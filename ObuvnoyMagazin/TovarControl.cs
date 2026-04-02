using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ObuvnoyMagazin
{
    public partial class TovarControl : UserControl
    {
        string connectDB = "Host = localhost; Username = postgres; Password = postgres; Port = 5432; Database = db_obuv_test ";
        public string IdArticle { get; set; }
        public string Category { get; set; }
        public string NameTovar { get; set; }
        public string OpisanieTovara { get; set; }
        public string Proizvoditel { get; set; }
        public string Postavshik { get; set; }
        public double Sale { get; set; }
        public int QuantitySclad { get; set; }
        public string Picture { get; set; }
        public int Discount { get; set; }
        public double TotalSales { get; set; }


        public TovarControl()
        {
            InitializeComponent();

        }
        public void SetLabels()
        {
            labelCategory.Text = Category;
            labelName_tovar.Text = NameTovar;
            labelOpisanie.Text = "Описание товара: " + OpisanieTovara;
            labelProizvoditel.Text = "Производитель: " + Proizvoditel;
            labelPostavshik.Text = "Поставщик: " + Postavshik;
            labelSale.Text = "Цена: " + Sale.ToString() + " руб.";
            labelQuantitySclad.Text = "Количество на складе: " + QuantitySclad.ToString();
            if (QuantitySclad == 0)
            {
                labelQuantitySclad.ForeColor = Color.DarkCyan;
            }
            labelDiscount.Text = Discount.ToString() + "%";
            if (Discount > 15)
            {
                labelDiscount.BackColor = ColorTranslator.FromHtml("#2E8B57");
            }
            if (Discount == 0)
            {
                labelTotalSales.Visible = false;
            }
            else
            {
                labelDiscount.Visible = true;
                labelSale.Font = new Font(labelSale.Font, FontStyle.Strikeout);
                labelSale.ForeColor = Color.Red;
            }
            labelTotalSales.Text = TotalSales.ToString() + " руб.";
            pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, "images") + "\\" + Picture;
        }

        private void buttonDownloadImage_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectDB)) 
            {
                con.Open();
                string proverka = $@"SELECT * FROM public.zakaz_tovar WHERE article_fk = '{IdArticle}' ;";
                using (NpgsqlCommand cmd = new NpgsqlCommand(proverka, con)) 
                {
                    int orderCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (orderCount > 0)
                    {
                        MessageBox.Show("Невозможно удалить товар так как он в заказе","Предупреждение", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Вы точно хотите удалить товар?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                        {
                            string delete = $@"DELETE FROM public.tovar
	                                        WHERE id_article = '{IdArticle}' ; ";
                            using (NpgsqlCommand command = new NpgsqlCommand(delete,con)) 
                            {
                                command.ExecuteNonQuery();
                                {
                                    con.Close();
                                }
                                MessageBox.Show("Товар успешно удалён", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Parent.Controls.Remove(this);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}