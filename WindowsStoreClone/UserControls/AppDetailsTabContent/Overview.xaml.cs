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

namespace WindowsStoreClone.UserControls.AppDetailsTabContent
{
    /// <summary>
    /// Interaction logic for Overview.xaml
    /// </summary>
    public partial class Overview : UserControl
    {
        public delegate void OnAppDetailsAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppDetailsAppClicked AppClicked;
        public Overview()
        {
            InitializeComponent();
            AppsViewerInsideOwerviewTab.AppClicked += AppsViewerInsideOwerviewTab_AnAppClicked;
        }
        private void AppsViewerInsideOwerviewTab_AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

    }
}
