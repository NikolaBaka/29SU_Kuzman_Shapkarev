double totalSum = double.Parse(Console.ReadLine());
string gender = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string sport = Console.ReadLine();

double sportPrice;
double[] malePrices = { 42, 41, 45, 34, 51, 39 };
double[] femalePrices = { 35, 37, 42, 31, 53, 37 };

void findingCardPrices(double totalSum, string gender, int age, double sportPriceF, double sportPriceM)
{
    if (gender == "f")
    {
        if (age > 19)
        {
            if(totalSum >= sportPriceF)
            {
                Console.WriteLine($"You purchased {Math.Round(totalSum / sportPriceF, 0)} month");
            }
            else
            {
                Console.WriteLine("You do not have enough money!");
            }
            
        }
        else
        {
            if (totalSum >= sportPriceF)
            {
                Console.WriteLine($"You purchased {sportPriceF - ((20 / 100) * sportPriceF)}");
            }
            else
            {
                Console.WriteLine("You do not have enough money!");
            }
        }

    }
    else if (gender == "m")
    {
        if (age > 19)
        {
            if (totalSum >= sportPriceM)
            {
                Console.WriteLine($"You purchased {Math.Round(totalSum / sportPriceM, 0)} month");
            }
            else
            {
                Console.WriteLine("You do not have enough money!");
            }

        }
        else
        {
            if (totalSum >= sportPriceM)
            {
                Console.WriteLine($"You purchased {sportPriceM - ((20 / 100) * sportPriceM)}");
            }
            else
            {
                Console.WriteLine("You do not have enough money!");
            }
        }
    }
}


switch (sport)
{
    case "Gym":
        findingCardPrices(totalSum, gender, age, femalePrices[0], malePrices[0]);
        break;

    case "Boxing":
       
        break;
}
    


