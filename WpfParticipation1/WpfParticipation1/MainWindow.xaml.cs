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

namespace WpfParticipation1
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

        private void BtnSubmit_Click(object sender, MouseEventArgs e)
        {
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSubmit_MouseEnter(object sender, MouseEventArgs e)
        {
            Random submit = new Random();
            int maxLeft = Convert.ToInt32(grdMain.ActualWidth - btnSubmit.Width);
            int maxTop = Convert.ToInt32(grdMain.ActualHeight - btnSubmit.Height);

            btnSubmit.Margin = new Thickness(submit.Next(maxLeft), submit.Next(maxTop), 0, 0);

        }
    }
}
