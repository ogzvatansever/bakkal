namespace bakkal
{
    partial class formAnasayfa
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
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonSepet = new System.Windows.Forms.Button();
            this.buttonUrunler = new System.Windows.Forms.Button();
            this.buttonToptan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGeri
            // 
            this.buttonGeri.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGeri.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.Location = new System.Drawing.Point(133, 242);
            this.buttonGeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(150, 150);
            this.buttonGeri.TabIndex = 0;
            this.buttonGeri.Text = "Geri Git";
            this.buttonGeri.UseVisualStyleBackColor = false;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonSepet
            // 
            this.buttonSepet.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSepet.Location = new System.Drawing.Point(291, 84);
            this.buttonSepet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSepet.Name = "buttonSepet";
            this.buttonSepet.Size = new System.Drawing.Size(150, 150);
            this.buttonSepet.TabIndex = 1;
            this.buttonSepet.Text = "Sepete Git";
            this.buttonSepet.UseVisualStyleBackColor = true;
            this.buttonSepet.Click += new System.EventHandler(this.buttonSepet_Click);
            // 
            // buttonUrunler
            // 
            this.buttonUrunler.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUrunler.Location = new System.Drawing.Point(291, 242);
            this.buttonUrunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUrunler.Name = "buttonUrunler";
            this.buttonUrunler.Size = new System.Drawing.Size(150, 150);
            this.buttonUrunler.TabIndex = 2;
            this.buttonUrunler.Text = "Ürün Listesi";
            this.buttonUrunler.UseVisualStyleBackColor = true;
            this.buttonUrunler.Click += new System.EventHandler(this.buttonUrunler_Click);
            // 
            // buttonToptan
            // 
            this.buttonToptan.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonToptan.Location = new System.Drawing.Point(133, 84);
            this.buttonToptan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToptan.Name = "buttonToptan";
            this.buttonToptan.Size = new System.Drawing.Size(150, 150);
            this.buttonToptan.TabIndex = 3;
            this.buttonToptan.Text = "Toptan Giriş";
            this.buttonToptan.UseVisualStyleBackColor = true;
            this.buttonToptan.Click += new System.EventHandler(this.buttonToptan_Click);
            // 
            // formAnasayfa
            // 
            this.AcceptButton = this.buttonUrunler;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonGeri;
            this.ClientSize = new System.Drawing.Size(557, 482);
            this.Controls.Add(this.buttonToptan);
            this.Controls.Add(this.buttonUrunler);
            this.Controls.Add(this.buttonSepet);
            this.Controls.Add(this.buttonGeri);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formAnasayfa";
            this.Text = "formAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonSepet;
        private System.Windows.Forms.Button buttonUrunler;
        private System.Windows.Forms.Button buttonToptan;
    }
}