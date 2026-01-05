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
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            // Add Repository Classes
            services.AddScoped<IRepository<User>, UserRepository>();

            services.AddScoped<IRepository<PhoneType>, PhoneTypeRepository>();
        }

        private static void AddViewModels(this IServiceCollection services)
        {
            // Add View Model Classes
            services.AddScoped<MauiViewModelClasses.UserViewModel>();
        }

        private static void AddViews(this IServiceCollection services)
        {
            // Add View Classes
            services.AddScoped<Views.UserDetailView>();

            services.AddScoped<Views.UserListView>();
        }
    }
}
