namespace ObuvnoyMagazin
{
    partial class TovarControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalSales = new System.Windows.Forms.Label();
            this.labelQuantitySclad = new System.Windows.Forms.Label();
            this.labelEdIzm = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            this.labelPostavshik = new System.Windows.Forms.Label();
            this.labelProizvoditel = new System.Windows.Forms.Label();
            this.labelOpisanie = new System.Windows.Forms.Label();
            this.labelName_tovar = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.buttonRedact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.buttonRedact);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelTotalSales);
            this.panel1.Controls.Add(this.labelQuantitySclad);
            this.panel1.Controls.Add(this.labelEdIzm);
            this.panel1.Controls.Add(this.labelSale);
            this.panel1.Controls.Add(this.labelPostavshik);
            this.panel1.Controls.Add(this.labelProizvoditel);
            this.panel1.Controls.Add(this.labelOpisanie);
            this.panel1.Controls.Add(this.labelName_tovar);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(135, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 106);
            this.panel1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(366, 78);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 22);
            this.buttonDelete.TabIndex = 40;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDownloadImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "|";
            // 
            // labelTotalSales
            // 
            this.labelTotalSales.AutoSize = true;
            this.labelTotalSales.Location = new System.Drawing.Point(111, 60);
            this.labelTotalSales.Name = "labelTotalSales";
            this.labelTotalSales.Size = new System.Drawing.Size(77, 14);
            this.labelTotalSales.TabIndex = 10;
            this.labelTotalSales.Text = "Итоговая цена";
            // 
            // labelQuantitySclad
            // 
            this.labelQuantitySclad.AutoSize = true;
            this.labelQuantitySclad.ForeColor = System.Drawing.Color.Black;
            this.labelQuantitySclad.Location = new System.Drawing.Point(13, 86);
            this.labelQuantitySclad.Name = "labelQuantitySclad";
            this.labelQuantitySclad.Size = new System.Drawing.Size(112, 14);
            this.labelQuantitySclad.TabIndex = 7;
            this.labelQuantitySclad.Text = "Количество на складе:";
            // 
            // labelEdIzm
            // 
            this.labelEdIzm.AutoSize = true;
            this.labelEdIzm.Location = new System.Drawing.Point(13, 73);
            this.labelEdIzm.Name = "labelEdIzm";
            this.labelEdIzm.Size = new System.Drawing.Size(122, 14);
            this.labelEdIzm.TabIndex = 6;
            this.labelEdIzm.Text = "Единица измерения: шт.";
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Location = new System.Drawing.Point(13, 60);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(34, 14);
            this.labelSale.TabIndex = 5;
            this.labelSale.Text = "Цена:";
            // 
            // labelPostavshik
            // 
            this.labelPostavshik.AutoSize = true;
            this.labelPostavshik.Location = new System.Drawing.Point(13, 47);
            this.labelPostavshik.Name = "labelPostavshik";
            this.labelPostavshik.Size = new System.Drawing.Size(63, 14);
            this.labelPostavshik.TabIndex = 4;
            this.labelPostavshik.Text = "Поставщик:";
            // 
            // labelProizvoditel
            // 
            this.labelProizvoditel.AutoSize = true;
            this.labelProizvoditel.Location = new System.Drawing.Point(13, 34);
            this.labelProizvoditel.Name = "labelProizvoditel";
            this.labelProizvoditel.Size = new System.Drawing.Size(79, 14);
            this.labelProizvoditel.TabIndex = 3;
            this.labelProizvoditel.Text = "Производитель";
            // 
            // labelOpisanie
            // 
            this.labelOpisanie.AutoSize = true;
            this.labelOpisanie.Location = new System.Drawing.Point(13, 21);
            this.labelOpisanie.Name = "labelOpisanie";
            this.labelOpisanie.Size = new System.Drawing.Size(92, 14);
            this.labelOpisanie.TabIndex = 2;
            this.labelOpisanie.Text = "Описание товара:";
            // 
            // labelName_tovar
            // 
            this.labelName_tovar.AutoSize = true;
            this.labelName_tovar.Location = new System.Drawing.Point(111, 8);
            this.labelName_tovar.Name = "labelName_tovar";
            this.labelName_tovar.Size = new System.Drawing.Size(112, 14);
            this.labelName_tovar.TabIndex = 1;
            this.labelName_tovar.Text = "Наименование товара";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(13, 8);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(81, 14);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Мужская обувь";
            // 
            // labelDiscount
            // 
            this.labelDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDiscount.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscount.Location = new System.Drawing.Point(616, 3);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(108, 106);
            this.labelDiscount.TabIndex = 2;
            this.labelDiscount.Text = "Скидка";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRedact
            // 
            this.buttonRedact.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonRedact.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRedact.Location = new System.Drawing.Point(366, 55);
            this.buttonRedact.Name = "buttonRedact";
            this.buttonRedact.Size = new System.Drawing.Size(106, 22);
            this.buttonRedact.TabIndex = 41;
            this.buttonRedact.Text = "Редактировать";
            this.buttonRedact.UseVisualStyleBackColor = false;
            this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
            // 
            // TovarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TovarControl";
            this.Size = new System.Drawing.Size(732, 112);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelQuantitySclad;
        private System.Windows.Forms.Label labelEdIzm;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.Label labelPostavshik;
        private System.Windows.Forms.Label labelProizvoditel;
        private System.Windows.Forms.Label labelOpisanie;
        private System.Windows.Forms.Label labelName_tovar;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTotalSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRedact;
    }
}
