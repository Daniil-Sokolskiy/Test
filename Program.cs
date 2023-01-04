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
Console.Write("AS = [");
for (int i = 0; i < AS.Length; i++)
    Console.Write($"'{AS[i]}'");
Console.WriteLine("]");

int j = 0;

for (int i = 0; i < AS.Length; i++)
{
    if (AS[i].Length <=3)
    {
        j++;
    }
}
string [] ASsort = new string [j];
int k = 0;
for (int i = 0; i < AS.Length; i++)
{
    if (AS[i].Length <= 3)
    {
        ASsort[k]=AS[i];
        k++;
    }
}
Console.Write("ASsort = [");
for (int i = 0; i < ASsort.Length; i++)
    Console.Write($"'{ASsort[i]}'");
Console.WriteLine("]");