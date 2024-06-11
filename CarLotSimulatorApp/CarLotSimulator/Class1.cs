﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Class1
    {
    }
}


public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string noise)
    {
        Console.WriteLine($"The {Year} {Make} {Model} makes the following engine noise: {noise}");
    }

    public void MakeHonkNoise(string noise)
    {
        Console.WriteLine($"The {Year} {Make} {Model} makes the following honk noise: {noise}");
    }
}




