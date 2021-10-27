using System;

namespace Pattern_1_Singleton.Basic
{
    /// <summary>
    /// This Class is a very basic singleton pattern and it is not thread safe
    /// </summary>
    public class SingletonTest1
    {
        //This object is a private instance and thus only initialized once
        private static SingletonTest1? _instance;

        //Public property allowing the caller to create a new instance if an instance has not already been created
        public static SingletonTest1 Instance
        {
            get
            {
                return _instance ??= new SingletonTest1();
            }
        }

        //private constructor with no parameters
        private SingletonTest1()
        {
            Console.WriteLine("Sample1: Executed Singleton");
        }
    }
}
