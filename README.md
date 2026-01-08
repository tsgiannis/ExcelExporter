# 📊 VBA Module Exporter

A lightweight Windows tool to **export VBA code modules** from Excel files (`.xls`, `.xlsx`, `.xlsm`, `.xlsb`, etc.) into plain text files — perfect for **version control**, **backup**, or **code review**.

![Excel Exporter Screenshot](ExcelExporter.png) 
![Excel (Dark) Exporter Screenshot](ExcelExporterDark.png) 

## ✨ Features

- Export **Standard Modules** (`.bas`), **Class Modules** (`.cls`), and **UserForms** (`.frm` + `.frx`)
- Supports **all Excel file types** that may contain VBA
- **Batch export** entire folders of Excel files
- Optional **ZIP archive** of exported code
- Resilient error handling (e.g., skips password-protected projects)
- Clean Material Design UI with light/dark mode
- **No dependencies** beyond .NET Framework + Excel (via COM)

## 🛠️ Requirements

- Windows 7+
- Microsoft Excel (2010 or later)
- .NET Framework 4.7.2+
- "Trust access to the VBA project object model" **enabled** in Excel:
  > File → Options → Trust Center → Macro Settings → ✅ *Trust access to the VBA project object model*

## 📥 Download

> [Latest Release](https://github.com/yourusername/vba-exporter/releases) (coming soon)

Or build from source (Visual Studio 2022).

## 🔒 Privacy & Safety

- **100% offline** — no internet access
- **No data collection**
- Source code fully open for audit

## 📜 License

MIT License — free for personal and commercial use.

---

Made with ❤️ for Excel developers, auditors, and automation engineers.
