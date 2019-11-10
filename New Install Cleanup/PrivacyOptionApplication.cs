using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Install_Cleanup {
    static class PrivacyOptionApplication {
        /*CONTACTS,
          ACCOUNT_INFO,
          ACTIVITY_HISTORY_SEND,
          ACTIVITY_HISTORY_STORE,
          ADVERTISING,
          CAMERA, 
          DIAGNOSTIC_FEEDBACK,
          LOCATION,
          MICROPHONE, 
          TAILORED_EXPERIENCES
        */
        public static void setOption(PrivacyOption option, string value) {
            switch (option) {
                case PrivacyOption.CONTACTS:
                    setContactsOption(value);
                    break;
                case PrivacyOption.ACCOUNT_INFO:
                    setAccountInfoOption(value);
                    break;
                case PrivacyOption.ACTIVITY_HISTORY_SEND:
                    setActivityHistorySendOption(value);
                    break;
                case PrivacyOption.ACTIVITY_HISTORY_STORE:
                    setActivityHistoryStoreOption(value);
                    break;
                case PrivacyOption.ADVERTISING:
                    setAdvertisingOption(value);
                    break;
                case PrivacyOption.CAMERA:
                    setCameraOption(value);
                    break;
                case PrivacyOption.DIAGNOSTIC_FEEDBACK:
                    setDiagnosticFeedbackOption(value);
                    break;
                case PrivacyOption.LOCATION:
                    setLocationOption(value);
                    break;
                case PrivacyOption.MICROPHONE:
                    setMicrophoneOption(value);
                    break;
                case PrivacyOption.TAILORED_EXPERIENCES:
                    setTailoredExperiencesOption(value);
                    break;
                default:
                    break;
            }
        }

        static public void setContactsOption(string value) {

        }

        static public void setAccountInfoOption(string value) {

        }

        static public void setActivityHistorySendOption(string value) {

        }

        static public void setActivityHistoryStoreOption(string value) {

        }

        static public void setAdvertisingOption(string value) {

        }

        static public void setCameraOption(string value) {

        }

        static public void setDiagnosticFeedbackOption(string value) {

        }

        static public void setLocationOption(string value) {

        }

        static public void setMicrophoneOption(string value) {

        }

        static public void setTailoredExperiencesOption(string value) {

        }
    }
}
