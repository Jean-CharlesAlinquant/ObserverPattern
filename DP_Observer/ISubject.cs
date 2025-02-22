namespace DesignPatterns.Observer;

public interface ISubject
{
    void Attach(IObserver observer);
    void Notify();
}
