using System;

namespace program
{
    public class A
    {
        internal int i = 10;
    }

    public class B : A
    {
        protected internal int j = 20;
    }

    public class PrintA
    {
        public PrintA(ref int r)
        {
            r = 60;
        }

        internal int printA;
    }

    public class PrintB
    {
        protected internal int prints = 5;

        public PrintB(out string o)
        {
            o = "Try harder!";
        }
    }

    public class Alpha
    {
        protected static string s = "This is a string";

        protected Alpha()
        {
            s += "alpha ";
        }
    }

    public class SubAlpha : Alpha
    {
        public SubAlpha()
        {
            s += "sub";
        }
    }

    public class SubSubAlpha : Alpha
    {
        public SubSubAlpha()
        {
            s += "subsub ";
        }

        public static void printI(A a1)
        {
            Console.WriteLine(a1.i);
        }

        public static void printJ(B b1)
        {
            Console.WriteLine(b1.j);
        }
    }

    public static void Main(string[] args)
    {
        A a = new A();
        a.i = 21;

        B b = new B();
        b.j = 25;

        printI(a); // Prints the value of a.i
        printI(b); // Prints the value of b.j
        printJ(b); // Prints the value of b.j

        Console.WriteLine(s); // Prints the value of s
        Console.WriteLine("Find the output");

        s = null; // Resets the value of s to null
        new SubSubAlpha(); // Instantiates SubSubAlpha, which appends "subsub" to s
        Console.WriteLine(s); // Prints the current value of s

        PrintA pa = new PrintA(ref a.i); // Instantiates PrintA, setting a.i to 60
        Console.WriteLine("printA = " + pa.printA); // Prints the value of pa.printA

        PrintB pb = new PrintB(out string s); // Instantiates PrintB, setting s to "Try harder!"
        Console.WriteLine("Out output = " + s); // Prints the value of s

        Console.WriteLine("printA = " + pa.printA); // Prints the value of pa.printA
        Console.WriteLine("Ref output = " + a.i); // Prints the current value of a.i
        Console.WriteLine("prints = " + pb.prints); // Prints the value of pb.prints
    }
}