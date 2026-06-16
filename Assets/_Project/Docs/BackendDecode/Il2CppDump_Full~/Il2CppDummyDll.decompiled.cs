using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: TargetFramework(".NETFramework,Version=v4.0", FrameworkDisplayName = ".NET Framework 4")]
[assembly: AssemblyCompany("Il2CppDummyDll")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0")]
[assembly: AssemblyProduct("Il2CppDummyDll")]
[assembly: AssemblyTitle("Il2CppDummyDll")]
[assembly: AssemblyVersion("1.0.0.0")]
namespace Il2CppDummyDll;

public class AddressAttribute : Attribute
{
	public string RVA;

	public string Offset;

	public string VA;

	public string Slot;
}
public class AttributeAttribute : Attribute
{
	public string Name;

	public string RVA;

	public string Offset;
}
public class FieldOffsetAttribute : Attribute
{
	public string Offset;
}
public class MetadataOffsetAttribute : Attribute
{
	public string Offset;
}
public class TokenAttribute : Attribute
{
	public string Token;
}
