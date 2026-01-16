using AdventureWorks.EntityLayer;
using Common.Library;
using System.Windows.Input;

namespace AdventureWorks.MAUI.MauiViewModelClasses
{
    // Command class is located in the Microsoft.Maui.Controls assembly.
    // That assembly should not be referenced by the agnostic view model layer so
    // this derived class is created in the MAUI project to expose commands.
    public class UserViewModel : ViewModelLayer.UserViewModel
    {
        public UserViewModel() : base()
        {
        }

        public UserViewModel(IRepository<User> repo): base(repo)
        {
        }

        public UserViewModel(IRepository<User> repo, IRepository<PhoneType> phoneRepo) : base(repo, phoneRepo)
        {
        }

        public ICommand? SaveCommand { get; private set; }

        public ICommand? EditCommand { get; private set; }
        
        public ICommand? CancelCommand { get; private set; }

        public ICommand? DeleteCommand { get; private set; }

        public override void Init()
        {
            base.Init();

            SaveCommand = new Command(async () => await SaveAsync());

            EditCommand = new Command<int>(async (int id) => await EditAsync(id));

            CancelCommand = new Command(async () => await CancelAsync());

            DeleteCommand = new Command(async () => await DeleteAsync());
        }

        public async Task EditAsync(int id)
        {
            await Shell.Current.GoToAsync($"{nameof(Views.UserDetailView)}?id={id}");
        }

        public override async Task<User?> SaveAsync()
        {
            User? result = await base.SaveAsync();

            if (result != null)
            {
                await Shell.Current.GoToAsync("..");
            }

            return result;
        }

        public async Task CancelAsync()
        {
            await Shell.Current.GoToAsync("..");
        }

        public async Task<bool> DeleteAsync()
        {
            bool result = false;

            bool perform = await Shell.Current.CurrentPage.DisplayAlert("Delete?", "Delete the User?", "Yes", "No");

            if (perform)
            {
                // TODO: Delete User Here
                User? response = new();

                if (response != null)
                {
                    // Redisplay List
                    await GetAsync();
                }
            }

            return result;
        }
    }
}
