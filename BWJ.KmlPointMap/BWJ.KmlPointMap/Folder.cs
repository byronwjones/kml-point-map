using BWJ.KmlPointMap.Styling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BWJ.KmlPointMap;
public sealed class Folder : KmlChildElement
{
    public Folder(string name) : base(name) { }

    public bool ShowExpanded { get; set; } = true;

    public void AddChild(KmlChildElement child)
    {
        child.Parent = this;
        children.Add(child);
    }

    public override string ToString()
    {
        return Name;
    }

    internal IEnumerable<Placemark> ExtractPlacemarks()
        => PlacemarkExtractor.ExtractPlacemarks(children);

    internal override string Write(string defaultStyleId, PlacemarkStyle[] styles)
    {
        var sb = new StringBuilder();
        foreach (var child in children)
        {
            if (child is Placemark)
            {
                var placemark = (Placemark)child;
                sb.AppendLine(placemark.Write(defaultStyleId, styles));
            }
            else if (child is Folder)
            {
                var folder = (Folder)child;
                sb.AppendLine(folder.Write(defaultStyleId, styles));
            }
        }
        var kml = $@"
		<Folder>
			<name>{HttpUtility.HtmlEncode(Name)}</name>
			<open>{(ShowExpanded ? 1 : 0)}</open>
			<visibility>{(Visible ? 1 : 0)}</visibility>
			{sb}
		</Folder>
".Trim();
        return kml;
    }

    private List<KmlChildElement> children = new List<KmlChildElement>();
}
