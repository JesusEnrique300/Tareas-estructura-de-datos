using System;

class Program {
    static void Main() {
        char[] arr = {'A', 'B', 'C', 'D', 'E'};
        Console.Write("Ingresa la letra a buscar: ");
        char valor = Console.ReadLine()[0];
        bool encontrado = false;

        for(int i = 0; i < arr.Length; i++) {
            if(arr[i] == valor) {
                Console.WriteLine("Encontrado en la posición " + i);
                encontrado = true;
                break;
            }
        }

        if(!encontrado)
            Console.WriteLine("No se encontró la letra.");
    }
}





