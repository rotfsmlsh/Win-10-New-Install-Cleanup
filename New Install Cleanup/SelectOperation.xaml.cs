using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for SelectOperation.xaml
    /// </summary>
    public partial class SelectOperation : Window {
        public SelectOperation() {
            InitializeComponent();
        }

        private void btn_typicalRemoval_Click(object sender, RoutedEventArgs e) {
            buildTypicalFeatureRemovalList();
        }

        private void btn_customRemoval_Click(object sender, RoutedEventArgs e) {
            RemoveDefaultApplications defaultApplications = new RemoveDefaultApplications();
            defaultApplications.Show();
        }

        private void buildTypicalFeatureRemovalList() {
            string[] wildcards = { "*3dbuilder*", "*alarms*", "*appconnector*", "*appinstaller*", "*communicationsapps*", "*calculator*", "*camera*",
                "*feedback*", "*officehub*", "*getstarted*", "*skypeapp*", "*zunemusic*", "*zune*", "*maps*", "*messaging*", "*solitaire*", "*wallet*",
                "*connectivitystore*", "*bingfinance*", "*bing*", "*zunevideo*", "*bingnews*", "*onenote*", "*oneconnect*", "*mspaint*", "*people*",
                "*commsphone*", "*windowsphone*", "*phone*", "*photos*", "*bingsports*", "*sticky*", "*sway*", "*3d*", "*soundrecorder*", "*bingweather*",
                "*holographic*", "*xbox*"};
            List<FeatureEntity> features = new List<FeatureEntity>();
            Cursor = Cursors.Wait;
            foreach (string wildcard in wildcards) {
                PowerShell ps = PowerShell.Create();
                //ps.AddCommand("Get-AppxPackage *name*");
                ps.AddCommand("Get-AppxPackage");
                ps.AddArgument(wildcard);
                Collection<PSObject> psObjects = ps.Invoke();
                foreach(PSObject obj in psObjects) {
                    features.Add(new FeatureEntity(obj));
                }
                ps.Dispose();
            }
            Cursor = Cursors.Arrow;
            RemoveDefaultApplications typicalApplications = new RemoveDefaultApplications(features);
            typicalApplications.Show();
        }

        private void btn_customPrivacySettings_Click(object sender, RoutedEventArgs e) {
            PrivacySettings privacySettings = new PrivacySettings();
            privacySettings.Show();
        }
    }
}
