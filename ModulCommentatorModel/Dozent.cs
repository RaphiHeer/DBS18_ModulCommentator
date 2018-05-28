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


    }
}
