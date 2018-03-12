namespace btprox
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.m_checkboxUseWindowsLog = new System.Windows.Forms.CheckBox();
            this.m_checkboxSound = new System.Windows.Forms.CheckBox();
            this.m_comboLanguages = new System.Windows.Forms.ComboBox();
            this.m_labelLanguage = new System.Windows.Forms.Label();
            this.m_labelSeconds = new System.Windows.Forms.Label();
            this.m_labelScanPeriod = new System.Windows.Forms.Label();
            this.m_numericScanPeriod = new System.Windows.Forms.NumericUpDown();
            this.m_checkBoxShowBaloons = new System.Windows.Forms.CheckBox();
            this.buttonSaveOptions = new System.Windows.Forms.Button();
            this.buttonOptionsCancel = new System.Windows.Forms.Button();
            this.tabControlOptions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numericScanPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlOptions.Controls.Add(this.tabPage1);
            this.tabControlOptions.Location = new System.Drawing.Point(0, 0);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(220, 238);
            this.tabControlOptions.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.m_checkboxUseWindowsLog);
            this.tabPage1.Controls.Add(this.m_checkboxSound);
            this.tabPage1.Controls.Add(this.m_comboLanguages);
            this.tabPage1.Controls.Add(this.m_labelLanguage);
            this.tabPage1.Controls.Add(this.m_labelSeconds);
            this.tabPage1.Controls.Add(this.m_labelScanPeriod);
            this.tabPage1.Controls.Add(this.m_numericScanPeriod);
            this.tabPage1.Controls.Add(this.m_checkBoxShowBaloons);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(212, 212);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // m_checkboxUseWindowsLog
            // 
            this.m_checkboxUseWindowsLog.AutoSize = true;
            this.m_checkboxUseWindowsLog.Location = new System.Drawing.Point(11, 182);
            this.m_checkboxUseWindowsLog.Name = "m_checkboxUseWindowsLog";
            this.m_checkboxUseWindowsLog.Size = new System.Drawing.Size(113, 17);
            this.m_checkboxUseWindowsLog.TabIndex = 7;
            this.m_checkboxUseWindowsLog.Text = "Use Windows Log";
            this.m_checkboxUseWindowsLog.UseVisualStyleBackColor = true;
            // 
            // m_checkboxSound
            // 
            this.m_checkboxSound.AutoSize = true;
            this.m_checkboxSound.Location = new System.Drawing.Point(11, 150);
            this.m_checkboxSound.Name = "m_checkboxSound";
            this.m_checkboxSound.Size = new System.Drawing.Size(98, 17);
            this.m_checkboxSound.TabIndex = 6;
            this.m_checkboxSound.Text = "Sound enabled";
            this.m_checkboxSound.UseVisualStyleBackColor = true;
            // 
            // m_comboLanguages
            // 
            this.m_comboLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboLanguages.FormattingEnabled = true;
            this.m_comboLanguages.Location = new System.Drawing.Point(11, 33);
            this.m_comboLanguages.Name = "m_comboLanguages";
            this.m_comboLanguages.Size = new System.Drawing.Size(97, 21);
            this.m_comboLanguages.TabIndex = 1;
            // 
            // m_labelLanguage
            // 
            this.m_labelLanguage.AutoSize = true;
            this.m_labelLanguage.Location = new System.Drawing.Point(8, 17);
            this.m_labelLanguage.Name = "m_labelLanguage";
            this.m_labelLanguage.Size = new System.Drawing.Size(58, 13);
            this.m_labelLanguage.TabIndex = 0;
            this.m_labelLanguage.Text = "Language:";
            // 
            // m_labelSeconds
            // 
            this.m_labelSeconds.AutoSize = true;
            this.m_labelSeconds.Location = new System.Drawing.Point(75, 116);
            this.m_labelSeconds.Name = "m_labelSeconds";
            this.m_labelSeconds.Size = new System.Drawing.Size(47, 13);
            this.m_labelSeconds.TabIndex = 5;
            this.m_labelSeconds.Text = "seconds";
            // 
            // m_labelScanPeriod
            // 
            this.m_labelScanPeriod.AutoSize = true;
            this.m_labelScanPeriod.Location = new System.Drawing.Point(8, 98);
            this.m_labelScanPeriod.Name = "m_labelScanPeriod";
            this.m_labelScanPeriod.Size = new System.Drawing.Size(65, 13);
            this.m_labelScanPeriod.TabIndex = 3;
            this.m_labelScanPeriod.Text = "Scan Period";
            // 
            // m_numericScanPeriod
            // 
            this.m_numericScanPeriod.Location = new System.Drawing.Point(11, 114);
            this.m_numericScanPeriod.Name = "m_numericScanPeriod";
            this.m_numericScanPeriod.Size = new System.Drawing.Size(58, 20);
            this.m_numericScanPeriod.TabIndex = 4;
            // 
            // m_checkBoxShowBaloons
            // 
            this.m_checkBoxShowBaloons.AutoSize = true;
            this.m_checkBoxShowBaloons.Location = new System.Drawing.Point(11, 69);
            this.m_checkBoxShowBaloons.Name = "m_checkBoxShowBaloons";
            this.m_checkBoxShowBaloons.Size = new System.Drawing.Size(152, 17);
            this.m_checkBoxShowBaloons.TabIndex = 2;
            this.m_checkBoxShowBaloons.Text = "Show Notification Balloons";
            this.m_checkBoxShowBaloons.UseVisualStyleBackColor = true;
            // 
            // buttonSaveOptions
            // 
            this.buttonSaveOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveOptions.Location = new System.Drawing.Point(12, 244);
            this.buttonSaveOptions.Name = "buttonSaveOptions";
            this.buttonSaveOptions.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveOptions.TabIndex = 1;
            this.buttonSaveOptions.Text = "&Save";
            this.buttonSaveOptions.UseVisualStyleBackColor = true;
            // 
            // buttonOptionsCancel
            // 
            this.buttonOptionsCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOptionsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOptionsCancel.Location = new System.Drawing.Point(133, 244);
            this.buttonOptionsCancel.Name = "buttonOptionsCancel";
            this.buttonOptionsCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonOptionsCancel.TabIndex = 2;
            this.buttonOptionsCancel.Text = "&Cancel";
            this.buttonOptionsCancel.UseVisualStyleBackColor = true;
            this.buttonOptionsCancel.Click += new System.EventHandler(this.ButtonOptionsCancelClick);
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.buttonSaveOptions;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOptionsCancel;
            this.ClientSize = new System.Drawing.Size(220, 272);
            this.Controls.Add(this.buttonOptionsCancel);
            this.Controls.Add(this.buttonSaveOptions);
            this.Controls.Add(this.tabControlOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.Text = "OptionsForm";
            this.Load += new System.EventHandler(this.OptionsFormLoad);
            this.tabControlOptions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numericScanPeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.Button buttonSaveOptions;
        private System.Windows.Forms.Button buttonOptionsCancel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox m_checkboxUseWindowsLog;
        private System.Windows.Forms.CheckBox m_checkboxSound;
        private System.Windows.Forms.ComboBox m_comboLanguages;
        private System.Windows.Forms.Label m_labelLanguage;
        private System.Windows.Forms.Label m_labelSeconds;
        private System.Windows.Forms.Label m_labelScanPeriod;
        private System.Windows.Forms.NumericUpDown m_numericScanPeriod;
        private System.Windows.Forms.CheckBox m_checkBoxShowBaloons;
    }
}