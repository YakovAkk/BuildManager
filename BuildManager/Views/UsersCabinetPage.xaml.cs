﻿using BuildManager.ViewModels;
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

namespace BuildManager.Views
{
    /// <summary>
    /// Interaction logic for UsersCabinetPage.xaml
    /// </summary>
    public partial class UsersCabinetPage : Page
    {
        public UsersCabinetPage()
        {
            InitializeComponent();
            DataContext = new UsersCabinetViewModel();
        }
    }
}
