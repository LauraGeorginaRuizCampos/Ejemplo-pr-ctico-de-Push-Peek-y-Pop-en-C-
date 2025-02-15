using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una pila de enteros
        Stack<int> stack = new Stack<int>();

        // PUSH: Agregar elementos a la pila
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine("Lord Farquaad presenta: Ejemplos prácticos de Push, Peek y Pop en C#");
        Console.WriteLine("\nElementos en la pila después de PUSH: " + string.Join(", ", stack));

        // PEEK: Ver el elemento en la cima sin eliminarlo
        Console.WriteLine("\nElemento en la cima (Peek): " + stack.Peek());

        // POP: Eliminar el elemento en la cima
        int removedElement = stack.Pop();
        Console.WriteLine("\nElemento eliminado con POP: " + removedElement);

        // Mostrar pila después del POP
        Console.WriteLine("\nElementos en la pila después de POP: " + string.Join(", ", stack));

        Console.ReadLine();
    }
}

