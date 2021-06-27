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
    /// Interaction logic for AddContract.xaml
    /// </summary>
    public partial class AddContract : Window
    {
        public AddContract()
        {
            InitializeComponent();
        }

        private void AddContract_Click(object sender, RoutedEventArgs e)
        {

            ZorTranSEntities db = new ZorTranSEntities();
            db.insert_client(Adresa.Text, Telefon.Text, Email.Text);
            int max = db.Clientis.Max(p => p.ID_CLIENT);
            if (check_PF.IsChecked == true && check_PJ.IsChecked == false)
            {
                db.insert_client_fizic(Nume.Text, Prenume.Text, max, 5, CNP.Text);
                MessageBox.Show("Contract adaugat cu succes!");
                this.Close();
            }
            else if (check_PF.IsChecked == false && check_PJ.IsChecked == true)
            {
                db.insert_client_juridic(nume.Text, cui.Text, nrRegCom.Text, max, 2);
                MessageBox.Show("Contract adaugat cu succes!");
                this.Close();
            }
            //apelam procedura pt client
            //
            //in functie de chech PJ sau check PF apelam procedura aferenta

            else
            MessageBox.Show("Date incomplete !");

        }

        private void Check_PJ_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Check_PJ_Unloaded(object sender, RoutedEventArgs e)
        {
            //Nume.IsReadOnly = false;
            //Prenume.IsReadOnly = false;
            //CNP.IsReadOnly = false;
            Nume.IsReadOnly = false;
            Prenume.IsReadOnly = false;
            CNP.IsReadOnly = false;

        }

        private void Check_PF_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Check_PF_Unloaded(object sender, RoutedEventArgs e)
        {
            nume.IsReadOnly = false;
            nrRegCom.IsReadOnly = false;
            cui.IsReadOnly = false;
        }
    }
}