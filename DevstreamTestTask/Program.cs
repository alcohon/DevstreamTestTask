using DevstreamTestTask.Design.Abstract;
using DevstreamTestTask.Design.Domain;
using DevstreamTestTask.ProblemSolving;
using DevstreamTestTask.Reflection;
using System;

namespace DevstreamTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //set speed below 20 to raise an Error for Bicycle instance
            Bicycle bicycle = new Bicycle("TestManufacturer1", "Test Bicycle name 1", 10.00m, Design.Enums.BicycleAcitvityType.Mountain, 29);


            //Task3
            //Create a console application which writes every Vehicle type name to the console, sorted alphabetically
            Console.WriteLine("All Vehicle types sorted alphabetically:");
            foreach (var item in InstanceService.GetInstances<Vehicle>().OrderBy(o => o.GetType().Name))
            {
                Console.WriteLine($"{item.GetType().Name}");
            }
            Console.WriteLine();

            //Create a method which can search for types by specifying part of the name
            Console.WriteLine("Search types with Pl keyword:");
            foreach (var item in InstanceService.SearchForInstances<Vehicle>("Pl"))
            {
                Console.WriteLine($"{item.GetType().Name}");
            }

            //Create a method which can write all instances returned from InstanceService.GetInstances() to disk
            InstanceService.WriteInstancesToDisc();
            Console.WriteLine();


            //Task 4
            //Create a method string ReverseString(string s) which returns a reversed version of the input string
            string str = "Reverse String WIth CuStom METHOD!!";
            Console.WriteLine($"{str}: {str.ReverseString()}");
            Console.WriteLine();

            //Create a method with the signature bool IsPalindrome
            string palindrome = "rotator";
            Console.WriteLine($"Is {palindrome} palindrome? {palindrome.IsPalindrome()}");

            string notpalindrome = "apple";
            Console.WriteLine($"Is {notpalindrome} palindrome? {notpalindrome.IsPalindrome()}");
            Console.WriteLine();

            //Create a method IEnumerable<int> MissingElements 
            int[] arr = { 2,3,4 };
            Console.WriteLine($"Find missing elements in sequence: {string.Join(", ", arr)}");
            IEnumerable<int> missingElems = arr.MissingElements();
            if (!missingElems.Any()) Console.WriteLine("There is no missing elements");
            foreach (var item in missingElems)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int[] arr1 = { 4, 6, 9 };
            Console.WriteLine($"Find missing elements in sequence: {string.Join(", ", arr1)}");
            foreach (var item in arr1.MissingElements())
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            int[] arr2 = { 1, 3, 4 };
            Console.WriteLine($"Find missing elements in sequence: {string.Join(", ", arr2)}");
            foreach (var item in arr2.MissingElements())
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}