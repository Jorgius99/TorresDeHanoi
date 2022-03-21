using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        private int n;

        public int Size { get; set; } 
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }

        public Pila()
        {
            this.Size = 0;
            this.Top = 0;
            Elementos = new List<Disco>();
        }
        

        
        public void push(Disco d)
        {
            Elementos.Add(d);
            Size = Elementos.Count();
            Top = d.Valor;
        }

        public Disco pop()
        {
            Disco eliminar = Elementos.Last();
            Elementos.RemoveAt(Elementos.Count - 1);
            Size = Elementos.Count;

            if (Elementos.Count == 0)
            {
                Top = 0;
            }
            else
            {
                Top = Elementos.Last().Valor;
            }
            return eliminar;
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
