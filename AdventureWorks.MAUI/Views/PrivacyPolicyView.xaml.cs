using AdventureWorks.MAUI.MauiViewModelClasses;

namespace AdventureWorks.MAUI.Views;

public partial class PrivacyPolicyView : ContentPage
{
	private readonly PrivacyPolicyViewModel viewModel;

    public PrivacyPolicyView(PrivacyPolicyViewModel viewModel)
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