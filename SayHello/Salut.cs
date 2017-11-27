namespace SayHello
{
    using System;

    class Salut
    {
        static void Main()
        {
            var name = Console.ReadLine();

            SayHello(name);
        }

        static void SayHello(string name)
        {
            var greeting = string.Format("Hello, {0}!",name);

            Console.WriteLine(greeting);
        }
    }
}
