using DocumentFormat.OpenXml.ExtendedProperties;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
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
    /// Логика взаимодействия для client.xaml
    /// </summary>
    public partial class client : Window
    {
        public client()
        {
            InitializeComponent();
            DGridClients.ItemsSource = pro22Entities.GetContext().client2.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddPage addPage = new AddPage((sender as Button).DataContext as client2);
            addPage.Show();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPage addPage = new AddPage(null);
            addPage.Show();
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var clientForRemoving = DGridClients.SelectedItems.Cast<client2>().ToList();

            if(MessageBox.Show($"Вы точно хотите удалить следующие {clientForRemoving.Count()}элементов","Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    pro22Entities.GetContext().client2.RemoveRange(clientForRemoving);
                    pro22Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridClients.ItemsSource = pro22Entities.GetContext().client2.ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
       
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                pro22Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridClients.ItemsSource = pro22Entities.GetContext().client2.ToList();
            }
        }
    }
}
