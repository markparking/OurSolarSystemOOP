
class Program
{
    static void Main(string[] args)
    {
        Star sun = new Star { Name = "Sun", Type = Star.Startype.YellowDwarf, Temperature = 5504 };
        Planet mercury = new Planet { Name = "Mercury", PlanetType1 = Planet.PlanetTypes.Terrestrial, DiameterInMeters = 4879 };
        Planet venus = new Planet { Name = "Venus", PlanetType1 = Planet.PlanetTypes.Terrestrial, DiameterInMeters = 12104 };
        Planet earth = new Planet { Name = "Earth", PlanetType1 = Planet.PlanetTypes.Terrestrial, DiameterInMeters = 12742 };
        Planet mars = new Planet { Name = "Mars", PlanetType1 = Planet.PlanetTypes.Terrestrial, DiameterInMeters = 6779 };
        Planet jupiter = new Planet { Name = "Jupiter", PlanetType1 = Planet.PlanetTypes.Giant, DiameterInMeters = 139822 };
        Planet saturn = new Planet { Name = "Saturn", PlanetType1 = Planet.PlanetTypes.Giant, DiameterInMeters = 116460 };
        Planet uranus = new Planet { Name = "Uranus", PlanetType1 = Planet.PlanetTypes.Giant, DiameterInMeters = 50724 };
        Planet neptune = new Planet { Name = "Neptune", PlanetType1 = Planet.PlanetTypes.Giant, DiameterInMeters = 49244 };
        Moon luna = new Moon { Name = "Luna", DiameterInMeters = 3474, Orbiting = earth };
        Moon titan = new Moon { Name = "Titan", DiameterInMeters = 5150, Orbiting = saturn };
        Moon phobos = new Moon { Name = "Phobos", DiameterInMeters = 22.2, Orbiting = mars };
        Moon europa = new Moon { Name = "Europa", DiameterInMeters = 222.2, Orbiting = jupiter, Moons = new List<Moon>() };
        Moon deimos = new Moon { Name = "Deimos", DiameterInMeters = 12.4, Orbiting = mars };
        Moon ganymedes = new Moon { Name = "Ganymedes", Orbiting = jupiter };
        Moon io = new Moon { Name = "Io", DiameterInMeters = 3643, Orbiting = jupiter };
        Moon mimas = new Moon { Name = "Mimas", DiameterInMeters = 396, Orbiting = saturn };

        List<SpaceObject> spaceObjects = new List<SpaceObject>();
        List<Moon> moons = new List<Moon>();

        spaceObjects.Add(sun);
        spaceObjects.Add(mercury);
        spaceObjects.Add(venus);
        spaceObjects.Add(earth);
        spaceObjects.Add(mars);
        spaceObjects.Add(jupiter);
        spaceObjects.Add(saturn);
        spaceObjects.Add(uranus);
        spaceObjects.Add(neptune);

        moons.Add(luna);
        moons.Add(titan);
        moons.Add(phobos);
        moons.Add(europa);
        moons.Add(deimos);
        moons.Add(ganymedes);
        moons.Add(io);
        moons.Add(mimas);

        Console.WriteLine("Stars:");
        foreach (var star in spaceObjects.OfType<Star>())
        {
            Console.WriteLine($"{star.Name}, Type: {star.Type}, Temperature: {star.Temperature} °C");
        }

        Console.WriteLine("\nPlanets:");
        foreach (var planet in spaceObjects.OfType<Planet>())
        {
            Console.WriteLine($"{planet.Name}, Type: {planet.PlanetType1}, Diameter: {planet.DiameterInMeters} km\n");
        }

        Console.WriteLine("\nMoons:");
        foreach (var moon in moons.OfType<Moon>())
        {
            Console.WriteLine($"{moon.Name}, Diameter: {moon.DiameterInMeters} km, \nOrbiting: {moon.Orbiting.Name}\n");
        }

    }
}
