﻿using System;
using PartsRecord;

namespace AnalyzerLibrary.Converter
{
	public class FileSizeConverter : IConverter<FileSize>
	{
		public FileSize Convert(string record)
		{
			return new FileSize(int.Parse(record));
		}
	}
}