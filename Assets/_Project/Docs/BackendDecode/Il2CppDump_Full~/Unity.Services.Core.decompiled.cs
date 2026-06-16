using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Services.Core;

[Token(Token = "0x2000002")]
internal class ExternalUserIdProperty
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string m_UserId;

	[Token(Token = "0x17000001")]
	public string UserId
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2DA1D68", Offset = "0x2D9DD68", VA = "0x2DA1D68")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2DA1D70", Offset = "0x2D9DD70", VA = "0x2DA1D70")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<string> UserIdChanged
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2DA1C08", Offset = "0x2D9DC08", VA = "0x2DA1C08")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2DA1CB8", Offset = "0x2D9DCB8", VA = "0x2DA1CB8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2DA1D90", Offset = "0x2D9DD90", VA = "0x2DA1D90")]
	public ExternalUserIdProperty()
	{
	}
}
[Token(Token = "0x2000003")]
public class InitializationOptions
{
	[Token(Token = "0x17000002")]
	internal IDictionary<string, object> Values
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2DA1D98", Offset = "0x2D9DD98", VA = "0x2DA1D98")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2DA1DA0", Offset = "0x2D9DDA0", VA = "0x2DA1DA0")]
	public InitializationOptions()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2DA1E20", Offset = "0x2D9DE20", VA = "0x2DA1E20")]
	internal InitializationOptions(IDictionary<string, object> values)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2DA1E48", Offset = "0x2D9DE48", VA = "0x2DA1E48")]
	internal InitializationOptions(InitializationOptions source)
	{
	}
}
[Token(Token = "0x2000004")]
public class ServicesInitializationException : Exception
{
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2DA1ED4", Offset = "0x2D9DED4", VA = "0x2DA1ED4")]
	public ServicesInitializationException()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2DA1F2C", Offset = "0x2D9DF2C", VA = "0x2DA1F2C")]
	public ServicesInitializationException(string message)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2DA1F94", Offset = "0x2D9DF94", VA = "0x2DA1F94")]
	public ServicesInitializationException(string message, Exception innerException)
	{
	}
}
[Token(Token = "0x2000005")]
public enum ServicesInitializationState
{
	[Token(Token = "0x4000005")]
	Uninitialized,
	[Token(Token = "0x4000006")]
	Initializing,
	[Token(Token = "0x4000007")]
	Initialized
}
[Token(Token = "0x2000006")]
internal class UnityProjectNotLinkedException : ServicesInitializationException
{
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2DA2004", Offset = "0x2D9E004", VA = "0x2DA2004")]
	public UnityProjectNotLinkedException(string message)
	{
	}
}
[Token(Token = "0x2000007")]
public interface IUnityServices
{
	[Token(Token = "0x600000E")]
	Task InitializeAsync([Optional] InitializationOptions options);
}
[Token(Token = "0x2000008")]
public static class UnityServices
{
	[StructLayout(3)]
	[Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct <InitializeAsync>d__26 : IAsyncStateMachine
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InitializationOptions options;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<object> <>u__1;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__2;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2DA2554", Offset = "0x2D9E554", VA = "0x2DA2554", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2DA2BB4", Offset = "0x2D9EBB4", VA = "0x2DA2BB4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal static ExternalUserIdProperty ExternalUserIdProperty;

	[Token(Token = "0x17000003")]
	public static IUnityServices Instance
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2DA2008", Offset = "0x2D9E008", VA = "0x2DA2008")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2DA2060", Offset = "0x2D9E060", VA = "0x2DA2060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	internal static TaskCompletionSource<object> InstantiationCompletion
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2DA20BC", Offset = "0x2D9E0BC", VA = "0x2DA20BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2DA2114", Offset = "0x2D9E114", VA = "0x2DA2114")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	private static Dictionary<string, IUnityServices> s_Services
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2DA2170", Offset = "0x2D9E170", VA = "0x2DA2170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public static string ExternalUserId
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2DA21C8", Offset = "0x2D9E1C8", VA = "0x2DA21C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2DA222C", Offset = "0x2D9E22C", VA = "0x2DA222C")]
		set
		{
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2DA22B8", Offset = "0x2D9E2B8", VA = "0x2DA22B8")]
	public static Task InitializeAsync()
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2DA232C", Offset = "0x2D9E32C", VA = "0x2DA232C")]
	[AsyncStateMachine(typeof(<InitializeAsync>d__26))]
	public static Task InitializeAsync(InitializationOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2DA23EC", Offset = "0x2D9E3EC", VA = "0x2DA23EC")]
	internal static void ClearServices()
	{
	}
}
[Token(Token = "0x200000A")]
internal static class UnityServicesBuilder
{
	[Token(Token = "0x200000B")]
	internal delegate IUnityServices CreationDelegate(string servicesId);

	[Token(Token = "0x17000007")]
	internal static CreationDelegate InstanceCreationDelegate
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2DA2C1C", Offset = "0x2D9EC1C", VA = "0x2DA2C1C")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Token(Token = "0x200000C")]
internal static class UnityThreadUtils
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int s_UnityThreadId;

	[Token(Token = "0x17000008")]
	private static TaskScheduler UnityThreadScheduler
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2DA2D18", Offset = "0x2D9ED18", VA = "0x2DA2D18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public static bool IsRunningOnUnityThread
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2DA2B54", Offset = "0x2D9EB54", VA = "0x2DA2B54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2DA2D64", Offset = "0x2D9ED64", VA = "0x2DA2D64")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void CaptureUnityThreadInfo()
	{
	}
}
