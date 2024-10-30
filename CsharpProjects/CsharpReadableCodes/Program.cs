/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.Write($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/* USING COMMENTS
The following code creates five random Order IDs
to test the fraud detection process. Order IDs
consist of  letter form A to E, and a three digit number.
Ex. A123

Random random = new Random();
string[] orderIds = new string[5];

for (int i = 0; i < orderIds.Length; i++){
    int prefixValue = random.Next(65,70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIds[i] = prefix + suffix;
}

foreach (var orderId in orderIds){
    Console.WriteLine(orderId);
}
*/

/*
// Example 1:
Console
.
WriteLine
(
    "Hello Example 1!"
)
;

//Example 2:
string firstWord = "Hello"; string lastWord = "Example 2"; Console.WriteLine(firstWord + " " + lastWord + "!");
*/

/* USING WHITESPACES

Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int totalRolls = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {totalRolls}");

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
    
    if((roll1 == roll2) && (roll2 == roll3)){
        totalRolls+=6;
        Console.WriteLine("You rolled triples! +6 bonus to total!");
    } else{
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        totalRolls+=2;
    }

}
*/

string str = "The quick brown fox jumps over the lazy dog.";

//Convert the message into a -char array
char[] charArray = str.ToCharArray();

//Reverse the chars
Array.Reverse(charArray);
int x = 0;

//Count the o's
foreach (char i in charArray){

    if (i=='o') {
        x++;
    }

}

//Convert it back to string
string new_message = new string(charArray);

//Print it out
Console.WriteLine(new_message + $"\n'o' appears {x} times.");