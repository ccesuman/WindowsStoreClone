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
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for AppDetails.xaml
    /// </summary>
    public partial class AppDetails : Page
    {
        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;

        public delegate void OnAppDetailsAnotherAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppDetailsAnotherAppClicked AppClicked;
        public AppDetails(AnApp anApp)
        {
            InitializeComponent();
            AppDetailsTitleAndBackgroundUC.AppNameLabel.Content = anApp.AppName;
            AppDetailsTitleAndBackgroundUC.AppImage.Source = anApp.AppImageSource;
            AppDetailsTitleAndBackgroundUC.BackButtonClicked += AppDetailsTitleAndBackgroundUC_BackButtonClicked;

            OverviewTabUC.AppClicked += OverviewTabUC_AppClicked;
        }
        private void OverviewTabUC_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }
        private void AppDetailsTitleAndBackgroundUC_BackButtonClicked(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }
    }
}
