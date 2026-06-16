using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.XR;

[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
[UnityEngine.Bindings.NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[UnityEngine.Bindings.NativeHeader("Modules/VR/VRModule.h")]
[UnityEngine.Bindings.NativeHeader("Runtime/Interfaces/IVRDevice.h")]
[UnityEngine.Bindings.NativeConditional("ENABLE_VR")]
public static class XRSettings
{
	[Token(Token = "0x2000003")]
	public enum StereoRenderingMode
	{
		[Token(Token = "0x4000002")]
		MultiPass,
		[Token(Token = "0x4000003")]
		SinglePass,
		[Token(Token = "0x4000004")]
		SinglePassInstanced,
		[Token(Token = "0x4000005")]
		SinglePassMultiview
	}

	[Token(Token = "0x17000001")]
	public static extern bool enabled
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x3048CE4", Offset = "0x3044CE4", VA = "0x3048CE4")]
		[UnityEngine.Bindings.StaticAccessor("GetIVRDeviceScripting()", UnityEngine.Bindings.StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		get;
	}

	[Token(Token = "0x17000002")]
	[UnityEngine.Bindings.NativeName("Active")]
	[UnityEngine.Bindings.StaticAccessor("GetIVRDeviceScripting()", UnityEngine.Bindings.StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static extern bool isDeviceActive
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x3048D0C", Offset = "0x3044D0C", VA = "0x3048D0C")]
		get;
	}

	[Token(Token = "0x17000003")]
	[UnityEngine.Bindings.NativeName("RenderScale")]
	[UnityEngine.Bindings.StaticAccessor("GetIVRDeviceScripting()", UnityEngine.Bindings.StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static extern float eyeTextureResolutionScale
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3048D34", Offset = "0x3044D34", VA = "0x3048D34")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x3048D5C", Offset = "0x3044D5C", VA = "0x3048D5C")]
		set;
	}

	[Token(Token = "0x17000004")]
	[UnityEngine.Bindings.StaticAccessor("GetIVRDeviceScripting()", UnityEngine.Bindings.StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static extern int eyeTextureWidth
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3048D94", Offset = "0x3044D94", VA = "0x3048D94")]
		get;
	}

	[Token(Token = "0x17000005")]
	[UnityEngine.Bindings.StaticAccessor("GetIVRDeviceScripting()", UnityEngine.Bindings.StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static extern int eyeTextureHeight
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3048DBC", Offset = "0x3044DBC", VA = "0x3048DBC")]
		get;
	}

	[Token(Token = "0x17000006")]
	[UnityEngine.Bindings.StaticAccessor("GetIVRDeviceScripting()", UnityEngine.Bindings.StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	[UnityEngine.Bindings.NativeName("IntermediateEyeTextureDesc")]
	[UnityEngine.Bindings.NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
	public static RenderTextureDescriptor eyeTextureDesc
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3048DE4", Offset = "0x3044DE4", VA = "0x3048DE4")]
		get
		{
			return default(RenderTextureDescriptor);
		}
	}

	[Token(Token = "0x17000007")]
	public static float renderViewportScale
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3048E90", Offset = "0x3044E90", VA = "0x3048E90")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000008")]
	[UnityEngine.Bindings.StaticAccessor("GetIVRDeviceScripting()", UnityEngine.Bindings.StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	[UnityEngine.Bindings.NativeName("RenderViewportScale")]
	internal static extern float renderViewportScaleInternal
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3048EB8", Offset = "0x3044EB8", VA = "0x3048EB8")]
		get;
	}

	[Token(Token = "0x17000009")]
	[UnityEngine.Bindings.NativeName("DeviceName")]
	[UnityEngine.Bindings.StaticAccessor("GetIVRDeviceScripting()", UnityEngine.Bindings.StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static extern string loadedDeviceName
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3048EE0", Offset = "0x3044EE0", VA = "0x3048EE0")]
		get;
	}

	[Token(Token = "0x1700000A")]
	public static extern string[] supportedDevices
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3048F08", Offset = "0x3044F08", VA = "0x3048F08")]
		get;
	}

	[Token(Token = "0x1700000B")]
	[UnityEngine.Bindings.StaticAccessor("GetIVRDeviceScripting()", UnityEngine.Bindings.StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static extern StereoRenderingMode stereoRenderingMode
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3048F30", Offset = "0x3044F30", VA = "0x3048F30")]
		get;
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x3048E54", Offset = "0x3044E54", VA = "0x3048E54")]
	private static extern void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret);
}
[Token(Token = "0x2000004")]
[UnityEngine.Bindings.NativeConditional("ENABLE_VR")]
public static class XRDevice
{
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<string> deviceLoaded;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3048F58", Offset = "0x3044F58", VA = "0x3048F58")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void InvokeDeviceLoaded(string loadedDeviceName)
	{
	}
}
