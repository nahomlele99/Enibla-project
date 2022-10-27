﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

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
            if (Roles.SelectedItem.ToString() == "User")
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "select * from Users where Username = @Username And Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Username", Uname.Texts);
                        cmd.Parameters.AddWithValue("@Password", Pword.Texts);
                        Console.WriteLine(query);
                        if (cmd.ExecuteReader().Read())
                        {
                            HomePage home = new HomePage();
                            home.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else if (Roles.SelectedItem.ToString() == "Service Provider" )
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "select * from ServiceProvider where AgentUsername = @Username And AgentPassword = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Username", Uname.Texts);
                        cmd.Parameters.AddWithValue("@Password", Pword.Texts);
                        Console.WriteLine(query);
                        if (cmd.ExecuteReader().Read())
                        {
                            ServiceProviderPage SP = new ServiceProviderPage();
                            SP.Show();
                            this.Hide();
                        }
                    }
                }

            }
            else if (Roles.SelectedItem.ToString() == "Delivery Man")
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "select * from Delivery where Username = @Username And Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Username", Uname.Texts);
                        cmd.Parameters.AddWithValue("@Password", Pword.Texts);
                        Console.WriteLine(query);
                        if (cmd.ExecuteReader().Read())
                        {
                            HomeDelievry DP = new HomeDelievry(Uname.Texts);
                            DP.Show();
                            this.Hide();
                        }
                    }
                }

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
