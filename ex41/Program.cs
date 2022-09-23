// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3


int[] InputArrayElements()
{
    Console.WriteLine("Введите любое количество чисел:");
    string line = Console.ReadLine()!;
    string[] parts = line.Split(' ');
    int[] numbers = new int[parts.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(parts[i]);
    }
    return numbers;
}

int CountPositivNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Положительных чисел : {CountPositivNumber(InputArrayElements())}");