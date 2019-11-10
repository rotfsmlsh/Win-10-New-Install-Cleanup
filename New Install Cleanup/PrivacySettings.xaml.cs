using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for PrivacyWizard.xaml
    /// </summary>
    public partial class PrivacySettings : Window {

        //location: allow apps to access location on/off

        //microphone: allow apps to access your microphone on/off

        //camera: allow apps to access your camera on/off

        //advertising id: let apps use advertising ID to make ads more interesting to you based on your app activity on/off

        //account info: allow apps to access your account info

        //access contacts: allow apps to access your contacts

        //activity history(store): store activity history on this device check/uncheck

        //activity history(send): send my activity to microsoft check/uncheck

        //diagnostic: Choose how much diagnostic data you want to send to Microsoft: basic/full
        // Basic: Send only info about your device, its settings and capabilities, and whether it is performing properly.
        // Full: Send all Basic diagnostic data, along with info about websites you browse and how you use apps and features, 
        //       plus additional info about device health, device activity, and enhanced error reporting

        readonly List<ComboBox> boxes;
        public PrivacySettings() {
            InitializeComponent();
            boxes = new List<ComboBox> {
                combo_accessContacts,
                combo_accountInfo,
                combo_activityHistorySend,
                combo_activityHistoryStore,
                combo_advertising,
                combo_camera,
                combo_diagnosticFeedback,
                combo_location,
                combo_microphone,
                combo_tailoredExperiences
            };
        }

        private void btn_lowestSettings_Click(object sender, RoutedEventArgs e) {
            combo_accessContacts.SelectedIndex = 0;
            combo_accountInfo.SelectedIndex = 0;
            combo_activityHistorySend.SelectedIndex = 0;
            combo_activityHistoryStore.SelectedIndex = 0;
            combo_advertising.SelectedIndex = 0;
            combo_camera.SelectedIndex = 0;
            combo_diagnosticFeedback.SelectedIndex = 0;
            combo_location.SelectedIndex = 0;
            combo_microphone.SelectedIndex = 0;
            combo_tailoredExperiences.SelectedIndex = 0;
        }

        private bool areBoxesFull() {
            foreach (ComboBox box in boxes) {
                if(box.SelectedIndex == -1) {
                    return false;
                }
            }
            return true;
        }
        
        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            btn_apply.IsEnabled = areBoxesFull();
        }

        private void setPrivacyOption(PrivacyOption option, string value) {
            PrivacyOptionApplication.setOption(option, value);
        }

        private void btn_apply_Click(object sender, RoutedEventArgs e) {
            foreach(ComboBox featureCombo in boxes) {

            }
        }
    }
}
