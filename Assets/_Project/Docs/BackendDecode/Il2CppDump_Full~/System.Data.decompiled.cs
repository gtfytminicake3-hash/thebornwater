using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("4.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x27C48F8", Offset = "0x27C08F8", VA = "0x27C48F8")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte[] NullableFlags;

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x27C4900", Offset = "0x27C0900", VA = "0x27C4900")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte Flag;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x27C4980", Offset = "0x27C0980", VA = "0x27C4980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Token(Token = "0x2000005")]
internal static class SR
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x27C49A8", Offset = "0x27C09A8", VA = "0x27C49A8")]
	internal static string GetString(string name)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x27C49AC", Offset = "0x27C09AC", VA = "0x27C49AC")]
	internal static string Format(string resourceFormat, object p1)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x27C4A1C", Offset = "0x27C0A1C", VA = "0x27C4A1C")]
	internal static string Format(string resourceFormat, object p1, object p2)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x27C4A94", Offset = "0x27C0A94", VA = "0x27C4A94")]
	internal static string Format(string resourceFormat, object p1, object p2, object p3)
	{
		return null;
	}
}
namespace System
{
	[Token(Token = "0x2000006")]
	internal static class LocalAppContextSwitches
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_allowArbitraryTypeInstantiation;

		[Token(Token = "0x17000001")]
		public static bool AllowArbitraryTypeInstantiation
		{
			[MethodImpl(256)]
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x27C4B1C", Offset = "0x27C0B1C", VA = "0x27C4B1C")]
			get
			{
				return default(bool);
			}
		}
	}
	[Token(Token = "0x2000007")]
	internal class LocalAppContext
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_isDisableCachingInitialized;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool s_disableCaching;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static object s_syncObject;

		[Token(Token = "0x17000002")]
		private static bool DisableCaching
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x27C4C4C", Offset = "0x27C0C4C", VA = "0x27C4C4C")]
			get
			{
				return default(bool);
			}
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x27C4B9C", Offset = "0x27C0B9C", VA = "0x27C4B9C")]
		internal static bool GetCachedSwitchValue(string switchName, ref int switchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x27C4BBC", Offset = "0x27C0BBC", VA = "0x27C4BBC")]
		private static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue)
		{
			return default(bool);
		}
	}
}
namespace System.Data
{
	[Token(Token = "0x2000009")]
	[DesignTimeVisible(false)]
	[DefaultProperty("ColumnName")]
	[ToolboxItem(false)]
	public class DataColumn : MarshalByValueComponent
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _allowNull;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _caption;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _columnName;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Type _dataType;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private StorageType _storageType;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal object _defaultValue;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DataSetDateTime _dateTimeMode;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DataExpression _expression;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _maxLength;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _ordinal;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _readOnly;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal Index _sortIndex;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal DataTable _table;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _unique;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		internal MappingType _columnMapping;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal int _hashCode;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		internal int _errors;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool _isSqlType;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool _implementsINullable;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool _implementsIChangeTracking;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool _implementsIRevertibleChangeTracking;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool _implementsIXMLSerializable;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool _defaultValueIsNull;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal List<DataColumn> _dependentColumns;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal PropertyCollection _extendedProperties;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DataStorage _storage;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AutoIncrementValue _autoInc;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal string _columnUri;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string _columnPrefix;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal string _encodedColumnName;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal SimpleType _simpleType;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_objectTypeCount;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly int _objectID;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanging;

		[Token(Token = "0x17000003")]
		[DefaultValue(true)]
		public bool AllowDBNull
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x27C5BCC", Offset = "0x27C1BCC", VA = "0x27C5BCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x27C5BD4", Offset = "0x27C1BD4", VA = "0x27C5BD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		[DefaultValue(false)]
		[RefreshProperties(RefreshProperties.All)]
		public bool AutoIncrement
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x27C6154", Offset = "0x27C2154", VA = "0x27C6154")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x27C616C", Offset = "0x27C216C", VA = "0x27C616C")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		internal object AutoIncrementCurrent
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x27C6FB0", Offset = "0x27C2FB0", VA = "0x27C6FB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x27C7034", Offset = "0x27C3034", VA = "0x27C7034")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		internal AutoIncrementValue AutoInc
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x27C6EBC", Offset = "0x27C2EBC", VA = "0x27C6EBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		[DefaultValue(0L)]
		public long AutoIncrementSeed
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x27C701C", Offset = "0x27C301C", VA = "0x27C701C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x27C7220", Offset = "0x27C3220", VA = "0x27C7220")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		[DefaultValue(1L)]
		public long AutoIncrementStep
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x27C7310", Offset = "0x27C3310", VA = "0x27C7310")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x27C732C", Offset = "0x27C332C", VA = "0x27C732C")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public string Caption
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x27C7424", Offset = "0x27C3424", VA = "0x27C7424")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x27C7440", Offset = "0x27C3440", VA = "0x27C7440")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		[DefaultValue("")]
		[RefreshProperties(RefreshProperties.All)]
		public string ColumnName
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x27C7530", Offset = "0x27C3530", VA = "0x27C7530")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x27C7538", Offset = "0x27C3538", VA = "0x27C7538")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		internal string EncodedColumnName
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x27C7924", Offset = "0x27C3924", VA = "0x27C7924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		internal IFormatProvider FormatProvider
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x27C7138", Offset = "0x27C3138", VA = "0x27C7138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		internal CultureInfo Locale
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x27C74C4", Offset = "0x27C34C4", VA = "0x27C74C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		internal int ObjectID
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x27C7990", Offset = "0x27C3990", VA = "0x27C7990")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000F")]
		[DefaultValue("")]
		public string Prefix
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x27C7998", Offset = "0x27C3998", VA = "0x27C7998")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x27C79A0", Offset = "0x27C39A0", VA = "0x27C79A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		internal bool Computed
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x27C7C68", Offset = "0x27C3C68", VA = "0x27C7C68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		internal DataExpression DataExpression
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x27C7C78", Offset = "0x27C3C78", VA = "0x27C7C78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		[DefaultValue(typeof(string))]
		[RefreshProperties(RefreshProperties.All)]
		[TypeConverter(typeof(ColumnTypeConverter))]
		public Type DataType
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x27C7C80", Offset = "0x27C3C80", VA = "0x27C7C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x27C66CC", Offset = "0x27C26CC", VA = "0x27C66CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		[RefreshProperties(RefreshProperties.All)]
		[DefaultValue(DataSetDateTime.UnspecifiedLocal)]
		public DataSetDateTime DateTimeMode
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x27C8418", Offset = "0x27C4418", VA = "0x27C8418")]
			get
			{
				return default(DataSetDateTime);
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x27C8420", Offset = "0x27C4420", VA = "0x27C8420")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		[TypeConverter(typeof(DefaultValueTypeConverter))]
		public object DefaultValue
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x27C7E98", Offset = "0x27C3E98", VA = "0x27C7E98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x27C7FB4", Offset = "0x27C3FB4", VA = "0x27C7FB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		internal bool DefaultValueIsNull
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x27C8774", Offset = "0x27C4774", VA = "0x27C8774")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		[RefreshProperties(RefreshProperties.All)]
		[DefaultValue("")]
		public string Expression
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x27C877C", Offset = "0x27C477C", VA = "0x27C877C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x27C53C4", Offset = "0x27C13C4", VA = "0x27C53C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		[Browsable(false)]
		public PropertyCollection ExtendedProperties
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x27C8C1C", Offset = "0x27C4C1C", VA = "0x27C8C1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		internal bool HasData
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x27C6670", Offset = "0x27C2670", VA = "0x27C6670")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		internal bool ImplementsINullable
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x27C8C80", Offset = "0x27C4C80", VA = "0x27C8C80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		internal bool ImplementsIChangeTracking
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x27C8C88", Offset = "0x27C4C88", VA = "0x27C8C88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		internal bool ImplementsIRevertibleChangeTracking
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x27C8C90", Offset = "0x27C4C90", VA = "0x27C8C90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		internal bool IsValueType
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x27C8C98", Offset = "0x27C4C98", VA = "0x27C8C98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		internal bool IsSqlType
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x27C8CB0", Offset = "0x27C4CB0", VA = "0x27C8CB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		[DefaultValue(-1)]
		public int MaxLength
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x27C8D34", Offset = "0x27C4D34", VA = "0x27C8D34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x27C8D3C", Offset = "0x27C4D3C", VA = "0x27C8D3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public string Namespace
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x27C9508", Offset = "0x27C5508", VA = "0x27C9508")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x27C9580", Offset = "0x27C5580", VA = "0x27C9580")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public int Ordinal
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x27C96FC", Offset = "0x27C56FC", VA = "0x27C96FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000021")]
		[DefaultValue(false)]
		public bool ReadOnly
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x27C983C", Offset = "0x27C583C", VA = "0x27C983C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x27C8890", Offset = "0x27C4890", VA = "0x27C8890")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Index SortIndex
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x27C9884", Offset = "0x27C5884", VA = "0x27C9884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataTable Table
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x27C9948", Offset = "0x27C5948", VA = "0x27C9948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		internal object this[int record]
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x27C7C10", Offset = "0x27C3C10", VA = "0x27C7C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x27C9A24", Offset = "0x27C5A24", VA = "0x27C9A24")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		[DefaultValue(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool Unique
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x27C9DA4", Offset = "0x27C5DA4", VA = "0x27C9DA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x27C9DAC", Offset = "0x27C5DAC", VA = "0x27C9DAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		internal string XmlDataType
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x27CA288", Offset = "0x27C6288", VA = "0x27CA288")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x27CA290", Offset = "0x27C6290", VA = "0x27CA290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		internal SimpleType SimpleType
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x27CA298", Offset = "0x27C6298", VA = "0x27CA298")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x27C5290", Offset = "0x27C1290", VA = "0x27C5290")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[DefaultValue(MappingType.Element)]
		public virtual MappingType ColumnMapping
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x27CA2A0", Offset = "0x27C62A0", VA = "0x27CA2A0", Slot = "10")]
			get
			{
				return default(MappingType);
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x27CA2A8", Offset = "0x27C62A8", VA = "0x27CA2A8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		internal bool IsCustomType
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x27CB1A0", Offset = "0x27C71A0", VA = "0x27CB1A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		internal bool ImplementsIXMLSerializable
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x27CB2E0", Offset = "0x27C72E0", VA = "0x27CB2E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x27C4E38", Offset = "0x27C0E38", VA = "0x27C4E38")]
		public DataColumn()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x27C51C8", Offset = "0x27C11C8", VA = "0x27C51C8")]
		public DataColumn(string columnName, Type dataType)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x27C4EC8", Offset = "0x27C0EC8", VA = "0x27C4EC8")]
		public DataColumn(string columnName, Type dataType, string expr, MappingType type)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x27C52CC", Offset = "0x27C12CC", VA = "0x27C52CC")]
		private void UpdateColumnType(Type type, StorageType typeCode)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x27C7B48", Offset = "0x27C3B48", VA = "0x27C7B48")]
		internal string GetColumnValueAsString(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x27C8CB8", Offset = "0x27C4CB8", VA = "0x27C8CB8")]
		private void SetMaxLengthSimpleType()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x27C9704", Offset = "0x27C5704", VA = "0x27C9704")]
		internal void SetOrdinalInternal(int ordinal)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x27C9950", Offset = "0x27C5950", VA = "0x27C9950")]
		internal void SetTable(DataTable table)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x27C9A00", Offset = "0x27C5A00", VA = "0x27C9A00")]
		private DataRow GetDataRow(int index)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x27C8B90", Offset = "0x27C4B90", VA = "0x27C8B90")]
		internal void InitializeRecord(int record)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x27C9C7C", Offset = "0x27C5C7C", VA = "0x27C9C7C")]
		internal void SetValue(int record, object value)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x27C9D84", Offset = "0x27C5D84", VA = "0x27C9D84")]
		internal void FreeRecord(int record)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x27CA280", Offset = "0x27C6280", VA = "0x27CA280")]
		internal void InternalUnique(bool value)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x27CA5C0", Offset = "0x27C65C0", VA = "0x27CA5C0")]
		internal void CheckColumnConstraint(DataRow row, DataRowAction action)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x27C9118", Offset = "0x27C5118", VA = "0x27C9118")]
		internal bool CheckMaxLength()
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x27CA68C", Offset = "0x27C668C", VA = "0x27CA68C")]
		internal void CheckMaxLength(DataRow dr)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x27C5D4C", Offset = "0x27C1D4C", VA = "0x27C5D4C")]
		protected internal void CheckNotAllowNull()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x27CA614", Offset = "0x27C6614", VA = "0x27CA614")]
		internal void CheckNullable(DataRow row)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x27CA234", Offset = "0x27C6234", VA = "0x27CA234")]
		protected void CheckUnique()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x27CA85C", Offset = "0x27C685C", VA = "0x27CA85C")]
		internal int Compare(int record1, int record2)
		{
			return default(int);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x27CA878", Offset = "0x27C6878", VA = "0x27CA878")]
		internal bool CompareValueTo(int record1, object value, bool checkType)
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x27CAA58", Offset = "0x27C6A58", VA = "0x27CAA58")]
		internal int CompareValueTo(int record1, object value)
		{
			return default(int);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x27CAA74", Offset = "0x27C6A74", VA = "0x27CAA74")]
		internal object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x27CAA90", Offset = "0x27C6A90", VA = "0x27CAA90")]
		internal void Copy(int srcRecordNo, int dstRecordNo)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x27CAAAC", Offset = "0x27C6AAC", VA = "0x27CAAAC")]
		internal DataColumn Clone()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x27CB050", Offset = "0x27C7050", VA = "0x27CB050")]
		internal object GetAggregateValue(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x27CA708", Offset = "0x27C6708", VA = "0x27CA708")]
		private int GetStringLength(int record)
		{
			return default(int);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x27CB114", Offset = "0x27C7114", VA = "0x27CB114")]
		internal void Init(int record)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x27C6394", Offset = "0x27C2394", VA = "0x27C6394")]
		internal static bool IsAutoIncrementType(Type dataType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x27CB214", Offset = "0x27C7214", VA = "0x27CB214")]
		internal bool IsValueCustomTypeInstance(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x27C7D08", Offset = "0x27C3D08", VA = "0x27C7D08")]
		internal bool IsInRelation()
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x27CB2E8", Offset = "0x27C72E8", VA = "0x27CB2E8")]
		internal bool IsMaxLengthViolated()
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x27CB820", Offset = "0x27C7820", VA = "0x27CB820")]
		internal bool IsNotAllowDBNullViolated()
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x27CB994", Offset = "0x27C7994", VA = "0x27CB994", Slot = "12")]
		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x27C78B0", Offset = "0x27C38B0", VA = "0x27C78B0")]
		protected internal void RaisePropertyChanging(string name)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x27CB9BC", Offset = "0x27C79BC", VA = "0x27CB9BC")]
		private void InsureStorage()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x27CBA34", Offset = "0x27C7A34", VA = "0x27CBA34")]
		internal void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x27CBA70", Offset = "0x27C7A70", VA = "0x27CBA70")]
		internal void OnSetDataSet()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x27CBA74", Offset = "0x27C7A74", VA = "0x27CBA74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x27CBAE8", Offset = "0x27C7AE8", VA = "0x27CBAE8")]
		internal object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x27CBB24", Offset = "0x27C7B24", VA = "0x27CBB24")]
		internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x27C7C2C", Offset = "0x27C3C2C", VA = "0x27C7C2C")]
		internal string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x27CBB68", Offset = "0x27C7B68", VA = "0x27CBB68")]
		internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x27CBBBC", Offset = "0x27C7BBC", VA = "0x27CBBBC")]
		internal object GetEmptyColumnStore(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x27CBBF0", Offset = "0x27C7BF0", VA = "0x27CBBF0")]
		internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x27CBC08", Offset = "0x27C7C08", VA = "0x27CBC08")]
		internal void SetStorage(object store, BitArray nullbits)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x27CBC44", Offset = "0x27C7C44", VA = "0x27CBC44")]
		internal void AddDependentColumn(DataColumn expressionColumn)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x27CBD3C", Offset = "0x27C7D3C", VA = "0x27CBD3C")]
		internal void RemoveDependentColumn(DataColumn expressionColumn)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x27C8A4C", Offset = "0x27C4A4C", VA = "0x27C8A4C")]
		internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression)
		{
		}
	}
	[Token(Token = "0x200000A")]
	internal abstract class AutoIncrementValue
	{
		[Token(Token = "0x1700002B")]
		internal bool Auto
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x27CBDD4", Offset = "0x27C7DD4", VA = "0x27CBDD4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x27CBDDC", Offset = "0x27C7DDC", VA = "0x27CBDDC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		internal abstract object Current
		{
			[Token(Token = "0x600007E")]
			get;
			[Token(Token = "0x600007F")]
			set;
		}

		[Token(Token = "0x1700002D")]
		internal abstract long Seed
		{
			[Token(Token = "0x6000080")]
			get;
			[Token(Token = "0x6000081")]
			set;
		}

		[Token(Token = "0x1700002E")]
		internal abstract long Step
		{
			[Token(Token = "0x6000082")]
			get;
			[Token(Token = "0x6000083")]
			set;
		}

		[Token(Token = "0x1700002F")]
		internal abstract Type DataType
		{
			[Token(Token = "0x6000084")]
			get;
		}

		[Token(Token = "0x6000085")]
		internal abstract void SetCurrent(object value, IFormatProvider formatProvider);

		[Token(Token = "0x6000086")]
		internal abstract void SetCurrentAndIncrement(object value);

		[Token(Token = "0x6000087")]
		internal abstract void MoveAfter();

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x27CAF40", Offset = "0x27C6F40", VA = "0x27CAF40")]
		internal AutoIncrementValue Clone()
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x27CBDE4", Offset = "0x27C7DE4", VA = "0x27CBDE4")]
		protected AutoIncrementValue()
		{
		}
	}
	[Token(Token = "0x200000B")]
	internal sealed class AutoIncrementInt64 : AutoIncrementValue
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long _current;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private long _seed;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long _step;

		[Token(Token = "0x17000030")]
		internal override object Current
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x27CBDEC", Offset = "0x27C7DEC", VA = "0x27CBDEC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x27CBE48", Offset = "0x27C7E48", VA = "0x27CBE48", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		internal override Type DataType
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x27CBEC0", Offset = "0x27C7EC0", VA = "0x27CBEC0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		internal override long Seed
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x27CBF2C", Offset = "0x27C7F2C", VA = "0x27CBF2C", Slot = "6")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x27CBF34", Offset = "0x27C7F34", VA = "0x27CBF34", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		internal override long Step
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x27CC094", Offset = "0x27C8094", VA = "0x27CC094", Slot = "8")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x27CC09C", Offset = "0x27C809C", VA = "0x27CC09C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x27CC15C", Offset = "0x27C815C", VA = "0x27CC15C", Slot = "13")]
		internal override void MoveAfter()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x27CC170", Offset = "0x27C8170", VA = "0x27CC170", Slot = "11")]
		internal override void SetCurrent(object value, IFormatProvider formatProvider)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x27CC1E4", Offset = "0x27C81E4", VA = "0x27CC1E4", Slot = "12")]
		internal override void SetCurrentAndIncrement(object value)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x27CBFC4", Offset = "0x27C7FC4", VA = "0x27CBFC4")]
		private bool BoundaryCheck(BigInteger value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x27C71A4", Offset = "0x27C31A4", VA = "0x27C71A4")]
		public AutoIncrementInt64()
		{
		}
	}
	[Token(Token = "0x200000C")]
	internal sealed class AutoIncrementBigInteger : AutoIncrementValue
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BigInteger _current;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long _seed;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BigInteger _step;

		[Token(Token = "0x17000034")]
		internal override object Current
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x27CC34C", Offset = "0x27C834C", VA = "0x27CC34C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x27CC3A8", Offset = "0x27C83A8", VA = "0x27CC3A8", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		internal override Type DataType
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x27CC420", Offset = "0x27C8420", VA = "0x27CC420", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		internal override long Seed
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x27CC48C", Offset = "0x27C848C", VA = "0x27CC48C", Slot = "6")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x27CC494", Offset = "0x27C8494", VA = "0x27CC494", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		internal override long Step
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x27CC69C", Offset = "0x27C869C", VA = "0x27CC69C", Slot = "8")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x27CC6FC", Offset = "0x27C86FC", VA = "0x27CC6FC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x27CC864", Offset = "0x27C8864", VA = "0x27CC864", Slot = "13")]
		internal override void MoveAfter()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x27CC8E0", Offset = "0x27C88E0", VA = "0x27CC8E0", Slot = "11")]
		internal override void SetCurrent(object value, IFormatProvider formatProvider)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x27CC904", Offset = "0x27C8904", VA = "0x27CC904", Slot = "12")]
		internal override void SetCurrentAndIncrement(object value)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x27CC574", Offset = "0x27C8574", VA = "0x27CC574")]
		private bool BoundaryCheck(BigInteger value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x27C71B4", Offset = "0x27C31B4", VA = "0x27C71B4")]
		public AutoIncrementBigInteger()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class DataException : SystemException
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x27CC9C4", Offset = "0x27C89C4", VA = "0x27CC9C4")]
		protected DataException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x27CC9CC", Offset = "0x27C89CC", VA = "0x27CC9CC")]
		public DataException()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x27CCA28", Offset = "0x27C8A28", VA = "0x27CCA28")]
		public DataException(string s)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x27CCA4C", Offset = "0x27C8A4C", VA = "0x27CCA4C")]
		public DataException(string s, Exception innerException)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	public class ConstraintException : DataException
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x27CCA54", Offset = "0x27C8A54", VA = "0x27CCA54")]
		protected ConstraintException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x27CCA5C", Offset = "0x27C8A5C", VA = "0x27CCA5C")]
		public ConstraintException()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x27CCAB8", Offset = "0x27C8AB8", VA = "0x27CCAB8")]
		public ConstraintException(string s)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class DeletedRowInaccessibleException : DataException
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x27CCADC", Offset = "0x27C8ADC", VA = "0x27CCADC")]
		protected DeletedRowInaccessibleException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x27CCAE4", Offset = "0x27C8AE4", VA = "0x27CCAE4")]
		public DeletedRowInaccessibleException()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x27CCB40", Offset = "0x27C8B40", VA = "0x27CCB40")]
		public DeletedRowInaccessibleException(string s)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class DuplicateNameException : DataException
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x27CCB64", Offset = "0x27C8B64", VA = "0x27CCB64")]
		protected DuplicateNameException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x27CCB6C", Offset = "0x27C8B6C", VA = "0x27CCB6C")]
		public DuplicateNameException()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x27CCBC8", Offset = "0x27C8BC8", VA = "0x27CCBC8")]
		public DuplicateNameException(string s)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class InRowChangingEventException : DataException
	{
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x27CCBEC", Offset = "0x27C8BEC", VA = "0x27CCBEC")]
		protected InRowChangingEventException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x27CCBF4", Offset = "0x27C8BF4", VA = "0x27CCBF4")]
		public InRowChangingEventException()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x27CCC50", Offset = "0x27C8C50", VA = "0x27CCC50")]
		public InRowChangingEventException(string s)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public class InvalidConstraintException : DataException
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x27CCC74", Offset = "0x27C8C74", VA = "0x27CCC74")]
		protected InvalidConstraintException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x27CCC7C", Offset = "0x27C8C7C", VA = "0x27CCC7C")]
		public InvalidConstraintException()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x27CCCD8", Offset = "0x27C8CD8", VA = "0x27CCCD8")]
		public InvalidConstraintException(string s)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public class NoNullAllowedException : DataException
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x27CCCFC", Offset = "0x27C8CFC", VA = "0x27CCCFC")]
		protected NoNullAllowedException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x27CCD04", Offset = "0x27C8D04", VA = "0x27CCD04")]
		public NoNullAllowedException()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x27CCD60", Offset = "0x27C8D60", VA = "0x27CCD60")]
		public NoNullAllowedException(string s)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public class ReadOnlyException : DataException
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x27CCD84", Offset = "0x27C8D84", VA = "0x27CCD84")]
		protected ReadOnlyException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x27CCD8C", Offset = "0x27C8D8C", VA = "0x27CCD8C")]
		public ReadOnlyException()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x27CCDE8", Offset = "0x27C8DE8", VA = "0x27CCDE8")]
		public ReadOnlyException(string s)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public class RowNotInTableException : DataException
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x27CCE0C", Offset = "0x27C8E0C", VA = "0x27CCE0C")]
		protected RowNotInTableException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x27CCE14", Offset = "0x27C8E14", VA = "0x27CCE14")]
		public RowNotInTableException()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x27CCE70", Offset = "0x27C8E70", VA = "0x27CCE70")]
		public RowNotInTableException(string s)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public class VersionNotFoundException : DataException
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x27CCE94", Offset = "0x27C8E94", VA = "0x27CCE94")]
		protected VersionNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x27CCE9C", Offset = "0x27C8E9C", VA = "0x27CCE9C")]
		public VersionNotFoundException()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x27CCEF8", Offset = "0x27C8EF8", VA = "0x27CCEF8")]
		public VersionNotFoundException(string s)
		{
		}
	}
	[Token(Token = "0x2000017")]
	internal static class ExceptionBuilder
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x27CCF1C", Offset = "0x27C8F1C", VA = "0x27CCF1C")]
		private static void TraceException(string trace, Exception e)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x27CCFB4", Offset = "0x27C8FB4", VA = "0x27CCFB4")]
		internal static Exception TraceExceptionAsReturnValue(Exception e)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x27C897C", Offset = "0x27C497C", VA = "0x27C897C")]
		internal static Exception TraceExceptionForCapture(Exception e)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x27C8BCC", Offset = "0x27C4BCC", VA = "0x27C8BCC")]
		internal static Exception TraceExceptionWithoutRethrow(Exception e)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x27CD004", Offset = "0x27C9004", VA = "0x27CD004")]
		internal static Exception _Argument(string error)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x27CD060", Offset = "0x27C9060", VA = "0x27CD060")]
		internal static Exception _Argument(string error, Exception innerException)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x27CD0CC", Offset = "0x27C90CC", VA = "0x27CD0CC")]
		private static Exception _ArgumentNull(string paramName, string msg)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x27CD138", Offset = "0x27C9138", VA = "0x27CD138")]
		internal static Exception _ArgumentOutOfRange(string paramName, string msg)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x27CD1A4", Offset = "0x27C91A4", VA = "0x27CD1A4")]
		private static Exception _IndexOutOfRange(string error)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x27CD200", Offset = "0x27C9200", VA = "0x27CD200")]
		private static Exception _InvalidOperation(string error)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x27CD25C", Offset = "0x27C925C", VA = "0x27CD25C")]
		private static Exception _InvalidEnumArgumentException(string error)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		private static Exception _InvalidEnumArgumentException<T>(T value)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x27CD2B8", Offset = "0x27C92B8", VA = "0x27CD2B8")]
		private static void ThrowDataException(string error, Exception innerException)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x27CD308", Offset = "0x27C9308", VA = "0x27CD308")]
		private static Exception _Data(string error)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x27CD370", Offset = "0x27C9370", VA = "0x27CD370")]
		private static Exception _Constraint(string error)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x27CD3D8", Offset = "0x27C93D8", VA = "0x27CD3D8")]
		private static Exception _InvalidConstraint(string error)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x27CD440", Offset = "0x27C9440", VA = "0x27CD440")]
		private static Exception _DeletedRowInaccessible(string error)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x27CD4A8", Offset = "0x27C94A8", VA = "0x27CD4A8")]
		private static Exception _DuplicateName(string error)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x27CD510", Offset = "0x27C9510", VA = "0x27CD510")]
		private static Exception _InRowChangingEvent(string error)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x27CD578", Offset = "0x27C9578", VA = "0x27CD578")]
		private static Exception _NoNullAllowed(string error)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x27CD5E0", Offset = "0x27C95E0", VA = "0x27CD5E0")]
		private static Exception _ReadOnly(string error)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x27CD648", Offset = "0x27C9648", VA = "0x27CD648")]
		private static Exception _RowNotInTable(string error)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x27CD6B0", Offset = "0x27C96B0", VA = "0x27CD6B0")]
		private static Exception _VersionNotFound(string error)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x27C51D4", Offset = "0x27C11D4", VA = "0x27C51D4")]
		public static Exception ArgumentNull(string paramName)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x27CD718", Offset = "0x27C9718", VA = "0x27CD718")]
		public static Exception ArgumentOutOfRange(string paramName)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x27CD76C", Offset = "0x27C976C", VA = "0x27CD76C")]
		public static Exception BadObjectPropertyAccess(string error)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x27CD7B8", Offset = "0x27C97B8", VA = "0x27CD7B8")]
		public static Exception TypeNotAllowed(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x27CD824", Offset = "0x27C9824", VA = "0x27CD824")]
		public static Exception CaseInsensitiveNameConflict(string name)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x27CD870", Offset = "0x27C9870", VA = "0x27CD870")]
		public static Exception NamespaceNameConflict(string name)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x27CD8BC", Offset = "0x27C98BC", VA = "0x27CD8BC")]
		public static Exception InvalidOffsetLength()
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x27CD8FC", Offset = "0x27C98FC", VA = "0x27CD8FC")]
		public static Exception ColumnNotInTheTable(string column, string table)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x27CD958", Offset = "0x27C9958", VA = "0x27CD958")]
		public static Exception ColumnNotInAnyTable()
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x27CD998", Offset = "0x27C9998", VA = "0x27CD998")]
		public static Exception ColumnOutOfRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x27CDA28", Offset = "0x27C9A28", VA = "0x27CDA28")]
		public static Exception ColumnOutOfRange(string column)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x27CDA74", Offset = "0x27C9A74", VA = "0x27CDA74")]
		public static Exception CannotAddColumn1(string column)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x27CDAC0", Offset = "0x27C9AC0", VA = "0x27CDAC0")]
		public static Exception CannotAddColumn2(string column)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x27CA534", Offset = "0x27C6534", VA = "0x27CA534")]
		public static Exception CannotAddColumn3()
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x27CA574", Offset = "0x27C6574", VA = "0x27CA574")]
		public static Exception CannotAddColumn4(string column)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x27CDB0C", Offset = "0x27C9B0C", VA = "0x27CDB0C")]
		public static Exception CannotAddDuplicate(string column)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x27CDB58", Offset = "0x27C9B58", VA = "0x27CDB58")]
		public static Exception CannotAddDuplicate2(string table)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x27CDBA4", Offset = "0x27C9BA4", VA = "0x27CDBA4")]
		public static Exception CannotAddDuplicate3(string table)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x27CDBF0", Offset = "0x27C9BF0", VA = "0x27CDBF0")]
		public static Exception CannotRemoveColumn()
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x27CDC30", Offset = "0x27C9C30", VA = "0x27CDC30")]
		public static Exception CannotRemovePrimaryKey()
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x27CDC70", Offset = "0x27C9C70", VA = "0x27CDC70")]
		public static Exception CannotRemoveChildKey(string relation)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x27CDCBC", Offset = "0x27C9CBC", VA = "0x27CDCBC")]
		public static Exception CannotRemoveConstraint(string constraint, string table)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x27CDD18", Offset = "0x27C9D18", VA = "0x27CDD18")]
		public static Exception CannotRemoveExpression(string column, string expression)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x27CDD74", Offset = "0x27C9D74", VA = "0x27CDD74")]
		public static Exception AddPrimaryKeyConstraint()
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x27CDDB4", Offset = "0x27C9DB4", VA = "0x27CDDB4")]
		public static Exception NoConstraintName()
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x27CDDF4", Offset = "0x27C9DF4", VA = "0x27CDDF4")]
		public static Exception ConstraintViolation(string constraint)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x27CDE40", Offset = "0x27C9E40", VA = "0x27CDE40")]
		public static string KeysToString(object[] keys)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x27CDF64", Offset = "0x27C9F64", VA = "0x27CDF64")]
		public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x27CE0E0", Offset = "0x27CA0E0", VA = "0x27CE0E0")]
		public static Exception ConstraintViolation(DataColumn[] columns, object[] values)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x27CE0F0", Offset = "0x27CA0F0", VA = "0x27CE0F0")]
		public static Exception ConstraintOutOfRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x27CE180", Offset = "0x27CA180", VA = "0x27CE180")]
		public static Exception DuplicateConstraint(string constraint)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x27CE1CC", Offset = "0x27CA1CC", VA = "0x27CE1CC")]
		public static Exception DuplicateConstraintName(string constraint)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x27CE218", Offset = "0x27CA218", VA = "0x27CE218")]
		public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x27CE2A0", Offset = "0x27CA2A0", VA = "0x27CE2A0")]
		public static Exception UniqueConstraintViolation()
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x27CE2E0", Offset = "0x27CA2E0", VA = "0x27CE2E0")]
		public static Exception ConstraintForeignTable()
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x27CE320", Offset = "0x27CA320", VA = "0x27CE320")]
		public static Exception ConstraintParentValues()
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x27CE360", Offset = "0x27CA360", VA = "0x27CE360")]
		public static Exception ConstraintAddFailed(DataTable table)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x27CE3B4", Offset = "0x27CA3B4", VA = "0x27CE3B4")]
		public static Exception ConstraintRemoveFailed()
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x27CE3F4", Offset = "0x27CA3F4", VA = "0x27CE3F4")]
		public static Exception FailedCascadeDelete(string constraint)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x27CE440", Offset = "0x27CA440", VA = "0x27CE440")]
		public static Exception FailedCascadeUpdate(string constraint)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x27CE48C", Offset = "0x27CA48C", VA = "0x27CE48C")]
		public static Exception FailedClearParentTable(string table, string constraint, string childTable)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x27CE4F0", Offset = "0x27CA4F0", VA = "0x27CE4F0")]
		public static Exception ForeignKeyViolation(string constraint, object[] keys)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x27CE558", Offset = "0x27CA558", VA = "0x27CE558")]
		public static Exception RemoveParentRow(ForeignKeyConstraint constraint)
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x27CB7D8", Offset = "0x27C77D8", VA = "0x27CB7D8")]
		public static string MaxLengthViolationText(string columnName)
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x27CB94C", Offset = "0x27C794C", VA = "0x27CB94C")]
		public static string NotAllowDBNullViolationText(string columnName)
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x27CE5C0", Offset = "0x27CA5C0", VA = "0x27CE5C0")]
		public static Exception CantAddConstraintToMultipleNestedTable(string tableName)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x27C6314", Offset = "0x27C2314", VA = "0x27C6314")]
		public static Exception AutoIncrementAndExpression()
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x27C6354", Offset = "0x27C2354", VA = "0x27C6354")]
		public static Exception AutoIncrementAndDefaultValue()
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x27CC11C", Offset = "0x27C811C", VA = "0x27CC11C")]
		public static Exception AutoIncrementSeed()
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x27C7C88", Offset = "0x27C3C88", VA = "0x27C7C88")]
		public static Exception CantChangeDataType()
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x27C7CC8", Offset = "0x27C3CC8", VA = "0x27C7CC8")]
		public static Exception NullDataType()
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x27C7870", Offset = "0x27C3870", VA = "0x27C7870")]
		public static Exception ColumnNameRequired()
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x27C868C", Offset = "0x27C468C", VA = "0x27C868C")]
		public static Exception DefaultValueAndAutoIncrement()
		{
			return null;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x27C82A8", Offset = "0x27C42A8", VA = "0x27C82A8")]
		public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner)
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x27C86CC", Offset = "0x27C46CC", VA = "0x27C86CC")]
		public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner)
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x27C87D8", Offset = "0x27C47D8", VA = "0x27C87D8")]
		public static Exception ExpressionAndUnique()
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x27C89CC", Offset = "0x27C49CC", VA = "0x27C89CC")]
		public static Exception ExpressionAndReadOnly()
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x27C8818", Offset = "0x27C4818", VA = "0x27C8818")]
		public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x27CE60C", Offset = "0x27CA60C", VA = "0x27CE60C")]
		public static Exception ExpressionInConstraint(DataColumn column)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x27C8A0C", Offset = "0x27C4A0C", VA = "0x27C8A0C")]
		public static Exception ExpressionCircular()
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x27CA810", Offset = "0x27C6810", VA = "0x27CA810")]
		public static Exception NonUniqueValues(string column)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x27CA778", Offset = "0x27C6778", VA = "0x27CA778")]
		public static Exception NullKeyValues(string column)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x27CA7C4", Offset = "0x27C67C4", VA = "0x27CA7C4")]
		public static Exception NullValues(string column)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x27C9844", Offset = "0x27C5844", VA = "0x27C9844")]
		public static Exception ReadOnlyAndExpression()
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x27CE660", Offset = "0x27CA660", VA = "0x27CE660")]
		public static Exception ReadOnly(string column)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x27CA1F4", Offset = "0x27C61F4", VA = "0x27CA1F4")]
		public static Exception UniqueAndExpression()
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x27C9BA4", Offset = "0x27C5BA4", VA = "0x27C9BA4")]
		public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x27CE6AC", Offset = "0x27CA6AC", VA = "0x27CE6AC")]
		public static Exception CannotSetToNull(DataColumn column)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x27CA724", Offset = "0x27C6724", VA = "0x27CA724")]
		public static Exception LongerThanMaxLength(DataColumn column)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x27C9464", Offset = "0x27C5464", VA = "0x27C9464")]
		public static Exception CannotSetMaxLength(DataColumn column, int value)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x27C9070", Offset = "0x27C5070", VA = "0x27C9070")]
		public static Exception CannotSetMaxLength2(DataColumn column)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x27C83BC", Offset = "0x27C43BC", VA = "0x27C83BC")]
		public static Exception CannotSetSimpleContentType(string columnName, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x27CA4D8", Offset = "0x27C64D8", VA = "0x27CA4D8")]
		public static Exception CannotSetSimpleContent(string columnName, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x27C96B0", Offset = "0x27C56B0", VA = "0x27C96B0")]
		public static Exception CannotChangeNamespace(string columnName)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x27C90C4", Offset = "0x27C50C4", VA = "0x27C90C4")]
		public static Exception HasToBeStringType(DataColumn column)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x27C6680", Offset = "0x27C2680", VA = "0x27C6680")]
		public static Exception AutoIncrementCannotSetIfHasData(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x27CE700", Offset = "0x27CA700", VA = "0x27CE700")]
		public static Exception INullableUDTwithoutStaticNull(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x27CE74C", Offset = "0x27CA74C", VA = "0x27CE74C")]
		public static Exception IComparableNotImplemented(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x27CE798", Offset = "0x27CA798", VA = "0x27CE798")]
		public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x27CE7E4", Offset = "0x27CA7E4", VA = "0x27CE7E4")]
		public static Exception InvalidDataColumnMapping(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x27C854C", Offset = "0x27C454C", VA = "0x27C854C")]
		public static Exception CannotSetDateTimeModeForNonDateTimeColumns()
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x27C8644", Offset = "0x27C4644", VA = "0x27C8644")]
		public static Exception InvalidDateTimeMode(DataSetDateTime mode)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x27C858C", Offset = "0x27C458C", VA = "0x27C858C")]
		public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue)
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x27C5228", Offset = "0x27C1228", VA = "0x27C5228")]
		public static Exception ColumnTypeNotSupported()
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x27CE850", Offset = "0x27CA850", VA = "0x27CE850")]
		public static Exception SetFailed(string name)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x27CE89C", Offset = "0x27CA89C", VA = "0x27CE89C")]
		public static Exception CanNotUse()
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x27CE8DC", Offset = "0x27CA8DC", VA = "0x27CE8DC")]
		public static Exception SetIListObject()
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x27CE91C", Offset = "0x27CA91C", VA = "0x27CE91C")]
		public static Exception AddNewNotAllowNull()
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x27CE95C", Offset = "0x27CA95C", VA = "0x27CE95C")]
		public static Exception NotOpen()
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x27CE99C", Offset = "0x27CA99C", VA = "0x27CE99C")]
		public static Exception CreateChildView()
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x27CE9DC", Offset = "0x27CA9DC", VA = "0x27CE9DC")]
		public static Exception CanNotDelete()
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x27CEA1C", Offset = "0x27CAA1C", VA = "0x27CEA1C")]
		public static Exception GetElementIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x27CEAAC", Offset = "0x27CAAAC", VA = "0x27CEAAC")]
		public static Exception AddExternalObject()
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x27CEAEC", Offset = "0x27CAAEC", VA = "0x27CEAEC")]
		public static Exception CanNotClear()
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x27CEB2C", Offset = "0x27CAB2C", VA = "0x27CEB2C")]
		public static Exception InsertExternalObject()
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x27CEB6C", Offset = "0x27CAB6C", VA = "0x27CEB6C")]
		public static Exception RemoveExternalObject()
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x27CEBAC", Offset = "0x27CABAC", VA = "0x27CEBAC")]
		public static Exception KeyTableMismatch()
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x27CEBEC", Offset = "0x27CABEC", VA = "0x27CEBEC")]
		public static Exception KeyNoColumns()
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x27CEC2C", Offset = "0x27CAC2C", VA = "0x27CEC2C")]
		public static Exception KeyTooManyColumns(int cols)
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x27CECBC", Offset = "0x27CACBC", VA = "0x27CECBC")]
		public static Exception KeyDuplicateColumns(string columnName)
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x27CED08", Offset = "0x27CAD08", VA = "0x27CED08")]
		public static Exception RelationDataSetMismatch()
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x27C7E58", Offset = "0x27C3E58", VA = "0x27C7E58")]
		public static Exception ColumnsTypeMismatch()
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x27CED48", Offset = "0x27CAD48", VA = "0x27CED48")]
		public static Exception KeyLengthMismatch()
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x27CED88", Offset = "0x27CAD88", VA = "0x27CED88")]
		public static Exception KeyLengthZero()
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x27CEDC8", Offset = "0x27CADC8", VA = "0x27CEDC8")]
		public static Exception ForeignRelation()
		{
			return null;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x27CEE08", Offset = "0x27CAE08", VA = "0x27CEE08")]
		public static Exception KeyColumnsIdentical()
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x27CEE48", Offset = "0x27CAE48", VA = "0x27CEE48")]
		public static Exception RelationForeignTable(string t1, string t2)
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x27CEEA4", Offset = "0x27CAEA4", VA = "0x27CEEA4")]
		public static Exception GetParentRowTableMismatch(string t1, string t2)
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x27CEF00", Offset = "0x27CAF00", VA = "0x27CEF00")]
		public static Exception SetParentRowTableMismatch(string t1, string t2)
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x27CEF5C", Offset = "0x27CAF5C", VA = "0x27CEF5C")]
		public static Exception RelationForeignRow()
		{
			return null;
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x27CEF9C", Offset = "0x27CAF9C", VA = "0x27CEF9C")]
		public static Exception RelationNestedReadOnly()
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x27CEFDC", Offset = "0x27CAFDC", VA = "0x27CEFDC")]
		public static Exception TableCantBeNestedInTwoTables(string tableName)
		{
			return null;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x27CF028", Offset = "0x27CB028", VA = "0x27CF028")]
		public static Exception LoopInNestedRelations(string tableName)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x27CF074", Offset = "0x27CB074", VA = "0x27CF074")]
		public static Exception RelationDoesNotExist()
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x27CF0B4", Offset = "0x27CB0B4", VA = "0x27CF0B4")]
		public static Exception ParentOrChildColumnsDoNotHaveDataSet()
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x27CF0F4", Offset = "0x27CB0F4", VA = "0x27CF0F4")]
		public static Exception InValidNestedRelation(string childTableName)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x27CF140", Offset = "0x27CB140", VA = "0x27CF140")]
		public static Exception InvalidParentNamespaceinNestedRelation(string childTableName)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x27CF18C", Offset = "0x27CB18C", VA = "0x27CF18C")]
		public static Exception RowNotInTheDataSet()
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x27CF1CC", Offset = "0x27CB1CC", VA = "0x27CF1CC")]
		public static Exception RowNotInTheTable()
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x27CF20C", Offset = "0x27CB20C", VA = "0x27CF20C")]
		public static Exception EditInRowChanging()
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x27CF24C", Offset = "0x27CB24C", VA = "0x27CF24C")]
		public static Exception EndEditInRowChanging()
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x27CF28C", Offset = "0x27CB28C", VA = "0x27CF28C")]
		public static Exception BeginEditInRowChanging()
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x27CF2CC", Offset = "0x27CB2CC", VA = "0x27CF2CC")]
		public static Exception CancelEditInRowChanging()
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x27CF30C", Offset = "0x27CB30C", VA = "0x27CF30C")]
		public static Exception DeleteInRowDeleting()
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x27CF34C", Offset = "0x27CB34C", VA = "0x27CF34C")]
		public static Exception ValueArrayLength()
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x27CF38C", Offset = "0x27CB38C", VA = "0x27CF38C")]
		public static Exception NoCurrentData()
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x27CF3CC", Offset = "0x27CB3CC", VA = "0x27CF3CC")]
		public static Exception NoOriginalData()
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x27CF40C", Offset = "0x27CB40C", VA = "0x27CF40C")]
		public static Exception NoProposedData()
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x27CF44C", Offset = "0x27CB44C", VA = "0x27CF44C")]
		public static Exception RowRemovedFromTheTable()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x27CF48C", Offset = "0x27CB48C", VA = "0x27CF48C")]
		public static Exception DeletedRowInaccessible()
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x27CF4CC", Offset = "0x27CB4CC", VA = "0x27CF4CC")]
		public static Exception RowAlreadyDeleted()
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x27CF50C", Offset = "0x27CB50C", VA = "0x27CF50C")]
		public static Exception RowEmpty()
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x27CF54C", Offset = "0x27CB54C", VA = "0x27CF54C")]
		public static Exception InvalidRowVersion()
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x27CF58C", Offset = "0x27CB58C", VA = "0x27CF58C")]
		public static Exception RowOutOfRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x27CF61C", Offset = "0x27CB61C", VA = "0x27CF61C")]
		public static Exception RowInsertTwice(int index, string tableName)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x27CF6BC", Offset = "0x27CB6BC", VA = "0x27CF6BC")]
		public static Exception RowInsertMissing(string tableName)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x27CF708", Offset = "0x27CB708", VA = "0x27CF708")]
		public static Exception RowAlreadyRemoved()
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x27CF748", Offset = "0x27CB748", VA = "0x27CF748")]
		public static Exception MultipleParents()
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x27CF788", Offset = "0x27CB788", VA = "0x27CF788")]
		public static Exception InvalidRowState(DataRowState state)
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x27CF7D0", Offset = "0x27CB7D0", VA = "0x27CF7D0")]
		public static Exception InvalidRowBitPattern()
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x27CF810", Offset = "0x27CB810", VA = "0x27CF810")]
		internal static Exception SetDataSetNameToEmpty()
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x27CF850", Offset = "0x27CB850", VA = "0x27CF850")]
		internal static Exception SetDataSetNameConflicting(string name)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x27CF89C", Offset = "0x27CB89C", VA = "0x27CF89C")]
		public static Exception DataSetUnsupportedSchema(string ns)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x27CF8E8", Offset = "0x27CB8E8", VA = "0x27CF8E8")]
		public static Exception MergeMissingDefinition(string obj)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x27CF934", Offset = "0x27CB934", VA = "0x27CF934")]
		public static Exception TablesInDifferentSets()
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x27CF974", Offset = "0x27CB974", VA = "0x27CF974")]
		public static Exception RelationAlreadyExists()
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x27CF9B4", Offset = "0x27CB9B4", VA = "0x27CF9B4")]
		public static Exception RowAlreadyInOtherCollection()
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x27CF9F4", Offset = "0x27CB9F4", VA = "0x27CF9F4")]
		public static Exception RowAlreadyInTheCollection()
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x27CFA34", Offset = "0x27CBA34", VA = "0x27CFA34")]
		public static Exception RecordStateRange()
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x27CFA74", Offset = "0x27CBA74", VA = "0x27CFA74")]
		public static Exception IndexKeyLength(int length, int keyLength)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x27CFB50", Offset = "0x27CBB50", VA = "0x27CFB50")]
		public static Exception RemovePrimaryKey(DataTable table)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x27CFBCC", Offset = "0x27CBBCC", VA = "0x27CFBCC")]
		public static Exception RelationAlreadyInOtherDataSet()
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x27CFC0C", Offset = "0x27CBC0C", VA = "0x27CFC0C")]
		public static Exception RelationAlreadyInTheDataSet()
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x27CFC4C", Offset = "0x27CBC4C", VA = "0x27CFC4C")]
		public static Exception RelationNotInTheDataSet(string relation)
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x27CFC98", Offset = "0x27CBC98", VA = "0x27CFC98")]
		public static Exception RelationOutOfRange(object index)
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x27CFD1C", Offset = "0x27CBD1C", VA = "0x27CFD1C")]
		public static Exception DuplicateRelation(string relation)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x27CFD68", Offset = "0x27CBD68", VA = "0x27CFD68")]
		public static Exception RelationTableNull()
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x27CFDA8", Offset = "0x27CBDA8", VA = "0x27CFDA8")]
		public static Exception RelationDataSetNull()
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x27CFDE8", Offset = "0x27CBDE8", VA = "0x27CFDE8")]
		public static Exception RelationTableWasRemoved()
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x27CFE28", Offset = "0x27CBE28", VA = "0x27CFE28")]
		public static Exception ParentTableMismatch()
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x27CFE68", Offset = "0x27CBE68", VA = "0x27CFE68")]
		public static Exception ChildTableMismatch()
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x27CFEA8", Offset = "0x27CBEA8", VA = "0x27CFEA8")]
		public static Exception EnforceConstraint()
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x27CFEE8", Offset = "0x27CBEE8", VA = "0x27CFEE8")]
		public static Exception CaseLocaleMismatch()
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x27CFF28", Offset = "0x27CBF28", VA = "0x27CFF28")]
		public static Exception CannotChangeCaseLocale()
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x27CFF30", Offset = "0x27CBF30", VA = "0x27CFF30")]
		public static Exception CannotChangeCaseLocale(Exception innerException)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x27CFF78", Offset = "0x27CBF78", VA = "0x27CFF78")]
		public static Exception InvalidRemotingFormat(SerializationFormat mode)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x27CFFC0", Offset = "0x27CBFC0", VA = "0x27CFFC0")]
		public static Exception TableForeignPrimaryKey()
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x27D0000", Offset = "0x27CC000", VA = "0x27D0000")]
		public static Exception TableCannotAddToSimpleContent()
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x27D0040", Offset = "0x27CC040", VA = "0x27D0040")]
		public static Exception NoTableName()
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x27D0080", Offset = "0x27CC080", VA = "0x27D0080")]
		public static Exception MultipleTextOnlyColumns()
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x27D00C0", Offset = "0x27CC0C0", VA = "0x27D00C0")]
		public static Exception InvalidSortString(string sort)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x27D010C", Offset = "0x27CC10C", VA = "0x27D010C")]
		public static Exception DuplicateTableName(string table)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x27D0158", Offset = "0x27CC158", VA = "0x27D0158")]
		public static Exception DuplicateTableName2(string table, string ns)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x27D01B4", Offset = "0x27CC1B4", VA = "0x27D01B4")]
		public static Exception SelfnestedDatasetConflictingName(string table)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x27D0200", Offset = "0x27CC200", VA = "0x27D0200")]
		public static Exception DatasetConflictingName(string table)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x27D024C", Offset = "0x27CC24C", VA = "0x27D024C")]
		public static Exception TableAlreadyInOtherDataSet()
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x27D028C", Offset = "0x27CC28C", VA = "0x27D028C")]
		public static Exception TableAlreadyInTheDataSet()
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x27D02CC", Offset = "0x27CC2CC", VA = "0x27D02CC")]
		public static Exception TableOutOfRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x27D035C", Offset = "0x27CC35C", VA = "0x27D035C")]
		public static Exception TableNotInTheDataSet(string table)
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x27D03A8", Offset = "0x27CC3A8", VA = "0x27D03A8")]
		public static Exception TableInRelation()
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x27D03E8", Offset = "0x27CC3E8", VA = "0x27D03E8")]
		public static Exception TableInConstraint(DataTable table, Constraint constraint)
		{
			return null;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x27D0460", Offset = "0x27CC460", VA = "0x27D0460")]
		public static Exception CanNotSerializeDataTableHierarchy()
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x27D04A0", Offset = "0x27CC4A0", VA = "0x27D04A0")]
		public static Exception CanNotRemoteDataTable()
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x27D04E0", Offset = "0x27CC4E0", VA = "0x27D04E0")]
		public static Exception CanNotSetRemotingFormat()
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x27D0520", Offset = "0x27CC520", VA = "0x27D0520")]
		public static Exception CanNotSerializeDataTableWithEmptyName()
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x27D0560", Offset = "0x27CC560", VA = "0x27D0560")]
		public static Exception TableNotFound(string tableName)
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x27D05AC", Offset = "0x27CC5AC", VA = "0x27D05AC")]
		public static Exception AggregateException(AggregateType aggregateType, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x27D0664", Offset = "0x27CC664", VA = "0x27D0664")]
		public static Exception InvalidStorageType(TypeCode typecode)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x27D06F8", Offset = "0x27CC6F8", VA = "0x27D06F8")]
		public static Exception RangeArgument(int min, int max)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x27D07AC", Offset = "0x27CC7AC", VA = "0x27D07AC")]
		public static Exception NullRange()
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x27D07EC", Offset = "0x27CC7EC", VA = "0x27D07EC")]
		public static Exception NegativeMinimumCapacity()
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x27D082C", Offset = "0x27CC82C", VA = "0x27D082C")]
		public static Exception ProblematicChars(char charValue)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x27D0908", Offset = "0x27CC908", VA = "0x27D0908")]
		public static Exception StorageSetFailed()
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x27D0948", Offset = "0x27CC948", VA = "0x27D0948")]
		public static Exception SimpleTypeNotSupported()
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x27D0988", Offset = "0x27CC988", VA = "0x27D0988")]
		public static Exception MissingAttribute(string attribute)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x27D09D8", Offset = "0x27CC9D8", VA = "0x27D09D8")]
		public static Exception MissingAttribute(string element, string attribute)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x27D0A34", Offset = "0x27CCA34", VA = "0x27D0A34")]
		public static Exception InvalidAttributeValue(string name, string value)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x27D0A90", Offset = "0x27CCA90", VA = "0x27D0A90")]
		public static Exception AttributeValues(string name, string value1, string value2)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x27D0AF4", Offset = "0x27CCAF4", VA = "0x27D0AF4")]
		public static Exception ElementTypeNotFound(string name)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x27D0B40", Offset = "0x27CCB40", VA = "0x27D0B40")]
		public static Exception RelationParentNameMissing(string rel)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x27D0B8C", Offset = "0x27CCB8C", VA = "0x27D0B8C")]
		public static Exception RelationChildNameMissing(string rel)
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x27D0BD8", Offset = "0x27CCBD8", VA = "0x27D0BD8")]
		public static Exception RelationTableKeyMissing(string rel)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x27D0C24", Offset = "0x27CCC24", VA = "0x27D0C24")]
		public static Exception RelationChildKeyMissing(string rel)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x27D0C70", Offset = "0x27CCC70", VA = "0x27D0C70")]
		public static Exception UndefinedDatatype(string name)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x27D0CBC", Offset = "0x27CCCBC", VA = "0x27D0CBC")]
		public static Exception DatatypeNotDefined()
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x27D0CFC", Offset = "0x27CCCFC", VA = "0x27D0CFC")]
		public static Exception MismatchKeyLength()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x27D0D3C", Offset = "0x27CCD3C", VA = "0x27D0D3C")]
		public static Exception InvalidField(string name)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x27D0D88", Offset = "0x27CCD88", VA = "0x27D0D88")]
		public static Exception InvalidSelector(string name)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x27D0DD4", Offset = "0x27CCDD4", VA = "0x27D0DD4")]
		public static Exception CircularComplexType(string name)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x27D0E20", Offset = "0x27CCE20", VA = "0x27D0E20")]
		public static Exception CannotInstantiateAbstract(string name)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x27D0E6C", Offset = "0x27CCE6C", VA = "0x27D0E6C")]
		public static Exception InvalidKey(string name)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x27D0EB8", Offset = "0x27CCEB8", VA = "0x27D0EB8")]
		public static Exception DiffgramMissingTable(string name)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x27D0F04", Offset = "0x27CCF04", VA = "0x27D0F04")]
		public static Exception DiffgramMissingSQL()
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x27D0F44", Offset = "0x27CCF44", VA = "0x27D0F44")]
		public static Exception DuplicateConstraintRead(string str)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x27D0F90", Offset = "0x27CCF90", VA = "0x27D0F90")]
		public static Exception ColumnTypeConflict(string name)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x27D0FDC", Offset = "0x27CCFDC", VA = "0x27D0FDC")]
		public static Exception CannotConvert(string name, string type)
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x27D1038", Offset = "0x27CD038", VA = "0x27D1038")]
		public static Exception MissingRefer(string name)
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x27C7AFC", Offset = "0x27C3AFC", VA = "0x27C7AFC")]
		public static Exception InvalidPrefix(string name)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x27D10BC", Offset = "0x27CD0BC", VA = "0x27D10BC")]
		public static Exception CanNotDeserializeObjectType()
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x27D10FC", Offset = "0x27CD0FC", VA = "0x27D10FC")]
		public static Exception IsDataSetAttributeMissingInSchema()
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x27D113C", Offset = "0x27CD13C", VA = "0x27D113C")]
		public static Exception TooManyIsDataSetAtributeInSchema()
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x27D117C", Offset = "0x27CD17C", VA = "0x27D117C")]
		public static Exception NestedCircular(string name)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x27D11C8", Offset = "0x27CD1C8", VA = "0x27D11C8")]
		public static Exception MultipleParentRows(string tableQName)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x27D1214", Offset = "0x27CD214", VA = "0x27D1214")]
		public static Exception PolymorphismNotSupported(string typeName)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x27D1260", Offset = "0x27CD260", VA = "0x27D1260")]
		public static Exception DataTableInferenceNotSupported()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x27D12A0", Offset = "0x27CD2A0", VA = "0x27D12A0")]
		internal static void ThrowMultipleTargetConverter(Exception innerException)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x27D1300", Offset = "0x27CD300", VA = "0x27D1300")]
		public static Exception DuplicateDeclaration(string name)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x27D134C", Offset = "0x27CD34C", VA = "0x27D134C")]
		public static Exception FoundEntity()
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x27D138C", Offset = "0x27CD38C", VA = "0x27D138C")]
		public static Exception MergeFailed(string name)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x27D1390", Offset = "0x27CD390", VA = "0x27D1390")]
		public static Exception ConvertFailed(Type type1, Type type2)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x27D1420", Offset = "0x27CD420", VA = "0x27D1420")]
		internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x27D147C", Offset = "0x27CD47C", VA = "0x27D147C")]
		internal static Exception InternalRBTreeError(RBTreeError internalError)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x27D14FC", Offset = "0x27CD4FC", VA = "0x27D14FC")]
		public static Exception EnumeratorModified()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[XmlRoot("DataSet")]
	[XmlSchemaProvider("GetDataSetSchema")]
	[DefaultProperty("DataSetName")]
	public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataViewManager _defaultViewManager;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly DataTableCollection _tableCollection;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly DataRelationCollection _relationCollection;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal PropertyCollection _extendedProperties;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _dataSetName;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _datasetPrefix;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal string _namespaceURI;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _enforceConstraints;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool _caseSensitive;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CultureInfo _culture;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _cultureUserSet;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		internal bool _fInReadXml;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		internal bool _fInLoadDiffgram;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		internal bool _fTopLevelTable;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal bool _fInitInProgress;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		internal bool _fEnableCascading;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		internal bool _fIsSchemaLoading;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal string _mainTableName;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SerializationFormat _remotingFormat;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private object _defaultViewManagerLock;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_objectTypeCount;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly int _objectID;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static XmlSchemaComplexType s_schemaTypeForWSDL;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		internal bool _useDataSetSchemaOnly;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		internal bool _udtIsWrapped;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanging;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[CompilerGenerated]
		private MergeFailedEventHandler MergeFailed;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[CompilerGenerated]
		private DataRowCreatedEventHandler DataRowCreated;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[CompilerGenerated]
		private DataSetClearEventhandler ClearFunctionCalled;

		[Token(Token = "0x17000038")]
		[DefaultValue(SerializationFormat.Xml)]
		public SerializationFormat RemotingFormat
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x27D18E8", Offset = "0x27CD8E8", VA = "0x27D18E8")]
			get
			{
				return default(SerializationFormat);
			}
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x27D18F0", Offset = "0x27CD8F0", VA = "0x27D18F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual SchemaSerializationMode SchemaSerializationMode
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x27D1990", Offset = "0x27CD990", VA = "0x27D1990", Slot = "14")]
			get
			{
				return default(SchemaSerializationMode);
			}
		}

		[Token(Token = "0x1700003A")]
		[DefaultValue(false)]
		public bool CaseSensitive
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x27D4AB8", Offset = "0x27D0AB8", VA = "0x27D4AB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x27D4AC0", Offset = "0x27D0AC0", VA = "0x27D4AC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		[DefaultValue(true)]
		public bool EnforceConstraints
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x27D5168", Offset = "0x27D1168", VA = "0x27D5168")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x27D4958", Offset = "0x27D0958", VA = "0x27D4958")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		[DefaultValue("")]
		public string DataSetName
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x27D5844", Offset = "0x27D1844", VA = "0x27D5844")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x27D17A8", Offset = "0x27CD7A8", VA = "0x27D17A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		[DefaultValue("")]
		public string Namespace
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x27D58C4", Offset = "0x27D18C4", VA = "0x27D58C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x27D58CC", Offset = "0x27D18CC", VA = "0x27D58CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		[DefaultValue("")]
		public string Prefix
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x27D5D4C", Offset = "0x27D1D4C", VA = "0x27D5D4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x27D5D54", Offset = "0x27D1D54", VA = "0x27D5D54")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		[Browsable(false)]
		public PropertyCollection ExtendedProperties
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x27D48C8", Offset = "0x27D08C8", VA = "0x27D48C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public CultureInfo Locale
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x27D5E70", Offset = "0x27D1E70", VA = "0x27D5E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x27D5E78", Offset = "0x27D1E78", VA = "0x27D5E78")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override ISite Site
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x27D6B30", Offset = "0x27D2B30", VA = "0x27D6B30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataRelationCollection Relations
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x27D6B38", Offset = "0x27D2B38", VA = "0x27D6B38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataTableCollection Tables
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x27D6B40", Offset = "0x27D2B40", VA = "0x27D6B40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		internal string MainTableName
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x27DD0C4", Offset = "0x27D90C4", VA = "0x27DD0C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x27DD0CC", Offset = "0x27D90CC", VA = "0x27DD0CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		internal int ObjectID
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x27DD0D4", Offset = "0x27D90D4", VA = "0x27DD0D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x27D153C", Offset = "0x27CD53C", VA = "0x27D153C")]
		public DataSet()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x27D1780", Offset = "0x27CD780", VA = "0x27D1780")]
		public DataSet(string dataSetName)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x27D1998", Offset = "0x27CD998", VA = "0x27D1998")]
		protected DataSet(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x27D19A0", Offset = "0x27CD9A0", VA = "0x27D19A0")]
		protected DataSet(SerializationInfo info, StreamingContext context, bool ConstructSchema)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x27D1BE0", Offset = "0x27CDBE0", VA = "0x27D1BE0", Slot = "15")]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x27D2208", Offset = "0x27CE208", VA = "0x27D2208", Slot = "16")]
		protected virtual void InitializeDerivedDataSet()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x27D1BE8", Offset = "0x27CDBE8", VA = "0x27D1BE8")]
		private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x27D1B98", Offset = "0x27CDB98", VA = "0x27D1B98")]
		internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x27D2EA4", Offset = "0x27CEEA4", VA = "0x27D2EA4")]
		private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x27D3394", Offset = "0x27CF394", VA = "0x27D3394")]
		private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x27D220C", Offset = "0x27CE20C", VA = "0x27D220C")]
		private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x27D3568", Offset = "0x27CF568", VA = "0x27D3568")]
		private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x27D237C", Offset = "0x27CE37C", VA = "0x27D237C")]
		private void SerializeRelations(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x27D3830", Offset = "0x27CF830", VA = "0x27D3830")]
		private void DeserializeRelations(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x27D492C", Offset = "0x27D092C", VA = "0x27D492C")]
		internal void FailedEnableConstraints()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x27D583C", Offset = "0x27D183C", VA = "0x27D583C")]
		internal void RestoreEnforceConstraints(bool value)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x27D5170", Offset = "0x27D1170", VA = "0x27D5170")]
		internal void EnableConstraints()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x27D5FF4", Offset = "0x27D1FF4", VA = "0x27D5FF4")]
		internal void SetLocaleValue(CultureInfo value, bool userSet)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x27D6B28", Offset = "0x27D2B28", VA = "0x27D6B28")]
		internal bool ShouldSerializeLocale()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x27D6B48", Offset = "0x27D2B48", VA = "0x27D6B48")]
		public void Clear()
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x27D6D54", Offset = "0x27D2D54", VA = "0x27D6D54", Slot = "17")]
		public virtual DataSet Clone()
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x27D2B94", Offset = "0x27CEB94", VA = "0x27D2B94")]
		internal int EstimatedXmlStringSize()
		{
			return default(int);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x27D7C8C", Offset = "0x27D3C8C", VA = "0x27D7C8C")]
		internal string GetRemotingDiffGram(DataTable table)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x27D2A00", Offset = "0x27CEA00", VA = "0x27D2A00")]
		internal string GetXmlSchemaForRemoting(DataTable table)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x27D7DBC", Offset = "0x27D3DBC", VA = "0x27D7DBC")]
		public void ReadXmlSchema(XmlReader reader)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x27D402C", Offset = "0x27D002C", VA = "0x27D402C")]
		internal void ReadXmlSchema(XmlReader reader, bool denyResolving)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x27D81C4", Offset = "0x27D41C4", VA = "0x27D81C4")]
		internal bool MoveToElement(XmlReader reader, int depth)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x27D8680", Offset = "0x27D4680", VA = "0x27D8680")]
		private static void MoveToElement(XmlReader reader)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x27D8278", Offset = "0x27D4278", VA = "0x27D8278")]
		internal void ReadEndElement(XmlReader reader)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x27D7F1C", Offset = "0x27D3F1C", VA = "0x27D7F1C")]
		internal void ReadXSDSchema(XmlReader reader, bool denyResolving)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x27D7DC4", Offset = "0x27D3DC4", VA = "0x27D7DC4")]
		internal void ReadXDRSchema(XmlReader reader)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x27D86F8", Offset = "0x27D46F8", VA = "0x27D86F8")]
		private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x27D8910", Offset = "0x27D4910", VA = "0x27D8910")]
		public XmlReadMode ReadXml(XmlReader reader)
		{
			return default(XmlReadMode);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x27D8918", Offset = "0x27D4918", VA = "0x27D8918")]
		internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving)
		{
			return default(XmlReadMode);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x27D8314", Offset = "0x27D4314", VA = "0x27D8314")]
		internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x27DABF4", Offset = "0x27D6BF4", VA = "0x27DABF4")]
		private bool IsEmpty()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x27D9A0C", Offset = "0x27D5A0C", VA = "0x27D9A0C")]
		private void ReadXmlDiffgram(XmlReader reader)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x27D48C0", Offset = "0x27D08C0", VA = "0x27D48C0")]
		public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode)
		{
			return default(XmlReadMode);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x27DB014", Offset = "0x27D7014", VA = "0x27DB014")]
		internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving)
		{
			return default(XmlReadMode);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x27D2CB4", Offset = "0x27CECB4", VA = "0x27D2CB4")]
		public void WriteXml(XmlWriter writer, XmlWriteMode mode)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x27DAEB4", Offset = "0x27D6EB4", VA = "0x27DAEB4")]
		public void Merge(DataSet dataSet)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x27DBDD8", Offset = "0x27D7DD8", VA = "0x27DBDD8")]
		public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x27DC014", Offset = "0x27D8014", VA = "0x27DC014", Slot = "18")]
		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x27DC03C", Offset = "0x27D803C", VA = "0x27DC03C")]
		internal void OnMergeFailed(MergeFailedEventArgs mfevent)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x27DC094", Offset = "0x27D8094", VA = "0x27DC094")]
		internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x27DC138", Offset = "0x27D8138", VA = "0x27DC138")]
		internal void OnDataRowCreated(DataRow row)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x27D6D2C", Offset = "0x27D2D2C", VA = "0x27D6D2C")]
		internal void OnClearFunctionCalled(DataTable table)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x27DC160", Offset = "0x27D8160", VA = "0x27DC160", Slot = "19")]
		protected internal virtual void OnRemoveTable(DataTable table)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x27DC164", Offset = "0x27D8164", VA = "0x27DC164")]
		internal void OnRemovedTable(DataTable table)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x27DC188", Offset = "0x27D8188", VA = "0x27DC188", Slot = "20")]
		protected virtual void OnRemoveRelation(DataRelation relation)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x27DC18C", Offset = "0x27D818C", VA = "0x27DC18C")]
		internal void OnRemoveRelationHack(DataRelation relation)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x27D584C", Offset = "0x27D184C", VA = "0x27D584C")]
		protected internal void RaisePropertyChanging(string name)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x27DC19C", Offset = "0x27D819C", VA = "0x27DC19C")]
		internal DataTable[] TopLevelTables()
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x27DC1A4", Offset = "0x27D81A4", VA = "0x27DC1A4")]
		internal DataTable[] TopLevelTables(bool forSchema)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x27DC488", Offset = "0x27D8488", VA = "0x27DC488", Slot = "21")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x27D4DB0", Offset = "0x27D0DB0", VA = "0x27D4DB0")]
		internal bool ValidateCaseConstraint()
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x27D66F8", Offset = "0x27D26F8", VA = "0x27D66F8")]
		internal bool ValidateLocaleConstraint()
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x27DC724", Offset = "0x27D8724", VA = "0x27DC724", Slot = "22")]
		protected virtual void ReadXmlSerializable(XmlReader reader)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x27DCA0C", Offset = "0x27D8A0C", VA = "0x27DCA0C")]
		public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x27DCC6C", Offset = "0x27D8C6C", VA = "0x27DCC6C", Slot = "10")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x27DCE40", Offset = "0x27D8E40", VA = "0x27DCE40", Slot = "11")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x27DD090", Offset = "0x27D9090", VA = "0x27DD090", Slot = "12")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	[DefaultProperty("TableName")]
	[DesignTimeVisible(false)]
	[DefaultEvent("RowChanging")]
	[XmlSchemaProvider("GetDataTableSchema")]
	[ToolboxItem(false)]
	public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable
	{
		[Token(Token = "0x200001A")]
		internal struct RowDiffIdUsageSection
		{
			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private DataTable _targetTable;

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x27DD0DC", Offset = "0x27D90DC", VA = "0x27DD0DC")]
			internal void Prepare(DataTable table)
			{
			}
		}

		[Token(Token = "0x200001B")]
		internal struct DSRowDiffIdUsageSection
		{
			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private DataSet _targetDS;

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x27D999C", Offset = "0x27D599C", VA = "0x27D999C")]
			internal void Prepare(DataSet ds)
			{
			}
		}

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataSet _dataSet;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DataView _defaultView;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal long _nextRowID;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal readonly DataRowCollection _rowCollection;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal readonly DataColumnCollection _columnCollection;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly ConstraintCollection _constraintCollection;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _elementColumnCount;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal DataRelationCollection _parentRelationsCollection;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal DataRelationCollection _childRelationsCollection;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal readonly RecordManager _recordManager;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal readonly List<Index> _indexes;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<Index> _shadowIndexes;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _shadowCount;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal PropertyCollection _extendedProperties;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string _tableName;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal string _tableNamespace;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string _tablePrefix;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal DataExpression _displayExpression;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal bool _fNestedInDataset;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CultureInfo _culture;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _cultureUserSet;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private CompareInfo _compareInfo;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private CompareOptions _compareFlags;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private IFormatProvider _formatProvider;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private StringComparer _hashCodeProvider;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool _caseSensitive;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private bool _caseSensitiveUserSet;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal string _encodedTableName;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal DataColumn _xmlText;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal DataColumn _colUnique;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal decimal _minOccurs;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal decimal _maxOccurs;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal bool _repeatableElement;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private object _typeName;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal UniqueConstraint _primaryKey;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal IndexField[] _primaryIndex;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private DataColumn[] _delayedSetPrimaryKey;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Index _loadIndex;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Index _loadIndexwithOriginalAdded;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Index _loadIndexwithCurrentDeleted;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int _suspendIndexEvents;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private bool _inDataLoad;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		private bool _schemaLoading;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16E")]
		private bool _enforceConstraints;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
		internal bool _suspendEnforceConstraints;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		protected internal bool fInitInProgress;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool _inLoad;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x172")]
		internal bool _fInLoadDiffgram;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x173")]
		private byte _isTypedDataTable;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private DataRow[] _emptyDataRowArray;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private PropertyDescriptorCollection _propertyDescriptorCollectionCache;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private DataRelation[] _nestedParentRelations;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		internal List<DataColumn> _dependentColumns;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool _mergingData;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private DataRowChangeEventHandler _onRowChangedDelegate;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private DataRowChangeEventHandler _onRowChangingDelegate;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private DataRowChangeEventHandler _onRowDeletingDelegate;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private DataRowChangeEventHandler _onRowDeletedDelegate;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private DataColumnChangeEventHandler _onColumnChangedDelegate;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private DataColumnChangeEventHandler _onColumnChangingDelegate;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private DataTableClearEventHandler _onTableClearingDelegate;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private DataTableClearEventHandler _onTableClearedDelegate;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private DataTableNewRowEventHandler _onTableNewRowDelegate;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private PropertyChangedEventHandler _onPropertyChangingDelegate;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly DataRowBuilder _rowBuilder;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		internal readonly List<DataView> _delayedViews;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly List<DataViewListener> _dataViewListeners;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		internal Hashtable _rowDiffId;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		internal readonly ReaderWriterLockSlim _indexesLock;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		internal int _ukColumnPositionForInference;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private SerializationFormat _remotingFormat;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_objectTypeCount;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly int _objectID;

		[Token(Token = "0x17000046")]
		public bool CaseSensitive
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x27B43E4", Offset = "0x27B03E4", VA = "0x27B43E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x27B43EC", Offset = "0x27B03EC", VA = "0x27B43EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		internal bool AreIndexEventsSuspended
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x27B448C", Offset = "0x27B048C", VA = "0x27B448C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		private bool IsTypedDataTable
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x27B4900", Offset = "0x27B0900", VA = "0x27B4900")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		internal bool SelfNested
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x27B49C8", Offset = "0x27B09C8", VA = "0x27B49C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal List<Index> LiveIndexes
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x27B4D1C", Offset = "0x27B0D1C", VA = "0x27B4D1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		[DefaultValue(SerializationFormat.Xml)]
		public SerializationFormat RemotingFormat
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x27B4DC8", Offset = "0x27B0DC8", VA = "0x27B4DC8")]
			get
			{
				return default(SerializationFormat);
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x27B4DD0", Offset = "0x27B0DD0", VA = "0x27B4DD0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		internal int UKColumnPositionForInference
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x27B4E30", Offset = "0x27B0E30", VA = "0x27B4E30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x27B4E38", Offset = "0x27B0E38", VA = "0x27B4E38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataRelationCollection ChildRelations
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x27B4E40", Offset = "0x27B0E40", VA = "0x27B4E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataColumnCollection Columns
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x27B4EAC", Offset = "0x27B0EAC", VA = "0x27B4EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		private CompareInfo CompareInfo
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x27B4EB4", Offset = "0x27B0EB4", VA = "0x27B4EB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ConstraintCollection Constraints
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x27B4EE8", Offset = "0x27B0EE8", VA = "0x27B4EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataSet DataSet
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x27B4F08", Offset = "0x27B0F08", VA = "0x27B4F08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		internal string DisplayExpressionInternal
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x27B4FBC", Offset = "0x27B0FBC", VA = "0x27B4FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		internal bool EnforceConstraints
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x27B5020", Offset = "0x27B1020", VA = "0x27B5020")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x27B5048", Offset = "0x27B1048", VA = "0x27B5048")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		internal bool SuspendEnforceConstraints
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x27B5604", Offset = "0x27B1604", VA = "0x27B5604")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x27B560C", Offset = "0x27B160C", VA = "0x27B560C")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		[Browsable(false)]
		public PropertyCollection ExtendedProperties
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x27B19FC", Offset = "0x27AD9FC", VA = "0x27B19FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		internal IFormatProvider FormatProvider
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x27B5614", Offset = "0x27B1614", VA = "0x27B5614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public CultureInfo Locale
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x27B56A4", Offset = "0x27B16A4", VA = "0x27B56A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x27B56AC", Offset = "0x27B16AC", VA = "0x27B56AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		[DefaultValue(50)]
		public int MinimumCapacity
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x27B5B30", Offset = "0x27B1B30", VA = "0x27B5B30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x27B2EA4", Offset = "0x27AEEA4", VA = "0x27B2EA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		internal int RecordCapacity
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x27B5B48", Offset = "0x27B1B48", VA = "0x27B5B48")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005A")]
		internal int ElementColumnCount
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x27B5B60", Offset = "0x27B1B60", VA = "0x27B5B60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x27B5B68", Offset = "0x27B1B68", VA = "0x27B5B68")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DataRelationCollection ParentRelations
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x27B4CB0", Offset = "0x27B0CB0", VA = "0x27B4CB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		internal bool MergingData
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x27B5BA8", Offset = "0x27B1BA8", VA = "0x27B5BA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x27B5BB0", Offset = "0x27B1BB0", VA = "0x27B5BB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		internal DataRelation[] NestedParentRelations
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x27B5BB8", Offset = "0x27B1BB8", VA = "0x27B5BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		internal bool SchemaLoading
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x27B5BC0", Offset = "0x27B1BC0", VA = "0x27B5BC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		internal int NestedParentsCount
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x27B6024", Offset = "0x27B2024", VA = "0x27B6024")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000060")]
		[TypeConverter(typeof(PrimaryKeyTypeConverter))]
		public DataColumn[] PrimaryKey
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x27B62DC", Offset = "0x27B22DC", VA = "0x27B62DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x27B6394", Offset = "0x27B2394", VA = "0x27B6394")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		[Browsable(false)]
		public DataRowCollection Rows
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x27B6778", Offset = "0x27B2778", VA = "0x27B6778")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		[DefaultValue("")]
		[RefreshProperties(RefreshProperties.All)]
		public string TableName
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x27B6780", Offset = "0x27B2780", VA = "0x27B6780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x27B6788", Offset = "0x27B2788", VA = "0x27B6788")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		internal string EncodedTableName
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x27B6CC8", Offset = "0x27B2CC8", VA = "0x27B6CC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public string Namespace
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x27AF214", Offset = "0x27AB214", VA = "0x27AF214")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x27B16F4", Offset = "0x27AD6F4", VA = "0x27B16F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		[DefaultValue("")]
		public string Prefix
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x27B7FA4", Offset = "0x27B3FA4", VA = "0x27B7FA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x27B7FAC", Offset = "0x27B3FAC", VA = "0x27B7FAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		internal DataColumn XmlText
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x27B810C", Offset = "0x27B410C", VA = "0x27B810C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x27B8114", Offset = "0x27B4114", VA = "0x27B8114")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		internal decimal MaxOccurs
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x27B81BC", Offset = "0x27B41BC", VA = "0x27B81BC")]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x27B81C8", Offset = "0x27B41C8", VA = "0x27B81C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		internal decimal MinOccurs
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x27B81D0", Offset = "0x27B41D0", VA = "0x27B81D0")]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x27B81DC", Offset = "0x27B41DC", VA = "0x27B81DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override ISite Site
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x27B9B28", Offset = "0x27B5B28", VA = "0x27B9B28", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		internal bool NeedColumnChangeEvents
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x27BD1A8", Offset = "0x27B91A8", VA = "0x27BD1A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		internal XmlQualifiedName TypeName
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x27B1968", Offset = "0x27AD968", VA = "0x27B1968")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x27BF834", Offset = "0x27BB834", VA = "0x27BF834")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		internal Hashtable RowDiffId
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x27C4178", Offset = "0x27C0178", VA = "0x27C4178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		internal int ObjectID
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x27C41DC", Offset = "0x27C01DC", VA = "0x27C41DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x27AD218", Offset = "0x27A9218", VA = "0x27AD218")]
		public DataTable()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x27AD6E4", Offset = "0x27A96E4", VA = "0x27AD6E4")]
		public DataTable(string tableName)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x27AD748", Offset = "0x27A9748", VA = "0x27AD748")]
		protected DataTable(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x27ADBFC", Offset = "0x27A9BFC", VA = "0x27ADBFC", Slot = "14")]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x27ADCD4", Offset = "0x27A9CD4", VA = "0x27ADCD4")]
		private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x27AD8E0", Offset = "0x27A98E0", VA = "0x27AD8E0")]
		internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x27ADF88", Offset = "0x27A9F88", VA = "0x27ADF88")]
		internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x27AF298", Offset = "0x27AB298", VA = "0x27AF298")]
		internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x27B1F2C", Offset = "0x27ADF2C", VA = "0x27B1F2C")]
		internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x27B2ECC", Offset = "0x27AEECC", VA = "0x27B2ECC")]
		internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x27B3B10", Offset = "0x27AFB10", VA = "0x27B3B10")]
		internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x27B3C6C", Offset = "0x27AFC6C", VA = "0x27B3C6C")]
		internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x27AEC48", Offset = "0x27AAC48", VA = "0x27AEC48")]
		internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x27B0158", Offset = "0x27AC158", VA = "0x27B0158")]
		internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x27B406C", Offset = "0x27B006C", VA = "0x27B406C")]
		private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex)
		{
			return default(DataRowState);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x27B3DD0", Offset = "0x27AFDD0", VA = "0x27B3DD0")]
		internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x27B4114", Offset = "0x27B0114", VA = "0x27B4114")]
		private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x27B449C", Offset = "0x27B049C", VA = "0x27B449C")]
		internal void RestoreIndexEvents(bool forceReset)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x27B4854", Offset = "0x27B0854", VA = "0x27B4854")]
		internal void SuspendIndexEvents()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x27B2668", Offset = "0x27AE668", VA = "0x27B2668")]
		internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes)
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x27B49C0", Offset = "0x27B09C0", VA = "0x27B49C0")]
		internal bool ShouldSerializeCaseSensitive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x27B4EF0", Offset = "0x27B0EF0", VA = "0x27B4EF0")]
		private void ResetConstraints()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x27B4F10", Offset = "0x27B0F10", VA = "0x27B4F10")]
		internal void SetDataSet(DataSet dataSet)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x27B508C", Offset = "0x27B108C", VA = "0x27B508C")]
		internal void EnableConstraints()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x27B2954", Offset = "0x27AE954", VA = "0x27B2954")]
		internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x27B5B28", Offset = "0x27B1B28", VA = "0x27B5B28")]
		internal bool ShouldSerializeLocale()
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x27B5BC8", Offset = "0x27B1BC8", VA = "0x27B5BC8")]
		internal void CacheNestedParent()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x27B5BE0", Offset = "0x27B1BE0", VA = "0x27B5BE0")]
		private DataRelation[] FindNestedParentRelations()
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x27B6D34", Offset = "0x27B2D34", VA = "0x27B6D34")]
		private string GetInheritedNamespace(List<DataTable> visitedTables)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x27B7C48", Offset = "0x27B3C48", VA = "0x27B7C48")]
		internal bool IsNamespaceInherited()
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x27B6F78", Offset = "0x27B2F78", VA = "0x27B6F78")]
		internal void CheckCascadingNamespaceConflict(string realNamespace)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x27B7318", Offset = "0x27B3318", VA = "0x27B7318")]
		internal void CheckNamespaceValidityForNestedRelations(string realNamespace)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x27B7C58", Offset = "0x27B3C58", VA = "0x27B7C58")]
		internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x27B76F0", Offset = "0x27B36F0", VA = "0x27B76F0")]
		internal void DoRaiseNamespaceChange()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x27B81E4", Offset = "0x27B41E4", VA = "0x27B81E4")]
		internal void SetKeyValues(DataKey key, object[] keyValues, int record)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x27B8278", Offset = "0x27B4278", VA = "0x27B8278")]
		internal DataRow FindByIndex(Index ndx, object[] key)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x27B8308", Offset = "0x27B4308", VA = "0x27B8308")]
		internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x27B8388", Offset = "0x27B4388", VA = "0x27B8388")]
		private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x27B86F4", Offset = "0x27B46F4", VA = "0x27B86F4")]
		internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch)
		{
			return null;
		}

		[MethodImpl(8)]
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x27B9174", Offset = "0x27B5174", VA = "0x27B9174", Slot = "15")]
		protected virtual DataTable CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x27B9200", Offset = "0x27B5200", VA = "0x27B9200", Slot = "16")]
		public virtual DataTable Clone()
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x27B9208", Offset = "0x27B5208", VA = "0x27B9208")]
		internal DataTable Clone(DataSet cloneDS)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x27B93D8", Offset = "0x27B53D8", VA = "0x27B93D8")]
		private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x27B96E4", Offset = "0x27B56E4", VA = "0x27B96E4")]
		private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x27B0ADC", Offset = "0x27ACADC", VA = "0x27B0ADC")]
		private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x27B9B30", Offset = "0x27B5B30", VA = "0x27B9B30")]
		internal void AddRow(DataRow row, int proposedID)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x27B9B40", Offset = "0x27B5B40", VA = "0x27B9B40")]
		internal void InsertRow(DataRow row, int proposedID, int pos)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x27B9B4C", Offset = "0x27B5B4C", VA = "0x27B9B4C")]
		internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x27BA7CC", Offset = "0x27B67CC", VA = "0x27BA7CC")]
		internal void CheckNotModifying(DataRow row)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x27BA7F4", Offset = "0x27B67F4", VA = "0x27BA7F4")]
		public void Clear()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x27BA7FC", Offset = "0x27B67FC", VA = "0x27BA7FC")]
		internal void Clear(bool clearAll)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x27BB114", Offset = "0x27B7114", VA = "0x27BB114")]
		internal void CascadeAll(DataRow row, DataRowAction action)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x27BB1CC", Offset = "0x27B71CC", VA = "0x27BB1CC")]
		internal void CommitRow(DataRow row)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x27BB384", Offset = "0x27B7384", VA = "0x27BB384")]
		internal int Compare(string s1, string s2)
		{
			return default(int);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x27BB38C", Offset = "0x27B738C", VA = "0x27BB38C")]
		internal int Compare(string s1, string s2, CompareInfo comparer)
		{
			return default(int);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x27BB4F0", Offset = "0x27B74F0", VA = "0x27BB4F0")]
		internal int IndexOf(string s1, string s2)
		{
			return default(int);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x27BB530", Offset = "0x27B7530", VA = "0x27BB530")]
		internal bool IsSuffix(string s1, string s2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x27BB570", Offset = "0x27B7570", VA = "0x27BB570")]
		internal void DeleteRow(DataRow row)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x27BB5C8", Offset = "0x27B75C8", VA = "0x27BB5C8")]
		internal string FormatSortString(IndexField[] indexDesc)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x27BB6FC", Offset = "0x27B76FC", VA = "0x27BB6FC")]
		internal void FreeRecord(ref int record)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x27BB714", Offset = "0x27B7714", VA = "0x27BB714")]
		internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x27BBAAC", Offset = "0x27B7AAC", VA = "0x27BBAAC")]
		internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x27BBC78", Offset = "0x27B7C78", VA = "0x27BBC78")]
		internal List<DataViewListener> GetListeners()
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x27B5A38", Offset = "0x27B1A38", VA = "0x27B5A38")]
		internal int GetSpecialHashCode(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x27B8CEC", Offset = "0x27B4CEC", VA = "0x27B8CEC")]
		internal void InsertRow(DataRow row, long proposedID)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x27BC91C", Offset = "0x27B891C", VA = "0x27BC91C")]
		internal int NewRecord()
		{
			return default(int);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x27BCA08", Offset = "0x27B8A08", VA = "0x27BCA08")]
		internal int NewUninitializedRecord()
		{
			return default(int);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x27BC924", Offset = "0x27B8924", VA = "0x27BC924")]
		internal int NewRecord(int sourceRecord)
		{
			return default(int);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x27B4018", Offset = "0x27B0018", VA = "0x27B4018")]
		internal DataRow NewEmptyRow()
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x27BCA20", Offset = "0x27B8A20", VA = "0x27BCA20")]
		private DataRow NewUninitializedRow()
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x27BCAD8", Offset = "0x27B8AD8", VA = "0x27BCAD8")]
		public DataRow NewRow()
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x27BCB90", Offset = "0x27B8B90", VA = "0x27BCB90")]
		internal DataRow CreateEmptyRow()
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x27BCB0C", Offset = "0x27B8B0C", VA = "0x27BCB0C")]
		private void NewRowCreated(DataRow row)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x27BCA4C", Offset = "0x27B8A4C", VA = "0x27BCA4C")]
		internal DataRow NewRow(int record)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x27BCF34", Offset = "0x27B8F34", VA = "0x27BCF34", Slot = "17")]
		protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x27BCF90", Offset = "0x27B8F90", VA = "0x27BCF90", Slot = "18")]
		protected virtual Type GetRowType()
		{
			return null;
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x27BCFFC", Offset = "0x27B8FFC", VA = "0x27BCFFC")]
		protected internal DataRow[] NewRowArray(int size)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x27BD1DC", Offset = "0x27B91DC", VA = "0x27BD1DC", Slot = "19")]
		protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x27BD2AC", Offset = "0x27B92AC", VA = "0x27BD2AC", Slot = "20")]
		protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x27BD37C", Offset = "0x27B937C", VA = "0x27BD37C", Slot = "21")]
		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x27BD44C", Offset = "0x27B944C", VA = "0x27BD44C")]
		internal void OnRemoveColumnInternal(DataColumn column)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x27BD45C", Offset = "0x27B945C", VA = "0x27BD45C", Slot = "22")]
		protected virtual void OnRemoveColumn(DataColumn column)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x27BB2E0", Offset = "0x27B72E0", VA = "0x27BB2E0")]
		private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x27BB23C", Offset = "0x27B723C", VA = "0x27BB23C")]
		private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x27BD460", Offset = "0x27B9460", VA = "0x27BD460", Slot = "23")]
		protected virtual void OnRowChanged(DataRowChangeEventArgs e)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x27BD530", Offset = "0x27B9530", VA = "0x27BD530", Slot = "24")]
		protected virtual void OnRowChanging(DataRowChangeEventArgs e)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x27BD600", Offset = "0x27B9600", VA = "0x27BD600", Slot = "25")]
		protected virtual void OnRowDeleting(DataRowChangeEventArgs e)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x27BD6D0", Offset = "0x27B96D0", VA = "0x27BD6D0", Slot = "26")]
		protected virtual void OnRowDeleted(DataRowChangeEventArgs e)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x27BD7A0", Offset = "0x27B97A0", VA = "0x27BD7A0", Slot = "27")]
		protected virtual void OnTableCleared(DataTableClearEventArgs e)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x27BD870", Offset = "0x27B9870", VA = "0x27BD870", Slot = "28")]
		protected virtual void OnTableClearing(DataTableClearEventArgs e)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x27BD940", Offset = "0x27B9940", VA = "0x27BD940", Slot = "29")]
		protected virtual void OnTableNewRow(DataTableNewRowEventArgs e)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x27BB748", Offset = "0x27B7748", VA = "0x27BB748")]
		internal IndexField[] ParseSortString(string sortString)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x27B6C50", Offset = "0x27B2C50", VA = "0x27B6C50")]
		internal void RaisePropertyChanging(string name)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x27BDA10", Offset = "0x27B9A10", VA = "0x27BDA10")]
		internal void RecordChanged(int record)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x27BDB90", Offset = "0x27B9B90", VA = "0x27BDB90")]
		internal void RecordChanged(int[] oldIndex, int[] newIndex)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x27BBE14", Offset = "0x27B7E14", VA = "0x27BBE14")]
		internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x27BBFAC", Offset = "0x27B7FAC", VA = "0x27BBFAC")]
		internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x27BDD6C", Offset = "0x27B9D6C", VA = "0x27BDD6C")]
		internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x27BDF1C", Offset = "0x27B9F1C", VA = "0x27BDF1C")]
		internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x27BE094", Offset = "0x27BA094", VA = "0x27BE094")]
		internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x27BE960", Offset = "0x27BA960", VA = "0x27BE960")]
		internal void RemoveRow(DataRow row, bool check)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x27BEAFC", Offset = "0x27BAAFC", VA = "0x27BEAFC", Slot = "30")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x27B0AD4", Offset = "0x27ACAD4", VA = "0x27B0AD4")]
		internal void ResetIndexes()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x27BED60", Offset = "0x27BAD60", VA = "0x27BED60")]
		internal void ResetInternalIndexes(DataColumn column)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x27BEF48", Offset = "0x27BAF48", VA = "0x27BEF48")]
		internal void RollbackRow(DataRow row)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x27BC734", Offset = "0x27B8734", VA = "0x27BC734")]
		private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x27BEFB4", Offset = "0x27BAFB4", VA = "0x27BEFB4")]
		private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x27BBC80", Offset = "0x27B7C80", VA = "0x27BBC80")]
		private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x27B8434", Offset = "0x27B4434", VA = "0x27B8434")]
		internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = DataRowAction.Change, bool isInMerge = false, bool fireEvent = true, bool suppressEnsurePropertyChanged = false)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x27B9EF8", Offset = "0x27B5EF8", VA = "0x27B9EF8")]
		private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x27B8484", Offset = "0x27B4484", VA = "0x27B8484")]
		internal void SetOldRecord(DataRow row, int proposedRecord)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x27BF1B4", Offset = "0x27BB1B4", VA = "0x27BF1B4")]
		private void RestoreShadowIndexes()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x27B481C", Offset = "0x27B081C", VA = "0x27B481C")]
		private void SetShadowIndexes()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x27BF1D0", Offset = "0x27BB1D0", VA = "0x27BF1D0")]
		internal void ShadowIndexCopy()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x27BF24C", Offset = "0x27BB24C", VA = "0x27BF24C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x27BEF94", Offset = "0x27BAF94", VA = "0x27BEF94")]
		internal bool UpdatingCurrent(DataRow row, DataRowAction action)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x27BF2C0", Offset = "0x27BB2C0", VA = "0x27BF2C0")]
		internal DataColumn AddUniqueKey(int position)
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x27BF538", Offset = "0x27BB538", VA = "0x27BF538")]
		internal DataColumn AddUniqueKey()
		{
			return null;
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x27BF540", Offset = "0x27BB540", VA = "0x27BF540")]
		internal DataColumn AddForeignKey(DataColumn parentKey)
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x27BF5EC", Offset = "0x27BB5EC", VA = "0x27BF5EC")]
		internal void UpdatePropertyDescriptorCollectionCache()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x27BF5F4", Offset = "0x27BB5F4", VA = "0x27BF5F4")]
		internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x27BF83C", Offset = "0x27BB83C", VA = "0x27BF83C")]
		public void Merge(DataTable table)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x27BF848", Offset = "0x27BB848", VA = "0x27BF848")]
		public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x27BFA88", Offset = "0x27BBA88", VA = "0x27BFA88")]
		public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x27BFE0C", Offset = "0x27BBE0C", VA = "0x27BFE0C")]
		private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x27B1A60", Offset = "0x27ADA60", VA = "0x27B1A60")]
		private bool CheckForClosureOnExpressionTables(List<DataTable> tableList)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x27C02C0", Offset = "0x27BC2C0", VA = "0x27C02C0")]
		public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x27C05C8", Offset = "0x27BC5C8", VA = "0x27C05C8")]
		private void RestoreConstraint(bool originalEnforceConstraint)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x27C061C", Offset = "0x27BC61C", VA = "0x27C061C")]
		private bool IsEmptyXml(XmlReader reader)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x27C07EC", Offset = "0x27BC7EC", VA = "0x27C07EC")]
		internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving)
		{
			return default(XmlReadMode);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x27C2094", Offset = "0x27BE094", VA = "0x27C2094")]
		internal void ReadEndElement(XmlReader reader)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x27C2130", Offset = "0x27BE130", VA = "0x27C2130")]
		internal void ReadXDRSchema(XmlReader reader)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x27C3470", Offset = "0x27BF470", VA = "0x27C3470")]
		internal bool MoveToElement(XmlReader reader, int depth)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x27C16E4", Offset = "0x27BD6E4", VA = "0x27C16E4")]
		private void ReadXmlDiffgram(XmlReader reader)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x27C3524", Offset = "0x27BF524", VA = "0x27C3524")]
		internal void ReadXSDSchema(XmlReader reader, bool denyResolving)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x27C21A0", Offset = "0x27BE1A0", VA = "0x27C21A0")]
		internal void ReadXmlSchema(XmlReader reader, bool denyResolving)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x27BFF18", Offset = "0x27BBF18", VA = "0x27BFF18")]
		private void CreateTableList(DataTable currentTable, List<DataTable> tableList)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x27C36B8", Offset = "0x27BF6B8", VA = "0x27C36B8")]
		private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x27C3B78", Offset = "0x27BFB78", VA = "0x27C3B78")]
		public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x27C3DA8", Offset = "0x27BFDA8", VA = "0x27C3DA8", Slot = "11")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x27C3DB8", Offset = "0x27BFDB8", VA = "0x27C3DB8", Slot = "31")]
		protected virtual XmlSchema GetSchema()
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x27C3F8C", Offset = "0x27BFF8C", VA = "0x27C3F8C", Slot = "12")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x27C4138", Offset = "0x27C0138", VA = "0x27C4138", Slot = "13")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x27C416C", Offset = "0x27C016C", VA = "0x27C416C", Slot = "32")]
		protected virtual void ReadXmlSerializable(XmlReader reader)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x27C41E4", Offset = "0x27C01E4", VA = "0x27C41E4")]
		internal void AddDependentColumn(DataColumn expressionColumn)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x27C42FC", Offset = "0x27C02FC", VA = "0x27C42FC")]
		internal void RemoveDependentColumn(DataColumn expressionColumn)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x27C438C", Offset = "0x27C038C", VA = "0x27C438C")]
		internal void EvaluateExpressions()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x27BC1C8", Offset = "0x27B81C8", VA = "0x27BC1C8")]
		internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x27C46D0", Offset = "0x27C06D0", VA = "0x27C46D0")]
		internal void EvaluateExpressions(DataColumn column)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x27BAFC4", Offset = "0x27B6FC4", VA = "0x27BAFC4")]
		internal void EvaluateDependentExpressions(DataColumn column)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x27BE204", Offset = "0x27BA204", VA = "0x27BE204")]
		internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows)
		{
		}
	}
	[Token(Token = "0x200001C")]
	internal sealed class FunctionNode : ExpressionNode
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly string _name;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal readonly int _info;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int _argumentCount;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal ExpressionNode[] _arguments;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly TypeLimiter? _capturedLimiter;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Function[] s_funcs;

		[Token(Token = "0x1700006E")]
		internal FunctionId Aggregate
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x27DFF80", Offset = "0x27DBF80", VA = "0x27DFF80")]
			get
			{
				return default(FunctionId);
			}
		}

		[Token(Token = "0x1700006F")]
		internal bool IsAggregate
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x27E001C", Offset = "0x27DC01C", VA = "0x27E001C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x27DD0F4", Offset = "0x27D90F4", VA = "0x27DD0F4")]
		internal FunctionNode(DataTable table, string name)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x27DD230", Offset = "0x27D9230", VA = "0x27DD230")]
		internal void AddArgument(ExpressionNode argument)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x27DD410", Offset = "0x27D9410", VA = "0x27DD410", Slot = "5")]
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x27DD8CC", Offset = "0x27D98CC", VA = "0x27DD8CC", Slot = "6")]
		internal override object Eval()
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x27DD8E0", Offset = "0x27D98E0", VA = "0x27DD8E0", Slot = "7")]
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x27DFB14", Offset = "0x27DBB14", VA = "0x27DFB14", Slot = "8")]
		internal override object Eval(int[] recordNos)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x27DFB48", Offset = "0x27DBB48", VA = "0x27DFB48", Slot = "9")]
		internal override bool IsConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x27DFBD0", Offset = "0x27DBBD0", VA = "0x27DFBD0", Slot = "10")]
		internal override bool IsTableConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x27DFC4C", Offset = "0x27DBC4C", VA = "0x27DFC4C", Slot = "11")]
		internal override bool HasLocalAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x27DFCC8", Offset = "0x27DBCC8", VA = "0x27DFCC8", Slot = "12")]
		internal override bool HasRemoteAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x27DFD44", Offset = "0x27DBD44", VA = "0x27DFD44", Slot = "14")]
		internal override bool DependsOn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x27DFDCC", Offset = "0x27DBDCC", VA = "0x27DFDCC", Slot = "13")]
		internal override ExpressionNode Optimize()
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x27DE1D0", Offset = "0x27DA1D0", VA = "0x27DE1D0")]
		private Type GetDataType(ExpressionNode node)
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x27DE468", Offset = "0x27DA468", VA = "0x27DE468")]
		private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x27DD6EC", Offset = "0x27D96EC", VA = "0x27DD6EC")]
		internal void Check()
		{
		}
	}
	[Token(Token = "0x200001D")]
	internal enum FunctionId
	{
		[Token(Token = "0x40000A2")]
		none = -1,
		[Token(Token = "0x40000A3")]
		Ascii = 0,
		[Token(Token = "0x40000A4")]
		Char = 1,
		[Token(Token = "0x40000A5")]
		Charindex = 2,
		[Token(Token = "0x40000A6")]
		Difference = 3,
		[Token(Token = "0x40000A7")]
		Len = 4,
		[Token(Token = "0x40000A8")]
		Lower = 5,
		[Token(Token = "0x40000A9")]
		LTrim = 6,
		[Token(Token = "0x40000AA")]
		Patindex = 7,
		[Token(Token = "0x40000AB")]
		Replicate = 8,
		[Token(Token = "0x40000AC")]
		Reverse = 9,
		[Token(Token = "0x40000AD")]
		Right = 10,
		[Token(Token = "0x40000AE")]
		RTrim = 11,
		[Token(Token = "0x40000AF")]
		Soundex = 12,
		[Token(Token = "0x40000B0")]
		Space = 13,
		[Token(Token = "0x40000B1")]
		Str = 14,
		[Token(Token = "0x40000B2")]
		Stuff = 15,
		[Token(Token = "0x40000B3")]
		Substring = 16,
		[Token(Token = "0x40000B4")]
		Upper = 17,
		[Token(Token = "0x40000B5")]
		IsNull = 18,
		[Token(Token = "0x40000B6")]
		Iif = 19,
		[Token(Token = "0x40000B7")]
		Convert = 20,
		[Token(Token = "0x40000B8")]
		cInt = 21,
		[Token(Token = "0x40000B9")]
		cBool = 22,
		[Token(Token = "0x40000BA")]
		cDate = 23,
		[Token(Token = "0x40000BB")]
		cDbl = 24,
		[Token(Token = "0x40000BC")]
		cStr = 25,
		[Token(Token = "0x40000BD")]
		Abs = 26,
		[Token(Token = "0x40000BE")]
		Acos = 27,
		[Token(Token = "0x40000BF")]
		In = 28,
		[Token(Token = "0x40000C0")]
		Trim = 29,
		[Token(Token = "0x40000C1")]
		Sum = 30,
		[Token(Token = "0x40000C2")]
		Avg = 31,
		[Token(Token = "0x40000C3")]
		Min = 32,
		[Token(Token = "0x40000C4")]
		Max = 33,
		[Token(Token = "0x40000C5")]
		Count = 34,
		[Token(Token = "0x40000C6")]
		StDev = 35,
		[Token(Token = "0x40000C7")]
		Var = 37,
		[Token(Token = "0x40000C8")]
		DateTimeOffset = 38
	}
	[Token(Token = "0x200001E")]
	internal sealed class Function
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal readonly string _name;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly FunctionId _id;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal readonly Type _result;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal readonly bool _isValidateArguments;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		internal readonly bool _isVariantArgumentList;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal readonly int _argumentCount;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal readonly Type[] _parameters;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static string[] s_functionName;

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x27E0B8C", Offset = "0x27DCB8C", VA = "0x27E0B8C")]
		internal Function(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3)
		{
		}
	}
	[Token(Token = "0x200001F")]
	internal sealed class TypeLimiter
	{
		[Token(Token = "0x2000020")]
		private sealed class Scope : IDisposable
		{
			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly HashSet<Type> s_allowedTypes;

			[Token(Token = "0x40000D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private HashSet<Type> m_allowedTypes;

			[Token(Token = "0x40000D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly Scope? m_previousScope;

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x27E18E8", Offset = "0x27DD8E8", VA = "0x27E18E8")]
			internal Scope(Scope? previousScope, IEnumerable<Type> allowedTypes)
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x27E1CA4", Offset = "0x27DDCA4", VA = "0x27E1CA4", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x27E14FC", Offset = "0x27DD4FC", VA = "0x27E14FC")]
			public bool IsAllowedType(Type type)
			{
				return default(bool);
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x27E1D70", Offset = "0x27DDD70", VA = "0x27E1D70")]
			private static bool IsTypeUnconditionallyAllowed(Type type)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40000D1")]
		[ThreadStatic]
		private static Scope? s_activeScope;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Scope m_instanceScope;

		[Token(Token = "0x17000070")]
		private static bool IsTypeLimitingDisabled
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x27E137C", Offset = "0x27DD37C", VA = "0x27E137C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x27E1354", Offset = "0x27DD354", VA = "0x27E1354")]
		private TypeLimiter(Scope scope)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x27E13F4", Offset = "0x27DD3F4", VA = "0x27E13F4")]
		public static TypeLimiter? Capture()
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x27E1464", Offset = "0x27DD464", VA = "0x27E1464")]
		public static void EnsureTypeIsAllowed(Type? type, [Optional] TypeLimiter? capturedLimiter)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x27E1694", Offset = "0x27DD694", VA = "0x27E1694")]
		public static IDisposable EnterRestrictedScope(DataSet dataSet)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x27E1A50", Offset = "0x27DDA50", VA = "0x27E1A50")]
		public static IDisposable EnterRestrictedScope(DataTable dataTable)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x27E1B08", Offset = "0x27DDB08", VA = "0x27E1B08")]
		private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x27E174C", Offset = "0x27DD74C", VA = "0x27E174C")]
		private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet)
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	public enum AcceptRejectRule
	{
		[Token(Token = "0x40000DC")]
		None,
		[Token(Token = "0x40000DD")]
		Cascade
	}
	[Token(Token = "0x2000024")]
	internal enum AggregateType
	{
		[Token(Token = "0x40000DF")]
		None = 0,
		[Token(Token = "0x40000E0")]
		Sum = 4,
		[Token(Token = "0x40000E1")]
		Mean = 5,
		[Token(Token = "0x40000E2")]
		Min = 6,
		[Token(Token = "0x40000E3")]
		Max = 7,
		[Token(Token = "0x40000E4")]
		First = 8,
		[Token(Token = "0x40000E5")]
		Count = 9,
		[Token(Token = "0x40000E6")]
		Var = 10,
		[Token(Token = "0x40000E7")]
		StDev = 11
	}
	[Token(Token = "0x2000025")]
	public class InternalDataCollectionBase : ICollection, IEnumerable
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly CollectionChangeEventArgs s_refreshEventArgs;

		[Token(Token = "0x17000071")]
		[Browsable(false)]
		public virtual int Count
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x27E299C", Offset = "0x27DE99C", VA = "0x27E299C", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		[Browsable(false)]
		public bool IsSynchronized
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x27E2A3C", Offset = "0x27DEA3C", VA = "0x27E2A3C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		[Browsable(false)]
		public object SyncRoot
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x27E2AF0", Offset = "0x27DEAF0", VA = "0x27E2AF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		protected virtual ArrayList List
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x27E2AF4", Offset = "0x27DEAF4", VA = "0x27E2AF4", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x27E29C8", Offset = "0x27DE9C8", VA = "0x27E29C8", Slot = "10")]
		public virtual void CopyTo(Array ar, int index)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x27E2A10", Offset = "0x27DEA10", VA = "0x27E2A10", Slot = "11")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x27E2A44", Offset = "0x27DEA44", VA = "0x27E2A44")]
		internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale)
		{
			return default(int);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x27E2AFC", Offset = "0x27DEAFC", VA = "0x27E2AFC")]
		public InternalDataCollectionBase()
		{
		}
	}
	[Token(Token = "0x2000026")]
	internal sealed class ColumnTypeConverter : TypeConverter
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Type[] s_types;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private StandardValuesCollection _values;

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x27E2B7C", Offset = "0x27DEB7C", VA = "0x27E2B7C")]
		public ColumnTypeConverter()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x27E2B84", Offset = "0x27DEB84", VA = "0x27E2B84", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x27E2C4C", Offset = "0x27DEC4C", VA = "0x27E2C4C", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x27E3140", Offset = "0x27DF140", VA = "0x27E3140", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x27E3208", Offset = "0x27DF208", VA = "0x27E3208", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x27E3410", Offset = "0x27DF410", VA = "0x27E3410", Slot = "12")]
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x27E3524", Offset = "0x27DF524", VA = "0x27E3524", Slot = "13")]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x27E352C", Offset = "0x27DF52C", VA = "0x27E352C", Slot = "14")]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000027")]
	[EventSource(Name = "System.Data.DataCommonEventSource")]
	internal class DataCommonEventSource : EventSource
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly DataCommonEventSource Log;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static long s_nextScopeId;

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x27E404C", Offset = "0x27E004C", VA = "0x27E404C")]
		[Event(1, Level = EventLevel.Informational)]
		internal void Trace(string message)
		{
		}

		[Token(Token = "0x6000322")]
		[NonEvent]
		internal void Trace<T0>(string format, T0 arg0)
		{
		}

		[Token(Token = "0x6000323")]
		[NonEvent]
		internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1)
		{
		}

		[Token(Token = "0x6000324")]
		[NonEvent]
		internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2)
		{
		}

		[Token(Token = "0x6000325")]
		[NonEvent]
		internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Token(Token = "0x6000326")]
		[NonEvent]
		internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Token(Token = "0x6000327")]
		[NonEvent]
		internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x27E405C", Offset = "0x27E005C", VA = "0x27E405C")]
		[Event(2, Level = EventLevel.Verbose)]
		internal long EnterScope(string message)
		{
			return default(long);
		}

		[Token(Token = "0x6000329")]
		[NonEvent]
		internal long EnterScope<T1>(string format, T1 arg1)
		{
			return default(long);
		}

		[Token(Token = "0x600032A")]
		[NonEvent]
		internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2)
		{
			return default(long);
		}

		[Token(Token = "0x600032B")]
		[NonEvent]
		internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
		{
			return default(long);
		}

		[Token(Token = "0x600032C")]
		[NonEvent]
		internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			return default(long);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x27E4120", Offset = "0x27E0120", VA = "0x27E4120")]
		[Event(3, Level = EventLevel.Verbose)]
		internal void ExitScope(long scopeId)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x27E4130", Offset = "0x27E0130", VA = "0x27E4130")]
		public DataCommonEventSource()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[TypeConverter(typeof(ConstraintConverter))]
	[DefaultProperty("ConstraintName")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _schemaName;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _inCollection;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataSet _dataSet;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal string _name;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal PropertyCollection _extendedProperties;

		[Token(Token = "0x17000075")]
		[DefaultValue("")]
		public virtual string ConstraintName
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x27E41A0", Offset = "0x27E01A0", VA = "0x27E41A0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x27E41A8", Offset = "0x27E01A8", VA = "0x27E41A8", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		internal string SchemaName
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x27E45E4", Offset = "0x27E05E4", VA = "0x27E45E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x27E461C", Offset = "0x27E061C", VA = "0x27E461C")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		internal virtual bool InCollection
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x27E464C", Offset = "0x27E064C", VA = "0x27E464C", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x27E4654", Offset = "0x27E0654", VA = "0x27E4654", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public abstract DataTable Table
		{
			[Token(Token = "0x6000336")]
			get;
		}

		[Token(Token = "0x17000079")]
		[Browsable(false)]
		public PropertyCollection ExtendedProperties
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x27E4694", Offset = "0x27E0694", VA = "0x27E4694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		[CLSCompliant(false)]
		protected virtual DataSet _DataSet
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x27E4844", Offset = "0x27E0844", VA = "0x27E4844", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000338")]
		internal abstract bool ContainsColumn(DataColumn column);

		[Token(Token = "0x6000339")]
		internal abstract bool CanEnableConstraint();

		[Token(Token = "0x600033A")]
		internal abstract Constraint Clone(DataSet destination);

		[Token(Token = "0x600033B")]
		internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x27E46F8", Offset = "0x27E06F8", VA = "0x27E46F8")]
		internal void CheckConstraint()
		{
		}

		[Token(Token = "0x600033D")]
		internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

		[Token(Token = "0x600033E")]
		internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

		[Token(Token = "0x600033F")]
		internal abstract void CheckConstraint(DataRow row, DataRowAction action);

		[Token(Token = "0x6000340")]
		internal abstract void CheckState();

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x27E474C", Offset = "0x27E074C", VA = "0x27E474C")]
		protected void CheckStateForProperty()
		{
		}

		[Token(Token = "0x6000343")]
		internal abstract bool IsConstraintViolated();

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x27E484C", Offset = "0x27E084C", VA = "0x27E484C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x27E4858", Offset = "0x27E0858", VA = "0x27E4858")]
		protected Constraint()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[DefaultEvent("CollectionChanged")]
	public sealed class ConstraintCollection : InternalDataCollectionBase
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DataTable _table;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ArrayList _list;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _defaultNameIndex;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CollectionChangeEventHandler _onCollectionChanged;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Constraint[] _delayLoadingConstraints;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _fLoadForeignKeyConstraintsOnly;

		[Token(Token = "0x1700007B")]
		protected override ArrayList List
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x27E4954", Offset = "0x27E0954", VA = "0x27E4954", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public Constraint this[int index]
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x27E495C", Offset = "0x27E095C", VA = "0x27E495C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		internal DataTable Table
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x27E4A58", Offset = "0x27E0A58", VA = "0x27E4A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public Constraint this[string name]
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x27E4A60", Offset = "0x27E0A60", VA = "0x27E4A60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x27E48B4", Offset = "0x27E08B4", VA = "0x27E48B4")]
		internal ConstraintCollection(DataTable table)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x27E4CA8", Offset = "0x27E0CA8", VA = "0x27E4CA8")]
		public void Add(Constraint constraint)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x27E4CB0", Offset = "0x27E0CB0", VA = "0x27E4CB0")]
		internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x27E5638", Offset = "0x27E1638", VA = "0x27E5638")]
		public Constraint Add(string name, DataColumn[] columns, bool primaryKey)
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x27E5290", Offset = "0x27E1290", VA = "0x27E5290")]
		private void AddUniqueConstraint(UniqueConstraint constraint)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x27E54A0", Offset = "0x27E14A0", VA = "0x27E54A0")]
		private void AddForeignKeyConstraint(ForeignKeyConstraint constraint)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x27E51C0", Offset = "0x27E11C0", VA = "0x27E51C0")]
		private bool AutoGenerated(Constraint constraint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x27E55D8", Offset = "0x27E15D8", VA = "0x27E55D8")]
		private void ArrayAdd(Constraint constraint)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x27E56E0", Offset = "0x27E16E0", VA = "0x27E56E0")]
		private void ArrayRemove(Constraint constraint)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x27E547C", Offset = "0x27E147C", VA = "0x27E547C")]
		internal string AssignName()
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x27E5510", Offset = "0x27E1510", VA = "0x27E5510")]
		private void BaseAdd(Constraint constraint)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x27E57D0", Offset = "0x27E17D0", VA = "0x27E57D0")]
		private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x27E5980", Offset = "0x27E1980", VA = "0x27E5980")]
		private void BaseRemove(Constraint constraint)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x27E5C14", Offset = "0x27E1C14", VA = "0x27E5C14")]
		internal bool CanRemove(Constraint constraint, bool fThrowException)
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x27E5C40", Offset = "0x27E1C40", VA = "0x27E5C40")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x27E6014", Offset = "0x27E2014", VA = "0x27E6014")]
		public bool Contains(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x27E602C", Offset = "0x27E202C", VA = "0x27E602C")]
		internal bool Contains(string name, bool caseSensitive)
		{
			return default(bool);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x27E5064", Offset = "0x27E1064", VA = "0x27E5064")]
		internal Constraint FindConstraint(Constraint constraint)
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x27E5370", Offset = "0x27E1370", VA = "0x27E5370")]
		internal UniqueConstraint FindKeyConstraint(DataColumn[] columns)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x27E61B0", Offset = "0x27E21B0", VA = "0x27E61B0")]
		internal UniqueConstraint FindKeyConstraint(DataColumn column)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x27E62BC", Offset = "0x27E22BC", VA = "0x27E62BC")]
		internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x27E6128", Offset = "0x27E2128", VA = "0x27E6128")]
		private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x27E4B4C", Offset = "0x27E0B4C", VA = "0x27E4B4C")]
		internal int InternalIndexOf(string constraintName)
		{
			return default(int);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x27E5718", Offset = "0x27E1718", VA = "0x27E5718")]
		private string MakeName(int index)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x27E5610", Offset = "0x27E1610", VA = "0x27E5610")]
		private void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x27E437C", Offset = "0x27E037C", VA = "0x27E437C")]
		internal void RegisterName(string name)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x27E63EC", Offset = "0x27E23EC", VA = "0x27E63EC")]
		public void Remove(Constraint constraint)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x27E4564", Offset = "0x27E0564", VA = "0x27E4564")]
		internal void UnregisterName(string name)
		{
		}
	}
	[Token(Token = "0x200002A")]
	internal sealed class ConstraintConverter : ExpandableObjectConverter
	{
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x27E6548", Offset = "0x27E2548", VA = "0x27E6548")]
		public ConstraintConverter()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x27E6550", Offset = "0x27E2550", VA = "0x27E6550", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x27E6618", Offset = "0x27E2618", VA = "0x27E6618", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}
	}
	[Token(Token = "0x200002B")]
	internal class ConstraintEnumerator
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IEnumerator _tables;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IEnumerator _constraints;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Constraint _currentObject;

		[Token(Token = "0x1700007F")]
		protected Constraint CurrentObject
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x27E7314", Offset = "0x27E3314", VA = "0x27E7314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x27E6FD0", Offset = "0x27E2FD0", VA = "0x27E6FD0")]
		public ConstraintEnumerator(DataSet dataSet)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x27E7024", Offset = "0x27E3024", VA = "0x27E7024")]
		public bool GetNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x27E7304", Offset = "0x27E3304", VA = "0x27E7304")]
		public Constraint GetConstraint()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x27E730C", Offset = "0x27E330C", VA = "0x27E730C", Slot = "4")]
		protected virtual bool IsValidCandidate(Constraint constraint)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002C")]
	internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator
	{
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x27E731C", Offset = "0x27E331C", VA = "0x27E731C")]
		public ForeignKeyConstraintEnumerator(DataSet dataSet)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x27E7320", Offset = "0x27E3320", VA = "0x27E7320", Slot = "4")]
		protected override bool IsValidCandidate(Constraint constraint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x27E7398", Offset = "0x27E3398", VA = "0x27E7398")]
		public ForeignKeyConstraint GetForeignKeyConstraint()
		{
			return null;
		}
	}
	[Token(Token = "0x200002D")]
	internal sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly DataTable _table;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x27E7410", Offset = "0x27E3410", VA = "0x27E7410")]
		public ChildForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x27E7434", Offset = "0x27E3434", VA = "0x27E7434", Slot = "4")]
		protected override bool IsValidCandidate(Constraint constraint)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002E")]
	internal sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly DataTable _table;

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x27E74C8", Offset = "0x27E34C8", VA = "0x27E74C8")]
		public ParentForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x27E74EC", Offset = "0x27E34EC", VA = "0x27E74EC", Slot = "4")]
		protected override bool IsValidCandidate(Constraint constraint)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002F")]
	public class DataColumnChangeEventArgs : EventArgs
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DataColumn _column;

		[Token(Token = "0x17000080")]
		public object ProposedValue
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x27E7670", Offset = "0x27E3670", VA = "0x27E7670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x27E7678", Offset = "0x27E3678", VA = "0x27E7678")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x27E7584", Offset = "0x27E3584", VA = "0x27E7584")]
		internal DataColumnChangeEventArgs(DataRow row)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x27E75F0", Offset = "0x27E35F0", VA = "0x27E75F0")]
		public DataColumnChangeEventArgs(DataRow row, DataColumn column, object value)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x27E7680", Offset = "0x27E3680", VA = "0x27E7680")]
		internal void InitializeColumnChangeEvent(DataColumn column, object value)
		{
		}
	}
	[Token(Token = "0x2000030")]
	public delegate void DataColumnChangeEventHandler(object sender, DataColumnChangeEventArgs e);
	[Token(Token = "0x2000031")]
	[DefaultEvent("CollectionChanged")]
	public sealed class DataColumnCollection : InternalDataCollectionBase
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DataTable _table;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ArrayList _list;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _defaultNameIndex;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DataColumn[] _delayedAddRangeColumns;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, DataColumn> _columnFromName;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _fInClear;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DataColumn[] _columnsImplementingIChangeTracking;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _nColumnsImplementingIChangeTracking;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _nColumnsImplementingIRevertibleChangeTracking;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[CompilerGenerated]
		private CollectionChangeEventHandler CollectionChanging;

		[Token(Token = "0x17000081")]
		protected override ArrayList List
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x27E78F4", Offset = "0x27E38F4", VA = "0x27E78F4", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		internal DataColumn[] ColumnsImplementingIChangeTracking
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x27E78FC", Offset = "0x27E38FC", VA = "0x27E78FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		internal int ColumnsImplementingIChangeTrackingCount
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x27E7904", Offset = "0x27E3904", VA = "0x27E7904")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000084")]
		internal int ColumnsImplementingIRevertibleChangeTrackingCount
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x27E790C", Offset = "0x27E390C", VA = "0x27E790C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000085")]
		public DataColumn this[int index]
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x27E7914", Offset = "0x27E3914", VA = "0x27E7914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public DataColumn this[string name]
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x27E7A44", Offset = "0x27E3A44", VA = "0x27E7A44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		internal DataColumn this[string name, string ns]
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x27E7CD0", Offset = "0x27E3CD0", VA = "0x27E7CD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event CollectionChangeEventHandler CollectionChanged
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x27E843C", Offset = "0x27E443C", VA = "0x27E843C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x27E84D8", Offset = "0x27E44D8", VA = "0x27E84D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		internal event CollectionChangeEventHandler ColumnPropertyChanged
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x27E8574", Offset = "0x27E4574", VA = "0x27E8574")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x27E8610", Offset = "0x27E4610", VA = "0x27E8610")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x27E77A4", Offset = "0x27E37A4", VA = "0x27E77A4")]
		internal DataColumnCollection(DataTable table)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x27E7D74", Offset = "0x27E3D74", VA = "0x27E7D74")]
		public void Add(DataColumn column)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x27E7D80", Offset = "0x27E3D80", VA = "0x27E7D80")]
		internal void AddAt(int index, DataColumn column)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x27E832C", Offset = "0x27E432C", VA = "0x27E832C")]
		private void ArrayAdd(DataColumn column)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x27E82EC", Offset = "0x27E42EC", VA = "0x27E82EC")]
		private void ArrayAdd(int index, DataColumn column)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x27E86EC", Offset = "0x27E46EC", VA = "0x27E86EC")]
		private void ArrayRemove(DataColumn column)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x27E8924", Offset = "0x27E4924", VA = "0x27E8924")]
		internal string AssignName()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x27E8004", Offset = "0x27E4004", VA = "0x27E8004")]
		private void BaseAdd(DataColumn column)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x27E8CEC", Offset = "0x27E4CEC", VA = "0x27E8CEC")]
		private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x27E8EC8", Offset = "0x27E4EC8", VA = "0x27E8EC8")]
		private void BaseRemove(DataColumn column)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x27E8F80", Offset = "0x27E4F80", VA = "0x27E8F80")]
		internal bool CanRemove(DataColumn column, bool fThrowException)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x27E86AC", Offset = "0x27E46AC", VA = "0x27E86AC")]
		private void CheckIChangeTracking(DataColumn column)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x27E9784", Offset = "0x27E5784", VA = "0x27E9784")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x27E9A58", Offset = "0x27E5A58", VA = "0x27E9A58")]
		public bool Contains(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x27E9AEC", Offset = "0x27E5AEC", VA = "0x27E9AEC")]
		internal bool Contains(string name, bool caseSensitive)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x27E9B88", Offset = "0x27E5B88", VA = "0x27E9B88")]
		public int IndexOf(string columnName)
		{
			return default(int);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x27E7B80", Offset = "0x27E3B80", VA = "0x27E7B80")]
		internal int IndexOfCaseInsensitive(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x27E89B8", Offset = "0x27E49B8", VA = "0x27E89B8")]
		private string MakeName(int index)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x27E8398", Offset = "0x27E4398", VA = "0x27E8398")]
		private void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x27E7FDC", Offset = "0x27E3FDC", VA = "0x27E7FDC")]
		private void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x27E9C88", Offset = "0x27E5C88", VA = "0x27E9C88")]
		internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x27E8A70", Offset = "0x27E4A70", VA = "0x27E8A70")]
		internal void RegisterColumnName(string name, DataColumn column)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x27E9CE0", Offset = "0x27E5CE0", VA = "0x27E9CE0")]
		internal bool CanRegisterName(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x27E9D44", Offset = "0x27E5D44", VA = "0x27E9D44")]
		public void Remove(DataColumn column)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x27E8C30", Offset = "0x27E4C30", VA = "0x27E8C30")]
		internal void UnregisterName(string name)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x27E96BC", Offset = "0x27E56BC", VA = "0x27E96BC")]
		private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x27E881C", Offset = "0x27E481C", VA = "0x27E881C")]
		private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
		{
		}
	}
	[Token(Token = "0x2000032")]
	internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor
	{
		[Token(Token = "0x17000088")]
		public override AttributeCollection Attributes
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x27E9E88", Offset = "0x27E5E88", VA = "0x27E9E88", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		internal DataColumn Column
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x27EA04C", Offset = "0x27E604C", VA = "0x27EA04C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public override Type ComponentType
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x27EA054", Offset = "0x27E6054", VA = "0x27EA054", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x27EA0C0", Offset = "0x27E60C0", VA = "0x27EA0C0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		public override Type PropertyType
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x27EA0D8", Offset = "0x27E60D8", VA = "0x27EA0D8", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x27E9E50", Offset = "0x27E5E50", VA = "0x27E9E50")]
		internal DataColumnPropertyDescriptor(DataColumn dataColumn)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x27EA0F0", Offset = "0x27E60F0", VA = "0x27EA0F0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x27EA160", Offset = "0x27E6160", VA = "0x27EA160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x27EA17C", Offset = "0x27E617C", VA = "0x27EA17C", Slot = "17")]
		public override bool CanResetValue(object component)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x27EA2DC", Offset = "0x27E62DC", VA = "0x27EA2DC", Slot = "18")]
		public override object GetValue(object component)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x27EA364", Offset = "0x27E6364", VA = "0x27EA364", Slot = "20")]
		public override void ResetValue(object component)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x27EA4B4", Offset = "0x27E64B4", VA = "0x27EA4B4", Slot = "21")]
		public override void SetValue(object component, object value)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x27EA594", Offset = "0x27E6594", VA = "0x27EA594", Slot = "22")]
		public override bool ShouldSerializeValue(object component)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000033")]
	internal sealed class DataError
	{
		[Token(Token = "0x2000034")]
		internal struct ColumnError
		{
			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal DataColumn _column;

			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string _error;
		}

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _rowError;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _count;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ColumnError[] _errorList;

		[Token(Token = "0x1700008D")]
		internal string Text
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x27EA6E8", Offset = "0x27E66E8", VA = "0x27EA6E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x27EA6F0", Offset = "0x27E66F0", VA = "0x27EA6F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		internal bool HasErrors
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x27EA748", Offset = "0x27E6748", VA = "0x27EA748")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x27EA59C", Offset = "0x27E659C", VA = "0x27EA59C")]
		internal DataError()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x27EA5F4", Offset = "0x27E65F4", VA = "0x27EA5F4")]
		internal DataError(string rowError)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x27EA778", Offset = "0x27E6778", VA = "0x27EA778")]
		internal void SetColumnError(DataColumn column, string error)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x27EAA44", Offset = "0x27E6A44", VA = "0x27EAA44")]
		internal string GetColumnError(DataColumn column)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x27EA858", Offset = "0x27E6858", VA = "0x27EA858")]
		internal void Clear(DataColumn column)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x27EAAD8", Offset = "0x27E6AD8", VA = "0x27EAAD8")]
		internal void Clear()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x27EAB78", Offset = "0x27E6B78", VA = "0x27EAB78")]
		internal DataColumn[] GetColumnsInError()
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x27EA690", Offset = "0x27E6690", VA = "0x27EA690")]
		private void SetText(string errorText)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x27EA904", Offset = "0x27E6904", VA = "0x27EA904")]
		internal int IndexOf(DataColumn column)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000035")]
	internal readonly struct DataKey
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly DataColumn[] _columns;

		[Token(Token = "0x1700008F")]
		internal DataColumn[] ColumnsReference
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x27EAEF8", Offset = "0x27E6EF8", VA = "0x27EAEF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		internal bool HasValue
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x27EAF00", Offset = "0x27E6F00", VA = "0x27EAF00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		internal DataTable Table
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x27E6FA0", Offset = "0x27E2FA0", VA = "0x27E6FA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x27EAC68", Offset = "0x27E6C68", VA = "0x27EAC68")]
		internal DataKey(DataColumn[] columns, bool copyColumns)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x27EAE60", Offset = "0x27E6E60", VA = "0x27EAE60")]
		internal void CheckState()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x27EAF10", Offset = "0x27E6F10", VA = "0x27EAF10")]
		internal bool ColumnsEqual(DataKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x27EAF18", Offset = "0x27E6F18", VA = "0x27EAF18")]
		internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x27E9628", Offset = "0x27E5628", VA = "0x27E9628")]
		internal bool ContainsColumn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x27EB008", Offset = "0x27E7008", VA = "0x27EB008", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x27EB06C", Offset = "0x27E706C", VA = "0x27EB06C", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x27EB0E8", Offset = "0x27E70E8", VA = "0x27EB0E8")]
		internal bool Equals(DataKey value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x27EB1A0", Offset = "0x27E71A0", VA = "0x27EB1A0")]
		internal string[] GetColumnNames()
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x27EB24C", Offset = "0x27E724C", VA = "0x27EB24C")]
		internal IndexField[] GetIndexDesc()
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x27EB31C", Offset = "0x27E731C", VA = "0x27EB31C")]
		internal object[] GetKeyValues(int record)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x27EB41C", Offset = "0x27E741C", VA = "0x27EB41C")]
		internal Index GetSortIndex()
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x27EB424", Offset = "0x27E7424", VA = "0x27EB424")]
		internal Index GetSortIndex(DataViewRowState recordStates)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x27EB47C", Offset = "0x27E747C", VA = "0x27EB47C")]
		internal bool RecordsEqual(int record1, int record2)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x27EB500", Offset = "0x27E7500", VA = "0x27EB500")]
		internal DataColumn[] ToArray()
		{
			return null;
		}
	}
	[Token(Token = "0x2000036")]
	[DefaultProperty("RelationName")]
	[TypeConverter(typeof(RelationshipConverter))]
	public class DataRelation
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DataSet _dataSet;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal PropertyCollection _extendedProperties;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string _relationName;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DataKey _childKey;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DataKey _parentKey;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UniqueConstraint _parentKeyConstraint;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ForeignKeyConstraint _childKeyConstraint;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal string[] _parentColumnNames;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal string[] _childColumnNames;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal string _parentTableName;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal string _childTableName;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal string _parentTableNamespace;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal string _childTableNamespace;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal bool _nested;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		internal bool _createConstraints;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		private bool _checkMultipleNested;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_objectTypeCount;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private readonly int _objectID;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanging;

		[Token(Token = "0x17000092")]
		public virtual DataColumn[] ChildColumns
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x27EBD20", Offset = "0x27E7D20", VA = "0x27EBD20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		internal DataColumn[] ChildColumnsReference
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x27EBE24", Offset = "0x27E7E24", VA = "0x27EBE24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		internal DataKey ChildKey
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x27E968C", Offset = "0x27E568C", VA = "0x27E968C")]
			get
			{
				return default(DataKey);
			}
		}

		[Token(Token = "0x17000095")]
		public virtual DataTable ChildTable
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x27EBE3C", Offset = "0x27E7E3C", VA = "0x27EBE3C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual DataSet DataSet
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x27EBE54", Offset = "0x27E7E54", VA = "0x27EBE54", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		internal string[] ParentColumnNames
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x27EBE6C", Offset = "0x27E7E6C", VA = "0x27EBE6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		internal string[] ChildColumnNames
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x27EBE74", Offset = "0x27E7E74", VA = "0x27EBE74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public virtual DataColumn[] ParentColumns
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x27EC26C", Offset = "0x27E826C", VA = "0x27EC26C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		internal DataColumn[] ParentColumnsReference
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x27EC284", Offset = "0x27E8284", VA = "0x27EC284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		internal DataKey ParentKey
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x27E96A4", Offset = "0x27E56A4", VA = "0x27E96A4")]
			get
			{
				return default(DataKey);
			}
		}

		[Token(Token = "0x1700009C")]
		public virtual DataTable ParentTable
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x27EC28C", Offset = "0x27E828C", VA = "0x27EC28C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		[DefaultValue("")]
		public virtual string RelationName
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x27EC2A4", Offset = "0x27E82A4", VA = "0x27EC2A4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		[DefaultValue(false)]
		public virtual bool Nested
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x27ECA28", Offset = "0x27E8A28", VA = "0x27ECA28", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x27ECA40", Offset = "0x27E8A40", VA = "0x27ECA40", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public virtual UniqueConstraint ParentKeyConstraint
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x27EDFD4", Offset = "0x27E9FD4", VA = "0x27EDFD4", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public virtual ForeignKeyConstraint ChildKeyConstraint
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x27EDFF4", Offset = "0x27E9FF4", VA = "0x27EDFF4", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		[Browsable(false)]
		public PropertyCollection ExtendedProperties
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x27EE00C", Offset = "0x27EA00C", VA = "0x27EE00C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		internal bool CheckMultipleNested
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x27EE070", Offset = "0x27EA070", VA = "0x27EE070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x27EE078", Offset = "0x27EA078", VA = "0x27EE078")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		internal int ObjectID
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x27EEC84", Offset = "0x27EAC84", VA = "0x27EEC84")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x27EB5D8", Offset = "0x27E75D8", VA = "0x27EB5D8")]
		public DataRelation(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x27EBA8C", Offset = "0x27E7A8C", VA = "0x27EBA8C")]
		public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x27EBA94", Offset = "0x27E7A94", VA = "0x27EBA94")]
		public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x27EBB5C", Offset = "0x27E7B5C", VA = "0x27EBB5C")]
		[Browsable(false)]
		public DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x27EBC34", Offset = "0x27E7C34", VA = "0x27EBC34")]
		[Browsable(false)]
		public DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x27EBE7C", Offset = "0x27E7E7C", VA = "0x27EBE7C")]
		private static bool IsKeyNull(object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x27EBF38", Offset = "0x27E7F38", VA = "0x27EBF38")]
		internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x27EBFF0", Offset = "0x27E7FF0", VA = "0x27EBFF0")]
		internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x27EC088", Offset = "0x27E8088", VA = "0x27EC088")]
		internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x27EC258", Offset = "0x27E8258", VA = "0x27EC258")]
		internal void SetDataSet(DataSet dataSet)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x27EC2BC", Offset = "0x27E82BC", VA = "0x27EC2BC")]
		internal void CheckNamespaceValidityForNestedRelations(string ns)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x27EC618", Offset = "0x27E8618", VA = "0x27EC618")]
		internal void CheckNestedRelations()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x27EDFEC", Offset = "0x27E9FEC", VA = "0x27EDFEC")]
		internal void SetParentKeyConstraint(UniqueConstraint value)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x27EE080", Offset = "0x27EA080", VA = "0x27EE080")]
		internal void SetChildKeyConstraint(ForeignKeyConstraint value)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x27EE088", Offset = "0x27EA088", VA = "0x27EE088")]
		internal void CheckState()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x27EBD38", Offset = "0x27E7D38", VA = "0x27EBD38")]
		protected void CheckStateForProperty()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x27EB7D0", Offset = "0x27E77D0", VA = "0x27EB7D0")]
		private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x27EE2B4", Offset = "0x27EA2B4", VA = "0x27EE2B4")]
		internal DataRelation Clone(DataSet destination)
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x27EE9D4", Offset = "0x27EA9D4", VA = "0x27EE9D4")]
		protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x27EDE8C", Offset = "0x27E9E8C", VA = "0x27EDE8C")]
		protected internal void RaisePropertyChanging(string name)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x27EEAA4", Offset = "0x27EAAA4", VA = "0x27EEAA4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x27ED9E0", Offset = "0x27E99E0", VA = "0x27ED9E0")]
		internal void ValidateMultipleNestedRelations()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x27EEAB0", Offset = "0x27EAAB0", VA = "0x27EEAB0")]
		private bool IsAutoGenerated(DataColumn col)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000037")]
	[DefaultEvent("CollectionChanged")]
	[DefaultProperty("Table")]
	public abstract class DataRelationCollection : InternalDataCollectionBase
	{
		[Token(Token = "0x2000038")]
		internal sealed class DataTableRelationCollection : DataRelationCollection
		{
			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private readonly DataTable _table;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private readonly ArrayList _relations;

			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private readonly bool _fParentCollection;

			[Token(Token = "0x170000A7")]
			protected override ArrayList List
			{
				[Token(Token = "0x600040E")]
				[Address(RVA = "0x27F0168", Offset = "0x27EC168", VA = "0x27F0168", Slot = "12")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			public override DataRelation this[int index]
			{
				[Token(Token = "0x6000411")]
				[Address(RVA = "0x27F01D8", Offset = "0x27EC1D8", VA = "0x27F01D8", Slot = "13")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			public override DataRelation this[string name]
			{
				[Token(Token = "0x6000412")]
				[Address(RVA = "0x27F02D8", Offset = "0x27EC2D8", VA = "0x27F02D8", Slot = "14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x14000004")]
			internal event CollectionChangeEventHandler RelationPropertyChanged
			{
				[Token(Token = "0x6000413")]
				[Address(RVA = "0x27F03C4", Offset = "0x27EC3C4", VA = "0x27F03C4")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6000414")]
				[Address(RVA = "0x27F0460", Offset = "0x27EC460", VA = "0x27F0460")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x27F00C4", Offset = "0x27EC0C4", VA = "0x27F00C4")]
			internal DataTableRelationCollection(DataTable table, bool fParentCollection)
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x27F0170", Offset = "0x27EC170", VA = "0x27F0170")]
			private void EnsureDataSet()
			{
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x27F01B4", Offset = "0x27EC1B4", VA = "0x27F01B4", Slot = "18")]
			protected override DataSet GetDataSet()
			{
				return null;
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x27F04FC", Offset = "0x27EC4FC", VA = "0x27F04FC")]
			private void AddCache(DataRelation relation)
			{
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x27F0544", Offset = "0x27EC544", VA = "0x27F0544", Slot = "15")]
			protected override void AddCore(DataRelation relation)
			{
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x27F060C", Offset = "0x27EC60C", VA = "0x27F060C")]
			private void RemoveCache(DataRelation relation)
			{
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x27F06E0", Offset = "0x27EC6E0", VA = "0x27F06E0", Slot = "21")]
			protected override void RemoveCore(DataRelation relation)
			{
			}
		}

		[Token(Token = "0x2000039")]
		internal sealed class DataSetRelationCollection : DataRelationCollection
		{
			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private readonly DataSet _dataSet;

			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private readonly ArrayList _relations;

			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private DataRelation[] _delayLoadingRelations;

			[Token(Token = "0x170000AA")]
			protected override ArrayList List
			{
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x27F0838", Offset = "0x27EC838", VA = "0x27F0838", Slot = "12")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			public override DataRelation this[int index]
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x27F087C", Offset = "0x27EC87C", VA = "0x27F087C", Slot = "13")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			public override DataRelation this[string name]
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x27F097C", Offset = "0x27EC97C", VA = "0x27F097C", Slot = "14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x27F07A8", Offset = "0x27EC7A8", VA = "0x27F07A8")]
			internal DataSetRelationCollection(DataSet dataSet)
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x27F0840", Offset = "0x27EC840", VA = "0x27F0840", Slot = "16")]
			public override void Clear()
			{
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x27F0874", Offset = "0x27EC874", VA = "0x27F0874", Slot = "18")]
			protected override DataSet GetDataSet()
			{
				return null;
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x27F0A68", Offset = "0x27ECA68", VA = "0x27F0A68", Slot = "15")]
			protected override void AddCore(DataRelation relation)
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x27F0FA0", Offset = "0x27ECFA0", VA = "0x27F0FA0", Slot = "21")]
			protected override void RemoveCore(DataRelation relation)
			{
			}
		}

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DataRelation _inTransition;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _defaultNameIndex;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CollectionChangeEventHandler _onCollectionChangedDelegate;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CollectionChangeEventHandler _onCollectionChangingDelegate;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_objectTypeCount;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly int _objectID;

		[Token(Token = "0x170000A4")]
		internal int ObjectID
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x27EEC8C", Offset = "0x27EAC8C", VA = "0x27EEC8C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A5")]
		public abstract DataRelation this[int index]
		{
			[Token(Token = "0x60003F9")]
			get;
		}

		[Token(Token = "0x170000A6")]
		public abstract DataRelation this[string name]
		{
			[Token(Token = "0x60003FA")]
			get;
		}

		[Token(Token = "0x14000003")]
		public event CollectionChangeEventHandler CollectionChanged
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x27EF148", Offset = "0x27EB148", VA = "0x27EF148")]
			add
			{
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x27EF240", Offset = "0x27EB240", VA = "0x27EF240")]
			remove
			{
			}
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x27EEC94", Offset = "0x27EAC94", VA = "0x27EEC94")]
		public void Add(DataRelation relation)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x27EEEDC", Offset = "0x27EAEDC", VA = "0x27EEEDC", Slot = "15")]
		protected virtual void AddCore(DataRelation relation)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x27EF338", Offset = "0x27EB338", VA = "0x27EF338")]
		internal string AssignName()
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x27EF414", Offset = "0x27EB414", VA = "0x27EF414", Slot = "16")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x27EF630", Offset = "0x27EB630", VA = "0x27EF630", Slot = "17")]
		public virtual bool Contains(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x27EF648", Offset = "0x27EB648", VA = "0x27EF648")]
		internal int InternalIndexOf(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000403")]
		protected abstract DataSet GetDataSet();

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x27EF35C", Offset = "0x27EB35C", VA = "0x27EF35C")]
		private string MakeName(int index)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x27EF7C0", Offset = "0x27EB7C0", VA = "0x27EF7C0", Slot = "19")]
		protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x27EF890", Offset = "0x27EB890", VA = "0x27EF890", Slot = "20")]
		protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x27EF960", Offset = "0x27EB960", VA = "0x27EF960")]
		internal void RegisterName(string name)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x27EFB1C", Offset = "0x27EBB1C", VA = "0x27EFB1C")]
		public void Remove(DataRelation relation)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x27EFCC8", Offset = "0x27EBCC8", VA = "0x27EFCC8")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x27EFD3C", Offset = "0x27EBD3C", VA = "0x27EFD3C", Slot = "21")]
		protected virtual void RemoveCore(DataRelation relation)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x27EFF04", Offset = "0x27EBF04", VA = "0x27EFF04")]
		internal void UnregisterName(string name)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x27F0030", Offset = "0x27EC030", VA = "0x27F0030")]
		protected DataRelationCollection()
		{
		}
	}
	[Token(Token = "0x200003A")]
	internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor
	{
		[Token(Token = "0x170000AD")]
		internal DataRelation Relation
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x27F121C", Offset = "0x27ED21C", VA = "0x27F121C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public override Type ComponentType
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x27F1224", Offset = "0x27ED224", VA = "0x27F1224", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x27F1290", Offset = "0x27ED290", VA = "0x27F1290", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		public override Type PropertyType
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x27F1298", Offset = "0x27ED298", VA = "0x27F1298", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x27F11D0", Offset = "0x27ED1D0", VA = "0x27F11D0")]
		internal DataRelationPropertyDescriptor(DataRelation dataRelation)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x27F1304", Offset = "0x27ED304", VA = "0x27F1304", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x27F1374", Offset = "0x27ED374", VA = "0x27F1374", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x27F1390", Offset = "0x27ED390", VA = "0x27F1390", Slot = "17")]
		public override bool CanResetValue(object component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x27F1398", Offset = "0x27ED398", VA = "0x27F1398", Slot = "18")]
		public override object GetValue(object component)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x27F142C", Offset = "0x27ED42C", VA = "0x27F142C", Slot = "20")]
		public override void ResetValue(object component)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x27F1430", Offset = "0x27ED430", VA = "0x27F1430", Slot = "21")]
		public override void SetValue(object component, object value)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x27F1434", Offset = "0x27ED434", VA = "0x27F1434", Slot = "22")]
		public override bool ShouldSerializeValue(object component)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003B")]
	public class DataRow
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DataTable _table;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly DataColumnCollection _columns;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int _oldRecord;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int _newRecord;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int _tempRecord;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal long _rowID;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal DataRowAction _action;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal bool _inChangingEvent;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		internal bool _inDeletingEvent;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		internal bool _inCascade;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DataColumn _lastChangedColumn;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _countColumnChange;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DataError _error;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _rbTreeNodeId;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_objectTypeCount;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal readonly int _objectID;

		[Token(Token = "0x170000B1")]
		internal DataColumn LastChangedColumn
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x27F14DC", Offset = "0x27ED4DC", VA = "0x27F14DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x27F14F8", Offset = "0x27ED4F8", VA = "0x27F14F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		internal bool HasPropertyChanged
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x27F150C", Offset = "0x27ED50C", VA = "0x27F150C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		internal int RBTreeNodeId
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x27F151C", Offset = "0x27ED51C", VA = "0x27F151C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x27F1524", Offset = "0x27ED524", VA = "0x27F1524")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public string RowError
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x27F15D4", Offset = "0x27ED5D4", VA = "0x27F15D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x27F1630", Offset = "0x27ED630", VA = "0x27F1630")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		internal long rowID
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x27F17E0", Offset = "0x27ED7E0", VA = "0x27F17E0")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x27F17E8", Offset = "0x27ED7E8", VA = "0x27F17E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public DataRowState RowState
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x27F1804", Offset = "0x27ED804", VA = "0x27F1804")]
			get
			{
				return default(DataRowState);
			}
		}

		[Token(Token = "0x170000B7")]
		public DataTable Table
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x27F1A24", Offset = "0x27EDA24", VA = "0x27F1A24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public string this[string columnName]
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x27F1AF4", Offset = "0x27EDAF4", VA = "0x27F1AF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public object this[DataColumn column]
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x27F19E8", Offset = "0x27ED9E8", VA = "0x27F19E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x27F1B88", Offset = "0x27EDB88", VA = "0x27F1B88")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public object this[DataColumn column, DataRowVersion version]
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x27F219C", Offset = "0x27EE19C", VA = "0x27F219C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public object[] ItemArray
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x27F2240", Offset = "0x27EE240", VA = "0x27F2240")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public bool HasErrors
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x27F2CBC", Offset = "0x27EECBC", VA = "0x27F2CBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x27F143C", Offset = "0x27ED43C", VA = "0x27F143C")]
		protected internal DataRow(DataRowBuilder builder)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x27F1790", Offset = "0x27ED790", VA = "0x27F1790")]
		private void RowErrorChanged()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x27EDEF8", Offset = "0x27E9EF8", VA = "0x27EDEF8")]
		internal void CheckForLoops(DataRelation rel)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x27F1A2C", Offset = "0x27EDA2C", VA = "0x27F1A2C")]
		internal int GetNestedParentCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x27F25F0", Offset = "0x27EE5F0", VA = "0x27F25F0")]
		public void AcceptChanges()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x27F2948", Offset = "0x27EE948", VA = "0x27F2948")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void BeginEdit()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x27F1F68", Offset = "0x27EDF68", VA = "0x27F1F68")]
		private bool BeginEditInternal()
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x27F2064", Offset = "0x27EE064", VA = "0x27F2064")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void CancelEdit()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x27F1E7C", Offset = "0x27EDE7C", VA = "0x27F1E7C")]
		private void CheckColumn(DataColumn column)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x27F294C", Offset = "0x27EE94C", VA = "0x27F294C")]
		internal void CheckInTable()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x27F2984", Offset = "0x27EE984", VA = "0x27F2984")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x27F20C0", Offset = "0x27EE0C0", VA = "0x27F20C0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndEdit()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x27F29E4", Offset = "0x27EE9E4", VA = "0x27F29E4")]
		public void SetColumnError(int columnIndex, string error)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x27F2A48", Offset = "0x27EEA48", VA = "0x27F2A48")]
		public void SetColumnError(DataColumn column, string error)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x27F2C18", Offset = "0x27EEC18", VA = "0x27F2C18")]
		public string GetColumnError(DataColumn column)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x27F2C94", Offset = "0x27EEC94", VA = "0x27F2C94")]
		public void ClearErrors()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x27E9600", Offset = "0x27E5600", VA = "0x27E9600")]
		internal void ClearError(DataColumn column)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x27F2CFC", Offset = "0x27EECFC", VA = "0x27F2CFC")]
		public DataColumn[] GetColumnsInError()
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x27F2DA8", Offset = "0x27EEDA8", VA = "0x27F2DA8")]
		public DataRow[] GetChildRows(DataRelation relation)
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x27F2DB0", Offset = "0x27EEDB0", VA = "0x27F2DB0")]
		public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x27F1B20", Offset = "0x27EDB20", VA = "0x27F1B20")]
		internal DataColumn GetDataColumn(string columnName)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x27EDFCC", Offset = "0x27E9FCC", VA = "0x27EDFCC")]
		public DataRow GetParentRow(DataRelation relation)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x27F2ED4", Offset = "0x27EEED4", VA = "0x27F2ED4")]
		public DataRow GetParentRow(DataRelation relation, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x27F2FEC", Offset = "0x27EEFEC", VA = "0x27F2FEC")]
		internal DataRow GetNestedParentRow(DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x27F30A8", Offset = "0x27EF0A8", VA = "0x27F30A8")]
		public DataRow[] GetParentRows(DataRelation relation)
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x27F30B0", Offset = "0x27EF0B0", VA = "0x27F30B0")]
		public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x27F31D4", Offset = "0x27EF1D4", VA = "0x27F31D4")]
		internal object[] GetColumnValues(DataColumn[] columns)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x27F31DC", Offset = "0x27EF1DC", VA = "0x27F31DC")]
		internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x27F3220", Offset = "0x27EF220", VA = "0x27F3220")]
		internal object[] GetKeyValues(DataKey key)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x27EBFD0", Offset = "0x27E7FD0", VA = "0x27EBFD0")]
		internal object[] GetKeyValues(DataKey key, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x27F323C", Offset = "0x27EF23C", VA = "0x27F323C")]
		internal int GetCurrentRecordNo()
		{
			return default(int);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x27F1F08", Offset = "0x27EDF08", VA = "0x27F1F08")]
		internal int GetDefaultRecord()
		{
			return default(int);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x27F3274", Offset = "0x27EF274", VA = "0x27F3274")]
		internal int GetOriginalRecordNo()
		{
			return default(int);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x27F202C", Offset = "0x27EE02C", VA = "0x27F202C")]
		private int GetProposedRecordNo()
		{
			return default(int);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x27F21E0", Offset = "0x27EE1E0", VA = "0x27F21E0")]
		internal int GetRecordFromVersion(DataRowVersion version)
		{
			return default(int);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x27F32AC", Offset = "0x27EF2AC", VA = "0x27F32AC")]
		internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState)
		{
			return default(DataRowVersion);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x27F32DC", Offset = "0x27EF2DC", VA = "0x27F32DC")]
		internal DataViewRowState GetRecordState(int record)
		{
			return default(DataViewRowState);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x27F3334", Offset = "0x27EF334", VA = "0x27F3334")]
		internal bool HasKeyChanged(DataKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x27F3340", Offset = "0x27EF340", VA = "0x27F3340")]
		internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x27EC1D4", Offset = "0x27E81D4", VA = "0x27EC1D4")]
		public bool HasVersion(DataRowVersion version)
		{
			return default(bool);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x27F33C4", Offset = "0x27EF3C4", VA = "0x27F33C4")]
		internal bool HaveValuesChanged(DataColumn[] columns)
		{
			return default(bool);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x27F33D0", Offset = "0x27EF3D0", VA = "0x27F33D0")]
		internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x27F3470", Offset = "0x27EF470", VA = "0x27F3470")]
		public void RejectChanges()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x27F17F8", Offset = "0x27ED7F8", VA = "0x27F17F8")]
		internal void ResetLastChangedColumn()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x27F3A30", Offset = "0x27EFA30", VA = "0x27F3A30")]
		internal void SetKeyValues(DataKey key, object[] keyValues)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x27F3B48", Offset = "0x27EFB48", VA = "0x27F3B48")]
		internal void SetNestedParentRow(DataRow parentRow, bool setNonNested)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x27F3F08", Offset = "0x27EFF08", VA = "0x27F3F08")]
		internal void SetParentRowToDBNull()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x27F41B4", Offset = "0x27F01B4", VA = "0x27F41B4")]
		internal void SetParentRowToDBNull(DataRelation relation)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x27F431C", Offset = "0x27F031C", VA = "0x27F431C")]
		internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200003C")]
	public sealed class DataRowBuilder
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal readonly DataTable _table;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int _record;

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x27F4608", Offset = "0x27F0608", VA = "0x27F4608")]
		internal DataRowBuilder(DataTable table, int record)
		{
		}
	}
	[Token(Token = "0x200003D")]
	[Flags]
	public enum DataRowAction
	{
		[Token(Token = "0x4000147")]
		Nothing = 0,
		[Token(Token = "0x4000148")]
		Delete = 1,
		[Token(Token = "0x4000149")]
		Change = 2,
		[Token(Token = "0x400014A")]
		Rollback = 4,
		[Token(Token = "0x400014B")]
		Commit = 8,
		[Token(Token = "0x400014C")]
		Add = 0x10,
		[Token(Token = "0x400014D")]
		ChangeOriginal = 0x20,
		[Token(Token = "0x400014E")]
		ChangeCurrentAndOriginal = 0x40
	}
	[Token(Token = "0x200003E")]
	public class DataRowChangeEventArgs : EventArgs
	{
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x27F4638", Offset = "0x27F0638", VA = "0x27F4638")]
		public DataRowChangeEventArgs(DataRow row, DataRowAction action)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public delegate void DataRowChangeEventHandler(object sender, DataRowChangeEventArgs e);
	[Token(Token = "0x2000040")]
	public sealed class DataRowCollection : InternalDataCollectionBase
	{
		[Token(Token = "0x2000041")]
		private sealed class DataRowTree : RBTree<DataRow>
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x27F4858", Offset = "0x27F0858", VA = "0x27F4858")]
			internal DataRowTree()
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x27F4EF0", Offset = "0x27F0EF0", VA = "0x27F4EF0", Slot = "5")]
			protected override int CompareNode(DataRow record1, DataRow record2)
			{
				return default(int);
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x27F4F1C", Offset = "0x27F0F1C", VA = "0x27F4F1C", Slot = "6")]
			protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DataTable _table;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly DataRowTree _list;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int _nullInList;

		[Token(Token = "0x170000BD")]
		public override int Count
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x27F48A4", Offset = "0x27F08A4", VA = "0x27F48A4", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BE")]
		public DataRow this[int index]
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x27E95A8", Offset = "0x27E55A8", VA = "0x27E95A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x27F47C4", Offset = "0x27F07C4", VA = "0x27F47C4")]
		internal DataRowCollection(DataTable table)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x27F48F4", Offset = "0x27F08F4", VA = "0x27F48F4")]
		public void Add(DataRow row)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x27F4910", Offset = "0x27F0910", VA = "0x27F4910")]
		internal void DiffInsertAt(DataRow row, int pos)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x27F4B14", Offset = "0x27F0B14", VA = "0x27F4B14")]
		public int IndexOf(DataRow row)
		{
			return default(int);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x27F4BAC", Offset = "0x27F0BAC", VA = "0x27F4BAC")]
		internal DataRow AddWithColumnEvents(params object[] values)
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x27F4C0C", Offset = "0x27F0C0C", VA = "0x27F4C0C")]
		internal void ArrayAdd(DataRow row)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x27F4C74", Offset = "0x27F0C74", VA = "0x27F4C74")]
		internal void ArrayInsert(DataRow row, int pos)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x27F4CEC", Offset = "0x27F0CEC", VA = "0x27F4CEC")]
		internal void ArrayClear()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x27F4D3C", Offset = "0x27F0D3C", VA = "0x27F4D3C")]
		internal void ArrayRemove(DataRow row)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x27F4DD0", Offset = "0x27F0DD0", VA = "0x27F4DD0", Slot = "10")]
		public override void CopyTo(Array ar, int index)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x27F4E38", Offset = "0x27F0E38", VA = "0x27F4E38")]
		public void CopyTo(DataRow[] array, int index)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x27F4EA0", Offset = "0x27F0EA0", VA = "0x27F4EA0", Slot = "11")]
		public override IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	internal delegate void DataRowCreatedEventHandler(object sender, DataRow r);
	[Token(Token = "0x2000043")]
	internal delegate void DataSetClearEventhandler(object sender, DataTable table);
	[Token(Token = "0x2000044")]
	[Flags]
	public enum DataRowState
	{
		[Token(Token = "0x4000155")]
		Detached = 1,
		[Token(Token = "0x4000156")]
		Unchanged = 2,
		[Token(Token = "0x4000157")]
		Added = 4,
		[Token(Token = "0x4000158")]
		Deleted = 8,
		[Token(Token = "0x4000159")]
		Modified = 0x10
	}
	[Token(Token = "0x2000045")]
	public enum DataRowVersion
	{
		[Token(Token = "0x400015B")]
		Original = 256,
		[Token(Token = "0x400015C")]
		Current = 512,
		[Token(Token = "0x400015D")]
		Proposed = 1024,
		[Token(Token = "0x400015E")]
		Default = 1536
	}
	[Token(Token = "0x2000046")]
	[DefaultMember("Item")]
	public class DataRowView : ICustomTypeDescriptor, INotifyPropertyChanged
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DataView _dataView;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly DataRow _row;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _delayBeginEdit;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection;

		[Token(Token = "0x170000BF")]
		public DataView DataView
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x27F51CC", Offset = "0x27F11CC", VA = "0x27F51CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private DataRowVersion RowVersionDefault
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x27F51D4", Offset = "0x27F11D4", VA = "0x27F51D4")]
			get
			{
				return default(DataRowVersion);
			}
		}

		[Token(Token = "0x170000C1")]
		public DataRow Row
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x27F540C", Offset = "0x27F140C", VA = "0x27F540C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public bool IsNew
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x27F5460", Offset = "0x27F1460", VA = "0x27F5460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000005")]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x27F5484", Offset = "0x27F1484", VA = "0x27F5484", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x27F5520", Offset = "0x27F1520", VA = "0x27F5520", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x27F5178", Offset = "0x27F1178", VA = "0x27F5178")]
		internal DataRowView(DataView dataView, DataRow row)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x27F51A4", Offset = "0x27F11A4", VA = "0x27F51A4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x27F51B0", Offset = "0x27F11B0", VA = "0x27F51B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x27F522C", Offset = "0x27F122C", VA = "0x27F522C")]
		internal int GetRecord()
		{
			return default(int);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x27F5250", Offset = "0x27F1250", VA = "0x27F5250")]
		internal bool HasRecord()
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x27EA2A8", Offset = "0x27E62A8", VA = "0x27EA2A8")]
		internal object GetColumnValue(DataColumn column)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x27EA428", Offset = "0x27E6428", VA = "0x27EA428")]
		internal void SetColumnValue(DataColumn column, object value)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x27F5274", Offset = "0x27F1274", VA = "0x27F5274")]
		public DataView CreateChildView(DataRelation relation, bool followParent)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x27F1424", Offset = "0x27ED424", VA = "0x27F1424")]
		public DataView CreateChildView(DataRelation relation)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x27F5414", Offset = "0x27F1414", VA = "0x27F5414", Slot = "11")]
		public void EndEdit()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x27F55BC", Offset = "0x27F15BC", VA = "0x27F55BC")]
		internal void RaisePropertyChangedEvent(string propName)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x27F564C", Offset = "0x27F164C", VA = "0x27F564C", Slot = "4")]
		private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x27F56A4", Offset = "0x27F16A4", VA = "0x27F56A4", Slot = "5")]
		private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x27F56AC", Offset = "0x27F16AC", VA = "0x27F56AC", Slot = "6")]
		private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x27F5748", Offset = "0x27F1748", VA = "0x27F5748", Slot = "7")]
		private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			return null;
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x27F57D0", Offset = "0x27F17D0", VA = "0x27F57D0", Slot = "8")]
		private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}
	}
	[Token(Token = "0x2000047")]
	public enum SerializationFormat
	{
		[Token(Token = "0x4000165")]
		Xml,
		[Token(Token = "0x4000166")]
		Binary
	}
	[Token(Token = "0x2000048")]
	public enum DataSetDateTime
	{
		[Token(Token = "0x4000168")]
		Local = 1,
		[Token(Token = "0x4000169")]
		Unspecified,
		[Token(Token = "0x400016A")]
		UnspecifiedLocal,
		[Token(Token = "0x400016B")]
		Utc
	}
	[Token(Token = "0x2000049")]
	public sealed class DataTableClearEventArgs : EventArgs
	{
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x27F5848", Offset = "0x27F1848", VA = "0x27F5848")]
		public DataTableClearEventArgs(DataTable dataTable)
		{
		}
	}
	[Token(Token = "0x200004A")]
	public delegate void DataTableClearEventHandler(object sender, DataTableClearEventArgs e);
	[Token(Token = "0x200004B")]
	[DefaultEvent("CollectionChanged")]
	[ListBindable(false)]
	public sealed class DataTableCollection : InternalDataCollectionBase
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DataSet _dataSet;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ArrayList _list;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _defaultNameIndex;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DataTable[] _delayedAddRangeTables;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CollectionChangeEventHandler _onCollectionChangedDelegate;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CollectionChangeEventHandler _onCollectionChangingDelegate;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_objectTypeCount;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly int _objectID;

		[Token(Token = "0x170000C3")]
		protected override ArrayList List
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x27F5B20", Offset = "0x27F1B20", VA = "0x27F5B20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		internal int ObjectID
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x27F5B28", Offset = "0x27F1B28", VA = "0x27F5B28")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C5")]
		public DataTable this[int index]
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x27F5B30", Offset = "0x27F1B30", VA = "0x27F5B30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public DataTable this[string name]
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x27F5C60", Offset = "0x27F1C60", VA = "0x27F5C60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public DataTable this[string name, string tableNamespace]
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x27EE8CC", Offset = "0x27EA8CC", VA = "0x27EE8CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x27F59CC", Offset = "0x27F19CC", VA = "0x27F59CC")]
		internal DataTableCollection(DataSet dataSet)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x27F60A8", Offset = "0x27F20A8", VA = "0x27F60A8")]
		internal DataTable GetTable(string name, string ns)
		{
			return null;
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x27F61C4", Offset = "0x27F21C4", VA = "0x27F61C4")]
		internal DataTable GetTableSmart(string name, string ns)
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x27F62FC", Offset = "0x27F22FC", VA = "0x27F62FC")]
		public void Add(DataTable table)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x27F6748", Offset = "0x27F2748", VA = "0x27F6748")]
		private void ArrayAdd(DataTable table)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x27F6838", Offset = "0x27F2838", VA = "0x27F6838")]
		internal string AssignName()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x27F6634", Offset = "0x27F2634", VA = "0x27F6634")]
		private void BaseAdd(DataTable table)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x27F6BB0", Offset = "0x27F2BB0", VA = "0x27F6BB0")]
		private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x27F6D24", Offset = "0x27F2D24", VA = "0x27F6D24")]
		private void BaseRemove(DataTable table)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x27F6D9C", Offset = "0x27F2D9C", VA = "0x27F6D9C")]
		internal bool CanRemove(DataTable table, bool fThrowException)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x27F72D8", Offset = "0x27F32D8", VA = "0x27F72D8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x27F6938", Offset = "0x27F2938", VA = "0x27F6938")]
		public bool Contains(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x27F7570", Offset = "0x27F3570", VA = "0x27F7570")]
		internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x27F76E4", Offset = "0x27F36E4", VA = "0x27F76E4")]
		internal bool Contains(string name, bool caseSensitive)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x27F780C", Offset = "0x27F380C", VA = "0x27F780C")]
		public int IndexOf(DataTable table)
		{
			return default(int);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x27F78F0", Offset = "0x27F38F0", VA = "0x27F78F0")]
		public int IndexOf(string tableName)
		{
			return default(int);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x27F7908", Offset = "0x27F3908", VA = "0x27F7908")]
		internal int IndexOf(string tableName, string tableNamespace, bool chekforNull)
		{
			return default(int);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x27F7968", Offset = "0x27F3968", VA = "0x27F7968")]
		internal void ReplaceFromInference(List<DataTable> tableList)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x27F5D54", Offset = "0x27F1D54", VA = "0x27F5D54")]
		internal int InternalIndexOf(string tableName)
		{
			return default(int);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x27F5F1C", Offset = "0x27F1F1C", VA = "0x27F5F1C")]
		internal int InternalIndexOf(string tableName, string tableNamespace)
		{
			return default(int);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x27F6880", Offset = "0x27F2880", VA = "0x27F6880")]
		private string MakeName(int index)
		{
			return null;
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x27F6768", Offset = "0x27F2768", VA = "0x27F6768")]
		private void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x27F6564", Offset = "0x27F2564", VA = "0x27F6564")]
		private void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x27F6950", Offset = "0x27F2950", VA = "0x27F6950")]
		internal void RegisterName(string name, string tbNamespace)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x27F79B8", Offset = "0x27F39B8", VA = "0x27F79B8")]
		public void Remove(DataTable table)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x27F71CC", Offset = "0x27F31CC", VA = "0x27F71CC")]
		internal void UnregisterName(string name)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public sealed class DataTableNewRowEventArgs : EventArgs
	{
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x27F7B80", Offset = "0x27F3B80", VA = "0x27F7B80")]
		public DataTableNewRowEventArgs(DataRow dataRow)
		{
		}
	}
	[Token(Token = "0x200004D")]
	public delegate void DataTableNewRowEventHandler(object sender, DataTableNewRowEventArgs e);
	[Token(Token = "0x200004E")]
	internal sealed class DataTableTypeConverter : ReferenceConverter
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x27F7D04", Offset = "0x27F3D04", VA = "0x27F7D04")]
		public DataTableTypeConverter()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x27F7DB8", Offset = "0x27F3DB8", VA = "0x27F7DB8", Slot = "11")]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004F")]
	[DefaultEvent("PositionChanged")]
	[DefaultProperty("Table")]
	public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable
	{
		[Token(Token = "0x2000050")]
		private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow>
		{
			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly DataRowReferenceComparer s_default;

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x27FAD14", Offset = "0x27F6D14", VA = "0x27FAD14")]
			private DataRowReferenceComparer()
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x27FAD1C", Offset = "0x27F6D1C", VA = "0x27FAD1C", Slot = "4")]
			public bool Equals(DataRow x, DataRow y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x27FAD28", Offset = "0x27F6D28", VA = "0x27FAD28", Slot = "5")]
			public int GetHashCode(DataRow obj)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataViewManager _dataViewManager;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DataTable _table;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _locked;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Index _index;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Index> _findIndexes;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _sort;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Comparison<DataRow> _comparison;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IFilter _rowFilter;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DataViewRowState _recordStates;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _shouldOpen;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool _open;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool _allowNew;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool _allowEdit;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _allowDelete;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _applyDefaultSort;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal DataRow _addNewRow;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ListChangedEventArgs _addNewMoved;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ListChangedEventHandler _onListChanged;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static ListChangedEventArgs s_resetEventArgs;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DataViewRowState _delayedRecordStates;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _fEndInitInProgress;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<DataRow, DataRowView> _rowViewCache;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DataViewListener _dvListener;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int s_objectTypeCount;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly int _objectID;

		[Token(Token = "0x170000C8")]
		[DefaultValue(true)]
		public bool AllowDelete
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x27F82BC", Offset = "0x27F42BC", VA = "0x27F82BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		[DefaultValue(true)]
		public bool AllowNew
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x27F82C4", Offset = "0x27F42C4", VA = "0x27F82C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		[Browsable(false)]
		public int Count
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x27F82CC", Offset = "0x27F42CC", VA = "0x27F82CC", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CB")]
		private int CountFromIndex
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x27F831C", Offset = "0x27F431C", VA = "0x27F831C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CC")]
		[Browsable(false)]
		public DataViewManager DataViewManager
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x27F8338", Offset = "0x27F4338", VA = "0x27F8338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		[Browsable(false)]
		protected bool IsOpen
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x27F8340", Offset = "0x27F4340", VA = "0x27F8340")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x27F8348", Offset = "0x27F4348", VA = "0x27F8348", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		[DefaultValue(DataViewRowState.CurrentRows)]
		public DataViewRowState RowStateFilter
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x27F8350", Offset = "0x27F4350", VA = "0x27F8350")]
			get
			{
				return default(DataViewRowState);
			}
		}

		[Token(Token = "0x170000D0")]
		[DefaultValue("")]
		public string Sort
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x27F8358", Offset = "0x27F4358", VA = "0x27F8358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		internal Comparison<DataRow> SortComparison
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x27F83AC", Offset = "0x27F43AC", VA = "0x27F83AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x27F83B4", Offset = "0x27F43B4", VA = "0x27F83B4", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		[DefaultValue(null)]
		[RefreshProperties(RefreshProperties.All)]
		[TypeConverter(typeof(DataTableTypeConverter))]
		public DataTable Table
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x27F83B8", Offset = "0x27F43B8", VA = "0x27F83B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		private object System.Collections.IList.Item
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x27F83C0", Offset = "0x27F43C0", VA = "0x27F83C0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x27F83F8", Offset = "0x27F43F8", VA = "0x27F83F8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public DataRowView this[int recordIndex]
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x27F83DC", Offset = "0x27F43DC", VA = "0x27F83DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		private bool System.Collections.IList.IsReadOnly
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x27F903C", Offset = "0x27F503C", VA = "0x27F903C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D7")]
		private bool System.Collections.IList.IsFixedSize
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x27F9044", Offset = "0x27F5044", VA = "0x27F9044", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D8")]
		internal int ObjectID
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x27FAC94", Offset = "0x27F6C94", VA = "0x27FAC94")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x27F7DC0", Offset = "0x27F3DC0", VA = "0x27F7DC0")]
		internal DataView(DataTable table, bool locked)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x27F8514", Offset = "0x27F4514", VA = "0x27F8514", Slot = "26")]
		public virtual DataRowView AddNew()
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x27F87BC", Offset = "0x27F47BC", VA = "0x27F87BC")]
		private void CheckOpen()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x27F88C8", Offset = "0x27F48C8", VA = "0x27F88C8")]
		protected void Close()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x27F891C", Offset = "0x27F491C", VA = "0x27F891C", Slot = "21")]
		public void CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x27F8A90", Offset = "0x27F4A90", VA = "0x27F8A90")]
		private void CopyTo(DataRowView[] array, int index)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x27F8C28", Offset = "0x27F4C28", VA = "0x27F8C28")]
		public void Delete(int index)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x27F8C44", Offset = "0x27F4C44", VA = "0x27F8C44")]
		internal void Delete(DataRow row)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x27F8F8C", Offset = "0x27F4F8C", VA = "0x27F8F8C", Slot = "8")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x27F8DE4", Offset = "0x27F4DE4", VA = "0x27F8DE4")]
		internal void FinishAddNew(bool success)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x27F8FC0", Offset = "0x27F4FC0", VA = "0x27F8FC0", Slot = "25")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x27F904C", Offset = "0x27F504C", VA = "0x27F904C", Slot = "12")]
		private int System.Collections.IList.Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x27F90A0", Offset = "0x27F50A0", VA = "0x27F90A0", Slot = "14")]
		private void System.Collections.IList.Clear()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x27F90C8", Offset = "0x27F50C8", VA = "0x27F90C8", Slot = "13")]
		private bool System.Collections.IList.Contains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x27F9154", Offset = "0x27F5154", VA = "0x27F9154", Slot = "17")]
		private int System.Collections.IList.IndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x27F87F0", Offset = "0x27F47F0", VA = "0x27F87F0")]
		internal int IndexOf(DataRowView rowview)
		{
			return default(int);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x27F91D4", Offset = "0x27F51D4", VA = "0x27F91D4")]
		private int IndexOfDataRowView(DataRowView rowview)
		{
			return default(int);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x27F922C", Offset = "0x27F522C", VA = "0x27F922C", Slot = "18")]
		private void System.Collections.IList.Insert(int index, object value)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x27F9254", Offset = "0x27F5254", VA = "0x27F9254", Slot = "19")]
		private void System.Collections.IList.Remove(object value)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x27F9374", Offset = "0x27F5374", VA = "0x27F9374", Slot = "20")]
		private void System.Collections.IList.RemoveAt(int index)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x27F9390", Offset = "0x27F5390", VA = "0x27F9390", Slot = "27")]
		internal virtual IFilter GetFilter()
		{
			return null;
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x27F9398", Offset = "0x27F5398", VA = "0x27F9398")]
		private int GetRecord(int recordIndex)
		{
			return default(int);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x27F8420", Offset = "0x27F4420", VA = "0x27F8420")]
		internal DataRow GetRow(int index)
		{
			return null;
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x27F8A5C", Offset = "0x27F4A5C", VA = "0x27F8A5C")]
		private DataRowView GetRowView(int record)
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x27F84BC", Offset = "0x27F44BC", VA = "0x27F84BC")]
		private DataRowView GetRowView(DataRow dr)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x27F9420", Offset = "0x27F5420", VA = "0x27F9420", Slot = "28")]
		protected virtual void IndexListChanged(object sender, ListChangedEventArgs e)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x27F94B0", Offset = "0x27F54B0", VA = "0x27F94B0")]
		internal void IndexListChangedInternal(ListChangedEventArgs e)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x27F9560", Offset = "0x27F5560", VA = "0x27F9560")]
		internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x27F99F4", Offset = "0x27F59F4", VA = "0x27F99F4", Slot = "29")]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x27F9D0C", Offset = "0x27F5D0C", VA = "0x27F9D0C")]
		protected void Reset()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x27F97C4", Offset = "0x27F57C4", VA = "0x27F97C4")]
		internal void ResetRowViewCache()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x27F9D30", Offset = "0x27F5D30", VA = "0x27F9D30")]
		internal void SetDataViewManager(DataViewManager dataViewManager)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x27F9F48", Offset = "0x27F5F48", VA = "0x27F9F48", Slot = "30")]
		internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x27F9F50", Offset = "0x27F5F50", VA = "0x27F9F50")]
		internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x27F8900", Offset = "0x27F4900", VA = "0x27F8900")]
		protected void UpdateIndex()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x27FA46C", Offset = "0x27F646C", VA = "0x27FA46C", Slot = "31")]
		protected virtual void UpdateIndex(bool force)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x27FA174", Offset = "0x27F6174", VA = "0x27FA174")]
		internal void UpdateIndex(bool force, bool fireEvent)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x27FA654", Offset = "0x27F6654", VA = "0x27FA654")]
		internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x27FA864", Offset = "0x27F6864", VA = "0x27FA864")]
		internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x27FAA74", Offset = "0x27F6A74", VA = "0x27FAA74", Slot = "32")]
		protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x27FAC84", Offset = "0x27F6C84", VA = "0x27FAC84")]
		internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e)
		{
		}
	}
	[Token(Token = "0x2000051")]
	internal sealed class DataViewListener
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly WeakReference _dvWeak;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DataTable _table;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Index _index;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal readonly int _objectID;

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x27F8064", Offset = "0x27F4064", VA = "0x27F8064")]
		internal DataViewListener(DataView dv)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x27FAD98", Offset = "0x27F6D98", VA = "0x27FAD98")]
		private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x27FAE60", Offset = "0x27F6E60", VA = "0x27FAE60")]
		private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x27FAF10", Offset = "0x27F6F10", VA = "0x27FAF10")]
		private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x27FAFDC", Offset = "0x27F6FDC", VA = "0x27FAFDC")]
		internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x27FB0A8", Offset = "0x27F70A8", VA = "0x27FB0A8")]
		internal void IndexListChanged(ListChangedEventArgs e)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x27F80E0", Offset = "0x27F40E0", VA = "0x27F80E0")]
		internal void RegisterMetaDataEvents(DataTable table)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x27F8914", Offset = "0x27F4914", VA = "0x27F8914")]
		internal void UnregisterMetaDataEvents()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x27FB380", Offset = "0x27F7380", VA = "0x27FB380")]
		private void UnregisterMetaDataEvents(bool updateListeners)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x27FA570", Offset = "0x27F6570", VA = "0x27FA570")]
		internal void RegisterListChangedEvent(Index index)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x27FA474", Offset = "0x27F6474", VA = "0x27FA474")]
		internal void UnregisterListChangedEvent()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x27FAE48", Offset = "0x27F6E48", VA = "0x27FAE48")]
		private void CleanUp(bool updateListeners)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x27FB158", Offset = "0x27F7158", VA = "0x27FB158")]
		private void RegisterListener(DataTable table)
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class DataViewManager : MarshalByValueComponent
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataViewSettingCollection _dataViewSettingsCollection;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int _nViews;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static NotSupportedException s_notSupported;

		[Token(Token = "0x170000D9")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataViewSettingCollection DataViewSettings
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x27FB61C", Offset = "0x27F761C", VA = "0x27FB61C")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000053")]
	[Flags]
	public enum DataViewRowState
	{
		[Token(Token = "0x4000199")]
		None = 0,
		[Token(Token = "0x400019A")]
		Unchanged = 2,
		[Token(Token = "0x400019B")]
		Added = 4,
		[Token(Token = "0x400019C")]
		Deleted = 8,
		[Token(Token = "0x400019D")]
		ModifiedCurrent = 0x10,
		[Token(Token = "0x400019E")]
		ModifiedOriginal = 0x20,
		[Token(Token = "0x400019F")]
		OriginalRows = 0x2A,
		[Token(Token = "0x40001A0")]
		CurrentRows = 0x16
	}
	[Token(Token = "0x2000054")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class DataViewSetting
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DataViewManager _dataViewManager;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DataTable _table;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _sort;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _rowFilter;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DataViewRowState _rowStateFilter;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool _applyDefaultSort;

		[Token(Token = "0x170000DA")]
		public bool ApplyDefaultSort
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x27FB6F4", Offset = "0x27F76F4", VA = "0x27FB6F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DB")]
		public string RowFilter
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x27FB724", Offset = "0x27F7724", VA = "0x27FB724")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public DataViewRowState RowStateFilter
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x27FB72C", Offset = "0x27F772C", VA = "0x27FB72C")]
			get
			{
				return default(DataViewRowState);
			}
		}

		[Token(Token = "0x170000DD")]
		public string Sort
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x27FB734", Offset = "0x27F7734", VA = "0x27FB734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x27FB694", Offset = "0x27F7694", VA = "0x27FB694")]
		internal DataViewSetting()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x27FB6FC", Offset = "0x27F76FC", VA = "0x27FB6FC")]
		internal void SetDataViewManager(DataViewManager dataViewManager)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x27FB710", Offset = "0x27F7710", VA = "0x27FB710")]
		internal void SetDataTable(DataTable table)
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class DataViewSettingCollection
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DataViewManager _dataViewManager;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Hashtable _list;

		[Token(Token = "0x170000DE")]
		public virtual DataViewSetting this[DataTable table]
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x27FB73C", Offset = "0x27F773C", VA = "0x27FB73C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x27FB844", Offset = "0x27F7844", VA = "0x27FB844", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x27FB8C4", Offset = "0x27F78C4", VA = "0x27FB8C4")]
		internal void Remove(DataTable table)
		{
		}
	}
	[Token(Token = "0x2000056")]
	internal sealed class DefaultValueTypeConverter : StringConverter
	{
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x27FB8E4", Offset = "0x27F78E4", VA = "0x27FB8E4")]
		public DefaultValueTypeConverter()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x27FB8EC", Offset = "0x27F78EC", VA = "0x27FB8EC", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x27FBA98", Offset = "0x27F7A98", VA = "0x27FBA98", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000057")]
	internal enum Aggregate
	{
		[Token(Token = "0x40001AA")]
		None = -1,
		[Token(Token = "0x40001AB")]
		Sum = 30,
		[Token(Token = "0x40001AC")]
		Avg = 31,
		[Token(Token = "0x40001AD")]
		Min = 32,
		[Token(Token = "0x40001AE")]
		Max = 33,
		[Token(Token = "0x40001AF")]
		Count = 34,
		[Token(Token = "0x40001B0")]
		StDev = 35,
		[Token(Token = "0x40001B1")]
		Var = 37
	}
	[Token(Token = "0x2000058")]
	internal sealed class AggregateNode : ExpressionNode
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly AggregateType _type;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly Aggregate _aggregate;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly bool _local;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string _relationName;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string _columnName;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DataTable _childTable;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DataColumn _column;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DataRelation _relation;

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x27FBC38", Offset = "0x27F7C38", VA = "0x27FBC38")]
		internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x27FBC44", Offset = "0x27F7C44", VA = "0x27FBC44")]
		internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x27FBD94", Offset = "0x27F7D94", VA = "0x27FBD94", Slot = "5")]
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x27FC100", Offset = "0x27F8100", VA = "0x27FC100")]
		internal static void Bind(DataRelation relation, List<DataColumn> list)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x27FC2F4", Offset = "0x27F82F4", VA = "0x27FC2F4", Slot = "6")]
		internal override object Eval()
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x27FC308", Offset = "0x27F8308", VA = "0x27FC308", Slot = "7")]
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x27FC62C", Offset = "0x27F862C", VA = "0x27FC62C", Slot = "8")]
		internal override object Eval(int[] records)
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x27FC6F0", Offset = "0x27F86F0", VA = "0x27FC6F0", Slot = "9")]
		internal override bool IsConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x27FC6F8", Offset = "0x27F86F8", VA = "0x27FC6F8", Slot = "10")]
		internal override bool IsTableConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x27FC700", Offset = "0x27F8700", VA = "0x27FC700", Slot = "11")]
		internal override bool HasLocalAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x27FC708", Offset = "0x27F8708", VA = "0x27FC708", Slot = "12")]
		internal override bool HasRemoteAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x27FC718", Offset = "0x27F8718", VA = "0x27FC718", Slot = "14")]
		internal override bool DependsOn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x27FC7B0", Offset = "0x27F87B0", VA = "0x27FC7B0", Slot = "13")]
		internal override ExpressionNode Optimize()
		{
			return null;
		}
	}
	[Token(Token = "0x2000059")]
	internal class BinaryNode : ExpressionNode
	{
		[Token(Token = "0x200005A")]
		private enum DataTypePrecedence
		{
			[Token(Token = "0x40001BE")]
			SqlDateTime = 25,
			[Token(Token = "0x40001BF")]
			DateTimeOffset = 24,
			[Token(Token = "0x40001C0")]
			DateTime = 23,
			[Token(Token = "0x40001C1")]
			TimeSpan = 20,
			[Token(Token = "0x40001C2")]
			SqlDouble = 19,
			[Token(Token = "0x40001C3")]
			Double = 18,
			[Token(Token = "0x40001C4")]
			SqlSingle = 17,
			[Token(Token = "0x40001C5")]
			Single = 16,
			[Token(Token = "0x40001C6")]
			SqlDecimal = 15,
			[Token(Token = "0x40001C7")]
			Decimal = 14,
			[Token(Token = "0x40001C8")]
			SqlMoney = 13,
			[Token(Token = "0x40001C9")]
			UInt64 = 12,
			[Token(Token = "0x40001CA")]
			SqlInt64 = 11,
			[Token(Token = "0x40001CB")]
			Int64 = 10,
			[Token(Token = "0x40001CC")]
			UInt32 = 9,
			[Token(Token = "0x40001CD")]
			SqlInt32 = 8,
			[Token(Token = "0x40001CE")]
			Int32 = 7,
			[Token(Token = "0x40001CF")]
			UInt16 = 6,
			[Token(Token = "0x40001D0")]
			SqlInt16 = 5,
			[Token(Token = "0x40001D1")]
			Int16 = 4,
			[Token(Token = "0x40001D2")]
			Byte = 3,
			[Token(Token = "0x40001D3")]
			SqlByte = 2,
			[Token(Token = "0x40001D4")]
			SByte = 1,
			[Token(Token = "0x40001D5")]
			Error = 0,
			[Token(Token = "0x40001D6")]
			SqlBoolean = -1,
			[Token(Token = "0x40001D7")]
			Boolean = -2,
			[Token(Token = "0x40001D8")]
			SqlGuid = -3,
			[Token(Token = "0x40001D9")]
			SqlString = -4,
			[Token(Token = "0x40001DA")]
			String = -5,
			[Token(Token = "0x40001DB")]
			SqlXml = -6,
			[Token(Token = "0x40001DC")]
			SqlChars = -7,
			[Token(Token = "0x40001DD")]
			Char = -8,
			[Token(Token = "0x40001DE")]
			SqlBytes = -9,
			[Token(Token = "0x40001DF")]
			SqlBinary = -10
		}

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int _op;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal ExpressionNode _left;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal ExpressionNode _right;

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x27FC7B4", Offset = "0x27F87B4", VA = "0x27FC7B4")]
		internal BinaryNode(DataTable table, int op, ExpressionNode left, ExpressionNode right)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x27FC7F8", Offset = "0x27F87F8", VA = "0x27FC7F8", Slot = "5")]
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x27FC84C", Offset = "0x27F884C", VA = "0x27FC84C", Slot = "6")]
		internal override object Eval()
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x27FC860", Offset = "0x27F8860", VA = "0x27FC860", Slot = "7")]
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x2802104", Offset = "0x27FE104", VA = "0x2802104", Slot = "8")]
		internal override object Eval(int[] recordNos)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x2802120", Offset = "0x27FE120", VA = "0x2802120", Slot = "9")]
		internal override bool IsConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2802168", Offset = "0x27FE168", VA = "0x2802168", Slot = "10")]
		internal override bool IsTableConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x28021B0", Offset = "0x27FE1B0", VA = "0x28021B0", Slot = "11")]
		internal override bool HasLocalAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x28021F8", Offset = "0x27FE1F8", VA = "0x28021F8", Slot = "12")]
		internal override bool HasRemoteAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2802240", Offset = "0x27FE240", VA = "0x2802240", Slot = "14")]
		internal override bool DependsOn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x28022A4", Offset = "0x27FE2A4", VA = "0x28022A4", Slot = "13")]
		internal override ExpressionNode Optimize()
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2802820", Offset = "0x27FE820", VA = "0x2802820")]
		internal void SetTypeMismatchError(int op, Type left, Type right)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x280291C", Offset = "0x27FE91C", VA = "0x280291C")]
		private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x2802954", Offset = "0x27FE954", VA = "0x2802954")]
		internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op)
		{
			return default(int);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x280295C", Offset = "0x27FE95C", VA = "0x280295C")]
		internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer)
		{
			return default(int);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x27FC87C", Offset = "0x27F887C", VA = "0x27FC87C")]
		private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2804478", Offset = "0x2800478", VA = "0x2804478")]
		private DataTypePrecedence GetPrecedence(StorageType storageType)
		{
			return default(DataTypePrecedence);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x280449C", Offset = "0x280049C", VA = "0x280449C")]
		private static StorageType GetPrecedenceType(DataTypePrecedence code)
		{
			return default(StorageType);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x28044C0", Offset = "0x28004C0", VA = "0x28044C0")]
		private bool IsMixed(StorageType left, StorageType right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x280457C", Offset = "0x280057C", VA = "0x280457C")]
		private bool IsMixedSql(StorageType left, StorageType right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x2803FC0", Offset = "0x27FFFC0", VA = "0x2803FC0")]
		internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op)
		{
			return default(StorageType);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x2803C3C", Offset = "0x27FFC3C", VA = "0x2803C3C")]
		internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op)
		{
			return default(StorageType);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x2804774", Offset = "0x2800774", VA = "0x2804774")]
		private int SqlResultType(int typeCode)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200005B")]
	internal sealed class LikeNode : BinaryNode
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _kind;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _pattern;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x28047C4", Offset = "0x28007C4", VA = "0x28047C4")]
		internal LikeNode(DataTable table, int op, ExpressionNode left, ExpressionNode right)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2804808", Offset = "0x2800808", VA = "0x2804808", Slot = "7")]
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x2804D6C", Offset = "0x2800D6C", VA = "0x2804D6C")]
		internal string AnalyzePattern(string pat)
		{
			return null;
		}
	}
	[Token(Token = "0x200005C")]
	internal sealed class ConstNode : ExpressionNode
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly object _val;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2805060", Offset = "0x2801060", VA = "0x2805060")]
		internal ConstNode(DataTable table, ValueType type, object constant)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x2802514", Offset = "0x27FE514", VA = "0x2802514")]
		internal ConstNode(DataTable table, ValueType type, object constant, bool fParseQuotes)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x2805A28", Offset = "0x2801A28", VA = "0x2805A28", Slot = "5")]
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x2805A30", Offset = "0x2801A30", VA = "0x2805A30", Slot = "6")]
		internal override object Eval()
		{
			return null;
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x2805A38", Offset = "0x2801A38", VA = "0x2805A38", Slot = "7")]
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x2805A44", Offset = "0x2801A44", VA = "0x2805A44", Slot = "8")]
		internal override object Eval(int[] recordNos)
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x2805A50", Offset = "0x2801A50", VA = "0x2805A50", Slot = "9")]
		internal override bool IsConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x2805A58", Offset = "0x2801A58", VA = "0x2805A58", Slot = "10")]
		internal override bool IsTableConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x2805A60", Offset = "0x2801A60", VA = "0x2805A60", Slot = "11")]
		internal override bool HasLocalAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x2805A68", Offset = "0x2801A68", VA = "0x2805A68", Slot = "12")]
		internal override bool HasRemoteAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x2805A70", Offset = "0x2801A70", VA = "0x2805A70", Slot = "13")]
		internal override ExpressionNode Optimize()
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x28055DC", Offset = "0x28015DC", VA = "0x28055DC")]
		private object SmallestDecimal(object constant)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2805068", Offset = "0x2801068", VA = "0x2805068")]
		private object SmallestNumeric(object constant)
		{
			return null;
		}
	}
	[Token(Token = "0x200005D")]
	internal sealed class DataExpression : IFilter
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string _originalExpression;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _parsed;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _bound;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ExpressionNode _expr;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DataTable _table;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly StorageType _storageType;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Type _dataType;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DataColumn[] _dependency;

		[Token(Token = "0x170000DF")]
		internal string Expression
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x2806BE0", Offset = "0x2802BE0", VA = "0x2806BE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		internal bool HasValue
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x2806C30", Offset = "0x2802C30", VA = "0x2806C30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x27F9F40", Offset = "0x27F5F40", VA = "0x27F9F40")]
		internal DataExpression(DataTable table, string expression)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2805A74", Offset = "0x2801A74", VA = "0x2805A74")]
		internal DataExpression(DataTable table, string expression, Type type)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x2806AF8", Offset = "0x2802AF8", VA = "0x2806AF8")]
		internal void Bind(DataTable table)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x27FC794", Offset = "0x27F8794", VA = "0x27FC794")]
		internal bool DependsOn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2806C40", Offset = "0x2802C40", VA = "0x2806C40")]
		internal object Evaluate()
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2806C4C", Offset = "0x2802C4C", VA = "0x2806C4C")]
		internal object Evaluate(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2806ECC", Offset = "0x2802ECC", VA = "0x2806ECC", Slot = "4")]
		public bool Invoke(DataRow row, DataRowVersion version)
		{
			return default(bool);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x280703C", Offset = "0x280303C", VA = "0x280703C")]
		internal DataColumn[] GetDependency()
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2807044", Offset = "0x2803044", VA = "0x2807044")]
		internal bool IsTableAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x280705C", Offset = "0x280305C", VA = "0x280705C")]
		internal static bool IsUnknown(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x28070B4", Offset = "0x28030B4", VA = "0x28070B4")]
		internal bool HasLocalAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x28070CC", Offset = "0x28030CC", VA = "0x28070CC")]
		internal bool HasRemoteAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x28039C0", Offset = "0x27FF9C0", VA = "0x28039C0")]
		internal static bool ToBoolean(object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005E")]
	internal abstract class ExpressionNode
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DataTable _table;

		[Token(Token = "0x170000E1")]
		internal IFormatProvider FormatProvider
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x2803954", Offset = "0x27FF954", VA = "0x2803954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		internal virtual bool IsSqlColumn
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x28070E4", Offset = "0x28030E4", VA = "0x28070E4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E3")]
		protected DataTable table
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x28070EC", Offset = "0x28030EC", VA = "0x28070EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x27FBD1C", Offset = "0x27F7D1C", VA = "0x27FBD1C")]
		protected ExpressionNode(DataTable table)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x28070F4", Offset = "0x28030F4", VA = "0x28070F4")]
		protected void BindTable(DataTable table)
		{
		}

		[Token(Token = "0x600056A")]
		internal abstract void Bind(DataTable table, List<DataColumn> list);

		[Token(Token = "0x600056B")]
		internal abstract object Eval();

		[Token(Token = "0x600056C")]
		internal abstract object Eval(DataRow row, DataRowVersion version);

		[Token(Token = "0x600056D")]
		internal abstract object Eval(int[] recordNos);

		[Token(Token = "0x600056E")]
		internal abstract bool IsConstant();

		[Token(Token = "0x600056F")]
		internal abstract bool IsTableConstant();

		[Token(Token = "0x6000570")]
		internal abstract bool HasLocalAggregate();

		[Token(Token = "0x6000571")]
		internal abstract bool HasRemoteAggregate();

		[Token(Token = "0x6000572")]
		internal abstract ExpressionNode Optimize();

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x28070FC", Offset = "0x28030FC", VA = "0x28070FC", Slot = "14")]
		internal virtual bool DependsOn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2804698", Offset = "0x2800698", VA = "0x2804698")]
		internal static bool IsInteger(StorageType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x280432C", Offset = "0x280032C", VA = "0x280432C")]
		internal static bool IsIntegerSql(StorageType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x280453C", Offset = "0x280053C", VA = "0x280453C")]
		internal static bool IsSigned(StorageType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x2804600", Offset = "0x2800600", VA = "0x2804600")]
		internal static bool IsSignedSql(StorageType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x280456C", Offset = "0x280056C", VA = "0x280456C")]
		internal static bool IsUnsigned(StorageType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x280461C", Offset = "0x280061C", VA = "0x280461C")]
		internal static bool IsUnsignedSql(StorageType type)
		{
			return default(bool);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x2804688", Offset = "0x2800688", VA = "0x2804688")]
		internal static bool IsNumeric(StorageType type)
		{
			return default(bool);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x28047A4", Offset = "0x28007A4", VA = "0x28047A4")]
		internal static bool IsNumericSql(StorageType type)
		{
			return default(bool);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x2807104", Offset = "0x2803104", VA = "0x2807104")]
		internal static bool IsFloat(StorageType type)
		{
			return default(bool);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x2807114", Offset = "0x2803114", VA = "0x2807114")]
		internal static bool IsFloatSql(StorageType type)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005F")]
	internal enum ValueType
	{
		[Token(Token = "0x40001ED")]
		Unknown = -1,
		[Token(Token = "0x40001EE")]
		Null,
		[Token(Token = "0x40001EF")]
		Bool,
		[Token(Token = "0x40001F0")]
		Numeric,
		[Token(Token = "0x40001F1")]
		Str,
		[Token(Token = "0x40001F2")]
		Float,
		[Token(Token = "0x40001F3")]
		Decimal,
		[Token(Token = "0x40001F4")]
		Object,
		[Token(Token = "0x40001F5")]
		Date
	}
	[Token(Token = "0x2000060")]
	internal enum Nodes
	{
		[Token(Token = "0x40001F7")]
		Noop,
		[Token(Token = "0x40001F8")]
		Unop,
		[Token(Token = "0x40001F9")]
		UnopSpec,
		[Token(Token = "0x40001FA")]
		Binop,
		[Token(Token = "0x40001FB")]
		BinopSpec,
		[Token(Token = "0x40001FC")]
		Zop,
		[Token(Token = "0x40001FD")]
		Call,
		[Token(Token = "0x40001FE")]
		Const,
		[Token(Token = "0x40001FF")]
		Name,
		[Token(Token = "0x4000200")]
		Paren,
		[Token(Token = "0x4000201")]
		Conv
	}
	[Token(Token = "0x2000061")]
	internal sealed class ExpressionParser
	{
		[Token(Token = "0x2000062")]
		private readonly struct ReservedWords
		{
			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal readonly string _word;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal readonly Tokens _token;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal readonly int _op;

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x2808EF8", Offset = "0x2804EF8", VA = "0x2808EF8")]
			internal ReservedWords(string word, Tokens token, int op)
			{
			}
		}

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ReservedWords[] s_reservedwords;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private char _escape;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private char _decimalSeparator;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private char _listSeparator;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		private char _exponentL;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private char _exponentU;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal char[] _text;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int _pos;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int _start;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal Tokens _token;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal int _op;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal OperatorInfo[] _ops;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal int _topOperator;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal int _topNode;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly DataTable _table;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal ExpressionNode[] _nodeStack;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal int _prevOperand;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal ExpressionNode _expression;

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x2805C20", Offset = "0x2801C20", VA = "0x2805C20")]
		internal ExpressionParser(DataTable table)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2805CC8", Offset = "0x2801CC8", VA = "0x2805CC8")]
		internal void LoadExpression(string data)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x2807130", Offset = "0x2803130", VA = "0x2807130")]
		internal void StartScan()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2805E00", Offset = "0x2801E00", VA = "0x2805E00")]
		internal ExpressionNode Parse()
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2807D6C", Offset = "0x2803D6C", VA = "0x2807D6C")]
		private ExpressionNode ParseAggregateArgument(FunctionId aggregate)
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2807D30", Offset = "0x2803D30", VA = "0x2807D30")]
		private ExpressionNode NodePop()
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2807CAC", Offset = "0x2803CAC", VA = "0x2807CAC")]
		private ExpressionNode NodePeek()
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x2807C18", Offset = "0x2803C18", VA = "0x2807C18")]
		private void NodePush(ExpressionNode node)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x2807638", Offset = "0x2803638", VA = "0x2807638")]
		private void BuildExpression(int pri)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x2807B0C", Offset = "0x2803B0C", VA = "0x2807B0C")]
		internal void CheckToken(Tokens token)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x28071FC", Offset = "0x28031FC", VA = "0x28071FC")]
		internal Tokens Scan()
		{
			return default(Tokens);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2808790", Offset = "0x2804790", VA = "0x2808790")]
		private void ScanNumeric()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2808AE8", Offset = "0x2804AE8", VA = "0x2808AE8")]
		private void ScanName()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2808684", Offset = "0x2804684", VA = "0x2808684")]
		private void ScanName(char chEnd, char esc, string charsToEscape)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2808514", Offset = "0x2804514", VA = "0x2808514")]
		private void ScanDate()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x28088B4", Offset = "0x28048B4", VA = "0x28088B4")]
		private void ScanBinaryConstant()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x28088CC", Offset = "0x28048CC", VA = "0x28088CC")]
		private void ScanReserved()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x28085B4", Offset = "0x28045B4", VA = "0x28085B4")]
		private void ScanString(char escape)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x28078F4", Offset = "0x28038F4", VA = "0x28078F4")]
		internal void ScanToken(Tokens token)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x28084B4", Offset = "0x28044B4", VA = "0x28084B4")]
		private void ScanWhite()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2808C68", Offset = "0x2804C68", VA = "0x2808C68")]
		private bool IsWhiteSpace(char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2808AA8", Offset = "0x2804AA8", VA = "0x2808AA8")]
		private bool IsAlphaNumeric(char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x28088B8", Offset = "0x28048B8", VA = "0x28088B8")]
		private bool IsDigit(char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2808BF4", Offset = "0x2804BF4", VA = "0x2808BF4")]
		private bool IsAlpha(char ch)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000063")]
	internal enum Tokens
	{
		[Token(Token = "0x4000218")]
		None,
		[Token(Token = "0x4000219")]
		Name,
		[Token(Token = "0x400021A")]
		Numeric,
		[Token(Token = "0x400021B")]
		Decimal,
		[Token(Token = "0x400021C")]
		Float,
		[Token(Token = "0x400021D")]
		BinaryConst,
		[Token(Token = "0x400021E")]
		StringConst,
		[Token(Token = "0x400021F")]
		Date,
		[Token(Token = "0x4000220")]
		ListSeparator,
		[Token(Token = "0x4000221")]
		LeftParen,
		[Token(Token = "0x4000222")]
		RightParen,
		[Token(Token = "0x4000223")]
		ZeroOp,
		[Token(Token = "0x4000224")]
		UnaryOp,
		[Token(Token = "0x4000225")]
		BinaryOp,
		[Token(Token = "0x4000226")]
		Child,
		[Token(Token = "0x4000227")]
		Parent,
		[Token(Token = "0x4000228")]
		Dot,
		[Token(Token = "0x4000229")]
		Unknown,
		[Token(Token = "0x400022A")]
		EOS
	}
	[Token(Token = "0x2000064")]
	internal sealed class OperatorInfo
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Nodes _type;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int _op;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int _priority;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x28071C0", Offset = "0x28031C0", VA = "0x28071C0")]
		internal OperatorInfo(Nodes type, int op, int pri)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class InvalidExpressionException : DataException
	{
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2808F04", Offset = "0x2804F04", VA = "0x2808F04")]
		protected InvalidExpressionException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2808F0C", Offset = "0x2804F0C", VA = "0x2808F0C")]
		public InvalidExpressionException()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2808F14", Offset = "0x2804F14", VA = "0x2808F14")]
		public InvalidExpressionException(string s)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class EvaluateException : InvalidExpressionException
	{
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2808F1C", Offset = "0x2804F1C", VA = "0x2808F1C")]
		protected EvaluateException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2808F24", Offset = "0x2804F24", VA = "0x2808F24")]
		public EvaluateException()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2808F2C", Offset = "0x2804F2C", VA = "0x2808F2C")]
		public EvaluateException(string s)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class SyntaxErrorException : InvalidExpressionException
	{
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2808F34", Offset = "0x2804F34", VA = "0x2808F34")]
		protected SyntaxErrorException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2808F3C", Offset = "0x2804F3C", VA = "0x2808F3C")]
		public SyntaxErrorException()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2808F44", Offset = "0x2804F44", VA = "0x2808F44")]
		public SyntaxErrorException(string s)
		{
		}
	}
	[Token(Token = "0x2000068")]
	internal sealed class ExprException
	{
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2808F4C", Offset = "0x2804F4C", VA = "0x2808F4C")]
		private static OverflowException _Overflow(string error)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x2808FB4", Offset = "0x2804FB4", VA = "0x2808FB4")]
		private static InvalidExpressionException _Expr(string error)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x280901C", Offset = "0x280501C", VA = "0x280901C")]
		private static SyntaxErrorException _Syntax(string error)
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x2809084", Offset = "0x2805084", VA = "0x2809084")]
		private static EvaluateException _Eval(string error)
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x28090EC", Offset = "0x28050EC", VA = "0x28090EC")]
		private static EvaluateException _Eval(string error, Exception innerException)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2806FA8", Offset = "0x2802FA8", VA = "0x2806FA8")]
		public static Exception InvokeArgument()
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2809154", Offset = "0x2805154", VA = "0x2809154")]
		public static Exception NYI(string moreinfo)
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x28075AC", Offset = "0x28035AC", VA = "0x28075AC")]
		public static Exception MissingOperand(OperatorInfo before)
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x28078A4", Offset = "0x28038A4", VA = "0x28078A4")]
		public static Exception MissingOperator(string token)
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x28091A4", Offset = "0x28051A4", VA = "0x28091A4")]
		public static Exception TypeMismatch(string expr)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x28091F4", Offset = "0x28051F4", VA = "0x28091F4")]
		public static Exception FunctionArgumentOutOfRange(string arg, string func)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2808360", Offset = "0x2804360", VA = "0x2808360")]
		public static Exception ExpressionTooComplex()
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x27FC0B0", Offset = "0x27F80B0", VA = "0x27FC0B0")]
		public static Exception UnboundName(string name)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2808C18", Offset = "0x2804C18", VA = "0x2808C18")]
		public static Exception InvalidString(string str)
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x27FBD44", Offset = "0x27F7D44", VA = "0x27FBD44")]
		public static Exception UndefinedFunction(string name)
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2807CF0", Offset = "0x2803CF0", VA = "0x2807CF0")]
		public static Exception SyntaxError()
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x280925C", Offset = "0x280525C", VA = "0x280925C")]
		public static Exception FunctionArgumentCount(string name)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2807864", Offset = "0x2803864", VA = "0x2807864")]
		public static Exception MissingRightParen()
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x280827C", Offset = "0x280427C", VA = "0x280827C")]
		public static Exception UnknownToken(string token, int position)
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x28083A0", Offset = "0x28043A0", VA = "0x28083A0")]
		public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x28092AC", Offset = "0x28052AC", VA = "0x28092AC")]
		public static Exception DatatypeConvertion(Type type1, Type type2)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2806E40", Offset = "0x2802E40", VA = "0x2806E40")]
		public static Exception DatavalueConvertion(object value, Type type, Exception innerException)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2809338", Offset = "0x2805338", VA = "0x2809338")]
		public static Exception InvalidName(string name)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2808BA4", Offset = "0x2804BA4", VA = "0x2808BA4")]
		public static Exception InvalidDate(string date)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2809388", Offset = "0x2805388", VA = "0x2809388")]
		public static Exception NonConstantArgument()
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2805010", Offset = "0x2801010", VA = "0x2805010")]
		public static Exception InvalidPattern(string pat)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x280434C", Offset = "0x280034C", VA = "0x280434C")]
		public static Exception InWithoutParentheses()
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x28093C8", Offset = "0x28053C8", VA = "0x28093C8")]
		public static Exception InWithoutList()
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x28024D4", Offset = "0x27FE4D4", VA = "0x28024D4")]
		public static Exception InvalidIsSyntax()
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x280440C", Offset = "0x280040C", VA = "0x280440C")]
		public static Exception Overflow(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2809408", Offset = "0x2805408", VA = "0x2809408")]
		public static Exception ArgumentType(string function, int arg, Type type)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x28094D0", Offset = "0x28054D0", VA = "0x28094D0")]
		public static Exception ArgumentTypeInteger(string function, int arg)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2802850", Offset = "0x27FE850", VA = "0x2802850")]
		public static Exception TypeMismatchInBinop(int op, Type type1, Type type2)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x28046A8", Offset = "0x28006A8", VA = "0x28046A8")]
		public static Exception AmbiguousBinop(int op, Type type1, Type type2)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x280438C", Offset = "0x280038C", VA = "0x280438C")]
		public static Exception UnsupportedOperator(int op)
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2808B54", Offset = "0x2804B54", VA = "0x2808B54")]
		public static Exception InvalidNameBracketing(string name)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2808094", Offset = "0x2804094", VA = "0x2808094")]
		public static Exception MissingOperandBefore(string op)
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2808014", Offset = "0x2804014", VA = "0x2808014")]
		public static Exception TooManyRightParentheses()
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x27FC050", Offset = "0x27F8050", VA = "0x27FC050")]
		public static Exception UnresolvedRelation(string name, string expr)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2809574", Offset = "0x2805574", VA = "0x2809574")]
		internal static EvaluateException BindFailure(string relationName)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2808320", Offset = "0x2804320", VA = "0x2808320")]
		public static Exception AggregateArgument()
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x27FC000", Offset = "0x27F8000", VA = "0x27FC000")]
		public static Exception AggregateUnbound(string expr)
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x27FC5EC", Offset = "0x27F85EC", VA = "0x27FC5EC")]
		public static Exception EvalNoContext()
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x28095C4", Offset = "0x28055C4", VA = "0x28095C4")]
		public static Exception ExpressionUnbound(string expr)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x27FC6A0", Offset = "0x27F86A0", VA = "0x27FC6A0")]
		public static Exception ComputeNotAggregate(string expr)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2806FEC", Offset = "0x2802FEC", VA = "0x2806FEC")]
		public static Exception FilterConvertion(string expr)
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2807B4C", Offset = "0x2803B4C", VA = "0x2807B4C")]
		public static Exception LookupArgument()
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2809614", Offset = "0x2805614", VA = "0x2809614")]
		public static Exception InvalidType(string typeName)
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2809664", Offset = "0x2805664", VA = "0x2809664")]
		public static Exception InvalidHoursArgument()
		{
			return null;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x28096A4", Offset = "0x28056A4", VA = "0x28096A4")]
		public static Exception InvalidMinutesArgument()
		{
			return null;
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x28096E4", Offset = "0x28056E4", VA = "0x28096E4")]
		public static Exception InvalidTimeZoneRange()
		{
			return null;
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2809724", Offset = "0x2805724", VA = "0x2809724")]
		public static Exception MismatchKindandTimeSpan()
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x2805D8C", Offset = "0x2801D8C", VA = "0x2805D8C")]
		public static Exception UnsupportedDataType(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000069")]
	internal interface IFilter
	{
		[Token(Token = "0x60005D7")]
		bool Invoke(DataRow row, DataRowVersion version);
	}
	[Token(Token = "0x200006A")]
	internal sealed class LookupNode : ExpressionNode
	{
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string _relationName;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string _columnName;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DataColumn _column;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DataRelation _relation;

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2807B8C", Offset = "0x2803B8C", VA = "0x2807B8C")]
		internal LookupNode(DataTable table, string columnName, string relationName)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2809764", Offset = "0x2805764", VA = "0x2809764", Slot = "5")]
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x28099B4", Offset = "0x28059B4", VA = "0x28099B4", Slot = "6")]
		internal override object Eval()
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x28099D8", Offset = "0x28059D8", VA = "0x28099D8", Slot = "7")]
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2809ADC", Offset = "0x2805ADC", VA = "0x2809ADC", Slot = "8")]
		internal override object Eval(int[] recordNos)
		{
			return null;
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2809B0C", Offset = "0x2805B0C", VA = "0x2809B0C", Slot = "9")]
		internal override bool IsConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x2809B14", Offset = "0x2805B14", VA = "0x2809B14", Slot = "10")]
		internal override bool IsTableConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x2809B1C", Offset = "0x2805B1C", VA = "0x2809B1C", Slot = "11")]
		internal override bool HasLocalAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x2809B24", Offset = "0x2805B24", VA = "0x2809B24", Slot = "12")]
		internal override bool HasRemoteAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x2809B2C", Offset = "0x2805B2C", VA = "0x2809B2C", Slot = "14")]
		internal override bool DependsOn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x2809B3C", Offset = "0x2805B3C", VA = "0x2809B3C", Slot = "13")]
		internal override ExpressionNode Optimize()
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	internal sealed class NameNode : ExpressionNode
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string _name;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool _found;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal DataColumn _column;

		[Token(Token = "0x170000E4")]
		internal override bool IsSqlColumn
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x2809B40", Offset = "0x2805B40", VA = "0x2809B40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x2807BC8", Offset = "0x2803BC8", VA = "0x2807BC8")]
		internal NameNode(DataTable table, char[] text, int start, int pos)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x2808250", Offset = "0x2804250", VA = "0x2808250")]
		internal NameNode(DataTable table, string name)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x2809B58", Offset = "0x2805B58", VA = "0x2809B58", Slot = "5")]
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x2809D88", Offset = "0x2805D88", VA = "0x2809D88", Slot = "6")]
		internal override object Eval()
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2809DAC", Offset = "0x2805DAC", VA = "0x2809DAC", Slot = "7")]
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x2809E48", Offset = "0x2805E48", VA = "0x2809E48", Slot = "8")]
		internal override object Eval(int[] records)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2809E78", Offset = "0x2805E78", VA = "0x2809E78", Slot = "9")]
		internal override bool IsConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x2809E80", Offset = "0x2805E80", VA = "0x2809E80", Slot = "10")]
		internal override bool IsTableConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x2809ED4", Offset = "0x2805ED4", VA = "0x2809ED4", Slot = "11")]
		internal override bool HasLocalAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x2809F28", Offset = "0x2805F28", VA = "0x2809F28", Slot = "12")]
		internal override bool HasRemoteAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2809F7C", Offset = "0x2805F7C", VA = "0x2809F7C", Slot = "14")]
		internal override bool DependsOn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2809FF8", Offset = "0x2805FF8", VA = "0x2809FF8", Slot = "13")]
		internal override ExpressionNode Optimize()
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x280791C", Offset = "0x280391C", VA = "0x280791C")]
		internal static string ParseName(char[] text, int start, int pos)
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	internal sealed class Operators
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] s_priority;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string[] s_looks;

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x280466C", Offset = "0x280066C", VA = "0x280466C")]
		internal static bool IsArithmetical(int op)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x280464C", Offset = "0x280064C", VA = "0x280464C")]
		internal static bool IsLogical(int op)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x280463C", Offset = "0x280063C", VA = "0x280463C")]
		internal static bool IsRelational(int op)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x28081A4", Offset = "0x28041A4", VA = "0x28081A4")]
		internal static int Priority(int op)
		{
			return default(int);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x28080E4", Offset = "0x28040E4", VA = "0x28080E4")]
		internal static string ToString(int op)
		{
			return null;
		}
	}
	[Token(Token = "0x200006D")]
	internal sealed class UnaryNode : ExpressionNode
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly int _op;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal ExpressionNode _right;

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2808054", Offset = "0x2804054", VA = "0x2808054")]
		internal UnaryNode(DataTable table, int op, ExpressionNode right)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x280A628", Offset = "0x2806628", VA = "0x280A628", Slot = "5")]
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x280A64C", Offset = "0x280664C", VA = "0x280A64C", Slot = "6")]
		internal override object Eval()
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x280A660", Offset = "0x2806660", VA = "0x280A660", Slot = "7")]
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x280AEA0", Offset = "0x2806EA0", VA = "0x280AEA0", Slot = "8")]
		internal override object Eval(int[] recordNos)
		{
			return null;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x280A6A0", Offset = "0x28066A0", VA = "0x280A6A0")]
		private object EvalUnaryOp(int op, object vl)
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x280AEBC", Offset = "0x2806EBC", VA = "0x280AEBC", Slot = "9")]
		internal override bool IsConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x280AED8", Offset = "0x2806ED8", VA = "0x280AED8", Slot = "10")]
		internal override bool IsTableConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x280AEF4", Offset = "0x2806EF4", VA = "0x280AEF4", Slot = "11")]
		internal override bool HasLocalAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x280AF10", Offset = "0x2806F10", VA = "0x280AF10", Slot = "12")]
		internal override bool HasRemoteAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x280AF2C", Offset = "0x2806F2C", VA = "0x280AF2C", Slot = "14")]
		internal override bool DependsOn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x280AF4C", Offset = "0x2806F4C", VA = "0x280AF4C", Slot = "13")]
		internal override ExpressionNode Optimize()
		{
			return null;
		}
	}
	[Token(Token = "0x200006E")]
	internal sealed class ZeroOpNode : ExpressionNode
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly int _op;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x280B000", Offset = "0x2807000", VA = "0x280B000")]
		internal ZeroOpNode(int op)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x280B02C", Offset = "0x280702C", VA = "0x280B02C", Slot = "5")]
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x280B030", Offset = "0x2807030", VA = "0x280B030", Slot = "6")]
		internal override object Eval()
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x280B0E8", Offset = "0x28070E8", VA = "0x280B0E8", Slot = "7")]
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x280B0F4", Offset = "0x28070F4", VA = "0x280B0F4", Slot = "8")]
		internal override object Eval(int[] recordNos)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x280B100", Offset = "0x2807100", VA = "0x280B100", Slot = "9")]
		internal override bool IsConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x280B108", Offset = "0x2807108", VA = "0x280B108", Slot = "10")]
		internal override bool IsTableConstant()
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x280B110", Offset = "0x2807110", VA = "0x280B110", Slot = "11")]
		internal override bool HasLocalAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x280B118", Offset = "0x2807118", VA = "0x280B118", Slot = "12")]
		internal override bool HasRemoteAggregate()
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x280B120", Offset = "0x2807120", VA = "0x280B120", Slot = "13")]
		internal override ExpressionNode Optimize()
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	[DefaultProperty("ConstraintName")]
	public class ForeignKeyConstraint : Constraint
	{
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Rule _deleteRule;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal Rule _updateRule;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal AcceptRejectRule _acceptRejectRule;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DataKey _childKey;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DataKey _parentKey;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal string _constraintName;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal string[] _parentColumnNames;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal string[] _childColumnNames;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal string _parentTableName;

		[Token(Token = "0x170000E5")]
		internal DataKey ChildKey
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x280B384", Offset = "0x2807384", VA = "0x280B384")]
			get
			{
				return default(DataKey);
			}
		}

		[Token(Token = "0x170000E6")]
		[ReadOnly(true)]
		public virtual DataColumn[] Columns
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x280B3A0", Offset = "0x28073A0", VA = "0x280B3A0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E7")]
		[ReadOnly(true)]
		public override DataTable Table
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x280B3C0", Offset = "0x28073C0", VA = "0x280B3C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		internal string[] ParentColumnNames
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x280B3E0", Offset = "0x28073E0", VA = "0x280B3E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		internal string[] ChildColumnNames
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x280B3EC", Offset = "0x28073EC", VA = "0x280B3EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		[DefaultValue(AcceptRejectRule.None)]
		public virtual AcceptRejectRule AcceptRejectRule
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x280D05C", Offset = "0x280905C", VA = "0x280D05C", Slot = "20")]
			get
			{
				return default(AcceptRejectRule);
			}
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x280D078", Offset = "0x2809078", VA = "0x280D078", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		[DefaultValue(Rule.Cascade)]
		public virtual Rule DeleteRule
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x280DE1C", Offset = "0x2809E1C", VA = "0x280DE1C", Slot = "22")]
			get
			{
				return default(Rule);
			}
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x280DE38", Offset = "0x2809E38", VA = "0x280DE38", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		[ReadOnly(true)]
		public virtual DataColumn[] RelatedColumns
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x280DF7C", Offset = "0x2809F7C", VA = "0x280DF7C", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		internal DataColumn[] RelatedColumnsReference
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x280D834", Offset = "0x2809834", VA = "0x280D834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		internal DataKey ParentKey
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x280C9FC", Offset = "0x28089FC", VA = "0x280C9FC")]
			get
			{
				return default(DataKey);
			}
		}

		[Token(Token = "0x170000EF")]
		[ReadOnly(true)]
		public virtual DataTable RelatedTable
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x280E064", Offset = "0x280A064", VA = "0x280E064", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		[DefaultValue(Rule.Cascade)]
		public virtual Rule UpdateRule
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x280E084", Offset = "0x280A084", VA = "0x280E084", Slot = "26")]
			get
			{
				return default(Rule);
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x280E0A0", Offset = "0x280A0A0", VA = "0x280E0A0", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x280B124", Offset = "0x2807124", VA = "0x280B124")]
		public ForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x280B164", Offset = "0x2807164", VA = "0x280B164")]
		public ForeignKeyConstraint(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x280B318", Offset = "0x2807318", VA = "0x280B318")]
		[Browsable(false)]
		public ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x280B3F8", Offset = "0x28073F8", VA = "0x280B3F8", Slot = "13")]
		internal override void CheckCanAddToCollection(ConstraintCollection constraints)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x280B510", Offset = "0x2807510", VA = "0x280B510", Slot = "14")]
		internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException)
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x280B518", Offset = "0x2807518", VA = "0x280B518")]
		internal bool IsKeyNull(object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x280B5D4", Offset = "0x28075D4", VA = "0x280B5D4", Slot = "18")]
		internal override bool IsConstraintViolated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x280BA80", Offset = "0x2807A80", VA = "0x280BA80", Slot = "10")]
		internal override bool CanEnableConstraint()
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x280BBD4", Offset = "0x2807BD4", VA = "0x280BBD4")]
		internal void CascadeCommit(DataRow row)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x280BD38", Offset = "0x2807D38", VA = "0x280BD38")]
		internal void CascadeDelete(DataRow row)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x280C22C", Offset = "0x280822C", VA = "0x280C22C")]
		internal void CascadeRollback(DataRow row)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x280C40C", Offset = "0x280840C", VA = "0x280C40C")]
		internal void CascadeUpdate(DataRow row)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x280C874", Offset = "0x2808874", VA = "0x280C874")]
		internal void CheckCanClearParentTable(DataTable table)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x280C950", Offset = "0x2808950", VA = "0x280C950")]
		internal void CheckCanRemoveParentRow(DataRow row)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x280CA18", Offset = "0x2808A18", VA = "0x280CA18")]
		internal void CheckCascade(DataRow row, DataRowAction action)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x280CB3C", Offset = "0x2808B3C", VA = "0x280CB3C", Slot = "15")]
		internal override void CheckConstraint(DataRow childRow, DataRowAction action)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x280CE08", Offset = "0x2808E08", VA = "0x280CE08")]
		private void NonVirtualCheckState()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x280D058", Offset = "0x2809058", VA = "0x280D058", Slot = "16")]
		internal override void CheckState()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x280D0C8", Offset = "0x28090C8", VA = "0x280D0C8", Slot = "9")]
		internal override bool ContainsColumn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x280D110", Offset = "0x2809110", VA = "0x280D110", Slot = "11")]
		internal override Constraint Clone(DataSet destination)
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x280D120", Offset = "0x2809120", VA = "0x280D120", Slot = "12")]
		internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup)
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x280D850", Offset = "0x2809850", VA = "0x280D850")]
		internal ForeignKeyConstraint Clone(DataTable destination)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x280B1B0", Offset = "0x28071B0", VA = "0x280B1B0")]
		private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x280DE88", Offset = "0x2809E88", VA = "0x280DE88", Slot = "0")]
		public override bool Equals(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x280DF74", Offset = "0x2809F74", VA = "0x280DF74", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x280DF9C", Offset = "0x2809F9C", VA = "0x280DF9C")]
		internal DataRelation FindParentRelation()
		{
			return null;
		}
	}
	[Token(Token = "0x2000070")]
	public enum MappingType
	{
		[Token(Token = "0x4000244")]
		Element = 1,
		[Token(Token = "0x4000245")]
		Attribute,
		[Token(Token = "0x4000246")]
		SimpleContent,
		[Token(Token = "0x4000247")]
		Hidden
	}
	[Token(Token = "0x2000071")]
	public class MergeFailedEventArgs : EventArgs
	{
		[Token(Token = "0x170000F1")]
		public string Conflict
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x280E160", Offset = "0x280A160", VA = "0x280E160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x280E0F0", Offset = "0x280A0F0", VA = "0x280E0F0")]
		public MergeFailedEventArgs(DataTable table, string conflict)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public delegate void MergeFailedEventHandler(object sender, MergeFailedEventArgs e);
	[Token(Token = "0x2000073")]
	internal sealed class Merger
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DataSet _dataSet;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DataTable _dataTable;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _preserveChanges;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private MissingSchemaAction _missingSchemaAction;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isStandAlonetable;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool _IgnoreNSforTableLookup;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x280E280", Offset = "0x280A280", VA = "0x280E280")]
		internal Merger(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x280E2C8", Offset = "0x280A2C8", VA = "0x280E2C8")]
		internal Merger(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x280E318", Offset = "0x280A318", VA = "0x280E318")]
		internal void MergeDataSet(DataSet source)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x280FDF4", Offset = "0x280BDF4", VA = "0x280FDF4")]
		internal void MergeTable(DataTable src)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x281001C", Offset = "0x280C01C", VA = "0x281001C")]
		private void MergeTable(DataTable src, DataTable dst)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2810604", Offset = "0x280C604", VA = "0x2810604")]
		private DataTable MergeSchema(DataTable table)
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x280F290", Offset = "0x280B290", VA = "0x280F290")]
		private void MergeTableData(DataTable src)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x280F344", Offset = "0x280B344", VA = "0x280F344")]
		private void MergeConstraints(DataSet source)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x2810D14", Offset = "0x280CD14", VA = "0x2810D14")]
		private void MergeConstraints(DataTable table)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x280F3B4", Offset = "0x280B3B4", VA = "0x280F3B4")]
		private void MergeRelation(DataRelation relation)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x280FBA0", Offset = "0x280BBA0", VA = "0x280FBA0")]
		private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x28104C0", Offset = "0x280C4C0", VA = "0x28104C0")]
		private DataKey GetSrcKey(DataTable src, DataTable dst)
		{
			return default(DataKey);
		}
	}
	[Token(Token = "0x2000074")]
	public enum MissingSchemaAction
	{
		[Token(Token = "0x4000251")]
		Add = 1,
		[Token(Token = "0x4000252")]
		Ignore,
		[Token(Token = "0x4000253")]
		Error,
		[Token(Token = "0x4000254")]
		AddWithKey
	}
	[Token(Token = "0x2000075")]
	internal sealed class PrimaryKeyTypeConverter : ReferenceConverter
	{
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x2810FC4", Offset = "0x280CFC4", VA = "0x2810FC4")]
		public PrimaryKeyTypeConverter()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x2811078", Offset = "0x280D078", VA = "0x2811078", Slot = "11")]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x2811080", Offset = "0x280D080", VA = "0x2811080", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2811148", Offset = "0x280D148", VA = "0x2811148", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class PropertyCollection : Hashtable, ICloneable
	{
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2811310", Offset = "0x280D310", VA = "0x2811310")]
		public PropertyCollection()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2811318", Offset = "0x280D318", VA = "0x2811318")]
		protected PropertyCollection(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2811320", Offset = "0x280D320", VA = "0x2811320", Slot = "24")]
		public override object Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x2000077")]
	internal struct Range
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _min;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private int _max;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool _isNotNull;

		[Token(Token = "0x170000F2")]
		public int Count
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x280C1C8", Offset = "0x28081C8", VA = "0x280C1C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F3")]
		public bool IsNull
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x280BD28", Offset = "0x2807D28", VA = "0x280BD28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F4")]
		public int Min
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x280C1E8", Offset = "0x28081E8", VA = "0x280C1E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x28115EC", Offset = "0x280D5EC", VA = "0x28115EC")]
		public Range(int min, int max)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2811634", Offset = "0x280D634", VA = "0x2811634")]
		internal void CheckNull()
		{
		}
	}
	[Token(Token = "0x2000078")]
	internal enum RBTreeError
	{
		[Token(Token = "0x4000259")]
		InvalidPageSize = 1,
		[Token(Token = "0x400025A")]
		PagePositionInSlotInUse = 3,
		[Token(Token = "0x400025B")]
		NoFreeSlots = 4,
		[Token(Token = "0x400025C")]
		InvalidStateinInsert = 5,
		[Token(Token = "0x400025D")]
		InvalidNextSizeInDelete = 7,
		[Token(Token = "0x400025E")]
		InvalidStateinDelete = 8,
		[Token(Token = "0x400025F")]
		InvalidNodeSizeinDelete = 9,
		[Token(Token = "0x4000260")]
		InvalidStateinEndDelete = 10,
		[Token(Token = "0x4000261")]
		CannotRotateInvalidsuccessorNodeinDelete = 11,
		[Token(Token = "0x4000262")]
		IndexOutOFRangeinGetNodeByIndex = 13,
		[Token(Token = "0x4000263")]
		RBDeleteFixup = 14,
		[Token(Token = "0x4000264")]
		UnsupportedAccessMethod1 = 15,
		[Token(Token = "0x4000265")]
		UnsupportedAccessMethod2 = 16,
		[Token(Token = "0x4000266")]
		UnsupportedAccessMethodInNonNillRootSubtree = 17,
		[Token(Token = "0x4000267")]
		AttachedNodeWithZerorbTreeNodeId = 18,
		[Token(Token = "0x4000268")]
		CompareNodeInDataRowTree = 19,
		[Token(Token = "0x4000269")]
		CompareSateliteTreeNodeInDataRowTree = 20,
		[Token(Token = "0x400026A")]
		NestedSatelliteTreeEnumerator = 21
	}
	[Token(Token = "0x2000079")]
	internal enum TreeAccessMethod
	{
		[Token(Token = "0x400026C")]
		KEY_SEARCH_AND_INDEX = 1,
		[Token(Token = "0x400026D")]
		INDEX_ONLY
	}
	[Token(Token = "0x200007A")]
	internal abstract class RBTree<K> : IEnumerable
	{
		[Token(Token = "0x200007B")]
		private enum NodeColor
		{
			[Token(Token = "0x4000278")]
			red,
			[Token(Token = "0x4000279")]
			black
		}

		[Token(Token = "0x200007C")]
		private struct Node
		{
			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _selfId;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _leftId;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _rightId;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _parentId;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _nextId;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _subTreeSize;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal K _keyOfNode;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal NodeColor _nodeColor;
		}

		[Token(Token = "0x200007D")]
		private readonly struct NodePath
		{
			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal readonly int _nodeID;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal readonly int _mainTreeNodeID;

			[Token(Token = "0x6000691")]
			internal NodePath(int nodeID, int mainTreeNodeID)
			{
			}
		}

		[Token(Token = "0x200007E")]
		private sealed class TreePage
		{
			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal readonly Node[] _slots;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal readonly int[] _slotMap;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _inUseCount;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _pageId;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _nextFreeSlotLine;

			[Token(Token = "0x170000F8")]
			internal int InUseCount
			{
				[Token(Token = "0x6000694")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000695")]
				set
				{
				}
			}

			[Token(Token = "0x170000F9")]
			internal int PageId
			{
				[Token(Token = "0x6000696")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000697")]
				set
				{
				}
			}

			[Token(Token = "0x6000692")]
			internal TreePage(int size)
			{
			}

			[Token(Token = "0x6000693")]
			internal int AllocSlot(RBTree<K> tree)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200007F")]
		internal struct RBTreeEnumerator : IEnumerator<K>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly RBTree<K> _tree;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int _version;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _index;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _mainTreeNodeId;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private K _current;

			[Token(Token = "0x170000FA")]
			public K Current
			{
				[Token(Token = "0x600069C")]
				get
				{
					return (K)null;
				}
			}

			[Token(Token = "0x170000FB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600069D")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000698")]
			internal RBTreeEnumerator(RBTree<K> tree)
			{
			}

			[Token(Token = "0x6000699")]
			internal RBTreeEnumerator(RBTree<K> tree, int position)
			{
			}

			[Token(Token = "0x600069A")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600069B")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600069E")]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TreePage[] _pageTable;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _pageTableMap;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _inUsePageCount;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _nextFreePageLine;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int root;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _version;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _inUseNodeCount;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _inUseSatelliteTreeCount;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TreeAccessMethod _accessMethod;

		[Token(Token = "0x170000F5")]
		public int Count
		{
			[Token(Token = "0x600065D")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F6")]
		public bool HasDuplicates
		{
			[Token(Token = "0x600065E")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F7")]
		public K this[int index]
		{
			[Token(Token = "0x600066C")]
			get
			{
				return (K)null;
			}
		}

		[Token(Token = "0x6000652")]
		protected abstract int CompareNode(K record1, K record2);

		[Token(Token = "0x6000653")]
		protected abstract int CompareSateliteTreeNode(K record1, K record2);

		[Token(Token = "0x6000654")]
		protected RBTree(TreeAccessMethod accessMethod)
		{
		}

		[Token(Token = "0x6000655")]
		private void InitTree()
		{
		}

		[Token(Token = "0x6000656")]
		private void FreePage(TreePage page)
		{
		}

		[Token(Token = "0x6000657")]
		private TreePage AllocPage(int size)
		{
			return null;
		}

		[Token(Token = "0x6000658")]
		private void MarkPageFull(TreePage page)
		{
		}

		[Token(Token = "0x6000659")]
		private void MarkPageFree(TreePage page)
		{
		}

		[Token(Token = "0x600065A")]
		private static int GetIntValueFromBitMap(uint bitMap)
		{
			return default(int);
		}

		[Token(Token = "0x600065B")]
		private void FreeNode(int nodeId)
		{
		}

		[Token(Token = "0x600065C")]
		private int GetIndexOfPageWithFreeSlot(bool allocatedPage)
		{
			return default(int);
		}

		[Token(Token = "0x600065F")]
		private int GetNewNode(K key)
		{
			return default(int);
		}

		[Token(Token = "0x6000660")]
		private int Successor(int x_id)
		{
			return default(int);
		}

		[Token(Token = "0x6000661")]
		private bool Successor(ref int nodeId, ref int mainTreeNodeId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		private int Minimum(int x_id)
		{
			return default(int);
		}

		[Token(Token = "0x6000663")]
		private int LeftRotate(int root_id, int x_id, int mainTreeNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000664")]
		private int RightRotate(int root_id, int x_id, int mainTreeNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000665")]
		private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append)
		{
			return default(int);
		}

		[Token(Token = "0x6000666")]
		public void UpdateNodeKey(K currentKey, K newKey)
		{
		}

		[Token(Token = "0x6000667")]
		public K DeleteByIndex(int i)
		{
			return (K)null;
		}

		[Token(Token = "0x6000668")]
		public int RBDelete(int z_id)
		{
			return default(int);
		}

		[Token(Token = "0x6000669")]
		private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID)
		{
			return default(int);
		}

		[Token(Token = "0x600066A")]
		private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID)
		{
			return default(int);
		}

		[Token(Token = "0x600066B")]
		private int SearchSubTree(int root_id, K key)
		{
			return default(int);
		}

		[Token(Token = "0x600066D")]
		private NodePath GetNodeByKey(K key)
		{
			return default(NodePath);
		}

		[Token(Token = "0x600066E")]
		public int GetIndexByKey(K key)
		{
			return default(int);
		}

		[Token(Token = "0x600066F")]
		public int GetIndexByNode(int node)
		{
			return default(int);
		}

		[Token(Token = "0x6000670")]
		private int GetIndexByNodePath(NodePath path)
		{
			return default(int);
		}

		[Token(Token = "0x6000671")]
		private int ComputeIndexByNode(int nodeId)
		{
			return default(int);
		}

		[Token(Token = "0x6000672")]
		private int ComputeIndexWithSatelliteByNode(int nodeId)
		{
			return default(int);
		}

		[Token(Token = "0x6000673")]
		private NodePath GetNodeByIndex(int userIndex)
		{
			return default(NodePath);
		}

		[Token(Token = "0x6000674")]
		private int ComputeNodeByIndex(int index, out int satelliteRootId)
		{
			return default(int);
		}

		[Token(Token = "0x6000675")]
		private int ComputeNodeByIndex(int x_id, int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000676")]
		public int Insert(K item)
		{
			return default(int);
		}

		[Token(Token = "0x6000677")]
		public int Add(K item)
		{
			return default(int);
		}

		[Token(Token = "0x6000678")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		public int IndexOf(int nodeId, K item)
		{
			return default(int);
		}

		[Token(Token = "0x600067A")]
		public int Insert(int position, K item)
		{
			return default(int);
		}

		[Token(Token = "0x600067B")]
		public int InsertAt(int position, K item, bool append)
		{
			return default(int);
		}

		[Token(Token = "0x600067C")]
		public void RemoveAt(int position)
		{
		}

		[Token(Token = "0x600067D")]
		public void Clear()
		{
		}

		[Token(Token = "0x600067E")]
		public void CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x600067F")]
		public void CopyTo(K[] array, int index)
		{
		}

		[Token(Token = "0x6000680")]
		private void SetRight(int nodeId, int rightNodeId)
		{
		}

		[Token(Token = "0x6000681")]
		private void SetLeft(int nodeId, int leftNodeId)
		{
		}

		[Token(Token = "0x6000682")]
		private void SetParent(int nodeId, int parentNodeId)
		{
		}

		[Token(Token = "0x6000683")]
		private void SetColor(int nodeId, NodeColor color)
		{
		}

		[Token(Token = "0x6000684")]
		private void SetKey(int nodeId, K key)
		{
		}

		[Token(Token = "0x6000685")]
		private void SetNext(int nodeId, int nextNodeId)
		{
		}

		[Token(Token = "0x6000686")]
		private void SetSubTreeSize(int nodeId, int size)
		{
		}

		[Token(Token = "0x6000687")]
		private void IncreaseSize(int nodeId)
		{
		}

		[Token(Token = "0x6000688")]
		private void RecomputeSize(int nodeId)
		{
		}

		[Token(Token = "0x6000689")]
		private void DecreaseSize(int nodeId)
		{
		}

		[Token(Token = "0x600068A")]
		public int Right(int nodeId)
		{
			return default(int);
		}

		[Token(Token = "0x600068B")]
		public int Left(int nodeId)
		{
			return default(int);
		}

		[Token(Token = "0x600068C")]
		public int Parent(int nodeId)
		{
			return default(int);
		}

		[Token(Token = "0x600068D")]
		private NodeColor color(int nodeId)
		{
			return default(NodeColor);
		}

		[Token(Token = "0x600068E")]
		public int Next(int nodeId)
		{
			return default(int);
		}

		[Token(Token = "0x600068F")]
		public int SubTreeSize(int nodeId)
		{
			return default(int);
		}

		[Token(Token = "0x6000690")]
		public K Key(int nodeId)
		{
			return (K)null;
		}
	}
	[Token(Token = "0x2000080")]
	internal sealed class RecordManager
	{
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DataTable _table;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _lastFreeRecord;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _minimumCapacity;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _recordCapacity;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<int> _freeRecordList;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DataRow[] _rows;

		[Token(Token = "0x170000FC")]
		internal int LastFreeRecord
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x2811910", Offset = "0x280D910", VA = "0x2811910")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000FD")]
		internal int MinimumCapacity
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x2811918", Offset = "0x280D918", VA = "0x2811918")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x2811920", Offset = "0x280D920", VA = "0x2811920")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		internal int RecordCapacity
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x2811960", Offset = "0x280D960", VA = "0x2811960")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x2811880", Offset = "0x280D880", VA = "0x2811880")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		internal DataRow this[int record]
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x2811DE8", Offset = "0x280DDE8", VA = "0x2811DE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x2811B98", Offset = "0x280DB98", VA = "0x2811B98")]
			set
			{
			}
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x2811668", Offset = "0x280D668", VA = "0x2811668")]
		internal RecordManager(DataTable table)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x281172C", Offset = "0x280D72C", VA = "0x281172C")]
		private void GrowRecordCapacity()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2811838", Offset = "0x280D838", VA = "0x2811838")]
		internal static int NewCapacity(int capacity)
		{
			return default(int);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x281184C", Offset = "0x280D84C", VA = "0x281184C")]
		private int NormalizedMinimumCapacity(int capacity)
		{
			return default(int);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2811968", Offset = "0x280D968", VA = "0x2811968")]
		internal int NewRecordBase()
		{
			return default(int);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x2811A34", Offset = "0x280DA34", VA = "0x2811A34")]
		internal void FreeRecord(ref int record)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x2811BFC", Offset = "0x280DBFC", VA = "0x2811BFC")]
		internal void Clear(bool clearAll)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x2811E18", Offset = "0x280DE18", VA = "0x2811E18")]
		internal int ImportRecord(DataTable src, int record)
		{
			return default(int);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x2811E20", Offset = "0x280DE20", VA = "0x2811E20")]
		internal int CopyRecord(DataTable src, int record, int copy)
		{
			return default(int);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x2812134", Offset = "0x280E134", VA = "0x2812134")]
		internal void SetRowCache(DataRow[] newRows)
		{
		}
	}
	[Token(Token = "0x2000081")]
	internal sealed class RelatedView : DataView, IFilter
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly DataKey? _parentKey;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly DataKey _childKey;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly DataRowView _parentRowView;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly object[] _filterValues;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x2812154", Offset = "0x280E154", VA = "0x2812154")]
		public RelatedView(DataColumn[] columns, object[] values)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x281226C", Offset = "0x280E26C", VA = "0x281226C")]
		public RelatedView(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x2812374", Offset = "0x280E374", VA = "0x2812374")]
		private object[] GetParentValues()
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x2812410", Offset = "0x280E410", VA = "0x2812410", Slot = "33")]
		public bool Invoke(DataRow row, DataRowVersion version)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x2812598", Offset = "0x280E598", VA = "0x2812598", Slot = "27")]
		internal override IFilter GetFilter()
		{
			return null;
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x281259C", Offset = "0x280E59C", VA = "0x281259C", Slot = "26")]
		public override DataRowView AddNew()
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x28125FC", Offset = "0x280E5FC", VA = "0x28125FC", Slot = "30")]
		internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter)
		{
		}
	}
	[Token(Token = "0x2000082")]
	internal sealed class RelationshipConverter : ExpandableObjectConverter
	{
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x2812620", Offset = "0x280E620", VA = "0x2812620")]
		public RelationshipConverter()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2812628", Offset = "0x280E628", VA = "0x2812628", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x28126F0", Offset = "0x280E6F0", VA = "0x28126F0", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	public enum Rule
	{
		[Token(Token = "0x4000299")]
		None,
		[Token(Token = "0x400029A")]
		Cascade,
		[Token(Token = "0x400029B")]
		SetNull,
		[Token(Token = "0x400029C")]
		SetDefault
	}
	[Token(Token = "0x2000084")]
	public enum SchemaSerializationMode
	{
		[Token(Token = "0x400029E")]
		IncludeSchema = 1,
		[Token(Token = "0x400029F")]
		ExcludeSchema
	}
	[Token(Token = "0x2000085")]
	internal readonly struct IndexField
	{
		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly DataColumn Column;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly bool IsDescending;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x28131BC", Offset = "0x280F1BC", VA = "0x28131BC")]
		internal IndexField(DataColumn column, bool isDescending)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x28131C8", Offset = "0x280F1C8", VA = "0x28131C8")]
		public static bool operator ==(IndexField if1, IndexField if2)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x28131DC", Offset = "0x280F1DC", VA = "0x28131DC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2813264", Offset = "0x280F264", VA = "0x2813264", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000086")]
	internal sealed class Index
	{
		[Token(Token = "0x2000087")]
		private sealed class IndexTree : RBTree<int>
		{
			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private readonly Index _index;

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x2815A14", Offset = "0x2811A14", VA = "0x2815A14")]
			internal IndexTree(Index index)
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x28162E4", Offset = "0x28122E4", VA = "0x28162E4", Slot = "5")]
			protected override int CompareNode(int record1, int record2)
			{
				return default(int);
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x28162F8", Offset = "0x28122F8", VA = "0x28162F8", Slot = "6")]
			protected override int CompareSateliteTreeNode(int record1, int record2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DataTable _table;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly IndexField[] _indexFields;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Comparison<DataRow> _comparison;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly DataViewRowState _recordStates;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WeakReference _rowFilter;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IndexTree _records;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _recordCount;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _refCount;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Listeners<DataViewListener> _listeners;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _suspendEvents;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private readonly bool _isSharable;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private readonly bool _hasRemoteAggregate;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_objectTypeCount;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private readonly int _objectID;

		[Token(Token = "0x17000100")]
		internal bool HasRemoteAggregate
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x2813B20", Offset = "0x280FB20", VA = "0x2813B20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000101")]
		internal int ObjectID
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x2813B28", Offset = "0x280FB28", VA = "0x2813B28")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000102")]
		public DataViewRowState RecordStates
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x2813B30", Offset = "0x280FB30", VA = "0x2813B30")]
			get
			{
				return default(DataViewRowState);
			}
		}

		[Token(Token = "0x17000103")]
		public IFilter RowFilter
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x2813B38", Offset = "0x280FB38", VA = "0x2813B38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		public bool HasDuplicates
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x2813C08", Offset = "0x280FC08", VA = "0x2813C08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000105")]
		public int RecordCount
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x2813C58", Offset = "0x280FC58", VA = "0x2813C58")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000106")]
		public int RefCount
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x2813ED0", Offset = "0x280FED0", VA = "0x2813ED0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000107")]
		private bool DoListChanged
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x28157B0", Offset = "0x28117B0", VA = "0x28157B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000108")]
		internal DataTable Table
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x28162DC", Offset = "0x28122DC", VA = "0x28162DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x28132E4", Offset = "0x280F2E4", VA = "0x28132E4")]
		public Index(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x28135C0", Offset = "0x280F5C0", VA = "0x28135C0")]
		public Index(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x2813618", Offset = "0x280F618", VA = "0x2813618")]
		private static IndexField[] GetAllFields(DataColumnCollection columns)
		{
			return null;
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x28132F4", Offset = "0x280F2F4", VA = "0x28132F4")]
		private Index(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2813A88", Offset = "0x280FA88", VA = "0x2813A88")]
		public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x2813BB0", Offset = "0x280FBB0", VA = "0x2813BB0")]
		public int GetRecord(int recordIndex)
		{
			return default(int);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x2813C60", Offset = "0x280FC60", VA = "0x2813C60")]
		private bool AcceptRecord(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x2813C8C", Offset = "0x280FC8C", VA = "0x2813C8C")]
		private bool AcceptRecord(int record, IFilter filter)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x2813E20", Offset = "0x280FE20", VA = "0x2813E20")]
		internal void ListChangedAdd(DataViewListener listener)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x2813E78", Offset = "0x280FE78", VA = "0x2813E78")]
		internal void ListChangedRemove(DataViewListener listener)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x2813ED8", Offset = "0x280FED8", VA = "0x2813ED8")]
		public void AddRef()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x28140BC", Offset = "0x28100BC", VA = "0x28140BC")]
		public int RemoveRef()
		{
			return default(int);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x281426C", Offset = "0x281026C", VA = "0x281426C")]
		private void ApplyChangeAction(int record, int action, int changeRecord)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x28146E8", Offset = "0x28106E8", VA = "0x28146E8")]
		public bool CheckUnique()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2814700", Offset = "0x2810700", VA = "0x2814700")]
		private int CompareRecords(int record1, int record2)
		{
			return default(int);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x281485C", Offset = "0x281085C", VA = "0x281485C")]
		private int CompareDataRows(int record1, int record2)
		{
			return default(int);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x28148C8", Offset = "0x28108C8", VA = "0x28148C8")]
		private int CompareDuplicateRecords(int record1, int record2)
		{
			return default(int);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2814A18", Offset = "0x2810A18", VA = "0x2814A18")]
		private int CompareRecordToKey(int record1, object[] vals)
		{
			return default(int);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x2814AE4", Offset = "0x2810AE4", VA = "0x2814AE4")]
		public void DeleteRecordFromIndex(int recordIndex)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x2814688", Offset = "0x2810688", VA = "0x2814688")]
		private void DeleteRecord(int recordIndex)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x2814AEC", Offset = "0x2810AEC", VA = "0x2814AEC")]
		private void DeleteRecord(int recordIndex, bool fireEvent)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x2814DC0", Offset = "0x2810DC0", VA = "0x2814DC0")]
		public RBTree<int>.RBTreeEnumerator GetEnumerator(int startIndex)
		{
			return default(RBTree<int>.RBTreeEnumerator);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x2814690", Offset = "0x2810690", VA = "0x2814690")]
		public int GetIndex(int record)
		{
			return default(int);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x2814508", Offset = "0x2810508", VA = "0x2814508")]
		private int GetIndex(int record, int changeRecord)
		{
			return default(int);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x280B7C8", Offset = "0x28077C8", VA = "0x280B7C8")]
		public object[] GetUniqueKeyValues()
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x281503C", Offset = "0x281103C", VA = "0x281503C")]
		private int FindNodeByKey(object originalKey)
		{
			return default(int);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x2815254", Offset = "0x2811254", VA = "0x2815254")]
		private int FindNodeByKeys(object[] originalKey)
		{
			return default(int);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x2815484", Offset = "0x2811484", VA = "0x2815484")]
		private int FindNodeByKeyRecord(int record)
		{
			return default(int);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x281557C", Offset = "0x281157C", VA = "0x281557C")]
		private Range GetRangeFromNode(int nodeId)
		{
			return default(Range);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x28156A4", Offset = "0x28116A4", VA = "0x28156A4")]
		public Range FindRecords(object key)
		{
			return default(Range);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x280B90C", Offset = "0x280790C", VA = "0x280B90C")]
		public Range FindRecords(object[] key)
		{
			return default(Range);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x28156C8", Offset = "0x28116C8", VA = "0x28156C8")]
		internal void FireResetEvent()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x28159A8", Offset = "0x28119A8", VA = "0x28159A8")]
		private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState)
		{
			return default(int);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x28159C4", Offset = "0x28119C4", VA = "0x28159C4")]
		private static int GetReplaceAction(DataViewRowState oldState)
		{
			return default(int);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x280C200", Offset = "0x2808200", VA = "0x280C200")]
		public DataRow GetRow(int i)
		{
			return null;
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x28159E4", Offset = "0x28119E4", VA = "0x28159E4")]
		public DataRow[] GetRows(object[] values)
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x280B930", Offset = "0x2807930", VA = "0x280B930")]
		public DataRow[] GetRows(Range range)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x28136E4", Offset = "0x280F6E4", VA = "0x28136E4")]
		private void InitRecords(IFilter filter)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2815A74", Offset = "0x2811A74", VA = "0x2815A74")]
		public int InsertRecordToIndex(int record)
		{
			return default(int);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2814310", Offset = "0x2810310", VA = "0x2814310")]
		private int InsertRecord(int record, bool fireEvent)
		{
			return default(int);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x2815AC4", Offset = "0x2811AC4", VA = "0x2815AC4")]
		public bool IsKeyInIndex(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x280B8F4", Offset = "0x28078F4", VA = "0x280B8F4")]
		public bool IsKeyInIndex(object[] key)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2815ADC", Offset = "0x2811ADC", VA = "0x2815ADC")]
		public bool IsKeyRecordInIndex(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x2815AF4", Offset = "0x2811AF4", VA = "0x2815AF4")]
		private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2814D30", Offset = "0x2810D30", VA = "0x2814D30")]
		private void OnListChanged(ListChangedType changedType, int index)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x2815830", Offset = "0x2811830", VA = "0x2815830")]
		private void OnListChanged(ListChangedEventArgs e)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2814C14", Offset = "0x2810C14", VA = "0x2814C14")]
		private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x2815B94", Offset = "0x2811B94", VA = "0x2815B94")]
		public void Reset()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x2815C5C", Offset = "0x2811C5C", VA = "0x2815C5C")]
		public void RecordChanged(int record)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x2815D40", Offset = "0x2811D40", VA = "0x2815D40")]
		public void RecordChanged(int oldIndex, int newIndex)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x2815E6C", Offset = "0x2811E6C", VA = "0x2815E6C")]
		public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x2815F6C", Offset = "0x2811F6C", VA = "0x2815F6C")]
		public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x2814E28", Offset = "0x2810E28", VA = "0x2814E28")]
		private void GetUniqueKeyValues(List<object[]> list, int curNodeId)
		{
		}

		[Token(Token = "0x60006FC")]
		internal static int IndexOfReference<T>(List<T> list, T item) where T : class
		{
			return default(int);
		}
	}
	[Token(Token = "0x200008A")]
	internal sealed class Listeners<TElem> where TElem : class
	{
		[Token(Token = "0x200008B")]
		internal delegate void Action<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

		[Token(Token = "0x200008C")]
		internal delegate TResult Func<T1, TResult>(T1 arg1);

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<TElem> _listeners;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Func<TElem, bool> _filter;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _objectID;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _listenerReaderCount;

		[Token(Token = "0x17000109")]
		internal bool HasListeners
		{
			[Token(Token = "0x6000707")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000706")]
		internal Listeners(int ObjectID, Func<TElem, bool> notifyFilter)
		{
		}

		[Token(Token = "0x6000708")]
		internal void Add(TElem listener)
		{
		}

		[Token(Token = "0x6000709")]
		internal int IndexOfReference(TElem listener)
		{
			return default(int);
		}

		[Token(Token = "0x600070A")]
		internal void Remove(TElem listener)
		{
		}

		[Token(Token = "0x600070B")]
		internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Action<TElem, T1, T2, T3> action)
		{
		}

		[Token(Token = "0x600070C")]
		private void RemoveNullListeners(int nullIndex)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	internal sealed class SimpleType : ISerializable
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _baseType;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SimpleType _baseSimpleType;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private XmlQualifiedName _xmlBaseType;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _name;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _length;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _minLength;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _maxLength;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _pattern;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _ns;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string _maxExclusive;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string _maxInclusive;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _minExclusive;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _minInclusive;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal string _enumeration;

		[Token(Token = "0x1700010A")]
		internal string BaseType
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x28170B4", Offset = "0x28130B4", VA = "0x28170B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		internal XmlQualifiedName XmlBaseType
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x28170BC", Offset = "0x28130BC", VA = "0x28170BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		internal string Name
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x28170C4", Offset = "0x28130C4", VA = "0x28170C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		internal string Namespace
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x28170CC", Offset = "0x28130CC", VA = "0x28170CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		internal int Length
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x28170D4", Offset = "0x28130D4", VA = "0x28170D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700010F")]
		internal int MaxLength
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x28170DC", Offset = "0x28130DC", VA = "0x28170DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x28170E4", Offset = "0x28130E4", VA = "0x28170E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		internal SimpleType BaseSimpleType
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x28170EC", Offset = "0x28130EC", VA = "0x28170EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		public string SimpleTypeQualifiedName
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x28170F4", Offset = "0x28130F4", VA = "0x28170F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x28163C0", Offset = "0x28123C0", VA = "0x28163C0")]
		internal SimpleType(string baseType)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x281644C", Offset = "0x281244C", VA = "0x281644C")]
		internal SimpleType(XmlSchemaSimpleType node)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x2816DB8", Offset = "0x2812DB8", VA = "0x2816DB8", Slot = "4")]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x281656C", Offset = "0x281256C", VA = "0x281656C")]
		internal void LoadTypeValues(XmlSchemaSimpleType node)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x2816F08", Offset = "0x2812F08", VA = "0x2816F08")]
		internal bool IsPlainString()
		{
			return default(bool);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2817164", Offset = "0x2813164", VA = "0x2817164")]
		internal string QualifiedName(string name)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x28171E0", Offset = "0x28131E0", VA = "0x28171E0")]
		internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting)
		{
			return null;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2817640", Offset = "0x2813640", VA = "0x2817640")]
		internal static SimpleType CreateEnumeratedType(string values)
		{
			return null;
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x28176C0", Offset = "0x28136C0", VA = "0x28176C0")]
		internal static SimpleType CreateByteArrayType(string encoding)
		{
			return null;
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2817728", Offset = "0x2813728", VA = "0x2817728")]
		internal static SimpleType CreateLimitedStringType(int length)
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x28177A8", Offset = "0x28137A8", VA = "0x28177A8")]
		internal static SimpleType CreateSimpleType(StorageType typeCode, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2817898", Offset = "0x2813898", VA = "0x2817898")]
		internal string HasConflictingDefinition(SimpleType otherSimpleType)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2817998", Offset = "0x2813998", VA = "0x2817998")]
		internal bool CanHaveMaxLength()
		{
			return default(bool);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x28179FC", Offset = "0x28139FC", VA = "0x28179FC")]
		internal void ConvertToAnnonymousSimpleType()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[DefaultProperty("ConstraintName")]
	public class UniqueConstraint : Constraint
	{
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DataKey _key;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Index _constraintIndex;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal bool _bPrimaryKey;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal string _constraintName;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal string[] _columnNames;

		[Token(Token = "0x17000112")]
		internal string[] ColumnNames
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x2817CEC", Offset = "0x2813CEC", VA = "0x2817CEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000113")]
		internal Index ConstraintIndex
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x2817CF8", Offset = "0x2813CF8", VA = "0x2817CF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		[ReadOnly(true)]
		public virtual DataColumn[] Columns
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x2818C64", Offset = "0x2814C64", VA = "0x2818C64", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		internal DataColumn[] ColumnsReference
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x2818288", Offset = "0x2814288", VA = "0x2818288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000116")]
		public bool IsPrimaryKey
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x2818C70", Offset = "0x2814C70", VA = "0x2818C70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		internal override bool InCollection
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x2818D5C", Offset = "0x2814D5C", VA = "0x2818D5C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		internal DataKey Key
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x2818DA8", Offset = "0x2814DA8", VA = "0x2818DA8")]
			get
			{
				return default(DataKey);
			}
		}

		[Token(Token = "0x17000119")]
		[ReadOnly(true)]
		public override DataTable Table
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x2818DB0", Offset = "0x2814DB0", VA = "0x2818DB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2817A70", Offset = "0x2813A70", VA = "0x2817A70")]
		public UniqueConstraint(DataColumn column)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x2817C08", Offset = "0x2813C08", VA = "0x2817C08")]
		public UniqueConstraint(string name, DataColumn[] columns)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x2817C3C", Offset = "0x2813C3C", VA = "0x2817C3C")]
		public UniqueConstraint(DataColumn[] columns)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x2817C6C", Offset = "0x2813C6C", VA = "0x2817C6C")]
		[Browsable(false)]
		public UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x2817CA8", Offset = "0x2813CA8", VA = "0x2817CA8")]
		public UniqueConstraint(string name, DataColumn[] columns, bool isPrimaryKey)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x2817D00", Offset = "0x2813D00", VA = "0x2817D00")]
		internal void ConstraintIndexClear()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2817D20", Offset = "0x2813D20", VA = "0x2817D20")]
		internal void ConstraintIndexInitialize()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x2817D58", Offset = "0x2813D58", VA = "0x2817D58", Slot = "16")]
		internal override void CheckState()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x2817D64", Offset = "0x2813D64", VA = "0x2817D64")]
		private void NonVirtualCheckState()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x2817D70", Offset = "0x2813D70", VA = "0x2817D70", Slot = "13")]
		internal override void CheckCanAddToCollection(ConstraintCollection constraints)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x2817D74", Offset = "0x2813D74", VA = "0x2817D74", Slot = "14")]
		internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException)
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x2817EE0", Offset = "0x2813EE0", VA = "0x2817EE0", Slot = "10")]
		internal override bool CanEnableConstraint()
		{
			return default(bool);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x2817F2C", Offset = "0x2813F2C", VA = "0x2817F2C", Slot = "18")]
		internal override bool IsConstraintViolated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2818190", Offset = "0x2814190", VA = "0x2818190", Slot = "15")]
		internal override void CheckConstraint(DataRow row, DataRowAction action)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2818290", Offset = "0x2814290", VA = "0x2818290", Slot = "9")]
		internal override bool ContainsColumn(DataColumn column)
		{
			return default(bool);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x281829C", Offset = "0x281429C", VA = "0x281829C", Slot = "11")]
		internal override Constraint Clone(DataSet destination)
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x28182AC", Offset = "0x28142AC", VA = "0x28182AC", Slot = "12")]
		internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup)
		{
			return null;
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x28187E0", Offset = "0x28147E0", VA = "0x28187E0")]
		internal UniqueConstraint Clone(DataTable table)
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x2817B20", Offset = "0x2813B20", VA = "0x2817B20")]
		private void Create(string constraintName, DataColumn[] columns)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x2818CB4", Offset = "0x2814CB4", VA = "0x2818CB4", Slot = "0")]
		public override bool Equals(object key2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x2818D54", Offset = "0x2814D54", VA = "0x2818D54", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200008F")]
	internal sealed class XDRSchema : XMLSchema
	{
		[Token(Token = "0x2000090")]
		private sealed class NameType : IComparable
		{
			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type type;

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x281C68C", Offset = "0x281868C", VA = "0x281C68C")]
			public NameType(string n, Type t)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x281C6B8", Offset = "0x28186B8", VA = "0x281C6B8", Slot = "4")]
			public int CompareTo(object obj)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string _schemaName;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string _schemaUri;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal XmlElement _schemaRoot;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal DataSet _ds;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] s_colonArray;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static NameType[] s_mapNameTypeXdr;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static NameType s_enumerationNameType;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x2818DE4", Offset = "0x2814DE4", VA = "0x2818DE4")]
		internal XDRSchema(DataSet ds, bool fInline)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x2818E58", Offset = "0x2814E58", VA = "0x2818E58")]
		internal void LoadSchema(XmlElement schemaRoot, DataSet ds)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x2819298", Offset = "0x2815298", VA = "0x2819298")]
		internal XmlElement FindTypeNode(XmlElement node)
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x28195B0", Offset = "0x28155B0", VA = "0x28195B0")]
		internal bool IsTextOnlyContent(XmlElement node)
		{
			return default(bool);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x2819780", Offset = "0x2815780", VA = "0x2819780")]
		internal bool IsXDRField(XmlElement node, XmlElement typeNode)
		{
			return default(bool);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x28190D8", Offset = "0x28150D8", VA = "0x28190D8")]
		internal DataTable HandleTable(XmlElement node)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x281A184", Offset = "0x2816184", VA = "0x281A184")]
		private static NameType FindNameType(string name)
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x281A258", Offset = "0x2816258", VA = "0x281A258")]
		private Type ParseDataType(string dt, string dtValues)
		{
			return null;
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x281A3A4", Offset = "0x28163A4", VA = "0x281A3A4")]
		internal string GetInstanceName(XmlElement node)
		{
			return null;
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x281A51C", Offset = "0x281651C", VA = "0x281A51C")]
		internal void HandleColumn(XmlElement node, DataTable table)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x28198D4", Offset = "0x28158D4", VA = "0x28198D4")]
		internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x281AEC8", Offset = "0x2816EC8", VA = "0x281AEC8")]
		internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x281B64C", Offset = "0x281764C", VA = "0x281B64C")]
		internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x2819B10", Offset = "0x2815B10", VA = "0x2819B10")]
		internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode)
		{
			return null;
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x28198E4", Offset = "0x28158E4", VA = "0x28198E4")]
		internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node)
		{
			return null;
		}
	}
	[Token(Token = "0x2000091")]
	internal sealed class XMLDiffLoader
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ArrayList _tables;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DataSet _dataSet;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataTable _dataTable;

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x281C728", Offset = "0x2818728", VA = "0x281C728")]
		internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x281CF44", Offset = "0x2818F44", VA = "0x281CF44")]
		private void CreateTablesHierarchy(DataTable dt)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x281D290", Offset = "0x2819290", VA = "0x281D290")]
		internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x281C8CC", Offset = "0x28188CC", VA = "0x281C8CC")]
		internal void ProcessDiffs(DataSet ds, XmlReader ssync)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x281D484", Offset = "0x2819484", VA = "0x281D484")]
		internal void ProcessDiffs(ArrayList tableList, XmlReader ssync)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x281CBA4", Offset = "0x2818BA4", VA = "0x281CBA4")]
		internal void ProcessErrors(DataSet ds, XmlReader ssync)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x281D750", Offset = "0x2819750", VA = "0x281D750")]
		internal void ProcessErrors(ArrayList dt, XmlReader ssync)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x281EAB8", Offset = "0x281AAB8", VA = "0x281EAB8")]
		private DataTable GetTable(string tableName, string ns)
		{
			return null;
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x281DC60", Offset = "0x2819C60", VA = "0x281DC60")]
		private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row)
		{
			return default(int);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x281DC00", Offset = "0x2819C00", VA = "0x281DC00")]
		internal void SkipWhitespaces(XmlReader reader)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x281EC84", Offset = "0x281AC84", VA = "0x281EC84")]
		public XMLDiffLoader()
		{
		}
	}
	[Token(Token = "0x2000092")]
	internal class XMLSchema
	{
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x281EC8C", Offset = "0x281AC8C", VA = "0x281EC8C")]
		internal static TypeConverter GetConverter(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x281B200", Offset = "0x2817200", VA = "0x281B200")]
		internal static void SetProperties(object instance, XmlAttributeCollection attrs)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2819064", Offset = "0x2815064", VA = "0x2819064")]
		internal static bool FEqualIdentity(XmlNode node, string name, string ns)
		{
			return default(bool);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x281ECE4", Offset = "0x281ACE4", VA = "0x281ECE4")]
		internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x281ADA4", Offset = "0x2816DA4", VA = "0x281ADA4")]
		internal static string GenUniqueColumnName(string proposedName, DataTable table)
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2818E50", Offset = "0x2814E50", VA = "0x2818E50")]
		public XMLSchema()
		{
		}
	}
	[Token(Token = "0x2000093")]
	internal sealed class ConstraintTable
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DataTable table;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XmlSchemaIdentityConstraint constraint;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x281EE34", Offset = "0x281AE34", VA = "0x281EE34")]
		public ConstraintTable(DataTable t, XmlSchemaIdentityConstraint c)
		{
		}
	}
	[Token(Token = "0x2000094")]
	internal sealed class XSDSchema : XMLSchema
	{
		[Token(Token = "0x2000095")]
		private sealed class NameType : IComparable
		{
			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string name;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly Type type;

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x282E354", Offset = "0x282A354", VA = "0x282E354")]
			public NameType(string n, Type t)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x282E380", Offset = "0x282A380", VA = "0x282E380", Slot = "4")]
			public int CompareTo(object obj)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private XmlSchemaSet _schemaSet;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private XmlSchemaElement _dsElement;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataSet _ds;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _schemaName;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ArrayList _columnExpressions;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Hashtable _constraintNodes;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ArrayList _refTables;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ArrayList _complexTypes;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private XmlSchemaObjectCollection _annotations;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private XmlSchemaObjectCollection _elements;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Hashtable _attributes;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Hashtable _elementsTable;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Hashtable _attributeGroups;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Hashtable _schemaTypes;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Hashtable _expressions;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<DataTable, List<DataTable>> _tableDictionary;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Hashtable _udSimpleTypes;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Hashtable _existingSimpleTypeMap;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _fromInference;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly NameType[] s_mapNameTypeXsd;

		[Token(Token = "0x1700011A")]
		internal bool FromInference
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x281EE60", Offset = "0x281AE60", VA = "0x281EE60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x281EE68", Offset = "0x281AE68", VA = "0x281EE68")]
			set
			{
			}
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x281EE70", Offset = "0x281AE70", VA = "0x281EE70")]
		private void CollectElementsAnnotations(XmlSchema schema)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x281EEF8", Offset = "0x281AEF8", VA = "0x281EEF8")]
		private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2817038", Offset = "0x2813038", VA = "0x2817038")]
		internal static string QualifiedName(string name)
		{
			return null;
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x281F7F4", Offset = "0x281B7F4", VA = "0x281F7F4")]
		internal static void SetProperties(object instance, XmlAttribute[] attrs)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x281FD58", Offset = "0x281BD58", VA = "0x281FD58")]
		private static void SetExtProperties(object instance, XmlAttribute[] attrs)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x28200E8", Offset = "0x281C0E8", VA = "0x28200E8")]
		private void HandleColumnExpression(object instance, XmlAttribute[] attrs)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2816DF0", Offset = "0x2812DF0", VA = "0x2816DF0")]
		internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x28202D4", Offset = "0x281C2D4", VA = "0x28202D4")]
		private static void SetExtProperties(object instance, XmlAttributeCollection attrs)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x2820518", Offset = "0x281C518", VA = "0x2820518")]
		internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x28206D4", Offset = "0x281C6D4", VA = "0x28206D4")]
		internal void HandleRelation(XmlElement node, bool fNested)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x2820F20", Offset = "0x281CF20", VA = "0x2820F20")]
		private bool HasAttributes(XmlSchemaObjectCollection attributes)
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2821160", Offset = "0x281D160", VA = "0x2821160")]
		private bool IsDatasetParticle(XmlSchemaParticle pt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2821B10", Offset = "0x281DB10", VA = "0x2821B10")]
		private int DatasetElementCount(XmlSchemaObjectCollection elements)
		{
			return default(int);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2821E78", Offset = "0x281DE78", VA = "0x2821E78")]
		private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x2822428", Offset = "0x281E428", VA = "0x2822428")]
		public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2822444", Offset = "0x281E444", VA = "0x2822444")]
		public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x2825758", Offset = "0x2821758", VA = "0x2825758")]
		private void HandleRelations(XmlSchemaAnnotation ann, bool fNested)
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2821684", Offset = "0x281D684", VA = "0x2821684")]
		internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt)
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x2825A3C", Offset = "0x2821A3C", VA = "0x2825A3C")]
		internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2826FA8", Offset = "0x2822FA8", VA = "0x2826FA8")]
		internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x2827C30", Offset = "0x2823C30", VA = "0x2827C30")]
		private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x2827FB4", Offset = "0x2823FB4", VA = "0x2827FB4")]
		internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable)
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x2822308", Offset = "0x281E308", VA = "0x2822308")]
		internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x28296E8", Offset = "0x28256E8", VA = "0x28296E8")]
		internal DataColumn FindField(DataTable table, string field)
		{
			return null;
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2829864", Offset = "0x2825864", VA = "0x2829864")]
		internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table)
		{
			return null;
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x2821D20", Offset = "0x281DD20", VA = "0x2821D20")]
		internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x282410C", Offset = "0x282010C", VA = "0x282410C")]
		internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal)
		{
			return null;
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x2829B08", Offset = "0x2825B08", VA = "0x2829B08")]
		internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule)
		{
			return default(AcceptRejectRule);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x2829B8C", Offset = "0x2825B8C", VA = "0x2829B8C")]
		internal static Rule TranslateRule(string strRule)
		{
			return default(Rule);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x2829C78", Offset = "0x2825C78", VA = "0x2829C78")]
		internal void HandleKeyref(XmlSchemaKeyref keyref)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x282A508", Offset = "0x2826508", VA = "0x282A508")]
		internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x282A938", Offset = "0x2826938", VA = "0x282A938")]
		internal DataTable InstantiateSimpleTable(XmlSchemaElement node)
		{
			return null;
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x28205FC", Offset = "0x281C5FC", VA = "0x28205FC")]
		internal string GetInstanceName(XmlSchemaAnnotated node)
		{
			return null;
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x282B3F0", Offset = "0x28273F0", VA = "0x282B3F0")]
		internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef)
		{
			return null;
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x282C940", Offset = "0x2828940", VA = "0x282C940")]
		public static Type XsdtoClr(string xsdTypeName)
		{
			return null;
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x282CA1C", Offset = "0x2828A1C", VA = "0x282CA1C")]
		private static NameType FindNameType(string name)
		{
			return null;
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x282CAF0", Offset = "0x2828AF0", VA = "0x282CAF0")]
		private Type ParseDataType(string dt)
		{
			return null;
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x282CC54", Offset = "0x2828C54", VA = "0x282CC54")]
		internal static bool IsXsdType(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x282418C", Offset = "0x282018C", VA = "0x282418C")]
		internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node)
		{
			return null;
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x2828D3C", Offset = "0x2824D3C", VA = "0x2828D3C")]
		internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x28285A0", Offset = "0x28245A0", VA = "0x28285A0")]
		internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2827260", Offset = "0x2823260", VA = "0x2827260")]
		internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x2826334", Offset = "0x2822334", VA = "0x2826334")]
		internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x28245E8", Offset = "0x28205E8", VA = "0x28245E8")]
		internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x282CCC4", Offset = "0x2828CC4", VA = "0x282CCC4")]
		private void AddTablesToList(List<DataTable> tableList, DataTable dt)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x282B00C", Offset = "0x282700C", VA = "0x282B00C")]
		private string GetPrefix(string ns)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x282CEBC", Offset = "0x2828EBC", VA = "0x282CEBC")]
		private string GetNamespaceFromPrefix(string prefix)
		{
			return null;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x282C7B0", Offset = "0x28287B0", VA = "0x282C7B0")]
		private string GetTableNamespace(XmlSchemaIdentityConstraint key)
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x282A3F0", Offset = "0x28263F0", VA = "0x282A3F0")]
		private string GetTableName(XmlSchemaIdentityConstraint key)
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x28218A4", Offset = "0x281D8A4", VA = "0x28218A4")]
		internal bool IsTable(XmlSchemaElement node)
		{
			return default(bool);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x2824470", Offset = "0x2820470", VA = "0x2824470")]
		internal DataTable HandleTable(XmlSchemaElement node)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x282D2A8", Offset = "0x28292A8", VA = "0x282D2A8")]
		public XSDSchema()
		{
		}
	}
	[Token(Token = "0x2000096")]
	internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader
	{
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> _namespacesToIgnore;

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x282E3F0", Offset = "0x282A3F0", VA = "0x282E3F0")]
		internal XmlIgnoreNamespaceReader(XmlDocument xdoc, string[] namespacesToIgnore)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x282E488", Offset = "0x282A488", VA = "0x282E488", Slot = "27")]
		public override bool MoveToFirstAttribute()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x282E598", Offset = "0x282A598", VA = "0x282E598", Slot = "28")]
		public override bool MoveToNextAttribute()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000097")]
	internal sealed class XmlDataLoader
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DataSet _dataSet;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private XmlToDatasetMap _nodeToSchemaMap;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Hashtable _nodeToRowMap;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Stack _childRowsStack;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Hashtable _htableExcludedNS;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _fIsXdr;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		internal bool _isDiffgram;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private XmlElement _topMostNode;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _ignoreSchema;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DataTable _dataTable;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isTableLevel;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool _fromInference;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private XmlReader _dataReader;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private object _XSD_XMLNS_NS;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private object _XDR_SCHEMA;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object _XDRNS;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private object _SQL_SYNC;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private object _UPDGNS;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private object _XSD_SCHEMA;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private object _XSDNS;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private object _DFFNS;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private object _MSDNS;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private object _DIFFID;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private object _HASCHANGES;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private object _ROWORDER;

		[Token(Token = "0x1700011B")]
		internal bool FromInference
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x282E98C", Offset = "0x282A98C", VA = "0x282E98C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x282E994", Offset = "0x282A994", VA = "0x282E994")]
			set
			{
			}
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x282E6A4", Offset = "0x282A6A4", VA = "0x282E6A4")]
		internal XmlDataLoader(DataSet dataset, bool IsXdr, bool ignoreSchema)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x282E738", Offset = "0x282A738", VA = "0x282E738")]
		internal XmlDataLoader(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x282E80C", Offset = "0x282A80C", VA = "0x282E80C")]
		internal XmlDataLoader(DataTable datatable, bool IsXdr, bool ignoreSchema)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x282E8AC", Offset = "0x282A8AC", VA = "0x282E8AC")]
		internal XmlDataLoader(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x282E99C", Offset = "0x282A99C", VA = "0x282E99C")]
		private void AttachRows(DataRow parentRow, XmlNode parentElement)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x282EB90", Offset = "0x282AB90", VA = "0x282EB90")]
		private int CountNonNSAttributes(XmlNode node)
		{
			return default(int);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x282ED10", Offset = "0x282AD10", VA = "0x282ED10")]
		private string GetValueForTextOnlyColums(XmlNode n)
		{
			return null;
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x282EF34", Offset = "0x282AF34", VA = "0x282EF34")]
		private string GetInitialTextFromNodes(ref XmlNode n)
		{
			return null;
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x282F110", Offset = "0x282B110", VA = "0x282F110")]
		private DataColumn GetTextOnlyColumn(DataRow row)
		{
			return null;
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x282EAF8", Offset = "0x282AAF8", VA = "0x282EAF8")]
		internal DataRow GetRowFromElement(XmlElement e)
		{
			return null;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x282F1D4", Offset = "0x282B1D4", VA = "0x282F1D4")]
		internal bool FColumnElement(XmlElement e)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x282EC84", Offset = "0x282AC84", VA = "0x282EC84")]
		private bool FExcludedNamespace(string ns)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x282F2BC", Offset = "0x282B2BC", VA = "0x282F2BC")]
		private bool FIgnoreNamespace(XmlNode node)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x282F57C", Offset = "0x282B57C", VA = "0x282F57C")]
		private bool FIgnoreNamespace(XmlReader node)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x282EEE0", Offset = "0x282AEE0", VA = "0x282EEE0")]
		internal bool IsTextLikeNode(XmlNodeType n)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x282F1A4", Offset = "0x282B1A4", VA = "0x282F1A4")]
		internal bool IsTextOnly(DataColumn c)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x282F604", Offset = "0x282B604", VA = "0x282F604")]
		internal void LoadData(XmlDocument xdoc)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x282FA38", Offset = "0x282BA38", VA = "0x282FA38")]
		private void LoadRowData(DataRow row, XmlElement rowElement)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x2830604", Offset = "0x282C604", VA = "0x2830604")]
		private void LoadRows(DataRow parentRow, XmlNode parentElement)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2830940", Offset = "0x282C940", VA = "0x2830940")]
		private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x28309B0", Offset = "0x282C9B0", VA = "0x28309B0")]
		private void InitNameTable()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x2830C2C", Offset = "0x282CC2C", VA = "0x2830C2C")]
		internal void LoadData(XmlReader reader)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2830FC4", Offset = "0x282CFC4", VA = "0x2830FC4")]
		private void LoadTopMostTable(DataTable table)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2831B88", Offset = "0x282DB88", VA = "0x2831B88")]
		private void LoadTable(DataTable table, bool isNested)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x28329B8", Offset = "0x282E9B8", VA = "0x28329B8")]
		private void LoadColumn(DataColumn column, object[] foundColumns)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2831974", Offset = "0x282D974", VA = "0x2831974")]
		private bool ProcessXsdSchema()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000098")]
	public enum XmlReadMode
	{
		[Token(Token = "0x400030B")]
		Auto,
		[Token(Token = "0x400030C")]
		ReadSchema,
		[Token(Token = "0x400030D")]
		IgnoreSchema,
		[Token(Token = "0x400030E")]
		InferSchema,
		[Token(Token = "0x400030F")]
		DiffGram,
		[Token(Token = "0x4000310")]
		Fragment,
		[Token(Token = "0x4000311")]
		InferTypedSchema
	}
	[Token(Token = "0x2000099")]
	internal sealed class XmlToDatasetMap
	{
		[Token(Token = "0x200009A")]
		private sealed class XmlNodeIdentety
		{
			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string LocalName;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string NamespaceURI;

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x28351F4", Offset = "0x28311F4", VA = "0x28351F4")]
			public XmlNodeIdentety(string localName, string namespaceURI)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x2835E4C", Offset = "0x2831E4C", VA = "0x2835E4C", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x2835E68", Offset = "0x2831E68", VA = "0x2835E68", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009B")]
		internal sealed class XmlNodeIdHashtable : Hashtable
		{
			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private XmlNodeIdentety _id;

			[Token(Token = "0x1700011C")]
			public object this[XmlNode node]
			{
				[Token(Token = "0x60007D8")]
				[Address(RVA = "0x2835C84", Offset = "0x2831C84", VA = "0x2835C84")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011D")]
			public object this[XmlReader dataReader]
			{
				[Token(Token = "0x60007D9")]
				[Address(RVA = "0x2835DDC", Offset = "0x2831DDC", VA = "0x2835DDC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011E")]
			public object this[DataTable table]
			{
				[Token(Token = "0x60007DA")]
				[Address(RVA = "0x2835D6C", Offset = "0x2831D6C", VA = "0x2835D6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011F")]
			public object this[string name]
			{
				[Token(Token = "0x60007DB")]
				[Address(RVA = "0x2835CFC", Offset = "0x2831CFC", VA = "0x2835CFC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x28357C8", Offset = "0x28317C8", VA = "0x28357C8")]
			public XmlNodeIdHashtable(int capacity)
			{
			}
		}

		[Token(Token = "0x200009C")]
		private sealed class TableSchemaInfo
		{
			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DataTable TableSchema;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public XmlNodeIdHashtable ColumnsSchemaMap;

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x2835164", Offset = "0x2831164", VA = "0x2835164")]
			public TableSchemaInfo(DataTable tableSchema)
			{
			}
		}

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private XmlNodeIdHashtable _tableSchemaMap;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TableSchemaInfo _lastTableSchemaInfo;

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x282F91C", Offset = "0x282B91C", VA = "0x282F91C")]
		public XmlToDatasetMap(DataSet dataSet, XmlNameTable nameTable)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2830F5C", Offset = "0x282CF5C", VA = "0x2830F5C")]
		public XmlToDatasetMap(XmlNameTable nameTable, DataSet dataSet)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x282F8E8", Offset = "0x282B8E8", VA = "0x282F8E8")]
		public XmlToDatasetMap(DataTable dataTable, XmlNameTable nameTable)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2830F90", Offset = "0x282CF90", VA = "0x2830F90")]
		public XmlToDatasetMap(XmlNameTable nameTable, DataTable dataTable)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2830988", Offset = "0x282C988", VA = "0x2830988")]
		internal static bool IsMappedColumn(DataColumn c)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2835044", Offset = "0x2831044", VA = "0x2835044")]
		private TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable)
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x2835220", Offset = "0x2831220", VA = "0x2835220")]
		private TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table)
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x2835390", Offset = "0x2831390", VA = "0x2835390")]
		private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x283561C", Offset = "0x283161C", VA = "0x283561C")]
		private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x28332FC", Offset = "0x282F2FC", VA = "0x28332FC")]
		private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x28338A4", Offset = "0x282F8A4", VA = "0x28338A4")]
		private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x28342FC", Offset = "0x28302FC", VA = "0x28342FC")]
		private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x2834624", Offset = "0x2830624", VA = "0x2834624")]
		private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x283585C", Offset = "0x283185C", VA = "0x283585C")]
		private ArrayList GetSelfAndDescendants(DataTable dt)
		{
			return null;
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x282F39C", Offset = "0x282B39C", VA = "0x282F39C")]
		public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace)
		{
			return null;
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x283289C", Offset = "0x282E89C", VA = "0x283289C")]
		public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace)
		{
			return null;
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x282F950", Offset = "0x282B950", VA = "0x282F950")]
		public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x28318B4", Offset = "0x282D8B4", VA = "0x28318B4")]
		public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace)
		{
			return null;
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x28354C0", Offset = "0x28314C0", VA = "0x28354C0")]
		private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public enum XmlWriteMode
	{
		[Token(Token = "0x400031A")]
		WriteSchema,
		[Token(Token = "0x400031B")]
		IgnoreSchema,
		[Token(Token = "0x400031C")]
		DiffGram
	}
	[Token(Token = "0x200009E")]
	internal enum SchemaFormat
	{
		[Token(Token = "0x400031E")]
		Public = 1,
		[Token(Token = "0x400031F")]
		Remoting,
		[Token(Token = "0x4000320")]
		WebService,
		[Token(Token = "0x4000321")]
		RemotingSkipSchema,
		[Token(Token = "0x4000322")]
		WebServiceSkipSchema
	}
	[Token(Token = "0x200009F")]
	internal sealed class XmlTreeGen
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ArrayList _constraintNames;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Hashtable _namespaces;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Hashtable _autogenerated;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Hashtable _prefixes;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DataSet _ds;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ArrayList _tables;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ArrayList _relations;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private XmlDocument _dc;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private XmlElement _sRoot;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _prefixCount;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private SchemaFormat _schFormat;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _filePath;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _fileName;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _fileExt;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private XmlElement _dsElement;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private XmlElement _constraintSeparator;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Converter<Type, string> _targetConverter;

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x2835F04", Offset = "0x2831F04", VA = "0x2835F04")]
		internal XmlTreeGen(SchemaFormat format)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x2835F98", Offset = "0x2831F98", VA = "0x2835F98")]
		internal static void AddExtendedProperties(PropertyCollection props, XmlElement node)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x2835FA0", Offset = "0x2831FA0", VA = "0x2835FA0")]
		internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x28366BC", Offset = "0x28326BC", VA = "0x28366BC")]
		internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x283686C", Offset = "0x283286C", VA = "0x283686C")]
		internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x2837174", Offset = "0x2833174", VA = "0x2837174")]
		internal static string XmlDataTypeName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x283803C", Offset = "0x283403C", VA = "0x283803C")]
		private void GenerateConstraintNames(DataTable table, bool fromTable)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x2838500", Offset = "0x2834500", VA = "0x2838500")]
		private void GenerateConstraintNames(ArrayList tables)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x28385F8", Offset = "0x28345F8", VA = "0x28385F8")]
		private void GenerateConstraintNames(DataSet ds)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x28388A4", Offset = "0x28348A4", VA = "0x28388A4")]
		private static bool _PropsNotEmpty(PropertyCollection props)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x28388CC", Offset = "0x28348CC", VA = "0x28388CC")]
		private bool HaveExtendedProperties(DataSet ds)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x2838A50", Offset = "0x2834A50", VA = "0x2838A50")]
		internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x2838CB4", Offset = "0x2834CB4", VA = "0x2838CB4")]
		internal static void ValidateColumnMapping(Type columnType)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x2838D3C", Offset = "0x2834D3C", VA = "0x2838D3C")]
		internal void SetupAutoGenerated(DataSet ds)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x28399B4", Offset = "0x28359B4", VA = "0x28399B4")]
		internal void SetupAutoGenerated(ArrayList dt)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x2838FE4", Offset = "0x2834FE4", VA = "0x2838FE4")]
		internal void SetupAutoGenerated(DataTable dt)
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x283A0B8", Offset = "0x28360B8", VA = "0x283A0B8")]
		private void CreateTablesHierarchy(DataTable dt)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x283A404", Offset = "0x2836404", VA = "0x283A404")]
		private void CreateRelations(DataTable dt)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x283A72C", Offset = "0x283672C", VA = "0x283A72C")]
		private DataTable[] CreateToplevelTables()
		{
			return null;
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x283AA1C", Offset = "0x2836A1C", VA = "0x283AA1C")]
		internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x283DF94", Offset = "0x2839F94", VA = "0x283DF94")]
		internal XmlElement SchemaTree(XmlDocument xd, DataTable dt)
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x283D2F0", Offset = "0x28392F0", VA = "0x283D2F0")]
		internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt)
		{
			return null;
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x2840D14", Offset = "0x283CD14", VA = "0x2840D14")]
		internal void SetPath(XmlWriter xw)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2840F18", Offset = "0x283CF18", VA = "0x2840F18")]
		internal void Save(DataSet ds, XmlWriter xw)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2840F38", Offset = "0x283CF38", VA = "0x2840F38")]
		internal void Save(DataTable dt, XmlWriter xw)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x2840F2C", Offset = "0x283CF2C", VA = "0x2840F2C")]
		internal void Save(DataSet ds, DataTable dt, XmlWriter xw)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x2840FF8", Offset = "0x283CFF8", VA = "0x2840FF8")]
		internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x2841000", Offset = "0x283D000", VA = "0x2841000")]
		internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<Type, string> multipleTargetConverter)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x283D9D0", Offset = "0x28399D0", VA = "0x283D9D0")]
		internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc)
		{
			return null;
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x2841150", Offset = "0x283D150", VA = "0x2841150")]
		private static XmlElement FindSimpleType(XmlElement schema, string name)
		{
			return null;
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x2841244", Offset = "0x283D244", VA = "0x2841244")]
		internal XmlElement GetSchema(string NamespaceURI)
		{
			return null;
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x28414D8", Offset = "0x283D4D8", VA = "0x28414D8")]
		internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x2841954", Offset = "0x283D954", VA = "0x2841954")]
		internal void AddColumnProperties(DataColumn col, XmlElement root)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2841F60", Offset = "0x283DF60", VA = "0x2841F60")]
		private string FindTargetNamespace(DataTable table)
		{
			return null;
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x2842070", Offset = "0x283E070", VA = "0x2842070")]
		internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal)
		{
			return null;
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x2842D30", Offset = "0x283ED30", VA = "0x2842D30")]
		internal static string TranslateAcceptRejectRule(AcceptRejectRule rule)
		{
			return null;
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x2842DA0", Offset = "0x283EDA0", VA = "0x2842DA0")]
		internal static string TranslateRule(Rule rule)
		{
			return null;
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x283D918", Offset = "0x2839918", VA = "0x283D918")]
		internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x2842B68", Offset = "0x283EB68", VA = "0x2842B68")]
		internal XmlElement FindTypeNode(XmlElement node, string strType)
		{
			return null;
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x283D910", Offset = "0x2839910", VA = "0x283D910")]
		internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema)
		{
			return null;
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x2842E54", Offset = "0x283EE54", VA = "0x2842E54")]
		private bool HasMixedColumns(DataTable table)
		{
			return default(bool);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x2839AA8", Offset = "0x2835AA8", VA = "0x2839AA8")]
		internal static bool AutoGenerated(DataColumn col)
		{
			return default(bool);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x28431C4", Offset = "0x283F1C4", VA = "0x28431C4")]
		internal static bool AutoGenerated(DataRelation rel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x2839FE4", Offset = "0x2835FE4", VA = "0x2839FE4")]
		internal static bool AutoGenerated(UniqueConstraint unique)
		{
			return default(bool);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x2839FD8", Offset = "0x2835FD8", VA = "0x2839FD8")]
		private bool AutoGenerated(ForeignKeyConstraint fk)
		{
			return default(bool);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x28432A8", Offset = "0x283F2A8", VA = "0x28432A8")]
		internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation)
		{
			return default(bool);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x28433E8", Offset = "0x283F3E8", VA = "0x28433E8")]
		private bool IsAutoGenerated(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x283E3E4", Offset = "0x283A3E4", VA = "0x283E3E4")]
		internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested)
		{
			return null;
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x2837E58", Offset = "0x2833E58", VA = "0x2837E58")]
		private void SetMSDataAttribute(XmlElement root, Type type)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	internal sealed class NewDiffgramGen
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XmlDocument _doc;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal DataSet _ds;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal DataTable _dt;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal XmlWriter _xmlw;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _fBefore;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _fErrors;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Hashtable _rowsOrder;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ArrayList _tables;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _writeHierarchy;

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x2843494", Offset = "0x283F494", VA = "0x2843494")]
		internal NewDiffgramGen(DataSet ds)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x2843808", Offset = "0x283F808", VA = "0x2843808")]
		internal NewDiffgramGen(DataTable dt, bool writeHierarchy)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x28438F4", Offset = "0x283F8F4", VA = "0x28438F4")]
		private void CreateTableHierarchy(DataTable dt)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x28435A4", Offset = "0x283F5A4", VA = "0x28435A4")]
		private void DoAssignments(ArrayList tables)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x2843C40", Offset = "0x283FC40", VA = "0x2843C40")]
		private bool EmptyData()
		{
			return default(bool);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x2843D34", Offset = "0x283FD34", VA = "0x2843D34")]
		internal void Save(XmlWriter xmlw)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x2843D3C", Offset = "0x283FD3C", VA = "0x2843D3C")]
		internal void Save(XmlWriter xmlw, DataTable table)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x2844134", Offset = "0x2840134", VA = "0x2844134")]
		private void GenerateTable(DataTable table)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x28441B0", Offset = "0x28401B0", VA = "0x28441B0")]
		private void GenerateTableErrors(DataTable table)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x2844724", Offset = "0x2840724", VA = "0x2844724")]
		private void GenerateRow(DataRow row)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x2844CC4", Offset = "0x2840CC4", VA = "0x2844CC4")]
		private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x284342C", Offset = "0x283F42C", VA = "0x284342C")]
		internal static string QualifiedName(string prefix, string name)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A1")]
	internal sealed class XmlDataTreeWriter
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private XmlWriter _xmlw;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DataSet _ds;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataTable _dt;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ArrayList _dTables;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DataTable[] _topLevelTables;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _fFromTable;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isDiffgram;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Hashtable _rowsOrder;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _writeHierarchy;

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x28456CC", Offset = "0x28416CC", VA = "0x28456CC")]
		internal XmlDataTreeWriter(DataSet ds)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x28459DC", Offset = "0x28419DC", VA = "0x28459DC")]
		internal XmlDataTreeWriter(DataTable dt, bool writeHierarchy)
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x2845E78", Offset = "0x2841E78", VA = "0x2845E78")]
		private DataTable[] CreateToplevelTables()
		{
			return null;
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x2845B2C", Offset = "0x2841B2C", VA = "0x2845B2C")]
		private void CreateTablesHierarchy(DataTable dt)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x2846168", Offset = "0x2842168", VA = "0x2846168")]
		internal static bool RowHasErrors(DataRow row)
		{
			return default(bool);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x2846230", Offset = "0x2842230", VA = "0x2846230")]
		internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x2848104", Offset = "0x2844104", VA = "0x2848104")]
		internal void Save(XmlWriter xw, bool writeSchema)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2848960", Offset = "0x2844960", VA = "0x2848960")]
		private ArrayList GetNestedChildRelations(DataRow row)
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x28468F8", Offset = "0x28428F8", VA = "0x28468F8")]
		internal void XmlDataRowWriter(DataRow row, string encodedTableName)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x2848C74", Offset = "0x2844C74", VA = "0x2848C74")]
		internal static bool PreserveSpace(object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A2")]
	internal sealed class DataTextWriter : XmlWriter
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private XmlWriter _xmltextWriter;

		[Token(Token = "0x17000120")]
		internal Stream BaseStream
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x2848D58", Offset = "0x2844D58", VA = "0x2848D58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		public override WriteState WriteState
		{
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x2849084", Offset = "0x2845084", VA = "0x2849084", Slot = "27")]
			get
			{
				return default(WriteState);
			}
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x284689C", Offset = "0x284289C", VA = "0x284689C")]
		internal static XmlWriter CreateWriter(XmlWriter xw)
		{
			return null;
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x2848D30", Offset = "0x2844D30", VA = "0x2848D30")]
		private DataTextWriter(XmlWriter w)
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x2848DE0", Offset = "0x2844DE0", VA = "0x2848DE0", Slot = "5")]
		public override void WriteStartDocument()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2848DFC", Offset = "0x2844DFC", VA = "0x2848DFC", Slot = "6")]
		public override void WriteStartDocument(bool standalone)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x2848E1C", Offset = "0x2844E1C", VA = "0x2848E1C", Slot = "7")]
		public override void WriteEndDocument()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x2848E38", Offset = "0x2844E38", VA = "0x2848E38", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2848E54", Offset = "0x2844E54", VA = "0x2848E54", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x2848E70", Offset = "0x2844E70", VA = "0x2848E70", Slot = "10")]
		public override void WriteEndElement()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2848E8C", Offset = "0x2844E8C", VA = "0x2848E8C", Slot = "11")]
		public override void WriteFullEndElement()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x2848EA8", Offset = "0x2844EA8", VA = "0x2848EA8", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x2848EC4", Offset = "0x2844EC4", VA = "0x2848EC4", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x2848EE4", Offset = "0x2844EE4", VA = "0x2848EE4", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2848F04", Offset = "0x2844F04", VA = "0x2848F04", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2848F24", Offset = "0x2844F24", VA = "0x2848F24", Slot = "16")]
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x2848F44", Offset = "0x2844F44", VA = "0x2848F44", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2848F64", Offset = "0x2844F64", VA = "0x2848F64", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x2848F84", Offset = "0x2844F84", VA = "0x2848F84", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x2848FA4", Offset = "0x2844FA4", VA = "0x2848FA4", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x2848FC4", Offset = "0x2844FC4", VA = "0x2848FC4", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x2848FE4", Offset = "0x2844FE4", VA = "0x2848FE4", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x2849004", Offset = "0x2845004", VA = "0x2849004", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x2849024", Offset = "0x2845024", VA = "0x2849024", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x2849044", Offset = "0x2845044", VA = "0x2849044", Slot = "25")]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x2849064", Offset = "0x2845064", VA = "0x2849064", Slot = "26")]
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x28490A4", Offset = "0x28450A4", VA = "0x28490A4", Slot = "28")]
		public override void Close()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x28490C4", Offset = "0x28450C4", VA = "0x28490C4", Slot = "29")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x28490E4", Offset = "0x28450E4", VA = "0x28490E4", Slot = "30")]
		public override string LookupPrefix(string ns)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A3")]
	internal sealed class DataTextReader : XmlReader
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private XmlReader _xmlreader;

		[Token(Token = "0x17000122")]
		public override XmlReaderSettings Settings
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x28491C8", Offset = "0x28451C8", VA = "0x28491C8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000123")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x28491E4", Offset = "0x28451E4", VA = "0x28491E4", Slot = "6")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x17000124")]
		public override string Name
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x2849200", Offset = "0x2845200", VA = "0x2849200", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000125")]
		public override string LocalName
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x284921C", Offset = "0x284521C", VA = "0x284921C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		public override string NamespaceURI
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x2849238", Offset = "0x2845238", VA = "0x2849238", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000127")]
		public override string Prefix
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x2849254", Offset = "0x2845254", VA = "0x2849254", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		public override string Value
		{
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x2849270", Offset = "0x2845270", VA = "0x2849270", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000129")]
		public override int Depth
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x284928C", Offset = "0x284528C", VA = "0x284928C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012A")]
		public override string BaseURI
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x28492A8", Offset = "0x28452A8", VA = "0x28492A8", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012B")]
		public override bool IsEmptyElement
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x28492C8", Offset = "0x28452C8", VA = "0x28492C8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012C")]
		public override bool IsDefault
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x28492E8", Offset = "0x28452E8", VA = "0x28492E8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012D")]
		public override char QuoteChar
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x2849308", Offset = "0x2845308", VA = "0x2849308", Slot = "16")]
			get
			{
				return default(char);
			}
		}

		[Token(Token = "0x1700012E")]
		public override XmlSpace XmlSpace
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x2849328", Offset = "0x2845328", VA = "0x2849328", Slot = "17")]
			get
			{
				return default(XmlSpace);
			}
		}

		[Token(Token = "0x1700012F")]
		public override string XmlLang
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x2849348", Offset = "0x2845348", VA = "0x2849348", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000130")]
		public override int AttributeCount
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x2849368", Offset = "0x2845368", VA = "0x2849368", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000131")]
		public override bool EOF
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x28494C8", Offset = "0x28454C8", VA = "0x28494C8", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000132")]
		public override ReadState ReadState
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x2849508", Offset = "0x2845508", VA = "0x2849508", Slot = "34")]
			get
			{
				return default(ReadState);
			}
		}

		[Token(Token = "0x17000133")]
		public override XmlNameTable NameTable
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x2849548", Offset = "0x2845548", VA = "0x2849548", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		public override bool CanResolveEntity
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x2849588", Offset = "0x2845588", VA = "0x2849588", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000135")]
		public override bool CanReadValueChunk
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x28495C8", Offset = "0x28455C8", VA = "0x28495C8", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x2849104", Offset = "0x2845104", VA = "0x2849104")]
		internal static XmlReader CreateReader(XmlReader xr)
		{
			return null;
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x284915C", Offset = "0x284515C", VA = "0x284915C")]
		private DataTextReader(XmlReader input)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x2849388", Offset = "0x2845388", VA = "0x2849388", Slot = "22")]
		public override string GetAttribute(string name)
		{
			return null;
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x28493A8", Offset = "0x28453A8", VA = "0x28493A8", Slot = "23")]
		public override string GetAttribute(string localName, string namespaceURI)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x28493C8", Offset = "0x28453C8", VA = "0x28493C8", Slot = "24")]
		public override string GetAttribute(int i)
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x28493E8", Offset = "0x28453E8", VA = "0x28493E8", Slot = "25")]
		public override bool MoveToAttribute(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x2849408", Offset = "0x2845408", VA = "0x2849408", Slot = "26")]
		public override void MoveToAttribute(int i)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x2849428", Offset = "0x2845428", VA = "0x2849428", Slot = "27")]
		public override bool MoveToFirstAttribute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x2849448", Offset = "0x2845448", VA = "0x2849448", Slot = "28")]
		public override bool MoveToNextAttribute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x2849468", Offset = "0x2845468", VA = "0x2849468", Slot = "29")]
		public override bool MoveToElement()
		{
			return default(bool);
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x2849488", Offset = "0x2845488", VA = "0x2849488", Slot = "30")]
		public override bool ReadAttributeValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x28494A8", Offset = "0x28454A8", VA = "0x28494A8", Slot = "31")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x28494E8", Offset = "0x28454E8", VA = "0x28494E8", Slot = "33")]
		public override void Close()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x2849528", Offset = "0x2845528", VA = "0x2849528", Slot = "35")]
		public override void Skip()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x2849568", Offset = "0x2845568", VA = "0x2849568", Slot = "37")]
		public override string LookupNamespace(string prefix)
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x28495A8", Offset = "0x28455A8", VA = "0x28495A8", Slot = "39")]
		public override void ResolveEntity()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x28495E8", Offset = "0x28455E8", VA = "0x28495E8", Slot = "42")]
		public override string ReadString()
		{
			return null;
		}
	}
}
namespace System.Data.SqlTypes
{
	[Token(Token = "0x20000A4")]
	internal static class SQLResource
	{
		[Token(Token = "0x17000136")]
		internal static string NullString
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x2849608", Offset = "0x2845608", VA = "0x2849608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000137")]
		internal static string ArithOverflowMessage
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x2849648", Offset = "0x2845648", VA = "0x2849648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		internal static string DivideByZeroMessage
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x2849688", Offset = "0x2845688", VA = "0x2849688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000139")]
		internal static string NullValueMessage
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x28496C8", Offset = "0x28456C8", VA = "0x28496C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013A")]
		internal static string TruncationMessage
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x2849708", Offset = "0x2845708", VA = "0x2849708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013B")]
		internal static string DateTimeOverflowMessage
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x2849748", Offset = "0x2845748", VA = "0x2849748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013C")]
		internal static string ConcatDiffCollationMessage
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x2849788", Offset = "0x2845788", VA = "0x2849788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013D")]
		internal static string CompareDiffCollationMessage
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x28497C8", Offset = "0x28457C8", VA = "0x28497C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013E")]
		internal static string ConversionOverflowMessage
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x2849808", Offset = "0x2845808", VA = "0x2849808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013F")]
		internal static string TimeZoneSpecifiedMessage
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x2849848", Offset = "0x2845848", VA = "0x2849848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000140")]
		internal static string InvalidPrecScaleMessage
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x2849888", Offset = "0x2845888", VA = "0x2849888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000141")]
		internal static string FormatMessage
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x28498C8", Offset = "0x28458C8", VA = "0x28498C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2849908", Offset = "0x2845908", VA = "0x2849908")]
		internal static string InvalidOpStreamClosed(string method)
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2849954", Offset = "0x2845954", VA = "0x2849954")]
		internal static string InvalidOpStreamNonWritable(string method)
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x28499A0", Offset = "0x28459A0", VA = "0x28499A0")]
		internal static string InvalidOpStreamNonReadable(string method)
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x28499EC", Offset = "0x28459EC", VA = "0x28499EC")]
		internal static string InvalidOpStreamNonSeekable(string method)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A5")]
	public interface INullable
	{
		[Token(Token = "0x17000142")]
		bool IsNull
		{
			[Token(Token = "0x6000876")]
			get;
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	[DefaultMember("Item")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlBinary : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte[] _value;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SqlBinary Null;

		[Token(Token = "0x17000143")]
		public bool IsNull
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x2849AB8", Offset = "0x2845AB8", VA = "0x2849AB8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000144")]
		public byte[] Value
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x2849AC8", Offset = "0x2845AC8", VA = "0x2849AC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x2849A38", Offset = "0x2845A38", VA = "0x2849A38")]
		private SqlBinary(bool fNull)
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x2849A40", Offset = "0x2845A40", VA = "0x2849A40")]
		public SqlBinary(byte[] value)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x2849B9C", Offset = "0x2845B9C", VA = "0x2849B9C")]
		public static implicit operator SqlBinary(byte[] x)
		{
			return default(SqlBinary);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x2849BB8", Offset = "0x2845BB8", VA = "0x2849BB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2849CCC", Offset = "0x2845CCC", VA = "0x2849CCC")]
		private static EComparison PerformCompareByte(byte[] x, byte[] y)
		{
			return default(EComparison);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x2849DD8", Offset = "0x2845DD8", VA = "0x2849DD8")]
		public static SqlBoolean operator ==(SqlBinary x, SqlBinary y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x2849EE8", Offset = "0x2845EE8", VA = "0x2849EE8")]
		public static SqlBoolean operator <(SqlBinary x, SqlBinary y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x2849FE4", Offset = "0x2845FE4", VA = "0x2849FE4")]
		public static SqlBoolean operator >(SqlBinary x, SqlBinary y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x284A0E0", Offset = "0x28460E0", VA = "0x284A0E0", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x284A1E4", Offset = "0x28461E4", VA = "0x284A1E4")]
		public int CompareTo(SqlBinary value)
		{
			return default(int);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x284A37C", Offset = "0x284637C", VA = "0x284A37C", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x284A500", Offset = "0x2846500", VA = "0x284A500")]
		internal static int HashByteArray(byte[] rgbValue, int length)
		{
			return default(int);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x284A560", Offset = "0x2846560", VA = "0x284A560", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x284A628", Offset = "0x2846628", VA = "0x284A628", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x284A630", Offset = "0x2846630", VA = "0x284A630", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x284A7D8", Offset = "0x28467D8", VA = "0x284A7D8", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x284A904", Offset = "0x2846904", VA = "0x284A904")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlBoolean : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte m_value;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SqlBoolean True;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static readonly SqlBoolean False;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static readonly SqlBoolean Null;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public static readonly SqlBoolean Zero;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly SqlBoolean One;

		[Token(Token = "0x17000145")]
		public bool IsNull
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x284AA60", Offset = "0x2846A60", VA = "0x284AA60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000146")]
		public bool Value
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x284A4AC", Offset = "0x28464AC", VA = "0x284A4AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000147")]
		public bool IsTrue
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x284AA70", Offset = "0x2846A70", VA = "0x284AA70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000148")]
		public bool IsFalse
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x284AA80", Offset = "0x2846A80", VA = "0x284AA80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000149")]
		public byte ByteValue
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x284AC20", Offset = "0x2846C20", VA = "0x284AC20")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x2849ED4", Offset = "0x2845ED4", VA = "0x2849ED4")]
		public SqlBoolean(bool value)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x284A9D8", Offset = "0x28469D8", VA = "0x284A9D8")]
		public SqlBoolean(int value)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x284AA44", Offset = "0x2846A44", VA = "0x284AA44")]
		private SqlBoolean(int value, bool fNull)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x284AA90", Offset = "0x2846A90", VA = "0x284AA90")]
		public static implicit operator SqlBoolean(bool x)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x284A320", Offset = "0x2846320", VA = "0x284A320")]
		public static bool operator true(SqlBoolean x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x284AAA0", Offset = "0x2846AA0", VA = "0x284AAA0")]
		public static SqlBoolean operator &(SqlBoolean x, SqlBoolean y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x284AB60", Offset = "0x2846B60", VA = "0x284AB60")]
		public static SqlBoolean operator |(SqlBoolean x, SqlBoolean y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x284ACB4", Offset = "0x2846CB4", VA = "0x284ACB4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x284AD98", Offset = "0x2846D98", VA = "0x284AD98")]
		public static SqlBoolean operator ==(SqlBoolean x, SqlBoolean y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x284AE48", Offset = "0x2846E48", VA = "0x284AE48")]
		public static SqlBoolean And(SqlBoolean x, SqlBoolean y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x284AEAC", Offset = "0x2846EAC", VA = "0x284AEAC")]
		public static SqlBoolean Or(SqlBoolean x, SqlBoolean y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x284AF10", Offset = "0x2846F10", VA = "0x284AF10", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x284B014", Offset = "0x2847014", VA = "0x284B014")]
		public int CompareTo(SqlBoolean value)
		{
			return default(int);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x284B114", Offset = "0x2847114", VA = "0x284B114", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x284B21C", Offset = "0x284721C", VA = "0x284B21C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x284B2D8", Offset = "0x28472D8", VA = "0x284B2D8", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x284B2E0", Offset = "0x28472E0", VA = "0x284B2E0", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x284B404", Offset = "0x2847404", VA = "0x284B404", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x284B51C", Offset = "0x284751C", VA = "0x284B51C")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlByte : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_fNotNull;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private byte m_value;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int s_iBitNotByteMax;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly SqlByte Null;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public static readonly SqlByte Zero;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly SqlByte MinValue;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public static readonly SqlByte MaxValue;

		[Token(Token = "0x1700014A")]
		public bool IsNull
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x284B668", Offset = "0x2847668", VA = "0x284B668", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014B")]
		public byte Value
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x284B678", Offset = "0x2847678", VA = "0x284B678")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x284B650", Offset = "0x2847650", VA = "0x284B650")]
		private SqlByte(bool fNull)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x284B658", Offset = "0x2847658", VA = "0x284B658")]
		public SqlByte(byte value)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x284B6C0", Offset = "0x28476C0", VA = "0x284B6C0")]
		public static implicit operator SqlByte(byte x)
		{
			return default(SqlByte);
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x284B6CC", Offset = "0x28476CC", VA = "0x284B6CC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x284B768", Offset = "0x2847768", VA = "0x284B768")]
		public static SqlByte operator +(SqlByte x, SqlByte y)
		{
			return default(SqlByte);
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x284B880", Offset = "0x2847880", VA = "0x284B880")]
		public static SqlByte operator -(SqlByte x, SqlByte y)
		{
			return default(SqlByte);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x284B994", Offset = "0x2847994", VA = "0x284B994")]
		public static SqlByte operator *(SqlByte x, SqlByte y)
		{
			return default(SqlByte);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x284BAAC", Offset = "0x2847AAC", VA = "0x284BAAC")]
		public static SqlByte operator /(SqlByte x, SqlByte y)
		{
			return default(SqlByte);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x284BBA8", Offset = "0x2847BA8", VA = "0x284BBA8")]
		public static explicit operator SqlByte(SqlInt64 x)
		{
			return default(SqlByte);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x284BD4C", Offset = "0x2847D4C", VA = "0x284BD4C")]
		public static SqlBoolean operator ==(SqlByte x, SqlByte y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x284BE10", Offset = "0x2847E10", VA = "0x284BE10")]
		public static SqlBoolean operator <(SqlByte x, SqlByte y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x284BED4", Offset = "0x2847ED4", VA = "0x284BED4")]
		public static SqlBoolean operator >(SqlByte x, SqlByte y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x284BF98", Offset = "0x2847F98", VA = "0x284BF98")]
		public static SqlBoolean LessThan(SqlByte x, SqlByte y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x284BFFC", Offset = "0x2847FFC", VA = "0x284BFFC")]
		public static SqlBoolean GreaterThan(SqlByte x, SqlByte y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x284C060", Offset = "0x2848060", VA = "0x284C060")]
		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x284C184", Offset = "0x2848184", VA = "0x284C184")]
		public SqlInt64 ToSqlInt64()
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x284C298", Offset = "0x2848298", VA = "0x284C298", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x284C39C", Offset = "0x284839C", VA = "0x284C39C")]
		public int CompareTo(SqlByte value)
		{
			return default(int);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x284C4DC", Offset = "0x28484DC", VA = "0x284C4DC", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x284C610", Offset = "0x2848610", VA = "0x284C610", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x284C6A0", Offset = "0x28486A0", VA = "0x284C6A0", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x284C6A8", Offset = "0x28486A8", VA = "0x284C6A8", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x284C7C8", Offset = "0x28487C8", VA = "0x284C7C8", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x284C8F8", Offset = "0x28488F8", VA = "0x284C8F8")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	internal enum SqlBytesCharsState
	{
		[Token(Token = "0x4000358")]
		Null = 0,
		[Token(Token = "0x4000359")]
		Buffer = 1,
		[Token(Token = "0x400035A")]
		Stream = 3
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	[XmlSchemaProvider("GetXsdType")]
	[DefaultMember("Item")]
	public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal byte[] _rgbBuf;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long _lCurLen;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Stream _stream;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SqlBytesCharsState _state;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] _rgbWorkBuf;

		[Token(Token = "0x1700014C")]
		public bool IsNull
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x284CB38", Offset = "0x2848B38", VA = "0x284CB38", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014D")]
		public byte[] Buffer
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x284CB48", Offset = "0x2848B48", VA = "0x284CB48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014E")]
		public long Length
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x284CCC8", Offset = "0x2848CC8", VA = "0x284CCC8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700014F")]
		public byte[] Value
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x284CD38", Offset = "0x2848D38", VA = "0x284CD38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000150")]
		public static SqlBytes Null
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x284D310", Offset = "0x2849310", VA = "0x284D310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x284C9FC", Offset = "0x28489FC", VA = "0x284C9FC")]
		public SqlBytes()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x284CA30", Offset = "0x2848A30", VA = "0x284CA30")]
		public SqlBytes(byte[] buffer)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x284CA80", Offset = "0x2848A80", VA = "0x284CA80")]
		public SqlBytes(SqlBinary value)
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x284CA20", Offset = "0x2848A20", VA = "0x284CA20")]
		public void SetNull()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x284CB80", Offset = "0x2848B80", VA = "0x284CB80")]
		private void CopyStreamToBuffer()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x284CB70", Offset = "0x2848B70", VA = "0x284CB70")]
		internal bool FStream()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x284CF1C", Offset = "0x2848F1C", VA = "0x284CF1C")]
		private void SetBuffer(byte[] buffer)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x284CF44", Offset = "0x2848F44", VA = "0x284CF44", Slot = "5")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x284CF4C", Offset = "0x2848F4C", VA = "0x284CF4C", Slot = "6")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x284D118", Offset = "0x2849118", VA = "0x284D118", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x284D24C", Offset = "0x284924C", VA = "0x284D24C")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x284D2D8", Offset = "0x28492D8", VA = "0x284D2D8", Slot = "8")]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	[DefaultMember("Item")]
	[XmlSchemaProvider("GetXsdType")]
	public sealed class SqlChars : INullable, IXmlSerializable, ISerializable
	{
		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal char[] _rgchBuf;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long _lCurLen;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal SqlStreamChars _stream;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SqlBytesCharsState _state;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private char[] _rgchWorkBuf;

		[Token(Token = "0x17000151")]
		public bool IsNull
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x284D4D4", Offset = "0x28494D4", VA = "0x284D4D4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000152")]
		public char[] Buffer
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x284D4E4", Offset = "0x28494E4", VA = "0x284D4E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000153")]
		public long Length
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x284D65C", Offset = "0x284965C", VA = "0x284D65C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000154")]
		public char[] Value
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x284D6CC", Offset = "0x28496CC", VA = "0x284D6CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000155")]
		public static SqlChars Null
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x284DBC0", Offset = "0x2849BC0", VA = "0x284DBC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x284D378", Offset = "0x2849378", VA = "0x284D378")]
		public SqlChars()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x284D3AC", Offset = "0x28493AC", VA = "0x284D3AC")]
		public SqlChars(char[] buffer)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x284D3FC", Offset = "0x28493FC", VA = "0x284D3FC")]
		public SqlChars(SqlString value)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x284D39C", Offset = "0x284939C", VA = "0x284D39C")]
		public void SetNull()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x284D50C", Offset = "0x284950C", VA = "0x284D50C")]
		internal bool FStream()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x284D51C", Offset = "0x284951C", VA = "0x284D51C")]
		private void CopyStreamToBuffer()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x284D8A8", Offset = "0x28498A8", VA = "0x284D8A8")]
		private void SetBuffer(char[] buffer)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x284D8D0", Offset = "0x28498D0", VA = "0x284D8D0", Slot = "5")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x284D8D8", Offset = "0x28498D8", VA = "0x284D8D8", Slot = "6")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x284D9FC", Offset = "0x28499FC", VA = "0x284D9FC", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x284DAFC", Offset = "0x2849AFC", VA = "0x284DAFC")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x284DB88", Offset = "0x2849B88", VA = "0x284DB88", Slot = "8")]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlDateTime : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_fNotNull;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private int m_day;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int m_time;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly double s_SQLTicksPerMillisecond;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int SQLTicksPerSecond;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int SQLTicksPerMinute;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int SQLTicksPerHour;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int s_SQLTicksPerDay;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly long s_ticksPerSecond;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly DateTime s_SQLBaseDate;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly long s_SQLBaseDateTicks;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly int s_minYear;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static readonly int s_maxYear;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly int s_minDay;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static readonly int s_maxDay;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly int s_minTime;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static readonly int s_maxTime;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly int s_dayBase;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly int[] s_daysToMonth365;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly int[] s_daysToMonth366;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly DateTime s_minDateTime;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly DateTime s_maxDateTime;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly TimeSpan s_minTimeSpan;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly TimeSpan s_maxTimeSpan;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static readonly string s_ISO8601_DateTimeFormat;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static readonly string[] s_dateTimeFormats;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static readonly SqlDateTime MinValue;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public static readonly SqlDateTime MaxValue;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static readonly SqlDateTime Null;

		[Token(Token = "0x17000156")]
		public bool IsNull
		{
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x284DEB8", Offset = "0x2849EB8", VA = "0x284DEB8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000157")]
		public DateTime Value
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x284E220", Offset = "0x284A220", VA = "0x284E220")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000158")]
		public int DayTicks
		{
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x284E2BC", Offset = "0x284A2BC", VA = "0x284E2BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000159")]
		public int TimeTicks
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x284E304", Offset = "0x284A304", VA = "0x284E304")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x284DC28", Offset = "0x2849C28", VA = "0x284DC28")]
		private SqlDateTime(bool fNull)
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x284DC34", Offset = "0x2849C34", VA = "0x284DC34")]
		public SqlDateTime(DateTime value)
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x284DD94", Offset = "0x2849D94", VA = "0x284DD94")]
		public SqlDateTime(int dayTicks, int timeTicks)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x284DEC8", Offset = "0x2849EC8", VA = "0x284DEC8")]
		private static TimeSpan ToTimeSpan(SqlDateTime value)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x284DF70", Offset = "0x2849F70", VA = "0x284DF70")]
		private static DateTime ToDateTime(SqlDateTime value)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x284E018", Offset = "0x284A018", VA = "0x284E018")]
		private static SqlDateTime FromTimeSpan(TimeSpan value)
		{
			return default(SqlDateTime);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x284DCA0", Offset = "0x2849CA0", VA = "0x284DCA0")]
		private static SqlDateTime FromDateTime(DateTime value)
		{
			return default(SqlDateTime);
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x284E34C", Offset = "0x284A34C", VA = "0x284E34C")]
		public static implicit operator SqlDateTime(DateTime value)
		{
			return default(SqlDateTime);
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x284E37C", Offset = "0x284A37C", VA = "0x284E37C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x284E46C", Offset = "0x284A46C", VA = "0x284E46C")]
		public static SqlBoolean operator ==(SqlDateTime x, SqlDateTime y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x284E544", Offset = "0x284A544", VA = "0x284E544")]
		public static SqlBoolean operator <(SqlDateTime x, SqlDateTime y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x284E630", Offset = "0x284A630", VA = "0x284E630")]
		public static SqlBoolean operator >(SqlDateTime x, SqlDateTime y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x284E71C", Offset = "0x284A71C", VA = "0x284E71C")]
		public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x284E798", Offset = "0x284A798", VA = "0x284E798")]
		public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x284E814", Offset = "0x284A814", VA = "0x284E814", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x284E920", Offset = "0x284A920", VA = "0x284E920")]
		public int CompareTo(SqlDateTime value)
		{
			return default(int);
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x284EA84", Offset = "0x284AA84", VA = "0x284EA84", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x284EBCC", Offset = "0x284ABCC", VA = "0x284EBCC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x284EC84", Offset = "0x284AC84", VA = "0x284EC84", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x284EC8C", Offset = "0x284AC8C", VA = "0x284EC8C", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x284EE88", Offset = "0x284AE88", VA = "0x284EE88", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x284EFE4", Offset = "0x284AFE4", VA = "0x284EFE4")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlDecimal : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal byte _bStatus;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal byte _bLen;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		internal byte _bPrec;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		internal byte _bScale;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal uint _data1;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal uint _data2;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal uint _data3;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal uint _data4;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly byte s_NUMERIC_MAX_PRECISION;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static readonly byte MaxPrecision;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static readonly byte MaxScale;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private static readonly byte s_bNullMask;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly byte s_bIsNull;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		private static readonly byte s_bNotNull;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private static readonly byte s_bReverseNullMask;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		private static readonly byte s_bSignMask;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly byte s_bPositive;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static readonly byte s_bNegative;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static readonly byte s_bReverseSignMask;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly uint s_uiZero;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int s_cNumeMax;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly long s_lInt32Base;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly ulong s_ulInt32Base;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly ulong s_ulInt32BaseForMod;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal static readonly ulong s_llMax;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly uint s_ulBase10;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly double s_DUINT_BASE;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly double s_DUINT_BASE2;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly double s_DUINT_BASE3;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly double s_DMAX_NUME;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly uint s_DBL_DIG;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private static readonly byte s_cNumeDivScaleMin;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly uint[] s_rgulShiftBase;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly uint[] s_decimalHelpersLo;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly uint[] s_decimalHelpersMid;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static readonly uint[] s_decimalHelpersHi;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static readonly uint[] s_decimalHelpersHiHi;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static readonly byte[] s_rgCLenFromPrec;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static readonly uint s_ulT1;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private static readonly uint s_ulT2;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static readonly uint s_ulT3;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private static readonly uint s_ulT4;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static readonly uint s_ulT5;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private static readonly uint s_ulT6;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static readonly uint s_ulT7;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private static readonly uint s_ulT8;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static readonly uint s_ulT9;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static readonly ulong s_dwlT10;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static readonly ulong s_dwlT11;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static readonly ulong s_dwlT12;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static readonly ulong s_dwlT13;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static readonly ulong s_dwlT14;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static readonly ulong s_dwlT15;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static readonly ulong s_dwlT16;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static readonly ulong s_dwlT17;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static readonly ulong s_dwlT18;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static readonly ulong s_dwlT19;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static readonly SqlDecimal Null;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public static readonly SqlDecimal MinValue;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static readonly SqlDecimal MaxValue;

		[Token(Token = "0x1700015A")]
		public bool IsNull
		{
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x28502DC", Offset = "0x284C2DC", VA = "0x28502DC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015B")]
		public decimal Value
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x285034C", Offset = "0x284C34C", VA = "0x285034C")]
			get
			{
				return default(decimal);
			}
		}

		[Token(Token = "0x1700015C")]
		public bool IsPositive
		{
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x2850500", Offset = "0x284C500", VA = "0x2850500")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015D")]
		public byte Scale
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x2850654", Offset = "0x284C654", VA = "0x2850654")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x1700015E")]
		public int[] Data
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x28506E8", Offset = "0x284C6E8", VA = "0x28506E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x284F464", Offset = "0x284B464", VA = "0x284F464")]
		private byte CalculatePrecision()
		{
			return default(byte);
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x284F680", Offset = "0x284B680", VA = "0x284F680")]
		private bool VerifyPrecision(byte precision)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x284F89C", Offset = "0x284B89C", VA = "0x284F89C")]
		private SqlDecimal(bool fNull)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x284F904", Offset = "0x284B904", VA = "0x284F904")]
		public SqlDecimal(decimal value)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x284FA68", Offset = "0x284BA68", VA = "0x284FA68")]
		public SqlDecimal(int value)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x284FCA4", Offset = "0x284BCA4", VA = "0x284FCA4")]
		public SqlDecimal(long value)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x285001C", Offset = "0x284C01C", VA = "0x285001C")]
		private SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x2850274", Offset = "0x284C274", VA = "0x2850274")]
		private void SetPositive()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x28505C0", Offset = "0x284C5C0", VA = "0x28505C0")]
		private void SetSignBit(bool fPositive)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x28507E4", Offset = "0x284C7E4", VA = "0x28507E4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x2850BE4", Offset = "0x284CBE4", VA = "0x2850BE4")]
		public static SqlDecimal Parse(string s)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x28514A8", Offset = "0x284D4A8", VA = "0x28514A8")]
		public double ToDouble()
		{
			return default(double);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x28503A0", Offset = "0x284C3A0", VA = "0x28503A0")]
		private decimal ToDecimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x28515F4", Offset = "0x284D5F4", VA = "0x28515F4")]
		public static implicit operator SqlDecimal(decimal x)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x285160C", Offset = "0x284D60C", VA = "0x285160C")]
		public static implicit operator SqlDecimal(long x)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x2851674", Offset = "0x284D674", VA = "0x2851674")]
		public static SqlDecimal operator -(SqlDecimal x)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x2851798", Offset = "0x284D798", VA = "0x2851798")]
		public static SqlDecimal operator +(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x28522BC", Offset = "0x284E2BC", VA = "0x28522BC")]
		public static SqlDecimal operator -(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x2852360", Offset = "0x284E360", VA = "0x2852360")]
		public static SqlDecimal operator *(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x2852C40", Offset = "0x284EC40", VA = "0x2852C40")]
		public static SqlDecimal operator /(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x28538F8", Offset = "0x284F8F8", VA = "0x28538F8")]
		public static implicit operator SqlDecimal(SqlByte x)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x28539D4", Offset = "0x284F9D4", VA = "0x28539D4")]
		public static implicit operator SqlDecimal(SqlInt16 x)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x2853B08", Offset = "0x284FB08", VA = "0x2853B08")]
		public static implicit operator SqlDecimal(SqlInt32 x)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x2853C84", Offset = "0x284FC84", VA = "0x2853C84")]
		public static implicit operator SqlDecimal(SqlInt64 x)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x2853D6C", Offset = "0x284FD6C", VA = "0x2853D6C")]
		public static implicit operator SqlDecimal(SqlMoney x)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x2853874", Offset = "0x284F874", VA = "0x2853874")]
		private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x2850254", Offset = "0x284C254", VA = "0x2850254")]
		private bool FZero()
		{
			return default(bool);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x2852254", Offset = "0x284E254", VA = "0x2852254")]
		private bool FGt10_38()
		{
			return default(bool);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x2853F84", Offset = "0x284FF84", VA = "0x2853F84")]
		private bool FGt10_38(uint[] rglData)
		{
			return default(bool);
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x284FB3C", Offset = "0x284BB3C", VA = "0x284FB3C")]
		private static byte BGetPrecUI4(uint value)
		{
			return default(byte);
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x284FD70", Offset = "0x284BD70", VA = "0x284FD70")]
		private static byte BGetPrecUI8(ulong dwlVal)
		{
			return default(byte);
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x28512E8", Offset = "0x284D2E8", VA = "0x28512E8")]
		private void AddULong(uint ulAdd)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x28510E4", Offset = "0x284D0E4", VA = "0x28510E4")]
		private void MultByULong(uint uiMultiplier)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x2854054", Offset = "0x2850054", VA = "0x2854054")]
		private uint DivByULong(uint iDivisor)
		{
			return default(uint);
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x2851D98", Offset = "0x284DD98", VA = "0x2851D98")]
		internal void AdjustScale(int digits, bool fRound)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x28520E8", Offset = "0x284E0E8", VA = "0x28520E8")]
		private int LAbsCmp(SqlDecimal snumOp)
		{
			return default(int);
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x28541FC", Offset = "0x28501FC", VA = "0x28541FC")]
		private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x2854260", Offset = "0x2850260", VA = "0x2854260")]
		private static void MpSet(uint[] rgulD, out int ciulD, uint iulN)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x285428C", Offset = "0x285028C", VA = "0x285428C")]
		private static void MpNormalize(uint[] rgulU, ref int ciulU)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x28542E4", Offset = "0x28502E4", VA = "0x28542E4")]
		private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX)
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x2850B0C", Offset = "0x284CB0C", VA = "0x2850B0C")]
		private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x28543EC", Offset = "0x28503EC", VA = "0x28543EC")]
		internal static ulong DWL(uint lo, uint hi)
		{
			return default(ulong);
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x28543E0", Offset = "0x28503E0", VA = "0x28543E0")]
		private static uint HI(ulong x)
		{
			return default(uint);
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x28543E8", Offset = "0x28503E8", VA = "0x28543E8")]
		private static uint LO(ulong x)
		{
			return default(uint);
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x285305C", Offset = "0x284F05C", VA = "0x285305C")]
		private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x28543F8", Offset = "0x28503F8", VA = "0x28543F8")]
		private EComparison CompareNm(SqlDecimal snumOp)
		{
			return default(EComparison);
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x285017C", Offset = "0x284C17C", VA = "0x285017C")]
		private static void CheckValidPrecScale(byte bPrec, byte bScale)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x285464C", Offset = "0x285064C", VA = "0x285464C")]
		public static SqlBoolean operator ==(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x2854744", Offset = "0x2850744", VA = "0x2854744")]
		public static SqlBoolean operator <(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x285483C", Offset = "0x285083C", VA = "0x285483C")]
		public static SqlBoolean operator >(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x2854934", Offset = "0x2850934", VA = "0x2854934")]
		public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x28549C4", Offset = "0x28509C4", VA = "0x28549C4")]
		public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x2854A54", Offset = "0x2850A54", VA = "0x2854A54")]
		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x2854B88", Offset = "0x2850B88", VA = "0x2854B88")]
		public SqlInt64 ToSqlInt64()
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x2854DB0", Offset = "0x2850DB0", VA = "0x2854DB0")]
		public SqlMoney ToSqlMoney()
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x2850BDC", Offset = "0x284CBDC", VA = "0x2850BDC")]
		private static char ChFromDigit(uint uiDigit)
		{
			return default(char);
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x2853FFC", Offset = "0x284FFFC", VA = "0x2853FFC")]
		private void StoreFromWorkingArray(uint[] rguiData)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x285106C", Offset = "0x284D06C", VA = "0x285106C")]
		private void SetToZero()
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x2854EF4", Offset = "0x2850EF4", VA = "0x2854EF4", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x2855010", Offset = "0x2851010", VA = "0x2855010")]
		public int CompareTo(SqlDecimal value)
		{
			return default(int);
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x28551A0", Offset = "0x28511A0", VA = "0x28551A0", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x2855310", Offset = "0x2851310", VA = "0x2855310", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x2855418", Offset = "0x2851418", VA = "0x2855418", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x2855420", Offset = "0x2851420", VA = "0x2855420", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x2855584", Offset = "0x2851584", VA = "0x2855584", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x285569C", Offset = "0x285169C", VA = "0x285569C")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlDouble : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_fNotNull;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private double m_value;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SqlDouble Null;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly SqlDouble Zero;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly SqlDouble MinValue;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly SqlDouble MaxValue;

		[Token(Token = "0x1700015F")]
		public bool IsNull
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x2855B00", Offset = "0x2851B00", VA = "0x2855B00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000160")]
		public double Value
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x2855B10", Offset = "0x2851B10", VA = "0x2855B10")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x2855A8C", Offset = "0x2851A8C", VA = "0x2855A8C")]
		private SqlDouble(bool fNull)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x2855A98", Offset = "0x2851A98", VA = "0x2855A98")]
		public SqlDouble(double value)
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x2855B58", Offset = "0x2851B58", VA = "0x2855B58")]
		public static implicit operator SqlDouble(double x)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x2855B7C", Offset = "0x2851B7C", VA = "0x2855B7C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x2855C18", Offset = "0x2851C18", VA = "0x2855C18")]
		public static SqlDouble operator -(SqlDouble x)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x2855CC0", Offset = "0x2851CC0", VA = "0x2855CC0")]
		public static SqlDouble operator +(SqlDouble x, SqlDouble y)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x2855DE8", Offset = "0x2851DE8", VA = "0x2855DE8")]
		public static SqlDouble operator -(SqlDouble x, SqlDouble y)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x2855F10", Offset = "0x2851F10", VA = "0x2855F10")]
		public static SqlDouble operator *(SqlDouble x, SqlDouble y)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x2856038", Offset = "0x2852038", VA = "0x2856038")]
		public static SqlDouble operator /(SqlDouble x, SqlDouble y)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x284C0B8", Offset = "0x28480B8", VA = "0x284C0B8")]
		public static implicit operator SqlDouble(SqlByte x)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x2856194", Offset = "0x2852194", VA = "0x2856194")]
		public static implicit operator SqlDouble(SqlInt16 x)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x2856260", Offset = "0x2852260", VA = "0x2856260")]
		public static implicit operator SqlDouble(SqlInt32 x)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x2856328", Offset = "0x2852328", VA = "0x2856328")]
		public static implicit operator SqlDouble(SqlInt64 x)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x28563F0", Offset = "0x28523F0", VA = "0x28563F0")]
		public static implicit operator SqlDouble(SqlSingle x)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x28564C0", Offset = "0x28524C0", VA = "0x28564C0")]
		public static implicit operator SqlDouble(SqlMoney x)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x2854AC4", Offset = "0x2850AC4", VA = "0x2854AC4")]
		public static implicit operator SqlDouble(SqlDecimal x)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x2856614", Offset = "0x2852614", VA = "0x2856614")]
		public static SqlBoolean operator ==(SqlDouble x, SqlDouble y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x28566E8", Offset = "0x28526E8", VA = "0x28566E8")]
		public static SqlBoolean operator <(SqlDouble x, SqlDouble y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x28567BC", Offset = "0x28527BC", VA = "0x28567BC")]
		public static SqlBoolean operator >(SqlDouble x, SqlDouble y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x2856890", Offset = "0x2852890", VA = "0x2856890")]
		public static SqlBoolean LessThan(SqlDouble x, SqlDouble y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x285690C", Offset = "0x285290C", VA = "0x285690C")]
		public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x2856988", Offset = "0x2852988", VA = "0x2856988")]
		public SqlSingle ToSqlSingle()
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x28569E8", Offset = "0x28529E8", VA = "0x28569E8", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x2856AF0", Offset = "0x2852AF0", VA = "0x2856AF0")]
		public int CompareTo(SqlDouble value)
		{
			return default(int);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x2856C4C", Offset = "0x2852C4C", VA = "0x2856C4C", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x2856D8C", Offset = "0x2852D8C", VA = "0x2856D8C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x2856E20", Offset = "0x2852E20", VA = "0x2856E20", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x2856E28", Offset = "0x2852E28", VA = "0x2856E28", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x2856F48", Offset = "0x2852F48", VA = "0x2856F48", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x2857084", Offset = "0x2853084", VA = "0x2857084")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlGuid : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int s_sizeOfGuid;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] s_rgiGuidOrder;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte[] m_value;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly SqlGuid Null;

		[Token(Token = "0x17000161")]
		public bool IsNull
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x28571D4", Offset = "0x28531D4", VA = "0x28571D4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000162")]
		public Guid Value
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x28571E4", Offset = "0x28531E4", VA = "0x28571E4")]
			get
			{
				return default(Guid);
			}
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x28571A0", Offset = "0x28531A0", VA = "0x28571A0")]
		private SqlGuid(bool fNull)
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x28571A8", Offset = "0x28531A8", VA = "0x28571A8")]
		public SqlGuid(Guid g)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x285728C", Offset = "0x285328C", VA = "0x285728C")]
		public static implicit operator SqlGuid(Guid x)
		{
			return default(SqlGuid);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x28572B0", Offset = "0x28532B0", VA = "0x28572B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x285735C", Offset = "0x285335C", VA = "0x285735C")]
		private static EComparison Compare(SqlGuid x, SqlGuid y)
		{
			return default(EComparison);
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x285745C", Offset = "0x285345C", VA = "0x285745C")]
		public static SqlBoolean operator ==(SqlGuid x, SqlGuid y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x2857538", Offset = "0x2853538", VA = "0x2857538")]
		public static SqlBoolean operator <(SqlGuid x, SqlGuid y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x2857614", Offset = "0x2853614", VA = "0x2857614")]
		public static SqlBoolean operator >(SqlGuid x, SqlGuid y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x28576F0", Offset = "0x28536F0", VA = "0x28576F0", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x28577F4", Offset = "0x28537F4", VA = "0x28577F4")]
		public int CompareTo(SqlGuid value)
		{
			return default(int);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x2857930", Offset = "0x2853930", VA = "0x2857930", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x2857A60", Offset = "0x2853A60", VA = "0x2857A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x2857AF0", Offset = "0x2853AF0", VA = "0x2857AF0", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x2857AF8", Offset = "0x2853AF8", VA = "0x2857AF8", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x2857C14", Offset = "0x2853C14", VA = "0x2857C14", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x2857D60", Offset = "0x2853D60", VA = "0x2857D60")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlInt16 : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_fNotNull;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private short m_value;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int s_MASKI2;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly SqlInt16 Null;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly SqlInt16 Zero;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly SqlInt16 MinValue;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly SqlInt16 MaxValue;

		[Token(Token = "0x17000163")]
		public bool IsNull
		{
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x2853AB0", Offset = "0x284FAB0", VA = "0x2853AB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000164")]
		public short Value
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x2853AC0", Offset = "0x284FAC0", VA = "0x2853AC0")]
			get
			{
				return default(short);
			}
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x2857E90", Offset = "0x2853E90", VA = "0x2857E90")]
		private SqlInt16(bool fNull)
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x2857E9C", Offset = "0x2853E9C", VA = "0x2857E9C")]
		public SqlInt16(short value)
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x2857EAC", Offset = "0x2853EAC", VA = "0x2857EAC")]
		public static implicit operator SqlInt16(short x)
		{
			return default(SqlInt16);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x2857EB8", Offset = "0x2853EB8", VA = "0x2857EB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x2857F54", Offset = "0x2853F54", VA = "0x2857F54")]
		public static SqlInt16 operator -(SqlInt16 x)
		{
			return default(SqlInt16);
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x2857FF4", Offset = "0x2853FF4", VA = "0x2857FF4")]
		public static SqlInt16 operator +(SqlInt16 x, SqlInt16 y)
		{
			return default(SqlInt16);
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x2858104", Offset = "0x2854104", VA = "0x2858104")]
		public static SqlInt16 operator -(SqlInt16 x, SqlInt16 y)
		{
			return default(SqlInt16);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2858214", Offset = "0x2854214", VA = "0x2858214")]
		public static SqlInt16 operator *(SqlInt16 x, SqlInt16 y)
		{
			return default(SqlInt16);
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x285835C", Offset = "0x285435C", VA = "0x285835C")]
		public static SqlInt16 operator /(SqlInt16 x, SqlInt16 y)
		{
			return default(SqlInt16);
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x28584B8", Offset = "0x28544B8", VA = "0x28584B8")]
		public static implicit operator SqlInt16(SqlByte x)
		{
			return default(SqlInt16);
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x2858588", Offset = "0x2854588", VA = "0x2858588")]
		public static explicit operator SqlInt16(SqlInt64 x)
		{
			return default(SqlInt16);
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x28586A0", Offset = "0x28546A0", VA = "0x28586A0")]
		public static SqlBoolean operator ==(SqlInt16 x, SqlInt16 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x2858760", Offset = "0x2854760", VA = "0x2858760")]
		public static SqlBoolean operator <(SqlInt16 x, SqlInt16 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x2858820", Offset = "0x2854820", VA = "0x2858820")]
		public static SqlBoolean operator >(SqlInt16 x, SqlInt16 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x28588E0", Offset = "0x28548E0", VA = "0x28588E0")]
		public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x2858944", Offset = "0x2854944", VA = "0x2858944")]
		public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x28589A8", Offset = "0x28549A8", VA = "0x28589A8")]
		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x2858A00", Offset = "0x2854A00", VA = "0x2858A00")]
		public SqlInt64 ToSqlInt64()
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x2858B10", Offset = "0x2854B10", VA = "0x2858B10", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x2858C14", Offset = "0x2854C14", VA = "0x2858C14")]
		public int CompareTo(SqlInt16 value)
		{
			return default(int);
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x2858D54", Offset = "0x2854D54", VA = "0x2858D54", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x2858E84", Offset = "0x2854E84", VA = "0x2858E84", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x2858F14", Offset = "0x2854F14", VA = "0x2858F14", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x2858F1C", Offset = "0x2854F1C", VA = "0x2858F1C", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x285903C", Offset = "0x285503C", VA = "0x285903C", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x285916C", Offset = "0x285516C", VA = "0x285916C")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlInt32 : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_fNotNull;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private int m_value;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly long s_iIntMin;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly long s_lBitNotIntMax;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly SqlInt32 Null;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly SqlInt32 Zero;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly SqlInt32 MinValue;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly SqlInt32 MaxValue;

		[Token(Token = "0x17000165")]
		public bool IsNull
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x2853BE4", Offset = "0x284FBE4", VA = "0x2853BE4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000166")]
		public int Value
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x2853BF4", Offset = "0x284FBF4", VA = "0x2853BF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x2859274", Offset = "0x2855274", VA = "0x2859274")]
		private SqlInt32(bool fNull)
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x2859280", Offset = "0x2855280", VA = "0x2859280")]
		public SqlInt32(int value)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x2859290", Offset = "0x2855290", VA = "0x2859290")]
		public static implicit operator SqlInt32(int x)
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x285929C", Offset = "0x285529C", VA = "0x285929C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x2859338", Offset = "0x2855338", VA = "0x2859338")]
		public static SqlInt32 operator -(SqlInt32 x)
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x28593D4", Offset = "0x28553D4", VA = "0x28593D4")]
		public static SqlInt32 operator +(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x2859510", Offset = "0x2855510", VA = "0x2859510")]
		public static SqlInt32 operator -(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x2859640", Offset = "0x2855640", VA = "0x2859640")]
		public static SqlInt32 operator *(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x2859788", Offset = "0x2855788", VA = "0x2859788")]
		public static SqlInt32 operator /(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x28598E8", Offset = "0x28558E8", VA = "0x28598E8")]
		public static implicit operator SqlInt32(SqlByte x)
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x28599B8", Offset = "0x28559B8", VA = "0x28599B8")]
		public static implicit operator SqlInt32(SqlInt16 x)
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x2859A8C", Offset = "0x2855A8C", VA = "0x2859A8C")]
		public static explicit operator SqlInt32(SqlInt64 x)
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x2859504", Offset = "0x2855504", VA = "0x2859504")]
		private static bool SameSignInt(int x, int y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x2859BA4", Offset = "0x2855BA4", VA = "0x2859BA4")]
		public static SqlBoolean operator ==(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x2859C68", Offset = "0x2855C68", VA = "0x2859C68")]
		public static SqlBoolean operator <(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x2859D2C", Offset = "0x2855D2C", VA = "0x2859D2C")]
		public static SqlBoolean operator >(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x2859DF0", Offset = "0x2855DF0", VA = "0x2859DF0")]
		public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x2859E54", Offset = "0x2855E54", VA = "0x2859E54")]
		public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x2859EB8", Offset = "0x2855EB8", VA = "0x2859EB8")]
		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x2859F10", Offset = "0x2855F10", VA = "0x2859F10")]
		public SqlInt64 ToSqlInt64()
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x285A020", Offset = "0x2856020", VA = "0x285A020", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x285A124", Offset = "0x2856124", VA = "0x285A124")]
		public int CompareTo(SqlInt32 value)
		{
			return default(int);
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x285A264", Offset = "0x2856264", VA = "0x285A264", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x285A394", Offset = "0x2856394", VA = "0x285A394", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x285A424", Offset = "0x2856424", VA = "0x285A424", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x285A42C", Offset = "0x285642C", VA = "0x285A42C", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x285A54C", Offset = "0x285654C", VA = "0x285A54C", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x285A67C", Offset = "0x285667C", VA = "0x285A67C")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlInt64 : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_fNotNull;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private long m_value;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly long s_lLowIntMask;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly long s_lHighIntMask;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly SqlInt64 Null;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly SqlInt64 Zero;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly SqlInt64 MinValue;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly SqlInt64 MaxValue;

		[Token(Token = "0x17000167")]
		public bool IsNull
		{
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x284BCF4", Offset = "0x2847CF4", VA = "0x284BCF4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000168")]
		public long Value
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x284BD04", Offset = "0x2847D04", VA = "0x284BD04")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x285A784", Offset = "0x2856784", VA = "0x285A784")]
		private SqlInt64(bool fNull)
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x285A790", Offset = "0x2856790", VA = "0x285A790")]
		public SqlInt64(long value)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x285A7A0", Offset = "0x28567A0", VA = "0x285A7A0")]
		public static implicit operator SqlInt64(long x)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x285A7AC", Offset = "0x28567AC", VA = "0x285A7AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x285A848", Offset = "0x2856848", VA = "0x285A848")]
		public static SqlInt64 operator -(SqlInt64 x)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x285A8D4", Offset = "0x28568D4", VA = "0x285A8D4")]
		public static SqlInt64 operator +(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x285AA18", Offset = "0x2856A18", VA = "0x285AA18")]
		public static SqlInt64 operator -(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x285AB4C", Offset = "0x2856B4C", VA = "0x285AB4C")]
		public static SqlInt64 operator *(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x285ACB4", Offset = "0x2856CB4", VA = "0x285ACB4")]
		public static SqlInt64 operator /(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x285ADEC", Offset = "0x2856DEC", VA = "0x285ADEC")]
		public static SqlInt64 operator %(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x284C1DC", Offset = "0x28481DC", VA = "0x284C1DC")]
		public static implicit operator SqlInt64(SqlByte x)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x2858A58", Offset = "0x2854A58", VA = "0x2858A58")]
		public static implicit operator SqlInt64(SqlInt16 x)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x2859F68", Offset = "0x2855F68", VA = "0x2859F68")]
		public static implicit operator SqlInt64(SqlInt32 x)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x2854BF8", Offset = "0x2850BF8", VA = "0x2854BF8")]
		public static explicit operator SqlInt64(SqlDecimal x)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x285AA08", Offset = "0x2856A08", VA = "0x285AA08")]
		private static bool SameSignLong(long x, long y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x285AF28", Offset = "0x2856F28", VA = "0x285AF28")]
		public static SqlBoolean operator ==(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x285AFF4", Offset = "0x2856FF4", VA = "0x285AFF4")]
		public static SqlBoolean operator <(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x285B0C0", Offset = "0x28570C0", VA = "0x285B0C0")]
		public static SqlBoolean operator >(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x285B18C", Offset = "0x285718C", VA = "0x285B18C")]
		public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x285B208", Offset = "0x2857208", VA = "0x285B208")]
		public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x285B284", Offset = "0x2857284", VA = "0x285B284")]
		public SqlByte ToSqlByte()
		{
			return default(SqlByte);
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x285B2E0", Offset = "0x28572E0", VA = "0x285B2E0")]
		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x285B33C", Offset = "0x285733C", VA = "0x285B33C")]
		public SqlInt16 ToSqlInt16()
		{
			return default(SqlInt16);
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x285B398", Offset = "0x2857398", VA = "0x285B398")]
		public SqlInt32 ToSqlInt32()
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x285B3F4", Offset = "0x28573F4", VA = "0x285B3F4")]
		public SqlDecimal ToSqlDecimal()
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x285B460", Offset = "0x2857460", VA = "0x285B460", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x285B568", Offset = "0x2857568", VA = "0x285B568")]
		public int CompareTo(SqlInt64 value)
		{
			return default(int);
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x285B6C4", Offset = "0x28576C4", VA = "0x285B6C4", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x285B804", Offset = "0x2857804", VA = "0x285B804", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x285B894", Offset = "0x2857894", VA = "0x285B894", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x285B89C", Offset = "0x285789C", VA = "0x285B89C", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x285B9BC", Offset = "0x28579BC", VA = "0x285B9BC", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x285BAEC", Offset = "0x2857AEC", VA = "0x285BAEC")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlMoney : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _fNotNull;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private long _value;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly int s_iMoneyScale;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly long s_lTickBase;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly double s_dTickBase;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly long s_minLong;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly long s_maxLong;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly SqlMoney Null;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly SqlMoney Zero;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly SqlMoney MinValue;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly SqlMoney MaxValue;

		[Token(Token = "0x17000169")]
		public bool IsNull
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x2853E60", Offset = "0x284FE60", VA = "0x2853E60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016A")]
		public decimal Value
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x285BEFC", Offset = "0x2857EFC", VA = "0x285BEFC")]
			get
			{
				return default(decimal);
			}
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x285BC10", Offset = "0x2857C10", VA = "0x285BC10")]
		private SqlMoney(bool fNull)
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x285BC1C", Offset = "0x2857C1C", VA = "0x285BC1C")]
		internal SqlMoney(long value, int ignored)
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x285BC2C", Offset = "0x2857C2C", VA = "0x285BC2C")]
		public SqlMoney(int value)
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x285BCA8", Offset = "0x2857CA8", VA = "0x285BCA8")]
		public SqlMoney(long value)
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x285BDA0", Offset = "0x2857DA0", VA = "0x285BDA0")]
		public SqlMoney(decimal value)
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x2853E70", Offset = "0x284FE70", VA = "0x2853E70")]
		public decimal ToDecimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x2856584", Offset = "0x2852584", VA = "0x2856584")]
		public double ToDouble()
		{
			return default(double);
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x285BF8C", Offset = "0x2857F8C", VA = "0x285BF8C")]
		public static implicit operator SqlMoney(decimal x)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x285BFB8", Offset = "0x2857FB8", VA = "0x285BFB8")]
		public static implicit operator SqlMoney(long x)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x285C014", Offset = "0x2858014", VA = "0x285C014", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x285C138", Offset = "0x2858138", VA = "0x285C138")]
		public static SqlMoney operator -(SqlMoney x)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x285C220", Offset = "0x2858220", VA = "0x285C220")]
		public static SqlMoney operator +(SqlMoney x, SqlMoney y)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x285C3C8", Offset = "0x28583C8", VA = "0x285C3C8")]
		public static SqlMoney operator -(SqlMoney x, SqlMoney y)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x285C570", Offset = "0x2858570", VA = "0x285C570")]
		public static SqlMoney operator *(SqlMoney x, SqlMoney y)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x285C6A8", Offset = "0x28586A8", VA = "0x285C6A8")]
		public static SqlMoney operator /(SqlMoney x, SqlMoney y)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x285C7E0", Offset = "0x28587E0", VA = "0x285C7E0")]
		public static implicit operator SqlMoney(SqlByte x)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x285C8AC", Offset = "0x28588AC", VA = "0x285C8AC")]
		public static implicit operator SqlMoney(SqlInt16 x)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x285C974", Offset = "0x2858974", VA = "0x285C974")]
		public static implicit operator SqlMoney(SqlInt32 x)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x285CA3C", Offset = "0x2858A3C", VA = "0x285CA3C")]
		public static implicit operator SqlMoney(SqlInt64 x)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x2854E20", Offset = "0x2850E20", VA = "0x2854E20")]
		public static explicit operator SqlMoney(SqlDecimal x)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x285CB04", Offset = "0x2858B04", VA = "0x285CB04")]
		public static SqlBoolean operator ==(SqlMoney x, SqlMoney y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x285CBD0", Offset = "0x2858BD0", VA = "0x285CBD0")]
		public static SqlBoolean operator <(SqlMoney x, SqlMoney y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x285CC9C", Offset = "0x2858C9C", VA = "0x285CC9C")]
		public static SqlBoolean operator >(SqlMoney x, SqlMoney y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x285CD68", Offset = "0x2858D68", VA = "0x285CD68")]
		public static SqlBoolean LessThan(SqlMoney x, SqlMoney y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x285CDE4", Offset = "0x2858DE4", VA = "0x285CDE4")]
		public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x285CE60", Offset = "0x2858E60", VA = "0x285CE60")]
		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x285CEBC", Offset = "0x2858EBC", VA = "0x285CEBC")]
		public SqlDecimal ToSqlDecimal()
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x285CF28", Offset = "0x2858F28", VA = "0x285CF28", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x285D030", Offset = "0x2859030", VA = "0x285D030")]
		public int CompareTo(SqlMoney value)
		{
			return default(int);
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x285D18C", Offset = "0x285918C", VA = "0x285D18C", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x285D2CC", Offset = "0x28592CC", VA = "0x285D2CC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x285D33C", Offset = "0x285933C", VA = "0x285D33C", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x285D344", Offset = "0x2859344", VA = "0x285D344", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x285D4B4", Offset = "0x28594B4", VA = "0x285D4B4", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x285D604", Offset = "0x2859604", VA = "0x285D604")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlSingle : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _fNotNull;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private float _value;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SqlSingle Null;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly SqlSingle Zero;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly SqlSingle MinValue;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly SqlSingle MaxValue;

		[Token(Token = "0x1700016B")]
		public bool IsNull
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x285D83C", Offset = "0x285983C", VA = "0x285D83C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016C")]
		public float Value
		{
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x285D84C", Offset = "0x285984C", VA = "0x285D84C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x285D758", Offset = "0x2859758", VA = "0x285D758")]
		private SqlSingle(bool fNull)
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x285D764", Offset = "0x2859764", VA = "0x285D764")]
		public SqlSingle(float value)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x285D7D8", Offset = "0x28597D8", VA = "0x285D7D8")]
		public SqlSingle(double value)
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x285D8C8", Offset = "0x28598C8", VA = "0x285D8C8")]
		public static implicit operator SqlSingle(float x)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x285D8E0", Offset = "0x28598E0", VA = "0x285D8E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x285D954", Offset = "0x2859954", VA = "0x285D954")]
		public static SqlSingle operator -(SqlSingle x)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x285D9F0", Offset = "0x28599F0", VA = "0x285D9F0")]
		public static SqlSingle operator +(SqlSingle x, SqlSingle y)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x285DB08", Offset = "0x2859B08", VA = "0x285DB08")]
		public static SqlSingle operator -(SqlSingle x, SqlSingle y)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x285DC20", Offset = "0x2859C20", VA = "0x285DC20")]
		public static SqlSingle operator *(SqlSingle x, SqlSingle y)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x285DD38", Offset = "0x2859D38", VA = "0x285DD38")]
		public static SqlSingle operator /(SqlSingle x, SqlSingle y)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x285DE88", Offset = "0x2859E88", VA = "0x285DE88")]
		public static implicit operator SqlSingle(SqlByte x)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x285DF58", Offset = "0x2859F58", VA = "0x285DF58")]
		public static implicit operator SqlSingle(SqlInt16 x)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x285E028", Offset = "0x285A028", VA = "0x285E028")]
		public static implicit operator SqlSingle(SqlInt32 x)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x285E0F4", Offset = "0x285A0F4", VA = "0x285E0F4")]
		public static implicit operator SqlSingle(SqlInt64 x)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x285E1C0", Offset = "0x285A1C0", VA = "0x285E1C0")]
		public static implicit operator SqlSingle(SqlMoney x)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x285E288", Offset = "0x285A288", VA = "0x285E288")]
		public static implicit operator SqlSingle(SqlDecimal x)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x285E350", Offset = "0x285A350", VA = "0x285E350")]
		public static explicit operator SqlSingle(SqlDouble x)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x285E418", Offset = "0x285A418", VA = "0x285E418")]
		public static SqlBoolean operator ==(SqlSingle x, SqlSingle y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x285E4F8", Offset = "0x285A4F8", VA = "0x285E4F8")]
		public static SqlBoolean operator <(SqlSingle x, SqlSingle y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x285E5D8", Offset = "0x285A5D8", VA = "0x285E5D8")]
		public static SqlBoolean operator >(SqlSingle x, SqlSingle y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x285E6B8", Offset = "0x285A6B8", VA = "0x285E6B8")]
		public static SqlBoolean LessThan(SqlSingle x, SqlSingle y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x285E71C", Offset = "0x285A71C", VA = "0x285E71C")]
		public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x285E780", Offset = "0x285A780", VA = "0x285E780")]
		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x285E7DC", Offset = "0x285A7DC", VA = "0x285E7DC", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x285E8DC", Offset = "0x285A8DC", VA = "0x285E8DC")]
		public int CompareTo(SqlSingle value)
		{
			return default(int);
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x285EAE8", Offset = "0x285AAE8", VA = "0x285EAE8", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x285EC1C", Offset = "0x285AC1C", VA = "0x285EC1C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x285ECAC", Offset = "0x285ACAC", VA = "0x285ECAC", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x285ECB4", Offset = "0x285ACB4", VA = "0x285ECB4", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x285EDD4", Offset = "0x285ADD4", VA = "0x285EDD4", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x285EF10", Offset = "0x285AF10", VA = "0x285EF10")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B5")]
	[Flags]
	public enum SqlCompareOptions
	{
		[Token(Token = "0x40003F1")]
		None = 0,
		[Token(Token = "0x40003F2")]
		IgnoreCase = 1,
		[Token(Token = "0x40003F3")]
		IgnoreNonSpace = 2,
		[Token(Token = "0x40003F4")]
		IgnoreKanaType = 8,
		[Token(Token = "0x40003F5")]
		IgnoreWidth = 0x10,
		[Token(Token = "0x40003F6")]
		BinarySort = 0x8000,
		[Token(Token = "0x40003F7")]
		BinarySort2 = 0x4000
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlString : INullable, IComparable, IXmlSerializable
	{
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string m_value;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private CompareInfo m_cmpInfo;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_lcid;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private SqlCompareOptions m_flag;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_fNotNull;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SqlString Null;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly UnicodeEncoding s_unicodeEncoding;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int IgnoreCase;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int IgnoreWidth;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int IgnoreNonSpace;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int IgnoreKanaType;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int BinarySort;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int BinarySort2;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly SqlCompareOptions s_iDefaultFlag;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static readonly CompareOptions s_iValidCompareOptionMask;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal static readonly int s_lcidUSEnglish;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly int s_lcidBinary;

		[Token(Token = "0x1700016D")]
		public bool IsNull
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x285F2C4", Offset = "0x285B2C4", VA = "0x285F2C4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016E")]
		public string Value
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x285F2D4", Offset = "0x285B2D4", VA = "0x285F2D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x285F02C", Offset = "0x285B02C", VA = "0x285F02C")]
		private SqlString(bool fNull)
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x285F03C", Offset = "0x285B03C", VA = "0x285F03C")]
		public SqlString(string data, int lcid, SqlCompareOptions compareOptions)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x285F174", Offset = "0x285B174", VA = "0x285F174")]
		public SqlString(string data)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x285F230", Offset = "0x285B230", VA = "0x285F230")]
		private SqlString(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo)
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x285F360", Offset = "0x285B360", VA = "0x285F360")]
		private void SetCompareInfo()
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x285F3E0", Offset = "0x285B3E0", VA = "0x285F3E0")]
		public static implicit operator SqlString(string x)
		{
			return default(SqlString);
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x285F3F4", Offset = "0x285B3F4", VA = "0x285F3F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x285F460", Offset = "0x285B460", VA = "0x285F460")]
		public static SqlString operator +(SqlString x, SqlString y)
		{
			return default(SqlString);
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x285F5D0", Offset = "0x285B5D0", VA = "0x285F5D0")]
		private static int StringCompare(SqlString x, SqlString y)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x285FBD0", Offset = "0x285BBD0", VA = "0x285FBD0")]
		private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x285FD30", Offset = "0x285BD30", VA = "0x285FD30")]
		public static SqlBoolean operator ==(SqlString x, SqlString y)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x285F0C8", Offset = "0x285B0C8", VA = "0x285F0C8")]
		private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions)
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x285FB2C", Offset = "0x285BB2C", VA = "0x285FB2C")]
		public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions)
		{
			return default(CompareOptions);
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x285FE44", Offset = "0x285BE44", VA = "0x285FE44")]
		private bool FBinarySort()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x285F7E4", Offset = "0x285B7E4", VA = "0x285F7E4")]
		private static int CompareBinary(SqlString x, SqlString y)
		{
			return default(int);
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x285F9B4", Offset = "0x285B9B4", VA = "0x285F9B4")]
		private static int CompareBinary2(SqlString x, SqlString y)
		{
			return default(int);
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x285FEB0", Offset = "0x285BEB0", VA = "0x285FEB0", Slot = "5")]
		public int CompareTo(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x285FFC0", Offset = "0x285BFC0", VA = "0x285FFC0")]
		public int CompareTo(SqlString value)
		{
			return default(int);
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x28600A0", Offset = "0x285C0A0", VA = "0x28600A0", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x2860220", Offset = "0x285C220", VA = "0x2860220", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x2860440", Offset = "0x285C440", VA = "0x2860440", Slot = "6")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x2860448", Offset = "0x285C448", VA = "0x2860448", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x286053C", Offset = "0x285C53C", VA = "0x286053C", Slot = "8")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x2860638", Offset = "0x285C638", VA = "0x2860638")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B7")]
	internal enum EComparison
	{
		[Token(Token = "0x400040B")]
		LT,
		[Token(Token = "0x400040C")]
		LE,
		[Token(Token = "0x400040D")]
		EQ,
		[Token(Token = "0x400040E")]
		GE,
		[Token(Token = "0x400040F")]
		GT,
		[Token(Token = "0x4000410")]
		NE
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class SqlTypeException : SystemException
	{
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x2860770", Offset = "0x285C770", VA = "0x2860770")]
		public SqlTypeException()
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x285F5A8", Offset = "0x285B5A8", VA = "0x285F5A8")]
		public SqlTypeException(string message)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x28607D0", Offset = "0x285C7D0", VA = "0x28607D0")]
		public SqlTypeException(string message, Exception e)
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x28607F4", Offset = "0x285C7F4", VA = "0x28607F4")]
		protected SqlTypeException(SerializationInfo si, StreamingContext sc)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x2860844", Offset = "0x285C844", VA = "0x2860844")]
		private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public sealed class SqlNullValueException : SqlTypeException
	{
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x285D890", Offset = "0x2859890", VA = "0x285D890")]
		public SqlNullValueException()
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x286093C", Offset = "0x285C93C", VA = "0x286093C")]
		public SqlNullValueException(string message)
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x2860918", Offset = "0x285C918", VA = "0x2860918")]
		public SqlNullValueException(string message, Exception e)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x2860964", Offset = "0x285C964", VA = "0x2860964")]
		private SqlNullValueException(SerializationInfo si, StreamingContext sc)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x28609C4", Offset = "0x285C9C4", VA = "0x28609C4")]
		private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public sealed class SqlTruncateException : SqlTypeException
	{
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x2860A98", Offset = "0x285CA98", VA = "0x2860A98")]
		public SqlTruncateException()
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x2860AF4", Offset = "0x285CAF4", VA = "0x2860AF4")]
		public SqlTruncateException(string message)
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x2860AD0", Offset = "0x285CAD0", VA = "0x2860AD0")]
		public SqlTruncateException(string message, Exception e)
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x2860B1C", Offset = "0x285CB1C", VA = "0x2860B1C")]
		private SqlTruncateException(SerializationInfo si, StreamingContext sc)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x2860B7C", Offset = "0x285CB7C", VA = "0x2860B7C")]
		private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BB")]
	internal abstract class SqlStreamChars
	{
		[Token(Token = "0x1700016F")]
		public abstract long Length
		{
			[Token(Token = "0x6000A4A")]
			get;
		}

		[Token(Token = "0x17000170")]
		public abstract long Position
		{
			[Token(Token = "0x6000A4B")]
			get;
		}

		[Token(Token = "0x6000A4C")]
		public abstract int Read(char[] buffer, int offset, int count);

		[Token(Token = "0x6000A4D")]
		public abstract long Seek(long offset, SeekOrigin origin);
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	[XmlSchemaProvider("GetXsdType")]
	public sealed class SqlXml : INullable, IXmlSerializable
	{
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly XmlReaderSettings s_defaultXmlReaderSettings;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static MethodInfo s_createSqlReaderMethodInfo;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MethodInfo _createSqlReaderMethodInfo;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _fNotNull;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Stream _stream;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _firstCreateReader;

		[Token(Token = "0x17000171")]
		private static MethodInfo CreateSqlReaderMethodInfo
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x2860E5C", Offset = "0x285CE5C", VA = "0x2860E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000172")]
		public bool IsNull
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x2860DDC", Offset = "0x285CDDC", VA = "0x2860DDC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x2860C50", Offset = "0x285CC50", VA = "0x2860C50")]
		public SqlXml()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x2860C8C", Offset = "0x285CC8C", VA = "0x2860C8C")]
		public XmlReader CreateReader()
		{
			return null;
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x2860F80", Offset = "0x285CF80", VA = "0x2860F80")]
		internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = false, bool throwTargetInvocationExceptions = false)
		{
			return null;
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x2861324", Offset = "0x285D324", VA = "0x2861324")]
		private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x2860C78", Offset = "0x285CC78", VA = "0x2860C78")]
		private void SetNull()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x286141C", Offset = "0x285D41C", VA = "0x286141C", Slot = "5")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x2861424", Offset = "0x285D424", VA = "0x2861424", Slot = "6")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r)
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x28615F4", Offset = "0x285D5F4", VA = "0x28615F4", Slot = "7")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x2861744", Offset = "0x285D744", VA = "0x2861744")]
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BD")]
	internal sealed class SqlXmlStreamWrapper : Stream
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Stream _stream;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long _lPosition;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isClosed;

		[Token(Token = "0x17000173")]
		public override bool CanRead
		{
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x28618AC", Offset = "0x285D8AC", VA = "0x28618AC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000174")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x2861954", Offset = "0x285D954", VA = "0x2861954", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000175")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x286198C", Offset = "0x285D98C", VA = "0x286198C", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000176")]
		public override long Length
		{
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x28619C4", Offset = "0x285D9C4", VA = "0x28619C4", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000177")]
		public override long Position
		{
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x2861B14", Offset = "0x285DB14", VA = "0x2861B14", Slot = "12")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x2861B70", Offset = "0x285DB70", VA = "0x2861B70", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x2860DEC", Offset = "0x285CDEC", VA = "0x2860DEC")]
		internal SqlXmlStreamWrapper(Stream stream)
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x2861C44", Offset = "0x285DC44", VA = "0x2861C44", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x2861E14", Offset = "0x285DE14", VA = "0x2861E14", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x2862048", Offset = "0x285E048", VA = "0x2862048", Slot = "34")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x286227C", Offset = "0x285E27C", VA = "0x286227C", Slot = "33")]
		public override int ReadByte()
		{
			return default(int);
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x2862390", Offset = "0x285E390", VA = "0x2862390", Slot = "36")]
		public override void WriteByte(byte value)
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x2862474", Offset = "0x285E474", VA = "0x2862474", Slot = "30")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x2862508", Offset = "0x285E508", VA = "0x2862508", Slot = "20")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x2862524", Offset = "0x285E524", VA = "0x2862524", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x2861A98", Offset = "0x285DA98", VA = "0x2861A98")]
		private void ThrowIfStreamCannotSeek(string method)
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x2861FCC", Offset = "0x285DFCC", VA = "0x2861FCC")]
		private void ThrowIfStreamCannotRead(string method)
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x2862200", Offset = "0x285E200", VA = "0x2862200")]
		private void ThrowIfStreamCannotWrite(string method)
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x2861A30", Offset = "0x285DA30", VA = "0x2861A30")]
		private void ThrowIfStreamClosed(string method)
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x28618E4", Offset = "0x285D8E4", VA = "0x28618E4")]
		private bool IsStreamClosed()
		{
			return default(bool);
		}
	}
}
namespace System.Data.Common
{
	[Token(Token = "0x20000BE")]
	internal sealed class ObjectStorage : DataStorage
	{
		[Token(Token = "0x20000BF")]
		private enum Families
		{
			[Token(Token = "0x4000423")]
			DATETIME,
			[Token(Token = "0x4000424")]
			NUMBER,
			[Token(Token = "0x4000425")]
			STRING,
			[Token(Token = "0x4000426")]
			BOOLEAN,
			[Token(Token = "0x4000427")]
			ARRAY
		}

		[Token(Token = "0x20000C0")]
		private class TempAssemblyComparer : IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>>
		{
			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default;

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x2867C04", Offset = "0x2863C04", VA = "0x2867C04")]
			private TempAssemblyComparer()
			{
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x2867C0C", Offset = "0x2863C0C", VA = "0x2867C0C", Slot = "4")]
			public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x2867D48", Offset = "0x2863D48", VA = "0x2867D48", Slot = "5")]
			public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object s_defaultValue;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private object[] _values;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool _implementsIXmlSerializable;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object s_tempAssemblyCacheLock;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly XmlSerializerFactory s_serializerFactory;

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x2862534", Offset = "0x285E534", VA = "0x2862534")]
		internal ObjectStorage(DataColumn column, Type type)
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x28628F8", Offset = "0x285E8F8", VA = "0x28628F8", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x2862928", Offset = "0x285E928", VA = "0x2862928", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x2862F98", Offset = "0x285EF98", VA = "0x2862F98", Slot = "6")]
		public override int CompareValueTo(int recordNo1, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x286317C", Offset = "0x285F17C", VA = "0x286317C")]
		private int CompareTo(object valueNo1, object valueNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x2862AD8", Offset = "0x285EAD8", VA = "0x2862AD8")]
		private int CompareWithFamilies(object valueNo1, object valueNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x28633F8", Offset = "0x285F3F8", VA = "0x28633F8", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x2863470", Offset = "0x285F470", VA = "0x2863470", Slot = "9")]
		public override object Get(int recordNo)
		{
			return null;
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x28632EC", Offset = "0x285F2EC", VA = "0x28632EC")]
		private Families GetFamily(Type dataType)
		{
			return default(Families);
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x28634AC", Offset = "0x285F4AC", VA = "0x28634AC", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x28634E4", Offset = "0x285F4E4", VA = "0x28634E4", Slot = "12")]
		public override void Set(int recordNo, object value)
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x2863CF0", Offset = "0x285FCF0", VA = "0x2863CF0", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x2863DA8", Offset = "0x285FDA8", VA = "0x2863DA8", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x2864318", Offset = "0x2860318", VA = "0x2864318", Slot = "15")]
		public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			return null;
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x2866E8C", Offset = "0x2862E8C", VA = "0x2866E8C", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x2867424", Offset = "0x2863424", VA = "0x2867424", Slot = "17")]
		public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x2867588", Offset = "0x2863588", VA = "0x2867588", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x28675D0", Offset = "0x28635D0", VA = "0x28675D0", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x28677CC", Offset = "0x28637CC", VA = "0x28677CC", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x2867994", Offset = "0x2863994", VA = "0x2867994")]
		internal static void VerifyIDynamicMetaObjectProvider(Type type)
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x28642A4", Offset = "0x28602A4", VA = "0x28642A4")]
		internal static XmlSerializer GetXmlSerializer(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x28668E8", Offset = "0x28628E8", VA = "0x28668E8")]
		internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C1")]
	internal static class ADP
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Type s_stackOverflowType;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Type s_outOfMemoryType;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Type s_threadAbortType;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly Type s_nullReferenceType;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly Type s_accessViolationType;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly Type s_securityType;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal static readonly string StrEmpty;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal static readonly string[] AzureSqlServerEndpoints;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal static readonly IntPtr PtrZero;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal static readonly int PtrSize;

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x2867E2C", Offset = "0x2863E2C", VA = "0x2867E2C")]
		private static void TraceException(string trace, Exception e)
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x2867EC4", Offset = "0x2863EC4", VA = "0x2867EC4")]
		internal static void TraceExceptionAsReturnValue(Exception e)
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x2867F30", Offset = "0x2863F30", VA = "0x2867F30")]
		internal static void TraceExceptionWithoutRethrow(Exception e)
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x2867F9C", Offset = "0x2863F9C", VA = "0x2867F9C")]
		internal static ArgumentException Argument(string error)
		{
			return null;
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x285FDB4", Offset = "0x285BDB4", VA = "0x285FDB4")]
		internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName)
		{
			return null;
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x286802C", Offset = "0x286402C", VA = "0x286802C")]
		internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName)
		{
			return null;
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x2867ABC", Offset = "0x2863ABC", VA = "0x2867ABC")]
		internal static InvalidOperationException InvalidOperation(string error)
		{
			return null;
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x28680C4", Offset = "0x28640C4", VA = "0x28680C4")]
		internal static NotSupportedException NotSupported(string error)
		{
			return null;
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x2861118", Offset = "0x285D118", VA = "0x2861118")]
		internal static bool IsCatchableExceptionType(Exception e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x2868154", Offset = "0x2864154", VA = "0x2868154")]
		internal static bool IsCatchableOrSecurityExceptionType(Exception e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x2868328", Offset = "0x2864328", VA = "0x2868328")]
		internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value)
		{
			return null;
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x2861DA8", Offset = "0x285DDA8", VA = "0x2861DA8")]
		internal static Exception InvalidSeekOrigin(string parameterName)
		{
			return null;
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x2868434", Offset = "0x2864434", VA = "0x2868434")]
		internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value)
		{
			return null;
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x28684E4", Offset = "0x28644E4", VA = "0x28684E4")]
		internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value)
		{
			return null;
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x2868594", Offset = "0x2864594", VA = "0x2868594")]
		internal static ArgumentOutOfRangeException InvalidRule(Rule value)
		{
			return null;
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x285EA24", Offset = "0x285AA24", VA = "0x285EA24")]
		internal static Exception WrongType(Type got, Type expected)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C2")]
	internal sealed class BigIntegerStorage : DataStorage
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BigInteger[] _values;

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x2868934", Offset = "0x2864934", VA = "0x2868934")]
		internal BigIntegerStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x2868B08", Offset = "0x2864B08", VA = "0x2868B08", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x2868B38", Offset = "0x2864B38", VA = "0x2868B38", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x2868CA8", Offset = "0x2864CA8", VA = "0x2868CA8", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x2868DF4", Offset = "0x2864DF4", VA = "0x2868DF4")]
		internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x2869564", Offset = "0x2865564", VA = "0x2869564")]
		internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x2869D08", Offset = "0x2865D08", VA = "0x2869D08", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x2869DA8", Offset = "0x2865DA8", VA = "0x2869DA8", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x2869E40", Offset = "0x2865E40", VA = "0x2869E40", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x2869F30", Offset = "0x2865F30", VA = "0x2869F30", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x286A074", Offset = "0x2866074", VA = "0x286A074", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x286A1B0", Offset = "0x28661B0", VA = "0x286A1B0", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x286A260", Offset = "0x2866260", VA = "0x286A260", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x286A350", Offset = "0x2866350", VA = "0x286A350", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x286A398", Offset = "0x2866398", VA = "0x286A398", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x286A49C", Offset = "0x286649C", VA = "0x286A49C", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000C3")]
	internal sealed class BooleanStorage : DataStorage
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool[] _values;

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x286A530", Offset = "0x2866530", VA = "0x286A530")]
		internal BooleanStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x286A624", Offset = "0x2866624", VA = "0x286A624", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x286A9C8", Offset = "0x28669C8", VA = "0x286A9C8", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x286AA88", Offset = "0x2866A88", VA = "0x286AA88", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x286AB9C", Offset = "0x2866B9C", VA = "0x286AB9C", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x286ACEC", Offset = "0x2866CEC", VA = "0x286ACEC", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x286AD40", Offset = "0x2866D40", VA = "0x286AD40", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x286ADDC", Offset = "0x2866DDC", VA = "0x286ADDC", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x286AF68", Offset = "0x2866F68", VA = "0x286AF68", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x286B028", Offset = "0x2867028", VA = "0x286B028", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x286B0B8", Offset = "0x28670B8", VA = "0x286B0B8", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x286B150", Offset = "0x2867150", VA = "0x286B150", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x286B198", Offset = "0x2867198", VA = "0x286B198", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x286B298", Offset = "0x2867298", VA = "0x286B298", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	internal sealed class ByteStorage : DataStorage
	{
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private byte[] _values;

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x286B32C", Offset = "0x286732C", VA = "0x286B32C")]
		internal ByteStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x286B420", Offset = "0x2867420", VA = "0x286B420", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x286BC10", Offset = "0x2867C10", VA = "0x286BC10", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x286BC78", Offset = "0x2867C78", VA = "0x286BC78", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x286BD78", Offset = "0x2867D78", VA = "0x286BD78", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x286BEC8", Offset = "0x2867EC8", VA = "0x286BEC8", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x286BF1C", Offset = "0x2867F1C", VA = "0x286BF1C", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x286BFB8", Offset = "0x2867FB8", VA = "0x286BFB8", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x286C13C", Offset = "0x286813C", VA = "0x286C13C", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x286C1FC", Offset = "0x28681FC", VA = "0x286C1FC", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x286C288", Offset = "0x2868288", VA = "0x286C288", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x286C320", Offset = "0x2868320", VA = "0x286C320", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x286C368", Offset = "0x2868368", VA = "0x286C368", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x286C468", Offset = "0x2868468", VA = "0x286C468", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	internal sealed class CharStorage : DataStorage
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private char[] _values;

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x286C4FC", Offset = "0x28684FC", VA = "0x286C4FC")]
		internal CharStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x286C5F0", Offset = "0x28685F0", VA = "0x286C5F0", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x286C988", Offset = "0x2868988", VA = "0x286C988", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x286CA48", Offset = "0x2868A48", VA = "0x286CA48", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x286CB5C", Offset = "0x2868B5C", VA = "0x286CB5C", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x286CCAC", Offset = "0x2868CAC", VA = "0x286CCAC", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x286CD00", Offset = "0x2868D00", VA = "0x286CD00", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x286CD9C", Offset = "0x2868D9C", VA = "0x286CD9C", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x286CF7C", Offset = "0x2868F7C", VA = "0x286CF7C", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x286D03C", Offset = "0x286903C", VA = "0x286D03C", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x286D0C8", Offset = "0x28690C8", VA = "0x286D0C8", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x286D160", Offset = "0x2869160", VA = "0x286D160", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x286D1A8", Offset = "0x28691A8", VA = "0x286D1A8", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x286D2A8", Offset = "0x28692A8", VA = "0x286D2A8", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000C6")]
	internal enum StorageType
	{
		[Token(Token = "0x4000438")]
		Empty,
		[Token(Token = "0x4000439")]
		Object,
		[Token(Token = "0x400043A")]
		DBNull,
		[Token(Token = "0x400043B")]
		Boolean,
		[Token(Token = "0x400043C")]
		Char,
		[Token(Token = "0x400043D")]
		SByte,
		[Token(Token = "0x400043E")]
		Byte,
		[Token(Token = "0x400043F")]
		Int16,
		[Token(Token = "0x4000440")]
		UInt16,
		[Token(Token = "0x4000441")]
		Int32,
		[Token(Token = "0x4000442")]
		UInt32,
		[Token(Token = "0x4000443")]
		Int64,
		[Token(Token = "0x4000444")]
		UInt64,
		[Token(Token = "0x4000445")]
		Single,
		[Token(Token = "0x4000446")]
		Double,
		[Token(Token = "0x4000447")]
		Decimal,
		[Token(Token = "0x4000448")]
		DateTime,
		[Token(Token = "0x4000449")]
		TimeSpan,
		[Token(Token = "0x400044A")]
		String,
		[Token(Token = "0x400044B")]
		Guid,
		[Token(Token = "0x400044C")]
		ByteArray,
		[Token(Token = "0x400044D")]
		CharArray,
		[Token(Token = "0x400044E")]
		Type,
		[Token(Token = "0x400044F")]
		DateTimeOffset,
		[Token(Token = "0x4000450")]
		BigInteger,
		[Token(Token = "0x4000451")]
		Uri,
		[Token(Token = "0x4000452")]
		SqlBinary,
		[Token(Token = "0x4000453")]
		SqlBoolean,
		[Token(Token = "0x4000454")]
		SqlByte,
		[Token(Token = "0x4000455")]
		SqlBytes,
		[Token(Token = "0x4000456")]
		SqlChars,
		[Token(Token = "0x4000457")]
		SqlDateTime,
		[Token(Token = "0x4000458")]
		SqlDecimal,
		[Token(Token = "0x4000459")]
		SqlDouble,
		[Token(Token = "0x400045A")]
		SqlGuid,
		[Token(Token = "0x400045B")]
		SqlInt16,
		[Token(Token = "0x400045C")]
		SqlInt32,
		[Token(Token = "0x400045D")]
		SqlInt64,
		[Token(Token = "0x400045E")]
		SqlMoney,
		[Token(Token = "0x400045F")]
		SqlSingle,
		[Token(Token = "0x4000460")]
		SqlString
	}
	[Token(Token = "0x20000C7")]
	internal abstract class DataStorage
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Type[] s_storageClassType;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal readonly DataColumn _column;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly DataTable _table;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal readonly Type _dataType;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal readonly StorageType _storageTypeCode;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BitArray _dbNullBits;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly object _defaultValue;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal readonly object _nullValue;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal readonly bool _isCloneable;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		internal readonly bool _isCustomDefinedType;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		internal readonly bool _isStringType;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		internal readonly bool _isValueType;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface;

		[Token(Token = "0x17000178")]
		internal DataSetDateTime DateTimeMode
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x286D3A0", Offset = "0x28693A0", VA = "0x286D3A0")]
			get
			{
				return default(DataSetDateTime);
			}
		}

		[Token(Token = "0x17000179")]
		internal IFormatProvider FormatProvider
		{
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x28633E0", Offset = "0x285F3E0", VA = "0x28633E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x2868A74", Offset = "0x2864A74", VA = "0x2868A74")]
		protected DataStorage(DataColumn column, Type type, object defaultValue, StorageType storageType)
		{
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x286D33C", Offset = "0x286933C", VA = "0x286D33C")]
		protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType)
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x28627F0", Offset = "0x285E7F0", VA = "0x28627F0")]
		protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType)
		{
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x286A9B4", Offset = "0x28669B4", VA = "0x286A9B4", Slot = "4")]
		public virtual object Aggregate(int[] recordNos, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x286D3B8", Offset = "0x28693B8", VA = "0x286D3B8")]
		public object AggregateCount(int[] recordNos)
		{
			return null;
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x2868C44", Offset = "0x2864C44", VA = "0x2868C44")]
		protected int CompareBits(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000ADC")]
		public abstract int Compare(int recordNo1, int recordNo2);

		[Token(Token = "0x6000ADD")]
		public abstract int CompareValueTo(int recordNo1, object value);

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x286D484", Offset = "0x2869484", VA = "0x286D484", Slot = "7")]
		public virtual object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x2869DFC", Offset = "0x2865DFC", VA = "0x2869DFC")]
		protected void CopyBits(int srcRecordNo, int dstRecordNo)
		{
		}

		[Token(Token = "0x6000AE0")]
		public abstract void Copy(int recordNo1, int recordNo2);

		[Token(Token = "0x6000AE1")]
		public abstract object Get(int recordNo);

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x2869EF8", Offset = "0x2865EF8", VA = "0x2869EF8")]
		protected object GetBits(int recordNo)
		{
			return null;
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x286D48C", Offset = "0x286948C", VA = "0x286D48C", Slot = "10")]
		public virtual int GetStringLength(int record)
		{
			return default(int);
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x2868DCC", Offset = "0x2864DCC", VA = "0x2868DCC")]
		protected bool HasValue(int recordNo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x286D494", Offset = "0x2869494", VA = "0x286D494", Slot = "11")]
		public virtual bool IsNull(int recordNo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE6")]
		public abstract void Set(int recordNo, object value);

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x286A058", Offset = "0x2866058", VA = "0x286A058")]
		protected void SetNullBit(int recordNo, bool flag)
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x286A134", Offset = "0x2866134", VA = "0x286A134", Slot = "13")]
		public virtual void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000AE9")]
		public abstract object ConvertXmlToObject(string s);

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x286D4AC", Offset = "0x28694AC", VA = "0x286D4AC", Slot = "15")]
		public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			return null;
		}

		[Token(Token = "0x6000AEB")]
		public abstract string ConvertObjectToXml(object value);

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x286D4EC", Offset = "0x28694EC", VA = "0x286D4EC", Slot = "17")]
		public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x286D528", Offset = "0x2869528", VA = "0x286D528")]
		public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode)
		{
			return null;
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x28626D8", Offset = "0x285E6D8", VA = "0x28626D8")]
		internal static StorageType GetStorageType(Type dataType)
		{
			return default(StorageType);
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x286E500", Offset = "0x286A500", VA = "0x286E500")]
		internal static Type GetTypeStorage(StorageType storageType)
		{
			return null;
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x28673B4", Offset = "0x28633B4", VA = "0x28673B4")]
		internal static bool IsTypeCustomType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x286D348", Offset = "0x2869348", VA = "0x286D348")]
		internal static bool IsTypeCustomType(StorageType typeCode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x286E57C", Offset = "0x286A57C", VA = "0x286E57C")]
		internal static bool IsSqlType(StorageType storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x286E588", Offset = "0x286A588", VA = "0x286E588")]
		public static bool IsSqlType(Type dataType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x286D364", Offset = "0x2869364", VA = "0x286D364")]
		private static bool DetermineIfValueType(StorageType typeCode, Type dataType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x286E684", Offset = "0x286A684", VA = "0x286E684")]
		internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking)
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x286E7D8", Offset = "0x286A7D8", VA = "0x286E7D8")]
		private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType)
		{
			return null;
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x286E990", Offset = "0x286A990", VA = "0x286E990")]
		internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x286EA64", Offset = "0x286AA64", VA = "0x286EA64")]
		public static bool IsObjectNull(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x286EB04", Offset = "0x286AB04", VA = "0x286EB04")]
		public static bool IsObjectSqlNull(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x286EBB8", Offset = "0x286ABB8", VA = "0x286EBB8")]
		internal object GetEmptyStorageInternal(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x286EBC8", Offset = "0x286ABC8", VA = "0x286EBC8")]
		internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x286EBD8", Offset = "0x286ABD8", VA = "0x286EBD8")]
		internal void SetStorageInternal(object store, BitArray nullbits)
		{
		}

		[Token(Token = "0x6000AFD")]
		protected abstract object GetEmptyStorage(int recordCount);

		[Token(Token = "0x6000AFE")]
		protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

		[Token(Token = "0x6000AFF")]
		protected abstract void SetStorage(object store, BitArray nullbits);

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x286EBE8", Offset = "0x286ABE8", VA = "0x286EBE8")]
		protected void SetNullStorage(BitArray nullbits)
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x2864A00", Offset = "0x2860A00", VA = "0x2864A00")]
		internal static Type GetType(string value)
		{
			return null;
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x286EBF0", Offset = "0x286ABF0", VA = "0x286EBF0")]
		internal static string GetQualifiedName(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C8")]
	internal sealed class DateTimeOffsetStorage : DataStorage
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTimeOffset s_defaultValue;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DateTimeOffset[] _values;

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x286E3D0", Offset = "0x286A3D0", VA = "0x286E3D0")]
		internal DateTimeOffsetStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x286F990", Offset = "0x286B990", VA = "0x286F990", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x286FE94", Offset = "0x286BE94", VA = "0x286FE94", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x2870034", Offset = "0x286C034", VA = "0x2870034", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x28701B0", Offset = "0x286C1B0", VA = "0x28701B0", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x2870254", Offset = "0x286C254", VA = "0x2870254", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x28702A8", Offset = "0x286C2A8", VA = "0x28702A8", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x28703C4", Offset = "0x286C3C4", VA = "0x28703C4", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x28704E4", Offset = "0x286C4E4", VA = "0x28704E4", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x28705A4", Offset = "0x286C5A4", VA = "0x28705A4", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x2870630", Offset = "0x286C630", VA = "0x2870630", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x28706CC", Offset = "0x286C6CC", VA = "0x28706CC", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x2870714", Offset = "0x286C714", VA = "0x2870714", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x2870818", Offset = "0x286C818", VA = "0x2870818", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000C9")]
	internal sealed class DateTimeStorage : DataStorage
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTime s_defaultValue;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DateTime[] _values;

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x286E2A8", Offset = "0x286A2A8", VA = "0x286E2A8")]
		internal DateTimeStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x2870924", Offset = "0x286C924", VA = "0x2870924", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x2870DF0", Offset = "0x286CDF0", VA = "0x2870DF0", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x2870F64", Offset = "0x286CF64", VA = "0x2870F64", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x28710CC", Offset = "0x286D0CC", VA = "0x28710CC", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x287121C", Offset = "0x286D21C", VA = "0x287121C", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x2871270", Offset = "0x286D270", VA = "0x2871270", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x2871368", Offset = "0x286D368", VA = "0x2871368", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x28716F8", Offset = "0x286D6F8", VA = "0x28716F8", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x28717B8", Offset = "0x286D7B8", VA = "0x28717B8", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x2871878", Offset = "0x286D878", VA = "0x2871878", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x2871968", Offset = "0x286D968", VA = "0x2871968", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x28719B0", Offset = "0x286D9B0", VA = "0x28719B0", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x2871B10", Offset = "0x286DB10", VA = "0x2871B10", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	internal sealed class DecimalStorage : DataStorage
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly decimal s_defaultValue;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private decimal[] _values;

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x286E16C", Offset = "0x286A16C", VA = "0x286E16C")]
		internal DecimalStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x2871D7C", Offset = "0x286DD7C", VA = "0x2871D7C", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x28729C0", Offset = "0x286E9C0", VA = "0x28729C0", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x2872B38", Offset = "0x286EB38", VA = "0x2872B38", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x2872CA0", Offset = "0x286ECA0", VA = "0x2872CA0", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x2872E48", Offset = "0x286EE48", VA = "0x2872E48", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x2872E9C", Offset = "0x286EE9C", VA = "0x2872E9C", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x2872F7C", Offset = "0x286EF7C", VA = "0x2872F7C", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x2873120", Offset = "0x286F120", VA = "0x2873120", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x28731E0", Offset = "0x286F1E0", VA = "0x28731E0", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x2873294", Offset = "0x286F294", VA = "0x2873294", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x2873330", Offset = "0x286F330", VA = "0x2873330", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x2873378", Offset = "0x286F378", VA = "0x2873378", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x287347C", Offset = "0x286F47C", VA = "0x287347C", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	internal sealed class DoubleStorage : DataStorage
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private double[] _values;

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x286E078", Offset = "0x286A078", VA = "0x286E078")]
		internal DoubleStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x2873510", Offset = "0x286F510", VA = "0x2873510", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x2873C70", Offset = "0x286FC70", VA = "0x2873C70", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x2873CE8", Offset = "0x286FCE8", VA = "0x2873CE8", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x2873DEC", Offset = "0x286FDEC", VA = "0x2873DEC", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x2873F38", Offset = "0x286FF38", VA = "0x2873F38", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x2873F8C", Offset = "0x286FF8C", VA = "0x2873F8C", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x287402C", Offset = "0x287002C", VA = "0x287402C", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x28741B0", Offset = "0x28701B0", VA = "0x28741B0", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x2874270", Offset = "0x2870270", VA = "0x2874270", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x28742F8", Offset = "0x28702F8", VA = "0x28742F8", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x2874394", Offset = "0x2870394", VA = "0x2874394", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x28743DC", Offset = "0x28703DC", VA = "0x28743DC", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x28744DC", Offset = "0x28704DC", VA = "0x28744DC", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000CC")]
	internal sealed class Int16Storage : DataStorage
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private short[] _values;

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x286DD9C", Offset = "0x2869D9C", VA = "0x286DD9C")]
		internal Int16Storage(DataColumn column)
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x2874570", Offset = "0x2870570", VA = "0x2874570", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x2874DD8", Offset = "0x2870DD8", VA = "0x2874DD8", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x2874E34", Offset = "0x2870E34", VA = "0x2874E34", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x2874F20", Offset = "0x2870F20", VA = "0x2874F20", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x2875070", Offset = "0x2871070", VA = "0x2875070", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x28750C4", Offset = "0x28710C4", VA = "0x28750C4", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x2875160", Offset = "0x2871160", VA = "0x2875160", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x28752E8", Offset = "0x28712E8", VA = "0x28752E8", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x28753A8", Offset = "0x28713A8", VA = "0x28753A8", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x2875434", Offset = "0x2871434", VA = "0x2875434", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x28754CC", Offset = "0x28714CC", VA = "0x28754CC", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x2875514", Offset = "0x2871514", VA = "0x2875514", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x2875610", Offset = "0x2871610", VA = "0x2875610", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	internal sealed class Int32Storage : DataStorage
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int[] _values;

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x286DE90", Offset = "0x2869E90", VA = "0x286DE90")]
		internal Int32Storage(DataColumn column)
		{
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x28756A4", Offset = "0x28716A4", VA = "0x28756A4", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x2875F04", Offset = "0x2871F04", VA = "0x2875F04", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x2875F6C", Offset = "0x2871F6C", VA = "0x2875F6C", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x2876058", Offset = "0x2872058", VA = "0x2876058", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x28761A8", Offset = "0x28721A8", VA = "0x28761A8", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x28761FC", Offset = "0x28721FC", VA = "0x28761FC", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x2876298", Offset = "0x2872298", VA = "0x2876298", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x2876420", Offset = "0x2872420", VA = "0x2876420", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x28764E0", Offset = "0x28724E0", VA = "0x28764E0", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x287656C", Offset = "0x287256C", VA = "0x287656C", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x2876604", Offset = "0x2872604", VA = "0x2876604", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x287664C", Offset = "0x287264C", VA = "0x287664C", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x2876748", Offset = "0x2872748", VA = "0x2876748", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	internal sealed class Int64Storage : DataStorage
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long[] _values;

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x286DF84", Offset = "0x2869F84", VA = "0x286DF84")]
		internal Int64Storage(DataColumn column)
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x28767DC", Offset = "0x28727DC", VA = "0x28767DC", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x2877010", Offset = "0x2873010", VA = "0x2877010", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x2877078", Offset = "0x2873078", VA = "0x2877078", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x2877164", Offset = "0x2873164", VA = "0x2877164", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x28772B4", Offset = "0x28732B4", VA = "0x28772B4", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x2877308", Offset = "0x2873308", VA = "0x2877308", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x28773A4", Offset = "0x28733A4", VA = "0x28773A4", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x287752C", Offset = "0x287352C", VA = "0x287752C", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x28775EC", Offset = "0x28735EC", VA = "0x28775EC", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x2877678", Offset = "0x2873678", VA = "0x2877678", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x2877710", Offset = "0x2873710", VA = "0x2877710", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x2877758", Offset = "0x2873758", VA = "0x2877758", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x2877854", Offset = "0x2873854", VA = "0x2877854", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	internal sealed class SByteStorage : DataStorage
	{
		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private sbyte[] _values;

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x286DCA8", Offset = "0x2869CA8", VA = "0x286DCA8")]
		public SByteStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x28778E8", Offset = "0x28738E8", VA = "0x28778E8", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x28780F8", Offset = "0x28740F8", VA = "0x28780F8", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x28781A4", Offset = "0x28741A4", VA = "0x28781A4", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x28782A4", Offset = "0x28742A4", VA = "0x28782A4", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x28783F4", Offset = "0x28743F4", VA = "0x28783F4", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x2878448", Offset = "0x2874448", VA = "0x2878448", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x28784F4", Offset = "0x28744F4", VA = "0x28784F4", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x2878678", Offset = "0x2874678", VA = "0x2878678", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x2878738", Offset = "0x2874738", VA = "0x2878738", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x28787C4", Offset = "0x28747C4", VA = "0x28787C4", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x287885C", Offset = "0x287485C", VA = "0x287885C", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x28788A4", Offset = "0x28748A4", VA = "0x28788A4", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x28789A4", Offset = "0x28749A4", VA = "0x28789A4", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	internal static class SqlConvert
	{
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x2878A38", Offset = "0x2874A38", VA = "0x2878A38")]
		public static SqlByte ConvertToSqlByte(object value)
		{
			return default(SqlByte);
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x2878C14", Offset = "0x2874C14", VA = "0x2878C14")]
		public static SqlInt16 ConvertToSqlInt16(object value)
		{
			return default(SqlInt16);
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x2878EBC", Offset = "0x2874EBC", VA = "0x2878EBC")]
		public static SqlInt32 ConvertToSqlInt32(object value)
		{
			return default(SqlInt32);
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x287928C", Offset = "0x287528C", VA = "0x287928C")]
		public static SqlInt64 ConvertToSqlInt64(object value)
		{
			return default(SqlInt64);
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x2879760", Offset = "0x2875760", VA = "0x2879760")]
		public static SqlDouble ConvertToSqlDouble(object value)
		{
			return default(SqlDouble);
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x2879E08", Offset = "0x2875E08", VA = "0x2879E08")]
		public static SqlDecimal ConvertToSqlDecimal(object value)
		{
			return default(SqlDecimal);
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x287A454", Offset = "0x2876454", VA = "0x287A454")]
		public static SqlSingle ConvertToSqlSingle(object value)
		{
			return default(SqlSingle);
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x287AA78", Offset = "0x2876A78", VA = "0x287AA78")]
		public static SqlMoney ConvertToSqlMoney(object value)
		{
			return default(SqlMoney);
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x287B07C", Offset = "0x287707C", VA = "0x287B07C")]
		public static SqlDateTime ConvertToSqlDateTime(object value)
		{
			return default(SqlDateTime);
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x287B264", Offset = "0x2877264", VA = "0x287B264")]
		public static SqlBoolean ConvertToSqlBoolean(object value)
		{
			return default(SqlBoolean);
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x287B42C", Offset = "0x287742C", VA = "0x287B42C")]
		public static SqlGuid ConvertToSqlGuid(object value)
		{
			return default(SqlGuid);
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x287B608", Offset = "0x2877608", VA = "0x287B608")]
		public static SqlBinary ConvertToSqlBinary(object value)
		{
			return default(SqlBinary);
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x287B7D8", Offset = "0x28777D8", VA = "0x287B7D8")]
		public static SqlString ConvertToSqlString(object value)
		{
			return default(SqlString);
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x287B9B0", Offset = "0x28779B0", VA = "0x287B9B0")]
		public static SqlChars ConvertToSqlChars(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x287BAF8", Offset = "0x2877AF8", VA = "0x287BAF8")]
		public static SqlBytes ConvertToSqlBytes(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x287BC40", Offset = "0x2877C40", VA = "0x287BC40")]
		public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider)
		{
			return default(DateTimeOffset);
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x287BCA8", Offset = "0x2877CA8", VA = "0x287BCA8")]
		public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x287BE84", Offset = "0x2877E84", VA = "0x287BE84")]
		public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x2864B38", Offset = "0x2860B38", VA = "0x2864B38")]
		public static object ChangeTypeForXML(object value, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D1")]
	internal sealed class SqlBinaryStorage : DataStorage
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlBinary[] _values;

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x287CF20", Offset = "0x2878F20", VA = "0x287CF20")]
		public SqlBinaryStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x287D060", Offset = "0x2879060", VA = "0x287D060", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x287D2A4", Offset = "0x28792A4", VA = "0x287D2A4", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x287D340", Offset = "0x2879340", VA = "0x287D340", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x287D3FC", Offset = "0x28793FC", VA = "0x287D3FC", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x287D474", Offset = "0x2879474", VA = "0x287D474", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x287D4B0", Offset = "0x28794B0", VA = "0x287D4B0", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x287D530", Offset = "0x2879530", VA = "0x287D530", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x287D5AC", Offset = "0x28795AC", VA = "0x287D5AC", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x287D5F4", Offset = "0x28795F4", VA = "0x287D5F4", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x287D6AC", Offset = "0x28796AC", VA = "0x287D6AC", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x287D948", Offset = "0x2879948", VA = "0x287D948", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x287DB94", Offset = "0x2879B94", VA = "0x287DB94", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x287DBDC", Offset = "0x2879BDC", VA = "0x287DBDC", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x287DCDC", Offset = "0x2879CDC", VA = "0x287DCDC", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000D2")]
	internal sealed class SqlByteStorage : DataStorage
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlByte[] _values;

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x287DD68", Offset = "0x2879D68", VA = "0x287DD68")]
		public SqlByteStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x287DEA0", Offset = "0x2879EA0", VA = "0x287DEA0", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x287ED18", Offset = "0x287AD18", VA = "0x287ED18", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x287EDB4", Offset = "0x287ADB4", VA = "0x287EDB4", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x287EE70", Offset = "0x287AE70", VA = "0x287EE70", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x287EEE8", Offset = "0x287AEE8", VA = "0x287EEE8", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x287EF24", Offset = "0x287AF24", VA = "0x287EF24", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x287EFA4", Offset = "0x287AFA4", VA = "0x287EFA4", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x287F020", Offset = "0x287B020", VA = "0x287F020", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x287F068", Offset = "0x287B068", VA = "0x287F068", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x287F120", Offset = "0x287B120", VA = "0x287F120", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x287F3BC", Offset = "0x287B3BC", VA = "0x287F3BC", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x287F608", Offset = "0x287B608", VA = "0x287F608", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x287F650", Offset = "0x287B650", VA = "0x287F650", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x287F750", Offset = "0x287B750", VA = "0x287F750", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000D3")]
	internal sealed class SqlBytesStorage : DataStorage
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlBytes[] _values;

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x287F7DC", Offset = "0x287B7DC", VA = "0x287F7DC")]
		public SqlBytesStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x287F8BC", Offset = "0x287B8BC", VA = "0x287F8BC", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x287FAD0", Offset = "0x287BAD0", VA = "0x287FAD0", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x287FAD8", Offset = "0x287BAD8", VA = "0x287FAD8", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x287FAE0", Offset = "0x287BAE0", VA = "0x287FAE0", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x287FB1C", Offset = "0x287BB1C", VA = "0x287FB1C", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x287FB4C", Offset = "0x287BB4C", VA = "0x287FB4C", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x287FB84", Offset = "0x287BB84", VA = "0x287FB84", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x287FC5C", Offset = "0x287BC5C", VA = "0x287FC5C", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x287FD14", Offset = "0x287BD14", VA = "0x287FD14", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x287FFD4", Offset = "0x287BFD4", VA = "0x287FFD4", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x2880220", Offset = "0x287C220", VA = "0x2880220", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x2880268", Offset = "0x287C268", VA = "0x2880268", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x2880368", Offset = "0x287C368", VA = "0x2880368", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	internal sealed class SqlCharsStorage : DataStorage
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlChars[] _values;

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x28803F4", Offset = "0x287C3F4", VA = "0x28803F4")]
		public SqlCharsStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x28804D4", Offset = "0x287C4D4", VA = "0x28804D4", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x28806E8", Offset = "0x287C6E8", VA = "0x28806E8", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x28806F0", Offset = "0x287C6F0", VA = "0x28806F0", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x28806F8", Offset = "0x287C6F8", VA = "0x28806F8", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x2880734", Offset = "0x287C734", VA = "0x2880734", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x2880764", Offset = "0x287C764", VA = "0x2880764", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x288079C", Offset = "0x287C79C", VA = "0x288079C", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x2880874", Offset = "0x287C874", VA = "0x2880874", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x288092C", Offset = "0x287C92C", VA = "0x288092C", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x2880BF8", Offset = "0x287CBF8", VA = "0x2880BF8", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x2880E44", Offset = "0x287CE44", VA = "0x2880E44", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x2880E8C", Offset = "0x287CE8C", VA = "0x2880E8C", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x2880F8C", Offset = "0x287CF8C", VA = "0x2880F8C", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000D5")]
	internal sealed class SqlDateTimeStorage : DataStorage
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlDateTime[] _values;

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x2881018", Offset = "0x287D018", VA = "0x2881018")]
		public SqlDateTimeStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x2881168", Offset = "0x287D168", VA = "0x2881168", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x2881774", Offset = "0x287D774", VA = "0x2881774", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x2881828", Offset = "0x287D828", VA = "0x2881828", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x28818EC", Offset = "0x287D8EC", VA = "0x28818EC", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x2881968", Offset = "0x287D968", VA = "0x2881968", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x28819B8", Offset = "0x287D9B8", VA = "0x28819B8", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x2881A44", Offset = "0x287DA44", VA = "0x2881A44", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x2881AC4", Offset = "0x287DAC4", VA = "0x2881AC4", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x2881B14", Offset = "0x287DB14", VA = "0x2881B14", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x2881BCC", Offset = "0x287DBCC", VA = "0x2881BCC", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x2881E78", Offset = "0x287DE78", VA = "0x2881E78", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x28820C4", Offset = "0x287E0C4", VA = "0x28820C4", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x288210C", Offset = "0x287E10C", VA = "0x288210C", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x2882220", Offset = "0x287E220", VA = "0x2882220", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000D6")]
	internal sealed class SqlDecimalStorage : DataStorage
	{
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlDecimal[] _values;

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x28822AC", Offset = "0x287E2AC", VA = "0x28822AC")]
		public SqlDecimalStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x28823FC", Offset = "0x287E3FC", VA = "0x28823FC", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x2883338", Offset = "0x287F338", VA = "0x2883338", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x288340C", Offset = "0x287F40C", VA = "0x288340C", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x28834E4", Offset = "0x287F4E4", VA = "0x28834E4", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x2883568", Offset = "0x287F568", VA = "0x2883568", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x28835B8", Offset = "0x287F5B8", VA = "0x28835B8", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x288364C", Offset = "0x287F64C", VA = "0x288364C", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x28836CC", Offset = "0x287F6CC", VA = "0x28836CC", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x2883734", Offset = "0x287F734", VA = "0x2883734", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x28837EC", Offset = "0x287F7EC", VA = "0x28837EC", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x2883A98", Offset = "0x287FA98", VA = "0x2883A98", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x2883CE4", Offset = "0x287FCE4", VA = "0x2883CE4", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x2883D2C", Offset = "0x287FD2C", VA = "0x2883D2C", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x2883E50", Offset = "0x287FE50", VA = "0x2883E50", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	internal sealed class SqlDoubleStorage : DataStorage
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlDouble[] _values;

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x2883EDC", Offset = "0x287FEDC", VA = "0x2883EDC")]
		public SqlDoubleStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x288401C", Offset = "0x288001C", VA = "0x288401C", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x2884D70", Offset = "0x2880D70", VA = "0x2884D70", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x2884E14", Offset = "0x2880E14", VA = "0x2884E14", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x2884ED0", Offset = "0x2880ED0", VA = "0x2884ED0", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x2884F48", Offset = "0x2880F48", VA = "0x2884F48", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x2884F84", Offset = "0x2880F84", VA = "0x2884F84", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x2885004", Offset = "0x2881004", VA = "0x2885004", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x2885080", Offset = "0x2881080", VA = "0x2885080", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x28850C8", Offset = "0x28810C8", VA = "0x28850C8", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x2885180", Offset = "0x2881180", VA = "0x2885180", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x288541C", Offset = "0x288141C", VA = "0x288541C", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x2885668", Offset = "0x2881668", VA = "0x2885668", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x28856B0", Offset = "0x28816B0", VA = "0x28856B0", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x28857B8", Offset = "0x28817B8", VA = "0x28857B8", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000D8")]
	internal sealed class SqlGuidStorage : DataStorage
	{
		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlGuid[] _values;

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x2885844", Offset = "0x2881844", VA = "0x2885844")]
		public SqlGuidStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x2885984", Offset = "0x2881984", VA = "0x2885984", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x2885BC8", Offset = "0x2881BC8", VA = "0x2885BC8", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x2885C64", Offset = "0x2881C64", VA = "0x2885C64", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x2885D20", Offset = "0x2881D20", VA = "0x2885D20", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x2885D98", Offset = "0x2881D98", VA = "0x2885D98", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x2885DD4", Offset = "0x2881DD4", VA = "0x2885DD4", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x2885E54", Offset = "0x2881E54", VA = "0x2885E54", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x2885ED0", Offset = "0x2881ED0", VA = "0x2885ED0", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x2885F18", Offset = "0x2881F18", VA = "0x2885F18", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x2885FD0", Offset = "0x2881FD0", VA = "0x2885FD0", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x288626C", Offset = "0x288226C", VA = "0x288626C", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x28864B8", Offset = "0x28824B8", VA = "0x28864B8", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x2886500", Offset = "0x2882500", VA = "0x2886500", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x2886600", Offset = "0x2882600", VA = "0x2886600", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000D9")]
	internal sealed class SqlInt16Storage : DataStorage
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlInt16[] _values;

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x288668C", Offset = "0x288268C", VA = "0x288668C")]
		public SqlInt16Storage(DataColumn column)
		{
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x28867C4", Offset = "0x28827C4", VA = "0x28867C4", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x288763C", Offset = "0x288363C", VA = "0x288763C", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x28876D8", Offset = "0x28836D8", VA = "0x28876D8", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x2887794", Offset = "0x2883794", VA = "0x2887794", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x288780C", Offset = "0x288380C", VA = "0x288780C", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x2887848", Offset = "0x2883848", VA = "0x2887848", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x28878C8", Offset = "0x28838C8", VA = "0x28878C8", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x2887944", Offset = "0x2883944", VA = "0x2887944", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x288798C", Offset = "0x288398C", VA = "0x288798C", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x2887A44", Offset = "0x2883A44", VA = "0x2887A44", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x2887CE0", Offset = "0x2883CE0", VA = "0x2887CE0", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x2887F2C", Offset = "0x2883F2C", VA = "0x2887F2C", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x2887F74", Offset = "0x2883F74", VA = "0x2887F74", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x2888074", Offset = "0x2884074", VA = "0x2888074", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000DA")]
	internal sealed class SqlInt32Storage : DataStorage
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlInt32[] _values;

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x2888100", Offset = "0x2884100", VA = "0x2888100")]
		public SqlInt32Storage(DataColumn column)
		{
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x2888240", Offset = "0x2884240", VA = "0x2888240", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x2889088", Offset = "0x2885088", VA = "0x2889088", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x2889124", Offset = "0x2885124", VA = "0x2889124", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x28891E0", Offset = "0x28851E0", VA = "0x28891E0", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x2889258", Offset = "0x2885258", VA = "0x2889258", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x2889294", Offset = "0x2885294", VA = "0x2889294", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x2889314", Offset = "0x2885314", VA = "0x2889314", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x2889390", Offset = "0x2885390", VA = "0x2889390", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x28893D8", Offset = "0x28853D8", VA = "0x28893D8", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x2889490", Offset = "0x2885490", VA = "0x2889490", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x288972C", Offset = "0x288572C", VA = "0x288972C", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x2889978", Offset = "0x2885978", VA = "0x2889978", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x28899C0", Offset = "0x28859C0", VA = "0x28899C0", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x2889AC0", Offset = "0x2885AC0", VA = "0x2889AC0", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000DB")]
	internal sealed class SqlInt64Storage : DataStorage
	{
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlInt64[] _values;

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x2889B4C", Offset = "0x2885B4C", VA = "0x2889B4C")]
		public SqlInt64Storage(DataColumn column)
		{
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x2889C8C", Offset = "0x2885C8C", VA = "0x2889C8C", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x288AB54", Offset = "0x2886B54", VA = "0x288AB54", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x288ABF8", Offset = "0x2886BF8", VA = "0x288ABF8", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x288ACB4", Offset = "0x2886CB4", VA = "0x288ACB4", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x288AD2C", Offset = "0x2886D2C", VA = "0x288AD2C", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x288AD68", Offset = "0x2886D68", VA = "0x288AD68", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x288ADE8", Offset = "0x2886DE8", VA = "0x288ADE8", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x288AE64", Offset = "0x2886E64", VA = "0x288AE64", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x288AEAC", Offset = "0x2886EAC", VA = "0x288AEAC", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x288AF64", Offset = "0x2886F64", VA = "0x288AF64", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x288B200", Offset = "0x2887200", VA = "0x288B200", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x288B44C", Offset = "0x288744C", VA = "0x288B44C", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x288B494", Offset = "0x2887494", VA = "0x288B494", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x288B59C", Offset = "0x288759C", VA = "0x288B59C", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	internal sealed class SqlMoneyStorage : DataStorage
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlMoney[] _values;

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x288B628", Offset = "0x2887628", VA = "0x288B628")]
		public SqlMoneyStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x288B768", Offset = "0x2887768", VA = "0x288B768", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x288C680", Offset = "0x2888680", VA = "0x288C680", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x288C724", Offset = "0x2888724", VA = "0x288C724", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x288C7E0", Offset = "0x28887E0", VA = "0x288C7E0", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x288C858", Offset = "0x2888858", VA = "0x288C858", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x288C894", Offset = "0x2888894", VA = "0x288C894", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x288C914", Offset = "0x2888914", VA = "0x288C914", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x288C990", Offset = "0x2888990", VA = "0x288C990", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x288C9D8", Offset = "0x28889D8", VA = "0x288C9D8", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x288CA90", Offset = "0x2888A90", VA = "0x288CA90", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x288CD2C", Offset = "0x2888D2C", VA = "0x288CD2C", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x288CF78", Offset = "0x2888F78", VA = "0x288CF78", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x288CFC0", Offset = "0x2888FC0", VA = "0x288CFC0", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x288D0C8", Offset = "0x28890C8", VA = "0x288D0C8", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	internal sealed class SqlSingleStorage : DataStorage
	{
		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlSingle[] _values;

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x288D154", Offset = "0x2889154", VA = "0x288D154")]
		public SqlSingleStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x288D294", Offset = "0x2889294", VA = "0x288D294", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x288E0B0", Offset = "0x288A0B0", VA = "0x288E0B0", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x288E14C", Offset = "0x288A14C", VA = "0x288E14C", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x288E208", Offset = "0x288A208", VA = "0x288E208", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x288E280", Offset = "0x288A280", VA = "0x288E280", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x288E2BC", Offset = "0x288A2BC", VA = "0x288E2BC", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x288E33C", Offset = "0x288A33C", VA = "0x288E33C", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x288E3B8", Offset = "0x288A3B8", VA = "0x288E3B8", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x288E400", Offset = "0x288A400", VA = "0x288E400", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x288E4B8", Offset = "0x288A4B8", VA = "0x288E4B8", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x288E754", Offset = "0x288A754", VA = "0x288E754", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x288E9A0", Offset = "0x288A9A0", VA = "0x288E9A0", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x288E9E8", Offset = "0x288A9E8", VA = "0x288E9E8", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x288EAE8", Offset = "0x288AAE8", VA = "0x288EAE8", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000DE")]
	internal sealed class SqlStringStorage : DataStorage
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlString[] _values;

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x288EB74", Offset = "0x288AB74", VA = "0x288EB74")]
		public SqlStringStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x288ECC0", Offset = "0x288ACC0", VA = "0x288ECC0", Slot = "4")]
		public override object Aggregate(int[] recordNos, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x288F0D0", Offset = "0x288B0D0", VA = "0x288F0D0", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x288F13C", Offset = "0x288B13C", VA = "0x288F13C")]
		public int Compare(SqlString valueNo1, SqlString valueNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x288F278", Offset = "0x288B278", VA = "0x288F278", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x288F33C", Offset = "0x288B33C", VA = "0x288F33C", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x288F3B8", Offset = "0x288B3B8", VA = "0x288F3B8", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x288F404", Offset = "0x288B404", VA = "0x288F404", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x288F48C", Offset = "0x288B48C", VA = "0x288F48C", Slot = "10")]
		public override int GetStringLength(int record)
		{
			return default(int);
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x288F550", Offset = "0x288B550", VA = "0x288F550", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x288F5D0", Offset = "0x288B5D0", VA = "0x288F5D0", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x288F62C", Offset = "0x288B62C", VA = "0x288F62C", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x288F6E4", Offset = "0x288B6E4", VA = "0x288F6E4", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x288F988", Offset = "0x288B988", VA = "0x288F988", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x288FBD4", Offset = "0x288BBD4", VA = "0x288FBD4", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x288FC1C", Offset = "0x288BC1C", VA = "0x288FC1C", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x288FD2C", Offset = "0x288BD2C", VA = "0x288FD2C", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	internal sealed class SqlBooleanStorage : DataStorage
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SqlBoolean[] _values;

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x288FDB8", Offset = "0x288BDB8", VA = "0x288FDB8")]
		public SqlBooleanStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x288FEF0", Offset = "0x288BEF0", VA = "0x288FEF0", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x2890390", Offset = "0x288C390", VA = "0x2890390", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x289042C", Offset = "0x288C42C", VA = "0x289042C", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x28904E8", Offset = "0x288C4E8", VA = "0x28904E8", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x2890560", Offset = "0x288C560", VA = "0x2890560", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x289059C", Offset = "0x288C59C", VA = "0x289059C", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x289061C", Offset = "0x288C61C", VA = "0x289061C", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x2890698", Offset = "0x288C698", VA = "0x2890698", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x28906E0", Offset = "0x288C6E0", VA = "0x28906E0", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x2890798", Offset = "0x288C798", VA = "0x2890798", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x2890A34", Offset = "0x288CA34", VA = "0x2890A34", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x2890C80", Offset = "0x288CC80", VA = "0x2890C80", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x2890CC8", Offset = "0x288CCC8", VA = "0x2890CC8", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x2890DC8", Offset = "0x288CDC8", VA = "0x2890DC8", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	internal sealed class SingleStorage : DataStorage
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] _values;

		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x2890E54", Offset = "0x288CE54", VA = "0x2890E54")]
		public SingleStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x2890F4C", Offset = "0x288CF4C", VA = "0x2890F4C", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x28916CC", Offset = "0x288D6CC", VA = "0x28916CC", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x2891748", Offset = "0x288D748", VA = "0x2891748", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x289184C", Offset = "0x288D84C", VA = "0x289184C", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x2891990", Offset = "0x288D990", VA = "0x2891990", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x28919E8", Offset = "0x288D9E8", VA = "0x28919E8", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x2891A8C", Offset = "0x288DA8C", VA = "0x2891A8C", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x2891C08", Offset = "0x288DC08", VA = "0x2891C08", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x2891CCC", Offset = "0x288DCCC", VA = "0x2891CCC", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x2891D54", Offset = "0x288DD54", VA = "0x2891D54", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x2891DF0", Offset = "0x288DDF0", VA = "0x2891DF0", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x2891E38", Offset = "0x288DE38", VA = "0x2891E38", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x2891F38", Offset = "0x288DF38", VA = "0x2891F38", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000E1")]
	internal sealed class SqlUdtStorage : DataStorage
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private object[] _values;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool _implementsIXmlSerializable;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private readonly bool _implementsIComparable;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ConcurrentDictionary<Type, object> s_typeToNull;

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x2891FCC", Offset = "0x288DFCC", VA = "0x2891FCC")]
		public SqlUdtStorage(DataColumn column, Type type)
		{
		}

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x289214C", Offset = "0x288E14C", VA = "0x289214C")]
		private SqlUdtStorage(DataColumn column, Type type, object nullValue)
		{
		}

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x2892044", Offset = "0x288E044", VA = "0x2892044")]
		internal static object GetStaticNullForUdtType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x28922E0", Offset = "0x288E2E0", VA = "0x28922E0", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x28923E4", Offset = "0x288E3E4", VA = "0x28923E4", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x2892414", Offset = "0x288E414", VA = "0x2892414", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x289244C", Offset = "0x288E44C", VA = "0x289244C", Slot = "6")]
		public override int CompareValueTo(int recordNo1, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x28926D8", Offset = "0x288E6D8", VA = "0x28926D8", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x2892760", Offset = "0x288E760", VA = "0x2892760", Slot = "9")]
		public override object Get(int recordNo)
		{
			return null;
		}

		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x2892790", Offset = "0x288E790", VA = "0x2892790", Slot = "12")]
		public override void Set(int recordNo, object value)
		{
		}

		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x28928E0", Offset = "0x288E8E0", VA = "0x28928E0", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x28929A4", Offset = "0x288E9A4", VA = "0x28929A4", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x2892CA8", Offset = "0x288ECA8", VA = "0x2892CA8", Slot = "15")]
		public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			return null;
		}

		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x2892F44", Offset = "0x288EF44", VA = "0x2892F44", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x289320C", Offset = "0x288F20C", VA = "0x289320C", Slot = "17")]
		public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x2893364", Offset = "0x288F364", VA = "0x2893364", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x28933AC", Offset = "0x288F3AC", VA = "0x28933AC", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x28934E4", Offset = "0x288F4E4", VA = "0x28934E4", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000E3")]
	internal sealed class StringStorage : DataStorage
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string[] _values;

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x2893724", Offset = "0x288F724", VA = "0x2893724")]
		public StringStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x2893808", Offset = "0x288F808", VA = "0x2893808", Slot = "4")]
		public override object Aggregate(int[] recordNos, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x2893AF0", Offset = "0x288FAF0", VA = "0x2893AF0", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x2893B64", Offset = "0x288FB64", VA = "0x2893B64", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x2893C38", Offset = "0x288FC38", VA = "0x2893C38", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x2893C60", Offset = "0x288FC60", VA = "0x2893C60", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x2893C9C", Offset = "0x288FC9C", VA = "0x2893C9C", Slot = "9")]
		public override object Get(int recordNo)
		{
			return null;
		}

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x2893CD8", Offset = "0x288FCD8", VA = "0x2893CD8", Slot = "10")]
		public override int GetStringLength(int record)
		{
			return default(int);
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x2893D18", Offset = "0x288FD18", VA = "0x2893D18", Slot = "11")]
		public override bool IsNull(int record)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x2893D50", Offset = "0x288FD50", VA = "0x2893D50", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x2893DC4", Offset = "0x288FDC4", VA = "0x2893DC4", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x2893E7C", Offset = "0x288FE7C", VA = "0x2893E7C", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x2893E84", Offset = "0x288FE84", VA = "0x2893E84", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x2893EE4", Offset = "0x288FEE4", VA = "0x2893EE4", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x2893F2C", Offset = "0x288FF2C", VA = "0x2893F2C", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x289402C", Offset = "0x289002C", VA = "0x289402C", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000E4")]
	internal sealed class TimeSpanStorage : DataStorage
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly TimeSpan s_defaultValue;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TimeSpan[] _values;

		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x28940B8", Offset = "0x28900B8", VA = "0x28940B8")]
		public TimeSpanStorage(DataColumn column)
		{
		}

		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0x28941E4", Offset = "0x28901E4", VA = "0x28941E4", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x2894E30", Offset = "0x2890E30", VA = "0x2894E30", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x2894FA8", Offset = "0x2890FA8", VA = "0x2894FA8", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x2895118", Offset = "0x2891118", VA = "0x2895118")]
		private static TimeSpan ConvertToTimeSpan(object value)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x289533C", Offset = "0x289133C", VA = "0x289533C", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x28953E8", Offset = "0x28913E8", VA = "0x28953E8", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x2895440", Offset = "0x2891440", VA = "0x2895440", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x2895540", Offset = "0x2891540", VA = "0x2895540", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x2895620", Offset = "0x2891620", VA = "0x2895620", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x28956E4", Offset = "0x28916E4", VA = "0x28956E4", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x2895770", Offset = "0x2891770", VA = "0x2895770", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x2895808", Offset = "0x2891808", VA = "0x2895808", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x2895850", Offset = "0x2891850", VA = "0x2895850", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x2895950", Offset = "0x2891950", VA = "0x2895950", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000E5")]
	internal sealed class UInt16Storage : DataStorage
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ushort s_defaultValue;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ushort[] _values;

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x2895A5C", Offset = "0x2891A5C", VA = "0x2895A5C")]
		public UInt16Storage(DataColumn column)
		{
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x2895B74", Offset = "0x2891B74", VA = "0x2895B74", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x28963F8", Offset = "0x28923F8", VA = "0x28963F8", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x28964B0", Offset = "0x28924B0", VA = "0x28964B0", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x28965C8", Offset = "0x28925C8", VA = "0x28965C8", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x2896710", Offset = "0x2892710", VA = "0x2896710", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x2896768", Offset = "0x2892768", VA = "0x2896768", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x2896834", Offset = "0x2892834", VA = "0x2896834", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x28969CC", Offset = "0x28929CC", VA = "0x28969CC", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x2896A90", Offset = "0x2892A90", VA = "0x2896A90", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x2896B1C", Offset = "0x2892B1C", VA = "0x2896B1C", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x2896BB4", Offset = "0x2892BB4", VA = "0x2896BB4", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x2896BFC", Offset = "0x2892BFC", VA = "0x2896BFC", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x2896CFC", Offset = "0x2892CFC", VA = "0x2896CFC", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000E6")]
	internal sealed class UInt32Storage : DataStorage
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly uint s_defaultValue;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private uint[] _values;

		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x2896D90", Offset = "0x2892D90", VA = "0x2896D90")]
		public UInt32Storage(DataColumn column)
		{
		}

		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x2896EA8", Offset = "0x2892EA8", VA = "0x2896EA8", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x2897730", Offset = "0x2893730", VA = "0x2897730", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x28977F8", Offset = "0x28937F8", VA = "0x28977F8", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x2897910", Offset = "0x2893910", VA = "0x2897910", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x2897A58", Offset = "0x2893A58", VA = "0x2897A58", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x2897AB0", Offset = "0x2893AB0", VA = "0x2897AB0", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x2897B7C", Offset = "0x2893B7C", VA = "0x2897B7C", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x2897D14", Offset = "0x2893D14", VA = "0x2897D14", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x2897DD8", Offset = "0x2893DD8", VA = "0x2897DD8", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x2897E64", Offset = "0x2893E64", VA = "0x2897E64", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x2897EFC", Offset = "0x2893EFC", VA = "0x2897EFC", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x2897F44", Offset = "0x2893F44", VA = "0x2897F44", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x2898044", Offset = "0x2894044", VA = "0x2898044", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
	[Token(Token = "0x20000E7")]
	internal sealed class UInt64Storage : DataStorage
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ulong s_defaultValue;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ulong[] _values;

		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x28980D8", Offset = "0x28940D8", VA = "0x28980D8")]
		public UInt64Storage(DataColumn column)
		{
		}

		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x28981F0", Offset = "0x28941F0", VA = "0x28981F0", Slot = "4")]
		public override object Aggregate(int[] records, AggregateType kind)
		{
			return null;
		}

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x2898A64", Offset = "0x2894A64", VA = "0x2898A64", Slot = "5")]
		public override int Compare(int recordNo1, int recordNo2)
		{
			return default(int);
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x2898B60", Offset = "0x2894B60", VA = "0x2898B60", Slot = "6")]
		public override int CompareValueTo(int recordNo, object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x2898C78", Offset = "0x2894C78", VA = "0x2898C78", Slot = "7")]
		public override object ConvertValue(object value)
		{
			return null;
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x2898DC0", Offset = "0x2894DC0", VA = "0x2898DC0", Slot = "8")]
		public override void Copy(int recordNo1, int recordNo2)
		{
		}

		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x2898E18", Offset = "0x2894E18", VA = "0x2898E18", Slot = "9")]
		public override object Get(int record)
		{
			return null;
		}

		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x2898EE4", Offset = "0x2894EE4", VA = "0x2898EE4", Slot = "12")]
		public override void Set(int record, object value)
		{
		}

		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x289907C", Offset = "0x289507C", VA = "0x289907C", Slot = "13")]
		public override void SetCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x2899140", Offset = "0x2895140", VA = "0x2899140", Slot = "14")]
		public override object ConvertXmlToObject(string s)
		{
			return null;
		}

		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x28991CC", Offset = "0x28951CC", VA = "0x28991CC", Slot = "16")]
		public override string ConvertObjectToXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x2899264", Offset = "0x2895264", VA = "0x2899264", Slot = "18")]
		protected override object GetEmptyStorage(int recordCount)
		{
			return null;
		}

		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x28992AC", Offset = "0x28952AC", VA = "0x28992AC", Slot = "19")]
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x28993AC", Offset = "0x28953AC", VA = "0x28993AC", Slot = "20")]
		protected override void SetStorage(object store, BitArray nullbits)
		{
		}
	}
}
