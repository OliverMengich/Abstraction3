using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndEncapsulation3
{
    
    class Program:MyClass
    {
        static int cnt = 4;
        static void Main(string[] args)
        {
            cnt = cnt + 6;
            Console.WriteLine(cnt);

            MyClass myClass = new MyClass();
            myClass.Name = 2;
            Program p = new Program();
            p.Name = 4;
            Myclass2 myclass2 = new Myclass2();
            myclass2.Name2 = 67;
            Console.WriteLine(myclass2.Name2);
            Console.Read();
        }
    }
    class MyClass: Myclass2
    {
        public void MyMethod()
        {
            Myclass2 myclass2 = new Myclass2();
            myclass2.Name2 = 34;
            Console.WriteLine(Name2);
        }
        internal int Name;
    }
    class Myclass2
    {
        protected internal int Name2;
        
       // protected internal means it can access anyway in the same assembly and in the class
       // A class in an assembly can be able to use the Variable
    }
}
