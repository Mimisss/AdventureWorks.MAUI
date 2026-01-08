using AdventureWorks.MAUI.MauiViewModelClasses;

namespace AdventureWorks.MAUI.Views;

[QueryProperty(nameof(LastPage), "lastPage")]
[QueryProperty(nameof(IsPrivacyPolicyAccepted), "isPrivacyPolicyAccepted")]
public partial class LoginView : ContentPage
{
	private readonly LoginViewModel viewModel;

	public LoginView(LoginViewModel viewModel)
	{
		InitializeComponent();

		this.viewModel = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		BindingContext = viewModel;

		if (LastPage != null && LastPage == nameof(Views.PrivacyPolicyView))
		{
			if (IsPrivacyPolicyAccepted)
			{
				Console.WriteLine("Privacy Policy was accepted");
			}
			else
			{
				Console.WriteLine("Privacy Policy was not accepted");
			}
		}

		LastPage = null;
    }

	public string? LastPage { get; set; }

	public bool IsPrivacyPolicyAccepted { get; set; }
}