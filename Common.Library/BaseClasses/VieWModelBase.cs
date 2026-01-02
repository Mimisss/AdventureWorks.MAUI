namespace Common.Library
{
    public class VieWModelBase : CommonBase
    {
        // Set after each method that either retrieves or modifies data in a data store
        private int rowsAffected;

        public int RowsAffected
        {
            get => rowsAffected;
            set
            {
                rowsAffected = value;

                RaisePropertyChanged(nameof(RowsAffected));
            }
        }
                
        protected virtual void PublishException(Exception ex)
        {
            LastException = ex;

            // Write code to perform logging here
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }
    }
}
