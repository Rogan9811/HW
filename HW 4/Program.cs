Console.WriteLine("Choose the task(25, 27, 29): ");
int tasks = Convert.ToInt32(Console.ReadLine());

switch (tasks)
{
    case 25:
        Console.WriteLine("Exponentiation. Raising the first number to the second. ");
        Console.WriteLine("Please, enter your first number: ");
        int FirstNumb = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please, enter your second number: ");
        int SecondNumb = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        for(int i = 1; i <= SecondNumb; i++)
        {
        result *= FirstNumb;
        }

        Console.WriteLine(result);
        break;
    
    case 27:
        void DigitSum(int Sum)
        {
            int res = 0;
            while(Sum > 0)
            {
                res += Sum%10;
                Sum /= 10;
            }

            Console.WriteLine(res);
        }
        
        Console.WriteLine("sum of every digit in a number. ");
        Console.WriteLine("Please, enter your number: ");
        int numb = Convert.ToInt32(Console.ReadLine());

        DigitSum(numb);

        break;

    case 29:
        void FillArray(int[] Array)
        {
            for(int i = 0; i < Array.Length; i++)
            {
                Array[i] = new Random().Next(0, 10);
            }
            Console.Write('[' + string.Join(',', Array) + ']');
        }

        Console.WriteLine("Enter number: ");
        int Anumb = Convert.ToInt32(Console.ReadLine());

        int[] Array1 = new int[Anumb];

        FillArray(Array1);

        break;
}