using System;
using System.Runtime.CompilerServices;

namespace exam._5._Abstractions
{
    
    public static class Delegates
    {
        
        // DELEGATE
        private delegate void MyDelegate();
        private static Action _myAction;
        
        // ASSOCIATION
        private static class Methods
        {
            public static void Method1()
            {
                Console.WriteLine("Method1");
            }

            public static void Method2()
            {
                Console.WriteLine("Method2");
            }

            public static void Method3(Action myAction)
            {
                Console.WriteLine("Action from method call:");
                myAction();
            }
        }
        
        // TEST
        public static void Test()
        {
            MyDelegate myDelegate = Methods.Method1;
            myDelegate += Methods.Method2;
            myDelegate();
            
            _myAction = () => { Console.WriteLine("Hello Action!"); };
            _myAction();
            Methods.Method3(_myAction);
        }
        
    }
    
}