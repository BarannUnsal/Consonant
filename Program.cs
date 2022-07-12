Console.WriteLine("Kelimeleri giriniz: ");

foreach (var item in Console.ReadLine().Split())
{
    bool control = false;
    for (int i = 1; i < item.Length; i++)
    {
        if (Sessiz(item[i]) == Sessiz(item[i - 1]))
            control = true;
    }
    Console.Write(control + " ");
}

bool Sessiz(char x)
{
    return !"aeıioöuü".ToCharArray().Contains(x);
}