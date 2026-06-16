using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[Token(Token = "0x2000002")]
public enum FontStyle
{
	[Token(Token = "0x4000002")]
	Normal,
	[Token(Token = "0x4000003")]
	Bold,
	[Token(Token = "0x4000004")]
	Italic,
	[Token(Token = "0x4000005")]
	BoldAndItalic
}
[Token(Token = "0x2000003")]
[Flags]
internal enum TextGenerationError
{
	[Token(Token = "0x4000007")]
	None = 0,
	[Token(Token = "0x4000008")]
	CustomSizeOnNonDynamicFont = 1,
	[Token(Token = "0x4000009")]
	CustomStyleOnNonDynamicFont = 2,
	[Token(Token = "0x400000A")]
	NoFont = 4
}
[Token(Token = "0x2000004")]
public struct TextGenerationSettings
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Font font;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Color color;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int fontSize;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float lineSpacing;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool richText;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float scaleFactor;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FontStyle fontStyle;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public TextAnchor textAnchor;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool alignByGeometry;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool resizeTextForBestFit;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int resizeTextMinSize;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int resizeTextMaxSize;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool updateBounds;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public VerticalWrapMode verticalOverflow;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public HorizontalWrapMode horizontalOverflow;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector2 generationExtents;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector2 pivot;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool generateOutOfBounds;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2EBA020", Offset = "0x2EB6020", VA = "0x2EBA020")]
	private bool CompareColors(Color left, Color right)
	{
		return default(bool);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2EBA158", Offset = "0x2EB6158", VA = "0x2EBA158")]
	private bool CompareVector2(Vector2 left, Vector2 right)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2EBA220", Offset = "0x2EB6220", VA = "0x2EBA220")]
	public bool Equals(TextGenerationSettings other)
	{
		return default(bool);
	}
}
[StructLayout(0)]
[Token(Token = "0x2000005")]
[UnityEngine.Bindings.NativeHeader("Modules/TextRendering/TextGenerator.h")]
[UnityEngine.Scripting.UsedByNativeCode]
public sealed class TextGenerator : IDisposable
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal IntPtr m_Ptr;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string m_LastString;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TextGenerationSettings m_LastSettings;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool m_HasGenerated;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private TextGenerationError m_LastValid;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly List<UIVertex> m_Verts;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly List<UICharInfo> m_Characters;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly List<UILineInfo> m_Lines;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool m_CachedVerts;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	private bool m_CachedCharacters;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	private bool m_CachedLines;

	[Token(Token = "0x17000001")]
	public int characterCountVisible
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2EBA744", Offset = "0x2EB6744", VA = "0x2EBA744")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000002")]
	public IList<UIVertex> verts
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2EBB2A4", Offset = "0x2EB72A4", VA = "0x2EBB2A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public IList<UICharInfo> characters
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2EBB300", Offset = "0x2EB7300", VA = "0x2EBB300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public IList<UILineInfo> lines
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2EBB35C", Offset = "0x2EB735C", VA = "0x2EBB35C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public Rect rectExtents
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2EBACFC", Offset = "0x2EB6CFC", VA = "0x2EBACFC")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x17000006")]
	public extern int characterCount
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2EBA788", Offset = "0x2EB6788", VA = "0x2EBA788")]
		get;
	}

	[Token(Token = "0x17000007")]
	public extern int lineCount
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2EBB3FC", Offset = "0x2EB73FC", VA = "0x2EBB3FC")]
		get;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2EBA424", Offset = "0x2EB6424", VA = "0x2EBA424")]
	public TextGenerator()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2EBA42C", Offset = "0x2EB642C", VA = "0x2EBA42C")]
	public TextGenerator(int initialCapacity)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2EBA5A0", Offset = "0x2EB65A0", VA = "0x2EBA5A0", Slot = "1")]
	~TextGenerator()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2EBA6AC", Offset = "0x2EB66AC", VA = "0x2EBA6AC", Slot = "4")]
	private void System.IDisposable.Dispose()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2EBA7C4", Offset = "0x2EB67C4", VA = "0x2EBA7C4")]
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings)
	{
		return default(TextGenerationSettings);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2EBAAB0", Offset = "0x2EB6AB0", VA = "0x2EBAAB0")]
	public void Invalidate()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2EBAAB8", Offset = "0x2EB6AB8", VA = "0x2EBAAB8")]
	public void GetCharacters(List<UICharInfo> characters)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2EBAB40", Offset = "0x2EB6B40", VA = "0x2EBAB40")]
	public void GetLines(List<UILineInfo> lines)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2EBABC8", Offset = "0x2EB6BC8", VA = "0x2EBABC8")]
	public void GetVertices(List<UIVertex> vertices)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2EBAC50", Offset = "0x2EB6C50", VA = "0x2EBAC50")]
	public float GetPreferredWidth(string str, TextGenerationSettings settings)
	{
		return default(float);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2EBAD54", Offset = "0x2EB6D54", VA = "0x2EBAD54")]
	public float GetPreferredHeight(string str, TextGenerationSettings settings)
	{
		return default(float);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2EBADB0", Offset = "0x2EB6DB0", VA = "0x2EBADB0")]
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2EBACB0", Offset = "0x2EB6CB0", VA = "0x2EBACB0")]
	public bool Populate(string str, TextGenerationSettings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2EBAF64", Offset = "0x2EB6F64", VA = "0x2EBAF64")]
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings)
	{
		return default(TextGenerationError);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2EBAFF4", Offset = "0x2EB6FF4", VA = "0x2EBAFF4")]
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings)
	{
		return default(TextGenerationError);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2EBA578", Offset = "0x2EB6578", VA = "0x2EBA578")]
	[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
	private static extern IntPtr Internal_Create();

	[MethodImpl(4096)]
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2EBA708", Offset = "0x2EB6708", VA = "0x2EBA708")]
	[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
	private static extern void Internal_Destroy(IntPtr ptr);

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2EBB438", Offset = "0x2EB7438", VA = "0x2EBB438")]
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
	{
		return default(bool);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2EBB0FC", Offset = "0x2EB70FC", VA = "0x2EBB0FC")]
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error)
	{
		return default(bool);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2EBAC0C", Offset = "0x2EB6C0C", VA = "0x2EBAC0C")]
	[UnityEngine.Bindings.NativeThrows]
	private extern void GetVerticesInternal(object vertices);

	[MethodImpl(4096)]
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2EBAAFC", Offset = "0x2EB6AFC", VA = "0x2EBAAFC")]
	[UnityEngine.Bindings.NativeThrows]
	private extern void GetCharactersInternal(object characters);

	[MethodImpl(4096)]
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2EBAB84", Offset = "0x2EB6B84", VA = "0x2EBAB84")]
	[UnityEngine.Bindings.NativeThrows]
	private extern void GetLinesInternal(object lines);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2EBB3B8", Offset = "0x2EB73B8", VA = "0x2EBB3B8")]
	private extern void get_rectExtents_Injected(out Rect ret);

	[MethodImpl(4096)]
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2EBB594", Offset = "0x2EB7594", VA = "0x2EBB594")]
	private extern bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error);
}
[Token(Token = "0x2000006")]
public enum TextAnchor
{
	[Token(Token = "0x4000029")]
	UpperLeft,
	[Token(Token = "0x400002A")]
	UpperCenter,
	[Token(Token = "0x400002B")]
	UpperRight,
	[Token(Token = "0x400002C")]
	MiddleLeft,
	[Token(Token = "0x400002D")]
	MiddleCenter,
	[Token(Token = "0x400002E")]
	MiddleRight,
	[Token(Token = "0x400002F")]
	LowerLeft,
	[Token(Token = "0x4000030")]
	LowerCenter,
	[Token(Token = "0x4000031")]
	LowerRight
}
[Token(Token = "0x2000007")]
public enum HorizontalWrapMode
{
	[Token(Token = "0x4000033")]
	Wrap,
	[Token(Token = "0x4000034")]
	Overflow
}
[Token(Token = "0x2000008")]
public enum VerticalWrapMode
{
	[Token(Token = "0x4000036")]
	Truncate,
	[Token(Token = "0x4000037")]
	Overflow
}
[Token(Token = "0x2000009")]
[UnityEngine.Scripting.UsedByNativeCode]
public struct UICharInfo
{
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector2 cursorPos;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float charWidth;
}
[Token(Token = "0x200000A")]
[UnityEngine.Scripting.UsedByNativeCode]
public struct UILineInfo
{
	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int startCharIdx;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int height;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float topY;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float leading;
}
[Token(Token = "0x200000B")]
[UnityEngine.Scripting.UsedByNativeCode]
public struct UIVertex
{
	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 normal;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 tangent;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color32 color;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector4 uv0;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector4 uv1;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector4 uv2;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector4 uv3;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Color32 s_DefaultColor;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly Vector4 s_DefaultTangent;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static UIVertex simpleVert;
}
[Token(Token = "0x200000C")]
[UnityEngine.Bindings.NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[UnityEngine.Bindings.NativeHeader("Modules/TextRendering/Public/Font.h")]
[UnityEngine.Bindings.StaticAccessor("TextRenderingPrivate", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
[UnityEngine.NativeClass("TextRendering::Font")]
public sealed class Font : Object
{
	[Token(Token = "0x200000D")]
	public delegate void FontTextureRebuildCallback();

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private FontTextureRebuildCallback m_FontTextureRebuildCallback;

	[Token(Token = "0x17000008")]
	public extern Material material
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2EBB9CC", Offset = "0x2EB79CC", VA = "0x2EBB9CC")]
		get;
	}

	[Token(Token = "0x17000009")]
	public extern bool dynamic
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2EBAA74", Offset = "0x2EB6A74", VA = "0x2EBAA74")]
		get;
	}

	[Token(Token = "0x1700000A")]
	public extern int fontSize
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2EBBA08", Offset = "0x2EB7A08", VA = "0x2EBBA08")]
		get;
	}

	[Token(Token = "0x14000001")]
	public static event Action<Font> textureRebuilt
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2EBB834", Offset = "0x2EB7834", VA = "0x2EBB834")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2EBB900", Offset = "0x2EB7900", VA = "0x2EBB900")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2EBBA44", Offset = "0x2EB7A44", VA = "0x2EBBA44")]
	public Font()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2EBBB0C", Offset = "0x2EB7B0C", VA = "0x2EBBB0C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void InvokeTextureRebuilt_Internal(Font font)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2EBBB98", Offset = "0x2EB7B98", VA = "0x2EBBB98")]
	public bool HasCharacter(char c)
	{
		return default(bool);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2EBBBDC", Offset = "0x2EB7BDC", VA = "0x2EBBBDC")]
	private extern bool HasCharacter(int c);

	[MethodImpl(4096)]
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2EBBAC8", Offset = "0x2EB7AC8", VA = "0x2EBBAC8")]
	private static extern void Internal_CreateFont([UnityEngine.Writable] Font self, string name);
}
