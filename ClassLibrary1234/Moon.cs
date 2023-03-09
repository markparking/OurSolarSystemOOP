

public sealed class Moon : Planet
{
    public Planet Orbiting { get; set; }
    public PlanetTypes PlanetType1 { get; } = PlanetTypes.Dwarf;

    public Moon()
    {
        // Set default values
        DiameterInMeters = 3474;
        Moons = new List<Moon>();
    }

}
