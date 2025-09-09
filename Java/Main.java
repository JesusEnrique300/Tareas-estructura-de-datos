import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        ArrayList<Integer> numeros = new ArrayList<>();
        numeros.add(10);
        numeros.add(20);
        numeros.add(30);
        numeros.add(40);
        numeros.add(50);

        // 1. Recorrer e imprimir
        System.out.println("Elementos iniciales:");
        for (int n : numeros) {
            System.out.print(n + " ");
        }
        System.out.println();

        // 2. Insertar elemento
        numeros.add(60);

        System.out.println("Elementos despues de insertar 60:");
        for (int n : numeros) {
            System.out.print(n + " ");
        }
        System.out.println();

        // 3. Buscar un elemento elegido por el usuario
        Scanner sc = new Scanner(System.in);
        System.out.print("Ingrese el numero a buscar: ");
        int buscar = sc.nextInt();

        boolean encontrado = false;
        for (int n : numeros) {
            if (n == buscar) {
                System.out.println("Elemento encontrado: " + n);
                encontrado = true;
                break;
            }
        }
        if (!encontrado) {
            System.out.println("Elemento no encontrado.");
        }
        sc.close();
    }
}



