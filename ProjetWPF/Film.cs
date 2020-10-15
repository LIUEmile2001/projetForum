using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class Film
    {
        private string titreFilm;
        private int nbEntrees;
        private string photoFilm;

        private List<Acteur> lesActeurs;

        private Realisateur leRealisateur;


        public Film(string unTitre,int uneEntree,string unePhoto,Realisateur unRealisateur)
        {
            TitreFilm = unTitre;
            NbEntrees = uneEntree;
            PhotoFilm = unePhoto;
            LeRealisateur = unRealisateur;
            LesActeurs = new List<Acteur>();
        }

        public string TitreFilm { get => titreFilm; set => titreFilm = value; }
        public int NbEntrees { get => nbEntrees; set => nbEntrees = value; }
        public string PhotoFilm { get => photoFilm; set => photoFilm = value; }
        public List<Acteur> LesActeurs { get => lesActeurs; set => lesActeurs = value; }
        public Realisateur LeRealisateur { get => leRealisateur; set => leRealisateur = value; }

        public void AjouterActeur(Acteur unActeur)
        {
            lesActeurs.Add(unActeur);
        }
    }
}
