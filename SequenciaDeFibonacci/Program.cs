using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaDeFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A sequencia de Fibonacci começando do 0,1 ate o vigesimo valor sera: ");

            int i = 0,anterior=0,atual=1,num=0;


            while(i <= 20)
            {
                Console.WriteLine("\n" + num);
                num = atual + anterior;
                
                anterior = atual;
                atual = num;

                i++;
            }
            Console.ReadKey();







        }
    }
}
