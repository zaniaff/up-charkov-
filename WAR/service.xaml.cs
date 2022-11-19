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
    /// Логика взаимодействия для service.xaml
    /// </summary>
    public partial class service : Window
    {
        pro22Entities context;
        public service()
        {
            InitializeComponent();
            context = new pro22Entities();
            DGridService.ItemsSource = context.service2.ToList();
        }
        private void BtnEdit_service_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var CurrentService = button.DataContext as service2;
            AddServicePage addServicePage = new AddServicePage(context, CurrentService);
            addServicePage.Show();
        }

        private void BtnAddSevice_Click(object sender, RoutedEventArgs e)
        {
            service2 NewService = new service2();
            context.service2.Add(NewService);
            AddServicePage addServicePage = new AddServicePage(context, NewService);
            addServicePage.Show();
        }
      
        private void BtnDeleteService_Click(object sender, RoutedEventArgs e)
        {
            var row = DGridService.SelectedItem as service2;
            if (row == null)
            {
                MessageBox.Show("");
                return;
            }

            MessageBoxResult result = MessageBox.Show("", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                context.service2.Remove(row);
                context.SaveChanges();
                DGridService.ItemsSource = context.service2.ToList();
            }
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            /*if(Visibility == Visibility.Visible)
            {
                //pro22Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridService.ItemsSource = pro22Entities.GetContext().service2.ToList();
            }*/
        }
    }
}
