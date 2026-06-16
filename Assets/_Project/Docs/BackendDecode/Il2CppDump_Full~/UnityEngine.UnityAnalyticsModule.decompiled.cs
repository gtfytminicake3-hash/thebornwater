using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine
{
	[Token(Token = "0x2000002")]
	[UnityEngine.Bindings.NativeHeader("UnityAnalyticsScriptingClasses.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
	public static class RemoteSettings
	{
		[Token(Token = "0x2000003")]
		public delegate void UpdatedEventHandler();

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static UpdatedEventHandler Updated;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action BeforeFetchFromServer;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<bool, bool, int> Completed;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x3042C4C", Offset = "0x303EC4C", VA = "0x3042C4C")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x3042CB0", Offset = "0x303ECB0", VA = "0x3042CB0")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void RemoteSettingsBeforeFetchFromServer()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3042D14", Offset = "0x303ED14", VA = "0x3042D14")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response)
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000004")]
	[ExcludeFromDocs]
	[UnityEngine.Bindings.NativeHeader("UnityAnalyticsScriptingClasses.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
	public class RemoteConfigSettings
	{
		[NonSerialized]
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<bool> Updated;

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3042E38", Offset = "0x303EE38", VA = "0x3042E38")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer)
		{
		}
	}
	[Token(Token = "0x2000005")]
	internal static class RemoteConfigSettingsHelper
	{
		[Token(Token = "0x2000006")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal enum Tag
		{
			[Token(Token = "0x4000007")]
			kUnknown,
			[Token(Token = "0x4000008")]
			kIntVal,
			[Token(Token = "0x4000009")]
			kInt64Val,
			[Token(Token = "0x400000A")]
			kUInt64Val,
			[Token(Token = "0x400000B")]
			kDoubleVal,
			[Token(Token = "0x400000C")]
			kBoolVal,
			[Token(Token = "0x400000D")]
			kStringVal,
			[Token(Token = "0x400000E")]
			kArrayVal,
			[Token(Token = "0x400000F")]
			kMixedArrayVal,
			[Token(Token = "0x4000010")]
			kMapVal,
			[Token(Token = "0x4000011")]
			kMaxTags
		}
	}
}
namespace UnityEngine.Analytics
{
	[Token(Token = "0x2000007")]
	[ExcludeFromDocs]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityAnalytics/ContinuousEvent/Manager.h")]
	public class ContinuousEvent
	{
	}
	[Token(Token = "0x2000008")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public enum AnalyticsSessionState
	{
		[Token(Token = "0x4000013")]
		kSessionStopped,
		[Token(Token = "0x4000014")]
		kSessionStarted,
		[Token(Token = "0x4000015")]
		kSessionPaused,
		[Token(Token = "0x4000016")]
		kSessionResumed
	}
	[Token(Token = "0x2000009")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
	[UnityEngine.Bindings.NativeHeader("UnityAnalyticsScriptingClasses.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public static class AnalyticsSessionInfo
	{
		[Token(Token = "0x200000A")]
		public delegate void SessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);

		[Token(Token = "0x200000B")]
		public delegate void IdentityTokenChanged(string token);

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static SessionStateChanged sessionStateChanged;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static IdentityTokenChanged identityTokenChanged;

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3042E64", Offset = "0x303EE64", VA = "0x3042E64")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3042F00", Offset = "0x303EF00", VA = "0x3042F00")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void CallIdentityTokenChanged(string token)
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x200000C")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
	internal class CustomEventData : IDisposable
	{
		[NonSerialized]
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x30430BC", Offset = "0x303F0BC", VA = "0x30430BC")]
		public CustomEventData(string name)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3043154", Offset = "0x303F154", VA = "0x3043154", Slot = "1")]
		~CustomEventData()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x30431D8", Offset = "0x303F1D8", VA = "0x30431D8")]
		private void Destroy()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3043270", Offset = "0x303F270", VA = "0x3043270", Slot = "4")]
		public void Dispose()
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3043110", Offset = "0x303F110", VA = "0x3043110")]
		internal static extern IntPtr Internal_Create(CustomEventData ced, string name);

		[MethodImpl(4096)]
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3043234", Offset = "0x303F234", VA = "0x3043234")]
		[UnityEngine.Bindings.ThreadSafe]
		internal static extern void Internal_Destroy(IntPtr ptr);

		[MethodImpl(4096)]
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x30432D0", Offset = "0x303F2D0", VA = "0x30432D0")]
		public extern bool AddString(string key, string value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3043324", Offset = "0x303F324", VA = "0x3043324")]
		public extern bool AddInt32(string key, int value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3043378", Offset = "0x303F378", VA = "0x3043378")]
		public extern bool AddUInt32(string key, uint value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x30433CC", Offset = "0x303F3CC", VA = "0x30433CC")]
		public extern bool AddInt64(string key, long value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3043420", Offset = "0x303F420", VA = "0x3043420")]
		public extern bool AddUInt64(string key, ulong value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3043474", Offset = "0x303F474", VA = "0x3043474")]
		public extern bool AddBool(string key, bool value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x30434C8", Offset = "0x303F4C8", VA = "0x30434C8")]
		public extern bool AddDouble(string key, double value);

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x304351C", Offset = "0x303F51C", VA = "0x304351C")]
		public bool AddDictionary(IDictionary<string, object> eventData)
		{
			return default(bool);
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x200000D")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityConnect/UnityConnectSettings.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
	public static class Analytics
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3044504", Offset = "0x3040504", VA = "0x3044504")]
		[UnityEngine.Bindings.ThreadSafe]
		internal static extern bool IsInitialized();

		[MethodImpl(4096)]
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x304452C", Offset = "0x304052C", VA = "0x304452C")]
		[UnityEngine.Bindings.StaticAccessor("GetUnityAnalytics()", UnityEngine.Bindings.StaticAccessorType.Dot)]
		private static extern AnalyticsResult SendCustomEventName(string customEventName);

		[MethodImpl(4096)]
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3044568", Offset = "0x3040568", VA = "0x3044568")]
		[UnityEngine.Bindings.StaticAccessor("GetUnityAnalytics()", UnityEngine.Bindings.StaticAccessorType.Dot)]
		private static extern AnalyticsResult SendCustomEvent(CustomEventData eventData);

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x30445A4", Offset = "0x30405A4", VA = "0x30445A4")]
		public static AnalyticsResult CustomEvent(string customEventName)
		{
			return default(AnalyticsResult);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3044668", Offset = "0x3040668", VA = "0x3044668")]
		public static AnalyticsResult CustomEvent(string customEventName, IDictionary<string, object> eventData)
		{
			return default(AnalyticsResult);
		}
	}
	[Token(Token = "0x200000E")]
	public enum AnalyticsResult
	{
		[Token(Token = "0x400001B")]
		Ok,
		[Token(Token = "0x400001C")]
		NotInitialized,
		[Token(Token = "0x400001D")]
		AnalyticsDisabled,
		[Token(Token = "0x400001E")]
		TooManyItems,
		[Token(Token = "0x400001F")]
		SizeLimitReached,
		[Token(Token = "0x4000020")]
		TooManyRequests,
		[Token(Token = "0x4000021")]
		InvalidData,
		[Token(Token = "0x4000022")]
		UnsupportedPlatform
	}
}
