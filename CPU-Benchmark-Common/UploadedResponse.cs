﻿#region using

using Reinforced.Typings.Attributes;

#endregion

namespace CPU_Benchmark_Common
{
	[TsInterface(AutoI = false)]
	public class UploadedResponse
	{
		public string UUID { get; set; }

		public string RawPath { get; set; }

		public string WebsitePath { get; set; }

		public long Uploaded { get; set; }
	}
}