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

namespace мессенджер
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

     

        private void podcl_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show("Не заполнили");
            }
            else
            {
                Client client = new Client();
                client.Show();
                Close();
            }


        }

        private void newChat_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (textbox.Text == "")
            {
                MessageBox.Show("Не заполнили");
            }
            else
            {
                ServerOkno server = new ServerOkno();
                server.Show();
                Close();
            }
          
        }
    }
}
