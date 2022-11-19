using DocumentFormat.OpenXml.ExtendedProperties;
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

namespace WAR
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Window
    {
        private client2 _currentclient = new client2();

        public AddPage(client2 selectedClient)
        {
            InitializeComponent();

            if(selectedClient != null)
                _currentclient = selectedClient;

            DataContext = _currentclient;
            ComboGender.ItemsSource = pro22Entities.GetContext().Gender.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
           StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentclient.middleName))
                errors.AppendLine("error");
            if (_currentclient.Gender == null)
                errors.AppendLine("error");

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentclient.id == 0)
                pro22Entities.GetContext().client2.Add(_currentclient);

            try
            {
                pro22Entities.GetContext().SaveChanges();
                MessageBox.Show("информация сохранена");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
