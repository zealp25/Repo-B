using System;
using SharedLibrary;

namespace ProjectB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project B says: " + MyLibraryClass.GetMessage());
        }
    }
}
