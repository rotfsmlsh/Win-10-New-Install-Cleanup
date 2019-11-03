using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace New_Install_Cleanup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();

            // populate list view
            populateFeatureListbox();
            
        }


        public void populateFeatureListbox() {
            PowerShell ps = PowerShell.Create();
            //ps.AddCommand("Get-AppxPackage | Select Name, PackageFullName");
            ps.AddCommand("Get-AppxPackage");
            Collection<PSObject> results = ps.Invoke();
            foreach(PSObject result in results) {
                FeatureEntity entity = new FeatureEntity(result);

                //TODO: check whitelist

                if (entity.nonRemovable == false) {
                    ListBoxItem item = new ListBoxItem {
                        Content = entity.name,
                        ToolTip = entity.generateTooltip(),
                        DataContext = entity
                    };
                    listbox_features.Items.Add(item);
                }
            }
            ps.Dispose();
        }

        private void listbox_features_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (listbox_features.SelectedItems.Count != 0) {
                btn_clearSelection.IsEnabled = true;
                btn_executeCleanup.IsEnabled = true;
            }
            else {
                btn_clearSelection.IsEnabled = false;
                btn_executeCleanup.IsEnabled = false;
            }
        }

        private void btn_executeCleanup_Click(object sender, RoutedEventArgs e) {
            //do the operation
            List<FeatureEntity> entities = new List<FeatureEntity>();
            foreach (ListBoxItem item in listbox_features.SelectedItems) {
                entities.Add((FeatureEntity)item.DataContext);
            }
            showConfirmation(entities);
        }

        private void btn_clearSelection_Click(object sender, RoutedEventArgs e) {
            listbox_features.SelectedItems.Clear();
        }

        private void showConfirmation(List<FeatureEntity> entities) {
            RunConfirmation confirmation = new RunConfirmation(entities) {
                IsEnabled = true,
                Visibility = Visibility.Visible
            };
        }
    }
}
