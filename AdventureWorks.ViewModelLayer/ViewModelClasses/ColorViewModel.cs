using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;

namespace AdventureWorks.ViewModelLayer
{
    public class ColorViewModel : ViewModelBase
    {
        private Color? currentEntity = new();

        private readonly IRepository<Color>? repository;

        private ObservableCollection<Color> colors = new();

        public ColorViewModel() : base()
        {
        }

        public ColorViewModel(IRepository<Color> repo) : base()
        {
            repository = repo;
        }

        public Color? CurrentEntity
        {
            get => currentEntity;
            set
            {
                currentEntity = value;

                RaisePropertyChanged(nameof(CurrentEntity));
            }
        }

        public ObservableCollection<Color> Colors
        {
            get => colors;
            set
            {
                colors = value;

                RaisePropertyChanged(nameof(Colors));
            }
        }

        public async Task<ObservableCollection<Color>> GetAsync()
        {
            RowsAffected = 0;
            try
            {
                if (repository == null)
                {
                    LastErrorMessage = REPO_NOT_SET;
                }
                else
                {
                    Colors = await repository.GetAsync();

                    RowsAffected = Colors.Count;

                    InfoMessage = $"Found {RowsAffected} colors";
                }
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
            }

            return Colors;
        }

        public async Task<Color?> GetAsync(int id)
        {
            try
            {
                if (repository != null)
                {
                    CurrentEntity = await repository.GetAsync(id);

                    InfoMessage = (CurrentEntity != null) ? "Color found" : $"Color id={id} not found";
                }
                else
                {
                    LastErrorMessage = REPO_NOT_SET;

                    InfoMessage = "Found a MOCK Color";

                    // MOCK Data
                    CurrentEntity = await Task.FromResult(new Color
                    {
                        ColorId = id,
                        ColorName = "Black"
                    });
                }

                RowsAffected = 1;
            }
            catch (Exception ex)
            {
                PublishException(ex);
            }

            return CurrentEntity;
        }

        public async virtual Task<Color?> SaveAsync()
        {
            // TODO: Write code to save data
            return await Task.FromResult(new Color());
        }
    }
}
