using System;
using System.Collections.Generic;

public delegate bool PromotionCriteriaDele(Employee emp);

public class Employee
{
    public int Id;
    public string Name;
    public decimal Salary;
    public int Experience;
    public static void PromoteList(List<Employee> employees, PromotionCriteriaDele criteria)
    {
        Console.WriteLine("Employees eligible for promotion:");
        foreach (var emp in employees)
        {
            if (criteria(emp))
            {
                Console.WriteLine($"{emp.Name} (ID: {emp.Id}, Experience: {emp.Experience})");
            }
        }
    }
}

public class UST
{
    public static bool PromotionCriteria(Employee emp)
    {
        return emp.Experience > 5; 
    }
}

public class Infosys
{
    public static bool PromotionCriteria(Employee emp)
    {
        return emp.Experience > 3; 
    }
}

public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee { Id = 3, Name = "hari", Salary = 30000, Experience = 7 });
        employees.Add(new Employee { Id = 2, Name = "Commerce", Salary = 40000, Experience = 2 });
        employees.Add(new Employee { Id = 5, Name = "Botony", Salary = 38000, Experience = 4 });

        Console.WriteLine("UST Promotion ");
        Employee.PromoteList(employees, UST.PromotionCriteria);

        Console.WriteLine("\nInfosys Promotion ");
        Employee.PromoteList(employees, Infosys.PromotionCriteria);
    }
}
