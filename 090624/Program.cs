﻿// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }
// Console.WriteLine($"{employeeName}, {title}");

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }
// Console.WriteLine($"{employeeName}, {title}");

/*

CHALLENGE: Convert if-elif-esle to switch statement 

*/
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         string sku = "01-MN-L";

//         string[] product = sku.Split('-');

//         string type = "";
//         string color = "";
//         string size = "";

// /////// type of product
// ///
// /*              if (product[0] == "01")
//         {
//             type = "Sweat shirt";
//         }
//         else if (product[0] == "02")
//         {
//             type = "T-Shirt";
//         }
//         else if (product[0] == "03")
//         {
//             type = "Sweat pants";
//         }
//         else
//         {
//             type = "Other";
//         }
// */
//         switch (product[0])
//         {
//             case "01":
//                 type = "Sweat shirt";
//                 break;
//             case "02":
//                 type = "T-Shirt";
//                 break;
//             case "03":
//                 type = "Sweat Pants";
//                 break;
//             default:
//                 type = "Other";
//                 break;
//         }


// //////// color of product
// ///
// /*        if (product[1] == "BL")
//         {
//             color = "Black";
//         }
//         else if (product[1] == "MN")
//         {
//             color = "Maroon";
//         }
//         else
//         {
//             color = "White";
//         }
// */
//         switch(product[1])
//         {
//             case "BL":
//                 color = "Black";
//                 break;
//             case "MN":
//                 color = "Maroon";
//                 break;
//             default:
//                 color = "White";
//                 break;

//         }


// //////////// size of product
// ///
// /*        if (product[2] == "S")
//         {
//             size = "Small";
//         }
//         else if (product[2] == "M")
//         {
//             size = "Medium";
//         }
//         else if (product[2] == "L")
//         {
//             size = "Large";
//         }
//         else
//         {
//             size = "One Size Fits All";
//         }
// */
//         switch(product[2])
//         {
//             case "S":
//                 size = "Small";
//                 break;
//             case "M":
//                 size = "Medium";
//                 break;
//             case "L":
//                 size = "Large";
//                 break;
//             default:
//                 size = "One Size Fits Most";
//                 break;
//         }



//         Console.WriteLine($"Product: {size} {color} {type}");
//     }
// }


//////////////////   FOR STATEMENTS   /////////////////////////
///


internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }


        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7) break;
        }

        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }

        Console.WriteLine();
        
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "David")
            {
                names[i] = "Sammy";
            }
        }

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}