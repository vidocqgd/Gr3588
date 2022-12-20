string? numLine = Console.ReadLine();

if (numLine !=null)

{
    int number = int.Parse(numLine);

    int evenNumber = 2;

if(number > 1)
{
    while(evenNumber < number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }

}

}