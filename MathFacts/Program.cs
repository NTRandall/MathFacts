using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Math Facts App";
            int choice = 0;
            Addition addTable = new Addition();
            Multiplication timesTable = new Multiplication();
            Subtraction subTable = new Subtraction();
            Division divTable = new Division();
            do
            {
                MainAppTitle(); 
                choice = MainMenu();
                if (choice == 1)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        addTable.AdditionTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                addTable.AdditionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your addition Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                addTable.AdditionTable(startNum, endNum);
                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more additon facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter y or n");
                                }
                            }
                        }

                    } while (continueChoice == true);
                }

                //Multiplication portion
                if (choice == 2)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        timesTable.MultiplicationTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                        }
                        finally
                        {
                            if (startNum > 0 & endNum <= 10)
                            {
                                timesTable.MultiplicationTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your Multiplication Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                timesTable.MultiplicationTable(startNum, endNum);
                                Console.WriteLine("");

                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more multiplication facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter y or n");
                                }
                            }
                        }
                    } while (continueChoice == true);
                }
                if (choice == 3)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        subTable.SubtractionTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                subTable.SubtractionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your subtraction Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                subTable.SubtractionTable(startNum, endNum);
                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more subtraction facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter y or n");
                                }
                            }
                        }

                        } while (continueChoice == true);
                     }
                if (choice == 4)
                     {
                            bool continueChoice = true;
                            int startNum = 0;
                            int endNum = 0;
                            do
                            {
                            divTable.DivisionTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                divTable.DivisionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your addition Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                divTable.DivisionTable(startNum, endNum);
                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more additon facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter y or n");
                                }
                            }
                        }

                    } while (continueChoice == true);
                }

                //End    
            } while (choice != 5);

                     }
        
        private static int MainMenu()
        {
            int choice;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select an option");
            Console.WriteLine("-----------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Option 1: Addition Facts");
            Console.WriteLine("Option 2: Multiplication Facts");
            Console.WriteLine("Option 3: Subtraction Facts");
            Console.WriteLine("Option 4: Division Facts");
            Console.WriteLine("Option 5: Leave Math Facts");
            //TODO - fix the exception handling
            choice = Int32.Parse(Console.ReadLine());
            return choice;
        }

        private static void MainAppTitle()
        {
            Console.Clear();
            string appTitle = @"

#   #   #   ##### #   #       #     #   #   # #####  #### 
## ##  # #    #    # #       ###   # #  #   #   #   #     
# # # #####   #     #       # # # #####  ####   #   #     
#   # #   #   #    # #       ###  #   #     #   #   #     
#   # #   #   #   #   #       #   #   #     #   #    #### 

            ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
