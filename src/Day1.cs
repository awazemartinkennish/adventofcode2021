namespace src;
public class Day1
{
    public int Part1(List<int> inputs)
    {
        int count = 0;
        for(int i = 1; i < inputs.Count; i++)
        {
            if (inputs[i] > inputs[i-1]) count++;
        }

        return count;
    }
}
