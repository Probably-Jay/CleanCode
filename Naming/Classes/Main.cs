using System;
using System.Collections.Generic;
using System.Diagnostics;
using Naming.Terrible;

namespace Naming.Better
{
    class Program
    {
        static void Main(string[] args)
        {
            var registry = new UserRegistryBadNames();
            registry.AddUser("John", "Doe", new DateTime(1989,5,6));
        }
    }

}