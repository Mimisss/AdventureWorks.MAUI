using AdventureWorks.DataLayer;
using AdventureWorks.EntityLayer;
using Common.Library;

namespace AdventureWorks.MAUI.ExtensionClasses
{
    public static class ServiceExtensions
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            // Add custom services here
            AddRepositories(services);

            AddViewModels(services);

            AddViews(services);

            AddOthers(services);
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            // Add Repository Classes
            services.AddScoped<IRepository<User>, UserRepository>();

            services.AddScoped<IRepository<PhoneType>, PhoneTypeRepository>();

            services.AddScoped<IRepository<Product>, ProductRepository>();

            services.AddScoped<IRepository<EntityLayer.Color>, ColorRepository>();
        }

        private static void AddViewModels(this IServiceCollection services)
        {
            // Add View Model Classes
            services.AddScoped<MauiViewModelClasses.UserViewModel>();

            services.AddScoped<MauiViewModelClasses.ProductViewModel>();

            services.AddScoped<MauiViewModelClasses.ColorViewModel>();

            services.AddScoped<MauiViewModelClasses.PrivacyPolicyViewModel>();

            services.AddScoped<MauiViewModelClasses.LoginViewModel>();
        }

        private static void AddViews(this IServiceCollection services)
        {
            // Add View Classes
            services.AddScoped<Views.UserDetailView>();

            services.AddScoped<Views.UserListView>();

            services.AddScoped<Views.ProductDetailView>();

            services.AddScoped<Views.ProductListView>();

            services.AddScoped<Views.ColorDetailView>();

            services.AddScoped<Views.ColorListView>();

            services.AddScoped<Views.PrivacyPolicyView>();

            services.AddScoped<Views.LoginView>();
        }

        private static void AddOthers(this IServiceCollection services)
        {
            // Add Other Classes
            services.AddSingleton<ConfigurationClasses.AppSettings>();
        }
    }
}
