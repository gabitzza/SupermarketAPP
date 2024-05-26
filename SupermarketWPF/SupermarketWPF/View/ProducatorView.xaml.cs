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
using System.Windows.Shapes;

namespace SupermarketWPF.View
{
    /// <summary>
    /// Interaction logic for ProducatorView.xaml
    /// </summary>
    public partial class ProducatorView : Window
    {
        public ProducatorView()
        {
            InitializeComponent();
            DataContext = new ProducatoriVM();
        }
    }
}
