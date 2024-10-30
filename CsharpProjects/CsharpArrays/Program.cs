/**string[] fraudOrderIds = ["A123", "B456", "C789"];
fraudOrderIds[0] = "A123";
fraudOrderIds[1] = "B456";
fraudOrderIds[2] = "C789";

Console.WriteLine($"First: {fraudOrderIds[0]}\n" + $"Second: {fraudOrderIds[1]}\n" + $"Third: {fraudOrderIds[2]}");

fraudOrderIds[0] = "F000";
Console.WriteLine($"Reassign First: {fraudOrderIds[0]}.\nThere are {fraudOrderIds.Length} fraudulent orders to process.");**/

/**int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;
foreach (int items in inventory){
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.Write($"We have {sum} items in Inventory.");**/

string[] orders = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
char fraudOrder = 'B'; //All -char variable should be in a single quotation ('')

foreach (string order in orders){
    if(order.StartsWith(fraudOrder.ToString())){
        Console.Write($"{order}\n");
    }
}
/**Other solution
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}**/

