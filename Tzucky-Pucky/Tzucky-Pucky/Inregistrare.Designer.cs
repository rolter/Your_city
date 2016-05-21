namespace Tzucky_Pucky
{
    partial class Inregistrare
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
            this.text_nume = new System.Windows.Forms.Label();
            this.text_prenume = new System.Windows.Forms.Label();
            this.text_parola = new System.Windows.Forms.Label();
            this.text_re_parola = new System.Windows.Forms.Label();
            this.text_mail = new System.Windows.Forms.Label();
            this.textb_nume = new System.Windows.Forms.TextBox();
            this.textb_prenume = new System.Windows.Forms.TextBox();
            this.textb_parola = new System.Windows.Forms.TextBox();
            this.textb_re_parola = new System.Windows.Forms.TextBox();
            this.textb_mail = new System.Windows.Forms.TextBox();
            this.but_inregistrare = new System.Windows.Forms.Button();
            this.text_wrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_nume
            // 
            this.text_nume.BackColor = System.Drawing.Color.Transparent;
            this.text_nume.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nume.Location = new System.Drawing.Point(131, 81);
            this.text_nume.Name = "text_nume";
            this.text_nume.Size = new System.Drawing.Size(100, 32);
            this.text_nume.TabIndex = 0;
            this.text_nume.Text = "Nume";
            // 
            // text_prenume
            // 
            this.text_prenume.BackColor = System.Drawing.Color.Transparent;
            this.text_prenume.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_prenume.Location = new System.Drawing.Point(131, 134);
            this.text_prenume.Name = "text_prenume";
            this.text_prenume.Size = new System.Drawing.Size(100, 44);
            this.text_prenume.TabIndex = 1;
            this.text_prenume.Text = "Prenume";
            // 
            // text_parola
            // 
            this.text_parola.BackColor = System.Drawing.Color.Transparent;
            this.text_parola.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_parola.Location = new System.Drawing.Point(131, 185);
            this.text_parola.Name = "text_parola";
            this.text_parola.Size = new System.Drawing.Size(100, 32);
            this.text_parola.TabIndex = 2;
            this.text_parola.Text = "Parola";
            // 
            // text_re_parola
            // 
            this.text_re_parola.BackColor = System.Drawing.Color.Transparent;
            this.text_re_parola.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_re_parola.Location = new System.Drawing.Point(131, 225);
            this.text_re_parola.Name = "text_re_parola";
            this.text_re_parola.Size = new System.Drawing.Size(182, 42);
            this.text_re_parola.TabIndex = 3;
            this.text_re_parola.Text = "Reintrodu parola";
            // 
            // text_mail
            // 
            this.text_mail.BackColor = System.Drawing.Color.Transparent;
            this.text_mail.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_mail.Location = new System.Drawing.Point(131, 281);
            this.text_mail.Name = "text_mail";
            this.text_mail.Size = new System.Drawing.Size(100, 31);
            this.text_mail.TabIndex = 4;
            this.text_mail.Text = "Email";
            // 
            // textb_nume
            // 
            this.textb_nume.BackColor = System.Drawing.Color.SeaShell;
            this.textb_nume.Location = new System.Drawing.Point(368, 88);
            this.textb_nume.MaxLength = 100;
            this.textb_nume.Name = "textb_nume";
            this.textb_nume.Size = new System.Drawing.Size(173, 20);
            this.textb_nume.TabIndex = 5;
            // 
            // textb_prenume
            // 
            this.textb_prenume.BackColor = System.Drawing.Color.SeaShell;
            this.textb_prenume.Location = new System.Drawing.Point(368, 134);
            this.textb_prenume.MaxLength = 100;
            this.textb_prenume.Name = "textb_prenume";
            this.textb_prenume.Size = new System.Drawing.Size(173, 20);
            this.textb_prenume.TabIndex = 6;
            // 
            // textb_parola
            // 
            this.textb_parola.BackColor = System.Drawing.Color.SeaShell;
            this.textb_parola.Location = new System.Drawing.Point(368, 185);
            this.textb_parola.MaxLength = 100;
            this.textb_parola.Name = "textb_parola";
            this.textb_parola.PasswordChar = '*';
            this.textb_parola.Size = new System.Drawing.Size(173, 20);
            this.textb_parola.TabIndex = 7;
            // 
            // textb_re_parola
            // 
            this.textb_re_parola.BackColor = System.Drawing.Color.SeaShell;
            this.textb_re_parola.Location = new System.Drawing.Point(368, 232);
            this.textb_re_parola.MaxLength = 100;
            this.textb_re_parola.Name = "textb_re_parola";
            this.textb_re_parola.PasswordChar = '*';
            this.textb_re_parola.Size = new System.Drawing.Size(173, 20);
            this.textb_re_parola.TabIndex = 8;
            // 
            // textb_mail
            // 
            this.textb_mail.BackColor = System.Drawing.Color.SeaShell;
            this.textb_mail.Location = new System.Drawing.Point(368, 281);
            this.textb_mail.MaxLength = 100;
            this.textb_mail.Name = "textb_mail";
            this.textb_mail.Size = new System.Drawing.Size(173, 20);
            this.textb_mail.TabIndex = 9;
            // 
            // but_inregistrare
            // 
            this.but_inregistrare.Location = new System.Drawing.Point(468, 395);
            this.but_inregistrare.Name = "but_inregistrare";
            this.but_inregistrare.Size = new System.Drawing.Size(153, 37);
            this.but_inregistrare.TabIndex = 10;
            this.but_inregistrare.Text = "Inregistrare";
            this.but_inregistrare.UseVisualStyleBackColor = true;
            this.but_inregistrare.Click += new System.EventHandler(this.but_inregistrare_Click);
            // 
            // text_wrong
            // 
            this.text_wrong.BackColor = System.Drawing.Color.Transparent;
            this.text_wrong.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_wrong.Location = new System.Drawing.Point(108, 395);
            this.text_wrong.Name = "text_wrong";
            this.text_wrong.Size = new System.Drawing.Size(228, 57);
            this.text_wrong.TabIndex = 11;
            this.text_wrong.Visible = false;
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tzucky_Pucky.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 461);
            this.ControlBox = false;
            this.Controls.Add(this.text_wrong);
            this.Controls.Add(this.but_inregistrare);
            this.Controls.Add(this.textb_mail);
            this.Controls.Add(this.textb_re_parola);
            this.Controls.Add(this.textb_parola);
            this.Controls.Add(this.textb_prenume);
            this.Controls.Add(this.textb_nume);
            this.Controls.Add(this.text_mail);
            this.Controls.Add(this.text_re_parola);
            this.Controls.Add(this.text_parola);
            this.Controls.Add(this.text_prenume);
            this.Controls.Add(this.text_nume);
            this.DoubleBuffered = true;
            this.Name = "Inregistrare";
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_nume;
        private System.Windows.Forms.Label text_prenume;
        private System.Windows.Forms.Label text_parola;
        private System.Windows.Forms.Label text_re_parola;
        private System.Windows.Forms.Label text_mail;
        private System.Windows.Forms.TextBox textb_nume;
        private System.Windows.Forms.TextBox textb_prenume;
        private System.Windows.Forms.TextBox textb_parola;
        private System.Windows.Forms.TextBox textb_re_parola;
        private System.Windows.Forms.TextBox textb_mail;
        private System.Windows.Forms.Button but_inregistrare;
        private System.Windows.Forms.Label text_wrong;
    }
}