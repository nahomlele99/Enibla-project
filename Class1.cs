using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
namespace MyRND_in_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            // ensures no TextBoxes are empty
            if (lastNameTextBox.Text == "" || firstNameTextBox.Text == "" || addressTextBox.Text == "" || cityTextBox.Text == "" || stateTextBox.Text == "" || zipCodeTextBox.Text == "" ||
phoneTextBox.Text == "")
            {
                // display popup box
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                firstNameTextBox.Focus(); // set focus to lastNameTextBox
                return;
            } // end if
            // if first name format invalid show message
            if (!Regex.Match(firstNameTextBox.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid first name", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                firstNameTextBox.Focus();
                return;
            } // end if
            // if last name format invalid show message
            if (!Regex.Match(lastNameTextBox.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // last name was incorrect
                MessageBox.Show("Invalid last name", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                lastNameTextBox.Focus();
                return;
            }// end if
            // if address format invalid show message
            if (!Regex.Match(addressTextBox.Text, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                // address was incorrect
                MessageBox.Show("Invalid address", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                addressTextBox.Focus();
                return;
            } // end if
            // if Email format invalid show message
            if (!Regex.Match(EmailTextBox.Text, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                // Emailaddress was incorrect
                MessageBox.Show("Invalid Emailaddress", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                addressTextBox.Focus();
                return;
            } // end if



            // if phone number format invalid show message
            if (!Regex.Match(phoneTextBox.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$").Success)
            {
                // phone number was incorrect
                MessageBox.Show("Invalid phone number", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                phoneTextBox.Focus();
                return;
            }// end if
            // information is valid, signal user and exit application
            this.Hide(); // hide main window while MessageBox displays
            MessageBox.Show("Thank You!", "Information Correct", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
