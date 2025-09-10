using System.Threading;
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

        private static void CheckSubmittion(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                throw new Exception("Given input is empty");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text;
            UInt16 newId = 0;
            UInt16 productQuantity = 0;
            Product product = null;

            CheckSubmittion(productName);

            productName = productName.Trim();

            newId = ++this.GlobalProductId;
            productQuantity = UInt16.Parse(textBox2.Text);
            product = new Product() { Id = newId, Name = productName, Quantity = productQuantity };

            this.GlobalInventoryManager.AddProduct(product);

            label4.Text = "Inserido com sucesso";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productName = textBox3.Text;

            CheckSubmittion(productName);

            productName = productName.Trim();

            this.GlobalInventoryManager.RemoveProduct(productName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Product> products = this.GlobalInventoryManager.ConsultStock();

            foreach (Product p in products)
            {
                label5.Text += $"- {p.Name}. Stock: {p.Quantity}\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // is creating a button just to "hide" the contents of a label overkill? yes.
            label5.Text = "";
        }
    }
}