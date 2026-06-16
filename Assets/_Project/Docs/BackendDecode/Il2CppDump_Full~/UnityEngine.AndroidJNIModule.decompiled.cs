using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine
{
	[StructLayout(2)]
	[Token(Token = "0x2000002")]
	[UnityEngine.Bindings.NativeType(UnityEngine.Bindings.CodegenOptions.Custom, "ScriptingJvalue")]
	public struct jvalue
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool z;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public sbyte b;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public char c;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short s;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int i;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long j;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float f;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double d;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr l;
	}
	[Token(Token = "0x2000003")]
	[UnityEngine.Bindings.NativeType(UnityEngine.Bindings.CodegenOptions.Custom, "ScriptingJNINativeMethod")]
	public struct JNINativeMethod
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string signature;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr fnPtr;
	}
	[Token(Token = "0x2000004")]
	[UnityEngine.Bindings.NativeConditional("PLATFORM_ANDROID")]
	[UnityEngine.Bindings.NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	[UnityEngine.Scripting.UsedByNativeCode]
	[UnityEngine.Bindings.StaticAccessor("AndroidJNIBindingsHelpers", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	public static class AndroidJNIHelper
	{
		[Token(Token = "0x17000001")]
		public static extern bool debug
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2DD2130", Offset = "0x2DCE130", VA = "0x2DD2130")]
			get;
			[MethodImpl(4096)]
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2DD2158", Offset = "0x2DCE158", VA = "0x2DD2158")]
			set;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2DD2194", Offset = "0x2DCE194", VA = "0x2DD2194")]
		public static IntPtr GetConstructorID(IntPtr javaClass)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2DD21DC", Offset = "0x2DCE1DC", VA = "0x2DD21DC")]
		public static IntPtr GetConstructorID(IntPtr javaClass, [DefaultValue("")] string signature)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2DD23C4", Offset = "0x2DCE3C4", VA = "0x2DD23C4")]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2DD2424", Offset = "0x2DCE424", VA = "0x2DD2424")]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue("")] string signature)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2DD2420", Offset = "0x2DCE420", VA = "0x2DD2420")]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue("")] string signature, [DefaultValue("false")] bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2DD2620", Offset = "0x2DCE620", VA = "0x2DD2620")]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2DD2680", Offset = "0x2DCE680", VA = "0x2DD2680")]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue("")] string signature)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2DD267C", Offset = "0x2DCE67C", VA = "0x2DD267C")]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue("")] string signature, [DefaultValue("false")] bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2DD2940", Offset = "0x2DCE940", VA = "0x2DD2940")]
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2DD299C", Offset = "0x2DCE99C", VA = "0x2DD299C")]
		public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2DD2B4C", Offset = "0x2DCEB4C", VA = "0x2DD2B4C")]
		public static IntPtr ConvertToJNIArray(Array array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2DD36EC", Offset = "0x2DCF6EC", VA = "0x2DD36EC")]
		public static jvalue[] CreateJNIArgArray(object[] args)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2DD3D08", Offset = "0x2DCFD08", VA = "0x2DD3D08")]
		public static void CreateJNIArgArray(object[] args, Span<jvalue> jniArgs)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2DD3E18", Offset = "0x2DCFE18", VA = "0x2DD3E18")]
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2DD3FDC", Offset = "0x2DCFFDC", VA = "0x2DD3FDC")]
		public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2DD3FE0", Offset = "0x2DCFFE0", VA = "0x2DD3FE0")]
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2DD4020", Offset = "0x2DD0020", VA = "0x2DD4020")]
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2DD4090", Offset = "0x2DD0090", VA = "0x2DD4090")]
		public static string GetSignature(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2DD4DA8", Offset = "0x2DD0DA8", VA = "0x2DD4DA8")]
		public static string GetSignature(object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			return (ArrayType)null;
		}

		[Token(Token = "0x6000017")]
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000018")]
		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000019")]
		public static string GetSignature<ReturnType>(object[] args)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2DD4ED0", Offset = "0x2DD0ED0", VA = "0x2DD4ED0")]
		private static IntPtr Box(jvalue val, string boxedClass, string signature)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2DD5194", Offset = "0x2DD1194", VA = "0x2DD5194")]
		public static IntPtr Box(sbyte value)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2DD51FC", Offset = "0x2DD11FC", VA = "0x2DD51FC")]
		public static IntPtr Box(short value)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2DD5264", Offset = "0x2DD1264", VA = "0x2DD5264")]
		public static IntPtr Box(int value)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2DD52CC", Offset = "0x2DD12CC", VA = "0x2DD52CC")]
		public static IntPtr Box(long value)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2DD5334", Offset = "0x2DD1334", VA = "0x2DD5334")]
		public static IntPtr Box(float value)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2DD539C", Offset = "0x2DD139C", VA = "0x2DD539C")]
		public static IntPtr Box(double value)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2DD5404", Offset = "0x2DD1404", VA = "0x2DD5404")]
		public static IntPtr Box(char value)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2DD546C", Offset = "0x2DD146C", VA = "0x2DD546C")]
		public static IntPtr Box(bool value)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2DD54D4", Offset = "0x2DD14D4", VA = "0x2DD54D4")]
		private static IntPtr GetUnboxMethod(IntPtr obj, string methodName, string signature)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2DD56CC", Offset = "0x2DD16CC", VA = "0x2DD56CC")]
		public static void Unbox(IntPtr obj, out sbyte value)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2DD57C4", Offset = "0x2DD17C4", VA = "0x2DD57C4")]
		public static void Unbox(IntPtr obj, out short value)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2DD58BC", Offset = "0x2DD18BC", VA = "0x2DD58BC")]
		public static void Unbox(IntPtr obj, out int value)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2DD59B4", Offset = "0x2DD19B4", VA = "0x2DD59B4")]
		public static void Unbox(IntPtr obj, out long value)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2DD5AAC", Offset = "0x2DD1AAC", VA = "0x2DD5AAC")]
		public static void Unbox(IntPtr obj, out float value)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2DD5BB0", Offset = "0x2DD1BB0", VA = "0x2DD5BB0")]
		public static void Unbox(IntPtr obj, out double value)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2DD5CB4", Offset = "0x2DD1CB4", VA = "0x2DD5CB4")]
		public static void Unbox(IntPtr obj, out char value)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2DD5DAC", Offset = "0x2DD1DAC", VA = "0x2DD5DAC")]
		public static void Unbox(IntPtr obj, out bool value)
		{
		}
	}
	[Token(Token = "0x2000005")]
	[UnityEngine.Bindings.StaticAccessor("AndroidJNIBindingsHelpers", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeConditional("PLATFORM_ANDROID")]
	[UnityEngine.Bindings.NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	public static class AndroidJNI
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2DD5EA8", Offset = "0x2DD1EA8", VA = "0x2DD5EA8")]
		[UnityEngine.Bindings.StaticAccessor("jni", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr GetJavaVM();

		[MethodImpl(4096)]
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2DD5ED0", Offset = "0x2DD1ED0", VA = "0x2DD5ED0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int AttachCurrentThread();

		[MethodImpl(4096)]
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2DD5EF8", Offset = "0x2DD1EF8", VA = "0x2DD5EF8")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int DetachCurrentThread();

		[MethodImpl(4096)]
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2DD5F20", Offset = "0x2DD1F20", VA = "0x2DD5F20")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int GetVersion();

		[MethodImpl(4096)]
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2DD5F48", Offset = "0x2DD1F48", VA = "0x2DD5F48")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr FindClass(string name);

		[MethodImpl(4096)]
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2DD5F84", Offset = "0x2DD1F84", VA = "0x2DD5F84")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr FromReflectedMethod(IntPtr refMethod);

		[MethodImpl(4096)]
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2DD5FC0", Offset = "0x2DD1FC0", VA = "0x2DD5FC0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr FromReflectedField(IntPtr refField);

		[MethodImpl(4096)]
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2DD5FFC", Offset = "0x2DD1FFC", VA = "0x2DD5FFC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic);

		[MethodImpl(4096)]
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2DD6050", Offset = "0x2DD2050", VA = "0x2DD6050")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic);

		[MethodImpl(4096)]
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2DD60A4", Offset = "0x2DD20A4", VA = "0x2DD60A4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr GetSuperclass(IntPtr clazz);

		[MethodImpl(4096)]
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2DD60E0", Offset = "0x2DD20E0", VA = "0x2DD60E0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2);

		[MethodImpl(4096)]
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2DD6124", Offset = "0x2DD2124", VA = "0x2DD6124")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int Throw(IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2DD6160", Offset = "0x2DD2160", VA = "0x2DD6160")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int ThrowNew(IntPtr clazz, string message);

		[MethodImpl(4096)]
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2DD61A4", Offset = "0x2DD21A4", VA = "0x2DD61A4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr ExceptionOccurred();

		[MethodImpl(4096)]
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2DD61CC", Offset = "0x2DD21CC", VA = "0x2DD61CC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void ExceptionDescribe();

		[MethodImpl(4096)]
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2DD61F4", Offset = "0x2DD21F4", VA = "0x2DD61F4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void ExceptionClear();

		[MethodImpl(4096)]
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2DD621C", Offset = "0x2DD221C", VA = "0x2DD621C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void FatalError(string message);

		[MethodImpl(4096)]
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2DD6258", Offset = "0x2DD2258", VA = "0x2DD6258")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int PushLocalFrame(int capacity);

		[MethodImpl(4096)]
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2DD6294", Offset = "0x2DD2294", VA = "0x2DD6294")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr PopLocalFrame(IntPtr ptr);

		[MethodImpl(4096)]
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2DD62D0", Offset = "0x2DD22D0", VA = "0x2DD62D0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewGlobalRef(IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2DD630C", Offset = "0x2DD230C", VA = "0x2DD630C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void DeleteGlobalRef(IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2DD6348", Offset = "0x2DD2348", VA = "0x2DD6348")]
		[UnityEngine.Bindings.ThreadSafe]
		internal static extern void QueueDeleteGlobalRef(IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2DD6384", Offset = "0x2DD2384", VA = "0x2DD6384")]
		[UnityEngine.Bindings.ThreadSafe]
		internal static extern uint GetQueueGlobalRefsCount();

		[MethodImpl(4096)]
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2DD63AC", Offset = "0x2DD23AC", VA = "0x2DD63AC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewWeakGlobalRef(IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2DD63E8", Offset = "0x2DD23E8", VA = "0x2DD63E8")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void DeleteWeakGlobalRef(IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2DD6424", Offset = "0x2DD2424", VA = "0x2DD6424")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewLocalRef(IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2DD6460", Offset = "0x2DD2460", VA = "0x2DD6460")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void DeleteLocalRef(IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2DD649C", Offset = "0x2DD249C", VA = "0x2DD649C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern bool IsSameObject(IntPtr obj1, IntPtr obj2);

		[MethodImpl(4096)]
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2DD64E0", Offset = "0x2DD24E0", VA = "0x2DD64E0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int EnsureLocalCapacity(int capacity);

		[MethodImpl(4096)]
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2DD651C", Offset = "0x2DD251C", VA = "0x2DD651C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr AllocObject(IntPtr clazz);

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2DD6558", Offset = "0x2DD2558", VA = "0x2DD6558")]
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2DD65C0", Offset = "0x2DD25C0", VA = "0x2DD65C0")]
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2DD6658", Offset = "0x2DD2658", VA = "0x2DD6658")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args);

		[MethodImpl(4096)]
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2DD66AC", Offset = "0x2DD26AC", VA = "0x2DD66AC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr GetObjectClass(IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2DD66E8", Offset = "0x2DD26E8", VA = "0x2DD66E8")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern bool IsInstanceOf(IntPtr obj, IntPtr clazz);

		[MethodImpl(4096)]
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2DD672C", Offset = "0x2DD272C", VA = "0x2DD672C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr GetMethodID(IntPtr clazz, string name, string sig);

		[MethodImpl(4096)]
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2DD6780", Offset = "0x2DD2780", VA = "0x2DD6780")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr GetFieldID(IntPtr clazz, string name, string sig);

		[MethodImpl(4096)]
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2DD67D4", Offset = "0x2DD27D4", VA = "0x2DD67D4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig);

		[MethodImpl(4096)]
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2DD6828", Offset = "0x2DD2828", VA = "0x2DD6828")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig);

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2DD687C", Offset = "0x2DD287C", VA = "0x2DD687C")]
		public static IntPtr NewString(string chars)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2DD68B8", Offset = "0x2DD28B8", VA = "0x2DD68B8")]
		[UnityEngine.Bindings.ThreadSafe]
		private static extern IntPtr NewStringFromStr(string chars);

		[MethodImpl(4096)]
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2DD68F4", Offset = "0x2DD28F4", VA = "0x2DD68F4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewString(char[] chars);

		[MethodImpl(4096)]
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2DD6930", Offset = "0x2DD2930", VA = "0x2DD6930")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewStringUTF(string bytes);

		[MethodImpl(4096)]
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2DD696C", Offset = "0x2DD296C", VA = "0x2DD696C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern string GetStringChars(IntPtr str);

		[MethodImpl(4096)]
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2DD69A8", Offset = "0x2DD29A8", VA = "0x2DD69A8")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int GetStringLength(IntPtr str);

		[MethodImpl(4096)]
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2DD69E4", Offset = "0x2DD29E4", VA = "0x2DD69E4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int GetStringUTFLength(IntPtr str);

		[MethodImpl(4096)]
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2DD6A20", Offset = "0x2DD2A20", VA = "0x2DD6A20")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern string GetStringUTFChars(IntPtr str);

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2DD6A5C", Offset = "0x2DD2A5C", VA = "0x2DD6A5C")]
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2DD6AC4", Offset = "0x2DD2AC4", VA = "0x2DD6AC4")]
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return null;
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2DD6B5C", Offset = "0x2DD2B5C", VA = "0x2DD6B5C")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2DD6BB0", Offset = "0x2DD2BB0", VA = "0x2DD6BB0")]
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2DD6C18", Offset = "0x2DD2C18", VA = "0x2DD6C18")]
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2DD6CB0", Offset = "0x2DD2CB0", VA = "0x2DD6CB0")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2DD6D04", Offset = "0x2DD2D04", VA = "0x2DD6D04")]
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(int);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2DD6D6C", Offset = "0x2DD2D6C", VA = "0x2DD6D6C")]
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(int);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2DD6E04", Offset = "0x2DD2E04", VA = "0x2DD6E04")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2DD6E58", Offset = "0x2DD2E58", VA = "0x2DD6E58")]
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2DD6EC0", Offset = "0x2DD2EC0", VA = "0x2DD6EC0")]
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2DD6F5C", Offset = "0x2DD2F5C", VA = "0x2DD6F5C")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2DD6FB0", Offset = "0x2DD2FB0", VA = "0x2DD6FB0")]
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(short);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2DD7018", Offset = "0x2DD3018", VA = "0x2DD7018")]
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(short);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2DD70B0", Offset = "0x2DD30B0", VA = "0x2DD70B0")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2DD7104", Offset = "0x2DD3104", VA = "0x2DD7104")]
		[Obsolete("AndroidJNI.CallByteMethod is obsolete. Use AndroidJNI.CallSByteMethod method instead")]
		public static byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(byte);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2DD7108", Offset = "0x2DD3108", VA = "0x2DD7108")]
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2DD7170", Offset = "0x2DD3170", VA = "0x2DD7170")]
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(sbyte);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2DD7208", Offset = "0x2DD3208", VA = "0x2DD7208")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2DD725C", Offset = "0x2DD325C", VA = "0x2DD725C")]
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(char);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2DD72C4", Offset = "0x2DD32C4", VA = "0x2DD72C4")]
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(char);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2DD735C", Offset = "0x2DD335C", VA = "0x2DD735C")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2DD73B0", Offset = "0x2DD33B0", VA = "0x2DD73B0")]
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2DD7418", Offset = "0x2DD3418", VA = "0x2DD7418")]
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(float);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2DD74B0", Offset = "0x2DD34B0", VA = "0x2DD74B0")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2DD7504", Offset = "0x2DD3504", VA = "0x2DD7504")]
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(double);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2DD756C", Offset = "0x2DD356C", VA = "0x2DD756C")]
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(double);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2DD7604", Offset = "0x2DD3604", VA = "0x2DD7604")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2DD7658", Offset = "0x2DD3658", VA = "0x2DD7658")]
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(long);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2DD76C0", Offset = "0x2DD36C0", VA = "0x2DD76C0")]
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(long);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2DD7758", Offset = "0x2DD3758", VA = "0x2DD7758")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2DD77AC", Offset = "0x2DD37AC", VA = "0x2DD77AC")]
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2DD7814", Offset = "0x2DD3814", VA = "0x2DD7814")]
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2DD78AC", Offset = "0x2DD38AC", VA = "0x2DD78AC")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args);

		[MethodImpl(4096)]
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2DD7900", Offset = "0x2DD3900", VA = "0x2DD7900")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern string GetStringField(IntPtr obj, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2DD7944", Offset = "0x2DD3944", VA = "0x2DD7944")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr GetObjectField(IntPtr obj, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2DD7988", Offset = "0x2DD3988", VA = "0x2DD7988")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern bool GetBooleanField(IntPtr obj, IntPtr fieldID);

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2DD79CC", Offset = "0x2DD39CC", VA = "0x2DD79CC")]
		[Obsolete("AndroidJNI.GetByteField is obsolete. Use AndroidJNI.GetSByteField method instead")]
		public static byte GetByteField(IntPtr obj, IntPtr fieldID)
		{
			return default(byte);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2DD7A10", Offset = "0x2DD3A10", VA = "0x2DD7A10")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern sbyte GetSByteField(IntPtr obj, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2DD7A54", Offset = "0x2DD3A54", VA = "0x2DD7A54")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern char GetCharField(IntPtr obj, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2DD7A98", Offset = "0x2DD3A98", VA = "0x2DD7A98")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern short GetShortField(IntPtr obj, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2DD7ADC", Offset = "0x2DD3ADC", VA = "0x2DD7ADC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int GetIntField(IntPtr obj, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2DD7B20", Offset = "0x2DD3B20", VA = "0x2DD7B20")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern long GetLongField(IntPtr obj, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2DD7B64", Offset = "0x2DD3B64", VA = "0x2DD7B64")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern float GetFloatField(IntPtr obj, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2DD7BA8", Offset = "0x2DD3BA8", VA = "0x2DD7BA8")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern double GetDoubleField(IntPtr obj, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2DD7BEC", Offset = "0x2DD3BEC", VA = "0x2DD7BEC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStringField(IntPtr obj, IntPtr fieldID, string val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2DD7C40", Offset = "0x2DD3C40", VA = "0x2DD7C40")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val);

		[MethodImpl(4096)]
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2DD7C94", Offset = "0x2DD3C94", VA = "0x2DD7C94")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val);

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2DD7CE8", Offset = "0x2DD3CE8", VA = "0x2DD7CE8")]
		[Obsolete("AndroidJNI.SetByteField is obsolete. Use AndroidJNI.SetSByteField method instead")]
		public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2DD7D3C", Offset = "0x2DD3D3C", VA = "0x2DD7D3C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val);

		[MethodImpl(4096)]
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2DD7D90", Offset = "0x2DD3D90", VA = "0x2DD7D90")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetCharField(IntPtr obj, IntPtr fieldID, char val);

		[MethodImpl(4096)]
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2DD7DE4", Offset = "0x2DD3DE4", VA = "0x2DD7DE4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetShortField(IntPtr obj, IntPtr fieldID, short val);

		[MethodImpl(4096)]
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2DD7E38", Offset = "0x2DD3E38", VA = "0x2DD7E38")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetIntField(IntPtr obj, IntPtr fieldID, int val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2DD7E8C", Offset = "0x2DD3E8C", VA = "0x2DD7E8C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetLongField(IntPtr obj, IntPtr fieldID, long val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2DD7EE0", Offset = "0x2DD3EE0", VA = "0x2DD7EE0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetFloatField(IntPtr obj, IntPtr fieldID, float val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2DD7F34", Offset = "0x2DD3F34", VA = "0x2DD7F34")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetDoubleField(IntPtr obj, IntPtr fieldID, double val);

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2DD7F88", Offset = "0x2DD3F88", VA = "0x2DD7F88")]
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2DD7FF0", Offset = "0x2DD3FF0", VA = "0x2DD7FF0")]
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return null;
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2DD8088", Offset = "0x2DD4088", VA = "0x2DD8088")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2DD80DC", Offset = "0x2DD40DC", VA = "0x2DD80DC")]
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2DD8144", Offset = "0x2DD4144", VA = "0x2DD8144")]
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2DD81DC", Offset = "0x2DD41DC", VA = "0x2DD81DC")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2DD8230", Offset = "0x2DD4230", VA = "0x2DD8230")]
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(int);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2DD8298", Offset = "0x2DD4298", VA = "0x2DD8298")]
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(int);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2DD8330", Offset = "0x2DD4330", VA = "0x2DD8330")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2DD8384", Offset = "0x2DD4384", VA = "0x2DD8384")]
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2DD83EC", Offset = "0x2DD43EC", VA = "0x2DD83EC")]
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2DD8488", Offset = "0x2DD4488", VA = "0x2DD8488")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2DD84DC", Offset = "0x2DD44DC", VA = "0x2DD84DC")]
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(short);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2DD8544", Offset = "0x2DD4544", VA = "0x2DD8544")]
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(short);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2DD85DC", Offset = "0x2DD45DC", VA = "0x2DD85DC")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2DD8630", Offset = "0x2DD4630", VA = "0x2DD8630")]
		[Obsolete("AndroidJNI.CallStaticByteMethod is obsolete. Use AndroidJNI.CallStaticSByteMethod method instead")]
		public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(byte);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2DD8634", Offset = "0x2DD4634", VA = "0x2DD8634")]
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2DD869C", Offset = "0x2DD469C", VA = "0x2DD869C")]
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(sbyte);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2DD8734", Offset = "0x2DD4734", VA = "0x2DD8734")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2DD8788", Offset = "0x2DD4788", VA = "0x2DD8788")]
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(char);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2DD87F0", Offset = "0x2DD47F0", VA = "0x2DD87F0")]
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(char);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2DD8888", Offset = "0x2DD4888", VA = "0x2DD8888")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2DD88DC", Offset = "0x2DD48DC", VA = "0x2DD88DC")]
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2DD8944", Offset = "0x2DD4944", VA = "0x2DD8944")]
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(float);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2DD89DC", Offset = "0x2DD49DC", VA = "0x2DD89DC")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2DD8A30", Offset = "0x2DD4A30", VA = "0x2DD8A30")]
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(double);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2DD8A98", Offset = "0x2DD4A98", VA = "0x2DD8A98")]
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(double);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2DD8B30", Offset = "0x2DD4B30", VA = "0x2DD8B30")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2DD8B84", Offset = "0x2DD4B84", VA = "0x2DD8B84")]
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(long);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2DD8BEC", Offset = "0x2DD4BEC", VA = "0x2DD8BEC")]
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(long);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2DD8C84", Offset = "0x2DD4C84", VA = "0x2DD8C84")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2DD8CD8", Offset = "0x2DD4CD8", VA = "0x2DD8CD8")]
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2DD8D40", Offset = "0x2DD4D40", VA = "0x2DD8D40")]
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2DD8DD8", Offset = "0x2DD4DD8", VA = "0x2DD8DD8")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args);

		[MethodImpl(4096)]
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2DD8E2C", Offset = "0x2DD4E2C", VA = "0x2DD8E2C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern string GetStaticStringField(IntPtr clazz, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2DD8E70", Offset = "0x2DD4E70", VA = "0x2DD8E70")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2DD8EB4", Offset = "0x2DD4EB4", VA = "0x2DD8EB4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID);

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2DD8EF8", Offset = "0x2DD4EF8", VA = "0x2DD8EF8")]
		[Obsolete("AndroidJNI.GetStaticByteField is obsolete. Use AndroidJNI.GetStaticSByteField method instead")]
		public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID)
		{
			return default(byte);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2DD8F3C", Offset = "0x2DD4F3C", VA = "0x2DD8F3C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2DD8F80", Offset = "0x2DD4F80", VA = "0x2DD8F80")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern char GetStaticCharField(IntPtr clazz, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2DD8FC4", Offset = "0x2DD4FC4", VA = "0x2DD8FC4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern short GetStaticShortField(IntPtr clazz, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2DD9008", Offset = "0x2DD5008", VA = "0x2DD9008")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int GetStaticIntField(IntPtr clazz, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2DD904C", Offset = "0x2DD504C", VA = "0x2DD904C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern long GetStaticLongField(IntPtr clazz, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2DD9090", Offset = "0x2DD5090", VA = "0x2DD9090")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern float GetStaticFloatField(IntPtr clazz, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2DD90D4", Offset = "0x2DD50D4", VA = "0x2DD90D4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID);

		[MethodImpl(4096)]
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2DD9118", Offset = "0x2DD5118", VA = "0x2DD9118")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val);

		[MethodImpl(4096)]
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2DD916C", Offset = "0x2DD516C", VA = "0x2DD916C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val);

		[MethodImpl(4096)]
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2DD91C0", Offset = "0x2DD51C0", VA = "0x2DD91C0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val);

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2DD9214", Offset = "0x2DD5214", VA = "0x2DD9214")]
		[Obsolete("AndroidJNI.SetStaticByteField is obsolete. Use AndroidJNI.SetStaticSByteField method instead")]
		public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2DD9268", Offset = "0x2DD5268", VA = "0x2DD9268")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val);

		[MethodImpl(4096)]
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2DD92BC", Offset = "0x2DD52BC", VA = "0x2DD92BC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val);

		[MethodImpl(4096)]
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2DD9310", Offset = "0x2DD5310", VA = "0x2DD9310")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val);

		[MethodImpl(4096)]
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2DD9364", Offset = "0x2DD5364", VA = "0x2DD9364")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val);

		[MethodImpl(4096)]
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2DD93B8", Offset = "0x2DD53B8", VA = "0x2DD93B8")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val);

		[MethodImpl(4096)]
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2DD940C", Offset = "0x2DD540C", VA = "0x2DD940C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val);

		[MethodImpl(4096)]
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2DD9460", Offset = "0x2DD5460", VA = "0x2DD9460")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val);

		[MethodImpl(4096)]
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2DD94B4", Offset = "0x2DD54B4", VA = "0x2DD94B4")]
		[UnityEngine.Bindings.ThreadSafe]
		private static extern IntPtr ConvertToBooleanArray(bool[] array);

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2DD94F0", Offset = "0x2DD54F0", VA = "0x2DD94F0")]
		public static IntPtr ToBooleanArray(bool[] array)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2DD9534", Offset = "0x2DD5534", VA = "0x2DD9534")]
		[UnityEngine.Bindings.ThreadSafe]
		[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
		public static extern IntPtr ToByteArray(byte[] array);

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2DD9570", Offset = "0x2DD5570", VA = "0x2DD9570")]
		public static IntPtr ToSByteArray(sbyte[] array)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2DD95C4", Offset = "0x2DD55C4", VA = "0x2DD95C4")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr ToSByteArray(sbyte* array, int length);

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2DD9608", Offset = "0x2DD5608", VA = "0x2DD9608")]
		public static IntPtr ToCharArray(char[] array)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2DD965C", Offset = "0x2DD565C", VA = "0x2DD965C")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr ToCharArray(char* array, int length);

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2DD96A0", Offset = "0x2DD56A0", VA = "0x2DD96A0")]
		public static IntPtr ToShortArray(short[] array)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2DD96F4", Offset = "0x2DD56F4", VA = "0x2DD96F4")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr ToShortArray(short* array, int length);

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2DD9738", Offset = "0x2DD5738", VA = "0x2DD9738")]
		public static IntPtr ToIntArray(int[] array)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2DD978C", Offset = "0x2DD578C", VA = "0x2DD978C")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr ToIntArray(int* array, int length);

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2DD97D0", Offset = "0x2DD57D0", VA = "0x2DD97D0")]
		public static IntPtr ToLongArray(long[] array)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2DD9824", Offset = "0x2DD5824", VA = "0x2DD9824")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr ToLongArray(long* array, int length);

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2DD9868", Offset = "0x2DD5868", VA = "0x2DD9868")]
		public static IntPtr ToFloatArray(float[] array)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2DD98BC", Offset = "0x2DD58BC", VA = "0x2DD98BC")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr ToFloatArray(float* array, int length);

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2DD9900", Offset = "0x2DD5900", VA = "0x2DD9900")]
		public static IntPtr ToDoubleArray(double[] array)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2DD9954", Offset = "0x2DD5954", VA = "0x2DD9954")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr ToDoubleArray(double* array, int length);

		[MethodImpl(4096)]
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2DD9998", Offset = "0x2DD5998", VA = "0x2DD9998")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass);

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2DD99EC", Offset = "0x2DD59EC", VA = "0x2DD99EC")]
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2DD9A50", Offset = "0x2DD5A50", VA = "0x2DD9A50")]
		public static IntPtr ToObjectArray(IntPtr[] array)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2DD9A58", Offset = "0x2DD5A58", VA = "0x2DD9A58")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern bool[] FromBooleanArray(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2DD9A94", Offset = "0x2DD5A94", VA = "0x2DD9A94")]
		[UnityEngine.Bindings.ThreadSafe]
		[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
		public static extern byte[] FromByteArray(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2DD9AD0", Offset = "0x2DD5AD0", VA = "0x2DD9AD0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern sbyte[] FromSByteArray(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2DD9B0C", Offset = "0x2DD5B0C", VA = "0x2DD9B0C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern char[] FromCharArray(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2DD9B48", Offset = "0x2DD5B48", VA = "0x2DD9B48")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern short[] FromShortArray(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2DD9B84", Offset = "0x2DD5B84", VA = "0x2DD9B84")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int[] FromIntArray(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2DD9BC0", Offset = "0x2DD5BC0", VA = "0x2DD9BC0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern long[] FromLongArray(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2DD9BFC", Offset = "0x2DD5BFC", VA = "0x2DD9BFC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern float[] FromFloatArray(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2DD9C38", Offset = "0x2DD5C38", VA = "0x2DD9C38")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern double[] FromDoubleArray(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2DD9C74", Offset = "0x2DD5C74", VA = "0x2DD9C74")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr[] FromObjectArray(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2DD9CB0", Offset = "0x2DD5CB0", VA = "0x2DD9CB0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int GetArrayLength(IntPtr array);

		[MethodImpl(4096)]
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2DD9CEC", Offset = "0x2DD5CEC", VA = "0x2DD9CEC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewBooleanArray(int size);

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2DD9D28", Offset = "0x2DD5D28", VA = "0x2DD9D28")]
		[Obsolete("AndroidJNI.NewByteArray is obsolete. Use AndroidJNI.NewSByteArray method instead")]
		public static IntPtr NewByteArray(int size)
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2DD9D64", Offset = "0x2DD5D64", VA = "0x2DD9D64")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewSByteArray(int size);

		[MethodImpl(4096)]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2DD9DA0", Offset = "0x2DD5DA0", VA = "0x2DD9DA0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewCharArray(int size);

		[MethodImpl(4096)]
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2DD9DDC", Offset = "0x2DD5DDC", VA = "0x2DD9DDC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewShortArray(int size);

		[MethodImpl(4096)]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2DD9E18", Offset = "0x2DD5E18", VA = "0x2DD9E18")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewIntArray(int size);

		[MethodImpl(4096)]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2DD9E54", Offset = "0x2DD5E54", VA = "0x2DD9E54")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewLongArray(int size);

		[MethodImpl(4096)]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2DD9E90", Offset = "0x2DD5E90", VA = "0x2DD9E90")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewFloatArray(int size);

		[MethodImpl(4096)]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2DD9ECC", Offset = "0x2DD5ECC", VA = "0x2DD9ECC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewDoubleArray(int size);

		[MethodImpl(4096)]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2DD9F08", Offset = "0x2DD5F08", VA = "0x2DD9F08")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2DD9F5C", Offset = "0x2DD5F5C", VA = "0x2DD9F5C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern bool GetBooleanArrayElement(IntPtr array, int index);

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2DD9FA0", Offset = "0x2DD5FA0", VA = "0x2DD9FA0")]
		[Obsolete("AndroidJNI.GetByteArrayElement is obsolete. Use AndroidJNI.GetSByteArrayElement method instead")]
		public static byte GetByteArrayElement(IntPtr array, int index)
		{
			return default(byte);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2DD9FE4", Offset = "0x2DD5FE4", VA = "0x2DD9FE4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern sbyte GetSByteArrayElement(IntPtr array, int index);

		[MethodImpl(4096)]
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2DDA028", Offset = "0x2DD6028", VA = "0x2DDA028")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern char GetCharArrayElement(IntPtr array, int index);

		[MethodImpl(4096)]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2DDA06C", Offset = "0x2DD606C", VA = "0x2DDA06C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern short GetShortArrayElement(IntPtr array, int index);

		[MethodImpl(4096)]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2DDA0B0", Offset = "0x2DD60B0", VA = "0x2DDA0B0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int GetIntArrayElement(IntPtr array, int index);

		[MethodImpl(4096)]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2DDA0F4", Offset = "0x2DD60F4", VA = "0x2DDA0F4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern long GetLongArrayElement(IntPtr array, int index);

		[MethodImpl(4096)]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2DDA138", Offset = "0x2DD6138", VA = "0x2DDA138")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern float GetFloatArrayElement(IntPtr array, int index);

		[MethodImpl(4096)]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2DDA17C", Offset = "0x2DD617C", VA = "0x2DDA17C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern double GetDoubleArrayElement(IntPtr array, int index);

		[MethodImpl(4096)]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2DDA1C0", Offset = "0x2DD61C0", VA = "0x2DDA1C0")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern IntPtr GetObjectArrayElement(IntPtr array, int index);

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2DDA204", Offset = "0x2DD6204", VA = "0x2DDA204")]
		[Obsolete("AndroidJNI.SetBooleanArrayElement(IntPtr, int, byte) is obsolete. Use AndroidJNI.SetBooleanArrayElement(IntPtr, int, bool) method instead")]
		public static void SetBooleanArrayElement(IntPtr array, int index, byte val)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2DDA25C", Offset = "0x2DD625C", VA = "0x2DDA25C")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetBooleanArrayElement(IntPtr array, int index, bool val);

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2DDA2B0", Offset = "0x2DD62B0", VA = "0x2DDA2B0")]
		[Obsolete("AndroidJNI.SetByteArrayElement is obsolete. Use AndroidJNI.SetSByteArrayElement method instead")]
		public static void SetByteArrayElement(IntPtr array, int index, sbyte val)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2DDA304", Offset = "0x2DD6304", VA = "0x2DDA304")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetSByteArrayElement(IntPtr array, int index, sbyte val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2DDA358", Offset = "0x2DD6358", VA = "0x2DDA358")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetCharArrayElement(IntPtr array, int index, char val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2DDA3AC", Offset = "0x2DD63AC", VA = "0x2DDA3AC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetShortArrayElement(IntPtr array, int index, short val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2DDA400", Offset = "0x2DD6400", VA = "0x2DDA400")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetIntArrayElement(IntPtr array, int index, int val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2DDA454", Offset = "0x2DD6454", VA = "0x2DDA454")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetLongArrayElement(IntPtr array, int index, long val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2DDA4A8", Offset = "0x2DD64A8", VA = "0x2DDA4A8")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetFloatArrayElement(IntPtr array, int index, float val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2DDA4FC", Offset = "0x2DD64FC", VA = "0x2DDA4FC")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetDoubleArrayElement(IntPtr array, int index, double val);

		[MethodImpl(4096)]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2DDA550", Offset = "0x2DD6550", VA = "0x2DDA550")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern void SetObjectArrayElement(IntPtr array, int index, IntPtr obj);

		[MethodImpl(4096)]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2DDA5A4", Offset = "0x2DD65A4", VA = "0x2DDA5A4")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern IntPtr NewDirectByteBuffer(byte* buffer, long capacity);

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2DDA5E8", Offset = "0x2DD65E8", VA = "0x2DDA5E8")]
		public static IntPtr NewDirectByteBuffer(NativeArray<byte> buffer)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2DDA640", Offset = "0x2DD6640", VA = "0x2DDA640")]
		public static IntPtr NewDirectByteBuffer(NativeArray<sbyte> buffer)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600010C")]
		private static IntPtr NewDirectByteBufferFromNativeArray<T>(NativeArray<T> buffer) where T : struct
		{
			return default(IntPtr);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2DDA698", Offset = "0x2DD6698", VA = "0x2DDA698")]
		[UnityEngine.Bindings.ThreadSafe]
		public unsafe static extern sbyte* GetDirectBufferAddress(IntPtr buffer);

		[MethodImpl(4096)]
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2DDA6D4", Offset = "0x2DD66D4", VA = "0x2DDA6D4")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern long GetDirectBufferCapacity(IntPtr buffer);

		[Token(Token = "0x600010F")]
		private static NativeArray<T> GetDirectBuffer<T>(IntPtr buffer) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2DDA710", Offset = "0x2DD6710", VA = "0x2DDA710")]
		public static NativeArray<byte> GetDirectByteBuffer(IntPtr buffer)
		{
			return default(NativeArray<byte>);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2DDA758", Offset = "0x2DD6758", VA = "0x2DDA758")]
		public static NativeArray<sbyte> GetDirectSByteBuffer(IntPtr buffer)
		{
			return default(NativeArray<sbyte>);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2DDA7A0", Offset = "0x2DD67A0", VA = "0x2DDA7A0")]
		public static int RegisterNatives(IntPtr clazz, JNINativeMethod[] methods)
		{
			return default(int);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2DDA92C", Offset = "0x2DD692C", VA = "0x2DDA92C")]
		[UnityEngine.Bindings.ThreadSafe]
		private static extern IntPtr RegisterNativesAllocate(int length);

		[MethodImpl(4096)]
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2DDA968", Offset = "0x2DD6968", VA = "0x2DDA968")]
		[UnityEngine.Bindings.ThreadSafe]
		private static extern void RegisterNativesSet(IntPtr natives, int idx, string name, string signature, IntPtr fnPtr);

		[MethodImpl(4096)]
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2DDA9D4", Offset = "0x2DD69D4", VA = "0x2DDA9D4")]
		[UnityEngine.Bindings.ThreadSafe]
		private static extern int RegisterNativesAndFree(IntPtr clazz, IntPtr natives, int n);

		[MethodImpl(4096)]
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2DDAA28", Offset = "0x2DD6A28", VA = "0x2DDAA28")]
		[UnityEngine.Bindings.ThreadSafe]
		public static extern int UnregisterNatives(IntPtr clazz);
	}
	[Token(Token = "0x2000006")]
	internal class AndroidJNISafe
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2DDAA64", Offset = "0x2DD6A64", VA = "0x2DDAA64")]
		public static void CheckException()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2DDAD94", Offset = "0x2DD6D94", VA = "0x2DDAD94")]
		public static void QueueDeleteGlobalRef(IntPtr globalref)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2DDADEC", Offset = "0x2DD6DEC", VA = "0x2DDADEC")]
		public static void DeleteWeakGlobalRef(IntPtr globalref)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2DDAE44", Offset = "0x2DD6E44", VA = "0x2DDAE44")]
		public static void DeleteLocalRef(IntPtr localref)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2DDAE9C", Offset = "0x2DD6E9C", VA = "0x2DDAE9C")]
		public static IntPtr NewString(string chars)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2DDAF3C", Offset = "0x2DD6F3C", VA = "0x2DDAF3C")]
		public static string GetStringChars(IntPtr str)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2DD5574", Offset = "0x2DD1574", VA = "0x2DD5574")]
		public static IntPtr GetObjectClass(IntPtr ptr)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2DD506C", Offset = "0x2DD106C", VA = "0x2DD506C")]
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2DD5614", Offset = "0x2DD1614", VA = "0x2DD5614")]
		public static IntPtr GetMethodID(IntPtr obj, string name, string sig)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2DDAFDC", Offset = "0x2DD6FDC", VA = "0x2DDAFDC")]
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2DDB094", Offset = "0x2DD7094", VA = "0x2DDB094")]
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2DDB14C", Offset = "0x2DD714C", VA = "0x2DDB14C")]
		public static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2DD4FCC", Offset = "0x2DD0FCC", VA = "0x2DD4FCC")]
		public static IntPtr FindClass(string name)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2DDB1EC", Offset = "0x2DD71EC", VA = "0x2DDB1EC")]
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2DDB25C", Offset = "0x2DD725C", VA = "0x2DDB25C")]
		public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2DDB31C", Offset = "0x2DD731C", VA = "0x2DDB31C")]
		public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2DDB3DC", Offset = "0x2DD73DC", VA = "0x2DDB3DC")]
		public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2DDB49C", Offset = "0x2DD749C", VA = "0x2DDB49C")]
		public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2DDB55C", Offset = "0x2DD755C", VA = "0x2DDB55C")]
		public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2DDB61C", Offset = "0x2DD761C", VA = "0x2DDB61C")]
		public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2DDB6DC", Offset = "0x2DD76DC", VA = "0x2DDB6DC")]
		public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2DDB79C", Offset = "0x2DD779C", VA = "0x2DDB79C")]
		public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2DDB85C", Offset = "0x2DD785C", VA = "0x2DDB85C")]
		public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2DDB91C", Offset = "0x2DD791C", VA = "0x2DDB91C")]
		public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2DDB9DC", Offset = "0x2DD79DC", VA = "0x2DDB9DC")]
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2DDBA84", Offset = "0x2DD7A84", VA = "0x2DDBA84")]
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2DDBB2C", Offset = "0x2DD7B2C", VA = "0x2DDBB2C")]
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
		{
			return default(char);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2DDBBD4", Offset = "0x2DD7BD4", VA = "0x2DDBBD4")]
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
		{
			return default(double);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2DDBC88", Offset = "0x2DD7C88", VA = "0x2DDBC88")]
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
		{
			return default(float);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2DDBD3C", Offset = "0x2DD7D3C", VA = "0x2DDBD3C")]
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
		{
			return default(long);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2DDBDE4", Offset = "0x2DD7DE4", VA = "0x2DDBDE4")]
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
		{
			return default(short);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2DDBE8C", Offset = "0x2DD7E8C", VA = "0x2DDBE8C")]
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2DDBF34", Offset = "0x2DD7F34", VA = "0x2DDBF34")]
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2DDBFDC", Offset = "0x2DD7FDC", VA = "0x2DDBFDC")]
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
		{
			return default(int);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2DDC084", Offset = "0x2DD8084", VA = "0x2DDC084")]
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2DDC0F4", Offset = "0x2DD80F4", VA = "0x2DDC0F4")]
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2DD5124", Offset = "0x2DD1124", VA = "0x2DD5124")]
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2DDC15C", Offset = "0x2DD815C", VA = "0x2DDC15C")]
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2DDC1C4", Offset = "0x2DD81C4", VA = "0x2DDC1C4")]
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2DDC234", Offset = "0x2DD8234", VA = "0x2DDC234")]
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(char);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2DDC2A4", Offset = "0x2DD82A4", VA = "0x2DDC2A4")]
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(double);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2DDC320", Offset = "0x2DD8320", VA = "0x2DDC320")]
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(float);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2DDC39C", Offset = "0x2DD839C", VA = "0x2DDC39C")]
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(long);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2DDC40C", Offset = "0x2DD840C", VA = "0x2DDC40C")]
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(short);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2DDC47C", Offset = "0x2DD847C", VA = "0x2DDC47C")]
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2DDC4EC", Offset = "0x2DD84EC", VA = "0x2DDC4EC")]
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2DDC55C", Offset = "0x2DD855C", VA = "0x2DDC55C")]
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			return default(int);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2DDC5CC", Offset = "0x2DD85CC", VA = "0x2DDC5CC")]
		public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2DDC68C", Offset = "0x2DD868C", VA = "0x2DDC68C")]
		public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2DDC74C", Offset = "0x2DD874C", VA = "0x2DDC74C")]
		public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2DDC80C", Offset = "0x2DD880C", VA = "0x2DDC80C")]
		public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2DDC8CC", Offset = "0x2DD88CC", VA = "0x2DDC8CC")]
		public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2DDC98C", Offset = "0x2DD898C", VA = "0x2DDC98C")]
		public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2DDCA4C", Offset = "0x2DD8A4C", VA = "0x2DDCA4C")]
		public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2DDCB0C", Offset = "0x2DD8B0C", VA = "0x2DDCB0C")]
		public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2DDCBCC", Offset = "0x2DD8BCC", VA = "0x2DDCBCC")]
		public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2DDCC8C", Offset = "0x2DD8C8C", VA = "0x2DDCC8C")]
		public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2DDCD4C", Offset = "0x2DD8D4C", VA = "0x2DDCD4C")]
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2DDCDF4", Offset = "0x2DD8DF4", VA = "0x2DDCDF4")]
		public static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2DDCE9C", Offset = "0x2DD8E9C", VA = "0x2DDCE9C")]
		public static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			return default(char);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2DDCF44", Offset = "0x2DD8F44", VA = "0x2DDCF44")]
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			return default(double);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2DDCFF8", Offset = "0x2DD8FF8", VA = "0x2DDCFF8")]
		public static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			return default(float);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2DDD0AC", Offset = "0x2DD90AC", VA = "0x2DDD0AC")]
		public static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			return default(long);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2DDD154", Offset = "0x2DD9154", VA = "0x2DDD154")]
		public static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			return default(short);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2DDD1FC", Offset = "0x2DD91FC", VA = "0x2DDD1FC")]
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2DDD2A4", Offset = "0x2DD92A4", VA = "0x2DDD2A4")]
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2DDD34C", Offset = "0x2DD934C", VA = "0x2DDD34C")]
		public static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			return default(int);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2DDD3F4", Offset = "0x2DD93F4", VA = "0x2DDD3F4")]
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2DDD464", Offset = "0x2DD9464", VA = "0x2DDD464")]
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2DDD4CC", Offset = "0x2DD94CC", VA = "0x2DDD4CC")]
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2DDD53C", Offset = "0x2DD953C", VA = "0x2DDD53C")]
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2DD5D3C", Offset = "0x2DD1D3C", VA = "0x2DD5D3C")]
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(char);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2DD5C38", Offset = "0x2DD1C38", VA = "0x2DD5C38")]
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(double);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2DD5B34", Offset = "0x2DD1B34", VA = "0x2DD5B34")]
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2DD5A3C", Offset = "0x2DD1A3C", VA = "0x2DD5A3C")]
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(long);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2DD584C", Offset = "0x2DD184C", VA = "0x2DD584C")]
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(short);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2DD5754", Offset = "0x2DD1754", VA = "0x2DD5754")]
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2DD5E38", Offset = "0x2DD1E38", VA = "0x2DD5E38")]
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2DD5944", Offset = "0x2DD1944", VA = "0x2DD5944")]
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			return default(int);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2DDD5AC", Offset = "0x2DD95AC", VA = "0x2DDD5AC")]
		public static char[] FromCharArray(IntPtr array)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2DDD64C", Offset = "0x2DD964C", VA = "0x2DDD64C")]
		public static double[] FromDoubleArray(IntPtr array)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2DDD6EC", Offset = "0x2DD96EC", VA = "0x2DDD6EC")]
		public static float[] FromFloatArray(IntPtr array)
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2DDD78C", Offset = "0x2DD978C", VA = "0x2DDD78C")]
		public static long[] FromLongArray(IntPtr array)
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2DDD82C", Offset = "0x2DD982C", VA = "0x2DDD82C")]
		public static short[] FromShortArray(IntPtr array)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2DDD8CC", Offset = "0x2DD98CC", VA = "0x2DDD8CC")]
		public static byte[] FromByteArray(IntPtr array)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2DDD96C", Offset = "0x2DD996C", VA = "0x2DDD96C")]
		public static sbyte[] FromSByteArray(IntPtr array)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2DDDA0C", Offset = "0x2DD9A0C", VA = "0x2DDDA0C")]
		public static bool[] FromBooleanArray(IntPtr array)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2DDDAAC", Offset = "0x2DD9AAC", VA = "0x2DDDAAC")]
		public static int[] FromIntArray(IntPtr array)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2DDDB4C", Offset = "0x2DD9B4C", VA = "0x2DDDB4C")]
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2DDDBBC", Offset = "0x2DD9BBC", VA = "0x2DDDBBC")]
		public static IntPtr ToCharArray(char[] array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2DDDC2C", Offset = "0x2DD9C2C", VA = "0x2DDDC2C")]
		public static IntPtr ToDoubleArray(double[] array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2DDDC9C", Offset = "0x2DD9C9C", VA = "0x2DDDC9C")]
		public static IntPtr ToFloatArray(float[] array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2DDDD0C", Offset = "0x2DD9D0C", VA = "0x2DDDD0C")]
		public static IntPtr ToLongArray(long[] array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2DDDD7C", Offset = "0x2DD9D7C", VA = "0x2DDDD7C")]
		public static IntPtr ToShortArray(short[] array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2DDDDEC", Offset = "0x2DD9DEC", VA = "0x2DDDDEC")]
		public static IntPtr ToByteArray(byte[] array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2DDDE8C", Offset = "0x2DD9E8C", VA = "0x2DDDE8C")]
		public static IntPtr ToSByteArray(sbyte[] array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2DDDEFC", Offset = "0x2DD9EFC", VA = "0x2DDDEFC")]
		public static IntPtr ToBooleanArray(bool[] array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2DDDFA0", Offset = "0x2DD9FA0", VA = "0x2DDDFA0")]
		public static IntPtr ToIntArray(int[] array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2DDE010", Offset = "0x2DDA010", VA = "0x2DDE010")]
		public static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2DDE0B8", Offset = "0x2DDA0B8", VA = "0x2DDE0B8")]
		public static int GetArrayLength(IntPtr array)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000007")]
	public delegate void AndroidJavaRunnable();
	[Token(Token = "0x2000008")]
	public sealed class AndroidJavaException : Exception
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string mJavaStackTrace;

		[Token(Token = "0x17000002")]
		public override string StackTrace
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2DDE1F4", Offset = "0x2DDA1F4", VA = "0x2DDE1F4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2DDAD20", Offset = "0x2DD6D20", VA = "0x2DDAD20")]
		internal AndroidJavaException(string message, string javaStackTrace)
		{
		}
	}
	[Token(Token = "0x2000009")]
	internal class GlobalJavaObjectRef
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_disposed;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected IntPtr m_jobject;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2DDE218", Offset = "0x2DDA218", VA = "0x2DDE218")]
		public GlobalJavaObjectRef(IntPtr jobject)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2DDE288", Offset = "0x2DDA288", VA = "0x2DDE288", Slot = "1")]
		~GlobalJavaObjectRef()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2DDE34C", Offset = "0x2DDA34C", VA = "0x2DDE34C")]
		public static implicit operator IntPtr(GlobalJavaObjectRef obj)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2DDE30C", Offset = "0x2DDA30C", VA = "0x2DDE30C")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200000A")]
	internal class AndroidJavaRunnableProxy : AndroidJavaProxy
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AndroidJavaRunnable mRunnable;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2DDE360", Offset = "0x2DDA360", VA = "0x2DDE360")]
		public AndroidJavaRunnableProxy(AndroidJavaRunnable runnable)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2DDE460", Offset = "0x2DDA460", VA = "0x2DDE460")]
		public void run()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2DDE480", Offset = "0x2DDA480", VA = "0x2DDE480", Slot = "6")]
		public override IntPtr Invoke(string methodName, IntPtr javaArgs)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200000B")]
	public class AndroidJavaProxy
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly AndroidJavaClass javaInterface;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal IntPtr proxyObject;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly GlobalJavaObjectRef s_JavaLangSystemClass;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly IntPtr s_HashCodeMethodID;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2DDE3E0", Offset = "0x2DDA3E0", VA = "0x2DDE3E0")]
		public AndroidJavaProxy(string javaInterface)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2DDE90C", Offset = "0x2DDA90C", VA = "0x2DDE90C")]
		public AndroidJavaProxy(AndroidJavaClass javaInterface)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2DDE938", Offset = "0x2DDA938", VA = "0x2DDE938", Slot = "1")]
		~AndroidJavaProxy()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2DDE9C4", Offset = "0x2DDA9C4", VA = "0x2DDE9C4", Slot = "4")]
		public virtual AndroidJavaObject Invoke(string methodName, object[] args)
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2DDFE3C", Offset = "0x2DDBE3C", VA = "0x2DDFE3C", Slot = "5")]
		public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs)
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2DDE540", Offset = "0x2DDA540", VA = "0x2DDE540", Slot = "6")]
		public virtual IntPtr Invoke(string methodName, IntPtr javaArgs)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2DE0B08", Offset = "0x2DDCB08", VA = "0x2DE0B08", Slot = "7")]
		public virtual bool equals(AndroidJavaObject obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2DE0B60", Offset = "0x2DDCB60", VA = "0x2DE0B60", Slot = "8")]
		public virtual int hashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2DE0D50", Offset = "0x2DDCD50", VA = "0x2DE0D50", Slot = "9")]
		public virtual string toString()
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2DE0DB4", Offset = "0x2DDCDB4", VA = "0x2DE0DB4")]
		internal AndroidJavaObject GetProxyObject()
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2DE0C58", Offset = "0x2DDCC58", VA = "0x2DE0C58")]
		internal IntPtr GetRawProxy()
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200000C")]
	public class AndroidJavaObject : IDisposable
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool enableDebugPrints;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal GlobalJavaObjectRef m_jobject;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal GlobalJavaObjectRef m_jclass;

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2DE0EBC", Offset = "0x2DDCEBC", VA = "0x2DE0EBC")]
		public AndroidJavaObject(string className, string[] args)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2DE1068", Offset = "0x2DDD068", VA = "0x2DE1068")]
		public AndroidJavaObject(string className, AndroidJavaObject[] args)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2DE111C", Offset = "0x2DDD11C", VA = "0x2DE111C")]
		public AndroidJavaObject(string className, AndroidJavaClass[] args)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2DE11D0", Offset = "0x2DDD1D0", VA = "0x2DE11D0")]
		public AndroidJavaObject(string className, AndroidJavaProxy[] args)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2DE1284", Offset = "0x2DDD284", VA = "0x2DE1284")]
		public AndroidJavaObject(string className, AndroidJavaRunnable[] args)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2DE1338", Offset = "0x2DDD338", VA = "0x2DE1338")]
		public AndroidJavaObject(string className, params object[] args)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2DDFD44", Offset = "0x2DDBD44", VA = "0x2DDFD44")]
		public AndroidJavaObject(IntPtr jobject)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2DE136C", Offset = "0x2DDD36C", VA = "0x2DE136C")]
		public AndroidJavaObject(IntPtr clazz, IntPtr constructorID, params object[] args)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2DE09B8", Offset = "0x2DDC9B8", VA = "0x2DE09B8", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600019B")]
		public void Call<T>(string methodName, T[] args)
		{
		}

		[Token(Token = "0x600019C")]
		public void Call<T>(IntPtr methodID, T[] args)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2DE1600", Offset = "0x2DDD600", VA = "0x2DE1600")]
		public void Call(string methodName, params object[] args)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2DE1664", Offset = "0x2DDD664", VA = "0x2DE1664")]
		public void Call(IntPtr methodID, params object[] args)
		{
		}

		[Token(Token = "0x600019F")]
		public void CallStatic<T>(string methodName, T[] args)
		{
		}

		[Token(Token = "0x60001A0")]
		public void CallStatic<T>(IntPtr methodID, T[] args)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2DE1830", Offset = "0x2DDD830", VA = "0x2DE1830")]
		public void CallStatic(string methodName, params object[] args)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2DE1894", Offset = "0x2DDD894", VA = "0x2DE1894")]
		public void CallStatic(IntPtr methodID, params object[] args)
		{
		}

		[Token(Token = "0x60001A3")]
		public FieldType Get<FieldType>(string fieldName)
		{
			return (FieldType)null;
		}

		[Token(Token = "0x60001A4")]
		public FieldType Get<FieldType>(IntPtr fieldID)
		{
			return (FieldType)null;
		}

		[Token(Token = "0x60001A5")]
		public void Set<FieldType>(string fieldName, FieldType val)
		{
		}

		[Token(Token = "0x60001A6")]
		public void Set<FieldType>(IntPtr fieldID, FieldType val)
		{
		}

		[Token(Token = "0x60001A7")]
		public FieldType GetStatic<FieldType>(string fieldName)
		{
			return (FieldType)null;
		}

		[Token(Token = "0x60001A8")]
		public FieldType GetStatic<FieldType>(IntPtr fieldID)
		{
			return (FieldType)null;
		}

		[Token(Token = "0x60001A9")]
		public void SetStatic<FieldType>(string fieldName, FieldType val)
		{
		}

		[Token(Token = "0x60001AA")]
		public void SetStatic<FieldType>(IntPtr fieldID, FieldType val)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2DE0AF0", Offset = "0x2DDCAF0", VA = "0x2DE0AF0")]
		public IntPtr GetRawObject()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2DE1A78", Offset = "0x2DDDA78", VA = "0x2DE1A78")]
		public IntPtr GetRawClass()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2DE1AA8", Offset = "0x2DDDAA8", VA = "0x2DE1AA8")]
		public AndroidJavaObject CloneReference()
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		public ReturnType Call<ReturnType, T>(string methodName, T[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001AF")]
		public ReturnType Call<ReturnType, T>(IntPtr methodID, T[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001B0")]
		public ReturnType Call<ReturnType>(string methodName, params object[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001B1")]
		public ReturnType Call<ReturnType>(IntPtr methodID, params object[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001B2")]
		public ReturnType CallStatic<ReturnType, T>(string methodName, T[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001B3")]
		public ReturnType CallStatic<ReturnType, T>(IntPtr methodID, T[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001B4")]
		public ReturnType CallStatic<ReturnType>(string methodName, params object[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001B5")]
		public ReturnType CallStatic<ReturnType>(IntPtr methodID, params object[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2DE1CB8", Offset = "0x2DDDCB8", VA = "0x2DE1CB8")]
		protected void DebugPrint(string msg)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2DE1D40", Offset = "0x2DDDD40", VA = "0x2DE1D40")]
		protected void DebugPrint(string call, string methodName, string signature, object[] args)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2DE0F78", Offset = "0x2DDCF78", VA = "0x2DE0F78")]
		private void _AndroidJavaObject(string className, params object[] args)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2DE13F8", Offset = "0x2DDD3F8", VA = "0x2DE13F8")]
		private void _AndroidJavaObject(IntPtr constructorID, params object[] args)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2DE0F70", Offset = "0x2DDCF70", VA = "0x2DE0F70")]
		internal AndroidJavaObject()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2DE1FD8", Offset = "0x2DDDFD8", VA = "0x2DE1FD8", Slot = "1")]
		~AndroidJavaObject()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2DE2068", Offset = "0x2DDE068", VA = "0x2DE2068", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2DE1604", Offset = "0x2DDD604", VA = "0x2DE1604")]
		protected void _Call(string methodName, params object[] args)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2DE1668", Offset = "0x2DDD668", VA = "0x2DE1668")]
		protected void _Call(IntPtr methodID, params object[] args)
		{
		}

		[Token(Token = "0x60001BF")]
		protected ReturnType _Call<ReturnType>(string methodName, params object[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001C0")]
		protected ReturnType _Call<ReturnType>(IntPtr methodID, params object[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001C1")]
		protected FieldType _Get<FieldType>(string fieldName)
		{
			return (FieldType)null;
		}

		[Token(Token = "0x60001C2")]
		protected FieldType _Get<FieldType>(IntPtr fieldID)
		{
			return (FieldType)null;
		}

		[Token(Token = "0x60001C3")]
		protected void _Set<FieldType>(string fieldName, FieldType val)
		{
		}

		[Token(Token = "0x60001C4")]
		protected void _Set<FieldType>(IntPtr fieldID, FieldType val)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2DE1834", Offset = "0x2DDD834", VA = "0x2DE1834")]
		protected void _CallStatic(string methodName, params object[] args)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2DE1898", Offset = "0x2DDD898", VA = "0x2DE1898")]
		protected void _CallStatic(IntPtr methodID, params object[] args)
		{
		}

		[Token(Token = "0x60001C7")]
		protected ReturnType _CallStatic<ReturnType>(string methodName, params object[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001C8")]
		protected ReturnType _CallStatic<ReturnType>(IntPtr methodID, params object[] args)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001C9")]
		protected FieldType _GetStatic<FieldType>(string fieldName)
		{
			return (FieldType)null;
		}

		[Token(Token = "0x60001CA")]
		protected FieldType _GetStatic<FieldType>(IntPtr fieldID)
		{
			return (FieldType)null;
		}

		[Token(Token = "0x60001CB")]
		protected void _SetStatic<FieldType>(string fieldName, FieldType val)
		{
		}

		[Token(Token = "0x60001CC")]
		protected void _SetStatic<FieldType>(IntPtr fieldID, FieldType val)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2DE0A24", Offset = "0x2DDCA24", VA = "0x2DE0A24")]
		internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2DE2098", Offset = "0x2DDE098", VA = "0x2DE2098")]
		internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject)
		{
			return (ReturnType)null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2DE1A60", Offset = "0x2DDDA60", VA = "0x2DE1A60")]
		protected IntPtr _GetRawObject()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2DE1A90", Offset = "0x2DDDA90", VA = "0x2DE1A90")]
		protected IntPtr _GetRawClass()
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200000D")]
	public class AndroidJavaClass : AndroidJavaObject
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2DDE8E0", Offset = "0x2DDA8E0", VA = "0x2DDE8E0")]
		public AndroidJavaClass(string className)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2DE2164", Offset = "0x2DDE164", VA = "0x2DE2164")]
		private void _AndroidJavaClass(string className)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2DE1BF4", Offset = "0x2DDDBF4", VA = "0x2DE1BF4")]
		internal AndroidJavaClass(IntPtr jclass)
		{
		}
	}
	[Token(Token = "0x200000E")]
	internal class AndroidReflection
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly GlobalJavaObjectRef s_ReflectionHelperClass;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly IntPtr s_ReflectionHelperGetConstructorID;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly IntPtr s_ReflectionHelperGetMethodID;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly IntPtr s_ReflectionHelperGetFieldID;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly IntPtr s_ReflectionHelperGetFieldSignature;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly IntPtr s_ReflectionHelperNewProxyInstance;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly IntPtr s_ReflectionHelperCeateInvocationError;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly IntPtr s_FieldGetDeclaringClass;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2DE2220", Offset = "0x2DDE220", VA = "0x2DE2220")]
		public static bool IsPrimitive(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2DE2234", Offset = "0x2DDE234", VA = "0x2DE2234")]
		public static bool IsAssignableFrom(Type t, Type from)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2DE2250", Offset = "0x2DDE250", VA = "0x2DE2250")]
		private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2DE22F0", Offset = "0x2DDE2F0", VA = "0x2DE22F0")]
		private static IntPtr GetMethodID(string clazz, string methodName, string signature)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2DE2390", Offset = "0x2DDE390", VA = "0x2DE2390")]
		public static IntPtr GetConstructorMember(IntPtr jclass, string signature)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2DE2510", Offset = "0x2DDE510", VA = "0x2DE2510")]
		public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2DE2718", Offset = "0x2DDE718", VA = "0x2DE2718")]
		public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2DE2920", Offset = "0x2DDE920", VA = "0x2DE2920")]
		public static IntPtr GetFieldClass(IntPtr field)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2DE2984", Offset = "0x2DDE984", VA = "0x2DE2984")]
		public static string GetFieldSignature(IntPtr field)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2DE2A2C", Offset = "0x2DDEA2C", VA = "0x2DE2A2C")]
		public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2DDFC58", Offset = "0x2DDBC58", VA = "0x2DDFC58")]
		internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200000F")]
	[UnityEngine.Scripting.UsedByNativeCode]
	internal sealed class _AndroidJNIHelper
	{
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2DD2AC4", Offset = "0x2DCEAC4", VA = "0x2DD2AC4")]
		public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2DD2944", Offset = "0x2DCE944", VA = "0x2DD2944")]
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2DE2DCC", Offset = "0x2DDEDCC", VA = "0x2DE2DCC")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2DD377C", Offset = "0x2DCF77C", VA = "0x2DD377C")]
		public static void CreateJNIArgArray(object[] args, Span<jvalue> ret)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2DE2EE4", Offset = "0x2DDEEE4", VA = "0x2DE2EE4")]
		public static object UnboxArray(AndroidJavaObject obj)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2DDFFB0", Offset = "0x2DDBFB0", VA = "0x2DDFFB0")]
		public static object Unbox(AndroidJavaObject obj)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2DDF300", Offset = "0x2DDB300", VA = "0x2DDF300")]
		public static AndroidJavaObject Box(object obj)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2DD3E84", Offset = "0x2DCFE84", VA = "0x2DD3E84")]
		public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2DD2B50", Offset = "0x2DCEB50", VA = "0x2DD2B50")]
		public static IntPtr ConvertToJNIArray(Array array)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001EA")]
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			return (ArrayType)null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2DD4000", Offset = "0x2DD0000", VA = "0x2DD4000")]
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2DD4058", Offset = "0x2DD0058", VA = "0x2DD4058")]
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001ED")]
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001EE")]
		public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2DD21E0", Offset = "0x2DCE1E0", VA = "0x2DD21E0")]
		public static IntPtr GetConstructorID(IntPtr jclass, string signature)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2DD242C", Offset = "0x2DCE42C", VA = "0x2DD242C")]
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2DE369C", Offset = "0x2DDF69C", VA = "0x2DE369C")]
		private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2DD2688", Offset = "0x2DCE688", VA = "0x2DD2688")]
		public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2DD4094", Offset = "0x2DD0094", VA = "0x2DD4094")]
		public static string GetSignature(object obj)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2DD4DAC", Offset = "0x2DD0DAC", VA = "0x2DD4DAC")]
		public static string GetSignature(object[] args)
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		public static string GetSignature<ReturnType>(object[] args)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2DE3730", Offset = "0x2DDF730", VA = "0x2DE3730")]
		public _AndroidJNIHelper()
		{
		}
	}
}
namespace UnityEngine.Android
{
	[Token(Token = "0x2000010")]
	[UnityEngine.Bindings.NativeHeader("Modules/AndroidJNI/Public/AndroidApp.bindings.h")]
	[UnityEngine.Bindings.StaticAccessor("AndroidApp", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeConditional("PLATFORM_ANDROID")]
	internal static class AndroidApp
	{
		[Token(Token = "0x17000003")]
		public static extern IntPtr UnityPlayerRaw
		{
			[MethodImpl(4096)]
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x2DD2A9C", Offset = "0x2DCEA9C", VA = "0x2DD2A9C")]
			[UnityEngine.Bindings.ThreadSafe]
			get;
		}
	}
	[Token(Token = "0x2000011")]
	public enum AndroidAssetPackStatus
	{
		[Token(Token = "0x4000021")]
		Unknown,
		[Token(Token = "0x4000022")]
		Pending,
		[Token(Token = "0x4000023")]
		Downloading,
		[Token(Token = "0x4000024")]
		Transferring,
		[Token(Token = "0x4000025")]
		Completed,
		[Token(Token = "0x4000026")]
		Failed,
		[Token(Token = "0x4000027")]
		Canceled,
		[Token(Token = "0x4000028")]
		WaitingForWifi,
		[Token(Token = "0x4000029")]
		NotInstalled
	}
	[Token(Token = "0x2000012")]
	public enum AndroidAssetPackError
	{
		[Token(Token = "0x400002B")]
		NoError = 0,
		[Token(Token = "0x400002C")]
		AppUnavailable = -1,
		[Token(Token = "0x400002D")]
		PackUnavailable = -2,
		[Token(Token = "0x400002E")]
		InvalidRequest = -3,
		[Token(Token = "0x400002F")]
		DownloadNotFound = -4,
		[Token(Token = "0x4000030")]
		ApiNotAvailable = -5,
		[Token(Token = "0x4000031")]
		NetworkError = -6,
		[Token(Token = "0x4000032")]
		AccessDenied = -7,
		[Token(Token = "0x4000033")]
		InsufficientStorage = -10,
		[Token(Token = "0x4000034")]
		PlayStoreNotFound = -11,
		[Token(Token = "0x4000035")]
		NetworkUnrestricted = -12,
		[Token(Token = "0x4000036")]
		AppNotOwned = -13,
		[Token(Token = "0x4000037")]
		InternalError = -100
	}
	[Token(Token = "0x2000013")]
	public class AndroidAssetPackInfo
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2DE3738", Offset = "0x2DDF738", VA = "0x2DE3738")]
		internal AndroidAssetPackInfo(string name, AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, AndroidAssetPackError error)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class AndroidAssetPackState
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2DE379C", Offset = "0x2DDF79C", VA = "0x2DE379C")]
		internal AndroidAssetPackState(string name, AndroidAssetPackStatus status, AndroidAssetPackError error)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class AndroidAssetPackUseMobileDataRequestResult
	{
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2DE37D8", Offset = "0x2DDF7D8", VA = "0x2DE37D8")]
		internal AndroidAssetPackUseMobileDataRequestResult(bool allowed)
		{
		}
	}
	[Token(Token = "0x2000016")]
	[UnityEngine.Bindings.StaticAccessor("AndroidAssetPacksBindingsHelpers", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeHeader("Modules/AndroidJNI/Public/AndroidAssetPacksBindingsHelpers.h")]
	public static class AndroidAssetPacks
	{
		[Token(Token = "0x2000017")]
		private class AssetPackManagerDownloadStatusCallback : AndroidJavaProxy
		{
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Action<AndroidAssetPackInfo> m_Callback;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string[] m_AssetPacks;

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x2DE3B6C", Offset = "0x2DDFB6C", VA = "0x2DE3B6C")]
			public AssetPackManagerDownloadStatusCallback(Action<AndroidAssetPackInfo> callback, string[] assetPacks)
			{
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x2DE3BF0", Offset = "0x2DDFBF0", VA = "0x2DE3BF0")]
			[Preserve]
			private void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode)
			{
			}
		}

		[Token(Token = "0x2000018")]
		private class AssetPackManagerMobileDataConfirmationCallback : AndroidJavaProxy
		{
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Action<AndroidAssetPackUseMobileDataRequestResult> m_Callback;

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x2DE3CFC", Offset = "0x2DDFCFC", VA = "0x2DE3CFC")]
			public AssetPackManagerMobileDataConfirmationCallback(Action<AndroidAssetPackUseMobileDataRequestResult> callback)
			{
			}

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x2DE3D7C", Offset = "0x2DDFD7C", VA = "0x2DE3D7C")]
			[Preserve]
			private void onMobileDataConfirmationResult(bool allowed)
			{
			}
		}

		[Token(Token = "0x2000019")]
		private class AssetPackManagerStatusQueryCallback : AndroidJavaProxy
		{
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Action<ulong, AndroidAssetPackState[]> m_Callback;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<string> m_AssetPackNames;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<AndroidAssetPackState> m_States;

			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private long m_Size;

			[Token(Token = "0x6000200")]
			[Address(RVA = "0x2DE3E00", Offset = "0x2DDFE00", VA = "0x2DE3E00")]
			public AssetPackManagerStatusQueryCallback(Action<ulong, AndroidAssetPackState[]> callback, string[] assetPacks)
			{
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0x2DE3EF4", Offset = "0x2DDFEF4", VA = "0x2DE3EF4")]
			[Preserve]
			private void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes)
			{
			}
		}

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AndroidJavaObject s_JavaPlayAssetDeliveryWrapper;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool s_ApiMissing;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2DE3800", Offset = "0x2DDF800", VA = "0x2DE3800")]
		private static AndroidJavaObject GetAssetPackManager()
		{
			return null;
		}
	}
	[Token(Token = "0x200001A")]
	public class PermissionCallbacks : AndroidJavaProxy
	{
		[Token(Token = "0x14000001")]
		public event Action<string> PermissionGranted
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x2DE4254", Offset = "0x2DE0254", VA = "0x2DE4254")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x2DE4304", Offset = "0x2DE0304", VA = "0x2DE4304")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<string> PermissionDenied
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x2DE43B4", Offset = "0x2DE03B4", VA = "0x2DE43B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x2DE4464", Offset = "0x2DE0464", VA = "0x2DE4464")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<string> PermissionDeniedAndDontAskAgain
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x2DE4514", Offset = "0x2DE0514", VA = "0x2DE4514")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x2DE45C4", Offset = "0x2DE05C4", VA = "0x2DE45C4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2DE4674", Offset = "0x2DE0674", VA = "0x2DE4674")]
		public PermissionCallbacks()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2DE46E0", Offset = "0x2DE06E0", VA = "0x2DE46E0")]
		[Preserve]
		private void onPermissionGranted(string permissionName)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2DE46FC", Offset = "0x2DE06FC", VA = "0x2DE46FC")]
		[Preserve]
		private void onPermissionDenied(string permissionName)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2DE4718", Offset = "0x2DE0718", VA = "0x2DE4718")]
		[Preserve]
		private void onPermissionDeniedAndDontAskAgain(string permissionName)
		{
		}
	}
}
