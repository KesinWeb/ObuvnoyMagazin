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

namespace ObuvnoyMagazin
{
    public partial class ZakazControl : UserControl
    {
        public int NomerZakaza { get; set; }
        public string Status { get; set; }
        public string Adress { get; set; }
        public DateTime DataZakaza { get; set; }
        public DateTime DataDostavki { get; set; }
        public ZakazControl()
        {
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
    }
}
