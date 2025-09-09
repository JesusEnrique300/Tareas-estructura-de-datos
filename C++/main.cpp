#include <iostream>
#include <vector>
using namespace std;

int main() {
    vector<int> numeros = {10, 20, 30, 40, 50};

    // 1. Recorrer e imprimir
    cout << "Elementos iniciales:" << endl;
    for (int n : numeros) {
        cout << n << " ";
    }
    cout << endl;

    // 2. Insertar elemento
    numeros.push_back(60);

    cout << "Elementos despues de insertar 60:" << endl;
    for (int n : numeros) {
        cout << n << " ";
    }
    cout << endl;

    // 3. Buscar un elemento elegido por el usuario
    int buscar;
    cout << "Ingrese el numero a buscar: ";
    cin >> buscar;

    bool encontrado = false;
    for (int n : numeros) {
        if (n == buscar) {
            cout << "Elemento encontrado: " << n << endl;
            encontrado = true;
            break;
        }
    }
    if (!encontrado) {
        cout << "Elemento no encontrado." << endl;
    }

    return 0;
}
