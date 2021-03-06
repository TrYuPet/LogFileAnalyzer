﻿using AnalyzerLibrary.ConverterInput;
using PartsRecord;

namespace AnalyzerLibrary.ReportConverter
{
	public class ReportUniqueIpConverterToString : IConverter<IpAddress, string>
	{
		public string Convert(IpAddress ipAddress)
		{
			return string.Format("{0}.{1}.{2}.{3}", ipAddress.A, ipAddress.B, ipAddress.C, ipAddress.D);
		}
	}
}