using Common.Library;
using System.Windows.Input;

namespace AdventureWorks.MAUI.MauiViewModelClasses
{
    // No corresponding view model class in the ViewModelLayer project
    // is needed as the functionality is to call pages in the UI.
    public class LoginViewModel : VieWModelBase
    {
        private readonly PrivacyPolicyViewModel privacyPolicyViewModel;

        public LoginViewModel(PrivacyPolicyViewModel privacyPolicyViewModel)
        {
            this.privacyPolicyViewModel = privacyPolicyViewModel;
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
