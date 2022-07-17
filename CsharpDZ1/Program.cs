// See https://aka.ms/new-console-template for more information

//Задача 1
Console.WriteLine("Задача №1\nВведите число от 1 до 100: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1 || num > 100)
{
    Console.WriteLine("Ошибка! Невенрное значение.");
}
else
{
    if (num % 3 == 0 && num % 5 == 0)
    {
        Console.WriteLine("Fizz Buzz"); 
    }
    else if (num % 3 == 0)
    {
        Console.WriteLine("Fizz"); 
    }
    else if (num % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(num);
    }
}
Console.WriteLine('\n');

//Задача 2
Console.WriteLine("Задача №2\nВведите число и процент: ");
int?[] arr = new int?[2];
int i = 0;
foreach (var item in arr)
{
    string? nums = Console.ReadLine();
    arr[i++] = int.Parse(nums);
}
Console.WriteLine(arr[0] * arr[1] / 100);
Console.WriteLine('\n');

//Задача 3
Console.WriteLine("Задача №3\nВведите 4 цифры.");
string?[] arr1 = new string?[4];
int j = 0;
foreach (var item in arr1)
{
    Console.WriteLine($"Введите {j + 1} цифру: ");
    string? result = Console.ReadLine();
    arr1[j++] = result;
}
Console.Write("Ваше число: ");
for(int k = 0; k < arr1.Length; k++)
{
    Console.Write(arr1[k]);
}
Console.WriteLine('\n');

//Задача 4
Console.WriteLine("Задача №4\nВведите шестизначное число: ");
int? number = Convert.ToInt32(Console.ReadLine());
int[] arr2 = number.ToString().Select(n => int.Parse(n.ToString())).ToArray();
if (arr2.Length != 6)
{
    Console.WriteLine("Ошибка! Вы ввели не шестизначное число");
}
else
{
    Console.Write("Ваше число до замены: ");
    for (int k = 0; k < arr2.Length; k++)
    {
        Console.Write(arr2[k]);
    }
    Console.WriteLine('\n');

    Console.WriteLine("Введите два числа: ");
    int?[] twoNumbers = new int?[2];
    int c = 0;
    foreach (var item in twoNumbers)
    {
        Console.WriteLine($"Введите {c + 1} цифру: ");
        string? result = Console.ReadLine();
        twoNumbers[c++] = int.Parse(result);
    }
    int tmp = arr2[(int)twoNumbers[0] - 1];
    arr2[(int)twoNumbers[0] - 1] = arr2[(int)twoNumbers[1] - 1];
    arr2[(int)twoNumbers[1] - 1] = tmp;

    Console.Write("Ваше окончательное число: ");
    for (int k = 0; k < arr2.Length; k++)
    {
        Console.Write(arr2[k]);
    }
}
Console.WriteLine('\n');

//Задача 5
Console.WriteLine("Задача №5\nВведите дату в формате DD.MM.YYYY: ");
string data = Console.ReadLine();
Console.WriteLine("Ваша дата - " + data);
string[] split = data.Split('.');
int day = int.Parse(split[0]);
int month = int.Parse(split[1]);
int year = int.Parse(split[2]);

switch (month)
{
    case 12: case 1: case 2:
        Console.WriteLine("Winter");
        break;
    case 3: case 4: case 5:
        Console.WriteLine("Spring");
        break ;
    case 6: case 7: case 8:
        Console.WriteLine("Summer");
        break;
    case 9: case 10: case 11:
        Console.WriteLine("Atumn");
        break;
        default:
        Console.WriteLine("Неизвестное значение");
        break;
}

int forDay = (day + ((13 * month - 1) / 5)
    + (year % 100) + (year % 100 / 4)
    + (year / 100 / 4) - (2 * (year / 100))) % 7;
switch (forDay)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Неизвестное значение");
        break;
}
Console.WriteLine('\n');

//Задача 6
Console.WriteLine("Задача №6\nВведите в какую систему нужно перевести" +
    "(1 - из Фарингейта в Цельсий, 2 - из Цельсий в Фарингейт : ");
int answer = Convert.ToInt32(Console.ReadLine());
double degrees;
if(answer == 1)
{
    Console.WriteLine("Введите градусы: ");
    degrees = Convert.ToDouble(Console.ReadLine());
    Console.Write("Градусов по Цельсию: ");
    Console.Write((degrees - 32) / 1.8);
}
else if(answer == 2)
{
    Console.WriteLine("Введите градусы: ");
    degrees = Convert.ToDouble(Console.ReadLine());
    Console.Write("Градусов по Фаренгейту: ");
    Console.Write(degrees * 1.8 + 32);
}
else
{
    Console.WriteLine("Неверное значение");
}
Console.WriteLine('\n');

//Задача 7
Console.WriteLine("Задача №6\nВведите диапазон значений(два числа): ");
int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
string allEven = "";
if(start > end)
{
    int tmp = start;
    start = end;
    end = tmp;
}
while(start <= end)
{
    if(start % 2 == 0)
    {
        allEven += start.ToString() + " ";
    }
    start++;
}
Console.WriteLine($"Все чётные числа в диапазоне от {start} до {end}");
Console.WriteLine(allEven);