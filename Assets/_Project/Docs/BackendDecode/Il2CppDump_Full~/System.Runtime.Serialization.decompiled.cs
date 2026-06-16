using System.Reflection;
using Il2CppDummyDll;

[assembly: AssemblyVersion("4.0.0.0")]
namespace System.Runtime.Serialization;

[Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
public sealed class DataContractAttribute : Attribute
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	private bool isReference;

	[Token(Token = "0x17000001")]
	public bool IsReference
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x28A8DA4", Offset = "0x28A4DA4", VA = "0x28A8DA4")]
		get
		{
			return default(bool);
		}
	}
}
[Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class DataMemberAttribute : Attribute
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x10")]
	private string name;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x18")]
	private int order;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x1C")]
	private bool isRequired;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x1D")]
	private bool emitDefaultValue;

	[Token(Token = "0x17000002")]
	public string Name
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x28A8DAC", Offset = "0x28A4DAC", VA = "0x28A8DAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public int Order
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x28A8DB4", Offset = "0x28A4DB4", VA = "0x28A8DB4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000004")]
	public bool IsRequired
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x28A8DBC", Offset = "0x28A4DBC", VA = "0x28A8DBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000005")]
	public bool EmitDefaultValue
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x28A8DC4", Offset = "0x28A4DC4", VA = "0x28A8DC4")]
		get
		{
			return default(bool);
		}
	}
}
[Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class EnumMemberAttribute : Attribute
{
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x10")]
	private string value;

	[Token(Token = "0x17000006")]
	public string Value
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x28A8DCC", Offset = "0x28A4DCC", VA = "0x28A8DCC")]
		get
		{
			return null;
		}
	}
}
[Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class IgnoreDataMemberAttribute : Attribute
{
}
