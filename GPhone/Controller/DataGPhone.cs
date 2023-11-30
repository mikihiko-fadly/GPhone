using GPhone.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPhone.Controller
{
    internal class DataGPhone
    {
        Connection conn = new Connection();
        public DataTable getlist(MySqlCommand cmd)
        {
            cmd.Connection = conn.GetConn();
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
