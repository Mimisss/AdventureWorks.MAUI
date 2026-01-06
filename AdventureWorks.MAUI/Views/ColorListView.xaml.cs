using AdventureWorks.MAUI.MauiViewModelClasses;

namespace AdventureWorks.MAUI.Views;

public partial class ColorListView : ContentPage
{
	private readonly ColorViewModel viewModel;

	public ColorListView(ColorViewModel viewModel)
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
}