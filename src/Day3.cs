namespace src;
public class Day3
{
    public (int gamma, int epsilon, int powerConsumption) Part1(List<string> inputs)
    {
        int inputWidth = inputs[0].Length;

        int[] ones = new int[inputWidth];
        int[] zeroes = new int[inputWidth];

        foreach (string item in inputs)
        {
            for (int i = 0; i < item.Length; i++)
            {
                char val = item[i];

                if (val == '1') ones[i]++;
                else if (val == '0') zeroes[i]++;
            }
        }

        int gamma = 0;
        int epsilon = 0;
        for (int i = 0; i < inputWidth; i++)
        {
            int increase = Convert.ToInt32(Math.Pow(2, inputWidth - i - 1));

            if (ones[i] > zeroes[i]){
                gamma += increase;
            } else {
                epsilon += increase;
            }
        }

        return (gamma, epsilon, gamma * epsilon);
    }
}
