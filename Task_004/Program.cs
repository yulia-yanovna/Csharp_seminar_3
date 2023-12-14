// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.
// “Hello my world” => “world my Hello”

string[] AddToArray(string[] array, string newWord)
{
    string[] newArray = new string[array.Length + 1];
    Array.Copy(array, newArray, array.Length);
    newArray[array.Length] = newWord;

    return newArray;
}

string ReplacingWordsBackwards(string str)
{
    string newStr = "";
    string[] tempArray = new string[0];
    string newWord = "";
    foreach (char symbol in str)
    {
        if (symbol != ' ')
        {
            newWord += symbol;
        }
        else 
        {
            tempArray = AddToArray(tempArray, newWord);
            newWord = "";
            continue;
        }
    }
    tempArray = AddToArray(tempArray, newWord);
    Array.Reverse(tempArray);
    newStr = string.Join(" ", tempArray);
    return newStr;
}

Console.Clear();
Console.Write("Введите слова, разделённые пробелами: ");
string? str = Console.ReadLine();
string replacedStr = ReplacingWordsBackwards(str!);
Console.WriteLine($"\n\"{str}\" => \"{replacedStr}\"");
