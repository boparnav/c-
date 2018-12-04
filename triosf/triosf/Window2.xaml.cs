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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;


namespace triosf
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            string connectionString = "datasource=127.0.0.1;port=3309;username=root;password=;database=studentfile;encrypt=false;";
            //select all
            string query = "SELECT * FROM studentdata;";



            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);


            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase );
                da.Fill(dt);
            data .ItemsSource= dt.DefaultView;


             commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;



        }

        private void ebtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Hide();
        }

        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
