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
using System.Data.Entity;
namespace ZORTRANS
{
    /// <summary>
    /// Interaction logic for Cars.xaml
    /// </summary>
    public partial class Cars : Window
    {
        ZorTranSEntities ztsContext = new ZorTranSEntities();
        CollectionViewSource carsViewSource;
        public Cars()
        {
            InitializeComponent();
            carsViewSource = ((CollectionViewSource)(FindResource("masiniViewSource")));
            DataContext = this;
        }
        private void Transports_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Drivers_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Drivers driversMenu = new Drivers();
            driversMenu.Show();
            this.Close();
        }

        private void Cars_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Cars carsMenu = new Cars();
            carsMenu.Show();
            this.Close();
        }

        private void Parteners_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Parteners partenersMenu = new Parteners();
            partenersMenu.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource carsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("masiniViewSource")));
            //// Load data by setting the CollectionViewSource.Source property:
            //// transporturiViewSource.Source = [generic data source]
            ztsContext.Masinis.Load();
            carsViewSource.Source = ztsContext.Masinis.Local;
            //System.Windows.Data.CollectionViewSource soferiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("soferiViewSource")));
            //// Load data by setting the CollectionViewSource.Source property:
            //// soferiViewSource.Source = [generic data source]
          //  System.Windows.Data.CollectionViewSource masiniViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("masiniViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // masiniViewSource.Source = [generic data source]
        }

        private void B_addCar_Click(object sender, RoutedEventArgs e)
        {
            adaugamasina masina = new adaugamasina();
            masina.Show();
        }
    }
}
