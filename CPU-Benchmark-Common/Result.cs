#region using

using Newtonsoft.Json;

#endregion

namespace CPU_Benchmark_Common
{
	/// <summary>
	///     Singular Benchmark result
	/// </summary>
	public class Result
    {
	    /// <summary>
	    ///     Constructor
	    /// </summary>
	    /// <param name="benchmark"></param>
	    /// <param name="timing"></param>
	    /// <param name="points"></param>
	    /// <param name="referenceTiming"></param>
	    /// <param name="referencePoints"></param>
	    /// <param name="dataThroughput"></param>
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

	    /// <summary>
	    ///     JSON Constructor
	    /// </summary>
	    public Result()
        {
            // Stupid JSON
        }

	    /// <summary>
	    ///     The benchmark that was run
	    /// </summary>
	    public string Benchmark { get; set; }

	    /// <summary>
	    ///     The points achieved
	    /// </summary>
	    public double Points { get; set; }

	    /// <summary>
	    ///     Points achieved by the reference CPU
	    /// </summary>
	    [JsonIgnore]
        public double ReferencePoints { get; set; }

	    /// <summary>
	    ///     Time spent on the benchmark by the reference CPU, in ms
	    /// </summary>
	    [JsonIgnore]
        public double ReferenceTiming { get; set; }

	    /// <summary>
	    ///     Approximate data throughput achieved
	    /// </summary>
	    [JsonIgnore]
        public double DataThroughput { get; set; }

	    /// <summary>
	    ///     Time spent on the benchmark, in ms
	    /// </summary>
	    public double Timing { get; set; }
    }
}