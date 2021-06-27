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
using System.Data;

namespace ZORTRANS
{
    /// <summary>
    /// Interaction logic for Drivers.xaml
    /// </summary>
    public partial class Drivers : Window
    {
        ZorTranSEntities ztsContext = new ZorTranSEntities();
        CollectionViewSource driversViewSource;
        public Drivers()
        {
            InitializeComponent();
            driversViewSource = ((CollectionViewSource)(FindResource("soferiViewSource")));
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

        private void SoferiDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource driversViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("soferiViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // transporturiViewSource.Source = [generic data source]
            ztsContext.Soferis.Load();
            driversViewSource.Source = ztsContext.Soferis.Local;
            System.Windows.Data.CollectionViewSource soferiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("soferiViewSource")));
            //  System.Windows.Data.CollectionViewSource masiniViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("masiniViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // soferiViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource angajatiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("angajatiViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // angajatiViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource masiniViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("masiniViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // masiniViewSource.Source = [generic data source]
        }

        private void SoferiDataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var objEmpToEdit = soferiDataGrid.SelectedItem as Soferi;
        }

        private void Concediere_Click(object sender, RoutedEventArgs e)
        {

            int id = (soferiDataGrid.SelectedItem as Soferi).ID_ANGAJAT;
            Soferi sofer = (from r in ztsContext.Soferis where r.ID_ANGAJAT == id select r).SingleOrDefault();
            ztsContext.Soferis.Remove(sofer);
            ztsContext.SaveChanges();
         
        }


        private void Angajare_Click(object sender, RoutedEventArgs e)
        {
            AddDriver newDriver = new AddDriver();
            newDriver.Show();

            driversViewSource.View.Refresh();
        }
    }
}
