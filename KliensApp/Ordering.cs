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

namespace KliensApp
{
    public partial class Ordering : Form
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Ordering()
        {
            InitializeComponent();
        }

        private bool CheckName(string név)
        {
            return !string.IsNullOrEmpty(név);
        }

        private bool CheckDB(string darab)
        {
            Regex r = new Regex("^\\d+$");
            return r.IsMatch(darab);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            Quantity = Convert.ToInt32(textBox2.Text);

            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckDB(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Kérlek konkrét darabszámot adj meg!");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Kérlek add meg a rendelt termék nevét!");
            }
        }
    }
}
