﻿using System;
using System.Text;

public abstract class Provider : Mine
{
    private double energyOutput;

    protected Provider(string id, double energyOutput) 
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value <= 0 || value > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }
    
    public override string ToString()
    {
        string name = this.GetType().Name;
        int ind = name.IndexOf("Provider");
        name = name.Insert(ind, " ");

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{name} - {this.Id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");
        return sb.ToString().Trim();
    }

}
