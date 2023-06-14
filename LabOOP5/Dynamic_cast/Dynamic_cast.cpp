#include <iostream>

using namespace std;

class Animal {
public:
    virtual void Sound() {
        cout << "AnimalSound\n";
    }
    virtual ~Animal() {

    }
};

class Cat : public Animal {
public:
    void Sound() {
        cout << "Meow!\n";
    }
    void CatMethod() {
        cout << "chasing mouse\n";
    }
    ~Cat() {

    }
};

class Lion : public Animal {
public:
    void Sound() {
        cout << "Rawr!\n";
    }
    ~Lion() {

    }
};

class Mouse : public Animal {
public:
    void Sound() {
        cout << "Squick!\n";
    }
    ~Mouse() {

    }
};

int main()
{
    Animal* c = new Cat();
    Animal* e = new Lion();
    Cat* d;
    if (d = dynamic_cast<Cat*>(c)) {
        d->CatMethod();
    }
    else {
        cout << "failed to dynamic_cast\n";
    }
}
