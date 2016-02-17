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

        public class Game
        {
            public static bool connected { get; set; }
            public static string gameName { get; set; }
            public static bool paused { get; set; }
            public static string time { get; set; }
            public static double timeScale { get; set; }
            public static string nextRestStopTime { get; set; }
            public static string version { get; set; }
            public static string telemetryPluginVersion { get; set; }
        }

        public class Truck
        {
            public static string id { get; set; }
            public static string make { get; set; }
            public static string model { get; set; }
            public static double speed { get; set; }
            public static double cruiseControlSpeed { get; set; }
            public static bool cruiseControlOn { get; set; }
            public static double odometer { get; set; }
            public static int gear { get; set; }
            public static int displayedGear { get; set; }
            public static int forwardGears { get; set; }
            public static int reverseGears { get; set; }
            public static string shifterType { get; set; }
            public static double engineRpm { get; set; }
            public static double engineRpmMax { get; set; }
            public static double fuel { get; set; }
            public static double fuelCapacity { get; set; }
            public static double fuelAverageConsumption { get; set; }
            public static double fuelWarningFactor { get; set; }
            public static bool fuelWarningOn { get; set; }
            public static double wearEngine { get; set; }
            public static double wearTransmission { get; set; }
            public static double wearCabin { get; set; }
            public static double wearChassis { get; set; }
            public static double wearWheels { get; set; }
            public static double userSteer { get; set; }
            public static double userThrottle { get; set; }
            public static double userBrake { get; set; }
            public static double userClutch { get; set; }
            public static double gameSteer { get; set; }
            public static double gameThrottle { get; set; }
            public static double gameBrake { get; set; }
            public static double gameClutch { get; set; }
            public static int shifterSlot { get; set; }
            public static bool engineOn { get; set; }
            public static bool electricOn { get; set; }
            public static bool wipersOn { get; set; }
            public static int retarderBrake { get; set; }
            public static int retarderStepCount { get; set; }
            public static bool parkBrakeOn { get; set; }
            public static bool motorBrakeOn { get; set; }
            public static double brakeTemperature { get; set; }
            public static double adblue { get; set; }
            public static double adblueCapacity { get; set; }
            public static double adblueAverageConsumpton { get; set; }
            public static bool adblueWarningOn { get; set; }
            public static double airPressure { get; set; }
            public static bool airPressureWarningOn { get; set; }
            public static double airPressureWarningValue { get; set; }
            public static bool airPressureEmergencyOn { get; set; }
            public static double airPressureEmergencyValue { get; set; }
            public static double oilTemperature { get; set; }
            public static double oilPressure { get; set; }
            public static bool oilPressureWarningOn { get; set; }
            public static double oilPressureWarningValue { get; set; }
            public static double waterTemperature { get; set; }
            public static bool waterTemperatureWarningOn { get; set; }
            public static double waterTemperatureWarningValue { get; set; }
            public static double batteryVoltage { get; set; }
            public static bool batteryVoltageWarningOn { get; set; }
            public static double batteryVoltageWarningValue { get; set; }
            public static double lightsDashboardValue { get; set; }
            public static bool lightsDashboardOn { get; set; }
            public static bool blinkerLeftActive { get; set; }
            public static bool blinkerRightActive { get; set; }
            public static bool blinkerLeftOn { get; set; }
            public static bool blinkerRightOn { get; set; }
            public static bool lightsParkingOn { get; set; }
            public static bool lightsBeamLowOn { get; set; }
            public static bool lightsBeamHighOn { get; set; }
            public static bool lightsAuxFrontOn { get; set; }
            public static bool lightsAuxRoofOn { get; set; }
            public static bool lightsBeaconOn { get; set; }
            public static bool lightsBrakeOn { get; set; }
            public static bool lightsReverseOn { get; set; }
        }

        public class TruckPlacement
        {
            public static double x { get; set; }
            public static double y { get; set; }
            public static double z { get; set; }
            public static double heading { get; set; }
            public static double pitch { get; set; }
            public static double roll { get; set; }
        }

        public class TruckAcceleration
        {
            public static double x { get; set; }
            public static double y { get; set; }
            public static double z { get; set; }
        }

        public class TruckHead
        {
            public static double x { get; set; }
            public static double y { get; set; }
            public static double z { get; set; }
        }

        public class TruckCabin
        {
            public static double x { get; set; }
            public static double y { get; set; }
            public static double z { get; set; }
        }

        public class TruckHook
        {
            public static double x { get; set; }
            public static double y { get; set; }
            public static double z { get; set; }
        }

        public class Trailer
        {
            public static bool attached { get; set; }
            public static string id { get; set; }
            public static string name { get; set; }
            public static double mass { get; set; }
            public static double wear { get; set; }
        }

        public class TrailerPlacement
        {
            public static double x { get; set; }
            public static double y { get; set; }
            public static double z { get; set; }
            public static double heading { get; set; }
            public static double pitch { get; set; }
            public static double roll { get; set; }
        }

        public class Job
        {
            public static int income { get; set; }
            public static string deadlineTime { get; set; }
            public static string remainingTime { get; set; }
            public static string sourceCity { get; set; }
            public static string sourceCompany { get; set; }
            public static string destinationCity { get; set; }
            public static string destinationCompany { get; set; }
        }

        public class Navigation
        {
            public static string estimatedTime { get; set; }
            public static int estimatedDistance { get; set; }
            public static int speedLimit { get; set; }
        }
    }
}