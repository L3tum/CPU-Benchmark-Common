#region using

using System;
using System.Collections.Generic;
using HardwareInformation;

#endregion

namespace CPU_Benchmark_Common
{
	public class Save
	{
		public Save()
		{
			Results = new Dictionary<uint, List<Result>>();
			Uploaded = 0;
		}

		public string DotNetVersion { get; set; }
		public MachineInformation MachineInformation { get; set; }
		public Dictionary<uint, List<Result>> Results { get; set; }
		public long Uploaded { get; set; }
		public string UUID { get; set; }
		public Version Version { get; set; }
	}
}