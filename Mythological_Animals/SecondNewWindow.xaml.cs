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

namespace Mythological_Animals
{
    /// <summary>
    /// Interaction logic for SecondNewWindow.xaml
    /// </summary>
    public partial class SecondNewWindow : Window
    {
        public SecondNewWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel vm = this.DataContext as ViewModel;
            vm.AddMyth();
            this.Close();
        }
    }
}
