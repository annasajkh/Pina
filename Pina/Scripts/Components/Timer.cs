namespace Pina.Scripts.Components;

public sealed class Timer
{
    public float WaitTime { get; set; }
    public bool IsOneshot { get; set; }
    public float TimeLeft { get; private set; }
    public bool Paused { get; private set; }

    public event Action? OnTimeout;

    public Timer(float waitTime, bool isOneshot)
    {
        WaitTime = waitTime;
        IsOneshot = isOneshot;
    }

    public void Start()
    {
        Paused = false;
    }

    public void Stop()
    {
        Paused = true;
    }

    public void Step(float delta)
    {
        if (!Paused)
        {
            TimeLeft += delta;

            if (TimeLeft >= WaitTime)
            {
                TimeLeft = 0;

                if (OnTimeout != null)
                {
                    OnTimeout();
                }

                if (IsOneshot)
                {
                    Paused = true;
                }
            }
        }
    }
}