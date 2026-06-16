using System.Reflection;
using Il2CppDummyDll;
using Unity.Services.Core.Device.Internal;
using Unity.Services.Core.Internal;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Services.Core.Device;

[Token(Token = "0x2000002")]
internal class InstallationId : IInstallationId, IServiceComponent
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	internal string Identifier;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	internal IUserIdentifierProvider UnityAdsIdentifierProvider;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	internal IUserIdentifierProvider UnityAnalyticsIdentifierProvider;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2DA2E24", Offset = "0x2D9EE24", VA = "0x2DA2E24")]
	public InstallationId()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2DA2ECC", Offset = "0x2D9EECC", VA = "0x2DA2ECC", Slot = "4")]
	public string GetOrCreateIdentifier()
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2DA2EF8", Offset = "0x2D9EEF8", VA = "0x2DA2EF8")]
	public void CreateIdentifier()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2DA3170", Offset = "0x2D9F170", VA = "0x2DA3170")]
	private static string ReadIdentifierFromFile()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2DA31E0", Offset = "0x2D9F1E0", VA = "0x2DA31E0")]
	private static void WriteIdentifierToFile(string identifier)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2DA31B4", Offset = "0x2D9F1B4", VA = "0x2DA31B4")]
	private static string GenerateGuid()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
internal static class AndroidUtils
{
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2DA3234", Offset = "0x2D9F234", VA = "0x2DA3234")]
	public static AndroidJavaObject GetUnityActivity()
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2DA33C8", Offset = "0x2D9F3C8", VA = "0x2DA33C8")]
	public static AndroidJavaObject GetSharedPreferences(AndroidJavaObject context, string name, int mode = 0)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2DA34FC", Offset = "0x2D9F4FC", VA = "0x2DA34FC")]
	public static AndroidJavaObject GetSharedPreferences(string name, int mode = 0)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2DA3620", Offset = "0x2D9F620", VA = "0x2DA3620")]
	public static string SharedPreferencesGetString(string name, string key, string defValue = "")
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2DA3758", Offset = "0x2D9F758", VA = "0x2DA3758")]
	public static string SharedPreferencesGetString(AndroidJavaObject preferences, string key, string defValue = "")
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2DA397C", Offset = "0x2D9F97C", VA = "0x2DA397C")]
	public static void SharedPreferencesPutString(string name, string key, string value)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2DA3AA8", Offset = "0x2D9FAA8", VA = "0x2DA3AA8")]
	public static void SharedPreferencesPutString(AndroidJavaObject preferences, string key, string value)
	{
	}
}
[Token(Token = "0x2000004")]
internal interface IUserIdentifierProvider
{
	[Token(Token = "0x17000001")]
	string UserId
	{
		[Token(Token = "0x600000E")]
		get;
		[Token(Token = "0x600000F")]
		set;
	}
}
[Token(Token = "0x2000005")]
internal class UnityAdsIdentifier : IUserIdentifierProvider
{
	[Token(Token = "0x17000002")]
	public string UserId
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2DA3CF0", Offset = "0x2D9FCF0", VA = "0x2DA3CF0", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2DA3D6C", Offset = "0x2D9FD6C", VA = "0x2DA3D6C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	private static string IdentifierForInstallAndroid
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2DA3CF4", Offset = "0x2D9FCF4", VA = "0x2DA3CF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2DA3D74", Offset = "0x2D9FD74", VA = "0x2DA3D74")]
		set
		{
		}
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2DA2EBC", Offset = "0x2D9EEBC", VA = "0x2DA2EBC")]
	public UnityAdsIdentifier()
	{
	}
}
[Token(Token = "0x2000006")]
internal class UnityAnalyticsIdentifier : IUserIdentifierProvider
{
	[Token(Token = "0x17000004")]
	public string UserId
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2DA3DDC", Offset = "0x2D9FDDC", VA = "0x2DA3DDC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2DA3E20", Offset = "0x2D9FE20", VA = "0x2DA3E20", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2DA2EC4", Offset = "0x2D9EEC4", VA = "0x2DA2EC4")]
	public UnityAnalyticsIdentifier()
	{
	}
}
