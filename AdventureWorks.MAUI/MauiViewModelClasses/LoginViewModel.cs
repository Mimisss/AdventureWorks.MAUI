using AdventureWorks.MAUI.ConfigurationClasses;
using Common.Library;
using System.Windows.Input;

namespace AdventureWorks.MAUI.MauiViewModelClasses
{
    // No corresponding view model class in the ViewModelLayer project
    // is needed as the functionality is to call pages in the UI.
    public class LoginViewModel : ViewModelBase
    {
        private readonly PrivacyPolicyViewModel privacyPolicyViewModel;

        private AppSettings settings;

        public LoginViewModel(PrivacyPolicyViewModel privacyPolicyViewModel, AppSettings settings)
        {
            this.privacyPolicyViewModel = privacyPolicyViewModel;

            this.settings = settings;
        }
                
        public AppSettings Settings
        {
            get { return settings; }
            // Note that RaisePropertyChanged is not called here
            set { settings = value; }
        }

        public ICommand? PrivacyPolicyDisplay { get; private set; }

        public override void Init()
        {
            base.Init();

            PrivacyPolicyDisplay = new Command(async () => await PrivacyPolicyDisplayAsync());
        }

        public async Task PrivacyPolicyDisplayAsync()
        {
            await Shell.Current.Navigation.PushModalAsync(new Views.PrivacyPolicyView(privacyPolicyViewModel));
        }
    }
}
