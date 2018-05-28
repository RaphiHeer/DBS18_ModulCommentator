using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ModulCommentatorModel;
using RavenDB;

namespace ModulCommentatorViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        Student currentStudent;
        StudentModel studentModel;

        public StudentViewModel(StudentModel studentModel)
        {
            this.studentModel = studentModel;

            this.currentStudent = new Student("-", "faheer", "Gott@Welt.jesus", "Heer","Raphael");
        }

        public string Key { get { return currentStudent.Id; } set { currentStudent.Id = value; } }

        public string Vorname { get { return currentStudent.vorname; } set { currentStudent.vorname = value; } }

        public string Nachname { get { return currentStudent.nachname; } set { currentStudent.nachname = value; } }

        public string Mail { get { return currentStudent.email; } set { currentStudent.email = value; } }

        public string Kuerzel { get { return currentStudent.username; } set { currentStudent.username = value; } }

        public List<Student> StudentenListe { get { return this.studentModel.GetStudentenListe(); } }

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
