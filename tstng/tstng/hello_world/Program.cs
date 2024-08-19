/////////////////////
///     8-19-24  


Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

//////////////////////////////////////

string value1 = " a";
string value2 = "A ";
Console.WriteLine();
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

///////////////////////////////////////

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine();
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//////////////////////


Random coin = new Random();
Console.WriteLine(coin.Next() % 2 == 0 ? "heads" : "tails");