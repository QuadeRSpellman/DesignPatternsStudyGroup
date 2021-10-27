using System;

namespace Pattern_1_Singleton.LazyThreadSafe
{
    public class SingletonLazy
    {
        //Lazy<T> with lambda this will be thread safe and should perform well
        private static readonly Lazy<SingletonLazy> Safe = new(() => new SingletonLazy());

        //Public property that will initialize the instance
        public static SingletonLazy Instance => Safe.Value;

        //Private constructor with no parameters
        private SingletonLazy()
        {
            Console.WriteLine("Sample2 Lazy: Executed Singleton");
        }
    }
}
