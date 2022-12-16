Console.Write("Choose number of home work(2, 4, 6): ");
int task = Convert.ToInt32(Console.ReadLine());

switch(task)
{
    case 2:
    
    //     Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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
}
