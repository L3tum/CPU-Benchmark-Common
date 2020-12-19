#region using

using Reinforced.Typings.Fluent;

#endregion

namespace CPU_Benchmark_Common.Typings
{
    public static class ReinforcedTypingsConfiguration
    {
        public static void Configure(ConfigurationBuilder builder)
        {
            builder.Global(globalBuilder =>
            {
                globalBuilder.UseModules();
                globalBuilder.GenerateDocumentation();
            });

            builder.AddImport("{ MachineInformation }", "@l3tum/hardwareinformation");

            builder.ExportAsClasses(new[]
            {
                typeof(Save),
                typeof(Result),
                typeof(UploadedResponse),
                typeof(Result.FrequencyPerCore)
            }, classBuilder =>
            {
                classBuilder.WithAllFields().WithAllMethods().WithAllProperties();
                classBuilder.WithProperties(prop => prop.Name == "MachineInformation",
                    prop => prop.Type("MachineInformation"));
                classBuilder.WithProperties(prop => prop.Name == "ReferencePoints", prop => prop.Ignore());
                classBuilder.WithProperties(prop => prop.Name == "ReferenceIterations", prop => prop.Ignore());
                classBuilder.WithProperties(prop => prop.Name == "DataThroughput", prop => prop.Ignore());
            });
        }
    }
}