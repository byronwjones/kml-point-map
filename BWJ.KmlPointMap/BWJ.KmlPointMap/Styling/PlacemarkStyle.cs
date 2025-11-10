namespace BWJ.KmlPointMap.Styling;
internal class PlacemarkStyle
{
    internal PlacemarkStyle(string uri, string id)
    {
        Uri = uri;
        Id = id;
    }

    public string Uri { get; }
    public string Id { get; set; }

    public string Write()
    {
        var styleDefinition = $@"
	<Style id=""s_{Id}"">
		<IconStyle>
			<scale>1.1</scale>
			<Icon>
				<href>{Uri}</href>
			</Icon>
			<hotSpot x=""20"" y=""2"" xunits=""pixels"" yunits=""pixels""/>
		</IconStyle>
	</Style>
	<Style id=""s_{Id}_hl"">
		<IconStyle>
			<scale>1.3</scale>
			<Icon>
				<href>{Uri}</href>
			</Icon>
			<hotSpot x=""20"" y=""2"" xunits=""pixels"" yunits=""pixels""/>
		</IconStyle>
	</Style>
	<StyleMap id=""sm_{Id}"">
		<Pair>
			<key>normal</key>
			<styleUrl>#s_{Id}</styleUrl>
		</Pair>
		<Pair>
			<key>highlight</key>
			<styleUrl>#s_{Id}_hl</styleUrl>
		</Pair>
	</StyleMap>
".Trim();

        return styleDefinition;
    }
}
