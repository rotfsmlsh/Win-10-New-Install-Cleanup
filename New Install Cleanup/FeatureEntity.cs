using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace New_Install_Cleanup {
    public class FeatureEntity {
        public string name { get; set; }
        public string fullName { get; set; }
        public string publisher { get; set; }
        public string version { get; set; }
        public bool nonRemovable { get; set; }


        public FeatureEntity(PSObject psObject) {
            name = (string)psObject.Properties["Name"].Value;
            fullName = (string)psObject.Properties["PackageFullName"].Value;
            publisher = (string)psObject.Properties["Publisher"].Value;
            version = (string)psObject.Properties["Version"].Value;
            if((bool)psObject.Properties["NonRemovable"].Value == true) {
                nonRemovable = true;
            }
            else {
                nonRemovable = false;
            }
        }

        public string generateTooltip() {
            StringBuilder tooltip = new StringBuilder();
            tooltip.AppendLine("Name:\t\t" + name);
            tooltip.AppendLine("Full Name:\t" + fullName);
            tooltip.AppendLine("Publisher:\t" + publisher);
            tooltip.Append("Version:\t\t" + version);
            return tooltip.ToString();
        }
    }
}
