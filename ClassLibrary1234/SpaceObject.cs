
public abstract class SpaceObject
{
    public enum Startype
    {
        YellowDwarf,
        White,
        BlueNeutron,
        RedGiant
    }
    public int Id { get; set; }
    public string Name { get; set; }

}