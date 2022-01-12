using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageJsonManager
{
    internal class Program
    {
        private const string greetingMessage = "Welcome To Package Manager CLI";

        static void Main(string[] args)
        {
            //TODO shelly <3
            // 1. prompt in the terminal the location of "package.json" file path in the system,  and load it to the instance
            // 2. now ask to update the "version" in the file
            // 3. save the file
            // 4. after you done this, add support to package.yaml and to the same thing
            Console.WriteLine(greetingMessage);
            Console.WriteLine("Please enter the file name:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the key:");
            string key = Console.ReadLine();
            Console.WriteLine("Please enter the value:");
            string value = Console.ReadLine();

            Console.WriteLine("fileName: {0} ", fileName);
            FileManager.UpdateObject(fileName, key, value);
           

        }
    }
}
