using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {

            int multipl = 0;
                for (int j=0; j<11; j++)
                {
                    line();

                // Top line of multipliers

                    if (j == 0)
                    {
                        for (int i = 0; i < 11; i++)
                            if (i == 0)
                                Console.Write("|   |");
                            else
                                if (i != 10)
                                Console.Write("| {0} |", i);
                            else
                                Console.Write("| {0}|", i);
                        Console.WriteLine();
                    line();
                    }
                // Execution after formation of top line of multipliers

                    if (j !=0)
                    {
                    //Forming a side row of multipliers

                        if (j != 10)
                            Console.Write("| {0}||", j);
                        else
                            Console.Write("|{0}||", j);

                    //Multiplication table

                        for (int h=1;h<=10;h++)
                        { 
                                multipl = h * j;
                                if (multipl < 10)
                                    Console.Write("| {0} |", multipl);
                                else
                                        if (multipl != 100)
                                    Console.Write("| {0}|", multipl);
                                else
                                    Console.Write("|{0}|", multipl);
                        }
                            Console.WriteLine();
                    }       
                }
            line();   
            Console.ReadKey();
        }

        static void line()
        {
            for (int n = 0; n < 11; n++)
                Console.Write(" --- ");
            Console.WriteLine();
        }


    }
}
