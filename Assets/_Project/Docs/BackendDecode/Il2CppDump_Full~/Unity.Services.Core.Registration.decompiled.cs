using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Unity.Services.Core.Configuration;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Internal;
using Unity.Services.Core.Internal.Serialization;
using Unity.Services.Core.Scheduler.Internal;
using Unity.Services.Core.Telemetry.Internal;
using Unity.Services.Core.Threading.Internal;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Services.Core.Registration;

[Token(Token = "0x2000002")]
internal class CorePackageInitializer : IInitializablePackageV2, IInitializablePackage, Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider
{
	[StructLayout(3)]
	[Token(Token = "0x2000003")]
	[CompilerGenerated]
	private struct <GenerateProjectConfigurationAsync>d__53 : IAsyncStateMachine
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.ProjectConfiguration> <>t__builder;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InitializationOptions options;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CorePackageInitializer <>4__this;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2DAB988", Offset = "0x2DA7988", VA = "0x2DAB988", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2DABC94", Offset = "0x2DA7C94", VA = "0x2DABC94", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct <GetSerializedConfigOrEmptyAsync>d__54 : IAsyncStateMachine
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2DABD10", Offset = "0x2DA7D10", VA = "0x2DABD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2DAC14C", Offset = "0x2DA814C", VA = "0x2DAC14C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct <InitializeComponents>d__47 : IAsyncStateMachine
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CorePackageInitializer <>4__this;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2DAC1C8", Offset = "0x2DA81C8", VA = "0x2DAC1C8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2DAC5D4", Offset = "0x2DA85D4", VA = "0x2DAC5D4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct <InitializeProjectConfigAsync>d__52 : IAsyncStateMachine
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CorePackageInitializer <>4__this;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InitializationOptions options;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<Unity.Services.Core.Configuration.ProjectConfiguration> <>u__1;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2DAC63C", Offset = "0x2DA863C", VA = "0x2DAC63C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2DAC8A8", Offset = "0x2DA88A8", VA = "0x2DAC8A8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CoreRegistry m_Registry;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Unity.Services.Core.Internal.Serialization.IJsonSerializer m_Serializer;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private InitializationOptions m_CurrentInitializationOptions;

	[Token(Token = "0x17000001")]
	internal Unity.Services.Core.Scheduler.Internal.ActionScheduler ActionScheduler
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2DAAB6C", Offset = "0x2DA6B6C", VA = "0x2DAAB6C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2DAAB74", Offset = "0x2DA6B74", VA = "0x2DAAB74")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	internal Unity.Services.Core.Device.InstallationId InstallationId
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2DAAB7C", Offset = "0x2DA6B7C", VA = "0x2DAAB7C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2DAAB84", Offset = "0x2DA6B84", VA = "0x2DAAB84")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	internal Unity.Services.Core.Configuration.ProjectConfiguration ProjectConfig
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2DAAB8C", Offset = "0x2DA6B8C", VA = "0x2DAAB8C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2DAAB94", Offset = "0x2DA6B94", VA = "0x2DAAB94")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	internal Unity.Services.Core.Environments.Internal.Environments Environments
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2DAAB9C", Offset = "0x2DA6B9C", VA = "0x2DAAB9C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2DAABA4", Offset = "0x2DA6BA4", VA = "0x2DAABA4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000005")]
	internal Unity.Services.Core.Configuration.ExternalUserId ExternalUserId
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2DAABAC", Offset = "0x2DA6BAC", VA = "0x2DAABAC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2DAABB4", Offset = "0x2DA6BB4", VA = "0x2DAABB4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000006")]
	internal ICloudProjectId CloudProjectId
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2DAABBC", Offset = "0x2DA6BBC", VA = "0x2DAABBC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2DAABC4", Offset = "0x2DA6BC4", VA = "0x2DAABC4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000007")]
	internal IDiagnosticsFactory DiagnosticsFactory
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2DAABCC", Offset = "0x2DA6BCC", VA = "0x2DAABCC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2DAABD4", Offset = "0x2DA6BD4", VA = "0x2DAABD4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000008")]
	internal IMetricsFactory MetricsFactory
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2DAABDC", Offset = "0x2DA6BDC", VA = "0x2DAABDC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2DAABE4", Offset = "0x2DA6BE4", VA = "0x2DAABE4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000009")]
	internal Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal UnityThreadUtils
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2DAABEC", Offset = "0x2DA6BEC", VA = "0x2DAABEC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2DAABF4", Offset = "0x2DA6BF4", VA = "0x2DAABF4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2DAABFC", Offset = "0x2DA6BFC", VA = "0x2DAABFC")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void InitializeOnLoad()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2DAACDC", Offset = "0x2DA6CDC", VA = "0x2DAACDC", Slot = "6")]
	public void Register(CorePackageRegistry registry)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2DAACB4", Offset = "0x2DA6CB4", VA = "0x2DAACB4")]
	public CorePackageInitializer(Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2DAAF04", Offset = "0x2DA6F04", VA = "0x2DAAF04", Slot = "5")]
	public Task Initialize(CoreRegistry registry)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2DAAFC8", Offset = "0x2DA6FC8", VA = "0x2DAAFC8", Slot = "4")]
	public Task InitializeInstanceAsync(CoreRegistry registry)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2DAAF0C", Offset = "0x2DA6F0C", VA = "0x2DAAF0C")]
	[AsyncStateMachine(typeof(<InitializeComponents>d__47))]
	private Task InitializeComponents()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2DAAFD0", Offset = "0x2DA6FD0", VA = "0x2DAAFD0")]
	private bool HaveInitOptionsChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2DAB044", Offset = "0x2DA7044", VA = "0x2DAB044")]
	private void FreeOptionsDependantComponents()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2DAB050", Offset = "0x2DA7050", VA = "0x2DAB050")]
	internal void InitializeInstallationId()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2DAB0C4", Offset = "0x2DA70C4", VA = "0x2DAB0C4")]
	internal void InitializeActionScheduler()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2DAB138", Offset = "0x2DA7138", VA = "0x2DAB138")]
	[AsyncStateMachine(typeof(<InitializeProjectConfigAsync>d__52))]
	internal Task InitializeProjectConfigAsync([NotNull] InitializationOptions options)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2DAB208", Offset = "0x2DA7208", VA = "0x2DAB208")]
	[AsyncStateMachine(typeof(<GenerateProjectConfigurationAsync>d__53))]
	internal Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync([NotNull] InitializationOptions options)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2DAB300", Offset = "0x2DA7300", VA = "0x2DAB300")]
	[AsyncStateMachine(typeof(<GetSerializedConfigOrEmptyAsync>d__54))]
	internal static Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync()
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2DAB3E0", Offset = "0x2DA73E0", VA = "0x2DAB3E0")]
	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2DAB53C", Offset = "0x2DA753C", VA = "0x2DAB53C")]
	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2DAB664", Offset = "0x2DA7664", VA = "0x2DAB664")]
	internal void InitializeMetrics()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2DAB6C4", Offset = "0x2DA76C4", VA = "0x2DAB6C4")]
	internal void InitializeDiagnostics()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2DAB724", Offset = "0x2DA7724", VA = "0x2DAB724")]
	internal void InitializeCloudProjectId([Optional] ICloudProjectId cloudProjectId)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2DAB78C", Offset = "0x2DA778C", VA = "0x2DAB78C")]
	internal void InitializeUnityThreadUtils()
	{
	}
}
