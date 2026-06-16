using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core.Internal;
using Unity.Services.Core.Telemetry.Internal;
using UnityEngine;
using UnityEngine.Networking;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Services.Authentication.Server.Internal
{
	[Token(Token = "0x2000002")]
	public interface IServerEnvironmentId : IEnvironmentId, IServiceComponent
	{
	}
}
namespace Unity.Services.Authentication.Internal
{
	[Token(Token = "0x2000003")]
	public interface IEnvironmentId : IServiceComponent
	{
	}
	[Token(Token = "0x2000004")]
	public interface IPlayerId : IServiceComponent
	{
		[Token(Token = "0x17000001")]
		string PlayerId
		{
			[Token(Token = "0x6000001")]
			get;
		}
	}
}
namespace Unity.Services.Core.Threading.Internal
{
	[Token(Token = "0x2000005")]
	public interface IUnityThreadUtils : IServiceComponent
	{
	}
}
namespace Unity.Services.Core.Telemetry.Internal
{
	[Token(Token = "0x2000006")]
	public interface IDiagnostics
	{
		[Token(Token = "0x6000002")]
		void SendDiagnostic(string name, string message, [Optional] IDictionary<string, string> tags);
	}
	[Token(Token = "0x2000007")]
	internal interface IDiagnosticsComponentProvider
	{
	}
	[Token(Token = "0x2000008")]
	public interface IDiagnosticsFactory : IServiceComponent
	{
		[Token(Token = "0x6000003")]
		IDiagnostics Create(string packageName);
	}
	[Token(Token = "0x2000009")]
	public interface IMetrics
	{
		[Token(Token = "0x6000004")]
		void SendGaugeMetric(string name, double value = 0.0, [Optional] IDictionary<string, string> tags);

		[Token(Token = "0x6000005")]
		void SendHistogramMetric(string name, double time, [Optional] IDictionary<string, string> tags);

		[Token(Token = "0x6000006")]
		void SendSumMetric(string name, double value = 1.0, [Optional] IDictionary<string, string> tags);
	}
	[Token(Token = "0x200000A")]
	public interface IMetricsFactory : IServiceComponent
	{
		[Token(Token = "0x6000007")]
		IMetrics Create(string packageName);
	}
}
namespace Unity.Services.Core.Scheduler.Internal
{
	[Token(Token = "0x200000B")]
	public interface IActionScheduler : IServiceComponent
	{
	}
}
namespace Unity.Services.Core.Environments.Internal
{
	[Token(Token = "0x200000C")]
	public interface IEnvironments : IServiceComponent
	{
		[Token(Token = "0x17000002")]
		string Current
		{
			[Token(Token = "0x6000008")]
			get;
		}
	}
}
namespace Unity.Services.Core.Device.Internal
{
	[Token(Token = "0x200000D")]
	public interface IInstallationId : IServiceComponent
	{
		[Token(Token = "0x6000009")]
		string GetOrCreateIdentifier();
	}
}
namespace Unity.Services.Core.Configuration.Internal
{
	[Token(Token = "0x200000E")]
	public interface ICloudProjectId : IServiceComponent
	{
		[Token(Token = "0x600000A")]
		string GetCloudProjectId();
	}
	[Token(Token = "0x200000F")]
	public interface IExternalUserId : IServiceComponent
	{
		[Token(Token = "0x17000003")]
		string UserId
		{
			[Token(Token = "0x600000B")]
			get;
		}

		[Token(Token = "0x14000001")]
		event Action<string> UserIdChanged;
	}
	[Token(Token = "0x2000010")]
	public interface IProjectConfiguration : IServiceComponent
	{
		[Token(Token = "0x600000E")]
		string GetString(string key, [Optional] string defaultValue);
	}
}
namespace Unity.Services.Core.Analytics.Internal
{
	[Token(Token = "0x2000011")]
	public interface IAnalyticsStandardEventComponent : IServiceComponent
	{
		[Token(Token = "0x600000F")]
		void Record(string eventName, IDictionary<string, object> eventParameters, int eventVersion, string packageName);
	}
	[Token(Token = "0x2000012")]
	public interface IAnalyticsUserId : IServiceComponent
	{
	}
}
namespace Unity.Services.Core.Internal
{
	[Token(Token = "0x2000013")]
	internal abstract class AsyncOperationBase : CustomYieldInstruction
	{
		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2DA3F04", Offset = "0x2D9FF04", VA = "0x2DA3F04", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000005")]
		public abstract bool IsCompleted
		{
			[Token(Token = "0x6000011")]
			get;
		}
	}
	[Token(Token = "0x2000014")]
	internal class TaskAsyncOperation : AsyncOperationBase
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static TaskScheduler Scheduler;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Task m_Task;

		[Token(Token = "0x17000006")]
		public override bool IsCompleted
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2DA3F24", Offset = "0x2D9FF24", VA = "0x2DA3F24", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2DA3F3C", Offset = "0x2D9FF3C", VA = "0x2DA3F3C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		internal static void SetScheduler()
		{
		}
	}
	[Token(Token = "0x2000015")]
	internal static class CoreLogger
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2DA3FB0", Offset = "0x2D9FFB0", VA = "0x2DA3FB0")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2DA40D0", Offset = "0x2DA00D0", VA = "0x2DA40D0")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2DA41F0", Offset = "0x2DA01F0", VA = "0x2DA41F0")]
		public static void LogException(Exception exception)
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class CircularDependencyException : ServicesInitializationException
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2DA4314", Offset = "0x2DA0314", VA = "0x2DA4314")]
		public CircularDependencyException()
		{
		}
	}
	[Token(Token = "0x2000017")]
	internal class ComponentRegistry : IComponentRegistry
	{
		[Token(Token = "0x17000007")]
		[NotNull]
		internal Dictionary<int, IServiceComponent> ComponentTypeHashToInstance
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2DA431C", Offset = "0x2DA031C", VA = "0x2DA431C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2DA4324", Offset = "0x2DA0324", VA = "0x2DA4324")]
		public ComponentRegistry()
		{
		}

		[Token(Token = "0x600001A")]
		public void RegisterServiceComponent<TComponent>(TComponent component) where TComponent : IServiceComponent
		{
		}

		[Token(Token = "0x600001B")]
		public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
		{
			return (TComponent)null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2DA43A4", Offset = "0x2DA03A4", VA = "0x2DA43A4")]
		private bool IsComponentTypeRegistered(int componentTypeHash)
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2DA446C", Offset = "0x2DA046C", VA = "0x2DA446C", Slot = "6")]
		public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance)
		{
		}
	}
	[Token(Token = "0x2000018")]
	internal interface IComponentRegistry
	{
		[Token(Token = "0x600001E")]
		void RegisterServiceComponent<TComponent>([NotNull] TComponent component) where TComponent : IServiceComponent;

		[Token(Token = "0x600001F")]
		TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent;

		[Token(Token = "0x6000020")]
		void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance);
	}
	[Token(Token = "0x2000019")]
	internal class LockedComponentRegistry : IComponentRegistry
	{
		[Token(Token = "0x17000008")]
		[NotNull]
		internal IComponentRegistry Registry
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2DA44E4", Offset = "0x2DA04E4", VA = "0x2DA44E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2DA44EC", Offset = "0x2DA04EC", VA = "0x2DA44EC")]
		public LockedComponentRegistry([NotNull] IComponentRegistry registryToLock)
		{
		}

		[Token(Token = "0x6000023")]
		public void RegisterServiceComponent<TComponent>(TComponent component) where TComponent : IServiceComponent
		{
		}

		[Token(Token = "0x6000024")]
		public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
		{
			return (TComponent)null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2DA4514", Offset = "0x2DA0514", VA = "0x2DA4514", Slot = "6")]
		public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public sealed class CorePackageRegistry
	{
		[Token(Token = "0x17000009")]
		public static CorePackageRegistry Instance
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2DA4560", Offset = "0x2DA0560", VA = "0x2DA4560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2DA45A8", Offset = "0x2DA05A8", VA = "0x2DA45A8")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		internal IPackageRegistry Registry
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2DA45F4", Offset = "0x2DA05F4", VA = "0x2DA45F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2DA45FC", Offset = "0x2DA05FC", VA = "0x2DA45FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2DA4604", Offset = "0x2DA0604", VA = "0x2DA4604")]
		internal CorePackageRegistry()
		{
		}

		[Token(Token = "0x600002B")]
		public CoreRegistration Register<TPackage>([NotNull] TPackage package) where TPackage : IInitializablePackage
		{
			return default(CoreRegistration);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2DA4810", Offset = "0x2DA0810", VA = "0x2DA4810")]
		internal void Lock()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public readonly struct CoreRegistration
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IPackageRegistry m_Registry;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly int m_PackageHash;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2DA48C4", Offset = "0x2DA08C4", VA = "0x2DA48C4")]
		internal CoreRegistration(IPackageRegistry registry, int packageHash)
		{
		}

		[Token(Token = "0x600002E")]
		public CoreRegistration DependsOn<T>() where T : IServiceComponent
		{
			return default(CoreRegistration);
		}

		[Token(Token = "0x600002F")]
		public CoreRegistration OptionallyDependsOn<T>() where T : IServiceComponent
		{
			return default(CoreRegistration);
		}

		[Token(Token = "0x6000030")]
		public CoreRegistration ProvidesComponent<T>() where T : IServiceComponent
		{
			return default(CoreRegistration);
		}
	}
	[Token(Token = "0x200001C")]
	public sealed class CoreRegistry
	{
		[Token(Token = "0x1700000B")]
		public static CoreRegistry Instance
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2DA48D0", Offset = "0x2DA08D0", VA = "0x2DA48D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2DA4918", Offset = "0x2DA0918", VA = "0x2DA4918")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		internal ServicesType Type
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2DA4964", Offset = "0x2DA0964", VA = "0x2DA4964")]
			[CompilerGenerated]
			get
			{
				return default(ServicesType);
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2DA496C", Offset = "0x2DA096C", VA = "0x2DA496C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		internal InitializationOptions Options
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2DA4974", Offset = "0x2DA0974", VA = "0x2DA4974")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2DA497C", Offset = "0x2DA097C", VA = "0x2DA497C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		[NotNull]
		internal IPackageRegistry PackageRegistry
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2DA4984", Offset = "0x2DA0984", VA = "0x2DA4984")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2DA498C", Offset = "0x2DA098C", VA = "0x2DA498C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		[NotNull]
		internal IComponentRegistry ComponentRegistry
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2DA4994", Offset = "0x2DA0994", VA = "0x2DA4994")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2DA499C", Offset = "0x2DA099C", VA = "0x2DA499C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		[NotNull]
		private IServiceRegistry ServiceRegistry
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2DA49A4", Offset = "0x2DA09A4", VA = "0x2DA49A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2DA49AC", Offset = "0x2DA09AC", VA = "0x2DA49AC")]
		internal CoreRegistry(IPackageRegistry packageRegistry, ServicesType type = ServicesType.Default, [Optional] string instanceId)
		{
		}

		[Token(Token = "0x600003D")]
		public CoreRegistration RegisterPackage<TPackage>([NotNull] TPackage package) where TPackage : IInitializablePackage
		{
			return default(CoreRegistration);
		}

		[Token(Token = "0x600003E")]
		public void RegisterServiceComponent<TComponent>([NotNull] TComponent component) where TComponent : IServiceComponent
		{
		}

		[Token(Token = "0x600003F")]
		public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
		{
			return (TComponent)null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2DA4ADC", Offset = "0x2DA0ADC", VA = "0x2DA4ADC")]
		internal void LockComponentRegistration()
		{
		}
	}
	[Token(Token = "0x200001D")]
	internal class CoreRegistryInitializer
	{
		[Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Stopwatch stopwatch;

			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<PackageInitializationInfo> packagesInitInfos;

			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<Exception> failureReasons;

			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CoreRegistryInitializer <>4__this;

			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public DependencyTree dependencyTree;

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2DA4C80", Offset = "0x2DA0C80", VA = "0x2DA4C80")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <InitializeRegistryAsync>d__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<List<PackageInitializationInfo>> <>t__builder;

			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoreRegistryInitializer <>4__this;

			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass3_0 <>8__1;

			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <i>5__2;

			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2DA5820", Offset = "0x2DA1820", VA = "0x2DA5820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2DA5E3C", Offset = "0x2DA1E3C", VA = "0x2DA5E3C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NotNull]
		private readonly CoreRegistry m_Registry;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NotNull]
		private readonly List<int> m_SortedPackageTypeHashes;

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2DA4B68", Offset = "0x2DA0B68", VA = "0x2DA4B68")]
		public CoreRegistryInitializer([NotNull] CoreRegistry registry, [NotNull] List<int> sortedPackageTypeHashes)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2DA4B94", Offset = "0x2DA0B94", VA = "0x2DA4B94")]
		[AsyncStateMachine(typeof(<InitializeRegistryAsync>d__3))]
		public Task<List<PackageInitializationInfo>> InitializeRegistryAsync()
		{
			return null;
		}
	}
	[Token(Token = "0x2000022")]
	internal class DependencyTree
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Dictionary<int, IInitializablePackage> PackageTypeHashToInstance;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Dictionary<int, int> ComponentTypeHashToPackageTypeHash;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Dictionary<int, List<int>> PackageTypeHashToComponentTypeHashDependencies;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Dictionary<int, IServiceComponent> ComponentTypeHashToInstance;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2DA4698", Offset = "0x2DA0698", VA = "0x2DA4698")]
		internal DependencyTree()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2DA5EB8", Offset = "0x2DA1EB8", VA = "0x2DA5EB8")]
		internal DependencyTree(Dictionary<int, IInitializablePackage> packageToInstance, Dictionary<int, int> componentToPackage, Dictionary<int, List<int>> packageToComponentDependencies, Dictionary<int, IServiceComponent> componentToInstance)
		{
		}
	}
	[Token(Token = "0x2000023")]
	internal class DependencyTreeSortFailedException : Exception
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2DA5EF8", Offset = "0x2DA1EF8", VA = "0x2DA5EF8")]
		public DependencyTreeSortFailedException(DependencyTree tree, ICollection<int> target, Exception inner)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2DA5F8C", Offset = "0x2DA1F8C", VA = "0x2DA5F8C")]
		private static string CreateExceptionMessage(DependencyTree tree, ICollection<int> target, [Optional] Exception inner)
		{
			return null;
		}
	}
	[Token(Token = "0x2000024")]
	internal static class DependencyTreeExtensions
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2DA606C", Offset = "0x2DA206C", VA = "0x2DA606C")]
		internal static string ToJson(this DependencyTree tree, [Optional] ICollection<int> order)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2DA7210", Offset = "0x2DA3210", VA = "0x2DA7210")]
		internal static bool IsOptional(this DependencyTree tree, int componentTypeHash)
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2DA7290", Offset = "0x2DA3290", VA = "0x2DA7290")]
		internal static bool IsProvided(this DependencyTree tree, int componentTypeHash)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2DA67B0", Offset = "0x2DA27B0", VA = "0x2DA67B0")]
		private static JObject GetPackageJObject(DependencyTree tree, int packageHash)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2DA6EB0", Offset = "0x2DA2EB0", VA = "0x2DA6EB0")]
		private static JObject GetComponentJObject(DependencyTree tree, int componentHash)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2DA72EC", Offset = "0x2DA32EC", VA = "0x2DA72EC")]
		private static string GetComponentIdentifier(IServiceComponent component)
		{
			return null;
		}
	}
	[Token(Token = "0x2000025")]
	internal struct DependencyTreeInitializeOrderSorter
	{
		[Token(Token = "0x2000026")]
		private enum ExplorationMark
		{
			[Token(Token = "0x400002F")]
			None,
			[Token(Token = "0x4000030")]
			Viewed,
			[Token(Token = "0x4000031")]
			Sorted
		}

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly DependencyTree Tree;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly ICollection<int> Target;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<int, ExplorationMark> m_PackageTypeHashExplorationHistory;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2DA73A4", Offset = "0x2DA33A4", VA = "0x2DA73A4")]
		public DependencyTreeInitializeOrderSorter(DependencyTree tree, ICollection<int> target)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2DA73B0", Offset = "0x2DA33B0", VA = "0x2DA73B0")]
		public void SortRegisteredPackagesIntoTarget()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2DA7850", Offset = "0x2DA3850", VA = "0x2DA7850")]
		private void RemoveUnprovidedOptionalDependenciesFromTree()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2DA7CE4", Offset = "0x2DA3CE4", VA = "0x2DA7CE4")]
		private void RemoveUnprovidedOptionalDependencies(IList<int> dependencyTypeHashes)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2DA79FC", Offset = "0x2DA39FC", VA = "0x2DA79FC")]
		private void SortTreeThrough(int packageTypeHash)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2DA7FF0", Offset = "0x2DA3FF0", VA = "0x2DA7FF0")]
		private void SortTreeThrough(IEnumerable<int> dependencyTypeHashes)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2DA7E9C", Offset = "0x2DA3E9C", VA = "0x2DA7E9C")]
		private void MarkPackage(int packageTypeHash, ExplorationMark mark)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2DA79A4", Offset = "0x2DA39A4", VA = "0x2DA79A4")]
		private IReadOnlyCollection<int> GetPackageTypeHashes()
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2DA82A0", Offset = "0x2DA42A0", VA = "0x2DA82A0")]
		private int GetPackageTypeHashFor(int componentTypeHash)
		{
			return default(int);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2DA7F04", Offset = "0x2DA3F04", VA = "0x2DA7F04")]
		private IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash)
		{
			return null;
		}
	}
	[Token(Token = "0x2000027")]
	internal class HashException : Exception
	{
		[Token(Token = "0x17000011")]
		public int Hash
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x2DA8394", Offset = "0x2DA4394", VA = "0x2DA8394")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2DA839C", Offset = "0x2DA439C", VA = "0x2DA839C")]
		public HashException(int hash, string message)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2DA8408", Offset = "0x2DA4408", VA = "0x2DA8408")]
		public HashException(int hash, string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000028")]
	internal class DependencyTreePackageHashException : HashException
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2DA8390", Offset = "0x2DA4390", VA = "0x2DA8390")]
		public DependencyTreePackageHashException(int hash, string message)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2DA829C", Offset = "0x2DA429C", VA = "0x2DA829C")]
		public DependencyTreePackageHashException(int hash, string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000029")]
	internal class DependencyTreeComponentHashException : HashException
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2DA838C", Offset = "0x2DA438C", VA = "0x2DA838C")]
		public DependencyTreeComponentHashException(int hash, string message)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public interface IInitializablePackage
	{
		[Token(Token = "0x6000068")]
		Task Initialize(CoreRegistry registry);
	}
	[Token(Token = "0x200002B")]
	public interface IInitializablePackageV2 : IInitializablePackage
	{
		[Token(Token = "0x6000069")]
		Task InitializeInstanceAsync(CoreRegistry registry);
	}
	[Token(Token = "0x200002C")]
	public interface IServiceComponent
	{
	}
	[Token(Token = "0x200002D")]
	internal class MissingComponent : IServiceComponent
	{
		[Token(Token = "0x17000012")]
		public Type IntendedType
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x2DA848C", Offset = "0x2DA448C", VA = "0x2DA848C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2DA8494", Offset = "0x2DA4494", VA = "0x2DA8494")]
		internal MissingComponent(Type intendedType)
		{
		}
	}
	[Token(Token = "0x200002E")]
	internal class PackageInitializationInfo
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type PackageType;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double InitializationTimeInSeconds;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2DA57B0", Offset = "0x2DA17B0", VA = "0x2DA57B0")]
		public PackageInitializationInfo()
		{
		}
	}
	[Token(Token = "0x200002F")]
	internal interface IPackageRegistry
	{
		[Token(Token = "0x17000013")]
		[CanBeNull]
		DependencyTree Tree
		{
			[Token(Token = "0x600006D")]
			get;
		}

		[Token(Token = "0x600006E")]
		CoreRegistration RegisterPackage<TPackage>([NotNull] TPackage package) where TPackage : IInitializablePackage;

		[Token(Token = "0x600006F")]
		void RegisterDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent;

		[Token(Token = "0x6000070")]
		void RegisterOptionalDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent;

		[Token(Token = "0x6000071")]
		void RegisterProvision<TComponent>(int packageTypeHash) where TComponent : IServiceComponent;
	}
	[Token(Token = "0x2000030")]
	internal class LockedPackageRegistry : IPackageRegistry
	{
		[Token(Token = "0x17000014")]
		[NotNull]
		internal IPackageRegistry Registry
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2DA84BC", Offset = "0x2DA44BC", VA = "0x2DA84BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public DependencyTree Tree
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2DA84C4", Offset = "0x2DA44C4", VA = "0x2DA84C4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2DA489C", Offset = "0x2DA089C", VA = "0x2DA489C")]
		public LockedPackageRegistry([NotNull] IPackageRegistry registryToLock)
		{
		}

		[Token(Token = "0x6000075")]
		public CoreRegistration RegisterPackage<TPackage>(TPackage package) where TPackage : IInitializablePackage
		{
			return default(CoreRegistration);
		}

		[Token(Token = "0x6000076")]
		public void RegisterDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
		}

		[Token(Token = "0x6000077")]
		public void RegisterOptionalDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
		}

		[Token(Token = "0x6000078")]
		public void RegisterProvision<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
		}
	}
	[Token(Token = "0x2000031")]
	internal class PackageRegistry : IPackageRegistry
	{
		[Token(Token = "0x17000016")]
		public DependencyTree Tree
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x2DA8564", Offset = "0x2DA4564", VA = "0x2DA8564", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x2DA856C", Offset = "0x2DA456C", VA = "0x2DA856C", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2DA47E8", Offset = "0x2DA07E8", VA = "0x2DA47E8")]
		public PackageRegistry([CanBeNull] DependencyTree tree)
		{
		}

		[Token(Token = "0x600007C")]
		public CoreRegistration RegisterPackage<TPackage>(TPackage package) where TPackage : IInitializablePackage
		{
			return default(CoreRegistration);
		}

		[Token(Token = "0x600007D")]
		public void RegisterDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
		}

		[Token(Token = "0x600007E")]
		public void RegisterOptionalDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
		}

		[Token(Token = "0x600007F")]
		public void RegisterProvision<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2DA8574", Offset = "0x2DA4574", VA = "0x2DA8574")]
		private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash)
		{
		}
	}
	[Token(Token = "0x2000032")]
	internal interface IServiceRegistry
	{
	}
	[Token(Token = "0x2000033")]
	internal class ServiceRegistry : IServiceRegistry
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2DA4A5C", Offset = "0x2DA0A5C", VA = "0x2DA4A5C")]
		public ServiceRegistry()
		{
		}
	}
	[Token(Token = "0x2000034")]
	internal enum ServicesType
	{
		[Token(Token = "0x400003A")]
		Default,
		[Token(Token = "0x400003B")]
		Instance
	}
	[Token(Token = "0x2000035")]
	internal class CoreDiagnostics
	{
		[Token(Token = "0x17000017")]
		public static CoreDiagnostics Instance
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2DA8680", Offset = "0x2DA4680", VA = "0x2DA8680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2DA86C8", Offset = "0x2DA46C8", VA = "0x2DA86C8")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000018")]
		internal IDiagnosticsComponentProvider DiagnosticsComponentProvider
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2DA8714", Offset = "0x2DA4714", VA = "0x2DA8714")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2DA871C", Offset = "0x2DA471C", VA = "0x2DA871C")]
		public CoreDiagnostics()
		{
		}
	}
	[Token(Token = "0x2000036")]
	internal class CoreMetrics
	{
		[Token(Token = "0x17000019")]
		public static CoreMetrics Instance
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x2DA8798", Offset = "0x2DA4798", VA = "0x2DA8798")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2DA87E0", Offset = "0x2DA47E0", VA = "0x2DA87E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2DA882C", Offset = "0x2DA482C", VA = "0x2DA882C")]
		public CoreMetrics()
		{
		}
	}
	[Token(Token = "0x2000037")]
	internal static class UnityServicesInitializer
	{
		[StructLayout(3)]
		[Token(Token = "0x2000038")]
		[CompilerGenerated]
		private struct <EnableServicesInitializationAsync>d__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2DA8DC4", Offset = "0x2DA4DC4", VA = "0x2DA8DC4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600008D")]
			[Address(RVA = "0x2DA90A0", Offset = "0x2DA50A0", VA = "0x2DA90A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2DA88A8", Offset = "0x2DA48A8", VA = "0x2DA88A8")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void CreateStaticInstance()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2DA8BEC", Offset = "0x2DA4BEC", VA = "0x2DA8BEC")]
		[AsyncStateMachine(typeof(<EnableServicesInitializationAsync>d__1))]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void EnableServicesInitializationAsync()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2DA8C70", Offset = "0x2DA4C70", VA = "0x2DA8C70")]
		internal static IUnityServices CreateInstance(string servicesId)
		{
			return null;
		}
	}
	[Token(Token = "0x2000039")]
	internal class UnityServicesInternal : IUnityServices
	{
		[Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DependencyTree dependencyTree;

			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<int> sortedPackageTypeHashes;

			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityServicesInternal <>4__this;

			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Stopwatch initStopwatch;

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2DA9490", Offset = "0x2DA5490", VA = "0x2DA9490")]
			public <>c__DisplayClass33_0()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <EnableInitializationAsync>d__36 : IAsyncStateMachine
		{
			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityServicesInternal <>4__this;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x2DA9944", Offset = "0x2DA5944", VA = "0x2DA9944", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2DA9B68", Offset = "0x2DA5B68", VA = "0x2DA9B68", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct <InitializeAsync>d__27 : IAsyncStateMachine
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InitializationOptions options;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityServicesInternal <>4__this;

			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<object> <>u__1;

			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__2;

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x2DA9BD0", Offset = "0x2DA5BD0", VA = "0x2DA9BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x2DAA048", Offset = "0x2DA6048", VA = "0x2DAA048", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct <InitializeServicesAsync>d__33 : IAsyncStateMachine
		{
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityServicesInternal <>4__this;

			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass33_0 <>8__1;

			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2DAA0B0", Offset = "0x2DA60B0", VA = "0x2DAA0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x2DAA5CC", Offset = "0x2DA65CC", VA = "0x2DAA5CC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		private Action Initialized;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[CompilerGenerated]
		private Action<Exception> InitializeFailed;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool CanInitialize;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskCompletionSource<object> m_Initialization;

		[Token(Token = "0x1700001A")]
		public ServicesInitializationState State
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x2DA90AC", Offset = "0x2DA50AC", VA = "0x2DA90AC", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(ServicesInitializationState);
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x2DA90B4", Offset = "0x2DA50B4", VA = "0x2DA90B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		[NotNull]
		internal CoreRegistry Registry
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x2DA90BC", Offset = "0x2DA50BC", VA = "0x2DA90BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2DA8BB0", Offset = "0x2DA4BB0", VA = "0x2DA8BB0")]
		public UnityServicesInternal([NotNull] CoreRegistry registry, [NotNull] CoreMetrics coreMetrics, [NotNull] CoreDiagnostics coreDiagnostics)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2DA90C4", Offset = "0x2DA50C4", VA = "0x2DA90C4", Slot = "4")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__27))]
		public Task InitializeAsync(InitializationOptions options)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2DA9190", Offset = "0x2DA5190", VA = "0x2DA9190")]
		private void TriggerInitializeSuccess()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2DA9268", Offset = "0x2DA5268", VA = "0x2DA9268")]
		private void TriggerInitializeFailed(Exception initException)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2DA9340", Offset = "0x2DA5340", VA = "0x2DA9340")]
		private bool HasRequestedInitialization()
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2DA9350", Offset = "0x2DA5350", VA = "0x2DA9350")]
		[AsyncStateMachine(typeof(<InitializeServicesAsync>d__33))]
		private Task InitializeServicesAsync()
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2DA8DB8", Offset = "0x2DA4DB8", VA = "0x2DA8DB8")]
		internal void EnableInitialization()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2DA8FE4", Offset = "0x2DA4FE4", VA = "0x2DA8FE4")]
		[AsyncStateMachine(typeof(<EnableInitializationAsync>d__36))]
		internal Task EnableInitializationAsync()
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	internal static class DictionaryExtensions
	{
		[Token(Token = "0x60000A7")]
		public static TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(this TDictionary self, [NotNull] IDictionary<TKey, TValue> dictionary) where TDictionary : IDictionary<TKey, TValue>
		{
			return (TDictionary)null;
		}

		[Token(Token = "0x60000A8")]
		public static bool ValueEquals<TKey, TValue>(this IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		public static bool ValueEquals<TKey, TValue, TComparer>(this IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y, TComparer valueComparer) where TComparer : IEqualityComparer<TValue>
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000040")]
	internal static class UnityWebRequestUtils
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2DAA634", Offset = "0x2DA6634", VA = "0x2DAA634")]
		public static bool HasSucceeded(this UnityWebRequest self)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2DAA658", Offset = "0x2DA6658", VA = "0x2DAA658")]
		public static Task<string> GetTextAsync(string uri)
		{
			return null;
		}
	}
}
namespace Unity.Services.Core.Internal.Serialization
{
	[Token(Token = "0x2000042")]
	internal interface IJsonSerializer
	{
		[Token(Token = "0x60000AE")]
		T DeserializeObject<T>(string value);
	}
	[Token(Token = "0x2000043")]
	internal class NewtonsoftSerializer : IJsonSerializer
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly JsonSerializer m_Serializer;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2DAAB0C", Offset = "0x2DA6B0C", VA = "0x2DAAB0C")]
		public NewtonsoftSerializer([Optional] JsonSerializerSettings settings)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2DAAB44", Offset = "0x2DA6B44", VA = "0x2DAAB44")]
		internal NewtonsoftSerializer(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60000B1")]
		public T DeserializeObject<T>(string value)
		{
			return (T)null;
		}
	}
}
