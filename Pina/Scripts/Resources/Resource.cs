﻿namespace Pina.Scripts.Resources;

public abstract class Resource
{
    public virtual void Unload()
    {
        Console.WriteLine($"Resource: [{GetType()}] is Unloaded");
    }
}