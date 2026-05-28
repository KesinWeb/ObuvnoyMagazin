using Npgsql;
using ObuvnoyMagazin.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObuvnoyMagazin
{
    public partial class AddZakazForm : Form
    {   
        public AddZakazForm()
        {

            InitializeComponent();
        }
        private void AddZakaz() 
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (comboBoxArticle.Text != null && numericUpDownQuantity.Value > 0) 
            {
                listBox1.Items.Add(comboBoxArticle.Text + " " + numericUpDownQuantity.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
