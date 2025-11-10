using BWJ.KmlPointMap.Styling;
using System.Web;

namespace BWJ.KmlPointMap;
public sealed class Placemark : KmlChildElement
{
    public Placemark(string name) : base(name) { }
    public Placemark(string name, string address) : base(name)
    {
        Address = address;
    }
    public Placemark(string name, Point coordinates) : base(name)
    {
        Coordinates = coordinates;
    }
    public Placemark(string name, double latitude, double longitude) : base(name)
    {
        Coordinates = new Point(latitude, longitude);
    }

    public string? Address { get; set; }
    public Point Coordinates { get; set; } = new Point();

    public string? Style { get; set; }

    public string? Description { get; set; }

    public override string ToString()
    {
        return string.IsNullOrWhiteSpace(Address) ?
            $"{Name}@{Coordinates}"
            :
            $"{Name}@{Address}";
    }

    internal override string Write(string defaultStyleId, PlacemarkStyle[] styles)
    {
        var styleId = defaultStyleId;
        if (string.IsNullOrWhiteSpace(Style) == false)
        {
            var style = styles.FirstOrDefault(s => s.Uri == Style);
            if (style is not null)
            {
                styleId = style.Id;
            }
        }

        var location = string.IsNullOrWhiteSpace(Address) ?
            Coordinates.Write()
            : $"<address>{HttpUtility.HtmlEncode(Address)}</address>";

        var d = string.Empty;
        if(string.IsNullOrWhiteSpace(Description) == false)
        {
            d = $"<description><![CDATA[{Description}]]> </description>";
        }

        var kml = $@"
		<Placemark>
			<name>{HttpUtility.HtmlEncode(Name)}</name>
			<visibility>{(Visible ? 1 : 0)}</visibility>
			{d}
			<styleUrl>#sm_{styleId}</styleUrl>
			{location}
		</Placemark>
".Trim();
        return kml;
    }
}
