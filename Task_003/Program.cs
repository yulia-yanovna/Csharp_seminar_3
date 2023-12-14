// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

bool IfPalindrome(string str)
{
    str = str!.ToLower(); 
        int fromLeft = 0;
        int fromRight = str!.Length - 1;

        while (fromLeft < fromRight)
        {
            if (str[fromLeft] != str[fromRight])
                return false; 
            fromLeft++;
            fromRight--;
        }
        return true;
}


//Console.Clear();
Console.Write("Веедите сроку в разном регистре: ");
string? str = Console.ReadLine();

if (IfPalindrome(str!))
    Console.WriteLine($"\n{str} => Да");
else
    Console.WriteLine($"\n{str} => Нет");