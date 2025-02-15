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

namespace RepairRequests
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверка совпадения паролей
            if (PasswordBox.Password != ConfirmPasswordBox.Password)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            // Проверка, что логин не пустой
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                MessageBox.Show("Логин не может быть пустым.");
                return;
            }

            // Проверка, что пароль не пустой
            if (string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                MessageBox.Show("Пароль не может быть пустым.");
                return;
            }

            // Проверка, что пользователь с таким логином уже не существует
            var users = UserRepository.LoadUsers();
            if (users.Any(u => u.Login == LoginTextBox.Text))
            {
                MessageBox.Show("Пользователь с таким логином уже существует.");
                return;
            }

            // Создание нового пользователя
            var newUser = new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordBox.Password,
                IsAdmin = false // По умолчанию пользователь не является администратором
            };

            // Добавление пользователя и сохранение в JSON
            UserRepository.AddUser(newUser);
            MessageBox.Show("Регистрация прошла успешно.");
            Close();
        }
    }
}
