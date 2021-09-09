using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Maximiliano", "4.364.951-6" , "16/05/1991");
            
            p.IntroduceYourself();
        }
    }
}
