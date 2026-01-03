
using Common.Library;

namespace AdventureWorks.EntityLayer
{
    public class PhoneType : EntityBase
    {
        private int phoneTypeId;

        private string typeDescription = string.Empty;

        public int PhoneTypeId
        {
            get { return phoneTypeId; }
            set
            {
                phoneTypeId = value;

                RaisePropertyChanged(nameof(PhoneTypeId));
            }
        }
        public string TypeDescription
        {
            get { return typeDescription; }
            set
            {
                typeDescription = value;

                RaisePropertyChanged(nameof(TypeDescription));
            }
        }
    }
}
