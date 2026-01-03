using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;

namespace AdventureWorks.DataLayer
{
    public partial class PhoneTypeRepository : IRepository<PhoneType>
    {
        public async Task<ObservableCollection<PhoneType>> GetAsync()
        {
            return await Task.FromResult(new ObservableCollection<PhoneType>()
            {
                new()
                {
                    PhoneTypeId = 1,
                    TypeDescription = @"Mobile",
                },
                new()
                {
                    PhoneTypeId = 2,
                    TypeDescription = @"Home",
                },
                new()
                {
                    PhoneTypeId = 3,
                    TypeDescription = @"Work",
                },
                new()
                {
                    PhoneTypeId = 4,
                    TypeDescription = @"Other",
                },
            });
        }

        public async Task<PhoneType?> GetAsync(int id)
        {
            ObservableCollection<PhoneType> phoneTypes = await GetAsync();

            PhoneType? entity = phoneTypes.Where(row => row.PhoneTypeId == id).FirstOrDefault();

            return entity;
        }
    }
}
