//Prog1
//перекрываемые методы и виртуальные методы

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
    virtual ~GrandFather() { //когда удаляется grandfather, будут вызываться деструкторы всех потомков (если необходимо)
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
    ~Father() { //без virtual, когда удаляется father, будет вызван деструктор father, затем grandfather и на этом всё
        cout << "father deleted.\n";
    }    
    //virtual ~Father() { //когда удаляется father, если в переменной лежит son, то будет вызван и его деструктор 
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
    //void method_V_F() override { //уже перекрыть эту функцию нельзя, она ранее была перекрыта с модификатором final
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

    //все объекты классов лежат в своих переменных
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

    //Son лежит в переменной класса-предка Father
    cout << "\nSon in Father\n";
    Father* ptr1 = new Son;
    ptr1->method();
    ptr1->method_V();
    ptr1->method_V_F();

    //Son лежит в переменной класса-предка GrandFather
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