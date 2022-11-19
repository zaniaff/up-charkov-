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
    /// Логика взаимодействия для servicePrice.xaml
    /// </summary>
    public partial class servicePrice : Window
    {
        public servicePrice()
        {
            InitializeComponent();
            //DGridClientService.ItemsSource = pro22Entities.GetContext().ClientService.ToList();
        }

        private void BtnEdit_serviceClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddPrice_Click(object sender, RoutedEventArgs e)
        {
            AddPricePage addPricePage = new AddPricePage();
            addPricePage.Show();
        }

        private void BtnDeletePrice_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
