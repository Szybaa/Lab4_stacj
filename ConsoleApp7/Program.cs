using System;
using System.Collections; //do uzywania array
using System.Collections.Generic; //do uzywania dicitoniary 
using System.Collections.Immutable; //do uzywania objects
using System.Collections.Concurrent; //do uzywania wielu watkow


namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add("Janek");  //dodanie
            list.Add("Jacek");
            list.Add("Jarek");
            list.Add("Arek");
            foreach (var item in list)  //iteracja
            {
                Console.WriteLine("List: "+item);
            }
            list.Remove("Arek");    //usuniecie

            Console.WriteLine();
            Console.WriteLine("Po usunieciu Arka");
            foreach (var item in list)
            {
                Console.WriteLine("List: " + item);
            }
            Console.WriteLine();

            Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
            dictionary1.Add("Peter Parker","Spiderman");
            dictionary1.Add("Tony Stark", "Iron Man");
            dictionary1.Add("Steve Rogers", "Kapitan Ameryka");
            dictionary1.Remove("Steve Rogers");

            foreach (var hero in dictionary1)
            {
                Console.WriteLine("{0}:{1}", hero.Key, hero.Value);
            }
            Console.WriteLine();

            Hashtable dictionary2 = new Hashtable();
            dictionary2.Add(1, "Pies"); //dodanie
            dictionary2.Add(2, "Kot");
            dictionary2.Add(3, "Yziak");
            dictionary2.Remove(3); //usuniece


            foreach (DictionaryEntry hash in dictionary2)
            {
                Console.WriteLine("Key: {0}, Value: {1}", hash.Key, hash.Value);
            }

            Queue queue = new Queue();
            queue.Enqueue(1);      //dodanie
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();    //usuniece
            foreach (var q in queue)  //iteracja
            {
                Console.WriteLine("queue: "+q);
            }
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();

            foreach (var item in stack)
                Console.Write(item + ",");

            Console.WriteLine();
         
            Vector<string> dynamicArray = new Vector<string>();
            dynamicArray[0] = "item0";
            dynamicArray[2] = "item2";
            dynamicArray[10] = "item10";
            dynamicArray[10] = null;
            /*foreach (var da in list2)
            {
                Console.WriteLine( da);
            }
            */


        }
        class Vector<T>
        {
            Dictionary<int, T> list2;

            public Vector()
            {
                this.list2 = new Dictionary<int, T>();
               
            }

            public T this[int index]
            {
                get
                {
                    if (list2.ContainsKey(index))
                        return list2[index];
                    else return default(T);
                }
                set
                {
                    if (list2.ContainsKey(index))
                    {
                        list2[index] = value;
                    }
                    else
                    {
                        list2.Add(index, value);
                        list2.Remove(index);
                    }
                }

            }
        }
    }
}
