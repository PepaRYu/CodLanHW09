Console.WriteLine("Введите первое число");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start , int end)
{
    if (start == end) return start.ToString();
    
    return (start + ", " + PrintNumbers(++start, end));
    
}
Console.WriteLine(PrintNumbers(N, M));
