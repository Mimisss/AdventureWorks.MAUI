using AdventureWorks.ViewModelLayer;

namespace AdventureWorks.MAUI.Views;

public partial class UserDetailView : ContentPage
{
	private readonly UserViewModel viewModel = new();

	public UserDetailView()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

		// Set the BindingContext to the ViewModel
		BindingContext = viewModel;

		// Retrieve a User
		await viewModel.GetAsync(1);
    }

	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		// TODO: Respond to the event here		
    }
}