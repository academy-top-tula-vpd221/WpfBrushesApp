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

namespace WpfBrushesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn2.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));//(Colors.Aqua);

            var gradient = new LinearGradientBrush();
            gradient.StartPoint = new Point(0, 1);
            gradient.EndPoint = new Point(0, 0);
            gradient.GradientStops.Add(new GradientStop(Colors.Azure, 0));
            gradient.GradientStops.Add(new GradientStop(Colors.Red, 1));
            btn4.Background = gradient;
        }
    }
}
