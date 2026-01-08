// VbaExporterService.cs
using System;
using System.IO;
using System.IO.Compression;
using Excel = Microsoft.Office.Interop.Excel;
using VBIDE = Microsoft.Vbe.Interop;

namespace ExcelExporter.Services
{
    public class ExportOptions
    {
        public bool ExportModules { get; set; } = true;
        public bool ExportClasses { get; set; } = true;
        public bool ExportForms { get; set; } = true;
        public bool CreateZipArchive { get; set; } = false;
    }

    public class ExcelExporterService
    {
        /// <summary>
        /// Exports VBA components from an Excel workbook based on options.
        /// Returns the path to the output directory (or ZIP file if requested).
        /// </summary>
        public string ExportVbaFromExcel(string excelFilePath, ExportOptions options)
        {
            if (string.IsNullOrWhiteSpace(excelFilePath))
                throw new ArgumentException("Excel file path is required.", nameof(excelFilePath));

            if (!File.Exists(excelFilePath))
                throw new FileNotFoundException("Excel file not found.", excelFilePath);

            if (!options.ExportModules && !options.ExportClasses && !options.ExportForms)
                throw new InvalidOperationException("At least one export type must be selected.");

            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;

            try
            {
                excelApp = new Excel.Application
                {
                    Visible = false,
                    DisplayAlerts = false,
                    AutomationSecurity = Microsoft.Office.Core.MsoAutomationSecurity.msoAutomationSecurityLow
                };

                workbook = excelApp.Workbooks.Open(excelFilePath);

                // Verify VBA project access
                try
                {
                    _ = workbook.VBProject;
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException(
                        "Cannot access VBA project. Enable 'Trust access to the VBA project object model' in Excel Trust Center.", ex);
                }

                string outputDir = GetOutputDirectory(workbook);
                Directory.CreateDirectory(outputDir);

                ExportComponents(workbook, outputDir, options);

                if (options.CreateZipArchive)
                {
                    string zipPath = Path.Combine(workbook.Path,
                        Path.GetFileNameWithoutExtension(workbook.Name) + " Modules.zip");

                    if (File.Exists(zipPath))
                        File.Delete(zipPath);

                    ZipFile.CreateFromDirectory(outputDir, zipPath);
                    return zipPath;
                }

                return outputDir;
            }
            finally
            {
                // Proper COM cleanup
                if (workbook != null)
                {
                    workbook.Close(SaveChanges: false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                }

                if (excelApp != null)
                {
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }

                // Force GC to help release COM objects
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void ExportComponents(Excel.Workbook workbook, string destDir, ExportOptions options)
        {
            foreach (VBIDE.VBComponent comp in workbook.VBProject.VBComponents)
            {
                if (comp.CodeModule.CountOfLines <= 0) continue;

                string extension = null;
                bool shouldExport = false;

                switch (comp.Type)
                {
                    case VBIDE.vbext_ComponentType.vbext_ct_StdModule:
                        shouldExport = options.ExportModules;
                        extension = ".bas";
                        break;
                    case VBIDE.vbext_ComponentType.vbext_ct_ClassModule:
                    case VBIDE.vbext_ComponentType.vbext_ct_Document:
                        shouldExport = options.ExportClasses;
                        extension = ".cls";
                        break;
                    case VBIDE.vbext_ComponentType.vbext_ct_MSForm:
                        shouldExport = options.ExportForms;
                        extension = ".frm";
                        break;
                    default:
                        continue;
                }

                if (!shouldExport) continue;

                string filePath = Path.Combine(destDir, comp.Name + extension);
                if (File.Exists(filePath)) File.Delete(filePath);
                comp.Export(filePath);
                // ✅ .frx is auto-exported by Excel if it exists
            }
        }

        private string GetOutputDirectory(Excel.Workbook workbook)
        {
            string name = Path.GetFileNameWithoutExtension(workbook.Name);
            return Path.Combine(workbook.Path, $"{name} Modules");
        }
    }
}