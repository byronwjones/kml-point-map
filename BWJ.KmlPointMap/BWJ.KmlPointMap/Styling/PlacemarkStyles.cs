using BWJ.KmlPointMap.Styling;

namespace BWJ.KmlPointMap
{
    /// <summary>
    /// Standard Google placemark style URLs
    /// </summary>
    public static class PlacemarkStyles
    {
        /// <summary>
        /// Standard pushpin graphic URLs, available in multiple colors
        /// </summary>
        public static ColorSet Pushpin { get; } =
            new ColorSet(
                "http://maps.google.com/mapfiles/kml/pushpin/ylw-pushpin.png",
                "http://maps.google.com/mapfiles/kml/pushpin/blue-pushpin.png",
                "http://maps.google.com/mapfiles/kml/pushpin/grn-pushpin.png",
                "http://maps.google.com/mapfiles/kml/pushpin/ltblu-pushpin.png",
                "http://maps.google.com/mapfiles/kml/pushpin/pink-pushpin.png",
                "http://maps.google.com/mapfiles/kml/pushpin/purple-pushpin.png",
                "http://maps.google.com/mapfiles/kml/pushpin/red-pushpin.png",
                "http://maps.google.com/mapfiles/kml/pushpin/wht-pushpin.png");

        /// <summary>
        /// Standard paddle graphic URLs, available with multiple types of content (or blank)
        /// </summary>
        public static class Paddle
        {
            /// <summary>
            /// Standard blank paddle graphic URLs, available in multiple colors
            /// </summary>
            public static ColorSet Blank { get; } =
                new ColorSet(
                    "http://maps.google.com/mapfiles/kml/paddle/ylw-blank.png",
                    "http://maps.google.com/mapfiles/kml/paddle/blue-blank.png",
                    "http://maps.google.com/mapfiles/kml/paddle/grn-blank.png",
                    "http://maps.google.com/mapfiles/kml/paddle/ltblu-blank.png",
                    "http://maps.google.com/mapfiles/kml/paddle/pink-blank.png",
                    "http://maps.google.com/mapfiles/kml/paddle/purple-blank.png",
                    "http://maps.google.com/mapfiles/kml/paddle/red-blank.png",
                    "http://maps.google.com/mapfiles/kml/paddle/wht-blank.png");

            /// <summary>
            /// Standard paddle graphic with diamond shape inside URLs, available in multiple colors
            /// </summary>
            public static ColorSet Diamond { get; } =
                new ColorSet(
                    "http://maps.google.com/mapfiles/kml/paddle/ylw-diamond.png",
                    "http://maps.google.com/mapfiles/kml/paddle/blue-diamond.png",
                    "http://maps.google.com/mapfiles/kml/paddle/grn-diamond.png",
                    "http://maps.google.com/mapfiles/kml/paddle/ltblu-diamond.png",
                    "http://maps.google.com/mapfiles/kml/paddle/pink-diamond.png",
                    "http://maps.google.com/mapfiles/kml/paddle/purple-diamond.png",
                    "http://maps.google.com/mapfiles/kml/paddle/red-diamond.png",
                    "http://maps.google.com/mapfiles/kml/paddle/wht-diamond.png");

            /// <summary>
            /// Standard paddle graphic with circle shape inside URLs, available in multiple colors
            /// </summary>
            public static ColorSet Circle { get; } =
                new ColorSet(
                    "http://maps.google.com/mapfiles/kml/paddle/ylw-circle.png",
                    "http://maps.google.com/mapfiles/kml/paddle/blue-circle.png",
                    "http://maps.google.com/mapfiles/kml/paddle/grn-circle.png",
                    "http://maps.google.com/mapfiles/kml/paddle/ltblu-circle.png",
                    "http://maps.google.com/mapfiles/kml/paddle/pink-circle.png",
                    "http://maps.google.com/mapfiles/kml/paddle/purple-circle.png",
                    "http://maps.google.com/mapfiles/kml/paddle/red-circle.png",
                    "http://maps.google.com/mapfiles/kml/paddle/wht-circle.png");

            /// <summary>
            /// Standard paddle graphic with square shape inside URLs, available in multiple colors
            /// </summary>
            public static ColorSet Square { get; } =
                new ColorSet(
                    "http://maps.google.com/mapfiles/kml/paddle/ylw-square.png",
                    "http://maps.google.com/mapfiles/kml/paddle/blue-square.png",
                    "http://maps.google.com/mapfiles/kml/paddle/grn-square.png",
                    "http://maps.google.com/mapfiles/kml/paddle/ltblu-square.png",
                    "http://maps.google.com/mapfiles/kml/paddle/pink-square.png",
                    "http://maps.google.com/mapfiles/kml/paddle/purple-square.png",
                    "http://maps.google.com/mapfiles/kml/paddle/red-square.png",
                    "http://maps.google.com/mapfiles/kml/paddle/wht-square.png");

            /// <summary>
            /// Standard paddle graphic with star shape inside URLs, available in multiple colors
            /// </summary>
            public static ColorSet Star { get; } =
                new ColorSet(
                    "http://maps.google.com/mapfiles/kml/paddle/ylw-stars.png",
                    "http://maps.google.com/mapfiles/kml/paddle/blue-stars.png",
                    "http://maps.google.com/mapfiles/kml/paddle/grn-stars.png",
                    "http://maps.google.com/mapfiles/kml/paddle/ltblu-stars.png",
                    "http://maps.google.com/mapfiles/kml/paddle/pink-stars.png",
                    "http://maps.google.com/mapfiles/kml/paddle/purple-stars.png",
                    "http://maps.google.com/mapfiles/kml/paddle/red-stars.png",
                    "http://maps.google.com/mapfiles/kml/paddle/wht-stars.png");

            /// <summary>
            /// Standard paddle graphic with letter inside URLs
            /// </summary>
            public static class Letter
            {
                public const string A = "http://maps.google.com/mapfiles/kml/paddle/A.png";
                public const string B = "http://maps.google.com/mapfiles/kml/paddle/B.png";
                public const string C = "http://maps.google.com/mapfiles/kml/paddle/C.png";
                public const string D = "http://maps.google.com/mapfiles/kml/paddle/D.png";
                public const string E = "http://maps.google.com/mapfiles/kml/paddle/E.png";
                public const string F = "http://maps.google.com/mapfiles/kml/paddle/F.png";
                public const string G = "http://maps.google.com/mapfiles/kml/paddle/G.png";
                public const string H = "http://maps.google.com/mapfiles/kml/paddle/H.png";
                public const string I = "http://maps.google.com/mapfiles/kml/paddle/I.png";
                public const string J = "http://maps.google.com/mapfiles/kml/paddle/J.png";
                public const string K = "http://maps.google.com/mapfiles/kml/paddle/K.png";
                public const string L = "http://maps.google.com/mapfiles/kml/paddle/L.png";
                public const string M = "http://maps.google.com/mapfiles/kml/paddle/M.png";
                public const string N = "http://maps.google.com/mapfiles/kml/paddle/N.png";
                public const string O = "http://maps.google.com/mapfiles/kml/paddle/O.png";
                public const string P = "http://maps.google.com/mapfiles/kml/paddle/P.png";
                public const string Q = "http://maps.google.com/mapfiles/kml/paddle/Q.png";
                public const string R = "http://maps.google.com/mapfiles/kml/paddle/R.png";
                public const string S = "http://maps.google.com/mapfiles/kml/paddle/S.png";
                public const string T = "http://maps.google.com/mapfiles/kml/paddle/T.png";
                public const string U = "http://maps.google.com/mapfiles/kml/paddle/U.png";
                public const string V = "http://maps.google.com/mapfiles/kml/paddle/V.png";
                public const string W = "http://maps.google.com/mapfiles/kml/paddle/W.png";
                public const string X = "http://maps.google.com/mapfiles/kml/paddle/X.png";
                public const string Y = "http://maps.google.com/mapfiles/kml/paddle/Y.png";
                public const string Z = "http://maps.google.com/mapfiles/kml/paddle/Z.png";
            }

            /// <summary>
            /// Standard paddle graphic with number inside URLs
            /// </summary>
            public static class Number
            {
                public const string Number01 = "http://maps.google.com/mapfiles/kml/paddle/1.png";
                public const string Number02 = "http://maps.google.com/mapfiles/kml/paddle/2.png";
                public const string Number03 = "http://maps.google.com/mapfiles/kml/paddle/3.png";
                public const string Number04 = "http://maps.google.com/mapfiles/kml/paddle/4.png";
                public const string Number05 = "http://maps.google.com/mapfiles/kml/paddle/5.png";
                public const string Number06 = "http://maps.google.com/mapfiles/kml/paddle/6.png";
                public const string Number07 = "http://maps.google.com/mapfiles/kml/paddle/7.png";
                public const string Number08 = "http://maps.google.com/mapfiles/kml/paddle/8.png";
                public const string Number09 = "http://maps.google.com/mapfiles/kml/paddle/9.png";
                public const string Number10 = "http://maps.google.com/mapfiles/kml/paddle/10.png";
            }
        }

        /// <summary>
        /// Standard emoji-like shape graphic URLs
        /// </summary>
        public static class Shape
        {
            public const string ArrowReverse = "http://maps.google.com/mapfiles/kml/shapes/arrow-reverse.png";
            public const string Arrow = "http://maps.google.com/mapfiles/kml/shapes/arrow.png";
            public const string Track = "http://maps.google.com/mapfiles/kml/shapes/track.png";
            public const string Donut = "http://maps.google.com/mapfiles/kml/shapes/donut.png";
            public const string Forbidden = "http://maps.google.com/mapfiles/kml/shapes/forbidden.png";
            public const string InfoI = "http://maps.google.com/mapfiles/kml/shapes/info-i.png";
            public const string Polygon = "http://maps.google.com/mapfiles/kml/shapes/polygon.png";
            public const string OpenDiamond = "http://maps.google.com/mapfiles/kml/shapes/open-diamond.png";
            public const string Square = "http://maps.google.com/mapfiles/kml/shapes/square.png";
            public const string Star = "http://maps.google.com/mapfiles/kml/shapes/star.png";
            public const string Target = "http://maps.google.com/mapfiles/kml/shapes/target.png";
            public const string Triangle = "http://maps.google.com/mapfiles/kml/shapes/triangle.png";
            public const string Crosshairs = "http://maps.google.com/mapfiles/kml/shapes/cross-hairs.png";
            public const string PlacemarkSquare = "http://maps.google.com/mapfiles/kml/shapes/placemark_square.png";
            public const string PlacemarkCircle = "http://maps.google.com/mapfiles/kml/shapes/placemark_circle.png";
            public const string ShadedDot = "http://maps.google.com/mapfiles/kml/shapes/shaded-dot.png";
            public const string Dining = "http://maps.google.com/mapfiles/kml/shapes/dining.png";
            public const string Coffee = "http://maps.google.com/mapfiles/kml/shapes/coffee.png";
            public const string Bars = "http://maps.google.com/mapfiles/kml/shapes/bars.png";
            public const string Martini = Bars;
            public const string SnackBar = "http://maps.google.com/mapfiles/kml/shapes/snack_bar.png";
            public const string Food = SnackBar;
            public const string Man = "http://maps.google.com/mapfiles/kml/shapes/man.png";
            public const string Woman = "http://maps.google.com/mapfiles/kml/shapes/woman.png";
            public const string WheelchairAccessible = "http://maps.google.com/mapfiles/kml/shapes/wheel_chair_accessible.png";
            public const string ParkingLot = "http://maps.google.com/mapfiles/kml/shapes/parking_lot.png";
            public const string Cabs = "http://maps.google.com/mapfiles/kml/shapes/cabs.png";
            public const string Taxi = Cabs;
            public const string Bus = "http://maps.google.com/mapfiles/kml/shapes/bus.png";
            public const string Truck = "http://maps.google.com/mapfiles/kml/shapes/truck.png";
            public const string Rail = "http://maps.google.com/mapfiles/kml/shapes/rail.png";
            public const string Train = Rail;
            public const string Airport = "http://maps.google.com/mapfiles/kml/shapes/airports.png";
            public const string Airplane = Airport;
            public const string Ferry = "http://maps.google.com/mapfiles/kml/shapes/ferry.png";
            public const string Ship = Ferry;
            public const string Heliport = "http://maps.google.com/mapfiles/kml/shapes/heliport.png";
            public const string Helicopter = Heliport;
            public const string Subway = "http://maps.google.com/mapfiles/kml/shapes/subway.png";
            public const string Tram = "http://maps.google.com/mapfiles/kml/shapes/tram.png";
            public const string Info = "http://maps.google.com/mapfiles/kml/shapes/info.png";
            public const string InfoCircle = "http://maps.google.com/mapfiles/kml/shapes/info_circle.png";
            public const string Flag = "http://maps.google.com/mapfiles/kml/shapes/flag.png";
            public const string Rainy = "http://maps.google.com/mapfiles/kml/shapes/rainy.png";
            public const string Water = "http://maps.google.com/mapfiles/kml/shapes/water.png";
            public const string Snowflake = "http://maps.google.com/mapfiles/kml/shapes/snowflake_simple.png";
            public const string Marina = "http://maps.google.com/mapfiles/kml/shapes/marina.png";
            public const string Anchor = Marina;
            public const string Fishing = "http://maps.google.com/mapfiles/kml/shapes/fishing.png";
            public const string Sailing = "http://maps.google.com/mapfiles/kml/shapes/sailing.png";
            public const string Boat = Sailing;
            public const string Swimming = "http://maps.google.com/mapfiles/kml/shapes/swimming.png";
            public const string Sking = "http://maps.google.com/mapfiles/kml/shapes/ski.png";
            public const string Parks = "http://maps.google.com/mapfiles/kml/shapes/parks.png";
            public const string Tree = Parks;
            public const string Campfire = "http://maps.google.com/mapfiles/kml/shapes/campfire.png";
            public const string Picnic = "http://maps.google.com/mapfiles/kml/shapes/picnic.png";
            public const string Bench = Picnic;
            public const string Campground = "http://maps.google.com/mapfiles/kml/shapes/campground.png";
            public const string RangerStation = "http://maps.google.com/mapfiles/kml/shapes/ranger_station.png";
            public const string School = RangerStation;
            public const string Toilets = "http://maps.google.com/mapfiles/kml/shapes/toilets.png";
            public const string Bathroom = Toilets;
            public const string PointOfInterest = "http://maps.google.com/mapfiles/kml/shapes/poi.png";
            public const string Hiking = "http://maps.google.com/mapfiles/kml/shapes/hiker.png";
            public const string Cycling = "http://maps.google.com/mapfiles/kml/shapes/cycling.png";
            public const string Motorcycling = "http://maps.google.com/mapfiles/kml/shapes/motorcycling.png";
            public const string HorsebackRiding = "http://maps.google.com/mapfiles/kml/shapes/horsebackriding.png";
            public const string Play = "http://maps.google.com/mapfiles/kml/shapes/play.png";
            public const string Soccer = Play;
            public const string Golfing = "http://maps.google.com/mapfiles/kml/shapes/golf.png";
            public const string Trail = "http://maps.google.com/mapfiles/kml/shapes/trail.png";
            public const string Shopping = "http://maps.google.com/mapfiles/kml/shapes/shopping.png";
            public const string Movies = "http://maps.google.com/mapfiles/kml/shapes/movies.png";
            public const string Convenience = "http://maps.google.com/mapfiles/kml/shapes/convenience.png";
            public const string Grocery = "http://maps.google.com/mapfiles/kml/shapes/grocery.png";
            public const string Basket = Grocery;
            public const string Arts = "http://maps.google.com/mapfiles/kml/shapes/arts.png";
            public const string Home = "http://maps.google.com/mapfiles/kml/shapes/homegardenbusiness.png";
            public const string Garden = Home;
            public const string Business = Home;
            public const string Electronics = "http://maps.google.com/mapfiles/kml/shapes/electronics.png";
            public const string Television = Electronics;
            public const string Mechanic = "http://maps.google.com/mapfiles/kml/shapes/mechanic.png";
            public const string Tools = Mechanic;
            public const string Wrench = Mechanic;
            public const string GasStation = "http://maps.google.com/mapfiles/kml/shapes/gas_stations.png";
            public const string RealEstate = "http://maps.google.com/mapfiles/kml/shapes/realestate.png";
            public const string Salon = "http://maps.google.com/mapfiles/kml/shapes/salon.png";
            public const string Dollar = "http://maps.google.com/mapfiles/kml/shapes/dollar.png";
            public const string Euro = "http://maps.google.com/mapfiles/kml/shapes/euro.png";
            public const string Yen = "http://maps.google.com/mapfiles/kml/shapes/yen.png";
            public const string FireDepartment = "http://maps.google.com/mapfiles/kml/shapes/firedept.png";
            public const string Fire = FireDepartment;
            public const string Hospital = "http://maps.google.com/mapfiles/kml/shapes/hospitals.png";
            public const string Lodging = "http://maps.google.com/mapfiles/kml/shapes/lodging.png";
            public const string Hotel = Lodging;
            public const string Bed = Lodging;
            public const string Phone = "http://maps.google.com/mapfiles/kml/shapes/phone.png";
            public const string Caution = "http://maps.google.com/mapfiles/kml/shapes/caution.png";
            public const string Warning = Caution;
            public const string Error = Caution;
            public const string Earthquake = "http://maps.google.com/mapfiles/kml/shapes/earthquake.png";
            public const string FallingRocks = "http://maps.google.com/mapfiles/kml/shapes/falling_rocks.png";
            public const string PostOffice = "http://maps.google.com/mapfiles/kml/shapes/post_office.png";
            public const string Mail = PostOffice;
            public const string Letter = PostOffice;
            public const string Police = "http://maps.google.com/mapfiles/kml/shapes/police.png";
            public const string Sunny = "http://maps.google.com/mapfiles/kml/shapes/sunny.png";
            public const string PartlyCloudy = "http://maps.google.com/mapfiles/kml/shapes/partly_cloudy.png";
            public const string Volcano = "http://maps.google.com/mapfiles/kml/shapes/volcano.png";
            public const string Camera = "http://maps.google.com/mapfiles/kml/shapes/camera.png";
            public const string Webcam = "http://maps.google.com/mapfiles/kml/shapes/webcam.png";
        }
    }
}
