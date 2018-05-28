using System;
using System.Collections.Generic;
using System.Text;

namespace ModulCommentatorModel
{
    public class SpecialQueryModel
    {
        object operations;

        public SpecialQueryModel(object operations)
        {

        }

        public List<Dozent> GetAllDozents()
        {
            List<Dozent> dozenten = new List<Dozent>();

            Dozent doz1 = new Dozent();
            doz1.Key = "1";
            doz1.Vorname = "Raphi";
            dozenten.Add(doz1);

            Dozent doz2 = new Dozent();
            doz2.Key = "2";
            doz2.Vorname = "Ueli";
            dozenten.Add(doz2);

            return dozenten;
        }

        public List<Dozent> GetDozentCountQuery(Dozent selectedDozent)
        {

        }
    }
}
