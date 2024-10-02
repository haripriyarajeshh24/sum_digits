using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Operators
{
    class Filteringinc
    {
        class CourseClass
        {
            public string Name { get; set; }
            public int Duration { get; set; }
            public int Fees { get; set; }
            public string Start_date { get; set; }
        }

        static void Main(string[] args)
        {

            List<CourseClass> courses = new List<CourseClass>();
            courses.Add(new CourseClass {Name = "CS", Duration = 3, Fees = 30000, Start_date = "21/09/2025"});
            courses.Add(new CourseClass { Name = "Commerce", Duration = 2, Fees = 40000, Start_date = "21/09/2025" });
            courses.Add(new CourseClass { Name = "Botony", Duration = 5, Fees = 38000, Start_date = "21/09/2025" });

            var list = (from course in courses where course.Duration < 3 select course);
            foreach (var course in list)
            {
                Console.WriteLine("Course with less than 3 months duration = {0} ", course.Name);
            }
            var sortedlist = from course in courses
                             orderby course.Name
                             select course;

            Console.WriteLine("---- Sorted values ------");

            foreach (CourseClass sort in sortedlist)
                Console.WriteLine(sort.Name + " \n");

            var sum = courses.Sum(course => course.Fees);

            Console.WriteLine("Overall fees of all courses : {0}", sum);

            var filteredGrouped = courses
                .Where(course => course.Duration < 3)
                .GroupBy(course => course.Name)
                .ToList();

            Console.WriteLine("Courses less than 3 months: ");
            foreach (var group in filteredGrouped)
            {
               
                foreach (var course in group)
                {
                    Console.WriteLine($" - {course.Name}");
                }
            }
            var filteredmonthGrouped = courses
            .Where(course => course.Duration < 6)
            .GroupBy(course => course.Name)
            .ToList();

            Console.WriteLine("Courses less than 6 months: ");
            foreach (var group in filteredmonthGrouped)
            {
                foreach (var course in group)
                {
                    Console.WriteLine($" - {course.Name}");
                }
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}