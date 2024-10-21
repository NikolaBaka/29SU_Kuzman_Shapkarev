
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(" * ");
//    }
//    Console.WriteLine();
//}

//for (int i = n; i > 0; i--)
//{
//    for (int j = 1; j < i; j++)
//    {
//        Console.Write(" * ");
//    }
//    Console.WriteLine();
//}

// Да сравним масивите.
// да - едакви
// не - различни

int[] array1 = { 2, 6, 3, 4, 5 };
int[] array2 = { 2, 6, 3, 4, 5 };
int j = 0;

if (array1.Length == array2.Length)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] == array2[i])
        {
            j++;
        }
        else
        {
            Console.WriteLine("No equal");
            break;
        }
    }
    if (j == array1.Length)
    {
        Console.WriteLine("Equal");
    }
}
else
{
    Console.WriteLine("No equal");
}

int sum = 0;
for (int i = 0; i < array1.Length; i++)
{
    sum += array1[i];
    sum = sum + array1[i];
}

Console.WriteLine(sum / array1.Length);



