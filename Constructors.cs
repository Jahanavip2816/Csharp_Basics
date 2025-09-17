// //------------------- Static Constructor

// using System;
// public class Jaanu
// {
//     private static int x = 100;
//     private static int y = 200;
//     static Jaanu()
//     {
//         Console.WriteLine($"Before swap a is: {x} and b is {y}");
//         x = x + y;
//         y = x - y;
//         x = x - y;
//     }

//         public static void Print() {


//         Console.WriteLine($"After swap a is: {x} and b is {y}");
//     }
//     }
// class Program {
//     public static void Main(string[] args)
//     {
//         Jaanu.Print();

//     }
// }

// //---------------Default Constructor

// using System;
// namespace ConstructorDemo
// {
//     class Employee
//     {
//         public int Id, Age;
//         public string Address, Name;
//         public bool IsPermanent;
//     }
//     class Test
//     {
//         static void Main(string[] args)
//         {
//             Employee e1 = new Employee();
//             Console.WriteLine("Employee Id is:  " + e1.Id);
//             Console.WriteLine("Employee Name is:  " + e1.Name);
//             Console.WriteLine("Employee Age is:  " + e1.Age);
//             Console.WriteLine("Employee Address is:  " + e1.Address);
//             Console.WriteLine("Is Employee Permanent:  " + e1.IsPermanent);
//         }
//     }
// }

// //---------------Private Constructor

// // using System;
// // class Program
// // {
// //     private Program()
// //     {
// //         Console.Write("Hi");
// //     }
// //     public static void Main(string[] args)
// //     {
// //         Program p = new Program();
// //         Console.Write(" everyone");
// //     }
// // }

// //------------------Parameterized Constructor

// // using System;
// // class Student
// // {
// //     public string Name;
// //     public int Age;

// //     public Student(string name, int age) // Parameters
// //     {
// //         Name = name;
// //         Age = 22;

// //     }
// //     public void Show()
// //     {
// //         Console.WriteLine($"My name is {Name} and My age is {Age} ");
// //     }
// //     public static void Main(string[] args)
// //     {
// //         Student obj = new Student("Jaanu", 20);
// //         Student obj1 = new Student("Jahanavi", 20);
// //         obj.Show();
// //         //obj1.Show();
// //     }
// // }

// //-----------------------Copy Constructor

// using System;
// class Student
// {
//     public string Name;
//     public int Age;

//     public Student(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
//     public Student(Student s) //Copy Constructor
//     {
//         Name = s.Name;
//         Age = s.Age;
//     }
//     public void show()
//     {
//         Console.WriteLine($"My name is {Name} and Age is {Age}");
//     }
//     public static void Main(string[] args)
//     {
//         Student s1 = new Student("Jaanu", 22);
//         s1.show();

//         Student s2 = new Student(s1);
//         s2.show(); // copy
//     }
// }


// //---------- Console Methods

// // using System;

// // class Program
// // {
// //     static void Main()
// //     {
// //         Console.Title = "My Console App";
// //         Console.ForegroundColor = ConsoleColor.White;
// //         Console.BackgroundColor = ConsoleColor.Black;
// //         Console.Clear();

// //         Console.WriteLine("Console Title: " + Console.Title);
// //         Console.WriteLine("Buffer Width: " + Console.BufferWidth);
// //         Console.WriteLine("Window Width: " + Console.WindowWidth);
// //         Console.WriteLine("Is Cursor Visible: " + Console.CursorVisible);
// //     }
// // }


