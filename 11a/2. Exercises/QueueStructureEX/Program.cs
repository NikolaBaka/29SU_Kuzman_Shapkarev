Console.WriteLine("Welcome to Cafe \"Kuzman\"");
Console.WriteLine("Enter a number for operation:");
Console.WriteLine("1. Add a client");
Console.WriteLine("2. Add a VIP client");
Console.WriteLine("3. Service");
Console.WriteLine("4. Number of waiting");
Console.WriteLine("5. All clients' names");
Console.WriteLine("6. Exit");
Console.WriteLine("-----------------------------");

Queue<string> cafeQueue = new Queue<string>();
Queue<string> cafeQueueVip = new Queue<string>();


string enter = Console.ReadLine();

while(enter != "6")
{
    switch (enter)
    {
        case "1":
            if (cafeQueue.Count < 3)
            {
                enter = Console.ReadLine();
                cafeQueue.Enqueue(enter);
                Console.WriteLine("The client is added.");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("The cafe is full");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            
            break;
        case "2":
            if (cafeQueue.Count < 3)
            {
                enter = Console.ReadLine();
                cafeQueueVip.Enqueue(enter);
                Console.WriteLine("The client is added.");
            }
            else
            {
                enter = Console.ReadLine();
                cafeQueueVip.Enqueue(enter);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("The client is added. The cafe is full.");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            break;
        case "3":
            if(cafeQueueVip.Count > 0)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Service: " + cafeQueueVip.Peek());
                Console.BackgroundColor = ConsoleColor.Black;
                cafeQueueVip.Dequeue();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Service: " + cafeQueue.Peek());
                Console.BackgroundColor = ConsoleColor.Black;
                cafeQueue.Dequeue();
            }
            break;
        case "4":
            Console.WriteLine("Waiting clients: " + cafeQueue.Count());
            break;
        case "5":
            // Разпечатване на опашката
            foreach (var item in cafeQueue)
            {
                Console.WriteLine(item);
            }
            break;
        default:
            Console.WriteLine("Enter a number between 1 - 5");
            break;
    }

    enter = Console.ReadLine();
}

Console.WriteLine("Exit");
