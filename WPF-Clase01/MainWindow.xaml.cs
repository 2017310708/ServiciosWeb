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

namespace WPF_Clase01
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            if(username == "admin" && password == "123")
            {
                MessageBox.Show($"Login Success con el usuario: {username}");
                // Console.WriteLine($"Login Success con el usuario: {username}");
            }
            else
            {
                MessageBox.Show("Login Fallido");
                // Console.WriteLine("Login Fallido");
            }
        }
    }
}