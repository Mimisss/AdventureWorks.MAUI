using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Library
{
    public class ValidationMessage : CommonBase
    {
        private string propertyName = string.Empty;

        private string message = string.Empty;

        public string PropertyName
        { 
            get { return propertyName; } 
            set 
            { 
                propertyName = value; 

                RaisePropertyChanged(nameof(PropertyName));
            }
        }

        public string Message
        {
            get { return message; }
            set
            {
                message = value;

                RaisePropertyChanged(nameof(Message));
            }
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                return $"{Message}";
            }
            else
            {
                return $"{Message} {PropertyName}";
            }
        }
    }
}
