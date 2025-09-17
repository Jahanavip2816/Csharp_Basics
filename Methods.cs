//----------------------------------Employee Crm

using System;
using System.Collections.Generic;

// ===== ABSTRACTION =====
abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void DisplayInfo(); // Abstract method
}

// ===== INHERITANCE & ENCAPSULATION =====
class Employee : Person
{
    private double salary; 

    public int EmployeeId { get; set; }
    public string Department { get; set; }
    public double Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
                Console.WriteLine("Salary cannot be negative!");
            else
                salary = value;
        }
    }

    // Constructor
    public Employee(int id, string name, int age, string dept, double sal)
    {
        EmployeeId = id;
        Name = name;
        Age = age;
        Department = dept;
        Salary = sal;
    }

    // Polymorphism (method overriding)
    public override void DisplayInfo()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Age: {Age}, Dept: {Department}, Salary: {Salary}");
    }
}

class EmployeeCRM
{
    private List<Employee> employees = new List<Employee>();

    // CREATE
    public void AddEmployee(Employee emp)
    {
        employees.Add(emp);
        Console.WriteLine("Employee added successfully!");
    }

    // READ
    public void ViewEmployees()
    {
        Console.WriteLine("\n--- Employee List ---");
        foreach (var emp in employees)
        {
            emp.DisplayInfo();
        }
    }

    public void UpdateEmployee(int id, string dept, double newSalary)
    {
        foreach (var emp in employees)
        {
            if (emp.EmployeeId == id)
            {
                emp.Department = dept;
                emp.Salary = newSalary;
                Console.WriteLine("Employee updated successfully!");
                return;
            }
        }
        Console.WriteLine("Employee not found!");
    }

    public void DeleteEmployee(int id)
    {
        Employee empToRemove = null;
        foreach (var emp in employees)
        {
            if (emp.EmployeeId == id)
            {
                empToRemove = emp;
                break;
            }
        }
        if (empToRemove != null)
        {
            employees.Remove(empToRemove);
            Console.WriteLine("Employee deleted successfully!");
        }
        else
        {
            Console.WriteLine("Employee not found!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeCRM crm = new EmployeeCRM();

        crm.AddEmployee(new Employee(1, "Jaanu", 22, "IT", 15000));
        crm.AddEmployee(new Employee(2, "Radha", 25, "HR", 55000));
        crm.AddEmployee(new Employee(3, "Krishna", 30, "Finance", 50000));

        crm.ViewEmployees();

        crm.UpdateEmployee(2, "Development", 65000);

        crm.DeleteEmployee(1);

        crm.ViewEmployees();
    }
}

//-------------------------------------------BankAccount

// using System;

// class Method
// {
//     public static double CalculateStats(out int min, out int max,params int[] nums)
//     {
//         if (nums == null || nums.Length == 0)
//         {
//             min = 0;
//             max = 0;
//             return 0;
//         }

//         min = nums[0];
//         max = nums[0];
//         int sum = 0;

//         foreach (int n in nums)
//         {
//             if (n < min)
//                 min = n;
//             if (n > max)
//                 max = n;

//             sum += n;
//         }

//         return (double)sum / nums.Length;
//     }

//     static void Main()
//     {
//         int min, max;
//         double avg = CalculateStats( out min, out max, 23,5,78,90,54);

//         Console.WriteLine($"Min: {min}");
//         Console.WriteLine($"Max: {max}");
//         Console.WriteLine($"Average: {avg}");
//     }
// }

