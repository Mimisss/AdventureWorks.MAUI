using Common.Library;
using System.Windows.Input;

namespace AdventureWorks.MAUI.MauiViewModelClasses
{
    // No corresponding view model class in the ViewModelLayer project
    // is needed as the functionality is to call pages in the UI.
    public class PrivacyPolicyViewModel : ViewModelBase
    {
        public ICommand? AcceptCommand { get; private set; }

        public ICommand? DeclineCommand { get; private set; }

        public override void Init()
        {
            base.Init();

            AcceptCommand = new Command(async () => await AcceptPolicyAsync());

            DeclineCommand = new Command(async () => await DeclinePolicyAsync());
        }

        public async Task AcceptPolicyAsync()
        {
            //await Shell.Current.Navigation.PopAsync();
            string ret = $"..?lastPage={nameof(Views.PrivacyPolicyView)}&isPrivacyPolicyAccepted=true";

            await Shell.Current.GoToAsync(ret);
        }

        public async Task DeclinePolicyAsync()
        {
            string ret = $"..?lastPage={nameof(Views.PrivacyPolicyView)}&isPrivacyPolicyAccepted=false";

            await Shell.Current.GoToAsync(ret);

        }
    }
}
