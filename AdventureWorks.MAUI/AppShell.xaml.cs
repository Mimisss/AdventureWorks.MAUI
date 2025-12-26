namespace AdventureWorks.MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes
            Routing.RegisterRoute(nameof(Views.UserDetailView), typeof(Views.UserDetailView));
        }
    }
}
