#define __CRTDBG_MAP_ALLOC
#include <crtdbg.h>
#define DEBUG_NEW new(_NORMAL_BLOCK, __FILE__, __LINE__)
#define new DEBUG_NEW

#include <iostream>
#include <vector>

using namespace std;

class OBJ {
public:
    int field;
    OBJ(int it) : field(it) {

    }
};

class MyObject {
public:
    int field;
    OBJ* obj;

    MyObject(int it) : field(it) {
        obj = new OBJ(it);
    }
    ~MyObject() {
        delete obj;
    }
};

int main()
{
    {
        vector<MyObject> a;
    for (int i = 0; i < 10; i++) {
        //MyObject* tmp = new MyObject(i);
        a.push_back(*(new MyObject(i)));
        //delete tmp;
    }

    for (int i = 0; i < 10; i++) {
        cout << a[i].field;
    }
    cout << endl;

    //a.erase(a.begin(), a.end());
    //MyObject *b = new MyObject(0);


    cout << a.size() << endl;
    cout << a.capacity() << endl;
    }
    _CrtDumpMemoryLeaks();
    return 0;
}
