using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Bindings;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[Token(Token = "0x2000002")]
[RequireComponent(typeof(Transform))]
[UnityEngine.Bindings.NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[UnityEngine.Bindings.NativeType(Header = "Modules/Grid/Public/Grid.h")]
public class GridLayout : Behaviour
{
}
