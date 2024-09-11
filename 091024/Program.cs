////////////////// TryParse() Method ///////////////////
///
// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");



//////////// Challenge Activity: Combine string array values as strings AND integers /////////////////
///
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// decimal result = 0;
// string resultString = "";

// foreach(string strValue in values)
// {
//     if(decimal.TryParse(strValue, out decimal value)) result += value;
//     else resultString += strValue;
// }

// Console.WriteLine(resultString);
// Console.WriteLine(result);


////////////////////////// Sort() and Reverse() ///////////////////////////////////
///
// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//////////////////// Explore Clear() and Resize() ////////////////////////////////////
///

// // Clear()
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// // Console.WriteLine($"Before: {pallets[0]}");
// // Array.Clear(pallets, 0, 2);
// // Console.WriteLine($"After: {pallets[0]}");
// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// // Console.WriteLine($"After: {pallets[0].ToLower()}");
// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// // resize()
// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//////////////// Split() and Join() //////////////////////////////
///
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// foreach (char valueChar in valueArray)
// {
//     Console.WriteLine(valueChar);
// }
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// // Console.WriteLine(result);

// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }


////////// Reverse letters in each word  challenge activity /////
string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramArray = pangram.Split(' ');
string[] newPangram = new string[pangramArray.Length];


for (int i = 0; i < pangramArray.Length; i++)
{
    char[] letters = pangramArray[i].ToCharArray();
    Array.Reverse(letters);
    newPangram[i] = new string(letters);
}

string finalResult = string.Join(' ', newPangram);
Console.WriteLine(finalResult);