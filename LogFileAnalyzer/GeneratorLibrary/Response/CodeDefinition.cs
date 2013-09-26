﻿using System;
using System.Collections;
using System.Globalization;

namespace GeneratorLibrary.Response
{
	class CodeDefinition : IResponse
	{
		private readonly int[] codes;
		private readonly Random random;

		public CodeDefinition(Random random, int[] codes)
		{
			this.codes = codes;
			this.random = random;
		}

		public string GetValue()
		{
			return codes[random.Next(0, codes.Length)].ToString(CultureInfo.InvariantCulture);
		}
	}
}
