using Common.Library;

namespace AdventureWorks.EntityLayer
{
    public partial class Product : EntityBase
    {
        private int productId;

        private string name = string.Empty;

        private string productNumber = string.Empty;

        private string color = string.Empty;

        private decimal standardCost = 1;

        private decimal listPrice = 2;

        private string? size = string.Empty;

        private decimal? weight;

        private int? productCategoryId;

        private int? productModelId;

        private DateTime sellStartDate;

        private DateTime? sellEndDate;

        private DateTime? discontinuedDate;

        private DateTime modifiedDate;

        public int ProductId
        {
            get { return productId; }
            set
            {
                productId = value;
                RaisePropertyChanged(nameof(ProductId));
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string ProductNumber
        {
            get { return productNumber; }
            set
            {
                productNumber = value;
                RaisePropertyChanged(nameof(ProductNumber));
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                RaisePropertyChanged(nameof(Color));
            }
        }

        public decimal StandardCost
        {
            get { return standardCost; }
            set
            {
                standardCost = value;
                RaisePropertyChanged(nameof(StandardCost));
            }
        }

        public decimal ListPrice
        {
            get { return listPrice; }
            set
            {
                listPrice = value;
                RaisePropertyChanged(nameof(ListPrice));
            }
        }

        public string? Size
        {
            get { return size; }
            set
            {
                size = value;
                RaisePropertyChanged(nameof(Size));
            }
        }

        public decimal? Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                RaisePropertyChanged(nameof(Weight));
            }
        }

        public int? ProductCategoryId
        {
            get { return productCategoryId; }
            set
            {
                productCategoryId = value;
                RaisePropertyChanged(nameof(ProductCategoryId));
            }
        }

        public int? ProductModelId
        {
            get { return productModelId; }
            set
            {
                productModelId = value;
                RaisePropertyChanged(nameof(ProductModelId));
            }
        }

        public DateTime SellStartDate
        {
            get { return sellStartDate; }
            set
            {
                sellStartDate = value;
                RaisePropertyChanged(nameof(SellStartDate));
            }
        }

        public DateTime? SellEndDate
        {
            get { return sellEndDate; }
            set
            {
                sellEndDate = value;
                RaisePropertyChanged(nameof(SellEndDate));
            }
        }

        public DateTime? DiscontinuedDate
        {
            get { return discontinuedDate; }
            set
            {
                discontinuedDate = value;
                RaisePropertyChanged(nameof(DiscontinuedDate));
            }
        }

        public DateTime ModifiedDate
        {
            get { return modifiedDate; }
            set
            {
                modifiedDate = value;
                RaisePropertyChanged(nameof(ModifiedDate));
            }
        }
    }
}
