using System.ComponentModel;

namespace Common.Library
{
    public abstract class CommonBase : INotifyPropertyChanged
    {
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
    }
}
