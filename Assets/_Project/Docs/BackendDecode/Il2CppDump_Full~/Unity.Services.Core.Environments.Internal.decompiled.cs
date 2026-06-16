using System.Reflection;
using Il2CppDummyDll;
using Unity.Services.Core.Internal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Services.Core.Environments.Internal;

[Token(Token = "0x2000002")]
internal class Environments : IEnvironments, IServiceComponent
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	private string m_Current;

	[Token(Token = "0x17000001")]
	public string Current
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2DA3EEC", Offset = "0x2D9FEEC", VA = "0x2DA3EEC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2DA3EF4", Offset = "0x2D9FEF4", VA = "0x2DA3EF4")]
		internal set
		{
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2DA3EFC", Offset = "0x2D9FEFC", VA = "0x2DA3EFC")]
	public Environments()
	{
	}
}
