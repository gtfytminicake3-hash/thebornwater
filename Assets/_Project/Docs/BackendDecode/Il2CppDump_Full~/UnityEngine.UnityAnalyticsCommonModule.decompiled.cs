using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.Analytics;

[StructLayout(0)]
[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
public static class AnalyticsCommon
{
	[Token(Token = "0x17000001")]
	[UnityEngine.Bindings.StaticAccessor("GetUnityAnalyticsCommon()", UnityEngine.Bindings.StaticAccessorType.Dot)]
	private static extern bool ugsAnalyticsEnabledInternal
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x3042B98", Offset = "0x303EB98", VA = "0x3042B98")]
		[UnityEngine.Bindings.NativeMethod("SetUGSAnalyticsUserOptStatus")]
		set;
	}

	[Token(Token = "0x17000002")]
	public static bool ugsAnalyticsEnabled
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x3042BD4", Offset = "0x303EBD4", VA = "0x3042BD4")]
		set
		{
		}
	}
}
[Token(Token = "0x2000003")]
public interface UGSAnalyticsInternalTools
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3042C10", Offset = "0x303EC10", VA = "0x3042C10")]
	static void SetPrivacyStatus(bool status)
	{
	}
}
