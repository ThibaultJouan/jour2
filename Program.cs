var inputs = File.ReadAllLines("input.txt");

int result = 0;

foreach(string s in inputs)
{
    //result += Traitement.Part1(s, 12, 13, 14);
    result += Traitement.Part2(s);

}

Console.WriteLine(result);