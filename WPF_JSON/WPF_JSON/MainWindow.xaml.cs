using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WPF_JSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string apiURL = "https://rickandmortyapi.com/api/character/";
            RickandMortyAPIResult apiInfo;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(apiURL).Result;

                apiInfo = JsonConvert.DeserializeObject<RickandMortyAPIResult>(json);

            }
            foreach (var character in apiInfo.results)
            {
                lstCharacter.Items.Add(character);
            }
        }

        private void LstCharacter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResultObject selectedCharacter = (ResultObject)lstCharacter.SelectedItem;
            imgCharacter.Source = new BitmapImage(new System.Uri(selectedCharacter.image));

        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            ResultObject selectedCharacter = (ResultObject)lstCharacter.SelectedItem;

            wbCharacter.Source = new System.Uri(selectedCharacter.image);
        }
    }
}
