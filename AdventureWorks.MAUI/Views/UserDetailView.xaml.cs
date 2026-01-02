using AdventureWorks.EntityLayer;

namespace AdventureWorks.MAUI.Views;

public partial class UserDetailView : ContentPage
{
	private readonly User viewModel;

	public UserDetailView()
	{
		InitializeComponent();
		
		viewModel = (User)Resources["viewModel"];
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		viewModel.LoginId = "PeterPiper384";

		viewModel.FirstName = "Peter";

		viewModel.LastName = "Piper";

		viewModel.Email = "Peter@pipering.com";
    }

	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		// TODO: Respond to the event here		
    }
}