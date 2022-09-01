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

namespace WPF_Test_Answers.UserControls
{
    /// <summary>
    /// Логика взаимодействия для Button_UserControl.xaml
    /// </summary>
    public partial class Button_UserControl : UserControl
    {
        public Button_UserControl()
        {

            InitializeComponent();
//            myvar = UC_Rectangle.Width;
        }

        //private double myvar;

	    public double myproperty
	    {
		    get { return UC_Rectangle.Width;}
		    set { UC_Rectangle.Width = value;}
	    }
        /*
        public double RectWidth
        {
            get
            {
                return (double)GetValue(RectWidthProperty);
            }
            set
            {
                SetValue(RectWidthProperty, value);
            }
        }

        public static readonly DependencyProperty RectWidthProperty = 
               DependencyProperty.Register("RectWidth", typeof(double), 
               typeof(Button_UserControl), new PropertyMetadata(0));
        */
        private void UC_Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            Brush? MouseOver_Background = new BrushConverter().ConvertFromString("#FFBEE6FD") as Brush;
            Brush? MouseOver_Border = new BrushConverter().ConvertFromString("#FF3C7FB1") as Brush;

            UC_Rectangle.Stroke = MouseOver_Border;
            UC_Rectangle.Fill = MouseOver_Background;
        }

        private void UC_Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Brush? MouseOver_Background = new BrushConverter().ConvertFromString("#FFDDDDDD") as Brush;
            Brush? MouseOver_Border = new BrushConverter().ConvertFromString("#FF707070") as Brush;

            UC_Rectangle.Stroke = MouseOver_Border;
            UC_Rectangle.Fill = MouseOver_Background;
        }

        private void UC_Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UC_Rectangle.StrokeThickness = 2;
        }

        private void UC_Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            UC_Rectangle.StrokeThickness = 1;
        }

    }
}
