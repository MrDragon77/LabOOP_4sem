using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP8_sharp
{
    public class MyList<T> : IEnumerable<T> where T : ISaveable<T>
    {
        protected class Node<T>
        {
            public T data { get; set; }
            public Node<T> next { get; set; }
            public Node<T> prev { get; set; }
            public Node() { }
            public Node(T data)
            {
                this.data = data;
            }
        }
        protected int listSize;
        protected Node<T> curNode;
        protected Node<T> head;
        protected Node<T> tail;

        public MyList()
        {
            listSize = 0;
            curNode = null;
            head = null;
            tail = null;
        }
        ~MyList() {
            while(size() > 0)
            {
                DeleteCurrent();
            }
        }
        public virtual void push_back(T elem)
        {
            Node<T> newNode = new Node<T>();
            newNode.next = null;
            newNode.data = elem;
            if (head != null)
            {
                newNode.prev = tail;
                tail.next = newNode;
                tail = newNode;
            }
            else
            {
                newNode.prev = null;
                head = tail = newNode;
            }
            listSize++;
            curNode = newNode;
        }
        public virtual void push_front(T elem)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = elem;
            if (head != null)
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            else
            {
                newNode.next = null;
                head = tail = newNode;
            }
            newNode.prev = null;
            listSize++;
            curNode = newNode;
        }
        public virtual void insert(T elem)
        {
            if (curNode == tail)
                push_back(elem);
            else if (curNode == head)
                push_front(elem);
            else
            {
                Node<T> nextNode = curNode.next;
                Node<T> newNode = new Node<T>();
                newNode.data = elem;
                curNode.next = newNode;
                newNode.prev = curNode;
                newNode.next = nextNode;
                nextNode.prev = newNode;
                curNode = newNode;
                listSize++;
            }
        }
        void getByPos(int pos)
        {
            if (pos >= listSize - 1)
                curNode = tail;
            else if (pos <= 0)
                curNode = head;
            else
            {
                int listPos = 0;
                curNode = head;
                while (listPos != pos)
                {
                    curNode = curNode.next;
                    listPos++;
                }
            }
        }
        public virtual void insertByPos(T elem, int pos)
        {
            getByPos(pos);
            insert(elem);
        }
        public virtual bool Find(T elem)
        {
            curNode = head;
            int listPos = 0;
            while (curNode != null && curNode.data.Equals(elem) == false)
            {
                curNode = curNode.next;
                listPos++;
            }
            if (curNode == null)
            {
                return false;
            }
            return true;
        }
        public virtual void DeleteCurrent()
        {
            if (head != null)
            {
                if (curNode == head)
                {
                    if (curNode == tail)
                    {
                        head = null;
                        tail = null;
                        curNode = null;
                    }
                    else
                    {
                        head = curNode.next;
                        head.prev = null;
                        curNode = head;
                    }
                }
                else if (curNode == tail)
                {
                    tail = curNode.prev;
                    curNode = tail;
                    tail.next = null;
                }
                else
                {
                    curNode.prev.next = curNode.next;
                    curNode.next.prev = curNode.prev;
                    curNode = curNode.next;
                }
                listSize--;
            }
        }
        public virtual void Delete(T elem)
        {
            if(Find(elem))
            {
                DeleteCurrent();
            }
        }
        public virtual void DeleteAtPos(int pos)
        {
            getByPos(pos);
            DeleteCurrent();
        }
        public T getData()
        {
            return curNode.data;
        }
        public int size()
        {
            return listSize;
        }
        public void to_begin()
        {
            getByPos(0);
        }
        public void to_end()
        {
            getByPos(listSize - 1);
        }
        public bool next()
        {
            if(curNode == null)
            {
                return false;
            }
            if (curNode.next != null)
            {
                curNode = curNode.next;
                return true;
            }
            return false;
        }
        public bool prev()
        {
            if (curNode == null)
            {
                return false;
            }
            if (curNode.prev != null)
            {
                curNode = curNode.prev;
                return true;
            }
            return false;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T>? current = head;
            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }
        public void SaveElements(string filename)
        {
            if (size() == 0)
            {
                return;
            }
            StreamWriter file = new StreamWriter(filename);
            file.WriteLine(head.data.GetType().ToString().Split('.')[0]);
            file.WriteLine("size: " + size().ToString());
            to_begin();

            getData().Save(file);

            while (next())
            {
                getData().Save(file);
            }
            file.Close();
        }
        public bool LoadElements(string filename, CFactory<T> factory)
        {
            StreamReader file = new StreamReader(filename);
            string type = file.ReadLine();
            if (type != factory.GetObjectType())
            {
                file.Close();
                return false;
            }

            while (size() > 0)
            {
                DeleteCurrent();
            }

            string[] sizeArgs = file.ReadLine().Split(' ');
            int numOfElems = Int32.Parse(sizeArgs[1]);
            for (int i = 0; i < numOfElems; ++i)
            {
                T elem = factory.CreateObject(file.ReadLine());
                if (elem == null)
                {
                    return false;
                }
                elem.Load(file, factory);
                push_back(elem);
            }
            file.Close();
            return true;
        }

    }
}
