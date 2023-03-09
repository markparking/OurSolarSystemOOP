
public class Planet : SpaceObject
{
    public enum PlanetTypes
    {
        Terrestrial,
        Giant,
        Dwarf,
        GasGiant
    }
    public PlanetTypes PlanetType1 { get; set; }
    public double DiameterInMeters { get; set; }
    public List<Moon> Moons { get; set; }

    public Planet()
    {
        Moons = new List<Moon>();
    }

}
