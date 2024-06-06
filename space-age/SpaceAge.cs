using System;

public class SpaceAge
{   
    private readonly int seconds;

    // Orbital periods for each planet in Earth years
    private const double EarthYearInSeconds = 31557600.0;
    private const double MercuryOrbitalPeriod = 0.2408467;
    private const double VenusOrbitalPeriod = 0.61519726;
    private const double MarsOrbitalPeriod = 1.8808158;
    private const double JupiterOrbitalPeriod = 11.862615;
    private const double SaturnOrbitalPeriod = 29.447498;
    private const double UranusOrbitalPeriod = 84.016846;
    private const double NeptuneOrbitalPeriod = 164.79132;

    public SpaceAge(int seconds)
    {  
        this.seconds = seconds;
    }
    
    public double OnEarth()
{     
    return seconds / EarthYearInSeconds;
}

public double OnMercury()
{    
    return OnEarth() / MercuryOrbitalPeriod;
}

public double OnVenus()
{    
    return OnEarth() / VenusOrbitalPeriod;
}

public double OnMars()
{    
    return OnEarth() / MarsOrbitalPeriod;
}

public double OnJupiter()
{    
    return OnEarth() / JupiterOrbitalPeriod;
}

public double OnSaturn()
{    
    return OnEarth() / SaturnOrbitalPeriod;
}

public double OnUranus()
{    
    return OnEarth() / UranusOrbitalPeriod;
}

public double OnNeptune()
{    
    return OnEarth() / NeptuneOrbitalPeriod;
}

}
