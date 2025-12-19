public interface CS_IUIListener
{
    void OnNotify(CS_ObEChangeType changeType, int value);
}

public interface CS_IUIChangeSubject
{
    void RegisterObserver(CS_IUIListener observer);
    void UnregisterObserver(CS_IUIListener observer);
    void NotifyObservers(CS_ObEChangeType changeType, int value);
}