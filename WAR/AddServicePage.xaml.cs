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
    /// Логика взаимодействия для AddServicePage.xaml
    /// </summary>
    public partial class AddServicePage : Window
    {
        pro22Entities context;
        public AddServicePage(pro22Entities context, service2 CurrentService)
        {
            InitializeComponent();
            this.context = context;
            this.DataContext = CurrentService;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges(); 
           /* StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentservice.service_name))
                errors.AppendLine("укажите название услуги");
            if (_currentservice.price == null)
                errors.AppendLine("цвведите цену");

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if(_currentservice.id == 0)
                pro22Entities.GetContext().service2.Add(_currentservice);

            try
            {
                pro22Entities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!!!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }*/
        }
    }
}
