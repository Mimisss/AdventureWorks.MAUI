using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;

namespace AdventureWorks.ViewModelLayer
{
    // A View Model class is used to bind data to the controls on the UI.
    // View models have properties used to set which controls are enabled/visible,
    // and for posting informational and error messages. View models have methods
    // to load data into entities and save data. View model classes may expose an
    // entity object or have properties to expose only those properties of the entity
    // object needed for the UI.
    public class UserViewModel : ViewModelBase
    {
        private User? currentEntity = new();

        private ObservableCollection<string> phoneTypesList = [];

        private readonly IRepository<User>? repository;

        private readonly IRepository<PhoneType>? phoneTypeRepository;

        private ObservableCollection<User> users = new();

        public UserViewModel()
        {
        }

        public UserViewModel(IRepository<User> repo) : base()
        {
            repository = repo;
        }

        public UserViewModel(IRepository<User> repo, IRepository<PhoneType> phoneTypeRepo) : base()
        {
            repository = repo;

            phoneTypeRepository = phoneTypeRepo;
        }

        public User? CurrentEntity
        {
            get => currentEntity;
            set
            {
                currentEntity = value;

                RaisePropertyChanged(nameof(CurrentEntity));
            }
        }

        public ObservableCollection<string> PhoneTypesList
        {
            get => phoneTypesList;
            set
            {
                phoneTypesList = value;

                RaisePropertyChanged(nameof(PhoneTypesList));
            }
        }

        public ObservableCollection<User> Users
        {
            get => users;
            set
            {
                users = value;

                RaisePropertyChanged(nameof(Users));
            }
        }

        // Return a list of users that can be bound to a collection-type control
        public async Task<ObservableCollection<User>> GetAsync()
        {
            BeginProcessing();

            try
            {
                if (repository == null)
                {
                    LastErrorMessage = REPO_NOT_SET;
                }
                else
                {
                    Users = await repository.GetAsync();

                    RowsAffected = Users.Count;

                    InfoMessage = $"Found {RowsAffected} users";
                }
            }
            catch (Exception ex)
            {
                PublishException(ex);
            }

            EndProcessing();

            return Users;
        }

        // Set the CurrentEntity property to a single user object, then return it
        public async Task<User?> GetAsync(int id)
        {
            BeginProcessing();

            try
            {
                // Get a User from a data store 
                if (repository != null)
                {
                    CurrentEntity = await repository.GetAsync(id);

                    InfoMessage = (CurrentEntity != null) ? "User found" : $"User id={id} not found";
                }
                else
                {
                    LastErrorMessage = REPO_NOT_SET;

                    InfoMessage = "Found a MOCK User";

                    // MOCK Data
                    CurrentEntity = await Task.FromResult(new User
                    {
                        UserId = id,
                        LoginId = "SallyJones615",
                        FirstName = "Sally",
                        LastName = "Jones",
                        Email = "Sallyj@jones.com",
                        Phone = "615.987.3456",
                        PhoneType = "Mobile",
                        IsFullTime = true,
                        IsEnrolledIn401k = true,
                        IsEnrolledInFlexTime = false,
                        IsEnrolledInHealthCare = true,
                        IsEnrolledInHSA = false,
                        IsEmployed = true,
                        BirthDate = Convert.ToDateTime("1989-08-13"),
                        StartTime = new TimeSpan(7, 30, 0)
                    });
                }

                RowsAffected = 1;
            }
            catch (Exception ex)
            {
                PublishException(ex);
            }

            EndProcessing();

            return CurrentEntity;
        }

        public async virtual Task<User?> SaveAsync()
        {
            // TODO: Write code to save data
            //System.Diagnostics.Debugger.Break();

            return await Task.FromResult(new User());
        }

        public async Task<ObservableCollection<string>> GetPhoneTypesAsync()
        {
            if (phoneTypeRepository != null)
            {
                var list = await phoneTypeRepository.GetAsync();

                PhoneTypesList = new ObservableCollection<string>(list.Select(row => row.TypeDescription));
            }

            return PhoneTypesList;
        }
    }
}
