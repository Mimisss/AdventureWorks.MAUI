namespace AdventureWorks.MAUI.Views;

public partial class UserListView : ContentPage
{
	public UserListView()
	{
		InitializeComponent();
	}

    private async void NavigateToDetail_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(Views.UserDetailView));
    }
}