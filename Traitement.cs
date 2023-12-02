using System.Text.RegularExpressions;

class Traitement
{
    public static int Part1(string input, int red, int green, int blue)
    {
        Regex regRed = new Regex(@"(\d+) red");
        Regex regBlue = new Regex(@"(\d+) blue");
        Regex regGreen = new Regex(@"(\d+) green");
        int foundBlue = 0;
        int foundRed = 0;
        int foundGreen = 0;
        var game = input.Split(':');
        var buff = game[1].Split(';');

        foreach(string s in buff)
        {
            Match sRed = regRed.Match(s);
            Match sBlue = regBlue.Match(s);
            Match sGreen = regGreen.Match(s);

            if(sRed.Captures.Count > 0 && foundRed < int.Parse(sRed.Groups[1].Value))
            {
                foundRed = int.Parse(sRed.Groups[1].Value);
            }
            if(sBlue.Captures.Count > 0 && foundBlue < int.Parse(sBlue.Groups[1].Value))
            {
                foundBlue = int.Parse(sBlue.Groups[1].Value);
            }
            if(sGreen.Captures.Count > 0 && foundGreen < int.Parse(sGreen.Groups[1].Value))
            {
                foundGreen = int.Parse(sGreen.Groups[1].Value);
            }
            if(foundBlue > blue || foundGreen > green || foundRed > red)
            {
                return 0;
            }
            foundBlue = 0;
            foundRed = 0;
            foundGreen = 0;
        }

        var result = game[0].Split();
        return int.Parse(result[1]);
    }

    public static int Part2(string input)
    {
        Regex regRed = new Regex(@"(\d+) red");
        Regex regBlue = new Regex(@"(\d+) blue");
        Regex regGreen = new Regex(@"(\d+) green");
        int foundBlue = 0;
        int foundRed = 0;
        int foundGreen = 0;
        var game = input.Split(':');
        var buff = game[1].Split(';');

        foreach(string s in buff)
        {
            Match red = regRed.Match(s);
            Match blue = regBlue.Match(s);
            Match green = regGreen.Match(s);

            if(red.Captures.Count > 0 && foundRed < int.Parse(red.Groups[1].Value))
            {
                foundRed = int.Parse(red.Groups[1].Value);
            }
            if(blue.Captures.Count > 0 && foundBlue < int.Parse(blue.Groups[1].Value))
            {
                foundBlue = int.Parse(blue.Groups[1].Value);
            }
            if(green.Captures.Count > 0 && foundGreen < int.Parse(green.Groups[1].Value))
            {
                foundGreen = int.Parse(green.Groups[1].Value);
            }
        }

        return foundBlue * foundGreen * foundRed;
    }
}