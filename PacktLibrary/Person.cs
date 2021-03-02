using System;
using static System.Console;

namespace Packt.Shared
{
    public class Person : Object
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;

        // methods
        public void WriteToConsole(string text)
        {
            WriteLine(text);
        }

        public string GetOrignin()
        {
            return "stuff";
        }

    }
}
