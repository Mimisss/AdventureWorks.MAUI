using Common.Library;

namespace AdventureWorks.EntityLayer
{
    public class User : EntityBase
    {
        private int userId;
        
        private string loginId = string.Empty;

        private string firstName = string.Empty;

        private string lastName = string.Empty;

        private string email = string.Empty;

        private string password = string.Empty; 

        private string phone = string.Empty;    

        private string phoneType = string.Empty;

        private bool isFullTime;

        private bool isEnrolledIn401k;

        private bool isEnrolledInHealthCare;

        private bool isEnrolledInHSA;

        private bool isEnrolledInFlexTime;

        private bool isEmployed;

        private DateTime birthDate = DateTime.Now.AddYears(-18);

        private TimeSpan? startTime = new TimeSpan(8, 0, 0);

        public int UserId
        {
            get { return userId; }
            set 
            { 
                userId = value;
                RaisePropertyChanged(nameof(UserId));
            }
        }
        
        public string LoginId
        { 
            get { return loginId; }
            set 
            { 
                loginId = value;
                RaisePropertyChanged(nameof(LoginId));
            }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                firstName = value;
                RaisePropertyChanged(nameof(FirstName));
            }
        }
        
        public string LastName 
        {
            get { return lastName; }
            set 
            { 
                lastName = value;
                RaisePropertyChanged(nameof(LastName));
            }
        }

        public string Email
        {
            get { return email; }
            set 
            { 
                email = value;
                RaisePropertyChanged(nameof(Email));
            }
        }
        
        public string Password
        {
            get { return password; }
            set 
            { 
                password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }
        
        public string Phone
        {
            get { return phone; }
            set 
            { 
                phone = value;
                RaisePropertyChanged(nameof(Phone));
            }
        }
        
        public string PhoneType
        {
            get { return phoneType; }
            set 
            { 
                phoneType = value;
                RaisePropertyChanged(nameof(PhoneType));
            }
        }
        
        public bool IsFullTime
        {
            get { return isFullTime; }
            set 
            { 
                isFullTime = value;
                RaisePropertyChanged(nameof(IsFullTime));
            }
        }
        
        public bool IsEnrolledIn401k
        {
            get { return isEnrolledIn401k; }
            set 
            { 
                isEnrolledIn401k = value;
                RaisePropertyChanged(nameof(IsEnrolledIn401k));
            }
        }
        
        public bool IsEnrolledInHealthCare
        {
            get { return isEnrolledInHealthCare; }
            set 
            { 
                isEnrolledInHealthCare = value;
                RaisePropertyChanged(nameof(IsEnrolledInHealthCare));
            }
        }
        
        public bool IsEnrolledInHSA
        {
            get { return isEnrolledInHSA; }
            set 
            { 
                isEnrolledInHSA = value;
                RaisePropertyChanged(nameof(IsEnrolledInHSA));
            }
        }
        
        public bool IsEnrolledInFlexTime
        {
            get { return isEnrolledInFlexTime; }
            set 
            { 
                isEnrolledInFlexTime = value;
                RaisePropertyChanged(nameof(IsEnrolledInFlexTime));
            }
        }
        
        public bool IsEmployed
        {
            get { return isEmployed; }
            set 
            { 
                isEmployed = value;
                RaisePropertyChanged(nameof(IsEmployed));
            }
        }
        
        public DateTime BirthDate
        {
            get { return birthDate; }
            set 
            { 
                birthDate = value;
                RaisePropertyChanged(nameof(BirthDate));
            }
        }
        
        public TimeSpan? StartTime
        {
            get { return startTime; }
            set 
            { 
                startTime = value;
                RaisePropertyChanged(nameof(StartTime));
            }            
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }    

        public string LastNameFirstName
        {
            get { return $"{LastName}, {FirstName}"; }
        }        
    }
}
