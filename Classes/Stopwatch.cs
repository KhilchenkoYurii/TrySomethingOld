namespace Classes;

public class Stopwatch
{
    private DateTime? _startTime;
    private DateTime? _endTime;
    private bool? _isDouble = null;
    private double _secondsAmount = 0;

    public void Start()
    {
        if (_isDouble == true)
            throw new Exception("you can`t start two time in a row");
        _startTime = DateTime.Now;
        _isDouble = true;
    }

    public void Stop()
    {
        if(_isDouble == false)
            throw new Exception("you can`t stop two time in a row");
        if (_startTime == new DateTime(1, 1, 1))
            throw new Exception("you need to start first");
        _endTime = DateTime.Now;
        _secondsAmount += (_endTime - _startTime).GetValueOrDefault().TotalSeconds;
        Console.WriteLine("Seconds: " + Double.Round(_secondsAmount,2));
        _isDouble = false;
    }

    public void Reset()
    {
        _startTime = null;
        _endTime = null;
        _isDouble = null;
        _secondsAmount = 0;
    }
}