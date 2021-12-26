
namespace OrderAutomation
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.tbxEposta = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblKullaniciSifre = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.btnKaydol);
            this.panel1.Controls.Add(this.tbxEposta);
            this.panel1.Controls.Add(this.tbxPassword);
            this.panel1.Controls.Add(this.lblKullaniciSifre);
            this.panel1.Controls.Add(this.lblEposta);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(66, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 618);
            this.panel1.TabIndex = 4;
            // 
            // btnKaydol
            // 
            this.btnKaydol.Location = new System.Drawing.Point(93, 469);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(130, 40);
            this.btnKaydol.TabIndex = 4;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // tbxEposta
            // 
            this.tbxEposta.Location = new System.Drawing.Point(163, 319);
            this.tbxEposta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEposta.Name = "tbxEposta";
            this.tbxEposta.Size = new System.Drawing.Size(202, 26);
            this.tbxEposta.TabIndex = 1;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(163, 382);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(202, 26);
            this.tbxPassword.TabIndex = 2;
            // 
            // lblKullaniciSifre
            // 
            this.lblKullaniciSifre.AutoSize = true;
            this.lblKullaniciSifre.Location = new System.Drawing.Point(89, 386);
            this.lblKullaniciSifre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKullaniciSifre.Name = "lblKullaniciSifre";
            this.lblKullaniciSifre.Size = new System.Drawing.Size(50, 20);
            this.lblKullaniciSifre.TabIndex = 3;
            this.lblKullaniciSifre.Text = "Şifre :";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(61, 319);
            this.lblEposta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(74, 20);
            this.lblEposta.TabIndex = 2;
            this.lblEposta.Text = "E-Posta :";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(234, 469);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(131, 40);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrderAutomation.Properties.Resources.Ay_Fotoğrafı_Nasıl_Daha_Net_Çekilir;
            this.ClientSize = new System.Drawing.Size(556, 691);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxEposta;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblKullaniciSifre;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnKaydol;
    }
}

