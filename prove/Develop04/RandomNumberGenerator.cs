using System.Diagnostics.Metrics;
using System.Net.Http.Headers;

public class RandomNumberGenerator
{
    private int _randomNumber;
    private int _counter = 0;
    private List<int> _randomNumbers = new List<int>();

    public RandomNumberGenerator(int range)
    {
        GenerateRandomNumberList(range);
    }

    private void GenerateRandomNumberList(int range)
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i <= range-1; i++)
        {
            numbers.Add(i); 
        }
        _randomNumbers = numbers.OrderBy(x => Guid.NewGuid()).ToList();
    }

    public int GetRandomNumber(int range)
    {
        _randomNumber = _randomNumbers[_counter];

        _counter++;

        if (_counter == _randomNumbers.Count)
        {
            _counter = 0;
        }

        return _randomNumber;
    }
}

