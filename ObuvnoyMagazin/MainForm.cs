using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Npgsql;

namespace ObuvnoyMagazin
{

    public partial class MainForm : Form
    {
        string connectDB = "Host = localhost; Username = postgres; Password = postgres; Port = 5432; Database = db_obuv_test ";
        public string Role { get; set; }
        public string Fio { get; set; }
        public string Article { get; set; }
        public string Filter = "";
        public string Sort = "";
        public MainForm(string Role, string Fio)
        {
            InitializeComponent();
            this.Role = Role;
            this.Fio = Fio;
            labelAdm.Text = Role;
            labelFio.Text = Fio;
            textBoxPoisc.TextChanged += (s, e) => Tovar();
            if (Role == "Менеджер")
            {
                buttonTovarAdd.Visible = false;
                buttonZakazAdd.Visible = false;
            }
            if (Role == "Авторизированный клиент" || Role == "Гость")
            {
                buttonTovarAdd.Visible = false;
                buttonZakazAdd.Visible = false;
                buttonZakaz.Visible = false;
                buttonTovar.Visible = false;
                comboBoxPost.Visible = false;
                radioButtonUbv.Visible = false;
                radioButtonVzr.Visible = false;
                textBoxPoisc.Visible = false;
                labelPoisc.Visible = false;
                labelPost.Visible = false;
            }
            Tovar();
        }

        public void Tovar() //метод вывод товаров
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectDB))
            {
                flowLayoutPanel1.Controls.Clear();
                con.Open();
                string sql = $@"SELECT name_tovar.name_tovar_pk, category.category_pk, sale, postavshik.postavshik_pk, proizvoditel.proizvoditel_pk, discount, quantity, opisanie, picture,
	                                ROUND (sale * (100 - discount)/100,2) AS total_sales,
                                    id_article 
	                                FROM public.tovar
	                                JOIN public.name_tovar ON name_tovar.id = tovar.name_tovar_fk
	                                JOIN public.postavshik ON postavshik.id = tovar.postavshik_fk
	                                JOIN public.proizvoditel ON proizvoditel.id = tovar.proizvoditel_fk
	                                JOIN public.category ON category.id = tovar.category_fk
                                    WHERE (name_tovar.name_tovar_pk ILIKE '%{textBoxPoisc.Text}%' OR category.category_pk ILIKE '%{textBoxPoisc.Text}%' OR proizvoditel.proizvoditel_pk ILIKE '%{textBoxPoisc.Text}%' OR opisanie ILIKE '%{textBoxPoisc.Text}%')
                                    AND ('%{Filter}%' IS NULL OR postavshik.postavshik_pk ILIKE '%{Filter}%')
                                    ORDER BY quantity {Sort}";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TovarControl tovar = new TovarControl(Role);
                            tovar.NameTovar = reader.GetString(0);
                            tovar.Category = reader.GetString(1);
                            tovar.Sale = reader.GetDouble(2);
                            tovar.Postavshik = reader.GetString(3);
                            tovar.Proizvoditel = reader.GetString(4);
                            tovar.Discount = reader.GetInt32(5);
                            tovar.QuantitySclad = reader.GetInt32(6);
                            tovar.OpisanieTovara = reader.GetString(7);
                            tovar.Picture = reader.IsDBNull(8) ? "picture.png" : reader.GetString(8);
                            tovar.TotalSales = reader.GetDouble(9);
                            tovar.IdArticle = reader.GetString(10);
                            tovar.SetLabels();
                            flowLayoutPanel1.Controls.Add(tovar);
                        }
                    }
                }
            }
        }
        public void Zakaz() //метод вывод заказа
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectDB))
            {
                flowLayoutPanel1.Controls.Clear();
                con.Open();
                string sql = @"SELECT nomer_zakaza_pk, data_zakaza, data_dostavki, adress.name_adress, status_zakaza.status_zakaza
	                            FROM public.zakaz	
	                            JOIN public.adress ON adress.id = zakaz.adress_fk
	                            JOIN public.status_zakaza ON status_zakaza.id = zakaz.status_zakaza_fk
	                            ORDER BY zakaz.nomer_zakaza_pk ASC";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tovar = new ZakazControl();
                            tovar.NomerZakaza = reader.GetInt32(0);
                            tovar.DataZakaza = reader.GetDateTime(1);
                            tovar.DataDostavki = reader.GetDateTime(2);
                            tovar.Adress = reader.GetString(3);
                            tovar.Status = reader.GetString(4);
                            tovar.SetLabels();
                            flowLayoutPanel1.Controls.Add(tovar);
                        }
                    }
                }
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorizacia autorizacia = new Autorizacia();
            autorizacia.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tovar();
        }

        private void buttonTovarAdd_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm();
            addform.ShowDialog();
        }

        private void radioButtonUbv_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUbv.Checked == true)
            {
                Sort = "DESC";
                Tovar();
            }
        }

        private void radioButtonVzr_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVzr.Checked == true)
            {
                Sort = "ASC";
                Tovar();
            }
        }

        private void comboBoxPost_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxPost.Text == "Все поставщики")
            {
                Tovar();
            }
            else
            {
                Filter = comboBoxPost.Text;
                Tovar();
            }
        }

        private void buttonZakaz_Click(object sender, EventArgs e)
        {
            Zakaz();
        }

        private void buttonZakazAdd_Click(object sender, EventArgs e)
        {
            var addzakazform = new AddZakazForm();
            addzakazform.ShowDialog();
        }
    }
}
