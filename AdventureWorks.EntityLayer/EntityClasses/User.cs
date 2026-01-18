using Common.Library;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.EntityLayer
{
    /// <summary>
    /// This class contains properties that map
    /// to each field in the dbo.User table.
    /// </summary>
    [Table("User", Schema = "dbo")]
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

        [Display(Name = "User Id")]
        [Required(ErrorMessage = "{0} must be filled in.")]
        public int UserId
        {
            get { return userId; }
            set 
            { 
                userId = value;
                RaisePropertyChanged(nameof(UserId));
            }
        }

        [Display(Name = "Login Id")]
        [Required(ErrorMessage = "{0} must be filled in.")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{0} must be between {2} and {1} characters long.")]
        public string LoginId
        { 
            get { return loginId; }
            set 
            { 
                loginId = value;
                RaisePropertyChanged(nameof(LoginId));
            }
        }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "{0} must be filled in.")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "{0} must be between {2} and {1} characters long.")]
        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                firstName = value;
                RaisePropertyChanged(nameof(FirstName));
            }
        }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "{0} must be filled in.")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "{0} must be between {2} and {1} characters long.")]
        public string LastName 
        {
            get { return lastName; }
            set 
            { 
                lastName = value;
                RaisePropertyChanged(nameof(LastName));
            }
        }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} must be filled in.")]
        [StringLength(256, MinimumLength = 0, ErrorMessage = "{0} must be between {2} and {1} characters long.")]
        public string Email
        {
            get { return email; }
            set 
            { 
                email = value;
                RaisePropertyChanged(nameof(Email));
            }
        }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "{0} must be filled in.")]
        [StringLength(12, MinimumLength = 0, ErrorMessage = "{0} must be between {2} and {1} characters long.")]
        public string Password
        {
            get { return password; }
            set 
            { 
                password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "{0} must be filled in.")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "{0} must be between {2} and {1} characters long.")]
        public string Phone
        {
            get { return phone; }
            set 
            { 
                phone = value;
                RaisePropertyChanged(nameof(Phone));
            }
        }

        [Display(Name = "Phone Type")]        
        [StringLength(10, MinimumLength = 0, ErrorMessage = "{0} must be between {2} and {1} characters long.")]
        public string PhoneType
        {
            get { return phoneType; }
            set 
            { 
                phoneType = value;
                RaisePropertyChanged(nameof(PhoneType));
            }
        }

        [Display(Name = "Is Full Time")]
        public bool IsFullTime
        {
            get { return isFullTime; }
            set 
            { 
                isFullTime = value;
                RaisePropertyChanged(nameof(IsFullTime));
            }
        }

        [Display(Name = "Is Enrolled in 40 1K")]
        public bool IsEnrolledIn401k
        {
            get { return isEnrolledIn401k; }
            set 
            { 
                isEnrolledIn401k = value;
                RaisePropertyChanged(nameof(IsEnrolledIn401k));
            }
        }

        [Display(Name = "Is Enrolled In Health Care")]
        public bool IsEnrolledInHealthCare
        {
            get { return isEnrolledInHealthCare; }
            set 
            { 
                isEnrolledInHealthCare = value;
                RaisePropertyChanged(nameof(IsEnrolledInHealthCare));
            }
        }

        [Display(Name = "Is Enrolled In Hsa")]
        public bool IsEnrolledInHSA
        {
            get { return isEnrolledInHSA; }
            set 
            { 
                isEnrolledInHSA = value;
                RaisePropertyChanged(nameof(IsEnrolledInHSA));
            }
        }

        [Display(Name = "Is Enrolled In Flex Time")]
        public bool IsEnrolledInFlexTime
        {
            get { return isEnrolledInFlexTime; }
            set 
            { 
                isEnrolledInFlexTime = value;
                RaisePropertyChanged(nameof(IsEnrolledInFlexTime));
            }
        }

        [Display(Name = "Is Employed")]
        public bool IsEmployed
        {
            get { return isEmployed; }
            set 
            { 
                isEmployed = value;
                RaisePropertyChanged(nameof(IsEmployed));
            }
        }

        [Display(Name = "Birth Date")]
        public DateTime BirthDate
        {
            get { return birthDate; }
            set 
            { 
                birthDate = value;
                RaisePropertyChanged(nameof(BirthDate));
            }
        }

        [Display(Name = "Start Time")]
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
