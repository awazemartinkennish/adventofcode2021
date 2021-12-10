namespace src;
public class Day2
{
    public int Part1(List<string> inputs)
    {
        int horizontal = 0;
        int veritical = 0;

        foreach (string instruction in inputs)
        {
            string[] instParts = instruction.Split(' ');
            int amount = int.Parse(instParts[1]);

            switch (instParts[0])
            {
                case "forward":
                    horizontal += amount;
                    break;
                case "down":
                    veritical += amount;
                    break;
                case "up":
                    veritical -= amount;
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        return horizontal * veritical;
    }
}
