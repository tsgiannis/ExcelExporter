using ExcelExporter.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace ExcelExporter
{
    public partial class MainApp : MaterialForm
    {
        // =========================
        // FREE EDITION STATE
        // =========================
        private string selectedExcelFile = null;
        private string lastExportPath = null;

        private ExcelExporterService exporter = new ExcelExporterService();

        // =========================
        // CONSTRUCTOR
        // =========================
        public MainApp()
        {
            InitializeComponent();

            this.Text = "Excel VBA Exporter – Free Edition";
            this.Icon = Properties.Resources.ExcelExporter;

            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(
                Primary.Blue600,
                Primary.Blue700,
                Primary.Blue200,
                Accent.LightBlue200,
                TextShade.WHITE);

            btnExport.Enabled = false;
            btnOpenFolder.Enabled = false;

            toolStripStatusLabel.Text =
                "Free Edition – Upgrade to PRO for batch export & CLI automation";
        }

        // =========================
        // SELECT FILE
        // =========================
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter =
                    "Excel Files (*.xls;*.xlsx;*.xlsm;*.xlsb;*.xlt;*.xltx;*.xltm;*.xlam)|" +
                    "*.xls;*.xlsx;*.xlsm;*.xlsb;*.xlt;*.xltx;*.xltm;*.xlam";

                ofd.Title = "Select an Excel file with VBA macros";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedExcelFile = ofd.FileName;
                    lblFile.Text = Path.GetFileName(selectedExcelFile);

                    btnExport.Enabled = true;
                    btnOpenFolder.Enabled = false;
                    toolStripStatusLabel.Text = "Ready to export";
                }
            }
        }

        // =========================
        // PRO FEATURE (FOLDER)
        // =========================
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Batch export from folders is available in the PRO edition.\n\n" +
                "PRO features include:\n" +
                "• Export VBA from entire folders\n" +
                "• Command-line automation\n" +
                "• CI / scripting integration",
                "PRO Feature",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // EXPORT (FREE = SINGLE FILE)
        // =========================
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedExcelFile))
            {
                MessageBox.Show(
                    "Please select an Excel file first.",
                    "No file selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ExportOptions options = new ExportOptions
            {
                ExportModules = chkModules.Checked,
                ExportClasses = chkClasses.Checked,
                ExportForms = chkForms.Checked,
                CreateZipArchive = chkZipExport.Checked
            };

            try
            {
                toolStripStatusLabel.Text = "Exporting...";
                Refresh();

                // ✅ CORRECT FREE-EDITION CALL
                lastExportPath = exporter.ExportVbaFromExcel(
                    selectedExcelFile,
                    options);

                btnOpenFolder.Enabled = true;
                toolStripStatusLabel.Text = "Export completed";

                MessageBox.Show(
                    "Export completed successfully.\n\nOutput:\n" + lastExportPath,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = "Export failed";

                MessageBox.Show(
                    ex.Message,
                    "Export failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // OPEN EXPORT FOLDER
        // =========================
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastExportPath))
            {
                MessageBox.Show(
                    "No export folder available.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string folderToOpen =
                File.Exists(lastExportPath)
                    ? Path.GetDirectoryName(lastExportPath)
                    : lastExportPath;

            if (Directory.Exists(folderToOpen))
            {
                Process.Start("explorer.exe", folderToOpen);
            }
            else
            {
                MessageBox.Show(
                    "Export folder no longer exists.",
                    "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // =========================
        // THEME
        // =========================
        private void toggleThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSkinManager.Instance.Theme =
                toggleThemeSwitch.Checked
                    ? MaterialSkinManager.Themes.DARK
                    : MaterialSkinManager.Themes.LIGHT;
        }
    }
}
