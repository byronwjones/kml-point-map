namespace BWJ.KmlPointMap;
public abstract class KmlElement
{
    internal KmlElement(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
