    string[] AS; // ссылка на массив строк
    int count; // текущее количество строк в массиве
    string s;
    string[] AS2; // дополнительная переменная-ссылка - сохраняет старый массив строк

    Console.WriteLine("Enter strings:");

    count = 0; // обнулить количество строк
    AS = new string[count]; // выделить память для 0 строк

    do
    {
        s = Console.ReadLine();
        if (s != "")
        {
            count++;
            AS2 = new string[count];
            for (int i = 0; i < AS2.Length - 1; i++)
                AS2[i] = AS[i];
            AS2[count - 1] = s;
            AS = AS2;
        }
    } while (s != "");

    for (int i = 0; i < AS.Length; i++)
        Console.WriteLine("AS[{0}] = {1}", i, AS[i]);

