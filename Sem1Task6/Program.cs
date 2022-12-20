string? numLine = Console.ReadLine();

if (numLine !=null)

{
    int number = int.Parse(numLine);

    int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}    

}
