Console.Write("Choose number of home work(2, 4, 6, 8): ");
int task = Convert.ToInt32(Console.ReadLine());

switch(task)
{
    case 2:
    
    //Задача 2:     Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

    // a = 5; b = 7 -> max = 7
    // a = 2 b = 10 -> max = 10
    // a = -9 b = -3 -> max = -3
    
    Console.Write("It's first task. ");
    Console.WriteLine("Enter your first number: ");
    int numb1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your second number: ");
    int numb2 = Convert.ToInt32(Console.ReadLine());

    if(numb1 == numb2)
        {
            Console.WriteLine("these numbers are the same.");
        }
    else 
    {
        if(numb1 > numb2)
        {
            Console.WriteLine(numb1 + ">" + numb2);
        }
            else
        {
            Console.WriteLine(numb2 + ">" + numb1);
        }
    }
    break;

    case 4:
    //     Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

    // 2, 3, 7 -> 7
    // 44 5 78 -> 78
    // 22 3 9 -> 22

    Console.WriteLine("This is a second task. ");
    Console.Write("Enter first number: ");
    int fnumb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number: ");
    int snumb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter third number: ");
    int tnumb = Convert.ToInt32(Console.ReadLine());
    int BIGNUMB = fnumb;
    Console.WriteLine(fnumb);
    Console.WriteLine(snumb);
    Console.WriteLine(tnumb);
    Console.WriteLine(BIGNUMB);
         
         if(BIGNUMB<snumb)
         {
             BIGNUMB = snumb;
         }
         else
         {
             BIGNUMB = tnumb;
         }
    
    Console.WriteLine("largest number is " + BIGNUMB);
    break;

    case 6:
    //     Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

    // 4 -> да
    // -3 -> нет
    // 7 -> нет

    Console.WriteLine("This is a fourth task. ");
    Console.Write("Enter number: ");
    int count = Convert.ToInt32(Console.ReadLine());
    int del = count % 2;
    
    if(del == 0)
    {
        Console.Write("This is even number.");
    }
    else
    {
        Console.Write("This is odd number.");
    }
    break;

    case 8:
    //     Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

    // 5 -> 2, 4
    // 8 -> 2, 4, 6, 8

    Console.WriteLine("This is a fourth task. ");
    Console.Write("Enter number: ");
    int N = Convert.ToInt32(Console.ReadLine());

    for(int i = 1; i <= N; i++)
    {
        if(i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
    break;
}
