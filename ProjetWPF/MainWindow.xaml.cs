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

namespace ProjetWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, List<Film>> dico = new Dictionary<string, List<Film>>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Film> genreAventure = new List<Film>();
            List<Film> genreComedie = new List<Film>();
            List<Film> genreHorreur = new List<Film>();

            List<string> lesGenres = new List<string>();
            List<Acteur> lesActeurs = new List<Acteur>();


            Acteur acteur1 = new Acteur("De Niro", "Robert", "Images/De Niro.png");

            Acteur acteur2 = new Acteur("Di Caprio", "Leonardo", "Images/Di Caprio.png");

            Acteur acteur3 = new Acteur("Nicholson", "Jack", "Images/Nicholson.png");

            Acteur acteur4 = new Acteur("Depp", "Johnny", "Images/Depp.png");

            Acteur acteur5 = new Acteur("Pitt", "Brad", "Images/Pitt.png");

            Acteur acteur6 = new Acteur("Portman", "Natalie", "Images/Portman.png");

            Acteur acteur7 = new Acteur("Lawrence", "Jennifer", "Images/Lawrence.png");

            Acteur acteur8 = new Acteur("Jolie", "Angelina", "Images/Jolie.png");

            Acteur acteur9 = new Acteur("Kidman", "Nicole", "Images/Kidman.png");

            Acteur acteur10 = new Acteur("Stone", "Emma", "Images/Stone.png");

            Realisateur real1 = new Realisateur("Tarantino", "Quentin", "Images/Tarantino.png");

            Realisateur real2 = new Realisateur("Spielberg", "Steven", "Images/Spielberg.png");

            Realisateur real3 = new Realisateur("Scorsese", "Martin", "Images/Scorsese.png");

            Film film1 = new Film("Film n°1", 23000, "Images/Film n°1.png", real1);

            Film film2 = new Film("Film n°2", 56000, "Images/Film n°2.png", real2);

            Film film3 = new Film("Film n°3", 21000, "Images/Film n°3.png", real3);

            genreAventure.Add(film1); genreComedie.Add(film2); genreHorreur.Add(film3);

            film1.AjouterActeur(acteur1); film2.AjouterActeur(acteur2); film3.AjouterActeur(acteur3); film1.AjouterActeur(acteur4); film2.AjouterActeur(acteur5);
            film2.AjouterActeur(acteur7); film3.AjouterActeur(acteur8);
            lesActeurs.Add(acteur1); lesActeurs.Add(acteur2); lesActeurs.Add(acteur3); lesActeurs.Add(acteur4); lesActeurs.Add(acteur5);

            dico.Add("Aventure", genreAventure);
            dico.Add("Horreur", genreHorreur);
            dico.Add("Comedie", genreComedie);

            lesGenres.Add("Aventure");
            lesGenres.Add("Horreur");
            lesGenres.Add("Comedie");

            cboGenreFilm.ItemsSource = lesGenres;

            lstActeurs.ItemsSource = lesActeurs;


        }

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cboGenreFilm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboGenreFilm.SelectedItem != null)
            {
                lstFilms.ItemsSource = dico[cboGenreFilm.SelectedItem as string];
            }
        }

        private void lstFilms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstFilms.SelectedItem != null)
            {
                lstActeurs.ItemsSource = dico[cboGenreFilm.SelectedItem as string].Find(Film=>Film.TitreFilm == (lstFilms.SelectedItem as Film).TitreFilm).LesActeurs;

            }
        }

        private void lstActeurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
