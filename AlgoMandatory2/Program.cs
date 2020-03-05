using System;
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

            for (int i = 0; i < inputList.Length; i++)
            {
                if (inputList[i].Equals("^"))
                {
                    if (int.TryParse(inputList[i - 1], out int moveCount))
                    {
                        for (int j = i + 1; j < inputList.Length; j++)
                        {
                            if (int.TryParse(inputList[j], out int k) || inputList[j].Equals("^"))
                            {
                                continue;
                            }

                            char c = inputList[j].ToCharArray()[0];
                            int move = (((c + moveCount) - 65) % 26) + 65;
                            c = (char) move;
                            inputList[j] = c.ToString();
                        }
                    }

                    inputList = RemoveFromArray(inputList, i);
                    inputList = RemoveFromArray(inputList, i - 1);

                    i -= 2;
                }
            }
            
            // string ud = "";
            // foreach (string c in inputList)
            // {
            //     ud += c + " ";
            // }
            // Console.WriteLine(ud);
            
            Console.WriteLine(string.Join(' ',inputList));
        }

        static string[] RemoveFromArray(string[] a, int index)
        {
            string[] nArray = new string[a.Length - 1];
            for (int i = 0; i < index; i++)
            {
                nArray[i] = a[i];
            }

            for (int i = index + 1; i < a.Length; i++)
            {
                nArray[i - 1] = a[i];
            }

            return nArray;
        }
    }
}