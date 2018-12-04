using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace triosf
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

      

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            var Firstname= Fname.Text;
            var lastName = lname.Text;

            var Phone = phone.Text;

            var address = add.Text;


            //radio button gender
            var gender = "";



            if (gmale.IsChecked == true)
            {

                gender = "male";

            }



            if (Gm.IsChecked == true)
            {

                gender = "female";

            }

            //radio btn prefference
            var pref = "";



            if (pt1.IsChecked == true)
            {

                pref = "PT";

            }



            if (ft1.IsChecked == true)
            {

                pref = "FT";

            }







            if (Firstname == "" || lastName == "" || Phone == "" || address == "")

                MessageBox.Show("Please enter all data " + gender);

            else

                MessageBox.Show("Thank you for submitting the data");

            //connection
            string connectionString = "datasource=127.0.0.1;port=3309;username=root;password=;database=studentfile;SslMode=none;";

            string query = "INSERT INTO studentData(`id`, `Firstname`, `Lastname`, `Address`,`Phone`,`Gender`,`Prefference`) VALUES (NULL, '" + Fname.Text + "', '" + lname.Text + "', '" + add.Text + "','" + phone.Text + "','" + gender+"','"+ pref +"')";

            // Which could be translated manually to :

            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'John', 'Doe', 'John Doe Villa')



            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;



            try

            {

                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();



                MessageBox.Show("User succesfully registered");



                databaseConnection.Close();

            }

            catch (Exception ex)

            {

                // Show any error message.

                MessageBox.Show(ex.Message);

            }




        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Fname.Text = "";

            lname.Text = "";

            phone.Text = "";

            add.Text = "";

            gmale.IsChecked = false;

            Gm.IsChecked = false;

            pt1.IsChecked = false;
            ft1.IsChecked = false;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void Lisbtn_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
            this.Hide();
        }
    }
    }

