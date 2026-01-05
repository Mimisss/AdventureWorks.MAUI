using AdventureWorks.MAUI.MauiViewModelClasses;

namespace AdventureWorks.MAUI.Views;

[QueryProperty(nameof(UserId), "id")]
public partial class UserDetailView : ContentPage
{
	private readonly UserViewModel viewModel = new();

	public UserDetailView(UserViewModel viewModel)
	{
		InitializeComponent();

        this.viewModel = viewModel;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

		// Set the BindingContext to the ViewModel
		BindingContext = viewModel;

		// Get the Phone Types
		await viewModel.GetPhoneTypesAsync();

        // Retrieve a User
        await viewModel.GetAsync(UserId);
    }

    public int UserId { get; set; }
}