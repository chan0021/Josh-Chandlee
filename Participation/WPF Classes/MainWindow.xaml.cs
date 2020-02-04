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

namespace WPF_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtAddress.Text = string.Empty;
            txtName.Text = string.Empty;
            txtZipCode.Text = string.Empty;

        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name, address, zipcode;
            name = txtName.Text;
            address = txtAddress.Text;
            zipcode = txtZipCode.Text;

            if(string.IsNullOrWhiteSpace(address)==true)
            {
                MessageBox.Show("Please enter an address");
            }
            int Zip;
            bool isZipAnInt = int.TryParse(zipcode, out Zip);
            if(isZipAnInt == false)
            {
                MessageBox.Show("Please enter a valid address");
            }

            EntryForm ef = new EntryForm(name, address, Zip);
            ef.Address = address;
            ef.Name = name;
            ef.ZipCode = Convert.ToInt32(zipcode);
            lbxListBox.Items.Add(ef);
        }
    }
}
