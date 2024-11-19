using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    struct Student
    {
        public string FullName;
        public int GroupNumber;
        public int Exam1;
        public int Exam2;
        public int Exam3;

        public bool HasPassed()
        {
            return Exam1 >= 3 && Exam2 >= 3 && Exam3 >= 3;
        }

        public override string ToString()
        {
            return $"{FullName}, Группа: {GroupNumber}, Экзамены: {Exam1}, {Exam2}, {Exam3}";
        }
    }

    static void Main(string[] args)
    {
        string inputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\input15_2.txt";
        string outputFilePath = "C:\\Users\\veron\\source\\repos\\task9\\output15_2.txt";

        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            List<Student> students = new List<Student>();

            using (StreamReader reader = new StreamReader(inputFilePath, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');

                    Student student = new Student
                    {
                        FullName = parts[0].Trim(),
                        GroupNumber = int.Parse(parts[1].Trim()),
                        Exam1 = int.Parse(parts[2].Trim()),
                        Exam2 = int.Parse(parts[3].Trim()),
                        Exam3 = int.Parse(parts[4].Trim())
                    };

                    students.Add(student);
                }
            }

            var passedStudents = students.Where(s => s.HasPassed())
                                         .OrderBy(s => s.GroupNumber)
                                         .ToList();

            using (StreamWriter writer = new StreamWriter(outputFilePath, false, Encoding.Default))
            {
                foreach (var student in passedStudents)
                {
                    writer.WriteLine(student.ToString());
                }
            }

            Console.WriteLine("Результаты успешно записаны в файл: " + outputFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}
