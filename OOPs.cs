//----------------------------------Employee CRM

// using System;
// using System.Collections.Generic;

// // ===== ABSTRACTION =====
// abstract class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public abstract void DisplayInfo(); // Abstract method
// }

// // ===== INHERITANCE & ENCAPSULATION =====
// class Employee : Person
// {
//     private double salary; 

//     public int EmployeeId { get; set; }
//     public string Department { get; set; }
//     public double Salary
//     {
//         get { return salary; }
//         set
//         {
//             if (value < 0)
//                 Console.WriteLine("Salary cannot be negative!");
//             else
//                 salary = value;
//         }
//     }

//     // Constructor
//     public Employee(int id, string name, int age, string dept, double sal)
//     {
//         EmployeeId = id;
//         Name = name;
//         Age = age;
//         Department = dept;
//         Salary = sal;
//     }

//     // Polymorphism (method overriding)
//     public override void DisplayInfo()
//     {
//         Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Age: {Age}, Dept: {Department}, Salary: {Salary}");
//     }
// }

// class EmployeeCRM
// {
//     private List<Employee> employees = new List<Employee>();

//     // CREATE
//     public void AddEmployee(Employee emp)
//     {
//         employees.Add(emp);
//         Console.WriteLine("Employee added successfully!");
//     }

//     // READ
//     public void ViewEmployees()
//     {
//         Console.WriteLine("\n--- Employee List ---");
//         foreach (var emp in employees)
//         {
//             emp.DisplayInfo();
//         }
//     }

//     public void UpdateEmployee(int id, string dept, double newSalary)
//     {
//         foreach (var emp in employees)
//         {
//             if (emp.EmployeeId == id)
//             {
//                 emp.Department = dept;
//                 emp.Salary = newSalary;
//                 Console.WriteLine("Employee updated successfully!");
//                 return;
//             }
//         }
//         Console.WriteLine("Employee not found!");
//     }

//     public void DeleteEmployee(int id)
//     {
//         Employee empToRemove = null;
//         foreach (var emp in employees)
//         {
//             if (emp.EmployeeId == id)
//             {
//                 empToRemove = emp;
//                 break;
//             }
//         }
//         if (empToRemove != null)
//         {
//             employees.Remove(empToRemove);
//             Console.WriteLine("Employee deleted successfully!");
//         }
//         else
//         {
//             Console.WriteLine("Employee not found!");
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         EmployeeCRM crm = new EmployeeCRM();

//         crm.AddEmployee(new Employee(1, "Jaanu", 22, "IT", 15000));
//         crm.AddEmployee(new Employee(2, "Radha", 25, "HR", 55000));
//         crm.AddEmployee(new Employee(3, "Krishna", 30, "Finance", 50000));

//         crm.ViewEmployees();

//         crm.UpdateEmployee(2, "Development", 65000);

//         crm.DeleteEmployee(1);

//         crm.ViewEmployees();
//     }
// }

//--------------------------------Bank details
// using System;

// //ABSTRACTION
// abstract class BankAccount
// {
//     public string HolderName { get; set; }   
//     private double balance;                  

//     public BankAccount(string holderName, double initialBalance)
//     {
//         HolderName = holderName;
//         balance = initialBalance;
//     }

//     // Encapsulation
//     public void Deposit(double amount)
//     {
//         balance += amount;
//         Console.WriteLine($"{HolderName} deposited {amount}. New Balance: {balance}");
//     }

//     public void Withdraw(double amount)
//     {
//         if (amount <= balance)
//         {
//             balance -= amount;
//             Console.WriteLine($"{HolderName} withdrew {amount}. Remaining Balance: {balance}");
//         }
//         else
//         {
//             Console.WriteLine("Insufficient Balance!");
//         }
//     }

//     public double GetBalance()
//     {
//         return balance;
//     }

//     // Abstraction
//     public abstract void AccountType();
// }

// // INHERITANCE
// class SavingsAccount : BankAccount
// {
//     public SavingsAccount(string holderName, double initialBalance)
//         : base(holderName, initialBalance) { }

//     //POLYMORPHISM
//     public override void AccountType()
//     {
//         Console.WriteLine($"{HolderName} has a Savings Account.");
//     }
// }

// class CurrentAccount : BankAccount
// {
//     public CurrentAccount(string holderName, double initialBalance)
//         : base(holderName, initialBalance) { }

//     public override void AccountType()
//     {
//         Console.WriteLine($"{HolderName} has a Current Account.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         BankAccount acc1 = new SavingsAccount("Jaanu", 10000);
//         acc1.AccountType();             
//         acc1.Deposit(2000);             
//         acc1.Withdraw(5000);
//         Console.WriteLine($"Final Balance: {acc1.GetBalance()}");
//         Console.WriteLine();

//         // Create Current Account
//         BankAccount acc2 = new CurrentAccount("Radha", 20000);
//         acc2.AccountType();
//         acc2.Deposit(5000);
//         acc2.Withdraw(30000);          
//         Console.WriteLine($"Final Balance: {acc2.GetBalance()}");
//     }
// }