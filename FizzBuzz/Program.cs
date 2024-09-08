// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         for (int i = 1; i <= 100; i++)
//         {
//             if (i % 15 == 0) Console.WriteLine($"{i}-FizzBuzz");
//             else if (i % 5 == 0) Console.WriteLine($"{i}-Buzz");
//             else if (i % 3 == 0) Console.WriteLine($"{i}-Fizz");
//             else Console.WriteLine(i);
//         }
//     }
// }

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int current = 0;

        do
        {
            current = random.Next(1, 11);
            Console.WriteLine(current);
        }
        while (current != 7);
    }
}