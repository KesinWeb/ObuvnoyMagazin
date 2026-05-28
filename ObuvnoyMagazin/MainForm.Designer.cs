namespace ObuvnoyMagazin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAdm = new System.Windows.Forms.Label();
            this.labelFio = new System.Windows.Forms.Label();
            this.buttonTovar = new System.Windows.Forms.Button();
            this.buttonTovarAdd = new System.Windows.Forms.Button();
            this.buttonZakaz = new System.Windows.Forms.Button();
            this.buttonZakazAdd = new System.Windows.Forms.Button();
            this.textBoxPoisc = new System.Windows.Forms.TextBox();
            this.labelPoisc = new System.Windows.Forms.Label();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.radioButtonUbv = new System.Windows.Forms.RadioButton();
            this.radioButtonVzr = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Chartreuse;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 390);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(778, 428);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(132, 29);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelAdm
            // 
            this.labelAdm.AutoSize = true;
            this.labelAdm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdm.Location = new System.Drawing.Point(77, 38);
            this.labelAdm.Name = "labelAdm";
            this.labelAdm.Size = new System.Drawing.Size(157, 24);
            this.labelAdm.TabIndex = 5;
            this.labelAdm.Text = "Администратор";
            // 
            // labelFio
            // 
            this.labelFio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFio.Location = new System.Drawing.Point(424, 38);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(240, 24);
            this.labelFio.TabIndex = 6;
            this.labelFio.Text = "Фамилия Имя Отчество";
            // 
            // buttonTovar
            // 
            this.buttonTovar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonTovar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTovar.Location = new System.Drawing.Point(778, 192);
            this.buttonTovar.Name = "buttonTovar";
            this.buttonTovar.Size = new System.Drawing.Size(132, 29);
            this.buttonTovar.TabIndex = 7;
            this.buttonTovar.Text = "Товар";
            this.buttonTovar.UseVisualStyleBackColor = false;
            this.buttonTovar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTovarAdd
            // 
            this.buttonTovarAdd.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonTovarAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTovarAdd.Location = new System.Drawing.Point(778, 227);
            this.buttonTovarAdd.Name = "buttonTovarAdd";
            this.buttonTovarAdd.Size = new System.Drawing.Size(132, 30);
            this.buttonTovarAdd.TabIndex = 8;
            this.buttonTovarAdd.Text = "Добавление Товара";
            this.buttonTovarAdd.UseVisualStyleBackColor = false;
            this.buttonTovarAdd.Click += new System.EventHandler(this.buttonTovarAdd_Click);
            // 
            // buttonZakaz
            // 
            this.buttonZakaz.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonZakaz.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZakaz.Location = new System.Drawing.Point(778, 362);
            this.buttonZakaz.Name = "buttonZakaz";
            this.buttonZakaz.Size = new System.Drawing.Size(132, 29);
            this.buttonZakaz.TabIndex = 9;
            this.buttonZakaz.Text = "Заказ";
            this.buttonZakaz.UseVisualStyleBackColor = false;
            this.buttonZakaz.Click += new System.EventHandler(this.buttonZakaz_Click);
            // 
            // buttonZakazAdd
            // 
            this.buttonZakazAdd.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonZakazAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZakazAdd.Location = new System.Drawing.Point(778, 397);
            this.buttonZakazAdd.Name = "buttonZakazAdd";
            this.buttonZakazAdd.Size = new System.Drawing.Size(132, 29);
            this.buttonZakazAdd.TabIndex = 10;
            this.buttonZakazAdd.Text = "Добавление Заказа";
            this.buttonZakazAdd.UseVisualStyleBackColor = false;
            this.buttonZakazAdd.Click += new System.EventHandler(this.buttonZakazAdd_Click);
            // 
            // textBoxPoisc
            // 
            this.textBoxPoisc.Location = new System.Drawing.Point(778, 71);
            this.textBoxPoisc.Name = "textBoxPoisc";
            this.textBoxPoisc.Size = new System.Drawing.Size(131, 20);
            this.textBoxPoisc.TabIndex = 11;
            // 
            // labelPoisc
            // 
            this.labelPoisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPoisc.AutoSize = true;
            this.labelPoisc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoisc.Location = new System.Drawing.Point(779, 47);
            this.labelPoisc.Name = "labelPoisc";
            this.labelPoisc.Size = new System.Drawing.Size(42, 15);
            this.labelPoisc.TabIndex = 12;
            this.labelPoisc.Text = "Поиск";
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Items.AddRange(new object[] {
            "Все поставщики",
            "Kari",
            "Обувь для вас"});
            this.comboBoxPost.Location = new System.Drawing.Point(778, 116);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(131, 22);
            this.comboBoxPost.TabIndex = 13;
            this.comboBoxPost.TextChanged += new System.EventHandler(this.comboBoxPost_TextChanged);
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPost.Location = new System.Drawing.Point(778, 94);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(69, 15);
            this.labelPost.TabIndex = 14;
            this.labelPost.Text = "Поставщик";
            // 
            // radioButtonUbv
            // 
            this.radioButtonUbv.AutoSize = true;
            this.radioButtonUbv.Location = new System.Drawing.Point(782, 144);
            this.radioButtonUbv.Name = "radioButtonUbv";
            this.radioButtonUbv.Size = new System.Drawing.Size(91, 18);
            this.radioButtonUbv.TabIndex = 15;
            this.radioButtonUbv.TabStop = true;
            this.radioButtonUbv.Text = "По убыванию";
            this.radioButtonUbv.UseVisualStyleBackColor = true;
            this.radioButtonUbv.CheckedChanged += new System.EventHandler(this.radioButtonUbv_CheckedChanged);
            // 
            // radioButtonVzr
            // 
            this.radioButtonVzr.AutoSize = true;
            this.radioButtonVzr.Location = new System.Drawing.Point(782, 168);
            this.radioButtonVzr.Name = "radioButtonVzr";
            this.radioButtonVzr.Size = new System.Drawing.Size(103, 18);
            this.radioButtonVzr.TabIndex = 16;
            this.radioButtonVzr.TabStop = true;
            this.radioButtonVzr.Text = "По возрастанию";
            this.radioButtonVzr.UseVisualStyleBackColor = true;
            this.radioButtonVzr.CheckedChanged += new System.EventHandler(this.radioButtonVzr_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 480);
            this.Controls.Add(this.radioButtonVzr);
            this.Controls.Add(this.radioButtonUbv);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.labelPoisc);
            this.Controls.Add(this.textBoxPoisc);
            this.Controls.Add(this.buttonZakazAdd);
            this.Controls.Add(this.buttonZakaz);
            this.Controls.Add(this.buttonTovarAdd);
            this.Controls.Add(this.buttonTovar);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.labelAdm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Обувь\"";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAdm;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTovar;
        private System.Windows.Forms.Button buttonTovarAdd;
        private System.Windows.Forms.Button buttonZakaz;
        private System.Windows.Forms.Button buttonZakazAdd;
        private System.Windows.Forms.TextBox textBoxPoisc;
        private System.Windows.Forms.Label labelPoisc;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.RadioButton radioButtonUbv;
        private System.Windows.Forms.RadioButton radioButtonVzr;
    }
}