using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Voyage> voyages = null;
        public MainWindow()
        {
            try
            {
                InitializeComponent();

                voyages = new ObservableCollection<Voyage>();
                Voyage nerja = new Voyage("NERJA EL CAPISTRANO", "Espagne", "http://flags.fmcdn.net/data/flags/w580/es.png", 5, "EL CAPISTRANO est un complexe touristique formé de plusieurs petits villages typiquement andalous situé à 2 km au sud de Nerja", new DateTime(2018, 11, 24), 148, 4);
                voyages.Add(nerja);
                Voyage thailande = new Voyage("CIRCUIT ORCHIDÉES", "Thaïlande", "http://flags.fmcdn.net/data/flags/w580/th.png", 10, "Visites de sites historiques classés au patrimoine mondial de l'UNESCO. Immersion dans une Thaïlande authentique grâce à la rencontre avec des tribus mythiques. Découverte des traditions lors des dîners spectacles à Bangkok et Chiang Mai", new DateTime(2018, 11, 28), 2138, 4);
                voyages.Add(thailande);
                Voyage teide = new Voyage("CIRCUIT SUR LA ROUTE DU TEIDE", "Espagne", "http://flags.fmcdn.net/data/flags/w580/es.png", 8, "Un programme qui vous mènera du nord au sud de Tenerife ! Découvrez les charmes, la nature et l’histoire de cette île. Une première approche idéale de l’éternel printemps.", new DateTime(2019, 01, 12), 1209, 3);
                voyages.Add(teide);
                Voyage islande = new Voyage("ESSENTIEL D'ISLANDE", "Islande", "http://flags.fmcdn.net/data/flags/w580/is.png", 9, "Le tour de l'Islande en une semaine.", new DateTime(2019, 05, 27), 2580, 3);
                voyages.Add(islande);
                Voyage sicile = new Voyage("CIRCUIT PARFUMS DE SICILE", "Italie", "http://flags.fmcdn.net/data/flags/w580/it.png", 7, "Le tour de la Sicile en une semaine", new DateTime(2019, 04, 12), 1099, 1);
                voyages.Add(sicile);
                Voyage malte = new Voyage("CIRCUIT ECHAPPÉE MALTAISE", "Malte", "http://flags.fmcdn.net/data/flags/w580/mt.png", 7, "Le tour de Malte en une semaine", new DateTime(2019, 04, 04), 895, 2);
                voyages.Add(malte);
                Voyage norvege = new Voyage("DU SPITZBERG AUX FJORDS DE NORVÈGE", "Norvège", "http://flagpedia.net/data/flags/w580/no.png", 12, "Découverte des îles jusqu'au cap Nord.", new DateTime(2019, 05, 21), 3265, 5);
                voyages.Add(norvege);
                Voyage senegal = new Voyage("ROYAM", "Sénégal", "http://flagpedia.net/data/flags/w580/sn.png", 8, "Vous serez charmé par cet hôtel avec ses bungalows de style africain et son aspect intimiste, son jardin composé de fleurs tropicales et de bouganvilliers, sa plage bordée de majestueux cocotiers sur la Petite Côte à Saly.", new DateTime(2018, 11, 27), 1296, 3);
                voyages.Add(senegal);
                Voyage inde = new Voyage("DU TAJ MAHAL À AMRITSAR", "Inde", "http://flagpedia.net/data/flags/w580/in.png", 12, "Une promenade en Rickshaw à Jaipur. Balade à dos d'éléphants ou en jeep à Jaipur. Suroth, village fortifié hors des sentiers battus. Voyage dans le temps à Fatehpur Sikri. Une balade en calèche à Agra. Le spectacle à Agra. Découverte de la merveilleuse cité du Sikhisme", new DateTime(2018, 12, 5), 1479, 5);
                voyages.Add(inde);
                Voyage croatie = new Voyage("CLUB MARMARA BONACA", "Croatie", "http://flags.fmcdn.net/data/flags/w580/hr.png", 8, "Envie de vues mer panoramiques, de la douceur des îles et de vacances mi-calmes mi-sportives ? Pas de doute, ce club niché sur l’île de Brac au large de Split est fait pour vous ! Profitez de sa situation exceptionnelle sur la côte Adriatique et de ses multiples activités… Club Marmara, l’expérience club en toute convivialité !", new DateTime(2019, 6, 1), 929, 3);
                voyages.Add(croatie);
                DataContext = voyages;

            }
            catch(Exception ex)
            {
                MessageBox.Show("erreur" + ex.Message);
            }

     
        }
        private void Button_Click_Deselect(object sender, RoutedEventArgs e)
        {
            this.list.UnselectAll();
        }


        private void Button_Click_Suppr(object sender, RoutedEventArgs e)
        {
            voyages.Remove((Voyage)this.list.SelectedItem);
        }


        private void btnajouter_Click(object sender, RoutedEventArgs e)
        {
            Voyage voyage = new Voyage("", "", "", 0, "", new DateTime(0001, 01, 01), 0, 0);
            voyages.Add(voyage);
            DataContext = voyages;
        }
    }
}
