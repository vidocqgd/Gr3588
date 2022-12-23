System.Random numberSintezator = new System.Random();

int number = numberSintezator.Next(100,1000);

Console.WriteLine(number);

int firstnumber=number/100;
int secondnumber=number%10;

int result = firstnumber*10 + secondnumber;
Console.WriteLine (result);

