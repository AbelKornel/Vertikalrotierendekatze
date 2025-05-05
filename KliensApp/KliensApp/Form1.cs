using KliensApp.Data;
using KliensApp.Models;
using System.Windows.Forms;


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

                var phrase = new ProductsToOrder {
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
            /* felugr� ablak, meg lehet adni az egys�g�rat, le�r�st, k�p?? 
             le�r�s tartalma beker�l a search �s meta keywordsbe �s a descriptionbe
             slug -- sku
              OK gombbal bez�r�s eset�n az instock �t�ll�t�dik*/
        }

        private void hccSearchQueryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
