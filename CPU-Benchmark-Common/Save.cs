#region using

using System;
using System.Collections.Generic;
using HardwareInformation;

#endregion

namespace CPU_Benchmark_Common
{
	/// <summary>
	///     Benchmark save
	/// </summary>
	public class Save
    {
	    /// <summary>
	    ///     Constructor
	    /// </summary>
	    public Save()
        {
            Results = new Dictionary<uint, List<Result>>();
            Uploaded = 0;
        }

	    /// <summary>
	    ///     Version of .NET the benchmark was run with
	    /// </summary>
	    public string DotNetVersion { get; set; }

	    /// <summary>
	    ///     Contains the information on the PC
	    /// </summary>
	    public MachineInformation MachineInformation { get; set; }

	    /// <summary>
	    ///     Benchmark results
	    /// </summary>
	    public Dictionary<uint, List<Result>> Results { get; set; }

	    /// <summary>
	    ///     Timestamp of when it was uploaded
	    /// </summary>
	    public long Uploaded { get; set; }

	    /// <summary>
	    ///     Unique identifier for this save
	    /// </summary>
	    public string UUID { get; set; }

	    /// <summary>
	    ///     Version of the benchmark the save was created with
	    /// </summary>
	    public Version Version { get; set; }
    }
}