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
using WindowsStoreClone.Pages;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private Main MainwindowContentPage;
        private TopAppWrapped MyTopAppsWrappedPage;
        private DownloadsAndUpdates DownloadsAndUpdatesPages;
        public MainWindow()
        {
            InitializeComponent();
            MainwindowContentPage = new Main();
            MainwindowContentPage.AppClicked += MainWindowContentPage_AppClicked;

            MainwindowContentPage.TopAppButtonClicked += MainWindowContentPage_TopAppButtonClicked;


            MyTopAppsWrappedPage = new TopAppWrapped();
            MyTopAppsWrappedPage.AnAppClicked += MainWindowContentPage_AppClicked;
            MyTopAppsWrappedPage.BackButtonClicked += BackButtonClicked;


            DownloadsAndUpdatesPages = new DownloadsAndUpdates();
            MainwindowContentPage.DownloadsAndUpdatesClicked += MainWindowContentPage_DownloadsAndUpdatesClicked;

            DownloadsAndUpdatesPages.BackButtonClicked += BackButtonClicked;

        }

        private void MainWindowContentPage_TopAppButtonClicked(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = MyTopAppsWrappedPage;
        }
        private void MainWindowContentPage_DownloadsAndUpdatesClicked()
        {
            MainWindowFrame.Content = DownloadsAndUpdatesPages;
        }
        private void MainWindowContentPage_AppClicked(AnApp sender , RoutedEventArgs e)
        {
            AppDetails myAppDetails = new AppDetails(sender);
            myAppDetails.BackButtonClicked += BackButtonClicked;
            myAppDetails.AppClicked += MainWindowContentPage_AppClicked;
            MainWindowFrame.Content = myAppDetails;
             


        }
       

        private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
        {
          //  AppDetails myAppDetails= new AppDetails();
            MainWindowFrame.Content = MainwindowContentPage;
        }

        private void  BackButtonClicked(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoBack)
            {
                MainWindowFrame.NavigationService.GoBack();
            }
        }
    }
}
