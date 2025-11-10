namespace BWJ.KmlPointMap;

/// <summary>
/// Represents a point on Earth, expressed in lat/long
/// </summary>
public sealed class Point
{
    public Point() { }
    public Point(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public double Latitude { get; }
    public double Longitude { get; }

    public override string ToString()
    {
        return $"{Latitude}, {Longitude}";
    }

    internal string Write()
    {
        return @$"
			<Point>
				<gx:drawOrder>1</gx:drawOrder>
				<coordinates>{Latitude},{Longitude},0</coordinates>
			</Point>
".Trim();
    }
}
