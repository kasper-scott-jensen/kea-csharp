namespace delegates_events;

public class CarEngine
{
    private bool _isEngineRunning;
    private int _currentEngineSpeed;

    public delegate void EngineStartHandler();
    public event EngineStartHandler? EngineStarted;

    public delegate void EngineStopHandler();
    public event EngineStopHandler? EngineStopped;

    public delegate void EngineSpeedChangeHandler(int speed);
    public event EngineSpeedChangeHandler? EngineSpeedChanged;

    public void StartEngine()
    {
        _isEngineRunning = true;
        EngineStarted?.Invoke();
    }

    public void StopEngine()
    {
        _isEngineRunning = false;
        EngineStopped?.Invoke();
    }

    public void SetEngineSpeed(int speed)
    {
        _currentEngineSpeed = speed;
        EngineSpeedChanged?.Invoke(_currentEngineSpeed);
    }
    
    
    
    

}