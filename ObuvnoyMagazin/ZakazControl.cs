using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ObuvnoyMagazin
{
    public partial class ZakazControl : UserControl
    {
        public int NomerZakaza { get; set; }
        public string Status { get; set; }
        public string Adress { get; set; }
        public DateTime DataZakaza { get; set; }
        public DateTime DataDostavki { get; set; }
        string connectDB = "Host = localhost; Username = postgres; Password = postgres; Port = 5432; Database = db_obuv_test ";
        public ZakazControl(int nomerzakaza)
        {
            this.NomerZakaza = nomerzakaza;
            InitializeComponent();
        }
        public void SetLabels()
        {
            labelAdress.Text = "Адресс Доствки: " + Adress;
            labelDataDost.Text = "Дата доставки: " + DataDostavki.ToString("dd.MM.yyyy");
            labelDataZakaza.Text = "Дата заказа: " + DataZakaza.ToString("dd.MM.yyyy");
            labelStatusZak.Text = "Статус заказа: " + Status;
            if (Status == "Завершен")
            {
                labelStatusZak.ForeColor = Color.Red;
            }
            if (Status == "Новый")
            {
                labelStatusZak.ForeColor = Color.DarkBlue;
            }
            labelNomerZak.Text = "Номер заказа: " + NomerZakaza.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var con = new NpgsqlConnection(connectDB);
            con.Open();
            var sql = $@"DELETE FROM public.zakaz
	                WHERE nomer_zakaza_pk = '{NomerZakaza}';";    
            var cmd = new NpgsqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Товар успешно удалён","Информация",MessageBoxButtons.OK, MessageBoxIcon.Information);
            var main = (MainForm)Application.OpenForms["MainForm"];
            main.Zakaz();
        }
    }
}
