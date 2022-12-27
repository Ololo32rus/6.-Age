// N - кол-во людей. Определить ск людей до 1985 г.р. < и > 1990 г.р.

int OldSum;
int YoungSum;
int People;
int Old;
int Young;
int[] AllPeople;

Random rnd = new Random();

Console.Write($"Введите количество людей в группе = ");
People = int.Parse(Console.ReadLine());

AllPeople = new int[People];

for (int i = 0; i < AllPeople.Length; i++)
{
    AllPeople[i] = rnd.Next(1950, 2010);
}
for (int i = 0; i < AllPeople.Length; i++)
{
    Console.WriteLine($"{AllPeople[i]}");
}

Console.WriteLine();

OldSum = 0; YoungSum = 0;

for (int i = 0; i < AllPeople.Length; i++)
{
    if (AllPeople[i] < 1985)
    {
        OldSum ++;
    }
    else if (AllPeople[i] > 1990)
    {
        YoungSum ++;
    }
}


Console.WriteLine($" Old People < 1985 = {OldSum} ");
Console.WriteLine($" Young People > 1990 = {YoungSum} ");
