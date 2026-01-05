using AdventureWorks.MAUI.MauiViewModelClasses;

namespace AdventureWorks.MAUI.Views;

public partial class UserListView : ContentPage
{
	private readonly UserViewModel viewModel;

	public UserListView(UserViewModel viewModel)
	{
		InitializeComponent();

		this.viewModel = viewModel;
    }

	protected override async void OnAppearing()
	{
		base.OnAppearing();

        BindingContext = viewModel;

		await viewModel.GetAsync();
	}

    private async void NavigateToDetail_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(Views.UserDetailView));
    }
}