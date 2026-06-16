using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngineInternal.Input;

[Token(Token = "0x2000002")]
internal unsafe delegate void NativeUpdateCallback(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer);
[StructLayout(2)]
[Token(Token = "0x2000003")]
internal struct NativeInputEventBuffer
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public unsafe void* eventBuffer;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int eventCount;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int sizeInBytes;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int capacityInBytes;
}
[Token(Token = "0x2000004")]
[Flags]
internal enum NativeInputUpdateType
{
	[Token(Token = "0x4000006")]
	Dynamic = 1,
	[Token(Token = "0x4000007")]
	Fixed = 2,
	[Token(Token = "0x4000008")]
	BeforeRender = 4,
	[Token(Token = "0x4000009")]
	Editor = 8,
	[Token(Token = "0x400000A")]
	IgnoreFocus = int.MinValue
}
[Token(Token = "0x2000005")]
[UnityEngine.Bindings.NativeHeader("Modules/Input/Private/InputInternal.h")]
[UnityEngine.Bindings.NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
internal class NativeInputSystem
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static NativeUpdateCallback onUpdate;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Action<NativeInputUpdateType> onBeforeUpdate;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Action<int, string> s_OnDeviceDiscoveredCallback;

	[Token(Token = "0x17000001")]
	internal static extern bool hasDeviceDiscoveredCallback
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2E7BABC", Offset = "0x2E77ABC", VA = "0x2E7BABC")]
		set;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2E7BA8C", Offset = "0x2E77A8C", VA = "0x2E7BA8C")]
	static NativeInputSystem()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2E7BAF8", Offset = "0x2E77AF8", VA = "0x2E7BAF8")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2E7BB74", Offset = "0x2E77B74", VA = "0x2E7BB74")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2E7BC10", Offset = "0x2E77C10", VA = "0x2E7BC10")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2E7BCA0", Offset = "0x2E77CA0", VA = "0x2E7BCA0")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval)
	{
	}
}
