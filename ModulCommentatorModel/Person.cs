using System;
using System.Collections.Generic;
using System.Text;

namespace ModulCommentatorModel
{
    public class Person
    {
        private string _key;
        private string _vorname;
        private string _nachname;
        private string _mail;

        public Person()
        {

        }

        public string Key { get { return _key; } set { _key = value; } }

        public string Vorname { get { return _vorname; } set { _vorname = value; } }

        public string Nachname { get { return _nachname; } set { _nachname = value; } }

        public string Mail { get { return _mail; } set { _mail = value; } }
    }
}
