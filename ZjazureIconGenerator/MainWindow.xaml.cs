using Microsoft.Win32;
using System;
using System.Windows;

namespace ZjazureIconGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClick(object sender, RoutedEventArgs e)
        {
            var dlg = new SaveFileDialog
            {
                Filter = "PNG image (*.png)|*.png",
                FileName = "zjazure.png"
            };
            if (dlg.ShowDialog().GetValueOrDefault())
            {
                try
                {
                    icon.SaveAsPNG(dlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Saving Image", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
