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
    /// Interaction logic for Reviews.xaml
    /// </summary>
    public partial class Reviews : UserControl
    {
        public Reviews()
        {
            InitializeComponent();

            MainStackPanel.Children.Clear();
            for (int i = 0; i < 9; i++)
            {
                (MainStackPanel as StackPanel).Children.Add(new AReview());
            }
        }

        
    }
}
