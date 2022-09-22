// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше
//  0 ввёл пользователь.

Console.Write("Введите целые числа через пробел: ");
string[] nums = Console.ReadLine()!.Split(' ');
int M = nums.Length;

int[] numbers = CreateNumbersArray(nums);
Console.WriteLine(CountPositiveNums(numbers));


int[] CreateNumbersArray(string[] nums)
{
    int[] numbers = new int[M];

    for (int i = 0; i < M; i++)
    {
        numbers[i] = int.Parse(nums[i]);
    }
    
    return numbers;
}

int CountPositiveNums(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        if (numbers[i] < 0)
            count += 1;
    }
    return count;
}