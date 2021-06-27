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
using System.Windows.Forms;
using System.Xaml;
using System.Xml;
namespace ZORTRANS
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            ZorTranSEntities db = new ZorTranSEntities();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = from c in db.Angajatis select c;
            this._reportViewer.LocalReport.ReportPath = "../../Report1.rdlc";
            _reportViewer.RefreshReport();
        }
    }
}
