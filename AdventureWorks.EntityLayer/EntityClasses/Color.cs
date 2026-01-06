using Common.Library;

namespace AdventureWorks.EntityLayer
{
    public class Color : EntityBase
    {
        private int colorId;

        private string colorName = string.Empty;

        public int ColorId
        {
            get { return colorId; }
            set
            {
                if (colorId != value)
                {
                    colorId = value;
                    RaisePropertyChanged(nameof(ColorId));
                }
            }
        }

        public string ColorName
        {
            get { return colorName; }
            set
            {
                if (colorName != value)
                {
                    colorName = value;
                    RaisePropertyChanged(nameof(ColorName));
                }
            }
        }
    }
}
