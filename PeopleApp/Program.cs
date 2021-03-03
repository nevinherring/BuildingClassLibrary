﻿using System;
using Packt.Shared;
using static System.Console;
namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            WriteLine(bob.ToString());
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth
            );
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            WriteLine(format: "{0}'s favorite wonder is {1}.  Its integer is {2}.",
            arg0: bob.Name,
            arg1: bob.FavoriteAncientWonder,
            arg2: (int)bob.FavoriteAncientWonder
            );
            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // bob.BucketList = (WondersOfTheAncientWorld)18;
            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Zoe" });
            WriteLine(
                $"{bob.Name} has {bob.Children.Count} children:"
            );
            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($" {bob.Children[child].Name}");
            }
            var alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };
            WriteLine(
                format: "{0} was born {1:dd MMM yy}",
                arg0: alice.Name,
                arg1: alice.DateOfBirth
            );
        }
    }
}
