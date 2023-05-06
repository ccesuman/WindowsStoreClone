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

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AppsViewer.xaml
    /// </summary>
    public partial class AppsViewer : UserControl
    {
        List<AnApp> PresentedApps;
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;
        public AppsViewer()
        {
            InitializeComponent();
            PresentedApps = new List<AnApp>();
            AppList.ItemsSource= PresentedApps;
            for(int i=0;i<20;i++)
            {
                AnApp curr = new AnApp();
                curr.AppClicked += Curr_AppClicked;
                PresentedApps.Add(curr);
            }
        }

        private void Curr_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfOneApp = (int)PresentedApps.First().ActualWidth + 
                2 * (int)PresentedApps.First().Margin.Left;

            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset - 4 * widthOfOneApp);
        }

        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfOneApp = (int)PresentedApps.First().ActualWidth +
                2 * (int)PresentedApps.First().Margin.Left;

            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset + 4 * widthOfOneApp);

        }

        private void AppsScrollView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled= true;
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArg.RoutedEvent = UIElement.MouseWheelEvent;
            eventArg.Source = sender;
            var parent = ((Control)sender).Parent as UIElement;
            parent.RaiseEvent(eventArg);

        }
    }
}
