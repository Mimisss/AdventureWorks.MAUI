using System.Collections.ObjectModel;

namespace Common.Library
{
    public interface IRepository<TEntity>
    {
        Task<ObservableCollection<TEntity>> GetAsync();

        Task<TEntity?> GetAsync(int id);
    }
}
