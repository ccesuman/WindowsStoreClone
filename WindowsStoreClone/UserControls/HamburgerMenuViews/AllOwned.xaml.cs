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

namespace WindowsStoreClone.UserControls.HamburgerMenuViews
{
    /// <summary>
    /// Interaction logic for AllOwned.xaml
    /// </summary>
    public partial class AllOwned : UserControl
    {

        
        public AllOwned()
        {
            InitializeComponent();

            HamHeder.FilterMenuItemClicked += HamHeader_FilterMenuItemClicked;
            HamHeder.SortByMenuItemClicked += HamHeader_SortedByMenuItemClicked;
        }
        private void HamHeader_FilterMenuItemClicked(object sender,RoutedEventArgs e)
        {
            if((sender as MenuItem).Header.ToString().ToLower()=="all types")
            {
                HamAppsList.AddAll();
            }
            else
            {
                HamAppsList.FilterByType((sender as MenuItem).Header.ToString());
            }
        }
        private void HamHeader_SortedByMenuItemClicked(object sender,RoutedEventArgs e)
        {
            if((sender as MenuItem).Header.ToString().ToLower()=="sort by name")
            {
                HamAppsList.SortByName();
            }
            else
            {
                HamAppsList.SortByDate();
            }
        }
    }
}
