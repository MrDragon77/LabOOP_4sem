//2-3 вопроса "В рамках..."

#include <iostream>

using namespace std;

class Father {
public:
    void method1() {
        cout << "method1 called by father.\n";
        method2();
    }
    void method2() { //будет вызван method2 у father
        cout << "method2 called by father.\n";
    }
    //virtual void method2() { //будет вызван method2 у son
    //    cout << "method2 called by father.\n";
    //}
};

class Son : public Father {
public:
    void method2() {
        cout << "method2 called by son.\n";
    }
};

int main()
{
    Son a;
    a.method1();
    return 0;
}
