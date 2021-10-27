using System;
using Pattern_1_Singleton.Basic;

namespace Pattern_1_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var Test1_1 = SingletonTest1.Instance;
            var Test1_2 = SingletonTest1.Instance;

        }
    }
}
