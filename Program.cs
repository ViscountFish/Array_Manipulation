using System;
using System.Linq;

class Array_Manipulation
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        // Input: Ask the user to enter elements of the array
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Menu: Provide options for manipulating and querying the array
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Find the minimum number");
            Console.WriteLine("2. Find the maximum number");
            Console.WriteLine("3. Calculate the sum and average");
            Console.WriteLine("4. Reverse the array");
            Console.WriteLine("5. Sort the array");
            Console.WriteLine("6. Add a new element to the array");
            Console.WriteLine("7. Remove an element from the array");
            Console.WriteLine("8. Display the array");
            Console.WriteLine("9. Exit");

            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    // Find the minimum number
                    int min = numbers.Min();
                    Console.WriteLine($"Minimum number: {min}");
                    break;

                case 2:
                    // Find the maximum number
                    int max = numbers.Max();
                    Console.WriteLine($"Maximum number: {max}");
                    break;

                case 3:
                    // Calculate sum and average
                    int sum = numbers.Sum();
                    double average = numbers.Average();
                    Console.WriteLine($"Sum: {sum}, Average: {average}");
                    break;

                case 4:
                    // Reverse the array
                    Array.Reverse(numbers);
                    Console.WriteLine("Array reversed.");
                    break;

                case 5:
                    // Sort the array
                    Array.Sort(numbers);
                    Console.WriteLine("Array sorted.");
                    break;

                case 6:
                    // Add a new element to the array
                    Console.Write("Enter the new element to add: ");
                    int newElement = int.Parse(Console.ReadLine());
                    numbers = AddElement(numbers, newElement);
                    Console.WriteLine($"Element {newElement} added.");
                    break;

                case 7:
                    // Remove an element from the array
                    Console.Write("Enter the element to remove: ");
                    int elementToRemove = int.Parse(Console.ReadLine());
                    numbers = RemoveElement(numbers, elementToRemove);
                    Console.WriteLine($"Element {elementToRemove} removed (if it existed).");
                    break;

                case 8:
                    // Display the array
                    Console.WriteLine("Array contents: " + string.Join(", ", numbers));
                    break;

                case 9:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Method to add an element to the array
    static int[] AddElement(int[] arr, int element)
    {
        int[] newArray = new int[arr.Length + 1];
        Array.Copy(arr, newArray, arr.Length);
        newArray[arr.Length] = element;
        return newArray;
    }

    // Method to remove an element from the array
    static int[] RemoveElement(int[] arr, int element)
    {
        return arr.Where(x => x != element).ToArray();
    }
}
