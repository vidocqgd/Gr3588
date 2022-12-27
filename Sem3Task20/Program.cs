int X1 = ReadData ("Введите координату X1: ");
int Y1 = ReadData ("Введите координату Y1: ");
int X2 = ReadData ("Введите координату X2: ");
int Y2 = ReadData ("Введите координату Y2: ");



int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double Distance (double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return distance;
}

void Printdata(string msg,double res)
{
    Console.WriteLine(msg + res);
}

Printdata("Расстояние между точками: ", Distance(X1, Y1, X2, Y2));