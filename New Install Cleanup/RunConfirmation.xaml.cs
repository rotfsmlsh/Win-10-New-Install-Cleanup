using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace New_Install_Cleanup {
    /// <summary>
    /// Interaction logic for RunConfirmation.xaml
    /// </summary>
    public partial class RunConfirmation : Window {
        readonly List<FeatureEntity> entities;
        RemoveDefaultApplications s;
        public RunConfirmation(List<FeatureEntity> selectedEntities, RemoveDefaultApplications sender) {
            InitializeComponent();
            entities = selectedEntities;
            s = sender;
            SetSelected(entities);
        }

        private void SetSelected(List<FeatureEntity> entities) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The following applications will be uninstalled...\n");
            foreach(FeatureEntity entity in entities) {
                sb.Append("Name:" + entity.friendlyName);
                sb.Append("\n");
            }
            txtBlock_summary.AppendText(sb.ToString());
        }

        private void checkbox_understand_Checked(object sender, RoutedEventArgs e) {
            btn_executeOperation.IsEnabled = true;
        }

        private void checkbox_understand_unchecked(object sender, RoutedEventArgs e) {
            btn_executeOperation.IsEnabled = false;
        }

        private void btn_executeOperation_Click(object sender, RoutedEventArgs e) {
            MessageBoxButtons boxButtons = MessageBoxButtons.YesNo;
            string title = "Ammonia - Confirm System Changes";
            string message = "This operation will remove pre-installed Windows applications.\n\n Are you sure you want to do this?";
            DialogResult result = MessageBox.Show(message, title, boxButtons, MessageBoxIcon.Warning);
            if(result == System.Windows.Forms.DialogResult.Yes) {
                runCleanupOperation();
                s.Close();
            }
            else {
                Close();
            }           
        }

        private void runCleanupOperation() {
            foreach (FeatureEntity entity in entities) {
                PowerShell ps = PowerShell.Create();
                ps.AddCommand("Get-AppxPackage");
                ps.AddArgument("*" + entity.name + "*");
                ps.AddCommand("Remove-AppxPackage");
                ps.Invoke();
                ps.Dispose();
            }

            Close();
        }
    }
}
