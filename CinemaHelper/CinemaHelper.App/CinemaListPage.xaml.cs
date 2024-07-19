﻿using CinemaHelper.Core.Data;
using CinemaHelper.Core.Service;
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

namespace CinemaHelper.App
{
    /// <summary>
    /// Логика взаимодействия для CinemaListPage.xaml
    /// </summary>
    public partial class CinemaListPage : Page
    {
        public CinemaListPage(MainViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}