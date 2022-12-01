Console.Clear();

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
string EnterNumber(string str)
{
    Console.Write(str);
    string number = Console.ReadLine();
    return number;
}

string ReverseString(string str)
    {
    char[] array = str.ToCharArray();
    Array.Reverse(array);
    return new string(array);
    }



string number = EnterNumber("Введите пятизначное число: ");
string reverse = ReverseString(number);
if (number == reverse)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}

