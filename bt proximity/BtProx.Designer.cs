namespace btprox
{
    partial class BtProxLock
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BtProxLock));
            this.m_exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_abortPendingLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.buttonSelectUnlockCommand = new System.Windows.Forms.Button();
            this.m_buttonHide = new System.Windows.Forms.Button();
            this.buttonSelectLockCommand = new System.Windows.Forms.Button();
            this.m_buttonStart = new System.Windows.Forms.Button();
            this.m_buttonStop = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.m_labelUsedDevices = new System.Windows.Forms.Label();
            this.m_labelReleaseCommand = new System.Windows.Forms.Label();
            this.m_buttonExit = new System.Windows.Forms.Button();
            this.m_labelLockCommand = new System.Windows.Forms.Label();
            this.m_labelTimeout = new System.Windows.Forms.Label();
            this.unlockCommandBox = new System.Windows.Forms.TextBox();
            this.m_labelMinutes = new System.Windows.Forms.Label();
            this.timeoutBox = new System.Windows.Forms.NumericUpDown();
            this.lockCommandBox = new System.Windows.Forms.TextBox();
            this.m_checkBoxSkipLock = new System.Windows.Forms.CheckBox();
            this.m_deviceTextbox = new System.Windows.Forms.TextBox();
            this.lockCommandArguments = new System.Windows.Forms.TextBox();
            this.m_labelLockArguments = new System.Windows.Forms.Label();
            this.m_labelReleaseArguments = new System.Windows.Forms.Label();
            this.unlockCommandArguments = new System.Windows.Forms.TextBox();
            this.trayMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_exitToolStripMenuItem
            // 
            this.m_exitToolStripMenuItem.Name = "m_exitToolStripMenuItem";
            this.m_exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.m_exitToolStripMenuItem.Text = "E&xit";
            this.m_exitToolStripMenuItem.Click += new System.EventHandler(this.ExitClickHandler);
            // 
            // m_aboutToolStripMenuItem
            // 
            this.m_aboutToolStripMenuItem.Name = "m_aboutToolStripMenuItem";
            this.m_aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.m_aboutToolStripMenuItem.Text = "&About";
            this.m_aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutMenuItemHandler);
            // 
            // m_settingsToolStripMenuItem
            // 
            this.m_settingsToolStripMenuItem.Name = "m_settingsToolStripMenuItem";
            this.m_settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.m_settingsToolStripMenuItem.Text = "&Options";
            this.m_settingsToolStripMenuItem.Click += new System.EventHandler(this.OptionsMenuItem);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Bluetooth Proximity Lock";
            this.notifyIcon.ContextMenuStrip = this.trayMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Stopped";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickHandler);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIconDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_restoreToolStripMenuItem,
            this.m_abortPendingLockToolStripMenuItem,
            this.m_aboutToolStripMenuItem,
            this.m_exitToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(177, 92);
            // 
            // m_restoreToolStripMenuItem
            // 
            this.m_restoreToolStripMenuItem.Name = "m_restoreToolStripMenuItem";
            this.m_restoreToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.m_restoreToolStripMenuItem.Text = "&Restore";
            this.m_restoreToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuRestore);
            // 
            // m_abortPendingLockToolStripMenuItem
            // 
            this.m_abortPendingLockToolStripMenuItem.Name = "m_abortPendingLockToolStripMenuItem";
            this.m_abortPendingLockToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.m_abortPendingLockToolStripMenuItem.Text = "Abo&rt pending lock";
            this.m_abortPendingLockToolStripMenuItem.Click += new System.EventHandler(this.AbortPendingLockHandler);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 306);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(317, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "Stopped";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel.Text = "Stopped";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_settingsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(317, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // buttonSelectUnlockCommand
            // 
            this.buttonSelectUnlockCommand.Location = new System.Drawing.Point(275, 217);
            this.buttonSelectUnlockCommand.Name = "buttonSelectUnlockCommand";
            this.buttonSelectUnlockCommand.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectUnlockCommand.TabIndex = 15;
            this.buttonSelectUnlockCommand.Text = "...";
            this.buttonSelectUnlockCommand.UseVisualStyleBackColor = true;
            this.buttonSelectUnlockCommand.Visible = false;
            this.buttonSelectUnlockCommand.Click += new System.EventHandler(this.SelectUnlockCommand);
            // 
            // m_buttonHide
            // 
            this.m_buttonHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonHide.Location = new System.Drawing.Point(159, 280);
            this.m_buttonHide.Name = "m_buttonHide";
            this.m_buttonHide.Size = new System.Drawing.Size(70, 23);
            this.m_buttonHide.TabIndex = 20;
            this.m_buttonHide.Text = "&Hide";
            this.m_buttonHide.UseVisualStyleBackColor = true;
            this.m_buttonHide.Click += new System.EventHandler(this.HideClickHandler);
            // 
            // buttonSelectLockCommand
            // 
            this.buttonSelectLockCommand.Location = new System.Drawing.Point(275, 115);
            this.buttonSelectLockCommand.Name = "buttonSelectLockCommand";
            this.buttonSelectLockCommand.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectLockCommand.TabIndex = 9;
            this.buttonSelectLockCommand.Text = "...";
            this.buttonSelectLockCommand.UseVisualStyleBackColor = true;
            this.buttonSelectLockCommand.Visible = false;
            this.buttonSelectLockCommand.Click += new System.EventHandler(this.SelectLockCommand);
            // 
            // m_buttonStart
            // 
            this.m_buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonStart.Location = new System.Drawing.Point(7, 280);
            this.m_buttonStart.Name = "m_buttonStart";
            this.m_buttonStart.Size = new System.Drawing.Size(70, 23);
            this.m_buttonStart.TabIndex = 18;
            this.m_buttonStart.Text = "&Start";
            this.m_buttonStart.UseVisualStyleBackColor = true;
            this.m_buttonStart.Click += new System.EventHandler(this.StartClickHandler);
            // 
            // m_buttonStop
            // 
            this.m_buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonStop.Location = new System.Drawing.Point(83, 280);
            this.m_buttonStop.Name = "m_buttonStop";
            this.m_buttonStop.Size = new System.Drawing.Size(70, 23);
            this.m_buttonStop.TabIndex = 19;
            this.m_buttonStop.Text = "S&top";
            this.m_buttonStop.UseVisualStyleBackColor = true;
            this.m_buttonStop.Click += new System.EventHandler(this.StopClickHandler);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(275, 38);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(30, 23);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "...";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.SelectDeviceClickHandler);
            // 
            // m_labelUsedDevices
            // 
            this.m_labelUsedDevices.AutoSize = true;
            this.m_labelUsedDevices.Location = new System.Drawing.Point(12, 43);
            this.m_labelUsedDevices.Name = "m_labelUsedDevices";
            this.m_labelUsedDevices.Size = new System.Drawing.Size(70, 13);
            this.m_labelUsedDevices.TabIndex = 1;
            this.m_labelUsedDevices.Text = "Used device:";
            // 
            // m_labelReleaseCommand
            // 
            this.m_labelReleaseCommand.Location = new System.Drawing.Point(12, 201);
            this.m_labelReleaseCommand.Name = "m_labelReleaseCommand";
            this.m_labelReleaseCommand.Size = new System.Drawing.Size(257, 13);
            this.m_labelReleaseCommand.TabIndex = 13;
            this.m_labelReleaseCommand.Text = "Release command:";
            this.m_labelReleaseCommand.Visible = false;
            // 
            // m_buttonExit
            // 
            this.m_buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_buttonExit.Location = new System.Drawing.Point(235, 280);
            this.m_buttonExit.Name = "m_buttonExit";
            this.m_buttonExit.Size = new System.Drawing.Size(70, 23);
            this.m_buttonExit.TabIndex = 21;
            this.m_buttonExit.Text = "E&xit";
            this.m_buttonExit.UseVisualStyleBackColor = true;
            this.m_buttonExit.Click += new System.EventHandler(this.ExitClickHandler);
            // 
            // m_labelLockCommand
            // 
            this.m_labelLockCommand.Location = new System.Drawing.Point(12, 99);
            this.m_labelLockCommand.Name = "m_labelLockCommand";
            this.m_labelLockCommand.Size = new System.Drawing.Size(257, 13);
            this.m_labelLockCommand.TabIndex = 7;
            this.m_labelLockCommand.Text = "Lock command:";
            this.m_labelLockCommand.Click += new System.EventHandler(this.m_labelLockCommand_Click);
            // 
            // m_labelTimeout
            // 
            this.m_labelTimeout.AutoSize = true;
            this.m_labelTimeout.Location = new System.Drawing.Point(12, 71);
            this.m_labelTimeout.Name = "m_labelTimeout";
            this.m_labelTimeout.Size = new System.Drawing.Size(48, 13);
            this.m_labelTimeout.TabIndex = 4;
            this.m_labelTimeout.Text = "Timeout:";
            // 
            // unlockCommandBox
            // 
            this.unlockCommandBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.unlockCommandBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.unlockCommandBox.Location = new System.Drawing.Point(12, 217);
            this.unlockCommandBox.Name = "unlockCommandBox";
            this.unlockCommandBox.Size = new System.Drawing.Size(257, 20);
            this.unlockCommandBox.TabIndex = 14;
            this.unlockCommandBox.Visible = false;
            this.unlockCommandBox.TextChanged += new System.EventHandler(this.UnlockCommandChangedHandler);
            // 
            // m_labelMinutes
            // 
            this.m_labelMinutes.AutoSize = true;
            this.m_labelMinutes.Location = new System.Drawing.Point(219, 71);
            this.m_labelMinutes.Name = "m_labelMinutes";
            this.m_labelMinutes.Size = new System.Drawing.Size(44, 13);
            this.m_labelMinutes.TabIndex = 6;
            this.m_labelMinutes.Text = "Minutes";
            // 
            // timeoutBox
            // 
            this.timeoutBox.Location = new System.Drawing.Point(143, 69);
            this.timeoutBox.Name = "timeoutBox";
            this.timeoutBox.Size = new System.Drawing.Size(70, 20);
            this.timeoutBox.TabIndex = 5;
            this.timeoutBox.ValueChanged += new System.EventHandler(this.TimeoutValueChanged);
            // 
            // lockCommandBox
            // 
            this.lockCommandBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lockCommandBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.lockCommandBox.Location = new System.Drawing.Point(12, 115);
            this.lockCommandBox.Name = "lockCommandBox";
            this.lockCommandBox.Size = new System.Drawing.Size(257, 20);
            this.lockCommandBox.TabIndex = 8;
            this.lockCommandBox.Visible = false;
            this.lockCommandBox.TextChanged += new System.EventHandler(this.LockCommandChangedHandler);
            // 
            // m_checkBoxSkipLock
            // 
            this.m_checkBoxSkipLock.AutoSize = true;
            this.m_checkBoxSkipLock.Checked = true;
            this.m_checkBoxSkipLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_checkBoxSkipLock.Location = new System.Drawing.Point(12, 167);
            this.m_checkBoxSkipLock.Name = "m_checkBoxSkipLock";
            this.m_checkBoxSkipLock.Size = new System.Drawing.Size(187, 17);
            this.m_checkBoxSkipLock.TabIndex = 12;
            this.m_checkBoxSkipLock.Text = "Don\'t lock (only run the command)";
            this.m_checkBoxSkipLock.UseVisualStyleBackColor = true;
            this.m_checkBoxSkipLock.Visible = false;
            this.m_checkBoxSkipLock.CheckedChanged += new System.EventHandler(this.LockSkipStateChanged);
            // 
            // m_deviceTextbox
            // 
            this.m_deviceTextbox.Enabled = false;
            this.m_deviceTextbox.Location = new System.Drawing.Point(143, 40);
            this.m_deviceTextbox.Name = "m_deviceTextbox";
            this.m_deviceTextbox.ReadOnly = true;
            this.m_deviceTextbox.Size = new System.Drawing.Size(126, 20);
            this.m_deviceTextbox.TabIndex = 2;
            // 
            // lockCommandArguments
            // 
            this.lockCommandArguments.Location = new System.Drawing.Point(83, 141);
            this.lockCommandArguments.Name = "lockCommandArguments";
            this.lockCommandArguments.Size = new System.Drawing.Size(220, 20);
            this.lockCommandArguments.TabIndex = 11;
            this.lockCommandArguments.Visible = false;
            this.lockCommandArguments.TextChanged += new System.EventHandler(this.LockArgumentsChangedHandler);
            // 
            // m_labelLockArguments
            // 
            this.m_labelLockArguments.Location = new System.Drawing.Point(12, 144);
            this.m_labelLockArguments.Name = "m_labelLockArguments";
            this.m_labelLockArguments.Size = new System.Drawing.Size(65, 13);
            this.m_labelLockArguments.TabIndex = 10;
            this.m_labelLockArguments.Text = "Arguments:";
            this.m_labelLockArguments.Visible = false;
            // 
            // m_labelReleaseArguments
            // 
            this.m_labelReleaseArguments.Location = new System.Drawing.Point(12, 246);
            this.m_labelReleaseArguments.Name = "m_labelReleaseArguments";
            this.m_labelReleaseArguments.Size = new System.Drawing.Size(65, 13);
            this.m_labelReleaseArguments.TabIndex = 16;
            this.m_labelReleaseArguments.Text = "Arguments:";
            this.m_labelReleaseArguments.Visible = false;
            // 
            // unlockCommandArguments
            // 
            this.unlockCommandArguments.Location = new System.Drawing.Point(83, 243);
            this.unlockCommandArguments.Name = "unlockCommandArguments";
            this.unlockCommandArguments.Size = new System.Drawing.Size(222, 20);
            this.unlockCommandArguments.TabIndex = 17;
            this.unlockCommandArguments.Visible = false;
            this.unlockCommandArguments.TextChanged += new System.EventHandler(this.UnlockArgumentsChangedHandler);
            // 
            // BtProxLock
            // 
            this.AcceptButton = this.m_buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_buttonExit;
            this.ClientSize = new System.Drawing.Size(317, 328);
            this.Controls.Add(this.m_deviceTextbox);
            this.Controls.Add(this.m_labelLockArguments);
            this.Controls.Add(this.unlockCommandArguments);
            this.Controls.Add(this.m_labelReleaseArguments);
            this.Controls.Add(this.lockCommandArguments);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.timeoutBox);
            this.Controls.Add(this.lockCommandBox);
            this.Controls.Add(this.m_checkBoxSkipLock);
            this.Controls.Add(this.m_labelMinutes);
            this.Controls.Add(this.m_labelTimeout);
            this.Controls.Add(this.m_buttonExit);
            this.Controls.Add(this.m_labelLockCommand);
            this.Controls.Add(this.m_labelUsedDevices);
            this.Controls.Add(this.unlockCommandBox);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.m_buttonStop);
            this.Controls.Add(this.m_labelReleaseCommand);
            this.Controls.Add(this.m_buttonStart);
            this.Controls.Add(this.m_buttonHide);
            this.Controls.Add(this.buttonSelectLockCommand);
            this.Controls.Add(this.buttonSelectUnlockCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "BtProxLock";
            this.Text = "Bluetooth Proximity Lock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingHandler);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosedHandler);
            this.Load += new System.EventHandler(this.BtProxLockLoad);
            this.LocationChanged += new System.EventHandler(this.BtProxLockLocationChanged);
            this.SizeChanged += new System.EventHandler(this.BtProxSizeChanged);
            this.trayMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem m_restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_abortPendingLockToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem m_settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonSelectUnlockCommand;
        private System.Windows.Forms.Button m_buttonHide;
        private System.Windows.Forms.Button buttonSelectLockCommand;
        private System.Windows.Forms.Button m_buttonStart;
        private System.Windows.Forms.Button m_buttonStop;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label m_labelUsedDevices;
        private System.Windows.Forms.Label m_labelReleaseCommand;
        private System.Windows.Forms.Button m_buttonExit;
        private System.Windows.Forms.Label m_labelLockCommand;
        private System.Windows.Forms.Label m_labelTimeout;
        private System.Windows.Forms.TextBox unlockCommandBox;
        private System.Windows.Forms.Label m_labelMinutes;
        private System.Windows.Forms.NumericUpDown timeoutBox;
        private System.Windows.Forms.TextBox lockCommandBox;
        private System.Windows.Forms.CheckBox m_checkBoxSkipLock;
        private System.Windows.Forms.TextBox m_deviceTextbox;
        private System.Windows.Forms.TextBox lockCommandArguments;
        private System.Windows.Forms.Label m_labelLockArguments;
        private System.Windows.Forms.Label m_labelReleaseArguments;
        private System.Windows.Forms.TextBox unlockCommandArguments;
    }
}

