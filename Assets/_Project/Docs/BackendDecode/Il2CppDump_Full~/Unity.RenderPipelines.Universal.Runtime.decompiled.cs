using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.Rendering.Universal.LibTessDotNet;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;
using UnityEngine.U2D;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2CD98F8", Offset = "0x2CD58F8", VA = "0x2CD98F8")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2CD9900", Offset = "0x2CD5900", VA = "0x2CD9900")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Token(Token = "0x2000004")]
public class FullScreenPassRendererFeature : ScriptableRendererFeature, ISerializationCallbackReceiver
{
	[Token(Token = "0x2000005")]
	public enum InjectionPoint
	{
		[Token(Token = "0x400000B")]
		BeforeRenderingTransparents = 450,
		[Token(Token = "0x400000C")]
		BeforeRenderingPostProcessing = 550,
		[Token(Token = "0x400000D")]
		AfterRenderingPostProcessing = 600
	}

	[Token(Token = "0x2000006")]
	internal class FullScreenRenderPass : ScriptableRenderPass
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Material m_Material;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int m_PassIndex;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool m_CopyActiveColor;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		private bool m_BindDepthStencilAttachment;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RTHandle m_CopiedColor;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MaterialPropertyBlock s_SharedPropertyBlock;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2CD9974", Offset = "0x2CD5974", VA = "0x2CD9974")]
		public FullScreenRenderPass(string passName)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2CD9C98", Offset = "0x2CD5C98", VA = "0x2CD9C98")]
		public void SetupMembers(Material material, int passIndex, bool copyActiveColor, bool bindDepthStencilAttachment)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2CD9D3C", Offset = "0x2CD5D3C", VA = "0x2CD9D3C", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2CD9D94", Offset = "0x2CD5D94", VA = "0x2CD9D94")]
		internal void ReAllocate(RenderTextureDescriptor desc)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2CD9CD0", Offset = "0x2CD5CD0", VA = "0x2CD9CD0")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2CD9E40", Offset = "0x2CD5E40", VA = "0x2CD9E40")]
		private static void ExecuteCopyColorPass(CommandBuffer cmd, RTHandle sourceTexture)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2CD9EC0", Offset = "0x2CD5EC0", VA = "0x2CD9EC0")]
		private static void ExecuteMainPass(CommandBuffer cmd, RTHandle sourceTexture, Material material, int passIndex)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2CDA0A0", Offset = "0x2CD60A0", VA = "0x2CDA0A0", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}

	[Token(Token = "0x2000007")]
	private enum Version
	{
		[Token(Token = "0x4000015")]
		Uninitialised = -1,
		[Token(Token = "0x4000016")]
		Initial = 0,
		[Token(Token = "0x4000017")]
		AddFetchColorBufferCheckbox = 1,
		[Token(Token = "0x4000018")]
		Count = 2,
		[Token(Token = "0x4000019")]
		Latest = 1
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public InjectionPoint injectionPoint;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool fetchColorBuffer;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ScriptableRenderPassInput requirements;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material passMaterial;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal bool showAdditionalProperties;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int passIndex;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool bindDepthStencilAttachment;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private FullScreenRenderPass m_FullScreenPass;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[HideInInspector]
	private Version m_Version;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2CD9908", Offset = "0x2CD5908", VA = "0x2CD9908", Slot = "5")]
	public override void Create()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2CD9A0C", Offset = "0x2CD5A0C", VA = "0x2CD9A0C", Slot = "10")]
	internal override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2CD9A20", Offset = "0x2CD5A20", VA = "0x2CD9A20", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2CD9CAC", Offset = "0x2CD5CAC", VA = "0x2CD9CAC", Slot = "11")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2CD9CE4", Offset = "0x2CD5CE4", VA = "0x2CD9CE4")]
	private void UpgradeIfNeeded()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2CD9CE8", Offset = "0x2CD5CE8", VA = "0x2CD9CE8", Slot = "12")]
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2CD9D04", Offset = "0x2CD5D04", VA = "0x2CD9D04", Slot = "13")]
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2CD9D1C", Offset = "0x2CD5D1C", VA = "0x2CD9D1C")]
	public FullScreenPassRendererFeature()
	{
	}
}
[Token(Token = "0x2000008")]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000009")]
	private struct MonoScriptData
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2CDA384", Offset = "0x2CD6384", VA = "0x2CDA384")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2CDA440", Offset = "0x2CD6440", VA = "0x2CDA440")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace UnityEngine.Experimental.Rendering.Universal
{
	[Token(Token = "0x200000A")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2d-pixelperfect.html%23properties")]
	[MovedFrom("UnityEngine.Experimental.Rendering")]
	[AddComponentMenu("Rendering/2D/Pixel Perfect Camera")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PixelPerfectCamera : MonoBehaviour, IPixelPerfectCamera, ISerializationCallbackReceiver
	{
		[Token(Token = "0x200000B")]
		public enum CropFrame
		{
			[Token(Token = "0x4000029")]
			None,
			[Token(Token = "0x400002A")]
			Pillarbox,
			[Token(Token = "0x400002B")]
			Letterbox,
			[Token(Token = "0x400002C")]
			Windowbox,
			[Token(Token = "0x400002D")]
			StretchFill
		}

		[Token(Token = "0x200000C")]
		public enum GridSnapping
		{
			[Token(Token = "0x400002F")]
			None,
			[Token(Token = "0x4000030")]
			PixelSnapping,
			[Token(Token = "0x4000031")]
			UpscaleRenderTexture
		}

		[Token(Token = "0x200000D")]
		public enum PixelPerfectFilterMode
		{
			[Token(Token = "0x4000033")]
			RetroAA,
			[Token(Token = "0x4000034")]
			Point
		}

		[Token(Token = "0x200000E")]
		private enum ComponentVersions
		{
			[Token(Token = "0x4000036")]
			Version_Unserialized,
			[Token(Token = "0x4000037")]
			Version_1
		}

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_AssetsPPU;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int m_RefResolutionX;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_RefResolutionY;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private CropFrame m_CropFrame;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridSnapping m_GridSnapping;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private PixelPerfectFilterMode m_FilterMode;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera m_Camera;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PixelPerfectCameraInternal m_Internal;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_CinemachineCompatibilityMode;

		[Token(Token = "0x17000001")]
		public CropFrame cropFrame
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2CDA448", Offset = "0x2CD6448", VA = "0x2CDA448")]
			get
			{
				return default(CropFrame);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2CDA450", Offset = "0x2CD6450", VA = "0x2CDA450")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public GridSnapping gridSnapping
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2CDA458", Offset = "0x2CD6458", VA = "0x2CDA458")]
			get
			{
				return default(GridSnapping);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2CDA460", Offset = "0x2CD6460", VA = "0x2CDA460")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float orthographicSize
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2CDA468", Offset = "0x2CD6468", VA = "0x2CDA468")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000004")]
		public int assetsPPU
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2CDA480", Offset = "0x2CD6480", VA = "0x2CDA480", Slot = "4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2CDA488", Offset = "0x2CD6488", VA = "0x2CDA488", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public int refResolutionX
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x2CDA4A4", Offset = "0x2CD64A4", VA = "0x2CDA4A4", Slot = "6")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2CDA4AC", Offset = "0x2CD64AC", VA = "0x2CDA4AC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int refResolutionY
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x2CDA4C8", Offset = "0x2CD64C8", VA = "0x2CDA4C8", Slot = "8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2CDA4D0", Offset = "0x2CD64D0", VA = "0x2CDA4D0", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		[Obsolete("Use gridSnapping instead", false)]
		public bool upscaleRT
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2CDA4EC", Offset = "0x2CD64EC", VA = "0x2CDA4EC", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2CDA4FC", Offset = "0x2CD64FC", VA = "0x2CDA4FC", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		[Obsolete("Use gridSnapping instead", false)]
		public bool pixelSnapping
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2CDA51C", Offset = "0x2CD651C", VA = "0x2CDA51C", Slot = "12")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2CDA52C", Offset = "0x2CD652C", VA = "0x2CDA52C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		[Obsolete("Use cropFrame instead", false)]
		public bool cropFrameX
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2CDA544", Offset = "0x2CD6544", VA = "0x2CDA544", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2CDA560", Offset = "0x2CD6560", VA = "0x2CDA560", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		[Obsolete("Use cropFrame instead", false)]
		public bool cropFrameY
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2CDA5AC", Offset = "0x2CD65AC", VA = "0x2CDA5AC", Slot = "16")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2CDA5C0", Offset = "0x2CD65C0", VA = "0x2CDA5C0", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		[Obsolete("Use cropFrame instead", false)]
		public bool stretchFill
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2CDA604", Offset = "0x2CD6604", VA = "0x2CDA604", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2CDA614", Offset = "0x2CD6614", VA = "0x2CDA614", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public int pixelRatio
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2CDA628", Offset = "0x2CD6628", VA = "0x2CDA628")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000D")]
		public bool requiresUpscalePass
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2CDA67C", Offset = "0x2CD667C", VA = "0x2CDA67C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		internal FilterMode finalBlitFilterMode
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2CDA86C", Offset = "0x2CD686C", VA = "0x2CDA86C")]
			get
			{
				return default(FilterMode);
			}
		}

		[Token(Token = "0x1700000F")]
		internal Vector2Int offscreenRTSize
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2CDA87C", Offset = "0x2CD687C", VA = "0x2CDA87C")]
			get
			{
				return default(Vector2Int);
			}
		}

		[Token(Token = "0x17000010")]
		private Vector2Int cameraRTSize
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2CDA894", Offset = "0x2CD6894", VA = "0x2CDA894")]
			get
			{
				return default(Vector2Int);
			}
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2CDA694", Offset = "0x2CD6694", VA = "0x2CDA694")]
		public Vector3 RoundToPixel(Vector3 position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2CDA84C", Offset = "0x2CD684C", VA = "0x2CDA84C")]
		public float CorrectCinemachineOrthoSize(float targetOrthoSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2CDA95C", Offset = "0x2CD695C", VA = "0x2CDA95C")]
		private void PixelSnap()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2CDABC4", Offset = "0x2CD6BC4", VA = "0x2CDABC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2CDAC54", Offset = "0x2CD6C54", VA = "0x2CDAC54")]
		private void UpdateCameraProperties()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2CDACF0", Offset = "0x2CD6CF0", VA = "0x2CDACF0")]
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2CDADBC", Offset = "0x2CD6DBC", VA = "0x2CDADBC")]
		private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2CDAE48", Offset = "0x2CD6E48", VA = "0x2CDAE48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2CDAF2C", Offset = "0x2CD6F2C", VA = "0x2CDAF2C")]
		internal void OnDisable()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2CDB040", Offset = "0x2CD7040", VA = "0x2CDB040", Slot = "20")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2CDB044", Offset = "0x2CD7044", VA = "0x2CDB044", Slot = "21")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2CDB048", Offset = "0x2CD7048", VA = "0x2CDB048")]
		public PixelPerfectCamera()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class RenderObjectsPass : ScriptableRenderPass
	{
		[Token(Token = "0x2000010")]
		private class PassData
		{
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal RenderObjectsPass pass;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal RenderingData renderingData;

			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2CDC150", Offset = "0x2CD8150", VA = "0x2CDC150")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderQueueType renderQueueType;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderObjects.CustomCameraSettings m_CameraSettings;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string m_ProfilerTag;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<ShaderTagId> m_ShaderTagIdList;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private RenderStateBlock m_RenderStateBlock;

		[Token(Token = "0x17000011")]
		public Material overrideMaterial
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2CDB064", Offset = "0x2CD7064", VA = "0x2CDB064")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2CDB06C", Offset = "0x2CD706C", VA = "0x2CDB06C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public int overrideMaterialPassIndex
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2CDB074", Offset = "0x2CD7074", VA = "0x2CDB074")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2CDB07C", Offset = "0x2CD707C", VA = "0x2CDB07C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Shader overrideShader
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2CDB084", Offset = "0x2CD7084", VA = "0x2CDB084")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2CDB08C", Offset = "0x2CD708C", VA = "0x2CDB08C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public int overrideShaderPassIndex
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2CDB094", Offset = "0x2CD7094", VA = "0x2CDB094")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2CDB09C", Offset = "0x2CD709C", VA = "0x2CDB09C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2CDB0A4", Offset = "0x2CD70A4", VA = "0x2CDB0A4")]
		public void SetDetphState(bool writeEnabled, CompareFunction function = CompareFunction.Less)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2CDB114", Offset = "0x2CD7114", VA = "0x2CDB114")]
		public void SetStencilState(int reference, CompareFunction compareFunction, StencilOp passOp, StencilOp failOp, StencilOp zFailOp)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2CDB1FC", Offset = "0x2CD71FC", VA = "0x2CDB1FC")]
		public RenderObjectsPass(string profilerTag, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2CDB688", Offset = "0x2CD7688", VA = "0x2CDB688")]
		internal RenderObjectsPass(URPProfileId profileId, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2CDB770", Offset = "0x2CD7770", VA = "0x2CDB770", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2CDBE84", Offset = "0x2CD7E84", VA = "0x2CDBE84", Slot = "10")]
		internal override void RecordRenderGraph(RenderGraph renderGraph, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public enum RenderQueueType
	{
		[Token(Token = "0x4000049")]
		Opaque,
		[Token(Token = "0x400004A")]
		Transparent
	}
	[Token(Token = "0x2000013")]
	[Tooltip("Render Objects simplifies the injection of additional render passes by exposing a selection of commonly used settings.")]
	[ExcludeFromPreset]
	public class RenderObjects : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x2000014")]
		public class RenderObjectsSettings
		{
			[Token(Token = "0x2000015")]
			public enum OverrideMaterialMode
			{
				[Token(Token = "0x400005B")]
				None,
				[Token(Token = "0x400005C")]
				Material,
				[Token(Token = "0x400005D")]
				Shader
			}

			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string passTag;

			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RenderPassEvent Event;

			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FilterSettings filterSettings;

			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material overrideMaterial;

			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int overrideMaterialPassIndex;

			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Shader overrideShader;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int overrideShaderPassIndex;

			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public OverrideMaterialMode overrideMode;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool overrideDepthState;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public CompareFunction depthCompareFunction;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool enableWrite;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public StencilStateData stencilSettings;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public CustomCameraSettings cameraSettings;

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2CDC51C", Offset = "0x2CD851C", VA = "0x2CDC51C")]
			public RenderObjectsSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000016")]
		public class FilterSettings
		{
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderQueueType RenderQueueType;

			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public LayerMask LayerMask;

			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] PassNames;

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2CDC63C", Offset = "0x2CD863C", VA = "0x2CDC63C")]
			public FilterSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000017")]
		public class CustomCameraSettings
		{
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool overrideCamera;

			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool restoreCamera;

			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector4 offset;

			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float cameraFieldOfView;

			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2CDC668", Offset = "0x2CD8668", VA = "0x2CDC668")]
			public CustomCameraSettings()
			{
			}
		}

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RenderObjectsSettings settings;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderObjectsPass renderObjectsPass;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2CDC284", Offset = "0x2CD8284", VA = "0x2CDC284", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2CDC418", Offset = "0x2CD8418", VA = "0x2CDC418", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2CDC4B8", Offset = "0x2CD84B8", VA = "0x2CDC4B8", Slot = "9")]
		internal override bool SupportsNativeRenderPass()
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2CDC4C0", Offset = "0x2CD84C0", VA = "0x2CDC4C0")]
		public RenderObjects()
		{
		}
	}
}
namespace UnityEngine.Rendering.Universal
{
	[Token(Token = "0x2000018")]
	[AddComponentMenu("")]
	[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
	public class CinemachineUniversalPixelPerfect : MonoBehaviour
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2CDC680", Offset = "0x2CD8680", VA = "0x2CDC680")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2CDC6E8", Offset = "0x2CD86E8", VA = "0x2CDC6E8")]
		public CinemachineUniversalPixelPerfect()
		{
		}
	}
	[Token(Token = "0x2000019")]
	internal struct DoublePoint
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double X;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double Y;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2CDC6F0", Offset = "0x2CD86F0", VA = "0x2CDC6F0")]
		public DoublePoint(double x = 0.0, double y = 0.0)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2CDC6F8", Offset = "0x2CD86F8", VA = "0x2CDC6F8")]
		public DoublePoint(DoublePoint dp)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2CDC700", Offset = "0x2CD8700", VA = "0x2CDC700")]
		public DoublePoint(IntPoint ip)
		{
		}
	}
	[Token(Token = "0x200001A")]
	internal class PolyTree : PolyNode
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal List<PolyNode> m_AllPolys;

		[Token(Token = "0x17000015")]
		public int Total
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2CDC874", Offset = "0x2CD8874", VA = "0x2CDC874")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2CDC710", Offset = "0x2CD8710", VA = "0x2CDC710")]
		public void Clear()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2CDC7F8", Offset = "0x2CD87F8", VA = "0x2CDC7F8")]
		public PolyNode GetFirst()
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2CDC918", Offset = "0x2CD8918", VA = "0x2CDC918")]
		public PolyTree()
		{
		}
	}
	[Token(Token = "0x200001B")]
	internal class PolyNode
	{
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal PolyNode m_Parent;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal List<IntPoint> m_polygon;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int m_Index;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal JoinType m_jointype;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal EndType m_endtype;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal List<PolyNode> m_Childs;

		[Token(Token = "0x17000016")]
		public int ChildCount
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x2CDCA70", Offset = "0x2CD8A70", VA = "0x2CDCA70")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000017")]
		public List<IntPoint> Contour
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x2CDCAB8", Offset = "0x2CD8AB8", VA = "0x2CDCAB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public List<PolyNode> Childs
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x2CDCC94", Offset = "0x2CD8C94", VA = "0x2CDCC94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public PolyNode Parent
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x2CDCC9C", Offset = "0x2CD8C9C", VA = "0x2CDCC9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public bool IsHole
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x2CDCCA4", Offset = "0x2CD8CA4", VA = "0x2CDCCA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public bool IsOpen
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x2CDCCC0", Offset = "0x2CD8CC0", VA = "0x2CDCCC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x2CDCCC8", Offset = "0x2CD8CC8", VA = "0x2CDCCC8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2CDCA54", Offset = "0x2CD8A54", VA = "0x2CDCA54")]
		private bool IsHoleNode()
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2CDCAC0", Offset = "0x2CD8AC0", VA = "0x2CDCAC0")]
		internal void AddChild(PolyNode Child)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2CDCB78", Offset = "0x2CD8B78", VA = "0x2CDCB78")]
		public PolyNode GetNext()
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2CDCBF4", Offset = "0x2CD8BF4", VA = "0x2CDCBF4")]
		internal PolyNode GetNextSiblingUp()
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2CDC990", Offset = "0x2CD8990", VA = "0x2CDC990")]
		public PolyNode()
		{
		}
	}
	[Token(Token = "0x200001C")]
	internal struct Int128
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private long hi;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private ulong lo;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2CDCCD0", Offset = "0x2CD8CD0", VA = "0x2CDCCD0")]
		public Int128(long _lo)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2CDCCDC", Offset = "0x2CD8CDC", VA = "0x2CDCCDC")]
		public Int128(long _hi, ulong _lo)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2CDCCE4", Offset = "0x2CD8CE4", VA = "0x2CDCCE4")]
		public Int128(Int128 val)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2CDCCEC", Offset = "0x2CD8CEC", VA = "0x2CDCCEC")]
		public bool IsNegative()
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2CDCCF8", Offset = "0x2CD8CF8", VA = "0x2CDCCF8")]
		public static bool operator ==(Int128 val1, Int128 val2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2CDCD9C", Offset = "0x2CD8D9C", VA = "0x2CDCD9C")]
		public static bool operator !=(Int128 val1, Int128 val2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2CDCDB4", Offset = "0x2CD8DB4", VA = "0x2CDCDB4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2CDCE3C", Offset = "0x2CD8E3C", VA = "0x2CDCE3C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2CDCE70", Offset = "0x2CD8E70", VA = "0x2CDCE70")]
		public static bool operator >(Int128 val1, Int128 val2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2CDCE88", Offset = "0x2CD8E88", VA = "0x2CDCE88")]
		public static bool operator <(Int128 val1, Int128 val2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2CDCEA0", Offset = "0x2CD8EA0", VA = "0x2CDCEA0")]
		public static Int128 operator +(Int128 lhs, Int128 rhs)
		{
			return default(Int128);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2CDCEAC", Offset = "0x2CD8EAC", VA = "0x2CDCEAC")]
		public static Int128 operator -(Int128 lhs, Int128 rhs)
		{
			return default(Int128);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2CDCED0", Offset = "0x2CD8ED0", VA = "0x2CDCED0")]
		public static Int128 operator -(Int128 val)
		{
			return default(Int128);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2CDCEE4", Offset = "0x2CD8EE4", VA = "0x2CDCEE4")]
		public static explicit operator double(Int128 val)
		{
			return default(double);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2CDCF44", Offset = "0x2CD8F44", VA = "0x2CDCF44")]
		public static Int128 Int128Mul(long lhs, long rhs)
		{
			return default(Int128);
		}
	}
	[Token(Token = "0x200001D")]
	internal struct IntPoint
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long N;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long X;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long Y;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long D;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double NX;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double NY;

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2CDCFB0", Offset = "0x2CD8FB0", VA = "0x2CDCFB0")]
		public IntPoint(long X, long Y)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2CDCFC4", Offset = "0x2CD8FC4", VA = "0x2CDCFC4")]
		public IntPoint(double x, double y)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2CDCFFC", Offset = "0x2CD8FFC", VA = "0x2CDCFFC")]
		public IntPoint(IntPoint pt)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2CDD030", Offset = "0x2CD9030", VA = "0x2CDD030")]
		public static bool operator ==(IntPoint a, IntPoint b)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2CDD05C", Offset = "0x2CD905C", VA = "0x2CDD05C")]
		public static bool operator !=(IntPoint a, IntPoint b)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2CDD088", Offset = "0x2CD9088", VA = "0x2CDD088", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2CDD110", Offset = "0x2CD9110", VA = "0x2CDD110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200001E")]
	internal struct IntRect
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long left;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long top;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long right;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long bottom;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2CDD17C", Offset = "0x2CD917C", VA = "0x2CDD17C")]
		public IntRect(long l, long t, long r, long b)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2CDD188", Offset = "0x2CD9188", VA = "0x2CDD188")]
		public IntRect(IntRect ir)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public enum ClipType
	{
		[Token(Token = "0x400007C")]
		ctIntersection,
		[Token(Token = "0x400007D")]
		ctUnion,
		[Token(Token = "0x400007E")]
		ctDifference,
		[Token(Token = "0x400007F")]
		ctXor
	}
	[Token(Token = "0x2000020")]
	public enum PolyType
	{
		[Token(Token = "0x4000081")]
		ptSubject,
		[Token(Token = "0x4000082")]
		ptClip
	}
	[Token(Token = "0x2000021")]
	public enum PolyFillType
	{
		[Token(Token = "0x4000084")]
		pftEvenOdd,
		[Token(Token = "0x4000085")]
		pftNonZero,
		[Token(Token = "0x4000086")]
		pftPositive,
		[Token(Token = "0x4000087")]
		pftNegative
	}
	[Token(Token = "0x2000022")]
	public enum JoinType
	{
		[Token(Token = "0x4000089")]
		jtRound
	}
	[Token(Token = "0x2000023")]
	public enum EndType
	{
		[Token(Token = "0x400008B")]
		etClosedPolygon,
		[Token(Token = "0x400008C")]
		etClosedLine
	}
	[Token(Token = "0x2000024")]
	internal enum EdgeSide
	{
		[Token(Token = "0x400008E")]
		esLeft,
		[Token(Token = "0x400008F")]
		esRight
	}
	[Token(Token = "0x2000025")]
	internal enum Direction
	{
		[Token(Token = "0x4000091")]
		dRightToLeft,
		[Token(Token = "0x4000092")]
		dLeftToRight
	}
	[Token(Token = "0x2000026")]
	internal class TEdge
	{
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPoint Bot;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal IntPoint Curr;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal IntPoint Top;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal IntPoint Delta;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal double Dx;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal PolyType PolyTyp;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		internal EdgeSide Side;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal int WindDelta;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		internal int WindCnt;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal int WindCnt2;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		internal int OutIdx;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal TEdge Next;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal TEdge Prev;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal TEdge NextInLML;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal TEdge NextInAEL;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		internal TEdge PrevInAEL;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal TEdge NextInSEL;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal TEdge PrevInSEL;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2CDD1AC", Offset = "0x2CD91AC", VA = "0x2CDD1AC")]
		public TEdge()
		{
		}
	}
	[Token(Token = "0x2000027")]
	internal class IntersectNode
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal TEdge Edge1;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal TEdge Edge2;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal IntPoint Pt;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2CDD1B4", Offset = "0x2CD91B4", VA = "0x2CDD1B4")]
		public IntersectNode()
		{
		}
	}
	[Token(Token = "0x2000028")]
	internal class MyIntersectNodeSort : IComparer<IntersectNode>
	{
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2CDD1BC", Offset = "0x2CD91BC", VA = "0x2CDD1BC", Slot = "4")]
		public int Compare(IntersectNode node1, IntersectNode node2)
		{
			return default(int);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2CDD1EC", Offset = "0x2CD91EC", VA = "0x2CDD1EC")]
		public MyIntersectNodeSort()
		{
		}
	}
	[Token(Token = "0x2000029")]
	internal class LocalMinima
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal long Y;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal TEdge LeftBound;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal TEdge RightBound;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LocalMinima Next;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2CDD1F4", Offset = "0x2CD91F4", VA = "0x2CDD1F4")]
		public LocalMinima()
		{
		}
	}
	[Token(Token = "0x200002A")]
	internal class Scanbeam
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal long Y;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Scanbeam Next;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2CDD1FC", Offset = "0x2CD91FC", VA = "0x2CDD1FC")]
		public Scanbeam()
		{
		}
	}
	[Token(Token = "0x200002B")]
	internal class Maxima
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal long X;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Maxima Next;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Maxima Prev;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2CDD204", Offset = "0x2CD9204", VA = "0x2CDD204")]
		public Maxima()
		{
		}
	}
	[Token(Token = "0x200002C")]
	internal class OutRec
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int Idx;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool IsHole;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		internal bool IsOpen;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal OutRec FirstLeft;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal OutPt Pts;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal OutPt BottomPt;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal PolyNode PolyNode;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2CDD20C", Offset = "0x2CD920C", VA = "0x2CDD20C")]
		public OutRec()
		{
		}
	}
	[Token(Token = "0x200002D")]
	internal class OutPt
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int Idx;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal IntPoint Pt;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal OutPt Next;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal OutPt Prev;

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2CDD214", Offset = "0x2CD9214", VA = "0x2CDD214")]
		public OutPt()
		{
		}
	}
	[Token(Token = "0x200002E")]
	internal class Join
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal OutPt OutPt1;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal OutPt OutPt2;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal IntPoint OffPt;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2CDD21C", Offset = "0x2CD921C", VA = "0x2CDD21C")]
		public Join()
		{
		}
	}
	[Token(Token = "0x200002F")]
	internal class ClipperBase
	{
		[Token(Token = "0x40000BF")]
		internal const double horizontal = -3.4E+38;

		[Token(Token = "0x40000C0")]
		internal const int Skip = -2;

		[Token(Token = "0x40000C1")]
		internal const int Unassigned = -1;

		[Token(Token = "0x40000C2")]
		internal const double tolerance = 1E-20;

		[Token(Token = "0x40000C3")]
		public const long loRange = 1073741823L;

		[Token(Token = "0x40000C4")]
		public const long hiRange = 4611686018427387903L;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal LocalMinima m_MinimaList;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal LocalMinima m_CurrentLM;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal List<List<TEdge>> m_edges;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Scanbeam m_Scanbeam;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal List<OutRec> m_PolyOuts;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal TEdge m_ActiveEdges;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool m_UseFullRange;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		internal bool m_HasOpenPaths;

		[Token(Token = "0x1700001C")]
		public bool PreserveCollinear
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x2CDD23C", Offset = "0x2CD923C", VA = "0x2CDD23C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x2CDD244", Offset = "0x2CD9244", VA = "0x2CDD244")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2CDD224", Offset = "0x2CD9224", VA = "0x2CDD224")]
		internal static bool near_zero(double val)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2CDD24C", Offset = "0x2CD924C", VA = "0x2CDD24C")]
		public void Swap(ref long val1, ref long val2)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2CDD260", Offset = "0x2CD9260", VA = "0x2CDD260")]
		internal static bool IsHorizontal(TEdge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2CDD27C", Offset = "0x2CD927C", VA = "0x2CDD27C")]
		internal bool PointIsVertex(IntPoint pt, OutPt pp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2CDD2CC", Offset = "0x2CD92CC", VA = "0x2CDD2CC")]
		internal bool PointOnLineSegment(IntPoint pt, IntPoint linePt1, IntPoint linePt2, bool UseFullRange)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2CDD434", Offset = "0x2CD9434", VA = "0x2CDD434")]
		internal bool PointOnPolygon(IntPoint pt, OutPt pp, bool UseFullRange)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2CDD4D4", Offset = "0x2CD94D4", VA = "0x2CDD4D4")]
		internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2CDD560", Offset = "0x2CD9560", VA = "0x2CDD560")]
		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2CDD610", Offset = "0x2CD9610", VA = "0x2CDD610")]
		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2CDD6DC", Offset = "0x2CD96DC", VA = "0x2CDD6DC")]
		internal ClipperBase()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2CDD764", Offset = "0x2CD9764", VA = "0x2CDD764", Slot = "4")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2CDD8E0", Offset = "0x2CD98E0", VA = "0x2CDD8E0")]
		private void DisposeLocalMinimaList()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2CDD8F4", Offset = "0x2CD98F4", VA = "0x2CDD8F4")]
		private void RangeTest(IntPoint Pt, ref bool useFullRange)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2CDD9F8", Offset = "0x2CD99F8", VA = "0x2CDD9F8")]
		private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2CDDA24", Offset = "0x2CD9A24", VA = "0x2CDDA24")]
		private void InitEdge2(TEdge e, PolyType polyType)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2CDDAE4", Offset = "0x2CD9AE4", VA = "0x2CDDAE4")]
		private TEdge FindNextLocMin(TEdge E)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2CDDBD0", Offset = "0x2CD9BD0", VA = "0x2CDDBD0")]
		private TEdge ProcessBound(TEdge E, bool LeftBoundIsForward)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2CDE048", Offset = "0x2CDA048", VA = "0x2CDE048")]
		public bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2CDEBE8", Offset = "0x2CDABE8", VA = "0x2CDEBE8")]
		public bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2CDEB6C", Offset = "0x2CDAB6C", VA = "0x2CDEB6C")]
		internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2CDEB3C", Offset = "0x2CDAB3C", VA = "0x2CDEB3C")]
		private TEdge RemoveEdge(TEdge e)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2CDDAA0", Offset = "0x2CD9AA0", VA = "0x2CDDAA0")]
		private void SetDx(TEdge e)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2CDDFD8", Offset = "0x2CD9FD8", VA = "0x2CDDFD8")]
		private void InsertLocalMinima(LocalMinima newLm)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2CDECB0", Offset = "0x2CDACB0", VA = "0x2CDECB0")]
		internal bool PopLocalMinima(long Y, out LocalMinima current)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2CDE028", Offset = "0x2CDA028", VA = "0x2CDE028")]
		private void ReverseHorizontal(TEdge e)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2CDECE0", Offset = "0x2CDACE0", VA = "0x2CDECE0", Slot = "5")]
		internal virtual void Reset()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2CDEE5C", Offset = "0x2CDAE5C", VA = "0x2CDEE5C")]
		public static IntRect GetBounds(List<List<IntPoint>> paths)
		{
			return default(IntRect);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2CDED5C", Offset = "0x2CDAD5C", VA = "0x2CDED5C")]
		internal void InsertScanbeam(long Y)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2CDF160", Offset = "0x2CDB160", VA = "0x2CDF160")]
		internal bool PopScanbeam(out long Y)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2CDF188", Offset = "0x2CDB188", VA = "0x2CDF188")]
		internal bool LocalMinimaPending()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2CDF198", Offset = "0x2CDB198", VA = "0x2CDF198")]
		internal OutRec CreateOutRec()
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2CDF29C", Offset = "0x2CDB29C", VA = "0x2CDF29C")]
		internal void DisposeOutRec(int index)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2CDF32C", Offset = "0x2CDB32C", VA = "0x2CDF32C")]
		internal void UpdateEdgeIntoAEL(ref TEdge e)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2CDF428", Offset = "0x2CDB428", VA = "0x2CDF428")]
		internal void SwapPositionsInAEL(TEdge edge1, TEdge edge2)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2CDF4FC", Offset = "0x2CDB4FC", VA = "0x2CDF4FC")]
		internal void DeleteFromAEL(TEdge e)
		{
		}
	}
	[Token(Token = "0x2000030")]
	internal class Clipper : ClipperBase
	{
		[Token(Token = "0x2000031")]
		internal enum NodeType
		{
			[Token(Token = "0x40000E0")]
			ntAny,
			[Token(Token = "0x40000E1")]
			ntOpen,
			[Token(Token = "0x40000E2")]
			ntClosed
		}

		[Token(Token = "0x40000CE")]
		public const int ioReverseSolution = 1;

		[Token(Token = "0x40000CF")]
		public const int ioStrictlySimple = 2;

		[Token(Token = "0x40000D0")]
		public const int ioPreserveCollinear = 4;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private ClipType m_ClipType;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Maxima m_Maxima;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TEdge m_SortedEdges;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<IntersectNode> m_IntersectList;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IComparer<IntersectNode> m_IntersectNodeComparer;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_ExecuteLocked;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private PolyFillType m_ClipFillType;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private PolyFillType m_SubjFillType;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<Join> m_Joins;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<Join> m_GhostJoins;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_UsingPolyTree;

		[Token(Token = "0x1700001D")]
		public int LastIndex
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2CDF7A4", Offset = "0x2CDB7A4", VA = "0x2CDF7A4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2CDF7AC", Offset = "0x2CDB7AC", VA = "0x2CDF7AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool ReverseSolution
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x2CDF7B4", Offset = "0x2CDB7B4", VA = "0x2CDF7B4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x2CDF7BC", Offset = "0x2CDB7BC", VA = "0x2CDF7BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool StrictlySimple
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x2CDF7C4", Offset = "0x2CDB7C4", VA = "0x2CDF7C4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x2CDF7CC", Offset = "0x2CDB7CC", VA = "0x2CDF7CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2CDF548", Offset = "0x2CDB548", VA = "0x2CDF548")]
		public Clipper(int InitOptions = 0)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2CDF6D0", Offset = "0x2CDB6D0", VA = "0x2CDF6D0")]
		private void InsertMaxima(long X)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2CDF7D4", Offset = "0x2CDB7D4", VA = "0x2CDF7D4")]
		public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType FillType = PolyFillType.pftEvenOdd)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2CDF984", Offset = "0x2CDB984", VA = "0x2CDF984")]
		public bool Execute(ClipType clipType, PolyTree polytree, PolyFillType FillType = PolyFillType.pftEvenOdd)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2CDF7DC", Offset = "0x2CDB7DC", VA = "0x2CDF7DC")]
		public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType subjFillType, PolyFillType clipFillType)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2CDF98C", Offset = "0x2CDB98C", VA = "0x2CDF98C")]
		public bool Execute(ClipType clipType, PolyTree polytree, PolyFillType subjFillType, PolyFillType clipFillType)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2CE04E4", Offset = "0x2CDC4E4", VA = "0x2CE04E4")]
		internal void FixHoleLinkage(OutRec outRec)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2CDFA78", Offset = "0x2CDBA78", VA = "0x2CDFA78")]
		private bool ExecuteInternal()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2CE1810", Offset = "0x2CDD810", VA = "0x2CE1810")]
		private void DisposeAllPolyPts()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2CE18B4", Offset = "0x2CDD8B4", VA = "0x2CE18B4")]
		private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2CE19B8", Offset = "0x2CDD9B8", VA = "0x2CE19B8")]
		private void AddGhostJoin(OutPt Op, IntPoint OffPt)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2CE0538", Offset = "0x2CDC538", VA = "0x2CE0538")]
		private void InsertLocalMinimaIntoAEL(long botY)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2CE1AAC", Offset = "0x2CDDAAC", VA = "0x2CE1AAC")]
		private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2CE2974", Offset = "0x2CDE974", VA = "0x2CE2974")]
		private bool E2InsertsBeforeE1(TEdge e1, TEdge e2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2CE2A4C", Offset = "0x2CDEA4C", VA = "0x2CE2A4C")]
		private bool IsEvenOddFillType(TEdge edge)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2CE2A7C", Offset = "0x2CDEA7C", VA = "0x2CE2A7C")]
		private bool IsEvenOddAltFillType(TEdge edge)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2CE1D9C", Offset = "0x2CDDD9C", VA = "0x2CE1D9C")]
		private bool IsContributing(TEdge edge)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2CE1B4C", Offset = "0x2CDDB4C", VA = "0x2CE1B4C")]
		private void SetWindingCount(TEdge edge)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2CE22DC", Offset = "0x2CDE2DC", VA = "0x2CE22DC")]
		private void AddEdgeToSEL(TEdge edge)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2CE2AAC", Offset = "0x2CDEAAC", VA = "0x2CE2AAC")]
		internal bool PopEdgeFromSEL(out TEdge e)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2CE2AD8", Offset = "0x2CDEAD8", VA = "0x2CE2AD8")]
		private void CopyAELToSEL()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2CE2AF8", Offset = "0x2CDEAF8", VA = "0x2CE2AF8")]
		private void SwapPositionsInSEL(TEdge edge1, TEdge edge2)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2CE2BE0", Offset = "0x2CDEBE0", VA = "0x2CE2BE0")]
		private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2CE20E0", Offset = "0x2CDE0E0", VA = "0x2CE20E0")]
		private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2CE1F10", Offset = "0x2CDDF10", VA = "0x2CE1F10")]
		private OutPt AddOutPt(TEdge e, IntPoint pt)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2CE2FCC", Offset = "0x2CDEFCC", VA = "0x2CE2FCC")]
		private OutPt GetLastOutPt(TEdge e)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2CE3054", Offset = "0x2CDF054", VA = "0x2CE3054")]
		internal void SwapPoints(ref IntPoint pt1, ref IntPoint pt2)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2CE2314", Offset = "0x2CDE314", VA = "0x2CE2314")]
		private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2CE2EF0", Offset = "0x2CDEEF0", VA = "0x2CE2EF0")]
		private void SetHoleState(TEdge e, OutRec outRec)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2CE3078", Offset = "0x2CDF078", VA = "0x2CE3078")]
		private double GetDx(IntPoint pt1, IntPoint pt2)
		{
			return default(double);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2CE30B0", Offset = "0x2CDF0B0", VA = "0x2CE30B0")]
		private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2CE33D4", Offset = "0x2CDF3D4", VA = "0x2CE33D4")]
		private OutPt GetBottomPt(OutPt pp)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2CE34DC", Offset = "0x2CDF4DC", VA = "0x2CE34DC")]
		private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2CE35AC", Offset = "0x2CDF5AC", VA = "0x2CE35AC")]
		private bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2CE35D8", Offset = "0x2CDF5D8", VA = "0x2CE35D8")]
		private OutRec GetOutRec(int idx)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2CE2CAC", Offset = "0x2CDECAC", VA = "0x2CE2CAC")]
		private void AppendPolygon(TEdge e1, TEdge e2)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2CE1014", Offset = "0x2CDD014", VA = "0x2CE1014")]
		private void ReversePolyPtLinks(OutPt pp)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2CE3678", Offset = "0x2CDF678", VA = "0x2CE3678")]
		private static void SwapSides(TEdge edge1, TEdge edge2)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2CE36A0", Offset = "0x2CDF6A0", VA = "0x2CE36A0")]
		private static void SwapPolyIndexes(TEdge edge1, TEdge edge2)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2CE233C", Offset = "0x2CDE33C", VA = "0x2CE233C")]
		private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2CE36C8", Offset = "0x2CDF6C8", VA = "0x2CE36C8")]
		private void DeleteFromSEL(TEdge e)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2CE09DC", Offset = "0x2CDC9DC", VA = "0x2CE09DC")]
		private void ProcessHorizontals()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2CE3DD8", Offset = "0x2CDFDD8", VA = "0x2CE3DD8")]
		private void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2CE3714", Offset = "0x2CDF714", VA = "0x2CE3714")]
		private void ProcessHorizontal(TEdge horzEdge)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2CE3E88", Offset = "0x2CDFE88", VA = "0x2CE3E88")]
		private TEdge GetNextInAEL(TEdge e, Direction Direction)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2CE3EB8", Offset = "0x2CDFEB8", VA = "0x2CE3EB8")]
		private bool IsMinima(TEdge e)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2CE3EFC", Offset = "0x2CDFEFC", VA = "0x2CE3EFC")]
		private bool IsMaxima(TEdge e, double Y)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2CE3F28", Offset = "0x2CDFF28", VA = "0x2CE3F28")]
		private bool IsIntermediate(TEdge e, double Y)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2CE3E14", Offset = "0x2CDFE14", VA = "0x2CE3E14")]
		internal TEdge GetMaximaPair(TEdge e)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2CE3F5C", Offset = "0x2CDFF5C", VA = "0x2CE3F5C")]
		internal TEdge GetMaximaPairEx(TEdge e)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2CE0A18", Offset = "0x2CDCA18", VA = "0x2CE0A18")]
		private bool ProcessIntersections(long topY)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2CE3F9C", Offset = "0x2CDFF9C", VA = "0x2CE3F9C")]
		private void BuildIntersectList(long topY)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2CE47E0", Offset = "0x2CE07E0", VA = "0x2CE47E0")]
		private bool EdgesAdjacent(IntersectNode inode)
		{
			return default(bool);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2CE4820", Offset = "0x2CE0820", VA = "0x2CE4820")]
		private static int IntersectNodeSort(IntersectNode node1, IntersectNode node2)
		{
			return default(int);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2CE416C", Offset = "0x2CE016C", VA = "0x2CE416C")]
		private bool FixupIntersectionOrder()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2CE437C", Offset = "0x2CE037C", VA = "0x2CE437C")]
		private void ProcessIntersectList()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2CE4844", Offset = "0x2CE0844", VA = "0x2CE4844")]
		internal static long Round(double value)
		{
			return default(long);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2CE29E0", Offset = "0x2CDE9E0", VA = "0x2CE29E0")]
		private static long TopX(TEdge edge, long currentY)
		{
			return default(long);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2CE4480", Offset = "0x2CE0480", VA = "0x2CE4480")]
		private void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2CE0B90", Offset = "0x2CDCB90", VA = "0x2CE0B90")]
		private void ProcessEdgesAtTopOfScanbeam(long topY)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2CE4874", Offset = "0x2CE0874", VA = "0x2CE4874")]
		private void DoMaxima(TEdge e)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2CE4A54", Offset = "0x2CE0A54", VA = "0x2CE4A54")]
		public static void ReversePaths(List<List<IntPoint>> polys)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2CE4BA0", Offset = "0x2CE0BA0", VA = "0x2CE4BA0")]
		public static bool Orientation(List<IntPoint> poly)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2CE4CE4", Offset = "0x2CE0CE4", VA = "0x2CE4CE4")]
		private int PointCount(OutPt pts)
		{
			return default(int);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2CDFEF8", Offset = "0x2CDBEF8", VA = "0x2CDFEF8")]
		private void BuildResult(List<List<IntPoint>> polyg)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2CE01A0", Offset = "0x2CDC1A0", VA = "0x2CE01A0")]
		private void BuildResult2(PolyTree polytree)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2CE1384", Offset = "0x2CDD384", VA = "0x2CE1384")]
		private void FixupOutPolyline(OutRec outrec)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2CE1424", Offset = "0x2CDD424", VA = "0x2CE1424")]
		private void FixupOutPolygon(OutRec outRec)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2CE4D14", Offset = "0x2CE0D14", VA = "0x2CE4D14")]
		private OutPt DupOutPt(OutPt outPt, bool InsertAfter)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2CE4DD8", Offset = "0x2CE0DD8", VA = "0x2CE4DD8")]
		private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2CE4F10", Offset = "0x2CE0F10", VA = "0x2CE4F10")]
		private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2CE5264", Offset = "0x2CE1264", VA = "0x2CE5264")]
		private bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2CE58B4", Offset = "0x2CE18B4", VA = "0x2CE58B4")]
		public static int PointInPolygon(IntPoint pt, List<IntPoint> path)
		{
			return default(int);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2CE5A70", Offset = "0x2CE1A70", VA = "0x2CE5A70")]
		private static int PointInPolygon(IntPoint pt, OutPt op)
		{
			return default(int);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2CE5B6C", Offset = "0x2CE1B6C", VA = "0x2CE5B6C")]
		private static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2CE5BDC", Offset = "0x2CE1BDC", VA = "0x2CE5BDC")]
		private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2CE5D70", Offset = "0x2CE1D70", VA = "0x2CE5D70")]
		private void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2CE5F60", Offset = "0x2CE1F60", VA = "0x2CE5F60")]
		private void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2CE5D58", Offset = "0x2CE1D58", VA = "0x2CE5D58")]
		private static OutRec ParseFirstLeft(OutRec FirstLeft)
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2CE1048", Offset = "0x2CDD048", VA = "0x2CE1048")]
		private void JoinCommonEdges()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2CE60C0", Offset = "0x2CE20C0", VA = "0x2CE60C0")]
		private void UpdateOutPtIdxs(OutRec outrec)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2CE160C", Offset = "0x2CDD60C", VA = "0x2CE160C")]
		private void DoSimplePolygons()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2CE4BB8", Offset = "0x2CE0BB8", VA = "0x2CE4BB8")]
		public static double Area(List<IntPoint> poly)
		{
			return default(double);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2CE1000", Offset = "0x2CDD000", VA = "0x2CE1000")]
		internal double Area(OutRec outRec)
		{
			return default(double);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2CE3378", Offset = "0x2CDF378", VA = "0x2CE3378")]
		internal double Area(OutPt op)
		{
			return default(double);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2CE60F4", Offset = "0x2CE20F4", VA = "0x2CE60F4")]
		public static List<List<IntPoint>> SimplifyPolygon(List<IntPoint> poly, PolyFillType fillType = PolyFillType.pftEvenOdd)
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2CE61D8", Offset = "0x2CE21D8", VA = "0x2CE61D8")]
		public static List<List<IntPoint>> SimplifyPolygons(List<List<IntPoint>> polys, PolyFillType fillType = PolyFillType.pftEvenOdd)
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2CE62BC", Offset = "0x2CE22BC", VA = "0x2CE62BC")]
		private static double DistanceSqrd(IntPoint pt1, IntPoint pt2)
		{
			return default(double);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2CE62DC", Offset = "0x2CE22DC", VA = "0x2CE62DC")]
		private static double DistanceFromLineSqrd(IntPoint pt, IntPoint ln1, IntPoint ln2)
		{
			return default(double);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2CE633C", Offset = "0x2CE233C", VA = "0x2CE633C")]
		private static bool SlopesNearCollinear(IntPoint pt1, IntPoint pt2, IntPoint pt3, double distSqrd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2CE660C", Offset = "0x2CE260C", VA = "0x2CE660C")]
		private static bool PointsAreClose(IntPoint pt1, IntPoint pt2, double distSqrd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2CE6634", Offset = "0x2CE2634", VA = "0x2CE6634")]
		private static OutPt ExcludeOp(OutPt op)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2CE6668", Offset = "0x2CE2668", VA = "0x2CE6668")]
		public static List<IntPoint> CleanPolygon(List<IntPoint> path, double distance = 1.415)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2CE6A84", Offset = "0x2CE2A84", VA = "0x2CE6A84")]
		public static List<List<IntPoint>> CleanPolygons(List<List<IntPoint>> polys, double distance = 1.415)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2CE6BD8", Offset = "0x2CE2BD8", VA = "0x2CE6BD8")]
		internal static List<List<IntPoint>> Minkowski(List<IntPoint> pattern, List<IntPoint> path, bool IsSum, bool IsClosed)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2CE75C4", Offset = "0x2CE35C4", VA = "0x2CE75C4")]
		public static List<List<IntPoint>> MinkowskiSum(List<IntPoint> pattern, List<IntPoint> path, bool pathIsClosed)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2CE767C", Offset = "0x2CE367C", VA = "0x2CE767C")]
		private static List<IntPoint> TranslatePath(List<IntPoint> path, IntPoint delta)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2CE7834", Offset = "0x2CE3834", VA = "0x2CE7834")]
		public static List<List<IntPoint>> MinkowskiSum(List<IntPoint> pattern, List<List<IntPoint>> paths, bool pathIsClosed)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2CE7A04", Offset = "0x2CE3A04", VA = "0x2CE7A04")]
		public static List<List<IntPoint>> MinkowskiDiff(List<IntPoint> poly1, List<IntPoint> poly2)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2CE7AB8", Offset = "0x2CE3AB8", VA = "0x2CE7AB8")]
		public static List<List<IntPoint>> PolyTreeToPaths(PolyTree polytree)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2CE7B74", Offset = "0x2CE3B74", VA = "0x2CE7B74")]
		internal static void AddPolyNodeToPaths(PolyNode polynode, NodeType nt, List<List<IntPoint>> paths)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2CE7D5C", Offset = "0x2CE3D5C", VA = "0x2CE7D5C")]
		public static List<List<IntPoint>> OpenPathsFromPolyTree(PolyTree polytree)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2CE7EE4", Offset = "0x2CE3EE4", VA = "0x2CE7EE4")]
		public static List<List<IntPoint>> ClosedPathsFromPolyTree(PolyTree polytree)
		{
			return null;
		}
	}
	[Token(Token = "0x2000032")]
	internal class ClipperOffset
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<List<IntPoint>> m_destPolys;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<IntPoint> m_srcPoly;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<IntPoint> m_destPoly;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<DoublePoint> m_normals;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private double m_delta;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double m_sinA;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double m_sin;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private double m_cos;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private double m_StepsPerRad;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IntPoint m_lowest;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PolyNode m_polyNodes;

		[Token(Token = "0x40000EF")]
		private const double two_pi = Math.PI * 2.0;

		[Token(Token = "0x40000F0")]
		private const double def_arc_tolerance = 0.25;

		[Token(Token = "0x17000020")]
		public double ArcTolerance
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2CE7FA0", Offset = "0x2CE3FA0", VA = "0x2CE7FA0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2CE7FA8", Offset = "0x2CE3FA8", VA = "0x2CE7FA8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2CE7FB0", Offset = "0x2CE3FB0", VA = "0x2CE7FB0")]
		public ClipperOffset(double arcTolerance = 0.25)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2CE8074", Offset = "0x2CE4074", VA = "0x2CE8074")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2CE80EC", Offset = "0x2CE40EC", VA = "0x2CE80EC")]
		internal static long Round(double value)
		{
			return default(long);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2CE811C", Offset = "0x2CE411C", VA = "0x2CE811C")]
		public void AddPath(List<IntPoint> path, JoinType joinType, EndType endType)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2CE8690", Offset = "0x2CE4690", VA = "0x2CE8690")]
		public void AddPaths(List<List<IntPoint>> paths, JoinType joinType, EndType endType)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2CE87D8", Offset = "0x2CE47D8", VA = "0x2CE87D8")]
		private void FixOrientations()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2CE8964", Offset = "0x2CE4964", VA = "0x2CE8964")]
		internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2)
		{
			return default(DoublePoint);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2CE8A28", Offset = "0x2CE4A28", VA = "0x2CE8A28")]
		private void DoOffset(double delta)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2CEA53C", Offset = "0x2CE653C", VA = "0x2CEA53C")]
		public void Execute(ref List<List<IntPoint>> solution, double delta, int inputSize)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2CEAA10", Offset = "0x2CE6A10", VA = "0x2CEAA10")]
		public void Execute(ref PolyTree solution, double delta)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2CE97E8", Offset = "0x2CE57E8", VA = "0x2CE97E8")]
		private void OffsetPoint(int j, ref int k, JoinType jointype)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2CEB014", Offset = "0x2CE7014", VA = "0x2CEB014")]
		internal void DoSquare(int j, int k)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2CEB5B8", Offset = "0x2CE75B8", VA = "0x2CEB5B8")]
		internal void DoMiter(int j, int k, double r)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2CEA030", Offset = "0x2CE6030", VA = "0x2CEA030")]
		internal void DoRound(int j, int k)
		{
		}
	}
	[Token(Token = "0x2000033")]
	internal class ClipperException : Exception
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2CEB880", Offset = "0x2CE7880", VA = "0x2CEB880")]
		public ClipperException(string description)
		{
		}
	}
	[Token(Token = "0x2000034")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2DLightProperties.html")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
	[AddComponentMenu("Rendering/2D/Light 2D")]
	public sealed class Light2D : Light2DBase, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000035")]
		public enum DeprecatedLightType
		{
			[Token(Token = "0x4000120")]
			Parametric
		}

		[Token(Token = "0x2000036")]
		public enum LightType
		{
			[Token(Token = "0x4000122")]
			Parametric,
			[Token(Token = "0x4000123")]
			Freeform,
			[Token(Token = "0x4000124")]
			Sprite,
			[Token(Token = "0x4000125")]
			Point,
			[Token(Token = "0x4000126")]
			Global
		}

		[Token(Token = "0x2000037")]
		public enum NormalMapQuality
		{
			[Token(Token = "0x4000128")]
			Disabled = 2,
			[Token(Token = "0x4000129")]
			Fast = 0,
			[Token(Token = "0x400012A")]
			Accurate = 1
		}

		[Token(Token = "0x2000038")]
		public enum OverlapOperation
		{
			[Token(Token = "0x400012C")]
			Additive,
			[Token(Token = "0x400012D")]
			AlphaBlend
		}

		[Token(Token = "0x2000039")]
		private enum ComponentVersions
		{
			[Token(Token = "0x400012F")]
			Version_Unserialized,
			[Token(Token = "0x4000130")]
			Version_1
		}

		[Token(Token = "0x40000F1")]
		private const ComponentVersions k_CurrentComponentVersion = ComponentVersions.Version_1;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ComponentVersions m_ComponentVersion;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[NotKeyable]
		[SerializeField]
		private LightType m_LightType;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("m_LightOperationIndex")]
		private int m_BlendStyleIndex;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_FalloffIntensity;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[ColorUsage(true)]
		private Color m_Color;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_Intensity;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[FormerlySerializedAs("m_LightVolumeOpacity")]
		private float m_LightVolumeIntensity;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_LightVolumeIntensityEnabled;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int[] m_ApplyToSortingLayers;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Reload("Textures/2D/Sparkle.png", ReloadAttribute.Package.Root)]
		private Sprite m_LightCookieSprite;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("m_LightCookieSprite")]
		[SerializeField]
		private Sprite m_DeprecatedPointLightCookieSprite;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int m_LightOrder;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private bool m_AlphaBlendOnOverlap;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OverlapOperation m_OverlapOperation;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[FormerlySerializedAs("m_PointLightDistance")]
		[SerializeField]
		private float m_NormalMapDistance;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[FormerlySerializedAs("m_PointLightQuality")]
		[NotKeyable]
		private NormalMapQuality m_NormalMapQuality;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private bool m_UseNormalMap;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[SerializeField]
		private bool m_ShadowIntensityEnabled;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_ShadowIntensity;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private bool m_ShadowVolumeIntensityEnabled;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_ShadowVolumeIntensity;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Mesh m_Mesh;

		[NonSerialized]
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private LightUtility.LightMeshVertex[] m_Vertices;

		[NonSerialized]
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ushort[] m_Triangles;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int m_PreviousLightCookieSprite;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		internal Vector3 m_CachedPosition;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Bounds m_LocalBounds;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal bool forceUpdate;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private float m_PointLightInnerAngle;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float m_PointLightOuterAngle;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private float m_PointLightInnerRadius;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float m_PointLightOuterRadius;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private int m_ShapeLightParametricSides;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private float m_ShapeLightParametricAngleOffset;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private float m_ShapeLightParametricRadius;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private float m_ShapeLightFalloffSize;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		private Vector2 m_ShapeLightFalloffOffset;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Vector3[] m_ShapePath;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float m_PreviousShapeLightFalloffSize;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int m_PreviousShapeLightParametricSides;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float m_PreviousShapeLightParametricAngleOffset;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float m_PreviousShapeLightParametricRadius;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int m_PreviousShapePathHash;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private LightType m_PreviousLightType;

		[Token(Token = "0x17000021")]
		internal LightUtility.LightMeshVertex[] vertices
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x2CEB8E8", Offset = "0x2CE78E8", VA = "0x2CEB8E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x2CEB8F0", Offset = "0x2CE78F0", VA = "0x2CEB8F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		internal ushort[] indices
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2CEB8F8", Offset = "0x2CE78F8", VA = "0x2CEB8F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x2CEB900", Offset = "0x2CE7900", VA = "0x2CEB900")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		internal int[] affectedSortingLayers
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2CEB908", Offset = "0x2CE7908", VA = "0x2CEB908")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private int lightCookieSpriteInstanceID
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2CEB910", Offset = "0x2CE7910", VA = "0x2CEB910")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		internal BoundingSphere boundingSphere
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2CEB924", Offset = "0x2CE7924", VA = "0x2CEB924")]
			[CompilerGenerated]
			get
			{
				return default(BoundingSphere);
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2CEB930", Offset = "0x2CE7930", VA = "0x2CEB930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		internal Mesh lightMesh
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2CEB93C", Offset = "0x2CE793C", VA = "0x2CEB93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		internal bool hasCachedMesh
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2CEB9DC", Offset = "0x2CE79DC", VA = "0x2CEB9DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public LightType lightType
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2CEBA1C", Offset = "0x2CE7A1C", VA = "0x2CEBA1C")]
			get
			{
				return default(LightType);
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2CEBA24", Offset = "0x2CE7A24", VA = "0x2CEBA24")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public int blendStyleIndex
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2CEBD8C", Offset = "0x2CE7D8C", VA = "0x2CEBD8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2CEBD94", Offset = "0x2CE7D94", VA = "0x2CEBD94")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float shadowIntensity
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2CEBD9C", Offset = "0x2CE7D9C", VA = "0x2CEBD9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x2CEBDA4", Offset = "0x2CE7DA4", VA = "0x2CEBDA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool shadowsEnabled
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2CEBDC4", Offset = "0x2CE7DC4", VA = "0x2CEBDC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2CEBDCC", Offset = "0x2CE7DCC", VA = "0x2CEBDCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public float shadowVolumeIntensity
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2CEBDD4", Offset = "0x2CE7DD4", VA = "0x2CEBDD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2CEBDDC", Offset = "0x2CE7DDC", VA = "0x2CEBDDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool volumetricShadowsEnabled
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x2CEBDFC", Offset = "0x2CE7DFC", VA = "0x2CEBDFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2CEBE04", Offset = "0x2CE7E04", VA = "0x2CEBE04")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Color color
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2CEBE0C", Offset = "0x2CE7E0C", VA = "0x2CEBE0C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2CEBE18", Offset = "0x2CE7E18", VA = "0x2CEBE18")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public float intensity
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2CEBE24", Offset = "0x2CE7E24", VA = "0x2CEBE24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x2CEBE2C", Offset = "0x2CE7E2C", VA = "0x2CEBE2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		[Obsolete]
		public float volumeOpacity
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2CEBE34", Offset = "0x2CE7E34", VA = "0x2CEBE34")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000031")]
		public float volumeIntensity
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2CEBE3C", Offset = "0x2CE7E3C", VA = "0x2CEBE3C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2CEBE44", Offset = "0x2CE7E44", VA = "0x2CEBE44")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool volumeIntensityEnabled
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2CEBE4C", Offset = "0x2CE7E4C", VA = "0x2CEBE4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2CEBE54", Offset = "0x2CE7E54", VA = "0x2CEBE54")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public Sprite lightCookieSprite
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2CEBE5C", Offset = "0x2CE7E5C", VA = "0x2CEBE5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2CEBE78", Offset = "0x2CE7E78", VA = "0x2CEBE78")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public float falloffIntensity
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2CEBE80", Offset = "0x2CE7E80", VA = "0x2CEBE80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2CEBE88", Offset = "0x2CE7E88", VA = "0x2CEBE88")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		[Obsolete]
		public bool alphaBlendOnOverlap
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2CEBEA8", Offset = "0x2CE7EA8", VA = "0x2CEBEA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public OverlapOperation overlapOperation
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2CEBEB8", Offset = "0x2CE7EB8", VA = "0x2CEBEB8")]
			get
			{
				return default(OverlapOperation);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2CEBEC0", Offset = "0x2CE7EC0", VA = "0x2CEBEC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public int lightOrder
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2CEBEC8", Offset = "0x2CE7EC8", VA = "0x2CEBEC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2CEBED0", Offset = "0x2CE7ED0", VA = "0x2CEBED0")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public float normalMapDistance
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x2CEBED8", Offset = "0x2CE7ED8", VA = "0x2CEBED8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000039")]
		public NormalMapQuality normalMapQuality
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x2CEBEE0", Offset = "0x2CE7EE0", VA = "0x2CEBEE0")]
			get
			{
				return default(NormalMapQuality);
			}
		}

		[Token(Token = "0x1700003A")]
		public bool renderVolumetricShadows
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x2CEBEE8", Offset = "0x2CE7EE8", VA = "0x2CEBEE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public float pointLightInnerAngle
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2CEDF68", Offset = "0x2CE9F68", VA = "0x2CEDF68")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2CEDF70", Offset = "0x2CE9F70", VA = "0x2CEDF70")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public float pointLightOuterAngle
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x2CEDF78", Offset = "0x2CE9F78", VA = "0x2CEDF78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2CEDF80", Offset = "0x2CE9F80", VA = "0x2CEDF80")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public float pointLightInnerRadius
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x2CEDF88", Offset = "0x2CE9F88", VA = "0x2CEDF88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2CEDF90", Offset = "0x2CE9F90", VA = "0x2CEDF90")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public float pointLightOuterRadius
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x2CEDF98", Offset = "0x2CE9F98", VA = "0x2CEDF98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2CEDFA0", Offset = "0x2CE9FA0", VA = "0x2CEDFA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		[Obsolete("pointLightDistance has been changed to normalMapDistance", true)]
		public float pointLightDistance
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x2CEDFA8", Offset = "0x2CE9FA8", VA = "0x2CEDFA8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000040")]
		[Obsolete("pointLightQuality has been changed to normalMapQuality", true)]
		public NormalMapQuality pointLightQuality
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x2CEDFB0", Offset = "0x2CE9FB0", VA = "0x2CEDFB0")]
			get
			{
				return default(NormalMapQuality);
			}
		}

		[Token(Token = "0x17000041")]
		internal bool isPointLight
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x2CEDB2C", Offset = "0x2CE9B2C", VA = "0x2CEDB2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public int shapeLightParametricSides
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2CEDFB8", Offset = "0x2CE9FB8", VA = "0x2CEDFB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000043")]
		public float shapeLightParametricAngleOffset
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2CEDFC0", Offset = "0x2CE9FC0", VA = "0x2CEDFC0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000044")]
		public float shapeLightParametricRadius
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x2CEDFC8", Offset = "0x2CE9FC8", VA = "0x2CEDFC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2CEDFD0", Offset = "0x2CE9FD0", VA = "0x2CEDFD0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public float shapeLightFalloffSize
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2CEDFD8", Offset = "0x2CE9FD8", VA = "0x2CEDFD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2CEDFE0", Offset = "0x2CE9FE0", VA = "0x2CEDFE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Vector3[] shapePath
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x2CEDFF4", Offset = "0x2CE9FF4", VA = "0x2CEDFF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2CEDFFC", Offset = "0x2CE9FFC", VA = "0x2CEDFFC")]
			internal set
			{
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2CEBF08", Offset = "0x2CE7F08", VA = "0x2CEBF08")]
		internal void MarkForUpdate()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2CEBF14", Offset = "0x2CE7F14", VA = "0x2CEBF14")]
		internal void CacheValues()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2CEBF44", Offset = "0x2CE7F44", VA = "0x2CEBF44")]
		internal int GetTopMostLitLayer()
		{
			return default(int);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2CEC114", Offset = "0x2CE8114", VA = "0x2CEC114")]
		internal Bounds UpdateSpriteMesh()
		{
			return default(Bounds);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2CEBA98", Offset = "0x2CE7A98", VA = "0x2CEBA98")]
		internal void UpdateMesh(bool forceUpdate = false)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2CED974", Offset = "0x2CE9974", VA = "0x2CED974")]
		internal void UpdateBoundingSphere()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2CEDB3C", Offset = "0x2CE9B3C", VA = "0x2CEDB3C")]
		internal bool IsLitLayer(int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2CEDB7C", Offset = "0x2CE9B7C", VA = "0x2CEDB7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2CEDC4C", Offset = "0x2CE9C4C", VA = "0x2CEDC4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2CEDDB4", Offset = "0x2CE9DB4", VA = "0x2CEDDB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2CEDEB8", Offset = "0x2CE9EB8", VA = "0x2CEDEB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2CEDEE8", Offset = "0x2CE9EE8", VA = "0x2CEDEE8", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2CEDEF4", Offset = "0x2CE9EF4", VA = "0x2CEDEF4", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2CEE004", Offset = "0x2CEA004", VA = "0x2CEE004")]
		public void SetShapePath(Vector3[] path)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2CEE00C", Offset = "0x2CEA00C", VA = "0x2CEE00C")]
		public Light2D()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
	public struct Light2DBlendStyle
	{
		[Token(Token = "0x200003B")]
		internal enum TextureChannel
		{
			[Token(Token = "0x4000139")]
			None,
			[Token(Token = "0x400013A")]
			R,
			[Token(Token = "0x400013B")]
			G,
			[Token(Token = "0x400013C")]
			B,
			[Token(Token = "0x400013D")]
			A,
			[Token(Token = "0x400013E")]
			OneMinusR,
			[Token(Token = "0x400013F")]
			OneMinusG,
			[Token(Token = "0x4000140")]
			OneMinusB,
			[Token(Token = "0x4000141")]
			OneMinusA
		}

		[Token(Token = "0x200003C")]
		internal struct MaskChannelFilter
		{
			[Token(Token = "0x1700004B")]
			public Vector4 mask
			{
				[Token(Token = "0x6000183")]
				[Address(RVA = "0x2CEE32C", Offset = "0x2CEA32C", VA = "0x2CEE32C")]
				[CompilerGenerated]
				readonly get
				{
					return default(Vector4);
				}
				[Token(Token = "0x6000184")]
				[Address(RVA = "0x2CEE338", Offset = "0x2CEA338", VA = "0x2CEE338")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700004C")]
			public Vector4 inverted
			{
				[Token(Token = "0x6000185")]
				[Address(RVA = "0x2CEE344", Offset = "0x2CEA344", VA = "0x2CEE344")]
				[CompilerGenerated]
				readonly get
				{
					return default(Vector4);
				}
				[Token(Token = "0x6000186")]
				[Address(RVA = "0x2CEE350", Offset = "0x2CEA350", VA = "0x2CEE350")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000187")]
			[Address(RVA = "0x2CEE2F8", Offset = "0x2CEA2F8", VA = "0x2CEE2F8")]
			public MaskChannelFilter(Vector4 m, Vector4 i)
			{
			}
		}

		[Token(Token = "0x200003D")]
		internal enum BlendMode
		{
			[Token(Token = "0x4000145")]
			Additive,
			[Token(Token = "0x4000146")]
			Multiply,
			[Token(Token = "0x4000147")]
			Subtractive
		}

		[Serializable]
		[Token(Token = "0x200003E")]
		internal struct BlendFactors
		{
			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float multiplicative;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float additive;
		}

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		internal TextureChannel maskTextureChannel;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		internal BlendMode blendMode;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int renderTargetHandleId;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal RTHandle renderTargetHandle;

		[Token(Token = "0x17000047")]
		internal Vector2 blendFactors
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2CEE14C", Offset = "0x2CEA14C", VA = "0x2CEE14C")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000048")]
		internal MaskChannelFilter maskTextureChannelFilter
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2CEE180", Offset = "0x2CEA180", VA = "0x2CEE180")]
			get
			{
				return default(MaskChannelFilter);
			}
		}

		[Token(Token = "0x17000049")]
		internal bool isDirty
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x2CEE30C", Offset = "0x2CEA30C", VA = "0x2CEE30C")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x2CEE314", Offset = "0x2CEA314", VA = "0x2CEE314")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		internal bool hasRenderTarget
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2CEE31C", Offset = "0x2CEA31C", VA = "0x2CEE31C")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2CEE324", Offset = "0x2CEA324", VA = "0x2CEE324")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Token(Token = "0x200003F")]
	internal struct LightStats
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int totalLights;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int totalNormalMapUsage;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int totalVolumetricUsage;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint blendStylesUsed;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint blendStylesWithLights;

		[Token(Token = "0x1700004D")]
		public bool useNormalMap
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x2CEE35C", Offset = "0x2CEA35C", VA = "0x2CEE35C")]
			get
			{
				return default(bool);
			}
		}
	}
	[Token(Token = "0x2000040")]
	internal interface ILight2DCullResult
	{
		[Token(Token = "0x1700004E")]
		List<Light2D> visibleLights
		{
			[Token(Token = "0x6000189")]
			get;
		}

		[Token(Token = "0x1700004F")]
		List<ShadowCasterGroup2D> visibleShadows
		{
			[Token(Token = "0x600018A")]
			get;
		}

		[Token(Token = "0x600018B")]
		LightStats GetLightStatsByLayer(int layer);

		[Token(Token = "0x600018C")]
		bool IsSceneLit();
	}
	[Token(Token = "0x2000041")]
	internal class Light2DCullResult : ILight2DCullResult
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Light2D> m_VisibleLights;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<ShadowCasterGroup2D> m_VisibleShadows;

		[Token(Token = "0x17000050")]
		public List<Light2D> visibleLights
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2CEE36C", Offset = "0x2CEA36C", VA = "0x2CEE36C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public List<ShadowCasterGroup2D> visibleShadows
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x2CEE374", Offset = "0x2CEA374", VA = "0x2CEE374", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2CEE37C", Offset = "0x2CEA37C", VA = "0x2CEE37C", Slot = "7")]
		public bool IsSceneLit()
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2CEE424", Offset = "0x2CEA424", VA = "0x2CEE424", Slot = "6")]
		public LightStats GetLightStatsByLayer(int layer)
		{
			return default(LightStats);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2CEE5FC", Offset = "0x2CEA5FC", VA = "0x2CEE5FC")]
		public void SetupCulling(ref ScriptableCullingParameters cullingParameters, Camera camera)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2CEEF4C", Offset = "0x2CEAF4C", VA = "0x2CEEF4C")]
		public Light2DCullResult()
		{
		}
	}
	[Token(Token = "0x2000043")]
	internal static class Light2DManager
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SortingLayer[] s_SortingLayers;

		[Token(Token = "0x17000052")]
		public static List<Light2D> lights
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x2CEF098", Offset = "0x2CEB098", VA = "0x2CEF098")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2CEF0F0", Offset = "0x2CEB0F0", VA = "0x2CEF0F0")]
		internal static void Initialize()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2CEF0F4", Offset = "0x2CEB0F4", VA = "0x2CEF0F4")]
		internal static void Dispose()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2CEDCB8", Offset = "0x2CE9CB8", VA = "0x2CEDCB8")]
		public static void RegisterLight(Light2D light)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2CEDE08", Offset = "0x2CE9E08", VA = "0x2CEDE08")]
		public static void DeregisterLight(Light2D light)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2CEBC10", Offset = "0x2CE7C10", VA = "0x2CEBC10")]
		public static void ErrorIfDuplicateGlobalLight(Light2D light)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2CEF2F4", Offset = "0x2CEB2F4", VA = "0x2CEF2F4")]
		public static bool GetGlobalColor(int sortingLayerIndex, int blendStyleIndex, out Color color)
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2CEF0F8", Offset = "0x2CEB0F8", VA = "0x2CEF0F8")]
		private static bool ContainsDuplicateGlobalLight(int sortingLayerIndex, int blendStyleIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2CEC070", Offset = "0x2CE8070", VA = "0x2CEC070")]
		public static SortingLayer[] GetCachedSortingLayer()
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	internal static class LightUtility
	{
		[Token(Token = "0x2000045")]
		private enum PivotType
		{
			[Token(Token = "0x4000156")]
			PivotBase,
			[Token(Token = "0x4000157")]
			PivotCurve,
			[Token(Token = "0x4000158")]
			PivotIntersect,
			[Token(Token = "0x4000159")]
			PivotSkip,
			[Token(Token = "0x400015A")]
			PivotClip
		}

		[Serializable]
		[Token(Token = "0x2000046")]
		internal struct LightMeshVertex
		{
			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Color color;

			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector2 uv;

			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly VertexAttributeDescriptor[] VertexLayout;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2CEC754", Offset = "0x2CE8754", VA = "0x2CEC754")]
		public static bool CheckForChange(Light2D.LightType a, ref Light2D.LightType b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2CEC73C", Offset = "0x2CE873C", VA = "0x2CEC73C")]
		public static bool CheckForChange(int a, ref int b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2CEC724", Offset = "0x2CE8724", VA = "0x2CEC724")]
		public static bool CheckForChange(float a, ref float b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2CEF58C", Offset = "0x2CEB58C", VA = "0x2CEF58C")]
		public static bool CheckForChange(bool a, ref bool b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2CEF5A8", Offset = "0x2CEB5A8", VA = "0x2CEF5A8")]
		private static bool TestPivot(List<IntPoint> path, int activePoint, long lastPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2CEF67C", Offset = "0x2CEB67C", VA = "0x2CEF67C")]
		private static List<IntPoint> DegeneratePivots(List<IntPoint> path, List<IntPoint> inPath, ref int interiorStart)
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2CEFA68", Offset = "0x2CEBA68", VA = "0x2CEFA68")]
		private static List<IntPoint> SortPivots(List<IntPoint> outPath, List<IntPoint> inPath)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2CEFC90", Offset = "0x2CEBC90", VA = "0x2CEFC90")]
		private static List<IntPoint> FixPivots(List<IntPoint> outPath, List<IntPoint> inPath, ref int interiorStart)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2CEFF90", Offset = "0x2CEBF90", VA = "0x2CEFF90")]
		internal static List<Vector2> GetOutlinePath(Vector3[] shapePath, float offsetDistance)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2CF0374", Offset = "0x2CEC374", VA = "0x2CF0374")]
		private static void TransferToMesh(NativeArray<LightMeshVertex> vertices, int vertexCount, NativeArray<ushort> indices, int indexCount, Light2D light)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2CEC76C", Offset = "0x2CE876C", VA = "0x2CEC76C")]
		public static Bounds GenerateShapeMesh(Light2D light, Vector3[] shapePath, float falloffDistance)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2CED308", Offset = "0x2CE9308", VA = "0x2CED308")]
		public static Bounds GenerateParametricMesh(Light2D light, float radius, float falloffDistance, float angle, int sides)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2CEC20C", Offset = "0x2CE820C", VA = "0x2CEC20C")]
		public static Bounds GenerateSpriteMesh(Light2D light, Sprite sprite)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2CEC640", Offset = "0x2CE8640", VA = "0x2CEC640")]
		public static int GetShapePathHash(Vector3[] path)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000047")]
	internal interface IRenderPass2D
	{
		[Token(Token = "0x17000053")]
		Renderer2DData rendererData
		{
			[Token(Token = "0x60001AF")]
			get;
		}
	}
	[Token(Token = "0x2000048")]
	internal class PixelPerfectBackgroundPass : ScriptableRenderPass
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilingSampler m_ProfilingScope;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2CF0674", Offset = "0x2CEC674", VA = "0x2CF0674")]
		public PixelPerfectBackgroundPass(RenderPassEvent evt)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2CF06E0", Offset = "0x2CEC6E0", VA = "0x2CF06E0", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x2000049")]
	internal class Render2DLightingPass : ScriptableRenderPass, IRenderPass2D
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int k_HDREmulationScaleID;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int k_InverseHDREmulationScaleID;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int k_UseSceneLightingID;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int k_RendererColorID;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int[] k_ShapeLightTextureIDs;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly ShaderTagId k_CombinedRenderingPassName;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly ShaderTagId k_NormalsRenderingPassName;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly ShaderTagId k_LegacyPassName;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly List<ShaderTagId> k_ShaderTags;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly ProfilingSampler m_ProfilingDrawLights;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly ProfilingSampler m_ProfilingDrawLightTextures;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly ProfilingSampler m_ProfilingDrawRenderers;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly ProfilingSampler m_ProfilingDrawLayerBatch;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly ProfilingSampler m_ProfilingSamplerUnlit;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Material m_BlitMaterial;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material m_SamplingMaterial;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly Renderer2DData m_Renderer2DData;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool m_NeedsDepth;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		private short m_CameraSortingLayerBoundsIndex;

		[Token(Token = "0x17000054")]
		private Renderer2DData UnityEngine.Rendering.Universal.IRenderPass2D.rendererData
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2CF5304", Offset = "0x2CF1304", VA = "0x2CF5304", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2CF08D8", Offset = "0x2CEC8D8", VA = "0x2CF08D8")]
		public Render2DLightingPass(Renderer2DData rendererData, Material blitMaterial, Material samplingMaterial)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2CF0A70", Offset = "0x2CECA70", VA = "0x2CF0A70")]
		internal void Setup(bool useDepth)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2CF0A78", Offset = "0x2CECA78", VA = "0x2CF0A78")]
		private void GetTransparencySortingMode(Camera camera, ref SortingSettings sortingSettings)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2CF0B18", Offset = "0x2CECB18", VA = "0x2CF0B18")]
		private void CopyCameraSortingLayerRenderTexture(ScriptableRenderContext context, RenderingData renderingData, RenderBufferStoreAction mainTargetStoreAction)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2CF0988", Offset = "0x2CEC988", VA = "0x2CF0988")]
		internal static short GetCameraSortingLayerBoundsIndex(Renderer2DData rendererData)
		{
			return default(short);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2CF0F4C", Offset = "0x2CECF4C", VA = "0x2CF0F4C")]
		private void DetermineWhenToResolve(int startIndex, int batchesDrawn, int batchCount, LayerBatch[] layerBatches, out int resolveDuringBatch, out bool resolveIsAfterCopy)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2CF1220", Offset = "0x2CED220", VA = "0x2CF1220")]
		private void Render(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, ref FilteringSettings filterSettings, DrawingSettings drawSettings)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2CF13D8", Offset = "0x2CED3D8", VA = "0x2CF13D8")]
		private int DrawLayerBatches(LayerBatch[] layerBatches, int batchCount, int startIndex, CommandBuffer cmd, ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings normalsDrawSettings, ref DrawingSettings drawSettings, ref RenderTextureDescriptor desc)
		{
			return default(int);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2CF3B5C", Offset = "0x2CEFB5C", VA = "0x2CF3B5C", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x200004B")]
	internal class UpscalePass : ScriptableRenderPass
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilingSampler m_ProfilingScope;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RTHandle m_Source;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RTHandle m_UpscaleHandle;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material m_BlitMaterial;

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2CF5928", Offset = "0x2CF1928", VA = "0x2CF5928")]
		public UpscalePass(RenderPassEvent evt, Material blitMaterial)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2CF59C8", Offset = "0x2CF19C8", VA = "0x2CF59C8")]
		public void Setup(RTHandle colorTargetHandle, int width, int height, FilterMode mode, ref RenderingData renderingData, out RTHandle upscaleHandle)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2CF5AC4", Offset = "0x2CF1AC4", VA = "0x2CF5AC4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2CF5AD8", Offset = "0x2CF1AD8", VA = "0x2CF5AD8", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x200004C")]
	internal struct LayerBatch
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int startLayerID;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int endLayerValue;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SortingLayerRange layerRange;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LightStats lightStats;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useNormals;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private unsafe fixed int renderTargetIds[4];

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private unsafe fixed bool renderTargetUsed[4];

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2CF5CF8", Offset = "0x2CF1CF8", VA = "0x2CF5CF8")]
		public void InitRTIds(int index)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2CF31D4", Offset = "0x2CEF1D4", VA = "0x2CF31D4")]
		public RenderTargetIdentifier GetRTId(CommandBuffer cmd, RenderTextureDescriptor desc, int index)
		{
			return default(RenderTargetIdentifier);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2CF3B00", Offset = "0x2CEFB00", VA = "0x2CF3B00")]
		public void ReleaseRT(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x200004F")]
	internal static class LayerUtility
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LayerBatch[] s_LayerBatches;

		[Token(Token = "0x17000055")]
		public static uint maxTextureCount
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x2CF5DCC", Offset = "0x2CF1DCC", VA = "0x2CF5DCC")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x2CF5E14", Offset = "0x2CF1E14", VA = "0x2CF5E14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2CF4784", Offset = "0x2CF0784", VA = "0x2CF4784")]
		public static void InitializeBudget(uint maxTextureCount)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2CF5E60", Offset = "0x2CF1E60", VA = "0x2CF5E60")]
		private static bool CanBatchLightsInLayer(int layerIndex1, int layerIndex2, SortingLayer[] sortingLayers, ILight2DCullResult lightCullResult)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2CF63B8", Offset = "0x2CF23B8", VA = "0x2CF63B8")]
		private static bool CanBatchCameraSortingLayer(int startLayerIndex, SortingLayer[] sortingLayers, Renderer2DData rendererData)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2CF6468", Offset = "0x2CF2468", VA = "0x2CF6468")]
		private static int FindUpperBoundInBatch(int startLayerIndex, SortingLayer[] sortingLayers, Renderer2DData rendererData)
		{
			return default(int);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2CF64FC", Offset = "0x2CF24FC", VA = "0x2CF64FC")]
		private static void InitializeBatchInfos(SortingLayer[] cachedSortingLayers)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2CF4D00", Offset = "0x2CF0D00", VA = "0x2CF4D00")]
		public static LayerBatch[] CalculateBatches(Renderer2DData rendererData, out int batchCount)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2CF254C", Offset = "0x2CEE54C", VA = "0x2CF254C")]
		public static void GetFilterSettings(Renderer2DData rendererData, ref LayerBatch layerBatch, out FilteringSettings filterSettings)
		{
		}
	}
	[Token(Token = "0x2000050")]
	internal static class Light2DLookupTexture
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Texture2D s_PointLightLookupTexture;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2CF65D4", Offset = "0x2CF25D4", VA = "0x2CF65D4")]
		public static Texture GetLightLookupTexture()
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2CF6670", Offset = "0x2CF2670", VA = "0x2CF6670")]
		private static Texture2D CreatePointLightLookupTexture()
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	internal static class RendererLighting
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ShaderTagId k_NormalsRenderingPassName;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly Color k_NormalClearColor;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string k_SpriteLightKeyword;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly string k_UsePointLightCookiesKeyword;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly string k_LightQualityFastKeyword;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly string k_UseNormalMap;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly string k_UseAdditiveBlendingKeyword;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly string[] k_UseBlendStyleKeywords;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly int[] k_BlendFactorsPropIDs;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly int[] k_MaskFilterPropIDs;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly int[] k_InvertedFilterPropIDs;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static GraphicsFormat s_RenderTextureFormatToUse;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private static bool s_HasSetupRenderTextureFormatToUse;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly int k_SrcBlendID;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private static readonly int k_DstBlendID;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly int k_FalloffIntensityID;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private static readonly int k_FalloffDistanceID;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static readonly int k_LightColorID;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private static readonly int k_VolumeOpacityID;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static readonly int k_CookieTexID;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private static readonly int k_FalloffLookupID;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static readonly int k_LightPositionID;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private static readonly int k_LightInvMatrixID;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static readonly int k_InnerRadiusMultID;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private static readonly int k_OuterAngleID;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static readonly int k_InnerAngleMultID;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private static readonly int k_LightLookupID;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static readonly int k_IsFullSpotlightID;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private static readonly int k_LightZDistanceID;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static readonly int k_PointLightCookieTexID;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2CF6A08", Offset = "0x2CF2A08", VA = "0x2CF6A08")]
		private static GraphicsFormat GetRenderTextureFormat()
		{
			return default(GraphicsFormat);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2CF6AFC", Offset = "0x2CF2AFC", VA = "0x2CF6AFC")]
		public static void CreateNormalMapRenderTexture(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, float renderScale)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2CF4B40", Offset = "0x2CF0B40", VA = "0x2CF4B40")]
		public static RenderTextureDescriptor GetBlendStyleRenderTextureDesc(this IRenderPass2D pass, RenderingData renderingData)
		{
			return default(RenderTextureDescriptor);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2CF0D8C", Offset = "0x2CECD8C", VA = "0x2CF0D8C")]
		public static void CreateCameraSortingLayerRenderTexture(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, Downsampling downsamplingMethod)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2CF328C", Offset = "0x2CEF28C", VA = "0x2CF328C")]
		public static void EnableBlendStyle(CommandBuffer cmd, int blendStyleIndex, bool enabled)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2CF5000", Offset = "0x2CF1000", VA = "0x2CF5000")]
		public static void DisableAllKeywords(this IRenderPass2D pass, CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2CF50B4", Offset = "0x2CF10B4", VA = "0x2CF50B4")]
		public static void ReleaseRenderTextures(this IRenderPass2D pass, CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2CF6F24", Offset = "0x2CF2F24", VA = "0x2CF6F24")]
		public static void DrawPointLight(CommandBuffer cmd, Light2D light, Mesh lightMesh, Material material)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2CF701C", Offset = "0x2CF301C", VA = "0x2CF701C")]
		private static bool CanCastShadows(Light2D light, int layerToRender)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2CF7088", Offset = "0x2CF3088", VA = "0x2CF7088")]
		private static bool CanCastVolumetricShadows(Light2D light, int endLayerValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2CF70D0", Offset = "0x2CF30D0", VA = "0x2CF70D0")]
		private static bool ShouldRenderLight(Light2D light, int blendStyleIndex, int layerToRender)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2CF71A8", Offset = "0x2CF31A8", VA = "0x2CF71A8")]
		private static void RenderLightSet(IRenderPass2D pass, RenderingData renderingData, int blendStyleIndex, CommandBuffer cmd, int layerToRender, RenderTargetIdentifier renderTexture, List<Light2D> lights)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2CF3344", Offset = "0x2CEF344", VA = "0x2CF3344")]
		public static void RenderLightVolumes(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, int endLayerValue, RenderTargetIdentifier renderTexture, RenderTargetIdentifier depthTexture, RenderBufferStoreAction intermediateStoreAction, RenderBufferStoreAction finalStoreAction, bool requiresRTInit, List<Light2D> lights)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2CF47DC", Offset = "0x2CF07DC", VA = "0x2CF47DC")]
		public static void SetShapeLightShaderGlobals(this IRenderPass2D pass, CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2CF7FB0", Offset = "0x2CF3FB0", VA = "0x2CF7FB0")]
		private static float GetNormalizedInnerRadius(Light2D light)
		{
			return default(float);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2CF7FC8", Offset = "0x2CF3FC8", VA = "0x2CF7FC8")]
		private static float GetNormalizedAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2CF7FD8", Offset = "0x2CF3FD8", VA = "0x2CF7FD8")]
		private static void GetScaledLightInvMatrix(Light2D light, out Matrix4x4 retMatrix)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2CF7A94", Offset = "0x2CF3A94", VA = "0x2CF7A94")]
		private static void SetGeneralLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd, Light2D light)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2CF7BA0", Offset = "0x2CF3BA0", VA = "0x2CF7BA0")]
		private static void SetPointLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd, Light2D light)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2CF8110", Offset = "0x2CF4110", VA = "0x2CF8110")]
		public static void ClearDirtyLighting(this IRenderPass2D pass, CommandBuffer cmd, uint blendStylesUsed)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2CF262C", Offset = "0x2CEE62C", VA = "0x2CF262C")]
		internal static void RenderNormals(this IRenderPass2D pass, ScriptableRenderContext context, RenderingData renderingData, DrawingSettings drawSettings, FilteringSettings filterSettings, RenderTargetIdentifier depthTarget, bool bFirstClear)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2CF2C84", Offset = "0x2CEEC84", VA = "0x2CF2C84")]
		public static void RenderLights(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, ref LayerBatch layerBatch, ref RenderTextureDescriptor rtDesc)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2CF83B8", Offset = "0x2CF43B8", VA = "0x2CF83B8")]
		private static void SetBlendModes(Material material, BlendMode src, BlendMode dst)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2CF8454", Offset = "0x2CF4454", VA = "0x2CF8454")]
		private static uint GetLightMaterialIndex(Light2D light, bool isVolume)
		{
			return default(uint);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2CF859C", Offset = "0x2CF459C", VA = "0x2CF859C")]
		private static Material CreateLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume)
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2CF7988", Offset = "0x2CF3988", VA = "0x2CF7988")]
		private static Material GetLightMaterial(this Renderer2DData rendererData, Light2D light, bool isVolume)
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	internal interface IPixelPerfectCamera
	{
		[Token(Token = "0x17000056")]
		int assetsPPU
		{
			[Token(Token = "0x60001EF")]
			get;
			[Token(Token = "0x60001F0")]
			set;
		}

		[Token(Token = "0x17000057")]
		int refResolutionX
		{
			[Token(Token = "0x60001F1")]
			get;
			[Token(Token = "0x60001F2")]
			set;
		}

		[Token(Token = "0x17000058")]
		int refResolutionY
		{
			[Token(Token = "0x60001F3")]
			get;
			[Token(Token = "0x60001F4")]
			set;
		}

		[Token(Token = "0x17000059")]
		bool upscaleRT
		{
			[Token(Token = "0x60001F5")]
			get;
			[Token(Token = "0x60001F6")]
			set;
		}

		[Token(Token = "0x1700005A")]
		bool pixelSnapping
		{
			[Token(Token = "0x60001F7")]
			get;
			[Token(Token = "0x60001F8")]
			set;
		}

		[Token(Token = "0x1700005B")]
		bool cropFrameX
		{
			[Token(Token = "0x60001F9")]
			get;
			[Token(Token = "0x60001FA")]
			set;
		}

		[Token(Token = "0x1700005C")]
		bool cropFrameY
		{
			[Token(Token = "0x60001FB")]
			get;
			[Token(Token = "0x60001FC")]
			set;
		}

		[Token(Token = "0x1700005D")]
		bool stretchFill
		{
			[Token(Token = "0x60001FD")]
			get;
			[Token(Token = "0x60001FE")]
			set;
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	internal class PixelPerfectCameraInternal : ISerializationCallbackReceiver
	{
		[NonSerialized]
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IPixelPerfectCamera m_Component;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PixelPerfectCamera m_SerializableComponent;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float originalOrthoSize;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool hasPostProcessLayer;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		internal bool cropFrameXAndY;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		internal bool cropFrameXOrY;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		internal bool useStretchFill;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int zoom;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal bool useOffscreenRT;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal int offscreenRTWidth;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal int offscreenRTHeight;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Rect pixelRect;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal float orthoSize;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal float unitsPerPixel;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal int cinemachineVCamZoom;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal bool requiresUpscaling;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2CF90EC", Offset = "0x2CF50EC", VA = "0x2CF90EC")]
		internal PixelPerfectCameraInternal(IPixelPerfectCamera component)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2CF913C", Offset = "0x2CF513C", VA = "0x2CF913C", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2CF91BC", Offset = "0x2CF51BC", VA = "0x2CF91BC", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2CF922C", Offset = "0x2CF522C", VA = "0x2CF922C")]
		internal void CalculateCameraProperties(int screenWidth, int screenHeight)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2CF9888", Offset = "0x2CF5888", VA = "0x2CF9888")]
		internal Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2CF9C1C", Offset = "0x2CF5C1C", VA = "0x2CF9C1C")]
		internal float CorrectCinemachineOrthoSize(float targetOrthoSize)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000054")]
	internal class Renderer2D : ScriptableRenderer
	{
		[Token(Token = "0x2000055")]
		private struct RenderPassInputSummary
		{
			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool requiresDepthTexture;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			internal bool requiresColorTexture;
		}

		[Token(Token = "0x40001B4")]
		internal const int k_DepthBufferBits = 32;

		[Token(Token = "0x40001B5")]
		private const int k_FinalBlitPassQueueOffset = 1;

		[Token(Token = "0x40001B6")]
		private const int k_AfterFinalBlitPassQueueOffset = 2;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Render2DLightingPass m_Render2DLightingPass;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private PixelPerfectBackgroundPass m_PixelPerfectBackgroundPass;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private UpscalePass m_UpscalePass;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private FinalBlitPass m_FinalBlitPass;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private DrawScreenSpaceUIPass m_DrawOffscreenUIPass;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private DrawScreenSpaceUIPass m_DrawOverlayUIPass;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Light2DCullResult m_LightCullResult;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		internal RenderTargetBufferSystem m_ColorBufferSystem;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private bool m_UseDepthStencilBuffer;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E9")]
		private bool m_CreateColorTexture;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EA")]
		private bool m_CreateDepthTexture;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private RTHandle m_ColorTextureHandle;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private RTHandle m_DepthTextureHandle;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Material m_BlitMaterial;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Material m_BlitHDRMaterial;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Material m_SamplingMaterial;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Renderer2DData m_Renderer2DData;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private PostProcessPasses m_PostProcessPasses;

		[Token(Token = "0x1700005E")]
		internal bool createColorTexture
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x2CFA034", Offset = "0x2CF6034", VA = "0x2CFA034")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		internal bool createDepthTexture
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x2CFA03C", Offset = "0x2CF603C", VA = "0x2CFA03C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		internal ColorGradingLutPass colorGradingLutPass
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x2CFA044", Offset = "0x2CF6044", VA = "0x2CFA044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		internal PostProcessPass postProcessPass
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x2CFA04C", Offset = "0x2CF604C", VA = "0x2CFA04C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		internal PostProcessPass finalPostProcessPass
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x2CFA054", Offset = "0x2CF6054", VA = "0x2CFA054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		internal RTHandle afterPostProcessColorHandle
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x2CFA05C", Offset = "0x2CF605C", VA = "0x2CFA05C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		internal RTHandle colorGradingLutHandle
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x2CFA064", Offset = "0x2CF6064", VA = "0x2CFA064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2CFA06C", Offset = "0x2CF606C", VA = "0x2CFA06C", Slot = "5")]
		public override int SupportedCameraStackingTypes()
		{
			return default(int);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2CFA074", Offset = "0x2CF6074", VA = "0x2CFA074")]
		public Renderer2D(Renderer2DData data)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2CFA564", Offset = "0x2CF6564", VA = "0x2CFA564", Slot = "8")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2CFA6DC", Offset = "0x2CF66DC", VA = "0x2CFA6DC", Slot = "9")]
		internal override void ReleaseRenderTargets()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2CFA708", Offset = "0x2CF6708", VA = "0x2CFA708")]
		public Renderer2DData GetRenderer2DData()
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2CFA710", Offset = "0x2CF6710", VA = "0x2CFA710")]
		private RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData, ref CameraData cameraData)
		{
			return default(RenderPassInputSummary);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2CFA870", Offset = "0x2CF6870", VA = "0x2CFA870")]
		private void CreateRenderTextures(ref RenderPassInputSummary renderPassInputs, CommandBuffer cmd, ref CameraData cameraData, bool forceCreateColorTexture, FilterMode colorTextureFilterMode, out RTHandle colorTargetHandle, out RTHandle depthTargetHandle)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2CFAD08", Offset = "0x2CF6D08", VA = "0x2CFAD08", Slot = "10")]
		public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2CFBAE0", Offset = "0x2CF7AE0", VA = "0x2CFBAE0", Slot = "12")]
		public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2CFBB94", Offset = "0x2CF7B94", VA = "0x2CFBB94", Slot = "16")]
		internal override void SwapColorBuffer(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2CFBD3C", Offset = "0x2CF7D3C", VA = "0x2CFBD3C", Slot = "6")]
		internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2CFBD54", Offset = "0x2CF7D54", VA = "0x2CFBD54", Slot = "7")]
		internal override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2CFBD6C", Offset = "0x2CF7D6C", VA = "0x2CFBD6C", Slot = "17")]
		internal override void EnableSwapBufferMSAA(bool enable)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
	[ReloadGroup]
	[ExcludeFromPreset]
	public class Renderer2DData : ScriptableRendererData
	{
		[Token(Token = "0x2000058")]
		internal enum Renderer2DDefaultMaterialType
		{
			[Token(Token = "0x40001FA")]
			Lit,
			[Token(Token = "0x40001FB")]
			Unlit,
			[Token(Token = "0x40001FC")]
			Custom
		}

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LayerMask m_LayerMask;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TransparencySortMode m_TransparencySortMode;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector3 m_TransparencySortAxis;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_HDREmulationScale;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0.01f, 1f)]
		[SerializeField]
		private float m_LightRenderTextureScale;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("m_LightOperations")]
		[SerializeField]
		private Light2DBlendStyle[] m_LightBlendStyles;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_UseDepthStencilBuffer;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_UseCameraSortingLayersTexture;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int m_CameraSortingLayersTextureBound;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Downsampling m_CameraSortingLayerDownsamplingMethod;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private uint m_MaxLightRenderTextureCount;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private uint m_MaxShadowRenderTextureCount;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Reload("Shaders/2D/Light2D-Shape.shader", ReloadAttribute.Package.Root)]
		[SerializeField]
		private Shader m_ShapeLightShader;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Reload("Shaders/2D/Light2D-Shape-Volumetric.shader", ReloadAttribute.Package.Root)]
		[SerializeField]
		private Shader m_ShapeLightVolumeShader;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Reload("Shaders/2D/Light2D-Point.shader", ReloadAttribute.Package.Root)]
		[SerializeField]
		private Shader m_PointLightShader;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Reload("Shaders/2D/Light2D-Point-Volumetric.shader", ReloadAttribute.Package.Root)]
		[SerializeField]
		private Shader m_PointLightVolumeShader;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Reload("Shaders/Utils/CoreBlit.shader", ReloadAttribute.Package.Root)]
		private Shader m_CoreBlitShader;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Reload("Shaders/Utils/BlitHDROverlay.shader", ReloadAttribute.Package.Root)]
		private Shader m_BlitHDROverlay;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", ReloadAttribute.Package.Root)]
		private Shader m_CoreBlitColorAndDepthPS;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Reload("Shaders/Utils/Sampling.shader", ReloadAttribute.Package.Root)]
		private Shader m_SamplingShader;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Reload("Shaders/2D/Shadow2D-Projected.shader", ReloadAttribute.Package.Root)]
		[SerializeField]
		private Shader m_ProjectedShadowShader;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Reload("Shaders/2D/Shadow2D-Shadow-Sprite.shader", ReloadAttribute.Package.Root)]
		private Shader m_SpriteShadowShader;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Reload("Shaders/2D/Shadow2D-Unshadow-Sprite.shader", ReloadAttribute.Package.Root)]
		private Shader m_SpriteUnshadowShader;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Reload("Shaders/2D/Shadow2D-Unshadow-Geometry.shader", ReloadAttribute.Package.Root)]
		[SerializeField]
		private Shader m_GeometryUnshadowShader;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Reload("Shaders/Utils/FallbackError.shader", ReloadAttribute.Package.Root)]
		private Shader m_FallbackErrorShader;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private PostProcessData m_PostProcessData;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		[Reload("Runtime/2D/Data/Textures/FalloffLookupTexture.png", ReloadAttribute.Package.Root)]
		[SerializeField]
		private Texture2D m_FallOffLookup;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal RTHandle normalsRenderTarget;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal int normalsRenderTargetId;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal RTHandle shadowsRenderTarget;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal int shadowsRenderTargetId;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		internal RTHandle cameraSortingLayerRenderTarget;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		internal int cameraSortingLayerRenderTargetId;

		[Token(Token = "0x17000065")]
		public float hdrEmulationScale
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x2CFE5E0", Offset = "0x2CFA5E0", VA = "0x2CFE5E0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000066")]
		internal float lightRenderTextureScale
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x2CFE5E8", Offset = "0x2CFA5E8", VA = "0x2CFE5E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000067")]
		public Light2DBlendStyle[] lightBlendStyles
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x2CFE5F0", Offset = "0x2CFA5F0", VA = "0x2CFE5F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		internal bool useDepthStencilBuffer
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x2CFE5F8", Offset = "0x2CFA5F8", VA = "0x2CFE5F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		internal Texture2D fallOffLookup
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x2CFE600", Offset = "0x2CFA600", VA = "0x2CFE600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		internal Shader shapeLightShader
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2CFE608", Offset = "0x2CFA608", VA = "0x2CFE608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		internal Shader shapeLightVolumeShader
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x2CFE610", Offset = "0x2CFA610", VA = "0x2CFE610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		internal Shader pointLightShader
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x2CFE618", Offset = "0x2CFA618", VA = "0x2CFE618")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		internal Shader pointLightVolumeShader
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2CFE620", Offset = "0x2CFA620", VA = "0x2CFE620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		internal Shader blitShader
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x2CFE628", Offset = "0x2CFA628", VA = "0x2CFE628")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		internal Shader blitHDROverlay
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x2CFE630", Offset = "0x2CFA630", VA = "0x2CFE630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		internal Shader coreBlitPS
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x2CFE638", Offset = "0x2CFA638", VA = "0x2CFE638")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		internal Shader coreBlitColorAndDepthPS
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x2CFE640", Offset = "0x2CFA640", VA = "0x2CFE640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		internal Shader samplingShader
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2CFE648", Offset = "0x2CFA648", VA = "0x2CFE648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		internal PostProcessData postProcessData
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2CFE650", Offset = "0x2CFA650", VA = "0x2CFE650")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2CFE658", Offset = "0x2CFA658", VA = "0x2CFE658")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		internal Shader spriteShadowShader
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2CFE660", Offset = "0x2CFA660", VA = "0x2CFE660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		internal Shader spriteUnshadowShader
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2CFE668", Offset = "0x2CFA668", VA = "0x2CFE668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		internal Shader geometryUnshadowShader
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2CFE670", Offset = "0x2CFA670", VA = "0x2CFE670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		internal Shader projectedShadowShader
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2CFE678", Offset = "0x2CFA678", VA = "0x2CFE678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		internal TransparencySortMode transparencySortMode
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2CFE680", Offset = "0x2CFA680", VA = "0x2CFE680")]
			get
			{
				return default(TransparencySortMode);
			}
		}

		[Token(Token = "0x17000079")]
		internal Vector3 transparencySortAxis
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x2CFE688", Offset = "0x2CFA688", VA = "0x2CFE688")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007A")]
		internal uint lightRenderTextureMemoryBudget
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x2CFE694", Offset = "0x2CFA694", VA = "0x2CFE694")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700007B")]
		internal uint shadowRenderTextureMemoryBudget
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x2CFE69C", Offset = "0x2CFA69C", VA = "0x2CFE69C")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700007C")]
		internal bool useCameraSortingLayerTexture
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x2CFE6A4", Offset = "0x2CFA6A4", VA = "0x2CFE6A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007D")]
		internal int cameraSortingLayerTextureBound
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x2CFE6AC", Offset = "0x2CFA6AC", VA = "0x2CFE6AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007E")]
		internal Downsampling cameraSortingLayerDownsamplingMethod
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x2CFE6B4", Offset = "0x2CFA6B4", VA = "0x2CFE6B4")]
			get
			{
				return default(Downsampling);
			}
		}

		[Token(Token = "0x1700007F")]
		internal LayerMask layerMask
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x2CFE6BC", Offset = "0x2CFA6BC", VA = "0x2CFE6BC")]
			get
			{
				return default(LayerMask);
			}
		}

		[Token(Token = "0x17000080")]
		internal Dictionary<uint, Material> lightMaterials
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x2CFEBD0", Offset = "0x2CFABD0", VA = "0x2CFEBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		internal Material[] spriteSelfShadowMaterial
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x2CFEBD8", Offset = "0x2CFABD8", VA = "0x2CFEBD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x2CFEBE0", Offset = "0x2CFABE0", VA = "0x2CFEBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		internal Material[] spriteUnshadowMaterial
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x2CFEBE8", Offset = "0x2CFABE8", VA = "0x2CFEBE8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x2CFEBF0", Offset = "0x2CFABF0", VA = "0x2CFEBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		internal Material[] geometryUnshadowMaterial
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2CFEBF8", Offset = "0x2CFABF8", VA = "0x2CFEBF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x2CFEC00", Offset = "0x2CFAC00", VA = "0x2CFEC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		internal Material[] projectedShadowMaterial
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x2CFEC08", Offset = "0x2CFAC08", VA = "0x2CFEC08")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x2CFEC10", Offset = "0x2CFAC10", VA = "0x2CFEC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		internal Material[] stencilOnlyShadowMaterial
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x2CFEC18", Offset = "0x2CFAC18", VA = "0x2CFEC18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x2CFEC20", Offset = "0x2CFAC20", VA = "0x2CFEC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		internal bool isNormalsRenderTargetValid
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x2CFEC28", Offset = "0x2CFAC28", VA = "0x2CFEC28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x2CFEC30", Offset = "0x2CFAC30", VA = "0x2CFEC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		internal float normalsRenderTargetScale
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x2CFEC38", Offset = "0x2CFAC38", VA = "0x2CFEC38")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x2CFEC40", Offset = "0x2CFAC40", VA = "0x2CFEC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		internal ILight2DCullResult lightCullResult
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x2CFEC48", Offset = "0x2CFAC48", VA = "0x2CFEC48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x2CFEC50", Offset = "0x2CFAC50", VA = "0x2CFEC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2CFE6C4", Offset = "0x2CFA6C4", VA = "0x2CFE6C4", Slot = "4")]
		protected override ScriptableRenderer Create()
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2CFE720", Offset = "0x2CFA720", VA = "0x2CFE720")]
		internal void Dispose()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2CFE900", Offset = "0x2CFA900", VA = "0x2CFE900", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2CFEC58", Offset = "0x2CFAC58", VA = "0x2CFEC58")]
		public Renderer2DData()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[ExecuteInEditMode]
	[AddComponentMenu("Rendering/2D/Composite Shadow Caster 2D")]
	[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
	public class CompositeShadowCaster2D : ShadowCasterGroup2D
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2CFED44", Offset = "0x2CFAD44", VA = "0x2CFED44")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2CFEE34", Offset = "0x2CFAE34", VA = "0x2CFEE34")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2CFEED0", Offset = "0x2CFAED0", VA = "0x2CFEED0")]
		public CompositeShadowCaster2D()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("Rendering/2D/Shadow Caster 2D")]
	public class ShadowCaster2D : ShadowCasterGroup2D, ISerializationCallbackReceiver
	{
		[Token(Token = "0x200005B")]
		public enum ComponentVersions
		{
			[Token(Token = "0x4000216")]
			Version_Unserialized,
			[Token(Token = "0x4000217")]
			Version_1
		}

		[Token(Token = "0x40001FD")]
		private const ComponentVersions k_CurrentComponentVersion = ComponentVersions.Version_1;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ComponentVersions m_ComponentVersion;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool m_HasRenderer;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[SerializeField]
		private bool m_UseRendererSilhouette;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[SerializeField]
		private bool m_CastsShadows;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		[SerializeField]
		private bool m_SelfShadows;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int[] m_ApplyToSortingLayers;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3[] m_ShapePath;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int m_ShapePathHash;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Mesh m_Mesh;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int m_InstanceId;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal ShadowCasterGroup2D m_ShadowCasterGroup;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal ShadowCasterGroup2D m_PreviousShadowCasterGroup;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		internal Bounds m_LocalBounds;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal BoundingSphere m_BoundingSphere;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int m_PreviousShadowGroup;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool m_PreviousCastsShadows;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int m_PreviousPathHash;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		internal Vector3 m_CachedPosition;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal Vector3 m_CachedLossyScale;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		internal Quaternion m_CachedRotation;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		internal Matrix4x4 m_CachedShadowMatrix;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		internal Matrix4x4 m_CachedInverseShadowMatrix;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		internal Matrix4x4 m_CachedLocalToWorldMatrix;

		[Token(Token = "0x17000089")]
		public Mesh mesh
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x2CFEEE0", Offset = "0x2CFAEE0", VA = "0x2CFEEE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public Vector3[] shapePath
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x2CFEEE8", Offset = "0x2CFAEE8", VA = "0x2CFEEE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		internal int shapePathHash
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x2CFEEF0", Offset = "0x2CFAEF0", VA = "0x2CFEEF0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x2CFEEF8", Offset = "0x2CFAEF8", VA = "0x2CFEEF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public bool useRendererSilhouette
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x2CFF094", Offset = "0x2CFB094", VA = "0x2CFF094")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x2CFF08C", Offset = "0x2CFB08C", VA = "0x2CFF08C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool selfShadows
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x2CFF0B4", Offset = "0x2CFB0B4", VA = "0x2CFF0B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x2CFF0AC", Offset = "0x2CFB0AC", VA = "0x2CFF0AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool castsShadows
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x2CFF0C4", Offset = "0x2CFB0C4", VA = "0x2CFF0C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x2CFF0BC", Offset = "0x2CFB0BC", VA = "0x2CFF0BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2CFEF00", Offset = "0x2CFAF00", VA = "0x2CFEF00", Slot = "4")]
		internal override void CacheValues()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2CFF0CC", Offset = "0x2CFB0CC", VA = "0x2CFF0CC")]
		private static int[] SetDefaultSortingLayers()
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2CFF198", Offset = "0x2CFB198", VA = "0x2CFF198")]
		internal bool IsLit(Light2D light)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2CFF1E4", Offset = "0x2CFB1E4", VA = "0x2CFF1E4")]
		internal bool IsShadowedLayer(int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2CFF244", Offset = "0x2CFB244", VA = "0x2CFF244")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2CFF5C8", Offset = "0x2CFB5C8", VA = "0x2CFF5C8")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2CFFEA8", Offset = "0x2CFBEA8", VA = "0x2CFFEA8")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2CFFF6C", Offset = "0x2CFBF6C", VA = "0x2CFFF6C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2D00398", Offset = "0x2CFC398", VA = "0x2D00398", Slot = "5")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2D003A4", Offset = "0x2CFC3A4", VA = "0x2D003A4", Slot = "6")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2D00250", Offset = "0x2CFC250", VA = "0x2D00250")]
		private void UpdateBoundingSphere()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2D0053C", Offset = "0x2CFC53C", VA = "0x2D0053C")]
		public ShadowCaster2D()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
	public abstract class ShadowCasterGroup2D : MonoBehaviour
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal int m_ShadowGroup;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ShadowCaster2D> m_ShadowCasters;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2D00554", Offset = "0x2CFC554", VA = "0x2D00554", Slot = "4")]
		internal virtual void CacheValues()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2D005E4", Offset = "0x2CFC5E4", VA = "0x2D005E4")]
		public List<ShadowCaster2D> GetShadowCasters()
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2D005EC", Offset = "0x2CFC5EC", VA = "0x2D005EC")]
		public int GetShadowGroup()
		{
			return default(int);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2D005F4", Offset = "0x2CFC5F4", VA = "0x2D005F4")]
		public void RegisterShadowCaster2D(ShadowCaster2D shadowCaster2D)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2D006E0", Offset = "0x2CFC6E0", VA = "0x2D006E0")]
		public void UnregisterShadowCaster2D(ShadowCaster2D shadowCaster2D)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2CFEED8", Offset = "0x2CFAED8", VA = "0x2CFEED8")]
		protected ShadowCasterGroup2D()
		{
		}
	}
	[Token(Token = "0x200005D")]
	internal class ShadowCasterGroup2DManager
	{
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ShadowCasterGroup2D> s_ShadowCasterGroups;

		[Token(Token = "0x1700008F")]
		public static List<ShadowCasterGroup2D> shadowCasterGroups
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2D00740", Offset = "0x2CFC740", VA = "0x2D00740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2D00788", Offset = "0x2CFC788", VA = "0x2D00788")]
		public static void CacheValues()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2D008F0", Offset = "0x2CFC8F0", VA = "0x2D008F0")]
		public static void AddShadowCasterGroupToList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2D009C4", Offset = "0x2CFC9C4", VA = "0x2D009C4")]
		public static void RemoveShadowCasterGroupFromList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2D00A1C", Offset = "0x2CFCA1C", VA = "0x2D00A1C")]
		private static CompositeShadowCaster2D FindTopMostCompositeShadowCaster(ShadowCaster2D shadowCaster)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2D00128", Offset = "0x2CFC128", VA = "0x2D00128")]
		public static bool AddToShadowCasterGroup(ShadowCaster2D shadowCaster, ref ShadowCasterGroup2D shadowCasterGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2CFFEB0", Offset = "0x2CFBEB0", VA = "0x2CFFEB0")]
		public static void RemoveFromShadowCasterGroup(ShadowCaster2D shadowCaster, ShadowCasterGroup2D shadowCasterGroup)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2CFED48", Offset = "0x2CFAD48", VA = "0x2CFED48")]
		public static void AddGroup(ShadowCasterGroup2D group)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2CFEE38", Offset = "0x2CFAE38", VA = "0x2CFEE38")]
		public static void RemoveGroup(ShadowCasterGroup2D group)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2D00B00", Offset = "0x2CFCB00", VA = "0x2D00B00")]
		public ShadowCasterGroup2DManager()
		{
		}
	}
	[Token(Token = "0x200005E")]
	internal static class ShadowRendering
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int k_LightPosID;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int k_SelfShadowingID;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int k_ShadowStencilGroupID;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int k_ShadowIntensityID;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int k_ShadowVolumeIntensityID;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int k_ShadowRadiusID;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int k_ShadowColorMaskID;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int k_ShadowModelMatrixID;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int k_ShadowModelInvMatrixID;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int k_ShadowModelScaleID;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly ProfilingSampler m_ProfilingSamplerShadows;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly ProfilingSampler m_ProfilingSamplerShadowsA;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly ProfilingSampler m_ProfilingSamplerShadowsR;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly ProfilingSampler m_ProfilingSamplerShadowsG;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly ProfilingSampler m_ProfilingSamplerShadowsB;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static RTHandle[] m_RenderTargets;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static int[] m_RenderTargetIds;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static RenderTargetIdentifier[] m_LightInputTextures;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly Color[] k_ColorLookup;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly ProfilingSampler[] m_ProfilingSamplerShadowColorsLookup;

		[Token(Token = "0x17000090")]
		public static uint maxTextureCount
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x2D00B08", Offset = "0x2CFCB08", VA = "0x2D00B08")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x2D00B60", Offset = "0x2CFCB60", VA = "0x2D00B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2D00BBC", Offset = "0x2CFCBBC", VA = "0x2D00BBC")]
		public static void InitializeBudget(uint maxTextureCount)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2D00F4C", Offset = "0x2CFCF4C", VA = "0x2D00F4C")]
		private static Material[] CreateMaterials(Shader shader, int pass = 0)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2D010AC", Offset = "0x2CFD0AC", VA = "0x2D010AC")]
		private static Material GetProjectedShadowMaterial(this Renderer2DData rendererData, int colorIndex)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2D011B0", Offset = "0x2CFD1B0", VA = "0x2D011B0")]
		private static Material GetStencilOnlyShadowMaterial(this Renderer2DData rendererData, int colorIndex)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2D012B4", Offset = "0x2CFD2B4", VA = "0x2D012B4")]
		private static Material GetSpriteSelfShadowMaterial(this Renderer2DData rendererData, int colorIndex)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2D013B8", Offset = "0x2CFD3B8", VA = "0x2D013B8")]
		private static Material GetSpriteUnshadowMaterial(this Renderer2DData rendererData, int colorIndex)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2D014BC", Offset = "0x2CFD4BC", VA = "0x2D014BC")]
		private static Material GetGeometryUnshadowMaterial(this Renderer2DData rendererData, int colorIndex)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2D015C0", Offset = "0x2CFD5C0", VA = "0x2D015C0")]
		public static void CreateShadowRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int shadowIndex)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2D0183C", Offset = "0x2CFD83C", VA = "0x2D0183C")]
		public static bool PrerenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, int shadowIndex, float shadowIntensity)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2D02658", Offset = "0x2CFE658", VA = "0x2D02658")]
		public static void SetGlobalShadowTexture(CommandBuffer cmdBuffer, Light2D light, int shadowIndex)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2D027C8", Offset = "0x2CFE7C8", VA = "0x2D027C8")]
		public static void DisableGlobalShadowTexture(CommandBuffer cmdBuffer)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2D01684", Offset = "0x2CFD684", VA = "0x2D01684")]
		private static void CreateShadowRenderTexture(IRenderPass2D pass, int handleId, RenderingData renderingData, CommandBuffer cmdBuffer)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2D02854", Offset = "0x2CFE854", VA = "0x2D02854")]
		public static void ReleaseShadowRenderTexture(CommandBuffer cmdBuffer, int shadowIndex)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2D02904", Offset = "0x2CFE904", VA = "0x2D02904")]
		public static void SetShadowProjectionGlobals(CommandBuffer cmdBuffer, ShadowCaster2D shadowCaster)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2D019D4", Offset = "0x2CFD9D4", VA = "0x2D019D4")]
		public static bool RenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, float shadowIntensity, RenderTargetIdentifier renderTexture, int colorBit)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005F")]
	internal class ShadowUtility
	{
		[Token(Token = "0x2000060")]
		internal struct Edge : IComparable<Edge>
		{
			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int vertexIndex0;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int vertexIndex1;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector4 tangent;

			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool compareReversed;

			[Token(Token = "0x6000294")]
			[Address(RVA = "0x2D0312C", Offset = "0x2CFF12C", VA = "0x2D0312C")]
			public void AssignVertexIndices(int vi0, int vi1)
			{
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x2D03A64", Offset = "0x2CFFA64", VA = "0x2D03A64")]
			public int Compare(Edge a, Edge b)
			{
				return default(int);
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x2D034B4", Offset = "0x2CFF4B4", VA = "0x2D034B4", Slot = "4")]
			public int CompareTo(Edge edgeToCompare)
			{
				return default(int);
			}
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2D02F00", Offset = "0x2CFEF00", VA = "0x2D02F00")]
		private static Edge CreateEdge(int triangleIndexA, int triangleIndexB, List<Vector3> vertices, List<int> triangles)
		{
			return default(Edge);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2D03140", Offset = "0x2CFF140", VA = "0x2D03140")]
		private static void PopulateEdgeArray(List<Vector3> vertices, List<int> triangles, List<Edge> edges)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2D0337C", Offset = "0x2CFF37C", VA = "0x2D0337C")]
		private static bool IsOutsideEdge(int edgeIndex, List<Edge> edgesToProcess)
		{
			return default(bool);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2D034EC", Offset = "0x2CFF4EC", VA = "0x2D034EC")]
		private static void SortEdges(List<Edge> edgesToProcess)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2D0353C", Offset = "0x2CFF53C", VA = "0x2D0353C")]
		private static void CreateShadowTriangles(List<Vector3> vertices, List<Color> colors, List<int> triangles, List<Vector4> tangents, List<Edge> edges)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2D03944", Offset = "0x2CFF944", VA = "0x2D03944")]
		private static object InterpCustomVertexData(Vec3 position, object[] data, float[] weights)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2D03968", Offset = "0x2CFF968", VA = "0x2D03968")]
		private static void InitializeTangents(int tangentsToAdd, List<Vector4> tangents)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2D003EC", Offset = "0x2CFC3EC", VA = "0x2D003EC")]
		internal static Bounds CalculateLocalBounds(Vector3[] inVertices)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2CFF6B0", Offset = "0x2CFB6B0", VA = "0x2CFF6B0")]
		public static Bounds GenerateShadowMesh(Mesh mesh, Vector3[] shapePath)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2D03A5C", Offset = "0x2CFFA5C", VA = "0x2D03A5C")]
		public ShadowUtility()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public static class ComponentUtility
	{
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2D03C28", Offset = "0x2CFFC28", VA = "0x2D03C28")]
		public static bool IsUniversalCamera(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2D03CB4", Offset = "0x2CFFCB4", VA = "0x2D03CB4")]
		public static bool IsUniversalLight(Light light)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class PostProcessData : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000064")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Reload("Shaders/PostProcessing/StopNaN.shader", ReloadAttribute.Package.Root)]
			public Shader stopNanPS;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Reload("Shaders/PostProcessing/SubpixelMorphologicalAntialiasing.shader", ReloadAttribute.Package.Root)]
			public Shader subpixelMorphologicalAntialiasingPS;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Reload("Shaders/PostProcessing/GaussianDepthOfField.shader", ReloadAttribute.Package.Root)]
			public Shader gaussianDepthOfFieldPS;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Reload("Shaders/PostProcessing/BokehDepthOfField.shader", ReloadAttribute.Package.Root)]
			public Shader bokehDepthOfFieldPS;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Reload("Shaders/PostProcessing/CameraMotionBlur.shader", ReloadAttribute.Package.Root)]
			public Shader cameraMotionBlurPS;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Reload("Shaders/PostProcessing/PaniniProjection.shader", ReloadAttribute.Package.Root)]
			public Shader paniniProjectionPS;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Reload("Shaders/PostProcessing/LutBuilderLdr.shader", ReloadAttribute.Package.Root)]
			public Shader lutBuilderLdrPS;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Reload("Shaders/PostProcessing/LutBuilderHdr.shader", ReloadAttribute.Package.Root)]
			public Shader lutBuilderHdrPS;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Reload("Shaders/PostProcessing/Bloom.shader", ReloadAttribute.Package.Root)]
			public Shader bloomPS;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Reload("Shaders/PostProcessing/TemporalAA.shader", ReloadAttribute.Package.Root)]
			public Shader temporalAntialiasingPS;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Reload("Shaders/PostProcessing/LensFlareDataDriven.shader", ReloadAttribute.Package.Root)]
			public Shader LensFlareDataDrivenPS;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Reload("Shaders/PostProcessing/ScalingSetup.shader", ReloadAttribute.Package.Root)]
			public Shader scalingSetupPS;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Reload("Shaders/PostProcessing/EdgeAdaptiveSpatialUpsampling.shader", ReloadAttribute.Package.Root)]
			public Shader easuPS;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Reload("Shaders/PostProcessing/UberPost.shader", ReloadAttribute.Package.Root)]
			public Shader uberPostPS;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Reload("Shaders/PostProcessing/FinalPost.shader", ReloadAttribute.Package.Root)]
			public Shader finalPostPassPS;

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x2D03D48", Offset = "0x2CFFD48", VA = "0x2D03D48")]
			public ShaderResources()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000065")]
		[ReloadGroup]
		public sealed class TextureResources
		{
			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Reload("Textures/BlueNoise16/L/LDR_LLL1_{0}.png", 0, 32, ReloadAttribute.Package.Root)]
			public Texture2D[] blueNoise16LTex;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Reload(new string[] { "Textures/FilmGrain/Thin01.png", "Textures/FilmGrain/Thin02.png", "Textures/FilmGrain/Medium01.png", "Textures/FilmGrain/Medium02.png", "Textures/FilmGrain/Medium03.png", "Textures/FilmGrain/Medium04.png", "Textures/FilmGrain/Medium05.png", "Textures/FilmGrain/Medium06.png", "Textures/FilmGrain/Large01.png", "Textures/FilmGrain/Large02.png" }, ReloadAttribute.Package.Root)]
			public Texture2D[] filmGrainTex;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Reload("Textures/SMAA/AreaTex.tga", ReloadAttribute.Package.Root)]
			public Texture2D smaaAreaTex;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Reload("Textures/SMAA/SearchTex.tga", ReloadAttribute.Package.Root)]
			public Texture2D smaaSearchTex;

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x2D03D50", Offset = "0x2CFFD50", VA = "0x2D03D50")]
			public TextureResources()
			{
			}
		}

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShaderResources shaders;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureResources textures;

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2D03D40", Offset = "0x2CFFD40", VA = "0x2D03D40")]
		public PostProcessData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class StencilStateData
	{
		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool overrideStencilState;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int stencilReference;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CompareFunction stencilCompareFunction;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public StencilOp passOperation;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StencilOp failOperation;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public StencilOp zFailOperation;

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2D03D58", Offset = "0x2CFFD58", VA = "0x2D03D58")]
		public StencilStateData()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public enum ShadowQuality
	{
		[Token(Token = "0x4000254")]
		Disabled,
		[Token(Token = "0x4000255")]
		HardShadows,
		[Token(Token = "0x4000256")]
		SoftShadows
	}
	[Token(Token = "0x2000068")]
	public enum SoftShadowQuality
	{
		[Token(Token = "0x4000258")]
		[InspectorName("Use settings from Render Pipeline Asset")]
		UsePipelineSettings,
		[Token(Token = "0x4000259")]
		Low,
		[Token(Token = "0x400025A")]
		Medium,
		[Token(Token = "0x400025B")]
		High
	}
	[Token(Token = "0x2000069")]
	public enum ShadowResolution
	{
		[Token(Token = "0x400025D")]
		_256 = 0x100,
		[Token(Token = "0x400025E")]
		_512 = 0x200,
		[Token(Token = "0x400025F")]
		_1024 = 0x400,
		[Token(Token = "0x4000260")]
		_2048 = 0x800,
		[Token(Token = "0x4000261")]
		_4096 = 0x1000
	}
	[Token(Token = "0x200006A")]
	public enum LightCookieResolution
	{
		[Token(Token = "0x4000263")]
		_256 = 0x100,
		[Token(Token = "0x4000264")]
		_512 = 0x200,
		[Token(Token = "0x4000265")]
		_1024 = 0x400,
		[Token(Token = "0x4000266")]
		_2048 = 0x800,
		[Token(Token = "0x4000267")]
		_4096 = 0x1000
	}
	[Token(Token = "0x200006B")]
	public enum LightCookieFormat
	{
		[Token(Token = "0x4000269")]
		GrayscaleLow,
		[Token(Token = "0x400026A")]
		GrayscaleHigh,
		[Token(Token = "0x400026B")]
		ColorLow,
		[Token(Token = "0x400026C")]
		ColorHigh,
		[Token(Token = "0x400026D")]
		ColorHDR
	}
	[Token(Token = "0x200006C")]
	public enum HDRColorBufferPrecision
	{
		[Token(Token = "0x400026F")]
		[Tooltip("Use 32-bits per pixel for HDR rendering.")]
		_32Bits,
		[Token(Token = "0x4000270")]
		[Tooltip("Use 64-bits per pixel for HDR rendering.")]
		_64Bits
	}
	[Token(Token = "0x200006D")]
	public enum MsaaQuality
	{
		[Token(Token = "0x4000272")]
		Disabled = 1,
		[Token(Token = "0x4000273")]
		_2x = 2,
		[Token(Token = "0x4000274")]
		_4x = 4,
		[Token(Token = "0x4000275")]
		_8x = 8
	}
	[Token(Token = "0x200006E")]
	public enum Downsampling
	{
		[Token(Token = "0x4000277")]
		None,
		[Token(Token = "0x4000278")]
		_2xBilinear,
		[Token(Token = "0x4000279")]
		_4xBox,
		[Token(Token = "0x400027A")]
		_4xBilinear
	}
	[Token(Token = "0x200006F")]
	internal enum DefaultMaterialType
	{
		[Token(Token = "0x400027C")]
		Standard,
		[Token(Token = "0x400027D")]
		Particle,
		[Token(Token = "0x400027E")]
		Terrain,
		[Token(Token = "0x400027F")]
		Sprite,
		[Token(Token = "0x4000280")]
		UnityBuiltinDefault,
		[Token(Token = "0x4000281")]
		SpriteMask,
		[Token(Token = "0x4000282")]
		Decal
	}
	[Token(Token = "0x2000070")]
	public enum LightRenderingMode
	{
		[Token(Token = "0x4000284")]
		Disabled = 0,
		[Token(Token = "0x4000285")]
		PerVertex = 2,
		[Token(Token = "0x4000286")]
		PerPixel = 1
	}
	[Token(Token = "0x2000071")]
	[Obsolete("PipelineDebugLevel is replaced to use the profiler and has no effect.", false)]
	public enum PipelineDebugLevel
	{
		[Token(Token = "0x4000288")]
		Disabled,
		[Token(Token = "0x4000289")]
		Profiling
	}
	[Token(Token = "0x2000072")]
	public enum RendererType
	{
		[Token(Token = "0x400028B")]
		Custom = 0,
		[Token(Token = "0x400028C")]
		UniversalRenderer = 1,
		[Token(Token = "0x400028D")]
		_2DRenderer = 2,
		[Token(Token = "0x400028E")]
		[Obsolete("ForwardRenderer has been renamed (UnityUpgradable) -> UniversalRenderer", true)]
		ForwardRenderer = 1
	}
	[Token(Token = "0x2000073")]
	public enum ColorGradingMode
	{
		[Token(Token = "0x4000290")]
		LowDynamicRange,
		[Token(Token = "0x4000291")]
		HighDynamicRange
	}
	[Token(Token = "0x2000074")]
	public enum StoreActionsOptimization
	{
		[Token(Token = "0x4000293")]
		Auto,
		[Token(Token = "0x4000294")]
		Discard,
		[Token(Token = "0x4000295")]
		Store
	}
	[Token(Token = "0x2000075")]
	public enum VolumeFrameworkUpdateMode
	{
		[Token(Token = "0x4000297")]
		[InspectorName("Every Frame")]
		EveryFrame,
		[Token(Token = "0x4000298")]
		[InspectorName("Via Scripting")]
		ViaScripting,
		[Token(Token = "0x4000299")]
		[InspectorName("Use Pipeline Settings")]
		UsePipelineSettings
	}
	[Token(Token = "0x2000076")]
	public enum UpscalingFilterSelection
	{
		[Token(Token = "0x400029B")]
		[InspectorName("Automatic")]
		[Tooltip("Unity selects a filtering option automatically based on the Render Scale value and the current screen resolution.")]
		Auto,
		[Token(Token = "0x400029C")]
		[InspectorName("Bilinear")]
		Linear,
		[Token(Token = "0x400029D")]
		[InspectorName("Nearest-Neighbor")]
		Point,
		[Token(Token = "0x400029E")]
		[InspectorName("FidelityFX Super Resolution 1.0")]
		[Tooltip("If the target device does not support Unity shader model 4.5, Unity falls back to the Automatic option.")]
		FSR
	}
	[Token(Token = "0x2000077")]
	public enum LODCrossFadeDitheringType
	{
		[Token(Token = "0x40002A0")]
		BayerMatrix,
		[Token(Token = "0x40002A1")]
		BlueNoise
	}
	[Token(Token = "0x2000078")]
	public enum ShEvalMode
	{
		[Token(Token = "0x40002A3")]
		Auto,
		[Token(Token = "0x40002A4")]
		PerVertex,
		[Token(Token = "0x40002A5")]
		Mixed,
		[Token(Token = "0x40002A6")]
		PerPixel
	}
	[Token(Token = "0x2000079")]
	[ExcludeFromPreset]
	public class UniversalRenderPipelineAsset : RenderPipelineAsset, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x200007A")]
		[ReloadGroup]
		public sealed class TextureResources
		{
			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Reload("Textures/BlueNoise64/L/LDR_LLL1_0.png", ReloadAttribute.Package.Root)]
			public Texture2D blueNoise64LTex;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Reload("Textures/BayerMatrix.png", ReloadAttribute.Package.Root)]
			public Texture2D bayerMatrixTex;

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x2D05F6C", Offset = "0x2D01F6C", VA = "0x2D05F6C")]
			public bool NeedsReload()
			{
				return default(bool);
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x2D05730", Offset = "0x2D01730", VA = "0x2D05730")]
			public TextureResources()
			{
			}
		}

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Shader m_DefaultShader;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ScriptableRenderer[] m_Renderers;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int k_AssetVersion;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int k_AssetPreviousVersion;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RendererType m_RendererType;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use m_RendererDataList instead.")]
		[SerializeField]
		internal ScriptableRendererData m_RendererData;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal ScriptableRendererData[] m_RendererDataList;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal int m_DefaultRendererIndex;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool m_RequireDepthTexture;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[SerializeField]
		private bool m_RequireOpaqueTexture;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Downsampling m_OpaqueDownsampling;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool m_SupportsTerrainHoles;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[SerializeField]
		private bool m_SupportsHDR;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private HDRColorBufferPrecision m_HDRColorBufferPrecision;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private MsaaQuality m_MSAA;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_RenderScale;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private UpscalingFilterSelection m_UpscalingFilter;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool m_FsrOverrideSharpness;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_FsrSharpness;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool m_EnableLODCrossFade;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private LODCrossFadeDitheringType m_LODCrossFadeDitheringType;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ShEvalMode m_ShEvalMode;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private LightRenderingMode m_MainLightRenderingMode;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool m_MainLightShadowsSupported;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private ShadowResolution m_MainLightShadowmapResolution;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LightRenderingMode m_AdditionalLightsRenderingMode;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private int m_AdditionalLightsPerObjectLimit;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool m_AdditionalLightShadowsSupported;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private ShadowResolution m_AdditionalLightsShadowmapResolution;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private int m_AdditionalLightsShadowResolutionTierLow;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private int m_AdditionalLightsShadowResolutionTierMedium;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int m_AdditionalLightsShadowResolutionTierHigh;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private bool m_ReflectionProbeBlending;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		[SerializeField]
		private bool m_ReflectionProbeBoxProjection;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float m_ShadowDistance;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private int m_ShadowCascadeCount;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float m_Cascade2Split;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private Vector2 m_Cascade3Split;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private Vector3 m_Cascade4Split;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_CascadeBorder;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float m_ShadowDepthBias;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_ShadowNormalBias;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private bool m_SoftShadowsSupported;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
		[SerializeField]
		private bool m_ConservativeEnclosingSphere;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private int m_NumIterationsEnclosingSphere;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private SoftShadowQuality m_SoftShadowQuality;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private LightCookieResolution m_AdditionalLightsCookieResolution;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private LightCookieFormat m_AdditionalLightsCookieFormat;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool m_UseSRPBatcher;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		[SerializeField]
		private bool m_SupportsDynamicBatching;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		[SerializeField]
		private bool m_MixedLightingSupported;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		[SerializeField]
		private bool m_SupportsLightCookies;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private bool m_SupportsLightLayers;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Obsolete]
		[SerializeField]
		private PipelineDebugLevel m_DebugLevel;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private StoreActionsOptimization m_StoreActionsOptimization;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool m_EnableRenderGraph;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[SerializeField]
		private bool m_UseAdaptivePerformance;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private ColorGradingMode m_ColorGradingMode;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private int m_ColorGradingLutSize;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		private bool m_UseFastSRGBLinearConversion;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		[SerializeField]
		private bool m_SupportDataDrivenLensFlare;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ShadowQuality m_ShadowType;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private bool m_LocalShadowsSupported;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ShadowResolution m_LocalShadowsAtlasResolution;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		private int m_MaxPixelLights;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private ShadowResolution m_ShadowAtlasResolution;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateMode;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private TextureResources m_Textures;

		[Token(Token = "0x40002EB")]
		public const int k_MinLutSize = 16;

		[Token(Token = "0x40002EC")]
		public const int k_MaxLutSize = 65;

		[Token(Token = "0x40002ED")]
		internal const int k_ShadowCascadeMinCount = 1;

		[Token(Token = "0x40002EE")]
		internal const int k_ShadowCascadeMaxCount = 4;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int AdditionalLightsDefaultShadowResolutionTierLow;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int AdditionalLightsDefaultShadowResolutionTierMedium;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int AdditionalLightsDefaultShadowResolutionTierHigh;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static GraphicsFormat[][] s_LightCookieFormatList;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private int m_ShaderVariantLogLevel;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[SerializeField]
		[Obsolete("This is obsolete, please use shadowCascadeCount instead.", false)]
		private ShadowCascadesOption m_ShadowCascades;

		[Token(Token = "0x17000091")]
		internal ReadOnlySpan<ScriptableRenderer> renderers
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x2D03D68", Offset = "0x2CFFD68", VA = "0x2D03D68")]
			get
			{
				return default(ReadOnlySpan<ScriptableRenderer>);
			}
		}

		[Token(Token = "0x17000092")]
		public ScriptableRenderer scriptableRenderer
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x2D04370", Offset = "0x2D00370", VA = "0x2D04370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		internal ScriptableRendererData scriptableRendererData
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x2D045AC", Offset = "0x2D005AC", VA = "0x2D045AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		internal GraphicsFormat additionalLightsCookieFormat
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x2D04924", Offset = "0x2D00924", VA = "0x2D04924")]
			get
			{
				return default(GraphicsFormat);
			}
		}

		[Token(Token = "0x17000095")]
		internal Vector2Int additionalLightsCookieResolution
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2D04B58", Offset = "0x2D00B58", VA = "0x2D04B58")]
			get
			{
				return default(Vector2Int);
			}
		}

		[Token(Token = "0x17000096")]
		internal int[] rendererIndexList
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x2D04B64", Offset = "0x2D00B64", VA = "0x2D04B64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public bool supportsCameraDepthTexture
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x2D04BFC", Offset = "0x2D00BFC", VA = "0x2D04BFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x2D04C04", Offset = "0x2D00C04", VA = "0x2D04C04")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public bool supportsCameraOpaqueTexture
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x2D04C0C", Offset = "0x2D00C0C", VA = "0x2D04C0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x2D04C14", Offset = "0x2D00C14", VA = "0x2D04C14")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public Downsampling opaqueDownsampling
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2D04C1C", Offset = "0x2D00C1C", VA = "0x2D04C1C")]
			get
			{
				return default(Downsampling);
			}
		}

		[Token(Token = "0x1700009A")]
		public bool supportsTerrainHoles
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x2D04C24", Offset = "0x2D00C24", VA = "0x2D04C24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		public StoreActionsOptimization storeActionsOptimization
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x2D04C2C", Offset = "0x2D00C2C", VA = "0x2D04C2C")]
			get
			{
				return default(StoreActionsOptimization);
			}
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x2D04C34", Offset = "0x2D00C34", VA = "0x2D04C34")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public bool supportsHDR
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x2D04C3C", Offset = "0x2D00C3C", VA = "0x2D04C3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x2D04C44", Offset = "0x2D00C44", VA = "0x2D04C44")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public HDRColorBufferPrecision hdrColorBufferPrecision
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x2D04C4C", Offset = "0x2D00C4C", VA = "0x2D04C4C")]
			get
			{
				return default(HDRColorBufferPrecision);
			}
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x2D04C54", Offset = "0x2D00C54", VA = "0x2D04C54")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public int msaaSampleCount
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x2D04C5C", Offset = "0x2D00C5C", VA = "0x2D04C5C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x2D04C64", Offset = "0x2D00C64", VA = "0x2D04C64")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public float renderScale
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x2D04C6C", Offset = "0x2D00C6C", VA = "0x2D04C6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x2D04C74", Offset = "0x2D00C74", VA = "0x2D04C74")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public bool enableLODCrossFade
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x2D04D08", Offset = "0x2D00D08", VA = "0x2D04D08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A1")]
		public LODCrossFadeDitheringType lodCrossFadeDitheringType
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x2D04D10", Offset = "0x2D00D10", VA = "0x2D04D10")]
			get
			{
				return default(LODCrossFadeDitheringType);
			}
		}

		[Token(Token = "0x170000A2")]
		public UpscalingFilterSelection upscalingFilter
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x2D04D18", Offset = "0x2D00D18", VA = "0x2D04D18")]
			get
			{
				return default(UpscalingFilterSelection);
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x2D04D20", Offset = "0x2D00D20", VA = "0x2D04D20")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool fsrOverrideSharpness
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x2D04D28", Offset = "0x2D00D28", VA = "0x2D04D28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x2D04D30", Offset = "0x2D00D30", VA = "0x2D04D30")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public float fsrSharpness
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x2D04D38", Offset = "0x2D00D38", VA = "0x2D04D38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x2D04D40", Offset = "0x2D00D40", VA = "0x2D04D40")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public ShEvalMode shEvalMode
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x2D04D48", Offset = "0x2D00D48", VA = "0x2D04D48")]
			get
			{
				return default(ShEvalMode);
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x2D04D50", Offset = "0x2D00D50", VA = "0x2D04D50")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public LightRenderingMode mainLightRenderingMode
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x2D04D58", Offset = "0x2D00D58", VA = "0x2D04D58")]
			get
			{
				return default(LightRenderingMode);
			}
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x2D04D60", Offset = "0x2D00D60", VA = "0x2D04D60")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool supportsMainLightShadows
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x2D04D68", Offset = "0x2D00D68", VA = "0x2D04D68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x2D04D70", Offset = "0x2D00D70", VA = "0x2D04D70")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public int mainLightShadowmapResolution
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x2D04D78", Offset = "0x2D00D78", VA = "0x2D04D78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x2D04D80", Offset = "0x2D00D80", VA = "0x2D04D80")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public LightRenderingMode additionalLightsRenderingMode
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x2D04D88", Offset = "0x2D00D88", VA = "0x2D04D88")]
			get
			{
				return default(LightRenderingMode);
			}
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x2D04D90", Offset = "0x2D00D90", VA = "0x2D04D90")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public int maxAdditionalLightsCount
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x2D04D98", Offset = "0x2D00D98", VA = "0x2D04D98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x2D04DA0", Offset = "0x2D00DA0", VA = "0x2D04DA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public bool supportsAdditionalLightShadows
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x2D04E58", Offset = "0x2D00E58", VA = "0x2D04E58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x2D04E60", Offset = "0x2D00E60", VA = "0x2D04E60")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public int additionalLightsShadowmapResolution
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x2D04E68", Offset = "0x2D00E68", VA = "0x2D04E68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x2D04E70", Offset = "0x2D00E70", VA = "0x2D04E70")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public int additionalLightsShadowResolutionTierLow
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x2D04E78", Offset = "0x2D00E78", VA = "0x2D04E78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x2D04E80", Offset = "0x2D00E80", VA = "0x2D04E80")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public int additionalLightsShadowResolutionTierMedium
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x2D04E88", Offset = "0x2D00E88", VA = "0x2D04E88")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x2D04E90", Offset = "0x2D00E90", VA = "0x2D04E90")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public int additionalLightsShadowResolutionTierHigh
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x2D04E98", Offset = "0x2D00E98", VA = "0x2D04E98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x2D04EA0", Offset = "0x2D00EA0", VA = "0x2D04EA0")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool reflectionProbeBlending
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x2D04F74", Offset = "0x2D00F74", VA = "0x2D04F74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x2D04F7C", Offset = "0x2D00F7C", VA = "0x2D04F7C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool reflectionProbeBoxProjection
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x2D04F84", Offset = "0x2D00F84", VA = "0x2D04F84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x2D04F8C", Offset = "0x2D00F8C", VA = "0x2D04F8C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public float shadowDistance
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x2D04F94", Offset = "0x2D00F94", VA = "0x2D04F94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x2D04F9C", Offset = "0x2D00F9C", VA = "0x2D04F9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public int shadowCascadeCount
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x2D04FB0", Offset = "0x2D00FB0", VA = "0x2D04FB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x2D04FB8", Offset = "0x2D00FB8", VA = "0x2D04FB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public float cascade2Split
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x2D0508C", Offset = "0x2D0108C", VA = "0x2D0508C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x2D05094", Offset = "0x2D01094", VA = "0x2D05094")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public Vector2 cascade3Split
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x2D0509C", Offset = "0x2D0109C", VA = "0x2D0509C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x2D050A4", Offset = "0x2D010A4", VA = "0x2D050A4")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public Vector3 cascade4Split
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x2D050AC", Offset = "0x2D010AC", VA = "0x2D050AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x2D050B8", Offset = "0x2D010B8", VA = "0x2D050B8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public float cascadeBorder
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x2D050C4", Offset = "0x2D010C4", VA = "0x2D050C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x2D050CC", Offset = "0x2D010CC", VA = "0x2D050CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public float shadowDepthBias
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x2D050D4", Offset = "0x2D010D4", VA = "0x2D050D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x2D050DC", Offset = "0x2D010DC", VA = "0x2D050DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public float shadowNormalBias
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x2D05168", Offset = "0x2D01168", VA = "0x2D05168")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x2D05170", Offset = "0x2D01170", VA = "0x2D05170")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public bool supportsSoftShadows
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x2D05188", Offset = "0x2D01188", VA = "0x2D05188")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x2D05190", Offset = "0x2D01190", VA = "0x2D05190")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		internal SoftShadowQuality softShadowQuality
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x2D05198", Offset = "0x2D01198", VA = "0x2D05198")]
			get
			{
				return default(SoftShadowQuality);
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x2D051A0", Offset = "0x2D011A0", VA = "0x2D051A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public bool supportsDynamicBatching
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x2D051A8", Offset = "0x2D011A8", VA = "0x2D051A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x2D051B0", Offset = "0x2D011B0", VA = "0x2D051B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public bool supportsMixedLighting
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x2D051B8", Offset = "0x2D011B8", VA = "0x2D051B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BE")]
		public bool supportsLightCookies
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x2D051C0", Offset = "0x2D011C0", VA = "0x2D051C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BF")]
		[Obsolete("This is obsolete, UnityEngine.Rendering.ShaderVariantLogLevel instead.", false)]
		public bool supportsLightLayers
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x2D051C8", Offset = "0x2D011C8", VA = "0x2D051C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		public bool useRenderingLayers
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x2D051D0", Offset = "0x2D011D0", VA = "0x2D051D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C1")]
		public VolumeFrameworkUpdateMode volumeFrameworkUpdateMode
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x2D051D8", Offset = "0x2D011D8", VA = "0x2D051D8")]
			get
			{
				return default(VolumeFrameworkUpdateMode);
			}
		}

		[Token(Token = "0x170000C2")]
		[Obsolete("PipelineDebugLevel is deprecated and replaced to use the profiler. Calling debugLevel is not necessary.", false)]
		public PipelineDebugLevel debugLevel
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x2D051E0", Offset = "0x2D011E0", VA = "0x2D051E0")]
			get
			{
				return default(PipelineDebugLevel);
			}
		}

		[Token(Token = "0x170000C3")]
		public bool useSRPBatcher
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x2D051E8", Offset = "0x2D011E8", VA = "0x2D051E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x2D051F0", Offset = "0x2D011F0", VA = "0x2D051F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		internal bool enableRenderGraph
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x2D051F8", Offset = "0x2D011F8", VA = "0x2D051F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x2D05200", Offset = "0x2D01200", VA = "0x2D05200")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public ColorGradingMode colorGradingMode
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x2D05208", Offset = "0x2D01208", VA = "0x2D05208")]
			get
			{
				return default(ColorGradingMode);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x2D05210", Offset = "0x2D01210", VA = "0x2D05210")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public int colorGradingLutSize
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x2D05218", Offset = "0x2D01218", VA = "0x2D05218")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x2D05220", Offset = "0x2D01220", VA = "0x2D05220")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public bool useFastSRGBLinearConversion
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x2D05240", Offset = "0x2D01240", VA = "0x2D05240")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C8")]
		public bool supportDataDrivenLensFlare
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x2D05248", Offset = "0x2D01248", VA = "0x2D05248")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		public bool useAdaptivePerformance
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x2D05250", Offset = "0x2D01250", VA = "0x2D05250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x2D05258", Offset = "0x2D01258", VA = "0x2D05258")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public bool conservativeEnclosingSphere
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x2D05260", Offset = "0x2D01260", VA = "0x2D05260")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x2D05268", Offset = "0x2D01268", VA = "0x2D05268")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public int numIterationsEnclosingSphere
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x2D05270", Offset = "0x2D01270", VA = "0x2D05270")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x2D05278", Offset = "0x2D01278", VA = "0x2D05278")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public override Material defaultMaterial
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x2D05280", Offset = "0x2D01280", VA = "0x2D05280", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public override Material defaultParticleMaterial
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x2D05288", Offset = "0x2D01288", VA = "0x2D05288", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		public override Material defaultLineMaterial
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x2D05290", Offset = "0x2D01290", VA = "0x2D05290", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		public override Material defaultTerrainMaterial
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x2D05298", Offset = "0x2D01298", VA = "0x2D05298", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		public override Material defaultUIMaterial
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x2D052A0", Offset = "0x2D012A0", VA = "0x2D052A0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public override Material defaultUIOverdrawMaterial
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x2D052A8", Offset = "0x2D012A8", VA = "0x2D052A8", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		public override Material defaultUIETC1SupportedMaterial
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x2D052B0", Offset = "0x2D012B0", VA = "0x2D052B0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public override Material default2DMaterial
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x2D052B8", Offset = "0x2D012B8", VA = "0x2D052B8", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public override Material default2DMaskMaterial
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x2D052C0", Offset = "0x2D012C0", VA = "0x2D052C0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public Material decalMaterial
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2D052C8", Offset = "0x2D012C8", VA = "0x2D052C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public override Shader defaultShader
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x2D052D0", Offset = "0x2D012D0", VA = "0x2D052D0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public override Shader terrainDetailLitShader
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x2D0537C", Offset = "0x2D0137C", VA = "0x2D0537C", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public override Shader terrainDetailGrassShader
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x2D05440", Offset = "0x2D01440", VA = "0x2D05440", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public override Shader terrainDetailGrassBillboardShader
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x2D05504", Offset = "0x2D01504", VA = "0x2D05504", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public override string[] renderingLayerMaskNames
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x2D055C8", Offset = "0x2D015C8", VA = "0x2D055C8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public override string[] prefixedRenderingLayerMaskNames
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x2D05628", Offset = "0x2D01628", VA = "0x2D05628", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
		public string[] lightLayerMaskNames
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x2D05688", Offset = "0x2D01688", VA = "0x2D05688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public TextureResources textures
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x2D056CC", Offset = "0x2D016CC", VA = "0x2D056CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		[Obsolete("Use UniversalRenderPipelineGlobalSettings.instance.shaderVariantLogLevel", false)]
		public ShaderVariantLogLevel shaderVariantLogLevel
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x2D05A74", Offset = "0x2D01A74", VA = "0x2D05A74")]
			get
			{
				return default(ShaderVariantLogLevel);
			}
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x2D05AD4", Offset = "0x2D01AD4", VA = "0x2D05AD4")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		[Obsolete("This is obsolete, please use shadowCascadeCount instead.", false)]
		public ShadowCascadesOption shadowCascadeOption
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x2D05B38", Offset = "0x2D01B38", VA = "0x2D05B38")]
			get
			{
				return default(ShadowCascadesOption);
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x2D05BB8", Offset = "0x2D01BB8", VA = "0x2D05BB8")]
			set
			{
			}
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2D03DB0", Offset = "0x2CFFDB0", VA = "0x2D03DB0")]
		public ScriptableRendererData LoadBuiltinRendererData(RendererType type = RendererType.UniversalRenderer)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2D03DEC", Offset = "0x2CFFDEC", VA = "0x2D03DEC", Slot = "25")]
		protected override RenderPipeline CreatePipeline()
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2D040B0", Offset = "0x2D000B0", VA = "0x2D040B0")]
		internal void DestroyRenderers()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2D04328", Offset = "0x2D00328", VA = "0x2D04328")]
		private void DestroyRenderer(ref ScriptableRenderer renderer)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2D0434C", Offset = "0x2D0034C", VA = "0x2D0434C", Slot = "27")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2D04114", Offset = "0x2D00114", VA = "0x2D04114")]
		private void CreateRenderers()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2D04368", Offset = "0x2D00368", VA = "0x2D04368")]
		private Material GetMaterial(DefaultMaterialType materialType)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2D0466C", Offset = "0x2D0066C", VA = "0x2D0466C")]
		public ScriptableRenderer GetRenderer(int index)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2D04EA8", Offset = "0x2D00EA8", VA = "0x2D04EA8")]
		internal int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier)
		{
			return default(int);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2D05738", Offset = "0x2D01738", VA = "0x2D05738", Slot = "28")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2D0573C", Offset = "0x2D0173C", VA = "0x2D0573C", Slot = "29")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2D050F4", Offset = "0x2D010F4", VA = "0x2D050F4")]
		private float ValidateShadowBias(float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2D04DB8", Offset = "0x2D00DB8", VA = "0x2D04DB8")]
		private int ValidatePerObjectLights(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2D04C8C", Offset = "0x2D00C8C", VA = "0x2D04C8C")]
		private float ValidateRenderScale(float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2D05950", Offset = "0x2D01950", VA = "0x2D05950")]
		internal bool ValidateRendererDataList(bool partial = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2D059D0", Offset = "0x2D019D0", VA = "0x2D059D0")]
		internal bool ValidateRendererData(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2D05C20", Offset = "0x2D01C20", VA = "0x2D05C20")]
		public UniversalRenderPipelineAsset()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class UniversalRenderPipelineEditorResources : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200007C")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Reload("Shaders/AutodeskInteractive/AutodeskInteractive.shadergraph", ReloadAttribute.Package.Root)]
			public Shader autodeskInteractivePS;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Reload("Shaders/AutodeskInteractive/AutodeskInteractiveTransparent.shadergraph", ReloadAttribute.Package.Root)]
			public Shader autodeskInteractiveTransparentPS;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Reload("Shaders/AutodeskInteractive/AutodeskInteractiveMasked.shadergraph", ReloadAttribute.Package.Root)]
			public Shader autodeskInteractiveMaskedPS;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Reload("Shaders/Nature/SpeedTree7.shader", ReloadAttribute.Package.Root)]
			public Shader defaultSpeedTree7PS;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Reload("Shaders/Nature/SpeedTree8_PBRLit.shadergraph", ReloadAttribute.Package.Root)]
			public Shader defaultSpeedTree8PS;

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x2D0600C", Offset = "0x2D0200C", VA = "0x2D0600C")]
			public ShaderResources()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		[ReloadGroup]
		public sealed class MaterialResources
		{
			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Reload("Runtime/Materials/Lit.mat", ReloadAttribute.Package.Root)]
			public Material lit;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Reload("Runtime/Materials/ParticlesUnlit.mat", ReloadAttribute.Package.Root)]
			public Material particleLit;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Reload("Runtime/Materials/TerrainLit.mat", ReloadAttribute.Package.Root)]
			public Material terrainLit;

			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Reload("Runtime/Materials/Decal.mat", ReloadAttribute.Package.Root)]
			public Material decal;

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x2D06014", Offset = "0x2D02014", VA = "0x2D06014")]
			public MaterialResources()
			{
			}
		}

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShaderResources shaders;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MaterialResources materials;

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2D06004", Offset = "0x2D02004", VA = "0x2D06004")]
		public UniversalRenderPipelineEditorResources()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class XRSystemData : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200007F")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Reload("Shaders/XR/XROcclusionMesh.shader", ReloadAttribute.Package.Root)]
			public Shader xrOcclusionMeshPS;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Reload("Shaders/XR/XRMirrorView.shader", ReloadAttribute.Package.Root)]
			public Shader xrMirrorViewPS;

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x2D06024", Offset = "0x2D02024", VA = "0x2D06024")]
			public ShaderResources()
			{
			}
		}

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShaderResources shaders;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x2D0601C", Offset = "0x2D0201C", VA = "0x2D0601C")]
		public XRSystemData()
		{
		}
	}
	[Token(Token = "0x2000080")]
	internal class DebugDisplaySettingsCommon : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		[Token(Token = "0x2000081")]
		internal static class WidgetFactory
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x2D06344", Offset = "0x2D02344", VA = "0x2D06344")]
			internal static DebugUI.Widget CreateMissingDebugShadersWarning()
			{
				return null;
			}
		}

		[Token(Token = "0x2000083")]
		[DisplayInfo(name = "Frequently Used", order = -1)]
		private class SettingsPanel : DebugDisplaySettingsPanel
		{
			[Token(Token = "0x4000307")]
			private const string k_GoToSectionString = "Go to Section...";

			[Token(Token = "0x170000E3")]
			public override DebugUI.Flags Flags
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0x2D06598", Offset = "0x2D02598", VA = "0x2D06598", Slot = "10")]
				get
				{
					return default(DebugUI.Flags);
				}
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0x2D0609C", Offset = "0x2D0209C", VA = "0x2D0609C")]
			public SettingsPanel()
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public bool AreAnySettingsActive
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x2D0602C", Offset = "0x2D0202C", VA = "0x2D0602C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E1")]
		public bool IsPostProcessingAllowed
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x2D06034", Offset = "0x2D02034", VA = "0x2D06034", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E2")]
		public bool IsLightingActive
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x2D0603C", Offset = "0x2D0203C", VA = "0x2D0603C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2D06044", Offset = "0x2D02044", VA = "0x2D06044", Slot = "8")]
		public bool TryGetScreenClearColor(ref Color _)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x2D0604C", Offset = "0x2D0204C", VA = "0x2D0604C", Slot = "4")]
		public IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x2D0633C", Offset = "0x2D0233C", VA = "0x2D0633C")]
		public DebugDisplaySettingsCommon()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class DebugDisplaySettingsLighting : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		[Token(Token = "0x2000086")]
		internal static class Strings
		{
			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DebugUI.Widget.NameAndTooltip LightingDebugMode;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly DebugUI.Widget.NameAndTooltip LightingFeatures;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly DebugUI.Widget.NameAndTooltip HDRDebugMode;
		}

		[Token(Token = "0x2000087")]
		internal static class WidgetFactory
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x2D0699C", Offset = "0x2D0299C", VA = "0x2D0699C")]
			internal static DebugUI.Widget CreateLightingDebugMode(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x2D06BF8", Offset = "0x2D02BF8", VA = "0x2D06BF8")]
			internal static DebugUI.Widget CreateLightingFeatures(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x2D06DE4", Offset = "0x2D02DE4", VA = "0x2D06DE4")]
			internal static DebugUI.Widget CreateHDRDebugMode(SettingsPanel panel)
			{
				return null;
			}
		}

		[Token(Token = "0x200008B")]
		[DisplayInfo(name = "Lighting", order = 3)]
		internal class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsLighting>
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x2D06744", Offset = "0x2D02744", VA = "0x2D06744")]
			public SettingsPanel(DebugDisplaySettingsLighting data)
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public DebugLightingMode lightingDebugMode
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x2D06670", Offset = "0x2D02670", VA = "0x2D06670")]
			[CompilerGenerated]
			get
			{
				return default(DebugLightingMode);
			}
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x2D06678", Offset = "0x2D02678", VA = "0x2D06678")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public DebugLightingFeatureFlags lightingFeatureFlags
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x2D06680", Offset = "0x2D02680", VA = "0x2D06680")]
			[CompilerGenerated]
			get
			{
				return default(DebugLightingFeatureFlags);
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x2D06688", Offset = "0x2D02688", VA = "0x2D06688")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public HDRDebugMode hdrDebugMode
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x2D06690", Offset = "0x2D02690", VA = "0x2D06690")]
			[CompilerGenerated]
			get
			{
				return default(HDRDebugMode);
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x2D06698", Offset = "0x2D02698", VA = "0x2D06698")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public bool AreAnySettingsActive
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x2D066A0", Offset = "0x2D026A0", VA = "0x2D066A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E8")]
		public bool IsPostProcessingAllowed
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x2D066C8", Offset = "0x2D026C8", VA = "0x2D066C8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		public bool IsLightingActive
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x2D066DC", Offset = "0x2D026DC", VA = "0x2D066DC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2D066E4", Offset = "0x2D026E4", VA = "0x2D066E4", Slot = "8")]
		public bool TryGetScreenClearColor(ref Color color)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2D066EC", Offset = "0x2D026EC", VA = "0x2D066EC", Slot = "4")]
		private IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel()
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x2D06890", Offset = "0x2D02890", VA = "0x2D06890")]
		public DebugDisplaySettingsLighting()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class DebugDisplaySettingsMaterial : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		[Token(Token = "0x200008D")]
		public enum AlbedoDebugValidationPreset
		{
			[Token(Token = "0x400031F")]
			DefaultLuminance,
			[Token(Token = "0x4000320")]
			BlackAcrylicPaint,
			[Token(Token = "0x4000321")]
			DarkSoil,
			[Token(Token = "0x4000322")]
			WornAsphalt,
			[Token(Token = "0x4000323")]
			DryClaySoil,
			[Token(Token = "0x4000324")]
			GreenGrass,
			[Token(Token = "0x4000325")]
			OldConcrete,
			[Token(Token = "0x4000326")]
			RedClayTile,
			[Token(Token = "0x4000327")]
			DrySand,
			[Token(Token = "0x4000328")]
			NewConcrete,
			[Token(Token = "0x4000329")]
			WhiteAcrylicPaint,
			[Token(Token = "0x400032A")]
			FreshSnow,
			[Token(Token = "0x400032B")]
			BlueSky,
			[Token(Token = "0x400032C")]
			Foliage,
			[Token(Token = "0x400032D")]
			Custom
		}

		[Token(Token = "0x200008E")]
		private struct AlbedoDebugValidationPresetData
		{
			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Color color;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float minLuminance;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float maxLuminance;
		}

		[Token(Token = "0x200008F")]
		private static class Strings
		{
			[Token(Token = "0x4000332")]
			public const string AlbedoSettingsContainerName = "Albedo Settings";

			[Token(Token = "0x4000333")]
			public const string MetallicSettingsContainerName = "Metallic Settings";

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DebugUI.Widget.NameAndTooltip MaterialOverride;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly DebugUI.Widget.NameAndTooltip VertexAttribute;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly DebugUI.Widget.NameAndTooltip MaterialValidationMode;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static readonly DebugUI.Widget.NameAndTooltip ValidationPreset;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static readonly DebugUI.Widget.NameAndTooltip AlbedoCustomColor;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static readonly DebugUI.Widget.NameAndTooltip AlbedoMinLuminance;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static readonly DebugUI.Widget.NameAndTooltip AlbedoMaxLuminance;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static readonly DebugUI.Widget.NameAndTooltip AlbedoHueTolerance;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static readonly DebugUI.Widget.NameAndTooltip AlbedoSaturationTolerance;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static readonly DebugUI.Widget.NameAndTooltip MetallicMinValue;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static readonly DebugUI.Widget.NameAndTooltip MetallicMaxValue;
		}

		[Token(Token = "0x2000090")]
		internal static class WidgetFactory
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x2D08244", Offset = "0x2D04244", VA = "0x2D08244")]
			internal static DebugUI.Widget CreateMaterialOverride(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x2D084A0", Offset = "0x2D044A0", VA = "0x2D084A0")]
			internal static DebugUI.Widget CreateVertexAttribute(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x2D086FC", Offset = "0x2D046FC", VA = "0x2D086FC")]
			internal static DebugUI.Widget CreateMaterialValidationMode(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x2D089F8", Offset = "0x2D049F8", VA = "0x2D089F8")]
			internal static DebugUI.Widget CreateAlbedoPreset(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0x2D08CF4", Offset = "0x2D04CF4", VA = "0x2D08CF4")]
			internal static DebugUI.Widget CreateAlbedoCustomColor(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x2D08ED0", Offset = "0x2D04ED0", VA = "0x2D08ED0")]
			internal static DebugUI.Widget CreateAlbedoMinLuminance(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x2D09068", Offset = "0x2D05068", VA = "0x2D09068")]
			internal static DebugUI.Widget CreateAlbedoMaxLuminance(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x2D09200", Offset = "0x2D05200", VA = "0x2D09200")]
			internal static DebugUI.Widget CreateAlbedoHueTolerance(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x2D093E8", Offset = "0x2D053E8", VA = "0x2D093E8")]
			internal static DebugUI.Widget CreateAlbedoSaturationTolerance(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x2D095D0", Offset = "0x2D055D0", VA = "0x2D095D0")]
			internal static DebugUI.Widget CreateMetallicMinValue(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x2D09768", Offset = "0x2D05768", VA = "0x2D09768")]
			internal static DebugUI.Widget CreateMetallicMaxValue(SettingsPanel panel)
			{
				return null;
			}
		}

		[Token(Token = "0x200009D")]
		[DisplayInfo(name = "Material", order = 2)]
		internal class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsMaterial>
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x2D075C4", Offset = "0x2D035C4", VA = "0x2D075C4")]
			public SettingsPanel(DebugDisplaySettingsMaterial data)
			{
			}
		}

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AlbedoDebugValidationPresetData[] m_AlbedoDebugValidationPresetData;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AlbedoDebugValidationPreset m_AlbedoValidationPreset;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_AlbedoHueTolerance;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_AlbedoSaturationTolerance;

		[Token(Token = "0x170000EA")]
		public AlbedoDebugValidationPreset albedoValidationPreset
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x2D073D8", Offset = "0x2D033D8", VA = "0x2D073D8")]
			get
			{
				return default(AlbedoDebugValidationPreset);
			}
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x2D073E0", Offset = "0x2D033E0", VA = "0x2D073E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public float albedoMinLuminance
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x2D07424", Offset = "0x2D03424", VA = "0x2D07424")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x2D0742C", Offset = "0x2D0342C", VA = "0x2D0742C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public float albedoMaxLuminance
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x2D07434", Offset = "0x2D03434", VA = "0x2D07434")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x2D0743C", Offset = "0x2D0343C", VA = "0x2D0743C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public float albedoHueTolerance
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x2D07444", Offset = "0x2D03444", VA = "0x2D07444")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x2D0745C", Offset = "0x2D0345C", VA = "0x2D0745C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public float albedoSaturationTolerance
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x2D07464", Offset = "0x2D03464", VA = "0x2D07464")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x2D0747C", Offset = "0x2D0347C", VA = "0x2D0747C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public Color albedoCompareColor
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x2D07484", Offset = "0x2D03484", VA = "0x2D07484")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x2D07490", Offset = "0x2D03490", VA = "0x2D07490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public float metallicMinValue
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x2D0749C", Offset = "0x2D0349C", VA = "0x2D0749C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x2D074A4", Offset = "0x2D034A4", VA = "0x2D074A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public float metallicMaxValue
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x2D074AC", Offset = "0x2D034AC", VA = "0x2D074AC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x2D074B4", Offset = "0x2D034B4", VA = "0x2D074B4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public DebugMaterialValidationMode materialValidationMode
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x2D074BC", Offset = "0x2D034BC", VA = "0x2D074BC")]
			[CompilerGenerated]
			get
			{
				return default(DebugMaterialValidationMode);
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x2D074C4", Offset = "0x2D034C4", VA = "0x2D074C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public DebugMaterialMode materialDebugMode
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x2D074CC", Offset = "0x2D034CC", VA = "0x2D074CC")]
			[CompilerGenerated]
			get
			{
				return default(DebugMaterialMode);
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x2D074D4", Offset = "0x2D034D4", VA = "0x2D074D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public DebugVertexAttributeMode vertexAttributeDebugMode
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x2D074DC", Offset = "0x2D034DC", VA = "0x2D074DC")]
			[CompilerGenerated]
			get
			{
				return default(DebugVertexAttributeMode);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x2D074E4", Offset = "0x2D034E4", VA = "0x2D074E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public bool AreAnySettingsActive
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x2D074EC", Offset = "0x2D034EC", VA = "0x2D074EC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F6")]
		public bool IsPostProcessingAllowed
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x2D07514", Offset = "0x2D03514", VA = "0x2D07514", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F7")]
		public bool IsLightingActive
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x2D0753C", Offset = "0x2D0353C", VA = "0x2D0753C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x2D07564", Offset = "0x2D03564", VA = "0x2D07564", Slot = "8")]
		public bool TryGetScreenClearColor(ref Color color)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x2D0756C", Offset = "0x2D0356C", VA = "0x2D0756C", Slot = "4")]
		private IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel()
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x2D079CC", Offset = "0x2D039CC", VA = "0x2D079CC")]
		public DebugDisplaySettingsMaterial()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public enum DebugWireframeMode
	{
		[Token(Token = "0x400034F")]
		None,
		[Token(Token = "0x4000350")]
		Wireframe,
		[Token(Token = "0x4000351")]
		SolidWireframe,
		[Token(Token = "0x4000352")]
		ShadedWireframe
	}
	[Token(Token = "0x20000A0")]
	public class DebugDisplaySettingsRendering : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		[Token(Token = "0x20000A1")]
		public enum TaaDebugMode
		{
			[Token(Token = "0x4000364")]
			None,
			[Token(Token = "0x4000365")]
			ShowRawFrame,
			[Token(Token = "0x4000366")]
			ShowRawFrameNoJitter,
			[Token(Token = "0x4000367")]
			ShowClampedHistory
		}

		[Token(Token = "0x20000A2")]
		private static class Strings
		{
			[Token(Token = "0x4000368")]
			public const string RangeValidationSettingsContainerName = "Pixel Range Settings";

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DebugUI.Widget.NameAndTooltip MapOverlays;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly DebugUI.Widget.NameAndTooltip MapSize;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly DebugUI.Widget.NameAndTooltip AdditionalWireframeModes;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static readonly DebugUI.Widget.NameAndTooltip WireframeNotSupportedWarning;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static readonly DebugUI.Widget.NameAndTooltip OverdrawMode;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static readonly DebugUI.Widget.NameAndTooltip MaxOverdrawCount;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static readonly DebugUI.Widget.NameAndTooltip PostProcessing;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static readonly DebugUI.Widget.NameAndTooltip MSAA;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static readonly DebugUI.Widget.NameAndTooltip HDR;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static readonly DebugUI.Widget.NameAndTooltip TaaDebugMode;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static readonly DebugUI.Widget.NameAndTooltip PixelValidationMode;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static readonly DebugUI.Widget.NameAndTooltip Channels;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static readonly DebugUI.Widget.NameAndTooltip ValueRangeMin;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static readonly DebugUI.Widget.NameAndTooltip ValueRangeMax;
		}

		[Token(Token = "0x20000A3")]
		internal static class WidgetFactory
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x2D0B0AC", Offset = "0x2D070AC", VA = "0x2D0B0AC")]
			internal static DebugUI.Widget CreateMapOverlays(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x2D0B308", Offset = "0x2D07308", VA = "0x2D0B308")]
			internal static DebugUI.Widget CreateMapOverlaySize(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x2D0B604", Offset = "0x2D07604", VA = "0x2D0B604")]
			internal static DebugUI.Widget CreateAdditionalWireframeShaderViews(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x2D0B900", Offset = "0x2D07900", VA = "0x2D0B900")]
			internal static DebugUI.Widget CreateWireframeNotSupportedWarning(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x2D0BA2C", Offset = "0x2D07A2C", VA = "0x2D0BA2C")]
			internal static DebugUI.Widget CreateOverdrawMode(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x2D0BC88", Offset = "0x2D07C88", VA = "0x2D0BC88")]
			internal static DebugUI.Widget CreateMaxOverdrawCount(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x2D0BFCC", Offset = "0x2D07FCC", VA = "0x2D0BFCC")]
			internal static DebugUI.Widget CreatePostProcessing(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x2D0C228", Offset = "0x2D08228", VA = "0x2D0C228")]
			internal static DebugUI.Widget CreateMSAA(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x2D0C3B4", Offset = "0x2D083B4", VA = "0x2D0C3B4")]
			internal static DebugUI.Widget CreateHDR(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x2D0C540", Offset = "0x2D08540", VA = "0x2D0C540")]
			internal static DebugUI.Widget CreateTaaDebugMode(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x2D0C83C", Offset = "0x2D0883C", VA = "0x2D0C83C")]
			internal static DebugUI.Widget CreatePixelValidationMode(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x2D0CB38", Offset = "0x2D08B38", VA = "0x2D0CB38")]
			internal static DebugUI.Widget CreatePixelValidationChannels(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x2D0CD94", Offset = "0x2D08D94", VA = "0x2D0CD94")]
			internal static DebugUI.Widget CreatePixelValueRangeMin(SettingsPanel panel)
			{
				return null;
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x2D0CF2C", Offset = "0x2D08F2C", VA = "0x2D0CF2C")]
			internal static DebugUI.Widget CreatePixelValueRangeMax(SettingsPanel panel)
			{
				return null;
			}
		}

		[Token(Token = "0x20000B3")]
		[DisplayInfo(name = "Rendering", order = 1)]
		internal class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsRendering>
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x2D0A8B8", Offset = "0x2D068B8", VA = "0x2D0A8B8")]
			public SettingsPanel(DebugDisplaySettingsRendering data)
			{
			}
		}

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DebugWireframeMode m_WireframeMode;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool m_Overdraw;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DebugOverdrawMode m_OverdrawMode;

		[Token(Token = "0x170000F8")]
		public DebugWireframeMode wireframeMode
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x2D0A584", Offset = "0x2D06584", VA = "0x2D0A584")]
			get
			{
				return default(DebugWireframeMode);
			}
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x2D0A58C", Offset = "0x2D0658C", VA = "0x2D0A58C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		[Obsolete("overdraw has been deprecated. Use overdrawMode instead.", false)]
		public bool overdraw
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x2D0A5E4", Offset = "0x2D065E4", VA = "0x2D0A5E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x2D0A5EC", Offset = "0x2D065EC", VA = "0x2D0A5EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public DebugOverdrawMode overdrawMode
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x2D0A61C", Offset = "0x2D0661C", VA = "0x2D0A61C")]
			get
			{
				return default(DebugOverdrawMode);
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x2D0A624", Offset = "0x2D06624", VA = "0x2D0A624")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public int maxOverdrawCount
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x2D0A648", Offset = "0x2D06648", VA = "0x2D0A648")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x2D0A650", Offset = "0x2D06650", VA = "0x2D0A650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public DebugFullScreenMode fullScreenDebugMode
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x2D0A658", Offset = "0x2D06658", VA = "0x2D0A658")]
			[CompilerGenerated]
			get
			{
				return default(DebugFullScreenMode);
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x2D0A660", Offset = "0x2D06660", VA = "0x2D0A660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public int fullScreenDebugModeOutputSizeScreenPercent
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x2D0A668", Offset = "0x2D06668", VA = "0x2D0A668")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x2D0A670", Offset = "0x2D06670", VA = "0x2D0A670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		internal DebugSceneOverrideMode sceneOverrideMode
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x2D0A678", Offset = "0x2D06678", VA = "0x2D0A678")]
			[CompilerGenerated]
			get
			{
				return default(DebugSceneOverrideMode);
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x2D0A680", Offset = "0x2D06680", VA = "0x2D0A680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		internal DebugMipInfoMode mipInfoMode
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x2D0A688", Offset = "0x2D06688", VA = "0x2D0A688")]
			[CompilerGenerated]
			get
			{
				return default(DebugMipInfoMode);
			}
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x2D0A690", Offset = "0x2D06690", VA = "0x2D0A690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public DebugPostProcessingMode postProcessingDebugMode
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x2D0A698", Offset = "0x2D06698", VA = "0x2D0A698")]
			[CompilerGenerated]
			get
			{
				return default(DebugPostProcessingMode);
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x2D0A6A0", Offset = "0x2D066A0", VA = "0x2D0A6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public bool enableMsaa
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x2D0A6A8", Offset = "0x2D066A8", VA = "0x2D0A6A8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x2D0A6B0", Offset = "0x2D066B0", VA = "0x2D0A6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public bool enableHDR
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x2D0A6B8", Offset = "0x2D066B8", VA = "0x2D0A6B8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x2D0A6C0", Offset = "0x2D066C0", VA = "0x2D0A6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public TaaDebugMode taaDebugMode
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x2D0A6C8", Offset = "0x2D066C8", VA = "0x2D0A6C8")]
			[CompilerGenerated]
			get
			{
				return default(TaaDebugMode);
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x2D0A6D0", Offset = "0x2D066D0", VA = "0x2D0A6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public DebugValidationMode validationMode
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x2D0A6D8", Offset = "0x2D066D8", VA = "0x2D0A6D8")]
			[CompilerGenerated]
			get
			{
				return default(DebugValidationMode);
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x2D0A6E0", Offset = "0x2D066E0", VA = "0x2D0A6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public PixelValidationChannels validationChannels
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x2D0A6E8", Offset = "0x2D066E8", VA = "0x2D0A6E8")]
			[CompilerGenerated]
			get
			{
				return default(PixelValidationChannels);
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x2D0A6F0", Offset = "0x2D066F0", VA = "0x2D0A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public float validationRangeMin
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x2D0A6F8", Offset = "0x2D066F8", VA = "0x2D0A6F8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x2D0A700", Offset = "0x2D06700", VA = "0x2D0A700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public float validationRangeMax
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x2D0A708", Offset = "0x2D06708", VA = "0x2D0A708")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x2D0A710", Offset = "0x2D06710", VA = "0x2D0A710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool AreAnySettingsActive
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x2D0A718", Offset = "0x2D06718", VA = "0x2D0A718", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000109")]
		public bool IsPostProcessingAllowed
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x2D0A76C", Offset = "0x2D0676C", VA = "0x2D0A76C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010A")]
		public bool IsLightingActive
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x2D0A794", Offset = "0x2D06794", VA = "0x2D0A794", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2D0A5B8", Offset = "0x2D065B8", VA = "0x2D0A5B8")]
		private void UpdateDebugSceneOverrideMode()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2D0A7B4", Offset = "0x2D067B4", VA = "0x2D0A7B4", Slot = "8")]
		public bool TryGetScreenClearColor(ref Color color)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2D0A860", Offset = "0x2D06860", VA = "0x2D0A860", Slot = "4")]
		private IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel()
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2D0AC90", Offset = "0x2D06C90", VA = "0x2D0AC90")]
		public DebugDisplaySettingsRendering()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	internal class DebugDisplayStats : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		[Token(Token = "0x20000B6")]
		[DisplayInfo(name = "Display Stats", order = int.MinValue)]
		private class StatsPanel : DebugDisplaySettingsPanel
		{
			[Token(Token = "0x1700010E")]
			public override DebugUI.Flags Flags
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x2D0E358", Offset = "0x2D0A358", VA = "0x2D0E358", Slot = "10")]
				get
				{
					return default(DebugUI.Flags);
				}
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x2D0E168", Offset = "0x2D0A168", VA = "0x2D0E168")]
			public StatsPanel(DebugFrameTiming frameTiming)
			{
			}
		}

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DebugFrameTiming m_DebugFrameTiming;

		[Token(Token = "0x1700010B")]
		public bool AreAnySettingsActive
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2D0E0EC", Offset = "0x2D0A0EC", VA = "0x2D0E0EC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010C")]
		public bool IsPostProcessingAllowed
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x2D0E0F4", Offset = "0x2D0A0F4", VA = "0x2D0E0F4", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010D")]
		public bool IsLightingActive
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x2D0E0FC", Offset = "0x2D0A0FC", VA = "0x2D0E0FC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2D0E0D4", Offset = "0x2D0A0D4", VA = "0x2D0E0D4")]
		public void UpdateFrameTiming()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x2D0E104", Offset = "0x2D0A104", VA = "0x2D0E104", Slot = "8")]
		public bool TryGetScreenClearColor(ref Color _)
		{
			return default(bool);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2D0E10C", Offset = "0x2D0A10C", VA = "0x2D0E10C", Slot = "4")]
		public IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2D0E2F8", Offset = "0x2D0A2F8", VA = "0x2D0E2F8")]
		public DebugDisplayStats()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	internal class DebugHandler : IDebugDisplaySettingsQuery
	{
		[Token(Token = "0x20000B8")]
		private class DebugRenderPassEnumerable : IEnumerable<DebugRenderSetup>, IEnumerable
		{
			[Token(Token = "0x20000B9")]
			private class Enumerator : IEnumerator<DebugRenderSetup>, IEnumerator, IDisposable
			{
				[Token(Token = "0x40003B9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private readonly DebugHandler m_DebugHandler;

				[Token(Token = "0x40003BA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private readonly ScriptableRenderContext m_Context;

				[Token(Token = "0x40003BB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private readonly CommandBuffer m_CommandBuffer;

				[Token(Token = "0x40003BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private readonly FilteringSettings m_FilteringSettings;

				[Token(Token = "0x40003BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private readonly int m_NumIterations;

				[Token(Token = "0x40003BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
				private int m_Index;

				[Token(Token = "0x1700011D")]
				public DebugRenderSetup Current
				{
					[Token(Token = "0x6000463")]
					[Address(RVA = "0x2D102E8", Offset = "0x2D0C2E8", VA = "0x2D102E8", Slot = "4")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x6000464")]
					[Address(RVA = "0x2D102F0", Offset = "0x2D0C2F0", VA = "0x2D102F0")]
					[CompilerGenerated]
					private set
					{
					}
				}

				[Token(Token = "0x1700011E")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000465")]
					[Address(RVA = "0x2D102F8", Offset = "0x2D0C2F8", VA = "0x2D102F8", Slot = "7")]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000466")]
				[Address(RVA = "0x2D10260", Offset = "0x2D0C260", VA = "0x2D10260")]
				public Enumerator(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, FilteringSettings filteringSettings)
				{
				}

				[Token(Token = "0x6000467")]
				[Address(RVA = "0x2D10300", Offset = "0x2D0C300", VA = "0x2D10300", Slot = "6")]
				public bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x6000468")]
				[Address(RVA = "0x2D10434", Offset = "0x2D0C434", VA = "0x2D10434", Slot = "8")]
				public void Reset()
				{
				}

				[Token(Token = "0x6000469")]
				[Address(RVA = "0x2D1045C", Offset = "0x2D0C45C", VA = "0x2D1045C", Slot = "5")]
				public void Dispose()
				{
				}
			}

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly DebugHandler m_DebugHandler;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly ScriptableRenderContext m_Context;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly CommandBuffer m_CommandBuffer;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly FilteringSettings m_FilteringSettings;

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x2D0F358", Offset = "0x2D0B358", VA = "0x2D0F358")]
			public DebugRenderPassEnumerable(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, FilteringSettings filteringSettings)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x2D101D4", Offset = "0x2D0C1D4", VA = "0x2D101D4", Slot = "4")]
			public IEnumerator<DebugRenderSetup> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x2D102E4", Offset = "0x2D0C2E4", VA = "0x2D102E4", Slot = "5")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000BA")]
		internal delegate void DrawFunction(ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock);

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int k_DebugColorInvalidModePropertyId;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int k_DebugColorPropertyId;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int k_DebugTexturePropertyId;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int k_DebugTextureNoStereoPropertyId;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int k_DebugTextureDisplayRect;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int k_DebugRenderTargetSupportsStereo;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int k_DebugMaterialModeId;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int k_DebugVertexAttributeModeId;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int k_DebugMaterialValidationModeId;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int k_DebugMipInfoModeId;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int k_DebugSceneOverrideModeId;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly int k_DebugFullScreenModeId;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly int k_DebugValidationModeId;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static readonly int k_DebugValidateBelowMinThresholdColorPropertyId;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly int k_DebugValidateAboveMaxThresholdColorPropertyId;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static readonly int k_DebugMaxPixelCost;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly int k_DebugLightingModeId;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static readonly int k_DebugLightingFeatureFlagsId;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly int k_DebugValidateAlbedoMinLuminanceId;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private static readonly int k_DebugValidateAlbedoMaxLuminanceId;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly int k_DebugValidateAlbedoSaturationToleranceId;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static readonly int k_DebugValidateAlbedoHueToleranceId;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly int k_DebugValidateAlbedoCompareColorId;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static readonly int k_DebugValidateMetallicMinValueId;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly int k_DebugValidateMetallicMaxValueId;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private static readonly int k_ValidationChannelsId;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly int k_RangeMinimumId;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private static readonly int k_RangeMaximumId;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Material m_ReplacementMaterial;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Material m_HDRDebugViewMaterial;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HDRDebugViewPass m_HDRDebugViewPass;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RTHandle m_DebugScreenColorHandle;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RTHandle m_DebugScreenDepthHandle;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_HasDebugRenderTarget;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool m_DebugRenderTargetSupportsStereo;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector4 m_DebugRenderTargetPixelRect;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RenderTargetIdentifier m_DebugRenderTargetIdentifier;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly UniversalRenderPipelineDebugDisplaySettings m_DebugDisplaySettings;

		[Token(Token = "0x1700010F")]
		private DebugDisplaySettingsLighting LightingSettings
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x2D0E360", Offset = "0x2D0A360", VA = "0x2D0E360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000110")]
		private DebugDisplaySettingsMaterial MaterialSettings
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x2D0E378", Offset = "0x2D0A378", VA = "0x2D0E378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		private DebugDisplaySettingsRendering RenderingSettings
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x2D0E390", Offset = "0x2D0A390", VA = "0x2D0E390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		public bool AreAnySettingsActive
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x2D0E3A8", Offset = "0x2D0A3A8", VA = "0x2D0E3A8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000113")]
		public bool IsPostProcessingAllowed
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x2D0E3C4", Offset = "0x2D0A3C4", VA = "0x2D0E3C4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000114")]
		public bool IsLightingActive
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x2D0E3E0", Offset = "0x2D0A3E0", VA = "0x2D0E3E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000115")]
		internal bool IsActiveModeUnsupportedForDeferred
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x2D0E3FC", Offset = "0x2D0A3FC", VA = "0x2D0E3FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000116")]
		internal Material ReplacementMaterial
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x2D0E488", Offset = "0x2D0A488", VA = "0x2D0E488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000117")]
		internal UniversalRenderPipelineDebugDisplaySettings DebugDisplaySettings
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x2D0E490", Offset = "0x2D0A490", VA = "0x2D0E490")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000118")]
		internal unsafe ref RTHandle DebugScreenColorHandle
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x2D0E498", Offset = "0x2D0A498", VA = "0x2D0E498")]
			get
			{
				return ref *(RTHandle*)null;
			}
		}

		[Token(Token = "0x17000119")]
		internal unsafe ref RTHandle DebugScreenDepthHandle
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x2D0E4A0", Offset = "0x2D0A4A0", VA = "0x2D0E4A0")]
			get
			{
				return ref *(RTHandle*)null;
			}
		}

		[Token(Token = "0x1700011A")]
		internal HDRDebugViewPass hdrDebugViewPass
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x2D0E4A8", Offset = "0x2D0A4A8", VA = "0x2D0E4A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011B")]
		internal bool IsScreenClearNeeded
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x2D0E4E8", Offset = "0x2D0A4E8", VA = "0x2D0E4E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		internal bool IsRenderPassSupported
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x2D0E524", Offset = "0x2D0A524", VA = "0x2D0E524")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x2D0E468", Offset = "0x2D0A468", VA = "0x2D0E468", Slot = "7")]
		public bool TryGetScreenClearColor(ref Color color)
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x2D0E4B0", Offset = "0x2D0A4B0", VA = "0x2D0E4B0")]
		internal bool HDRDebugViewIsActive(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x2D0E4E4", Offset = "0x2D0A4E4", VA = "0x2D0E4E4")]
		internal bool WriteToDebugScreenTexture(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x2D0E550", Offset = "0x2D0A550", VA = "0x2D0E550")]
		internal DebugHandler(ScriptableRendererData scriptableRendererData)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2D0E6EC", Offset = "0x2D0A6EC", VA = "0x2D0E6EC")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2D0E788", Offset = "0x2D0A788", VA = "0x2D0E788")]
		internal bool IsActiveForCamera(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2D0E7C8", Offset = "0x2D0A7C8", VA = "0x2D0E7C8")]
		internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2D0E7E0", Offset = "0x2D0A7E0", VA = "0x2D0E7E0")]
		internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode, out int textureHeightPercent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2D0E81C", Offset = "0x2D0A81C", VA = "0x2D0E81C")]
		internal static void ConfigureColorDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2D0E868", Offset = "0x2D0A868", VA = "0x2D0E868")]
		internal static void ConfigureDepthDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2D0E8C0", Offset = "0x2D0A8C0", VA = "0x2D0E8C0")]
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal void SetupShaderProperties(CommandBuffer cmd, int passIndex = 0)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2D0ED24", Offset = "0x2D0AD24", VA = "0x2D0ED24")]
		internal void SetDebugRenderTarget(RenderTargetIdentifier renderTargetIdentifier, Rect displayRect, bool supportsStereo)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2D0ED4C", Offset = "0x2D0AD4C", VA = "0x2D0ED4C")]
		internal void ResetDebugRenderTarget()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2D0ED54", Offset = "0x2D0AD54", VA = "0x2D0ED54")]
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal void UpdateShaderGlobalPropertiesForFinalValidationPass(CommandBuffer cmd, ref CameraData cameraData, bool isFinalPass)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2D0EF60", Offset = "0x2D0AF60", VA = "0x2D0EF60")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		internal void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2D0F2B4", Offset = "0x2D0B2B4", VA = "0x2D0F2B4")]
		internal IEnumerable<DebugRenderSetup> CreateDebugRenderSetupEnumerable(ScriptableRenderContext context, CommandBuffer commandBuffer, FilteringSettings filteringSettings)
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2D0F3A8", Offset = "0x2D0B3A8", VA = "0x2D0F3A8")]
		internal void DrawWithDebugRenderState(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, DrawFunction func)
		{
		}
	}
	[Token(Token = "0x20000BB")]
	internal class DebugRenderSetup : IDisposable
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DebugHandler m_DebugHandler;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ScriptableRenderContext m_Context;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly CommandBuffer m_CommandBuffer;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly int m_Index;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private readonly FilteringSettings m_FilteringSettings;

		[Token(Token = "0x1700011F")]
		private DebugDisplaySettingsMaterial MaterialSettings
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x2D10680", Offset = "0x2D0C680", VA = "0x2D10680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000120")]
		private DebugDisplaySettingsRendering RenderingSettings
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x2D106A4", Offset = "0x2D0C6A4", VA = "0x2D106A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		private DebugDisplaySettingsLighting LightingSettings
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x2D106C8", Offset = "0x2D0C6C8", VA = "0x2D106C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x2D106EC", Offset = "0x2D0C6EC", VA = "0x2D106EC")]
		private void Begin()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x2D107CC", Offset = "0x2D0C7CC", VA = "0x2D107CC")]
		private void End()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x2D103D0", Offset = "0x2D0C3D0", VA = "0x2D103D0")]
		internal DebugRenderSetup(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, int index, FilteringSettings filteringSettings)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x2D0F7F8", Offset = "0x2D0B7F8", VA = "0x2D0F7F8")]
		internal DrawingSettings CreateDrawingSettings(DrawingSettings drawingSettings)
		{
			return default(DrawingSettings);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x2D0F930", Offset = "0x2D0B930", VA = "0x2D0F930")]
		internal RenderStateBlock GetRenderStateBlock(RenderStateBlock renderStateBlock)
		{
			return default(RenderStateBlock);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x2D103CC", Offset = "0x2D0C3CC", VA = "0x2D103CC", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class UniversalRenderPipelineDebugDisplaySettings : DebugDisplaySettings<UniversalRenderPipelineDebugDisplaySettings>
	{
		[Token(Token = "0x17000122")]
		private DebugDisplaySettingsCommon commonSettings
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x2D10874", Offset = "0x2D0C874", VA = "0x2D10874")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x2D1087C", Offset = "0x2D0C87C", VA = "0x2D1087C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public DebugDisplaySettingsMaterial materialSettings
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x2D10884", Offset = "0x2D0C884", VA = "0x2D10884")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x2D1088C", Offset = "0x2D0C88C", VA = "0x2D1088C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public DebugDisplaySettingsRendering renderingSettings
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x2D10894", Offset = "0x2D0C894", VA = "0x2D10894")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x2D1089C", Offset = "0x2D0C89C", VA = "0x2D1089C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public DebugDisplaySettingsLighting lightingSettings
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x2D108A4", Offset = "0x2D0C8A4", VA = "0x2D108A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x2D108AC", Offset = "0x2D0C8AC", VA = "0x2D108AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public DebugDisplaySettingsVolume volumeSettings
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x2D108B4", Offset = "0x2D0C8B4", VA = "0x2D108B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x2D108BC", Offset = "0x2D0C8BC", VA = "0x2D108BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000127")]
		internal DebugDisplayStats displayStats
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x2D108C4", Offset = "0x2D0C8C4", VA = "0x2D108C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x2D108CC", Offset = "0x2D0C8CC", VA = "0x2D108CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public override bool IsPostProcessingAllowed
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x2D108D4", Offset = "0x2D0C8D4", VA = "0x2D108D4", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2D10B3C", Offset = "0x2D0CB3C", VA = "0x2D10B3C")]
		public UniversalRenderPipelineDebugDisplaySettings()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2D10BBC", Offset = "0x2D0CBBC", VA = "0x2D10BBC", Slot = "13")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2D10ED0", Offset = "0x2D0CED0", VA = "0x2D10ED0")]
		internal void UpdateFrameTiming()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class UniversalRenderPipelineVolumeDebugSettings : VolumeDebugSettings<UniversalAdditionalCameraData>
	{
		[Token(Token = "0x17000129")]
		public override Type targetRenderPipeline
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x2D10EF4", Offset = "0x2D0CEF4", VA = "0x2D10EF4", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		public override VolumeStack selectedCameraVolumeStack
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x2D10F60", Offset = "0x2D0CF60", VA = "0x2D10F60", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012B")]
		public override LayerMask selectedCameraLayerMask
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x2D11078", Offset = "0x2D0D078", VA = "0x2D11078", Slot = "22")]
			get
			{
				return default(LayerMask);
			}
		}

		[Token(Token = "0x1700012C")]
		public override Vector3 selectedCameraPosition
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x2D11130", Offset = "0x2D0D130", VA = "0x2D11130", Slot = "23")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x2D10E64", Offset = "0x2D0CE64", VA = "0x2D10E64")]
		public UniversalRenderPipelineVolumeDebugSettings()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	internal class DecalDrawDBufferSystem : DecalDrawSystem
	{
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x2D11204", Offset = "0x2D0D204", VA = "0x2D11204")]
		public DecalDrawDBufferSystem(DecalEntityManager entityManager)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x2D11284", Offset = "0x2D0D284", VA = "0x2D11284", Slot = "5")]
		protected override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000BF")]
	internal class DBufferRenderPass : ScriptableRenderPass
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] s_DBufferNames;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string s_DBufferDepthName;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private DecalDrawDBufferSystem m_DrawSystem;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DBufferSettings m_Settings;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Material m_DBufferClear;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<ShaderTagId> m_ShaderTagIdList;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ProfilingSampler m_DBufferClearSampler;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool m_DecalLayers;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private RTHandle m_DBufferDepth;

		[Token(Token = "0x1700012D")]
		internal RTHandle[] dBufferColorHandles
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x2D11298", Offset = "0x2D0D298", VA = "0x2D11298")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x2D112A0", Offset = "0x2D0D2A0", VA = "0x2D112A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		internal RTHandle depthHandle
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x2D112A8", Offset = "0x2D0D2A8", VA = "0x2D112A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x2D112B0", Offset = "0x2D0D2B0", VA = "0x2D112B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		internal RTHandle dBufferDepth
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x2D112B8", Offset = "0x2D0D2B8", VA = "0x2D112B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x2D112C0", Offset = "0x2D0D2C0", VA = "0x2D112C0")]
		public DBufferRenderPass(Material dBufferClear, DBufferSettings settings, DecalDrawDBufferSystem drawSystem, bool decalLayers)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2D1157C", Offset = "0x2D0D57C", VA = "0x2D1157C")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2D115F4", Offset = "0x2D0D5F4", VA = "0x2D115F4")]
		public void Setup(in CameraData cameraData)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2D11700", Offset = "0x2D0D700", VA = "0x2D11700")]
		public void Setup(in CameraData cameraData, RTHandle depthTextureHandle)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x2D11A18", Offset = "0x2D0DA18", VA = "0x2D11A18", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2D11A24", Offset = "0x2D0DA24", VA = "0x2D11A24", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2D120CC", Offset = "0x2D0E0CC", VA = "0x2D120CC", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x20000C0")]
	internal class DecalDrawFowardEmissiveSystem : DecalDrawSystem
	{
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2D12334", Offset = "0x2D0E334", VA = "0x2D12334")]
		public DecalDrawFowardEmissiveSystem(DecalEntityManager entityManager)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2D123B4", Offset = "0x2D0E3B4", VA = "0x2D123B4", Slot = "5")]
		protected override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000C1")]
	internal class DecalForwardEmissivePass : ScriptableRenderPass
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<ShaderTagId> m_ShaderTagIdList;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private DecalDrawFowardEmissiveSystem m_DrawSystem;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2D123C8", Offset = "0x2D0E3C8", VA = "0x2D123C8")]
		public DecalForwardEmissivePass(DecalDrawFowardEmissiveSystem drawSystem)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2D12608", Offset = "0x2D0E608", VA = "0x2D12608", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x20000C2")]
	internal class DecalDrawErrorSystem : DecalDrawSystem
	{
		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DecalTechnique m_Technique;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2D127E4", Offset = "0x2D0E7E4", VA = "0x2D127E4")]
		public DecalDrawErrorSystem(DecalEntityManager entityManager, DecalTechnique technique)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2D12870", Offset = "0x2D0E870", VA = "0x2D12870", Slot = "5")]
		protected override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			return default(int);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2D128E0", Offset = "0x2D0E8E0", VA = "0x2D128E0", Slot = "4")]
		protected override Material GetMaterial(DecalEntityChunk decalEntityChunk)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C3")]
	internal class DecalPreviewPass : ScriptableRenderPass
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<ShaderTagId> m_ShaderTagIdList;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2D128F8", Offset = "0x2D0E8F8", VA = "0x2D128F8")]
		public DecalPreviewPass()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2D12B30", Offset = "0x2D0EB30", VA = "0x2D12B30", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public enum DecalScaleMode
	{
		[Token(Token = "0x40003E1")]
		ScaleInvariant,
		[Token(Token = "0x40003E2")]
		[InspectorName("Inherit from Hierarchy")]
		InheritFromHierarchy
	}
	[Token(Token = "0x20000C5")]
	[ExecuteAlways]
	[AddComponentMenu("Rendering/URP Decal Projector")]
	public class DecalProjector : MonoBehaviour
	{
		[Token(Token = "0x20000C6")]
		internal delegate void DecalProjectorAction(DecalProjector decalProjector);

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material m_Material;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_DrawDistance;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_FadeScale;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(0f, 180f)]
		private float m_StartAngleFade;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(0f, 180f)]
		private float m_EndAngleFade;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 m_UVScale;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 m_UVBias;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private uint m_DecalLayerMask;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private DecalScaleMode m_ScaleMode;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		internal Vector3 m_Offset;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		internal Vector3 m_Size;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_FadeFactor;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material m_OldMaterial;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_OldDrawDistance;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_OldFadeScale;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float m_OldStartAngleFade;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float m_OldEndAngleFade;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 m_OldUVScale;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 m_OldUVBias;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DecalScaleMode m_OldScaleMode;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 m_OldOffset;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 m_OldSize;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float m_OldFadeFactor;

		[Token(Token = "0x17000130")]
		internal static Material defaultMaterial
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x2D13430", Offset = "0x2D0F430", VA = "0x2D13430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x2D13478", Offset = "0x2D0F478", VA = "0x2D13478")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		internal static bool isSupported
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x2D134C4", Offset = "0x2D0F4C4", VA = "0x2D134C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000132")]
		internal DecalEntity decalEntity
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x2D13514", Offset = "0x2D0F514", VA = "0x2D13514")]
			[CompilerGenerated]
			get
			{
				return default(DecalEntity);
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x2D1351C", Offset = "0x2D0F51C", VA = "0x2D1351C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public Material material
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x2D13524", Offset = "0x2D0F524", VA = "0x2D13524")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x2D1352C", Offset = "0x2D0F52C", VA = "0x2D1352C")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public float drawDistance
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x2D13650", Offset = "0x2D0F650", VA = "0x2D13650")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x2D13658", Offset = "0x2D0F658", VA = "0x2D13658")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public float fadeScale
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x2D1366C", Offset = "0x2D0F66C", VA = "0x2D1366C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x2D13674", Offset = "0x2D0F674", VA = "0x2D13674")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public float startAngleFade
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x2D13694", Offset = "0x2D0F694", VA = "0x2D13694")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x2D1369C", Offset = "0x2D0F69C", VA = "0x2D1369C")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public float endAngleFade
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x2D136C0", Offset = "0x2D0F6C0", VA = "0x2D136C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x2D136C8", Offset = "0x2D0F6C8", VA = "0x2D136C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public Vector2 uvScale
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x2D136EC", Offset = "0x2D0F6EC", VA = "0x2D136EC")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x2D136F4", Offset = "0x2D0F6F4", VA = "0x2D136F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public Vector2 uvBias
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x2D136FC", Offset = "0x2D0F6FC", VA = "0x2D136FC")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x2D13704", Offset = "0x2D0F704", VA = "0x2D13704")]
			set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public uint renderingLayerMask
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x2D1370C", Offset = "0x2D0F70C", VA = "0x2D1370C")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x2D13714", Offset = "0x2D0F714", VA = "0x2D13714")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public DecalScaleMode scaleMode
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x2D1371C", Offset = "0x2D0F71C", VA = "0x2D1371C")]
			get
			{
				return default(DecalScaleMode);
			}
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x2D13724", Offset = "0x2D0F724", VA = "0x2D13724")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public Vector3 pivot
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x2D1372C", Offset = "0x2D0F72C", VA = "0x2D1372C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x2D13738", Offset = "0x2D0F738", VA = "0x2D13738")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public Vector3 size
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x2D13744", Offset = "0x2D0F744", VA = "0x2D13744")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x2D13750", Offset = "0x2D0F750", VA = "0x2D13750")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public float fadeFactor
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x2D1375C", Offset = "0x2D0F75C", VA = "0x2D1375C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x2D13764", Offset = "0x2D0F764", VA = "0x2D13764")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		internal Vector3 effectiveScale
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x2D13784", Offset = "0x2D0F784", VA = "0x2D13784")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000140")]
		internal Vector3 decalSize
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x2D137F0", Offset = "0x2D0F7F0", VA = "0x2D137F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000141")]
		internal Vector3 decalOffset
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x2D137FC", Offset = "0x2D0F7FC", VA = "0x2D137FC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000142")]
		internal Vector4 uvScaleBias
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x2D1380C", Offset = "0x2D0F80C", VA = "0x2D1380C")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x14000001")]
		internal static event DecalProjectorAction onDecalAdd
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x2D12CE0", Offset = "0x2D0ECE0", VA = "0x2D12CE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x2D12D98", Offset = "0x2D0ED98", VA = "0x2D12D98")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		internal static event DecalProjectorAction onDecalRemove
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x2D12E50", Offset = "0x2D0EE50", VA = "0x2D12E50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x2D12F0C", Offset = "0x2D0EF0C", VA = "0x2D12F0C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		internal static event DecalProjectorAction onDecalPropertyChange
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x2D12FC8", Offset = "0x2D0EFC8", VA = "0x2D12FC8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x2D13084", Offset = "0x2D0F084", VA = "0x2D13084")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		internal static event Action onAllDecalPropertyChange
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x2D13140", Offset = "0x2D0F140", VA = "0x2D13140")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x2D131FC", Offset = "0x2D0F1FC", VA = "0x2D131FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		internal static event DecalProjectorAction onDecalMaterialChange
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x2D132B8", Offset = "0x2D0F2B8", VA = "0x2D132B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x2D13374", Offset = "0x2D0F374", VA = "0x2D13374")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2D13818", Offset = "0x2D0F818", VA = "0x2D13818")]
		private void InitMaterial()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2D13878", Offset = "0x2D0F878", VA = "0x2D13878")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2D138F4", Offset = "0x2D0F8F4", VA = "0x2D138F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2D13534", Offset = "0x2D0F534", VA = "0x2D13534")]
		internal void OnValidate()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2D13960", Offset = "0x2D0F960", VA = "0x2D13960")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2D13B10", Offset = "0x2D0FB10", VA = "0x2D13B10")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2D13C4C", Offset = "0x2D0FC4C", VA = "0x2D13C4C")]
		internal static void UpdateAllDecalProperties()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2D13CB0", Offset = "0x2D0FCB0", VA = "0x2D13CB0")]
		public DecalProjector()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	internal static class DecalShaderPassNames
	{
		[Token(Token = "0x4000401")]
		public const string DecalPreview = "DecalPreview";

		[Token(Token = "0x4000402")]
		public const string DBufferProjector = "DBufferProjector";

		[Token(Token = "0x4000403")]
		public const string DecalProjectorForwardEmissive = "DecalProjectorForwardEmissive";

		[Token(Token = "0x4000404")]
		public const string DecalScreenSpaceProjector = "DecalScreenSpaceProjector";

		[Token(Token = "0x4000405")]
		public const string DecalGBufferProjector = "DecalGBufferProjector";

		[Token(Token = "0x4000406")]
		public const string DBufferMesh = "DBufferMesh";

		[Token(Token = "0x4000407")]
		public const string DecalMeshForwardEmissive = "DecalMeshForwardEmissive";

		[Token(Token = "0x4000408")]
		public const string DecalScreenSpaceMesh = "DecalScreenSpaceMesh";

		[Token(Token = "0x4000409")]
		public const string DecalGBufferMesh = "DecalGBufferMesh";
	}
	[Token(Token = "0x20000C8")]
	internal abstract class DecalChunk : IDisposable
	{
		[Token(Token = "0x17000143")]
		public int count
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x2D13E40", Offset = "0x2D0FE40", VA = "0x2D13E40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x2D13E48", Offset = "0x2D0FE48", VA = "0x2D13E48")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public int capacity
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x2D13E50", Offset = "0x2D0FE50", VA = "0x2D13E50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x2D13E58", Offset = "0x2D0FE58", VA = "0x2D13E58")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public JobHandle currentJobHandle
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x2D13E60", Offset = "0x2D0FE60", VA = "0x2D13E60")]
			[CompilerGenerated]
			get
			{
				return default(JobHandle);
			}
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x2D13E6C", Offset = "0x2D0FE6C", VA = "0x2D13E6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2D13E74", Offset = "0x2D0FE74", VA = "0x2D13E74", Slot = "5")]
		public virtual void Push()
		{
		}

		[Token(Token = "0x60004E2")]
		public abstract void RemoveAtSwapBack(int index);

		[Token(Token = "0x60004E3")]
		public abstract void SetCapacity(int capacity);

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2D13E84", Offset = "0x2D0FE84", VA = "0x2D13E84", Slot = "8")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2D13E88", Offset = "0x2D0FE88", VA = "0x2D13E88")]
		protected void ResizeNativeArray(ref TransformAccessArray array, DecalProjector[] decalProjectors, int capacity)
		{
		}

		[Token(Token = "0x60004E6")]
		protected void RemoveAtSwapBack<T>(ref NativeArray<T> array, int index, int count) where T : struct
		{
		}

		[Token(Token = "0x60004E7")]
		protected void RemoveAtSwapBack<T>(ref T[] array, int index, int count)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2D13F54", Offset = "0x2D0FF54", VA = "0x2D13F54")]
		protected DecalChunk()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	internal struct DecalSubDrawCall
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int start;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int end;

		[Token(Token = "0x17000146")]
		public int count
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x2D13F5C", Offset = "0x2D0FF5C", VA = "0x2D13F5C")]
			get
			{
				return default(int);
			}
		}
	}
	[Token(Token = "0x20000CA")]
	internal class DecalDrawCallChunk : DecalChunk
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NativeArray<float4x4> decalToWorlds;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public NativeArray<float4x4> normalToDecals;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public NativeArray<float> renderingLayerMasks;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public NativeArray<DecalSubDrawCall> subCalls;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public NativeArray<int> subCallCounts;

		[Token(Token = "0x17000147")]
		public int subCallCount
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x2D13F74", Offset = "0x2D0FF74", VA = "0x2D13F74")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x2D13F68", Offset = "0x2D0FF68", VA = "0x2D13F68")]
			set
			{
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2D13F80", Offset = "0x2D0FF80", VA = "0x2D13F80", Slot = "6")]
		public override void RemoveAtSwapBack(int entityIndex)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2D14068", Offset = "0x2D10068", VA = "0x2D14068", Slot = "7")]
		public override void SetCapacity(int newCapacity)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2D14128", Offset = "0x2D10128", VA = "0x2D14128", Slot = "8")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2D141F4", Offset = "0x2D101F4", VA = "0x2D141F4")]
		public DecalDrawCallChunk()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	internal class DecalCreateDrawCallSystem
	{
		[Token(Token = "0x20000CC")]
		[BurstCompile]
		private struct DrawCallJob : IJob
		{
			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float4x4> decalToWorlds;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float4x4> normalToWorlds;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float4x4> sizeOffsets;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float2> drawDistances;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float2> angleFades;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float4> uvScaleBiases;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Unity.Collections.ReadOnly]
			public NativeArray<int> layerMasks;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Unity.Collections.ReadOnly]
			public NativeArray<ulong> sceneLayerMasks;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float> fadeFactors;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Unity.Collections.ReadOnly]
			public NativeArray<BoundingSphere> boundingSpheres;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Unity.Collections.ReadOnly]
			public NativeArray<uint> renderingLayerMasks;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Vector3 cameraPosition;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public ulong sceneCullingMask;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public int cullingMask;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[Unity.Collections.ReadOnly]
			public NativeArray<int> visibleDecalIndices;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public int visibleDecalCount;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			public float maxDrawDistance;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[WriteOnly]
			public NativeArray<float4x4> decalToWorldsDraw;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[WriteOnly]
			public NativeArray<float4x4> normalToDecalsDraw;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[WriteOnly]
			public NativeArray<float> renderingLayerMasksDraw;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[WriteOnly]
			public NativeArray<DecalSubDrawCall> subCalls;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[WriteOnly]
			public NativeArray<int> subCallCount;

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x2D14680", Offset = "0x2D10680", VA = "0x2D14680", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DecalEntityManager m_EntityManager;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ProfilingSampler m_Sampler;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxDrawDistance;

		[Token(Token = "0x17000148")]
		public float maxDrawDistance
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x2D141FC", Offset = "0x2D101FC", VA = "0x2D141FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x2D14204", Offset = "0x2D10204", VA = "0x2D14204")]
			set
			{
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2D1420C", Offset = "0x2D1020C", VA = "0x2D1420C")]
		public DecalCreateDrawCallSystem(DecalEntityManager entityManager, float maxDrawDistance)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2D142A8", Offset = "0x2D102A8", VA = "0x2D142A8")]
		public void Execute()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2D144B8", Offset = "0x2D104B8", VA = "0x2D144B8")]
		private void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, DecalDrawCallChunk drawCallChunk, int count)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	internal abstract class DecalDrawSystem
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly uint MaxBatchSize;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected DecalEntityManager m_EntityManager;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Matrix4x4[] m_WorldToDecals;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4[] m_NormalToDecals;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float[] m_DecalLayerMasks;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ProfilingSampler m_Sampler;

		[Token(Token = "0x17000149")]
		public Material overrideMaterial
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x2D14980", Offset = "0x2D10980", VA = "0x2D14980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x2D14988", Offset = "0x2D10988", VA = "0x2D14988")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2D14990", Offset = "0x2D10990", VA = "0x2D14990")]
		public DecalDrawSystem(string sampler, DecalEntityManager entityManager)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2D14AB4", Offset = "0x2D10AB4", VA = "0x2D14AB4")]
		public void Execute(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2D14E30", Offset = "0x2D10E30", VA = "0x2D14E30", Slot = "4")]
		protected virtual Material GetMaterial(DecalEntityChunk decalEntityChunk)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		protected abstract int GetPassIndex(DecalCachedChunk decalCachedChunk);

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2D14CCC", Offset = "0x2D10CCC", VA = "0x2D14CCC")]
		private void Execute(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2D1508C", Offset = "0x2D1108C", VA = "0x2D1508C")]
		private void Draw(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2D14E44", Offset = "0x2D10E44", VA = "0x2D14E44")]
		private void DrawInstanced(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2D15370", Offset = "0x2D11370", VA = "0x2D15370")]
		public void Execute(in CameraData cameraData)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2D15588", Offset = "0x2D11588", VA = "0x2D15588")]
		private void Execute(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2D1594C", Offset = "0x2D1194C", VA = "0x2D1594C")]
		private void Draw(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2D156D8", Offset = "0x2D116D8", VA = "0x2D156D8")]
		private void DrawInstanced(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	internal class DecalEntityIndexer
	{
		[Token(Token = "0x20000CF")]
		public struct DecalEntityItem
		{
			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int chunkIndex;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int arrayIndex;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int version;
		}

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<DecalEntityItem> m_Entities;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Queue<int> m_FreeIndices;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2D15BC8", Offset = "0x2D11BC8", VA = "0x2D15BC8")]
		public bool IsValid(DecalEntity decalEntity)
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2D15C50", Offset = "0x2D11C50", VA = "0x2D15C50")]
		public DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex)
		{
			return default(DecalEntity);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2D15DD4", Offset = "0x2D11DD4", VA = "0x2D15DD4")]
		public void DestroyDecalEntity(DecalEntity decalEntity)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2D15E84", Offset = "0x2D11E84", VA = "0x2D15E84")]
		public DecalEntityItem GetItem(DecalEntity decalEntity)
		{
			return default(DecalEntityItem);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2D15EE4", Offset = "0x2D11EE4", VA = "0x2D15EE4")]
		public void UpdateIndex(DecalEntity decalEntity, int newArrayIndex)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2D15F80", Offset = "0x2D11F80", VA = "0x2D15F80")]
		public void RemapChunkIndices(List<int> remaper)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2D16094", Offset = "0x2D12094", VA = "0x2D16094")]
		public void Clear()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2D16104", Offset = "0x2D12104", VA = "0x2D16104")]
		public DecalEntityIndexer()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	internal struct DecalEntity
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int index;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int version;
	}
	[Token(Token = "0x20000D1")]
	internal class DecalEntityChunk : DecalChunk
	{
		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Material material;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NativeArray<DecalEntity> decalEntities;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DecalProjector[] decalProjectors;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TransformAccessArray transformAccessArray;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2D161C8", Offset = "0x2D121C8", VA = "0x2D161C8", Slot = "5")]
		public override void Push()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2D161D8", Offset = "0x2D121D8", VA = "0x2D161D8", Slot = "6")]
		public override void RemoveAtSwapBack(int entityIndex)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2D16284", Offset = "0x2D12284", VA = "0x2D16284", Slot = "7")]
		public override void SetCapacity(int newCapacity)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2D16318", Offset = "0x2D12318", VA = "0x2D16318", Slot = "8")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2D16380", Offset = "0x2D12380", VA = "0x2D16380")]
		public DecalEntityChunk()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	internal class DecalEntityManager : IDisposable
	{
		[Token(Token = "0x20000D3")]
		private struct CombinedChunks
		{
			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DecalEntityChunk entityChunk;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public DecalCachedChunk cachedChunk;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DecalCulledChunk culledChunk;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DecalDrawCallChunk drawCallChunk;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int previousChunkIndex;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool valid;
		}

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<DecalEntityChunk> entityChunks;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<DecalCachedChunk> cachedChunks;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<DecalCulledChunk> culledChunks;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<DecalDrawCallChunk> drawCallChunks;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int chunkCount;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ProfilingSampler m_AddDecalSampler;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ProfilingSampler m_ResizeChunks;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ProfilingSampler m_SortChunks;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DecalEntityIndexer m_DecalEntityIndexer;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Material, int> m_MaterialToChunkIndex;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<CombinedChunks> m_CombinedChunks;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<int> m_CombinedChunkRemmap;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ErrorMaterial;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Mesh m_DecalProjectorMesh;

		[Token(Token = "0x1700014A")]
		public Material errorMaterial
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x2D16388", Offset = "0x2D12388", VA = "0x2D16388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014B")]
		public Mesh decalProjectorMesh
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x2D152B8", Offset = "0x2D112B8", VA = "0x2D152B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2D16454", Offset = "0x2D12454", VA = "0x2D16454")]
		public DecalEntityManager()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2D16738", Offset = "0x2D12738", VA = "0x2D16738")]
		public bool IsValid(DecalEntity decalEntity)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x2D1674C", Offset = "0x2D1274C", VA = "0x2D1674C")]
		public DecalEntity CreateDecalEntity(DecalProjector decalProjector)
		{
			return default(DecalEntity);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x2D16CA8", Offset = "0x2D12CA8", VA = "0x2D16CA8")]
		private int CreateChunkIndex(Material material)
		{
			return default(int);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x2D17554", Offset = "0x2D13554", VA = "0x2D17554")]
		public void UpdateAllDecalEntitiesData()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2D171EC", Offset = "0x2D131EC", VA = "0x2D171EC")]
		public void UpdateDecalEntityData(DecalEntity decalEntity, DecalProjector decalProjector)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x2D17760", Offset = "0x2D13760", VA = "0x2D17760")]
		public void DestroyDecalEntity(DecalEntity decalEntity)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x2D17938", Offset = "0x2D13938", VA = "0x2D17938")]
		public void Update()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2D18288", Offset = "0x2D14288", VA = "0x2D18288", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	internal class DecalSkipCulledSystem
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DecalEntityManager m_EntityManager;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ProfilingSampler m_Sampler;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2D18CC8", Offset = "0x2D14CC8", VA = "0x2D18CC8")]
		public DecalSkipCulledSystem(DecalEntityManager entityManager)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2D18D54", Offset = "0x2D14D54", VA = "0x2D18D54")]
		public void Execute(Camera camera)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2D18EC4", Offset = "0x2D14EC4", VA = "0x2D18EC4")]
		private void Execute(DecalCulledChunk culledChunk, int count)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2D18F6C", Offset = "0x2D14F6C", VA = "0x2D18F6C")]
		internal static ulong GetSceneCullingMaskFromCamera(Camera camera)
		{
			return default(ulong);
		}
	}
	[Token(Token = "0x20000D6")]
	internal class DecalCachedChunk : DecalChunk
	{
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MaterialPropertyBlock propertyBlock;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int passIndexDBuffer;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int passIndexEmissive;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int passIndexScreenSpace;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int passIndexGBuffer;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int drawOrder;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool isCreated;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public NativeArray<float4x4> decalToWorlds;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public NativeArray<float4x4> normalToWorlds;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public NativeArray<float4x4> sizeOffsets;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public NativeArray<float2> drawDistances;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public NativeArray<float2> angleFades;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public NativeArray<float4> uvScaleBias;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public NativeArray<int> layerMasks;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public NativeArray<ulong> sceneLayerMasks;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public NativeArray<float> fadeFactors;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public NativeArray<BoundingSphere> boundingSpheres;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public NativeArray<DecalScaleMode> scaleModes;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public NativeArray<uint> renderingLayerMasks;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public NativeArray<float3> positions;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public NativeArray<quaternion> rotation;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public NativeArray<float3> scales;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public NativeArray<bool> dirty;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public BoundingSphere[] boundingSphereArray;

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x2D18F74", Offset = "0x2D14F74", VA = "0x2D18F74", Slot = "6")]
		public override void RemoveAtSwapBack(int entityIndex)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x2D1926C", Offset = "0x2D1526C", VA = "0x2D1926C", Slot = "7")]
		public override void SetCapacity(int newCapacity)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x2D194D4", Offset = "0x2D154D4", VA = "0x2D194D4", Slot = "8")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2D17544", Offset = "0x2D13544", VA = "0x2D17544")]
		public DecalCachedChunk()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	internal class DecalUpdateCachedSystem
	{
		[Token(Token = "0x20000D8")]
		[BurstCompile]
		public struct UpdateTransformsJob : IJobParallelForTransform
		{
			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly quaternion k_MinusYtoZRotation;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NativeArray<float3> positions;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NativeArray<quaternion> rotations;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NativeArray<float3> scales;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public NativeArray<bool> dirty;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Unity.Collections.ReadOnly]
			public NativeArray<DecalScaleMode> scaleModes;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float4x4> sizeOffsets;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[WriteOnly]
			public NativeArray<float4x4> decalToWorlds;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[WriteOnly]
			public NativeArray<float4x4> normalToWorlds;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[WriteOnly]
			public NativeArray<BoundingSphere> boundingSpheres;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public float minDistance;

			[Token(Token = "0x600052A")]
			[Address(RVA = "0x2D19BE8", Offset = "0x2D15BE8", VA = "0x2D19BE8")]
			private float DistanceBetweenQuaternions(quaternion a, quaternion b)
			{
				return default(float);
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0x2D19C18", Offset = "0x2D15C18", VA = "0x2D19C18", Slot = "4")]
			public void Execute(int index, TransformAccess transform)
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x2D1A1C8", Offset = "0x2D161C8", VA = "0x2D1A1C8")]
			private BoundingSphere GetDecalProjectBoundingSphere(Matrix4x4 decalToWorld)
			{
				return default(BoundingSphere);
			}
		}

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DecalEntityManager m_EntityManager;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ProfilingSampler m_Sampler;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ProfilingSampler m_SamplerJob;

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x2D196DC", Offset = "0x2D156DC", VA = "0x2D196DC")]
		public DecalUpdateCachedSystem(DecalEntityManager entityManager)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2D197A0", Offset = "0x2D157A0", VA = "0x2D197A0")]
		public void Execute()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x2D1995C", Offset = "0x2D1595C", VA = "0x2D1995C")]
		private void Execute(DecalEntityChunk entityChunk, DecalCachedChunk cachedChunk, int count)
		{
		}
	}
	[Token(Token = "0x20000D9")]
	internal class DecalUpdateCulledSystem
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DecalEntityManager m_EntityManager;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ProfilingSampler m_Sampler;

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2D1A508", Offset = "0x2D16508", VA = "0x2D1A508")]
		public DecalUpdateCulledSystem(DecalEntityManager entityManager)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2D1A594", Offset = "0x2D16594", VA = "0x2D1A594")]
		public void Execute()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2D1A6F8", Offset = "0x2D166F8", VA = "0x2D1A6F8")]
		private void Execute(DecalCulledChunk culledChunk, int count)
		{
		}
	}
	[Token(Token = "0x20000DA")]
	internal class DecalCulledChunk : DecalChunk
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 cameraPosition;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ulong sceneCullingMask;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int cullingMask;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CullingGroup cullingGroups;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int[] visibleDecalIndexArray;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public NativeArray<int> visibleDecalIndices;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int visibleDecalCount;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2D1A794", Offset = "0x2D16794", VA = "0x2D1A794", Slot = "6")]
		public override void RemoveAtSwapBack(int entityIndex)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2D1A830", Offset = "0x2D16830", VA = "0x2D1A830", Slot = "7")]
		public override void SetCapacity(int newCapacity)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x2D1A8E8", Offset = "0x2D168E8", VA = "0x2D1A8E8", Slot = "8")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x2D1754C", Offset = "0x2D1354C", VA = "0x2D1754C")]
		public DecalCulledChunk()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	internal class DecalUpdateCullingGroupSystem
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float[] m_BoundingDistance;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera m_Camera;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DecalEntityManager m_EntityManager;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ProfilingSampler m_Sampler;

		[Token(Token = "0x1700014C")]
		public float boundingDistance
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x2D1A95C", Offset = "0x2D1695C", VA = "0x2D1A95C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x2D1A984", Offset = "0x2D16984", VA = "0x2D1A984")]
			set
			{
			}
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x2D1A9AC", Offset = "0x2D169AC", VA = "0x2D1A9AC")]
		public DecalUpdateCullingGroupSystem(DecalEntityManager entityManager, float drawDistance)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2D1AA84", Offset = "0x2D16A84", VA = "0x2D1AA84")]
		public void Execute(Camera camera)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2D1AC48", Offset = "0x2D16C48", VA = "0x2D1AC48")]
		public void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, int count)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2D1AD84", Offset = "0x2D16D84", VA = "0x2D1AD84")]
		internal static ulong GetSceneCullingMaskFromCamera(Camera camera)
		{
			return default(ulong);
		}
	}
	[Token(Token = "0x20000DC")]
	internal class DecalDrawGBufferSystem : DecalDrawSystem
	{
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x2D1AD8C", Offset = "0x2D16D8C", VA = "0x2D1AD8C")]
		public DecalDrawGBufferSystem(DecalEntityManager entityManager)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x2D1AE08", Offset = "0x2D16E08", VA = "0x2D1AE08", Slot = "5")]
		protected override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000DD")]
	internal class DecalGBufferRenderPass : ScriptableRenderPass
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<ShaderTagId> m_ShaderTagIdList;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private DecalDrawGBufferSystem m_DrawSystem;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private DecalScreenSpaceSettings m_Settings;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private DeferredLights m_DeferredLights;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RTHandle[] m_GbufferAttachments;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool m_DecalLayers;

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2D1AE1C", Offset = "0x2D16E1C", VA = "0x2D1AE1C")]
		public DecalGBufferRenderPass(DecalScreenSpaceSettings settings, DecalDrawGBufferSystem drawSystem, bool decalLayers)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2D1B4F4", Offset = "0x2D174F4", VA = "0x2D1B4F4")]
		internal void Setup(DeferredLights deferredLights)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2D1B4FC", Offset = "0x2D174FC", VA = "0x2D1B4FC", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x2D1BB9C", Offset = "0x2D17B9C", VA = "0x2D1BB9C", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2D1BF98", Offset = "0x2D17F98", VA = "0x2D1BF98", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x20000DE")]
	internal class DecalDrawScreenSpaceSystem : DecalDrawSystem
	{
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x2D1C0D8", Offset = "0x2D180D8", VA = "0x2D1C0D8")]
		public DecalDrawScreenSpaceSystem(DecalEntityManager entityManager)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x2D1C154", Offset = "0x2D18154", VA = "0x2D1C154", Slot = "5")]
		protected override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000DF")]
	internal class DecalScreenSpaceRenderPass : ScriptableRenderPass
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<ShaderTagId> m_ShaderTagIdList;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private DecalDrawScreenSpaceSystem m_DrawSystem;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private DecalScreenSpaceSettings m_Settings;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool m_DecalLayers;

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x2D1C168", Offset = "0x2D18168", VA = "0x2D1C168")]
		public DecalScreenSpaceRenderPass(DecalScreenSpaceSettings settings, DecalDrawScreenSpaceSystem drawSystem, bool decalLayers)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x2D1C3DC", Offset = "0x2D183DC", VA = "0x2D1C3DC", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x2D1C7F0", Offset = "0x2D187F0", VA = "0x2D1C7F0", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public abstract class ScriptableRenderPass
	{
		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static RTHandle k_CameraTarget;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RenderBufferStoreAction[] m_ColorStoreActions;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderBufferStoreAction m_DepthStoreAction;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool[] m_OverriddenColorStoreActions;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_OverriddenDepthStoreAction;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal NativeArray<int> m_ColorAttachmentIndices;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal NativeArray<int> m_InputAttachmentIndices;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal bool m_UsesRTHandles;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RTHandle[] m_ColorAttachments;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RenderTargetIdentifier[] m_ColorAttachmentIds;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal RTHandle[] m_InputAttachments;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal bool[] m_InputAttachmentIsTransient;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RTHandle m_DepthAttachment;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RenderTargetIdentifier m_DepthAttachmentId;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ScriptableRenderPassInput m_Input;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private ClearFlag m_ClearFlag;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Color m_ClearColor;

		[Token(Token = "0x1700014D")]
		public RenderPassEvent renderPassEvent
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x2D1C93C", Offset = "0x2D1893C", VA = "0x2D1C93C")]
			[CompilerGenerated]
			get
			{
				return default(RenderPassEvent);
			}
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x2D1C944", Offset = "0x2D18944", VA = "0x2D1C944")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		[Obsolete("Use colorAttachmentHandles")]
		public RenderTargetIdentifier[] colorAttachments
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x2D1C94C", Offset = "0x2D1894C", VA = "0x2D1C94C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014F")]
		[Obsolete("Use colorAttachmentHandle")]
		public RenderTargetIdentifier colorAttachment
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x2D1C954", Offset = "0x2D18954", VA = "0x2D1C954")]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Token(Token = "0x17000150")]
		[Obsolete("Use depthAttachmentHandle")]
		public RenderTargetIdentifier depthAttachment
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x2D1C988", Offset = "0x2D18988", VA = "0x2D1C988")]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Token(Token = "0x17000151")]
		public RTHandle[] colorAttachmentHandles
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x2D1CA00", Offset = "0x2D18A00", VA = "0x2D1CA00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		public RTHandle colorAttachmentHandle
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x2D1CA08", Offset = "0x2D18A08", VA = "0x2D1CA08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000153")]
		public RTHandle depthAttachmentHandle
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x2D1CA30", Offset = "0x2D18A30", VA = "0x2D1CA30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		public RenderBufferStoreAction[] colorStoreActions
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x2D1CA38", Offset = "0x2D18A38", VA = "0x2D1CA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000155")]
		public RenderBufferStoreAction depthStoreAction
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x2D1CA40", Offset = "0x2D18A40", VA = "0x2D1CA40")]
			get
			{
				return default(RenderBufferStoreAction);
			}
		}

		[Token(Token = "0x17000156")]
		internal bool[] overriddenColorStoreActions
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x2D1CA48", Offset = "0x2D18A48", VA = "0x2D1CA48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000157")]
		internal bool overriddenDepthStoreAction
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x2D1CA50", Offset = "0x2D18A50", VA = "0x2D1CA50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000158")]
		public ScriptableRenderPassInput input
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x2D1CA58", Offset = "0x2D18A58", VA = "0x2D1CA58")]
			get
			{
				return default(ScriptableRenderPassInput);
			}
		}

		[Token(Token = "0x17000159")]
		public ClearFlag clearFlag
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x2D1CA60", Offset = "0x2D18A60", VA = "0x2D1CA60")]
			get
			{
				return default(ClearFlag);
			}
		}

		[Token(Token = "0x1700015A")]
		public Color clearColor
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x2D1CA68", Offset = "0x2D18A68", VA = "0x2D1CA68")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x1700015B")]
		protected internal ProfilingSampler profilingSampler
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x2D1CA74", Offset = "0x2D18A74", VA = "0x2D1CA74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x2D1CA7C", Offset = "0x2D18A7C", VA = "0x2D1CA7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		internal bool overrideCameraTarget
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x2D1CA84", Offset = "0x2D18A84", VA = "0x2D1CA84")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x2D1CA8C", Offset = "0x2D18A8C", VA = "0x2D1CA8C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		internal bool isBlitRenderPass
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x2D1CA94", Offset = "0x2D18A94", VA = "0x2D1CA94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x2D1CA9C", Offset = "0x2D18A9C", VA = "0x2D1CA9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		internal bool useNativeRenderPass
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x2D1CAA4", Offset = "0x2D18AA4", VA = "0x2D1CAA4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x2D1CAAC", Offset = "0x2D18AAC", VA = "0x2D1CAAC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		internal int renderPassQueueIndex
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x2D1CAB4", Offset = "0x2D18AB4", VA = "0x2D1CAB4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x2D1CABC", Offset = "0x2D18ABC", VA = "0x2D1CABC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000160")]
		internal GraphicsFormat[] renderTargetFormat
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x2D1CAC4", Offset = "0x2D18AC4", VA = "0x2D1CAC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x2D1CACC", Offset = "0x2D18ACC", VA = "0x2D1CACC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2D1C930", Offset = "0x2D18930", VA = "0x2D1C930", Slot = "4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x2D1CAD4", Offset = "0x2D18AD4", VA = "0x2D1CAD4")]
		internal static DebugHandler GetActiveDebugHandler(ref RenderingData renderingData)
		{
			return null;
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2D1B0A8", Offset = "0x2D170A8", VA = "0x2D1B0A8")]
		public ScriptableRenderPass()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2D1CB10", Offset = "0x2D18B10", VA = "0x2D1CB10")]
		public void ConfigureInput(ScriptableRenderPassInput passInput)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2D1CB18", Offset = "0x2D18B18", VA = "0x2D1CB18")]
		public void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0u)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2D1CB6C", Offset = "0x2D18B6C", VA = "0x2D1CB6C")]
		public void ConfigureColorStoreActions(RenderBufferStoreAction[] storeActions)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x2D1CC50", Offset = "0x2D18C50", VA = "0x2D1CC50")]
		public void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x2D1CC60", Offset = "0x2D18C60", VA = "0x2D1CC60")]
		internal void ConfigureInputAttachments(RTHandle input, bool isTransient = false)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x2D1CCE0", Offset = "0x2D18CE0", VA = "0x2D1CCE0")]
		internal void ConfigureInputAttachments(RTHandle[] inputs)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x2D1B940", Offset = "0x2D17940", VA = "0x2D1B940")]
		internal void ConfigureInputAttachments(RTHandle[] inputs, bool[] isTransient)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x2D1CCE8", Offset = "0x2D18CE8", VA = "0x2D1CCE8")]
		internal void SetInputAttachmentTransient(int idx, bool isTransient)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x2D1CD1C", Offset = "0x2D18D1C", VA = "0x2D1CD1C")]
		internal bool IsInputAttachmentTransient(int idx)
		{
			return default(bool);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x2D1CD4C", Offset = "0x2D18D4C", VA = "0x2D1CD4C")]
		public void ResetTarget()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x2D1CE70", Offset = "0x2D18E70", VA = "0x2D1CE70")]
		[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
		public void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x2D1CF6C", Offset = "0x2D18F6C", VA = "0x2D1CF6C")]
		public void ConfigureTarget(RTHandle colorAttachment, RTHandle depthAttachment)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x2D1D07C", Offset = "0x2D1907C", VA = "0x2D1D07C")]
		[Obsolete("Use RTHandles for colorAttachments and depthAttachment")]
		public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x2D1B948", Offset = "0x2D17948", VA = "0x2D1B948")]
		public void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x2D1D1D8", Offset = "0x2D191D8", VA = "0x2D1D1D8")]
		internal void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment, GraphicsFormat[] formats)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2D1CEB0", Offset = "0x2D18EB0", VA = "0x2D1CEB0")]
		[Obsolete("Use RTHandle for colorAttachment")]
		public void ConfigureTarget(RenderTargetIdentifier colorAttachment)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x2D1D254", Offset = "0x2D19254", VA = "0x2D1D254")]
		public void ConfigureTarget(RTHandle colorAttachment)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x2D1D340", Offset = "0x2D19340", VA = "0x2D1D340")]
		[Obsolete("Use RTHandles for colorAttachments")]
		public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x2D1D3DC", Offset = "0x2D193DC", VA = "0x2D1D3DC")]
		public void ConfigureTarget(RTHandle[] colorAttachments)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x2D1D44C", Offset = "0x2D1944C", VA = "0x2D1D44C")]
		public void ConfigureClear(ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x2D1D45C", Offset = "0x2D1945C", VA = "0x2D1D45C", Slot = "5")]
		public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x2D1D460", Offset = "0x2D19460", VA = "0x2D1D460", Slot = "6")]
		public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x2D1D464", Offset = "0x2D19464", VA = "0x2D1D464", Slot = "7")]
		public virtual void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x2D1D468", Offset = "0x2D19468", VA = "0x2D1D468", Slot = "8")]
		public virtual void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600057D")]
		public abstract void Execute(ScriptableRenderContext context, ref RenderingData renderingData);

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x2D1D46C", Offset = "0x2D1946C", VA = "0x2D1D46C", Slot = "10")]
		internal virtual void RecordRenderGraph(RenderGraph renderGraph, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2D1D524", Offset = "0x2D19524", VA = "0x2D1D524")]
		[Obsolete("Use RTHandles for source and destination")]
		public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, [Optional] Material material, int passIndex = 0)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x2D1D8E0", Offset = "0x2D198E0", VA = "0x2D1D8E0")]
		public void Blit(CommandBuffer cmd, RTHandle source, RTHandle destination, [Optional] Material material, int passIndex = 0)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2D1DA00", Offset = "0x2D19A00", VA = "0x2D1DA00")]
		public void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2D1DB04", Offset = "0x2D19B04", VA = "0x2D1DB04")]
		public void Blit(CommandBuffer cmd, ref RenderingData data, RTHandle source, Material material, int passIndex = 0)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2D1DB54", Offset = "0x2D19B54", VA = "0x2D1DB54")]
		public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2D1BF18", Offset = "0x2D17F18", VA = "0x2D1BF18")]
		public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x2D1DBD4", Offset = "0x2D19BD4", VA = "0x2D1DBD4")]
		public static bool operator <(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x2D1DBFC", Offset = "0x2D19BFC", VA = "0x2D1DBFC")]
		public static bool operator >(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x2D1DC24", Offset = "0x2D19C24", VA = "0x2D1DC24")]
		internal static int GetRenderPassEventRange(RenderPassEvent renderPassEvent)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E1")]
	[Obsolete("ForwardRenderer has been deprecated (UnityUpgradable) -> UniversalRenderer", true)]
	public sealed class ForwardRenderer : ScriptableRenderer
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string k_ErrorMessage;

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2D1DE30", Offset = "0x2D19E30", VA = "0x2D1DE30")]
		public ForwardRenderer(ForwardRendererData data)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2D1E75C", Offset = "0x2D1A75C", VA = "0x2D1E75C", Slot = "10")]
		public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2D1E7C0", Offset = "0x2D1A7C0", VA = "0x2D1E7C0", Slot = "11")]
		public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2D1E824", Offset = "0x2D1A824", VA = "0x2D1E824", Slot = "12")]
		public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2D1E888", Offset = "0x2D1A888", VA = "0x2D1E888", Slot = "13")]
		public override void FinishRendering(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2D1E8EC", Offset = "0x2D1A8EC", VA = "0x2D1E8EC", Slot = "16")]
		internal override void SwapColorBuffer(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2D1E950", Offset = "0x2D1A950", VA = "0x2D1E950", Slot = "6")]
		internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E2")]
	[Obsolete("This is obsolete, please use shadowCascadeCount instead.", false)]
	public enum ShadowCascadesOption
	{
		[Token(Token = "0x40004B3")]
		NoCascades,
		[Token(Token = "0x40004B4")]
		TwoCascades,
		[Token(Token = "0x40004B5")]
		FourCascades
	}
	[Token(Token = "0x20000E3")]
	[Obsolete("This is obsolete, UnityEngine.Rendering.ShaderVariantLogLevel instead.", false)]
	public enum ShaderVariantLogLevel
	{
		[Token(Token = "0x40004B7")]
		Disabled,
		[Token(Token = "0x40004B8")]
		[InspectorName("Only URP Shaders")]
		OnlyUniversalRPShaders,
		[Token(Token = "0x40004B9")]
		[InspectorName("All Shaders")]
		AllShaders
	}
	[Token(Token = "0x20000E4")]
	public abstract class ScriptableRenderer : IDisposable
	{
		[Token(Token = "0x20000E5")]
		private static class Profiling
		{
			[Token(Token = "0x20000E6")]
			public static class RenderBlock
			{
				[Token(Token = "0x40004F6")]
				private const string k_Name = "RenderPassBlock";

				[Token(Token = "0x40004F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly ProfilingSampler beforeRendering;

				[Token(Token = "0x40004F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static readonly ProfilingSampler mainRenderingOpaque;

				[Token(Token = "0x40004F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public static readonly ProfilingSampler mainRenderingTransparent;

				[Token(Token = "0x40004FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public static readonly ProfilingSampler afterRendering;
			}

			[Token(Token = "0x20000E7")]
			public static class RenderPass
			{
				[Token(Token = "0x40004FB")]
				private const string k_Name = "ScriptableRenderPass";

				[Token(Token = "0x40004FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly ProfilingSampler configure;

				[Token(Token = "0x40004FD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static readonly ProfilingSampler setRenderPassAttachments;
			}

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ProfilingSampler setMRTAttachmentsList;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly ProfilingSampler setAttachmentList;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly ProfilingSampler execute;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly ProfilingSampler setupFrameData;

			[Token(Token = "0x40004E8")]
			private const string k_Name = "ScriptableRenderer";

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly ProfilingSampler setPerCameraShaderVariables;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static readonly ProfilingSampler sortRenderPasses;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static readonly ProfilingSampler setupLights;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static readonly ProfilingSampler setupCamera;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static readonly ProfilingSampler vfxProcessCamera;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static readonly ProfilingSampler addRenderPasses;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static readonly ProfilingSampler setupRenderPasses;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static readonly ProfilingSampler clearRenderingState;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static readonly ProfilingSampler internalStartRendering;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static readonly ProfilingSampler internalFinishRendering;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static readonly ProfilingSampler drawGizmos;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal static readonly ProfilingSampler beginXRRendering;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal static readonly ProfilingSampler endXRRendering;
		}

		[Token(Token = "0x20000E8")]
		internal struct RenderPassDescriptor
		{
			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int w;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal int h;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int samples;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int depthID;

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x2D2B48C", Offset = "0x2D2748C", VA = "0x2D2B48C")]
			internal RenderPassDescriptor(int width, int height, int sampleCount, int rtID)
			{
			}
		}

		[Token(Token = "0x20000E9")]
		public class RenderingFeatures
		{
			[Token(Token = "0x1700016F")]
			[Obsolete("cameraStacking has been deprecated use SupportedCameraRenderTypes() in ScriptableRenderer instead.", false)]
			public bool cameraStacking
			{
				[Token(Token = "0x6000609")]
				[Address(RVA = "0x2D2B498", Offset = "0x2D27498", VA = "0x2D2B498")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600060A")]
				[Address(RVA = "0x2D2B4A0", Offset = "0x2D274A0", VA = "0x2D2B4A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000170")]
			public bool msaa
			{
				[Token(Token = "0x600060B")]
				[Address(RVA = "0x2D2B4A8", Offset = "0x2D274A8", VA = "0x2D2B4A8")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600060C")]
				[Address(RVA = "0x2D2B4B0", Offset = "0x2D274B0", VA = "0x2D2B4B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x2D2B4B8", Offset = "0x2D274B8", VA = "0x2D2B4B8")]
			public RenderingFeatures()
			{
			}
		}

		[Token(Token = "0x20000EA")]
		private static class RenderPassBlock
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int BeforeRendering;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int MainRenderingOpaque;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int MainRenderingTransparent;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int AfterRendering;
		}

		[Token(Token = "0x20000EB")]
		internal struct RTHandleRenderTargetIdentifierCompat
		{
			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RTHandle handle;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public RenderTargetIdentifier fallback;

			[Token(Token = "0x17000171")]
			public bool useRTHandle
			{
				[Token(Token = "0x600060F")]
				[Address(RVA = "0x2D2B518", Offset = "0x2D27518", VA = "0x2D2B518")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000172")]
			public RenderTargetIdentifier nameID
			{
				[Token(Token = "0x6000610")]
				[Address(RVA = "0x2D2B528", Offset = "0x2D27528", VA = "0x2D2B528")]
				get
				{
					return default(RenderTargetIdentifier);
				}
			}
		}

		[Token(Token = "0x20000EC")]
		private class VFXProcessCameraPassData
		{
			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal CullingResults cullResults;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Camera camera;

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x2D2B598", Offset = "0x2D27598", VA = "0x2D2B598")]
			public VFXProcessCameraPassData()
			{
			}
		}

		[Token(Token = "0x20000ED")]
		private class DrawGizmosPassData
		{
			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderingData renderingData;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			public ScriptableRenderer renderer;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			public GizmoSubset gizmoSubset;

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x2D2B5A0", Offset = "0x2D275A0", VA = "0x2D2B5A0")]
			public DrawGizmosPassData()
			{
			}
		}

		[Token(Token = "0x20000EE")]
		private class BeginXRPassData
		{
			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderingData renderingData;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			public CameraData cameraData;

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x2D2B5A8", Offset = "0x2D275A8", VA = "0x2D2B5A8")]
			public BeginXRPassData()
			{
			}
		}

		[Token(Token = "0x20000EF")]
		private class EndXRPassData
		{
			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderingData renderingData;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			public CameraData cameraData;

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x2D2B5B0", Offset = "0x2D275B0", VA = "0x2D2B5B0")]
			public EndXRPassData()
			{
			}
		}

		[Token(Token = "0x20000F0")]
		private class PassData
		{
			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal RenderingData renderingData;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			internal ScriptableRenderer renderer;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			internal CameraData cameraData;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
			internal bool isTargetBackbuffer;

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x2D2B5B8", Offset = "0x2D275B8", VA = "0x2D2B5B8")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x20000F1")]
		internal struct RenderBlocks : IDisposable
		{
			[Token(Token = "0x20000F2")]
			public struct BlockRange : IDisposable
			{
				[Token(Token = "0x400051A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private int m_Current;

				[Token(Token = "0x400051B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				private int m_End;

				[Token(Token = "0x17000173")]
				public int Current
				{
					[Token(Token = "0x600061E")]
					[Address(RVA = "0x2D2B940", Offset = "0x2D27940", VA = "0x2D2B940")]
					get
					{
						return default(int);
					}
				}

				[Token(Token = "0x600061B")]
				[Address(RVA = "0x2D2B900", Offset = "0x2D27900", VA = "0x2D2B900")]
				public BlockRange(int begin, int end)
				{
				}

				[Token(Token = "0x600061C")]
				[Address(RVA = "0x2D2B91C", Offset = "0x2D2791C", VA = "0x2D2B91C")]
				public BlockRange GetEnumerator()
				{
					return default(BlockRange);
				}

				[Token(Token = "0x600061D")]
				[Address(RVA = "0x2D2B924", Offset = "0x2D27924", VA = "0x2D2B924")]
				public bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x600061F")]
				[Address(RVA = "0x2D2B948", Offset = "0x2D27948", VA = "0x2D2B948", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<RenderPassEvent> m_BlockEventLimits;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private NativeArray<int> m_BlockRanges;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private NativeArray<int> m_BlockRangeLengths;

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x2D2B5C0", Offset = "0x2D275C0", VA = "0x2D2B5C0")]
			public RenderBlocks(List<ScriptableRenderPass> activeRenderPassQueue)
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x2D2B874", Offset = "0x2D27874", VA = "0x2D2B874", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x2D2B76C", Offset = "0x2D2776C", VA = "0x2D2B76C")]
			private void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue)
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x2D2B8C8", Offset = "0x2D278C8", VA = "0x2D2B8C8")]
			public int GetLength(int index)
			{
				return default(int);
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x2D2B8D4", Offset = "0x2D278D4", VA = "0x2D2B8D4")]
			public BlockRange GetRange(int index)
			{
				return default(BlockRange);
			}
		}

		[Token(Token = "0x40004BA")]
		private const int kRenderPassMapSize = 10;

		[Token(Token = "0x40004BB")]
		private const int kRenderPassMaxCount = 20;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_LastBeginSubpassPassIndex;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<Hash128, int[]> m_MergeableRenderPassesMap;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int[][] m_MergeableRenderPassesMapArrays;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Hash128[] m_PassIndexToPassHash;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Hash128, int> m_RenderPassesAttachmentCount;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AttachmentDescriptor[] m_ActiveColorAttachmentDescriptors;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AttachmentDescriptor m_ActiveDepthAttachmentDescriptor;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool[] m_IsActiveColorAttachmentTransient;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal RenderBufferStoreAction[] m_FinalColorStoreAction;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal RenderBufferStoreAction m_FinalDepthStoreAction;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal bool hasReleasedRTs;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static ScriptableRenderer current;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private StoreActionsOptimization m_StoreActionsOptimizationSetting;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool m_UseOptimizedStoreActions;

		[Token(Token = "0x40004CE")]
		private const int k_RenderPassBlockCount = 4;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static readonly RTHandle k_CameraTarget;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<ScriptableRenderPass> m_ActiveRenderPassQueue;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<ScriptableRendererFeature> m_RendererFeatures;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RTHandleRenderTargetIdentifierCompat m_CameraColorTarget;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private RTHandleRenderTargetIdentifierCompat m_CameraDepthTarget;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private RTHandleRenderTargetIdentifierCompat m_CameraResolveTarget;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool m_FirstTimeCameraColorTargetIsBound;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A1")]
		private bool m_FirstTimeCameraDepthTargetIsBound;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A2")]
		private bool m_IsPipelineExecuting;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A3")]
		internal bool disableNativeRenderPassInFeatures;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		internal bool useRenderPassEnabled;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static RenderTargetIdentifier[] m_ActiveColorAttachments;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static RenderTargetIdentifier m_ActiveDepthAttachment;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static RenderBufferStoreAction[] m_ActiveColorStoreActions;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static RenderBufferStoreAction m_ActiveDepthStoreAction;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopies;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Plane[] s_Planes;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static Vector4[] s_VectorPlanes;

		[Token(Token = "0x17000161")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("cameraDepth has been renamed to cameraDepthTarget. (UnityUpgradable) -> cameraDepthTarget")]
		public RenderTargetIdentifier cameraDepth
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x2D1E9E8", Offset = "0x2D1A9E8", VA = "0x2D1E9E8")]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Token(Token = "0x17000162")]
		protected ProfilingSampler profilingExecute
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x2D22424", Offset = "0x2D1E424", VA = "0x2D22424")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x2D2242C", Offset = "0x2D1E42C", VA = "0x2D2242C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		internal DebugHandler DebugHandler
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x2D22434", Offset = "0x2D1E434", VA = "0x2D22434")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000164")]
		[Obsolete("Use cameraColorTargetHandle")]
		public RenderTargetIdentifier cameraColorTarget
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x2D23990", Offset = "0x2D1F990", VA = "0x2D23990")]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Token(Token = "0x17000165")]
		public RTHandle cameraColorTargetHandle
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x2D1DA80", Offset = "0x2D19A80", VA = "0x2D1DA80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000166")]
		[Obsolete("Use cameraDepthTargetHandle")]
		public RenderTargetIdentifier cameraDepthTarget
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x2D23A40", Offset = "0x2D1FA40", VA = "0x2D23A40")]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Token(Token = "0x17000167")]
		public RTHandle cameraDepthTargetHandle
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x2D22370", Offset = "0x2D1E370", VA = "0x2D22370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000168")]
		protected List<ScriptableRendererFeature> rendererFeatures
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x2D23AE0", Offset = "0x2D1FAE0", VA = "0x2D23AE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000169")]
		protected List<ScriptableRenderPass> activeRenderPassQueue
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x2D23AE8", Offset = "0x2D1FAE8", VA = "0x2D23AE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016A")]
		public RenderingFeatures supportedRenderingFeatures
		{
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x2D23AF0", Offset = "0x2D1FAF0", VA = "0x2D23AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x2D23AF8", Offset = "0x2D1FAF8", VA = "0x2D23AF8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x2D23B00", Offset = "0x2D1FB00", VA = "0x2D23B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x2D23B08", Offset = "0x2D1FB08", VA = "0x2D23B08")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		internal bool useDepthPriming
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x2D23C64", Offset = "0x2D1FC64", VA = "0x2D23C64")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x2D23C6C", Offset = "0x2D1FC6C", VA = "0x2D23C6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		internal bool stripShadowsOffVariants
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x2D23C74", Offset = "0x2D1FC74", VA = "0x2D23C74")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x2D23C7C", Offset = "0x2D1FC7C", VA = "0x2D23C7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		internal bool stripAdditionalLightOffVariants
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x2D23C84", Offset = "0x2D1FC84", VA = "0x2D23C84")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x2D23C8C", Offset = "0x2D1FC8C", VA = "0x2D23C8C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2D1E9F4", Offset = "0x2D1A9F4", VA = "0x2D1E9F4")]
		internal void ResetNativeRenderPassFrameData()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2D1EB10", Offset = "0x2D1AB10", VA = "0x2D1EB10")]
		internal void SetupNativeRenderPassFrameData(ref CameraData cameraData, bool isRenderPassEnabled)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2D1F458", Offset = "0x2D1B458", VA = "0x2D1F458")]
		internal void UpdateFinalStoreActions(int[] currentMergeablePasses, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2D1F80C", Offset = "0x2D1B80C", VA = "0x2D1F80C")]
		internal void SetNativeRenderPassMRTAttachmentList(ScriptableRenderPass renderPass, ref CameraData cameraData, bool needCustomCameraColorClear, ClearFlag cameraClearFlag)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2D20588", Offset = "0x2D1C588", VA = "0x2D20588")]
		private bool IsDepthOnlyRenderTexture(RenderTexture t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2D205B0", Offset = "0x2D1C5B0", VA = "0x2D205B0")]
		internal void SetNativeRenderPassAttachmentList(ScriptableRenderPass renderPass, ref CameraData cameraData, RTHandle passColorAttachment, RTHandle passDepthAttachment, ClearFlag finalClearFlag, Color finalClearColor)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2D2125C", Offset = "0x2D1D25C", VA = "0x2D2125C")]
		internal void ExecuteNativeRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref CameraData cameraData, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2D202A4", Offset = "0x2D1C2A4", VA = "0x2D202A4")]
		internal void SetupInputAttachmentIndices(ScriptableRenderPass pass)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2D20484", Offset = "0x2D1C484", VA = "0x2D20484")]
		internal void SetupTransientInputAttachments(int attachmentCount)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2D21D64", Offset = "0x2D1DD64", VA = "0x2D21D64")]
		internal static uint GetSubPassAttachmentIndicesCount(ScriptableRenderPass pass)
		{
			return default(uint);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2D21ED8", Offset = "0x2D1DED8", VA = "0x2D21ED8")]
		internal static bool AreAttachmentIndicesCompatible(ScriptableRenderPass lastSubPass, ScriptableRenderPass currentSubPass)
		{
			return default(bool);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2D22018", Offset = "0x2D1E018", VA = "0x2D22018")]
		internal static uint GetValidColorAttachmentCount(AttachmentDescriptor[] colorAttachments)
		{
			return default(uint);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2D21FD0", Offset = "0x2D1DFD0", VA = "0x2D21FD0")]
		internal static int GetValidInputAttachmentCount(ScriptableRenderPass renderPass)
		{
			return default(int);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2D2113C", Offset = "0x2D1D13C", VA = "0x2D2113C")]
		internal static int FindAttachmentDescriptorIndexInList(int attachmentIdx, AttachmentDescriptor attachmentDescriptor, AttachmentDescriptor[] attachmentDescriptors)
		{
			return default(int);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2D20184", Offset = "0x2D1C184", VA = "0x2D20184")]
		internal static int FindAttachmentDescriptorIndexInList(RenderTargetIdentifier target, AttachmentDescriptor[] attachmentDescriptors)
		{
			return default(int);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2D1F418", Offset = "0x2D1B418", VA = "0x2D1F418")]
		internal static int GetValidPassIndexCount(int[] array)
		{
			return default(int);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2D1F730", Offset = "0x2D1B730", VA = "0x2D1F730")]
		internal static RTHandle GetFirstAllocatedRTHandle(ScriptableRenderPass pass)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x2D20268", Offset = "0x2D1C268", VA = "0x2D20268")]
		internal static bool PassHasInputAttachments(ScriptableRenderPass renderPass)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2D22160", Offset = "0x2D1E160", VA = "0x2D22160")]
		internal static Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex)
		{
			return default(Hash128);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x2D1F388", Offset = "0x2D1B388", VA = "0x2D1F388")]
		internal static Hash128 CreateRenderPassHash(RenderPassDescriptor desc, uint hashIndex)
		{
			return default(Hash128);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x2D2218C", Offset = "0x2D1E18C", VA = "0x2D2218C")]
		internal static void GetRenderTextureDescriptor(ref CameraData cameraData, ScriptableRenderPass renderPass, out RenderTextureDescriptor targetRT)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2D1F280", Offset = "0x2D1B280", VA = "0x2D1F280")]
		private RenderPassDescriptor InitializeRenderPassDescriptor(ref CameraData cameraData, ScriptableRenderPass renderPass)
		{
			return default(RenderPassDescriptor);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2D223F4", Offset = "0x2D1E3F4", VA = "0x2D223F4", Slot = "5")]
		public virtual int SupportedCameraStackingTypes()
		{
			return default(int);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x2D223FC", Offset = "0x2D1E3FC", VA = "0x2D223FC")]
		public bool SupportsCameraStackingType(CameraRenderType cameraRenderType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2D2243C", Offset = "0x2D1E43C", VA = "0x2D2243C")]
		public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2D224C0", Offset = "0x2D1E4C0", VA = "0x2D224C0")]
		internal static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices, bool isTargetFlipped)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2D229A0", Offset = "0x2D1E9A0", VA = "0x2D229A0")]
		private void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2D229E0", Offset = "0x2D1E9E0", VA = "0x2D229E0")]
		private void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData, bool isTargetFlipped)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2D23014", Offset = "0x2D1F014", VA = "0x2D23014")]
		private void SetPerCameraBillboardProperties(CommandBuffer cmd, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x2D231EC", Offset = "0x2D1F1EC", VA = "0x2D231EC")]
		private static void CalculateBillboardProperties(in Matrix4x4 worldToCameraMatrix, out Vector3 billboardTangent, out Vector3 billboardNormal, out float cameraXZAngle)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2D235A0", Offset = "0x2D1F5A0", VA = "0x2D235A0")]
		private void SetPerCameraClippingPlaneProperties(CommandBuffer cmd, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x2D235D4", Offset = "0x2D1F5D4", VA = "0x2D235D4")]
		private void SetPerCameraClippingPlaneProperties(CommandBuffer cmd, in CameraData cameraData, bool isTargetFlipped)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x2D237B8", Offset = "0x2D1F7B8", VA = "0x2D237B8")]
		private static void SetShaderTimeValues(CommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2D23A30", Offset = "0x2D1FA30", VA = "0x2D23A30", Slot = "6")]
		internal virtual RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2D23A38", Offset = "0x2D1FA38", VA = "0x2D23A38", Slot = "7")]
		internal virtual RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2D23B10", Offset = "0x2D1FB10", VA = "0x2D23B10")]
		internal static void ConfigureActiveTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2D1DEB8", Offset = "0x2D19EB8", VA = "0x2D1DEB8")]
		public ScriptableRenderer(ScriptableRendererData data)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2D23E98", Offset = "0x2D1FE98", VA = "0x2D23E98", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x2D23FD0", Offset = "0x2D1FFD0", VA = "0x2D23FD0", Slot = "8")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2D23FE4", Offset = "0x2D1FFE4", VA = "0x2D23FE4", Slot = "9")]
		internal virtual void ReleaseRenderTargets()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2D23FE8", Offset = "0x2D1FFE8", VA = "0x2D23FE8")]
		[Obsolete("Use RTHandles for colorTarget and depthTarget")]
		public void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2D2402C", Offset = "0x2D2002C", VA = "0x2D2402C")]
		public void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2D24050", Offset = "0x2D20050", VA = "0x2D24050")]
		[Obsolete("Use RTHandles for colorTarget, depthTarget and resolveTarget")]
		internal void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget, RenderTargetIdentifier resolveTarget)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2D240C4", Offset = "0x2D200C4", VA = "0x2D240C4")]
		internal void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget, RTHandle resolveTarget)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2D240F4", Offset = "0x2D200F4", VA = "0x2D240F4")]
		[Obsolete("Use RTHandle for colorTarget")]
		internal void ConfigureCameraColorTarget(RenderTargetIdentifier colorTarget)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2D2411C", Offset = "0x2D2011C", VA = "0x2D2411C")]
		internal void ConfigureCameraColorTarget(RTHandle colorTarget)
		{
		}

		[Token(Token = "0x60005D3")]
		public abstract void Setup(ScriptableRenderContext context, ref RenderingData renderingData);

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2D24134", Offset = "0x2D20134", VA = "0x2D24134", Slot = "11")]
		public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2D24138", Offset = "0x2D20138", VA = "0x2D24138", Slot = "12")]
		public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x2D2413C", Offset = "0x2D2013C", VA = "0x2D2413C", Slot = "13")]
		public virtual void FinishRendering(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x2D24140", Offset = "0x2D20140", VA = "0x2D24140", Slot = "14")]
		internal virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2D24144", Offset = "0x2D20144", VA = "0x2D24144")]
		private void InitRenderGraphFrame(RenderGraph renderGraph, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2D2436C", Offset = "0x2D2036C", VA = "0x2D2436C")]
		internal void ProcessVFXCameraCommand(RenderGraph renderGraph, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x2D2458C", Offset = "0x2D2058C", VA = "0x2D2458C")]
		internal void SetupRenderGraphCameraProperties(RenderGraph renderGraph, ref RenderingData renderingData, bool isTargetBackbuffer)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x2D247D8", Offset = "0x2D207D8", VA = "0x2D247D8")]
		internal void DrawRenderGraphGizmos(RenderGraph renderGraph, TextureHandle color, TextureHandle depth, GizmoSubset gizmoSubset, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2D24A50", Offset = "0x2D20A50", VA = "0x2D24A50")]
		private void BeginRenderGraphXRRendering(RenderGraph renderGraph, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2D24C80", Offset = "0x2D20C80", VA = "0x2D24C80")]
		private void EndRenderGraphXRRendering(RenderGraph renderGraph, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x2D24EB0", Offset = "0x2D20EB0", VA = "0x2D24EB0")]
		internal void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x2D25180", Offset = "0x2D21180", VA = "0x2D25180")]
		internal void FinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x2D253F8", Offset = "0x2D213F8", VA = "0x2D253F8", Slot = "15")]
		internal virtual void OnFinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x2D253FC", Offset = "0x2D213FC", VA = "0x2D253FC")]
		internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData, RenderPassEvent injectionPoint)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x2D2559C", Offset = "0x2D2159C", VA = "0x2D2559C")]
		internal void SetPerCameraProperties(ScriptableRenderContext context, ref CameraData cameraData, Camera camera, CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x2D256A0", Offset = "0x2D216A0", VA = "0x2D256A0")]
		public void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x2D27264", Offset = "0x2D23264", VA = "0x2D27264")]
		public void EnqueuePass(ScriptableRenderPass pass)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x2D27314", Offset = "0x2D23314", VA = "0x2D27314")]
		protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData)
		{
			return default(ClearFlag);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x2D2748C", Offset = "0x2D2348C", VA = "0x2D2748C")]
		internal void OnPreCullRenderPasses(in CameraData cameraData)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x2D27550", Offset = "0x2D23550", VA = "0x2D27550")]
		internal void AddRenderPasses(ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2D26594", Offset = "0x2D22594", VA = "0x2D26594")]
		protected void SetupRenderPasses(in RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x2D268E0", Offset = "0x2D228E0", VA = "0x2D268E0")]
		private static void ClearRenderingState(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2D23C94", Offset = "0x2D1FC94", VA = "0x2D23C94")]
		internal void Clear(CameraRenderType cameraType)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x2D26CEC", Offset = "0x2D22CEC", VA = "0x2D26CEC")]
		private void ExecuteBlock(int blockIndex, in RenderBlocks renderBlocks, ScriptableRenderContext context, ref RenderingData renderingData, bool submit = false)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x2D1F254", Offset = "0x2D1B254", VA = "0x2D1F254")]
		private bool IsRenderPassEnabled(ScriptableRenderPass renderPass)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x2D2781C", Offset = "0x2D2381C", VA = "0x2D2781C")]
		private void ExecuteRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2D27BE0", Offset = "0x2D23BE0", VA = "0x2D27BE0")]
		private void SetRenderPassAttachments(CommandBuffer cmd, ScriptableRenderPass renderPass, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2D26E74", Offset = "0x2D22E74", VA = "0x2D26E74")]
		private void BeginXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2D27008", Offset = "0x2D23008", VA = "0x2D27008")]
		private void EndXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x2D1D660", Offset = "0x2D19660", VA = "0x2D1D660")]
		[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
		internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x2D29924", Offset = "0x2D25924", VA = "0x2D29924")]
		internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2D29450", Offset = "0x2D25450", VA = "0x2D29450")]
		[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
		internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2D29188", Offset = "0x2D25188", VA = "0x2D29188")]
		internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2D29E48", Offset = "0x2D25E48", VA = "0x2D29E48")]
		[Obsolete("Use RTHandle for colorAttachment")]
		private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2D29F2C", Offset = "0x2D25F2C", VA = "0x2D29F2C")]
		private static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2D29738", Offset = "0x2D25738", VA = "0x2D29738")]
		[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
		private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2D29CB0", Offset = "0x2D25CB0", VA = "0x2D29CB0")]
		private static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2D28F64", Offset = "0x2D24F64", VA = "0x2D28F64")]
		[Obsolete("Use RTHandles for colorAttachments and depthAttachment")]
		private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2D29080", Offset = "0x2D25080", VA = "0x2D29080")]
		[Obsolete("Use RTHandle for colorAttachments")]
		private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorAttachments, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2D29FFC", Offset = "0x2D25FFC", VA = "0x2D29FFC")]
		private static void SetRenderTarget(CommandBuffer cmd, RTHandle[] colorAttachments, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x2D2A220", Offset = "0x2D26220", VA = "0x2D2A220", Slot = "16")]
		internal virtual void SwapColorBuffer(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x2D2A224", Offset = "0x2D26224", VA = "0x2D2A224", Slot = "17")]
		internal virtual void EnableSwapBufferMSAA(bool enable)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x2D2A228", Offset = "0x2D26228", VA = "0x2D2A228")]
		[Conditional("UNITY_EDITOR")]
		private void DrawGizmos(ScriptableRenderContext context, Camera camera, GizmoSubset gizmoSubset, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x2D2A22C", Offset = "0x2D2622C", VA = "0x2D2A22C")]
		[Conditional("UNITY_EDITOR")]
		private void DrawWireOverlay(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x2D2672C", Offset = "0x2D2272C", VA = "0x2D2672C")]
		private void InternalStartRendering(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x2D251E0", Offset = "0x2D211E0", VA = "0x2D251E0")]
		private void InternalFinishRendering(bool resolveFinalTarget, RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x2D271A0", Offset = "0x2D231A0", VA = "0x2D271A0")]
		private void InternalFinishRendering(ScriptableRenderContext context, bool resolveFinalTarget, RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x2D25020", Offset = "0x2D21020", VA = "0x2D25020")]
		internal static void SortStable(List<ScriptableRenderPass> list)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F4")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Bloom", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class Bloom : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The number of final iterations to skip in the effect processing sequence.")]
		[Obsolete("This is obsolete, please use maxIterations instead.", false)]
		public ClampedIntParameter skipIterations;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
		[Header("Bloom")]
		public MinFloatParameter threshold;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Strength of the bloom filter.")]
		public MinFloatParameter intensity;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Set the radius of the bloom effect.")]
		public ClampedFloatParameter scatter;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Set the maximum intensity that Unity uses to calculate Bloom. If pixels in your Scene are more intense than this, URP renders them at their current intensity, but uses this intensity value for the purposes of Bloom calculations.")]
		public MinFloatParameter clamp;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Use the color picker to select a color for the Bloom effect to tint to.")]
		public ColorParameter tint;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Use bicubic sampling instead of bilinear sampling for the upsampling passes. This is slightly more expensive but helps getting smoother visuals.")]
		public BoolParameter highQualityFiltering;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AdditionalProperty]
		[Tooltip("The starting resolution that this effect begins processing.")]
		public DownscaleParameter downscale;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The maximum number of iterations in the effect processing sequence.")]
		[AdditionalProperty]
		public ClampedIntParameter maxIterations;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Lens Dirt")]
		[Tooltip("Dirtiness texture to add smudges or dust to the bloom effect.")]
		public TextureParameter dirtTexture;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("Amount of dirtiness.")]
		public MinFloatParameter dirtIntensity;

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x2D2BE58", Offset = "0x2D27E58", VA = "0x2D2BE58", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x2D2BE88", Offset = "0x2D27E88", VA = "0x2D2BE88", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x2D2BE90", Offset = "0x2D27E90", VA = "0x2D2BE90")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[Conditional("UNITY_EDITOR")]
	internal class URPHelpURLAttribute : CoreRPHelpURLAttribute
	{
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x2D2C170", Offset = "0x2D28170", VA = "0x2D2C170")]
		public URPHelpURLAttribute(string pageName, string pageHash = "")
		{
		}
	}
	[Token(Token = "0x20000F6")]
	internal class Documentation : DocumentationInfo
	{
		[Token(Token = "0x400052E")]
		public const string packageName = "com.unity.render-pipelines.universal";

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x2D2C1D4", Offset = "0x2D281D4", VA = "0x2D2C1D4")]
		public Documentation()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F7")]
	[Obsolete("ForwardRendererData has been deprecated (UnityUpgradable) -> UniversalRendererData", true)]
	[ReloadGroup]
	[ExcludeFromPreset]
	public class ForwardRendererData : ScriptableRendererData
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Reload("Shaders/Utils/Blit.shader", ReloadAttribute.Package.Root)]
			public Shader blitPS;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Reload("Shaders/Utils/CopyDepth.shader", ReloadAttribute.Package.Root)]
			public Shader copyDepthPS;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Obsolete("Obsolete, this feature will be supported by new 'ScreenSpaceShadows' renderer feature")]
			public Shader screenSpaceShadowPS;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Reload("Shaders/Utils/Sampling.shader", ReloadAttribute.Package.Root)]
			public Shader samplingPS;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Reload("Shaders/Utils/StencilDeferred.shader", ReloadAttribute.Package.Root)]
			public Shader stencilDeferredPS;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Reload("Shaders/Utils/FallbackError.shader", ReloadAttribute.Package.Root)]
			public Shader fallbackErrorPS;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Reload("Shaders/Utils/FallbackLoading.shader", ReloadAttribute.Package.Root)]
			public Shader fallbackLoadingPS;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Obsolete("Use fallbackErrorPS instead")]
			[Reload("Shaders/Utils/MaterialError.shader", ReloadAttribute.Package.Root)]
			public Shader materialErrorPS;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[SerializeField]
			[Reload("Shaders/Utils/CoreBlit.shader", ReloadAttribute.Package.Root)]
			internal Shader coreBlitPS;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[SerializeField]
			[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", ReloadAttribute.Package.Root)]
			internal Shader coreBlitColorAndDepthPS;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Reload("Shaders/CameraMotionVectors.shader", ReloadAttribute.Package.Root)]
			public Shader cameraMotionVector;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Reload("Shaders/ObjectMotionVectors.shader", ReloadAttribute.Package.Root)]
			public Shader objectMotionVector;

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x2D2C630", Offset = "0x2D28630", VA = "0x2D2C630")]
			public ShaderResources()
			{
			}
		}

		[Token(Token = "0x400052F")]
		private const string k_ErrorMessage = "ForwardRendererData has been deprecated. Use UniversalRendererData instead";

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ShaderResources shaders;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PostProcessData postProcessData;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Reload("Runtime/Data/XRSystemData.asset", ReloadAttribute.Package.Root)]
		public XRSystemData xrSystemData;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LayerMask m_OpaqueLayerMask;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private LayerMask m_TransparentLayerMask;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StencilStateData m_DefaultStencilState;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool m_ShadowTransparentReceive;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private RenderingMode m_RenderingMode;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DepthPrimingMode m_DepthPrimingMode;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private bool m_AccurateGbufferNormals;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		[SerializeField]
		private bool m_ClusteredRendering;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TileSize m_TileSize;

		[Token(Token = "0x17000174")]
		public LayerMask opaqueLayerMask
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x2D2C298", Offset = "0x2D28298", VA = "0x2D2C298")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x2D2C2E4", Offset = "0x2D282E4", VA = "0x2D2C2E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public LayerMask transparentLayerMask
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x2D2C330", Offset = "0x2D28330", VA = "0x2D2C330")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x2D2C37C", Offset = "0x2D2837C", VA = "0x2D2C37C")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public StencilStateData defaultStencilState
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x2D2C3C8", Offset = "0x2D283C8", VA = "0x2D2C3C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x2D2C414", Offset = "0x2D28414", VA = "0x2D2C414")]
			set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public bool shadowTransparentReceive
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x2D2C460", Offset = "0x2D28460", VA = "0x2D2C460")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x2D2C4AC", Offset = "0x2D284AC", VA = "0x2D2C4AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x2D2C4F8", Offset = "0x2D284F8", VA = "0x2D2C4F8")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x2D2C544", Offset = "0x2D28544", VA = "0x2D2C544")]
			set
			{
			}
		}

		[Token(Token = "0x17000179")]
		public bool accurateGbufferNormals
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x2D2C590", Offset = "0x2D28590", VA = "0x2D2C590")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x2D2C5DC", Offset = "0x2D285DC", VA = "0x2D2C5DC")]
			set
			{
			}
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x2D2C1DC", Offset = "0x2D281DC", VA = "0x2D2C1DC", Slot = "4")]
		protected override ScriptableRenderer Create()
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x2D2C628", Offset = "0x2D28628", VA = "0x2D2C628")]
		public ForwardRendererData()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public enum IntermediateTextureMode
	{
		[Token(Token = "0x4000549")]
		Auto,
		[Token(Token = "0x400054A")]
		Always
	}
	[Token(Token = "0x20000FA")]
	internal class LightCookieManager : IDisposable
	{
		[Token(Token = "0x20000FB")]
		private static class ShaderProperty
		{
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int mainLightTexture;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int mainLightWorldToLight;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int mainLightCookieTextureFormat;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int additionalLightsCookieAtlasTexture;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int additionalLightsCookieAtlasTextureFormat;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly int additionalLightsCookieEnableBits;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly int additionalLightsCookieAtlasUVRectBuffer;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly int additionalLightsCookieAtlasUVRects;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly int additionalLightsWorldToLightBuffer;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static readonly int additionalLightsLightTypeBuffer;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static readonly int additionalLightsWorldToLights;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public static readonly int additionalLightsLightTypes;
		}

		[Token(Token = "0x20000FC")]
		private enum LightCookieShaderFormat
		{
			[Token(Token = "0x4000563")]
			None = -1,
			[Token(Token = "0x4000564")]
			RGB,
			[Token(Token = "0x4000565")]
			Alpha,
			[Token(Token = "0x4000566")]
			Red
		}

		[Token(Token = "0x20000FD")]
		public struct Settings
		{
			[Token(Token = "0x20000FE")]
			public struct AtlasSettings
			{
				[Token(Token = "0x400056B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public Vector2Int resolution;

				[Token(Token = "0x400056C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public GraphicsFormat format;

				[Token(Token = "0x400056D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public bool useMips;

				[Token(Token = "0x1700017B")]
				public bool isPow2
				{
					[Token(Token = "0x6000656")]
					[Address(RVA = "0x2D2C89C", Offset = "0x2D2889C", VA = "0x2D2C89C")]
					get
					{
						return default(bool);
					}
				}

				[Token(Token = "0x1700017C")]
				public bool isSquare
				{
					[Token(Token = "0x6000657")]
					[Address(RVA = "0x2D2F1FC", Offset = "0x2D2B1FC", VA = "0x2D2F1FC")]
					get
					{
						return default(bool);
					}
				}
			}

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AtlasSettings atlas;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int maxAdditionalLights;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float cubeOctahedralSizeScale;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool useStructuredBuffer;

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x2D2F144", Offset = "0x2D2B144", VA = "0x2D2F144")]
			public static Settings Create()
			{
				return default(Settings);
			}
		}

		[Token(Token = "0x20000FF")]
		private struct Sorting
		{
			[Token(Token = "0x6000658")]
			public static void QuickSort<T>(T[] data, Func<T, T, int> compare)
			{
			}

			[Token(Token = "0x6000659")]
			public static void QuickSort<T>(T[] data, int start, int end, Func<T, T, int> compare)
			{
			}

			[Token(Token = "0x600065A")]
			private static T Median3Pivot<T>(T[] data, int start, int pivot, int end, Func<T, T, int> compare)
			{
				return (T)null;
			}

			[Token(Token = "0x600065B")]
			private static int Partition<T>(T[] data, int start, int end, Func<T, T, int> compare)
			{
				return default(int);
			}

			[Token(Token = "0x600065C")]
			public static void InsertionSort<T>(T[] data, int start, int end, Func<T, T, int> compare)
			{
			}
		}

		[Token(Token = "0x2000101")]
		private struct LightCookieMapping
		{
			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ushort visibleLightIndex;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public ushort lightBufferIndex;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Light light;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<LightCookieMapping, LightCookieMapping, int> s_CompareByCookieSize;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<LightCookieMapping, LightCookieMapping, int> s_CompareByBufferIndex;
		}

		[Token(Token = "0x2000103")]
		private readonly struct WorkSlice<T>
		{
			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly T[] m_Data;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int m_Start;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int m_Length;

			[Token(Token = "0x1700017D")]
			public T this[int index]
			{
				[Token(Token = "0x6000665")]
				get
				{
					return (T)null;
				}
				[Token(Token = "0x6000666")]
				set
				{
				}
			}

			[Token(Token = "0x1700017E")]
			public int length
			{
				[Token(Token = "0x6000667")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700017F")]
			public int capacity
			{
				[Token(Token = "0x6000668")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000663")]
			public WorkSlice(T[] src, int srcLen = -1)
			{
			}

			[Token(Token = "0x6000664")]
			public WorkSlice(T[] src, int srcStart, int srcLen = -1)
			{
			}

			[Token(Token = "0x6000669")]
			public void Sort(Func<T, T, int> compare)
			{
			}
		}

		[Token(Token = "0x2000104")]
		private class WorkMemory
		{
			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LightCookieMapping[] lightMappings;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector4[] uvRects;

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x2D2D484", Offset = "0x2D29484", VA = "0x2D2D484")]
			public void Resize(int size)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x2D2C6E4", Offset = "0x2D286E4", VA = "0x2D2C6E4")]
			public WorkMemory()
			{
			}
		}

		[Token(Token = "0x2000105")]
		private struct ShaderBitArray
		{
			[Token(Token = "0x400057A")]
			private const int k_BitsPerElement = 32;

			[Token(Token = "0x400057B")]
			private const int k_ElementShift = 5;

			[Token(Token = "0x400057C")]
			private const int k_ElementMask = 31;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float[] m_Data;

			[Token(Token = "0x17000180")]
			public int elemLength
			{
				[Token(Token = "0x600066C")]
				[Address(RVA = "0x2D2F45C", Offset = "0x2D2B45C", VA = "0x2D2F45C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000181")]
			public int bitCapacity
			{
				[Token(Token = "0x600066D")]
				[Address(RVA = "0x2D2F474", Offset = "0x2D2B474", VA = "0x2D2F474")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000182")]
			public float[] data
			{
				[Token(Token = "0x600066E")]
				[Address(RVA = "0x2D2F490", Offset = "0x2D2B490", VA = "0x2D2F490")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000183")]
			public bool this[int index]
			{
				[Token(Token = "0x6000672")]
				[Address(RVA = "0x2D2F5F4", Offset = "0x2D2B5F4", VA = "0x2D2F5F4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000673")]
				[Address(RVA = "0x2D2EC58", Offset = "0x2D2AC58", VA = "0x2D2EC58")]
				set
				{
				}
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x2D2F498", Offset = "0x2D2B498", VA = "0x2D2F498")]
			public void Resize(int bitCount)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x2D2EC10", Offset = "0x2D2AC10", VA = "0x2D2EC10")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x2D2F5E0", Offset = "0x2D2B5E0", VA = "0x2D2F5E0")]
			private void GetElementIndexAndBitOffset(int index, out int elemIndex, out int bitOffset)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x2D2F620", Offset = "0x2D2B620", VA = "0x2D2F620", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x2000106")]
		private class LightCookieShaderData : IDisposable
		{
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_Size;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool m_UseStructuredBuffer;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Matrix4x4[] m_WorldToLightCpuData;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector4[] m_AtlasUVRectCpuData;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float[] m_LightTypeCpuData;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ShaderBitArray m_CookieEnableBitsCpuData;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ComputeBuffer m_WorldToLightBuffer;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ComputeBuffer m_AtlasUVRectBuffer;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ComputeBuffer m_LightTypeBuffer;

			[Token(Token = "0x17000184")]
			public Matrix4x4[] worldToLights
			{
				[Token(Token = "0x6000675")]
				[Address(RVA = "0x2D2F784", Offset = "0x2D2B784", VA = "0x2D2F784")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000185")]
			public ShaderBitArray cookieEnableBits
			{
				[Token(Token = "0x6000676")]
				[Address(RVA = "0x2D2F78C", Offset = "0x2D2B78C", VA = "0x2D2F78C")]
				get
				{
					return default(ShaderBitArray);
				}
			}

			[Token(Token = "0x17000186")]
			public Vector4[] atlasUVRects
			{
				[Token(Token = "0x6000677")]
				[Address(RVA = "0x2D2F794", Offset = "0x2D2B794", VA = "0x2D2F794")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000187")]
			public float[] lightTypes
			{
				[Token(Token = "0x6000678")]
				[Address(RVA = "0x2D2F79C", Offset = "0x2D2B79C", VA = "0x2D2F79C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000188")]
			public bool isUploaded
			{
				[Token(Token = "0x6000679")]
				[Address(RVA = "0x2D2F7A4", Offset = "0x2D2B7A4", VA = "0x2D2F7A4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600067A")]
				[Address(RVA = "0x2D2F7AC", Offset = "0x2D2B7AC", VA = "0x2D2F7AC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x2D2C8D0", Offset = "0x2D288D0", VA = "0x2D2C8D0")]
			public LightCookieShaderData(int size, bool useStructuredBuffer)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x2D2C954", Offset = "0x2D28954", VA = "0x2D2C954", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x2D2EA2C", Offset = "0x2D2AA2C", VA = "0x2D2EA2C")]
			public void Resize(int size)
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x2D2EC98", Offset = "0x2D2AC98", VA = "0x2D2EC98")]
			public void Upload(CommandBuffer cmd)
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x2D2D1F4", Offset = "0x2D291F4", VA = "0x2D2D1F4")]
			public void Clear(CommandBuffer cmd)
			{
			}
		}

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Matrix4x4 s_DirLightProj;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Texture2DAtlas m_AdditionalLightsCookieAtlas;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LightCookieShaderData m_AdditionalLightsCookieShaderData;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Settings m_Settings;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WorkMemory m_WorkMem;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int[] m_VisibleLightIndexToShaderDataIndex;

		[Token(Token = "0x4000551")]
		private const int k_MaxCookieSizeDivisor = 16;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_CookieSizeDivisor;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private uint m_PrevCookieRequestPixelCount;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_PrevWarnFrame;

		[Token(Token = "0x1700017A")]
		internal bool IsKeywordLightCookieEnabled
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x2D2C638", Offset = "0x2D28638", VA = "0x2D2C638")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x2D2C640", Offset = "0x2D28640", VA = "0x2D2C640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x2D2C648", Offset = "0x2D28648", VA = "0x2D2C648")]
		public LightCookieManager(ref Settings settings)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2D2C6EC", Offset = "0x2D286EC", VA = "0x2D2C6EC")]
		private void InitAdditionalLights(int size)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2D2C904", Offset = "0x2D28904", VA = "0x2D2C904")]
		public bool isInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x2D2C924", Offset = "0x2D28924", VA = "0x2D2C924", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x2D2C99C", Offset = "0x2D2899C", VA = "0x2D2C99C")]
		public int GetLightCookieShaderDataIndex(int visibleLightIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x2D2C9E4", Offset = "0x2D289E4", VA = "0x2D2C9E4")]
		public void Setup(ScriptableRenderContext ctx, CommandBuffer cmd, ref LightData lightData)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2D2CC78", Offset = "0x2D28C78", VA = "0x2D2CC78")]
		private bool SetupMainLight(CommandBuffer cmd, ref VisibleLight visibleMainLight)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x2D2D280", Offset = "0x2D29280", VA = "0x2D2D280")]
		private LightCookieShaderFormat GetLightCookieShaderFormat(GraphicsFormat cookieFormat)
		{
			return default(LightCookieShaderFormat);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x2D2D360", Offset = "0x2D29360", VA = "0x2D2D360")]
		private void GetLightUVScaleOffset(ref UniversalAdditionalLightData additionalLightData, ref Matrix4x4 uvTransform)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x2D2D060", Offset = "0x2D29060", VA = "0x2D2D060")]
		private bool SetupAdditionalLights(CommandBuffer cmd, ref LightData lightData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x2D2D5B4", Offset = "0x2D295B4", VA = "0x2D2D5B4")]
		private int FilterAndValidateAdditionalLights(ref LightData lightData, LightCookieMapping[] validLightMappings)
		{
			return default(int);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2D2D9D0", Offset = "0x2D299D0", VA = "0x2D2D9D0")]
		private int UpdateAdditionalLightsAtlas(CommandBuffer cmd, ref WorkSlice<LightCookieMapping> validLightMappings, Vector4[] textureAtlasUVRects)
		{
			return default(int);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2D2E1B0", Offset = "0x2D2A1B0", VA = "0x2D2E1B0")]
		private int FetchUVRects(CommandBuffer cmd, ref WorkSlice<LightCookieMapping> validLightMappings, Vector4[] textureAtlasUVRects, int cookieSizeDivisor)
		{
			return default(int);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2D2E088", Offset = "0x2D2A088", VA = "0x2D2E088")]
		private uint ComputeCookieRequestPixelCount(ref WorkSlice<LightCookieMapping> validLightMappings)
		{
			return default(uint);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2D2E184", Offset = "0x2D2A184", VA = "0x2D2E184")]
		private int ApproximateCookieSizeDivisor(float requestAtlasRatio)
		{
			return default(int);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2D2E568", Offset = "0x2D2A568", VA = "0x2D2E568")]
		private Vector4 Fetch2D(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2D2E408", Offset = "0x2D2A408", VA = "0x2D2E408")]
		private Vector4 FetchCube(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2D2E868", Offset = "0x2D2A868", VA = "0x2D2E868")]
		private int ComputeOctahedralCookieSize(Texture cookie)
		{
			return default(int);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x2D2E6BC", Offset = "0x2D2A6BC", VA = "0x2D2E6BC")]
		private void AdjustUVRect(ref Vector4 uvScaleOffset, Texture cookie, ref Vector2 cookieSize)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2D2E988", Offset = "0x2D2A988", VA = "0x2D2E988")]
		private void ShrinkUVRect(ref Vector4 uvScaleOffset, float amountPixels, ref Vector2 cookieSize)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x2D2DB4C", Offset = "0x2D29B4C", VA = "0x2D2DB4C")]
		private void UploadAdditionalLights(CommandBuffer cmd, ref LightData lightData, ref WorkSlice<LightCookieMapping> validLightMappings, ref WorkSlice<Vector4> validUvRects)
		{
		}
	}
	[Token(Token = "0x2000107")]
	internal struct BuddyAllocation
	{
		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int level;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int index;

		[Token(Token = "0x17000189")]
		public uint2 index2D
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x2D2F7BC", Offset = "0x2D2B7BC", VA = "0x2D2F7BC")]
			get
			{
				return default(uint2);
			}
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x2D2F7B4", Offset = "0x2D2B7B4", VA = "0x2D2F7B4")]
		public BuddyAllocation(int level, int index)
		{
		}
	}
	[Token(Token = "0x2000108")]
	internal struct BuddyAllocator : IDisposable
	{
		[Token(Token = "0x2000109")]
		private struct Header
		{
			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int branchingOrder;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int levelCount;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int allocationCount;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int freeAllocationIdsCount;
		}

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private unsafe void* m_Data;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private (int, int) m_ActiveFreeMaskCounts;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private (int, int) m_FreeMasksStorage;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private (int, int) m_FreeMaskIndicesStorage;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Allocator m_Allocator;

		[Token(Token = "0x1700018A")]
		private unsafe ref Header header
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x2D2F7C8", Offset = "0x2D2B7C8", VA = "0x2D2F7C8")]
			get
			{
				return ref *(Header*)null;
			}
		}

		[Token(Token = "0x1700018B")]
		private NativeArray<int> freeMaskCounts
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x2D2F804", Offset = "0x2D2B804", VA = "0x2D2F804")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Token(Token = "0x1700018C")]
		private NativeArray<ulong> freeMasksStorage
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x2D2F850", Offset = "0x2D2B850", VA = "0x2D2F850")]
			get
			{
				return default(NativeArray<ulong>);
			}
		}

		[Token(Token = "0x1700018D")]
		private NativeArray<int> freeMaskIndicesStorage
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x2D2F9D0", Offset = "0x2D2B9D0", VA = "0x2D2F9D0")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Token(Token = "0x1700018E")]
		public int levelCount
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x2D2FAF4", Offset = "0x2D2BAF4", VA = "0x2D2FAF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2D2F89C", Offset = "0x2D2B89C", VA = "0x2D2F89C")]
		private NativeArray<ulong> FreeMasks(int level)
		{
			return default(NativeArray<ulong>);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2D2FA1C", Offset = "0x2D2BA1C", VA = "0x2D2FA1C")]
		private NativeArray<int> FreeMaskIndices(int level)
		{
			return default(NativeArray<int>);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x2D2FB34", Offset = "0x2D2BB34", VA = "0x2D2FB34")]
		public BuddyAllocator(int levelCount, int branchingOrder, Allocator allocator = Allocator.Persistent)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x2D2FC94", Offset = "0x2D2BC94", VA = "0x2D2FC94")]
		public bool TryAllocate(int requestedLevel, out BuddyAllocation allocation)
		{
			return default(bool);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x2D2FEA0", Offset = "0x2D2BEA0", VA = "0x2D2FEA0")]
		public void Free(BuddyAllocation allocation)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x2D30000", Offset = "0x2D2C000", VA = "0x2D30000", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600068D")]
		private NativeArray<T> GetNativeArray<T>(int offset, int length) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x2D30028", Offset = "0x2D2C028", VA = "0x2D30028")]
		private static int LevelOffset(int level, int branchingOrder)
		{
			return default(int);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x2D30048", Offset = "0x2D2C048", VA = "0x2D30048")]
		private static int LevelLength(int level, int branchingOrder)
		{
			return default(int);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x2D2F974", Offset = "0x2D2B974", VA = "0x2D2F974")]
		private static int LevelOffset64(int level, int branchingOrder)
		{
			return default(int);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x2D2F9AC", Offset = "0x2D2B9AC", VA = "0x2D2F9AC")]
		private static int LevelLength64(int level, int branchingOrder)
		{
			return default(int);
		}

		[Token(Token = "0x6000692")]
		private static (int, int) AllocateRange<T>(int length, ref int dataSize) where T : struct
		{
			return default((int, int));
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x2D30068", Offset = "0x2D2C068", VA = "0x2D30068")]
		private static int AlignForward(int offset, int alignment)
		{
			return default(int);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x2D30084", Offset = "0x2D2C084", VA = "0x2D30084")]
		private unsafe static void* PtrAdd(void* ptr, int bytes)
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)null);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x2D2FE94", Offset = "0x2D2BE94", VA = "0x2D2FE94")]
		private static int Pow2(int n)
		{
			return default(int);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x2D30058", Offset = "0x2D2C058", VA = "0x2D30058")]
		private static int Pow2N(int x, int n)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200010A")]
	internal struct Fixed2<T> where T : struct
	{
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T item1;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T item2;

		[Token(Token = "0x1700018F")]
		public T this[int index]
		{
			[Token(Token = "0x6000699")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x600069A")]
			set
			{
			}
		}

		[Token(Token = "0x6000697")]
		public Fixed2(T item1)
		{
		}

		[Token(Token = "0x6000698")]
		public Fixed2(T item1, T item2)
		{
		}

		[Token(Token = "0x600069B")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private static void CheckRange(int index)
		{
		}
	}
	[Token(Token = "0x200010B")]
	internal struct PinnedArray<T> : IDisposable where T : struct
	{
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] managedArray;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GCHandle handle;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NativeArray<T> nativeArray;

		[Token(Token = "0x17000190")]
		public int length
		{
			[Token(Token = "0x600069C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600069D")]
		public PinnedArray(int length)
		{
		}

		[Token(Token = "0x600069E")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200010C")]
	internal sealed class MotionVectorsPersistentData
	{
		[Token(Token = "0x4000598")]
		private const int k_EyeCount = 2;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Matrix4x4[] m_ViewProjection;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Matrix4x4[] m_PreviousViewProjection;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int[] m_LastFrameIndex;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly float[] m_PrevAspectRatio;

		[Token(Token = "0x17000191")]
		internal int lastFrameIndex
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x2D3029C", Offset = "0x2D2C29C", VA = "0x2D3029C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000192")]
		internal Matrix4x4 viewProjection
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x2D302C4", Offset = "0x2D2C2C4", VA = "0x2D302C4")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x17000193")]
		internal Matrix4x4 previousViewProjection
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x2D302F8", Offset = "0x2D2C2F8", VA = "0x2D302F8")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x17000194")]
		internal Matrix4x4[] viewProjectionStereo
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x2D3032C", Offset = "0x2D2C32C", VA = "0x2D3032C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000195")]
		internal Matrix4x4[] previousViewProjectionStereo
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x2D30334", Offset = "0x2D2C334", VA = "0x2D30334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x2D300AC", Offset = "0x2D2C0AC", VA = "0x2D300AC")]
		internal MotionVectorsPersistentData()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2D30178", Offset = "0x2D2C178", VA = "0x2D30178")]
		public void Reset()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2D3033C", Offset = "0x2D2C33C", VA = "0x2D3033C")]
		internal int GetXRMultiPassId(ref CameraData cameraData)
		{
			return default(int);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x2D30378", Offset = "0x2D2C378", VA = "0x2D30378")]
		public void Update(ref CameraData cameraData)
		{
		}
	}
	[Token(Token = "0x200010D")]
	public enum BloomDownscaleMode
	{
		[Token(Token = "0x400059E")]
		Half,
		[Token(Token = "0x400059F")]
		Quarter
	}
	[Serializable]
	[Token(Token = "0x200010E")]
	public sealed class DownscaleParameter : VolumeParameter<BloomDownscaleMode>
	{
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2D2C110", Offset = "0x2D28110", VA = "0x2D2C110")]
		public DownscaleParameter(BloomDownscaleMode value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010F")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Channel Mixer", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class ChannelMixer : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Modify influence of the red channel in the overall mix.")]
		public ClampedFloatParameter redOutRedIn;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Modify influence of the green channel in the overall mix.")]
		public ClampedFloatParameter redOutGreenIn;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Modify influence of the blue channel in the overall mix.")]
		public ClampedFloatParameter redOutBlueIn;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Modify influence of the red channel in the overall mix.")]
		public ClampedFloatParameter greenOutRedIn;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Modify influence of the green channel in the overall mix.")]
		public ClampedFloatParameter greenOutGreenIn;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Modify influence of the blue channel in the overall mix.")]
		public ClampedFloatParameter greenOutBlueIn;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Modify influence of the red channel in the overall mix.")]
		public ClampedFloatParameter blueOutRedIn;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Modify influence of the green channel in the overall mix.")]
		public ClampedFloatParameter blueOutGreenIn;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Modify influence of the blue channel in the overall mix.")]
		public ClampedFloatParameter blueOutBlueIn;

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x2D30864", Offset = "0x2D2C864", VA = "0x2D30864", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x2D309B8", Offset = "0x2D2C9B8", VA = "0x2D309B8", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x2D309C0", Offset = "0x2D2C9C0", VA = "0x2D309C0")]
		public ChannelMixer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000110")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Chromatic Aberration", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class ChromaticAberration : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Use the slider to set the strength of the Chromatic Aberration effect.")]
		public ClampedFloatParameter intensity;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x2D30B98", Offset = "0x2D2CB98", VA = "0x2D30B98", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x2D30BC8", Offset = "0x2D2CBC8", VA = "0x2D30BC8", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x2D30BD0", Offset = "0x2D2CBD0", VA = "0x2D30BD0")]
		public ChromaticAberration()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000111")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Color Adjustments", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class ColorAdjustments : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Adjusts the overall exposure of the scene in EV100. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
		public FloatParameter postExposure;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Expands or shrinks the overall range of tonal values.")]
		public ClampedFloatParameter contrast;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Tint the render by multiplying a color.")]
		public ColorParameter colorFilter;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Shift the hue of all colors.")]
		public ClampedFloatParameter hueShift;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Pushes the intensity of all colors.")]
		public ClampedFloatParameter saturation;

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x2D30C40", Offset = "0x2D2CC40", VA = "0x2D30C40", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x2D30D28", Offset = "0x2D2CD28", VA = "0x2D30D28", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x2D30D30", Offset = "0x2D2CD30", VA = "0x2D30D30")]
		public ColorAdjustments()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000112")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Color Curves", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class ColorCurves : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Affects the luminance across the whole image.")]
		public TextureCurveParameter master;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Affects the red channel intensity across the whole image.")]
		public TextureCurveParameter red;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Affects the green channel intensity across the whole image.")]
		public TextureCurveParameter green;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Affects the blue channel intensity across the whole image.")]
		public TextureCurveParameter blue;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Shifts the input hue (x-axis) according to the output hue (y-axis).")]
		public TextureCurveParameter hueVsHue;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Adjusts saturation (y-axis) according to the input hue (x-axis).")]
		public TextureCurveParameter hueVsSat;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Adjusts saturation (y-axis) according to the input saturation (x-axis).")]
		public TextureCurveParameter satVsSat;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Adjusts saturation (y-axis) according to the input luminance (x-axis).")]
		public TextureCurveParameter lumVsSat;

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x2D30E98", Offset = "0x2D2CE98", VA = "0x2D30E98", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x2D30EA0", Offset = "0x2D2CEA0", VA = "0x2D30EA0", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x2D30EA8", Offset = "0x2D2CEA8", VA = "0x2D30EA8")]
		public ColorCurves()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000113")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Color Lookup", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class ColorLookup : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("A 2D Lookup Texture (LUT) to use for color grading.")]
		public TextureParameter texture;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
		public ClampedFloatParameter contribution;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x2D3145C", Offset = "0x2D2D45C", VA = "0x2D3145C", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x2D316EC", Offset = "0x2D2D6EC", VA = "0x2D316EC", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x2D314A0", Offset = "0x2D2D4A0", VA = "0x2D314A0")]
		public bool ValidateLUT()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2D316F4", Offset = "0x2D2D6F4", VA = "0x2D316F4")]
		public ColorLookup()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public enum DepthOfFieldMode
	{
		[Token(Token = "0x40005BA")]
		Off,
		[Token(Token = "0x40005BB")]
		Gaussian,
		[Token(Token = "0x40005BC")]
		Bokeh
	}
	[Serializable]
	[Token(Token = "0x2000115")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Depth Of Field", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class DepthOfField : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Use \"Gaussian\" for a faster but non physical depth of field; \"Bokeh\" for a more realistic but slower depth of field.")]
		public DepthOfFieldModeParameter mode;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The distance at which the blurring will start.")]
		public MinFloatParameter gaussianStart;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The distance at which the blurring will reach its maximum radius.")]
		public MinFloatParameter gaussianEnd;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The maximum radius of the gaussian blur. Values above 1 may show under-sampling artifacts.")]
		public ClampedFloatParameter gaussianMaxRadius;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Use higher quality sampling to reduce flickering and improve the overall blur smoothness.")]
		public BoolParameter highQualitySampling;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The distance to the point of focus.")]
		public MinFloatParameter focusDistance;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
		public ClampedFloatParameter aperture;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
		public ClampedFloatParameter focalLength;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The number of aperture blades.")]
		public ClampedIntParameter bladeCount;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The curvature of aperture blades. The smaller the value is, the more visible aperture blades are. A value of 1 will make the bokeh perfectly circular.")]
		public ClampedFloatParameter bladeCurvature;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("The rotation of aperture blades in degrees.")]
		public ClampedFloatParameter bladeRotation;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x2D317A0", Offset = "0x2D2D7A0", VA = "0x2D317A0", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2D31820", Offset = "0x2D2D820", VA = "0x2D31820", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x2D31828", Offset = "0x2D2D828", VA = "0x2D31828")]
		public DepthOfField()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000116")]
	public sealed class DepthOfFieldModeParameter : VolumeParameter<DepthOfFieldMode>
	{
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x2D31A80", Offset = "0x2D2DA80", VA = "0x2D31A80")]
		public DepthOfFieldModeParameter(DepthOfFieldMode value, bool overrideState = false)
		{
		}
	}
	[Token(Token = "0x2000117")]
	public enum FilmGrainLookup
	{
		[Token(Token = "0x40005C9")]
		Thin1,
		[Token(Token = "0x40005CA")]
		Thin2,
		[Token(Token = "0x40005CB")]
		Medium1,
		[Token(Token = "0x40005CC")]
		Medium2,
		[Token(Token = "0x40005CD")]
		Medium3,
		[Token(Token = "0x40005CE")]
		Medium4,
		[Token(Token = "0x40005CF")]
		Medium5,
		[Token(Token = "0x40005D0")]
		Medium6,
		[Token(Token = "0x40005D1")]
		Large01,
		[Token(Token = "0x40005D2")]
		Large02,
		[Token(Token = "0x40005D3")]
		Custom
	}
	[Serializable]
	[Token(Token = "0x2000118")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Film Grain", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class FilmGrain : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The type of grain to use. You can select a preset or provide your own texture by selecting Custom.")]
		public FilmGrainLookupParameter type;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Use the slider to set the strength of the Film Grain effect.")]
		public ClampedFloatParameter intensity;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Controls the noisiness response curve based on scene luminance. Higher values mean less noise in light areas.")]
		public ClampedFloatParameter response;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("A tileable texture to use for the grain. The neutral value is 0.5 where no grain is applied.")]
		public NoInterpTextureParameter texture;

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2D31AE0", Offset = "0x2D2DAE0", VA = "0x2D31AE0", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x2D31BB8", Offset = "0x2D2DBB8", VA = "0x2D31BB8", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2D31BC0", Offset = "0x2D2DBC0", VA = "0x2D31BC0")]
		public FilmGrain()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000119")]
	public sealed class FilmGrainLookupParameter : VolumeParameter<FilmGrainLookup>
	{
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x2D31CC8", Offset = "0x2D2DCC8", VA = "0x2D31CC8")]
		public FilmGrainLookupParameter(FilmGrainLookup value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011A")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Lens Distortion", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class LensDistortion : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Total distortion amount.")]
		public ClampedFloatParameter intensity;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Intensity multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
		public ClampedFloatParameter xMultiplier;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Intensity multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
		public ClampedFloatParameter yMultiplier;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Distortion center point. 0.5,0.5 is center of the screen")]
		public Vector2Parameter center;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Controls global screen scaling for the distortion effect. Use this to hide screen borders when using high \"Intensity.\"")]
		public ClampedFloatParameter scale;

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x2D31D28", Offset = "0x2D2DD28", VA = "0x2D31D28", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2D31DAC", Offset = "0x2D2DDAC", VA = "0x2D31DAC", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x2D31DB4", Offset = "0x2D2DDB4", VA = "0x2D31DB4")]
		public LensDistortion()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011B")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Lift, Gamma, Gain", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Use this to control and apply a hue to the dark tones. This has a more exaggerated effect on shadows.")]
		public Vector4Parameter lift;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Use this to control and apply a hue to the mid-range tones with a power function.")]
		public Vector4Parameter gamma;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Use this to increase and apply a hue to the signal and make highlights brighter.")]
		public Vector4Parameter gain;

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2D31EE0", Offset = "0x2D2DEE0", VA = "0x2D31EE0", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2D31F88", Offset = "0x2D2DF88", VA = "0x2D31F88", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x2D31F90", Offset = "0x2D2DF90", VA = "0x2D31F90")]
		public LiftGammaGain()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public enum MotionBlurMode
	{
		[Token(Token = "0x40005E1")]
		CameraOnly,
		[Token(Token = "0x40005E2")]
		CameraAndObjects
	}
	[Token(Token = "0x200011D")]
	public enum MotionBlurQuality
	{
		[Token(Token = "0x40005E4")]
		Low,
		[Token(Token = "0x40005E5")]
		Medium,
		[Token(Token = "0x40005E6")]
		High
	}
	[Serializable]
	[Token(Token = "0x200011E")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Motion Blur", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class MotionBlur : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The motion blur technique to use. If you don't need object motion blur, CameraOnly will result in better performance.")]
		public MotionBlurModeParameter mode;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The quality of the effect. Lower presets will result in better performance at the expense of visual quality.")]
		public MotionBlurQualityParameter quality;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The strength of the motion blur filter. Acts as a multiplier for velocities.")]
		public ClampedFloatParameter intensity;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Sets the maximum length, as a fraction of the screen's full resolution, that the velocity resulting from Camera rotation can have. Lower values will improve performance.")]
		public ClampedFloatParameter clamp;

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x2D3205C", Offset = "0x2D2E05C", VA = "0x2D3205C", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x2D320B8", Offset = "0x2D2E0B8", VA = "0x2D320B8", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x2D320C0", Offset = "0x2D2E0C0", VA = "0x2D320C0")]
		public MotionBlur()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011F")]
	public sealed class MotionBlurModeParameter : VolumeParameter<MotionBlurMode>
	{
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x2D321C8", Offset = "0x2D2E1C8", VA = "0x2D321C8")]
		public MotionBlurModeParameter(MotionBlurMode value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000120")]
	public sealed class MotionBlurQualityParameter : VolumeParameter<MotionBlurQuality>
	{
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x2D32228", Offset = "0x2D2E228", VA = "0x2D32228")]
		public MotionBlurQualityParameter(MotionBlurQuality value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000121")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Panini Projection", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class PaniniProjection : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Panini projection distance.")]
		public ClampedFloatParameter distance;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Panini projection crop to fit.")]
		public ClampedFloatParameter cropToFit;

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x2D32288", Offset = "0x2D2E288", VA = "0x2D32288", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x2D322B8", Offset = "0x2D2E2B8", VA = "0x2D322B8", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x2D322C0", Offset = "0x2D2E2C0", VA = "0x2D322C0")]
		public PaniniProjection()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000122")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Shadows, Midtones, Highlights", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Use this to control and apply a hue to the shadows.")]
		public Vector4Parameter shadows;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Use this to control and apply a hue to the midtones.")]
		public Vector4Parameter midtones;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Use this to control and apply a hue to the highlights.")]
		public Vector4Parameter highlights;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Start point of the transition between shadows and midtones.")]
		[Header("Shadow Limits")]
		public MinFloatParameter shadowsStart;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("End point of the transition between shadows and midtones.")]
		public MinFloatParameter shadowsEnd;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Start point of the transition between midtones and highlights.")]
		[Header("Highlight Limits")]
		public MinFloatParameter highlightsStart;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("End point of the transition between midtones and highlights.")]
		public MinFloatParameter highlightsEnd;

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x2D32358", Offset = "0x2D2E358", VA = "0x2D32358", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x2D32400", Offset = "0x2D2E400", VA = "0x2D32400", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x2D32408", Offset = "0x2D2E408", VA = "0x2D32408")]
		public ShadowsMidtonesHighlights()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000123")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Split Toning", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class SplitToning : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The color to use for shadows.")]
		public ColorParameter shadows;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The color to use for highlights.")]
		public ColorParameter highlights;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Balance between the colors in the highlights and shadows.")]
		public ClampedFloatParameter balance;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x2D32588", Offset = "0x2D2E588", VA = "0x2D32588", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2D32610", Offset = "0x2D2E610", VA = "0x2D32610", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x2D32618", Offset = "0x2D2E618", VA = "0x2D32618")]
		public SplitToning()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public enum TonemappingMode
	{
		[Token(Token = "0x40005F8")]
		None,
		[Token(Token = "0x40005F9")]
		Neutral,
		[Token(Token = "0x40005FA")]
		ACES
	}
	[Token(Token = "0x2000125")]
	public enum NeutralRangeReductionMode
	{
		[Token(Token = "0x40005FC")]
		Reinhard = 1,
		[Token(Token = "0x40005FD")]
		BT2390
	}
	[Token(Token = "0x2000126")]
	public enum HDRACESPreset
	{
		[Token(Token = "0x40005FF")]
		ACES1000Nits = 3,
		[Token(Token = "0x4000600")]
		ACES2000Nits,
		[Token(Token = "0x4000601")]
		ACES4000Nits
	}
	[Serializable]
	[Token(Token = "0x2000127")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Tonemapping", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class Tonemapping : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Select a tonemapping algorithm to use for the color grading process.")]
		public TonemappingModeParameter mode;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Specifies the range reduction mode used when HDR output is enabled and Neutral tonemapping is enabled.")]
		[AdditionalProperty]
		public NeutralRangeReductionModeParameter neutralHDRRangeReductionMode;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Use the ACES preset for HDR displays.")]
		public HDRACESPresetParameter acesPreset;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Specify how much hue to preserve. Values closer to 0 are likely to preserve hue. As values get closer to 1, Unity doesn't correct hue shifts.")]
		public ClampedFloatParameter hueShiftAmount;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Enable to use values detected from the output device as paper white. When enabled, output images might differ between SDR and HDR. For best accuracy, set this value manually.")]
		public BoolParameter detectPaperWhite;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The reference brightness of a paper white surface. This property determines the maximum brightness of UI. The brightness of the scene is scaled relative to this value. The value is in nits.")]
		public ClampedFloatParameter paperWhite;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Enable to use the minimum and maximum brightness values detected from the output device. For best accuracy, considering calibrating these values manually.")]
		public BoolParameter detectBrightnessLimits;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The minimum brightness of the screen (in nits). This value is assumed to be 0.005f with ACES Tonemap.")]
		public ClampedFloatParameter minNits;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The maximum brightness of the screen (in nits). This value is defined by the preset when using ACES Tonemap.")]
		public ClampedFloatParameter maxNits;

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2D3271C", Offset = "0x2D2E71C", VA = "0x2D3271C", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2D3274C", Offset = "0x2D2E74C", VA = "0x2D3274C", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x2D32754", Offset = "0x2D2E754", VA = "0x2D32754")]
		public Tonemapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000128")]
	public sealed class TonemappingModeParameter : VolumeParameter<TonemappingMode>
	{
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x2D32948", Offset = "0x2D2E948", VA = "0x2D32948")]
		public TonemappingModeParameter(TonemappingMode value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000129")]
	public sealed class NeutralRangeReductionModeParameter : VolumeParameter<NeutralRangeReductionMode>
	{
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x2D329A8", Offset = "0x2D2E9A8", VA = "0x2D329A8")]
		public NeutralRangeReductionModeParameter(NeutralRangeReductionMode value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012A")]
	public sealed class HDRACESPresetParameter : VolumeParameter<HDRACESPreset>
	{
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x2D32A08", Offset = "0x2D2EA08", VA = "0x2D32A08")]
		public HDRACESPresetParameter(HDRACESPreset value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012B")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Vignette", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class Vignette : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Vignette color.")]
		public ColorParameter color;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
		public Vector2Parameter center;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Amount of vignetting on screen.")]
		public ClampedFloatParameter intensity;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Smoothness of the vignette borders.")]
		public ClampedFloatParameter smoothness;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
		public BoolParameter rounded;

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x2D32A68", Offset = "0x2D2EA68", VA = "0x2D32A68", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x2D32A98", Offset = "0x2D2EA98", VA = "0x2D32A98", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x2D32AA0", Offset = "0x2D2EAA0", VA = "0x2D32AA0")]
		public Vignette()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012C")]
	[VolumeComponentMenuForRenderPipeline("Post-processing/White Balance", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent
	{
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Sets the white balance to a custom color temperature.")]
		public ClampedFloatParameter temperature;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
		public ClampedFloatParameter tint;

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x2D32C08", Offset = "0x2D2EC08", VA = "0x2D32C08", Slot = "8")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x2D32C64", Offset = "0x2D2EC64", VA = "0x2D32C64", Slot = "9")]
		public bool IsTileCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x2D32C6C", Offset = "0x2D2EC6C", VA = "0x2D32C6C")]
		public WhiteBalance()
		{
		}
	}
	[Token(Token = "0x200012D")]
	internal class CapturePass : ScriptableRenderPass
	{
		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RTHandle m_CameraColorHandle;

		[Token(Token = "0x4000613")]
		private const string m_ProfilerTag = "Capture Pass";

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2D32D1C", Offset = "0x2D2ED1C", VA = "0x2D32D1C")]
		public CapturePass(RenderPassEvent evt)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x2D32DCC", Offset = "0x2D2EDCC", VA = "0x2D32DCC", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x200012E")]
	internal class DrawScreenSpaceUIPass : ScriptableRenderPass
	{
		[Token(Token = "0x200012F")]
		private class PassData
		{
			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal CommandBuffer cmd;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Camera camera;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal TextureHandle offscreenTexture;

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x2D3321C", Offset = "0x2D2F21C", VA = "0x2D3321C")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private PassData m_PassData;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RTHandle m_ColorTarget;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RTHandle m_DepthTarget;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool m_RenderOffscreen;

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2D33128", Offset = "0x2D2F128", VA = "0x2D33128")]
		public DrawScreenSpaceUIPass(RenderPassEvent evt, bool renderOffscreen)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x2D33224", Offset = "0x2D2F224", VA = "0x2D33224")]
		public static void ConfigureColorDescriptor(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x2D33264", Offset = "0x2D2F264", VA = "0x2D33264")]
		public static void ConfigureDepthDescriptor(ref RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2D332B0", Offset = "0x2D2F2B0", VA = "0x2D332B0")]
		private static void ExecutePass(ScriptableRenderContext context, PassData passData)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x2D33340", Offset = "0x2D2F340", VA = "0x2D33340")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x2D33374", Offset = "0x2D2F374", VA = "0x2D33374")]
		public void Setup(ref CameraData cameraData, int depthBufferBits)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2D334F4", Offset = "0x2D2F4F4", VA = "0x2D334F4", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2D33844", Offset = "0x2D2F844", VA = "0x2D33844")]
		internal void RenderOffscreen(RenderGraph renderGraph, int depthBufferBits, out TextureHandle output, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2D33C14", Offset = "0x2D2FC14", VA = "0x2D33C14")]
		internal void RenderOverlay(RenderGraph renderGraph, in TextureHandle colorBuffer, in TextureHandle depthBuffer, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class DrawSkyboxPass : ScriptableRenderPass
	{
		[Token(Token = "0x2000132")]
		private class PassData
		{
			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle color;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle depth;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal RenderingData renderingData;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			internal DrawSkyboxPass pass;

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x2D34704", Offset = "0x2D30704", VA = "0x2D34704")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool m_IsActiveTargetBackBuffer;

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2D33FA4", Offset = "0x2D2FFA4", VA = "0x2D33FA4")]
		public DrawSkyboxPass(RenderPassEvent evt)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x2D34054", Offset = "0x2D30054", VA = "0x2D34054", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2D341F4", Offset = "0x2D301F4", VA = "0x2D341F4")]
		private RendererList CreateSkyboxRendererList(ScriptableRenderContext context, CameraData cameraData)
		{
			return default(RendererList);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x2D344A0", Offset = "0x2D304A0", VA = "0x2D344A0")]
		internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x2000134")]
	internal class HDRDebugViewPass : ScriptableRenderPass
	{
		[Token(Token = "0x2000135")]
		private enum HDRDebugPassId
		{
			[Token(Token = "0x400062B")]
			CIExyPrepass,
			[Token(Token = "0x400062C")]
			DebugViewPass
		}

		[Token(Token = "0x2000136")]
		private class PassData
		{
			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Material material;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal HDRDebugMode hdrDebugMode;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Vector4 luminanceParameters;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal CameraData cameraData;

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x2D34894", Offset = "0x2D30894", VA = "0x2D34894")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x2000137")]
		internal class ShaderConstants
		{
			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int _DebugHDRModeId;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int _HDRDebugParamsId;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int _xyTextureId;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int _SizeOfHDRXYMapping;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int _CIExyUAVIndex;

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x2D3554C", Offset = "0x2D3154C", VA = "0x2D3554C")]
			public ShaderConstants()
			{
			}
		}

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private PassData m_PassData;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RTHandle m_CIExyTarget;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RTHandle m_PassthroughRT;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RTHandle m_CameraTargetHandle;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x2D347A4", Offset = "0x2D307A4", VA = "0x2D347A4")]
		public HDRDebugViewPass(Material mat)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x2D3489C", Offset = "0x2D3089C", VA = "0x2D3489C")]
		public static void ConfigureDescriptor(ref RenderTextureDescriptor descriptor)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x2D348E4", Offset = "0x2D308E4", VA = "0x2D348E4")]
		public static void ConfigureDescriptorForCIEPrepass(ref RenderTextureDescriptor descriptor)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x2D34978", Offset = "0x2D30978", VA = "0x2D34978")]
		internal static Vector4 GetLuminanceParameters(ref CameraData cameraData)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x2D34ADC", Offset = "0x2D30ADC", VA = "0x2D34ADC")]
		private static void ExecuteCIExyPrepass(CommandBuffer cmd, PassData data, RTHandle sourceTexture, RTHandle xyTarget, RTHandle destTexture)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x2D34E68", Offset = "0x2D30E68", VA = "0x2D34E68")]
		private static void ExecuteHDRDebugViewFinalPass(CommandBuffer cmd, PassData data, RTHandle sourceTexture, RTHandle destination, RTHandle xyTarget)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x2D35134", Offset = "0x2D31134", VA = "0x2D35134")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x2D35178", Offset = "0x2D31178", VA = "0x2D35178")]
		public void Setup(ref CameraData cameraData, HDRDebugMode hdrdebugMode)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x2D352D4", Offset = "0x2D312D4", VA = "0x2D352D4", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x2D354D8", Offset = "0x2D314D8", VA = "0x2D354D8")]
		private void ExecutePass(CommandBuffer cmd, PassData data, RTHandle sourceTexture, RTHandle xyTarget)
		{
		}
	}
	[Token(Token = "0x2000138")]
	internal class InvokeOnRenderObjectCallbackPass : ScriptableRenderPass
	{
		[Token(Token = "0x2000139")]
		private class PassData
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle colorTarget;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle depthTarget;

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x2D35970", Offset = "0x2D31970", VA = "0x2D35970")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x2D35630", Offset = "0x2D31630", VA = "0x2D35630")]
		public InvokeOnRenderObjectCallbackPass(RenderPassEvent evt)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x2D356E4", Offset = "0x2D316E4", VA = "0x2D356E4", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x2D35740", Offset = "0x2D31740", VA = "0x2D35740")]
		internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x200013B")]
	internal sealed class MotionVectorRenderPass : ScriptableRenderPass
	{
		[Token(Token = "0x200013C")]
		private class PassData
		{
			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle motionVectorColor;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle motionVectorDepth;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal TextureHandle cameraDepth;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal RenderingData renderingData;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			internal Material cameraMaterial;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
			internal Material objectMaterial;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
			internal FilteringSettings filteringSettings;

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x2D35BC4", Offset = "0x2D31BC4", VA = "0x2D35BC4")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x400063A")]
		private const string kPreviousViewProjectionNoJitter = "_PrevViewProjMatrix";

		[Token(Token = "0x400063B")]
		private const string kViewProjectionNoJitter = "_NonJitteredViewProjMatrix";

		[Token(Token = "0x400063C")]
		private const string kPreviousViewProjectionNoJitterStereo = "_PrevViewProjMatrixStereo";

		[Token(Token = "0x400063D")]
		private const string kViewProjectionNoJitterStereo = "_NonJitteredViewProjMatrixStereo";

		[Token(Token = "0x400063E")]
		internal const GraphicsFormat k_TargetFormat = GraphicsFormat.R16G16_SFloat;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] s_ShaderTags;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RTHandle m_Color;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RTHandle m_Depth;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly Material m_CameraMaterial;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly Material m_ObjectMaterial;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly FilteringSettings m_FilteringSettings;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private PassData m_PassData;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x2D35A3C", Offset = "0x2D31A3C", VA = "0x2D35A3C")]
		internal MotionVectorRenderPass(RenderPassEvent evt, Material cameraMaterial, Material objectMaterial, LayerMask opaqueLayerMask)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x2D35BCC", Offset = "0x2D31BCC", VA = "0x2D35BCC")]
		internal void Setup(RTHandle color, RTHandle depth)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x2D35BD4", Offset = "0x2D31BD4", VA = "0x2D35BD4", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2D35CA0", Offset = "0x2D31CA0", VA = "0x2D35CA0")]
		private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x2D36430", Offset = "0x2D32430", VA = "0x2D36430", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x2D364C4", Offset = "0x2D324C4", VA = "0x2D364C4")]
		private static DrawingSettings GetDrawingSettings(ref RenderingData renderingData, Material objectMaterial)
		{
			return default(DrawingSettings);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x2D36098", Offset = "0x2D32098", VA = "0x2D36098")]
		private static void DrawCameraMotionVectors(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, Camera camera, Material cameraMaterial)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x2D36254", Offset = "0x2D32254", VA = "0x2D36254")]
		private static void DrawObjectMotionVectors(ScriptableRenderContext context, ref RenderingData renderingData, Camera camera, Material objectMaterial, CommandBuffer cmd, ref FilteringSettings filteringSettings)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x2D36738", Offset = "0x2D32738", VA = "0x2D36738")]
		internal void Render(RenderGraph renderGraph, ref TextureHandle cameraDepthTexture, in TextureHandle motionVectorColor, in TextureHandle motionVectorDepth, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x200013E")]
	public interface IPostProcessComponent
	{
		[Token(Token = "0x600071C")]
		bool IsActive();

		[Token(Token = "0x600071D")]
		bool IsTileCompatible();
	}
	[Token(Token = "0x200013F")]
	internal class PostProcessPass : ScriptableRenderPass
	{
		[Token(Token = "0x2000140")]
		private class MaterialLibrary
		{
			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly Material stopNaN;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly Material subpixelMorphologicalAntialiasing;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public readonly Material gaussianDepthOfField;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public readonly Material bokehDepthOfField;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public readonly Material cameraMotionBlur;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public readonly Material paniniProjection;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public readonly Material bloom;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public readonly Material temporalAntialiasing;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public readonly Material scalingSetup;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public readonly Material easu;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public readonly Material uber;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public readonly Material finalPass;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public readonly Material lensFlareDataDriven;

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x2D3D950", Offset = "0x2D39950", VA = "0x2D3D950")]
			public MaterialLibrary(PostProcessData data)
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x2D3DA80", Offset = "0x2D39A80", VA = "0x2D3DA80")]
			private Material Load(Shader shader)
			{
				return null;
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x2D3DBF4", Offset = "0x2D39BF4", VA = "0x2D3DBF4")]
			internal void Cleanup()
			{
			}
		}

		[Token(Token = "0x2000141")]
		private static class ShaderConstants
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int _TempTarget;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int _TempTarget2;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int _StencilRef;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int _StencilMask;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int _FullCoCTexture;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly int _HalfCoCTexture;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly int _DofTexture;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly int _CoCParams;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly int _BokehKernel;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static readonly int _BokehConstants;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static readonly int _PongTexture;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public static readonly int _PingTexture;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static readonly int _Metrics;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public static readonly int _AreaTexture;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static readonly int _SearchTexture;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public static readonly int _EdgeTexture;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static readonly int _BlendTexture;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public static readonly int _ColorTexture;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static readonly int _Params;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public static readonly int _SourceTexLowMip;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static readonly int _Bloom_Params;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public static readonly int _Bloom_RGBM;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static readonly int _Bloom_Texture;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public static readonly int _LensDirt_Texture;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static readonly int _LensDirt_Params;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public static readonly int _LensDirt_Intensity;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static readonly int _Distortion_Params1;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public static readonly int _Distortion_Params2;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static readonly int _Chroma_Params;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public static readonly int _Vignette_Params1;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static readonly int _Vignette_Params2;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public static readonly int _Vignette_ParamsXR;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static readonly int _Lut_Params;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public static readonly int _UserLut_Params;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static readonly int _InternalLut;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public static readonly int _UserLut;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static readonly int _DownSampleScaleFactor;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public static readonly int _FlareOcclusionRemapTex;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static readonly int _FlareOcclusionTex;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public static readonly int _FlareOcclusionIndex;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static readonly int _FlareTex;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public static readonly int _FlareColorValue;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public static readonly int _FlareData0;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			public static readonly int _FlareData1;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static readonly int _FlareData2;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			public static readonly int _FlareData3;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public static readonly int _FlareData4;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			public static readonly int _FlareData5;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static readonly int _FullscreenProjMat;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public static int[] _BloomMipUp;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static int[] _BloomMipDown;
		}

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTextureDescriptor m_Descriptor;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private RTHandle m_Source;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RTHandle m_Destination;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private RTHandle m_Depth;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private RTHandle m_InternalLut;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private RTHandle m_MotionVectors;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private RTHandle m_FullCoCTexture;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private RTHandle m_HalfCoCTexture;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private RTHandle m_PingTexture;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private RTHandle m_PongTexture;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private RTHandle[] m_BloomMipDown;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private RTHandle[] m_BloomMipUp;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private RTHandle m_BlendTexture;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private RTHandle m_EdgeColorTexture;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private RTHandle m_EdgeStencilTexture;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private RTHandle m_TempTarget;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private RTHandle m_TempTarget2;

		[Token(Token = "0x4000660")]
		private const string k_RenderPostProcessingTag = "Render PostProcessing Effects";

		[Token(Token = "0x4000661")]
		private const string k_RenderFinalPostProcessingTag = "Render Final PostProcessing Pass";

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilingSampler m_ProfilingRenderPostProcessing;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ProfilingSampler m_ProfilingRenderFinalPostProcessing;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private MaterialLibrary m_Materials;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private PostProcessData m_Data;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private DepthOfField m_DepthOfField;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private MotionBlur m_MotionBlur;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private PaniniProjection m_PaniniProjection;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Bloom m_Bloom;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private LensDistortion m_LensDistortion;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private ChromaticAberration m_ChromaticAberration;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Vignette m_Vignette;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private ColorLookup m_ColorLookup;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private ColorAdjustments m_ColorAdjustments;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Tonemapping m_Tonemapping;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private FilmGrain m_FilmGrain;

		[Token(Token = "0x4000671")]
		private const int k_MaxPyramidSize = 16;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly GraphicsFormat m_DefaultHDRFormat;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private bool m_UseRGBM;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly GraphicsFormat m_SMAAEdgeFormat;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private readonly GraphicsFormat m_GaussianCoCFormat;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private int m_DitheringTextureIndex;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private RenderTargetIdentifier[] m_MRT2;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private Vector4[] m_BokehKernel;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private int m_BokehHash;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private float m_BokehMaxRadius;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private float m_BokehRCPAspect;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private bool m_IsFinalPass;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x235")]
		private bool m_HasFinalPass;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x236")]
		private bool m_EnableColorEncodingIfNeeded;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x237")]
		private bool m_UseFastSRGBLinearConversion;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private bool m_SupportDataDrivenLensFlare;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x239")]
		private bool m_ResolveToScreen;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23A")]
		private bool m_UseSwapBuffer;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private RTHandle m_ScalingSetupTarget;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private RTHandle m_UpscaledTarget;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private Material m_BlitMaterial;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly int k_ShaderPropertyId_ViewProjM;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal static readonly int k_ShaderPropertyId_PrevViewProjM;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static readonly int k_ShaderPropertyId_ViewProjMStereo;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal static readonly int k_ShaderPropertyId_PrevViewProjMStereo;

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x2D36BDC", Offset = "0x2D32BDC", VA = "0x2D36BDC")]
		public PostProcessPass(RenderPassEvent evt, PostProcessData data, ref PostProcessParams postProcessParams)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2D3716C", Offset = "0x2D3316C", VA = "0x2D3716C")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2D37184", Offset = "0x2D33184", VA = "0x2D37184")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2D372F8", Offset = "0x2D332F8", VA = "0x2D372F8")]
		public void Setup(in RenderTextureDescriptor baseDescriptor, in RTHandle source, bool resolveToScreen, in RTHandle depth, in RTHandle internalLut, in RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2D37414", Offset = "0x2D33414", VA = "0x2D37414")]
		public void SetupFinalPass(in RTHandle source, bool useSwapBuffer = false, bool enableColorEncoding = true)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2D374B0", Offset = "0x2D334B0", VA = "0x2D374B0", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2D374BC", Offset = "0x2D334BC", VA = "0x2D374BC")]
		public bool CanRunOnTile()
		{
			return default(bool);
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2D374C4", Offset = "0x2D334C4", VA = "0x2D374C4", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2D39694", Offset = "0x2D35694", VA = "0x2D39694")]
		private RenderTextureDescriptor GetCompatibleDescriptor()
		{
			return default(RenderTextureDescriptor);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x2D396E0", Offset = "0x2D356E0", VA = "0x2D396E0")]
		private RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, GraphicsFormat format, DepthBits depthBufferBits = DepthBits.None)
		{
			return default(RenderTextureDescriptor);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2D397D8", Offset = "0x2D357D8", VA = "0x2D397D8")]
		internal static RenderTextureDescriptor GetCompatibleDescriptor(RenderTextureDescriptor desc, int width, int height, GraphicsFormat format, DepthBits depthBufferBits = DepthBits.None)
		{
			return default(RenderTextureDescriptor);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x2D39848", Offset = "0x2D35848", VA = "0x2D39848")]
		private bool RequireSRGBConversionBlitToBackBuffer(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x2D39874", Offset = "0x2D35874", VA = "0x2D39874")]
		private bool RequireHDROutput(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x2D380F0", Offset = "0x2D340F0", VA = "0x2D380F0")]
		private void Render(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x2D39B3C", Offset = "0x2D35B3C", VA = "0x2D39B3C")]
		private void DoSubpixelMorphologicalAntialiasing(ref CameraData cameraData, CommandBuffer cmd, RTHandle source, RTHandle destination)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x2D3A100", Offset = "0x2D36100", VA = "0x2D3A100")]
		private void DoDepthOfField(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x2D3C338", Offset = "0x2D38338", VA = "0x2D3C338")]
		private void DoGaussianDepthOfField(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x2D3D08C", Offset = "0x2D3908C", VA = "0x2D3D08C")]
		private void PrepareBokehKernel(float maxRadius, float rcpAspect)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2D3D2F8", Offset = "0x2D392F8", VA = "0x2D3D2F8")]
		private static float GetMaxBokehRadiusInPixels(float viewportHeight)
		{
			return default(float);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x2D3CA78", Offset = "0x2D38A78", VA = "0x2D3CA78")]
		private void DoBokehDepthOfField(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x2D3D314", Offset = "0x2D39314", VA = "0x2D3D314")]
		private static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo)
		{
			return default(float);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x2D3B138", Offset = "0x2D37138", VA = "0x2D3B138")]
		private void LensFlareDataDrivenComputeOcclusion(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x2D3B3CC", Offset = "0x2D373CC", VA = "0x2D3B3CC")]
		private void LensFlareDataDriven(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x2D3D52C", Offset = "0x2D3952C", VA = "0x2D3D52C")]
		internal static void UpdateMotionBlurMatrices(ref Material material, Camera camera, XRPass xr)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x2D3A1C0", Offset = "0x2D361C0", VA = "0x2D3A1C0")]
		private void DoMotionBlur(CommandBuffer cmd, RTHandle source, RTHandle destination, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2D3A388", Offset = "0x2D36388", VA = "0x2D3A388")]
		private void DoPaniniProjection(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2D3D70C", Offset = "0x2D3970C", VA = "0x2D3D70C")]
		private Vector2 CalcViewExtents(Camera camera)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x2D3D768", Offset = "0x2D39768", VA = "0x2D3D768")]
		private Vector2 CalcCropExtents(Camera camera, float d)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x2D3A5C8", Offset = "0x2D365C8", VA = "0x2D3A5C8")]
		private void SetupBloom(CommandBuffer cmd, RTHandle source, Material uberMaterial)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x2D3B760", Offset = "0x2D37760", VA = "0x2D3B760")]
		private void SetupLensDistortion(Material material, bool isSceneView)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x2D3BA58", Offset = "0x2D37A58", VA = "0x2D3BA58")]
		private void SetupChromaticAberration(Material material)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x2D3BB60", Offset = "0x2D37B60", VA = "0x2D3BB60")]
		private void SetupVignette(Material material, XRPass xrPass)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x2D3BDAC", Offset = "0x2D37DAC", VA = "0x2D3BDAC")]
		private void SetupColorGrading(CommandBuffer cmd, ref RenderingData renderingData, Material material)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x2D3C0F0", Offset = "0x2D380F0", VA = "0x2D3C0F0")]
		private void SetupGrain(ref CameraData cameraData, Material material)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x2D3C198", Offset = "0x2D38198", VA = "0x2D3C198")]
		private void SetupDithering(ref CameraData cameraData, Material material)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x2D3C230", Offset = "0x2D38230", VA = "0x2D3C230")]
		private void SetupHDROutput(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperations)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x2D37844", Offset = "0x2D33844", VA = "0x2D37844")]
		private void RenderFinalPass(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x2000144")]
	[Flags]
	public enum ScriptableRenderPassInput
	{
		[Token(Token = "0x40006D2")]
		None = 0,
		[Token(Token = "0x40006D3")]
		Depth = 1,
		[Token(Token = "0x40006D4")]
		Normal = 2,
		[Token(Token = "0x40006D5")]
		Color = 4,
		[Token(Token = "0x40006D6")]
		Motion = 8
	}
	[Token(Token = "0x2000145")]
	public enum RenderPassEvent
	{
		[Token(Token = "0x40006D8")]
		BeforeRendering = 0,
		[Token(Token = "0x40006D9")]
		BeforeRenderingShadows = 50,
		[Token(Token = "0x40006DA")]
		AfterRenderingShadows = 100,
		[Token(Token = "0x40006DB")]
		BeforeRenderingPrePasses = 150,
		[Token(Token = "0x40006DC")]
		AfterRenderingPrePasses = 200,
		[Token(Token = "0x40006DD")]
		BeforeRenderingGbuffer = 210,
		[Token(Token = "0x40006DE")]
		AfterRenderingGbuffer = 220,
		[Token(Token = "0x40006DF")]
		BeforeRenderingDeferredLights = 230,
		[Token(Token = "0x40006E0")]
		AfterRenderingDeferredLights = 240,
		[Token(Token = "0x40006E1")]
		BeforeRenderingOpaques = 250,
		[Token(Token = "0x40006E2")]
		AfterRenderingOpaques = 300,
		[Token(Token = "0x40006E3")]
		BeforeRenderingSkybox = 350,
		[Token(Token = "0x40006E4")]
		AfterRenderingSkybox = 400,
		[Token(Token = "0x40006E5")]
		BeforeRenderingTransparents = 450,
		[Token(Token = "0x40006E6")]
		AfterRenderingTransparents = 500,
		[Token(Token = "0x40006E7")]
		BeforeRenderingPostProcessing = 550,
		[Token(Token = "0x40006E8")]
		AfterRenderingPostProcessing = 600,
		[Token(Token = "0x40006E9")]
		AfterRendering = 1000
	}
	[Token(Token = "0x2000146")]
	internal static class RenderPassEventsEnumValues
	{
		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int[] values;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x2D3E75C", Offset = "0x2D3A75C", VA = "0x2D3E75C")]
		static RenderPassEventsEnumValues()
		{
		}
	}
	[Token(Token = "0x2000147")]
	internal class TransparentSettingsPass : ScriptableRenderPass
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool m_shouldReceiveShadows;

		[Token(Token = "0x40006EC")]
		private const string m_ProfilerTag = "Transparent Settings Pass";

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x2D3EAE0", Offset = "0x2D3AAE0", VA = "0x2D3EAE0")]
		public TransparentSettingsPass(RenderPassEvent evt, bool shadowReceiveSupported)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2D3EBA4", Offset = "0x2D3ABA4", VA = "0x2D3EBA4")]
		public bool Setup()
		{
			return default(bool);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x2D3EBB4", Offset = "0x2D3ABB4", VA = "0x2D3EBB4", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x2D3EC10", Offset = "0x2D3AC10", VA = "0x2D3EC10")]
		public static void ExecutePass(CommandBuffer cmd, bool shouldReceiveShadows)
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class XROcclusionMeshPass : ScriptableRenderPass
	{
		[Token(Token = "0x2000149")]
		private class PassData
		{
			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal RenderingData renderingData;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			internal TextureHandle cameraColorAttachment;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			internal TextureHandle cameraDepthAttachment;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			internal bool isActiveTargetBackBuffer;

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x2D3EF08", Offset = "0x2D3AF08", VA = "0x2D3EF08")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private PassData m_PassData;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool m_IsActiveTargetBackBuffer;

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x2D3EDF0", Offset = "0x2D3ADF0", VA = "0x2D3EDF0")]
		public XROcclusionMeshPass(RenderPassEvent evt)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x2D3EF10", Offset = "0x2D3AF10", VA = "0x2D3EF10")]
		private static void ExecutePass(ScriptableRenderContext context, PassData data)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x2D3EF9C", Offset = "0x2D3AF9C", VA = "0x2D3EF9C", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x2D3EFD8", Offset = "0x2D3AFD8", VA = "0x2D3EFD8")]
		internal void Render(RenderGraph renderGraph, in TextureHandle cameraColorAttachment, in TextureHandle cameraDepthAttachment, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x200014B")]
	internal struct PostProcessParams
	{
		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Material blitMaterial;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GraphicsFormat requestHDRFormat;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x2D3F2B8", Offset = "0x2D3B2B8", VA = "0x2D3F2B8")]
		public static PostProcessParams Create()
		{
			return default(PostProcessParams);
		}
	}
	[Token(Token = "0x200014C")]
	internal struct PostProcessPasses : IDisposable
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ColorGradingLutPass m_ColorGradingLutPass;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private PostProcessPass m_PostProcessPass;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PostProcessPass m_FinalPostProcessPass;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal RTHandle m_AfterPostProcessColor;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal RTHandle m_ColorGradingLut;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PostProcessData m_RendererPostProcessData;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PostProcessData m_CurrentPostProcessData;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material m_BlitMaterial;

		[Token(Token = "0x17000196")]
		public ColorGradingLutPass colorGradingLutPass
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x2D3F2C4", Offset = "0x2D3B2C4", VA = "0x2D3F2C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000197")]
		public PostProcessPass postProcessPass
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x2D3F2CC", Offset = "0x2D3B2CC", VA = "0x2D3F2CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000198")]
		public PostProcessPass finalPostProcessPass
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x2D3F2D4", Offset = "0x2D3B2D4", VA = "0x2D3F2D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000199")]
		public RTHandle afterPostProcessColor
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x2D3F2DC", Offset = "0x2D3B2DC", VA = "0x2D3F2DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019A")]
		public RTHandle colorGradingLut
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x2D3F2E4", Offset = "0x2D3B2E4", VA = "0x2D3F2E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019B")]
		public bool isCreated
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x2D3F2EC", Offset = "0x2D3B2EC", VA = "0x2D3F2EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x2D3F34C", Offset = "0x2D3B34C", VA = "0x2D3F34C")]
		public PostProcessPasses(PostProcessData rendererPostProcessData, ref PostProcessParams postProcessParams)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2D3F364", Offset = "0x2D3B364", VA = "0x2D3F364")]
		public void Recreate(PostProcessData data, ref PostProcessParams ppParams)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x2D3F520", Offset = "0x2D3B520", VA = "0x2D3F520", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x2D3F584", Offset = "0x2D3B584", VA = "0x2D3F584")]
		internal void ReleaseRenderTargets()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public static class PostProcessUtils
	{
		[Token(Token = "0x200014E")]
		private static class ShaderConstants
		{
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int _Grain_Texture;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int _Grain_Params;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int _Grain_TilingParams;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int _BlueNoise_Texture;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int _Dithering_Params;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly int _SourceSize;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2D3F5D8", Offset = "0x2D3B5D8", VA = "0x2D3F5D8")]
		[Obsolete("This method is obsolete. Use ConfigureDithering override that takes camera pixel width and height instead.")]
		public static int ConfigureDithering(PostProcessData data, int index, Camera camera, Material material)
		{
			return default(int);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2D3F63C", Offset = "0x2D3B63C", VA = "0x2D3F63C")]
		public static int ConfigureDithering(PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, Material material)
		{
			return default(int);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2D3F7D0", Offset = "0x2D3B7D0", VA = "0x2D3F7D0")]
		[Obsolete("This method is obsolete. Use ConfigureFilmGrain override that takes camera pixel width and height instead.")]
		public static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, Camera camera, Material material)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2D3F834", Offset = "0x2D3B834", VA = "0x2D3F834")]
		public static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, Material material)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2D3FAFC", Offset = "0x2D3BAFC", VA = "0x2D3FAFC")]
		internal static void SetSourceSize(CommandBuffer cmd, RenderTextureDescriptor desc)
		{
		}
	}
	[Token(Token = "0x200014F")]
	internal struct ReflectionProbeManager : IDisposable
	{
		[Token(Token = "0x2000150")]
		private struct CachedProbe
		{
			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint updateCount;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Hash128 imageContentsHash;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int size;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int mipCount;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public unsafe fixed int dataIndices[7];

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public unsafe fixed int levels[7];

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Texture texture;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public int lastUsed;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Vector4 hdrData;
		}

		[Token(Token = "0x2000153")]
		private static class ShaderProperties
		{
			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int BoxMin;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int BoxMax;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int ProbePosition;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int MipScaleOffset;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int Count;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly int Atlas;
		}

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int2 m_Resolution;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private RenderTexture m_AtlasTexture0;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RenderTexture m_AtlasTexture1;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BuddyAllocator m_AtlasAllocator;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<int, CachedProbe> m_Cache;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<int, int> m_WarningCache;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<int> m_NeedsUpdate;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> m_NeedsRemove;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector4[] m_BoxMax;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector4[] m_BoxMin;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector4[] m_ProbePosition;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector4[] m_MipScaleOffset;

		[Token(Token = "0x4000712")]
		private const int k_MaxMipCount = 7;

		[Token(Token = "0x4000713")]
		private const string k_ReflectionProbeAtlasName = "URP Reflection Probe Atlas";

		[Token(Token = "0x1700019C")]
		public RenderTexture atlasRT
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x2D3FD2C", Offset = "0x2D3BD2C", VA = "0x2D3FD2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x2D3FD34", Offset = "0x2D3BD34", VA = "0x2D3FD34")]
		public static ReflectionProbeManager Create()
		{
			return default(ReflectionProbeManager);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x2D3FD78", Offset = "0x2D3BD78", VA = "0x2D3FD78")]
		private void Init()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x2D4017C", Offset = "0x2D3C17C", VA = "0x2D4017C")]
		public void UpdateGpuData(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2D41ACC", Offset = "0x2D3DACC", VA = "0x2D41ACC")]
		private float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip)
		{
			return default(float4);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x2D41BE8", Offset = "0x2D3DBE8", VA = "0x2D41BE8", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000154")]
	internal enum DecalSurfaceData
	{
		[Token(Token = "0x4000726")]
		[Tooltip("Decals will affect only base color and emission.")]
		Albedo,
		[Token(Token = "0x4000727")]
		[Tooltip("Decals will affect only base color, normal and emission.")]
		AlbedoNormal,
		[Token(Token = "0x4000728")]
		[Tooltip("Decals will affect base color, normal, metallic, ambient occlusion, smoothness and emission.")]
		AlbedoNormalMAOS
	}
	[Token(Token = "0x2000155")]
	internal enum DecalTechnique
	{
		[Token(Token = "0x400072A")]
		Invalid,
		[Token(Token = "0x400072B")]
		DBuffer,
		[Token(Token = "0x400072C")]
		ScreenSpace,
		[Token(Token = "0x400072D")]
		GBuffer
	}
	[Token(Token = "0x2000156")]
	internal enum DecalTechniqueOption
	{
		[Token(Token = "0x400072F")]
		[Tooltip("Automatically selects technique based on build platform.")]
		Automatic,
		[Token(Token = "0x4000730")]
		[InspectorName("DBuffer")]
		[Tooltip("Renders decals into DBuffer and then applied during opaque rendering. Requires DepthNormal prepass which makes not viable solution for the tile based renderers common on mobile.")]
		DBuffer,
		[Token(Token = "0x4000731")]
		[Tooltip("Renders decals after opaque objects with normal reconstructed from depth. The decals are simply rendered as mesh on top of opaque ones, as result does not support blending per single surface data (etc. normal blending only).")]
		ScreenSpace
	}
	[Serializable]
	[Token(Token = "0x2000157")]
	internal class DBufferSettings
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DecalSurfaceData surfaceData;

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x2D41E10", Offset = "0x2D3DE10", VA = "0x2D41E10")]
		public DBufferSettings()
		{
		}
	}
	[Token(Token = "0x2000158")]
	internal enum DecalNormalBlend
	{
		[Token(Token = "0x4000734")]
		[Tooltip("Low quality of normal reconstruction (Uses 1 sample).")]
		Low,
		[Token(Token = "0x4000735")]
		[Tooltip("Medium quality of normal reconstruction (Uses 5 samples).")]
		Medium,
		[Token(Token = "0x4000736")]
		[Tooltip("High quality of normal reconstruction (Uses 9 samples).")]
		High
	}
	[Serializable]
	[Token(Token = "0x2000159")]
	internal class DecalScreenSpaceSettings
	{
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DecalNormalBlend normalBlend;

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x2D41E20", Offset = "0x2D3DE20", VA = "0x2D41E20")]
		public DecalScreenSpaceSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015A")]
	internal class DecalSettings
	{
		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DecalTechniqueOption technique;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxDrawDistance;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool decalLayers;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DBufferSettings dBufferSettings;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DecalScreenSpaceSettings screenSpaceSettings;

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2D41E28", Offset = "0x2D3DE28", VA = "0x2D41E28")]
		public DecalSettings()
		{
		}
	}
	[Token(Token = "0x200015B")]
	internal class SharedDecalEntityManager : IDisposable
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DecalEntityManager m_DecalEntityManager;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_ReferenceCounter;

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2D41E38", Offset = "0x2D3DE38", VA = "0x2D41E38")]
		public DecalEntityManager Get()
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2D420C8", Offset = "0x2D3E0C8", VA = "0x2D420C8")]
		public void Release(DecalEntityManager decalEntityManager)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x2D420E4", Offset = "0x2D3E0E4", VA = "0x2D420E4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2D42294", Offset = "0x2D3E294", VA = "0x2D42294")]
		private void OnDecalAdd(DecalProjector decalProjector)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x2D422E8", Offset = "0x2D3E2E8", VA = "0x2D422E8")]
		private void OnDecalRemove(DecalProjector decalProjector)
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2D4230C", Offset = "0x2D3E30C", VA = "0x2D4230C")]
		private void OnDecalPropertyChange(DecalProjector decalProjector)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x2D42368", Offset = "0x2D3E368", VA = "0x2D42368")]
		private void OnAllDecalPropertyChange()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2D42380", Offset = "0x2D3E380", VA = "0x2D42380")]
		private void OnDecalMaterialChange(DecalProjector decalProjector)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x2D423A8", Offset = "0x2D3E3A8", VA = "0x2D423A8")]
		public SharedDecalEntityManager()
		{
		}
	}
	[Token(Token = "0x200015C")]
	[DisallowMultipleRendererFeature("Decal")]
	[Tooltip("With this Renderer Feature, Unity can project specific Materials (decals) onto other objects in the Scene.")]
	internal class DecalRendererFeature : ScriptableRendererFeature
	{
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DecalSettings m_Settings;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Reload("Shaders/Utils/CopyDepth.shader", ReloadAttribute.Package.Root)]
		[HideInInspector]
		[SerializeField]
		private Shader m_CopyDepthPS;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Reload("Runtime/Decal/DBuffer/DBufferClear.shader", ReloadAttribute.Package.Root)]
		[HideInInspector]
		[SerializeField]
		private Shader m_DBufferClear;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DecalTechnique m_Technique;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DBufferSettings m_DBufferSettings;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DecalScreenSpaceSettings m_ScreenSpaceSettings;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_RecreateSystems;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CopyDepthPass m_CopyDepthPass;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DecalPreviewPass m_DecalPreviewPass;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CopyDepthMaterial;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DecalEntityManager m_DecalEntityManager;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DecalUpdateCachedSystem m_DecalUpdateCachedSystem;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DecalUpdateCulledSystem m_DecalUpdateCulledSystem;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private DecalDrawErrorSystem m_DrawErrorSystem;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DBufferRenderPass m_DBufferRenderPass;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DecalForwardEmissivePass m_ForwardEmissivePass;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private DecalDrawDBufferSystem m_DecalDrawDBufferSystem;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material m_DBufferClearMaterial;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private DecalSkipCulledSystem m_DecalSkipCulledSystem;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private DecalGBufferRenderPass m_GBufferRenderPass;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DecalDrawGBufferSystem m_DrawGBufferSystem;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private DeferredLights m_DeferredLights;

		[Token(Token = "0x1700019D")]
		private static SharedDecalEntityManager sharedDecalEntityManager
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x2D423B0", Offset = "0x2D3E3B0", VA = "0x2D423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019E")]
		internal unsafe ref DecalSettings settings
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x2D42408", Offset = "0x2D3E408", VA = "0x2D42408")]
			get
			{
				return ref *(DecalSettings*)null;
			}
		}

		[Token(Token = "0x1700019F")]
		internal bool intermediateRendering
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x2D42410", Offset = "0x2D3E410", VA = "0x2D42410")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A0")]
		internal bool requiresDecalLayers
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x2D42420", Offset = "0x2D3E420", VA = "0x2D42420")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A1")]
		internal static bool isGLDevice
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x2D42438", Offset = "0x2D3E438", VA = "0x2D42438")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2D4247C", Offset = "0x2D3E47C", VA = "0x2D4247C", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x2D424DC", Offset = "0x2D3E4DC", VA = "0x2D424DC", Slot = "10")]
		internal override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x2D42780", Offset = "0x2D3E780", VA = "0x2D42780")]
		internal DBufferSettings GetDBufferSettings()
		{
			return null;
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x2D42800", Offset = "0x2D3E800", VA = "0x2D42800")]
		internal DecalScreenSpaceSettings GetScreenSpaceSettings()
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x2D4287C", Offset = "0x2D3E87C", VA = "0x2D4287C")]
		internal DecalTechnique GetTechnique(ScriptableRendererData renderer)
		{
			return default(DecalTechnique);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x2D429A4", Offset = "0x2D3E9A4", VA = "0x2D429A4")]
		internal DecalTechnique GetTechnique(ScriptableRenderer renderer)
		{
			return default(DecalTechnique);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x2D42588", Offset = "0x2D3E588", VA = "0x2D42588")]
		internal DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques = true)
		{
			return default(DecalTechnique);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2D42A84", Offset = "0x2D3EA84", VA = "0x2D42A84")]
		private bool IsAutomaticDBuffer()
		{
			return default(bool);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2D42AFC", Offset = "0x2D3EAFC", VA = "0x2D42AFC")]
		private bool RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x2D4305C", Offset = "0x2D3F05C", VA = "0x2D4305C", Slot = "6")]
		public override void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x2D43148", Offset = "0x2D3F148", VA = "0x2D43148", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x2D43290", Offset = "0x2D3F290", VA = "0x2D43290", Slot = "9")]
		internal override bool SupportsNativeRenderPass()
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x2D432A4", Offset = "0x2D3F2A4", VA = "0x2D432A4", Slot = "8")]
		public override void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x2D43464", Offset = "0x2D3F464", VA = "0x2D43464", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x2D43574", Offset = "0x2D3F574", VA = "0x2D43574")]
		[Conditional("ADAPTIVE_PERFORMANCE_4_0_0_OR_NEWER")]
		private void ChangeAdaptivePerformanceDrawDistances()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2D43578", Offset = "0x2D3F578", VA = "0x2D43578")]
		public DecalRendererFeature()
		{
		}
	}
	[Token(Token = "0x200015D")]
	[AttributeUsage(AttributeTargets.Class)]
	public class DisallowMultipleRendererFeature : Attribute
	{
		[Token(Token = "0x170001A2")]
		public string customTitle
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x2D43670", Offset = "0x2D3F670", VA = "0x2D43670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x2D43668", Offset = "0x2D3F668", VA = "0x2D43668")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x2D43678", Offset = "0x2D3F678", VA = "0x2D43678")]
		public DisallowMultipleRendererFeature([Optional] string customTitle)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015E")]
	internal class ScreenSpaceAmbientOcclusionSettings
	{
		[Token(Token = "0x200015F")]
		internal enum DepthSource
		{
			[Token(Token = "0x4000769")]
			Depth,
			[Token(Token = "0x400076A")]
			DepthNormals
		}

		[Token(Token = "0x2000160")]
		internal enum NormalQuality
		{
			[Token(Token = "0x400076C")]
			Low,
			[Token(Token = "0x400076D")]
			Medium,
			[Token(Token = "0x400076E")]
			High
		}

		[Token(Token = "0x2000161")]
		internal enum AOSampleOption
		{
			[Token(Token = "0x4000770")]
			High,
			[Token(Token = "0x4000771")]
			Medium,
			[Token(Token = "0x4000772")]
			Low
		}

		[Token(Token = "0x2000162")]
		internal enum AOMethodOptions
		{
			[Token(Token = "0x4000774")]
			BlueNoise,
			[Token(Token = "0x4000775")]
			InterleavedGradient
		}

		[Token(Token = "0x2000163")]
		internal enum BlurQualityOptions
		{
			[Token(Token = "0x4000777")]
			High,
			[Token(Token = "0x4000778")]
			Medium,
			[Token(Token = "0x4000779")]
			Low
		}

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal AOMethodOptions AOMethod;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		internal bool Downsample;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		[SerializeField]
		internal bool AfterOpaque;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal DepthSource Source;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		internal NormalQuality NormalSamples;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal float Intensity;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		internal float DirectLightingStrength;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal float Radius;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		internal AOSampleOption Samples;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal BlurQualityOptions BlurQuality;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		internal float Falloff;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal int SampleCount;

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x2D436A0", Offset = "0x2D3F6A0", VA = "0x2D436A0")]
		public ScreenSpaceAmbientOcclusionSettings()
		{
		}
	}
	[Token(Token = "0x2000164")]
	[DisallowMultipleRendererFeature("Screen Space Ambient Occlusion")]
	[Tooltip("The Ambient Occlusion effect darkens creases, holes, intersections and surfaces that are close to each other.")]
	internal class ScreenSpaceAmbientOcclusion : ScriptableRendererFeature
	{
		[Token(Token = "0x2000165")]
		internal class ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass
		{
			[Token(Token = "0x2000166")]
			private enum BlurTypes
			{
				[Token(Token = "0x40007B4")]
				Bilateral,
				[Token(Token = "0x40007B5")]
				Gaussian,
				[Token(Token = "0x40007B6")]
				Kawase
			}

			[Token(Token = "0x2000167")]
			private enum ShaderPasses
			{
				[Token(Token = "0x40007B8")]
				AmbientOcclusion,
				[Token(Token = "0x40007B9")]
				BilateralBlurHorizontal,
				[Token(Token = "0x40007BA")]
				BilateralBlurVertical,
				[Token(Token = "0x40007BB")]
				BilateralBlurFinal,
				[Token(Token = "0x40007BC")]
				BilateralAfterOpaque,
				[Token(Token = "0x40007BD")]
				GaussianBlurHorizontal,
				[Token(Token = "0x40007BE")]
				GaussianBlurVertical,
				[Token(Token = "0x40007BF")]
				GaussianAfterOpaque,
				[Token(Token = "0x40007C0")]
				KawaseBlur,
				[Token(Token = "0x40007C1")]
				KawaseAfterOpaque
			}

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			internal string profilerTag;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool m_SupportsR8RenderTextureFormat;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private int m_BlueNoiseTextureIndex;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private float m_BlurRandomOffsetX;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			private float m_BlurRandomOffsetY;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Material m_Material;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private Texture2D[] m_BlueNoiseTextures;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector4[] m_CameraTopLeftCorner;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private Vector4[] m_CameraXExtent;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Vector4[] m_CameraYExtent;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector4[] m_CameraZExtent;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private RTHandle[] m_SSAOTextures;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private BlurTypes m_BlurType;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Matrix4x4[] m_CameraViewProjections;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private ProfilingSampler m_ProfilingSampler;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private ScriptableRenderer m_Renderer;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private RenderTextureDescriptor m_AOPassDescriptor;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private ScreenSpaceAmbientOcclusionSettings m_CurrentSettings;

			[Token(Token = "0x400079B")]
			private const int k_FinalTexID = 3;

			[Token(Token = "0x400079C")]
			private const string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture";

			[Token(Token = "0x400079D")]
			private const string k_AmbientOcclusionParamName = "_AmbientOcclusionParam";

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int s_AmbientOcclusionParamID;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private static readonly int s_SSAOParamsID;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static readonly int s_SSAOBlueNoiseParamsID;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private static readonly int s_LastKawasePass;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static readonly int s_BlueNoiseTextureID;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private static readonly int s_CameraViewXExtentID;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static readonly int s_CameraViewYExtentID;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private static readonly int s_CameraViewZExtentID;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static readonly int s_ProjectionParams2ID;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private static readonly int s_KawaseBlurIterationID;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static readonly int s_CameraViewProjectionsID;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private static readonly int s_CameraViewTopLeftCornerID;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static readonly int[] m_BilateralTexturesIndices;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static readonly ShaderPasses[] m_BilateralPasses;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static readonly ShaderPasses[] m_BilateralAfterOpaquePasses;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static readonly int[] m_GaussianTexturesIndices;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static readonly ShaderPasses[] m_GaussianPasses;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static readonly ShaderPasses[] m_GaussianAfterOpaquePasses;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static readonly int[] m_KawaseTexturesIndices;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static readonly ShaderPasses[] m_KawasePasses;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static readonly ShaderPasses[] m_KawaseAfterOpaquePasses;

			[Token(Token = "0x170001A4")]
			private bool isRendererDeferred
			{
				[Token(Token = "0x60007A0")]
				[Address(RVA = "0x2D43F40", Offset = "0x2D3FF40", VA = "0x2D43F40")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x2D43788", Offset = "0x2D3F788", VA = "0x2D43788")]
			internal ScreenSpaceAmbientOcclusionPass()
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x2D43C00", Offset = "0x2D3FC00", VA = "0x2D43C00")]
			internal bool Setup(ref ScreenSpaceAmbientOcclusionSettings featureSettings, ref ScriptableRenderer renderer, ref Material material, ref Texture2D[] blueNoiseTextures)
			{
				return default(bool);
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x2D43FAC", Offset = "0x2D3FFAC", VA = "0x2D43FAC", Slot = "5")]
			public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x2D45010", Offset = "0x2D41010", VA = "0x2D45010", Slot = "9")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x2D4579C", Offset = "0x2D4179C", VA = "0x2D4579C")]
			private static void RenderAndSetBaseMap(ref CommandBuffer cmd, ref RenderingData renderingData, ref ScriptableRenderer renderer, ref Material mat, ref RTHandle baseMap, ref RTHandle target, ShaderPasses pass)
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x2D45640", Offset = "0x2D41640", VA = "0x2D45640")]
			private static void GetPassOrder(BlurTypes blurType, bool isAfterOpaque, out int[] textureIndices, out ShaderPasses[] shaderPasses)
			{
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x2D45A94", Offset = "0x2D41A94", VA = "0x2D45A94")]
			private static bool IsAfterOpaquePass(ref ShaderPasses pass)
			{
				return default(bool);
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x2D45AB0", Offset = "0x2D41AB0", VA = "0x2D45AB0", Slot = "7")]
			public override void OnCameraCleanup(CommandBuffer cmd)
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x2D43E04", Offset = "0x2D3FE04", VA = "0x2D43E04")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScreenSpaceAmbientOcclusionSettings m_Settings;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		[Reload("Textures/BlueNoise256/LDR_LLL1_{0}.png", 0, 7, ReloadAttribute.Package.Root)]
		internal Texture2D[] m_BlueNoise256Textures;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[Reload("Shaders/Utils/ScreenSpaceAmbientOcclusion.shader", ReloadAttribute.Package.Root)]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material m_Material;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ScreenSpaceAmbientOcclusionPass m_SSAOPass;

		[Token(Token = "0x400077F")]
		internal const string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT";

		[Token(Token = "0x4000780")]
		internal const string k_AOBlueNoiseKeyword = "_BLUE_NOISE";

		[Token(Token = "0x4000781")]
		internal const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";

		[Token(Token = "0x4000782")]
		internal const string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW";

		[Token(Token = "0x4000783")]
		internal const string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM";

		[Token(Token = "0x4000784")]
		internal const string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH";

		[Token(Token = "0x4000785")]
		internal const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";

		[Token(Token = "0x4000786")]
		internal const string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW";

		[Token(Token = "0x4000787")]
		internal const string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM";

		[Token(Token = "0x4000788")]
		internal const string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH";

		[Token(Token = "0x170001A3")]
		internal unsafe ref ScreenSpaceAmbientOcclusionSettings settings
		{
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x2D436D4", Offset = "0x2D3F6D4", VA = "0x2D436D4")]
			get
			{
				return ref *(ScreenSpaceAmbientOcclusionSettings*)null;
			}
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2D436DC", Offset = "0x2D3F6DC", VA = "0x2D436DC", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x2D4393C", Offset = "0x2D3F93C", VA = "0x2D4393C", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x2D43D98", Offset = "0x2D3FD98", VA = "0x2D43D98", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x2D43B18", Offset = "0x2D3FB18", VA = "0x2D43B18")]
		private bool GetMaterials()
		{
			return default(bool);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2D43EAC", Offset = "0x2D3FEAC", VA = "0x2D43EAC")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000168")]
	internal class ScreenSpaceShadowsSettings
	{
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2D46060", Offset = "0x2D42060", VA = "0x2D46060")]
		public ScreenSpaceShadowsSettings()
		{
		}
	}
	[Token(Token = "0x2000169")]
	[DisallowMultipleRendererFeature("Screen Space Shadows")]
	[Tooltip("Screen Space Shadows")]
	internal class ScreenSpaceShadows : ScriptableRendererFeature
	{
		[Token(Token = "0x200016A")]
		private class ScreenSpaceShadowsPass : ScriptableRenderPass
		{
			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static string m_ProfilerTag;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static ProfilingSampler m_ProfilingSampler;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private Material m_Material;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private ScreenSpaceShadowsSettings m_CurrentSettings;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private RTHandle m_RenderTarget;

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x2D46120", Offset = "0x2D42120", VA = "0x2D46120")]
			internal ScreenSpaceShadowsPass()
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x2D46664", Offset = "0x2D42664", VA = "0x2D46664")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x2D46574", Offset = "0x2D42574", VA = "0x2D46574")]
			internal bool Setup(ScreenSpaceShadowsSettings featureSettings, Material material)
			{
				return default(bool);
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x2D466E0", Offset = "0x2D426E0", VA = "0x2D466E0", Slot = "5")]
			public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
			{
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x2D46A30", Offset = "0x2D42A30", VA = "0x2D46A30", Slot = "9")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}
		}

		[Token(Token = "0x200016B")]
		private class ScreenSpaceShadowsPostPass : ScriptableRenderPass
		{
			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static string m_ProfilerTag;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static ProfilingSampler m_ProfilingSampler;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static readonly RTHandle k_CurrentActive;

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x2D46DCC", Offset = "0x2D42DCC", VA = "0x2D46DCC", Slot = "6")]
			public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x2D46E30", Offset = "0x2D42E30", VA = "0x2D46E30", Slot = "9")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x2D461A8", Offset = "0x2D421A8", VA = "0x2D461A8")]
			public ScreenSpaceShadowsPostPass()
			{
			}
		}

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScreenSpaceShadowsSettings m_Settings;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material m_Material;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ScreenSpaceShadowsPass m_SSShadowsPass;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ScreenSpaceShadowsPostPass m_SSShadowsPostPass;

		[Token(Token = "0x40007C7")]
		private const string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows";

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2D46068", Offset = "0x2D42068", VA = "0x2D46068", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2D46354", Offset = "0x2D42354", VA = "0x2D46354", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2D465EC", Offset = "0x2D425EC", VA = "0x2D465EC", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2D46200", Offset = "0x2D42200", VA = "0x2D46200")]
		private bool LoadMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x2D46678", Offset = "0x2D42678", VA = "0x2D46678")]
		public ScreenSpaceShadows()
		{
		}
	}
	[Token(Token = "0x200016C")]
	internal static class RenderingLayerUtils
	{
		[Token(Token = "0x200016D")]
		public enum Event
		{
			[Token(Token = "0x40007D1")]
			DepthNormalPrePass,
			[Token(Token = "0x40007D2")]
			Opaque
		}

		[Token(Token = "0x200016E")]
		public enum MaskSize
		{
			[Token(Token = "0x40007D4")]
			Bits8,
			[Token(Token = "0x40007D5")]
			Bits16,
			[Token(Token = "0x40007D6")]
			Bits24,
			[Token(Token = "0x40007D7")]
			Bits32
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2D470E4", Offset = "0x2D430E4", VA = "0x2D470E4")]
		public static void CombineRendererEvents(bool isDeferred, int msaaSampleCount, Event rendererEvent, ref Event combinedEvent)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x2D47118", Offset = "0x2D43118", VA = "0x2D47118")]
		public static bool RequireRenderingLayers(UniversalRendererData universalRendererData, int msaaSampleCount, out Event combinedEvent, out MaskSize combinedMaskSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2D47420", Offset = "0x2D43420", VA = "0x2D47420")]
		public static bool RequireRenderingLayers(UniversalRenderer universalRenderer, List<ScriptableRendererFeature> rendererFeatures, int msaaSampleCount, out Event combinedEvent, out MaskSize combinedMaskSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2D47704", Offset = "0x2D43704", VA = "0x2D47704")]
		public static void SetupProperties(CommandBuffer cmd, MaskSize maskSize)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x2D47818", Offset = "0x2D43818", VA = "0x2D47818")]
		public static GraphicsFormat GetFormat(MaskSize maskSize)
		{
			return default(GraphicsFormat);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2D47868", Offset = "0x2D43868", VA = "0x2D47868")]
		public static uint ToValidRenderingLayers(uint renderingLayers)
		{
			return default(uint);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x2D473EC", Offset = "0x2D433EC", VA = "0x2D473EC")]
		private static MaskSize GetMaskSize(int bits)
		{
			return default(MaskSize);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2D477CC", Offset = "0x2D437CC", VA = "0x2D477CC")]
		private static int GetBits(MaskSize maskSize)
		{
			return default(int);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2D4710C", Offset = "0x2D4310C", VA = "0x2D4710C")]
		private static Event Combine(Event a, Event b)
		{
			return default(Event);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2D473E0", Offset = "0x2D433E0", VA = "0x2D473E0")]
		private static MaskSize Combine(MaskSize a, MaskSize b)
		{
			return default(MaskSize);
		}
	}
	[Token(Token = "0x200016F")]
	public static class RenderingUtils
	{
		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ShaderTagId> m_LegacyShaderPassNames;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AttachmentDescriptor s_EmptyAttachment;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static Mesh s_FullscreenMesh;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static Material s_ErrorMaterial;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static Dictionary<RenderTextureFormat, bool> m_RenderTextureFormatSupport;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>> m_GraphicsFormatSupport;

		[Token(Token = "0x170001A5")]
		internal static AttachmentDescriptor emptyAttachment
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x2D4792C", Offset = "0x2D4392C", VA = "0x2D4792C")]
			get
			{
				return default(AttachmentDescriptor);
			}
		}

		[Token(Token = "0x170001A6")]
		[Obsolete("Use Blitter.BlitCameraTexture instead of CommandBuffer.DrawMesh(fullscreenMesh, ...)")]
		public static Mesh fullscreenMesh
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x2D47990", Offset = "0x2D43990", VA = "0x2D47990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A7")]
		internal static bool useStructuredBuffer
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x2D47F44", Offset = "0x2D43F44", VA = "0x2D47F44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A8")]
		private static Material errorMaterial
		{
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x2D47F58", Offset = "0x2D43F58", VA = "0x2D47F58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x2D47F4C", Offset = "0x2D43F4C", VA = "0x2D47F4C")]
		internal static bool SupportsLightLayers(GraphicsDeviceType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x2D480E8", Offset = "0x2D440E8", VA = "0x2D480E8")]
		public static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x2D483C4", Offset = "0x2D443C4", VA = "0x2D483C4")]
		internal static void SetScaleBiasRt(CommandBuffer cmd, in RenderingData renderingData)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x2D48538", Offset = "0x2D44538", VA = "0x2D48538")]
		internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x2D486FC", Offset = "0x2D446FC", VA = "0x2D486FC")]
		internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destinationColor, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle destinationDepthStencil, RenderBufferLoadAction depthStencilLoadAction, RenderBufferStoreAction depthStencilStoreAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x2D4890C", Offset = "0x2D4490C", VA = "0x2D4890C")]
		internal static void FinalBlit(CommandBuffer cmd, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int passIndex)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x2D48DDC", Offset = "0x2D44DDC", VA = "0x2D48DDC")]
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal static void RenderObjectsWithError(ScriptableRenderContext context, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x2D490D8", Offset = "0x2D450D8", VA = "0x2D490D8")]
		internal static void ClearSystemInfoCache()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x2D4917C", Offset = "0x2D4517C", VA = "0x2D4917C")]
		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x2D46850", Offset = "0x2D42850", VA = "0x2D46850")]
		public static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x2D49274", Offset = "0x2D45274", VA = "0x2D49274")]
		internal static int GetLastValidColorBufferIndex(RenderTargetIdentifier[] colorBuffers)
		{
			return default(int);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x2D49330", Offset = "0x2D45330", VA = "0x2D49330")]
		[Obsolete("Use RTHandles for colorBuffers")]
		internal static uint GetValidColorBufferCount(RenderTargetIdentifier[] colorBuffers)
		{
			return default(uint);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x2D49400", Offset = "0x2D45400", VA = "0x2D49400")]
		internal static uint GetValidColorBufferCount(RTHandle[] colorBuffers)
		{
			return default(uint);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x2D494D8", Offset = "0x2D454D8", VA = "0x2D494D8")]
		[Obsolete("Use RTHandles for colorBuffers")]
		internal static bool IsMRT(RenderTargetIdentifier[] colorBuffers)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x2D49538", Offset = "0x2D45538", VA = "0x2D49538")]
		internal static bool IsMRT(RTHandle[] colorBuffers)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x2D49598", Offset = "0x2D45598", VA = "0x2D49598")]
		internal static bool Contains(RenderTargetIdentifier[] source, RenderTargetIdentifier value)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x2D49648", Offset = "0x2D45648", VA = "0x2D49648")]
		internal static int IndexOf(RenderTargetIdentifier[] source, RenderTargetIdentifier value)
		{
			return default(int);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x2D496F0", Offset = "0x2D456F0", VA = "0x2D496F0")]
		internal static uint CountDistinct(RenderTargetIdentifier[] source, RenderTargetIdentifier value)
		{
			return default(uint);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x2D49810", Offset = "0x2D45810", VA = "0x2D49810")]
		internal static int LastValid(RenderTargetIdentifier[] source)
		{
			return default(int);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x2D498D0", Offset = "0x2D458D0", VA = "0x2D498D0")]
		internal static bool Contains(ClearFlag a, ClearFlag b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x2D498DC", Offset = "0x2D458DC", VA = "0x2D498DC")]
		internal static bool SequenceEqual(RenderTargetIdentifier[] left, RenderTargetIdentifier[] right)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x2D499B8", Offset = "0x2D459B8", VA = "0x2D499B8")]
		internal static bool MultisampleDepthResolveSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x2D49A50", Offset = "0x2D45A50", VA = "0x2D49A50")]
		internal static bool RTHandleNeedsReAlloc(RTHandle handle, in TextureDesc descriptor, bool scaled)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x2D49ED4", Offset = "0x2D45ED4", VA = "0x2D49ED4")]
		internal static RenderTargetIdentifier GetCameraTargetIdentifier(ref RenderingData renderingData)
		{
			return default(RenderTargetIdentifier);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x2D44CDC", Offset = "0x2D40CDC", VA = "0x2D44CDC")]
		public static bool ReAllocateIfNeeded(ref RTHandle handle, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return default(bool);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x2D4A434", Offset = "0x2D46434", VA = "0x2D4A434")]
		public static bool ReAllocateIfNeeded(ref RTHandle handle, Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return default(bool);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x2D4A7EC", Offset = "0x2D467EC", VA = "0x2D4A7EC")]
		public static bool ReAllocateIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return default(bool);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x2D4ABC0", Offset = "0x2D46BC0", VA = "0x2D4ABC0")]
		public static bool SetMaxRTHandlePoolCapacity(int capacity)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x2D4A19C", Offset = "0x2D4619C", VA = "0x2D4A19C")]
		internal static void AddStaleResourceToPoolOrRelease(TextureDesc desc, RTHandle handle)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x2D4AEF8", Offset = "0x2D46EF8", VA = "0x2D4AEF8")]
		public static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x2D4B09C", Offset = "0x2D4709C", VA = "0x2D4B09C")]
		public static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}
	}
	[Token(Token = "0x2000170")]
	[Obsolete("Deprecated in favor of RTHandle")]
	public struct RenderTargetHandle
	{
		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly RenderTargetHandle CameraTarget;

		[Token(Token = "0x170001A9")]
		public int id
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x2D4B734", Offset = "0x2D47734", VA = "0x2D4B734")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x2D4B72C", Offset = "0x2D4772C", VA = "0x2D4B72C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		private RenderTargetIdentifier rtid
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x2D4B754", Offset = "0x2D47754", VA = "0x2D4B754")]
			[CompilerGenerated]
			readonly get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x2D4B73C", Offset = "0x2D4773C", VA = "0x2D4B73C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x2D4B76C", Offset = "0x2D4776C", VA = "0x2D4B76C")]
		public RenderTargetHandle(RenderTargetIdentifier renderTargetIdentifier)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x2D4B7E4", Offset = "0x2D477E4", VA = "0x2D4B7E4")]
		public RenderTargetHandle(RTHandle rtHandle)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x2D4B9D4", Offset = "0x2D479D4", VA = "0x2D4B9D4")]
		internal static RenderTargetHandle GetCameraTarget(ref CameraData cameraData)
		{
			return default(RenderTargetHandle);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x2D4BA94", Offset = "0x2D47A94", VA = "0x2D4BA94")]
		public void Init(string shaderProperty)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x2D4BB08", Offset = "0x2D47B08", VA = "0x2D4BB08")]
		public void Init(RenderTargetIdentifier renderTargetIdentifier)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x2D4BB80", Offset = "0x2D47B80", VA = "0x2D4BB80")]
		public RenderTargetIdentifier Identifier()
		{
			return default(RenderTargetIdentifier);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x2D4BC80", Offset = "0x2D47C80", VA = "0x2D4BC80")]
		public bool HasInternalRenderTargetId()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2D4BCDC", Offset = "0x2D47CDC", VA = "0x2D4BCDC")]
		public bool Equals(RenderTargetHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2D4BDE8", Offset = "0x2D47DE8", VA = "0x2D4BDE8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x2D4BEA8", Offset = "0x2D47EA8", VA = "0x2D4BEA8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x2D4BEFC", Offset = "0x2D47EFC", VA = "0x2D4BEFC")]
		public static bool operator ==(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x2D4BF80", Offset = "0x2D47F80", VA = "0x2D4BF80")]
		public static bool operator !=(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000171")]
	internal class RTHandleResourcePool
	{
		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected Dictionary<int, SortedList<int, (RTHandle resource, int frameIndex)>> m_ResourcePool;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected List<int> m_RemoveList;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static int s_CurrentStaleResourceCount;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		protected static int s_StaleResourceLifetime;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static int s_StaleResourceMaxCapacity;

		[Token(Token = "0x170001AB")]
		internal int staleResourceCapacity
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x2D4C064", Offset = "0x2D48064", VA = "0x2D4C064")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x2D4AC58", Offset = "0x2D46C58", VA = "0x2D4AC58")]
			set
			{
			}
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x2D4ACF4", Offset = "0x2D46CF4", VA = "0x2D4ACF4")]
		internal bool AddResourceToPool(in TextureDesc texDesc, RTHandle resource, int currentFrameIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x2D4A268", Offset = "0x2D46268", VA = "0x2D4A268")]
		internal bool TryGetResource(in TextureDesc texDesc, out RTHandle resource, bool usepool = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2D4C0BC", Offset = "0x2D480BC", VA = "0x2D4C0BC")]
		internal void Cleanup()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x2D4C520", Offset = "0x2D48520", VA = "0x2D4C520")]
		protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x2D4C594", Offset = "0x2D48594", VA = "0x2D4C594")]
		internal void PurgeUnusedResources(int currentFrameIndex)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x2D4CAC0", Offset = "0x2D48AC0", VA = "0x2D4CAC0")]
		internal void LogDebugInfo()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x2D4C4C8", Offset = "0x2D484C8", VA = "0x2D4C4C8")]
		internal int GetHashCodeWithNameHash(in TextureDesc texDesc)
		{
			return default(int);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x2D4A04C", Offset = "0x2D4604C", VA = "0x2D4A04C")]
		internal static TextureDesc CreateTextureDesc(RenderTextureDescriptor desc, TextureSizeMode textureSizeMode = TextureSizeMode.Explicit, int anisoLevel = 1, float mipMapBias = 0f, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp, string name = "")
		{
			return default(TextureDesc);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x2D4D0AC", Offset = "0x2D490AC", VA = "0x2D4D0AC")]
		public RTHandleResourcePool()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public enum SampleCount
	{
		[Token(Token = "0x40007E7")]
		One = 1,
		[Token(Token = "0x40007E8")]
		Two = 2,
		[Token(Token = "0x40007E9")]
		Four = 4
	}
	[Token(Token = "0x2000173")]
	public abstract class ScriptableRendererData : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000174")]
		[ReloadGroup]
		public sealed class DebugShaderResources
		{
			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Reload("Shaders/Debug/DebugReplacement.shader", ReloadAttribute.Package.Root)]
			public Shader debugReplacementPS;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Reload("Shaders/Debug/HDRDebugView.shader", ReloadAttribute.Package.Root)]
			public Shader hdrDebugViewPS;

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x2D4D2FC", Offset = "0x2D492FC", VA = "0x2D4D2FC")]
			public DebugShaderResources()
			{
			}
		}

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DebugShaderResources debugShaders;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal List<ScriptableRendererFeature> m_RendererFeatures;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal List<long> m_RendererFeatureMap;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_UseNativeRenderPass;

		[Token(Token = "0x170001AC")]
		internal bool isInvalidated
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x2D4D1CC", Offset = "0x2D491CC", VA = "0x2D4D1CC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x2D4D1D4", Offset = "0x2D491D4", VA = "0x2D4D1D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public List<ScriptableRendererFeature> rendererFeatures
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x2D4D1DC", Offset = "0x2D491DC", VA = "0x2D4D1DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AE")]
		public bool useNativeRenderPass
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x2D4D218", Offset = "0x2D49218", VA = "0x2D4D218")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x2D4D220", Offset = "0x2D49220", VA = "0x2D4D220")]
			set
			{
			}
		}

		[Token(Token = "0x6000808")]
		protected abstract ScriptableRenderer Create();

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x2D4D1E4", Offset = "0x2D491E4", VA = "0x2D4D1E4")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x2D4D1F0", Offset = "0x2D491F0", VA = "0x2D4D1F0")]
		internal ScriptableRenderer InternalCreateRenderer()
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x2D4D200", Offset = "0x2D49200", VA = "0x2D4D200", Slot = "5")]
		protected virtual void OnValidate()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x2D4D20C", Offset = "0x2D4920C", VA = "0x2D4D20C", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000810")]
		internal bool TryGetRendererFeature<T>(out T rendererFeature) where T : ScriptableRendererFeature
		{
			return default(bool);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x2D4D230", Offset = "0x2D49230", VA = "0x2D4D230")]
		protected ScriptableRendererData()
		{
		}
	}
	[Token(Token = "0x2000175")]
	[ExcludeFromPreset]
	public abstract class ScriptableRendererFeature : ScriptableObject, IDisposable
	{
		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private bool m_Active;

		[Token(Token = "0x170001AF")]
		public bool isActive
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x2D4D304", Offset = "0x2D49304", VA = "0x2D4D304")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000814")]
		public abstract void Create();

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x2D4D30C", Offset = "0x2D4930C", VA = "0x2D4D30C", Slot = "6")]
		public virtual void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData)
		{
		}

		[Token(Token = "0x6000816")]
		public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData);

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x2D4D310", Offset = "0x2D49310", VA = "0x2D4D310", Slot = "8")]
		public virtual void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x2D4D314", Offset = "0x2D49314", VA = "0x2D4D314")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x2D4D320", Offset = "0x2D49320", VA = "0x2D4D320")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x2D4D32C", Offset = "0x2D4932C", VA = "0x2D4D32C", Slot = "9")]
		internal virtual bool SupportsNativeRenderPass()
		{
			return default(bool);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x2D4D334", Offset = "0x2D49334", VA = "0x2D4D334", Slot = "10")]
		internal virtual bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x2D4D344", Offset = "0x2D49344", VA = "0x2D4D344")]
		public void SetActive(bool active)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x2D4D34C", Offset = "0x2D4934C", VA = "0x2D4D34C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x2D4D3B8", Offset = "0x2D493B8", VA = "0x2D4D3B8", Slot = "11")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x2D435E8", Offset = "0x2D3F5E8", VA = "0x2D435E8")]
		protected ScriptableRendererFeature()
		{
		}
	}
	[Token(Token = "0x2000176")]
	internal class ShaderData : IDisposable
	{
		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ShaderData m_Instance;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ComputeBuffer m_LightDataBuffer;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ComputeBuffer m_LightIndicesBuffer;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer;

		[Token(Token = "0x170001B0")]
		internal static ShaderData instance
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x2D4D3C4", Offset = "0x2D493C4", VA = "0x2D4D3C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x2D4D3BC", Offset = "0x2D493BC", VA = "0x2D4D3BC")]
		private ShaderData()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x2D4D43C", Offset = "0x2D4943C", VA = "0x2D4D43C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x2D4D4C0", Offset = "0x2D494C0", VA = "0x2D4D4C0")]
		internal ComputeBuffer GetLightDataBuffer(int size)
		{
			return null;
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x2D4D51C", Offset = "0x2D4951C", VA = "0x2D4D51C")]
		internal ComputeBuffer GetLightIndicesBuffer(int size)
		{
			return null;
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x2D4D578", Offset = "0x2D49578", VA = "0x2D4D578")]
		internal ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size)
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x2D4D5D4", Offset = "0x2D495D4", VA = "0x2D4D5D4")]
		internal ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size)
		{
			return null;
		}

		[Token(Token = "0x6000827")]
		private ComputeBuffer GetOrUpdateBuffer<T>(ref ComputeBuffer buffer, int size) where T : struct
		{
			return null;
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2D4D49C", Offset = "0x2D4949C", VA = "0x2D4D49C")]
		private void DisposeBuffer(ref ComputeBuffer buffer)
		{
		}
	}
	[Token(Token = "0x2000177")]
	public enum ShaderPathID
	{
		[Token(Token = "0x40007F8")]
		Lit,
		[Token(Token = "0x40007F9")]
		SimpleLit,
		[Token(Token = "0x40007FA")]
		Unlit,
		[Token(Token = "0x40007FB")]
		TerrainLit,
		[Token(Token = "0x40007FC")]
		ParticlesLit,
		[Token(Token = "0x40007FD")]
		ParticlesSimpleLit,
		[Token(Token = "0x40007FE")]
		ParticlesUnlit,
		[Token(Token = "0x40007FF")]
		BakedLit,
		[Token(Token = "0x4000800")]
		SpeedTree7,
		[Token(Token = "0x4000801")]
		SpeedTree7Billboard,
		[Token(Token = "0x4000802")]
		SpeedTree8
	}
	[Token(Token = "0x2000178")]
	public static class ShaderUtils
	{
		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] s_ShaderPaths;

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x2D4D630", Offset = "0x2D49630", VA = "0x2D4D630")]
		public static string GetShaderPath(ShaderPathID id)
		{
			return null;
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x2D4D83C", Offset = "0x2D4983C", VA = "0x2D4D83C")]
		public static ShaderPathID GetEnumFromPath(string path)
		{
			return default(ShaderPathID);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2D4D948", Offset = "0x2D49948", VA = "0x2D4D948")]
		public static bool IsLWShader(Shader shader)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200017A")]
	public struct ShadowSliceData
	{
		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Matrix4x4 viewMatrix;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Matrix4x4 projectionMatrix;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Matrix4x4 shadowTransform;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public int offsetX;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int offsetY;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int resolution;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public ShadowSplitData splitData;

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x2D4DBEC", Offset = "0x2D49BEC", VA = "0x2D4DBEC")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public static class ShadowUtils
	{
		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly bool m_ForceShadowPointSampling;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int _ShadowBias;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int _LightDirection;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static int _LightPosition;

		[Token(Token = "0x4000810")]
		internal const int kMinimumPunctualLightHardShadowResolution = 8;

		[Token(Token = "0x4000811")]
		internal const int kMinimumPunctualLightSoftShadowResolution = 16;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x2D4DC7C", Offset = "0x2D49C7C", VA = "0x2D4DC7C")]
		static ShadowUtils()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2D4DDAC", Offset = "0x2D49DAC", VA = "0x2D4DDAC")]
		public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			return default(bool);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2D4DEE0", Offset = "0x2D49EE0", VA = "0x2D4DEE0")]
		public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x2D4E320", Offset = "0x2D4A320", VA = "0x2D4E320")]
		public static bool ExtractSpotLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2D4E408", Offset = "0x2D4A408", VA = "0x2D4E408")]
		public static bool ExtractPointLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x2D4E540", Offset = "0x2D4A540", VA = "0x2D4E540")]
		public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings, Matrix4x4 proj, Matrix4x4 view)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x2D4E698", Offset = "0x2D4A698", VA = "0x2D4E698")]
		public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings)
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x2D4E748", Offset = "0x2D4A748", VA = "0x2D4E748")]
		public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x2D4E200", Offset = "0x2D4A200", VA = "0x2D4E200")]
		public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x2D4E774", Offset = "0x2D4A774", VA = "0x2D4E774")]
		public static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x2D4EAF0", Offset = "0x2D4AAF0", VA = "0x2D4EAF0")]
		internal static void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, out float scale, out float bias)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x2D4EB44", Offset = "0x2D4AB44", VA = "0x2D4EB44")]
		public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x2D4EC5C", Offset = "0x2D4AC5C", VA = "0x2D4EC5C")]
		internal static void SetShadowBias(CommandBuffer cmd, Vector4 shadowBias)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x2D4ECF8", Offset = "0x2D4ACF8", VA = "0x2D4ECF8")]
		internal static void SetLightDirection(CommandBuffer cmd, Vector3 lightDirection)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x2D4ED90", Offset = "0x2D4AD90", VA = "0x2D4ED90")]
		internal static void SetLightPosition(CommandBuffer cmd, Vector3 lightPosition)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x2D4EE28", Offset = "0x2D4AE28", VA = "0x2D4EE28")]
		internal static void SetCameraPosition(CommandBuffer cmd, Vector3 worldSpaceCameraPos)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x2D4EEC0", Offset = "0x2D4AEC0", VA = "0x2D4EEC0")]
		internal static void SetWorldToCameraAndCameraToWorldMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x2D4F000", Offset = "0x2D4B000", VA = "0x2D4F000")]
		private static RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits)
		{
			return default(RenderTextureDescriptor);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x2D4F118", Offset = "0x2D4B118", VA = "0x2D4F118")]
		[Obsolete("Use AllocShadowRT or ShadowRTReAllocateIfNeeded")]
		public static RenderTexture GetTemporaryShadowTexture(int width, int height, int bits)
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x2D4F1D8", Offset = "0x2D4B1D8", VA = "0x2D4F1D8")]
		public static bool ShadowRTNeedsReAlloc(RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x2D4F3F4", Offset = "0x2D4B3F4", VA = "0x2D4F3F4")]
		public static RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name)
		{
			return null;
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x2D4F4E0", Offset = "0x2D4B4E0", VA = "0x2D4F4E0")]
		public static bool ShadowRTReAllocateIfNeeded(ref RTHandle handle, int width, int height, int bits, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return default(bool);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x2D4E09C", Offset = "0x2D4A09C", VA = "0x2D4E09C")]
		private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x2D4F5D0", Offset = "0x2D4B5D0", VA = "0x2D4F5D0")]
		internal static float SoftShadowQualityToShaderProperty(Light light, bool softShadowsEnabled)
		{
			return default(float);
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x2D4F740", Offset = "0x2D4B740", VA = "0x2D4F740")]
		internal static bool SupportsPerLightSoftShadowQuality()
		{
			return default(bool);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x2D4F7D0", Offset = "0x2D4B7D0", VA = "0x2D4F7D0")]
		internal static void SetPerLightSoftShadowKeyword(CommandBuffer cmd, bool hasSoftShadows)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x2D4F88C", Offset = "0x2D4B88C", VA = "0x2D4F88C")]
		internal static void SetSoftShadowQualityShaderKeywords(CommandBuffer cmd, ref ShadowData shadowData)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2D4FB70", Offset = "0x2D4BB70", VA = "0x2D4FB70")]
		internal static bool IsValidShadowCastingLight(ref LightData lightData, int i)
		{
			return default(bool);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x2D4FCD0", Offset = "0x2D4BCD0", VA = "0x2D4FCD0")]
		internal static int GetPunctualLightShadowSlicesCount(in LightType lightType)
		{
			return default(int);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x2D4FCEC", Offset = "0x2D4BCEC", VA = "0x2D4FCEC")]
		internal static int MinimalPunctualLightShadowResolution(bool softShadow)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200017C")]
	internal static class SpaceFillingCurves
	{
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x2D4FD00", Offset = "0x2D4BD00", VA = "0x2D4FD00")]
		private static uint Part1By1(uint x)
		{
			return default(uint);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x2D4FD24", Offset = "0x2D4BD24", VA = "0x2D4FD24")]
		private static uint Compact1By1(uint x)
		{
			return default(uint);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2D4FD4C", Offset = "0x2D4BD4C", VA = "0x2D4FD4C")]
		public static uint EncodeMorton2D(uint2 coord)
		{
			return default(uint);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2D41B90", Offset = "0x2D3DB90", VA = "0x2D41B90")]
		public static uint2 DecodeMorton2D(uint code)
		{
			return default(uint2);
		}
	}
	[Token(Token = "0x200017D")]
	public enum TemporalAAQuality
	{
		[Token(Token = "0x4000813")]
		VeryLow,
		[Token(Token = "0x4000814")]
		Low,
		[Token(Token = "0x4000815")]
		Medium,
		[Token(Token = "0x4000816")]
		High,
		[Token(Token = "0x4000817")]
		VeryHigh
	}
	[Token(Token = "0x200017E")]
	internal sealed class TaaPersistentData
	{
		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GraphicsFormat[] formatList;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RenderTextureDescriptor m_RtDesc;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RTHandle m_AccumulationTexture;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RTHandle m_AccumulationTexture2;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_LastAccumUpdateFrameIndex;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_LastAccumUpdateFrameIndex2;

		[Token(Token = "0x170001B1")]
		public RenderTextureDescriptor rtd
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x2D4FDC0", Offset = "0x2D4BDC0", VA = "0x2D4FDC0")]
			get
			{
				return default(RenderTextureDescriptor);
			}
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x2D4FDDC", Offset = "0x2D4BDDC", VA = "0x2D4FDDC")]
		public RTHandle accumulationTexture(int index)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x2D4FDF4", Offset = "0x2D4BDF4", VA = "0x2D4FDF4")]
		public int GetLastAccumFrameIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x2D4FE0C", Offset = "0x2D4BE0C", VA = "0x2D4FE0C")]
		public void SetLastAccumFrameIndex(int index, int value)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x2D4FE20", Offset = "0x2D4BE20", VA = "0x2D4FE20")]
		public TaaPersistentData()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x2D4FE28", Offset = "0x2D4BE28", VA = "0x2D4FE28")]
		public void Init(int sizeX, int sizeY, int volumeDepth, GraphicsFormat format, VRTextureUsage vrUsage, TextureDimension texDim)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x2D5009C", Offset = "0x2D4C09C", VA = "0x2D5009C")]
		public bool AllocateTargets(bool xrMultipassEnabled = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x2D50054", Offset = "0x2D4C054", VA = "0x2D50054")]
		public void DeallocateTargets()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public static class TemporalAA
	{
		[Token(Token = "0x2000180")]
		internal static class ShaderConstants
		{
			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int _TaaAccumulationTex;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int _TaaMotionVectorTex;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int _TaaFilterWeights;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int _TaaFrameInfluence;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int _TaaVarianceClampScale;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly int _CameraDepthTexture;
		}

		[Token(Token = "0x2000181")]
		internal static class ShaderKeywords
		{
			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly string TAA_LOW_PRECISION_SOURCE;
		}

		[Serializable]
		[Token(Token = "0x2000182")]
		public struct Settings
		{
			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			[FormerlySerializedAs("quality")]
			internal TemporalAAQuality m_Quality;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[SerializeField]
			[FormerlySerializedAs("frameInfluence")]
			internal float m_FrameInfluence;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			[FormerlySerializedAs("jitterScale")]
			internal float m_JitterScale;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[SerializeField]
			[FormerlySerializedAs("mipBias")]
			internal float m_MipBias;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[FormerlySerializedAs("varianceClampScale")]
			[SerializeField]
			internal float m_VarianceClampScale;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			[FormerlySerializedAs("contrastAdaptiveSharpening")]
			internal float m_ContrastAdaptiveSharpening;

			[NonSerialized]
			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int resetHistoryFrames;

			[NonSerialized]
			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int jitterFrameCountOffset;

			[Token(Token = "0x170001B2")]
			public TemporalAAQuality quality
			{
				[Token(Token = "0x6000866")]
				[Address(RVA = "0x2D51650", Offset = "0x2D4D650", VA = "0x2D51650")]
				get
				{
					return default(TemporalAAQuality);
				}
				[Token(Token = "0x6000867")]
				[Address(RVA = "0x2D51658", Offset = "0x2D4D658", VA = "0x2D51658")]
				set
				{
				}
			}

			[Token(Token = "0x170001B3")]
			public float baseBlendFactor
			{
				[Token(Token = "0x6000868")]
				[Address(RVA = "0x2D51674", Offset = "0x2D4D674", VA = "0x2D51674")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000869")]
				[Address(RVA = "0x2D51684", Offset = "0x2D4D684", VA = "0x2D51684")]
				set
				{
				}
			}

			[Token(Token = "0x170001B4")]
			public float jitterScale
			{
				[Token(Token = "0x600086A")]
				[Address(RVA = "0x2D516A8", Offset = "0x2D4D6A8", VA = "0x2D516A8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600086B")]
				[Address(RVA = "0x2D516B0", Offset = "0x2D4D6B0", VA = "0x2D516B0")]
				set
				{
				}
			}

			[Token(Token = "0x170001B5")]
			public float mipBias
			{
				[Token(Token = "0x600086C")]
				[Address(RVA = "0x2D516D0", Offset = "0x2D4D6D0", VA = "0x2D516D0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600086D")]
				[Address(RVA = "0x2D516D8", Offset = "0x2D4D6D8", VA = "0x2D516D8")]
				set
				{
				}
			}

			[Token(Token = "0x170001B6")]
			public float varianceClampScale
			{
				[Token(Token = "0x600086E")]
				[Address(RVA = "0x2D516F8", Offset = "0x2D4D6F8", VA = "0x2D516F8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600086F")]
				[Address(RVA = "0x2D51700", Offset = "0x2D4D700", VA = "0x2D51700")]
				set
				{
				}
			}

			[Token(Token = "0x170001B7")]
			public float contrastAdaptiveSharpening
			{
				[Token(Token = "0x6000870")]
				[Address(RVA = "0x2D51724", Offset = "0x2D4D724", VA = "0x2D51724")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000871")]
				[Address(RVA = "0x2D5172C", Offset = "0x2D4D72C", VA = "0x2D5172C")]
				set
				{
				}
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x2D5174C", Offset = "0x2D4D74C", VA = "0x2D5174C")]
			public static Settings Create()
			{
				return default(Settings);
			}
		}

		[Token(Token = "0x2000183")]
		private class TaaPassData
		{
			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle dstTex;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle srcColorTex;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal TextureHandle srcDepthTex;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal TextureHandle srcMotionVectorTex;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal TextureHandle srcTaaAccumTex;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Material material;

			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int passIndex;

			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal float taaFrameInfluence;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal float taaVarianceClampScale;

			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal float[] taaFilterWeights;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal bool taaLowPrecisionSource;

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x2D5176C", Offset = "0x2D4D76C", VA = "0x2D5176C")]
			public TaaPassData()
			{
			}
		}

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector2[] taaFilterOffsets;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float[] taaFilterWeights;

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x2D50340", Offset = "0x2D4C340", VA = "0x2D50340")]
		internal static Matrix4x4 CalculateJitterMatrix(ref CameraData cameraData)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x2D50464", Offset = "0x2D4C464", VA = "0x2D50464")]
		internal static Vector2 CalculateJitter(int frameIndex)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x2D504AC", Offset = "0x2D4C4AC", VA = "0x2D504AC")]
		internal static float[] CalculateFilterWeights(float jitterScale)
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x2D50628", Offset = "0x2D4C628", VA = "0x2D50628")]
		internal static string ValidateAndWarn(ref CameraData cameraData)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x2D5080C", Offset = "0x2D4C80C", VA = "0x2D5080C")]
		internal static void ExecutePass(CommandBuffer cmd, Material taaMaterial, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderTexture motionVectors)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x2D50C94", Offset = "0x2D4CC94", VA = "0x2D50C94")]
		internal static void Render(RenderGraph renderGraph, Material taaMaterial, ref CameraData cameraData, ref TextureHandle srcColor, ref TextureHandle srcDepth, ref TextureHandle srcMotionVectors, ref TextureHandle dstColor)
		{
		}
	}
	[Token(Token = "0x2000185")]
	internal struct InclusiveRange
	{
		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short start;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public short end;

		[Token(Token = "0x170001B8")]
		public bool isEmpty
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0x2D51CF4", Offset = "0x2D4DCF4", VA = "0x2D51CF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B9")]
		public static InclusiveRange empty
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x2D51DBC", Offset = "0x2D4DDBC", VA = "0x2D51DBC")]
			get
			{
				return default(InclusiveRange);
			}
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x2D51BC4", Offset = "0x2D4DBC4", VA = "0x2D51BC4")]
		public InclusiveRange(short startEnd)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x2D51BD0", Offset = "0x2D4DBD0", VA = "0x2D51BD0")]
		public InclusiveRange(short start, short end)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2D51BDC", Offset = "0x2D4DBDC", VA = "0x2D51BDC")]
		public void Expand(short index)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x2D51C68", Offset = "0x2D4DC68", VA = "0x2D51C68")]
		public void Clamp(short min, short max)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2D51D08", Offset = "0x2D4DD08", VA = "0x2D51D08")]
		public bool Contains(short index)
		{
			return default(bool);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x2D51D2C", Offset = "0x2D4DD2C", VA = "0x2D51D2C")]
		public static InclusiveRange Merge(InclusiveRange a, InclusiveRange b)
		{
			return default(InclusiveRange);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x2D51DC4", Offset = "0x2D4DDC4", VA = "0x2D51DC4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000186")]
	[BurstCompile]
	internal struct LightMinMaxZJob : IJobFor
	{
		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Fixed2<float4x4> worldToViews;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Unity.Collections.ReadOnly]
		public NativeArray<VisibleLight> lights;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public NativeArray<float2> minMaxZs;

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x2D51E64", Offset = "0x2D4DE64", VA = "0x2D51E64", Slot = "4")]
		public void Execute(int index)
		{
		}
	}
	[Token(Token = "0x2000187")]
	[BurstCompile]
	internal struct ReflectionProbeMinMaxZJob : IJobFor
	{
		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Fixed2<float4x4> worldToViews;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Unity.Collections.ReadOnly]
		public NativeArray<VisibleReflectionProbe> reflectionProbes;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public NativeArray<float2> minMaxZs;

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x2D52328", Offset = "0x2D4E328", VA = "0x2D52328", Slot = "4")]
		public void Execute(int index)
		{
		}
	}
	[Token(Token = "0x2000188")]
	[BurstCompile(FloatMode = FloatMode.Fast, DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct TileRangeExpansionJob : IJobFor
	{
		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Unity.Collections.ReadOnly]
		public NativeArray<InclusiveRange> tileRanges;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NativeDisableParallelForRestriction]
		public NativeArray<uint> tileMasks;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int rangesPerItem;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int itemsPerTile;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int wordsPerTile;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int2 tileResolution;

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x2D524F8", Offset = "0x2D4E4F8", VA = "0x2D524F8", Slot = "4")]
		public void Execute(int jobIndex)
		{
		}
	}
	[Token(Token = "0x2000189")]
	internal enum TileSize
	{
		[Token(Token = "0x400084C")]
		_8 = 8,
		[Token(Token = "0x400084D")]
		_16 = 0x10,
		[Token(Token = "0x400084E")]
		_32 = 0x20,
		[Token(Token = "0x400084F")]
		_64 = 0x40
	}
	[Token(Token = "0x200018A")]
	internal static class TileSizeExtensions
	{
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x2D52720", Offset = "0x2D4E720", VA = "0x2D52720")]
		public static bool IsValid(this TileSize tileSize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200018B")]
	[BurstCompile(FloatMode = FloatMode.Default, DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct TilingJob : IJobFor
	{
		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Unity.Collections.ReadOnly]
		public NativeArray<VisibleLight> lights;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Unity.Collections.ReadOnly]
		public NativeArray<VisibleReflectionProbe> reflectionProbes;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NativeDisableParallelForRestriction]
		public NativeArray<InclusiveRange> tileRanges;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int itemsPerTile;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int rangesPerItem;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Fixed2<float4x4> worldToViews;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float2 tileScale;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float2 tileScaleInv;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Fixed2<float> viewPlaneBottoms;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Fixed2<float> viewPlaneTops;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Fixed2<float4> viewToViewportScaleBiases;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public int2 tileCount;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public float near;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool isOrthographic;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		private InclusiveRange m_TileYRange;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private int m_Offset;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int m_ViewIndex;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float2 m_CenterOffset;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float3[] k_CubePoints;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int4[] k_CubeLineIndices;

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x2D52740", Offset = "0x2D4E740", VA = "0x2D52740", Slot = "4")]
		public void Execute(int jobIndex)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x2D534F4", Offset = "0x2D4F4F4", VA = "0x2D534F4")]
		private void TileLight(int lightIndex)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x2D52884", Offset = "0x2D4E884", VA = "0x2D52884")]
		private void TileLightOrthographic(int lightIndex)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x2D550F0", Offset = "0x2D510F0", VA = "0x2D550F0")]
		private void TileReflectionProbe(int index)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x2D56BB0", Offset = "0x2D52BB0", VA = "0x2D56BB0")]
		private float2 ViewToTileSpace(float3 positionVS)
		{
			return default(float2);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x2D57A28", Offset = "0x2D53A28", VA = "0x2D57A28")]
		private float2 ViewToTileSpaceOrthographic(float3 positionVS)
		{
			return default(float2);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x2D55940", Offset = "0x2D51940", VA = "0x2D55940")]
		private void ExpandY(float3 positionVS)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x2D5773C", Offset = "0x2D5373C", VA = "0x2D5773C")]
		private void ExpandOrthographic(float3 positionVS)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x2D5794C", Offset = "0x2D5394C", VA = "0x2D5794C")]
		private void ExpandRangeOrthographic(ref InclusiveRange range, float xVS)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x2D55A60", Offset = "0x2D51A60", VA = "0x2D55A60")]
		private static float square(float x)
		{
			return default(float);
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x2D55A68", Offset = "0x2D51A68", VA = "0x2D55A68")]
		private static void GetSphereHorizon(float2 center, float radius, float near, float clipRadius, out float2 p0, out float2 p1)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x2D5735C", Offset = "0x2D5335C", VA = "0x2D5735C")]
		private static void GetSphereYPlaneHorizon(float3 center, float sphereRadius, float near, float clipRadius, float y, out float3 left, out float3 right)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x2D55FAC", Offset = "0x2D51FAC", VA = "0x2D55FAC")]
		private static bool GetCircleClipPoints(float3 circleCenter, float3 circleNormal, float circleRadius, float near, out float3 p0, out float3 p1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x2D57AB4", Offset = "0x2D53AB4", VA = "0x2D57AB4")]
		private static (float, float) IntersectEllipseLine(float a, float b, float3 line)
		{
			return default((float, float));
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x2D55DB4", Offset = "0x2D51DB4", VA = "0x2D55DB4")]
		private static void GetProjectedCircleHorizon(float2 center, float radius, float2 U, float2 V, out float2 uv1, out float2 uv2)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x2D56C50", Offset = "0x2D52C50", VA = "0x2D56C50")]
		private static bool IntersectCircleYPlane(float y, float3 circleCenter, float3 circleNormal, float3 circleU, float3 circleV, float circleRadius, out float3 p1, out float3 p2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x2D566F4", Offset = "0x2D526F4", VA = "0x2D566F4")]
		private static void GetConeSideTangentPoints(float3 vertex, float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, float3 circleU, float3 circleV, out float3 l1, out float3 l2)
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x2D56420", Offset = "0x2D52420", VA = "0x2D56420")]
		private static float3 EvaluateNearConic(float near, float3 o, float3 d, float r, float3 u, float3 v, float theta)
		{
			return default(float3);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x2D561B0", Offset = "0x2D521B0", VA = "0x2D561B0")]
		private static float2 FindNearConicTangentTheta(float2 o, float2 d, float r, float2 u, float2 v)
		{
			return default(float2);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x2D56EFC", Offset = "0x2D52EFC", VA = "0x2D56EFC")]
		private static float2 FindNearConicYTheta(float near, float3 o, float3 d, float r, float3 u, float3 v, float y)
		{
			return default(float2);
		}
	}
	[Token(Token = "0x200018E")]
	[BurstCompile(FloatMode = FloatMode.Fast, DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct ZBinningJob : IJobFor
	{
		[Token(Token = "0x400086D")]
		public const int batchSize = 128;

		[Token(Token = "0x400086E")]
		public const int headerLength = 2;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[NativeDisableParallelForRestriction]
		public NativeArray<uint> bins;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Unity.Collections.ReadOnly]
		public NativeArray<float2> minMaxZs;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float zBinScale;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float zBinOffset;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int binCount;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int wordsPerTile;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int lightCount;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int reflectionProbeCount;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int batchCount;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int viewCount;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isOrthographic;

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x2D57DC8", Offset = "0x2D53DC8", VA = "0x2D57DC8")]
		private static uint EncodeHeader(uint min, uint max)
		{
			return default(uint);
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x2D57DD0", Offset = "0x2D53DD0", VA = "0x2D57DD0")]
		private static (uint, uint) DecodeHeader(uint zBin)
		{
			return default((uint, uint));
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x2D57E34", Offset = "0x2D53E34", VA = "0x2D57E34", Slot = "4")]
		public void Execute(int jobIndex)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x2D57F48", Offset = "0x2D53F48", VA = "0x2D57F48")]
		private void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset)
		{
		}
	}
	[Token(Token = "0x200018F")]
	public enum CameraOverrideOption
	{
		[Token(Token = "0x400087B")]
		Off,
		[Token(Token = "0x400087C")]
		On,
		[Token(Token = "0x400087D")]
		[InspectorName("Use settings from Render Pipeline Asset")]
		UsePipelineSettings
	}
	[Token(Token = "0x2000190")]
	public enum RendererOverrideOption
	{
		[Token(Token = "0x400087F")]
		Custom,
		[Token(Token = "0x4000880")]
		UsePipelineSettings
	}
	[Token(Token = "0x2000191")]
	public enum AntialiasingMode
	{
		[Token(Token = "0x4000882")]
		[InspectorName("No Anti-aliasing")]
		None,
		[Token(Token = "0x4000883")]
		[InspectorName("Fast Approximate Anti-aliasing (FXAA)")]
		FastApproximateAntialiasing,
		[Token(Token = "0x4000884")]
		[InspectorName("Subpixel Morphological Anti-aliasing (SMAA)")]
		SubpixelMorphologicalAntiAliasing,
		[Token(Token = "0x4000885")]
		[InspectorName("Temporal Anti-aliasing (TAA)")]
		TemporalAntiAliasing
	}
	[Token(Token = "0x2000192")]
	public enum CameraRenderType
	{
		[Token(Token = "0x4000887")]
		Base,
		[Token(Token = "0x4000888")]
		Overlay
	}
	[Token(Token = "0x2000193")]
	public enum AntialiasingQuality
	{
		[Token(Token = "0x400088A")]
		Low,
		[Token(Token = "0x400088B")]
		Medium,
		[Token(Token = "0x400088C")]
		High
	}
	[Token(Token = "0x2000194")]
	public static class CameraExtensions
	{
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x2D5816C", Offset = "0x2D5416C", VA = "0x2D5816C")]
		public static UniversalAdditionalCameraData GetUniversalAdditionalCameraData(this Camera camera)
		{
			return null;
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x2D58204", Offset = "0x2D54204", VA = "0x2D58204")]
		public static VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(this Camera camera)
		{
			return default(VolumeFrameworkUpdateMode);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x2D58220", Offset = "0x2D54220", VA = "0x2D58220")]
		public static void SetVolumeFrameworkUpdateMode(this Camera camera, VolumeFrameworkUpdateMode mode)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x2D583D4", Offset = "0x2D543D4", VA = "0x2D583D4")]
		public static void UpdateVolumeStack(this Camera camera)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x2D5830C", Offset = "0x2D5430C", VA = "0x2D5830C")]
		public static void UpdateVolumeStack(this Camera camera, UniversalAdditionalCameraData cameraData)
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x2D586E8", Offset = "0x2D546E8", VA = "0x2D586E8")]
		public static void DestroyVolumeStack(this Camera camera)
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x2D586FC", Offset = "0x2D546FC", VA = "0x2D586FC")]
		public static void DestroyVolumeStack(this Camera camera, UniversalAdditionalCameraData cameraData)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x2D5850C", Offset = "0x2D5450C", VA = "0x2D5850C")]
		internal static void GetVolumeLayerMaskAndTrigger(this Camera camera, UniversalAdditionalCameraData cameraData, out LayerMask layerMask, out Transform trigger)
		{
		}
	}
	[Token(Token = "0x2000195")]
	internal static class CameraTypeUtility
	{
		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] s_CameraTypeNames;

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x2D588B0", Offset = "0x2D548B0", VA = "0x2D588B0")]
		public static string GetName(this CameraRenderType type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000196")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	public class UniversalAdditionalCameraData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData
	{
		[Token(Token = "0x400088E")]
		private const string k_GizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/";

		[Token(Token = "0x400088F")]
		private const string k_BaseCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";

		[Token(Token = "0x4000890")]
		private const string k_OverlayCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";

		[Token(Token = "0x4000891")]
		private const string k_PostProcessingGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_PostProcessing.png";

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("renderShadows")]
		private bool m_RenderShadows;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CameraOverrideOption m_RequiresDepthTextureOption;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CameraOverrideOption m_RequiresOpaqueTextureOption;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private CameraRenderType m_CameraType;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Camera> m_Cameras;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_RendererIndex;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LayerMask m_VolumeLayerMask;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform m_VolumeTrigger;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateModeOption;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool m_RenderPostProcessing;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AntialiasingMode m_Antialiasing;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private AntialiasingQuality m_AntialiasingQuality;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_StopNaN;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_Dithering;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		[SerializeField]
		private bool m_ClearDepth;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		[SerializeField]
		private bool m_AllowXRRendering;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool m_AllowHDROutput;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[SerializeField]
		private bool m_UseScreenCoordOverride;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector4 m_ScreenSizeOverride;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector4 m_ScreenCoordScaleBias;

		[NonSerialized]
		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Camera m_Camera;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("requiresDepthTexture")]
		[SerializeField]
		private bool m_RequiresDepthTexture;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[FormerlySerializedAs("requiresColorTexture")]
		[SerializeField]
		private bool m_RequiresColorTexture;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[HideInInspector]
		[SerializeField]
		private float m_Version;

		[NonSerialized]
		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MotionVectorsPersistentData m_MotionVectorsPersistentData;

		[NonSerialized]
		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TaaPersistentData m_TaaPersistentData;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		internal TemporalAA.Settings m_TaaSettings;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UniversalAdditionalCameraData s_DefaultAdditionalCameraData;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<VolumeStack> s_CachedVolumeStacks;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private VolumeStack m_VolumeStack;

		[Token(Token = "0x170001BA")]
		public float version
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x2D58A4C", Offset = "0x2D54A4C", VA = "0x2D58A4C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001BB")]
		internal static UniversalAdditionalCameraData defaultAdditionalCameraData
		{
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x2D58A54", Offset = "0x2D54A54", VA = "0x2D58A54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BC")]
		internal Camera camera
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x2D58C40", Offset = "0x2D54C40", VA = "0x2D58C40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BD")]
		public bool renderShadows
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x2D58CE0", Offset = "0x2D54CE0", VA = "0x2D58CE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x2D58CE8", Offset = "0x2D54CE8", VA = "0x2D58CE8")]
			set
			{
			}
		}

		[Token(Token = "0x170001BE")]
		public CameraOverrideOption requiresDepthOption
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x2D58CF0", Offset = "0x2D54CF0", VA = "0x2D58CF0")]
			get
			{
				return default(CameraOverrideOption);
			}
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x2D58CF8", Offset = "0x2D54CF8", VA = "0x2D58CF8")]
			set
			{
			}
		}

		[Token(Token = "0x170001BF")]
		public CameraOverrideOption requiresColorOption
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x2D58D00", Offset = "0x2D54D00", VA = "0x2D58D00")]
			get
			{
				return default(CameraOverrideOption);
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x2D58D08", Offset = "0x2D54D08", VA = "0x2D58D08")]
			set
			{
			}
		}

		[Token(Token = "0x170001C0")]
		public CameraRenderType renderType
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x2D58D10", Offset = "0x2D54D10", VA = "0x2D58D10")]
			get
			{
				return default(CameraRenderType);
			}
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x2D58D18", Offset = "0x2D54D18", VA = "0x2D58D18")]
			set
			{
			}
		}

		[Token(Token = "0x170001C1")]
		public List<Camera> cameraStack
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x2D58D20", Offset = "0x2D54D20", VA = "0x2D58D20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C2")]
		public bool clearDepth
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x2D593B0", Offset = "0x2D553B0", VA = "0x2D593B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C3")]
		public bool requiresDepthTexture
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x2D593B8", Offset = "0x2D553B8", VA = "0x2D593B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x2D59434", Offset = "0x2D55434", VA = "0x2D59434")]
			set
			{
			}
		}

		[Token(Token = "0x170001C4")]
		public bool requiresColorTexture
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x2D5944C", Offset = "0x2D5544C", VA = "0x2D5944C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x2D594C8", Offset = "0x2D554C8", VA = "0x2D594C8")]
			set
			{
			}
		}

		[Token(Token = "0x170001C5")]
		public ScriptableRenderer scriptableRenderer
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x2D58EA4", Offset = "0x2D54EA4", VA = "0x2D58EA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C6")]
		public LayerMask volumeLayerMask
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x2D594E8", Offset = "0x2D554E8", VA = "0x2D594E8")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x2D594F0", Offset = "0x2D554F0", VA = "0x2D594F0")]
			set
			{
			}
		}

		[Token(Token = "0x170001C7")]
		public Transform volumeTrigger
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x2D594F8", Offset = "0x2D554F8", VA = "0x2D594F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x2D59500", Offset = "0x2D55500", VA = "0x2D59500")]
			set
			{
			}
		}

		[Token(Token = "0x170001C8")]
		internal VolumeFrameworkUpdateMode volumeFrameworkUpdateMode
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x2D59508", Offset = "0x2D55508", VA = "0x2D59508")]
			get
			{
				return default(VolumeFrameworkUpdateMode);
			}
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x2D59510", Offset = "0x2D55510", VA = "0x2D59510")]
			set
			{
			}
		}

		[Token(Token = "0x170001C9")]
		public bool requiresVolumeFrameworkUpdate
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x2D58288", Offset = "0x2D54288", VA = "0x2D58288")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001CA")]
		public VolumeStack volumeStack
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x2D59518", Offset = "0x2D55518", VA = "0x2D59518")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x2D58784", Offset = "0x2D54784", VA = "0x2D58784")]
			set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public bool renderPostProcessing
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x2D59520", Offset = "0x2D55520", VA = "0x2D59520")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x2D59528", Offset = "0x2D55528", VA = "0x2D59528")]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public AntialiasingMode antialiasing
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x2D59530", Offset = "0x2D55530", VA = "0x2D59530")]
			get
			{
				return default(AntialiasingMode);
			}
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x2D59538", Offset = "0x2D55538", VA = "0x2D59538")]
			set
			{
			}
		}

		[Token(Token = "0x170001CD")]
		public AntialiasingQuality antialiasingQuality
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x2D59540", Offset = "0x2D55540", VA = "0x2D59540")]
			get
			{
				return default(AntialiasingQuality);
			}
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x2D59548", Offset = "0x2D55548", VA = "0x2D59548")]
			set
			{
			}
		}

		[Token(Token = "0x170001CE")]
		public unsafe ref TemporalAA.Settings taaSettings
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x2D59550", Offset = "0x2D55550", VA = "0x2D59550")]
			get
			{
				return ref *(TemporalAA.Settings*)null;
			}
		}

		[Token(Token = "0x170001CF")]
		internal TaaPersistentData taaPersistentData
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x2D59558", Offset = "0x2D55558", VA = "0x2D59558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D0")]
		internal MotionVectorsPersistentData motionVectorsPersistentData
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x2D59560", Offset = "0x2D55560", VA = "0x2D59560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D1")]
		public bool resetHistory
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x2D59568", Offset = "0x2D55568", VA = "0x2D59568")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x2D59578", Offset = "0x2D55578", VA = "0x2D59578")]
			set
			{
			}
		}

		[Token(Token = "0x170001D2")]
		public bool stopNaN
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x2D595BC", Offset = "0x2D555BC", VA = "0x2D595BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x2D595C4", Offset = "0x2D555C4", VA = "0x2D595C4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public bool dithering
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x2D595CC", Offset = "0x2D555CC", VA = "0x2D595CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x2D595D4", Offset = "0x2D555D4", VA = "0x2D595D4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public bool allowXRRendering
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x2D595DC", Offset = "0x2D555DC", VA = "0x2D595DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x2D595E4", Offset = "0x2D555E4", VA = "0x2D595E4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D5")]
		public bool useScreenCoordOverride
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x2D595EC", Offset = "0x2D555EC", VA = "0x2D595EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x2D595F4", Offset = "0x2D555F4", VA = "0x2D595F4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public Vector4 screenSizeOverride
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x2D595FC", Offset = "0x2D555FC", VA = "0x2D595FC")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x2D59608", Offset = "0x2D55608", VA = "0x2D59608")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public Vector4 screenCoordScaleBias
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x2D59614", Offset = "0x2D55614", VA = "0x2D59614")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x2D59620", Offset = "0x2D55620", VA = "0x2D59620")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public bool allowHDROutput
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x2D5962C", Offset = "0x2D5562C", VA = "0x2D5962C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x2D59634", Offset = "0x2D55634", VA = "0x2D59634")]
			set
			{
			}
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x2D59124", Offset = "0x2D55124", VA = "0x2D59124")]
		internal void UpdateCameraStack()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x2D594E0", Offset = "0x2D554E0", VA = "0x2D594E0")]
		public void SetRenderer(int index)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x2D583F0", Offset = "0x2D543F0", VA = "0x2D583F0")]
		internal void GetOrCreateVolumeStack()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x2D5963C", Offset = "0x2D5563C", VA = "0x2D5963C", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x2D59640", Offset = "0x2D55640", VA = "0x2D59640", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x2D59660", Offset = "0x2D55660", VA = "0x2D59660")]
		public void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x2D59778", Offset = "0x2D55778", VA = "0x2D59778")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x2D597DC", Offset = "0x2D557DC", VA = "0x2D597DC")]
		private ScriptableRenderer GetRawRenderer()
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x2D58AFC", Offset = "0x2D54AFC", VA = "0x2D58AFC")]
		public UniversalAdditionalCameraData()
		{
		}
	}
	[Token(Token = "0x2000198")]
	[Flags]
	public enum LightLayerEnum
	{
		[Token(Token = "0x40008B3")]
		Nothing = 0,
		[Token(Token = "0x40008B4")]
		LightLayerDefault = 1,
		[Token(Token = "0x40008B5")]
		LightLayer1 = 2,
		[Token(Token = "0x40008B6")]
		LightLayer2 = 4,
		[Token(Token = "0x40008B7")]
		LightLayer3 = 8,
		[Token(Token = "0x40008B8")]
		LightLayer4 = 0x10,
		[Token(Token = "0x40008B9")]
		LightLayer5 = 0x20,
		[Token(Token = "0x40008BA")]
		LightLayer6 = 0x40,
		[Token(Token = "0x40008BB")]
		LightLayer7 = 0x80,
		[Token(Token = "0x40008BC")]
		Everything = 0xFF
	}
	[Token(Token = "0x2000199")]
	public static class LightExtensions
	{
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x2D599EC", Offset = "0x2D559EC", VA = "0x2D599EC")]
		public static UniversalAdditionalLightData GetUniversalAdditionalLightData(this Light light)
		{
			return null;
		}
	}
	[Token(Token = "0x200019A")]
	[RequireComponent(typeof(Light))]
	[DisallowMultipleComponent]
	public class UniversalAdditionalLightData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData
	{
		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_Version;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Controls if light Shadow Bias parameters use pipeline settings.")]
		private bool m_UsePipelineSettings;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int AdditionalLightsShadowResolutionTierCustom;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int AdditionalLightsShadowResolutionTierLow;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int AdditionalLightsShadowResolutionTierMedium;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int AdditionalLightsShadowResolutionTierHigh;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int AdditionalLightsShadowDefaultResolutionTier;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int AdditionalLightsShadowDefaultCustomResolution;

		[NonSerialized]
		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Light m_Light;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int AdditionalLightsShadowMinimumResolution;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Controls if light shadow resolution uses pipeline settings.")]
		private int m_AdditionalLightsShadowResolutionTier;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Obsolete("This is obsolete, please use m_RenderingLayerMask instead.", false)]
		[SerializeField]
		private LightLayerEnum m_LightLayerMask;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private uint m_RenderingLayers;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool m_CustomShadowLayers;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LightLayerEnum m_ShadowLayerMask;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private uint m_ShadowRenderingLayers;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 m_LightCookieSize;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 m_LightCookieOffset;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SoftShadowQuality m_SoftShadowQuality;

		[Token(Token = "0x170001D9")]
		internal int version
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x2D59A84", Offset = "0x2D55A84", VA = "0x2D59A84")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001DA")]
		public bool usePipelineSettings
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x2D59A8C", Offset = "0x2D55A8C", VA = "0x2D59A8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x2D59A94", Offset = "0x2D55A94", VA = "0x2D59A94")]
			set
			{
			}
		}

		[Token(Token = "0x170001DB")]
		internal Light light
		{
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x2D59A9C", Offset = "0x2D55A9C", VA = "0x2D59A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DC")]
		public int additionalLightsShadowResolutionTier
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x2D59B2C", Offset = "0x2D55B2C", VA = "0x2D59B2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001DD")]
		[Obsolete("This is obsolete, please use renderingLayerMask instead.", false)]
		public LightLayerEnum lightLayerMask
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x2D59B34", Offset = "0x2D55B34", VA = "0x2D59B34")]
			get
			{
				return default(LightLayerEnum);
			}
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x2D59B3C", Offset = "0x2D55B3C", VA = "0x2D59B3C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public uint renderingLayers
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x2D59B44", Offset = "0x2D55B44", VA = "0x2D59B44")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x2D59B4C", Offset = "0x2D55B4C", VA = "0x2D59B4C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public bool customShadowLayers
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x2D59C0C", Offset = "0x2D55C0C", VA = "0x2D59C0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x2D59C14", Offset = "0x2D55C14", VA = "0x2D59C14")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		[Obsolete("This is obsolete, please use shadowRenderingLayerMask instead.", false)]
		public LightLayerEnum shadowLayerMask
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x2D59C30", Offset = "0x2D55C30", VA = "0x2D59C30")]
			get
			{
				return default(LightLayerEnum);
			}
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x2D59C38", Offset = "0x2D55C38", VA = "0x2D59C38")]
			set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public uint shadowRenderingLayers
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x2D59C40", Offset = "0x2D55C40", VA = "0x2D59C40")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x2D59C48", Offset = "0x2D55C48", VA = "0x2D59C48")]
			set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		[Tooltip("Controls the size of the cookie mask currently assigned to the light.")]
		public Vector2 lightCookieSize
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x2D59C60", Offset = "0x2D55C60", VA = "0x2D59C60")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x2D59C68", Offset = "0x2D55C68", VA = "0x2D59C68")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		[Tooltip("Controls the offset of the cookie mask currently assigned to the light.")]
		public Vector2 lightCookieOffset
		{
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x2D59C70", Offset = "0x2D55C70", VA = "0x2D59C70")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x2D59C78", Offset = "0x2D55C78", VA = "0x2D59C78")]
			set
			{
			}
		}

		[Token(Token = "0x170001E4")]
		[Tooltip("Controls the filtering quality of soft shadows. Higher quality has lower performance.")]
		public SoftShadowQuality softShadowQuality
		{
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x2D59C80", Offset = "0x2D55C80", VA = "0x2D59C80")]
			get
			{
				return default(SoftShadowQuality);
			}
			[Token(Token = "0x6000900")]
			[Address(RVA = "0x2D59C88", Offset = "0x2D55C88", VA = "0x2D59C88")]
			set
			{
			}
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x2D59C90", Offset = "0x2D55C90", VA = "0x2D59C90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x2D59C94", Offset = "0x2D55C94", VA = "0x2D59C94", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x2D59B64", Offset = "0x2D55B64", VA = "0x2D59B64")]
		private void SyncLightAndShadowLayers()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x2D59D60", Offset = "0x2D55D60", VA = "0x2D59D60")]
		public UniversalAdditionalLightData()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public enum RenderingMode
	{
		[Token(Token = "0x40008D1")]
		Forward = 0,
		[Token(Token = "0x40008D2")]
		[InspectorName("Forward+")]
		ForwardPlus = 2,
		[Token(Token = "0x40008D3")]
		Deferred = 1
	}
	[Token(Token = "0x200019C")]
	public enum DepthPrimingMode
	{
		[Token(Token = "0x40008D5")]
		Disabled,
		[Token(Token = "0x40008D6")]
		Auto,
		[Token(Token = "0x40008D7")]
		Forced
	}
	[Token(Token = "0x200019D")]
	public sealed class UniversalRenderer : ScriptableRenderer
	{
		[Token(Token = "0x200019E")]
		private static class Profiling
		{
			[Token(Token = "0x400091C")]
			private const string k_Name = "UniversalRenderer";

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ProfilingSampler createCameraRenderTarget;
		}

		[Token(Token = "0x200019F")]
		private struct RenderPassInputSummary
		{
			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool requiresDepthTexture;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			internal bool requiresDepthPrepass;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			internal bool requiresNormalsTexture;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			internal bool requiresColorTexture;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal bool requiresColorTextureCreated;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			internal bool requiresMotionVectors;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RenderPassEvent requiresDepthNormalAtEvent;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal RenderPassEvent requiresDepthTextureEarliestEvent;
		}

		[Token(Token = "0x20001A0")]
		internal class RenderGraphFrameResources
		{
			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle backBufferColor;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle cameraColor;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal TextureHandle cameraDepth;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal TextureHandle mainShadowsTexture;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal TextureHandle additionalShadowsTexture;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal TextureHandle[] gbuffer;

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal TextureHandle cameraOpaqueTexture;

			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal TextureHandle cameraDepthTexture;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal TextureHandle cameraNormalsTexture;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal TextureHandle motionVectorColor;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal TextureHandle motionVectorDepth;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal TextureHandle internalColorLut;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal TextureHandle overlayUITexture;

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x2D60280", Offset = "0x2D5C280", VA = "0x2D60280")]
			public RenderGraphFrameResources()
			{
			}
		}

		[Token(Token = "0x40008D8")]
		private const GraphicsFormat k_DepthStencilFormat = GraphicsFormat.D24_UNorm_S8_UInt;

		[Token(Token = "0x40008D9")]
		private const int k_DepthBufferBits = 24;

		[Token(Token = "0x40008DA")]
		private const int k_FinalBlitPassQueueOffset = 1;

		[Token(Token = "0x40008DB")]
		private const int k_AfterFinalBlitPassQueueOffset = 2;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<ShaderTagId> k_DepthNormalsOnly;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private bool m_Clustering;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private DepthOnlyPass m_DepthPrepass;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private DepthNormalOnlyPass m_DepthNormalPrepass;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private CopyDepthPass m_PrimedDepthCopyPass;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private MotionVectorRenderPass m_MotionVectorPass;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private MainLightShadowCasterPass m_MainLightShadowCasterPass;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private GBufferPass m_GBufferPass;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private CopyDepthPass m_GBufferCopyDepthPass;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private DeferredPass m_DeferredPass;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private DrawObjectsPass m_RenderOpaqueForwardOnlyPass;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private DrawObjectsPass m_RenderOpaqueForwardPass;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private DrawSkyboxPass m_DrawSkyboxPass;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private CopyDepthPass m_CopyDepthPass;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private CopyColorPass m_CopyColorPass;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private TransparentSettingsPass m_TransparentSettingsPass;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private DrawObjectsPass m_RenderTransparentForwardPass;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private FinalBlitPass m_FinalBlitPass;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private CapturePass m_CapturePass;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private XROcclusionMeshPass m_XROcclusionMeshPass;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private CopyDepthPass m_XRCopyDepthPass;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private DrawScreenSpaceUIPass m_DrawOffscreenUIPass;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private DrawScreenSpaceUIPass m_DrawOverlayUIPass;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		internal RenderTargetBufferSystem m_ColorBufferSystem;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		internal RTHandle m_ActiveCameraColorAttachment;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private RTHandle m_ColorFrontBuffer;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		internal RTHandle m_ActiveCameraDepthAttachment;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		internal RTHandle m_CameraDepthAttachment;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private RTHandle m_XRTargetHandleAlias;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		internal RTHandle m_CameraDepthAttachment_D3d_11;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		internal RTHandle m_DepthTexture;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private RTHandle m_NormalsTexture;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private RTHandle m_DecalLayersTexture;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private RTHandle m_OpaqueColor;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private RTHandle m_MotionVectorColor;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private RTHandle m_MotionVectorDepth;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private ForwardLights m_ForwardLights;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private DeferredLights m_DeferredLights;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private RenderingMode m_RenderingMode;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
		private DepthPrimingMode m_DepthPrimingMode;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private CopyDepthMode m_CopyDepthMode;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private bool m_DepthPrimingRecommended;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F5")]
		private StencilState m_DefaultStencilState;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private LightCookieManager m_LightCookieManager;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private IntermediateTextureMode m_IntermediateTextureMode;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
		private bool m_VulkanEnablePreTransform;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private Material m_BlitMaterial;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private Material m_BlitHDRMaterial;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private Material m_CopyDepthMaterial;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private Material m_SamplingMaterial;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private Material m_StencilDeferredMaterial;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private Material m_CameraMotionVecMaterial;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private Material m_ObjectMotionVecMaterial;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private PostProcessPasses m_PostProcessPasses;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RTHandle m_RenderGraphCameraColorHandle;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static RTHandle m_RenderGraphCameraDepthHandle;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static TextureHandle m_ActiveRenderGraphColor;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static TextureHandle m_ActiveRenderGraphDepth;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		internal bool m_TargetIsBackbuffer;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		internal RenderGraphFrameResources frameResources;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool m_UseIntermediateTexture;

		[Token(Token = "0x170001E5")]
		internal RenderingMode renderingModeRequested
		{
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x2D59ED0", Offset = "0x2D55ED0", VA = "0x2D59ED0")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x170001E6")]
		internal RenderingMode renderingModeActual
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x2D59ED8", Offset = "0x2D55ED8", VA = "0x2D59ED8")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x170001E7")]
		internal bool accurateGbufferNormals
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x2D59F48", Offset = "0x2D55F48", VA = "0x2D59F48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001E8")]
		public DepthPrimingMode depthPrimingMode
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x2D59F60", Offset = "0x2D55F60", VA = "0x2D59F60")]
			get
			{
				return default(DepthPrimingMode);
			}
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x2D59F68", Offset = "0x2D55F68", VA = "0x2D59F68")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		internal ColorGradingLutPass colorGradingLutPass
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x2D59F70", Offset = "0x2D55F70", VA = "0x2D59F70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EA")]
		internal PostProcessPass postProcessPass
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x2D59F78", Offset = "0x2D55F78", VA = "0x2D59F78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EB")]
		internal PostProcessPass finalPostProcessPass
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x2D59F80", Offset = "0x2D55F80", VA = "0x2D59F80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EC")]
		internal RTHandle colorGradingLut
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x2D59F88", Offset = "0x2D55F88", VA = "0x2D59F88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001ED")]
		internal DeferredLights deferredLights
		{
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x2D59F90", Offset = "0x2D55F90", VA = "0x2D59F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x2D59EAC", Offset = "0x2D55EAC", VA = "0x2D59EAC", Slot = "5")]
		public override int SupportedCameraStackingTypes()
		{
			return default(int);
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x2D59F98", Offset = "0x2D55F98", VA = "0x2D59F98")]
		public UniversalRenderer(UniversalRendererData data)
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x2D5AEDC", Offset = "0x2D56EDC", VA = "0x2D5AEDC", Slot = "8")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x2D5B0E4", Offset = "0x2D570E4", VA = "0x2D5B0E4", Slot = "9")]
		internal override void ReleaseRenderTargets()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x2D5B1DC", Offset = "0x2D571DC", VA = "0x2D5B1DC")]
		private void SetupFinalPassDebug(ref CameraData cameraData)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x2D5B4B4", Offset = "0x2D574B4", VA = "0x2D5B4B4")]
		public static bool IsOffscreenDepthTexture(in CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x2D5B540", Offset = "0x2D57540", VA = "0x2D5B540")]
		private bool IsDepthPrimingEnabled(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x2D5B6F8", Offset = "0x2D576F8", VA = "0x2D5B6F8")]
		private bool IsWebGL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x2D5B700", Offset = "0x2D57700", VA = "0x2D5B700")]
		private bool IsGLESDevice()
		{
			return default(bool);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x2D5B734", Offset = "0x2D57734", VA = "0x2D5B734")]
		private bool IsGLDevice()
		{
			return default(bool);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x2D5B778", Offset = "0x2D57778", VA = "0x2D5B778", Slot = "10")]
		public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x2D5E890", Offset = "0x2D5A890", VA = "0x2D5E890", Slot = "11")]
		public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x2D5E8F4", Offset = "0x2D5A8F4", VA = "0x2D5E8F4", Slot = "12")]
		public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x2D5EBC8", Offset = "0x2D5ABC8", VA = "0x2D5EBC8", Slot = "13")]
		public override void FinishRendering(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x2D5E728", Offset = "0x2D5A728", VA = "0x2D5E728")]
		private void EnqueueDeferred(ref RenderingData renderingData, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x2D5DD74", Offset = "0x2D59D74", VA = "0x2D5DD74")]
		private RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData)
		{
			return default(RenderPassInputSummary);
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x2D5E130", Offset = "0x2D5A130", VA = "0x2D5E130")]
		private void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, bool primedDepth, CommandBuffer cmd, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x2D5EBF4", Offset = "0x2D5ABF4", VA = "0x2D5EBF4")]
		private bool PlatformRequiresExplicitMsaaResolve()
		{
			return default(bool);
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x2D5DF78", Offset = "0x2D59F78", VA = "0x2D5DF78")]
		private bool RequiresIntermediateColorTexture(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x2D5B60C", Offset = "0x2D5760C", VA = "0x2D5B60C")]
		private bool CanCopyDepth(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x2D5EC68", Offset = "0x2D5AC68", VA = "0x2D5EC68", Slot = "16")]
		internal override void SwapColorBuffer(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x2D5EE10", Offset = "0x2D5AE10", VA = "0x2D5EE10", Slot = "6")]
		internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			return null;
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x2D5EE28", Offset = "0x2D5AE28", VA = "0x2D5EE28", Slot = "7")]
		internal override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x2D5EE40", Offset = "0x2D5AE40", VA = "0x2D5EE40", Slot = "17")]
		internal override void EnableSwapBufferMSAA(bool enable)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x2D5B04C", Offset = "0x2D5704C", VA = "0x2D5B04C")]
		private void CleanupRenderGraphResources()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x2D5EE5C", Offset = "0x2D5AE5C", VA = "0x2D5EE5C")]
		internal static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x2D5EF44", Offset = "0x2D5AF44", VA = "0x2D5EF44")]
		private bool RequiresColorAndDepthTextures(out bool createColorTexture, out bool createDepthTexture, ref RenderingData renderingData, RenderPassInputSummary renderPassInputs)
		{
			return default(bool);
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x2D5F1A8", Offset = "0x2D5B1A8", VA = "0x2D5F1A8")]
		private void CreateRenderGraphCameraRenderTargets(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x2D5F910", Offset = "0x2D5B910", VA = "0x2D5F910", Slot = "14")]
		internal override void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x2D60050", Offset = "0x2D5C050", VA = "0x2D60050", Slot = "15")]
		internal override void OnFinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x2D5F98C", Offset = "0x2D5B98C", VA = "0x2D5F98C")]
		private void OnBeforeRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x2D5FA60", Offset = "0x2D5BA60", VA = "0x2D5FA60")]
		private void OnMainRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x2D5FEFC", Offset = "0x2D5BEFC", VA = "0x2D5FEFC")]
		private void OnAfterRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public enum CopyDepthMode
	{
		[Token(Token = "0x4000937")]
		AfterOpaques,
		[Token(Token = "0x4000938")]
		AfterTransparents,
		[Token(Token = "0x4000939")]
		ForcePrepass
	}
	[Serializable]
	[Token(Token = "0x20001A3")]
	[ExcludeFromPreset]
	[ReloadGroup]
	public class UniversalRendererData : ScriptableRendererData, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x20001A4")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Reload("Shaders/Utils/Blit.shader", ReloadAttribute.Package.Root)]
			public Shader blitPS;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Reload("Shaders/Utils/CopyDepth.shader", ReloadAttribute.Package.Root)]
			public Shader copyDepthPS;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Obsolete("Obsolete, this feature will be supported by new 'ScreenSpaceShadows' renderer feature")]
			public Shader screenSpaceShadowPS;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Reload("Shaders/Utils/Sampling.shader", ReloadAttribute.Package.Root)]
			public Shader samplingPS;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Reload("Shaders/Utils/StencilDeferred.shader", ReloadAttribute.Package.Root)]
			public Shader stencilDeferredPS;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Reload("Shaders/Utils/FallbackError.shader", ReloadAttribute.Package.Root)]
			public Shader fallbackErrorPS;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Reload("Shaders/Utils/FallbackLoading.shader", ReloadAttribute.Package.Root)]
			public Shader fallbackLoadingPS;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Reload("Shaders/Utils/MaterialError.shader", ReloadAttribute.Package.Root)]
			[Obsolete("Use fallbackErrorPS instead")]
			public Shader materialErrorPS;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Reload("Shaders/Utils/CoreBlit.shader", ReloadAttribute.Package.Root)]
			[SerializeField]
			internal Shader coreBlitPS;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", ReloadAttribute.Package.Root)]
			[SerializeField]
			internal Shader coreBlitColorAndDepthPS;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Reload("Shaders/Utils/BlitHDROverlay.shader", ReloadAttribute.Package.Root)]
			[SerializeField]
			internal Shader blitHDROverlay;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Reload("Shaders/CameraMotionVectors.shader", ReloadAttribute.Package.Root)]
			public Shader cameraMotionVector;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Reload("Shaders/ObjectMotionVectors.shader", ReloadAttribute.Package.Root)]
			public Shader objectMotionVector;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Reload("Shaders/PostProcessing/LensFlareDataDriven.shader", ReloadAttribute.Package.Root)]
			public Shader dataDrivenLensFlare;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Reload("Shaders/Terrain/TerrainDetailLit.shader", ReloadAttribute.Package.Root)]
			public Shader terrainDetailLitPS;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Reload("Shaders/Terrain/WavingGrass.shader", ReloadAttribute.Package.Root)]
			public Shader terrainDetailGrassPS;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Reload("Shaders/Terrain/WavingGrassBillboard.shader", ReloadAttribute.Package.Root)]
			public Shader terrainDetailGrassBillboardPS;

			[Token(Token = "0x6000950")]
			[Address(RVA = "0x2D60648", Offset = "0x2D5C648", VA = "0x2D60648")]
			public ShaderResources()
			{
			}
		}

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PostProcessData postProcessData;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Reload("Runtime/Data/XRSystemData.asset", ReloadAttribute.Package.Root)]
		public XRSystemData xrSystemData;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ShaderResources shaders;

		[Token(Token = "0x400093D")]
		private const int k_LatestAssetVersion = 2;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int m_AssetVersion;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private LayerMask m_OpaqueLayerMask;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LayerMask m_TransparentLayerMask;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private StencilStateData m_DefaultStencilState;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool m_ShadowTransparentReceive;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private RenderingMode m_RenderingMode;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DepthPrimingMode m_DepthPrimingMode;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private CopyDepthMode m_CopyDepthMode;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool m_AccurateGbufferNormals;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private IntermediateTextureMode m_IntermediateTextureMode;

		[Token(Token = "0x170001EE")]
		public LayerMask opaqueLayerMask
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x2D603C4", Offset = "0x2D5C3C4", VA = "0x2D603C4")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x2D603CC", Offset = "0x2D5C3CC", VA = "0x2D603CC")]
			set
			{
			}
		}

		[Token(Token = "0x170001EF")]
		public LayerMask transparentLayerMask
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x2D603F4", Offset = "0x2D5C3F4", VA = "0x2D603F4")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x2D603FC", Offset = "0x2D5C3FC", VA = "0x2D603FC")]
			set
			{
			}
		}

		[Token(Token = "0x170001F0")]
		public StencilStateData defaultStencilState
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x2D60424", Offset = "0x2D5C424", VA = "0x2D60424")]
			get
			{
				return null;
			}
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x2D6042C", Offset = "0x2D5C42C", VA = "0x2D6042C")]
			set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		public bool shadowTransparentReceive
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x2D60454", Offset = "0x2D5C454", VA = "0x2D60454")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x2D6045C", Offset = "0x2D5C45C", VA = "0x2D6045C")]
			set
			{
			}
		}

		[Token(Token = "0x170001F2")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x2D60484", Offset = "0x2D5C484", VA = "0x2D60484")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x2D6048C", Offset = "0x2D5C48C", VA = "0x2D6048C")]
			set
			{
			}
		}

		[Token(Token = "0x170001F3")]
		public DepthPrimingMode depthPrimingMode
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x2D604B4", Offset = "0x2D5C4B4", VA = "0x2D604B4")]
			get
			{
				return default(DepthPrimingMode);
			}
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x2D604BC", Offset = "0x2D5C4BC", VA = "0x2D604BC")]
			set
			{
			}
		}

		[Token(Token = "0x170001F4")]
		public CopyDepthMode copyDepthMode
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x2D604E4", Offset = "0x2D5C4E4", VA = "0x2D604E4")]
			get
			{
				return default(CopyDepthMode);
			}
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x2D604EC", Offset = "0x2D5C4EC", VA = "0x2D604EC")]
			set
			{
			}
		}

		[Token(Token = "0x170001F5")]
		public bool accurateGbufferNormals
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x2D60514", Offset = "0x2D5C514", VA = "0x2D60514")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x2D6051C", Offset = "0x2D5C51C", VA = "0x2D6051C")]
			set
			{
			}
		}

		[Token(Token = "0x170001F6")]
		public IntermediateTextureMode intermediateTextureMode
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x2D60544", Offset = "0x2D5C544", VA = "0x2D60544")]
			get
			{
				return default(IntermediateTextureMode);
			}
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x2D6054C", Offset = "0x2D5C54C", VA = "0x2D6054C")]
			set
			{
			}
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x2D60338", Offset = "0x2D5C338", VA = "0x2D60338", Slot = "4")]
		protected override ScriptableRenderer Create()
		{
			return null;
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x2D60574", Offset = "0x2D5C574", VA = "0x2D60574", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x2D603C0", Offset = "0x2D5C3C0", VA = "0x2D603C0")]
		private void ReloadAllNullProperties()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x2D6057C", Offset = "0x2D5C57C", VA = "0x2D6057C", Slot = "7")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x2D60588", Offset = "0x2D5C588", VA = "0x2D60588", Slot = "8")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x2D605A4", Offset = "0x2D5C5A4", VA = "0x2D605A4")]
		public UniversalRendererData()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	internal class ClearTargetsPass
	{
		[Token(Token = "0x20001A6")]
		private class PassData
		{
			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle color;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle depth;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal RTClearFlags clearFlags;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal Color clearColor;

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x2D609BC", Offset = "0x2D5C9BC", VA = "0x2D609BC")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ProfilingSampler s_ClearProfilingSampler;

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x2D60650", Offset = "0x2D5C650", VA = "0x2D60650")]
		internal static void Render(RenderGraph graph, UniversalRenderer renderer, RTClearFlags clearFlags, Color clearColor)
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x2D60924", Offset = "0x2D5C924", VA = "0x2D60924")]
		public ClearTargetsPass()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	public sealed class UniversalRenderPipeline : RenderPipeline
	{
		[Token(Token = "0x20001A9")]
		internal static class Profiling
		{
			[Token(Token = "0x20001AA")]
			public static class Pipeline
			{
				[Token(Token = "0x20001AB")]
				public static class Renderer
				{
					[Token(Token = "0x4000984")]
					private const string k_Name = "ScriptableRenderer";

					[Token(Token = "0x4000985")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
					public static readonly ProfilingSampler setupCullingParameters;

					[Token(Token = "0x4000986")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
					public static readonly ProfilingSampler setup;
				}

				[Token(Token = "0x20001AC")]
				public static class Context
				{
					[Token(Token = "0x4000987")]
					private const string k_Name = "ScriptableRenderContext";

					[Token(Token = "0x4000988")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
					public static readonly ProfilingSampler submit;
				}

				[Token(Token = "0x4000975")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly ProfilingSampler beginContextRendering;

				[Token(Token = "0x4000976")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static readonly ProfilingSampler endContextRendering;

				[Token(Token = "0x4000977")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public static readonly ProfilingSampler beginCameraRendering;

				[Token(Token = "0x4000978")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public static readonly ProfilingSampler endCameraRendering;

				[Token(Token = "0x4000979")]
				private const string k_Name = "UniversalRenderPipeline";

				[Token(Token = "0x400097A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public static readonly ProfilingSampler initializeCameraData;

				[Token(Token = "0x400097B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public static readonly ProfilingSampler initializeStackedCameraData;

				[Token(Token = "0x400097C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public static readonly ProfilingSampler initializeAdditionalCameraData;

				[Token(Token = "0x400097D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public static readonly ProfilingSampler initializeRenderingData;

				[Token(Token = "0x400097E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public static readonly ProfilingSampler initializeShadowData;

				[Token(Token = "0x400097F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public static readonly ProfilingSampler initializeLightData;

				[Token(Token = "0x4000980")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public static readonly ProfilingSampler getPerObjectLightFlags;

				[Token(Token = "0x4000981")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public static readonly ProfilingSampler getMainLightIndex;

				[Token(Token = "0x4000982")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public static readonly ProfilingSampler setupPerFrameShaderConstants;

				[Token(Token = "0x4000983")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public static readonly ProfilingSampler setupPerCameraShaderConstants;
			}

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Dictionary<int, ProfilingSampler> s_HashSamplerCache;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly ProfilingSampler unknownSampler;

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x2D655E8", Offset = "0x2D615E8", VA = "0x2D655E8")]
			public static ProfilingSampler TryGetOrAddCameraSampler(Camera camera)
			{
				return null;
			}
		}

		[Token(Token = "0x20001AD")]
		public class SingleCameraRequest
		{
			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderTexture destination;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int mipLevel;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public CubemapFace face;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int slice;

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x2D69B48", Offset = "0x2D65B48", VA = "0x2D69B48")]
			public SingleCameraRequest()
			{
			}
		}

		[Token(Token = "0x4000960")]
		public const string k_ShaderTagName = "UniversalPipeline";

		[Token(Token = "0x4000961")]
		internal const int k_DefaultRenderingLayerMask = 1;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly DebugDisplaySettingsUI m_DebugDisplaySettingsUI;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UniversalRenderPipelineGlobalSettings m_GlobalSettings;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool cameraStackRequiresDepthForPostprocessing;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static RenderGraph s_RenderGraph;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static RTHandleResourcePool s_RTHandlePool;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool useRenderGraph;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly UniversalRenderPipelineAsset pipelineAsset;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal bool enableHDROnce;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static Vector4 k_DefaultLightPosition;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static Vector4 k_DefaultLightColor;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static Vector4 k_DefaultLightAttenuation;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private static Vector4 k_DefaultLightSpotDirection;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static Vector4 k_DefaultLightsProbeChannel;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static List<Vector4> m_ShadowBiasData;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static List<int> m_ShadowResolutionData;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Comparison<Camera> cameraComparison;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static Lightmapping.RequestLightsDelegate lightsDelegate;

		[Token(Token = "0x170001F7")]
		public static float maxShadowBias
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x2D60A64", Offset = "0x2D5CA64", VA = "0x2D60A64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001F8")]
		public static float minRenderScale
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x2D60A6C", Offset = "0x2D5CA6C", VA = "0x2D60A6C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001F9")]
		public static float maxRenderScale
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x2D60A78", Offset = "0x2D5CA78", VA = "0x2D60A78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001FA")]
		public static int maxNumIterationsEnclosingSphere
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x2D60A80", Offset = "0x2D5CA80", VA = "0x2D60A80")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FB")]
		public static int maxPerObjectLights
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x2D60A88", Offset = "0x2D5CA88", VA = "0x2D60A88")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FC")]
		public static int maxVisibleAdditionalLights
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x2D60AAC", Offset = "0x2D5CAAC", VA = "0x2D60AAC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FD")]
		internal static int lightsPerTile
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x2D60B70", Offset = "0x2D5CB70", VA = "0x2D60B70")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FE")]
		internal static int maxZBinWords
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x2D60BD4", Offset = "0x2D5CBD4", VA = "0x2D60BD4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FF")]
		internal static int maxTileWords
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x2D60BDC", Offset = "0x2D5CBDC", VA = "0x2D60BDC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000200")]
		internal static int maxVisibleReflectionProbes
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x2D60C3C", Offset = "0x2D5CC3C", VA = "0x2D60C3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000201")]
		public override RenderPipelineGlobalSettings defaultSettings
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x2D60CC4", Offset = "0x2D5CCC4", VA = "0x2D60CC4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000202")]
		public static UniversalRenderPipelineAsset asset
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x2D622D0", Offset = "0x2D5E2D0", VA = "0x2D622D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x2D60CCC", Offset = "0x2D5CCCC", VA = "0x2D60CCC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x2D60CE4", Offset = "0x2D5CCE4", VA = "0x2D60CE4")]
		public UniversalRenderPipeline(UniversalRenderPipelineAsset asset)
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x2D6136C", Offset = "0x2D5D36C", VA = "0x2D6136C", Slot = "8")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x2D61598", Offset = "0x2D5D598", VA = "0x2D61598")]
		private void DisposeAdditionalCameraData()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x2D61654", Offset = "0x2D5D654", VA = "0x2D61654", Slot = "4")]
		protected override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x2D616EC", Offset = "0x2D5D6EC", VA = "0x2D616EC", Slot = "7")]
		protected override void Render(ScriptableRenderContext renderContext, List<Camera> cameras)
		{
		}

		[Token(Token = "0x6000969")]
		protected override bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data)
		{
			return default(bool);
		}

		[Token(Token = "0x600096A")]
		protected override void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x2D63D84", Offset = "0x2D5FD84", VA = "0x2D63D84")]
		[Obsolete("RenderSingleCamera is obsolete, please use RenderPipeline.SubmitRenderRequest with UniversalRenderer.SingleCameraRequest as RequestData type", false)]
		public static void RenderSingleCamera(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x2D63CC0", Offset = "0x2D5FCC0", VA = "0x2D63CC0")]
		internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x2D63DE8", Offset = "0x2D5FDE8", VA = "0x2D63DE8")]
		internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, ref UniversalAdditionalCameraData additionalCameraData)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x2D6545C", Offset = "0x2D6145C", VA = "0x2D6545C")]
		private static bool TryGetCullingParameters(CameraData cameraData, out ScriptableCullingParameters cullingParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x2D64AC0", Offset = "0x2D60AC0", VA = "0x2D64AC0")]
		private static void RenderSingleCamera(ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x2D6249C", Offset = "0x2D5E49C", VA = "0x2D6249C")]
		private static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera)
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x2D664F4", Offset = "0x2D624F4", VA = "0x2D664F4")]
		private static void UpdateCameraData(ref CameraData baseCameraData, in XRPass xr)
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x2D639EC", Offset = "0x2D5F9EC", VA = "0x2D639EC")]
		private static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData)
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x2D66A8C", Offset = "0x2D62A8C", VA = "0x2D66A8C")]
		private static bool CheckPostProcessForDepth(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x2D662A4", Offset = "0x2D622A4", VA = "0x2D662A4")]
		private static bool CheckPostProcessForDepth()
		{
			return default(bool);
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x2D61300", Offset = "0x2D5D300", VA = "0x2D61300")]
		private static void SetSupportedRenderingFeatures(UniversalRenderPipelineAsset pipelineAsset)
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x2D63F44", Offset = "0x2D5FF44", VA = "0x2D63F44")]
		private static void InitializeCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, out CameraData cameraData)
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x2D66BF0", Offset = "0x2D62BF0", VA = "0x2D66BF0")]
		private static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x2D6437C", Offset = "0x2D6037C", VA = "0x2D6437C")]
		private static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x2D65BAC", Offset = "0x2D61BAC", VA = "0x2D65BAC")]
		private static void InitializeRenderingData(UniversalRenderPipelineAsset settings, ref CameraData cameraData, ref CullingResults cullResults, CommandBuffer cmd, out RenderingData renderingData)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x2D67D00", Offset = "0x2D63D00", VA = "0x2D67D00")]
		private static void InitializeShadowData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, bool mainLightCastShadows, bool additionalLightsCastShadows, bool isForwardPlus, out ShadowData shadowData)
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x2D685E4", Offset = "0x2D645E4", VA = "0x2D685E4")]
		private static void InitializePostProcessingData(UniversalRenderPipelineAsset settings, bool isHDROutputActive, out PostProcessingData postProcessingData)
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x2D67AA4", Offset = "0x2D63AA4", VA = "0x2D67AA4")]
		private static void InitializeLightData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, int mainLightIndex, out LightData lightData)
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x2D67694", Offset = "0x2D63694", VA = "0x2D67694")]
		private static void ApplyTaaRenderingDebugOverrides(ref TemporalAA.Settings taaSettings)
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x2D675EC", Offset = "0x2D635EC", VA = "0x2D675EC")]
		private static void UpdateTemporalAAData(ref CameraData cameraData, UniversalAdditionalCameraData additionalCameraData)
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x2D65B10", Offset = "0x2D61B10", VA = "0x2D65B10")]
		private static void UpdateTemporalAATargets(ref CameraData cameraData)
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x2D66370", Offset = "0x2D62370", VA = "0x2D66370")]
		private static void UpdateCameraStereoMatrices(Camera camera, XRPass xr)
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2D6861C", Offset = "0x2D6461C", VA = "0x2D6861C")]
		private static PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus)
		{
			return default(PerObjectData);
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x2D6783C", Offset = "0x2D6383C", VA = "0x2D6783C")]
		private static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights)
		{
			return default(int);
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x2D61F98", Offset = "0x2D5DF98", VA = "0x2D61F98")]
		private static void SetupPerFrameShaderConstants()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x2D65750", Offset = "0x2D61750", VA = "0x2D65750")]
		private static void SetupPerCameraShaderConstants(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x2D68768", Offset = "0x2D64768", VA = "0x2D68768")]
		private static void CheckAndApplyDebugSettings(ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x2D674BC", Offset = "0x2D634BC", VA = "0x2D674BC")]
		private static ImageUpscalingFilter ResolveUpscalingFilterSelection(Vector2 imageSize, float renderScale, UpscalingFilterSelection selection)
		{
			return default(ImageUpscalingFilter);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x2D66190", Offset = "0x2D62190", VA = "0x2D66190")]
		internal static bool HDROutputForMainDisplayIsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x2D61EF0", Offset = "0x2D5DEF0", VA = "0x2D61EF0")]
		internal static bool HDROutputForAnyDisplayIsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x2D61DB8", Offset = "0x2D5DDB8", VA = "0x2D61DB8")]
		private void SetHDRState(List<Camera> cameras)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x2D689F0", Offset = "0x2D649F0", VA = "0x2D689F0")]
		internal static void GetHDROutputLuminanceParameters(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Tonemapping tonemapping, out Vector4 hdrOutputParameters)
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x2D68AE0", Offset = "0x2D64AE0", VA = "0x2D68AE0")]
		internal static void GetHDROutputGradingParameters(Tonemapping tonemapping, out Vector4 hdrOutputParameters)
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x2D623C0", Offset = "0x2D5E3C0", VA = "0x2D623C0")]
		public static bool IsGameCamera(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x2D68BA8", Offset = "0x2D64BA8", VA = "0x2D68BA8")]
		[Obsolete("Please use CameraData.xr.enabled instead.", true)]
		public static bool IsStereoEnabled(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x2D62344", Offset = "0x2D5E344", VA = "0x2D62344")]
		private void SortCameras(List<Camera> cameras)
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x2D68914", Offset = "0x2D64914", VA = "0x2D68914")]
		internal static GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha)
		{
			return default(GraphicsFormat);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x2D68CA8", Offset = "0x2D64CA8", VA = "0x2D68CA8")]
		internal static GraphicsFormat MakeUnormRenderTextureGraphicsFormat()
		{
			return default(GraphicsFormat);
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x2D67238", Offset = "0x2D63238", VA = "0x2D67238")]
		internal static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, ref CameraData cameraData, bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture)
		{
			return default(RenderTextureDescriptor);
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x2D68DAC", Offset = "0x2D64DAC", VA = "0x2D68DAC")]
		public static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, float? innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir)
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x2D68EFC", Offset = "0x2D64EFC", VA = "0x2D68EFC")]
		internal static void GetPunctualLightDistanceAttenuation(float lightRange, ref Vector4 lightAttenuation)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x2D68F6C", Offset = "0x2D64F6C", VA = "0x2D68F6C")]
		internal static void GetSpotAngleAttenuation(float spotAngle, float? innerSpotAngle, ref Vector4 lightAttenuation)
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x2D68F38", Offset = "0x2D64F38", VA = "0x2D68F38")]
		internal static void GetSpotDirection(ref Matrix4x4 lightLocalToWorldMatrix, out Vector4 lightSpotDir)
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x2D69078", Offset = "0x2D65078", VA = "0x2D69078")]
		public static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel)
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x2D693C8", Offset = "0x2D653C8", VA = "0x2D693C8")]
		private static void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x2D66044", Offset = "0x2D62044", VA = "0x2D66044")]
		private static void RecordAndExecuteRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x20001AF")]
	internal static class NativeArrayExtensions
	{
		[Token(Token = "0x60009A5")]
		public unsafe static ref T UnsafeElementAt<T>(this NativeArray<T> array, int index) where T : struct
		{
			return ref *(T*)null;
		}

		[Token(Token = "0x60009A6")]
		public unsafe static ref T UnsafeElementAtMutable<T>(this NativeArray<T> array, int index) where T : struct
		{
			return ref *(T*)null;
		}
	}
	[Token(Token = "0x20001B0")]
	public enum MixedLightingSetup
	{
		[Token(Token = "0x4000990")]
		None,
		[Token(Token = "0x4000991")]
		ShadowMask,
		[Token(Token = "0x4000992")]
		Subtractive
	}
	[Token(Token = "0x20001B1")]
	internal enum ImageScalingMode
	{
		[Token(Token = "0x4000994")]
		None,
		[Token(Token = "0x4000995")]
		Upscaling,
		[Token(Token = "0x4000996")]
		Downscaling
	}
	[Token(Token = "0x20001B2")]
	internal enum ImageUpscalingFilter
	{
		[Token(Token = "0x4000998")]
		Linear,
		[Token(Token = "0x4000999")]
		Point,
		[Token(Token = "0x400099A")]
		FSR
	}
	[Token(Token = "0x20001B3")]
	public struct RenderingData
	{
		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal CommandBuffer commandBuffer;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CullingResults cullResults;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraData cameraData;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public LightData lightData;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public ShadowData shadowData;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public PostProcessingData postProcessingData;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		public bool supportsDynamicBatching;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public PerObjectData perObjectData;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		public bool postProcessingEnabled;
	}
	[Token(Token = "0x20001B4")]
	public struct LightData
	{
		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int mainLightIndex;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int additionalLightsCount;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxPerObjectAdditionalLightsCount;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NativeArray<VisibleLight> visibleLights;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool shadeAdditionalLightsPerVertex;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool supportsMixedLighting;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool reflectionProbeBoxProjection;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool reflectionProbeBlending;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool supportsLightLayers;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool supportsAdditionalLights;
	}
	[Token(Token = "0x20001B5")]
	public struct CameraData
	{
		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Matrix4x4 m_ViewMatrix;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Matrix4x4 m_ProjectionMatrix;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Matrix4x4 m_JitterMatrix;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Camera camera;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public CameraRenderType renderType;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public RenderTexture targetTexture;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public RenderTextureDescriptor cameraTargetDescriptor;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		internal Rect pixelRect;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		internal bool useScreenCoordOverride;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal Vector4 screenSizeOverride;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal Vector4 screenCoordScaleBias;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal int pixelWidth;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		internal int pixelHeight;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		internal float aspectRatio;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public float renderScale;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		internal ImageScalingMode imageScalingMode;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		internal ImageUpscalingFilter upscalingFilter;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal bool fsrOverrideSharpness;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		internal float fsrSharpness;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		internal HDRColorBufferPrecision hdrColorBufferPrecision;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public bool clearDepth;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public CameraType cameraType;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool isDefaultViewport;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool isHdrEnabled;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16E")]
		public bool allowHDROutput;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
		public bool requiresDepthTexture;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public bool requiresOpaqueTexture;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		public bool postProcessingRequiresDepthTexture;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x172")]
		public bool xrRendering;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x173")]
		internal bool stackLastCameraOutputToHDR;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public SortingCriteria defaultOpaqueSortFlags;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[Obsolete("Please use xr.enabled instead.", true)]
		public bool isStereoEnabled;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public float maxShadowDistance;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public bool postProcessEnabled;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
		internal bool stackAnyPostProcessingEnabled;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> captureActions;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public LayerMask volumeLayerMask;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public Transform volumeTrigger;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public bool isStopNaNEnabled;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A9")]
		public bool isDitheringEnabled;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public AntialiasingMode antialiasing;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public AntialiasingQuality antialiasingQuality;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public ScriptableRenderer renderer;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool resolveFinalTarget;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public Vector3 worldSpaceCameraPos;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public Color backgroundColor;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		internal TaaPersistentData taaPersistentData;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		internal TemporalAA.Settings taaSettings;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public Camera baseCamera;

		[Token(Token = "0x17000203")]
		public int scaledWidth
		{
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x2D68D14", Offset = "0x2D64D14", VA = "0x2D68D14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000204")]
		public int scaledHeight
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x2D68D60", Offset = "0x2D64D60", VA = "0x2D68D60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000205")]
		internal bool requireSrgbConversion
		{
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x2D6AA2C", Offset = "0x2D66A2C", VA = "0x2D6AA2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000206")]
		public bool isSceneViewCamera
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x2D655D8", Offset = "0x2D615D8", VA = "0x2D655D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000207")]
		public bool isPreviewCamera
		{
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x2D68904", Offset = "0x2D64904", VA = "0x2D68904")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000208")]
		internal bool isRenderPassSupportedCamera
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x2D6ABB4", Offset = "0x2D66BB4", VA = "0x2D6ABB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000209")]
		internal bool resolveToScreen
		{
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x2D6ABC8", Offset = "0x2D66BC8", VA = "0x2D6ABC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700020A")]
		public bool isHDROutputActive
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x2D67790", Offset = "0x2D63790", VA = "0x2D67790")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700020B")]
		public HDROutputUtils.HDRDisplayInformation hdrDisplayInformation
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x2D6AC70", Offset = "0x2D66C70", VA = "0x2D6AC70")]
			get
			{
				return default(HDROutputUtils.HDRDisplayInformation);
			}
		}

		[Token(Token = "0x1700020C")]
		public ColorGamut hdrDisplayColorGamut
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x2D6AD64", Offset = "0x2D66D64", VA = "0x2D6AD64")]
			get
			{
				return default(ColorGamut);
			}
		}

		[Token(Token = "0x1700020D")]
		public bool rendersOverlayUI
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x2D6ADF4", Offset = "0x2D66DF4", VA = "0x2D6ADF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700020E")]
		public XRPass xr
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x2D6B0A8", Offset = "0x2D670A8", VA = "0x2D6B0A8")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x2D6B0B0", Offset = "0x2D670B0", VA = "0x2D6B0B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		internal XRPassUniversal xrUniversal
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x2D66884", Offset = "0x2D62884", VA = "0x2D66884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000210")]
		internal bool resetHistory
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x2D6B0B8", Offset = "0x2D670B8", VA = "0x2D6B0B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x2D69EE8", Offset = "0x2D65EE8", VA = "0x2D69EE8")]
		internal void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix)
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x2D6775C", Offset = "0x2D6375C", VA = "0x2D6775C")]
		internal void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix)
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x2D69F60", Offset = "0x2D65F60", VA = "0x2D69F60")]
		internal void PushBuiltinShaderConstantsXR(CommandBuffer cmd, bool renderIntoTexture)
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x2D6A4E4", Offset = "0x2D664E4", VA = "0x2D6A4E4")]
		public Matrix4x4 GetViewMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x2D6A54C", Offset = "0x2D6654C", VA = "0x2D6A54C")]
		public Matrix4x4 GetProjectionMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x2D6A6A4", Offset = "0x2D666A4", VA = "0x2D6A6A4")]
		internal Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x2D6A70C", Offset = "0x2D6670C", VA = "0x2D6A70C")]
		public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x2D6A9E0", Offset = "0x2D669E0", VA = "0x2D6A9E0")]
		public Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x2D6A61C", Offset = "0x2D6661C", VA = "0x2D6A61C")]
		internal Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x2D6AE70", Offset = "0x2D66E70", VA = "0x2D6AE70")]
		public bool IsHandleYFlipped(RTHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x2D6A79C", Offset = "0x2D6679C", VA = "0x2D6A79C")]
		public bool IsCameraProjectionMatrixFlipped()
		{
			return default(bool);
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x2D6AFFC", Offset = "0x2D66FFC", VA = "0x2D6AFFC")]
		public bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, [Optional] RTHandle depth)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x2D66B1C", Offset = "0x2D62B1C", VA = "0x2D66B1C")]
		internal bool IsTemporalAAEnabled()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001B6")]
	public struct ShadowData
	{
		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool supportsMainLightShadows;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal bool mainLightShadowsEnabled;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[Obsolete("Obsolete, this feature was replaced by new 'ScreenSpaceShadows' renderer feature")]
		public bool requiresScreenSpaceShadowResolve;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int mainLightShadowmapWidth;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int mainLightShadowmapHeight;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int mainLightShadowCascadesCount;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 mainLightShadowCascadesSplit;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float mainLightShadowCascadeBorder;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool supportsAdditionalLightShadows;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		internal bool additionalLightShadowsEnabled;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int additionalLightsShadowmapWidth;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int additionalLightsShadowmapHeight;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool supportsSoftShadows;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int shadowmapDepthBufferBits;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Vector4> bias;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<int> resolution;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal bool isKeywordAdditionalLightShadowsEnabled;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		internal bool isKeywordSoftShadowsEnabled;
	}
	[Token(Token = "0x20001B7")]
	public struct PreTile
	{
		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float4 planeLeft;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float4 planeRight;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float4 planeBottom;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float4 planeTop;
	}
	[Token(Token = "0x20001B8")]
	public struct TileData
	{
		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint tileID;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint listBitMask;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint relLightOffset;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint unused;
	}
	[Token(Token = "0x20001B9")]
	public struct PunctualLightData
	{
		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 wsPos;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float radius;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector4 color;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector4 attenuation;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 spotDirection;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int flags;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector4 occlusionProbeInfo;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public uint layerMask;
	}
	[Token(Token = "0x20001BA")]
	internal static class ShaderPropertyId
	{
		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int glossyEnvironmentColor;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int subtractiveShadowColor;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int glossyEnvironmentCubeMap;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int glossyEnvironmentCubeMapHDR;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ambientSkyColor;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int ambientEquatorColor;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int ambientGroundColor;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int time;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int sinTime;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int cosTime;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int deltaTime;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int timeParameters;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int scaledScreenParams;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int worldSpaceCameraPos;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int screenParams;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int alphaToMaskAvailable;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int projectionParams;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int zBufferParams;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int orthoParams;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int globalMipBias;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int screenSize;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int screenCoordScaleBias;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int screenSizeOverride;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int viewMatrix;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int projectionMatrix;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int viewAndProjectionMatrix;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int inverseViewMatrix;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly int inverseProjectionMatrix;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly int inverseViewAndProjectionMatrix;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static readonly int cameraProjectionMatrix;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly int inverseCameraProjectionMatrix;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static readonly int worldToCameraMatrix;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly int cameraToWorldMatrix;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static readonly int shadowBias;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly int lightDirection;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static readonly int lightPosition;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static readonly int cameraWorldClipPlanes;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public static readonly int billboardNormal;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static readonly int billboardTangent;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public static readonly int billboardCameraParams;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static readonly int blitTexture;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public static readonly int blitScaleBias;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static readonly int sourceTex;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public static readonly int scaleBias;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static readonly int scaleBiasRt;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public static readonly int rendererColor;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static readonly int ditheringTexture;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public static readonly int ditheringTextureInvSize;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static readonly int renderingLayerMaxInt;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public static readonly int renderingLayerRcpMaxInt;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static readonly int overlayUITexture;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public static readonly int hdrOutputLuminanceParams;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static readonly int hdrOutputGradingParams;
	}
	[Token(Token = "0x20001BB")]
	public struct PostProcessingData
	{
		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ColorGradingMode gradingMode;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int lutSize;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool useFastSRGBLinearConversion;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public bool supportDataDrivenLensFlare;
	}
	[Token(Token = "0x20001BC")]
	public static class ShaderKeywordStrings
	{
		[Token(Token = "0x4000A3B")]
		public const string MainLightShadows = "_MAIN_LIGHT_SHADOWS";

		[Token(Token = "0x4000A3C")]
		public const string MainLightShadowCascades = "_MAIN_LIGHT_SHADOWS_CASCADE";

		[Token(Token = "0x4000A3D")]
		public const string MainLightShadowScreen = "_MAIN_LIGHT_SHADOWS_SCREEN";

		[Token(Token = "0x4000A3E")]
		public const string CastingPunctualLightShadow = "_CASTING_PUNCTUAL_LIGHT_SHADOW";

		[Token(Token = "0x4000A3F")]
		public const string AdditionalLightsVertex = "_ADDITIONAL_LIGHTS_VERTEX";

		[Token(Token = "0x4000A40")]
		public const string AdditionalLightsPixel = "_ADDITIONAL_LIGHTS";

		[Token(Token = "0x4000A41")]
		internal const string ForwardPlus = "_FORWARD_PLUS";

		[Token(Token = "0x4000A42")]
		public const string AdditionalLightShadows = "_ADDITIONAL_LIGHT_SHADOWS";

		[Token(Token = "0x4000A43")]
		public const string ReflectionProbeBoxProjection = "_REFLECTION_PROBE_BOX_PROJECTION";

		[Token(Token = "0x4000A44")]
		public const string ReflectionProbeBlending = "_REFLECTION_PROBE_BLENDING";

		[Token(Token = "0x4000A45")]
		public const string SoftShadows = "_SHADOWS_SOFT";

		[Token(Token = "0x4000A46")]
		public const string SoftShadowsLow = "_SHADOWS_SOFT_LOW";

		[Token(Token = "0x4000A47")]
		public const string SoftShadowsMedium = "_SHADOWS_SOFT_MEDIUM";

		[Token(Token = "0x4000A48")]
		public const string SoftShadowsHigh = "_SHADOWS_SOFT_HIGH";

		[Token(Token = "0x4000A49")]
		public const string MixedLightingSubtractive = "_MIXED_LIGHTING_SUBTRACTIVE";

		[Token(Token = "0x4000A4A")]
		public const string LightmapShadowMixing = "LIGHTMAP_SHADOW_MIXING";

		[Token(Token = "0x4000A4B")]
		public const string ShadowsShadowMask = "SHADOWS_SHADOWMASK";

		[Token(Token = "0x4000A4C")]
		public const string LightLayers = "_LIGHT_LAYERS";

		[Token(Token = "0x4000A4D")]
		public const string RenderPassEnabled = "_RENDER_PASS_ENABLED";

		[Token(Token = "0x4000A4E")]
		public const string BillboardFaceCameraPos = "BILLBOARD_FACE_CAMERA_POS";

		[Token(Token = "0x4000A4F")]
		public const string LightCookies = "_LIGHT_COOKIES";

		[Token(Token = "0x4000A50")]
		public const string DepthNoMsaa = "_DEPTH_NO_MSAA";

		[Token(Token = "0x4000A51")]
		public const string DepthMsaa2 = "_DEPTH_MSAA_2";

		[Token(Token = "0x4000A52")]
		public const string DepthMsaa4 = "_DEPTH_MSAA_4";

		[Token(Token = "0x4000A53")]
		public const string DepthMsaa8 = "_DEPTH_MSAA_8";

		[Token(Token = "0x4000A54")]
		public const string LinearToSRGBConversion = "_LINEAR_TO_SRGB_CONVERSION";

		[Token(Token = "0x4000A55")]
		internal const string UseFastSRGBLinearConversion = "_USE_FAST_SRGB_LINEAR_CONVERSION";

		[Token(Token = "0x4000A56")]
		public const string DBufferMRT1 = "_DBUFFER_MRT1";

		[Token(Token = "0x4000A57")]
		public const string DBufferMRT2 = "_DBUFFER_MRT2";

		[Token(Token = "0x4000A58")]
		public const string DBufferMRT3 = "_DBUFFER_MRT3";

		[Token(Token = "0x4000A59")]
		public const string DecalNormalBlendLow = "_DECAL_NORMAL_BLEND_LOW";

		[Token(Token = "0x4000A5A")]
		public const string DecalNormalBlendMedium = "_DECAL_NORMAL_BLEND_MEDIUM";

		[Token(Token = "0x4000A5B")]
		public const string DecalNormalBlendHigh = "_DECAL_NORMAL_BLEND_HIGH";

		[Token(Token = "0x4000A5C")]
		public const string DecalLayers = "_DECAL_LAYERS";

		[Token(Token = "0x4000A5D")]
		public const string WriteRenderingLayers = "_WRITE_RENDERING_LAYERS";

		[Token(Token = "0x4000A5E")]
		public const string SmaaLow = "_SMAA_PRESET_LOW";

		[Token(Token = "0x4000A5F")]
		public const string SmaaMedium = "_SMAA_PRESET_MEDIUM";

		[Token(Token = "0x4000A60")]
		public const string SmaaHigh = "_SMAA_PRESET_HIGH";

		[Token(Token = "0x4000A61")]
		public const string PaniniGeneric = "_GENERIC";

		[Token(Token = "0x4000A62")]
		public const string PaniniUnitDistance = "_UNIT_DISTANCE";

		[Token(Token = "0x4000A63")]
		public const string BloomLQ = "_BLOOM_LQ";

		[Token(Token = "0x4000A64")]
		public const string BloomHQ = "_BLOOM_HQ";

		[Token(Token = "0x4000A65")]
		public const string BloomLQDirt = "_BLOOM_LQ_DIRT";

		[Token(Token = "0x4000A66")]
		public const string BloomHQDirt = "_BLOOM_HQ_DIRT";

		[Token(Token = "0x4000A67")]
		public const string UseRGBM = "_USE_RGBM";

		[Token(Token = "0x4000A68")]
		public const string Distortion = "_DISTORTION";

		[Token(Token = "0x4000A69")]
		public const string ChromaticAberration = "_CHROMATIC_ABERRATION";

		[Token(Token = "0x4000A6A")]
		public const string HDRGrading = "_HDR_GRADING";

		[Token(Token = "0x4000A6B")]
		public const string TonemapACES = "_TONEMAP_ACES";

		[Token(Token = "0x4000A6C")]
		public const string TonemapNeutral = "_TONEMAP_NEUTRAL";

		[Token(Token = "0x4000A6D")]
		public const string FilmGrain = "_FILM_GRAIN";

		[Token(Token = "0x4000A6E")]
		public const string Fxaa = "_FXAA";

		[Token(Token = "0x4000A6F")]
		public const string Dithering = "_DITHERING";

		[Token(Token = "0x4000A70")]
		public const string ScreenSpaceOcclusion = "_SCREEN_SPACE_OCCLUSION";

		[Token(Token = "0x4000A71")]
		public const string PointSampling = "_POINT_SAMPLING";

		[Token(Token = "0x4000A72")]
		public const string Rcas = "_RCAS";

		[Token(Token = "0x4000A73")]
		public const string EasuRcasAndHDRInput = "_EASU_RCAS_AND_HDR_INPUT";

		[Token(Token = "0x4000A74")]
		public const string Gamma20 = "_GAMMA_20";

		[Token(Token = "0x4000A75")]
		public const string FxaaAndGamma20 = "_FXAA_AND_GAMMA_20";

		[Token(Token = "0x4000A76")]
		public const string HighQualitySampling = "_HIGH_QUALITY_SAMPLING";

		[Token(Token = "0x4000A77")]
		public const string _SPOT = "_SPOT";

		[Token(Token = "0x4000A78")]
		public const string _DIRECTIONAL = "_DIRECTIONAL";

		[Token(Token = "0x4000A79")]
		public const string _POINT = "_POINT";

		[Token(Token = "0x4000A7A")]
		public const string _DEFERRED_STENCIL = "_DEFERRED_STENCIL";

		[Token(Token = "0x4000A7B")]
		public const string _DEFERRED_FIRST_LIGHT = "_DEFERRED_FIRST_LIGHT";

		[Token(Token = "0x4000A7C")]
		public const string _DEFERRED_MAIN_LIGHT = "_DEFERRED_MAIN_LIGHT";

		[Token(Token = "0x4000A7D")]
		public const string _GBUFFER_NORMALS_OCT = "_GBUFFER_NORMALS_OCT";

		[Token(Token = "0x4000A7E")]
		public const string _DEFERRED_MIXED_LIGHTING = "_DEFERRED_MIXED_LIGHTING";

		[Token(Token = "0x4000A7F")]
		public const string LIGHTMAP_ON = "LIGHTMAP_ON";

		[Token(Token = "0x4000A80")]
		public const string DYNAMICLIGHTMAP_ON = "DYNAMICLIGHTMAP_ON";

		[Token(Token = "0x4000A81")]
		public const string _ALPHATEST_ON = "_ALPHATEST_ON";

		[Token(Token = "0x4000A82")]
		public const string DIRLIGHTMAP_COMBINED = "DIRLIGHTMAP_COMBINED";

		[Token(Token = "0x4000A83")]
		public const string _DETAIL_MULX2 = "_DETAIL_MULX2";

		[Token(Token = "0x4000A84")]
		public const string _DETAIL_SCALED = "_DETAIL_SCALED";

		[Token(Token = "0x4000A85")]
		public const string _CLEARCOAT = "_CLEARCOAT";

		[Token(Token = "0x4000A86")]
		public const string _CLEARCOATMAP = "_CLEARCOATMAP";

		[Token(Token = "0x4000A87")]
		public const string DEBUG_DISPLAY = "DEBUG_DISPLAY";

		[Token(Token = "0x4000A88")]
		public const string LOD_FADE_CROSSFADE = "LOD_FADE_CROSSFADE";

		[Token(Token = "0x4000A89")]
		public const string USE_UNITY_CROSSFADE = "USE_UNITY_CROSSFADE";

		[Token(Token = "0x4000A8A")]
		public const string _EMISSION = "_EMISSION";

		[Token(Token = "0x4000A8B")]
		public const string _RECEIVE_SHADOWS_OFF = "_RECEIVE_SHADOWS_OFF";

		[Token(Token = "0x4000A8C")]
		public const string _SURFACE_TYPE_TRANSPARENT = "_SURFACE_TYPE_TRANSPARENT";

		[Token(Token = "0x4000A8D")]
		public const string _ALPHAPREMULTIPLY_ON = "_ALPHAPREMULTIPLY_ON";

		[Token(Token = "0x4000A8E")]
		public const string _ALPHAMODULATE_ON = "_ALPHAMODULATE_ON";

		[Token(Token = "0x4000A8F")]
		public const string _NORMALMAP = "_NORMALMAP";

		[Token(Token = "0x4000A90")]
		public const string EDITOR_VISUALIZATION = "EDITOR_VISUALIZATION";

		[Token(Token = "0x4000A91")]
		public const string DisableTexture2DXArray = "DISABLE_TEXTURE2D_X_ARRAY";

		[Token(Token = "0x4000A92")]
		public const string BlitSingleSlice = "BLIT_SINGLE_SLICE";

		[Token(Token = "0x4000A93")]
		public const string XROcclusionMeshCombined = "XR_OCCLUSION_MESH_COMBINED";

		[Token(Token = "0x4000A94")]
		public const string SCREEN_COORD_OVERRIDE = "SCREEN_COORD_OVERRIDE";

		[Token(Token = "0x4000A95")]
		public const string DOWNSAMPLING_SIZE_2 = "DOWNSAMPLING_SIZE_2";

		[Token(Token = "0x4000A96")]
		public const string DOWNSAMPLING_SIZE_4 = "DOWNSAMPLING_SIZE_4";

		[Token(Token = "0x4000A97")]
		public const string DOWNSAMPLING_SIZE_8 = "DOWNSAMPLING_SIZE_8";

		[Token(Token = "0x4000A98")]
		public const string DOWNSAMPLING_SIZE_16 = "DOWNSAMPLING_SIZE_16";

		[Token(Token = "0x4000A99")]
		public const string FoveatedRenderingNonUniformRaster = "_FOVEATED_RENDERING_NON_UNIFORM_RASTER";

		[Token(Token = "0x4000A9A")]
		public const string EVALUATE_SH_MIXED = "EVALUATE_SH_MIXED";

		[Token(Token = "0x4000A9B")]
		public const string EVALUATE_SH_VERTEX = "EVALUATE_SH_VERTEX";

		[Token(Token = "0x4000A9C")]
		public const string UseDrawProcedural = "_USE_DRAW_PROCEDURAL";
	}
	[Token(Token = "0x20001BD")]
	internal enum URPProfileId
	{
		[Token(Token = "0x4000A9E")]
		UniversalRenderTotal,
		[Token(Token = "0x4000A9F")]
		UpdateVolumeFramework,
		[Token(Token = "0x4000AA0")]
		RenderCameraStack,
		[Token(Token = "0x4000AA1")]
		AdditionalLightsShadow,
		[Token(Token = "0x4000AA2")]
		ColorGradingLUT,
		[Token(Token = "0x4000AA3")]
		CopyColor,
		[Token(Token = "0x4000AA4")]
		CopyDepth,
		[Token(Token = "0x4000AA5")]
		DepthNormalPrepass,
		[Token(Token = "0x4000AA6")]
		DepthPrepass,
		[Token(Token = "0x4000AA7")]
		UpdateReflectionProbeAtlas,
		[Token(Token = "0x4000AA8")]
		DrawOpaqueObjects,
		[Token(Token = "0x4000AA9")]
		DrawTransparentObjects,
		[Token(Token = "0x4000AAA")]
		DrawScreenSpaceUI,
		[Token(Token = "0x4000AAB")]
		LightCookies,
		[Token(Token = "0x4000AAC")]
		MainLightShadow,
		[Token(Token = "0x4000AAD")]
		ResolveShadows,
		[Token(Token = "0x4000AAE")]
		SSAO,
		[Token(Token = "0x4000AAF")]
		StopNaNs,
		[Token(Token = "0x4000AB0")]
		SMAA,
		[Token(Token = "0x4000AB1")]
		GaussianDepthOfField,
		[Token(Token = "0x4000AB2")]
		BokehDepthOfField,
		[Token(Token = "0x4000AB3")]
		TemporalAA,
		[Token(Token = "0x4000AB4")]
		MotionBlur,
		[Token(Token = "0x4000AB5")]
		PaniniProjection,
		[Token(Token = "0x4000AB6")]
		UberPostProcess,
		[Token(Token = "0x4000AB7")]
		Bloom,
		[Token(Token = "0x4000AB8")]
		LensFlareDataDrivenComputeOcclusion,
		[Token(Token = "0x4000AB9")]
		LensFlareDataDriven,
		[Token(Token = "0x4000ABA")]
		MotionVectors,
		[Token(Token = "0x4000ABB")]
		DrawFullscreen,
		[Token(Token = "0x4000ABC")]
		FinalBlit
	}
	[Token(Token = "0x20001BE")]
	internal static class PlatformAutoDetect
	{
		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<XRDisplaySubsystem> displaySubsystemList;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		internal static bool isRunningOnPowerVRGPU;

		[Token(Token = "0x17000211")]
		internal static bool isXRMobile
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x2D6BDDC", Offset = "0x2D67DDC", VA = "0x2D6BDDC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x2D6BE34", Offset = "0x2D67E34", VA = "0x2D6BE34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000212")]
		internal static bool isShaderAPIMobileDefined
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x2D6BE94", Offset = "0x2D67E94", VA = "0x2D6BE94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x2D6BEEC", Offset = "0x2D67EEC", VA = "0x2D6BEEC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000213")]
		internal static bool isSwitch
		{
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x2D6BF4C", Offset = "0x2D67F4C", VA = "0x2D6BF4C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x2D6BFA4", Offset = "0x2D67FA4", VA = "0x2D6BFA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x2D6BB10", Offset = "0x2D67B10", VA = "0x2D6BB10")]
		internal static void Initialize()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x2D6BC6C", Offset = "0x2D67C6C", VA = "0x2D6BC6C")]
		private static bool IsRunningXRMobile()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x2D6C004", Offset = "0x2D68004", VA = "0x2D6C004")]
		internal static ShEvalMode ShAutoDetect(ShEvalMode mode)
		{
			return default(ShEvalMode);
		}
	}
	[Token(Token = "0x20001BF")]
	internal class UniversalRenderPipelineGlobalSettings : RenderPipelineGlobalSettings, ISerializationCallbackReceiver, IShaderVariantSettings
	{
		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int k_AssetVersion;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UniversalRenderPipelineGlobalSettings cachedInstance;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string defaultAssetName;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] m_RenderingLayerNames;

		[NonSerialized]
		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] m_PrefixedRenderingLayerNames;

		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private uint m_ValidRenderingLayers;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
		public string lightLayerName0;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
		public string lightLayerName1;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
		public string lightLayerName2;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
		public string lightLayerName3;

		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
		public string lightLayerName4;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
		public string lightLayerName5;

		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
		public string lightLayerName6;

		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Obsolete("This is obsolete, please use renderingLayerNames instead.", false)]
		public string lightLayerName7;

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool m_StripDebugVariants;

		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[SerializeField]
		private bool m_StripUnusedPostProcessingVariants;

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		[SerializeField]
		private bool m_StripUnusedVariants;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		[SerializeField]
		private bool m_StripUnusedLODCrossFadeVariants;

		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private bool m_StripScreenCoordOverrideVariants;

		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[Obsolete("Please use stripRuntimeDebugShaders instead.", false)]
		public bool supportRuntimeDebugDisplay;

		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		internal UnityEngine.Rendering.ShaderVariantLogLevel m_ShaderVariantLogLevel;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		internal bool m_ExportShaderVariants;

		[Token(Token = "0x17000214")]
		public static UniversalRenderPipelineGlobalSettings instance
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x2D611D4", Offset = "0x2D5D1D4", VA = "0x2D611D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000215")]
		private string[] renderingLayerNames
		{
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x2D6C48C", Offset = "0x2D6848C", VA = "0x2D6C48C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000216")]
		private string[] prefixedRenderingLayerNames
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x2D6C4B0", Offset = "0x2D684B0", VA = "0x2D6C4B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000217")]
		public string[] renderingLayerMaskNames
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x2D6C4D4", Offset = "0x2D684D4", VA = "0x2D6C4D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000218")]
		public string[] prefixedRenderingLayerMaskNames
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x2D6C4F8", Offset = "0x2D684F8", VA = "0x2D6C4F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000219")]
		public uint validRenderingLayers
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x2D6C51C", Offset = "0x2D6851C", VA = "0x2D6C51C")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700021A")]
		[Obsolete("This is obsolete, please use prefixedRenderingLayerMaskNames instead.", false)]
		public string[] prefixedLightLayerNames
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x2D6C540", Offset = "0x2D68540", VA = "0x2D6C540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021B")]
		[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
		public string[] lightLayerNames
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x2D6C584", Offset = "0x2D68584", VA = "0x2D6C584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021C")]
		public bool stripDebugVariants
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x2D6C648", Offset = "0x2D68648", VA = "0x2D6C648")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x2D6C650", Offset = "0x2D68650", VA = "0x2D6C650")]
			set
			{
			}
		}

		[Token(Token = "0x1700021D")]
		public bool stripUnusedPostProcessingVariants
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x2D6C658", Offset = "0x2D68658", VA = "0x2D6C658")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x2D6C660", Offset = "0x2D68660", VA = "0x2D6C660")]
			set
			{
			}
		}

		[Token(Token = "0x1700021E")]
		public bool stripUnusedVariants
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x2D6C668", Offset = "0x2D68668", VA = "0x2D6C668")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x2D6C670", Offset = "0x2D68670", VA = "0x2D6C670")]
			set
			{
			}
		}

		[Token(Token = "0x1700021F")]
		[Obsolete("No longer used as Shader Prefiltering automatically strips out unused LOD Crossfade variants. Please use the LOD Crossfade setting in the URP Asset to disable the feature if not used.", false)]
		public bool stripUnusedLODCrossFadeVariants
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x2D6C678", Offset = "0x2D68678", VA = "0x2D6C678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x2D6C680", Offset = "0x2D68680", VA = "0x2D6C680")]
			set
			{
			}
		}

		[Token(Token = "0x17000220")]
		public bool stripScreenCoordOverrideVariants
		{
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x2D6C688", Offset = "0x2D68688", VA = "0x2D6C688")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x2D6C690", Offset = "0x2D68690", VA = "0x2D6C690")]
			set
			{
			}
		}

		[Token(Token = "0x17000221")]
		public UnityEngine.Rendering.ShaderVariantLogLevel shaderVariantLogLevel
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x2D6C698", Offset = "0x2D68698", VA = "0x2D6C698", Slot = "6")]
			get
			{
				return default(UnityEngine.Rendering.ShaderVariantLogLevel);
			}
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x2D6C6A0", Offset = "0x2D686A0", VA = "0x2D6C6A0", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000222")]
		public bool exportShaderVariants
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x2D6C6A8", Offset = "0x2D686A8", VA = "0x2D6C6A8", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x2D6C6B0", Offset = "0x2D686B0", VA = "0x2D6C6B0", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x2D6C220", Offset = "0x2D68220", VA = "0x2D6C220", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x2D6C224", Offset = "0x2D68224", VA = "0x2D6C224", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x2D6C228", Offset = "0x2D68228", VA = "0x2D6C228")]
		internal static void UpdateGraphicsSettings(UniversalRenderPipelineGlobalSettings newSettings)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x2D6C348", Offset = "0x2D68348", VA = "0x2D6C348")]
		private void Reset()
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x2D6C34C", Offset = "0x2D6834C", VA = "0x2D6C34C")]
		internal void UpdateRenderingLayerNames()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x2D6C5C8", Offset = "0x2D685C8", VA = "0x2D6C5C8")]
		internal void ResetRenderingLayerNames()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x2D6C6BC", Offset = "0x2D686BC", VA = "0x2D6C6BC")]
		public UniversalRenderPipelineGlobalSettings()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	internal class XRPassUniversal : XRPass
	{
		[Token(Token = "0x17000223")]
		internal bool isLateLatchEnabled
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x2D6C920", Offset = "0x2D68920", VA = "0x2D6C920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x2D6C928", Offset = "0x2D68928", VA = "0x2D6C928")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000224")]
		internal bool canMarkLateLatch
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x2D6C930", Offset = "0x2D68930", VA = "0x2D6C930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x2D6C938", Offset = "0x2D68938", VA = "0x2D6C938")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000225")]
		internal bool hasMarkedLateLatch
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x2D6C940", Offset = "0x2D68940", VA = "0x2D6C940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x2D6C948", Offset = "0x2D68948", VA = "0x2D6C948")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x2D6C7D0", Offset = "0x2D687D0", VA = "0x2D6C7D0")]
		public static XRPass Create(XRPassCreateInfo createInfo)
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x2D6C8B4", Offset = "0x2D688B4", VA = "0x2D6C8B4", Slot = "4")]
		public override void Release()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x2D6C950", Offset = "0x2D68950", VA = "0x2D6C950")]
		public XRPassUniversal()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	internal static class XRSystemUniversal
	{
		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Matrix4x4[] s_projMatrix;

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x2D66900", Offset = "0x2D62900", VA = "0x2D66900")]
		internal static void BeginLateLatching(Camera camera, XRPassUniversal xrPass)
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x2D669D0", Offset = "0x2D629D0", VA = "0x2D669D0")]
		internal static void EndLateLatching(Camera camera, XRPassUniversal xrPass)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x2D6C958", Offset = "0x2D68958", VA = "0x2D6C958")]
		internal static void UnmarkShaderProperties(CommandBuffer cmd, XRPassUniversal xrPass)
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x2D6C9D4", Offset = "0x2D689D4", VA = "0x2D6C9D4")]
		internal static void MarkShaderProperties(CommandBuffer cmd, XRPassUniversal xrPass, bool renderIntoTexture)
		{
		}
	}
}
namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	[Token(Token = "0x20001C2")]
	internal class Dict<TValue> where TValue : class
	{
		[Token(Token = "0x20001C3")]
		public class Node
		{
			[Token(Token = "0x4000ADE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x4000ADF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _prev;

			[Token(Token = "0x4000AE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _next;

			[Token(Token = "0x17000226")]
			public TValue Key
			{
				[Token(Token = "0x6000A00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000227")]
			public Node Prev
			{
				[Token(Token = "0x6000A01")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000228")]
			public Node Next
			{
				[Token(Token = "0x6000A02")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A03")]
			public Node()
			{
			}
		}

		[Token(Token = "0x20001C4")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Node _head;

		[Token(Token = "0x60009FA")]
		public Dict(LessOrEqual leq)
		{
		}

		[Token(Token = "0x60009FB")]
		public Node Insert(TValue key)
		{
			return null;
		}

		[Token(Token = "0x60009FC")]
		public Node InsertBefore(Node node, TValue key)
		{
			return null;
		}

		[Token(Token = "0x60009FD")]
		public Node Find(TValue key)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		public Node Min()
		{
			return null;
		}

		[Token(Token = "0x60009FF")]
		public void Remove(Node node)
		{
		}
	}
	[Token(Token = "0x20001C5")]
	internal static class Geom
	{
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x2D6CC18", Offset = "0x2D68C18", VA = "0x2D6CC18")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x2D6CCC8", Offset = "0x2D68CC8", VA = "0x2D6CCC8")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x2D6CD18", Offset = "0x2D68D18", VA = "0x2D6CD18")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x2D6CD58", Offset = "0x2D68D58", VA = "0x2D6CD58")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x2D6CDA4", Offset = "0x2D68DA4", VA = "0x2D6CDA4")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x2D6CE14", Offset = "0x2D68E14", VA = "0x2D6CE14")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x2D6CE74", Offset = "0x2D68E74", VA = "0x2D6CE74")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x2D6CEC0", Offset = "0x2D68EC0", VA = "0x2D6CEC0")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x2D6CF30", Offset = "0x2D68F30", VA = "0x2D6CF30")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x2D6CF90", Offset = "0x2D68F90", VA = "0x2D6CF90")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x2D6CFD0", Offset = "0x2D68FD0", VA = "0x2D6CFD0")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x2D6CFF4", Offset = "0x2D68FF4", VA = "0x2D6CFF4")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x2D6D078", Offset = "0x2D69078", VA = "0x2D6D078")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x2D6D0C0", Offset = "0x2D690C0", VA = "0x2D6D0C0")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x2D6D118", Offset = "0x2D69118", VA = "0x2D6D118")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x2D6D12C", Offset = "0x2D6912C", VA = "0x2D6D12C")]
		public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
		}
	}
	[Token(Token = "0x20001C6")]
	internal class Mesh : MeshUtils.Pooled<Mesh>
	{
		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MeshUtils.Vertex _vHead;

		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal MeshUtils.Face _fHead;

		[Token(Token = "0x4000AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal MeshUtils.Edge _eHead;

		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal MeshUtils.Edge _eHeadSym;

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x2D6D4B8", Offset = "0x2D694B8", VA = "0x2D6D4B8")]
		public Mesh()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x2D6D610", Offset = "0x2D69610", VA = "0x2D6D610", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x2D6D61C", Offset = "0x2D6961C", VA = "0x2D6D61C", Slot = "5")]
		public override void OnFree()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x2D6D724", Offset = "0x2D69724", VA = "0x2D6D724")]
		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x2D6D924", Offset = "0x2D69924", VA = "0x2D6D924")]
		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x2D6DB40", Offset = "0x2D69B40", VA = "0x2D6DB40")]
		public void Delete(MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x2D6DD04", Offset = "0x2D69D04", VA = "0x2D6DD04")]
		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x2D6DD6C", Offset = "0x2D69D6C", VA = "0x2D6DD6C")]
		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x2D6DE34", Offset = "0x2D69E34", VA = "0x2D6DE34")]
		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x2D6DEFC", Offset = "0x2D69EFC", VA = "0x2D6DEFC")]
		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x2D6E018", Offset = "0x2D6A018", VA = "0x2D6E018")]
		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x2D6E1D0", Offset = "0x2D6A1D0", VA = "0x2D6E1D0")]
		[Conditional("DEBUG")]
		public void Check()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	internal struct Vec3
	{
		[Token(Token = "0x4000AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vec3 Zero;

		[Token(Token = "0x4000AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float X;

		[Token(Token = "0x4000AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Y;

		[Token(Token = "0x4000AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Z;

		[Token(Token = "0x17000229")]
		public float this[int index]
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x2D6E268", Offset = "0x2D6A268", VA = "0x2D6E268")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x2D6E2C8", Offset = "0x2D6A2C8", VA = "0x2D6E2C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x2D6E328", Offset = "0x2D6A328", VA = "0x2D6E328")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x2D6E34C", Offset = "0x2D6A34C", VA = "0x2D6E34C")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x2D6E368", Offset = "0x2D6A368", VA = "0x2D6E368")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x2D6E394", Offset = "0x2D6A394", VA = "0x2D6E394")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x2D6E430", Offset = "0x2D6A430", VA = "0x2D6E430")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x2D6E508", Offset = "0x2D6A508", VA = "0x2D6E508", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20001C8")]
	internal static class MeshUtils
	{
		[Token(Token = "0x20001C9")]
		public abstract class Pooled<T> where T : Pooled<T>, new()
		{
			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Stack<T> _stack;

			[Token(Token = "0x6000A35")]
			public abstract void Reset();

			[Token(Token = "0x6000A36")]
			public virtual void OnFree()
			{
			}

			[Token(Token = "0x6000A37")]
			public static T Create()
			{
				return null;
			}

			[Token(Token = "0x6000A38")]
			public void Free()
			{
			}

			[Token(Token = "0x6000A39")]
			protected Pooled()
			{
			}
		}

		[Token(Token = "0x20001CA")]
		public class Vertex : Pooled<Vertex>
		{
			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vertex _prev;

			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vertex _next;

			[Token(Token = "0x4000AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000AEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vec3 _coords;

			[Token(Token = "0x4000AEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float _s;

			[Token(Token = "0x4000AF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float _t;

			[Token(Token = "0x4000AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal PQHandle _pqHandle;

			[Token(Token = "0x4000AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _n;

			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal object _data;

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x2D6E65C", Offset = "0x2D6A65C", VA = "0x2D6E65C", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x2D6E6D8", Offset = "0x2D6A6D8", VA = "0x2D6E6D8")]
			public Vertex()
			{
			}
		}

		[Token(Token = "0x20001CB")]
		public class Face : Pooled<Face>
		{
			[Token(Token = "0x4000AF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Face _prev;

			[Token(Token = "0x4000AF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Face _next;

			[Token(Token = "0x4000AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Face _trail;

			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int _n;

			[Token(Token = "0x4000AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool _marked;

			[Token(Token = "0x4000AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			internal bool _inside;

			[Token(Token = "0x1700022A")]
			internal int VertsCount
			{
				[Token(Token = "0x6000A3C")]
				[Address(RVA = "0x2D6E184", Offset = "0x2D6A184", VA = "0x2D6E184")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x2D6E720", Offset = "0x2D6A720", VA = "0x2D6E720", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x2D6E730", Offset = "0x2D6A730", VA = "0x2D6E730")]
			public Face()
			{
			}
		}

		[Token(Token = "0x20001CC")]
		public struct EdgePair
		{
			[Token(Token = "0x4000AFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Edge _e;

			[Token(Token = "0x4000AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Edge _eSym;

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x2D6D5A0", Offset = "0x2D695A0", VA = "0x2D6D5A0")]
			public static EdgePair Create()
			{
				return default(EdgePair);
			}

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x2D6E778", Offset = "0x2D6A778", VA = "0x2D6E778")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x20001CD")]
		public class Edge : Pooled<Edge>
		{
			[Token(Token = "0x4000AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal EdgePair _pair;

			[Token(Token = "0x4000AFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _next;

			[Token(Token = "0x4000AFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Edge _Sym;

			[Token(Token = "0x4000B00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Edge _Onext;

			[Token(Token = "0x4000B01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Edge _Lnext;

			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Vertex _Org;

			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Face _Lface;

			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Tess.ActiveRegion _activeRegion;

			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int _winding;

			[Token(Token = "0x1700022B")]
			internal Face _Rface
			{
				[Token(Token = "0x6000A41")]
				[Address(RVA = "0x2D6DC40", Offset = "0x2D69C40", VA = "0x2D6DC40")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A42")]
				[Address(RVA = "0x2D6DE1C", Offset = "0x2D69E1C", VA = "0x2D6DE1C")]
				set
				{
				}
			}

			[Token(Token = "0x1700022C")]
			internal Vertex _Dst
			{
				[Token(Token = "0x6000A43")]
				[Address(RVA = "0x2D6CFB8", Offset = "0x2D68FB8", VA = "0x2D6CFB8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A44")]
				[Address(RVA = "0x2D6DE04", Offset = "0x2D69E04", VA = "0x2D6DE04")]
				set
				{
				}
			}

			[Token(Token = "0x1700022D")]
			internal Edge _Oprev
			{
				[Token(Token = "0x6000A45")]
				[Address(RVA = "0x2D6DC58", Offset = "0x2D69C58", VA = "0x2D6DC58")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A46")]
				[Address(RVA = "0x2D6E780", Offset = "0x2D6A780", VA = "0x2D6E780")]
				set
				{
				}
			}

			[Token(Token = "0x1700022E")]
			internal Edge _Lprev
			{
				[Token(Token = "0x6000A47")]
				[Address(RVA = "0x2D6E1B8", Offset = "0x2D6A1B8", VA = "0x2D6E1B8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A48")]
				[Address(RVA = "0x2D6E798", Offset = "0x2D6A798", VA = "0x2D6E798")]
				set
				{
				}
			}

			[Token(Token = "0x1700022F")]
			internal Edge _Dprev
			{
				[Token(Token = "0x6000A49")]
				[Address(RVA = "0x2D6E7B0", Offset = "0x2D6A7B0", VA = "0x2D6E7B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A4A")]
				[Address(RVA = "0x2D6E7C8", Offset = "0x2D6A7C8", VA = "0x2D6E7C8")]
				set
				{
				}
			}

			[Token(Token = "0x17000230")]
			internal Edge _Rprev
			{
				[Token(Token = "0x6000A4B")]
				[Address(RVA = "0x2D6E7E0", Offset = "0x2D6A7E0", VA = "0x2D6E7E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0x2D6E7F8", Offset = "0x2D6A7F8", VA = "0x2D6E7F8")]
				set
				{
				}
			}

			[Token(Token = "0x17000231")]
			internal Edge _Dnext
			{
				[Token(Token = "0x6000A4D")]
				[Address(RVA = "0x2D6E810", Offset = "0x2D6A810", VA = "0x2D6E810")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A4E")]
				[Address(RVA = "0x2D6E834", Offset = "0x2D6A834", VA = "0x2D6E834")]
				set
				{
				}
			}

			[Token(Token = "0x17000232")]
			internal Edge _Rnext
			{
				[Token(Token = "0x6000A4F")]
				[Address(RVA = "0x2D6E858", Offset = "0x2D6A858", VA = "0x2D6E858")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A50")]
				[Address(RVA = "0x2D6E87C", Offset = "0x2D6A87C", VA = "0x2D6E87C")]
				set
				{
				}
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x2D6E5D0", Offset = "0x2D6A5D0", VA = "0x2D6E5D0")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x2D6E8A0", Offset = "0x2D6A8A0", VA = "0x2D6E8A0", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x2D6E8B4", Offset = "0x2D6A8B4", VA = "0x2D6E8B4")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x4000AE9")]
		public const int Undef = -1;

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x2D6D774", Offset = "0x2D69774", VA = "0x2D6D774")]
		public static Edge MakeEdge(Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x2D6DAF8", Offset = "0x2D69AF8", VA = "0x2D6DAF8")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x2D6D7F4", Offset = "0x2D697F4", VA = "0x2D6D7F4")]
		public static void MakeVertex(Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x2D6D884", Offset = "0x2D69884", VA = "0x2D6D884")]
		public static void MakeFace(Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x2D6DC70", Offset = "0x2D69C70", VA = "0x2D6DC70")]
		public static void KillEdge(Edge eDel)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x2D6D9E8", Offset = "0x2D699E8", VA = "0x2D6D9E8")]
		public static void KillVertex(Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x2D6DA70", Offset = "0x2D69A70", VA = "0x2D6DA70")]
		public static void KillFace(Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x2D6E5FC", Offset = "0x2D6A5FC", VA = "0x2D6E5FC")]
		public static float FaceArea(Face f)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20001CE")]
	internal struct PQHandle
	{
		[Token(Token = "0x4000B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int Invalid;

		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int _handle;
	}
	[Token(Token = "0x20001CF")]
	internal class PriorityHeap<TValue> where TValue : class
	{
		[Token(Token = "0x20001D0")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x20001D1")]
		protected class HandleElem
		{
			[Token(Token = "0x4000B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x4000B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _node;

			[Token(Token = "0x6000A62")]
			public HandleElem()
			{
			}
		}

		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _nodes;

		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HandleElem[] _handles;

		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x4000B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _freeList;

		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x17000233")]
		public bool Empty
		{
			[Token(Token = "0x6000A55")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A56")]
		public PriorityHeap(int initialSize, LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000A57")]
		private void FloatDown(int curr)
		{
		}

		[Token(Token = "0x6000A58")]
		private void FloatUp(int curr)
		{
		}

		[Token(Token = "0x6000A59")]
		public void Init()
		{
		}

		[Token(Token = "0x6000A5A")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x6000A5B")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x6000A5C")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x6000A5D")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x20001D2")]
	internal class PriorityQueue<TValue> where TValue : class
	{
		[Token(Token = "0x20001D3")]
		private class StackItem
		{
			[Token(Token = "0x4000B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int p;

			[Token(Token = "0x4000B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int r;

			[Token(Token = "0x6000A6B")]
			public StackItem()
			{
			}
		}

		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue>.LessOrEqual _leq;

		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue> _heap;

		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TValue[] _keys;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _order;

		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x17000234")]
		public bool Empty
		{
			[Token(Token = "0x6000A63")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A64")]
		public PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000A65")]
		private static void Swap(ref int a, ref int b)
		{
		}

		[Token(Token = "0x6000A66")]
		public void Init()
		{
		}

		[Token(Token = "0x6000A67")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x6000A68")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x6000A69")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x6000A6A")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x20001D4")]
	internal class Tess
	{
		[Token(Token = "0x20001D5")]
		internal class ActiveRegion
		{
			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MeshUtils.Edge _eUp;

			[Token(Token = "0x4000B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Dict<ActiveRegion>.Node _nodeUp;

			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _windingNumber;

			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool _inside;

			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool _sentinel;

			[Token(Token = "0x4000B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool _dirty;

			[Token(Token = "0x4000B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			internal bool _fixUpperEdge;

			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x2D7239C", Offset = "0x2D6E39C", VA = "0x2D7239C")]
			public ActiveRegion()
			{
			}
		}

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Mesh _mesh;

		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vec3 _normal;

		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vec3 _sUnit;

		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vec3 _tUnit;

		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _bminX;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _bminY;

		[Token(Token = "0x4000B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _bmaxX;

		[Token(Token = "0x4000B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _bmaxY;

		[Token(Token = "0x4000B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private WindingRule _windingRule;

		[Token(Token = "0x4000B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dict<ActiveRegion> _dict;

		[Token(Token = "0x4000B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PriorityQueue<MeshUtils.Vertex> _pq;

		[Token(Token = "0x4000B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshUtils.Vertex _event;

		[Token(Token = "0x4000B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CombineCallback _combineCallback;

		[Token(Token = "0x4000B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ContourVertex[] _vertices;

		[Token(Token = "0x4000B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _vertexCount;

		[Token(Token = "0x4000B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] _elements;

		[Token(Token = "0x4000B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _elementCount;

		[Token(Token = "0x4000B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float SUnitX;

		[Token(Token = "0x4000B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float SUnitY;

		[Token(Token = "0x4000B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float SentinelCoord;

		[Token(Token = "0x4000B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool NoEmptyPolygons;

		[Token(Token = "0x4000B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool UsePooling;

		[Token(Token = "0x17000235")]
		public Vec3 Normal
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x2D70B44", Offset = "0x2D6CB44", VA = "0x2D70B44")]
			get
			{
				return default(Vec3);
			}
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x2D70B50", Offset = "0x2D6CB50", VA = "0x2D70B50")]
			set
			{
			}
		}

		[Token(Token = "0x17000236")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x2D70B5C", Offset = "0x2D6CB5C", VA = "0x2D70B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000237")]
		public int VertexCount
		{
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x2D70B64", Offset = "0x2D6CB64", VA = "0x2D70B64")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000238")]
		public int[] Elements
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x2D70B6C", Offset = "0x2D6CB6C", VA = "0x2D70B6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000239")]
		public int ElementCount
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x2D70B74", Offset = "0x2D6CB74", VA = "0x2D70B74")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x2D6E948", Offset = "0x2D6A948", VA = "0x2D6E948")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x2D6E970", Offset = "0x2D6A970", VA = "0x2D6E970")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x2D6E998", Offset = "0x2D6A998", VA = "0x2D6E998")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x2D6EAA8", Offset = "0x2D6AAA8", VA = "0x2D6EAA8")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x2D6EB10", Offset = "0x2D6AB10", VA = "0x2D6EB10")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x2D6EB54", Offset = "0x2D6AB54", VA = "0x2D6EB54")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x2D6EC04", Offset = "0x2D6AC04", VA = "0x2D6EC04")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x2D6EC58", Offset = "0x2D6AC58", VA = "0x2D6EC58")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x2D6ED10", Offset = "0x2D6AD10", VA = "0x2D6ED10")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x2D6ED64", Offset = "0x2D6AD64", VA = "0x2D6ED64")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x2D6ED94", Offset = "0x2D6AD94", VA = "0x2D6ED94")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x2D6EEB0", Offset = "0x2D6AEB0", VA = "0x2D6EEB0")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x2D6F418", Offset = "0x2D6B418", VA = "0x2D6F418")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x2D6F42C", Offset = "0x2D6B42C", VA = "0x2D6F42C")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x2D6F51C", Offset = "0x2D6B51C", VA = "0x2D6F51C")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x2D6F068", Offset = "0x2D6B068", VA = "0x2D6F068")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x2D6F794", Offset = "0x2D6B794", VA = "0x2D6F794")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x2D6F8F8", Offset = "0x2D6B8F8", VA = "0x2D6F8F8")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x2D6F1F4", Offset = "0x2D6B1F4", VA = "0x2D6F1F4")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x2D6FE8C", Offset = "0x2D6BE8C", VA = "0x2D6FE8C")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x2D7007C", Offset = "0x2D6C07C", VA = "0x2D7007C")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x2D7022C", Offset = "0x2D6C22C", VA = "0x2D7022C")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x2D70170", Offset = "0x2D6C170", VA = "0x2D70170")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x2D70448", Offset = "0x2D6C448", VA = "0x2D70448")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x2D70534", Offset = "0x2D6C534", VA = "0x2D70534")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x2D7061C", Offset = "0x2D6C61C", VA = "0x2D7061C")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x2D7069C", Offset = "0x2D6C69C", VA = "0x2D7069C")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x2D707C0", Offset = "0x2D6C7C0", VA = "0x2D707C0")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x2D709A8", Offset = "0x2D6C9A8", VA = "0x2D709A8")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x2D709B0", Offset = "0x2D6C9B0", VA = "0x2D709B0")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x2D70A3C", Offset = "0x2D6CA3C", VA = "0x2D70A3C")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x2D70B7C", Offset = "0x2D6CB7C", VA = "0x2D70B7C")]
		public Tess()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x2D70C20", Offset = "0x2D6CC20", VA = "0x2D70C20")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x2D7123C", Offset = "0x2D6D23C", VA = "0x2D7123C")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x2D71334", Offset = "0x2D6D334", VA = "0x2D71334")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x2D71634", Offset = "0x2D6D634", VA = "0x2D71634")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x2D71810", Offset = "0x2D6D810", VA = "0x2D71810")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x2D71870", Offset = "0x2D6D870", VA = "0x2D71870")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x2D718CC", Offset = "0x2D6D8CC", VA = "0x2D718CC")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x2D71978", Offset = "0x2D6D978", VA = "0x2D71978")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x2D719B0", Offset = "0x2D6D9B0", VA = "0x2D719B0")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x2D71DA8", Offset = "0x2D6DDA8", VA = "0x2D71DA8")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x2D71FA0", Offset = "0x2D6DFA0", VA = "0x2D71FA0")]
		private float SignedArea(ContourVertex[] vertices)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x2D72034", Offset = "0x2D6E034", VA = "0x2D72034")]
		public void AddContour(ContourVertex[] vertices)
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x2D7203C", Offset = "0x2D6E03C", VA = "0x2D7203C")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x2D721F0", Offset = "0x2D6E1F0", VA = "0x2D721F0")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x2D721F8", Offset = "0x2D6E1F8", VA = "0x2D721F8")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback)
		{
		}
	}
	[Token(Token = "0x20001D6")]
	internal enum WindingRule
	{
		[Token(Token = "0x4000B38")]
		EvenOdd,
		[Token(Token = "0x4000B39")]
		NonZero,
		[Token(Token = "0x4000B3A")]
		Positive,
		[Token(Token = "0x4000B3B")]
		Negative,
		[Token(Token = "0x4000B3C")]
		AbsGeqTwo
	}
	[Token(Token = "0x20001D7")]
	internal enum ElementType
	{
		[Token(Token = "0x4000B3E")]
		Polygons,
		[Token(Token = "0x4000B3F")]
		ConnectedPolygons,
		[Token(Token = "0x4000B40")]
		BoundaryContours
	}
	[Token(Token = "0x20001D8")]
	internal enum ContourOrientation
	{
		[Token(Token = "0x4000B42")]
		Original,
		[Token(Token = "0x4000B43")]
		Clockwise,
		[Token(Token = "0x4000B44")]
		CounterClockwise
	}
	[Token(Token = "0x20001D9")]
	internal struct ContourVertex
	{
		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vec3 Position;

		[Token(Token = "0x4000B46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object Data;

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x2D723A4", Offset = "0x2D6E3A4", VA = "0x2D723A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20001DA")]
	internal delegate object CombineCallback(Vec3 position, object[] data, float[] weights);
}
namespace UnityEngine.Rendering.Universal.Internal
{
	[Token(Token = "0x20001DB")]
	internal static class DeferredConfig
	{
		[Token(Token = "0x1700023A")]
		internal static bool IsOpenGL
		{
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x2D72584", Offset = "0x2D6E584", VA = "0x2D72584")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x2D725CC", Offset = "0x2D6E5CC", VA = "0x2D725CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700023B")]
		internal static bool IsDX10
		{
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x2D7261C", Offset = "0x2D6E61C", VA = "0x2D7261C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x2D72664", Offset = "0x2D6E664", VA = "0x2D72664")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Token(Token = "0x20001DC")]
	internal enum LightFlag
	{
		[Token(Token = "0x4000B4A")]
		SubtractiveMixedLighting = 4
	}
	[Token(Token = "0x20001DD")]
	internal class DeferredLights
	{
		[Token(Token = "0x20001DE")]
		internal static class ShaderConstants
		{
			[Token(Token = "0x4000B7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int _LitStencilRef;

			[Token(Token = "0x4000B7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int _LitStencilReadMask;

			[Token(Token = "0x4000B7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int _LitStencilWriteMask;

			[Token(Token = "0x4000B7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int _SimpleLitStencilRef;

			[Token(Token = "0x4000B7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int _SimpleLitStencilReadMask;

			[Token(Token = "0x4000B7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly int _SimpleLitStencilWriteMask;

			[Token(Token = "0x4000B80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly int _StencilRef;

			[Token(Token = "0x4000B81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly int _StencilReadMask;

			[Token(Token = "0x4000B82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly int _StencilWriteMask;

			[Token(Token = "0x4000B83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static readonly int _LitPunctualStencilRef;

			[Token(Token = "0x4000B84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static readonly int _LitPunctualStencilReadMask;

			[Token(Token = "0x4000B85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public static readonly int _LitPunctualStencilWriteMask;

			[Token(Token = "0x4000B86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static readonly int _SimpleLitPunctualStencilRef;

			[Token(Token = "0x4000B87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public static readonly int _SimpleLitPunctualStencilReadMask;

			[Token(Token = "0x4000B88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static readonly int _SimpleLitPunctualStencilWriteMask;

			[Token(Token = "0x4000B89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public static readonly int _LitDirStencilRef;

			[Token(Token = "0x4000B8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static readonly int _LitDirStencilReadMask;

			[Token(Token = "0x4000B8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public static readonly int _LitDirStencilWriteMask;

			[Token(Token = "0x4000B8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static readonly int _SimpleLitDirStencilRef;

			[Token(Token = "0x4000B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public static readonly int _SimpleLitDirStencilReadMask;

			[Token(Token = "0x4000B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static readonly int _SimpleLitDirStencilWriteMask;

			[Token(Token = "0x4000B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public static readonly int _ClearStencilRef;

			[Token(Token = "0x4000B90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static readonly int _ClearStencilReadMask;

			[Token(Token = "0x4000B91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public static readonly int _ClearStencilWriteMask;

			[Token(Token = "0x4000B92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static readonly int _ScreenToWorld;

			[Token(Token = "0x4000B93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public static int _MainLightPosition;

			[Token(Token = "0x4000B94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static int _MainLightColor;

			[Token(Token = "0x4000B95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public static int _MainLightLayerMask;

			[Token(Token = "0x4000B96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static int _SpotLightScale;

			[Token(Token = "0x4000B97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public static int _SpotLightBias;

			[Token(Token = "0x4000B98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static int _SpotLightGuard;

			[Token(Token = "0x4000B99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public static int _LightPosWS;

			[Token(Token = "0x4000B9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static int _LightColor;

			[Token(Token = "0x4000B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public static int _LightAttenuation;

			[Token(Token = "0x4000B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static int _LightOcclusionProbInfo;

			[Token(Token = "0x4000B9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public static int _LightDirection;

			[Token(Token = "0x4000B9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static int _LightFlags;

			[Token(Token = "0x4000B9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public static int _ShadowLightIndex;

			[Token(Token = "0x4000BA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static int _LightLayerMask;

			[Token(Token = "0x4000BA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public static int _CookieLightIndex;
		}

		[Token(Token = "0x20001DF")]
		internal enum StencilDeferredPasses
		{
			[Token(Token = "0x4000BA3")]
			StencilVolume,
			[Token(Token = "0x4000BA4")]
			PunctualLit,
			[Token(Token = "0x4000BA5")]
			PunctualSimpleLit,
			[Token(Token = "0x4000BA6")]
			DirectionalLit,
			[Token(Token = "0x4000BA7")]
			DirectionalSimpleLit,
			[Token(Token = "0x4000BA8")]
			ClearStencilPartial,
			[Token(Token = "0x4000BA9")]
			Fog,
			[Token(Token = "0x4000BAA")]
			SSAOOnly
		}

		[Token(Token = "0x20001E0")]
		internal struct InitParams
		{
			[Token(Token = "0x4000BAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Material stencilDeferredMaterial;

			[Token(Token = "0x4000BAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public LightCookieManager lightCookieManager;
		}

		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly string[] k_GBufferNames;

		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string[] k_StencilDeferredPassNames;

		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly ushort k_InvalidLightOffset;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string k_SetupLights;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string k_DeferredPass;

		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly string k_DeferredStencilPass;

		[Token(Token = "0x4000B51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly string k_DeferredFogPass;

		[Token(Token = "0x4000B52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly string k_ClearStencilPartial;

		[Token(Token = "0x4000B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly string k_SetupLightConstants;

		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly float kStencilShapeGuard;

		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly ProfilingSampler m_ProfilingSetupLights;

		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly ProfilingSampler m_ProfilingDeferredPass;

		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly ProfilingSampler m_ProfilingSetupLightConstants;

		[Token(Token = "0x4000B65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RTHandle[] GbufferRTHandles;

		[Token(Token = "0x4000B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private NativeArray<ushort> m_stencilVisLights;

		[Token(Token = "0x4000B6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private NativeArray<ushort> m_stencilVisLightOffsets;

		[Token(Token = "0x4000B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

		[Token(Token = "0x4000B70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Mesh m_SphereMesh;

		[Token(Token = "0x4000B71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Mesh m_HemisphereMesh;

		[Token(Token = "0x4000B72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Mesh m_FullscreenMesh;

		[Token(Token = "0x4000B73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material m_StencilDeferredMaterial;

		[Token(Token = "0x4000B74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int[] m_StencilDeferredPasses;

		[Token(Token = "0x4000B75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Matrix4x4[] m_ScreenToWorld;

		[Token(Token = "0x4000B76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ProfilingSampler m_ProfilingSamplerDeferredStencilPass;

		[Token(Token = "0x4000B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ProfilingSampler m_ProfilingSamplerDeferredFogPass;

		[Token(Token = "0x4000B78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ProfilingSampler m_ProfilingSamplerClearStencilPartialPass;

		[Token(Token = "0x4000B79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private LightCookieManager m_LightCookieManager;

		[Token(Token = "0x1700023C")]
		internal int GBufferAlbedoIndex
		{
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x2D726B4", Offset = "0x2D6E6B4", VA = "0x2D726B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700023D")]
		internal int GBufferSpecularMetallicIndex
		{
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x2D726BC", Offset = "0x2D6E6BC", VA = "0x2D726BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700023E")]
		internal int GBufferNormalSmoothnessIndex
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x2D726C4", Offset = "0x2D6E6C4", VA = "0x2D726C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700023F")]
		internal int GBufferLightingIndex
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x2D726CC", Offset = "0x2D6E6CC", VA = "0x2D726CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000240")]
		internal int GbufferDepthIndex
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x2D726D4", Offset = "0x2D6E6D4", VA = "0x2D726D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000241")]
		internal int GBufferRenderingLayers
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x2D726E8", Offset = "0x2D6E6E8", VA = "0x2D726E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000242")]
		internal int GBufferShadowMask
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x2D7273C", Offset = "0x2D6E73C", VA = "0x2D7273C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000243")]
		internal int GBufferSliceCount
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x2D72794", Offset = "0x2D6E794", VA = "0x2D72794")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000244")]
		internal bool UseShadowMask
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x2D72784", Offset = "0x2D6E784", VA = "0x2D72784")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000245")]
		internal bool UseRenderingLayers
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x2D72718", Offset = "0x2D6E718", VA = "0x2D72718")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000246")]
		internal RenderingLayerUtils.MaskSize RenderingLayerMaskSize
		{
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x2D72968", Offset = "0x2D6E968", VA = "0x2D72968")]
			[CompilerGenerated]
			get
			{
				return default(RenderingLayerUtils.MaskSize);
			}
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x2D72970", Offset = "0x2D6E970", VA = "0x2D72970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000247")]
		internal bool UseDecalLayers
		{
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x2D72978", Offset = "0x2D6E978", VA = "0x2D72978")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x2D72980", Offset = "0x2D6E980", VA = "0x2D72980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000248")]
		internal bool UseLightLayers
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x2D72908", Offset = "0x2D6E908", VA = "0x2D72908")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000249")]
		internal bool UseRenderPass
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x2D72988", Offset = "0x2D6E988", VA = "0x2D72988")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x2D72990", Offset = "0x2D6E990", VA = "0x2D72990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700024A")]
		internal bool HasDepthPrepass
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x2D72998", Offset = "0x2D6E998", VA = "0x2D72998")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x2D729A0", Offset = "0x2D6E9A0", VA = "0x2D729A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700024B")]
		internal bool HasNormalPrepass
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x2D729A8", Offset = "0x2D6E9A8", VA = "0x2D729A8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x2D729B0", Offset = "0x2D6E9B0", VA = "0x2D729B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700024C")]
		internal bool HasRenderingLayerPrepass
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x2D729B8", Offset = "0x2D6E9B8", VA = "0x2D729B8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x2D729C0", Offset = "0x2D6E9C0", VA = "0x2D729C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700024D")]
		internal bool IsOverlay
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x2D729C8", Offset = "0x2D6E9C8", VA = "0x2D729C8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x2D729D0", Offset = "0x2D6E9D0", VA = "0x2D729D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700024E")]
		internal bool AccurateGbufferNormals
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x2D729D8", Offset = "0x2D6E9D8", VA = "0x2D729D8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x2D729E0", Offset = "0x2D6E9E0", VA = "0x2D729E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700024F")]
		internal MixedLightingSetup MixedLightingSetup
		{
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x2D729E8", Offset = "0x2D6E9E8", VA = "0x2D729E8")]
			[CompilerGenerated]
			get
			{
				return default(MixedLightingSetup);
			}
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x2D729F0", Offset = "0x2D6E9F0", VA = "0x2D729F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000250")]
		internal bool UseJobSystem
		{
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x2D729F8", Offset = "0x2D6E9F8", VA = "0x2D729F8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x2D72A00", Offset = "0x2D6EA00", VA = "0x2D72A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000251")]
		internal int RenderWidth
		{
			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x2D72A08", Offset = "0x2D6EA08", VA = "0x2D72A08")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x2D72A10", Offset = "0x2D6EA10", VA = "0x2D72A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000252")]
		internal int RenderHeight
		{
			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x2D72A18", Offset = "0x2D6EA18", VA = "0x2D72A18")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x2D72A20", Offset = "0x2D6EA20", VA = "0x2D72A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000253")]
		internal RTHandle[] GbufferAttachments
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x2D72A28", Offset = "0x2D6EA28", VA = "0x2D72A28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x2D72A30", Offset = "0x2D6EA30", VA = "0x2D72A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000254")]
		internal TextureHandle[] GbufferTextureHandles
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x2D72A38", Offset = "0x2D6EA38", VA = "0x2D72A38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x2D72A40", Offset = "0x2D6EA40", VA = "0x2D72A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000255")]
		internal RTHandle[] DeferredInputAttachments
		{
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x2D72A48", Offset = "0x2D6EA48", VA = "0x2D72A48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x2D72A50", Offset = "0x2D6EA50", VA = "0x2D72A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000256")]
		internal bool[] DeferredInputIsTransient
		{
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x2D72A58", Offset = "0x2D6EA58", VA = "0x2D72A58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x2D72A60", Offset = "0x2D6EA60", VA = "0x2D72A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000257")]
		internal RTHandle DepthAttachment
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x2D72A68", Offset = "0x2D6EA68", VA = "0x2D72A68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x2D72A70", Offset = "0x2D6EA70", VA = "0x2D72A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000258")]
		internal RTHandle DepthCopyTexture
		{
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x2D72A78", Offset = "0x2D6EA78", VA = "0x2D72A78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x2D72A80", Offset = "0x2D6EA80", VA = "0x2D72A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000259")]
		internal GraphicsFormat[] GbufferFormats
		{
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x2D72A88", Offset = "0x2D6EA88", VA = "0x2D72A88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x2D72A90", Offset = "0x2D6EA90", VA = "0x2D72A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700025A")]
		internal RTHandle DepthAttachmentHandle
		{
			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x2D72A98", Offset = "0x2D6EA98", VA = "0x2D72A98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0x2D72AA0", Offset = "0x2D6EAA0", VA = "0x2D72AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x2D727D8", Offset = "0x2D6E7D8", VA = "0x2D727D8")]
		internal GraphicsFormat GetGBufferFormat(int index)
		{
			return default(GraphicsFormat);
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x2D72AA8", Offset = "0x2D6EAA8", VA = "0x2D72AA8")]
		internal DeferredLights(InitParams initParams, bool useNativeRenderPass = false)
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x2D730C4", Offset = "0x2D6F0C4", VA = "0x2D730C4")]
		internal void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x2D738A8", Offset = "0x2D6F8A8", VA = "0x2D738A8")]
		internal void ResolveMixedLightingMode(ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x2D73CA8", Offset = "0x2D6FCA8", VA = "0x2D73CA8")]
		internal void DisableFramebufferFetchInput()
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x2D73CB0", Offset = "0x2D6FCB0", VA = "0x2D73CB0")]
		internal void ReleaseGbufferResources()
		{
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x2D73D50", Offset = "0x2D6FD50", VA = "0x2D73D50")]
		internal void ReAllocateGBufferIfNeeded(RenderTextureDescriptor gbufferSlice, int gbufferIndex)
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x2D73A14", Offset = "0x2D6FA14", VA = "0x2D73A14")]
		internal void CreateGbufferResources()
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x2D73F34", Offset = "0x2D6FF34", VA = "0x2D73F34")]
		internal void UpdateDeferredInputAttachments()
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x2D740D4", Offset = "0x2D700D4", VA = "0x2D740D4")]
		internal bool IsRuntimeSupportedThisFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x2D74170", Offset = "0x2D70170", VA = "0x2D74170")]
		public void Setup(ref RenderingData renderingData, AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, RTHandle depthCopyTexture, RTHandle depthAttachment, RTHandle colorAttachment)
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x2D74374", Offset = "0x2D70374", VA = "0x2D74374")]
		internal void Setup(AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass)
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x2D7437C", Offset = "0x2D7037C", VA = "0x2D7437C")]
		public void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x2D74454", Offset = "0x2D70454", VA = "0x2D74454")]
		internal static StencilState OverwriteStencil(StencilState s, int stencilWriteMask)
		{
			return default(StencilState);
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x2D7460C", Offset = "0x2D7060C", VA = "0x2D7460C")]
		internal static RenderStateBlock OverwriteStencil(RenderStateBlock block, int stencilWriteMask, int stencilRef)
		{
			return default(RenderStateBlock);
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x2D74870", Offset = "0x2D70870", VA = "0x2D74870")]
		internal void ClearStencilPartial(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x2D74B70", Offset = "0x2D70B70", VA = "0x2D74B70")]
		internal void ExecuteDeferredPass(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x2D738A0", Offset = "0x2D6F8A0", VA = "0x2D738A0")]
		private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x2D75510", Offset = "0x2D71510", VA = "0x2D75510")]
		private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x2D75698", Offset = "0x2D71698", VA = "0x2D75698")]
		internal Matrix4x4[] GetScreenToWorldMatrix(CameraData cameraData)
		{
			return null;
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x2D74E28", Offset = "0x2D70E28", VA = "0x2D74E28")]
		private void SetupMatrixConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x2D735C0", Offset = "0x2D6F5C0", VA = "0x2D735C0")]
		private void PrecomputeLights(out NativeArray<ushort> stencilVisLights, out NativeArray<ushort> stencilVisLightOffsets, ref NativeArray<VisibleLight> visibleLights, bool hasAdditionalLights, Matrix4x4 view, bool isOrthographic, float zNear)
		{
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x2D74EDC", Offset = "0x2D70EDC", VA = "0x2D74EDC")]
		private bool HasStencilLightsOfType(LightType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x2D75088", Offset = "0x2D71088", VA = "0x2D75088")]
		private void RenderStencilLights(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x2D76DBC", Offset = "0x2D72DBC", VA = "0x2D76DBC")]
		private void SetAdditionalLightsShadowsKeyword(ref CommandBuffer cmd, ref RenderingData renderingData, bool hasDeferredShadows)
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x2D75944", Offset = "0x2D71944", VA = "0x2D75944")]
		private void RenderStencilDirectionalLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights, int mainLightIndex)
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x2D75F3C", Offset = "0x2D71F3C", VA = "0x2D75F3C")]
		private void RenderStencilPointLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights)
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x2D76600", Offset = "0x2D72600", VA = "0x2D76600")]
		private void RenderStencilSpotLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights)
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x2D74F54", Offset = "0x2D70F54", VA = "0x2D74F54")]
		private void RenderSSAOBeforeShading(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x2D75334", Offset = "0x2D71334", VA = "0x2D75334")]
		private void RenderFog(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x2D72D08", Offset = "0x2D6ED08", VA = "0x2D72D08")]
		private void InitStencilDeferredMaterial()
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x2D76E98", Offset = "0x2D72E98", VA = "0x2D76E98")]
		private static Mesh CreateSphereMesh()
		{
			return null;
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x2D7745C", Offset = "0x2D7345C", VA = "0x2D7745C")]
		private static Mesh CreateHemisphereMesh()
		{
			return null;
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x2D74A24", Offset = "0x2D70A24", VA = "0x2D74A24")]
		private static Mesh CreateFullscreenMesh()
		{
			return null;
		}
	}
	[Token(Token = "0x20001E1")]
	public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
	{
		[Token(Token = "0x20001E2")]
		private static class AdditionalShadowsConstantBuffer
		{
			[Token(Token = "0x4000BD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static int _AdditionalLightsWorldToShadow;

			[Token(Token = "0x4000BD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static int _AdditionalShadowParams;

			[Token(Token = "0x4000BD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static int _AdditionalShadowOffset0;

			[Token(Token = "0x4000BD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static int _AdditionalShadowOffset1;

			[Token(Token = "0x4000BD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static int _AdditionalShadowFadeParams;

			[Token(Token = "0x4000BD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static int _AdditionalShadowmapSize;
		}

		[Token(Token = "0x20001E3")]
		internal struct ShadowResolutionRequest
		{
			[Token(Token = "0x4000BD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int visibleLightIndex;

			[Token(Token = "0x4000BD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int perLightShadowSliceIndex;

			[Token(Token = "0x4000BDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int requestedResolution;

			[Token(Token = "0x4000BDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool softShadow;

			[Token(Token = "0x4000BDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool pointLightShadow;

			[Token(Token = "0x4000BDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int offsetX;

			[Token(Token = "0x4000BDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int offsetY;

			[Token(Token = "0x4000BDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int allocatedResolution;

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x2D7B0A8", Offset = "0x2D770A8", VA = "0x2D7B0A8")]
			public ShadowResolutionRequest(int _visibleLightIndex, int _perLightShadowSliceIndex, int _requestedResolution, bool _softShadow, bool _pointLightShadow)
			{
			}
		}

		[Token(Token = "0x20001E4")]
		private class PassData
		{
			[Token(Token = "0x4000BE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal AdditionalLightsShadowCasterPass pass;

			[Token(Token = "0x4000BE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal RenderGraph graph;

			[Token(Token = "0x4000BE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal TextureHandle shadowmapTexture;

			[Token(Token = "0x4000BE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal RenderingData renderingData;

			[Token(Token = "0x4000BE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			internal int shadowmapID;

			[Token(Token = "0x4000BE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
			internal bool emptyShadowmap;

			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x2D7C588", Offset = "0x2D78588", VA = "0x2D7C588")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsBufferId was deprecated. Shadow slice matrix is now passed to the GPU using an entry in buffer m_AdditionalLightsWorldToShadow_SSBO", false)]
		public static int m_AdditionalShadowsBufferId;

		[Token(Token = "0x4000BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsIndicesId was deprecated. Shadow slice index is now passed to the GPU using last member of an entry in buffer m_AdditionalShadowParams_SSBO", false)]
		public static int m_AdditionalShadowsIndicesId;

		[Token(Token = "0x4000BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Vector4 c_DefaultShadowParams;

		[Token(Token = "0x4000BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int m_AdditionalLightsWorldToShadow_SSBO;

		[Token(Token = "0x4000BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static int m_AdditionalShadowParams_SSBO;

		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool m_UseStructuredBuffer;

		[Token(Token = "0x4000BB3")]
		private const int k_ShadowmapBufferBits = 16;

		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int m_AdditionalLightsShadowmapID;

		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal RTHandle m_AdditionalLightsShadowmapHandle;

		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool m_CreateEmptyShadowmap;

		[Token(Token = "0x4000BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RTHandle m_EmptyAdditionalLightShadowmapTexture;

		[Token(Token = "0x4000BB8")]
		private const int k_EmptyShadowMapDimensions = 1;

		[Token(Token = "0x4000BB9")]
		private const string k_AdditionalLightShadowMapTextureName = "_AdditionalLightsShadowmapTexture";

		[Token(Token = "0x4000BBA")]
		private const string k_EmptyAdditionalLightShadowMapTextureName = "_EmptyAdditionalLightShadowmapTexture";

		[Token(Token = "0x4000BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static Vector4[] s_EmptyAdditionalLightIndexToShadowParams;

		[Token(Token = "0x4000BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float m_MaxShadowDistanceSq;

		[Token(Token = "0x4000BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float m_CascadeBorder;

		[Token(Token = "0x4000BBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ShadowSliceData[] m_AdditionalLightsShadowSlices;

		[Token(Token = "0x4000BBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int[] m_VisibleLightIndexToAdditionalLightIndex;

		[Token(Token = "0x4000BC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int[] m_AdditionalLightIndexToVisibleLightIndex;

		[Token(Token = "0x4000BC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<int> m_ShadowSliceToAdditionalLightIndex;

		[Token(Token = "0x4000BC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private List<int> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex;

		[Token(Token = "0x4000BC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector4[] m_AdditionalLightIndexToShadowParams;

		[Token(Token = "0x4000BC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix;

		[Token(Token = "0x4000BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private List<ShadowResolutionRequest> m_ShadowResolutionRequests;

		[Token(Token = "0x4000BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float[] m_VisibleLightIndexToCameraSquareDistance;

		[Token(Token = "0x4000BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private ShadowResolutionRequest[] m_SortedShadowResolutionRequests;

		[Token(Token = "0x4000BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private int[] m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex;

		[Token(Token = "0x4000BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<RectInt> m_UnusedAtlasSquareAreas;

		[Token(Token = "0x4000BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int renderTargetWidth;

		[Token(Token = "0x4000BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int renderTargetHeight;

		[Token(Token = "0x4000BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private ProfilingSampler m_ProfilingSetupSampler;

		[Token(Token = "0x4000BCD")]
		private const float LightTypeIdentifierInShadowParams_Spot = 0f;

		[Token(Token = "0x4000BCE")]
		private const float LightTypeIdentifierInShadowParams_Point = 1f;

		[Token(Token = "0x4000BCF")]
		private const int kMinimumPunctualLightHardShadowResolution = 8;

		[Token(Token = "0x4000BD0")]
		private const int kMinimumPunctualLightSoftShadowResolution = 16;

		[Token(Token = "0x4000BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Dictionary<int, ulong> m_ShadowRequestsHashes;

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x2D78548", Offset = "0x2D74548", VA = "0x2D78548")]
		public AdditionalLightsShadowCasterPass(RenderPassEvent evt)
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x2D78BF8", Offset = "0x2D74BF8", VA = "0x2D78BF8")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x2D78C0C", Offset = "0x2D74C0C", VA = "0x2D78C0C")]
		private int GetPunctualLightShadowSlicesCount(in LightType lightType)
		{
			return default(int);
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x2D78C28", Offset = "0x2D74C28", VA = "0x2D78C28")]
		internal static float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels)
		{
			return default(float);
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x2D78C98", Offset = "0x2D74C98", VA = "0x2D78C98")]
		private int MinimalPunctualLightShadowResolution(bool softShadow)
		{
			return default(int);
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x2D78CAC", Offset = "0x2D74CAC", VA = "0x2D78CAC")]
		internal static float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering)
		{
			return default(float);
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x2D78DD0", Offset = "0x2D74DD0", VA = "0x2D78DD0")]
		internal void InsertionSort(ShadowResolutionRequest[] array, int startIndex, int lastIndex)
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x2D79054", Offset = "0x2D75054", VA = "0x2D79054")]
		private int EstimateScaleFactorNeededToFitAllShadowsInAtlas(in ShadowResolutionRequest[] shadowResolutionRequests, int endIndex, int atlasWidth)
		{
			return default(int);
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x2D790D4", Offset = "0x2D750D4", VA = "0x2D790D4")]
		private void AtlasLayout(int atlasSize, int totalShadowSlicesCount, int estimatedScaleFactor)
		{
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x2D7939C", Offset = "0x2D7539C", VA = "0x2D7939C")]
		private ulong ResolutionLog2ForHash(int resolution)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x2D793E8", Offset = "0x2D753E8", VA = "0x2D793E8")]
		private ulong ComputeShadowRequestHash(ref RenderingData renderingData)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x2D797C0", Offset = "0x2D757C0", VA = "0x2D797C0")]
		public bool Setup(ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x2D7AF1C", Offset = "0x2D76F1C", VA = "0x2D7AF1C")]
		private bool SetupForEmptyRendering(ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x2D7B0C4", Offset = "0x2D770C4", VA = "0x2D7B0C4", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x2D7B118", Offset = "0x2D77118", VA = "0x2D7B118", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x2D76E64", Offset = "0x2D72E64", VA = "0x2D76E64")]
		public int GetShadowLightIndexFromLightIndex(int visibleLightIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x2D7B044", Offset = "0x2D77044", VA = "0x2D7B044")]
		private void Clear()
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x2D7B1E4", Offset = "0x2D771E4", VA = "0x2D7B1E4")]
		private void SetEmptyAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x2D7BB24", Offset = "0x2D77B24", VA = "0x2D7BB24")]
		internal static void SetEmptyAdditionalLightShadowParams(CommandBuffer cmd, Vector4[] lightIndexToShadowParams)
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x2D7B2F0", Offset = "0x2D772F0", VA = "0x2D7B2F0")]
		private void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x2D7BC40", Offset = "0x2D77C40", VA = "0x2D7BC40")]
		private void SetupAdditionalLightsShadowReceiverConstants(CommandBuffer cmd, bool softShadows)
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x2D79660", Offset = "0x2D75660", VA = "0x2D79660")]
		private bool IsValidShadowCastingLight(ref LightData lightData, int i)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x2D7BF1C", Offset = "0x2D77F1C", VA = "0x2D7BF1C")]
		internal TextureHandle Render(RenderGraph graph, ref RenderingData renderingData)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x2D7C4E4", Offset = "0x2D784E4", VA = "0x2D7C4E4")]
		private void InitPassData(ref PassData passData, ref RenderingData renderingData, ref RenderGraph graph)
		{
		}
	}
	[Token(Token = "0x20001E6")]
	public class ForwardLights
	{
		[Token(Token = "0x20001E7")]
		private static class LightConstantBuffer
		{
			[Token(Token = "0x4000C08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static int _MainLightPosition;

			[Token(Token = "0x4000C09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static int _MainLightColor;

			[Token(Token = "0x4000C0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static int _MainLightOcclusionProbesChannel;

			[Token(Token = "0x4000C0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static int _MainLightLayerMask;

			[Token(Token = "0x4000C0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static int _AdditionalLightsCount;

			[Token(Token = "0x4000C0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static int _AdditionalLightsPosition;

			[Token(Token = "0x4000C0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static int _AdditionalLightsColor;

			[Token(Token = "0x4000C0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static int _AdditionalLightsAttenuation;

			[Token(Token = "0x4000C10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static int _AdditionalLightsSpotDir;

			[Token(Token = "0x4000C11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static int _AdditionalLightOcclusionProbeChannel;

			[Token(Token = "0x4000C12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static int _AdditionalLightsLayerMasks;
		}

		[Token(Token = "0x20001E8")]
		internal struct InitParams
		{
			[Token(Token = "0x4000C13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LightCookieManager lightCookieManager;

			[Token(Token = "0x4000C14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool forwardPlus;

			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x2D7C740", Offset = "0x2D78740", VA = "0x2D7C740")]
			internal static InitParams Create()
			{
				return default(InitParams);
			}
		}

		[Token(Token = "0x4000BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_AdditionalLightsBufferId;

		[Token(Token = "0x4000BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_AdditionalLightsIndicesId;

		[Token(Token = "0x4000BEB")]
		private const string k_SetupLightConstants = "Setup Light Constants";

		[Token(Token = "0x4000BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x4000BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ProfilingSampler m_ProfilingSamplerFPSetup;

		[Token(Token = "0x4000BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly ProfilingSampler m_ProfilingSamplerFPComplete;

		[Token(Token = "0x4000BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly ProfilingSampler m_ProfilingSamplerFPUpload;

		[Token(Token = "0x4000BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MixedLightingSetup m_MixedLightingSetup;

		[Token(Token = "0x4000BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector4[] m_AdditionalLightPositions;

		[Token(Token = "0x4000BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector4[] m_AdditionalLightColors;

		[Token(Token = "0x4000BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector4[] m_AdditionalLightAttenuations;

		[Token(Token = "0x4000BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector4[] m_AdditionalLightSpotDirections;

		[Token(Token = "0x4000BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector4[] m_AdditionalLightOcclusionProbeChannels;

		[Token(Token = "0x4000BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] m_AdditionalLightsLayerMasks;

		[Token(Token = "0x4000BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_UseStructuredBuffer;

		[Token(Token = "0x4000BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool m_UseForwardPlus;

		[Token(Token = "0x4000BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_DirectionalLightCount;

		[Token(Token = "0x4000BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_ActualTileWidth;

		[Token(Token = "0x4000BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int2 m_TileResolution;

		[Token(Token = "0x4000BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private JobHandle m_CullingHandle;

		[Token(Token = "0x4000BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private NativeArray<uint> m_ZBins;

		[Token(Token = "0x4000BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GraphicsBuffer m_ZBinsBuffer;

		[Token(Token = "0x4000BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<uint> m_TileMasks;

		[Token(Token = "0x4000C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GraphicsBuffer m_TileMasksBuffer;

		[Token(Token = "0x4000C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LightCookieManager m_LightCookieManager;

		[Token(Token = "0x4000C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ReflectionProbeManager m_ReflectionProbeManager;

		[Token(Token = "0x4000C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int m_WordsPerTile;

		[Token(Token = "0x4000C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float m_ZBinScale;

		[Token(Token = "0x4000C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float m_ZBinOffset;

		[Token(Token = "0x4000C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private int m_LightCount;

		[Token(Token = "0x4000C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private int m_BinCount;

		[Token(Token = "0x1700025B")]
		internal ReflectionProbeManager reflectionProbeManager
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x2D7CE2C", Offset = "0x2D78E2C", VA = "0x2D7CE2C")]
			get
			{
				return default(ReflectionProbeManager);
			}
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x2D7C718", Offset = "0x2D78718", VA = "0x2D7C718")]
		public ForwardLights()
		{
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x2D7C850", Offset = "0x2D78850", VA = "0x2D7C850")]
		internal ForwardLights(InitParams initParams)
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x2D7CC6C", Offset = "0x2D78C6C", VA = "0x2D7CC6C")]
		private void CreateForwardPlusBuffers()
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x2D7CE3C", Offset = "0x2D78E3C", VA = "0x2D7CE3C")]
		private static int AlignByteCount(int count, int align)
		{
			return default(int);
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x2D7CE50", Offset = "0x2D78E50", VA = "0x2D7CE50")]
		private void GetViewParams(Camera camera, float4x4 viewToClip, out float viewPlaneBot, out float viewPlaneTop, out float4 viewToViewportScaleBias)
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x2D7CFB4", Offset = "0x2D78FB4", VA = "0x2D7CFB4")]
		internal void PreSetup(ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x2D7E224", Offset = "0x2D7A224", VA = "0x2D7E224")]
		public void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x2D7EBF0", Offset = "0x2D7ABF0", VA = "0x2D7EBF0")]
		internal void Cleanup()
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x2D7ECA8", Offset = "0x2D7ACA8", VA = "0x2D7ECA8")]
		private void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel, out uint lightLayerMask, out bool isSubtractive)
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x2D7EBB8", Offset = "0x2D7ABB8", VA = "0x2D7EBB8")]
		private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x2D7EE94", Offset = "0x2D7AE94", VA = "0x2D7EE94")]
		private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x2D7EFD8", Offset = "0x2D7AFD8", VA = "0x2D7EFD8")]
		private void SetupAdditionalLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x2D7F504", Offset = "0x2D7B504", VA = "0x2D7F504")]
		private int SetupPerObjectLightIndices(CullingResults cullResults, ref LightData lightData)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001E9")]
	public static class NormalReconstruction
	{
		[Token(Token = "0x4000C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int s_NormalReconstructionMatrixID;

		[Token(Token = "0x4000C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Matrix4x4[] s_NormalReconstructionMatrix;

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x2D7F7FC", Offset = "0x2D7B7FC", VA = "0x2D7F7FC")]
		public static void SetupProperties(CommandBuffer cmd, in CameraData cameraData)
		{
		}
	}
	[Token(Token = "0x20001EA")]
	public class ColorGradingLutPass : ScriptableRenderPass
	{
		[Token(Token = "0x20001EB")]
		private class PassData
		{
			[Token(Token = "0x4000C1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal RenderingData renderingData;

			[Token(Token = "0x4000C1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			internal Material lutBuilderLdr;

			[Token(Token = "0x4000C20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			internal Material lutBuilderHdr;

			[Token(Token = "0x4000C21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			internal bool allowColorGradingACESHDR;

			[Token(Token = "0x4000C22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
			internal TextureHandle internalLut;

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x2D7FE60", Offset = "0x2D7BE60", VA = "0x2D7FE60")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x20001EC")]
		private static class ShaderConstants
		{
			[Token(Token = "0x4000C23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int _Lut_Params;

			[Token(Token = "0x4000C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int _ColorBalance;

			[Token(Token = "0x4000C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int _ColorFilter;

			[Token(Token = "0x4000C26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int _ChannelMixerRed;

			[Token(Token = "0x4000C27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int _ChannelMixerGreen;

			[Token(Token = "0x4000C28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly int _ChannelMixerBlue;

			[Token(Token = "0x4000C29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly int _HueSatCon;

			[Token(Token = "0x4000C2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly int _Lift;

			[Token(Token = "0x4000C2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly int _Gamma;

			[Token(Token = "0x4000C2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static readonly int _Gain;

			[Token(Token = "0x4000C2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static readonly int _Shadows;

			[Token(Token = "0x4000C2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public static readonly int _Midtones;

			[Token(Token = "0x4000C2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static readonly int _Highlights;

			[Token(Token = "0x4000C30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public static readonly int _ShaHiLimits;

			[Token(Token = "0x4000C31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static readonly int _SplitShadows;

			[Token(Token = "0x4000C32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public static readonly int _SplitHighlights;

			[Token(Token = "0x4000C33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static readonly int _CurveMaster;

			[Token(Token = "0x4000C34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public static readonly int _CurveRed;

			[Token(Token = "0x4000C35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static readonly int _CurveGreen;

			[Token(Token = "0x4000C36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public static readonly int _CurveBlue;

			[Token(Token = "0x4000C37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static readonly int _CurveHueVsHue;

			[Token(Token = "0x4000C38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public static readonly int _CurveHueVsSat;

			[Token(Token = "0x4000C39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static readonly int _CurveLumVsSat;

			[Token(Token = "0x4000C3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public static readonly int _CurveSatVsSat;
		}

		[Token(Token = "0x4000C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly Material m_LutBuilderLdr;

		[Token(Token = "0x4000C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly Material m_LutBuilderHdr;

		[Token(Token = "0x4000C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal readonly GraphicsFormat m_HdrLutFormat;

		[Token(Token = "0x4000C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		internal readonly GraphicsFormat m_LdrLutFormat;

		[Token(Token = "0x4000C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private PassData m_PassData;

		[Token(Token = "0x4000C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RTHandle m_InternalLut;

		[Token(Token = "0x4000C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool m_AllowColorGradingACESHDR;

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x2D7FB84", Offset = "0x2D7BB84", VA = "0x2D7FB84")]
		public ColorGradingLutPass(RenderPassEvent evt, PostProcessData data)
		{
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x2D7FE68", Offset = "0x2D7BE68", VA = "0x2D7FE68")]
		public void Setup(in RTHandle internalLut)
		{
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x2D7FE74", Offset = "0x2D7BE74", VA = "0x2D7FE74")]
		public void ConfigureDescriptor(in PostProcessingData postProcessingData, out RenderTextureDescriptor descriptor, out FilterMode filterMode)
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x2D7FEF8", Offset = "0x2D7BEF8", VA = "0x2D7FEF8", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x2D7FFEC", Offset = "0x2D7BFEC", VA = "0x2D7FFEC")]
		private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref RenderingData renderingData, RTHandle internalLutTarget)
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x2D8121C", Offset = "0x2D7D21C", VA = "0x2D8121C")]
		internal void Render(RenderGraph renderGraph, out TextureHandle internalColorLut, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x2D8154C", Offset = "0x2D7D54C", VA = "0x2D8154C")]
		public void Cleanup()
		{
		}
	}
	[Token(Token = "0x20001EE")]
	public class CopyColorPass : ScriptableRenderPass
	{
		[Token(Token = "0x20001EF")]
		private class PassData
		{
			[Token(Token = "0x4000C45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle source;

			[Token(Token = "0x4000C46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle destination;

			[Token(Token = "0x4000C47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool useProceduralBlit;

			[Token(Token = "0x4000C48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			internal bool disableFoveatedRenderingForPass;

			[Token(Token = "0x4000C49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal CommandBuffer cmd;

			[Token(Token = "0x4000C4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Material samplingMaterial;

			[Token(Token = "0x4000C4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Material copyColorMaterial;

			[Token(Token = "0x4000C4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Downsampling downsamplingMethod;

			[Token(Token = "0x4000C4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal ClearFlag clearFlag;

			[Token(Token = "0x4000C4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Color clearColor;

			[Token(Token = "0x4000C4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int sampleOffsetShaderHandle;

			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x2D82CCC", Offset = "0x2D7ECCC", VA = "0x2D82CCC")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int m_SampleOffsetShaderHandle;

		[Token(Token = "0x4000C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material m_SamplingMaterial;

		[Token(Token = "0x4000C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Downsampling m_DownsamplingMethod;

		[Token(Token = "0x4000C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material m_CopyColorMaterial;

		[Token(Token = "0x4000C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private PassData m_PassData;

		[Token(Token = "0x1700025C")]
		private RTHandle source
		{
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x2D81B70", Offset = "0x2D7DB70", VA = "0x2D81B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x2D81B78", Offset = "0x2D7DB78", VA = "0x2D81B78")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700025D")]
		private RTHandle destination
		{
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x2D81B80", Offset = "0x2D7DB80", VA = "0x2D81B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x2D81B88", Offset = "0x2D7DB88", VA = "0x2D81B88")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700025E")]
		private int destinationID
		{
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x2D81B90", Offset = "0x2D7DB90", VA = "0x2D81B90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x2D81B98", Offset = "0x2D7DB98", VA = "0x2D81B98")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x2D81BA0", Offset = "0x2D7DBA0", VA = "0x2D81BA0")]
		public CopyColorPass(RenderPassEvent evt, Material samplingMaterial, [Optional] Material copyColorMaterial)
		{
		}

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x2D81CC8", Offset = "0x2D7DCC8", VA = "0x2D81CC8")]
		public static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode)
		{
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x2D81D34", Offset = "0x2D7DD34", VA = "0x2D81D34")]
		[Obsolete("Use RTHandles for source and destination.")]
		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling)
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x2D81E44", Offset = "0x2D7DE44", VA = "0x2D81E44")]
		public void Setup(RTHandle source, RTHandle destination, Downsampling downsampling)
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x2D81E50", Offset = "0x2D7DE50", VA = "0x2D81E50", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x2D82044", Offset = "0x2D7E044", VA = "0x2D82044", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x2D821D8", Offset = "0x2D7E1D8", VA = "0x2D821D8")]
		private static void ExecutePass(PassData passData, RTHandle source, RTHandle destination, ref CommandBuffer cmd, bool useDrawProceduralBlit, bool disableFoveatedRenderingForPass)
		{
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x2D82614", Offset = "0x2D7E614", VA = "0x2D82614")]
		internal TextureHandle Render(RenderGraph renderGraph, out TextureHandle destination, in TextureHandle source, Downsampling downsampling, ref RenderingData renderingData)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x2D82BDC", Offset = "0x2D7EBDC", VA = "0x2D82BDC", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x20001F1")]
	public class CopyDepthPass : ScriptableRenderPass
	{
		[Token(Token = "0x20001F2")]
		private class PassData
		{
			[Token(Token = "0x4000C5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle source;

			[Token(Token = "0x4000C5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle destination;

			[Token(Token = "0x4000C5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal CommandBuffer cmd;

			[Token(Token = "0x4000C5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal CameraData cameraData;

			[Token(Token = "0x4000C5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			internal Material copyDepthMaterial;

			[Token(Token = "0x4000C60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
			internal int msaaSamples;

			[Token(Token = "0x4000C61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
			internal bool copyResolvedDepth;

			[Token(Token = "0x4000C62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x245")]
			internal bool copyToDepth;

			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x2D82FE8", Offset = "0x2D7EFE8", VA = "0x2D82FE8")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material m_CopyDepthMaterial;

		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal bool m_CopyResolvedDepth;

		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		internal bool m_ShouldClear;

		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private PassData m_PassData;

		[Token(Token = "0x1700025F")]
		private RTHandle source
		{
			[Token(Token = "0x6000B55")]
			[Address(RVA = "0x2D82E88", Offset = "0x2D7EE88", VA = "0x2D82E88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x2D82E90", Offset = "0x2D7EE90", VA = "0x2D82E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000260")]
		private RTHandle destination
		{
			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x2D82E98", Offset = "0x2D7EE98", VA = "0x2D82E98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x2D82EA0", Offset = "0x2D7EEA0", VA = "0x2D82EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000261")]
		internal int MssaSamples
		{
			[Token(Token = "0x6000B59")]
			[Address(RVA = "0x2D82EA8", Offset = "0x2D7EEA8", VA = "0x2D82EA8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B5A")]
			[Address(RVA = "0x2D82EB0", Offset = "0x2D7EEB0", VA = "0x2D82EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000262")]
		internal bool CopyToDepth
		{
			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0x2D82EB8", Offset = "0x2D7EEB8", VA = "0x2D82EB8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0x2D82EC0", Offset = "0x2D7EEC0", VA = "0x2D82EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x2D82EC8", Offset = "0x2D7EEC8", VA = "0x2D82EC8")]
		public CopyDepthPass(RenderPassEvent evt, Material copyDepthMaterial, bool shouldClear = false, bool copyToDepth = false, bool copyResolvedDepth = false)
		{
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x2D82FF0", Offset = "0x2D7EFF0", VA = "0x2D82FF0")]
		public void Setup(RTHandle source, RTHandle destination)
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x2D83000", Offset = "0x2D7F000", VA = "0x2D83000", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x2D83108", Offset = "0x2D7F108", VA = "0x2D83108", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x2D83210", Offset = "0x2D7F210", VA = "0x2D83210")]
		private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref CommandBuffer cmd, ref CameraData cameraData, RTHandle source, RTHandle destination)
		{
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x2D839C4", Offset = "0x2D7F9C4", VA = "0x2D839C4", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x2D83A74", Offset = "0x2D7FA74", VA = "0x2D83A74")]
		internal void Render(RenderGraph renderGraph, out TextureHandle destination, in TextureHandle source, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x20001F4")]
	internal class DeferredPass : ScriptableRenderPass
	{
		[Token(Token = "0x20001F5")]
		private class PassData
		{
			[Token(Token = "0x4000C68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle color;

			[Token(Token = "0x4000C69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle depth;

			[Token(Token = "0x4000C6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal RenderingData renderingData;

			[Token(Token = "0x4000C6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			internal DeferredLights deferredLights;

			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x2D8477C", Offset = "0x2D8077C", VA = "0x2D8477C")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private DeferredLights m_DeferredLights;

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x2D8432C", Offset = "0x2D8032C", VA = "0x2D8432C")]
		public DeferredPass(RenderPassEvent evt, DeferredLights deferredLights)
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x2D843E4", Offset = "0x2D803E4", VA = "0x2D843E4", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescripor)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x2D84464", Offset = "0x2D80464", VA = "0x2D84464", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x2D8447C", Offset = "0x2D8047C", VA = "0x2D8447C")]
		internal void Render(RenderGraph renderGraph, TextureHandle color, TextureHandle depth, TextureHandle[] gbuffer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x2D84764", Offset = "0x2D80764", VA = "0x2D84764", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x20001F7")]
	public class DepthNormalOnlyPass : ScriptableRenderPass
	{
		[Token(Token = "0x20001F8")]
		private class PassData
		{
			[Token(Token = "0x4000C78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle cameraDepthTexture;

			[Token(Token = "0x4000C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle cameraNormalsTexture;

			[Token(Token = "0x4000C7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal RenderingData renderingData;

			[Token(Token = "0x4000C7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			internal List<ShaderTagId> shaderTagIds;

			[Token(Token = "0x4000C7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			internal FilteringSettings filteringSettings;

			[Token(Token = "0x4000C7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
			internal bool enableRenderingLayers;

			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x2D84A18", Offset = "0x2D80A18", VA = "0x2D84A18")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x4000C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private PassData m_PassData;

		[Token(Token = "0x4000C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<ShaderTagId> k_DepthNormals;

		[Token(Token = "0x4000C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly RTHandle[] k_ColorAttachment1;

		[Token(Token = "0x4000C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly RTHandle[] k_ColorAttachment2;

		[Token(Token = "0x17000263")]
		internal List<ShaderTagId> shaderTagIds
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x2D84818", Offset = "0x2D80818", VA = "0x2D84818")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x2D84820", Offset = "0x2D80820", VA = "0x2D84820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000264")]
		private RTHandle depthHandle
		{
			[Token(Token = "0x6000B75")]
			[Address(RVA = "0x2D84828", Offset = "0x2D80828", VA = "0x2D84828")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x2D84830", Offset = "0x2D80830", VA = "0x2D84830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000265")]
		private RTHandle normalHandle
		{
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x2D84838", Offset = "0x2D80838", VA = "0x2D84838")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x2D84840", Offset = "0x2D80840", VA = "0x2D84840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000266")]
		private RTHandle renderingLayersHandle
		{
			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x2D84848", Offset = "0x2D80848", VA = "0x2D84848")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x2D84850", Offset = "0x2D80850", VA = "0x2D84850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000267")]
		internal bool enableRenderingLayers
		{
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x2D84858", Offset = "0x2D80858", VA = "0x2D84858")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x2D84860", Offset = "0x2D80860", VA = "0x2D84860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x2D84868", Offset = "0x2D80868", VA = "0x2D84868")]
		public DepthNormalOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x2D84A20", Offset = "0x2D80A20", VA = "0x2D84A20")]
		public static GraphicsFormat GetGraphicsFormat()
		{
			return default(GraphicsFormat);
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x2D84AB8", Offset = "0x2D80AB8", VA = "0x2D84AB8")]
		public void Setup(RTHandle depthHandle, RTHandle normalHandle)
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x2D84AC4", Offset = "0x2D80AC4", VA = "0x2D84AC4")]
		public void Setup(RTHandle depthHandle, RTHandle normalHandle, RTHandle decalLayerHandle)
		{
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x2D84AD8", Offset = "0x2D80AD8", VA = "0x2D84AD8", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x2D84C7C", Offset = "0x2D80C7C", VA = "0x2D84C7C")]
		private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x2D85004", Offset = "0x2D81004", VA = "0x2D85004", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x2D850A8", Offset = "0x2D810A8", VA = "0x2D850A8", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x2D85160", Offset = "0x2D81160", VA = "0x2D85160")]
		internal void Render(RenderGraph renderGraph, out TextureHandle cameraNormalsTexture, out TextureHandle cameraDepthTexture, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x20001FA")]
	public class DepthOnlyPass : ScriptableRenderPass
	{
		[Token(Token = "0x20001FB")]
		private class PassData
		{
			[Token(Token = "0x4000C86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle cameraDepthTexture;

			[Token(Token = "0x4000C87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal RenderingData renderingData;

			[Token(Token = "0x4000C88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			internal ShaderTagId shaderTagId;

			[Token(Token = "0x4000C89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
			internal FilteringSettings filteringSettings;

			[Token(Token = "0x6000B96")]
			[Address(RVA = "0x2D85A3C", Offset = "0x2D81A3C", VA = "0x2D85A3C")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ShaderTagId k_ShaderTagId;

		[Token(Token = "0x4000C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GraphicsFormat depthStencilFormat;

		[Token(Token = "0x4000C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private PassData m_PassData;

		[Token(Token = "0x4000C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x17000268")]
		private RTHandle destination
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x2D85868", Offset = "0x2D81868", VA = "0x2D85868")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0x2D85870", Offset = "0x2D81870", VA = "0x2D85870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000269")]
		internal ShaderTagId shaderTagId
		{
			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0x2D85878", Offset = "0x2D81878", VA = "0x2D85878")]
			[CompilerGenerated]
			get
			{
				return default(ShaderTagId);
			}
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x2D85880", Offset = "0x2D81880", VA = "0x2D85880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x2D85888", Offset = "0x2D81888", VA = "0x2D85888")]
		public DepthOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
		{
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x2D85A44", Offset = "0x2D81A44", VA = "0x2D85A44")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle depthAttachmentHandle)
		{
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x2D85A54", Offset = "0x2D81A54", VA = "0x2D85A54", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x2D85AE0", Offset = "0x2D81AE0", VA = "0x2D85AE0")]
		private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x2D85D54", Offset = "0x2D81D54", VA = "0x2D85D54", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x2D85DEC", Offset = "0x2D81DEC", VA = "0x2D85DEC")]
		internal void Render(RenderGraph renderGraph, out TextureHandle cameraDepthTexture, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x20001FD")]
	internal class DrawObjectsWithRenderingLayersPass : DrawObjectsPass
	{
		[Token(Token = "0x4000C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private RTHandle[] m_ColorTargetIndentifiers;

		[Token(Token = "0x4000C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private RTHandle m_DepthTargetIndentifiers;

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x2D8627C", Offset = "0x2D8227C", VA = "0x2D8627C")]
		public DrawObjectsWithRenderingLayersPass(URPProfileId profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		{
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x2D86460", Offset = "0x2D82460", VA = "0x2D86460")]
		public void Setup(RTHandle colorAttachment, RTHandle renderingLayersTexture, RTHandle depthAttachment)
		{
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x2D865C0", Offset = "0x2D825C0", VA = "0x2D865C0", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x2D865CC", Offset = "0x2D825CC", VA = "0x2D865CC", Slot = "11")]
		protected override void OnExecute(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x20001FE")]
	public class DrawObjectsPass : ScriptableRenderPass
	{
		[Token(Token = "0x20001FF")]
		private class PassData
		{
			[Token(Token = "0x4000C99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle m_Albedo;

			[Token(Token = "0x4000C9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle m_Depth;

			[Token(Token = "0x4000C9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal RenderingData m_RenderingData;

			[Token(Token = "0x4000C9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			internal bool m_IsOpaque;

			[Token(Token = "0x4000C9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
			internal RenderStateBlock m_RenderStateBlock;

			[Token(Token = "0x4000C9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
			internal FilteringSettings m_FilteringSettings;

			[Token(Token = "0x4000C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
			internal List<ShaderTagId> m_ShaderTagIdList;

			[Token(Token = "0x4000CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
			internal ProfilingSampler m_ProfilingSampler;

			[Token(Token = "0x4000CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
			internal bool m_ShouldTransparentsReceiveShadows;

			[Token(Token = "0x4000CA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x371")]
			internal bool m_IsActiveTargetBackBuffer;

			[Token(Token = "0x4000CA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
			internal DrawObjectsPass pass;

			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x2D8696C", Offset = "0x2D8296C", VA = "0x2D8696C")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x4000C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderStateBlock m_RenderStateBlock;

		[Token(Token = "0x4000C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<ShaderTagId> m_ShaderTagIdList;

		[Token(Token = "0x4000C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private string m_ProfilerTag;

		[Token(Token = "0x4000C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x4000C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool m_IsOpaque;

		[Token(Token = "0x4000C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		public bool m_IsActiveTargetBackBuffer;

		[Token(Token = "0x4000C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		public bool m_ShouldTransparentsReceiveShadows;

		[Token(Token = "0x4000C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private PassData m_PassData;

		[Token(Token = "0x4000C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool m_UseDepthPriming;

		[Token(Token = "0x4000C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int s_DrawObjectPassDataPropID;

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x2D86640", Offset = "0x2D82640", VA = "0x2D86640")]
		public DrawObjectsPass(string profilerTag, ShaderTagId[] shaderTagIds, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x2D86974", Offset = "0x2D82974", VA = "0x2D86974")]
		public DrawObjectsPass(string profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x2D86360", Offset = "0x2D82360", VA = "0x2D86360")]
		internal DrawObjectsPass(URPProfileId profileId, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x2D86AF4", Offset = "0x2D82AF4", VA = "0x2D86AF4", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x2D86C00", Offset = "0x2D82C00", VA = "0x2D86C00")]
		private static void CameraSetup(CommandBuffer cmd, PassData data, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x2D86CD8", Offset = "0x2D82CD8", VA = "0x2D86CD8")]
		private static void ExecutePass(ScriptableRenderContext context, PassData data, ref RenderingData renderingData, bool yFlip)
		{
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x2D872F4", Offset = "0x2D832F4", VA = "0x2D872F4")]
		internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x2D87640", Offset = "0x2D83640", VA = "0x2D87640", Slot = "11")]
		protected virtual void OnExecute(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x2000201")]
	public class FinalBlitPass : ScriptableRenderPass
	{
		[Token(Token = "0x2000202")]
		private static class BlitPassNames
		{
			[Token(Token = "0x4000CAA")]
			public const string NearestSampler = "NearestDebugDraw";

			[Token(Token = "0x4000CAB")]
			public const string BilinearSampler = "BilinearDebugDraw";
		}

		[Token(Token = "0x2000203")]
		private enum BlitType
		{
			[Token(Token = "0x4000CAD")]
			Core,
			[Token(Token = "0x4000CAE")]
			HDR,
			[Token(Token = "0x4000CAF")]
			Count
		}

		[Token(Token = "0x2000204")]
		private struct BlitMaterialData
		{
			[Token(Token = "0x4000CB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Material material;

			[Token(Token = "0x4000CB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int nearestSamplerPass;

			[Token(Token = "0x4000CB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int bilinearSamplerPass;
		}

		[Token(Token = "0x2000205")]
		private class PassData
		{
			[Token(Token = "0x4000CB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle source;

			[Token(Token = "0x4000CB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle destination;

			[Token(Token = "0x4000CB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int sourceID;

			[Token(Token = "0x4000CB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal Vector4 hdrOutputLuminanceParams;

			[Token(Token = "0x4000CB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool requireSrgbConversion;

			[Token(Token = "0x4000CB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal BlitMaterialData blitMaterialData;

			[Token(Token = "0x4000CB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal RenderingData renderingData;

			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x2D87BD8", Offset = "0x2D83BD8", VA = "0x2D87BD8")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RTHandle m_Source;

		[Token(Token = "0x4000CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private PassData m_PassData;

		[Token(Token = "0x4000CA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private BlitMaterialData[] m_BlitMaterialData;

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x2D879C4", Offset = "0x2D839C4", VA = "0x2D879C4")]
		public FinalBlitPass(RenderPassEvent evt, Material blitMaterial, Material blitHDRMaterial)
		{
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x2D87BE0", Offset = "0x2D83BE0", VA = "0x2D87BE0")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x2D87BE4", Offset = "0x2D83BE4", VA = "0x2D87BE4")]
		[Obsolete("Use RTHandles for colorHandle")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle)
		{
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x2D87DD4", Offset = "0x2D83DD4", VA = "0x2D87DD4")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle colorHandle)
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x2D87DDC", Offset = "0x2D83DDC", VA = "0x2D87DDC")]
		private static void SetupHDROutput(ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperation, Vector4 hdrOutputParameters)
		{
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x2D87E9C", Offset = "0x2D83E9C", VA = "0x2D87E9C", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x2D87F58", Offset = "0x2D83F58", VA = "0x2D87F58", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x2D88794", Offset = "0x2D84794", VA = "0x2D88794")]
		private static void ExecutePass(ref RenderingData renderingData, in BlitMaterialData blitMaterialData, RTHandle cameraTarget, RTHandle source)
		{
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x2D88708", Offset = "0x2D84708", VA = "0x2D88708")]
		private void InitPassData(ref RenderingData renderingData, ref PassData passData, BlitType blitType)
		{
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x2D888C4", Offset = "0x2D848C4", VA = "0x2D888C4")]
		internal void Render(RenderGraph renderGraph, ref RenderingData renderingData, TextureHandle src, TextureHandle dest, TextureHandle overlayUITexture)
		{
		}
	}
	[Token(Token = "0x2000207")]
	internal class GBufferPass : ScriptableRenderPass
	{
		[Token(Token = "0x2000208")]
		private class PassData
		{
			[Token(Token = "0x4000CCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextureHandle[] gbuffer;

			[Token(Token = "0x4000CCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextureHandle depth;

			[Token(Token = "0x4000CCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal RenderingData renderingData;

			[Token(Token = "0x4000CCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			internal DeferredLights deferredLights;

			[Token(Token = "0x4000CCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			internal FilteringSettings filteringSettings;

			[Token(Token = "0x4000CCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
			internal DrawingSettings drawingSettings;

			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x2D89560", Offset = "0x2D85560", VA = "0x2D89560")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000CBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int s_CameraNormalsTextureID;

		[Token(Token = "0x4000CBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static ShaderTagId s_ShaderTagLit;

		[Token(Token = "0x4000CBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ShaderTagId s_ShaderTagSimpleLit;

		[Token(Token = "0x4000CBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static ShaderTagId s_ShaderTagUnlit;

		[Token(Token = "0x4000CC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ShaderTagId s_ShaderTagComplexLit;

		[Token(Token = "0x4000CC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static ShaderTagId s_ShaderTagUniversalGBuffer;

		[Token(Token = "0x4000CC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static ShaderTagId s_ShaderTagUniversalMaterialType;

		[Token(Token = "0x4000CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x4000CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DeferredLights m_DeferredLights;

		[Token(Token = "0x4000CC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static ShaderTagId[] s_ShaderTagValues;

		[Token(Token = "0x4000CC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static RenderStateBlock[] s_RenderStateBlocks;

		[Token(Token = "0x4000CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x4000CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderStateBlock m_RenderStateBlock;

		[Token(Token = "0x4000CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private PassData m_PassData;

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x2D89064", Offset = "0x2D85064", VA = "0x2D89064")]
		public GBufferPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, DeferredLights deferredLights)
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x2D89568", Offset = "0x2D85568", VA = "0x2D89568")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x2D89580", Offset = "0x2D85580", VA = "0x2D89580", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x2D89894", Offset = "0x2D85894", VA = "0x2D89894", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x2D89BB8", Offset = "0x2D85BB8", VA = "0x2D89BB8")]
		private static void ExecutePass(ScriptableRenderContext context, PassData data, ref RenderingData renderingData, bool useRenderGraph = false)
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x2D89F68", Offset = "0x2D85F68", VA = "0x2D89F68")]
		internal void Render(RenderGraph renderGraph, TextureHandle cameraColor, TextureHandle cameraDepth, ref RenderingData renderingData, ref UniversalRenderer.RenderGraphFrameResources frameResources)
		{
		}
	}
	[Token(Token = "0x200020A")]
	public class MainLightShadowCasterPass : ScriptableRenderPass
	{
		[Token(Token = "0x200020B")]
		private static class MainLightShadowConstantBuffer
		{
			[Token(Token = "0x4000CE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static int _WorldToShadow;

			[Token(Token = "0x4000CE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static int _ShadowParams;

			[Token(Token = "0x4000CE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static int _CascadeShadowSplitSpheres0;

			[Token(Token = "0x4000CEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static int _CascadeShadowSplitSpheres1;

			[Token(Token = "0x4000CEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static int _CascadeShadowSplitSpheres2;

			[Token(Token = "0x4000CEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static int _CascadeShadowSplitSpheres3;

			[Token(Token = "0x4000CED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static int _CascadeShadowSplitSphereRadii;

			[Token(Token = "0x4000CEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static int _ShadowOffset0;

			[Token(Token = "0x4000CEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static int _ShadowOffset1;

			[Token(Token = "0x4000CF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static int _ShadowmapSize;
		}

		[Token(Token = "0x200020C")]
		private class PassData
		{
			[Token(Token = "0x4000CF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MainLightShadowCasterPass pass;

			[Token(Token = "0x4000CF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal RenderGraph graph;

			[Token(Token = "0x4000CF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal TextureHandle shadowmapTexture;

			[Token(Token = "0x4000CF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal RenderingData renderingData;

			[Token(Token = "0x4000CF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			internal int shadowmapID;

			[Token(Token = "0x4000CF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
			internal bool emptyShadowmap;

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x2D8CCF4", Offset = "0x2D88CF4", VA = "0x2D8CCF4")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x4000CD3")]
		private const int k_MaxCascades = 4;

		[Token(Token = "0x4000CD4")]
		private const int k_ShadowmapBufferBits = 16;

		[Token(Token = "0x4000CD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float m_CascadeBorder;

		[Token(Token = "0x4000CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float m_MaxShadowDistanceSq;

		[Token(Token = "0x4000CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int m_ShadowCasterCascadesCount;

		[Token(Token = "0x4000CD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int m_MainLightShadowmapID;

		[Token(Token = "0x4000CD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal RTHandle m_MainLightShadowmapTexture;

		[Token(Token = "0x4000CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RTHandle m_EmptyMainLightShadowmapTexture;

		[Token(Token = "0x4000CDB")]
		private const int k_EmptyShadowMapDimensions = 1;

		[Token(Token = "0x4000CDC")]
		private const string k_MainLightShadowMapTextureName = "_MainLightShadowmapTexture";

		[Token(Token = "0x4000CDD")]
		private const string k_EmptyMainLightShadowMapTextureName = "_EmptyMainLightShadowmapTexture";

		[Token(Token = "0x4000CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector4 s_EmptyShadowParams;

		[Token(Token = "0x4000CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Vector4 s_EmptyShadowmapSize;

		[Token(Token = "0x4000CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Matrix4x4[] m_MainLightShadowMatrices;

		[Token(Token = "0x4000CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ShadowSliceData[] m_CascadeSlices;

		[Token(Token = "0x4000CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector4[] m_CascadeSplitDistances;

		[Token(Token = "0x4000CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool m_CreateEmptyShadowmap;

		[Token(Token = "0x4000CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int renderTargetWidth;

		[Token(Token = "0x4000CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int renderTargetHeight;

		[Token(Token = "0x4000CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ProfilingSampler m_ProfilingSetupSampler;

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x2D8AF6C", Offset = "0x2D86F6C", VA = "0x2D8AF6C")]
		public MainLightShadowCasterPass(RenderPassEvent evt)
		{
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x2D8B338", Offset = "0x2D87338", VA = "0x2D8B338")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x2D8B36C", Offset = "0x2D8736C", VA = "0x2D8B36C")]
		public bool Setup(ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x2D8B7A4", Offset = "0x2D877A4", VA = "0x2D8B7A4")]
		private bool SetupForEmptyRendering(ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x2D8B978", Offset = "0x2D87978", VA = "0x2D8B978", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x2D8B9CC", Offset = "0x2D879CC", VA = "0x2D8B9CC", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x2D8B854", Offset = "0x2D87854", VA = "0x2D8B854")]
		private void Clear()
		{
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x2D8BA78", Offset = "0x2D87A78", VA = "0x2D8BA78")]
		private void SetEmptyMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x2D8C174", Offset = "0x2D88174", VA = "0x2D8C174")]
		internal static void SetEmptyMainLightShadowParams(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x2D8BB70", Offset = "0x2D87B70", VA = "0x2D8BB70")]
		private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x2D8C238", Offset = "0x2D88238", VA = "0x2D8C238")]
		private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref VisibleLight shadowLight, ref ShadowData shadowData)
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x2D8C688", Offset = "0x2D88688", VA = "0x2D8C688")]
		internal TextureHandle Render(RenderGraph graph, ref RenderingData renderingData)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x2D8CC50", Offset = "0x2D88C50", VA = "0x2D8CC50")]
		private void InitPassData(ref PassData passData, ref RenderingData renderingData, ref RenderGraph graph)
		{
		}
	}
	[Token(Token = "0x200020E")]
	internal sealed class RenderTargetBufferSystem
	{
		[Token(Token = "0x200020F")]
		private struct SwapBuffer
		{
			[Token(Token = "0x4000D00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RTHandle rtMSAA;

			[Token(Token = "0x4000D01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public RTHandle rtResolve;

			[Token(Token = "0x4000D02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000D03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int msaa;
		}

		[Token(Token = "0x4000CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SwapBuffer m_A;

		[Token(Token = "0x4000CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SwapBuffer m_B;

		[Token(Token = "0x4000CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool m_AisBackBuffer;

		[Token(Token = "0x4000CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static RenderTextureDescriptor m_Desc;

		[Token(Token = "0x4000CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FilterMode m_FilterMode;

		[Token(Token = "0x4000CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool m_AllowMSAA;

		[Token(Token = "0x1700026A")]
		private unsafe ref SwapBuffer backBuffer
		{
			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x2D8CE84", Offset = "0x2D88E84", VA = "0x2D8CE84")]
			get
			{
				return ref *(SwapBuffer*)null;
			}
		}

		[Token(Token = "0x1700026B")]
		private unsafe ref SwapBuffer frontBuffer
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x2D8CEF4", Offset = "0x2D88EF4", VA = "0x2D8CEF4")]
			get
			{
				return ref *(SwapBuffer*)null;
			}
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x2D8CF64", Offset = "0x2D88F64", VA = "0x2D8CF64")]
		public RenderTargetBufferSystem(string name)
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x2D8D000", Offset = "0x2D89000", VA = "0x2D8D000")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x2D8D054", Offset = "0x2D89054", VA = "0x2D8D054")]
		public RTHandle PeekBackBuffer()
		{
			return null;
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x2D8D09C", Offset = "0x2D8909C", VA = "0x2D8D09C")]
		public RTHandle GetBackBuffer(CommandBuffer cmd)
		{
			return null;
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x2D8D2E0", Offset = "0x2D892E0", VA = "0x2D8D2E0")]
		public RTHandle GetFrontBuffer(CommandBuffer cmd)
		{
			return null;
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x2D8D36C", Offset = "0x2D8936C", VA = "0x2D8D36C")]
		public void Swap()
		{
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x2D8D0B4", Offset = "0x2D890B4", VA = "0x2D8D0B4")]
		private void ReAllocate(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x2D8D3CC", Offset = "0x2D893CC", VA = "0x2D8D3CC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x2D8D448", Offset = "0x2D89448", VA = "0x2D8D448")]
		public void SetCameraSettings(RenderTextureDescriptor desc, FilterMode filterMode)
		{
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x2D8D5B4", Offset = "0x2D895B4", VA = "0x2D8D5B4")]
		public RTHandle GetBufferA()
		{
			return null;
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x2D8D538", Offset = "0x2D89538", VA = "0x2D8D538")]
		public void EnableMSAA(bool enable)
		{
		}
	}
	[Token(Token = "0x2000210")]
	internal enum StencilUsage
	{
		[Token(Token = "0x4000D05")]
		UserMask = 15,
		[Token(Token = "0x4000D06")]
		StencilLight = 16,
		[Token(Token = "0x4000D07")]
		MaterialMask = 96,
		[Token(Token = "0x4000D08")]
		MaterialUnlit = 0,
		[Token(Token = "0x4000D09")]
		MaterialLit = 32,
		[Token(Token = "0x4000D0A")]
		MaterialSimpleLit = 64
	}
}
namespace UnityEngine.Rendering.Universal.UTess
{
	[Token(Token = "0x2000211")]
	[DebuggerTypeProxy(typeof(ArraySliceDebugView<>))]
	[DebuggerDisplay("Length = {Length}")]
	internal struct ArraySlice<T> : IEquatable<ArraySlice<T>> where T : struct
	{
		[Token(Token = "0x4000D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe byte* m_Buffer;

		[Token(Token = "0x4000D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int m_Stride;

		[Token(Token = "0x4000D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int m_Length;

		[Token(Token = "0x1700026C")]
		public T this[int index]
		{
			[Token(Token = "0x6000BEE")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000BEF")]
			[WriteAccessRequired]
			set
			{
			}
		}

		[Token(Token = "0x1700026D")]
		public int Stride
		{
			[Token(Token = "0x6000BF3")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700026E")]
		public int Length
		{
			[Token(Token = "0x6000BF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000BE7")]
		public ArraySlice(NativeArray<T> array, int start, int length)
		{
		}

		[Token(Token = "0x6000BE8")]
		public bool Equals(ArraySlice<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE9")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BEA")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000BEB")]
		public static bool operator ==(ArraySlice<T> left, ArraySlice<T> right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BEC")]
		public static bool operator !=(ArraySlice<T> left, ArraySlice<T> right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BED")]
		public unsafe static ArraySlice<T> ConvertExistingDataToArraySlice(void* dataPointer, int stride, int length)
		{
			return default(ArraySlice<T>);
		}

		[Token(Token = "0x6000BF0")]
		internal unsafe void* GetUnsafeReadOnlyPtr()
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)null);
		}

		[Token(Token = "0x6000BF1")]
		internal void CopyTo(T[] array)
		{
		}

		[Token(Token = "0x6000BF2")]
		internal T[] ToArray()
		{
			return null;
		}
	}
	[Token(Token = "0x2000212")]
	internal sealed class ArraySliceDebugView<T> where T : struct
	{
		[Token(Token = "0x4000D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ArraySlice<T> m_Slice;

		[Token(Token = "0x1700026F")]
		public T[] Items
		{
			[Token(Token = "0x6000BF6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BF5")]
		public ArraySliceDebugView(ArraySlice<T> slice)
		{
		}
	}
	[Token(Token = "0x2000213")]
	internal struct PlanarGraph
	{
		[Token(Token = "0x4000D0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly double kEpsilon;

		[Token(Token = "0x4000D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int kMaxIntersectionTolerance;

		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x2D8D628", Offset = "0x2D89628", VA = "0x2D8D628")]
		internal static void RemoveDuplicateEdges(ref NativeArray<int2> edges, ref int edgeCount, NativeArray<int> duplicates, int duplicateCount)
		{
		}

		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x2D8D7D0", Offset = "0x2D897D0", VA = "0x2D8D7D0")]
		internal static bool CheckCollinear(double2 a0, double2 a1, double2 b0, double2 b1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x2D8D8F0", Offset = "0x2D898F0", VA = "0x2D8D8F0")]
		internal static bool LineLineIntersection(double2 a0, double2 a1, double2 b0, double2 b1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x2D8DC94", Offset = "0x2D89C94", VA = "0x2D8DC94")]
		internal static bool LineLineIntersection(double2 p1, double2 p2, double2 p3, double2 p4, ref double2 result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x2D8DDFC", Offset = "0x2D89DFC", VA = "0x2D8DDFC")]
		internal static bool CalculateEdgeIntersections(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, ref NativeArray<int2> results, ref NativeArray<double2> intersects, ref int resultCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x2D8E184", Offset = "0x2D8A184", VA = "0x2D8E184")]
		internal static bool CalculateTJunctions(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, NativeArray<int2> results, ref int resultCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x2D8E330", Offset = "0x2D8A330", VA = "0x2D8E330")]
		internal static bool CutEdges(ref NativeArray<double2> points, ref int pointCount, ref NativeArray<int2> edges, ref int edgeCount, ref NativeArray<int2> tJunctions, ref int tJunctionCount, NativeArray<int2> intersections, NativeArray<double2> intersects, int intersectionCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x2D8E5B4", Offset = "0x2D8A5B4", VA = "0x2D8E5B4")]
		internal static void RemoveDuplicatePoints(ref NativeArray<double2> points, ref int pointCount, ref NativeArray<int> duplicates, ref int duplicateCount, Allocator allocator)
		{
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x2D8E88C", Offset = "0x2D8A88C", VA = "0x2D8E88C")]
		internal static bool Validate(Allocator allocator, NativeArray<float2> inputPoints, int pointCount, NativeArray<int2> inputEdges, int edgeCount, ref NativeArray<float2> outputPoints, ref int outputPointCount, ref NativeArray<int2> outputEdges, ref int outputEdgeCount)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000214")]
	internal struct Refinery
	{
		[Token(Token = "0x4000D11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float kMinAreaFactor;

		[Token(Token = "0x4000D12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly float kMaxAreaFactor;

		[Token(Token = "0x4000D13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int kMaxSteinerCount;

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x2D8EE64", Offset = "0x2D8AE64", VA = "0x2D8EE64")]
		private static bool RequiresRefining(UTriangle tri, float maxArea)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x2D8EE74", Offset = "0x2D8AE74", VA = "0x2D8EE74")]
		private static void FetchEncroachedSegments(NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<UEncroachingSegment> encroach, ref int encroachCount, UCircle c)
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x2D8F040", Offset = "0x2D8B040", VA = "0x2D8F040")]
		private static void InsertVertex(ref NativeArray<float2> pgPoints, ref int pgPointCount, float2 newVertex, ref int nid)
		{
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x2D8F060", Offset = "0x2D8B060", VA = "0x2D8F060")]
		private static int FindSegment(NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, UEncroachingSegment es)
		{
			return default(int);
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x2D8F0E4", Offset = "0x2D8B0E4", VA = "0x2D8F0E4")]
		private static void SplitSegments(ref NativeArray<float2> pgPoints, ref int pgPointCount, ref NativeArray<int2> pgEdges, ref int pgEdgeCount, UEncroachingSegment es)
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x2D8F2B8", Offset = "0x2D8B2B8", VA = "0x2D8F2B8")]
		internal static bool Condition(Allocator allocator, float factorArea, float targetArea, ref NativeArray<float2> pgPoints, ref int pgPointCount, ref NativeArray<int2> pgEdges, ref int pgEdgeCount, ref NativeArray<float2> vertices, ref int vertexCount, ref NativeArray<int> indices, ref int indexCount, ref float maxArea)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000215")]
	internal struct Smoothen
	{
		[Token(Token = "0x4000D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float kMaxAreaTolerance;

		[Token(Token = "0x4000D15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly float kMaxEdgeTolerance;

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x2D8F994", Offset = "0x2D8B994", VA = "0x2D8F994")]
		private static void RefineEdges(ref NativeArray<int4> refinedEdges, ref NativeArray<int4> delaEdges, ref int delaEdgeCount, ref NativeArray<int4> voronoiEdges)
		{
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x2D8FB18", Offset = "0x2D8BB18", VA = "0x2D8FB18")]
		private static void GetAffectingEdges(int pointIndex, NativeArray<int4> edges, int edgeCount, ref NativeArray<int> resultSet, ref NativeArray<int> checkSet, ref int resultCount)
		{
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x2D8FB78", Offset = "0x2D8BB78", VA = "0x2D8FB78")]
		private static void CentroidByPoints(int triIndex, NativeArray<UTriangle> triangles, ref NativeArray<int> centroidTris, ref int centroidCount, ref float2 aggregate, ref float2 point)
		{
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x2D8FBE4", Offset = "0x2D8BBE4", VA = "0x2D8FBE4")]
		private static void CentroidByPolygon(int4 e, NativeArray<UTriangle> triangles, ref float2 centroid, ref float area, ref float distance)
		{
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x2D8FCB8", Offset = "0x2D8BCB8", VA = "0x2D8FCB8")]
		private static bool ConnectTriangles(ref NativeArray<int4> connectedTri, ref NativeArray<int> affectEdges, ref NativeArray<int> checkSet, NativeArray<int4> voronoiEdges, int triangleCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x2D8FDC0", Offset = "0x2D8BDC0", VA = "0x2D8FDC0")]
		internal static bool Condition(Allocator allocator, ref NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<float2> vertices, ref int vertexCount, ref NativeArray<int> indices, ref int indexCount)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000216")]
	internal struct Tessellator
	{
		[Token(Token = "0x2000217")]
		private struct TestHullPointL : ICondition2<UHull, float2>
		{
			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x2D93024", Offset = "0x2D8F024", VA = "0x2D93024", Slot = "4")]
			public bool Test(UHull h, float2 p, ref float t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000218")]
		private struct TestHullPointU : ICondition2<UHull, float2>
		{
			[Token(Token = "0x6000C29")]
			[Address(RVA = "0x2D930D4", Offset = "0x2D8F0D4", VA = "0x2D930D4", Slot = "4")]
			public bool Test(UHull h, float2 p, ref float t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000219")]
		private struct TestHullEventLe : ICondition2<UHull, UEvent>
		{
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x2D93184", Offset = "0x2D8F184", VA = "0x2D93184", Slot = "4")]
			public bool Test(UHull h, UEvent p, ref float t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200021A")]
		private struct TestHullEventE : ICondition2<UHull, UEvent>
		{
			[Token(Token = "0x6000C2B")]
			[Address(RVA = "0x2D931DC", Offset = "0x2D8F1DC", VA = "0x2D931DC", Slot = "4")]
			public bool Test(UHull h, UEvent p, ref float t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200021B")]
		private struct TestEdgePointE : ICondition2<int2, int2>
		{
			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x2D93234", Offset = "0x2D8F234", VA = "0x2D93234", Slot = "4")]
			public bool Test(int2 h, int2 p, ref float t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200021C")]
		private struct TestCellE : ICondition2<int3, int3>
		{
			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0x2D9326C", Offset = "0x2D8F26C", VA = "0x2D9326C", Slot = "4")]
			public bool Test(int3 h, int3 p, ref float t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000D16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private NativeArray<int2> m_Edges;

		[Token(Token = "0x4000D17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NativeArray<UStar> m_Stars;

		[Token(Token = "0x4000D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private NativeArray<int3> m_Cells;

		[Token(Token = "0x4000D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_CellCount;

		[Token(Token = "0x4000D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NativeArray<int> m_ILArray;

		[Token(Token = "0x4000D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private NativeArray<int> m_IUArray;

		[Token(Token = "0x4000D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private NativeArray<int> m_SPArray;

		[Token(Token = "0x4000D1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_NumEdges;

		[Token(Token = "0x4000D1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int m_NumHulls;

		[Token(Token = "0x4000D1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_NumPoints;

		[Token(Token = "0x4000D20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_StarCount;

		[Token(Token = "0x4000D21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private NativeArray<int> m_Flags;

		[Token(Token = "0x4000D22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private NativeArray<int> m_Neighbors;

		[Token(Token = "0x4000D23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private NativeArray<int> m_Constraints;

		[Token(Token = "0x4000D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Allocator m_Allocator;

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x2D904D0", Offset = "0x2D8C4D0", VA = "0x2D904D0")]
		private static float FindSplit(UHull hull, UEvent edge)
		{
			return default(float);
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x2D9062C", Offset = "0x2D8C62C", VA = "0x2D9062C")]
		private void SetAllocator(Allocator allocator)
		{
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x2D90634", Offset = "0x2D8C634", VA = "0x2D90634")]
		private bool AddPoint(NativeArray<UHull> hulls, int hullCount, NativeArray<float2> points, float2 p, int idx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x2D909F8", Offset = "0x2D8C9F8", VA = "0x2D909F8")]
		private static void InsertHull(NativeArray<UHull> Hulls, int Pos, ref int Count, UHull Value)
		{
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x2D90A94", Offset = "0x2D8CA94", VA = "0x2D90A94")]
		private static void EraseHull(NativeArray<UHull> Hulls, int Pos, ref int Count)
		{
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x2D90AFC", Offset = "0x2D8CAFC", VA = "0x2D90AFC")]
		private bool SplitHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x2D90DF8", Offset = "0x2D8CDF8", VA = "0x2D90DF8")]
		private bool MergeHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x2D90FF0", Offset = "0x2D8CFF0", VA = "0x2D90FF0")]
		private static void InsertUniqueEdge(NativeArray<int2> edges, int2 e, ref int edgeCount)
		{
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x2D91058", Offset = "0x2D8D058", VA = "0x2D91058")]
		private void PrepareDelaunay(NativeArray<int2> edges, int edgeCount)
		{
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x2D914A8", Offset = "0x2D8D4A8", VA = "0x2D914A8")]
		private int OppositeOf(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x2D91568", Offset = "0x2D8D568", VA = "0x2D91568")]
		private int FindConstraint(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x2D91604", Offset = "0x2D8D604", VA = "0x2D91604")]
		private void AddTriangle(int i, int j, int k)
		{
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x2D917AC", Offset = "0x2D8D7AC", VA = "0x2D917AC")]
		private void RemovePair(int r, int j, int k)
		{
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x2D91908", Offset = "0x2D8D908", VA = "0x2D91908")]
		private void RemoveTriangle(int i, int j, int k)
		{
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x2D9195C", Offset = "0x2D8D95C", VA = "0x2D9195C")]
		private void EdgeFlip(int i, int j)
		{
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x2D919EC", Offset = "0x2D8D9EC", VA = "0x2D919EC")]
		private bool Flip(NativeArray<float2> points, ref NativeArray<int> stack, ref int stackCount, int a, int b, int x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x2D91B6C", Offset = "0x2D8DB6C", VA = "0x2D91B6C")]
		private NativeArray<int3> GetCells(ref int count)
		{
			return default(NativeArray<int3>);
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x2D91CC4", Offset = "0x2D8DCC4", VA = "0x2D91CC4")]
		internal bool ApplyDelaunay(NativeArray<float2> points, NativeArray<int2> edges)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x2D921C4", Offset = "0x2D8E1C4", VA = "0x2D921C4")]
		private int FindNeighbor(NativeArray<int3> cells, int count, int a, int b, int c)
		{
			return default(int);
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x2D922D0", Offset = "0x2D8E2D0", VA = "0x2D922D0")]
		private NativeArray<int3> Constrain(ref int count)
		{
			return default(NativeArray<int3>);
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x2D9273C", Offset = "0x2D8E73C", VA = "0x2D9273C")]
		internal NativeArray<int3> RemoveExterior(ref int cellCount)
		{
			return default(NativeArray<int3>);
		}

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x2D92854", Offset = "0x2D8E854", VA = "0x2D92854")]
		internal NativeArray<int3> RemoveInterior(int cellCount)
		{
			return default(NativeArray<int3>);
		}

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x2D9295C", Offset = "0x2D8E95C", VA = "0x2D9295C")]
		internal bool Triangulate(NativeArray<float2> points, int pointCount, NativeArray<int2> edges, int edgeCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x2D8F74C", Offset = "0x2D8B74C", VA = "0x2D8F74C")]
		internal static bool Tessellate(Allocator allocator, NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<float2> outputVertices, ref int vertexCount, ref NativeArray<int> outputIndices, ref int indexCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x2D92EBC", Offset = "0x2D8EEBC", VA = "0x2D92EBC")]
		internal void Cleanup()
		{
		}
	}
	[Token(Token = "0x200021D")]
	internal enum UEventType
	{
		[Token(Token = "0x4000D26")]
		EVENT_POINT,
		[Token(Token = "0x4000D27")]
		EVENT_END,
		[Token(Token = "0x4000D28")]
		EVENT_START
	}
	[Token(Token = "0x200021E")]
	internal struct UEvent
	{
		[Token(Token = "0x4000D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float2 a;

		[Token(Token = "0x4000D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float2 b;

		[Token(Token = "0x4000D2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idx;

		[Token(Token = "0x4000D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int type;
	}
	[Token(Token = "0x200021F")]
	internal struct UHull
	{
		[Token(Token = "0x4000D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float2 a;

		[Token(Token = "0x4000D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float2 b;

		[Token(Token = "0x4000D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idx;

		[Token(Token = "0x4000D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ArraySlice<int> ilarray;

		[Token(Token = "0x4000D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ilcount;

		[Token(Token = "0x4000D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ArraySlice<int> iuarray;

		[Token(Token = "0x4000D33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int iucount;
	}
	[Token(Token = "0x2000220")]
	internal struct UStar
	{
		[Token(Token = "0x4000D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ArraySlice<int> points;

		[Token(Token = "0x4000D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int pointCount;
	}
	[Token(Token = "0x2000221")]
	internal struct UBounds
	{
		[Token(Token = "0x4000D36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double2 min;

		[Token(Token = "0x4000D37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double2 max;
	}
	[Token(Token = "0x2000222")]
	internal struct UCircle
	{
		[Token(Token = "0x4000D38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float2 center;

		[Token(Token = "0x4000D39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float radius;
	}
	[Token(Token = "0x2000223")]
	internal struct UTriangle
	{
		[Token(Token = "0x4000D3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float2 va;

		[Token(Token = "0x4000D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float2 vb;

		[Token(Token = "0x4000D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float2 vc;

		[Token(Token = "0x4000D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UCircle c;

		[Token(Token = "0x4000D3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float area;

		[Token(Token = "0x4000D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int3 indices;
	}
	[Token(Token = "0x2000224")]
	internal struct UEncroachingSegment
	{
		[Token(Token = "0x4000D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float2 a;

		[Token(Token = "0x4000D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float2 b;

		[Token(Token = "0x4000D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int index;
	}
	[Token(Token = "0x2000225")]
	internal interface ICondition2<in T, in U>
	{
		[Token(Token = "0x6000C2E")]
		bool Test(T x, U y, ref float t);
	}
	[Token(Token = "0x2000226")]
	internal struct XCompare : IComparer<double>
	{
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x2D932AC", Offset = "0x2D8F2AC", VA = "0x2D932AC", Slot = "4")]
		public int Compare(double a, double b)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000227")]
	internal struct IntersectionCompare : IComparer<int2>
	{
		[Token(Token = "0x4000D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NativeArray<double2> points;

		[Token(Token = "0x4000D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NativeArray<int2> edges;

		[Token(Token = "0x4000D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public unsafe fixed double xvasort[4];

		[Token(Token = "0x4000D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public unsafe fixed double xvbsort[4];

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x2D932BC", Offset = "0x2D8F2BC", VA = "0x2D932BC", Slot = "4")]
		public int Compare(int2 a, int2 b)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200022A")]
	internal struct TessEventCompare : IComparer<UEvent>
	{
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x2CFBE18", Offset = "0x2CF7E18", VA = "0x2CFBE18", Slot = "4")]
		public int Compare(UEvent a, UEvent b)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200022B")]
	internal struct TessEdgeCompare : IComparer<int2>
	{
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x2CFBF4C", Offset = "0x2CF7F4C", VA = "0x2CFBF4C", Slot = "4")]
		public int Compare(int2 a, int2 b)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200022C")]
	internal struct TessCellCompare : IComparer<int3>
	{
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x2CFBF64", Offset = "0x2CF7F64", VA = "0x2CFBF64", Slot = "4")]
		public int Compare(int3 a, int3 b)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200022D")]
	internal struct TessJunctionCompare : IComparer<int2>
	{
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x2CFBF88", Offset = "0x2CF7F88", VA = "0x2CFBF88", Slot = "4")]
		public int Compare(int2 a, int2 b)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200022E")]
	internal struct DelaEdgeCompare : IComparer<int4>
	{
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x2CFBFA0", Offset = "0x2CF7FA0", VA = "0x2CFBFA0", Slot = "4")]
		public int Compare(int4 a, int4 b)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200022F")]
	internal struct TessLink
	{
		[Token(Token = "0x4000D49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal NativeArray<int> roots;

		[Token(Token = "0x4000D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal NativeArray<int> ranks;

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x2CFBFD4", Offset = "0x2CF7FD4", VA = "0x2CFBFD4")]
		internal static TessLink CreateLink(int count, Allocator allocator)
		{
			return default(TessLink);
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x2CFC0A0", Offset = "0x2CF80A0", VA = "0x2CFC0A0")]
		internal static void DestroyLink(TessLink link)
		{
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x2CFC0F4", Offset = "0x2CF80F4", VA = "0x2CFC0F4")]
		internal int Find(int x)
		{
			return default(int);
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x2CFC12C", Offset = "0x2CF812C", VA = "0x2CFC12C")]
		internal void Link(int x, int y)
		{
		}
	}
	[Token(Token = "0x2000230")]
	internal struct ModuleHandle
	{
		[Token(Token = "0x4000D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly int kMaxArea;

		[Token(Token = "0x4000D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal static readonly int kMaxEdgeCount;

		[Token(Token = "0x4000D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly int kMaxIndexCount;

		[Token(Token = "0x4000D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal static readonly int kMaxVertexCount;

		[Token(Token = "0x4000D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly int kMaxTriangleCount;

		[Token(Token = "0x4000D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal static readonly int kMaxRefineIterations;

		[Token(Token = "0x4000D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static readonly int kMaxSmoothenIterations;

		[Token(Token = "0x4000D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal static readonly float kIncrementAreaFactor;

		[Token(Token = "0x6000C3A")]
		internal static void Copy<T>(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) where T : struct
		{
		}

		[Token(Token = "0x6000C3B")]
		internal static void Copy<T>(NativeArray<T> src, NativeArray<T> dst, int length) where T : struct
		{
		}

		[Token(Token = "0x6000C3C")]
		internal unsafe static void InsertionSort<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
		{
		}

		[Token(Token = "0x6000C3D")]
		internal static int GetLower<T, U, X>(NativeArray<T> values, int count, U check, X condition) where T : struct where U : struct where X : ICondition2<T, U>
		{
			return default(int);
		}

		[Token(Token = "0x6000C3E")]
		internal static int GetUpper<T, U, X>(NativeArray<T> values, int count, U check, X condition) where T : struct where U : struct where X : ICondition2<T, U>
		{
			return default(int);
		}

		[Token(Token = "0x6000C3F")]
		internal static int GetEqual<T, U, X>(NativeArray<T> values, int count, U check, X condition) where T : struct where U : struct where X : ICondition2<T, U>
		{
			return default(int);
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x2CFBF18", Offset = "0x2CF7F18", VA = "0x2CFBF18")]
		internal static float OrientFast(float2 a, float2 b, float2 c)
		{
			return default(float);
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x2CFC1D4", Offset = "0x2CF81D4", VA = "0x2CFC1D4")]
		internal static double OrientFastDouble(double2 a, double2 b, double2 c)
		{
			return default(double);
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x2CFC20C", Offset = "0x2CF820C", VA = "0x2CFC20C")]
		internal static UCircle CircumCircle(UTriangle tri)
		{
			return default(UCircle);
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x2CFC304", Offset = "0x2CF8304", VA = "0x2CFC304")]
		internal static bool IsInsideCircle(UCircle c, float2 v)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x2CFC394", Offset = "0x2CF8394", VA = "0x2CFC394")]
		internal static float TriangleArea(float2 va, float2 vb, float2 vc)
		{
			return default(float);
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x2CFC3BC", Offset = "0x2CF83BC", VA = "0x2CFC3BC")]
		internal static float Sign(float2 p1, float2 p2, float2 p3)
		{
			return default(float);
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x2CFC3DC", Offset = "0x2CF83DC", VA = "0x2CFC3DC")]
		internal static bool IsInsideTriangle(float2 pt, float2 v1, float2 v2, float2 v3)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x2CFC4DC", Offset = "0x2CF84DC", VA = "0x2CFC4DC")]
		internal static bool IsInsideTriangleApproximate(float2 pt, float2 v1, float2 v2, float2 v3)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x2CFC5EC", Offset = "0x2CF85EC", VA = "0x2CFC5EC")]
		internal static bool IsInsideCircle(float2 a, float2 b, float2 c, float2 p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x2CFC774", Offset = "0x2CF8774", VA = "0x2CFC774")]
		internal static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea)
		{
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x2CFC934", Offset = "0x2CF8934", VA = "0x2CFC934")]
		internal static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea, ref float maxEdge, ref float avgEdge, ref float minEdge)
		{
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x2CFCCCC", Offset = "0x2CF8CCC", VA = "0x2CFCCCC")]
		internal static void BuildTrianglesAndEdges(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref NativeArray<int4> delaEdges, ref int delaEdgeCount, ref float maxArea, ref float avgArea, ref float minArea)
		{
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x2CFCF30", Offset = "0x2CF8F30", VA = "0x2CFCF30")]
		private static void CopyGraph(NativeArray<float2> srcPoints, int srcPointCount, ref NativeArray<float2> dstPoints, ref int dstPointCount, NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2> dstEdges, ref int dstEdgeCount)
		{
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x2CFD02C", Offset = "0x2CF902C", VA = "0x2CFD02C")]
		private static void CopyGeometry(NativeArray<int> srcIndices, int srcIndexCount, ref NativeArray<int> dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2> dstVertices, ref int dstVertexCount)
		{
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x2CFD128", Offset = "0x2CF9128", VA = "0x2CFD128")]
		private static void TransferOutput(NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2> dstEdges, ref int dstEdgeCount, NativeArray<int> srcIndices, int srcIndexCount, ref NativeArray<int> dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2> dstVertices, ref int dstVertexCount)
		{
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x2CFD274", Offset = "0x2CF9274", VA = "0x2CFD274")]
		private static void GraphConditioner(NativeArray<float2> points, ref NativeArray<float2> pgPoints, ref int pgPointCount, ref NativeArray<int2> pgEdges, ref int pgEdgeCount, bool resetTopology)
		{
		}

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x2CFD48C", Offset = "0x2CF948C", VA = "0x2CFD48C")]
		private static void Reorder(int startVertexCount, int index, ref NativeArray<int> indices, ref int indexCount, ref NativeArray<float2> vertices, ref int vertexCount)
		{
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x2CFD504", Offset = "0x2CF9504", VA = "0x2CFD504")]
		internal static void VertexCleanupConditioner(int startVertexCount, ref NativeArray<int> indices, ref int indexCount, ref NativeArray<float2> vertices, ref int vertexCount)
		{
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x2CFD5A8", Offset = "0x2CF95A8", VA = "0x2CFD5A8")]
		public static float4 ConvexQuad(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount)
		{
			return default(float4);
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x2CFD7A8", Offset = "0x2CF97A8", VA = "0x2CFD7A8")]
		public static float4 Tessellate(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount)
		{
			return default(float4);
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x2CFDB7C", Offset = "0x2CF9B7C", VA = "0x2CFDB7C")]
		public static float4 Subdivide(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount, float areaFactor, float targetArea, int refineIterations, int smoothenIterations)
		{
			return default(float4);
		}
	}
}
