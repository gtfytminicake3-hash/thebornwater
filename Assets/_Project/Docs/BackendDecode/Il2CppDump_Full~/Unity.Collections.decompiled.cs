using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2B2A4D0", Offset = "0x2B264D0", VA = "0x2B2A4D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2B2A4D8", Offset = "0x2B264D8", VA = "0x2B2A4D8")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Collections
{
	[Token(Token = "0x2000004")]
	public static class AllocatorManager
	{
		[Token(Token = "0x2000005")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int TryFunction(IntPtr allocatorState, ref Block block);

		[Token(Token = "0x2000006")]
		public struct AllocatorHandle : IAllocator, IDisposable
		{
			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ushort Index;

			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public ushort Version;

			[Token(Token = "0x17000001")]
			internal unsafe ref TableEntry TableEntry
			{
				[Token(Token = "0x6000016")]
				[Address(RVA = "0x2B2A5D0", Offset = "0x2B265D0", VA = "0x2B2A5D0")]
				get
				{
					return ref *(TableEntry*)null;
				}
			}

			[Token(Token = "0x17000002")]
			public int Value
			{
				[Token(Token = "0x6000019")]
				[Address(RVA = "0x2B2AC0C", Offset = "0x2B26C0C", VA = "0x2B2AC0C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000003")]
			public AllocatorHandle Handle
			{
				[Token(Token = "0x600001B")]
				[Address(RVA = "0x2B2A774", Offset = "0x2B26774", VA = "0x2B2A774", Slot = "5")]
				get
				{
					return default(AllocatorHandle);
				}
			}

			[Token(Token = "0x17000004")]
			public Allocator ToAllocator
			{
				[Token(Token = "0x600001C")]
				[Address(RVA = "0x2B2AC7C", Offset = "0x2B26C7C", VA = "0x2B2AC7C", Slot = "7")]
				get
				{
					return default(Allocator);
				}
			}

			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2B2AC08", Offset = "0x2B26C08", VA = "0x2B2AC08")]
			internal void Rewind()
			{
			}

			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2B2A910", Offset = "0x2B26910", VA = "0x2B2A910")]
			public static implicit operator AllocatorHandle(Allocator a)
			{
				return default(AllocatorHandle);
			}

			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2B2AC14", Offset = "0x2B26C14", VA = "0x2B2AC14", Slot = "4")]
			public int Try(ref Block block)
			{
				return default(int);
			}

			[Token(Token = "0x600001D")]
			[Address(RVA = "0x2B2AC84", Offset = "0x2B26C84", VA = "0x2B2AC84", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000007")]
		public struct Range : IDisposable
		{
			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr Pointer;

			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int Items;

			[Token(Token = "0x400000B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public AllocatorHandle Allocator;

			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2B2AC88", Offset = "0x2B26C88", VA = "0x2B2AC88", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000008")]
		public struct Block : IDisposable
		{
			[Token(Token = "0x400000C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Range Range;

			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int BytesPerItem;

			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int AllocatedItems;

			[Token(Token = "0x400000F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte Log2Alignment;

			[Token(Token = "0x4000010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public byte Padding0;

			[Token(Token = "0x4000011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public ushort Padding1;

			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint Padding2;

			[Token(Token = "0x17000005")]
			public long Bytes
			{
				[Token(Token = "0x600001F")]
				[Address(RVA = "0x2B2A8EC", Offset = "0x2B268EC", VA = "0x2B2A8EC")]
				get
				{
					return default(long);
				}
			}

			[Token(Token = "0x17000006")]
			public long AllocatedBytes
			{
				[Token(Token = "0x6000020")]
				[Address(RVA = "0x2B2ACC8", Offset = "0x2B26CC8", VA = "0x2B2ACC8")]
				get
				{
					return default(long);
				}
			}

			[Token(Token = "0x17000007")]
			public int Alignment
			{
				[Token(Token = "0x6000021")]
				[Address(RVA = "0x2B2A900", Offset = "0x2B26900", VA = "0x2B2A900")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000022")]
				[Address(RVA = "0x2B2ACD8", Offset = "0x2B26CD8", VA = "0x2B2ACD8")]
				set
				{
				}
			}

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2B2ACC4", Offset = "0x2B26CC4", VA = "0x2B2ACC4", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2B2AD14", Offset = "0x2B26D14", VA = "0x2B2AD14")]
			public int TryFree()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000009")]
		public interface IAllocator : IDisposable
		{
			[Token(Token = "0x17000008")]
			AllocatorHandle Handle
			{
				[Token(Token = "0x6000026")]
				get;
			}

			[Token(Token = "0x6000025")]
			int Try(ref Block block);
		}

		[Token(Token = "0x200000A")]
		[BurstCompile(CompileSynchronously = true)]
		internal struct StackAllocator : IAllocator, IDisposable
		{
			[Token(Token = "0x200000B")]
			public delegate int Try_00000980$PostfixBurstDelegate(IntPtr allocatorState, ref Block block);

			[Token(Token = "0x200000C")]
			internal static class Try_00000980$BurstDirectCall
			{
				[Token(Token = "0x4000016")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x4000017")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x600002E")]
				[Address(RVA = "0x2B2B060", Offset = "0x2B27060", VA = "0x2B2B060")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x600002F")]
				[Address(RVA = "0x2B2B17C", Offset = "0x2B2717C", VA = "0x2B2B17C")]
				private static IntPtr GetFunctionPointer()
				{
					return default(IntPtr);
				}

				[Token(Token = "0x6000030")]
				[Address(RVA = "0x2B2B1D8", Offset = "0x2B271D8", VA = "0x2B2B1D8")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x6000031")]
				[Address(RVA = "0x2B2AB0C", Offset = "0x2B26B0C", VA = "0x2B2AB0C")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000033")]
				[Address(RVA = "0x2B2AEE0", Offset = "0x2B26EE0", VA = "0x2B2AEE0")]
				public static int Invoke(IntPtr allocatorState, ref Block block)
				{
					return default(int);
				}
			}

			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal AllocatorHandle m_handle;

			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Block m_storage;

			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal long m_top;

			[Token(Token = "0x17000009")]
			public AllocatorHandle Handle
			{
				[Token(Token = "0x6000027")]
				[Address(RVA = "0x2B2ADD0", Offset = "0x2B26DD0", VA = "0x2B2ADD0", Slot = "5")]
				get
				{
					return default(AllocatorHandle);
				}
			}

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2B2ADD8", Offset = "0x2B26DD8", VA = "0x2B2ADD8", Slot = "4")]
			public int Try(ref Block block)
			{
				return default(int);
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2B2AD6C", Offset = "0x2B26D6C", VA = "0x2B2AD6C")]
			[BurstCompile(CompileSynchronously = true)]
			[MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try(IntPtr allocatorState, ref Block block)
			{
				return default(int);
			}

			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2B2AFA0", Offset = "0x2B26FA0", VA = "0x2B2AFA0", Slot = "6")]
			public void Dispose()
			{
			}

			[MethodImpl(256)]
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2B2AFA4", Offset = "0x2B26FA4", VA = "0x2B2AFA4")]
			[MonoPInvokeCallback(typeof(TryFunction))]
			[BurstCompile(CompileSynchronously = true)]
			public static int Try$BurstManaged(IntPtr allocatorState, ref Block block)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200000D")]
		[BurstCompile(CompileSynchronously = true)]
		internal struct SlabAllocator : IAllocator, IDisposable
		{
			[Token(Token = "0x200000E")]
			public delegate int Try_0000098E$PostfixBurstDelegate(IntPtr allocatorState, ref Block block);

			[Token(Token = "0x200000F")]
			internal static class Try_0000098E$BurstDirectCall
			{
				[Token(Token = "0x400001E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x400001F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x600003C")]
				[Address(RVA = "0x2B2B6C8", Offset = "0x2B276C8", VA = "0x2B2B6C8")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x600003D")]
				[Address(RVA = "0x2B2B7E4", Offset = "0x2B277E4", VA = "0x2B2B7E4")]
				private static IntPtr GetFunctionPointer()
				{
					return default(IntPtr);
				}

				[Token(Token = "0x600003E")]
				[Address(RVA = "0x2B2B840", Offset = "0x2B27840", VA = "0x2B2B840")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x600003F")]
				[Address(RVA = "0x2B2AB64", Offset = "0x2B26B64", VA = "0x2B2AB64")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000041")]
				[Address(RVA = "0x2B2B548", Offset = "0x2B27548", VA = "0x2B2B548")]
				public static int Invoke(IntPtr allocatorState, ref Block block)
				{
					return default(int);
				}
			}

			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal AllocatorHandle m_handle;

			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Block Storage;

			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int Log2SlabSizeInBytes;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal FixedList4096Bytes<int> Occupied;

			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1030")]
			internal long budgetInBytes;

			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1038")]
			internal long allocatedBytes;

			[Token(Token = "0x1700000A")]
			public AllocatorHandle Handle
			{
				[Token(Token = "0x6000034")]
				[Address(RVA = "0x2B2B2E8", Offset = "0x2B272E8", VA = "0x2B2B2E8", Slot = "5")]
				get
				{
					return default(AllocatorHandle);
				}
			}

			[Token(Token = "0x1700000B")]
			internal int SlabSizeInBytes
			{
				[Token(Token = "0x6000035")]
				[Address(RVA = "0x2B2B2F0", Offset = "0x2B272F0", VA = "0x2B2B2F0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2B2B300", Offset = "0x2B27300", VA = "0x2B2B300", Slot = "4")]
			public int Try(ref Block block)
			{
				return default(int);
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2B2B284", Offset = "0x2B27284", VA = "0x2B2B284")]
			[BurstCompile(CompileSynchronously = true)]
			[MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try(IntPtr allocatorState, ref Block block)
			{
				return default(int);
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2B2B608", Offset = "0x2B27608", VA = "0x2B2B608", Slot = "6")]
			public void Dispose()
			{
			}

			[MethodImpl(256)]
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2B2B60C", Offset = "0x2B2760C", VA = "0x2B2B60C")]
			[MonoPInvokeCallback(typeof(TryFunction))]
			[BurstCompile(CompileSynchronously = true)]
			public static int Try$BurstManaged(IntPtr allocatorState, ref Block block)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000010")]
		internal struct TableEntry
		{
			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal IntPtr function;

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal IntPtr state;
		}

		[Token(Token = "0x2000011")]
		internal struct Array16<T> where T : struct
		{
			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f0;

			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f1;

			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f2;

			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f3;

			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f4;

			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f5;

			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f6;

			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f7;

			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f8;

			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f9;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f10;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f11;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f12;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f13;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f14;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T f15;
		}

		[Token(Token = "0x2000012")]
		internal struct Array256<T> where T : struct
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f0;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f1;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f2;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f3;

			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f4;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f5;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f6;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f7;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f8;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f9;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f10;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f11;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f12;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f13;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f14;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array16<T> f15;
		}

		[Token(Token = "0x2000013")]
		internal struct Array4096<T> where T : struct
		{
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f0;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f1;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f2;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f3;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f4;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f5;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f6;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f7;

			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f8;

			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f9;

			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f10;

			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f11;

			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f12;

			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f13;

			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f14;

			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array256<T> f15;
		}

		[Token(Token = "0x2000014")]
		internal struct Array32768<T> where T : struct
		{
			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array4096<T> f0;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array4096<T> f1;

			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array4096<T> f2;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array4096<T> f3;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array4096<T> f4;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array4096<T> f5;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array4096<T> f6;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Array4096<T> f7;

			[Token(Token = "0x6000042")]
			public unsafe ref T ElementAt(int index)
			{
				return ref *(T*)null;
			}
		}

		[Token(Token = "0x2000015")]
		internal sealed class SharedStatics
		{
			[Token(Token = "0x2000016")]
			internal sealed class TableEntry
			{
				[Token(Token = "0x400005A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				internal static readonly SharedStatic<Array32768<AllocatorManager.TableEntry>> Ref;
			}
		}

		[Token(Token = "0x2000017")]
		internal static class Managed
		{
			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static TryFunction[] TryFunctionDelegates;
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly AllocatorHandle Invalid;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly AllocatorHandle None;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly AllocatorHandle Temp;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly AllocatorHandle TempJob;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly AllocatorHandle Persistent;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly AllocatorHandle AudioKernel;

		[Token(Token = "0x6000003")]
		internal static Block AllocateBlock<T>(this ref T t, int sizeOf, int alignOf, int items) where T : struct, IAllocator
		{
			return default(Block);
		}

		[Token(Token = "0x6000004")]
		internal unsafe static void* Allocate<T>(this ref T t, int sizeOf, int alignOf, int items) where T : struct, IAllocator
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)null);
		}

		[Token(Token = "0x6000005")]
		internal unsafe static U* Allocate<T, U>(this ref T t, U u, int items) where T : struct, IAllocator where U : struct
		{
			//IL_0002: Expected I, but got O
			return (U*)unchecked((nint)null);
		}

		[Token(Token = "0x6000006")]
		internal static void FreeBlock<T>(this ref T t, ref Block block) where T : struct, IAllocator
		{
		}

		[Token(Token = "0x6000007")]
		internal unsafe static void Free<T>(this ref T t, void* pointer, int sizeOf, int alignOf, int items) where T : struct, IAllocator
		{
		}

		[Token(Token = "0x6000008")]
		internal unsafe static void Free<T, U>(this ref T t, U* pointer, int items) where T : struct, IAllocator where U : struct
		{
		}

		[Token(Token = "0x6000009")]
		public unsafe static void Free<T>(AllocatorHandle handle, T* pointer, int items = 1) where T : struct
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2B2A4E0", Offset = "0x2B264E0", VA = "0x2B2A4E0")]
		[BurstDiscard]
		private static void CheckDelegate(ref bool useDelegate)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2B2A4EC", Offset = "0x2B264EC", VA = "0x2B2A4EC")]
		private static bool UseDelegate()
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2B2A53C", Offset = "0x2B2653C", VA = "0x2B2A53C")]
		private static int allocate_block(ref Block block)
		{
			return default(int);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2B2A668", Offset = "0x2B26668", VA = "0x2B2A668")]
		[BurstDiscard]
		private static void forward_mono_allocate_block(ref Block block, ref int error)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2B2A77C", Offset = "0x2B2677C", VA = "0x2B2A77C")]
		internal static Allocator LegacyOf(AllocatorHandle handle)
		{
			return default(Allocator);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2B2A790", Offset = "0x2B26790", VA = "0x2B2A790")]
		private static int TryLegacy(ref Block block)
		{
			return default(int);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2B2A950", Offset = "0x2B26950", VA = "0x2B2A950")]
		public static int Try(ref Block block)
		{
			return default(int);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2B2AAB8", Offset = "0x2B26AB8", VA = "0x2B2AAB8")]
		public static void Initialize$StackAllocator_Try_00000980$BurstDirectCall()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2B2AB10", Offset = "0x2B26B10", VA = "0x2B2AB10")]
		public static void Initialize$SlabAllocator_Try_0000098E$BurstDirectCall()
		{
		}
	}
	[Token(Token = "0x2000018")]
	internal class CreatePropertyAttribute : Attribute
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2B2B9D0", Offset = "0x2B279D0", VA = "0x2B2B9D0")]
		public CreatePropertyAttribute()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
	public class BurstCompatibleAttribute : Attribute
	{
		[Token(Token = "0x1700000C")]
		public Type[] GenericTypeArguments
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x2B2B9D8", Offset = "0x2B279D8", VA = "0x2B2B9D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2B2B9E0", Offset = "0x2B279E0", VA = "0x2B2B9E0")]
		public BurstCompatibleAttribute()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	public class NotBurstCompatibleAttribute : Attribute
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2B2B9E8", Offset = "0x2B279E8", VA = "0x2B2B9E8")]
		public NotBurstCompatibleAttribute()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[BurstCompatible]
	public static class CollectionHelper
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2B2B9F0", Offset = "0x2B279F0", VA = "0x2B2B9F0")]
		public unsafe static uint Hash(void* ptr, int bytes)
		{
			return default(uint);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2B2BA30", Offset = "0x2B27A30", VA = "0x2B2BA30")]
		internal static bool ShouldDeallocate(AllocatorManager.AllocatorHandle allocator)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2B2BA3C", Offset = "0x2B27A3C", VA = "0x2B2BA3C")]
		internal static int AssumePositive(int value)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200001C")]
	[BurstCompatible]
	internal struct FixedList
	{
		[Token(Token = "0x600004C")]
		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		internal static int PaddingBytes<T>() where T : struct
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList32BytesDebugView<>))]
	[DefaultMember("Item")]
	public struct FixedList32Bytes<T> : IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal ushort length;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal FixedBytes30 buffer;

		[Token(Token = "0x1700000D")]
		[CreateProperty]
		public int Length
		{
			[Token(Token = "0x600004D")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000E")]
		internal int LengthInBytes
		{
			[Token(Token = "0x600004E")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000F")]
		internal unsafe byte* Buffer
		{
			[Token(Token = "0x600004F")]
			get
			{
				//IL_0002: Expected I, but got O
				return (byte*)unchecked((nint)null);
			}
		}

		[Token(Token = "0x6000050")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000051")]
		public int CompareTo(FixedList32Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000052")]
		public bool Equals(FixedList32Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		public int CompareTo(FixedList64Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000054")]
		public bool Equals(FixedList64Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		public int CompareTo(FixedList128Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000056")]
		public bool Equals(FixedList128Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000057")]
		public int CompareTo(FixedList512Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000058")]
		public bool Equals(FixedList512Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		public int CompareTo(FixedList4096Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x600005A")]
		public bool Equals(FixedList4096Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600005B")]
		[NotBurstCompatible]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200001E")]
	internal sealed class FixedList32BytesDebugView<T> where T : struct
	{
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList64BytesDebugView<>))]
	[DefaultMember("Item")]
	public struct FixedList64Bytes<T> : IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal ushort length;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal FixedBytes62 buffer;

		[Token(Token = "0x17000010")]
		[CreateProperty]
		public int Length
		{
			[Token(Token = "0x600005E")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000011")]
		internal int LengthInBytes
		{
			[Token(Token = "0x600005F")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000012")]
		internal unsafe byte* Buffer
		{
			[Token(Token = "0x6000060")]
			get
			{
				//IL_0002: Expected I, but got O
				return (byte*)unchecked((nint)null);
			}
		}

		[Token(Token = "0x6000061")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000062")]
		public int CompareTo(FixedList32Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000063")]
		public bool Equals(FixedList32Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		public int CompareTo(FixedList64Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000065")]
		public bool Equals(FixedList64Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		public int CompareTo(FixedList128Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000067")]
		public bool Equals(FixedList128Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		public int CompareTo(FixedList512Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000069")]
		public bool Equals(FixedList512Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		public int CompareTo(FixedList4096Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x600006B")]
		public bool Equals(FixedList4096Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[NotBurstCompatible]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	internal sealed class FixedList64BytesDebugView<T> where T : struct
	{
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	[DefaultMember("Item")]
	[DebuggerTypeProxy(typeof(FixedList128BytesDebugView<>))]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct FixedList128Bytes<T> : IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal ushort length;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal FixedBytes126 buffer;

		[Token(Token = "0x17000013")]
		[CreateProperty]
		public int Length
		{
			[Token(Token = "0x600006F")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000014")]
		internal int LengthInBytes
		{
			[Token(Token = "0x6000070")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		internal unsafe byte* Buffer
		{
			[Token(Token = "0x6000071")]
			get
			{
				//IL_0002: Expected I, but got O
				return (byte*)unchecked((nint)null);
			}
		}

		[Token(Token = "0x6000072")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000073")]
		public int CompareTo(FixedList32Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000074")]
		public bool Equals(FixedList32Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		public int CompareTo(FixedList64Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000076")]
		public bool Equals(FixedList64Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		public int CompareTo(FixedList128Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000078")]
		public bool Equals(FixedList128Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		public int CompareTo(FixedList512Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x600007A")]
		public bool Equals(FixedList512Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		public int CompareTo(FixedList4096Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x600007C")]
		public bool Equals(FixedList4096Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[NotBurstCompatible]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000022")]
	internal sealed class FixedList128BytesDebugView<T> where T : struct
	{
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	[DebuggerTypeProxy(typeof(FixedList512BytesDebugView<>))]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	[DefaultMember("Item")]
	public struct FixedList512Bytes<T> : IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
	{
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal ushort length;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal FixedBytes510 buffer;

		[Token(Token = "0x17000016")]
		[CreateProperty]
		public int Length
		{
			[Token(Token = "0x6000080")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000017")]
		internal int LengthInBytes
		{
			[Token(Token = "0x6000081")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000018")]
		internal unsafe byte* Buffer
		{
			[Token(Token = "0x6000082")]
			get
			{
				//IL_0002: Expected I, but got O
				return (byte*)unchecked((nint)null);
			}
		}

		[Token(Token = "0x6000083")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000084")]
		public int CompareTo(FixedList32Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000085")]
		public bool Equals(FixedList32Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		public int CompareTo(FixedList64Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000087")]
		public bool Equals(FixedList64Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		public int CompareTo(FixedList128Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000089")]
		public bool Equals(FixedList128Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		public int CompareTo(FixedList512Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x600008B")]
		public bool Equals(FixedList512Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		public int CompareTo(FixedList4096Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x600008D")]
		public bool Equals(FixedList4096Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[NotBurstCompatible]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000024")]
	internal sealed class FixedList512BytesDebugView<T> where T : struct
	{
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	[DebuggerTypeProxy(typeof(FixedList4096BytesDebugView<>))]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct FixedList4096Bytes<T> : IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal ushort length;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal FixedBytes4094 buffer;

		[Token(Token = "0x17000019")]
		[CreateProperty]
		public int Length
		{
			[Token(Token = "0x6000091")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001A")]
		internal int LengthInBytes
		{
			[Token(Token = "0x6000092")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001B")]
		internal unsafe byte* Buffer
		{
			[Token(Token = "0x6000093")]
			get
			{
				//IL_0002: Expected I, but got O
				return (byte*)unchecked((nint)null);
			}
		}

		[Token(Token = "0x1700001C")]
		public T this[int index]
		{
			[Token(Token = "0x6000094")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000095")]
			set
			{
			}
		}

		[Token(Token = "0x6000096")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000097")]
		public int CompareTo(FixedList32Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x6000098")]
		public bool Equals(FixedList32Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		public int CompareTo(FixedList64Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x600009A")]
		public bool Equals(FixedList64Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		public int CompareTo(FixedList128Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x600009C")]
		public bool Equals(FixedList128Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		public int CompareTo(FixedList512Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x600009E")]
		public bool Equals(FixedList512Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		public int CompareTo(FixedList4096Bytes<T> other)
		{
			return default(int);
		}

		[Token(Token = "0x60000A0")]
		public bool Equals(FixedList4096Bytes<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[NotBurstCompatible]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000026")]
	internal sealed class FixedList4096BytesDebugView<T> where T : struct
	{
	}
	[Serializable]
	[StructLayout(2)]
	[Token(Token = "0x2000027")]
	[BurstCompatible]
	public struct FixedBytes16
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte byte0000;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte byte0001;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte byte0002;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte byte0003;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte byte0004;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public byte byte0005;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public byte byte0006;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte byte0007;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte byte0008;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public byte byte0009;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public byte byte0010;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public byte byte0011;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte byte0012;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public byte byte0013;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public byte byte0014;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public byte byte0015;
	}
	[Serializable]
	[StructLayout(2)]
	[Token(Token = "0x2000028")]
	[BurstCompatible]
	public struct FixedBytes30
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FixedBytes16 offset0000;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte byte0016;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public byte byte0017;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public byte byte0018;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public byte byte0019;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public byte byte0020;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public byte byte0021;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public byte byte0022;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public byte byte0023;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte byte0024;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public byte byte0025;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public byte byte0026;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public byte byte0027;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public byte byte0028;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public byte byte0029;
	}
	[Serializable]
	[StructLayout(2)]
	[Token(Token = "0x2000029")]
	[BurstCompatible]
	public struct FixedBytes62
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FixedBytes16 offset0000;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FixedBytes16 offset0016;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FixedBytes16 offset0032;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte byte0048;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public byte byte0049;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public byte byte0050;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public byte byte0051;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public byte byte0052;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public byte byte0053;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public byte byte0054;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public byte byte0055;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public byte byte0056;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public byte byte0057;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public byte byte0058;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public byte byte0059;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public byte byte0060;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public byte byte0061;
	}
	[Serializable]
	[StructLayout(2)]
	[Token(Token = "0x200002A")]
	[BurstCompatible]
	public struct FixedBytes126
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FixedBytes16 offset0000;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FixedBytes16 offset0016;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FixedBytes16 offset0032;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FixedBytes16 offset0048;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FixedBytes16 offset0064;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public FixedBytes16 offset0080;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FixedBytes16 offset0096;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public byte byte0112;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public byte byte0113;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		public byte byte0114;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		public byte byte0115;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public byte byte0116;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public byte byte0117;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		public byte byte0118;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x77")]
		public byte byte0119;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public byte byte0120;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public byte byte0121;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public byte byte0122;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		public byte byte0123;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public byte byte0124;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		public byte byte0125;
	}
	[Serializable]
	[StructLayout(2)]
	[Token(Token = "0x200002B")]
	[BurstCompatible]
	public struct FixedBytes510
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FixedBytes16 offset0000;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FixedBytes16 offset0016;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FixedBytes16 offset0032;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FixedBytes16 offset0048;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FixedBytes16 offset0064;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public FixedBytes16 offset0080;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FixedBytes16 offset0096;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public FixedBytes16 offset0112;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public FixedBytes16 offset0128;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FixedBytes16 offset0144;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FixedBytes16 offset0160;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public FixedBytes16 offset0176;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public FixedBytes16 offset0192;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public FixedBytes16 offset0208;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public FixedBytes16 offset0224;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public FixedBytes16 offset0240;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public FixedBytes16 offset0256;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public FixedBytes16 offset0272;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public FixedBytes16 offset0288;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public FixedBytes16 offset0304;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public FixedBytes16 offset0320;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public FixedBytes16 offset0336;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public FixedBytes16 offset0352;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public FixedBytes16 offset0368;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public FixedBytes16 offset0384;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public FixedBytes16 offset0400;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public FixedBytes16 offset0416;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public FixedBytes16 offset0432;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public FixedBytes16 offset0448;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public FixedBytes16 offset0464;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public FixedBytes16 offset0480;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public byte byte0496;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
		public byte byte0497;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F2")]
		public byte byte0498;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F3")]
		public byte byte0499;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		public byte byte0500;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F5")]
		public byte byte0501;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F6")]
		public byte byte0502;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F7")]
		public byte byte0503;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public byte byte0504;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F9")]
		public byte byte0505;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FA")]
		public byte byte0506;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FB")]
		public byte byte0507;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		public byte byte0508;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FD")]
		public byte byte0509;
	}
	[Serializable]
	[StructLayout(2)]
	[Token(Token = "0x200002C")]
	[BurstCompatible]
	public struct FixedBytes4094
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FixedBytes16 offset0000;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FixedBytes16 offset0016;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FixedBytes16 offset0032;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FixedBytes16 offset0048;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FixedBytes16 offset0064;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public FixedBytes16 offset0080;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FixedBytes16 offset0096;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public FixedBytes16 offset0112;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public FixedBytes16 offset0128;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FixedBytes16 offset0144;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FixedBytes16 offset0160;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public FixedBytes16 offset0176;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public FixedBytes16 offset0192;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public FixedBytes16 offset0208;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public FixedBytes16 offset0224;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public FixedBytes16 offset0240;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public FixedBytes16 offset0256;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public FixedBytes16 offset0272;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public FixedBytes16 offset0288;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public FixedBytes16 offset0304;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public FixedBytes16 offset0320;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public FixedBytes16 offset0336;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public FixedBytes16 offset0352;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public FixedBytes16 offset0368;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public FixedBytes16 offset0384;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public FixedBytes16 offset0400;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public FixedBytes16 offset0416;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public FixedBytes16 offset0432;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public FixedBytes16 offset0448;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public FixedBytes16 offset0464;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public FixedBytes16 offset0480;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public FixedBytes16 offset0496;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public FixedBytes16 offset0512;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public FixedBytes16 offset0528;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public FixedBytes16 offset0544;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public FixedBytes16 offset0560;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public FixedBytes16 offset0576;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public FixedBytes16 offset0592;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		public FixedBytes16 offset0608;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public FixedBytes16 offset0624;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public FixedBytes16 offset0640;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public FixedBytes16 offset0656;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public FixedBytes16 offset0672;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public FixedBytes16 offset0688;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public FixedBytes16 offset0704;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public FixedBytes16 offset0720;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public FixedBytes16 offset0736;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		public FixedBytes16 offset0752;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		public FixedBytes16 offset0768;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		public FixedBytes16 offset0784;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public FixedBytes16 offset0800;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public FixedBytes16 offset0816;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		public FixedBytes16 offset0832;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		public FixedBytes16 offset0848;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		public FixedBytes16 offset0864;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		public FixedBytes16 offset0880;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		public FixedBytes16 offset0896;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		public FixedBytes16 offset0912;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		public FixedBytes16 offset0928;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		public FixedBytes16 offset0944;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		public FixedBytes16 offset0960;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		public FixedBytes16 offset0976;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		public FixedBytes16 offset0992;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		public FixedBytes16 offset1008;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		public FixedBytes16 offset1024;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		public FixedBytes16 offset1040;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		public FixedBytes16 offset1056;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		public FixedBytes16 offset1072;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		public FixedBytes16 offset1088;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		public FixedBytes16 offset1104;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		public FixedBytes16 offset1120;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		public FixedBytes16 offset1136;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		public FixedBytes16 offset1152;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		public FixedBytes16 offset1168;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		public FixedBytes16 offset1184;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		public FixedBytes16 offset1200;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		public FixedBytes16 offset1216;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		public FixedBytes16 offset1232;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		public FixedBytes16 offset1248;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		public FixedBytes16 offset1264;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		public FixedBytes16 offset1280;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		public FixedBytes16 offset1296;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		public FixedBytes16 offset1312;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		public FixedBytes16 offset1328;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		public FixedBytes16 offset1344;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		public FixedBytes16 offset1360;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		public FixedBytes16 offset1376;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		public FixedBytes16 offset1392;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		public FixedBytes16 offset1408;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		public FixedBytes16 offset1424;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		public FixedBytes16 offset1440;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		public FixedBytes16 offset1456;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		public FixedBytes16 offset1472;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		public FixedBytes16 offset1488;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		public FixedBytes16 offset1504;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		public FixedBytes16 offset1520;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		public FixedBytes16 offset1536;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		public FixedBytes16 offset1552;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		public FixedBytes16 offset1568;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x630")]
		public FixedBytes16 offset1584;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x640")]
		public FixedBytes16 offset1600;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x650")]
		public FixedBytes16 offset1616;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x660")]
		public FixedBytes16 offset1632;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x670")]
		public FixedBytes16 offset1648;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x680")]
		public FixedBytes16 offset1664;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x690")]
		public FixedBytes16 offset1680;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
		public FixedBytes16 offset1696;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
		public FixedBytes16 offset1712;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
		public FixedBytes16 offset1728;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
		public FixedBytes16 offset1744;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E0")]
		public FixedBytes16 offset1760;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
		public FixedBytes16 offset1776;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x700")]
		public FixedBytes16 offset1792;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x710")]
		public FixedBytes16 offset1808;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x720")]
		public FixedBytes16 offset1824;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x730")]
		public FixedBytes16 offset1840;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x740")]
		public FixedBytes16 offset1856;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x750")]
		public FixedBytes16 offset1872;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x760")]
		public FixedBytes16 offset1888;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x770")]
		public FixedBytes16 offset1904;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x780")]
		public FixedBytes16 offset1920;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x790")]
		public FixedBytes16 offset1936;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A0")]
		public FixedBytes16 offset1952;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B0")]
		public FixedBytes16 offset1968;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C0")]
		public FixedBytes16 offset1984;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D0")]
		public FixedBytes16 offset2000;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E0")]
		public FixedBytes16 offset2016;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
		public FixedBytes16 offset2032;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x800")]
		public FixedBytes16 offset2048;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x810")]
		public FixedBytes16 offset2064;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x820")]
		public FixedBytes16 offset2080;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x830")]
		public FixedBytes16 offset2096;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x840")]
		public FixedBytes16 offset2112;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x850")]
		public FixedBytes16 offset2128;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x860")]
		public FixedBytes16 offset2144;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x870")]
		public FixedBytes16 offset2160;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x880")]
		public FixedBytes16 offset2176;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x890")]
		public FixedBytes16 offset2192;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A0")]
		public FixedBytes16 offset2208;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B0")]
		public FixedBytes16 offset2224;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C0")]
		public FixedBytes16 offset2240;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D0")]
		public FixedBytes16 offset2256;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E0")]
		public FixedBytes16 offset2272;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8F0")]
		public FixedBytes16 offset2288;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x900")]
		public FixedBytes16 offset2304;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x910")]
		public FixedBytes16 offset2320;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x920")]
		public FixedBytes16 offset2336;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x930")]
		public FixedBytes16 offset2352;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x940")]
		public FixedBytes16 offset2368;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x950")]
		public FixedBytes16 offset2384;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x960")]
		public FixedBytes16 offset2400;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x970")]
		public FixedBytes16 offset2416;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x980")]
		public FixedBytes16 offset2432;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x990")]
		public FixedBytes16 offset2448;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A0")]
		public FixedBytes16 offset2464;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9B0")]
		public FixedBytes16 offset2480;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C0")]
		public FixedBytes16 offset2496;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D0")]
		public FixedBytes16 offset2512;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E0")]
		public FixedBytes16 offset2528;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F0")]
		public FixedBytes16 offset2544;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA00")]
		public FixedBytes16 offset2560;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA10")]
		public FixedBytes16 offset2576;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA20")]
		public FixedBytes16 offset2592;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA30")]
		public FixedBytes16 offset2608;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA40")]
		public FixedBytes16 offset2624;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA50")]
		public FixedBytes16 offset2640;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA60")]
		public FixedBytes16 offset2656;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA70")]
		public FixedBytes16 offset2672;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA80")]
		public FixedBytes16 offset2688;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA90")]
		public FixedBytes16 offset2704;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA0")]
		public FixedBytes16 offset2720;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB0")]
		public FixedBytes16 offset2736;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC0")]
		public FixedBytes16 offset2752;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD0")]
		public FixedBytes16 offset2768;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAE0")]
		public FixedBytes16 offset2784;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAF0")]
		public FixedBytes16 offset2800;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB00")]
		public FixedBytes16 offset2816;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB10")]
		public FixedBytes16 offset2832;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB20")]
		public FixedBytes16 offset2848;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB30")]
		public FixedBytes16 offset2864;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB40")]
		public FixedBytes16 offset2880;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB50")]
		public FixedBytes16 offset2896;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB60")]
		public FixedBytes16 offset2912;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB70")]
		public FixedBytes16 offset2928;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB80")]
		public FixedBytes16 offset2944;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB90")]
		public FixedBytes16 offset2960;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA0")]
		public FixedBytes16 offset2976;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBB0")]
		public FixedBytes16 offset2992;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC0")]
		public FixedBytes16 offset3008;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD0")]
		public FixedBytes16 offset3024;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBE0")]
		public FixedBytes16 offset3040;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBF0")]
		public FixedBytes16 offset3056;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC00")]
		public FixedBytes16 offset3072;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC10")]
		public FixedBytes16 offset3088;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC20")]
		public FixedBytes16 offset3104;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC30")]
		public FixedBytes16 offset3120;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC40")]
		public FixedBytes16 offset3136;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC50")]
		public FixedBytes16 offset3152;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC60")]
		public FixedBytes16 offset3168;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC70")]
		public FixedBytes16 offset3184;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC80")]
		public FixedBytes16 offset3200;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC90")]
		public FixedBytes16 offset3216;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA0")]
		public FixedBytes16 offset3232;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCB0")]
		public FixedBytes16 offset3248;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC0")]
		public FixedBytes16 offset3264;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD0")]
		public FixedBytes16 offset3280;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE0")]
		public FixedBytes16 offset3296;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCF0")]
		public FixedBytes16 offset3312;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD00")]
		public FixedBytes16 offset3328;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD10")]
		public FixedBytes16 offset3344;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD20")]
		public FixedBytes16 offset3360;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD30")]
		public FixedBytes16 offset3376;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD40")]
		public FixedBytes16 offset3392;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD50")]
		public FixedBytes16 offset3408;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD60")]
		public FixedBytes16 offset3424;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD70")]
		public FixedBytes16 offset3440;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD80")]
		public FixedBytes16 offset3456;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD90")]
		public FixedBytes16 offset3472;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA0")]
		public FixedBytes16 offset3488;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDB0")]
		public FixedBytes16 offset3504;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC0")]
		public FixedBytes16 offset3520;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDD0")]
		public FixedBytes16 offset3536;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDE0")]
		public FixedBytes16 offset3552;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDF0")]
		public FixedBytes16 offset3568;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE00")]
		public FixedBytes16 offset3584;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE10")]
		public FixedBytes16 offset3600;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE20")]
		public FixedBytes16 offset3616;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE30")]
		public FixedBytes16 offset3632;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE40")]
		public FixedBytes16 offset3648;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE50")]
		public FixedBytes16 offset3664;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE60")]
		public FixedBytes16 offset3680;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE70")]
		public FixedBytes16 offset3696;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE80")]
		public FixedBytes16 offset3712;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE90")]
		public FixedBytes16 offset3728;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA0")]
		public FixedBytes16 offset3744;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB0")]
		public FixedBytes16 offset3760;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC0")]
		public FixedBytes16 offset3776;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED0")]
		public FixedBytes16 offset3792;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEE0")]
		public FixedBytes16 offset3808;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEF0")]
		public FixedBytes16 offset3824;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF00")]
		public FixedBytes16 offset3840;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF10")]
		public FixedBytes16 offset3856;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF20")]
		public FixedBytes16 offset3872;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF30")]
		public FixedBytes16 offset3888;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF40")]
		public FixedBytes16 offset3904;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF50")]
		public FixedBytes16 offset3920;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF60")]
		public FixedBytes16 offset3936;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF70")]
		public FixedBytes16 offset3952;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF80")]
		public FixedBytes16 offset3968;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF90")]
		public FixedBytes16 offset3984;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA0")]
		public FixedBytes16 offset4000;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB0")]
		public FixedBytes16 offset4016;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC0")]
		public FixedBytes16 offset4032;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD0")]
		public FixedBytes16 offset4048;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFE0")]
		public FixedBytes16 offset4064;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF0")]
		public byte byte4080;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF1")]
		public byte byte4081;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF2")]
		public byte byte4082;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF3")]
		public byte byte4083;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF4")]
		public byte byte4084;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF5")]
		public byte byte4085;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF6")]
		public byte byte4086;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF7")]
		public byte byte4087;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF8")]
		public byte byte4088;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF9")]
		public byte byte4089;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFFA")]
		public byte byte4090;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFFB")]
		public byte byte4091;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFFC")]
		public byte byte4092;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFFD")]
		public byte byte4093;
	}
	[Token(Token = "0x200002D")]
	[BurstCompatible]
	internal struct Memory
	{
		[Token(Token = "0x200002E")]
		[BurstCompatible]
		internal struct Unmanaged
		{
			[Token(Token = "0x200002F")]
			[BurstCompatible]
			internal struct Array
			{
				[Token(Token = "0x60000A7")]
				[Address(RVA = "0x2B2BB1C", Offset = "0x2B27B1C", VA = "0x2B2BB1C")]
				private static bool IsCustom(AllocatorManager.AllocatorHandle allocator)
				{
					return default(bool);
				}

				[Token(Token = "0x60000A8")]
				[Address(RVA = "0x2B2BB28", Offset = "0x2B27B28", VA = "0x2B2BB28")]
				private unsafe static void* CustomResize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align)
				{
					//IL_0002: Expected I, but got O
					return (void*)unchecked((nint)null);
				}

				[Token(Token = "0x60000A9")]
				[Address(RVA = "0x2B2BA40", Offset = "0x2B27A40", VA = "0x2B2BA40")]
				internal unsafe static void* Resize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align)
				{
					//IL_0002: Expected I, but got O
					return (void*)unchecked((nint)null);
				}

				[Token(Token = "0x60000AA")]
				[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
				internal unsafe static T* Resize<T>(T* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator) where T : struct
				{
					//IL_0002: Expected I, but got O
					return (T*)unchecked((nint)null);
				}
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x2B2A914", Offset = "0x2B26914", VA = "0x2B2A914")]
			internal unsafe static void* Allocate(long size, int align, AllocatorManager.AllocatorHandle allocator)
			{
				//IL_0002: Expected I, but got O
				return (void*)unchecked((nint)null);
			}

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2B2A930", Offset = "0x2B26930", VA = "0x2B2A930")]
			internal unsafe static void Free(void* pointer, AllocatorManager.AllocatorHandle allocator)
			{
			}

			[Token(Token = "0x60000A6")]
			[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
			internal unsafe static void Free<T>(T* pointer, AllocatorManager.AllocatorHandle allocator) where T : struct
			{
			}
		}
	}
	[Token(Token = "0x2000030")]
	[BurstCompatible]
	public static class NativeArrayExtensions
	{
		[Token(Token = "0x60000AB")]
		[BurstCompatible(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static bool Contains<T, U>(this NativeList<T> list, U value) where T : struct, IEquatable<U>
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[BurstCompatible(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public unsafe static int IndexOf<T, U>(void* ptr, int length, U value) where T : struct, IEquatable<U>
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000031")]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	[DebuggerDisplay("Length = {Length}")]
	[NativeContainer]
	[DebuggerTypeProxy(typeof(NativeListDebugView<>))]
	public struct NativeList<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<T>* m_ListData;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal AllocatorManager.AllocatorHandle m_DeprecatedAllocator;

		[Token(Token = "0x1700001D")]
		public T this[int index]
		{
			[Token(Token = "0x60000B0")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x1700001E")]
		public int Length
		{
			[Token(Token = "0x60000B1")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000AD")]
		public NativeList(AllocatorManager.AllocatorHandle allocator)
		{
		}

		[Token(Token = "0x60000AE")]
		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
		internal void Initialize<U>(int initialCapacity, ref U allocator, int disposeSentinelStackDepth) where U : struct, AllocatorManager.IAllocator
		{
		}

		[Token(Token = "0x60000AF")]
		private NativeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth)
		{
		}

		[Token(Token = "0x60000B2")]
		public void Add(in T value)
		{
		}

		[Token(Token = "0x60000B3")]
		public void RemoveAtSwapBack(int index)
		{
		}

		[Token(Token = "0x60000B4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000B5")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000B6")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000032")]
	internal sealed class NativeListDebugView<T> where T : struct
	{
	}
	[Token(Token = "0x2000033")]
	internal struct Spinner
	{
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_value;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2B2BC10", Offset = "0x2B27C10", VA = "0x2B2BC10")]
		public void Lock()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2B2BC3C", Offset = "0x2B27C3C", VA = "0x2B2BC3C")]
		public void Unlock()
		{
		}
	}
	[Token(Token = "0x2000034")]
	internal struct UnmanagedArray<T> : IDisposable where T : struct
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_pointer;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_length;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AllocatorManager.AllocatorHandle m_allocator;

		[Token(Token = "0x1700001F")]
		public unsafe ref T this[int index]
		{
			[Token(Token = "0x60000BB")]
			get
			{
				return ref *(T*)null;
			}
		}

		[Token(Token = "0x60000BA")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[BurstCompile]
	public struct RewindableAllocator : AllocatorManager.IAllocator, IDisposable
	{
		[Token(Token = "0x2000036")]
		[BurstCompatible]
		internal struct MemoryBlock : IDisposable
		{
			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public unsafe byte* m_pointer;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long m_bytes;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long m_current;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long m_allocations;

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2B2C238", Offset = "0x2B28238", VA = "0x2B2C238")]
			public MemoryBlock(long bytes)
			{
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x2B2BE30", Offset = "0x2B27E30", VA = "0x2B2BE30")]
			public void Rewind()
			{
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x2B2BDD8", Offset = "0x2B27DD8", VA = "0x2B2BDD8", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x2B2C158", Offset = "0x2B28158", VA = "0x2B2C158")]
			public int TryAllocate(ref AllocatorManager.Block block)
			{
				return default(int);
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2B2C278", Offset = "0x2B28278", VA = "0x2B2C278")]
			public bool Contains(IntPtr ptr)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000037")]
		public delegate int Try_000006E8$PostfixBurstDelegate(IntPtr state, ref AllocatorManager.Block block);

		[Token(Token = "0x2000038")]
		internal static class Try_000006E8$BurstDirectCall
		{
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2B2C43C", Offset = "0x2B2843C", VA = "0x2B2C43C")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2B2C558", Offset = "0x2B28558", VA = "0x2B2C558")]
			private static IntPtr GetFunctionPointer()
			{
				return default(IntPtr);
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2B2C5B4", Offset = "0x2B285B4", VA = "0x2B2C5B4")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2B2C65C", Offset = "0x2B2865C", VA = "0x2B2C65C")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x2B2C2B8", Offset = "0x2B282B8", VA = "0x2B2C2B8")]
			public static int Invoke(IntPtr state, ref AllocatorManager.Block block)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Spinner m_spinner;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private AllocatorManager.AllocatorHandle m_handle;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private UnmanagedArray<MemoryBlock> m_block;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_best;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_last;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_used;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_enableBlockFree;

		[Token(Token = "0x17000020")]
		public AllocatorManager.AllocatorHandle Handle
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2B2C378", Offset = "0x2B28378", VA = "0x2B2C378", Slot = "5")]
			get
			{
				return default(AllocatorManager.AllocatorHandle);
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2B2BCD4", Offset = "0x2B27CD4", VA = "0x2B2BCD4")]
		public void Rewind()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2B2BE38", Offset = "0x2B27E38", VA = "0x2B2BE38", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2B2BF14", Offset = "0x2B27F14", VA = "0x2B2BF14", Slot = "4")]
		public int Try(ref AllocatorManager.Block block)
		{
			return default(int);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2B2BC70", Offset = "0x2B27C70", VA = "0x2B2BC70")]
		[MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		[BurstCompile]
		internal static int Try(IntPtr state, ref AllocatorManager.Block block)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2B2C380", Offset = "0x2B28380", VA = "0x2B2C380")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		public static int Try$BurstManaged(IntPtr state, ref AllocatorManager.Block block)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000039")]
	[BurstCompatible]
	[BurstCompile]
	[BurstCompatible]
	[BurstCompatible]
	public static class xxHash3
	{
		[Token(Token = "0x200003A")]
		public unsafe delegate ulong Hash64Long_0000071F$PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret);

		[Token(Token = "0x200003B")]
		internal static class Hash64Long_0000071F$BurstDirectCall
		{
			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2B2DAC8", Offset = "0x2B29AC8", VA = "0x2B2DAC8")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2B2DBE4", Offset = "0x2B29BE4", VA = "0x2B2DBE4")]
			private static IntPtr GetFunctionPointer()
			{
				return default(IntPtr);
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x2B2DC40", Offset = "0x2B29C40", VA = "0x2B2DC40")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x2B2DCE8", Offset = "0x2B29CE8", VA = "0x2B2DCE8")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x2B2CFEC", Offset = "0x2B28FEC", VA = "0x2B2CFEC")]
			public unsafe static ulong Invoke(byte* input, byte* dest, long length, byte* secret)
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x200003C")]
		public unsafe delegate void Hash128Long_00000726$PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret, out uint4 result);

		[Token(Token = "0x200003D")]
		internal static class Hash128Long_00000726$BurstDirectCall
		{
			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x2B2DDA4", Offset = "0x2B29DA4", VA = "0x2B2DDA4")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x2B2DEC0", Offset = "0x2B29EC0", VA = "0x2B2DEC0")]
			private static IntPtr GetFunctionPointer()
			{
				return default(IntPtr);
			}

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x2B2DF1C", Offset = "0x2B29F1C", VA = "0x2B2DF1C")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x2B2DFC4", Offset = "0x2B29FC4", VA = "0x2B2DFC4")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x2B2D268", Offset = "0x2B29268", VA = "0x2B2D268")]
			public unsafe static void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result)
			{
			}
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2B2C664", Offset = "0x2B28664", VA = "0x2B2C664")]
		internal unsafe static void Avx2HashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2B2C82C", Offset = "0x2B2882C", VA = "0x2B2C82C")]
		internal unsafe static void Avx2ScrambleAcc(ulong* acc, byte* secret)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2B2C798", Offset = "0x2B28798", VA = "0x2B2C798")]
		internal unsafe static void Avx2Accumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2B2CBD0", Offset = "0x2B28BD0", VA = "0x2B2CBD0")]
		internal unsafe static void Avx2Accumulate512(ulong* acc, byte* input, byte* dest, byte* secret)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2B2CF70", Offset = "0x2B28F70", VA = "0x2B2CF70")]
		[BurstCompile]
		private unsafe static ulong Hash64Long(byte* input, byte* dest, long length, byte* secret)
		{
			return default(ulong);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2B2D1E4", Offset = "0x2B291E4", VA = "0x2B2D1E4")]
		[BurstCompile]
		private unsafe static void Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2B2D354", Offset = "0x2B29354", VA = "0x2B2D354")]
		internal static uint4 ToUint4(ulong ul0, ulong ul1)
		{
			return default(uint4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2B2D358", Offset = "0x2B29358", VA = "0x2B2D358")]
		private unsafe static ulong Read64LE(void* addr)
		{
			return default(ulong);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2B2D360", Offset = "0x2B29360", VA = "0x2B2D360")]
		private unsafe static void Write64LE(void* addr, ulong value)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2B2D368", Offset = "0x2B29368", VA = "0x2B2D368")]
		private static ulong Mul32To64(uint x, uint y)
		{
			return default(ulong);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2B2D370", Offset = "0x2B29370", VA = "0x2B2D370")]
		private static ulong XorShift64(ulong v64, int shift)
		{
			return default(ulong);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2B2D37C", Offset = "0x2B2937C", VA = "0x2B2D37C")]
		private static ulong Mul128Fold64(ulong lhs, ulong rhs)
		{
			return default(ulong);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2B2D39C", Offset = "0x2B2939C", VA = "0x2B2D39C")]
		private static ulong Avalanche(ulong h64)
		{
			return default(ulong);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2B2D3BC", Offset = "0x2B293BC", VA = "0x2B2D3BC")]
		private unsafe static ulong Mix2Acc(ulong acc0, ulong acc1, byte* secret)
		{
			return default(ulong);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2B2D3E8", Offset = "0x2B293E8", VA = "0x2B2D3E8")]
		internal unsafe static ulong MergeAcc(ulong* acc, byte* secret, ulong start)
		{
			return default(ulong);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2B2D4E4", Offset = "0x2B294E4", VA = "0x2B2D4E4")]
		private unsafe static void DefaultHashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2B2D648", Offset = "0x2B29648", VA = "0x2B2D648")]
		internal unsafe static void DefaultAccumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2B2D704", Offset = "0x2B29704", VA = "0x2B2D704")]
		internal unsafe static void DefaultAccumulate512(ulong* acc, byte* input, byte* dest, byte* secret, int isHash64)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2B2D6D0", Offset = "0x2B296D0", VA = "0x2B2D6D0")]
		internal unsafe static void DefaultScrambleAcc(ulong* acc, byte* secret)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2B2D754", Offset = "0x2B29754", VA = "0x2B2D754")]
		[BurstCompile]
		public unsafe static ulong Hash64Long$BurstManaged(byte* input, byte* dest, long length, byte* secret)
		{
			return default(ulong);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2B2D8A0", Offset = "0x2B298A0", VA = "0x2B2D8A0")]
		[BurstCompile]
		public unsafe static void Hash128Long$BurstManaged(byte* input, byte* dest, long length, byte* secret, out uint4 result)
		{
		}
	}
}
namespace Unity.Collections.LowLevel.Unsafe
{
	[Token(Token = "0x200003E")]
	[BurstCompatible]
	public static class NativeListUnsafeUtility
	{
		[Token(Token = "0x60000F4")]
		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeList<T> list) where T : struct
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)null);
		}
	}
	[Token(Token = "0x200003F")]
	[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(UnsafeListTDebugView<>))]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct UnsafeList<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe T* Ptr;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_length;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_capacity;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AllocatorManager.AllocatorHandle Allocator;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Obsolete("Use Length property (UnityUpgradable) -> Length", true)]
		public int length;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Obsolete("Use Capacity property (UnityUpgradable) -> Capacity", true)]
		public int capacity;

		[Token(Token = "0x17000021")]
		public int Length
		{
			[Token(Token = "0x60000F5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000022")]
		public int Capacity
		{
			[Token(Token = "0x60000F6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000023")]
		public T this[int index]
		{
			[Token(Token = "0x60000F7")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x60000F8")]
		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
		internal unsafe static UnsafeList<T>* Create<U>(int initialCapacity, ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory) where U : struct, AllocatorManager.IAllocator
		{
			//IL_0002: Expected I, but got O
			return (UnsafeList<T>*)unchecked((nint)null);
		}

		[Token(Token = "0x60000F9")]
		public unsafe static void Destroy(UnsafeList<T>* listData)
		{
		}

		[Token(Token = "0x60000FA")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000FB")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000FC")]
		public void Resize(int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
		{
		}

		[Token(Token = "0x60000FD")]
		private void Realloc<U>(ref U allocator, int newCapacity) where U : struct, AllocatorManager.IAllocator
		{
		}

		[Token(Token = "0x60000FE")]
		private void SetCapacity<U>(ref U allocator, int capacity) where U : struct, AllocatorManager.IAllocator
		{
		}

		[Token(Token = "0x60000FF")]
		public void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000100")]
		public void Add(in T value)
		{
		}

		[Token(Token = "0x6000101")]
		public void RemoveAtSwapBack(int index)
		{
		}

		[Token(Token = "0x6000102")]
		public void RemoveRangeSwapBack(int index, int count)
		{
		}

		[Token(Token = "0x6000103")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000040")]
	internal sealed class UnsafeListTDebugView<T> where T : struct
	{
	}
}
[Token(Token = "0x2000041")]
internal static class $BurstDirectCallInitializer
{
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2B2DFCC", Offset = "0x2B29FCC", VA = "0x2B2DFCC")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
	}
}
