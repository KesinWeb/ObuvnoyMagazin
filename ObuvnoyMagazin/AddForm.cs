using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObuvnoyMagazin
{
    public partial class AddForm : Form
    {
        List<Control> controls = new List<Control>();
        string connectDB = "Host = localhost; Username = postgres; Password = postgres; Port = 5432; Database = db_obuv_test ";
        public AddForm()
        {
            InitializeComponent();
            controls.Add(maskedTextBoxArticle);
            controls.Add(maskedTextBoxSale);
            controls.Add(comboBoxCateg);
            controls.Add(comboBoxNameTovar);
            controls.Add(comboBoxPostav);
            controls.Add(comboBoxProiz);
            controls.Add(numericUpDownDiscount);
            controls.Add(numericUpDownQuantity);
            controls.Add(textBoxOpisanie);
            controls.ForEach(control => control.Click += (sen, ev) => 
            {
                control.BackColor = Color.White;
                if (control is MaskedTextBox) 
                {
                    ((MaskedTextBox)control).Clear();
                }
            });
        }
        private void AddTovar() 
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectDB)) 
            {
                    con.Open();
                    string inssql = @"INSERT INTO public.tovar(
	                id_article, name_tovar_fk, edinic_izm, sale, postavshik_fk, proizvoditel_fk, category_fk, discount, quantity, opisanie, picture)
	                VALUES (@id_article,
	                (select id from name_tovar where name_tovar_pk = @name_tovar),
	                @edizm, 
	                @sale,
	                (select id from postavshik where postavshik_pk = @postavshik), 
	                (select id from proizvoditel where proizvoditel_pk = @proizvod), 
	                (select id from category where category_pk = @category), 
	                @discount,
	                @quantity, 
	                @opisanie,
	                @picture) ; ";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(inssql, con))
                    {
                        cmd.Parameters.AddWithValue("@id_article", maskedTextBoxArticle.Text);
                        cmd.Parameters.AddWithValue("@name_tovar", comboBoxNameTovar.Text);
                        cmd.Parameters.AddWithValue("@edizm", labelEdIzm.Text);
                        cmd.Parameters.AddWithValue("@sale", Convert.ToDouble(maskedTextBoxSale.Text));
                        cmd.Parameters.AddWithValue("@postavshik", comboBoxPostav.Text);
                        cmd.Parameters.AddWithValue("@proizvod", comboBoxProiz.Text);
                        cmd.Parameters.AddWithValue("@category", comboBoxCateg.Text);
                        cmd.Parameters.AddWithValue("@discount", Convert.ToInt32(numericUpDownDiscount.Text));
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(numericUpDownQuantity.Text));
                        cmd.Parameters.AddWithValue("@opisanie", textBoxOpisanie.Text);
                        if (buttonDownloadImage.Text == "Загрузить фото")
                        {
                            cmd.Parameters.AddWithValue("@picture", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@picture", buttonDownloadImage.Text);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        

        private void buttonTovarAdd_Click(object sender, EventArgs e)
        {
            bool HasError = false;
            controls.ForEach(control => 
            {
                if (string.IsNullOrEmpty(null))
                {
                    HasError = true;
                    control.BackColor = Color.Red;
                }    
            });
            if (HasError)
            {
                MessageBox.Show("Ошибка пожалуйста заполните поля", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                AddTovar();
                MessageBox.Show("Товар успешно добавлен", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                MainForm main = (MainForm)Application.OpenForms["MainForm"];
                main.Tovar();
            }
        }
    }
}
