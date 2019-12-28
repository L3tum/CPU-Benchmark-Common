#region using

using Newtonsoft.Json;
using Reinforced.Typings.Attributes;

#endregion

namespace CPU_Benchmark_Common
{
	[TsInterface(AutoI = false)]
	public class Result
	{
		public Result(string benchmark, double timing, double points, double referenceTiming, double referencePoints,
			double dataThroughput)
		{
			Benchmark = benchmark;
			Timing = timing;
			Points = points;
			ReferenceTiming = referenceTiming;
			ReferencePoints = referencePoints;
			DataThroughput = dataThroughput;
		}

		public Result()
		{
			// Stupid JSON
		}

		public string Benchmark { get; set; }
		public double Points { get; set; }

		[JsonIgnore] [TsIgnore] public double ReferencePoints { get; set; }

		[JsonIgnore] [TsIgnore] public double ReferenceTiming { get; set; }

		[JsonIgnore] [TsIgnore] public double DataThroughput { get; set; }

		public double Timing { get; set; }
	}
}