﻿using GettingStarted;
using GettingStarted.Notebooks;

public class Program
{
    public static async Task Main(string[] args)
    {
        INotebook notebook = new OLSRealWorld();
        await notebook.Execute();
    }
}
