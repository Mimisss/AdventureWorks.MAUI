using AdventureWorks.MAUI.MauiViewModelClasses;

namespace AdventureWorks.MAUI.Views;

[QueryProperty(nameof(ProductId), "id")]
public partial class ProductDetailView : ContentPage
{
	private readonly ProductViewModel viewModel;

    public ProductDetailView(ProductViewModel viewModel)
	{
		InitializeComponent();

		this.viewModel = viewModel;
	}

	public int ProductId { get; set; }

	protected async override void OnAppearing()
	{
		base.OnAppearing();

        // Set the BindingContext to the ViewModel
        BindingContext = viewModel;

        // Retrieve a Product
        await viewModel.GetAsync(ProductId);
    }

    private void Weight_Changed(object sender, ValueChangedEventArgs e)
    {
		// Have the slider value change in while number increments
		weight.Value = Math.Round(e.NewValue, 0);
    }
}