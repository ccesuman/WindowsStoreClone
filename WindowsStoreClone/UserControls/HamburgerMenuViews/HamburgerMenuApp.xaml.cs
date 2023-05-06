using MiscUtil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
    /// Interaction logic for HamburgerMenuApp.xaml
    /// </summary>
    public partial class HamburgerMenuApp : UserControl
    {
        public List<string> AppNames;
        public List<string> AppType;
        public string AppName;
        public DateTime Purchased;
        public string Type;
        public HamburgerMenuApp()
        {
            InitializeComponent();

            AppType= new List<string>()
            {
                "App",
                "Game",
                "Movie",
                "Avatar",
            };
             
            List<string> filepaths = Directory.GetFiles(Environment.CurrentDirectory
               + @"\..\..\Images\MiniIcons", "*.png").ToList<string>();

            FileInfo myRandomFile = new FileInfo(filepaths[StaticRandom.Next(filepaths.Count)]);

            AppImage.Source = new BitmapImage(
                new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute));

            //this is for filtering the name of the image from the path and hold the name of the image
            AppNameLabel.Content = (new CultureInfo("en-US", false).TextInfo).ToTitleCase
                (
                AppImage.Source.ToString().Split('/').Last().Split('.').First().Split('-').Last().Split('.').First()
                );
            AppName = AppNameLabel.Content.ToString();
            Type = AppType[StaticRandom.Next(AppType.Count)];
            Purchased = new DateTime(2021,1,StaticRandom.Next(1,DateTime.Now.Day +1));
            PucrhasedLabel.Content= "Purchased "+Purchased.ToString("d");
        }
    }
}
