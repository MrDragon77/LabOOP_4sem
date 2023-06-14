#include <iostream>
#include <cstdlib> //for abs
const double PI = 3.141592653589793; //pi

using std::cout;

class PointPublic {
private:
	void PrivateMethod() {
		cout << "PRIVATE\n";
		//I am private
	}

protected:
	void ProtectedMethod() {
		cout << "PROTECTED\n";
		//I am protected
	}

public:
	int x;
	int y;

	PointPublic() {
		x = 0;
		y = 0;
		cout << "PointPublic()\n";
	}
	PointPublic(int x, int y = 0) {
		this->x = x;
		this->y = y;
		cout << "PointPublic(int x, int y = 0)\n";
	}
	/*PointPublic(int x = 0, int y = 0) { //can`t do this, cause there will be 2 similar constructors
		this->x = x;
		this->y = y;
		cout << "PointPublic(int x, int y = 0)\n";
	}*/
	PointPublic(const PointPublic& origin) {
		this->x = origin.x;
		this->y = origin.y;
		cout << "PointPublic(const PointPublic& origin)\n";
	}
	~PointPublic() {
		cout << "~PointPublic()\n";
	}

	void Move(int dx, int dy) {
		x += dx;
		y += dy;
	}
	void ShowPoint() const {
		cout << x << "; " << y << '\n';
	}
	int SquareDist_FromOrigin() const {
		return abs(x * x + y * y);
	}
	int SquareDist_TwoPoints(const PointPublic& second) const;
	void PrintX() {
		cout << "PrintX() in Base class " << x << '\n';
	}
	virtual void PrintY() {
		cout << "PrintY() in Base class " << y << '\n';
	}
};

int PointPublic::SquareDist_TwoPoints(const PointPublic& second) const {
	return abs((x * x + y * y) - (second.x * second.x + second.y * second.y));
}

class Circle1 : public PointPublic { //public: all public -> public, protected -> protected
//here available PointPublic`s public and protected methods
public:
	int r; //radius

	Circle1() : PointPublic() {
		r = 0;
		cout << "Circle1()\n";
	}
	Circle1(int x, int y, int r = 0) : PointPublic(x, y) {
		this->r = r;
		cout << "Circle1(int x, int y, int r = 0)\n";
	}
	Circle1(const Circle1& origin) : PointPublic(origin) {
		r = origin.r;
		cout << "Circle1(const Circle1& origin)\n";
	}
	~Circle1() {
		cout << "~Circle1()\n";
	}

	double Area() const {
		return PI * r * r;
	}
	void Method() {
		//PrivateMethod(); //can`t do this
		ProtectedMethod(); //can do
	}
	void PrintX() {
		cout << "PrintX() in Child class " << x << '\n';
	}
	void PrintY() {
		cout << "PrintY() in Child class " << y << '\n';
	}
};

class Elipse1 : public Circle1 {
public:
	void SomeMethod() {
		cout << r; //it`s okay
		cout << x; //it`s okay
		ProtectedMethod(); //it`s also okay
		//PrivateMethod(); //it` wrong
	}
};

class Circle2 : protected PointPublic { //protected: all public -> protected, protected -> protected
//here available PointPublic`s public and protected methods
public:
	int r; //radius

	Circle2() : PointPublic() {
		r = 0;
		cout << "Circle2()\n";
	}
	Circle2(int x, int y, int r = 0) : PointPublic(x, y) {
		this->r = r;
		cout << "Circle2(int x, int y, int r = 0)\n";
	}
	Circle2(const Circle2& origin) : PointPublic(origin) {
		r = origin.r;
		cout << "Circle2(const Circle2& origin)\n";
	}
	~Circle2() {
		cout << "~Circle2()\n";
	}

	double Area() const {
		return PI * r * r;
	}
};

class Elipse2 : public Circle2 {
public:
	void SomeMethod() {
		cout << r; //it`s okay
		cout << x; //it`s okay
		ProtectedMethod(); //it`s also okay
		//PrivateMethod(); //it` wrong
	}
};

class Circle3 : private PointPublic { //private: all public -> private, protected -> private
public:
	int r; //radius

	Circle3() : PointPublic() {
		r = 0;
		cout << "Circle3()\n";
	}
	Circle3(int x, int y, int r = 0) : PointPublic(x, y) {
		this->r = r;
		cout << "Circle3(int x, int y, int r = 0)\n";
	}
	Circle3(const Circle3& origin) : PointPublic(origin) {
		r = origin.r;
		cout << "Circle3(const Circle3& origin)\n";
	}
	~Circle3() {
		cout << "~Circle3()\n";
	}

	double Area() const {
		return PI * r * r;
	}
};

class Elipse3 : public Circle3 {
public:
	void SomeMethod() {
		cout << r; //it`s okay
		//cout << x; //it`s wrong now (it`s private in Circle3)
		//ProtectedMethod(); //and it`s wrong (it`s private in Circle3)
		//PrivateMethod(); //it` wrong
	}
};

int main() {
	cout << "STATIC.\n";
	{ //creates here
		PointPublic a;
		PointPublic b(4);
		PointPublic c(5, 4);
		PointPublic d(b);
		a.Move(1, 1);
		a.ShowPoint();
		b.ShowPoint();
		c.ShowPoint();
		d.ShowPoint();
		cout << a.SquareDist_FromOrigin() << '\n';

		Circle1 c1_1;
		Circle1 c1_2(1, 2);
		Circle1 c1_3(4, 56, 5);
		Circle1 c1_4(c1_2);
		c1_1.Move(1, 12); //available all PointPublic`s public mathods and Circle`s public methods
		c1_1.ShowPoint();
		c1_2.ShowPoint();
		c1_3.ShowPoint();
		c1_4.ShowPoint();
		cout << c1_2.Area() << '\n';

		Circle2 c2_1;
		Circle2 c2_2(1, 2);
		Circle2 c2_3(4, 56, 5);
		Circle2 c2_4(c2_2);
		//c2_1.Move(1, 12); //available only Circle`s public methods
		//c2_1.ShowPoint();
		//c2_2.ShowPoint();
		//c2_3.ShowPoint();
		//c2_4.ShowPoint();
		cout << c2_1.Area() << '\n';

		Circle3 c3_1;
		Circle3 c3_2(1, 2);
		Circle3 c3_3(4, 56, 5);
		Circle3 c3_4(c3_2);
		//c2_1.Move(1, 12); //available only Circle`s public methods
		//c2_1.ShowPoint();
		//c2_2.ShowPoint();
		//c2_3.ShowPoint();
		//c2_4.ShowPoint();
		cout << c3_1.Area() << '\n';

	} //deletes here
	
	cout << "\nDYNAMIC.\n";
	//creates here, manually
	PointPublic *a = new PointPublic;
	PointPublic *b = new PointPublic(4);
	PointPublic *c = new PointPublic(5, 4);
	PointPublic *d = new PointPublic(*b); //need *, cause b is pointer
	a->Move(1, 1);
	a->ShowPoint();
	b->ShowPoint();
	c->ShowPoint();
	d->ShowPoint();
	cout << a->SquareDist_FromOrigin() << '\n';

	Circle1 *c1_1 = new Circle1;
	Circle1 *c1_2 = new Circle1(1, 2);
	Circle1 *c1_3 = new Circle1(4, 56, 5);
	Circle1 *c1_4 = new Circle1(*c1_2);
	c1_1->Move(1, 12); //same 
	c1_2->ShowPoint(); //available all PointPublic`s public mathods and Circle`s public methods
	c1_2->ShowPoint();
	c1_3->ShowPoint();
	c1_4->ShowPoint();
	cout << c1_2->Area() << '\n';
	
	//deletes here, manually
	delete a;
	delete b;
	delete c;
	delete d;
	delete c1_1;
	delete c1_2;
	delete c1_3;
	delete c1_4;

	cout << "\nPARENT`S POINTER\n";
	PointPublic* ptr1 = new PointPublic;
	PointPublic* ptr2 = new Circle1;
	//Circle1* ptr3 = new PointPublic; //wrong
	ptr2->x; //only PointPublic`s public methods
	//we treating to Circle1 object as like it is a PointPublic object (parent object)

	delete ptr1; //cause ptr1 is PointPublic*, then only ~PointPublic() is called
	delete ptr2; //here also ptr2 is PointPublic*, so only ~PointPublic() is called, and no ~Circle1()
	//That`s incorrect, cause we could dynamically allocated memory in constructor and doesn`t called the destructor.

	cout << "\nVIRTUAL FUNCTIONS\n";
	PointPublic* ptrV1 = new PointPublic;
	ptrV1->PrintX(); //base
	ptrV1->PrintY(); //base
	PointPublic* ptrV2 = new Circle1;
	ptrV2->PrintX(); //base
	ptrV2->PrintY(); //child
	return 0;
}




//int Quater() const {
//	if (x > 0) {
//		if (y > 0) {
//			return 1;
//		}
//		else if (y < 0) {
//			return 4;
//		}
//		else {
//			return 0; //no one Quater - Point is on coordinate axis
//		}
//	}
//	else if (x < 0) {
//		if (y > 0) {
//			return 2;
//		}
//		else if (y < 0) {
//			return 3;
//		}
//		else {
//			return 0;
//		}
//	}
//	else {
//		return 0;
//	}
//}