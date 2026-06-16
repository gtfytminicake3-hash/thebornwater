using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;
using Unity.Services.Core.Internal.Serialization;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Services.Core.Configuration;

[Token(Token = "0x2000002")]
internal class CloudProjectId : ICloudProjectId, IServiceComponent
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2DA0C04", Offset = "0x2D9CC04", VA = "0x2DA0C04", Slot = "4")]
	public string GetCloudProjectId()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2DA0C54", Offset = "0x2D9CC54", VA = "0x2DA0C54")]
	public CloudProjectId()
	{
	}
}
[Token(Token = "0x2000003")]
internal static class ConfigurationCollectionHelper
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2DA0C5C", Offset = "0x2D9CC5C", VA = "0x2DA0C5C")]
	public static void FillWith(this IDictionary<string, ConfigurationEntry> self, SerializableProjectConfiguration config)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2DA0E7C", Offset = "0x2D9CE7C", VA = "0x2DA0E7C")]
	public static void FillWith(this IDictionary<string, ConfigurationEntry> self, InitializationOptions options)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2DA0CEC", Offset = "0x2D9CCEC", VA = "0x2DA0CEC")]
	private static void SetOrCreateEntry(this IDictionary<string, ConfigurationEntry> self, string key, ConfigurationEntry entry)
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
internal class ConfigurationEntry
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[JsonRequired]
	[SerializeField]
	private string m_Value;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[JsonRequired]
	[SerializeField]
	private bool m_IsReadOnly;

	[Token(Token = "0x17000001")]
	[JsonIgnore]
	public string Value
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2DA1254", Offset = "0x2D9D254", VA = "0x2DA1254")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	[JsonIgnore]
	public bool IsReadOnly
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2DA125C", Offset = "0x2D9D25C", VA = "0x2DA125C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2DA1264", Offset = "0x2D9D264", VA = "0x2DA1264")]
	public ConfigurationEntry()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2DA126C", Offset = "0x2D9D26C", VA = "0x2DA126C")]
	public ConfigurationEntry(string value, bool isReadOnly = false)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2DA123C", Offset = "0x2D9D23C", VA = "0x2DA123C")]
	public bool TrySetValue(string value)
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2DA1228", Offset = "0x2D9D228", VA = "0x2DA1228")]
	public static implicit operator string(ConfigurationEntry entry)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2DA11C8", Offset = "0x2D9D1C8", VA = "0x2DA11C8")]
	public static implicit operator ConfigurationEntry(string value)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
internal static class ConfigurationUtils
{
	[Token(Token = "0x17000003")]
	public static IConfigurationLoader ConfigurationLoader
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2DA129C", Offset = "0x2D9D29C", VA = "0x2DA129C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Token(Token = "0x2000006")]
internal class ExternalUserId : IExternalUserId, IServiceComponent
{
	[Token(Token = "0x17000004")]
	public string UserId
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2DA13C4", Offset = "0x2D9D3C4", VA = "0x2DA13C4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<string> UserIdChanged
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2DA1428", Offset = "0x2D9D428", VA = "0x2DA1428", Slot = "5")]
		add
		{
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2DA1494", Offset = "0x2D9D494", VA = "0x2DA1494", Slot = "6")]
		remove
		{
		}
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2DA1500", Offset = "0x2D9D500", VA = "0x2DA1500")]
	public ExternalUserId()
	{
	}
}
[Token(Token = "0x2000007")]
internal interface IConfigurationLoader
{
	[Token(Token = "0x6000013")]
	Task<SerializableProjectConfiguration> GetConfigAsync();
}
[Token(Token = "0x2000008")]
internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly IReadOnlyDictionary<string, ConfigurationEntry> m_ConfigValues;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2DA1508", Offset = "0x2D9D508", VA = "0x2DA1508")]
	public ProjectConfiguration(IReadOnlyDictionary<string, ConfigurationEntry> configValues, Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2DA1534", Offset = "0x2D9D534", VA = "0x2DA1534", Slot = "4")]
	public string GetString(string key, [Optional] string defaultValue)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000009")]
internal struct SerializableProjectConfiguration
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	[JsonRequired]
	internal string[] Keys;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[JsonRequired]
	[SerializeField]
	internal ConfigurationEntry[] Values;

	[Token(Token = "0x17000005")]
	public static SerializableProjectConfiguration Empty
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2DA160C", Offset = "0x2D9D60C", VA = "0x2DA160C")]
		get
		{
			return default(SerializableProjectConfiguration);
		}
	}
}
[Token(Token = "0x200000A")]
internal class StreamingAssetsConfigurationLoader : IConfigurationLoader
{
	[StructLayout(3)]
	[Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct <GetConfigAsync>d__2 : IAsyncStateMachine
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<SerializableProjectConfiguration> <>t__builder;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StreamingAssetsConfigurationLoader <>4__this;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<string> <>u__1;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2DA17FC", Offset = "0x2D9D7FC", VA = "0x2DA17FC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2DA1B8C", Offset = "0x2D9DB8C", VA = "0x2DA1B8C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly Unity.Services.Core.Internal.Serialization.IJsonSerializer m_Serializer;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2DA139C", Offset = "0x2D9D39C", VA = "0x2DA139C")]
	public StreamingAssetsConfigurationLoader(Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2DA1710", Offset = "0x2D9D710", VA = "0x2DA1710", Slot = "4")]
	[AsyncStateMachine(typeof(<GetConfigAsync>d__2))]
	public Task<SerializableProjectConfiguration> GetConfigAsync()
	{
		return null;
	}
}
[Token(Token = "0x200000C")]
internal static class StreamingAssetsUtils
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2DA1AF4", Offset = "0x2D9DAF4", VA = "0x2DA1AF4")]
	public static Task<string> GetFileTextFromStreamingAssetsAsync(string path)
	{
		return null;
	}
}
