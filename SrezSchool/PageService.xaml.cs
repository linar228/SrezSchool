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
using SrezSchool.BD;
using System.Collections.ObjectModel;

namespace SrezSchool
{
    /// <summary>
    /// Логика взаимодействия для PageService.xaml
    /// </summary>
    public partial class PageService : Page
    {
        private static ObservableCollection<Service> services = new ObservableCollection<Service>(Connection.connection.Service);
        public PageService()
        {
            InitializeComponent();
            if (AuthPage.role == "Admin")
            {
                BtnAdd.IsEnabled = true;
            }
            else
                BtnAdd.IsEnabled = false;
            LVServices.ItemsSource = services.ToList();
            DataContext = this;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
