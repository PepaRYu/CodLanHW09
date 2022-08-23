Console.WriteLine("Введите первое число");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());


int SumDigits(int first, int second ){
    if (first == second)  return first;
    return first+SumDigits(++first, second);
}

Console.WriteLine(SumDigits(N, M));