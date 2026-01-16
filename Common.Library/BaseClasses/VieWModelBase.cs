namespace Common.Library
{
    public class ViewModelBase : CommonBase
    {
        // Set after each method that either retrieves or modifies data in a data store
        private int rowsAffected;

        private bool isInfoAreaVisible;

        private bool isExceptionAreaVisible;

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
        }

        protected virtual void EndProcessing()
        {
            if (!string.IsNullOrEmpty(LastErrorMessage) ||  LastException != null) 
            {
                IsExceptionAreaVisible = true;
            }
        }
    }
}
