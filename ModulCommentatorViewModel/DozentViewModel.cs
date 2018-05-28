using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ModulCommentatorModel;

namespace ModulCommentatorViewModel
{
    public class DozentViewModel : INotifyPropertyChanged
    {
        DozentModel dozentModel;

        Dozent currentDozent;

        public DozentViewModel(DozentModel model)
        {
            this.dozentModel = model;

            currentDozent = new Dozent();
            currentDozent.Key = "1234";
            currentDozent.Vorname = "Raphael";
            currentDozent.Nachname = "Heer";
            currentDozent.Mail = "Gott@Welt.jesus";
            currentDozent.Kuerzel = "her";
        }

        public string Key { get { return currentDozent.Key; } set { currentDozent.Key = value; } }

        public string Vorname { get { return currentDozent.Vorname; } set { currentDozent.Vorname = value; } }

        public string Nachname { get { return currentDozent.Nachname; } set { currentDozent.Nachname = value; } }

        public string Mail { get { return currentDozent.Mail; } set { currentDozent.Mail = value; } }

        public string Kuerzel { get { return currentDozent.Kuerzel; } set { currentDozent.Kuerzel = value; } }

        public List<Dozent> DozentenListe { get { return dozentModel.CreateDozentenListe(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyCahnged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if(handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
