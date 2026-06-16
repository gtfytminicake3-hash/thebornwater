using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.SubsystemsImplementation;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine
{
	[Token(Token = "0x2000002")]
	public interface ISubsystem
	{
	}
	[Token(Token = "0x2000003")]
	public interface ISubsystemDescriptor
	{
		[Token(Token = "0x17000001")]
		string id
		{
			[Token(Token = "0x6000001")]
			get;
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000004")]
	[UnityEngine.Scripting.UsedByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Subsystems/Subsystem.h")]
	public class IntegratedSubsystem : ISubsystem
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal ISubsystemDescriptor m_SubsystemDescriptor;

		[Token(Token = "0x17000002")]
		public bool running
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2E880C4", Offset = "0x2E840C4", VA = "0x2E880C4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		internal bool valid
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2E88124", Offset = "0x2E84124", VA = "0x2E88124")]
			get
			{
				return default(bool);
			}
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2E88080", Offset = "0x2E84080", VA = "0x2E88080")]
		internal extern void SetHandle(IntegratedSubsystem subsystem);

		[MethodImpl(4096)]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2E88134", Offset = "0x2E84134", VA = "0x2E88134")]
		internal extern bool IsRunning();

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2E88170", Offset = "0x2E84170", VA = "0x2E88170")]
		public IntegratedSubsystem()
		{
		}
	}
	[Token(Token = "0x2000005")]
	[UnityEngine.Scripting.UsedByNativeCode("Subsystem_TSubsystemDescriptor")]
	public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem where TSubsystemDescriptor : ISubsystemDescriptor
	{
		[Token(Token = "0x6000007")]
		public IntegratedSubsystem()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000006")]
	[UnityEngine.Scripting.UsedByNativeCode("SubsystemDescriptorBase")]
	public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		[Token(Token = "0x17000004")]
		public string id
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2E88178", Offset = "0x2E84178", VA = "0x2E88178", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2E881F0", Offset = "0x2E841F0", VA = "0x2E881F0")]
		protected IntegratedSubsystemDescriptor()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000007")]
	[UnityEngine.Bindings.NativeHeader("Modules/Subsystems/SubsystemDescriptor.h")]
	[UnityEngine.Scripting.UsedByNativeCode("SubsystemDescriptor")]
	public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor where TSubsystem : IntegratedSubsystem
	{
		[Token(Token = "0x600000A")]
		public IntegratedSubsystemDescriptor()
		{
		}
	}
	[Token(Token = "0x2000008")]
	internal static class SubsystemDescriptorBindings
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2E881B4", Offset = "0x2E841B4", VA = "0x2E881B4")]
		public static extern string GetId(IntPtr descriptorPtr);
	}
	[Token(Token = "0x2000009")]
	public abstract class Subsystem : ISubsystem
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2E881F8", Offset = "0x2E841F8", VA = "0x2E881F8")]
		protected Subsystem()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public abstract class SubsystemDescriptor : ISubsystemDescriptor
	{
		[Token(Token = "0x17000005")]
		public string id
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2E88200", Offset = "0x2E84200", VA = "0x2E88200", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2E88208", Offset = "0x2E84208", VA = "0x2E88208")]
		protected SubsystemDescriptor()
		{
		}
	}
	[Token(Token = "0x200000B")]
	internal static class Internal_SubsystemDescriptors
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2E88210", Offset = "0x2E84210", VA = "0x2E88210")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void Internal_AddDescriptor(SubsystemDescriptor descriptor)
		{
		}
	}
	[Token(Token = "0x200000C")]
	[UnityEngine.Bindings.NativeHeader("Modules/Subsystems/SubsystemManager.h")]
	public static class SubsystemManager
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action beforeReloadSubsystems;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action afterReloadSubsystems;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<IntegratedSubsystem> s_IntegratedSubsystems;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<SubsystemWithProvider> s_StandaloneSubsystems;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<Subsystem> s_DeprecatedSubsystems;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action reloadSubsytemsStarted;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action reloadSubsytemsCompleted;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2E882DC", Offset = "0x2E842DC", VA = "0x2E882DC")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		private static void ReloadSubsystemsStarted()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2E883BC", Offset = "0x2E843BC", VA = "0x2E883BC")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		private static void ReloadSubsystemsCompleted()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2E8849C", Offset = "0x2E8449C", VA = "0x2E8849C")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2E885AC", Offset = "0x2E845AC", VA = "0x2E885AC")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		private static void ClearSubsystems()
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2E887D4", Offset = "0x2E847D4", VA = "0x2E887D4")]
		private static extern void StaticConstructScriptingClassMap();

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2E887FC", Offset = "0x2E847FC", VA = "0x2E887FC")]
		static SubsystemManager()
		{
		}

		[Token(Token = "0x6000016")]
		public static void GetSubsystems<T>(List<T> subsystems) where T : ISubsystem
		{
		}

		[Token(Token = "0x6000017")]
		private static void AddSubsystemSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo) where TBaseTypeInList : ISubsystem where TQueryType : ISubsystem
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2E88944", Offset = "0x2E84944", VA = "0x2E88944")]
		internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		public static void GetInstances<T>(List<T> subsystems) where T : ISubsystem
		{
		}
	}
}
namespace UnityEngine.SubsystemsImplementation
{
	[Token(Token = "0x200000D")]
	[UnityEngine.Bindings.NativeHeader("Modules/Subsystems/SubsystemManager.h")]
	public static class SubsystemDescriptorStore
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<SubsystemDescriptor> s_DeprecatedDescriptors;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2E88AC8", Offset = "0x2E84AC8", VA = "0x2E88AC8")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2E88BA0", Offset = "0x2E84BA0", VA = "0x2E88BA0")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void ClearManagedDescriptors()
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2E88D48", Offset = "0x2E84D48", VA = "0x2E88D48")]
		private static extern void ReportSingleSubsystemAnalytics(string id);

		[Token(Token = "0x600001D")]
		internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) where TDescriptor : TBaseTypeInList where TBaseTypeInList : ISubsystemDescriptor
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2E88264", Offset = "0x2E84264", VA = "0x2E88264")]
		internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor
	{
		[Token(Token = "0x17000006")]
		public string id
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2E88EB0", Offset = "0x2E84EB0", VA = "0x2E88EB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2E88EB8", Offset = "0x2E84EB8", VA = "0x2E88EB8")]
		protected SubsystemDescriptorWithProvider()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public abstract class SubsystemWithProvider : ISubsystem
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2E88EC0", Offset = "0x2E84EC0", VA = "0x2E88EC0")]
		protected SubsystemWithProvider()
		{
		}
	}
}
