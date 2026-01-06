using Common.Library;
using System.Windows.Input;

namespace AdventureWorks.MAUI.MauiViewModelClasses
{
    public class ColorViewModel : ViewModelLayer.ColorViewModel
    {
        public ColorViewModel() : base() 
        {
        }

        public ColorViewModel(IRepository<EntityLayer.Color> repo) : base(repo) 
        {
        }

        public ICommand? SaveCommand { get; private set; }

        public ICommand? EditCommand { get; private set; }

        public ICommand? CancelCommand { get; private set; }

        public override void Init()
        {
            base.Init();

            SaveCommand = new Command(async () => await SaveAsync());

            EditCommand = new Command<int>(async (int id) => await EditAsync(id));

            CancelCommand = new Command(async () => await CancelAsync());
        }

        public override async Task<EntityLayer.Color?> SaveAsync()
        {
            EntityLayer.Color? result = await base.SaveAsync();

            if (result != null)
            {
                await Shell.Current.GoToAsync("..");
            }

            return result;
        }

        public async Task EditAsync(int id)
        {
            await Shell.Current.GoToAsync($"{nameof(Views.ColorDetailView)}?id={id}");
        }

        public async Task CancelAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
