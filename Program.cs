using System;
using System.Collections;        //for hash table and array list

namespace ArrayListDemo
{
    class LIistDemo
    {
        static void Main(string[] args)
        {
            //Array
           Array b=new int[6] {2,3,12,33,45,56,};
            foreach(int i in b)
                Console.Write(i);
            Array m = new string[4] { "asd", "asre", "vcxz", "gklm" };
            foreach(string i in m)
                Console.Write(i);

            //list
            List<int> x = new List<int>();
            x.Add(1);
            x.Add(20);
            x.Add(30);
            x.Add(40);
            x.Add(50);
            foreach (int i in x)
                Console.Write(i);
            Console.WriteLine(x.Capacity);
            Console.WriteLine(x.Count);

            //arrayList
            ArrayList z = new ArrayList();
            z.Add(1);
            z.Add(20);
            z.Add("Amit");
            z.Add(2.4);
            z.Add('d');
            Console.WriteLine(z.Capacity);
            Console.WriteLine(z.Count);
            foreach(object i in z)
                Console.Write(i);

            //dictionary
            Dictionary<int,string> y = new Dictionary <int,string>();
            y.Add(1, "ram");
            y.Add(2, "shyam");
            y.Add(5, "gita");
            foreach(int i in y.Keys)
                Console.Write(y[i]);
            Console.WriteLine(y.Count);

            //hash table
            Hashtable h = new Hashtable();
            h.Add(1, 20);
            h.Add(5, "Raj");
            h.Add("A", "Akshay");
            h.Add("C", "Sunny");
            h.Add("B", 55);

            Console.WriteLine(h[1]);
            Console.WriteLine(h["A"]);

            foreach (DictionaryEntry i in h)
            {
                Console.WriteLine("{0} and {1} ", i.Key, i.Value);
            }
            Console.WriteLine(h.Count);
        }
    }
}