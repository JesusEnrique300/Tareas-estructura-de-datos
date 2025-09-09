#include <iostream>
using namespace std;

int main() {
    char arr[] = {'A', 'B', 'C', 'D', 'E'};
    int n = sizeof(arr) / sizeof(arr[0]);
    char valor;
    bool encontrado = false;

    cout << "Ingresa la letra a buscar: ";
    cin >> valor;

    for(int i = 0; i < n; i++) {
        if(arr[i] == valor) {
            cout << "Encontrado en la posición " << i << endl;
            encontrado = true;
            break; // Detener el bucle si encontramos el valor
        }
    }

    if(!encontrado)
        cout << "No se encontró la letra." << endl;

    return 0;
}




