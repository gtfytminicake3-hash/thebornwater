using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Jobs;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;
using UnityEngine.Rendering.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;
using UnityEngine.UI;
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
		[Address(RVA = "0x2C5EAE4", Offset = "0x2C5AAE4", VA = "0x2C5EAE4")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2C5EAEC", Offset = "0x2C5AAEC", VA = "0x2C5EAEC")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000005")]
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
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2C5EAF4", Offset = "0x2C5AAF4", VA = "0x2C5EAF4")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2C5EBB0", Offset = "0x2C5ABB0", VA = "0x2C5EBB0")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace UnityEngine
{
	[Token(Token = "0x2000006")]
	[AddComponentMenu("Rendering/Light Anchor")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class LightAnchor : MonoBehaviour
	{
		[Token(Token = "0x2000007")]
		public enum UpDirection
		{
			[Token(Token = "0x4000011")]
			World,
			[Token(Token = "0x4000012")]
			Local
		}

		[Token(Token = "0x2000008")]
		private struct Axes
		{
			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 up;

			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 right;

			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 forward;
		}

		[Token(Token = "0x4000006")]
		private const float k_ArcRadius = 5f;

		[Token(Token = "0x4000007")]
		private const float k_AxisLength = 10f;

		[Token(Token = "0x4000008")]
		internal const float k_MaxDistance = 10000f;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Min(0f)]
		private float m_Distance;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpDirection m_FrameSpace;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_AnchorPositionOverride;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 m_AnchorPositionOffset;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_Yaw;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_Pitch;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_Roll;

		[Token(Token = "0x17000001")]
		public float yaw
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2C5EBB8", Offset = "0x2C5ABB8", VA = "0x2C5EBB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2C5EBC0", Offset = "0x2C5ABC0", VA = "0x2C5EBC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float pitch
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2C5EC2C", Offset = "0x2C5AC2C", VA = "0x2C5EC2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2C5EC34", Offset = "0x2C5AC34", VA = "0x2C5EC34")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float roll
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2C5EC6C", Offset = "0x2C5AC6C", VA = "0x2C5EC6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2C5EC74", Offset = "0x2C5AC74", VA = "0x2C5EC74")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public float distance
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2C5ECAC", Offset = "0x2C5ACAC", VA = "0x2C5ECAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2C5ECB4", Offset = "0x2C5ACB4", VA = "0x2C5ECB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public UpDirection frameSpace
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2C5ECD8", Offset = "0x2C5ACD8", VA = "0x2C5ECD8")]
			get
			{
				return default(UpDirection);
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2C5ECE0", Offset = "0x2C5ACE0", VA = "0x2C5ECE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Vector3 anchorPosition
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2C5ECE8", Offset = "0x2C5ACE8", VA = "0x2C5ECE8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000007")]
		public Transform anchorPositionOverride
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2C5EDF4", Offset = "0x2C5ADF4", VA = "0x2C5EDF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2C5EDFC", Offset = "0x2C5ADFC", VA = "0x2C5EDFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Vector3 anchorPositionOffset
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2C5EE04", Offset = "0x2C5AE04", VA = "0x2C5EE04")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2C5EE10", Offset = "0x2C5AE10", VA = "0x2C5EE10")]
			set
			{
			}
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2C5EBF8", Offset = "0x2C5ABF8", VA = "0x2C5EBF8")]
		public static float NormalizeAngleDegree(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2C5EE1C", Offset = "0x2C5AE1C", VA = "0x2C5EE1C")]
		public void SynchronizeOnTransform(Camera camera)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2C5FB08", Offset = "0x2C5BB08", VA = "0x2C5FB08")]
		public void UpdateTransform(Camera camera, Vector3 anchor)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2C5F2E8", Offset = "0x2C5B2E8", VA = "0x2C5F2E8")]
		private Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor)
		{
			return default(Axes);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2C5FE48", Offset = "0x2C5BE48", VA = "0x2C5FE48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2C5FF48", Offset = "0x2C5BF48", VA = "0x2C5FF48")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2C5FB70", Offset = "0x2C5BB70", VA = "0x2C5FB70")]
		private void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2C60018", Offset = "0x2C5C018", VA = "0x2C60018")]
		public LightAnchor()
		{
		}
	}
}
namespace UnityEngine.Experimental.Rendering
{
	[Token(Token = "0x2000009")]
	public static class XRBuiltinShaderConstants
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int unity_StereoCameraProjection;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int unity_StereoCameraInvProjection;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int unity_StereoMatrixV;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int unity_StereoMatrixInvV;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int unity_StereoMatrixP;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int unity_StereoMatrixInvP;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int unity_StereoMatrixVP;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int unity_StereoMatrixInvVP;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int unity_StereoWorldSpaceCameraPos;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Matrix4x4[] s_cameraProjMatrix;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Matrix4x4[] s_invCameraProjMatrix;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Matrix4x4[] s_viewMatrix;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Matrix4x4[] s_invViewMatrix;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Matrix4x4[] s_projMatrix;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Matrix4x4[] s_invProjMatrix;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Matrix4x4[] s_viewProjMatrix;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Matrix4x4[] s_invViewProjMatrix;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static Vector4[] s_worldSpaceCameraPos;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2C60020", Offset = "0x2C5C020", VA = "0x2C60020")]
		public static void UpdateBuiltinShaderConstants(Matrix4x4 viewMatrix, Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2C60460", Offset = "0x2C5C460", VA = "0x2C60460")]
		public static void SetBuiltinShaderConstants(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2C605B0", Offset = "0x2C5C5B0", VA = "0x2C605B0")]
		public static void Update(XRPass xrPass, CommandBuffer cmd, bool renderIntoTexture)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class XRLayout
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<(Camera, XRPass)> m_ActivePasses;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2C61058", Offset = "0x2C5D058", VA = "0x2C61058")]
		public void AddCamera(Camera camera, bool enableXR)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2C61990", Offset = "0x2C5D990", VA = "0x2C61990")]
		public void ReconfigurePass(XRPass xrPass, Camera camera)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2C61CB0", Offset = "0x2C5DCB0", VA = "0x2C61CB0")]
		public List<(Camera, XRPass)> GetActivePasses()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2C61894", Offset = "0x2C5D894", VA = "0x2C61894")]
		internal void AddPass(Camera camera, XRPass xrPass)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2C61CB8", Offset = "0x2C5DCB8", VA = "0x2C61CB8")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2C61DE4", Offset = "0x2C5DDE4", VA = "0x2C61DE4")]
		internal void LogDebugInfo()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2C62318", Offset = "0x2C5E318", VA = "0x2C62318")]
		public XRLayout()
		{
		}
	}
	[Token(Token = "0x200000B")]
	internal static class XRMirrorView
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MaterialPropertyBlock s_MirrorViewMaterialProperty;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ProfilingSampler k_MirrorViewProfilingSampler;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int k_SourceTex;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int k_SourceTexArraySlice;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int k_ScaleBias;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int k_ScaleBiasRt;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int k_SRGBRead;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int k_SRGBWrite;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int k_MaxNits;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly int k_SourceMaxNits;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly int k_SourceHDREncoding;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static readonly int k_ColorTransform;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2C62394", Offset = "0x2C5E394", VA = "0x2C62394")]
		internal static void RenderMirrorView(CommandBuffer cmd, Camera camera, Material mat, XRDisplaySubsystem display)
		{
		}
	}
	[Token(Token = "0x200000C")]
	internal class XROcclusionMesh
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private XRPass m_Pass;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Mesh m_CombinedMesh;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CombinedMeshHashCode;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilingSampler k_OcclusionMeshProfilingSampler;

		[Token(Token = "0x17000009")]
		internal bool hasValidOcclusionMesh
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2C6334C", Offset = "0x2C5F34C", VA = "0x2C6334C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2C6331C", Offset = "0x2C5F31C", VA = "0x2C6331C")]
		internal XROcclusionMesh(XRPass xrPass)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2C63344", Offset = "0x2C5F344", VA = "0x2C63344")]
		internal void SetMaterial(Material mat)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2C634F8", Offset = "0x2C5F4F8", VA = "0x2C634F8")]
		internal void RenderOcclusionMesh(CommandBuffer cmd, float occlusionMeshScale, bool yFlip = false)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2C63B98", Offset = "0x2C5FB98", VA = "0x2C63B98")]
		internal void UpdateCombinedMesh()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2C63404", Offset = "0x2C5F404", VA = "0x2C63404")]
		private bool IsOcclusionMeshSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2C63C60", Offset = "0x2C5FC60", VA = "0x2C63C60")]
		private bool TryGetOcclusionMeshCombinedHashCode(out int hashCode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2C63D54", Offset = "0x2C5FD54", VA = "0x2C63D54")]
		private void CreateOcclusionMeshCombined()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public struct XRPassCreateInfo
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal RenderTargetIdentifier renderTarget;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal RenderTextureDescriptor renderTargetDesc;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal ScriptableCullingParameters cullingParameters;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x690")]
		internal Material occlusionMeshMaterial;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x698")]
		internal float occlusionMeshScale;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
		internal IntPtr foveatedRenderingInfo;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
		internal int multipassId;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6AC")]
		internal int cullingPassId;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
		internal bool copyDepth;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
		internal XRDisplaySubsystem.XRRenderPass xrSdkRenderPass;
	}
	[Token(Token = "0x200000E")]
	public class XRPass
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<XRView> m_Views;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly XROcclusionMesh m_OcclusionMesh;

		[Token(Token = "0x1700000A")]
		public bool enabled
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2C60BE4", Offset = "0x2C5CBE4", VA = "0x2C60BE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool supportsFoveatedRendering
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2C644CC", Offset = "0x2C604CC", VA = "0x2C644CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public bool copyDepth
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2C6458C", Offset = "0x2C6058C", VA = "0x2C6458C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2C64594", Offset = "0x2C60594", VA = "0x2C64594")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public int multipassId
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2C6459C", Offset = "0x2C6059C", VA = "0x2C6459C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2C645A4", Offset = "0x2C605A4", VA = "0x2C645A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public int cullingPassId
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2C645AC", Offset = "0x2C605AC", VA = "0x2C645AC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2C645B4", Offset = "0x2C605B4", VA = "0x2C645B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public RenderTargetIdentifier renderTarget
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2C645BC", Offset = "0x2C605BC", VA = "0x2C645BC")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2C645D0", Offset = "0x2C605D0", VA = "0x2C645D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public RenderTextureDescriptor renderTargetDesc
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2C645E4", Offset = "0x2C605E4", VA = "0x2C645E4")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2C64604", Offset = "0x2C60604", VA = "0x2C64604")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public ScriptableCullingParameters cullingParams
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2C64624", Offset = "0x2C60624", VA = "0x2C64624")]
			[CompilerGenerated]
			get
			{
				return default(ScriptableCullingParameters);
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2C64634", Offset = "0x2C60634", VA = "0x2C64634")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public int viewCount
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2C622D0", Offset = "0x2C5E2D0", VA = "0x2C622D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000013")]
		public bool singlePassEnabled
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2C60D14", Offset = "0x2C5CD14", VA = "0x2C60D14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		public IntPtr foveatedRenderingInfo
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2C64640", Offset = "0x2C60640", VA = "0x2C64640")]
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x2C64648", Offset = "0x2C60648", VA = "0x2C64648")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public bool isHDRDisplayOutputActive
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2C64650", Offset = "0x2C60650", VA = "0x2C64650")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public ColorGamut hdrDisplayOutputColorGamut
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2C646FC", Offset = "0x2C606FC", VA = "0x2C646FC")]
			get
			{
				return default(ColorGamut);
			}
		}

		[Token(Token = "0x17000017")]
		public HDROutputUtils.HDRDisplayInformation hdrDisplayOutputInformation
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2C647A8", Offset = "0x2C607A8", VA = "0x2C647A8")]
			get
			{
				return default(HDROutputUtils.HDRDisplayInformation);
			}
		}

		[Token(Token = "0x17000018")]
		public float occlusionMeshScale
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2C649CC", Offset = "0x2C609CC", VA = "0x2C649CC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2C649D4", Offset = "0x2C609D4", VA = "0x2C649D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool hasValidOcclusionMesh
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2C649DC", Offset = "0x2C609DC", VA = "0x2C649DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2C64130", Offset = "0x2C60130", VA = "0x2C64130")]
		public XRPass()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2C641E4", Offset = "0x2C601E4", VA = "0x2C641E4")]
		public static XRPass CreateDefault(XRPassCreateInfo createInfo)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2C64460", Offset = "0x2C60460", VA = "0x2C64460", Slot = "4")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2C60C88", Offset = "0x2C5CC88", VA = "0x2C60C88")]
		public Matrix4x4 GetProjMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2C60BFC", Offset = "0x2C5CBFC", VA = "0x2C60BFC")]
		public Matrix4x4 GetViewMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2C621F4", Offset = "0x2C5E1F4", VA = "0x2C621F4")]
		public Rect GetViewport(int viewIndex = 0)
		{
			return default(Rect);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2C6348C", Offset = "0x2C5F48C", VA = "0x2C6348C")]
		public Mesh GetOcclusionMesh(int viewIndex = 0)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2C62264", Offset = "0x2C5E264", VA = "0x2C62264")]
		public int GetTextureArraySlice(int viewIndex = 0)
		{
			return default(int);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2C639A0", Offset = "0x2C5F9A0", VA = "0x2C639A0")]
		public void StartSinglePass(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2C638D0", Offset = "0x2C5F8D0", VA = "0x2C638D0")]
		public void StopSinglePass(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2C649F0", Offset = "0x2C609F0", VA = "0x2C649F0")]
		public void RenderOcclusionMesh(CommandBuffer cmd, bool renderIntoTexture = false)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2C64A18", Offset = "0x2C60A18", VA = "0x2C64A18")]
		public Vector4 ApplyXRViewCenterOffset(Vector2 center)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2C64B5C", Offset = "0x2C60B5C", VA = "0x2C64B5C")]
		internal void AssignView(int viewId, XRView xrView)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2C64C48", Offset = "0x2C60C48", VA = "0x2C64C48")]
		internal void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2C61C9C", Offset = "0x2C5DC9C", VA = "0x2C61C9C")]
		internal void UpdateCombinedOcclusionMesh()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2C642BC", Offset = "0x2C602BC", VA = "0x2C642BC")]
		public void InitBase(XRPassCreateInfo createInfo)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2C64CD4", Offset = "0x2C60CD4", VA = "0x2C64CD4")]
		internal void AddView(XRView xrView)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public static class XRSystem
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static XRLayout s_Layout;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Func<XRPassCreateInfo, XRPass> s_PassAllocator;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<XRDisplaySubsystem> s_DisplayList;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static XRDisplaySubsystem s_Display;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static MSAASamples s_MSAASamples;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Material s_OcclusionMeshMaterial;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Material s_MirrorViewMaterial;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Action<XRLayout, Camera> s_LayoutOverride;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly XRPass emptyPass;

		[Token(Token = "0x1700001A")]
		public static bool displayActive
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2C61204", Offset = "0x2C5D204", VA = "0x2C61204")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public static bool isHDRDisplayOutputActive
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2C64F24", Offset = "0x2C60F24", VA = "0x2C64F24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public static bool singlePassAllowed
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2C64FD8", Offset = "0x2C60FD8", VA = "0x2C64FD8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x2C65030", Offset = "0x2C61030", VA = "0x2C65030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public static FoveatedRenderingCaps foveatedRenderingCaps
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x2C65090", Offset = "0x2C61090", VA = "0x2C65090")]
			[CompilerGenerated]
			get
			{
				return default(FoveatedRenderingCaps);
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x2C650E8", Offset = "0x2C610E8", VA = "0x2C650E8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public static bool dumpDebugInfo
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x2C65144", Offset = "0x2C61144", VA = "0x2C65144")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x2C6519C", Offset = "0x2C6119C", VA = "0x2C6519C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2C64ECC", Offset = "0x2C60ECC", VA = "0x2C64ECC")]
		public static XRDisplaySubsystem GetActiveDisplay()
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2C651FC", Offset = "0x2C611FC", VA = "0x2C651FC")]
		public static void Initialize(Func<XRPassCreateInfo, XRPass> passAllocator, Shader occlusionMeshPS, Shader mirrorViewPS)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2C65848", Offset = "0x2C61848", VA = "0x2C65848")]
		public static void SetDisplayMSAASamples(MSAASamples msaaSamples)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2C65A4C", Offset = "0x2C61A4C", VA = "0x2C65A4C")]
		public static MSAASamples GetDisplayMSAASamples()
		{
			return default(MSAASamples);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2C65AA4", Offset = "0x2C61AA4", VA = "0x2C65AA4")]
		public static void SetRenderScale(float renderScale)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2C65C64", Offset = "0x2C61C64", VA = "0x2C65C64")]
		public static XRLayout NewLayout()
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2C65D5C", Offset = "0x2C61D5C", VA = "0x2C65D5C")]
		public static void EndLayout()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2C65E2C", Offset = "0x2C61E2C", VA = "0x2C65E2C")]
		public static void RenderMirrorView(CommandBuffer cmd, Camera camera)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2C65ED0", Offset = "0x2C61ED0", VA = "0x2C65ED0")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2C61298", Offset = "0x2C5D298", VA = "0x2C61298")]
		internal static void SetDisplayZRange(float zNear, float zFar)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2C66054", Offset = "0x2C62054", VA = "0x2C66054")]
		private static void SetLayoutOverride(Action<XRLayout, Camera> action)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2C660B0", Offset = "0x2C620B0", VA = "0x2C660B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void XRSystemInit()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2C65578", Offset = "0x2C61578", VA = "0x2C65578")]
		private static void RefreshDeviceInfo()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2C6135C", Offset = "0x2C5D35C", VA = "0x2C6135C")]
		internal static void CreateDefaultLayout(Camera camera)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2C61A1C", Offset = "0x2C5DA1C", VA = "0x2C61A1C")]
		internal static void ReconfigurePass(XRPass xrPass, Camera camera)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2C66150", Offset = "0x2C62150", VA = "0x2C66150")]
		private static bool CanUseSinglePass(Camera camera, XRDisplaySubsystem.XRRenderPass renderPass)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2C66540", Offset = "0x2C62540", VA = "0x2C66540")]
		private static XRView BuildView(XRDisplaySubsystem.XRRenderPass renderPass, XRDisplaySubsystem.XRRenderParameter renderParameter)
		{
			return default(XRView);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2C662D4", Offset = "0x2C622D4", VA = "0x2C662D4")]
		private static XRPassCreateInfo BuildPass(XRDisplaySubsystem.XRRenderPass xrRenderPass, ScriptableCullingParameters cullingParameters)
		{
			return default(XRPassCreateInfo);
		}
	}
	[Token(Token = "0x2000010")]
	internal readonly struct XRView
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly Matrix4x4 projMatrix;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal readonly Matrix4x4 viewMatrix;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal readonly Rect viewport;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal readonly Mesh occlusionMesh;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal readonly int textureArraySlice;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		internal readonly Vector2 eyeCenterUV;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2C66658", Offset = "0x2C62658", VA = "0x2C66658")]
		internal XRView(Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Rect viewport, Mesh occlusionMesh, int textureArraySlice)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2C667D0", Offset = "0x2C627D0", VA = "0x2C667D0")]
		private static Vector2 ComputeEyeCenterUV(Matrix4x4 proj)
		{
			return default(Vector2);
		}
	}
}
namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	[Token(Token = "0x2000011")]
	[Flags]
	public enum DepthAccess
	{
		[Token(Token = "0x4000061")]
		Read = 1,
		[Token(Token = "0x4000062")]
		Write = 2,
		[Token(Token = "0x4000063")]
		ReadWrite = 3
	}
	[Token(Token = "0x2000012")]
	public class RenderGraphContext
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScriptableRenderContext renderContext;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CommandBuffer cmd;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RenderGraphObjectPool renderGraphPool;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RenderGraphDefaultResources defaultResources;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2C6686C", Offset = "0x2C6286C", VA = "0x2C6686C")]
		public RenderGraphContext()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public struct RenderGraphParameters
	{
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string executionName;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int currentFrameIndex;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool rendererListCulling;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScriptableRenderContext scriptableRenderContext;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CommandBuffer commandBuffer;
	}
	[Token(Token = "0x2000014")]
	public struct RenderGraphExecution : IDisposable
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RenderGraph renderGraph;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2C66874", Offset = "0x2C62874", VA = "0x2C66874")]
		internal RenderGraphExecution(RenderGraph renderGraph)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2C6687C", Offset = "0x2C6287C", VA = "0x2C6687C", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000015")]
	internal class RenderGraphDebugParams
	{
		[Token(Token = "0x2000016")]
		private static class Strings
		{
			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly DebugUI.Widget.NameAndTooltip DisablePassCulling;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly DebugUI.Widget.NameAndTooltip ImmediateMode;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static readonly DebugUI.Widget.NameAndTooltip EnableLogging;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static readonly DebugUI.Widget.NameAndTooltip LogFrameInformation;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static readonly DebugUI.Widget.NameAndTooltip LogResources;
		}

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DebugUI.Widget[] m_DebugItems;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DebugUI.Panel m_DebugPanel;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool clearRenderTargetsAtCreation;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool clearRenderTargetsAtRelease;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool disablePassCulling;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool immediateMode;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool enableLogging;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool logFrameInformation;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool logResources;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2C66AAC", Offset = "0x2C62AAC", VA = "0x2C66AAC")]
		public void RegisterDebug(string name, [Optional] DebugUI.Panel debugPanel)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2C67164", Offset = "0x2C63164", VA = "0x2C67164")]
		public void UnRegisterDebug(string name)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2C671C8", Offset = "0x2C631C8", VA = "0x2C671C8")]
		public RenderGraphDebugParams()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public delegate void RenderFunc<PassData>(PassData data, RenderGraphContext renderGraphContext) where PassData : class, new();
	[Token(Token = "0x2000018")]
	internal class RenderGraphDebugData
	{
		[Token(Token = "0x2000019")]
		[DebuggerDisplay("PassDebug: {name}")]
		public struct PassDebugData
		{
			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<int>[] resourceReadLists;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<int>[] resourceWriteLists;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool culled;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool async;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int syncToPassIndex;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int syncFromPassIndex;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool generateDebugData;
		}

		[Token(Token = "0x200001A")]
		[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
		public struct ResourceDebugData
		{
			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool imported;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int creationPassIndex;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int releasePassIndex;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<int> consumerList;

			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<int> producerList;
		}

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<PassDebugData> passList;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<ResourceDebugData>[] resourceLists;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2C674DC", Offset = "0x2C634DC", VA = "0x2C674DC")]
		public void Clear()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2C6766C", Offset = "0x2C6366C", VA = "0x2C6766C")]
		public RenderGraphDebugData()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class RenderGraph
	{
		[Token(Token = "0x200001C")]
		internal struct CompiledResourceInfo
		{
			[Token(Token = "0x40000AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<int> producers;

			[Token(Token = "0x40000AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<int> consumers;

			[Token(Token = "0x40000AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int refCount;

			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool imported;

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2C6B0EC", Offset = "0x2C670EC", VA = "0x2C6B0EC")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200001D")]
		[DebuggerDisplay("RenderPass: {pass.name} (Index:{pass.index} Async:{enableAsyncCompute})")]
		internal struct CompiledPassInfo
		{
			[Token(Token = "0x40000AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RenderGraphPass pass;

			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<int>[] resourceCreateList;

			[Token(Token = "0x40000B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<int>[] resourceReleaseList;

			[Token(Token = "0x40000B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int refCount;

			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool culled;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			public bool culledByRendererList;

			[Token(Token = "0x40000B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
			public bool hasSideEffect;

			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int syncToPassIndex;

			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int syncFromPassIndex;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool needGraphicsFence;

			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GraphicsFence fence;

			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool enableAsyncCompute;

			[Token(Token = "0x17000022")]
			public bool allowPassCulling
			{
				[Token(Token = "0x60000E2")]
				[Address(RVA = "0x2C6C3DC", Offset = "0x2C683DC", VA = "0x2C6C3DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2C6B348", Offset = "0x2C67348", VA = "0x2C6B348")]
			public void Reset(RenderGraphPass pass)
			{
			}
		}

		[Token(Token = "0x200001E")]
		private class ProfilingScopePassData
		{
			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ProfilingSampler sampler;

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2C72354", Offset = "0x2C6E354", VA = "0x2C72354")]
			public ProfilingScopePassData()
			{
			}
		}

		[Token(Token = "0x200001F")]
		internal delegate void OnGraphRegisteredDelegate(RenderGraph graph);

		[Token(Token = "0x2000020")]
		internal delegate void OnExecutionRegisteredDelegate(RenderGraph graph, string executionName);

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int kMaxMRTCount;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RenderGraphResourceRegistry m_Resources;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RenderGraphObjectPool m_RenderGraphPool;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<RenderGraphPass> m_RenderPasses;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<RendererListHandle> m_RendererLists;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderGraphDebugParams m_DebugParameters;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RenderGraphLogger m_FrameInformationLogger;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderGraphDefaultResources m_DefaultResources;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_ExecutionExceptionWasRaised;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RenderGraphContext m_RenderGraphContext;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CommandBuffer m_PreviousCommandBuffer;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_CurrentImmediatePassIndex;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<int>[] m_ImmediateModeResourceList;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DynamicArray<CompiledResourceInfo>[] m_CompiledResourcesInfos;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DynamicArray<CompiledPassInfo> m_CompiledPassInfos;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Stack<int> m_CullingStack;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int m_ExecutionCount;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int m_CurrentFrameIndex;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool m_HasRenderGraphBegun;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string m_CurrentExecutionName;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool m_RendererListCulling;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<string, RenderGraphDebugData> m_DebugData;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<RenderGraph> s_RegisteredGraphs;

		[Token(Token = "0x1700001F")]
		public string name
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x2C67710", Offset = "0x2C63710", VA = "0x2C67710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x2C67718", Offset = "0x2C63718", VA = "0x2C67718")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		internal static bool requireDebugData
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x2C67720", Offset = "0x2C63720", VA = "0x2C67720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x2C67778", Offset = "0x2C63778", VA = "0x2C67778")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public RenderGraphDefaultResources defaultResources
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x2C677D8", Offset = "0x2C637D8", VA = "0x2C677D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		internal static event OnGraphRegisteredDelegate onGraphRegistered
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2C6A958", Offset = "0x2C66958", VA = "0x2C6A958")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2C6AA34", Offset = "0x2C66A34", VA = "0x2C6AA34")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		internal static event OnGraphRegisteredDelegate onGraphUnregistered
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2C6AB10", Offset = "0x2C66B10", VA = "0x2C6AB10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x2C6ABEC", Offset = "0x2C66BEC", VA = "0x2C6ABEC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		internal static event OnExecutionRegisteredDelegate onExecutionRegistered
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x2C6ACC8", Offset = "0x2C66CC8", VA = "0x2C6ACC8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x2C6ADA4", Offset = "0x2C66DA4", VA = "0x2C6ADA4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		internal static event OnExecutionRegisteredDelegate onExecutionUnregistered
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x2C6AE80", Offset = "0x2C66E80", VA = "0x2C6AE80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x2C6AF5C", Offset = "0x2C66F5C", VA = "0x2C6AF5C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2C677E0", Offset = "0x2C637E0", VA = "0x2C677E0")]
		public RenderGraph(string name = "RenderGraph")
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2C68238", Offset = "0x2C64238", VA = "0x2C68238")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2C684D4", Offset = "0x2C644D4", VA = "0x2C684D4")]
		public void RegisterDebug([Optional] DebugUI.Panel panel)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2C684F4", Offset = "0x2C644F4", VA = "0x2C684F4")]
		public void UnRegisterDebug()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2C68508", Offset = "0x2C64508", VA = "0x2C68508")]
		public static List<RenderGraph> GetRegisteredRenderGraphs()
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2C68560", Offset = "0x2C64560", VA = "0x2C68560")]
		internal RenderGraphDebugData GetDebugData(string executionName)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2C685D8", Offset = "0x2C645D8", VA = "0x2C685D8")]
		public void EndFrame()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2C68904", Offset = "0x2C64904", VA = "0x2C68904")]
		public TextureHandle ImportTexture(RTHandle rt)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2C689C8", Offset = "0x2C649C8", VA = "0x2C689C8")]
		public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2C68B48", Offset = "0x2C64B48", VA = "0x2C68B48")]
		public TextureHandle CreateTexture(in TextureDesc desc)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2C68C2C", Offset = "0x2C64C2C", VA = "0x2C68C2C")]
		public TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease = false)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2C68E5C", Offset = "0x2C64E5C", VA = "0x2C68E5C")]
		public void RefreshSharedTextureDesc(TextureHandle handle, in TextureDesc desc)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2C68F98", Offset = "0x2C64F98", VA = "0x2C68F98")]
		public void ReleaseSharedTexture(TextureHandle texture)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2C69138", Offset = "0x2C65138", VA = "0x2C69138")]
		public TextureHandle CreateTexture(TextureHandle texture)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2C6929C", Offset = "0x2C6529C", VA = "0x2C6929C")]
		public void CreateTextureIfInvalid(in TextureDesc desc, ref TextureHandle texture)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2C69378", Offset = "0x2C65378", VA = "0x2C69378")]
		public TextureDesc GetTextureDesc(TextureHandle texture)
		{
			return default(TextureDesc);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2C69398", Offset = "0x2C65398", VA = "0x2C69398")]
		public RendererListHandle CreateRendererList(in RendererListDesc desc)
		{
			return default(RendererListHandle);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2C6944C", Offset = "0x2C6544C", VA = "0x2C6944C")]
		public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)
		{
			return default(ComputeBufferHandle);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2C69514", Offset = "0x2C65514", VA = "0x2C69514")]
		public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc)
		{
			return default(ComputeBufferHandle);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2C695F0", Offset = "0x2C655F0", VA = "0x2C695F0")]
		public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferHandle computeBuffer)
		{
			return default(ComputeBufferHandle);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2C69748", Offset = "0x2C65748", VA = "0x2C69748")]
		public ComputeBufferDesc GetComputeBufferDesc(in ComputeBufferHandle computeBuffer)
		{
			return default(ComputeBufferDesc);
		}

		[Token(Token = "0x60000A9")]
		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler) where PassData : class, new()
		{
			return default(RenderGraphBuilder);
		}

		[Token(Token = "0x60000AA")]
		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData) where PassData : class, new()
		{
			return default(RenderGraphBuilder);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2C6975C", Offset = "0x2C6575C", VA = "0x2C6975C")]
		public RenderGraphExecution RecordAndExecute(in RenderGraphParameters parameters)
		{
			return default(RenderGraphExecution);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2C66890", Offset = "0x2C62890", VA = "0x2C66890")]
		internal void Execute()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2C6A1B0", Offset = "0x2C661B0", VA = "0x2C6A1B0")]
		public void BeginProfilingSampler(ProfilingSampler sampler)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2C6A3C4", Offset = "0x2C663C4", VA = "0x2C6A3C4")]
		public void EndProfilingSampler(ProfilingSampler sampler)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2C6A5A0", Offset = "0x2C665A0", VA = "0x2C6A5A0")]
		internal DynamicArray<CompiledPassInfo> GetCompiledPassInfos()
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2C6A5A8", Offset = "0x2C665A8", VA = "0x2C6A5A8")]
		internal void ClearCompiledGraph()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2C6A8D8", Offset = "0x2C668D8", VA = "0x2C6A8D8")]
		private void InvalidateContext()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2C6A8F4", Offset = "0x2C668F4", VA = "0x2C6A8F4")]
		internal void OnPassAdded(RenderGraphPass pass)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2C6B038", Offset = "0x2C67038", VA = "0x2C6B038")]
		private void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2C6B1CC", Offset = "0x2C671CC", VA = "0x2C6B1CC")]
		private void InitializeCompilationData()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2C6B54C", Offset = "0x2C6754C", VA = "0x2C6B54C")]
		private void CountReferences()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2C6BDA8", Offset = "0x2C67DA8", VA = "0x2C6BDA8")]
		private void CullUnusedPasses()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2C6C7D4", Offset = "0x2C687D4", VA = "0x2C6C7D4")]
		private void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2C6C7FC", Offset = "0x2C687FC", VA = "0x2C6C7FC")]
		private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, in CompiledResourceInfo resource)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2C6CAB0", Offset = "0x2C68AB0", VA = "0x2C6CAB0")]
		private int GetFirstValidConsumerIndex(int passIndex, in CompiledResourceInfo info)
		{
			return default(int);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2C6CC34", Offset = "0x2C68C34", VA = "0x2C6CC34")]
		private int FindTextureProducer(int consumerPass, in CompiledResourceInfo info, out int index)
		{
			return default(int);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2C6C92C", Offset = "0x2C6892C", VA = "0x2C6C92C")]
		private int GetLatestProducerIndex(int passIndex, in CompiledResourceInfo info)
		{
			return default(int);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2C6CD48", Offset = "0x2C68D48", VA = "0x2C6CD48")]
		private int GetLatestValidReadIndex(in CompiledResourceInfo info)
		{
			return default(int);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2C6CE2C", Offset = "0x2C68E2C", VA = "0x2C6CE2C")]
		private int GetFirstValidWriteIndex(in CompiledResourceInfo info)
		{
			return default(int);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2C6CF20", Offset = "0x2C68F20", VA = "0x2C6CF20")]
		private int GetLatestValidWriteIndex(in CompiledResourceInfo info)
		{
			return default(int);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2C6D004", Offset = "0x2C69004", VA = "0x2C6D004")]
		private void CreateRendererLists()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2C6D3B8", Offset = "0x2C693B8", VA = "0x2C6D3B8")]
		internal bool GetImportedFallback(TextureDesc desc, out TextureHandle fallback)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2C6D5D8", Offset = "0x2C695D8", VA = "0x2C6D5D8")]
		private void AllocateCulledPassResources(ref CompiledPassInfo passInfo, int passIndex)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2C6DB68", Offset = "0x2C69B68", VA = "0x2C6DB68")]
		private void UpdateResourceAllocationAndSynchronization()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2C6E52C", Offset = "0x2C6A52C", VA = "0x2C6E52C")]
		private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2C6E7FC", Offset = "0x2C6A7FC", VA = "0x2C6E7FC")]
		private void TryCullPassAtIndex(int passIndex)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2C6E904", Offset = "0x2C6A904", VA = "0x2C6E904")]
		private void CullRendererLists()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2C69F44", Offset = "0x2C65F44", VA = "0x2C69F44")]
		internal void CompileRenderGraph()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2C6EB00", Offset = "0x2C6AB00", VA = "0x2C6EB00")]
		private unsafe ref CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass)
		{
			return ref *(CompiledPassInfo*)null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2C6A934", Offset = "0x2C66934", VA = "0x2C6A934")]
		private void ExecutePassImmediately(RenderGraphPass pass)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2C6F524", Offset = "0x2C6B524", VA = "0x2C6F524")]
		private void ExecuteCompiledPass(ref CompiledPassInfo passInfo, int passIndex)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2C6A064", Offset = "0x2C66064", VA = "0x2C6A064")]
		private void ExecuteRenderGraph()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2C700D4", Offset = "0x2C6C0D4", VA = "0x2C700D4")]
		private void PreRenderPassSetRenderTargets(in CompiledPassInfo passInfo, RenderGraphContext rgContext)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2C6FB9C", Offset = "0x2C6BB9C", VA = "0x2C6FB9C")]
		private void PreRenderPassExecute(in CompiledPassInfo passInfo, RenderGraphContext rgContext)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2C6FE90", Offset = "0x2C6BE90", VA = "0x2C6FE90")]
		private void PostRenderPassExecute(ref CompiledPassInfo passInfo, RenderGraphContext rgContext)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2C6A690", Offset = "0x2C66690", VA = "0x2C6A690")]
		private void ClearRenderPasses()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2C70AF0", Offset = "0x2C6CAF0", VA = "0x2C70AF0")]
		private void ReleaseImmediateModeResources()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2C69D10", Offset = "0x2C65D10", VA = "0x2C69D10")]
		private void LogFrameInformation()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2C6E9F0", Offset = "0x2C6A9F0", VA = "0x2C6E9F0")]
		private void LogRendererListsCreation()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2C6F87C", Offset = "0x2C6B87C", VA = "0x2C6F87C")]
		private void LogRenderPassBegin(in CompiledPassInfo passInfo)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2C6C3F4", Offset = "0x2C683F4", VA = "0x2C6C3F4")]
		private void LogCulledPasses()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2C70C78", Offset = "0x2C6CC78", VA = "0x2C70C78")]
		private ProfilingSampler GetDefaultProfilingSampler(string name)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2C70D64", Offset = "0x2C6CD64", VA = "0x2C70D64")]
		private void UpdateImportedResourceLifeTime(ref RenderGraphDebugData.ResourceDebugData data, List<int> passList)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2C70F1C", Offset = "0x2C6CF1C", VA = "0x2C70F1C")]
		private void GenerateDebugData()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2C71FB0", Offset = "0x2C6DFB0", VA = "0x2C71FB0")]
		private void CleanupDebugData()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public struct RenderGraphProfilingScope : IDisposable
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_Disposed;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private ProfilingSampler m_Sampler;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RenderGraph m_RenderGraph;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2C7269C", Offset = "0x2C6E69C", VA = "0x2C7269C")]
		public RenderGraphProfilingScope(RenderGraph renderGraph, ProfilingSampler sampler)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2C726BC", Offset = "0x2C6E6BC", VA = "0x2C726BC", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2C726C4", Offset = "0x2C6E6C4", VA = "0x2C726C4")]
		private void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public struct RenderGraphBuilder : IDisposable
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RenderGraphPass m_RenderPass;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private RenderGraphResourceRegistry m_Resources;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RenderGraph m_RenderGraph;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_Disposed;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2C726FC", Offset = "0x2C6E6FC", VA = "0x2C726FC")]
		public TextureHandle UseColorBuffer(in TextureHandle input, int index)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2C728D4", Offset = "0x2C6E8D4", VA = "0x2C728D4")]
		public TextureHandle UseDepthBuffer(in TextureHandle input, DepthAccess flags)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2C72A80", Offset = "0x2C6EA80", VA = "0x2C72A80")]
		public TextureHandle ReadTexture(in TextureHandle input)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2C729FC", Offset = "0x2C6E9FC", VA = "0x2C729FC")]
		public TextureHandle WriteTexture(in TextureHandle input)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2C72D50", Offset = "0x2C6ED50", VA = "0x2C72D50")]
		public TextureHandle ReadWriteTexture(in TextureHandle input)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2C72DA0", Offset = "0x2C6EDA0", VA = "0x2C72DA0")]
		public TextureHandle CreateTransientTexture(in TextureDesc desc)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2C72EF4", Offset = "0x2C6EEF4", VA = "0x2C72EF4")]
		public TextureHandle CreateTransientTexture(in TextureHandle texture)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2C72F74", Offset = "0x2C6EF74", VA = "0x2C72F74")]
		public RendererListHandle UseRendererList(in RendererListHandle input)
		{
			return default(RendererListHandle);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2C73040", Offset = "0x2C6F040", VA = "0x2C73040")]
		public ComputeBufferHandle ReadComputeBuffer(in ComputeBufferHandle input)
		{
			return default(ComputeBufferHandle);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2C73064", Offset = "0x2C6F064", VA = "0x2C73064")]
		public ComputeBufferHandle WriteComputeBuffer(in ComputeBufferHandle input)
		{
			return default(ComputeBufferHandle);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2C730A4", Offset = "0x2C6F0A4", VA = "0x2C730A4")]
		public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferDesc desc)
		{
			return default(ComputeBufferHandle);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2C730F8", Offset = "0x2C6F0F8", VA = "0x2C730F8")]
		public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferHandle computebuffer)
		{
			return default(ComputeBufferHandle);
		}

		[Token(Token = "0x6000100")]
		public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc) where PassData : class, new()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2C73168", Offset = "0x2C6F168", VA = "0x2C73168")]
		public void EnableAsyncCompute(bool value)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2C6A38C", Offset = "0x2C6638C", VA = "0x2C6A38C")]
		public void AllowPassCulling(bool value)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2C73194", Offset = "0x2C6F194", VA = "0x2C73194", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2C731D0", Offset = "0x2C6F1D0", VA = "0x2C731D0")]
		public void AllowRendererListCulling(bool value)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2C731F4", Offset = "0x2C6F1F4", VA = "0x2C731F4")]
		public RendererListHandle DependsOn(in RendererListHandle input)
		{
			return default(RendererListHandle);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2C7321C", Offset = "0x2C6F21C", VA = "0x2C7321C")]
		internal RenderGraphBuilder(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2C7319C", Offset = "0x2C6F19C", VA = "0x2C7319C")]
		private void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2C72744", Offset = "0x2C6E744", VA = "0x2C72744")]
		private void CheckResource(in ResourceHandle res, bool dontCheckTransientReadWrite = false)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2C6A3A8", Offset = "0x2C663A8", VA = "0x2C6A3A8")]
		internal void GenerateDebugData(bool value)
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class RenderGraphDefaultResources
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_IsValid;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RTHandle m_BlackTexture2D;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RTHandle m_WhiteTexture2D;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RTHandle m_ShadowTexture2D;

		[Token(Token = "0x17000023")]
		public TextureHandle blackTexture
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x2C73234", Offset = "0x2C6F234", VA = "0x2C73234")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x2C7323C", Offset = "0x2C6F23C", VA = "0x2C7323C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public TextureHandle whiteTexture
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x2C73244", Offset = "0x2C6F244", VA = "0x2C73244")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x2C7324C", Offset = "0x2C6F24C", VA = "0x2C7324C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public TextureHandle clearTextureXR
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x2C73254", Offset = "0x2C6F254", VA = "0x2C73254")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2C7325C", Offset = "0x2C6F25C", VA = "0x2C7325C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public TextureHandle magentaTextureXR
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x2C73264", Offset = "0x2C6F264", VA = "0x2C73264")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x2C7326C", Offset = "0x2C6F26C", VA = "0x2C7326C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public TextureHandle blackTextureXR
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x2C73274", Offset = "0x2C6F274", VA = "0x2C73274")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x2C7327C", Offset = "0x2C6F27C", VA = "0x2C7327C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public TextureHandle blackTextureArrayXR
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x2C73284", Offset = "0x2C6F284", VA = "0x2C73284")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x2C7328C", Offset = "0x2C6F28C", VA = "0x2C7328C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public TextureHandle blackUIntTextureXR
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x2C73294", Offset = "0x2C6F294", VA = "0x2C73294")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2C7329C", Offset = "0x2C6F29C", VA = "0x2C7329C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public TextureHandle blackTexture3DXR
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x2C732A4", Offset = "0x2C6F2A4", VA = "0x2C732A4")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x2C732AC", Offset = "0x2C6F2AC", VA = "0x2C732AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public TextureHandle whiteTextureXR
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x2C732B4", Offset = "0x2C6F2B4", VA = "0x2C732B4")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x2C732BC", Offset = "0x2C6F2BC", VA = "0x2C732BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public TextureHandle defaultShadowTexture
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2C732C4", Offset = "0x2C6F2C4", VA = "0x2C732C4")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x2C732CC", Offset = "0x2C6F2CC", VA = "0x2C732CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2C67E2C", Offset = "0x2C63E2C", VA = "0x2C67E2C")]
		internal RenderGraphDefaultResources()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2C683AC", Offset = "0x2C643AC", VA = "0x2C683AC")]
		internal void Cleanup()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2C69B2C", Offset = "0x2C65B2C", VA = "0x2C69B2C")]
		internal void InitializeForRendering(RenderGraph renderGraph)
		{
		}
	}
	[Token(Token = "0x2000025")]
	internal struct RenderGraphLogIndent : IDisposable
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_Indentation;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private RenderGraphLogger m_Logger;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Disposed;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2C6FB78", Offset = "0x2C6BB78", VA = "0x2C6FB78")]
		public RenderGraphLogIndent(RenderGraphLogger logger, int indentation = 1)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2C73344", Offset = "0x2C6F344", VA = "0x2C73344", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2C73378", Offset = "0x2C6F378", VA = "0x2C73378")]
		private void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000026")]
	internal class RenderGraphLogger
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, StringBuilder> m_LogMap;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StringBuilder m_CurrentBuilder;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentIndentation;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2C69A4C", Offset = "0x2C65A4C", VA = "0x2C69A4C")]
		public void Initialize(string logName)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2C732D4", Offset = "0x2C6F2D4", VA = "0x2C732D4")]
		public void IncrementIndentation(int value)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2C733B0", Offset = "0x2C6F3B0", VA = "0x2C733B0")]
		public void DecrementIndentation(int value)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2C6C358", Offset = "0x2C68358", VA = "0x2C6C358")]
		public void LogLine(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2C7342C", Offset = "0x2C6F42C", VA = "0x2C7342C")]
		public string GetLog(string logName)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2C68704", Offset = "0x2C64704", VA = "0x2C68704")]
		public string GetAllLogs()
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2C67DB0", Offset = "0x2C63DB0", VA = "0x2C67DB0")]
		public RenderGraphLogger()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public sealed class RenderGraphObjectPool
	{
		[Token(Token = "0x2000028")]
		private abstract class SharedObjectPoolBase
		{
			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected static List<SharedObjectPoolBase> s_AllocatedPools;

			[Token(Token = "0x6000132")]
			protected abstract void Clear();

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x2C735DC", Offset = "0x2C6F5DC", VA = "0x2C735DC")]
			public static void ClearAll()
			{
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2C73738", Offset = "0x2C6F738", VA = "0x2C73738")]
			protected SharedObjectPoolBase()
			{
			}
		}

		[Token(Token = "0x2000029")]
		private class SharedObjectPool<T> : SharedObjectPoolBase where T : new()
		{
			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Stack<T> m_Pool;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly Lazy<SharedObjectPool<T>> s_Instance;

			[Token(Token = "0x1700002D")]
			public static SharedObjectPool<T> sharedPool
			{
				[Token(Token = "0x600013A")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000136")]
			public T Get()
			{
				return (T)null;
			}

			[Token(Token = "0x6000137")]
			public void Release(T value)
			{
			}

			[Token(Token = "0x6000138")]
			private static SharedObjectPool<T> AllocatePool()
			{
				return null;
			}

			[Token(Token = "0x6000139")]
			protected override void Clear()
			{
			}

			[Token(Token = "0x600013B")]
			public SharedObjectPool()
			{
			}
		}

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<(Type, int), Stack<object>> m_ArrayPool;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<(object, (Type, int))> m_AllocatedArrays;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2C67CA4", Offset = "0x2C63CA4", VA = "0x2C67CA4")]
		internal RenderGraphObjectPool()
		{
		}

		[Token(Token = "0x600012C")]
		public T[] GetTempArray<T>(int size)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2C734CC", Offset = "0x2C6F4CC", VA = "0x2C734CC")]
		public MaterialPropertyBlock GetTempMaterialPropertyBlock()
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2C70654", Offset = "0x2C6C654", VA = "0x2C70654")]
		internal void ReleaseAllTempAlloc()
		{
		}

		[Token(Token = "0x600012F")]
		internal T Get<T>() where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000130")]
		internal void Release<T>(T value) where T : new()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2C683EC", Offset = "0x2C643EC", VA = "0x2C683EC")]
		internal void Cleanup()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal abstract class RenderGraphPass
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<ResourceHandle>[] resourceReadLists;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<ResourceHandle>[] resourceWriteLists;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<ResourceHandle>[] transientResourceList;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<RendererListHandle> usedRendererListList;

		[Token(Token = "0x1700002E")]
		public string name
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2C737CC", Offset = "0x2C6F7CC", VA = "0x2C737CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2C737D4", Offset = "0x2C6F7D4", VA = "0x2C737D4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public int index
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2C737DC", Offset = "0x2C6F7DC", VA = "0x2C737DC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x2C737E4", Offset = "0x2C6F7E4", VA = "0x2C737E4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public ProfilingSampler customSampler
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2C737EC", Offset = "0x2C6F7EC", VA = "0x2C737EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2C737F4", Offset = "0x2C6F7F4", VA = "0x2C737F4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool enableAsyncCompute
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2C737FC", Offset = "0x2C6F7FC", VA = "0x2C737FC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2C73804", Offset = "0x2C6F804", VA = "0x2C73804")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool allowPassCulling
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x2C7380C", Offset = "0x2C6F80C", VA = "0x2C7380C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2C73814", Offset = "0x2C6F814", VA = "0x2C73814")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public TextureHandle depthBuffer
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2C7381C", Offset = "0x2C6F81C", VA = "0x2C7381C")]
			[CompilerGenerated]
			get
			{
				return default(TextureHandle);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2C73824", Offset = "0x2C6F824", VA = "0x2C73824")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public TextureHandle[] colorBuffers
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2C7382C", Offset = "0x2C6F82C", VA = "0x2C7382C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2C73834", Offset = "0x2C6F834", VA = "0x2C73834")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public int colorBufferMaxIndex
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2C7383C", Offset = "0x2C6F83C", VA = "0x2C7383C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2C73844", Offset = "0x2C6F844", VA = "0x2C73844")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public int refCount
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2C7384C", Offset = "0x2C6F84C", VA = "0x2C7384C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2C73854", Offset = "0x2C6F854", VA = "0x2C73854")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool generateDebugData
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2C7385C", Offset = "0x2C6F85C", VA = "0x2C7385C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2C73864", Offset = "0x2C6F864", VA = "0x2C73864")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool allowRendererListCulling
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2C7386C", Offset = "0x2C6F86C", VA = "0x2C7386C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2C73874", Offset = "0x2C6F874", VA = "0x2C73874")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600013D")]
		public RenderFunc<PassData> GetExecuteDelegate<PassData>() where PassData : class, new()
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		public abstract void Execute(RenderGraphContext renderGraphContext);

		[Token(Token = "0x600013F")]
		public abstract void Release(RenderGraphObjectPool pool);

		[Token(Token = "0x6000140")]
		public abstract bool HasRenderFunc();

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2C7387C", Offset = "0x2C6F87C", VA = "0x2C7387C")]
		public RenderGraphPass()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2C73ADC", Offset = "0x2C6FADC", VA = "0x2C73ADC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2C72C50", Offset = "0x2C6EC50", VA = "0x2C72C50")]
		public void AddResourceWrite(in ResourceHandle res)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2C72B50", Offset = "0x2C6EB50", VA = "0x2C72B50")]
		public void AddResourceRead(in ResourceHandle res)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2C72DF4", Offset = "0x2C6EDF4", VA = "0x2C72DF4")]
		public void AddTransientResource(in ResourceHandle res)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2C72F9C", Offset = "0x2C6EF9C", VA = "0x2C72F9C")]
		public void UseRendererList(RendererListHandle rendererList)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2C73184", Offset = "0x2C6F184", VA = "0x2C73184")]
		public void EnableAsyncCompute(bool value)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2C7318C", Offset = "0x2C6F18C", VA = "0x2C7318C")]
		public void AllowPassCulling(bool value)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2C731EC", Offset = "0x2C6F1EC", VA = "0x2C731EC")]
		public void AllowRendererListCulling(bool value)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2C7322C", Offset = "0x2C6F22C", VA = "0x2C7322C")]
		public void GenerateDebugData(bool value)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2C72820", Offset = "0x2C6E820", VA = "0x2C72820")]
		public void SetColorBuffer(TextureHandle resource, int index)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2C72A3C", Offset = "0x2C6EA3C", VA = "0x2C72A3C")]
		public void SetDepthBuffer(TextureHandle resource, DepthAccess flags)
		{
		}
	}
	[Token(Token = "0x200002B")]
	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal sealed class RenderGraphPass<PassData> : RenderGraphPass where PassData : class, new()
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal PassData data;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal RenderFunc<PassData> renderFunc;

		[Token(Token = "0x6000163")]
		public override void Execute(RenderGraphContext renderGraphContext)
		{
		}

		[Token(Token = "0x6000164")]
		public void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler)
		{
		}

		[Token(Token = "0x6000165")]
		public override void Release(RenderGraphObjectPool pool)
		{
		}

		[Token(Token = "0x6000166")]
		public override bool HasRenderFunc()
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		public RenderGraphPass()
		{
		}
	}
	[Token(Token = "0x200002C")]
	internal enum RenderGraphProfileId
	{
		[Token(Token = "0x40000F2")]
		CompileRenderGraph,
		[Token(Token = "0x40000F3")]
		ExecuteRenderGraph,
		[Token(Token = "0x40000F4")]
		RenderGraphClear,
		[Token(Token = "0x40000F5")]
		RenderGraphClearDebug
	}
	[Token(Token = "0x200002D")]
	[DebuggerDisplay("ComputeBuffer ({handle.index})")]
	public struct ComputeBufferHandle
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ComputeBufferHandle s_NullHandle;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ResourceHandle handle;

		[Token(Token = "0x17000039")]
		public static ComputeBufferHandle nullHandle
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2C73D84", Offset = "0x2C6FD84", VA = "0x2C73D84")]
			get
			{
				return default(ComputeBufferHandle);
			}
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2C73DDC", Offset = "0x2C6FDDC", VA = "0x2C73DDC")]
		internal ComputeBufferHandle(int handle, bool shared = false)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2C73EC0", Offset = "0x2C6FEC0", VA = "0x2C73EC0")]
		public static implicit operator ComputeBuffer(ComputeBufferHandle buffer)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2C73F68", Offset = "0x2C6FF68", VA = "0x2C73F68")]
		public bool IsValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002E")]
	public struct ComputeBufferDesc
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int count;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int stride;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ComputeBufferType type;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2C74138", Offset = "0x2C70138", VA = "0x2C74138")]
		public ComputeBufferDesc(int count, int stride)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2C7414C", Offset = "0x2C7014C", VA = "0x2C7414C")]
		public ComputeBufferDesc(int count, int stride, ComputeBufferType type)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2C74160", Offset = "0x2C70160", VA = "0x2C74160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200002F")]
	[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
	internal class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer>
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2C741A0", Offset = "0x2C701A0", VA = "0x2C741A0", Slot = "5")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2C741F4", Offset = "0x2C701F4", VA = "0x2C741F4", Slot = "9")]
		public override void CreatePooledGraphicsResource()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2C74390", Offset = "0x2C70390", VA = "0x2C74390", Slot = "11")]
		public override void ReleasePooledGraphicsResource(int frameIndex)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2C744F0", Offset = "0x2C704F0", VA = "0x2C744F0", Slot = "10")]
		public override void CreateGraphicsResource(string name = "")
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2C74658", Offset = "0x2C70658", VA = "0x2C74658", Slot = "12")]
		public override void ReleaseGraphicsResource()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2C746B0", Offset = "0x2C706B0", VA = "0x2C746B0", Slot = "13")]
		public override void LogCreation(RenderGraphLogger logger)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2C7478C", Offset = "0x2C7078C", VA = "0x2C7478C", Slot = "14")]
		public override void LogRelease(RenderGraphLogger logger)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2C74868", Offset = "0x2C70868", VA = "0x2C74868")]
		public ComputeBufferResource()
		{
		}
	}
	[Token(Token = "0x2000030")]
	internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer>
	{
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2C748B0", Offset = "0x2C708B0", VA = "0x2C748B0", Slot = "8")]
		protected override void ReleaseInternalResource(ComputeBuffer res)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2C748C8", Offset = "0x2C708C8", VA = "0x2C748C8", Slot = "9")]
		protected override string GetResourceName(ComputeBuffer res)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2C74908", Offset = "0x2C70908", VA = "0x2C74908", Slot = "10")]
		protected override long GetResourceSize(ComputeBuffer res)
		{
			return default(long);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2C7494C", Offset = "0x2C7094C", VA = "0x2C7494C", Slot = "11")]
		protected override string GetResourceTypeName()
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2C7498C", Offset = "0x2C7098C", VA = "0x2C7498C", Slot = "12")]
		protected override int GetSortIndex(ComputeBuffer res)
		{
			return default(int);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2C749AC", Offset = "0x2C709AC", VA = "0x2C749AC", Slot = "4")]
		public override void PurgeUnusedResources(int currentFrameIndex)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2C74ECC", Offset = "0x2C70ECC", VA = "0x2C74ECC")]
		public ComputeBufferPool()
		{
		}
	}
	[Token(Token = "0x2000031")]
	internal abstract class IRenderGraphResourcePool
	{
		[Token(Token = "0x600017F")]
		public abstract void PurgeUnusedResources(int currentFrameIndex);

		[Token(Token = "0x6000180")]
		public abstract void Cleanup();

		[Token(Token = "0x6000181")]
		public abstract void CheckFrameAllocation(bool onException, int frameIndex);

		[Token(Token = "0x6000182")]
		public abstract void LogResources(RenderGraphLogger logger);

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2C74F14", Offset = "0x2C70F14", VA = "0x2C74F14")]
		protected IRenderGraphResourcePool()
		{
		}
	}
	[Token(Token = "0x2000032")]
	internal abstract class RenderGraphResourcePool<Type> : IRenderGraphResourcePool where Type : class
	{
		[Token(Token = "0x2000033")]
		private struct ResourceLogInfo
		{
			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long size;
		}

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Dictionary<int, SortedList<int, (Type resource, int frameIndex)>> m_ResourcePool;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected List<int> m_RemoveList;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<(int, Type)> m_FrameAllocatedResources;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static int s_CurrentFrameIndex;

		[Token(Token = "0x4000100")]
		private const int kStaleResourceLifetime = 10;

		[Token(Token = "0x6000184")]
		protected abstract void ReleaseInternalResource(Type res);

		[Token(Token = "0x6000185")]
		protected abstract string GetResourceName(Type res);

		[Token(Token = "0x6000186")]
		protected abstract long GetResourceSize(Type res);

		[Token(Token = "0x6000187")]
		protected abstract string GetResourceTypeName();

		[Token(Token = "0x6000188")]
		protected abstract int GetSortIndex(Type res);

		[Token(Token = "0x6000189")]
		public void ReleaseResource(int hash, Type resource, int currentFrameIndex)
		{
		}

		[Token(Token = "0x600018A")]
		public bool TryGetResource(int hashCode, out Type resource)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x600018C")]
		public void RegisterFrameAllocation(int hash, Type value)
		{
		}

		[Token(Token = "0x600018D")]
		public void UnregisterFrameAllocation(int hash, Type value)
		{
		}

		[Token(Token = "0x600018E")]
		public override void CheckFrameAllocation(bool onException, int frameIndex)
		{
		}

		[Token(Token = "0x600018F")]
		public override void LogResources(RenderGraphLogger logger)
		{
		}

		[Token(Token = "0x6000190")]
		protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		protected RenderGraphResourcePool()
		{
		}
	}
	[Token(Token = "0x2000035")]
	internal class RenderGraphResourceRegistry
	{
		[Token(Token = "0x2000036")]
		private delegate bool ResourceCreateCallback(RenderGraphContext rgContext, IRenderGraphResource res);

		[Token(Token = "0x2000037")]
		private delegate void ResourceCallback(RenderGraphContext rgContext, IRenderGraphResource res);

		[Token(Token = "0x2000038")]
		private class RenderGraphResourcesData
		{
			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicArray<IRenderGraphResource> resourceArray;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int sharedResourcesCount;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IRenderGraphResourcePool pool;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResourceCreateCallback createResourceCallback;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ResourceCallback releaseResourceCallback;

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x2C7617C", Offset = "0x2C7217C", VA = "0x2C7617C")]
			public void Clear(bool onException, int frameIndex)
			{
			}

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x2C7621C", Offset = "0x2C7221C", VA = "0x2C7621C")]
			public void Cleanup()
			{
			}

			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x2C76200", Offset = "0x2C72200", VA = "0x2C76200")]
			public void PurgeUnusedGraphicsResources(int frameIndex)
			{
			}

			[Token(Token = "0x60001D7")]
			public int AddNewRenderGraphResource<ResType>(out ResType outRes, bool pooledResource = true) where ResType : IRenderGraphResource, new()
			{
				return default(int);
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x2C751D8", Offset = "0x2C711D8", VA = "0x2C751D8")]
			public RenderGraphResourcesData()
			{
			}
		}

		[Token(Token = "0x4000105")]
		private const int kSharedResourceLifetime = 30;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RenderGraphResourceRegistry m_CurrentRegistry;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RenderGraphResourcesData[] m_RenderGraphResources;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DynamicArray<RendererListResource> m_RendererListResources;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderGraphDebugParams m_RenderGraphDebug;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderGraphLogger m_ResourceLogger;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderGraphLogger m_FrameInformationLogger;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_CurrentFrameIndex;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int m_ExecutionCount;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RTHandle m_CurrentBackbuffer;

		[Token(Token = "0x400010F")]
		private const int kInitialRendererListCount = 256;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<RendererList> m_ActiveRendererLists;

		[Token(Token = "0x1700003A")]
		internal static RenderGraphResourceRegistry current
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x2C74F1C", Offset = "0x2C70F1C", VA = "0x2C74F1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x2C74F64", Offset = "0x2C70F64", VA = "0x2C74F64")]
			set
			{
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2C6DA44", Offset = "0x2C69A44", VA = "0x2C6DA44")]
		internal RTHandle GetTexture(in TextureHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2C7295C", Offset = "0x2C6E95C", VA = "0x2C7295C")]
		internal bool TextureNeedsFallback(in TextureHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2C6E72C", Offset = "0x2C6A72C", VA = "0x2C6E72C")]
		internal RendererList GetRendererList(in RendererListHandle handle)
		{
			return default(RendererList);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2C73FBC", Offset = "0x2C6FFBC", VA = "0x2C73FBC")]
		internal ComputeBuffer GetComputeBuffer(in ComputeBufferHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2C750B8", Offset = "0x2C710B8", VA = "0x2C750B8")]
		private RenderGraphResourceRegistry()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2C67F38", Offset = "0x2C63F38", VA = "0x2C67F38")]
		internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2C699A0", Offset = "0x2C659A0", VA = "0x2C699A0")]
		internal void BeginRenderGraph(int executionCount)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2C69EF0", Offset = "0x2C65EF0", VA = "0x2C69EF0")]
		internal void BeginExecute(int currentFrameIndex)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2C75674", Offset = "0x2C71674", VA = "0x2C75674")]
		internal void EndExecute()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2C756B4", Offset = "0x2C716B4", VA = "0x2C756B4")]
		private void CheckHandleValidity(in ResourceHandle res)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2C75724", Offset = "0x2C71724", VA = "0x2C75724")]
		private void CheckHandleValidity(RenderGraphResourceType type, int index)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2C72748", Offset = "0x2C6E748", VA = "0x2C72748")]
		internal void IncrementWriteCount(in ResourceHandle res)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2C75838", Offset = "0x2C71838", VA = "0x2C75838")]
		internal string GetRenderGraphResourceName(in ResourceHandle res)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2C72160", Offset = "0x2C6E160", VA = "0x2C72160")]
		internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index)
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2C6BCD4", Offset = "0x2C67CD4", VA = "0x2C6BCD4")]
		internal bool IsRenderGraphResourceImported(in ResourceHandle res)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2C6E438", Offset = "0x2C6A438", VA = "0x2C6E438")]
		internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2C6F3BC", Offset = "0x2C6B3BC", VA = "0x2C6F3BC")]
		internal bool IsGraphicsResourceCreated(in ResourceHandle res)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2C6F494", Offset = "0x2C6B494", VA = "0x2C6F494")]
		internal bool IsRendererListCreated(in RendererListHandle res)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2C7220C", Offset = "0x2C6E20C", VA = "0x2C7220C")]
		internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2C75910", Offset = "0x2C71910", VA = "0x2C75910")]
		internal int GetRenderGraphResourceTransientIndex(in ResourceHandle res)
		{
			return default(int);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2C68918", Offset = "0x2C64918", VA = "0x2C68918")]
		internal TextureHandle ImportTexture(RTHandle rt)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2C68C98", Offset = "0x2C64C98", VA = "0x2C68C98")]
		internal TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2C68E70", Offset = "0x2C64E70", VA = "0x2C68E70")]
		internal void RefreshSharedTextureDesc(TextureHandle texture, in TextureDesc desc)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2C69000", Offset = "0x2C65000", VA = "0x2C69000")]
		internal void ReleaseSharedTexture(TextureHandle texture)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2C68A00", Offset = "0x2C64A00", VA = "0x2C68A00")]
		internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2C68B60", Offset = "0x2C64B60", VA = "0x2C68B60")]
		internal TextureHandle CreateTexture(in TextureDesc desc, int transientPassIndex = -1)
		{
			return default(TextureHandle);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2C75A1C", Offset = "0x2C71A1C", VA = "0x2C75A1C")]
		internal int GetResourceCount(RenderGraphResourceType type)
		{
			return default(int);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2C6B338", Offset = "0x2C67338", VA = "0x2C6B338")]
		internal int GetTextureResourceCount()
		{
			return default(int);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2C6D948", Offset = "0x2C69948", VA = "0x2C6D948")]
		internal TextureResource GetTextureResource(in ResourceHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2C69190", Offset = "0x2C65190", VA = "0x2C69190")]
		internal TextureDesc GetTextureResourceDesc(in ResourceHandle handle)
		{
			return default(TextureDesc);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2C693AC", Offset = "0x2C653AC", VA = "0x2C693AC")]
		internal RendererListHandle CreateRendererList(in RendererListDesc desc)
		{
			return default(RendererListHandle);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2C69460", Offset = "0x2C65460", VA = "0x2C69460")]
		internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)
		{
			return default(ComputeBufferHandle);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2C6952C", Offset = "0x2C6552C", VA = "0x2C6952C")]
		internal ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc, int transientPassIndex = -1)
		{
			return default(ComputeBufferHandle);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2C69634", Offset = "0x2C65634", VA = "0x2C69634")]
		internal ComputeBufferDesc GetComputeBufferResourceDesc(in ResourceHandle handle)
		{
			return default(ComputeBufferDesc);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2C6B340", Offset = "0x2C67340", VA = "0x2C6B340")]
		internal int GetComputeBufferResourceCount()
		{
			return default(int);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2C74FB8", Offset = "0x2C70FB8", VA = "0x2C74FB8")]
		private ComputeBufferResource GetComputeBufferResource(in ResourceHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2C6E490", Offset = "0x2C6A490", VA = "0x2C6E490")]
		internal void UpdateSharedResourceLastFrameIndex(int type, int index)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2C7551C", Offset = "0x2C7151C", VA = "0x2C7551C")]
		private void ManageSharedRenderGraphResources()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2C704D0", Offset = "0x2C6C4D0", VA = "0x2C704D0")]
		internal bool CreatePooledResource(RenderGraphContext rgContext, int type, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2C75AC4", Offset = "0x2C71AC4", VA = "0x2C75AC4")]
		internal bool CreatePooledResource(RenderGraphContext rgContext, ResourceHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2C75B48", Offset = "0x2C71B48", VA = "0x2C75B48")]
		private bool CreateTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2C709C4", Offset = "0x2C6C9C4", VA = "0x2C709C4")]
		internal void ReleasePooledResource(RenderGraphContext rgContext, int type, int index)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2C75D80", Offset = "0x2C71D80", VA = "0x2C75D80")]
		internal void ReleasePooledResource(RenderGraphContext rgContext, ResourceHandle handle)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2C75E04", Offset = "0x2C71E04", VA = "0x2C75E04")]
		private void ReleaseTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2C75A18", Offset = "0x2C71A18", VA = "0x2C75A18")]
		private void ValidateTextureDesc(in TextureDesc desc)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2C75A8C", Offset = "0x2C71A8C", VA = "0x2C75A8C")]
		private void ValidateRendererListDesc(in RendererListDesc desc)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2C75AC0", Offset = "0x2C71AC0", VA = "0x2C75AC0")]
		private void ValidateComputeBufferDesc(in ComputeBufferDesc desc)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2C6D0E0", Offset = "0x2C690E0", VA = "0x2C6D0E0")]
		internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2C6A808", Offset = "0x2C66808", VA = "0x2C6A808")]
		internal void Clear(bool onException)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2C68694", Offset = "0x2C64694", VA = "0x2C68694")]
		internal void PurgeUnusedGraphicsResources()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2C6830C", Offset = "0x2C6430C", VA = "0x2C6830C")]
		internal void Cleanup()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2C68894", Offset = "0x2C64894", VA = "0x2C68894")]
		internal void FlushLogs()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2C75FC4", Offset = "0x2C71FC4", VA = "0x2C75FC4")]
		private void LogResources()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[DebuggerDisplay("RendererList ({handle})")]
	public struct RendererListHandle
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_IsValid;

		[Token(Token = "0x1700003B")]
		internal int handle
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x2C76364", Offset = "0x2C72364", VA = "0x2C76364")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x2C7636C", Offset = "0x2C7236C", VA = "0x2C7636C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2C75AB0", Offset = "0x2C71AB0", VA = "0x2C75AB0")]
		internal RendererListHandle(int handle)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2C74FB0", Offset = "0x2C70FB0", VA = "0x2C74FB0")]
		public static implicit operator int(RendererListHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2C76374", Offset = "0x2C72374", VA = "0x2C76374")]
		public static implicit operator RendererList(RendererListHandle rendererList)
		{
			return default(RendererList);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2C76440", Offset = "0x2C72440", VA = "0x2C76440")]
		public bool IsValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003A")]
	internal struct RendererListResource
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RendererListDesc desc;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public RendererList rendererList;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2C75A90", Offset = "0x2C71A90", VA = "0x2C75A90")]
		internal RendererListResource(in RendererListDesc desc)
		{
		}
	}
	[Token(Token = "0x200003B")]
	internal enum RenderGraphResourceType
	{
		[Token(Token = "0x400011B")]
		Texture,
		[Token(Token = "0x400011C")]
		ComputeBuffer,
		[Token(Token = "0x400011D")]
		Count
	}
	[Token(Token = "0x200003C")]
	internal struct ResourceHandle
	{
		[Token(Token = "0x400011E")]
		private const uint kValidityMask = 4294901760u;

		[Token(Token = "0x400011F")]
		private const uint kIndexMask = 65535u;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint m_Value;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint s_CurrentValidBit;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static uint s_SharedResourceValidBit;

		[Token(Token = "0x1700003C")]
		public int index
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x2C7571C", Offset = "0x2C7171C", VA = "0x2C7571C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		public RenderGraphResourceType type
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x2C76448", Offset = "0x2C72448", VA = "0x2C76448")]
			[CompilerGenerated]
			readonly get
			{
				return default(RenderGraphResourceType);
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x2C76450", Offset = "0x2C72450", VA = "0x2C76450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public int iType
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x2C73D30", Offset = "0x2C6FD30", VA = "0x2C73D30")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2C73E10", Offset = "0x2C6FE10", VA = "0x2C73E10")]
		internal ResourceHandle(int value, RenderGraphResourceType type, bool shared)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2C6BC80", Offset = "0x2C67C80", VA = "0x2C6BC80")]
		public static implicit operator int(ResourceHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2C74094", Offset = "0x2C70094", VA = "0x2C74094")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2C7545C", Offset = "0x2C7145C", VA = "0x2C7545C")]
		public static void NewFrame(int executionIndex)
		{
		}
	}
	[Token(Token = "0x200003D")]
	internal class IRenderGraphResource
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool imported;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool shared;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool sharedExplicitRelease;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool requestFallBack;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint writeCount;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int cachedHash;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int transientPassIndex;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sharedResourceLastFrameUsed;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected IRenderGraphResourcePool m_Pool;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2C764A8", Offset = "0x2C724A8", VA = "0x2C764A8", Slot = "4")]
		public virtual void Reset(IRenderGraphResourcePool pool)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2C764C4", Offset = "0x2C724C4", VA = "0x2C764C4", Slot = "5")]
		public virtual string GetName()
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2C76504", Offset = "0x2C72504", VA = "0x2C76504", Slot = "6")]
		public virtual bool IsCreated()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2C7650C", Offset = "0x2C7250C", VA = "0x2C7650C", Slot = "7")]
		public virtual void IncrementWriteCount()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2C7651C", Offset = "0x2C7251C", VA = "0x2C7651C", Slot = "8")]
		public virtual bool NeedsFallBack()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2C7653C", Offset = "0x2C7253C", VA = "0x2C7653C", Slot = "9")]
		public virtual void CreatePooledGraphicsResource()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2C76540", Offset = "0x2C72540", VA = "0x2C76540", Slot = "10")]
		public virtual void CreateGraphicsResource(string name = "")
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2C76544", Offset = "0x2C72544", VA = "0x2C76544", Slot = "11")]
		public virtual void ReleasePooledGraphicsResource(int frameIndex)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2C76548", Offset = "0x2C72548", VA = "0x2C76548", Slot = "12")]
		public virtual void ReleaseGraphicsResource()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2C7654C", Offset = "0x2C7254C", VA = "0x2C7654C", Slot = "13")]
		public virtual void LogCreation(RenderGraphLogger logger)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2C76550", Offset = "0x2C72550", VA = "0x2C76550", Slot = "14")]
		public virtual void LogRelease(RenderGraphLogger logger)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2C76554", Offset = "0x2C72554", VA = "0x2C76554", Slot = "15")]
		public virtual int GetSortIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2C7655C", Offset = "0x2C7255C", VA = "0x2C7655C")]
		public IRenderGraphResource()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
	internal abstract class RenderGraphResource<DescType, ResType> : IRenderGraphResource where DescType : struct where ResType : class
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DescType desc;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ResType graphicsResource;

		[Token(Token = "0x60001F6")]
		protected RenderGraphResource()
		{
		}

		[Token(Token = "0x60001F7")]
		public override void Reset(IRenderGraphResourcePool pool)
		{
		}

		[Token(Token = "0x60001F8")]
		public override bool IsCreated()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F9")]
		public override void ReleaseGraphicsResource()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[DebuggerDisplay("Texture ({handle.index})")]
	public struct TextureHandle
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TextureHandle s_NullHandle;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ResourceHandle handle;

		[Token(Token = "0x1700003F")]
		public static TextureHandle nullHandle
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x2C76564", Offset = "0x2C72564", VA = "0x2C76564")]
			get
			{
				return default(TextureHandle);
			}
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2C759E4", Offset = "0x2C719E4", VA = "0x2C759E4")]
		internal TextureHandle(int handle, bool shared = false)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2C765BC", Offset = "0x2C725BC", VA = "0x2C765BC")]
		public static implicit operator RenderTargetIdentifier(TextureHandle texture)
		{
			return default(RenderTargetIdentifier);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2C7668C", Offset = "0x2C7268C", VA = "0x2C7668C")]
		public static implicit operator Texture(TextureHandle texture)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2C76738", Offset = "0x2C72738", VA = "0x2C76738")]
		public static implicit operator RenderTexture(TextureHandle texture)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2C767E4", Offset = "0x2C727E4", VA = "0x2C767E4")]
		public static implicit operator RTHandle(TextureHandle texture)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2C69324", Offset = "0x2C65324", VA = "0x2C69324")]
		public bool IsValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000040")]
	public enum TextureSizeMode
	{
		[Token(Token = "0x4000132")]
		Explicit,
		[Token(Token = "0x4000133")]
		Scale,
		[Token(Token = "0x4000134")]
		Functor
	}
	[Token(Token = "0x2000041")]
	public struct FastMemoryDesc
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool inFastMemory;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public FastMemoryFlags flags;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float residencyFraction;
	}
	[Token(Token = "0x2000042")]
	public struct TextureDesc
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TextureSizeMode sizeMode;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int width;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int height;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int slices;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 scale;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScaleFunc func;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DepthBits depthBufferBits;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public GraphicsFormat colorFormat;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FilterMode filterMode;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TextureWrapMode wrapMode;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextureDimension dimension;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool enableRandomWrite;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool useMipMap;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool autoGenerateMips;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool isShadowMap;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int anisoLevel;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float mipMapBias;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MSAASamples msaaSamples;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool bindTextureMS;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		public bool useDynamicScale;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public RenderTextureMemoryless memoryless;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public VRTextureUsage vrUsage;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string name;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FastMemoryDesc fastMemoryDesc;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool fallBackToBlackTexture;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool disableFallBackToImportedTexture;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		public bool clearBuffer;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color clearColor;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2C76A54", Offset = "0x2C72A54", VA = "0x2C76A54")]
		private void InitDefaultValues(bool dynamicResolution, bool xrReady)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2C76B1C", Offset = "0x2C72B1C", VA = "0x2C76B1C")]
		public TextureDesc(int width, int height, bool dynamicResolution = false, bool xrReady = false)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2C76B4C", Offset = "0x2C72B4C", VA = "0x2C76B4C")]
		public TextureDesc(Vector2 scale, bool dynamicResolution = false, bool xrReady = false)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2C76B8C", Offset = "0x2C72B8C", VA = "0x2C76B8C")]
		public TextureDesc(ScaleFunc func, bool dynamicResolution = false, bool xrReady = false)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2C76BD4", Offset = "0x2C72BD4", VA = "0x2C76BD4")]
		public TextureDesc(TextureDesc input)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2C76BDC", Offset = "0x2C72BDC", VA = "0x2C76BDC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000043")]
	[DebuggerDisplay("TextureResource ({desc.name})")]
	internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle>
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int m_TextureCreationIndex;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2C76DE0", Offset = "0x2C72DE0", VA = "0x2C76DE0", Slot = "5")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2C76E4C", Offset = "0x2C72E4C", VA = "0x2C76E4C", Slot = "9")]
		public override void CreatePooledGraphicsResource()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2C76FC4", Offset = "0x2C72FC4", VA = "0x2C76FC4", Slot = "11")]
		public override void ReleasePooledGraphicsResource(int frameIndex)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2C77124", Offset = "0x2C73124", VA = "0x2C77124", Slot = "10")]
		public override void CreateGraphicsResource(string name = "")
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2C77478", Offset = "0x2C73478", VA = "0x2C77478", Slot = "12")]
		public override void ReleaseGraphicsResource()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2C774D0", Offset = "0x2C734D0", VA = "0x2C774D0", Slot = "13")]
		public override void LogCreation(RenderGraphLogger logger)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2C775F0", Offset = "0x2C735F0", VA = "0x2C775F0", Slot = "14")]
		public override void LogRelease(RenderGraphLogger logger)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2C776D0", Offset = "0x2C736D0", VA = "0x2C776D0")]
		public TextureResource()
		{
		}
	}
	[Token(Token = "0x2000044")]
	internal class TexturePool : RenderGraphResourcePool<RTHandle>
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2C77718", Offset = "0x2C73718", VA = "0x2C77718", Slot = "8")]
		protected override void ReleaseInternalResource(RTHandle res)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2C77730", Offset = "0x2C73730", VA = "0x2C77730", Slot = "9")]
		protected override string GetResourceName(RTHandle res)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2C77750", Offset = "0x2C73750", VA = "0x2C77750", Slot = "10")]
		protected override long GetResourceSize(RTHandle res)
		{
			return default(long);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2C77768", Offset = "0x2C73768", VA = "0x2C77768", Slot = "11")]
		protected override string GetResourceTypeName()
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2C777A8", Offset = "0x2C737A8", VA = "0x2C777A8", Slot = "12")]
		protected override int GetSortIndex(RTHandle res)
		{
			return default(int);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2C777C0", Offset = "0x2C737C0", VA = "0x2C777C0", Slot = "4")]
		public override void PurgeUnusedResources(int currentFrameIndex)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2C77CE0", Offset = "0x2C73CE0", VA = "0x2C77CE0")]
		public TexturePool()
		{
		}
	}
}
namespace UnityEngine.Rendering
{
	[Token(Token = "0x2000045")]
	public class CameraSwitcher : MonoBehaviour
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera[] m_Cameras;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentCameraIndex;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Camera m_OriginalCamera;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion m_OriginalCameraRotation;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Camera m_CurrentCamera;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GUIContent[] m_CameraNames;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int[] m_CameraIndices;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DebugUI.EnumField m_DebugEntry;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_DebugEntryEnumIndex;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2C77D28", Offset = "0x2C73D28", VA = "0x2C77D28")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2C78518", Offset = "0x2C74518", VA = "0x2C78518")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2C7823C", Offset = "0x2C7423C", VA = "0x2C7823C")]
		private int GetCameraCount()
		{
			return default(int);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2C785A8", Offset = "0x2C745A8", VA = "0x2C785A8")]
		private Camera GetNextCamera()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2C785F0", Offset = "0x2C745F0", VA = "0x2C785F0")]
		private void SetCameraIndex(int index)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2C78810", Offset = "0x2C74810", VA = "0x2C78810")]
		public CameraSwitcher()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class FreeCamera : MonoBehaviour
	{
		[Token(Token = "0x400015F")]
		private const float k_MouseSensitivityMultiplier = 0.01f;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_LookSpeedController;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m_LookSpeedMouse;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_MoveSpeed;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_MoveSpeedIncrement;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_Turbo;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string kMouseX;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string kMouseY;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string kRightStickX;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string kRightStickY;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string kVertical;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string kHorizontal;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string kYAxis;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static string kSpeedAxis;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float inputRotateAxisX;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float inputRotateAxisY;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float inputChangeSpeed;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float inputVertical;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float inputHorizontal;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float inputYAxis;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool leftShiftBoost;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool leftShift;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		private bool fire1;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2C7883C", Offset = "0x2C7483C", VA = "0x2C7883C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2C78840", Offset = "0x2C74840", VA = "0x2C78840")]
		private void RegisterInputs()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2C78844", Offset = "0x2C74844", VA = "0x2C78844")]
		private void UpdateInputs()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2C78A14", Offset = "0x2C74A14", VA = "0x2C78A14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2C78E18", Offset = "0x2C74E18", VA = "0x2C78E18")]
		public FreeCamera()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public static class CommandBufferPool
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ObjectPool<CommandBuffer> s_BufferPool;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2C78F74", Offset = "0x2C74F74", VA = "0x2C78F74")]
		public static CommandBuffer Get()
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2C7901C", Offset = "0x2C7501C", VA = "0x2C7901C")]
		public static CommandBuffer Get(string name)
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2C790B4", Offset = "0x2C750B4", VA = "0x2C790B4")]
		public static void Release(CommandBuffer buffer)
		{
		}
	}
	[Token(Token = "0x2000049")]
	[Flags]
	public enum ClearFlag
	{
		[Token(Token = "0x4000179")]
		None = 0,
		[Token(Token = "0x400017A")]
		Color = 1,
		[Token(Token = "0x400017B")]
		Depth = 2,
		[Token(Token = "0x400017C")]
		Stencil = 4,
		[Token(Token = "0x400017D")]
		DepthStencil = 6,
		[Token(Token = "0x400017E")]
		ColorStencil = 5,
		[Token(Token = "0x400017F")]
		All = 7
	}
	[Token(Token = "0x200004A")]
	public static class ComponentSingleton<TType> where TType : Component
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TType s_Instance;

		[Token(Token = "0x17000040")]
		public static TType instance
		{
			[Token(Token = "0x600022E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022F")]
		public static void Release()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class ConstantBuffer
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ConstantBufferBase> m_RegisteredConstantBuffers;

		[Token(Token = "0x6000230")]
		public static void PushGlobal<CBType>(CommandBuffer cmd, in CBType data, int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x6000231")]
		public static void PushGlobal<CBType>(in CBType data, int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x6000232")]
		public static void Push<CBType>(CommandBuffer cmd, in CBType data, ComputeShader cs, int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x6000233")]
		public static void Push<CBType>(in CBType data, ComputeShader cs, int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x6000234")]
		public static void Push<CBType>(CommandBuffer cmd, in CBType data, Material mat, int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x6000235")]
		public static void Push<CBType>(in CBType data, Material mat, int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x6000236")]
		public static void UpdateData<CBType>(CommandBuffer cmd, in CBType data) where CBType : struct
		{
		}

		[Token(Token = "0x6000237")]
		public static void UpdateData<CBType>(in CBType data) where CBType : struct
		{
		}

		[Token(Token = "0x6000238")]
		public static void SetGlobal<CBType>(CommandBuffer cmd, int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x6000239")]
		public static void SetGlobal<CBType>(int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x600023A")]
		public static void Set<CBType>(CommandBuffer cmd, ComputeShader cs, int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x600023B")]
		public static void Set<CBType>(ComputeShader cs, int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x600023C")]
		public static void Set<CBType>(Material mat, int shaderId) where CBType : struct
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2C792C4", Offset = "0x2C752C4", VA = "0x2C792C4")]
		public static void ReleaseAll()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2C79478", Offset = "0x2C75478", VA = "0x2C79478")]
		internal static void Register(ConstantBufferBase cb)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2C79544", Offset = "0x2C75544", VA = "0x2C79544")]
		public ConstantBuffer()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public abstract class ConstantBufferBase
	{
		[Token(Token = "0x6000241")]
		public abstract void Release();

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2C795D8", Offset = "0x2C755D8", VA = "0x2C795D8")]
		protected ConstantBufferBase()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class ConstantBuffer<CBType> : ConstantBufferBase where CBType : struct
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HashSet<int> m_GlobalBindings;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CBType[] m_Data;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ComputeBuffer m_GPUConstantBuffer;

		[Token(Token = "0x6000243")]
		public ConstantBuffer()
		{
		}

		[Token(Token = "0x6000244")]
		public void UpdateData(CommandBuffer cmd, in CBType data)
		{
		}

		[Token(Token = "0x6000245")]
		public void UpdateData(in CBType data)
		{
		}

		[Token(Token = "0x6000246")]
		public void SetGlobal(CommandBuffer cmd, int shaderId)
		{
		}

		[Token(Token = "0x6000247")]
		public void SetGlobal(int shaderId)
		{
		}

		[Token(Token = "0x6000248")]
		public void Set(CommandBuffer cmd, ComputeShader cs, int shaderId)
		{
		}

		[Token(Token = "0x6000249")]
		public void Set(ComputeShader cs, int shaderId)
		{
		}

		[Token(Token = "0x600024A")]
		public void Set(Material mat, int shaderId)
		{
		}

		[Token(Token = "0x600024B")]
		public void PushGlobal(CommandBuffer cmd, in CBType data, int shaderId)
		{
		}

		[Token(Token = "0x600024C")]
		public void PushGlobal(in CBType data, int shaderId)
		{
		}

		[Token(Token = "0x600024D")]
		public override void Release()
		{
		}
	}
	[Token(Token = "0x200004E")]
	internal class ConstantBufferSingleton<CBType> : ConstantBuffer<CBType> where CBType : struct
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ConstantBufferSingleton<CBType> s_Instance;

		[Token(Token = "0x17000041")]
		internal static ConstantBufferSingleton<CBType> instance
		{
			[Token(Token = "0x600024E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024F")]
			set
			{
			}
		}

		[Token(Token = "0x6000250")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000251")]
		public ConstantBufferSingleton()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field, AllowMultiple = false)]
	public class DisplayInfoAttribute : Attribute
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int order;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2C795E0", Offset = "0x2C755E0", VA = "0x2C795E0")]
		public DisplayInfoAttribute()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeUsage(AttributeTargets.Field)]
	public class AdditionalPropertyAttribute : Attribute
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2C795E8", Offset = "0x2C755E8", VA = "0x2C795E8")]
		public AdditionalPropertyAttribute()
		{
		}
	}
	[Token(Token = "0x2000051")]
	internal enum CoreProfileId
	{
		[Token(Token = "0x4000189")]
		BlitTextureInPotAtlas,
		[Token(Token = "0x400018A")]
		APVCellStreamingUpdate,
		[Token(Token = "0x400018B")]
		APVScenarioBlendingUpdate
	}
	[Token(Token = "0x2000052")]
	public static class CoreUnsafeUtils
	{
		[Token(Token = "0x2000053")]
		public struct FixedBufferStringQueue
		{
			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private unsafe byte* m_ReadCursor;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private unsafe byte* m_WriteCursor;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private unsafe readonly byte* m_BufferEnd;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private unsafe readonly byte* m_BufferStart;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly int m_BufferLength;

			[Token(Token = "0x17000042")]
			public int Count
			{
				[Token(Token = "0x600026D")]
				[Address(RVA = "0x2C7A290", Offset = "0x2C76290", VA = "0x2C7A290")]
				[CompilerGenerated]
				readonly get
				{
					return default(int);
				}
				[Token(Token = "0x600026E")]
				[Address(RVA = "0x2C7A298", Offset = "0x2C76298", VA = "0x2C7A298")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x2C7A2A0", Offset = "0x2C762A0", VA = "0x2C7A2A0")]
			public unsafe FixedBufferStringQueue(byte* ptr, int length)
			{
			}

			[Token(Token = "0x6000270")]
			[Address(RVA = "0x2C7A2EC", Offset = "0x2C762EC", VA = "0x2C7A2EC")]
			public bool TryPush(string v)
			{
				return default(bool);
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0x2C7A39C", Offset = "0x2C7639C", VA = "0x2C7A39C")]
			public bool TryPop(out string v)
			{
				return default(bool);
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x2C7A2D0", Offset = "0x2C762D0", VA = "0x2C7A2D0")]
			public void Clear()
			{
			}
		}

		[Token(Token = "0x2000054")]
		public interface IKeyGetter<TValue, TKey>
		{
			[Token(Token = "0x6000273")]
			TKey Get(ref TValue v);
		}

		[Token(Token = "0x2000055")]
		internal struct DefaultKeyGetter<T> : IKeyGetter<T, T>
		{
			[Token(Token = "0x6000274")]
			public T Get(ref T v)
			{
				return (T)null;
			}
		}

		[Token(Token = "0x2000056")]
		internal struct UintKeyGetter : IKeyGetter<uint, uint>
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x2C7A404", Offset = "0x2C76404", VA = "0x2C7A404", Slot = "4")]
			public uint Get(ref uint v)
			{
				return default(uint);
			}
		}

		[Token(Token = "0x6000254")]
		public unsafe static void CopyTo<T>(this List<T> list, void* dest, int count) where T : struct
		{
		}

		[Token(Token = "0x6000255")]
		public unsafe static void CopyTo<T>(this T[] list, void* dest, int count) where T : struct
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2C795F0", Offset = "0x2C755F0", VA = "0x2C795F0")]
		private static void CalculateRadixParams(int radixBits, out int bitStates)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2C79660", Offset = "0x2C75660", VA = "0x2C79660")]
		private static int CalculateRadixSupportSize(int bitStates, int arrayLength)
		{
			return default(int);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2C7966C", Offset = "0x2C7566C", VA = "0x2C7966C")]
		private unsafe static void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, out uint* bucketIndices, out uint* bucketSizes, out uint* bucketPrefix, out uint* arrayOutput)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2C7968C", Offset = "0x2C7568C", VA = "0x2C7968C")]
		private unsafe static void MergeSort(uint* array, uint* support, int length)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2C797AC", Offset = "0x2C757AC", VA = "0x2C797AC")]
		public static void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2C798A8", Offset = "0x2C758A8", VA = "0x2C798A8")]
		public static void MergeSort(NativeArray<uint> arr, int sortSize, ref NativeArray<uint> supportArray)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2C799CC", Offset = "0x2C759CC", VA = "0x2C799CC")]
		private unsafe static void InsertionSort(uint* arr, int length)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2C79A2C", Offset = "0x2C75A2C", VA = "0x2C79A2C")]
		public static void InsertionSort(uint[] arr, int sortSize)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2C79ABC", Offset = "0x2C75ABC", VA = "0x2C79ABC")]
		public static void InsertionSort(NativeArray<uint> arr, int sortSize)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2C79B7C", Offset = "0x2C75B7C", VA = "0x2C79B7C")]
		private unsafe static void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2C79D30", Offset = "0x2C75D30", VA = "0x2C79D30")]
		public static void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits = 8)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2C79E5C", Offset = "0x2C75E5C", VA = "0x2C79E5C")]
		public static void RadixSort(NativeArray<uint> array, int sortSize, ref NativeArray<uint> supportArray, int radixBits = 8)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2C79FB0", Offset = "0x2C75FB0", VA = "0x2C79FB0")]
		public static void QuickSort(uint[] arr, int left, int right)
		{
		}

		[Token(Token = "0x6000263")]
		public unsafe static void QuickSort<T>(int count, void* data) where T : struct, IComparable<T>
		{
		}

		[Token(Token = "0x6000264")]
		public unsafe static void QuickSort<TValue, TKey, TGetter>(int count, void* data) where TValue : struct where TKey : struct, IComparable<TKey> where TGetter : struct, IKeyGetter<TValue, TKey>
		{
		}

		[Token(Token = "0x6000265")]
		public unsafe static void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right) where TValue : struct where TKey : struct, IComparable<TKey> where TGetter : struct, IKeyGetter<TValue, TKey>
		{
		}

		[Token(Token = "0x6000266")]
		public unsafe static int IndexOf<T>(void* data, int count, T v) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Token(Token = "0x6000267")]
		public unsafe static int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) where TOldValue : struct where TOldGetter : struct, IKeyGetter<TOldValue, Hash128> where TNewValue : struct where TNewGetter : struct, IKeyGetter<TNewValue, Hash128>
		{
			return default(int);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2C7A028", Offset = "0x2C76028", VA = "0x2C7A028")]
		public unsafe static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000269")]
		public unsafe static void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash) where TValue : struct where TGetter : struct, IKeyGetter<TValue, Hash128>
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2C7A0CC", Offset = "0x2C760CC", VA = "0x2C7A0CC")]
		public unsafe static void CombineHashes(int count, Hash128* hashes, Hash128* outHash)
		{
		}

		[Token(Token = "0x600026B")]
		private unsafe static int Partition<TValue, TKey, TGetter>(void* data, int left, int right) where TValue : struct where TKey : struct, IComparable<TKey> where TGetter : struct, IKeyGetter<TValue, TKey>
		{
			return default(int);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2C7A12C", Offset = "0x2C7612C", VA = "0x2C7A12C")]
		public static bool HaveDuplicates(int[] arr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000057")]
	[DebuggerDisplay("Size = {size} Capacity = {capacity}")]
	public class DynamicArray<T> where T : new()
	{
		[Token(Token = "0x2000058")]
		public struct Iterator
		{
			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly DynamicArray<T> owner;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int index;

			[Token(Token = "0x17000046")]
			public unsafe ref T Current
			{
				[Token(Token = "0x600028E")]
				get
				{
					return ref *(T*)null;
				}
			}

			[Token(Token = "0x600028D")]
			public Iterator(DynamicArray<T> setOwner)
			{
			}

			[Token(Token = "0x600028F")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000290")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000059")]
		public struct RangeEnumerable
		{
			[Token(Token = "0x200005A")]
			public struct RangeIterator
			{
				[Token(Token = "0x4000197")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private readonly DynamicArray<T> owner;

				[Token(Token = "0x4000198")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private int index;

				[Token(Token = "0x4000199")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private int first;

				[Token(Token = "0x400019A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private int last;

				[Token(Token = "0x17000047")]
				public unsafe ref T Current
				{
					[Token(Token = "0x6000293")]
					get
					{
						return ref *(T*)null;
					}
				}

				[Token(Token = "0x6000292")]
				public RangeIterator(DynamicArray<T> setOwner, int first, int numItems)
				{
				}

				[Token(Token = "0x6000294")]
				public bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x6000295")]
				public void Reset()
				{
				}
			}

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RangeIterator iterator;

			[Token(Token = "0x6000291")]
			public RangeIterator GetEnumerator()
			{
				return default(RangeIterator);
			}
		}

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] m_Array;

		[Token(Token = "0x17000043")]
		public int size
		{
			[Token(Token = "0x6000276")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000277")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public int capacity
		{
			[Token(Token = "0x6000278")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000045")]
		public unsafe ref T this[int index]
		{
			[Token(Token = "0x6000288")]
			get
			{
				return ref *(T*)null;
			}
		}

		[Token(Token = "0x6000279")]
		public DynamicArray()
		{
		}

		[Token(Token = "0x600027A")]
		public DynamicArray(int size)
		{
		}

		[Token(Token = "0x600027B")]
		public void Clear()
		{
		}

		[Token(Token = "0x600027C")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		public int Add(in T value)
		{
			return default(int);
		}

		[Token(Token = "0x600027E")]
		public void AddRange(DynamicArray<T> array)
		{
		}

		[Token(Token = "0x600027F")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000281")]
		public void RemoveRange(int index, int count)
		{
		}

		[Token(Token = "0x6000282")]
		public int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			return default(int);
		}

		[Token(Token = "0x6000283")]
		public int IndexOf(T item, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000284")]
		public int IndexOf(T item, int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000285")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000286")]
		public void Resize(int newSize, bool keepContent = false)
		{
		}

		[Token(Token = "0x6000287")]
		public void Reserve(int newCapacity, bool keepContent = false)
		{
		}

		[Token(Token = "0x6000289")]
		public static implicit operator T[](DynamicArray<T> array)
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		public Iterator GetEnumerator()
		{
			return default(Iterator);
		}

		[Token(Token = "0x600028B")]
		public RangeEnumerable SubRange(int first, int numItems)
		{
			return default(RangeEnumerable);
		}

		[Token(Token = "0x600028C")]
		internal void BumpVersion()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public static class DynamicArrayExtensions
	{
		[Token(Token = "0x6000296")]
		private static int Partition<T>(T[] data, int left, int right) where T : IComparable<T>, new()
		{
			return default(int);
		}

		[Token(Token = "0x6000297")]
		private static void QuickSort<T>(T[] data, int left, int right) where T : IComparable<T>, new()
		{
		}

		[Token(Token = "0x6000298")]
		public static void QuickSort<T>(this DynamicArray<T> array) where T : IComparable<T>, new()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public delegate float PerformDynamicRes();
	[Token(Token = "0x200005D")]
	public enum DynamicResScalePolicyType
	{
		[Token(Token = "0x400019C")]
		ReturnsPercentage,
		[Token(Token = "0x400019D")]
		ReturnsMinMaxLerpFactor
	}
	[Token(Token = "0x200005E")]
	public enum DynamicResScalerSlot
	{
		[Token(Token = "0x400019F")]
		User,
		[Token(Token = "0x40001A0")]
		System,
		[Token(Token = "0x40001A1")]
		Count
	}
	[Token(Token = "0x200005F")]
	public class DynamicResolutionHandler
	{
		[Token(Token = "0x2000060")]
		private struct ScalerContainer
		{
			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DynamicResScalePolicyType type;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public PerformDynamicRes method;
		}

		[Token(Token = "0x2000061")]
		public enum UpsamplerScheduleType
		{
			[Token(Token = "0x40001C4")]
			BeforePost,
			[Token(Token = "0x40001C5")]
			AfterDepthOfField,
			[Token(Token = "0x40001C6")]
			AfterPost
		}

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Enabled;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool m_UseMipBias;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_MinScreenFraction;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_MaxScreenFraction;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_CurrentFraction;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_ForcingRes;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool m_CurrentCameraRequest;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_PrevFraction;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_ForceSoftwareFallback;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool m_RunUpscalerFilterOnFullResolution;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_PrevHWScaleWidth;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_PrevHWScaleHeight;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector2Int m_LastScaledSize;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DynamicResScalerSlot s_ActiveScalerSlot;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ScalerContainer[] s_ScalerContainers;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector2Int cachedOriginalSize;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<int, DynamicResUpscaleFilter> s_CameraUpscaleFilters;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DynamicResolutionType type;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private GlobalDynamicResolutionSettings m_CachedSettings;

		[Token(Token = "0x40001B7")]
		private const int CameraDictionaryMaxcCapacity = 32;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private WeakReference m_OwnerCameraWeakRef;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<int, DynamicResolutionHandler> s_CameraInstances;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DynamicResolutionHandler s_DefaultInstance;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static int s_ActiveCameraId;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DynamicResolutionHandler s_ActiveInstance;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static bool s_ActiveInstanceDirty;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static float s_GlobalHwFraction;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static bool s_GlobalHwUpresActive;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UpsamplerScheduleType m_UpsamplerSchedule;

		[Token(Token = "0x17000048")]
		public DynamicResUpscaleFilter filter
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x2C7A528", Offset = "0x2C76528", VA = "0x2C7A528")]
			[CompilerGenerated]
			get
			{
				return default(DynamicResUpscaleFilter);
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x2C7A530", Offset = "0x2C76530", VA = "0x2C7A530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public Vector2Int finalViewport
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x2C7A538", Offset = "0x2C76538", VA = "0x2C7A538")]
			[CompilerGenerated]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x2C7A540", Offset = "0x2C76540", VA = "0x2C7A540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool runUpscalerFilterOnFullResolution
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x2C7A550", Offset = "0x2C76550", VA = "0x2C7A550")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x2C7A548", Offset = "0x2C76548", VA = "0x2C7A548")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public UpsamplerScheduleType upsamplerSchedule
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x2C7ABA0", Offset = "0x2C76BA0", VA = "0x2C7ABA0")]
			get
			{
				return default(UpsamplerScheduleType);
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x2C7AB98", Offset = "0x2C76B98", VA = "0x2C7AB98")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public static DynamicResolutionHandler instance
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x2C7ABA8", Offset = "0x2C76BA8", VA = "0x2C7ABA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2C7A4EC", Offset = "0x2C764EC", VA = "0x2C7A4EC")]
		private void Reset()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2C7A570", Offset = "0x2C76570", VA = "0x2C7A570")]
		private bool FlushScalableBufferManagerState()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2C7A6DC", Offset = "0x2C766DC", VA = "0x2C7A6DC")]
		private static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera)
		{
			return null;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2C7AAF0", Offset = "0x2C76AF0", VA = "0x2C7AAF0")]
		private DynamicResolutionHandler()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2C7AC50", Offset = "0x2C76C50", VA = "0x2C7AC50")]
		private static float DefaultDynamicResMethod()
		{
			return default(float);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2C7AC58", Offset = "0x2C76C58", VA = "0x2C7AC58")]
		private void ProcessSettings(GlobalDynamicResolutionSettings settings)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2C7AE2C", Offset = "0x2C76E2C", VA = "0x2C7AE2C")]
		public Vector2 GetResolvedScale()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2C7AEA0", Offset = "0x2C76EA0", VA = "0x2C7AEA0")]
		public float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = false)
		{
			return default(float);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2C7AF30", Offset = "0x2C76F30", VA = "0x2C7AF30")]
		public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2C7AFB4", Offset = "0x2C76FB4", VA = "0x2C7AFB4")]
		public static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2C7B03C", Offset = "0x2C7703C", VA = "0x2C7B03C")]
		public static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2C7B098", Offset = "0x2C77098", VA = "0x2C7B098")]
		public static void ClearSelectedCamera()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2C7B100", Offset = "0x2C77100", VA = "0x2C7B100")]
		public static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2C7B22C", Offset = "0x2C7722C", VA = "0x2C7B22C")]
		public void SetCurrentCameraRequest(bool cameraRequest)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2C7B234", Offset = "0x2C77234", VA = "0x2C7B234")]
		public static void UpdateAndUseCamera(Camera camera, [Optional] GlobalDynamicResolutionSettings? settings, [Optional] Action OnResolutionChange)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2C7B418", Offset = "0x2C77418", VA = "0x2C7B418")]
		public void Update(GlobalDynamicResolutionSettings settings, [Optional] Action OnResolutionChange)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2C7B684", Offset = "0x2C77684", VA = "0x2C7B684")]
		public bool SoftwareDynamicResIsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2C7A6AC", Offset = "0x2C766AC", VA = "0x2C7A6AC")]
		public bool HardwareDynamicResIsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2C7B6E0", Offset = "0x2C776E0", VA = "0x2C7B6E0")]
		public bool RequestsHardwareDynamicResolution()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2C7B700", Offset = "0x2C77700", VA = "0x2C7B700")]
		public bool DynamicResolutionEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2C7B748", Offset = "0x2C77748", VA = "0x2C7B748")]
		public void ForceSoftwareFallback()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2C7B754", Offset = "0x2C77754", VA = "0x2C7B754")]
		public Vector2Int GetScaledSize(Vector2Int size)
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2C7B7A4", Offset = "0x2C777A4", VA = "0x2C7B7A4")]
		public Vector2Int ApplyScalesOnSize(Vector2Int size)
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2C7B7CC", Offset = "0x2C777CC", VA = "0x2C7B7CC")]
		internal Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales)
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2C7B950", Offset = "0x2C77950", VA = "0x2C7B950")]
		public float GetCurrentScale()
		{
			return default(float);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2C7B96C", Offset = "0x2C7796C", VA = "0x2C7B96C")]
		public Vector2Int GetLastScaledSize()
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2C7B974", Offset = "0x2C77974", VA = "0x2C7B974")]
		public float GetLowResMultiplier(float targetLowRes)
		{
			return default(float);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2C7B97C", Offset = "0x2C7797C", VA = "0x2C7B97C")]
		public float GetLowResMultiplier(float targetLowRes, float minimumThreshold)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000062")]
	public enum DynamicResolutionType : byte
	{
		[Token(Token = "0x40001C8")]
		Software,
		[Token(Token = "0x40001C9")]
		Hardware
	}
	[Token(Token = "0x2000063")]
	public enum DynamicResUpscaleFilter : byte
	{
		[Token(Token = "0x40001CB")]
		[Obsolete("Bilinear upscale filter is considered obsolete and is not supported anymore, please use CatmullRom for a very cheap, but blurry filter.", false)]
		Bilinear,
		[Token(Token = "0x40001CC")]
		CatmullRom,
		[Token(Token = "0x40001CD")]
		[Obsolete("Lanczos upscale filter is considered obsolete and is not supported anymore, please use Contrast Adaptive Sharpening for very sharp filter or FidelityFX Super Resolution 1.0.", false)]
		Lanczos,
		[Token(Token = "0x40001CE")]
		ContrastAdaptiveSharpen,
		[Token(Token = "0x40001CF")]
		[InspectorName("FidelityFX Super Resolution 1.0")]
		EdgeAdaptiveScalingUpres,
		[Token(Token = "0x40001D0")]
		[InspectorName("TAA Upscale")]
		TAAU
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public struct GlobalDynamicResolutionSettings
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool enabled;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool useMipBias;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public bool enableDLSS;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint DLSSPerfQualitySetting;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DynamicResolutionHandler.UpsamplerScheduleType DLSSInjectionPoint;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool DLSSUseOptimalSettings;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float DLSSSharpness;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool fsrOverrideSharpness;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float fsrSharpness;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxPercentage;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minPercentage;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public DynamicResolutionType dynResType;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public DynamicResUpscaleFilter upsampleFilter;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool forceResolution;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float forcedPercentage;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float lowResTransparencyMinimumThreshold;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float rayTracingHalfResThreshold;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lowResSSGIMinimumThreshold;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lowResVolumetricCloudsMinimumThreshold;

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2C7AC00", Offset = "0x2C76C00", VA = "0x2C7AC00")]
		public static GlobalDynamicResolutionSettings NewDefault()
		{
			return default(GlobalDynamicResolutionSettings);
		}
	}
	[Token(Token = "0x2000065")]
	public interface IAdditionalData
	{
	}
	[Token(Token = "0x2000066")]
	public interface IVirtualTexturingEnabledRenderPipeline
	{
		[Token(Token = "0x1700004D")]
		bool virtualTexturingEnabled
		{
			[Token(Token = "0x60002C4")]
			get;
		}
	}
	[Token(Token = "0x2000067")]
	public struct ListBuffer<T> where T : struct
	{
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private unsafe T* m_BufferPtr;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_Capacity;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private unsafe int* m_CountPtr;

		[Token(Token = "0x1700004E")]
		internal unsafe T* BufferPtr
		{
			[Token(Token = "0x60002C5")]
			get
			{
				//IL_0002: Expected I, but got O
				return (T*)unchecked((nint)null);
			}
		}

		[Token(Token = "0x1700004F")]
		public int Count
		{
			[Token(Token = "0x60002C6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000050")]
		public int Capacity
		{
			[Token(Token = "0x60002C7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000051")]
		public unsafe ref T this[in int index]
		{
			[Token(Token = "0x60002C9")]
			get
			{
				return ref *(T*)null;
			}
		}

		[Token(Token = "0x60002C8")]
		public unsafe ListBuffer(T* bufferPtr, int* countPtr, int capacity)
		{
		}

		[Token(Token = "0x60002CA")]
		public unsafe ref T GetUnchecked(in int index)
		{
			return ref *(T*)null;
		}

		[Token(Token = "0x60002CB")]
		public bool TryAdd(in T value)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CC")]
		public unsafe void CopyTo(T* dstBuffer, int startDstIndex, int copyCount)
		{
		}

		[Token(Token = "0x60002CD")]
		public bool TryCopyTo(ListBuffer<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		public unsafe bool TryCopyFrom(T* srcPtr, int count)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000068")]
	public static class ListBufferExtensions
	{
		[Token(Token = "0x60002CF")]
		public static void QuickSort<T>(this ListBuffer<T> self) where T : struct, IComparable<T>
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class ObjectPool<T> where T : new()
	{
		[Token(Token = "0x200006A")]
		public struct PooledObject : IDisposable
		{
			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly T m_ToReturn;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly ObjectPool<T> m_Pool;

			[Token(Token = "0x60002D8")]
			internal PooledObject(T value, ObjectPool<T> pool)
			{
			}

			[Token(Token = "0x60002D9")]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Stack<T> m_Stack;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly UnityAction<T> m_ActionOnGet;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly UnityAction<T> m_ActionOnRelease;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly bool m_CollectionCheck;

		[Token(Token = "0x17000052")]
		public int countAll
		{
			[Token(Token = "0x60002D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public int countActive
		{
			[Token(Token = "0x60002D2")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000054")]
		public int countInactive
		{
			[Token(Token = "0x60002D3")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002D4")]
		public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = true)
		{
		}

		[Token(Token = "0x60002D5")]
		public T Get()
		{
			return (T)null;
		}

		[Token(Token = "0x60002D6")]
		public PooledObject Get(out T v)
		{
			return default(PooledObject);
		}

		[Token(Token = "0x60002D7")]
		public void Release(T element)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public static class GenericPool<T> where T : new()
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<T> s_Pool;

		[Token(Token = "0x60002DA")]
		public static T Get()
		{
			return (T)null;
		}

		[Token(Token = "0x60002DB")]
		public static ObjectPool<T>.PooledObject Get(out T value)
		{
			return default(ObjectPool<T>.PooledObject);
		}

		[Token(Token = "0x60002DC")]
		public static void Release(T toRelease)
		{
		}
	}
	[Token(Token = "0x200006C")]
	public static class UnsafeGenericPool<T> where T : new()
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<T> s_Pool;

		[Token(Token = "0x60002DE")]
		public static T Get()
		{
			return (T)null;
		}

		[Token(Token = "0x60002DF")]
		public static ObjectPool<T>.PooledObject Get(out T value)
		{
			return default(ObjectPool<T>.PooledObject);
		}

		[Token(Token = "0x60002E0")]
		public static void Release(T toRelease)
		{
		}
	}
	[Token(Token = "0x200006D")]
	public static class ListPool<T>
	{
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<List<T>> s_Pool;

		[Token(Token = "0x60002E2")]
		public static List<T> Get()
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		public static ObjectPool<List<T>>.PooledObject Get(out List<T> value)
		{
			return default(ObjectPool<List<T>>.PooledObject);
		}

		[Token(Token = "0x60002E4")]
		public static void Release(List<T> toRelease)
		{
		}
	}
	[Token(Token = "0x200006F")]
	public static class HashSetPool<T>
	{
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<HashSet<T>> s_Pool;

		[Token(Token = "0x60002E9")]
		public static HashSet<T> Get()
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		public static ObjectPool<HashSet<T>>.PooledObject Get(out HashSet<T> value)
		{
			return default(ObjectPool<HashSet<T>>.PooledObject);
		}

		[Token(Token = "0x60002EB")]
		public static void Release(HashSet<T> toRelease)
		{
		}
	}
	[Token(Token = "0x2000071")]
	public static class DictionaryPool<TKey, TValue>
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<Dictionary<TKey, TValue>> s_Pool;

		[Token(Token = "0x60002F0")]
		public static Dictionary<TKey, TValue> Get()
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		public static ObjectPool<Dictionary<TKey, TValue>>.PooledObject Get(out Dictionary<TKey, TValue> value)
		{
			return default(ObjectPool<Dictionary<TKey, TValue>>.PooledObject);
		}

		[Token(Token = "0x60002F2")]
		public static void Release(Dictionary<TKey, TValue> toRelease)
		{
		}
	}
	[Token(Token = "0x2000073")]
	public sealed class ListChangedEventArgs<T> : EventArgs
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly int index;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly T item;

		[Token(Token = "0x60002F7")]
		public ListChangedEventArgs(int index, T item)
		{
		}
	}
	[Token(Token = "0x2000074")]
	public delegate void ListChangedEventHandler<T>(ObservableList<T> sender, ListChangedEventArgs<T> e);
	[Token(Token = "0x2000075")]
	public class ObservableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IList<T> m_List;

		[Token(Token = "0x17000055")]
		public T this[int index]
		{
			[Token(Token = "0x6000300")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000301")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public int Count
		{
			[Token(Token = "0x6000302")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000057")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000303")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000005")]
		public event ListChangedEventHandler<T> ItemAdded
		{
			[Token(Token = "0x60002FC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002FD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event ListChangedEventHandler<T> ItemRemoved
		{
			[Token(Token = "0x60002FE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002FF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000304")]
		public ObservableList()
		{
		}

		[Token(Token = "0x6000305")]
		public ObservableList(int capacity)
		{
		}

		[Token(Token = "0x6000306")]
		public ObservableList(IEnumerable<T> collection)
		{
		}

		[Token(Token = "0x6000307")]
		private void OnEvent(ListChangedEventHandler<T> e, int index, T item)
		{
		}

		[Token(Token = "0x6000308")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x600030A")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x600030B")]
		public void Add(params T[] items)
		{
		}

		[Token(Token = "0x600030C")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x600030D")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		public int Remove(params T[] items)
		{
			return default(int);
		}

		[Token(Token = "0x600030F")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000310")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000311")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000312")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000076")]
	public static class RemoveRangeExtensions
	{
		[Token(Token = "0x6000314")]
		[MustUseReturnValue]
		[CollectionAccess(CollectionAccessType.ModifyExistingContent)]
		public static bool TryRemoveElementsInRange<TValue>([DisallowNull] this IList<TValue> list, int index, int count, [NotNullWhen(false)] out Exception error)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class SerializableEnum
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_EnumValueAsString;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_EnumTypeAsString;

		[Token(Token = "0x17000058")]
		public Enum value
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x2C7BC00", Offset = "0x2C77C00", VA = "0x2C7BC00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x2C7BD40", Offset = "0x2C77D40", VA = "0x2C7BD40")]
			set
			{
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2C7BD70", Offset = "0x2C77D70", VA = "0x2C7BD70")]
		public SerializableEnum(Type enumType)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class SerializedDictionary<K, V> : SerializedDictionary<K, V, K, V>
	{
		[Token(Token = "0x6000318")]
		public override K SerializeKey(K key)
		{
			return (K)null;
		}

		[Token(Token = "0x6000319")]
		public override V SerializeValue(V val)
		{
			return (V)null;
		}

		[Token(Token = "0x600031A")]
		public override K DeserializeKey(K key)
		{
			return (K)null;
		}

		[Token(Token = "0x600031B")]
		public override V DeserializeValue(V val)
		{
			return (V)null;
		}

		[Token(Token = "0x600031C")]
		public SerializedDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public abstract class SerializedDictionary<K, V, SK, SV> : Dictionary<K, V>, ISerializationCallbackReceiver
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<SK> m_Keys;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<SV> m_Values;

		[Token(Token = "0x600031D")]
		public abstract SK SerializeKey(K key);

		[Token(Token = "0x600031E")]
		public abstract SV SerializeValue(V value);

		[Token(Token = "0x600031F")]
		public abstract K DeserializeKey(SK serializedKey);

		[Token(Token = "0x6000320")]
		public abstract V DeserializeValue(SV serializedValue);

		[Token(Token = "0x6000321")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000322")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000323")]
		protected SerializedDictionary()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public static class SwapCollectionExtensions
	{
		[Token(Token = "0x6000324")]
		[MustUseReturnValue]
		[CollectionAccess(CollectionAccessType.ModifyExistingContent)]
		public static bool TrySwap<TValue>([DisallowNull] this IList<TValue> list, int from, int to, [NotNullWhen(false)] out Exception error)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class XRGraphics
	{
		[Token(Token = "0x200007C")]
		public enum StereoRenderingMode
		{
			[Token(Token = "0x4000200")]
			MultiPass,
			[Token(Token = "0x4000201")]
			SinglePass,
			[Token(Token = "0x4000202")]
			SinglePassInstanced,
			[Token(Token = "0x4000203")]
			SinglePassMultiView
		}

		[Token(Token = "0x17000059")]
		public static float eyeTextureResolutionScale
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x2C7BE18", Offset = "0x2C77E18", VA = "0x2C7BE18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x2C7BE48", Offset = "0x2C77E48", VA = "0x2C7BE48")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public static float renderViewportScale
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x2C7BE50", Offset = "0x2C77E50", VA = "0x2C7BE50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005B")]
		public static bool enabled
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x2C7BE40", Offset = "0x2C77E40", VA = "0x2C7BE40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public static bool isDeviceActive
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x2C7BE78", Offset = "0x2C77E78", VA = "0x2C7BE78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		public static string loadedDeviceName
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x2C7BEA0", Offset = "0x2C77EA0", VA = "0x2C7BEA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public static string[] supportedDevices
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x2C7BEF0", Offset = "0x2C77EF0", VA = "0x2C7BEF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public static StereoRenderingMode stereoRenderingMode
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x2C7BF44", Offset = "0x2C77F44", VA = "0x2C7BF44")]
			get
			{
				return default(StereoRenderingMode);
			}
		}

		[Token(Token = "0x17000060")]
		public static RenderTextureDescriptor eyeTextureDesc
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x2C7BF6C", Offset = "0x2C77F6C", VA = "0x2C7BF6C")]
			get
			{
				return default(RenderTextureDescriptor);
			}
		}

		[Token(Token = "0x17000061")]
		public static int eyeTextureWidth
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x2C7BFB8", Offset = "0x2C77FB8", VA = "0x2C7BFB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000062")]
		public static int eyeTextureHeight
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x2C7BFE0", Offset = "0x2C77FE0", VA = "0x2C7BFE0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2C7C008", Offset = "0x2C78008", VA = "0x2C7C008")]
		public XRGraphics()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public abstract class DebugDisplaySettings<T> : IDebugDisplaySettings, IDebugDisplaySettingsQuery where T : IDebugDisplaySettings, new()
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly HashSet<IDebugDisplaySettingsData> m_Settings;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Lazy<T> s_Instance;

		[Token(Token = "0x17000063")]
		public static T Instance
		{
			[Token(Token = "0x6000331")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x17000064")]
		public virtual bool AreAnySettingsActive
		{
			[Token(Token = "0x6000332")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public virtual bool IsPostProcessingAllowed
		{
			[Token(Token = "0x6000333")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public virtual bool IsLightingActive
		{
			[Token(Token = "0x6000334")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000335")]
		protected TData Add<TData>(TData newData) where TData : IDebugDisplaySettingsData
		{
			return (TData)null;
		}

		[Token(Token = "0x6000336")]
		public void ForEach(Action<IDebugDisplaySettingsData> onExecute)
		{
		}

		[Token(Token = "0x6000337")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x6000338")]
		public virtual bool TryGetScreenClearColor(ref Color color)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		protected DebugDisplaySettings()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public abstract class DebugDisplaySettingsPanel : IDebugDisplaySettingsPanelDisposable, IDebugDisplaySettingsPanel, IDisposable
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<DebugUI.Widget> m_Widgets;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly DisplayInfoAttribute m_DisplayInfo;

		[Token(Token = "0x17000067")]
		public virtual string PanelName
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x2C7C010", Offset = "0x2C78010", VA = "0x2C7C010", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public virtual int Order
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x2C7C06C", Offset = "0x2C7806C", VA = "0x2C7C06C", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000069")]
		public DebugUI.Widget[] Widgets
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x2C7C084", Offset = "0x2C78084", VA = "0x2C7C084", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public virtual DebugUI.Flags Flags
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x2C7C0D4", Offset = "0x2C780D4", VA = "0x2C7C0D4", Slot = "10")]
			get
			{
				return default(DebugUI.Flags);
			}
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2C7C0DC", Offset = "0x2C780DC", VA = "0x2C7C0DC")]
		protected void AddWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2C7C1CC", Offset = "0x2C781CC", VA = "0x2C7C1CC")]
		protected void Clear()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2C7C23C", Offset = "0x2C7823C", VA = "0x2C7C23C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x2C7C240", Offset = "0x2C78240", VA = "0x2C7C240")]
		protected DebugDisplaySettingsPanel()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public abstract class DebugDisplaySettingsPanel<T> : DebugDisplaySettingsPanel where T : IDebugDisplaySettingsData
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal T m_Data;

		[Token(Token = "0x1700006B")]
		public T data
		{
			[Token(Token = "0x6000346")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000347")]
			internal set
			{
			}
		}

		[Token(Token = "0x6000348")]
		protected DebugDisplaySettingsPanel(T data)
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class DebugDisplaySettingsUI : IDebugData
	{
		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IEnumerable<IDebugDisplaySettingsPanelDisposable> m_DisposablePanels;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IDebugDisplaySettings m_Settings;

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2C7C380", Offset = "0x2C78380", VA = "0x2C7C380")]
		private void Reset()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x2C7C900", Offset = "0x2C78900", VA = "0x2C7C900")]
		public void RegisterDebug(IDebugDisplaySettings settings)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x2C7C46C", Offset = "0x2C7846C", VA = "0x2C7C46C")]
		public void UnregisterDebug()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2C7CC18", Offset = "0x2C78C18", VA = "0x2C7CC18", Slot = "4")]
		public Action GetReset()
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2C7CC94", Offset = "0x2C78C94", VA = "0x2C7CC94")]
		public DebugDisplaySettingsUI()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class DebugDisplaySettingsVolume : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		[Token(Token = "0x2000084")]
		private static class Styles
		{
			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly GUIContent none;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly GUIContent editorCamera;
		}

		[Token(Token = "0x2000085")]
		private static class Strings
		{
			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly string none;

			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly string camera;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly string parameter;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly string component;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly string debugViewNotSupported;

			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static readonly string parameterNotOverrided;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static readonly string volumeInfo;

			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static readonly string gameObject;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static readonly string resultValue;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static readonly string resultValueTooltip;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static readonly string globalDefaultValue;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static readonly string globalDefaultValueTooltip;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static readonly string qualityLevelValue;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static readonly string qualityLevelValueTooltip;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static readonly string global;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static readonly string local;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static readonly string volumeProfile;
		}

		[Token(Token = "0x2000086")]
		internal static class WidgetFactory
		{
			[Token(Token = "0x2000087")]
			private struct VolumeParameterChain
			{
				[Token(Token = "0x4000224")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public DebugUI.Widget.NameAndTooltip nameAndTooltip;

				[Token(Token = "0x4000225")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public VolumeProfile volumeProfile;

				[Token(Token = "0x4000226")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public VolumeComponent volumeComponent;

				[Token(Token = "0x4000227")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Volume volume;
			}

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DebugUI.Value s_EmptyDebugUIValue;

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x2C7D4BC", Offset = "0x2C794BC", VA = "0x2C7D4BC")]
			public static DebugUI.EnumField CreateComponentSelector(SettingsPanel panel, Action<DebugUI.Field<int>, int> refresh)
			{
				return null;
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x2C7DB38", Offset = "0x2C79B38", VA = "0x2C7DB38")]
			public static DebugUI.ObjectPopupField CreateCameraSelector(SettingsPanel panel, Action<DebugUI.Field<Object>, Object> refresh)
			{
				return null;
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x2C7DD54", Offset = "0x2C79D54", VA = "0x2C7DD54")]
			private static DebugUI.Widget CreateVolumeParameterWidget(string name, bool isResultParameter, VolumeParameter param, [Optional] Func<bool> isHiddenCallback)
			{
				return null;
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x2C7DE04", Offset = "0x2C79E04", VA = "0x2C7DE04")]
			private static VolumeComponent GetSelectedVolumeComponent(VolumeProfile profile, Type selectedType)
			{
				return null;
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0x2C7DFE0", Offset = "0x2C79FE0", VA = "0x2C7DFE0")]
			private static List<VolumeParameterChain> GetResolutionChain(DebugDisplaySettingsVolume data)
			{
				return null;
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x2C7E494", Offset = "0x2C7A494", VA = "0x2C7E494")]
			public static DebugUI.Table CreateVolumeTable(DebugDisplaySettingsVolume data)
			{
				return null;
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0x2C7F150", Offset = "0x2C7B150", VA = "0x2C7F150")]
			private static void SetTableColumnVisibility(DebugDisplaySettingsVolume data, DebugUI.Table table)
			{
			}

			[Token(Token = "0x6000360")]
			[Address(RVA = "0x2C7E990", Offset = "0x2C7A990", VA = "0x2C7E990")]
			private static void GenerateTableColumns(DebugUI.Table table, DebugDisplaySettingsVolume data, List<VolumeParameterChain> resolutionChain)
			{
			}

			[Token(Token = "0x6000361")]
			[Address(RVA = "0x2C7E71C", Offset = "0x2C7A71C", VA = "0x2C7E71C")]
			private static void GenerateTableRows(DebugUI.Table table, List<VolumeParameterChain> resolutionChain)
			{
			}
		}

		[Token(Token = "0x200008E")]
		[DisplayInfo(name = "Volume", order = int.MaxValue)]
		internal class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsVolume>
		{
			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private DebugUI.Table m_VolumeTable;

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x2C7D048", Offset = "0x2C79048", VA = "0x2C7D048")]
			public SettingsPanel(DebugDisplaySettingsVolume data)
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x2C80108", Offset = "0x2C7C108", VA = "0x2C80108")]
			private void Refresh()
			{
			}
		}

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int volumeComponentEnumIndex;

		[Token(Token = "0x1700006C")]
		public IVolumeDebugSettings2 volumeDebugSettings
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x2C7CFA0", Offset = "0x2C78FA0", VA = "0x2C7CFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public bool AreAnySettingsActive
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x2C7CFD0", Offset = "0x2C78FD0", VA = "0x2C7CFD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		public bool IsPostProcessingAllowed
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x2C7CFD8", Offset = "0x2C78FD8", VA = "0x2C7CFD8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		public bool IsLightingActive
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x2C7CFE0", Offset = "0x2C78FE0", VA = "0x2C7CFE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x2C7CFA8", Offset = "0x2C78FA8", VA = "0x2C7CFA8")]
		public DebugDisplaySettingsVolume(IVolumeDebugSettings2 volumeDebugSettings)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x2C7CFE8", Offset = "0x2C78FE8", VA = "0x2C7CFE8", Slot = "8")]
		public bool TryGetScreenClearColor(ref Color color)
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x2C7CFF0", Offset = "0x2C78FF0", VA = "0x2C7CFF0", Slot = "4")]
		public IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			return null;
		}
	}
	[Token(Token = "0x200008F")]
	public class DebugFrameTiming
	{
		[Token(Token = "0x4000235")]
		private const string k_FpsFormatString = "{0:F1}";

		[Token(Token = "0x4000236")]
		private const string k_MsFormatString = "{0:F2}ms";

		[Token(Token = "0x4000237")]
		private const float k_RefreshRate = 0.2f;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal FrameTimeSampleHistory m_FrameHistory;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal BottleneckHistory m_BottleneckHistory;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FrameTiming[] m_Timing;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FrameTimeSample m_Sample;

		[Token(Token = "0x17000070")]
		public int bottleneckHistorySize
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x2C803AC", Offset = "0x2C7C3AC", VA = "0x2C803AC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x2C803B4", Offset = "0x2C7C3B4", VA = "0x2C803B4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public int sampleHistorySize
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x2C803BC", Offset = "0x2C7C3BC", VA = "0x2C803BC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x2C803C4", Offset = "0x2C7C3C4", VA = "0x2C803C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2C803CC", Offset = "0x2C7C3CC", VA = "0x2C803CC")]
		public DebugFrameTiming()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x2C804A4", Offset = "0x2C7C4A4", VA = "0x2C804A4")]
		public void UpdateFrameTiming()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2C80684", Offset = "0x2C7C684", VA = "0x2C80684")]
		public void RegisterDebugUI(List<DebugUI.Widget> list)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2C81788", Offset = "0x2C7D788", VA = "0x2C81788")]
		internal void Reset()
		{
		}
	}
	[Token(Token = "0x2000090")]
	internal enum DebugAction
	{
		[Token(Token = "0x400023F")]
		EnableDebugMenu,
		[Token(Token = "0x4000240")]
		PreviousDebugPanel,
		[Token(Token = "0x4000241")]
		NextDebugPanel,
		[Token(Token = "0x4000242")]
		Action,
		[Token(Token = "0x4000243")]
		MakePersistent,
		[Token(Token = "0x4000244")]
		MoveVertical,
		[Token(Token = "0x4000245")]
		MoveHorizontal,
		[Token(Token = "0x4000246")]
		Multiplier,
		[Token(Token = "0x4000247")]
		ResetAll,
		[Token(Token = "0x4000248")]
		DebugActionCount
	}
	[Token(Token = "0x2000091")]
	internal enum DebugActionRepeatMode
	{
		[Token(Token = "0x400024A")]
		Never,
		[Token(Token = "0x400024B")]
		Delay
	}
	[Token(Token = "0x2000092")]
	public sealed class DebugManager
	{
		[Token(Token = "0x2000093")]
		public enum UIMode
		{
			[Token(Token = "0x400026A")]
			EditorMode,
			[Token(Token = "0x400026B")]
			RuntimeMode
		}

		[Token(Token = "0x2000094")]
		private class UIState
		{
			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIMode mode;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private bool m_Open;

			[Token(Token = "0x17000079")]
			public bool open
			{
				[Token(Token = "0x60003D2")]
				[Address(RVA = "0x2C86054", Offset = "0x2C82054", VA = "0x2C86054")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003D3")]
				[Address(RVA = "0x2C85AA8", Offset = "0x2C81AA8", VA = "0x2C85AA8")]
				set
				{
				}
			}

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x2C83AD8", Offset = "0x2C7FAD8", VA = "0x2C83AD8")]
			public UIState()
			{
			}
		}

		[Token(Token = "0x400024C")]
		private const string kEnableDebugBtn1 = "Enable Debug Button 1";

		[Token(Token = "0x400024D")]
		private const string kEnableDebugBtn2 = "Enable Debug Button 2";

		[Token(Token = "0x400024E")]
		private const string kDebugPreviousBtn = "Debug Previous";

		[Token(Token = "0x400024F")]
		private const string kDebugNextBtn = "Debug Next";

		[Token(Token = "0x4000250")]
		private const string kValidateBtn = "Debug Validate";

		[Token(Token = "0x4000251")]
		private const string kPersistentBtn = "Debug Persistent";

		[Token(Token = "0x4000252")]
		private const string kDPadVertical = "Debug Vertical";

		[Token(Token = "0x4000253")]
		private const string kDPadHorizontal = "Debug Horizontal";

		[Token(Token = "0x4000254")]
		private const string kMultiplierBtn = "Debug Multiplier";

		[Token(Token = "0x4000255")]
		private const string kResetBtn = "Debug Reset";

		[Token(Token = "0x4000256")]
		private const string kEnableDebug = "Enable Debug";

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DebugActionDesc[] m_DebugActions;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DebugActionState[] m_DebugActionStates;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Lazy<DebugManager> s_Instance;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ReadOnlyCollection<DebugUI.Panel> m_ReadOnlyPanels;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<DebugUI.Panel> m_Panels;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool refreshEditorRequested;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int? m_RequestedPanelIndex;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject m_Root;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DebugUIHandlerCanvas m_RootUICanvas;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject m_PersistentRoot;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UIState editorUIState;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_EnableRuntimeUI;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UIState runtimeUIState;

		[Token(Token = "0x17000072")]
		public static DebugManager instance
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x2C782C4", Offset = "0x2C742C4", VA = "0x2C782C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public ReadOnlyCollection<DebugUI.Panel> panels
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x2C83430", Offset = "0x2C7F430", VA = "0x2C83430")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public bool isAnyDebugUIActive
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x2C83824", Offset = "0x2C7F824", VA = "0x2C83824")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public bool displayEditorUI
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x2C85A78", Offset = "0x2C81A78", VA = "0x2C85A78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x2C85A90", Offset = "0x2C81A90", VA = "0x2C85A90")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool enableRuntimeUI
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x2C85B3C", Offset = "0x2C81B3C", VA = "0x2C85B3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x2C85B44", Offset = "0x2C81B44", VA = "0x2C85B44")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public bool displayRuntimeUI
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x2C78D90", Offset = "0x2C74D90", VA = "0x2C78D90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x2C85B74", Offset = "0x2C81B74", VA = "0x2C85B74")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public bool displayPersistentRuntimeUI
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x2C8384C", Offset = "0x2C7F84C", VA = "0x2C8384C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x2C85EB4", Offset = "0x2C81EB4", VA = "0x2C85EB4")]
			set
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<bool> onDisplayRuntimeUIChanged
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x2C83454", Offset = "0x2C7F454", VA = "0x2C83454")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x2C83504", Offset = "0x2C7F504", VA = "0x2C83504")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event Action onSetDirty
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x2C835B4", Offset = "0x2C7F5B4", VA = "0x2C835B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x2C83650", Offset = "0x2C7F650", VA = "0x2C83650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		private event Action resetData
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x2C836EC", Offset = "0x2C7F6EC", VA = "0x2C836EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x2C83788", Offset = "0x2C7F788", VA = "0x2C83788")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public static event Action<UIMode, bool> windowStateChanged
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x2C85890", Offset = "0x2C81890", VA = "0x2C85890")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x2C85984", Offset = "0x2C81984", VA = "0x2C85984")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2C81FF8", Offset = "0x2C7DFF8", VA = "0x2C81FF8")]
		private void RegisterActions()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2C829A4", Offset = "0x2C7E9A4", VA = "0x2C829A4")]
		internal void EnableInputActions()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2C828C4", Offset = "0x2C7E8C4", VA = "0x2C828C4")]
		private void AddAction(DebugAction action, DebugActionDesc desc)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2C829F8", Offset = "0x2C7E9F8", VA = "0x2C829F8")]
		private void SampleAction(int actionIndex)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x2C82EEC", Offset = "0x2C7EEEC", VA = "0x2C82EEC")]
		private void UpdateAction(int actionIndex)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x2C83144", Offset = "0x2C7F144", VA = "0x2C83144")]
		internal void UpdateActions()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2C8319C", Offset = "0x2C7F19C", VA = "0x2C8319C")]
		internal float GetAction(DebugAction action)
		{
			return default(float);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2C831D4", Offset = "0x2C7F1D4", VA = "0x2C831D4")]
		internal bool GetActionToggleDebugMenuWithTouch()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2C83324", Offset = "0x2C7F324", VA = "0x2C83324")]
		internal bool GetActionReleaseScrollTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2C833B0", Offset = "0x2C7F3B0", VA = "0x2C833B0")]
		private void RegisterInputs()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2C833B4", Offset = "0x2C7F3B4", VA = "0x2C833B4")]
		private void UpdateReadOnlyCollection()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2C838D4", Offset = "0x2C7F8D4", VA = "0x2C838D4")]
		private DebugManager()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2C7CAAC", Offset = "0x2C78AAC", VA = "0x2C7CAAC")]
		public void RefreshEditor()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2C83AE0", Offset = "0x2C7FAE0", VA = "0x2C83AE0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2C7FF54", Offset = "0x2C7BF54", VA = "0x2C7FF54")]
		public void ReDrawOnScreenDebug()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2C7CAC0", Offset = "0x2C78AC0", VA = "0x2C7CAC0")]
		public void RegisterData(IDebugData data)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2C7CB6C", Offset = "0x2C78B6C", VA = "0x2C7CB6C")]
		public void UnregisterData(IDebugData data)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x2C83B0C", Offset = "0x2C7FB0C", VA = "0x2C83B0C")]
		public int GetState()
		{
			return default(int);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2C83C58", Offset = "0x2C7FC58", VA = "0x2C83C58")]
		internal void RegisterRootCanvas(DebugUIHandlerCanvas root)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2C83C8C", Offset = "0x2C7FC8C", VA = "0x2C83C8C")]
		internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2C83CA8", Offset = "0x2C7FCA8", VA = "0x2C83CA8")]
		internal void SetScrollTarget(DebugUIHandlerWidget widget)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2C83D40", Offset = "0x2C7FD40", VA = "0x2C83D40")]
		private void EnsurePersistentCanvas()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2C83F28", Offset = "0x2C7FF28", VA = "0x2C83F28")]
		internal void TogglePersistent(DebugUI.Widget widget, [Optional] int? forceTupleIndex)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2C84450", Offset = "0x2C80450", VA = "0x2C84450")]
		private void OnPanelDirty(DebugUI.Panel panel)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x2C84470", Offset = "0x2C80470", VA = "0x2C84470")]
		public int PanelIndex([DisallowNull] string displayName)
		{
			return default(int);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2C84548", Offset = "0x2C80548", VA = "0x2C84548")]
		public string PanelDiplayName([DisallowNull] int panelIndex)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2C845F0", Offset = "0x2C805F0", VA = "0x2C845F0")]
		public void RequestEditorWindowPanelIndex(int index)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2C84658", Offset = "0x2C80658", VA = "0x2C84658")]
		internal int? GetRequestedEditorWindowPanelIndex()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2C7833C", Offset = "0x2C7433C", VA = "0x2C7833C")]
		public DebugUI.Panel GetPanel(string displayName, bool createIfNull = false, int groupIndex = 0, bool overrideIfExist = false)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2C84A04", Offset = "0x2C80A04", VA = "0x2C84A04")]
		public int FindPanelIndex(string displayName)
		{
			return default(int);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2C84AE4", Offset = "0x2C80AE4", VA = "0x2C84AE4")]
		public void RemovePanel(string displayName)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2C84718", Offset = "0x2C80718", VA = "0x2C84718")]
		public void RemovePanel(DebugUI.Panel panel)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2C84C98", Offset = "0x2C80C98", VA = "0x2C84C98")]
		public DebugUI.Widget[] GetItems(DebugUI.Flags flags)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2C84F2C", Offset = "0x2C80F2C", VA = "0x2C84F2C")]
		internal DebugUI.Widget[] GetItemsFromContainer(DebugUI.Flags flags, DebugUI.IContainer container)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2C85418", Offset = "0x2C81418", VA = "0x2C85418")]
		public DebugUI.Widget GetItem(string queryPath)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2C85564", Offset = "0x2C81564", VA = "0x2C85564")]
		private DebugUI.Widget GetItem(string queryPath, DebugUI.IContainer container)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2C85F30", Offset = "0x2C81F30", VA = "0x2C85F30")]
		[Obsolete("Use DebugManager.instance.displayEditorUI.open property instead. #from(23.1)")]
		public void ToggleEditorUI(bool open)
		{
		}
	}
	[Token(Token = "0x2000097")]
	internal class DebugActionDesc
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string axisTrigger;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string[]> buttonTriggerList;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<KeyCode[]> keyTriggerList;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DebugActionRepeatMode repeatMode;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float repeatDelay;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2C827E4", Offset = "0x2C7E7E4", VA = "0x2C827E4")]
		public DebugActionDesc()
		{
		}
	}
	[Token(Token = "0x2000098")]
	internal class DebugActionState
	{
		[Token(Token = "0x2000099")]
		private enum DebugActionKeyType
		{
			[Token(Token = "0x4000281")]
			Button,
			[Token(Token = "0x4000282")]
			Axis,
			[Token(Token = "0x4000283")]
			Key
		}

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DebugActionKeyType m_Type;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string[] m_PressedButtons;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_PressedAxis;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private KeyCode[] m_PressedKeys;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool[] m_TriggerPressedUp;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Timer;

		[Token(Token = "0x1700007A")]
		internal bool runningAction
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x2C861B4", Offset = "0x2C821B4", VA = "0x2C861B4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x2C861BC", Offset = "0x2C821BC", VA = "0x2C861BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		internal float actionState
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x2C861C4", Offset = "0x2C821C4", VA = "0x2C861C4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x2C861CC", Offset = "0x2C821CC", VA = "0x2C861CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2C861D4", Offset = "0x2C821D4", VA = "0x2C861D4")]
		private void Trigger(int triggerCount, float state)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2C82DE0", Offset = "0x2C7EDE0", VA = "0x2C82DE0")]
		public void TriggerWithButton(string[] buttons, float state)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2C82E58", Offset = "0x2C7EE58", VA = "0x2C82E58")]
		public void TriggerWithAxis(string axis, float state)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2C82E70", Offset = "0x2C7EE70", VA = "0x2C82E70")]
		public void TriggerWithKey(KeyCode[] keys, float state)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2C86284", Offset = "0x2C82284", VA = "0x2C86284")]
		private void Reset()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x2C82F50", Offset = "0x2C7EF50", VA = "0x2C82F50")]
		public void Update(DebugActionDesc desc)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x2C829A8", Offset = "0x2C7E9A8", VA = "0x2C829A8")]
		public DebugActionState()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public interface IDebugData
	{
		[Token(Token = "0x60003E9")]
		Action GetReset();
	}
	[Token(Token = "0x200009B")]
	public class DebugShapes
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DebugShapes s_Instance;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Mesh m_sphereMesh;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Mesh m_boxMesh;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh m_coneMesh;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh m_pyramidMesh;

		[Token(Token = "0x1700007C")]
		public static DebugShapes instance
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x2C86294", Offset = "0x2C82294", VA = "0x2C86294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2C86314", Offset = "0x2C82314", VA = "0x2C86314")]
		private void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2C869E0", Offset = "0x2C829E0", VA = "0x2C869E0")]
		private void BuildBox(ref Mesh outputMesh, float length, float width, float height)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2C87128", Offset = "0x2C83128", VA = "0x2C87128")]
		private void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2C879EC", Offset = "0x2C839EC", VA = "0x2C879EC")]
		private void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2C87CE4", Offset = "0x2C83CE4", VA = "0x2C87CE4")]
		private void BuildShapes()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2C87DD4", Offset = "0x2C83DD4", VA = "0x2C87DD4")]
		private void RebuildResources()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2C87EC4", Offset = "0x2C83EC4", VA = "0x2C87EC4")]
		public Mesh RequestSphereMesh()
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2C87EDC", Offset = "0x2C83EDC", VA = "0x2C87EDC")]
		public Mesh RequestBoxMesh()
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2C87EF4", Offset = "0x2C83EF4", VA = "0x2C87EF4")]
		public Mesh RequestConeMesh()
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2C87F0C", Offset = "0x2C83F0C", VA = "0x2C87F0C")]
		public Mesh RequestPyramidMesh()
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2C8630C", Offset = "0x2C8230C", VA = "0x2C8630C")]
		public DebugShapes()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class DebugUI
	{
		[Token(Token = "0x200009D")]
		public class Container : Widget, IContainer
		{
			[Token(Token = "0x4000289")]
			private const string k_IDToken = "#";

			[Token(Token = "0x1700007D")]
			internal bool hideDisplayName
			{
				[Token(Token = "0x60003F7")]
				[Address(RVA = "0x2C87F2C", Offset = "0x2C83F2C", VA = "0x2C87F2C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700007E")]
			public ObservableList<Widget> children
			{
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0x2C87FA0", Offset = "0x2C83FA0", VA = "0x2C87FA0", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003F9")]
				[Address(RVA = "0x2C87FA8", Offset = "0x2C83FA8", VA = "0x2C87FA8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public override Panel panel
			{
				[Token(Token = "0x60003FA")]
				[Address(RVA = "0x2C87FB0", Offset = "0x2C83FB0", VA = "0x2C87FB0", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003FB")]
				[Address(RVA = "0x2C87FB8", Offset = "0x2C83FB8", VA = "0x2C87FB8", Slot = "5")]
				internal set
				{
				}
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x2C88080", Offset = "0x2C84080", VA = "0x2C88080")]
			public Container()
			{
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x2C882F0", Offset = "0x2C842F0", VA = "0x2C882F0")]
			public Container(string id)
			{
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x2C8811C", Offset = "0x2C8411C", VA = "0x2C8811C")]
			public Container(string displayName, ObservableList<Widget> children)
			{
			}

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x2C883AC", Offset = "0x2C843AC", VA = "0x2C883AC", Slot = "11")]
			internal override void GenerateQueryPath()
			{
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x2C88548", Offset = "0x2C84548", VA = "0x2C88548", Slot = "16")]
			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x2C88678", Offset = "0x2C84678", VA = "0x2C88678", Slot = "17")]
			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x2C886E0", Offset = "0x2C846E0", VA = "0x2C886E0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x200009E")]
		public class Foldout : Container, IValueField
		{
			[Token(Token = "0x200009F")]
			public struct ContextMenuItem
			{
				[Token(Token = "0x4000290")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string displayName;

				[Token(Token = "0x4000291")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public Action action;
			}

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool opened;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
			public bool isHeader;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<ContextMenuItem> contextMenuItems;

			[Token(Token = "0x17000080")]
			public bool isReadOnly
			{
				[Token(Token = "0x6000403")]
				[Address(RVA = "0x2C88848", Offset = "0x2C84848", VA = "0x2C88848")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000081")]
			public string[] columnLabels
			{
				[Token(Token = "0x6000404")]
				[Address(RVA = "0x2C88850", Offset = "0x2C84850", VA = "0x2C88850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000405")]
				[Address(RVA = "0x2C88858", Offset = "0x2C84858", VA = "0x2C88858")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public string[] columnTooltips
			{
				[Token(Token = "0x6000406")]
				[Address(RVA = "0x2C88860", Offset = "0x2C84860", VA = "0x2C88860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000407")]
				[Address(RVA = "0x2C88868", Offset = "0x2C84868", VA = "0x2C88868")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x2C81768", Offset = "0x2C7D768", VA = "0x2C81768")]
			public Foldout()
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x2C88870", Offset = "0x2C84870", VA = "0x2C88870")]
			public Foldout(string displayName, ObservableList<Widget> children, [Optional] string[] columnLabels, [Optional] string[] columnTooltips)
			{
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x2C88898", Offset = "0x2C84898", VA = "0x2C88898")]
			public bool GetValue()
			{
				return default(bool);
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x2C888A0", Offset = "0x2C848A0", VA = "0x2C888A0", Slot = "18")]
			private object UnityEngine.Rendering.DebugUI.IValueField.GetValue()
			{
				return null;
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x2C888FC", Offset = "0x2C848FC", VA = "0x2C888FC", Slot = "19")]
			public void SetValue(object value)
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x2C88974", Offset = "0x2C84974", VA = "0x2C88974", Slot = "20")]
			public object ValidateValue(object value)
			{
				return null;
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x2C8897C", Offset = "0x2C8497C", VA = "0x2C8897C")]
			public void SetValue(bool value)
			{
			}
		}

		[Token(Token = "0x20000A0")]
		public class HBox : Container
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x2C88984", Offset = "0x2C84984", VA = "0x2C88984")]
			public HBox()
			{
			}
		}

		[Token(Token = "0x20000A1")]
		public class VBox : Container
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x2C889D4", Offset = "0x2C849D4", VA = "0x2C889D4")]
			public VBox()
			{
			}
		}

		[Token(Token = "0x20000A2")]
		public class Table : Container
		{
			[Token(Token = "0x20000A3")]
			public class Row : Foldout
			{
				[Token(Token = "0x6000417")]
				[Address(RVA = "0x2C7F598", Offset = "0x2C7B598", VA = "0x2C7F598")]
				public Row()
				{
				}
			}

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool isReadOnly;

			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool[] m_Header;

			[Token(Token = "0x17000083")]
			public bool[] VisibleColumns
			{
				[Token(Token = "0x6000414")]
				[Address(RVA = "0x2C88A24", Offset = "0x2C84A24", VA = "0x2C88A24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x2C7E6CC", Offset = "0x2C7A6CC", VA = "0x2C7E6CC")]
			public Table()
			{
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x2C7F494", Offset = "0x2C7B494", VA = "0x2C7F494")]
			public void SetColumnVisibility(int index, bool visible)
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x2C88C50", Offset = "0x2C84C50", VA = "0x2C88C50")]
			public bool GetColumnVisibility(int index)
			{
				return default(bool);
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x2C88C94", Offset = "0x2C84C94", VA = "0x2C88C94", Slot = "16")]
			protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x2C88CAC", Offset = "0x2C84CAC", VA = "0x2C88CAC", Slot = "17")]
			protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}
		}

		[Token(Token = "0x20000A4")]
		[Flags]
		public enum Flags
		{
			[Token(Token = "0x4000295")]
			None = 0,
			[Token(Token = "0x4000296")]
			EditorOnly = 2,
			[Token(Token = "0x4000297")]
			RuntimeOnly = 4,
			[Token(Token = "0x4000298")]
			EditorForceUpdate = 8,
			[Token(Token = "0x4000299")]
			FrequentlyUsed = 0x10
		}

		[Token(Token = "0x20000A5")]
		public abstract class Widget
		{
			[Token(Token = "0x20000A6")]
			public struct NameAndTooltip
			{
				[Token(Token = "0x40002A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string name;

				[Token(Token = "0x40002A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string tooltip;
			}

			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			protected Panel m_Panel;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected IContainer m_Parent;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Func<bool> isHiddenCallback;

			[Token(Token = "0x17000084")]
			public virtual Panel panel
			{
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x2C88CC4", Offset = "0x2C84CC4", VA = "0x2C88CC4", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000419")]
				[Address(RVA = "0x2C88CCC", Offset = "0x2C84CCC", VA = "0x2C88CCC", Slot = "5")]
				internal set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public virtual IContainer parent
			{
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x2C88CD4", Offset = "0x2C84CD4", VA = "0x2C88CD4", Slot = "6")]
				get
				{
					return null;
				}
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x2C88CDC", Offset = "0x2C84CDC", VA = "0x2C88CDC", Slot = "7")]
				internal set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public Flags flags
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x2C88CE4", Offset = "0x2C84CE4", VA = "0x2C88CE4")]
				[CompilerGenerated]
				get
				{
					return default(Flags);
				}
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x2C88CEC", Offset = "0x2C84CEC", VA = "0x2C88CEC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000087")]
			public string displayName
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x2C88CF4", Offset = "0x2C84CF4", VA = "0x2C88CF4", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600041F")]
				[Address(RVA = "0x2C88CFC", Offset = "0x2C84CFC", VA = "0x2C88CFC", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public string tooltip
			{
				[Token(Token = "0x6000420")]
				[Address(RVA = "0x2C88D04", Offset = "0x2C84D04", VA = "0x2C88D04")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000421")]
				[Address(RVA = "0x2C88D0C", Offset = "0x2C84D0C", VA = "0x2C88D0C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public string queryPath
			{
				[Token(Token = "0x6000422")]
				[Address(RVA = "0x2C88D14", Offset = "0x2C84D14", VA = "0x2C88D14", Slot = "10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000423")]
				[Address(RVA = "0x2C88D1C", Offset = "0x2C84D1C", VA = "0x2C88D1C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public bool isEditorOnly
			{
				[Token(Token = "0x6000424")]
				[Address(RVA = "0x2C88D24", Offset = "0x2C84D24", VA = "0x2C88D24")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008B")]
			public bool isRuntimeOnly
			{
				[Token(Token = "0x6000425")]
				[Address(RVA = "0x2C88D30", Offset = "0x2C84D30", VA = "0x2C88D30")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008C")]
			public bool isInactiveInEditor
			{
				[Token(Token = "0x6000426")]
				[Address(RVA = "0x2C88D3C", Offset = "0x2C84D3C", VA = "0x2C88D3C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008D")]
			public bool isHidden
			{
				[Token(Token = "0x6000427")]
				[Address(RVA = "0x2C88828", Offset = "0x2C84828", VA = "0x2C88828")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008E")]
			public NameAndTooltip nameAndTooltip
			{
				[Token(Token = "0x600042A")]
				[Address(RVA = "0x2C7F4F0", Offset = "0x2C7B4F0", VA = "0x2C7F4F0")]
				set
				{
				}
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x2C88464", Offset = "0x2C84464", VA = "0x2C88464", Slot = "11")]
			internal virtual void GenerateQueryPath()
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x2C88DAC", Offset = "0x2C84DAC", VA = "0x2C88DAC", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x2C883A4", Offset = "0x2C843A4", VA = "0x2C883A4")]
			protected Widget()
			{
			}
		}

		[Token(Token = "0x20000A7")]
		public interface IContainer
		{
			[Token(Token = "0x1700008F")]
			ObservableList<Widget> children
			{
				[Token(Token = "0x600042C")]
				get;
			}

			[Token(Token = "0x17000090")]
			string displayName
			{
				[Token(Token = "0x600042D")]
				get;
				[Token(Token = "0x600042E")]
				set;
			}

			[Token(Token = "0x17000091")]
			string queryPath
			{
				[Token(Token = "0x600042F")]
				get;
			}
		}

		[Token(Token = "0x20000A8")]
		public interface IValueField
		{
			[Token(Token = "0x6000430")]
			object GetValue();

			[Token(Token = "0x6000431")]
			void SetValue(object value);

			[Token(Token = "0x6000432")]
			object ValidateValue(object value);
		}

		[Token(Token = "0x20000A9")]
		public class Button : Widget
		{
			[Token(Token = "0x17000092")]
			public Action action
			{
				[Token(Token = "0x6000433")]
				[Address(RVA = "0x2C88E54", Offset = "0x2C84E54", VA = "0x2C88E54")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000434")]
				[Address(RVA = "0x2C88E5C", Offset = "0x2C84E5C", VA = "0x2C88E5C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x2C88E64", Offset = "0x2C84E64", VA = "0x2C88E64")]
			public Button()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		public class Value : Widget
		{
			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float refreshRate;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string formatString;

			[Token(Token = "0x17000093")]
			public Func<object> getter
			{
				[Token(Token = "0x6000436")]
				[Address(RVA = "0x2C88E6C", Offset = "0x2C84E6C", VA = "0x2C88E6C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000437")]
				[Address(RVA = "0x2C88E74", Offset = "0x2C84E74", VA = "0x2C88E74")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2C7DDA4", Offset = "0x2C79DA4", VA = "0x2C7DDA4")]
			public Value()
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x2C88E7C", Offset = "0x2C84E7C", VA = "0x2C88E7C", Slot = "12")]
			public virtual object GetValue()
			{
				return null;
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x2C88E9C", Offset = "0x2C84E9C", VA = "0x2C88E9C", Slot = "13")]
			public virtual string FormatString(object value)
			{
				return null;
			}
		}

		[Token(Token = "0x20000AB")]
		public class ProgressBarValue : Value
		{
			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float min;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float max;

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x2C88F08", Offset = "0x2C84F08", VA = "0x2C88F08", Slot = "13")]
			public override string FormatString(object value)
			{
				return null;
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x2C8177C", Offset = "0x2C7D77C", VA = "0x2C8177C")]
			public ProgressBarValue()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		public class ValueTuple : Widget
		{
			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Value[] values;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int pinnedElementIndex;

			[Token(Token = "0x17000094")]
			public int numElements
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x2C88FFC", Offset = "0x2C84FFC", VA = "0x2C88FFC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000095")]
			public float refreshRate
			{
				[Token(Token = "0x600043F")]
				[Address(RVA = "0x2C89014", Offset = "0x2C85014", VA = "0x2C89014")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x2C8176C", Offset = "0x2C7D76C", VA = "0x2C8176C")]
			public ValueTuple()
			{
			}
		}

		[Token(Token = "0x20000AD")]
		public abstract class Field<T> : Widget, IValueField
		{
			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<Field<T>, T> onValueChanged;

			[Token(Token = "0x17000096")]
			public Func<T> getter
			{
				[Token(Token = "0x6000441")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000442")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000097")]
			public Action<T> setter
			{
				[Token(Token = "0x6000443")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000444")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000445")]
			private object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value)
			{
				return null;
			}

			[Token(Token = "0x6000446")]
			public virtual T ValidateValue(T value)
			{
				return (T)null;
			}

			[Token(Token = "0x6000447")]
			private object UnityEngine.Rendering.DebugUI.IValueField.GetValue()
			{
				return null;
			}

			[Token(Token = "0x6000448")]
			public T GetValue()
			{
				return (T)null;
			}

			[Token(Token = "0x6000449")]
			public void SetValue(object value)
			{
			}

			[Token(Token = "0x600044A")]
			public virtual void SetValue(T value)
			{
			}

			[Token(Token = "0x600044B")]
			protected Field()
			{
			}
		}

		[Token(Token = "0x20000AE")]
		public class BoolField : Field<bool>
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x2C89074", Offset = "0x2C85074", VA = "0x2C89074")]
			public BoolField()
			{
			}
		}

		[Token(Token = "0x20000AF")]
		public class HistoryBoolField : BoolField
		{
			[Token(Token = "0x17000098")]
			public Func<bool>[] historyGetter
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x2C890BC", Offset = "0x2C850BC", VA = "0x2C890BC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x2C890C4", Offset = "0x2C850C4", VA = "0x2C890C4")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000099")]
			public int historyDepth
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x2C890CC", Offset = "0x2C850CC", VA = "0x2C890CC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x2C890E4", Offset = "0x2C850E4", VA = "0x2C890E4")]
			public bool GetHistoryValue(int historyIndex)
			{
				return default(bool);
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x2C89124", Offset = "0x2C85124", VA = "0x2C89124")]
			public HistoryBoolField()
			{
			}
		}

		[Token(Token = "0x20000B0")]
		public class IntField : Field<int>
		{
			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Func<int> min;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Func<int> max;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public int incStep;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public int intStepMult;

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x2C89128", Offset = "0x2C85128", VA = "0x2C89128", Slot = "15")]
			public override int ValidateValue(int value)
			{
				return default(int);
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x2C8918C", Offset = "0x2C8518C", VA = "0x2C8918C")]
			public IntField()
			{
			}
		}

		[Token(Token = "0x20000B1")]
		public class UIntField : Field<uint>
		{
			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Func<uint> min;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Func<uint> max;

			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public uint incStep;

			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public uint intStepMult;

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x2C891E0", Offset = "0x2C851E0", VA = "0x2C891E0", Slot = "15")]
			public override uint ValidateValue(uint value)
			{
				return default(uint);
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x2C89244", Offset = "0x2C85244", VA = "0x2C89244")]
			public UIntField()
			{
			}
		}

		[Token(Token = "0x20000B2")]
		public class FloatField : Field<float>
		{
			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Func<float> min;

			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Func<float> max;

			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public float incStep;

			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public float incStepMult;

			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public int decimals;

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x2C89298", Offset = "0x2C85298", VA = "0x2C89298", Slot = "15")]
			public override float ValidateValue(float value)
			{
				return default(float);
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x2C892F8", Offset = "0x2C852F8", VA = "0x2C892F8")]
			public FloatField()
			{
			}
		}

		[Token(Token = "0x20000B3")]
		public abstract class EnumField<T> : Field<T>
		{
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GUIContent[] enumNames;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int[] m_EnumValues;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Regex s_NicifyRegEx;

			[Token(Token = "0x1700009A")]
			public int[] enumValues
			{
				[Token(Token = "0x6000458")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000459")]
				set
				{
				}
			}

			[Token(Token = "0x600045A")]
			protected void AutoFillFromType(Type enumType)
			{
			}

			[Token(Token = "0x600045B")]
			protected EnumField()
			{
			}
		}

		[Token(Token = "0x20000B5")]
		public class EnumField : EnumField<int>
		{
			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal int[] quickSeparators;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private int[] m_Indexes;

			[Token(Token = "0x1700009B")]
			internal int[] indexes
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x2C89354", Offset = "0x2C85354", VA = "0x2C89354")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			public Func<int> getIndex
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0x2C893C8", Offset = "0x2C853C8", VA = "0x2C893C8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x2C893D0", Offset = "0x2C853D0", VA = "0x2C893D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public Action<int> setIndex
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x2C893D8", Offset = "0x2C853D8", VA = "0x2C893D8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x2C893E0", Offset = "0x2C853E0", VA = "0x2C893E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public int currentIndex
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x2C893E8", Offset = "0x2C853E8", VA = "0x2C893E8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x2C89408", Offset = "0x2C85408", VA = "0x2C89408")]
				set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public Type autoEnum
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x2C89428", Offset = "0x2C85428", VA = "0x2C89428")]
				set
				{
				}
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x2C89488", Offset = "0x2C85488", VA = "0x2C89488")]
			internal void InitQuickSeparators()
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x2C89694", Offset = "0x2C85694", VA = "0x2C89694", Slot = "16")]
			public override void SetValue(int value)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x2C78258", Offset = "0x2C74258", VA = "0x2C78258")]
			public EnumField()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		public class ObjectPopupField : Field<Object>
		{
			[Token(Token = "0x170000A0")]
			public Func<IEnumerable<Object>> getObjects
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x2C898D0", Offset = "0x2C858D0", VA = "0x2C898D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x2C898D8", Offset = "0x2C858D8", VA = "0x2C898D8")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x2C7DD0C", Offset = "0x2C79D0C", VA = "0x2C7DD0C")]
			public ObjectPopupField()
			{
			}
		}

		[Token(Token = "0x20000B8")]
		public class HistoryEnumField : EnumField
		{
			[Token(Token = "0x170000A1")]
			public Func<int>[] historyIndexGetter
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x2C898E0", Offset = "0x2C858E0", VA = "0x2C898E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x2C898E8", Offset = "0x2C858E8", VA = "0x2C898E8")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			public int historyDepth
			{
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x2C898F0", Offset = "0x2C858F0", VA = "0x2C898F0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x2C89908", Offset = "0x2C85908", VA = "0x2C89908")]
			public int GetHistoryValue(int historyIndex)
			{
				return default(int);
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x2C89948", Offset = "0x2C85948", VA = "0x2C89948")]
			public HistoryEnumField()
			{
			}
		}

		[Token(Token = "0x20000B9")]
		public class BitField : EnumField<Enum>
		{
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Type m_EnumType;

			[Token(Token = "0x170000A3")]
			public Type enumType
			{
				[Token(Token = "0x6000476")]
				[Address(RVA = "0x2C8994C", Offset = "0x2C8594C", VA = "0x2C8994C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000477")]
				[Address(RVA = "0x2C89954", Offset = "0x2C85954", VA = "0x2C89954")]
				set
				{
				}
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x2C899B0", Offset = "0x2C859B0", VA = "0x2C899B0")]
			public BitField()
			{
			}
		}

		[Token(Token = "0x20000BA")]
		public class ColorField : Field<Color>
		{
			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public bool hdr;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
			public bool showAlpha;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
			public bool showPicker;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float incStep;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float incStepMult;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public int decimals;

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x2C89A1C", Offset = "0x2C85A1C", VA = "0x2C89A1C", Slot = "15")]
			public override Color ValidateValue(Color value)
			{
				return default(Color);
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x2C89A74", Offset = "0x2C85A74", VA = "0x2C89A74")]
			public ColorField()
			{
			}
		}

		[Token(Token = "0x20000BB")]
		public class Vector2Field : Field<Vector2>
		{
			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float incStep;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float incStepMult;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int decimals;

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x2C89AD8", Offset = "0x2C85AD8", VA = "0x2C89AD8")]
			public Vector2Field()
			{
			}
		}

		[Token(Token = "0x20000BC")]
		public class Vector3Field : Field<Vector3>
		{
			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float incStep;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float incStepMult;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int decimals;

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x2C89B34", Offset = "0x2C85B34", VA = "0x2C89B34")]
			public Vector3Field()
			{
			}
		}

		[Token(Token = "0x20000BD")]
		public class Vector4Field : Field<Vector4>
		{
			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float incStep;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float incStepMult;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int decimals;

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x2C89B90", Offset = "0x2C85B90", VA = "0x2C89B90")]
			public Vector4Field()
			{
			}
		}

		[Token(Token = "0x20000BE")]
		public class ObjectField : Field<Object>
		{
			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Type type;

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x2C7F4F8", Offset = "0x2C7B4F8", VA = "0x2C7F4F8")]
			public ObjectField()
			{
			}
		}

		[Token(Token = "0x20000BF")]
		public class ObjectListField : Field<Object[]>
		{
			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Type type;

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x2C89BEC", Offset = "0x2C85BEC", VA = "0x2C89BEC")]
			public ObjectListField()
			{
			}
		}

		[Token(Token = "0x20000C0")]
		public class MessageBox : Widget
		{
			[Token(Token = "0x20000C1")]
			public enum Style
			{
				[Token(Token = "0x40002DD")]
				Info,
				[Token(Token = "0x40002DE")]
				Warning,
				[Token(Token = "0x40002DF")]
				Error
			}

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Style style;

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x2C89C8C", Offset = "0x2C85C8C", VA = "0x2C89C8C")]
			public MessageBox()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		public class Panel : IContainer, IComparable<Panel>
		{
			[Token(Token = "0x170000A4")]
			public Flags flags
			{
				[Token(Token = "0x6000481")]
				[Address(RVA = "0x2C89C94", Offset = "0x2C85C94", VA = "0x2C89C94")]
				[CompilerGenerated]
				get
				{
					return default(Flags);
				}
				[Token(Token = "0x6000482")]
				[Address(RVA = "0x2C89C9C", Offset = "0x2C85C9C", VA = "0x2C89C9C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			public string displayName
			{
				[Token(Token = "0x6000483")]
				[Address(RVA = "0x2C89CA4", Offset = "0x2C85CA4", VA = "0x2C89CA4", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000484")]
				[Address(RVA = "0x2C89CAC", Offset = "0x2C85CAC", VA = "0x2C89CAC", Slot = "6")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			public int groupIndex
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x2C89CB4", Offset = "0x2C85CB4", VA = "0x2C89CB4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x2C89CBC", Offset = "0x2C85CBC", VA = "0x2C89CBC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			public string queryPath
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x2C89CC4", Offset = "0x2C85CC4", VA = "0x2C89CC4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			public bool isEditorOnly
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x2C89CCC", Offset = "0x2C85CCC", VA = "0x2C89CCC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A9")]
			public bool isRuntimeOnly
			{
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x2C89CD8", Offset = "0x2C85CD8", VA = "0x2C89CD8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AA")]
			public bool isInactiveInEditor
			{
				[Token(Token = "0x600048A")]
				[Address(RVA = "0x2C89CE4", Offset = "0x2C85CE4", VA = "0x2C89CE4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AB")]
			public bool editorForceUpdate
			{
				[Token(Token = "0x600048B")]
				[Address(RVA = "0x2C89D54", Offset = "0x2C85D54", VA = "0x2C89D54")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AC")]
			public ObservableList<Widget> children
			{
				[Token(Token = "0x600048C")]
				[Address(RVA = "0x2C89D60", Offset = "0x2C85D60", VA = "0x2C89D60", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600048D")]
				[Address(RVA = "0x2C89D68", Offset = "0x2C85D68", VA = "0x2C89D68")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1400000B")]
			public event Action<Panel> onSetDirty
			{
				[Token(Token = "0x600048E")]
				[Address(RVA = "0x2C84954", Offset = "0x2C80954", VA = "0x2C84954")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x600048F")]
				[Address(RVA = "0x2C84668", Offset = "0x2C80668", VA = "0x2C84668")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x2C84788", Offset = "0x2C80788", VA = "0x2C84788")]
			public Panel()
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x2C89D70", Offset = "0x2C85D70", VA = "0x2C89D70", Slot = "9")]
			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x2C89DC8", Offset = "0x2C85DC8", VA = "0x2C89DC8", Slot = "10")]
			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x2C885B0", Offset = "0x2C845B0", VA = "0x2C885B0")]
			public void SetDirty()
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x2C89E20", Offset = "0x2C85E20", VA = "0x2C89E20", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x2C89F00", Offset = "0x2C85F00", VA = "0x2C89F00", Slot = "8")]
			private int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(Panel other)
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2C87F24", Offset = "0x2C83F24", VA = "0x2C87F24")]
		public DebugUI()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	internal class DebugUpdater : MonoBehaviour
	{
		[Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class <DoAfterInputModuleUpdated>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action action;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004A9")]
				[Address(RVA = "0x2C8A9E0", Offset = "0x2C869E0", VA = "0x2C8A9E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004AB")]
				[Address(RVA = "0x2C8AA20", Offset = "0x2C86A20", VA = "0x2C8AA20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x2C8A5C4", Offset = "0x2C865C4", VA = "0x2C8A5C4")]
			[DebuggerHidden]
			public <DoAfterInputModuleUpdated>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x2C8A8F8", Offset = "0x2C868F8", VA = "0x2C8A8F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x2C8A8FC", Offset = "0x2C868FC", VA = "0x2C8A8FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x2C8A9E8", Offset = "0x2C869E8", VA = "0x2C8A9E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C6")]
		[CompilerGenerated]
		private sealed class <RefreshRuntimeUINextFrame>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004AF")]
				[Address(RVA = "0x2C8AABC", Offset = "0x2C86ABC", VA = "0x2C8AABC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004B1")]
				[Address(RVA = "0x2C8AAFC", Offset = "0x2C86AFC", VA = "0x2C8AAFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x2C8A8C8", Offset = "0x2C868C8", VA = "0x2C8A8C8")]
			[DebuggerHidden]
			public <RefreshRuntimeUINextFrame>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x2C8AA28", Offset = "0x2C86A28", VA = "0x2C8AA28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x2C8AA2C", Offset = "0x2C86A2C", VA = "0x2C8AA2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x2C8AAC4", Offset = "0x2C86AC4", VA = "0x2C8AAC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DebugUpdater s_Instance;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ScreenOrientation m_Orientation;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_RuntimeUiWasVisibleLastFrame;

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2C89F98", Offset = "0x2C85F98", VA = "0x2C89F98")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void RuntimeInit()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x2C85B68", Offset = "0x2C81B68", VA = "0x2C85B68")]
		internal static void SetEnabled(bool enabled)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2C89F9C", Offset = "0x2C85F9C", VA = "0x2C89F9C")]
		private static void EnableRuntime()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2C8A104", Offset = "0x2C86104", VA = "0x2C8A104")]
		private static void DisableRuntime()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2C85DEC", Offset = "0x2C81DEC", VA = "0x2C85DEC")]
		internal static void HandleInternalEventSystemComponents(bool uiEnabled)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2C8A228", Offset = "0x2C86228", VA = "0x2C8A228")]
		private void EnsureExactlyOneEventSystem()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2C8A564", Offset = "0x2C86564", VA = "0x2C8A564")]
		[IteratorStateMachine(typeof(<DoAfterInputModuleUpdated>d__9))]
		private IEnumerator DoAfterInputModuleUpdated(Action action)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2C8A5EC", Offset = "0x2C865EC", VA = "0x2C8A5EC")]
		private void CheckInputModuleExists()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2C8A4E0", Offset = "0x2C864E0", VA = "0x2C8A4E0")]
		private void CreateDebugEventSystem()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2C8A400", Offset = "0x2C86400", VA = "0x2C8A400")]
		private void DestroyDebugEventSystem()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2C8A718", Offset = "0x2C86718", VA = "0x2C8A718")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2C8A870", Offset = "0x2C86870", VA = "0x2C8A870")]
		[IteratorStateMachine(typeof(<RefreshRuntimeUINextFrame>d__14))]
		private static IEnumerator RefreshRuntimeUINextFrame()
		{
			return null;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2C8A8F0", Offset = "0x2C868F0", VA = "0x2C8A8F0")]
		public DebugUpdater()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	internal enum PerformanceBottleneck
	{
		[Token(Token = "0x40002F0")]
		Indeterminate,
		[Token(Token = "0x40002F1")]
		PresentLimited,
		[Token(Token = "0x40002F2")]
		CPU,
		[Token(Token = "0x40002F3")]
		GPU,
		[Token(Token = "0x40002F4")]
		Balanced
	}
	[Token(Token = "0x20000C8")]
	internal struct BottleneckHistogram
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal float PresentLimited;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal float CPU;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float GPU;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float Balanced;
	}
	[Token(Token = "0x20000C9")]
	internal class BottleneckHistory
	{
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<PerformanceBottleneck> m_Bottlenecks;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal BottleneckHistogram Histogram;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2C8AB04", Offset = "0x2C86B04", VA = "0x2C8AB04")]
		public BottleneckHistory(int initialCapacity)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2C8ABB0", Offset = "0x2C86BB0", VA = "0x2C8ABB0")]
		internal void DiscardOldSamples(int historySize)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2C8AC50", Offset = "0x2C86C50", VA = "0x2C8AC50")]
		internal void AddBottleneckFromAveragedSample(FrameTimeSample frameHistorySampleAverage)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2C8ADC0", Offset = "0x2C86DC0", VA = "0x2C8ADC0")]
		internal void ComputeHistogram()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2C8AD1C", Offset = "0x2C86D1C", VA = "0x2C8AD1C")]
		private static PerformanceBottleneck DetermineBottleneck(FrameTimeSample s)
		{
			return default(PerformanceBottleneck);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2C8AECC", Offset = "0x2C86ECC", VA = "0x2C8AECC")]
		internal void Clear()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	internal struct FrameTimeSample
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal float FramesPerSecond;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal float FullFrameTime;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float MainThreadCPUFrameTime;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float MainThreadCPUPresentWaitTime;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float RenderThreadCPUFrameTime;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float GPUFrameTime;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2C8AF20", Offset = "0x2C86F20", VA = "0x2C8AF20")]
		internal FrameTimeSample(float initValue)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	internal class FrameTimeSampleHistory
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<FrameTimeSample> m_Samples;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal FrameTimeSample SampleAverage;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal FrameTimeSample SampleMin;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal FrameTimeSample SampleMax;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Func<float, float, float> s_SampleValueAdd;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Func<float, float, float> s_SampleValueMin;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Func<float, float, float> s_SampleValueMax;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Func<float, float, float> s_SampleValueCountValid;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Func<float, float, float> s_SampleValueEnsureValid;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Func<float, float, float> s_SampleValueDivide;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2C8AF30", Offset = "0x2C86F30", VA = "0x2C8AF30")]
		public FrameTimeSampleHistory(int initialCapacity)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2C8AFDC", Offset = "0x2C86FDC", VA = "0x2C8AFDC")]
		internal void Add(FrameTimeSample sample)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2C8B0B8", Offset = "0x2C870B8", VA = "0x2C8B0B8")]
		internal void ComputeAggregateValues()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2C8B3FC", Offset = "0x2C873FC", VA = "0x2C8B3FC")]
		internal void DiscardOldSamples(int sampleHistorySize)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2C8B49C", Offset = "0x2C8749C", VA = "0x2C8B49C")]
		internal void Clear()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public interface IDebugDisplaySettings : IDebugDisplaySettingsQuery
	{
		[Token(Token = "0x60004C8")]
		void Reset();

		[Token(Token = "0x60004C9")]
		void ForEach(Action<IDebugDisplaySettingsData> onExecute);
	}
	[Token(Token = "0x20000CE")]
	public interface IDebugDisplaySettingsData : IDebugDisplaySettingsQuery
	{
		[Token(Token = "0x60004CA")]
		IDebugDisplaySettingsPanelDisposable CreatePanel();
	}
	[Token(Token = "0x20000CF")]
	public interface IDebugDisplaySettingsPanel
	{
		[Token(Token = "0x170000B1")]
		string PanelName
		{
			[Token(Token = "0x60004CB")]
			get;
		}

		[Token(Token = "0x170000B2")]
		DebugUI.Widget[] Widgets
		{
			[Token(Token = "0x60004CC")]
			get;
		}

		[Token(Token = "0x170000B3")]
		DebugUI.Flags Flags
		{
			[Token(Token = "0x60004CD")]
			get;
		}
	}
	[Token(Token = "0x20000D0")]
	public interface IDebugDisplaySettingsPanelDisposable : IDebugDisplaySettingsPanel, IDisposable
	{
	}
	[Token(Token = "0x20000D1")]
	public interface IDebugDisplaySettingsQuery
	{
		[Token(Token = "0x170000B4")]
		bool AreAnySettingsActive
		{
			[Token(Token = "0x60004CE")]
			get;
		}

		[Token(Token = "0x170000B5")]
		bool IsPostProcessingAllowed
		{
			[Token(Token = "0x60004CF")]
			get;
		}

		[Token(Token = "0x170000B6")]
		bool IsLightingActive
		{
			[Token(Token = "0x60004D0")]
			get;
		}

		[Token(Token = "0x60004D1")]
		bool TryGetScreenClearColor(ref Color color);
	}
	[Token(Token = "0x20000D2")]
	[Obsolete("This variant is obsolete and kept only for not breaking user code. Use IVolumeDebugSettings2 for all new usage.", false)]
	public interface IVolumeDebugSettings
	{
		[Token(Token = "0x170000B7")]
		int selectedComponent
		{
			[Token(Token = "0x60004D2")]
			get;
			[Token(Token = "0x60004D3")]
			set;
		}

		[Token(Token = "0x170000B8")]
		Camera selectedCamera
		{
			[Token(Token = "0x60004D4")]
			get;
		}

		[Token(Token = "0x170000B9")]
		IEnumerable<Camera> cameras
		{
			[Token(Token = "0x60004D5")]
			get;
		}

		[Token(Token = "0x170000BA")]
		int selectedCameraIndex
		{
			[Token(Token = "0x60004D6")]
			get;
			[Token(Token = "0x60004D7")]
			set;
		}

		[Token(Token = "0x170000BB")]
		VolumeStack selectedCameraVolumeStack
		{
			[Token(Token = "0x60004D8")]
			get;
		}

		[Token(Token = "0x170000BC")]
		LayerMask selectedCameraLayerMask
		{
			[Token(Token = "0x60004D9")]
			get;
		}

		[Token(Token = "0x170000BD")]
		Vector3 selectedCameraPosition
		{
			[Token(Token = "0x60004DA")]
			get;
		}

		[Token(Token = "0x170000BE")]
		Type selectedComponentType
		{
			[Token(Token = "0x60004DB")]
			get;
			[Token(Token = "0x60004DC")]
			set;
		}

		[Token(Token = "0x60004DD")]
		Volume[] GetVolumes();

		[Token(Token = "0x60004DE")]
		bool VolumeHasInfluence(Volume volume);

		[Token(Token = "0x60004DF")]
		bool RefreshVolumes(Volume[] newVolumes);

		[Token(Token = "0x60004E0")]
		float GetVolumeWeight(Volume volume);
	}
	[Token(Token = "0x20000D3")]
	public interface IVolumeDebugSettings2 : IVolumeDebugSettings
	{
		[Token(Token = "0x170000BF")]
		Type targetRenderPipeline
		{
			[Token(Token = "0x60004E1")]
			get;
		}

		[Token(Token = "0x170000C0")]
		List<(string, Type)> volumeComponentsPathAndType
		{
			[Token(Token = "0x60004E2")]
			get;
		}
	}
	[Token(Token = "0x20000D4")]
	public class MousePositionDebug
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MousePositionDebug s_Instance;

		[Token(Token = "0x170000C1")]
		public static MousePositionDebug instance
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x2C8B7F4", Offset = "0x2C877F4", VA = "0x2C8B7F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2C8B874", Offset = "0x2C87874", VA = "0x2C8B874")]
		public void Build()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2C8B878", Offset = "0x2C87878", VA = "0x2C8B878")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2C8B87C", Offset = "0x2C8787C", VA = "0x2C8B87C")]
		public Vector2 GetMousePosition(float ScreenHeight, bool sceneView)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2C8B884", Offset = "0x2C87884", VA = "0x2C8B884")]
		private Vector2 GetInputMousePosition()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2C8B88C", Offset = "0x2C8788C", VA = "0x2C8B88C")]
		public Vector2 GetMouseClickPosition(float ScreenHeight)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2C8B86C", Offset = "0x2C8786C", VA = "0x2C8B86C")]
		public MousePositionDebug()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	internal class TProfilingSampler<TEnum> : ProfilingSampler where TEnum : Enum
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static Dictionary<TEnum, TProfilingSampler<TEnum>> samples;

		[Token(Token = "0x60004EA")]
		static TProfilingSampler()
		{
		}

		[Token(Token = "0x60004EB")]
		public TProfilingSampler(string name)
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[IgnoredByDeepProfiler]
	public class ProfilingSampler
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Recorder m_Recorder;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Recorder m_InlineRecorder;

		[Token(Token = "0x170000C2")]
		internal CustomSampler sampler
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x2C8BAB4", Offset = "0x2C87AB4", VA = "0x2C8BAB4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x2C8BABC", Offset = "0x2C87ABC", VA = "0x2C8BABC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		internal CustomSampler inlineSampler
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x2C8BAC4", Offset = "0x2C87AC4", VA = "0x2C8BAC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x2C8BACC", Offset = "0x2C87ACC", VA = "0x2C8BACC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public string name
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x2C8BAD4", Offset = "0x2C87AD4", VA = "0x2C8BAD4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x2C8BADC", Offset = "0x2C87ADC", VA = "0x2C8BADC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public bool enableRecording
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x2C8BAE4", Offset = "0x2C87AE4", VA = "0x2C8BAE4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public float gpuElapsedTime
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x2C8BB28", Offset = "0x2C87B28", VA = "0x2C8BB28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C7")]
		public int gpuSampleCount
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x2C8BB74", Offset = "0x2C87B74", VA = "0x2C8BB74")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C8")]
		public float cpuElapsedTime
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x2C8BBB4", Offset = "0x2C87BB4", VA = "0x2C8BBB4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C9")]
		public int cpuSampleCount
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x2C8BC00", Offset = "0x2C87C00", VA = "0x2C8BC00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CA")]
		public float inlineCpuElapsedTime
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x2C8BC40", Offset = "0x2C87C40", VA = "0x2C8BC40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CB")]
		public int inlineCpuSampleCount
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x2C8BC8C", Offset = "0x2C87C8C", VA = "0x2C8BC8C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60004EC")]
		public static ProfilingSampler Get<TEnum>(TEnum marker) where TEnum : Enum
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2C8B8CC", Offset = "0x2C878CC", VA = "0x2C8B8CC")]
		public ProfilingSampler(string name)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2C8B9CC", Offset = "0x2C879CC", VA = "0x2C8B9CC")]
		public void Begin(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2C8BA30", Offset = "0x2C87A30", VA = "0x2C8BA30")]
		public void End(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2C8BA94", Offset = "0x2C87A94", VA = "0x2C8BA94")]
		internal bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2C8BCCC", Offset = "0x2C87CCC", VA = "0x2C8BCCC")]
		private ProfilingSampler()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public struct ProfilingScope : IDisposable
	{
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2C8BCD4", Offset = "0x2C87CD4", VA = "0x2C8BCD4")]
		public ProfilingScope(CommandBuffer cmd, ProfilingSampler sampler)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2C8BCD8", Offset = "0x2C87CD8", VA = "0x2C8BCD8", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	[Obsolete("Please use ProfilingScope")]
	[IgnoredByDeepProfiler]
	public struct ProfilingSample : IDisposable
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly CommandBuffer m_Cmd;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly string m_Name;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Disposed;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CustomSampler m_Sampler;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2C8BCDC", Offset = "0x2C87CDC", VA = "0x2C8BCDC")]
		public ProfilingSample(CommandBuffer cmd, string name, [Optional] CustomSampler sampler)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2C8BD64", Offset = "0x2C87D64", VA = "0x2C8BD64")]
		public ProfilingSample(CommandBuffer cmd, string format, object arg)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2C8BDA0", Offset = "0x2C87DA0", VA = "0x2C8BDA0")]
		public ProfilingSample(CommandBuffer cmd, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2C8BDDC", Offset = "0x2C87DDC", VA = "0x2C8BDDC", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2C8BDE4", Offset = "0x2C87DE4", VA = "0x2C8BDE4")]
		private void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public sealed class ShaderDebugPrintManager
	{
		[Token(Token = "0x20000DA")]
		private static class Profiling
		{
			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ProfilingSampler BufferReadComplete;
		}

		[Token(Token = "0x20000DB")]
		private enum DebugValueType
		{
			[Token(Token = "0x4000327")]
			TypeUint = 1,
			[Token(Token = "0x4000328")]
			TypeInt,
			[Token(Token = "0x4000329")]
			TypeFloat,
			[Token(Token = "0x400032A")]
			TypeUint2,
			[Token(Token = "0x400032B")]
			TypeInt2,
			[Token(Token = "0x400032C")]
			TypeFloat2,
			[Token(Token = "0x400032D")]
			TypeUint3,
			[Token(Token = "0x400032E")]
			TypeInt3,
			[Token(Token = "0x400032F")]
			TypeFloat3,
			[Token(Token = "0x4000330")]
			TypeUint4,
			[Token(Token = "0x4000331")]
			TypeInt4,
			[Token(Token = "0x4000332")]
			TypeFloat4,
			[Token(Token = "0x4000333")]
			TypeBool
		}

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ShaderDebugPrintManager s_Instance;

		[Token(Token = "0x4000318")]
		private const int k_DebugUAVSlot = 7;

		[Token(Token = "0x4000319")]
		private const int k_FramesInFlight = 4;

		[Token(Token = "0x400031A")]
		private const int k_MaxBufferElements = 16384;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<GraphicsBuffer> m_OutputBuffers;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<AsyncGPUReadbackRequest> m_ReadbackRequests;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<AsyncGPUReadbackRequest> m_BufferReadCompleteAction;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_FrameCounter;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_FrameCleared;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_OutputLine;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action<string> m_OutputAction;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int m_ShaderPropertyIDInputMouse;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int m_ShaderPropertyIDInputFrame;

		[Token(Token = "0x4000324")]
		private const uint k_TypeHasTag = 128u;

		[Token(Token = "0x170000CC")]
		public static ShaderDebugPrintManager instance
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x2C8C13C", Offset = "0x2C8813C", VA = "0x2C8C13C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public string outputLine
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x2C8D3BC", Offset = "0x2C893BC", VA = "0x2C8D3BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		public Action<string> outputAction
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x2C8D3C4", Offset = "0x2C893C4", VA = "0x2C8D3C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2C8BE70", Offset = "0x2C87E70", VA = "0x2C8BE70")]
		private int DebugValueTypeToElemSize(DebugValueType type)
		{
			return default(int);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2C8BE94", Offset = "0x2C87E94", VA = "0x2C8BE94")]
		private ShaderDebugPrintManager()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2C8C194", Offset = "0x2C88194", VA = "0x2C8C194")]
		public void SetShaderDebugPrintInputConstants(CommandBuffer cmd, ShaderDebugPrintInput input)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2C8C25C", Offset = "0x2C8825C", VA = "0x2C8C25C")]
		public void SetShaderDebugPrintBindings(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2C8C35C", Offset = "0x2C8835C", VA = "0x2C8C35C")]
		private void ClearShaderDebugPrintBuffer()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2C8C444", Offset = "0x2C88444", VA = "0x2C8C444")]
		private void BufferReadComplete(AsyncGPUReadbackRequest request)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2C8D300", Offset = "0x2C89300", VA = "0x2C8D300")]
		public void EndFrame()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2C8D3CC", Offset = "0x2C893CC", VA = "0x2C8D3CC")]
		public void DefaultOutput(string line)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public struct ShaderDebugPrintInput
	{
		[Token(Token = "0x170000CF")]
		public Vector2 pos
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x2C8D56C", Offset = "0x2C8956C", VA = "0x2C8D56C")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x2C8D574", Offset = "0x2C89574", VA = "0x2C8D574")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public bool leftDown
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x2C8D57C", Offset = "0x2C8957C", VA = "0x2C8D57C")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x2C8D584", Offset = "0x2C89584", VA = "0x2C8D584")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public bool rightDown
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x2C8D58C", Offset = "0x2C8958C", VA = "0x2C8D58C")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x2C8D594", Offset = "0x2C89594", VA = "0x2C8D594")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public bool middleDown
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x2C8D59C", Offset = "0x2C8959C", VA = "0x2C8D59C")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x2C8D5A4", Offset = "0x2C895A4", VA = "0x2C8D5A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2C8D5AC", Offset = "0x2C895AC", VA = "0x2C8D5AC")]
		public string String()
		{
			return null;
		}
	}
	[Token(Token = "0x20000DD")]
	public static class ShaderDebugPrintInputProducer
	{
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x2C8D7AC", Offset = "0x2C897AC", VA = "0x2C8D7AC")]
		public static ShaderDebugPrintInput Get()
		{
			return default(ShaderDebugPrintInput);
		}
	}
	[Token(Token = "0x20000DE")]
	public abstract class VolumeDebugSettings<T> : IVolumeDebugSettings2, IVolumeDebugSettings where T : MonoBehaviour, IAdditionalData
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Camera m_SelectedCamera;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int m_SelectedCameraIndex;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Camera[] m_CamerasArray;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<Camera> m_Cameras;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<(string, Type)> s_ComponentPathAndType;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float[] weights;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Volume[] volumes;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private VolumeParameter[,] savedStates;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Type> s_ComponentTypes;

		[Token(Token = "0x170000D3")]
		public int selectedComponent
		{
			[Token(Token = "0x600051D")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600051E")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public Camera selectedCamera
		{
			[Token(Token = "0x600051F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public int selectedCameraIndex
		{
			[Token(Token = "0x6000520")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000521")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public IEnumerable<Camera> cameras
		{
			[Token(Token = "0x6000522")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public abstract VolumeStack selectedCameraVolumeStack
		{
			[Token(Token = "0x6000523")]
			get;
		}

		[Token(Token = "0x170000D8")]
		public abstract LayerMask selectedCameraLayerMask
		{
			[Token(Token = "0x6000524")]
			get;
		}

		[Token(Token = "0x170000D9")]
		public abstract Vector3 selectedCameraPosition
		{
			[Token(Token = "0x6000525")]
			get;
		}

		[Token(Token = "0x170000DA")]
		public Type selectedComponentType
		{
			[Token(Token = "0x6000526")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000527")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public List<(string, Type)> volumeComponentsPathAndType
		{
			[Token(Token = "0x6000528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public abstract Type targetRenderPipeline
		{
			[Token(Token = "0x6000529")]
			get;
		}

		[Token(Token = "0x170000DD")]
		[Obsolete("Please use volumeComponentsPathAndType instead, and get the second element of the tuple", false)]
		public static List<Type> componentTypes
		{
			[Token(Token = "0x6000534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		[Obsolete("Cameras are auto registered/unregistered, use property cameras", false)]
		protected static List<T> additionalCameraDatas
		{
			[Token(Token = "0x6000536")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000537")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600052A")]
		internal VolumeParameter GetParameter(VolumeComponent component, FieldInfo field)
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		internal VolumeParameter GetParameter(FieldInfo field)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		internal VolumeParameter GetParameter(Volume volume, FieldInfo field)
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		private float ComputeWeight(Volume volume, Vector3 triggerPos)
		{
			return default(float);
		}

		[Token(Token = "0x600052E")]
		public Volume[] GetVolumes()
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		private VolumeParameter[,] GetStates()
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		private bool ChangedStates(VolumeParameter[,] newStates)
		{
			return default(bool);
		}

		[Token(Token = "0x6000531")]
		public bool RefreshVolumes(Volume[] newVolumes)
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		public float GetVolumeWeight(Volume volume)
		{
			return default(float);
		}

		[Token(Token = "0x6000533")]
		public bool VolumeHasInfluence(Volume volume)
		{
			return default(bool);
		}

		[Token(Token = "0x6000535")]
		[Obsolete("Please use componentPathAndType instead, and get the first element of the tuple", false)]
		public static string ComponentDisplayName(Type component)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Obsolete("Cameras are auto registered/unregistered", false)]
		public static void RegisterCamera(T additionalCamera)
		{
		}

		[Token(Token = "0x6000539")]
		[Obsolete("Cameras are auto registered/unregistered", false)]
		public static void UnRegisterCamera(T additionalCamera)
		{
		}

		[Token(Token = "0x600053A")]
		protected VolumeDebugSettings()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = false)]
	public class CoreRPHelpURLAttribute : HelpURLAttribute
	{
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x2C8D82C", Offset = "0x2C8982C", VA = "0x2C8D82C")]
		public CoreRPHelpURLAttribute(string pageName, string packageName = "com.unity.render-pipelines.core")
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x2C8DA00", Offset = "0x2C89A00", VA = "0x2C8DA00")]
		public CoreRPHelpURLAttribute(string pageName, string pageHash, string packageName = "com.unity.render-pipelines.core")
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class DocumentationInfo
	{
		[Token(Token = "0x400034A")]
		private const string fallbackVersion = "13.1";

		[Token(Token = "0x400034B")]
		private const string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html{3}";

		[Token(Token = "0x170000DF")]
		public static string version
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x2C8DA24", Offset = "0x2C89A24", VA = "0x2C8DA24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x2C8DA64", Offset = "0x2C89A64", VA = "0x2C8DA64")]
		public static string GetPageLink(string packageName, string pageName)
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2C8D898", Offset = "0x2C89898", VA = "0x2C8D898")]
		public static string GetPageLink(string packageName, string pageName, string pageHash)
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x2C8DBD8", Offset = "0x2C89BD8", VA = "0x2C8DBD8")]
		public DocumentationInfo()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public static class DocumentationUtils
	{
		[Token(Token = "0x600054B")]
		public static string GetHelpURL<TEnum>([Optional] TEnum mask) where TEnum : struct, IConvertible
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x2C8DBE0", Offset = "0x2C89BE0", VA = "0x2C8DBE0")]
		public static bool TryGetHelpURL(Type type, out string url)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E4")]
	internal class ProbeBrickIndex
	{
		[Serializable]
		[Token(Token = "0x20000E5")]
		[DebuggerDisplay("Brick [{position}, {subdivisionLevel}]")]
		public struct Brick : IEquatable<Brick>
		{
			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3Int position;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int subdivisionLevel;

			[Token(Token = "0x6000561")]
			[Address(RVA = "0x2C904B4", Offset = "0x2C8C4B4", VA = "0x2C904B4")]
			internal Brick(Vector3Int position, int subdivisionLevel)
			{
			}

			[Token(Token = "0x6000562")]
			[Address(RVA = "0x2C904C0", Offset = "0x2C8C4C0", VA = "0x2C904C0", Slot = "4")]
			public bool Equals(Brick other)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000E6")]
		[DebuggerDisplay("Brick [{brick.position}, {brick.subdivisionLevel}], {flattenedIdx}")]
		private struct ReservedBrick
		{
			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Brick brick;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int flattenedIdx;
		}

		[Token(Token = "0x20000E7")]
		private class VoxelMeta
		{
			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ProbeReferenceVolume.Cell cell;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<ushort> brickIndices;

			[Token(Token = "0x6000563")]
			[Address(RVA = "0x2C90508", Offset = "0x2C8C508", VA = "0x2C90508")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000564")]
			[Address(RVA = "0x2C9055C", Offset = "0x2C8C55C", VA = "0x2C9055C")]
			public VoxelMeta()
			{
			}
		}

		[Token(Token = "0x20000E8")]
		private class BrickMeta
		{
			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HashSet<Vector3Int> voxels;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<ReservedBrick> bricks;

			[Token(Token = "0x6000565")]
			[Address(RVA = "0x2C905D8", Offset = "0x2C8C5D8", VA = "0x2C905D8")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000566")]
			[Address(RVA = "0x2C9064C", Offset = "0x2C8C64C", VA = "0x2C9064C")]
			public BrickMeta()
			{
			}
		}

		[Token(Token = "0x20000E9")]
		public struct CellIndexUpdateInfo
		{
			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int firstChunkIndex;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int numberOfChunks;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int minSubdivInCell;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3Int minValidBrickIndexForCellAtMaxRes;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3Int cellPositionInBricksAtMaxRes;
		}

		[Token(Token = "0x400034C")]
		internal const int kMaxSubdivisionLevels = 7;

		[Token(Token = "0x400034D")]
		internal const int kIndexChunkSize = 243;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BitArray m_IndexChunks;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_IndexInChunks;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_NextFreeChunk;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_AvailableChunkCount;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_PhysicalIndexBuffer;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int[] m_PhysicalIndexBufferData;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3Int m_CenterRS;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<Vector3Int, List<VoxelMeta>> m_VoxelToBricks;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<ProbeReferenceVolume.Cell, BrickMeta> m_BricksToVoxels;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ObjectPool<BrickMeta> m_BrickMetaPool;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ObjectPool<List<VoxelMeta>> m_VoxelMetaListPool;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ObjectPool<VoxelMeta> m_VoxelMetaPool;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_NeedUpdateIndexComputeBuffer;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_UpdateMinIndex;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_UpdateMaxIndex;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ProbeReferenceVolume.Cell g_Cell;

		[Token(Token = "0x170000E0")]
		internal int estimatedVMemCost
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x2C8DC58", Offset = "0x2C89C58", VA = "0x2C8DC58")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x2C8DC60", Offset = "0x2C89C60", VA = "0x2C8DC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x2C8DC68", Offset = "0x2C89C68", VA = "0x2C8DC68")]
		private int GetVoxelSubdivLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x2C8DD0C", Offset = "0x2C89D0C", VA = "0x2C8DD0C")]
		private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget)
		{
			return default(int);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x2C8DD48", Offset = "0x2C89D48", VA = "0x2C8DD48")]
		internal ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x2C8E6FC", Offset = "0x2C8A6FC", VA = "0x2C8E6FC")]
		public int GetRemainingChunkCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x2C8E704", Offset = "0x2C8A704", VA = "0x2C8E704")]
		internal void UploadIndexData()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x2C8E234", Offset = "0x2C8A234", VA = "0x2C8E234")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2C8E74C", Offset = "0x2C8A74C", VA = "0x2C8E74C")]
		private void MapBrickToVoxels(Brick brick, HashSet<Vector3Int> voxels)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x2C8EA80", Offset = "0x2C8AA80", VA = "0x2C8EA80")]
		private void ClearVoxel(Vector3Int pos, CellIndexUpdateInfo cellInfo)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2C8F030", Offset = "0x2C8B030", VA = "0x2C8F030")]
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2C8F064", Offset = "0x2C8B064", VA = "0x2C8F064")]
		internal void Cleanup()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2C8F0C8", Offset = "0x2C8B0C8", VA = "0x2C8F0C8")]
		private int MergeIndex(int index, int size)
		{
			return default(int);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x2C8F0D4", Offset = "0x2C8B0D4", VA = "0x2C8F0D4")]
		internal bool AssignIndexChunksToCell(int bricksCount, ref CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog)
		{
			return default(bool);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2C8F2B4", Offset = "0x2C8B2B4", VA = "0x2C8F2B4")]
		public void AddBricks(ProbeReferenceVolume.Cell cell, NativeArray<Brick> bricks, List<ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, CellIndexUpdateInfo cellInfo)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2C8FC94", Offset = "0x2C8BC94", VA = "0x2C8FC94")]
		public void RemoveBricks(ProbeReferenceVolume.CellInfo cellInfo)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2C8FA94", Offset = "0x2C8BA94", VA = "0x2C8FA94")]
		private void UpdateIndexForVoxel(Vector3Int voxel, CellIndexUpdateInfo cellInfo)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2C8ECC8", Offset = "0x2C8ACC8", VA = "0x2C8ECC8")]
		private void UpdatePhysicalIndex(Vector3Int brickMin, Vector3Int brickMax, int value, CellIndexUpdateInfo cellInfo)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2C8EB28", Offset = "0x2C8AB28", VA = "0x2C8EB28")]
		private void ClipToIndexSpace(Vector3Int pos, int subdiv, out Vector3Int outMinpos, out Vector3Int outMaxpos, CellIndexUpdateInfo cellInfo)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2C901CC", Offset = "0x2C8C1CC", VA = "0x2C901CC")]
		private void UpdateIndexForVoxel(Vector3Int voxel, List<ReservedBrick> bricks, List<ushort> indices, CellIndexUpdateInfo cellInfo)
		{
		}
	}
	[Token(Token = "0x20000EB")]
	internal class ProbeBrickPool
	{
		[Token(Token = "0x20000EC")]
		[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
		public struct BrickChunkAlloc
		{
			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x2C8FA80", Offset = "0x2C8BA80", VA = "0x2C8FA80")]
			internal int flattenIndex(int sx, int sy)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000ED")]
		public struct DataLocation
		{
			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Texture TexL0_L1rx;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Texture TexL1_G_ry;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Texture TexL1_B_rz;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Texture TexL2_0;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Texture TexL2_1;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Texture TexL2_2;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Texture TexL2_3;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Texture3D TexValidity;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int width;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal int height;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal int depth;

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x2C90ED0", Offset = "0x2C8CED0", VA = "0x2C90ED0")]
			internal void Cleanup()
			{
			}
		}

		[Token(Token = "0x4000373")]
		private const int kProbePoolChunkSizeInBricks = 128;

		[Token(Token = "0x4000374")]
		internal const int kBrickCellCount = 3;

		[Token(Token = "0x4000375")]
		internal const int kBrickProbeCountPerDim = 4;

		[Token(Token = "0x4000376")]
		internal const int kBrickProbeCountTotal = 64;

		[Token(Token = "0x4000377")]
		internal const int kChunkProbeCountPerDim = 512;

		[Token(Token = "0x4000379")]
		private const int kMaxPoolWidth = 2048;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal DataLocation m_Pool;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BrickChunkAlloc m_NextFreeChunk;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Stack<BrickChunkAlloc> m_FreeList;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int m_AvailableChunkCount;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private ProbeVolumeSHBands m_SHBands;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_ContainsValidity;

		[Token(Token = "0x170000E1")]
		internal int estimatedVMemCost
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x2C908C8", Offset = "0x2C8C8C8", VA = "0x2C908C8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x2C908D0", Offset = "0x2C8C8D0", VA = "0x2C908D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x2C908D8", Offset = "0x2C8C8D8", VA = "0x2C908D8")]
		internal ProbeBrickPool(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool allocateValidityData = true)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x2C90DEC", Offset = "0x2C8CDEC", VA = "0x2C90DEC")]
		public int GetRemainingChunkCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x2C90DF4", Offset = "0x2C8CDF4", VA = "0x2C90DF4")]
		internal void EnsureTextureValidity()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x2C90F90", Offset = "0x2C8CF90", VA = "0x2C90F90")]
		internal static int GetChunkSizeInBrickCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2C90F98", Offset = "0x2C8CF98", VA = "0x2C90F98")]
		internal static int GetChunkSizeInProbeCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x2C90FA0", Offset = "0x2C8CFA0", VA = "0x2C90FA0")]
		internal int GetPoolWidth()
		{
			return default(int);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x2C90FA8", Offset = "0x2C8CFA8", VA = "0x2C90FA8")]
		internal int GetPoolHeight()
		{
			return default(int);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x2C90FB0", Offset = "0x2C8CFB0", VA = "0x2C90FB0")]
		internal Vector3Int GetPoolDimensions()
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x2C90FC0", Offset = "0x2C8CFC0", VA = "0x2C90FC0")]
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x2C911B8", Offset = "0x2C8D1B8", VA = "0x2C911B8")]
		internal void Clear()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x2C91214", Offset = "0x2C8D214", VA = "0x2C91214")]
		internal static int GetChunkCount(int brickCount, int chunkSizeInBricks)
		{
			return default(int);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x2C91224", Offset = "0x2C8D224", VA = "0x2C91224")]
		internal bool Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations, bool ignoreErrorLog)
		{
			return default(bool);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x2C91474", Offset = "0x2C8D474", VA = "0x2C91474")]
		internal void Deallocate(List<BrickChunkAlloc> allocations)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x2C915E8", Offset = "0x2C8D5E8", VA = "0x2C915E8")]
		internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x2C91984", Offset = "0x2C8D984", VA = "0x2C91984")]
		internal void UpdateValidity(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2C91B18", Offset = "0x2C8DB18", VA = "0x2C91B18")]
		internal static Vector3Int ProbeCountToDataLocSize(int numProbes)
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x2C91B84", Offset = "0x2C8DB84", VA = "0x2C91B84")]
		public static Texture CreateDataTexture(int width, int height, int depth, GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes)
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2C90A44", Offset = "0x2C8CA44", VA = "0x2C90A44")]
		public static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, out int allocatedBytes)
		{
			return default(DataLocation);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2C90A30", Offset = "0x2C8CA30", VA = "0x2C90A30")]
		private void DerivePoolSizeFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2C91D84", Offset = "0x2C8DD84", VA = "0x2C91D84")]
		internal void Cleanup()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	internal class ProbeBrickBlendingPool
	{
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ComputeShader stateBlendShader;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int scenarioBlendingKernel;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int _PoolDim_LerpFactor;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int _ChunkList;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int _State0_L0_L1Rx;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int _State0_L1G_L1Ry;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int _State0_L1B_L1Rz;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int _State0_L2_0;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int _State0_L2_1;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int _State0_L2_2;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly int _State0_L2_3;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly int _State1_L0_L1Rx;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static readonly int _State1_L1G_L1Ry;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly int _State1_L1B_L1Rz;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static readonly int _State1_L2_0;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly int _State1_L2_1;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static readonly int _State1_L2_2;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly int _State1_L2_3;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private static readonly int _Out_L0_L1Rx;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly int _Out_L1G_L1Ry;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static readonly int _Out_L1B_L1Rz;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly int _Out_L2_0;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static readonly int _Out_L2_1;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly int _Out_L2_2;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private static readonly int _Out_L2_3;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector4[] m_ChunkList;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_MappedChunks;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ProbeBrickPool m_State0;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ProbeBrickPool m_State1;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ProbeVolumeTextureMemoryBudget m_MemoryBudget;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private ProbeVolumeSHBands m_ShBands;

		[Token(Token = "0x170000E2")]
		internal static bool isSupported
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x2C91D8C", Offset = "0x2C8DD8C", VA = "0x2C91D8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E3")]
		internal bool isAllocated
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x2C91F24", Offset = "0x2C8DF24", VA = "0x2C91F24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E4")]
		internal int estimatedVMemCost
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x2C91F34", Offset = "0x2C8DF34", VA = "0x2C91F34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x2C91E18", Offset = "0x2C8DE18", VA = "0x2C91E18")]
		internal static void Initialize(in ProbeVolumeSystemParameters parameters)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2C91F64", Offset = "0x2C8DF64", VA = "0x2C91F64")]
		internal int GetPoolWidth()
		{
			return default(int);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2C91F7C", Offset = "0x2C8DF7C", VA = "0x2C91F7C")]
		internal int GetPoolHeight()
		{
			return default(int);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2C91F94", Offset = "0x2C8DF94", VA = "0x2C91F94")]
		internal int GetPoolDepth()
		{
			return default(int);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2C91FAC", Offset = "0x2C8DFAC", VA = "0x2C91FAC")]
		internal ProbeBrickBlendingPool(ProbeVolumeBlendingTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2C91FD8", Offset = "0x2C8DFD8", VA = "0x2C91FD8")]
		internal void AllocateResourcesIfNeeded()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2C920E0", Offset = "0x2C8E0E0", VA = "0x2C920E0")]
		internal void Update(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands, int state)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x2C92158", Offset = "0x2C8E158", VA = "0x2C92158")]
		private static int DivRoundUp(int x, int y)
		{
			return default(int);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2C92168", Offset = "0x2C8E168", VA = "0x2C92168")]
		internal void PerformBlending(CommandBuffer cmd, float factor, ProbeBrickPool dstPool)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2C92A4C", Offset = "0x2C8EA4C", VA = "0x2C92A4C")]
		internal void BlendChunks(ProbeReferenceVolume.BlendingCellInfo blendingCell, ProbeBrickPool dstPool)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2C92B64", Offset = "0x2C8EB64", VA = "0x2C92B64")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2C92B74", Offset = "0x2C8EB74", VA = "0x2C92B74")]
		internal bool Allocate(int numberOfBrickChunks, List<ProbeBrickPool.BrickChunkAlloc> outAllocations)
		{
			return default(bool);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2C92BCC", Offset = "0x2C8EBCC", VA = "0x2C92BCC")]
		internal void Deallocate(List<ProbeBrickPool.BrickChunkAlloc> allocations)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2C92C30", Offset = "0x2C8EC30", VA = "0x2C92C30")]
		internal void EnsureTextureValidity()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2C92C60", Offset = "0x2C8EC60", VA = "0x2C92C60")]
		internal void Cleanup()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	internal class ProbeCellIndices
	{
		[Token(Token = "0x20000F0")]
		internal struct IndexMetaData
		{
			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static uint[] s_PackedValues;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Vector3Int minLocalIdx;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Vector3Int maxLocalIdx;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int firstChunkIndex;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int minSubdiv;

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x2C93494", Offset = "0x2C8F494", VA = "0x2C93494")]
			internal void Pack(out uint[] vals)
			{
			}
		}

		[Token(Token = "0x40003AD")]
		private const int kUintPerEntry = 3;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ComputeBuffer m_IndexOfIndicesBuffer;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint[] m_IndexOfIndicesData;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3Int m_CellCount;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3Int m_CellMin;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_CellSizeInMinBricks;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_NeedUpdateComputeBuffer;

		[Token(Token = "0x170000E5")]
		internal int estimatedVMemCost
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x2C93150", Offset = "0x2C8F150", VA = "0x2C93150")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x2C93158", Offset = "0x2C8F158", VA = "0x2C93158")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2C93160", Offset = "0x2C8F160", VA = "0x2C93160")]
		internal Vector3Int GetCellIndexDimension()
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2C93170", Offset = "0x2C8F170", VA = "0x2C93170")]
		internal Vector3Int GetCellMinPosition()
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2C93180", Offset = "0x2C8F180", VA = "0x2C93180")]
		private int GetFlatIndex(Vector3Int normalizedPos)
		{
			return default(int);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2C93198", Offset = "0x2C8F198", VA = "0x2C93198")]
		internal ProbeCellIndices(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2C932DC", Offset = "0x2C8F2DC", VA = "0x2C932DC")]
		internal int GetFlatIdxForCell(Vector3Int cellPosition)
		{
			return default(int);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2C9330C", Offset = "0x2C8F30C", VA = "0x2C9330C")]
		internal void UpdateCell(int cellFlatIdx, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2C935AC", Offset = "0x2C8F5AC", VA = "0x2C935AC")]
		internal void MarkCellAsUnloaded(int cellFlatIdx)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2C93608", Offset = "0x2C8F608", VA = "0x2C93608")]
		internal void PushComputeData()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x2C93634", Offset = "0x2C8F634", VA = "0x2C93634")]
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2C93668", Offset = "0x2C8F668", VA = "0x2C93668")]
		internal void Cleanup()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public struct ProbeVolumeSystemParameters
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ProbeVolumeTextureMemoryBudget memoryBudget;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Mesh probeDebugMesh;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Shader probeDebugShader;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh offsetDebugMesh;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader offsetDebugShader;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ComputeShader scenarioBlendingShader;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ProbeVolumeSceneData sceneData;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ProbeVolumeSHBands shBands;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool supportsRuntimeDebug;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool supportStreaming;
	}
	[Token(Token = "0x20000F2")]
	public struct ProbeVolumeShadingParameters
	{
		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float normalBias;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float viewBias;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool scaleBiasByMinDistanceBetweenProbes;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float samplingNoise;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float weight;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public APVLeakReductionMode leakReductionMode;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float occlusionWeightContribution;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minValidNormalWeight;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int frameIndexForNoise;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float reflNormalizationLowerClamp;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float reflNormalizationUpperClamp;
	}
	[Serializable]
	[Token(Token = "0x20000F3")]
	public enum ProbeVolumeTextureMemoryBudget
	{
		[Token(Token = "0x40003D1")]
		MemoryBudgetLow = 0x200,
		[Token(Token = "0x40003D2")]
		MemoryBudgetMedium = 0x400,
		[Token(Token = "0x40003D3")]
		MemoryBudgetHigh = 0x800
	}
	[Serializable]
	[Token(Token = "0x20000F4")]
	public enum ProbeVolumeBlendingTextureMemoryBudget
	{
		[Token(Token = "0x40003D5")]
		None = 0,
		[Token(Token = "0x40003D6")]
		MemoryBudgetLow = 0x80,
		[Token(Token = "0x40003D7")]
		MemoryBudgetMedium = 0x100,
		[Token(Token = "0x40003D8")]
		MemoryBudgetHigh = 0x200
	}
	[Serializable]
	[Token(Token = "0x20000F5")]
	public enum ProbeVolumeSHBands
	{
		[Token(Token = "0x40003DA")]
		SphericalHarmonicsL1 = 1,
		[Token(Token = "0x40003DB")]
		SphericalHarmonicsL2
	}
	[Token(Token = "0x20000F6")]
	public class ProbeReferenceVolume
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		[DebuggerDisplay("Index = {index} position = {position}")]
		internal class Cell
		{
			[Token(Token = "0x20000F8")]
			public struct PerScenarioData
			{
				[Token(Token = "0x170000FE")]
				public NativeArray<ushort> shL0L1RxData
				{
					[Token(Token = "0x600061B")]
					[Address(RVA = "0x2C9D578", Offset = "0x2C99578", VA = "0x2C9D578")]
					[CompilerGenerated]
					readonly get
					{
						return default(NativeArray<ushort>);
					}
					[Token(Token = "0x600061C")]
					[Address(RVA = "0x2C9D584", Offset = "0x2C99584", VA = "0x2C9D584")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Token(Token = "0x170000FF")]
				public NativeArray<byte> shL1GL1RyData
				{
					[Token(Token = "0x600061D")]
					[Address(RVA = "0x2C9D58C", Offset = "0x2C9958C", VA = "0x2C9D58C")]
					[CompilerGenerated]
					readonly get
					{
						return default(NativeArray<byte>);
					}
					[Token(Token = "0x600061E")]
					[Address(RVA = "0x2C9D598", Offset = "0x2C99598", VA = "0x2C9D598")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Token(Token = "0x17000100")]
				public NativeArray<byte> shL1BL1RzData
				{
					[Token(Token = "0x600061F")]
					[Address(RVA = "0x2C9D5A0", Offset = "0x2C995A0", VA = "0x2C9D5A0")]
					[CompilerGenerated]
					readonly get
					{
						return default(NativeArray<byte>);
					}
					[Token(Token = "0x6000620")]
					[Address(RVA = "0x2C9D5AC", Offset = "0x2C995AC", VA = "0x2C9D5AC")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Token(Token = "0x17000101")]
				public NativeArray<byte> shL2Data_0
				{
					[Token(Token = "0x6000621")]
					[Address(RVA = "0x2C9D5B4", Offset = "0x2C995B4", VA = "0x2C9D5B4")]
					[CompilerGenerated]
					readonly get
					{
						return default(NativeArray<byte>);
					}
					[Token(Token = "0x6000622")]
					[Address(RVA = "0x2C9D5C0", Offset = "0x2C995C0", VA = "0x2C9D5C0")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Token(Token = "0x17000102")]
				public NativeArray<byte> shL2Data_1
				{
					[Token(Token = "0x6000623")]
					[Address(RVA = "0x2C9D5C8", Offset = "0x2C995C8", VA = "0x2C9D5C8")]
					[CompilerGenerated]
					readonly get
					{
						return default(NativeArray<byte>);
					}
					[Token(Token = "0x6000624")]
					[Address(RVA = "0x2C9D5D4", Offset = "0x2C995D4", VA = "0x2C9D5D4")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Token(Token = "0x17000103")]
				public NativeArray<byte> shL2Data_2
				{
					[Token(Token = "0x6000625")]
					[Address(RVA = "0x2C9D5DC", Offset = "0x2C995DC", VA = "0x2C9D5DC")]
					[CompilerGenerated]
					readonly get
					{
						return default(NativeArray<byte>);
					}
					[Token(Token = "0x6000626")]
					[Address(RVA = "0x2C9D5E8", Offset = "0x2C995E8", VA = "0x2C9D5E8")]
					[CompilerGenerated]
					internal set
					{
					}
				}

				[Token(Token = "0x17000104")]
				public NativeArray<byte> shL2Data_3
				{
					[Token(Token = "0x6000627")]
					[Address(RVA = "0x2C9D5F0", Offset = "0x2C995F0", VA = "0x2C9D5F0")]
					[CompilerGenerated]
					readonly get
					{
						return default(NativeArray<byte>);
					}
					[Token(Token = "0x6000628")]
					[Address(RVA = "0x2C9D5FC", Offset = "0x2C995FC", VA = "0x2C9D5FC")]
					[CompilerGenerated]
					internal set
					{
					}
				}
			}

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3Int position;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int index;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int probeCount;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int minSubdiv;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int maxSubdiv;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int indexChunkCount;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int shChunkCount;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool hasTwoScenarios;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ProbeVolumeSHBands shBands;

			[NonSerialized]
			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public PerScenarioData scenario0;

			[NonSerialized]
			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			public PerScenarioData scenario1;

			[Token(Token = "0x170000F7")]
			public NativeArray<ProbeBrickIndex.Brick> bricks
			{
				[Token(Token = "0x600060D")]
				[Address(RVA = "0x2C9D4E8", Offset = "0x2C994E8", VA = "0x2C9D4E8")]
				[CompilerGenerated]
				get
				{
					return default(NativeArray<ProbeBrickIndex.Brick>);
				}
				[Token(Token = "0x600060E")]
				[Address(RVA = "0x2C9D4F4", Offset = "0x2C994F4", VA = "0x2C9D4F4")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Token(Token = "0x170000F8")]
			public NativeArray<byte> validityNeighMaskData
			{
				[Token(Token = "0x600060F")]
				[Address(RVA = "0x2C9D4FC", Offset = "0x2C994FC", VA = "0x2C9D4FC")]
				[CompilerGenerated]
				get
				{
					return default(NativeArray<byte>);
				}
				[Token(Token = "0x6000610")]
				[Address(RVA = "0x2C9D508", Offset = "0x2C99508", VA = "0x2C9D508")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Token(Token = "0x170000F9")]
			public NativeArray<Vector3> probePositions
			{
				[Token(Token = "0x6000611")]
				[Address(RVA = "0x2C9D510", Offset = "0x2C99510", VA = "0x2C9D510")]
				[CompilerGenerated]
				get
				{
					return default(NativeArray<Vector3>);
				}
				[Token(Token = "0x6000612")]
				[Address(RVA = "0x2C9D51C", Offset = "0x2C9951C", VA = "0x2C9D51C")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Token(Token = "0x170000FA")]
			public NativeArray<float> touchupVolumeInteraction
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0x2C9D524", Offset = "0x2C99524", VA = "0x2C9D524")]
				[CompilerGenerated]
				get
				{
					return default(NativeArray<float>);
				}
				[Token(Token = "0x6000614")]
				[Address(RVA = "0x2C9D530", Offset = "0x2C99530", VA = "0x2C9D530")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Token(Token = "0x170000FB")]
			public NativeArray<Vector3> offsetVectors
			{
				[Token(Token = "0x6000615")]
				[Address(RVA = "0x2C9D538", Offset = "0x2C99538", VA = "0x2C9D538")]
				[CompilerGenerated]
				get
				{
					return default(NativeArray<Vector3>);
				}
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x2C9D544", Offset = "0x2C99544", VA = "0x2C9D544")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Token(Token = "0x170000FC")]
			public NativeArray<float> validity
			{
				[Token(Token = "0x6000617")]
				[Address(RVA = "0x2C9D54C", Offset = "0x2C9954C", VA = "0x2C9D54C")]
				[CompilerGenerated]
				get
				{
					return default(NativeArray<float>);
				}
				[Token(Token = "0x6000618")]
				[Address(RVA = "0x2C9D558", Offset = "0x2C99558", VA = "0x2C9D558")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Token(Token = "0x170000FD")]
			public PerScenarioData bakingScenario
			{
				[Token(Token = "0x6000619")]
				[Address(RVA = "0x2C9D560", Offset = "0x2C99560", VA = "0x2C9D560")]
				get
				{
					return default(PerScenarioData);
				}
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x2C9D570", Offset = "0x2C99570", VA = "0x2C9D570")]
			public Cell()
			{
			}
		}

		[Token(Token = "0x20000F9")]
		[DebuggerDisplay("Index = {cell.index} Loaded = {loaded}")]
		internal class CellInfo : IComparable<CellInfo>
		{
			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Cell cell;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BlendingCellInfo blendingCell;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<ProbeBrickPool.BrickChunkAlloc> chunkList;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int flatIdxInCellIndices;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool loaded;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProbeBrickIndex.CellIndexUpdateInfo updateInfo;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public bool indexUpdated;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public ProbeBrickIndex.CellIndexUpdateInfo tempUpdateInfo;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public int sourceAssetInstanceID;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float streamingScore;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public int referenceCount;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public CellInstancedDebugProbes debugProbes;

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x2C9D604", Offset = "0x2C99604", VA = "0x2C9D604", Slot = "4")]
			public int CompareTo(CellInfo other)
			{
				return default(int);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x2C9D63C", Offset = "0x2C9963C", VA = "0x2C9D63C")]
			public void Clear()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x2C9D6B0", Offset = "0x2C996B0", VA = "0x2C9D6B0")]
			public CellInfo()
			{
			}
		}

		[Token(Token = "0x20000FA")]
		[DebuggerDisplay("Index = {cellInfo.cell.index} Factor = {blendingFactor} Score = {streamingScore}")]
		internal class BlendingCellInfo : IComparable<BlendingCellInfo>
		{
			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CellInfo cellInfo;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<ProbeBrickPool.BrickChunkAlloc> chunkList;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float streamingScore;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float blendingFactor;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool blending;

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x2C9D734", Offset = "0x2C99734", VA = "0x2C9D734", Slot = "4")]
			public int CompareTo(BlendingCellInfo other)
			{
				return default(int);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x2C9D76C", Offset = "0x2C9976C", VA = "0x2C9D76C")]
			public void Clear()
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x2C9D7C8", Offset = "0x2C997C8", VA = "0x2C9D7C8")]
			public void MarkUpToDate()
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x2C9D7D4", Offset = "0x2C997D4", VA = "0x2C9D7D4")]
			public bool IsUpToDate()
			{
				return default(bool);
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x2C9D7EC", Offset = "0x2C997EC", VA = "0x2C9D7EC")]
			public void ForceReupload()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x2C9D7F8", Offset = "0x2C997F8", VA = "0x2C9D7F8")]
			public bool ShouldReupload()
			{
				return default(bool);
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x2C9D80C", Offset = "0x2C9980C", VA = "0x2C9D80C")]
			public void Prioritize()
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x2C9D818", Offset = "0x2C99818", VA = "0x2C9D818")]
			public bool ShouldPrioritize()
			{
				return default(bool);
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x2C9D82C", Offset = "0x2C9982C", VA = "0x2C9D82C")]
			public BlendingCellInfo()
			{
			}
		}

		[Token(Token = "0x20000FB")]
		internal struct Volume : IEquatable<Volume>
		{
			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Vector3 corner;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Vector3 X;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vector3 Y;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal Vector3 Z;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal float maxSubdivisionMultiplier;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float minSubdivisionMultiplier;

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x2C9D8A8", Offset = "0x2C998A8", VA = "0x2C9D8A8")]
			public Volume(Matrix4x4 trs, float maxSubdivision, float minSubdivision)
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x2C9D98C", Offset = "0x2C9998C", VA = "0x2C9D98C")]
			public Volume(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1f, float minSubdivision = 0f)
			{
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x2C9D9CC", Offset = "0x2C999CC", VA = "0x2C9D9CC")]
			public Volume(Volume copy)
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x2C9DA60", Offset = "0x2C99A60", VA = "0x2C9DA60")]
			public Volume(Bounds bounds)
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x2C9DAC0", Offset = "0x2C99AC0", VA = "0x2C9DAC0")]
			public Bounds CalculateAABB()
			{
				return default(Bounds);
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x2C9DBC4", Offset = "0x2C99BC4", VA = "0x2C9DBC4")]
			public void CalculateCenterAndSize(out Vector3 center, out Vector3 size)
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x2C9DD74", Offset = "0x2C99D74", VA = "0x2C9DD74")]
			public void Transform(Matrix4x4 trs)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x2C9DE0C", Offset = "0x2C99E0C", VA = "0x2C9DE0C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x2C9E02C", Offset = "0x2C9A02C", VA = "0x2C9E02C", Slot = "4")]
			public bool Equals(Volume other)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000FC")]
		internal struct RefVolTransform
		{
			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 posWS;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Quaternion rot;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float scale;
		}

		[Token(Token = "0x20000FD")]
		public struct RuntimeResources
		{
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ComputeBuffer index;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ComputeBuffer cellIndices;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderTexture L0_L1rx;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RenderTexture L1_G_ry;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RenderTexture L1_B_rz;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RenderTexture L2_0;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RenderTexture L2_1;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public RenderTexture L2_2;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RenderTexture L2_3;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Texture3D Validity;
		}

		[Token(Token = "0x20000FE")]
		public struct ExtraDataActionInput
		{
		}

		[Token(Token = "0x20000FF")]
		private struct InitInfo
		{
			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3Int pendingMinCellPosition;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3Int pendingMaxCellPosition;
		}

		[Token(Token = "0x2000100")]
		internal class CellInstancedDebugProbes
		{
			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Matrix4x4[]> probeBuffers;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<Matrix4x4[]> offsetBuffers;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<MaterialPropertyBlock> props;

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x2C9E120", Offset = "0x2C9A120", VA = "0x2C9E120")]
			public CellInstancedDebugProbes()
			{
			}
		}

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_IsInitialized;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool m_SupportStreaming;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private RefVolTransform m_Transform;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_MaxSubdivision;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ProbeBrickPool m_Pool;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ProbeBrickIndex m_Index;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ProbeCellIndices m_CellIndices;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ProbeBrickBlendingPool m_BlendingPool;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] m_PositionOffsets;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Bounds m_CurrGlobalBounds;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal Dictionary<int, CellInfo> cells;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ObjectPool<CellInfo> m_CellInfoPool;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ObjectPool<BlendingCellInfo> m_BlendingCellInfoPool;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ProbeBrickPool.DataLocation m_TemporaryDataLocation;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int m_TemporaryDataLocationMemCost;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int m_CurrentProbeVolumeChunkSizeInBricks;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal ProbeVolumeSceneData sceneData;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3Int minLoadedCellPos;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Vector3Int maxLoadedCellPos;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Action<ExtraDataActionInput> retrieveExtraDataAction;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Action checksDuringBakeAction;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool m_BricksLoaded;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeLoaded;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeUnloaded;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Dictionary<string, ProbeVolumeAsset> m_ActiveAssets;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool m_NeedLoadAsset;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		private bool m_ProbeReferenceVolumeInit;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
		private bool m_EnabledBySRP;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private InitInfo m_PendingInitInfo;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private bool m_NeedsIndexRebuild;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
		private bool m_HasChangedIndex;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int m_CBShaderID;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int m_NumberOfCellsLoadedPerFrame;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int m_NumberOfCellsBlendedPerFrame;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float m_TurnoverRate;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private ProbeVolumeTextureMemoryBudget m_MemoryBudget;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private ProbeVolumeSHBands m_SHBands;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float m_ProbeVolumesWeight;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		internal bool clearAssetsOnVolumeClear;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static string defaultLightingScenario;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ProbeReferenceVolume _instance;

		[Token(Token = "0x4000408")]
		private const int kProbesPerBatch = 511;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly string k_DebugPanelName;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private DebugUI.Widget[] m_DebugItems;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Mesh m_DebugMesh;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Material m_DebugMaterial;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Mesh m_DebugOffsetMesh;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Material m_DebugOffsetMaterial;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Plane[] m_DebugFrustumPlanes;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private GUIContent[] m_DebugScenarioNames;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private int[] m_DebugScenarioValues;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private string m_DebugActiveSceneGUID;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private string m_DebugActiveScenario;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private DebugUI.EnumField m_DebugScenarioField;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		internal ProbeVolumeBakingProcessSettings bakingProcessSettings;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		internal Dictionary<Bounds, ProbeBrickIndex.Brick[]> realtimeSubdivisionInfo;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private bool m_MaxSubdivVisualizedIsMaxAvailable;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private DynamicArray<CellInfo> m_LoadedCells;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private DynamicArray<CellInfo> m_ToBeLoadedCells;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private DynamicArray<CellInfo> m_TempCellToLoadList;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private DynamicArray<CellInfo> m_TempCellToUnloadList;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private DynamicArray<BlendingCellInfo> m_LoadedBlendingCells;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private DynamicArray<BlendingCellInfo> m_ToBeLoadedBlendingCells;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private DynamicArray<BlendingCellInfo> m_TempBlendingCellToLoadList;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private DynamicArray<BlendingCellInfo> m_TempBlendingCellToUnloadList;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private Vector3 m_FrozenCameraPosition;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private bool m_HasRemainingCellsToBlend;

		[Token(Token = "0x170000E6")]
		internal Bounds globalBounds
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x2C93734", Offset = "0x2C8F734", VA = "0x2C93734")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x2C93748", Offset = "0x2C8F748", VA = "0x2C93748")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public bool isInitialized
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x2C9375C", Offset = "0x2C8F75C", VA = "0x2C9375C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E8")]
		internal bool enabledBySRP
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x2C93764", Offset = "0x2C8F764", VA = "0x2C93764")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		internal bool hasUnloadedCells
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x2C9376C", Offset = "0x2C8F76C", VA = "0x2C9376C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		internal bool enableScenarioBlending
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x2C937BC", Offset = "0x2C8F7BC", VA = "0x2C937BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EB")]
		internal int numberOfCellsLoadedPerFrame
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x2C93824", Offset = "0x2C8F824", VA = "0x2C93824")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EC")]
		public int numberOfCellsBlendedPerFrame
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x2C9382C", Offset = "0x2C8F82C", VA = "0x2C9382C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x2C93834", Offset = "0x2C8F834", VA = "0x2C93834")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public float turnoverRate
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x2C93844", Offset = "0x2C8F844", VA = "0x2C93844")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x2C9384C", Offset = "0x2C8F84C", VA = "0x2C9384C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public ProbeVolumeSHBands shBands
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x2C9386C", Offset = "0x2C8F86C", VA = "0x2C9386C")]
			get
			{
				return default(ProbeVolumeSHBands);
			}
		}

		[Token(Token = "0x170000EF")]
		public string lightingScenario
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x2C93874", Offset = "0x2C8F874", VA = "0x2C93874")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x2C9388C", Offset = "0x2C8F88C", VA = "0x2C9388C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public float scenarioBlendingFactor
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x2C938A4", Offset = "0x2C8F8A4", VA = "0x2C938A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x2C938BC", Offset = "0x2C8F8BC", VA = "0x2C938BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public ProbeVolumeTextureMemoryBudget memoryBudget
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x2C938F0", Offset = "0x2C8F8F0", VA = "0x2C938F0")]
			get
			{
				return default(ProbeVolumeTextureMemoryBudget);
			}
		}

		[Token(Token = "0x170000F2")]
		public float probeVolumesWeight
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x2C938F8", Offset = "0x2C8F8F8", VA = "0x2C938F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x2C93900", Offset = "0x2C8F900", VA = "0x2C93900")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		internal List<ProbeVolumePerSceneData> perSceneDataList
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x2C93920", Offset = "0x2C8F920", VA = "0x2C93920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x2C93928", Offset = "0x2C8F928", VA = "0x2C93928")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public static ProbeReferenceVolume instance
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x2C93A58", Offset = "0x2C8FA58", VA = "0x2C93A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		internal ProbeVolumeDebug probeVolumeDebug
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x2C9856C", Offset = "0x2C9456C", VA = "0x2C9856C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F6")]
		public Color[] subdivisionDebugColors
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x2C98574", Offset = "0x2C94574", VA = "0x2C98574")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2C938D8", Offset = "0x2C8F8D8", VA = "0x2C938D8")]
		public void BlendLightingScenario(string otherScenario, float blendingFactor)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2C93930", Offset = "0x2C8F930", VA = "0x2C93930")]
		internal void RegisterPerSceneData(ProbeVolumePerSceneData data)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2C93A00", Offset = "0x2C8FA00", VA = "0x2C93A00")]
		internal void UnregisterPerSceneData(ProbeVolumePerSceneData data)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2C93AB0", Offset = "0x2C8FAB0", VA = "0x2C93AB0")]
		public void Initialize(in ProbeVolumeSystemParameters parameters)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2C94084", Offset = "0x2C90084", VA = "0x2C94084")]
		public void SetEnableStateFromSRP(bool srpEnablesPV)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2C9408C", Offset = "0x2C9008C", VA = "0x2C9408C")]
		internal void ForceSHBand(ProbeVolumeSHBands shBands)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x2C94138", Offset = "0x2C90138", VA = "0x2C94138")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2C94248", Offset = "0x2C90248", VA = "0x2C94248")]
		public int GetVideoMemoryCost()
		{
			return default(int);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2C942CC", Offset = "0x2C902CC", VA = "0x2C942CC")]
		private void RemoveCell(Cell cell)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2C94438", Offset = "0x2C90438", VA = "0x2C94438")]
		internal void UnloadCell(CellInfo cellInfo)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2C94518", Offset = "0x2C90518", VA = "0x2C94518")]
		internal void UnloadBlendingCell(BlendingCellInfo blendingCell)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2C946BC", Offset = "0x2C906BC", VA = "0x2C946BC")]
		internal void UnloadAllCells()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2C94798", Offset = "0x2C90798", VA = "0x2C94798")]
		internal void UnloadAllBlendingCells()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2C94874", Offset = "0x2C90874", VA = "0x2C94874")]
		private void AddCell(Cell cell, int assetInstanceID)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x2C94A0C", Offset = "0x2C90A0C", VA = "0x2C94A0C")]
		internal bool LoadCell(CellInfo cellInfo, bool ignoreErrorLog = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2C94F7C", Offset = "0x2C90F7C", VA = "0x2C94F7C")]
		internal void LoadAllCells()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2C950B8", Offset = "0x2C910B8", VA = "0x2C950B8")]
		private void RecomputeMinMaxLoadedCellPos()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2C952AC", Offset = "0x2C912AC", VA = "0x2C952AC")]
		private bool CheckCompatibilityWithCollection(ProbeVolumeAsset asset, Dictionary<string, ProbeVolumeAsset> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2C95498", Offset = "0x2C91498", VA = "0x2C95498")]
		internal void AddPendingAssetLoading(ProbeVolumeAsset asset)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2C95BC0", Offset = "0x2C91BC0", VA = "0x2C95BC0")]
		internal void AddPendingAssetRemoval(ProbeVolumeAsset asset)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2C95CA8", Offset = "0x2C91CA8", VA = "0x2C95CA8")]
		internal void RemovePendingAsset(ProbeVolumeAsset asset)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2C95F1C", Offset = "0x2C91F1C", VA = "0x2C95F1C")]
		private void PerformPendingIndexChangeAndInit()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x2C95F5C", Offset = "0x2C91F5C", VA = "0x2C95F5C")]
		internal void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2C96094", Offset = "0x2C92094", VA = "0x2C96094")]
		private void LoadAsset(ProbeVolumeAsset asset)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2C96298", Offset = "0x2C92298", VA = "0x2C96298")]
		private void PerformPendingLoading()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x2C965E4", Offset = "0x2C925E4", VA = "0x2C965E4")]
		private void PerformPendingDeletion()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x2C96770", Offset = "0x2C92770", VA = "0x2C96770")]
		internal int GetNumberOfBricksAtSubdiv(Vector3Int position, int minSubdiv, out Vector3Int minValidLocalIdxAtMaxRes, out Vector3Int sizeOfValidIndicesAtMaxRes)
		{
			return default(int);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2C94B0C", Offset = "0x2C90B0C", VA = "0x2C94B0C")]
		private bool GetCellIndexUpdate(Cell cell, out ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2C96DB8", Offset = "0x2C92DB8", VA = "0x2C96DB8")]
		public void PerformPendingOperations()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x2C93E98", Offset = "0x2C8FE98", VA = "0x2C93E98")]
		private void InitProbeReferenceVolume(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget, ProbeVolumeSHBands shBands)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x2C96210", Offset = "0x2C92210", VA = "0x2C96210")]
		private void AllocateTemporaryDataLocation()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2C96DD8", Offset = "0x2C92DD8", VA = "0x2C96DD8")]
		private ProbeReferenceVolume()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2C97474", Offset = "0x2C93474", VA = "0x2C97474")]
		public RuntimeResources GetRuntimeResources()
		{
			return default(RuntimeResources);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x2C96010", Offset = "0x2C92010", VA = "0x2C96010")]
		internal void SetTRS(Vector3 position, Quaternion rotation, float minBrickSize)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x2C96024", Offset = "0x2C92024", VA = "0x2C96024")]
		internal void SetMaxSubdivision(int maxSubdivision)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x2C8EA50", Offset = "0x2C8AA50", VA = "0x2C8EA50")]
		internal static int CellSize(int subdivisionLevel)
		{
			return default(int);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x2C97524", Offset = "0x2C93524", VA = "0x2C97524")]
		internal float BrickSize(int subdivisionLevel)
		{
			return default(float);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x2C96DB0", Offset = "0x2C92DB0", VA = "0x2C96DB0")]
		internal float MinBrickSize()
		{
			return default(float);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x2C96DA4", Offset = "0x2C92DA4", VA = "0x2C96DA4")]
		internal float MaxBrickSize()
		{
			return default(float);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x2C975B8", Offset = "0x2C935B8", VA = "0x2C975B8")]
		internal RefVolTransform GetTransform()
		{
			return default(RefVolTransform);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x2C975C8", Offset = "0x2C935C8", VA = "0x2C975C8")]
		internal int GetMaxSubdivision()
		{
			return default(int);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x2C975D0", Offset = "0x2C935D0", VA = "0x2C975D0")]
		internal int GetMaxSubdivision(float multiplier)
		{
			return default(int);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x2C97650", Offset = "0x2C93650", VA = "0x2C97650")]
		internal float GetDistanceBetweenProbes(int subdivisionLevel)
		{
			return default(float);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2C97668", Offset = "0x2C93668", VA = "0x2C97668")]
		internal float MinDistanceBetweenProbes()
		{
			return default(float);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x2C97684", Offset = "0x2C93684", VA = "0x2C97684")]
		public bool DataHasBeenLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2C9768C", Offset = "0x2C9368C", VA = "0x2C9768C")]
		internal void Clear()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x2C97760", Offset = "0x2C93760", VA = "0x2C97760")]
		private List<ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, ProbeBrickPool.DataLocation dataLoc)
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x2C978E4", Offset = "0x2C938E4", VA = "0x2C978E4")]
		private void UpdatePool(List<ProbeBrickPool.BrickChunkAlloc> chunkList, Cell.PerScenarioData data, NativeArray<byte> validityNeighMaskData, int chunkIndex, int poolIndex)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x2C97E50", Offset = "0x2C93E50", VA = "0x2C97E50")]
		private void UpdatePoolValidity(List<ProbeBrickPool.BrickChunkAlloc> chunkList, Cell.PerScenarioData data, NativeArray<byte> validityNeighMaskData, int chunkIndex)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2C97F78", Offset = "0x2C93F78", VA = "0x2C97F78")]
		private bool AddBlendingBricks(BlendingCellInfo blendingCell)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2C94C74", Offset = "0x2C90C74", VA = "0x2C94C74")]
		private bool AddBricks(CellInfo cellInfo, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2C982B0", Offset = "0x2C942B0", VA = "0x2C982B0")]
		private void UpdateCellIndex(CellInfo cellInfo)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x2C9458C", Offset = "0x2C9058C", VA = "0x2C9458C")]
		private void ReleaseBricks(CellInfo cellInfo)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x2C98378", Offset = "0x2C94378", VA = "0x2C98378")]
		public void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2C940D0", Offset = "0x2C900D0", VA = "0x2C940D0")]
		private void CleanupLoadedData()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2C9857C", Offset = "0x2C9457C", VA = "0x2C9857C")]
		public void RenderDebug(Camera camera)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2C93D30", Offset = "0x2C8FD30", VA = "0x2C93D30")]
		private void InitializeDebug(in ProbeVolumeSystemParameters parameters)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2C941D4", Offset = "0x2C901D4", VA = "0x2C941D4")]
		private void CleanupDebug()
		{
		}

		[Token(Token = "0x60005F9")]
		private void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2C98F7C", Offset = "0x2C94F7C", VA = "0x2C98F7C")]
		private void RegisterDebug(ProbeVolumeSystemParameters parameters)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2C9B0DC", Offset = "0x2C970DC", VA = "0x2C9B0DC")]
		private void UnregisterDebug(bool destroyPanel)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x2C9B214", Offset = "0x2C97214", VA = "0x2C9B214")]
		private bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Plane[] frustumPlanes)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x2C985DC", Offset = "0x2C945DC", VA = "0x2C985DC")]
		private void DrawProbeDebug(Camera camera)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x2C9C254", Offset = "0x2C98254", VA = "0x2C9C254")]
		internal void ResetDebugViewToMaxSubdiv()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x2C9466C", Offset = "0x2C9066C", VA = "0x2C9466C")]
		private void ClearDebugData()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x2C9B464", Offset = "0x2C97464", VA = "0x2C9B464")]
		private CellInstancedDebugProbes CreateInstancedProbes(CellInfo cellInfo)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x2C9C304", Offset = "0x2C98304", VA = "0x2C9C304")]
		private void OnClearLightingdata()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x2C9C308", Offset = "0x2C98308", VA = "0x2C9C308")]
		internal void ScenarioBlendingChanged(bool scenarioChanged)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x2C9C3B0", Offset = "0x2C983B0", VA = "0x2C9C3B0")]
		public void SetNumberOfCellsLoadedPerFrame(int numberOfCells)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x2C9C3C0", Offset = "0x2C983C0", VA = "0x2C9C3C0")]
		private void ComputeCellCameraDistance(Vector3 cameraPosition, DynamicArray<CellInfo> cells)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x2C9C4F8", Offset = "0x2C984F8", VA = "0x2C9C4F8")]
		private void ComputeStreamingScoreForBlending(DynamicArray<BlendingCellInfo> cells, float worstScore)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x2C9C5F0", Offset = "0x2C985F0", VA = "0x2C9C5F0")]
		private bool TryLoadCell(CellInfo cellInfo, ref int shBudget, ref int indexBudget, DynamicArray<CellInfo> loadedCells)
		{
			return default(bool);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x2C9C6F0", Offset = "0x2C986F0", VA = "0x2C9C6F0")]
		private void UnloadBlendingCell(BlendingCellInfo blendingCell, DynamicArray<BlendingCellInfo> unloadedCells)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x2C9C768", Offset = "0x2C98768", VA = "0x2C9C768")]
		private bool TryLoadBlendingCell(BlendingCellInfo blendingCell, DynamicArray<BlendingCellInfo> loadedCells)
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x2C9C7EC", Offset = "0x2C987EC", VA = "0x2C9C7EC")]
		public void UpdateCellStreaming(CommandBuffer cmd, Camera camera)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x2C9D348", Offset = "0x2C99348", VA = "0x2C9D348")]
		private int FindWorstBlendingCellToBeLoaded()
		{
			return default(int);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x2C9CE10", Offset = "0x2C98E10", VA = "0x2C9CE10")]
		private void UpdateBlendingCellStreaming(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x2000103")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.12\\Runtime\\Lighting\\ProbeVolume\\ProbeReferenceVolume.Debug.cs")]
	public enum DebugProbeShadingMode
	{
		[Token(Token = "0x4000483")]
		SH,
		[Token(Token = "0x4000484")]
		SHL0,
		[Token(Token = "0x4000485")]
		SHL0L1,
		[Token(Token = "0x4000486")]
		Validity,
		[Token(Token = "0x4000487")]
		ValidityOverDilationThreshold,
		[Token(Token = "0x4000488")]
		InvalidatedByTouchupVolumes,
		[Token(Token = "0x4000489")]
		Size
	}
	[Token(Token = "0x2000104")]
	internal class ProbeVolumeDebug : IDebugData
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool drawProbes;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool drawBricks;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool drawCells;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool realtimeSubdivision;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int subdivisionCellUpdatePerFrame;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float subdivisionDelayInSeconds;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public DebugProbeShadingMode probeShading;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float probeSize;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float subdivisionViewCullingDistance;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float probeCullingDistance;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxSubdivToVisualize;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int minSubdivToVisualize;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float exposureCompensation;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool drawVirtualOffsetPush;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float offsetSize;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool freezeStreaming;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int otherStateIndex;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x2C9FB8C", Offset = "0x2C9BB8C", VA = "0x2C9FB8C")]
		public ProbeVolumeDebug()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x2C9FC10", Offset = "0x2C9BC10", VA = "0x2C9FC10")]
		private void Init()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x2C9FC58", Offset = "0x2C9BC58", VA = "0x2C9FC58", Slot = "4")]
		public Action GetReset()
		{
			return null;
		}
	}
	[Token(Token = "0x2000105")]
	public sealed class ProbeReferenceVolumeProfile : ScriptableObject
	{
		[Token(Token = "0x2000106")]
		internal enum Version
		{
			[Token(Token = "0x40004A2")]
			Initial
		}

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Version version;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		internal bool freezePlacement;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(2f, 5f)]
		public int simplificationLevels;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Min(0.1f)]
		public float minDistanceBetweenProbes;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask renderersLayerMask;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Min(0f)]
		public float minRendererVolumeSize;

		[Token(Token = "0x17000105")]
		public int cellSizeInBricks
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x2C9FD1C", Offset = "0x2C9BD1C", VA = "0x2C9FD1C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000106")]
		public int maxSubdivision
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x2C9FD50", Offset = "0x2C9BD50", VA = "0x2C9FD50")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000107")]
		public float minBrickSize
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x2C9FD5C", Offset = "0x2C9BD5C", VA = "0x2C9FD5C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000108")]
		public float cellSizeInMeters
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x2C9FD7C", Offset = "0x2C9BD7C", VA = "0x2C9FD7C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x2C9FDE0", Offset = "0x2C9BDE0", VA = "0x2C9FDE0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2C9FE44", Offset = "0x2C9BE44", VA = "0x2C9FE44")]
		public bool IsEquivalent(ProbeReferenceVolumeProfile otherProfile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x2C9FF4C", Offset = "0x2C9BF4C", VA = "0x2C9FF4C")]
		public ProbeReferenceVolumeProfile()
		{
		}
	}
	[Token(Token = "0x2000107")]
	[AddComponentMenu("Rendering/Probe Volume Touchup")]
	[ExecuteAlways]
	public class ProbeTouchupVolume : MonoBehaviour
	{
		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0.0001f, 2f)]
		public float intensityScale;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool invalidateProbes;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool overrideDilationThreshold;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 0.99f)]
		public float overriddenDilationThreshold;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 size;

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x2C9FFE8", Offset = "0x2C9BFE8", VA = "0x2C9FFE8")]
		public ProbeTouchupVolume()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AddComponentMenu("Rendering/Probe Volume")]
	[ExecuteAlways]
	public class ProbeVolume : MonoBehaviour
	{
		[Token(Token = "0x2000109")]
		public enum Mode
		{
			[Token(Token = "0x40004B7")]
			Global,
			[Token(Token = "0x40004B8")]
			Scene,
			[Token(Token = "0x40004B9")]
			Local
		}

		[Token(Token = "0x200010A")]
		private enum Version
		{
			[Token(Token = "0x40004BB")]
			Initial,
			[Token(Token = "0x40004BC")]
			LocalMode,
			[Token(Token = "0x40004BD")]
			Count
		}

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("When set to Global this Probe Volume considers all renderers with Contribute Global Illumination enabled. Local only considers renderers in the scene.\nThis list updates every time the Scene is saved or the lighting is baked.")]
		public Mode mode;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 size;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Min(0f)]
		[HideInInspector]
		public bool overrideRendererFilters;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		[Min(0f)]
		public float minRendererVolumeSize;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LayerMask objectLayerMask;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		public int lowestSubdivLevelOverride;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public int highestSubdivLevelOverride;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public bool overridesSubdivLevels;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[SerializeField]
		internal bool mightNeedRebaking;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal Matrix4x4 cachedTransform;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		internal int cachedHashCode;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[HideInInspector]
		[Tooltip("Whether spaces with no renderers need to be filled with bricks at lowest subdivision level.")]
		public bool fillEmptySpaces;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Version version;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Obsolete("Use mode instead")]
		public bool globalVolume;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x2CA0004", Offset = "0x2C9C004", VA = "0x2CA0004")]
		private void Awake()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x2CA002C", Offset = "0x2C9C02C", VA = "0x2CA002C")]
		public ProbeVolume()
		{
		}
	}
	[Token(Token = "0x200010B")]
	[PreferBinarySerialization]
	internal class ProbeVolumeAsset : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		internal enum AssetVersion
		{
			[Token(Token = "0x40004CC")]
			First = 0,
			[Token(Token = "0x40004CD")]
			AddProbeVolumesAtlasEncodingModes = 1,
			[Token(Token = "0x40004CE")]
			PV2 = 2,
			[Token(Token = "0x40004CF")]
			ChunkBasedIndex = 3,
			[Token(Token = "0x40004D0")]
			BinaryRuntimeDebugSplit = 4,
			[Token(Token = "0x40004D1")]
			BinaryTextureData = 5,
			[Token(Token = "0x40004D2")]
			Max = 6,
			[Token(Token = "0x40004D3")]
			Current = 5
		}

		[Serializable]
		[Token(Token = "0x200010D")]
		internal struct CellCounts
		{
			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int bricksCount;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int probesCount;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int offsetsCount;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int chunksCount;

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x2CA05F4", Offset = "0x2C9C5F4", VA = "0x2CA05F4")]
			public void Add(CellCounts o)
			{
			}
		}

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected internal int m_Version;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal ProbeReferenceVolume.Cell[] cells;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal CellCounts[] cellCounts;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal CellCounts totalCellCounts;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal Vector3Int maxCellPosition;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		internal Vector3Int minCellPosition;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		internal Bounds globalBounds;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		internal ProbeVolumeSHBands bands;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		internal int chunkSizeInBricks;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string m_AssetFullPath;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		internal int cellSizeInBricks;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		internal int simplificationLevels;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		internal float minDistanceBetweenProbes;

		[Token(Token = "0x17000109")]
		public int Version
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x2CA008C", Offset = "0x2C9C08C", VA = "0x2CA008C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700010A")]
		internal int maxSubdivision
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x2CA0094", Offset = "0x2C9C094", VA = "0x2CA0094")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700010B")]
		internal float minBrickSize
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x2CA00A0", Offset = "0x2C9C0A0", VA = "0x2CA00A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x2CA00C0", Offset = "0x2C9C0C0", VA = "0x2CA00C0")]
		internal bool CompatibleWith(ProbeVolumeAsset otherAsset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x2CA013C", Offset = "0x2C9C13C", VA = "0x2CA013C")]
		internal bool IsInvalid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x2CA0178", Offset = "0x2C9C178", VA = "0x2CA0178")]
		public string GetSerializedFullPath()
		{
			return null;
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x2CA0180", Offset = "0x2C9C180", VA = "0x2CA0180")]
		private static int AlignUp16(int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000693")]
		private NativeArray<T> GetSubArray<T>(NativeArray<byte> input, int count, ref int offset) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x2CA01A8", Offset = "0x2C9C1A8", VA = "0x2CA01A8")]
		internal bool ResolveSharedCellData(TextAsset cellSharedDataAsset, TextAsset cellSupportDataAsset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x2CA0620", Offset = "0x2C9C620", VA = "0x2CA0620")]
		internal bool ResolvePerScenarioCellData(TextAsset cellDataAsset, TextAsset cellOptionalDataAsset, int stateIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x2CA0B0C", Offset = "0x2C9CB0C", VA = "0x2CA0B0C")]
		public ProbeVolumeAsset()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010E")]
	internal struct ProbeDilationSettings
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool enableDilation;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float dilationDistance;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float dilationValidityThreshold;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int dilationIterations;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool squaredDistWeighting;

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x2CA0B64", Offset = "0x2C9CB64", VA = "0x2CA0B64")]
		internal void SetDefaults()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x2CA0B84", Offset = "0x2C9CB84", VA = "0x2CA0B84")]
		internal void UpgradeFromTo(ProbeVolumeBakingProcessSettings.SettingsVersion from, ProbeVolumeBakingProcessSettings.SettingsVersion to)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010F")]
	internal struct VirtualOffsetSettings
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool useVirtualOffset;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Range(0f, 1f)]
		public float outOfGeoOffset;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Range(0f, 2f)]
		public float searchMultiplier;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Range(-0.05f, 0f)]
		public float rayOriginBias;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(4f, 24f)]
		public int maxHitsPerRay;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public LayerMask collisionMask;

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x2CA0B88", Offset = "0x2C9CB88", VA = "0x2CA0B88")]
		internal void SetDefaults()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x2CA0BCC", Offset = "0x2C9CBCC", VA = "0x2CA0BCC")]
		internal void UpgradeFromTo(ProbeVolumeBakingProcessSettings.SettingsVersion from, ProbeVolumeBakingProcessSettings.SettingsVersion to)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000110")]
	internal struct ProbeVolumeBakingProcessSettings
	{
		[Token(Token = "0x2000111")]
		internal enum SettingsVersion
		{
			[Token(Token = "0x40004E7")]
			Initial = 0,
			[Token(Token = "0x40004E8")]
			ThreadedVirtualOffset = 1,
			[Token(Token = "0x40004E9")]
			Max = 2,
			[Token(Token = "0x40004EA")]
			Current = 1
		}

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private SettingsVersion m_Version;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ProbeDilationSettings dilationSettings;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VirtualOffsetSettings virtualOffsetSettings;

		[Token(Token = "0x1700010C")]
		internal static ProbeVolumeBakingProcessSettings Default
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x2CA0C0C", Offset = "0x2C9CC0C", VA = "0x2CA0C0C")]
			get
			{
				return default(ProbeVolumeBakingProcessSettings);
			}
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x2CA0CE0", Offset = "0x2C9CCE0", VA = "0x2CA0CE0")]
		internal ProbeVolumeBakingProcessSettings(ProbeDilationSettings dilationSettings, VirtualOffsetSettings virtualOffsetSettings)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x2CA0C80", Offset = "0x2C9CC80", VA = "0x2CA0C80")]
		internal void SetDefaults()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x2CA0D0C", Offset = "0x2C9CD0C", VA = "0x2CA0D0C")]
		internal void Upgrade()
		{
		}
	}
	[Token(Token = "0x2000112")]
	internal struct GIContributors
	{
	}
	[Token(Token = "0x2000113")]
	[AddComponentMenu("")]
	[ExecuteAlways]
	public class ProbeVolumePerSceneData : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2000114")]
		internal struct PerScenarioData
		{
			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int sceneHash;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public TextAsset cellDataAsset;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TextAsset cellOptionalDataAsset;
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		private struct SerializablePerScenarioDataItem
		{
			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string scenario;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public PerScenarioData data;
		}

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal ProbeVolumeAsset asset;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal TextAsset cellSharedDataAsset;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal TextAsset cellSupportDataAsset;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<SerializablePerScenarioDataItem> serializedScenarios;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal Dictionary<string, PerScenarioData> scenarios;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool assetLoaded;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string activeScenario;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string otherScenario;

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x2CA0D58", Offset = "0x2C9CD58", VA = "0x2CA0D58", Slot = "5")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x2CA0EE4", Offset = "0x2C9CEE4", VA = "0x2CA0EE4", Slot = "4")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x2CA1114", Offset = "0x2C9D114", VA = "0x2CA1114")]
		internal void Clear()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x2CA124C", Offset = "0x2C9D24C", VA = "0x2CA124C")]
		internal void RemoveScenario(string scenario)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x2CA12A4", Offset = "0x2C9D2A4", VA = "0x2CA12A4")]
		internal void RenameScenario(string scenario, string newName)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2CA1388", Offset = "0x2C9D388", VA = "0x2CA1388")]
		internal bool ResolveCells()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2CA13B0", Offset = "0x2C9D3B0", VA = "0x2CA13B0")]
		internal bool ResolveSharedCellData()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x2CA1438", Offset = "0x2C9D438", VA = "0x2CA1438")]
		private bool ResolvePerScenarioCellData()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2CA1594", Offset = "0x2C9D594", VA = "0x2CA1594")]
		internal void QueueAssetLoading()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x2CA116C", Offset = "0x2C9D16C", VA = "0x2CA116C")]
		internal void QueueAssetRemoval()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x2CA16BC", Offset = "0x2C9D6BC", VA = "0x2CA16BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x2CA18B0", Offset = "0x2C9D8B0", VA = "0x2CA18B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x2CA17B0", Offset = "0x2C9D7B0", VA = "0x2CA17B0")]
		internal void Initialize()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x2CA1958", Offset = "0x2C9D958", VA = "0x2CA1958")]
		internal void UpdateActiveScenario(string activeScenario, string otherScenario)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x2CA1A10", Offset = "0x2C9DA10", VA = "0x2CA1A10")]
		public ProbeVolumePerSceneData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000116")]
	public class ProbeVolumeSceneData : ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2000117")]
		private struct SerializableBoundItem
		{
			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string sceneGUID;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public Bounds bounds;
		}

		[Serializable]
		[Token(Token = "0x2000118")]
		private struct SerializableHasPVItem
		{
			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string sceneGUID;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public bool hasProbeVolumes;
		}

		[Serializable]
		[Token(Token = "0x2000119")]
		private struct SerializablePVProfile
		{
			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string sceneGUID;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public ProbeReferenceVolumeProfile profile;
		}

		[Serializable]
		[Token(Token = "0x200011A")]
		private struct SerializablePVBakeSettings
		{
			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string sceneGUID;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ProbeVolumeBakingProcessSettings settings;
		}

		[Serializable]
		[Token(Token = "0x200011B")]
		internal class BakingSet
		{
			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<string> sceneGUIDs;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProbeVolumeBakingProcessSettings settings;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public ProbeReferenceVolumeProfile profile;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<string> lightingScenarios;

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x2CA3938", Offset = "0x2C9F938", VA = "0x2CA3938")]
			internal string CreateScenario(string name)
			{
				return null;
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x2CA3AA0", Offset = "0x2C9FAA0", VA = "0x2CA3AA0")]
			internal bool RemoveScenario(string name)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x2CA37E8", Offset = "0x2C9F7E8", VA = "0x2CA37E8")]
			public BakingSet()
			{
			}
		}

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PropertyInfo s_SceneGUID;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<SerializableBoundItem> serializedBounds;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<SerializableHasPVItem> serializedHasVolumes;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SerializablePVProfile> serializedProfiles;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SerializablePVBakeSettings> serializedBakeSettings;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<BakingSet> serializedBakingSets;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Object parentAsset;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal string parentSceneDataPropertyName;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Dictionary<string, Bounds> sceneBounds;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal Dictionary<string, bool> hasProbeVolumes;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal Dictionary<string, ProbeReferenceVolumeProfile> sceneProfiles;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal Dictionary<string, ProbeVolumeBakingProcessSettings> sceneBakingSettings;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal List<BakingSet> bakingSets;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string m_LightingScenario;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string m_OtherScenario;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_ScenarioBlendingFactor;

		[Token(Token = "0x1700010D")]
		internal string lightingScenario
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x2CA1AD4", Offset = "0x2C9DAD4", VA = "0x2CA1AD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		internal string otherScenario
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x2CA1ADC", Offset = "0x2C9DADC", VA = "0x2CA1ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010F")]
		internal float scenarioBlendingFactor
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x2CA1AE4", Offset = "0x2C9DAE4", VA = "0x2CA1AE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x2C9F5E4", Offset = "0x2C9B5E4", VA = "0x2C9F5E4")]
		internal static string GetSceneGUID(Scene scene)
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x2CA1AEC", Offset = "0x2C9DAEC", VA = "0x2CA1AEC")]
		internal void SetActiveScenario(string scenario)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x2C9F740", Offset = "0x2C9B740", VA = "0x2C9F740")]
		internal void BlendLightingScenario(string otherScenario, float blendingFactor)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x2CA1DC8", Offset = "0x2C9DDC8", VA = "0x2CA1DC8")]
		public ProbeVolumeSceneData(Object parentAsset, string parentSceneDataPropertyName)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x2CA22A0", Offset = "0x2C9E2A0", VA = "0x2CA22A0")]
		public void SetParentObject(Object parent, string parentSceneDataPropertyName)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x2CA22A8", Offset = "0x2C9E2A8", VA = "0x2CA22A8", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2CA20E0", Offset = "0x2C9E0E0", VA = "0x2CA20E0")]
		private void UpdateBakingSets()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x2CA2F40", Offset = "0x2C9EF40", VA = "0x2CA2F40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2CA3718", Offset = "0x2C9F718", VA = "0x2CA3718")]
		internal BakingSet CreateNewBakingSet(string name)
		{
			return null;
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x2CA2A7C", Offset = "0x2C9EA7C", VA = "0x2CA2A7C")]
		private void InitializeBakingSet(BakingSet set, string name)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x2CA2B4C", Offset = "0x2C9EB4C", VA = "0x2CA2B4C")]
		private void InitializeScenarios(BakingSet set)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2CA2C60", Offset = "0x2C9EC60", VA = "0x2CA2C60")]
		internal void SyncBakingSetSettings()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public enum APVConstantBufferRegister
	{
		[Token(Token = "0x4000516")]
		GlobalRegister = 5
	}
	[Token(Token = "0x200011D")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.12\\Runtime\\Lighting\\ProbeVolume\\ShaderVariablesProbeVolumes.cs")]
	public enum APVLeakReductionMode
	{
		[Token(Token = "0x4000518")]
		None,
		[Token(Token = "0x4000519")]
		ValidityAndNormalBased
	}
	[Token(Token = "0x200011E")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.12\\Runtime\\Lighting\\ProbeVolume\\ShaderVariablesProbeVolumes.cs", needAccessors = false, generateCBuffer = true, constantRegister = 5)]
	internal struct ShaderVariablesProbeVolumes
	{
		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4 _PoolDim_CellInMeters;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector4 _MinCellPos_Noise;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector4 _IndicesDim_IndexChunkSize;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector4 _Biases_CellInMinBrick_MinBrickSize;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector4 _LeakReductionParams;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector4 _Weight_MinLoadedCell;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector4 _MaxLoadedCell_FrameIndex;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector4 _NormalizationClamp_Padding12;
	}
	[Serializable]
	[Token(Token = "0x200011F")]
	public struct SphericalHarmonicsL1
	{
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4 shAr;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector4 shAg;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector4 shAb;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SphericalHarmonicsL1 zero;

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2CA3AF8", Offset = "0x2C9FAF8", VA = "0x2CA3AF8")]
		public static SphericalHarmonicsL1 operator +(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
		{
			return default(SphericalHarmonicsL1);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x2CA3B20", Offset = "0x2C9FB20", VA = "0x2CA3B20")]
		public static SphericalHarmonicsL1 operator -(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
		{
			return default(SphericalHarmonicsL1);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2CA3B48", Offset = "0x2C9FB48", VA = "0x2CA3B48")]
		public static SphericalHarmonicsL1 operator *(SphericalHarmonicsL1 lhs, float rhs)
		{
			return default(SphericalHarmonicsL1);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2CA3B68", Offset = "0x2C9FB68", VA = "0x2CA3B68")]
		public static SphericalHarmonicsL1 operator /(SphericalHarmonicsL1 lhs, float rhs)
		{
			return default(SphericalHarmonicsL1);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x2CA3B8C", Offset = "0x2C9FB8C", VA = "0x2CA3B8C")]
		public static bool operator ==(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x2CA3C3C", Offset = "0x2C9FC3C", VA = "0x2CA3C3C")]
		public static bool operator !=(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x2CA3CD4", Offset = "0x2C9FCD4", VA = "0x2CA3CD4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x2CA3DA4", Offset = "0x2C9FDA4", VA = "0x2CA3DA4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000120")]
	public class SphericalHarmonicsL2Utils
	{
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x2CA3F48", Offset = "0x2C9FF48", VA = "0x2CA3F48")]
		public static void GetL1(SphericalHarmonicsL2 sh, out Vector3 L1_R, out Vector3 L1_G, out Vector3 L1_B)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x2CA405C", Offset = "0x2CA005C", VA = "0x2CA405C")]
		public static void GetL2(SphericalHarmonicsL2 sh, out Vector3 L2_0, out Vector3 L2_1, out Vector3 L2_2, out Vector3 L2_3, out Vector3 L2_4)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x2CA4218", Offset = "0x2CA0218", VA = "0x2CA4218")]
		public static void SetL0(ref SphericalHarmonicsL2 sh, Vector3 L0)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x2CA4274", Offset = "0x2CA0274", VA = "0x2CA4274")]
		public static void SetL1R(ref SphericalHarmonicsL2 sh, Vector3 L1_R)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x2CA42D0", Offset = "0x2CA02D0", VA = "0x2CA42D0")]
		public static void SetL1G(ref SphericalHarmonicsL2 sh, Vector3 L1_G)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x2CA432C", Offset = "0x2CA032C", VA = "0x2CA432C")]
		public static void SetL1B(ref SphericalHarmonicsL2 sh, Vector3 L1_B)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x2CA4388", Offset = "0x2CA0388", VA = "0x2CA4388")]
		public static void SetL1(ref SphericalHarmonicsL2 sh, Vector3 L1_R, Vector3 L1_G, Vector3 L1_B)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x2CA43EC", Offset = "0x2CA03EC", VA = "0x2CA43EC")]
		public static void SetCoefficient(ref SphericalHarmonicsL2 sh, int index, Vector3 coefficient)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2CA4454", Offset = "0x2CA0454", VA = "0x2CA4454")]
		public static Vector3 GetCoefficient(SphericalHarmonicsL2 sh, int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x2CA44C4", Offset = "0x2CA04C4", VA = "0x2CA44C4")]
		public SphericalHarmonicsL2Utils()
		{
		}
	}
	[Token(Token = "0x2000121")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.12\\Runtime\\PostProcessing\\HDROutputDefines.cs")]
	public enum HDRRangeReduction
	{
		[Token(Token = "0x4000527")]
		None,
		[Token(Token = "0x4000528")]
		Reinhard,
		[Token(Token = "0x4000529")]
		BT2390,
		[Token(Token = "0x400052A")]
		ACES1000Nits,
		[Token(Token = "0x400052B")]
		ACES2000Nits,
		[Token(Token = "0x400052C")]
		ACES4000Nits
	}
	[Token(Token = "0x2000122")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.12\\Runtime\\PostProcessing\\HDROutputDefines.cs")]
	public enum HDRColorspace
	{
		[Token(Token = "0x400052E")]
		Rec709,
		[Token(Token = "0x400052F")]
		Rec2020,
		[Token(Token = "0x4000530")]
		P3D65
	}
	[Token(Token = "0x2000123")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.12\\Runtime\\PostProcessing\\HDROutputDefines.cs")]
	public enum HDREncoding
	{
		[Token(Token = "0x4000532")]
		Linear = 3,
		[Token(Token = "0x4000533")]
		PQ = 2,
		[Token(Token = "0x4000534")]
		Gamma22 = 4,
		[Token(Token = "0x4000535")]
		sRGB = 0
	}
	[Token(Token = "0x2000124")]
	public sealed class LensFlareCommonSRP
	{
		[Token(Token = "0x2000125")]
		internal class LensFlareCompInfo
		{
			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int index;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal LensFlareComponentSRP comp;

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x2CA4F10", Offset = "0x2CA0F10", VA = "0x2CA4F10")]
			internal LensFlareCompInfo(int idx, LensFlareComponentSRP cmp)
			{
			}
		}

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LensFlareCommonSRP m_Instance;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object m_Padlock;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<LensFlareCompInfo> m_Data;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<int> m_AvailableIndicies;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int maxLensFlareWithOcclusion;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static int maxLensFlareWithOcclusionTemporalSample;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static int mergeNeeded;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static RTHandle occlusionRT;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static int frameIdx;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static readonly bool s_SupportsLensFlareTexFormat;

		[Token(Token = "0x17000110")]
		public static LensFlareCommonSRP Instance
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x2CA49A8", Offset = "0x2CA09A8", VA = "0x2CA49A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		private List<LensFlareCompInfo> Data
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x2CA4B30", Offset = "0x2CA0B30", VA = "0x2CA4B30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2CA44CC", Offset = "0x2CA04CC", VA = "0x2CA44CC")]
		private LensFlareCommonSRP()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2CA44D4", Offset = "0x2CA04D4", VA = "0x2CA44D4")]
		public static bool IsOcclusionRTCompatible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x2CA455C", Offset = "0x2CA055C", VA = "0x2CA455C")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x2CA486C", Offset = "0x2CA086C", VA = "0x2CA486C")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x2CA4B88", Offset = "0x2CA0B88", VA = "0x2CA4B88")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x2CA4C0C", Offset = "0x2CA0C0C", VA = "0x2CA4C0C")]
		private int GetNextAvailableIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x2CA4D30", Offset = "0x2CA0D30", VA = "0x2CA4D30")]
		public void AddData(LensFlareComponentSRP newData)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x2CA4F40", Offset = "0x2CA0F40", VA = "0x2CA4F40")]
		public void RemoveData(LensFlareComponentSRP data)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x2CA5168", Offset = "0x2CA1168", VA = "0x2CA5168")]
		public static float ShapeAttenuationPointLight()
		{
			return default(float);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x2CA5170", Offset = "0x2CA1170", VA = "0x2CA5170")]
		public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo)
		{
			return default(float);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2CA5190", Offset = "0x2CA1190", VA = "0x2CA5190")]
		public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01)
		{
			return default(float);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x2CA5244", Offset = "0x2CA1244", VA = "0x2CA5244")]
		public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo)
		{
			return default(float);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x2CA5274", Offset = "0x2CA1274", VA = "0x2CA5274")]
		public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo)
		{
			return default(float);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2CA531C", Offset = "0x2CA131C", VA = "0x2CA531C")]
		public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam)
		{
			return default(float);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x2CA5830", Offset = "0x2CA1830", VA = "0x2CA5830")]
		public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo)
		{
			return default(float);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x2CA58C8", Offset = "0x2CA18C8", VA = "0x2CA58C8")]
		public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo)
		{
			return default(float);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2CA5960", Offset = "0x2CA1960", VA = "0x2CA5960")]
		private static bool IsLensFlareSRPHidden(Camera cam, LensFlareComponentSRP comp, LensFlareDataSRP data)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x2CA5A84", Offset = "0x2CA1A84", VA = "0x2CA5A84")]
		public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x2CA5C78", Offset = "0x2CA1C78", VA = "0x2CA5C78")]
		private static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2CA5CAC", Offset = "0x2CA1CAC", VA = "0x2CA5CAC")]
		private static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2CA5DF0", Offset = "0x2CA1DF0", VA = "0x2CA5DF0")]
		private static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2CA5E6C", Offset = "0x2CA1E6C", VA = "0x2CA5E6C")]
		private static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x2CA5F54", Offset = "0x2CA1F54", VA = "0x2CA5F54")]
		public static bool IsCloudLayerOpacityNeeded(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2CA61BC", Offset = "0x2CA21BC", VA = "0x2CA61BC")]
		private static void SetOcclusionPermutation(CommandBuffer cmd, bool useBackgroundCloudOcclusion, bool volumetricCloudOcclusion, bool hasCloudLayer, int _FlareCloudOpacity, int _FlareSunOcclusionTex, Texture cloudOpacityTexture, Texture sunOcclusionTexture)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2CA6358", Offset = "0x2CA2358", VA = "0x2CA6358")]
		public static void ComputeOcclusion(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x2CA741C", Offset = "0x2CA341C", VA = "0x2CA741C")]
		public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x2CA71BC", Offset = "0x2CA31BC", VA = "0x2CA71BC")]
		private static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2CA9744", Offset = "0x2CA5744", VA = "0x2CA9744")]
		private static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x2CA9788", Offset = "0x2CA5788", VA = "0x2CA9788")]
		private static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2CA984C", Offset = "0x2CA584C", VA = "0x2CA984C")]
		private static Vector2 Panini_Generic_Inv(Vector2 projPos, float d)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x200012B")]
	[AddComponentMenu("Rendering/Lens Flare (SRP)")]
	[ExecuteAlways]
	public sealed class LensFlareComponentSRP : MonoBehaviour
	{
		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LensFlareDataSRP m_LensFlareData;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Min(0f)]
		public float intensity;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Min(1E-05f)]
		public float maxAttenuationDistance;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Min(1E-05f)]
		public float maxAttenuationScale;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve distanceAttenuationCurve;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scaleByDistanceCurve;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool attenuationByLightShape;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve radialScreenAttenuationCurve;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool useOcclusion;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Min(0f)]
		public float occlusionRadius;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool useBackgroundCloudOcclusion;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Range(1f, 64f)]
		public uint sampleCount;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float occlusionOffset;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Min(0f)]
		public float scale;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool allowOffScreen;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool volumetricCloudOcclusion;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float sCelestialAngularRadius;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TextureCurve occlusionRemapCurve;

		[Token(Token = "0x17000112")]
		public LensFlareDataSRP lensFlareData
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x2CA9B10", Offset = "0x2CA5B10", VA = "0x2CA9B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x2CA9B18", Offset = "0x2CA5B18", VA = "0x2CA9B18")]
			set
			{
			}
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x2CA7328", Offset = "0x2CA3328", VA = "0x2CA7328")]
		public float celestialProjectedOcclusionRadius(Camera mainCam)
		{
			return default(float);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x2CA9BF4", Offset = "0x2CA5BF4", VA = "0x2CA9BF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x2CA9CB0", Offset = "0x2CA5CB0", VA = "0x2CA9CB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x2CA9B20", Offset = "0x2CA5B20", VA = "0x2CA9B20")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x2CA9D10", Offset = "0x2CA5D10", VA = "0x2CA9D10")]
		public LensFlareComponentSRP()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012C")]
	public enum SRPLensFlareBlendMode
	{
		[Token(Token = "0x400055E")]
		Additive,
		[Token(Token = "0x400055F")]
		Screen,
		[Token(Token = "0x4000560")]
		Premultiply,
		[Token(Token = "0x4000561")]
		Lerp
	}
	[Serializable]
	[Token(Token = "0x200012D")]
	public enum SRPLensFlareDistribution
	{
		[Token(Token = "0x4000563")]
		Uniform,
		[Token(Token = "0x4000564")]
		Curve,
		[Token(Token = "0x4000565")]
		Random
	}
	[Serializable]
	[Token(Token = "0x200012E")]
	public enum SRPLensFlareType
	{
		[Token(Token = "0x4000567")]
		Image,
		[Token(Token = "0x4000568")]
		Circle,
		[Token(Token = "0x4000569")]
		Polygon
	}
	[Serializable]
	[Token(Token = "0x200012F")]
	public sealed class LensFlareDataElementSRP
	{
		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool visible;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float position;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 positionOffset;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float angularOffset;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 translationScale;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Min(0f)]
		[FormerlySerializedAs("localIntensity")]
		private float m_LocalIntensity;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture lensFlareTexture;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float uniformScale;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector2 sizeXY;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool allowMultipleElement;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Min(1f)]
		[FormerlySerializedAs("count")]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool preserveAspectRatio;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float rotation;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Color tint;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public SRPLensFlareBlendMode blendMode;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool autoRotate;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public SRPLensFlareType flareType;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool modulateByLightColor;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[SerializeField]
		private bool isFoldOpened;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public SRPLensFlareDistribution distribution;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float lengthSpread;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve positionCurve;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve scaleCurve;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int seed;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Gradient colorGradient;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[FormerlySerializedAs("intensityVariation")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_IntensityVariation;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public Vector2 positionVariation;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float scaleVariation;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float rotationVariation;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool enableRadialDistortion;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Vector2 targetSizeDistortion;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AnimationCurve distortionCurve;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool distortionRelativeToCenter;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[FormerlySerializedAs("fallOff")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_FallOff;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Range(0f, 1f)]
		[FormerlySerializedAs("edgeOffset")]
		private float m_EdgeOffset;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[FormerlySerializedAs("sideCount")]
		[Min(3f)]
		[SerializeField]
		private int m_SideCount;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		[SerializeField]
		[FormerlySerializedAs("sdfRoundness")]
		private float m_SdfRoundness;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public bool inverseSDF;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float uniformAngle;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AnimationCurve uniformAngleCurve;

		[Token(Token = "0x17000113")]
		public float localIntensity
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x2CAA700", Offset = "0x2CA6700", VA = "0x2CAA700")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x2CAA654", Offset = "0x2CA6654", VA = "0x2CAA654")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public int count
		{
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x2CAA708", Offset = "0x2CA6708", VA = "0x2CAA708")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x2CAA668", Offset = "0x2CA6668", VA = "0x2CAA668")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		public float intensityVariation
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x2CAA710", Offset = "0x2CA6710", VA = "0x2CAA710")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x2CAA678", Offset = "0x2CA6678", VA = "0x2CAA678")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public float fallOff
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x2CAA718", Offset = "0x2CA6718", VA = "0x2CAA718")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x2CAA68C", Offset = "0x2CA668C", VA = "0x2CAA68C")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public float edgeOffset
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x2CAA720", Offset = "0x2CA6720", VA = "0x2CAA720")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x2CAA6AC", Offset = "0x2CA66AC", VA = "0x2CAA6AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public int sideCount
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x2CAA728", Offset = "0x2CA6728", VA = "0x2CAA728")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x2CAA6EC", Offset = "0x2CA66EC", VA = "0x2CAA6EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public float sdfRoundness
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x2CAA730", Offset = "0x2CA6730", VA = "0x2CAA730")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x2CAA6CC", Offset = "0x2CA66CC", VA = "0x2CAA6CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x2CAA088", Offset = "0x2CA6088", VA = "0x2CAA088")]
		public LensFlareDataElementSRP()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000130")]
	public sealed class LensFlareDataSRP : ScriptableObject
	{
		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LensFlareDataElementSRP[] elements;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x2CAA738", Offset = "0x2CA6738", VA = "0x2CAA738")]
		public LensFlareDataSRP()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public interface ICloudBackground
	{
		[Token(Token = "0x6000718")]
		bool IsCloudBackgroundUsable();
	}
	[Token(Token = "0x2000132")]
	public enum ShaderVariantLogLevel
	{
		[Token(Token = "0x4000594")]
		[Tooltip("No shader variants are logged")]
		Disabled,
		[Token(Token = "0x4000595")]
		[Tooltip("Only shaders that are compatible with SRPs (e.g., URP, HDRP) are logged")]
		OnlySRPShaders,
		[Token(Token = "0x4000596")]
		[Tooltip("All shader variants are logged")]
		AllShaders
	}
	[Token(Token = "0x2000133")]
	public interface IShaderVariantSettings
	{
		[Token(Token = "0x1700011A")]
		ShaderVariantLogLevel shaderVariantLogLevel
		{
			[Token(Token = "0x6000719")]
			get;
			[Token(Token = "0x600071A")]
			set;
		}

		[Token(Token = "0x1700011B")]
		bool exportShaderVariants
		{
			[Token(Token = "0x600071B")]
			get;
			[Token(Token = "0x600071C")]
			set;
		}
	}
	[Token(Token = "0x2000134")]
	public interface IVolumetricCloud
	{
		[Token(Token = "0x600071D")]
		bool IsVolumetricCloudUsable();
	}
	[Token(Token = "0x2000135")]
	public abstract class RenderPipelineResources : ScriptableObject
	{
		[Token(Token = "0x1700011C")]
		protected virtual string packagePath
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x2CAA754", Offset = "0x2CA6754", VA = "0x2CAA754", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		internal string packagePath_Internal
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x2CAA75C", Offset = "0x2CA675C", VA = "0x2CAA75C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2CAA768", Offset = "0x2CA6768", VA = "0x2CAA768")]
		protected RenderPipelineResources()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public enum PackingRules
	{
		[Token(Token = "0x4000598")]
		Exact,
		[Token(Token = "0x4000599")]
		Aggressive
	}
	[Token(Token = "0x2000137")]
	public enum FieldPacking
	{
		[Token(Token = "0x400059B")]
		NoPacking,
		[Token(Token = "0x400059C")]
		R11G11B10,
		[Token(Token = "0x400059D")]
		PackedFloat,
		[Token(Token = "0x400059E")]
		PackedUint
	}
	[Token(Token = "0x2000138")]
	public enum FieldPrecision
	{
		[Token(Token = "0x40005A0")]
		Half,
		[Token(Token = "0x40005A1")]
		Real,
		[Token(Token = "0x40005A2")]
		Default
	}
	[Token(Token = "0x2000139")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	public class GenerateHLSL : Attribute
	{
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PackingRules packingRules;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool containsPackedFields;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool needAccessors;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool needSetters;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public bool needParamDebug;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int paramDefinesStart;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool omitStructDeclaration;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool generateCBuffer;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int constantRegister;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sourcePath;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2CAA770", Offset = "0x2CA6770", VA = "0x2CAA770")]
		public GenerateHLSL(PackingRules rules = PackingRules.Exact, bool needAccessors = true, bool needSetters = false, bool needParamDebug = false, int paramDefinesStart = 1, bool omitStructDeclaration = false, bool containsPackedFields = false, bool generateCBuffer = false, int constantRegister = -1, [Optional][CallerFilePath] string sourcePath)
		{
		}
	}
	[Token(Token = "0x200013A")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SurfaceDataAttributes : Attribute
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] displayNames;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isDirection;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool sRGBDisplay;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FieldPrecision precision;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool checkIsNormalized;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string preprocessor;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2CAA800", Offset = "0x2CA6800", VA = "0x2CAA800")]
		public SurfaceDataAttributes(string displayName = "", bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = FieldPrecision.Default, bool checkIsNormalized = false, string preprocessor = "")
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2CAA8C4", Offset = "0x2CA68C4", VA = "0x2CAA8C4")]
		public SurfaceDataAttributes(string[] displayNames, bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = FieldPrecision.Default, bool checkIsNormalized = false, string preprocessor = "")
		{
		}
	}
	[Token(Token = "0x200013B")]
	[AttributeUsage(AttributeTargets.Field)]
	public class HLSLArray : Attribute
	{
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int arraySize;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type elementType;

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2CAA924", Offset = "0x2CA6924", VA = "0x2CAA924")]
		public HLSLArray(int arraySize, Type elementType)
		{
		}
	}
	[Token(Token = "0x200013C")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public class PackingAttribute : Attribute
	{
		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] displayNames;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] range;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FieldPacking packingScheme;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int offsetInSource;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int sizeInBits;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isDirection;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool sRGBDisplay;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool checkIsNormalized;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string preprocessor;

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2CAA954", Offset = "0x2CA6954", VA = "0x2CAA954")]
		public PackingAttribute(string[] displayNames, FieldPacking packingScheme = FieldPacking.NoPacking, int bitSize = 32, int offsetInSource = 0, float minValue = 0f, float maxValue = 1f, bool isDirection = false, bool sRGBDisplay = false, bool checkIsNormalized = false, string preprocessor = "")
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2CAAA4C", Offset = "0x2CA6A4C", VA = "0x2CAAA4C")]
		public PackingAttribute(string displayName = "", FieldPacking packingScheme = FieldPacking.NoPacking, int bitSize = 0, int offsetInSource = 0, float minValue = 0f, float maxValue = 1f, bool isDirection = false, bool sRGBDisplay = false, bool checkIsNormalized = false, string preprocessor = "")
		{
		}
	}
	[Token(Token = "0x200013D")]
	public struct ShaderGenUInt4
	{
	}
	[Token(Token = "0x200013E")]
	internal static class Hammersley
	{
		[Token(Token = "0x200013F")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.12\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq16
		{
			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HLSLArray(16, typeof(Vector4))]
			public unsafe fixed float hammersley2dSeq16[64];
		}

		[Token(Token = "0x2000141")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.12\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq32
		{
			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HLSLArray(32, typeof(Vector4))]
			public unsafe fixed float hammersley2dSeq32[128];
		}

		[Token(Token = "0x2000143")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.12\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq64
		{
			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HLSLArray(64, typeof(Vector4))]
			public unsafe fixed float hammersley2dSeq64[256];
		}

		[Token(Token = "0x2000145")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.12\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq256
		{
			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HLSLArray(256, typeof(Vector4))]
			public unsafe fixed float hammersley2dSeq256[1024];
		}

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float[] k_Hammersley2dSeq16;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float[] k_Hammersley2dSeq32;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float[] k_Hammersley2dSeq64;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static float[] k_Hammersley2dSeq256;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int s_hammersley2DSeq16Id;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int s_hammersley2DSeq32Id;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int s_hammersley2DSeq64Id;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly int s_hammersley2DSeq256Id;

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x2CAAB74", Offset = "0x2CA6B74", VA = "0x2CAAB74")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2CAAEE4", Offset = "0x2CA6EE4", VA = "0x2CAAEE4")]
		public static void BindConstants(CommandBuffer cmd, ComputeShader cs)
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class BufferedRTHandleSystem : IDisposable
	{
		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<int, RTHandle[]> m_RTHandles;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RTHandleSystem m_RTHandleSystem;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_DisposedValue;

		[Token(Token = "0x1700011E")]
		public int maxWidth
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x2CAB254", Offset = "0x2CA7254", VA = "0x2CAB254")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700011F")]
		public int maxHeight
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x2CAB26C", Offset = "0x2CA726C", VA = "0x2CAB26C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000120")]
		public RTHandleProperties rtHandleProperties
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x2CAB284", Offset = "0x2CA7284", VA = "0x2CAB284")]
			get
			{
				return default(RTHandleProperties);
			}
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x2CAB2A8", Offset = "0x2CA72A8", VA = "0x2CAB2A8")]
		public RTHandle GetFrameRT(int bufferId, int frameIndex)
		{
			return null;
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x2CAB360", Offset = "0x2CA7360", VA = "0x2CAB360")]
		public void AllocBuffer(int bufferId, Func<RTHandleSystem, int, RTHandle> allocator, int bufferCount)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x2CAB5EC", Offset = "0x2CA75EC", VA = "0x2CAB5EC")]
		public void ReleaseBuffer(int bufferId)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2CAB6EC", Offset = "0x2CA76EC", VA = "0x2CAB6EC")]
		public void SwapAndSetReferenceSize(int width, int height)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x2CAB9D4", Offset = "0x2CA79D4", VA = "0x2CAB9D4")]
		public void ResetReferenceSize(int width, int height)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x2CAB9FC", Offset = "0x2CA79FC", VA = "0x2CAB9FC")]
		public int GetNumFramesAllocated(int bufferId)
		{
			return default(int);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x2CABA94", Offset = "0x2CA7A94", VA = "0x2CABA94")]
		public Vector2 CalculateRatioAgainstMaxSize(int width, int height)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x2CAB728", Offset = "0x2CA7728", VA = "0x2CAB728")]
		private void Swap()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x2CABCB8", Offset = "0x2CA7CB8", VA = "0x2CABCB8")]
		private void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x2CABEC8", Offset = "0x2CA7EC8", VA = "0x2CABEC8", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2CABCFC", Offset = "0x2CA7CFC", VA = "0x2CABCFC")]
		public void ReleaseAll()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2CABED0", Offset = "0x2CA7ED0", VA = "0x2CABED0")]
		public BufferedRTHandleSystem()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public enum DepthBits
	{
		[Token(Token = "0x40005D2")]
		None = 0,
		[Token(Token = "0x40005D3")]
		Depth8 = 8,
		[Token(Token = "0x40005D4")]
		Depth16 = 16,
		[Token(Token = "0x40005D5")]
		Depth24 = 24,
		[Token(Token = "0x40005D6")]
		Depth32 = 32
	}
	[Token(Token = "0x2000149")]
	public enum MSAASamples
	{
		[Token(Token = "0x40005D8")]
		None = 1,
		[Token(Token = "0x40005D9")]
		MSAA2x = 2,
		[Token(Token = "0x40005DA")]
		MSAA4x = 4,
		[Token(Token = "0x40005DB")]
		MSAA8x = 8
	}
	[Token(Token = "0x200014A")]
	public class PowerOfTwoTextureAtlas : Texture2DAtlas
	{
		[Token(Token = "0x200014B")]
		private enum BlitType
		{
			[Token(Token = "0x40005E0")]
			Padding,
			[Token(Token = "0x40005E1")]
			PaddingMultiply,
			[Token(Token = "0x40005E2")]
			OctahedralPadding,
			[Token(Token = "0x40005E3")]
			OctahedralPaddingMultiply
		}

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly int m_MipPadding;

		[Token(Token = "0x40005DD")]
		private const float k_MipmapFactorApprox = 1.33f;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, Vector2Int> m_RequestedTextures;

		[Token(Token = "0x17000121")]
		public int mipPadding
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x2CAC110", Offset = "0x2CA8110", VA = "0x2CAC110")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x2CAC014", Offset = "0x2CA8014", VA = "0x2CAC014")]
		public PowerOfTwoTextureAtlas(int size, int mipPadding, GraphicsFormat format, FilterMode filterMode = FilterMode.Point, string name = "", bool useMipMap = true)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x2CAC118", Offset = "0x2CA8118", VA = "0x2CAC118")]
		private int GetTexturePadding()
		{
			return default(int);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x2CAC148", Offset = "0x2CA8148", VA = "0x2CAC148")]
		public Vector4 GetPayloadScaleOffset(Texture texture, in Vector4 scaleOffset)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x2CAC278", Offset = "0x2CA8278", VA = "0x2CAC278")]
		public static Vector4 GetPayloadScaleOffset(in Vector2 textureSize, in Vector2 paddingSize, in Vector4 scaleOffset)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x2CAC2B0", Offset = "0x2CA82B0", VA = "0x2CAC2B0")]
		private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x2CAC69C", Offset = "0x2CA869C", VA = "0x2CAC69C", Slot = "4")]
		public override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x2CAC7A8", Offset = "0x2CA87A8", VA = "0x2CAC7A8")]
		public void BlitTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x2CAC8B4", Offset = "0x2CA88B4", VA = "0x2CAC8B4", Slot = "5")]
		public override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x2CAC9C0", Offset = "0x2CA89C0", VA = "0x2CAC9C0")]
		public void BlitOctahedralTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x2CACACC", Offset = "0x2CA8ACC", VA = "0x2CACACC")]
		private void TextureSizeToPowerOfTwo(Texture texture, ref int width, ref int height)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x2CAC20C", Offset = "0x2CA820C", VA = "0x2CAC20C")]
		private Vector2 GetPowerOfTwoTextureSize(Texture texture)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x2CACB08", Offset = "0x2CA8B08", VA = "0x2CACB08", Slot = "7")]
		public override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x2CACCD8", Offset = "0x2CA8CD8", VA = "0x2CACCD8")]
		public void ResetRequestedTexture()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x2CACD28", Offset = "0x2CA8D28", VA = "0x2CACD28")]
		public bool ReserveSpace(Texture texture)
		{
			return default(bool);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x2CACD9C", Offset = "0x2CA8D9C", VA = "0x2CACD9C")]
		public bool ReserveSpace(Texture texture, int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x2CACEFC", Offset = "0x2CA8EFC", VA = "0x2CACEFC")]
		public bool ReserveSpace(Texture textureA, Texture textureB, int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x2CACDD4", Offset = "0x2CA8DD4", VA = "0x2CACDD4")]
		private bool ReserveSpace(int id, int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x2CACF34", Offset = "0x2CA8F34", VA = "0x2CACF34")]
		public bool RelayoutEntries()
		{
			return default(bool);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x2CAD390", Offset = "0x2CA9390", VA = "0x2CAD390")]
		public static long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, GraphicsFormat format)
		{
			return default(long);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2CAD458", Offset = "0x2CA9458", VA = "0x2CAD458")]
		public static int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, GraphicsFormat format)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014D")]
	public struct RTHandleStaticHelpers
	{
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static RTHandle s_RTHandleWrapper;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x2CAD5DC", Offset = "0x2CA95DC", VA = "0x2CAD5DC")]
		public static void SetRTHandleStaticWrapper(RenderTargetIdentifier rtId)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x2CAD740", Offset = "0x2CA9740", VA = "0x2CAD740")]
		public static void SetRTHandleUserManagedWrapper(ref RTHandle rtWrapper, RenderTargetIdentifier rtId)
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class RTHandle
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal RTHandleSystem m_Owner;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal RenderTexture m_RT;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Texture m_ExternalTexture;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal RenderTargetIdentifier m_NameID;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal bool m_EnableMSAA;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		internal bool m_EnableRandomWrite;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		internal bool m_EnableHWDynamicScale;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal string m_Name;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal bool m_UseCustomHandleScales;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		internal RTHandleProperties m_CustomHandleProperties;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal ScaleFunc scaleFunc;

		[Token(Token = "0x17000122")]
		public Vector2 scaleFactor
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x2CAD90C", Offset = "0x2CA990C", VA = "0x2CAD90C")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x2CAD914", Offset = "0x2CA9914", VA = "0x2CAD914")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public bool useScaling
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x2CAD91C", Offset = "0x2CA991C", VA = "0x2CAD91C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x2CAD924", Offset = "0x2CA9924", VA = "0x2CAD924")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public Vector2Int referenceSize
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x2CAD92C", Offset = "0x2CA992C", VA = "0x2CAD92C")]
			[CompilerGenerated]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x2CAD934", Offset = "0x2CA9934", VA = "0x2CAD934")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public RTHandleProperties rtHandleProperties
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x2CAD93C", Offset = "0x2CA993C", VA = "0x2CAD93C")]
			get
			{
				return default(RTHandleProperties);
			}
		}

		[Token(Token = "0x17000126")]
		public RenderTexture rt
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x2CAD978", Offset = "0x2CA9978", VA = "0x2CAD978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000127")]
		public RenderTargetIdentifier nameID
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x2CAD980", Offset = "0x2CA9980", VA = "0x2CAD980")]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Token(Token = "0x17000128")]
		public string name
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x2CAD998", Offset = "0x2CA9998", VA = "0x2CAD998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000129")]
		public bool isMSAAEnabled
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x2CAD9A0", Offset = "0x2CA99A0", VA = "0x2CAD9A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x2CAD8E4", Offset = "0x2CA98E4", VA = "0x2CAD8E4")]
		public void SetCustomHandleProperties(in RTHandleProperties properties)
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x2CAD904", Offset = "0x2CA9904", VA = "0x2CAD904")]
		public void ClearCustomHandleProperties()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x2CAD9A8", Offset = "0x2CA99A8", VA = "0x2CAD9A8")]
		internal RTHandle(RTHandleSystem owner)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x2CA73F0", Offset = "0x2CA33F0", VA = "0x2CA73F0")]
		public static implicit operator RenderTargetIdentifier(RTHandle handle)
		{
			return default(RenderTargetIdentifier);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x2CAD9D0", Offset = "0x2CA99D0", VA = "0x2CAD9D0")]
		public static implicit operator Texture(RTHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x2CADA54", Offset = "0x2CA9A54", VA = "0x2CADA54")]
		public static implicit operator RenderTexture(RTHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2CADA60", Offset = "0x2CA9A60", VA = "0x2CADA60")]
		internal void SetRenderTexture(RenderTexture rt)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x2CADAA8", Offset = "0x2CA9AA8", VA = "0x2CADAA8")]
		internal void SetTexture(Texture tex)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x2CAD724", Offset = "0x2CA9724", VA = "0x2CAD724")]
		internal void SetTexture(RenderTargetIdentifier tex)
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2CADAF0", Offset = "0x2CA9AF0", VA = "0x2CADAF0")]
		public int GetInstanceID()
		{
			return default(int);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2CADBAC", Offset = "0x2CA9BAC", VA = "0x2CADBAC")]
		public void Release()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2CADCB0", Offset = "0x2CA9CB0", VA = "0x2CADCB0")]
		public Vector2Int GetScaledSize(Vector2Int refSize)
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2CADEA4", Offset = "0x2CA9EA4", VA = "0x2CADEA4")]
		public Vector2Int GetScaledSize()
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2CAE098", Offset = "0x2CAA098", VA = "0x2CAE098")]
		public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1f, FastMemoryFlags flags = FastMemoryFlags.SpillTop, bool copyContents = false)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2CAE120", Offset = "0x2CAA120", VA = "0x2CAE120")]
		public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1f, FastMemoryFlags flags = FastMemoryFlags.SpillTop)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2CAE128", Offset = "0x2CAA128", VA = "0x2CAE128")]
		public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = true)
		{
		}
	}
	[Token(Token = "0x200014F")]
	public static class RTHandles
	{
		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RTHandleSystem s_DefaultInstance;

		[Token(Token = "0x1700012A")]
		public static int maxWidth
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x2CAE184", Offset = "0x2CAA184", VA = "0x2CAE184")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012B")]
		public static int maxHeight
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x2CAE1E8", Offset = "0x2CAA1E8", VA = "0x2CAE1E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012C")]
		public static RTHandleProperties rtHandleProperties
		{
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x2CAE24C", Offset = "0x2CAA24C", VA = "0x2CAE24C")]
			get
			{
				return default(RTHandleProperties);
			}
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2CA4718", Offset = "0x2CA0718", VA = "0x2CA4718")]
		public static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x2CAE368", Offset = "0x2CAA368", VA = "0x2CAE368")]
		public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x2CAEA54", Offset = "0x2CAAA54", VA = "0x2CAEA54")]
		public static RTHandle Alloc(in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return null;
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x2CAECB4", Offset = "0x2CAACB4", VA = "0x2CAECB4")]
		public static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			return null;
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x2CAF0B8", Offset = "0x2CAB0B8", VA = "0x2CAF0B8")]
		public static RTHandle Alloc(Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return null;
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2CAF304", Offset = "0x2CAB304", VA = "0x2CAF304")]
		public static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			return null;
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2CAF58C", Offset = "0x2CAB58C", VA = "0x2CAF58C")]
		public static RTHandle Alloc(ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2CAF7CC", Offset = "0x2CAB7CC", VA = "0x2CAF7CC")]
		public static RTHandle Alloc(Texture tex)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x2CAF900", Offset = "0x2CAB900", VA = "0x2CAF900")]
		public static RTHandle Alloc(RenderTexture tex)
		{
			return null;
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2CAD6A0", Offset = "0x2CA96A0", VA = "0x2CAD6A0")]
		public static RTHandle Alloc(RenderTargetIdentifier tex)
		{
			return null;
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x2CAFAA8", Offset = "0x2CABAA8", VA = "0x2CAFAA8")]
		public static RTHandle Alloc(RenderTargetIdentifier tex, string name)
		{
			return null;
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2CAFBE0", Offset = "0x2CABBE0", VA = "0x2CAFBE0")]
		private static RTHandle Alloc(RTHandle tex)
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x2CAFC50", Offset = "0x2CABC50", VA = "0x2CAFC50")]
		public static void Initialize(int width, int height)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2CAFF48", Offset = "0x2CABF48", VA = "0x2CAFF48")]
		[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead.")]
		public static void Initialize(int width, int height, bool useLegacyDynamicResControl = false)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x2CA4930", Offset = "0x2CA0930", VA = "0x2CA4930")]
		public static void Release(RTHandle rth)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x2CB0004", Offset = "0x2CAC004", VA = "0x2CB0004")]
		public static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested)
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x2CB01DC", Offset = "0x2CAC1DC", VA = "0x2CB01DC")]
		public static void SetReferenceSize(int width, int height)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x2CB0258", Offset = "0x2CAC258", VA = "0x2CB0258")]
		public static void ResetReferenceSize(int width, int height)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2CB02D8", Offset = "0x2CAC2D8", VA = "0x2CB02D8")]
		public static Vector2 CalculateRatioAgainstMaxSize(int width, int height)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x2000150")]
	public delegate Vector2Int ScaleFunc(Vector2Int size);
	[Token(Token = "0x2000151")]
	public struct RTHandleProperties
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector2Int previousViewportSize;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2Int previousRenderTargetSize;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2Int currentViewportSize;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2Int currentRenderTargetSize;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector4 rtHandleScale;
	}
	[Token(Token = "0x2000152")]
	public class RTHandleSystem : IDisposable
	{
		[Token(Token = "0x2000153")]
		internal enum ResizeMode
		{
			[Token(Token = "0x4000603")]
			Auto,
			[Token(Token = "0x4000604")]
			OnDemand
		}

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_HardwareDynamicResRequested;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HashSet<RTHandle> m_AutoSizedRTs;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RTHandle[] m_AutoSizedRTsArray;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<RTHandle> m_ResizeOnDemandRTs;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RTHandleProperties m_RTHandleProperties;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_MaxWidths;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_MaxHeights;

		[Token(Token = "0x1700012D")]
		public RTHandleProperties rtHandleProperties
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x2CB0514", Offset = "0x2CAC514", VA = "0x2CB0514")]
			get
			{
				return default(RTHandleProperties);
			}
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x2CABF74", Offset = "0x2CA7F74", VA = "0x2CABF74")]
		public RTHandleSystem()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x2CABEC0", Offset = "0x2CA7EC0", VA = "0x2CABEC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2CAFCC8", Offset = "0x2CABCC8", VA = "0x2CAFCC8")]
		public void Initialize(int width, int height)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2CAFFD8", Offset = "0x2CABFD8", VA = "0x2CAFFD8")]
		[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead.")]
		public void Initialize(int width, int height, bool useLegacyDynamicResControl = false)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x2CAB6DC", Offset = "0x2CA76DC", VA = "0x2CAB6DC")]
		public void Release(RTHandle rth)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x2CADC58", Offset = "0x2CA9C58", VA = "0x2CADC58")]
		internal void Remove(RTHandle rth)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x2CAB9F0", Offset = "0x2CA79F0", VA = "0x2CAB9F0")]
		public void ResetReferenceSize(int width, int height)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x2CAB9CC", Offset = "0x2CA79CC", VA = "0x2CAB9CC")]
		public void SetReferenceSize(int width, int height)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x2CB06C8", Offset = "0x2CAC6C8", VA = "0x2CB06C8")]
		public void SetReferenceSize(int width, int height, bool reset)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x2CABABC", Offset = "0x2CA7ABC", VA = "0x2CABABC")]
		internal Vector2 CalculateRatioAgainstMaxSize(in Vector2Int viewportSize)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2CB006C", Offset = "0x2CAC06C", VA = "0x2CB006C")]
		public void SetHardwareDynamicResolutionState(bool enableHWDynamicRes)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x2CAB4D8", Offset = "0x2CA74D8", VA = "0x2CAB4D8")]
		internal void SwitchResizeMode(RTHandle rth, ResizeMode mode)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x2CB0B20", Offset = "0x2CACB20", VA = "0x2CB0B20")]
		private void DemandResize(RTHandle rth)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x2CB0D70", Offset = "0x2CACD70", VA = "0x2CB0D70")]
		public int GetMaxWidth()
		{
			return default(int);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x2CB0D78", Offset = "0x2CACD78", VA = "0x2CB0D78")]
		public int GetMaxHeight()
		{
			return default(int);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x2CB0528", Offset = "0x2CAC528", VA = "0x2CB0528")]
		private void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x2CB0850", Offset = "0x2CAC850", VA = "0x2CB0850")]
		private void Resize(int width, int height, bool sizeChanged)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2CAE2C0", Offset = "0x2CAA2C0", VA = "0x2CAE2C0")]
		public RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x2CAE4C4", Offset = "0x2CAA4C4", VA = "0x2CAE4C4")]
		public RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			return null;
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x2CAEE04", Offset = "0x2CAAE04", VA = "0x2CAEE04")]
		public RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x2CAF448", Offset = "0x2CAB448", VA = "0x2CAF448")]
		public RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
		{
			return null;
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2CB0D80", Offset = "0x2CACD80", VA = "0x2CB0D80")]
		private RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, DepthBits depthBufferBits, GraphicsFormat colorFormat, FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, RenderTextureMemoryless memoryless, VRTextureUsage vrUsage, string name)
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x2CAF968", Offset = "0x2CAB968", VA = "0x2CAF968")]
		public RTHandle Alloc(RenderTexture texture)
		{
			return null;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x2CAF834", Offset = "0x2CAB834", VA = "0x2CAF834")]
		public RTHandle Alloc(Texture texture)
		{
			return null;
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2CAFA34", Offset = "0x2CABA34", VA = "0x2CAFA34")]
		public RTHandle Alloc(RenderTargetIdentifier texture)
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x2CAFB3C", Offset = "0x2CABB3C", VA = "0x2CAFB3C")]
		public RTHandle Alloc(RenderTargetIdentifier texture, string name)
		{
			return null;
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x2CB12AC", Offset = "0x2CAD2AC", VA = "0x2CB12AC")]
		private static RTHandle Alloc(RTHandle tex)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x2CB131C", Offset = "0x2CAD31C", VA = "0x2CB131C")]
		internal string DumpRTInfo()
		{
			return null;
		}
	}
	[Token(Token = "0x2000154")]
	internal class AtlasAllocator
	{
		[Token(Token = "0x2000155")]
		private class AtlasNode
		{
			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AtlasNode m_RightChild;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AtlasNode m_BottomChild;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector4 m_Rect;

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x2CB189C", Offset = "0x2CAD89C", VA = "0x2CB189C")]
			public AtlasNode Allocate(ref ObjectPool<AtlasNode> pool, int width, int height, bool powerOfTwoPadding)
			{
				return null;
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x2CB1AB4", Offset = "0x2CADAB4", VA = "0x2CB1AB4")]
			public void Release(ref ObjectPool<AtlasNode> pool)
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x2CB180C", Offset = "0x2CAD80C", VA = "0x2CB180C")]
			public AtlasNode()
			{
			}
		}

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AtlasNode m_Root;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_Width;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_Height;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool powerOfTwoPadding;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ObjectPool<AtlasNode> m_NodePool;

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x2CB1610", Offset = "0x2CAD610", VA = "0x2CB1610")]
		public AtlasAllocator(int width, int height, bool potPadding)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x2CB1818", Offset = "0x2CAD818", VA = "0x2CB1818")]
		public bool Allocate(ref Vector4 result, int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2CB1A78", Offset = "0x2CADA78", VA = "0x2CB1A78")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class Texture2DAtlas
	{
		[Token(Token = "0x2000158")]
		private enum BlitType
		{
			[Token(Token = "0x4000620")]
			Default,
			[Token(Token = "0x4000621")]
			CubeTo2DOctahedral,
			[Token(Token = "0x4000622")]
			SingleChannel,
			[Token(Token = "0x4000623")]
			CubeTo2DOctahedralSingleChannel
		}

		[Token(Token = "0x4000610")]
		private protected const int kGPUTexInvalid = 0;

		[Token(Token = "0x4000611")]
		private protected const int kGPUTexValidMip0 = 1;

		[Token(Token = "0x4000612")]
		private protected const int kGPUTexValidMipAll = 2;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private protected RTHandle m_AtlasTexture;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private protected int m_Width;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private protected int m_Height;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private protected GraphicsFormat m_Format;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private protected bool m_UseMipMaps;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool m_IsAtlasTextureOwner;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AtlasAllocator m_AtlasAllocator;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<int, (Vector4 scaleOffset, Vector2Int size)> m_AllocationCache;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, int> m_IsGPUTextureUpToDate;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<int, int> m_TextureHashes;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector4 fullScaleOffset;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int s_MaxMipLevelPadding;

		[Token(Token = "0x1700012E")]
		public static int maxMipLevelPadding
		{
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x2CB1BF8", Offset = "0x2CADBF8", VA = "0x2CB1BF8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012F")]
		public RTHandle AtlasTexture
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x2CB1C50", Offset = "0x2CADC50", VA = "0x2CB1C50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2CB1C58", Offset = "0x2CADC58", VA = "0x2CB1C58")]
		public Texture2DAtlas(int width, int height, GraphicsFormat format, FilterMode filterMode = FilterMode.Point, bool powerOfTwoPadding = false, string name = "", bool useMipMap = true)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x2CB1FA4", Offset = "0x2CADFA4", VA = "0x2CB1FA4")]
		public void Release()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x2CB201C", Offset = "0x2CAE01C", VA = "0x2CB201C")]
		public void ResetAllocator()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2CB209C", Offset = "0x2CAE09C", VA = "0x2CB209C")]
		public void ClearTarget(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2CB1ED0", Offset = "0x2CADED0", VA = "0x2CB1ED0")]
		private protected int GetTextureMipmapCount(int width, int height)
		{
			return default(int);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2CB2408", Offset = "0x2CAE408", VA = "0x2CB2408")]
		private protected bool Is2D(Texture texture)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x2CB24D4", Offset = "0x2CAE4D4", VA = "0x2CB24D4")]
		private protected bool IsSingleChannelBlit(Texture source, Texture destination)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x2CB271C", Offset = "0x2CAE71C", VA = "0x2CB271C")]
		private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2CB3008", Offset = "0x2CAF008", VA = "0x2CB3008")]
		private protected void MarkGPUTextureValid(int instanceId, bool mipAreValid = false)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2CB3078", Offset = "0x2CAF078", VA = "0x2CB3078")]
		private protected void MarkGPUTextureInvalid(int instanceId)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x2CB30D4", Offset = "0x2CAF0D4", VA = "0x2CB30D4", Slot = "4")]
		public virtual void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2CB33EC", Offset = "0x2CAF3EC", VA = "0x2CB33EC", Slot = "5")]
		public virtual void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2CB33F8", Offset = "0x2CAF3F8", VA = "0x2CB33F8", Slot = "6")]
		public virtual void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = true, int overrideInstanceID = -1)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x2CB3574", Offset = "0x2CAF574", VA = "0x2CB3574", Slot = "7")]
		public virtual bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2CB3744", Offset = "0x2CAF744", VA = "0x2CB3744")]
		public bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x2CB37A0", Offset = "0x2CAF7A0", VA = "0x2CB37A0", Slot = "8")]
		public virtual bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2CB3928", Offset = "0x2CAF928", VA = "0x2CB3928")]
		private protected int GetTextureHash(Texture textureA, Texture textureB)
		{
			return default(int);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2CB326C", Offset = "0x2CAF26C", VA = "0x2CB326C")]
		public int GetTextureID(Texture texture)
		{
			return default(int);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2CB39A0", Offset = "0x2CAF9A0", VA = "0x2CB39A0")]
		public int GetTextureID(Texture textureA, Texture textureB)
		{
			return default(int);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2CB39E8", Offset = "0x2CAF9E8", VA = "0x2CB39E8")]
		public bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2CB3AA4", Offset = "0x2CAFAA4", VA = "0x2CB3AA4")]
		public bool IsCached(out Vector4 scaleOffset, Texture texture)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x2CB3A1C", Offset = "0x2CAFA1C", VA = "0x2CB3A1C")]
		public bool IsCached(out Vector4 scaleOffset, int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x2CB3AE0", Offset = "0x2CAFAE0", VA = "0x2CB3AE0")]
		internal Vector2Int GetCachedTextureSize(int id)
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x2CB3B54", Offset = "0x2CAFB54", VA = "0x2CB3B54", Slot = "9")]
		public virtual bool NeedsUpdate(Texture texture, bool needMips = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x2CB3DC4", Offset = "0x2CAFDC4", VA = "0x2CB3DC4", Slot = "10")]
		public virtual bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x2CB41D0", Offset = "0x2CB01D0", VA = "0x2CB41D0", Slot = "11")]
		public virtual bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x2CB4270", Offset = "0x2CB0270", VA = "0x2CB4270", Slot = "12")]
		public virtual bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = true, bool blitMips = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x2CB43EC", Offset = "0x2CB03EC", VA = "0x2CB43EC", Slot = "13")]
		public virtual bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = true, bool blitMips = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x2CB449C", Offset = "0x2CB049C", VA = "0x2CB449C")]
		internal bool EnsureTextureSlot(out bool isUploadNeeded, ref Vector4 scaleBias, int key, int width, int height)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000159")]
	internal class AtlasAllocatorDynamic
	{
		[Token(Token = "0x200015A")]
		private class AtlasNodePool
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal AtlasNode[] m_Nodes;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private short m_Next;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			private short m_FreelistHead;

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x2CB4784", Offset = "0x2CB0784", VA = "0x2CB4784")]
			public AtlasNodePool(short capacity)
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x2CB54D4", Offset = "0x2CB14D4", VA = "0x2CB54D4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x2CB506C", Offset = "0x2CB106C", VA = "0x2CB506C")]
			public void Clear()
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x2CB47F4", Offset = "0x2CB07F4", VA = "0x2CB47F4")]
			public short AtlasNodeCreate(short parent)
			{
				return default(short);
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x2CB5544", Offset = "0x2CB1544", VA = "0x2CB5544")]
			public void AtlasNodeFree(short index)
			{
			}
		}

		[StructLayout(2)]
		[Token(Token = "0x200015B")]
		private struct AtlasNode
		{
			[Token(Token = "0x200015C")]
			private enum AtlasNodeFlags : uint
			{
				[Token(Token = "0x4000634")]
				IsOccupied = 1u
			}

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public short m_Self;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public short m_Parent;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public short m_LeftChild;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public short m_RightChild;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public short m_FreelistNext;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public ushort m_Flags;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector4 m_Rect;

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x2CB54E4", Offset = "0x2CB14E4", VA = "0x2CB54E4")]
			public AtlasNode(short self, short parent)
			{
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x2CB54C8", Offset = "0x2CB14C8", VA = "0x2CB54C8")]
			public bool IsOccupied()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x2CB5580", Offset = "0x2CB1580", VA = "0x2CB5580")]
			public void SetIsOccupied()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x2CB5590", Offset = "0x2CB1590", VA = "0x2CB5590")]
			public void ClearIsOccupied()
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x2CB55A0", Offset = "0x2CB15A0", VA = "0x2CB55A0")]
			public bool IsLeafNode()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x2CB4A64", Offset = "0x2CB0A64", VA = "0x2CB4A64")]
			public short Allocate(AtlasNodePool pool, int width, int height)
			{
				return default(short);
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x2CB55B0", Offset = "0x2CB15B0", VA = "0x2CB55B0")]
			public void ReleaseChildren(AtlasNodePool pool)
			{
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x2CB4F0C", Offset = "0x2CB0F0C", VA = "0x2CB4F0C")]
			public void ReleaseAndMerge(AtlasNodePool pool)
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x2CB5658", Offset = "0x2CB1658", VA = "0x2CB5658")]
			public bool IsMergeNeeded(AtlasNodePool pool)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_Width;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_Height;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AtlasNodePool m_Pool;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private short m_Root;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<int, short> m_NodeFromID;

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x2CB4664", Offset = "0x2CB0664", VA = "0x2CB4664")]
		public AtlasAllocatorDynamic(int width, int height, int capacityAllocations)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x2CB4934", Offset = "0x2CB0934", VA = "0x2CB4934")]
		public bool Allocate(out Vector4 result, int key, int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x2CB4E40", Offset = "0x2CB0E40", VA = "0x2CB4E40")]
		public void Release(int key)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x2CB4FC8", Offset = "0x2CB0FC8", VA = "0x2CB4FC8")]
		public void Release()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x2CB5078", Offset = "0x2CB1078", VA = "0x2CB5078")]
		public string DebugStringFromRoot(int depthMax = -1)
		{
			return null;
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x2CB50E8", Offset = "0x2CB10E8", VA = "0x2CB50E8")]
		private void DebugStringFromNode(ref string res, short n, int depthCurrent = 0, int depthMax = -1)
		{
		}
	}
	[Token(Token = "0x200015D")]
	internal class Texture2DAtlasDynamic
	{
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RTHandle m_AtlasTexture;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isAtlasTextureOwner;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_Width;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Height;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private GraphicsFormat m_Format;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AtlasAllocatorDynamic m_AtlasAllocator;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<int, Vector4> m_AllocationCache;

		[Token(Token = "0x17000130")]
		public RTHandle AtlasTexture
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x2CB56DC", Offset = "0x2CB16DC", VA = "0x2CB56DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x2CB56E4", Offset = "0x2CB16E4", VA = "0x2CB56E4")]
		public Texture2DAtlasDynamic(int width, int height, int capacity, GraphicsFormat format)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x2CB5874", Offset = "0x2CB1874", VA = "0x2CB5874")]
		public Texture2DAtlasDynamic(int width, int height, int capacity, RTHandle atlasTexture)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x2CB5978", Offset = "0x2CB1978", VA = "0x2CB5978")]
		public void Release()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x2CB59F0", Offset = "0x2CB19F0", VA = "0x2CB59F0")]
		public void ResetAllocator()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x2CB5A4C", Offset = "0x2CB1A4C", VA = "0x2CB5A4C")]
		public bool AddTexture(CommandBuffer cmd, out Vector4 scaleOffset, Texture texture)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x2CB5C90", Offset = "0x2CB1C90", VA = "0x2CB5C90")]
		public bool IsCached(out Vector4 scaleOffset, int key)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x2CB5CF8", Offset = "0x2CB1CF8", VA = "0x2CB5CF8")]
		public bool EnsureTextureSlot(out bool isUploadNeeded, out Vector4 scaleOffset, int key, int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x2CB5E08", Offset = "0x2CB1E08", VA = "0x2CB5E08")]
		public void ReleaseTextureSlot(int key)
		{
		}
	}
	[Token(Token = "0x200015E")]
	public static class TextureXR
	{
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int m_MaxViews;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture m_BlackUIntTexture2DArray;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Texture m_BlackUIntTexture;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static RTHandle m_BlackUIntTexture2DArrayRTH;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static RTHandle m_BlackUIntTextureRTH;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Texture2DArray m_ClearTexture2DArray;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Texture2D m_ClearTexture;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static RTHandle m_ClearTexture2DArrayRTH;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static RTHandle m_ClearTextureRTH;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Texture2DArray m_MagentaTexture2DArray;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Texture2D m_MagentaTexture;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static RTHandle m_MagentaTexture2DArrayRTH;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static RTHandle m_MagentaTextureRTH;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static Texture2D m_BlackTexture;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static Texture3D m_BlackTexture3D;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static Texture2DArray m_BlackTexture2DArray;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static RTHandle m_BlackTexture2DArrayRTH;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static RTHandle m_BlackTextureRTH;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static RTHandle m_BlackTexture3DRTH;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static Texture2DArray m_WhiteTexture2DArray;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static RTHandle m_WhiteTexture2DArrayRTH;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static RTHandle m_WhiteTextureRTH;

		[Token(Token = "0x17000131")]
		public static int maxViews
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x2CB5E70", Offset = "0x2CB1E70", VA = "0x2CB5E70")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public static int slices
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x2CB5ECC", Offset = "0x2CB1ECC", VA = "0x2CB5ECC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000133")]
		public static bool useTexArray
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x2CB5F24", Offset = "0x2CB1F24", VA = "0x2CB5F24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000134")]
		public static TextureDimension dimension
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x2CB5F8C", Offset = "0x2CB1F8C", VA = "0x2CB5F8C")]
			get
			{
				return default(TextureDimension);
			}
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x2CB5FEC", Offset = "0x2CB1FEC", VA = "0x2CB5FEC")]
		public static RTHandle GetBlackUIntTexture()
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x2CB6070", Offset = "0x2CB2070", VA = "0x2CB6070")]
		public static RTHandle GetClearTexture()
		{
			return null;
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x2CB60F4", Offset = "0x2CB20F4", VA = "0x2CB60F4")]
		public static RTHandle GetMagentaTexture()
		{
			return null;
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2CB6178", Offset = "0x2CB2178", VA = "0x2CB6178")]
		public static RTHandle GetBlackTexture()
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2CB61FC", Offset = "0x2CB21FC", VA = "0x2CB61FC")]
		public static RTHandle GetBlackTextureArray()
		{
			return null;
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x2CB6254", Offset = "0x2CB2254", VA = "0x2CB6254")]
		public static RTHandle GetBlackTexture3D()
		{
			return null;
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x2CB62AC", Offset = "0x2CB22AC", VA = "0x2CB62AC")]
		public static RTHandle GetWhiteTexture()
		{
			return null;
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x2CB6330", Offset = "0x2CB2330", VA = "0x2CB6330")]
		public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x2CB6CB4", Offset = "0x2CB2CB4", VA = "0x2CB6CB4")]
		private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name)
		{
			return null;
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x2CB68C4", Offset = "0x2CB28C4", VA = "0x2CB68C4")]
		private static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
		{
			return null;
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x2CB6B08", Offset = "0x2CB2B08", VA = "0x2CB6B08")]
		private static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
		{
			return null;
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x2CB6E94", Offset = "0x2CB2E94", VA = "0x2CB6E94")]
		private static Texture3D CreateBlackTexture3D(string name)
		{
			return null;
		}
	}
	[Token(Token = "0x200015F")]
	public static class ArrayExtensions
	{
		[Token(Token = "0x60007FE")]
		public static void ResizeArray<T>(this ref NativeArray<T> array, int capacity) where T : struct
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x2CB6FA0", Offset = "0x2CB2FA0", VA = "0x2CB6FA0")]
		public static void ResizeArray(this ref TransformAccessArray array, int capacity)
		{
		}

		[Token(Token = "0x6000800")]
		public static void ResizeArray<T>(ref T[] array, int capacity)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000160")]
	public struct SHCoefficients : IEquatable<SHCoefficients>
	{
		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4 SHAr;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector4 SHAg;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector4 SHAb;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector4 SHBr;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector4 SHBg;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector4 SHBb;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector4 SHC;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector4 ProbesOcclusion;

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x2CB7040", Offset = "0x2CB3040", VA = "0x2CB7040")]
		public SHCoefficients(SphericalHarmonicsL2 sh)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x2CB733C", Offset = "0x2CB333C", VA = "0x2CB733C")]
		public SHCoefficients(SphericalHarmonicsL2 sh, Vector4 probesOcclusion)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x2CB7198", Offset = "0x2CB3198", VA = "0x2CB7198")]
		private static Vector4 GetSHA(SphericalHarmonicsL2 sh, int i)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x2CB7240", Offset = "0x2CB3240", VA = "0x2CB7240")]
		private static Vector4 GetSHB(SphericalHarmonicsL2 sh, int i)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x2CB72D4", Offset = "0x2CB32D4", VA = "0x2CB72D4")]
		private static Vector4 GetSHC(SphericalHarmonicsL2 sh)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x2CB7394", Offset = "0x2CB3394", VA = "0x2CB7394", Slot = "4")]
		public bool Equals(SHCoefficients other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x2CB75A0", Offset = "0x2CB35A0", VA = "0x2CB75A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x2CB7630", Offset = "0x2CB3630", VA = "0x2CB7630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x2CB77A4", Offset = "0x2CB37A4", VA = "0x2CB77A4")]
		public static bool operator ==(SHCoefficients left, SHCoefficients right)
		{
			return default(bool);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x2CB77D8", Offset = "0x2CB37D8", VA = "0x2CB77D8")]
		public static bool operator !=(SHCoefficients left, SHCoefficients right)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000161")]
	[Obsolete("BatchRendererGroupGlobals and associated cbuffer are now set automatically by Unity. Setting it manually is no longer necessary or supported.")]
	public struct BatchRendererGroupGlobals : IEquatable<BatchRendererGroupGlobals>
	{
		[Token(Token = "0x400065A")]
		public const string kGlobalsPropertyName = "unity_DOTSInstanceGlobalValues";

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int kGlobalsPropertyId;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4 ProbesOcclusion;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector4 SpecCube0_HDR;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector4 SpecCube1_HDR;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SHCoefficients SHCoefficients;

		[Token(Token = "0x17000135")]
		public static BatchRendererGroupGlobals Default
		{
			[Token(Token = "0x600080B")]
			[Address(RVA = "0x2CB7810", Offset = "0x2CB3810", VA = "0x2CB7810")]
			get
			{
				return default(BatchRendererGroupGlobals);
			}
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x2CB7938", Offset = "0x2CB3938", VA = "0x2CB7938", Slot = "4")]
		public bool Equals(BatchRendererGroupGlobals other)
		{
			return default(bool);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x2CB7A58", Offset = "0x2CB3A58", VA = "0x2CB7A58", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x2CB7AF8", Offset = "0x2CB3AF8", VA = "0x2CB7AF8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x2CB7C08", Offset = "0x2CB3C08", VA = "0x2CB7C08")]
		public static bool operator ==(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x2CB7C8C", Offset = "0x2CB3C8C", VA = "0x2CB7C8C")]
		public static bool operator !=(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000162")]
	public interface IBitArray
	{
		[Token(Token = "0x17000136")]
		uint capacity
		{
			[Token(Token = "0x6000812")]
			get;
		}

		[Token(Token = "0x17000137")]
		bool allFalse
		{
			[Token(Token = "0x6000813")]
			get;
		}

		[Token(Token = "0x17000138")]
		bool allTrue
		{
			[Token(Token = "0x6000814")]
			get;
		}

		[Token(Token = "0x17000139")]
		bool this[uint index]
		{
			[Token(Token = "0x6000815")]
			get;
			[Token(Token = "0x6000816")]
			set;
		}

		[Token(Token = "0x1700013A")]
		string humanizedData
		{
			[Token(Token = "0x6000817")]
			get;
		}

		[Token(Token = "0x6000818")]
		IBitArray BitAnd(IBitArray other);

		[Token(Token = "0x6000819")]
		IBitArray BitOr(IBitArray other);

		[Token(Token = "0x600081A")]
		IBitArray BitNot();
	}
	[Serializable]
	[Token(Token = "0x2000163")]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray8 : IBitArray
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private byte data;

		[Token(Token = "0x1700013B")]
		public uint capacity
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x2CB7D7C", Offset = "0x2CB3D7C", VA = "0x2CB7D7C", Slot = "4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700013C")]
		public bool allFalse
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x2CB7D84", Offset = "0x2CB3D84", VA = "0x2CB7D84", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013D")]
		public bool allTrue
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x2CB7D94", Offset = "0x2CB3D94", VA = "0x2CB7D94", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013E")]
		public string humanizedData
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x2CB7DA4", Offset = "0x2CB3DA4", VA = "0x2CB7DA4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013F")]
		public bool this[uint index]
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x2CB7E9C", Offset = "0x2CB3E9C", VA = "0x2CB7E9C", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x2CB7EBC", Offset = "0x2CB3EBC", VA = "0x2CB7EBC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2CB7F04", Offset = "0x2CB3F04", VA = "0x2CB7F04")]
		public BitArray8(byte initValue)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x2CB7F0C", Offset = "0x2CB3F0C", VA = "0x2CB7F0C")]
		public BitArray8(IEnumerable<uint> bitIndexTrue)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x2CB7FC4", Offset = "0x2CB3FC4", VA = "0x2CB7FC4")]
		public static BitArray8 operator ~(BitArray8 a)
		{
			return default(BitArray8);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x2CB7FCC", Offset = "0x2CB3FCC", VA = "0x2CB7FCC")]
		public static BitArray8 operator |(BitArray8 a, BitArray8 b)
		{
			return default(BitArray8);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x2CB7FD4", Offset = "0x2CB3FD4", VA = "0x2CB7FD4")]
		public static BitArray8 operator &(BitArray8 a, BitArray8 b)
		{
			return default(BitArray8);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x2CB7FDC", Offset = "0x2CB3FDC", VA = "0x2CB7FDC", Slot = "10")]
		public IBitArray BitAnd(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x2CB8078", Offset = "0x2CB4078", VA = "0x2CB8078", Slot = "11")]
		public IBitArray BitOr(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2CB8114", Offset = "0x2CB4114", VA = "0x2CB8114", Slot = "12")]
		public IBitArray BitNot()
		{
			return null;
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x2CB8174", Offset = "0x2CB4174", VA = "0x2CB8174")]
		public static bool operator ==(BitArray8 a, BitArray8 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x2CB8184", Offset = "0x2CB4184", VA = "0x2CB8184")]
		public static bool operator !=(BitArray8 a, BitArray8 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2CB8194", Offset = "0x2CB4194", VA = "0x2CB8194", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x2CB820C", Offset = "0x2CB420C", VA = "0x2CB820C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000164")]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray16 : IBitArray
	{
		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ushort data;

		[Token(Token = "0x17000140")]
		public uint capacity
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x2CB822C", Offset = "0x2CB422C", VA = "0x2CB822C", Slot = "4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000141")]
		public bool allFalse
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x2CB8234", Offset = "0x2CB4234", VA = "0x2CB8234", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000142")]
		public bool allTrue
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x2CB8244", Offset = "0x2CB4244", VA = "0x2CB8244", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000143")]
		public string humanizedData
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x2CB8254", Offset = "0x2CB4254", VA = "0x2CB8254", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000144")]
		public bool this[uint index]
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x2CB83C4", Offset = "0x2CB43C4", VA = "0x2CB83C4", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x2CB83E4", Offset = "0x2CB43E4", VA = "0x2CB83E4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x2CB842C", Offset = "0x2CB442C", VA = "0x2CB842C")]
		public BitArray16(ushort initValue)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2CB8434", Offset = "0x2CB4434", VA = "0x2CB8434")]
		public BitArray16(IEnumerable<uint> bitIndexTrue)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x2CB84EC", Offset = "0x2CB44EC", VA = "0x2CB84EC")]
		public static BitArray16 operator ~(BitArray16 a)
		{
			return default(BitArray16);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x2CB84F4", Offset = "0x2CB44F4", VA = "0x2CB84F4")]
		public static BitArray16 operator |(BitArray16 a, BitArray16 b)
		{
			return default(BitArray16);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x2CB84FC", Offset = "0x2CB44FC", VA = "0x2CB84FC")]
		public static BitArray16 operator &(BitArray16 a, BitArray16 b)
		{
			return default(BitArray16);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x2CB8504", Offset = "0x2CB4504", VA = "0x2CB8504", Slot = "10")]
		public IBitArray BitAnd(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x2CB85A0", Offset = "0x2CB45A0", VA = "0x2CB85A0", Slot = "11")]
		public IBitArray BitOr(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x2CB863C", Offset = "0x2CB463C", VA = "0x2CB863C", Slot = "12")]
		public IBitArray BitNot()
		{
			return null;
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x2CB869C", Offset = "0x2CB469C", VA = "0x2CB869C")]
		public static bool operator ==(BitArray16 a, BitArray16 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x2CB86AC", Offset = "0x2CB46AC", VA = "0x2CB86AC")]
		public static bool operator !=(BitArray16 a, BitArray16 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x2CB86BC", Offset = "0x2CB46BC", VA = "0x2CB86BC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x2CB8734", Offset = "0x2CB4734", VA = "0x2CB8734", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000165")]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray32 : IBitArray
	{
		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private uint data;

		[Token(Token = "0x17000145")]
		public uint capacity
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x2CB8754", Offset = "0x2CB4754", VA = "0x2CB8754", Slot = "4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000146")]
		public bool allFalse
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x2CB875C", Offset = "0x2CB475C", VA = "0x2CB875C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000147")]
		public bool allTrue
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x2CB876C", Offset = "0x2CB476C", VA = "0x2CB876C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000148")]
		private string humanizedVersion
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x2CB877C", Offset = "0x2CB477C", VA = "0x2CB877C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000149")]
		public string humanizedData
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x2CB87DC", Offset = "0x2CB47DC", VA = "0x2CB87DC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014A")]
		public bool this[uint index]
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x2CB894C", Offset = "0x2CB494C", VA = "0x2CB894C", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x2CB8968", Offset = "0x2CB4968", VA = "0x2CB8968", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x2CB89B0", Offset = "0x2CB49B0", VA = "0x2CB89B0")]
		public BitArray32(uint initValue)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x2CB89B8", Offset = "0x2CB49B8", VA = "0x2CB89B8")]
		public BitArray32(IEnumerable<uint> bitIndexTrue)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x2CB8A70", Offset = "0x2CB4A70", VA = "0x2CB8A70", Slot = "10")]
		public IBitArray BitAnd(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x2CB8B14", Offset = "0x2CB4B14", VA = "0x2CB8B14", Slot = "11")]
		public IBitArray BitOr(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x2CB8BB8", Offset = "0x2CB4BB8", VA = "0x2CB8BB8", Slot = "12")]
		public IBitArray BitNot()
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2CB8C18", Offset = "0x2CB4C18", VA = "0x2CB8C18")]
		public static BitArray32 operator ~(BitArray32 a)
		{
			return default(BitArray32);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x2CB8BB0", Offset = "0x2CB4BB0", VA = "0x2CB8BB0")]
		public static BitArray32 operator |(BitArray32 a, BitArray32 b)
		{
			return default(BitArray32);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x2CB8B0C", Offset = "0x2CB4B0C", VA = "0x2CB8B0C")]
		public static BitArray32 operator &(BitArray32 a, BitArray32 b)
		{
			return default(BitArray32);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x2CB8C20", Offset = "0x2CB4C20", VA = "0x2CB8C20")]
		public static bool operator ==(BitArray32 a, BitArray32 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x2CB8C2C", Offset = "0x2CB4C2C", VA = "0x2CB8C2C")]
		public static bool operator !=(BitArray32 a, BitArray32 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2CB8C38", Offset = "0x2CB4C38", VA = "0x2CB8C38", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2CB8CB0", Offset = "0x2CB4CB0", VA = "0x2CB8CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000166")]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray64 : IBitArray
	{
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ulong data;

		[Token(Token = "0x1700014B")]
		public uint capacity
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x2CB8CD0", Offset = "0x2CB4CD0", VA = "0x2CB8CD0", Slot = "4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700014C")]
		public bool allFalse
		{
			[Token(Token = "0x6000853")]
			[Address(RVA = "0x2CB8CD8", Offset = "0x2CB4CD8", VA = "0x2CB8CD8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014D")]
		public bool allTrue
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x2CB8CE8", Offset = "0x2CB4CE8", VA = "0x2CB8CE8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014E")]
		public string humanizedData
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x2CB8CF8", Offset = "0x2CB4CF8", VA = "0x2CB8CF8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014F")]
		public bool this[uint index]
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x2CB8E68", Offset = "0x2CB4E68", VA = "0x2CB8E68", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x2CB8E84", Offset = "0x2CB4E84", VA = "0x2CB8E84", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x2CB8ECC", Offset = "0x2CB4ECC", VA = "0x2CB8ECC")]
		public BitArray64(ulong initValue)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x2CB8ED4", Offset = "0x2CB4ED4", VA = "0x2CB8ED4")]
		public BitArray64(IEnumerable<uint> bitIndexTrue)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x2CB8F8C", Offset = "0x2CB4F8C", VA = "0x2CB8F8C")]
		public static BitArray64 operator ~(BitArray64 a)
		{
			return default(BitArray64);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x2CB8F94", Offset = "0x2CB4F94", VA = "0x2CB8F94")]
		public static BitArray64 operator |(BitArray64 a, BitArray64 b)
		{
			return default(BitArray64);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x2CB8F9C", Offset = "0x2CB4F9C", VA = "0x2CB8F9C")]
		public static BitArray64 operator &(BitArray64 a, BitArray64 b)
		{
			return default(BitArray64);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x2CB8FA4", Offset = "0x2CB4FA4", VA = "0x2CB8FA4", Slot = "10")]
		public IBitArray BitAnd(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x2CB9040", Offset = "0x2CB5040", VA = "0x2CB9040", Slot = "11")]
		public IBitArray BitOr(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x2CB90DC", Offset = "0x2CB50DC", VA = "0x2CB90DC", Slot = "12")]
		public IBitArray BitNot()
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x2CB913C", Offset = "0x2CB513C", VA = "0x2CB913C")]
		public static bool operator ==(BitArray64 a, BitArray64 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x2CB9148", Offset = "0x2CB5148", VA = "0x2CB9148")]
		public static bool operator !=(BitArray64 a, BitArray64 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x2CB9154", Offset = "0x2CB5154", VA = "0x2CB9154", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x2CB91CC", Offset = "0x2CB51CC", VA = "0x2CB91CC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000167")]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray128 : IBitArray
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ulong data1;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ulong data2;

		[Token(Token = "0x17000150")]
		public uint capacity
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x2CB91EC", Offset = "0x2CB51EC", VA = "0x2CB91EC", Slot = "4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000151")]
		public bool allFalse
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x2CB91F4", Offset = "0x2CB51F4", VA = "0x2CB91F4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000152")]
		public bool allTrue
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x2CB9214", Offset = "0x2CB5214", VA = "0x2CB9214", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000153")]
		public string humanizedData
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x2CB9238", Offset = "0x2CB5238", VA = "0x2CB9238", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		public bool this[uint index]
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x2CB9434", Offset = "0x2CB5434", VA = "0x2CB9434", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x2CB9464", Offset = "0x2CB5464", VA = "0x2CB9464", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x2CB94D4", Offset = "0x2CB54D4", VA = "0x2CB94D4")]
		public BitArray128(ulong initValue1, ulong initValue2)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x2CB94DC", Offset = "0x2CB54DC", VA = "0x2CB94DC")]
		public BitArray128(IEnumerable<uint> bitIndexTrue)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x2CB95B8", Offset = "0x2CB55B8", VA = "0x2CB95B8")]
		public static BitArray128 operator ~(BitArray128 a)
		{
			return default(BitArray128);
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x2CB95C4", Offset = "0x2CB55C4", VA = "0x2CB95C4")]
		public static BitArray128 operator |(BitArray128 a, BitArray128 b)
		{
			return default(BitArray128);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x2CB95D0", Offset = "0x2CB55D0", VA = "0x2CB95D0")]
		public static BitArray128 operator &(BitArray128 a, BitArray128 b)
		{
			return default(BitArray128);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2CB95DC", Offset = "0x2CB55DC", VA = "0x2CB95DC", Slot = "10")]
		public IBitArray BitAnd(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x2CB967C", Offset = "0x2CB567C", VA = "0x2CB967C", Slot = "11")]
		public IBitArray BitOr(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x2CB971C", Offset = "0x2CB571C", VA = "0x2CB971C", Slot = "12")]
		public IBitArray BitNot()
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2CB977C", Offset = "0x2CB577C", VA = "0x2CB977C")]
		public static bool operator ==(BitArray128 a, BitArray128 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2CB978C", Offset = "0x2CB578C", VA = "0x2CB978C")]
		public static bool operator !=(BitArray128 a, BitArray128 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2CB979C", Offset = "0x2CB579C", VA = "0x2CB979C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2CB9854", Offset = "0x2CB5854", VA = "0x2CB9854", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000168")]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray256 : IBitArray
	{
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ulong data1;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ulong data2;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ulong data3;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ulong data4;

		[Token(Token = "0x17000155")]
		public uint capacity
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x2CB989C", Offset = "0x2CB589C", VA = "0x2CB989C", Slot = "4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000156")]
		public bool allFalse
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x2CB98A4", Offset = "0x2CB58A4", VA = "0x2CB98A4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000157")]
		public bool allTrue
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x2CB98D4", Offset = "0x2CB58D4", VA = "0x2CB98D4", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000158")]
		public string humanizedData
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x2CB9910", Offset = "0x2CB5910", VA = "0x2CB9910", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000159")]
		public bool this[uint index]
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x2CB9C10", Offset = "0x2CB5C10", VA = "0x2CB9C10", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x2CB9C90", Offset = "0x2CB5C90", VA = "0x2CB9C90", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x2CB9D58", Offset = "0x2CB5D58", VA = "0x2CB9D58")]
		public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2CB9D64", Offset = "0x2CB5D64", VA = "0x2CB9D64")]
		public BitArray256(IEnumerable<uint> bitIndexTrue)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x2CB9E7C", Offset = "0x2CB5E7C", VA = "0x2CB9E7C")]
		public static BitArray256 operator ~(BitArray256 a)
		{
			return default(BitArray256);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x2CB9E90", Offset = "0x2CB5E90", VA = "0x2CB9E90")]
		public static BitArray256 operator |(BitArray256 a, BitArray256 b)
		{
			return default(BitArray256);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x2CB9EA8", Offset = "0x2CB5EA8", VA = "0x2CB9EA8")]
		public static BitArray256 operator &(BitArray256 a, BitArray256 b)
		{
			return default(BitArray256);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x2CB9EC0", Offset = "0x2CB5EC0", VA = "0x2CB9EC0", Slot = "10")]
		public IBitArray BitAnd(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x2CB9F68", Offset = "0x2CB5F68", VA = "0x2CB9F68", Slot = "11")]
		public IBitArray BitOr(IBitArray other)
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x2CBA010", Offset = "0x2CB6010", VA = "0x2CBA010", Slot = "12")]
		public IBitArray BitNot()
		{
			return null;
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x2CBA074", Offset = "0x2CB6074", VA = "0x2CBA074")]
		public static bool operator ==(BitArray256 a, BitArray256 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x2CBA0C0", Offset = "0x2CB60C0", VA = "0x2CBA0C0")]
		public static bool operator !=(BitArray256 a, BitArray256 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x2CBA10C", Offset = "0x2CB610C", VA = "0x2CBA10C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x2CBA230", Offset = "0x2CB6230", VA = "0x2CBA230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000169")]
	public static class BitArrayUtilities
	{
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x2CB7EAC", Offset = "0x2CB3EAC", VA = "0x2CB7EAC")]
		public static bool Get8(uint index, byte data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x2CB83D4", Offset = "0x2CB43D4", VA = "0x2CB83D4")]
		public static bool Get16(uint index, ushort data)
		{
			return default(bool);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x2CB895C", Offset = "0x2CB495C", VA = "0x2CB895C")]
		public static bool Get32(uint index, uint data)
		{
			return default(bool);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x2CB8E78", Offset = "0x2CB4E78", VA = "0x2CB8E78")]
		public static bool Get64(uint index, ulong data)
		{
			return default(bool);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x2CB9450", Offset = "0x2CB5450", VA = "0x2CB9450")]
		public static bool Get128(uint index, ulong data1, ulong data2)
		{
			return default(bool);
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x2CB9C54", Offset = "0x2CB5C54", VA = "0x2CB9C54")]
		public static bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4)
		{
			return default(bool);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x2CB7EE0", Offset = "0x2CB3EE0", VA = "0x2CB7EE0")]
		public static void Set8(uint index, ref byte data, bool value)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x2CB8408", Offset = "0x2CB4408", VA = "0x2CB8408")]
		public static void Set16(uint index, ref ushort data, bool value)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x2CB898C", Offset = "0x2CB498C", VA = "0x2CB898C")]
		public static void Set32(uint index, ref uint data, bool value)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x2CB8EA8", Offset = "0x2CB4EA8", VA = "0x2CB8EA8")]
		public static void Set64(uint index, ref ulong data, bool value)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x2CB9498", Offset = "0x2CB5498", VA = "0x2CB9498")]
		public static void Set128(uint index, ref ulong data1, ref ulong data2, bool value)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x2CB9CB0", Offset = "0x2CB5CB0", VA = "0x2CB9CB0")]
		public static void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value)
		{
		}
	}
	[Token(Token = "0x200016A")]
	public static class Blitter
	{
		[Token(Token = "0x200016B")]
		private static class BlitShaderIDs
		{
			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int _BlitTexture;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int _BlitCubeTexture;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int _BlitScaleBias;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int _BlitScaleBiasRt;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int _BlitMipLevel;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly int _BlitTextureSize;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly int _BlitPaddingSize;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly int _BlitDecodeInstructions;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly int _InputDepth;
		}

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material s_Blit;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material s_BlitTexArray;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material s_BlitTexArraySingleSlice;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Material s_BlitColorAndDepth;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static MaterialPropertyBlock s_PropertyBlock;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Mesh s_TriangleMesh;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Mesh s_QuadMesh;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static LocalKeyword s_DecodeHdrKeyword;

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x2CBA2AC", Offset = "0x2CB62AC", VA = "0x2CBA2AC")]
		public static void Initialize(Shader blitPS, Shader blitColorAndDepthPS)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x2CBAB68", Offset = "0x2CB6B68", VA = "0x2CBAB68")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x2CBACF0", Offset = "0x2CB6CF0", VA = "0x2CBACF0")]
		public static Material GetBlitMaterial(TextureDimension dimension, bool singleSlice = false)
		{
			return null;
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x2CBAD94", Offset = "0x2CB6D94", VA = "0x2CBAD94")]
		private static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass)
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x2CBAF2C", Offset = "0x2CB6F2C", VA = "0x2CBAF2C")]
		internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x2CBB0C4", Offset = "0x2CB70C4", VA = "0x2CBB0C4")]
		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x2CBB350", Offset = "0x2CB7350", VA = "0x2CBB350")]
		public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x2CBB480", Offset = "0x2CB7480", VA = "0x2CBB480")]
		public static void BlitColorAndDepth(CommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth)
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x2CBB218", Offset = "0x2CB7218", VA = "0x2CBB218")]
		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x2CBB664", Offset = "0x2CB7664", VA = "0x2CBB664")]
		public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x2CBB7B0", Offset = "0x2CB77B0", VA = "0x2CBB7B0")]
		public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass)
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x2CBB938", Offset = "0x2CB7938", VA = "0x2CBB938")]
		public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x2CBBAD8", Offset = "0x2CB7AD8", VA = "0x2CBBAD8")]
		public static void BlitTexture(CommandBuffer cmd, Vector4 scaleBias, Material material, int pass)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x2CBBBC8", Offset = "0x2CB7BC8", VA = "0x2CBBBC8")]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f, bool bilinear = false)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x2CBBDC8", Offset = "0x2CB7DC8", VA = "0x2CBBDC8")]
		public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f, bool bilinear = false)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x2CBBF24", Offset = "0x2CB7F24", VA = "0x2CBBF24")]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x2CBC078", Offset = "0x2CB8078", VA = "0x2CBC078")]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x2CBC30C", Offset = "0x2CB830C", VA = "0x2CBC30C")]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0f, bool bilinear = false)
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x2CBC404", Offset = "0x2CB8404", VA = "0x2CBC404")]
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0f, bool bilinear = false)
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x2CB222C", Offset = "0x2CAE22C", VA = "0x2CB222C")]
		public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x2CBC5A0", Offset = "0x2CB85A0", VA = "0x2CBC5A0")]
		public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x2CBC838", Offset = "0x2CB8838", VA = "0x2CBC838")]
		public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x2CBCAD0", Offset = "0x2CB8AD0", VA = "0x2CBCAD0")]
		public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2CBCCE8", Offset = "0x2CB8CE8", VA = "0x2CBCCE8")]
		public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x2CB2970", Offset = "0x2CAE970", VA = "0x2CB2970")]
		public static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x2CBCF00", Offset = "0x2CB8F00", VA = "0x2CBCF00")]
		public static void BlitCubeToOctahedral2DQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, [Optional] Vector4? decodeInstructions)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x2CB2D98", Offset = "0x2CAED98", VA = "0x2CB2D98")]
		public static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x2CB2B08", Offset = "0x2CAEB08", VA = "0x2CB2B08")]
		public static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex)
		{
		}
	}
	[Token(Token = "0x200016C")]
	public static class CameraCaptureBridge
	{
		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>> actionDict;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _enabled;

		[Token(Token = "0x1700015A")]
		public static bool enabled
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x2CBD488", Offset = "0x2CB9488", VA = "0x2CBD488")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x2CBD4E0", Offset = "0x2CB94E0", VA = "0x2CBD4E0")]
			set
			{
			}
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x2CBD540", Offset = "0x2CB9540", VA = "0x2CBD540")]
		public static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera)
		{
			return null;
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x2CBD64C", Offset = "0x2CB964C", VA = "0x2CBD64C")]
		public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x2CBD798", Offset = "0x2CB9798", VA = "0x2CBD798")]
		public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action)
		{
		}
	}
	[Token(Token = "0x200016D")]
	internal static class ColorSpaceUtils
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Matrix4x4 Rec709ToRec2020Mat;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly Matrix4x4 Rec709ToP3D65Mat;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly Matrix4x4 Rec2020ToRec709Mat;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static readonly Matrix4x4 Rec2020ToP3D65Mat;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static readonly Matrix4x4 P3D65ToRec2020Mat;
	}
	[Token(Token = "0x200016E")]
	public static class ColorUtils
	{
		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float s_LightMeterCalibrationConstant;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float s_LensAttenuation;

		[Token(Token = "0x1700015B")]
		public static float lensImperfectionExposureScale
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x2CBDC20", Offset = "0x2CB9C20", VA = "0x2CBDC20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x2CBDC90", Offset = "0x2CB9C90", VA = "0x2CBDC90")]
		public static float StandardIlluminantY(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x2CBDCBC", Offset = "0x2CB9CBC", VA = "0x2CBDCBC")]
		public static Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x2CBDD4C", Offset = "0x2CB9D4C", VA = "0x2CBDD4C")]
		public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x2CBDEA8", Offset = "0x2CB9EA8", VA = "0x2CBDEA8")]
		public static (Vector4, Vector4, Vector4) PrepareShadowsMidtonesHighlights(in Vector4 inShadows, in Vector4 inMidtones, in Vector4 inHighlights)
		{
			return default((Vector4, Vector4, Vector4));
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x2CBE08C", Offset = "0x2CBA08C", VA = "0x2CBE08C")]
		public static (Vector4, Vector4, Vector4) PrepareLiftGammaGain(in Vector4 inLift, in Vector4 inGamma, in Vector4 inGain)
		{
			return default((Vector4, Vector4, Vector4));
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x2CBE338", Offset = "0x2CBA338", VA = "0x2CBE338")]
		public static (Vector4, Vector4) PrepareSplitToning(in Vector4 inShadows, in Vector4 inHighlights, float balance)
		{
			return default((Vector4, Vector4));
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x2CBE308", Offset = "0x2CBA308", VA = "0x2CBE308")]
		public static float Luminance(in Color color)
		{
			return default(float);
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x2CBE3C4", Offset = "0x2CBA3C4", VA = "0x2CBE3C4")]
		public static float ComputeEV100(float aperture, float shutterSpeed, float ISO)
		{
			return default(float);
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x2CBE450", Offset = "0x2CBA450", VA = "0x2CBE450")]
		public static float ConvertEV100ToExposure(float EV100)
		{
			return default(float);
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x2CBE4C4", Offset = "0x2CBA4C4", VA = "0x2CBE4C4")]
		public static float ConvertExposureToEV100(float exposure)
		{
			return default(float);
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x2CBE57C", Offset = "0x2CBA57C", VA = "0x2CBE57C")]
		public static float ComputeEV100FromAvgLuminance(float avgLuminance)
		{
			return default(float);
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x2CBE63C", Offset = "0x2CBA63C", VA = "0x2CBE63C")]
		public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100)
		{
			return default(float);
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x2CBE678", Offset = "0x2CBA678", VA = "0x2CBE678")]
		public static uint ToHex(Color c)
		{
			return default(uint);
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x2CBE6E8", Offset = "0x2CBA6E8", VA = "0x2CBE6E8")]
		public static Color ToRGBA(uint hex)
		{
			return default(Color);
		}
	}
	[Token(Token = "0x200016F")]
	public static class CoreMatrixUtils
	{
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x2CBE784", Offset = "0x2CBA784", VA = "0x2CBE784")]
		public static void MatrixTimesTranslation(ref Matrix4x4 inOutMatrix, Vector3 translation)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x2CBE7E0", Offset = "0x2CBA7E0", VA = "0x2CBE7E0")]
		public static void TranslationTimesMatrix(ref Matrix4x4 inOutMatrix, Vector3 translation)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x2CBE868", Offset = "0x2CBA868", VA = "0x2CBE868")]
		public static Matrix4x4 MultiplyPerspectiveMatrix(Matrix4x4 perspective, Matrix4x4 rhs)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x2CBE910", Offset = "0x2CBA910", VA = "0x2CBE910")]
		private static Matrix4x4 MultiplyOrthoMatrixCentered(Matrix4x4 ortho, Matrix4x4 rhs)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x2CBE9A8", Offset = "0x2CBA9A8", VA = "0x2CBE9A8")]
		private static Matrix4x4 MultiplyGenericOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x2CBEA64", Offset = "0x2CBAA64", VA = "0x2CBEA64")]
		public static Matrix4x4 MultiplyOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs, bool centered)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x2CBEB40", Offset = "0x2CBAB40", VA = "0x2CBEB40")]
		public static Matrix4x4 MultiplyProjectionMatrix(Matrix4x4 projMatrix, Matrix4x4 rhs, bool orthoCentered)
		{
			return default(Matrix4x4);
		}
	}
	[Token(Token = "0x2000170")]
	public static class CoreUtils
	{
		[Token(Token = "0x2000171")]
		public static class Sections
		{
			[Token(Token = "0x4000696")]
			public const int section1 = 10000;

			[Token(Token = "0x4000697")]
			public const int section2 = 20000;

			[Token(Token = "0x4000698")]
			public const int section3 = 30000;

			[Token(Token = "0x4000699")]
			public const int section4 = 40000;

			[Token(Token = "0x400069A")]
			public const int section5 = 50000;

			[Token(Token = "0x400069B")]
			public const int section6 = 60000;

			[Token(Token = "0x400069C")]
			public const int section7 = 70000;

			[Token(Token = "0x400069D")]
			public const int section8 = 80000;
		}

		[Token(Token = "0x2000172")]
		public static class Priorities
		{
			[Token(Token = "0x400069E")]
			public const int assetsCreateShaderMenuPriority = 83;

			[Token(Token = "0x400069F")]
			public const int assetsCreateRenderingMenuPriority = 308;

			[Token(Token = "0x40006A0")]
			public const int editMenuPriority = 320;

			[Token(Token = "0x40006A1")]
			public const int gameObjectMenuPriority = 10;

			[Token(Token = "0x40006A2")]
			public const int srpLensFlareMenuPriority = 303;
		}

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3[] lookAtList;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Vector3[] upVectorList;

		[Token(Token = "0x4000686")]
		private const string obsoletePriorityMessage = "Use CoreUtils.Priorities instead";

		[Token(Token = "0x4000687")]
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority1 = 320;

		[Token(Token = "0x4000688")]
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority2 = 331;

		[Token(Token = "0x4000689")]
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority3 = 342;

		[Token(Token = "0x400068A")]
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority4 = 353;

		[Token(Token = "0x400068B")]
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority1 = 230;

		[Token(Token = "0x400068C")]
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority2 = 241;

		[Token(Token = "0x400068D")]
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority3 = 300;

		[Token(Token = "0x400068E")]
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int gameObjectMenuPriority = 10;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Cubemap m_BlackCubeTexture;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Cubemap m_MagentaCubeTexture;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static CubemapArray m_MagentaCubeTextureArray;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Cubemap m_WhiteCubeTexture;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static RenderTexture m_EmptyUAV;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Texture3D m_BlackVolumeTexture;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static IEnumerable<Type> m_AssemblyTypes;

		[Token(Token = "0x1700015C")]
		public static Cubemap blackCubeTexture
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x2CBEBFC", Offset = "0x2CBABFC", VA = "0x2CBEBFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015D")]
		public static Cubemap magentaCubeTexture
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x2CBED7C", Offset = "0x2CBAD7C", VA = "0x2CBED7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		public static CubemapArray magentaCubeTextureArray
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x2CBEEFC", Offset = "0x2CBAEFC", VA = "0x2CBEEFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015F")]
		public static Cubemap whiteCubeTexture
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x2CBF0C8", Offset = "0x2CBB0C8", VA = "0x2CBF0C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		public static RenderTexture emptyUAV
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x2CBF248", Offset = "0x2CBB248", VA = "0x2CBF248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000161")]
		public static Texture3D blackVolumeTexture
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x2CBF378", Offset = "0x2CBB378", VA = "0x2CBF378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x2CBF4F4", Offset = "0x2CBB4F4", VA = "0x2CBF4F4")]
		public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x2CBF518", Offset = "0x2CBB518", VA = "0x2CBF518")]
		private static int FixupDepthSlice(int depthSlice, RTHandle buffer)
		{
			return default(int);
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x2CBF55C", Offset = "0x2CBB55C", VA = "0x2CBF55C")]
		private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace)
		{
			return default(int);
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x2CBF570", Offset = "0x2CBB570", VA = "0x2CBF570")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x2CBF670", Offset = "0x2CBB670", VA = "0x2CBF670")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = ClearFlag.None, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x2CBF730", Offset = "0x2CBB730", VA = "0x2CBF730")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x2CBF91C", Offset = "0x2CBB91C", VA = "0x2CBF91C")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x2CBF804", Offset = "0x2CBB804", VA = "0x2CBF804")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x2CBF9F4", Offset = "0x2CBB9F4", VA = "0x2CBF9F4")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer)
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x2CBFB74", Offset = "0x2CBBB74", VA = "0x2CBFB74")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = ClearFlag.None)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x2CBFA90", Offset = "0x2CBBA90", VA = "0x2CBFA90")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x2CBFC1C", Offset = "0x2CBBC1C", VA = "0x2CBFC1C")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x2CBFD04", Offset = "0x2CBBD04", VA = "0x2CBFD04")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x2CBFDF4", Offset = "0x2CBBDF4", VA = "0x2CBFDF4")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x2CBFF18", Offset = "0x2CBBF18", VA = "0x2CBFF18")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x2CBFFC8", Offset = "0x2CBBFC8", VA = "0x2CBFFC8")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x2CC00E0", Offset = "0x2CBC0E0", VA = "0x2CC00E0")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x2CC0230", Offset = "0x2CBC230", VA = "0x2CC0230")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x2CC03AC", Offset = "0x2CBC3AC", VA = "0x2CC03AC")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x2CC04AC", Offset = "0x2CBC4AC", VA = "0x2CC04AC")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag)
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x2CC0594", Offset = "0x2CBC594", VA = "0x2CC0594")]
		private static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x2CC06B0", Offset = "0x2CBC6B0", VA = "0x2CC06B0")]
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x2CBBD24", Offset = "0x2CB7D24", VA = "0x2CBBD24")]
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = ClearFlag.None, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x2CC07BC", Offset = "0x2CBC7BC", VA = "0x2CC07BC")]
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x2CC0B20", Offset = "0x2CBCB20", VA = "0x2CC0B20")]
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x2CC0924", Offset = "0x2CBC924", VA = "0x2CC0924")]
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x2CBC1F4", Offset = "0x2CB81F4", VA = "0x2CBC1F4")]
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x2CC0C8C", Offset = "0x2CBCC8C", VA = "0x2CC0C8C")]
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x2CC0EBC", Offset = "0x2CBCEBC", VA = "0x2CC0EBC")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x2CC0F6C", Offset = "0x2CBCF6C", VA = "0x2CC0F6C")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = ClearFlag.None)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x2CC1020", Offset = "0x2CBD020", VA = "0x2CC1020")]
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x2CC0638", Offset = "0x2CBC638", VA = "0x2CC0638")]
		public static void SetViewport(CommandBuffer cmd, RTHandle target)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x2CC1110", Offset = "0x2CBD110", VA = "0x2CC1110")]
		public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = MSAASamples.None)
		{
			return null;
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x2CC1458", Offset = "0x2CBD458", VA = "0x2CC1458")]
		public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = MSAASamples.None)
		{
			return null;
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x2CC1550", Offset = "0x2CBD550", VA = "0x2CC1550")]
		public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, TextureDimension dim, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = MSAASamples.None, bool dynamicRes = false)
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x2CC1208", Offset = "0x2CBD208", VA = "0x2CC1208")]
		private static string GetRenderTargetAutoName(int width, int height, int depth, string format, TextureDimension dim, string name, bool mips, bool enableMSAA, MSAASamples msaaSamples, bool dynamicRes)
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x2CC1654", Offset = "0x2CBD654", VA = "0x2CC1654")]
		public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = false, int depth = 0)
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x2CC1AF4", Offset = "0x2CBDAF4", VA = "0x2CC1AF4")]
		public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = false, int depth = 0)
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x2CC173C", Offset = "0x2CBD73C", VA = "0x2CC173C")]
		private static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = false, int depth = 0)
		{
			return null;
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x2CC1BDC", Offset = "0x2CBDBDC", VA = "0x2CC1BDC")]
		public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, Color clearColor, bool clearMips = false)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x2CC1D90", Offset = "0x2CBDD90", VA = "0x2CC1D90")]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, [Optional] MaterialPropertyBlock properties, int shaderPassId = 0)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x2CC1E34", Offset = "0x2CBDE34", VA = "0x2CC1E34")]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, [Optional] MaterialPropertyBlock properties, int shaderPassId = 0)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x2CC1F00", Offset = "0x2CBDF00", VA = "0x2CC1F00")]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, [Optional] MaterialPropertyBlock properties, int shaderPassId = 0)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x2CC1FE0", Offset = "0x2CBDFE0", VA = "0x2CC1FE0")]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, [Optional] MaterialPropertyBlock properties, int shaderPassId = 0)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x2CC20B4", Offset = "0x2CBE0B4", VA = "0x2CC20B4")]
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, [Optional] MaterialPropertyBlock properties, int shaderPassId = 0)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x2CC216C", Offset = "0x2CBE16C", VA = "0x2CC216C")]
		public static Color ConvertSRGBToActiveColorSpace(Color color)
		{
			return default(Color);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x2CC21E8", Offset = "0x2CBE1E8", VA = "0x2CC21E8")]
		public static Color ConvertLinearToActiveColorSpace(Color color)
		{
			return default(Color);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x2CC2264", Offset = "0x2CBE264", VA = "0x2CC2264")]
		public static Material CreateEngineMaterial(string shaderPath)
		{
			return null;
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x2CBA79C", Offset = "0x2CB679C", VA = "0x2CBA79C")]
		public static Material CreateEngineMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x600090B")]
		public static bool HasFlag<T>(T mask, T flag) where T : IConvertible
		{
			return default(bool);
		}

		[Token(Token = "0x600090C")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x2CC23A0", Offset = "0x2CBE3A0", VA = "0x2CC23A0")]
		public static void SetKeyword(CommandBuffer cmd, string keyword, bool state)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x2CC23CC", Offset = "0x2CBE3CC", VA = "0x2CC23CC")]
		public static void SetKeyword(Material material, string keyword, bool state)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x2CC23F8", Offset = "0x2CBE3F8", VA = "0x2CC23F8")]
		public static void SetKeyword(ComputeShader cs, string keyword, bool state)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x2CBAC68", Offset = "0x2CB6C68", VA = "0x2CBAC68")]
		public static void Destroy(Object obj)
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x2CC2424", Offset = "0x2CBE424", VA = "0x2CC2424")]
		public static IEnumerable<Type> GetAllAssemblyTypes()
		{
			return null;
		}

		[Token(Token = "0x6000912")]
		public static IEnumerable<Type> GetAllTypesDerivedFrom<T>()
		{
			return null;
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x2CC25B0", Offset = "0x2CBE5B0", VA = "0x2CC25B0")]
		public static void SafeRelease(GraphicsBuffer buffer)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x2CC25C0", Offset = "0x2CBE5C0", VA = "0x2CC25C0")]
		public static void SafeRelease(ComputeBuffer buffer)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x2CC25D0", Offset = "0x2CBE5D0", VA = "0x2CC25D0")]
		public static Mesh CreateCubeMesh(Vector3 min, Vector3 max)
		{
			return null;
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x2CC2974", Offset = "0x2CBE974", VA = "0x2CC2974")]
		public static bool ArePostProcessesEnabled(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x2CC297C", Offset = "0x2CBE97C", VA = "0x2CC297C")]
		public static bool AreAnimatedMaterialsEnabled(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x2CC2984", Offset = "0x2CBE984", VA = "0x2CC2984")]
		public static bool IsSceneLightingDisabled(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x2CC298C", Offset = "0x2CBE98C", VA = "0x2CC298C")]
		public static bool IsLightOverlapDebugEnabled(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x2CC2994", Offset = "0x2CBE994", VA = "0x2CC2994")]
		public static bool IsSceneViewFogEnabled(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x2CC299C", Offset = "0x2CBE99C", VA = "0x2CC299C")]
		public static bool IsSceneFilteringEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x2CC29A4", Offset = "0x2CBE9A4", VA = "0x2CC29A4")]
		public static bool IsSceneViewPrefabStageContextHidden()
		{
			return default(bool);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x2CC29AC", Offset = "0x2CBE9AC", VA = "0x2CC29AC")]
		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, RendererList rendererList)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x2CB3284", Offset = "0x2CAF284", VA = "0x2CB3284")]
		public static int GetTextureHash(Texture texture)
		{
			return default(int);
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x2CC2A90", Offset = "0x2CBEA90", VA = "0x2CC2A90")]
		public static int PreviousPowerOfTwo(int size)
		{
			return default(int);
		}

		[Token(Token = "0x6000920")]
		public static T GetLastEnumValue<T>() where T : Enum
		{
			return (T)null;
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x2CC2ABC", Offset = "0x2CBEABC", VA = "0x2CC2ABC")]
		internal static string GetCorePath()
		{
			return null;
		}
	}
	[Token(Token = "0x2000175")]
	public static class DelegateUtility
	{
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x2CC2DD0", Offset = "0x2CBEDD0", VA = "0x2CC2DD0")]
		public static Delegate Cast(Delegate source, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000176")]
	public static class FSRUtils
	{
		[Token(Token = "0x2000177")]
		private static class ShaderConstants
		{
			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int _FsrEasuConstants0;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int _FsrEasuConstants1;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int _FsrEasuConstants2;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int _FsrEasuConstants3;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int _FsrRcasConstants;
		}

		[Token(Token = "0x40006A7")]
		internal const float kMaxSharpnessStops = 2.5f;

		[Token(Token = "0x40006A8")]
		public const float kDefaultSharpnessStops = 0.2f;

		[Token(Token = "0x40006A9")]
		public const float kDefaultSharpnessLinear = 0.92f;

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x2CC2F4C", Offset = "0x2CBEF4C", VA = "0x2CC2F4C")]
		public static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x2CC30CC", Offset = "0x2CBF0CC", VA = "0x2CC30CC")]
		public static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2f)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x2CC3174", Offset = "0x2CBF174", VA = "0x2CC3174")]
		public static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92f)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x2CC3188", Offset = "0x2CBF188", VA = "0x2CC3188")]
		public static bool IsSupported()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000178")]
	public class HableCurve
	{
		[Token(Token = "0x2000179")]
		public class Segment
		{
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float offsetX;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float offsetY;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float scaleX;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float scaleY;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float lnA;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float B;

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x2CC3518", Offset = "0x2CBF518", VA = "0x2CC3518")]
			public float Eval(float x)
			{
				return default(float);
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x2CC3438", Offset = "0x2CBF438", VA = "0x2CC3438")]
			public Segment()
			{
			}
		}

		[Token(Token = "0x200017A")]
		private struct DirectParams
		{
			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal float x0;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal float y0;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float x1;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal float y1;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal float W;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal float overshootX;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal float overshootY;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal float gamma;
		}

		[Token(Token = "0x200017B")]
		public class Uniforms
		{
			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private HableCurve parent;

			[Token(Token = "0x17000166")]
			public Vector4 curve
			{
				[Token(Token = "0x6000941")]
				[Address(RVA = "0x2CC3A2C", Offset = "0x2CBFA2C", VA = "0x2CC3A2C")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x17000167")]
			public Vector4 toeSegmentA
			{
				[Token(Token = "0x6000942")]
				[Address(RVA = "0x2CC3A4C", Offset = "0x2CBFA4C", VA = "0x2CC3A4C")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x17000168")]
			public Vector4 toeSegmentB
			{
				[Token(Token = "0x6000943")]
				[Address(RVA = "0x2CC3A88", Offset = "0x2CBFA88", VA = "0x2CC3A88")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x17000169")]
			public Vector4 midSegmentA
			{
				[Token(Token = "0x6000944")]
				[Address(RVA = "0x2CC3AC8", Offset = "0x2CBFAC8", VA = "0x2CC3AC8")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x1700016A")]
			public Vector4 midSegmentB
			{
				[Token(Token = "0x6000945")]
				[Address(RVA = "0x2CC3B08", Offset = "0x2CBFB08", VA = "0x2CC3B08")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x1700016B")]
			public Vector4 shoSegmentA
			{
				[Token(Token = "0x6000946")]
				[Address(RVA = "0x2CC3B4C", Offset = "0x2CBFB4C", VA = "0x2CC3B4C")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x1700016C")]
			public Vector4 shoSegmentB
			{
				[Token(Token = "0x6000947")]
				[Address(RVA = "0x2CC3B8C", Offset = "0x2CBFB8C", VA = "0x2CC3B8C")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x2CC3440", Offset = "0x2CBF440", VA = "0x2CC3440")]
			internal Uniforms(HableCurve parent)
			{
			}
		}

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Segment[] segments;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Uniforms uniforms;

		[Token(Token = "0x17000162")]
		public float whitePoint
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x2CC32DC", Offset = "0x2CBF2DC", VA = "0x2CC32DC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x2CC32E4", Offset = "0x2CBF2E4", VA = "0x2CC32E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public float inverseWhitePoint
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x2CC32EC", Offset = "0x2CBF2EC", VA = "0x2CC32EC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x2CC32F4", Offset = "0x2CBF2F4", VA = "0x2CC32F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public float x0
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x2CC32FC", Offset = "0x2CBF2FC", VA = "0x2CC32FC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x2CC3304", Offset = "0x2CBF304", VA = "0x2CC3304")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public float x1
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x2CC330C", Offset = "0x2CBF30C", VA = "0x2CC330C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x2CC3314", Offset = "0x2CBF314", VA = "0x2CC3314")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x2CC331C", Offset = "0x2CBF31C", VA = "0x2CC331C")]
		public HableCurve()
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x2CC3468", Offset = "0x2CBF468", VA = "0x2CC3468")]
		public float Eval(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x2CC3578", Offset = "0x2CBF578", VA = "0x2CC3578")]
		public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x2CC36B4", Offset = "0x2CBF6B4", VA = "0x2CC36B4")]
		private void InitSegments(DirectParams srcParams)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x2CC39DC", Offset = "0x2CBF9DC", VA = "0x2CC39DC")]
		private void SolveAB(out float lnA, out float B, float x0, float y0, float m)
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x2CC3974", Offset = "0x2CBF974", VA = "0x2CC3974")]
		private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x2CC39A0", Offset = "0x2CBF9A0", VA = "0x2CC39A0")]
		private float EvalDerivativeLinearGamma(float m, float b, float g, float x)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200017C")]
	public static class HaltonSequence
	{
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x2CC3BD0", Offset = "0x2CBFBD0", VA = "0x2CC3BD0")]
		public static float Get(int index, int radix)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200017D")]
	internal ref struct HashFNV1A32
	{
		[Token(Token = "0x40006C4")]
		private const uint k_Prime = 16777619u;

		[Token(Token = "0x40006C5")]
		private const uint k_OffsetBasis = 2166136261u;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint m_Hash;

		[Token(Token = "0x1700016D")]
		public int value
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x2CC3F5C", Offset = "0x2CBFF5C", VA = "0x2CC3F5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x2CC3C14", Offset = "0x2CBFC14", VA = "0x2CC3C14")]
		public static HashFNV1A32 Create()
		{
			return default(HashFNV1A32);
		}

		[MethodImpl(256)]
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x2CC3C20", Offset = "0x2CBFC20", VA = "0x2CC3C20")]
		public void Append(in int input)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x2CC3C40", Offset = "0x2CBFC40", VA = "0x2CC3C40")]
		public void Append(in uint input)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x2CC3C60", Offset = "0x2CBFC60", VA = "0x2CC3C60")]
		public void Append(in bool input)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x2CC3C88", Offset = "0x2CBFC88", VA = "0x2CC3C88")]
		public void Append(in float input)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x2CC3CCC", Offset = "0x2CBFCCC", VA = "0x2CC3CCC")]
		public void Append(in double input)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x2CC3D04", Offset = "0x2CBFD04", VA = "0x2CC3D04")]
		public void Append(in Vector2 input)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x2CC3D68", Offset = "0x2CBFD68", VA = "0x2CC3D68")]
		public void Append(in Vector3 input)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x2CC3DF0", Offset = "0x2CBFDF0", VA = "0x2CC3DF0")]
		public void Append(in Vector4 input)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000952")]
		public void Append<T>(T input) where T : struct
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x2CC3E8C", Offset = "0x2CBFE8C", VA = "0x2CC3E8C")]
		public void Append(Delegate del)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x2CC3F08", Offset = "0x2CBFF08", VA = "0x2CC3F08")]
		internal static int GetFuncHashCode(Delegate del)
		{
			return default(int);
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x2CC3F64", Offset = "0x2CBFF64", VA = "0x2CC3F64", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200017E")]
	public static class HDROutputUtils
	{
		[Token(Token = "0x200017F")]
		[Flags]
		public enum Operation
		{
			[Token(Token = "0x40006C8")]
			None = 0,
			[Token(Token = "0x40006C9")]
			ColorConversion = 1,
			[Token(Token = "0x40006CA")]
			ColorEncoding = 2
		}

		[Token(Token = "0x2000180")]
		public struct HDRDisplayInformation
		{
			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int maxFullFrameToneMapLuminance;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int maxToneMapLuminance;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int minToneMapLuminance;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float paperWhiteNits;

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x2CC4B4C", Offset = "0x2CC0B4C", VA = "0x2CC4B4C")]
			public HDRDisplayInformation(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits)
			{
			}
		}

		[Token(Token = "0x2000181")]
		public static class ShaderKeywords
		{
			[Token(Token = "0x40006CF")]
			public const string HDR_COLORSPACE_CONVERSION = "HDR_COLORSPACE_CONVERSION";

			[Token(Token = "0x40006D0")]
			public const string HDR_ENCODING = "HDR_ENCODING";

			[Token(Token = "0x40006D1")]
			public const string HDR_COLORSPACE_CONVERSION_AND_ENCODING = "HDR_COLORSPACE_CONVERSION_AND_ENCODING";

			[Token(Token = "0x40006D2")]
			public const string HDR_INPUT = "HDR_INPUT";

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly ShaderKeyword HDRColorSpaceConversion;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly ShaderKeyword HDREncoding;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly ShaderKeyword HDRColorSpaceConversionAndEncoding;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal static readonly ShaderKeyword HDRInput;
		}

		[Token(Token = "0x2000182")]
		private static class ShaderPropertyId
		{
			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int hdrColorSpace;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int hdrEncoding;
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x2CC3F6C", Offset = "0x2CBFF6C", VA = "0x2CC3F6C")]
		public static bool GetColorSpaceForGamut(ColorGamut gamut, out int colorspace)
		{
			return default(bool);
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x2CC4168", Offset = "0x2CC0168", VA = "0x2CC4168")]
		public static bool GetColorEncodingForGamut(ColorGamut gamut, out int encoding)
		{
			return default(bool);
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x2CC42E0", Offset = "0x2CC02E0", VA = "0x2CC42E0")]
		public static void ConfigureHDROutput(Material material, ColorGamut gamut, Operation operations)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x2CC4540", Offset = "0x2CC0540", VA = "0x2CC4540")]
		public static void ConfigureHDROutput(MaterialPropertyBlock properties, ColorGamut gamut)
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x2CC460C", Offset = "0x2CC060C", VA = "0x2CC460C")]
		public static void ConfigureHDROutput(Material material, Operation operations)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x2CC47E0", Offset = "0x2CC07E0", VA = "0x2CC47E0")]
		public static void ConfigureHDROutput(ComputeShader computeShader, ColorGamut gamut, Operation operations)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x2CC4A40", Offset = "0x2CC0A40", VA = "0x2CC4A40")]
		public static bool IsShaderVariantValid(ShaderKeywordSet shaderKeywordSet, bool isHDREnabled)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000183")]
	[MovedFrom("Utilities")]
	[Flags]
	public enum MaterialQuality
	{
		[Token(Token = "0x40006DA")]
		Low = 1,
		[Token(Token = "0x40006DB")]
		Medium = 2,
		[Token(Token = "0x40006DC")]
		High = 4
	}
	[Token(Token = "0x2000184")]
	[MovedFrom("Utilities")]
	public static class MaterialQualityUtilities
	{
		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] KeywordNames;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] EnumNames;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static ShaderKeyword[] Keywords;

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x2CC4D30", Offset = "0x2CC0D30", VA = "0x2CC4D30")]
		public static MaterialQuality GetHighestQuality(this MaterialQuality levels)
		{
			return default(MaterialQuality);
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x2CC4DBC", Offset = "0x2CC0DBC", VA = "0x2CC4DBC")]
		public static MaterialQuality GetClosestQuality(this MaterialQuality availableLevels, MaterialQuality requestedLevel)
		{
			return default(MaterialQuality);
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x2CC4F84", Offset = "0x2CC0F84", VA = "0x2CC4F84")]
		public static void SetGlobalShaderKeywords(this MaterialQuality level)
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x2CC507C", Offset = "0x2CC107C", VA = "0x2CC507C")]
		public static void SetGlobalShaderKeywords(this MaterialQuality level, CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x2CC4EEC", Offset = "0x2CC0EEC", VA = "0x2CC4EEC")]
		public static int ToFirstIndex(this MaterialQuality level)
		{
			return default(int);
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x2CC4F78", Offset = "0x2CC0F78", VA = "0x2CC4F78")]
		public static MaterialQuality FromIndex(int index)
		{
			return default(MaterialQuality);
		}
	}
	[Token(Token = "0x2000185")]
	internal class MeshGizmo : IDisposable
	{
		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int vertexCountPerCube;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Vector3> vertices;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<int> indices;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Color> colors;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material wireMaterial;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material dottedWireMaterial;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material solidMaterial;

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x2CC5408", Offset = "0x2CC1408", VA = "0x2CC5408")]
		public MeshGizmo(int capacity = 0)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x2CC5584", Offset = "0x2CC1584", VA = "0x2CC5584")]
		public void Clear()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x2CC5614", Offset = "0x2CC1614", VA = "0x2CC5614")]
		public void AddWireCube(Vector3 center, Vector3 size, Color color)
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x2CC5B30", Offset = "0x2CC1B30", VA = "0x2CC5B30")]
		private void DrawMesh(Matrix4x4 trs, Material mat, MeshTopology topology, CompareFunction depthTest, string gizmoName)
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x2CC5CC8", Offset = "0x2CC1CC8", VA = "0x2CC5CC8")]
		public void RenderWireframe(Matrix4x4 trs, CompareFunction depthTest = CompareFunction.LessEqual, [Optional] string gizmoName)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x2CC5D04", Offset = "0x2CC1D04", VA = "0x2CC5D04", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000187")]
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class ReloadAttribute : Attribute
	{
		[Token(Token = "0x2000188")]
		public enum Package
		{
			[Token(Token = "0x40006EB")]
			Builtin,
			[Token(Token = "0x40006EC")]
			Root,
			[Token(Token = "0x40006ED")]
			BuiltinExtra
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x2CC5DAC", Offset = "0x2CC1DAC", VA = "0x2CC5DAC")]
		public ReloadAttribute(string[] paths, Package package = Package.Root)
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x2CC5DB4", Offset = "0x2CC1DB4", VA = "0x2CC5DB4")]
		public ReloadAttribute(string path, Package package = Package.Root)
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x2CC5E30", Offset = "0x2CC1E30", VA = "0x2CC5E30")]
		public ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, Package package = Package.Root)
		{
		}
	}
	[Token(Token = "0x2000189")]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ReloadGroupAttribute : Attribute
	{
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x2CC5E38", Offset = "0x2CC1E38", VA = "0x2CC5E38")]
		public ReloadGroupAttribute()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class SceneRenderPipeline : MonoBehaviour
	{
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x2CC5E40", Offset = "0x2CC1E40", VA = "0x2CC5E40")]
		public SceneRenderPipeline()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200018B")]
	public class TextureCurve : IDisposable
	{
		[Token(Token = "0x40006EE")]
		private const int k_Precision = 128;

		[Token(Token = "0x40006EF")]
		private const float k_Step = 1f / 128f;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool m_Loop;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_ZeroValue;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Range;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve m_Curve;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnimationCurve m_LoopingCurve;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Texture2D m_Texture;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_IsCurveDirty;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool m_IsTextureDirty;

		[Token(Token = "0x1700016E")]
		public int length
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x2CC5E48", Offset = "0x2CC1E48", VA = "0x2CC5E48")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x2CC5E50", Offset = "0x2CC1E50", VA = "0x2CC5E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public Keyframe this[int index]
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x2CC5E58", Offset = "0x2CC1E58", VA = "0x2CC5E58")]
			get
			{
				return default(Keyframe);
			}
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x2CC5E70", Offset = "0x2CC1E70", VA = "0x2CC5E70")]
		public TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, in Vector2 bounds)
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x2CC5EC4", Offset = "0x2CC1EC4", VA = "0x2CC5EC4")]
		public TextureCurve(Keyframe[] keys, float zeroValue, bool loop, in Vector2 bounds)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x2CC5FC4", Offset = "0x2CC1FC4", VA = "0x2CC5FC4", Slot = "1")]
		~TextureCurve()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x2CC5FCC", Offset = "0x2CC1FCC", VA = "0x2CC5FCC", Slot = "4")]
		[Obsolete("Please use Release() instead.")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x2CC5FD0", Offset = "0x2CC1FD0", VA = "0x2CC5FD0")]
		public void Release()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x2CC6034", Offset = "0x2CC2034", VA = "0x2CC6034")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x2CC6040", Offset = "0x2CC2040", VA = "0x2CC6040")]
		private static GraphicsFormat GetTextureFormat()
		{
			return default(GraphicsFormat);
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x2CC6088", Offset = "0x2CC2088", VA = "0x2CC6088")]
		public Texture2D GetTexture()
		{
			return null;
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x2CC626C", Offset = "0x2CC226C", VA = "0x2CC626C")]
		public float Evaluate(float time)
		{
			return default(float);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2CC6488", Offset = "0x2CC2488", VA = "0x2CC6488")]
		public int AddKey(float time, float value)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x2CC64B8", Offset = "0x2CC24B8", VA = "0x2CC64B8")]
		public int MoveKey(int index, in Keyframe key)
		{
			return default(int);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x2CC6500", Offset = "0x2CC2500", VA = "0x2CC6500")]
		public void RemoveKey(int index)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x2CC652C", Offset = "0x2CC252C", VA = "0x2CC652C")]
		public void SmoothTangents(int index, float weight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200018C")]
	public class TextureCurveParameter : VolumeParameter<TextureCurve>
	{
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x2CC6558", Offset = "0x2CC2558", VA = "0x2CC6558")]
		public TextureCurveParameter(TextureCurve value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x2CC65B8", Offset = "0x2CC25B8", VA = "0x2CC65B8", Slot = "11")]
		public override void Release()
		{
		}
	}
	[Token(Token = "0x200018D")]
	public static class TileLayoutUtils
	{
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x2CC65CC", Offset = "0x2CC25CC", VA = "0x2CC65CC")]
		public static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight)
		{
			return default(bool);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x2CC6658", Offset = "0x2CC2658", VA = "0x2CC6658")]
		public static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x2CC66B8", Offset = "0x2CC26B8", VA = "0x2CC66B8")]
		public static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200018E")]
	public static class XRUtils
	{
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x2CC6718", Offset = "0x2CC2718", VA = "0x2CC6718")]
		public static void DrawOcclusionMesh(CommandBuffer cmd, Camera camera, bool stereoEnabled = true)
		{
		}
	}
	[Token(Token = "0x200018F")]
	public interface IVolume
	{
		[Token(Token = "0x17000170")]
		bool isGlobal
		{
			[Token(Token = "0x600098B")]
			get;
			[Token(Token = "0x600098C")]
			set;
		}

		[Token(Token = "0x17000171")]
		List<Collider> colliders
		{
			[Token(Token = "0x600098D")]
			get;
		}
	}
	[Token(Token = "0x2000190")]
	public class KeyframeUtility
	{
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x2CC67A0", Offset = "0x2CC27A0", VA = "0x2CC67A0")]
		public static void ResetAnimationCurve(AnimationCurve curve)
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x2CC67B4", Offset = "0x2CC27B4", VA = "0x2CC67B4")]
		private static Keyframe LerpSingleKeyframe(Keyframe lhs, Keyframe rhs, float t)
		{
			return default(Keyframe);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x2CC6974", Offset = "0x2CC2974", VA = "0x2CC6974")]
		private static Keyframe GetKeyframeAndClampEdge([DisallowNull] NativeArray<Keyframe> keys, int index)
		{
			return default(Keyframe);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x2CC6A7C", Offset = "0x2CC2A7C", VA = "0x2CC6A7C")]
		private static Keyframe FetchKeyFromIndexClampEdge([DisallowNull] NativeArray<Keyframe> keys, int index, float segmentStartTime, float segmentEndTime)
		{
			return default(Keyframe);
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x2CC6BEC", Offset = "0x2CC2BEC", VA = "0x2CC6BEC")]
		private static void EvalCurveSegmentAndDeriv(out float dstValue, out float dstDeriv, Keyframe lhsKey, Keyframe rhsKey, float desiredTime)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x2CC6D78", Offset = "0x2CC2D78", VA = "0x2CC6D78")]
		private static Keyframe EvalKeyAtTime([DisallowNull] NativeArray<Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime)
		{
			return default(Keyframe);
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x2CC6E3C", Offset = "0x2CC2E3C", VA = "0x2CC6E3C")]
		public static void InterpAnimationCurve(ref AnimationCurve lhsAndResultCurve, [DisallowNull] AnimationCurve rhsCurve, float t)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x2CC74D4", Offset = "0x2CC34D4", VA = "0x2CC74D4")]
		public KeyframeUtility()
		{
		}
	}
	[Token(Token = "0x2000191")]
	[ExecuteAlways]
	[AddComponentMenu("Miscellaneous/Volume")]
	public class Volume : MonoBehaviour, IVolume
	{
		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("isGlobal")]
		[SerializeField]
		private bool m_IsGlobal;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("A value which determines which Volume is being used when Volumes have an equal amount of influence on the Scene. Volumes with a higher priority will override lower ones.")]
		[Delayed]
		public float priority;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Sets the outer distance to start blending from. A value of 0 means no blending and Unity applies the Volume overrides immediately upon entry.")]
		public float blendDistance;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Sets the total weight of this Volume in the Scene. 0 means no effect and 1 means full effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VolumeProfile sharedProfile;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal List<Collider> m_Colliders;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_PreviousLayer;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_PreviousPriority;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private VolumeProfile m_InternalProfile;

		[Token(Token = "0x17000172")]
		[Tooltip("When enabled, the Volume is applied to the entire Scene.")]
		public bool isGlobal
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x2CC74DC", Offset = "0x2CC34DC", VA = "0x2CC74DC", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x2CC74E4", Offset = "0x2CC34E4", VA = "0x2CC74E4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		public VolumeProfile profile
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x2CC74EC", Offset = "0x2CC34EC", VA = "0x2CC74EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x2CC77A0", Offset = "0x2CC37A0", VA = "0x2CC77A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000174")]
		public List<Collider> colliders
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x2CC77A8", Offset = "0x2CC37A8", VA = "0x2CC77A8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000175")]
		internal VolumeProfile profileRef
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x2CC77B0", Offset = "0x2CC37B0", VA = "0x2CC77B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x2CC7828", Offset = "0x2CC3828", VA = "0x2CC7828")]
		public bool HasInstantiatedProfile()
		{
			return default(bool);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x2CC7888", Offset = "0x2CC3888", VA = "0x2CC7888")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x2CC7C40", Offset = "0x2CC3C40", VA = "0x2CC7C40")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x2CC7E6C", Offset = "0x2CC3E6C", VA = "0x2CC7E6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x2CC7F10", Offset = "0x2CC3F10", VA = "0x2CC7F10")]
		internal void UpdateLayer()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x2CC8168", Offset = "0x2CC4168", VA = "0x2CC8168")]
		public Volume()
		{
		}
	}
	[Token(Token = "0x2000192")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class VolumeComponentMenu : Attribute
	{
		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string menu;

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x2CC81F4", Offset = "0x2CC41F4", VA = "0x2CC81F4")]
		public VolumeComponentMenu(string menu)
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu
	{
		[Token(Token = "0x17000176")]
		public Type[] pipelineTypes
		{
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x2CC821C", Offset = "0x2CC421C", VA = "0x2CC821C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x2CC8224", Offset = "0x2CC4224", VA = "0x2CC8224")]
		public VolumeComponentMenuForRenderPipeline(string menu, params Type[] pipelineTypes)
		{
		}
	}
	[Token(Token = "0x2000194")]
	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("VolumeComponentDeprecated has been deprecated (UnityUpgradable) -> [UnityEngine] UnityEngine.HideInInspector", false)]
	public sealed class VolumeComponentDeprecated : Attribute
	{
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x2CC83F8", Offset = "0x2CC43F8", VA = "0x2CC83F8")]
		public VolumeComponentDeprecated()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000195")]
	public class VolumeComponent : ScriptableObject
	{
		[Token(Token = "0x2000196")]
		public sealed class Indent : PropertyAttribute
		{
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly int relativeAmount;

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x2CC966C", Offset = "0x2CC566C", VA = "0x2CC966C")]
			public Indent(int relativeAmount = 1)
			{
			}
		}

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool active;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal readonly List<VolumeParameter> parameterList;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ReadOnlyCollection<VolumeParameter> m_ParameterReadOnlyCollection;

		[Token(Token = "0x17000177")]
		public string displayName
		{
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x2CC8400", Offset = "0x2CC4400", VA = "0x2CC8400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x2CC8408", Offset = "0x2CC4408", VA = "0x2CC8408")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public ReadOnlyCollection<VolumeParameter> parameters
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x2CC8410", Offset = "0x2CC4410", VA = "0x2CC8410")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x2CC8470", Offset = "0x2CC4470", VA = "0x2CC8470")]
		internal static void FindParameters(object o, List<VolumeParameter> parameters, [Optional] Func<FieldInfo, bool> filter)
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x2CC8A60", Offset = "0x2CC4A60", VA = "0x2CC8A60", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x2CC8C88", Offset = "0x2CC4C88", VA = "0x2CC8C88", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x2CC8DB4", Offset = "0x2CC4DB4", VA = "0x2CC8DB4", Slot = "6")]
		public virtual void Override(VolumeComponent state, float interpFactor)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x2CC8ED8", Offset = "0x2CC4ED8", VA = "0x2CC8ED8")]
		public void SetAllOverridesTo(bool state)
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x2CC8EE8", Offset = "0x2CC4EE8", VA = "0x2CC8EE8")]
		internal void SetOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state)
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x2CC93D4", Offset = "0x2CC53D4", VA = "0x2CC93D4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x2CC947C", Offset = "0x2CC547C", VA = "0x2CC947C")]
		public bool AnyPropertiesIsOverridden()
		{
			return default(bool);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x2CC9520", Offset = "0x2CC5520", VA = "0x2CC9520", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x2CC9524", Offset = "0x2CC5524", VA = "0x2CC9524")]
		public void Release()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x2CC95CC", Offset = "0x2CC55CC", VA = "0x2CC95CC")]
		public VolumeComponent()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public sealed class VolumeManager
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Lazy<VolumeManager> s_Instance;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, List<(string, Type)>> s_SupportedVolumeComponentsForRenderPipeline;

		[Token(Token = "0x400070F")]
		private const int k_MaxLayerCount = 32;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, List<Volume>> m_SortedVolumes;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<Volume> m_Volumes;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<int, bool> m_SortNeeded;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<VolumeComponent> m_ComponentsDefaultState;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<Collider> m_TempColliders;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private VolumeStack m_DefaultStack;

		[Token(Token = "0x17000179")]
		public static VolumeManager instance
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x2CC7930", Offset = "0x2CC3930", VA = "0x2CC7930")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		public VolumeStack stack
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x2CC971C", Offset = "0x2CC571C", VA = "0x2CC971C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x2CC9724", Offset = "0x2CC5724", VA = "0x2CC9724")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		[Obsolete("Please use baseComponentTypeArray instead.")]
		public IEnumerable<Type> baseComponentTypes
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x2CC972C", Offset = "0x2CC572C", VA = "0x2CC972C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x2CC9734", Offset = "0x2CC5734", VA = "0x2CC9734")]
			private set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		public Type[] baseComponentTypeArray
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x2CC9C84", Offset = "0x2CC5C84", VA = "0x2CC9C84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x2CC9C8C", Offset = "0x2CC5C8C", VA = "0x2CC9C8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x2CC9790", Offset = "0x2CC5790", VA = "0x2CC9790")]
		internal static List<(string, Type)> GetSupportedVolumeComponents(Type currentPipelineType)
		{
			return null;
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x2CC988C", Offset = "0x2CC588C", VA = "0x2CC988C")]
		private static List<(string, Type)> FilterVolumeComponentTypes(Type[] types, Type currentPipelineType)
		{
			return null;
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x2CC9C94", Offset = "0x2CC5C94", VA = "0x2CC9C94")]
		internal VolumeComponent GetDefaultVolumeComponent(Type volumeComponentType)
		{
			return null;
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x2CC9E30", Offset = "0x2CC5E30", VA = "0x2CC9E30")]
		private VolumeManager()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x2CCA2D4", Offset = "0x2CC62D4", VA = "0x2CCA2D4")]
		public VolumeStack CreateStack()
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x2CCA7E4", Offset = "0x2CC67E4", VA = "0x2CCA7E4")]
		public void ResetMainStack()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x2CCA7F0", Offset = "0x2CC67F0", VA = "0x2CCA7F0")]
		public void DestroyStack(VolumeStack stack)
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x2CC9FE4", Offset = "0x2CC5FE4", VA = "0x2CC9FE4")]
		private void ReloadBaseTypes()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x2CC79A8", Offset = "0x2CC39A8", VA = "0x2CC79A8")]
		public void Register(Volume volume, int layer)
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x2CC7CC4", Offset = "0x2CC3CC4", VA = "0x2CC7CC4")]
		public void Unregister(Volume volume, int layer)
		{
		}

		[Token(Token = "0x60009C9")]
		public bool IsComponentActiveInMask<T>(LayerMask layerMask) where T : VolumeComponent
		{
			return default(bool);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x2CC7FB8", Offset = "0x2CC3FB8", VA = "0x2CC7FB8")]
		internal void SetLayerDirty(int layer)
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x2CC8138", Offset = "0x2CC4138", VA = "0x2CC8138")]
		internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x2CCA808", Offset = "0x2CC6808", VA = "0x2CCA808")]
		private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x2CCA95C", Offset = "0x2CC695C", VA = "0x2CCA95C")]
		internal void ReplaceData(VolumeStack stack)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x2CCA9F4", Offset = "0x2CC69F4", VA = "0x2CCA9F4")]
		[Conditional("UNITY_EDITOR")]
		public void CheckBaseTypes()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x2CCAAB0", Offset = "0x2CC6AB0", VA = "0x2CCAAB0")]
		[Conditional("UNITY_EDITOR")]
		public void CheckStack(VolumeStack stack)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x2CCACB4", Offset = "0x2CC6CB4", VA = "0x2CCACB4")]
		private bool CheckUpdateRequired(VolumeStack stack)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x2CCAD30", Offset = "0x2CC6D30", VA = "0x2CCAD30")]
		public void Update(Transform trigger, LayerMask layerMask)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x2CCAD44", Offset = "0x2CC6D44", VA = "0x2CCAD44")]
		public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask)
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x2CCB450", Offset = "0x2CC7450", VA = "0x2CCB450")]
		public Volume[] GetVolumes(LayerMask layerMask)
		{
			return null;
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x2CCB154", Offset = "0x2CC7154", VA = "0x2CCB154")]
		private List<Volume> GrabVolumes(LayerMask mask)
		{
			return null;
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x2CCB584", Offset = "0x2CC7584", VA = "0x2CCB584")]
		private static void SortByPriority(List<Volume> volumes)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x2CCB6B8", Offset = "0x2CC76B8", VA = "0x2CCB6B8")]
		private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200019A")]
	[Obsolete("VolumeIsolationScope is deprecated, it does not have any effect anymore.")]
	public struct VolumeIsolationScope : IDisposable
	{
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x2CCB95C", Offset = "0x2CC795C", VA = "0x2CCB95C")]
		public VolumeIsolationScope(bool unused)
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x2CCB960", Offset = "0x2CC7960", VA = "0x2CCB960", Slot = "4")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public abstract class VolumeParameter : ICloneable
	{
		[Token(Token = "0x400071A")]
		public const string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected bool m_OverrideState;

		[Token(Token = "0x1700017D")]
		public virtual bool overrideState
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x2CCB964", Offset = "0x2CC7964", VA = "0x2CCB964", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x2CCB96C", Offset = "0x2CC796C", VA = "0x2CCB96C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x60009E2")]
		internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t);

		[Token(Token = "0x60009E3")]
		public T GetValue<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x60009E4")]
		public abstract void SetValue(VolumeParameter parameter);

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x2CCB974", Offset = "0x2CC7974", VA = "0x2CCB974", Slot = "9")]
		protected internal virtual void OnEnable()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x2CCB978", Offset = "0x2CC7978", VA = "0x2CCB978", Slot = "10")]
		protected internal virtual void OnDisable()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x2CC92A0", Offset = "0x2CC52A0", VA = "0x2CC92A0")]
		public static bool IsObjectParameter(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x2CCB97C", Offset = "0x2CC797C", VA = "0x2CCB97C", Slot = "11")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x60009E9")]
		public abstract object Clone();

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x2CCB980", Offset = "0x2CC7980", VA = "0x2CCB980")]
		protected VolumeParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200019C")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class VolumeParameter<T> : VolumeParameter, IEquatable<VolumeParameter<T>>
	{
		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected T m_Value;

		[Token(Token = "0x1700017E")]
		public virtual T value
		{
			[Token(Token = "0x60009EB")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60009EC")]
			set
			{
			}
		}

		[Token(Token = "0x60009ED")]
		public VolumeParameter()
		{
		}

		[Token(Token = "0x60009EE")]
		protected VolumeParameter(T value, bool overrideState)
		{
		}

		[Token(Token = "0x60009EF")]
		internal override void Interp(VolumeParameter from, VolumeParameter to, float t)
		{
		}

		[Token(Token = "0x60009F0")]
		public virtual void Interp(T from, T to, float t)
		{
		}

		[Token(Token = "0x60009F1")]
		public void Override(T x)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60009F2")]
		public override void SetValue(VolumeParameter parameter)
		{
		}

		[Token(Token = "0x60009F3")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009F4")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009F5")]
		public static bool operator ==(VolumeParameter<T> lhs, T rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F6")]
		public static bool operator !=(VolumeParameter<T> lhs, T rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F7")]
		public bool Equals(VolumeParameter<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F8")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F9")]
		public override object Clone()
		{
			return null;
		}

		[Token(Token = "0x60009FA")]
		public static explicit operator T(VolumeParameter<T> prop)
		{
			return (T)null;
		}
	}
	[Serializable]
	[Token(Token = "0x200019D")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class BoolParameter : VolumeParameter<bool>
	{
		[Token(Token = "0x200019E")]
		public enum DisplayType
		{
			[Token(Token = "0x400071F")]
			Checkbox,
			[Token(Token = "0x4000720")]
			EnumPopup
		}

		[NonSerialized]
		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public DisplayType displayType;

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x2CCB988", Offset = "0x2CC7988", VA = "0x2CCB988")]
		public BoolParameter(bool value, bool overrideState = false)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x2CCB9E8", Offset = "0x2CC79E8", VA = "0x2CCB9E8")]
		public BoolParameter(bool value, DisplayType displayType, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200019F")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class LayerMaskParameter : VolumeParameter<LayerMask>
	{
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x2CCBA5C", Offset = "0x2CC7A5C", VA = "0x2CCBA5C")]
		public LayerMaskParameter(LayerMask value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A0")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class IntParameter : VolumeParameter<int>
	{
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x2CCBABC", Offset = "0x2CC7ABC", VA = "0x2CCBABC")]
		public IntParameter(int value, bool overrideState = false)
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x2CCBB1C", Offset = "0x2CC7B1C", VA = "0x2CCBB1C", Slot = "16")]
		public sealed override void Interp(int from, int to, float t)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A1")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpIntParameter : VolumeParameter<int>
	{
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x2CCBB50", Offset = "0x2CC7B50", VA = "0x2CCBB50")]
		public NoInterpIntParameter(int value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A2")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class MinIntParameter : IntParameter
	{
		[NonSerialized]
		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int min;

		[Token(Token = "0x1700017F")]
		public override int value
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x2CCBBB0", Offset = "0x2CC7BB0", VA = "0x2CCBBB0", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x2CCBBB8", Offset = "0x2CC7BB8", VA = "0x2CCBBB8", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x2CCBBCC", Offset = "0x2CC7BCC", VA = "0x2CCBBCC")]
		public MinIntParameter(int value, int min, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A3")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpMinIntParameter : VolumeParameter<int>
	{
		[NonSerialized]
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int min;

		[Token(Token = "0x17000180")]
		public override int value
		{
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x2CCBBF4", Offset = "0x2CC7BF4", VA = "0x2CCBBF4", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x2CCBBFC", Offset = "0x2CC7BFC", VA = "0x2CCBBFC", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x2CCBC10", Offset = "0x2CC7C10", VA = "0x2CCBC10")]
		public NoInterpMinIntParameter(int value, int min, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A4")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class MaxIntParameter : IntParameter
	{
		[NonSerialized]
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int max;

		[Token(Token = "0x17000181")]
		public override int value
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x2CCBC84", Offset = "0x2CC7C84", VA = "0x2CCBC84", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x2CCBC8C", Offset = "0x2CC7C8C", VA = "0x2CCBC8C", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x2CCBCA0", Offset = "0x2CC7CA0", VA = "0x2CCBCA0")]
		public MaxIntParameter(int value, int max, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A5")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpMaxIntParameter : VolumeParameter<int>
	{
		[NonSerialized]
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int max;

		[Token(Token = "0x17000182")]
		public override int value
		{
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x2CCBCC8", Offset = "0x2CC7CC8", VA = "0x2CCBCC8", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x2CCBCD0", Offset = "0x2CC7CD0", VA = "0x2CCBCD0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x2CCBCE4", Offset = "0x2CC7CE4", VA = "0x2CCBCE4")]
		public NoInterpMaxIntParameter(int value, int max, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A6")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class ClampedIntParameter : IntParameter
	{
		[NonSerialized]
		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int min;

		[NonSerialized]
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int max;

		[Token(Token = "0x17000183")]
		public override int value
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x2CCBD58", Offset = "0x2CC7D58", VA = "0x2CCBD58", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x2CCBD60", Offset = "0x2CC7D60", VA = "0x2CCBD60", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x2CCBD7C", Offset = "0x2CC7D7C", VA = "0x2CCBD7C")]
		public ClampedIntParameter(int value, int min, int max, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A7")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpClampedIntParameter : VolumeParameter<int>
	{
		[NonSerialized]
		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int min;

		[NonSerialized]
		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int max;

		[Token(Token = "0x17000184")]
		public override int value
		{
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x2CCBDA8", Offset = "0x2CC7DA8", VA = "0x2CCBDA8", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x2CCBDB0", Offset = "0x2CC7DB0", VA = "0x2CCBDB0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x2CCBDCC", Offset = "0x2CC7DCC", VA = "0x2CCBDCC")]
		public NoInterpClampedIntParameter(int value, int min, int max, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A8")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class FloatParameter : VolumeParameter<float>
	{
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x2CCBE44", Offset = "0x2CC7E44", VA = "0x2CCBE44")]
		public FloatParameter(float value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x2CCBEAC", Offset = "0x2CC7EAC", VA = "0x2CCBEAC", Slot = "16")]
		public sealed override void Interp(float from, float to, float t)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A9")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpFloatParameter : VolumeParameter<float>
	{
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x2CCBEC0", Offset = "0x2CC7EC0", VA = "0x2CCBEC0")]
		public NoInterpFloatParameter(float value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001AA")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class MinFloatParameter : FloatParameter
	{
		[NonSerialized]
		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float min;

		[Token(Token = "0x17000185")]
		public override float value
		{
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x2CCBF28", Offset = "0x2CC7F28", VA = "0x2CCBF28", Slot = "14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x2CCBF30", Offset = "0x2CC7F30", VA = "0x2CCBF30", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x2CCBF44", Offset = "0x2CC7F44", VA = "0x2CCBF44")]
		public MinFloatParameter(float value, float min, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001AB")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpMinFloatParameter : VolumeParameter<float>
	{
		[NonSerialized]
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float min;

		[Token(Token = "0x17000186")]
		public override float value
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x2CCBF68", Offset = "0x2CC7F68", VA = "0x2CCBF68", Slot = "14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x2CCBF70", Offset = "0x2CC7F70", VA = "0x2CCBF70", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x2CCBF84", Offset = "0x2CC7F84", VA = "0x2CCBF84")]
		public NoInterpMinFloatParameter(float value, float min, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001AC")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class MaxFloatParameter : FloatParameter
	{
		[NonSerialized]
		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float max;

		[Token(Token = "0x17000187")]
		public override float value
		{
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x2CCBFF8", Offset = "0x2CC7FF8", VA = "0x2CCBFF8", Slot = "14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x2CCC000", Offset = "0x2CC8000", VA = "0x2CCC000", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x2CCC014", Offset = "0x2CC8014", VA = "0x2CCC014")]
		public MaxFloatParameter(float value, float max, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001AD")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpMaxFloatParameter : VolumeParameter<float>
	{
		[NonSerialized]
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float max;

		[Token(Token = "0x17000188")]
		public override float value
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x2CCC038", Offset = "0x2CC8038", VA = "0x2CCC038", Slot = "14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x2CCC040", Offset = "0x2CC8040", VA = "0x2CCC040", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x2CCC054", Offset = "0x2CC8054", VA = "0x2CCC054")]
		public NoInterpMaxFloatParameter(float value, float max, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001AE")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class ClampedFloatParameter : FloatParameter
	{
		[NonSerialized]
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float min;

		[NonSerialized]
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float max;

		[Token(Token = "0x17000189")]
		public override float value
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x2CCC0C8", Offset = "0x2CC80C8", VA = "0x2CCC0C8", Slot = "14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x2CCC0D0", Offset = "0x2CC80D0", VA = "0x2CCC0D0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x2CCC0EC", Offset = "0x2CC80EC", VA = "0x2CCC0EC")]
		public ClampedFloatParameter(float value, float min, float max, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001AF")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpClampedFloatParameter : VolumeParameter<float>
	{
		[NonSerialized]
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float min;

		[NonSerialized]
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float max;

		[Token(Token = "0x1700018A")]
		public override float value
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x2CCC114", Offset = "0x2CC8114", VA = "0x2CCC114", Slot = "14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x2CCC11C", Offset = "0x2CC811C", VA = "0x2CCC11C", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x2CCC138", Offset = "0x2CC8138", VA = "0x2CCC138")]
		public NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B0")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class FloatRangeParameter : VolumeParameter<Vector2>
	{
		[NonSerialized]
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float min;

		[NonSerialized]
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float max;

		[Token(Token = "0x1700018B")]
		public override Vector2 value
		{
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x2CCC1B8", Offset = "0x2CC81B8", VA = "0x2CCC1B8", Slot = "14")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x2CCC1C0", Offset = "0x2CC81C0", VA = "0x2CCC1C0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x2CCC1EC", Offset = "0x2CC81EC", VA = "0x2CCC1EC")]
		public FloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x2CCC274", Offset = "0x2CC8274", VA = "0x2CCC274", Slot = "16")]
		public override void Interp(Vector2 from, Vector2 to, float t)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B1")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpFloatRangeParameter : VolumeParameter<Vector2>
	{
		[NonSerialized]
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float min;

		[NonSerialized]
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float max;

		[Token(Token = "0x1700018C")]
		public override Vector2 value
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x2CCC294", Offset = "0x2CC8294", VA = "0x2CCC294", Slot = "14")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x2CCC29C", Offset = "0x2CC829C", VA = "0x2CCC29C", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x2CCC2C8", Offset = "0x2CC82C8", VA = "0x2CCC2C8")]
		public NoInterpFloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B2")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class ColorParameter : VolumeParameter<Color>
	{
		[NonSerialized]
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool hdr;

		[NonSerialized]
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool showAlpha;

		[NonSerialized]
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool showEyeDropper;

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x2CCC350", Offset = "0x2CC8350", VA = "0x2CCC350")]
		public ColorParameter(Color value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x2CCC3E0", Offset = "0x2CC83E0", VA = "0x2CCC3E0")]
		public ColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x2CCC4B0", Offset = "0x2CC84B0", VA = "0x2CCC4B0", Slot = "16")]
		public override void Interp(Color from, Color to, float t)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B3")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpColorParameter : VolumeParameter<Color>
	{
		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool hdr;

		[NonSerialized]
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool showAlpha;

		[NonSerialized]
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool showEyeDropper;

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x2CCC4E0", Offset = "0x2CC84E0", VA = "0x2CCC4E0")]
		public NoInterpColorParameter(Color value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x2CCC570", Offset = "0x2CC8570", VA = "0x2CCC570")]
		public NoInterpColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B4")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class Vector2Parameter : VolumeParameter<Vector2>
	{
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x2CCC640", Offset = "0x2CC8640", VA = "0x2CCC640")]
		public Vector2Parameter(Vector2 value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x2CCC6B0", Offset = "0x2CC86B0", VA = "0x2CCC6B0", Slot = "16")]
		public override void Interp(Vector2 from, Vector2 to, float t)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B5")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpVector2Parameter : VolumeParameter<Vector2>
	{
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x2CCC6D0", Offset = "0x2CC86D0", VA = "0x2CCC6D0")]
		public NoInterpVector2Parameter(Vector2 value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B6")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class Vector3Parameter : VolumeParameter<Vector3>
	{
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x2CCC740", Offset = "0x2CC8740", VA = "0x2CCC740")]
		public Vector3Parameter(Vector3 value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x2CCC7C0", Offset = "0x2CC87C0", VA = "0x2CCC7C0", Slot = "16")]
		public override void Interp(Vector3 from, Vector3 to, float t)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B7")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpVector3Parameter : VolumeParameter<Vector3>
	{
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x2CCC7F0", Offset = "0x2CC87F0", VA = "0x2CCC7F0")]
		public NoInterpVector3Parameter(Vector3 value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B8")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class Vector4Parameter : VolumeParameter<Vector4>
	{
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x2CCC870", Offset = "0x2CC8870", VA = "0x2CCC870")]
		public Vector4Parameter(Vector4 value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x2CCC8F8", Offset = "0x2CC88F8", VA = "0x2CCC8F8", Slot = "16")]
		public override void Interp(Vector4 from, Vector4 to, float t)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B9")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpVector4Parameter : VolumeParameter<Vector4>
	{
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x2CCC928", Offset = "0x2CC8928", VA = "0x2CCC928")]
		public NoInterpVector4Parameter(Vector4 value, bool overrideState = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001BA")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class TextureParameter : VolumeParameter<Texture>
	{
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureDimension dimension;

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x2CCC9B0", Offset = "0x2CC89B0", VA = "0x2CCC9B0")]
		public TextureParameter(Texture value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x2CCC9BC", Offset = "0x2CC89BC", VA = "0x2CCC9BC")]
		public TextureParameter(Texture value, TextureDimension dimension, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x2CCCA30", Offset = "0x2CC8A30", VA = "0x2CCCA30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001BB")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpTextureParameter : VolumeParameter<Texture>
	{
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x2CCCB34", Offset = "0x2CC8B34", VA = "0x2CCCB34")]
		public NoInterpTextureParameter(Texture value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x2CCCB94", Offset = "0x2CC8B94", VA = "0x2CCCB94", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001BC")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class Texture2DParameter : VolumeParameter<Texture>
	{
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x2CCCC98", Offset = "0x2CC8C98", VA = "0x2CCCC98")]
		public Texture2DParameter(Texture value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x2CCCCF8", Offset = "0x2CC8CF8", VA = "0x2CCCCF8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001BD")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class Texture3DParameter : VolumeParameter<Texture>
	{
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x2CCCDFC", Offset = "0x2CC8DFC", VA = "0x2CCCDFC")]
		public Texture3DParameter(Texture value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x2CCCE5C", Offset = "0x2CC8E5C", VA = "0x2CCCE5C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001BE")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class RenderTextureParameter : VolumeParameter<RenderTexture>
	{
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x2CCCF60", Offset = "0x2CC8F60", VA = "0x2CCCF60")]
		public RenderTextureParameter(RenderTexture value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x2CCCFC0", Offset = "0x2CC8FC0", VA = "0x2CCCFC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001BF")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpRenderTextureParameter : VolumeParameter<RenderTexture>
	{
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x2CCD0C4", Offset = "0x2CC90C4", VA = "0x2CCD0C4")]
		public NoInterpRenderTextureParameter(RenderTexture value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x2CCD124", Offset = "0x2CC9124", VA = "0x2CCD124", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001C0")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class CubemapParameter : VolumeParameter<Texture>
	{
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x2CCD228", Offset = "0x2CC9228", VA = "0x2CCD228")]
		public CubemapParameter(Texture value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x2CCD288", Offset = "0x2CC9288", VA = "0x2CCD288", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001C1")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class NoInterpCubemapParameter : VolumeParameter<Cubemap>
	{
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x2CCD38C", Offset = "0x2CC938C", VA = "0x2CCD38C")]
		public NoInterpCubemapParameter(Cubemap value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x2CCD3EC", Offset = "0x2CC93EC", VA = "0x2CCD3EC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001C2")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class ObjectParameter<T> : VolumeParameter<T>
	{
		[Token(Token = "0x1700018D")]
		internal ReadOnlyCollection<VolumeParameter> parameters
		{
			[Token(Token = "0x6000A4E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public sealed override bool overrideState
		{
			[Token(Token = "0x6000A50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A51")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		public sealed override T value
		{
			[Token(Token = "0x6000A52")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000A53")]
			set
			{
			}
		}

		[Token(Token = "0x6000A54")]
		public ObjectParameter(T value)
		{
		}

		[Token(Token = "0x6000A55")]
		internal override void Interp(VolumeParameter from, VolumeParameter to, float t)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001C4")]
	public class AnimationCurveParameter : VolumeParameter<AnimationCurve>
	{
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x2CCD4F0", Offset = "0x2CC94F0", VA = "0x2CCD4F0")]
		public AnimationCurveParameter(AnimationCurve value, bool overrideState = false)
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x2CCD550", Offset = "0x2CC9550", VA = "0x2CCD550", Slot = "16")]
		public override void Interp(AnimationCurve lhsCurve, AnimationCurve rhsCurve, float t)
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x2CCD55C", Offset = "0x2CC955C", VA = "0x2CCD55C", Slot = "8")]
		public override void SetValue(VolumeParameter parameter)
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x2CCD5EC", Offset = "0x2CC95EC", VA = "0x2CCD5EC", Slot = "12")]
		public override object Clone()
		{
			return null;
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x2CCD6CC", Offset = "0x2CC96CC", VA = "0x2CCD6CC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001C5")]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class MaterialParameter : VolumeParameter<Material>
	{
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x2CCD780", Offset = "0x2CC9780", VA = "0x2CCD780")]
		public MaterialParameter(Material value, bool overrideState = false)
		{
		}
	}
	[Token(Token = "0x20001C6")]
	public sealed class VolumeProfile : ScriptableObject
	{
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<VolumeComponent> components;

		[NonSerialized]
		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isDirty;

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x2CCD7E0", Offset = "0x2CC97E0", VA = "0x2CCD7E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x2CCD8DC", Offset = "0x2CC98DC", VA = "0x2CCD8DC")]
		internal void OnDisable()
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x2CCD9C0", Offset = "0x2CC99C0", VA = "0x2CCD9C0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000A64")]
		public T Add<T>(bool overrides = false) where T : VolumeComponent
		{
			return null;
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x2CCD9CC", Offset = "0x2CC99CC", VA = "0x2CCD9CC")]
		public VolumeComponent Add(Type type, bool overrides = false)
		{
			return null;
		}

		[Token(Token = "0x6000A66")]
		public void Remove<T>() where T : VolumeComponent
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x2CCDCDC", Offset = "0x2CC9CDC", VA = "0x2CCDCDC")]
		public void Remove(Type type)
		{
		}

		[Token(Token = "0x6000A68")]
		public bool Has<T>() where T : VolumeComponent
		{
			return default(bool);
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x2CCDB48", Offset = "0x2CC9B48", VA = "0x2CCDB48")]
		public bool Has(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x2CCDDF0", Offset = "0x2CC9DF0", VA = "0x2CCDDF0")]
		public bool HasSubclassOf(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6B")]
		public bool TryGet<T>(out T component) where T : VolumeComponent
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6C")]
		public bool TryGet<T>(Type type, out T component) where T : VolumeComponent
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6D")]
		public bool TryGetSubclassOf<T>(Type type, out T component) where T : VolumeComponent
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6E")]
		public bool TryGetAllSubclassOf<T>(Type type, List<T> result) where T : VolumeComponent
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x2CCDF60", Offset = "0x2CC9F60", VA = "0x2CCDF60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x2CCE008", Offset = "0x2CCA008", VA = "0x2CCE008")]
		internal int GetComponentListHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x2CCE0BC", Offset = "0x2CCA0BC", VA = "0x2CCE0BC")]
		internal void Sanitize()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x2CCE1B8", Offset = "0x2CCA1B8", VA = "0x2CCE1B8")]
		public VolumeProfile()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public sealed class VolumeStack : IDisposable
	{
		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal readonly Dictionary<Type, VolumeComponent> components;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal (VolumeParameter parameter, VolumeParameter defaultValue)[] defaultParameters;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool requiresReset;

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x2CCA33C", Offset = "0x2CC633C", VA = "0x2CCA33C")]
		internal VolumeStack()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x2CCE2FC", Offset = "0x2CCA2FC", VA = "0x2CCE2FC")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x2CCA3C0", Offset = "0x2CC63C0", VA = "0x2CCA3C0")]
		internal void Reload(List<VolumeComponent> componentDefaultStates)
		{
		}

		[Token(Token = "0x6000A79")]
		public T GetComponent<T>() where T : VolumeComponent
		{
			return null;
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x2CCA8EC", Offset = "0x2CC68EC", VA = "0x2CCA8EC")]
		public VolumeComponent GetComponent(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x2CCA804", Offset = "0x2CC6804", VA = "0x2CCA804", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	public static class XRGraphicsAutomatedTests
	{
		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool running;

		[Token(Token = "0x17000190")]
		private static bool activatedFromCommandLine
		{
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x2CCE4E4", Offset = "0x2CCA4E4", VA = "0x2CCE4E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000191")]
		public static bool enabled
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x2CCE4EC", Offset = "0x2CCA4EC", VA = "0x2CCE4EC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x2CCE544", Offset = "0x2CCA544", VA = "0x2CCE544")]
		internal static void OverrideLayout(XRLayout layout, Camera camera)
		{
		}
	}
}
namespace UnityEngine.Rendering.LookDev
{
	[Token(Token = "0x20001CA")]
	public interface IDataProvider
	{
		[Token(Token = "0x17000192")]
		IEnumerable<string> supportedDebugModes
		{
			[Token(Token = "0x6000A82")]
			get;
		}

		[Token(Token = "0x6000A80")]
		void FirstInitScene(StageRuntimeInterface stage);

		[Token(Token = "0x6000A81")]
		void UpdateSky(Camera camera, Sky sky, StageRuntimeInterface stage);

		[Token(Token = "0x6000A83")]
		void UpdateDebugMode(int debugIndex);

		[Token(Token = "0x6000A84")]
		void GetShadowMask(ref RenderTexture output, StageRuntimeInterface stage);

		[Token(Token = "0x6000A85")]
		void OnBeginRendering(StageRuntimeInterface stage);

		[Token(Token = "0x6000A86")]
		void OnEndRendering(StageRuntimeInterface stage);

		[Token(Token = "0x6000A87")]
		void Cleanup(StageRuntimeInterface SRI);
	}
	[Token(Token = "0x20001CB")]
	public struct Sky
	{
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Cubemap cubemap;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float longitudeOffset;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float exposure;
	}
	[Token(Token = "0x20001CC")]
	public class StageRuntimeInterface
	{
		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Func<bool, GameObject> m_AddGameObject;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Func<Camera> m_GetCamera;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Func<Light> m_GetSunLight;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object SRPData;

		[Token(Token = "0x17000193")]
		public Camera camera
		{
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x2CCEA98", Offset = "0x2CCAA98", VA = "0x2CCEA98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000194")]
		public Light sunLight
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x2CCEAB8", Offset = "0x2CCAAB8", VA = "0x2CCEAB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x2CCEA38", Offset = "0x2CCAA38", VA = "0x2CCEA38")]
		public StageRuntimeInterface(Func<bool, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight)
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x2CCEA74", Offset = "0x2CCAA74", VA = "0x2CCEA74")]
		public GameObject AddGameObject(bool persistent = false)
		{
			return null;
		}
	}
}
namespace UnityEngine.Rendering.UI
{
	[Token(Token = "0x20001CD")]
	public class DebugUIHandlerBitField : DebugUIHandlerWidget
	{
		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UIFoldout valueToggle;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DebugUIHandlerIndirectToggle> toggles;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DebugUI.BitField m_Field;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DebugUIHandlerContainer m_Container;

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x2CCEAD8", Offset = "0x2CCAAD8", VA = "0x2CCEAD8", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x2CCEEB8", Offset = "0x2CCAEB8", VA = "0x2CCEEB8")]
		private bool GetValue(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x2CCEF60", Offset = "0x2CCAF60", VA = "0x2CCEF60")]
		private void SetValue(int index, bool value)
		{
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x2CCF2C8", Offset = "0x2CCB2C8", VA = "0x2CCF2C8", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x2CCF53C", Offset = "0x2CCB53C", VA = "0x2CCF53C", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x2CCF568", Offset = "0x2CCB568", VA = "0x2CCF568", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x2CCF584", Offset = "0x2CCB584", VA = "0x2CCF584", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x2CCF5A0", Offset = "0x2CCB5A0", VA = "0x2CCF5A0", Slot = "8")]
		public override void OnAction()
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x2CCF5C4", Offset = "0x2CCB5C4", VA = "0x2CCF5C4", Slot = "12")]
		public override DebugUIHandlerWidget Next()
		{
			return null;
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x2CCF720", Offset = "0x2CCB720", VA = "0x2CCF720")]
		public DebugUIHandlerBitField()
		{
		}
	}
	[Token(Token = "0x20001CE")]
	public class DebugUIHandlerButton : DebugUIHandlerWidget
	{
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private DebugUI.Button m_Field;

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x2CCF728", Offset = "0x2CCB728", VA = "0x2CCF728", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x2CCF7AC", Offset = "0x2CCB7AC", VA = "0x2CCF7AC", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x2CCF7E4", Offset = "0x2CCB7E4", VA = "0x2CCF7E4", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x2CCF810", Offset = "0x2CCB810", VA = "0x2CCF810", Slot = "8")]
		public override void OnAction()
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x2CCF83C", Offset = "0x2CCB83C", VA = "0x2CCF83C")]
		public DebugUIHandlerButton()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001CF")]
	public class DebugUIPrefabBundle
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string type;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform prefab;

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x2CCF844", Offset = "0x2CCB844", VA = "0x2CCF844")]
		public DebugUIPrefabBundle()
		{
		}
	}
	[Token(Token = "0x20001D0")]
	public class DebugUIHandlerCanvas : MonoBehaviour
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_DebugTreeState;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<Type, Transform> m_PrefabsMap;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform panelPrefab;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<DebugUIPrefabBundle> prefabs;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<DebugUIHandlerPanel> m_UIPanels;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_SelectedPanel;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DebugUIHandlerWidget m_SelectedWidget;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string m_CurrentQueryPath;

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x2CCF84C", Offset = "0x2CCB84C", VA = "0x2CCF84C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x2CCF98C", Offset = "0x2CCB98C", VA = "0x2CCF98C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x2CD0128", Offset = "0x2CCC128", VA = "0x2CD0128")]
		internal void RequestHierarchyReset()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x2CCFAB4", Offset = "0x2CCBAB4", VA = "0x2CCFAB4")]
		private void ResetAllHierarchy()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x2CD0134", Offset = "0x2CCC134", VA = "0x2CD0134")]
		private void Rebuild()
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x2CD0B00", Offset = "0x2CCCB00", VA = "0x2CD0B00")]
		private void Traverse(DebugUI.IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler, ref DebugUIHandlerWidget selectedHandler)
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x2CD1144", Offset = "0x2CCD144", VA = "0x2CD1144")]
		private DebugUIHandlerWidget GetWidgetFromPath(string queryPath)
		{
			return null;
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x2CD0F48", Offset = "0x2CCCF48", VA = "0x2CD0F48")]
		private void ActivatePanel(int index, [Optional] DebugUIHandlerWidget selectedWidget)
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x2CD12E4", Offset = "0x2CCD2E4", VA = "0x2CD12E4")]
		internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext)
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x2CD15F4", Offset = "0x2CCD5F4", VA = "0x2CD15F4")]
		internal void SelectPreviousItem()
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x2CD16B8", Offset = "0x2CCD6B8", VA = "0x2CD16B8")]
		internal void SelectNextPanel()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x2CD172C", Offset = "0x2CCD72C", VA = "0x2CD172C")]
		internal void SelectPreviousPanel()
		{
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x2CD1530", Offset = "0x2CCD530", VA = "0x2CD1530")]
		internal void SelectNextItem()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x2CD17AC", Offset = "0x2CCD7AC", VA = "0x2CD17AC")]
		private void ChangeSelectionValue(float multiplier)
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x2CD18B0", Offset = "0x2CCD8B0", VA = "0x2CD18B0")]
		private void ActivateSelection()
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x2CCFD94", Offset = "0x2CCBD94", VA = "0x2CCFD94")]
		private void HandleInput()
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x2CD1458", Offset = "0x2CCD458", VA = "0x2CD1458")]
		internal void SetScrollTarget(DebugUIHandlerWidget widget)
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x2CD1938", Offset = "0x2CCD938", VA = "0x2CD1938")]
		public DebugUIHandlerCanvas()
		{
		}
	}
	[Token(Token = "0x20001D3")]
	public class DebugUIHandlerColor : DebugUIHandlerWidget
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UIFoldout valueToggle;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Image colorImage;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DebugUIHandlerIndirectFloatField fieldR;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DebugUIHandlerIndirectFloatField fieldG;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DebugUIHandlerIndirectFloatField fieldB;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public DebugUIHandlerIndirectFloatField fieldA;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private DebugUI.ColorField m_Field;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DebugUIHandlerContainer m_Container;

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x2CD1A40", Offset = "0x2CCDA40", VA = "0x2CD1A40", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x2CD1F60", Offset = "0x2CCDF60", VA = "0x2CD1F60")]
		private void SetValue(float x, bool r = false, bool g = false, bool b = false, bool a = false)
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x2CD1DAC", Offset = "0x2CCDDAC", VA = "0x2CD1DAC")]
		private void SetupSettings(DebugUIHandlerIndirectFloatField field)
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x2CD2020", Offset = "0x2CCE020", VA = "0x2CD2020", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x2CD2104", Offset = "0x2CCE104", VA = "0x2CD2104", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x2CD2130", Offset = "0x2CCE130", VA = "0x2CD2130", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x2CD214C", Offset = "0x2CCE14C", VA = "0x2CD214C", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x2CD2168", Offset = "0x2CCE168", VA = "0x2CD2168", Slot = "8")]
		public override void OnAction()
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x2CD1EAC", Offset = "0x2CCDEAC", VA = "0x2CD1EAC")]
		internal void UpdateColor()
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x2CD218C", Offset = "0x2CCE18C", VA = "0x2CD218C", Slot = "12")]
		public override DebugUIHandlerWidget Next()
		{
			return null;
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x2CD2258", Offset = "0x2CCE258", VA = "0x2CD2258")]
		public DebugUIHandlerColor()
		{
		}
	}
	[Token(Token = "0x20001D4")]
	public class DebugUIHandlerContainer : MonoBehaviour
	{
		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public RectTransform contentHolder;

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x2CCF690", Offset = "0x2CCB690", VA = "0x2CCF690")]
		internal DebugUIHandlerWidget GetFirstItem()
		{
			return null;
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x2CCF4AC", Offset = "0x2CCB4AC", VA = "0x2CCF4AC")]
		internal DebugUIHandlerWidget GetLastItem()
		{
			return null;
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x2CCF3AC", Offset = "0x2CCB3AC", VA = "0x2CCF3AC")]
		internal bool IsDirectChild(DebugUIHandlerWidget widget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x2CD2454", Offset = "0x2CCE454", VA = "0x2CD2454")]
		private List<DebugUIHandlerWidget> GetActiveChildren()
		{
			return null;
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x2CD2848", Offset = "0x2CCE848", VA = "0x2CD2848")]
		public DebugUIHandlerContainer()
		{
		}
	}
	[Token(Token = "0x20001D6")]
	public class DebugUIHandlerEnumField : DebugUIHandlerField<DebugUI.EnumField>
	{
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x2CD28BC", Offset = "0x2CCE8BC", VA = "0x2CD28BC", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x2CD2A2C", Offset = "0x2CCEA2C", VA = "0x2CD2A2C", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x2CD2BD0", Offset = "0x2CCEBD0", VA = "0x2CD2BD0", Slot = "13")]
		public override void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x2CD2C68", Offset = "0x2CCEC68", VA = "0x2CD2C68")]
		public DebugUIHandlerEnumField()
		{
		}
	}
	[Token(Token = "0x20001D7")]
	public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField
	{
		[Token(Token = "0x20001D8")]
		[CompilerGenerated]
		private sealed class <RefreshAfterSanitization>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DebugUIHandlerEnumHistory <>4__this;

			[Token(Token = "0x17000195")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ADC")]
				[Address(RVA = "0x2CD32B0", Offset = "0x2CCF2B0", VA = "0x2CD32B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000196")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ADE")]
				[Address(RVA = "0x2CD32F0", Offset = "0x2CCF2F0", VA = "0x2CD32F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x2CD31A4", Offset = "0x2CCF1A4", VA = "0x2CD31A4")]
			[DebuggerHidden]
			public <RefreshAfterSanitization>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x2CD31D0", Offset = "0x2CCF1D0", VA = "0x2CD31D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x2CD31D4", Offset = "0x2CCF1D4", VA = "0x2CD31D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x2CD32B8", Offset = "0x2CCF2B8", VA = "0x2CD32B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Text[] historyValues;

		[Token(Token = "0x4000771")]
		private const float k_XOffset = 230f;

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x2CD2CB0", Offset = "0x2CCECB0", VA = "0x2CD2CB0", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x2CD2F28", Offset = "0x2CCEF28", VA = "0x2CD2F28", Slot = "13")]
		public override void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x2CD3144", Offset = "0x2CCF144", VA = "0x2CD3144")]
		[IteratorStateMachine(typeof(<RefreshAfterSanitization>d__4))]
		private IEnumerator RefreshAfterSanitization()
		{
			return null;
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x2CD31CC", Offset = "0x2CCF1CC", VA = "0x2CD31CC")]
		public DebugUIHandlerEnumHistory()
		{
		}
	}
	[Token(Token = "0x20001D9")]
	public abstract class DebugUIHandlerField<T> : DebugUIHandlerWidget where T : DebugUI.Widget
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Text nextButtonText;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Text previousButtonText;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Text nameLabel;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Text valueLabel;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected internal T m_Field;

		[Token(Token = "0x6000ADF")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000AE0")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE1")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000AE2")]
		public override void OnAction()
		{
		}

		[Token(Token = "0x6000AE3")]
		public abstract void UpdateValueLabel();

		[Token(Token = "0x6000AE4")]
		protected void SetLabelText(string text)
		{
		}

		[Token(Token = "0x6000AE5")]
		protected DebugUIHandlerField()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	public class DebugUIHandlerFloatField : DebugUIHandlerWidget
	{
		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text valueLabel;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DebugUI.FloatField m_Field;

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x2CD32F8", Offset = "0x2CCF2F8", VA = "0x2CD32F8", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x2CD3448", Offset = "0x2CCF448", VA = "0x2CD3448", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x2CD34A0", Offset = "0x2CCF4A0", VA = "0x2CD34A0", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x2CD34F0", Offset = "0x2CCF4F0", VA = "0x2CD34F0", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x2CD3594", Offset = "0x2CCF594", VA = "0x2CD3594", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x2CD34F8", Offset = "0x2CCF4F8", VA = "0x2CD34F8")]
		private void ChangeValue(bool fast, float multiplier)
		{
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x2CD3384", Offset = "0x2CCF384", VA = "0x2CD3384")]
		private void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x2CD359C", Offset = "0x2CCF59C", VA = "0x2CD359C")]
		public DebugUIHandlerFloatField()
		{
		}
	}
	[Token(Token = "0x20001DB")]
	public class DebugUIHandlerFoldout : DebugUIHandlerWidget
	{
		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UIFoldout valueToggle;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DebugUI.Foldout m_Field;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DebugUIHandlerContainer m_Container;

		[Token(Token = "0x4000781")]
		private const float k_FoldoutXOffset = 215f;

		[Token(Token = "0x4000782")]
		private const float k_XOffset = 230f;

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x2CD35A4", Offset = "0x2CCF5A4", VA = "0x2CD35A4", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x2CD3910", Offset = "0x2CCF910", VA = "0x2CD3910", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x2CD39F4", Offset = "0x2CCF9F4", VA = "0x2CD39F4", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x2CD3A20", Offset = "0x2CCFA20", VA = "0x2CD3A20", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x2CD3A3C", Offset = "0x2CCFA3C", VA = "0x2CD3A3C", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x2CD3A54", Offset = "0x2CCFA54", VA = "0x2CD3A54", Slot = "8")]
		public override void OnAction()
		{
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x2CD38E8", Offset = "0x2CCF8E8", VA = "0x2CD38E8")]
		private void UpdateValue()
		{
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x2CD3A74", Offset = "0x2CCFA74", VA = "0x2CD3A74", Slot = "12")]
		public override DebugUIHandlerWidget Next()
		{
			return null;
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x2CD3B40", Offset = "0x2CCFB40", VA = "0x2CD3B40")]
		public DebugUIHandlerFoldout()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	public class DebugUIHandlerGroup : DebugUIHandlerWidget
	{
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform header;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DebugUI.Container m_Field;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DebugUIHandlerContainer m_Container;

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x2CD3B48", Offset = "0x2CCFB48", VA = "0x2CD3B48", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x2CD3C34", Offset = "0x2CCFC34", VA = "0x2CD3C34", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x2CD3CEC", Offset = "0x2CCFCEC", VA = "0x2CD3CEC", Slot = "12")]
		public override DebugUIHandlerWidget Next()
		{
			return null;
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x2CD3DA8", Offset = "0x2CCFDA8", VA = "0x2CD3DA8")]
		public DebugUIHandlerGroup()
		{
		}
	}
	[Token(Token = "0x20001DD")]
	public class DebugUIHandlerHBox : DebugUIHandlerWidget
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DebugUIHandlerContainer m_Container;

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x2CD3DB0", Offset = "0x2CCFDB0", VA = "0x2CD3DB0", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x2CD3E10", Offset = "0x2CCFE10", VA = "0x2CD3E10", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x2CD3EC8", Offset = "0x2CCFEC8", VA = "0x2CD3EC8", Slot = "12")]
		public override DebugUIHandlerWidget Next()
		{
			return null;
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x2CD3F84", Offset = "0x2CCFF84", VA = "0x2CD3F84")]
		public DebugUIHandlerHBox()
		{
		}
	}
	[Token(Token = "0x20001DE")]
	public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget
	{
		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text valueLabel;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Func<float> getter;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Action<float> setter;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Func<float> incStepGetter;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Func<float> incStepMultGetter;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Func<float> decimalsGetter;

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x2CD201C", Offset = "0x2CCE01C", VA = "0x2CD201C")]
		public void Init()
		{
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x2CD409C", Offset = "0x2CD009C", VA = "0x2CD409C", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x2CD40F4", Offset = "0x2CD00F4", VA = "0x2CD40F4", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x2CD4144", Offset = "0x2CD0144", VA = "0x2CD4144", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x2CD4204", Offset = "0x2CD0204", VA = "0x2CD4204", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x2CD414C", Offset = "0x2CD014C", VA = "0x2CD414C")]
		private void ChangeValue(bool fast, float multiplier)
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x2CD3F8C", Offset = "0x2CCFF8C", VA = "0x2CD3F8C")]
		private void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x2CD420C", Offset = "0x2CD020C", VA = "0x2CD420C")]
		public DebugUIHandlerIndirectFloatField()
		{
		}
	}
	[Token(Token = "0x20001DF")]
	public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Toggle valueToggle;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Image checkmarkImage;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Func<int, bool> getter;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Action<int, bool> setter;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal int index;

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x2CCEE0C", Offset = "0x2CCAE0C", VA = "0x2CCEE0C")]
		public void Init()
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x2CD4214", Offset = "0x2CD0214", VA = "0x2CD4214")]
		private void OnToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x2CD4240", Offset = "0x2CD0240", VA = "0x2CD4240", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x2CD4298", Offset = "0x2CD0298", VA = "0x2CD4298", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x2CD42E8", Offset = "0x2CD02E8", VA = "0x2CD42E8", Slot = "8")]
		public override void OnAction()
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x2CCF220", Offset = "0x2CCB220", VA = "0x2CCF220")]
		internal void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x2CD4344", Offset = "0x2CD0344", VA = "0x2CD4344")]
		public DebugUIHandlerIndirectToggle()
		{
		}
	}
	[Token(Token = "0x20001E0")]
	public class DebugUIHandlerIntField : DebugUIHandlerWidget
	{
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text valueLabel;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DebugUI.IntField m_Field;

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x2CD434C", Offset = "0x2CD034C", VA = "0x2CD434C", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x2CD44B8", Offset = "0x2CD04B8", VA = "0x2CD44B8", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x2CD4510", Offset = "0x2CD0510", VA = "0x2CD4510", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x2CD4560", Offset = "0x2CD0560", VA = "0x2CD4560", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x2CD4608", Offset = "0x2CD0608", VA = "0x2CD4608", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x2CD4568", Offset = "0x2CD0568", VA = "0x2CD4568")]
		private void ChangeValue(bool fast, int multiplier)
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x2CD43D8", Offset = "0x2CD03D8", VA = "0x2CD43D8")]
		private void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x2CD4610", Offset = "0x2CD0610", VA = "0x2CD4610")]
		public DebugUIHandlerIntField()
		{
		}
	}
	[Token(Token = "0x20001E1")]
	public class DebugUIHandlerMessageBox : DebugUIHandlerWidget
	{
		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private DebugUI.MessageBox m_Field;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Color32 k_WarningBackgroundColor;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Color32 k_WarningTextColor;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Color32 k_ErrorBackgroundColor;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Color32 k_ErrorTextColor;

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x2CD4618", Offset = "0x2CD0618", VA = "0x2CD4618", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x2CD4798", Offset = "0x2CD0798", VA = "0x2CD4798", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x2CD47A0", Offset = "0x2CD07A0", VA = "0x2CD47A0")]
		public DebugUIHandlerMessageBox()
		{
		}
	}
	[Token(Token = "0x20001E2")]
	public class DebugUIHandlerObject : DebugUIHandlerWidget
	{
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text valueLabel;

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x2CD4830", Offset = "0x2CD0830", VA = "0x2CD4830", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x2CD48FC", Offset = "0x2CD08FC", VA = "0x2CD48FC", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x2CD4954", Offset = "0x2CD0954", VA = "0x2CD4954", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x2CD49A4", Offset = "0x2CD09A4", VA = "0x2CD49A4")]
		public DebugUIHandlerObject()
		{
		}
	}
	[Token(Token = "0x20001E3")]
	public class DebugUIHandlerObjectList : DebugUIHandlerField<DebugUI.ObjectListField>
	{
		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int m_Index;

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x2CD49AC", Offset = "0x2CD09AC", VA = "0x2CD49AC", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x2CD4A0C", Offset = "0x2CD0A0C", VA = "0x2CD4A0C", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x2CD4A28", Offset = "0x2CD0A28", VA = "0x2CD4A28", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x2CD4A44", Offset = "0x2CD0A44", VA = "0x2CD4A44", Slot = "13")]
		public override void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x2CD4BB4", Offset = "0x2CD0BB4", VA = "0x2CD4BB4")]
		public DebugUIHandlerObjectList()
		{
		}
	}
	[Token(Token = "0x20001E4")]
	public class DebugUIHandlerObjectPopupField : DebugUIHandlerField<DebugUI.ObjectPopupField>
	{
		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int m_Index;

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x2CD4BFC", Offset = "0x2CD0BFC", VA = "0x2CD4BFC", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x2CD4C5C", Offset = "0x2CD0C5C", VA = "0x2CD4C5C")]
		private void ChangeSelectedObject()
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x2CD4D5C", Offset = "0x2CD0D5C", VA = "0x2CD4D5C", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x2CD4D6C", Offset = "0x2CD0D6C", VA = "0x2CD4D6C", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x2CD4D7C", Offset = "0x2CD0D7C", VA = "0x2CD4D7C", Slot = "13")]
		public override void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x2CD4E5C", Offset = "0x2CD0E5C", VA = "0x2CD4E5C")]
		public DebugUIHandlerObjectPopupField()
		{
		}
	}
	[Token(Token = "0x20001E5")]
	public class DebugUIHandlerPanel : MonoBehaviour
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text nameLabel;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ScrollRect scrollRect;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RectTransform viewport;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DebugUIHandlerCanvas Canvas;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform m_ScrollTransform;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform m_ContentTransform;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform m_MaskTransform;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DebugUIHandlerWidget m_ScrollTarget;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected internal DebugUI.Panel m_Panel;

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x2CD4EA4", Offset = "0x2CD0EA4", VA = "0x2CD4EA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x2CD0AD0", Offset = "0x2CCCAD0", VA = "0x2CD0AD0")]
		internal void SetPanel(DebugUI.Panel panel)
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x2CD4F5C", Offset = "0x2CD0F5C", VA = "0x2CD4F5C")]
		internal DebugUI.Panel GetPanel()
		{
			return null;
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x2CD4F64", Offset = "0x2CD0F64", VA = "0x2CD4F64")]
		public void SelectNextItem()
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x2CD4F78", Offset = "0x2CD0F78", VA = "0x2CD4F78")]
		public void SelectPreviousItem()
		{
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x2CD4F8C", Offset = "0x2CD0F8C", VA = "0x2CD4F8C")]
		public void OnScrollbarClicked()
		{
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x2CD4FF0", Offset = "0x2CD0FF0", VA = "0x2CD4FF0")]
		internal void SetScrollTarget(DebugUIHandlerWidget target)
		{
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x2CCFFA8", Offset = "0x2CCBFA8", VA = "0x2CCFFA8")]
		internal void UpdateScroll()
		{
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x2CD4FF8", Offset = "0x2CD0FF8", VA = "0x2CD4FF8")]
		private float GetYPosInScroll(RectTransform target)
		{
			return default(float);
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x2CD1290", Offset = "0x2CCD290", VA = "0x2CD1290")]
		internal DebugUIHandlerWidget GetFirstItem()
		{
			return null;
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x2CD50E4", Offset = "0x2CD10E4", VA = "0x2CD50E4")]
		public void ResetDebugManager()
		{
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x2CD5144", Offset = "0x2CD1144", VA = "0x2CD5144")]
		public DebugUIHandlerPanel()
		{
		}
	}
	[Token(Token = "0x20001E6")]
	internal class DebugUIHandlerPersistentCanvas : MonoBehaviour
	{
		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform panel;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform valuePrefab;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<DebugUIHandlerValue> m_Items;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<DebugUI.ValueTuple> m_ValueTupleWidgets;

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x2CD514C", Offset = "0x2CD114C", VA = "0x2CD514C")]
		internal void Toggle(DebugUI.Value widget, [Optional] string displayName)
		{
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x2CD5430", Offset = "0x2CD1430", VA = "0x2CD5430")]
		internal void Toggle(DebugUI.ValueTuple widget, [Optional] int? forceTupleIndex)
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x2CD57B4", Offset = "0x2CD17B4", VA = "0x2CD57B4")]
		internal bool IsEmpty()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x2CD5804", Offset = "0x2CD1804", VA = "0x2CD5804")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x2CD59A0", Offset = "0x2CD19A0", VA = "0x2CD59A0")]
		public DebugUIHandlerPersistentCanvas()
		{
		}
	}
	[Token(Token = "0x20001E9")]
	public class DebugUIHandlerProgressBar : DebugUIHandlerWidget
	{
		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text valueLabel;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public RectTransform progressBarRect;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DebugUI.ProgressBarValue m_Value;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_Timer;

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x2CD5A94", Offset = "0x2CD1A94", VA = "0x2CD5A94", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x2CD5A9C", Offset = "0x2CD1A9C", VA = "0x2CD5A9C", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x2CD5C34", Offset = "0x2CD1C34", VA = "0x2CD5C34", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x2CD5C6C", Offset = "0x2CD1C6C", VA = "0x2CD5C6C", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x2CD5C98", Offset = "0x2CD1C98", VA = "0x2CD5C98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x2CD5B28", Offset = "0x2CD1B28", VA = "0x2CD5B28")]
		private void UpdateValue()
		{
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x2CD5CFC", Offset = "0x2CD1CFC", VA = "0x2CD5CFC")]
		public DebugUIHandlerProgressBar()
		{
		}
	}
	[Token(Token = "0x20001EA")]
	public class DebugUIHandlerRow : DebugUIHandlerFoldout
	{
		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_Timer;

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x2CD5D04", Offset = "0x2CD1D04", VA = "0x2CD5D04", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x2CD5D0C", Offset = "0x2CD1D0C", VA = "0x2CD5D0C")]
		private GameObject GetChild(int index)
		{
			return null;
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x2CD5E3C", Offset = "0x2CD1E3C", VA = "0x2CD5E3C")]
		private bool TryGetChild(int index, out GameObject child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x2CD5EBC", Offset = "0x2CD1EBC", VA = "0x2CD5EBC")]
		private bool IsActive(DebugUI.Table table, int index, GameObject child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x2CD5FF0", Offset = "0x2CD1FF0", VA = "0x2CD5FF0")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x2CD63B4", Offset = "0x2CD23B4", VA = "0x2CD63B4")]
		public DebugUIHandlerRow()
		{
		}
	}
	[Token(Token = "0x20001EB")]
	public class DebugUIHandlerToggle : DebugUIHandlerWidget
	{
		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Toggle valueToggle;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Image checkmarkImage;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected internal DebugUI.BoolField m_Field;

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x2CD63BC", Offset = "0x2CD23BC", VA = "0x2CD63BC", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x2CD64CC", Offset = "0x2CD24CC", VA = "0x2CD64CC")]
		private void OnToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x2CD64F0", Offset = "0x2CD24F0", VA = "0x2CD64F0", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x2CD6548", Offset = "0x2CD2548", VA = "0x2CD6548", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x2CD6598", Offset = "0x2CD2598", VA = "0x2CD6598", Slot = "8")]
		public override void OnAction()
		{
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x2CD6620", Offset = "0x2CD2620", VA = "0x2CD6620", Slot = "13")]
		protected internal virtual void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x2CD66D0", Offset = "0x2CD26D0", VA = "0x2CD66D0")]
		public DebugUIHandlerToggle()
		{
		}
	}
	[Token(Token = "0x20001EC")]
	public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle
	{
		[Token(Token = "0x20001ED")]
		[CompilerGenerated]
		private sealed class <RefreshAfterSanitization>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DebugUIHandlerToggleHistory <>4__this;

			[Token(Token = "0x17000197")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B59")]
				[Address(RVA = "0x2CD6D28", Offset = "0x2CD2D28", VA = "0x2CD6D28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000198")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B5B")]
				[Address(RVA = "0x2CD6D68", Offset = "0x2CD2D68", VA = "0x2CD6D68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x2CD6C48", Offset = "0x2CD2C48", VA = "0x2CD6C48")]
			[DebuggerHidden]
			public <RefreshAfterSanitization>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x2CD6C78", Offset = "0x2CD2C78", VA = "0x2CD6C78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x2CD6C7C", Offset = "0x2CD2C7C", VA = "0x2CD6C7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B5A")]
			[Address(RVA = "0x2CD6D30", Offset = "0x2CD2D30", VA = "0x2CD6D30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Toggle[] historyToggles;

		[Token(Token = "0x40007BC")]
		private const float k_XOffset = 230f;

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x2CD66D8", Offset = "0x2CD26D8", VA = "0x2CD66D8", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x2CD6A58", Offset = "0x2CD2A58", VA = "0x2CD6A58", Slot = "13")]
		protected internal override void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x2CD6BE8", Offset = "0x2CD2BE8", VA = "0x2CD6BE8")]
		[IteratorStateMachine(typeof(<RefreshAfterSanitization>d__4))]
		private IEnumerator RefreshAfterSanitization()
		{
			return null;
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x2CD6C70", Offset = "0x2CD2C70", VA = "0x2CD6C70")]
		public DebugUIHandlerToggleHistory()
		{
		}
	}
	[Token(Token = "0x20001EE")]
	public class DebugUIHandlerUIntField : DebugUIHandlerWidget
	{
		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text valueLabel;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DebugUI.UIntField m_Field;

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x2CD6D70", Offset = "0x2CD2D70", VA = "0x2CD6D70", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x2CD6EDC", Offset = "0x2CD2EDC", VA = "0x2CD6EDC", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x2CD6F34", Offset = "0x2CD2F34", VA = "0x2CD6F34", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x2CD6F84", Offset = "0x2CD2F84", VA = "0x2CD6F84", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x2CD7044", Offset = "0x2CD3044", VA = "0x2CD7044", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x2CD6F8C", Offset = "0x2CD2F8C", VA = "0x2CD6F8C")]
		private void ChangeValue(bool fast, int multiplier)
		{
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x2CD6DFC", Offset = "0x2CD2DFC", VA = "0x2CD6DFC")]
		private void UpdateValueLabel()
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x2CD704C", Offset = "0x2CD304C", VA = "0x2CD704C")]
		public DebugUIHandlerUIntField()
		{
		}
	}
	[Token(Token = "0x20001EF")]
	public class DebugUIHandlerValue : DebugUIHandlerWidget
	{
		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text valueLabel;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DebugUI.Value m_Field;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected internal float m_Timer;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Color k_ZeroColor;

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x2CD7054", Offset = "0x2CD3054", VA = "0x2CD7054", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x2CD705C", Offset = "0x2CD305C", VA = "0x2CD705C", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x2CD70E0", Offset = "0x2CD30E0", VA = "0x2CD70E0", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x2CD7138", Offset = "0x2CD3138", VA = "0x2CD7138", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x2CD7188", Offset = "0x2CD3188", VA = "0x2CD7188")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x2CD7308", Offset = "0x2CD3308", VA = "0x2CD7308")]
		public DebugUIHandlerValue()
		{
		}
	}
	[Token(Token = "0x20001F0")]
	public class DebugUIHandlerValueTuple : DebugUIHandlerWidget
	{
		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text valueLabel;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected internal DebugUI.ValueTuple m_Field;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected internal Text[] valueElements;

		[Token(Token = "0x40007CC")]
		private const float k_XOffset = 230f;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_Timer;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Color k_ZeroColor;

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x2CD7360", Offset = "0x2CD3360", VA = "0x2CD7360", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x2CD7368", Offset = "0x2CD3368", VA = "0x2CD7368", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x2CD73A0", Offset = "0x2CD33A0", VA = "0x2CD73A0", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x2CD73CC", Offset = "0x2CD33CC", VA = "0x2CD73CC", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x2CD771C", Offset = "0x2CD371C", VA = "0x2CD771C", Slot = "13")]
		internal virtual void UpdateValueLabels()
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x2CD796C", Offset = "0x2CD396C", VA = "0x2CD796C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x2CD79E8", Offset = "0x2CD39E8", VA = "0x2CD79E8")]
		public DebugUIHandlerValueTuple()
		{
		}
	}
	[Token(Token = "0x20001F1")]
	public class DebugUIHandlerVBox : DebugUIHandlerWidget
	{
		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DebugUIHandlerContainer m_Container;

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x2CD7A40", Offset = "0x2CD3A40", VA = "0x2CD7A40", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x2CD7AA0", Offset = "0x2CD3AA0", VA = "0x2CD7AA0", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x2CD7B58", Offset = "0x2CD3B58", VA = "0x2CD7B58", Slot = "12")]
		public override DebugUIHandlerWidget Next()
		{
			return null;
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x2CD7C14", Offset = "0x2CD3C14", VA = "0x2CD7C14")]
		public DebugUIHandlerVBox()
		{
		}
	}
	[Token(Token = "0x20001F2")]
	public class DebugUIHandlerVector2 : DebugUIHandlerWidget
	{
		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UIFoldout valueToggle;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DebugUIHandlerIndirectFloatField fieldX;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DebugUIHandlerIndirectFloatField fieldY;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DebugUI.Vector2Field m_Field;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DebugUIHandlerContainer m_Container;

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x2CD7C1C", Offset = "0x2CD3C1C", VA = "0x2CD7C1C", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x2CD7F14", Offset = "0x2CD3F14", VA = "0x2CD7F14")]
		private void SetValue(float v, bool x = false, bool y = false)
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x2CD7E14", Offset = "0x2CD3E14", VA = "0x2CD7E14")]
		private void SetupSettings(DebugUIHandlerIndirectFloatField field)
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x2CD7FA8", Offset = "0x2CD3FA8", VA = "0x2CD7FA8", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x2CD808C", Offset = "0x2CD408C", VA = "0x2CD808C", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x2CD80B8", Offset = "0x2CD40B8", VA = "0x2CD80B8", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x2CD80D4", Offset = "0x2CD40D4", VA = "0x2CD80D4", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x2CD80F0", Offset = "0x2CD40F0", VA = "0x2CD80F0", Slot = "8")]
		public override void OnAction()
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x2CD8114", Offset = "0x2CD4114", VA = "0x2CD8114", Slot = "12")]
		public override DebugUIHandlerWidget Next()
		{
			return null;
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x2CD81E0", Offset = "0x2CD41E0", VA = "0x2CD81E0")]
		public DebugUIHandlerVector2()
		{
		}
	}
	[Token(Token = "0x20001F3")]
	public class DebugUIHandlerVector3 : DebugUIHandlerWidget
	{
		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UIFoldout valueToggle;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DebugUIHandlerIndirectFloatField fieldX;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DebugUIHandlerIndirectFloatField fieldY;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DebugUIHandlerIndirectFloatField fieldZ;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DebugUI.Vector3Field m_Field;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private DebugUIHandlerContainer m_Container;

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x2CD82F4", Offset = "0x2CD42F4", VA = "0x2CD82F4", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x2CD8680", Offset = "0x2CD4680", VA = "0x2CD8680")]
		private void SetValue(float v, bool x = false, bool y = false, bool z = false)
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x2CD8580", Offset = "0x2CD4580", VA = "0x2CD8580")]
		private void SetupSettings(DebugUIHandlerIndirectFloatField field)
		{
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x2CD8720", Offset = "0x2CD4720", VA = "0x2CD8720", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x2CD8804", Offset = "0x2CD4804", VA = "0x2CD8804", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x2CD8830", Offset = "0x2CD4830", VA = "0x2CD8830", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x2CD884C", Offset = "0x2CD484C", VA = "0x2CD884C", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x2CD8868", Offset = "0x2CD4868", VA = "0x2CD8868", Slot = "8")]
		public override void OnAction()
		{
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x2CD888C", Offset = "0x2CD488C", VA = "0x2CD888C", Slot = "12")]
		public override DebugUIHandlerWidget Next()
		{
			return null;
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x2CD8958", Offset = "0x2CD4958", VA = "0x2CD8958")]
		public DebugUIHandlerVector3()
		{
		}
	}
	[Token(Token = "0x20001F4")]
	public class DebugUIHandlerVector4 : DebugUIHandlerWidget
	{
		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Text nameLabel;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UIFoldout valueToggle;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DebugUIHandlerIndirectFloatField fieldX;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DebugUIHandlerIndirectFloatField fieldY;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DebugUIHandlerIndirectFloatField fieldZ;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DebugUIHandlerIndirectFloatField fieldW;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private DebugUI.Vector4Field m_Field;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private DebugUIHandlerContainer m_Container;

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x2CD8ADC", Offset = "0x2CD4ADC", VA = "0x2CD8ADC", Slot = "5")]
		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x2CD8F00", Offset = "0x2CD4F00", VA = "0x2CD8F00")]
		private void SetValue(float v, bool x = false, bool y = false, bool z = false, bool w = false)
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x2CD8DFC", Offset = "0x2CD4DFC", VA = "0x2CD8DFC")]
		private void SetupSettings(DebugUIHandlerIndirectFloatField field)
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x2CD8FB4", Offset = "0x2CD4FB4", VA = "0x2CD8FB4", Slot = "6")]
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x2CD90A0", Offset = "0x2CD50A0", VA = "0x2CD90A0", Slot = "7")]
		public override void OnDeselection()
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x2CD90CC", Offset = "0x2CD50CC", VA = "0x2CD90CC", Slot = "9")]
		public override void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x2CD90E8", Offset = "0x2CD50E8", VA = "0x2CD90E8", Slot = "10")]
		public override void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x2CD9104", Offset = "0x2CD5104", VA = "0x2CD9104", Slot = "8")]
		public override void OnAction()
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x2CD9128", Offset = "0x2CD5128", VA = "0x2CD9128", Slot = "12")]
		public override DebugUIHandlerWidget Next()
		{
			return null;
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x2CD92F8", Offset = "0x2CD52F8", VA = "0x2CD92F8")]
		public DebugUIHandlerVector4()
		{
		}
	}
	[Token(Token = "0x20001F5")]
	public class DebugUIHandlerWidget : MonoBehaviour
	{
		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Color colorDefault;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public Color colorSelected;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected DebugUI.Widget m_Widget;

		[Token(Token = "0x17000199")]
		public DebugUIHandlerWidget parentUIHandler
		{
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x2CD9524", Offset = "0x2CD5524", VA = "0x2CD9524")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x2CD952C", Offset = "0x2CD552C", VA = "0x2CD952C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public DebugUIHandlerWidget previousUIHandler
		{
			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0x2CD9534", Offset = "0x2CD5534", VA = "0x2CD9534")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0x2CD953C", Offset = "0x2CD553C", VA = "0x2CD953C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public DebugUIHandlerWidget nextUIHandler
		{
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x2CD9544", Offset = "0x2CD5544", VA = "0x2CD9544")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x2CD954C", Offset = "0x2CD554C", VA = "0x2CD954C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x2CD9554", Offset = "0x2CD5554", VA = "0x2CD9554", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x2CD9558", Offset = "0x2CD5558", VA = "0x2CD9558", Slot = "5")]
		internal virtual void SetWidget(DebugUI.Widget widget)
		{
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x2CD9560", Offset = "0x2CD5560", VA = "0x2CD9560")]
		internal DebugUI.Widget GetWidget()
		{
			return null;
		}

		[Token(Token = "0x6000BB9")]
		protected T CastWidget<T>() where T : DebugUI.Widget
		{
			return null;
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x2CD9568", Offset = "0x2CD5568", VA = "0x2CD9568", Slot = "6")]
		public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x2CD9570", Offset = "0x2CD5570", VA = "0x2CD9570", Slot = "7")]
		public virtual void OnDeselection()
		{
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x2CD9574", Offset = "0x2CD5574", VA = "0x2CD9574", Slot = "8")]
		public virtual void OnAction()
		{
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x2CD9578", Offset = "0x2CD5578", VA = "0x2CD9578", Slot = "9")]
		public virtual void OnIncrement(bool fast)
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x2CD957C", Offset = "0x2CD557C", VA = "0x2CD957C", Slot = "10")]
		public virtual void OnDecrement(bool fast)
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x2CD9580", Offset = "0x2CD5580", VA = "0x2CD9580", Slot = "11")]
		public virtual DebugUIHandlerWidget Previous()
		{
			return null;
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x2CD91F4", Offset = "0x2CD51F4", VA = "0x2CD91F4", Slot = "12")]
		public virtual DebugUIHandlerWidget Next()
		{
			return null;
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x2CD9314", Offset = "0x2CD5314", VA = "0x2CD9314")]
		public DebugUIHandlerWidget()
		{
		}
	}
	[Token(Token = "0x20001F6")]
	[ExecuteAlways]
	public class UIFoldout : Toggle
	{
		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public GameObject content;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public GameObject arrowOpened;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public GameObject arrowClosed;

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x2CD962C", Offset = "0x2CD562C", VA = "0x2CD962C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x2CD96F4", Offset = "0x2CD56F4", VA = "0x2CD96F4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x2CD96EC", Offset = "0x2CD56EC", VA = "0x2CD96EC")]
		public void SetState(bool state)
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x2CD9700", Offset = "0x2CD5700", VA = "0x2CD9700")]
		public void SetState(bool state, bool rebuildLayout)
		{
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x2CD98F0", Offset = "0x2CD58F0", VA = "0x2CD98F0")]
		public UIFoldout()
		{
		}
	}
}
