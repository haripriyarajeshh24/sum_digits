using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace ProgramCollections
{

    public class CollectionArraylist
    {
        //public static void Main()
        //{
        //    var person = new ArrayList();
        //    person.Add("Billu");
        //    person.Add(23);
        //    person.Add("Male");
        //    person.Add(true);
        //    person.Add(170);
        //    person.Add(70);

        //    Console.WriteLine("Employee Details : ");

        //    foreach (var item in person) { Console.WriteLine(item); }

        //    person.RemoveAt(4);

        //    Console.WriteLine("After height removal : ");
        //    foreach (var item in person) { Console.WriteLine(item); }

        //    bool containslocation = person.Contains("location");
        //    if (containslocation) { Console.WriteLine("Yesss"); }
        //    else { Console.WriteLine("Nooo"); }
        //}
    }

    //public class Students
    //{
    //    public int rollno;
    //    public string name;
    //    public double cgpa;

    //    public Students(int rollno, string name, double cgpa)
    //    {
    //        this.rollno = rollno;
    //        this.name = name;
    //        this.cgpa = cgpa;
    //    }
    //    public static void AddStudent(Students student)
    //    {
    //        int id = student.rollno;
    //    }
    //    public static void Main()
    //    {
    //        Students student1 = new Students(1, "hari", 8.9);
    //        Students student2 = new Students(2, "priya", 8);
    //        Students student3 = new Students(3, "riya", 9);
    //        AddStudent(student1);  
    //        Hashtable studentTable = new Hashtable();

    //        studentTable.Add(student1.rollno, student1);
    //        studentTable.Add(student2.rollno, student2);
    //        studentTable.Add(student3.rollno, student3);

    //        foreach (DictionaryEntry entry in studentTable)
    //        {
    //            Students student = (Students)entry.Value;
    //            Console.WriteLine($"Roll No: {entry.Key}, Student: {student.name}");
    //        }
    //        Console.WriteLine("Provide the roll no of student : ");
    //        int keyToSearch = int.Parse(Console.ReadLine());
    //        if (studentTable.Contains(keyToSearch))
    //        {
    //            Students student = (Students)studentTable[keyToSearch];
    //            Console.WriteLine($"Roll No: {student.rollno}, Name: {student.name}, CGPA: {student.cgpa}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Student not found.");
    //        }

    //    }
    //}

    public class Students
    {
        public int rollno;
        public string name;
        public double cgpa;

        public Students(int rollno, string name, double cgpa)
        {
            this.rollno = rollno;
            this.name = name;
            this.cgpa = cgpa;
        }
        public static void AddStudent(Students student)
        {
            Dictionary<int, Students> studentdict = new Dictionary<int, Students>();
            studentdict.Add(student.rollno, student);
            for (int x = 0; x < studentdict.Count; x++)
            {
                int key = studentdict.Keys.ElementAt(x);
                Students currentStudent = studentdict[key];
                Console.WriteLine("{0} and {1}", key, currentStudent.name); 
            }
        }
        public static void Main()
        {
            Students student1 = new Students(1, "hari", 8.9);
            Students student2 = new Students(2, "priya", 8);
            Students student3 = new Students(3, "riya", 9);
            AddStudent(student1);
            AddStudent(student2);
            AddStudent(student3);


        }
    }
}