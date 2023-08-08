string[] symbol(string[] array)
{
    string[] Newsymbol = new string[11];

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Newsymbol[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref Newsymbol, count);
    return Newsymbol;
}
void Print(string[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}

string[] NewArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

Print(symbol(NewArray));