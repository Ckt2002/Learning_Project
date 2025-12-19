using System;

public class CS_ObPlayerChangeEvent : CS_IUIChangeSubject
{
    private event Action<CS_ObEChangeType, int> OnEventRaised;

    public void NotifyObservers(CS_ObEChangeType changeType, int value)
    {
        OnEventRaised?.Invoke(changeType, value);
    }

    public void RegisterObserver(CS_IUIListener observer)
    {
        OnEventRaised += observer.OnNotify;
    }

    public void UnregisterObserver(CS_IUIListener observer)
    {
        OnEventRaised -= observer.OnNotify;
    }
}