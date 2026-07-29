using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{

    
       class InvalidAmountException : Exception
        {
            public InvalidAmountException(string message) : base(message)
            { }
        }
        internal class Program
        {


            static void Main(string[] args)
            {
                string[] category = new string[10];
                double[] amount = new double[10];
                int count = 0;
                int choice;

                do
                {
                    Console.WriteLine("\n===== Expense Tracker =====");
                    Console.WriteLine("1. Add Expense");
                    Console.WriteLine("2. Display Expenses");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");

                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                if (count == 10)
                                {
                                    Console.WriteLine("Expense storage is full.");
                                    break;
                                }
                                try
                                {
                                    Console.Write("Enter Category: ");
                                    category[count] = Console.ReadLine();

                                    foreach (char ch in category[count])
                                    {
                                        if (!char.IsLetter(ch) && ch != ' ')
                                        {
                                            throw new Exception("Category should contain only letters.");
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    continue;   // Return to the menu
                                }

                                Console.Write("Enter Amount: ");

                                try
                                {
                                    amount[count] = Convert.ToDouble(Console.ReadLine());

                                    if (amount[count] <= 0)
                                    {
                                        throw new InvalidAmountException("Amount must be greater than 0.");
                                    }

                                    count++;
                                    Console.WriteLine("Expense Added Successfully.");
                                }
                                catch (InvalidAmountException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }

                                break;

                            case 2:
                                if (count == 0)
                                {
                                    Console.WriteLine("No Expenses Found.");
                                }
                                else
                                {
                                    double total = 0;

                                    Console.WriteLine("\nExpense List");
                                    Console.WriteLine("----------------------");

                                    for (int i = 0; i < count; i++)
                                    {
                                        Console.WriteLine("Category : " + category[i]);
                                        Console.WriteLine("Amount   : " + amount[i]);
                                        Console.WriteLine("----------------------");

                                        total += amount[i];
                                    }

                                    Console.WriteLine("Total Expense = " + total);
                                }
                                break;

                            case 3:
                                Console.WriteLine("Thank You!");
                                break;

                            default:
                                Console.WriteLine("Invalid Choice.");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter valid input.");
                        choice = 0;
                    }

                } while (choice != 3);

            }
        }
    }

