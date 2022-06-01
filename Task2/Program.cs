//По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
    if (a == b * b)
    {
        Console.Write($"{a} квадрат {b}");
    }
    else if (b == a * a)
        {
            Console.Write($"{b} квадрат {a}");
        }
            else 
            {
                Console.Write("Числа не являются квадратом друг друга");
            }