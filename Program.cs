//Задача 1: Задайте двумерный массив символов (тип char [,]).
//Создать строку из символов этого массива.
bool IsInt(string input)
{
bool result = false;
    int justForTry = 0;
    result = int.TryParse(input , out justForTry);
    return result;
}
int EnterIntCycle(string input)
{
    int result = 0;
    while (IsInt(input) == false)
    {
            Console.WriteLine("Enter the integer please");
            input = Console.ReadLine();        
    }
    result = int.Parse(input);
    return result;
}
char GetRandomCharacter(string text, Random rng)
{
    int index = rng.Next(text.Length);
    return text[index];
}
char [,] GetTableChar(char[,] table , string randomText) 
{
    Random rng = new Random();
    for (int i = 0; i < table.GetLength(0); i++) 
    {
        for (int j = 0; j < table.GetLength(1); j++) 
        {
            table[i, j] = GetRandomCharacter(randomText, rng);
        }
    }
    return table;
}
void PrintTable(char[,] table) 
{
    for (int i = 0; i < table.GetLength(0); i++) 
    {
        for (int j = 0; j < table.GetLength(1); j++) 
        {
            Console.Write(table[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
string GetStringFromCharTable(char[,] table) 
{
    string str = String.Empty;
    for (int i = 0; i < table.GetLength(0); i++) 
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            str += table[i, j];
        }
    }
    return str;
}


//Console.WriteLine("Enter the row count");
//string strRow = Console.ReadLine();
//strRow ??= "NO DATA";
//int rowCount = EnterIntCycle(strRow);
//Console.WriteLine("Enter the cell count");
//string strCell = Console.ReadLine();
//strCell ??= "NO DATA";
//int cellCount = EnterIntCycle(strCell);
//char[,] tableChar = new char[rowCount,cellCount];
//Console.WriteLine("Text Entering");
//string randomText = Console.ReadLine();
//randomText ??= "NO DATA";
//GetTableChar(tableChar , randomText);
//PrintTable(tableChar);
//string mySTR = GetStringFromCharTable(tableChar);
//Console.WriteLine(mySTR);
//Console.ReadLine();


//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string text = "Hello World";
string newText = text.ToLower();
Console.WriteLine(newText);
Console.ReadLine();