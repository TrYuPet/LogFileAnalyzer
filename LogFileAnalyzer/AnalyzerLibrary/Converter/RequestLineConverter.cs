﻿using System;
using PartsRecord;

namespace AnalyzerLibrary.Converter
{
	public class RequestLineConverter : IConverter<RequestLine>
	{
		public RequestLine Convert(string record)
		{
			string[] parts = record.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
			string[] protololAndVersion = parts[2].Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
			return new RequestLine(parts[0], parts[1], protololAndVersion[0], protololAndVersion[1]);
		}
	}
}