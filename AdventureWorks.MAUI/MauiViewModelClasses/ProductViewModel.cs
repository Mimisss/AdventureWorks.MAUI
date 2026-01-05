using AdventureWorks.EntityLayer;
using Common.Library;

namespace AdventureWorks.MAUI.MauiViewModelClasses
{
    public class ProductViewModel : ViewModelLayer.ProductViewModel
    {
        public ProductViewModel() : base()
        {
        }

        public ProductViewModel(IRepository<Product> repo) : base(repo)
        {
        }
    }
}
