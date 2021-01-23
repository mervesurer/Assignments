using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Class();
            List<Student> studs = list.GetAllStudents();

            list.Add(new Student { StudentNumber = 1, Name = "Merve", LastName = "Sürer", Age = 22, Score = 78});
            list.Add(new Student { StudentNumber = 2, Name = "Melis", LastName = "Sürer", Age = 21, Score = 92 });
            list.Add(new Student { StudentNumber = 3, Name = "Hediye", LastName = "Sürer", Age = 48, Score = 100 });
            list.Add(new Student { StudentNumber = 4, Name = "Suat", LastName = "Sürer", Age = 54, Score = 78 });
            list.Add(new Student { StudentNumber = 5, Name = "Merve Fatma", LastName = "Sürer", Age = 22, Score = 86 });

            foreach (var item in studs)
            {
                Console.WriteLine(item.Name + " " + item.LastName);
            }

            Console.WriteLine();

            list.Add(new Student { StudentNumber = 1, Name = "Merve", LastName = "Sürer" });

            foreach (var item in studs)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Öğrenci numarasına göre öğrenci: ");
            var student = list.GetStudentByStudentNumber(3);
            Console.WriteLine($"{student.StudentNumber} numaralı {student.Name} {student.LastName} isimli öğrenci sınıfta mevcut.");

            Console.WriteLine();

            Console.WriteLine("Öğrenci ismine göre öğrenciler: ");
            var findNames = list.GetStudentsByName("Merve");
            findNames.ForEach(st => Console.WriteLine($"{st.Name} {st.LastName} isimli öğrenci sınıfta mevcut."));

            Console.WriteLine();

            Console.WriteLine("Öğrenci yaşına göre öğrenciler: ");
            var findNamesByAge = list.GetStudentsByAge(22);
            findNamesByAge.ForEach(st => Console.WriteLine($"{st.Age} yaşında {st.Name} {st.LastName} isimli öğrenci sınıfta mevcut."));

            Console.WriteLine();

            Console.WriteLine("Öğrencinin aldığı puanlara göre öğrenciler: ");
            var findNamesByScore = list.GetStudentsByScore(78);
            findNamesByScore.ForEach(st => Console.WriteLine($"{st.Score} puanı almış {st.Name} {st.LastName} isimli öğrenci sınıfta mevcut."));

            Console.WriteLine();
            list.Remove(3);

            foreach (var item in studs)
            {
                Console.WriteLine(item.Name + " " + item.LastName);
            }

            Console.ReadLine();
        }
    }
}
