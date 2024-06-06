using System;

class WeighingMachine
{
    private double _weight;

    
    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
    public int Precision { get; }

    
    public double Weight { 
        get=>_weight;
        set=> _weight =value >= 0 ? value : throw new ArgumentOutOfRangeException(); }

    
   public string DisplayWeight => $"{Math.Round(Weight - TareAdjustment, Precision).ToString($"F{Precision}")} kg";

    // TareAdjustment property
    public double TareAdjustment { get; set; } =5.0;
}
