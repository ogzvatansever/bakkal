namespace bakkal
{
    partial class formGiris
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
            this.buttonGiris = new System.Windows.Forms.Button();
            this.labelKAdi = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.labelHata = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonGiris
            // 
            this.buttonGiris.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonGiris.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.Location = new System.Drawing.Point(308, 230);
            this.buttonGiris.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(100, 30);
            this.buttonGiris.TabIndex = 0;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = false;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // labelKAdi
            // 
            this.labelKAdi.AutoSize = true;
            this.labelKAdi.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKAdi.Location = new System.Drawing.Point(155, 166);
            this.labelKAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKAdi.Name = "labelKAdi";
            this.labelKAdi.Size = new System.Drawing.Size(128, 17);
            this.labelKAdi.TabIndex = 1;
            this.labelKAdi.Text = "Kullanıcı Adı :";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.Location = new System.Drawing.Point(158, 200);
            this.labelSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(64, 17);
            this.labelSifre.TabIndex = 2;
            this.labelSifre.Text = "Şifre :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(256, 162);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "admin";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(256, 196);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "123";
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCikis.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.Location = new System.Drawing.Point(200, 230);
            this.buttonCikis.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(100, 30);
            this.buttonCikis.TabIndex = 5;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // labelHata
            // 
            this.labelHata.AutoSize = true;
            this.labelHata.Location = new System.Drawing.Point(13, 120);
            this.labelHata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHata.Name = "labelHata";
            this.labelHata.Size = new System.Drawing.Size(0, 17);
            this.labelHata.TabIndex = 6;
            this.labelHata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(399, 200);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // formGiris
            // 
            this.AcceptButton = this.buttonGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonCikis;
            this.ClientSize = new System.Drawing.Size(619, 367);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelHata);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKAdi);
            this.Controls.Add(this.buttonGiris);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formGiris";
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Label labelKAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Label labelHata;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}