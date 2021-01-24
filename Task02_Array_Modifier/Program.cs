using System;
using System.Linq;

namespace Task02_Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayForModify = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            while (true)
            {
                //Console.WriteLine(string.Join(", ", arrayForModify));

                string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string typeComand = comand[0].ToUpper();

                if (typeComand == "END")
                {
                    break;
                }

                switch (typeComand)
                {
                    case "SWAP":

                        int indexOne = int.Parse(comand[1]);
                        int indexTwo = int.Parse(comand[2]);

                        int helpVar = arrayForModify[indexOne];
                        arrayForModify[indexOne] = arrayForModify[indexTwo];
                        arrayForModify[indexTwo] = helpVar;

                        break;

                    case "MULTIPLY":

                        indexOne = int.Parse(comand[1]);
                        indexTwo = int.Parse(comand[2]);

                        arrayForModify[indexOne] *= arrayForModify[indexTwo];

                        break;

                    case "DECREASE":

                        for (int i = 0; i <= arrayForModify.Length - 1; i++)
                        {
                            arrayForModify[i]--;
                        }

                        break;
                    
                    default:
                        break;
                }
            }
            
            Console.WriteLine(string.Join(", ", arrayForModify));
        }
    }
}
