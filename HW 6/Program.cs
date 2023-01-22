Console.WriteLine("Choose the tasks's number(41, 43): ");
int tasks = Convert.ToInt32(Console.ReadLine());

switch(tasks)
{
    case 41:
        Console.WriteLine("This is task 41. Please, enter random(>0) number: ");
    int size = Convert.ToInt32(Console.ReadLine());
    if(size<0) Console.WriteLine("Enter right number.");
    else 
    {
        int[] randomNums = new int[size];
        int count = 0;
        for (int i = 0; i < randomNums.Length ; i++)
        {
            Console.Write($"Enter the {i+1} number: ");
            randomNums[i] = Convert.ToInt32(Console.ReadLine());
            if(randomNums[i]>0) count ++;
        }
        Console.WriteLine($"The count of positive numbers is {count}.");
    }
    break;

    case 43:
        // for 1 straight
        Console.Write("This is task 43. Please, enter coefficient before X for 1 straight: ");
        double kX1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("This is task 43. Please, enter free member for 1 straight: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        // for 2 straight
        Console.Write("This is task 43. Please, enter coefficient before X for 2 straight: ");
        double kX2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("This is task 43. Please, enter free member for 2 straight: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        double intersectionPointX = 0;
        double intersectionPointY = 0;

        if(kX1 == kX2) Console.WriteLine("Error. Straight don't overlap.");
        if(kX1 == kX2 || b1 == b2) Console.WriteLine("This is the one straight.");

        intersectionPointX = Math.Round((b2 - b1)/(kX1 - kX2), 2);
        intersectionPointY = Math.Round((kX1 * (b2 - b1))/(kX1-kX2) + b1, 2);

        Console.Write("This is the intersection point: " + intersectionPointX + " " + intersectionPointY);
    break;
}