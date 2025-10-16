using System;
using System.Collections.Generic;
using System.Linq;
using Spectre.Console;


namespace Lab5v2
{
    class Program
    {
        static void Main()
        {
            try
            {
                var enrollmentRepo = new Repository<Enrollment>();

                var course1 = new Course("Програмування на C#", "CS101");
                var course2 = new Course("Бази даних", "DB202");

                var student1 = new Student("Іван Іванов", "ivan@example.com");
                var student2 = new Student("Марія Петренко", "maria@example.com");
                var student3 = new Student("Олег Сидоренко", "oleg@example.com");

                enrollmentRepo.Add(new Enrollment(course1, student1, 85));
                enrollmentRepo.Add(new Enrollment(course1, student2, 72));
                enrollmentRepo.Add(new Enrollment(course1, student3, 55));
                enrollmentRepo.Add(new Enrollment(course2, student1, 95));

                // Викличе виняток — дубльований студент
                enrollmentRepo.Add(new Enrollment(course1, student1, 90));
            }
            catch (DuplicateEnrollmentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.WriteLine("\n=== Статистика по курсу ===");
            var repo = new Repository<Enrollment>();

            var csharp = new Course("Програмування на C#", "CS101");
            repo.Add(new Enrollment(csharp, new Student("Іван Іванов", "ivan@example.com"), 85));
            repo.Add(new Enrollment(csharp, new Student("Марія Петренко", "maria@example.com"), 72));
            repo.Add(new Enrollment(csharp, new Student("Олег Сидоренко", "oleg@example.com"), 55));

            var allEnrollments = repo.Where(e => e.Course.Code == "CS101");

            double avg = allEnrollments.Average(e => e.Grade);
            double passRate = allEnrollments.Count(e => e.Grade >= 60) * 100.0 / allEnrollments.Count();

            // === Виводимо красиву таблицю ===
            AnsiConsole.MarkupLine($"[bold yellow]Курс:[/] {csharp.Name}");
            AnsiConsole.MarkupLine($"[green]Середній бал:[/] {avg:F2}");
            AnsiConsole.MarkupLine($"[cyan]Відсоток зданих:[/] {passRate:F1}%\n");

            var table = new Table();
            table.Border = TableBorder.Rounded;
            table.AddColumn("[u]Слухач[/]");
            table.AddColumn("[u]Email[/]");
            table.AddColumn("[u]Оцінка[/]");

            foreach (var e in allEnrollments)
            {
                var gradeColor = e.Grade >= 60 ? "green" : "red";
                table.AddRow(e.Student.Name, e.Student.Email, $"[{gradeColor}]{e.Grade}[/]");
            }

            AnsiConsole.Write(table);
      

        }
    }
}
