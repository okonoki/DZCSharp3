// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.Clear();
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
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

// int number1 = number / 10000;
// int number2 = number / 1000 % 10;
// int number4 = number / 10 % 10;
// int number5 = number / 10;

// void Palindrome(int number1, int number2, int number4, int number5)
// {
//     if (FiveNumbers(number))
//     {
//         if (number1 == number5 || number2 == number4)
//     {
//         Console.WriteLine("Да, это полиндром!");
//     }
//     else 
//     {
//         Console.WriteLine("Нет, это не полиндром!");
//     }
//     }  
// }
// Palindrome(number1, number2, number4, number5);

int ReverseNumber(int a)
{
    int revNum = 0;
    int temp = a;
    while (temp > 0)
    {
        revNum = revNum * 10 + temp % 10; // 0+1 / 10+2=12 / 120+3=123 / 1230+2=1232 / 12320+1=12321
        temp /= 10; // 1232 / 123 / 12 / 1 / 0
    }
}



int Prompt(string message)
{
Console.Write(message);
string? value = Console.ReadLine();
int number = Convert.ToInt32(value);
return number;
}

int ReverseNumber(int a)
{
int revNum = 0;
int temp = a; // 12321
while (temp > 0)
{
revNum = revNum * 10 + temp % 10; // 0 + 1 // 10 + 2 = 12 // 120 + 3=123 // 1230 + 2 //12320 +1 //12321
temp /= 10; // 1232 // 123 // 12 // 1 // 0

}
return revNum;
}

int a = Prompt("Введите 5-и значное число: ");
int reversed = ReverseNumber(a);

if (reversed == a)
{
Console.WriteLine("Число является полиндромом.");
}
else
{
Console.WriteLine("Число НЕ является полиндромом.");
}