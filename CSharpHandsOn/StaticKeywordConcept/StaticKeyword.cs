using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.StaticKeywordConcept
{
    public interface staticInterface
    {
        int a
        {
            
            get;
            set;
        }
        void show();
    }
    public static class StaticKeyword
    {
       // int i = 10;
        static int a = 20;

        static StaticKeyword()
        {

        }

        public static void myMethod()
        {
            Console.WriteLine("Parent myMethod");
        }

        public static void genMethod()
        {
            
        }

        public static void genMethod(int i)
        {

        }
    }

    class StaticRunnerClass
    {
        public static void myMethod()
        {
            Console.WriteLine("Child myMethod");
        }

        public void show()
        {
            Console.WriteLine("Child class Show method");
        }

        public void show1()
        {
            Console.WriteLine("Child class Show1 method");
        }

        public static void Main()
        {
            //StaticKeyword sk = new StaticRunnerClass();
            StaticKeyword.myMethod();
            StaticRunnerClass.myMethod();

            StaticRunnerClass sr = new StaticRunnerClass();
            sr.show();
            sr.show1();
            //staticInterface  si = new StaticRunnerClass();
            //si.show();
           // si.show1(); //interface reference type cannot access the implementing class's unique methods.
            Console.ReadLine();

            //StaticKeyword sk = new StaticKeyword(); //Cannot create instance/objects of the static class.
        }
    }
}
