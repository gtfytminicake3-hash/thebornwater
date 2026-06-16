using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Modules/ScreenCapture/Public/CaptureScreenshot.h")]
public static class ScreenCapture
{
	[Token(Token = "0x2000003")]
	public enum StereoScreenCaptureMode
	{
		[Token(Token = "0x4000002")]
		LeftEye = 1,
		[Token(Token = "0x4000003")]
		RightEye,
		[Token(Token = "0x4000004")]
		BothEyes
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2E875B8", Offset = "0x2E835B8", VA = "0x2E875B8")]
	public static void CaptureScreenshot(string filename)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2E875FC", Offset = "0x2E835FC", VA = "0x2E875FC")]
	private static extern void CaptureScreenshot(string filename, [DefaultValue("1")] int superSize, [DefaultValue("1")] StereoScreenCaptureMode CaptureMode);
}
