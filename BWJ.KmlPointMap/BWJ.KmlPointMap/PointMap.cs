using BWJ.Core.Chronology;
using BWJ.KmlPointMap.Styling;
using System.Text;
using System.Web;

namespace BWJ.KmlPointMap;
public sealed class PointMap : KmlElement
{
    public PointMap(string name) : base(name)
    {
        DefaultStyle = PlacemarkStyles.Pushpin.Yellow;
    }

    private string defaultStyle = string.Empty;
    public string DefaultStyle
    {
        get { return defaultStyle; }
        set
        {
            defaultStyle = value;
            if(Styles.Any(s => s.Uri == value) == false)
            {
                Styles.Add(new PlacemarkStyle(value, GetStyleId(value)));
            }
        }
    }

    public void AddChild(KmlChildElement child)
        => children.Add(child);

    public string ToKmlString()
    {
        ConfigureStyles();
        var styles = Styles.ToArray();

        var sb = new StringBuilder();
        foreach (var style in Styles)
        {
            sb.AppendLine(style.Write());
        }

        var defaultStyleId = styles.First(s => s.Uri == defaultStyle).Id;
        foreach(var child in children)
        {
            sb.AppendLine(child.Write(defaultStyleId, styles));
        }

        var kml = $@"
<?xml version=""1.0"" encoding=""UTF-8""?>
<kml xmlns=""http://www.opengis.net/kml/2.2"" xmlns:gx=""http://www.google.com/kml/ext/2.2"" xmlns:kml=""http://www.opengis.net/kml/2.2"">
<Document>
	<name>{HttpUtility.HtmlEncode(Name)}</name>
	{sb}
</Document>
</kml>
".Trim();

        return kml;
    }

    private List<PlacemarkStyle> Styles = new List<PlacemarkStyle>();

    private void ConfigureStyles()
    {
        var usedStyles = PlacemarkExtractor.ExtractPlacemarks(children)
            .Where(p => string.IsNullOrWhiteSpace(p.Style) == false)
            .Select(p => p.Style!)
            .Distinct();
        if(usedStyles.Any() == false) { return; }

        var unusedStyles = Styles.Where(s => usedStyles.Any(us => s.Uri == us) == false).ToArray();
        foreach (var style in unusedStyles)
        {
            Styles.Remove(style);
        }

        foreach(var style in usedStyles)
        {
            if(Styles.Any(s => s.Uri == style) == false)
            {
                Styles.Add(new PlacemarkStyle(style, GetStyleId(style)));
            }
        }
    }

    private static string GetStyleId(string iconUri)
    {
        if (iconUri.StartsWith("http://maps.google.com/mapfiles/kml/"))
        {
            var nameIndex = iconUri.LastIndexOf('/') + 1;
            var iconName = iconUri.Substring(nameIndex);

            var extIndex = iconName.LastIndexOf('.');
            return iconName.Substring(0, extIndex);
        }

        return $"cus-{DateTime.Now.ToLong()}";
    }

    private List<KmlChildElement> children = new List<KmlChildElement>();
}
