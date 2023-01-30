Console.Clear();
Console.Write("This is final home work. Choose the task's number(64, 66, 68): ");
int tasks = Convert.ToInt32(Console.ReadLine());

switch(tasks)
{
    case 64:
        Console.WriteLine("Мне лень на инглише писать. эт задание 64: " +
        "Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1." +
        "Выполнить с помощью рекурсии");

        void printTo1(int numb, int temp)
        {
            if (temp >= numb + 1) return;

            printTo1(numb, temp + 1);
            Console.Write(temp + " ");
        }

        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int temp = 1;

        printTo1(number, temp);
    break;

    case 66:
        Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine();

        int sumMToN(int numb, int numb2)
        {
            if (numb < numb2) return 0;
            else{
            return numb + sumMToN(numb - 1, numb2);
            }
        }

        Console.Write("Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        if(n > m) sum = sumMToN(n, m);
        else if(n == m) Console.Write(n);
        else sum = sumMToN(m, n);

        Console.WriteLine(sum);
    break;

    case 68:
        int Akkerman(int m, int n)
        {
            if(m==0) return n + 1;
            else if(m > 0 && n == 0) return Akkerman(m-1, 1);
            else if(m>0 && n > 0) return Akkerman(m-1, Akkerman(m, n - 1));
            else return 0;
        }

        Console.Write("Введите m: ");
        int mAk = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите n: ");
        int nAk = Convert.ToInt32(Console.ReadLine());

        int result = Akkerman(mAk, nAk);

        Console.WriteLine($"Ваша функция А({mAk},{nAk}) равна {result}");
    break;
}