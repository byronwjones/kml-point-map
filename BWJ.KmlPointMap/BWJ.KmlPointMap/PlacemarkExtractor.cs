namespace BWJ.KmlPointMap;
internal static class PlacemarkExtractor
{
    public static IEnumerable<Placemark> ExtractPlacemarks(IEnumerable<KmlChildElement> childElements)
    {
        var placemarks = new List<Placemark>();
        var childmarks = childElements.OfType<Placemark>();
        placemarks.AddRange(childmarks);

        var grandMarks = childElements.OfType<Folder>()
            .SelectMany(x => x.ExtractPlacemarks());
        placemarks.AddRange(grandMarks);

        return placemarks;
    }
}
