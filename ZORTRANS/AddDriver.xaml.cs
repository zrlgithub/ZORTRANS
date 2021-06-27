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

namespace ZORTRANS
{
    /// <summary>
    /// Interaction logic for AddDriver.xaml
    /// </summary>
    public partial class AddDriver : Window
    {
        public AddDriver()
        {
            InitializeComponent();
        }

        private void Angajare_Click(object sender, RoutedEventArgs e)
        {
            ZorTranSEntities db = new ZorTranSEntities();

            db.insert_angajat(nume.Text,prenume.Text,adresa.Text, System.DateTime.Parse(data.Text),cnp.Text,telefon.Text,1);

            int max = db.Angajatis.Max(p => p.ID_Angajat);
            db.insert_sofer(categorie.Text, Int32.Parse(id.Text),max,2);

            this.Close();
            MessageBox.Show("Sofer angajat cu succes!");

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource masiniViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("masiniViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // masiniViewSource.Source = [generic data source]
        }
    }
}
