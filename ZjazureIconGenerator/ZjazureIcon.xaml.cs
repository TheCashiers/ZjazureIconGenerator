using System;
using System.Collections.Generic;
using System.IO;
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

namespace ZjazureIconGenerator
{
    /// <summary>
    /// Interaction logic for ZjazureIcon.xaml
    /// </summary>
    public partial class ZjazureIcon : UserControl
    {
        public ZjazureIcon()
        {
            InitializeComponent();
        }

        public Brush IconBackground
        {
            get { return (Brush)GetValue(IconBackgroundProperty); }
            set { SetValue(IconBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register(nameof(IconBackground), typeof(Brush), typeof(ZjazureIcon), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0x51, 0x2E, 0x70))));

        public Brush IconForeground
        {
            get { return (Brush)GetValue(IconForegroundProperty); }
            set { SetValue(IconForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ForegroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconForegroundProperty =
            DependencyProperty.Register(nameof(IconForeground), typeof(Brush), typeof(ZjazureIcon), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(115, 0x00, 0xD1, 0xFE))));

        public void SaveAsPNG(string path)
        {
            var rtb = new RenderTargetBitmap(512, 512, 96, 96, PixelFormats.Default);
            rtb.Render(rootCanvas);
            var png = new PngBitmapEncoder();
            png.Frames.Add(BitmapFrame.Create(rtb));
            using (var fs = File.OpenWrite(path))
            {
                png.Save(fs);
            }
        }

    }
}
