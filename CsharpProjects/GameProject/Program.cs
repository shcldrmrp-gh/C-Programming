Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int totalRolls = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {totalRolls}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {

    if ((roll1 == roll2) && (roll2 == roll3)) {
    totalRolls+=6;
    Console.WriteLine($"You rolled triples! +6 bonus to total! Total rolls is now {totalRolls}.");
    } else {
        totalRolls+=2;
    Console.WriteLine($"You rolled doubles! +2 bonus to total! Total rolls is now {totalRolls}.");
    }
    
} 

if (totalRolls >= 15) {
    Console.WriteLine("You win a car!");
} else if (totalRolls >= 10) {
    Console.WriteLine("You win a laptop!");
} else if (totalRolls >= 7) {
    Console.WriteLine("You win a trip!");
} else {
    Console.WriteLine("You win a kitten!");
}