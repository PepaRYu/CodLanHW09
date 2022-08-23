Console.WriteLine("Введите первое число");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int M = Convert.ToInt32(Console.ReadLine());


int Akkerman(int first , int second){
    if (first == 0) return second + 1;
    if ((second == 0) && (first != 0)) return Akkerman(first - 1, 1 );
    return Akkerman(first - 1 , Akkerman(first ,  second - 1));
}

Console.WriteLine(Akkerman(N, M));