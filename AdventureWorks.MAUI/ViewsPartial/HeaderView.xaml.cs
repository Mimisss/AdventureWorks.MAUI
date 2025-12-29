namespace AdventureWorks.MAUI.ViewsPartial;

public partial class HeaderView : ContentView
{
	public HeaderView()
	{
		InitializeComponent();
	}

	public string ViewTitle
	{
		get => (string)GetValue(VIewTitleProperty);
		set => SetValue(VIewTitleProperty, value);
    }

	public static readonly BindableProperty VIewTitleProperty =
		BindableProperty.Create(nameof(ViewTitle), typeof(string), typeof(HeaderView), string.Empty);

	public string ViewDescription
	{
		get => (string)GetValue(ViewDescriptionProperty);
		set => SetValue(ViewDescriptionProperty, value);
    }

    public static readonly BindableProperty ViewDescriptionProperty =
		BindableProperty.Create(nameof(ViewDescription), typeof(string), typeof(HeaderView), string.Empty);
}