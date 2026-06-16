using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngine.TextCore.LowLevel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.TextCore
{
	[Serializable]
	[Token(Token = "0x2000002")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public struct FaceInfo
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("faceIndex")]
		private int m_FaceIndex;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("familyName")]
		private string m_FamilyName;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("styleName")]
		private string m_StyleName;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[UnityEngine.Bindings.NativeName("pointSize")]
		[SerializeField]
		private int m_PointSize;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("scale")]
		private float m_Scale;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("unitsPerEM")]
		private int m_UnitsPerEM;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("lineHeight")]
		private float m_LineHeight;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[UnityEngine.Bindings.NativeName("ascentLine")]
		[SerializeField]
		private float m_AscentLine;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[UnityEngine.Bindings.NativeName("capLine")]
		[SerializeField]
		private float m_CapLine;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[UnityEngine.Bindings.NativeName("meanLine")]
		[SerializeField]
		private float m_MeanLine;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("baseline")]
		private float m_Baseline;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("descentLine")]
		private float m_DescentLine;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[UnityEngine.Bindings.NativeName("superscriptOffset")]
		[SerializeField]
		private float m_SuperscriptOffset;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("superscriptSize")]
		private float m_SuperscriptSize;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("subscriptOffset")]
		private float m_SubscriptOffset;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[UnityEngine.Bindings.NativeName("subscriptSize")]
		[SerializeField]
		private float m_SubscriptSize;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("underlineOffset")]
		private float m_UnderlineOffset;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[UnityEngine.Bindings.NativeName("underlineThickness")]
		[SerializeField]
		private float m_UnderlineThickness;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("strikethroughOffset")]
		private float m_StrikethroughOffset;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[UnityEngine.Bindings.NativeName("strikethroughThickness")]
		[SerializeField]
		private float m_StrikethroughThickness;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("tabWidth")]
		private float m_TabWidth;

		[Token(Token = "0x17000001")]
		internal int faceIndex
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2E88EC8", Offset = "0x2E84EC8", VA = "0x2E88EC8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000002")]
		public string familyName
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2E88ED0", Offset = "0x2E84ED0", VA = "0x2E88ED0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public string styleName
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2E88ED8", Offset = "0x2E84ED8", VA = "0x2E88ED8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public int pointSize
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2E88EE0", Offset = "0x2E84EE0", VA = "0x2E88EE0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000005")]
		public float scale
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2E88EE8", Offset = "0x2E84EE8", VA = "0x2E88EE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2E88EF0", Offset = "0x2E84EF0", VA = "0x2E88EF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float lineHeight
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2E88EF8", Offset = "0x2E84EF8", VA = "0x2E88EF8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000007")]
		public float ascentLine
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2E88F00", Offset = "0x2E84F00", VA = "0x2E88F00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000008")]
		public float capLine
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2E88F08", Offset = "0x2E84F08", VA = "0x2E88F08")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2E88F10", Offset = "0x2E84F10", VA = "0x2E88F10")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public float meanLine
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2E88F18", Offset = "0x2E84F18", VA = "0x2E88F18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2E88F20", Offset = "0x2E84F20", VA = "0x2E88F20")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float baseline
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2E88F28", Offset = "0x2E84F28", VA = "0x2E88F28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000B")]
		public float descentLine
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2E88F30", Offset = "0x2E84F30", VA = "0x2E88F30")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000C")]
		public float superscriptOffset
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2E88F38", Offset = "0x2E84F38", VA = "0x2E88F38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000D")]
		public float superscriptSize
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2E88F40", Offset = "0x2E84F40", VA = "0x2E88F40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000E")]
		public float subscriptOffset
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2E88F48", Offset = "0x2E84F48", VA = "0x2E88F48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000F")]
		public float subscriptSize
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2E88F50", Offset = "0x2E84F50", VA = "0x2E88F50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000010")]
		public float underlineOffset
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2E88F58", Offset = "0x2E84F58", VA = "0x2E88F58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		public float underlineThickness
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2E88F60", Offset = "0x2E84F60", VA = "0x2E88F60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		public float strikethroughOffset
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2E88F68", Offset = "0x2E84F68", VA = "0x2E88F68")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2E88F70", Offset = "0x2E84F70", VA = "0x2E88F70")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public float tabWidth
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2E88F78", Offset = "0x2E84F78", VA = "0x2E88F78")]
			get
			{
				return default(float);
			}
		}
	}
	[Token(Token = "0x2000003")]
	public enum GlyphClassDefinitionType
	{
		[Token(Token = "0x4000017")]
		Undefined,
		[Token(Token = "0x4000018")]
		Base,
		[Token(Token = "0x4000019")]
		Ligature,
		[Token(Token = "0x400001A")]
		Mark,
		[Token(Token = "0x400001B")]
		Component
	}
	[Serializable]
	[Token(Token = "0x2000004")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public struct GlyphRect : IEquatable<GlyphRect>
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("x")]
		private int m_X;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("y")]
		private int m_Y;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[UnityEngine.Bindings.NativeName("width")]
		[SerializeField]
		private int m_Width;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[UnityEngine.Bindings.NativeName("height")]
		[SerializeField]
		private int m_Height;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly GlyphRect s_ZeroGlyphRect;

		[Token(Token = "0x17000014")]
		public int x
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2E88F80", Offset = "0x2E84F80", VA = "0x2E88F80")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		public int y
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2E88F88", Offset = "0x2E84F88", VA = "0x2E88F88")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000016")]
		public int width
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2E88F90", Offset = "0x2E84F90", VA = "0x2E88F90")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000017")]
		public int height
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2E88F98", Offset = "0x2E84F98", VA = "0x2E88F98")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000018")]
		public static GlyphRect zero
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2E88FA0", Offset = "0x2E84FA0", VA = "0x2E88FA0")]
			get
			{
				return default(GlyphRect);
			}
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2E88FF8", Offset = "0x2E84FF8", VA = "0x2E88FF8")]
		public GlyphRect(int x, int y, int width, int height)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2E89004", Offset = "0x2E85004", VA = "0x2E89004", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2E89068", Offset = "0x2E85068", VA = "0x2E89068", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2E890E0", Offset = "0x2E850E0", VA = "0x2E890E0", Slot = "4")]
		public bool Equals(GlyphRect other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public struct GlyphMetrics : IEquatable<GlyphMetrics>
	{
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("width")]
		private float m_Width;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("height")]
		private float m_Height;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("horizontalBearingX")]
		private float m_HorizontalBearingX;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[UnityEngine.Bindings.NativeName("horizontalBearingY")]
		[SerializeField]
		private float m_HorizontalBearingY;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[UnityEngine.Bindings.NativeName("horizontalAdvance")]
		[SerializeField]
		private float m_HorizontalAdvance;

		[Token(Token = "0x17000019")]
		public float width
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2E891BC", Offset = "0x2E851BC", VA = "0x2E891BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001A")]
		public float height
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2E891C4", Offset = "0x2E851C4", VA = "0x2E891C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001B")]
		public float horizontalBearingX
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2E891CC", Offset = "0x2E851CC", VA = "0x2E891CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001C")]
		public float horizontalBearingY
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2E891D4", Offset = "0x2E851D4", VA = "0x2E891D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public float horizontalAdvance
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2E891DC", Offset = "0x2E851DC", VA = "0x2E891DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2E891E4", Offset = "0x2E851E4", VA = "0x2E891E4")]
		public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2E891F4", Offset = "0x2E851F4", VA = "0x2E891F4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2E89260", Offset = "0x2E85260", VA = "0x2E89260", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2E892E0", Offset = "0x2E852E0", VA = "0x2E892E0", Slot = "4")]
		public bool Equals(GlyphMetrics other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[StructLayout(0)]
	[Token(Token = "0x2000006")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public class Glyph
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("index")]
		private uint m_Index;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[UnityEngine.Bindings.NativeName("metrics")]
		[SerializeField]
		private GlyphMetrics m_Metrics;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("glyphRect")]
		private GlyphRect m_GlyphRect;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("scale")]
		private float m_Scale;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[UnityEngine.Bindings.NativeName("atlasIndex")]
		[SerializeField]
		private int m_AtlasIndex;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[UnityEngine.Bindings.NativeName("type")]
		[SerializeField]
		private GlyphClassDefinitionType m_ClassDefinitionType;

		[Token(Token = "0x1700001E")]
		public uint index
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2E89384", Offset = "0x2E85384", VA = "0x2E89384")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700001F")]
		public GlyphMetrics metrics
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2E8938C", Offset = "0x2E8538C", VA = "0x2E8938C")]
			get
			{
				return default(GlyphMetrics);
			}
		}

		[Token(Token = "0x17000020")]
		public GlyphRect glyphRect
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2E893A0", Offset = "0x2E853A0", VA = "0x2E893A0")]
			get
			{
				return default(GlyphRect);
			}
		}

		[Token(Token = "0x17000021")]
		public float scale
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2E893AC", Offset = "0x2E853AC", VA = "0x2E893AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		public int atlasIndex
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2E893B4", Offset = "0x2E853B4", VA = "0x2E893B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2E893BC", Offset = "0x2E853BC", VA = "0x2E893BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2E893C4", Offset = "0x2E853C4", VA = "0x2E893C4")]
		public Glyph()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2E893EC", Offset = "0x2E853EC", VA = "0x2E893EC")]
		internal Glyph(GlyphMarshallingStruct glyphStruct)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2E89468", Offset = "0x2E85468", VA = "0x2E89468")]
		public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex)
		{
		}
	}
}
namespace UnityEngine.TextCore.LowLevel
{
	[Token(Token = "0x2000007")]
	[Flags]
	[UnityEngine.Scripting.UsedByNativeCode]
	public enum GlyphLoadFlags
	{
		[Token(Token = "0x400002D")]
		LOAD_DEFAULT = 0,
		[Token(Token = "0x400002E")]
		LOAD_NO_SCALE = 1,
		[Token(Token = "0x400002F")]
		LOAD_NO_HINTING = 2,
		[Token(Token = "0x4000030")]
		LOAD_RENDER = 4,
		[Token(Token = "0x4000031")]
		LOAD_NO_BITMAP = 8,
		[Token(Token = "0x4000032")]
		LOAD_FORCE_AUTOHINT = 0x20,
		[Token(Token = "0x4000033")]
		LOAD_MONOCHROME = 0x1000,
		[Token(Token = "0x4000034")]
		LOAD_NO_AUTOHINT = 0x8000,
		[Token(Token = "0x4000035")]
		LOAD_COLOR = 0x100000,
		[Token(Token = "0x4000036")]
		LOAD_COMPUTE_METRICS = 0x200000,
		[Token(Token = "0x4000037")]
		LOAD_BITMAP_METRICS_ONLY = 0x400000
	}
	[Token(Token = "0x2000008")]
	public enum FontEngineError
	{
		[Token(Token = "0x4000039")]
		Success = 0,
		[Token(Token = "0x400003A")]
		Invalid_File_Path = 1,
		[Token(Token = "0x400003B")]
		Invalid_File_Format = 2,
		[Token(Token = "0x400003C")]
		Invalid_File_Structure = 3,
		[Token(Token = "0x400003D")]
		Invalid_File = 4,
		[Token(Token = "0x400003E")]
		Invalid_Table = 8,
		[Token(Token = "0x400003F")]
		Invalid_Glyph_Index = 16,
		[Token(Token = "0x4000040")]
		Invalid_Character_Code = 17,
		[Token(Token = "0x4000041")]
		Invalid_Pixel_Size = 23,
		[Token(Token = "0x4000042")]
		Invalid_Library = 33,
		[Token(Token = "0x4000043")]
		Invalid_Face = 35,
		[Token(Token = "0x4000044")]
		Invalid_Library_or_Face = 41,
		[Token(Token = "0x4000045")]
		Atlas_Generation_Cancelled = 100,
		[Token(Token = "0x4000046")]
		Invalid_SharedTextureData = 101,
		[Token(Token = "0x4000047")]
		OpenTypeLayoutLookup_Mismatch = 116
	}
	[Token(Token = "0x2000009")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public enum GlyphRenderMode
	{
		[Token(Token = "0x4000049")]
		SMOOTH_HINTED = 4121,
		[Token(Token = "0x400004A")]
		SMOOTH = 4117,
		[Token(Token = "0x400004B")]
		COLOR_HINTED = 69656,
		[Token(Token = "0x400004C")]
		COLOR = 69652,
		[Token(Token = "0x400004D")]
		RASTER_HINTED = 4122,
		[Token(Token = "0x400004E")]
		RASTER = 4118,
		[Token(Token = "0x400004F")]
		SDF = 4134,
		[Token(Token = "0x4000050")]
		SDF8 = 8230,
		[Token(Token = "0x4000051")]
		SDF16 = 16422,
		[Token(Token = "0x4000052")]
		SDF32 = 32806,
		[Token(Token = "0x4000053")]
		SDFAA_HINTED = 4169,
		[Token(Token = "0x4000054")]
		SDFAA = 4165
	}
	[Token(Token = "0x200000A")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public enum GlyphPackingMode
	{
		[Token(Token = "0x4000056")]
		BestShortSideFit,
		[Token(Token = "0x4000057")]
		BestLongSideFit,
		[Token(Token = "0x4000058")]
		BestAreaFit,
		[Token(Token = "0x4000059")]
		BottomLeftRule,
		[Token(Token = "0x400005A")]
		ContactPointRule
	}
	[Token(Token = "0x200000B")]
	[UnityEngine.Scripting.UsedByNativeCode]
	[DebuggerDisplay("{familyName} - {styleName}")]
	internal struct FontReference
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string familyName;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string styleName;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int faceIndex;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string filePath;
	}
	[Token(Token = "0x200000C")]
	[UnityEngine.Bindings.NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
	public sealed class FontEngine
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Glyph[] s_Glyphs;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static uint[] s_GlyphIndexes_MarshallingArray_A;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static GlyphRect[] s_FreeGlyphRects;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GlyphRect[] s_UsedGlyphRects;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Dictionary<uint, Glyph> s_GlyphLookupDictionary;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2E894D8", Offset = "0x2E854D8", VA = "0x2E894D8")]
		public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex)
		{
			return default(FontEngineError);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2E89564", Offset = "0x2E85564", VA = "0x2E89564")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static extern int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex);

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2E895B8", Offset = "0x2E855B8", VA = "0x2E895B8")]
		public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex)
		{
			return default(FontEngineError);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2E89644", Offset = "0x2E85644", VA = "0x2E89644")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static extern int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex);

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2E89698", Offset = "0x2E85698", VA = "0x2E89698")]
		public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize)
		{
			return default(FontEngineError);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2E89724", Offset = "0x2E85724", VA = "0x2E89724")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static extern int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize);

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2E89778", Offset = "0x2E85778", VA = "0x2E89778")]
		internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2E89804", Offset = "0x2E85804", VA = "0x2E89804")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = true, IsFreeFunction = true)]
		private static extern bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef);

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2E89858", Offset = "0x2E85858", VA = "0x2E89858")]
		public static FaceInfo GetFaceInfo()
		{
			return default(FaceInfo);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2E898F8", Offset = "0x2E858F8", VA = "0x2E898F8")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = true, IsFreeFunction = true)]
		private static extern int GetFaceInfo_Internal(ref FaceInfo faceInfo);

		[MethodImpl(4096)]
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2E89934", Offset = "0x2E85934", VA = "0x2E89934")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = true, IsFreeFunction = true)]
		internal static extern uint GetGlyphIndex(uint unicode);

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2E89970", Offset = "0x2E85970", VA = "0x2E89970")]
		public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2E89AA4", Offset = "0x2E85AA4", VA = "0x2E89AA4")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = true, IsFreeFunction = true)]
		private static extern bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct);

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2E89AF8", Offset = "0x2E85AF8", VA = "0x2E89AF8")]
		public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2E89C2C", Offset = "0x2E85C2C", VA = "0x2E89C2C")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = true, IsFreeFunction = true)]
		private static extern bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct);

		[MethodImpl(4096)]
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2E89C80", Offset = "0x2E85C80", VA = "0x2E89C80")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = true, IsFreeFunction = true)]
		internal static extern void SetTextureUploadMode(bool shouldUploadImmediately);

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2E89CBC", Offset = "0x2E85CBC", VA = "0x2E89CBC")]
		internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2E8A1C8", Offset = "0x2E861C8", VA = "0x2E8A1C8")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = true, IsFreeFunction = true)]
		private static extern bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph);

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2E8A264", Offset = "0x2E86264", VA = "0x2E8A264")]
		internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2E8AAC0", Offset = "0x2E86AC0", VA = "0x2E8AAC0")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = true, IsFreeFunction = true)]
		private static extern bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount);

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2E8AB68", Offset = "0x2E86B68", VA = "0x2E8AB68")]
		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2E8AD38", Offset = "0x2E86D38", VA = "0x2E8AD38")]
		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount)
		{
			return null;
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2E8ACB8", Offset = "0x2E86CB8", VA = "0x2E8ACB8")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = true)]
		private static extern int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount);

		[MethodImpl(4096)]
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2E8ACFC", Offset = "0x2E86CFC", VA = "0x2E8ACFC")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = true)]
		private static extern int GetPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords);

		[Token(Token = "0x600004C")]
		private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref T[] dstArray)
		{
		}

		[Token(Token = "0x600004D")]
		private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2E8AEC0", Offset = "0x2E86EC0", VA = "0x2E8AEC0")]
		[UnityEngine.Bindings.NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = true)]
		internal static extern void ResetAtlasTexture(Texture2D texture);
	}
	[Token(Token = "0x200000D")]
	internal struct FontEngineUtilities
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2E8AAAC", Offset = "0x2E86AAC", VA = "0x2E8AAAC")]
		internal static int MaxValue(int a, int b, int c)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200000E")]
	[UnityEngine.Scripting.UsedByNativeCode]
	internal struct GlyphMarshallingStruct
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint index;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public GlyphMetrics metrics;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GlyphRect glyphRect;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float scale;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int atlasIndex;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GlyphClassDefinitionType classDefinitionType;
	}
	[Token(Token = "0x200000F")]
	[Flags]
	public enum FontFeatureLookupFlags
	{
		[Token(Token = "0x400006E")]
		None = 0,
		[Token(Token = "0x400006F")]
		IgnoreLigatures = 4,
		[Token(Token = "0x4000070")]
		IgnoreSpacingAdjustments = 0x100
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public struct GlyphValueRecord : IEquatable<GlyphValueRecord>
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("xPlacement")]
		[SerializeField]
		private float m_XPlacement;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("yPlacement")]
		private float m_YPlacement;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("xAdvance")]
		private float m_XAdvance;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[UnityEngine.Bindings.NativeName("yAdvance")]
		[SerializeField]
		private float m_YAdvance;

		[Token(Token = "0x17000023")]
		public float xPlacement
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2E8B054", Offset = "0x2E87054", VA = "0x2E8B054")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2E8B05C", Offset = "0x2E8705C", VA = "0x2E8B05C")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public float yPlacement
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2E8B064", Offset = "0x2E87064", VA = "0x2E8B064")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2E8B06C", Offset = "0x2E8706C", VA = "0x2E8B06C")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public float xAdvance
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2E8B074", Offset = "0x2E87074", VA = "0x2E8B074")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000026")]
		public float yAdvance
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2E8B07C", Offset = "0x2E8707C", VA = "0x2E8B07C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2E8B084", Offset = "0x2E87084", VA = "0x2E8B084")]
		public static GlyphValueRecord operator +(GlyphValueRecord a, GlyphValueRecord b)
		{
			return default(GlyphValueRecord);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2E8B098", Offset = "0x2E87098", VA = "0x2E8B098", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2E8B0FC", Offset = "0x2E870FC", VA = "0x2E8B0FC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2E8B174", Offset = "0x2E87174", VA = "0x2E8B174", Slot = "4")]
		public bool Equals(GlyphValueRecord other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord>
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("glyphIndex")]
		[SerializeField]
		private uint m_GlyphIndex;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("glyphValueRecord")]
		private GlyphValueRecord m_GlyphValueRecord;

		[Token(Token = "0x17000027")]
		public uint glyphIndex
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2E8B21C", Offset = "0x2E8721C", VA = "0x2E8B21C")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000028")]
		public GlyphValueRecord glyphValueRecord
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2E8B224", Offset = "0x2E87224", VA = "0x2E8B224")]
			get
			{
				return default(GlyphValueRecord);
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2E8B230", Offset = "0x2E87230", VA = "0x2E8B230", Slot = "2")]
		[ExcludeFromDocs]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2E8B29C", Offset = "0x2E8729C", VA = "0x2E8B29C", Slot = "0")]
		[ExcludeFromDocs]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2E8B31C", Offset = "0x2E8731C", VA = "0x2E8B31C", Slot = "4")]
		[ExcludeFromDocs]
		public bool Equals(GlyphAdjustmentRecord other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord>
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("firstAdjustmentRecord")]
		[SerializeField]
		private GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[UnityEngine.Bindings.NativeName("secondAdjustmentRecord")]
		[SerializeField]
		private GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FontFeatureLookupFlags m_FeatureLookupFlags;

		[Token(Token = "0x17000029")]
		public GlyphAdjustmentRecord firstAdjustmentRecord
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x2E8B3C0", Offset = "0x2E873C0", VA = "0x2E8B3C0")]
			get
			{
				return default(GlyphAdjustmentRecord);
			}
		}

		[Token(Token = "0x1700002A")]
		public GlyphAdjustmentRecord secondAdjustmentRecord
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x2E8B3D4", Offset = "0x2E873D4", VA = "0x2E8B3D4")]
			get
			{
				return default(GlyphAdjustmentRecord);
			}
		}

		[Token(Token = "0x1700002B")]
		public FontFeatureLookupFlags featureLookupFlags
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x2E8B3E8", Offset = "0x2E873E8", VA = "0x2E8B3E8")]
			get
			{
				return default(FontFeatureLookupFlags);
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2E8B3F0", Offset = "0x2E873F0", VA = "0x2E8B3F0", Slot = "2")]
		[ExcludeFromDocs]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2E8B45C", Offset = "0x2E8745C", VA = "0x2E8B45C", Slot = "0")]
		[ExcludeFromDocs]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2E8B4DC", Offset = "0x2E874DC", VA = "0x2E8B4DC", Slot = "4")]
		[ExcludeFromDocs]
		public bool Equals(GlyphPairAdjustmentRecord other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	[UnityEngine.Scripting.UsedByNativeCode]
	internal struct GlyphAnchorPoint
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("xPositionAdjustment")]
		[SerializeField]
		private float m_XCoordinate;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[UnityEngine.Bindings.NativeName("yPositionAdjustment")]
		[SerializeField]
		private float m_YCoordinate;

		[Token(Token = "0x1700002C")]
		public float xCoordinate
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x2E8B580", Offset = "0x2E87580", VA = "0x2E8B580")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float yCoordinate
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x2E8B588", Offset = "0x2E87588", VA = "0x2E8B588")]
			get
			{
				return default(float);
			}
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	[UnityEngine.Scripting.UsedByNativeCode]
	internal struct MarkPositionAdjustment
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("xCoordinate")]
		[SerializeField]
		private float m_XPositionAdjustment;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[UnityEngine.Bindings.NativeName("yCoordinate")]
		[SerializeField]
		private float m_YPositionAdjustment;

		[Token(Token = "0x1700002E")]
		public float xPositionAdjustment
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x2E8B590", Offset = "0x2E87590", VA = "0x2E8B590")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		public float yPositionAdjustment
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x2E8B598", Offset = "0x2E87598", VA = "0x2E8B598")]
			get
			{
				return default(float);
			}
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	[UnityEngine.Scripting.UsedByNativeCode]
	internal struct MarkToBaseAdjustmentRecord
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("baseGlyphID")]
		private uint m_BaseGlyphID;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("baseAnchor")]
		private GlyphAnchorPoint m_BaseGlyphAnchorPoint;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[UnityEngine.Bindings.NativeName("markGlyphID")]
		[SerializeField]
		private uint m_MarkGlyphID;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("markPositionAdjustment")]
		private MarkPositionAdjustment m_MarkPositionAdjustment;

		[Token(Token = "0x17000030")]
		public uint baseGlyphID
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x2E8B5A0", Offset = "0x2E875A0", VA = "0x2E8B5A0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000031")]
		public GlyphAnchorPoint baseGlyphAnchorPoint
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x2E8B5A8", Offset = "0x2E875A8", VA = "0x2E8B5A8")]
			get
			{
				return default(GlyphAnchorPoint);
			}
		}

		[Token(Token = "0x17000032")]
		public uint markGlyphID
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x2E8B5B0", Offset = "0x2E875B0", VA = "0x2E8B5B0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000033")]
		public MarkPositionAdjustment markPositionAdjustment
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2E8B5B8", Offset = "0x2E875B8", VA = "0x2E8B5B8")]
			get
			{
				return default(MarkPositionAdjustment);
			}
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	[UnityEngine.Scripting.UsedByNativeCode]
	internal struct MarkToMarkAdjustmentRecord
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("baseMarkGlyphID")]
		[SerializeField]
		private uint m_BaseMarkGlyphID;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("baseMarkAnchor")]
		private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[UnityEngine.Bindings.NativeName("combiningMarkGlyphID")]
		[SerializeField]
		private uint m_CombiningMarkGlyphID;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[UnityEngine.Bindings.NativeName("combiningMarkPositionAdjustment")]
		[SerializeField]
		private MarkPositionAdjustment m_CombiningMarkPositionAdjustment;

		[Token(Token = "0x17000034")]
		public uint baseMarkGlyphID
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x2E8B5C0", Offset = "0x2E875C0", VA = "0x2E8B5C0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000035")]
		public GlyphAnchorPoint baseMarkGlyphAnchorPoint
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2E8B5C8", Offset = "0x2E875C8", VA = "0x2E8B5C8")]
			get
			{
				return default(GlyphAnchorPoint);
			}
		}

		[Token(Token = "0x17000036")]
		public uint combiningMarkGlyphID
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2E8B5D0", Offset = "0x2E875D0", VA = "0x2E8B5D0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000037")]
		public MarkPositionAdjustment combiningMarkPositionAdjustment
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2E8B5D8", Offset = "0x2E875D8", VA = "0x2E8B5D8")]
			get
			{
				return default(MarkPositionAdjustment);
			}
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	[UnityEngine.Scripting.UsedByNativeCode]
	internal struct MultipleSubstitutionRecord
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("targetGlyphID")]
		[SerializeField]
		private uint m_TargetGlyphID;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[UnityEngine.Bindings.NativeName("substituteGlyphIDs")]
		[SerializeField]
		private uint[] m_SubstituteGlyphIDs;
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	[UnityEngine.Scripting.UsedByNativeCode]
	internal struct LigatureSubstitutionRecord
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("componentGlyphs")]
		[SerializeField]
		private uint[] m_ComponentGlyphIDs;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		[UnityEngine.Bindings.NativeName("ligatureGlyph")]
		private uint m_LigatureGlyphID;

		[Token(Token = "0x17000038")]
		public uint[] componentGlyphIDs
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2E8B5E0", Offset = "0x2E875E0", VA = "0x2E8B5E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public uint ligatureGlyphID
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2E8B5E8", Offset = "0x2E875E8", VA = "0x2E8B5E8")]
			get
			{
				return default(uint);
			}
		}
	}
}
