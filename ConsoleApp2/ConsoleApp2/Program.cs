// See https://aka.ms/new-console-template for more information
char ans;
int num;
Console.WriteLine("This is a multiplication table program ");

do
{
    do
    {
        Console.Write("Multiplication table of: ");
        num = int.Parse(Console.ReadLine());
        if (num <= 0)
            Console.WriteLine("Please enter a numer greater than 0");
    } while (num <= 0);

    for (int i = 1; i <= 12; i++)
        Console.WriteLine(num + " * " + i + " = " + num * i);

    Console.Write("Do you want to go again (y/n)? ");
    ans = char.Parse(Console.ReadLine());

} while (ans == 'Y' || ans == 'y');