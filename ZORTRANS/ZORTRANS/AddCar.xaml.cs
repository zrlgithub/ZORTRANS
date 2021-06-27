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
    /// Interaction logic for adaugamasina.xaml
    /// </summary>
    public partial class adaugamasina : Window
    {
        public adaugamasina()
        {
            InitializeComponent();
        }

        private void Adauga_Click(object sender, RoutedEventArgs e)
        {
            ZorTranSEntities db = new ZorTranSEntities();

            db.insert_masina(marca.Text, model.Text, nrinmatriculare.Text, tip.Text,Int32.Parse(idtransport.Text));
            this.Close();
            MessageBox.Show("Masina adaugata cu succes!");
            
        }
    }
}
