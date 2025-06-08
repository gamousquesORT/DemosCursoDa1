using System;

namespace SingletonClassicCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor inicial {0}", GlobalCounter.Instance.Counter());
            GlobalCounter.Instance.Increment();
            Console.WriteLine("Valor inicial {0}", GlobalCounter.Instance.Counter());
            GlobalCounter.Instance.Increment();
            Console.WriteLine("Valor inicial {0}", GlobalCounter.Instance.Counter());

        }
    }
}