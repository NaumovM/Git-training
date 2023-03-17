Console.Clear();
Console.Write("Введите слова через пробел: ");
string[] inArray = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.Write($"[{String.Join(", ", inArray)}] -> ");
string[] outArray = ThreeSymbols(inArray);
Console.Write($"[{String.Join(", ", outArray)}]");

string[] ThreeSymbols(string[] array)
{
    string[] result = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    //result = result.Where(x => x != null).ToArray();
    //нагуглил, как быстро подрезать массив, но так нельзя.
    string[] total = new string[count];
    for (int i = 0; i < total.Length; i++)
    {
        total[i] = result[i];
    }
    return total;
}
