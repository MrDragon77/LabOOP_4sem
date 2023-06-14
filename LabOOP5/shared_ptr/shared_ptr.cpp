#include <iostream>
#include <memory>

using namespace std;

class Point {
public:
    int x, y;

    Point() : x(0), y(0) {

    }
    Point(int x, int y) : x(x), y(y) {

    }
    Point(const Point& origin) : x(origin.x), y(origin.y) {

    }
    void method() {
        cout << "Point method.\n";
    }
    virtual ~Point() {

    }
};

void pass_object_V(unique_ptr<Point> p)
{
    p->method(); //point уничтожается здесь
}

shared_ptr<Point> pass_object(shared_ptr<Point> p)
{
    p->method();
    return p;
}

int main()
{
    //unique_ptr<Point> a;
    //Point* ptr = new Point();
    //a = ptr; //так нельзя, ошибка

    shared_ptr<Point> p = make_shared<Point>(1, 2);
    p = pass_object(p);
    p->method();
    return 0;
}