using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSDemoTRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LMSAPPEntities content = new LMSAPPEntities();
            if(usernametxt.Text != string.Empty && pwdtxt.Text != string.Empty)
            {
                var user = content.LMSAdmins.Where(x => x.UserName.Equals(usernametxt.Text)).FirstOrDefault();
                if(user != null) 
                {
                    if (user.Password.Equals(pwdtxt.Text))
                    {
                        MessageBox.Show("Login");
                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Username Incorrect");
                }
            }

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
