using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ModulCommentatorModel
{
    public class Student : Person
    {
        private string _username;

        public Student()
        {

        }

        public string Username { get { return _username; } set { _username = value; } }
    }
}
