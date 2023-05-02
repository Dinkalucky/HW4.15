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

namespace Task15._5
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //int result = await Task.Run(() => Addition(4, 5)).ConfigureAwait(false); thread lock
            int result = await Task.Run(() => Addition(4, 5)).ConfigureAwait(true);
            textBox.Text = result.ToString();
        }

        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
