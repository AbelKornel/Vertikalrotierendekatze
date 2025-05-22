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

            _context.hcc_SearchQuery.Load();
            _context.ProductsToOrder.Load();
            _context.OrderedProducts.Load();

            comboBox1.DataSource = _context.hcc_SearchQuery.Local;
            comboBox1.DisplayMember = "QueryPhrase";
            listBox1.DataSource = _context.ProductsToOrder.Local;
            listBox1.DisplayMember = "Phrase";
            dataGridView1.DataSource = _context.OrderedProducts.Local;
        }
    }
}
