using Florespinoza.ListasEnlasada;
using System;

namespace Florespinoza
{
    public class ListaEnlazada
    {
        private Nodo head;

        public ListaEnlazada()
        {
            head = null;
        }

        // Método para insertar un nodo al final de la lista
        public void InsertarFinal(int data)
        {
            Nodo newNode = new Nodo(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Nodo temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        // Método para insertar un nodo al inicio de la lista
        public void InsertarInicio(int data)
        {
            Nodo newNode = new Nodo(data);
            newNode.Next = head;
            head = newNode;
        }

        // Método para mostrar todos los elementos de la lista
        public void Mostrar()
        {
            if (head == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }

        // Método para eliminar un nodo con un valor específico
        public void EliminarNodo(int data)
        {
            if (head == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Nodo temp = head;
            while (temp.Next != null && temp.Next.Data != data)
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("El valor no se encuentra en la lista.");
                return;
            }

            temp.Next = temp.Next.Next;
            Console.WriteLine($"El valor {data} ha sido eliminado de la lista.");
        }

        // Método para encontrar el nodo medio de la lista
        public Nodo EncontrarNodoMedio()
        {
            if (head == null)
            {
                Console.WriteLine("La lista está vacía.");
                return null;
            }

            Nodo slow = head;
            Nodo fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            Console.WriteLine("El nodo medio es: " + slow.Data);
            return slow;
        }

        // Método para invertir la lista enlazada
        public void InvertirLista()
        {
            Nodo prev = null;
            Nodo current = head;
            Nodo next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;
            Console.WriteLine("La lista ha sido invertida.");
        }
    }
}