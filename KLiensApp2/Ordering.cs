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

namespace KLiensApp2
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            Quantity = Convert.ToInt32(textBox2.Text);

            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void textBox1_Validated_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void textBox1_Validating_1(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Kérlek add meg a rendelt termék nevét!");
            }
        }

        private void textBox2_Validated_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
        }

        private void textBox2_Validating_1(object sender, CancelEventArgs e)
        {
            if (!CheckDB(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Kérlek konkrét darabszámot adj meg!");
            }
        }
    }
}
