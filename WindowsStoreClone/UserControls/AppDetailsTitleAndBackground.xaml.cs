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
    /// Interaction logic for AppDetailsTitleAndBackground.xaml
    /// </summary>
    public partial class AppDetailsTitleAndBackground : UserControl
    {
        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;
        public AppDetailsTitleAndBackground()
        {
            InitializeComponent();
        }

        private void BackButton_Btn(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }

        
    }
}
