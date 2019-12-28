#region using

using Reinforced.Typings.Attributes;

#endregion

[assembly: TsGlobal(GenerateDocumentation = true, UseModules = true, DiscardNamespacesWhenUsingModules = true)]
[assembly: TsImport(ImportRequire = false, ImportSource = "@l3tum/hardwareinformation/HardwareInformation/MachineInformation", ImportTarget = "{ MachineInformation }")]