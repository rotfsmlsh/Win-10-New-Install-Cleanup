using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Windows;
using System.Windows.Controls;

namespace New_Install_Cleanup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class RemoveDefaultApplications : Window
    {
        public RemoveDefaultApplications() {
            InitializeComponent();

            // populate list view
            populateFeatureListbox();
            btn_selectAll.IsEnabled = false;
        }

        public RemoveDefaultApplications(List<FeatureEntity> entities) {
            InitializeComponent();
            btn_selectAll.IsEnabled = true;
            foreach(FeatureEntity entity in entities) {
                if (entity.nonRemovable == false && containsIgnoreCase(entity.fullName, "microsoft")) {
                    ListBoxItem item = new ListBoxItem {
                        Content = entity.friendlyName,
                        ToolTip = entity.generateTooltip(),
                        DataContext = entity
                    };
                    listbox_features.Items.Add(item);
                }
            }
        }


        public void populateFeatureListbox() {
            PowerShell ps = PowerShell.Create();
            //ps.AddCommand("Get-AppxPackage | Select Name, PackageFullName");
            ps.AddCommand("Get-AppxPackage");
            Collection<PSObject> results = ps.Invoke();
            foreach(PSObject result in results) {
                FeatureEntity entity = new FeatureEntity(result);

                //TODO: check whitelist

                if (entity.nonRemovable == false && containsIgnoreCase(entity.fullName, "microsoft")) {
                    ListBoxItem item = new ListBoxItem {
                        Content = entity.friendlyName,
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
            showConfirmation(entities, this);
        }

        private void btn_clearSelection_Click(object sender, RoutedEventArgs e) {
            listbox_features.SelectedItems.Clear();
        }

        private void showConfirmation(List<FeatureEntity> entities, RemoveDefaultApplications sender) {
            _ = new RunConfirmation(entities, sender) {
                IsEnabled = true,
                Visibility = Visibility.Visible
            };
        }

        private bool containsIgnoreCase(string s, string pattern) {
            return s.IndexOf(pattern, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void btn_selectAll_Click(object sender, RoutedEventArgs e) {
            listbox_features.SelectAll();
        }
    }
}
