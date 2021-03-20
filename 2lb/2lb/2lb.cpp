#include <iostream>
#include <vector>
using namespace std;

class doc {
protected:
    string payer;
    float sum;
    char date[11];
    int id;
public:
    
    static doc* begin;
     doc* next;

    static void add(doc *cur) {
        cur->next = begin;
        begin = cur;
    }

    doc() {
        payer = "";
        sum = 0;
        strcpy(date, "");
        id = 0;
    }
    doc(const string _payer, float _sum, const char _date[11], int _id) {
        payer = _payer;
        sum = _sum;
        strcpy(date, _date);
        id = _id;
        add(this);

    }
    virtual void show() {
        cout <<  "Плательщик: " << this->payer << "\tСумма: " << this->sum << "\tДата совершения платежа: " 
            << this->date << "\tID: " << this->id << endl;
    }
    static void print() {
        doc* l = begin;

        while (l) {
            l->show();
            l = l->next;
        }
    }
    ~doc() {};   
};
class waybill : public doc{
private:
    int count;
public:
    waybill() {
        count = 0;
    }
    waybill(const string _payer, float _sum, const char _date[11], int _id, int _count) 
        : doc(_payer, _sum, _date, _id)
    {
        count = _count;
    }
    ~waybill() {};
    void show() {
        cout << "Плательщик: " << this->payer << "\tСумма: " << this->sum << "\tДата совершения платежа: " << this->date << "\tID: " << this->id << "\tКоличество: " << this->count << endl;
    }
};
class receipt : public doc {
protected:
    int NDS;
public:
    receipt() {
        NDS = 0;
    }
    receipt(const string _payer, float _sum, const char _date[11], int _id, int _NDS)
        :doc(_payer, _sum, _date, _id)
    {
        NDS = _NDS;
    }
   
    ~receipt() { };
    void show() {
        cout << "Плательщик: " << this->payer << "\tСумма: " << this->sum << "\tДата совершения платежа: " << this->date << "\tID: " << this->id << "\tNDS: " << this->NDS << endl;
    }
};
class check : public  receipt {
private:
    float discount;
public:
    check() {
        discount = 0;
    }
    check(const string _payer, float _sum, const char _date[11], int _id, int _NDS, float _discount)
        :receipt(_payer, _sum, _date, _id, _NDS) {
        discount = _discount;
    }
    void show() {
        cout << "Плательщик: " << this->payer << "\tСумма: " << this->sum << "\tДата совершения платежа: " << this->date << "\tID: " << this->id << "\tNDS: " << this->NDS << "\tСкидка:" << this->discount << endl;
    }
    ~check() {};

};

doc* doc::begin;

int main()
{
    setlocale(LC_ALL, "");
    doc a("Kirill", 800, "10/10/2010",1);
    waybill b("Vasya", 300, "11/11/2000", 10, 1);
    receipt c("Lena", 100, "12/12/2012", 43, 20);
    check d("Dima", 2, "13/12/2013", 16, 50, 10);

    doc::print();
}
