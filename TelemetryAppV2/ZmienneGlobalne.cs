namespace TelemetryAppV2
{
    public class ZmienneGlobalne
    {
        public static string AdresUrlTelemetrii = "http://localhost:25555/api/ets2/telemetry";

        public class User
        {
            public static string login;
            public static int id;
        }

        public class Truck
        {
            public static int speed;
        }
    }
}