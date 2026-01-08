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
			viewModel.Settings.IsPrivacyPolicyAccepted = IsPrivacyPolicyAccepted;
		}

		LastPage = null;
    }

	public string? LastPage { get; set; }

	public bool IsPrivacyPolicyAccepted { get; set; }
}