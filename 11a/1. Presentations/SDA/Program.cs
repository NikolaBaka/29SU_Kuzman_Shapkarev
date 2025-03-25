
List<int> list = new List<int>();

// 1, 3, 54, 25, 3, stop

Console.WriteLine("Enter numbers in list:");
string enter = Console.ReadLine();

while (enter != "stop")
{
    list.Add(int.Parse(enter));

    enter = Console.ReadLine();
}

// enter = "stop" 

while (enter != "7")
{
    // print menu
    PrintMenu();

    enter = Console.ReadLine();

    switch (enter)
    {
        case "1":
            // foreach
            for (int i = 0; i < list.Capacity; i++)
            {
                if (i == list.Count - 1)
                {
                    Console.Write(list[i]);
                }
                else
                {
                    Console.Write(list[i] + ", ");
                }
            }
            break;

        case "2":
            // sorting
            list.Sort();
            break;

        case "3":
            // max
            break;

        case "4":
            // min
            break;

        case "5":
            // searching
            // number: 7 - > index 1
            // number: 0 - > index 6

            int count = 0;

            Console.WriteLine("Enter a number:");
            int numberEnter = int.Parse(Console.ReadLine());

            for(int i = 0; i < list.Count; i++)
            {
                if (numberEnter == list[i])
                {
                    Console.WriteLine("index " + i);
                }
                else
                {
                    count++;
                }
            }
            
            if(count == list.Count)
            {
                Console.WriteLine("The number is not found.");
            }

            break;

        case "6":
            // Repetative
            int[] array = new int[1000];



            break;

        case "7":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Enter number between 1 - 7");
            break;
    }

}

void PrintMenu()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1) Print list");
    Console.WriteLine("2) Sort");
    Console.WriteLine("3) Max element");
    Console.WriteLine("4) Min element");
    Console.WriteLine("5) Search element");
    Console.WriteLine("6) Repetative elements");
    Console.WriteLine("7) Exit");
    Console.WriteLine();
    Console.WriteLine("Enter a number: ");
}