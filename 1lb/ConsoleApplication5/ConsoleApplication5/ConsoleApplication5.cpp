// ConsoleApplication5.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include<cstring>
#define _CRT_SECURE_NO_WARNINGS
using namespace std;

class animal {
public:
    char name[25];
    char *clas;
    int aWeight;
    animal() {
        
        strcpy(name, "unknown\t");
        clas = NULL;
        aWeight = 0;
        cout << "\nВызвался конструктор без параметров!\n";
    };
    animal(const char *_name, const char * _clas, int _weight) {
        strcpy(name, _name);
        clas = (char*)malloc(sizeof(_clas));
        strcpy(clas, _clas);
        aWeight = _weight;
        cout << "\nВызвался конструтор с парметрами\n";
    };
    animal(animal &al) {
        strcpy(name, al.name);
        clas = (char*)malloc(sizeof(al.clas));

        strcpy(clas, al.clas);
        aWeight = al.aWeight;
        cout << "\nВызвался конструктор копирования\n";
    };
    ~animal() {
        cout << "\nВызвался деструктор\n";
    }
    char* GetName() { return name; }
    char* GetClas() { return clas; }
    int GetAWeight() { return aWeight; }
    void SetName(const char* _name) {
        strcpy(name, _name);
    }
    void SetClas(const char* _clas) {
        clas = (char*)realloc(clas, sizeof(_clas));
        strcpy(clas, _clas);
    }
    void SetAWeight(int weight) {
        aWeight = weight;
    }
    void PrintAnimal() {
        char result[100];
        sprintf(result, "\n\nИнформация о животном\nИмя: %s \nКласс: %s \nСредний вес: %d\n\n", name, clas, aWeight);
        cout << result;
    }
};
void example() {
    cout << "\n\nУказатель fcnPtr ссылается на функцию example\n";
}
void (*fcnPtr)() = example;


int main() {
    setlocale(LC_ALL, "");
    animal cat;
    cat.PrintAnimal();
    animal cat1("Kod", "Mlekopit", 6);
    cat1.PrintAnimal();
    animal cat2(cat1);
    cat2.PrintAnimal();
    (*fcnPtr)();
    animal* cat3 = &cat;
    cat3->SetClas("xyz");
    cat3->PrintAnimal();
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
