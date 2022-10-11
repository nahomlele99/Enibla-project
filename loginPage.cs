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
            MessageBox.Show("username " + Uname.Text +" "+ Pword.Text);
            string connection = @"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=Enibla;Integrated Security=True";
            string query1 = "Select Username , Password from client where Username = '"+Uname.Text+"' and Password = '"+Pword.Text+"';";
            SqlConnection con = new SqlConnection(connection);
            SqlDataAdapter sda = new SqlDataAdapter(query1, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                HomePage hotel = new HomePage();
                hotel.Show();
                this.Hide();
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
