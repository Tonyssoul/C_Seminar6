// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] InputArray(string str)
{
    System.Console.WriteLine(str);
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

int[] array = InputArray("Введите числа через пробел");

void PrintArray(int[] array)
{
    System.Console.WriteLine("[ " + string.Join(", ", array) + "]");
}

int Findmax(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            res++;
        }
        
    }
    return res;
}

PrintArray(array);
int result = Findmax(array);
System.Console.WriteLine(result);