Console.WriteLine("Enter Balance: ");
double totalSum = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Gender: ");
string gender = Console.ReadLine();
Console.WriteLine("Enter age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Sport: ");
string sport = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Summary: ");

double sportPrice;
double[] malePrices = { 42, 41, 45, 34, 51, 39 };
double[] femalePrices = { 35, 37, 42, 31, 53, 37 };

void conditions (int age, double totalSum, double sportPrice)
{
    if (age > 19)
    {
        if (totalSum >= sportPrice)
        {
            Console.WriteLine($"You purchased {Math.Round(totalSum / sportPrice, 0)} months");
        }
        else
        {
            Console.WriteLine("You do not have enough money!");
        }

    }
    else
    {
        if (totalSum >= sportPrice)
        {
            Console.WriteLine($"You purchased {Math.Round(totalSum / (sportPrice - ((20 / 100) * sportPrice)), 0)} months");
        }
        else
        {
            Console.WriteLine("You do not have enough money!");
        }
    }
}
void findingCardPrices(double totalSum, string gender, int age, double sportPriceF, double sportPriceM)
{
    if (gender == "f")
    {
        conditions(age, totalSum, sportPriceF);

    }
    else if (gender == "m")
    {
        conditions(age, totalSum, sportPriceM);
    }
}


switch (sport)
{
    case "Gym":
        findingCardPrices(totalSum, gender, age, femalePrices[0], malePrices[0]);
        break;
    case "Boxing":
        findingCardPrices(totalSum, gender, age, femalePrices[1], malePrices[1]);
        break;
    case "Yoga":
        findingCardPrices(totalSum, gender, age, femalePrices[2], malePrices[2]);
        break;
    case "Zumba":
        findingCardPrices(totalSum, gender, age, femalePrices[3], malePrices[3]);
        break;
    case "Dances":
        findingCardPrices(totalSum, gender, age, femalePrices[4], malePrices[4]);
        break;
    case "Pilates":
        findingCardPrices(totalSum, gender, age, femalePrices[5], malePrices[5]);
        break;
}
