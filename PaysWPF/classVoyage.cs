using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1
{
    class Voyage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string details;
        private ushort nbJours;
        private string nom;
        private ushort notation;
        private string pays;
        private double prix;
        private DateTime prochainDate;
        private string urlDrapeau;



        public string Details { get { return details; } set { details = value; NotifyPropertyChanged("Details"); } }
        public ushort NbJours { get { return nbJours; } set { nbJours = value; NotifyPropertyChanged("NbJours"); } }
        public string Nom { get { return nom; } set { nom = value; NotifyPropertyChanged("Nom"); } }
        public ushort Notation { get { return notation; } set { notation = value; NotifyPropertyChanged("Notation"); } }
        public string Pays { get { return pays; } set { pays = value; NotifyPropertyChanged("Pays"); } }
        public double Prix { get { return prix; } set { prix = value; NotifyPropertyChanged("Prix"); } }
        public DateTime ProchainDate { get { return prochainDate; } set { prochainDate = value; NotifyPropertyChanged("NProchainDateom"); } }
        public string UrlDrapeau { get { return urlDrapeau; } set { urlDrapeau = value; NotifyPropertyChanged("UrlDrapeau"); } }


        public void NotifyPropertyChanged(string propertyName)

        {
            try
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
            catch(Exception e)
            {
                throw new Exception("erreur" + e.Message);
            }
        }

        public Voyage(string nom, string pays, string urlDrapeau, ushort nbJours, string details, DateTime prochainDate, double prix, ushort notation)
        {
            if (nom == "" & pays == "" & nbJours <= 0 & prochainDate == null & prix <=0 & notation<=0 & notation>5)
            {
                throw new Exception("Erreur dans la création des pays");
            }
            else
            {
                this.details = details;
                this.nbJours = nbJours;
                this.nom = nom;
                this.notation = notation;
                this.pays = pays;
                this.prix = prix;
                this.prochainDate = prochainDate;
                this.urlDrapeau = urlDrapeau;
            }

        }
    }
}
