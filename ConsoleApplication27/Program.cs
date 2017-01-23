using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    public class A
    {
        public void Metoda1() { Console.WriteLine("A Metoda1()"); }
        public virtual void Metoda2() { Console.WriteLine("A Metoda2()"); Metoda3(); }
        public virtual void Metoda3() { Console.WriteLine("A Metoda3()"); }
    }

    public class B : A
    {
        public void Metoda1() { Console.WriteLine("B Metoda1()"); }
        public virtual void Metoda2() { Console.WriteLine("B Metoda2()"); Metoda1(); }
        public override void Metoda3() { Console.WriteLine("B Metoda3()"); }
    }

    public class C : B
    {
        public override void Metoda2() { Console.WriteLine("C Metoda2()"); }
    }

    public class D : C
    {
        public void Metoda1() { Console.WriteLine("D Metoda1()"); }
        public override void Metoda2() { Console.WriteLine("D Metoda2()"); Metoda3(); }
        public override void Metoda3() { Console.WriteLine("D Metoda3()"); }
    }

    public abstract class E : D
    {
        public virtual void Metoda2() { Console.WriteLine("E Metoda2()"); }
        public abstract void Metoda3();
    }

    public class F : E
    {
        public override void Metoda2() { Console.WriteLine("F Metoda2()"); }
        public override void Metoda3() { Console.WriteLine("F Metoda3()"); }
    }

    public abstract class G : F
    {
        public virtual void Metoda2() { Console.WriteLine("G Metoda2()"); }
        public abstract void Metoda3();
    }

    public class H : G
    {
        public void Metoda1() { Console.WriteLine("H Metoda1()"); }
        public override void Metoda2() { Console.WriteLine("H Metoda2()"); }
        public override void Metoda3() { Console.WriteLine("H Metoda3()"); }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tu jest wynik:");
            //tu wkleić kod
            Console.ReadKey();
 
        }
    }
}
