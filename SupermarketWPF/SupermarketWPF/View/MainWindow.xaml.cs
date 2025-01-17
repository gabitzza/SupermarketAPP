﻿using SupermarketWPF.ViewModels;
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

namespace SupermarketWPF.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
        }

        private void OpenCasierView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var view = new LoginView();
                view.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open LoginView: " + ex.Message);
            }
        }
    }
}
