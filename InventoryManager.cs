using System.Runtime.CompilerServices;

namespace ApiProvaParcial
{
    public class InventoryManager
    {
        private List<Product> productList { get; set; }

        public InventoryManager(List<Product> productList)
        {
            this.productList = productList;
        }

        public void AddProduct(Product product)
        {
            this.productList.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            if (!this.productList.Contains(product))
            {
                Console.WriteLine("item does not exists, so i cant erased");
                return;
            }

            this.productList.Remove(product);
        }

        public List<Product> ConsultStock()
        {
            return this.productList;
        }
    }
}
