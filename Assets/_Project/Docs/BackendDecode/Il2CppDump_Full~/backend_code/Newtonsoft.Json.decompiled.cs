using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

[assembly: AssemblyVersion("13.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x269BE40", Offset = "0x2697E40", VA = "0x269BE40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x269BE48", Offset = "0x2697E48", VA = "0x269BE48")]
		public IsReadOnlyAttribute()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte[] NullableFlags;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x269BE50", Offset = "0x2697E50", VA = "0x269BE50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x269BED0", Offset = "0x2697ED0", VA = "0x269BED0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte Flag;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x269BEF8", Offset = "0x2697EF8", VA = "0x269BEF8")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace System.Diagnostics.CodeAnalysis
{
	[Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	internal sealed class NotNullAttribute : Attribute
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x269BF20", Offset = "0x2697F20", VA = "0x269BF20")]
		public NotNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	internal sealed class NotNullWhenAttribute : Attribute
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x269BF28", Offset = "0x2697F28", VA = "0x269BF28")]
		public NotNullWhenAttribute(bool returnValue)
		{
		}
	}
}
namespace Newtonsoft.Json
{
	[Token(Token = "0x2000008")]
	public enum ConstructorHandling
	{
		[Token(Token = "0x4000005")]
		Default,
		[Token(Token = "0x4000006")]
		AllowNonPublicDefaultConstructor
	}
	[Token(Token = "0x2000009")]
	public enum DateFormatHandling
	{
		[Token(Token = "0x4000008")]
		IsoDateFormat,
		[Token(Token = "0x4000009")]
		MicrosoftDateFormat
	}
	[Token(Token = "0x200000A")]
	public enum DateParseHandling
	{
		[Token(Token = "0x400000B")]
		None,
		[Token(Token = "0x400000C")]
		DateTime,
		[Token(Token = "0x400000D")]
		DateTimeOffset
	}
	[Token(Token = "0x200000B")]
	public enum DateTimeZoneHandling
	{
		[Token(Token = "0x400000F")]
		Local,
		[Token(Token = "0x4000010")]
		Utc,
		[Token(Token = "0x4000011")]
		Unspecified,
		[Token(Token = "0x4000012")]
		RoundtripKind
	}
	[Token(Token = "0x200000C")]
	public class DefaultJsonNameTable : JsonNameTable
	{
		[Token(Token = "0x200000D")]
		private class Entry
		{
			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal readonly string Value;

			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal readonly int HashCode;

			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Entry Next;

			[Token(Token = "0x600000F")]
			[Address(RVA = "0x269C520", Offset = "0x2698520", VA = "0x269C520")]
			internal Entry(string value, int hashCode, Entry next)
			{
			}
		}

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int HashCodeRandomizer;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _count;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Entry[] _entries;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _mask;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x269BF50", Offset = "0x2697F50", VA = "0x269BF50")]
		static DefaultJsonNameTable()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x269BFA0", Offset = "0x2697FA0", VA = "0x269BFA0")]
		public DefaultJsonNameTable()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x269C010", Offset = "0x2698010", VA = "0x269C010", Slot = "4")]
		public override string Get(char[] key, int start, int length)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x269C264", Offset = "0x2698264", VA = "0x269C264")]
		public string Add(string key)
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x269C418", Offset = "0x2698418", VA = "0x269C418")]
		private string AddEntry(string str, int hashCode)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x269C560", Offset = "0x2698560", VA = "0x269C560")]
		private void Grow()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x269C1A4", Offset = "0x26981A4", VA = "0x269C1A4")]
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000E")]
	[Flags]
	public enum DefaultValueHandling
	{
		[Token(Token = "0x400001B")]
		Include = 0,
		[Token(Token = "0x400001C")]
		Ignore = 1,
		[Token(Token = "0x400001D")]
		Populate = 2,
		[Token(Token = "0x400001E")]
		IgnoreAndPopulate = 3
	}
	[Token(Token = "0x200000F")]
	public enum FloatFormatHandling
	{
		[Token(Token = "0x4000020")]
		String,
		[Token(Token = "0x4000021")]
		Symbol,
		[Token(Token = "0x4000022")]
		DefaultValue
	}
	[Token(Token = "0x2000010")]
	public enum FloatParseHandling
	{
		[Token(Token = "0x4000024")]
		Double,
		[Token(Token = "0x4000025")]
		Decimal
	}
	[Token(Token = "0x2000011")]
	public enum Formatting
	{
		[Token(Token = "0x4000027")]
		None,
		[Token(Token = "0x4000028")]
		Indented
	}
	[Token(Token = "0x2000012")]
	public interface IArrayPool<T> where T : notnull
	{
		[Token(Token = "0x6000010")]
		T[] Rent(int minimumLength);

		[Token(Token = "0x6000011")]
		void Return(T[]? array);
	}
	[Token(Token = "0x2000013")]
	public interface IJsonLineInfo
	{
		[Token(Token = "0x17000001")]
		int LineNumber
		{
			[Token(Token = "0x6000013")]
			get;
		}

		[Token(Token = "0x17000002")]
		int LinePosition
		{
			[Token(Token = "0x6000014")]
			get;
		}

		[Token(Token = "0x6000012")]
		bool HasLineInfo();
	}
	[Token(Token = "0x2000014")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonArrayAttribute : JsonContainerAttribute
	{
	}
	[Token(Token = "0x2000015")]
	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false)]
	public sealed class JsonConstructorAttribute : Attribute
	{
	}
	[Token(Token = "0x2000016")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public abstract class JsonContainerAttribute : Attribute
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal bool? _isReference;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		internal bool? _itemIsReference;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal TypeNameHandling? _itemTypeNameHandling;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Type? _namingStrategyType;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private object[]? _namingStrategyParameters;

		[Token(Token = "0x17000003")]
		public Type? ItemConverterType
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x269C694", Offset = "0x2698694", VA = "0x269C694")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public object[]? ItemConverterParameters
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x269C69C", Offset = "0x269869C", VA = "0x269C69C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public Type? NamingStrategyType
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x269C6A4", Offset = "0x26986A4", VA = "0x269C6A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public object[]? NamingStrategyParameters
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x269C6AC", Offset = "0x26986AC", VA = "0x269C6AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		internal NamingStrategy? NamingStrategyInstance
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x269C6B4", Offset = "0x26986B4", VA = "0x269C6B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x269C6BC", Offset = "0x26986BC", VA = "0x269C6BC")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Token(Token = "0x2000017")]
	public static class JsonConvert
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string True;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly string False;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly string Null;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly string Undefined;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly string PositiveInfinity;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly string NegativeInfinity;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly string NaN;

		[Token(Token = "0x17000008")]
		public static Func<JsonSerializerSettings>? DefaultSettings
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x269C6C4", Offset = "0x26986C4", VA = "0x269C6C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x269C71C", Offset = "0x269871C", VA = "0x269C71C")]
		public static string ToString(bool value)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x269C788", Offset = "0x2698788", VA = "0x269C788")]
		public static string ToString(char value)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x269C86C", Offset = "0x269886C", VA = "0x269C86C")]
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x269CA2C", Offset = "0x2698A2C", VA = "0x269CA2C")]
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x269CB68", Offset = "0x2698B68", VA = "0x269CB68")]
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x269C95C", Offset = "0x269895C", VA = "0x269C95C")]
		private static string EnsureDecimalPlace(double value, string text)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x269CC54", Offset = "0x2698C54", VA = "0x269CC54")]
		private static string EnsureDecimalPlace(string text)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x269CCC8", Offset = "0x2698CC8", VA = "0x269CCC8")]
		public static string ToString(decimal value)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x269C814", Offset = "0x2698814", VA = "0x269C814")]
		public static string ToString(string? value)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x269CDBC", Offset = "0x2698DBC", VA = "0x269CDBC")]
		public static string ToString(string? value, char delimiter)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x269CE24", Offset = "0x2698E24", VA = "0x269CE24")]
		public static string ToString(string? value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x269CF08", Offset = "0x2698F08", VA = "0x269CF08")]
		[DebuggerStepThrough]
		public static string SerializeObject(object? value)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x269CF64", Offset = "0x2698F64", VA = "0x269CF64")]
		[DebuggerStepThrough]
		public static string? SerializeObject(object? value, Type? type, JsonSerializerSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x269D014", Offset = "0x2699014", VA = "0x269D014")]
		private static string SerializeObjectInternal(object? value, Type? type, JsonSerializer jsonSerializer)
		{
			return null;
		}
	}
	[Token(Token = "0x2000018")]
	public abstract class JsonConverter
	{
		[Token(Token = "0x17000009")]
		public virtual bool CanRead
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x269D544", Offset = "0x2699544", VA = "0x269D544", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public virtual bool CanWrite
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x269D54C", Offset = "0x269954C", VA = "0x269D54C", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600002B")]
		public abstract void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer);

		[Token(Token = "0x600002C")]
		public abstract object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer);

		[Token(Token = "0x600002D")]
		public abstract bool CanConvert(Type objectType);

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x269D554", Offset = "0x2699554", VA = "0x269D554")]
		protected JsonConverter()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class JsonConverterAttribute : Attribute
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Type _converterType;

		[Token(Token = "0x1700000B")]
		public Type ConverterType
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x269D55C", Offset = "0x269955C", VA = "0x269D55C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public object[]? ConverterParameters
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x269D564", Offset = "0x2699564", VA = "0x269D564")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200001A")]
	public class JsonConverterCollection : Collection<JsonConverter>
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x269D56C", Offset = "0x269956C", VA = "0x269D56C")]
		public JsonConverterCollection()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonDictionaryAttribute : JsonContainerAttribute
	{
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class JsonException : Exception
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x269D5B4", Offset = "0x26995B4", VA = "0x269D5B4")]
		public JsonException()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x269D60C", Offset = "0x269960C", VA = "0x269D60C")]
		public JsonException(string message)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x269D674", Offset = "0x2699674", VA = "0x269D674")]
		public JsonException(string message, Exception? innerException)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x269D6E4", Offset = "0x26996E4", VA = "0x269D6E4")]
		public JsonException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Token(Token = "0x200001D")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public class JsonExtensionDataAttribute : Attribute
	{
		[Token(Token = "0x1700000D")]
		public bool WriteData
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x269D764", Offset = "0x2699764", VA = "0x269D764")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public bool ReadData
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x269D76C", Offset = "0x269976C", VA = "0x269D76C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}
	}
	[Token(Token = "0x200001E")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonIgnoreAttribute : Attribute
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x269D774", Offset = "0x2699774", VA = "0x269D774")]
		public JsonIgnoreAttribute()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public abstract class JsonNameTable
	{
		[Token(Token = "0x600003B")]
		public abstract string Get(char[] key, int start, int length);

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x269C008", Offset = "0x2698008", VA = "0x269C008")]
		protected JsonNameTable()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MemberSerialization _memberSerialization;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal MissingMemberHandling? _missingMemberHandling;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal Required? _itemRequired;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		internal NullValueHandling? _itemNullValueHandling;

		[Token(Token = "0x1700000F")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x269D77C", Offset = "0x269977C", VA = "0x269D77C")]
			get
			{
				return default(MemberSerialization);
			}
		}
	}
	[Token(Token = "0x2000021")]
	internal enum JsonContainerType
	{
		[Token(Token = "0x4000043")]
		None,
		[Token(Token = "0x4000044")]
		Object,
		[Token(Token = "0x4000045")]
		Array,
		[Token(Token = "0x4000046")]
		Constructor
	}
	[Token(Token = "0x2000022")]
	internal struct JsonPosition
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] SpecialCharacters;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal JsonContainerType Type;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal int Position;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string? PropertyName;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool HasIndex;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x269D784", Offset = "0x2699784", VA = "0x269D784")]
		public JsonPosition(JsonContainerType type)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x269D810", Offset = "0x2699810", VA = "0x269D810")]
		internal int CalculateLength()
		{
			return default(int);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x269D8A4", Offset = "0x26998A4", VA = "0x269D8A4")]
		internal void WriteTo(StringBuilder sb, ref StringWriter? writer, ref char[]? buffer)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x269D800", Offset = "0x2699800", VA = "0x269D800")]
		internal static bool TypeHasIndex(JsonContainerType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x269DAB4", Offset = "0x2699AB4", VA = "0x269DAB4")]
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x269DDA0", Offset = "0x2699DA0", VA = "0x269DDA0")]
		internal static string FormatMessage(IJsonLineInfo? lineInfo, string path, string message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class JsonPropertyAttribute : Attribute
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal NullValueHandling? _nullValueHandling;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal DefaultValueHandling? _defaultValueHandling;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal ObjectCreationHandling? _objectCreationHandling;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal TypeNameHandling? _typeNameHandling;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal bool? _isReference;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal int? _order;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal Required? _required;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal bool? _itemIsReference;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal TypeNameHandling? _itemTypeNameHandling;

		[Token(Token = "0x17000010")]
		public Type? ItemConverterType
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x269E160", Offset = "0x269A160", VA = "0x269E160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public object[]? ItemConverterParameters
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x269E168", Offset = "0x269A168", VA = "0x269E168")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public Type? NamingStrategyType
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x269E170", Offset = "0x269A170", VA = "0x269E170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public object[]? NamingStrategyParameters
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x269E178", Offset = "0x269A178", VA = "0x269E178")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public string? PropertyName
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x269E180", Offset = "0x269A180", VA = "0x269E180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000024")]
	public abstract class JsonReader : IDisposable
	{
		[Token(Token = "0x2000025")]
		protected internal enum State
		{
			[Token(Token = "0x400006C")]
			Start,
			[Token(Token = "0x400006D")]
			Complete,
			[Token(Token = "0x400006E")]
			Property,
			[Token(Token = "0x400006F")]
			ObjectStart,
			[Token(Token = "0x4000070")]
			Object,
			[Token(Token = "0x4000071")]
			ArrayStart,
			[Token(Token = "0x4000072")]
			Array,
			[Token(Token = "0x4000073")]
			Closed,
			[Token(Token = "0x4000074")]
			PostValue,
			[Token(Token = "0x4000075")]
			ConstructorStart,
			[Token(Token = "0x4000076")]
			Constructor,
			[Token(Token = "0x4000077")]
			Error,
			[Token(Token = "0x4000078")]
			Finished
		}

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JsonToken _tokenType;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object? _value;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal char _quoteChar;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal State _currentState;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private JsonPosition _currentPosition;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CultureInfo? _culture;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int? _maxDepth;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool _hasExceededMaxDepth;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal DateParseHandling _dateParseHandling;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal FloatParseHandling _floatParseHandling;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string? _dateFormatString;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<JsonPosition>? _stack;

		[Token(Token = "0x17000015")]
		protected State CurrentState
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x269E188", Offset = "0x269A188", VA = "0x269E188")]
			get
			{
				return default(State);
			}
		}

		[Token(Token = "0x17000016")]
		public bool CloseInput
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x269E190", Offset = "0x269A190", VA = "0x269E190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x269E198", Offset = "0x269A198", VA = "0x269E198")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool SupportMultipleContent
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x269E1A0", Offset = "0x269A1A0", VA = "0x269E1A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x269E1A8", Offset = "0x269A1A8", VA = "0x269E1A8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x269E1B0", Offset = "0x269A1B0", VA = "0x269E1B0")]
			get
			{
				return default(DateTimeZoneHandling);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x269E1B8", Offset = "0x269A1B8", VA = "0x269E1B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public DateParseHandling DateParseHandling
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x269E214", Offset = "0x269A214", VA = "0x269E214")]
			get
			{
				return default(DateParseHandling);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x269E21C", Offset = "0x269A21C", VA = "0x269E21C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x269E278", Offset = "0x269A278", VA = "0x269E278")]
			get
			{
				return default(FloatParseHandling);
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x269E280", Offset = "0x269A280", VA = "0x269E280")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public string? DateFormatString
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x269E2DC", Offset = "0x269A2DC", VA = "0x269E2DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x269E2E4", Offset = "0x269A2E4", VA = "0x269E2E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int? MaxDepth
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x269E2EC", Offset = "0x269A2EC", VA = "0x269E2EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x269E2F4", Offset = "0x269A2F4", VA = "0x269E2F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public virtual JsonToken TokenType
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x269E3B0", Offset = "0x269A3B0", VA = "0x269E3B0", Slot = "5")]
			get
			{
				return default(JsonToken);
			}
		}

		[Token(Token = "0x1700001E")]
		public virtual object? Value
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x269E3B8", Offset = "0x269A3B8", VA = "0x269E3B8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public virtual Type? ValueType
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x269E3C0", Offset = "0x269A3C0", VA = "0x269E3C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public virtual int Depth
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x269E3D4", Offset = "0x269A3D4", VA = "0x269E3D4", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000021")]
		public virtual string Path
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x269E44C", Offset = "0x269A44C", VA = "0x269E44C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public CultureInfo Culture
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x269E55C", Offset = "0x269A55C", VA = "0x269E55C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x269E5C4", Offset = "0x269A5C4", VA = "0x269E5C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x269E5CC", Offset = "0x269A5CC", VA = "0x269E5CC")]
		internal JsonPosition GetPosition(int depth)
		{
			return default(JsonPosition);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x269E668", Offset = "0x269A668", VA = "0x269E668")]
		protected JsonReader()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x269E6F8", Offset = "0x269A6F8", VA = "0x269E6F8")]
		private void Push(JsonContainerType value)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x269E9A0", Offset = "0x269A9A0", VA = "0x269E9A0")]
		private JsonContainerType Pop()
		{
			return default(JsonContainerType);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x269EAB8", Offset = "0x269AAB8", VA = "0x269EAB8")]
		private JsonContainerType Peek()
		{
			return default(JsonContainerType);
		}

		[Token(Token = "0x6000065")]
		public abstract bool Read();

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x269EAC0", Offset = "0x269AAC0", VA = "0x269EAC0", Slot = "11")]
		public virtual int? ReadAsInt32()
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x269F120", Offset = "0x269B120", VA = "0x269F120")]
		internal int? ReadInt32String(string? s)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x269F2FC", Offset = "0x269B2FC", VA = "0x269F2FC", Slot = "12")]
		public virtual string? ReadAsString()
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x269F59C", Offset = "0x269B59C", VA = "0x269F59C", Slot = "13")]
		public virtual byte[]? ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x269FB7C", Offset = "0x269BB7C", VA = "0x269FB7C")]
		internal byte[] ReadArrayIntoByteArray()
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x269FCC8", Offset = "0x269BCC8", VA = "0x269FCC8")]
		private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x269FED0", Offset = "0x269BED0", VA = "0x269FED0", Slot = "14")]
		public virtual double? ReadAsDouble()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x26A01D0", Offset = "0x269C1D0", VA = "0x26A01D0")]
		internal double? ReadDoubleString(string? s)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x26A03A8", Offset = "0x269C3A8", VA = "0x26A03A8", Slot = "15")]
		public virtual bool? ReadAsBoolean()
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x26A06F4", Offset = "0x269C6F4", VA = "0x26A06F4")]
		internal bool? ReadBooleanString(string? s)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x26A08D0", Offset = "0x269C8D0", VA = "0x26A08D0", Slot = "16")]
		public virtual decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x26A0D80", Offset = "0x269CD80", VA = "0x26A0D80")]
		internal decimal? ReadDecimalString(string? s)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x26A103C", Offset = "0x269D03C", VA = "0x26A103C", Slot = "17")]
		public virtual DateTime? ReadAsDateTime()
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x26A12E0", Offset = "0x269D2E0", VA = "0x26A12E0")]
		internal DateTime? ReadDateTimeString(string? s)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x26A1594", Offset = "0x269D594", VA = "0x26A1594", Slot = "18")]
		public virtual DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x26A1834", Offset = "0x269D834", VA = "0x26A1834")]
		internal DateTimeOffset? ReadDateTimeOffsetString(string? s)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x269FB38", Offset = "0x269BB38", VA = "0x269FB38")]
		internal void ReaderReadAndAssert()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x26A1AA0", Offset = "0x269DAA0", VA = "0x26A1AA0")]
		internal JsonReaderException CreateUnexpectedEndException()
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x269F96C", Offset = "0x269B96C", VA = "0x269F96C")]
		internal void ReadIntoWrappedTypeObject()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x26A1AEC", Offset = "0x269DAEC", VA = "0x26A1AEC")]
		public void Skip()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x269FCBC", Offset = "0x269BCBC", VA = "0x269FCBC")]
		protected void SetToken(JsonToken newToken)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x26A1B84", Offset = "0x269DB84", VA = "0x26A1B84")]
		protected void SetToken(JsonToken newToken, object? value)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x269EF78", Offset = "0x269AF78", VA = "0x269EF78")]
		protected void SetToken(JsonToken newToken, object? value, bool updateIndex)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x26A1C88", Offset = "0x269DC88", VA = "0x26A1C88")]
		internal void SetPostValueState(bool updateIndex)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x269E980", Offset = "0x269A980", VA = "0x269E980")]
		private void UpdateScopeWithFinishedValue()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x26A1B8C", Offset = "0x269DB8C", VA = "0x26A1B8C")]
		private void ValidateEnd(JsonToken endToken)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x26A1D90", Offset = "0x269DD90", VA = "0x26A1D90")]
		protected void SetStateBasedOnCurrent()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x26A1CC4", Offset = "0x269DCC4", VA = "0x26A1CC4")]
		private void SetFinished()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x26A1CE8", Offset = "0x269DCE8", VA = "0x26A1CE8")]
		private JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			return default(JsonContainerType);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x26A1E84", Offset = "0x269DE84", VA = "0x26A1E84", Slot = "4")]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x26A1EF4", Offset = "0x269DEF4", VA = "0x26A1EF4", Slot = "19")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x26A1F18", Offset = "0x269DF18", VA = "0x26A1F18", Slot = "20")]
		public virtual void Close()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x26A1F2C", Offset = "0x269DF2C", VA = "0x26A1F2C")]
		internal void ReadAndAssert()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x26A1F88", Offset = "0x269DF88", VA = "0x26A1F88")]
		internal void ReadForTypeAndAssert(JsonContract? contract, bool hasConverter)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x26A1FD4", Offset = "0x269DFD4", VA = "0x26A1FD4")]
		internal bool ReadForType(JsonContract? contract, bool hasConverter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x26A22EC", Offset = "0x269E2EC", VA = "0x26A22EC")]
		internal bool ReadAndMoveToContent()
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x26A231C", Offset = "0x269E31C", VA = "0x26A231C")]
		internal bool MoveToContent()
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x269EE80", Offset = "0x269AE80", VA = "0x269EE80")]
		private JsonToken GetContentToken()
		{
			return default(JsonToken);
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class JsonReaderException : JsonException
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x26A2368", Offset = "0x269E368", VA = "0x26A2368")]
		public JsonReaderException()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x26A236C", Offset = "0x269E36C", VA = "0x26A236C")]
		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x26A2370", Offset = "0x269E370", VA = "0x26A2370")]
		public JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception? innerException)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x269E998", Offset = "0x269A998", VA = "0x269E998")]
		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x269EEF4", Offset = "0x269AEF4", VA = "0x269EEF4")]
		internal static JsonReaderException Create(JsonReader reader, string message, Exception? ex)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x26A23AC", Offset = "0x269E3AC", VA = "0x26A23AC")]
		internal static JsonReaderException Create(IJsonLineInfo? lineInfo, string path, string message, Exception? ex)
		{
			return null;
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonRequiredAttribute : Attribute
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x26A25A4", Offset = "0x269E5A4", VA = "0x26A25A4")]
		public JsonRequiredAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class JsonSerializationException : JsonException
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x26A25AC", Offset = "0x269E5AC", VA = "0x26A25AC")]
		public JsonSerializationException()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x26A25B0", Offset = "0x269E5B0", VA = "0x26A25B0")]
		public JsonSerializationException(string message)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x26A25B4", Offset = "0x269E5B4", VA = "0x26A25B4")]
		public JsonSerializationException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x26A25B8", Offset = "0x269E5B8", VA = "0x26A25B8")]
		public JsonSerializationException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x26A25BC", Offset = "0x269E5BC", VA = "0x26A25BC")]
		public JsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception? innerException)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x26A1F80", Offset = "0x269DF80", VA = "0x26A1F80")]
		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x26A25F8", Offset = "0x269E5F8", VA = "0x26A25F8")]
		internal static JsonSerializationException Create(JsonReader reader, string message, Exception? ex)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x26A267C", Offset = "0x269E67C", VA = "0x26A267C")]
		internal static JsonSerializationException Create(IJsonLineInfo? lineInfo, string path, string message, Exception? ex)
		{
			return null;
		}
	}
	[Token(Token = "0x2000029")]
	public class JsonSerializer
	{
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal TypeNameHandling _typeNameHandling;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal PreserveReferencesHandling _preserveReferencesHandling;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal ReferenceLoopHandling _referenceLoopHandling;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal MissingMemberHandling _missingMemberHandling;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal ObjectCreationHandling _objectCreationHandling;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal NullValueHandling _nullValueHandling;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal DefaultValueHandling _defaultValueHandling;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal ConstructorHandling _constructorHandling;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal MetadataPropertyHandling _metadataPropertyHandling;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal JsonConverterCollection? _converters;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal IContractResolver _contractResolver;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal ITraceWriter? _traceWriter;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal IEqualityComparer? _equalityComparer;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal ISerializationBinder _serializationBinder;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal StreamingContext _context;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IReferenceResolver? _referenceResolver;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Formatting? _formatting;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DateFormatHandling? _dateFormatHandling;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DateTimeZoneHandling? _dateTimeZoneHandling;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private DateParseHandling? _dateParseHandling;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FloatFormatHandling? _floatFormatHandling;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private FloatParseHandling? _floatParseHandling;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private StringEscapeHandling? _stringEscapeHandling;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CultureInfo _culture;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int? _maxDepth;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _maxDepthSet;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool? _checkAdditionalContent;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string? _dateFormatString;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool _dateFormatStringSet;

		[Token(Token = "0x17000023")]
		public virtual IReferenceResolver? ReferenceResolver
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x26A29D4", Offset = "0x269E9D4", VA = "0x26A29D4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public virtual ISerializationBinder SerializationBinder
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x26A2A44", Offset = "0x269EA44", VA = "0x26A2A44", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public virtual ITraceWriter? TraceWriter
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x26A2AB4", Offset = "0x269EAB4", VA = "0x26A2AB4", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x26A2ABC", Offset = "0x269EABC", VA = "0x26A2ABC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public virtual IEqualityComparer? EqualityComparer
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x26A2AC4", Offset = "0x269EAC4", VA = "0x26A2AC4", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public virtual TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x26A2ACC", Offset = "0x269EACC", VA = "0x26A2ACC", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x26A2B28", Offset = "0x269EB28", VA = "0x26A2B28", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x26A2B84", Offset = "0x269EB84", VA = "0x26A2B84", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x26A2BE0", Offset = "0x269EBE0", VA = "0x26A2BE0", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public virtual MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x26A2C3C", Offset = "0x269EC3C", VA = "0x26A2C3C", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public virtual NullValueHandling NullValueHandling
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x26A2C98", Offset = "0x269EC98", VA = "0x26A2C98", Slot = "16")]
			get
			{
				return default(NullValueHandling);
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x26A2CA0", Offset = "0x269ECA0", VA = "0x26A2CA0", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public virtual DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x26A2CFC", Offset = "0x269ECFC", VA = "0x26A2CFC", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x26A2D58", Offset = "0x269ED58", VA = "0x26A2D58", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public virtual ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x26A2DB4", Offset = "0x269EDB4", VA = "0x26A2DB4", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x26A2E10", Offset = "0x269EE10", VA = "0x26A2E10", Slot = "21")]
			get
			{
				return default(MetadataPropertyHandling);
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x26A2E18", Offset = "0x269EE18", VA = "0x26A2E18", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public virtual JsonConverterCollection Converters
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x26A2E74", Offset = "0x269EE74", VA = "0x26A2E74", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public virtual IContractResolver ContractResolver
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x26A2ED4", Offset = "0x269EED4", VA = "0x26A2ED4", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x26A2EDC", Offset = "0x269EEDC", VA = "0x26A2EDC", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public virtual StreamingContext Context
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x26A2F84", Offset = "0x269EF84", VA = "0x26A2F84", Slot = "26")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x26A2F90", Offset = "0x269EF90", VA = "0x26A2F90", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public virtual Formatting Formatting
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x26A2F98", Offset = "0x269EF98", VA = "0x26A2F98", Slot = "28")]
			get
			{
				return default(Formatting);
			}
		}

		[Token(Token = "0x17000035")]
		public virtual int? MaxDepth
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x26A2FD4", Offset = "0x269EFD4", VA = "0x26A2FD4", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public virtual bool CheckAdditionalContent
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x26A2FDC", Offset = "0x269EFDC", VA = "0x26A2FDC", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public virtual event EventHandler<ErrorEventArgs>? Error
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x26A2874", Offset = "0x269E874", VA = "0x26A2874", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x26A2924", Offset = "0x269E924", VA = "0x26A2924", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x26A3018", Offset = "0x269F018", VA = "0x26A3018")]
		public JsonSerializer()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x26A3148", Offset = "0x269F148", VA = "0x26A3148")]
		public static JsonSerializer Create()
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x26A3198", Offset = "0x269F198", VA = "0x26A3198")]
		public static JsonSerializer Create(JsonSerializerSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x26A38EC", Offset = "0x269F8EC", VA = "0x26A38EC")]
		public static JsonSerializer CreateDefault()
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x269CFE0", Offset = "0x2698FE0", VA = "0x269CFE0")]
		public static JsonSerializer CreateDefault(JsonSerializerSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x26A31CC", Offset = "0x269F1CC", VA = "0x26A31CC")]
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x26A3C78", Offset = "0x269FC78", VA = "0x26A3C78")]
		[DebuggerStepThrough]
		public void Populate(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x26A3C88", Offset = "0x269FC88", VA = "0x26A3C88", Slot = "31")]
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x60000BE")]
		[DebuggerStepThrough]
		public T? Deserialize<T>(JsonReader reader)
		{
			return (T?)null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x26A44E8", Offset = "0x26A04E8", VA = "0x26A44E8")]
		[DebuggerStepThrough]
		public object? Deserialize(JsonReader reader, Type? objectType)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x26A44F8", Offset = "0x26A04F8", VA = "0x26A44F8", Slot = "32")]
		internal virtual object? DeserializeInternal(JsonReader reader, Type? objectType)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x26A3F00", Offset = "0x269FF00", VA = "0x26A3F00")]
		internal void SetupReader(JsonReader reader, out CultureInfo? previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string? previousDateFormatString)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x26A430C", Offset = "0x26A030C", VA = "0x26A430C")]
		private void ResetReader(JsonReader reader, CultureInfo? previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string? previousDateFormatString)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x269D420", Offset = "0x2699420", VA = "0x269D420")]
		public void Serialize(JsonWriter jsonWriter, object? value, Type? objectType)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x26A4778", Offset = "0x26A0778", VA = "0x26A4778")]
		public void Serialize(JsonWriter jsonWriter, object? value)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x26A4284", Offset = "0x26A0284", VA = "0x26A4284")]
		private TraceJsonReader CreateTraceJsonReader(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x26A478C", Offset = "0x26A078C", VA = "0x26A478C", Slot = "33")]
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object? value, Type? objectType)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x26A4EF0", Offset = "0x26A0EF0", VA = "0x26A4EF0")]
		internal IReferenceResolver GetReferenceResolver()
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x26A4F54", Offset = "0x26A0F54", VA = "0x26A4F54")]
		internal JsonConverter GetMatchingConverter(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x26A4F5C", Offset = "0x26A0F5C", VA = "0x26A4F5C")]
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter>? converters, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x26A50B8", Offset = "0x26A10B8", VA = "0x26A50B8")]
		internal void OnError(ErrorEventArgs e)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class JsonSerializerSettings
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly StreamingContext DefaultContext;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly CultureInfo DefaultCulture;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Formatting? _formatting;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal DateFormatHandling? _dateFormatHandling;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal DateParseHandling? _dateParseHandling;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal FloatFormatHandling? _floatFormatHandling;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal FloatParseHandling? _floatParseHandling;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal StringEscapeHandling? _stringEscapeHandling;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal CultureInfo? _culture;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal bool? _checkAdditionalContent;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal int? _maxDepth;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal bool _maxDepthSet;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal string? _dateFormatString;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal bool _dateFormatStringSet;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		internal DefaultValueHandling? _defaultValueHandling;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		internal PreserveReferencesHandling? _preserveReferencesHandling;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		internal NullValueHandling? _nullValueHandling;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		internal ObjectCreationHandling? _objectCreationHandling;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		internal MissingMemberHandling? _missingMemberHandling;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal StreamingContext? _context;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal ConstructorHandling? _constructorHandling;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal TypeNameHandling? _typeNameHandling;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal MetadataPropertyHandling? _metadataPropertyHandling;

		[Token(Token = "0x17000037")]
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x26A3A80", Offset = "0x269FA80", VA = "0x26A3A80")]
			get
			{
				return default(ReferenceLoopHandling);
			}
		}

		[Token(Token = "0x17000038")]
		public MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x26A3ABC", Offset = "0x269FABC", VA = "0x26A3ABC")]
			get
			{
				return default(MissingMemberHandling);
			}
		}

		[Token(Token = "0x17000039")]
		public ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x26A3AF8", Offset = "0x269FAF8", VA = "0x26A3AF8")]
			get
			{
				return default(ObjectCreationHandling);
			}
		}

		[Token(Token = "0x1700003A")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x26A3B34", Offset = "0x269FB34", VA = "0x26A3B34")]
			get
			{
				return default(NullValueHandling);
			}
		}

		[Token(Token = "0x1700003B")]
		public DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x26A3B70", Offset = "0x269FB70", VA = "0x26A3B70")]
			get
			{
				return default(DefaultValueHandling);
			}
		}

		[Token(Token = "0x1700003C")]
		public IList<JsonConverter> Converters
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x26A50E0", Offset = "0x26A10E0", VA = "0x26A50E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x26A3A44", Offset = "0x269FA44", VA = "0x26A3A44")]
			get
			{
				return default(PreserveReferencesHandling);
			}
		}

		[Token(Token = "0x1700003E")]
		public TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x26A3990", Offset = "0x269F990", VA = "0x26A3990")]
			get
			{
				return default(TypeNameHandling);
			}
		}

		[Token(Token = "0x1700003F")]
		public MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x26A39CC", Offset = "0x269F9CC", VA = "0x26A39CC")]
			get
			{
				return default(MetadataPropertyHandling);
			}
		}

		[Token(Token = "0x17000040")]
		public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x26A3A08", Offset = "0x269FA08", VA = "0x26A3A08")]
			get
			{
				return default(TypeNameAssemblyFormatHandling);
			}
		}

		[Token(Token = "0x17000041")]
		public ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x26A3BAC", Offset = "0x269FBAC", VA = "0x26A3BAC")]
			get
			{
				return default(ConstructorHandling);
			}
		}

		[Token(Token = "0x17000042")]
		public IContractResolver? ContractResolver
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x26A50E8", Offset = "0x26A10E8", VA = "0x26A50E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IEqualityComparer? EqualityComparer
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x26A50F0", Offset = "0x26A10F0", VA = "0x26A50F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public Func<IReferenceResolver?>? ReferenceResolverProvider
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x26A50F8", Offset = "0x26A10F8", VA = "0x26A50F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public ITraceWriter? TraceWriter
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x26A5100", Offset = "0x26A1100", VA = "0x26A5100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public ISerializationBinder? SerializationBinder
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x26A5108", Offset = "0x26A1108", VA = "0x26A5108")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public EventHandler<ErrorEventArgs>? Error
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x26A5110", Offset = "0x26A1110", VA = "0x26A5110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public StreamingContext Context
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x26A3BE8", Offset = "0x269FBE8", VA = "0x26A3BE8")]
			get
			{
				return default(StreamingContext);
			}
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x26A5118", Offset = "0x26A1118", VA = "0x26A5118")]
		static JsonSerializerSettings()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		private readonly bool _safeAsync;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly TextReader _reader;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private char[]? _chars;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _charsUsed;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _charPos;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _lineStartPos;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _lineNumber;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _isEndOfFile;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private StringBuffer _stringBuffer;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private StringReference _stringReference;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private IArrayPool<char>? _arrayPool;

		[Token(Token = "0x17000049")]
		public JsonNameTable? PropertyNameTable
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x26A52A4", Offset = "0x26A12A4", VA = "0x26A52A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x26A52AC", Offset = "0x26A12AC", VA = "0x26A52AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public int LineNumber
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x26AB81C", Offset = "0x26A781C", VA = "0x26AB81C", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004B")]
		public int LinePosition
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x26AB864", Offset = "0x26A7864", VA = "0x26AB864", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x26A5198", Offset = "0x26A1198", VA = "0x26A5198")]
		public JsonTextReader(TextReader reader)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x26A52B4", Offset = "0x26A12B4", VA = "0x26A52B4")]
		private void EnsureBufferNotEmpty()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x26A52FC", Offset = "0x26A12FC", VA = "0x26A52FC")]
		private void SetNewLine(bool hasNextChar)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x26A535C", Offset = "0x26A135C", VA = "0x26A535C")]
		private void OnNewLine(int pos)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x26A536C", Offset = "0x26A136C", VA = "0x26A536C")]
		private void ParseString(char quote, ReadType readType)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x26A58D8", Offset = "0x26A18D8", VA = "0x26A58D8")]
		private void ParseReadString(char quote, ReadType readType)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x26A5CB8", Offset = "0x26A1CB8", VA = "0x26A5CB8")]
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x26A53B4", Offset = "0x26A13B4", VA = "0x26A53B4")]
		private void ShiftBufferIfNeeded()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x26A5CCC", Offset = "0x26A1CCC", VA = "0x26A5CCC")]
		private int ReadData(bool append)
		{
			return default(int);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x26A5D64", Offset = "0x26A1D64", VA = "0x26A5D64")]
		private void PrepareBufferForReadData(bool append, int charsRequired)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x26A5CD4", Offset = "0x26A1CD4", VA = "0x26A5CD4")]
		private int ReadData(bool append, int charsRequired)
		{
			return default(int);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x26A5EFC", Offset = "0x26A1EFC", VA = "0x26A5EFC")]
		private bool EnsureChars(int relativePosition, bool append)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x26A5F1C", Offset = "0x26A1F1C", VA = "0x26A5F1C")]
		private bool ReadChars(int relativePosition, bool append)
		{
			return default(bool);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x26A5F8C", Offset = "0x26A1F8C", VA = "0x26A5F8C", Slot = "10")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x26A6E10", Offset = "0x26A2E10", VA = "0x26A6E10", Slot = "11")]
		public override int? ReadAsInt32()
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x26A72F0", Offset = "0x26A32F0", VA = "0x26A72F0", Slot = "17")]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x26A789C", Offset = "0x26A389C", VA = "0x26A789C", Slot = "12")]
		public override string? ReadAsString()
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x26A7900", Offset = "0x26A3900", VA = "0x26A7900", Slot = "13")]
		public override byte[]? ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x26A73B4", Offset = "0x26A33B4", VA = "0x26A73B4")]
		private object? ReadStringValue(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x26A819C", Offset = "0x26A419C", VA = "0x26A819C")]
		private object? FinishReadQuotedStringValue(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x26A7F1C", Offset = "0x26A3F1C", VA = "0x26A7F1C")]
		private JsonReaderException CreateUnexpectedCharacterException(char c)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x26A8674", Offset = "0x26A4674", VA = "0x26A8674", Slot = "15")]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x26A7EB8", Offset = "0x26A3EB8", VA = "0x26A7EB8")]
		private void ProcessValueComma()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x26A6ED4", Offset = "0x26A2ED4", VA = "0x26A6ED4")]
		private object? ReadNumberValue(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x26A8C54", Offset = "0x26A4C54", VA = "0x26A8C54")]
		private object? FinishReadQuotedNumber(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x26A8DE4", Offset = "0x26A4DE4", VA = "0x26A8DE4", Slot = "18")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x26A8EC0", Offset = "0x26A4EC0", VA = "0x26A8EC0", Slot = "16")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x26A8F9C", Offset = "0x26A4F9C", VA = "0x26A8F9C", Slot = "14")]
		public override double? ReadAsDouble()
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x26A7DE8", Offset = "0x26A3DE8", VA = "0x26A7DE8")]
		private void HandleNull()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x26A8050", Offset = "0x26A4050", VA = "0x26A8050")]
		private void ReadFinished()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x26A7D98", Offset = "0x26A3D98", VA = "0x26A7D98")]
		private bool ReadNullChar()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x26A61B8", Offset = "0x26A21B8", VA = "0x26A61B8")]
		private void EnsureBuffer()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x26A5474", Offset = "0x26A1474", VA = "0x26A5474")]
		private void ReadStringIntoBuffer(char quote)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x26A919C", Offset = "0x26A519C", VA = "0x26A919C")]
		private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x26A914C", Offset = "0x26A514C", VA = "0x26A914C")]
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x26A9234", Offset = "0x26A5234", VA = "0x26A9234")]
		private char ConvertUnicode(bool enoughChars)
		{
			return default(char);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x26A910C", Offset = "0x26A510C", VA = "0x26A910C")]
		private char ParseUnicode()
		{
			return default(char);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x26A9388", Offset = "0x26A5388", VA = "0x26A9388")]
		private void ReadNumberIntoBuffer()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x26A940C", Offset = "0x26A540C", VA = "0x26A940C")]
		private bool ReadNumberCharIntoBuffer(char currentChar, int charPos)
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x26A9588", Offset = "0x26A5588", VA = "0x26A9588")]
		private void ClearRecentString()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x26A67C8", Offset = "0x26A27C8", VA = "0x26A67C8")]
		private bool ParsePostValue(bool ignoreComments)
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x26A6638", Offset = "0x26A2638", VA = "0x26A6638")]
		private bool ParseObject()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x26A9594", Offset = "0x26A5594", VA = "0x26A9594")]
		private bool ParseProperty()
		{
			return default(bool);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x26A97B4", Offset = "0x26A57B4", VA = "0x26A97B4")]
		private bool ValidIdentifierChar(char value)
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x26A9830", Offset = "0x26A5830", VA = "0x26A9830")]
		private void ParseUnquotedProperty()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x26A9914", Offset = "0x26A5914", VA = "0x26A9914")]
		private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x26A61FC", Offset = "0x26A21FC", VA = "0x26A61FC")]
		private bool ParseValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x26A8034", Offset = "0x26A4034", VA = "0x26A8034")]
		private void ProcessLineFeed()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x26A7FEC", Offset = "0x26A3FEC", VA = "0x26A7FEC")]
		private void ProcessCarriageReturn(bool append)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x26A6A6C", Offset = "0x26A2A6C", VA = "0x26A6A6C")]
		private void EatWhitespace()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x26A9C14", Offset = "0x26A5C14", VA = "0x26A9C14")]
		private void ParseConstructor()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x26A8468", Offset = "0x26A4468", VA = "0x26A8468")]
		private void ParseNumber(ReadType readType)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x26A9FD0", Offset = "0x26A5FD0", VA = "0x26A9FD0")]
		private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x26AAFCC", Offset = "0x26A6FCC", VA = "0x26AAFCC")]
		private JsonReaderException ThrowReaderError(string message, [Optional] Exception? ex)
		{
			return null;
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x26AB048", Offset = "0x26A7048", VA = "0x26AB048")]
		private static object BigIntegerParse(string number, CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x26A6B80", Offset = "0x26A2B80", VA = "0x26A6B80")]
		private void ParseComment(bool setToken)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x26AB0D0", Offset = "0x26A70D0", VA = "0x26AB0D0")]
		private void EndComment(bool setToken, int initialPosition, int endPosition)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x26AB130", Offset = "0x26A7130", VA = "0x26AB130")]
		private bool MatchValue(string value)
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x26AB18C", Offset = "0x26A718C", VA = "0x26AB18C")]
		private bool MatchValue(bool enoughChars, string value)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x26A84D0", Offset = "0x26A44D0", VA = "0x26A84D0")]
		private bool MatchValueWithTrailingSeparator(string value)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x26AB264", Offset = "0x26A7264", VA = "0x26AB264")]
		private bool IsSeparator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x26A9A64", Offset = "0x26A5A64", VA = "0x26A9A64")]
		private void ParseTrue()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x26A9060", Offset = "0x26A5060", VA = "0x26A9060")]
		private void ParseNull()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x26A9F24", Offset = "0x26A5F24", VA = "0x26A9F24")]
		private void ParseUndefined()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x26A9B3C", Offset = "0x26A5B3C", VA = "0x26A9B3C")]
		private void ParseFalse()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x26A83E8", Offset = "0x26A43E8", VA = "0x26A83E8")]
		private object ParseNumberNegativeInfinity(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x26AB3B8", Offset = "0x26A73B8", VA = "0x26AB3B8")]
		private object ParseNumberNegativeInfinity(ReadType readType, bool matched)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x26A8574", Offset = "0x26A4574", VA = "0x26A8574")]
		private object ParseNumberPositiveInfinity(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x26AB50C", Offset = "0x26A750C", VA = "0x26AB50C")]
		private object ParseNumberPositiveInfinity(ReadType readType, bool matched)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x26A85F4", Offset = "0x26A45F4", VA = "0x26A85F4")]
		private object ParseNumberNaN(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x26AB660", Offset = "0x26A7660", VA = "0x26AB660")]
		private object ParseNumberNaN(ReadType readType, bool matched)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x26AB7B4", Offset = "0x26A77B4", VA = "0x26AB7B4", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x26AB814", Offset = "0x26A7814", VA = "0x26AB814", Slot = "21")]
		public bool HasLineInfo()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002C")]
	internal enum ReadType
	{
		[Token(Token = "0x40000CC")]
		Read,
		[Token(Token = "0x40000CD")]
		ReadAsInt32,
		[Token(Token = "0x40000CE")]
		ReadAsInt64,
		[Token(Token = "0x40000CF")]
		ReadAsBytes,
		[Token(Token = "0x40000D0")]
		ReadAsString,
		[Token(Token = "0x40000D1")]
		ReadAsDecimal,
		[Token(Token = "0x40000D2")]
		ReadAsDateTime,
		[Token(Token = "0x40000D3")]
		ReadAsDateTimeOffset,
		[Token(Token = "0x40000D4")]
		ReadAsDouble,
		[Token(Token = "0x40000D5")]
		ReadAsBoolean
	}
	[Token(Token = "0x200002D")]
	public class JsonTextWriter : JsonWriter
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly bool _safeAsync;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly TextWriter _writer;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Base64Encoder? _base64Encoder;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private char _indentChar;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _indentation;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private char _quoteChar;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		private bool _quoteName;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool[]? _charEscapeFlags;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private char[]? _writeBuffer;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private IArrayPool<char>? _arrayPool;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private char[]? _indentChars;

		[Token(Token = "0x1700004C")]
		private Base64Encoder Base64Encoder
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x26AB870", Offset = "0x26A7870", VA = "0x26AB870")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public char QuoteChar
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x26AB8DC", Offset = "0x26A78DC", VA = "0x26AB8DC")]
			get
			{
				return default(char);
			}
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x269D25C", Offset = "0x269925C", VA = "0x269D25C")]
		public JsonTextWriter(TextWriter textWriter)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x26AB97C", Offset = "0x26A797C", VA = "0x26AB97C", Slot = "6")]
		public override void Close()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x26AB9B0", Offset = "0x26A79B0", VA = "0x26AB9B0")]
		private void CloseBufferAndWriter()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x26AB9F8", Offset = "0x26A79F8", VA = "0x26AB9F8", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x26ABA70", Offset = "0x26A7A70", VA = "0x26ABA70", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x26ABAA8", Offset = "0x26A7AA8", VA = "0x26ABAA8", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x26ABB50", Offset = "0x26A7B50", VA = "0x26ABB50", Slot = "17")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x26ABC44", Offset = "0x26A7C44", VA = "0x26ABC44", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x26ABD7C", Offset = "0x26A7D7C", VA = "0x26ABD7C", Slot = "14")]
		public override void WritePropertyName(string name, bool escape)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x26ABE3C", Offset = "0x26A7E3C", VA = "0x26ABE3C", Slot = "5")]
		internal override void OnStringEscapeHandlingChanged()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x26AB910", Offset = "0x26A7910", VA = "0x26AB910")]
		private void UpdateCharEscapeFlags()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x26ABE40", Offset = "0x26A7E40", VA = "0x26ABE40", Slot = "18")]
		protected override void WriteIndent()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x26ABFB4", Offset = "0x26A7FB4", VA = "0x26ABFB4")]
		private int SetIndentChars()
		{
			return default(int);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x26AC098", Offset = "0x26A8098", VA = "0x26AC098", Slot = "19")]
		protected override void WriteValueDelimiter()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x26AC0BC", Offset = "0x26A80BC", VA = "0x26AC0BC", Slot = "20")]
		protected override void WriteIndentSpace()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x26AC0E0", Offset = "0x26A80E0", VA = "0x26AC0E0")]
		private void WriteValueInternal(string value, JsonToken token)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x26AC100", Offset = "0x26A8100", VA = "0x26AC100", Slot = "62")]
		public override void WriteValue(object? value)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x26AC36C", Offset = "0x26A836C", VA = "0x26AC36C", Slot = "21")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x26AC400", Offset = "0x26A8400", VA = "0x26AC400", Slot = "22")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x26AC494", Offset = "0x26A8494", VA = "0x26AC494", Slot = "23")]
		public override void WriteRaw(string? json)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x26AC4B8", Offset = "0x26A84B8", VA = "0x26AC4B8", Slot = "25")]
		public override void WriteValue(string? value)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x26ABCA8", Offset = "0x26A7CA8", VA = "0x26ABCA8")]
		private void WriteEscapedString(string value, bool quote)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x26AC59C", Offset = "0x26A859C", VA = "0x26AC59C", Slot = "26")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x26AC628", Offset = "0x26A8628", VA = "0x26AC628", Slot = "27")]
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x26AC6B4", Offset = "0x26A86B4", VA = "0x26AC6B4", Slot = "28")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x26AC6F8", Offset = "0x26A86F8", VA = "0x26AC6F8", Slot = "29")]
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x26AC7B0", Offset = "0x26A87B0", VA = "0x26AC7B0", Slot = "30")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x26AC868", Offset = "0x26A8868", VA = "0x26AC868", Slot = "47")]
		public override void WriteValue(float? value)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x26AC968", Offset = "0x26A8968", VA = "0x26AC968", Slot = "31")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x26ACA20", Offset = "0x26A8A20", VA = "0x26ACA20", Slot = "48")]
		public override void WriteValue(double? value)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x26ACB2C", Offset = "0x26A8B2C", VA = "0x26ACB2C", Slot = "32")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x26ACBC8", Offset = "0x26A8BC8", VA = "0x26ACBC8", Slot = "33")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x26ACC0C", Offset = "0x26A8C0C", VA = "0x26ACC0C", Slot = "34")]
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x26ACC50", Offset = "0x26A8C50", VA = "0x26ACC50", Slot = "35")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x26ACCEC", Offset = "0x26A8CEC", VA = "0x26ACCEC", Slot = "36")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x26ACD30", Offset = "0x26A8D30", VA = "0x26ACD30", Slot = "37")]
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x26ACD74", Offset = "0x26A8D74", VA = "0x26ACD74", Slot = "38")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x26ACE20", Offset = "0x26A8E20", VA = "0x26ACE20", Slot = "39")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x26ACFB0", Offset = "0x26A8FB0", VA = "0x26ACFB0")]
		private int WriteValueToBuffer(DateTime value)
		{
			return default(int);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x26AD0D8", Offset = "0x26A90D8", VA = "0x26AD0D8", Slot = "60")]
		public override void WriteValue(byte[]? value)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x26AD1A0", Offset = "0x26A91A0", VA = "0x26AD1A0", Slot = "40")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x26AD308", Offset = "0x26A9308", VA = "0x26AD308")]
		private int WriteValueToBuffer(DateTimeOffset value)
		{
			return default(int);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x26AD488", Offset = "0x26A9488", VA = "0x26AD488", Slot = "41")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x26AD594", Offset = "0x26A9594", VA = "0x26AD594", Slot = "42")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x26AD6B8", Offset = "0x26A96B8", VA = "0x26AD6B8", Slot = "61")]
		public override void WriteValue(Uri? value)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x26AD788", Offset = "0x26A9788", VA = "0x26AD788", Slot = "63")]
		public override void WriteComment(string? text)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x26AC56C", Offset = "0x26A856C", VA = "0x26AC56C")]
		private void EnsureWriteBuffer()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x26AC66C", Offset = "0x26A866C", VA = "0x26AC66C")]
		private void WriteIntegerValue(long value)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x26AC740", Offset = "0x26A8740", VA = "0x26AC740")]
		private void WriteIntegerValue(ulong value, bool negative)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x26AD848", Offset = "0x26A9848", VA = "0x26AD848")]
		private int WriteNumberToBuffer(ulong value, bool negative)
		{
			return default(int);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x26AC5E0", Offset = "0x26A85E0", VA = "0x26AC5E0")]
		private void WriteIntegerValue(int value)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x26AD9E0", Offset = "0x26A99E0", VA = "0x26AD9E0")]
		private void WriteIntegerValue(uint value, bool negative)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x26AD924", Offset = "0x26A9924", VA = "0x26AD924")]
		private int WriteNumberToBuffer(uint value, bool negative)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200002E")]
	public enum JsonToken
	{
		[Token(Token = "0x40000E2")]
		None,
		[Token(Token = "0x40000E3")]
		StartObject,
		[Token(Token = "0x40000E4")]
		StartArray,
		[Token(Token = "0x40000E5")]
		StartConstructor,
		[Token(Token = "0x40000E6")]
		PropertyName,
		[Token(Token = "0x40000E7")]
		Comment,
		[Token(Token = "0x40000E8")]
		Raw,
		[Token(Token = "0x40000E9")]
		Integer,
		[Token(Token = "0x40000EA")]
		Float,
		[Token(Token = "0x40000EB")]
		String,
		[Token(Token = "0x40000EC")]
		Boolean,
		[Token(Token = "0x40000ED")]
		Null,
		[Token(Token = "0x40000EE")]
		Undefined,
		[Token(Token = "0x40000EF")]
		EndObject,
		[Token(Token = "0x40000F0")]
		EndArray,
		[Token(Token = "0x40000F1")]
		EndConstructor,
		[Token(Token = "0x40000F2")]
		Date,
		[Token(Token = "0x40000F3")]
		Bytes
	}
	[Token(Token = "0x200002F")]
	public abstract class JsonWriter : IDisposable
	{
		[Token(Token = "0x2000030")]
		internal enum State
		{
			[Token(Token = "0x4000103")]
			Start,
			[Token(Token = "0x4000104")]
			Property,
			[Token(Token = "0x4000105")]
			ObjectStart,
			[Token(Token = "0x4000106")]
			Object,
			[Token(Token = "0x4000107")]
			ArrayStart,
			[Token(Token = "0x4000108")]
			Array,
			[Token(Token = "0x4000109")]
			ConstructorStart,
			[Token(Token = "0x400010A")]
			Constructor,
			[Token(Token = "0x400010B")]
			Closed,
			[Token(Token = "0x400010C")]
			Error
		}

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly State[][] StateArray;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly State[][] StateArrayTemplate;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JsonPosition>? _stack;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private JsonPosition _currentPosition;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private State _currentState;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Formatting _formatting;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private DateFormatHandling _dateFormatHandling;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private StringEscapeHandling _stringEscapeHandling;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FloatFormatHandling _floatFormatHandling;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string? _dateFormatString;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CultureInfo? _culture;

		[Token(Token = "0x1700004E")]
		public bool CloseOutput
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x26ADF5C", Offset = "0x26A9F5C", VA = "0x26ADF5C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x26ADF64", Offset = "0x26A9F64", VA = "0x26ADF64")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public bool AutoCompleteOnClose
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x26ADF6C", Offset = "0x26A9F6C", VA = "0x26ADF6C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x26ADF74", Offset = "0x26A9F74", VA = "0x26ADF74")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		protected internal int Top
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x26ABF64", Offset = "0x26A7F64", VA = "0x26ABF64")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000051")]
		public WriteState WriteState
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x26ADF84", Offset = "0x26A9F84", VA = "0x26ADF84")]
			get
			{
				return default(WriteState);
			}
		}

		[Token(Token = "0x17000052")]
		internal string ContainerPath
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x26AE028", Offset = "0x26AA028", VA = "0x26AE028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public string Path
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x26AE0C8", Offset = "0x26AA0C8", VA = "0x26AE0C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public Formatting Formatting
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x26AE1D8", Offset = "0x26AA1D8", VA = "0x26AE1D8")]
			get
			{
				return default(Formatting);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x269D3C4", Offset = "0x26993C4", VA = "0x269D3C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x26AE1E0", Offset = "0x26AA1E0", VA = "0x26AE1E0")]
			get
			{
				return default(DateFormatHandling);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x26A4D0C", Offset = "0x26A0D0C", VA = "0x26A4D0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x26AE1E8", Offset = "0x26AA1E8", VA = "0x26AE1E8")]
			get
			{
				return default(DateTimeZoneHandling);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x26A4D68", Offset = "0x26A0D68", VA = "0x26A4D68")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x26AE1F0", Offset = "0x26AA1F0", VA = "0x26AE1F0")]
			get
			{
				return default(StringEscapeHandling);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x26A4E20", Offset = "0x26A0E20", VA = "0x26A4E20")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x26AE1FC", Offset = "0x26AA1FC", VA = "0x26AE1FC")]
			get
			{
				return default(FloatFormatHandling);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x26A4DC4", Offset = "0x26A0DC4", VA = "0x26A4DC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public string? DateFormatString
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x26AE204", Offset = "0x26AA204", VA = "0x26AE204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x26AE20C", Offset = "0x26AA20C", VA = "0x26AE20C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x26A4E88", Offset = "0x26A0E88", VA = "0x26A4E88")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x26AE214", Offset = "0x26AA214", VA = "0x26AE214")]
			set
			{
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x26ADA50", Offset = "0x26A9A50", VA = "0x26ADA50")]
		internal static State[][] BuildStateArray()
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x26ADCCC", Offset = "0x26A9CCC", VA = "0x26ADCCC")]
		static JsonWriter()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x26AE1F8", Offset = "0x26AA1F8", VA = "0x26AE1F8", Slot = "5")]
		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x26AB8E4", Offset = "0x26A78E4", VA = "0x26AB8E4")]
		protected JsonWriter()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x26AE21C", Offset = "0x26AA21C", VA = "0x26AE21C")]
		internal void UpdateScopeWithFinishedValue()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x26AE234", Offset = "0x26AA234", VA = "0x26AE234")]
		private void Push(JsonContainerType value)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x26AE3A4", Offset = "0x26AA3A4", VA = "0x26AE3A4")]
		private JsonContainerType Pop()
		{
			return default(JsonContainerType);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x26ADF7C", Offset = "0x26A9F7C", VA = "0x26ADF7C")]
		private JsonContainerType Peek()
		{
			return default(JsonContainerType);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x26AB9A0", Offset = "0x26A79A0", VA = "0x26AB9A0", Slot = "6")]
		public virtual void Close()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x26AE4B0", Offset = "0x26AA4B0", VA = "0x26AE4B0", Slot = "7")]
		public virtual void WriteStartObject()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x26AE4BC", Offset = "0x26AA4BC", VA = "0x26AE4BC", Slot = "8")]
		public virtual void WriteEndObject()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x26AE4C8", Offset = "0x26AA4C8", VA = "0x26AE4C8", Slot = "9")]
		public virtual void WriteStartArray()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x26AE4D4", Offset = "0x26AA4D4", VA = "0x26AE4D4", Slot = "10")]
		public virtual void WriteEndArray()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x26AE4DC", Offset = "0x26AA4DC", VA = "0x26AE4DC", Slot = "11")]
		public virtual void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x26AE4E8", Offset = "0x26AA4E8", VA = "0x26AE4E8", Slot = "12")]
		public virtual void WriteEndConstructor()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x26AE4F0", Offset = "0x26AA4F0", VA = "0x26AE4F0", Slot = "13")]
		public virtual void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x26AE500", Offset = "0x26AA500", VA = "0x26AE500", Slot = "14")]
		public virtual void WritePropertyName(string name, bool escape)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x26AE510", Offset = "0x26AA510", VA = "0x26AE510", Slot = "15")]
		public virtual void WriteEnd()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x26AE5F0", Offset = "0x26AA5F0", VA = "0x26AE5F0")]
		public void WriteToken(JsonReader reader)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x26AE5F8", Offset = "0x26AA5F8", VA = "0x26AE5F8")]
		public void WriteToken(JsonReader reader, bool writeChildren)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x26AE678", Offset = "0x26AA678", VA = "0x26AE678")]
		public void WriteToken(JsonToken token, object? value)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x26AED4C", Offset = "0x26AAD4C", VA = "0x26AED4C", Slot = "16")]
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x26AF060", Offset = "0x26AB060", VA = "0x26AF060")]
		private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x26AEF30", Offset = "0x26AAF30", VA = "0x26AEF30")]
		private int CalculateWriteTokenInitialDepth(JsonReader reader)
		{
			return default(int);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x26AF0CC", Offset = "0x26AB0CC", VA = "0x26AF0CC")]
		private int CalculateWriteTokenFinalDepth(JsonReader reader)
		{
			return default(int);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x26AEF94", Offset = "0x26AAF94", VA = "0x26AEF94")]
		private void WriteConstructorDate(JsonReader reader)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x26AE518", Offset = "0x26AA518", VA = "0x26AE518")]
		private void WriteEnd(JsonContainerType type)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x26AE470", Offset = "0x26AA470", VA = "0x26AE470")]
		private void AutoCompleteAll()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x26AF12C", Offset = "0x26AB12C", VA = "0x26AF12C")]
		private JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			return default(JsonToken);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x26AF1C8", Offset = "0x26AB1C8", VA = "0x26AF1C8")]
		private void AutoCompleteClose(JsonContainerType type)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x26AF284", Offset = "0x26AB284", VA = "0x26AF284")]
		private int CalculateLevelsToComplete(JsonContainerType type)
		{
			return default(int);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x26AF37C", Offset = "0x26AB37C", VA = "0x26AF37C")]
		private void UpdateCurrentState()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x26AF42C", Offset = "0x26AB42C", VA = "0x26AF42C", Slot = "17")]
		protected virtual void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x26AF430", Offset = "0x26AB430", VA = "0x26AF430", Slot = "18")]
		protected virtual void WriteIndent()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x26AF434", Offset = "0x26AB434", VA = "0x26AF434", Slot = "19")]
		protected virtual void WriteValueDelimiter()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x26AF438", Offset = "0x26AB438", VA = "0x26AF438", Slot = "20")]
		protected virtual void WriteIndentSpace()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x26AF43C", Offset = "0x26AB43C", VA = "0x26AF43C")]
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x26AF64C", Offset = "0x26AB64C", VA = "0x26AF64C", Slot = "21")]
		public virtual void WriteNull()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x26AF668", Offset = "0x26AB668", VA = "0x26AF668", Slot = "22")]
		public virtual void WriteUndefined()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x26AF684", Offset = "0x26AB684", VA = "0x26AF684", Slot = "23")]
		public virtual void WriteRaw(string? json)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x26AF688", Offset = "0x26AB688", VA = "0x26AF688", Slot = "24")]
		public virtual void WriteRawValue(string? json)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x26AF6D8", Offset = "0x26AB6D8", VA = "0x26AF6D8", Slot = "25")]
		public virtual void WriteValue(string? value)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x26AF6F4", Offset = "0x26AB6F4", VA = "0x26AF6F4", Slot = "26")]
		public virtual void WriteValue(int value)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x26AF710", Offset = "0x26AB710", VA = "0x26AF710", Slot = "27")]
		[CLSCompliant(false)]
		public virtual void WriteValue(uint value)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x26AF72C", Offset = "0x26AB72C", VA = "0x26AF72C", Slot = "28")]
		public virtual void WriteValue(long value)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x26AF748", Offset = "0x26AB748", VA = "0x26AF748", Slot = "29")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x26AF764", Offset = "0x26AB764", VA = "0x26AF764", Slot = "30")]
		public virtual void WriteValue(float value)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x26AF780", Offset = "0x26AB780", VA = "0x26AF780", Slot = "31")]
		public virtual void WriteValue(double value)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x26AF79C", Offset = "0x26AB79C", VA = "0x26AF79C", Slot = "32")]
		public virtual void WriteValue(bool value)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x26AF7B8", Offset = "0x26AB7B8", VA = "0x26AF7B8", Slot = "33")]
		public virtual void WriteValue(short value)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x26AF7D4", Offset = "0x26AB7D4", VA = "0x26AF7D4", Slot = "34")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x26AF7F0", Offset = "0x26AB7F0", VA = "0x26AF7F0", Slot = "35")]
		public virtual void WriteValue(char value)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x26AF80C", Offset = "0x26AB80C", VA = "0x26AF80C", Slot = "36")]
		public virtual void WriteValue(byte value)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x26AF828", Offset = "0x26AB828", VA = "0x26AF828", Slot = "37")]
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x26AF844", Offset = "0x26AB844", VA = "0x26AF844", Slot = "38")]
		public virtual void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x26AF860", Offset = "0x26AB860", VA = "0x26AF860", Slot = "39")]
		public virtual void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x26AF87C", Offset = "0x26AB87C", VA = "0x26AF87C", Slot = "40")]
		public virtual void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x26AF898", Offset = "0x26AB898", VA = "0x26AF898", Slot = "41")]
		public virtual void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x26AF8B4", Offset = "0x26AB8B4", VA = "0x26AF8B4", Slot = "42")]
		public virtual void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x26AF8D0", Offset = "0x26AB8D0", VA = "0x26AF8D0", Slot = "43")]
		public virtual void WriteValue(int? value)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x26AF94C", Offset = "0x26AB94C", VA = "0x26AF94C", Slot = "44")]
		[CLSCompliant(false)]
		public virtual void WriteValue(uint? value)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x26AF9C8", Offset = "0x26AB9C8", VA = "0x26AF9C8", Slot = "45")]
		public virtual void WriteValue(long? value)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x26AFA54", Offset = "0x26ABA54", VA = "0x26AFA54", Slot = "46")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong? value)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x26AFAE0", Offset = "0x26ABAE0", VA = "0x26AFAE0", Slot = "47")]
		public virtual void WriteValue(float? value)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x26AFB60", Offset = "0x26ABB60", VA = "0x26AFB60", Slot = "48")]
		public virtual void WriteValue(double? value)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x26AFBEC", Offset = "0x26ABBEC", VA = "0x26AFBEC", Slot = "49")]
		public virtual void WriteValue(bool? value)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x26AFC70", Offset = "0x26ABC70", VA = "0x26AFC70", Slot = "50")]
		public virtual void WriteValue(short? value)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x26AFCEC", Offset = "0x26ABCEC", VA = "0x26AFCEC", Slot = "51")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort? value)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x26AFD68", Offset = "0x26ABD68", VA = "0x26AFD68", Slot = "52")]
		public virtual void WriteValue(char? value)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x26AFDE4", Offset = "0x26ABDE4", VA = "0x26AFDE4", Slot = "53")]
		public virtual void WriteValue(byte? value)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x26AFE60", Offset = "0x26ABE60", VA = "0x26AFE60", Slot = "54")]
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte? value)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x26AFEDC", Offset = "0x26ABEDC", VA = "0x26AFEDC", Slot = "55")]
		public virtual void WriteValue(decimal? value)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x26AFF5C", Offset = "0x26ABF5C", VA = "0x26AFF5C", Slot = "56")]
		public virtual void WriteValue(DateTime? value)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x26AFFE8", Offset = "0x26ABFE8", VA = "0x26AFFE8", Slot = "57")]
		public virtual void WriteValue(DateTimeOffset? value)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x26B0068", Offset = "0x26AC068", VA = "0x26B0068", Slot = "58")]
		public virtual void WriteValue(Guid? value)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x26B00EC", Offset = "0x26AC0EC", VA = "0x26B00EC", Slot = "59")]
		public virtual void WriteValue(TimeSpan? value)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x26B0178", Offset = "0x26AC178", VA = "0x26B0178", Slot = "60")]
		public virtual void WriteValue(byte[]? value)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x26B01A8", Offset = "0x26AC1A8", VA = "0x26B01A8", Slot = "61")]
		public virtual void WriteValue(Uri? value)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x26AC238", Offset = "0x26A8238", VA = "0x26AC238", Slot = "62")]
		public virtual void WriteValue(object? value)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x26B13FC", Offset = "0x26AD3FC", VA = "0x26B13FC", Slot = "63")]
		public virtual void WriteComment(string? text)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x26B1404", Offset = "0x26AD404", VA = "0x26B1404", Slot = "4")]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x26B1474", Offset = "0x26AD474", VA = "0x26B1474", Slot = "64")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x26B030C", Offset = "0x26AC30C", VA = "0x26B030C")]
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x26B1494", Offset = "0x26AD494", VA = "0x26B1494")]
		private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x26B0254", Offset = "0x26AC254", VA = "0x26B0254")]
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x26B162C", Offset = "0x26AD62C", VA = "0x26B162C")]
		protected void SetWriteState(JsonToken token, object value)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x26AE4C4", Offset = "0x26AA4C4", VA = "0x26AE4C4")]
		internal void InternalWriteEnd(JsonContainerType container)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x26ABC98", Offset = "0x26A7C98", VA = "0x26ABC98")]
		internal void InternalWritePropertyName(string name)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x26AC4B4", Offset = "0x26A84B4", VA = "0x26AC4B4")]
		internal void InternalWriteRaw()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x26ABA30", Offset = "0x26A7A30", VA = "0x26ABA30")]
		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x26AC220", Offset = "0x26A8220", VA = "0x26AC220")]
		internal void InternalWriteValue(JsonToken token)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x26AD840", Offset = "0x26A9840", VA = "0x26AD840")]
		internal void InternalWriteComment()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class JsonWriterException : JsonException
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x26B184C", Offset = "0x26AD84C", VA = "0x26B184C")]
		public JsonWriterException()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x26B1854", Offset = "0x26AD854", VA = "0x26B1854")]
		public JsonWriterException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x26B185C", Offset = "0x26AD85C", VA = "0x26B185C")]
		public JsonWriterException(string message, string path, Exception? innerException)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x26B1888", Offset = "0x26AD888", VA = "0x26B1888")]
		internal static JsonWriterException Create(JsonWriter writer, string message, Exception? ex)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x26B18BC", Offset = "0x26AD8BC", VA = "0x26B18BC")]
		internal static JsonWriterException Create(string path, string message, Exception? ex)
		{
			return null;
		}
	}
	[Token(Token = "0x2000032")]
	public enum MemberSerialization
	{
		[Token(Token = "0x400010F")]
		OptOut,
		[Token(Token = "0x4000110")]
		OptIn,
		[Token(Token = "0x4000111")]
		Fields
	}
	[Token(Token = "0x2000033")]
	public enum MetadataPropertyHandling
	{
		[Token(Token = "0x4000113")]
		Default,
		[Token(Token = "0x4000114")]
		ReadAhead,
		[Token(Token = "0x4000115")]
		Ignore
	}
	[Token(Token = "0x2000034")]
	public enum MissingMemberHandling
	{
		[Token(Token = "0x4000117")]
		Ignore,
		[Token(Token = "0x4000118")]
		Error
	}
	[Token(Token = "0x2000035")]
	public enum NullValueHandling
	{
		[Token(Token = "0x400011A")]
		Include,
		[Token(Token = "0x400011B")]
		Ignore
	}
	[Token(Token = "0x2000036")]
	public enum ObjectCreationHandling
	{
		[Token(Token = "0x400011D")]
		Auto,
		[Token(Token = "0x400011E")]
		Reuse,
		[Token(Token = "0x400011F")]
		Replace
	}
	[Token(Token = "0x2000037")]
	[Flags]
	public enum PreserveReferencesHandling
	{
		[Token(Token = "0x4000121")]
		None = 0,
		[Token(Token = "0x4000122")]
		Objects = 1,
		[Token(Token = "0x4000123")]
		Arrays = 2,
		[Token(Token = "0x4000124")]
		All = 3
	}
	[Token(Token = "0x2000038")]
	public enum ReferenceLoopHandling
	{
		[Token(Token = "0x4000126")]
		Error,
		[Token(Token = "0x4000127")]
		Ignore,
		[Token(Token = "0x4000128")]
		Serialize
	}
	[Token(Token = "0x2000039")]
	public enum Required
	{
		[Token(Token = "0x400012A")]
		Default,
		[Token(Token = "0x400012B")]
		AllowNull,
		[Token(Token = "0x400012C")]
		Always,
		[Token(Token = "0x400012D")]
		DisallowNull
	}
	[Token(Token = "0x200003A")]
	public enum StringEscapeHandling
	{
		[Token(Token = "0x400012F")]
		Default,
		[Token(Token = "0x4000130")]
		EscapeNonAscii,
		[Token(Token = "0x4000131")]
		EscapeHtml
	}
	[Token(Token = "0x200003B")]
	public enum TypeNameAssemblyFormatHandling
	{
		[Token(Token = "0x4000133")]
		Simple,
		[Token(Token = "0x4000134")]
		Full
	}
	[Token(Token = "0x200003C")]
	[Flags]
	public enum TypeNameHandling
	{
		[Token(Token = "0x4000136")]
		None = 0,
		[Token(Token = "0x4000137")]
		Objects = 1,
		[Token(Token = "0x4000138")]
		Arrays = 2,
		[Token(Token = "0x4000139")]
		All = 3,
		[Token(Token = "0x400013A")]
		Auto = 4
	}
	[Token(Token = "0x200003D")]
	public enum WriteState
	{
		[Token(Token = "0x400013C")]
		Error,
		[Token(Token = "0x400013D")]
		Closed,
		[Token(Token = "0x400013E")]
		Object,
		[Token(Token = "0x400013F")]
		Array,
		[Token(Token = "0x4000140")]
		Constructor,
		[Token(Token = "0x4000141")]
		Property,
		[Token(Token = "0x4000142")]
		Start
	}
}
namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200003E")]
	internal class Base64Encoder
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly char[] _charsLine;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly TextWriter _writer;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[]? _leftOverBytes;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _leftOverBytesCount;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x26B1970", Offset = "0x26AD970", VA = "0x26B1970")]
		public Base64Encoder(TextWriter writer)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x26B1A48", Offset = "0x26ADA48", VA = "0x26B1A48")]
		private void ValidateEncode(byte[] buffer, int index, int count)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x26B1B0C", Offset = "0x26ADB0C", VA = "0x26B1B0C")]
		public void Encode(byte[] buffer, int index, int count)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x26B1D68", Offset = "0x26ADD68", VA = "0x26B1D68")]
		private void StoreLeftOverBytes(byte[] buffer, int index, ref int count)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x26B1CAC", Offset = "0x26ADCAC", VA = "0x26B1CAC")]
		private bool FulfillFromLeftover(byte[] buffer, int index, ref int count)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x26B1E68", Offset = "0x26ADE68", VA = "0x26B1E68")]
		public void Flush()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x26B1D48", Offset = "0x26ADD48", VA = "0x26B1D48")]
		private void WriteChars(char[] chars, int index, int count)
		{
		}
	}
	[Token(Token = "0x200003F")]
	internal class BidirectionalDictionary<TFirst, TSecond> where TFirst : notnull where TSecond : notnull
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string _duplicateFirstErrorMessage;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string _duplicateSecondErrorMessage;

		[Token(Token = "0x60001E0")]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
		}

		[Token(Token = "0x60001E1")]
		public void Set(TFirst first, TSecond second)
		{
		}

		[Token(Token = "0x60001E2")]
		public bool TryGetByFirst(TFirst first, [NotNullWhen(true)] out TSecond? second)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E3")]
		public bool TryGetBySecond(TSecond second, [NotNullWhen(true)] out TFirst? first)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000040")]
	internal static class BoxedPrimitives
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly object BooleanTrue;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly object BooleanFalse;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly object Int32_M1;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static readonly object Int32_0;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly object Int32_1;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static readonly object Int32_2;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal static readonly object Int32_3;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal static readonly object Int32_4;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal static readonly object Int32_5;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal static readonly object Int32_6;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal static readonly object Int32_7;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal static readonly object Int32_8;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal static readonly object Int64_M1;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal static readonly object Int64_0;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal static readonly object Int64_1;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal static readonly object Int64_2;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal static readonly object Int64_3;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal static readonly object Int64_4;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal static readonly object Int64_5;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal static readonly object Int64_6;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal static readonly object Int64_7;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal static readonly object Int64_8;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static readonly object DecimalZero;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal static readonly object DoubleNaN;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal static readonly object DoublePositiveInfinity;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal static readonly object DoubleNegativeInfinity;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal static readonly object DoubleZero;

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x26B1F20", Offset = "0x26ADF20", VA = "0x26B1F20")]
		internal static object Get(bool value)
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x26B1F98", Offset = "0x26ADF98", VA = "0x26B1F98")]
		internal static object Get(int value)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x26B21E8", Offset = "0x26AE1E8", VA = "0x26B21E8")]
		internal static object Get(long value)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x26B2394", Offset = "0x26AE394", VA = "0x26B2394")]
		internal static object Get(decimal value)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x26B247C", Offset = "0x26AE47C", VA = "0x26B247C")]
		internal static object Get(double value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	internal static class CollectionUtils
	{
		[Token(Token = "0x2000042")]
		private static class EmptyArrayContainer<T>
		{
			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly T[] Empty;
		}

		[Token(Token = "0x60001EA")]
		public static bool IsNullOrEmpty<T>(ICollection<T> collection) where T : notnull
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection) where T : notnull
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x26B2A2C", Offset = "0x26AEA2C", VA = "0x26B2A2C")]
		public static bool IsDictionaryType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x26B2C30", Offset = "0x26AEC30", VA = "0x26B2C30")]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x26B2D40", Offset = "0x26AED40", VA = "0x26B2D40")]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate) where T : notnull
		{
			return default(int);
		}

		[Token(Token = "0x60001F0")]
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer) where T : notnull
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		public static int IndexOfReference<T>(this List<T> list, T item) where T : notnull
		{
			return default(int);
		}

		[Token(Token = "0x60001F2")]
		public static void FastReverse<T>(this List<T> list) where T : notnull
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x26B3070", Offset = "0x26AF070", VA = "0x26B3070")]
		private static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x26B3324", Offset = "0x26AF324", VA = "0x26B3324")]
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x26B35D8", Offset = "0x26AF5D8", VA = "0x26B35D8")]
		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x26B3778", Offset = "0x26AF778", VA = "0x26B3778")]
		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		public static T[] ArrayEmpty<T>() where T : notnull
		{
			return null;
		}
	}
	[Token(Token = "0x2000043")]
	internal interface IWrappedCollection : IList, ICollection, IEnumerable
	{
		[Token(Token = "0x1700005B")]
		object UnderlyingCollection
		{
			[Token(Token = "0x60001F9")]
			get;
		}
	}
	[Token(Token = "0x2000044")]
	internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection where T : notnull
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IList? _list;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ICollection<T>? _genericCollection;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object? _syncRoot;

		[Token(Token = "0x1700005C")]
		public virtual int Count
		{
			[Token(Token = "0x60001FE")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005D")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x60001FF")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		private bool System.Collections.IList.IsFixedSize
		{
			[Token(Token = "0x6000208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		private object? System.Collections.IList.Item
		{
			[Token(Token = "0x600020A")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020B")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x600020D")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x600020E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public object UnderlyingCollection
		{
			[Token(Token = "0x6000211")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FA")]
		public virtual void Add(T item)
		{
		}

		[Token(Token = "0x60001FB")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x60001FC")]
		public virtual bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000200")]
		public virtual bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		public virtual IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		private int System.Collections.IList.Add(object? value)
		{
			return default(int);
		}

		[Token(Token = "0x6000204")]
		private bool System.Collections.IList.Contains(object? value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		private int System.Collections.IList.IndexOf(object? value)
		{
			return default(int);
		}

		[Token(Token = "0x6000206")]
		private void System.Collections.IList.RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000207")]
		private void System.Collections.IList.Insert(int index, object? value)
		{
		}

		[Token(Token = "0x6000209")]
		private void System.Collections.IList.Remove(object? value)
		{
		}

		[Token(Token = "0x600020C")]
		private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex)
		{
		}

		[Token(Token = "0x600020F")]
		private static void VerifyValueType(object? value)
		{
		}

		[Token(Token = "0x6000210")]
		private static bool IsCompatibleObject(object? value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000045")]
	internal enum PrimitiveTypeCode
	{
		[Token(Token = "0x400016B")]
		Empty,
		[Token(Token = "0x400016C")]
		Object,
		[Token(Token = "0x400016D")]
		Char,
		[Token(Token = "0x400016E")]
		CharNullable,
		[Token(Token = "0x400016F")]
		Boolean,
		[Token(Token = "0x4000170")]
		BooleanNullable,
		[Token(Token = "0x4000171")]
		SByte,
		[Token(Token = "0x4000172")]
		SByteNullable,
		[Token(Token = "0x4000173")]
		Int16,
		[Token(Token = "0x4000174")]
		Int16Nullable,
		[Token(Token = "0x4000175")]
		UInt16,
		[Token(Token = "0x4000176")]
		UInt16Nullable,
		[Token(Token = "0x4000177")]
		Int32,
		[Token(Token = "0x4000178")]
		Int32Nullable,
		[Token(Token = "0x4000179")]
		Byte,
		[Token(Token = "0x400017A")]
		ByteNullable,
		[Token(Token = "0x400017B")]
		UInt32,
		[Token(Token = "0x400017C")]
		UInt32Nullable,
		[Token(Token = "0x400017D")]
		Int64,
		[Token(Token = "0x400017E")]
		Int64Nullable,
		[Token(Token = "0x400017F")]
		UInt64,
		[Token(Token = "0x4000180")]
		UInt64Nullable,
		[Token(Token = "0x4000181")]
		Single,
		[Token(Token = "0x4000182")]
		SingleNullable,
		[Token(Token = "0x4000183")]
		Double,
		[Token(Token = "0x4000184")]
		DoubleNullable,
		[Token(Token = "0x4000185")]
		DateTime,
		[Token(Token = "0x4000186")]
		DateTimeNullable,
		[Token(Token = "0x4000187")]
		DateTimeOffset,
		[Token(Token = "0x4000188")]
		DateTimeOffsetNullable,
		[Token(Token = "0x4000189")]
		Decimal,
		[Token(Token = "0x400018A")]
		DecimalNullable,
		[Token(Token = "0x400018B")]
		Guid,
		[Token(Token = "0x400018C")]
		GuidNullable,
		[Token(Token = "0x400018D")]
		TimeSpan,
		[Token(Token = "0x400018E")]
		TimeSpanNullable,
		[Token(Token = "0x400018F")]
		BigInteger,
		[Token(Token = "0x4000190")]
		BigIntegerNullable,
		[Token(Token = "0x4000191")]
		Uri,
		[Token(Token = "0x4000192")]
		String,
		[Token(Token = "0x4000193")]
		Bytes,
		[Token(Token = "0x4000194")]
		DBNull
	}
	[Token(Token = "0x2000046")]
	internal class TypeInformation
	{
		[Token(Token = "0x17000063")]
		public Type Type
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x26B395C", Offset = "0x26AF95C", VA = "0x26B395C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public PrimitiveTypeCode TypeCode
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x26B3964", Offset = "0x26AF964", VA = "0x26B3964")]
			[CompilerGenerated]
			get
			{
				return default(PrimitiveTypeCode);
			}
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x26B396C", Offset = "0x26AF96C", VA = "0x26B396C")]
		public TypeInformation(Type type, PrimitiveTypeCode typeCode)
		{
		}
	}
	[Token(Token = "0x2000047")]
	internal enum ParseResult
	{
		[Token(Token = "0x4000198")]
		None,
		[Token(Token = "0x4000199")]
		Success,
		[Token(Token = "0x400019A")]
		Overflow,
		[Token(Token = "0x400019B")]
		Invalid
	}
	[Token(Token = "0x2000048")]
	internal static class ConvertUtils
	{
		[Token(Token = "0x2000049")]
		internal enum ConvertResult
		{
			[Token(Token = "0x40001A0")]
			Success,
			[Token(Token = "0x40001A1")]
			CannotConvertNull,
			[Token(Token = "0x40001A2")]
			NotInstantiableType,
			[Token(Token = "0x40001A3")]
			NoValidConversion
		}

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly TypeInformation[] PrimitiveTypeCodes;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object?, object?>?> CastConverters;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x26B399C", Offset = "0x26AF99C", VA = "0x26B399C")]
		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			return default(PrimitiveTypeCode);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x26B3A00", Offset = "0x26AFA00", VA = "0x26B3A00")]
		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			return default(PrimitiveTypeCode);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x26B3D8C", Offset = "0x26AFD8C", VA = "0x26B3D8C")]
		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x26B3E78", Offset = "0x26AFE78", VA = "0x26B3E78")]
		public static bool IsConvertible(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x26B3F0C", Offset = "0x26AFF0C", VA = "0x26B3F0C")]
		public static TimeSpan ParseTimeSpan(string input)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x26B3F9C", Offset = "0x26AFF9C", VA = "0x26B3F9C")]
		private static Func<object?, object?>? CreateCastConverter(StructMultiKey<Type, Type> t)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x26B41DC", Offset = "0x26B01DC", VA = "0x26B41DC")]
		internal static BigInteger ToBigInteger(object value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x26B45F4", Offset = "0x26B05F4", VA = "0x26B45F4")]
		public static object FromBigInteger(BigInteger i, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x26B4B18", Offset = "0x26B0B18", VA = "0x26B4B18")]
		public static object Convert(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x26B5850", Offset = "0x26B1850", VA = "0x26B5850")]
		private static bool TryConvert(object? initialValue, CultureInfo culture, Type targetType, out object? value)
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x26B4D74", Offset = "0x26B0D74", VA = "0x26B4D74")]
		private static ConvertResult TryConvertInternal(object? initialValue, CultureInfo culture, Type targetType, out object? value)
		{
			return default(ConvertResult);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x26B5CD4", Offset = "0x26B1CD4", VA = "0x26B5CD4")]
		public static object ConvertOrCast(object? initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x26B5A88", Offset = "0x26B1A88", VA = "0x26B5A88")]
		private static object EnsureTypeAssignable(object? value, Type initialType, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x26B59E4", Offset = "0x26B19E4", VA = "0x26B59E4")]
		public static bool VersionTryParse(string input, [NotNullWhen(true)] out Version? result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x26B5958", Offset = "0x26B1958", VA = "0x26B5958")]
		public static bool IsInteger(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x26B5E70", Offset = "0x26B1E70", VA = "0x26B5E70")]
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			return default(ParseResult);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x26B5FE8", Offset = "0x26B1FE8", VA = "0x26B5FE8")]
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			return default(ParseResult);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x26B6148", Offset = "0x26B2148", VA = "0x26B6148")]
		public static ParseResult DecimalTryParse(char[] chars, int start, int length, out decimal value)
		{
			return default(ParseResult);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x26B6B24", Offset = "0x26B2B24", VA = "0x26B6B24")]
		public static bool TryConvertGuid(string s, out Guid g)
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x26B6B80", Offset = "0x26B2B80", VA = "0x26B6B80")]
		public static bool TryHexTextToInt(char[] text, int start, int end, out int value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004B")]
	internal enum ParserTimeZone
	{
		[Token(Token = "0x40001A6")]
		Unspecified,
		[Token(Token = "0x40001A7")]
		Utc,
		[Token(Token = "0x40001A8")]
		LocalWestOfUtc,
		[Token(Token = "0x40001A9")]
		LocalEastOfUtc
	}
	[Token(Token = "0x200004C")]
	internal struct DateTimeParser
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Year;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Month;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int Day;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int Hour;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Minute;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Second;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Fraction;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int ZoneHour;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ZoneMinute;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ParserTimeZone Zone;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private char[] _text;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _end;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] Power10;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int Lzyyyy;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int Lzyyyy_;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int Lzyyyy_MM;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int Lzyyyy_MM_;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int Lzyyyy_MM_dd;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int Lzyyyy_MM_ddT;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int LzHH;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int LzHH_;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int LzHH_mm;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly int LzHH_mm_;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly int LzHH_mm_ss;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static readonly int Lz_;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly int Lz_zz;

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x26B7E00", Offset = "0x26B3E00", VA = "0x26B7E00")]
		static DateTimeParser()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x26B8074", Offset = "0x26B4074", VA = "0x26B8074")]
		public bool Parse(char[] text, int startIndex, int length)
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x26B8164", Offset = "0x26B4164", VA = "0x26B8164")]
		private bool ParseDate(int start)
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x26B8350", Offset = "0x26B4350", VA = "0x26B8350")]
		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x26B8558", Offset = "0x26B4558", VA = "0x26B8558")]
		private bool ParseTime(ref int start)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x26B8820", Offset = "0x26B4820", VA = "0x26B8820")]
		private bool ParseZone(int start)
		{
			return default(bool);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x26B83EC", Offset = "0x26B43EC", VA = "0x26B83EC")]
		private bool Parse4Digit(int start, out int num)
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x26B84C4", Offset = "0x26B44C4", VA = "0x26B84C4")]
		private bool Parse2Digit(int start, out int num)
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x26B8304", Offset = "0x26B4304", VA = "0x26B8304")]
		private bool ParseChar(int start, char ch)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004D")]
	internal static class DateTimeUtils
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly long InitialJavaScriptDateTicks;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] DaysToMonth365;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int[] DaysToMonth366;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x26B8A20", Offset = "0x26B4A20", VA = "0x26B8A20")]
		static DateTimeUtils()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x26B8B0C", Offset = "0x26B4B0C", VA = "0x26B8B0C")]
		public static TimeSpan GetUtcOffset(this DateTime d)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x26B8B74", Offset = "0x26B4B74", VA = "0x26B8B74")]
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			return default(XmlDateTimeSerializationMode);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x26B8CEC", Offset = "0x26B4CEC", VA = "0x26B8CEC")]
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x26B8E44", Offset = "0x26B4E44", VA = "0x26B8E44")]
		private static DateTime SwitchToLocalTime(DateTime value)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x26B8F1C", Offset = "0x26B4F1C", VA = "0x26B8F1C")]
		private static DateTime SwitchToUtcTime(DateTime value)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x26B8FF4", Offset = "0x26B4FF4", VA = "0x26B8FF4")]
		private static long ToUniversalTicks(DateTime dateTime)
		{
			return default(long);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x26B90B4", Offset = "0x26B50B4", VA = "0x26B90B4")]
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			return default(long);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x26B920C", Offset = "0x26B520C", VA = "0x26B920C")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			return default(long);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x26B92F0", Offset = "0x26B52F0", VA = "0x26B92F0")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return default(long);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x26B9348", Offset = "0x26B5348", VA = "0x26B9348")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			return default(long);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x26B9274", Offset = "0x26B5274", VA = "0x26B9274")]
		private static long UniversalTicksToJavaScriptTicks(long universalTicks)
		{
			return default(long);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x26B9404", Offset = "0x26B5404", VA = "0x26B9404")]
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x26B948C", Offset = "0x26B548C", VA = "0x26B948C")]
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x26B99B4", Offset = "0x26B59B4", VA = "0x26B99B4")]
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x26B98BC", Offset = "0x26B58BC", VA = "0x26B98BC")]
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x26B9C2C", Offset = "0x26B5C2C", VA = "0x26B9C2C")]
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string? dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x26BA27C", Offset = "0x26B627C", VA = "0x26BA27C")]
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string? dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x26BA550", Offset = "0x26B6550", VA = "0x26BA550")]
		internal static bool TryParseDateTimeOffset(StringReference s, string? dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x26BA964", Offset = "0x26B6964", VA = "0x26BA964")]
		internal static bool TryParseDateTimeOffset(string s, string? dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x26BAC30", Offset = "0x26B6C30", VA = "0x26BAC30")]
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind)
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x26BA00C", Offset = "0x26B600C", VA = "0x26BA00C")]
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x26BA198", Offset = "0x26B6198", VA = "0x26BA198")]
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x26BA764", Offset = "0x26B6764", VA = "0x26BA764")]
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x26BA8B8", Offset = "0x26B68B8", VA = "0x26BA8B8")]
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x26BAE28", Offset = "0x26B6E28", VA = "0x26BAE28")]
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset)
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x26BAFB4", Offset = "0x26B6FB4", VA = "0x26BAFB4")]
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string? formatString, CultureInfo culture)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x26BB124", Offset = "0x26B7124", VA = "0x26BB124")]
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format)
		{
			return default(int);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x26BB5E4", Offset = "0x26B75E4", VA = "0x26BB5E4")]
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
		{
			return default(int);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x26BBC10", Offset = "0x26B7C10", VA = "0x26BBC10")]
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x26BB430", Offset = "0x26B7430", VA = "0x26BB430")]
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format)
		{
			return default(int);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x26BBC78", Offset = "0x26B7C78", VA = "0x26BBC78")]
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string? formatString, CultureInfo culture)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x26BB9EC", Offset = "0x26B79EC", VA = "0x26BB9EC")]
		private static void GetDateValues(DateTime td, out int year, out int month, out int day)
		{
		}
	}
	[Token(Token = "0x200004E")]
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		[Token(Token = "0x17000065")]
		object UnderlyingDictionary
		{
			[Token(Token = "0x6000256")]
			get;
		}
	}
	[Token(Token = "0x200004F")]
	internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection where TKey : notnull where TValue : notnull
	{
		[Token(Token = "0x2000050")]
		private readonly struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator, IEnumerator where TEnumeratorKey : notnull where TEnumeratorValue : notnull
		{
			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			[Token(Token = "0x17000072")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x6000276")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Token(Token = "0x17000073")]
			public object Key
			{
				[Token(Token = "0x6000277")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public object? Value
			{
				[Token(Token = "0x6000278")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			public object Current
			{
				[Token(Token = "0x6000279")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000275")]
			public DictionaryEnumerator(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
			}

			[Token(Token = "0x600027A")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600027B")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IDictionary? _dictionary;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TKey, TValue>? _genericDictionary;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IReadOnlyDictionary<TKey, TValue>? _readOnlyDictionary;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object? _syncRoot;

		[Token(Token = "0x17000066")]
		internal IDictionary<TKey, TValue> GenericDictionary
		{
			[Token(Token = "0x6000257")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x600025A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x600025D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x600025E")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x600025F")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public int Count
		{
			[Token(Token = "0x6000264")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006B")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000265")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		private object? System.Collections.IDictionary.Item
		{
			[Token(Token = "0x600026A")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026B")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[Token(Token = "0x600026E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private ICollection System.Collections.IDictionary.Values
		{
			[Token(Token = "0x6000270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x6000272")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x6000273")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public object UnderlyingDictionary
		{
			[Token(Token = "0x6000274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000258")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6000259")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		public bool TryGetValue(TKey key, out TValue? value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[Token(Token = "0x6000261")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000262")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000266")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		private void System.Collections.IDictionary.Add(object key, object? value)
		{
		}

		[Token(Token = "0x600026C")]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		public void Remove(object key)
		{
		}

		[Token(Token = "0x6000271")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}
	}
	[Token(Token = "0x2000052")]
	internal class DynamicProxy<T> where T : notnull
	{
		[Token(Token = "0x600027F")]
		public virtual IEnumerable<string> GetDynamicMemberNames(T instance)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, out object? result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		public virtual bool TryConvert(T instance, ConvertBinder binder, out object? result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, out object? result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, out object? result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		public virtual bool TryGetMember(T instance, GetMemberBinder binder, out object? result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, out object? result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, out object? result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600028A")]
		public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, out object? result)
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		public DynamicProxy()
		{
		}
	}
	[Token(Token = "0x2000053")]
	internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject where T : notnull
	{
		[Token(Token = "0x2000054")]
		private delegate DynamicMetaObject Fallback(DynamicMetaObject? errorSuggestion);

		[Token(Token = "0x2000055")]
		private sealed class GetBinderAdapter : GetMemberBinder
		{
			[Token(Token = "0x60002A8")]
			internal GetBinderAdapter(InvokeMemberBinder binder)
			{
			}

			[Token(Token = "0x60002A9")]
			public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject? errorSuggestion)
			{
				return null;
			}
		}

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly DynamicProxy<T> _proxy;

		[Token(Token = "0x17000076")]
		private static Expression[] NoArgs
		{
			[Token(Token = "0x600029B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028D")]
		internal DynamicProxyMetaObject(Expression expression, T value, DynamicProxy<T> proxy)
		{
		}

		[Token(Token = "0x600028E")]
		private bool IsOverridden(string method)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		public override DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		private static IEnumerable<Expression> GetArgs(params DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		private static Expression[] GetArgArray(DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		private static ConstantExpression Constant(DynamicMetaObjectBinder binder)
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, Fallback fallback, [Optional] Fallback? fallbackInvoke)
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, Fallback? fallbackInvoke)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, Fallback fallback)
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Fallback fallback)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		private BindingRestrictions GetRestrictions()
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	internal static class DynamicUtils
	{
		[Token(Token = "0x2000064")]
		internal static class BinderWrapper
		{
			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static object? _getCSharpArgumentInfoArray;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static object? _setCSharpArgumentInfoArray;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static MethodCall<object?, object?>? _getMemberCall;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static MethodCall<object?, object?>? _setMemberCall;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static bool _init;

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x26BBF30", Offset = "0x26B7F30", VA = "0x26BBF30")]
			private static void Init()
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x26BC104", Offset = "0x26B8104", VA = "0x26BC104")]
			private static object CreateSharpArgumentInfoArray(params int[] values)
			{
				return null;
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x26BC3DC", Offset = "0x26B83DC", VA = "0x26BC3DC")]
			private static void CreateMemberCalls()
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x26BC8B4", Offset = "0x26B88B4", VA = "0x26BC8B4")]
			public static CallSiteBinder GetMember(string name, Type context)
			{
				return null;
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x26BCA88", Offset = "0x26B8A88", VA = "0x26BCA88")]
			public static CallSiteBinder SetMember(string name, Type context)
			{
				return null;
			}
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x26BBE48", Offset = "0x26B7E48", VA = "0x26BBE48")]
		public static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider dynamicProvider)
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	internal class NoThrowGetBinderMember : GetMemberBinder
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly GetMemberBinder _innerBinder;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x26BCC5C", Offset = "0x26B8C5C", VA = "0x26BCC5C")]
		public NoThrowGetBinderMember(GetMemberBinder innerBinder)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x26BCC94", Offset = "0x26B8C94", VA = "0x26BCC94", Slot = "9")]
		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject? errorSuggestion)
		{
			return null;
		}
	}
	[Token(Token = "0x2000066")]
	internal class NoThrowSetBinderMember : SetMemberBinder
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly SetMemberBinder _innerBinder;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x26BCDEC", Offset = "0x26B8DEC", VA = "0x26BCDEC")]
		public NoThrowSetBinderMember(SetMemberBinder innerBinder)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x26BCE24", Offset = "0x26B8E24", VA = "0x26BCE24", Slot = "9")]
		public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject? errorSuggestion)
		{
			return null;
		}
	}
	[Token(Token = "0x2000067")]
	internal class NoThrowExpressionVisitor : ExpressionVisitor
	{
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly object ErrorResult;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x26BCF6C", Offset = "0x26B8F6C", VA = "0x26BCF6C", Slot = "7")]
		protected override Expression VisitConditional(ConditionalExpression node)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x26BCDE4", Offset = "0x26B8DE4", VA = "0x26BCDE4")]
		public NoThrowExpressionVisitor()
		{
		}
	}
	[Token(Token = "0x2000068")]
	internal class EnumInfo
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool IsFlags;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong[] Values;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string[] Names;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string[] ResolvedNames;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x26BD0C8", Offset = "0x26B90C8", VA = "0x26BD0C8")]
		public EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames)
		{
		}
	}
	[Token(Token = "0x2000069")]
	internal static class EnumUtils
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<StructMultiKey<Type, NamingStrategy?>, EnumInfo> ValuesAndNamesPerEnum;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static CamelCaseNamingStrategy _camelCaseNamingStrategy;

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x26BD10C", Offset = "0x26B910C", VA = "0x26BD10C")]
		private static EnumInfo InitializeValuesAndNames(StructMultiKey<Type, NamingStrategy?> key)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x26BD95C", Offset = "0x26B995C", VA = "0x26BD95C")]
		public static bool TryToString(Type enumType, object value, NamingStrategy? namingStrategy, [NotNullWhen(true)] out string? name)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x26BDAD8", Offset = "0x26B9AD8", VA = "0x26BDAD8")]
		private static string InternalFlagsFormat(EnumInfo entry, ulong result)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x26BDC7C", Offset = "0x26B9C7C", VA = "0x26BDC7C")]
		public static EnumInfo GetEnumValuesAndNames(Type enumType)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x26BD5F0", Offset = "0x26B95F0", VA = "0x26BD5F0")]
		private static ulong ToUInt64(object value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x26BDD38", Offset = "0x26B9D38", VA = "0x26BDD38")]
		public static object ParseEnum(Type enumType, NamingStrategy? namingStrategy, string value, bool disallowNumber)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x26BE5DC", Offset = "0x26BA5DC", VA = "0x26BE5DC")]
		private static int? MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x26BE4E8", Offset = "0x26BA4E8", VA = "0x26BE4E8")]
		private static int? FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison)
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	internal class FSharpFunction
	{
		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object? _instance;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly MethodCall<object?, object> _invoker;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x26BE850", Offset = "0x26BA850", VA = "0x26BE850")]
		public FSharpFunction(object? instance, MethodCall<object?, object> invoker)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x26BE87C", Offset = "0x26BA87C", VA = "0x26BE87C")]
		public object Invoke(params object[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	internal class FSharpUtils
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object Lock;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FSharpUtils? _instance;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MethodInfo _ofSeq;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Type _mapType;

		[Token(Token = "0x17000077")]
		public static FSharpUtils Instance
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x26BEFD4", Offset = "0x26BAFD4", VA = "0x26BEFD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private Assembly FSharpCoreAssembly
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x26BF02C", Offset = "0x26BB02C", VA = "0x26BF02C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public MethodCall<object?, object> IsUnion
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x26BF034", Offset = "0x26BB034", VA = "0x26BF034")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x26BF03C", Offset = "0x26BB03C", VA = "0x26BF03C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public MethodCall<object?, object> GetUnionCases
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x26BF044", Offset = "0x26BB044", VA = "0x26BF044")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x26BF04C", Offset = "0x26BB04C", VA = "0x26BF04C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public MethodCall<object?, object> PreComputeUnionTagReader
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x26BF054", Offset = "0x26BB054", VA = "0x26BF054")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x26BF05C", Offset = "0x26BB05C", VA = "0x26BF05C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public MethodCall<object?, object> PreComputeUnionReader
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x26BF064", Offset = "0x26BB064", VA = "0x26BF064")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x26BF06C", Offset = "0x26BB06C", VA = "0x26BF06C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public MethodCall<object?, object> PreComputeUnionConstructor
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x26BF074", Offset = "0x26BB074", VA = "0x26BF074")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x26BF07C", Offset = "0x26BB07C", VA = "0x26BF07C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public Func<object, object> GetUnionCaseInfoDeclaringType
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x26BF084", Offset = "0x26BB084", VA = "0x26BF084")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x26BF08C", Offset = "0x26BB08C", VA = "0x26BF08C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public Func<object, object> GetUnionCaseInfoName
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x26BF094", Offset = "0x26BB094", VA = "0x26BF094")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x26BF09C", Offset = "0x26BB09C", VA = "0x26BF09C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public Func<object, object> GetUnionCaseInfoTag
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x26BF0A4", Offset = "0x26BB0A4", VA = "0x26BF0A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x26BF0AC", Offset = "0x26BB0AC", VA = "0x26BF0AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public MethodCall<object, object?> GetUnionCaseInfoFields
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x26BF0B4", Offset = "0x26BB0B4", VA = "0x26BF0B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x26BF0BC", Offset = "0x26BB0BC", VA = "0x26BF0BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x26BE8A8", Offset = "0x26BA8A8", VA = "0x26BE8A8")]
		private FSharpUtils(Assembly fsharpCoreAssembly)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x26BF0C4", Offset = "0x26BB0C4", VA = "0x26BF0C4")]
		public static void EnsureInitialized(Assembly fsharpCoreAssembly)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x26BED78", Offset = "0x26BAD78", VA = "0x26BED78")]
		private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x26BEDEC", Offset = "0x26BADEC", VA = "0x26BEDEC")]
		private static MethodCall<object, object> CreateFSharpFuncCall(Type type, string methodName)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x26BF234", Offset = "0x26BB234", VA = "0x26BF234")]
		public ObjectConstructor<object> CreateSeq(Type t)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x26BF330", Offset = "0x26BB330", VA = "0x26BF330")]
		public ObjectConstructor<object> CreateMap(Type keyType, Type valueType)
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		public ObjectConstructor<object?>? BuildMapCreator<TKey, TValue>()
		{
			return null;
		}
	}
	[Token(Token = "0x2000070")]
	internal static class ImmutableCollectionsUtils
	{
		[Token(Token = "0x2000071")]
		internal class ImmutableCollectionTypeInfo
		{
			[Token(Token = "0x17000082")]
			public string ContractTypeName
			{
				[Token(Token = "0x6000309")]
				[Address(RVA = "0x26C082C", Offset = "0x26BC82C", VA = "0x26C082C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600030A")]
				[Address(RVA = "0x26C0834", Offset = "0x26BC834", VA = "0x26C0834")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public string CreatedTypeName
			{
				[Token(Token = "0x600030B")]
				[Address(RVA = "0x26C083C", Offset = "0x26BC83C", VA = "0x26C083C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600030C")]
				[Address(RVA = "0x26C0844", Offset = "0x26BC844", VA = "0x26C0844")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public string BuilderTypeName
			{
				[Token(Token = "0x600030D")]
				[Address(RVA = "0x26C084C", Offset = "0x26BC84C", VA = "0x26C084C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600030E")]
				[Address(RVA = "0x26C0854", Offset = "0x26BC854", VA = "0x26C0854")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x26C07F0", Offset = "0x26BC7F0", VA = "0x26C07F0")]
			public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName)
			{
			}
		}

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IList<ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly IList<ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions;

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x26BF5E4", Offset = "0x26BB5E4", VA = "0x26BF5E4")]
		internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, [NotNullWhen(true)] out Type? createdType, [NotNullWhen(true)] out ObjectConstructor<object>? parameterizedCreator)
		{
			return default(bool);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x26BFA78", Offset = "0x26BBA78", VA = "0x26BFA78")]
		internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, [NotNullWhen(true)] out Type? createdType, [NotNullWhen(true)] out ObjectConstructor<object>? parameterizedCreator)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000075")]
	internal static class BufferUtils
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x26C0AF0", Offset = "0x26BCAF0", VA = "0x26C0AF0")]
		public static char[] RentBuffer(IArrayPool<char>? bufferPool, int minSize)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x26C0BB8", Offset = "0x26BCBB8", VA = "0x26C0BB8")]
		public static void ReturnBuffer(IArrayPool<char>? bufferPool, char[]? buffer)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x26C0C68", Offset = "0x26BCC68", VA = "0x26C0C68")]
		public static char[]? EnsureBufferSize(IArrayPool<char>? bufferPool, int size, char[]? buffer)
		{
			return null;
		}
	}
	[Token(Token = "0x2000076")]
	internal static class JavaScriptUtils
	{
		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly bool[] SingleQuoteCharEscapeFlags;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly bool[] DoubleQuoteCharEscapeFlags;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly bool[] HtmlCharEscapeFlags;

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x26C0DA4", Offset = "0x26BCDA4", VA = "0x26C0DA4")]
		static JavaScriptUtils()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x26C1948", Offset = "0x26BD948", VA = "0x26C1948")]
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x26C19F4", Offset = "0x26BD9F4", VA = "0x26C19F4")]
		public static bool ShouldEscapeJavaScriptString(string? s, bool[] charEscapeFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x26C1A7C", Offset = "0x26BDA7C", VA = "0x26C1A7C")]
		public static void WriteEscapedJavaScriptString(TextWriter writer, string? s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char>? bufferPool, ref char[]? writeBuffer)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x26C21E0", Offset = "0x26BE1E0", VA = "0x26C21E0")]
		public static string ToEscapedJavaScriptString(string? value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x26C206C", Offset = "0x26BE06C", VA = "0x26C206C")]
		private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling)
		{
			return default(int);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x26C2478", Offset = "0x26BE478", VA = "0x26C2478")]
		public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, [NotNullWhen(false)] out string? errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x26C28CC", Offset = "0x26BE8CC", VA = "0x26C28CC")]
		private static bool TryGetDateConstructorValue(JsonReader reader, out long? integer, [NotNullWhen(false)] out string? errorMessage)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000077")]
	internal static class JsonTokenUtils
	{
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x26C2A74", Offset = "0x26BEA74", VA = "0x26C2A74")]
		internal static bool IsEndToken(JsonToken token)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x26C2A84", Offset = "0x26BEA84", VA = "0x26C2A84")]
		internal static bool IsStartToken(JsonToken token)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x26C2A94", Offset = "0x26BEA94", VA = "0x26C2A94")]
		internal static bool IsPrimitiveToken(JsonToken token)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000078")]
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly LateBoundReflectionDelegateFactory _instance;

		[Token(Token = "0x17000085")]
		internal static ReflectionDelegateFactory Instance
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x26C2AAC", Offset = "0x26BEAAC", VA = "0x26C2AAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x26C2B04", Offset = "0x26BEB04", VA = "0x26C2B04", Slot = "5")]
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method)
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method)
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		public override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x26C2C3C", Offset = "0x26BEC3C", VA = "0x26C2C3C")]
		public LateBoundReflectionDelegateFactory()
		{
		}
	}
	[Token(Token = "0x2000080")]
	internal static class MathUtils
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x26C2CE0", Offset = "0x26BECE0", VA = "0x26C2CE0")]
		public static int IntLength(ulong i)
		{
			return default(int);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x26C2EA4", Offset = "0x26BEEA4", VA = "0x26C2EA4")]
		public static char IntToHex(int n)
		{
			return default(char);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x26C2EBC", Offset = "0x26BEEBC", VA = "0x26C2EBC")]
		public static bool ApproxEquals(double d1, double d2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000081")]
	internal delegate TResult MethodCall<T, TResult>(T target, params object?[] args);
	[Token(Token = "0x2000082")]
	internal static class MiscellaneousUtils
	{
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x26C2F58", Offset = "0x26BEF58", VA = "0x26C2F58")]
		public static bool ValueEquals(object? objA, object? objB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x26B8BF4", Offset = "0x26B4BF4", VA = "0x26B8BF4")]
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x26C32A8", Offset = "0x26BF2A8", VA = "0x26C32A8")]
		public static string ToString(object? value)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x26C3358", Offset = "0x26BF358", VA = "0x26C3358")]
		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			return default(int);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x26C3408", Offset = "0x26BF408", VA = "0x26C3408")]
		public static string GetPrefix(string qualifiedName)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x26C34BC", Offset = "0x26BF4BC", VA = "0x26C34BC")]
		public static string GetLocalName(string qualifiedName)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x26C3428", Offset = "0x26BF428", VA = "0x26C3428")]
		public static void GetQualifiedNameParts(string qualifiedName, out string? prefix, out string localName)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x26C34F0", Offset = "0x26BF4F0", VA = "0x26C34F0")]
		internal static RegexOptions GetRegexOptions(string optionsText)
		{
			return default(RegexOptions);
		}
	}
	[Token(Token = "0x2000083")]
	internal abstract class ReflectionDelegateFactory
	{
		[Token(Token = "0x600034D")]
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo) where T : notnull
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo) where T : notnull
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method) where T : notnull;

		[Token(Token = "0x6000350")]
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

		[Token(Token = "0x6000351")]
		public abstract Func<T> CreateDefaultConstructor<T>(Type type) where T : notnull;

		[Token(Token = "0x6000352")]
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) where T : notnull;

		[Token(Token = "0x6000353")]
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo) where T : notnull;

		[Token(Token = "0x6000354")]
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo) where T : notnull;

		[Token(Token = "0x6000355")]
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) where T : notnull;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x26C2C44", Offset = "0x26BEC44", VA = "0x26C2C44")]
		protected ReflectionDelegateFactory()
		{
		}
	}
	[Token(Token = "0x2000084")]
	internal class ReflectionMember
	{
		[Token(Token = "0x17000086")]
		public Type? MemberType
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x26C3598", Offset = "0x26BF598", VA = "0x26C3598")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x26C35A0", Offset = "0x26BF5A0", VA = "0x26C35A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public Func<object, object?>? Getter
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x26C35A8", Offset = "0x26BF5A8", VA = "0x26C35A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x26C35B0", Offset = "0x26BF5B0", VA = "0x26C35B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Action<object, object?>? Setter
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x26C35B8", Offset = "0x26BF5B8", VA = "0x26C35B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x26C35C0", Offset = "0x26BF5C0", VA = "0x26C35C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x26C35C8", Offset = "0x26BF5C8", VA = "0x26C35C8")]
		public ReflectionMember()
		{
		}
	}
	[Token(Token = "0x2000085")]
	internal class ReflectionObject
	{
		[Token(Token = "0x17000089")]
		public ObjectConstructor<object>? Creator
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x26C35D0", Offset = "0x26BF5D0", VA = "0x26C35D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public IDictionary<string, ReflectionMember> Members
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x26C35D8", Offset = "0x26BF5D8", VA = "0x26C35D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x26C35E0", Offset = "0x26BF5E0", VA = "0x26C35E0")]
		private ReflectionObject(ObjectConstructor<object>? creator)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x26C3664", Offset = "0x26BF664", VA = "0x26C3664")]
		public object GetValue(object target, string member)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x26C3738", Offset = "0x26BF738", VA = "0x26C3738")]
		public void SetValue(object target, string member, object? value)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x26C3814", Offset = "0x26BF814", VA = "0x26C3814")]
		public Type GetType(string member)
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x26C38C8", Offset = "0x26BF8C8", VA = "0x26C38C8")]
		public static ReflectionObject Create(Type t, params string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x26C38D4", Offset = "0x26BF8D4", VA = "0x26C38D4")]
		public static ReflectionObject Create(Type t, MethodBase? creator, params string[] memberNames)
		{
			return null;
		}
	}
	[Token(Token = "0x2000089")]
	internal static class ReflectionUtils
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Type[] EmptyTypes;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x26C48A8", Offset = "0x26C08A8", VA = "0x26C48A8")]
		static ReflectionUtils()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x26C4920", Offset = "0x26C0920", VA = "0x26C4920")]
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x26C4A00", Offset = "0x26C0A00", VA = "0x26C4A00")]
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x26C4AC0", Offset = "0x26C0AC0", VA = "0x26C4AC0")]
		public static bool IsPublic(PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x26B5E60", Offset = "0x26B1E60", VA = "0x26B5E60")]
		public static Type? GetObjectType(object? v)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x26C4B50", Offset = "0x26C0B50", VA = "0x26C4B50")]
		public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder? binder)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x26C4C28", Offset = "0x26C0C28", VA = "0x26C4C28")]
		private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder? binder)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x26C4D60", Offset = "0x26C0D60", VA = "0x26C4D60")]
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x26C40FC", Offset = "0x26C00FC", VA = "0x26C40FC")]
		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x26C5008", Offset = "0x26C1008", VA = "0x26C5008")]
		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x26C4EDC", Offset = "0x26C0EDC", VA = "0x26C4EDC")]
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x26B59EC", Offset = "0x26B19EC", VA = "0x26B59EC")]
		public static bool IsNullable(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x26B3CA0", Offset = "0x26AFCA0", VA = "0x26B3CA0")]
		public static bool IsNullableType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x26C5060", Offset = "0x26C1060", VA = "0x26C5060")]
		public static Type EnsureNotNullableType(Type t)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x26C50D4", Offset = "0x26C10D4", VA = "0x26C50D4")]
		public static Type EnsureNotByRefType(Type t)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x26C5124", Offset = "0x26C1124", VA = "0x26C5124")]
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x26B2BC0", Offset = "0x26AEBC0", VA = "0x26B2BC0")]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x26C51D0", Offset = "0x26C11D0", VA = "0x26C51D0")]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, [NotNullWhen(true)] out Type? implementingType)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x26C543C", Offset = "0x26C143C", VA = "0x26C543C")]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x26C54AC", Offset = "0x26C14AC", VA = "0x26C54AC")]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type? implementingType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x26C5614", Offset = "0x26C1614", VA = "0x26C5614")]
		private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, out Type? implementingType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x26C5734", Offset = "0x26C1734", VA = "0x26C5734")]
		public static Type GetCollectionItemType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x26C595C", Offset = "0x26C195C", VA = "0x26C595C")]
		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type? keyType, out Type? valueType)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x26C44E8", Offset = "0x26C04E8", VA = "0x26C44E8")]
		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x26C5B80", Offset = "0x26C1B80", VA = "0x26C5B80")]
		public static bool IsByRefLikeType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x26C60B0", Offset = "0x26C20B0", VA = "0x26C60B0")]
		public static bool IsIndexedProperty(PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x26C6128", Offset = "0x26C2128", VA = "0x26C6128")]
		public static object GetMemberValue(MemberInfo member, object target)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x26C6434", Offset = "0x26C2434", VA = "0x26C6434")]
		public static void SetMemberValue(MemberInfo member, object target, object? value)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x26C4208", Offset = "0x26C0208", VA = "0x26C4208")]
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x26C4354", Offset = "0x26C0354", VA = "0x26C4354")]
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x26C6644", Offset = "0x26C2644", VA = "0x26C6644")]
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x26C7458", Offset = "0x26C3458", VA = "0x26C7458")]
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			return default(bool);
		}

		[Token(Token = "0x600038C")]
		public static T GetAttribute<T>(object attributeProvider) where T : notnull, Attribute
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		public static T GetAttribute<T>(object attributeProvider, bool inherit) where T : notnull, Attribute
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : notnull, Attribute
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x26C5C90", Offset = "0x26C1C90", VA = "0x26C5C90")]
		public static Attribute[] GetAttributes(object attributeProvider, Type? attributeType, bool inherit)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x26C7630", Offset = "0x26C3630", VA = "0x26C7630")]
		public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName)
		{
			return default(StructMultiKey<string, string>);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x26C7724", Offset = "0x26C3724", VA = "0x26C7724")]
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x26C79AC", Offset = "0x26C39AC", VA = "0x26C79AC")]
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x26C7038", Offset = "0x26C3038", VA = "0x26C7038")]
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x26C7C10", Offset = "0x26C3C10", VA = "0x26C7C10")]
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type type, BindingFlags bindingAttr)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x26C7150", Offset = "0x26C3150", VA = "0x26C7150")]
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x26C7DF8", Offset = "0x26C3DF8", VA = "0x26C7DF8")]
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			return default(BindingFlags);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x26C7E08", Offset = "0x26C3E08", VA = "0x26C7E08")]
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x26C8360", Offset = "0x26C4360", VA = "0x26C8360")]
		public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			return default(bool);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x26C8460", Offset = "0x26C4460", VA = "0x26C8460")]
		public static object GetDefaultValue(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200008F")]
	internal struct StringBuffer
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private char[]? _buffer;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int _position;

		[Token(Token = "0x1700008B")]
		public int Position
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x26C8BF0", Offset = "0x26C4BF0", VA = "0x26C8BF0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x26C8BF8", Offset = "0x26C4BF8", VA = "0x26C8BF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public bool IsEmpty
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x26C8C00", Offset = "0x26C4C00", VA = "0x26C8C00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		public char[]? InternalBuffer
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x26C8E00", Offset = "0x26C4E00", VA = "0x26C8E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x26C8C10", Offset = "0x26C4C10", VA = "0x26C8C10")]
		public StringBuffer(IArrayPool<char>? bufferPool, int initalSize)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x26C8C34", Offset = "0x26C4C34", VA = "0x26C8C34")]
		private StringBuffer(char[] buffer)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x26C8C40", Offset = "0x26C4C40", VA = "0x26C8C40")]
		public void Append(IArrayPool<char>? bufferPool, char value)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x26C8D1C", Offset = "0x26C4D1C", VA = "0x26C8D1C")]
		public void Append(IArrayPool<char>? bufferPool, char[] buffer, int startIndex, int count)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x26C8D9C", Offset = "0x26C4D9C", VA = "0x26C8D9C")]
		public void Clear(IArrayPool<char>? bufferPool)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x26C8CB8", Offset = "0x26C4CB8", VA = "0x26C8CB8")]
		private void EnsureSize(IArrayPool<char>? bufferPool, int appendLength)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x26C8DC8", Offset = "0x26C4DC8", VA = "0x26C8DC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x26C8DE4", Offset = "0x26C4DE4", VA = "0x26C8DE4")]
		public string ToString(int start, int length)
		{
			return null;
		}
	}
	[Token(Token = "0x2000090")]
	internal readonly struct StringReference
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly char[] _chars;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly int _startIndex;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly int _length;

		[Token(Token = "0x1700008E")]
		public char this[int i]
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x26B9E50", Offset = "0x26B5E50", VA = "0x26B9E50")]
			get
			{
				return default(char);
			}
		}

		[Token(Token = "0x1700008F")]
		public char[] Chars
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x26C8E08", Offset = "0x26C4E08", VA = "0x26C8E08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public int StartIndex
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x26C8E10", Offset = "0x26C4E10", VA = "0x26C8E10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000091")]
		public int Length
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x26C8E18", Offset = "0x26C4E18", VA = "0x26C8E18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x26BA544", Offset = "0x26B6544", VA = "0x26BA544")]
		public StringReference(char[] chars, int startIndex, int length)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x26BA180", Offset = "0x26B6180", VA = "0x26BA180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000091")]
	internal static class StringReferenceExtensions
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x26BADA4", Offset = "0x26B6DA4", VA = "0x26BADA4")]
		public static int IndexOf(this StringReference s, char c, int startIndex, int length)
		{
			return default(int);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x26B9E80", Offset = "0x26B5E80", VA = "0x26B9E80")]
		public static bool StartsWith(this StringReference s, string text)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x26B9F44", Offset = "0x26B5F44", VA = "0x26B9F44")]
		public static bool EndsWith(this StringReference s, string text)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000092")]
	internal static class StringUtils
	{
		[Token(Token = "0x2000093")]
		private enum SeparatedCaseState
		{
			[Token(Token = "0x4000249")]
			Start,
			[Token(Token = "0x400024A")]
			Lower,
			[Token(Token = "0x400024B")]
			Upper,
			[Token(Token = "0x400024C")]
			NewWord
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x26BA178", Offset = "0x26B6178", VA = "0x26BA178")]
		public static bool IsNullOrEmpty([NotNullWhen(false)] string? value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x26B454C", Offset = "0x26B054C", VA = "0x26B454C")]
		public static string FormatWith(this string format, IFormatProvider provider, object? arg0)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x26B5774", Offset = "0x26B1774", VA = "0x26B5774")]
		public static string FormatWith(this string format, IFormatProvider provider, object? arg0, object? arg1)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x26C8E8C", Offset = "0x26C4E8C", VA = "0x26C8E8C")]
		public static string FormatWith(this string format, IFormatProvider provider, object? arg0, object? arg1, object? arg2)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x26C8F94", Offset = "0x26C4F94", VA = "0x26C8F94")]
		public static string? FormatWith(this string format, IFormatProvider provider, object? arg0, object? arg1, object? arg2, object? arg3)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x26C8E20", Offset = "0x26C4E20", VA = "0x26C8E20")]
		private static string FormatWith(this string format, IFormatProvider provider, params object?[] args)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x26C23B0", Offset = "0x26BE3B0", VA = "0x26C23B0")]
		public static StringWriter CreateStringWriter(int capacity)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x26C2128", Offset = "0x26BE128", VA = "0x26C2128")]
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
		}

		[Token(Token = "0x60003C6")]
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) where TSource : notnull
		{
			return (TSource)null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x26C90D0", Offset = "0x26C50D0", VA = "0x26C90D0")]
		public static string ToCamelCase(string s)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x26C92B8", Offset = "0x26C52B8", VA = "0x26C92B8")]
		private static char ToLower(char c)
		{
			return default(char);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x26C9348", Offset = "0x26C5348", VA = "0x26C9348")]
		public static string ToSnakeCase(string s)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x26C9638", Offset = "0x26C5638", VA = "0x26C9638")]
		public static string ToKebabCase(string s)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x26C9350", Offset = "0x26C5350", VA = "0x26C9350")]
		private static string ToSeparatedCase(string s, char separator)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x26C9640", Offset = "0x26C5640", VA = "0x26C9640")]
		public static bool IsHighSurrogate(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x26C9698", Offset = "0x26C5698", VA = "0x26C9698")]
		public static bool IsLowSurrogate(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x26C34DC", Offset = "0x26BF4DC", VA = "0x26C34DC")]
		public static int IndexOf(string s, char c)
		{
			return default(int);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x26C96F0", Offset = "0x26C56F0", VA = "0x26C96F0")]
		public static bool StartsWith(this string source, char value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x26C9734", Offset = "0x26C5734", VA = "0x26C9734")]
		public static bool EndsWith(this string source, char value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x26C77F8", Offset = "0x26C37F8", VA = "0x26C77F8")]
		public static string Trim(this string s, int start, int length)
		{
			return null;
		}
	}
	[Token(Token = "0x2000095")]
	internal readonly struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>> where T1 : notnull where T2 : notnull
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly T1 Value1;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly T2 Value2;

		[Token(Token = "0x60003D5")]
		public StructMultiKey(T1 v1, T2 v2)
		{
		}

		[Token(Token = "0x60003D6")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003D7")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		public bool Equals(StructMultiKey<T1, T2> other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000096")]
	internal class ThreadSafeStore<TKey, TValue> where TKey : notnull where TValue : notnull
	{
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Func<TKey, TValue> _creator;

		[Token(Token = "0x60003D9")]
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
		}

		[Token(Token = "0x60003DA")]
		public TValue Get(TKey key)
		{
			return (TValue)null;
		}
	}
	[Token(Token = "0x2000097")]
	internal static class TypeExtensions
	{
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x26C41F0", Offset = "0x26C01F0", VA = "0x26C41F0")]
		public static MemberTypes MemberType(this MemberInfo memberInfo)
		{
			return default(MemberTypes);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x26C9774", Offset = "0x26C5774", VA = "0x26C9774")]
		public static bool ContainsGenericParameters(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x26B5C90", Offset = "0x26B1C90", VA = "0x26B5C90")]
		public static bool IsInterface(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x26BFA38", Offset = "0x26BBA38", VA = "0x26BFA38")]
		public static bool IsGenericType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x26B5CA4", Offset = "0x26B1CA4", VA = "0x26B5CA4")]
		public static bool IsGenericTypeDefinition(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x26C5718", Offset = "0x26C1718", VA = "0x26C5718")]
		public static Type BaseType(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x26BFA5C", Offset = "0x26BBA5C", VA = "0x26BFA5C")]
		public static Assembly Assembly(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x26B3C84", Offset = "0x26AFC84", VA = "0x26B3C84")]
		public static bool IsEnum(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x26C5600", Offset = "0x26C1600", VA = "0x26C5600")]
		public static bool IsClass(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x26C9790", Offset = "0x26C5790", VA = "0x26C9790")]
		public static bool IsSealed(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x26B5CC0", Offset = "0x26B1CC0", VA = "0x26B5CC0")]
		public static bool IsAbstract(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x26C97A4", Offset = "0x26C57A4", VA = "0x26C97A4")]
		public static bool IsVisible(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x26C4EC8", Offset = "0x26C0EC8", VA = "0x26C4EC8")]
		public static bool IsValueType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x26C97B8", Offset = "0x26C57B8", VA = "0x26C97B8")]
		public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces, [NotNullWhen(true)] out Type? match)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x26C9930", Offset = "0x26C5930", VA = "0x26C9930")]
		public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x26C9948", Offset = "0x26C5948", VA = "0x26C9948")]
		public static bool ImplementInterface(this Type type, Type interfaceType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000098")]
	internal static class ValidationUtils
	{
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x26B19FC", Offset = "0x26AD9FC", VA = "0x26B19FC")]
		public static void ArgumentNotNull([NotNull] object? value, string parameterName)
		{
		}
	}
}
namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000099")]
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<object, T?> TypeAttributeCache;

		[Token(Token = "0x60003EC")]
		public static T GetAttribute(object type)
		{
			return null;
		}
	}
	[Token(Token = "0x200009A")]
	public class CamelCaseNamingStrategy : NamingStrategy
	{
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x26C9D0C", Offset = "0x26C5D0C", VA = "0x26C9D0C")]
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x26C9D3C", Offset = "0x26C5D3C", VA = "0x26C9D3C")]
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x26BE7D0", Offset = "0x26BA7D0", VA = "0x26BE7D0")]
		public CamelCaseNamingStrategy()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x26C9D7C", Offset = "0x26C5D7C", VA = "0x26C9D7C", Slot = "7")]
		protected override string ResolvePropertyName(string name)
		{
			return null;
		}
	}
	[Token(Token = "0x200009B")]
	public class DefaultContractResolver : IContractResolver
	{
		[Token(Token = "0x200009C")]
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			[Token(Token = "0x200009D")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__2 : IEnumerator<KeyValuePair<object, object>>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4000261")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private int <>1__state;

				[Token(Token = "0x4000262")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private KeyValuePair<object, object> <>2__current;

				[Token(Token = "0x4000263")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this;

				[Token(Token = "0x4000264")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1;

				[Token(Token = "0x1700009A")]
				private KeyValuePair<object, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Current
				{
					[Token(Token = "0x6000434")]
					[DebuggerHidden]
					get
					{
						return default(KeyValuePair<object, object>);
					}
				}

				[Token(Token = "0x1700009B")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000436")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000430")]
				[DebuggerHidden]
				public <GetEnumerator>d__2(int <>1__state)
				{
				}

				[Token(Token = "0x6000431")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x6000432")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x6000433")]
				private void <>m__Finally1()
				{
				}

				[Token(Token = "0x6000435")]
				[DebuggerHidden]
				private void System.Collections.IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			[Token(Token = "0x600042D")]
			public EnumerableDictionaryWrapper(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
			}

			[Token(Token = "0x600042E")]
			[IteratorStateMachine(typeof(EnumerableDictionaryWrapper<, >.<GetEnumerator>d__2))]
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600042F")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IContractResolver _instance;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string[] BlacklistedTypeNames;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly JsonConverter[] BuiltInConverters;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DefaultJsonNameTable _nameTable;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ThreadSafeStore<Type, JsonContract> _contractCache;

		[Token(Token = "0x17000092")]
		internal static IContractResolver Instance
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x26C9D84", Offset = "0x26C5D84", VA = "0x26C9D84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		public BindingFlags DefaultMembersSearchFlags
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x26C9DDC", Offset = "0x26C5DDC", VA = "0x26C9DDC")]
			[CompilerGenerated]
			get
			{
				return default(BindingFlags);
			}
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x26C9DE4", Offset = "0x26C5DE4", VA = "0x26C9DE4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool SerializeCompilerGeneratedMembers
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x26C9DEC", Offset = "0x26C5DEC", VA = "0x26C9DEC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public bool IgnoreSerializableInterface
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x26C9DF4", Offset = "0x26C5DF4", VA = "0x26C9DF4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000096")]
		public bool IgnoreSerializableAttribute
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x26C9DFC", Offset = "0x26C5DFC", VA = "0x26C9DFC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x26C9E04", Offset = "0x26C5E04", VA = "0x26C9E04")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public bool IgnoreIsSpecifiedMembers
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x26C9E0C", Offset = "0x26C5E0C", VA = "0x26C9E0C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000098")]
		public bool IgnoreShouldSerializeMembers
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x26C9E14", Offset = "0x26C5E14", VA = "0x26C9E14")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		public NamingStrategy? NamingStrategy
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x26C9E1C", Offset = "0x26C5E1C", VA = "0x26C9E1C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x26C9E24", Offset = "0x26C5E24", VA = "0x26C9E24")]
		public DefaultContractResolver()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x26C9F20", Offset = "0x26C5F20", VA = "0x26C9F20", Slot = "5")]
		public virtual JsonContract ResolveContract(Type type)
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x26C9FA0", Offset = "0x26C5FA0", VA = "0x26C9FA0")]
		private static bool FilterMembers(MemberInfo member)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x26CA0E4", Offset = "0x26C60E4", VA = "0x26CA0E4", Slot = "6")]
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x26CAD84", Offset = "0x26C6D84", VA = "0x26CAD84")]
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x26CAE8C", Offset = "0x26C6E8C", VA = "0x26CAE8C", Slot = "7")]
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x26CC824", Offset = "0x26C8824", VA = "0x26CC824")]
		private static void ThrowUnableToSerializeError(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x26CBE78", Offset = "0x26C7E78", VA = "0x26CBE78")]
		private MemberInfo GetExtensionDataMemberForType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x26CC034", Offset = "0x26C8034", VA = "0x26CC034")]
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x26CB690", Offset = "0x26C7690", VA = "0x26CB690")]
		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x26CBBC4", Offset = "0x26C7BC4", VA = "0x26CBBC4")]
		private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x26CBB7C", Offset = "0x26C7B7C", VA = "0x26CBB7C")]
		private ConstructorInfo GetParameterizedConstructor(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x26CCB10", Offset = "0x26C8B10", VA = "0x26CCB10", Slot = "8")]
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x26CCA68", Offset = "0x26C8A68", VA = "0x26CCA68")]
		private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x26CCC94", Offset = "0x26C8C94", VA = "0x26CCC94", Slot = "9")]
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty? matchingMemberProperty, ParameterInfo parameterInfo)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x26CD564", Offset = "0x26C9564", VA = "0x26CD564", Slot = "10")]
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x26CD5BC", Offset = "0x26C95BC", VA = "0x26CD5BC")]
		private Func<object> GetDefaultCreator(Type createdType)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x26CB44C", Offset = "0x26C744C", VA = "0x26CB44C")]
		private void InitializeContract(JsonContract contract)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x26CD65C", Offset = "0x26C965C", VA = "0x26CD65C")]
		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x26CD7A8", Offset = "0x26C97A8", VA = "0x26CD7A8")]
		private void GetCallbackMethodsForType(Type type, out List<SerializationCallback>? onSerializing, out List<SerializationCallback>? onSerialized, out List<SerializationCallback>? onDeserializing, out List<SerializationCallback>? onDeserialized, out List<SerializationErrorCallback>? onError)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x26CE8E8", Offset = "0x26CA8E8", VA = "0x26CE8E8")]
		private static bool IsConcurrentOrObservableCollection(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x26CE1B4", Offset = "0x26CA1B4", VA = "0x26CE1B4")]
		private static bool ShouldSkipDeserialized(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x26CE0E0", Offset = "0x26CA0E0", VA = "0x26CE0E0")]
		private static bool ShouldSkipSerializing(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x26CC8B8", Offset = "0x26C88B8", VA = "0x26CC8B8")]
		private List<Type> GetClassHierarchyForType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x26CEA30", Offset = "0x26CAA30", VA = "0x26CEA30", Slot = "11")]
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x26CEF5C", Offset = "0x26CAF5C", VA = "0x26CEF5C", Slot = "12")]
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x26CF294", Offset = "0x26CB294", VA = "0x26CF294", Slot = "13")]
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x26CF308", Offset = "0x26CB308", VA = "0x26CF308", Slot = "14")]
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x26CF37C", Offset = "0x26CB37C", VA = "0x26CF37C", Slot = "15")]
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x26CF5A0", Offset = "0x26CB5A0", VA = "0x26CF5A0", Slot = "16")]
		protected virtual JsonDynamicContract CreateDynamicContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x26CF7B0", Offset = "0x26CB7B0", VA = "0x26CF7B0", Slot = "17")]
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x26CF824", Offset = "0x26CB824", VA = "0x26CF824", Slot = "18")]
		protected virtual JsonContract CreateContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x26CFC28", Offset = "0x26CBC28", VA = "0x26CFC28")]
		internal static bool IsJsonPrimitiveType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x26CFDA0", Offset = "0x26CBDA0", VA = "0x26CFDA0")]
		internal static bool IsIConvertible(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x26CFC88", Offset = "0x26CBC88", VA = "0x26CFC88")]
		internal static bool CanConvertToString(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x26CE288", Offset = "0x26CA288", VA = "0x26CE288")]
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo? currentCallback, ref Type? prevAttributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x26CFF18", Offset = "0x26CBF18", VA = "0x26CFF18")]
		internal static string GetClrTypeFullName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x26D0018", Offset = "0x26CC018", VA = "0x26D0018", Slot = "19")]
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x26D043C", Offset = "0x26CC43C", VA = "0x26D043C", Slot = "20")]
		internal virtual DefaultJsonNameTable GetNameTable()
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x26D0444", Offset = "0x26CC444", VA = "0x26D0444", Slot = "21")]
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x26D04A0", Offset = "0x26CC4A0", VA = "0x26D04A0", Slot = "22")]
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x26CCF24", Offset = "0x26C8F24", VA = "0x26CCF24")]
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x26D0684", Offset = "0x26CC684", VA = "0x26D0684")]
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x26D08E0", Offset = "0x26CC8E0", VA = "0x26D08E0")]
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x26D0BC8", Offset = "0x26CCBC8", VA = "0x26D0BC8", Slot = "23")]
		protected virtual string ResolvePropertyName(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x26D0BE8", Offset = "0x26CCBE8", VA = "0x26D0BE8", Slot = "24")]
		protected virtual string ResolveExtensionDataName(string extensionDataName)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x26D0C04", Offset = "0x26CCC04", VA = "0x26D0C04", Slot = "25")]
		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x26D0C30", Offset = "0x26CCC30", VA = "0x26D0C30")]
		public string GetResolvedPropertyName(string propertyName)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A7")]
	public class DefaultNamingStrategy : NamingStrategy
	{
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x26D1CF4", Offset = "0x26CDCF4", VA = "0x26D1CF4", Slot = "7")]
		protected override string ResolvePropertyName(string name)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x26D1CFC", Offset = "0x26CDCFC", VA = "0x26D1CFC")]
		public DefaultNamingStrategy()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	internal class DefaultReferenceResolver : IReferenceResolver
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _referenceCount;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x26D1D04", Offset = "0x26CDD04", VA = "0x26D1D04")]
		private BidirectionalDictionary<string, object> GetMappings(object context)
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x26D1F14", Offset = "0x26CDF14", VA = "0x26D1F14", Slot = "4")]
		public object ResolveReference(object context, string reference)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x26D1F88", Offset = "0x26CDF88", VA = "0x26D1F88", Slot = "5")]
		public string GetReference(object context, object value)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x26D207C", Offset = "0x26CE07C", VA = "0x26D207C", Slot = "7")]
		public void AddReference(object context, string reference, object value)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x26D20E8", Offset = "0x26CE0E8", VA = "0x26D20E8", Slot = "6")]
		public bool IsReferenced(object context, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x26D215C", Offset = "0x26CE15C", VA = "0x26D215C")]
		public DefaultReferenceResolver()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
	{
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly DefaultSerializationBinder Instance;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ThreadSafeStore<StructMultiKey<string?, string>, Type> _typeCache;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x26D2164", Offset = "0x26CE164", VA = "0x26D2164")]
		public DefaultSerializationBinder()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x26D2234", Offset = "0x26CE234", VA = "0x26D2234")]
		private Type GetTypeFromTypeNameKey(StructMultiKey<string?, string> typeNameKey)
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x26D262C", Offset = "0x26CE62C", VA = "0x26D262C")]
		private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x26D28EC", Offset = "0x26CE8EC", VA = "0x26D28EC")]
		private Type GetTypeByName(StructMultiKey<string?, string> typeNameKey)
		{
			return null;
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x26D2954", Offset = "0x26CE954", VA = "0x26D2954", Slot = "5")]
		public override Type BindToType(string? assemblyName, string typeName)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x26D29D0", Offset = "0x26CE9D0", VA = "0x26D29D0", Slot = "4")]
		public override void BindToName(Type serializedType, out string? assemblyName, out string? typeName)
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class ErrorContext
	{
		[Token(Token = "0x1700009C")]
		internal bool Traced
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x26D2AD0", Offset = "0x26CEAD0", VA = "0x26D2AD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x26D2AD8", Offset = "0x26CEAD8", VA = "0x26D2AD8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public Exception Error
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x26D2AE0", Offset = "0x26CEAE0", VA = "0x26D2AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public bool Handled
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x26D2AE8", Offset = "0x26CEAE8", VA = "0x26D2AE8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x26D2A90", Offset = "0x26CEA90", VA = "0x26D2A90")]
		internal ErrorContext(object? originalObject, object? member, string path, Exception error)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class ErrorEventArgs : EventArgs
	{
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x26D2AF0", Offset = "0x26CEAF0", VA = "0x26D2AF0")]
		public ErrorEventArgs(object? currentObject, ErrorContext errorContext)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public interface IAttributeProvider
	{
	}
	[Token(Token = "0x20000AD")]
	public interface IContractResolver
	{
		[Token(Token = "0x6000463")]
		JsonContract ResolveContract(Type type);
	}
	[Token(Token = "0x20000AE")]
	public interface IReferenceResolver
	{
		[Token(Token = "0x6000464")]
		object ResolveReference(object context, string reference);

		[Token(Token = "0x6000465")]
		string GetReference(object context, object value);

		[Token(Token = "0x6000466")]
		bool IsReferenced(object context, object value);

		[Token(Token = "0x6000467")]
		void AddReference(object context, string reference, object value);
	}
	[Token(Token = "0x20000AF")]
	public interface ISerializationBinder
	{
		[Token(Token = "0x6000468")]
		Type BindToType(string? assemblyName, string typeName);

		[Token(Token = "0x6000469")]
		void BindToName(Type serializedType, out string? assemblyName, out string? typeName);
	}
	[Token(Token = "0x20000B0")]
	public interface ITraceWriter
	{
		[Token(Token = "0x1700009F")]
		TraceLevel LevelFilter
		{
			[Token(Token = "0x600046A")]
			get;
		}

		[Token(Token = "0x600046B")]
		void Trace(TraceLevel level, string message, Exception? ex);
	}
	[Token(Token = "0x20000B1")]
	public interface IValueProvider
	{
		[Token(Token = "0x600046C")]
		void SetValue(object target, object? value);

		[Token(Token = "0x600046D")]
		object GetValue(object target);
	}
	[Token(Token = "0x20000B2")]
	public class JsonArrayContract : JsonContainerContract
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly Type? _genericCollectionDefinitionType;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Type? _genericWrapperType;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ObjectConstructor<object>? _genericWrapperCreator;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Func<object>? _genericTemporaryCollectionCreator;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly ConstructorInfo? _parameterizedConstructor;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ObjectConstructor<object>? _parameterizedCreator;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ObjectConstructor<object>? _overrideCreator;

		[Token(Token = "0x170000A0")]
		public Type? CollectionItemType
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x26D2B60", Offset = "0x26CEB60", VA = "0x26D2B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public bool IsMultidimensionalArray
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x26D2B68", Offset = "0x26CEB68", VA = "0x26D2B68")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		internal bool IsArray
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x26D2B70", Offset = "0x26CEB70", VA = "0x26D2B70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		internal bool ShouldCreateWrapper
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x26D2B78", Offset = "0x26CEB78", VA = "0x26D2B78")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		internal bool CanDeserialize
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x26D2B80", Offset = "0x26CEB80", VA = "0x26D2B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x26D2B88", Offset = "0x26CEB88", VA = "0x26D2B88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		internal ObjectConstructor<object>? ParameterizedCreator
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x26D2B90", Offset = "0x26CEB90", VA = "0x26D2B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public ObjectConstructor<object>? OverrideCreator
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x26D2C50", Offset = "0x26CEC50", VA = "0x26D2C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x26D2C58", Offset = "0x26CEC58", VA = "0x26D2C58")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool HasParameterizedCreator
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x26D2C68", Offset = "0x26CEC68", VA = "0x26D2C68")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x26D2C70", Offset = "0x26CEC70", VA = "0x26D2C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		internal bool HasParameterizedCreatorInternal
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x26D2C78", Offset = "0x26CEC78", VA = "0x26D2C78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x26D2CF8", Offset = "0x26CECF8", VA = "0x26D2CF8")]
		public JsonArrayContract(Type underlyingType)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x26D3D00", Offset = "0x26CFD00", VA = "0x26D3D00")]
		internal IWrappedCollection CreateWrapper(object list)
		{
			return null;
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x26D40C8", Offset = "0x26D00C8", VA = "0x26D40C8")]
		internal IList CreateTemporaryCollection()
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x26D3BF4", Offset = "0x26CFBF4", VA = "0x26D3BF4")]
		private void StoreFSharpListCreatorIfNecessary(Type underlyingType)
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class JsonContainerContract : JsonContract
	{
		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private JsonContract? _itemContract;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private JsonContract? _finalItemContract;

		[Token(Token = "0x170000A9")]
		internal JsonContract? ItemContract
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x26D4320", Offset = "0x26D0320", VA = "0x26D4320")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x26D4328", Offset = "0x26D0328", VA = "0x26D4328")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		internal JsonContract? FinalItemContract
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x26D4364", Offset = "0x26D0364", VA = "0x26D4364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public JsonConverter? ItemConverter
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x26D436C", Offset = "0x26D036C", VA = "0x26D436C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x26D4374", Offset = "0x26D0374", VA = "0x26D4374")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public bool? ItemIsReference
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x26D437C", Offset = "0x26D037C", VA = "0x26D437C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x26D4384", Offset = "0x26D0384", VA = "0x26D4384")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x26D438C", Offset = "0x26D038C", VA = "0x26D438C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x26D4394", Offset = "0x26D0394", VA = "0x26D4394")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public TypeNameHandling? ItemTypeNameHandling
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x26D439C", Offset = "0x26D039C", VA = "0x26D439C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x26D43A4", Offset = "0x26D03A4", VA = "0x26D43A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x26D3A40", Offset = "0x26CFA40", VA = "0x26D3A40")]
		internal JsonContainerContract(Type underlyingType)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	internal enum JsonContractType
	{
		[Token(Token = "0x4000298")]
		None,
		[Token(Token = "0x4000299")]
		Object,
		[Token(Token = "0x400029A")]
		Array,
		[Token(Token = "0x400029B")]
		Primitive,
		[Token(Token = "0x400029C")]
		String,
		[Token(Token = "0x400029D")]
		Dictionary,
		[Token(Token = "0x400029E")]
		Dynamic,
		[Token(Token = "0x400029F")]
		Serializable,
		[Token(Token = "0x40002A0")]
		Linq
	}
	[Token(Token = "0x20000B5")]
	public delegate void SerializationCallback(object o, StreamingContext context);
	[Token(Token = "0x20000B6")]
	public delegate void SerializationErrorCallback(object o, StreamingContext context, ErrorContext errorContext);
	[Token(Token = "0x20000B7")]
	public delegate void ExtensionDataSetter(object o, string key, object? value);
	[Token(Token = "0x20000B8")]
	public delegate IEnumerable<KeyValuePair<object, object>> ExtensionDataGetter(object o);
	[Token(Token = "0x20000B9")]
	public abstract class JsonContract
	{
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool IsNullable;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		internal bool IsConvertable;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		internal bool IsEnum;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Type NonNullableUnderlyingType;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal ReadType InternalReadType;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal JsonContractType ContractType;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal bool IsReadOnlyOrFixedSize;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		internal bool IsSealed;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		internal bool IsInstantiable;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<SerializationCallback>? _onDeserializedCallbacks;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<SerializationCallback>? _onDeserializingCallbacks;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<SerializationCallback>? _onSerializedCallbacks;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<SerializationCallback>? _onSerializingCallbacks;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<SerializationErrorCallback>? _onErrorCallbacks;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Type _createdType;

		[Token(Token = "0x170000AF")]
		public Type UnderlyingType
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x26D4958", Offset = "0x26D0958", VA = "0x26D4958")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public Type CreatedType
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x26D4960", Offset = "0x26D0960", VA = "0x26D4960")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x26D3B4C", Offset = "0x26CFB4C", VA = "0x26D3B4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool? IsReference
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x26D4968", Offset = "0x26D0968", VA = "0x26D4968")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x26D4970", Offset = "0x26D0970", VA = "0x26D4970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public JsonConverter? Converter
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x26D4978", Offset = "0x26D0978", VA = "0x26D4978")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x26D4980", Offset = "0x26D0980", VA = "0x26D4980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public JsonConverter? InternalConverter
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x26D4988", Offset = "0x26D0988", VA = "0x26D4988")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x26D4990", Offset = "0x26D0990", VA = "0x26D4990")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public IList<SerializationCallback> OnDeserializedCallbacks
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x26D4998", Offset = "0x26D0998", VA = "0x26D4998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public IList<SerializationCallback> OnDeserializingCallbacks
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x26D4A10", Offset = "0x26D0A10", VA = "0x26D4A10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public IList<SerializationCallback> OnSerializedCallbacks
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x26D4A88", Offset = "0x26D0A88", VA = "0x26D4A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public IList<SerializationCallback> OnSerializingCallbacks
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x26D4B00", Offset = "0x26D0B00", VA = "0x26D4B00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public IList<SerializationErrorCallback> OnErrorCallbacks
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x26D4B78", Offset = "0x26D0B78", VA = "0x26D4B78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public Func<object>? DefaultCreator
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x26D4BF0", Offset = "0x26D0BF0", VA = "0x26D4BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x26D4BF8", Offset = "0x26D0BF8", VA = "0x26D4BF8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public bool DefaultCreatorNonPublic
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x26D4C00", Offset = "0x26D0C00", VA = "0x26D4C00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x26D4C08", Offset = "0x26D0C08", VA = "0x26D4C08")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x26D43AC", Offset = "0x26D03AC", VA = "0x26D43AC")]
		internal JsonContract(Type underlyingType)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x26D4C10", Offset = "0x26D0C10", VA = "0x26D4C10")]
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x26D4D6C", Offset = "0x26D0D6C", VA = "0x26D4D6C")]
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x26D4EC8", Offset = "0x26D0EC8", VA = "0x26D4EC8")]
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x26D5024", Offset = "0x26D1024", VA = "0x26D5024")]
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x26D5180", Offset = "0x26D1180", VA = "0x26D5180")]
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x26D52E4", Offset = "0x26D12E4", VA = "0x26D52E4")]
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x26D5390", Offset = "0x26D1390", VA = "0x26D5390")]
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BC")]
	public class JsonDictionaryContract : JsonContainerContract
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly Type? _genericCollectionDefinitionType;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Type? _genericWrapperType;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ObjectConstructor<object>? _genericWrapperCreator;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Func<object>? _genericTemporaryDictionaryCreator;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly ConstructorInfo? _parameterizedConstructor;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private ObjectConstructor<object>? _overrideCreator;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private ObjectConstructor<object>? _parameterizedCreator;

		[Token(Token = "0x170000BB")]
		public Func<string, string>? DictionaryKeyResolver
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x26D5658", Offset = "0x26D1658", VA = "0x26D5658")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x26D5660", Offset = "0x26D1660", VA = "0x26D5660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public Type? DictionaryKeyType
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x26D5668", Offset = "0x26D1668", VA = "0x26D5668")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public Type? DictionaryValueType
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x26D5670", Offset = "0x26D1670", VA = "0x26D5670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		internal JsonContract? KeyContract
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x26D5678", Offset = "0x26D1678", VA = "0x26D5678")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x26D5680", Offset = "0x26D1680", VA = "0x26D5680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		internal bool ShouldCreateWrapper
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x26D5688", Offset = "0x26D1688", VA = "0x26D5688")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		internal ObjectConstructor<object>? ParameterizedCreator
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x26D5690", Offset = "0x26D1690", VA = "0x26D5690")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public ObjectConstructor<object>? OverrideCreator
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x26D5750", Offset = "0x26D1750", VA = "0x26D5750")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x26D5758", Offset = "0x26D1758", VA = "0x26D5758")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public bool HasParameterizedCreator
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x26D5760", Offset = "0x26D1760", VA = "0x26D5760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x26D5768", Offset = "0x26D1768", VA = "0x26D5768")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		internal bool HasParameterizedCreatorInternal
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x26D5770", Offset = "0x26D1770", VA = "0x26D5770")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x26D57F0", Offset = "0x26D17F0", VA = "0x26D57F0")]
		public JsonDictionaryContract(Type underlyingType)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x26D61B4", Offset = "0x26D21B4", VA = "0x26D61B4")]
		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			return null;
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x26D643C", Offset = "0x26D243C", VA = "0x26D643C")]
		internal IDictionary CreateTemporaryDictionary()
		{
			return null;
		}
	}
	[Token(Token = "0x20000BD")]
	public class JsonDynamicContract : JsonContainerContract
	{
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object?, object>>> _callSiteSetters;

		[Token(Token = "0x170000C4")]
		public JsonPropertyCollection Properties
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x26D66B0", Offset = "0x26D26B0", VA = "0x26D66B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public Func<string, string>? PropertyNameResolver
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x26D66B8", Offset = "0x26D26B8", VA = "0x26D66B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x26D66C0", Offset = "0x26D26C0", VA = "0x26D66C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x26D66C8", Offset = "0x26D26C8", VA = "0x26D66C8")]
		private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x26D67F4", Offset = "0x26D27F4", VA = "0x26D67F4")]
		private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x26D6920", Offset = "0x26D2920", VA = "0x26D6920")]
		public JsonDynamicContract(Type underlyingType)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x26D6C28", Offset = "0x26D2C28", VA = "0x26D6C28")]
		internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object? value)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x26D6D2C", Offset = "0x26D2D2C", VA = "0x26D6D2C")]
		internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object? value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BE")]
	internal class JsonFormatterConverter : IFormatterConverter
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly JsonSerializerInternalReader _reader;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly JsonISerializableContract _contract;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly JsonProperty? _member;

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x26D6E2C", Offset = "0x26D2E2C", VA = "0x26D6E2C")]
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty? member)
		{
		}

		[Token(Token = "0x60004C9")]
		private T GetTokenValue<T>(object value) where T : notnull
		{
			return (T)null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x26D6ED0", Offset = "0x26D2ED0", VA = "0x26D6ED0", Slot = "4")]
		public object Convert(object value, Type type)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x26D710C", Offset = "0x26D310C", VA = "0x26D710C", Slot = "5")]
		public bool ToBoolean(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x26D7164", Offset = "0x26D3164", VA = "0x26D7164", Slot = "6")]
		public int ToInt32(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x26D71BC", Offset = "0x26D31BC", VA = "0x26D71BC", Slot = "7")]
		public long ToInt64(object value)
		{
			return default(long);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x26D7214", Offset = "0x26D3214", VA = "0x26D7214", Slot = "8")]
		public float ToSingle(object value)
		{
			return default(float);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x26D726C", Offset = "0x26D326C", VA = "0x26D726C", Slot = "9")]
		public string ToString(object value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BF")]
	public class JsonISerializableContract : JsonContainerContract
	{
		[Token(Token = "0x170000C6")]
		public ObjectConstructor<object>? ISerializableCreator
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x26D72C4", Offset = "0x26D32C4", VA = "0x26D72C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x26D72CC", Offset = "0x26D32CC", VA = "0x26D72CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x26D72D4", Offset = "0x26D32D4", VA = "0x26D72D4")]
		public JsonISerializableContract(Type underlyingType)
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class JsonLinqContract : JsonContract
	{
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x26D72F0", Offset = "0x26D32F0", VA = "0x26D72F0")]
		public JsonLinqContract(Type underlyingType)
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class JsonObjectContract : JsonContainerContract
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal bool ExtensionDataIsJToken;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		private bool? _hasRequiredOrDefaultValueProperties;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ObjectConstructor<object>? _overrideCreator;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ObjectConstructor<object>? _parameterizedCreator;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private JsonPropertyCollection? _creatorParameters;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Type? _extensionDataValueType;

		[Token(Token = "0x170000C7")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x26D730C", Offset = "0x26D330C", VA = "0x26D730C")]
			[CompilerGenerated]
			get
			{
				return default(MemberSerialization);
			}
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x26D7314", Offset = "0x26D3314", VA = "0x26D7314")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public MissingMemberHandling? MissingMemberHandling
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x26D731C", Offset = "0x26D331C", VA = "0x26D731C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x26D7324", Offset = "0x26D3324", VA = "0x26D7324")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public Required? ItemRequired
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x26D732C", Offset = "0x26D332C", VA = "0x26D732C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x26D7334", Offset = "0x26D3334", VA = "0x26D7334")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public NullValueHandling? ItemNullValueHandling
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x26D733C", Offset = "0x26D333C", VA = "0x26D733C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x26D7344", Offset = "0x26D3344", VA = "0x26D7344")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public JsonPropertyCollection Properties
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x26D734C", Offset = "0x26D334C", VA = "0x26D734C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public JsonPropertyCollection CreatorParameters
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x26D7354", Offset = "0x26D3354", VA = "0x26D7354")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public ObjectConstructor<object>? OverrideCreator
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x26D73BC", Offset = "0x26D33BC", VA = "0x26D73BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x26D73C4", Offset = "0x26D33C4", VA = "0x26D73C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		internal ObjectConstructor<object>? ParameterizedCreator
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x26D73CC", Offset = "0x26D33CC", VA = "0x26D73CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x26D73D4", Offset = "0x26D33D4", VA = "0x26D73D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public ExtensionDataSetter? ExtensionDataSetter
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x26D73DC", Offset = "0x26D33DC", VA = "0x26D73DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x26D73E4", Offset = "0x26D33E4", VA = "0x26D73E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public ExtensionDataGetter? ExtensionDataGetter
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x26D73EC", Offset = "0x26D33EC", VA = "0x26D73EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x26D73F4", Offset = "0x26D33F4", VA = "0x26D73F4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public Type? ExtensionDataValueType
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x26D73FC", Offset = "0x26D33FC", VA = "0x26D73FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public Func<string, string>? ExtensionDataNameResolver
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x26D74D0", Offset = "0x26D34D0", VA = "0x26D74D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x26D74D8", Offset = "0x26D34D8", VA = "0x26D74D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		internal bool HasRequiredOrDefaultValueProperties
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x26D74E0", Offset = "0x26D34E0", VA = "0x26D74E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x26D78E8", Offset = "0x26D38E8", VA = "0x26D78E8")]
		public JsonObjectContract(Type underlyingType)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x26D7964", Offset = "0x26D3964", VA = "0x26D7964")]
		internal object GetUninitializedObject()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C2")]
	public class JsonPrimitiveContract : JsonContract
	{
		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, ReadType> ReadTypeMap;

		[Token(Token = "0x170000D4")]
		internal PrimitiveTypeCode TypeCode
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x26D7A68", Offset = "0x26D3A68", VA = "0x26D7A68")]
			[CompilerGenerated]
			get
			{
				return default(PrimitiveTypeCode);
			}
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x26D7A70", Offset = "0x26D3A70", VA = "0x26D7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x26D7A78", Offset = "0x26D3A78", VA = "0x26D7A78")]
		public JsonPrimitiveContract(Type underlyingType)
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class JsonProperty
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Required? _required;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal bool _hasExplicitDefaultValue;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object? _defaultValue;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _hasGeneratedDefaultValue;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string? _propertyName;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal bool _skipPropertyNameEscape;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Type? _propertyType;

		[Token(Token = "0x170000D5")]
		internal JsonContract? PropertyContract
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x26D7EC8", Offset = "0x26D3EC8", VA = "0x26D7EC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x26D7ED0", Offset = "0x26D3ED0", VA = "0x26D7ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public string? PropertyName
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x26D7ED8", Offset = "0x26D3ED8", VA = "0x26D7ED8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x26D7EE0", Offset = "0x26D3EE0", VA = "0x26D7EE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public Type? DeclaringType
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x26D7F64", Offset = "0x26D3F64", VA = "0x26D7F64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x26D7F6C", Offset = "0x26D3F6C", VA = "0x26D7F6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public int? Order
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x26D7F74", Offset = "0x26D3F74", VA = "0x26D7F74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x26D7F7C", Offset = "0x26D3F7C", VA = "0x26D7F7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public string? UnderlyingName
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x26D7F84", Offset = "0x26D3F84", VA = "0x26D7F84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x26D7F8C", Offset = "0x26D3F8C", VA = "0x26D7F8C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public IValueProvider? ValueProvider
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x26D7F94", Offset = "0x26D3F94", VA = "0x26D7F94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x26D7F9C", Offset = "0x26D3F9C", VA = "0x26D7F9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public IAttributeProvider? AttributeProvider
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x26D7FA4", Offset = "0x26D3FA4", VA = "0x26D7FA4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public Type? PropertyType
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x26D7FAC", Offset = "0x26D3FAC", VA = "0x26D7FAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x26D7FB4", Offset = "0x26D3FB4", VA = "0x26D7FB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public JsonConverter? Converter
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x26D8030", Offset = "0x26D4030", VA = "0x26D8030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x26D8038", Offset = "0x26D4038", VA = "0x26D8038")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public bool Ignored
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x26D8040", Offset = "0x26D4040", VA = "0x26D8040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x26D8048", Offset = "0x26D4048", VA = "0x26D8048")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public bool Readable
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x26D8050", Offset = "0x26D4050", VA = "0x26D8050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x26D8058", Offset = "0x26D4058", VA = "0x26D8058")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public bool Writable
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x26D8060", Offset = "0x26D4060", VA = "0x26D8060")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x26D8068", Offset = "0x26D4068", VA = "0x26D8068")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public bool HasMemberAttribute
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x26D8070", Offset = "0x26D4070", VA = "0x26D8070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x26D8078", Offset = "0x26D4078", VA = "0x26D8078")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public object? DefaultValue
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x26D8080", Offset = "0x26D4080", VA = "0x26D8080")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x26D8098", Offset = "0x26D4098", VA = "0x26D8098")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public Required Required
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x26D78AC", Offset = "0x26D38AC", VA = "0x26D78AC")]
			get
			{
				return default(Required);
			}
		}

		[Token(Token = "0x170000E4")]
		public bool? IsReference
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x26D816C", Offset = "0x26D416C", VA = "0x26D816C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x26D8174", Offset = "0x26D4174", VA = "0x26D8174")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public NullValueHandling? NullValueHandling
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x26D817C", Offset = "0x26D417C", VA = "0x26D817C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x26D8184", Offset = "0x26D4184", VA = "0x26D8184")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public DefaultValueHandling? DefaultValueHandling
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x26D818C", Offset = "0x26D418C", VA = "0x26D818C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x26D8194", Offset = "0x26D4194", VA = "0x26D8194")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public ReferenceLoopHandling? ReferenceLoopHandling
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x26D819C", Offset = "0x26D419C", VA = "0x26D819C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x26D81A4", Offset = "0x26D41A4", VA = "0x26D81A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public ObjectCreationHandling? ObjectCreationHandling
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x26D81AC", Offset = "0x26D41AC", VA = "0x26D81AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x26D81B4", Offset = "0x26D41B4", VA = "0x26D81B4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public TypeNameHandling? TypeNameHandling
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x26D81BC", Offset = "0x26D41BC", VA = "0x26D81BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x26D81C4", Offset = "0x26D41C4", VA = "0x26D81C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public Predicate<object>? ShouldSerialize
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x26D81CC", Offset = "0x26D41CC", VA = "0x26D81CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x26D81D4", Offset = "0x26D41D4", VA = "0x26D81D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public Predicate<object>? ShouldDeserialize
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x26D81DC", Offset = "0x26D41DC", VA = "0x26D81DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		public Predicate<object>? GetIsSpecified
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x26D81E4", Offset = "0x26D41E4", VA = "0x26D81E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x26D81EC", Offset = "0x26D41EC", VA = "0x26D81EC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public Action<object, object?>? SetIsSpecified
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x26D81F4", Offset = "0x26D41F4", VA = "0x26D81F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x26D81FC", Offset = "0x26D41FC", VA = "0x26D81FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public JsonConverter? ItemConverter
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x26D8258", Offset = "0x26D4258", VA = "0x26D8258")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x26D8260", Offset = "0x26D4260", VA = "0x26D8260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public bool? ItemIsReference
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x26D8268", Offset = "0x26D4268", VA = "0x26D8268")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x26D8270", Offset = "0x26D4270", VA = "0x26D8270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public TypeNameHandling? ItemTypeNameHandling
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x26D8278", Offset = "0x26D4278", VA = "0x26D8278")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x26D8280", Offset = "0x26D4280", VA = "0x26D8280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x26D8288", Offset = "0x26D4288", VA = "0x26D8288")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x26D8290", Offset = "0x26D4290", VA = "0x26D8290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x26D80A8", Offset = "0x26D40A8", VA = "0x26D80A8")]
		internal object? GetResolvedDefaultValue()
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x26D8204", Offset = "0x26D4204", VA = "0x26D8204", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x26D8298", Offset = "0x26D4298", VA = "0x26D8298")]
		internal void WritePropertyName(JsonWriter writer)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x26D82F0", Offset = "0x26D42F0", VA = "0x26D82F0")]
		public JsonProperty()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Type _type;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<JsonProperty> _list;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x26D6AC4", Offset = "0x26D2AC4", VA = "0x26D6AC4")]
		public JsonPropertyCollection(Type type)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x26D82F8", Offset = "0x26D42F8", VA = "0x26D82F8", Slot = "39")]
		protected override string GetKeyForItem(JsonProperty item)
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x26D830C", Offset = "0x26D430C", VA = "0x26D830C")]
		public void AddProperty(JsonProperty property)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x26D85C8", Offset = "0x26D45C8", VA = "0x26D85C8")]
		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x26D86F4", Offset = "0x26D46F4", VA = "0x26D86F4")]
		private bool TryGetProperty(string key, [NotNullWhen(true)] out JsonProperty? item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x26D8608", Offset = "0x26D4608", VA = "0x26D8608")]
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C5")]
	internal abstract class JsonSerializerInternalBase
	{
		[Token(Token = "0x20000C6")]
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object>
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x26D8E04", Offset = "0x26D4E04", VA = "0x26D8E04", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object? x, object? y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x26D8E10", Offset = "0x26D4E10", VA = "0x26D8E10", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x26D8858", Offset = "0x26D4858", VA = "0x26D8858")]
			public ReferenceEqualsEqualityComparer()
			{
			}
		}

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ErrorContext? _currentErrorContext;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BidirectionalDictionary<string, object>? _mappings;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal readonly JsonSerializer Serializer;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal readonly ITraceWriter? TraceWriter;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected JsonSerializerProxy? InternalSerializer;

		[Token(Token = "0x170000F2")]
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x26D1E10", Offset = "0x26CDE10", VA = "0x26D1E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x26D87D0", Offset = "0x26D47D0", VA = "0x26D87D0")]
		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x26D8860", Offset = "0x26D4860", VA = "0x26D8860")]
		protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract? containerContract, JsonProperty property)
		{
			return default(NullValueHandling);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x26D88F4", Offset = "0x26D48F4", VA = "0x26D88F4")]
		private ErrorContext GetErrorContext(object? currentObject, object? member, string path, Exception error)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x26D89D4", Offset = "0x26D49D4", VA = "0x26D89D4")]
		protected void ClearErrorContext()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x26D8A30", Offset = "0x26D4A30", VA = "0x26D8A30")]
		protected bool IsErrorHandled(object? currentObject, JsonContract? contract, object? keyValue, IJsonLineInfo? lineInfo, string path, Exception ex)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C7")]
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		[Token(Token = "0x20000C8")]
		internal enum PropertyPresence
		{
			[Token(Token = "0x4000305")]
			None,
			[Token(Token = "0x4000306")]
			Null,
			[Token(Token = "0x4000307")]
			Value
		}

		[Token(Token = "0x20000C9")]
		internal class CreatorPropertyContext
		{
			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string Name;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public JsonProperty? Property;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JsonProperty? ConstructorProperty;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropertyPresence? Presence;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object? Value;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool Used;

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x26E3ECC", Offset = "0x26DFECC", VA = "0x26E3ECC")]
			public CreatorPropertyContext(string name)
			{
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x26D8E1C", Offset = "0x26D4E1C", VA = "0x26D8E1C")]
		public JsonSerializerInternalReader(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x26D8E20", Offset = "0x26D4E20", VA = "0x26D8E20")]
		public void Populate(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x26DAD10", Offset = "0x26D6D10", VA = "0x26DAD10")]
		private JsonContract? GetContractSafe(Type? type)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x26DAD9C", Offset = "0x26D6D9C", VA = "0x26DAD9C")]
		private JsonContract GetContract(Type type)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x26DAE4C", Offset = "0x26D6E4C", VA = "0x26DAE4C")]
		public object? Deserialize(JsonReader reader, Type? objectType, bool checkAdditionalContent)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x26DBB3C", Offset = "0x26D7B3C", VA = "0x26DBB3C")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x26DBBA4", Offset = "0x26D7BA4", VA = "0x26DBBA4")]
		private JToken? CreateJToken(JsonReader reader, JsonContract? contract)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x26DBF84", Offset = "0x26D7F84", VA = "0x26DBF84")]
		private JToken CreateJObject(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x26DB600", Offset = "0x26D7600", VA = "0x26DB600")]
		private object? CreateValueInternal(JsonReader reader, Type? objectType, JsonContract? contract, JsonProperty? member, JsonContainerContract? containerContract, JsonProperty? containerMember, object? existingValue)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x26DDA80", Offset = "0x26D9A80", VA = "0x26DDA80")]
		private static bool CoerceEmptyStringToNull(Type? objectType, JsonContract? contract, string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x26DDBAC", Offset = "0x26D9BAC", VA = "0x26DDBAC")]
		internal string GetExpectedDescription(JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x26DB17C", Offset = "0x26D717C", VA = "0x26DB17C")]
		private JsonConverter? GetConverter(JsonContract? contract, JsonConverter? memberConverter, JsonContainerContract? containerContract, JsonProperty? containerProperty)
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x26DC3C8", Offset = "0x26D83C8", VA = "0x26DC3C8")]
		private object? CreateObject(JsonReader reader, Type? objectType, JsonContract? contract, JsonProperty? member, JsonContainerContract? containerContract, JsonProperty? containerMember, object? existingValue)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x26DDC64", Offset = "0x26D9C64", VA = "0x26DDC64")]
		private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type? objectType, ref JsonContract? contract, JsonProperty? member, JsonContainerContract? containerContract, JsonProperty? containerMember, object? existingValue, out object? newValue, out string? id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x26DE390", Offset = "0x26DA390", VA = "0x26DE390")]
		private bool ReadMetadataProperties(JsonReader reader, ref Type? objectType, ref JsonContract? contract, JsonProperty? member, JsonContainerContract? containerContract, JsonProperty? containerMember, object? existingValue, out object? newValue, out string? id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x26DFB18", Offset = "0x26DBB18", VA = "0x26DFB18")]
		private void ResolveTypeName(JsonReader reader, ref Type? objectType, ref JsonContract? contract, JsonProperty? member, JsonContainerContract? containerContract, JsonProperty? containerMember, string qualifiedTypeName)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x26E0110", Offset = "0x26DC110", VA = "0x26E0110")]
		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x26DCE4C", Offset = "0x26D8E4C", VA = "0x26DCE4C")]
		private object? CreateList(JsonReader reader, Type? objectType, JsonContract? contract, JsonProperty? member, object? existingValue, string? id)
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x26DE8F8", Offset = "0x26DA8F8", VA = "0x26DE8F8")]
		private bool HasNoDefinedType(JsonContract? contract)
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x26DD4BC", Offset = "0x26D94BC", VA = "0x26DD4BC")]
		private object? EnsureType(JsonReader reader, object? value, CultureInfo culture, JsonContract? contract, Type? targetType)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x26E0BF4", Offset = "0x26DCBF4", VA = "0x26E0BF4")]
		private bool SetPropertyValue(JsonProperty property, JsonConverter? propertyConverter, JsonContainerContract? containerContract, JsonProperty? containerProperty, JsonReader reader, object target)
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x26E1074", Offset = "0x26DD074", VA = "0x26E1074")]
		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter? propertyConverter, JsonContainerContract? containerContract, JsonProperty? containerProperty, JsonReader reader, object target, out bool useExistingValue, out object? currentValue, out JsonContract? propertyContract, out bool gottenCurrentValue, out bool ignoredValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x26E1694", Offset = "0x26DD694", VA = "0x26E1694")]
		private void AddReference(JsonReader reader, string id, object value)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x26E1688", Offset = "0x26DD688", VA = "0x26E1688")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x26E1598", Offset = "0x26DD598", VA = "0x26E1598")]
		private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract? contract, object? value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x26E0290", Offset = "0x26DC290", VA = "0x26E0290")]
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x26DEC20", Offset = "0x26DAC20", VA = "0x26DEC20")]
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x26E1A58", Offset = "0x26DDA58", VA = "0x26E1A58")]
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x26E1C84", Offset = "0x26DDC84", VA = "0x26E1C84")]
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x26D9898", Offset = "0x26D5898", VA = "0x26D9898")]
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty? containerProperty, string? id)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x26E0520", Offset = "0x26DC520", VA = "0x26E0520")]
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty? containerProperty, string? id)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x26E1EB0", Offset = "0x26DDEB0", VA = "0x26E1EB0")]
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object? currentObject, string message)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x26D9340", Offset = "0x26D5340", VA = "0x26D9340")]
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty? containerProperty, string? id)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x26DF490", Offset = "0x26DB490", VA = "0x26DF490")]
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty? member, string? id)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x26D6FE8", Offset = "0x26D2FE8", VA = "0x26D6FE8")]
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty? member)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x26DEE54", Offset = "0x26DAE54", VA = "0x26DEE54")]
		private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty? member, string? id)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x26E1FE4", Offset = "0x26DDFE4", VA = "0x26E1FE4")]
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty? containerProperty, ObjectConstructor<object> creator, string? id)
		{
			return null;
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x26DB1E8", Offset = "0x26D71E8", VA = "0x26DB1E8")]
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object? existingValue)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x26E3864", Offset = "0x26DF864", VA = "0x26E3864")]
		private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty? containerProperty, JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x26DE9F4", Offset = "0x26DA9F4", VA = "0x26DE9F4")]
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty? containerMember, JsonProperty? containerProperty, string? id, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x26DA2B8", Offset = "0x26D62B8", VA = "0x26DA2B8")]
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty? member, string? id)
		{
			return null;
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x26E456C", Offset = "0x26E056C", VA = "0x26E456C")]
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x26DC2AC", Offset = "0x26D82AC", VA = "0x26DC2AC")]
		private bool CheckPropertyName(JsonReader reader, string memberName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x26E43F8", Offset = "0x26E03F8", VA = "0x26E43F8")]
		private void SetExtensionData(JsonObjectContract contract, JsonProperty? member, JsonReader reader, string memberName, object o)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x26E433C", Offset = "0x26E033C", VA = "0x26E433C")]
		private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty? member, JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x26E3EF4", Offset = "0x26DFEF4", VA = "0x26E3EF4")]
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x26E47D0", Offset = "0x26E07D0", VA = "0x26E47D0")]
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence>? requiredProperties)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x26DBAD4", Offset = "0x26D7AD4", VA = "0x26DBAD4")]
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
		}
	}
	[Token(Token = "0x20000CC")]
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Type? _rootType;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _rootLevel;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<object> _serializeStack;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x26E4994", Offset = "0x26E0994", VA = "0x26E4994")]
		public JsonSerializerInternalWriter(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x26E4A14", Offset = "0x26E0A14", VA = "0x26E4A14")]
		public void Serialize(JsonWriter jsonWriter, object? value, Type? objectType)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x26E57A8", Offset = "0x26E17A8", VA = "0x26E57A8")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x26E4C74", Offset = "0x26E0C74", VA = "0x26E4C74")]
		private JsonContract? GetContractSafe(object? value)
		{
			return null;
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x26E5810", Offset = "0x26E1810", VA = "0x26E5810")]
		private JsonContract GetContract(object value)
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x26E58D4", Offset = "0x26E18D4", VA = "0x26E58D4")]
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty? member, JsonContainerContract? containerContract, JsonProperty? containerProperty)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x26E50A0", Offset = "0x26E10A0", VA = "0x26E50A0")]
		private void SerializeValue(JsonWriter writer, object? value, JsonContract? valueContract, JsonProperty? member, JsonContainerContract? containerContract, JsonProperty? containerProperty)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x26E8894", Offset = "0x26E4894", VA = "0x26E8894")]
		private bool? ResolveIsReference(JsonContract contract, JsonProperty? property, JsonContainerContract? collectionContract, JsonProperty? containerProperty)
		{
			return null;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x26E4C84", Offset = "0x26E0C84", VA = "0x26E4C84")]
		private bool ShouldWriteReference(object? value, JsonProperty? property, JsonContract? valueContract, JsonContainerContract? collectionContract, JsonProperty? containerProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x26E8950", Offset = "0x26E4950", VA = "0x26E8950")]
		private bool ShouldWriteProperty(object? memberValue, JsonObjectContract? containerContract, JsonProperty property)
		{
			return default(bool);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x26E8A28", Offset = "0x26E4A28", VA = "0x26E8A28")]
		private bool CheckForCircularReference(JsonWriter writer, object? value, JsonProperty? property, JsonContract? contract, JsonContainerContract? containerContract, JsonProperty? containerProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x26E4E24", Offset = "0x26E0E24", VA = "0x26E4E24")]
		private void WriteReference(JsonWriter writer, object value)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x26E8E70", Offset = "0x26E4E70", VA = "0x26E8E70")]
		private string GetReference(JsonWriter writer, object value)
		{
			return null;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x26E905C", Offset = "0x26E505C", VA = "0x26E905C")]
		internal static bool TryConvertToString(object value, Type type, [NotNullWhen(true)] out string? s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x26E7370", Offset = "0x26E3370", VA = "0x26E7370")]
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x26E9164", Offset = "0x26E5164", VA = "0x26E9164")]
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x26E9368", Offset = "0x26E5368", VA = "0x26E9368")]
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x26E63B4", Offset = "0x26E23B4", VA = "0x26E63B4")]
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty? member, JsonContainerContract? collectionContract, JsonProperty? containerProperty)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x26E96B0", Offset = "0x26E56B0", VA = "0x26E96B0")]
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty? member, JsonProperty property, [NotNullWhen(true)] out JsonContract? memberContract, out object? memberValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x26E956C", Offset = "0x26E556C", VA = "0x26E956C")]
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty? member, JsonContainerContract? collectionContract, JsonProperty? containerProperty)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x26EA4A8", Offset = "0x26E64A8", VA = "0x26EA4A8")]
		private bool HasCreatorParameter(JsonContainerContract? contract, JsonProperty property)
		{
			return default(bool);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x26EA55C", Offset = "0x26E655C", VA = "0x26EA55C")]
		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x26E5C1C", Offset = "0x26E1C1C", VA = "0x26E5C1C")]
		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x26E8A1C", Offset = "0x26E4A1C", VA = "0x26E8A1C")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x26E8944", Offset = "0x26E4944", VA = "0x26E8944")]
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x26EA7A8", Offset = "0x26E67A8", VA = "0x26EA7A8")]
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x26E5E9C", Offset = "0x26E1E9C", VA = "0x26E5E9C")]
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract? collectionContract, JsonProperty? containerProperty)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x26E6AB4", Offset = "0x26E2AB4", VA = "0x26E6AB4")]
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty? member, JsonContainerContract? collectionContract, JsonProperty? containerProperty)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x26E7174", Offset = "0x26E3174", VA = "0x26E7174")]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty? member, JsonContainerContract? collectionContract, JsonProperty? containerProperty)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x26EAA74", Offset = "0x26E6A74", VA = "0x26EAA74")]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty? member, int initialDepth, int[] indices)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x26EA7B4", Offset = "0x26E67B4", VA = "0x26EA7B4")]
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty? member, JsonContainerContract? containerContract, JsonProperty? containerProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x26E8428", Offset = "0x26E4428", VA = "0x26E8428")]
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty? member, JsonContainerContract? collectionContract, JsonProperty? containerProperty)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x26E7C84", Offset = "0x26E3C84", VA = "0x26E7C84")]
		private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty? member, JsonContainerContract? collectionContract, JsonProperty? containerProperty)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x26EADEC", Offset = "0x26E6DEC", VA = "0x26EADEC")]
		private bool ShouldWriteDynamicProperty(object? memberValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x26E5A3C", Offset = "0x26E1A3C", VA = "0x26E5A3C")]
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty? member, JsonContainerContract? containerContract, JsonProperty? containerProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x26E73F0", Offset = "0x26E33F0", VA = "0x26E73F0")]
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty? member, JsonContainerContract? collectionContract, JsonProperty? containerProperty)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x26E9AD8", Offset = "0x26E5AD8", VA = "0x26E9AD8")]
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape)
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x26E5734", Offset = "0x26E1734", VA = "0x26E5734")]
		private void HandleError(JsonWriter writer, int initialDepth)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x26E9FE8", Offset = "0x26E5FE8", VA = "0x26E9FE8")]
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
		{
			return default(bool);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x26EA248", Offset = "0x26E6248", VA = "0x26EA248")]
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000CD")]
	internal class JsonSerializerProxy : JsonSerializer
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly JsonSerializerInternalReader? _serializerReader;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly JsonSerializerInternalWriter? _serializerWriter;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal readonly JsonSerializer _serializer;

		[Token(Token = "0x170000F3")]
		public override IReferenceResolver? ReferenceResolver
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x26EAEE0", Offset = "0x26E6EE0", VA = "0x26EAEE0", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public override ITraceWriter? TraceWriter
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x26EAEFC", Offset = "0x26E6EFC", VA = "0x26EAEFC", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x26EAF18", Offset = "0x26E6F18", VA = "0x26EAF18", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public override IEqualityComparer? EqualityComparer
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x26EAF34", Offset = "0x26E6F34", VA = "0x26EAF34", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public override JsonConverterCollection Converters
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x26EAF50", Offset = "0x26E6F50", VA = "0x26EAF50", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		public override DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x26EAF70", Offset = "0x26E6F70", VA = "0x26EAF70", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public override IContractResolver ContractResolver
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x26EAF90", Offset = "0x26E6F90", VA = "0x26EAF90", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x26EAFB0", Offset = "0x26E6FB0", VA = "0x26EAFB0", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public override MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x26EAFD0", Offset = "0x26E6FD0", VA = "0x26EAFD0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public override NullValueHandling NullValueHandling
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x26EAFF0", Offset = "0x26E6FF0", VA = "0x26EAFF0", Slot = "16")]
			get
			{
				return default(NullValueHandling);
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x26EB010", Offset = "0x26E7010", VA = "0x26EB010", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public override ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x26EB030", Offset = "0x26E7030", VA = "0x26EB030", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x26EB050", Offset = "0x26E7050", VA = "0x26EB050", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x26EB070", Offset = "0x26E7070", VA = "0x26EB070", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public override TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x26EB090", Offset = "0x26E7090", VA = "0x26EB090", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x26EB0AC", Offset = "0x26E70AC", VA = "0x26EB0AC", Slot = "21")]
			get
			{
				return default(MetadataPropertyHandling);
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x26EB0CC", Offset = "0x26E70CC", VA = "0x26EB0CC", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x26EB0EC", Offset = "0x26E70EC", VA = "0x26EB0EC", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public override ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x26EB108", Offset = "0x26E7108", VA = "0x26EB108", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public override ISerializationBinder SerializationBinder
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x26EB128", Offset = "0x26E7128", VA = "0x26EB128", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public override StreamingContext Context
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x26EB144", Offset = "0x26E7144", VA = "0x26EB144", Slot = "26")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x26EB164", Offset = "0x26E7164", VA = "0x26EB164", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public override Formatting Formatting
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x26EB184", Offset = "0x26E7184", VA = "0x26EB184", Slot = "28")]
			get
			{
				return default(Formatting);
			}
		}

		[Token(Token = "0x17000105")]
		public override int? MaxDepth
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x26EB1A4", Offset = "0x26E71A4", VA = "0x26EB1A4", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		public override bool CheckAdditionalContent
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x26EB1C4", Offset = "0x26E71C4", VA = "0x26EB1C4", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000002")]
		public override event EventHandler<ErrorEventArgs>? Error
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x26EAEA8", Offset = "0x26E6EA8", VA = "0x26EAEA8", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x26EAEC4", Offset = "0x26E6EC4", VA = "0x26EAEC4", Slot = "5")]
			remove
			{
			}
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x26EB1E4", Offset = "0x26E71E4", VA = "0x26EB1E4")]
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x26EB200", Offset = "0x26E7200", VA = "0x26EB200")]
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x26EB27C", Offset = "0x26E727C", VA = "0x26EB27C")]
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x26EB2F8", Offset = "0x26E72F8", VA = "0x26EB2F8", Slot = "32")]
		internal override object? DeserializeInternal(JsonReader reader, Type? objectType)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x26EB328", Offset = "0x26E7328", VA = "0x26EB328", Slot = "31")]
		internal override void PopulateInternal(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x26EB354", Offset = "0x26E7354", VA = "0x26EB354", Slot = "33")]
		internal override void SerializeInternal(JsonWriter jsonWriter, object? value, Type? rootType)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class JsonStringContract : JsonPrimitiveContract
	{
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x26EB380", Offset = "0x26E7380", VA = "0x26EB380")]
		public JsonStringContract(Type underlyingType)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	internal static class JsonTypeReflector
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool? _fullyTrusted;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ThreadSafeStore<Type, Func<object[]?, object>> CreatorCache;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly ThreadSafeStore<Type, Type?> AssociatedMetadataTypesCache;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static ReflectionObject? _metadataTypeAttributeReflectionObject;

		[Token(Token = "0x17000107")]
		public static bool FullyTrusted
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x26EC384", Offset = "0x26E8384", VA = "0x26EC384")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000108")]
		public static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x26EBFC0", Offset = "0x26E7FC0", VA = "0x26EBFC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005BD")]
		public static T GetCachedAttribute<T>(object attributeProvider) where T : notnull, Attribute
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x26EB3F4", Offset = "0x26E73F4", VA = "0x26EB3F4")]
		public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x26EB5E0", Offset = "0x26E75E0", VA = "0x26EB5E0")]
		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x26EB6AC", Offset = "0x26E76AC", VA = "0x26EB6AC")]
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x26EB940", Offset = "0x26E7940", VA = "0x26EB940")]
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			return default(MemberSerialization);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x26EBA94", Offset = "0x26E7A94", VA = "0x26EBA94")]
		public static JsonConverter GetJsonConverter(object attributeProvider)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x26EBBB4", Offset = "0x26E7BB4", VA = "0x26EBBB4")]
		public static JsonConverter CreateJsonConverterInstance(Type converterType, object[]? args)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x26EBCA8", Offset = "0x26E7CA8", VA = "0x26EBCA8")]
		public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[]? args)
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x26EBD9C", Offset = "0x26E7D9C", VA = "0x26EBD9C")]
		public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x26EBE54", Offset = "0x26E7E54", VA = "0x26EBE54")]
		private static Func<object[], object> GetCreator(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x26EC048", Offset = "0x26E8048", VA = "0x26EC048")]
		private static Type GetAssociatedMetadataType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x26EC0C8", Offset = "0x26E80C8", VA = "0x26EC0C8")]
		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		private static T GetAttribute<T>(Type type) where T : notnull, Attribute
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		private static T GetAttribute<T>(MemberInfo memberInfo) where T : notnull, Attribute
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x26EC308", Offset = "0x26E8308", VA = "0x26EC308")]
		public static bool IsNonSerializable(object provider)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x26EBA18", Offset = "0x26E7A18", VA = "0x26EBA18")]
		public static bool IsSerializable(object provider)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CD")]
		public static T GetAttribute<T>(object provider) where T : notnull, Attribute
		{
			return null;
		}
	}
	[Token(Token = "0x20000D2")]
	public class KebabCaseNamingStrategy : NamingStrategy
	{
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x26ECAF4", Offset = "0x26E8AF4", VA = "0x26ECAF4")]
		public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x26ECB2C", Offset = "0x26E8B2C", VA = "0x26ECB2C")]
		public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x26ECB6C", Offset = "0x26E8B6C", VA = "0x26ECB6C")]
		public KebabCaseNamingStrategy()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x26ECB74", Offset = "0x26E8B74", VA = "0x26ECB74", Slot = "7")]
		protected override string ResolvePropertyName(string name)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D3")]
	public abstract class NamingStrategy
	{
		[Token(Token = "0x17000109")]
		public bool ProcessDictionaryKeys
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x26ECB80", Offset = "0x26E8B80", VA = "0x26ECB80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x26ECB88", Offset = "0x26E8B88", VA = "0x26ECB88")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public bool ProcessExtensionDataNames
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x26ECB90", Offset = "0x26E8B90", VA = "0x26ECB90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x26ECB98", Offset = "0x26E8B98", VA = "0x26ECB98")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public bool OverrideSpecifiedNames
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x26ECBA0", Offset = "0x26E8BA0", VA = "0x26ECBA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x26ECBA8", Offset = "0x26E8BA8", VA = "0x26ECBA8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x26ECBB0", Offset = "0x26E8BB0", VA = "0x26ECBB0", Slot = "4")]
		public virtual string GetPropertyName(string name, bool hasSpecifiedName)
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x26ECBD0", Offset = "0x26E8BD0", VA = "0x26ECBD0", Slot = "5")]
		public virtual string GetExtensionDataName(string name)
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x26ECBEC", Offset = "0x26E8BEC", VA = "0x26ECBEC", Slot = "6")]
		public virtual string GetDictionaryKey(string key)
		{
			return null;
		}

		[Token(Token = "0x60005E3")]
		protected abstract string ResolvePropertyName(string name);

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x26ECC08", Offset = "0x26E8C08", VA = "0x26ECC08", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x26ECCE4", Offset = "0x26E8CE4", VA = "0x26ECCE4", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x26ECD64", Offset = "0x26E8D64", VA = "0x26ECD64")]
		protected bool Equals(NamingStrategy? other)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x26ECB24", Offset = "0x26E8B24", VA = "0x26ECB24")]
		protected NamingStrategy()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public delegate object ObjectConstructor<T>(params object?[] args);
	[Token(Token = "0x20000D5")]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class OnErrorAttribute : Attribute
	{
	}
	[Token(Token = "0x20000D6")]
	public class ReflectionAttributeProvider : IAttributeProvider
	{
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object _attributeProvider;

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x26ECE38", Offset = "0x26E8E38", VA = "0x26ECE38")]
		public ReflectionAttributeProvider(object attributeProvider)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class ReflectionValueProvider : IValueProvider
	{
		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MemberInfo _memberInfo;

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x26ECEA4", Offset = "0x26E8EA4", VA = "0x26ECEA4")]
		public ReflectionValueProvider(MemberInfo memberInfo)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x26ECF10", Offset = "0x26E8F10", VA = "0x26ECF10", Slot = "4")]
		public void SetValue(object target, object? value)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x26ED0AC", Offset = "0x26E90AC", VA = "0x26ED0AC", Slot = "5")]
		public object GetValue(object target)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D8")]
	public class SnakeCaseNamingStrategy : NamingStrategy
	{
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x26ED344", Offset = "0x26E9344", VA = "0x26ED344")]
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x26ED374", Offset = "0x26E9374", VA = "0x26ED374")]
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x26ED3B4", Offset = "0x26E93B4", VA = "0x26ED3B4")]
		public SnakeCaseNamingStrategy()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x26ED3BC", Offset = "0x26E93BC", VA = "0x26ED3BC", Slot = "7")]
		protected override string ResolvePropertyName(string name)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D9")]
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly JsonReader _innerReader;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly JsonTextWriter _textWriter;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly StringWriter _sw;

		[Token(Token = "0x1700010C")]
		public override int Depth
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x26ED798", Offset = "0x26E9798", VA = "0x26ED798", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700010D")]
		public override string Path
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x26ED7B4", Offset = "0x26E97B4", VA = "0x26ED7B4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		public override JsonToken TokenType
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x26ED7D0", Offset = "0x26E97D0", VA = "0x26ED7D0", Slot = "5")]
			get
			{
				return default(JsonToken);
			}
		}

		[Token(Token = "0x1700010F")]
		public override object? Value
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x26ED7EC", Offset = "0x26E97EC", VA = "0x26ED7EC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000110")]
		public override Type? ValueType
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x26ED808", Offset = "0x26E9808", VA = "0x26ED808", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		private int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x26ED8F8", Offset = "0x26E98F8", VA = "0x26ED8F8", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000112")]
		private int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x26ED9B0", Offset = "0x26E99B0", VA = "0x26ED9B0", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x26ED3C8", Offset = "0x26E93C8", VA = "0x26ED3C8")]
		public TraceJsonReader(JsonReader innerReader)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x26ED508", Offset = "0x26E9508", VA = "0x26ED508")]
		public string GetDeserializedJsonMessage()
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x26ED524", Offset = "0x26E9524", VA = "0x26ED524", Slot = "10")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x26ED598", Offset = "0x26E9598", VA = "0x26ED598", Slot = "11")]
		public override int? ReadAsInt32()
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x26ED5D8", Offset = "0x26E95D8", VA = "0x26ED5D8", Slot = "12")]
		public override string? ReadAsString()
		{
			return null;
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x26ED618", Offset = "0x26E9618", VA = "0x26ED618", Slot = "13")]
		public override byte[]? ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x26ED65C", Offset = "0x26E965C", VA = "0x26ED65C", Slot = "16")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x26ED68C", Offset = "0x26E968C", VA = "0x26ED68C", Slot = "14")]
		public override double? ReadAsDouble()
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x26ED6D8", Offset = "0x26E96D8", VA = "0x26ED6D8", Slot = "15")]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x26ED71C", Offset = "0x26E971C", VA = "0x26ED71C", Slot = "17")]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x26ED768", Offset = "0x26E9768", VA = "0x26ED768", Slot = "18")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x26ED564", Offset = "0x26E9564", VA = "0x26ED564")]
		public void WriteCurrentToken()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x26ED824", Offset = "0x26E9824", VA = "0x26ED824", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x26ED844", Offset = "0x26E9844", VA = "0x26ED844", Slot = "21")]
		private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DA")]
	internal class TraceJsonWriter : JsonWriter
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly JsonWriter _innerWriter;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly JsonTextWriter _textWriter;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly StringWriter _sw;

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x26EDA68", Offset = "0x26E9A68", VA = "0x26EDA68")]
		public TraceJsonWriter(JsonWriter innerWriter)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x26EDC30", Offset = "0x26E9C30", VA = "0x26EDC30")]
		public string GetSerializedJsonMessage()
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x26EDC4C", Offset = "0x26E9C4C", VA = "0x26EDC4C", Slot = "38")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x26EDCB8", Offset = "0x26E9CB8", VA = "0x26EDCB8", Slot = "55")]
		public override void WriteValue(decimal? value)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x26EDDC4", Offset = "0x26E9DC4", VA = "0x26EDDC4", Slot = "32")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x26EDE28", Offset = "0x26E9E28", VA = "0x26EDE28", Slot = "49")]
		public override void WriteValue(bool? value)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x26EDED8", Offset = "0x26E9ED8", VA = "0x26EDED8", Slot = "36")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x26EDF38", Offset = "0x26E9F38", VA = "0x26EDF38", Slot = "53")]
		public override void WriteValue(byte? value)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x26EDFE4", Offset = "0x26E9FE4", VA = "0x26EDFE4", Slot = "35")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x26EE044", Offset = "0x26EA044", VA = "0x26EE044", Slot = "52")]
		public override void WriteValue(char? value)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x26EE0F0", Offset = "0x26EA0F0", VA = "0x26EE0F0", Slot = "60")]
		public override void WriteValue(byte[]? value)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x26EE164", Offset = "0x26EA164", VA = "0x26EE164", Slot = "39")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x26EE1C4", Offset = "0x26EA1C4", VA = "0x26EE1C4", Slot = "56")]
		public override void WriteValue(DateTime? value)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x26EE284", Offset = "0x26EA284", VA = "0x26EE284", Slot = "40")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x26EE2F0", Offset = "0x26EA2F0", VA = "0x26EE2F0", Slot = "57")]
		public override void WriteValue(DateTimeOffset? value)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x26EE3C4", Offset = "0x26EA3C4", VA = "0x26EE3C4", Slot = "31")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x26EE424", Offset = "0x26EA424", VA = "0x26EE424", Slot = "48")]
		public override void WriteValue(double? value)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x26EE4E8", Offset = "0x26EA4E8", VA = "0x26EE4E8", Slot = "22")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x26EE534", Offset = "0x26EA534", VA = "0x26EE534", Slot = "21")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x26EE580", Offset = "0x26EA580", VA = "0x26EE580", Slot = "30")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x26EE5E0", Offset = "0x26EA5E0", VA = "0x26EE5E0", Slot = "47")]
		public override void WriteValue(float? value)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x26EE690", Offset = "0x26EA690", VA = "0x26EE690", Slot = "41")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x26EE6FC", Offset = "0x26EA6FC", VA = "0x26EE6FC", Slot = "58")]
		public override void WriteValue(Guid? value)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x26EE7D4", Offset = "0x26EA7D4", VA = "0x26EE7D4", Slot = "26")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x26EE834", Offset = "0x26EA834", VA = "0x26EE834", Slot = "43")]
		public override void WriteValue(int? value)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x26EE8E0", Offset = "0x26EA8E0", VA = "0x26EE8E0", Slot = "28")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x26EE940", Offset = "0x26EA940", VA = "0x26EE940", Slot = "45")]
		public override void WriteValue(long? value)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x26EEA00", Offset = "0x26EAA00", VA = "0x26EEA00", Slot = "62")]
		public override void WriteValue(object? value)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x26EEAF8", Offset = "0x26EAAF8", VA = "0x26EEAF8", Slot = "37")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x26EEB58", Offset = "0x26EAB58", VA = "0x26EEB58", Slot = "54")]
		public override void WriteValue(sbyte? value)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x26EEC04", Offset = "0x26EAC04", VA = "0x26EEC04", Slot = "33")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x26EEC64", Offset = "0x26EAC64", VA = "0x26EEC64", Slot = "50")]
		public override void WriteValue(short? value)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x26EED10", Offset = "0x26EAD10", VA = "0x26EED10", Slot = "25")]
		public override void WriteValue(string? value)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x26EED70", Offset = "0x26EAD70", VA = "0x26EED70", Slot = "42")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x26EEDD0", Offset = "0x26EADD0", VA = "0x26EEDD0", Slot = "59")]
		public override void WriteValue(TimeSpan? value)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x26EEE90", Offset = "0x26EAE90", VA = "0x26EEE90", Slot = "27")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x26EEEF0", Offset = "0x26EAEF0", VA = "0x26EEEF0", Slot = "44")]
		public override void WriteValue(uint? value)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x26EEF9C", Offset = "0x26EAF9C", VA = "0x26EEF9C", Slot = "29")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x26EEFFC", Offset = "0x26EAFFC", VA = "0x26EEFFC", Slot = "46")]
		public override void WriteValue(ulong? value)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x26EF0BC", Offset = "0x26EB0BC", VA = "0x26EF0BC", Slot = "61")]
		public override void WriteValue(Uri? value)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x26EF180", Offset = "0x26EB180", VA = "0x26EF180", Slot = "34")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x26EF1E0", Offset = "0x26EB1E0", VA = "0x26EF1E0", Slot = "51")]
		public override void WriteValue(ushort? value)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x26EF28C", Offset = "0x26EB28C", VA = "0x26EF28C", Slot = "63")]
		public override void WriteComment(string? text)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x26EF2EC", Offset = "0x26EB2EC", VA = "0x26EF2EC", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x26EF330", Offset = "0x26EB330", VA = "0x26EF330", Slot = "10")]
		public override void WriteEndArray()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x26EF374", Offset = "0x26EB374", VA = "0x26EF374", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x26EF3CC", Offset = "0x26EB3CC", VA = "0x26EF3CC", Slot = "12")]
		public override void WriteEndConstructor()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x26EF410", Offset = "0x26EB410", VA = "0x26EF410", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x26EF470", Offset = "0x26EB470", VA = "0x26EF470", Slot = "14")]
		public override void WritePropertyName(string name, bool escape)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x26EF4DC", Offset = "0x26EB4DC", VA = "0x26EF4DC", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x26EF520", Offset = "0x26EB520", VA = "0x26EF520", Slot = "8")]
		public override void WriteEndObject()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x26EF564", Offset = "0x26EB564", VA = "0x26EF564", Slot = "24")]
		public override void WriteRawValue(string? json)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x26EF5C4", Offset = "0x26EB5C4", VA = "0x26EF5C4", Slot = "23")]
		public override void WriteRaw(string? json)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x26EF624", Offset = "0x26EB624", VA = "0x26EF624", Slot = "6")]
		public override void Close()
		{
		}
	}
}
namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000DB")]
	public enum CommentHandling
	{
		[Token(Token = "0x400032E")]
		Ignore,
		[Token(Token = "0x400032F")]
		Load
	}
	[Token(Token = "0x20000DC")]
	public enum DuplicatePropertyNameHandling
	{
		[Token(Token = "0x4000331")]
		Replace,
		[Token(Token = "0x4000332")]
		Ignore,
		[Token(Token = "0x4000333")]
		Error
	}
	[Token(Token = "0x20000DD")]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<JToken> _values;

		[Token(Token = "0x17000113")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x26EF668", Offset = "0x26EB668", VA = "0x26EF668", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		public override JTokenType Type
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x26EF670", Offset = "0x26EB670", VA = "0x26EF670", Slot = "12")]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x17000115")]
		public JToken this[int index]
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x26F0170", Offset = "0x26EC170", VA = "0x26F0170", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x26F0180", Offset = "0x26EC180", VA = "0x26F0180", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x26F0300", Offset = "0x26EC300", VA = "0x26F0300", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x26EF678", Offset = "0x26EB678", VA = "0x26EF678")]
		public JArray()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x26EF748", Offset = "0x26EB748", VA = "0x26EF748")]
		internal JArray(JArray other, JsonCloneSettings? settings)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x26EFB0C", Offset = "0x26EBB0C", VA = "0x26EFB0C")]
		public JArray(object content)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x26EFBA0", Offset = "0x26EBBA0", VA = "0x26EFBA0", Slot = "11")]
		internal override JToken CloneToken([Optional] JsonCloneSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x26EFC08", Offset = "0x26EBC08", VA = "0x26EFC08")]
		public static JArray Load(JsonReader reader, JsonLoadSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x26F00A4", Offset = "0x26EC0A4", VA = "0x26F00A4", Slot = "17")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x26F0190", Offset = "0x26EC190", VA = "0x26F0190", Slot = "51")]
		internal override int IndexOfItem(JToken? item)
		{
			return default(int);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x26F01F4", Offset = "0x26EC1F4", VA = "0x26F01F4", Slot = "21")]
		public int IndexOf(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x26F0204", Offset = "0x26EC204", VA = "0x26F0204", Slot = "22")]
		public void Insert(int index, JToken item)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x26F021C", Offset = "0x26EC21C", VA = "0x26F021C", Slot = "23")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x26F022C", Offset = "0x26EC22C", VA = "0x26F022C", Slot = "4")]
		public IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x26F02C0", Offset = "0x26EC2C0", VA = "0x26F02C0", Slot = "26")]
		public void Add(JToken item)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x26F02D0", Offset = "0x26EC2D0", VA = "0x26F02D0", Slot = "27")]
		public void Clear()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x26F02E0", Offset = "0x26EC2E0", VA = "0x26F02E0", Slot = "28")]
		public bool Contains(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x26F02F0", Offset = "0x26EC2F0", VA = "0x26F02F0", Slot = "29")]
		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x26F0308", Offset = "0x26EC308", VA = "0x26F0308", Slot = "30")]
		public bool Remove(JToken item)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DE")]
	[DefaultMember("Item")]
	public class JConstructor : JContainer
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string? _name;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly List<JToken> _values;

		[Token(Token = "0x17000117")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x26F0318", Offset = "0x26EC318", VA = "0x26F0318", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000118")]
		public string? Name
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x26F0384", Offset = "0x26EC384", VA = "0x26F0384")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000119")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x26F038C", Offset = "0x26EC38C", VA = "0x26F038C", Slot = "12")]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x26F0320", Offset = "0x26EC320", VA = "0x26F0320", Slot = "51")]
		internal override int IndexOfItem(JToken? item)
		{
			return default(int);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x26F0394", Offset = "0x26EC394", VA = "0x26F0394")]
		internal JConstructor(JConstructor other, JsonCloneSettings? settings)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x26F0438", Offset = "0x26EC438", VA = "0x26F0438")]
		public JConstructor(string name)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x26F0558", Offset = "0x26EC558", VA = "0x26F0558", Slot = "11")]
		internal override JToken CloneToken([Optional] JsonCloneSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x26F05C0", Offset = "0x26EC5C0", VA = "0x26F05C0", Slot = "17")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x26F06A0", Offset = "0x26EC6A0", VA = "0x26F06A0")]
		public static JConstructor Load(JsonReader reader, JsonLoadSettings? settings)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DF")]
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IBindingList, ICollection, IList, INotifyCollectionChanged
	{
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal ListChangedEventHandler? _listChanged;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal NotifyCollectionChangedEventHandler? _collectionChanged;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object? _syncRoot;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _busy;

		[Token(Token = "0x1700011A")]
		protected abstract IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x600065D")]
			get;
		}

		[Token(Token = "0x1700011B")]
		public override bool HasValues
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x26F0F3C", Offset = "0x26ECF3C", VA = "0x26F0F3C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		public override JToken? First
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x26F0FFC", Offset = "0x26ECFFC", VA = "0x26F0FFC", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		public override JToken? Last
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x26F1138", Offset = "0x26ED138", VA = "0x26F1138", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x26F3B28", Offset = "0x26EFB28", VA = "0x26F3B28", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x26F3B38", Offset = "0x26EFB38", VA = "0x26F3B38", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x26F3B88", Offset = "0x26EFB88", VA = "0x26F3B88", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000120")]
		private bool System.Collections.IList.IsFixedSize
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x26F3D60", Offset = "0x26EFD60", VA = "0x26F3D60", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000121")]
		private bool System.Collections.IList.IsReadOnly
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x26F3D68", Offset = "0x26EFD68", VA = "0x26F3D68", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000122")]
		private object? System.Collections.IList.Item
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x26F3DB4", Offset = "0x26EFDB4", VA = "0x26F3DB4", Slot = "31")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x26F3DC4", Offset = "0x26EFDC4", VA = "0x26F3DC4", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public int Count
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x26F2C34", Offset = "0x26EEC34", VA = "0x26F2C34", Slot = "43")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000124")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x26F3E14", Offset = "0x26EFE14", VA = "0x26F3E14", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000125")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x26F3E1C", Offset = "0x26EFE1C", VA = "0x26F3E1C", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000003")]
		public event NotifyCollectionChangedEventHandler? CollectionChanged
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x26F0890", Offset = "0x26EC890", VA = "0x26F0890", Slot = "46")]
			add
			{
			}
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x26F0910", Offset = "0x26EC910", VA = "0x26F0910", Slot = "47")]
			remove
			{
			}
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x26EF6F0", Offset = "0x26EB6F0", VA = "0x26EF6F0")]
		internal JContainer()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x26EF7D8", Offset = "0x26EB7D8", VA = "0x26EF7D8")]
		internal JContainer(JContainer other, JsonCloneSettings? settings)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x26F0D8C", Offset = "0x26ECD8C", VA = "0x26F0D8C")]
		internal void CheckReentrancy()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x26F0E2C", Offset = "0x26ECE2C", VA = "0x26F0E2C", Slot = "49")]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x26F0EB4", Offset = "0x26ECEB4", VA = "0x26F0EB4", Slot = "50")]
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x26F1274", Offset = "0x26ED274", VA = "0x26F1274", Slot = "16")]
		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x26F12E8", Offset = "0x26ED2E8", VA = "0x26F12E8")]
		internal bool IsMultiContent([NotNullWhen(true)] object? content)
		{
			return default(bool);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x26F13CC", Offset = "0x26ED3CC", VA = "0x26F13CC")]
		internal JToken EnsureParentToken(JToken? item, bool skipParentCheck, bool copyAnnotations)
		{
			return null;
		}

		[Token(Token = "0x6000669")]
		internal abstract int IndexOfItem(JToken? item);

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x26F1534", Offset = "0x26ED534", VA = "0x26F1534", Slot = "52")]
		internal virtual bool InsertItem(int index, JToken? item, bool skipParentCheck, bool copyAnnotations)
		{
			return default(bool);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x26F1928", Offset = "0x26ED928", VA = "0x26F1928", Slot = "53")]
		internal virtual void RemoveItemAt(int index)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x26F1D74", Offset = "0x26EDD74", VA = "0x26F1D74", Slot = "54")]
		internal virtual bool RemoveItem(JToken? item)
		{
			return default(bool);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x26F1DC8", Offset = "0x26EDDC8", VA = "0x26F1DC8", Slot = "55")]
		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x26F1E84", Offset = "0x26EDE84", VA = "0x26F1E84", Slot = "56")]
		internal virtual void SetItem(int index, JToken? item)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x26F23E0", Offset = "0x26EE3E0", VA = "0x26F23E0", Slot = "57")]
		internal virtual void ClearItems()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x26F27B0", Offset = "0x26EE7B0", VA = "0x26F27B0", Slot = "58")]
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x26F2814", Offset = "0x26EE814", VA = "0x26F2814", Slot = "59")]
		internal virtual bool ContainsItem(JToken? item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x26F2838", Offset = "0x26EE838", VA = "0x26F2838", Slot = "60")]
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x26F2330", Offset = "0x26EE330", VA = "0x26F2330")]
		internal static bool IsTokenUnchanged(JToken currentValue, JToken? newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x26F2CE8", Offset = "0x26EECE8", VA = "0x26F2CE8", Slot = "61")]
		internal virtual void ValidateToken(JToken o, JToken? existing)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x26F2E04", Offset = "0x26EEE04", VA = "0x26F2E04", Slot = "62")]
		public virtual void Add(object? content)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x26F2ED4", Offset = "0x26EEED4", VA = "0x26F2ED4")]
		internal bool TryAdd(object? content)
		{
			return default(bool);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x26F2FA4", Offset = "0x26EEFA4", VA = "0x26F2FA4")]
		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x26F0A24", Offset = "0x26ECA24", VA = "0x26F0A24")]
		internal bool TryAddInternal(int index, object? content, bool skipParentCheck, bool copyAnnotations)
		{
			return default(bool);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x26F3074", Offset = "0x26EF074", VA = "0x26F3074")]
		internal static JToken CreateFromContent(object? content)
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x26F3158", Offset = "0x26EF158", VA = "0x26F3158")]
		public void RemoveAll()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x26EFF48", Offset = "0x26EBF48", VA = "0x26EFF48")]
		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings? options)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x26F3168", Offset = "0x26EF168", VA = "0x26F3168")]
		internal void ReadContentFrom(JsonReader r, JsonLoadSettings? settings)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x26F3690", Offset = "0x26EF690", VA = "0x26F3690")]
		private static JProperty? ReadProperty(JsonReader r, JsonLoadSettings? settings, IJsonLineInfo? lineInfo, JContainer parent)
		{
			return null;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x26F3AF0", Offset = "0x26EFAF0", VA = "0x26F3AF0", Slot = "21")]
		private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x26F3B00", Offset = "0x26EFB00", VA = "0x26F3B00", Slot = "22")]
		private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x26F3B18", Offset = "0x26EFB18", VA = "0x26F3B18", Slot = "23")]
		private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x26F3B48", Offset = "0x26EFB48", VA = "0x26F3B48", Slot = "26")]
		private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x26F3B58", Offset = "0x26EFB58", VA = "0x26F3B58", Slot = "27")]
		private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x26F3B68", Offset = "0x26EFB68", VA = "0x26F3B68", Slot = "28")]
		private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x26F3B78", Offset = "0x26EFB78", VA = "0x26F3B78", Slot = "29")]
		private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x26F3B90", Offset = "0x26EFB90", VA = "0x26F3B90", Slot = "30")]
		private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x26F3BA0", Offset = "0x26EFBA0", VA = "0x26F3BA0")]
		private JToken? EnsureValue(object? value)
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x26F3C5C", Offset = "0x26EFC5C", VA = "0x26F3C5C", Slot = "33")]
		private int System.Collections.IList.Add(object? value)
		{
			return default(int);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x26F3CA0", Offset = "0x26EFCA0", VA = "0x26F3CA0", Slot = "35")]
		private void System.Collections.IList.Clear()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x26F3CB0", Offset = "0x26EFCB0", VA = "0x26F3CB0", Slot = "34")]
		private bool System.Collections.IList.Contains(object? value)
		{
			return default(bool);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x26F3CE4", Offset = "0x26EFCE4", VA = "0x26F3CE4", Slot = "38")]
		private int System.Collections.IList.IndexOf(object? value)
		{
			return default(int);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x26F3D18", Offset = "0x26EFD18", VA = "0x26F3D18", Slot = "39")]
		private void System.Collections.IList.Insert(int index, object? value)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x26F3D70", Offset = "0x26EFD70", VA = "0x26F3D70", Slot = "40")]
		private void System.Collections.IList.Remove(object? value)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x26F3DA4", Offset = "0x26EFDA4", VA = "0x26F3DA4", Slot = "41")]
		private void System.Collections.IList.RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x26F3E04", Offset = "0x26EFE04", VA = "0x26F3E04", Slot = "42")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[DefaultMember("Item")]
	public readonly struct JEnumerable<T> : IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> where T : notnull, JToken
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly JEnumerable<T> Empty;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IEnumerable<T> _enumerable;

		[Token(Token = "0x6000699")]
		public JEnumerable(IEnumerable<T> enumerable)
		{
		}

		[Token(Token = "0x600069A")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600069B")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600069C")]
		public bool Equals(JEnumerable<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600069D")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600069E")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E1")]
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor
	{
		[Token(Token = "0x20000E2")]
		private class JObjectDynamicProxy : DynamicProxy<JObject>
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x26F5DE8", Offset = "0x26F1DE8", VA = "0x26F5DE8", Slot = "11")]
			public override bool TryGetMember(JObject instance, GetMemberBinder binder, out object? result)
			{
				return default(bool);
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x26F5E20", Offset = "0x26F1E20", VA = "0x26F5E20", Slot = "15")]
			public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x26F5F00", Offset = "0x26F1F00", VA = "0x26F5F00", Slot = "4")]
			public override IEnumerable<string> GetDynamicMemberNames(JObject instance)
			{
				return null;
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x26F5DA0", Offset = "0x26F1DA0", VA = "0x26F5DA0")]
			public JObjectDynamicProxy()
			{
			}
		}

		[Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__64 : IEnumerator<KeyValuePair<string, JToken>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private KeyValuePair<string, JToken?> <>2__current;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JObject <>4__this;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JToken> <>7__wrap1;

			[Token(Token = "0x1700012C")]
			private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x26F6420", Offset = "0x26F2420", VA = "0x26F6420", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, JToken>);
				}
			}

			[Token(Token = "0x1700012D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x26F6464", Offset = "0x26F2464", VA = "0x26F6464", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x26F56B4", Offset = "0x26F16B4", VA = "0x26F56B4")]
			[DebuggerHidden]
			public <GetEnumerator>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x26F6084", Offset = "0x26F2084", VA = "0x26F6084", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x26F60A0", Offset = "0x26F20A0", VA = "0x26F60A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x26F6370", Offset = "0x26F2370", VA = "0x26F6370")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x26F642C", Offset = "0x26F242C", VA = "0x26F642C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly JPropertyKeyedCollection _properties;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[CompilerGenerated]
		private PropertyChangingEventHandler? PropertyChanging;

		[Token(Token = "0x17000126")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x26F3E90", Offset = "0x26EFE90", VA = "0x26F3E90", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000127")]
		public override JTokenType Type
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x26F4750", Offset = "0x26F0750", VA = "0x26F4750", Slot = "12")]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x17000128")]
		public JToken? this[string propertyName]
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x26F47A0", Offset = "0x26F07A0", VA = "0x26F47A0", Slot = "63")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x26F4820", Offset = "0x26F0820", VA = "0x26F4820", Slot = "64")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x26F4E44", Offset = "0x26F0E44", VA = "0x26F4E44", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		private ICollection<JToken?> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x26F4F84", Offset = "0x26F0F84", VA = "0x26F4F84", Slot = "66")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012B")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x26F550C", Offset = "0x26F150C", VA = "0x26F550C", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000004")]
		public event PropertyChangedEventHandler? PropertyChanged
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x26F3E98", Offset = "0x26EFE98", VA = "0x26F3E98", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x26F3F34", Offset = "0x26EFF34", VA = "0x26F3F34", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x26F3584", Offset = "0x26EF584", VA = "0x26F3584")]
		public JObject()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x26F4060", Offset = "0x26F0060", VA = "0x26F4060")]
		public JObject(JObject other)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x26F40CC", Offset = "0x26F00CC", VA = "0x26F40CC")]
		internal JObject(JObject other, JsonCloneSettings? settings)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x26F413C", Offset = "0x26F013C", VA = "0x26F413C")]
		public JObject(params object[] content)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x26F4140", Offset = "0x26F0140", VA = "0x26F4140")]
		public JObject(object content)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x26F41BC", Offset = "0x26F01BC", VA = "0x26F41BC", Slot = "51")]
		internal override int IndexOfItem(JToken? item)
		{
			return default(int);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x26F4280", Offset = "0x26F0280", VA = "0x26F4280", Slot = "52")]
		internal override bool InsertItem(int index, JToken? item, bool skipParentCheck, bool copyAnnotations)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x26F42F0", Offset = "0x26F02F0", VA = "0x26F42F0", Slot = "61")]
		internal override void ValidateToken(JToken o, JToken? existing)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x26F457C", Offset = "0x26F057C", VA = "0x26F457C")]
		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x26F46C8", Offset = "0x26F06C8", VA = "0x26F46C8")]
		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x26F46E8", Offset = "0x26F06E8", VA = "0x26F46E8", Slot = "11")]
		internal override JToken CloneToken(JsonCloneSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x26F4758", Offset = "0x26F0758", VA = "0x26F4758")]
		public IEnumerable<JProperty> Properties()
		{
			return null;
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x26F3864", Offset = "0x26EF864", VA = "0x26F3864")]
		public JProperty Property(string name, StringComparison comparison)
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x26F4994", Offset = "0x26F0994", VA = "0x26F4994")]
		public static JObject Load(JsonReader reader, JsonLoadSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x26F4B58", Offset = "0x26F0B58", VA = "0x26F4B58", Slot = "17")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x26F4918", Offset = "0x26F0918", VA = "0x26F4918", Slot = "68")]
		public void Add(string propertyName, JToken? value)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x26F4D2C", Offset = "0x26F0D2C", VA = "0x26F4D2C", Slot = "67")]
		public bool ContainsKey(string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x26F4EB0", Offset = "0x26F0EB0", VA = "0x26F4EB0", Slot = "69")]
		public bool Remove(string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x26F4F44", Offset = "0x26F0F44", VA = "0x26F4F44", Slot = "70")]
		public bool TryGetValue(string propertyName, [NotNullWhen(true)] out JToken? value)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x26F4FBC", Offset = "0x26F0FBC", VA = "0x26F4FBC", Slot = "73")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken?> item)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x26F5050", Offset = "0x26F1050", VA = "0x26F5050", Slot = "74")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x26F5060", Offset = "0x26F1060", VA = "0x26F5060", Slot = "75")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken?> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x26F50E0", Offset = "0x26F10E0", VA = "0x26F50E0", Slot = "76")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken?>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x26F5514", Offset = "0x26F1514", VA = "0x26F5514", Slot = "77")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken?> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x26F5654", Offset = "0x26F1654", VA = "0x26F5654", Slot = "78")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__64))]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x26F56DC", Offset = "0x26F16DC", VA = "0x26F56DC", Slot = "86")]
		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x26F576C", Offset = "0x26F176C", VA = "0x26F576C", Slot = "87")]
		protected virtual void OnPropertyChanging(string propertyName)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x26F57FC", Offset = "0x26F17FC", VA = "0x26F57FC", Slot = "83")]
		private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x26F5898", Offset = "0x26F1898", VA = "0x26F5898", Slot = "84")]
		private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[]? attributes)
		{
			return null;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x26F5BC8", Offset = "0x26F1BC8", VA = "0x26F5BC8", Slot = "81")]
		private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x26F5C20", Offset = "0x26F1C20", VA = "0x26F5C20", Slot = "82")]
		private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x26F5C74", Offset = "0x26F1C74", VA = "0x26F5C74", Slot = "85")]
		private object? System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor? pd)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x26F5CF0", Offset = "0x26F1CF0", VA = "0x26F5CF0", Slot = "18")]
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E5")]
	public class JProperty : JContainer
	{
		[Token(Token = "0x20000E6")]
		private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
		{
			[Token(Token = "0x20000E7")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__1 : IEnumerator<JToken>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4000349")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int <>1__state;

				[Token(Token = "0x400034A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private JToken <>2__current;

				[Token(Token = "0x400034B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public JPropertyList <>4__this;

				[Token(Token = "0x17000135")]
				private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
				{
					[Token(Token = "0x60006FD")]
					[Address(RVA = "0x26F6F94", Offset = "0x26F2F94", VA = "0x26F6F94", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x17000136")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x60006FF")]
					[Address(RVA = "0x26F6FD4", Offset = "0x26F2FD4", VA = "0x26F6FD4", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x26F6DB0", Offset = "0x26F2DB0", VA = "0x26F6DB0")]
				[DebuggerHidden]
				public <GetEnumerator>d__1(int <>1__state)
				{
				}

				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x26F6F3C", Offset = "0x26F2F3C", VA = "0x26F6F3C", Slot = "5")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x60006FC")]
				[Address(RVA = "0x26F6F40", Offset = "0x26F2F40", VA = "0x26F6F40", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x60006FE")]
				[Address(RVA = "0x26F6F9C", Offset = "0x26F2F9C", VA = "0x26F6F9C", Slot = "8")]
				[DebuggerHidden]
				private void System.Collections.IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal JToken? _token;

			[Token(Token = "0x17000132")]
			public int Count
			{
				[Token(Token = "0x60006F2")]
				[Address(RVA = "0x26F6E7C", Offset = "0x26F2E7C", VA = "0x26F6E7C", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000133")]
			public bool IsReadOnly
			{
				[Token(Token = "0x60006F3")]
				[Address(RVA = "0x26F6E8C", Offset = "0x26F2E8C", VA = "0x26F6E8C", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000134")]
			public JToken this[int index]
			{
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x26F6EB4", Offset = "0x26F2EB4", VA = "0x26F6EB4", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x26F6EF8", Offset = "0x26F2EF8", VA = "0x26F6EF8", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x26F6D50", Offset = "0x26F2D50", VA = "0x26F6D50", Slot = "16")]
			[IteratorStateMachine(typeof(<GetEnumerator>d__1))]
			public IEnumerator<JToken> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x26F6DD8", Offset = "0x26F2DD8", VA = "0x26F6DD8", Slot = "17")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x26F6DDC", Offset = "0x26F2DDC", VA = "0x26F6DDC", Slot = "11")]
			public void Add(JToken item)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x26F6DE4", Offset = "0x26F2DE4", VA = "0x26F6DE4", Slot = "12")]
			public void Clear()
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x26F6DEC", Offset = "0x26F2DEC", VA = "0x26F6DEC", Slot = "13")]
			public bool Contains(JToken item)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x26F6DFC", Offset = "0x26F2DFC", VA = "0x26F6DFC", Slot = "14")]
			public void CopyTo(JToken[] array, int arrayIndex)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x26F6E60", Offset = "0x26F2E60", VA = "0x26F6E60", Slot = "15")]
			public bool Remove(JToken item)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x26F687C", Offset = "0x26F287C", VA = "0x26F687C", Slot = "6")]
			public int IndexOf(JToken item)
			{
				return default(int);
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x26F6E94", Offset = "0x26F2E94", VA = "0x26F6E94", Slot = "7")]
			public void Insert(int index, JToken item)
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x26F6EA4", Offset = "0x26F2EA4", VA = "0x26F6EA4", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x26F6558", Offset = "0x26F2558", VA = "0x26F6558")]
			public JPropertyList()
			{
			}
		}

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly JPropertyList _content;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string _name;

		[Token(Token = "0x1700012E")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x26F64C0", Offset = "0x26F24C0", VA = "0x26F64C0", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012F")]
		public string Name
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x26F64C8", Offset = "0x26F24C8", VA = "0x26F64C8")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000130")]
		public JToken Value
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x26F356C", Offset = "0x26EF56C", VA = "0x26F356C")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x26F4898", Offset = "0x26F0898", VA = "0x26F4898")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public override JTokenType Type
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x26F6AD8", Offset = "0x26F2AD8", VA = "0x26F6AD8", Slot = "12")]
			[DebuggerStepThrough]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x26F64D0", Offset = "0x26F24D0", VA = "0x26F64D0")]
		internal JProperty(JProperty other, JsonCloneSettings? settings)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x26F6560", Offset = "0x26F2560", VA = "0x26F6560", Slot = "55")]
		internal override JToken GetItem(int index)
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x26F65B4", Offset = "0x26F25B4", VA = "0x26F65B4", Slot = "56")]
		internal override void SetItem(int index, JToken? item)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x26F66F8", Offset = "0x26F26F8", VA = "0x26F66F8", Slot = "54")]
		internal override bool RemoveItem(JToken? item)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x26F67A4", Offset = "0x26F27A4", VA = "0x26F67A4", Slot = "53")]
		internal override void RemoveItemAt(int index)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x26F6850", Offset = "0x26F2850", VA = "0x26F6850", Slot = "51")]
		internal override int IndexOfItem(JToken? item)
		{
			return default(int);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x26F688C", Offset = "0x26F288C", VA = "0x26F688C", Slot = "52")]
		internal override bool InsertItem(int index, JToken? item, bool skipParentCheck, bool copyAnnotations)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x26F69A4", Offset = "0x26F29A4", VA = "0x26F69A4", Slot = "59")]
		internal override bool ContainsItem(JToken? item)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x26F69C4", Offset = "0x26F29C4", VA = "0x26F69C4", Slot = "57")]
		internal override void ClearItems()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x26F6A70", Offset = "0x26F2A70", VA = "0x26F6A70", Slot = "11")]
		internal override JToken CloneToken(JsonCloneSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x26F39EC", Offset = "0x26EF9EC", VA = "0x26F39EC")]
		internal JProperty(string name)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x26F4C40", Offset = "0x26F0C40", VA = "0x26F4C40")]
		public JProperty(string name, object? content)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x26F6AE0", Offset = "0x26F2AE0", VA = "0x26F6AE0", Slot = "17")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x26F6B60", Offset = "0x26F2B60", VA = "0x26F6B60")]
		public static JProperty Load(JsonReader reader, JsonLoadSettings? settings)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E8")]
	public class JPropertyDescriptor : PropertyDescriptor
	{
		[Token(Token = "0x17000137")]
		public override Type ComponentType
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x26F71BC", Offset = "0x26F31BC", VA = "0x26F71BC", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x26F7228", Offset = "0x26F3228", VA = "0x26F7228", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000139")]
		public override Type PropertyType
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x26F7230", Offset = "0x26F3230", VA = "0x26F7230", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013A")]
		protected override int NameHashCode
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x26F729C", Offset = "0x26F329C", VA = "0x26F729C", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x26F5BBC", Offset = "0x26F1BBC", VA = "0x26F5BBC")]
		public JPropertyDescriptor(string name)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x26F6FDC", Offset = "0x26F2FDC", VA = "0x26F6FDC", Slot = "17")]
		public override bool CanResetValue(object component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x26F6FE4", Offset = "0x26F2FE4", VA = "0x26F6FE4", Slot = "18")]
		public override object? GetValue(object? component)
		{
			return null;
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x26F7080", Offset = "0x26F3080", VA = "0x26F7080", Slot = "20")]
		public override void ResetValue(object component)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x26F7084", Offset = "0x26F3084", VA = "0x26F7084", Slot = "21")]
		public override void SetValue(object? component, object? value)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x26F71B4", Offset = "0x26F31B4", VA = "0x26F71B4", Slot = "22")]
		public override bool ShouldSerializeValue(object component)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E9")]
	[DefaultMember("Item")]
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IEqualityComparer<string> Comparer;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, JToken>? _dictionary;

		[Token(Token = "0x1700013B")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x26F4E58", Offset = "0x26F0E58", VA = "0x26F4E58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x26F3FD0", Offset = "0x26EFFD0", VA = "0x26F3FD0")]
		public JPropertyKeyedCollection()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x26F72A4", Offset = "0x26F32A4", VA = "0x26F72A4")]
		private void AddKey(string key, JToken item)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x26F73BC", Offset = "0x26F33BC", VA = "0x26F73BC", Slot = "35")]
		protected override void ClearItems()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x26F4D98", Offset = "0x26F0D98", VA = "0x26F4D98")]
		public bool Contains(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x26F7314", Offset = "0x26F3314", VA = "0x26F7314")]
		private void EnsureDictionary()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x26F7434", Offset = "0x26F3434", VA = "0x26F7434")]
		private string GetKeyForItem(JToken item)
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x26F74B4", Offset = "0x26F34B4", VA = "0x26F74B4", Slot = "36")]
		protected override void InsertItem(int index, JToken item)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x26F752C", Offset = "0x26F352C", VA = "0x26F752C", Slot = "37")]
		protected override void RemoveItem(int index)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x26F7620", Offset = "0x26F3620", VA = "0x26F7620")]
		private void RemoveKey(string key)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x26F7680", Offset = "0x26F3680", VA = "0x26F7680", Slot = "38")]
		protected override void SetItem(int index, JToken item)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x26F4504", Offset = "0x26F0504", VA = "0x26F4504")]
		public bool TryGetValue(string key, [NotNullWhen(true)] out JToken? value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x26F41DC", Offset = "0x26F01DC", VA = "0x26F41DC")]
		public int IndexOfReference(JToken t)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000EA")]
	public class JRaw : JValue
	{
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x26F7930", Offset = "0x26F3930", VA = "0x26F7930")]
		internal JRaw(JRaw other, JsonCloneSettings? settings)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x26F79F4", Offset = "0x26F39F4", VA = "0x26F79F4")]
		public JRaw(object? rawJson)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x26F7A70", Offset = "0x26F3A70", VA = "0x26F7A70")]
		public static JRaw Create(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x26F7D50", Offset = "0x26F3D50", VA = "0x26F7D50", Slot = "11")]
		internal override JToken CloneToken(JsonCloneSettings? settings)
		{
			return null;
		}
	}
	[Token(Token = "0x20000EB")]
	public class JsonCloneSettings
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly JsonCloneSettings SkipCopyAnnotations;

		[Token(Token = "0x1700013C")]
		public bool CopyAnnotations
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x26F7DD8", Offset = "0x26F3DD8", VA = "0x26F7DD8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x26F7DE0", Offset = "0x26F3DE0", VA = "0x26F7DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x26F7DB8", Offset = "0x26F3DB8", VA = "0x26F7DB8")]
		public JsonCloneSettings()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class JsonLoadSettings
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CommentHandling _commentHandling;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private LineInfoHandling _lineInfoHandling;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DuplicatePropertyNameHandling _duplicatePropertyNameHandling;

		[Token(Token = "0x1700013D")]
		public CommentHandling CommentHandling
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x26F7E48", Offset = "0x26F3E48", VA = "0x26F7E48")]
			get
			{
				return default(CommentHandling);
			}
		}

		[Token(Token = "0x1700013E")]
		public LineInfoHandling LineInfoHandling
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x26F7E50", Offset = "0x26F3E50", VA = "0x26F7E50")]
			get
			{
				return default(LineInfoHandling);
			}
		}

		[Token(Token = "0x1700013F")]
		public DuplicatePropertyNameHandling DuplicatePropertyNameHandling
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x26F7E58", Offset = "0x26F3E58", VA = "0x26F7E58")]
			get
			{
				return default(DuplicatePropertyNameHandling);
			}
		}
	}
	[Token(Token = "0x20000ED")]
	[DefaultMember("Item")]
	public abstract class JToken : IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
	{
		[Token(Token = "0x20000EE")]
		private class LineInfoAnnotation
		{
			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal readonly int LineNumber;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal readonly int LinePosition;

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x26FEB70", Offset = "0x26FAB70", VA = "0x26FEB70")]
			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
			}
		}

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JContainer? _parent;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private JToken? _previous;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private JToken? _next;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object? _annotations;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly JTokenType[] BooleanTypes;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly JTokenType[] NumberTypes;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly JTokenType[] BigIntegerTypes;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly JTokenType[] StringTypes;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly JTokenType[] GuidTypes;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly JTokenType[] TimeSpanTypes;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly JTokenType[] UriTypes;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly JTokenType[] CharTypes;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly JTokenType[] DateTimeTypes;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly JTokenType[] BytesTypes;

		[Token(Token = "0x17000140")]
		public JContainer? Parent
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x26F7E60", Offset = "0x26F3E60", VA = "0x26F7E60")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x26F7E68", Offset = "0x26F3E68", VA = "0x26F7E68")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public JToken Root
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x26F151C", Offset = "0x26ED51C", VA = "0x26F151C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000142")]
		public abstract JTokenType Type
		{
			[Token(Token = "0x6000727")]
			get;
		}

		[Token(Token = "0x17000143")]
		public abstract bool HasValues
		{
			[Token(Token = "0x6000728")]
			get;
		}

		[Token(Token = "0x17000144")]
		public JToken? Next
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x26F7E70", Offset = "0x26F3E70", VA = "0x26F7E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x26F7E78", Offset = "0x26F3E78", VA = "0x26F7E78")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public JToken? Previous
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x26F7E80", Offset = "0x26F3E80", VA = "0x26F7E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x26F7E88", Offset = "0x26F3E88", VA = "0x26F7E88")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public string Path
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x26F7E90", Offset = "0x26F3E90", VA = "0x26F7E90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000147")]
		public virtual JToken? First
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x26F81D8", Offset = "0x26F41D8", VA = "0x26F81D8", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000148")]
		public virtual JToken? Last
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x26F8268", Offset = "0x26F4268", VA = "0x26F8268", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000149")]
		private int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x26FEE00", Offset = "0x26FAE00", VA = "0x26FEE00", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014A")]
		private int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x26FEE54", Offset = "0x26FAE54", VA = "0x26FEE54", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000726")]
		internal abstract JToken CloneToken(JsonCloneSettings? settings);

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x26F0990", Offset = "0x26EC990", VA = "0x26F0990")]
		internal JToken()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x26F82F8", Offset = "0x26F42F8", VA = "0x26F82F8", Slot = "16")]
		public virtual JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x26F4EDC", Offset = "0x26F0EDC", VA = "0x26F4EDC")]
		public void Remove()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x26F3A80", Offset = "0x26EFA80", VA = "0x26F3A80")]
		public void Replace(JToken value)
		{
		}

		[Token(Token = "0x6000734")]
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x26F8350", Offset = "0x26F4350", VA = "0x26F8350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x26F83F0", Offset = "0x26F43F0", VA = "0x26F83F0")]
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x26F8604", Offset = "0x26F4604", VA = "0x26F8604")]
		private static JValue EnsureValue(JToken value)
		{
			return null;
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x26F8718", Offset = "0x26F4718", VA = "0x26F8718")]
		private static string GetType(JToken token)
		{
			return null;
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x26F8808", Offset = "0x26F4808", VA = "0x26F8808")]
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x26F88C8", Offset = "0x26F48C8", VA = "0x26F88C8")]
		public static explicit operator bool(JToken value)
		{
			return default(bool);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x26F8AD0", Offset = "0x26F4AD0", VA = "0x26F8AD0")]
		public static explicit operator DateTimeOffset(JToken value)
		{
			return default(DateTimeOffset);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x26F8D1C", Offset = "0x26F4D1C", VA = "0x26F8D1C")]
		public static explicit operator bool?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x26F8F70", Offset = "0x26F4F70", VA = "0x26F8F70")]
		public static explicit operator long(JToken value)
		{
			return default(long);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x26F9154", Offset = "0x26F5154", VA = "0x26F9154")]
		public static explicit operator DateTime?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x26F9378", Offset = "0x26F5378", VA = "0x26F9378")]
		public static explicit operator DateTimeOffset?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x26F9648", Offset = "0x26F5648", VA = "0x26F9648")]
		public static explicit operator decimal?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x26F9888", Offset = "0x26F5888", VA = "0x26F9888")]
		public static explicit operator double?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x26F9AA8", Offset = "0x26F5AA8", VA = "0x26F9AA8")]
		public static explicit operator char?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x26F9CCC", Offset = "0x26F5CCC", VA = "0x26F9CCC")]
		public static explicit operator int(JToken value)
		{
			return default(int);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x26F9EB0", Offset = "0x26F5EB0", VA = "0x26F9EB0")]
		public static explicit operator short(JToken value)
		{
			return default(short);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x26FA094", Offset = "0x26F6094", VA = "0x26FA094")]
		[CLSCompliant(false)]
		public static explicit operator ushort(JToken value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x26FA278", Offset = "0x26F6278", VA = "0x26FA278")]
		[CLSCompliant(false)]
		public static explicit operator char(JToken value)
		{
			return default(char);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x26FA45C", Offset = "0x26F645C", VA = "0x26FA45C")]
		public static explicit operator byte(JToken value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x26FA640", Offset = "0x26F6640", VA = "0x26FA640")]
		[CLSCompliant(false)]
		public static explicit operator sbyte(JToken value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x26FA824", Offset = "0x26F6824", VA = "0x26FA824")]
		public static explicit operator int?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x26FAA48", Offset = "0x26F6A48", VA = "0x26FAA48")]
		public static explicit operator short?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x26FAC6C", Offset = "0x26F6C6C", VA = "0x26FAC6C")]
		[CLSCompliant(false)]
		public static explicit operator ushort?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x26FAE90", Offset = "0x26F6E90", VA = "0x26FAE90")]
		public static explicit operator byte?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x26FB0B4", Offset = "0x26F70B4", VA = "0x26FB0B4")]
		[CLSCompliant(false)]
		public static explicit operator sbyte?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x26FB2D8", Offset = "0x26F72D8", VA = "0x26FB2D8")]
		public static explicit operator DateTime(JToken value)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x26FB4CC", Offset = "0x26F74CC", VA = "0x26FB4CC")]
		public static explicit operator long?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x26FB6F0", Offset = "0x26F76F0", VA = "0x26FB6F0")]
		public static explicit operator float?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x26FB910", Offset = "0x26F7910", VA = "0x26FB910")]
		public static explicit operator decimal(JToken value)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x26FBAF4", Offset = "0x26F7AF4", VA = "0x26FBAF4")]
		[CLSCompliant(false)]
		public static explicit operator uint?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x26FBD18", Offset = "0x26F7D18", VA = "0x26FBD18")]
		[CLSCompliant(false)]
		public static explicit operator ulong?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x26FBF3C", Offset = "0x26F7F3C", VA = "0x26FBF3C")]
		public static explicit operator double(JToken value)
		{
			return default(double);
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x26FC120", Offset = "0x26F8120", VA = "0x26FC120")]
		public static explicit operator float(JToken value)
		{
			return default(float);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x26FC304", Offset = "0x26F8304", VA = "0x26FC304")]
		public static explicit operator string?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x26FC588", Offset = "0x26F8588", VA = "0x26FC588")]
		[CLSCompliant(false)]
		public static explicit operator uint(JToken value)
		{
			return default(uint);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x26FC76C", Offset = "0x26F876C", VA = "0x26FC76C")]
		[CLSCompliant(false)]
		public static explicit operator ulong(JToken value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x26FC950", Offset = "0x26F8950", VA = "0x26FC950")]
		public static explicit operator Guid(JToken value)
		{
			return default(Guid);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x26FCB70", Offset = "0x26F8B70", VA = "0x26FCB70")]
		public static explicit operator Guid?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x26FCDE0", Offset = "0x26F8DE0", VA = "0x26FCDE0")]
		public static explicit operator TimeSpan(JToken value)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x26FCFDC", Offset = "0x26F8FDC", VA = "0x26FCFDC")]
		public static explicit operator TimeSpan?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x26FD214", Offset = "0x26F9214", VA = "0x26FD214")]
		public static explicit operator Uri?(JToken? value)
		{
			return null;
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x26FD408", Offset = "0x26F9408", VA = "0x26FD408")]
		private static BigInteger ToBigInteger(JToken value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x26FD554", Offset = "0x26F9554", VA = "0x26FD554")]
		private static BigInteger? ToBigIntegerNullable(JToken value)
		{
			return null;
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x26FD700", Offset = "0x26F9700", VA = "0x26FD700", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x26FD794", Offset = "0x26F9794", VA = "0x26FD794", Slot = "4")]
		private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x26FD828", Offset = "0x26F9828", VA = "0x26FD828")]
		public JsonReader CreateReader()
		{
			return null;
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x26FD8EC", Offset = "0x26F98EC", VA = "0x26FD8EC")]
		public object ToObject(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x26FE570", Offset = "0x26FA570", VA = "0x26FE570")]
		public object? ToObject(Type? objectType, JsonSerializer jsonSerializer)
		{
			return null;
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x26FE78C", Offset = "0x26FA78C", VA = "0x26FE78C")]
		public static JToken ReadFrom(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x26FE7E4", Offset = "0x26FA7E4", VA = "0x26FE7E4")]
		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x26EFDA8", Offset = "0x26EBDA8", VA = "0x26EFDA8")]
		internal void SetLineInfo(IJsonLineInfo? lineInfo, JsonLoadSettings? settings)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x26FEB00", Offset = "0x26FAB00", VA = "0x26FEB00")]
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x26FEDAC", Offset = "0x26FADAC", VA = "0x26FEDAC", Slot = "6")]
		private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x26FEEA8", Offset = "0x26FAEA8", VA = "0x26FEEA8", Slot = "18")]
		protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x26FEF70", Offset = "0x26FAF70", VA = "0x26FEF70", Slot = "10")]
		private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
		{
			return null;
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x26FEF80", Offset = "0x26FAF80", VA = "0x26FEF80", Slot = "9")]
		private object System.ICloneable.Clone()
		{
			return null;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x26FEF90", Offset = "0x26FAF90", VA = "0x26FEF90")]
		public JToken DeepClone()
		{
			return null;
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x26FEB9C", Offset = "0x26FAB9C", VA = "0x26FEB9C")]
		public void AddAnnotation(object annotation)
		{
		}

		[Token(Token = "0x6000771")]
		public T Annotation<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x26F0998", Offset = "0x26EC998", VA = "0x26F0998")]
		internal void CopyAnnotations(JToken target, JToken source)
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly JToken _root;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string? _initialPath;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private JToken? _parent;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private JToken? _current;

		[Token(Token = "0x1700014B")]
		public JToken? CurrentToken
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x26FF254", Offset = "0x26FB254", VA = "0x26FF254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014C")]
		private int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x26FFD24", Offset = "0x26FBD24", VA = "0x26FFD24", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014D")]
		private int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x26FFDDC", Offset = "0x26FBDDC", VA = "0x26FFDDC", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014E")]
		public override string Path
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x26FFE94", Offset = "0x26FBE94", VA = "0x26FFE94", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x26FD880", Offset = "0x26F9880", VA = "0x26FD880")]
		public JTokenReader(JToken token)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x26FF25C", Offset = "0x26FB25C", VA = "0x26FF25C", Slot = "10")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x26FF394", Offset = "0x26FB394", VA = "0x26FF394")]
		private bool ReadOver(JToken t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x26FFA68", Offset = "0x26FBA68", VA = "0x26FFA68")]
		private bool ReadToEnd()
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x26FFB0C", Offset = "0x26FBB0C", VA = "0x26FFB0C")]
		private JsonToken? GetEndToken(JContainer c)
		{
			return null;
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x26FF32C", Offset = "0x26FB32C", VA = "0x26FF32C")]
		private bool ReadInto(JContainer c)
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x26FFA88", Offset = "0x26FBA88", VA = "0x26FFA88")]
		private bool SetEnd(JContainer c)
		{
			return default(bool);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x26FF448", Offset = "0x26FB448", VA = "0x26FF448")]
		private void SetToken(JToken token)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x26FFC50", Offset = "0x26FBC50", VA = "0x26FFC50")]
		private string? SafeToString(object? value)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x26FFC70", Offset = "0x26FBC70", VA = "0x26FFC70", Slot = "21")]
		private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F0")]
	public enum JTokenType
	{
		[Token(Token = "0x4000368")]
		None,
		[Token(Token = "0x4000369")]
		Object,
		[Token(Token = "0x400036A")]
		Array,
		[Token(Token = "0x400036B")]
		Constructor,
		[Token(Token = "0x400036C")]
		Property,
		[Token(Token = "0x400036D")]
		Comment,
		[Token(Token = "0x400036E")]
		Integer,
		[Token(Token = "0x400036F")]
		Float,
		[Token(Token = "0x4000370")]
		String,
		[Token(Token = "0x4000371")]
		Boolean,
		[Token(Token = "0x4000372")]
		Null,
		[Token(Token = "0x4000373")]
		Undefined,
		[Token(Token = "0x4000374")]
		Date,
		[Token(Token = "0x4000375")]
		Raw,
		[Token(Token = "0x4000376")]
		Bytes,
		[Token(Token = "0x4000377")]
		Guid,
		[Token(Token = "0x4000378")]
		Uri,
		[Token(Token = "0x4000379")]
		TimeSpan
	}
	[Token(Token = "0x20000F1")]
	public class JTokenWriter : JsonWriter
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private JContainer? _token;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private JContainer? _parent;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private JValue? _value;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private JToken? _current;

		[Token(Token = "0x1700014F")]
		public JToken? Token
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x26FFF74", Offset = "0x26FBF74", VA = "0x26FFF74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x26FFF90", Offset = "0x26FBF90", VA = "0x26FFF90")]
		public JTokenWriter()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x26FFFE8", Offset = "0x26FBFE8", VA = "0x26FFFE8", Slot = "6")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x26FFFF0", Offset = "0x26FBFF0", VA = "0x26FFFF0", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x270006C", Offset = "0x26FC06C", VA = "0x270006C")]
		private void AddParent(JContainer container)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x27000A8", Offset = "0x26FC0A8", VA = "0x27000A8")]
		private void RemoveParent()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x27000F8", Offset = "0x26FC0F8", VA = "0x27000F8", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x2700174", Offset = "0x26FC174", VA = "0x2700174", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x2700204", Offset = "0x26FC204", VA = "0x2700204", Slot = "17")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2700208", Offset = "0x26FC208", VA = "0x2700208", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x27002DC", Offset = "0x26FC2DC", VA = "0x27002DC")]
		private void AddRawValue(object? value, JTokenType type, JsonToken token)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x270034C", Offset = "0x26FC34C", VA = "0x270034C")]
		internal void AddJValue(JValue? value, JsonToken token)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x27003D0", Offset = "0x26FC3D0", VA = "0x27003D0", Slot = "62")]
		public override void WriteValue(object? value)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x2700460", Offset = "0x26FC460", VA = "0x2700460", Slot = "21")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x2700484", Offset = "0x26FC484", VA = "0x2700484", Slot = "22")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x27004A8", Offset = "0x26FC4A8", VA = "0x27004A8", Slot = "23")]
		public override void WriteRaw(string? json)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x2700524", Offset = "0x26FC524", VA = "0x2700524", Slot = "63")]
		public override void WriteComment(string? text)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2700558", Offset = "0x26FC558", VA = "0x2700558", Slot = "25")]
		public override void WriteValue(string? value)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x27005DC", Offset = "0x26FC5DC", VA = "0x27005DC", Slot = "26")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x270065C", Offset = "0x26FC65C", VA = "0x270065C", Slot = "27")]
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x27006DC", Offset = "0x26FC6DC", VA = "0x27006DC", Slot = "28")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x27007C8", Offset = "0x26FC7C8", VA = "0x27007C8", Slot = "29")]
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x27008AC", Offset = "0x26FC8AC", VA = "0x27008AC", Slot = "30")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x2700990", Offset = "0x26FC990", VA = "0x2700990", Slot = "31")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2700A7C", Offset = "0x26FCA7C", VA = "0x2700A7C", Slot = "32")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x2700B68", Offset = "0x26FCB68", VA = "0x2700B68", Slot = "33")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x2700BE8", Offset = "0x26FCBE8", VA = "0x2700BE8", Slot = "34")]
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x2700C68", Offset = "0x26FCC68", VA = "0x2700C68", Slot = "35")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2700D5C", Offset = "0x26FCD5C", VA = "0x2700D5C", Slot = "36")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x2700DDC", Offset = "0x26FCDDC", VA = "0x2700DDC", Slot = "37")]
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x2700E5C", Offset = "0x26FCE5C", VA = "0x2700E5C", Slot = "38")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2700F5C", Offset = "0x26FCF5C", VA = "0x2700F5C", Slot = "39")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x2701080", Offset = "0x26FD080", VA = "0x2701080", Slot = "40")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x270117C", Offset = "0x26FD17C", VA = "0x270117C", Slot = "60")]
		public override void WriteValue(byte[]? value)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x27011F8", Offset = "0x26FD1F8", VA = "0x27011F8", Slot = "42")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x27012DC", Offset = "0x26FD2DC", VA = "0x27012DC", Slot = "41")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x27013D8", Offset = "0x26FD3D8", VA = "0x27013D8", Slot = "61")]
		public override void WriteValue(Uri? value)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x27014D4", Offset = "0x26FD4D4", VA = "0x27014D4", Slot = "16")]
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
	{
		[Token(Token = "0x20000F3")]
		private class JValueDynamicProxy : DynamicProxy<JValue>
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x270477C", Offset = "0x270077C", VA = "0x270477C", Slot = "6")]
			public override bool TryConvert(JValue instance, ConvertBinder binder, [NotNullWhen(true)] out object? result)
			{
				return default(bool);
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x2704948", Offset = "0x2700948", VA = "0x2704948", Slot = "5")]
			public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, [NotNullWhen(true)] out object? result)
			{
				return default(bool);
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x27040FC", Offset = "0x27000FC", VA = "0x27040FC")]
			public JValueDynamicProxy()
			{
			}
		}

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private JTokenType _valueType;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object? _value;

		[Token(Token = "0x17000150")]
		public override bool HasValues
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x2701B60", Offset = "0x26FDB60", VA = "0x2701B60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000151")]
		public override JTokenType Type
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x270342C", Offset = "0x26FF42C", VA = "0x270342C", Slot = "12")]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x17000152")]
		public object? Value
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x2703434", Offset = "0x26FF434", VA = "0x2703434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x26F79FC", Offset = "0x26F39FC", VA = "0x26F79FC")]
		internal JValue(object? value, JTokenType type)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x26F7934", Offset = "0x26F3934", VA = "0x26F7934")]
		internal JValue(JValue other, JsonCloneSettings? settings)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2700754", Offset = "0x26FC754", VA = "0x2700754")]
		public JValue(long value)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2700EE0", Offset = "0x26FCEE0", VA = "0x2700EE0")]
		public JValue(decimal value)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2700840", Offset = "0x26FC840", VA = "0x2700840")]
		[CLSCompliant(false)]
		public JValue(ulong value)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2700A08", Offset = "0x26FCA08", VA = "0x2700A08")]
		public JValue(double value)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2700924", Offset = "0x26FC924", VA = "0x2700924")]
		public JValue(float value)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x2701014", Offset = "0x26FD014", VA = "0x2701014")]
		public JValue(DateTime value)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2701104", Offset = "0x26FD104", VA = "0x2701104")]
		public JValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2700AF4", Offset = "0x26FCAF4", VA = "0x2700AF4")]
		public JValue(bool value)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x27005D4", Offset = "0x26FC5D4", VA = "0x27005D4")]
		public JValue(string? value)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x2701360", Offset = "0x26FD360", VA = "0x2701360")]
		public JValue(Guid value)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2701450", Offset = "0x26FD450", VA = "0x2701450")]
		public JValue(Uri? value)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2701270", Offset = "0x26FD270", VA = "0x2701270")]
		public JValue(TimeSpan value)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x26F3128", Offset = "0x26EF128", VA = "0x26F3128")]
		public JValue(object? value)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x2701B68", Offset = "0x26FDB68", VA = "0x2701B68")]
		private static int CompareBigInteger(BigInteger i1, object i2)
		{
			return default(int);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2701E64", Offset = "0x26FDE64", VA = "0x2701E64")]
		internal static int Compare(JTokenType valueType, object? objA, object? objB)
		{
			return default(int);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2702944", Offset = "0x26FE944", VA = "0x2702944")]
		private static int CompareFloat(object objA, object objB)
		{
			return default(int);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x2702A3C", Offset = "0x26FEA3C", VA = "0x2702A3C")]
		private static bool Operation(ExpressionType operation, object? objA, object? objB, out object? result)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2703348", Offset = "0x26FF348", VA = "0x2703348", Slot = "11")]
		internal override JToken CloneToken(JsonCloneSettings? settings)
		{
			return null;
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x26F35DC", Offset = "0x26EF5DC", VA = "0x26F35DC")]
		public static JValue CreateComment(string? value)
		{
			return null;
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x26F14C4", Offset = "0x26ED4C4", VA = "0x26F14C4")]
		public static JValue CreateNull()
		{
			return null;
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x26F3638", Offset = "0x26EF638", VA = "0x26F3638")]
		public static JValue CreateUndefined()
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x270173C", Offset = "0x26FD73C", VA = "0x270173C")]
		private static JTokenType GetValueType(JTokenType? current, object? value)
		{
			return default(JTokenType);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x27033B0", Offset = "0x26FF3B0", VA = "0x27033B0")]
		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return default(JTokenType);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x270343C", Offset = "0x26FF43C", VA = "0x270343C", Slot = "17")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2703DB0", Offset = "0x26FFDB0", VA = "0x2703DB0")]
		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x2703E0C", Offset = "0x26FFE0C", VA = "0x2703E0C", Slot = "19")]
		public bool Equals(JValue? other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x2703E1C", Offset = "0x26FFE1C", VA = "0x2703E1C", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x2703EA8", Offset = "0x26FFEA8", VA = "0x2703EA8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x2703EC0", Offset = "0x26FFEC0", VA = "0x2703EC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x2703F28", Offset = "0x26FFF28", VA = "0x2703F28", Slot = "38")]
		public string ToString(IFormatProvider? formatProvider)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x2703F34", Offset = "0x26FFF34", VA = "0x2703F34", Slot = "20")]
		public string? ToString(string? format, IFormatProvider? formatProvider)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x270404C", Offset = "0x270004C", VA = "0x270404C", Slot = "18")]
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x2704144", Offset = "0x2700144", VA = "0x2704144", Slot = "21")]
		private int System.IComparable.CompareTo(object? obj)
		{
			return default(int);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x27041F4", Offset = "0x27001F4", VA = "0x27041F4", Slot = "22")]
		public int CompareTo(JValue? obj)
		{
			return default(int);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x2704224", Offset = "0x2700224", VA = "0x2704224", Slot = "23")]
		private TypeCode System.IConvertible.GetTypeCode()
		{
			return default(TypeCode);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x27042E0", Offset = "0x27002E0", VA = "0x27042E0", Slot = "24")]
		private bool System.IConvertible.ToBoolean(IFormatProvider? provider)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x2704334", Offset = "0x2700334", VA = "0x2704334", Slot = "25")]
		private char System.IConvertible.ToChar(IFormatProvider? provider)
		{
			return default(char);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x2704388", Offset = "0x2700388", VA = "0x2704388", Slot = "26")]
		private sbyte System.IConvertible.ToSByte(IFormatProvider? provider)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x27043DC", Offset = "0x27003DC", VA = "0x27043DC", Slot = "27")]
		private byte System.IConvertible.ToByte(IFormatProvider? provider)
		{
			return default(byte);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x2704430", Offset = "0x2700430", VA = "0x2704430", Slot = "28")]
		private short System.IConvertible.ToInt16(IFormatProvider? provider)
		{
			return default(short);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x2704484", Offset = "0x2700484", VA = "0x2704484", Slot = "29")]
		private ushort System.IConvertible.ToUInt16(IFormatProvider? provider)
		{
			return default(ushort);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x27044D8", Offset = "0x27004D8", VA = "0x27044D8", Slot = "30")]
		private int System.IConvertible.ToInt32(IFormatProvider? provider)
		{
			return default(int);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x270452C", Offset = "0x270052C", VA = "0x270452C", Slot = "31")]
		private uint System.IConvertible.ToUInt32(IFormatProvider? provider)
		{
			return default(uint);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x2704580", Offset = "0x2700580", VA = "0x2704580", Slot = "32")]
		private long System.IConvertible.ToInt64(IFormatProvider? provider)
		{
			return default(long);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x27045D4", Offset = "0x27005D4", VA = "0x27045D4", Slot = "33")]
		private ulong System.IConvertible.ToUInt64(IFormatProvider? provider)
		{
			return default(ulong);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x2704628", Offset = "0x2700628", VA = "0x2704628", Slot = "34")]
		private float System.IConvertible.ToSingle(IFormatProvider? provider)
		{
			return default(float);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x270467C", Offset = "0x270067C", VA = "0x270467C", Slot = "35")]
		private double System.IConvertible.ToDouble(IFormatProvider? provider)
		{
			return default(double);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x27046D0", Offset = "0x27006D0", VA = "0x27046D0", Slot = "36")]
		private decimal System.IConvertible.ToDecimal(IFormatProvider? provider)
		{
			return default(decimal);
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x2704724", Offset = "0x2700724", VA = "0x2704724", Slot = "37")]
		private DateTime System.IConvertible.ToDateTime(IFormatProvider? provider)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x2704778", Offset = "0x2700778", VA = "0x2704778", Slot = "39")]
		private object System.IConvertible.ToType(Type conversionType, IFormatProvider? provider)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F4")]
	public enum LineInfoHandling
	{
		[Token(Token = "0x4000381")]
		Ignore,
		[Token(Token = "0x4000382")]
		Load
	}
}
namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F5")]
	public class BinaryConverter : JsonConverter
	{
		[Token(Token = "0x4000383")]
		private const string BinaryTypeName = "System.Data.Linq.Binary";

		[Token(Token = "0x4000384")]
		private const string BinaryToArrayName = "ToArray";

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ReflectionObject? _reflectionObject;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x2704C68", Offset = "0x2700C68", VA = "0x2704C68", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x2704CBC", Offset = "0x2700CBC", VA = "0x2704CBC")]
		private byte[] GetByteArray(object value)
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x2704EA4", Offset = "0x2700EA4", VA = "0x2704EA4")]
		private static void EnsureReflectionObject(Type t)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x2705030", Offset = "0x2701030", VA = "0x2705030", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x270541C", Offset = "0x270141C", VA = "0x270541C")]
		private byte[] ReadByteArray(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x27056A8", Offset = "0x27016A8", VA = "0x27056A8", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x27057C0", Offset = "0x27017C0", VA = "0x27057C0")]
		public BinaryConverter()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonObjectIdConverter : JsonConverter
	{
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x27057C8", Offset = "0x27017C8", VA = "0x27057C8", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x27058BC", Offset = "0x27018BC", VA = "0x27058BC", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x2705A40", Offset = "0x2701A40", VA = "0x2705A40", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x2705AC8", Offset = "0x2701AC8", VA = "0x2705AC8")]
		public BsonObjectIdConverter()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public abstract class CustomCreationConverter<T> : JsonConverter where T : notnull
	{
		[Token(Token = "0x17000153")]
		public override bool CanWrite
		{
			[Token(Token = "0x60007F2")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007EE")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007EF")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007F0")]
		public abstract T Create(Type objectType);

		[Token(Token = "0x60007F1")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F3")]
		protected CustomCreationConverter()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class DataSetConverter : JsonConverter
	{
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2705AD0", Offset = "0x2701AD0", VA = "0x2705AD0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2705F38", Offset = "0x2701F38", VA = "0x2705F38", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x2706220", Offset = "0x2702220", VA = "0x2706220", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x27062B4", Offset = "0x27022B4", VA = "0x27062B4")]
		public DataSetConverter()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class DataTableConverter : JsonConverter
	{
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x27062BC", Offset = "0x27022BC", VA = "0x27062BC", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x2706A14", Offset = "0x2702A14", VA = "0x2706A14", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x2706D00", Offset = "0x2702D00", VA = "0x2706D00")]
		private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x2707220", Offset = "0x2703220", VA = "0x2707220")]
		private static Type GetColumnDataType(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x27073EC", Offset = "0x27033EC", VA = "0x27073EC", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x2705F30", Offset = "0x2701F30", VA = "0x2705F30")]
		public DataTableConverter()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public abstract class DateTimeConverterBase : JsonConverter
	{
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2707480", Offset = "0x2703480", VA = "0x2707480", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x27075F4", Offset = "0x27035F4", VA = "0x27075F4")]
		protected DateTimeConverterBase()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class DiscriminatedUnionConverter : JsonConverter
	{
		[Token(Token = "0x20000FC")]
		internal class Union
		{
			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly FSharpFunction TagReader;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly List<UnionCase> Cases;

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x2707FA0", Offset = "0x2703FA0", VA = "0x2707FA0")]
			public Union(FSharpFunction tagReader, List<UnionCase> cases)
			{
			}
		}

		[Token(Token = "0x20000FD")]
		internal class UnionCase
		{
			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly int Tag;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly string Name;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public readonly PropertyInfo[] Fields;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public readonly FSharpFunction FieldReader;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public readonly FSharpFunction Constructor;

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x2707FCC", Offset = "0x2703FCC", VA = "0x2707FCC")]
			public UnionCase(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor)
			{
			}
		}

		[Token(Token = "0x4000386")]
		private const string CasePropertyName = "Case";

		[Token(Token = "0x4000387")]
		private const string FieldsPropertyName = "Fields";

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<Type, Union> UnionCache;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache;

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x27075FC", Offset = "0x27035FC", VA = "0x27075FC")]
		private static Type CreateUnionTypeLookup(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x27077FC", Offset = "0x27037FC", VA = "0x27077FC")]
		private static Union CreateUnion(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x270801C", Offset = "0x270401C", VA = "0x270801C", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x27084D0", Offset = "0x27044D0", VA = "0x27084D0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x2708B0C", Offset = "0x2704B0C", VA = "0x2708B0C", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x2708D9C", Offset = "0x2704D9C", VA = "0x2708D9C")]
		public DiscriminatedUnionConverter()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class EntityKeyMemberConverter : JsonConverter
	{
		[Token(Token = "0x4000394")]
		private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";

		[Token(Token = "0x4000395")]
		private const string KeyPropertyName = "Key";

		[Token(Token = "0x4000396")]
		private const string TypePropertyName = "Type";

		[Token(Token = "0x4000397")]
		private const string ValuePropertyName = "Value";

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ReflectionObject? _reflectionObject;

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x2708F60", Offset = "0x2704F60", VA = "0x2708F60", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x27093AC", Offset = "0x27053AC", VA = "0x27093AC")]
		private static void ReadAndAssertProperty(JsonReader reader, string propertyName)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x2709498", Offset = "0x2705498", VA = "0x2709498", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x27092CC", Offset = "0x27052CC", VA = "0x27092CC")]
		private static void EnsureReflectionObject(Type objectType)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x2709758", Offset = "0x2705758", VA = "0x2709758", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x27097A8", Offset = "0x27057A8", VA = "0x27097A8")]
		public EntityKeyMemberConverter()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class ExpandoObjectConverter : JsonConverter
	{
		[Token(Token = "0x17000154")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x2709CE0", Offset = "0x2705CE0", VA = "0x2709CE0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x27097B0", Offset = "0x27057B0", VA = "0x27097B0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x27097B4", Offset = "0x27057B4", VA = "0x27097B4", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x27097B8", Offset = "0x27057B8", VA = "0x27097B8")]
		private object ReadValue(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x2709AD0", Offset = "0x2705AD0", VA = "0x2709AD0")]
		private object ReadList(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x2709914", Offset = "0x2705914", VA = "0x2709914")]
		private object ReadObject(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x2709C58", Offset = "0x2705C58", VA = "0x2709C58", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x2709CE8", Offset = "0x2705CE8", VA = "0x2709CE8")]
		public ExpandoObjectConverter()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		[Token(Token = "0x4000399")]
		private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DateTimeStyles _dateTimeStyles;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string? _dateTimeFormat;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CultureInfo? _culture;

		[Token(Token = "0x17000155")]
		public DateTimeStyles DateTimeStyles
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x2709CF0", Offset = "0x2705CF0", VA = "0x2709CF0")]
			get
			{
				return default(DateTimeStyles);
			}
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x2709CF8", Offset = "0x2705CF8", VA = "0x2709CF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public string? DateTimeFormat
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x2709D00", Offset = "0x2705D00", VA = "0x2709D00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x2709D54", Offset = "0x2705D54", VA = "0x2709D54")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public CultureInfo Culture
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x2709D90", Offset = "0x2705D90", VA = "0x2709D90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x2709DF8", Offset = "0x2705DF8", VA = "0x2709DF8")]
			set
			{
			}
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2709E00", Offset = "0x2705E00", VA = "0x2709E00", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x270A068", Offset = "0x2706068", VA = "0x270A068", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x270A580", Offset = "0x2706580", VA = "0x270A580")]
		public IsoDateTimeConverter()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class JavaScriptDateTimeConverter : DateTimeConverterBase
	{
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x270A590", Offset = "0x2706590", VA = "0x270A590", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x270A774", Offset = "0x2706774", VA = "0x270A774", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x270AAA4", Offset = "0x2706AA4", VA = "0x270AAA4")]
		public JavaScriptDateTimeConverter()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class KeyValuePairConverter : JsonConverter
	{
		[Token(Token = "0x400039D")]
		private const string KeyName = "Key";

		[Token(Token = "0x400039E")]
		private const string ValueName = "Value";

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x270AAAC", Offset = "0x2706AAC", VA = "0x270AAAC")]
		private static ReflectionObject InitializeReflectionObject(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x270ACF4", Offset = "0x2706CF4", VA = "0x270ACF4", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x270AF54", Offset = "0x2706F54", VA = "0x270AF54", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x270B404", Offset = "0x2707404", VA = "0x270B404", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x270B51C", Offset = "0x270751C", VA = "0x270B51C")]
		public KeyValuePairConverter()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class RegexConverter : JsonConverter
	{
		[Token(Token = "0x40003A0")]
		private const string PatternName = "Pattern";

		[Token(Token = "0x40003A1")]
		private const string OptionsName = "Options";

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x270B600", Offset = "0x2707600", VA = "0x270B600", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x270BA08", Offset = "0x2707A08", VA = "0x270BA08")]
		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			return default(bool);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x270B718", Offset = "0x2707718", VA = "0x270B718")]
		private void WriteBson(BsonWriter writer, Regex regex)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x270B84C", Offset = "0x270784C", VA = "0x270B84C")]
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x270BAC4", Offset = "0x2707AC4", VA = "0x270BAC4", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x270BDDC", Offset = "0x2707DDC", VA = "0x270BDDC")]
		private object ReadRegexString(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x270BB70", Offset = "0x2707B70", VA = "0x270BB70")]
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x270BF40", Offset = "0x2707F40", VA = "0x270BF40", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x270BFBC", Offset = "0x2707FBC", VA = "0x270BFBC")]
		private bool IsRegex(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x270C044", Offset = "0x2708044", VA = "0x270C044")]
		public RegexConverter()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class StringEnumConverter : JsonConverter
	{
		[Token(Token = "0x17000158")]
		[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
		public bool CamelCaseText
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x270C04C", Offset = "0x270804C", VA = "0x270C04C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x270C0C8", Offset = "0x27080C8", VA = "0x270C0C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public NamingStrategy? NamingStrategy
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x270C198", Offset = "0x2708198", VA = "0x270C198")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x270C1A0", Offset = "0x27081A0", VA = "0x270C1A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public bool AllowIntegerValues
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x270C1A8", Offset = "0x27081A8", VA = "0x270C1A8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x270C1B0", Offset = "0x27081B0", VA = "0x270C1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x270C1B8", Offset = "0x27081B8", VA = "0x270C1B8")]
		public StringEnumConverter()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x270C1C8", Offset = "0x27081C8", VA = "0x270C1C8")]
		[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
		public StringEnumConverter(bool camelCaseText)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x270C23C", Offset = "0x270823C", VA = "0x270C23C")]
		public StringEnumConverter(NamingStrategy namingStrategy, bool allowIntegerValues = true)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x270C274", Offset = "0x2708274", VA = "0x270C274")]
		public StringEnumConverter(Type namingStrategyType)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x270C31C", Offset = "0x270831C", VA = "0x270C31C")]
		public StringEnumConverter(Type namingStrategyType, object[] namingStrategyParameters)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x270C3D0", Offset = "0x27083D0", VA = "0x270C3D0")]
		public StringEnumConverter(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x270C490", Offset = "0x2708490", VA = "0x270C490", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x270C694", Offset = "0x2708694", VA = "0x270C694", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x270CB1C", Offset = "0x2708B1C", VA = "0x270CB1C", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000107")]
	public class UnixDateTimeConverter : DateTimeConverterBase
	{
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly DateTime UnixEpoch;

		[Token(Token = "0x1700015B")]
		public bool AllowPreEpoch
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x270CB94", Offset = "0x2708B94", VA = "0x270CB94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x270CB9C", Offset = "0x2708B9C", VA = "0x270CB9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x270CBA4", Offset = "0x2708BA4", VA = "0x270CBA4")]
		public UnixDateTimeConverter()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x270CBC0", Offset = "0x2708BC0", VA = "0x270CBC0")]
		public UnixDateTimeConverter(bool allowPreEpoch)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x270CBE8", Offset = "0x2708BE8", VA = "0x270CBE8", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x270CE54", Offset = "0x2708E54", VA = "0x270CE54", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}
	}
	[Token(Token = "0x2000108")]
	public class VersionConverter : JsonConverter
	{
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x270D2D0", Offset = "0x27092D0", VA = "0x270D2D0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x270D3B8", Offset = "0x27093B8", VA = "0x270D3B8", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x270D63C", Offset = "0x270963C", VA = "0x270D63C", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x270D6C4", Offset = "0x27096C4", VA = "0x270D6C4")]
		public VersionConverter()
		{
		}
	}
	[Token(Token = "0x2000109")]
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly XmlDocument _document;

		[Token(Token = "0x1700015C")]
		public IXmlElement? DocumentElement
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x270DEB4", Offset = "0x2709EB4", VA = "0x270DEB4", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x270D6CC", Offset = "0x27096CC", VA = "0x270D6CC")]
		public XmlDocumentWrapper(XmlDocument document)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x270D720", Offset = "0x2709720", VA = "0x270D720", Slot = "15")]
		public IXmlNode CreateComment(string? data)
		{
			return null;
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x270D7A8", Offset = "0x27097A8", VA = "0x270D7A8", Slot = "16")]
		public IXmlNode CreateTextNode(string? text)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x270D830", Offset = "0x2709830", VA = "0x270D830", Slot = "17")]
		public IXmlNode CreateCDataSection(string? data)
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x270D8B8", Offset = "0x27098B8", VA = "0x270D8B8", Slot = "18")]
		public IXmlNode CreateWhitespace(string? text)
		{
			return null;
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x270D940", Offset = "0x2709940", VA = "0x270D940", Slot = "19")]
		public IXmlNode CreateSignificantWhitespace(string? text)
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x270D9C8", Offset = "0x27099C8", VA = "0x270D9C8", Slot = "20")]
		public IXmlNode CreateXmlDeclaration(string version, string? encoding, string? standalone)
		{
			return null;
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x270DA98", Offset = "0x2709A98", VA = "0x270DA98", Slot = "21")]
		public IXmlNode? CreateXmlDocumentType(string name, string? publicId, string? systemId, string? internalSubset)
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x270DB6C", Offset = "0x2709B6C", VA = "0x270DB6C", Slot = "22")]
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x270DC04", Offset = "0x2709C04", VA = "0x270DC04", Slot = "23")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x270DCB4", Offset = "0x2709CB4", VA = "0x270DCB4", Slot = "24")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x270DD48", Offset = "0x2709D48", VA = "0x270DD48", Slot = "25")]
		public IXmlNode CreateAttribute(string name, string? value)
		{
			return null;
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x270DE08", Offset = "0x2709E08", VA = "0x270DE08", Slot = "26")]
		public IXmlNode CreateAttribute(string qualifiedName, string? namespaceUri, string? value)
		{
			return null;
		}
	}
	[Token(Token = "0x200010A")]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly XmlElement _element;

		[Token(Token = "0x1700015D")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x270E054", Offset = "0x270A054", VA = "0x270E054", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x270DC88", Offset = "0x2709C88", VA = "0x270DC88")]
		public XmlElementWrapper(XmlElement element)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x270DF4C", Offset = "0x2709F4C", VA = "0x270DF4C", Slot = "15")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x270E034", Offset = "0x270A034", VA = "0x270E034", Slot = "16")]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}
	}
	[Token(Token = "0x200010B")]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly XmlDeclaration _declaration;

		[Token(Token = "0x1700015E")]
		public string? Version
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x270E06C", Offset = "0x270A06C", VA = "0x270E06C", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015F")]
		public string? Encoding
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x270E084", Offset = "0x270A084", VA = "0x270E084", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		public string? Standalone
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x270E09C", Offset = "0x270A09C", VA = "0x270E09C", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x270DA6C", Offset = "0x2709A6C", VA = "0x270DA6C")]
		public XmlDeclarationWrapper(XmlDeclaration declaration)
		{
		}
	}
	[Token(Token = "0x200010C")]
	internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly XmlDocumentType _documentType;

		[Token(Token = "0x17000161")]
		public string Name
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x270E0B4", Offset = "0x270A0B4", VA = "0x270E0B4", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000162")]
		public string? System
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x270E0D0", Offset = "0x270A0D0", VA = "0x270E0D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000163")]
		public string? Public
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x270E0E8", Offset = "0x270A0E8", VA = "0x270E0E8", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000164")]
		public string? InternalSubset
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x270E100", Offset = "0x270A100", VA = "0x270E100", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000165")]
		public override string? LocalName
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x270E118", Offset = "0x270A118", VA = "0x270E118", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x270DB40", Offset = "0x2709B40", VA = "0x270DB40")]
		public XmlDocumentTypeWrapper(XmlDocumentType documentType)
		{
		}
	}
	[Token(Token = "0x200010D")]
	internal class XmlNodeWrapper : IXmlNode
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly XmlNode _node;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<IXmlNode>? _childNodes;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<IXmlNode>? _attributes;

		[Token(Token = "0x17000166")]
		public object? WrappedNode
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x270E158", Offset = "0x270A158", VA = "0x270E158", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000167")]
		public XmlNodeType NodeType
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x270E160", Offset = "0x270A160", VA = "0x270E160", Slot = "4")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x17000168")]
		public virtual string? LocalName
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x270E17C", Offset = "0x270A17C", VA = "0x270E17C", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000169")]
		public List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x270E19C", Offset = "0x270A19C", VA = "0x270E19C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016A")]
		public List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x270E6FC", Offset = "0x270A6FC", VA = "0x270E6FC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016B")]
		private bool HasAttributes
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x270EAE0", Offset = "0x270AAE0", VA = "0x270EAE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016C")]
		public IXmlNode? ParentNode
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x270EB90", Offset = "0x270AB90", VA = "0x270EB90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016D")]
		public string? Value
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x270EC44", Offset = "0x270AC44", VA = "0x270EC44", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x270DDEC", Offset = "0x2709DEC", VA = "0x270DDEC", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public string? NamespaceUri
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x270ED04", Offset = "0x270AD04", VA = "0x270ED04", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x270D6F8", Offset = "0x27096F8", VA = "0x270D6F8")]
		public XmlNodeWrapper(XmlNode node)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x270E588", Offset = "0x270A588", VA = "0x270E588")]
		internal static IXmlNode WrapNode(XmlNode node)
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x270EC60", Offset = "0x270AC60", VA = "0x270EC60", Slot = "10")]
		public IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
	[Token(Token = "0x200010E")]
	internal interface IXmlDocument : IXmlNode
	{
		[Token(Token = "0x1700016F")]
		IXmlElement? DocumentElement
		{
			[Token(Token = "0x6000886")]
			get;
		}

		[Token(Token = "0x600087A")]
		IXmlNode CreateComment(string? text);

		[Token(Token = "0x600087B")]
		IXmlNode CreateTextNode(string? text);

		[Token(Token = "0x600087C")]
		IXmlNode CreateCDataSection(string? data);

		[Token(Token = "0x600087D")]
		IXmlNode CreateWhitespace(string? text);

		[Token(Token = "0x600087E")]
		IXmlNode CreateSignificantWhitespace(string? text);

		[Token(Token = "0x600087F")]
		IXmlNode CreateXmlDeclaration(string version, string? encoding, string? standalone);

		[Token(Token = "0x6000880")]
		IXmlNode? CreateXmlDocumentType(string name, string? publicId, string? systemId, string? internalSubset);

		[Token(Token = "0x6000881")]
		IXmlNode CreateProcessingInstruction(string target, string data);

		[Token(Token = "0x6000882")]
		IXmlElement CreateElement(string elementName);

		[Token(Token = "0x6000883")]
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		[Token(Token = "0x6000884")]
		IXmlNode CreateAttribute(string name, string value);

		[Token(Token = "0x6000885")]
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
	}
	[Token(Token = "0x200010F")]
	internal interface IXmlDeclaration : IXmlNode
	{
		[Token(Token = "0x17000170")]
		string? Version
		{
			[Token(Token = "0x6000887")]
			get;
		}

		[Token(Token = "0x17000171")]
		string? Encoding
		{
			[Token(Token = "0x6000888")]
			get;
		}

		[Token(Token = "0x17000172")]
		string? Standalone
		{
			[Token(Token = "0x6000889")]
			get;
		}
	}
	[Token(Token = "0x2000110")]
	internal interface IXmlDocumentType : IXmlNode
	{
		[Token(Token = "0x17000173")]
		string Name
		{
			[Token(Token = "0x600088A")]
			get;
		}

		[Token(Token = "0x17000174")]
		string? System
		{
			[Token(Token = "0x600088B")]
			get;
		}

		[Token(Token = "0x17000175")]
		string? Public
		{
			[Token(Token = "0x600088C")]
			get;
		}

		[Token(Token = "0x17000176")]
		string? InternalSubset
		{
			[Token(Token = "0x600088D")]
			get;
		}
	}
	[Token(Token = "0x2000111")]
	internal interface IXmlElement : IXmlNode
	{
		[Token(Token = "0x17000177")]
		bool IsEmpty
		{
			[Token(Token = "0x6000890")]
			get;
		}

		[Token(Token = "0x600088E")]
		void SetAttributeNode(IXmlNode attribute);

		[Token(Token = "0x600088F")]
		string GetPrefixOfNamespace(string namespaceUri);
	}
	[Token(Token = "0x2000112")]
	internal interface IXmlNode
	{
		[Token(Token = "0x17000178")]
		XmlNodeType NodeType
		{
			[Token(Token = "0x6000891")]
			get;
		}

		[Token(Token = "0x17000179")]
		string? LocalName
		{
			[Token(Token = "0x6000892")]
			get;
		}

		[Token(Token = "0x1700017A")]
		List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000893")]
			get;
		}

		[Token(Token = "0x1700017B")]
		List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000894")]
			get;
		}

		[Token(Token = "0x1700017C")]
		IXmlNode? ParentNode
		{
			[Token(Token = "0x6000895")]
			get;
		}

		[Token(Token = "0x1700017D")]
		string? Value
		{
			[Token(Token = "0x6000896")]
			get;
		}

		[Token(Token = "0x1700017E")]
		string? NamespaceUri
		{
			[Token(Token = "0x6000898")]
			get;
		}

		[Token(Token = "0x1700017F")]
		object? WrappedNode
		{
			[Token(Token = "0x6000899")]
			get;
		}

		[Token(Token = "0x6000897")]
		IXmlNode AppendChild(IXmlNode newChild);
	}
	[Token(Token = "0x2000113")]
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		[Token(Token = "0x17000180")]
		internal XDeclaration Declaration
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x270ED24", Offset = "0x270AD24", VA = "0x270ED24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000181")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x270ED7C", Offset = "0x270AD7C", VA = "0x270ED7C", Slot = "13")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x17000182")]
		public string? Version
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x270ED84", Offset = "0x270AD84", VA = "0x270ED84", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		public string? Encoding
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x270ED9C", Offset = "0x270AD9C", VA = "0x270ED9C", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		public string? Standalone
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x270EDB4", Offset = "0x270ADB4", VA = "0x270EDB4", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x270ED2C", Offset = "0x270AD2C", VA = "0x270ED2C")]
		public XDeclarationWrapper(XDeclaration declaration)
		{
		}
	}
	[Token(Token = "0x2000114")]
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly XDocumentType _documentType;

		[Token(Token = "0x17000185")]
		public string Name
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x270EDF4", Offset = "0x270ADF4", VA = "0x270EDF4", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000186")]
		public string? System
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x270EE0C", Offset = "0x270AE0C", VA = "0x270EE0C", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000187")]
		public string? Public
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x270EE24", Offset = "0x270AE24", VA = "0x270EE24", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000188")]
		public string? InternalSubset
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x270EE3C", Offset = "0x270AE3C", VA = "0x270EE3C", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000189")]
		public override string? LocalName
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x270EE54", Offset = "0x270AE54", VA = "0x270EE54", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x270EDCC", Offset = "0x270ADCC", VA = "0x270EDCC")]
		public XDocumentTypeWrapper(XDocumentType documentType)
		{
		}
	}
	[Token(Token = "0x2000115")]
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
	{
		[Token(Token = "0x1700018A")]
		private XDocument Document
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x270EE94", Offset = "0x270AE94", VA = "0x270EE94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018B")]
		public override List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x270EF5C", Offset = "0x270AF5C", VA = "0x270EF5C", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018C")]
		protected override bool HasChildNodes
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x270F490", Offset = "0x270B490", VA = "0x270F490", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700018D")]
		public IXmlElement? DocumentElement
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x270FCF4", Offset = "0x270BCF4", VA = "0x270FCF4", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x270EF0C", Offset = "0x270AF0C", VA = "0x270EF0C")]
		public XDocumentWrapper(XDocument document)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x270F4F4", Offset = "0x270B4F4", VA = "0x270F4F4", Slot = "22")]
		public IXmlNode CreateComment(string? text)
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x270F584", Offset = "0x270B584", VA = "0x270F584", Slot = "23")]
		public IXmlNode CreateTextNode(string? text)
		{
			return null;
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x270F614", Offset = "0x270B614", VA = "0x270F614", Slot = "24")]
		public IXmlNode CreateCDataSection(string? data)
		{
			return null;
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x270F6A4", Offset = "0x270B6A4", VA = "0x270F6A4", Slot = "25")]
		public IXmlNode CreateWhitespace(string? text)
		{
			return null;
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x270F734", Offset = "0x270B734", VA = "0x270F734", Slot = "26")]
		public IXmlNode CreateSignificantWhitespace(string? text)
		{
			return null;
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x270F7C4", Offset = "0x270B7C4", VA = "0x270F7C4", Slot = "27")]
		public IXmlNode CreateXmlDeclaration(string version, string? encoding, string? standalone)
		{
			return null;
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x270F86C", Offset = "0x270B86C", VA = "0x270F86C", Slot = "28")]
		public IXmlNode? CreateXmlDocumentType(string name, string? publicId, string? systemId, string? internalSubset)
		{
			return null;
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x270F91C", Offset = "0x270B91C", VA = "0x270F91C", Slot = "29")]
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x270F9DC", Offset = "0x270B9DC", VA = "0x270F9DC", Slot = "30")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x270FAA8", Offset = "0x270BAA8", VA = "0x270FAA8", Slot = "31")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x270FB5C", Offset = "0x270BB5C", VA = "0x270FB5C", Slot = "32")]
		public IXmlNode CreateAttribute(string name, string value)
		{
			return null;
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x270FC30", Offset = "0x270BC30", VA = "0x270FC30", Slot = "33")]
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x270FD90", Offset = "0x270BD90", VA = "0x270FD90", Slot = "19")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
	[Token(Token = "0x2000116")]
	internal class XTextWrapper : XObjectWrapper
	{
		[Token(Token = "0x1700018E")]
		private XText Text
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x270FF00", Offset = "0x270BF00", VA = "0x270FF00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018F")]
		public override string? Value
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x270FFA0", Offset = "0x270BFA0", VA = "0x270FFA0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000190")]
		public override IXmlNode? ParentNode
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x270FFBC", Offset = "0x270BFBC", VA = "0x270FFBC", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x270FF78", Offset = "0x270BF78", VA = "0x270FF78")]
		public XTextWrapper(XText text)
		{
		}
	}
	[Token(Token = "0x2000117")]
	internal class XCommentWrapper : XObjectWrapper
	{
		[Token(Token = "0x17000191")]
		private XComment Text
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x2710308", Offset = "0x270C308", VA = "0x2710308")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000192")]
		public override string? Value
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x27103A8", Offset = "0x270C3A8", VA = "0x27103A8", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000193")]
		public override IXmlNode? ParentNode
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x27103C4", Offset = "0x270C3C4", VA = "0x27103C4", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x2710380", Offset = "0x270C380", VA = "0x2710380")]
		public XCommentWrapper(XComment text)
		{
		}
	}
	[Token(Token = "0x2000118")]
	internal class XProcessingInstructionWrapper : XObjectWrapper
	{
		[Token(Token = "0x17000194")]
		private XProcessingInstruction ProcessingInstruction
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x2710408", Offset = "0x270C408", VA = "0x2710408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000195")]
		public override string? LocalName
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x2710480", Offset = "0x270C480", VA = "0x2710480", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000196")]
		public override string? Value
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x271049C", Offset = "0x270C49C", VA = "0x271049C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x270F9B4", Offset = "0x270B9B4", VA = "0x270F9B4")]
		public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction)
		{
		}
	}
	[Token(Token = "0x2000119")]
	internal class XContainerWrapper : XObjectWrapper
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<IXmlNode>? _childNodes;

		[Token(Token = "0x17000197")]
		private XContainer Container
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x27104B8", Offset = "0x270C4B8", VA = "0x27104B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000198")]
		public override List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x270F0CC", Offset = "0x270B0CC", VA = "0x270F0CC", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000199")]
		protected virtual bool HasChildNodes
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x270F4CC", Offset = "0x270B4CC", VA = "0x270F4CC", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019A")]
		public override IXmlNode? ParentNode
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x2710530", Offset = "0x270C530", VA = "0x2710530", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x270EF34", Offset = "0x270AF34", VA = "0x270EF34")]
		public XContainerWrapper(XContainer container)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x2710000", Offset = "0x270C000", VA = "0x2710000")]
		internal static IXmlNode WrapNode(XObject node)
		{
			return null;
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x270FE30", Offset = "0x270BE30", VA = "0x270FE30", Slot = "19")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
	[Token(Token = "0x200011A")]
	internal class XObjectWrapper : IXmlNode
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly XObject? _xmlObject;

		[Token(Token = "0x1700019B")]
		public object? WrappedNode
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x2710574", Offset = "0x270C574", VA = "0x2710574", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019C")]
		public virtual XmlNodeType NodeType
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x271057C", Offset = "0x270C57C", VA = "0x271057C", Slot = "13")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x1700019D")]
		public virtual string? LocalName
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x2710594", Offset = "0x270C594", VA = "0x2710594", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019E")]
		public virtual List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x271059C", Offset = "0x270C59C", VA = "0x271059C", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019F")]
		public virtual List<IXmlNode> Attributes
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x27105F4", Offset = "0x270C5F4", VA = "0x27105F4", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A0")]
		public virtual IXmlNode? ParentNode
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x271064C", Offset = "0x270C64C", VA = "0x271064C", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A1")]
		public virtual string? Value
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x2710654", Offset = "0x270C654", VA = "0x2710654", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A2")]
		public virtual string? NamespaceUri
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x2710694", Offset = "0x270C694", VA = "0x2710694", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x270ED54", Offset = "0x270AD54", VA = "0x270ED54")]
		public XObjectWrapper(XObject? xmlObject)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x271065C", Offset = "0x270C65C", VA = "0x271065C", Slot = "19")]
		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
	[Token(Token = "0x200011B")]
	internal class XAttributeWrapper : XObjectWrapper
	{
		[Token(Token = "0x170001A3")]
		private XAttribute Attribute
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x271069C", Offset = "0x270C69C", VA = "0x271069C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A4")]
		public override string? Value
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x2710714", Offset = "0x270C714", VA = "0x2710714", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A5")]
		public override string? LocalName
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x2710730", Offset = "0x270C730", VA = "0x2710730", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A6")]
		public override string? NamespaceUri
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x2710754", Offset = "0x270C754", VA = "0x2710754", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A7")]
		public override IXmlNode? ParentNode
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x2710778", Offset = "0x270C778", VA = "0x2710778", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x270FC08", Offset = "0x270BC08", VA = "0x270FC08")]
		public XAttributeWrapper(XAttribute attribute)
		{
		}
	}
	[Token(Token = "0x200011C")]
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<IXmlNode>? _attributes;

		[Token(Token = "0x170001A8")]
		private XElement Element
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x27107BC", Offset = "0x270C7BC", VA = "0x27107BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A9")]
		public override List<IXmlNode> Attributes
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x27108D8", Offset = "0x270C8D8", VA = "0x27108D8", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AA")]
		public override string? Value
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x27112C0", Offset = "0x270D2C0", VA = "0x27112C0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AB")]
		public override string? LocalName
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x27112DC", Offset = "0x270D2DC", VA = "0x27112DC", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AC")]
		public override string? NamespaceUri
		{
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x2711300", Offset = "0x270D300", VA = "0x2711300", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AD")]
		public bool IsEmpty
		{
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x2711324", Offset = "0x270D324", VA = "0x2711324", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x270FA80", Offset = "0x270BA80", VA = "0x270FA80")]
		public XElementWrapper(XElement element)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x2710834", Offset = "0x270C834", VA = "0x2710834", Slot = "22")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x2710DE8", Offset = "0x270CDE8", VA = "0x2710DE8")]
		private bool HasImplicitNamespaceAttribute(string namespaceUri)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x2711298", Offset = "0x270D298", VA = "0x2711298", Slot = "19")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x2711258", Offset = "0x270D258", VA = "0x2711258", Slot = "23")]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}
	}
	[Token(Token = "0x200011D")]
	public class XmlNodeConverter : JsonConverter
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly List<IXmlNode> EmptyChildNodes;

		[Token(Token = "0x40003B3")]
		private const string TextName = "#text";

		[Token(Token = "0x40003B4")]
		private const string CommentName = "#comment";

		[Token(Token = "0x40003B5")]
		private const string CDataName = "#cdata-section";

		[Token(Token = "0x40003B6")]
		private const string WhitespaceName = "#whitespace";

		[Token(Token = "0x40003B7")]
		private const string SignificantWhitespaceName = "#significant-whitespace";

		[Token(Token = "0x40003B8")]
		private const string DeclarationName = "?xml";

		[Token(Token = "0x40003B9")]
		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";

		[Token(Token = "0x170001AE")]
		public string? DeserializeRootElementName
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x2711340", Offset = "0x270D340", VA = "0x2711340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x2711348", Offset = "0x270D348", VA = "0x2711348")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AF")]
		public bool WriteArrayAttribute
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x2711350", Offset = "0x270D350", VA = "0x2711350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x2711358", Offset = "0x270D358", VA = "0x2711358")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B0")]
		public bool OmitRootObject
		{
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x2711360", Offset = "0x270D360", VA = "0x2711360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x2711368", Offset = "0x270D368", VA = "0x2711368")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B1")]
		public bool EncodeSpecialCharacters
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x2711370", Offset = "0x270D370", VA = "0x2711370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x2711378", Offset = "0x270D378", VA = "0x2711378")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x2711380", Offset = "0x270D380", VA = "0x2711380", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x27114CC", Offset = "0x270D4CC", VA = "0x27114CC")]
		private IXmlNode WrapXml(object value)
		{
			return null;
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x27115E4", Offset = "0x270D5E4", VA = "0x27115E4")]
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x2713328", Offset = "0x270F328", VA = "0x2713328")]
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x27136B4", Offset = "0x270F6B4", VA = "0x27136B4")]
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x2713B38", Offset = "0x270FB38", VA = "0x2713B38")]
		private bool IsArray(IXmlNode node)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x2713E9C", Offset = "0x270FE9C", VA = "0x2713E9C")]
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x2714848", Offset = "0x2710848", VA = "0x2714848")]
		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames)
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x27149B4", Offset = "0x27109B4", VA = "0x27149B4")]
		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x2711C34", Offset = "0x270DC34", VA = "0x2711C34")]
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x2714A84", Offset = "0x2710A84", VA = "0x2714A84")]
		private static bool AllSameName(IXmlNode node)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x2714FF4", Offset = "0x2710FF4", VA = "0x2714FF4", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x2716310", Offset = "0x2712310", VA = "0x2716310")]
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x271584C", Offset = "0x271184C", VA = "0x271584C")]
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x2718554", Offset = "0x2714554", VA = "0x2718554")]
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string? elementPrefix, Dictionary<string, string?>? attributeNameValues)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x27181D8", Offset = "0x27141D8", VA = "0x27181D8")]
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string? attributePrefix)
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x27168BC", Offset = "0x27128BC", VA = "0x27168BC")]
		private static string ConvertTokenToXmlValue(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x2717840", Offset = "0x2713840", VA = "0x2717840")]
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x2718D78", Offset = "0x2714D78", VA = "0x2718D78")]
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x2717BBC", Offset = "0x2713BBC", VA = "0x2717BBC")]
		private bool ShouldReadInto(JsonReader reader)
		{
			return default(bool);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x2717BFC", Offset = "0x2713BFC", VA = "0x2717BFC")]
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x2716FD0", Offset = "0x2712FD0", VA = "0x2716FD0")]
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x2717468", Offset = "0x2713468", VA = "0x2717468")]
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x2718B8C", Offset = "0x2714B8C", VA = "0x2718B8C")]
		private IXmlElement CreateElement(string elementName, IXmlDocument document, string? elementPrefix, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x2715B94", Offset = "0x2711B94", VA = "0x2715B94")]
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x27190B8", Offset = "0x27150B8", VA = "0x27190B8")]
		private bool IsNamespaceAttribute(string attributeName, [NotNullWhen(true)] out string? prefix)
		{
			return default(bool);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x2714D1C", Offset = "0x2710D1C", VA = "0x2714D1C")]
		private bool ValueAttributes(List<IXmlNode> c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x2719198", Offset = "0x2715198", VA = "0x2719198", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default(bool);
		}

		[MethodImpl(8)]
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x2719240", Offset = "0x2715240", VA = "0x2719240")]
		private bool IsXObject(Type valueType)
		{
			return default(bool);
		}

		[MethodImpl(8)]
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x27192D4", Offset = "0x27152D4", VA = "0x27192D4")]
		private bool IsXmlNode(Type valueType)
		{
			return default(bool);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x2719368", Offset = "0x2715368", VA = "0x2719368")]
		public XmlNodeConverter()
		{
		}
	}
}
namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200011E")]
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonObjectId
	{
		[Token(Token = "0x170001B2")]
		public byte[] Value
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x27193FC", Offset = "0x27153FC", VA = "0x27193FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x2719404", Offset = "0x2715404", VA = "0x2719404")]
		public BsonObjectId(byte[] value)
		{
		}
	}
	[Token(Token = "0x200011F")]
	internal abstract class BsonToken
	{
		[Token(Token = "0x170001B3")]
		public abstract BsonType Type
		{
			[Token(Token = "0x6000910")]
			get;
		}

		[Token(Token = "0x170001B4")]
		public BsonToken Parent
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x27194E0", Offset = "0x27154E0", VA = "0x27194E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x27194E8", Offset = "0x27154E8", VA = "0x27194E8")]
		protected BsonToken()
		{
		}
	}
	[Token(Token = "0x2000120")]
	internal class BsonObject : BsonToken
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<BsonProperty> _children;

		[Token(Token = "0x170001B5")]
		public override BsonType Type
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x2719654", Offset = "0x2715654", VA = "0x2719654", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x27194F0", Offset = "0x27154F0", VA = "0x27194F0")]
		public void Add(string name, BsonToken token)
		{
		}
	}
	[Token(Token = "0x2000121")]
	internal class BsonArray : BsonToken
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<BsonToken> _children;

		[Token(Token = "0x170001B6")]
		public override BsonType Type
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x2719704", Offset = "0x2715704", VA = "0x2719704", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x271965C", Offset = "0x271565C", VA = "0x271965C")]
		public void Add(BsonToken token)
		{
		}
	}
	[Token(Token = "0x2000122")]
	internal class BsonValue : BsonToken
	{
		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly object _value;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly BsonType _type;

		[Token(Token = "0x170001B7")]
		public override BsonType Type
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x271973C", Offset = "0x271573C", VA = "0x271973C", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x271970C", Offset = "0x271570C", VA = "0x271970C")]
		public BsonValue(object value, BsonType type)
		{
		}
	}
	[Token(Token = "0x2000123")]
	internal class BsonString : BsonValue
	{
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x271961C", Offset = "0x271561C", VA = "0x271961C")]
		public BsonString(object value, bool includeLength)
		{
		}
	}
	[Token(Token = "0x2000124")]
	internal class BsonRegex : BsonToken
	{
		[Token(Token = "0x170001B8")]
		public BsonString Pattern
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x2719744", Offset = "0x2715744", VA = "0x2719744")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public BsonString Options
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x271974C", Offset = "0x271574C", VA = "0x271974C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001BA")]
		public override BsonType Type
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x27197FC", Offset = "0x27157FC", VA = "0x27197FC", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x2719754", Offset = "0x2715754", VA = "0x2719754")]
		public BsonRegex(string pattern, string options)
		{
		}
	}
	[Token(Token = "0x2000125")]
	internal class BsonProperty
	{
		[Token(Token = "0x170001BB")]
		public BsonString Name
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x2719804", Offset = "0x2715804", VA = "0x2719804")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001BC")]
		public BsonToken Value
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x271980C", Offset = "0x271580C", VA = "0x271980C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x2719614", Offset = "0x2715614", VA = "0x2719614")]
		public BsonProperty()
		{
		}
	}
	[Token(Token = "0x2000126")]
	internal enum BsonType : sbyte
	{
		[Token(Token = "0x40003CA")]
		Number = 1,
		[Token(Token = "0x40003CB")]
		String = 2,
		[Token(Token = "0x40003CC")]
		Object = 3,
		[Token(Token = "0x40003CD")]
		Array = 4,
		[Token(Token = "0x40003CE")]
		Binary = 5,
		[Token(Token = "0x40003CF")]
		Undefined = 6,
		[Token(Token = "0x40003D0")]
		Oid = 7,
		[Token(Token = "0x40003D1")]
		Boolean = 8,
		[Token(Token = "0x40003D2")]
		Date = 9,
		[Token(Token = "0x40003D3")]
		Null = 10,
		[Token(Token = "0x40003D4")]
		Regex = 11,
		[Token(Token = "0x40003D5")]
		Reference = 12,
		[Token(Token = "0x40003D6")]
		Code = 13,
		[Token(Token = "0x40003D7")]
		Symbol = 14,
		[Token(Token = "0x40003D8")]
		CodeWScope = 15,
		[Token(Token = "0x40003D9")]
		Integer = 16,
		[Token(Token = "0x40003DA")]
		TimeStamp = 17,
		[Token(Token = "0x40003DB")]
		Long = 18,
		[Token(Token = "0x40003DC")]
		MinKey = -1,
		[Token(Token = "0x40003DD")]
		MaxKey = sbyte.MaxValue
	}
	[Token(Token = "0x2000127")]
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonWriter : JsonWriter
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BsonToken _root;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BsonToken _parent;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _propertyName;

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x2719814", Offset = "0x2715814", VA = "0x2719814")]
		private void AddValue(object value, BsonType type)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x2719888", Offset = "0x2715888", VA = "0x2719888")]
		internal void AddToken(BsonToken token)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x2719A4C", Offset = "0x2715A4C", VA = "0x2719A4C")]
		public void WriteObjectId(byte[] value)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x270BA14", Offset = "0x2707A14", VA = "0x270BA14")]
		public void WriteRegex(string pattern, string options)
		{
		}
	}
}
