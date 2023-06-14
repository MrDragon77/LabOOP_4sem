#include <iostream>

using namespace std;
class Animal {
public:
    virtual string classname() {
        return "Animal";
    }
    virtual void Sound() = 0;
};

class Cat : public Animal {
public:
    string classname() override {
        return "Cat";
    }
    void Sound() {
        cout << "Meow!\n";
    }
};

class Lion : public Animal {
public:
    string classname() override {
        return "Lion";
    }
    void Sound() {
        cout << "Rawr!\n";
    }
};

class Mouse : public Animal {
public:
    string classname() override {
        return "Mouse";
    }
    void Sound() {
        cout << "Squick!\n";
    }
};

int main()
{
    Mouse a;
    if (a.classname() == "Mouse" || a.classname() == "Animal") {
        cout << true;
    }
    else {
        cout << false;
    }
    cout << '\n';
    return 0;
}
