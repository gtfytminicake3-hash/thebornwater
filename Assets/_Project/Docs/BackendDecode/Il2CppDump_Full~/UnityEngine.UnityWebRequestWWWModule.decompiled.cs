using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Networking;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[Token(Token = "0x2000002")]
[Obsolete("Use UnityWebRequest, a fully featured replacement which is more efficient and has additional features")]
public class WWW : CustomYieldInstruction, IDisposable
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	private UnityWebRequest _uwr;

	[Token(Token = "0x17000001")]
	public string error
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x3047E2C", Offset = "0x3043E2C", VA = "0x3047E2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public string text
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3047F48", Offset = "0x3043F48", VA = "0x3047F48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public string url
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x30480BC", Offset = "0x30440BC", VA = "0x30480BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public override bool keepWaiting
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x30480D4", Offset = "0x30440D4", VA = "0x30480D4", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x3047DEC", Offset = "0x3043DEC", VA = "0x3047DEC")]
	public WWW(string url)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3048100", Offset = "0x3044100", VA = "0x3048100", Slot = "9")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3047FD8", Offset = "0x3043FD8", VA = "0x3047FD8")]
	private bool WaitUntilDoneIfPossible()
	{
		return default(bool);
	}
}
