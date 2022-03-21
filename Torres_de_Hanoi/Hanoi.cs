using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        private int m=0;
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.isEmpty())
            {
                a.push(b.pop());
                m++;
            }
            else if (b.isEmpty())
            {
                b.push(a.pop());
                m++;
            }
            else if (a.Top < b.Top)
            {
                b.push(a.pop());
                m++;
            }
            else
            {
                a.push(b.pop());
                m++;
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            
            if(n%2 != 0)
            {
                while (fin.Size!=n)
                {
                    mover_disco(ini, fin);
                    Console.Write("Movimiento: " + m);
                    Console.Write("\n");
                    mover_disco(ini, aux);
                    Console.Write("Movimiento: " + m );
                    Console.Write("\n");
                    mover_disco(aux, fin);
                    Console.Write("Movimiento: " + m );
                    Console.Write("\n");
                }
            }
            else
            { 
                    mover_disco(ini, aux);
                    Console.Write("Movimiento: " + m );
                    Console.Write("\n");
                    mover_disco(ini, fin);
                    Console.Write("Movimiento: " + m );
                    Console.Write("\n");
                    mover_disco(aux, fin);
                    Console.Write("Movimiento: " + m );
                    Console.Write("\n");

            }
            
            return m;
        }
        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            m = 0;
            if (n == 1)
            {
                mover_disco(ini, fin);

            }
            else
            {
                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                recursivo(n - 1, aux, fin, ini);
            }
            return m;
        }

    }
}
