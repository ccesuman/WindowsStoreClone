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
using MahApps.Metro.Controls;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for DownloadsAndUpdates.xaml
    /// </summary>
    public partial class DownloadsAndUpdates : Page
    {

        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;
        public DownloadsAndUpdates()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }

        private void HamburgerMenuControl_ItemInvoked(object sender,  HamburgerMenuItemInvokedEventArgs args)
        {
            HamburgerMenuControl.Content = args.InvokedItem;
        }
    }
}
