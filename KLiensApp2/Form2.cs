using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
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
    }
    
}
