using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of names to be stored");
            int NumberOfNames = Convert.ToInt32(Console.ReadLine());

          

             string[,] Names = new String[NumberOfNames,2];

            for (int i = 0; i < NumberOfNames; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter name number {0}", (i + 1));
                string name = Console.ReadLine();

                int hashvalue = 0;


                for (int charNumber = 0; charNumber <= (name.Length - 1); charNumber++)
                {
                    hashvalue = hashvalue + (Convert.ToByte(name[charNumber]) * charNumber);

                }

                hashvalue = hashvalue % (NumberOfNames*3);

                Names[i, 0] = Convert.ToString(hashvalue);
                Names[i, 1] = name;

            }

            for (int i = 0; i < NumberOfNames; i++)
            {
                Console.WriteLine(Names[i, 0] + " " + Names[i, 1]);
                
            }
            Console.ReadKey();


        }
    }
}
