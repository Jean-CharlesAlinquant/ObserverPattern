namespace DesignPatterns.Observer;

public record NewsAgency(string AgencyName) : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject is WeatherStation weatherStation)
        {
            float temperature = weatherStation.Temperature;
            Console.WriteLine($"{AgencyName} updated that temperature has changed to {temperature}");
        }
    }
}