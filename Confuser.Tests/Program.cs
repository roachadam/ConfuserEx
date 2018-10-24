using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Confuser.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 100;
            int mod  = 1999;
            int xor = id ^ mod;
            Console.WriteLine(xor ^ mod);
            Console.WriteLine($"calling {Assembly.GetCallingAssembly().FullName}");
            Console.WriteLine($"entry {Assembly.GetEntryAssembly().FullName}");
            Console.WriteLine($"executing {Assembly.GetExecutingAssembly().FullName}");
            Console.WriteLine($"asm {Assembly.GetAssembly(typeof(Program)).FullName}");
            if(Assembly.GetCallingAssembly() != Assembly.GetExecutingAssembly())
                Console.WriteLine("invoked!");


            foreach(ProcessModule mods in Process.GetCurrentProcess().Modules)
                if(mods.ModuleName.ToLower().Contains("dnlib"))
                    Console.WriteLine("adsfkjbadsfjkh");
            Console.Read();
        }
    }
}
