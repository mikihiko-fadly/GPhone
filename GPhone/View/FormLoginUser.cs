using GPhone.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPhone.View
{
    public partial class FormLoginUser : Form
    {
        DataGPhone dtg;
        public FormLoginUser()
        {
            dtg = new DataGPhone();
            InitializeComponent();
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == " ") || (txtEmail.Text == " ") || (txtPass.Text == " "))
            {
                MessageBox.Show("verified need", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtUsername.Text;
                string email = txtEmail.Text;
                string pass = txtPass.Text;
                DataTable dt = dtg.getlist(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM person WHERE username = '" + name + "'AND email = '" + email + "' AND pass = '" + pass + "'"));
                if (dt.Rows.Count > 0)
                {
                    FormMenuUser fmus = new FormMenuUser();
                    this.Hide();
                    fmus.Show();
                }
                else
                {
                    MessageBox.Show("nothing", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
