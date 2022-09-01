using Microsoft.VisualBasic;
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
using WPF_Test_Answers.UserControls;

namespace WPF_Test_Answers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button_UserControl uc1 = new Button_UserControl();

        public MainWindow()
        {
            InitializeComponent();
            Status_text.Text = uc1.myproperty.ToString();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Status_text.Text = "Standard Button is pressed";
        }

        private void RoundBtn_Click(object sender, RoutedEventArgs e)
        {
            Status_text.Text = "Round Button is pressed";
        }

        private void Button_UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Status_text.Text = "User Control Button is pressed";
            //uc1.RectWidth = 160;
        }
    }
}
