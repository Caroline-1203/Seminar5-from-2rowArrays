// Считать строку с консоли, содержащую латинские буквы.
//  Вывести на экран согласные буквы этой строки.
string str = getString();
PrintString(str);
string getString()
{
    Console.WriteLine("Введите строку ...");
    string str = Console.ReadLine();
    return str;

}
bool IsVowel(char c)
    {
        return c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';

    }
void PrintString(string str, int index = 0)

{
    
    if (index < str.Length)
    {
        char c = Char.ToUpper(str[index]);

        if ((c >= 'A' && c<= 'Z')  && !IsVowel(c))
        {
                Console.Write(c+ " ");
            }
PrintString(str, index + 1);


    }

}


