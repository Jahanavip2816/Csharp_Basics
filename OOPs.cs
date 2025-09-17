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