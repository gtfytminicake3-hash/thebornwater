using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
public static class JsonUtility
{
	[MethodImpl(4096)]
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2E7BD30", Offset = "0x2E77D30", VA = "0x2E7BD30")]
	[UnityEngine.Bindings.FreeFunction("ToJsonInternal", true)]
	[UnityEngine.Bindings.ThreadSafe]
	private static extern string ToJsonInternal([UnityEngine.Bindings.NotNull("ArgumentNullException")] object obj, bool prettyPrint);

	[MethodImpl(4096)]
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2E7BD74", Offset = "0x2E77D74", VA = "0x2E7BD74")]
	[UnityEngine.Bindings.ThreadSafe]
	[UnityEngine.Bindings.FreeFunction("FromJsonInternal", true, ThrowsException = true)]
	private static extern object FromJsonInternal(string json, object objectToOverwrite, Type type);

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2E7BDC8", Offset = "0x2E77DC8", VA = "0x2E7BDC8")]
	public static string ToJson(object obj)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2E7BDD0", Offset = "0x2E77DD0", VA = "0x2E7BDD0")]
	public static string ToJson(object obj, bool prettyPrint)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	public static T FromJson<T>(string json)
	{
		return (T)null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2E7BF40", Offset = "0x2E77F40", VA = "0x2E7BF40")]
	public static object FromJson(string json, Type type)
	{
		return null;
	}
}
