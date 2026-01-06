using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;

namespace AdventureWorks.DataLayer
{
    public class ColorRepository : IRepository<Color>
    {
        public async Task<ObservableCollection<Color>> GetAsync()
        {
            return await Task.FromResult(new ObservableCollection<Color>
            {
                new() { ColorId = 1, ColorName = "Black" },
                new() { ColorId = 2, ColorName = "Blue" },
                new() { ColorId = 3, ColorName = "Gray" },
                new() { ColorId = 4, ColorName = "Purple" },
                new() { ColorId = 5, ColorName = "Red" },
                new() { ColorId = 6, ColorName = "Green" },
                new() { ColorId = 7, ColorName = "DarkViolet" },
                new() { ColorId = 8, ColorName = "SkyBlue" },
                new() { ColorId = 9, ColorName = "Yellow" }
            });
        }

        public async Task<Color?> GetAsync(int id)
        { 
            ObservableCollection<Color> colors = await GetAsync();

            Color? entity = colors.Where(row => row.ColorId == id).FirstOrDefault();

            return entity;
        }
    }
}
