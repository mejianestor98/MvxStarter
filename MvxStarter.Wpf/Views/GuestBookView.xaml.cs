﻿using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using MvxStarter.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvxStarter.Wpf.Views
{
    /// <summary>
    /// Interaction logic for GuestBookView.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(GuestBookViewModel))]
    public partial class GuestBookView : MvxWpfView
    {
        public GuestBookView()
        {
            InitializeComponent();
        }
    }
}
