namespace BWJ.KmlPointMap.Styling;
public class ColorSet
{
    internal ColorSet(
        string yellow,
        string blue,
        string green,
        string lightBlue,
        string pink,
        string purple,
        string red,
        string white)
    {
        Yellow = yellow;
        Blue = blue;
        Green = green;
        LightBlue = lightBlue;
        Pink = pink;
        Purple = purple;
        Red = red;
        White = white;
    }

    public string Yellow { get; }
    public string Blue { get; }
    public string Green { get; }
    public string LightBlue { get; }
    public string Pink { get; }
    public string Purple { get; }
    public string Red { get; }
    public string White { get; }
}
