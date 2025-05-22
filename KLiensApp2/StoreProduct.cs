using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KLiensApp2
{
    public partial class StoreProduct : Form
    {
        public int Price { get; set; }
        
        public StoreProduct()
        {
            InitializeComponent();
        }

        private bool CheckNumber(string szam)
        {
            Regex r = new Regex("^\\d+$");
            return r.IsMatch(szam);
        }

        private void StoreProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Price = Convert.ToInt32(textBox3.Text);

            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox3, "");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckNumber(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "Kérlek konkrét számértéket adj meg!");
            }
        }
    }
}
