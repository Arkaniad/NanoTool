using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanoTool {
    public partial class MainForm : Form {

        private List<string> _Packages;

        private string _NanoServerPath;
        private string _OutputPath;
        private string _DriversPath;
        private string _UnattendedXMLPath;

        private string _ScriptPath;

        public MainForm() {
            _Packages = new List<string>() {
                "Microsoft-NanoServer-BootFromWim-Package.cab",
                "Microsoft-NanoServer-Compute-Package.cab",
                "Microsoft-NanoServer-Containers-Package.cab",
                "Microsoft-NanoServer-DCB-Package.cab",
                "Microsoft-NanoServer-Defender-Package.cab",
                "Microsoft-NanoServer-DNS-Package.cab",
                "Microsoft-NanoServer-DSC-Package.cab",
                "Microsoft-NanoServer-FailoverCluster-Package.cab",
                "Microsoft-NanoServer-Guest-Package.cab",
                "Microsoft-NanoServer-Host-Package.cab",
                "Microsoft-NanoServer-IIS-Package.cab",
                "Microsoft-NanoServer-NPDS-Package.cab",
                "Microsoft-NanoServer-OEM-Drivers-Package.cab",
                "Microsoft-NanoServer-SCVMM-Compute-Package.cab",
                "Microsoft-NanoServer-SCVMM-Package.cab",
                "Microsoft-NanoServer-SecureStartup-Package.cab",
                "Microsoft-NanoServer-ShieldedVM-Package.cab",
                "Microsoft-NanoServer-Storage-Package.cab"
            };

            InitializeComponent();

            diskSizeMagnitudeDropdown.SelectedIndex = 0;
        }
        private void MainForm_Load(object sender, EventArgs e) {
            _InitializePackagesList();
        }

        private void _InitializePackagesList() {
            foreach(string package in _Packages) {
                packagesBox.Items.Add(package);
            }
        }

        #region Event Handlers
        private void nanoServerFolderBrowseButton_Click(object sender, EventArgs e) {
            if(nanoServerBrowserDialog.ShowDialog() == DialogResult.OK) {
                nanoServerFolderTextBox.Text = nanoServerBrowserDialog.SelectedPath;
                _NanoServerPath = nanoServerBrowserDialog.SelectedPath;
            }
        }

        private void outputFolderBrowseButton_Click(object sender, EventArgs e) {
            if(outputFolderBrowserDialog.ShowDialog() == DialogResult.OK) {
                outputFolderTextBox.Text = outputFolderBrowserDialog.SelectedPath;
                _OutputPath = outputFolderBrowserDialog.SelectedPath;
            }
        }

        private void unattendedBrowseButton_Click(object sender, EventArgs e) {
            if(unattendedOpenDialog.ShowDialog() == DialogResult.OK) {
                unattendedTextBox.Text = unattendedOpenDialog.FileName;
                _UnattendedXMLPath = unattendedOpenDialog.FileName;
            }
        }

        private void driversPathBrowseButton_Click(object sender, EventArgs e) {
            if(driversPathBrowserDialog.ShowDialog() == DialogResult.OK) {
                driversPathTextBox.Text = driversPathBrowserDialog.SelectedPath;
                _DriversPath = driversPathBrowserDialog.SelectedPath;
            }
        }
        #endregion Event Handlers

        private void generateButton_Click(object sender, EventArgs e) {
            List<string> errors = new List<string>();

            string hostname = hostnameTextBox.Text;
            if(String.IsNullOrEmpty(hostname)) {
                errors.Add("Hostname is empty.");
            }

            string domainName = domainNameTextBox.Text;
            if (String.IsNullOrEmpty(domainName)) {
                errors.Add("Domain Name is empty.");
            }

            string ipv4Address = ipv4AddressTextBox.Text;
            if(String.IsNullOrEmpty(ipv4Address)) {
                errors.Add("IPv4 Address is empty.");
            }

            string ipv4SubnetMask = ipv4SubnetMaskTextBox.Text;
            if(String.IsNullOrEmpty(ipv4SubnetMask)) {
                errors.Add("IPv4 Subnet Mask is empty.");
            }

            string ipv4Gateway = ipv4GatewayTextBox.Text;
            if(String.IsNullOrEmpty(ipv4Gateway)) {
                errors.Add("IPv4 Gateway is empty.");
            }

            string ipv4DNSPrimary = ipv4DNSPrimaryTextBox.Text;
            if(String.IsNullOrEmpty(ipv4DNSPrimary)) {
                errors.Add("IPv4 DNS Primary is empty.");
            }

            string ipv4DNSSecondary = ipv4DNSSecondaryTextBox.Text;
            if(String.IsNullOrEmpty(ipv4DNSSecondary)) {
                errors.Add("IPv4 DNS Secondary is empty.");
            }

            string interfaceName = interfaceNameTextBox.Text;

            string adminPassword = passwordTextBox.Text;
            if(String.IsNullOrEmpty(adminPassword)) {
                errors.Add("Password is empty.");
            }

            bool remoteManagementPort = remoteManagementPortEnabled.Checked;

            string diskSize = diskSizeUpDown.Text + diskSizeMagnitudeDropdown.SelectedItem;

            List<string> selectedPackages = new List<string>();
            foreach(var item in packagesBox.CheckedItems) {
               selectedPackages.Add(item.ToString().TrimEnd(".cab".ToCharArray()));
            }

            string fullScript;

            if(errors.Count() == 0) {
                fullScript = _GenerateScript(hostname, domainName, ipv4Address, ipv4SubnetMask, ipv4Gateway, ipv4DNSPrimary, ipv4DNSSecondary, adminPassword, diskSize, interfaceName, remoteManagementPort, selectedPackages);
                bool result = _RunScript();
                if (!result) {
                    MessageBox.Show("Process did not complete successfully.");
                } else {
                    MessageBox.Show("Success!");
                }
            } else {
                string errorMessage = "Unable to generate image file, there were errors in the form.\n\n";
                foreach(var error in errors) {
                    errorMessage += "- " + error + "\n";
                }
                MessageBox.Show(errorMessage);
            }
        }

        private bool _RunScript() {
            string execute = string.Format("-ExecutionPolicy Unrestricted {0}", _ScriptPath);
            var proc = Process.Start("powershell.exe", execute);

            var waiting = true;
            while(waiting) {
                if (proc.HasExited) {
                    waiting = false;
                } else {
                    Thread.Sleep(1000);
                }
            }

            if (proc.ExitCode == 0) {
                return true;
            }
            return false;
        }

        private string _GenerateScript(
            string hostname, 
            string domainName, 
            string ipv4Address, 
            string ipv4SubnetMask, 
            string ipv4Gateway, 
            string ipv4DNSPrimary, 
            string ipv4DNSSecondary,
            string password,
            string diskSize, 
            string interfaceName, 
            bool remoteManagementPort, 
            List<string> selectedPackages) {
            string script = "";

            var scriptBuilder = new StringBuilder();

            var mediaPath = Path.GetFullPath(Path.Combine(_NanoServerPath, @"..\"));
            var modulePath = Path.GetFullPath(Path.Combine(_NanoServerPath, "NanoServerImageGenerator", "NanoServerImageGenerator.psm1"));
            scriptBuilder.Append(string.Format("Import-Module {0}\n", modulePath));
            scriptBuilder.Append("New-NanoServerImage ");
            scriptBuilder.Append(string.Format(@"-MediaPath {0} ", Path.GetFullPath(Path.Combine(_NanoServerPath, "..\\"))));
            scriptBuilder.Append(string.Format(@"-TargetPath {0} ", Path.GetFullPath(Path.Combine(_OutputPath, string.Format("{0}.vhdx", hostname)))));
            scriptBuilder.Append(string.Format(@"-ComputerName {0} ", hostname));
            if (!string.IsNullOrEmpty(interfaceName)) {
                scriptBuilder.Append(string.Format(@"-InterfaceNameOrIndex {0} ", interfaceName));
            }
            scriptBuilder.Append(string.Format(@"-Ipv4Address {0} ", ipv4Address));
            scriptBuilder.Append(string.Format(@"-Ipv4SubnetMask {0} ", ipv4SubnetMask));
            scriptBuilder.Append(string.Format(@"-Ipv4Dns {0}, {1} ", ipv4DNSPrimary, ipv4DNSSecondary));
            scriptBuilder.Append(string.Format(@"-Ipv4Gateway {0} ", ipv4Gateway));
            scriptBuilder.Append(string.Format(@"-DomainName {0} ", domainName));
            scriptBuilder.Append(string.Format(@"-MaxSize {0} ", diskSize));
            scriptBuilder.Append(string.Format("-AdministratorPassword (ConvertTo-SecureString \'{0}\' -AsPlainText -Force) ", password));
            
            if(!string.IsNullOrEmpty(_DriversPath)) {
                scriptBuilder.Append(string.Format(@"-DriversPath {0} ", _DriversPath));
            }

            if(!string.IsNullOrEmpty(_UnattendedXMLPath)) {
                scriptBuilder.Append(string.Format(@"-UnattendPath {0} ", _UnattendedXMLPath));
            }

            scriptBuilder.Append("-Edition ");
            if(editionStandardButton.Checked) {
                scriptBuilder.Append("Standard ");
            } else {
                scriptBuilder.Append("Datacenter ");
            }

            scriptBuilder.Append("-DeploymentType ");
            if(vmGuest.Checked) {
                scriptBuilder.Append("Guest ");
            } else {
                scriptBuilder.Append("Host ");
            }
            scriptBuilder.Append("-Packages ");
            foreach (var installedPackage in selectedPackages) {
                if (installedPackage != selectedPackages.Last()) {
                    scriptBuilder.Append(installedPackage + ", ");
                } else {
                    scriptBuilder.Append(installedPackage + " ");
                }
            }
            if (remoteManagementPort) {
                scriptBuilder.Append("-EnableRemoteManagementPort");
            }

            scriptBuilder.AppendLine();
            scriptBuilder.Append("Write-Host \"Press any key to continue...\"");
            scriptBuilder.Append("$x = $host.UI.RawUI.ReadKey(\"NoEcho,IncludeKeyDown\")");
            script = scriptBuilder.ToString();
            _ScriptPath = Path.GetFullPath(Path.Combine(_OutputPath, string.Format("{0}-create.ps1", hostname)));
            File.WriteAllText(_ScriptPath, script);
            return script;
        }
    }
}
