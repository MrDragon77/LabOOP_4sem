#include <iostream>
#include <memory>

using namespace std;

class Base {
public:
    Base() {
        cout << "Base() constructor called.\n";
    }
    Base(Base* obj) {
        cout << "Base(Base* obj) constructor called.\n";
    }
    Base(Base& obj) {
        cout << "Base(Base& obj) constructor called.\n";
    }
    Base(const Base& obj) {
        cout << "Base(Base& obj) constructor called.\n";
    }
    ~Base() {
        cout << "~Base() destructor called.\n";
    }
};

class Desc : public Base {
public:
    Desc() {
        cout << "Desc() constructor called.\n";
    }
    Desc(Desc* obj) {
        cout << "Desc(Desc* obj) constructor called.\n";
    }
    Desc(Desc& obj) {
        cout << "Desc(Desc& obj) constructor called.\n";
    }
    ~Desc() {
        cout << "~Desc() destructor called.\n";
    }
};


void func1(Base  obj) {
    cout << "func1.\n";
}

void func2(Base* obj) {
    cout << "func2.\n";
}

void func3(Base& obj) {
    cout << "func3.\n";
}


Base func1() {
    Base obj;
    return obj;
}

Base* func2() {
    Base obj;
    return &obj;
}

Base& func3() {
    Base obj;
    return obj;
}

unique_ptr<Base> func4() {
    //Base* obj = new Base();
    //return *obj;
    unique_ptr<Base> obj = make_unique<Base>();
    return move(obj);
}

Base* func5() {
    Base* obj = new Base();
    return obj;
}
Base& func6() {
    Base* obj = new Base();
    return *obj;
}


int main()
{
    Base *a = new Base();
    Desc *b = new Desc();
    func1(a);
    func2(a);
    func3(*a);
    func1(b);
    func2(b);
    func3(*b);

    cout << "MyQuest\n";
    Desc obj11;
    func1(obj11);

    cout << "\nCREATION IN FUNCTIONS\n";
    //Base c = func1();
    Base c;
    c = func1();

    cout << '\n';
    Base* d = func2();

    cout << '\n';
    Base &e = func3();

    cout << '\n';
    Base f = func4();

    cout << '\n';
    Base *g = func5();

    cout << '\n';
    Base &k = func6();

    cout << '\n';

    return 0;
}