using System.Diagnostics;

//Nev10();
//IsmeretlenN();
//Visszaszamol();
//Mozog();
//Csillagok();
//Paratlan();
//SzamtaniSorozat();
//Fahrenheit();
//Oszotok();
//ElsoUtolso();
//Fibonacci();
//Forditva();
//AtlosNev();
Pseudo();

static void Nev10()
{
    string name = "Juhasz Zoltan";

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{i + 1,2}. {name}");
    }
}
static void IsmeretlenN()
{
    Console.Write("irjon be egy egesz szamot: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("irjon be egy tetszoleges szoveget: ");
    string t = Console.ReadLine();

    for (int i = 0; i < n; i++)
    {
        Console.Write($"{t} ");
    }
}
static void Visszaszamol()
{
    for (int i = 10; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(250);
        for (int j = 0; j < 3; j++)
        {
            Console.Write(".");
            Thread.Sleep(100);
        }
        Console.Clear();
    }
    Console.WriteLine("lejárt az idő!");
    Thread.Sleep(2000);
    Environment.Exit(0);
}
static void Csillagok()
{
    Random rnd = new();
    for (int x = 0; x < 200; x++)
    {
        Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);

        Console.SetCursorPosition(
            rnd.Next(Console.WindowWidth),
            rnd.Next(Console.WindowHeight));
        Console.Write("*");
    }
}
static void Mozog()
{
    Console.CursorVisible = false;
    Random rnd = new();
    string nev = "Juhasz Zoltan Mate";
    for (int i = 0; i < 100; i++)
    {
        Console.Clear();
        Console.SetCursorPosition(
            left: rnd.Next(Console.WindowWidth - nev.Length),
            top: rnd.Next(Console.WindowHeight));
        Console.Write(nev);
        Thread.Sleep(400);
    }
    Console.CursorVisible = true;
}
static void Paratlan()
{
    for (int i = 99; i >= 1; i-=2)
    {
        Console.Write(i + " ");
    }
}
static void SzamtaniSorozat()
{
    Console.Write("szamtani sorozat elso tagja: ");
    int a = int.Parse(Console.ReadLine());
    
    Console.Write("szamtani sorozat differencialja: ");
    int d = int.Parse(Console.ReadLine());
    Console.Write("attmpt01: ");
    for (int i = 0; i < 20; i++)
    {
        Console.Write($"{a + i * d} ");
    }
    Console.Write("\nattmpt02: ");
    for (int a0 = a; a0 < a + (d*20); a0+=d)
    {
        Console.Write($"{a0} ");
    }
    Console.Write("\n");
}
static void Fahrenheit()
{
    for (int c = -30; c <= 30; c++)
    {
        Console.WriteLine($"{c,3}°C == {c * 1.8 + 32,5:0.0}°F");
    }
}
static void Oszotok()
{
    Console.Write("irjon be egy pozitiv egesz szamot: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write($"{n} osztoi: 1, ");
    for (int i = 2; i <= n/2; i++)
    {
        if (n % i == 0) Console.Write(i + ", ");
    }
    if (n != 1) Console.WriteLine($"{n}.");
}
static void ElsoUtolso()
{
    Stopwatch sw = new();

    Console.Write("atmpt 1:");
    sw.Start();
    for (int i = 100; i <= 999; i++)
    {
        string szam = $"{i}";
        if (szam[0] == szam[2])
        {
            Console.Write(i + " ");
        }
    }
    sw.Stop();
    Console.WriteLine($"\nidő: {sw.Elapsed.TotalSeconds}");
    sw.Reset();
    Console.Write("\natmpt 2:");
    sw.Start();
    for (int i = 100; i <= 999; i++)
    {
        if (i % 100 % 10 == i / 100)
        {
            Console.Write($"{i} ");
        }
    }
    sw.Stop();
    Console.WriteLine($"\nidő: {sw.Elapsed.TotalSeconds}");
}
static void Fibonacci()
{
    int a1 = 1;
    int a2 = 1;

    Console.Write("Fibonacci sorozat:\n1, 1, ");
    for (int i = 0; i < 20; i++)
    {
        int s = a1 + a2;
        Console.Write(s +", ");
        a1 = a2;
        a2 = s;
    }
}
static void Forditva()
{
    Console.Write("input szoveg: ");
    string szoveg = Console.ReadLine();

    //             0    1    2    3
    // "cica" -> ['c', 'i', 'c', 'a'] --> len:  4

    Console.Write("output szoveg: ");
    for (int i = szoveg.Length - 1; i >= 0; i--)
    {
        Console.Write(szoveg[i]);
    }
}
static void AtlosNev()
{
    string nev = "Juhasz Zoltan";
    for (int i = 0; i < nev.Length; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("  ");
        }
        Console.WriteLine(nev[i]);
    }
}

static void Pseudo()
{
    int i, j;

    for (i = 5; i >= 0; i--)
    {
        for (j = 0; j <= 5; j++)
        {
            if (i == j) Console.Write("1");
            else Console.Write("0");
        }
        Console.Write("\n");
    }
}
Console.ReadKey(true);