import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        char[] arr = {'A', 'B', 'C', 'D', 'E'};
        Scanner sc = new Scanner(System.in);
        System.out.print("Ingresa la letra a buscar: ");
        char valor = sc.next().charAt(0);
        boolean encontrado = false;

        for(int i = 0; i < arr.length; i++) {
            if(arr[i] == valor) {
                System.out.println("Encontrado en la posición " + i);
                encontrado = true;
                break;
            }
        }

        if(!encontrado)
            System.out.println("No se encontró la letra.");
    }
}





