void fillArray(int[] array)
    {
        for(int i = 0; i < array.Length; i ++)
        {
            array[i] = new Random().Next(100, 1000);
        }

        Console.WriteLine("It's your array: " + '[' + string.Join(',', array) + ']');
    }


Console.WriteLine("Choose the task's number(34, 36, 38): ");
int tasks = Convert.ToInt32(Console.ReadLine());

switch(tasks)
{
    case 34:
    int searchTheEvenCount(int[] array)
        {
            int result = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0) result ++;
            }
            return result;
        }

        Console.WriteLine("This is task 34. Enter the size of array: ");
        int Size34 = Convert.ToInt32(Console.ReadLine());
        int[] array34 = new int[Size34];

        fillArray(array34);
        int res34 = searchTheEvenCount(array34);

        Console.WriteLine("Count of array's even numbers is - " + res34);  
    break;

    case 36:
        int sumOfNegativeindexes(int[] array)
        {
            int result = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(i % 2 == 1) result += array[i];
            }
            return result;
        }
        
        Console.WriteLine("This is task 36. Enter the size of array: ");
        int Size36 = Convert.ToInt32(Console.ReadLine());
        int[] array36 = new int[Size36];

        fillArray(array36);
        int res36 = sumOfNegativeindexes(array36);

        Console.WriteLine("Sum of odd numbers of the array = " + res36);
    break;

    case 38:
        int diffBetweenMaxAndMin(int[] array)
        {
            int result;
            int max = 0;
            int min = 99999;

            for(int i = 0; i < array.Length; i++)
            {
                if(max < array[i]) max = array[i];
                else if(min > array[i]) min = array[i];
            }
            result = max - min;
            return result;
        }

        Console.WriteLine("This is task 38. Enter the size of array: ");
        int Size38 = Convert.ToInt32(Console.ReadLine());
        int[] array38 = new int[Size38];

        fillArray(array38);
        int res38 = diffBetweenMaxAndMin(array38);

        Console.WriteLine("Difference between array's max count and array's min count = " + res38);
    break;
}