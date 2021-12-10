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

    public int Part2(List<int> inputs)
    {
        List<int> slidingWindows = new();
        for(int i = 2; i < inputs.Count; i++)
        {
            slidingWindows.Add(inputs[i-2] + inputs[i-1] + inputs[i]);
        }

        return Part1(slidingWindows);
    }
}
