using System.Runtime.CompilerServices;

namespace ApiProvaParcial
{
    public class InventoryManager
    {
        private List<Product> ProductList { get; set; }

        public InventoryManager(List<Product> productList)
        {
            this.ProductList = productList;
        }

        private Product QueryProductInStock(string productName)
        {
            Product product = null;

            foreach (Product p in this.ProductList)
            {
                if (productName == p.Name)
                {
                    // copy product's info
                    product.Id = p.Id;
                    product.Quantity = p.Quantity;
                    break;
                }
            }

            return product;
        }

        public void AddProduct(Product product)
        {
            this.ProductList.Add(product);
        }

        public void RemoveProduct(string productName)
        {
            Product productToRemove = this.QueryProductInStock(productName);

            if (productToRemove == null)
            {
                throw new Exception("Handle case of given product not being there");
            }

            this.ProductList.Remove(productToRemove);
        }

        public List<Product> ConsultStock()
        {
            return this.ProductList;
        }
    }
}
