using KliensApp.Data;
using KliensApp.Models;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;




namespace KliensApp
{
    public partial class Form1 : Form
    {
        private readonly KliensDbContext _context;


        public Form1()
        {
            InitializeComponent();
            _context = new KliensDbContext();

        }
        
        private static Api apiHivas()
        {
            string url = "http://rendfejl1018.northeurope.cloudapp.azure.com/";
            string kulcs = "1-40db881d-4fed-4469-9c36-00f257bf6789";

            Api proxy = new Api(url, kulcs);
            return proxy;
        }

        private void ListUpdate()
        {
            var toOrder = from x in _context.ProductsToOrder
                          select x;
            productsToOrderBindingSource.DataSource = toOrder.ToList();
        }
        private void DataGridViewUpdate()
        {
            var ordered = from x in _context.OrderedProducts
                          select x;
            orderedProductsBindingSource.DataSource = ordered.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var ker = from x in _context.HccSearchQuery
                      orderby x.LastUpdated descending
                      select x;

            hccSearchQueryBindingSource.DataSource = ker.ToList();

            ListUpdate();
            DataGridViewUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var kivalasztott = (HccSearchQuery)hccSearchQueryBindingSource.Current;

                var phrase = new ProductsToOrder
                {
                    Phrase = kivalasztott.QueryPhrase
                };

                _context.ProductsToOrder.Add(phrase);
                _context.SaveChanges();
                ListUpdate();

            }
            else
            {
                MessageBox.Show("Nincs kiv�lasztott kifejez�s!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ordering ordering = new Ordering();


            if (ordering.ShowDialog() == DialogResult.OK)
            {
                string name = ordering.Name;
                int db = ordering.Quantity;

                using (var context = new KliensDbContext())
                {
                    var newOrderedProduct = new OrderedProducts
                    {
                        ProductName = name,
                        Quantity = db
                    };

                    context.OrderedProducts.Add(newOrderedProduct);
                    context.SaveChanges();
                }
                DataGridViewUpdate();


            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Api proxy = apiHivas();

            // create a new instance of a product
            var product = new ProductDTO();

            // populate the product object with minimal information
            product.ProductName = "teszt";
            product.Sku = "TP001";
            product.SitePrice = 10000;
            product.InventoryMode = ProductInventoryModeDTO.AlwayInStock;

            // call the API to create the new product
            ApiResponse<ProductDTO> response = proxy.ProductsCreate(product, null);
        }
        
        private void hccSearchQueryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void OrderManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztosan be akarod z�rni?", "Meger�s�t�s", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
          

    }
}
