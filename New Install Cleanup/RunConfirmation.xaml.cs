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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace New_Install_Cleanup {
    /// <summary>
    /// Interaction logic for RunConfirmation.xaml
    /// </summary>
    public partial class RunConfirmation : Window {
        readonly List<FeatureEntity> entities;
        public RunConfirmation(List<FeatureEntity> selectedEntities) {
            InitializeComponent();
            entities = selectedEntities;
            SetSelected(entities);
        }

        private void SetSelected(List<FeatureEntity> entities) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The following applications will be uninstalled...\n");
            foreach(FeatureEntity entity in entities) {
                sb.Append("Name: " + entity.name);
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
            runCleanupOperation();
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
        }
    }
}
