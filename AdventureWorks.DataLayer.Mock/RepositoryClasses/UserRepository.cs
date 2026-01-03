using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;

namespace AdventureWorks.DataLayer
{
    public partial class UserRepository : IRepository<User>
    {
        public async Task<ObservableCollection<User>> GetAsync()
        {
            return await Task.FromResult(new ObservableCollection<User>()
            {
                new()
                {
                    UserId = 1,
                    LoginId = @"MichaelThomason",
                    FirstName = @"Michael",
                    LastName = @"Thomason",
                    Email = @"MichaelThomason@advworks.com",
                    Phone = @"615.555.3333",
                    PhoneType = @"Mobile",
                    IsFullTime = true,
                    IsEnrolledIn401k = true,
                    IsEnrolledInHealthCare = true,
                    IsEnrolledInHSA = false,
                    IsEnrolledInFlexTime = false,
                    IsEmployed = true,
                    BirthDate = new DateTime(1985, 3, 15),
                    StartTime = null,
                },
                new()
                {
                    UserId = 2,
                    LoginId = @"SheilaCleverly",
                    FirstName = @"Sheila",
                    LastName = @"Cleverly",
                    Email = @"SheilaCleverly@advworks.com",
                    Phone = @"615.123.3456",
                    PhoneType = @"Other",
                    IsFullTime = false,
                    IsEnrolledIn401k = false,
                    IsEnrolledInHealthCare = true,
                    IsEnrolledInHSA = false,
                    IsEnrolledInFlexTime = false,
                    IsEmployed = true,
                    BirthDate = new DateTime(1981, 6, 9),
                    StartTime = new TimeSpan(7, 30, 0),
                },
                new()
                {
                    UserId = 3,
                    LoginId = @"CatherineAbel",
                    FirstName = @"Catherine",
                    LastName = @"Abel",
                    Email = @"CatherineAbel@advworks.com",
                    Phone = @"615.998.3332",
                    PhoneType = @"Mobile",
                    IsFullTime = true,
                    IsEnrolledIn401k = true,
                    IsEnrolledInHealthCare = true,
                    IsEnrolledInHSA = true,
                    IsEnrolledInFlexTime = true,
                    IsEmployed = true,
                    BirthDate = new DateTime(1979, 4, 5),
                    StartTime = null,
                }
 
                // ADD MORE MOCK DATA HERE
            });
        }

        public async Task<User?> GetAsync(int id)
        {
            ObservableCollection<User> users = await GetAsync();

            User? entity = users.Where(row => row.UserId == id).FirstOrDefault();

            return entity;
        }
    }
}
