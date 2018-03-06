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
using System.Windows.Shapes;

namespace GROBSI
{
    /// <summary>
    /// Interaction logic for ResolutionSelector.xaml
    /// </summary>
    public partial class ResolutionSelector : Window
    {
        int[,] resoultions = new int[,] {{1366, 768}, { 1440, 900 }, { 1920, 1080}};

        public ResolutionSelector()
        {
            InitializeComponent();


        }
        
        private void GenerateButtons()
        {
            foreach(int res in this.resoultions)
            {
                //TODO: dynamically generate buttons from string array
            }
        }

        private void ConfirmButton_click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void ResolutionButton_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            string[] resolution = bt.Content.ToString().Split('x');
            this.heightTextBox.Text = resolution[0];
            this.widthTextBox.Text = resolution[1];
        }
    }
}
