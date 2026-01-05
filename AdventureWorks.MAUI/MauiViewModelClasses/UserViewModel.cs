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

        public override void Init()
        {
            base.Init();

            SaveCommand = new Command(async () => await SaveAsync());

            EditCommand = new Command<int>(async (int id) => await EditAsync(id));
        }

        public async Task EditAsync(int id)
        {
            await Shell.Current.GoToAsync($"{nameof(Views.UserDetailView)}?id={id}");
        }
    }
}
