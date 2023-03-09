
public class Star : SpaceObject
{

    public Startype Type { get; set; }
    public int Temperature { get; set; }
    public List<Planet> Planets { get; set; }

    public Star()
    {
        Planets = new List<Planet>();
    }

}
