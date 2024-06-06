using System;

class RemoteControlCar
{
    private int distanceDriven=0;
    private int batteryLevel=100;

    public static RemoteControlCar Buy()
    {
        // Create a new instance of RemoteControlCar
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return "Driven " + distanceDriven + " meters";
    }

    public string BatteryDisplay()
    {   if(batteryLevel==0){
        return "Battery empty";
    }
        return "Battery at " + batteryLevel+ "%";
    }

    public void Drive()
    {
        // Assuming each drive consumes some battery and increases distance driven
        if (batteryLevel > 0)
        {
            distanceDriven += 20; // Just an example increment
            batteryLevel -= 1;    // Just an example decrement
            Console.WriteLine("Car is being driven.");
        }
        else
        {
             Console.WriteLine("Battery empty");
        }
    }

    static void Main(string[] args)
    {
        RemoteControlCar car = RemoteControlCar.Buy();
        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine(car.BatteryDisplay());
        car.Drive();
        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine(car.BatteryDisplay()); 
    } 
}
