// N - кол-во людей. Определить ск людей до 1985 г.р. < и > 1990 г.р.

/*
int old = 0;
int young = 0;
 int N = 100;                           // количество людей
    Random rnd = new Random ();         // рандомное число Г.Р.
int A = rnd .Next (1950, 2010);         // диапазон Г.Р.

for (int i = 1; i < N + 1; i++)           // задаём цикл на кол-во людей
{

    if (A <= 1985)                      // Ставим условие для рандома
    { i += old + i; }                    // При выполнении условия 

    Console.WriteLine($"Старпёры {old} ");
это я пытался через цикл и if, но не придумал как присвоить людей к году рождения... белебирду выдаёт 
потом думал через массив но чот отмёл эту идею (Тоже думал как присвоить чуваков к возрасту), и опять вернулся к нему после хз ск времени*/

int Old = 0;
int Young = 0;
int People ;
Console.Write($"Введите количество людей в группе = ");
    People = int.Parse(Console.ReadLine());
        int[] N = new int[People] ;

Random rnd = new Random();        
int A = rnd.Next(1950, 2010);

for (int i = 0; i < N.Length; i++)
{

    if (N[A] < 1985) 
        Old += i;
    if (N[A] > 1990)
        Young += i ;
}
Console.WriteLine($" Миллиниалов {Young} \n Старпёров {Old}" );

