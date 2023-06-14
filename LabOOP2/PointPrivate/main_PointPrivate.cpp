#include <iostream>
#include <cstdlib> //for abs
const double PI = 3.141592653589793; //pi

using std::cout;

class PointPrivate {
private:
	int x;
	int y;

public:
	PointPrivate() {
		SetX(0);
		SetY(0);
		cout << "PointPrivate()\n";
	}
	PointPrivate(int x, int y = 0) {
		SetX(x);
		SetY(y);
		cout << "PointPrivate(int x, int y = 0)\n";
	}
	PointPrivate(const PointPrivate& origin) {
		SetX(origin.GetX());
		SetY(origin.GetY());
		cout << "PointPrivate(const PointPrivate& origin)\n";
	}
	~PointPrivate() {
		cout << "~PointPrivate()\n";
	}

	int GetX() const {
		return x;
	}
	int GetY() const {
		return y;
	}

	void SetX(int x) {
		this->x = x;
	}
	void SetY(int y) {
		this->y = y;
	}

	void Move(int dx, int dy) {
		SetX(GetX() + dx);
		SetY(GetY() + dy);
	}
	void ShowPoint() {
		cout << GetX() << "; " << GetY() << '\n';
	}
	int SquareDist_FromOrigin() const {
		return abs(GetX() * GetX() + GetY() * GetY());
	}
	int SquareDist_TwoPoints(const PointPrivate& second) const;
};

int PointPrivate::SquareDist_TwoPoints(const PointPrivate& second) const {
	return abs((GetX() * GetX() + GetY() * GetY()) - (second.GetX() * second.GetX() + second.GetY() * second.GetY()));
}

class Circle {
public:
	PointPrivate* p;
	int r; //radius

	Circle() : p(new PointPrivate), r(0) {
		//p = new PointPrivate;
		//r = 0;
		cout << "Circle()\n";
	}
	Circle(int x, int y, int r = 0) : p(new PointPrivate(x, y)), r(r) {
		//p = new PointPrivate(x, y);
		//this->r = r;
		cout << "Circle(int x, int y, int r = 0) : PointPublic(x, y)\n";
	}
	Circle(const Circle& origin) : p(new PointPrivate(*(origin.p))), r(origin.r) {
		//p = origin.p; //поверхностное копирование (just copying pointer)
		//p = new PointPrivate(*(origin.p)); //глубокое копирование (creating new same object)
		//r = origin.r;
		cout << "Circle(const Circle& origin) : PointPublic(origin)\n";
	}
	~Circle() {
		delete p;
		cout << "~Circle()\n";
	}

	double Area() const {
		return PI * r * r;
	}

};


int main() {
	Circle *a = new Circle;
	Circle *b = new Circle(*a);
	delete a;
	delete b;

	cout << '\n';
	return 0;
}