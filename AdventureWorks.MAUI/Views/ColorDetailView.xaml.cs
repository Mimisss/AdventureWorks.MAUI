using AdventureWorks.MAUI.MauiViewModelClasses;

namespace AdventureWorks.MAUI.Views;

[QueryProperty(nameof(ColorId), "id")]
public partial class ColorDetailView : ContentPage
{
	private readonly ColorViewModel viewModel;

	public ColorDetailView(ColorViewModel viewModel)
	{
		InitializeComponent();

		this.viewModel = viewModel;
    }

	public int ColorId { get; set; }

	protected override async void OnAppearing()
	{
		base.OnAppearing();

        // Set the Binding Context to the ViewModel
        BindingContext = viewModel;

		// Retrive a color
        await viewModel.GetAsync(ColorId);
    }
}