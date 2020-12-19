#region using

using System.Collections;
using System.Collections.Generic;
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
	    /// <param name="iterations"></param>
	    /// <param name="points"></param>
	    /// <param name="referenceIterations"></param>
	    /// <param name="referencePoints"></param>
	    /// <param name="dataThroughput"></param>
	    public Result(string benchmark, ulong iterations, double points, ulong referenceIterations,
            double referencePoints,
            double dataThroughput)
        {
            Benchmark = benchmark;
            Iterations = iterations;
            Points = points;
            ReferenceIterations = referenceIterations;
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
        public ulong ReferenceIterations { get; set; }

	    /// <summary>
	    ///     Approximate data throughput achieved
	    /// </summary>
	    [JsonIgnore]
        public double DataThroughput { get; set; }

	    /// <summary>
	    ///     Time spent on the benchmark, in ms
	    /// </summary>
	    public ulong Iterations { get; set; }

	    /// <summary>
	    ///     The cores the benchmark was run on
	    /// </summary>
	    public BitArray CoreId { get; set; }

	    /// <summary>
	    ///     The frequencies achieved during the run
	    /// </summary>
	    public Dictionary<ulong, FrequencyPerCore> Frequencies { get; set; }

        public sealed class FrequencyPerCore
        {
            public int BaseFrequency { get; set; }
            public int AverageFrequency { get; set; }
            public int HighestFrequency { get; set; }
            public int LowestFrequency { get; set; }
        }
    }
}