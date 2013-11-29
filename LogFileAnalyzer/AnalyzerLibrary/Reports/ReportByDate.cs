﻿using System;
using System.Collections.Generic;
using System.Linq;
using AnalyzerLibrary.Constant;
using AnalyzerLibrary.Entities;
using AnalyzerLibrary.ReportResults;
using PartsRecord;

namespace AnalyzerLibrary.Reports
{
	public class ReportByDate : IReport
	{
		private readonly ReportParameters _parameters;

		public ReportByDate(ReportParameters parameters)
		{
			_parameters = parameters;
		}

		public ReportResult GetReport()
		{
			DateTime min = DateTime.Parse(_parameters.GeneralParams[Keys.Reports.Date + Keys.Reports.Min].ToString());
			DateTime max = DateTime.Parse(_parameters.GeneralParams[Keys.Reports.Date + Keys.Reports.Max].ToString());

			List<LogRecordParts> findResult =
				_parameters.LogRecordPartses.Where(x => x.Date.DateNow >= min & x.Date.DateNow <= max).ToList();

			return new ReportDateResult(findResult);
		}
	}
}