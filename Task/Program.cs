#include <iostream>
#include <string>
using namespace std;

int main() {
    string array1[5] = { "123", "23", "hello", "world", "res" };
    string array2[sizeof(array1) / sizeof(array1[0])];
    int count = 0;

    for (int i = 0; i < sizeof(array1) / sizeof(array1[0]); i++) {
        if (array1[i].length() <= 3) {
            array2[count] = array1[i];
            count++;
        }
    }

    for (int i = 0; i < sizeof(array2) / sizeof(array2[0]); i++) {
        cout << array2[i] << " ";
    }
    cout << endl;

    return 0;
}
