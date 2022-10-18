using System;

namespace topic_5_dice_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int die1;
            int die2;
            int dieSum;
            decimal money = 100.00m;
            decimal bet = 1.00m;
            Console.WriteLine($"You currently have ${money} in your bank account.");
            Console.WriteLine("Enter how much you want to bet.");
            bet = Convert.ToDecimal(Console.ReadLine());
            if (bet > money)
                bet = 0.00m;
            Console.WriteLine("What do you want to bet on?");
            Console.WriteLine("1. Doubles");
            Console.WriteLine("2. Not double");
            Console.WriteLine("3. Even Sum");
            Console.WriteLine("4. Odd Sum");
            int roll = Convert.ToInt32(Console.ReadLine());
            die1 = generator.Next(1, 7);
            die2 = generator.Next(1, 7);
            dieSum = die1 + die2;
            int q = dieSum % 2;
            if (roll == 1)
            {
                Console.WriteLine("You bet on doubles.");
                Console.WriteLine($"The first die rolled a {die1}. The second die rolled a {die2}. The total rolled is {dieSum}.");
                if (die1 == die2)
                {
                    Console.WriteLine("You win.");
                    bet = bet * 2;
                    money = money + bet;
                }
                else
                {
                    Console.WriteLine("You lose.");
                    money = money - bet;
                }
            }
            else if (roll == 2)
            {
                Console.WriteLine("You bet on not double.");
                Console.WriteLine($"The first die rolled a {die1}. The second die rolled a {die2}. The total rolled is {dieSum}.");
                if (die1 != die2)
                {
                    Console.WriteLine("You win.");
                    bet = bet / 2;
                    money = money + bet;
                }
                else
                {
                    Console.WriteLine("You lose.");
                    money = money - bet;
                }
            }
            else if (roll == 3)
            {
                Console.WriteLine("You bet on even sum.");
                Console.WriteLine($"The first die rolled a {die1}. The second die rolled a {die2}. The total rolled is {dieSum}.");
                if (q == 0)
                {
                    Console.WriteLine("You win.");
                    money = money + bet;
                }
                else
                {
                    Console.WriteLine("You lose.");
                    money = money - bet;
                }
            }
            else if (roll == 4)
            {
                Console.WriteLine("You bet on odd sum.");
                Console.WriteLine($"The first die rolled a {die1}. The second die rolled a {die2}. The total rolled is {dieSum}.");
                if (q == 1)
                {
                    Console.WriteLine("You win.");
                    money = money + bet;
                }
                else
                {
                    Console.WriteLine("You lose.");
                    money = money - bet;
                }
            }
            else
                Console.WriteLine("Invalid choice.");
            Console.WriteLine($"You currently have ${Math.Round(money, 2)} in your bank account.");
        }
    }
}
