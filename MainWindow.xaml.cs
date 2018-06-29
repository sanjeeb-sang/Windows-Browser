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
using System.Xml;

namespace WebBrowser_Version_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {

        // Instance variables to be used in this class
        // End of Instance Variables
        

        // MainWindow Constructor
        public MainWindow()
        {
            InitializeComponent();

        }

        private void DockPanel_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
