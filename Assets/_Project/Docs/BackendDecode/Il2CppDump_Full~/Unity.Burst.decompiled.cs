using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Burst
{
	[Token(Token = "0x2000002")]
	public enum OptimizeFor
	{
		[Token(Token = "0x4000002")]
		Default,
		[Token(Token = "0x4000003")]
		Performance,
		[Token(Token = "0x4000004")]
		Size,
		[Token(Token = "0x4000005")]
		FastCompilation,
		[Token(Token = "0x4000006")]
		Balanced
	}
	[Token(Token = "0x2000003")]
	public enum FloatMode
	{
		[Token(Token = "0x4000008")]
		Default,
		[Token(Token = "0x4000009")]
		Strict,
		[Token(Token = "0x400000A")]
		Deterministic,
		[Token(Token = "0x400000B")]
		Fast
	}
	[Token(Token = "0x2000004")]
	public enum FloatPrecision
	{
		[Token(Token = "0x400000D")]
		Standard,
		[Token(Token = "0x400000E")]
		High,
		[Token(Token = "0x400000F")]
		Medium,
		[Token(Token = "0x4000010")]
		Low
	}
	[Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
	public class BurstCompileAttribute : Attribute
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal bool? _compileSynchronously;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		internal bool? _disableSafetyChecks;

		[Token(Token = "0x17000001")]
		public FloatMode FloatMode
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2B24BEC", Offset = "0x2B20BEC", VA = "0x2B24BEC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public FloatPrecision FloatPrecision
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2B24BF4", Offset = "0x2B20BF4", VA = "0x2B24BF4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public bool CompileSynchronously
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2B24BFC", Offset = "0x2B20BFC", VA = "0x2B24BFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public bool DisableSafetyChecks
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2B24C64", Offset = "0x2B20C64", VA = "0x2B24C64")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public OptimizeFor OptimizeFor
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2B24CCC", Offset = "0x2B20CCC", VA = "0x2B24CCC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		internal string[] Options
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2B24CD4", Offset = "0x2B20CD4", VA = "0x2B24CD4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2B24CDC", Offset = "0x2B20CDC", VA = "0x2B24CDC")]
		public BurstCompileAttribute()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2B24CE4", Offset = "0x2B20CE4", VA = "0x2B24CE4")]
		public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public static class BurstCompiler
	{
		[Token(Token = "0x2000007")]
		[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
		internal class StaticTypeReinitAttribute : Attribute
		{
			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly Type reinitType;

			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2B25688", Offset = "0x2B21688", VA = "0x2B25688")]
			public StaticTypeReinitAttribute(Type toReinit)
			{
			}
		}

		[Token(Token = "0x2000008")]
		[BurstCompile]
		internal static class BurstCompilerHelper
		{
			[Token(Token = "0x2000009")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			private delegate bool IsBurstEnabledDelegate();

			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly IsBurstEnabledDelegate IsBurstEnabledImpl;

			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly bool IsBurstGenerated;

			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2B256B0", Offset = "0x2B216B0", VA = "0x2B256B0")]
			[MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
			[BurstCompile]
			private static bool IsBurstEnabled()
			{
				return default(bool);
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2B25700", Offset = "0x2B21700", VA = "0x2B25700")]
			[BurstDiscard]
			private static void DiscardedMethod(ref bool value)
			{
			}

			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2B25708", Offset = "0x2B21708", VA = "0x2B25708")]
			private static bool IsCompiledByBurst(Delegate del)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200000A")]
		private class FakeDelegate
		{
			[Token(Token = "0x17000008")]
			[Preserve]
			public MethodInfo Method
			{
				[Token(Token = "0x6000017")]
				[Address(RVA = "0x2B258BC", Offset = "0x2B218BC", VA = "0x2B258BC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2B24F20", Offset = "0x2B20F20", VA = "0x2B24F20")]
			public FakeDelegate(MethodInfo method)
			{
			}
		}

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool _IsEnabled;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly BurstCompilerOptions Options;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static Action OnCompileILPPMethod2;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly MethodInfo DummyMethodInfo;

		[Token(Token = "0x17000007")]
		public static bool IsEnabled
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2B24D10", Offset = "0x2B20D10", VA = "0x2B24D10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2B24DA4", Offset = "0x2B20DA4", VA = "0x2B24DA4")]
		public static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2B25388", Offset = "0x2B21388", VA = "0x2B25388")]
		public unsafe static void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle)
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)null);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2B24F48", Offset = "0x2B20F48", VA = "0x2B24F48")]
		private unsafe static void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing)
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)null);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2B25528", Offset = "0x2B21528", VA = "0x2B25528")]
		private static void DummyMethod()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public sealed class BurstCompilerOptions
	{
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly bool ForceDisableBurstCompilation;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static readonly bool ForceBurstCompilationSynchronously;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		internal static readonly bool IsSecondaryUnityProcess;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _enableBurstCompilation;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool _enableBurstSafetyChecks;

		[Token(Token = "0x17000009")]
		private bool IsGlobal
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2B25AE4", Offset = "0x2B21AE4", VA = "0x2B25AE4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public bool EnableBurstCompilation
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x2B25AEC", Offset = "0x2B21AEC", VA = "0x2B25AEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2B25994", Offset = "0x2B21994", VA = "0x2B25994")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool EnableBurstSafetyChecks
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x2B25AB4", Offset = "0x2B21AB4", VA = "0x2B25AB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		internal Action OptionsChanged
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2B25B14", Offset = "0x2B21B14", VA = "0x2B25B14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2B25624", Offset = "0x2B21624", VA = "0x2B25624")]
		internal BurstCompilerOptions(bool isGlobal)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2B25B1C", Offset = "0x2B21B1C", VA = "0x2B25B1C")]
		private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2B25BA4", Offset = "0x2B21BA4", VA = "0x2B25BA4")]
		private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2B2546C", Offset = "0x2B2146C", VA = "0x2B2546C")]
		internal static bool HasBurstCompileAttribute(MemberInfo member)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2B25AF4", Offset = "0x2B21AF4", VA = "0x2B25AF4")]
		private void OnOptionsChanged()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2B25B10", Offset = "0x2B21B10", VA = "0x2B25B10")]
		private void MaybeTriggerRecompilation()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2B25F8C", Offset = "0x2B21F8C", VA = "0x2B25F8C")]
		static BurstCompilerOptions()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2B26104", Offset = "0x2B22104", VA = "0x2B26104")]
		private static bool CheckIsSecondaryUnityProcess()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000D")]
	public static class BurstRuntime
	{
		[Token(Token = "0x200000E")]
		internal class PreserveAttribute : Attribute
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2B26248", Offset = "0x2B22248", VA = "0x2B26248")]
			public PreserveAttribute()
			{
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2B2610C", Offset = "0x2B2210C", VA = "0x2B2610C")]
		[Preserve]
		internal unsafe static void RuntimeLog(byte* message, int logType, byte* fileName, int lineNumber)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2B26124", Offset = "0x2B22124", VA = "0x2B26124")]
		[Preserve]
		internal static void PreventRequiredAttributeStrip()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2B26230", Offset = "0x2B22230", VA = "0x2B26230")]
		[Preserve]
		internal unsafe static void Log(byte* message, int logType, byte* fileName, int lineNumber)
		{
		}
	}
	[Token(Token = "0x200000F")]
	internal static class BurstString
	{
		[Token(Token = "0x2000010")]
		internal class PreserveAttribute : Attribute
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2B29CFC", Offset = "0x2B25CFC", VA = "0x2B29CFC")]
			public PreserveAttribute()
			{
			}
		}

		[Token(Token = "0x2000011")]
		private enum NumberBufferKind
		{
			[Token(Token = "0x400002E")]
			Integer,
			[Token(Token = "0x400002F")]
			Float
		}

		[Token(Token = "0x2000012")]
		private struct NumberBuffer
		{
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private unsafe readonly byte* _buffer;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public NumberBufferKind Kind;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int DigitsCount;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int Scale;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly bool IsNegative;

			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2B2775C", Offset = "0x2B2375C", VA = "0x2B2775C")]
			public unsafe NumberBuffer(NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative)
			{
			}

			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2B29D04", Offset = "0x2B25D04", VA = "0x2B29D04")]
			public unsafe byte* GetDigitsPointer()
			{
				//IL_0002: Expected I, but got O
				return (byte*)unchecked((nint)null);
			}
		}

		[Token(Token = "0x2000013")]
		public enum NumberFormatKind : byte
		{
			[Token(Token = "0x4000036")]
			General,
			[Token(Token = "0x4000037")]
			Decimal,
			[Token(Token = "0x4000038")]
			DecimalForceSigned,
			[Token(Token = "0x4000039")]
			Hexadecimal
		}

		[Token(Token = "0x2000014")]
		public struct FormatOptions
		{
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NumberFormatKind Kind;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public sbyte AlignAndSize;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte Specifier;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public bool Lowercase;

			[Token(Token = "0x1700000D")]
			public bool Uppercase
			{
				[Token(Token = "0x600005F")]
				[Address(RVA = "0x2B27710", Offset = "0x2B23710", VA = "0x2B27710")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2B27F0C", Offset = "0x2B23F0C", VA = "0x2B27F0C")]
			public FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase)
			{
			}

			[Token(Token = "0x6000060")]
			[Address(RVA = "0x2B276F8", Offset = "0x2B236F8", VA = "0x2B276F8")]
			public int GetBase()
			{
				return default(int);
			}

			[Token(Token = "0x6000061")]
			[Address(RVA = "0x2B29D0C", Offset = "0x2B25D0C", VA = "0x2B29D0C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x2000015")]
		public struct tBigInt
		{
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int m_length;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public unsafe fixed uint m_blocks[35];

			[Token(Token = "0x6000062")]
			[Address(RVA = "0x2B29FF8", Offset = "0x2B25FF8", VA = "0x2B29FF8")]
			public int GetLength()
			{
				return default(int);
			}

			[Token(Token = "0x6000063")]
			[Address(RVA = "0x2B298F8", Offset = "0x2B258F8", VA = "0x2B298F8")]
			public uint GetBlock(int idx)
			{
				return default(uint);
			}

			[Token(Token = "0x6000064")]
			[Address(RVA = "0x2B29904", Offset = "0x2B25904", VA = "0x2B29904")]
			public bool IsZero()
			{
				return default(bool);
			}

			[Token(Token = "0x6000065")]
			[Address(RVA = "0x2B298C8", Offset = "0x2B258C8", VA = "0x2B298C8")]
			public void SetU64(ulong val)
			{
			}

			[Token(Token = "0x6000066")]
			[Address(RVA = "0x2B28930", Offset = "0x2B24930", VA = "0x2B28930")]
			public void SetU32(uint val)
			{
			}
		}

		[Token(Token = "0x2000017")]
		public enum CutoffMode
		{
			[Token(Token = "0x4000042")]
			Unique,
			[Token(Token = "0x4000043")]
			TotalLength,
			[Token(Token = "0x4000044")]
			FractionLength
		}

		[StructLayout(2)]
		[Token(Token = "0x2000018")]
		public struct tFloatUnion32
		{
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float m_floatingPoint;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint m_integer;

			[Token(Token = "0x6000067")]
			[Address(RVA = "0x2B29B1C", Offset = "0x2B25B1C", VA = "0x2B29B1C")]
			public bool IsNegative()
			{
				return default(bool);
			}

			[Token(Token = "0x6000068")]
			[Address(RVA = "0x2B29B04", Offset = "0x2B25B04", VA = "0x2B29B04")]
			public uint GetExponent()
			{
				return default(uint);
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x2B29B10", Offset = "0x2B25B10", VA = "0x2B29B10")]
			public uint GetMantissa()
			{
				return default(uint);
			}
		}

		[StructLayout(2)]
		[Token(Token = "0x2000019")]
		public struct tFloatUnion64
		{
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double m_floatingPoint;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong m_integer;

			[Token(Token = "0x600006A")]
			[Address(RVA = "0x2B29B40", Offset = "0x2B25B40", VA = "0x2B29B40")]
			public bool IsNegative()
			{
				return default(bool);
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0x2B29B28", Offset = "0x2B25B28", VA = "0x2B29B28")]
			public uint GetExponent()
			{
				return default(uint);
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0x2B29B34", Offset = "0x2B25B34", VA = "0x2B29B34")]
			public ulong GetMantissa()
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] SplitByColon;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly byte[] logTable;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly uint[] g_PowerOf10_U32;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly byte[] InfinityString;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly byte[] NanString;

		[MethodImpl(256)]
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2B26250", Offset = "0x2B22250", VA = "0x2B26250")]
		[Preserve]
		public unsafe static void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2B26274", Offset = "0x2B22274", VA = "0x2B26274")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2B264A4", Offset = "0x2B224A4", VA = "0x2B264A4")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2B267C8", Offset = "0x2B227C8", VA = "0x2B267C8")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2B26AEC", Offset = "0x2B22AEC", VA = "0x2B26AEC")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2B26CB4", Offset = "0x2B22CB4", VA = "0x2B26CB4")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2B26EB0", Offset = "0x2B22EB0", VA = "0x2B26EB0")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2B26FB8", Offset = "0x2B22FB8", VA = "0x2B26FB8")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2B2703C", Offset = "0x2B2303C", VA = "0x2B2703C")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2B26F34", Offset = "0x2B22F34", VA = "0x2B26F34")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2B2725C", Offset = "0x2B2325C", VA = "0x2B2725C")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2B274B8", Offset = "0x2B234B8", VA = "0x2B274B8")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2B27578", Offset = "0x2B23578", VA = "0x2B27578")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2B27638", Offset = "0x2B23638", VA = "0x2B27638")]
		[Preserve]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2B270C0", Offset = "0x2B230C0", VA = "0x2B270C0")]
		private unsafe static void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2B279C4", Offset = "0x2B239C4", VA = "0x2B279C4")]
		private static int GetLengthIntegerToString(long value, int basis, int zeroPadding)
		{
			return default(int);
		}

		[MethodImpl(8)]
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2B2731C", Offset = "0x2B2331C", VA = "0x2B2731C")]
		private unsafe static void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, FormatOptions options)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2B27770", Offset = "0x2B23770", VA = "0x2B27770")]
		private unsafe static void FormatNumber(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2B279F0", Offset = "0x2B239F0", VA = "0x2B279F0")]
		private unsafe static void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2B27720", Offset = "0x2B23720", VA = "0x2B27720")]
		private static byte ValueToIntegerChar(int value, bool uppercase)
		{
			return default(byte);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2B263E0", Offset = "0x2B223E0", VA = "0x2B263E0")]
		private unsafe static bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2B2639C", Offset = "0x2B2239C", VA = "0x2B2639C")]
		private unsafe static bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2B27BC8", Offset = "0x2B23BC8", VA = "0x2B27BC8")]
		private static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits)
		{
			return default(int);
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2B27D1C", Offset = "0x2B23D1C", VA = "0x2B27D1C")]
		private unsafe static void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2B27A90", Offset = "0x2B23A90", VA = "0x2B27A90")]
		private static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2B27F20", Offset = "0x2B23F20", VA = "0x2B27F20")]
		private unsafe static bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2B27F3C", Offset = "0x2B23F3C", VA = "0x2B27F3C")]
		private static uint LogBase2(uint val)
		{
			return default(uint);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2B2808C", Offset = "0x2B2408C", VA = "0x2B2808C")]
		private static int BigInt_Compare(in tBigInt lhs, in tBigInt rhs)
		{
			return default(int);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2B280E8", Offset = "0x2B240E8", VA = "0x2B280E8")]
		private static void BigInt_Add(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2B2817C", Offset = "0x2B2417C", VA = "0x2B2817C")]
		private static void BigInt_Add_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2B2821C", Offset = "0x2B2421C", VA = "0x2B2821C")]
		private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2B282B0", Offset = "0x2B242B0", VA = "0x2B282B0")]
		private static void BigInt_Multiply_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2B283DC", Offset = "0x2B243DC", VA = "0x2B283DC")]
		private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, uint rhs)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2B2843C", Offset = "0x2B2443C", VA = "0x2B2843C")]
		private static void BigInt_Multiply2(out tBigInt pResult, in tBigInt input)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2B28498", Offset = "0x2B24498", VA = "0x2B28498")]
		private static void BigInt_Multiply2(ref tBigInt pResult)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2B284F0", Offset = "0x2B244F0", VA = "0x2B284F0")]
		private static void BigInt_Multiply10(ref tBigInt pResult)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2B28548", Offset = "0x2B24548", VA = "0x2B28548")]
		private static tBigInt g_PowerOf10_Big(int i)
		{
			return default(tBigInt);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2B2878C", Offset = "0x2B2478C", VA = "0x2B2878C")]
		private static void BigInt_Pow10(out tBigInt pResult, uint exponent)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2B2894C", Offset = "0x2B2494C", VA = "0x2B2894C")]
		private static void BigInt_MultiplyPow10(out tBigInt pResult, in tBigInt input, uint exponent)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2B28B04", Offset = "0x2B24B04", VA = "0x2B28B04")]
		private static void BigInt_Pow2(out tBigInt pResult, uint exponent)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2B28B58", Offset = "0x2B24B58", VA = "0x2B28B58")]
		private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, in tBigInt divisor)
		{
			return default(uint);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2B28CBC", Offset = "0x2B24CBC", VA = "0x2B28CBC")]
		private static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2B28DDC", Offset = "0x2B24DDC", VA = "0x2B28DDC")]
		private unsafe static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent)
		{
			return default(uint);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2B29914", Offset = "0x2B25914", VA = "0x2B29914")]
		private unsafe static void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2B26530", Offset = "0x2B22530", VA = "0x2B26530")]
		private unsafe static void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2B26854", Offset = "0x2B22854", VA = "0x2B26854")]
		private unsafe static void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public readonly struct FunctionPointer<T>
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		private readonly IntPtr _ptr;

		[Token(Token = "0x1700000E")]
		public T Invoke
		{
			[Token(Token = "0x600006E")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x600006D")]
		public FunctionPointer(IntPtr ptr)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public readonly struct SharedStatic<T> where T : struct
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private unsafe readonly void* _buffer;

		[Token(Token = "0x1700000F")]
		public unsafe ref T Data
		{
			[Token(Token = "0x6000070")]
			get
			{
				return ref *(T*)null;
			}
		}

		[Token(Token = "0x600006F")]
		private unsafe SharedStatic(void* buffer)
		{
		}

		[Token(Token = "0x6000071")]
		public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode)
		{
			return default(SharedStatic<T>);
		}
	}
	[Token(Token = "0x200001C")]
	internal static class SharedStatic
	{
		[Token(Token = "0x200001D")]
		internal class PreserveAttribute : Attribute
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2B2A050", Offset = "0x2B26050", VA = "0x2B2A050")]
			public PreserveAttribute()
			{
			}
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2B2A000", Offset = "0x2B26000", VA = "0x2B2A000")]
		[Preserve]
		public unsafe static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment)
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)null);
		}
	}
}
namespace Unity.Burst.Intrinsics
{
	[Token(Token = "0x200001E")]
	public static class Common
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2B2A058", Offset = "0x2B26058", VA = "0x2B2A058")]
		public static ulong umul128(ulong x, ulong y, out ulong high)
		{
			return default(ulong);
		}
	}
	[Token(Token = "0x200001F")]
	[BurstRuntime.Preserve]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	internal sealed class BurstTargetCpuAttribute : Attribute
	{
	}
	[Token(Token = "0x2000020")]
	internal class V64DebugView
	{
	}
	[Token(Token = "0x2000021")]
	internal class V128DebugView
	{
	}
	[Token(Token = "0x2000022")]
	internal class V256DebugView
	{
	}
	[StructLayout(2)]
	[Token(Token = "0x2000023")]
	[DebuggerTypeProxy(typeof(V128DebugView))]
	public struct v128
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte Byte0;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte Byte1;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte Byte2;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte Byte3;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte Byte4;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public byte Byte5;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public byte Byte6;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte Byte7;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte Byte8;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public byte Byte9;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public byte Byte10;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public byte Byte11;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte Byte12;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public byte Byte13;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public byte Byte14;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public byte Byte15;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public sbyte SByte0;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public sbyte SByte1;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public sbyte SByte2;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public sbyte SByte3;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public sbyte SByte4;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public sbyte SByte5;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public sbyte SByte6;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public sbyte SByte7;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public sbyte SByte8;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public sbyte SByte9;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public sbyte SByte10;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public sbyte SByte11;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public sbyte SByte12;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public sbyte SByte13;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public sbyte SByte14;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public sbyte SByte15;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ushort UShort0;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public ushort UShort1;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort UShort2;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort UShort3;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort UShort4;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort UShort5;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort UShort6;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort UShort7;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short SShort0;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public short SShort1;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public short SShort2;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public short SShort3;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public short SShort4;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public short SShort5;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public short SShort6;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public short SShort7;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint UInt0;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint UInt1;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint UInt2;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint UInt3;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int SInt0;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int SInt1;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int SInt2;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int SInt3;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong ULong0;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong ULong1;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long SLong0;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long SLong1;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Float0;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Float1;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Float2;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float Float3;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double Double0;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double Double1;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public v64 Lo64;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public v64 Hi64;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000024")]
	[DebuggerTypeProxy(typeof(V256DebugView))]
	public struct v256
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte Byte0;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte Byte1;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte Byte2;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte Byte3;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte Byte4;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public byte Byte5;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public byte Byte6;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte Byte7;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte Byte8;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public byte Byte9;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public byte Byte10;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public byte Byte11;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte Byte12;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public byte Byte13;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public byte Byte14;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public byte Byte15;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte Byte16;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public byte Byte17;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public byte Byte18;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public byte Byte19;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public byte Byte20;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public byte Byte21;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public byte Byte22;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public byte Byte23;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte Byte24;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public byte Byte25;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public byte Byte26;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public byte Byte27;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public byte Byte28;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public byte Byte29;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public byte Byte30;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		public byte Byte31;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public sbyte SByte0;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public sbyte SByte1;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public sbyte SByte2;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public sbyte SByte3;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public sbyte SByte4;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public sbyte SByte5;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public sbyte SByte6;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public sbyte SByte7;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public sbyte SByte8;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public sbyte SByte9;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public sbyte SByte10;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public sbyte SByte11;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public sbyte SByte12;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public sbyte SByte13;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public sbyte SByte14;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public sbyte SByte15;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public sbyte SByte16;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public sbyte SByte17;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public sbyte SByte18;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public sbyte SByte19;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public sbyte SByte20;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public sbyte SByte21;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public sbyte SByte22;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public sbyte SByte23;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public sbyte SByte24;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public sbyte SByte25;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public sbyte SByte26;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public sbyte SByte27;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public sbyte SByte28;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public sbyte SByte29;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public sbyte SByte30;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		public sbyte SByte31;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ushort UShort0;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public ushort UShort1;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort UShort2;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort UShort3;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort UShort4;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort UShort5;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort UShort6;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort UShort7;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ushort UShort8;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public ushort UShort9;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ushort UShort10;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public ushort UShort11;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ushort UShort12;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public ushort UShort13;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ushort UShort14;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public ushort UShort15;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short SShort0;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public short SShort1;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public short SShort2;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public short SShort3;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public short SShort4;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public short SShort5;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public short SShort6;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public short SShort7;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public short SShort8;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public short SShort9;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public short SShort10;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public short SShort11;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short SShort12;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public short SShort13;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public short SShort14;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public short SShort15;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint UInt0;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint UInt1;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint UInt2;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint UInt3;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint UInt4;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint UInt5;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint UInt6;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint UInt7;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int SInt0;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int SInt1;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int SInt2;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int SInt3;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int SInt4;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SInt5;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SInt6;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int SInt7;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong ULong0;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong ULong1;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong ULong2;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong ULong3;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long SLong0;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long SLong1;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long SLong2;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long SLong3;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Float0;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Float1;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Float2;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float Float3;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Float4;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Float5;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Float6;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Float7;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double Double0;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double Double1;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double Double2;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double Double3;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public v128 Lo128;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public v128 Hi128;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2B2A094", Offset = "0x2B26094", VA = "0x2B2A094")]
		public v256(int v)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2B2A0A0", Offset = "0x2B260A0", VA = "0x2B2A0A0")]
		public v256(v128 lo, v128 hi)
		{
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x2000025")]
	[DebuggerTypeProxy(typeof(V64DebugView))]
	public struct v64
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte Byte0;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte Byte1;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte Byte2;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte Byte3;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte Byte4;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public byte Byte5;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public byte Byte6;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte Byte7;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public sbyte SByte0;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public sbyte SByte1;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public sbyte SByte2;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public sbyte SByte3;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public sbyte SByte4;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public sbyte SByte5;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public sbyte SByte6;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public sbyte SByte7;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ushort UShort0;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public ushort UShort1;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort UShort2;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort UShort3;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short SShort0;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public short SShort1;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public short SShort2;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public short SShort3;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint UInt0;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint UInt1;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int SInt0;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int SInt1;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong ULong0;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long SLong0;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Float0;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Float1;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double Double0;
	}
	[Token(Token = "0x2000026")]
	[BurstCompile]
	public static class X86
	{
		[Token(Token = "0x2000027")]
		public static class Avx
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x2B2A0AC", Offset = "0x2B260AC", VA = "0x2B2A0AC")]
			[DebuggerStepThrough]
			public unsafe static v256 mm256_load_ps(void* ptr)
			{
				return default(v256);
			}

			[Token(Token = "0x6000078")]
			[Address(RVA = "0x2B2A0B8", Offset = "0x2B260B8", VA = "0x2B2A0B8")]
			[DebuggerStepThrough]
			public unsafe static void mm256_store_ps(void* ptr, v256 val)
			{
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x2B2A0C4", Offset = "0x2B260C4", VA = "0x2B2A0C4")]
			[DebuggerStepThrough]
			public unsafe static v256 mm256_loadu_si256(void* ptr)
			{
				return default(v256);
			}

			[Token(Token = "0x600007A")]
			[Address(RVA = "0x2B2A0D0", Offset = "0x2B260D0", VA = "0x2B2A0D0")]
			[DebuggerStepThrough]
			public unsafe static void mm256_storeu_si256(void* ptr, v256 v)
			{
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x2B2A0DC", Offset = "0x2B260DC", VA = "0x2B2A0DC")]
			[DebuggerStepThrough]
			public static v256 mm256_set1_epi32(int a)
			{
				return default(v256);
			}
		}

		[Token(Token = "0x2000028")]
		public static class Avx2
		{
			[Token(Token = "0x17000010")]
			public static bool IsAvx2Supported
			{
				[Token(Token = "0x600007C")]
				[Address(RVA = "0x2B2A0E8", Offset = "0x2B260E8", VA = "0x2B2A0E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x2B2A0F0", Offset = "0x2B260F0", VA = "0x2B2A0F0")]
			[DebuggerStepThrough]
			public static v256 mm256_xor_si256(v256 a, v256 b)
			{
				return default(v256);
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0x2B2A114", Offset = "0x2B26114", VA = "0x2B2A114")]
			[DebuggerStepThrough]
			public static v256 mm256_add_epi64(v256 a, v256 b)
			{
				return default(v256);
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2B2A138", Offset = "0x2B26138", VA = "0x2B2A138")]
			[DebuggerStepThrough]
			public static v256 mm256_mul_epu32(v256 a, v256 b)
			{
				return default(v256);
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0x2B2A180", Offset = "0x2B26180", VA = "0x2B2A180")]
			[DebuggerStepThrough]
			public static v256 mm256_slli_epi64(v256 a, int imm8)
			{
				return default(v256);
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0x2B2A2B4", Offset = "0x2B262B4", VA = "0x2B2A2B4")]
			[DebuggerStepThrough]
			public static v256 mm256_srli_epi64(v256 a, int imm8)
			{
				return default(v256);
			}

			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2B2A3D8", Offset = "0x2B263D8", VA = "0x2B2A3D8")]
			[DebuggerStepThrough]
			public static v256 mm256_shuffle_epi32(v256 a, int imm8)
			{
				return default(v256);
			}
		}

		[Token(Token = "0x2000029")]
		public static class Sse
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2B2A4AC", Offset = "0x2B264AC", VA = "0x2B2A4AC")]
			public static int SHUFFLE(int d, int c, int b, int a)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200002A")]
		public static class Sse2
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2B2A12C", Offset = "0x2B2612C", VA = "0x2B2A12C")]
			[DebuggerStepThrough]
			public static v128 add_epi64(v128 a, v128 b)
			{
				return default(v128);
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0x2B2A174", Offset = "0x2B26174", VA = "0x2B2A174")]
			[DebuggerStepThrough]
			public static v128 mul_epu32(v128 a, v128 b)
			{
				return default(v128);
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0x2B2A1D8", Offset = "0x2B261D8", VA = "0x2B2A1D8")]
			[DebuggerStepThrough]
			public static v128 slli_epi64(v128 a, int imm8)
			{
				return default(v128);
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2B2A30C", Offset = "0x2B2630C", VA = "0x2B2A30C")]
			[DebuggerStepThrough]
			public static v128 srli_epi64(v128 a, int imm8)
			{
				return default(v128);
			}

			[Token(Token = "0x6000088")]
			[Address(RVA = "0x2B2A108", Offset = "0x2B26108", VA = "0x2B2A108")]
			[DebuggerStepThrough]
			public static v128 xor_si128(v128 a, v128 b)
			{
				return default(v128);
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2B2A430", Offset = "0x2B26430", VA = "0x2B2A430")]
			[DebuggerStepThrough]
			public static v128 shuffle_epi32(v128 a, int imm8)
			{
				return default(v128);
			}
		}
	}
}
namespace Unity.Burst.CompilerServices
{
	[Token(Token = "0x200002B")]
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class AssumeRangeAttribute : Attribute
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2B2A4C0", Offset = "0x2B264C0", VA = "0x2B2A4C0")]
		public AssumeRangeAttribute(long min, long max)
		{
		}
	}
}
