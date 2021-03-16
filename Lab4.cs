using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // LAB 4 - PART 1
            // Located below with the AddFirst method within the LinkedList class

            // LAB 4 - PART 2
            var list1 = new LinkedList<int>();
            list1.AddFirst(100);
            list1.AddFirst(200);
            list1.AddFirst(300);
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }

            // LAB 4 - PART 3
            var list2 = new LinkedList<string>();
            list2.AddFirst("one");
            list2.AddFirst("two");
            list2.AddFirst("three");
            foreach (string i in list2)
            {
                Console.WriteLine(i);
            }

            // LAB 4 - PART 4
            var list3 = new LinkedList<Person>();
            list3.AddFirst(new Person("Alex", "Auburn"));
            list3.AddFirst(new Person("Bob", "Brown"));
            list3.AddFirst(new Person("Chuck", "Chimney"));
            foreach (Person i in list3)
            {
                Console.WriteLine(i.ToString());
            }

            Console.ReadLine();

        }

    }

    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedListNode<T> First { get; private set; }
        public LinkedListNode<T> Last { get; private set; }

        public LinkedListNode<T> AddLast(T node)
        {
            var newNode = new LinkedListNode<T>(node);
            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                newNode.Prev = Last;
                Last.Next = newNode;
                Last = newNode;
            }
            return newNode;
        }

        // LAB 4 - PART 1
        public LinkedListNode<T> AddFirst(T node)
        {

            var newNode = new LinkedListNode<T>(node);

            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                newNode.Next = First;
                First.Prev = newNode;
                First = newNode;
            }

            return newNode;

        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = First;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode(T value) =>
            Value = value;

        public T Value { get; }
        public LinkedListNode<T> Next { get; internal set; }
        public LinkedListNode<T> Prev { get; internal set; }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string f = "none", string l = "none")
        {
            FirstName = f;
            LastName = l;
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }


}

