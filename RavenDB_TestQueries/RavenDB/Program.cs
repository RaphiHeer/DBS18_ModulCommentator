using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DB_Operation operation = new DB_Operation();

            Student student1 = new Student("Student|", "stu1", "stu1@stud.hslu.ch", "Test", "Student1");
            Student student2 = new Student("Student|", "stu2", "stu2@stud.hslu.ch", "Test", "Student2");

            operation.addStudent(student1);
            operation.addStudent(student2);

            Dozenten dozent1 = new Dozenten("Dozent|", "doz1", "doz1@stud.hslu.ch", "Test", "Dozent1");
            Dozenten dozent2 = new Dozenten("Dozent|", "doz2", "doz2@stud.hslu.ch", "Test", "Dozent2");

            operation.addDozent(dozent1);
            operation.addDozent(dozent2);

            Modul modul1 = new Modul("Modul|", "TestModul1", "TM1", operation.getDozent("Dozent/19").Id);
            Modul modul2 = new Modul("Modul|", "TestModul2", "TM2", operation.getDozent("Dozent/20").Id);

            operation.addModul(modul1);
            operation.addModul(modul2);
            
            List<string> dozenten = new List<string>();
            dozenten.Add(operation.getDozent("Dozent/19").Id);
            dozenten.Add(operation.getDozent("Dozent/20").Id);

            Kommentar comment = new Kommentar("Kommentar|", "Test1", operation.getStudent("Student/19").Id, operation.getModul("Modul/19").Id, dozenten);            

            operation.addComment(comment);

            operation
        }
    }
}
