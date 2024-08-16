using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florespinoza
{


namespace ListasEnlasada
{
    public class Nodo
    {
        public int Data;
        public Nodo Next;

        public Nodo(int data)
        {
            Data = data;
            Next = null;
        }
    }
}