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

namespace RepairRequests
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordBox.Password;

            var user = UserRepository.FindUser(login, password);

            if (user != null)
            {
                // После успешного входа сохраняем текущего пользователя
                UserRepository.SetCurrentUser(user);

                MessageBox.Show($"Добро пожаловать, {user.Login}!");

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }


        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var registerWindow = new RegisterWindow();
            registerWindow.ShowDialog();
        }
    }
}