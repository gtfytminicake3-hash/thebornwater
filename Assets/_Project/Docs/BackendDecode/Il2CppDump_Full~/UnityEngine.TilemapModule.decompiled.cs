using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Bindings;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.Tilemaps;

[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[UnityEngine.Bindings.NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
[UnityEngine.Bindings.NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[UnityEngine.Bindings.NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
[RequireComponent(typeof(Transform))]
[UnityEngine.Bindings.NativeHeader("Modules/Grid/Public/Grid.h")]
[UnityEngine.Bindings.NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
public sealed class Tilemap : GridLayout
{
}
[Token(Token = "0x2000003")]
[UnityEngine.Bindings.NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
[UnityEngine.Bindings.NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[UnityEngine.Bindings.NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[RequireComponent(typeof(Tilemap))]
[UnityEngine.Bindings.NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
public sealed class TilemapRenderer : Renderer
{
}
