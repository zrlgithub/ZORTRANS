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
    /// Interaction logic for Parteners.xaml
    /// </summary>
    public partial class Parteners : Window
    {
        ZorTranSEntities ztsContext = new ZorTranSEntities();
        CollectionViewSource clientiwViewSource;
        CollectionViewSource persfViewSource, persjViewSource;
        public Parteners()
        {
            InitializeComponent();

            clientiwViewSource = ((CollectionViewSource)(FindResource("clientiViewSource")));
            persfViewSource = ((CollectionViewSource)(FindResource("persoane_FiziceViewSource")));
            persjViewSource = ((CollectionViewSource)(FindResource("persoane_JuridiceViewSource")));

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

        private void ClientiDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Grid1_Loaded(object sender, RoutedEventArgs e)
        {
           // btn_PJ.Foreground = Brushes.Red;


        }

        private void Grid1_Unloaded(object sender, RoutedEventArgs e)
        {
       
        }

        private void Grid2_Loaded(object sender, RoutedEventArgs e)
        {
            
            

        }

        private void CNPTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cNPTextBox.Text != " " && cUITextBox.Text == "")
            {
                btn_PF.Background = Brushes.Red;
                btn_PJ.Background = Brushes.Transparent;
            }
            else
            {
                btn_PF.Background = Brushes.Transparent;
                btn_PJ.Background = Brushes.Red;
            }
        }

        private void CUITextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            btn_PJ.Background = Brushes.Red;
        }

        private void ClientiComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void B_sendmail_Click(object sender, RoutedEventArgs e)
        {
            Mail partenerMail = new Mail(clientiComboBox.Text);
            partenerMail.Show();
            //this.Close();
        }

        private void B_addPartener_Click(object sender, RoutedEventArgs e)
        {
            AddContract newClient = new AddContract();
            newClient.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource clientiwViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientiViewSource")));

            System.Windows.Data.CollectionViewSource persoane_FiziceViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("persoane_FiziceViewSource")));
          
            System.Windows.Data.CollectionViewSource persoane_JuridiceViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("persoane_JuridiceViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            ztsContext.Clientis.Load();
            clientiwViewSource.Source = ztsContext.Clientis.Local;

           // ztsContext.Persoane_Fizice.Load();
           //ztsContext.Persoane_Juridice.Load();

           persoane_FiziceViewSource.Source = ztsContext.Persoane_Fizice.Local.GroupBy(x=>x.ID_LOCATIE).Distinct();
           persoane_JuridiceViewSource.Source = ztsContext.Persoane_Juridice.Local.GroupBy(x=>x.Nr_registru_comertului).Distinct();

        }
    }
}
