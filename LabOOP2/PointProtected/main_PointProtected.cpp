#include <iostream>
#include <cstdlib> //for abs
const double PI = 3.141592653589793; //pi

using std::cout;

void Friend(PointProtected& p);

class PointProtected {
protected:
	int x;
	int y;

public:
	PointProtected() : x(0), y(0) {
		cout << "PointProtected()\n";
	}
	PointProtected(int x, int y = 0) : x(x), y(y) {
		cout << "PointProtected(int x, int y = 0)\n";
	}
	PointProtected(const PointProtected& origin) : x(origin.x), y(origin.y) {
		cout << "PointProtected(const PointProtected& origin)\n";
	}
	~PointProtected() {
		cout << "~PointProtected()\n";
	}

	void Move(int dx, int dy) {
		x += dx;
		y += dy;
	}
	void SetXY(int x, int y) {
		this->x = x;
		this->y = y;
	}
	int GetX() const {
		return x;
	}
	int GetY() const {
		return y;
	}
	void ShowPoint() const {
		cout << x << "; " << y << '\n';
	}
	int SquareDist_FromOrigin() const {
		return abs(x * x + y * y);
	}
	int SquareDist_TwoPoints(const PointProtected& second) const;
	friend void Friend(PointProtected& p);
};

int PointProtected::SquareDist_TwoPoints(const PointProtected& second) const {
	return abs((x * x + y * y) - (second.x * second.x + second.y * second.y));
}

void Friend(PointProtected& p) {
	cout << p.x << ' ' << p.y << ' '; //friend function has access to protected and private p`s fields, even outside the class
	cout << "I am friend\n";
}

class Circle {
public:
	PointProtected p;
	int r; //radius

	Circle() : r(0) {
		//p already created
		//r = 0;
		cout << "Circle()\n";
	}
	Circle(int x, int y, int r = 0) : p(x, y), r(r) {
		//cause p already created we can't change it`s protected or private fields directly
		//p.SetXY(x, y);
		//this->r = r;
		cout << "Circle(int x, int y, int r = 0) : PointPublic(x, y)\n";
	}
	Circle(const Circle& origin) : p(origin.p), r(origin.r) {
		//p.SetXY(origin.p.x, origin.p.y); //can`t cause x and y is protected fields
		//p.SetXY(origin.p.GetX(), origin.p.GetY()); //now it`s okay
		//r = origin.r;
		cout << "Circle(const Circle& origin) : PointPublic(origin)\n";
	}
	~Circle() {
		cout << "~Circle()\n";
	}

	double Area() const {
		return PI * r * r;
	}

};


int main() {
	Circle a;
	cout << a.p.GetX() << a.p.GetY() << '\n';


	return 0;
}