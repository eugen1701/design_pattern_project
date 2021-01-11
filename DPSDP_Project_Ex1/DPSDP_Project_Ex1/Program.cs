using System;

namespace DPSDP_Project_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.enqueue(3);
            q.enqueue(4);
            q.enqueue(5);
            foreach (int elem in q)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();
        }
    }
}