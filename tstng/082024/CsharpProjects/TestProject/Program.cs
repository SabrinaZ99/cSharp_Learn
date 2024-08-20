///////
///  VAR SCOPE PRACTICE
///  8-20-24
///////////////////////////////////////////////////////////////////

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         bool flag = true;
//         int value = 55;
//         if (flag)
//         {
//             value = 10;
//             Console.WriteLine($"Inside the code block: {value}");
//         }
//         Console.WriteLine($"Outside the code block: {value}");

//     }
// }


///////////////////////////////////////////////////////////////
/// IF-ELSE syntax practice

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         bool flag = true;
//         if (flag)
//             Console.WriteLine(flag);
//         else
//             Console.WriteLine("u just lost the game");
//     }
// }
//////////////////////////////////////////////////////////////////
/// VAR SCOPE CHALLENGE ACTIVITY

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int[] numbers = { 4, 8, 15, 16, 23, 42 };
//         bool found = false;
//         int total = 0;
//         foreach (int number in numbers)
//         {
//             total += number;
//             if (number == 42)
//                 found = true;
//         }

//         if (found)
//             Console.WriteLine("Set contains 42");

//         Console.WriteLine($"Total: {total}");
//     }
// }


/////////////////////////////////////////////////////////////
/// Code Flow branching w/switch-case construct