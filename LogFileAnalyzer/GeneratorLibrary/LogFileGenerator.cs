﻿using Config;
using GeneratorLibrary.Constant;
using GeneratorLibrary.Converter;
using GeneratorLibrary.Writer;
using PartsRecord;

namespace GeneratorLibrary
{
	public class LogFileGenerator
	{
		private readonly StructureConfig _configParameters;
		private readonly ConvertToString _converter = new ConvertToString();
		private readonly LogRecordTemplate _logRecordTemplate;

		public LogFileGenerator(StructureConfig configParameters)
		{
			_configParameters = configParameters;
			_logRecordTemplate = new LogRecordTemplate(_configParameters);
		}

		public void GenerateLogFile()
		{
			int count = int.Parse(_configParameters[Keys.ConsoleParameters][Keys.Count]);
			LogRecordParts recordParts;
			using (var _writer = new LogStringWriter(_configParameters[Keys.ConsoleParameters][Keys.FileName]))
			{
				for (int i = 0; i < count; i++)
				{
					recordParts = _logRecordTemplate.GenerateRecord();
					_writer.Write(_converter.Convert(recordParts));
				}
			}
		}
	}
}