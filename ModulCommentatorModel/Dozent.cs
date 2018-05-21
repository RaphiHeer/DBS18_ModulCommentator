using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ModulCommentatorModel
{
    public class Dozent : Person
    {

        private string _kuerzel;

        public Dozent()
        {

        }

        public string Kuerzel { get { return _kuerzel; } set { _kuerzel = value; } }

        public static List<Dozent> CreateDozentenListe()
        {
            List<Dozent> dozenten = new List<Dozent>();

            Dozent doz1 = new Dozent();
            doz1.Key = "1";
            dozenten.Add(doz1);

            Dozent doz2 = new Dozent();
            doz2.Key = "2";
            dozenten.Add(doz2);

            return dozenten;
        }

        public static Dozent CreateDozentFromKey(string key)
        {
            Dozent doz = new Dozent();
            return doz;
        }

    }
}
