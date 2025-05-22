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

namespace KLiensApp2
{
    public partial class Form2 : Form
    {
        VertikalDataEntities _context = new VertikalDataEntities();

        public Form2()
        {
            InitializeComponent();


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
                string name = ordering.Name;
                int db = ordering.Quantity;

                /*OrderedProducts newOrderedProduct = new OrderedProducts();
                newOrderedProduct.Quantity = db;
                newOrderedProduct.ProductName = name;

                _context.OrderedProducts.Add(newOrderedProduct);
                _context.SaveChanges();*/
                using (var context = new VertikalDataEntities())
                {
                    var newOrderedProduct = new OrderedProducts
                    {
                        ProductName = name,
                        Quantity = db
                    };

                    context.OrderedProducts.Add(newOrderedProduct);
                    context.SaveChanges();
                }

            }
            DataGridViewUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Kiválasztott sor ID-jének lekérdezése
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OrderID"].Value);

                using (var context = new VertikalDataEntities())
                {
                    // Az entitás lekérdezése az ID alapján
                    var productToDelete = context.OrderedProducts.SingleOrDefault(p => p.OrderID == id);

                    if (productToDelete != null)
                    {
                        // Törlés az adatbázisból
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
}
