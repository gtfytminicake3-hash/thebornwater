using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

[assembly: AssemblyVersion("4.0.5.0")]
namespace Unity.Burst
{
	[Token(Token = "0x2000002")]
	internal static class Unsafe
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000001")]
		[System.Runtime.Versioning.NonVersionable]
		public unsafe static ref T AsRef<T>(void* source)
		{
			return ref *(T*)null;
		}
	}
}
namespace System.Runtime.Versioning
{
	[Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	internal sealed class NonVersionableAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2B2A4C8", Offset = "0x2B264C8", VA = "0x2B2A4C8")]
		public NonVersionableAttribute()
		{
		}
	}
}
