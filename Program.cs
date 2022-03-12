double sum = 0;
int nomre;
int m = 0;
int x = -1;
System.Console.WriteLine("nomre bede");
do
{
    nomre = Convert.ToInt32(Console.ReadLine());
    sum = sum + nomre;
    x++;
    m = m = nomre;
} while (nomre <= 20 && nomre != 0);
System.Console.WriteLine(sum / x);