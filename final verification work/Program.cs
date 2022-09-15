int GetNumberPositiv()
{
    Console.WriteLine("Введите число");
    string text = Console.ReadLine();

    string[] sentence ={"введите именно число", 
                        "Число! это дожно быть число!!! \nпопробуй еще раз", 
                        "Это не закончится до тех пор, пока не будет введено число.", 
                        "ты не знаешь что такое число? 1, 2, 5, 10... \nПопробуй еще раз. Я верю -ты сможешь!", 
                        "Это не число! Не ошибись! Ни чего кроме числа! одного числа!"};

    if(!int.TryParse(text, out int number))
    {
        Console.WriteLine(sentence[new Random().Next(0, 5)]);
        return GetNumberPositiv();
    }

    else if(number < 0) 
    {
        Console.WriteLine("Число не должно быть отрицательным");
        return GetNumberPositiv();
    }

    return number;
}

string[] FillArrayStr()
{
    Console.WriteLine("Сколько строк будет введено?");
    int n = GetNumberPositiv();
    string[] array = new string[n];
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1} строку");
        array[i] = Console.ReadLine();
    }

    return array;
}

string[] newArray = FillArrayStr();
Console.WriteLine(string.Join(" ", newArray));