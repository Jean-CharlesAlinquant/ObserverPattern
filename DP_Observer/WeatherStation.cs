namespace DesignPatterns.Observer;

public class WeatherStation : ISubject
{
    private List<IObserver> _observers;
    private float _temperature;
    public float Temperature
    {
        get { return _temperature; }
        set
        {
            _temperature = value;
            Notify();
        }
    }

    public WeatherStation()
    {
        _observers = new List<IObserver>();
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Notify()
    {
        _observers.ForEach(observer => observer.Update(this));
    }
}
