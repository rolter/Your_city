using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tzucky_Pucky
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }
        bool Check()
        {
            if (textb_parola.Text == textb_re_parola.Text && !(string.IsNullOrWhiteSpace(textb_parola.Text)) && !(string.IsNullOrWhiteSpace(textb_re_parola.Text)))
                return true;
            else
            {
                text_wrong.Text += "Parolele nu corespund!";
                text_wrong.Visible = true;
            }
            return false;
        }

        private void but_inregistrare_Click(object sender, EventArgs e)
        {
            text_wrong.Text = "";
            if (Check())
            {
                this.Close();
                FormCheck.page.Show();
            }
        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {

        }
    }
}
