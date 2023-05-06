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
    /// Interaction logic for TopAppWrapped.xaml
    /// </summary>
    public partial class TopAppWrapped : Page
    {
        

        public delegate void OnAnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAnAppClicked AnAppClicked;

        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;
        public TopAppWrapped()
        {
            InitializeComponent();
            for(int i=0;i<20;i++)
            {
                AnApp currAnApp= new AnApp();
                currAnApp.AppClicked += CurrAnApp_AppClicked;
                TopAppsWrappedPageMainWrapPanel.Children.Add(currAnApp);
            }
        }
        private void CurrAnApp_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AnAppClicked(sender, e);
        }

        private void Back_Btn(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);   

        }

        private void TopAppsWrappedPageMainSV_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if(e.VerticalChange >0)
            {
                int adjustment = 400;
                if(e.VerticalOffset + e.ViewportHeight + adjustment >= e.ExtentHeight)
                {
                    for(int i=0;i<6;i++)
                    {
                        AnApp currAnApp = new AnApp();
                        currAnApp.AppClicked += CurrAnApp_AppClicked;
                        TopAppsWrappedPageMainWrapPanel.Children.Add(currAnApp);
                    }
                }
            }

        }
    }
}
