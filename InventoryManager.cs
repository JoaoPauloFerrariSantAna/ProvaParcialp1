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

        public void AddProduct(Product product)
        {
            this.ProductList.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            if (!this.ProductList.Contains(product))
            {
                Console.WriteLine("item does not exists, so i cant erased");
                return;
            }

            this.ProductList.Remove(product);
        }

        public List<Product> ConsultStock()
        {
            return this.ProductList;
        }
    }
}
