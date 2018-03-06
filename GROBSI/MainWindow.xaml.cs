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

namespace GROBSI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int resolutionWidth = 0;
        private int resolutionHeight = 0;
        public MainWindow()
        {
            ResolutionSelector rs = new ResolutionSelector();
            if (rs.ShowDialog() == true)
            {
                InitializeComponent();
            }
            else
                this.Close();

            tempLabelHeight.Content = resolutionHeight;
            tempLabelWidth.Content = resolutionWidth;
        }
    }
}
