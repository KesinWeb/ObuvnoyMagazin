using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ObuvnoyMagazin
{
    public partial class Autorizacia : Form
    {
        string connectDB = "Host = localhost; Username = postgres; Password = postgres; Port = 5432; Database = db_obuv_test ";
        public Autorizacia()
        {
            InitializeComponent();
            
        }
        public void Aut() 
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectDB)) 
            {
                con.Open();
                var sql = $@"SELECT roles.role_name, fio, login, password
	                        FROM public.users
	                        JOIN public.roles ON roles.id = users.role_fk
                            WHERE login = '{textBoxLogin.Text}' AND password = '{textBoxPassword.Text}' ";
                NpgsqlCommand cmd = new NpgsqlCommand(sql,con);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Успешная авторизация", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainForm mainForm = new MainForm(reader.GetString(0), reader.GetString(1));
                    mainForm.ShowDialog();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Неправильный логин или пароль, либо вы не заполнили поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void buttonVhodGost_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm("Гость", "");
            mainForm.ShowDialog();
            this.Close();
        }
        
        private void buttonAutorizacia_Click(object sender, EventArgs e)
        {
            Aut();
        }
    }
}
