//Prog1
//������������� ������ � ����������� ������

#include <iostream>

using namespace std;

class GrandFather {
public:
    GrandFather() {
        cout << "grandfather created.\n";
    }
    void method() {
        cout << "grandfather called method\n";
    }
    virtual void method_V() {
        cout << "grandfather called method_V\n";
    }
    virtual void method_V_F() {
        cout << "grandfather called method_V_F\n";
    }
    //~GrandFather() {
    //    cout << "grandfather deleted.\n";
    //}    
    virtual ~GrandFather() { //����� ��������� grandfather, ����� ���������� ����������� ���� �������� (���� ����������)
        cout << "grandfather deleted.\n";
    }
};

class Father : public GrandFather {
public:
    Father() {
        cout << "father created.\n";
    }
    void method() {
        cout << "father called method\n";
    }
    void method_V() override {
        cout << "father called method_V\n";
    }
    void method_V_F() final {
        cout << "father called method_V_F\n";
    }
    ~Father() { //��� virtual, ����� ��������� father, ����� ������ ���������� father, ����� grandfather � �� ���� ��
        cout << "father deleted.\n";
    }    
    //virtual ~Father() { //����� ��������� father, ���� � ���������� ����� son, �� ����� ������ � ��� ���������� 
    //    cout << "father deleted.\n";
    //}
};

class Son : public Father {
public:
    Son() {
        cout << "son created.\n";
    }
    void method() {
        cout << "son called method\n";
    }
    void method_V() override {
        cout << "son called method_V\n";
    }
    //void method_V_F() override { //��� ��������� ��� ������� ������, ��� ����� ���� ��������� � ������������� final
    //    cout << "father called method_V_F\n";
    //}
    ~Son() {
        cout << "son deleted.\n";
    }
};



int main()
{
    GrandFather a;
    Father b;
    Son c;

    //��� ������� ������� ����� � ����� ����������
    cout << '\n';
    a.method();
    a.method_V();
    a.method_V_F();
    b.method();
    b.method_V();
    b.method_V_F();
    c.method();
    c.method_V();
    c.method_V_F();

    //Son ����� � ���������� ������-������ Father
    cout << "\nSon in Father\n";
    Father* ptr1 = new Son;
    ptr1->method();
    ptr1->method_V();
    ptr1->method_V_F();

    //Son ����� � ���������� ������-������ GrandFather
    cout << "\nSon in GrandFather\n";
    GrandFather* ptr2 = new Son;
    ptr2->method();
    ptr2->method_V();
    ptr2->method_V_F();

    cout << "\ndeleting\n";
    delete ptr1;
    delete ptr2;
    cout << '\n';
    return 0;
}