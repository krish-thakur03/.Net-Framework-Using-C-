﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A1q1 ques01 = new A1q1();
            ques01.func01();


            A1q2 ques02 = new A1q2();
            ques02.func02();


            A1q3 ques03 = new A1q3();
            ques03.checkBalance();
            ques03.deposit(8000);
            ques03.withdraw(18000);
            ques03.checkBalance();


            A1q4 ques04 = new A1q4();
            ques04.func04();


            A1q5 ques05 = new A1q5();
            ques05.checkPassword();


            A1q6 ques06 = new A1q6();
            ques06.GetTotalCharge();


            A1q7 ques07 = new A1q7();
            ques07.attend();
            ques07.attend();
            ques07.attend();
            ques07.attend();
            ques07.getAttendence();
            ques07.isPerfectattence();


            A1q8 ques08 = new A1q8();
            ques08.getExpenseDetails();


            A1q9 quesQ9 = new A1q9();
            quesQ9.addItem("laptop", 60000);
            quesQ9.addItem("mobile", 19000);
            quesQ9.addItem("watch", 2000);
            quesQ9.removeItem("watch");
            quesQ9.getTotalPrice();


            A1q10 ques10 = new A1q10();
            ques10.getMonthSallery();
        }
    }
    class A1q1
    {
        public void func01()
        {

            double[] shopcart = { 1000, 2800, 3000, 1980, 1235 };
            double totalsum = 0;
            for (int i = 0; i < shopcart.Length; i++)
            {
                totalsum += shopcart[i];
            }
            if (totalsum > 3000)
            {
                totalsum = (totalsum * 90) / 100;
            }
            Console.WriteLine("Your final sum is : " + totalsum.ToString());
        }
    }
    class A1q2
    {
        public void func02()
        {
            Console.WriteLine("Enter the temperature in Celsius : ");
            double temp = double.Parse(Console.ReadLine());
            double F = ((temp * 9) / 5) + 32;
            Console.WriteLine("Temperature in fahrenheit is : " + F.ToString());
        }
    }
    class A1q3
    {
        double balance = 5000;
        public void checkBalance()
        {
            Console.WriteLine("Your current balance is : " + balance.ToString());
        }
        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("After depositing " + amount.ToString() + " Your New balance is : " + balance.ToString());
        }
        public void withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient amount ");
                return;
            }
            balance -= amount;
            Console.WriteLine("After withdrawal of " + amount.ToString() + " Your new balance is : " + balance.ToString());
        }
    }
    class A1q4
    {
        public void func04()
        {
            double[] marks = new double[5];
            double totalMarks = 0;
            Console.WriteLine("Enter the marks of five subjects ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter the marks of subject " + (i + 1) + " : ");
                marks[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < marks.Length; i++)
            {
                totalMarks += marks[i];
            }
            double average = totalMarks / 5;
            if (average > 90) Console.WriteLine("Your grade is : A");
            else if (average > 80) Console.WriteLine("Your grade is : B");
            else if (average > 70) Console.WriteLine("Your grade is : C");
            else if (average < 60) Console.WriteLine("Your grade is : D");
            else
            {
                Console.WriteLine("Your grade is : F");
            }
        }
    }
    class A1q5
    {
        public void checkPassword()
        {
            Console.Write("Enter the password : ");
            string pass = Console.ReadLine();
            bool isLower = false;
            bool isUpper = false;
            bool isDigit = false;
            if (pass.Length > 7)
            {
                foreach (char c in pass)
                {
                    if (char.IsDigit(c))
                        isDigit = true;
                    else if (char.IsLower(c))
                        isLower = true;
                    else if (char.IsUpper(c))
                        isUpper = true;
                }
                if (isUpper && isLower && isDigit)
                    Console.WriteLine("password is valid");
                return;
            }
            Console.WriteLine("Password is invalid. It must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number like qRi4n9gL");
        }

    }
    class A1q6
    {
        public void GetTotalCharge()
        {
            double fixedCharge = 20;
            double chargePerKm = 5;
            double totalCharge = 0;
            Console.Write("Enter the distance travelled : ");
            double dis = double.Parse(Console.ReadLine());
            Console.Write("Enter the subcharge is applied : ");
            double subCharge = double.Parse(Console.ReadLine());
            if (dis < 3)
            {
                totalCharge = totalCharge + fixedCharge;
                Console.WriteLine("Your total charge is " + totalCharge.ToString());
                return;
            }
            totalCharge = ((dis - 2) * chargePerKm) + fixedCharge + subCharge;
            Console.WriteLine("Your total charge is " + totalCharge.ToString());
        }

    }
    class A1q7
    {
        int attendece = 0;
        int totalAttendence = 5;
        public void getAttendence()
        {
            Console.WriteLine("Your attendence is " + (totalAttendence - attendece).ToString());
        }
        public void attend()
        {
            attendece++;
        }
        public bool isPerfectattence()
        {
            return attendece > 2 ? true : false;
        }

    }
    class A1q8
    {
        public void getExpenseDetails()
        {
            double[] months = new double[12];
            double totalExpense = 0;
            int maxExpenseMonth = 1;
            int minExpenseMonth = 1;
            for (int i = 0; i < months.Length; i++)
            {
                Console.Write("enter expense of " + (i + 1) + " month : ");
                months[i] = double.Parse(Console.ReadLine());
                totalExpense += months[i];
            }
            for (int i = 0; i < totalExpense; i++)
            {
                if (months[maxExpenseMonth] < months[i])
                {
                    maxExpenseMonth = i;
                }
                else if (months[minExpenseMonth] > months[i])
                {
                    minExpenseMonth = i;
                }
            }
            Console.WriteLine("Maximum expense month : " + maxExpenseMonth.ToString());
            Console.WriteLine("Minimum expense month : " + minExpenseMonth.ToString());
            Console.WriteLine("Total expense of year : " + totalExpense.ToString());


        }

    }
    class A1q9
    {
        Dictionary<string, double> cart = new Dictionary<string, double>();
        double total = 0;

        public void addItem(string name, double price)
        {
            cart.Add(name, price);
            total += price;
        }
        public void removeItem(string name)
        {
            total -= cart[name];
            cart.Remove(name);

        }
        public void getTotalPrice()
        {
            Console.WriteLine("Total price is " + total.ToString());
        }

    }
    class A1q10
    {
        public void getMonthSallery()
        {
            int[] weekHours = new int[4];

            int totalHours = 0;
            Console.Write("Enter the wage per hour rate : ");
            int hourWage = int.Parse(Console.ReadLine());
            for (int i = 0; i < weekHours.Length; i++)
            {
                Console.Write("Enter the hours of " + (i + 1) + "week : ");
                weekHours[i] = int.Parse(Console.ReadLine());
                totalHours += weekHours[i];
            }
            Console.WriteLine("Your tatal sallery of months is " + (totalHours * hourWage).ToString());


        }

    }
}
