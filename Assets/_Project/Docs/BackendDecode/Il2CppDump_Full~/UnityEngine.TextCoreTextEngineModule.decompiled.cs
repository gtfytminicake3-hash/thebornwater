using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.Internal;
using UnityEngine.Serialization;
using UnityEngine.TextCore.LowLevel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.TextCore.Text;

[Serializable]
[Token(Token = "0x2000002")]
public class Character : TextElement
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2E8B5F0", Offset = "0x2E875F0", VA = "0x2E8B5F0")]
	public Character()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2E8B628", Offset = "0x2E87628", VA = "0x2E8B628")]
	public Character(uint unicode, FontAsset fontAsset, Glyph glyph)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2E8B6A8", Offset = "0x2E876A8", VA = "0x2E8B6A8")]
	internal Character(uint unicode, uint glyphIndex)
	{
	}
}
[Token(Token = "0x2000003")]
internal static class ColorUtilities
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2E8B6E8", Offset = "0x2E876E8", VA = "0x2E8B6E8")]
	internal static bool CompareColors(Color32 a, Color32 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2E8B6F8", Offset = "0x2E876F8", VA = "0x2E8B6F8")]
	internal static Color32 MultiplyColors(Color32 c1, Color32 c2)
	{
		return default(Color32);
	}
}
[Token(Token = "0x2000004")]
public enum TextFontWeight
{
	[Token(Token = "0x4000002")]
	Thin = 100,
	[Token(Token = "0x4000003")]
	ExtraLight = 200,
	[Token(Token = "0x4000004")]
	Light = 300,
	[Token(Token = "0x4000005")]
	Regular = 400,
	[Token(Token = "0x4000006")]
	Medium = 500,
	[Token(Token = "0x4000007")]
	SemiBold = 600,
	[Token(Token = "0x4000008")]
	Bold = 700,
	[Token(Token = "0x4000009")]
	Heavy = 800,
	[Token(Token = "0x400000A")]
	Black = 900
}
[Serializable]
[Token(Token = "0x2000005")]
public struct FontWeightPair
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public FontAsset regularTypeface;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public FontAsset italicTypeface;
}
[Serializable]
[Token(Token = "0x2000006")]
[ExcludeFromDocs]
public struct FontAssetCreationEditorSettings
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string sourceFontFileGUID;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int faceIndex;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int pointSizeSamplingMode;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int pointSize;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int padding;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int paddingMode;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int packingMode;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int atlasWidth;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int atlasHeight;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int characterSetSelectionMode;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string characterSequence;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string referencedFontAssetGUID;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string referencedTextAssetGUID;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int fontStyle;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float fontStyleModifier;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int renderMode;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool includeFontFeatures;
}
[Token(Token = "0x2000007")]
public enum AtlasPopulationMode
{
	[Token(Token = "0x400001F")]
	Static,
	[Token(Token = "0x4000020")]
	Dynamic,
	[Token(Token = "0x4000021")]
	DynamicOS
}
[Serializable]
[Token(Token = "0x2000008")]
[ExcludeFromPreset]
public class FontAsset : TextAsset
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	internal string m_SourceFontFileGUID;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Font m_SourceFontFile;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private string m_SourceFontFilePath;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[SerializeField]
	internal bool InternalDynamicOS;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	internal FaceInfo m_FaceInfo;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private int m_FamilyNameHashCode;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private int m_StyleNameHashCode;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	internal List<Glyph> m_GlyphTable;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[SerializeField]
	internal List<Character> m_CharacterTable;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	internal Dictionary<uint, Character> m_CharacterLookupDictionary;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	internal Texture2D m_AtlasTexture;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[SerializeField]
	internal Texture2D[] m_AtlasTextures;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	internal int m_AtlasTextureIndex;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	internal int m_AtlasWidth;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	[SerializeField]
	internal int m_AtlasHeight;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[SerializeField]
	internal int m_AtlasPadding;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[SerializeField]
	internal FontFeatureTable m_FontFeatureTable;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[SerializeField]
	internal List<FontAsset> m_FallbackFontAssetTable;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[SerializeField]
	private FontWeightPair[] m_FontWeightTable;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	[FormerlySerializedAs("normalStyle")]
	internal float m_RegularStyleWeight;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	[FormerlySerializedAs("normalSpacingOffset")]
	[SerializeField]
	internal float m_RegularStyleSpacing;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[FormerlySerializedAs("boldStyle")]
	[SerializeField]
	internal float m_BoldStyleWeight;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	[SerializeField]
	[FormerlySerializedAs("boldSpacing")]
	internal float m_BoldStyleSpacing;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	[FormerlySerializedAs("italicStyle")]
	internal byte m_ItalicStyleSlant;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x199")]
	[FormerlySerializedAs("tabSize")]
	[SerializeField]
	internal byte m_TabMultiple;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19A")]
	internal bool IsFontAssetLookupTablesDirty;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ProfilerMarker k_AddSynthesizedCharactersMarker;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static ProfilerMarker k_TryAddCharacterMarker;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static ProfilerMarker k_TryAddCharactersMarker;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static ProfilerMarker k_ClearFontAssetDataMarker;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static ProfilerMarker k_UpdateFontAssetDataMarker;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static ProfilerMarker k_TryAddGlyphMarker;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string s_DefaultMaterialSuffix;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static HashSet<int> k_SearchedFontAssetLookup;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private List<Glyph> m_GlyphsToRender;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private List<Glyph> m_GlyphsRendered;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private List<uint> m_GlyphIndexList;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private List<uint> m_GlyphIndexListNewlyAdded;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal List<uint> m_GlyphsToAdd;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal HashSet<uint> m_GlyphsToAddLookup;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	internal List<Character> m_CharactersToAdd;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	internal HashSet<uint> m_CharactersToAddLookup;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	internal List<uint> s_MissingCharacterList;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	internal HashSet<uint> m_MissingUnicodesFromFontFile;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	internal static uint[] k_GlyphIndexArray;

	[Token(Token = "0x17000001")]
	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2E8B7DC", Offset = "0x2E877DC", VA = "0x2E8B7DC")]
		get
		{
			return default(FontAssetCreationEditorSettings);
		}
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2E8B7EC", Offset = "0x2E877EC", VA = "0x2E8B7EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Font sourceFontFile
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2E8B7F8", Offset = "0x2E877F8", VA = "0x2E8B7F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2E8B800", Offset = "0x2E87800", VA = "0x2E8B800")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public AtlasPopulationMode atlasPopulationMode
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2E8B808", Offset = "0x2E87808", VA = "0x2E8B808")]
		get
		{
			return default(AtlasPopulationMode);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2E8B810", Offset = "0x2E87810", VA = "0x2E8B810")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public FaceInfo faceInfo
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2E8B818", Offset = "0x2E87818", VA = "0x2E8B818")]
		get
		{
			return default(FaceInfo);
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2E8B828", Offset = "0x2E87828", VA = "0x2E8B828")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	internal int familyNameHashCode
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2E8B834", Offset = "0x2E87834", VA = "0x2E8B834")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2E8B864", Offset = "0x2E87864", VA = "0x2E8B864")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	internal int styleNameHashCode
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2E8B86C", Offset = "0x2E8786C", VA = "0x2E8B86C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2E8B89C", Offset = "0x2E8789C", VA = "0x2E8B89C")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public List<Glyph> glyphTable
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2E8B8A4", Offset = "0x2E878A4", VA = "0x2E8B8A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2E8B8AC", Offset = "0x2E878AC", VA = "0x2E8B8AC")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Dictionary<uint, Glyph> glyphLookupTable
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2E8B8B4", Offset = "0x2E878B4", VA = "0x2E8B8B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	public List<Character> characterTable
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2E8BC7C", Offset = "0x2E87C7C", VA = "0x2E8BC7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2E8BC84", Offset = "0x2E87C84", VA = "0x2E8BC84")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Dictionary<uint, Character> characterLookupTable
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2E8BC8C", Offset = "0x2E87C8C", VA = "0x2E8BC8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	public Texture2D atlasTexture
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2E8BCB0", Offset = "0x2E87CB0", VA = "0x2E8BCB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000C")]
	public Texture2D[] atlasTextures
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2E8BD40", Offset = "0x2E87D40", VA = "0x2E8BD40")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2E8BD48", Offset = "0x2E87D48", VA = "0x2E8BD48")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public int atlasTextureCount
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2E8BD50", Offset = "0x2E87D50", VA = "0x2E8BD50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000E")]
	public bool isMultiAtlasTexturesEnabled
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2E8BD5C", Offset = "0x2E87D5C", VA = "0x2E8BD5C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2E8BD64", Offset = "0x2E87D64", VA = "0x2E8BD64")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	internal bool clearDynamicDataOnBuild
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2E8BD6C", Offset = "0x2E87D6C", VA = "0x2E8BD6C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2E8BD74", Offset = "0x2E87D74", VA = "0x2E8BD74")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public int atlasWidth
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2E8BD7C", Offset = "0x2E87D7C", VA = "0x2E8BD7C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2E8BD84", Offset = "0x2E87D84", VA = "0x2E8BD84")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public int atlasHeight
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2E8BD8C", Offset = "0x2E87D8C", VA = "0x2E8BD8C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2E8BD94", Offset = "0x2E87D94", VA = "0x2E8BD94")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public int atlasPadding
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2E8BD9C", Offset = "0x2E87D9C", VA = "0x2E8BD9C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2E8BDA4", Offset = "0x2E87DA4", VA = "0x2E8BDA4")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public GlyphRenderMode atlasRenderMode
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2E8BDAC", Offset = "0x2E87DAC", VA = "0x2E8BDAC")]
		get
		{
			return default(GlyphRenderMode);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2E8BDB4", Offset = "0x2E87DB4", VA = "0x2E8BDB4")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000014")]
	internal List<GlyphRect> usedGlyphRects
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2E8BDBC", Offset = "0x2E87DBC", VA = "0x2E8BDBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2E8BDC4", Offset = "0x2E87DC4", VA = "0x2E8BDC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	internal List<GlyphRect> freeGlyphRects
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2E8BDCC", Offset = "0x2E87DCC", VA = "0x2E8BDCC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2E8BDD4", Offset = "0x2E87DD4", VA = "0x2E8BDD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public FontFeatureTable fontFeatureTable
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2E8BDDC", Offset = "0x2E87DDC", VA = "0x2E8BDDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2E8BDE4", Offset = "0x2E87DE4", VA = "0x2E8BDE4")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public List<FontAsset> fallbackFontAssetTable
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2E8BDEC", Offset = "0x2E87DEC", VA = "0x2E8BDEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2E8BDF4", Offset = "0x2E87DF4", VA = "0x2E8BDF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public FontWeightPair[] fontWeightTable
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2E8BDFC", Offset = "0x2E87DFC", VA = "0x2E8BDFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2E8BE04", Offset = "0x2E87E04", VA = "0x2E8BE04")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public float regularStyleWeight
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2E8BE0C", Offset = "0x2E87E0C", VA = "0x2E8BE0C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2E8BE14", Offset = "0x2E87E14", VA = "0x2E8BE14")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public float regularStyleSpacing
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2E8BE1C", Offset = "0x2E87E1C", VA = "0x2E8BE1C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2E8BE24", Offset = "0x2E87E24", VA = "0x2E8BE24")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public float boldStyleWeight
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2E8BE2C", Offset = "0x2E87E2C", VA = "0x2E8BE2C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2E8BE34", Offset = "0x2E87E34", VA = "0x2E8BE34")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public float boldStyleSpacing
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2E8BE3C", Offset = "0x2E87E3C", VA = "0x2E8BE3C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2E8BE44", Offset = "0x2E87E44", VA = "0x2E8BE44")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public byte italicStyleSlant
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2E8BE4C", Offset = "0x2E87E4C", VA = "0x2E8BE4C")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2E8BE54", Offset = "0x2E87E54", VA = "0x2E8BE54")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public byte tabMultiple
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2E8BE5C", Offset = "0x2E87E5C", VA = "0x2E8BE5C")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2E8BE64", Offset = "0x2E87E64", VA = "0x2E8BE64")]
		set
		{
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2E8BE6C", Offset = "0x2E87E6C", VA = "0x2E8BE6C")]
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2E8C1B8", Offset = "0x2E881B8", VA = "0x2E8C1B8")]
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2E8C044", Offset = "0x2E88044", VA = "0x2E8C044")]
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.DynamicOS, bool enableMultiAtlasSupport = true)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2E8C6E8", Offset = "0x2E886E8", VA = "0x2E8C6E8")]
	public static FontAsset CreateFontAsset(Font font)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2E8C764", Offset = "0x2E88764", VA = "0x2E8C764")]
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2E8C824", Offset = "0x2E88824", VA = "0x2E8C824")]
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2E8C26C", Offset = "0x2E8826C", VA = "0x2E8C26C")]
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2E8CA54", Offset = "0x2E88A54", VA = "0x2E8CA54")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2E8CA58", Offset = "0x2E88A58", VA = "0x2E8CA58")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2E8B8D8", Offset = "0x2E878D8", VA = "0x2E8B8D8")]
	public void ReadFontAssetDefinition()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2E8CB80", Offset = "0x2E88B80", VA = "0x2E8CB80")]
	internal void InitializeDictionaryLookupTables()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2E8CD90", Offset = "0x2E88D90", VA = "0x2E8CD90")]
	internal void InitializeGlyphLookupDictionary()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2E8D018", Offset = "0x2E89018", VA = "0x2E8D018")]
	internal void InitializeCharacterLookupDictionary()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2E8D1B0", Offset = "0x2E891B0", VA = "0x2E8D1B0")]
	internal void InitializeLigatureSubstitutionLookupDictionary()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2E8D4D4", Offset = "0x2E894D4", VA = "0x2E8D4D4")]
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2E8D704", Offset = "0x2E89704", VA = "0x2E8D704")]
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2E8D8D4", Offset = "0x2E898D4", VA = "0x2E8D8D4")]
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2E8CBB8", Offset = "0x2E88BB8", VA = "0x2E8CBB8")]
	internal void AddSynthesizedCharactersAndFaceMetrics()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2E8DC20", Offset = "0x2E89C20", VA = "0x2E8DC20")]
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2E8DE34", Offset = "0x2E89E34", VA = "0x2E8DE34")]
	internal void AddCharacterToLookupCache(uint unicode, Character character)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2E8DAAC", Offset = "0x2E89AAC", VA = "0x2E8DAAC")]
	private FontEngineError LoadFontFace()
	{
		return default(FontEngineError);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2E8DE9C", Offset = "0x2E89E9C", VA = "0x2E8DE9C")]
	internal void SortCharacterTable()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2E8DFD0", Offset = "0x2E89FD0", VA = "0x2E8DFD0")]
	internal void SortGlyphTable()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2E8E104", Offset = "0x2E8A104", VA = "0x2E8E104")]
	internal void SortFontFeatureTable()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2E8E6FC", Offset = "0x2E8A6FC", VA = "0x2E8E6FC")]
	internal void SortAllTables()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2E8E71C", Offset = "0x2E8A71C", VA = "0x2E8E71C")]
	public bool HasCharacter(int character)
	{
		return default(bool);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2E8E77C", Offset = "0x2E8A77C", VA = "0x2E8E77C")]
	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2E8E784", Offset = "0x2E8A784", VA = "0x2E8E784")]
	public bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2E8F41C", Offset = "0x2E8B41C", VA = "0x2E8F41C")]
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2E8F63C", Offset = "0x2E8B63C", VA = "0x2E8F63C")]
	public bool HasCharacters(string text, out List<char> missingCharacters)
	{
		return default(bool);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2E8F7DC", Offset = "0x2E8B7DC", VA = "0x2E8F7DC")]
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2E8FC1C", Offset = "0x2E8BC1C", VA = "0x2E8FC1C")]
	public bool HasCharacters(string text)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2E8FCD8", Offset = "0x2E8BCD8", VA = "0x2E8FCD8")]
	public static string GetCharacters(FontAsset fontAsset)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2E8FDE8", Offset = "0x2E8BDE8", VA = "0x2E8FDE8")]
	public static int[] GetCharactersArray(FontAsset fontAsset)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2E8FECC", Offset = "0x2E8BECC", VA = "0x2E8FECC")]
	internal uint GetGlyphIndex(uint unicode)
	{
		return default(uint);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2E8FFA8", Offset = "0x2E8BFA8", VA = "0x2E8FFA8")]
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2E90100", Offset = "0x2E8C100", VA = "0x2E90100")]
	internal static void UpdateFontFeaturesForFontAssetsInQueue()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2E902C0", Offset = "0x2E8C2C0", VA = "0x2E902C0")]
	internal static void RegisterAtlasTextureForApply(Texture2D texture)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2E903E8", Offset = "0x2E8C3E8", VA = "0x2E903E8")]
	internal static void UpdateAtlasTexturesInQueue()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2E9055C", Offset = "0x2E8C55C", VA = "0x2E9055C")]
	internal static void UpdateFontAssetsInUpdateQueue()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2E905AC", Offset = "0x2E8C5AC", VA = "0x2E905AC")]
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2E905C8", Offset = "0x2E8C5C8", VA = "0x2E905C8")]
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2E91600", Offset = "0x2E8D600", VA = "0x2E91600")]
	public bool TryAddCharacters(string characters, bool includeFontFeatures = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2E9161C", Offset = "0x2E8D61C", VA = "0x2E9161C")]
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2E921D0", Offset = "0x2E8E1D0", VA = "0x2E921D0")]
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph)
	{
		return default(bool);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2E8EA9C", Offset = "0x2E8AA9C", VA = "0x2E8EA9C")]
	internal bool TryAddCharacterInternal(uint unicode, out Character character, bool shouldGetFontFeatures = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2E92C7C", Offset = "0x2E8EC7C", VA = "0x2E92C7C")]
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out Character character, bool shouldGetFontFeatures = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2E931CC", Offset = "0x2E8F1CC", VA = "0x2E931CC")]
	internal void TryAddGlyphsToAtlasTextures()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2E9118C", Offset = "0x2E8D18C", VA = "0x2E9118C")]
	private bool TryAddGlyphsToNewAtlasTexture()
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2E92A60", Offset = "0x2E8EA60", VA = "0x2E92A60")]
	private void SetupNewAtlasTexture()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2E90268", Offset = "0x2E8C268", VA = "0x2E90268")]
	private void UpdateAllFontFeatures()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2E931D0", Offset = "0x2E8F1D0", VA = "0x2E931D0")]
	internal void UpdateGlyphAdjustmentRecords()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2E93898", Offset = "0x2E8F898", VA = "0x2E93898")]
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2E93CD8", Offset = "0x2E8FCD8", VA = "0x2E93CD8")]
	internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2E93CDC", Offset = "0x2E8FCDC", VA = "0x2E93CDC")]
	internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
	{
	}

	[Token(Token = "0x6000075")]
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2E93CE0", Offset = "0x2E8FCE0", VA = "0x2E93CE0")]
	public void ClearFontAssetData(bool setAtlasSizeToZero = false)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2E94288", Offset = "0x2E90288", VA = "0x2E94288")]
	internal void ClearFontAssetDataInternal(bool clearFontFeatures = false)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2E942A4", Offset = "0x2E902A4", VA = "0x2E942A4")]
	internal void UpdateFontAssetData()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2E93E14", Offset = "0x2E8FE14", VA = "0x2E93E14")]
	internal void ClearFontAssetTables(bool clearFontFeatures)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2E940A8", Offset = "0x2E900A8", VA = "0x2E940A8")]
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2E8CABC", Offset = "0x2E88ABC", VA = "0x2E8CABC")]
	private void DestroyAtlasTextures()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2E944C4", Offset = "0x2E904C4", VA = "0x2E944C4")]
	public FontAsset()
	{
	}
}
[Token(Token = "0x200000A")]
internal static class FontAssetUtilities
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static HashSet<int> k_SearchedAssets;

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2E94B5C", Offset = "0x2E90B5C", VA = "0x2E94B5C")]
	internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2E94C5C", Offset = "0x2E90C5C", VA = "0x2E94C5C")]
	private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2E950C8", Offset = "0x2E910C8", VA = "0x2E950C8")]
	public static Character GetCharacterFromFontAssets(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2E95278", Offset = "0x2E91278", VA = "0x2E95278")]
	public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2E95538", Offset = "0x2E91538", VA = "0x2E95538")]
	private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200000B")]
public class FontFeatureTable
{
	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	internal List<UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord> m_MultipleSubstitutionRecords;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	internal List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord> m_LigatureSubstitutionRecords;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal List<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	internal List<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal Dictionary<uint, List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	internal Dictionary<uint, UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	internal Dictionary<uint, UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2E93640", Offset = "0x2E8F640", VA = "0x2E93640")]
	internal FontFeatureTable()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2E8E138", Offset = "0x2E8A138", VA = "0x2E8E138")]
	public void SortGlyphPairAdjustmentRecords()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2E8E324", Offset = "0x2E8A324", VA = "0x2E8E324")]
	public void SortMarkToBaseAdjustmentRecords()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2E8E510", Offset = "0x2E8A510", VA = "0x2E8E510")]
	public void SortMarkToMarkAdjustmentRecords()
	{
	}
}
[Token(Token = "0x200000D")]
internal struct Extents
{
	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector2 min;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector2 max;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2E9580C", Offset = "0x2E9180C", VA = "0x2E9580C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
internal struct LineInfo
{
	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal int controlCharacterCount;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int characterCount;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int visibleCharacterCount;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int spaceCount;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int visibleSpaceCount;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int wordCount;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int firstCharacterIndex;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int firstVisibleCharacterIndex;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int lastCharacterIndex;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int lastVisibleCharacterIndex;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float length;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float lineHeight;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float ascender;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float baseline;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float descender;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float maxAdvance;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float width;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float marginLeft;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float marginRight;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public TextAlignment alignment;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Extents lineExtents;
}
[Token(Token = "0x200000F")]
internal struct LinkInfo
{
	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int hashCode;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int linkIdFirstCharacterIndex;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int linkIdLength;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int linkTextfirstCharacterIndex;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int linkTextLength;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal char[] linkId;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string m_LinkIdString;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string m_LinkTextString;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2E959AC", Offset = "0x2E919AC", VA = "0x2E959AC")]
	internal void SetLinkId(char[] text, int startIndex, int length)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2E95A90", Offset = "0x2E91A90", VA = "0x2E95A90")]
	public string GetLinkText(TextInfo textInfo)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2E95B88", Offset = "0x2E91B88", VA = "0x2E95B88")]
	public string GetLinkId()
	{
		return null;
	}
}
[Token(Token = "0x2000010")]
internal static class MaterialManager
{
	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<long, Material> s_FallbackMaterials;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2E95BCC", Offset = "0x2E91BCC", VA = "0x2E95BCC")]
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2E9620C", Offset = "0x2E9220C", VA = "0x2E9620C")]
	public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2E95F84", Offset = "0x2E91F84", VA = "0x2E95F84")]
	private static void CopyMaterialPresetProperties(Material source, Material destination)
	{
	}
}
[Token(Token = "0x2000011")]
internal struct MaterialReference
{
	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int index;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public FontAsset fontAsset;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SpriteAsset spriteAsset;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material material;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isDefaultMaterial;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool isFallbackMaterial;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material fallbackMaterial;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float padding;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int referenceCount;

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2E964B8", Offset = "0x2E924B8", VA = "0x2E964B8")]
	public MaterialReference(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2E96534", Offset = "0x2E92534", VA = "0x2E96534")]
	public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
	{
		return default(int);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2E96744", Offset = "0x2E92744", VA = "0x2E96744")]
	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
	{
		return default(int);
	}
}
[Token(Token = "0x2000012")]
internal class MaterialReferenceManager
{
	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MaterialReferenceManager s_Instance;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<int, Material> m_FontMaterialReferenceLookup;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<int, FontAsset> m_FontAssetReferenceLookup;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup;

	[Token(Token = "0x1700001F")]
	public static MaterialReferenceManager instance
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2E96924", Offset = "0x2E92924", VA = "0x2E96924")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2E96AEC", Offset = "0x2E92AEC", VA = "0x2E96AEC")]
	public static void AddFontAsset(FontAsset fontAsset)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2E96B0C", Offset = "0x2E92B0C", VA = "0x2E96B0C")]
	private void AddFontAssetInternal(FontAsset fontAsset)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2E96CBC", Offset = "0x2E92CBC", VA = "0x2E96CBC")]
	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2E96CEC", Offset = "0x2E92CEC", VA = "0x2E96CEC")]
	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2E96DC0", Offset = "0x2E92DC0", VA = "0x2E96DC0")]
	public static void AddFontMaterial(int hashCode, Material material)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2E96DF0", Offset = "0x2E92DF0", VA = "0x2E96DF0")]
	private void AddFontMaterialInternal(int hashCode, Material material)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2E96E58", Offset = "0x2E92E58", VA = "0x2E96E58")]
	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2E96E88", Offset = "0x2E92E88", VA = "0x2E96E88")]
	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x2E96F2C", Offset = "0x2E92F2C", VA = "0x2E96F2C")]
	public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2E96F5C", Offset = "0x2E92F5C", VA = "0x2E96F5C")]
	private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2E96FC8", Offset = "0x2E92FC8", VA = "0x2E96FC8")]
	public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2E96FF8", Offset = "0x2E92FF8", VA = "0x2E96FF8")]
	private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x2E97064", Offset = "0x2E93064", VA = "0x2E97064")]
	public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2E97094", Offset = "0x2E93094", VA = "0x2E97094")]
	private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2E97100", Offset = "0x2E93100", VA = "0x2E97100")]
	public static bool TryGetMaterial(int hashCode, out Material material)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2E97130", Offset = "0x2E93130", VA = "0x2E97130")]
	private bool TryGetMaterialInternal(int hashCode, out Material material)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2E96998", Offset = "0x2E92998", VA = "0x2E96998")]
	public MaterialReferenceManager()
	{
	}
}
[Token(Token = "0x2000013")]
internal enum VertexSortingOrder
{
	[Token(Token = "0x40000A1")]
	Normal,
	[Token(Token = "0x40000A2")]
	Reverse
}
[Token(Token = "0x2000014")]
internal struct MeshInfo
{
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Color32 k_DefaultColor;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly Vector3 k_DefaultNormal;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Vector4 k_DefaultTangent;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int vertexCount;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector3[] vertices;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] normals;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4[] tangents;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4[] uvs0;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2[] uvs2;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color32[] colors32;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int[] triangles;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material material;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	internal GlyphRenderMode glyphRenderMode;

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2E9719C", Offset = "0x2E9319C", VA = "0x2E9719C")]
	public MeshInfo(int size)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2E97598", Offset = "0x2E93598", VA = "0x2E97598")]
	internal void ResizeMeshInfo(int size)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2E97778", Offset = "0x2E93778", VA = "0x2E97778")]
	internal void Clear(bool uploadChanges)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2E977A4", Offset = "0x2E937A4", VA = "0x2E977A4")]
	internal void ClearUnusedVertices()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2E977D8", Offset = "0x2E937D8", VA = "0x2E977D8")]
	internal void SortGeometry(VertexSortingOrder order)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2E9788C", Offset = "0x2E9388C", VA = "0x2E9788C")]
	internal void SwapVertexData(int src, int dst)
	{
	}
}
[Token(Token = "0x2000015")]
[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/2022.3/Documentation/Manual/UIE-sprite.html")]
public class SpriteAsset : TextAsset
{
	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal Dictionary<int, int> m_NameLookup;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	internal Dictionary<uint, int> m_GlyphIndexLookup;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	internal FaceInfo m_FaceInfo;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	internal Texture m_SpriteAtlasTexture;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private List<SpriteCharacter> m_SpriteCharacterTable;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	internal Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private List<SpriteGlyph> m_SpriteGlyphTable;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	internal Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public List<SpriteAsset> fallbackSpriteAssets;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	internal bool m_IsSpriteAssetLookupTablesDirty;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static HashSet<int> k_searchedSpriteAssets;

	[Token(Token = "0x17000020")]
	public FaceInfo faceInfo
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2E97C84", Offset = "0x2E93C84", VA = "0x2E97C84")]
		get
		{
			return default(FaceInfo);
		}
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2E97C94", Offset = "0x2E93C94", VA = "0x2E97C94")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public Texture spriteSheet
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2E97CA0", Offset = "0x2E93CA0", VA = "0x2E97CA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2E97CA8", Offset = "0x2E93CA8", VA = "0x2E97CA8")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public List<SpriteCharacter> spriteCharacterTable
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2E97CB0", Offset = "0x2E93CB0", VA = "0x2E97CB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2E9818C", Offset = "0x2E9418C", VA = "0x2E9818C")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2E95514", Offset = "0x2E91514", VA = "0x2E95514")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2E98194", Offset = "0x2E94194", VA = "0x2E98194")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public List<SpriteGlyph> spriteGlyphTable
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2E9819C", Offset = "0x2E9419C", VA = "0x2E9819C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2E981A4", Offset = "0x2E941A4", VA = "0x2E981A4")]
		internal set
		{
		}
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2E981AC", Offset = "0x2E941AC", VA = "0x2E981AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2E97CD4", Offset = "0x2E93CD4", VA = "0x2E97CD4")]
	public void UpdateLookupTables()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x2E981B8", Offset = "0x2E941B8", VA = "0x2E981B8")]
	public int GetSpriteIndexFromHashcode(int hashCode)
	{
		return default(int);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2E98240", Offset = "0x2E94240", VA = "0x2E98240")]
	public int GetSpriteIndexFromUnicode(uint unicode)
	{
		return default(int);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x2E982D4", Offset = "0x2E942D4", VA = "0x2E982D4")]
	public int GetSpriteIndexFromName(string name)
	{
		return default(int);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x2E98314", Offset = "0x2E94314", VA = "0x2E98314")]
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2E984D8", Offset = "0x2E944D8", VA = "0x2E984D8")]
	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2E98674", Offset = "0x2E94674", VA = "0x2E98674")]
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x2E98724", Offset = "0x2E94724", VA = "0x2E98724")]
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, [Optional] TextSettings textSettings)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x2E98A5C", Offset = "0x2E94A5C", VA = "0x2E98A5C")]
	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2E98C00", Offset = "0x2E94C00", VA = "0x2E98C00")]
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2E98CB0", Offset = "0x2E94CB0", VA = "0x2E98CB0")]
	public void SortGlyphTable()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2E98DE0", Offset = "0x2E94DE0", VA = "0x2E98DE0")]
	internal void SortCharacterTable()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2E98F14", Offset = "0x2E94F14", VA = "0x2E98F14")]
	internal void SortGlyphAndCharacterTables()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x2E98F2C", Offset = "0x2E94F2C", VA = "0x2E98F2C")]
	public SpriteAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x2000017")]
public class SpriteCharacter : TextElement
{
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string m_Name;

	[Token(Token = "0x17000025")]
	public string name
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2E981B0", Offset = "0x2E941B0", VA = "0x2E981B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2E99084", Offset = "0x2E95084", VA = "0x2E99084")]
	public SpriteCharacter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class SpriteGlyph : Glyph
{
	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Sprite sprite;

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2E990A4", Offset = "0x2E950A4", VA = "0x2E990A4")]
	public SpriteGlyph()
	{
	}
}
[Serializable]
[Token(Token = "0x2000019")]
[ExcludeFromObjectFactory]
public abstract class TextAsset : ScriptableObject
{
	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	internal string m_Version;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal int m_InstanceID;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	internal int m_HashCode;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("material")]
	[SerializeField]
	internal Material m_Material;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal int m_MaterialHashCode;

	[Token(Token = "0x17000026")]
	public string version
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2E990AC", Offset = "0x2E950AC", VA = "0x2E990AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2E990B4", Offset = "0x2E950B4", VA = "0x2E990B4")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public int instanceID
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2E900D8", Offset = "0x2E8C0D8", VA = "0x2E900D8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000028")]
	public int hashCode
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2E96BF4", Offset = "0x2E92BF4", VA = "0x2E96BF4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2E990BC", Offset = "0x2E950BC", VA = "0x2E990BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public Material material
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2E990C4", Offset = "0x2E950C4", VA = "0x2E990C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2E990CC", Offset = "0x2E950CC", VA = "0x2E990CC")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public int materialHashCode
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2E96C24", Offset = "0x2E92C24", VA = "0x2E96C24")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2E990D4", Offset = "0x2E950D4", VA = "0x2E990D4")]
		set
		{
		}
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x2E9473C", Offset = "0x2E9073C", VA = "0x2E9473C")]
	protected TextAsset()
	{
	}
}
[Token(Token = "0x200001A")]
public enum ColorGradientMode
{
	[Token(Token = "0x40000C6")]
	Single,
	[Token(Token = "0x40000C7")]
	HorizontalGradient,
	[Token(Token = "0x40000C8")]
	VerticalGradient,
	[Token(Token = "0x40000C9")]
	FourCornersGradient
}
[Serializable]
[Token(Token = "0x200001B")]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
public class TextColorGradient : ScriptableObject
{
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ColorGradientMode colorMode;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color topLeft;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color topRight;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Color bottomLeft;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Color bottomRight;

	[Token(Token = "0x40000CF")]
	private const ColorGradientMode k_DefaultColorMode = ColorGradientMode.FourCornersGradient;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Color k_DefaultColor;

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x2E990DC", Offset = "0x2E950DC", VA = "0x2E990DC")]
	public TextColorGradient()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x2E99178", Offset = "0x2E95178", VA = "0x2E99178")]
	public TextColorGradient(Color color)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x2E991E4", Offset = "0x2E951E4", VA = "0x2E991E4")]
	public TextColorGradient(Color color0, Color color1, Color color2, Color color3)
	{
	}
}
[Token(Token = "0x200001C")]
public enum TextElementType : byte
{
	[Token(Token = "0x40000D2")]
	Character = 1,
	[Token(Token = "0x40000D3")]
	Sprite
}
[Serializable]
[Token(Token = "0x200001D")]
public abstract class TextElement
{
	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	protected TextElementType m_ElementType;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	internal uint m_Unicode;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal TextAsset m_TextAsset;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal Glyph m_Glyph;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal uint m_GlyphIndex;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	internal float m_Scale;

	[Token(Token = "0x1700002B")]
	public TextElementType elementType
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2E992D4", Offset = "0x2E952D4", VA = "0x2E992D4")]
		get
		{
			return default(TextElementType);
		}
	}

	[Token(Token = "0x1700002C")]
	public uint unicode
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2E8DAA4", Offset = "0x2E89AA4", VA = "0x2E8DAA4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2E8B688", Offset = "0x2E87688", VA = "0x2E8B688")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public TextAsset textAsset
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2E950C0", Offset = "0x2E910C0", VA = "0x2E950C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2E8B690", Offset = "0x2E87690", VA = "0x2E8B690")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public Glyph glyph
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2E992DC", Offset = "0x2E952DC", VA = "0x2E992DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2E8B698", Offset = "0x2E87698", VA = "0x2E8B698")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public uint glyphIndex
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2E8CD88", Offset = "0x2E88D88", VA = "0x2E8CD88")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2E8B6A0", Offset = "0x2E876A0", VA = "0x2E8B6A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public float scale
	{
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2E992E4", Offset = "0x2E952E4", VA = "0x2E992E4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2E8B620", Offset = "0x2E87620", VA = "0x2E8B620")]
		set
		{
		}
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x2E8B618", Offset = "0x2E87618", VA = "0x2E8B618")]
	protected TextElement()
	{
	}
}
[Token(Token = "0x200001E")]
internal struct TextVertex
{
	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 uv;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector2 uv2;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color32 color;
}
[Token(Token = "0x200001F")]
internal struct TextElementInfo
{
	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public char character;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int index;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public TextElementType elementType;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int stringLength;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TextElement textElement;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Glyph alternativeGlyph;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FontAsset fontAsset;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SpriteAsset spriteAsset;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int spriteIndex;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material material;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int materialReferenceIndex;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool isUsingAlternateTypeface;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float pointSize;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int lineNumber;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int pageNumber;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int vertexIndex;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextVertex vertexTopLeft;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextVertex vertexBottomLeft;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextVertex vertexTopRight;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public TextVertex vertexBottomRight;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Vector3 topLeft;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public Vector3 bottomLeft;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Vector3 topRight;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public Vector3 bottomRight;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float origin;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public float ascender;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float baseLine;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public float descender;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	internal float adjustedAscender;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	internal float adjustedDescender;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	internal float adjustedHorizontalAdvance;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public float xAdvance;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public float aspectRatio;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	public float scale;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Color32 color;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public Color32 underlineColor;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public int underlineVertexIndex;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	public Color32 strikethroughColor;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public int strikethroughVertexIndex;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public Color32 highlightColor;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public HighlightState highlightState;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	public FontStyles style;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public bool isVisible;

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2E992EC", Offset = "0x2E952EC", VA = "0x2E992EC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000020")]
internal class TextGenerationSettings : IEquatable<TextGenerationSettings>
{
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string text;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rect screenRect;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector4 margins;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float scale;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public FontAsset fontAsset;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material material;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SpriteAsset spriteAsset;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextStyleSheet styleSheet;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public FontStyles fontStyle;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextSettings textSettings;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextAlignment textAlignment;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public TextOverflowMode overflowMode;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool wordWrap;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float wordWrappingRatio;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Color color;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TextColorGradient fontColorGradient;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextColorGradient fontColorGradientPreset;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool tintSprites;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	public bool overrideRichTextColors;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	public bool shouldConvertToLinearSpace;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float fontSize;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool autoSize;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float fontSizeMin;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float fontSizeMax;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public bool enableKerning;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
	public bool richText;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB6")]
	public bool isRightToLeft;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float extraPadding;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool parseControlCharacters;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
	public bool isOrthographic;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
	public bool tagNoParsing;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float characterSpacing;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public float wordSpacing;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float lineSpacing;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float paragraphSpacing;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float lineSpacingMax;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public TextWrappingMode textWrappingMode;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public int maxVisibleCharacters;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public int maxVisibleWords;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public int maxVisibleLines;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public int firstVisibleCharacter;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public bool useMaxVisibleDescender;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public TextFontWeight fontWeight;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public int pageToDisplay;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public TextureMapping horizontalMapping;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public TextureMapping verticalMapping;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float uvLineOffset;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public VertexSortingOrder geometrySortingOrder;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public bool inverseYAxis;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public float charWidthMaxAdj;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	internal TextInputSource inputSource;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x2E9A9E0", Offset = "0x2E969E0", VA = "0x2E9A9E0", Slot = "4")]
	public bool Equals(TextGenerationSettings other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x2E9AE54", Offset = "0x2E96E54", VA = "0x2E9AE54", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x2E9AF60", Offset = "0x2E96F60", VA = "0x2E9AF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x2E9B430", Offset = "0x2E97430", VA = "0x2E9B430")]
	public static bool operator ==(TextGenerationSettings left, TextGenerationSettings right)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x2E9B438", Offset = "0x2E97438", VA = "0x2E9B438", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x2E9CEE0", Offset = "0x2E98EE0", VA = "0x2E9CEE0")]
	public TextGenerationSettings()
	{
	}
}
[Token(Token = "0x2000021")]
internal class TextGenerator
{
	[Token(Token = "0x2000022")]
	public delegate void MissingCharacterEventCallback(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset);

	[Token(Token = "0x2000023")]
	protected struct SpecialCharacter
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Character character;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public FontAsset fontAsset;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material material;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int materialIndex;

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2EB1670", Offset = "0x2EAD670", VA = "0x2EB1670")]
		public SpecialCharacter(Character character, int materialIndex)
		{
		}
	}

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static TextGenerator s_TextGenerator;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private TextBackingContainer m_TextBackingArray;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal TextProcessingElement[] m_TextProcessingArray;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal int m_InternalTextProcessingArraySize;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private char[] m_HtmlTag;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal HighlightState m_HighlightState;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected bool m_IsIgnoringAlignment;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static bool m_IsTextTruncated;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static MissingCharacterEventCallback OnMissingCharacter;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] m_RectTransformCorners;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float m_MarginWidth;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_MarginHeight;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float m_PreferredWidth;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float m_PreferredHeight;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private FontAsset m_CurrentFontAsset;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Material m_CurrentMaterial;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int m_CurrentMaterialIndex;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private TextProcessingStack<MaterialReference> m_MaterialReferenceStack;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float m_Padding;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private SpriteAsset m_CurrentSpriteAsset;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int m_TotalCharacterCount;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float m_FontSize;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float m_FontScaleMultiplier;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float m_CurrentFontSize;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private TextProcessingStack<float> m_SizeStack;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	protected TextProcessingStack<int>[] m_TextStyleStacks;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	protected int m_TextStyleStackDepth;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private FontStyles m_FontStyleInternal;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private FontStyleStack m_FontStyleStack;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private TextFontWeight m_FontWeightInternal;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private TextProcessingStack<TextFontWeight> m_FontWeightStack;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private TextAlignment m_LineJustification;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private TextProcessingStack<TextAlignment> m_LineJustificationStack;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private float m_BaselineOffset;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private TextProcessingStack<float> m_BaselineOffsetStack;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Color32 m_FontColor32;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private Color32 m_HtmlColor;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Color32 m_UnderlineColor;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private Color32 m_StrikethroughColor;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private TextProcessingStack<Color32> m_ColorStack;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private TextProcessingStack<Color32> m_UnderlineColorStack;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private TextProcessingStack<Color32> m_StrikethroughColorStack;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private TextProcessingStack<Color32> m_HighlightColorStack;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private TextProcessingStack<HighlightState> m_HighlightStateStack;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private TextProcessingStack<int> m_ItalicAngleStack;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private TextColorGradient m_ColorGradientPreset;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private TextProcessingStack<TextColorGradient> m_ColorGradientStack;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private bool m_ColorGradientPresetIsTinted;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private TextProcessingStack<int> m_ActionStack;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	private float m_LineOffset;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
	private float m_LineHeight;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private bool m_IsDrivenLineSpacing;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
	private float m_CSpacing;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	private float m_MonoSpacing;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
	private float m_XAdvance;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	private float m_TagLineIndent;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
	private float m_TagIndent;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private TextProcessingStack<float> m_IndentStack;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	private bool m_TagNoParsing;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
	private int m_CharacterCount;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	private int m_FirstCharacterOfLine;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
	private int m_LastCharacterOfLine;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	private int m_FirstVisibleCharacterOfLine;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
	private int m_LastVisibleCharacterOfLine;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	private float m_MaxLineAscender;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
	private float m_MaxLineDescender;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	private int m_LineNumber;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
	private int m_LineVisibleCharacterCount;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	private int m_LineVisibleSpaceCount;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
	private int m_FirstOverflowCharacterIndex;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	private int m_PageNumber;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x354")]
	private float m_MarginLeft;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	private float m_MarginRight;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
	private float m_Width;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	private Extents m_MeshExtents;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	private float m_MaxCapHeight;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
	private float m_MaxAscender;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	private float m_MaxDescender;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
	private bool m_IsNewPage;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37D")]
	private bool m_IsNonBreakingSpace;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	private WordWrapState m_SavedWordWrapState;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x718")]
	private WordWrapState m_SavedLineState;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAB0")]
	private WordWrapState m_SavedEllipsisState;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE48")]
	private WordWrapState m_SavedLastValidState;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11E0")]
	private WordWrapState m_SavedSoftLineBreakState;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1578")]
	private TextElementType m_TextElementType;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1579")]
	private bool m_isTextLayoutPhase;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x157C")]
	private int m_SpriteIndex;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1580")]
	private Color32 m_SpriteColor;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1588")]
	private TextElement m_CachedTextElement;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1590")]
	private Color32 m_HighlightColor;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1594")]
	private float m_CharWidthAdjDelta;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1598")]
	private float m_MaxFontSize;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x159C")]
	private float m_MinFontSize;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15A0")]
	private int m_AutoSizeIterationCount;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15A4")]
	private int m_AutoSizeMaxIterationCount;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15A8")]
	private bool m_IsAutoSizePointSizeSet;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15AC")]
	private float m_StartOfLineAscender;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15B0")]
	private float m_LineSpacingDelta;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15B8")]
	private MaterialReference[] m_MaterialReferences;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C0")]
	private int m_SpriteCount;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C8")]
	private TextProcessingStack<int> m_StyleStack;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15E8")]
	private TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19A0")]
	private int m_SpriteAnimationId;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19A4")]
	private int m_ItalicAngle;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19A8")]
	private Vector3 m_FXScale;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19B4")]
	private Quaternion m_FXRotation;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C4")]
	private int m_LastBaseGlyphIndex;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C8")]
	private float m_PageAscender;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19D0")]
	private RichTextTagAttribute[] m_XmlAttribute;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19D8")]
	private float[] m_AttributeParameterValues;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19E0")]
	private Dictionary<int, int> m_MaterialReferenceIndexLookup;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19E8")]
	private bool m_IsCalculatingPreferredValues;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19F0")]
	private SpriteAsset m_DefaultSpriteAsset;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19F8")]
	private bool m_TintSprite;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A00")]
	protected SpecialCharacter m_Ellipsis;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A20")]
	protected SpecialCharacter m_Underline;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A40")]
	private TextElementInfo[] m_InternalTextElementInfo;

	[Token(Token = "0x17000031")]
	public static bool isTextTruncated
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2EA4FA8", Offset = "0x2EA0FA8", VA = "0x2EA4FA8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x2EA43DC", Offset = "0x2EA03DC", VA = "0x2EA43DC")]
	private static TextGenerator GetTextGenerator()
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x2EA4AE4", Offset = "0x2EA0AE4", VA = "0x2EA4AE4")]
	public static void GenerateText(TextGenerationSettings settings, TextInfo textInfo)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x2EA4D50", Offset = "0x2EA0D50", VA = "0x2EA4D50")]
	public static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x2EA4C58", Offset = "0x2EA0C58", VA = "0x2EA4C58")]
	private void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x2E9CF5C", Offset = "0x2E98F5C", VA = "0x2E9CF5C")]
	private void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x2EA71D8", Offset = "0x2EA31D8", VA = "0x2EA71D8")]
	private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x2EA7470", Offset = "0x2EA3470", VA = "0x2EA7470")]
	protected int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo)
	{
		return default(int);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2EA770C", Offset = "0x2EA370C", VA = "0x2EA770C")]
	protected bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x2EABD1C", Offset = "0x2EA7D1C", VA = "0x2EABD1C")]
	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2EAC7F4", Offset = "0x2EA87F4", VA = "0x2EAC7F4")]
	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2EACFA4", Offset = "0x2EA8FA4", VA = "0x2EACFA4")]
	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2EADB6C", Offset = "0x2EA9B6C", VA = "0x2EADB6C")]
	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2EAE06C", Offset = "0x2EAA06C", VA = "0x2EAE06C")]
	private static void ClearMesh(bool updateMesh, TextInfo textInfo)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x2EA5D84", Offset = "0x2EA1D84", VA = "0x2EA5D84")]
	internal int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		return default(int);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2EAE228", Offset = "0x2EAA228", VA = "0x2EAE228")]
	internal TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2EA5018", Offset = "0x2EA1018", VA = "0x2EA5018")]
	private void ComputeMarginSize(Rect rect, Vector4 margins)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x2EA4FF0", Offset = "0x2EA0FF0", VA = "0x2EA4FF0")]
	protected void GetSpecialCharacters(TextGenerationSettings generationSettings)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x2EAE08C", Offset = "0x2EAA08C", VA = "0x2EAE08C")]
	protected void GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x2EADAE8", Offset = "0x2EA9AE8", VA = "0x2EADAE8")]
	protected void GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x2EA4E80", Offset = "0x2EA0E80", VA = "0x2EA4E80")]
	private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x2EAE5A4", Offset = "0x2EAA5A4", VA = "0x2EAE5A4", Slot = "4")]
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingMode textWrapMode, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x2EA5080", Offset = "0x2EA1080", VA = "0x2EA5080")]
	private void PopulateTextBackingArray(string sourceText)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x2EB0F74", Offset = "0x2EACF74", VA = "0x2EB0F74")]
	private void PopulateTextBackingArray(string sourceText, int start, int length)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x2EA5098", Offset = "0x2EA1098", VA = "0x2EA5098")]
	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x2EB1074", Offset = "0x2EAD074", VA = "0x2EB1074")]
	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x2EAE508", Offset = "0x2EAA508", VA = "0x2EAE508")]
	protected void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x2EABCB8", Offset = "0x2EA7CB8", VA = "0x2EABCB8")]
	private void ClearMarkupTagAttributes()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x2EA4450", Offset = "0x2EA0450", VA = "0x2EA4450")]
	public TextGenerator()
	{
	}
}
[Token(Token = "0x2000024")]
internal enum TextAlignment
{
	[Token(Token = "0x40001B8")]
	TopLeft = 257,
	[Token(Token = "0x40001B9")]
	TopCenter = 258,
	[Token(Token = "0x40001BA")]
	TopRight = 260,
	[Token(Token = "0x40001BB")]
	TopJustified = 264,
	[Token(Token = "0x40001BC")]
	TopFlush = 272,
	[Token(Token = "0x40001BD")]
	TopGeoAligned = 288,
	[Token(Token = "0x40001BE")]
	MiddleLeft = 513,
	[Token(Token = "0x40001BF")]
	MiddleCenter = 514,
	[Token(Token = "0x40001C0")]
	MiddleRight = 516,
	[Token(Token = "0x40001C1")]
	MiddleJustified = 520,
	[Token(Token = "0x40001C2")]
	MiddleFlush = 528,
	[Token(Token = "0x40001C3")]
	MiddleGeoAligned = 544,
	[Token(Token = "0x40001C4")]
	BottomLeft = 1025,
	[Token(Token = "0x40001C5")]
	BottomCenter = 1026,
	[Token(Token = "0x40001C6")]
	BottomRight = 1028,
	[Token(Token = "0x40001C7")]
	BottomJustified = 1032,
	[Token(Token = "0x40001C8")]
	BottomFlush = 1040,
	[Token(Token = "0x40001C9")]
	BottomGeoAligned = 1056,
	[Token(Token = "0x40001CA")]
	BaselineLeft = 2049,
	[Token(Token = "0x40001CB")]
	BaselineCenter = 2050,
	[Token(Token = "0x40001CC")]
	BaselineRight = 2052,
	[Token(Token = "0x40001CD")]
	BaselineJustified = 2056,
	[Token(Token = "0x40001CE")]
	BaselineFlush = 2064,
	[Token(Token = "0x40001CF")]
	BaselineGeoAligned = 2080,
	[Token(Token = "0x40001D0")]
	MidlineLeft = 4097,
	[Token(Token = "0x40001D1")]
	MidlineCenter = 4098,
	[Token(Token = "0x40001D2")]
	MidlineRight = 4100,
	[Token(Token = "0x40001D3")]
	MidlineJustified = 4104,
	[Token(Token = "0x40001D4")]
	MidlineFlush = 4112,
	[Token(Token = "0x40001D5")]
	MidlineGeoAligned = 4128,
	[Token(Token = "0x40001D6")]
	CaplineLeft = 8193,
	[Token(Token = "0x40001D7")]
	CaplineCenter = 8194,
	[Token(Token = "0x40001D8")]
	CaplineRight = 8196,
	[Token(Token = "0x40001D9")]
	CaplineJustified = 8200,
	[Token(Token = "0x40001DA")]
	CaplineFlush = 8208,
	[Token(Token = "0x40001DB")]
	CaplineGeoAligned = 8224
}
[Token(Token = "0x2000025")]
[Flags]
public enum FontStyles
{
	[Token(Token = "0x40001DD")]
	Normal = 0,
	[Token(Token = "0x40001DE")]
	Bold = 1,
	[Token(Token = "0x40001DF")]
	Italic = 2,
	[Token(Token = "0x40001E0")]
	Underline = 4,
	[Token(Token = "0x40001E1")]
	LowerCase = 8,
	[Token(Token = "0x40001E2")]
	UpperCase = 0x10,
	[Token(Token = "0x40001E3")]
	SmallCaps = 0x20,
	[Token(Token = "0x40001E4")]
	Strikethrough = 0x40,
	[Token(Token = "0x40001E5")]
	Superscript = 0x80,
	[Token(Token = "0x40001E6")]
	Subscript = 0x100,
	[Token(Token = "0x40001E7")]
	Highlight = 0x200
}
[Token(Token = "0x2000026")]
internal enum TextOverflowMode
{
	[Token(Token = "0x40001E9")]
	Overflow,
	[Token(Token = "0x40001EA")]
	Ellipsis,
	[Token(Token = "0x40001EB")]
	Masking,
	[Token(Token = "0x40001EC")]
	Truncate,
	[Token(Token = "0x40001ED")]
	ScrollRect,
	[Token(Token = "0x40001EE")]
	Page,
	[Token(Token = "0x40001EF")]
	Linked
}
[Token(Token = "0x2000027")]
internal enum TextureMapping
{
	[Token(Token = "0x40001F1")]
	Character,
	[Token(Token = "0x40001F2")]
	Line,
	[Token(Token = "0x40001F3")]
	Paragraph,
	[Token(Token = "0x40001F4")]
	MatchAspect
}
[Token(Token = "0x2000028")]
internal enum TextWrappingMode
{
	[Token(Token = "0x40001F6")]
	NoWrap,
	[Token(Token = "0x40001F7")]
	Normal,
	[Token(Token = "0x40001F8")]
	PreserveWhitespace,
	[Token(Token = "0x40001F9")]
	PreserveWhitespaceNoWrap
}
[Token(Token = "0x2000029")]
internal enum TextInputSource
{
	[Token(Token = "0x40001FB")]
	TextInputBox,
	[Token(Token = "0x40001FC")]
	SetText,
	[Token(Token = "0x40001FD")]
	SetTextArray,
	[Token(Token = "0x40001FE")]
	TextString
}
[Token(Token = "0x200002A")]
internal struct RichTextTagAttribute
{
	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int nameHashCode;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int valueHashCode;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public TagValueType valueType;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int valueStartIndex;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int valueLength;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public TagUnitType unitType;
}
[Token(Token = "0x200002B")]
[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
internal struct TextProcessingElement
{
	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public TextProcessingElementType elementType;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint unicode;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int stringIndex;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int length;
}
[Token(Token = "0x200002C")]
internal struct TextBackingContainer
{
	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private uint[] m_Array;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private int m_Count;

	[Token(Token = "0x17000032")]
	public int Capacity
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2EB1778", Offset = "0x2EAD778", VA = "0x2EB1778")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000033")]
	public int Count
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2EB1790", Offset = "0x2EAD790", VA = "0x2EB1790")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2EB1798", Offset = "0x2EAD798", VA = "0x2EB1798")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public uint this[int index]
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2EB17A0", Offset = "0x2EAD7A0", VA = "0x2EB17A0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2EB17D0", Offset = "0x2EAD7D0", VA = "0x2EB17D0")]
		set
		{
		}
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x2EB1894", Offset = "0x2EAD894", VA = "0x2EB1894")]
	public TextBackingContainer(int size)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2EB1830", Offset = "0x2EAD830", VA = "0x2EB1830")]
	public void Resize(int size)
	{
	}
}
[Token(Token = "0x200002D")]
internal struct CharacterSubstitution
{
	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int index;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint unicode;

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x2EB18F4", Offset = "0x2EAD8F4", VA = "0x2EB18F4")]
	public CharacterSubstitution(int index, uint unicode)
	{
	}
}
[Token(Token = "0x200002E")]
internal struct Offset
{
	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float m_Left;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private float m_Right;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private float m_Top;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private float m_Bottom;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Offset k_ZeroOffset;

	[Token(Token = "0x17000035")]
	public float left
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2EB18FC", Offset = "0x2EAD8FC", VA = "0x2EB18FC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000036")]
	public float right
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2EB1904", Offset = "0x2EAD904", VA = "0x2EB1904")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000037")]
	public float top
	{
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2EB190C", Offset = "0x2EAD90C", VA = "0x2EB190C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000038")]
	public float bottom
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2EB1914", Offset = "0x2EAD914", VA = "0x2EB1914")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000039")]
	public static Offset zero
	{
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2EB191C", Offset = "0x2EAD91C", VA = "0x2EB191C")]
		get
		{
			return default(Offset);
		}
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x2EB1978", Offset = "0x2EAD978", VA = "0x2EB1978")]
	public Offset(float left, float right, float top, float bottom)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x2EB1984", Offset = "0x2EAD984", VA = "0x2EB1984")]
	public static bool operator ==(Offset lhs, Offset rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x2EB19AC", Offset = "0x2EAD9AC", VA = "0x2EB19AC")]
	public static Offset operator *(Offset a, float b)
	{
		return default(Offset);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x2EB19C0", Offset = "0x2EAD9C0", VA = "0x2EB19C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x2EB1A24", Offset = "0x2EADA24", VA = "0x2EB1A24", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}
}
[Token(Token = "0x200002F")]
internal struct HighlightState
{
	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Color32 color;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Offset padding;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x2EB1AE4", Offset = "0x2EADAE4", VA = "0x2EB1AE4")]
	public HighlightState(Color32 color, Offset padding)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x2EB1AF4", Offset = "0x2EADAF4", VA = "0x2EB1AF4")]
	public static bool operator ==(HighlightState lhs, HighlightState rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x2EB1BE4", Offset = "0x2EADBE4", VA = "0x2EB1BE4")]
	public static bool operator !=(HighlightState lhs, HighlightState rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x2EB1C2C", Offset = "0x2EADC2C", VA = "0x2EB1C2C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x2EB1C98", Offset = "0x2EADC98", VA = "0x2EB1C98", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000030")]
internal struct WordWrapState
{
	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int previousWordBreak;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int totalCharacterCount;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int visibleCharacterCount;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int visibleSpaceCount;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int visibleSpriteCount;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int visibleLinkCount;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int firstCharacterIndex;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int firstVisibleCharacterIndex;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int lastCharacterIndex;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int lastVisibleCharIndex;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int lineNumber;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float maxCapHeight;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maxAscender;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float maxDescender;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float maxLineAscender;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float maxLineDescender;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float startOfLineAscender;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float xAdvance;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float preferredWidth;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float preferredHeight;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float previousLineScale;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float pageAscender;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int wordCount;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public FontStyles fontStyle;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float fontScale;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float fontScaleMultiplier;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int italicAngle;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float currentFontSize;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float baselineOffset;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lineOffset;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextInfo textInfo;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public LineInfo lineInfo;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Color32 vertexColor;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public Color32 underlineColor;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Color32 strikethroughColor;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public Color32 highlightColor;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public HighlightState highlightState;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public FontStyleStack basicStyleStack;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public TextProcessingStack<int> italicAngleStack;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public TextProcessingStack<Color32> colorStack;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public TextProcessingStack<Color32> underlineColorStack;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public TextProcessingStack<Color32> strikethroughColorStack;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public TextProcessingStack<Color32> highlightColorStack;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public TextProcessingStack<HighlightState> highlightStateStack;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public TextProcessingStack<TextColorGradient> colorGradientStack;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public TextProcessingStack<float> sizeStack;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public TextProcessingStack<float> indentStack;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public TextProcessingStack<TextFontWeight> fontWeightStack;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public TextProcessingStack<int> styleStack;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public TextProcessingStack<float> baselineStack;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public TextProcessingStack<int> actionStack;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public TextProcessingStack<MaterialReference> materialReferenceStack;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public TextProcessingStack<TextAlignment> lineJustificationStack;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	public int lastBaseGlyphIndex;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
	public int spriteAnimationId;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	public FontAsset currentFontAsset;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	public SpriteAsset currentSpriteAsset;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public Material currentMaterial;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public int currentMaterialIndex;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x364")]
	public Extents meshExtents;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
	public bool tagNoParsing;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x375")]
	public bool isNonBreakingSpace;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x376")]
	public bool isDrivenLineSpacing;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public Vector3 fxScale;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
	public Quaternion fxRotation;
}
[Token(Token = "0x2000031")]
internal static class TextGeneratorUtilities
{
	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Vector2 largePositiveVector2;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly Vector2 largeNegativeVector2;

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x2EB1D18", Offset = "0x2EADD18", VA = "0x2EB1D18")]
	public static bool Approximately(float a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x2EB1D40", Offset = "0x2EADD40", VA = "0x2EB1D40")]
	public static Color32 HexCharsToColor(char[] hexChars, int tagCount)
	{
		return default(Color32);
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x2EB23A8", Offset = "0x2EAE3A8", VA = "0x2EB23A8")]
	public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
	{
		return default(Color32);
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x2EB237C", Offset = "0x2EAE37C", VA = "0x2EB237C")]
	public static uint HexToInt(char hex)
	{
		return default(uint);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x2EB2628", Offset = "0x2EAE628", VA = "0x2EB2628")]
	public static float ConvertToFloat(char[] chars, int startIndex, int length)
	{
		return default(float);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x2EB26A4", Offset = "0x2EAE6A4", VA = "0x2EB26A4")]
	public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex)
	{
		return default(float);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x2EB27FC", Offset = "0x2EAE7FC", VA = "0x2EB27FC")]
	public static Vector2 PackUV(float x, float y, float scale)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000137")]
	public static void ResizeInternalArray<T>(ref T[] array)
	{
	}

	[Token(Token = "0x6000138")]
	public static void ResizeInternalArray<T>(ref T[] array, int size)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x2EB2854", Offset = "0x2EAE854", VA = "0x2EB2854")]
	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x2EB2DF0", Offset = "0x2EAEDF0", VA = "0x2EB2DF0")]
	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x2EB2EF0", Offset = "0x2EAEEF0", VA = "0x2EB2EF0")]
	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		return default(bool);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x2EB3218", Offset = "0x2EAF218", VA = "0x2EB3218")]
	private static bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		return default(bool);
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x2EB3440", Offset = "0x2EAF440", VA = "0x2EB3440")]
	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x2EB356C", Offset = "0x2EAF56C", VA = "0x2EB356C")]
	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x2EB3644", Offset = "0x2EAF644", VA = "0x2EB3644")]
	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x2EB295C", Offset = "0x2EAE95C", VA = "0x2EB295C")]
	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x2EB3134", Offset = "0x2EAF134", VA = "0x2EB3134")]
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x2EB3370", Offset = "0x2EAF370", VA = "0x2EB3370")]
	public static int GetStyleHashCode(ref uint[] text, int index, out int closeIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x2EB3048", Offset = "0x2EAF048", VA = "0x2EB3048")]
	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x2EB3728", Offset = "0x2EAF728", VA = "0x2EB3728")]
	public static uint GetUTF16(uint[] text, int i)
	{
		return default(uint);
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x2EB3B7C", Offset = "0x2EAFB7C", VA = "0x2EB3B7C")]
	public static uint GetUTF16(TextBackingContainer text, int i)
	{
		return default(uint);
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x2EB380C", Offset = "0x2EAF80C", VA = "0x2EB380C")]
	public static uint GetUTF32(uint[] text, int i)
	{
		return default(uint);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x2EB3C60", Offset = "0x2EAFC60", VA = "0x2EB3C60")]
	public static uint GetUTF32(TextBackingContainer text, int i)
	{
		return default(uint);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x2EB3DD4", Offset = "0x2EAFDD4", VA = "0x2EB3DD4")]
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x2EB4468", Offset = "0x2EB0468", VA = "0x2EB4468")]
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x2EB4974", Offset = "0x2EB0974", VA = "0x2EB4974")]
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x2EB4A50", Offset = "0x2EB0A50", VA = "0x2EB4A50")]
	public static void ResizeLineExtents(int size, TextInfo textInfo)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x2EB4BEC", Offset = "0x2EB0BEC", VA = "0x2EB4BEC")]
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle)
	{
		return default(FontStyles);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x2EB4BFC", Offset = "0x2EB0BFC", VA = "0x2EB4BFC")]
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor)
	{
		return default(TextAlignment);
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x2EB4C20", Offset = "0x2EB0C20", VA = "0x2EB4C20")]
	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
	{
		return default(uint);
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x2EB4C34", Offset = "0x2EB0C34", VA = "0x2EB4C34")]
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x2EB3980", Offset = "0x2EAF980", VA = "0x2EB3980")]
	public static int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x2EB3B08", Offset = "0x2EAFB08", VA = "0x2EB3B08")]
	public static char ToUpperASCIIFast(char c)
	{
		return default(char);
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x2EB4D34", Offset = "0x2EB0D34", VA = "0x2EB4D34")]
	public static uint ToUpperASCIIFast(uint c)
	{
		return default(uint);
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x2EB4DA8", Offset = "0x2EB0DA8", VA = "0x2EB4DA8")]
	public static char ToUpperFast(char c)
	{
		return default(char);
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x2EB4E1C", Offset = "0x2EB0E1C", VA = "0x2EB4E1C")]
	public static int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters)
	{
		return default(int);
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x2EB4F08", Offset = "0x2EB0F08", VA = "0x2EB4F08")]
	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x2EB4F3C", Offset = "0x2EB0F3C", VA = "0x2EB4F3C")]
	public static bool IsBaseGlyph(uint c)
	{
		return default(bool);
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x2EB50BC", Offset = "0x2EB10BC", VA = "0x2EB50BC")]
	public static Color MinAlpha(this Color c1, Color c2)
	{
		return default(Color);
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x2EB43D4", Offset = "0x2EB03D4", VA = "0x2EB43D4")]
	internal static Color32 GammaToLinear(Color32 c)
	{
		return default(Color32);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x2EB50C8", Offset = "0x2EB10C8", VA = "0x2EB50C8")]
	private static byte GammaToLinear(byte value)
	{
		return default(byte);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x2EB5178", Offset = "0x2EB1178", VA = "0x2EB5178")]
	public static bool IsValidUTF16(TextBackingContainer text, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x2EB51F0", Offset = "0x2EB11F0", VA = "0x2EB51F0")]
	public static bool IsValidUTF32(TextBackingContainer text, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x2EB5268", Offset = "0x2EB1268", VA = "0x2EB5268")]
	internal static bool IsHangul(uint c)
	{
		return default(bool);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x2EB52FC", Offset = "0x2EB12FC", VA = "0x2EB52FC")]
	internal static bool IsCJK(uint c)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000032")]
internal class TextHandle
{
	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Vector2 m_PreferredSize;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextInfo m_TextInfo;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static TextInfo m_LayoutTextInfo;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_PreviousGenerationSettingsHash;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected TextGenerationSettings textGenerationSettings;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static TextGenerationSettings s_LayoutSettings;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isDirty;

	[Token(Token = "0x1700003A")]
	internal TextInfo textInfo
	{
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2EB5504", Offset = "0x2EB1504", VA = "0x2EB5504")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003B")]
	internal static TextInfo layoutTextInfo
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2EB56B0", Offset = "0x2EB16B0", VA = "0x2EB56B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2EB54A0", Offset = "0x2EB14A0", VA = "0x2EB54A0")]
	public TextHandle()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x2EB5768", Offset = "0x2EB1768", VA = "0x2EB5768")]
	public bool IsDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x2EB57B8", Offset = "0x2EB17B8", VA = "0x2EB57B8")]
	public Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = true)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x2EB5908", Offset = "0x2EB1908", VA = "0x2EB5908")]
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = false, bool inverseYAxis = true)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x2EB5A94", Offset = "0x2EB1A94", VA = "0x2EB5A94")]
	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = true)
	{
		return default(int);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x2EB5F14", Offset = "0x2EB1F14", VA = "0x2EB5F14")]
	public int LineDownCharacterPosition(int originalPos)
	{
		return default(int);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x2EB60E8", Offset = "0x2EB20E8", VA = "0x2EB60E8")]
	public int LineUpCharacterPosition(int originalPos)
	{
		return default(int);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x2EB5B9C", Offset = "0x2EB1B9C", VA = "0x2EB5B9C")]
	public int FindNearestLine(Vector2 position)
	{
		return default(int);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x2EB5C6C", Offset = "0x2EB1C6C", VA = "0x2EB5C6C")]
	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly)
	{
		return default(int);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x2EB642C", Offset = "0x2EB242C", VA = "0x2EB642C")]
	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = true)
	{
		return default(int);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x2EB62A4", Offset = "0x2EB22A4", VA = "0x2EB62A4")]
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		return default(bool);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x2EB6364", Offset = "0x2EB2364", VA = "0x2EB6364")]
	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
	{
		return default(float);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x2EB66E8", Offset = "0x2EB26E8", VA = "0x2EB66E8")]
	public int GetLineNumber(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x2EB6778", Offset = "0x2EB2778", VA = "0x2EB6778")]
	public float GetLineHeight(int lineNumber)
	{
		return default(float);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x2EB6808", Offset = "0x2EB2808", VA = "0x2EB6808")]
	public float GetLineHeightFromCharacterIndex(int index)
	{
		return default(float);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x2EB689C", Offset = "0x2EB289C", VA = "0x2EB689C")]
	public float GetCharacterHeightFromIndex(int index)
	{
		return default(float);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x2EB6934", Offset = "0x2EB2934", VA = "0x2EB6934")]
	public bool IsElided()
	{
		return default(bool);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x2EB6974", Offset = "0x2EB2974", VA = "0x2EB6974")]
	public string Substring(int startIndex, int length)
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x2EB6AA8", Offset = "0x2EB2AA8", VA = "0x2EB6AA8")]
	public int IndexOf(char value, int startIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x2EB6B94", Offset = "0x2EB2B94", VA = "0x2EB6B94")]
	public int LastIndexOf(char value, int startIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x2EB6C5C", Offset = "0x2EB2C5C", VA = "0x2EB6C5C")]
	protected float ComputeTextWidth(TextGenerationSettings tgs)
	{
		return default(float);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x2EB6CE8", Offset = "0x2EB2CE8", VA = "0x2EB6CE8")]
	protected float ComputeTextHeight(TextGenerationSettings tgs)
	{
		return default(float);
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x2EB6C74", Offset = "0x2EB2C74", VA = "0x2EB6C74")]
	protected void UpdatePreferredValues(TextGenerationSettings tgs)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x2EB6D00", Offset = "0x2EB2D00", VA = "0x2EB6D00")]
	protected TextInfo Update(TextGenerationSettings tgs)
	{
		return null;
	}
}
[Token(Token = "0x2000033")]
internal struct PageInfo
{
	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int firstCharacterIndex;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int lastCharacterIndex;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float ascender;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float baseLine;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float descender;
}
[Token(Token = "0x2000034")]
internal struct WordInfo
{
	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int firstCharacterIndex;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int lastCharacterIndex;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int characterCount;
}
[Token(Token = "0x2000035")]
internal class TextInfo
{
	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2 s_InfinityVectorPositive;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector2 s_InfinityVectorNegative;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int characterCount;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int spriteCount;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int spaceCount;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int wordCount;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int linkCount;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int lineCount;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int pageCount;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int materialCount;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextElementInfo[] textElementInfo;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public WordInfo[] wordInfo;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LinkInfo[] linkInfo;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LineInfo[] lineInfo;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public PageInfo[] pageInfo;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public MeshInfo[] meshInfo;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool isDirty;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool hasMultipleColors;

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x2EB5564", Offset = "0x2EB1564", VA = "0x2EB5564")]
	public TextInfo()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x2EB6DDC", Offset = "0x2EB2DDC", VA = "0x2EB6DDC")]
	internal void Clear()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x2EB6E34", Offset = "0x2EB2E34", VA = "0x2EB6E34")]
	internal void ClearMeshInfo(bool updateMesh)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x2EB6EEC", Offset = "0x2EB2EEC", VA = "0x2EB6EEC")]
	internal void ClearLineInfo()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x2EB705C", Offset = "0x2EB305C", VA = "0x2EB705C")]
	internal void ClearPageInfo()
	{
	}

	[Token(Token = "0x600017F")]
	internal static void Resize<T>(ref T[] array, int size)
	{
	}

	[Token(Token = "0x6000180")]
	internal static void Resize<T>(ref T[] array, int size, bool isBlockAllocated)
	{
	}
}
[Token(Token = "0x2000036")]
internal enum MarkupTag
{
	[Token(Token = "0x4000279")]
	BOLD = 66,
	[Token(Token = "0x400027A")]
	SLASH_BOLD = 1613,
	[Token(Token = "0x400027B")]
	ITALIC = 73,
	[Token(Token = "0x400027C")]
	SLASH_ITALIC = 1606,
	[Token(Token = "0x400027D")]
	UNDERLINE = 85,
	[Token(Token = "0x400027E")]
	SLASH_UNDERLINE = 1626,
	[Token(Token = "0x400027F")]
	STRIKETHROUGH = 83,
	[Token(Token = "0x4000280")]
	SLASH_STRIKETHROUGH = 1628,
	[Token(Token = "0x4000281")]
	MARK = 2699125,
	[Token(Token = "0x4000282")]
	SLASH_MARK = 57644506,
	[Token(Token = "0x4000283")]
	SUBSCRIPT = 92132,
	[Token(Token = "0x4000284")]
	SLASH_SUBSCRIPT = 1770219,
	[Token(Token = "0x4000285")]
	SUPERSCRIPT = 92150,
	[Token(Token = "0x4000286")]
	SLASH_SUPERSCRIPT = 1770233,
	[Token(Token = "0x4000287")]
	COLOR = 81999901,
	[Token(Token = "0x4000288")]
	SLASH_COLOR = 1909026194,
	[Token(Token = "0x4000289")]
	ALPHA = 75165780,
	[Token(Token = "0x400028A")]
	A = 65,
	[Token(Token = "0x400028B")]
	SLASH_A = 1614,
	[Token(Token = "0x400028C")]
	SIZE = 3061285,
	[Token(Token = "0x400028D")]
	SLASH_SIZE = 58429962,
	[Token(Token = "0x400028E")]
	SPRITE = -991527447,
	[Token(Token = "0x400028F")]
	NO_BREAK = 2856657,
	[Token(Token = "0x4000290")]
	SLASH_NO_BREAK = 57477502,
	[Token(Token = "0x4000291")]
	STYLE = 100252951,
	[Token(Token = "0x4000292")]
	SLASH_STYLE = 1927738392,
	[Token(Token = "0x4000293")]
	FONT = 2586451,
	[Token(Token = "0x4000294")]
	SLASH_FONT = 57747708,
	[Token(Token = "0x4000295")]
	SLASH_MATERIAL = -1100708252,
	[Token(Token = "0x4000296")]
	LINK = 2656128,
	[Token(Token = "0x4000297")]
	SLASH_LINK = 57686191,
	[Token(Token = "0x4000298")]
	FONT_WEIGHT = -1889896162,
	[Token(Token = "0x4000299")]
	SLASH_FONT_WEIGHT = -757976431,
	[Token(Token = "0x400029A")]
	NO_PARSE = -408011596,
	[Token(Token = "0x400029B")]
	SLASH_NO_PARSE = -294095813,
	[Token(Token = "0x400029C")]
	POSITION = 85420,
	[Token(Token = "0x400029D")]
	SLASH_POSITION = 1777699,
	[Token(Token = "0x400029E")]
	VERTICAL_OFFSET = 1952379995,
	[Token(Token = "0x400029F")]
	SLASH_VERTICAL_OFFSET = -11107948,
	[Token(Token = "0x40002A0")]
	SPACE = 100083556,
	[Token(Token = "0x40002A1")]
	SLASH_SPACE = 1927873067,
	[Token(Token = "0x40002A2")]
	PAGE = 2808691,
	[Token(Token = "0x40002A3")]
	SLASH_PAGE = 58683868,
	[Token(Token = "0x40002A4")]
	ALIGN = 75138797,
	[Token(Token = "0x40002A5")]
	SLASH_ALIGN = 1916026786,
	[Token(Token = "0x40002A6")]
	WIDTH = 105793766,
	[Token(Token = "0x40002A7")]
	SLASH_WIDTH = 1923459625,
	[Token(Token = "0x40002A8")]
	GRADIENT = -1999759898,
	[Token(Token = "0x40002A9")]
	SLASH_GRADIENT = -1854491959,
	[Token(Token = "0x40002AA")]
	CHARACTER_SPACE = -1584382009,
	[Token(Token = "0x40002AB")]
	SLASH_CHARACTER_SPACE = -1394426712,
	[Token(Token = "0x40002AC")]
	MONOSPACE = -1340221943,
	[Token(Token = "0x40002AD")]
	SLASH_MONOSPACE = -1638865562,
	[Token(Token = "0x40002AE")]
	CLASS = 82115566,
	[Token(Token = "0x40002AF")]
	INDENT = -1514123076,
	[Token(Token = "0x40002B0")]
	SLASH_INDENT = -1496889389,
	[Token(Token = "0x40002B1")]
	LINE_INDENT = -844305121,
	[Token(Token = "0x40002B2")]
	SLASH_LINE_INDENT = 93886352,
	[Token(Token = "0x40002B3")]
	MARGIN = -1355614050,
	[Token(Token = "0x40002B4")]
	SLASH_MARGIN = -1649644303,
	[Token(Token = "0x40002B5")]
	MARGIN_LEFT = -272933656,
	[Token(Token = "0x40002B6")]
	MARGIN_RIGHT = -447416589,
	[Token(Token = "0x40002B7")]
	LINE_HEIGHT = -799081892,
	[Token(Token = "0x40002B8")]
	SLASH_LINE_HEIGHT = 200452819,
	[Token(Token = "0x40002B9")]
	ACTION = -1827519330,
	[Token(Token = "0x40002BA")]
	SLASH_ACTION = -1187217679,
	[Token(Token = "0x40002BB")]
	SCALE = 100553336,
	[Token(Token = "0x40002BC")]
	SLASH_SCALE = 1928413879,
	[Token(Token = "0x40002BD")]
	ROTATE = -1000007783,
	[Token(Token = "0x40002BE")]
	SLASH_ROTATE = -764695562,
	[Token(Token = "0x40002BF")]
	TABLE = 226476955,
	[Token(Token = "0x40002C0")]
	SLASH_TABLE = -979118220,
	[Token(Token = "0x40002C1")]
	TH = 5862489,
	[Token(Token = "0x40002C2")]
	SLASH_TH = 193346070,
	[Token(Token = "0x40002C3")]
	TR = 5862467,
	[Token(Token = "0x40002C4")]
	SLASH_TR = 193346060,
	[Token(Token = "0x40002C5")]
	TD = 5862485,
	[Token(Token = "0x40002C6")]
	SLASH_TD = 193346074,
	[Token(Token = "0x40002C7")]
	LOWERCASE = -1506899689,
	[Token(Token = "0x40002C8")]
	SLASH_LOWERCASE = -1451284584,
	[Token(Token = "0x40002C9")]
	ALLCAPS = 218273952,
	[Token(Token = "0x40002CA")]
	SLASH_ALLCAPS = -797437649,
	[Token(Token = "0x40002CB")]
	UPPERCASE = -305409418,
	[Token(Token = "0x40002CC")]
	SLASH_UPPERCASE = -582368199,
	[Token(Token = "0x40002CD")]
	SMALLCAPS = -766062114,
	[Token(Token = "0x40002CE")]
	SLASH_SMALLCAPS = 199921873,
	[Token(Token = "0x40002CF")]
	LIGA = 2655971,
	[Token(Token = "0x40002D0")]
	SLASH_LIGA = 57686604,
	[Token(Token = "0x40002D1")]
	FRAC = 2598518,
	[Token(Token = "0x40002D2")]
	SLASH_FRAC = 57774681,
	[Token(Token = "0x40002D3")]
	NAME = 2875623,
	[Token(Token = "0x40002D4")]
	INDEX = 84268030,
	[Token(Token = "0x40002D5")]
	TINT = 2960519,
	[Token(Token = "0x40002D6")]
	ANIM = 2283339,
	[Token(Token = "0x40002D7")]
	MATERIAL = 825491659,
	[Token(Token = "0x40002D8")]
	HREF = 2535353,
	[Token(Token = "0x40002D9")]
	ANGLE = 75347905,
	[Token(Token = "0x40002DA")]
	PADDING = -2144568463,
	[Token(Token = "0x40002DB")]
	FAMILYNAME = 704251153,
	[Token(Token = "0x40002DC")]
	STYLENAME = -1207081936,
	[Token(Token = "0x40002DD")]
	RED = 91635,
	[Token(Token = "0x40002DE")]
	GREEN = 87065851,
	[Token(Token = "0x40002DF")]
	BLUE = 2457214,
	[Token(Token = "0x40002E0")]
	YELLOW = -882444668,
	[Token(Token = "0x40002E1")]
	ORANGE = -1108587920,
	[Token(Token = "0x40002E2")]
	BLACK = 81074727,
	[Token(Token = "0x40002E3")]
	WHITE = 105680263,
	[Token(Token = "0x40002E4")]
	PURPLE = -1250222130,
	[Token(Token = "0x40002E5")]
	BR = 2256,
	[Token(Token = "0x40002E6")]
	CR = 2289,
	[Token(Token = "0x40002E7")]
	ZWSP = 3288238,
	[Token(Token = "0x40002E8")]
	ZWJ = 99623,
	[Token(Token = "0x40002E9")]
	NBSP = 2869039,
	[Token(Token = "0x40002EA")]
	SHY = 92674,
	[Token(Token = "0x40002EB")]
	LEFT = 2660507,
	[Token(Token = "0x40002EC")]
	RIGHT = 99937376,
	[Token(Token = "0x40002ED")]
	CENTER = -1591113269,
	[Token(Token = "0x40002EE")]
	JUSTIFIED = 817091359,
	[Token(Token = "0x40002EF")]
	FLUSH = 85552164,
	[Token(Token = "0x40002F0")]
	NONE = 2857034,
	[Token(Token = "0x40002F1")]
	PLUS = 43,
	[Token(Token = "0x40002F2")]
	MINUS = 45,
	[Token(Token = "0x40002F3")]
	PX = 2568,
	[Token(Token = "0x40002F4")]
	PLUS_PX = 49507,
	[Token(Token = "0x40002F5")]
	MINUS_PX = 47461,
	[Token(Token = "0x40002F6")]
	EM = 2216,
	[Token(Token = "0x40002F7")]
	PLUS_EM = 49091,
	[Token(Token = "0x40002F8")]
	MINUS_EM = 46789,
	[Token(Token = "0x40002F9")]
	PCT = 85031,
	[Token(Token = "0x40002FA")]
	PLUS_PCT = 1634348,
	[Token(Token = "0x40002FB")]
	MINUS_PCT = 1567082,
	[Token(Token = "0x40002FC")]
	PERCENTAGE = 37,
	[Token(Token = "0x40002FD")]
	PLUS_PERCENTAGE = 1454,
	[Token(Token = "0x40002FE")]
	MINUS_PERCENTAGE = 1512,
	[Token(Token = "0x40002FF")]
	TRUE = 2932022,
	[Token(Token = "0x4000300")]
	FALSE = 85422813,
	[Token(Token = "0x4000301")]
	INVALID = 1585415185,
	[Token(Token = "0x4000302")]
	NOTDEF = 612146780,
	[Token(Token = "0x4000303")]
	NORMAL = -1183493901,
	[Token(Token = "0x4000304")]
	DEFAULT = -620974005,
	[Token(Token = "0x4000305")]
	REGULAR = 1291372090
}
[Token(Token = "0x2000037")]
internal enum TagValueType
{
	[Token(Token = "0x4000307")]
	None = 0,
	[Token(Token = "0x4000308")]
	NumericalValue = 1,
	[Token(Token = "0x4000309")]
	StringValue = 2,
	[Token(Token = "0x400030A")]
	ColorValue = 4
}
[Token(Token = "0x2000038")]
internal enum TagUnitType
{
	[Token(Token = "0x400030C")]
	Pixels,
	[Token(Token = "0x400030D")]
	FontUnits,
	[Token(Token = "0x400030E")]
	Percentage
}
[Token(Token = "0x2000039")]
internal enum TextProcessingElementType
{
	[Token(Token = "0x4000310")]
	Undefined,
	[Token(Token = "0x4000311")]
	TextCharacterElement,
	[Token(Token = "0x4000312")]
	TextMarkupElement
}
[Token(Token = "0x200003A")]
internal struct FontStyleStack
{
	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public byte bold;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public byte italic;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public byte underline;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
	public byte strikethrough;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public byte highlight;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
	public byte superscript;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
	public byte subscript;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
	public byte uppercase;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public byte lowercase;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	public byte smallcaps;

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x2EB7144", Offset = "0x2EB3144", VA = "0x2EB7144")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x2EB7150", Offset = "0x2EB3150", VA = "0x2EB7150")]
	public byte Add(FontStyles style)
	{
		return default(byte);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x2EB7254", Offset = "0x2EB3254", VA = "0x2EB7254")]
	public byte Remove(FontStyles style)
	{
		return default(byte);
	}
}
[Token(Token = "0x200003B")]
[DebuggerDisplay("Item count = {m_Count}")]
internal struct TextProcessingStack<T>
{
	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] itemStack;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int index;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private T m_DefaultItem;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int m_Capacity;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int m_RolloverSize;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int m_Count;

	[Token(Token = "0x1700003C")]
	public int Count
	{
		[Token(Token = "0x6000188")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003D")]
	public T current
	{
		[Token(Token = "0x6000189")]
		get
		{
			return (T)null;
		}
	}

	[Token(Token = "0x6000185")]
	public TextProcessingStack(T[] stack)
	{
	}

	[Token(Token = "0x6000186")]
	public TextProcessingStack(int capacity)
	{
	}

	[Token(Token = "0x6000187")]
	public TextProcessingStack(int capacity, int rolloverSize)
	{
	}

	[Token(Token = "0x600018A")]
	internal static void SetDefault(TextProcessingStack<T>[] stack, T item)
	{
	}

	[Token(Token = "0x600018B")]
	public void Clear()
	{
	}

	[Token(Token = "0x600018C")]
	public void SetDefault(T item)
	{
	}

	[Token(Token = "0x600018D")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x600018E")]
	public T Remove()
	{
		return (T)null;
	}

	[Token(Token = "0x600018F")]
	public void Push(T item)
	{
	}

	[Token(Token = "0x6000190")]
	public T Pop()
	{
		return (T)null;
	}

	[Token(Token = "0x6000191")]
	public T Peek()
	{
		return (T)null;
	}

	[Token(Token = "0x6000192")]
	public T CurrentItem()
	{
		return (T)null;
	}
}
[Token(Token = "0x200003C")]
internal class TextResourceManager
{
	[Token(Token = "0x200003D")]
	private struct FontAssetRef
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nameHashCode;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int familyNameHashCode;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int styleNameHashCode;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long familyNameAndStyleHashCode;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly FontAsset fontAsset;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2EB7888", Offset = "0x2EB3888", VA = "0x2EB7888")]
		public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset)
		{
		}
	}

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<int, FontAssetRef> s_FontAssetReferences;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly List<int> s_FontAssetRemovalList;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly int k_RegularStyleHashCode;

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x2EB737C", Offset = "0x2EB337C", VA = "0x2EB737C")]
	internal static void AddFontAsset(FontAsset fontAsset)
	{
	}
}
[Serializable]
[Token(Token = "0x200003E")]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
public class TextSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200003F")]
	private struct FontReferenceMap
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Font font;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public FontAsset fontAsset;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2EB8398", Offset = "0x2EB4398", VA = "0x2EB8398")]
		public FontReferenceMap(Font font, FontAsset fontAsset)
		{
		}
	}

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected string m_Version;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("m_defaultFontAsset")]
	protected FontAsset m_DefaultFontAsset;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	protected string m_DefaultFontAssetPath;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[FormerlySerializedAs("m_fallbackFontAssets")]
	protected List<FontAsset> m_FallbackFontAssets;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("m_matchMaterialPreset")]
	protected bool m_MatchMaterialPreset;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[FormerlySerializedAs("m_missingGlyphCharacter")]
	protected int m_MissingCharacterUnicode;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected bool m_ClearDynamicDataOnBuild;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	[SerializeField]
	protected SpriteAsset m_DefaultSpriteAsset;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	protected string m_DefaultSpriteAssetPath;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected List<SpriteAsset> m_FallbackSpriteAssets;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected uint m_MissingSpriteCharacterUnicode;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[FormerlySerializedAs("m_defaultStyleSheet")]
	[SerializeField]
	protected TextStyleSheet m_DefaultStyleSheet;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected string m_StyleSheetsResourcePath;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	[SerializeField]
	protected string m_DefaultColorGradientPresetsPath;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	[SerializeField]
	[FormerlySerializedAs("m_warningsDisabled")]
	protected bool m_DisplayWarnings;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	internal Dictionary<int, FontAsset> m_FontLookup;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<FontReferenceMap> m_FontReferences;

	[Token(Token = "0x1700003E")]
	public string version
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2EB7AC0", Offset = "0x2EB3AC0", VA = "0x2EB7AC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2EB7AC8", Offset = "0x2EB3AC8", VA = "0x2EB7AC8")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700003F")]
	public FontAsset defaultFontAsset
	{
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2EB7AD0", Offset = "0x2EB3AD0", VA = "0x2EB7AD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2EB7AD8", Offset = "0x2EB3AD8", VA = "0x2EB7AD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public string defaultFontAssetPath
	{
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2EB7AE0", Offset = "0x2EB3AE0", VA = "0x2EB7AE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2EB7AE8", Offset = "0x2EB3AE8", VA = "0x2EB7AE8")]
		set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public List<FontAsset> fallbackFontAssets
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2EB7AF0", Offset = "0x2EB3AF0", VA = "0x2EB7AF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2EB7AF8", Offset = "0x2EB3AF8", VA = "0x2EB7AF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public bool matchMaterialPreset
	{
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2EB7B00", Offset = "0x2EB3B00", VA = "0x2EB7B00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2EB7B08", Offset = "0x2EB3B08", VA = "0x2EB7B08")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public int missingCharacterUnicode
	{
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2EB7B10", Offset = "0x2EB3B10", VA = "0x2EB7B10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2EB7B18", Offset = "0x2EB3B18", VA = "0x2EB7B18")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public bool clearDynamicDataOnBuild
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2EB7B20", Offset = "0x2EB3B20", VA = "0x2EB7B20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2EB7B28", Offset = "0x2EB3B28", VA = "0x2EB7B28")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public SpriteAsset defaultSpriteAsset
	{
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2EB7B30", Offset = "0x2EB3B30", VA = "0x2EB7B30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2EB7B38", Offset = "0x2EB3B38", VA = "0x2EB7B38")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public string defaultSpriteAssetPath
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2EB7B40", Offset = "0x2EB3B40", VA = "0x2EB7B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2EB7B48", Offset = "0x2EB3B48", VA = "0x2EB7B48")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public List<SpriteAsset> fallbackSpriteAssets
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2EB7B50", Offset = "0x2EB3B50", VA = "0x2EB7B50")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2EB7B58", Offset = "0x2EB3B58", VA = "0x2EB7B58")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public uint missingSpriteCharacterUnicode
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2EB7B60", Offset = "0x2EB3B60", VA = "0x2EB7B60")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2EB7B68", Offset = "0x2EB3B68", VA = "0x2EB7B68")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public TextStyleSheet defaultStyleSheet
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2EB7B70", Offset = "0x2EB3B70", VA = "0x2EB7B70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2EB7B78", Offset = "0x2EB3B78", VA = "0x2EB7B78")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public string styleSheetsResourcePath
	{
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2EB7B80", Offset = "0x2EB3B80", VA = "0x2EB7B80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2EB7B88", Offset = "0x2EB3B88", VA = "0x2EB7B88")]
		set
		{
		}
	}

	[Token(Token = "0x1700004B")]
	public string defaultColorGradientPresetsPath
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2EB7B90", Offset = "0x2EB3B90", VA = "0x2EB7B90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2EB7B98", Offset = "0x2EB3B98", VA = "0x2EB7B98")]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public UnicodeLineBreakingRules lineBreakingRules
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2EB7BA0", Offset = "0x2EB3BA0", VA = "0x2EB7BA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2EB7E08", Offset = "0x2EB3E08", VA = "0x2EB7E08")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public bool useModernHangulLineBreakingRules
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2EB7E10", Offset = "0x2EB3E10", VA = "0x2EB7E10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2EB7E18", Offset = "0x2EB3E18", VA = "0x2EB7E18")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public bool displayWarnings
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2EB7E20", Offset = "0x2EB3E20", VA = "0x2EB7E20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2EB7E28", Offset = "0x2EB3E28", VA = "0x2EB7E28")]
		set
		{
		}
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x2EB7E30", Offset = "0x2EB3E30", VA = "0x2EB7E30")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x2EB7E48", Offset = "0x2EB3E48", VA = "0x2EB7E48")]
	protected void InitializeFontReferenceLookup()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x2EB807C", Offset = "0x2EB407C", VA = "0x2EB807C")]
	protected FontAsset GetCachedFontAssetInternal(Font font)
	{
		return null;
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x2EB83A0", Offset = "0x2EB43A0", VA = "0x2EB83A0")]
	public TextSettings()
	{
	}
}
[Token(Token = "0x2000040")]
[ExcludeFromDocs]
public static class TextShaderUtilities
{
	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int ID_MainTex;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int ID_FaceTex;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int ID_FaceColor;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int ID_FaceDilate;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int ID_Shininess;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static int ID_OutlineOffset1;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static int ID_OutlineOffset2;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static int ID_OutlineOffset3;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static int ID_OutlineMode;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static int ID_IsoPerimeter;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static int ID_Softness;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public static int ID_UnderlayColor;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static int ID_UnderlayOffsetX;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static int ID_UnderlayOffsetY;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static int ID_UnderlayDilate;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public static int ID_UnderlaySoftness;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static int ID_UnderlayOffset;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public static int ID_UnderlayIsoPerimeter;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static int ID_WeightNormal;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public static int ID_WeightBold;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static int ID_OutlineTex;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public static int ID_OutlineWidth;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static int ID_OutlineSoftness;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public static int ID_OutlineColor;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static int ID_Outline2Color;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public static int ID_Outline2Width;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static int ID_Padding;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public static int ID_GradientScale;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static int ID_ScaleX;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public static int ID_ScaleY;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static int ID_PerspectiveFilter;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public static int ID_Sharpness;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static int ID_TextureWidth;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public static int ID_TextureHeight;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static int ID_BevelAmount;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public static int ID_GlowColor;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static int ID_GlowOffset;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public static int ID_GlowPower;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static int ID_GlowOuter;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public static int ID_GlowInner;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static int ID_LightAngle;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public static int ID_EnvMap;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static int ID_EnvMatrix;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public static int ID_EnvMatrixRotation;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static int ID_MaskCoord;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public static int ID_ClipRect;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static int ID_MaskSoftnessX;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public static int ID_MaskSoftnessY;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public static int ID_VertexOffsetX;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public static int ID_VertexOffsetY;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public static int ID_UseClipRect;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public static int ID_StencilID;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public static int ID_StencilOp;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public static int ID_StencilComp;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public static int ID_StencilReadMask;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public static int ID_StencilWriteMask;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public static int ID_ShaderFlags;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public static int ID_ScaleRatio_A;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public static int ID_ScaleRatio_B;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public static int ID_ScaleRatio_C;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public static string Keyword_Bevel;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public static string Keyword_Glow;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public static string Keyword_Underlay;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public static string Keyword_Ratios;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public static string Keyword_MASK_SOFT;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public static string Keyword_MASK_HARD;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public static string Keyword_MASK_TEX;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public static string Keyword_Outline;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public static string ShaderTag_ZTestMode;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public static string ShaderTag_CullMode;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private static float m_clamp;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public static bool isInitialized;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private static Shader k_ShaderRef_MobileSDF;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private static Shader k_ShaderRef_MobileBitmap;

	[Token(Token = "0x1700004F")]
	internal static Shader ShaderRef_MobileSDF
	{
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2EB84A4", Offset = "0x2EB44A4", VA = "0x2EB84A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000050")]
	internal static Shader ShaderRef_MobileBitmap
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2EB868C", Offset = "0x2EB468C", VA = "0x2EB868C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x2EB8874", Offset = "0x2EB4874", VA = "0x2EB8874")]
	static TextShaderUtilities()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2EB89F0", Offset = "0x2EB49F0", VA = "0x2EB89F0")]
	internal static void GetShaderPropertyIDs()
	{
	}
}
[Serializable]
[Token(Token = "0x2000041")]
public class TextStyle
{
	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static TextStyle k_NormalStyle;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string m_Name;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int m_HashCode;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_OpeningDefinition;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_ClosingDefinition;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private uint[] m_OpeningTagArray;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private uint[] m_ClosingTagArray;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	internal uint[] m_OpeningTagUnicodeArray;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	internal uint[] m_ClosingTagUnicodeArray;

	[Token(Token = "0x17000051")]
	public int hashCode
	{
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2EB294C", Offset = "0x2EAE94C", VA = "0x2EB294C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000052")]
	public uint[] styleOpeningTagArray
	{
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2EB2954", Offset = "0x2EAE954", VA = "0x2EB2954")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	public uint[] styleClosingTagArray
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2EB2EE8", Offset = "0x2EAEEE8", VA = "0x2EB2EE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x2EB95A4", Offset = "0x2EB55A4", VA = "0x2EB95A4")]
	internal TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x2EB95F0", Offset = "0x2EB55F0", VA = "0x2EB95F0")]
	public void RefreshStyle()
	{
	}
}
[Serializable]
[Token(Token = "0x2000042")]
[ExcludeFromObjectFactory]
[ExcludeFromPreset]
public class TextStyleSheet : ScriptableObject
{
	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<TextStyle> m_StyleList;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<int, TextStyle> m_StyleLookupDictionary;

	[Token(Token = "0x17000054")]
	internal List<TextStyle> styles
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2EB97B4", Offset = "0x2EB57B4", VA = "0x2EB97B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x2EB97BC", Offset = "0x2EB57BC", VA = "0x2EB97BC")]
	private void Reset()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x2EB3A80", Offset = "0x2EAFA80", VA = "0x2EB3A80")]
	public TextStyle GetStyle(int hashCode)
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x2EB9A98", Offset = "0x2EB5A98", VA = "0x2EB9A98")]
	public TextStyle GetStyle(string name)
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x2EB9B2C", Offset = "0x2EB5B2C", VA = "0x2EB9B2C")]
	public void RefreshStyles()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x2EB97C0", Offset = "0x2EB57C0", VA = "0x2EB97C0")]
	private void LoadStyleDictionaryInternal()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x2EB9B30", Offset = "0x2EB5B30", VA = "0x2EB9B30")]
	public TextStyleSheet()
	{
	}
}
[Token(Token = "0x2000043")]
internal static class TextUtilities
{
	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x2EB9BB0", Offset = "0x2EB5BB0", VA = "0x2EB9BB0")]
	internal static char ToUpperFast(char c)
	{
		return default(char);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x2EB7A50", Offset = "0x2EB3A50", VA = "0x2EB7A50")]
	public static int GetHashCodeCaseInSensitive(string s)
	{
		return default(int);
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x2EB9C24", Offset = "0x2EB5C24", VA = "0x2EB9C24")]
	internal static string UintToString(this List<uint> unicodes)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000044")]
public class UnicodeLineBreakingRules
{
	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private UnityEngine.TextAsset m_UnicodeLineBreakingRules;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UnityEngine.TextAsset m_LeadingCharacters;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEngine.TextAsset m_FollowingCharacters;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private HashSet<uint> m_LeadingCharactersLookup;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private HashSet<uint> m_FollowingCharactersLookup;

	[Token(Token = "0x17000055")]
	public UnityEngine.TextAsset leadingCharacters
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2EB9CFC", Offset = "0x2EB5CFC", VA = "0x2EB9CFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000056")]
	public UnityEngine.TextAsset followingCharacters
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2EB9D04", Offset = "0x2EB5D04", VA = "0x2EB9D04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000057")]
	internal HashSet<uint> leadingCharactersLookup
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2EB9D0C", Offset = "0x2EB5D0C", VA = "0x2EB9D0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000058")]
	internal HashSet<uint> followingCharactersLookup
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2EB9F08", Offset = "0x2EB5F08", VA = "0x2EB9F08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000059")]
	public bool useModernHangulLineBreakingRules
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2EB9F30", Offset = "0x2EB5F30", VA = "0x2EB9F30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x2EB7C1C", Offset = "0x2EB3C1C", VA = "0x2EB7C1C")]
	internal void LoadLineBreakingRules()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x2EB9D34", Offset = "0x2EB5D34", VA = "0x2EB9D34")]
	internal void LoadLineBreakingRules(UnityEngine.TextAsset leadingRules, UnityEngine.TextAsset followingRules)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2EB9F38", Offset = "0x2EB5F38", VA = "0x2EB9F38")]
	private static HashSet<uint> GetCharacters(UnityEngine.TextAsset file)
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x2EB7C14", Offset = "0x2EB3C14", VA = "0x2EB7C14")]
	public UnicodeLineBreakingRules()
	{
	}
}
