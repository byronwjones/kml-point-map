using BWJ.KmlPointMap.Styling;

namespace BWJ.KmlPointMap;
public abstract class KmlChildElement : KmlElement
{
    internal KmlChildElement(string name) : base(name) { }

    public bool Visible { get; set; } = true;
    public KmlElement? Parent { get; set; }

    internal virtual string Write(string defaultStyleId, PlacemarkStyle[] styles)
    {
        throw new NotImplementedException();
    }
}
