#region using

using System;
using System.Collections.Generic;
using HardwareInformation;

#endregion

namespace CPU_Benchmark_Common
{
	public class Save
	{
		public string DotNetVersion;
		public MachineInformation MachineInformation;
		public Dictionary<uint, List<Result>> Results;
		public long Uploaded;
		public string UUID;
		public Version Version;

		public Save()
		{
			Results = new Dictionary<uint, List<Result>>();
			Uploaded = 0;
		}
	}
}