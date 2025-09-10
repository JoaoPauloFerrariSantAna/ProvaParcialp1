using ApiProvaParcial;

namespace ProvaParcialP1
{
    public partial class Form1 : Form
    {
        private UInt16 GlobalProductId;
        private InventoryManager GlobalInventoryManager = new InventoryManager(new List<Product>());

        public Form1(UInt16 GlobalProductId, InventoryManager GlobalInventoryManager)
        {
            this.GlobalProductId = GlobalProductId;
            this.GlobalInventoryManager = GlobalInventoryManager;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text;

            if (String.IsNullOrEmpty(productName))
            {
                throw new Exception("Add error handling");
            }

            productName = productName.Trim();

            UInt16 newId = ++this.GlobalProductId;
            UInt16 productQuantity = UInt16.Parse(textBox2.Text);
            Product product = new Product() { Id = newId, Name = productName, Quantity = productQuantity };

            this.GlobalInventoryManager.AddProduct(product);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product productToRemove = new Product();

            string productName = textBox3.Text;

            if (String.IsNullOrEmpty(productName))
            {
                throw new Exception("Add error handling");
            }

            productName = productName.Trim();

            // first of all, we need to fill the "productToRemove"'s fields
            // so that when we  get to this.GlobalInventoryManager.Contains it does not errs
            foreach (Product p in this.GlobalInventoryManager.ConsultStock())
            {
                if (productName == p.Name)
                {
                    // because then we'll copy p into productToRemove
                    productToRemove = p;
                    break;
                }
            }

            this.GlobalInventoryManager.RemoveProduct(productToRemove);
        }
    }
}
