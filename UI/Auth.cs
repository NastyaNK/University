using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Auth : Form
    {

        readonly Form main;

        public Auth(Form form)
        {
            this.main = form;
            InitializeComponent();
        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            if (auth(tb_name.Text, tb_pass.Text))
            {
                Properties.Settings.Default.login = tb_name.Text;
                Properties.Settings.Default.pass = tb_pass.Text;
                DataView view = ((Main)main).ta_manager.ПользователиTableAdapter.GetData().DefaultView;
                view.RowFilter = $"name = '{tb_name.Text}' and pass = '{tb_pass.Text}'";
                Properties.Settings.Default.type = view[0][3].ToString().Trim();
                Properties.Settings.Default.Save();
                main.Show();
                this.Hide();
            }
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Close();
        }

        public bool auth(string name, string pass)
        {
            if (name.Length > 0 && pass.Length > 0)
            {
                int result = int.Parse("" + ((Main)main).ta_manager.ПользователиTableAdapter.Exists(name, pass));
                return result > 0;
            }
            return false;
        }
    }
}
