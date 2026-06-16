using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
public static class ImageConversion
{
	[MethodImpl(4096)]
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2E54608", Offset = "0x2E50608", VA = "0x2E54608")]
	[UnityEngine.Bindings.NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = true, ThrowsException = true)]
	public static extern byte[] EncodeToPNG(this Texture2D tex);
}
