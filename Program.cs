using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть шестизначне число:");
        string numberString = Console.ReadLine();
        
        if (numberString.Length != 6)
        {
            Console.WriteLine("Помилка! Введіть шестизначне число.");
            return;
        }

        Console.WriteLine("Введіть номери розрядів для заміни цифр (наприклад, 1 і 6):");
        string positionsString = Console.ReadLine();

        string[] positions = positionsString.Split(' ');

        if (positions.Length != 2)
        {
            Console.WriteLine("Помилка! Введіть два номери розрядів для заміни цифр.");
            return;
        }

        int position1, position2;

        if (!int.TryParse(positions[0], out position1) || !int.TryParse(positions[1], out position2))
        {
            Console.WriteLine("Помилка! Введіть дійсні номери розрядів для заміни цифр.");
            return;
        }

        if (position1 < 1 || position1 > 6 || position2 < 1 || position2 > 6)
        {
            Console.WriteLine("Помилка! Номери розрядів повинні бути від 1 до 6.");
            return; 
        }

        int[] digits = new int[6];
        for (int i = 0; i < 6; i++)
        {
            digits[i] = int.Parse(numberString[i].ToString());
        }
        
        int temp = digits[position1 - 1];
        digits[position1 - 1] = digits[position2 - 1];
        digits[position2 - 1] = temp;

        string newNumberString = string.Join("", digits);

        Console.WriteLine($"Результат: {newNumberString}");
    }
}
