using AdventureWorks.EntityLayer;
using Common.Library;
using System.Collections.ObjectModel;

namespace AdventureWorks.ViewModelLayer
{
    public class ProductViewModel : VieWModelBase
    {
        private Product? currentEntity = new();

        private readonly IRepository<Product>? repository;

        private ObservableCollection<Product> products = new();

        public ProductViewModel() : base()
        {
        }

        public ProductViewModel(IRepository<Product> repo) : base()
        {
            repository = repo;
        }

        public Product? CurrentEntity
        {
            get => currentEntity;
            set
            {
                currentEntity = value;

                RaisePropertyChanged(nameof(CurrentEntity));
            }
        }

        public ObservableCollection<Product> Products
        {
            get => products;
            set
            {
                products = value;

                RaisePropertyChanged(nameof(Products));
            }
        }

        public async Task<ObservableCollection<Product>> GetAsync()
        {
            RowsAffected = 0;
            try
            {
                if (repository == null)
                {
                    LastErrorMessage = REPO_NOT_SET;
                }
                else
                {
                    Products = await repository.GetAsync();

                    RowsAffected = Products.Count;

                    InfoMessage = $"Found {RowsAffected} products";
                }
            }
            catch (Exception ex)
            {
                PublishException(ex);
            }

            return Products;
        }

        public async Task<Product?> GetAsync(int id)
        {
            try
            {
                if (repository != null)
                {
                    CurrentEntity = await repository.GetAsync(id);

                    InfoMessage = (CurrentEntity != null) ? "Product found" : $"Product id={id} not found";
                }
                else
                {
                    LastErrorMessage = REPO_NOT_SET;

                    InfoMessage = "Found a MOCK Product";

                    // MOCK Data
                    CurrentEntity = await Task.FromResult(new Product
                    {
                        ProductId = id,
                        Name = "A New Product",
                        Color = "Black",
                        StandardCost = 10,
                        ListPrice = 20,
                        SellStartDate = Convert.ToDateTime("2023-01-07"),
                        Size = "LG"
                    });
                }

                RowsAffected = 1;
            } 
            catch (Exception ex) 
            {
                RowsAffected = 0;

                PublishException(ex);
            }

            return CurrentEntity;
        }

        public async virtual Task<Product?> SaveAsync()
        {
            // TODO: Write code to save data
            return await Task.FromResult(new Product());
        }
    }
}
