using System.Windows;
using System.Windows.Input;

namespace WpfParticipation
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
            btnSubmit.Margin = new Thickness(50,50,0,0);
        }
    }
}
