namespace Tzucky_Pucky
{
    partial class First_Page
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
            this.but_inregistrare = new System.Windows.Forms.Button();
            this.but_logare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_inregistrare
            // 
            this.but_inregistrare.BackColor = System.Drawing.Color.SeaShell;
            this.but_inregistrare.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.but_inregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_inregistrare.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_inregistrare.ForeColor = System.Drawing.Color.Purple;
            this.but_inregistrare.Location = new System.Drawing.Point(45, 358);
            this.but_inregistrare.Name = "but_inregistrare";
            this.but_inregistrare.Size = new System.Drawing.Size(177, 42);
            this.but_inregistrare.TabIndex = 0;
            this.but_inregistrare.Text = "Inregistreaza-te";
            this.but_inregistrare.UseVisualStyleBackColor = false;
            this.but_inregistrare.Click += new System.EventHandler(this.but_inregistrare_Click);
            // 
            // but_logare
            // 
            this.but_logare.BackColor = System.Drawing.Color.SeaShell;
            this.but_logare.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.but_logare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_logare.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_logare.ForeColor = System.Drawing.Color.Purple;
            this.but_logare.Location = new System.Drawing.Point(535, 358);
            this.but_logare.Name = "but_logare";
            this.but_logare.Size = new System.Drawing.Size(177, 42);
            this.but_logare.TabIndex = 1;
            this.but_logare.Text = "Logare";
            this.but_logare.UseVisualStyleBackColor = false;
            this.but_logare.Click += new System.EventHandler(this.but_logare_Click);
            // 
            // First_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tzucky_Pucky.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 432);
            this.ControlBox = false;
            this.Controls.Add(this.but_logare);
            this.Controls.Add(this.but_inregistrare);
            this.DoubleBuffered = true;
            this.Name = "First_Page";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_inregistrare;
        private System.Windows.Forms.Button but_logare;
    }
}

