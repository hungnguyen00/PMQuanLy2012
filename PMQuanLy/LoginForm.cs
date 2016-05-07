using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PMQuanLy.Model;
using PMQuanLy.ServiceAppCust;

namespace PMQuanLy
{
    public partial class LoginForm : Form
    {
        ServiceAppCust.ServiceCustomerControllerPortTypeClient serviceAppCust = new ServiceCustomerControllerPortTypeClient();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string result = serviceAppCust.Login(txt_username.Text.ToString(), txt_password.Text.ToString());
            if (!String.IsNullOrEmpty(result))
            {
                if (File.Exists("auth.xml"))
                {
                    //Delete file
                    File.Delete(@"auth.xml");
                }
                FileStream template = File.Create("auth.xml"); //Tạo file log nếu k có
                template.Close();
                File.WriteAllText("auth.xml", result);

                //Go to Main Page
                MainForm fMain = new MainForm();
                this.Hide();
                fMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("username or Password incorrect!!!");
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
