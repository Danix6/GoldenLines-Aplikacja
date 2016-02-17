using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Timers;
using System.Windows.Forms;

namespace TelemetryAppV2
{
    public class FunkcjeGlobalne
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        private string _json;
        private string _jsonString;
        private WebClient wc = new WebClient();
        private SpeechSynthesizer lektor = new SpeechSynthesizer();

        public bool sprawdzPolaczenieInternetowe()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        public bool CzyWlaczonySerwerTelemetrii()
        {
            try
            {
                _json = wc.DownloadString(new Uri(ZmienneGlobalne.AdresUrlTelemetrii));
                return true;
            }
            catch (Exception e)
            {
                _json = e.Message;
                return false;
            }
        }

        public string PobierzDaneTelemetrii()
        {
            try
            {
                _jsonString = wc.DownloadString(new Uri(ZmienneGlobalne.AdresUrlTelemetrii));
            }
            catch (Exception e)
            {
                _jsonString = e.Message;
            }
            return _jsonString;
        }

        public void PrzypiszDaneTelemetrii(object source, ElapsedEventArgs e)
        {
            string json = PobierzDaneTelemetrii();
            JObject dane = new JObject();
            dane = JObject.Parse(json);
            ZmienneGlobalne.Game.connected = Convert.ToBoolean(dane["game"]["connected"]);
            ZmienneGlobalne.Game.gameName = Convert.ToString(dane["game"]["gameName"]);
            ZmienneGlobalne.Game.paused = Convert.ToBoolean(dane["game"]["paused"]);
            ZmienneGlobalne.Game.time = Convert.ToString(dane["game"]["time"]);
            ZmienneGlobalne.Game.timeScale = Convert.ToDouble(dane["game"]["timeScale"]);
            ZmienneGlobalne.Game.nextRestStopTime = Convert.ToString(dane["game"]["nextRestStopTime"]);
            ZmienneGlobalne.Game.version = Convert.ToString(dane["game"]["version"]);
            ZmienneGlobalne.Game.telemetryPluginVersion = Convert.ToString(dane["game"]["telemetryPluginVersion"]);
            ZmienneGlobalne.Truck.id = Convert.ToString(dane["truck"]["id"]);
            ZmienneGlobalne.Truck.make = Convert.ToString(dane["truck"]["make"]);
            ZmienneGlobalne.Truck.model = Convert.ToString(dane["truck"]["model"]);
            ZmienneGlobalne.Truck.speed = Convert.ToDouble(dane["truck"]["speed"]);
            ZmienneGlobalne.Truck.cruiseControlSpeed = Convert.ToDouble(dane["truck"]["cruiseControlSpeed"]);
            ZmienneGlobalne.Truck.cruiseControlOn = Convert.ToBoolean(dane["truck"]["cruiseControlOn"]);
            ZmienneGlobalne.Truck.odometer = Convert.ToDouble(dane["truck"]["odometer"]);
            ZmienneGlobalne.Truck.gear = Convert.ToInt32(dane["truck"]["gear"]);
            ZmienneGlobalne.Truck.displayedGear = Convert.ToInt32(dane["truck"]["displayedGear"]);
            ZmienneGlobalne.Truck.forwardGears = Convert.ToInt32(dane["truck"]["forwardGears"]);
            ZmienneGlobalne.Truck.reverseGears = Convert.ToInt32(dane["truck"]["reverseGears"]);
            ZmienneGlobalne.Truck.shifterType = Convert.ToString(dane["truck"]["shifterType"]);
            ZmienneGlobalne.Truck.engineRpm = Convert.ToDouble(dane["truck"]["engineRpm"]);
            ZmienneGlobalne.Truck.engineRpmMax = Convert.ToDouble(dane["truck"]["engineRpmMax"]);
            ZmienneGlobalne.Truck.fuel = Convert.ToDouble(dane["truck"]["fuel"]);
            ZmienneGlobalne.Truck.fuelCapacity = Convert.ToDouble(dane["truck"]["fuelCapacity"]);
            ZmienneGlobalne.Truck.fuelAverageConsumption = Convert.ToDouble(dane["truck"]["fuelAverageConsumption"]);
            ZmienneGlobalne.Truck.fuelWarningFactor = Convert.ToDouble(dane["truck"]["fuelWarningFactor"]);
            ZmienneGlobalne.Truck.fuelWarningOn = Convert.ToBoolean(dane["truck"]["fuelWarningOn"]);
            ZmienneGlobalne.Truck.wearEngine = Convert.ToDouble(dane["truck"]["wearEngine"]);
            ZmienneGlobalne.Truck.wearTransmission = Convert.ToDouble(dane["truck"]["wearTransmission"]);
            ZmienneGlobalne.Truck.wearCabin = Convert.ToDouble(dane["truck"]["wearCabin"]);
            ZmienneGlobalne.Truck.wearChassis = Convert.ToDouble(dane["truck"]["wearChassis"]);
            ZmienneGlobalne.Truck.wearWheels = Convert.ToDouble(dane["truck"]["wearWheels"]);
            ZmienneGlobalne.Truck.userSteer = Convert.ToDouble(dane["truck"]["userSteer"]);
            ZmienneGlobalne.Truck.userThrottle = Convert.ToDouble(dane["truck"]["userThrottle"]);
            ZmienneGlobalne.Truck.userBrake = Convert.ToDouble(dane["truck"]["userBrake"]);
            ZmienneGlobalne.Truck.userClutch = Convert.ToDouble(dane["truck"]["userClutch"]);
            ZmienneGlobalne.Truck.gameSteer = Convert.ToDouble(dane["truck"]["gameSteer"]);
            ZmienneGlobalne.Truck.gameThrottle = Convert.ToDouble(dane["truck"]["gameThrottle"]);
            ZmienneGlobalne.Truck.gameBrake = Convert.ToDouble(dane["truck"]["gameBrake"]);
            ZmienneGlobalne.Truck.gameClutch = Convert.ToDouble(dane["truck"]["gameClutch"]);
            ZmienneGlobalne.Truck.shifterSlot = Convert.ToInt32(dane["truck"]["shifterSlot"]);
            ZmienneGlobalne.Truck.engineOn = Convert.ToBoolean(dane["truck"]["engineOn"]);
            ZmienneGlobalne.Truck.electricOn = Convert.ToBoolean(dane["truck"]["electricOn"]);
            ZmienneGlobalne.Truck.wipersOn = Convert.ToBoolean(dane["truck"]["wipersOn"]);
            ZmienneGlobalne.Truck.retarderBrake = Convert.ToInt32(dane["truck"]["retarderBrake"]);
            ZmienneGlobalne.Truck.retarderStepCount = Convert.ToInt32(dane["truck"]["retarderStepCount"]);
            ZmienneGlobalne.Truck.parkBrakeOn = Convert.ToBoolean(dane["truck"]["parkBrakeOn"]);
            ZmienneGlobalne.Truck.motorBrakeOn = Convert.ToBoolean(dane["truck"]["motorBrakeOn"]);
            ZmienneGlobalne.Truck.brakeTemperature = Convert.ToDouble(dane["truck"]["brakeTemperature"]);
            ZmienneGlobalne.Truck.adblue = Convert.ToDouble(dane["truck"]["adblue"]);
            ZmienneGlobalne.Truck.adblueCapacity = Convert.ToDouble(dane["truck"]["adblueCapacity"]);
            ZmienneGlobalne.Truck.adblueAverageConsumpton = Convert.ToDouble(dane["truck"]["adblueAverageConsumption"]);
            ZmienneGlobalne.Truck.adblueWarningOn = Convert.ToBoolean(dane["truck"]["adblueWarningOn"]);
            ZmienneGlobalne.Truck.airPressure = Convert.ToDouble(dane["truck"]["airPressure"]);
            ZmienneGlobalne.Truck.airPressureWarningOn = Convert.ToBoolean(dane["truck"]["airPressureWarningOn"]);
            ZmienneGlobalne.Truck.airPressureWarningValue = Convert.ToDouble(dane["truck"]["airPressureWarningValue"]);
            ZmienneGlobalne.Truck.airPressureEmergencyOn = Convert.ToBoolean(dane["truck"]["airPressureEmergencyOn"]);
            ZmienneGlobalne.Truck.airPressureEmergencyValue = Convert.ToDouble(dane["truck"]["airPressureEmergencyValue"]);
            ZmienneGlobalne.Truck.oilTemperature = Convert.ToDouble(dane["truck"]["oilTemperature"]);
            ZmienneGlobalne.Truck.oilPressure = Convert.ToDouble(dane["truck"]["oilPressure"]);
            ZmienneGlobalne.Truck.oilPressureWarningOn = Convert.ToBoolean(dane["truck"]["oilPressureWarningOn"]);
            ZmienneGlobalne.Truck.oilPressureWarningValue = Convert.ToDouble(dane["truck"]["oilPressureWarningValue"]);
            ZmienneGlobalne.Truck.waterTemperature = Convert.ToDouble(dane["truck"]["waterTemperature"]);
            ZmienneGlobalne.Truck.waterTemperatureWarningOn = Convert.ToBoolean(dane["truck"]["waterTemperatureWarningOn"]);
            ZmienneGlobalne.Truck.waterTemperatureWarningValue = Convert.ToDouble(dane["truck"]["waterTemperatureWarningValue"]);
            ZmienneGlobalne.Truck.batteryVoltage = Convert.ToDouble(dane["truck"]["batteryVoltage"]);
            ZmienneGlobalne.Truck.batteryVoltageWarningOn = Convert.ToBoolean(dane["truck"]["batteryVoltageWarningOn"]);
            ZmienneGlobalne.Truck.batteryVoltageWarningValue = Convert.ToDouble(dane["truck"]["batteryVoltageWarningValue"]);
            ZmienneGlobalne.Truck.lightsDashboardValue = Convert.ToDouble(dane["truck"]["lightsDashboardValue"]);
            ZmienneGlobalne.Truck.lightsDashboardOn = Convert.ToBoolean(dane["truck"]["lightsDashboardOn"]);
            ZmienneGlobalne.Truck.blinkerLeftActive = Convert.ToBoolean(dane["truck"]["blinkerLeftActive"]);
            ZmienneGlobalne.Truck.blinkerRightActive = Convert.ToBoolean(dane["truck"]["blinkerRightActive"]);
            ZmienneGlobalne.Truck.blinkerLeftOn = Convert.ToBoolean(dane["truck"]["blinkerLeftOn"]);
            ZmienneGlobalne.Truck.blinkerRightOn = Convert.ToBoolean(dane["truck"]["blinkerRightOn"]);
            ZmienneGlobalne.Truck.lightsParkingOn = Convert.ToBoolean(dane["truck"]["lightsParkingOn"]);
            ZmienneGlobalne.Truck.lightsBeamLowOn = Convert.ToBoolean(dane["truck"]["lightsBeamLowOn"]);
            ZmienneGlobalne.Truck.lightsBeamHighOn = Convert.ToBoolean(dane["truck"]["lightsBeamHighOn"]);
            ZmienneGlobalne.Truck.lightsAuxFrontOn = Convert.ToBoolean(dane["truck"]["lightsAuxFrontOn"]);
            ZmienneGlobalne.Truck.lightsAuxRoofOn = Convert.ToBoolean(dane["truck"]["lightsAuxRoofOn"]);
            ZmienneGlobalne.Truck.lightsBeaconOn = Convert.ToBoolean(dane["truck"]["lightsBeaconOn"]);
            ZmienneGlobalne.Truck.lightsBrakeOn = Convert.ToBoolean(dane["truck"]["lightsBrakeOn"]);
            ZmienneGlobalne.Truck.lightsReverseOn = Convert.ToBoolean(dane["truck"]["lightsReverseOn"]);
            ZmienneGlobalne.TruckPlacement.x = Convert.ToDouble(dane["truck"]["placement"]["x"]);
            ZmienneGlobalne.TruckPlacement.y = Convert.ToDouble(dane["truck"]["placement"]["y"]);
            ZmienneGlobalne.TruckPlacement.z = Convert.ToDouble(dane["truck"]["placement"]["z"]);
            ZmienneGlobalne.TruckPlacement.heading = Convert.ToDouble(dane["truck"]["placement"]["heading"]);
            ZmienneGlobalne.TruckPlacement.pitch = Convert.ToDouble(dane["truck"]["placement"]["pitch"]);
            ZmienneGlobalne.TruckPlacement.roll = Convert.ToDouble(dane["truck"]["placement"]["roll"]);
            ZmienneGlobalne.TruckAcceleration.x = Convert.ToDouble(dane["truck"]["acceleration"]["x"]);
            ZmienneGlobalne.TruckAcceleration.y = Convert.ToDouble(dane["truck"]["acceleration"]["y"]);
            ZmienneGlobalne.TruckAcceleration.z = Convert.ToDouble(dane["truck"]["acceleration"]["z"]);
            ZmienneGlobalne.TruckHead.x = Convert.ToDouble(dane["truck"]["head"]["x"]);
            ZmienneGlobalne.TruckHead.y = Convert.ToDouble(dane["truck"]["head"]["y"]);
            ZmienneGlobalne.TruckHead.z = Convert.ToDouble(dane["truck"]["head"]["z"]);
            ZmienneGlobalne.TruckCabin.x = Convert.ToDouble(dane["truck"]["cabin"]["x"]);
            ZmienneGlobalne.TruckCabin.y = Convert.ToDouble(dane["truck"]["cabin"]["y"]);
            ZmienneGlobalne.TruckCabin.z = Convert.ToDouble(dane["truck"]["cabin"]["z"]);
            ZmienneGlobalne.TruckHook.x = Convert.ToDouble(dane["truck"]["hook"]["x"]);
            ZmienneGlobalne.TruckHook.y = Convert.ToDouble(dane["truck"]["hook"]["y"]);
            ZmienneGlobalne.TruckHook.z = Convert.ToDouble(dane["truck"]["hook"]["z"]);
            ZmienneGlobalne.Trailer.attached = Convert.ToBoolean(dane["trailer"]["attached"]);
            ZmienneGlobalne.Trailer.id = Convert.ToString(dane["trailer"]["id"]);
            ZmienneGlobalne.Trailer.name = Convert.ToString(dane["trailer"]["name"]);
            ZmienneGlobalne.Trailer.mass = Convert.ToDouble(dane["trailer"]["mass"]);
            ZmienneGlobalne.Trailer.wear = Convert.ToDouble(dane["trailer"]["wear"]);
            ZmienneGlobalne.TrailerPlacement.x = Convert.ToDouble(dane["trailer"]["placement"]["x"]);
            ZmienneGlobalne.TrailerPlacement.y = Convert.ToDouble(dane["trailer"]["placement"]["y"]);
            ZmienneGlobalne.TrailerPlacement.z = Convert.ToDouble(dane["trailer"]["placement"]["z"]);
            ZmienneGlobalne.TrailerPlacement.heading = Convert.ToDouble(dane["trailer"]["placement"]["heading"]);
            ZmienneGlobalne.TrailerPlacement.pitch = Convert.ToDouble(dane["trailer"]["placement"]["pitch"]);
            ZmienneGlobalne.TrailerPlacement.roll = Convert.ToDouble(dane["trailer"]["placement"]["roll"]);
            ZmienneGlobalne.Job.income = Convert.ToInt32(dane["job"]["income"]);
            ZmienneGlobalne.Job.deadlineTime = Convert.ToString(dane["job"]["deadlineTime"]);
            ZmienneGlobalne.Job.remainingTime = Convert.ToString(dane["job"]["remainingTime"]);
            ZmienneGlobalne.Job.sourceCity = Convert.ToString(dane["job"]["sourceCity"]);
            ZmienneGlobalne.Job.sourceCompany = Convert.ToString(dane["job"]["sourceCompany"]);
            ZmienneGlobalne.Job.destinationCity = Convert.ToString(dane["job"]["destinationCity"]);
            ZmienneGlobalne.Job.destinationCompany = Convert.ToString(dane["job"]["destinationCompany"]);
            ZmienneGlobalne.Navigation.estimatedTime = Convert.ToString(dane["navigation"]["estimatedTime"]);
            ZmienneGlobalne.Navigation.estimatedDistance = Convert.ToInt32(dane["navigation"]["estimatedDistance"]);
            ZmienneGlobalne.Navigation.speedLimit = Convert.ToInt32(dane["navigation"]["speedLimit"]);
        }

        public bool CzyTextBoxPusty(TextBox nazwaTextBox)
        {
            bool wynik;
            if (nazwaTextBox.Text.Length < 1)
            {
                nazwaTextBox.BackColor = Color.Red;
                wynik = false;
            }
            else
            {
                nazwaTextBox.BackColor = Color.White;
                wynik = true;
            }
            return wynik;
        }

        public void CzytajText(string tekst)
        {
            lektor.SpeakAsync(tekst);
        }

        public void ButtonEnabled(Button przycisk, bool stan)
        {
            przycisk.Enabled = stan;
        }

        public void LabelForeColor(Label label, Color kolor)
        {
            label.ForeColor = kolor;
        }

        public void TextBoxBackColor(TextBox textbox, Color kolor)
        {
            textbox.BackColor = kolor;
        }

        public void LabelText(Label label, string tekst)
        {
            label.Text = tekst;
        }
    }
}