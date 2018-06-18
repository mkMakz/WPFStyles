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

namespace Styles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Change_Template(object sender, RoutedEventArgs e)
        {
            ResourceDictionary template = new ResourceDictionary();

            RadioButton rb = (RadioButton)sender;

            switch(rb.Name)
            {
                case "Dark":
                    {
                        template.Source = new Uri("Resources/DarkStyle.xaml", UriKind.Relative);
                    }
                    break;
                case "Light":
                    {

                    }
                    break;
            }

            var currentResource = this.Resources.MergedDictionaries;
            this.Resources.MergedDictionaries[0] = template;
        }
    }
}
