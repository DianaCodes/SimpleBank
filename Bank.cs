using System;
using System.Data.SqlClient;
using System.Collections;
using BankAccount;
using System.Collections.Generic;
using System.IO;
using Microsoft.SqlServer;
using System.Data;

/*
author: Diana Arita
 */

namespace BankProgram {
    public class Bank {
        public Bank() {
        }

        public static void Main(string[] args) {
            string sqlConnectionString = "Data Source=(local);Initial Catalog=AdventureWorks;Integrated Security=True";
            FileInfo file = new FileInfo("C:\\data.sql");
            string script = file.OpenText().ReadToEnd();
            SqlConnection conn = new SqlConnection(sqlConnectionString);
            Server server = new Server(new ServerConnection(conn));
            server.ConnectionContext.ExecuteNonQuery(script);


            List<Account> bank = new List<Account>();

        //     while(true) {
        //         Console.WriteLine("Welcome to the Online Bank.");
        //         Console.WriteLine("1. to create an account.");
        //         Console.WriteLine("2. to check balance.");
        //         Console.WriteLine("3. to deposit.");
        //         Console.WriteLine("4. to withdraw.");
        //         Console.WriteLine("5. to set interest rate.");
        //         Console.WriteLine("6. to check compund interest.");

        //         String s = Console.ReadLine();
                
        //         if(s=="1"){
        //             Console.Write("Please type a name: ");
        //             string name = Console.ReadLine();
        //             Console.Write("Enter initial balance: ");
        //             double init = double.Parse(Console.ReadLine());
        //             bank.Add(new Account(name, init));
        //             Console.WriteLine("Bank Account Added!");
        //             Console.ReadLine();
        //         }else if(s=="2"){
        //             Console.Write("Please type a name: ");
        //             string nmChk = Console.ReadLine();
        //             for (int ix = 0; ix < bank.Count; ix++)
        //             {
        //                 if (bank[ix].name == nmChk)
        //                 {
        //                     Console.WriteLine("Account Found!\nName: {0}\nBalance: {1}", bank[ix].name, bank[ix].balance);
        //                 }
        //             }
        //             Console.ReadLine();
        //         } else if(s=="3"){
        //             Console.Write("Please type a name: ");
        //             string nmChk = Console.ReadLine(), nmNow = null;
        //             int accNum = -1;
        //             for (int ix = 0; ix < bank.Count; ix++)
        //             {
        //                 if (bank[ix].name == nmChk)
        //                 {
        //                     nmNow = nmChk;
        //                     accNum = ix;
        //                 }
        //             }
        //             if (accNum != -1)
        //             {
        //                 Console.Write("Amount to Deposit: ");
        //                 bank[accNum].deposit(double.Parse(Console.ReadLine()));
        //                 Console.WriteLine("Amount successfully deposited!");
        //             }
        //             else { Console.WriteLine("Account not found!"); }
        //             Console.ReadLine();
        //         } else if(s=="4"){
        //             Console.Write("Please type a name: ");
        //             string nmChk = Console.ReadLine(), nmNow = null;
        //             int accNum = -1;
        //             for (int ix = 0; ix < bank.Count; ix++)
        //             {
        //                 if (bank[ix].name == nmChk)
        //                 {
        //                     nmNow = nmChk;
        //                     accNum = ix;
        //                 }
        //             }
        //             if (accNum != -1)
        //             {
        //                 Console.Write("Amount to Withdraw: ");
        //                 bool ok = bank[accNum].withdraw(double.Parse(Console.ReadLine()));
        //                 if (ok) 
        //                 {
        //                     Console.WriteLine("Amount successfully withdrawn!");
        //                     if (bank[accNum].balance == 0)
        //                     {
        //                         bank[accNum] = null;
        //                         Console.WriteLine("Account closed!");
        //                     }
        //                 }
        //                 else { Console.WriteLine("Insufficient funds!"); }
        //             }
        //             else { Console.WriteLine("Account not found!"); }
        //             Console.ReadLine();
        //         } else if(s=="5"){
        //             Console.Write("Please type a name: ");
        //             string nmChk = Console.ReadLine(), nmNow = null;
        //             int accNum = -1;
        //             for (int ix = 0; ix < bank.Count; ix++)
        //             {
        //                 if (bank[ix].name == nmChk)
        //                 {
        //                     nmNow = nmChk;
        //                     accNum = ix;
        //                 }
        //             }
        //             if (accNum != -1)
        //             {
        //                 Console.Write("Set interest rate (in percent): ");
        //                 bank[accNum].setIntRate((0.01 * double.Parse(Console.ReadLine())));
        //                 Console.WriteLine("Interest rate set!");
        //             }
        //             else { Console.WriteLine("Account not found!"); }
        //             Console.ReadLine();
        //         } else if(s=="6"){
        //             Console.Write("Please type a name: ");
        //             string nmChk = Console.ReadLine(), nmNow = null;
        //             int accNum = -1;
        //             for (int ix = 0; ix < bank.Count; ix++)
        //             {
        //                 if (bank[ix].name == nmChk)
        //                 {
        //                     nmNow = nmChk;
        //                     accNum = ix;
        //                 }
        //             }
        //             if (accNum != -1)
        //             {
        //                 Console.Write("Months of compunding interest: ");
        //                 int mos = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Balance after {0} months: {1}", mos, bank[accNum].getBalAfter(mos));
        //             }
        //             else { Console.WriteLine("Account not found!"); }
        //             Console.ReadLine();
        //         } else if(s=="quit"){
        //             break;
        //         } else{
        //             Console.WriteLine("Invalid Syntax!");
        //             Console.ReadLine();
        //         }
        //     }
        //     Console.Clear();
        } 
    }
}