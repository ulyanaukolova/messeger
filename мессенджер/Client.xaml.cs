using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace мессенджер
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        private Socket server;

        public Client()
        {
            InitializeComponent();
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Connect("26.85.79.42", 8888);
            RecieveMessage();
        }
        private async Task RecieveMessage()
        {
            while (true)
            {
                byte[] bye = new byte[1024];
                await server.ReceiveAsync(bye, SocketFlags.None);
                string message = Encoding.UTF8.GetString(bye);
                list1.Items.Add(message);

            }
        }

        private async Task send(string msg)
        {
            byte[] bye = Encoding.UTF8.GetBytes(msg);
            await server.SendAsync(bye, SocketFlags.None);
        }

        private void btnotp_Click(object sender, RoutedEventArgs e)
        {
            string msg = "/disconnect";
            send("0");
            disconnect();
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            Close();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void disconnect()
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
