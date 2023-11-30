using GPhone.Controller;
using GPhone.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPhone.Model
{
    public partial class FormLoginAdmin : Form
    {
        DataGPhone dtg;
        public FormLoginAdmin()
        {
            dtg = new DataGPhone();
            InitializeComponent();
        }

        private void FormLoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if((txtAdmin.Text == " ") || (txtPassword.Text == " "))
            {
                MessageBox.Show("verified need","wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtAdmin.Text;
                string pass = txtPassword.Text;
                DataTable dt = dtg.getlist(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM admin WHERE username = '" + name + "'AND pass = '" + pass + "'"));
                if(dt.Rows.Count > 0)
                {
                   FormMenuAdmin fma = new FormMenuAdmin();
                    this.Hide();
                    fma.Show();
                }
                else
                {
                    MessageBox.Show("nothing", "wrong", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

           
        }
    }
}
