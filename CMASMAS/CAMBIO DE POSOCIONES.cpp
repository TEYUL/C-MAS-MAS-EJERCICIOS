#include <iostream>
#include <string>

using namespace std;

int main() {
    string numero;
    cout << "Ingrese un numero: ";
    cin >> numero;

    if (numero.length() < 2 || numero.length() > 4) {
        cout << "El numero ingresado debe tener entre dos y cuatro digitos." << endl;
        return 1;
    }

    int longitud = numero.length();
    for (int i = 0; i < longitud / 2; ++i) {
        char temp = numero[i];
        numero[i] = numero[longitud - 1 - i];
        numero[longitud - 1 - i] = temp;
    }

    cout << "Los cambios son: " << numero << endl;

    return 0;
}








