﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Subtraction
    {
    
        public void SubtractionTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @"
                                                                                                          
 #### #   # ####  ##### ####    #   #   # ##### #   #  ###  #   #     #####   #   ####  ##### #####  #### 
#      # #   #      #   #   #  # #  #   #   #   #  ## #   # #   #       #    # #   #     #  # #     #     
#       #    ####   #   ####  #####  ####   #   # # # #   # #####       #   #####  ####  #  # ####  #     
#      #     #  #   #   #     #   #     #   #   ##  # #   # #   #       #   #   #  #  #  #  # #     #     
 #### #     #####   #   #     #   #     #   #   #   #  ###  #   #       #   #   # ##### #   # #####  #### 
";

            Console.WriteLine(appTitle); ;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending number between 1 -10.");
            Console.WriteLine("Next you will see the numbers between these selections be subtracted.");
            Console.WriteLine("to numbers 1 -10");
            Console.WriteLine("");
            Console.WriteLine("Select a starting number between 1 and 10");
        }

        public void SubtractionTable(int startNum, int endNum)
        {
            //TODO - build out the logic of addition table here
            for (int i = startNum - 1; i <= endNum; i++)
            {
                if (i == startNum - 1)
                {
                    Console.Write(String.Format("{0, 6}", "n"));
                }
                else
                {
                    Console.Write(String.Format("{0,6}", i));
                }

            }

            Console.WriteLine("\n");


            for (int i = 1; i <= 10; i++)
            {
                Console.Write(String.Format("{0, 6}", i));
                for (int b = startNum; b <= endNum; b++)
                {
                    string output = String.Format("{0, 6}", i - b);
                    Console.Write(output);
                }
                Console.WriteLine("");
            }

        }
    }
}
