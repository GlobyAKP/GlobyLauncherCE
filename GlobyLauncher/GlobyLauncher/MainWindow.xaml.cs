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
        private ImageBrush GlobyLBG = new ImageBrush();
        private ImageBrush GlobyLeftStackBG = new ImageBrush();
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += OnLoadText;

            GlobyLeftStackBG.ImageSource = new BitmapImage(new Uri("/WorkSpace/Globy CE/Launcher/GlobyLauncher/GlobyLauncher/Assets/peakpx.jpg", UriKind.Relative));
            LeftDivStack.Background = GlobyLeftStackBG;
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

            //Image Changes
            GlobyLBG.ImageSource = new BitmapImage(new Uri("/WorkSpace/Globy CE/Launcher/GlobyLauncher/GlobyLauncher/Assets/10(Temp).jpg", UriKind.Relative));
            CanvasStack70_.Background = GlobyLBG;

            //Button Changes
            Globy10PlayBut.IsEnabled = true;
            Globy10PlayBut.Visibility = Visibility.Visible;

            Globy15PlayBut.IsEnabled = false;
            Globy15PlayBut.Visibility = Visibility.Collapsed;

            GlobyCEPlayBut.IsEnabled = false;
            GlobyCEPlayBut.Visibility = Visibility.Collapsed;

            CreditsWrap.IsEnabled = false;
            CreditsWrap.Visibility = Visibility.Collapsed;
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

            //Image Changes
            GlobyLBG.ImageSource = new BitmapImage(new Uri("/WorkSpace/Globy CE/Launcher/GlobyLauncher/GlobyLauncher/Assets/rpg(temp).jfif", UriKind.Relative));
            CanvasStack70_.Background = GlobyLBG;

            //Button Changes
            Globy10PlayBut.IsEnabled = false;
            Globy10PlayBut.Visibility = Visibility.Collapsed;

            Globy15PlayBut.IsEnabled = true;
            Globy15PlayBut.Visibility = Visibility.Visible;

            GlobyCEPlayBut.IsEnabled = false;
            GlobyCEPlayBut.Visibility = Visibility.Collapsed;

            CreditsWrap.IsEnabled = false;
            CreditsWrap.Visibility = Visibility.Collapsed;
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

            //Image Changes
            GlobyLBG.ImageSource = new BitmapImage(new Uri("/WorkSpace/Globy CE/Launcher/GlobyLauncher/GlobyLauncher/Assets/CE(temp).jpg", UriKind.Relative));
            CanvasStack70_.Background = GlobyLBG;

            //Button Changes
            Globy10PlayBut.IsEnabled = false;
            Globy10PlayBut.Visibility = Visibility.Collapsed;

            Globy15PlayBut.IsEnabled = false;
            Globy15PlayBut.Visibility = Visibility.Collapsed;

            GlobyCEPlayBut.IsEnabled = true;
            GlobyCEPlayBut.Visibility = Visibility.Visible;

            CreditsWrap.IsEnabled = false;
            CreditsWrap.Visibility = Visibility.Collapsed;
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

            //Image Changes
            GlobyLBG.ImageSource = new BitmapImage(new Uri("/WorkSpace/Globy CE/Launcher/GlobyLauncher/GlobyLauncher/Assets/Blank.png", UriKind.Relative));
            CanvasStack70_.Background = GlobyLBG;

            //Button Changes
            Globy10PlayBut.IsEnabled = false;
            Globy10PlayBut.Visibility = Visibility.Collapsed;

            Globy15PlayBut.IsEnabled = false;
            Globy15PlayBut.Visibility = Visibility.Collapsed;

            GlobyCEPlayBut.IsEnabled = false;
            GlobyCEPlayBut.Visibility = Visibility.Collapsed;

            CreditsWrap.IsEnabled = true;
            CreditsWrap.Visibility = Visibility.Visible;
        }
    }
}
