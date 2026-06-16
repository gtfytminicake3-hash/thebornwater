using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[Token(Token = "0x2000002")]
public interface ICanvasRaycastFilter
{
	[Token(Token = "0x6000001")]
	bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
}
[Token(Token = "0x2000003")]
[UnityEngine.Bindings.NativeHeader("Modules/UI/CanvasGroup.h")]
[UnityEngine.NativeClass("UI::CanvasGroup")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x17000001")]
	[UnityEngine.Bindings.NativeProperty("Alpha", false, UnityEngine.Bindings.TargetType.Function)]
	public extern float alpha
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x300B0C0", Offset = "0x30070C0", VA = "0x300B0C0")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x300B0FC", Offset = "0x30070FC", VA = "0x300B0FC")]
		set;
	}

	[Token(Token = "0x17000002")]
	[UnityEngine.Bindings.NativeProperty("Interactable", false, UnityEngine.Bindings.TargetType.Function)]
	public extern bool interactable
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x300B148", Offset = "0x3007148", VA = "0x300B148")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x300B184", Offset = "0x3007184", VA = "0x300B184")]
		set;
	}

	[Token(Token = "0x17000003")]
	[UnityEngine.Bindings.NativeProperty("BlocksRaycasts", false, UnityEngine.Bindings.TargetType.Function)]
	public extern bool blocksRaycasts
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x300B1C8", Offset = "0x30071C8", VA = "0x300B1C8")]
		get;
	}

	[Token(Token = "0x17000004")]
	[UnityEngine.Bindings.NativeProperty("IgnoreParentGroups", false, UnityEngine.Bindings.TargetType.Function)]
	public extern bool ignoreParentGroups
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x300B204", Offset = "0x3007204", VA = "0x300B204")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x300B240", Offset = "0x3007240", VA = "0x300B240")]
		set;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x300B284", Offset = "0x3007284", VA = "0x300B284", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x300B2C0", Offset = "0x30072C0", VA = "0x300B2C0")]
	public CanvasGroup()
	{
	}
}
[Token(Token = "0x2000004")]
[UnityEngine.Bindings.NativeHeader("Modules/UI/CanvasRenderer.h")]
[UnityEngine.NativeClass("UI::CanvasRenderer")]
public sealed class CanvasRenderer : Component
{
	[Token(Token = "0x17000005")]
	public extern bool hasPopInstruction
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x300B2C8", Offset = "0x30072C8", VA = "0x300B2C8")]
		set;
	}

	[Token(Token = "0x17000006")]
	public extern int materialCount
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x300B30C", Offset = "0x300730C", VA = "0x300B30C")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x300B348", Offset = "0x3007348", VA = "0x300B348")]
		set;
	}

	[Token(Token = "0x17000007")]
	public extern int popMaterialCount
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x300B38C", Offset = "0x300738C", VA = "0x300B38C")]
		set;
	}

	[Token(Token = "0x17000008")]
	public extern int absoluteDepth
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x300B3D0", Offset = "0x30073D0", VA = "0x300B3D0")]
		get;
	}

	[Token(Token = "0x17000009")]
	public extern bool hasMoved
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x300B40C", Offset = "0x300740C", VA = "0x300B40C")]
		get;
	}

	[Token(Token = "0x1700000A")]
	[UnityEngine.Bindings.NativeProperty("ShouldCull", false, UnityEngine.Bindings.TargetType.Function)]
	public extern bool cull
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x300B448", Offset = "0x3007448", VA = "0x300B448")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x300B484", Offset = "0x3007484", VA = "0x300B484")]
		set;
	}

	[Token(Token = "0x1700000B")]
	public Vector2 clippingSoftness
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x300B694", Offset = "0x3007694", VA = "0x300B694")]
		set
		{
		}
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x300B4C8", Offset = "0x30074C8", VA = "0x300B4C8")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x300B560", Offset = "0x3007560", VA = "0x300B560")]
	public Color GetColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x300B5FC", Offset = "0x30075FC", VA = "0x300B5FC")]
	public void EnableRectClipping(Rect rect)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x300B720", Offset = "0x3007720", VA = "0x300B720")]
	public extern void DisableRectClipping();

	[MethodImpl(4096)]
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x300B75C", Offset = "0x300775C", VA = "0x300B75C")]
	public extern void SetMaterial(Material material, int index);

	[MethodImpl(4096)]
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x300B7B0", Offset = "0x30077B0", VA = "0x300B7B0")]
	public extern void SetPopMaterial(Material material, int index);

	[MethodImpl(4096)]
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x300B804", Offset = "0x3007804", VA = "0x300B804")]
	public extern void SetTexture(Texture texture);

	[MethodImpl(4096)]
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x300B848", Offset = "0x3007848", VA = "0x300B848")]
	public extern void SetAlphaTexture(Texture texture);

	[MethodImpl(4096)]
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x300B88C", Offset = "0x300788C", VA = "0x300B88C")]
	public extern void SetMesh(Mesh mesh);

	[MethodImpl(4096)]
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x300B8D0", Offset = "0x30078D0", VA = "0x300B8D0")]
	public extern void Clear();

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x300B90C", Offset = "0x300790C", VA = "0x300B90C")]
	public void SetMaterial(Material material, Texture texture)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x300BA34", Offset = "0x3007A34", VA = "0x300BA34")]
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x300BBE4", Offset = "0x3007BE4", VA = "0x300BBE4")]
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x300BD1C", Offset = "0x3007D1C", VA = "0x300BD1C")]
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x300BBA0", Offset = "0x3007BA0", VA = "0x300BBA0")]
	[UnityEngine.Bindings.StaticAccessor("UI", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	private static extern void SplitIndicesStreamsInternal(object verts, object indices);

	[MethodImpl(4096)]
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x300BB04", Offset = "0x3007B04", VA = "0x300BB04")]
	[UnityEngine.Bindings.StaticAccessor("UI", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	private static extern void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents);

	[MethodImpl(4096)]
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x300BC80", Offset = "0x3007C80", VA = "0x300BC80")]
	[UnityEngine.Bindings.StaticAccessor("UI", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	private static extern void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices);

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x300BDB8", Offset = "0x3007DB8", VA = "0x300BDB8")]
	public CanvasRenderer()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x300B51C", Offset = "0x300751C", VA = "0x300B51C")]
	private extern void SetColor_Injected(ref Color color);

	[MethodImpl(4096)]
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x300B5B8", Offset = "0x30075B8", VA = "0x300B5B8")]
	private extern void GetColor_Injected(out Color ret);

	[MethodImpl(4096)]
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x300B650", Offset = "0x3007650", VA = "0x300B650")]
	private extern void EnableRectClipping_Injected(ref Rect rect);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x300B6DC", Offset = "0x30076DC", VA = "0x300B6DC")]
	private extern void set_clippingSoftness_Injected(ref Vector2 value);
}
[Token(Token = "0x2000005")]
[UnityEngine.Bindings.NativeHeader("Runtime/Camera/Camera.h")]
[UnityEngine.Bindings.NativeHeader("Modules/UI/Canvas.h")]
[UnityEngine.Bindings.NativeHeader("Modules/UI/RectTransformUtil.h")]
[UnityEngine.Bindings.StaticAccessor("UI", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
[UnityEngine.Bindings.NativeHeader("Runtime/Transform/RectTransform.h")]
public sealed class RectTransformUtility
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3[] s_Corners;

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x300BDC0", Offset = "0x3007DC0", VA = "0x300BDC0")]
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x300BEC0", Offset = "0x3007EC0", VA = "0x300BEC0")]
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas)
	{
		return default(Rect);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x300BFB4", Offset = "0x3007FB4", VA = "0x300BFB4")]
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset)
	{
		return default(bool);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x300C0B8", Offset = "0x30080B8", VA = "0x300C0B8")]
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam)
	{
		return default(bool);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x300C18C", Offset = "0x300818C", VA = "0x300C18C")]
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset)
	{
		return default(bool);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x300C238", Offset = "0x3008238", VA = "0x300C238")]
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x300C824", Offset = "0x3008824", VA = "0x300C824")]
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint)
	{
		return default(bool);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x300C650", Offset = "0x3008650", VA = "0x300C650")]
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos)
	{
		return default(Ray);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x300C920", Offset = "0x3008920", VA = "0x300C920")]
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x300C9D0", Offset = "0x30089D0", VA = "0x300C9D0")]
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x300CCBC", Offset = "0x3008CBC", VA = "0x300CCBC")]
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x300CF18", Offset = "0x3008F18", VA = "0x300CF18")]
	private static Vector2 GetTransposed(Vector2 input)
	{
		return default(Vector2);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x300BE64", Offset = "0x3007E64", VA = "0x300BE64")]
	private static extern void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret);

	[MethodImpl(4096)]
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x300BF60", Offset = "0x3007F60", VA = "0x300BF60")]
	private static extern void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret);

	[MethodImpl(4096)]
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x300C05C", Offset = "0x300805C", VA = "0x300C05C")]
	private static extern bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset);
}
[Token(Token = "0x2000006")]
public enum RenderMode
{
	[Token(Token = "0x4000004")]
	ScreenSpaceOverlay,
	[Token(Token = "0x4000005")]
	ScreenSpaceCamera,
	[Token(Token = "0x4000006")]
	WorldSpace
}
[Token(Token = "0x2000007")]
[UnityEngine.NativeClass("UI::Canvas")]
[UnityEngine.Bindings.NativeHeader("Modules/UI/CanvasManager.h")]
[UnityEngine.Bindings.NativeHeader("Modules/UI/UIStructs.h")]
[RequireComponent(typeof(RectTransform))]
[UnityEngine.Bindings.NativeHeader("Modules/UI/Canvas.h")]
public sealed class Canvas : Behaviour
{
	[Token(Token = "0x2000008")]
	public delegate void WillRenderCanvases();

	[Token(Token = "0x1700000C")]
	public extern RenderMode renderMode
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x300D278", Offset = "0x3009278", VA = "0x300D278")]
		get;
	}

	[Token(Token = "0x1700000D")]
	public extern bool isRootCanvas
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x300D2B4", Offset = "0x30092B4", VA = "0x300D2B4")]
		get;
	}

	[Token(Token = "0x1700000E")]
	public extern float scaleFactor
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x300D2F0", Offset = "0x30092F0", VA = "0x300D2F0")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x300D32C", Offset = "0x300932C", VA = "0x300D32C")]
		set;
	}

	[Token(Token = "0x1700000F")]
	public extern float referencePixelsPerUnit
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x300D378", Offset = "0x3009378", VA = "0x300D378")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x300D3B4", Offset = "0x30093B4", VA = "0x300D3B4")]
		set;
	}

	[Token(Token = "0x17000010")]
	public extern bool pixelPerfect
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x300D400", Offset = "0x3009400", VA = "0x300D400")]
		get;
	}

	[Token(Token = "0x17000011")]
	public extern int renderOrder
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x300D43C", Offset = "0x300943C", VA = "0x300D43C")]
		get;
	}

	[Token(Token = "0x17000012")]
	public extern bool overrideSorting
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x300D478", Offset = "0x3009478", VA = "0x300D478")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x300D4B4", Offset = "0x30094B4", VA = "0x300D4B4")]
		set;
	}

	[Token(Token = "0x17000013")]
	public extern int sortingOrder
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x300D4F8", Offset = "0x30094F8", VA = "0x300D4F8")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x300D534", Offset = "0x3009534", VA = "0x300D534")]
		set;
	}

	[Token(Token = "0x17000014")]
	public extern int targetDisplay
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x300D578", Offset = "0x3009578", VA = "0x300D578")]
		get;
	}

	[Token(Token = "0x17000015")]
	public extern int sortingLayerID
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x300D5B4", Offset = "0x30095B4", VA = "0x300D5B4")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x300D5F0", Offset = "0x30095F0", VA = "0x300D5F0")]
		set;
	}

	[Token(Token = "0x17000016")]
	public extern Canvas rootCanvas
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x300D634", Offset = "0x3009634", VA = "0x300D634")]
		get;
	}

	[Token(Token = "0x17000017")]
	public Vector2 renderingDisplaySize
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x300D670", Offset = "0x3009670", VA = "0x300D670")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000018")]
	internal static Action<int> externBeginRenderOverlays
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x300D700", Offset = "0x3009700", VA = "0x300D700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x300D748", Offset = "0x3009748", VA = "0x300D748")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	internal static Action<int, int> externRenderOverlaysBefore
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x300D794", Offset = "0x3009794", VA = "0x300D794")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x300D7DC", Offset = "0x30097DC", VA = "0x300D7DC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	internal static Action<int> externEndRenderOverlays
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x300D828", Offset = "0x3009828", VA = "0x300D828")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x300D870", Offset = "0x3009870", VA = "0x300D870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	[UnityEngine.Bindings.NativeProperty("Camera", false, UnityEngine.Bindings.TargetType.Function)]
	public extern Camera worldCamera
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x300D8F8", Offset = "0x30098F8", VA = "0x300D8F8")]
		get;
	}

	[Token(Token = "0x14000001")]
	public static event WillRenderCanvases preWillRenderCanvases
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x300CF90", Offset = "0x3008F90", VA = "0x300CF90")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x300D048", Offset = "0x3009048", VA = "0x300D048")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event WillRenderCanvases willRenderCanvases
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x300D100", Offset = "0x3009100", VA = "0x300D100")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x300D1BC", Offset = "0x30091BC", VA = "0x300D1BC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x300D8BC", Offset = "0x30098BC", VA = "0x300D8BC")]
	[UnityEngine.Bindings.FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	internal static extern void SetExternalCanvasEnabled(bool enabled);

	[MethodImpl(4096)]
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x300D934", Offset = "0x3009934", VA = "0x300D934")]
	[UnityEngine.Bindings.FreeFunction("UI::GetDefaultUIMaterial")]
	public static extern Material GetDefaultCanvasMaterial();

	[MethodImpl(4096)]
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x300D95C", Offset = "0x300995C", VA = "0x300D95C")]
	[UnityEngine.Bindings.FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	public static extern Material GetETC1SupportedCanvasMaterial();

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x300D984", Offset = "0x3009984", VA = "0x300D984")]
	public static void ForceUpdateCanvases()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x300D994", Offset = "0x3009994", VA = "0x300D994")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void SendPreWillRenderCanvases()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x300D9F8", Offset = "0x30099F8", VA = "0x300D9F8")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void SendWillRenderCanvases()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x300DA5C", Offset = "0x3009A5C", VA = "0x300DA5C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void BeginRenderExtraOverlays(int displayIndex)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x300DAC8", Offset = "0x3009AC8", VA = "0x300DAC8")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x300DB3C", Offset = "0x3009B3C", VA = "0x300DB3C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void EndRenderExtraOverlays(int displayIndex)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x300DBA8", Offset = "0x3009BA8", VA = "0x300DBA8")]
	public Canvas()
	{
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x300D6BC", Offset = "0x30096BC", VA = "0x300D6BC")]
	private extern void get_renderingDisplaySize_Injected(out Vector2 ret);
}
[Token(Token = "0x2000009")]
[IgnoredByDeepProfiler]
[UnityEngine.Bindings.NativeHeader("Modules/UI/Canvas.h")]
[UnityEngine.Bindings.StaticAccessor("UI::SystemProfilerApi", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
public static class UISystemProfilerApi
{
	[Token(Token = "0x200000A")]
	public enum SampleType
	{
		[Token(Token = "0x400000D")]
		Layout,
		[Token(Token = "0x400000E")]
		Render
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x300DC4C", Offset = "0x3009C4C", VA = "0x300DC4C")]
	public static extern void BeginSample(SampleType type);

	[MethodImpl(4096)]
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x300DC88", Offset = "0x3009C88", VA = "0x300DC88")]
	public static extern void EndSample(SampleType type);

	[MethodImpl(4096)]
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x300DCC4", Offset = "0x3009CC4", VA = "0x300DCC4")]
	public static extern void AddMarker(string name, Object obj);
}
