using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {   return [0,2,5,3,7,8,4];
        throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {   return birdsPerDay[birdsPerDay.Length-1];
        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public int IncrementTodaysCount()
    {   return birdsPerDay[birdsPerDay.Length - 1]++;
        throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int count in birdsPerDay)
        {
            // If any count is zero, return true
            if (count == 0)
            {
                return true;
            }
        }
        // If no count is zero, return false
        return false;
        throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int a=0;
        for(int i=0;i<numberOfDays;i++){
            a+=birdsPerDay[i];
        }
        return a;
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {   int a=0;
        for(int i=0;i<birdsPerDay.Length;i++){
            if(birdsPerDay[i]>=5){
            a+=1;
        }}
        return a; 
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
