namespace ObuvnoyMagazin
{
    partial class ZakazControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDataZakaza = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelStatusZak = new System.Windows.Forms.Label();
            this.labelNomerZak = new System.Windows.Forms.Label();
            this.labelDataDost = new System.Windows.Forms.Label();
            this.buttonRedact = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonRedact);
            this.panel1.Controls.Add(this.labelDataZakaza);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labelAdress);
            this.panel1.Controls.Add(this.labelStatusZak);
            this.panel1.Controls.Add(this.labelNomerZak);
            this.panel1.Location = new System.Drawing.Point(15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 113);
            this.panel1.TabIndex = 0;
            // 
            // labelDataZakaza
            // 
            this.labelDataZakaza.AutoSize = true;
            this.labelDataZakaza.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataZakaza.Location = new System.Drawing.Point(24, 82);
            this.labelDataZakaza.Name = "labelDataZakaza";
            this.labelDataZakaza.Size = new System.Drawing.Size(45, 19);
            this.labelDataZakaza.TabIndex = 4;
            this.labelDataZakaza.Text = "label5";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdress.Location = new System.Drawing.Point(24, 60);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(45, 19);
            this.labelAdress.TabIndex = 3;
            this.labelAdress.Text = "label4";
            // 
            // labelStatusZak
            // 
            this.labelStatusZak.AutoSize = true;
            this.labelStatusZak.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusZak.Location = new System.Drawing.Point(24, 38);
            this.labelStatusZak.Name = "labelStatusZak";
            this.labelStatusZak.Size = new System.Drawing.Size(45, 19);
            this.labelStatusZak.TabIndex = 2;
            this.labelStatusZak.Text = "label3";
            // 
            // labelNomerZak
            // 
            this.labelNomerZak.AutoSize = true;
            this.labelNomerZak.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNomerZak.Location = new System.Drawing.Point(24, 15);
            this.labelNomerZak.Name = "labelNomerZak";
            this.labelNomerZak.Size = new System.Drawing.Size(49, 19);
            this.labelNomerZak.TabIndex = 1;
            this.labelNomerZak.Text = "label2";
            // 
            // labelDataDost
            // 
            this.labelDataDost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDataDost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataDost.Location = new System.Drawing.Point(597, 3);
            this.labelDataDost.Name = "labelDataDost";
            this.labelDataDost.Size = new System.Drawing.Size(132, 113);
            this.labelDataDost.TabIndex = 0;
            this.labelDataDost.Text = "label1";
            this.labelDataDost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRedact
            // 
            this.buttonRedact.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonRedact.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRedact.Location = new System.Drawing.Point(465, 58);
            this.buttonRedact.Name = "buttonRedact";
            this.buttonRedact.Size = new System.Drawing.Size(106, 22);
            this.buttonRedact.TabIndex = 43;
            this.buttonRedact.Text = "Редактировать";
            this.buttonRedact.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(465, 81);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 22);
            this.buttonDelete.TabIndex = 42;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ZakazControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDataDost);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ZakazControl";
            this.Size = new System.Drawing.Size(732, 121);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDataZakaza;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelStatusZak;
        private System.Windows.Forms.Label labelNomerZak;
        private System.Windows.Forms.Label labelDataDost;
        private System.Windows.Forms.Button buttonRedact;
        private System.Windows.Forms.Button buttonDelete;
    }
}
