﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TEditXna.Editor.Plugins
{
    /// <summary>
    /// Interaction logic for ReplaceAllPlugin.xaml
    /// </summary>
    public partial class ReplaceAllPluginView : Window
    {
        public ReplaceAllPluginView()
        {
            InitializeComponent();
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void ReplaceButtonClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
