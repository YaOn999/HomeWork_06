// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int SumPositavNum(int[] num)
{
    int result = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0) result = result + 1;
    }
    return result;
}

int[] EnterData(string text)
{
    Console.Write(text);
    string arrayText = Console.ReadLine();
    int[] arrayNum = arrayText.Split(' ').Select(Int32.Parse).ToArray();
    return arrayNum;
}

int[] num = EnterData("Введите числа через пробел: ");
Console.WriteLine($"[{String.Join(" ", num)}]");

int result = SumPositavNum(num);
Console.WriteLine("пользователь ввел " + result + " положительных цифр(ы)");
