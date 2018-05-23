using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RavenDB
{
    class DB_Operation
    {
        IDocumentStore store;

        public DB_Operation()
        {
            store = DocumentStoreHolder.Store;
        }

        public void addStudent(Student student)
        {
            addStudent(student.Id, student.username, student.email, student.nachname, student.vorname);
        }

        public void addStudent(string id, string username, string email, string nachname, string vorname)
        {
            using (IDocumentSession session = store.OpenSession())
            {
                Student newStudent = new Student(id, username, email, nachname, vorname);
                session.Store(newStudent);
                session.SaveChanges();
            }
        }


        //Beispiel von Präsentator um student zu holen
        public Student GetStuden(string vorname)
        {
            using (IDocumentSession session = store.OpenSession())
            {
                var student = session.Query<Student>().Where<Student>(x => x.nachname == vorname).First();
                return student;
            }
        }

        public void addDozent(Dozenten dozent)
        {
            addDozent(dozent.Id, dozent.vorname, dozent.nachname, dozent.kuerzel, dozent.email);
        }

        public void addDozent(string id, string kuerzel, string email, string nachname, string vorname)
        {
            using (IDocumentSession session = store.OpenSession())
            {
                Dozenten newDozent = new Dozenten(id, kuerzel, email, nachname, vorname);
                session.Store(newDozent);
                session.SaveChanges();
            }
        }

        public void addModul(Modul modul)
        {
            addModul(modul.Id, modul.bezeichnung, modul.kuerzel, modul.verantwortlicher);
        }

        public void addModul(string id, string bezeichnung, string kuerzel, string verantwortlicher)
        {
            using (IDocumentSession session = store.OpenSession())
            {
                Modul newModul = new Modul(id, bezeichnung, kuerzel, verantwortlicher);
                session.Store(newModul);
                session.SaveChanges();
            }
        }

        public void addComment(Kommentar comment)
        {
            addComment(comment.Id, comment.text, comment.geschrieben_von, comment.modul, comment.Dozenten);
        }

        public void addComment(string id, string text, string geschrieben_von, string modul, List<string> dozenten)
        {
            using (IDocumentSession session = store.OpenSession())
            {
                Kommentar newComment = new Kommentar(id, text, geschrieben_von, modul, dozenten);
                session.Store(newComment);
                session.SaveChanges();
            }
        }

        public Dozenten getDozent(string id)
        {
            Dozenten dozent = null;

            using (IDocumentSession session = store.OpenSession())
            {
                dozent = session.Load<Dozenten>(id);
            }

            return dozent;
        }

        public Student getStudent(string id)
        {
            Student student = null;

            using (IDocumentSession session = store.OpenSession())
            {
                student = session.Load<Student>(id);
            }

            return student;
        }

        public Modul getModul(string id)
        {
            Modul modul = null;

            using (IDocumentSession session = store.OpenSession())
            {
                modul = session.Load<Modul>(id);
            }

            return modul;
        }
    }

    
}
