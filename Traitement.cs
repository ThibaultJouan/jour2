class Traitement
{
    public static int Part1(string input, int red, int green, int blue)
    {
        int foundBlue = 0;
        int foundRed = 0;
        int foundGreen = 0;
        var game = input.Split(':');
        var buff = game[1].Split(';');

        foreach(string s in buff)
        {
            var truc = s.Trim();
            var machin = truc.Split(',');

            foreach(string t in machin)
            {
                var final = t.Trim().Split(' ');

                switch(final[1])
                {
                    case "blue":
                        foundBlue = int.Parse(final[0]);
                        break;
                    case "red":
                        foundRed = int.Parse(final[0]);
                        break;
                    case "green":
                        foundGreen = int.Parse(final[0]);
                        break;
                    default:
                        break;
                }
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
        int foundBlue = 0;
        int foundRed = 0;
        int foundGreen = 0;
        var game = input.Split(':');
        var buff = game[1].Split(';');

        foreach(string s in buff)
        {
            var truc = s.Trim();
            var machin = truc.Split(',');

            foreach(string t in machin)
            {
                var final = t.Trim().Split(' ');

                switch(final[1])
                {
                    case "blue":
                        if(int.Parse(final[0]) > foundBlue)
                        {
                            foundBlue = int.Parse(final[0]);
                        }
                        break;
                    case "red":
                        if(int.Parse(final[0]) > foundRed)
                        {
                            foundRed = int.Parse(final[0]);
                        }
                        break;
                    case "green":
                        if(int.Parse(final[0]) > foundGreen)
                        {
                            foundGreen = int.Parse(final[0]);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        return foundBlue * foundGreen * foundRed;
    }
}