using System.Reflection;
using Il2CppDummyDll;
using Unity.Services.Core.Internal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Services.Core.Threading.Internal;

[Token(Token = "0x2000002")]
internal class UnityThreadUtilsInternal : IUnityThreadUtils, IServiceComponent
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2DAD6EC", Offset = "0x2DA96EC", VA = "0x2DAD6EC")]
	public UnityThreadUtilsInternal()
	{
	}
}
