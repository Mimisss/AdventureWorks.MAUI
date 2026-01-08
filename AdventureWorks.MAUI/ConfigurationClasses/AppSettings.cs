using Common.Library;

namespace AdventureWorks.MAUI.ConfigurationClasses
{
    public class AppSettings : CommonBase
    {
        private bool isPrivacyPolicyAccepted;

        public bool IsPrivacyPolicyAccepted
        {
            get { return isPrivacyPolicyAccepted; }
            set
            {
                isPrivacyPolicyAccepted = value;

                RaisePropertyChanged(nameof(IsPrivacyPolicyAccepted));
            }
        }
    }
}
