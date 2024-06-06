using System;
class Lasagna
{
    public int ExpectedMinutesInOven(){
        return 40;
        
    }
    public int RemainingMinutesInOven(int a){
        return ExpectedMinutesInOven()-a;
        
    }
    public int PreparationTimeInMinutes(int b){
        return b*2;
    }

    public int ElapsedTimeInMinutes(int c, int d){
        return c*2+d;
    }
    static void Main(string[] args){  
Lasagna lasagna= new Lasagna();
Console.WriteLine(lasagna.ExpectedMinutesInOven());
Console.WriteLine(lasagna.RemainingMinutesInOven(30));
Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));
    }
   

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}

