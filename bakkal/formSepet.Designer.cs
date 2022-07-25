namespace bakkal
{
    partial class formSepet
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonOdeme = new System.Windows.Forms.Button();
            this.labelSepet = new System.Windows.Forms.Label();
            this.labelSepetUst = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(271, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 557);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(16, 115);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 361);
            this.listBox1.TabIndex = 1;
            // 
            // buttonGeri
            // 
            this.buttonGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGeri.Location = new System.Drawing.Point(28, 547);
            this.buttonGeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(100, 30);
            this.buttonGeri.TabIndex = 2;
            this.buttonGeri.Text = "Geri Git";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonOdeme
            // 
            this.buttonOdeme.Location = new System.Drawing.Point(136, 547);
            this.buttonOdeme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOdeme.Name = "buttonOdeme";
            this.buttonOdeme.Size = new System.Drawing.Size(100, 30);
            this.buttonOdeme.TabIndex = 5;
            this.buttonOdeme.Text = "Ödeme Yap";
            this.buttonOdeme.UseVisualStyleBackColor = true;
            this.buttonOdeme.Click += new System.EventHandler(this.buttonOdeme_Click);
            // 
            // labelSepet
            // 
            this.labelSepet.AutoSize = true;
            this.labelSepet.Location = new System.Drawing.Point(39, 481);
            this.labelSepet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSepet.Name = "labelSepet";
            this.labelSepet.Size = new System.Drawing.Size(88, 17);
            this.labelSepet.TabIndex = 6;
            this.labelSepet.Text = "labelSepet";
            this.labelSepet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSepetUst
            // 
            this.labelSepetUst.AutoSize = true;
            this.labelSepetUst.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSepetUst.Location = new System.Drawing.Point(16, 71);
            this.labelSepetUst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSepetUst.Name = "labelSepetUst";
            this.labelSepetUst.Size = new System.Drawing.Size(127, 35);
            this.labelSepetUst.TabIndex = 7;
            this.labelSepetUst.Text = "Sepet :";
            this.labelSepetUst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bakkal.Properties.Resources.png_transparent_shopping_cart_computer_icons_service_cart_angle_service_grocery_store;
            this.pictureBox1.Location = new System.Drawing.Point(161, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // formSepet
            // 
            this.AcceptButton = this.buttonOdeme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonGeri;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSepetUst);
            this.Controls.Add(this.labelSepet);
            this.Controls.Add(this.buttonOdeme);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formSepet";
            this.Text = "formSepet";
            this.Load += new System.EventHandler(this.formSepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonOdeme;
        private System.Windows.Forms.Label labelSepet;
        private System.Windows.Forms.Label labelSepetUst;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}