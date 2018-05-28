using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ModulCommentatorModel;

namespace ModulCommentatorViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        Student currentDozent;
        StudentModel studentModel;

        public StudentViewModel(StudentModel studentModel)
        {
            this.studentModel = studentModel;

            currentDozent = new Student();
            currentDozent.Key = "1234";
            currentDozent.Vorname = "Raphael";
            currentDozent.Nachname = "Heer";
            currentDozent.Mail = "Gott@Welt.jesus";
            currentDozent.Username = "faheer";
        }

        public string Key { get { return currentDozent.Key; } set { currentDozent.Key = value; } }

        public string Vorname { get { return currentDozent.Vorname; } set { currentDozent.Vorname = value; } }

        public string Nachname { get { return currentDozent.Nachname; } set { currentDozent.Nachname = value; } }

        public string Mail { get { return currentDozent.Mail; } set { currentDozent.Mail = value; } }

        public string Kuerzel { get { return currentDozent.Username; } set { currentDozent.Username = value; } }

        public List<Student> StudentenListe { get { return this.studentModel.CreateStudentenListe(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyCahnged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
