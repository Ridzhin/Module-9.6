
Trigger trigger = new Trigger();
trigger.TriggerEvent += ShowSort;

while (true) 
{ 
    try
    {
        trigger.Read();
    }

    catch (FormatException)
    {
        Console.WriteLine("Ошибка ввода");
    }
}

static void ShowSort(int number)
{
    string[] Surnames = new string[5];
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine("Введите фамилию номер {0}", j + 1);
        Surnames[j] = Console.ReadLine();
    }
    if (number == 1)
    {
        var orderedSurnames = Surnames.OrderBy(n => n);
        foreach (var i in orderedSurnames)
            Console.WriteLine(i);
    }
    if (number == 2)
    {
        var desorderedSurnames = Surnames.OrderByDescending(n => n);
        foreach (string i in desorderedSurnames)
        Console.WriteLine(i);
    }

}


class Trigger
{
    public delegate void TriggerDelegate(int number);
    public event TriggerDelegate TriggerEvent;

    public void Read()
    {

        Console.WriteLine("Для сортировки фамилий в алфавитном порядке введите 1, для сортировки в обратном алфавитному 2");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number != 1 && number != 2) throw new FormatException();

        NumberEntered(number);
    }

    protected virtual void NumberEntered(int number)
    {
        TriggerEvent?.Invoke(number);
    }
    
}