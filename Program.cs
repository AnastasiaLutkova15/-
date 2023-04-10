
string[] array = new string[] { "hello", "2", "world", ":-)" };
string[] shortStrings = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        shortStrings[i] = array[i];
    }
    Console.Write($"{shortStrings[i] + " "}");
}
