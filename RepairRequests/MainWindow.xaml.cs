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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadRequests();
        }

        // Load requests based on user role (admin or regular user)
        private void LoadRequests()
        {
            var user = UserRepository.GetCurrentUser();
            if (user == null)
            {
                MessageBox.Show("Ошибка загрузки пользователя.");
                return;
            }

            // Check if the user is an admin
            bool isAdmin = user.IsAdmin;

            // Load all requests for admin, or only the user's own requests
            var requests = RequestRepository.LoadRequests()
                            .Where(r => isAdmin || r.ClientName == user.Login) // Show all for admin, or only own for regular users
                            .ToList();

            // Bind requests to the DataGrid
            RequestsDataGrid.ItemsSource = requests;

            // If not an admin, hide the edit button
            EditRequestButton.Visibility = isAdmin ? Visibility.Visible : Visibility.Collapsed;
        }

        // Open a window for adding a new request
        private void AddRequest_Click(object sender, RoutedEventArgs e)
        {
            var createRequestWindow = new CreateRequestWindow();
            if (createRequestWindow.ShowDialog() == true)
            {
                // Reload requests after adding a new one
                LoadRequests();
            }
        }

        // Open a window for editing the selected request
        private void EditRequest_Click(object sender, RoutedEventArgs e)
        {
            // Check if a request is selected in the DataGrid
            if (RequestsDataGrid.SelectedItem != null)
            {
                var selectedRequest = RequestsDataGrid.SelectedItem as Request;

                // Check if the selected request is not null and open the editing window for the selected request
                var editRequestWindow = new EditRequestWindow(selectedRequest);
                if (editRequestWindow.ShowDialog() == true)
                {
                    // Reload requests after editing
                    LoadRequests();
                }
            }
            else
            {
                // Show a message if no request is selected for editing
                MessageBox.Show("Выберите заявку для редактирования.");
            }
        }
    }
}