using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Class
    {
        private List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            foreach(var st in students)
            {
                if(st.StudentNumber == student.StudentNumber)
                {
                    Console.WriteLine("Bu öğrenci numarasına sahip bir öğrenci mevcut! Öğrenci numarasını değiştiriniz!");
                    int number = Convert.ToInt32(Console.ReadLine());
                    student.StudentNumber = number;
                }
            }
            
            foreach(var st in students)
            {
                if(st.Name.ToLower().Equals(student.Name.ToLower()) && st.LastName.ToLower().Equals(student.LastName.ToLower()))
                {
                    Console.WriteLine("Aynı ad soyadı taşıyan öğrenci mevcut. Eklemek istediğinize emin misiniz?(Evet/Hayır)");
                    string cevap = Console.ReadLine();
                    if(cevap.ToLower().Equals("hayır"))
                    {
                        return;
                    }
                    Console.WriteLine("Öğrenci Başarıyla eklenmiştir!");
                }
            }

            students.Add(student);
        }

        public void Remove(Student student)
        {
            students.Remove(student);
        }

        public void Remove(int Number)
        {
            var student = students.FirstOrDefault(st => st.StudentNumber == Number);

            students.Remove(student);
        }

        public Student GetStudentByStudentNumber(int Number)
        {
            return students.FirstOrDefault(st => st.StudentNumber == Number);
        }

        public List<Student> GetStudentsByName(string Name)
        {
            return students.Where(st => st.Name.Contains(Name)).ToList();
        }

        public List<Student> GetStudentsByAge(int Age)
        {
            return students.Where(st => st.Age == Age).ToList();
        }

        public List<Student> GetStudentsByScore(int Score)
        {
            return students.Where(st => st.Score == Score).ToList();
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
