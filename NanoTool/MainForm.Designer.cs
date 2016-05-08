namespace NanoTool {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.nanoServerFolderLabel = new System.Windows.Forms.Label();
            this.nanoServerFolderBrowseButton = new System.Windows.Forms.Button();
            this.nanoServerFolderTextBox = new System.Windows.Forms.TextBox();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.outputFolderBrowseButton = new System.Windows.Forms.Button();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.domainNameLabel = new System.Windows.Forms.Label();
            this.domainNameTextBox = new System.Windows.Forms.TextBox();
            this.ipv4AddressLabel = new System.Windows.Forms.Label();
            this.ipv4AddressTextBox = new System.Windows.Forms.TextBox();
            this.ipv4SubnetMaskLabel = new System.Windows.Forms.Label();
            this.ipv4SubnetMaskTextBox = new System.Windows.Forms.TextBox();
            this.ipv4GatewayLabel = new System.Windows.Forms.Label();
            this.ipv4GatewayTextBox = new System.Windows.Forms.TextBox();
            this.ipv4DNSPrimaryTextBox = new System.Windows.Forms.TextBox();
            this.ipv4DNSSecondaryTextBox = new System.Windows.Forms.TextBox();
            this.ipv4DNS1Label = new System.Windows.Forms.Label();
            this.ipv4DNS2Label = new System.Windows.Forms.Label();
            this.diskSizeLabel = new System.Windows.Forms.Label();
            this.diskSizeMagnitudeDropdown = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.editionLabel = new System.Windows.Forms.Label();
            this.editionStandardButton = new System.Windows.Forms.RadioButton();
            this.editionDatacenterButton = new System.Windows.Forms.RadioButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.diskSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.remoteManagementPortEnabled = new System.Windows.Forms.CheckBox();
            this.interfaceNameLabel = new System.Windows.Forms.Label();
            this.interfaceNameTextBox = new System.Windows.Forms.TextBox();
            this.driversPathTextBox = new System.Windows.Forms.TextBox();
            this.driversPathBrowseButton = new System.Windows.Forms.Button();
            this.unattendedTextBox = new System.Windows.Forms.TextBox();
            this.unattendedBrowseButton = new System.Windows.Forms.Button();
            this.driversPathLabel = new System.Windows.Forms.Label();
            this.unattendedLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.packagesBox = new System.Windows.Forms.CheckedListBox();
            this.packagesLabel = new System.Windows.Forms.Label();
            this.editionGroup = new System.Windows.Forms.GroupBox();
            this.unattendedOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.nanoServerBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.driversPathBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.vmTypeBox = new System.Windows.Forms.GroupBox();
            this.vmHost = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.vmGuest = new System.Windows.Forms.RadioButton();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskSizeUpDown)).BeginInit();
            this.editionGroup.SuspendLayout();
            this.vmTypeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 725);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(441, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // nanoServerFolderLabel
            // 
            this.nanoServerFolderLabel.AutoSize = true;
            this.nanoServerFolderLabel.Location = new System.Drawing.Point(11, 19);
            this.nanoServerFolderLabel.Name = "nanoServerFolderLabel";
            this.nanoServerFolderLabel.Size = new System.Drawing.Size(96, 13);
            this.nanoServerFolderLabel.TabIndex = 1;
            this.nanoServerFolderLabel.Text = "NanoServer Folder";
            // 
            // nanoServerFolderBrowseButton
            // 
            this.nanoServerFolderBrowseButton.Location = new System.Drawing.Point(113, 14);
            this.nanoServerFolderBrowseButton.Name = "nanoServerFolderBrowseButton";
            this.nanoServerFolderBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.nanoServerFolderBrowseButton.TabIndex = 2;
            this.nanoServerFolderBrowseButton.Text = "Browse...";
            this.nanoServerFolderBrowseButton.UseVisualStyleBackColor = true;
            this.nanoServerFolderBrowseButton.Click += new System.EventHandler(this.nanoServerFolderBrowseButton_Click);
            // 
            // nanoServerFolderTextBox
            // 
            this.nanoServerFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nanoServerFolderTextBox.Location = new System.Drawing.Point(194, 16);
            this.nanoServerFolderTextBox.Name = "nanoServerFolderTextBox";
            this.nanoServerFolderTextBox.ReadOnly = true;
            this.nanoServerFolderTextBox.Size = new System.Drawing.Size(236, 20);
            this.nanoServerFolderTextBox.TabIndex = 3;
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.AutoSize = true;
            this.outputFolderLabel.Location = new System.Drawing.Point(36, 54);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(71, 13);
            this.outputFolderLabel.TabIndex = 4;
            this.outputFolderLabel.Text = "Output Folder";
            // 
            // outputFolderBrowseButton
            // 
            this.outputFolderBrowseButton.Location = new System.Drawing.Point(113, 49);
            this.outputFolderBrowseButton.Name = "outputFolderBrowseButton";
            this.outputFolderBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.outputFolderBrowseButton.TabIndex = 5;
            this.outputFolderBrowseButton.Text = "Browse...";
            this.outputFolderBrowseButton.UseVisualStyleBackColor = true;
            this.outputFolderBrowseButton.Click += new System.EventHandler(this.outputFolderBrowseButton_Click);
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFolderTextBox.Location = new System.Drawing.Point(194, 51);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.ReadOnly = true;
            this.outputFolderTextBox.Size = new System.Drawing.Size(236, 20);
            this.outputFolderTextBox.TabIndex = 6;
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostnameTextBox.Location = new System.Drawing.Point(113, 82);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.Size = new System.Drawing.Size(317, 20);
            this.hostnameTextBox.TabIndex = 7;
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Location = new System.Drawing.Point(52, 85);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(55, 13);
            this.hostnameLabel.TabIndex = 8;
            this.hostnameLabel.Text = "Hostname";
            // 
            // domainNameLabel
            // 
            this.domainNameLabel.AutoSize = true;
            this.domainNameLabel.Location = new System.Drawing.Point(33, 111);
            this.domainNameLabel.Name = "domainNameLabel";
            this.domainNameLabel.Size = new System.Drawing.Size(74, 13);
            this.domainNameLabel.TabIndex = 9;
            this.domainNameLabel.Text = "Domain Name";
            // 
            // domainNameTextBox
            // 
            this.domainNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.domainNameTextBox.Location = new System.Drawing.Point(113, 108);
            this.domainNameTextBox.Name = "domainNameTextBox";
            this.domainNameTextBox.Size = new System.Drawing.Size(317, 20);
            this.domainNameTextBox.TabIndex = 10;
            // 
            // ipv4AddressLabel
            // 
            this.ipv4AddressLabel.AutoSize = true;
            this.ipv4AddressLabel.Location = new System.Drawing.Point(36, 137);
            this.ipv4AddressLabel.Name = "ipv4AddressLabel";
            this.ipv4AddressLabel.Size = new System.Drawing.Size(70, 13);
            this.ipv4AddressLabel.TabIndex = 11;
            this.ipv4AddressLabel.Text = "IPv4 Address";
            // 
            // ipv4AddressTextBox
            // 
            this.ipv4AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipv4AddressTextBox.Location = new System.Drawing.Point(113, 134);
            this.ipv4AddressTextBox.Name = "ipv4AddressTextBox";
            this.ipv4AddressTextBox.Size = new System.Drawing.Size(317, 20);
            this.ipv4AddressTextBox.TabIndex = 12;
            // 
            // ipv4SubnetMaskLabel
            // 
            this.ipv4SubnetMaskLabel.AutoSize = true;
            this.ipv4SubnetMaskLabel.Location = new System.Drawing.Point(12, 162);
            this.ipv4SubnetMaskLabel.Name = "ipv4SubnetMaskLabel";
            this.ipv4SubnetMaskLabel.Size = new System.Drawing.Size(95, 13);
            this.ipv4SubnetMaskLabel.TabIndex = 13;
            this.ipv4SubnetMaskLabel.Text = "IPv4 Subnet Mask";
            // 
            // ipv4SubnetMaskTextBox
            // 
            this.ipv4SubnetMaskTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipv4SubnetMaskTextBox.Location = new System.Drawing.Point(113, 159);
            this.ipv4SubnetMaskTextBox.Name = "ipv4SubnetMaskTextBox";
            this.ipv4SubnetMaskTextBox.Size = new System.Drawing.Size(317, 20);
            this.ipv4SubnetMaskTextBox.TabIndex = 14;
            // 
            // ipv4GatewayLabel
            // 
            this.ipv4GatewayLabel.AutoSize = true;
            this.ipv4GatewayLabel.Location = new System.Drawing.Point(32, 188);
            this.ipv4GatewayLabel.Name = "ipv4GatewayLabel";
            this.ipv4GatewayLabel.Size = new System.Drawing.Size(74, 13);
            this.ipv4GatewayLabel.TabIndex = 15;
            this.ipv4GatewayLabel.Text = "IPv4 Gateway";
            // 
            // ipv4GatewayTextBox
            // 
            this.ipv4GatewayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipv4GatewayTextBox.Location = new System.Drawing.Point(113, 185);
            this.ipv4GatewayTextBox.Name = "ipv4GatewayTextBox";
            this.ipv4GatewayTextBox.Size = new System.Drawing.Size(317, 20);
            this.ipv4GatewayTextBox.TabIndex = 16;
            // 
            // ipv4DNSPrimaryTextBox
            // 
            this.ipv4DNSPrimaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipv4DNSPrimaryTextBox.Location = new System.Drawing.Point(113, 211);
            this.ipv4DNSPrimaryTextBox.Name = "ipv4DNSPrimaryTextBox";
            this.ipv4DNSPrimaryTextBox.Size = new System.Drawing.Size(317, 20);
            this.ipv4DNSPrimaryTextBox.TabIndex = 17;
            // 
            // ipv4DNSSecondaryTextBox
            // 
            this.ipv4DNSSecondaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipv4DNSSecondaryTextBox.Location = new System.Drawing.Point(113, 237);
            this.ipv4DNSSecondaryTextBox.Name = "ipv4DNSSecondaryTextBox";
            this.ipv4DNSSecondaryTextBox.Size = new System.Drawing.Size(317, 20);
            this.ipv4DNSSecondaryTextBox.TabIndex = 18;
            // 
            // ipv4DNS1Label
            // 
            this.ipv4DNS1Label.AutoSize = true;
            this.ipv4DNS1Label.Location = new System.Drawing.Point(43, 214);
            this.ipv4DNS1Label.Name = "ipv4DNS1Label";
            this.ipv4DNS1Label.Size = new System.Drawing.Size(64, 13);
            this.ipv4DNS1Label.TabIndex = 19;
            this.ipv4DNS1Label.Text = "IPv4 DNS 1";
            // 
            // ipv4DNS2Label
            // 
            this.ipv4DNS2Label.AutoSize = true;
            this.ipv4DNS2Label.Location = new System.Drawing.Point(42, 240);
            this.ipv4DNS2Label.Name = "ipv4DNS2Label";
            this.ipv4DNS2Label.Size = new System.Drawing.Size(64, 13);
            this.ipv4DNS2Label.TabIndex = 20;
            this.ipv4DNS2Label.Text = "IPv4 DNS 2";
            // 
            // diskSizeLabel
            // 
            this.diskSizeLabel.AutoSize = true;
            this.diskSizeLabel.Location = new System.Drawing.Point(31, 267);
            this.diskSizeLabel.Name = "diskSizeLabel";
            this.diskSizeLabel.Size = new System.Drawing.Size(75, 13);
            this.diskSizeLabel.TabIndex = 22;
            this.diskSizeLabel.Text = "Disk Size (GB)";
            // 
            // diskSizeMagnitudeDropdown
            // 
            this.diskSizeMagnitudeDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diskSizeMagnitudeDropdown.FormattingEnabled = true;
            this.diskSizeMagnitudeDropdown.Items.AddRange(new object[] {
            "GB",
            "TB"});
            this.diskSizeMagnitudeDropdown.Location = new System.Drawing.Point(345, 264);
            this.diskSizeMagnitudeDropdown.Name = "diskSizeMagnitudeDropdown";
            this.diskSizeMagnitudeDropdown.Size = new System.Drawing.Size(85, 21);
            this.diskSizeMagnitudeDropdown.TabIndex = 25;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(113, 291);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(317, 20);
            this.passwordTextBox.TabIndex = 26;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(22, 294);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(85, 13);
            this.passwordLabel.TabIndex = 27;
            this.passwordLabel.Text = "Admin Password";
            // 
            // editionLabel
            // 
            this.editionLabel.AutoSize = true;
            this.editionLabel.Location = new System.Drawing.Point(68, 338);
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(39, 13);
            this.editionLabel.TabIndex = 28;
            this.editionLabel.Text = "Edition";
            // 
            // editionStandardButton
            // 
            this.editionStandardButton.AutoSize = true;
            this.editionStandardButton.Checked = true;
            this.editionStandardButton.Location = new System.Drawing.Point(7, 19);
            this.editionStandardButton.Name = "editionStandardButton";
            this.editionStandardButton.Size = new System.Drawing.Size(68, 17);
            this.editionStandardButton.TabIndex = 29;
            this.editionStandardButton.TabStop = true;
            this.editionStandardButton.Text = "Standard";
            this.editionStandardButton.UseVisualStyleBackColor = true;
            // 
            // editionDatacenterButton
            // 
            this.editionDatacenterButton.AutoSize = true;
            this.editionDatacenterButton.Location = new System.Drawing.Point(81, 19);
            this.editionDatacenterButton.Name = "editionDatacenterButton";
            this.editionDatacenterButton.Size = new System.Drawing.Size(78, 17);
            this.editionDatacenterButton.TabIndex = 30;
            this.editionDatacenterButton.Text = "Datacenter";
            this.editionDatacenterButton.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.vmTypeBox);
            this.mainPanel.Controls.Add(this.diskSizeUpDown);
            this.mainPanel.Controls.Add(this.remoteManagementPortEnabled);
            this.mainPanel.Controls.Add(this.interfaceNameLabel);
            this.mainPanel.Controls.Add(this.interfaceNameTextBox);
            this.mainPanel.Controls.Add(this.driversPathTextBox);
            this.mainPanel.Controls.Add(this.driversPathBrowseButton);
            this.mainPanel.Controls.Add(this.unattendedTextBox);
            this.mainPanel.Controls.Add(this.unattendedBrowseButton);
            this.mainPanel.Controls.Add(this.driversPathLabel);
            this.mainPanel.Controls.Add(this.unattendedLabel);
            this.mainPanel.Controls.Add(this.generateButton);
            this.mainPanel.Controls.Add(this.packagesBox);
            this.mainPanel.Controls.Add(this.packagesLabel);
            this.mainPanel.Controls.Add(this.editionGroup);
            this.mainPanel.Controls.Add(this.nanoServerFolderTextBox);
            this.mainPanel.Controls.Add(this.nanoServerFolderLabel);
            this.mainPanel.Controls.Add(this.nanoServerFolderBrowseButton);
            this.mainPanel.Controls.Add(this.editionLabel);
            this.mainPanel.Controls.Add(this.outputFolderLabel);
            this.mainPanel.Controls.Add(this.passwordLabel);
            this.mainPanel.Controls.Add(this.outputFolderBrowseButton);
            this.mainPanel.Controls.Add(this.passwordTextBox);
            this.mainPanel.Controls.Add(this.outputFolderTextBox);
            this.mainPanel.Controls.Add(this.diskSizeMagnitudeDropdown);
            this.mainPanel.Controls.Add(this.hostnameTextBox);
            this.mainPanel.Controls.Add(this.hostnameLabel);
            this.mainPanel.Controls.Add(this.diskSizeLabel);
            this.mainPanel.Controls.Add(this.domainNameLabel);
            this.mainPanel.Controls.Add(this.ipv4DNS2Label);
            this.mainPanel.Controls.Add(this.domainNameTextBox);
            this.mainPanel.Controls.Add(this.ipv4DNS1Label);
            this.mainPanel.Controls.Add(this.ipv4AddressLabel);
            this.mainPanel.Controls.Add(this.ipv4DNSSecondaryTextBox);
            this.mainPanel.Controls.Add(this.ipv4AddressTextBox);
            this.mainPanel.Controls.Add(this.ipv4DNSPrimaryTextBox);
            this.mainPanel.Controls.Add(this.ipv4SubnetMaskLabel);
            this.mainPanel.Controls.Add(this.ipv4GatewayTextBox);
            this.mainPanel.Controls.Add(this.ipv4SubnetMaskTextBox);
            this.mainPanel.Controls.Add(this.ipv4GatewayLabel);
            this.mainPanel.Location = new System.Drawing.Point(0, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(442, 720);
            this.mainPanel.TabIndex = 31;
            // 
            // diskSizeUpDown
            // 
            this.diskSizeUpDown.Location = new System.Drawing.Point(114, 265);
            this.diskSizeUpDown.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.diskSizeUpDown.Name = "diskSizeUpDown";
            this.diskSizeUpDown.Size = new System.Drawing.Size(225, 20);
            this.diskSizeUpDown.TabIndex = 45;
            this.diskSizeUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // remoteManagementPortEnabled
            // 
            this.remoteManagementPortEnabled.AutoSize = true;
            this.remoteManagementPortEnabled.Location = new System.Drawing.Point(113, 648);
            this.remoteManagementPortEnabled.Name = "remoteManagementPortEnabled";
            this.remoteManagementPortEnabled.Size = new System.Drawing.Size(186, 17);
            this.remoteManagementPortEnabled.TabIndex = 44;
            this.remoteManagementPortEnabled.Text = "Enable Remote Management Port";
            this.remoteManagementPortEnabled.UseVisualStyleBackColor = true;
            // 
            // interfaceNameLabel
            // 
            this.interfaceNameLabel.AutoSize = true;
            this.interfaceNameLabel.Location = new System.Drawing.Point(28, 625);
            this.interfaceNameLabel.Name = "interfaceNameLabel";
            this.interfaceNameLabel.Size = new System.Drawing.Size(80, 13);
            this.interfaceNameLabel.TabIndex = 43;
            this.interfaceNameLabel.Text = "Interface Name";
            // 
            // interfaceNameTextBox
            // 
            this.interfaceNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interfaceNameTextBox.Location = new System.Drawing.Point(113, 622);
            this.interfaceNameTextBox.Name = "interfaceNameTextBox";
            this.interfaceNameTextBox.Size = new System.Drawing.Size(316, 20);
            this.interfaceNameTextBox.TabIndex = 42;
            // 
            // driversPathTextBox
            // 
            this.driversPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driversPathTextBox.Location = new System.Drawing.Point(193, 594);
            this.driversPathTextBox.Name = "driversPathTextBox";
            this.driversPathTextBox.ReadOnly = true;
            this.driversPathTextBox.Size = new System.Drawing.Size(236, 20);
            this.driversPathTextBox.TabIndex = 41;
            // 
            // driversPathBrowseButton
            // 
            this.driversPathBrowseButton.Location = new System.Drawing.Point(113, 592);
            this.driversPathBrowseButton.Name = "driversPathBrowseButton";
            this.driversPathBrowseButton.Size = new System.Drawing.Size(74, 23);
            this.driversPathBrowseButton.TabIndex = 40;
            this.driversPathBrowseButton.Text = "Browse...";
            this.driversPathBrowseButton.UseVisualStyleBackColor = true;
            this.driversPathBrowseButton.Click += new System.EventHandler(this.driversPathBrowseButton_Click);
            // 
            // unattendedTextBox
            // 
            this.unattendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unattendedTextBox.Location = new System.Drawing.Point(194, 568);
            this.unattendedTextBox.Name = "unattendedTextBox";
            this.unattendedTextBox.ReadOnly = true;
            this.unattendedTextBox.Size = new System.Drawing.Size(236, 20);
            this.unattendedTextBox.TabIndex = 39;
            // 
            // unattendedBrowseButton
            // 
            this.unattendedBrowseButton.Location = new System.Drawing.Point(113, 566);
            this.unattendedBrowseButton.Name = "unattendedBrowseButton";
            this.unattendedBrowseButton.Size = new System.Drawing.Size(74, 23);
            this.unattendedBrowseButton.TabIndex = 38;
            this.unattendedBrowseButton.Text = "Browse...";
            this.unattendedBrowseButton.UseVisualStyleBackColor = true;
            this.unattendedBrowseButton.Click += new System.EventHandler(this.unattendedBrowseButton_Click);
            // 
            // driversPathLabel
            // 
            this.driversPathLabel.AutoSize = true;
            this.driversPathLabel.Location = new System.Drawing.Point(43, 597);
            this.driversPathLabel.Name = "driversPathLabel";
            this.driversPathLabel.Size = new System.Drawing.Size(65, 13);
            this.driversPathLabel.TabIndex = 37;
            this.driversPathLabel.Text = "Drivers Path";
            // 
            // unattendedLabel
            // 
            this.unattendedLabel.AutoSize = true;
            this.unattendedLabel.Location = new System.Drawing.Point(27, 568);
            this.unattendedLabel.Name = "unattendedLabel";
            this.unattendedLabel.Size = new System.Drawing.Size(81, 13);
            this.unattendedLabel.TabIndex = 36;
            this.unattendedLabel.Text = "Unattended.xml";
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(113, 671);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(316, 37);
            this.generateButton.TabIndex = 35;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // packagesBox
            // 
            this.packagesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packagesBox.FormattingEnabled = true;
            this.packagesBox.Location = new System.Drawing.Point(114, 421);
            this.packagesBox.Name = "packagesBox";
            this.packagesBox.Size = new System.Drawing.Size(317, 139);
            this.packagesBox.TabIndex = 34;
            // 
            // packagesLabel
            // 
            this.packagesLabel.AutoSize = true;
            this.packagesLabel.Location = new System.Drawing.Point(53, 433);
            this.packagesLabel.Name = "packagesLabel";
            this.packagesLabel.Size = new System.Drawing.Size(55, 13);
            this.packagesLabel.TabIndex = 33;
            this.packagesLabel.Text = "Packages";
            // 
            // editionGroup
            // 
            this.editionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editionGroup.Controls.Add(this.editionStandardButton);
            this.editionGroup.Controls.Add(this.editionDatacenterButton);
            this.editionGroup.Location = new System.Drawing.Point(113, 317);
            this.editionGroup.Name = "editionGroup";
            this.editionGroup.Size = new System.Drawing.Size(317, 47);
            this.editionGroup.TabIndex = 31;
            this.editionGroup.TabStop = false;
            // 
            // unattendedOpenDialog
            // 
            this.unattendedOpenDialog.FileName = "Unattended.xml";
            // 
            // vmTypeBox
            // 
            this.vmTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vmTypeBox.Controls.Add(this.vmGuest);
            this.vmTypeBox.Controls.Add(this.vmHost);
            this.vmTypeBox.Location = new System.Drawing.Point(114, 370);
            this.vmTypeBox.Name = "vmTypeBox";
            this.vmTypeBox.Size = new System.Drawing.Size(316, 45);
            this.vmTypeBox.TabIndex = 46;
            this.vmTypeBox.TabStop = false;
            // 
            // vmHost
            // 
            this.vmHost.AutoSize = true;
            this.vmHost.Location = new System.Drawing.Point(7, 18);
            this.vmHost.Name = "vmHost";
            this.vmHost.Size = new System.Drawing.Size(47, 17);
            this.vmHost.TabIndex = 0;
            this.vmHost.Text = "Host";
            this.vmHost.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Host / Guest";
            // 
            // vmGuest
            // 
            this.vmGuest.AutoSize = true;
            this.vmGuest.Checked = true;
            this.vmGuest.Location = new System.Drawing.Point(60, 18);
            this.vmGuest.Name = "vmGuest";
            this.vmGuest.Size = new System.Drawing.Size(53, 17);
            this.vmGuest.TabIndex = 1;
            this.vmGuest.TabStop = true;
            this.vmGuest.Text = "Guest";
            this.vmGuest.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 747);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.MaximumSize = new System.Drawing.Size(457, 786);
            this.MinimumSize = new System.Drawing.Size(457, 786);
            this.Name = "MainForm";
            this.Text = "NanoTool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskSizeUpDown)).EndInit();
            this.editionGroup.ResumeLayout(false);
            this.editionGroup.PerformLayout();
            this.vmTypeBox.ResumeLayout(false);
            this.vmTypeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label nanoServerFolderLabel;
        private System.Windows.Forms.Button nanoServerFolderBrowseButton;
        private System.Windows.Forms.TextBox nanoServerFolderTextBox;
        private System.Windows.Forms.Label outputFolderLabel;
        private System.Windows.Forms.Button outputFolderBrowseButton;
        private System.Windows.Forms.TextBox outputFolderTextBox;
        private System.Windows.Forms.TextBox hostnameTextBox;
        private System.Windows.Forms.Label hostnameLabel;
        private System.Windows.Forms.Label domainNameLabel;
        private System.Windows.Forms.TextBox domainNameTextBox;
        private System.Windows.Forms.Label ipv4AddressLabel;
        private System.Windows.Forms.TextBox ipv4AddressTextBox;
        private System.Windows.Forms.Label ipv4SubnetMaskLabel;
        private System.Windows.Forms.TextBox ipv4SubnetMaskTextBox;
        private System.Windows.Forms.Label ipv4GatewayLabel;
        private System.Windows.Forms.TextBox ipv4GatewayTextBox;
        private System.Windows.Forms.TextBox ipv4DNSPrimaryTextBox;
        private System.Windows.Forms.TextBox ipv4DNSSecondaryTextBox;
        private System.Windows.Forms.Label ipv4DNS1Label;
        private System.Windows.Forms.Label ipv4DNS2Label;
        private System.Windows.Forms.Label diskSizeLabel;
        private System.Windows.Forms.ComboBox diskSizeMagnitudeDropdown;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label editionLabel;
        private System.Windows.Forms.RadioButton editionStandardButton;
        private System.Windows.Forms.RadioButton editionDatacenterButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox editionGroup;
        private System.Windows.Forms.Label packagesLabel;
        private System.Windows.Forms.CheckedListBox packagesBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox driversPathTextBox;
        private System.Windows.Forms.Button driversPathBrowseButton;
        private System.Windows.Forms.TextBox unattendedTextBox;
        private System.Windows.Forms.Button unattendedBrowseButton;
        private System.Windows.Forms.Label driversPathLabel;
        private System.Windows.Forms.Label unattendedLabel;
        private System.Windows.Forms.CheckBox remoteManagementPortEnabled;
        private System.Windows.Forms.Label interfaceNameLabel;
        private System.Windows.Forms.TextBox interfaceNameTextBox;
        private System.Windows.Forms.OpenFileDialog unattendedOpenDialog;
        private System.Windows.Forms.FolderBrowserDialog nanoServerBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog driversPathBrowserDialog;
        private System.Windows.Forms.NumericUpDown diskSizeUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox vmTypeBox;
        private System.Windows.Forms.RadioButton vmGuest;
        private System.Windows.Forms.RadioButton vmHost;
    }
}

