using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace ZORTRANS
{
    /// <summary>
    /// Interaction logic for AddTransport.xaml
    /// </summary>
    public partial class AddTransport : Window
    {
        ZorTranSEntities ztsContext = new ZorTranSEntities();
        CollectionViewSource locatiiViewSource;

        public AddTransport()
        {
            InitializeComponent();
            locatiiViewSource = ((CollectionViewSource)(FindResource("locatiiViewSource")));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource locatiiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("locatiiViewSource")));
            ztsContext.Locatiis.Load();
            locatiiViewSource.Source = ztsContext.Locatiis.Local;
            // Load data by setting the CollectionViewSource.Source property:
            // locatiiViewSource.Source = [generic data source]
        }
        private void AdaugaTransport_Click(object sender, RoutedEventArgs e)
        {
            ZorTranSEntities db = new ZorTranSEntities();

            db.insert_transport(plecare.Text,destinatie.Text,Int32.Parse(distanta.Text),marfa.Text,float.Parse(greutate.Text),float.Parse(pretkm.Text),System.DateTime.Parse(data.Text),Int32.Parse(iD_LOCATIETextBox.Text));
            this.Close();

            MessageBox.Show("Transport adaugat cu succes!");

        }

        private void Adauga_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
