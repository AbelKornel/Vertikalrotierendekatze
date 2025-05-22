using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Shipping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KLiensApp2
{
    public partial class Form2 : Form
    {
        VertikalDataEntities _context = new VertikalDataEntities();

        public Form2()
        {
            InitializeComponent();


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
            listBox1.DataSource = toOrder.ToList();
            listBox1.DisplayMember = "Phrase";
        }

        private void DataGridViewUpdate()
        {
            var ordered = from x in _context.OrderedProducts
                          select x;
            dataGridView1.DataSource = ordered.ToList();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztosan be akarod zárni?", "Megerősítés", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var kivalasztott = comboBox1.SelectedItem as hcc_SearchQuery;

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
                MessageBox.Show("Nincs kiválasztott kifejezés!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            var ker = from x in _context.hcc_SearchQuery
                      orderby x.LastUpdated descending
                      select x;

            comboBox1.DataSource = ker.ToList();
            comboBox1.DisplayMember = "QueryPhrase";

            ListUpdate();
            DataGridViewUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ordering ordering = new Ordering();


            if (ordering.ShowDialog() == DialogResult.OK)
            {

                OrderedProducts newOrderedProduct = new OrderedProducts();
                newOrderedProduct.Quantity = ordering.Quantity;
                newOrderedProduct.ProductName = ordering.Name;
                newOrderedProduct.Price = ordering.Price;

                _context.OrderedProducts.Local.Add(newOrderedProduct);
                try
                {
                    _context.SaveChanges();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataGridViewUpdate(); 

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztosan törölni akarod??", "Megerősítés", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OrderID"].Value);

                    using (var context = new VertikalDataEntities())
                    {

                        var productToDelete = context.OrderedProducts.SingleOrDefault(p => p.OrderID == id);

                        if (productToDelete != null)
                        {

                            context.OrderedProducts.Remove(productToDelete);
                            context.SaveChanges();

                            MessageBox.Show("Törlés sikeres.");
                        }
                        else
                        {
                            MessageBox.Show("A termék nem található.");
                        }
                    }

                    DataGridViewUpdate();
                }
                else
                {
                    MessageBox.Show("Kérlek válassz ki egy sort.");
                }
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Api proxy = apiHivas();

                // create a new instance of a product
                var product = new ProductDTO();

                // populate the product object with minimal information
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    product.ProductName = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
                    product.Sku = "KLP" + dataGridView1.CurrentRow.Cells[0].Value?.ToString();
                    product.SitePrice = 10000;
                    product.InventoryMode = ProductInventoryModeDTO.AlwayInStock;
                }
                else 
                {
                    MessageBox.Show("Kérlek válassz ki egy sort!");
                }


                    // call the API to create the new product
                    ApiResponse<ProductDTO> response = proxy.ProductsCreate(product, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
