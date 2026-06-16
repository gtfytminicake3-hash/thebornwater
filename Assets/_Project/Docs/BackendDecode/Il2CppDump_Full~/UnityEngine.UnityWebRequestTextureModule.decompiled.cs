using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.Networking;

[StructLayout(0)]
[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Modules/UnityWebRequestTexture/Public/DownloadHandlerTexture.h")]
public sealed class DownloadHandlerTexture : DownloadHandler
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private NativeArray<byte> m_NativeData;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool mNonReadable;

	[Token(Token = "0x17000001")]
	public Texture2D texture
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3047C34", Offset = "0x3043C34", VA = "0x3047C34")]
		get
		{
			return null;
		}
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x3047B14", Offset = "0x3043B14", VA = "0x3047B14")]
	private static extern IntPtr Create(DownloadHandlerTexture obj, bool readable);

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x3047B58", Offset = "0x3043B58", VA = "0x3047B58")]
	private void InternalCreateTexture(bool readable)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3047BA4", Offset = "0x3043BA4", VA = "0x3047BA4")]
	public DownloadHandlerTexture(bool readable)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x3047C04", Offset = "0x3043C04", VA = "0x3047C04", Slot = "6")]
	protected override NativeArray<byte> GetNativeData()
	{
		return default(NativeArray<byte>);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3047C10", Offset = "0x3043C10", VA = "0x3047C10", Slot = "5")]
	public override void Dispose()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3047C70", Offset = "0x3043C70", VA = "0x3047C70")]
	[UnityEngine.Bindings.NativeThrows]
	private extern Texture2D InternalGetTextureNative();

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x3047CAC", Offset = "0x3043CAC", VA = "0x3047CAC")]
	public static Texture2D GetContent(UnityWebRequest www)
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public static class UnityWebRequestTexture
{
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3047D28", Offset = "0x3043D28", VA = "0x3047D28")]
	public static UnityWebRequest GetTexture(string uri)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x3047D30", Offset = "0x3043D30", VA = "0x3047D30")]
	public static UnityWebRequest GetTexture(string uri, bool nonReadable)
	{
		return null;
	}
}
