using AdventureWorks.MAUI.MauiViewModelClasses;

namespace AdventureWorks.MAUI.Views;

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
    }
}