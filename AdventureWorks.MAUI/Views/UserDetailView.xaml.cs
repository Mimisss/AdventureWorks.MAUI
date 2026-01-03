using AdventureWorks.ViewModelLayer;
using System.Threading.Tasks;

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

		// Get the Phone Types
		await viewModel.GetPhoneTypesAsync();

        // Retrieve a User
        await viewModel.GetAsync(1);
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        // TODO: Respond to the event here		
        await viewModel.SaveAsync();
    }
}