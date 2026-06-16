using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Unity.Services.Analytics.Data;
using Unity.Services.Analytics.Internal;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core.Analytics.Internal;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device.Internal;
using Unity.Services.Core.Internal;
using UnityEngine;
using UnityEngine.Networking;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
internal class Ua2CoreInitializeCallback : IInitializablePackage
{
	[StructLayout(3)]
	[Token(Token = "0x2000003")]
	[CompilerGenerated]
	private struct <Initialize>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoreRegistry registry;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2D936DC", Offset = "0x2D8F6DC", VA = "0x2D936DC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2D941C8", Offset = "0x2D901C8", VA = "0x2D941C8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2D93430", Offset = "0x2D8F430", VA = "0x2D93430")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Register()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2D93620", Offset = "0x2D8F620", VA = "0x2D93620", Slot = "4")]
	[AsyncStateMachine(typeof(<Initialize>d__1))]
	public Task Initialize(CoreRegistry registry)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2D93618", Offset = "0x2D8F618", VA = "0x2D93618")]
	public Ua2CoreInitializeCallback()
	{
	}
}
namespace Unity.Services.Analytics
{
	[Token(Token = "0x2000004")]
	public static class AnalyticsService
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AnalyticsServiceInstance m_Instance;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IDispatcherDebug m_DispatcherDebug;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IBufferDebug m_BufferDebug;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Action<string, string, DateTime, byte[]> m_EventRecordedCallback;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Action<HashSet<string>> m_EventsClearingCallback;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Action<byte[]> m_FlushStartedCallback;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Action<int, bool, bool, bool, bool, byte[]> m_FlushCompletedCallback;

		[Token(Token = "0x17000001")]
		public static IAnalyticsService Instance
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2D95924", Offset = "0x2D91924", VA = "0x2D95924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2D93900", Offset = "0x2D8F900", VA = "0x2D93900")]
		internal static void Initialize(CoreRegistry registry)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2D956C8", Offset = "0x2D916C8", VA = "0x2D956C8")]
		internal static void TearDown()
		{
		}
	}
	[Token(Token = "0x2000005")]
	internal interface IAnalyticsServiceSystemCalls
	{
		[Token(Token = "0x17000002")]
		DateTime UtcNow
		{
			[Token(Token = "0x6000009")]
			get;
		}
	}
	[Token(Token = "0x2000006")]
	internal class AnalyticsServiceSystemCalls : IAnalyticsServiceSystemCalls
	{
		[Token(Token = "0x17000003")]
		public DateTime UtcNow
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2D959B8", Offset = "0x2D919B8", VA = "0x2D959B8", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2D95370", Offset = "0x2D91370", VA = "0x2D95370")]
		public AnalyticsServiceSystemCalls()
		{
		}
	}
	[Token(Token = "0x2000007")]
	internal interface IUnstructuredEventRecorder
	{
		[Token(Token = "0x600000C")]
		void CustomData(string eventName, IDictionary<string, object> eventParams, int? eventVersion, bool isStandardEvent, string callingMethodIdentifier);
	}
	[Token(Token = "0x2000008")]
	internal class AnalyticsServiceInstance : IAnalyticsService, IUnstructuredEventRecorder
	{
		[Token(Token = "0x400000C")]
		private const string k_ForgetCallingId = "com.unity.services.analytics.Events.RequestDataDeletion";

		[Token(Token = "0x400000D")]
		private const string k_StartUpCallingId = "com.unity.services.analytics.Events.Startup";

		[Token(Token = "0x400000E")]
		private const string k_PlayerChangedCallingId = "com.unity.services.analytics.Events.PlayerChanged";

		[Token(Token = "0x400000F")]
		internal const string k_InvokedByUserCallingId = "com.unity.services.analytics.Events.UserInvoked";

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TimeSpan k_BackgroundSessionRefreshPeriod;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly TransactionCurrencyConverter converter;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IIdentityManager m_UserIdentity;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ISessionManager m_Session;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IDataGenerator m_DataGenerator;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly ICoreStatsHelper m_CoreStatsHelper;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly IDispatcher m_DataDispatcher;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly IAnalyticsForgetter m_AnalyticsForgetter;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly IAnalyticsServiceSystemCalls m_SystemCalls;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly IAnalyticsContainer m_Container;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal IBuffer m_DataBuffer;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_BufferLengthAtLastGameRunning;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DateTime m_ApplicationPauseTime;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_IsActive;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool m_StartUpEventsRecorded;

		[Token(Token = "0x17000004")]
		internal int AutoflushPeriodMultiplier
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2D98228", Offset = "0x2D94228", VA = "0x2D98228")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2D95378", Offset = "0x2D91378", VA = "0x2D95378")]
		internal AnalyticsServiceInstance(IDataGenerator dataGenerator, IBuffer realBuffer, ICoreStatsHelper coreStatsHelper, IDispatcher dispatcher, IAnalyticsForgetter forgetter, IIdentityManager userIdentity, string environment, IAnalyticsServiceSystemCalls systemCalls, IAnalyticsContainer container, ISessionManager session)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2D955BC", Offset = "0x2D915BC", VA = "0x2D955BC")]
		internal void ResumeDataDeletionIfNecessary()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2D9753C", Offset = "0x2D9353C", VA = "0x2D9753C")]
		internal void DeactivateWithDataDeletionRequest()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2D97B94", Offset = "0x2D93B94", VA = "0x2D97B94")]
		private void DataDeletionCompleted()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2D979F4", Offset = "0x2D939F4", VA = "0x2D979F4")]
		private void Deactivate()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2D97C4C", Offset = "0x2D93C4C", VA = "0x2D97C4C")]
		private void RecordStartupEvents(string callingId)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2D97ED4", Offset = "0x2D93ED4", VA = "0x2D97ED4")]
		private void PlayerChanged()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2D9802C", Offset = "0x2D9402C", VA = "0x2D9802C")]
		internal void ApplicationPaused(bool paused)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2D982E8", Offset = "0x2D942E8", VA = "0x2D982E8", Slot = "6")]
		public void Flush()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2D98428", Offset = "0x2D94428", VA = "0x2D98428")]
		internal void ApplicationQuit()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2D98578", Offset = "0x2D94578", VA = "0x2D98578")]
		internal void RecordGameRunningIfNecessary()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2D987D8", Offset = "0x2D947D8", VA = "0x2D987D8", Slot = "4")]
		public long ConvertCurrencyToMinorUnits(string currencyCode, double value)
		{
			return default(long);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2D98980", Offset = "0x2D94980", VA = "0x2D98980", Slot = "5")]
		public void CustomData(string eventName, IDictionary<string, object> eventParams, int? eventVersion, bool isStandardEvent, string callingMethodIdentifier)
		{
		}
	}
	[Token(Token = "0x2000009")]
	internal class TransactionCurrencyConverter
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, int> m_Iso4217CurrencyMinorUnits;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2D987EC", Offset = "0x2D947EC", VA = "0x2D987EC")]
		public long Convert(string currencyCode, double value)
		{
			return default(long);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2D95A08", Offset = "0x2D91A08", VA = "0x2D95A08")]
		public TransactionCurrencyConverter()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public enum TransactionServer
	{
		[Token(Token = "0x4000021")]
		APPLE,
		[Token(Token = "0x4000022")]
		AMAZON,
		[Token(Token = "0x4000023")]
		GOOGLE,
		[Token(Token = "0x4000024")]
		VALVE
	}
	[Token(Token = "0x200000B")]
	public enum TransactionType
	{
		[Token(Token = "0x4000026")]
		INVALID,
		[Token(Token = "0x4000027")]
		SALE,
		[Token(Token = "0x4000028")]
		PURCHASE,
		[Token(Token = "0x4000029")]
		TRADE
	}
	[Token(Token = "0x200000C")]
	public interface IAnalyticsService
	{
		[Token(Token = "0x600001D")]
		long ConvertCurrencyToMinorUnits(string currencyCode, double value);
	}
	[Token(Token = "0x200000D")]
	internal interface IAnalyticsContainer
	{
		[Token(Token = "0x600001E")]
		void Enable();

		[Token(Token = "0x600001F")]
		void Disable();
	}
	[Token(Token = "0x200000E")]
	internal class AnalyticsContainer : MonoBehaviour, IAnalyticsContainer, IContainerDebug
	{
		[Token(Token = "0x400002A")]
		private const float k_AutoFlushPeriod = 60f;

		[Token(Token = "0x400002B")]
		private const float k_GameRunningPeriod = 60f;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_Created;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GameObject s_Container;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static AnalyticsContainer m_Instance;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_AutoFlushTime;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_GameRunningTime;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnalyticsServiceInstance m_Service;

		[Token(Token = "0x17000005")]
		private float AutoFlushPeriod
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2D98EDC", Offset = "0x2D94EDC", VA = "0x2D98EDC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000006")]
		internal static IContainerDebug ContainerDebug
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2D98F08", Offset = "0x2D94F08", VA = "0x2D98F08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		public float TimeUntilNextHeartbeat
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2D98F50", Offset = "0x2D94F50", VA = "0x2D98F50", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2D94EFC", Offset = "0x2D90EFC", VA = "0x2D94EFC")]
		internal static AnalyticsContainer CreateContainer()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2D955A8", Offset = "0x2D915A8", VA = "0x2D955A8", Slot = "7")]
		public void Initialize(AnalyticsServiceInstance service)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2D98F6C", Offset = "0x2D94F6C", VA = "0x2D98F6C", Slot = "4")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2D98F78", Offset = "0x2D94F78", VA = "0x2D98F78", Slot = "5")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2D98F98", Offset = "0x2D94F98", VA = "0x2D98F98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2D9901C", Offset = "0x2D9501C", VA = "0x2D9901C")]
		private void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2D99034", Offset = "0x2D95034", VA = "0x2D99034")]
		private void CleanUp()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2D99124", Offset = "0x2D95124", VA = "0x2D99124")]
		public AnalyticsContainer()
		{
		}
	}
	[Token(Token = "0x200000F")]
	internal interface ICoreStatsHelper
	{
		[Token(Token = "0x600002B")]
		void SetCoreStatsConsent(bool userProvidedConsent);
	}
	[Token(Token = "0x2000010")]
	internal class CoreStatsHelper : ICoreStatsHelper
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2D9912C", Offset = "0x2D9512C", VA = "0x2D9912C", Slot = "4")]
		public void SetCoreStatsConsent(bool userProvidedConsent)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2D94230", Offset = "0x2D90230", VA = "0x2D94230")]
		public CoreStatsHelper()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public static class SdkVersion
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string SDK_VERSION;
	}
}
namespace Unity.Services.Analytics.Data
{
	[Token(Token = "0x2000012")]
	internal interface ICommonData
	{
		[Token(Token = "0x17000008")]
		string Version
		{
			[Token(Token = "0x600002F")]
			get;
		}

		[Token(Token = "0x17000009")]
		string GameBundleId
		{
			[Token(Token = "0x6000030")]
			get;
		}

		[Token(Token = "0x1700000A")]
		string ProjectId
		{
			[Token(Token = "0x6000031")]
			get;
		}

		[Token(Token = "0x1700000B")]
		string Platform
		{
			[Token(Token = "0x6000032")]
			get;
		}

		[Token(Token = "0x1700000C")]
		string BuildGUID
		{
			[Token(Token = "0x6000033")]
			get;
		}

		[Token(Token = "0x1700000D")]
		string Idfv
		{
			[Token(Token = "0x6000034")]
			get;
		}

		[Token(Token = "0x1700000E")]
		string GameStoreId
		{
			[Token(Token = "0x6000035")]
			get;
		}

		[Token(Token = "0x1700000F")]
		bool HasVolume
		{
			[Token(Token = "0x6000036")]
			get;
		}

		[Token(Token = "0x17000010")]
		float Volume
		{
			[Token(Token = "0x6000037")]
			get;
		}

		[Token(Token = "0x17000011")]
		double BatteryLevel
		{
			[Token(Token = "0x6000038")]
			get;
		}

		[Token(Token = "0x17000012")]
		string AnalyticsRegionLanguageCode
		{
			[Token(Token = "0x6000039")]
			get;
		}
	}
	[Token(Token = "0x2000013")]
	internal interface IDeviceData
	{
		[Token(Token = "0x17000013")]
		string CpuType
		{
			[Token(Token = "0x600003A")]
			get;
		}

		[Token(Token = "0x17000014")]
		string GpuType
		{
			[Token(Token = "0x600003B")]
			get;
		}

		[Token(Token = "0x17000015")]
		int CpuCores
		{
			[Token(Token = "0x600003C")]
			get;
		}

		[Token(Token = "0x17000016")]
		int RamTotal
		{
			[Token(Token = "0x600003D")]
			get;
		}

		[Token(Token = "0x17000017")]
		int ScreenWidth
		{
			[Token(Token = "0x600003E")]
			get;
		}

		[Token(Token = "0x17000018")]
		int ScreenHeight
		{
			[Token(Token = "0x600003F")]
			get;
		}

		[Token(Token = "0x17000019")]
		float ScreenDpi
		{
			[Token(Token = "0x6000040")]
			get;
		}

		[Token(Token = "0x1700001A")]
		string OperatingSystem
		{
			[Token(Token = "0x6000041")]
			get;
		}

		[Token(Token = "0x1700001B")]
		string DeviceModel
		{
			[Token(Token = "0x6000042")]
			get;
		}

		[Token(Token = "0x1700001C")]
		bool IsDebugDevice
		{
			[Token(Token = "0x6000043")]
			get;
		}

		[Token(Token = "0x1700001D")]
		bool IsTiny
		{
			[Token(Token = "0x6000044")]
			get;
		}
	}
	[Token(Token = "0x2000014")]
	internal class DeviceDataWrapper : IDeviceData
	{
		[Token(Token = "0x1700001E")]
		public string CpuType
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2D99198", Offset = "0x2D95198", VA = "0x2D99198", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public string GpuType
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x2D991A0", Offset = "0x2D951A0", VA = "0x2D991A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public int CpuCores
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2D991A8", Offset = "0x2D951A8", VA = "0x2D991A8", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000021")]
		public int RamTotal
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2D991B0", Offset = "0x2D951B0", VA = "0x2D991B0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000022")]
		public int ScreenWidth
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2D991B8", Offset = "0x2D951B8", VA = "0x2D991B8", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000023")]
		public int ScreenHeight
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2D991C0", Offset = "0x2D951C0", VA = "0x2D991C0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000024")]
		public float ScreenDpi
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2D991C8", Offset = "0x2D951C8", VA = "0x2D991C8", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000025")]
		public string OperatingSystem
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2D991D0", Offset = "0x2D951D0", VA = "0x2D991D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public string DeviceModel
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2D991D8", Offset = "0x2D951D8", VA = "0x2D991D8", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public bool IsDebugDevice
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2D991E0", Offset = "0x2D951E0", VA = "0x2D991E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public bool IsTiny
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2D991E8", Offset = "0x2D951E8", VA = "0x2D991E8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2D95240", Offset = "0x2D91240", VA = "0x2D95240")]
		public DeviceDataWrapper()
		{
		}
	}
	[Token(Token = "0x2000015")]
	internal class CommonDataWrapper : ICommonData
	{
		[Token(Token = "0x17000029")]
		public string Version
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2D991F0", Offset = "0x2D951F0", VA = "0x2D991F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public string GameBundleId
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2D991F8", Offset = "0x2D951F8", VA = "0x2D991F8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public string ProjectId
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2D99200", Offset = "0x2D95200", VA = "0x2D99200", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public string Platform
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2D99208", Offset = "0x2D95208", VA = "0x2D99208", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public string BuildGUID
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2D99210", Offset = "0x2D95210", VA = "0x2D99210", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public string Idfv
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2D99218", Offset = "0x2D95218", VA = "0x2D99218", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public string GameStoreId
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2D99220", Offset = "0x2D95220", VA = "0x2D99220", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public bool HasVolume
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2D99228", Offset = "0x2D95228", VA = "0x2D99228", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public float Volume
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x2D99230", Offset = "0x2D95230", VA = "0x2D99230", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		public double BatteryLevel
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2D994E0", Offset = "0x2D954E0", VA = "0x2D994E0", Slot = "13")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000033")]
		public string AnalyticsRegionLanguageCode
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2D994F8", Offset = "0x2D954F8", VA = "0x2D994F8", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2D95194", Offset = "0x2D91194", VA = "0x2D95194")]
		public CommonDataWrapper(string cloudProjectId)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2D99544", Offset = "0x2D95544", VA = "0x2D99544")]
		private static string GetPlatform()
		{
			return null;
		}
	}
	[Token(Token = "0x2000016")]
	internal interface IDataGenerator
	{
		[Token(Token = "0x600005E")]
		void GameRunning(string callingMethodIdentifier);

		[Token(Token = "0x600005F")]
		void SdkStartup(string callingMethodIdentifier);

		[Token(Token = "0x6000060")]
		void NewPlayer(string callingMethodIdentifier);

		[Token(Token = "0x6000061")]
		void GameStarted(string callingMethodIdentifier);

		[Token(Token = "0x6000062")]
		void GameEnded(string callingMethodIdentifier, DataGenerator.SessionEndState quitState);

		[Token(Token = "0x6000063")]
		void ClientDevice(string callingMethodIdentifier);

		[Token(Token = "0x6000064")]
		void PushCommonParams(string callingMethodIdentifier);
	}
	[Token(Token = "0x2000017")]
	internal class DataGenerator : IDataGenerator
	{
		[Token(Token = "0x2000018")]
		internal enum SessionEndState
		{
			[Token(Token = "0x400003F")]
			PAUSED,
			[Token(Token = "0x4000040")]
			KILLEDINBACKGROUND,
			[Token(Token = "0x4000041")]
			KILLEDINFOREGROUND,
			[Token(Token = "0x4000042")]
			QUIT
		}

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IBuffer m_Buffer;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ICommonData m_CommonData;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IDeviceData m_DeviceData;

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2D95248", Offset = "0x2D91248", VA = "0x2D95248")]
		public DataGenerator(IBuffer buffer, ICommonData staticData, IDeviceData deviceData)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2D99730", Offset = "0x2D95730", VA = "0x2D99730", Slot = "5")]
		public void SdkStartup(string callingMethodIdentifier)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2D9A5B0", Offset = "0x2D965B0", VA = "0x2D9A5B0", Slot = "4")]
		public void GameRunning(string callingMethodIdentifier)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2D9A6EC", Offset = "0x2D966EC", VA = "0x2D9A6EC", Slot = "6")]
		public void NewPlayer(string callingMethodIdentifier)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2D9A928", Offset = "0x2D96928", VA = "0x2D9A928", Slot = "7")]
		public void GameStarted(string callingMethodIdentifier)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2D9AFA0", Offset = "0x2D96FA0", VA = "0x2D9AFA0", Slot = "8")]
		public void GameEnded(string callingMethodIdentifier, SessionEndState quitState)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2D9B1AC", Offset = "0x2D971AC", VA = "0x2D9B1AC", Slot = "9")]
		public void ClientDevice(string callingMethodIdentifier)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2D999C4", Offset = "0x2D959C4", VA = "0x2D999C4", Slot = "10")]
		public void PushCommonParams(string callingMethodIdentifier)
		{
		}
	}
}
namespace Unity.Services.Analytics.Platform
{
	[Token(Token = "0x2000019")]
	internal static class DeviceVolumeProvider
	{
		[Token(Token = "0x17000034")]
		internal static bool VolumeAvailable
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2D99728", Offset = "0x2D95728", VA = "0x2D99728")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2D99234", Offset = "0x2D95234", VA = "0x2D99234")]
		internal static float GetDeviceVolume()
		{
			return default(float);
		}
	}
}
namespace Unity.Services.Analytics.Internal
{
	[Token(Token = "0x200001A")]
	internal class AnalyticsUserIdServiceComponent : IAnalyticsUserId, IServiceComponent
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAnalyticsService m_AnalyticsService;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2D956A0", Offset = "0x2D916A0", VA = "0x2D956A0")]
		public AnalyticsUserIdServiceComponent(IAnalyticsService analyticsService)
		{
		}
	}
	[Token(Token = "0x200001B")]
	internal interface IIdentityManager
	{
		[Token(Token = "0x17000035")]
		string UserId
		{
			[Token(Token = "0x6000070")]
			get;
		}

		[Token(Token = "0x17000036")]
		string InstallId
		{
			[Token(Token = "0x6000071")]
			get;
		}

		[Token(Token = "0x17000037")]
		string PlayerId
		{
			[Token(Token = "0x6000072")]
			get;
		}

		[Token(Token = "0x17000038")]
		bool IsNewPlayer
		{
			[Token(Token = "0x6000073")]
			get;
		}

		[Token(Token = "0x14000001")]
		event Action OnPlayerChanged;
	}
	[Token(Token = "0x200001C")]
	internal class IdentityManager : IIdentityManager
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IPlayerId m_PlayerId;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IExternalUserId m_ExternalIdProvider;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IPersistence m_Persistence;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Initialized;

		[Token(Token = "0x17000039")]
		public string UserId
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x2D9B98C", Offset = "0x2D9798C", VA = "0x2D9B98C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x2D9B994", Offset = "0x2D97994", VA = "0x2D9B994")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public string InstallId
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x2D9B99C", Offset = "0x2D9799C", VA = "0x2D9B99C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x2D9B9A4", Offset = "0x2D979A4", VA = "0x2D9B9A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public string PlayerId
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x2D9B9AC", Offset = "0x2D979AC", VA = "0x2D9B9AC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public string ExternalId
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x2D9BA58", Offset = "0x2D97A58", VA = "0x2D9BA58", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x2D9BA60", Offset = "0x2D97A60", VA = "0x2D9BA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool IsNewPlayer
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x2D9BA68", Offset = "0x2D97A68", VA = "0x2D9BA68", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x2D9BA70", Offset = "0x2D97A70", VA = "0x2D9BA70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action OnPlayerChanged
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2D9BA78", Offset = "0x2D97A78", VA = "0x2D9BA78", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x2D9BB14", Offset = "0x2D97B14", VA = "0x2D9BB14", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2D94240", Offset = "0x2D90240", VA = "0x2D94240")]
		public IdentityManager(IInstallationId installId, IPlayerId playerId, IExternalUserId externalId, IPersistence persistence)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2D9BBB0", Offset = "0x2D97BB0", VA = "0x2D9BBB0")]
		private void ExternalUserIdChanged(string newName)
		{
		}
	}
	[Token(Token = "0x200001D")]
	internal static class Locale
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2D9BD5C", Offset = "0x2D97D5C", VA = "0x2D9BD5C")]
		internal static string CurrentLanguageCode()
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2D994FC", Offset = "0x2D954FC", VA = "0x2D994FC")]
		internal static string AnalyticsRegionLanguageCode()
		{
			return null;
		}
	}
	[Token(Token = "0x200001E")]
	internal interface IAnalyticsForgetter
	{
		[Token(Token = "0x1700003E")]
		bool DeletionInProgress
		{
			[Token(Token = "0x6000085")]
			get;
		}

		[Token(Token = "0x6000086")]
		void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback);
	}
	[Token(Token = "0x200001F")]
	internal class AnalyticsForgetter : IAnalyticsForgetter
	{
		[Token(Token = "0x2000020")]
		private enum DataDeletionStatus
		{
			[Token(Token = "0x4000054")]
			DataAllowed,
			[Token(Token = "0x4000055")]
			DeletionInProgress,
			[Token(Token = "0x4000056")]
			SuccessfullyDeleted
		}

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string m_CollectUrl;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IPersistence m_Persistence;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IWebRequestHelper m_WebRequestHelper;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action m_Callback;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DataDeletionStatus m_DeletionStatus;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IWebRequest m_Request;

		[Token(Token = "0x1700003F")]
		public bool DeletionInProgress
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2D9BF0C", Offset = "0x2D97F0C", VA = "0x2D9BF0C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2D95284", Offset = "0x2D91284", VA = "0x2D95284")]
		internal AnalyticsForgetter(string collectUrl, IPersistence persistence, IWebRequestHelper webRequestHelper)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2D9BF1C", Offset = "0x2D97F1C", VA = "0x2D9BF1C")]
		private void SetForgettingStatus(DataDeletionStatus state)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2D9BFE4", Offset = "0x2D97FE4", VA = "0x2D9BFE4", Slot = "5")]
		public void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2D9C568", Offset = "0x2D98568", VA = "0x2D9C568")]
		private void UploadComplete(long code)
		{
		}
	}
	[Token(Token = "0x2000021")]
	internal interface IBuffer
	{
		[Token(Token = "0x17000040")]
		int Length
		{
			[Token(Token = "0x6000096")]
			get;
		}

		[Token(Token = "0x600008C")]
		void PushStandardEventStart(string name, int version);

		[Token(Token = "0x600008D")]
		void PushCustomEventStart(string name);

		[Token(Token = "0x600008E")]
		void PushEndEvent();

		[Token(Token = "0x600008F")]
		void PushDouble(string name, double value);

		[Token(Token = "0x6000090")]
		void PushString(string name, string value);

		[Token(Token = "0x6000091")]
		void PushInt64(string name, long value);

		[Token(Token = "0x6000092")]
		void PushBool(string name, bool value);

		[Token(Token = "0x6000093")]
		void PushObject(string name, object value);

		[Token(Token = "0x6000094")]
		void FlushToDisk();

		[Token(Token = "0x6000095")]
		void ClearDiskCache();

		[Token(Token = "0x6000097")]
		byte[] Serialize();

		[Token(Token = "0x6000098")]
		void ClearBuffer();

		[Token(Token = "0x6000099")]
		void ClearBuffer(long upTo);
	}
	[Token(Token = "0x2000022")]
	internal interface IBufferSystemCalls
	{
		[Token(Token = "0x600009A")]
		string GenerateGuid();

		[Token(Token = "0x600009B")]
		DateTime Now();

		[Token(Token = "0x600009C")]
		TimeSpan GetTimeZoneUtcOffset(DateTime dateTime);
	}
	[Token(Token = "0x2000023")]
	internal class BufferSystemCalls : IBufferSystemCalls
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2D9C6C0", Offset = "0x2D986C0", VA = "0x2D9C6C0", Slot = "4")]
		public string GenerateGuid()
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2D9C6EC", Offset = "0x2D986EC", VA = "0x2D9C6EC", Slot = "5")]
		public DateTime Now()
		{
			return default(DateTime);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2D9C73C", Offset = "0x2D9873C", VA = "0x2D9C73C", Slot = "6")]
		public TimeSpan GetTimeZoneUtcOffset(DateTime dateTime)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2D9449C", Offset = "0x2D9049C", VA = "0x2D9449C")]
		public BufferSystemCalls()
		{
		}
	}
	[Token(Token = "0x2000024")]
	internal struct EventSummary
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int StartIndex;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal int EndIndex;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string Id;
	}
	[Token(Token = "0x2000025")]
	internal class BufferX : IBuffer, IBufferDebug
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly byte[] k_WorkingBuffer;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly char[] k_WorkingCharacterBuffer;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly byte[] k_PayloadHeader;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly byte[] k_HeaderEventName;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly byte[] k_HeaderUserName;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly byte[] k_HeaderSessionID;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly byte[] k_HeaderEventUUID;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly byte[] k_HeaderTimestamp;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly byte[] k_HeaderEventVersion;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly byte[] k_HeaderInstallationID;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly byte[] k_HeaderPlayerID;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly byte[] k_HeaderOpenEventParams;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly byte[] k_CloseEvent;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly byte k_Quote;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly byte[] k_QuoteColon;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly byte[] k_QuoteComma;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly byte[] k_Comma;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly byte[] k_OpenBrace;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly byte[] k_CloseBraceComma;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly byte[] k_OpenBracket;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly byte[] k_CloseBracketComma;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly byte k_Colon;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		private readonly byte k_Dash;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		private readonly byte k_Space;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBB")]
		private readonly byte k_Point;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private readonly byte k_Positive;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		private readonly byte k_Negative;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly byte[] k_True;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly byte[] k_False;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly byte[] k_Int2CharacterByte;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly long[] k_Order;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly IBufferSystemCalls m_SystemCalls;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly IDiskCache m_DiskCache;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly IIdentityManager m_UserIdentity;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly ISessionManager m_Session;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly List<EventSummary> m_EventSummaries;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string m_CurrentEventId;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string m_CurrentEventName;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private DateTime m_CurrentEventTimestamp;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private MemoryStream m_SpareBuffer;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private MemoryStream m_Buffer;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[CompilerGenerated]
		private Action<HashSet<string>> EventsCleared;

		[Token(Token = "0x17000041")]
		public int Length
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x2D9C7A4", Offset = "0x2D987A4", VA = "0x2D9C7A4", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<string, string, DateTime, byte[]> EventRecorded
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2D9C7C8", Offset = "0x2D987C8", VA = "0x2D9C7C8", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x2D9C878", Offset = "0x2D98878", VA = "0x2D9C878", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<HashSet<string>> EventsClearing
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x2D9C928", Offset = "0x2D98928", VA = "0x2D9C928", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2D9C9D8", Offset = "0x2D989D8", VA = "0x2D9C9D8", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2D946D8", Offset = "0x2D906D8", VA = "0x2D946D8")]
		public BufferX(IBufferSystemCalls eventIdGenerator, IDiskCache diskCache, IIdentityManager userIdentity, ISessionManager session)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2D9CB30", Offset = "0x2D98B30", VA = "0x2D9CB30")]
		private void WriteString(in string value)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2D9CBB8", Offset = "0x2D98BB8", VA = "0x2D9CBB8")]
		private void WriteLong(in long value)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2D9CE08", Offset = "0x2D98E08", VA = "0x2D9CE08")]
		private void WriteByte(in byte value)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2D9CE2C", Offset = "0x2D98E2C", VA = "0x2D9CE2C")]
		private void WriteBytes(in byte[] bytes)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2D9CE60", Offset = "0x2D98E60", VA = "0x2D9CE60")]
		private void WriteName(string name)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2D9CEC0", Offset = "0x2D98EC0", VA = "0x2D9CEC0")]
		private void WriteDateTime(DateTime dateTime)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2D9CC0C", Offset = "0x2D98C0C", VA = "0x2D9CC0C")]
		private int SerializeLong(in long number, in byte[] buffer, in int startIndex, in int minimumLength)
		{
			return default(int);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2D9D388", Offset = "0x2D99388", VA = "0x2D9D388", Slot = "4")]
		public void PushStandardEventStart(string name, int version)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2D9D83C", Offset = "0x2D9983C", VA = "0x2D9D83C", Slot = "5")]
		public void PushCustomEventStart(string name)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2D9D5AC", Offset = "0x2D995AC", VA = "0x2D9D5AC")]
		private void PushCommonEventStart(string name)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2D9D858", Offset = "0x2D99858", VA = "0x2D9D858")]
		private void StripTrailingCommaIfNecessary()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2D9D904", Offset = "0x2D99904", VA = "0x2D9D904", Slot = "6")]
		public void PushEndEvent()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2D9DC08", Offset = "0x2D99C08", VA = "0x2D9DC08")]
		public void PushObjectStart(string name)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2D9DC24", Offset = "0x2D99C24", VA = "0x2D9DC24")]
		public void PushObjectEnd()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2D9DC40", Offset = "0x2D99C40", VA = "0x2D9DC40")]
		public void PushArrayStart(string name)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2D9DC5C", Offset = "0x2D99C5C", VA = "0x2D9DC5C")]
		public void PushArrayEnd()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2D9DC78", Offset = "0x2D99C78", VA = "0x2D9DC78", Slot = "7")]
		public void PushDouble(string name, double value)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2D9DD20", Offset = "0x2D99D20", VA = "0x2D9DD20", Slot = "22")]
		public void PushFloat(string name, float value)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2D9DDC8", Offset = "0x2D99DC8", VA = "0x2D9DDC8", Slot = "8")]
		public void PushString(string name, string value)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2D9E150", Offset = "0x2D9A150", VA = "0x2D9E150")]
		private int ProcessCharacterOntoWorkingBuffer(int index, char character)
		{
			return default(int);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2D9E340", Offset = "0x2D9A340", VA = "0x2D9E340", Slot = "9")]
		public void PushInt64(string name, long value)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2D9E374", Offset = "0x2D9A374", VA = "0x2D9E374", Slot = "23")]
		public void PushInt(string name, int value)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2D9E37C", Offset = "0x2D9A37C", VA = "0x2D9E37C", Slot = "10")]
		public void PushBool(string name, bool value)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2D9E3C0", Offset = "0x2D9A3C0", VA = "0x2D9E3C0")]
		public void PushTimestamp(string name, DateTime value)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2D9E414", Offset = "0x2D9A414", VA = "0x2D9E414", Slot = "11")]
		public void PushObject(string name, object value)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2D9EBB0", Offset = "0x2D9ABB0", VA = "0x2D9EBB0", Slot = "15")]
		public byte[] Serialize()
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2D9CA88", Offset = "0x2D98A88", VA = "0x2D9CA88", Slot = "16")]
		public void ClearBuffer()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2D9EF44", Offset = "0x2D9AF44", VA = "0x2D9EF44", Slot = "17")]
		public void ClearBuffer(long upTo)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2D9F2A4", Offset = "0x2D9B2A4", VA = "0x2D9F2A4", Slot = "12")]
		public void FlushToDisk()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2D9F358", Offset = "0x2D9B358", VA = "0x2D9F358", Slot = "13")]
		public void ClearDiskCache()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2D97948", Offset = "0x2D93948", VA = "0x2D97948")]
		internal static string SerializeDateTime(DateTime dateTime)
		{
			return null;
		}
	}
	[Token(Token = "0x2000026")]
	internal interface IDiskCache
	{
		[Token(Token = "0x60000C6")]
		void Clear();

		[Token(Token = "0x60000C7")]
		void Write(List<EventSummary> eventSummaries, Stream payload);
	}
	[Token(Token = "0x2000027")]
	internal interface IFileSystemCalls
	{
		[Token(Token = "0x60000C8")]
		bool CanAccessFileSystem();

		[Token(Token = "0x60000C9")]
		bool FileExists(string path);

		[Token(Token = "0x60000CA")]
		void DeleteFile(string path);

		[Token(Token = "0x60000CB")]
		Stream OpenFileForWriting(string path);
	}
	[Token(Token = "0x2000028")]
	internal class FileSystemCalls : IFileSystemCalls
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly bool m_CanAccessFileSystem;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2D944A4", Offset = "0x2D904A4", VA = "0x2D944A4")]
		internal FileSystemCalls()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2D9F3F8", Offset = "0x2D9B3F8", VA = "0x2D9F3F8", Slot = "4")]
		public bool CanAccessFileSystem()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2D9F400", Offset = "0x2D9B400", VA = "0x2D9F400", Slot = "5")]
		public bool FileExists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2D9F40C", Offset = "0x2D9B40C", VA = "0x2D9F40C", Slot = "6")]
		public void DeleteFile(string path)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2D9F418", Offset = "0x2D9B418", VA = "0x2D9F418", Slot = "7")]
		public Stream OpenFileForWriting(string path)
		{
			return null;
		}
	}
	[Token(Token = "0x2000029")]
	internal class DiskCache : IDiskCache
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string k_CacheFilePath;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IFileSystemCalls k_SystemCalls;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly long k_CacheFileMaximumSize;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2D945CC", Offset = "0x2D905CC", VA = "0x2D945CC")]
		internal DiskCache(IFileSystemCalls systemCalls)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2D9F478", Offset = "0x2D9B478", VA = "0x2D9F478", Slot = "5")]
		public void Write(List<EventSummary> eventSummaries, Stream payload)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2D9FA28", Offset = "0x2D9BA28", VA = "0x2D9FA28", Slot = "4")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200002A")]
	internal interface IDispatcher
	{
		[Token(Token = "0x17000042")]
		int ConsecutiveFailedUploadCount
		{
			[Token(Token = "0x60000D4")]
			get;
		}

		[Token(Token = "0x60000D5")]
		void SetBuffer(IBuffer buffer);

		[Token(Token = "0x60000D6")]
		void Flush();
	}
	[Token(Token = "0x200002B")]
	internal class Dispatcher : IDispatcher, IDispatcherDebug
	{
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IWebRequestHelper m_WebRequestHelper;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string m_CollectUrl;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IBuffer m_DataBuffer;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IWebRequest m_FlushRequest;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] m_LastFlushPayload;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_FlushBufferIndex;

		[Token(Token = "0x17000043")]
		public int ConsecutiveFailedUploadCount
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x2D9FBC0", Offset = "0x2D9BBC0", VA = "0x2D9FBC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2D9FBC8", Offset = "0x2D9BBC8", VA = "0x2D9FBC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool FlushInProgress
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x2D9FBD0", Offset = "0x2D9BBD0", VA = "0x2D9FBD0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x2D9FBD8", Offset = "0x2D9BBD8", VA = "0x2D9FBD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action<byte[]> FlushStarted
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x2D9FBE0", Offset = "0x2D9BBE0", VA = "0x2D9FBE0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x2D9FC90", Offset = "0x2D9BC90", VA = "0x2D9FC90", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event Action<int, bool, bool, bool, bool, byte[]> FlushFinished
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x2D9FD40", Offset = "0x2D9BD40", VA = "0x2D9FD40", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x2D9FDF0", Offset = "0x2D9BDF0", VA = "0x2D9FDF0", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2D95168", Offset = "0x2D91168", VA = "0x2D95168")]
		public Dispatcher(IWebRequestHelper webRequestHelper, string collectUrl)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2D9FEA0", Offset = "0x2D9BEA0", VA = "0x2D9FEA0", Slot = "5")]
		public void SetBuffer(IBuffer buffer)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2D9FEA8", Offset = "0x2D9BEA8", VA = "0x2D9FEA8", Slot = "6")]
		public void Flush()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2D9FF2C", Offset = "0x2D9BF2C", VA = "0x2D9FF2C")]
		private void FlushBufferToService()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2DA0334", Offset = "0x2D9C334", VA = "0x2DA0334")]
		private void UploadCompleted(long responseCode)
		{
		}
	}
	[Token(Token = "0x200002C")]
	internal interface IBufferDebug
	{
		[Token(Token = "0x14000007")]
		event Action<string, string, DateTime, byte[]> EventRecorded;

		[Token(Token = "0x14000008")]
		event Action<HashSet<string>> EventsClearing;
	}
	[Token(Token = "0x200002D")]
	internal interface IDispatcherDebug
	{
		[Token(Token = "0x14000009")]
		event Action<byte[]> FlushStarted;

		[Token(Token = "0x1400000A")]
		event Action<int, bool, bool, bool, bool, byte[]> FlushFinished;
	}
	[Token(Token = "0x200002E")]
	internal interface IContainerDebug
	{
	}
	[Token(Token = "0x200002F")]
	internal interface IPersistence
	{
		[Token(Token = "0x60000EC")]
		void SaveValue(string key, int value);

		[Token(Token = "0x60000ED")]
		void SaveValue(string key, string value);

		[Token(Token = "0x60000EE")]
		int LoadInt(string key);
	}
	[Token(Token = "0x2000030")]
	internal class PlayerPrefsPersistence : IPersistence
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2DA06A0", Offset = "0x2D9C6A0", VA = "0x2DA06A0", Slot = "4")]
		public void SaveValue(string key, int value)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2DA06C0", Offset = "0x2D9C6C0", VA = "0x2DA06C0", Slot = "5")]
		public void SaveValue(string key, string value)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2DA06E0", Offset = "0x2D9C6E0", VA = "0x2DA06E0", Slot = "6")]
		public int LoadInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2D94238", Offset = "0x2D90238", VA = "0x2D94238")]
		public PlayerPrefsPersistence()
		{
		}
	}
	[Token(Token = "0x2000031")]
	internal interface IWebRequest : IDisposable
	{
		[Token(Token = "0x17000045")]
		bool IsNetworkError
		{
			[Token(Token = "0x60000F5")]
			get;
		}

		[Token(Token = "0x60000F3")]
		UnityWebRequestAsyncOperation SendWebRequest();

		[Token(Token = "0x60000F4")]
		void SetRequestHeader(string key, string value);
	}
	[Token(Token = "0x2000032")]
	internal interface IWebRequestHelper
	{
		[Token(Token = "0x60000F6")]
		IWebRequest CreateWebRequest(string url, string method, byte[] postBytes);

		[Token(Token = "0x60000F7")]
		void SendWebRequest(IWebRequest request, Action<long> onCompleted);
	}
	[Token(Token = "0x2000033")]
	internal class AnalyticsWebRequest : UnityWebRequest, IWebRequest, IDisposable
	{
		[Token(Token = "0x17000046")]
		public bool IsNetworkError
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x2DA071C", Offset = "0x2D9C71C", VA = "0x2DA071C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2DA0714", Offset = "0x2D9C714", VA = "0x2DA0714")]
		internal AnalyticsWebRequest(string url, string method)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2DA0738", Offset = "0x2D9C738", VA = "0x2DA0738", Slot = "5")]
		private UnityWebRequestAsyncOperation Unity.Services.Analytics.Internal.IWebRequest.SendWebRequest()
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2DA0740", Offset = "0x2D9C740", VA = "0x2DA0740", Slot = "6")]
		private void Unity.Services.Analytics.Internal.IWebRequest.SetRequestHeader(string key, string value)
		{
		}
	}
	[Token(Token = "0x2000034")]
	internal class WebRequestHelper : IWebRequestHelper
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string k_ClientIdHeaderValue;

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2DA0748", Offset = "0x2D9C748", VA = "0x2DA0748", Slot = "4")]
		public IWebRequest CreateWebRequest(string url, string method, byte[] postBytes)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2DA0858", Offset = "0x2D9C858", VA = "0x2DA0858", Slot = "5")]
		public void SendWebRequest(IWebRequest request, Action<long> onCompleted)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2D950DC", Offset = "0x2D910DC", VA = "0x2D950DC")]
		public WebRequestHelper()
		{
		}
	}
	[Token(Token = "0x2000036")]
	internal interface ISessionManager
	{
		[Token(Token = "0x17000047")]
		string SessionId
		{
			[Token(Token = "0x6000101")]
			get;
		}

		[Token(Token = "0x6000102")]
		void StartNewSession();
	}
	[Token(Token = "0x2000037")]
	internal class SessionManager : ISessionManager
	{
		[Token(Token = "0x17000048")]
		public string SessionId
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x2DA09DC", Offset = "0x2D9C9DC", VA = "0x2DA09DC", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2DA09E4", Offset = "0x2D9C9E4", VA = "0x2DA09E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2D94460", Offset = "0x2D90460", VA = "0x2D94460")]
		public SessionManager()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2DA09EC", Offset = "0x2D9C9EC", VA = "0x2DA09EC", Slot = "5")]
		public void StartNewSession()
		{
		}
	}
	[Token(Token = "0x2000038")]
	internal class StandardEventServiceComponent : IAnalyticsStandardEventComponent, IServiceComponent
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IProjectConfiguration m_Configuration;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IUnstructuredEventRecorder m_AnalyticsService;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2D95674", Offset = "0x2D91674", VA = "0x2D95674")]
		public StandardEventServiceComponent(IProjectConfiguration configuration, IUnstructuredEventRecorder analyticsService)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2DA0A20", Offset = "0x2D9CA20", VA = "0x2DA0A20", Slot = "4")]
		public void Record(string eventName, IDictionary<string, object> eventParameters, int eventVersion, string packageName)
		{
		}
	}
}
