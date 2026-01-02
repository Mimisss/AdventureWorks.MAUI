using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Common.Library
{
    public abstract class CommonBase : INotifyPropertyChanged
    {
        private string infoMessage = string.Empty;

        private string lastErrorMessage = string.Empty;

        private Exception? lastException = null;

        protected CommonBase()
        {
            Init();
        }

        public virtual void Init()
        {
            // Initialize properties
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void RaisePropertyChanged(string propertyName)
        {
            // Notify MAUI controls that the property has changed
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // NotMapped: Each entity class inherits from this class and these properties
        // should not be mapped to database columns
        [NotMapped]

        // JsonIgnore: Prevent sending these properties as JSON when serializing/deserializing
        // an entity object through a Web API
        [JsonIgnore]
        public string InfoMessage
        {
            get => infoMessage;
            set
            {
                infoMessage = value;

                RaisePropertyChanged(nameof(InfoMessage));
            }
        }

        [NotMapped]
        [JsonIgnore]
        public string LastErrorMessage
        {
            get => lastErrorMessage;
            set
            {
                lastErrorMessage = value;

                RaisePropertyChanged(nameof(LastErrorMessage));
            }
        }

        [NotMapped]
        [JsonIgnore]
        public Exception? LastException
        {
            get => lastException;
            set
            {
                lastException = value;

                lastErrorMessage = lastException?.Message ?? string.Empty;

                RaisePropertyChanged(nameof(LastException));
            }
        }
    }
}
