using System;

public class Player
{
    public int RollDie()
    {
        Random rand = new Random();
        return rand.Next(1,18);
        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
        Random rand = new Random();
        return rand.NextDouble()*99.0; 
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}
