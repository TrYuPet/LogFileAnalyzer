﻿using System.Globalization;
using PartsRecord;

namespace GeneratorLibrary.Converter
{
	public class UserIdConverter : IConverter<string>
	{
		private readonly UserId _userId;

		public UserIdConverter(UserId userId)
		{
			_userId = userId;
		}

		public string Convert()
		{
			return _userId.Id.ToString(CultureInfo.InvariantCulture);
		}
	}
}