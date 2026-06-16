using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[CompilerGenerated]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2B36818", Offset = "0x2B32818", VA = "0x2B36818")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2B368D4", Offset = "0x2B328D4", VA = "0x2B368D4")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public sealed class DisplayNameAttribute : Attribute
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string displayName;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2B368DC", Offset = "0x2B328DC", VA = "0x2B368DC")]
	public DisplayNameAttribute(string displayName)
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public sealed class MaxAttribute : Attribute
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly float max;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2B36904", Offset = "0x2B32904", VA = "0x2B36904")]
	public MaxAttribute(float max)
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public sealed class MinAttribute : Attribute
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly float min;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2B3692C", Offset = "0x2B3292C", VA = "0x2B3692C")]
	public MinAttribute(float min)
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public sealed class MinMaxAttribute : Attribute
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly float min;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public readonly float max;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2B36954", Offset = "0x2B32954", VA = "0x2B36954")]
	public MinMaxAttribute(float min, float max)
	{
	}
}
[Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class PostProcessAttribute : Attribute
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly Type renderer;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly PostProcessEvent eventType;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly string menuItem;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly bool allowInSceneView;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	internal readonly bool builtinEffect;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2B36980", Offset = "0x2B32980", VA = "0x2B36980")]
	public PostProcessAttribute(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = true)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2B369CC", Offset = "0x2B329CC", VA = "0x2B369CC")]
	internal PostProcessAttribute(Type renderer, string menuItem, bool allowInSceneView = true)
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public sealed class TrackballAttribute : Attribute
{
	[Token(Token = "0x200000A")]
	public enum Mode
	{
		[Token(Token = "0x4000012")]
		None,
		[Token(Token = "0x4000013")]
		Lift,
		[Token(Token = "0x4000014")]
		Gamma,
		[Token(Token = "0x4000015")]
		Gain
	}

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly Mode mode;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2B36A14", Offset = "0x2B32A14", VA = "0x2B36A14")]
	public TrackballAttribute(Mode mode)
	{
	}
}
[Token(Token = "0x200000B")]
public enum AmbientOcclusionMode
{
	[Token(Token = "0x4000017")]
	ScalableAmbientObscurance,
	[Token(Token = "0x4000018")]
	MultiScaleVolumetricObscurance
}
[Token(Token = "0x200000C")]
public enum AmbientOcclusionQuality
{
	[Token(Token = "0x400001A")]
	Lowest,
	[Token(Token = "0x400001B")]
	Low,
	[Token(Token = "0x400001C")]
	Medium,
	[Token(Token = "0x400001D")]
	High,
	[Token(Token = "0x400001E")]
	Ultra
}
[Serializable]
[Token(Token = "0x200000D")]
public sealed class AmbientOcclusionModeParameter : ParameterOverride<AmbientOcclusionMode>
{
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2B36A3C", Offset = "0x2B32A3C", VA = "0x2B36A3C")]
	public AmbientOcclusionModeParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality>
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2B36A84", Offset = "0x2B32A84", VA = "0x2B36A84")]
	public AmbientOcclusionQualityParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x200000F")]
[PostProcess(typeof(AmbientOcclusionRenderer), "Unity/Ambient Occlusion", true)]
public sealed class AmbientOcclusion : PostProcessEffectSettings
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The ambient occlusion method to use. \"Multi Scale Volumetric Obscurance\" is higher quality and faster on desktop & console platforms but requires compute shader support.")]
	public AmbientOcclusionModeParameter mode;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(0f, 4f)]
	[Tooltip("The degree of darkness added by ambient occlusion. Higher values produce darker areas.")]
	public FloatParameter intensity;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("The custom color to use for the ambient occlusion. The default is black.")]
	[ColorUsage(false)]
	public ColorParameter color;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("Check this box to mark this Volume as to only affect ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering. Objects rendered with the Forward rendering path won't get any ambient occlusion.")]
	public BoolParameter ambientOnly;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Range(-8f, 0f)]
	public FloatParameter noiseFilterTolerance;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Range(-8f, -1f)]
	public FloatParameter blurTolerance;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Range(-12f, -1f)]
	public FloatParameter upsampleTolerance;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("This modifies the thickness of occluders. It increases the size of dark areas and also introduces a dark halo around objects.")]
	[Range(1f, 10f)]
	public FloatParameter thicknessModifier;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Range(0f, 0.001f)]
	[Tooltip("Add a bias distance to sampled depth in AO to reduce self-shadowing aliasing artifacts. ")]
	public FloatParameter zBias;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Range(0f, 1f)]
	[Tooltip("Modifies the influence of direct lighting on ambient occlusion.")]
	public FloatParameter directLightingStrength;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("The radius of sample points. This affects the size of darkened areas.")]
	public FloatParameter radius;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Tooltip("The number of sample points. This affects both quality and performance. For \"Lowest\", \"Low\", and \"Medium\", passes are downsampled. For \"High\" and \"Ultra\", they are not and therefore you should only \"High\" and \"Ultra\" on high-end hardware.")]
	public AmbientOcclusionQualityParameter quality;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2B36ACC", Offset = "0x2B32ACC", VA = "0x2B36ACC", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2B36DC0", Offset = "0x2B32DC0", VA = "0x2B36DC0")]
	public AmbientOcclusion()
	{
	}
}
[Token(Token = "0x2000010")]
internal interface IAmbientOcclusionMethod
{
	[Token(Token = "0x600000E")]
	DepthTextureMode GetCameraFlags();

	[Token(Token = "0x600000F")]
	void RenderAfterOpaque(PostProcessRenderContext context);

	[Token(Token = "0x6000010")]
	void RenderAmbientOnly(PostProcessRenderContext context);

	[Token(Token = "0x6000011")]
	void CompositeAmbientOnly(PostProcessRenderContext context);

	[Token(Token = "0x6000012")]
	void Release();
}
[Token(Token = "0x2000011")]
[Preserve]
internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion>
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private IAmbientOcclusionMethod[] m_Methods;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2B37004", Offset = "0x2B33004", VA = "0x2B37004", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2B375DC", Offset = "0x2B335DC", VA = "0x2B375DC")]
	public bool IsAmbientOnly(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2B3766C", Offset = "0x2B3366C", VA = "0x2B3766C")]
	public IAmbientOcclusionMethod Get()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2B376DC", Offset = "0x2B336DC", VA = "0x2B376DC", Slot = "5")]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2B37784", Offset = "0x2B33784", VA = "0x2B37784", Slot = "7")]
	public override void Release()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2B3786C", Offset = "0x2B3386C", VA = "0x2B3786C")]
	public ScalableAO GetScalableAO()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2B378E0", Offset = "0x2B338E0", VA = "0x2B378E0")]
	public MultiScaleVO GetMultiScaleVO()
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2B37958", Offset = "0x2B33958", VA = "0x2B37958", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2B3795C", Offset = "0x2B3395C", VA = "0x2B3795C")]
	public AmbientOcclusionRenderer()
	{
	}
}
[Token(Token = "0x2000012")]
public enum EyeAdaptation
{
	[Token(Token = "0x400002D")]
	Progressive,
	[Token(Token = "0x400002E")]
	Fixed
}
[Serializable]
[Token(Token = "0x2000013")]
public sealed class EyeAdaptationParameter : ParameterOverride<EyeAdaptation>
{
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2B379A4", Offset = "0x2B339A4", VA = "0x2B379A4")]
	public EyeAdaptationParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
[PostProcess(typeof(AutoExposureRenderer), "Unity/Auto Exposure", true)]
public sealed class AutoExposure : PostProcessEffectSettings
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[DisplayName("Filtering (%)")]
	[Tooltip("Filters the bright and dark parts of the histogram when computing the average luminance. This is to avoid very dark pixels and very bright pixels from contributing to the auto exposure. Unit is in percent.")]
	[MinMax(1f, 99f)]
	public Vector2Parameter filtering;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(-9f, 9f)]
	[DisplayName("Minimum (EV)")]
	[Tooltip("Minimum average luminance to consider for auto exposure. Unit is EV.")]
	public FloatParameter minLuminance;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Range(-9f, 9f)]
	[DisplayName("Maximum (EV)")]
	[Tooltip("Maximum average luminance to consider for auto exposure. Unit is EV.")]
	public FloatParameter maxLuminance;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[DisplayName("Exposure Compensation")]
	[Tooltip("Use this to scale the global exposure of the scene.")]
	[Min(0f)]
	public FloatParameter keyValue;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[DisplayName("Type")]
	[Tooltip("Use \"Progressive\" if you want auto exposure to be animated. Use \"Fixed\" otherwise.")]
	public EyeAdaptationParameter eyeAdaptation;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Tooltip("Adaptation speed from a dark to a light environment.")]
	[Min(0f)]
	public FloatParameter speedUp;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("Adaptation speed from a light to a dark environment.")]
	[Min(0f)]
	public FloatParameter speedDown;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2B379EC", Offset = "0x2B339EC", VA = "0x2B379EC", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2B37B44", Offset = "0x2B33B44", VA = "0x2B37B44")]
	public AutoExposure()
	{
	}
}
[Token(Token = "0x2000015")]
[Preserve]
internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure>
{
	[Token(Token = "0x4000036")]
	private const int k_NumEyes = 2;

	[Token(Token = "0x4000037")]
	private const int k_NumAutoExposureTextures = 2;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly RenderTexture[][] m_AutoExposurePool;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int[] m_AutoExposurePingPong;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture m_CurrentAutoExposure;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2B37CA8", Offset = "0x2B33CA8", VA = "0x2B37CA8")]
	public AutoExposureRenderer()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2B37DF0", Offset = "0x2B33DF0", VA = "0x2B37DF0")]
	private void CheckTexture(int eye, int id)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2B37FE4", Offset = "0x2B33FE4", VA = "0x2B37FE4", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2B38674", Offset = "0x2B34674", VA = "0x2B38674", Slot = "7")]
	public override void Release()
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
[PostProcess(typeof(BloomRenderer), "Unity/Bloom", true)]
public sealed class Bloom : PostProcessEffectSettings
{
	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Strength of the bloom filter. Values higher than 1 will make bloom contribute more energy to the final render.")]
	[Min(0f)]
	public FloatParameter intensity;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Min(0f)]
	[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
	public FloatParameter threshold;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("Makes transitions between under/over-threshold gradual. 0 for a hard threshold, 1 for a soft threshold).")]
	[Range(0f, 1f)]
	public FloatParameter softKnee;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("Clamps pixels to control the bloom amount. Value is in gamma-space.")]
	public FloatParameter clamp;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Range(1f, 10f)]
	[Tooltip("Changes the extent of veiling effects. For maximum quality, use integer values. Because this value changes the internal iteration count, You should not animating it as it may introduce issues with the perceived radius.")]
	public FloatParameter diffusion;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Range(-1f, 1f)]
	[Tooltip("Distorts the bloom to give an anamorphic look. Negative values distort vertically, positive values distort horizontally.")]
	public FloatParameter anamorphicRatio;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[ColorUsage(false, true)]
	[Tooltip("Global tint of the bloom filter.")]
	public ColorParameter color;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performance by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public BoolParameter fastMode;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("The lens dirt texture used to add smudges or dust to the bloom effect.")]
	[DisplayName("Texture")]
	public TextureParameter dirtTexture;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Min(0f)]
	[Tooltip("The intensity of the lens dirtiness.")]
	[DisplayName("Intensity")]
	public FloatParameter dirtIntensity;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2B38760", Offset = "0x2B34760", VA = "0x2B38760", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2B3879C", Offset = "0x2B3479C", VA = "0x2B3879C")]
	public Bloom()
	{
	}
}
[Token(Token = "0x2000017")]
[Preserve]
internal sealed class BloomRenderer : PostProcessEffectRenderer<Bloom>
{
	[Token(Token = "0x2000018")]
	private enum Pass
	{
		[Token(Token = "0x4000048")]
		Prefilter13,
		[Token(Token = "0x4000049")]
		Prefilter4,
		[Token(Token = "0x400004A")]
		Downsample13,
		[Token(Token = "0x400004B")]
		Downsample4,
		[Token(Token = "0x400004C")]
		UpsampleTent,
		[Token(Token = "0x400004D")]
		UpsampleBox,
		[Token(Token = "0x400004E")]
		DebugOverlayThreshold,
		[Token(Token = "0x400004F")]
		DebugOverlayTent,
		[Token(Token = "0x4000050")]
		DebugOverlayBox
	}

	[Token(Token = "0x2000019")]
	private struct Level
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int down;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal int up;
	}

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Level[] m_Pyramid;

	[Token(Token = "0x4000046")]
	private const int k_MaxPyramidSize = 16;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2B3897C", Offset = "0x2B3497C", VA = "0x2B3897C", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2B38AA8", Offset = "0x2B34AA8", VA = "0x2B38AA8", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2B396EC", Offset = "0x2B356EC", VA = "0x2B396EC")]
	public BloomRenderer()
	{
	}
}
[Serializable]
[Token(Token = "0x200001A")]
[PostProcess(typeof(ChromaticAberrationRenderer), "Unity/Chromatic Aberration", true)]
public sealed class ChromaticAberration : PostProcessEffectSettings
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Shifts the hue of chromatic aberrations.")]
	public TextureParameter spectralLut;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(0f, 1f)]
	[Tooltip("Amount of tangential distortion.")]
	public FloatParameter intensity;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performances by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public BoolParameter fastMode;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2B39734", Offset = "0x2B35734", VA = "0x2B39734", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2B39770", Offset = "0x2B35770", VA = "0x2B39770")]
	public ChromaticAberration()
	{
	}
}
[Token(Token = "0x200001B")]
[Preserve]
internal sealed class ChromaticAberrationRenderer : PostProcessEffectRenderer<ChromaticAberration>
{
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Texture2D m_InternalSpectralLut;

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2B39844", Offset = "0x2B35844", VA = "0x2B39844", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2B39B30", Offset = "0x2B35B30", VA = "0x2B39B30", Slot = "7")]
	public override void Release()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2B39B94", Offset = "0x2B35B94", VA = "0x2B39B94")]
	public ChromaticAberrationRenderer()
	{
	}
}
[Token(Token = "0x200001C")]
public enum GradingMode
{
	[Token(Token = "0x4000058")]
	LowDefinitionRange,
	[Token(Token = "0x4000059")]
	HighDefinitionRange,
	[Token(Token = "0x400005A")]
	External
}
[Token(Token = "0x200001D")]
public enum Tonemapper
{
	[Token(Token = "0x400005C")]
	None,
	[Token(Token = "0x400005D")]
	Neutral,
	[Token(Token = "0x400005E")]
	ACES,
	[Token(Token = "0x400005F")]
	Custom
}
[Serializable]
[Token(Token = "0x200001E")]
public sealed class GradingModeParameter : ParameterOverride<GradingMode>
{
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2B39BDC", Offset = "0x2B35BDC", VA = "0x2B39BDC")]
	public GradingModeParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x200001F")]
public sealed class TonemapperParameter : ParameterOverride<Tonemapper>
{
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2B39C24", Offset = "0x2B35C24", VA = "0x2B39C24")]
	public TonemapperParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000020")]
[PostProcess(typeof(ColorGradingRenderer), "Unity/Color Grading", true)]
public sealed class ColorGrading : PostProcessEffectSettings
{
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[DisplayName("Mode")]
	[Tooltip("Select a color grading mode that fits your dynamic range and workflow. Use HDR if your camera is set to render in HDR and your target platform supports it. Use LDR for low-end mobiles or devices that don't support HDR. Use External if you prefer authoring a Log LUT in an external software.")]
	public GradingModeParameter gradingMode;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[DisplayName("Lookup Texture")]
	[Tooltip("A custom 3D log-encoded texture.")]
	public TextureParameter externalLut;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[DisplayName("Mode")]
	[Tooltip("Select a tonemapping algorithm to use at the end of the color grading process.")]
	public TonemapperParameter tonemapper;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[DisplayName("Toe Strength")]
	[Range(0f, 1f)]
	[Tooltip("Affects the transition between the toe and the mid section of the curve. A value of 0 means no toe, a value of 1 means a very hard transition.")]
	public FloatParameter toneCurveToeStrength;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Tooltip("Affects how much of the dynamic range is in the toe. With a small value, the toe will be very short and quickly transition into the linear section, with a larger value, the toe will be longer.")]
	[Range(0f, 1f)]
	[DisplayName("Toe Length")]
	public FloatParameter toneCurveToeLength;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[DisplayName("Shoulder Strength")]
	[Tooltip("Affects the transition between the mid section and the shoulder of the curve. A value of 0 means no shoulder, a value of 1 means a very hard transition.")]
	[Range(0f, 1f)]
	public FloatParameter toneCurveShoulderStrength;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[DisplayName("Shoulder Length")]
	[Min(0f)]
	[Tooltip("Affects how many F-stops (EV) to add to the dynamic range of the curve.")]
	public FloatParameter toneCurveShoulderLength;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[DisplayName("Shoulder Angle")]
	[Tooltip("Affects how much overshoot to add to the shoulder.")]
	[Range(0f, 1f)]
	public FloatParameter toneCurveShoulderAngle;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Min(0.001f)]
	[DisplayName("Gamma")]
	[Tooltip("Applies a gamma function to the curve.")]
	public FloatParameter toneCurveGamma;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[DisplayName("Lookup Texture")]
	[Tooltip("Custom lookup texture (strip format, for example 256x16) to apply before the rest of the color grading operators. If none is provided, a neutral one will be generated internally.")]
	public TextureParameter ldrLut;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Range(0f, 1f)]
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	[DisplayName("Contribution")]
	public FloatParameter ldrLutContribution;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[DisplayName("Temperature")]
	[Tooltip("Sets the white balance to a custom color temperature.")]
	[Range(-100f, 100f)]
	public FloatParameter temperature;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[DisplayName("Tint")]
	[Range(-100f, 100f)]
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	public FloatParameter tint;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[ColorUsage(false, true)]
	[DisplayName("Color Filter")]
	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[DisplayName("Hue Shift")]
	[Range(-180f, 180f)]
	[Tooltip("Shift the hue of all colors.")]
	public FloatParameter hueShift;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[DisplayName("Saturation")]
	[Range(-100f, 100f)]
	[Tooltip("Pushes the intensity of all colors.")]
	public FloatParameter saturation;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Tooltip("Makes the image brighter or darker.")]
	[Range(-100f, 100f)]
	[DisplayName("Brightness")]
	public FloatParameter brightness;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[DisplayName("Post-exposure (EV)")]
	[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after the HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Range(-100f, 100f)]
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	[DisplayName("Contrast")]
	public FloatParameter contrast;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[DisplayName("Red")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerRedOutRedIn;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[DisplayName("Green")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerRedOutGreenIn;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[DisplayName("Blue")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Range(-200f, 200f)]
	public FloatParameter mixerRedOutBlueIn;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[DisplayName("Red")]
	[Range(-200f, 200f)]
	public FloatParameter mixerGreenOutRedIn;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[DisplayName("Green")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerGreenOutGreenIn;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[DisplayName("Blue")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Range(-200f, 200f)]
	public FloatParameter mixerGreenOutBlueIn;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Range(-200f, 200f)]
	[DisplayName("Red")]
	public FloatParameter mixerBlueOutRedIn;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[Range(-200f, 200f)]
	[DisplayName("Green")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerBlueOutGreenIn;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Range(-200f, 200f)]
	[DisplayName("Blue")]
	public FloatParameter mixerBlueOutBlueIn;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[DisplayName("Lift")]
	[Tooltip("Controls the darkest portions of the render.")]
	[Trackball(TrackballAttribute.Mode.Lift)]
	public Vector4Parameter lift;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[Trackball(TrackballAttribute.Mode.Gamma)]
	[DisplayName("Gamma")]
	[Tooltip("Power function that controls mid-range tones.")]
	public Vector4Parameter gamma;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[DisplayName("Gain")]
	[Tooltip("Controls the lightest portions of the render.")]
	[Trackball(TrackballAttribute.Mode.Gain)]
	public Vector4Parameter gain;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public SplineParameter masterCurve;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public SplineParameter redCurve;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public SplineParameter greenCurve;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public SplineParameter blueCurve;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public SplineParameter hueVsHueCurve;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public SplineParameter hueVsSatCurve;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public SplineParameter satVsSatCurve;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public SplineParameter lumVsSatCurve;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2B39C6C", Offset = "0x2B35C6C", VA = "0x2B39C6C", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2B39CC0", Offset = "0x2B35CC0", VA = "0x2B39CC0")]
	public ColorGrading()
	{
	}
}
[Token(Token = "0x2000021")]
[Preserve]
internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading>
{
	[Token(Token = "0x2000022")]
	private enum Pass
	{
		[Token(Token = "0x400008F")]
		LutGenLDRFromScratch,
		[Token(Token = "0x4000090")]
		LutGenLDR,
		[Token(Token = "0x4000091")]
		LutGenHDR2D
	}

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Texture2D m_GradingCurves;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Color[] m_Pixels;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture m_InternalLdrLut;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RenderTexture m_InternalLogLut;

	[Token(Token = "0x400008B")]
	private const int k_Lut2DSize = 32;

	[Token(Token = "0x400008C")]
	private const int k_Lut3DSize = 33;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly HableCurve m_HableCurve;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2B3A77C", Offset = "0x2B3677C", VA = "0x2B3A77C", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2B3A8C0", Offset = "0x2B368C0", VA = "0x2B3A8C0")]
	private void RenderExternalPipeline3D(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2B3AABC", Offset = "0x2B36ABC", VA = "0x2B3AABC")]
	private void RenderHDRPipeline3D(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2B3B4E4", Offset = "0x2B374E4", VA = "0x2B3B4E4")]
	private void RenderHDRPipeline2D(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2B3BE40", Offset = "0x2B37E40", VA = "0x2B3BE40")]
	private void RenderLDRPipeline2D(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2B3C690", Offset = "0x2B38690", VA = "0x2B3C690")]
	private void CheckInternalLogLut()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2B3CBA0", Offset = "0x2B38BA0", VA = "0x2B3CBA0")]
	private void CheckInternalStripLut()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2B3C860", Offset = "0x2B38860", VA = "0x2B3C860")]
	private Texture2D GetCurveTexture(bool hdr)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2B3CD98", Offset = "0x2B38D98", VA = "0x2B3CD98")]
	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format)
	{
		return default(bool);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2B3CD3C", Offset = "0x2B38D3C", VA = "0x2B3CD3C")]
	private static RenderTextureFormat GetLutFormat()
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2B3CD70", Offset = "0x2B38D70", VA = "0x2B3CD70")]
	private static TextureFormat GetCurveFormat()
	{
		return default(TextureFormat);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2B3CE00", Offset = "0x2B38E00", VA = "0x2B3CE00", Slot = "7")]
	public override void Release()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2B3CE84", Offset = "0x2B38E84", VA = "0x2B3CE84")]
	public ColorGradingRenderer()
	{
	}
}
[Token(Token = "0x2000023")]
public enum KernelSize
{
	[Token(Token = "0x4000093")]
	Small,
	[Token(Token = "0x4000094")]
	Medium,
	[Token(Token = "0x4000095")]
	Large,
	[Token(Token = "0x4000096")]
	VeryLarge
}
[Serializable]
[Token(Token = "0x2000024")]
public sealed class KernelSizeParameter : ParameterOverride<KernelSize>
{
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2B3CF28", Offset = "0x2B38F28", VA = "0x2B3CF28")]
	public KernelSizeParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000025")]
[PostProcess(typeof(DepthOfFieldRenderer), "Unity/Depth of Field", false)]
public sealed class DepthOfField : PostProcessEffectSettings
{
	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Min(0.1f)]
	[Tooltip("Distance to the point of focus.")]
	public FloatParameter focusDistance;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(0.05f, 32f)]
	[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
	public FloatParameter aperture;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
	[Range(1f, 300f)]
	public FloatParameter focalLength;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[DisplayName("Max Blur Size")]
	[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects performances (the larger the kernel is, the longer the GPU time is required).")]
	public KernelSizeParameter kernelSize;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2B3CF70", Offset = "0x2B38F70", VA = "0x2B3CF70", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2B3CFA8", Offset = "0x2B38FA8", VA = "0x2B3CFA8")]
	public DepthOfField()
	{
	}
}
[Token(Token = "0x2000026")]
[Preserve]
internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField>
{
	[Token(Token = "0x2000027")]
	private enum Pass
	{
		[Token(Token = "0x40000A1")]
		CoCCalculation,
		[Token(Token = "0x40000A2")]
		CoCTemporalFilter,
		[Token(Token = "0x40000A3")]
		DownsampleAndPrefilter,
		[Token(Token = "0x40000A4")]
		BokehSmallKernel,
		[Token(Token = "0x40000A5")]
		BokehMediumKernel,
		[Token(Token = "0x40000A6")]
		BokehLargeKernel,
		[Token(Token = "0x40000A7")]
		BokehVeryLargeKernel,
		[Token(Token = "0x40000A8")]
		PostFilter,
		[Token(Token = "0x40000A9")]
		Combine,
		[Token(Token = "0x40000AA")]
		DebugOverlay
	}

	[Token(Token = "0x400009B")]
	private const int k_NumEyes = 2;

	[Token(Token = "0x400009C")]
	private const int k_NumCoCHistoryTextures = 2;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly RenderTexture[][] m_CoCHistoryTextures;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int[] m_HistoryPingPong;

	[Token(Token = "0x400009F")]
	private const float k_FilmHeight = 0.024f;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2B3D098", Offset = "0x2B39098", VA = "0x2B3D098")]
	public DepthOfFieldRenderer()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2B3D1E0", Offset = "0x2B391E0", VA = "0x2B3D1E0", Slot = "5")]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2B3D1E8", Offset = "0x2B391E8", VA = "0x2B3D1E8")]
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2B3D280", Offset = "0x2B39280", VA = "0x2B3D280")]
	private float CalculateMaxCoCRadius(int screenHeight)
	{
		return default(float);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2B3D300", Offset = "0x2B39300", VA = "0x2B3D300")]
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2B3D550", Offset = "0x2B39550", VA = "0x2B3D550", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2B3DE40", Offset = "0x2B39E40", VA = "0x2B3DE40", Slot = "7")]
	public override void Release()
	{
	}
}
[Serializable]
[Token(Token = "0x2000028")]
[Preserve]
internal sealed class Dithering
{
	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int m_NoiseTextureIndex;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private System.Random m_Random;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2B3DF28", Offset = "0x2B39F28", VA = "0x2B3DF28")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2B3E0B0", Offset = "0x2B3A0B0", VA = "0x2B3E0B0")]
	public Dithering()
	{
	}
}
[Serializable]
[Token(Token = "0x2000029")]
[Preserve]
public sealed class FastApproximateAntialiasing
{
	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Tooltip("Boost performances by lowering the effect quality. This setting is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	[FormerlySerializedAs("mobileOptimized")]
	public bool fastMode;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[Tooltip("Keep alpha channel. This will slightly lower the effect quality but allows rendering against a transparent background.\nThis setting has no effect if the camera render target has no alpha channel.")]
	public bool keepAlpha;

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2B3E114", Offset = "0x2B3A114", VA = "0x2B3E114")]
	public FastApproximateAntialiasing()
	{
	}
}
[Serializable]
[Token(Token = "0x200002A")]
[Preserve]
public sealed class Fog
{
	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Tooltip("Enables the internal deferred fog pass. Actual fog settings should be set in the Lighting panel.")]
	public bool enabled;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[Tooltip("Mark true for the fog to ignore the skybox")]
	public bool excludeSkybox;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2B3E11C", Offset = "0x2B3A11C", VA = "0x2B3E11C")]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2B3E124", Offset = "0x2B3A124", VA = "0x2B3E124")]
	internal bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2B3E22C", Offset = "0x2B3A22C", VA = "0x2B3E22C")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2B3E49C", Offset = "0x2B3A49C", VA = "0x2B3E49C")]
	public Fog()
	{
	}
}
[Serializable]
[Token(Token = "0x200002B")]
[PostProcess(typeof(GrainRenderer), "Unity/Grain", true)]
public sealed class Grain : PostProcessEffectSettings
{
	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Enable the use of colored grain.")]
	public BoolParameter colored;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(0f, 1f)]
	[Tooltip("Grain strength. Higher values mean more visible grain.")]
	public FloatParameter intensity;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Range(0.3f, 3f)]
	[Tooltip("Grain particle size.")]
	public FloatParameter size;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Range(0f, 1f)]
	[DisplayName("Luminance Contribution")]
	[Tooltip("Controls the noise response curve based on scene luminance. Lower values mean less noise in dark areas.")]
	public FloatParameter lumContrib;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2B3E4AC", Offset = "0x2B3A4AC", VA = "0x2B3E4AC", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2B3E4E8", Offset = "0x2B3A4E8", VA = "0x2B3E4E8")]
	public Grain()
	{
	}
}
[Token(Token = "0x200002C")]
[Preserve]
internal sealed class GrainRenderer : PostProcessEffectRenderer<Grain>
{
	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderTexture m_GrainLookupRT;

	[Token(Token = "0x40000B6")]
	private const int k_SampleCount = 1024;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int m_SampleIndex;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2B3E5D8", Offset = "0x2B3A5D8", VA = "0x2B3E5D8", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2B3EB8C", Offset = "0x2B3AB8C", VA = "0x2B3EB8C")]
	private RenderTextureFormat GetLookupFormat()
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2B3EBF0", Offset = "0x2B3ABF0", VA = "0x2B3EBF0", Slot = "7")]
	public override void Release()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2B3EC58", Offset = "0x2B3AC58", VA = "0x2B3EC58")]
	public GrainRenderer()
	{
	}
}
[Serializable]
[Token(Token = "0x200002D")]
[PostProcess(typeof(LensDistortionRenderer), "Unity/Lens Distortion", true)]
public sealed class LensDistortion : PostProcessEffectSettings
{
	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(-100f, 100f)]
	[Tooltip("Total distortion amount.")]
	public FloatParameter intensity;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[DisplayName("X Multiplier")]
	[Tooltip("Intensity multiplier on the x-axis. Set it to 0 to disable distortion on this axis.")]
	[Range(0f, 1f)]
	public FloatParameter intensityX;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("Intensity multiplier on the y-axis. Set it to 0 to disable distortion on this axis.")]
	[DisplayName("Y Multiplier")]
	[Range(0f, 1f)]
	public FloatParameter intensityY;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space]
	[Tooltip("Distortion center point (x-axis).")]
	[Range(-1f, 1f)]
	public FloatParameter centerX;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Range(-1f, 1f)]
	[Tooltip("Distortion center point (y-axis).")]
	public FloatParameter centerY;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space]
	[Range(0.01f, 5f)]
	[Tooltip("Global screen scaling.")]
	public FloatParameter scale;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2B3ECA0", Offset = "0x2B3ACA0", VA = "0x2B3ECA0", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2B3EDAC", Offset = "0x2B3ADAC", VA = "0x2B3EDAC")]
	public LensDistortion()
	{
	}
}
[Token(Token = "0x200002E")]
[Preserve]
internal sealed class LensDistortionRenderer : PostProcessEffectRenderer<LensDistortion>
{
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2B3EEC8", Offset = "0x2B3AEC8", VA = "0x2B3EEC8", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2B3F0C4", Offset = "0x2B3B0C4", VA = "0x2B3F0C4")]
	public LensDistortionRenderer()
	{
	}
}
[Serializable]
[Token(Token = "0x200002F")]
[PostProcess(typeof(MotionBlurRenderer), "Unity/Motion Blur", false)]
public sealed class MotionBlur : PostProcessEffectSettings
{
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
	[Range(0f, 360f)]
	public FloatParameter shutterAngle;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(4f, 32f)]
	[Tooltip("The amount of sample points. This affects quality and performance.")]
	public IntParameter sampleCount;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2B3F10C", Offset = "0x2B3B10C", VA = "0x2B3F10C", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2B3F1BC", Offset = "0x2B3B1BC", VA = "0x2B3F1BC")]
	public MotionBlur()
	{
	}
}
[Token(Token = "0x2000030")]
[Preserve]
internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur>
{
	[Token(Token = "0x2000031")]
	private enum Pass
	{
		[Token(Token = "0x40000C1")]
		VelocitySetup,
		[Token(Token = "0x40000C2")]
		TileMax1,
		[Token(Token = "0x40000C3")]
		TileMax2,
		[Token(Token = "0x40000C4")]
		TileMaxV,
		[Token(Token = "0x40000C5")]
		NeighborMax,
		[Token(Token = "0x40000C6")]
		Reconstruction
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2B3F264", Offset = "0x2B3B264", VA = "0x2B3F264", Slot = "5")]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2B3F26C", Offset = "0x2B3B26C", VA = "0x2B3F26C")]
	private void CreateTemporaryRT(PostProcessRenderContext context, int nameID, int width, int height, RenderTextureFormat RTFormat)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2B3F30C", Offset = "0x2B3B30C", VA = "0x2B3F30C", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2B3FBD8", Offset = "0x2B3BBD8", VA = "0x2B3FBD8")]
	public MotionBlurRenderer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000032")]
[Preserve]
internal sealed class MultiScaleVO : IAmbientOcclusionMethod
{
	[Token(Token = "0x2000033")]
	internal enum MipLevel
	{
		[Token(Token = "0x40000D7")]
		Original,
		[Token(Token = "0x40000D8")]
		L1,
		[Token(Token = "0x40000D9")]
		L2,
		[Token(Token = "0x40000DA")]
		L3,
		[Token(Token = "0x40000DB")]
		L4,
		[Token(Token = "0x40000DC")]
		L5,
		[Token(Token = "0x40000DD")]
		L6
	}

	[Token(Token = "0x2000034")]
	private enum Pass
	{
		[Token(Token = "0x40000DF")]
		DepthCopy,
		[Token(Token = "0x40000E0")]
		CompositionDeferred,
		[Token(Token = "0x40000E1")]
		CompositionForward,
		[Token(Token = "0x40000E2")]
		DebugOverlay
	}

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly float[] m_SampleThickness;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly float[] m_InvThicknessTable;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly float[] m_SampleWeightTable;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly int[] m_Widths;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly int[] m_Heights;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly int[] m_ScaledWidths;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly int[] m_ScaledHeights;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AmbientOcclusion m_Settings;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private PropertySheet m_PropertySheet;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private PostProcessResources m_Resources;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private RenderTexture m_AmbientOnlyAO;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private RenderTextureFormat m_R8Format;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private RenderTextureFormat m_R16Format;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool float4Texture;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly RenderTargetIdentifier[] m_MRT;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2B3725C", Offset = "0x2B3325C", VA = "0x2B3725C")]
	public MultiScaleVO(AmbientOcclusion settings)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2B3FC20", Offset = "0x2B3BC20", VA = "0x2B3FC20", Slot = "4")]
	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2B3FC28", Offset = "0x2B3BC28", VA = "0x2B3FC28")]
	public void SetResources(PostProcessResources resources)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2B3FC30", Offset = "0x2B3BC30", VA = "0x2B3FC30")]
	private void Alloc(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2B3FD70", Offset = "0x2B3BD70", VA = "0x2B3FD70")]
	private void AllocArray(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2B3FEB4", Offset = "0x2B3BEB4", VA = "0x2B3FEB4")]
	private void Release(CommandBuffer cmd, int id)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2B3FED0", Offset = "0x2B3BED0", VA = "0x2B3FED0")]
	private Vector4 CalculateZBufferParams(Camera camera)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2B3FF3C", Offset = "0x2B3BF3C", VA = "0x2B3FF3C")]
	private float CalculateTanHalfFovHeight(Camera camera)
	{
		return default(float);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2B3FF90", Offset = "0x2B3BF90", VA = "0x2B3FF90")]
	private Vector2 GetSize(MipLevel mip)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2B3FFE8", Offset = "0x2B3BFE8", VA = "0x2B3FFE8")]
	private Vector3 GetSizeArray(MipLevel mip)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2B40044", Offset = "0x2B3C044", VA = "0x2B40044")]
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2B40750", Offset = "0x2B3C750", VA = "0x2B40750")]
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA, Camera camera)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2B40CF4", Offset = "0x2B3CCF4", VA = "0x2B40CF4")]
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, RenderTargetIdentifier? depthMap, bool isMSAA)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2B4147C", Offset = "0x2B3D47C", VA = "0x2B4147C")]
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2B41A54", Offset = "0x2B3DA54", VA = "0x2B41A54")]
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, int? highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2B41F60", Offset = "0x2B3DF60", VA = "0x2B41F60")]
	private void PushReleaseCommands(CommandBuffer cmd)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2B42134", Offset = "0x2B3E134", VA = "0x2B42134")]
	private void PreparePropertySheet(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2B4221C", Offset = "0x2B3E21C", VA = "0x2B4221C")]
	private void CheckAOTexture(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2B42424", Offset = "0x2B3E424", VA = "0x2B42424")]
	private void PushDebug(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2B424A8", Offset = "0x2B3E4A8", VA = "0x2B424A8", Slot = "5")]
	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2B42794", Offset = "0x2B3E794", VA = "0x2B42794", Slot = "6")]
	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2B42898", Offset = "0x2B3E898", VA = "0x2B42898", Slot = "7")]
	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2B42A38", Offset = "0x2B3EA38", VA = "0x2B42A38", Slot = "8")]
	public void Release()
	{
	}
}
[Serializable]
[Token(Token = "0x2000035")]
[Preserve]
internal sealed class ScalableAO : IAmbientOcclusionMethod
{
	[Token(Token = "0x2000036")]
	private enum Pass
	{
		[Token(Token = "0x40000E9")]
		OcclusionEstimationForward,
		[Token(Token = "0x40000EA")]
		OcclusionEstimationDeferred,
		[Token(Token = "0x40000EB")]
		HorizontalBlurForward,
		[Token(Token = "0x40000EC")]
		HorizontalBlurDeferred,
		[Token(Token = "0x40000ED")]
		VerticalBlur,
		[Token(Token = "0x40000EE")]
		CompositionForward,
		[Token(Token = "0x40000EF")]
		CompositionDeferred,
		[Token(Token = "0x40000F0")]
		DebugOverlay
	}

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private RenderTexture m_Result;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PropertySheet m_PropertySheet;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AmbientOcclusion m_Settings;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly RenderTargetIdentifier[] m_MRT;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly int[] m_SampleCount;

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2B37134", Offset = "0x2B33134", VA = "0x2B37134")]
	public ScalableAO(AmbientOcclusion settings)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2B42A9C", Offset = "0x2B3EA9C", VA = "0x2B42A9C", Slot = "4")]
	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2B42AA4", Offset = "0x2B3EAA4", VA = "0x2B42AA4")]
	private void DoLazyInitialization(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2B42C3C", Offset = "0x2B3EC3C", VA = "0x2B42C3C")]
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2B43108", Offset = "0x2B3F108", VA = "0x2B43108", Slot = "5")]
	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2B432C0", Offset = "0x2B3F2C0", VA = "0x2B432C0", Slot = "6")]
	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2B4334C", Offset = "0x2B3F34C", VA = "0x2B4334C", Slot = "7")]
	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2B434EC", Offset = "0x2B3F4EC", VA = "0x2B434EC", Slot = "8")]
	public void Release()
	{
	}
}
[Token(Token = "0x2000037")]
public enum ScreenSpaceReflectionPreset
{
	[Token(Token = "0x40000F2")]
	Lower,
	[Token(Token = "0x40000F3")]
	Low,
	[Token(Token = "0x40000F4")]
	Medium,
	[Token(Token = "0x40000F5")]
	High,
	[Token(Token = "0x40000F6")]
	Higher,
	[Token(Token = "0x40000F7")]
	Ultra,
	[Token(Token = "0x40000F8")]
	Overkill,
	[Token(Token = "0x40000F9")]
	Custom
}
[Token(Token = "0x2000038")]
public enum ScreenSpaceReflectionResolution
{
	[Token(Token = "0x40000FB")]
	Downsampled,
	[Token(Token = "0x40000FC")]
	FullSize,
	[Token(Token = "0x40000FD")]
	Supersampled
}
[Serializable]
[Token(Token = "0x2000039")]
public sealed class ScreenSpaceReflectionPresetParameter : ParameterOverride<ScreenSpaceReflectionPreset>
{
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2B43550", Offset = "0x2B3F550", VA = "0x2B43550")]
	public ScreenSpaceReflectionPresetParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x200003A")]
public sealed class ScreenSpaceReflectionResolutionParameter : ParameterOverride<ScreenSpaceReflectionResolution>
{
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x2B43598", Offset = "0x2B3F598", VA = "0x2B43598")]
	public ScreenSpaceReflectionResolutionParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x200003B")]
[PostProcess(typeof(ScreenSpaceReflectionsRenderer), "Unity/Screen-space reflections", true)]
public sealed class ScreenSpaceReflections : PostProcessEffectSettings
{
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Choose a quality preset, or use \"Custom\" to create your own custom preset. Don't use a preset higher than \"Medium\" if you desire good performance on consoles.")]
	public ScreenSpaceReflectionPresetParameter preset;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Maximum number of steps in the raymarching pass. Higher values mean more reflections.")]
	[Range(0f, 256f)]
	public IntParameter maximumIterationCount;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("Changes the size of the SSR buffer. Downsample it to maximize performances or supersample it for higher quality results with reduced performance.")]
	public ScreenSpaceReflectionResolutionParameter resolution;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Range(1f, 64f)]
	[Tooltip("Ray thickness. Lower values are more expensive but allow the effect to detect smaller details.")]
	public FloatParameter thickness;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Tooltip("Maximum distance to traverse after which it will stop drawing reflections.")]
	public FloatParameter maximumMarchDistance;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Range(0f, 1f)]
	[Tooltip("Fades reflections close to the near planes.")]
	public FloatParameter distanceFade;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Range(0f, 1f)]
	[Tooltip("Fades reflections close to the screen edges.")]
	public FloatParameter vignette;

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2B435E0", Offset = "0x2B3F5E0", VA = "0x2B435E0", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2B4371C", Offset = "0x2B3F71C", VA = "0x2B4371C")]
	public ScreenSpaceReflections()
	{
	}
}
[Token(Token = "0x200003C")]
[Preserve]
internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections>
{
	[Token(Token = "0x200003D")]
	private class QualityPreset
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maximumIterationCount;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float thickness;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScreenSpaceReflectionResolution downsampling;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2B44D54", Offset = "0x2B40D54", VA = "0x2B44D54")]
		public QualityPreset()
		{
		}
	}

	[Token(Token = "0x200003E")]
	private enum Pass
	{
		[Token(Token = "0x400010D")]
		Test,
		[Token(Token = "0x400010E")]
		Resolve,
		[Token(Token = "0x400010F")]
		Reproject,
		[Token(Token = "0x4000110")]
		Composite
	}

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderTexture m_Resolve;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RenderTexture m_History;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int[] m_MipIDs;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly QualityPreset[] m_Presets;

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2B43898", Offset = "0x2B3F898", VA = "0x2B43898", Slot = "5")]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2B438A0", Offset = "0x2B3F8A0", VA = "0x2B438A0")]
	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2B43AA0", Offset = "0x2B3FAA0", VA = "0x2B43AA0", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2B44A1C", Offset = "0x2B40A1C", VA = "0x2B44A1C", Slot = "7")]
	public override void Release()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2B44A90", Offset = "0x2B40A90", VA = "0x2B44A90")]
	public ScreenSpaceReflectionsRenderer()
	{
	}
}
[Serializable]
[Token(Token = "0x200003F")]
[Preserve]
public sealed class SubpixelMorphologicalAntialiasing
{
	[Token(Token = "0x2000040")]
	private enum Pass
	{
		[Token(Token = "0x4000113")]
		EdgeDetection = 0,
		[Token(Token = "0x4000114")]
		BlendWeights = 3,
		[Token(Token = "0x4000115")]
		NeighborhoodBlending = 6
	}

	[Token(Token = "0x2000041")]
	public enum Quality
	{
		[Token(Token = "0x4000117")]
		Low,
		[Token(Token = "0x4000118")]
		Medium,
		[Token(Token = "0x4000119")]
		High
	}

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Tooltip("Lower quality is faster at the expense of visual quality (Low = ~60%, Medium = ~80%).")]
	public Quality quality;

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2B44D5C", Offset = "0x2B40D5C", VA = "0x2B44D5C")]
	public bool IsSupported()
	{
		return default(bool);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2B44DB8", Offset = "0x2B40DB8", VA = "0x2B44DB8")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2B451C8", Offset = "0x2B411C8", VA = "0x2B451C8")]
	public SubpixelMorphologicalAntialiasing()
	{
	}
}
[Serializable]
[Token(Token = "0x2000042")]
[Preserve]
public sealed class TemporalAntialiasing
{
	[Token(Token = "0x2000043")]
	private enum Pass
	{
		[Token(Token = "0x4000129")]
		SolverDilate,
		[Token(Token = "0x400012A")]
		SolverNoDilate
	}

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Range(0.1f, 1f)]
	[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable, but blurrier, output.")]
	public float jitterSpread;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Range(0f, 3f)]
	[Tooltip("Controls the amount of sharpening applied to the color buffer. High values may introduce dark-border artifacts.")]
	public float sharpness;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 0.99f)]
	[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
	public float stationaryBlending;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
	[Range(0f, 0.99f)]
	public float motionBlending;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly RenderTargetIdentifier[] m_Mrt;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_ResetHistory;

	[Token(Token = "0x4000122")]
	private const int k_SampleCount = 8;

	[Token(Token = "0x4000124")]
	private const int k_NumEyes = 2;

	[Token(Token = "0x4000125")]
	private const int k_NumHistoryTextures = 2;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly RenderTexture[][] m_HistoryTextures;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly int[] m_HistoryPingPong;

	[Token(Token = "0x17000001")]
	public Vector2 jitter
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2B451D8", Offset = "0x2B411D8", VA = "0x2B451D8")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2B451E0", Offset = "0x2B411E0", VA = "0x2B451E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public int sampleIndex
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2B451E8", Offset = "0x2B411E8", VA = "0x2B451E8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2B451F0", Offset = "0x2B411F0", VA = "0x2B451F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2B451F8", Offset = "0x2B411F8", VA = "0x2B451F8")]
	public bool IsSupported()
	{
		return default(bool);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2B45238", Offset = "0x2B41238", VA = "0x2B45238")]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2B45240", Offset = "0x2B41240", VA = "0x2B45240")]
	internal void ResetHistory()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2B4524C", Offset = "0x2B4124C", VA = "0x2B4524C")]
	private Vector2 GenerateRandomOffset()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2B452BC", Offset = "0x2B412BC", VA = "0x2B452BC")]
	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2B45434", Offset = "0x2B41434", VA = "0x2B45434")]
	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2B454C4", Offset = "0x2B414C4", VA = "0x2B454C4")]
	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2B45630", Offset = "0x2B41630", VA = "0x2B45630")]
	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2B45720", Offset = "0x2B41720", VA = "0x2B45720")]
	private RenderTexture CheckHistory(int id, PostProcessRenderContext context)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2B45B50", Offset = "0x2B41B50", VA = "0x2B45B50")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2B45E84", Offset = "0x2B41E84", VA = "0x2B45E84")]
	internal void Release()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2B45F94", Offset = "0x2B41F94", VA = "0x2B45F94")]
	public TemporalAntialiasing()
	{
	}
}
[Token(Token = "0x2000044")]
public enum VignetteMode
{
	[Token(Token = "0x400012C")]
	Classic,
	[Token(Token = "0x400012D")]
	Masked
}
[Serializable]
[Token(Token = "0x2000045")]
public sealed class VignetteModeParameter : ParameterOverride<VignetteMode>
{
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2B4605C", Offset = "0x2B4205C", VA = "0x2B4605C")]
	public VignetteModeParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000046")]
[PostProcess(typeof(VignetteRenderer), "Unity/Vignette", true)]
public sealed class Vignette : PostProcessEffectSettings
{
	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
	public VignetteModeParameter mode;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Vignette color.")]
	public ColorParameter color;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("Sets the vignette center point (screen center is [0.5, 0.5]).")]
	public Vector2Parameter center;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Range(0f, 1f)]
	[Tooltip("Amount of vignetting on screen.")]
	public FloatParameter intensity;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Range(0.01f, 1f)]
	[Tooltip("Smoothness of the vignette borders.")]
	public FloatParameter smoothness;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Tooltip("Lower values will make a square-ish vignette.")]
	[Range(0f, 1f)]
	public FloatParameter roundness;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("Set to true to mark the vignette to be perfectly round. False will make its shape dependent on the current aspect ratio.")]
	public BoolParameter rounded;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("A black and white mask to use as a vignette.")]
	public TextureParameter mask;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Mask opacity.")]
	[Range(0f, 1f)]
	public FloatParameter opacity;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2B460A4", Offset = "0x2B420A4", VA = "0x2B460A4", Slot = "4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2B46178", Offset = "0x2B42178", VA = "0x2B46178")]
	public Vignette()
	{
	}
}
[Token(Token = "0x2000047")]
[Preserve]
internal sealed class VignetteRenderer : PostProcessEffectRenderer<Vignette>
{
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2B46360", Offset = "0x2B42360", VA = "0x2B46360", Slot = "8")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2B465F4", Offset = "0x2B425F4", VA = "0x2B465F4")]
	public VignetteRenderer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000048")]
public sealed class HistogramMonitor : Monitor
{
	[Token(Token = "0x2000049")]
	public enum Channel
	{
		[Token(Token = "0x400013F")]
		Red,
		[Token(Token = "0x4000140")]
		Green,
		[Token(Token = "0x4000141")]
		Blue,
		[Token(Token = "0x4000142")]
		Master
	}

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int width;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int height;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Channel channel;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ComputeBuffer m_Data;

	[Token(Token = "0x400013B")]
	private const int k_NumBins = 256;

	[Token(Token = "0x400013C")]
	private const int k_ThreadGroupSizeX = 16;

	[Token(Token = "0x400013D")]
	private const int k_ThreadGroupSizeY = 16;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2B4663C", Offset = "0x2B4263C", VA = "0x2B4663C", Slot = "7")]
	internal override void OnDisable()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2B466BC", Offset = "0x2B426BC", VA = "0x2B466BC", Slot = "5")]
	internal override bool NeedsHalfRes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2B466C4", Offset = "0x2B426C4", VA = "0x2B466C4", Slot = "4")]
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2B46738", Offset = "0x2B42738", VA = "0x2B46738", Slot = "8")]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2B47108", Offset = "0x2B43108", VA = "0x2B47108")]
	public HistogramMonitor()
	{
	}
}
[Serializable]
[Token(Token = "0x200004A")]
public sealed class LightMeterMonitor : Monitor
{
	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int width;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int height;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool showCurves;

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2B4712C", Offset = "0x2B4312C", VA = "0x2B4712C", Slot = "4")]
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2B471D4", Offset = "0x2B431D4", VA = "0x2B471D4", Slot = "8")]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x2B47610", Offset = "0x2B43610", VA = "0x2B47610")]
	public LightMeterMonitor()
	{
	}
}
[Token(Token = "0x200004B")]
public enum MonitorType
{
	[Token(Token = "0x4000147")]
	LightMeter,
	[Token(Token = "0x4000148")]
	Histogram,
	[Token(Token = "0x4000149")]
	Waveform,
	[Token(Token = "0x400014A")]
	Vectorscope
}
[Token(Token = "0x200004C")]
public abstract class Monitor
{
	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal bool requested;

	[Token(Token = "0x17000003")]
	public RenderTexture output
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2B4762C", Offset = "0x2B4362C", VA = "0x2B4762C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2B47634", Offset = "0x2B43634", VA = "0x2B47634")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2B4763C", Offset = "0x2B4363C", VA = "0x2B4763C")]
	public bool IsRequestedAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AB")]
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2B477B4", Offset = "0x2B437B4", VA = "0x2B477B4", Slot = "5")]
	internal virtual bool NeedsHalfRes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2B46C68", Offset = "0x2B42C68", VA = "0x2B46C68")]
	protected void CheckOutput(int width, int height)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2B47844", Offset = "0x2B43844", VA = "0x2B47844", Slot = "6")]
	internal virtual void OnEnable()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2B46664", Offset = "0x2B42664", VA = "0x2B46664", Slot = "7")]
	internal virtual void OnDisable()
	{
	}

	[Token(Token = "0x60000B0")]
	internal abstract void Render(PostProcessRenderContext context);

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2B47124", Offset = "0x2B43124", VA = "0x2B47124")]
	protected Monitor()
	{
	}
}
[Serializable]
[Token(Token = "0x200004D")]
public sealed class VectorscopeMonitor : Monitor
{
	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int size;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float exposure;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ComputeBuffer m_Data;

	[Token(Token = "0x4000150")]
	private const int k_ThreadGroupSizeX = 16;

	[Token(Token = "0x4000151")]
	private const int k_ThreadGroupSizeY = 16;

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2B47848", Offset = "0x2B43848", VA = "0x2B47848", Slot = "7")]
	internal override void OnDisable()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2B47870", Offset = "0x2B43870", VA = "0x2B47870", Slot = "5")]
	internal override bool NeedsHalfRes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2B47878", Offset = "0x2B43878", VA = "0x2B47878", Slot = "4")]
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2B478EC", Offset = "0x2B438EC", VA = "0x2B478EC", Slot = "8")]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2B47EE4", Offset = "0x2B43EE4", VA = "0x2B47EE4")]
	public VectorscopeMonitor()
	{
	}
}
[Serializable]
[Token(Token = "0x200004E")]
public sealed class WaveformMonitor : Monitor
{
	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float exposure;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int height;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ComputeBuffer m_Data;

	[Token(Token = "0x4000155")]
	private const int k_ThreadGroupSize = 256;

	[Token(Token = "0x4000156")]
	private const int k_ThreadGroupSizeX = 16;

	[Token(Token = "0x4000157")]
	private const int k_ThreadGroupSizeY = 16;

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2B47EFC", Offset = "0x2B43EFC", VA = "0x2B47EFC", Slot = "7")]
	internal override void OnDisable()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2B47F24", Offset = "0x2B43F24", VA = "0x2B47F24", Slot = "5")]
	internal override bool NeedsHalfRes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2B47F2C", Offset = "0x2B43F2C", VA = "0x2B47F2C", Slot = "4")]
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2B47FA0", Offset = "0x2B43FA0", VA = "0x2B47FA0", Slot = "8")]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2B4887C", Offset = "0x2B4487C", VA = "0x2B4887C")]
	public WaveformMonitor()
	{
	}
}
[Token(Token = "0x200004F")]
public abstract class ParameterOverride
{
	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool overrideState;

	[Token(Token = "0x60000BC")]
	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	[Token(Token = "0x60000BD")]
	public abstract int GetHash();

	[Token(Token = "0x60000BE")]
	public T GetValue<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x2B48894", Offset = "0x2B44894", VA = "0x2B48894", Slot = "6")]
	protected internal virtual void OnEnable()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2B48898", Offset = "0x2B44898", VA = "0x2B48898", Slot = "7")]
	protected internal virtual void OnDisable()
	{
	}

	[Token(Token = "0x60000C1")]
	internal abstract void SetValue(ParameterOverride parameter);

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2B4889C", Offset = "0x2B4489C", VA = "0x2B4889C")]
	protected ParameterOverride()
	{
	}
}
[Serializable]
[Token(Token = "0x2000050")]
public class ParameterOverride<T> : ParameterOverride
{
	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T value;

	[Token(Token = "0x60000C3")]
	public ParameterOverride()
	{
	}

	[Token(Token = "0x60000C4")]
	public ParameterOverride(T value)
	{
	}

	[Token(Token = "0x60000C5")]
	public ParameterOverride(T value, bool overrideState)
	{
	}

	[Token(Token = "0x60000C6")]
	internal override void Interp(ParameterOverride from, ParameterOverride to, float t)
	{
	}

	[Token(Token = "0x60000C7")]
	public virtual void Interp(T from, T to, float t)
	{
	}

	[Token(Token = "0x60000C8")]
	public void Override(T x)
	{
	}

	[Token(Token = "0x60000C9")]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[Token(Token = "0x60000CA")]
	public override int GetHash()
	{
		return default(int);
	}

	[Token(Token = "0x60000CB")]
	public static implicit operator T(ParameterOverride<T> prop)
	{
		return (T)null;
	}
}
[Serializable]
[Token(Token = "0x2000051")]
public sealed class FloatParameter : ParameterOverride<float>
{
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2B488A4", Offset = "0x2B448A4", VA = "0x2B488A4", Slot = "9")]
	public override void Interp(float from, float to, float t)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2B488B8", Offset = "0x2B448B8", VA = "0x2B488B8")]
	public FloatParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000052")]
public sealed class IntParameter : ParameterOverride<int>
{
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2B48900", Offset = "0x2B44900", VA = "0x2B48900", Slot = "9")]
	public override void Interp(int from, int to, float t)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x2B48934", Offset = "0x2B44934", VA = "0x2B48934")]
	public IntParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000053")]
public sealed class BoolParameter : ParameterOverride<bool>
{
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x2B4897C", Offset = "0x2B4497C", VA = "0x2B4897C")]
	public BoolParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000054")]
public sealed class ColorParameter : ParameterOverride<Color>
{
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x2B489C4", Offset = "0x2B449C4", VA = "0x2B489C4", Slot = "9")]
	public override void Interp(Color from, Color to, float t)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x2B489F4", Offset = "0x2B449F4", VA = "0x2B489F4")]
	public static implicit operator Vector4(ColorParameter prop)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2B48A0C", Offset = "0x2B44A0C", VA = "0x2B48A0C")]
	public ColorParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000055")]
public sealed class Vector2Parameter : ParameterOverride<Vector2>
{
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2B48A54", Offset = "0x2B44A54", VA = "0x2B48A54", Slot = "9")]
	public override void Interp(Vector2 from, Vector2 to, float t)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2B48A74", Offset = "0x2B44A74", VA = "0x2B48A74")]
	public static implicit operator Vector3(Vector2Parameter prop)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2B48A8C", Offset = "0x2B44A8C", VA = "0x2B48A8C")]
	public static implicit operator Vector4(Vector2Parameter prop)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x2B48AA8", Offset = "0x2B44AA8", VA = "0x2B48AA8")]
	public Vector2Parameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000056")]
public sealed class Vector3Parameter : ParameterOverride<Vector3>
{
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x2B48AF0", Offset = "0x2B44AF0", VA = "0x2B48AF0", Slot = "9")]
	public override void Interp(Vector3 from, Vector3 to, float t)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x2B48B20", Offset = "0x2B44B20", VA = "0x2B48B20")]
	public static implicit operator Vector2(Vector3Parameter prop)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x2B48B34", Offset = "0x2B44B34", VA = "0x2B48B34")]
	public static implicit operator Vector4(Vector3Parameter prop)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x2B48B50", Offset = "0x2B44B50", VA = "0x2B48B50")]
	public Vector3Parameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000057")]
public sealed class Vector4Parameter : ParameterOverride<Vector4>
{
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x2B48B98", Offset = "0x2B44B98", VA = "0x2B48B98", Slot = "9")]
	public override void Interp(Vector4 from, Vector4 to, float t)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x2B48BC8", Offset = "0x2B44BC8", VA = "0x2B48BC8")]
	public static implicit operator Vector2(Vector4Parameter prop)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x2B48BDC", Offset = "0x2B44BDC", VA = "0x2B48BDC")]
	public static implicit operator Vector3(Vector4Parameter prop)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x2B48BF4", Offset = "0x2B44BF4", VA = "0x2B48BF4")]
	public Vector4Parameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000058")]
public sealed class SplineParameter : ParameterOverride<Spline>
{
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x2B48C3C", Offset = "0x2B44C3C", VA = "0x2B48C3C", Slot = "6")]
	protected internal override void OnEnable()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x2B48C54", Offset = "0x2B44C54", VA = "0x2B48C54", Slot = "8")]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x2B48CDC", Offset = "0x2B44CDC", VA = "0x2B48CDC", Slot = "9")]
	public override void Interp(Spline from, Spline to, float t)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x2B48E14", Offset = "0x2B44E14", VA = "0x2B48E14")]
	public SplineParameter()
	{
	}
}
[Token(Token = "0x2000059")]
public enum TextureParameterDefault
{
	[Token(Token = "0x400015B")]
	None,
	[Token(Token = "0x400015C")]
	Black,
	[Token(Token = "0x400015D")]
	White,
	[Token(Token = "0x400015E")]
	Transparent,
	[Token(Token = "0x400015F")]
	Lut2D
}
[Serializable]
[Token(Token = "0x200005A")]
public sealed class TextureParameter : ParameterOverride<Texture>
{
	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextureParameterDefault defaultState;

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x2B48E5C", Offset = "0x2B44E5C", VA = "0x2B48E5C", Slot = "9")]
	public override void Interp(Texture from, Texture to, float t)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x2B49588", Offset = "0x2B45588", VA = "0x2B49588")]
	public TextureParameter()
	{
	}
}
[Token(Token = "0x200005B")]
public sealed class PostProcessBundle
{
	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PostProcessEffectRenderer m_Renderer;

	[Token(Token = "0x17000004")]
	public PostProcessAttribute attribute
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2B495D8", Offset = "0x2B455D8", VA = "0x2B495D8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2B495E0", Offset = "0x2B455E0", VA = "0x2B495E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public PostProcessEffectSettings settings
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2B495E8", Offset = "0x2B455E8", VA = "0x2B495E8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2B495F0", Offset = "0x2B455F0", VA = "0x2B495F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000006")]
	internal PostProcessEffectRenderer renderer
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2B495F8", Offset = "0x2B455F8", VA = "0x2B495F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x2B496E0", Offset = "0x2B456E0", VA = "0x2B496E0")]
	internal PostProcessBundle(PostProcessEffectSettings settings)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x2B4978C", Offset = "0x2B4578C", VA = "0x2B4978C")]
	internal void Release()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x2B497F8", Offset = "0x2B457F8", VA = "0x2B497F8")]
	internal void ResetHistory()
	{
	}

	[Token(Token = "0x60000EE")]
	internal T CastSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	internal T CastRenderer<T>() where T : PostProcessEffectRenderer
	{
		return null;
	}
}
[Token(Token = "0x200005C")]
[ExecuteAlways]
[AddComponentMenu("Rendering/Post-process Debug", 1002)]
public sealed class PostProcessDebug : MonoBehaviour
{
	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PostProcessLayer postProcessLayer;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private PostProcessLayer m_PreviousPostProcessLayer;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool lightMeter;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool histogram;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool waveform;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool vectorscope;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public DebugOverlay debugOverlay;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera m_CurrentCamera;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CommandBuffer m_CmdAfterEverything;

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x2B49810", Offset = "0x2B45810", VA = "0x2B49810")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2B49894", Offset = "0x2B45894", VA = "0x2B49894")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x2B49920", Offset = "0x2B45920", VA = "0x2B49920")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x2B49B18", Offset = "0x2B45B18", VA = "0x2B49B18")]
	private void Reset()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x2B49924", Offset = "0x2B45924", VA = "0x2B49924")]
	private void UpdateStates()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x2B49BD8", Offset = "0x2B45BD8", VA = "0x2B49BD8")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x2B49CCC", Offset = "0x2B45CCC", VA = "0x2B49CCC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x2B49DBC", Offset = "0x2B45DBC", VA = "0x2B49DBC")]
	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x2B49F00", Offset = "0x2B45F00", VA = "0x2B49F00")]
	public PostProcessDebug()
	{
	}
}
[Token(Token = "0x200005D")]
public enum DebugOverlay
{
	[Token(Token = "0x400016E")]
	None,
	[Token(Token = "0x400016F")]
	Depth,
	[Token(Token = "0x4000170")]
	Normals,
	[Token(Token = "0x4000171")]
	MotionVectors,
	[Token(Token = "0x4000172")]
	NANTracker,
	[Token(Token = "0x4000173")]
	ColorBlindnessSimulation,
	[Token(Token = "0x4000174")]
	_,
	[Token(Token = "0x4000175")]
	AmbientOcclusion,
	[Token(Token = "0x4000176")]
	BloomBuffer,
	[Token(Token = "0x4000177")]
	BloomThreshold,
	[Token(Token = "0x4000178")]
	DepthOfField
}
[Token(Token = "0x200005E")]
public enum ColorBlindnessType
{
	[Token(Token = "0x400017A")]
	Deuteranopia,
	[Token(Token = "0x400017B")]
	Protanopia,
	[Token(Token = "0x400017C")]
	Tritanopia
}
[Serializable]
[Token(Token = "0x200005F")]
public sealed class PostProcessDebugLayer
{
	[Serializable]
	[Token(Token = "0x2000060")]
	public class OverlaySettings
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool linearDepth;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 16f)]
		public float motionColorIntensity;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(4f, 128f)]
		public int motionGridSize;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorBlindnessType colorBlindnessType;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float colorBlindnessStrength;

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2B4AEB8", Offset = "0x2B46EB8", VA = "0x2B4AEB8")]
		public OverlaySettings()
		{
		}
	}

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LightMeterMonitor lightMeter;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HistogramMonitor histogram;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public WaveformMonitor waveform;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public VectorscopeMonitor vectorscope;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<MonitorType, Monitor> m_Monitors;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int frameWidth;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int frameHeight;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public OverlaySettings overlaySettings;

	[Token(Token = "0x17000007")]
	public RenderTexture debugOverlayTarget
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2B49F08", Offset = "0x2B45F08", VA = "0x2B49F08")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2B49F10", Offset = "0x2B45F10", VA = "0x2B49F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public bool debugOverlayActive
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2B49F18", Offset = "0x2B45F18", VA = "0x2B49F18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2B49F20", Offset = "0x2B45F20", VA = "0x2B49F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public DebugOverlay debugOverlay
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2B49F28", Offset = "0x2B45F28", VA = "0x2B49F28")]
		[CompilerGenerated]
		get
		{
			return default(DebugOverlay);
		}
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2B49F30", Offset = "0x2B45F30", VA = "0x2B49F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x2B49F38", Offset = "0x2B45F38", VA = "0x2B49F38")]
	internal void OnEnable()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2B4A1FC", Offset = "0x2B461FC", VA = "0x2B4A1FC")]
	internal void OnDisable()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x2B4A350", Offset = "0x2B46350", VA = "0x2B4A350")]
	private void DestroyDebugOverlayTarget()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2B49B68", Offset = "0x2B45B68", VA = "0x2B49B68")]
	public void RequestMonitorPass(MonitorType monitor)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2B49BD0", Offset = "0x2B45BD0", VA = "0x2B49BD0")]
	public void RequestDebugOverlay(DebugOverlay mode)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2B4A3B0", Offset = "0x2B463B0", VA = "0x2B4A3B0")]
	internal void SetFrameSize(int width, int height)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2B4A3BC", Offset = "0x2B463BC", VA = "0x2B4A3BC")]
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x2B4A610", Offset = "0x2B46610", VA = "0x2B4A610")]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2B4A638", Offset = "0x2B46638", VA = "0x2B4A638")]
	internal void RenderMonitors(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2B4A9F8", Offset = "0x2B469F8", VA = "0x2B4A9F8")]
	internal void RenderSpecialOverlays(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x2B4AD5C", Offset = "0x2B46D5C", VA = "0x2B4AD5C")]
	internal void EndFrame()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x2B4AEB0", Offset = "0x2B46EB0", VA = "0x2B4AEB0")]
	public PostProcessDebugLayer()
	{
	}
}
[Token(Token = "0x2000061")]
public abstract class PostProcessEffectRenderer
{
	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected bool m_ResetHistory;

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x2B4AED4", Offset = "0x2B46ED4", VA = "0x2B4AED4", Slot = "4")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x2B4AED8", Offset = "0x2B46ED8", VA = "0x2B4AED8", Slot = "5")]
	public virtual DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x2B4AEE0", Offset = "0x2B46EE0", VA = "0x2B4AEE0", Slot = "6")]
	public virtual void ResetHistory()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x2B4AEEC", Offset = "0x2B46EEC", VA = "0x2B4AEEC", Slot = "7")]
	public virtual void Release()
	{
	}

	[Token(Token = "0x6000110")]
	public abstract void Render(PostProcessRenderContext context);

	[Token(Token = "0x6000111")]
	internal abstract void SetSettings(PostProcessEffectSettings settings);

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x2B4AEF8", Offset = "0x2B46EF8", VA = "0x2B4AEF8")]
	protected PostProcessEffectRenderer()
	{
	}
}
[Token(Token = "0x2000062")]
public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer where T : PostProcessEffectSettings
{
	[Token(Token = "0x1700000A")]
	public T settings
	{
		[Token(Token = "0x6000113")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000114")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x6000115")]
	internal override void SetSettings(PostProcessEffectSettings settings)
	{
	}

	[Token(Token = "0x6000116")]
	protected PostProcessEffectRenderer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000063")]
public class PostProcessEffectSettings : ScriptableObject
{
	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool active;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BoolParameter enabled;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal ReadOnlyCollection<ParameterOverride> parameters;

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x2B4AF08", Offset = "0x2B46F08", VA = "0x2B4AF08")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x2B4B3D0", Offset = "0x2B473D0", VA = "0x2B4B3D0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x2B4B618", Offset = "0x2B47618", VA = "0x2B4B618")]
	public void SetAllOverridesTo(bool state, bool excludeEnabled = true)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x2B4B88C", Offset = "0x2B4788C", VA = "0x2B4B88C", Slot = "4")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x2B4B8A4", Offset = "0x2B478A4", VA = "0x2B4B8A4")]
	public int GetHash()
	{
		return default(int);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x2B4BB18", Offset = "0x2B47B18", VA = "0x2B4BB18")]
	public PostProcessEffectSettings()
	{
	}
}
[Token(Token = "0x2000065")]
public enum PostProcessEvent
{
	[Token(Token = "0x4000196")]
	BeforeTransparent,
	[Token(Token = "0x4000197")]
	BeforeStack,
	[Token(Token = "0x4000198")]
	AfterStack
}
[Token(Token = "0x2000066")]
internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent>
{
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x2B4BD58", Offset = "0x2B47D58", VA = "0x2B4BD58", Slot = "4")]
	public bool Equals(PostProcessEvent x, PostProcessEvent y)
	{
		return default(bool);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x2B4BD64", Offset = "0x2B47D64", VA = "0x2B4BD64", Slot = "5")]
	public int GetHashCode(PostProcessEvent obj)
	{
		return default(int);
	}
}
[Token(Token = "0x2000067")]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Rendering/Post-process Layer", 1000)]
[ImageEffectAllowedInSceneView]
[DisallowMultipleComponent]
[ExecuteAlways]
public sealed class PostProcessLayer : MonoBehaviour
{
	[Token(Token = "0x2000068")]
	public enum Antialiasing
	{
		[Token(Token = "0x40001BF")]
		None,
		[Token(Token = "0x40001C0")]
		FastApproximateAntialiasing,
		[Token(Token = "0x40001C1")]
		SubpixelMorphologicalAntialiasing,
		[Token(Token = "0x40001C2")]
		TemporalAntialiasing
	}

	[Serializable]
	[Token(Token = "0x2000069")]
	public sealed class SerializedBundleRef
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string assemblyQualifiedName;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PostProcessBundle bundle;

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2B4D020", Offset = "0x2B49020", VA = "0x2B4D020")]
		public SerializedBundleRef()
		{
		}
	}

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform volumeTrigger;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LayerMask volumeLayer;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool stopNaNPropagation;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool finalBlitToCameraTarget;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Antialiasing antialiasingMode;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TemporalAntialiasing temporalAntialiasing;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public FastApproximateAntialiasing fastApproximateAntialiasing;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Fog fog;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Dithering dithering;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public PostProcessDebugLayer debugLayer;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private PostProcessResources m_Resources;

	[NonSerialized]
	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private PostProcessResources m_OldResources;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Preserve]
	private bool m_ShowToolkit;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	[SerializeField]
	[Preserve]
	private bool m_ShowCustomSorter;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
	public bool breakBeforeColorGrading;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private List<SerializedBundleRef> m_BeforeTransparentBundles;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private List<SerializedBundleRef> m_BeforeStackBundles;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private List<SerializedBundleRef> m_AfterStackBundles;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Dictionary<Type, PostProcessBundle> m_Bundles;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private PropertySheetFactory m_PropertySheetFactory;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CommandBuffer m_LegacyCmdBufferBeforeReflections;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private CommandBuffer m_LegacyCmdBufferBeforeLighting;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private CommandBuffer m_LegacyCmdBufferOpaque;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private CommandBuffer m_LegacyCmdBuffer;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Camera m_Camera;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private PostProcessRenderContext m_CurrentContext;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private LogHistogram m_LogHistogram;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool m_SettingsUpdateNeeded;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
	private bool m_IsRenderingInSceneView;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private TargetPool m_TargetPool;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool m_NaNKilled;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly List<PostProcessEffectRenderer> m_ActiveEffects;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly List<RenderTargetIdentifier> m_Targets;

	[Token(Token = "0x1700000B")]
	public Dictionary<PostProcessEvent, List<SerializedBundleRef>> sortedBundles
	{
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2B4BD6C", Offset = "0x2B47D6C", VA = "0x2B4BD6C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2B4BD74", Offset = "0x2B47D74", VA = "0x2B4BD74")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public DepthTextureMode cameraDepthFlags
	{
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2B4BD7C", Offset = "0x2B47D7C", VA = "0x2B4BD7C")]
		[CompilerGenerated]
		get
		{
			return default(DepthTextureMode);
		}
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2B4BD84", Offset = "0x2B47D84", VA = "0x2B4BD84")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool haveBundlesBeenInited
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2B4BD8C", Offset = "0x2B47D8C", VA = "0x2B4BD8C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2B4BD94", Offset = "0x2B47D94", VA = "0x2B4BD94")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x2B4BD9C", Offset = "0x2B47D9C", VA = "0x2B4BD9C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x2B4C4DC", Offset = "0x2B484DC", VA = "0x2B4C4DC")]
	private void InitLegacy()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x2B4C6C8", Offset = "0x2B486C8", VA = "0x2B4C6C8")]
	private bool DynamicResolutionAllowsFinalBlitToCameraTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x2B4C820", Offset = "0x2B48820", VA = "0x2B4C820")]
	[ImageEffectUsesCommandBuffer]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x2B4BEBC", Offset = "0x2B47EBC", VA = "0x2B4BEBC")]
	public void Init(PostProcessResources resources)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x2B4C018", Offset = "0x2B48018", VA = "0x2B4C018")]
	public void InitBundles()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x2B4C940", Offset = "0x2B48940", VA = "0x2B4C940")]
	private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x2B4D030", Offset = "0x2B49030", VA = "0x2B4D030")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x2B4D44C", Offset = "0x2B4944C", VA = "0x2B4D44C")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x2B4D468", Offset = "0x2B49468", VA = "0x2B4D468")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x2B4E400", Offset = "0x2B4A400", VA = "0x2B4E400")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x2B4E484", Offset = "0x2B4A484", VA = "0x2B4E484")]
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x2B4E48C", Offset = "0x2B4A48C", VA = "0x2B4E48C")]
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x2B4D914", Offset = "0x2B49914", VA = "0x2B4D914")]
	private void BuildCommandBuffers()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x2B4F978", Offset = "0x2B4B978", VA = "0x2B4F978")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6000139")]
	public PostProcessBundle GetBundle<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x2B4FAFC", Offset = "0x2B4BAFC", VA = "0x2B4FAFC")]
	public PostProcessBundle GetBundle(Type settingsType)
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	public T GetSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x2B4FB54", Offset = "0x2B4BB54", VA = "0x2B4FB54")]
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA = false)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x2B4FC54", Offset = "0x2B4BC54", VA = "0x2B4FC54")]
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x2B4FEE0", Offset = "0x2B4BEE0", VA = "0x2B4FEE0")]
	private void SetLegacyCameraFlags(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x2B5013C", Offset = "0x2B4C13C", VA = "0x2B5013C")]
	public void ResetHistory()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x2B4EC54", Offset = "0x2B4AC54", VA = "0x2B4EC54")]
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x2B502A0", Offset = "0x2B4C2A0", VA = "0x2B502A0")]
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x2B4E934", Offset = "0x2B4A934", VA = "0x2B4E934")]
	private void SetupContext(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x2B4EA84", Offset = "0x2B4AA84", VA = "0x2B4EA84")]
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x2B4EF30", Offset = "0x2B4AF30", VA = "0x2B4EF30")]
	public void RenderOpaqueOnly(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x2B4F018", Offset = "0x2B4B018", VA = "0x2B4F018")]
	public void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x2B51670", Offset = "0x2B4D670", VA = "0x2B51670")]
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1)
	{
		return default(int);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x2B50B20", Offset = "0x2B4CB20", VA = "0x2B50B20")]
	private void RenderList(List<SerializedBundleRef> list, PostProcessRenderContext context, string marker)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x2B526B8", Offset = "0x2B4E6B8", VA = "0x2B526B8")]
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x2B5275C", Offset = "0x2B4E75C", VA = "0x2B5275C")]
	private void ApplyDefaultFlip(MaterialPropertyBlock properties)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x2B517D4", Offset = "0x2B4D7D4", VA = "0x2B517D4")]
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1)
	{
		return default(int);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x2B51FA8", Offset = "0x2B4DFA8", VA = "0x2B51FA8")]
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1)
	{
	}

	[Token(Token = "0x600014C")]
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = false) where T : PostProcessEffectSettings
	{
		return default(int);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x2B529D0", Offset = "0x2B4E9D0", VA = "0x2B529D0")]
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x2B53140", Offset = "0x2B4F140", VA = "0x2B53140")]
	public PostProcessLayer()
	{
	}
}
[Token(Token = "0x200006F")]
public sealed class PostProcessManager
{
	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PostProcessManager s_Instance;

	[Token(Token = "0x40001CD")]
	private const int k_MaxLayerCount = 32;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly List<PostProcessVolume> m_Volumes;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Dictionary<int, bool> m_SortNeeded;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly List<PostProcessEffectSettings> m_BaseSettings;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly List<Collider> m_TempColliders;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes;

	[Token(Token = "0x1700000E")]
	public static PostProcessManager instance
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2B4C8CC", Offset = "0x2B488CC", VA = "0x2B4C8CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x2B534BC", Offset = "0x2B4F4BC", VA = "0x2B534BC")]
	private PostProcessManager()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x2B53BC8", Offset = "0x2B4FBC8", VA = "0x2B53BC8")]
	private void CleanBaseTypes()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2B5369C", Offset = "0x2B4F69C", VA = "0x2B5369C")]
	private void ReloadBaseTypes()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x2B53D74", Offset = "0x2B4FD74", VA = "0x2B53D74")]
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = true, bool skipZeroWeight = true)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x2B54748", Offset = "0x2B50748", VA = "0x2B54748")]
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer)
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x2B54810", Offset = "0x2B50810", VA = "0x2B54810")]
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x2B549B8", Offset = "0x2B509B8", VA = "0x2B549B8")]
	public PostProcessVolume QuickVolume(int layer, float priority, params PostProcessEffectSettings[] settings)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x2B54E98", Offset = "0x2B50E98", VA = "0x2B54E98")]
	internal void SetLayerDirty(int layer)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x2B55018", Offset = "0x2B51018", VA = "0x2B55018")]
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x2B551FC", Offset = "0x2B511FC", VA = "0x2B551FC")]
	private void Register(PostProcessVolume volume, int layer)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x2B5543C", Offset = "0x2B5143C", VA = "0x2B5543C")]
	internal void Register(PostProcessVolume volume)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x2B55058", Offset = "0x2B51058", VA = "0x2B55058")]
	private void Unregister(PostProcessVolume volume, int layer)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x2B55484", Offset = "0x2B51484", VA = "0x2B55484")]
	internal void Unregister(PostProcessVolume volume)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x2B554D4", Offset = "0x2B514D4", VA = "0x2B554D4")]
	private void ReplaceData(PostProcessLayer postProcessLayer)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x2B505C8", Offset = "0x2B4C5C8", VA = "0x2B505C8")]
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x2B54334", Offset = "0x2B50334", VA = "0x2B54334")]
	private List<PostProcessVolume> GrabVolumes(LayerMask mask)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x2B5573C", Offset = "0x2B5173C", VA = "0x2B5573C")]
	private static void SortByPriority(List<PostProcessVolume> volumes)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x2B55870", Offset = "0x2B51870", VA = "0x2B55870")]
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000071")]
public sealed class PostProcessProfile : ScriptableObject
{
	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("A list of all settings currently stored in this profile.")]
	public List<PostProcessEffectSettings> settings;

	[NonSerialized]
	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isDirty;

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x2B55994", Offset = "0x2B51994", VA = "0x2B55994")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000173")]
	public T AddSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x2B55A90", Offset = "0x2B51A90", VA = "0x2B55A90")]
	public PostProcessEffectSettings AddSettings(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x2B54D84", Offset = "0x2B50D84", VA = "0x2B54D84")]
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	public void RemoveSettings<T>() where T : PostProcessEffectSettings
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x2B55DC8", Offset = "0x2B51DC8", VA = "0x2B55DC8")]
	public void RemoveSettings(Type type)
	{
	}

	[Token(Token = "0x6000178")]
	public bool HasSettings<T>() where T : PostProcessEffectSettings
	{
		return default(bool);
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x2B55C34", Offset = "0x2B51C34", VA = "0x2B55C34")]
	public bool HasSettings(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x600017A")]
	public T GetSetting<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	public bool TryGetSettings<T>(out T outSetting) where T : PostProcessEffectSettings
	{
		return default(bool);
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x2B55F24", Offset = "0x2B51F24", VA = "0x2B55F24")]
	public PostProcessProfile()
	{
	}
}
[Token(Token = "0x2000073")]
public sealed class PostProcessRenderContext
{
	[Token(Token = "0x2000074")]
	public enum StereoRenderingMode
	{
		[Token(Token = "0x40001F8")]
		MultiPass,
		[Token(Token = "0x40001F9")]
		SinglePass,
		[Token(Token = "0x40001FA")]
		SinglePassInstanced,
		[Token(Token = "0x40001FB")]
		SinglePassMultiview
	}

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Camera m_Camera;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	internal PropertySheet uberSheet;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	internal Texture autoExposureTexture;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	internal LogHistogram logHistogram;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	internal Texture logLut;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	internal AutoExposure autoExposure;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	internal int bloomBufferNameID;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	internal bool physicalCamera;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private RenderTextureDescriptor m_sourceDescriptor;

	[Token(Token = "0x1700000F")]
	public Camera camera
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2B56068", Offset = "0x2B52068", VA = "0x2B56068")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2B4E804", Offset = "0x2B4A804", VA = "0x2B4E804")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public CommandBuffer command
	{
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2B56070", Offset = "0x2B52070", VA = "0x2B56070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2B56078", Offset = "0x2B52078", VA = "0x2B56078")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public RenderTargetIdentifier source
	{
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2B56080", Offset = "0x2B52080", VA = "0x2B56080")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2B56094", Offset = "0x2B52094", VA = "0x2B56094")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public RenderTargetIdentifier destination
	{
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2B560A8", Offset = "0x2B520A8", VA = "0x2B560A8")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2B560C0", Offset = "0x2B520C0", VA = "0x2B560C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public RenderTextureFormat sourceFormat
	{
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2B560D8", Offset = "0x2B520D8", VA = "0x2B560D8")]
		[CompilerGenerated]
		get
		{
			return default(RenderTextureFormat);
		}
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2B560E0", Offset = "0x2B520E0", VA = "0x2B560E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public bool flip
	{
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2B560E8", Offset = "0x2B520E8", VA = "0x2B560E8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2B560F0", Offset = "0x2B520F0", VA = "0x2B560F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public PostProcessResources resources
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2B560F8", Offset = "0x2B520F8", VA = "0x2B560F8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2B56100", Offset = "0x2B52100", VA = "0x2B56100")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public PropertySheetFactory propertySheets
	{
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2B56108", Offset = "0x2B52108", VA = "0x2B56108")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2B56110", Offset = "0x2B52110", VA = "0x2B56110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Dictionary<string, object> userData
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2B56118", Offset = "0x2B52118", VA = "0x2B56118")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2B56120", Offset = "0x2B52120", VA = "0x2B56120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public PostProcessDebugLayer debugLayer
	{
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2B56128", Offset = "0x2B52128", VA = "0x2B56128")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2B56130", Offset = "0x2B52130", VA = "0x2B56130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public int width
	{
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2B56138", Offset = "0x2B52138", VA = "0x2B56138")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2B56140", Offset = "0x2B52140", VA = "0x2B56140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public int height
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2B56148", Offset = "0x2B52148", VA = "0x2B56148")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2B56150", Offset = "0x2B52150", VA = "0x2B56150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public bool stereoActive
	{
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2B56158", Offset = "0x2B52158", VA = "0x2B56158")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2B56160", Offset = "0x2B52160", VA = "0x2B56160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public int xrActiveEye
	{
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2B56168", Offset = "0x2B52168", VA = "0x2B56168")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2B56170", Offset = "0x2B52170", VA = "0x2B56170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public int numberOfEyes
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2B56178", Offset = "0x2B52178", VA = "0x2B56178")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2B56180", Offset = "0x2B52180", VA = "0x2B56180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public StereoRenderingMode stereoRenderingMode
	{
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2B56188", Offset = "0x2B52188", VA = "0x2B56188")]
		[CompilerGenerated]
		get
		{
			return default(StereoRenderingMode);
		}
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2B56190", Offset = "0x2B52190", VA = "0x2B56190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public int screenWidth
	{
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2B56198", Offset = "0x2B52198", VA = "0x2B56198")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2B561A0", Offset = "0x2B521A0", VA = "0x2B561A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public int screenHeight
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2B561A8", Offset = "0x2B521A8", VA = "0x2B561A8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2B561B0", Offset = "0x2B521B0", VA = "0x2B561B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public bool isSceneView
	{
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2B561B8", Offset = "0x2B521B8", VA = "0x2B561B8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2B561C0", Offset = "0x2B521C0", VA = "0x2B561C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public PostProcessLayer.Antialiasing antialiasing
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2B561C8", Offset = "0x2B521C8", VA = "0x2B561C8")]
		[CompilerGenerated]
		get
		{
			return default(PostProcessLayer.Antialiasing);
		}
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2B561D0", Offset = "0x2B521D0", VA = "0x2B561D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public TemporalAntialiasing temporalAntialiasing
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2B561D8", Offset = "0x2B521D8", VA = "0x2B561D8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2B561E0", Offset = "0x2B521E0", VA = "0x2B561E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x2B4E688", Offset = "0x2B4A688", VA = "0x2B4E688")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x2B4D8E0", Offset = "0x2B498E0", VA = "0x2B4D8E0")]
	public bool IsTemporalAntialiasingActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x2B561E8", Offset = "0x2B521E8", VA = "0x2B561E8")]
	public bool IsDebugOverlayEnabled(DebugOverlay overlay)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x2B56208", Offset = "0x2B52208", VA = "0x2B56208")]
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x2B56240", Offset = "0x2B52240", VA = "0x2B56240")]
	internal RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
	{
		return default(RenderTextureDescriptor);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x2B4E594", Offset = "0x2B4A594", VA = "0x2B4E594")]
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x2B56414", Offset = "0x2B52414", VA = "0x2B56414")]
	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, int widthOverride = 0, int heightOverride = 0)
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x2B4EB84", Offset = "0x2B4AB84", VA = "0x2B4EB84")]
	public void UpdateSinglePassStereoState(bool isTAAEnabled, bool isAOEnabled, bool isSSREnabled)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x2B4C6C0", Offset = "0x2B486C0", VA = "0x2B4C6C0")]
	public PostProcessRenderContext()
	{
	}
}
[Token(Token = "0x2000075")]
public sealed class PostProcessResources : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000076")]
	public sealed class Shaders
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Shader bloom;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader copy;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader copyStd;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader copyStdFromTexArray;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader copyStdFromDoubleWide;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader discardAlpha;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader depthOfField;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader finalPass;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader grainBaker;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader motionBlur;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader temporalAntialiasing;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader subpixelMorphologicalAntialiasing;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader texture2dLerp;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader uber;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader lut2DBaker;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader lightMeter;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Shader gammaHistogram;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader waveform;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Shader vectorscope;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader debugOverlays;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader deferredFog;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Shader scalableAO;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader multiScaleAO;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader screenSpaceReflections;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2B56494", Offset = "0x2B52494", VA = "0x2B56494")]
		public Shaders Clone()
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2B564F8", Offset = "0x2B524F8", VA = "0x2B564F8")]
		public Shaders()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000077")]
	public sealed class ComputeShaders
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ComputeShader autoExposure;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ComputeShader exposureHistogram;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ComputeShader lut3DBaker;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ComputeShader texture3dLerp;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ComputeShader gammaHistogram;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ComputeShader waveform;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ComputeShader vectorscope;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ComputeShader multiScaleAODownsample1;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ComputeShader multiScaleAODownsample2;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ComputeShader multiScaleAORender;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ComputeShader multiScaleAOUpsample;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ComputeShader gaussianDownsample;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2B56500", Offset = "0x2B52500", VA = "0x2B56500")]
		public ComputeShaders Clone()
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2B56564", Offset = "0x2B52564", VA = "0x2B56564")]
		public ComputeShaders()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000078")]
	public sealed class SMAALuts
	{
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D area;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D search;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2B5656C", Offset = "0x2B5256C", VA = "0x2B5656C")]
		public SMAALuts()
		{
		}
	}

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D[] blueNoise64;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D[] blueNoise256;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SMAALuts smaaLuts;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Shaders shaders;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ComputeShaders computeShaders;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x2B5648C", Offset = "0x2B5248C", VA = "0x2B5648C")]
	public PostProcessResources()
	{
	}
}
[Token(Token = "0x2000079")]
[ExecuteAlways]
[AddComponentMenu("Rendering/Post-process Volume", 1001)]
public sealed class PostProcessVolume : MonoBehaviour
{
	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PostProcessProfile sharedProfile;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Check this box to mark this volume as global. This volume's Profile will be applied to the whole Scene.")]
	public bool isGlobal;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The distance (from the attached Collider) to start blending from. A value of 0 means there will be no blending and the Volume overrides will be applied immediatly upon entry to the attached Collider.")]
	[Min(0f)]
	public float blendDistance;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The total weight of this Volume in the Scene. A value of 0 signifies that it will have no effect, 1 signifies full effect.")]
	[Range(0f, 1f)]
	public float weight;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("The volume priority in the stack. A higher value means higher priority. Negative values are supported.")]
	public float priority;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_PreviousLayer;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_PreviousPriority;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Collider> m_TempColliders;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private PostProcessProfile m_InternalProfile;

	[Token(Token = "0x17000024")]
	public PostProcessProfile profile
	{
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2B54AF8", Offset = "0x2B50AF8", VA = "0x2B54AF8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2B56574", Offset = "0x2B52574", VA = "0x2B56574")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	internal PostProcessProfile profileRef
	{
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2B546D0", Offset = "0x2B506D0", VA = "0x2B546D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000026")]
	internal int previousLayer
	{
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2B565DC", Offset = "0x2B525DC", VA = "0x2B565DC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x2B5657C", Offset = "0x2B5257C", VA = "0x2B5657C")]
	public bool HasInstantiatedProfile()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x2B565E4", Offset = "0x2B525E4", VA = "0x2B565E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x2B56684", Offset = "0x2B52684", VA = "0x2B56684")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2B566A4", Offset = "0x2B526A4", VA = "0x2B566A4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x2B56728", Offset = "0x2B52728", VA = "0x2B56728")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x2B56EAC", Offset = "0x2B52EAC", VA = "0x2B56EAC")]
	public PostProcessVolume()
	{
	}
}
[Token(Token = "0x200007A")]
public static class ColorUtilities
{
	[Token(Token = "0x4000230")]
	private const float logC_cut = 0.011361f;

	[Token(Token = "0x4000231")]
	private const float logC_a = 5.555556f;

	[Token(Token = "0x4000232")]
	private const float logC_b = 0.047996f;

	[Token(Token = "0x4000233")]
	private const float logC_c = 0.244161f;

	[Token(Token = "0x4000234")]
	private const float logC_d = 0.386036f;

	[Token(Token = "0x4000235")]
	private const float logC_e = 5.301883f;

	[Token(Token = "0x4000236")]
	private const float logC_f = 0.092819f;

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x2B56EBC", Offset = "0x2B52EBC", VA = "0x2B56EBC")]
	public static float StandardIlluminantY(float x)
	{
		return default(float);
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x2B56EE8", Offset = "0x2B52EE8", VA = "0x2B56EE8")]
	public static Vector3 CIExyToLMS(float x, float y)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x2B56F78", Offset = "0x2B52F78", VA = "0x2B56F78")]
	public static Vector3 ComputeColorBalance(float temperature, float tint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x2B5707C", Offset = "0x2B5307C", VA = "0x2B5707C")]
	public static Vector3 ColorToLift(Vector4 color)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x2B570C4", Offset = "0x2B530C4", VA = "0x2B570C4")]
	public static Vector3 ColorToInverseGamma(Vector4 color)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x2B57134", Offset = "0x2B53134", VA = "0x2B57134")]
	public static Vector3 ColorToGain(Vector4 color)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x2B57184", Offset = "0x2B53184", VA = "0x2B57184")]
	public static float LogCToLinear(float x)
	{
		return default(float);
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x2B571F4", Offset = "0x2B531F4", VA = "0x2B571F4")]
	public static float LinearToLogC(float x)
	{
		return default(float);
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x2B57260", Offset = "0x2B53260", VA = "0x2B57260")]
	public static uint ToHex(Color c)
	{
		return default(uint);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x2B572D0", Offset = "0x2B532D0", VA = "0x2B572D0")]
	public static Color ToRGBA(uint hex)
	{
		return default(Color);
	}
}
[Token(Token = "0x200007B")]
public class HableCurve
{
	[Token(Token = "0x200007C")]
	private class Segment
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float offsetX;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float offsetY;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float scaleX;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scaleY;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float lnA;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float B;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2B57558", Offset = "0x2B53558", VA = "0x2B57558")]
		public float Eval(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2B57478", Offset = "0x2B53478", VA = "0x2B57478")]
		public Segment()
		{
		}
	}

	[Token(Token = "0x200007D")]
	private struct DirectParams
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal float x0;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal float y0;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float x1;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float y1;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float W;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float overshootX;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal float overshootY;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal float gamma;
	}

	[Token(Token = "0x200007E")]
	public class Uniforms
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HableCurve parent;

		[Token(Token = "0x1700002B")]
		public Vector4 curve
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x2B57AB8", Offset = "0x2B53AB8", VA = "0x2B57AB8")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700002C")]
		public Vector4 toeSegmentA
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x2B57AD8", Offset = "0x2B53AD8", VA = "0x2B57AD8")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector4 toeSegmentB
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x2B57B14", Offset = "0x2B53B14", VA = "0x2B57B14")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700002E")]
		public Vector4 midSegmentA
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x2B57B54", Offset = "0x2B53B54", VA = "0x2B57B54")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700002F")]
		public Vector4 midSegmentB
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x2B57B94", Offset = "0x2B53B94", VA = "0x2B57B94")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000030")]
		public Vector4 shoSegmentA
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x2B57BD8", Offset = "0x2B53BD8", VA = "0x2B57BD8")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000031")]
		public Vector4 shoSegmentB
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x2B57C18", Offset = "0x2B53C18", VA = "0x2B57C18")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2B57480", Offset = "0x2B53480", VA = "0x2B57480")]
		internal Uniforms(HableCurve parent)
		{
		}
	}

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Segment[] m_Segments;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly Uniforms uniforms;

	[Token(Token = "0x17000027")]
	public float whitePoint
	{
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2B5731C", Offset = "0x2B5331C", VA = "0x2B5731C")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2B57324", Offset = "0x2B53324", VA = "0x2B57324")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public float inverseWhitePoint
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2B5732C", Offset = "0x2B5332C", VA = "0x2B5732C")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2B57334", Offset = "0x2B53334", VA = "0x2B57334")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000029")]
	internal float x0
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2B5733C", Offset = "0x2B5333C", VA = "0x2B5733C")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2B57344", Offset = "0x2B53344", VA = "0x2B57344")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	internal float x1
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2B5734C", Offset = "0x2B5334C", VA = "0x2B5734C")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2B57354", Offset = "0x2B53354", VA = "0x2B57354")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x2B5735C", Offset = "0x2B5335C", VA = "0x2B5735C")]
	public HableCurve()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x2B574A8", Offset = "0x2B534A8", VA = "0x2B574A8")]
	public float Eval(float x)
	{
		return default(float);
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2B575B8", Offset = "0x2B535B8", VA = "0x2B575B8")]
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x2B57740", Offset = "0x2B53740", VA = "0x2B57740")]
	private void InitSegments(DirectParams srcParams)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2B57A68", Offset = "0x2B53A68", VA = "0x2B57A68")]
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x2B57A00", Offset = "0x2B53A00", VA = "0x2B57A00")]
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x2B57A2C", Offset = "0x2B53A2C", VA = "0x2B57A2C")]
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x)
	{
		return default(float);
	}
}
[Token(Token = "0x200007F")]
public static class HaltonSeq
{
	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x2B57C5C", Offset = "0x2B53C5C", VA = "0x2B57C5C")]
	public static float Get(int index, int radix)
	{
		return default(float);
	}
}
[Token(Token = "0x2000080")]
internal sealed class LogHistogram
{
	[Token(Token = "0x400024C")]
	public const int rangeMin = -9;

	[Token(Token = "0x400024D")]
	public const int rangeMax = 9;

	[Token(Token = "0x400024E")]
	private const int k_Bins = 128;

	[Token(Token = "0x17000032")]
	public ComputeBuffer data
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2B57CA0", Offset = "0x2B53CA0", VA = "0x2B57CA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2B57CA8", Offset = "0x2B53CA8", VA = "0x2B57CA8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x2B52A6C", Offset = "0x2B4EA6C", VA = "0x2B52A6C")]
	public void Generate(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x2B475C0", Offset = "0x2B435C0", VA = "0x2B475C0")]
	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x2B4D2B0", Offset = "0x2B492B0", VA = "0x2B4D2B0")]
	public void Release()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x2B4C3EC", Offset = "0x2B483EC", VA = "0x2B4C3EC")]
	public LogHistogram()
	{
	}
}
[Token(Token = "0x2000081")]
internal static class MeshUtilities
{
	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<PrimitiveType, Mesh> s_Primitives;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives;

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x2B57CB0", Offset = "0x2B53CB0", VA = "0x2B57CB0")]
	static MeshUtilities()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x2B57E74", Offset = "0x2B53E74", VA = "0x2B57E74")]
	internal static Mesh GetColliderMesh(Collider collider)
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x2B57FC8", Offset = "0x2B53FC8", VA = "0x2B57FC8")]
	internal static Mesh GetPrimitive(PrimitiveType primitiveType)
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x2B580B4", Offset = "0x2B540B4", VA = "0x2B580B4")]
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType)
	{
		return null;
	}
}
[Token(Token = "0x2000082")]
internal static class PostProcessEffectRendererExtensions
{
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x2B4EE70", Offset = "0x2B4AE70", VA = "0x2B4EE70")]
	public static Exception RenderOrLog(this PostProcessEffectRenderer self, PostProcessRenderContext context)
	{
		return null;
	}
}
[Token(Token = "0x2000083")]
public sealed class PropertySheet
{
	[Token(Token = "0x17000033")]
	public MaterialPropertyBlock properties
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2B58158", Offset = "0x2B54158", VA = "0x2B58158")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2B58160", Offset = "0x2B54160", VA = "0x2B58160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000034")]
	internal Material material
	{
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2B58168", Offset = "0x2B54168", VA = "0x2B58168")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2B58170", Offset = "0x2B54170", VA = "0x2B58170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x2B58178", Offset = "0x2B54178", VA = "0x2B58178")]
	internal PropertySheet(Material material)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x2B475A4", Offset = "0x2B435A4", VA = "0x2B475A4")]
	public void ClearKeywords()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x2B475E8", Offset = "0x2B435E8", VA = "0x2B475E8")]
	public void EnableKeyword(string keyword)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x2B581EC", Offset = "0x2B541EC", VA = "0x2B581EC")]
	public void DisableKeyword(string keyword)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x2B58204", Offset = "0x2B54204", VA = "0x2B58204")]
	internal void Release()
	{
	}
}
[Token(Token = "0x2000084")]
public sealed class PropertySheetFactory
{
	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly Dictionary<Shader, PropertySheet> m_Sheets;

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x2B4C3F4", Offset = "0x2B483F4", VA = "0x2B4C3F4")]
	public PropertySheetFactory()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x2B58264", Offset = "0x2B54264", VA = "0x2B58264")]
	[Obsolete("Use PropertySheet.Get(Shader) with a direct reference to the Shader instead.")]
	public PropertySheet Get(string shaderName)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x2B46DFC", Offset = "0x2B42DFC", VA = "0x2B46DFC")]
	public PropertySheet Get(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x2B4D2D4", Offset = "0x2B492D4", VA = "0x2B4D2D4")]
	public void Release()
	{
	}
}
[Token(Token = "0x2000085")]
public static class RuntimeUtilities
{
	[Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class <GetAllSceneObjects>d__86<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : Component
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T <>2__current;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>l__initialThreadId;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<Transform> <queue>5__2;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject[] <>7__wrap2;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>7__wrap3;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerator <>7__wrap4;

		[Token(Token = "0x1700004B")]
		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x6000246")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000248")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000242")]
		[DebuggerHidden]
		public <GetAllSceneObjects>d__86(int <>1__state)
		{
		}

		[Token(Token = "0x6000243")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000244")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000247")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000249")]
		[DebuggerHidden]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Texture2D m_WhiteTexture;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Texture3D m_WhiteTexture3D;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Texture2D m_BlackTexture;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Texture3D m_BlackTexture3D;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Texture2D m_TransparentTexture;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static Texture3D m_TransparentTexture3D;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Dictionary<int, Texture2D> m_LutStrips;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static PostProcessResources s_Resources;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Mesh s_FullscreenTriangle;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Material s_CopyStdMaterial;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static Material s_CopyStdFromDoubleWideMaterial;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static Material s_CopyMaterial;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Material s_CopyFromTexArrayMaterial;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static PropertySheet s_CopySheet;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static PropertySheet s_CopyFromTexArraySheet;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static IEnumerable<Type> m_AssemblyTypes;

	[Token(Token = "0x17000035")]
	public static Texture2D whiteTexture
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2B527F4", Offset = "0x2B4E7F4", VA = "0x2B527F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000036")]
	public static Texture3D whiteTexture3D
	{
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2B58344", Offset = "0x2B54344", VA = "0x2B58344")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000037")]
	public static Texture2D blackTexture
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2B584D8", Offset = "0x2B544D8", VA = "0x2B584D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000038")]
	public static Texture3D blackTexture3D
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2B58644", Offset = "0x2B54644", VA = "0x2B58644")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000039")]
	public static Texture2D transparentTexture
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2B587DC", Offset = "0x2B547DC", VA = "0x2B587DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003A")]
	public static Texture3D transparentTexture3D
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2B58948", Offset = "0x2B54948", VA = "0x2B58948")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003B")]
	public static Mesh fullscreenTriangle
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2B58AD8", Offset = "0x2B54AD8", VA = "0x2B58AD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003C")]
	public static Material copyStdMaterial
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2B4EC60", Offset = "0x2B4AC60", VA = "0x2B4EC60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003D")]
	public static Material copyStdFromDoubleWideMaterial
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2B51334", Offset = "0x2B4D334", VA = "0x2B51334")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	public static Material copyMaterial
	{
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2B58E3C", Offset = "0x2B54E3C", VA = "0x2B58E3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003F")]
	public static Material copyFromTexArrayMaterial
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2B58F90", Offset = "0x2B54F90", VA = "0x2B58F90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000040")]
	public static PropertySheet copySheet
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2B515B0", Offset = "0x2B4D5B0", VA = "0x2B515B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public static PropertySheet copyFromTexArraySheet
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2B510AC", Offset = "0x2B4D0AC", VA = "0x2B510AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000042")]
	public static bool scriptableRenderPipelineActive
	{
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2B4C474", Offset = "0x2B48474", VA = "0x2B4C474")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000043")]
	public static bool supportsDeferredShading
	{
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2B599D8", Offset = "0x2B559D8", VA = "0x2B599D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000044")]
	public static bool supportsDepthNormals
	{
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2B59A48", Offset = "0x2B55A48", VA = "0x2B59A48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000045")]
	public static bool isSinglePassStereoEnabled
	{
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2B4FAD0", Offset = "0x2B4BAD0", VA = "0x2B4FAD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000046")]
	public static bool isVREnabled
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2B59AB8", Offset = "0x2B55AB8", VA = "0x2B59AB8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000047")]
	public static bool isAndroidOpenGL
	{
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2B476E4", Offset = "0x2B436E4", VA = "0x2B476E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000048")]
	public static bool isWebNonWebGPU
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2B47758", Offset = "0x2B43758", VA = "0x2B47758")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000049")]
	public static RenderTextureFormat defaultHDRRenderTextureFormat
	{
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2B4E664", Offset = "0x2B4A664", VA = "0x2B4E664")]
		get
		{
			return default(RenderTextureFormat);
		}
	}

	[Token(Token = "0x1700004A")]
	public static bool isLinearColorSpace
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2B46DE0", Offset = "0x2B42DE0", VA = "0x2B46DE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x2B49290", Offset = "0x2B45290", VA = "0x2B49290")]
	public static Texture2D GetLutStrip(int size)
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x2B50490", Offset = "0x2B4C490", VA = "0x2B50490")]
	internal static bool isValidResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x2B5051C", Offset = "0x2B4C51C", VA = "0x2B5051C")]
	internal static void UpdateResources(PostProcessResources resources)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x2B590E4", Offset = "0x2B550E4", VA = "0x2B590E4")]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x2B5911C", Offset = "0x2B5511C", VA = "0x2B5911C")]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x2B59154", Offset = "0x2B55154", VA = "0x2B59154")]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x2B48654", Offset = "0x2B44654", VA = "0x2B48654")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, [Optional] Rect? viewport, bool preserveDepth = false)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x2B591A0", Offset = "0x2B551A0", VA = "0x2B591A0")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, [Optional] Rect? viewport, bool preserveDepth = false)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x2B47008", Offset = "0x2B43008", VA = "0x2B47008")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport, bool preserveDepth = false)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x2B51488", Offset = "0x2B4D488", VA = "0x2B51488")]
	public static void BlitFullscreenTriangleFromDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x2B52FE0", Offset = "0x2B4EFE0", VA = "0x2B52FE0")]
	public static void BlitFullscreenTriangleToDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2B5116C", Offset = "0x2B4D16C", VA = "0x2B5116C")]
	public static void BlitFullscreenTriangleFromTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x2B52E20", Offset = "0x2B4EE20", VA = "0x2B52E20")]
	public static void BlitFullscreenTriangleToTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x2B593D4", Offset = "0x2B553D4", VA = "0x2B593D4")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x2B5964C", Offset = "0x2B5564C", VA = "0x2B5964C")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x2B59830", Offset = "0x2B55830", VA = "0x2B59830")]
	public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x2B4EDB4", Offset = "0x2B4ADB4", VA = "0x2B4EDB4")]
	public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x2B598D4", Offset = "0x2B558D4", VA = "0x2B598D4")]
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x2B4E66C", Offset = "0x2B4A66C", VA = "0x2B4E66C")]
	public static bool isFloatingPointFormat(RenderTextureFormat format)
	{
		return default(bool);
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x2B5296C", Offset = "0x2B4E96C", VA = "0x2B5296C")]
	internal static bool hasAlpha(RenderTextureFormat format)
	{
		return default(bool);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x2B477BC", Offset = "0x2B437BC", VA = "0x2B477BC")]
	public static void Destroy(Object obj)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x2B59AC0", Offset = "0x2B55AC0", VA = "0x2B59AC0")]
	public static bool IsResolvedDepthAvailable(Camera camera)
	{
		return default(bool);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x2B59B28", Offset = "0x2B55B28", VA = "0x2B59B28")]
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x2B59CA8", Offset = "0x2B55CA8", VA = "0x2B59CA8")]
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x2B59D8C", Offset = "0x2B55D8C", VA = "0x2B59D8C")]
	public static bool IsPostProcessingActive(PostProcessLayer layer)
	{
		return default(bool);
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x2B59E10", Offset = "0x2B55E10", VA = "0x2B59E10")]
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer)
	{
		return default(bool);
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x2B4C764", Offset = "0x2B48764", VA = "0x2B4C764")]
	public static bool IsDynamicResolutionEnabled(Camera camera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000230")]
	[IteratorStateMachine(typeof(<GetAllSceneObjects>d__86<>))]
	public static IEnumerable<T> GetAllSceneObjects<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000231")]
	public static void CreateIfNull<T>(ref T obj) where T : class, new()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x2B47600", Offset = "0x2B43600", VA = "0x2B47600")]
	public static float Exp2(float x)
	{
		return default(float);
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x2B59E9C", Offset = "0x2B55E9C", VA = "0x2B59E9C")]
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x2B59FD8", Offset = "0x2B55FD8", VA = "0x2B59FD8")]
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x2B5A0B4", Offset = "0x2B560B4", VA = "0x2B5A0B4")]
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x2B5A19C", Offset = "0x2B5619C", VA = "0x2B5A19C")]
	public static IEnumerable<Type> GetAllAssemblyTypes()
	{
		return null;
	}

	[Token(Token = "0x6000237")]
	public static IEnumerable<Type> GetAllTypesDerivedFrom<T>()
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	public static T GetAttribute<T>(this Type type) where T : Attribute
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}
}
[Token(Token = "0x2000089")]
internal static class ShaderIDs
{
	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly int MainTex;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	internal static readonly int Jitter;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	internal static readonly int Sharpness;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	internal static readonly int FinalBlendParameters;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal static readonly int HistoryTex;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	internal static readonly int SMAA_Flip;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal static readonly int SMAA_Flop;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	internal static readonly int AOParams;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal static readonly int AOColor;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	internal static readonly int OcclusionTexture1;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal static readonly int OcclusionTexture2;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	internal static readonly int SAOcclusionTexture;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal static readonly int MSVOcclusionTexture;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	internal static readonly int DepthCopy;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal static readonly int LinearDepth;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	internal static readonly int LowDepth1;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	internal static readonly int LowDepth2;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	internal static readonly int LowDepth3;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	internal static readonly int LowDepth4;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	internal static readonly int TiledDepth1;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	internal static readonly int TiledDepth2;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	internal static readonly int TiledDepth3;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	internal static readonly int TiledDepth4;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal static readonly int Occlusion1;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	internal static readonly int Occlusion2;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	internal static readonly int Occlusion3;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	internal static readonly int Occlusion4;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	internal static readonly int Combined1;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	internal static readonly int Combined2;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	internal static readonly int Combined3;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	internal static readonly int SSRResolveTemp;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	internal static readonly int Noise;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	internal static readonly int Test;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	internal static readonly int Resolve;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	internal static readonly int History;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	internal static readonly int ViewMatrix;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	internal static readonly int InverseViewMatrix;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	internal static readonly int ScreenSpaceProjectionMatrix;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	internal static readonly int Params2;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	internal static readonly int FogColor;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	internal static readonly int FogParams;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	internal static readonly int VelocityScale;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	internal static readonly int MaxBlurRadius;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	internal static readonly int RcpMaxBlurRadius;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	internal static readonly int VelocityTex;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	internal static readonly int Tile2RT;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	internal static readonly int Tile4RT;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	internal static readonly int Tile8RT;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	internal static readonly int TileMaxOffs;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	internal static readonly int TileMaxLoop;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	internal static readonly int TileVRT;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	internal static readonly int NeighborMaxTex;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	internal static readonly int LoopCount;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	internal static readonly int DepthOfFieldTemp;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	internal static readonly int DepthOfFieldTex;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	internal static readonly int Distance;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	internal static readonly int LensCoeff;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	internal static readonly int MaxCoC;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	internal static readonly int RcpMaxCoC;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	internal static readonly int RcpAspect;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	internal static readonly int CoCTex;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	internal static readonly int TaaParams;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	internal static readonly int AutoExposureTex;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	internal static readonly int HistogramBuffer;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	internal static readonly int Params;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	internal static readonly int ScaleOffsetRes;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	internal static readonly int BloomTex;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	internal static readonly int SampleScale;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	internal static readonly int Threshold;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	internal static readonly int ColorIntensity;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	internal static readonly int Bloom_DirtTex;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	internal static readonly int Bloom_Settings;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	internal static readonly int Bloom_Color;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	internal static readonly int Bloom_DirtTileOffset;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	internal static readonly int ChromaticAberration_Amount;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	internal static readonly int ChromaticAberration_SpectralLut;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	internal static readonly int Distortion_CenterScale;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	internal static readonly int Distortion_Amount;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	internal static readonly int Lut2D;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	internal static readonly int Lut3D;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	internal static readonly int Lut3D_Params;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	internal static readonly int Lut2D_Params;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	internal static readonly int UserLut2D_Params;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	internal static readonly int PostExposure;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	internal static readonly int ColorBalance;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	internal static readonly int ColorFilter;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	internal static readonly int HueSatCon;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	internal static readonly int Brightness;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	internal static readonly int ChannelMixerRed;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	internal static readonly int ChannelMixerGreen;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	internal static readonly int ChannelMixerBlue;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	internal static readonly int Lift;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	internal static readonly int InvGamma;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	internal static readonly int Gain;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	internal static readonly int Curves;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	internal static readonly int CustomToneCurve;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	internal static readonly int ToeSegmentA;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	internal static readonly int ToeSegmentB;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	internal static readonly int MidSegmentA;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	internal static readonly int MidSegmentB;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal static readonly int ShoSegmentA;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	internal static readonly int ShoSegmentB;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal static readonly int Vignette_Color;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	internal static readonly int Vignette_Center;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal static readonly int Vignette_Settings;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	internal static readonly int Vignette_Mask;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal static readonly int Vignette_Opacity;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	internal static readonly int Vignette_Mode;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal static readonly int Grain_Params1;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	internal static readonly int Grain_Params2;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal static readonly int GrainTex;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	internal static readonly int Phase;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal static readonly int GrainNoiseParameters;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	internal static readonly int LumaInAlpha;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal static readonly int DitheringTex;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal static readonly int Dithering_Coords;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	internal static readonly int From;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	internal static readonly int To;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	internal static readonly int Interp;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	internal static readonly int TargetColor;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	internal static readonly int HalfResFinalCopy;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	internal static readonly int WaveformSource;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	internal static readonly int WaveformBuffer;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	internal static readonly int VectorscopeBuffer;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	internal static readonly int RenderViewportScaleFactor;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	internal static readonly int UVTransform;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	internal static readonly int DepthSlice;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	internal static readonly int UVScaleOffset;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	internal static readonly int PosScaleOffset;
}
[Serializable]
[Token(Token = "0x200008A")]
public sealed class Spline
{
	[Token(Token = "0x40002F1")]
	public const int k_Precision = 128;

	[Token(Token = "0x40002F2")]
	public const float k_Step = 1f / 128f;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AnimationCurve curve;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_Loop;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_ZeroValue;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_Range;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AnimationCurve m_InternalLoopingCurve;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int frameCount;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] cachedData;

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x2B5BD84", Offset = "0x2B57D84", VA = "0x2B5BD84")]
	public Spline(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x2B5BE70", Offset = "0x2B57E70", VA = "0x2B5BE70")]
	public void Cache(int frame)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x2B5C080", Offset = "0x2B58080", VA = "0x2B5C080")]
	public float Evaluate(float t, int length)
	{
		return default(float);
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x2B5C0C4", Offset = "0x2B580C4", VA = "0x2B5C0C4")]
	public float Evaluate(float t)
	{
		return default(float);
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x2B5C100", Offset = "0x2B58100", VA = "0x2B5C100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200008B")]
internal class TargetPool
{
	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly List<int> m_Pool;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int m_Current;

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x2B5C128", Offset = "0x2B58128", VA = "0x2B5C128")]
	internal TargetPool()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x2B5C1C0", Offset = "0x2B581C0", VA = "0x2B5C1C0")]
	internal int Get()
	{
		return default(int);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x2B5C1E4", Offset = "0x2B581E4", VA = "0x2B5C1E4")]
	private int Get(int i)
	{
		return default(int);
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x2B5C344", Offset = "0x2B58344", VA = "0x2B5C344")]
	internal void Reset()
	{
	}
}
[Token(Token = "0x200008C")]
public static class TextureFormatUtilities
{
	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<int, bool> s_SupportedRenderTextureFormats;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Dictionary<int, bool> s_SupportedTextureFormats;

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x2B5C34C", Offset = "0x2B5834C", VA = "0x2B5C34C")]
	static TextureFormatUtilities()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x2B5CE48", Offset = "0x2B58E48", VA = "0x2B5CE48")]
	private static bool IsObsolete(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x2B5CF64", Offset = "0x2B58F64", VA = "0x2B5CF64")]
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture)
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x2B5D0D4", Offset = "0x2B590D4", VA = "0x2B5D0D4")]
	internal static bool IsSupported(this RenderTextureFormat format)
	{
		return default(bool);
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x2B5D16C", Offset = "0x2B5916C", VA = "0x2B5D16C")]
	internal static bool IsSupported(this TextureFormat format)
	{
		return default(bool);
	}
}
[Token(Token = "0x200008D")]
internal class TextureLerper
{
	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static TextureLerper m_Instance;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private CommandBuffer m_Command;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PropertySheetFactory m_PropertySheets;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PostProcessResources m_Resources;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<RenderTexture> m_Recycled;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<RenderTexture> m_Actives;

	[Token(Token = "0x1700004D")]
	internal static TextureLerper instance
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2B5D204", Offset = "0x2B59204", VA = "0x2B5D204")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x2B5D278", Offset = "0x2B59278", VA = "0x2B5D278")]
	private TextureLerper()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x2B5D310", Offset = "0x2B59310", VA = "0x2B5D310")]
	internal void BeginFrame(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x2B5D334", Offset = "0x2B59334", VA = "0x2B5D334")]
	internal void EndFrame()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x2B5D53C", Offset = "0x2B5953C", VA = "0x2B5D53C")]
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false)
	{
		return null;
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x2B5D830", Offset = "0x2B59830", VA = "0x2B5D830")]
	internal Texture Lerp(Texture from, Texture to, float t)
	{
		return null;
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x2B5DEE8", Offset = "0x2B59EE8", VA = "0x2B5DEE8")]
	internal Texture Lerp(Texture from, Color to, float t)
	{
		return null;
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x2B5E4C4", Offset = "0x2B5A4C4", VA = "0x2B5E4C4")]
	internal void Clear()
	{
	}
}
