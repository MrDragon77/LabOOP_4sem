#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

template<typename T>
class MyContainer {
public:
	T* buffer;
	unsigned int bufSize; //всего места
	unsigned int curSize; //занято места
	unsigned int curItemIndex; //индекс текущего элемент

	void Grow(unsigned int newSize) { //to increase size array (while x2)
		if (newSize <= bufSize) {
			return;
		}
		int newBufSize = (bufSize == 0 ? 1 : bufSize) * 2;
		while (newSize > newBufSize) {
			newBufSize *= 2;
		}
		T* newBuffer = new T[newBufSize];
		unsigned int i = 0;
		for (; i < bufSize; i++) {
			newBuffer[i] = buffer[i];
		}
		delete[] buffer;
		buffer = newBuffer;
		bufSize = newBufSize;
	}
	MyContainer() : buffer(nullptr), bufSize(0), curSize(0), curItemIndex(0) {
	
	}
	MyContainer(unsigned int size) : bufSize(size), curSize(0), curItemIndex(0) {
		if (size == 0) {
			buffer = nullptr;
		}
		else {
			buffer = new T[bufSize];
		}
	}
	MyContainer(const MyContainer& origin) : bufSize(origin.bufSize), curSize(origin.curSize), curItemIndex(origin.curItemIndex) {
		buffer = new T[bufSize];
		for (int i = 0; i < bufSize; i++) {
			buffer[i] = origin.buffer[i];
		}
	}
	~MyContainer() {
		delete[] buffer;
	}

	unsigned int getBufSize() const {
		return bufSize;
	}
	unsigned int getCurSize() const {
		return curSize;
	}
	unsigned int getCurItemIndex() const {
		return curItemIndex;
	}
	T getCurItem() const {
		return buffer[curItemIndex];
	}
	void Add(unsigned int index, const T& object) { //добавление по index (вклинивая)
		if (index > curSize) {
			return;
		}
		Grow(curSize + 1);
		//if (index >= curSize) {
		//	curSize = index + 1;
		//}
		if (curSize > 0) {
			bool zero = false;
			for (unsigned int i = curSize - 1; !zero && i >= index; i--) {
				buffer[i + 1] = buffer[i];
				if (i == 0) {
					zero = true;
				}
			}
		}
		buffer[index] = object;
		curSize++;
	}
	void PushBack(const T& object) {
		//Grow(++curSize);
		//
		//buffer[curSize - 1] = object;
		Add(curSize, object);
	}
	void PushFront(const T& object) {
		Add(0, object);
	}
	void Del(unsigned int index) {
		if (curSize == 0 || index >= curSize) {
			return;
		}
		for (unsigned int i = index; i < curSize - 1; i++) {
			buffer[i] = buffer[i + 1];
		}
		curSize--;
	}
	void setObject(unsigned int i, const T &object) {
		if (i >= curSize) {
			return;
		}
		buffer[i] = object;
	}
	T getObject(unsigned int i) {
		if (i >= curSize) {
			return NULL;
		}
		return buffer[i];
	}
	void next() {
		if (curItemIndex < curSize - 1) {
			curItemIndex++;
		}
	}
	void prev() {
		if (curItemIndex > 0) {
			curItemIndex--;
		}
	}
	void first() {
		curItemIndex = 0;
	}
	void last() {
		if (curSize > 0) {
			curItemIndex = curSize - 1;
		}
		else {
			curItemIndex = curSize;
		}
	}

	//void PrintContainerInt() {
	//	for (int i = 0; i < curSize; i++) {
	//		cout << buffer[i] << ' ';
	//	}
	//}
};

class MyObject {
public:
	int field;

	MyObject() : field(0) {

	}
	MyObject(int it) : field(it) {

	}
	MyObject(const MyObject &origin) : field(origin.field) {

	}
	~MyObject() {

	}
};

MyObject* createNewObject(int it) {
	return new MyObject(it);
}

int main() {
	{
	srand(time(nullptr));
	MyContainer<int> storage;

	for (int it = 0; it < 100; it++) {
		int randAction = rand() % 10;
		switch (randAction) {
		case 0: //add
			storage.Add(storage.getCurItemIndex(), it);
			break;
		case 1: //pushBack
			storage.PushBack(it);
			break;
		case 2: //pushFront
			storage.PushFront(it);
			break;
		case 3: //Del
			storage.Del(storage.getCurItemIndex());
			break;
		case 4: //setObject
			storage.setObject(storage.getCurItemIndex(), it);
			break;
		case 5: //getObject
			storage.getObject(storage.getCurItemIndex());
			break;
		case 6: //next
			storage.next();
			break;
		case 7: //prev
			storage.prev();
			break;
		case 8: //first
			storage.first();
			break;
		case 9: //last
			storage.last();
			break;
		}

		cout << it << " : " << randAction << ") " << storage.getCurItemIndex() << " : ";
		for (int i = 0; i < storage.getCurSize(); i++) {
			cout << storage.getObject(i) << ' ';
		}
		cout << '\n';
	}

	//for (int i = 0; i < 10; i++)
	//	storage.PushBack(i);
	//
	//for (int i = 0; i < 10; i++)
	//	cout << storage.getObject(i);

	//storage.Grow(20);
	//cout << storage.getBufSize() << endl;
	//storage.Grow(40);
	//cout << storage.getBufSize() << endl;
	//storage.Grow(140);
	//cout << storage.getCurSize() << endl;
	//cout << storage.getObject(150) << endl;
	//cout << storage.getCurSize() << endl;


	MyContainer<MyObject> storage2;
	cout << "SizeData: " << storage2.getCurSize() << ' ' << storage2.getBufSize() << endl;
	storage2.PushBack(*(new MyObject(1)));
	cout << "SizeData: " << storage2.getCurSize() << ' ' << storage2.getBufSize() << endl;
	storage2.Add(0, *(new MyObject(2)));
	cout << "SizeData: " << storage2.getCurSize() << ' ' << storage2.getBufSize() << endl;
	storage2.PushFront(*(new MyObject(3)));
	storage2.PushFront(*(new MyObject(4)));
	storage2.PushFront(*(new MyObject(5)));
	for (int i = 0; i < storage2.getCurSize(); i++) {
		cout << storage2.getObject(i).field << ' ';
	}
	
	for(storage2.first(); )
	cout << endl;
	storage2.Del(3);
	cout << "SizeData: " << storage2.getCurSize() << ' ' << storage2.getBufSize() << endl;

	}
	return 0;
}