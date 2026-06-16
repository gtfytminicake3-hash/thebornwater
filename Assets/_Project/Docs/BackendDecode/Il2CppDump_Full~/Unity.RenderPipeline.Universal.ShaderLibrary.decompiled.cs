using System;
using System.Reflection;
using Il2CppDummyDll;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000002")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum DebugMaterialMode
{
	[Token(Token = "0x4000002")]
	None,
	[Token(Token = "0x4000003")]
	Albedo,
	[Token(Token = "0x4000004")]
	Specular,
	[Token(Token = "0x4000005")]
	Alpha,
	[Token(Token = "0x4000006")]
	Smoothness,
	[Token(Token = "0x4000007")]
	AmbientOcclusion,
	[Token(Token = "0x4000008")]
	Emission,
	[Token(Token = "0x4000009")]
	NormalWorldSpace,
	[Token(Token = "0x400000A")]
	NormalTangentSpace,
	[Token(Token = "0x400000B")]
	LightingComplexity,
	[Token(Token = "0x400000C")]
	Metallic,
	[Token(Token = "0x400000D")]
	SpriteMask
}
[Token(Token = "0x2000003")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum DebugVertexAttributeMode
{
	[Token(Token = "0x400000F")]
	None,
	[Token(Token = "0x4000010")]
	Texcoord0,
	[Token(Token = "0x4000011")]
	Texcoord1,
	[Token(Token = "0x4000012")]
	Texcoord2,
	[Token(Token = "0x4000013")]
	Texcoord3,
	[Token(Token = "0x4000014")]
	Color,
	[Token(Token = "0x4000015")]
	Tangent,
	[Token(Token = "0x4000016")]
	Normal
}
[Token(Token = "0x2000004")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum DebugMaterialValidationMode
{
	[Token(Token = "0x4000018")]
	None,
	[Token(Token = "0x4000019")]
	Albedo,
	[Token(Token = "0x400001A")]
	Metallic
}
[Token(Token = "0x2000005")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum DebugFullScreenMode
{
	[Token(Token = "0x400001C")]
	None,
	[Token(Token = "0x400001D")]
	Depth,
	[Token(Token = "0x400001E")]
	AdditionalLightsShadowMap,
	[Token(Token = "0x400001F")]
	MainLightShadowMap,
	[Token(Token = "0x4000020")]
	ReflectionProbeAtlas
}
[Token(Token = "0x2000006")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum DebugSceneOverrideMode
{
	[Token(Token = "0x4000022")]
	None,
	[Token(Token = "0x4000023")]
	Overdraw,
	[Token(Token = "0x4000024")]
	Wireframe,
	[Token(Token = "0x4000025")]
	SolidWireframe,
	[Token(Token = "0x4000026")]
	ShadedWireframe
}
[Token(Token = "0x2000007")]
public enum DebugOverdrawMode
{
	[Token(Token = "0x4000028")]
	None,
	[Token(Token = "0x4000029")]
	Opaque,
	[Token(Token = "0x400002A")]
	Transparent,
	[Token(Token = "0x400002B")]
	All
}
[Token(Token = "0x2000008")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum DebugMipInfoMode
{
	[Token(Token = "0x400002D")]
	None,
	[Token(Token = "0x400002E")]
	Level,
	[Token(Token = "0x400002F")]
	Count,
	[Token(Token = "0x4000030")]
	Ratio
}
[Token(Token = "0x2000009")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum DebugPostProcessingMode
{
	[Token(Token = "0x4000032")]
	Disabled,
	[Token(Token = "0x4000033")]
	Auto,
	[Token(Token = "0x4000034")]
	Enabled
}
[Token(Token = "0x200000A")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum DebugValidationMode
{
	[Token(Token = "0x4000036")]
	None,
	[Token(Token = "0x4000037")]
	[InspectorName("Highlight NaN, Inf and Negative Values")]
	HighlightNanInfNegative,
	[Token(Token = "0x4000038")]
	[InspectorName("Highlight Values Outside Range")]
	HighlightOutsideOfRange
}
[Token(Token = "0x200000B")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum PixelValidationChannels
{
	[Token(Token = "0x400003A")]
	RGB,
	[Token(Token = "0x400003B")]
	R,
	[Token(Token = "0x400003C")]
	G,
	[Token(Token = "0x400003D")]
	B,
	[Token(Token = "0x400003E")]
	A
}
[Token(Token = "0x200000C")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum DebugLightingMode
{
	[Token(Token = "0x4000040")]
	None,
	[Token(Token = "0x4000041")]
	ShadowCascades,
	[Token(Token = "0x4000042")]
	LightingWithoutNormalMaps,
	[Token(Token = "0x4000043")]
	LightingWithNormalMaps,
	[Token(Token = "0x4000044")]
	Reflections,
	[Token(Token = "0x4000045")]
	ReflectionsWithSmoothness
}
[Token(Token = "0x200000D")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum HDRDebugMode
{
	[Token(Token = "0x4000047")]
	None,
	[Token(Token = "0x4000048")]
	GamutView,
	[Token(Token = "0x4000049")]
	GamutClip,
	[Token(Token = "0x400004A")]
	ValuesAbovePaperWhite
}
[Token(Token = "0x200000E")]
[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
[Flags]
public enum DebugLightingFeatureFlags
{
	[Token(Token = "0x400004C")]
	None = 0,
	[Token(Token = "0x400004D")]
	GlobalIllumination = 1,
	[Token(Token = "0x400004E")]
	MainLight = 2,
	[Token(Token = "0x400004F")]
	AdditionalLights = 4,
	[Token(Token = "0x4000050")]
	VertexLighting = 8,
	[Token(Token = "0x4000051")]
	Emission = 0x10,
	[Token(Token = "0x4000052")]
	AmbientOcclusion = 0x20
}
[Token(Token = "0x200000F")]
public static class ShaderInput
{
	[Token(Token = "0x2000010")]
	[GenerateHLSL(PackingRules.Exact, false, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@14.0.12\\ShaderLibrary\\ShaderTypes.cs")]
	public struct LightData
	{
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x0")]
		public Vector4 position;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x10")]
		public Vector4 color;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x20")]
		public Vector4 attenuation;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x30")]
		public Vector4 spotDirection;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x40")]
		public Vector4 occlusionProbeChannels;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x50")]
		public uint layerMask;
	}
}
