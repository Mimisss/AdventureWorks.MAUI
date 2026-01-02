namespace AdventureWorks.EntityLayer
{
    public class User
    {
        public int UserId { get; set; }
        
        public string LoginId { get; set; } = string.Empty;
        
        public string FirstName { get; set; } = string.Empty;
        
        public string LastName { get; set; } = string.Empty;
        
        public string Email { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;
        
        public string Phone { get; set; } = string.Empty;
        
        public string PhoneType { get; set; } = string.Empty;
        
        public bool IsFullTime { get; set; }
        
        public bool IsEnrolledIn401k { get; set; }
        
        public bool IsEnrolledInHealthCare { get; set; }
        
        public bool IsEnrolledInHSA { get; set; }
        
        public bool IsEnrolledInFlexTime { get; set; }
        
        public bool IsEmployed { get; set; }
        
        public DateTime BirthDate { get; set; } = DateTime.Now.AddYears(-18);
        
        public TimeSpan StartTime { get; set; } = new TimeSpan(8, 0, 0);
    }
}
