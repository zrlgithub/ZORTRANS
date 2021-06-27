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
    
    public partial class Menu : Window
    {
        ZorTranSEntities ztsContext = new ZorTranSEntities();
        CollectionViewSource transViewSource;

        public Menu()
        {

            InitializeComponent();
            transViewSource = ((CollectionViewSource)(FindResource("transporturiViewSource")));
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

            System.Windows.Data.CollectionViewSource transporturiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("transporturiViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // transporturiViewSource.Source = [generic data source]
            ztsContext.Transporturis.Load();
            transporturiViewSource.Source = ztsContext.Transporturis.Local;
            System.Windows.Data.CollectionViewSource soferiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("soferiViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // soferiViewSource.Source = [generic data source]
        }

        private void TransporturiDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void B_addTransport_Click(object sender, RoutedEventArgs e)
        {
            AddTransport newTransport = new AddTransport();
            newTransport.Show();

            Menu menu = new Menu();
            menu.Show();
            this.Close();

            transViewSource.View.Refresh();

            transporturiDataGrid.ItemsSource = null;
            transporturiDataGrid.ItemsSource = ztsContext.Transporturis.Local;


            transporturiDataGrid.Items.Refresh();
            transporturiDataGrid.UpdateLayout();
            CollectionViewSource.GetDefaultView(transporturiDataGrid.ItemsSource).Refresh();
        }

        private void B_createRaport_Click(object sender, RoutedEventArgs e)
        {
            Window1 raport = new Window1();
                raport.Show();

        }

        private void B_afisareVenit_Click(object sender, RoutedEventArgs e)
        {
            ZorTranSEntities db = new ZorTranSEntities();
            double? objectResults = db.VenitTotalFirma().FirstOrDefault();
            if (objectResults.HasValue)
            {
                MessageBox.Show(string.Format("Venit total al firmei este {0} lei.", objectResults));
            }
        }

        private void B_angajati_Click(object sender, RoutedEventArgs e)
        {
            Window2 raportAngajati = new Window2();
            raportAngajati.Show();
        }
    }
}
