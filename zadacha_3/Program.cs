// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


void FindCubeNumber(int number)
{
    int count = 1;
    while (count < number + 1)
    {
        double result = Math.Pow(count, 3); // сделал дабл резалт так как через инт функция math выдает ошибку (дабл не удвется преобразовать в тип инт) поэтому сделал дабл
        Console.Write($"{result} ");
        count++;
    }
}

int digit = EnterNumber("Введите цифру: ");
FindCubeNumber(digit);