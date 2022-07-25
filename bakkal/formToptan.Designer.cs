namespace bakkal
{
    partial class formToptan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelBarkod = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 557);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelBarkod
            // 
            this.labelBarkod.AutoSize = true;
            this.labelBarkod.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBarkod.Location = new System.Drawing.Point(16, 258);
            this.labelBarkod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBarkod.Name = "labelBarkod";
            this.labelBarkod.Size = new System.Drawing.Size(120, 17);
            this.labelBarkod.TabIndex = 1;
            this.labelBarkod.Text = "Koli Barkodu :";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.Location = new System.Drawing.Point(164, 288);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(100, 30);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "Koli Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBarkod.Location = new System.Drawing.Point(121, 254);
            this.textBoxBarkod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBarkod.MaxLength = 11;
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(192, 23);
            this.textBoxBarkod.TabIndex = 3;
            // 
            // buttonGeri
            // 
            this.buttonGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGeri.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.Location = new System.Drawing.Point(56, 288);
            this.buttonGeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(100, 30);
            this.buttonGeri.TabIndex = 4;
            this.buttonGeri.Text = "Geri Git";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bakkal.Properties.Resources.icon_2;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // formToptan
            // 
            this.AcceptButton = this.buttonEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonGeri;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.textBoxBarkod);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.labelBarkod);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formToptan";
            this.Text = "formToptan";
            this.Load += new System.EventHandler(this.formToptan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelBarkod;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}