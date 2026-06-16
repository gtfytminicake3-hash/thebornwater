using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

[assembly: AssemblyVersion("1.0.0.0")]
namespace Unity.IL2CPP.CompilerServices
{
	[Token(Token = "0x2000002")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
	internal class Il2CppEagerStaticClassConstructionAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2B2E208", Offset = "0x2B2A208", VA = "0x2B2E208")]
		public Il2CppEagerStaticClassConstructionAttribute()
		{
		}
	}
}
namespace Unity.Mathematics
{
	[Serializable]
	[Token(Token = "0x2000003")]
	[DefaultMember("Item")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	public struct bool2 : IEquatable<bool2>
	{
		[Token(Token = "0x2000004")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool x;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool y;

		[MethodImpl(256)]
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2B2E210", Offset = "0x2B2A210", VA = "0x2B2E210")]
		public bool2(bool x, bool y)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2B2E21C", Offset = "0x2B2A21C", VA = "0x2B2E21C", Slot = "4")]
		public bool Equals(bool2 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2B2E248", Offset = "0x2B2A248", VA = "0x2B2E248", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2B2E2D4", Offset = "0x2B2A2D4", VA = "0x2B2E2D4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2B2E310", Offset = "0x2B2A310", VA = "0x2B2E310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000005")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public static class math
	{
		[StructLayout(2)]
		[Token(Token = "0x2000006")]
		internal struct IntFloatUnion
		{
			[Token(Token = "0x4000003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int intValue;

			[Token(Token = "0x4000004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float floatValue;
		}

		[StructLayout(2)]
		[Token(Token = "0x2000007")]
		internal struct LongDoubleUnion
		{
			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long longValue;

			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double doubleValue;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2B2E3B0", Offset = "0x2B2A3B0", VA = "0x2B2E3B0")]
		public static uint hash(bool2 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2B2E3E8", Offset = "0x2B2A3E8", VA = "0x2B2E3E8")]
		public static uint hash(double2 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2B2E42C", Offset = "0x2B2A42C", VA = "0x2B2E42C")]
		public static float2 float2(float x, float y)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2B2E430", Offset = "0x2B2A430", VA = "0x2B2E430")]
		public static uint hash(float2 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2B2E464", Offset = "0x2B2A464", VA = "0x2B2E464")]
		public static float2x2 float2x2(float2 c0, float2 c1)
		{
			return default(float2x2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2B2E468", Offset = "0x2B2A468", VA = "0x2B2E468")]
		public static float determinant(float2x2 m)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2B2E478", Offset = "0x2B2A478", VA = "0x2B2E478")]
		public static uint hash(float2x2 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2B2E4D0", Offset = "0x2B2A4D0", VA = "0x2B2E4D0")]
		public static float3 float3(float x, float y, float z)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2B2E4D4", Offset = "0x2B2A4D4", VA = "0x2B2E4D4")]
		public static float3 float3(float x, float2 yz)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2B2E4D8", Offset = "0x2B2A4D8", VA = "0x2B2E4D8")]
		public static float3 float3(float2 xy, float z)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2B2E4DC", Offset = "0x2B2A4DC", VA = "0x2B2E4DC")]
		public static uint hash(float3 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2B2E524", Offset = "0x2B2A524", VA = "0x2B2E524")]
		public static uint hash(float3x3 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2B2E5C4", Offset = "0x2B2A5C4", VA = "0x2B2E5C4")]
		public static float4 float4(float x, float y, float z, float w)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2B2E5C8", Offset = "0x2B2A5C8", VA = "0x2B2E5C8")]
		public static float4 float4(float2 xy, float z, float w)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2B2E5CC", Offset = "0x2B2A5CC", VA = "0x2B2E5CC")]
		public static float4 float4(float2 xy, float2 zw)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2B2E5D0", Offset = "0x2B2A5D0", VA = "0x2B2E5D0")]
		public static float4 float4(float3 xyz, float w)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2B2E5D4", Offset = "0x2B2A5D4", VA = "0x2B2E5D4")]
		public static uint hash(float4 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2B2E634", Offset = "0x2B2A634", VA = "0x2B2E634")]
		public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
			return default(float4x4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2B2E658", Offset = "0x2B2A658", VA = "0x2B2E658")]
		public static uint hash(float4x4 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2B2E784", Offset = "0x2B2A784", VA = "0x2B2E784")]
		public static int2 int2(int x, int y)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2B2E790", Offset = "0x2B2A790", VA = "0x2B2E790")]
		public static uint hash(int2 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2B2E7C0", Offset = "0x2B2A7C0", VA = "0x2B2E7C0")]
		public static uint hash(int3 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2B2E800", Offset = "0x2B2A800", VA = "0x2B2E800")]
		public static uint hash(int4 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2B2E858", Offset = "0x2B2A858", VA = "0x2B2E858")]
		public static int asint(float x)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2B2E860", Offset = "0x2B2A860", VA = "0x2B2E860")]
		public static uint2 asuint(int2 x)
		{
			return default(uint2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2B2E864", Offset = "0x2B2A864", VA = "0x2B2E864")]
		public static uint3 asuint(int3 x)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2B2E86C", Offset = "0x2B2A86C", VA = "0x2B2E86C")]
		public static uint4 asuint(int4 x)
		{
			return default(uint4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2B2E870", Offset = "0x2B2A870", VA = "0x2B2E870")]
		public static uint asuint(float x)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2B2E878", Offset = "0x2B2A878", VA = "0x2B2E878")]
		public static uint2 asuint(float2 x)
		{
			return default(uint2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2B2E888", Offset = "0x2B2A888", VA = "0x2B2E888")]
		public static uint3 asuint(float3 x)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2B2E89C", Offset = "0x2B2A89C", VA = "0x2B2E89C")]
		public static uint4 asuint(float4 x)
		{
			return default(uint4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2B2E8B8", Offset = "0x2B2A8B8", VA = "0x2B2E8B8")]
		public static long aslong(double x)
		{
			return default(long);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2B2E8C0", Offset = "0x2B2A8C0", VA = "0x2B2E8C0")]
		public static ulong asulong(double x)
		{
			return default(ulong);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2B2E8C8", Offset = "0x2B2A8C8", VA = "0x2B2E8C8")]
		public static float asfloat(int x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2B2E8D0", Offset = "0x2B2A8D0", VA = "0x2B2E8D0")]
		public static float asfloat(uint x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2B2E8D8", Offset = "0x2B2A8D8", VA = "0x2B2E8D8")]
		public static float3 asfloat(uint3 x)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2B2E8EC", Offset = "0x2B2A8EC", VA = "0x2B2E8EC")]
		public static double asdouble(long x)
		{
			return default(double);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2B2E8F4", Offset = "0x2B2A8F4", VA = "0x2B2E8F4")]
		public static double asdouble(ulong x)
		{
			return default(double);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2B2E8FC", Offset = "0x2B2A8FC", VA = "0x2B2E8FC")]
		public static bool isinf(double x)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2B2E914", Offset = "0x2B2A914", VA = "0x2B2E914")]
		public static int min(int x, int y)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2B2E920", Offset = "0x2B2A920", VA = "0x2B2E920")]
		public static uint min(uint x, uint y)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2B2E92C", Offset = "0x2B2A92C", VA = "0x2B2E92C")]
		public static long min(long x, long y)
		{
			return default(long);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2B2E938", Offset = "0x2B2A938", VA = "0x2B2E938")]
		public static float min(float x, float y)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2B2E954", Offset = "0x2B2A954", VA = "0x2B2E954")]
		public static float2 min(float2 x, float2 y)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2B2E984", Offset = "0x2B2A984", VA = "0x2B2E984")]
		public static float3 min(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2B2E9C8", Offset = "0x2B2A9C8", VA = "0x2B2E9C8")]
		public static double min(double x, double y)
		{
			return default(double);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2B2E9E4", Offset = "0x2B2A9E4", VA = "0x2B2E9E4")]
		public static double2 min(double2 x, double2 y)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2B2EA14", Offset = "0x2B2AA14", VA = "0x2B2EA14")]
		public static int max(int x, int y)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2B2EA20", Offset = "0x2B2AA20", VA = "0x2B2EA20")]
		public static int2 max(int2 x, int2 y)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2B2EA40", Offset = "0x2B2AA40", VA = "0x2B2EA40")]
		public static uint max(uint x, uint y)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2B2EA4C", Offset = "0x2B2AA4C", VA = "0x2B2EA4C")]
		public static long max(long x, long y)
		{
			return default(long);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2B2EA58", Offset = "0x2B2AA58", VA = "0x2B2EA58")]
		public static float max(float x, float y)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2B2EA74", Offset = "0x2B2AA74", VA = "0x2B2EA74")]
		public static float2 max(float2 x, float2 y)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2B2EAA4", Offset = "0x2B2AAA4", VA = "0x2B2EAA4")]
		public static float3 max(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2B2EAE8", Offset = "0x2B2AAE8", VA = "0x2B2EAE8")]
		public static float lerp(float x, float y, float s)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2B2EAF8", Offset = "0x2B2AAF8", VA = "0x2B2EAF8")]
		public static float3 lerp(float3 x, float3 y, float s)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2B2EB20", Offset = "0x2B2AB20", VA = "0x2B2EB20")]
		public static int clamp(int x, int a, int b)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2B2EB34", Offset = "0x2B2AB34", VA = "0x2B2EB34")]
		public static float clamp(float x, float a, float b)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2B2EB64", Offset = "0x2B2AB64", VA = "0x2B2EB64")]
		public static int abs(int x)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2B2EB70", Offset = "0x2B2AB70", VA = "0x2B2EB70")]
		public static float abs(float x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2B2EB78", Offset = "0x2B2AB78", VA = "0x2B2EB78")]
		public static double abs(double x)
		{
			return default(double);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2B2EB80", Offset = "0x2B2AB80", VA = "0x2B2EB80")]
		public static float dot(float2 x, float2 y)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2B2EB90", Offset = "0x2B2AB90", VA = "0x2B2EB90")]
		public static float dot(float3 x, float3 y)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2B2EBA8", Offset = "0x2B2ABA8", VA = "0x2B2EBA8")]
		public static float dot(float4 x, float4 y)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2B2EBC8", Offset = "0x2B2ABC8", VA = "0x2B2EBC8")]
		public static double dot(double2 x, double2 y)
		{
			return default(double);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2B2EBD8", Offset = "0x2B2ABD8", VA = "0x2B2EBD8")]
		public static float atan(float x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2B2EC3C", Offset = "0x2B2AC3C", VA = "0x2B2EC3C")]
		public static float2 atan(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2B2ECE8", Offset = "0x2B2ACE8", VA = "0x2B2ECE8")]
		public static float cos(float x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2B2ED4C", Offset = "0x2B2AD4C", VA = "0x2B2ED4C")]
		public static float3 cos(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2B2EE40", Offset = "0x2B2AE40", VA = "0x2B2EE40")]
		public static float sin(float x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2B2EEA4", Offset = "0x2B2AEA4", VA = "0x2B2EEA4")]
		public static float3 sin(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2B2EF98", Offset = "0x2B2AF98", VA = "0x2B2EF98")]
		public static float rcp(float x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2B2EFA4", Offset = "0x2B2AFA4", VA = "0x2B2EFA4")]
		public static float2 rcp(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2B2EFB4", Offset = "0x2B2AFB4", VA = "0x2B2EFB4")]
		public static float pow(float x, float y)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2B2F024", Offset = "0x2B2B024", VA = "0x2B2F024")]
		public static float log2(float x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2B2F090", Offset = "0x2B2B090", VA = "0x2B2F090")]
		public static float sqrt(float x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2B2F0EC", Offset = "0x2B2B0EC", VA = "0x2B2F0EC")]
		public static double sqrt(double x)
		{
			return default(double);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2B2F148", Offset = "0x2B2B148", VA = "0x2B2F148")]
		public static float rsqrt(float x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2B2F1A4", Offset = "0x2B2B1A4", VA = "0x2B2F1A4")]
		public static float2 normalize(float2 x)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2B2F218", Offset = "0x2B2B218", VA = "0x2B2F218")]
		public static float3 normalize(float3 x)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2B2F2A4", Offset = "0x2B2B2A4", VA = "0x2B2F2A4")]
		public static float length(float2 x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2B2F308", Offset = "0x2B2B308", VA = "0x2B2F308")]
		public static float length(float3 x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2B2F380", Offset = "0x2B2B380", VA = "0x2B2F380")]
		public static float length(float4 x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2B2F404", Offset = "0x2B2B404", VA = "0x2B2F404")]
		public static double length(double2 x)
		{
			return default(double);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2B2F468", Offset = "0x2B2B468", VA = "0x2B2F468")]
		public static float lengthsq(float2 x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2B2F478", Offset = "0x2B2B478", VA = "0x2B2F478")]
		public static float lengthsq(float3 x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2B2F490", Offset = "0x2B2B490", VA = "0x2B2F490")]
		public static float lengthsq(float4 x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2B2F4B0", Offset = "0x2B2B4B0", VA = "0x2B2F4B0")]
		public static float distance(float2 x, float2 y)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2B2F52C", Offset = "0x2B2B52C", VA = "0x2B2F52C")]
		public static double distance(double2 x, double2 y)
		{
			return default(double);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2B2F5A8", Offset = "0x2B2B5A8", VA = "0x2B2F5A8")]
		public static float distancesq(float3 x, float3 y)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2B2F5CC", Offset = "0x2B2B5CC", VA = "0x2B2F5CC")]
		public static float distancesq(float4 x, float4 y)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2B2F5FC", Offset = "0x2B2B5FC", VA = "0x2B2F5FC")]
		public static float3 cross(float3 x, float3 y)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2B2F624", Offset = "0x2B2B624", VA = "0x2B2F624")]
		public static bool any(bool2 x)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2B2F634", Offset = "0x2B2B634", VA = "0x2B2F634")]
		public static bool any(float2 x)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2B2F648", Offset = "0x2B2B648", VA = "0x2B2F648")]
		public static uint select(uint a, uint b, bool c)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2B2F654", Offset = "0x2B2B654", VA = "0x2B2F654")]
		public static uint2 select(uint2 a, uint2 b, bool2 c)
		{
			return default(uint2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2B2F66C", Offset = "0x2B2B66C", VA = "0x2B2F66C")]
		public static void sincos(float3 x, out float3 s, out float3 c)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2B2F6D0", Offset = "0x2B2B6D0", VA = "0x2B2F6D0")]
		public static int lzcnt(int x)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2B2F70C", Offset = "0x2B2B70C", VA = "0x2B2F70C")]
		public static int lzcnt(uint x)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2B2F748", Offset = "0x2B2B748", VA = "0x2B2F748")]
		public static int tzcnt(int x)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2B2F784", Offset = "0x2B2B784", VA = "0x2B2F784")]
		public static int tzcnt(uint x)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2B2F7C0", Offset = "0x2B2B7C0", VA = "0x2B2F7C0")]
		public static int tzcnt(ulong x)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2B2F814", Offset = "0x2B2B814", VA = "0x2B2F814")]
		public static int ceilpow2(int x)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2B2F834", Offset = "0x2B2B834", VA = "0x2B2F834")]
		public static int2 ceilpow2(int2 x)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2B2F8BC", Offset = "0x2B2B8BC", VA = "0x2B2F8BC")]
		public static long ceilpow2(long x)
		{
			return default(long);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2B2F8E0", Offset = "0x2B2B8E0", VA = "0x2B2F8E0")]
		public static int ceillog2(int x)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2B2F918", Offset = "0x2B2B918", VA = "0x2B2F918")]
		public static int floorlog2(int x)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2B2F950", Offset = "0x2B2B950", VA = "0x2B2F950")]
		public static float radians(float x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2B2F960", Offset = "0x2B2B960", VA = "0x2B2F960")]
		public static uint csum(uint2 x)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2B2F96C", Offset = "0x2B2B96C", VA = "0x2B2F96C")]
		public static uint csum(uint3 x)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2B2F97C", Offset = "0x2B2B97C", VA = "0x2B2F97C")]
		public static uint csum(uint4 x)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2B2F994", Offset = "0x2B2B994", VA = "0x2B2F994")]
		public static float csum(float3 x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2B2F9A0", Offset = "0x2B2B9A0", VA = "0x2B2F9A0")]
		public static float f16tof32(uint x)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2B2F9F8", Offset = "0x2B2B9F8", VA = "0x2B2F9F8")]
		internal static uint fold_to_uint(double x)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2B2FA08", Offset = "0x2B2BA08", VA = "0x2B2FA08")]
		internal static uint2 fold_to_uint(double2 x)
		{
			return default(uint2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2B2FA28", Offset = "0x2B2BA28", VA = "0x2B2FA28")]
		public static float3x3 float3x3(quaternion rotation)
		{
			return default(float3x3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2B2FB18", Offset = "0x2B2BB18", VA = "0x2B2FB18")]
		public static float4 mul(float4x4 a, float4 b)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2B2FB4C", Offset = "0x2B2BB4C", VA = "0x2B2FB4C")]
		public static float4x4 mul(float4x4 a, float4x4 b)
		{
			return default(float4x4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2B2FBF0", Offset = "0x2B2BBF0", VA = "0x2B2FBF0")]
		public static quaternion quaternion(float4 value)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2B2FBF4", Offset = "0x2B2BBF4", VA = "0x2B2FBF4")]
		public static quaternion mul(quaternion a, quaternion b)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2B2FC68", Offset = "0x2B2BC68", VA = "0x2B2FC68")]
		public static uint hash(quaternion q)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2B2FCC8", Offset = "0x2B2BCC8", VA = "0x2B2FCC8")]
		public static uint2 uint2(uint x, uint y)
		{
			return default(uint2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2B2FCD4", Offset = "0x2B2BCD4", VA = "0x2B2FCD4")]
		public static uint hash(uint2 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2B2FD04", Offset = "0x2B2BD04", VA = "0x2B2FD04")]
		public static uint3 uint3(uint x, uint y, uint z)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2B2FD14", Offset = "0x2B2BD14", VA = "0x2B2FD14")]
		public static uint hash(uint3 v)
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2B2FD54", Offset = "0x2B2BD54", VA = "0x2B2FD54")]
		public static uint4 uint4(uint x, uint y, uint z, uint w)
		{
			return default(uint4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2B2FD6C", Offset = "0x2B2BD6C", VA = "0x2B2FD6C")]
		public static uint hash(uint4 v)
		{
			return default(uint);
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	public struct double2 : IEquatable<double2>, IFormattable
	{
		[Token(Token = "0x2000009")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly double2 zero;

		[MethodImpl(256)]
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2B2FDC4", Offset = "0x2B2BDC4", VA = "0x2B2FDC4")]
		public double2(double x, double y)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2B2FDCC", Offset = "0x2B2BDCC", VA = "0x2B2FDCC")]
		public double2(float2 v)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2B2FDDC", Offset = "0x2B2BDDC", VA = "0x2B2FDDC")]
		public static implicit operator double2(float2 v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2B2FDE8", Offset = "0x2B2BDE8", VA = "0x2B2FDE8")]
		public static double2 operator -(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2B2FDF4", Offset = "0x2B2BDF4", VA = "0x2B2FDF4", Slot = "4")]
		public bool Equals(double2 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2B2FE18", Offset = "0x2B2BE18", VA = "0x2B2FE18", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2B2FEA0", Offset = "0x2B2BEA0", VA = "0x2B2FEA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2B2FEE0", Offset = "0x2B2BEE0", VA = "0x2B2FEE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2B2FF88", Offset = "0x2B2BF88", VA = "0x2B2FF88", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	public struct float2 : IEquatable<float2>, IFormattable
	{
		[Token(Token = "0x200000B")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float2 zero;

		[MethodImpl(256)]
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2B30018", Offset = "0x2B2C018", VA = "0x2B30018")]
		public float2(float x, float y)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2B30020", Offset = "0x2B2C020", VA = "0x2B30020")]
		public float2(int2 v)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2B30034", Offset = "0x2B2C034", VA = "0x2B30034")]
		public float2(uint2 v)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2B30048", Offset = "0x2B2C048", VA = "0x2B30048")]
		public static implicit operator float2(int2 v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2B30058", Offset = "0x2B2C058", VA = "0x2B30058")]
		public static implicit operator float2(uint2 v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2B30068", Offset = "0x2B2C068", VA = "0x2B30068")]
		public static float2 operator *(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2B30074", Offset = "0x2B2C074", VA = "0x2B30074")]
		public static float2 operator *(float2 lhs, float rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2B30080", Offset = "0x2B2C080", VA = "0x2B30080")]
		public static float2 operator *(float lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2B30090", Offset = "0x2B2C090", VA = "0x2B30090")]
		public static float2 operator +(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2B3009C", Offset = "0x2B2C09C", VA = "0x2B3009C")]
		public static float2 operator +(float2 lhs, float rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2B300A8", Offset = "0x2B2C0A8", VA = "0x2B300A8")]
		public static float2 operator +(float lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2B300B8", Offset = "0x2B2C0B8", VA = "0x2B300B8")]
		public static float2 operator -(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2B300C4", Offset = "0x2B2C0C4", VA = "0x2B300C4")]
		public static float2 operator /(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2B300D0", Offset = "0x2B2C0D0", VA = "0x2B300D0")]
		public static float2 operator /(float2 lhs, float rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2B300DC", Offset = "0x2B2C0DC", VA = "0x2B300DC")]
		public static float2 operator /(float lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2B300EC", Offset = "0x2B2C0EC", VA = "0x2B300EC")]
		public static float2 operator -(float2 val)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2B300F8", Offset = "0x2B2C0F8", VA = "0x2B300F8", Slot = "4")]
		public bool Equals(float2 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2B3011C", Offset = "0x2B2C11C", VA = "0x2B3011C", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2B301A4", Offset = "0x2B2C1A4", VA = "0x2B301A4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2B301D8", Offset = "0x2B2C1D8", VA = "0x2B301D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2B30278", Offset = "0x2B2C278", VA = "0x2B30278", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2B30308", Offset = "0x2B2C308", VA = "0x2B30308")]
		public static implicit operator Vector2(float2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2B3030C", Offset = "0x2B2C30C", VA = "0x2B3030C")]
		public static implicit operator float2(Vector2 v)
		{
			return default(float2);
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	[DefaultMember("Item")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct float2x2 : IEquatable<float2x2>, IFormattable
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float2 c0;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float2 c1;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float2x2 identity;

		[MethodImpl(256)]
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2B30310", Offset = "0x2B2C310", VA = "0x2B30310")]
		public float2x2(float2 c0, float2 c1)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2B3031C", Offset = "0x2B2C31C", VA = "0x2B3031C")]
		public float2x2(float m00, float m01, float m10, float m11)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2B30328", Offset = "0x2B2C328", VA = "0x2B30328", Slot = "4")]
		public bool Equals(float2x2 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2B30364", Offset = "0x2B2C364", VA = "0x2B30364", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2B3040C", Offset = "0x2B2C40C", VA = "0x2B3040C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2B30464", Offset = "0x2B2C464", VA = "0x2B30464", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2B30610", Offset = "0x2B2C610", VA = "0x2B30610", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	[DefaultMember("Item")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	public struct float3 : IEquatable<float3>, IFormattable
	{
		[Token(Token = "0x200000E")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float3 zero;

		[Token(Token = "0x17000001")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxy
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x2B308C4", Offset = "0x2B2C8C4", VA = "0x2B308C4")]
			get
			{
				return default(float4);
			}
		}

		[Token(Token = "0x17000002")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyz
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x2B308D4", Offset = "0x2B2C8D4", VA = "0x2B308D4")]
			get
			{
				return default(float4);
			}
		}

		[Token(Token = "0x17000003")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x2B308E4", Offset = "0x2B2C8E4", VA = "0x2B308E4")]
			get
			{
				return default(float3);
			}
		}

		[Token(Token = "0x17000004")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzx
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2B308F0", Offset = "0x2B2C8F0", VA = "0x2B308F0")]
			get
			{
				return default(float3);
			}
		}

		[Token(Token = "0x17000005")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2B308FC", Offset = "0x2B2C8FC", VA = "0x2B308FC")]
			get
			{
				return default(float2);
			}
		}

		[Token(Token = "0x17000006")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xz
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2B30904", Offset = "0x2B2C904", VA = "0x2B30904")]
			get
			{
				return default(float2);
			}
		}

		[Token(Token = "0x17000007")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yz
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2B30910", Offset = "0x2B2C910", VA = "0x2B30910")]
			get
			{
				return default(float2);
			}
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2B307F4", Offset = "0x2B2C7F4", VA = "0x2B307F4")]
		public float3(float x, float y, float z)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2B30800", Offset = "0x2B2C800", VA = "0x2B30800")]
		public float3(float x, float2 yz)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2B3080C", Offset = "0x2B2C80C", VA = "0x2B3080C")]
		public float3(float2 xy, float z)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2B30818", Offset = "0x2B2C818", VA = "0x2B30818")]
		public float3(float v)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2B30824", Offset = "0x2B2C824", VA = "0x2B30824")]
		public float3(int v)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2B30834", Offset = "0x2B2C834", VA = "0x2B30834")]
		public static implicit operator float3(float v)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2B30840", Offset = "0x2B2C840", VA = "0x2B30840")]
		public static implicit operator float3(int v)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2B30850", Offset = "0x2B2C850", VA = "0x2B30850")]
		public static float3 operator *(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2B30860", Offset = "0x2B2C860", VA = "0x2B30860")]
		public static float3 operator *(float3 lhs, float rhs)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2B30870", Offset = "0x2B2C870", VA = "0x2B30870")]
		public static float3 operator *(float lhs, float3 rhs)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2B30884", Offset = "0x2B2C884", VA = "0x2B30884")]
		public static float3 operator +(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2B30894", Offset = "0x2B2C894", VA = "0x2B30894")]
		public static float3 operator -(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2B308A4", Offset = "0x2B2C8A4", VA = "0x2B308A4")]
		public static float3 operator /(float3 lhs, float rhs)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2B308B4", Offset = "0x2B2C8B4", VA = "0x2B308B4")]
		public static float3 operator -(float3 val)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2B30918", Offset = "0x2B2C918", VA = "0x2B30918", Slot = "4")]
		public bool Equals(float3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2B30948", Offset = "0x2B2C948", VA = "0x2B30948", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2B309E0", Offset = "0x2B2C9E0", VA = "0x2B309E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2B30A24", Offset = "0x2B2CA24", VA = "0x2B30A24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2B30AE8", Offset = "0x2B2CAE8", VA = "0x2B30AE8", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2B30B9C", Offset = "0x2B2CB9C", VA = "0x2B30B9C")]
		public static implicit operator Vector3(float3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2B30BA0", Offset = "0x2B2CBA0", VA = "0x2B30BA0")]
		public static implicit operator float3(Vector3 v)
		{
			return default(float3);
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	[DefaultMember("Item")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct float3x3 : IEquatable<float3x3>, IFormattable
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float3 c0;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float3 c1;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float3 c2;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float3x3 identity;

		[MethodImpl(256)]
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2B30BA4", Offset = "0x2B2CBA4", VA = "0x2B30BA4")]
		public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2B30BC0", Offset = "0x2B2CBC0", VA = "0x2B30BC0", Slot = "4")]
		public bool Equals(float3x3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2B30C5C", Offset = "0x2B2CC5C", VA = "0x2B30C5C", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2B30D54", Offset = "0x2B2CD54", VA = "0x2B30D54", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2B30DD8", Offset = "0x2B2CDD8", VA = "0x2B30DD8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2B310C4", Offset = "0x2B2D0C4", VA = "0x2B310C4", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2B2FA3C", Offset = "0x2B2BA3C", VA = "0x2B2FA3C")]
		public float3x3(quaternion q)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	public struct float4 : IEquatable<float4>, IFormattable
	{
		[Token(Token = "0x2000011")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float w;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float4 zero;

		[Token(Token = "0x17000008")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzx
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x2B314C4", Offset = "0x2B2D4C4", VA = "0x2B314C4")]
			get
			{
				return default(float4);
			}
		}

		[Token(Token = "0x17000009")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxy
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x2B314D4", Offset = "0x2B2D4D4", VA = "0x2B314D4")]
			get
			{
				return default(float4);
			}
		}

		[Token(Token = "0x1700000A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxz
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x2B314E4", Offset = "0x2B2D4E4", VA = "0x2B314E4")]
			get
			{
				return default(float4);
			}
		}

		[Token(Token = "0x1700000B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyy
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x2B314F4", Offset = "0x2B2D4F4", VA = "0x2B314F4")]
			get
			{
				return default(float4);
			}
		}

		[Token(Token = "0x1700000C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyz
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2B31504", Offset = "0x2B2D504", VA = "0x2B31504")]
			get
			{
				return default(float4);
			}
		}

		[Token(Token = "0x1700000D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwwx
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x2B31514", Offset = "0x2B2D514", VA = "0x2B31514")]
			get
			{
				return default(float4);
			}
		}

		[Token(Token = "0x1700000E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwww
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2B31528", Offset = "0x2B2D528", VA = "0x2B31528")]
			get
			{
				return default(float4);
			}
		}

		[Token(Token = "0x1700000F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2B3153C", Offset = "0x2B2D53C", VA = "0x2B3153C")]
			get
			{
				return default(float3);
			}
		}

		[Token(Token = "0x17000010")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxw
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x2B31548", Offset = "0x2B2D548", VA = "0x2B31548")]
			get
			{
				return default(float3);
			}
		}

		[Token(Token = "0x17000011")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zwx
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2B31554", Offset = "0x2B2D554", VA = "0x2B31554")]
			get
			{
				return default(float3);
			}
		}

		[Token(Token = "0x17000012")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wzy
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2B31560", Offset = "0x2B2D560", VA = "0x2B31560")]
			get
			{
				return default(float3);
			}
		}

		[Token(Token = "0x17000013")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x2B3156C", Offset = "0x2B2D56C", VA = "0x2B3156C")]
			get
			{
				return default(float2);
			}
		}

		[Token(Token = "0x17000014")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zw
		{
			[MethodImpl(256)]
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x2B31574", Offset = "0x2B2D574", VA = "0x2B31574")]
			get
			{
				return default(float2);
			}
		}

		[Token(Token = "0x17000015")]
		public float this[int index]
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2B3157C", Offset = "0x2B2D57C", VA = "0x2B3157C")]
			get
			{
				return default(float);
			}
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2B313F0", Offset = "0x2B2D3F0", VA = "0x2B313F0")]
		public float4(float x, float y, float z, float w)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2B313FC", Offset = "0x2B2D3FC", VA = "0x2B313FC")]
		public float4(float2 xy, float z, float w)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2B31408", Offset = "0x2B2D408", VA = "0x2B31408")]
		public float4(float2 xy, float2 zw)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2B31414", Offset = "0x2B2D414", VA = "0x2B31414")]
		public float4(float3 xyz, float w)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2B31420", Offset = "0x2B2D420", VA = "0x2B31420")]
		public float4(int4 v)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2B31444", Offset = "0x2B2D444", VA = "0x2B31444")]
		public static implicit operator float4(int4 v)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2B31460", Offset = "0x2B2D460", VA = "0x2B31460")]
		public static float4 operator *(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2B31474", Offset = "0x2B2D474", VA = "0x2B31474")]
		public static float4 operator *(float4 lhs, float rhs)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2B31488", Offset = "0x2B2D488", VA = "0x2B31488")]
		public static float4 operator +(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2B3149C", Offset = "0x2B2D49C", VA = "0x2B3149C")]
		public static float4 operator -(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2B314B0", Offset = "0x2B2D4B0", VA = "0x2B314B0")]
		public static float4 operator /(float4 lhs, float rhs)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2B31584", Offset = "0x2B2D584", VA = "0x2B31584", Slot = "4")]
		public bool Equals(float4 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2B315C0", Offset = "0x2B2D5C0", VA = "0x2B315C0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2B31668", Offset = "0x2B2D668", VA = "0x2B31668", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2B316C4", Offset = "0x2B2D6C4", VA = "0x2B316C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2B31870", Offset = "0x2B2D870", VA = "0x2B31870", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2B31A04", Offset = "0x2B2DA04", VA = "0x2B31A04")]
		public static implicit operator float4(Vector4 v)
		{
			return default(float4);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2B31A08", Offset = "0x2B2DA08", VA = "0x2B31A08")]
		public static implicit operator Vector4(float4 v)
		{
			return default(Vector4);
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct float4x4 : IEquatable<float4x4>, IFormattable
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float4 c0;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float4 c1;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float4 c2;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float4 c3;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float4x4 identity;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly float4x4 zero;

		[Token(Token = "0x17000016")]
		public unsafe ref float4 this[int index]
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x2B31A84", Offset = "0x2B2DA84", VA = "0x2B31A84")]
			get
			{
				return ref *(float4*)null;
			}
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2B31A0C", Offset = "0x2B2DA0C", VA = "0x2B31A0C")]
		public float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2B31A30", Offset = "0x2B2DA30", VA = "0x2B31A30")]
		public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2B31A8C", Offset = "0x2B2DA8C", VA = "0x2B31A8C", Slot = "4")]
		public bool Equals(float4x4 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2B31B98", Offset = "0x2B2DB98", VA = "0x2B31B98", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2B31D00", Offset = "0x2B2DD00", VA = "0x2B31D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2B31E20", Offset = "0x2B2DE20", VA = "0x2B31E20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2B322CC", Offset = "0x2B2E2CC", VA = "0x2B322CC", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2B32760", Offset = "0x2B2E760", VA = "0x2B32760")]
		public static implicit operator float4x4(Matrix4x4 m)
		{
			return default(float4x4);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2B32830", Offset = "0x2B2E830", VA = "0x2B32830")]
		public static implicit operator Matrix4x4(float4x4 m)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2B32894", Offset = "0x2B2E894", VA = "0x2B32894")]
		public float4x4(quaternion rotation, float3 translation)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2B32928", Offset = "0x2B2E928", VA = "0x2B32928")]
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale)
		{
			return default(float4x4);
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct half : IEquatable<half>, IFormattable
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ushort value;

		[Token(Token = "0x17000017")]
		public static float MinValue
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2B32A70", Offset = "0x2B2EA70", VA = "0x2B32A70")]
			get
			{
				return default(float);
			}
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2B32A7C", Offset = "0x2B2EA7C", VA = "0x2B32A7C", Slot = "4")]
		public bool Equals(half rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2B32A8C", Offset = "0x2B2EA8C", VA = "0x2B32A8C", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2B32B04", Offset = "0x2B2EB04", VA = "0x2B32B04", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2B32B0C", Offset = "0x2B2EB0C", VA = "0x2B32B0C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2B32B80", Offset = "0x2B2EB80", VA = "0x2B32B80", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	[DefaultMember("Item")]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct int2 : IEquatable<int2>, IFormattable
	{
		[Token(Token = "0x2000015")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int2 zero;

		[Token(Token = "0x17000018")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxy
		{
			[MethodImpl(256)]
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2B32CA0", Offset = "0x2B2ECA0", VA = "0x2B32CA0")]
			get
			{
				return default(int4);
			}
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2B32BF4", Offset = "0x2B2EBF4", VA = "0x2B32BF4")]
		public int2(int x, int y)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2B32BFC", Offset = "0x2B2EBFC", VA = "0x2B32BFC")]
		public int2(int v)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2B32C04", Offset = "0x2B2EC04", VA = "0x2B32C04")]
		public static implicit operator int2(int v)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2B32C10", Offset = "0x2B2EC10", VA = "0x2B32C10")]
		public static int2 operator +(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2B32C28", Offset = "0x2B2EC28", VA = "0x2B32C28")]
		public static int2 operator +(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2B32C3C", Offset = "0x2B2EC3C", VA = "0x2B32C3C")]
		public static int2 operator -(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2B32C50", Offset = "0x2B2EC50", VA = "0x2B32C50")]
		public static int2 operator /(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2B32C64", Offset = "0x2B2EC64", VA = "0x2B32C64")]
		public static bool2 operator <(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2B32C84", Offset = "0x2B2EC84", VA = "0x2B32C84")]
		public static int2 operator >>(int2 x, int n)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2B32C98", Offset = "0x2B2EC98", VA = "0x2B32C98")]
		public static int2 operator |(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2B32CAC", Offset = "0x2B2ECAC", VA = "0x2B32CAC", Slot = "4")]
		public bool Equals(int2 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2B32CD4", Offset = "0x2B2ECD4", VA = "0x2B32CD4", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2B32D5C", Offset = "0x2B2ED5C", VA = "0x2B32D5C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2B32D90", Offset = "0x2B2ED90", VA = "0x2B32D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2B32E30", Offset = "0x2B2EE30", VA = "0x2B32E30", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DefaultMember("Item")]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	public struct int3 : IEquatable<int3>, IFormattable
	{
		[Token(Token = "0x2000017")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int z;

		[MethodImpl(256)]
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2B32EC0", Offset = "0x2B2EEC0", VA = "0x2B32EC0")]
		public int3(int x, int y, int z)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2B32ECC", Offset = "0x2B2EECC", VA = "0x2B32ECC", Slot = "4")]
		public bool Equals(int3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2B32F00", Offset = "0x2B2EF00", VA = "0x2B32F00", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2B32F98", Offset = "0x2B2EF98", VA = "0x2B32F98", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2B32FE0", Offset = "0x2B2EFE0", VA = "0x2B32FE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2B330A4", Offset = "0x2B2F0A4", VA = "0x2B330A4", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	public struct int4 : IEquatable<int4>, IFormattable
	{
		[Token(Token = "0x2000019")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int z;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int w;

		[Token(Token = "0x17000019")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy
		{
			[MethodImpl(256)]
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2B331E8", Offset = "0x2B2F1E8", VA = "0x2B331E8")]
			get
			{
				return default(int2);
			}
		}

		[Token(Token = "0x1700001A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zw
		{
			[MethodImpl(256)]
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2B331F0", Offset = "0x2B2F1F0", VA = "0x2B331F0")]
			get
			{
				return default(int2);
			}
		}

		[Token(Token = "0x1700001B")]
		public int this[int index]
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2B331F8", Offset = "0x2B2F1F8", VA = "0x2B331F8")]
			get
			{
				return default(int);
			}
		}

		[MethodImpl(256)]
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2B33158", Offset = "0x2B2F158", VA = "0x2B33158")]
		public int4(int x, int y, int z, int w)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2B33164", Offset = "0x2B2F164", VA = "0x2B33164")]
		public int4(float4 v)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2B33190", Offset = "0x2B2F190", VA = "0x2B33190")]
		public static explicit operator int4(float4 v)
		{
			return default(int4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2B33200", Offset = "0x2B2F200", VA = "0x2B33200", Slot = "4")]
		public bool Equals(int4 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2B33244", Offset = "0x2B2F244", VA = "0x2B33244", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2B332EC", Offset = "0x2B2F2EC", VA = "0x2B332EC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2B33348", Offset = "0x2B2F348", VA = "0x2B33348", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2B334F4", Offset = "0x2B2F4F4", VA = "0x2B334F4", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct quaternion : IEquatable<quaternion>, IFormattable
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float4 value;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly quaternion identity;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2B33688", Offset = "0x2B2F688", VA = "0x2B33688")]
		public static implicit operator quaternion(Quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2B3368C", Offset = "0x2B2F68C", VA = "0x2B3368C")]
		public quaternion(float x, float y, float z, float w)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2B33698", Offset = "0x2B2F698", VA = "0x2B33698")]
		public quaternion(float4 value)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2B336A4", Offset = "0x2B2F6A4", VA = "0x2B336A4")]
		public static quaternion EulerXYZ(float3 xyz)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2B33758", Offset = "0x2B2F758", VA = "0x2B33758")]
		public static quaternion EulerXYZ(float x, float y, float z)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2B3380C", Offset = "0x2B2F80C", VA = "0x2B3380C", Slot = "4")]
		public bool Equals(quaternion x)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2B33848", Offset = "0x2B2F848", VA = "0x2B33848", Slot = "0")]
		public override bool Equals(object x)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2B338F0", Offset = "0x2B2F8F0", VA = "0x2B338F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2B3394C", Offset = "0x2B2F94C", VA = "0x2B3394C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2B33AF8", Offset = "0x2B2FAF8", VA = "0x2B33AF8", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	public struct uint2 : IEquatable<uint2>, IFormattable
	{
		[Token(Token = "0x200001C")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint x;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint y;

		[MethodImpl(256)]
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2B33CDC", Offset = "0x2B2FCDC", VA = "0x2B33CDC")]
		public uint2(uint x, uint y)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2B33CE4", Offset = "0x2B2FCE4", VA = "0x2B33CE4")]
		public static uint2 operator *(uint2 lhs, uint2 rhs)
		{
			return default(uint2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2B33CFC", Offset = "0x2B2FCFC", VA = "0x2B33CFC")]
		public static uint2 operator +(uint2 lhs, uint2 rhs)
		{
			return default(uint2);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2B33D14", Offset = "0x2B2FD14", VA = "0x2B33D14", Slot = "4")]
		public bool Equals(uint2 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2B33D3C", Offset = "0x2B2FD3C", VA = "0x2B33D3C", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2B33DC4", Offset = "0x2B2FDC4", VA = "0x2B33DC4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2B33DF8", Offset = "0x2B2FDF8", VA = "0x2B33DF8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2B33E98", Offset = "0x2B2FE98", VA = "0x2B33E98", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	public struct uint3 : IEquatable<uint3>, IFormattable
	{
		[Token(Token = "0x200001E")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint x;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint y;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint z;

		[MethodImpl(256)]
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2B33F28", Offset = "0x2B2FF28", VA = "0x2B33F28")]
		public uint3(uint x, uint y, uint z)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2B33F34", Offset = "0x2B2FF34", VA = "0x2B33F34")]
		public static uint3 operator *(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2B33F50", Offset = "0x2B2FF50", VA = "0x2B33F50")]
		public static uint3 operator +(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2B33F6C", Offset = "0x2B2FF6C", VA = "0x2B33F6C")]
		public static uint3 operator ^(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2B33F78", Offset = "0x2B2FF78", VA = "0x2B33F78", Slot = "4")]
		public bool Equals(uint3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2B33FAC", Offset = "0x2B2FFAC", VA = "0x2B33FAC", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2B34044", Offset = "0x2B30044", VA = "0x2B34044", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2B3408C", Offset = "0x2B3008C", VA = "0x2B3408C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2B34150", Offset = "0x2B30150", VA = "0x2B34150", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	[DefaultMember("Item")]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct uint4 : IEquatable<uint4>, IFormattable
	{
		[Token(Token = "0x2000020")]
		internal sealed class DebuggerProxy
		{
		}

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint x;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint y;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint z;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint w;

		[MethodImpl(256)]
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2B34204", Offset = "0x2B30204", VA = "0x2B34204")]
		public uint4(uint x, uint y, uint z, uint w)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2B34210", Offset = "0x2B30210", VA = "0x2B34210")]
		public static uint4 operator *(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2B3423C", Offset = "0x2B3023C", VA = "0x2B3423C")]
		public static uint4 operator +(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2B34268", Offset = "0x2B30268", VA = "0x2B34268", Slot = "4")]
		public bool Equals(uint4 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2B342AC", Offset = "0x2B302AC", VA = "0x2B342AC", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2B34354", Offset = "0x2B30354", VA = "0x2B34354", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2B343B0", Offset = "0x2B303B0", VA = "0x2B343B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2B3455C", Offset = "0x2B3055C", VA = "0x2B3455C", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
