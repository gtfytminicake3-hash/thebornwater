using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;

[assembly: AssemblyVersion("4.0.0.0")]
namespace System.Numerics.Hashing
{
	[Token(Token = "0x2000002")]
	internal static class HashHelpers
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int RandomSeed;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2899440", Offset = "0x2895440", VA = "0x2899440")]
		public static int Combine(int h1, int h2)
		{
			return default(int);
		}
	}
}
namespace System.Drawing
{
	[Token(Token = "0x2000003")]
	public enum KnownColor
	{
		[Token(Token = "0x4000003")]
		ActiveBorder = 1,
		[Token(Token = "0x4000004")]
		ActiveCaption,
		[Token(Token = "0x4000005")]
		ActiveCaptionText,
		[Token(Token = "0x4000006")]
		AppWorkspace,
		[Token(Token = "0x4000007")]
		Control,
		[Token(Token = "0x4000008")]
		ControlDark,
		[Token(Token = "0x4000009")]
		ControlDarkDark,
		[Token(Token = "0x400000A")]
		ControlLight,
		[Token(Token = "0x400000B")]
		ControlLightLight,
		[Token(Token = "0x400000C")]
		ControlText,
		[Token(Token = "0x400000D")]
		Desktop,
		[Token(Token = "0x400000E")]
		GrayText,
		[Token(Token = "0x400000F")]
		Highlight,
		[Token(Token = "0x4000010")]
		HighlightText,
		[Token(Token = "0x4000011")]
		HotTrack,
		[Token(Token = "0x4000012")]
		InactiveBorder,
		[Token(Token = "0x4000013")]
		InactiveCaption,
		[Token(Token = "0x4000014")]
		InactiveCaptionText,
		[Token(Token = "0x4000015")]
		Info,
		[Token(Token = "0x4000016")]
		InfoText,
		[Token(Token = "0x4000017")]
		Menu,
		[Token(Token = "0x4000018")]
		MenuText,
		[Token(Token = "0x4000019")]
		ScrollBar,
		[Token(Token = "0x400001A")]
		Window,
		[Token(Token = "0x400001B")]
		WindowFrame,
		[Token(Token = "0x400001C")]
		WindowText,
		[Token(Token = "0x400001D")]
		Transparent,
		[Token(Token = "0x400001E")]
		AliceBlue,
		[Token(Token = "0x400001F")]
		AntiqueWhite,
		[Token(Token = "0x4000020")]
		Aqua,
		[Token(Token = "0x4000021")]
		Aquamarine,
		[Token(Token = "0x4000022")]
		Azure,
		[Token(Token = "0x4000023")]
		Beige,
		[Token(Token = "0x4000024")]
		Bisque,
		[Token(Token = "0x4000025")]
		Black,
		[Token(Token = "0x4000026")]
		BlanchedAlmond,
		[Token(Token = "0x4000027")]
		Blue,
		[Token(Token = "0x4000028")]
		BlueViolet,
		[Token(Token = "0x4000029")]
		Brown,
		[Token(Token = "0x400002A")]
		BurlyWood,
		[Token(Token = "0x400002B")]
		CadetBlue,
		[Token(Token = "0x400002C")]
		Chartreuse,
		[Token(Token = "0x400002D")]
		Chocolate,
		[Token(Token = "0x400002E")]
		Coral,
		[Token(Token = "0x400002F")]
		CornflowerBlue,
		[Token(Token = "0x4000030")]
		Cornsilk,
		[Token(Token = "0x4000031")]
		Crimson,
		[Token(Token = "0x4000032")]
		Cyan,
		[Token(Token = "0x4000033")]
		DarkBlue,
		[Token(Token = "0x4000034")]
		DarkCyan,
		[Token(Token = "0x4000035")]
		DarkGoldenrod,
		[Token(Token = "0x4000036")]
		DarkGray,
		[Token(Token = "0x4000037")]
		DarkGreen,
		[Token(Token = "0x4000038")]
		DarkKhaki,
		[Token(Token = "0x4000039")]
		DarkMagenta,
		[Token(Token = "0x400003A")]
		DarkOliveGreen,
		[Token(Token = "0x400003B")]
		DarkOrange,
		[Token(Token = "0x400003C")]
		DarkOrchid,
		[Token(Token = "0x400003D")]
		DarkRed,
		[Token(Token = "0x400003E")]
		DarkSalmon,
		[Token(Token = "0x400003F")]
		DarkSeaGreen,
		[Token(Token = "0x4000040")]
		DarkSlateBlue,
		[Token(Token = "0x4000041")]
		DarkSlateGray,
		[Token(Token = "0x4000042")]
		DarkTurquoise,
		[Token(Token = "0x4000043")]
		DarkViolet,
		[Token(Token = "0x4000044")]
		DeepPink,
		[Token(Token = "0x4000045")]
		DeepSkyBlue,
		[Token(Token = "0x4000046")]
		DimGray,
		[Token(Token = "0x4000047")]
		DodgerBlue,
		[Token(Token = "0x4000048")]
		Firebrick,
		[Token(Token = "0x4000049")]
		FloralWhite,
		[Token(Token = "0x400004A")]
		ForestGreen,
		[Token(Token = "0x400004B")]
		Fuchsia,
		[Token(Token = "0x400004C")]
		Gainsboro,
		[Token(Token = "0x400004D")]
		GhostWhite,
		[Token(Token = "0x400004E")]
		Gold,
		[Token(Token = "0x400004F")]
		Goldenrod,
		[Token(Token = "0x4000050")]
		Gray,
		[Token(Token = "0x4000051")]
		Green,
		[Token(Token = "0x4000052")]
		GreenYellow,
		[Token(Token = "0x4000053")]
		Honeydew,
		[Token(Token = "0x4000054")]
		HotPink,
		[Token(Token = "0x4000055")]
		IndianRed,
		[Token(Token = "0x4000056")]
		Indigo,
		[Token(Token = "0x4000057")]
		Ivory,
		[Token(Token = "0x4000058")]
		Khaki,
		[Token(Token = "0x4000059")]
		Lavender,
		[Token(Token = "0x400005A")]
		LavenderBlush,
		[Token(Token = "0x400005B")]
		LawnGreen,
		[Token(Token = "0x400005C")]
		LemonChiffon,
		[Token(Token = "0x400005D")]
		LightBlue,
		[Token(Token = "0x400005E")]
		LightCoral,
		[Token(Token = "0x400005F")]
		LightCyan,
		[Token(Token = "0x4000060")]
		LightGoldenrodYellow,
		[Token(Token = "0x4000061")]
		LightGray,
		[Token(Token = "0x4000062")]
		LightGreen,
		[Token(Token = "0x4000063")]
		LightPink,
		[Token(Token = "0x4000064")]
		LightSalmon,
		[Token(Token = "0x4000065")]
		LightSeaGreen,
		[Token(Token = "0x4000066")]
		LightSkyBlue,
		[Token(Token = "0x4000067")]
		LightSlateGray,
		[Token(Token = "0x4000068")]
		LightSteelBlue,
		[Token(Token = "0x4000069")]
		LightYellow,
		[Token(Token = "0x400006A")]
		Lime,
		[Token(Token = "0x400006B")]
		LimeGreen,
		[Token(Token = "0x400006C")]
		Linen,
		[Token(Token = "0x400006D")]
		Magenta,
		[Token(Token = "0x400006E")]
		Maroon,
		[Token(Token = "0x400006F")]
		MediumAquamarine,
		[Token(Token = "0x4000070")]
		MediumBlue,
		[Token(Token = "0x4000071")]
		MediumOrchid,
		[Token(Token = "0x4000072")]
		MediumPurple,
		[Token(Token = "0x4000073")]
		MediumSeaGreen,
		[Token(Token = "0x4000074")]
		MediumSlateBlue,
		[Token(Token = "0x4000075")]
		MediumSpringGreen,
		[Token(Token = "0x4000076")]
		MediumTurquoise,
		[Token(Token = "0x4000077")]
		MediumVioletRed,
		[Token(Token = "0x4000078")]
		MidnightBlue,
		[Token(Token = "0x4000079")]
		MintCream,
		[Token(Token = "0x400007A")]
		MistyRose,
		[Token(Token = "0x400007B")]
		Moccasin,
		[Token(Token = "0x400007C")]
		NavajoWhite,
		[Token(Token = "0x400007D")]
		Navy,
		[Token(Token = "0x400007E")]
		OldLace,
		[Token(Token = "0x400007F")]
		Olive,
		[Token(Token = "0x4000080")]
		OliveDrab,
		[Token(Token = "0x4000081")]
		Orange,
		[Token(Token = "0x4000082")]
		OrangeRed,
		[Token(Token = "0x4000083")]
		Orchid,
		[Token(Token = "0x4000084")]
		PaleGoldenrod,
		[Token(Token = "0x4000085")]
		PaleGreen,
		[Token(Token = "0x4000086")]
		PaleTurquoise,
		[Token(Token = "0x4000087")]
		PaleVioletRed,
		[Token(Token = "0x4000088")]
		PapayaWhip,
		[Token(Token = "0x4000089")]
		PeachPuff,
		[Token(Token = "0x400008A")]
		Peru,
		[Token(Token = "0x400008B")]
		Pink,
		[Token(Token = "0x400008C")]
		Plum,
		[Token(Token = "0x400008D")]
		PowderBlue,
		[Token(Token = "0x400008E")]
		Purple,
		[Token(Token = "0x400008F")]
		Red,
		[Token(Token = "0x4000090")]
		RosyBrown,
		[Token(Token = "0x4000091")]
		RoyalBlue,
		[Token(Token = "0x4000092")]
		SaddleBrown,
		[Token(Token = "0x4000093")]
		Salmon,
		[Token(Token = "0x4000094")]
		SandyBrown,
		[Token(Token = "0x4000095")]
		SeaGreen,
		[Token(Token = "0x4000096")]
		SeaShell,
		[Token(Token = "0x4000097")]
		Sienna,
		[Token(Token = "0x4000098")]
		Silver,
		[Token(Token = "0x4000099")]
		SkyBlue,
		[Token(Token = "0x400009A")]
		SlateBlue,
		[Token(Token = "0x400009B")]
		SlateGray,
		[Token(Token = "0x400009C")]
		Snow,
		[Token(Token = "0x400009D")]
		SpringGreen,
		[Token(Token = "0x400009E")]
		SteelBlue,
		[Token(Token = "0x400009F")]
		Tan,
		[Token(Token = "0x40000A0")]
		Teal,
		[Token(Token = "0x40000A1")]
		Thistle,
		[Token(Token = "0x40000A2")]
		Tomato,
		[Token(Token = "0x40000A3")]
		Turquoise,
		[Token(Token = "0x40000A4")]
		Violet,
		[Token(Token = "0x40000A5")]
		Wheat,
		[Token(Token = "0x40000A6")]
		White,
		[Token(Token = "0x40000A7")]
		WhiteSmoke,
		[Token(Token = "0x40000A8")]
		Yellow,
		[Token(Token = "0x40000A9")]
		YellowGreen,
		[Token(Token = "0x40000AA")]
		ButtonFace,
		[Token(Token = "0x40000AB")]
		ButtonHighlight,
		[Token(Token = "0x40000AC")]
		ButtonShadow,
		[Token(Token = "0x40000AD")]
		GradientActiveCaption,
		[Token(Token = "0x40000AE")]
		GradientInactiveCaption,
		[Token(Token = "0x40000AF")]
		MenuBar,
		[Token(Token = "0x40000B0")]
		MenuHighlight
	}
	[Token(Token = "0x2000004")]
	internal static class KnownColorTable
	{
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x0")]
		private static int[] s_colorTable;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x8")]
		private static string[] s_colorNameTable;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x28994B8", Offset = "0x28954B8", VA = "0x28994B8")]
		private static void EnsureColorTable()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2899510", Offset = "0x2895510", VA = "0x2899510")]
		private static void InitColorTable()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x289A0F4", Offset = "0x28960F4", VA = "0x289A0F4")]
		private static void EnsureColorNameTable()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x289A14C", Offset = "0x289614C", VA = "0x289A14C")]
		private static void InitColorNameTable()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x289B778", Offset = "0x2897778", VA = "0x289B778")]
		public static int KnownColorToArgb(KnownColor color)
		{
			return default(int);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x289B7E8", Offset = "0x28977E8", VA = "0x289B7E8")]
		public static string KnownColorToName(KnownColor color)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2899FC0", Offset = "0x2895FC0", VA = "0x2899FC0")]
		private static void UpdateSystemColors(int[] colorTable)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	[DebuggerDisplay("{NameAndARGBValue}")]
	public readonly struct Color : IEquatable<Color>
	{
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x0")]
		private readonly string name;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x8")]
		private readonly long value;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x10")]
		private readonly short knownColor;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x12")]
		private readonly short state;

		[Token(Token = "0x17000001")]
		public byte R
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x289B858", Offset = "0x2897858", VA = "0x289B858")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000002")]
		public byte G
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x289B8A0", Offset = "0x28978A0", VA = "0x289B8A0")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000003")]
		public byte B
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x289B8B4", Offset = "0x28978B4", VA = "0x289B8B4")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000004")]
		public byte A
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x289B8C4", Offset = "0x28978C4", VA = "0x289B8C4")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000005")]
		public bool IsKnownColor
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x289B8D8", Offset = "0x28978D8", VA = "0x289B8D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000006")]
		public string Name
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x289B8E4", Offset = "0x28978E4", VA = "0x289B8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private long Value
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x289B86C", Offset = "0x289786C", VA = "0x289B86C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x289B970", Offset = "0x2897970", VA = "0x289B970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x289BBB0", Offset = "0x2897BB0", VA = "0x289BBB0")]
		public static bool operator ==(Color left, Color right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x289BBF8", Offset = "0x2897BF8", VA = "0x289BBF8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x289BC88", Offset = "0x2897C88", VA = "0x289BC88", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x289BCD0", Offset = "0x2897CD0", VA = "0x289BCD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public struct Point : IEquatable<Point>
	{
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x0")]
		private int x;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x4")]
		private int y;

		[Token(Token = "0x17000008")]
		public int X
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x289BD9C", Offset = "0x2897D9C", VA = "0x289BD9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000009")]
		public int Y
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x289BDA4", Offset = "0x2897DA4", VA = "0x289BDA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x289BDAC", Offset = "0x2897DAC", VA = "0x289BDAC")]
		public static bool operator ==(Point left, Point right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x289BDB8", Offset = "0x2897DB8", VA = "0x289BDB8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x289BE30", Offset = "0x2897E30", VA = "0x289BE30", Slot = "4")]
		public bool Equals(Point other)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x289BE40", Offset = "0x2897E40", VA = "0x289BE40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x289BEA0", Offset = "0x2897EA0", VA = "0x289BEA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public struct PointF : IEquatable<PointF>
	{
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x0")]
		private float x;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x4")]
		private float y;

		[Token(Token = "0x1700000A")]
		public float X
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x289BFC4", Offset = "0x2897FC4", VA = "0x289BFC4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000B")]
		public float Y
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x289BFCC", Offset = "0x2897FCC", VA = "0x289BFCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x289BFD4", Offset = "0x2897FD4", VA = "0x289BFD4")]
		public static bool operator ==(PointF left, PointF right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x289BFE4", Offset = "0x2897FE4", VA = "0x289BFE4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x289C06C", Offset = "0x289806C", VA = "0x289C06C", Slot = "4")]
		public bool Equals(PointF other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x289C084", Offset = "0x2898084", VA = "0x289C084", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x289C11C", Offset = "0x289811C", VA = "0x289C11C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public struct Rectangle : IEquatable<Rectangle>
	{
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x0")]
		private int x;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x4")]
		private int y;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x8")]
		private int width;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0xC")]
		private int height;

		[Token(Token = "0x1700000C")]
		public int X
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x289C224", Offset = "0x2898224", VA = "0x289C224")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000D")]
		public int Y
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x289C22C", Offset = "0x289822C", VA = "0x289C22C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000E")]
		public int Width
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x289C234", Offset = "0x2898234", VA = "0x289C234")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000F")]
		public int Height
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x289C23C", Offset = "0x289823C", VA = "0x289C23C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x289C244", Offset = "0x2898244", VA = "0x289C244", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x289C2E4", Offset = "0x28982E4", VA = "0x289C2E4", Slot = "4")]
		public bool Equals(Rectangle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x289C318", Offset = "0x2898318", VA = "0x289C318")]
		public static bool operator ==(Rectangle left, Rectangle right)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x289C340", Offset = "0x2898340", VA = "0x289C340", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x289C3BC", Offset = "0x28983BC", VA = "0x289C3BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public struct RectangleF : IEquatable<RectangleF>
	{
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x0")]
		private float x;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x4")]
		private float y;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x8")]
		private float width;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0xC")]
		private float height;

		[Token(Token = "0x17000010")]
		public float X
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x289C570", Offset = "0x2898570", VA = "0x289C570")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		public float Y
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x289C578", Offset = "0x2898578", VA = "0x289C578")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		public float Width
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x289C580", Offset = "0x2898580", VA = "0x289C580")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		public float Height
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x289C588", Offset = "0x2898588", VA = "0x289C588")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x289C590", Offset = "0x2898590", VA = "0x289C590", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x289C640", Offset = "0x2898640", VA = "0x289C640", Slot = "4")]
		public bool Equals(RectangleF other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x289C670", Offset = "0x2898670", VA = "0x289C670")]
		public static bool operator ==(RectangleF left, RectangleF right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x289C698", Offset = "0x2898698", VA = "0x289C698", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x289C770", Offset = "0x2898770", VA = "0x289C770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public struct Size : IEquatable<Size>
	{
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x0")]
		private int width;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x4")]
		private int height;

		[Token(Token = "0x17000014")]
		public int Width
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x289C930", Offset = "0x2898930", VA = "0x289C930")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		public int Height
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x289C938", Offset = "0x2898938", VA = "0x289C938")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x289C924", Offset = "0x2898924", VA = "0x289C924")]
		public static bool operator ==(Size sz1, Size sz2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x289C940", Offset = "0x2898940", VA = "0x289C940", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x289C9B8", Offset = "0x28989B8", VA = "0x289C9B8", Slot = "4")]
		public bool Equals(Size other)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x289C9C8", Offset = "0x28989C8", VA = "0x289C9C8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x289CA28", Offset = "0x2898A28", VA = "0x289CA28", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public struct SizeF : IEquatable<SizeF>
	{
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x0")]
		private float width;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x4")]
		private float height;

		[Token(Token = "0x17000016")]
		public float Width
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x289CB40", Offset = "0x2898B40", VA = "0x289CB40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		public float Height
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x289CB48", Offset = "0x2898B48", VA = "0x289CB48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x289CB30", Offset = "0x2898B30", VA = "0x289CB30")]
		public static bool operator ==(SizeF sz1, SizeF sz2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x289CB50", Offset = "0x2898B50", VA = "0x289CB50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x289CBD8", Offset = "0x2898BD8", VA = "0x289CBD8", Slot = "4")]
		public bool Equals(SizeF other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x289CBF0", Offset = "0x2898BF0", VA = "0x289CBF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x289CC88", Offset = "0x2898C88", VA = "0x289CC88", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
