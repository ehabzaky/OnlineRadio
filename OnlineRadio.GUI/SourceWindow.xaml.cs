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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OnlineRadio.GUI
{
    /// <summary>
    /// Interaction logic for SourceWindow.xaml
    /// </summary>
    public partial class SourceWindow : Window
    {
        public Source SourceResult
        {
            get;
            set;
        }

        public SourceWindow(Source SourceInput) : this()
        {
            NameBox.Text = SourceInput.Name;
            UrlBox.Text = SourceInput.Url;
            ArtistTitleOrderInvertedBox.IsChecked = SourceInput.ArtistTitleOrderInverted;
        }

        public SourceWindow()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            SourceResult = new Source(NameBox.Text, UrlBox.Text, ArtistTitleOrderInvertedBox.IsChecked ?? false);
            DialogResult = true;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
