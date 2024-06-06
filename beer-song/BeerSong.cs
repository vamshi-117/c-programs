using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {

        StringBuilder output = new StringBuilder();
        int currentBottles = startBottles;

        for(int i=0; i < takeDown; i++)
        {
            int nextBottles = currentBottles - 1;
            
            if(currentBottles == 0)
            {
                output.Append("No more bottles of beer on the wall, no more bottles of beer.\n" + "Go to the store and buy some more, 99 bottles of beer on the wall.");

                return output.ToString();            
            }
            
            if(currentBottles == 1)
            {
            output.Append($"{currentBottles} bottle of beer on the wall, {currentBottles} bottle of beer.\n" + $"Take it down and pass it around, no more bottles of beer on the wall.");
                currentBottles--;
                
                if(i < takeDown -1)
                {
                    output.Append($"\n\n");
                }
                
                if(i == takeDown -1)
                {
                    return output.ToString();
                }
                continue;
            }
            
            if(currentBottles == 2)
            {
                output.Append($"{currentBottles} bottles of beer on the wall, {currentBottles} bottles of beer.\n" + $"Take one down and pass it around, {nextBottles} bottle of beer on the wall.");
                
                currentBottles--; 

                if(i < takeDown -1)
                {
                    output.Append($"\n\n");
                }
                
                if(i == takeDown -1)
                {
                    return output.ToString();
                }
                 
                continue;
            }
                
            output.Append($"{currentBottles} bottles of beer on the wall, {currentBottles} bottles of beer.\n" + $"Take one down and pass it around, {nextBottles} bottles of beer on the wall.");
            currentBottles--;

            if(i < takeDown -1)
            {
                output.Append($"\n\n");
            }
        }

        return output.ToString();
    }
}