// Дано число обозначающее день недели.Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
    if(day > 0 && day < 6) 
    {
        Console.WriteLine("Это будний день");
    }
    else 
        if(day >=6 && day <= 7)
        {
            Console.WriteLine("Это выходной день");
        }
        else
            Console.WriteLine("Введен несуществующий день недели");
            


