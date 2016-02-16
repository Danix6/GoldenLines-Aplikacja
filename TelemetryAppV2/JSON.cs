using System;
using System.Net;

namespace TelemetryAppV2
{
    public class JSON
    {
        public string JSONString;

        public string DownloadJSON()
        {
            WebClient wc = new WebClient();
            try
            {
                JSONString = wc.DownloadString(new Uri("http://localhost:25555/api/ets2/telemetry"));
            }
            catch (Exception e)
            {
                JSONString = e.Message;
            }
            return JSONString;
        }
    }
}