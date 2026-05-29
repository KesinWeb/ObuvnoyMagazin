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
        string connectDB = "Host = localhost; Username = postgres; Password = postgres; Port = 5432; Database = db_obuv_test ";
        public AddZakazForm()
        {
            InitializeComponent();
            SetData();
        }
        private void SetData() 
        {
            var con = new NpgsqlConnection(connectDB);
            con.Open();
            var sql = @"SELECT status_zakaza FROM public.status_zakaza;
                        SELECT name_adress FROM public.adress;
                        SELECT fio FROM public.users;
                        SELECT id_article FROM public.tovar;";
            var cmd = new NpgsqlCommand(sql, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            { 
                comboBoxStatus.Items.Add(reader.GetString(0));
            }
            if (reader.NextResult())
            {
                while(reader.Read())
                {
                    comboBoxAdress.Items.Add(reader.GetString(0));
                }
            }
            if (reader.NextResult())
            {
                while (reader.Read())
                {
                    comboBoxFio.Items.Add(reader.GetString(0));
                }
            }
            if (reader.NextResult())
            {
                while (reader.Read())
                {
                    comboBoxArticle.Items.Add(reader.GetString(0));
                }
            }
        }
        private void AddZakaz()
        {
            int zakazId = 0;
            var con = new NpgsqlConnection(connectDB);
            con.Open();
            var sql = @"INSERT INTO public.zakaz(
	data_zakaza, data_dostavki, adress_fk, fio_users_fk, status_zakaza_fk)
	VALUES (@data_zakaza, @data_dostavki, @adress_fk, @fio_users_fk, @status_zakaza_fk) returning nomer_zakaza_pk";  
            var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@data_zakaza", dateTimePickerZakaz.Value);
            cmd.Parameters.AddWithValue("@data_dostavki", dateTimePickerDostavki.Value);
            cmd.Parameters.AddWithValue("@adress_fk", comboBoxAdress.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@fio_users_fk", comboBoxFio.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@status_zakaza_fk", comboBoxStatus.SelectedIndex + 1);
            zakazId = Convert.ToInt32(cmd.ExecuteScalar());
            var sql1 = @"INSERT INTO public.zakaz_tovar(
	                    nomer_zakaza_fk, article_fk, quantity)
	                    VALUES ((select nomer_zakaza_pk from zakaz where nomer_zakaza_pk = @nomer_zakaza), @article, @quantity);";
            var cmd1 = new NpgsqlCommand(sql1, con);
            foreach (var item in listBox1.Items)
            {
                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@article", item.ToString().Split(' ')[0]);
                cmd1.Parameters.AddWithValue("@quantity", Convert.ToInt32(item.ToString().Split(' ')[1]));
                cmd1.Parameters.AddWithValue("@nomer_zakaza", zakazId);
                cmd1.ExecuteNonQuery();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePickerDostavki.Value < dateTimePickerZakaz.Value) { MessageBox.Show("Дата заказа не может быть больше даты доставки, пожалуйста проверьты даты!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);return; }
            else if (comboBoxAdress.Text != null || comboBoxFio.Text != null || comboBoxStatus != null || comboBoxAdress.Text != null || listBox1.Items != null) 
            {
                MessageBox.Show("Пожалуйста заполните все поля!!!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            else
            {  
                AddZakaz();
                MessageBox.Show("Заказ успешно добавлен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                var main = (MainForm)Application.OpenForms["MainForm"];
                main.Zakaz();
            }
        }
    }
}
