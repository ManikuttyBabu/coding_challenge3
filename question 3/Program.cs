using System;


decimal[] decimals = new decimal[4];
Console.WriteLine("Enter the flight fares:");
for (int i = 0; i < decimals.Length; i++)
{
    decimals[i] = Convert.ToDecimal(Console.ReadLine());
}
Console.WriteLine("The flight fares are:");
for (int i = 0; i < decimals.Length; i++)
{
    Console.WriteLine(decimals[i]);
}
for (int i = 0; i < decimals.Length; i++)
    for (int j = i+1; j < decimals.Length; j++)
        if (decimals[i] < decimals[j])
        {
            decimal temp = decimals[i];
            decimals[i] = decimals[j];
            decimals[j] = temp;
        }
Console.WriteLine("After sorting in asscending order:");
for (int i = 0; i < decimals.Length; i++)
{
    Console.WriteLine(decimals[i]);
}
Console.WriteLine("next qstn");
for (int i = 0; i < decimals.Length; i++)
    for (int j = i+1; j < decimals.Length; j++)
        if (decimals[i] > decimals[j])
        {
            decimal temp = decimals[i];
            decimals[i] = decimals[j];
            decimals[j] = temp;
        }
Console.WriteLine("After sorting in desscending order:");
for (int i = 0; i < decimals.Length; i++)
{
    Console.WriteLine(decimals[i]);
}

Console.WriteLine("nxt qstn");
Console.WriteLine("Enter the fare to searched");
decimal n = Convert.ToDecimal(Console.ReadLine());
int Count = 0;
decimal teamp = 0;
for (int i = 0; i < decimals.Length; i++)
{
    if (decimals[i] == n)
    {

        Count++;
        teamp = decimals[i];
    }

}
if (Count == 0)
{
    Console.WriteLine("not found");
}
else
    Console.WriteLine("search is successfull" + " " + teamp);

Console.WriteLine("nxt qstn");
decimal max = decimals[0];

for (int i = 1; i < decimals.Length; i++)
    if (max < decimals[i])
    {
        max = decimals[i];
    }

Console.WriteLine("Maximum value is:" + " " + max);




Console.WriteLine("nxt qstn");
decimal min = decimals[0];

for (int i = 1; i < decimals.Length; i++)
    //min sep varibel
    if (min > decimals[i])
    {
        min = decimals[i];
    }
Console.WriteLine("Minimum value is:" + " " + min);


Console.WriteLine("nxt qstn");
decimal d = 0;
for (int i = 0;  i < decimals.Length; i++)
    for (int j = i + 1; j < decimals.Length; j++)
    {
        if (decimals[i] == decimals[j])
        {
            
           
            d++;
            Console.WriteLine("Duplicated element is" + " " + decimals[i]);
        }
        
    }
if (d == 0)
{
    Console.WriteLine("no duplicate elements");
    
}

