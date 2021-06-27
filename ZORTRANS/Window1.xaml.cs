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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace ZORTRANS
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            ReportDocument report = new ReportDocument();
            report.Load("../../CrystalReportTransp.rpt");
            using(ZorTranSEntities db=new ZorTranSEntities())
            {
                report.SetDataSource(from c in db.Transporturis select c);
            }
            cristalViewer1.ViewerCore.ReportSource = report;
            
        }
        
    }
}
