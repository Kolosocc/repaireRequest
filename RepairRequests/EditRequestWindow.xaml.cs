using System;
using System.Windows;

namespace RepairRequests
{
    public partial class EditRequestWindow : Window
    {
        private Request _request;

        public EditRequestWindow(Request request)
        {
            InitializeComponent();
            _request = request;

            // Set ComboBox ItemsSource for Enums
            EquipmentTypeComboBox.ItemsSource = Enum.GetValues(typeof(EquipmentType));
            StatusComboBox.ItemsSource = Enum.GetValues(typeof(RequestStatus));

            // Load the data after setting the ItemsSource
            LoadRequestData();
        }

        private void LoadRequestData()
        {
            // Populate the fields with the current request data
            RequestIdTextBox.Text = _request.RequestId.ToString();
            DateAddedPicker.SelectedDate = _request.DateAdded;

            // Set the SelectedItem after loading the ItemsSource
            EquipmentTypeComboBox.SelectedItem = _request.EquipmentType;
            StatusComboBox.SelectedItem = _request.Status;

            ModelTextBox.Text = _request.Model;
            ProblemDescriptionTextBox.Text = _request.ProblemDescription;
            ClientNameTextBox.Text = _request.ClientName;
            PhoneNumberTextBox.Text = _request.PhoneNumber;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Ensure the combo boxes have a selected item before accessing it
            if (EquipmentTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип техники.");
                return;
            }

            if (StatusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите статус заявки.");
                return;
            }

            // Update the request data with the current values from the UI
            _request.DateAdded = DateAddedPicker.SelectedDate ?? DateTime.Now;

            // Save the equipment type and status
            _request.EquipmentType = (EquipmentType)EquipmentTypeComboBox.SelectedItem;
            _request.Model = ModelTextBox.Text;
            _request.ProblemDescription = ProblemDescriptionTextBox.Text;
            _request.PhoneNumber = PhoneNumberTextBox.Text;
            _request.Status = (RequestStatus)StatusComboBox.SelectedItem;

            // Update the request in the repository (assuming UpdateRequest method handles it)
            RequestRepository.UpdateRequest(_request);
            DialogResult = true;
            Close();
        }
    }
}
