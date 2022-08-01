using System;

namespace Finalizer_Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeSomeGarbeg();
            Console.WriteLine($"Memory Used Befor Collection {GC.GetTotalMemory(false):N0}"); //8,555,888
            GC.Collect(); // Explicit Cleaning
            Console.WriteLine($"Memory Used after Collection {GC.GetTotalMemory(true):N0}");
            Console.ReadKey();
        }

        static void MakeSomeGarbeg()
        {
            Version v;
            for (int i = 0; i < 1000; i++)
            {
                v = new Version();
            }
        }
    }


}
