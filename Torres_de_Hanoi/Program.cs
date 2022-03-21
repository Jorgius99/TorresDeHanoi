using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            int j = 0;
            Console.WriteLine("Cuantos discos le quieres meter?");
            n = Convert.ToInt32(Console.ReadLine());
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();
            Hanoi a = new Hanoi();

            for (int i = n; i > 0; i--)
            {
                Disco disco = new Disco(i);
                ini.push(disco);
            }
            Console.WriteLine("Como quieres hacerlo 1: recursivo; 2: iterativo");
            j = Convert.ToInt32(Console.ReadLine());
            if (j == 2)
            {
                Console.WriteLine(a.iterativo(n, ini, fin, aux));
            }
            else if (j == 1)
            {
                Console.WriteLine(a.recursivo(n, ini, fin, aux));
            }
            else
            {
                Console.WriteLine("Numero incorrecto");
            }
            
            

            //Console.WriteLine("Se ha completado el puzle en " + m + " movimientos");
            Console.ReadLine();
        }
    }
}
