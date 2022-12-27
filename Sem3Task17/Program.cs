int coordX = ReadData ("Введите коордигату X");
int coordY = ReadData ("Введите коордигату Y");
PrintQuterTest();

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintQuterTest()
{
    if (coordX > 0 && coordY > 0) Console.WriteLine("Точка в четверти 1");
    if (coordX > 0 && coordY < 0) Console.WriteLine("Точка в четверти 2");
    if (coordX < 0 && coordY < 0) Console.WriteLine("Точка в четверти 3");
    if (coordX < 0 && coordY > 0) Console.WriteLine("Точка в четверти 4");
}



