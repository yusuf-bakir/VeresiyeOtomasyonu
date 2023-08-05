namespace Veresiye
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Adsoyad = new System.Windows.Forms.TextBox();
            this.Telefonno = new System.Windows.Forms.TextBox();
            this.Addres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adsoyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon no :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adress :";
            // 
            // Adsoyad
            // 
            this.Adsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Adsoyad.Location = new System.Drawing.Point(187, 74);
            this.Adsoyad.Name = "Adsoyad";
            this.Adsoyad.Size = new System.Drawing.Size(209, 22);
            this.Adsoyad.TabIndex = 3;
            this.Adsoyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Telefonno
            // 
            this.Telefonno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Telefonno.Location = new System.Drawing.Point(187, 144);
            this.Telefonno.Name = "Telefonno";
            this.Telefonno.Size = new System.Drawing.Size(209, 22);
            this.Telefonno.TabIndex = 4;
            this.Telefonno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Telefonno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefonno_KeyPress);
            // 
            // Addres
            // 
            this.Addres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Addres.Location = new System.Drawing.Point(187, 214);
            this.Addres.Name = "Addres";
            this.Addres.Size = new System.Drawing.Size(209, 22);
            this.Addres.TabIndex = 5;
            this.Addres.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(131, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Müşteri Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Addres);
            this.Controls.Add(this.Telefonno);
            this.Controls.Add(this.Adsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form6";
            this.Text = "Müşteri Ekleme";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adsoyad;
        private System.Windows.Forms.TextBox Telefonno;
        private System.Windows.Forms.TextBox Addres;
        private System.Windows.Forms.Button button1;
    }
}