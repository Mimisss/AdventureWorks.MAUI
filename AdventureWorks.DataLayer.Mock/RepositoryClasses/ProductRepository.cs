using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;

namespace AdventureWorks.DataLayer
{
    public class ProductRepository : IRepository<Product>
    {
        public async Task<ObservableCollection<Product>> GetAsync()
        {
            return await Task.FromResult(new ObservableCollection<Product>
            {
                new()
                {
                    ProductId = 680,
                    Name = @"HL Road Frame - Black, 58",
                    ProductNumber = @"FR-R92B-58",
                    Color = @"Black",
                    StandardCost = 100.0000m,
                    ListPrice = 1431.5000m,
                    Size = @"58",
                    Weight = 1016.04m,
                    ProductCategoryId = 18,
                    ProductModelId = 6,
                    SellStartDate = new DateTime(2002, 6, 1),
                    SellEndDate = null,
                    DiscontinuedDate = null,
                    ModifiedDate = new DateTime(2008, 3, 11),
                },
                new()
                {
                    ProductId = 707,
                    Name = @"Sport-100 Helmet, Red",
                    ProductNumber = @"HL-U509-R",
                    Color = @"Red",
                    StandardCost = 13.0863m,
                    ListPrice = 34.9900m,
                    Size = null,
                    Weight = 3.4m,
                    ProductCategoryId = 35,
                    ProductModelId = 33,
                    SellStartDate = new DateTime(2005, 7, 1),
                    SellEndDate = null,
                    DiscontinuedDate = null,
                    ModifiedDate = new DateTime(2008, 3, 11),
                },
                new()
                {
                    ProductId = 712,
                    Name = @"AWC Logo Cap",
                    ProductNumber = @"CA-1098",
                    Color = @"Multi",
                    StandardCost = 6.9223m,
                    ListPrice = 8.9900m,
                    Size = null,
                    Weight = 0.80m,
                    ProductCategoryId = 23,
                    ProductModelId = 2,
                    SellStartDate = new DateTime(2005, 7, 1),
                    SellEndDate = null,
                    DiscontinuedDate = null,
                    ModifiedDate = new DateTime(2008, 3, 11),
                },
                new()
                {
                    ProductId = 713,
                    Name = @"Long-Sleeve Logo Jersey, S",
                    ProductNumber = @"LJ-0192-S",
                    Color = @"Multi",
                    StandardCost = 38.4923m,
                    ListPrice = 49.9900m,
                    Size = "S",
                    Weight = null,
                    ProductCategoryId = 25,
                    ProductModelId = 11,
                    SellStartDate = new DateTime(2005, 7, 1),
                    SellEndDate = null,
                    DiscontinuedDate = null,
                    ModifiedDate = new DateTime(2008, 3, 11),
                }
            });
        }

        public async Task<Product?> GetAsync(int id)
        {
            ObservableCollection<Product> products = await GetAsync();

            Product? entity = products.Where(row => row.ProductId == id).FirstOrDefault();

            return entity;
        }
    }
}
