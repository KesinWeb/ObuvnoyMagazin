using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ObuvnoyMagazin
{
    public partial class AddForm : Form
    {
        List<Control> controls = new List<Control>();
        string connectDB = "Host = localhost; Username = postgres; Password = postgres; Port = 5432; Database = db_obuv_test ";
        public bool isRedact { get; set; }
        public string Article { get; set; }
        public string Category { get; set; }
        public string NameTovar { get; set; }
        public string OpisanieTovara { get; set; }
        public string Proizvoditel { get; set; }
        public string Postavshik { get; set; }
        public double Sale { get; set; }
        public int QuantitySclad { get; set; }
        public string Picture { get; set; }
        public int Discount { get; set; }
        public AddForm(bool isRedact, string article)
        {
            InitializeComponent();
            this.isRedact = isRedact;
            isRedact = true;
            labelAddTovar.Text = "Редактирование товара";
            buttonTovarAdd.Text = "Сохранить изменения";
            Article = article;
            comboBoxCateg.Text = Category;
            comboBoxNameTovar.Text = NameTovar;
            comboBoxPostav.Text = Postavshik;
            comboBoxProiz.Text = Proizvoditel;
            textBoxOpisanie.Text = OpisanieTovara;
            numericUpDownDiscount.Value = Discount;
            numericUpDownQuantity.Value = QuantitySclad;
            maskedTextBoxSale.Text = Sale.ToString();
            maskedTextBoxArticle.Text = Article;
            maskedTextBoxArticle.Enabled = false;
        }
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
        public void SelectRedact()
        {
            var con = new NpgsqlConnection(connectDB);
            con.Open();
            var sql = $@"SELECT name_tovar.name_tovar_pk, category.category_pk, sale, postavshik.postavshik_pk, proizvoditel.proizvoditel_pk, discount, quantity, opisanie, picture,
                                    id_article 
	                                FROM public.tovar
	                                JOIN public.name_tovar ON name_tovar.id = tovar.name_tovar_fk
	                                JOIN public.postavshik ON postavshik.id = tovar.postavshik_fk
	                                JOIN public.proizvoditel ON proizvoditel.id = tovar.proizvoditel_fk
	                                JOIN public.category ON category.id = tovar.category_fk
                                    WHERE id_article = '{Article}'";
            var cmd = new NpgsqlCommand(sql, con);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                comboBoxNameTovar.Text = reader.GetString(0);
                comboBoxCateg.Text = reader.GetString(1);
                maskedTextBoxSale.Text = reader.GetDouble(2).ToString();
                comboBoxPostav.Text = reader.GetString(3);
                comboBoxProiz.Text = reader.GetString(4);
                numericUpDownDiscount.Value = reader.GetInt32(5);
                numericUpDownQuantity.Value = reader.GetInt32(6);
                textBoxOpisanie.Text = reader.GetString(7);
                pictureBoxPhoto.ImageLocation = reader.IsDBNull(8) ? Path.Combine(Application.StartupPath, "images") + "\\" + "picture.png" : Path.Combine(Application.StartupPath, "images") + "\\" + reader.GetString(8);
                buttonDownloadImage.Text = reader.IsDBNull(8) ? "Загрузить фото" : reader.GetString(8);
                maskedTextBoxArticle.Text = reader.GetString(9);
            }
        }
        public void RedactTovar()
        {
            var con = new NpgsqlConnection(connectDB);
            con.Open();
            var sql = $@"UPDATE public.tovar
	            SET id_article=@id_article, 
                name_tovar_fk=(select id from name_tovar where name_tovar_pk = @name_tovar), 
                edinic_izm=@edizm,
                sale=@sale, 
                postavshik_fk=(select id from postavshik where postavshik_pk = @postavshik), 
                proizvoditel_fk=(select id from proizvoditel where proizvoditel_pk = @proizvod),
                category_fk=(select id from category where category_pk = @category), 
                discount=@discount, 
                quantity=@quantity, 
                opisanie=@opisanie, 
                picture=@picture
	            WHERE id_article = '{Article}' ;";
            var cmd = new NpgsqlCommand(sql, con);
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
        private void buttonTovarAdd_Click(object sender, EventArgs e)
        {
            bool HasError = false;
            controls.ForEach(control =>
            {
                if (string.IsNullOrEmpty(control.Text))
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
                if (isRedact)
                {
                    RedactTovar();
                    MessageBox.Show("Товар успешно обновлён", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    MainForm main = (MainForm)Application.OpenForms["MainForm"];
                    main.Tovar();
          
                }
                else
                {
                    AddTovar();
                    MessageBox.Show("Товар успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    MainForm main = (MainForm)Application.OpenForms["MainForm"];
                    main.Tovar();
                }
            }
        }

            private void buttonDownloadImage_Click(object sender, EventArgs e)
            {
                var dialog = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp" };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var image = Path.Combine(Path.Combine(Application.StartupPath, "images"), dialog.SafeFileName);
                    File.Copy(dialog.FileName, image, true);
                    pictureBoxPhoto.Image = Image.FromFile(image);
                    buttonDownloadImage.Text = dialog.SafeFileName;
                    MessageBox.Show("Фото загружено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
    }
}
