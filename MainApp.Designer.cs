namespace ExcelExporter
{
    partial class MainApp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnSelectFile = new MaterialSkin.Controls.MaterialButton();
            this.lblFile = new MaterialSkin.Controls.MaterialLabel();
            this.btnExport = new MaterialSkin.Controls.MaterialButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpExportTypes = new MaterialSkin.Controls.MaterialCard();
            this.chkForms = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkModules = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkClasses = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkZipExport = new MaterialSkin.Controls.MaterialCheckbox();
            this.toggleThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.lblTheme = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpenFolder = new MaterialSkin.Controls.MaterialButton();
            this.btnSelectFolder = new MaterialSkin.Controls.MaterialButton();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.grpExportTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectFile.Depth = 0;
            this.btnSelectFile.HighEmphasis = true;
            this.btnSelectFile.Icon = null;
            this.btnSelectFile.Location = new System.Drawing.Point(71, 115);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSelectFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectFile.Size = new System.Drawing.Size(166, 36);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select Excel File...";
            this.btnSelectFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectFile.UseAccentColor = false;
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Depth = 0;
            this.lblFile.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.lblFile.Location = new System.Drawing.Point(68, 79);
            this.lblFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(109, 19);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "No file selected";
            // 
            // btnExport
            // 
            this.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExport.Depth = 0;
            this.btnExport.Enabled = false;
            this.btnExport.HighEmphasis = true;
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(71, 161);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExport.Name = "btnExport";
            this.btnExport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExport.Size = new System.Drawing.Size(109, 36);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export VBA";
            this.btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExport.UseAccentColor = false;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(2, 523);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(765, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // grpExportTypes
            // 
            this.grpExportTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpExportTypes.Controls.Add(this.chkForms);
            this.grpExportTypes.Controls.Add(this.chkModules);
            this.grpExportTypes.Controls.Add(this.chkClasses);
            this.grpExportTypes.Controls.Add(this.chkZipExport);
            this.grpExportTypes.Depth = 0;
            this.grpExportTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpExportTypes.Location = new System.Drawing.Point(472, 129);
            this.grpExportTypes.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.grpExportTypes.MouseState = MaterialSkin.MouseState.HOVER;
            this.grpExportTypes.Name = "grpExportTypes";
            this.grpExportTypes.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.grpExportTypes.Size = new System.Drawing.Size(295, 208);
            this.grpExportTypes.TabIndex = 2;
            // 
            // chkForms
            // 
            this.chkForms.AutoSize = true;
            this.chkForms.Checked = true;
            this.chkForms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkForms.Depth = 0;
            this.chkForms.Location = new System.Drawing.Point(10, 104);
            this.chkForms.Margin = new System.Windows.Forms.Padding(0);
            this.chkForms.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkForms.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkForms.Name = "chkForms";
            this.chkForms.ReadOnly = false;
            this.chkForms.Ripple = true;
            this.chkForms.Size = new System.Drawing.Size(189, 37);
            this.chkForms.TabIndex = 2;
            this.chkForms.Text = "User Forms (.frm/.frx)";
            this.chkForms.UseVisualStyleBackColor = true;
            // 
            // chkModules
            // 
            this.chkModules.AutoSize = true;
            this.chkModules.Checked = true;
            this.chkModules.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModules.Depth = 0;
            this.chkModules.Location = new System.Drawing.Point(10, 11);
            this.chkModules.Margin = new System.Windows.Forms.Padding(0);
            this.chkModules.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkModules.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkModules.Name = "chkModules";
            this.chkModules.ReadOnly = false;
            this.chkModules.Ripple = true;
            this.chkModules.Size = new System.Drawing.Size(210, 37);
            this.chkModules.TabIndex = 0;
            this.chkModules.Text = "Standard Modules (.bas)";
            this.chkModules.UseVisualStyleBackColor = true;
            // 
            // chkClasses
            // 
            this.chkClasses.AutoSize = true;
            this.chkClasses.Checked = true;
            this.chkClasses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClasses.Depth = 0;
            this.chkClasses.Location = new System.Drawing.Point(10, 48);
            this.chkClasses.Margin = new System.Windows.Forms.Padding(0);
            this.chkClasses.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkClasses.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkClasses.Name = "chkClasses";
            this.chkClasses.ReadOnly = false;
            this.chkClasses.Ripple = true;
            this.chkClasses.Size = new System.Drawing.Size(269, 37);
            this.chkClasses.TabIndex = 1;
            this.chkClasses.Text = "Class & Document Modules (.cls)";
            this.chkClasses.UseVisualStyleBackColor = true;
            // 
            // chkZipExport
            // 
            this.chkZipExport.AutoSize = true;
            this.chkZipExport.Depth = 0;
            this.chkZipExport.Location = new System.Drawing.Point(10, 140);
            this.chkZipExport.Margin = new System.Windows.Forms.Padding(0);
            this.chkZipExport.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkZipExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkZipExport.Name = "chkZipExport";
            this.chkZipExport.ReadOnly = false;
            this.chkZipExport.Ripple = true;
            this.chkZipExport.Size = new System.Drawing.Size(184, 37);
            this.chkZipExport.TabIndex = 3;
            this.chkZipExport.Text = "Export as ZIP archive";
            this.chkZipExport.UseVisualStyleBackColor = true;
            // 
            // toggleThemeSwitch
            // 
            this.toggleThemeSwitch.AutoSize = true;
            this.toggleThemeSwitch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toggleThemeSwitch.Depth = 0;
            this.toggleThemeSwitch.Location = new System.Drawing.Point(698, 70);
            this.toggleThemeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.toggleThemeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.toggleThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.toggleThemeSwitch.Name = "toggleThemeSwitch";
            this.toggleThemeSwitch.Ripple = true;
            this.toggleThemeSwitch.Size = new System.Drawing.Size(58, 37);
            this.toggleThemeSwitch.TabIndex = 4;
            this.toggleThemeSwitch.UseVisualStyleBackColor = false;
            this.toggleThemeSwitch.CheckedChanged += new System.EventHandler(this.toggleThemeSwitch_CheckedChanged);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Depth = 0;
            this.lblTheme.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTheme.Location = new System.Drawing.Point(662, 79);
            this.lblTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(34, 19);
            this.lblTheme.TabIndex = 5;
            this.lblTheme.Text = "Dark";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenFolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenFolder.Depth = 0;
            this.btnOpenFolder.HighEmphasis = true;
            this.btnOpenFolder.Icon = null;
            this.btnOpenFolder.Location = new System.Drawing.Point(186, 161);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOpenFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenFolder.Size = new System.Drawing.Size(117, 36);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnOpenFolder.UseAccentColor = false;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectFolder.Depth = 0;
            this.btnSelectFolder.HighEmphasis = true;
            this.btnSelectFolder.Icon = null;
            this.btnSelectFolder.Location = new System.Drawing.Point(250, 115);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectFolder.Size = new System.Drawing.Size(143, 36);
            this.btnSelectFolder.TabIndex = 5;
            this.btnSelectFolder.Text = "Select Folder...";
            this.btnSelectFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectFolder.UseAccentColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(2, 351);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(765, 135);
            this.txtLog.TabIndex = 6;
            this.txtLog.Visible = false;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 547);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.toggleThemeSwitch);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grpExportTypes);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApp";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VBA Module Exporter";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpExportTypes.ResumeLayout(false);
            this.grpExportTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSelectFile;
        private MaterialSkin.Controls.MaterialLabel lblFile;
        private MaterialSkin.Controls.MaterialButton btnExport;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private MaterialSkin.Controls.MaterialCard grpExportTypes;
        private MaterialSkin.Controls.MaterialCheckbox chkModules;
        private MaterialSkin.Controls.MaterialCheckbox chkClasses;
        private MaterialSkin.Controls.MaterialCheckbox chkForms;
        private MaterialSkin.Controls.MaterialCheckbox chkZipExport;
        private MaterialSkin.Controls.MaterialSwitch toggleThemeSwitch;
        private MaterialSkin.Controls.MaterialLabel lblTheme;
        private MaterialSkin.Controls.MaterialButton btnSelectFolder;
        private MaterialSkin.Controls.MaterialButton btnOpenFolder;
        private System.Windows.Forms.TextBox txtLog;






    }
}