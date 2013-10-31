﻿using System;
using System.Text;
using GeneratorLibrary.PartsRecord;

namespace GeneratorLibrary.Converter
{
	public class IpAddressConverter : IConverter<string>
	{
		private readonly IpAddress _ipAddress;

		public IpAddressConverter(IpAddress ipAddress)
		{
			_ipAddress = ipAddress;
		}

		public string Convert()
		{
			return _ipAddress.A + "." + _ipAddress.B + "." + _ipAddress.C + "." + _ipAddress.D;
		}
	}
}