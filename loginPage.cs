using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Enibla_project
{
    public partial class loginPage : Form
    {
        public static loginPage instance;
        public loginPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            joinAsPage joinAs = new joinAsPage();
            joinAs.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "User" && Uname.Texts == "Admin" && Pword.Texts == "admin") {
                HomePage home = new HomePage();
                home.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Service Provider" && Uname.Texts == "SAdmin" && Pword.Texts == "Sadmin")
            {
                AdminPage SP = new AdminPage();
                SP.Show();
                this.Hide();
            }
            else if(comboBox1.SelectedItem.ToString() == "Service Provider")
            {
                MessageBox.Show("Not Currently Working");
            }
            else
            {
                MessageBox.Show("please check your username or passsword");
            }

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font("Microsoft Sans Serif", 14);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
