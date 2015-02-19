using System;
using logmod_telemetry_server.IEts2Data;
using System.Text;

namespace logmod_telemetry_server
{
	class Ets2TelemetryData : IEts2Data
	{
		Ets2DataStructure _rawData;

		public void Update(Ets2DataStructure rawData){
			_rawData = rawData;
		}

		static DateTime MinutesToDate(int minutes){
			if (minutes < 0) {
				minutes = 0;
			}
			return new DateTime ((long)minutes * 10000000 * 60, DateTimeKind.Utc);
		}

		static string BytesToString(byte[] bytes){
			if (bytes == null) {
				return string.Empty;
			}
			return Encoding.UTF8.GetString (bytes, 0, Array.FindIndex(bytes, b => b == 0));
		}

		public bool Connected
		{
			get { return _rawData.ets2_telemetry_plugin_version &&  }
		}
	}
}

