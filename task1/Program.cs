// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.Clear();
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int number = Prompt("Введите пятизначное число: ");

bool FiveNumbers(int number)
{
    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Вы ввели не пятизначное число! Повторите попытку.");
        return false;
    }
    return true;
}

int number1 = number / 10000;
int number2 = number / 1000 % 10;
int number4 = number / 10 % 10;
int number5 = number / 10;

void Palindrome(int number1, int number2, int number4, int number5)
{
    if (FiveNumbers(number))
    {
        if (number1 == number5 || number2 == number4)
    {
        Console.WriteLine("Да, это полиндром!");
    }
    else 
    {
        Console.WriteLine("Нет, это не полиндром!");
    }
    }  
}
Palindrome(number1, number2, number4, number5);