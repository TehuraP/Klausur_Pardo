﻿using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Mythological_Animals
{
    /// <summary>
    /// Interaction logic for MythWindow.xaml
    /// </summary>
    public partial class MythWindow : Window
    {
        public MythWindow()
        {
            InitializeComponent();

            ViewModel vm = new ViewModel();       

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)FindResource("RotateAnimation");
            sb.Begin(kittie);
        }

    }
}
