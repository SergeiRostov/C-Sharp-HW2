// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти: ");
int q = int.Parse(Console.ReadLine());
if (q == 1)
    {
        Console.WriteLine("По оси X > 0, по оси Y > 0");
    }
    else if (q == 2)
            {
                Console.WriteLine("По оси X < 0, по оси Y > 0");
            }
            else if (q == 3)
                {
                    Console.WriteLine("По оси X < 0, по оси Y < 0");
                }
                else if (q == 4)
                    {
                        Console.WriteLine("По оси X > 0, по оси Y < 0");
                    }
                    else
                        {
                        Console.WriteLine("Такой четверти не существует");
                        }