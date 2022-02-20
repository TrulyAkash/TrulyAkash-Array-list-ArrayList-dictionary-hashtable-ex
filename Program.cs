using System;
namespace ArrayListDemo
{
    class LIistDemo
    {
        static void Main(string[] args)
        {

            List<int> x = new List<int>();
            x.Add(1);
            x.Add(20);
            x.Add(30);
            x.Add(40);
            x.Add(50);
            foreach (int i in x)
                Console.WriteLine(i);
            Console.WriteLine(x.Capacity);
            Console.WriteLine(x.Count);
            Dictionary<int,string> y = new Dictionary <int,string>();
            y.Add(1, "ram");
            y.Add(2, "shyam");
            y.Add(5, "gita");
            Console.WriteLine(y.Count);
           
            foreach(int i in y.Keys)
                Console.WriteLine(y[5]);

        }
    }
}