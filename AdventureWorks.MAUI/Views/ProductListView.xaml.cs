using AdventureWorks.MAUI.MauiViewModelClasses;

namespace AdventureWorks.MAUI.Views;

public partial class ProductListView : ContentPage
{
	private readonly ProductViewModel viewModel = new();

    public ProductListView(ProductViewModel viewModel)
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