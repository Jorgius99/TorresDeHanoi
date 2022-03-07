using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        /* TODO: Implementar métodos */
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }

        public Pila(int Size, int Top, List<Disco> Elementos)
        {
            this.Size = Size;
            this.Top = Top;
            this.Elementos = Elementos;
        }

        public void push(Disco d)
        {
            Size++;
            this.Elementos.Add(d);
        }

        public Disco pop()
        {
            Disco final=Elementos.ElementAt(Top);
            Elementos.RemoveAt(Top);
            Size--;
            return final;
        }                

        public bool isEmpty()
        {
            if (Elementos.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
