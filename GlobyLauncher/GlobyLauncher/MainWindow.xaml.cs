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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GlobyLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String SampleLabelText = "Launcher Loaded Successfully";
        public SolidColorBrush ButUIWhite = new SolidColorBrush(Colors.White);
        public SolidColorBrush ButUIGray = (SolidColorBrush)new BrushConverter().ConvertFrom("#333333");
        public SolidColorBrush ButUIDefault = new SolidColorBrush(Colors.PowderBlue);
        protected ImageBrush GlobyLBG = new ImageBrush();
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += OnLoadText;
        }

        private void OnLoadText(object sender, EventArgs e) {
            OriginalButton(sender, e);
        }

        private void Globy1_0View_Click(object sender, RoutedEventArgs e)
        {
            OriginalButton(sender, e);
        }

        private void Globy1_5View_Click(object sender, RoutedEventArgs e)
        {
            RpgButton(sender, e);
        }

        private void GlobyCEView_Click(object sender, RoutedEventArgs e)
        {
            CEButton(sender, e);
        }

        private void InfoView_Click(object sender, RoutedEventArgs e)
        {
            InfoButton(sender, e);
        }

        protected void OriginalButton(object sender, EventArgs e) 
        {
            ///Button Views
            Globy1_0View.Background = ButUIDefault;
            Globy1_0View.Foreground = ButUIWhite;

            Globy1_5View.Background = ButUIWhite;
            Globy1_5View.Foreground = ButUIGray;

            GlobyCEView.Background = ButUIWhite;
            GlobyCEView.Foreground = ButUIGray;

            InfoView.Background = ButUIWhite;
            InfoView.Foreground = ButUIGray;
        }
        protected void RpgButton(object sender, EventArgs e)
        {
            ///Button Views
            Globy1_0View.Background = ButUIWhite;
            Globy1_0View.Foreground = ButUIGray;

            Globy1_5View.Background = ButUIDefault;
            Globy1_5View.Foreground = ButUIWhite;

            GlobyCEView.Background = ButUIWhite;
            GlobyCEView.Foreground = ButUIGray;

            InfoView.Background = ButUIWhite;
            InfoView.Foreground = ButUIGray;
        }
        protected void CEButton(object sender, EventArgs e)
        {
            ///Button Views
            Globy1_0View.Background = ButUIWhite;
            Globy1_0View.Foreground = ButUIGray;

            Globy1_5View.Background = ButUIWhite;
            Globy1_5View.Foreground = ButUIGray;

            GlobyCEView.Background = ButUIDefault;
            GlobyCEView.Foreground = ButUIWhite;

            InfoView.Background = ButUIWhite;
            InfoView.Foreground = ButUIGray;
        }
        protected void InfoButton(object sender, EventArgs e)
        {
            ///Button Views
            Globy1_0View.Background = ButUIWhite;
            Globy1_0View.Foreground = ButUIGray;

            Globy1_5View.Background = ButUIWhite;
            Globy1_5View.Foreground = ButUIGray;

            GlobyCEView.Background = ButUIWhite;
            GlobyCEView.Foreground = ButUIGray;

            InfoView.Background = ButUIDefault;
            InfoView.Foreground = ButUIWhite;
        }
    }
}
