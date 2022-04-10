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

namespace ListSort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> names = new List<string>();
        
        int count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (NameBox.Text != "")
            {
                count += 1;
                Name = NameBox.Text;
                names.Add(Name);
                NameBox.Text = "";
            }
            else sortMethod();
        }

        private void sortMethod()
        {
            names.Sort();
            foreach (var name in names)
            {
                _ = MessageBox.Show(name.ToString());
            }
        }

        private void SortBtn_Click(object sender, RoutedEventArgs e)
        {
            sortMethod();
        }
    }
}
