// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}
int N = InputNumber("Введите число N ");
int Fibonachi1 = 0;
int Fibonachi2 = 1;
int FibonachiN;

System.Console.Write("0 1 ");
for (int i = 0; i < N - 2; i++)
{
    int sum = Fibonachi1 + Fibonachi2;
    System.Console.Write(sum + " ");
    Fibonachi1 = Fibonachi2;
    Fibonachi2 = sum;
}


// с помощью рекурсии
// int Fibonacci(int n)
// {
//     if(n==1 || n==2) return 1;
//     else return Fibonacci(n-1)+Fibonacci(n-2);
// }

// for (int i = 0; i < N; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }



