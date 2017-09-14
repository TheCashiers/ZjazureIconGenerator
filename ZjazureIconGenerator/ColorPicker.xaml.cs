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

namespace ZjazureIconGenerator
{
    /// <summary>
    /// Interaction logic for ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker : UserControl
    {
        public ColorPicker()
        {
            InitializeComponent();
            MultiBinding mb = CreateColorBinding();

            SetBinding(ColorProperty, mb);
        }

        private static MultiBinding CreateColorBinding()
        {
            var mb = new MultiBinding
            {
                Converter = new ColorConverter(),
                Mode = BindingMode.TwoWay
            };
            mb.Bindings.Add(new Binding("Value") { ElementName = "rSetter", Mode = BindingMode.TwoWay });
            mb.Bindings.Add(new Binding("Value") { ElementName = "gSetter", Mode = BindingMode.TwoWay });
            mb.Bindings.Add(new Binding("Value") { ElementName = "bSetter", Mode = BindingMode.TwoWay });
            mb.Bindings.Add(new Binding("Value") { ElementName = "aSetter", Mode = BindingMode.TwoWay });
            return mb;
        }

        public Color Color
        {
            get { return (Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Color.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(Color), typeof(ColorPicker), new PropertyMetadata(default(Color)));


    }
}
