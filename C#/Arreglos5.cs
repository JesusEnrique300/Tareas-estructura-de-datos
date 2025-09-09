using System;

class Program {
    static void Main() {
        int[,] arr = { {1,2,3}, {4,5,6}, {7,8,9} };

        for(int j = 0; j < 3; j++) {      // Columnas
            for(int i = 0; i < 3; i++) {  // Filas
                Console.Write(arr[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}


