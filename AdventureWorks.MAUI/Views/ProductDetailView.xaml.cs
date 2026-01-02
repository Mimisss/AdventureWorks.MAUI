namespace AdventureWorks.MAUI.Views;

public partial class ProductDetailView : ContentPage
{
	public ProductDetailView()
	{
		InitializeComponent();
	}

    private void Weight_Changed(object sender, ValueChangedEventArgs e)
    {
		// Have the slider value change in while number increments
		weight.Value = Math.Round(e.NewValue, 0);
    }
}