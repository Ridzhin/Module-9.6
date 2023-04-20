try
{
    Console.Write("Введите новый пароль: ");
    string password = Console.ReadLine();
    if (password == null || password.Length < 5)
    {
        throw new Exception("Длмна пароля должна быть более 5 символов");
    }
    else
    {
        Console.WriteLine("Пароль теперь: {0}", password);
    }
}
catch (Exception e)
{
    Console.WriteLine("Ошибка: {0}", e.Message);
}