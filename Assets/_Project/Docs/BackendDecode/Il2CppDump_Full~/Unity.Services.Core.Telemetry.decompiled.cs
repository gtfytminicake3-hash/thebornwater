using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Services.Core.Internal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Services.Core.Telemetry.Internal;

[Token(Token = "0x2000002")]
internal class Diagnostics : IDiagnostics
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2DAD44C", Offset = "0x2DA944C", VA = "0x2DAD44C", Slot = "4")]
	public void SendDiagnostic(string name, string message, [Optional] IDictionary<string, string> tags)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2DAD450", Offset = "0x2DA9450", VA = "0x2DAD450")]
	public Diagnostics()
	{
	}
}
[Token(Token = "0x2000003")]
internal class DiagnosticsFactory : IDiagnosticsFactory, IServiceComponent
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2DAD4CC", Offset = "0x2DA94CC", VA = "0x2DAD4CC", Slot = "4")]
	public IDiagnostics Create(string packageName)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2DAD51C", Offset = "0x2DA951C", VA = "0x2DAD51C")]
	public DiagnosticsFactory()
	{
	}
}
[Token(Token = "0x2000004")]
internal class Metrics : IMetrics
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2DAD598", Offset = "0x2DA9598", VA = "0x2DAD598", Slot = "4")]
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, double value, IDictionary<string, string> tags)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2DAD59C", Offset = "0x2DA959C", VA = "0x2DAD59C", Slot = "5")]
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, double time, IDictionary<string, string> tags)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2DAD5A0", Offset = "0x2DA95A0", VA = "0x2DAD5A0", Slot = "6")]
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, double value, IDictionary<string, string> tags)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2DAD5A4", Offset = "0x2DA95A4", VA = "0x2DAD5A4")]
	public Metrics()
	{
	}
}
[Token(Token = "0x2000005")]
internal class MetricsFactory : IMetricsFactory, IServiceComponent
{
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2DAD620", Offset = "0x2DA9620", VA = "0x2DAD620", Slot = "4")]
	public IMetrics Create(string packageName)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2DAD670", Offset = "0x2DA9670", VA = "0x2DAD670")]
	public MetricsFactory()
	{
	}
}
