using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlgoMandatory2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string ind = Console.ReadLine();

            string[] inputList = ind.Trim().Split(' ');

            Stack output = new Stack();
            long moveCount = 0;
            foreach (string input in inputList)
            {
                try
                {
                    if (input.Equals("^"))
                    {
                        string pop = output.Pop().ToString();
                        if (long.TryParse(pop, out long i))
                        {
                            moveCount += i;
                            moveCount = moveCount % 26;
                        }
                    }
                    else
                    {
                        if (!long.TryParse(input, out long j))
                        {
                            char c = input.ToCharArray()[0];
                            long move = (((c + moveCount) - 65) % 26) + 65;
                            c = (char) move;
                            output.Push(c.ToString());
                        }
                        else
                        {
                            output.Push(input);
                        }
                    }
                }
                catch
                {
                }
            }

            Console.WriteLine(string.Join(' ', output.ToArray().Reverse()));
        }
    }
}