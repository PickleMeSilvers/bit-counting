// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine(CountBits(0));
Console.WriteLine(CountBits(4));
Console.WriteLine(CountBits(7));
Console.WriteLine(CountBits(10));

static int CountBits(int n)
{
    string binaryRepresentation = Convert.ToString(n, 2);

    return Regex.Matches(binaryRepresentation, "1").Count;
}