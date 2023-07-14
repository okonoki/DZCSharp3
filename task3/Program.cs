// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Clear();
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int N = Prompt("Введите число N: ");
void NumberCubed(int N)
{
    for (int i = 1; i <= N; i += 1)
    {
        if (i < N)
        {
             Console.Write(i * i * i + ", ");
        }
        else Console.Write(i * i * i);
    }
}
NumberCubed(N);