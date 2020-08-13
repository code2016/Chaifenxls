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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReadAndWrite;
using TB = System.Data.DataTable;
namespace Chaifenxls
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        TB tb = new TB();
        private void But_open_Click(object sender, RoutedEventArgs e)
        {
            Tuple<TB,string> readxls= XlsRAW.readxlsdir();
            this.lab_open.Content = readxls.Item2;
        }

        private void deal()
        {
            
            List<Dangyuerangli> data = new List<Dangyuerangli>();
            for (int i = 0; i < data.Count; i++)
            {

            }
        }
    }
}
