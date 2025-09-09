using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> numeros = new List<int>{10, 20, 30, 40, 50};

        // 1. Recorrer e imprimir
        Console.WriteLine("Elementos iniciales:");
        foreach (int n in numeros) {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        // 2. Insertar elemento
        numeros.Add(60);

        Console.WriteLine("Elementos despues de insertar 60:");
        foreach (int n in numeros) {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        // 3. Buscar un elemento elegido por el usuario
        Console.Write("Ingrese el numero a buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        bool encontrado = false;
        foreach (int n in numeros) {
            if (n == buscar) {
                Console.WriteLine("Elemento encontrado: " + n);
                encontrado = true;
                break;
            }
        }
        if (!encontrado) {
            Console.WriteLine("Elemento no encontrado.");
        }
    }
}


