// using System;
// using System.Globalization;

// namespace Program
// {
//     Demonstration of Encapsulation
//     public class Employee
//     {
//         public int empExp;

//         static void Main(string[] args)
//         {
//             Employee objEmp = new Employee();
//             objEmp.empExp = 3;

//             Console.WriteLine("Experience" + objEmp.empExp);

//         }

//     public class Employee
//     {
//         private int empExp;

//         public int EmpExp
//         {
//             get { return empExp; }

//             set { empExp = value; }
//         }
//             static public void Main()
//             {
//                 Employee objEmp = new Employee();
//                 objEmp.EmpExp = 3;

//                 // Displaying value
//                 Console.WriteLine(" Experience: " + objEmp.EmpExp);
//             }
//         }

//         class Car
//     {
//         public string Brand;
//         public string Color;

//         // Constructor (same name as class)
//         public Car(string brand, string color)
//         {
//             Brand = brand;
//             Color = color;
//         }

//         public void Drive()
//         {
//             Console.WriteLine(Brand + " is driving...");
//         }
//     }

//     class Program
//     {
//         static void Main()
//         {
//             // Object created with values directly
//             Car car1 = new Car("BMW", "Red");
//             Car car2 = new Car("Audi", "Black");

//             car1.Drive();   // BMW is driving...
//             car2.Drive();   // Audi is driving...
//         }




//     public class Program
//     {
//         public void Calc(double c) {

//             // int age = 24;
//     System.Console.WriteLine("my age is " + age);
//     System.Console.WriteLine("Hello, World!");
//     System.Console.WriteLine(23 + 25);

//     int myInt = 10;
//     double myDouble = 5.25;
//     bool myBool = true;
//     string myString = "jaanu";

//     Console.WriteLine(Convert.ToString(myInt));    
//     Console.WriteLine(Convert.ToDouble(myInt));    
//     Console.WriteLine(Convert.ToInt32(myDouble));  
//     Console.WriteLine(Convert.ToString(myBool));   
//     Console.WriteLine(myString);  

//     int i = 345;
//     float a = i;
//     Console.WriteLine(a);

//     float f1 = 4567.3334F;
//     int i1 = Convert.ToInt32(f1);

//     Console.WriteLine(i1);

//     string strNumber = "123";
//     int number = int.Parse(strNumber); // Succeeded, number is 123
//     Console.WriteLine(number);

//     string strInvalid = "abc";
//     int invalidNumber = int.Parse(strInvalid); // Throws a FormatException

//     Console.WriteLine(invalidNumber);

//     string a = "abcd12";
//     int n;
//     bool s = int.TryParse(a, out n);
//     Console.WriteLine(s);

//     Console.WriteLine("Enter your name:");
//     string name = Console.ReadLine();
//     Console.WriteLine("Your name is:" + name);

//     Console.WriteLine("Enter your age:");
//     int age =Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Your age is:" +age);

//     int a = 10;
//     int b = 20;

//     Console.WriteLine("Result of " + a + " and " + b + " is " + (a + b));

//     ---------------------------------MATH METHODS 

//     Console.WriteLine(Math.Max(10, 3));
//     Console.WriteLine(Math.Min(10, 3));
//     Console.WriteLine(Math.Sqrt(4));
//     Console.WriteLine(Math.Abs(-3.45));
//     Console.WriteLine(Math.Round(5.5));
//     Console.WriteLine(Math.Min(10, -10));
//     Console.WriteLine("Sin(PI/2) = " + Math.Sin(Math.PI / 2));
//     Console.WriteLine("Cos(0) = " + Math.Cos(0));
//     Console.WriteLine("Tan(PI/4) = " + Math.Tan(Math.PI / 4));
//     Console.WriteLine("Atan(1) = " + Math.Atan(1));
//     Console.WriteLine("Atan2(1,1) = " + Math.Atan2(1, 1));
//     Console.WriteLine(Math.PI);
//     Console.WriteLine(Math.E);
//     Console.WriteLine(Math.Ceiling(5.5));
//     Console.WriteLine(Math.Floor(5.5));
//     Console.WriteLine(Math.Truncate(5.5));
//     Console.WriteLine(Math.Pow(5, 5));
//     Console.WriteLine(Math.Cbrt(27));
//     Console.WriteLine(Math.Exp(5));
//     Console.WriteLine(Math.Log(5));// Returns base e
//     Console.WriteLine(Math.Log10(5));// Returns base 10


//     Console.WriteLine("Enter a number");
//     int a = Convert.ToInt32(Console.ReadLine());
//     if (a >= 18)
//     {
//         Console.WriteLine("a can have lisence");
//     }
//     else
//     {
//         Console.WriteLine("They are minor");
//     }

//     Conditional Statements //

//     Console.WriteLine("Enter a number");
//     int a = Convert.ToInt32(Console.ReadLine());
//     if (a < 0)
//     {
//         Console.WriteLine("a is negative");
//     }
//     if (a > 0)
//     {
//         Console.WriteLine(" a is positive");
//     }
//     else
//     {
//         Console.WriteLine("a is zero");
//     }

//     -----------------------------------------------Loops

//     for (int i = 1; i <= 10; i++)
//     {
//         if (i == 7)
//         {
//             continue;
//         }
//         if (i % 2 != 0)
//         {
//             Console.WriteLine(i);
//         }
//     }

//     int i = 1;
//     while (i <= 10)
//     {
//         if (i % 2 != 0)
//         {
//             Console.WriteLine(i);
//         }
//         i++;
//     }

//     int a = 1;
//     while (a <= 10)
//     {
//         Console.WriteLine(a);
//         a += 2;
//     }

//     int b = 1;
//     do
//     {
//         Console.WriteLine(b);
//         if (b == 7)
//         {
//             break;
//         }
//         b += 2;
//     }
//     while (b <= 10);

//         double f = ((9 * c) / 5) + 32;
//         Console.WriteLine("Fahrenheit value is " + f);
//     }
//     static void Main(string[] args)
//     {
//         double c;
//         Console.WriteLine("Enter Centigrade value ");
//         c = Convert.ToDouble(Console.ReadLine());
//         Program obj = new Program();
//         obj.Calc(c);



//     }

//             }

//         }

//     ---------------------------------Control Statements

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter your name: ");
//             string name = Console.ReadLine();

//             Console.Write("Enter your age: ");
//             int age = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine($"Hello {name}! You are {age} years old.");
//             Console.WriteLine("This is a .NET Console Application running on the CLR.");
//             Console.WriteLine("The CLR (Common Language Runtime) is the execution engine for .NET applications. " +
//                               "It provides services like memory management, type safety, and garbage collection.\n");

//             Console.WriteLine("Data Type Demonstration ");

//             int myInt = 100;
//             float myFloat = 3.14f;
//             double myDouble = 12345.6789;
//             char myChar = 'A';
//             string myString = "C# Demo";
//             int[] myArray = { 1, 2, 3, 4, 5 };

//             Console.WriteLine($"int: Value={myInt}, Size={sizeof(int)} bytes, Range=({int.MinValue} to {int.MaxValue})");
//             Console.WriteLine($"float: Value={myFloat}, Size={sizeof(float)} bytes, Range=({float.MinValue} to {float.MaxValue})");
//             Console.WriteLine($"double: Value={myDouble}, Size={sizeof(double)} bytes, Range=({double.MinValue} to {double.MaxValue})");
//             Console.WriteLine($"char: Value={myChar}, Size={sizeof(char)} bytes, Range=({char.MinValue} to {char.MaxValue})");
//             Console.WriteLine($"string: Value=\"{myString}\", Reference Type, Length={myString.Length}");
//             Console.WriteLine($"array: Values=[{string.Join(", ", myArray)}], Reference Type, Length={myArray.Length}\n");

//             Console.WriteLine("=== Control Flow Implementation ===");
//             Console.Write("Enter a number between 1 and 5: ");
//             int number = Convert.ToInt32(Console.ReadLine());

//             if (number < 1 || number > 5)
//             {
//                 Console.WriteLine("Invalid number! Please enter a number between 1 and 5.");
//             }
//             else
//             {
//                 switch (number)
//                 {
//                     case 1:
//                         Console.WriteLine("You entered One.");
//                         break;
//                     case 2:
//                         Console.WriteLine("You entered Two.");
//                         break;
//                     case 3:
//                         Console.WriteLine("You entered Three.");
//                         break;
//                     case 4:
//                         Console.WriteLine("You entered Four.");
//                         break;
//                     case 5:
//                         Console.WriteLine("You entered Five.");
//                         break;
//                 }

//                 Console.WriteLine("Counting from 1 to your number:");
//                 for (int i = 1; i <= number; i++)
//                 {
//                     Console.WriteLine(i);
//                 }
//             }
//         }
//     }
// }


//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] theNumbers = new int[4];

//             theNumbers[0] = 1;
//             theNumbers[1] = 2;
//             theNumbers[2] = 3;
//             theNumbers[3] = 4;

//             Console.WriteLine(theNumbers[1]);


//         }
//     }


//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             String name = "\"jaanu\"";

//             Console.WriteLine(name);
//         }
//     }

//         public class Program{
//         static void Main()
//         {
//             Console.WriteLine("Hello\nWorld");   // Newline
//             Console.WriteLine("Hello\tWorld");   // Tab
//             Console.WriteLine("She said, \"Hi!\""); // Double quotes
//             Console.WriteLine("Path: C:\\Users\\Admin"); // Backslash
//             Console.WriteLine("Bell sound\a");   // Beep
//             Console.WriteLine("Unicode: \u03A9"); // Ω (Greek Omega)
//         }
//     }

//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             int a, b;

//             Console.WriteLine("Enter a: ");
//             a = int.Parse(Console.ReadLine());

//             Console.WriteLine("Enter b");
//             b = int.Parse(Console.ReadLine());

//             //(a, b) = (b, a); 

//             // temp = a;
//             // a = b;
//             // b = temp;

//             a = a + b;
//             b = a - b;
//             a = a - b;


//             Console.WriteLine("After Swapping");
//             Console.WriteLine("a is " + a);
//             Console.WriteLine("b is " + b);
//         }
//     }

//     ---------------------methods


//     public class Jaanu
//     {
//         static void Main(string[] args)
//         {
//             Jaanu obj = new Jaanu();
//             obj.Details();

//         }
//         public string Details()
//         {
//             string name = "Jaanu";
//             Console.WriteLine($"Name: {name}");
//             return $"Name: {name}";
//     }
        
//     }
//    }