using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Modules/SpriteMask/Public/ScriptBindings/SpriteMask.bindings.h")]
[UnityEngine.Bindings.StaticAccessor("SpriteUtilityBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
public static class SpriteMaskUtility
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2E88000", Offset = "0x2E84000", VA = "0x2E88000")]
	public static bool HasSpriteMaskInLayerRange(SortingLayerRange range)
	{
		return default(bool);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2E88044", Offset = "0x2E84044", VA = "0x2E88044")]
	private static extern bool HasSpriteMaskInLayerRange_Injected(ref SortingLayerRange range);
}
