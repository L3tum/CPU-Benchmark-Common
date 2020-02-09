namespace CPU_Benchmark_Common
{
	/// <summary>
	///     Response by the CPU-Benchmark-Server
	/// </summary>
	public class UploadedResponse
	{
		/// <summary>
		///     The unique identifier of the uploaded save
		/// </summary>
		public string UUID { get; set; }

		/// <summary>
		///     The raw github link of the save
		/// </summary>

		public string RawPath { get; set; }

		/// <summary>
		///     The link to the save parsed on the website
		/// </summary>

		public string WebsitePath { get; set; }

		/// <summary>
		///     Timestamp of when the save was uploaded
		/// </summary>
		public long Uploaded { get; set; }
	}
}