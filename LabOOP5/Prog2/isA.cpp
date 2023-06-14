#include <iostream>

using namespace std;

class Animal {
public:
    virtual bool isA(string name) {
        return name == "Animal";
    }
    virtual void Sound() = 0;
};

class Cat : public Animal {
public:
    bool isA(string name) override {
        return name == "Cat" || Animal::isA(name);
    }
    void Sound() {
        cout << "Meow!\n";
    }
};

class Lion : public Animal {
public:
    bool isA(string name) override {
        return name == "Lion" || Animal::isA(name);
    }
    void Sound() {
        cout << "Rawr!\n";
    }
};

class Mouse : public Animal {
public:
    bool isA(string name) override {
        return name == "Mouse" || Animal::isA(name);
    }
    void Sound() {
        cout << "Squick!\n";
    }
};

int main()
{
    Mouse a;
    cout << a.isA("Mouse") << '\n';
    cout << a.isA("Animal") << '\n';
}
