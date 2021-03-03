using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : Object
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;

        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>();

        // constants
        public const string Species = "Homo Sapien";

        // read-only fields
        public readonly string HomePlanet = "Earth";

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
