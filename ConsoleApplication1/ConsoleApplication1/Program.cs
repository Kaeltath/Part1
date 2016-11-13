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
            int NumberOne = 1;
            int NumberTwo = 2;
            int residue = 3;
            Console.WriteLine("input number one ");
            NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number two ");
            NumberTwo = Convert.ToInt32(Console.ReadLine());
            if (NumberTwo == 0)
            {
                Console.WriteLine("error ecured: \"Dividing by ZERO\" ");
            }
            else
            {
                residue = NumberOne % NumberTwo;
                if (residue != 0)
                {

                    Console.WriteLine("Not Divided");
                }
                else
                {
                    int Summ = NumberOne / NumberTwo;
                    Console.WriteLine("summ = " + Summ);
                }
            }
            Console.ReadLine();
        }
    }
}