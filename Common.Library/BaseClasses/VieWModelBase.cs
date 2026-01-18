using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Common.Library
{
    public class ViewModelBase : CommonBase
    {
        // Set after each method that either retrieves or modifies data in a data store
        private int rowsAffected;

        private bool isInfoAreaVisible;

        private bool isExceptionAreaVisible;

        private bool isValidationAreaVisible;

        private ObservableCollection<ValidationMessage> validationMessages = new();

        public int RowsAffected
        {
            get => rowsAffected;
            set
            {
                rowsAffected = value;

                RaisePropertyChanged(nameof(RowsAffected));
            }
        }
        
        public bool IsInfoAreaVisible
        {
            get { return isInfoAreaVisible; }
            set
            {  
                isInfoAreaVisible = value;

                RaisePropertyChanged(nameof(IsInfoAreaVisible));
            }
        }

        public bool IsExceptionAreaVisible
        {
            get { return isExceptionAreaVisible; }
            set
            {
                isExceptionAreaVisible = value;

                RaisePropertyChanged(nameof(IsExceptionAreaVisible));
            }
        }

        public bool IsValidationAreaVisible
        {
            get { return isValidationAreaVisible; }
            set
            {
                isValidationAreaVisible = value;

                RaisePropertyChanged(nameof(IsValidationAreaVisible));
            }
        }

        public ObservableCollection<ValidationMessage> ValidationMessages
        {
            get { return validationMessages; }
            set
            {
                validationMessages = value;

                RaisePropertyChanged(nameof(ValidationMessages));
            }
        }

        protected virtual void PublishException(Exception ex)
        {
            LastException = ex;

            // Write code to perform logging here
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }

        protected virtual void BeginProcessing()
        {
            InfoMessage = string.Empty;

            LastErrorMessage = string.Empty;

            LastException = null;

            RowsAffected = 0;

            IsInfoAreaVisible = true;

            IsExceptionAreaVisible = false;

            IsValidationAreaVisible = false;

            ValidationMessages.Clear();
        }

        protected virtual void EndProcessing()
        {
            if (!string.IsNullOrEmpty(LastErrorMessage) ||  LastException != null) 
            {
                IsExceptionAreaVisible = true;
            }

            IsValidationAreaVisible = ValidationMessages.Count > 0;
        }

        public bool Validate<T>(T entity)
        {
            ValidationMessages.Clear();
            if (entity != null)
            {                
                ValidationContext context = new(entity, serviceProvider: null, items: null);
                
                List<ValidationResult> results = new();
                
                
                if (!Validator.TryValidateObject(entity, context, results, true))
                {
                    // Get validation results
                    foreach (ValidationResult item in results)
                    {
                        string propName = string.Empty;

                        if (item.MemberNames.Any())
                        {
                            propName = ((string[])item.MemberNames)[0];
                        }

                        // Build new ValidationMessage object
                        ValidationMessage msg = new()
                        {
                            Message = item.ErrorMessage ?? string.Empty,
                            PropertyName = propName
                        };
                                                
                        ValidationMessages.Add(msg);
                    }
                }
            }

            IsValidationAreaVisible = ValidationMessages.Count > 0;

            return !IsValidationAreaVisible;
        }
    }
}
