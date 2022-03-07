using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.Top < b.Top)
            {
                if (a.Size != 0)
                {
                    Disco anyadir = a.pop();
                    b.push(anyadir);
                }
            }
            else
            {
                if (b.Size != 0)
                {
                    Disco anyadir1 = b.pop();
                    a.push(anyadir1);
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
