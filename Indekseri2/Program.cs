using Indekseri2;

Student A = new("0123456789");
Console.WriteLine(A);

byte[,] bod =
{
    {2,1},
    {3,2},
    {4,3}
};
Student B = new("1234353679", bod);
Console.WriteLine(B[3, 1]);
A[1, 2] = 5;
Console.WriteLine(A);
Console.WriteLine(B[1]);

Kolegij Analiza = new("Analiza", "001");
Analiza[0] = new[] { A, B };
Analiza[1] = new[]
{
    new Student("1234554321", new byte[,]{{1,2},{3,4},{1,2}}),
    new Student("1234554322", new byte[,]{{2,2},{5,4},{0,2}}),
    new Student("1234554323", new byte[,]{{4,2},{3,1},{1,3}})
};

/* Console.WriteLine("Unesite jmbag studenta:");
var jmbag = Console.ReadLine();
if (jmbag != null)
    Console.WriteLine(Analiza[jmbag]);

try
{
    Console.WriteLine(Analiza[1][1][1, 6]);
}
catch(IndexOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}

int[] niz = { 9, 1, 6, 5, 3 };
Index i = ^3;
Console.WriteLine(niz[i]);
*/

foreach (Student student in Analiza[^1])
{
    Console.WriteLine(student);
}

//Index a = 1;
//Analiza[a] = new[] { A, B };

int[] niz = { 1, 2, 3, 4, 5 };
Range r = ^2..;
foreach (var br in niz[r])
{
    Console.WriteLine(br);
}

Range raspon = 0..1;
foreach (Student[] grupa in Analiza[raspon])
{
    foreach(Student student in grupa)
    {
        Console.WriteLine(student);
    }   
}