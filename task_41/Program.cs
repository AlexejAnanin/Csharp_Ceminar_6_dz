// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] EnterNumbers()
{
    Console.WriteLine("Введите произвольное количество чисел:");
int[] M = Array.ConvertAll(Console.ReadLine()!.Split(", "), int.Parse);

return M;
}

int CountNumbers(int[] M){
int count = 0;
for (int i = 0; i < M.Length; i++)
{
    if (M[i] > 0)
    {
        count++;
    }
}
return count;
}

Console.Write($"Количество чисел больше нуля: {CountNumbers(EnterNumbers())}");

