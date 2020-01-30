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

namespace EntryForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtName.Text = "";
            txtAddress.Text = "";
            txtZipCode.Text = "";

        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            EntryForm newEntryForm = new EntryForm();
            newEntryForm.Name = txtName.Text;
            newEntryForm.Address = txtAddress.Text;
            newEntryForm.ZipCode = Convert.ToInt32(txtZipCode.Text);

            lstOutput.Items.Add(newEntryForm.ToString());


        }

        private void TxtAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtZipCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LstOutput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

