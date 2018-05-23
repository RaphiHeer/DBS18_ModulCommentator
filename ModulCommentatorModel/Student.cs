﻿using System;
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

        public static List<Student> CreateStudentenListe()
        {
            List<Student> studenten = new List<Student>();

            Student stud1 = new Student();
            stud1.Key = "1";
            stud1.Vorname = "Nicole";
            studenten.Add(stud1);

            Student stud2 = new Student();
            stud2.Key = "2";
            stud2.Vorname = "Luca";
            studenten.Add(stud2);

            Student stud3 = new Student();
            stud3.Key = "3";
            stud3.Vorname = "Ramona";
            studenten.Add(stud3);

            Student stud4 = new Student();
            stud4.Key = "4";
            stud4.Vorname = "Raphi";
            studenten.Add(stud4);

            return studenten;
        }

        public static Student CreateStudentFromKey(string key)
        {
            Student stud = new Student();
            stud.Key = key;
            return stud;
        }
    }
}