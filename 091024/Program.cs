////////// TryParse() Method //////////
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



////////// Challenge Activity: Combine string array values as strings AND integers /////
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

