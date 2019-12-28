#region using

using Reinforced.Typings.Attributes;

#endregion

[assembly: TsGlobal(GenerateDocumentation = true, DiscardNamespacesWhenUsingModules = true, UseModules = true)]
[assembly:
	TsImport(ImportRequire = false, ImportSource = "@l3tum/hardwareinformation",
		ImportTarget = "{ MachineInformation }")]