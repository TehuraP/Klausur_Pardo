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

namespace Mythological_Animals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel vm = new ViewModel();
            vm.GodData = new System.Collections.ObjectModel.ObservableCollection<GodModel>();

            GodModel g1 = new GodModel();
            g1.Name = "Zeus";
            g1.Description = "Lighting";
            GodModel g2 = new GodModel();
            g2.Name = "Hera";
            g2.Description = "Marriage";
            GodModel g3 = new GodModel();
            g3.Name = "Apollo";
            g3.Description = "Sea";
            GodModel g4 = new GodModel();
            g4.Name = "Hermes";
            g4.Description = "Fast";
            GodModel g5 = new GodModel();
            g5.Name = "Aphrodite";
            g5.Description = "Sex";

            vm.GodData.Add(g1);
            vm.GodData.Add(g2);
            vm.GodData.Add(g3);
            vm.GodData.Add(g4);
            vm.GodData.Add(g5);

            vm.NewGod = new GodModel();
          //  vm.AddGod();

            this.DataContext = vm;
            vm.FillProdukteFromDB();
           
        }
        private void MenuItemNeuesProdukt_Click(object sender, RoutedEventArgs e)
        {
            NewWindow myNewWindow = new NewWindow();
            ViewModel vm = this.DataContext as ViewModel;
            myNewWindow.DataContext = vm;
            myNewWindow.ShowDialog();
        }

        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            ViewModel vm = this.DataContext as ViewModel;
            vm.DeleteProdukt();
        }
    }
}
