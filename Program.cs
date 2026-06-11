using System;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                var student = new Student()
                {
                    StudentName = "John Smith"
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();

                Console.WriteLine("Student saved successfully!");
                Console.ReadKey();
            }
        }
    }
}
