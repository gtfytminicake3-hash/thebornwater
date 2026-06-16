using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.XR;

[Token(Token = "0x2000002")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.StaticAccessor("XRInputTrackingFacade::Get()", UnityEngine.Bindings.StaticAccessorType.Dot)]
[UnityEngine.Bindings.NativeConditional("ENABLE_VR")]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
public static class InputTracking
{
	[Token(Token = "0x2000003")]
	private enum TrackingStateEventType
	{
		[Token(Token = "0x4000006")]
		NodeAdded,
		[Token(Token = "0x4000007")]
		NodeRemoved,
		[Token(Token = "0x4000008")]
		TrackingAcquired,
		[Token(Token = "0x4000009")]
		TrackingLost
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<XRNodeState> trackingAcquired;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<XRNodeState> trackingLost;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<XRNodeState> nodeAdded;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<XRNodeState> nodeRemoved;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x3048FC4", Offset = "0x3044FC4", VA = "0x3048FC4")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked)
	{
	}
}
[Token(Token = "0x2000004")]
public enum XRNode
{
	[Token(Token = "0x400000B")]
	LeftEye,
	[Token(Token = "0x400000C")]
	RightEye,
	[Token(Token = "0x400000D")]
	CenterEye,
	[Token(Token = "0x400000E")]
	Head,
	[Token(Token = "0x400000F")]
	LeftHand,
	[Token(Token = "0x4000010")]
	RightHand,
	[Token(Token = "0x4000011")]
	GameController,
	[Token(Token = "0x4000012")]
	TrackingReference,
	[Token(Token = "0x4000013")]
	HardwareTracker
}
[Token(Token = "0x2000005")]
[Flags]
internal enum AvailableTrackingData
{
	[Token(Token = "0x4000015")]
	None = 0,
	[Token(Token = "0x4000016")]
	PositionAvailable = 1,
	[Token(Token = "0x4000017")]
	RotationAvailable = 2,
	[Token(Token = "0x4000018")]
	VelocityAvailable = 4,
	[Token(Token = "0x4000019")]
	AngularVelocityAvailable = 8,
	[Token(Token = "0x400001A")]
	AccelerationAvailable = 0x10,
	[Token(Token = "0x400001B")]
	AngularAccelerationAvailable = 0x20
}
[Token(Token = "0x2000006")]
[UnityEngine.Scripting.UsedByNativeCode]
public struct XRNodeState
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private XRNode m_Type;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private AvailableTrackingData m_AvailableFields;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private Vector3 m_Position;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Quaternion m_Rotation;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 m_Velocity;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 m_AngularVelocity;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 m_Acceleration;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 m_AngularAcceleration;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int m_Tracked;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ulong m_UniqueID;

	[Token(Token = "0x17000001")]
	public ulong uniqueID
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x3049154", Offset = "0x3045154", VA = "0x3049154")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public XRNode nodeType
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x304915C", Offset = "0x304515C", VA = "0x304915C")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public bool tracked
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x3049164", Offset = "0x3045164", VA = "0x3049164")]
		set
		{
		}
	}
}
[Token(Token = "0x2000007")]
internal enum InputFeatureType : uint
{
	[Token(Token = "0x4000027")]
	Custom = 0u,
	[Token(Token = "0x4000028")]
	Binary = 1u,
	[Token(Token = "0x4000029")]
	DiscreteStates = 2u,
	[Token(Token = "0x400002A")]
	Axis1D = 3u,
	[Token(Token = "0x400002B")]
	Axis2D = 4u,
	[Token(Token = "0x400002C")]
	Axis3D = 5u,
	[Token(Token = "0x400002D")]
	Rotation = 6u,
	[Token(Token = "0x400002E")]
	Hand = 7u,
	[Token(Token = "0x400002F")]
	Bone = 8u,
	[Token(Token = "0x4000030")]
	Eyes = 9u,
	[Token(Token = "0x4000031")]
	kUnityXRInputFeatureTypeInvalid = uint.MaxValue
}
[Token(Token = "0x2000008")]
internal enum ConnectionChangeType : uint
{
	[Token(Token = "0x4000033")]
	Connected,
	[Token(Token = "0x4000034")]
	Disconnected,
	[Token(Token = "0x4000035")]
	ConfigChange
}
[Token(Token = "0x2000009")]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeConditional("ENABLE_VR")]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage>
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal string m_Name;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[UnityEngine.Bindings.NativeName("m_FeatureType")]
	internal InputFeatureType m_InternalType;

	[Token(Token = "0x17000004")]
	public string name
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3049170", Offset = "0x3045170", VA = "0x3049170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	internal InputFeatureType internalType
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3049178", Offset = "0x3045178", VA = "0x3049178")]
		get
		{
			return default(InputFeatureType);
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3049180", Offset = "0x3045180", VA = "0x3049180", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x304920C", Offset = "0x304520C", VA = "0x304920C", Slot = "4")]
	public bool Equals(InputFeatureUsage other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x304924C", Offset = "0x304524C", VA = "0x304924C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200000A")]
[UnityEngine.Scripting.UsedByNativeCode]
[UnityEngine.Bindings.NativeConditional("ENABLE_VR")]
public struct InputDevice : IEquatable<InputDevice>
{
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private ulong m_DeviceId;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private bool m_Initialized;

	[Token(Token = "0x17000006")]
	private ulong deviceId
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x30492A8", Offset = "0x30452A8", VA = "0x30492A8")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x3049298", Offset = "0x3045298", VA = "0x3049298")]
	internal InputDevice(ulong deviceId)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x30492C0", Offset = "0x30452C0", VA = "0x30492C0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x3049354", Offset = "0x3045354", VA = "0x3049354", Slot = "4")]
	public bool Equals(InputDevice other)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x304937C", Offset = "0x304537C", VA = "0x304937C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200000B")]
[UnityEngine.Bindings.StaticAccessor("XRInputDevices::Get()", UnityEngine.Bindings.StaticAccessorType.Dot)]
[UnityEngine.Bindings.NativeHeader("XRScriptingClasses.h")]
[UnityEngine.Bindings.NativeHeader("Modules/XR/XRPrefix.h")]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[UnityEngine.Bindings.NativeConditional("ENABLE_VR")]
[UnityEngine.Scripting.RequiredByNativeCode]
public struct Hand : IEquatable<Hand>
{
	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private ulong m_DeviceId;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private uint m_FeatureIndex;

	[Token(Token = "0x17000007")]
	internal ulong deviceId
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x30493A8", Offset = "0x30453A8", VA = "0x30493A8")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17000008")]
	internal uint featureIndex
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x30493B0", Offset = "0x30453B0", VA = "0x30493B0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x30493B8", Offset = "0x30453B8", VA = "0x30493B8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3049440", Offset = "0x3045440", VA = "0x3049440", Slot = "4")]
	public bool Equals(Hand other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3049464", Offset = "0x3045464", VA = "0x3049464", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200000C")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.StaticAccessor("XRInputDevices::Get()", UnityEngine.Bindings.StaticAccessorType.Dot)]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[UnityEngine.Bindings.NativeHeader("XRScriptingClasses.h")]
[UnityEngine.Bindings.NativeHeader("Modules/XR/XRPrefix.h")]
[UnityEngine.Bindings.NativeConditional("ENABLE_VR")]
public struct Eyes : IEquatable<Eyes>
{
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private ulong m_DeviceId;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private uint m_FeatureIndex;

	[Token(Token = "0x17000009")]
	internal ulong deviceId
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x30494B0", Offset = "0x30454B0", VA = "0x30494B0")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700000A")]
	internal uint featureIndex
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x30494B8", Offset = "0x30454B8", VA = "0x30494B8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x30494C0", Offset = "0x30454C0", VA = "0x30494C0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3049548", Offset = "0x3045548", VA = "0x3049548", Slot = "4")]
	public bool Equals(Eyes other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x304956C", Offset = "0x304556C", VA = "0x304956C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200000D")]
[UnityEngine.Bindings.NativeConditional("ENABLE_VR")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[UnityEngine.Bindings.NativeHeader("XRScriptingClasses.h")]
[UnityEngine.Bindings.StaticAccessor("XRInputDevices::Get()", UnityEngine.Bindings.StaticAccessorType.Dot)]
[UnityEngine.Bindings.NativeHeader("Modules/XR/XRPrefix.h")]
public struct Bone : IEquatable<Bone>
{
	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private ulong m_DeviceId;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private uint m_FeatureIndex;

	[Token(Token = "0x1700000B")]
	internal ulong deviceId
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x30495B8", Offset = "0x30455B8", VA = "0x30495B8")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700000C")]
	internal uint featureIndex
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x30495C0", Offset = "0x30455C0", VA = "0x30495C0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x30495C8", Offset = "0x30455C8", VA = "0x30495C8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3049650", Offset = "0x3045650", VA = "0x3049650", Slot = "4")]
	public bool Equals(Bone other)
	{
		return default(bool);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x3049674", Offset = "0x3045674", VA = "0x3049674", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[StructLayout(0)]
[Token(Token = "0x200000E")]
[UnityEngine.Bindings.StaticAccessor("XRInputDevices::Get()", UnityEngine.Bindings.StaticAccessorType.Dot)]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[UnityEngine.Bindings.NativeConditional("ENABLE_VR")]
[UnityEngine.Scripting.UsedByNativeCode]
public class InputDevices
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<InputDevice> deviceConnected;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<InputDevice> deviceDisconnected;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<InputDevice> deviceConfigChanged;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x30496C0", Offset = "0x30456C0", VA = "0x30496C0")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change)
	{
	}
}
[Token(Token = "0x200000F")]
[UnityEngine.Bindings.NativeHeader("Modules/XR/XRPrefix.h")]
[UnityEngine.Bindings.NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
[UnityEngine.Scripting.UsedByNativeCode]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[Token(Token = "0x2000010")]
	[Flags]
	public enum TextureLayout
	{
		[Token(Token = "0x4000046")]
		Texture2DArray = 1,
		[Token(Token = "0x4000047")]
		SingleTexture2D = 2,
		[Token(Token = "0x4000048")]
		SeparateTexture2Ds = 4
	}

	[Token(Token = "0x2000011")]
	[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	public struct XRRenderParameter
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Matrix4x4 view;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Matrix4x4 projection;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Rect viewport;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Mesh occlusionMesh;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int textureArraySlice;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Matrix4x4 previousView;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public bool isPreviousViewValid;
	}

	[Token(Token = "0x2000012")]
	[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
	public struct XRRenderPass
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr displaySubsystemInstance;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int renderPassIndex;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RenderTargetIdentifier renderTarget;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RenderTextureDescriptor renderTargetDesc;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool hasMotionVectorPass;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public RenderTargetIdentifier motionVectorRenderTarget;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public RenderTextureDescriptor motionVectorRenderTargetDesc;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool shouldFillOutDepth;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int cullingPassIndex;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public IntPtr foveatedRenderingInfo;

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x304A018", Offset = "0x3046018", VA = "0x304A018")]
		[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
		[UnityEngine.Bindings.NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameter", IsFreeFunction = true, HasExplicitThis = true, ThrowsException = true)]
		public void GetRenderParameter(Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x304A0D0", Offset = "0x30460D0", VA = "0x304A0D0")]
		[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
		[UnityEngine.Bindings.NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameterCount", IsFreeFunction = true, HasExplicitThis = true)]
		public int GetRenderParameterCount()
		{
			return default(int);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x304A074", Offset = "0x3046074", VA = "0x304A074")]
		private static extern void GetRenderParameter_Injected(ref XRRenderPass _unity_self, Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter);

		[MethodImpl(4096)]
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x304A10C", Offset = "0x304610C", VA = "0x304A10C")]
		private static extern int GetRenderParameterCount_Injected(ref XRRenderPass _unity_self);
	}

	[Token(Token = "0x2000013")]
	[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/RenderTexture.h")]
	public struct XRBlitParams
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RenderTexture srcTex;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int srcTexArraySlice;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Rect srcRect;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Rect destRect;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr foveatedRenderingInfo;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool srcHdrEncoded;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ColorGamut srcHdrColorGamut;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int srcHdrMaxLuminance;
	}

	[Token(Token = "0x2000014")]
	[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	public struct XRMirrorViewBlitDesc
	{
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr displaySubsystemInstance;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool nativeBlitAvailable;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public bool nativeBlitInvalidStates;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int blitParamsCount;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x304A148", Offset = "0x3046148", VA = "0x304A148")]
		[UnityEngine.Bindings.NativeMethod(Name = "XRMirrorViewBlitDescScriptApi::GetBlitParameter", IsFreeFunction = true, HasExplicitThis = true)]
		[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
		public void GetBlitParameter(int blitParameterIndex, out XRBlitParams blitParameter)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x304A19C", Offset = "0x304619C", VA = "0x304A19C")]
		private static extern void GetBlitParameter_Injected(ref XRMirrorViewBlitDesc _unity_self, int blitParameterIndex, out XRBlitParams blitParameter);
	}

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<bool> displayFocusChanged;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private HDROutputSettings m_HDROutputSettings;

	[Token(Token = "0x1700000D")]
	public extern float scaleOfAllRenderTargets
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x304979C", Offset = "0x304579C", VA = "0x304979C")]
		set;
	}

	[Token(Token = "0x1700000E")]
	public extern float zNear
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x30497E8", Offset = "0x30457E8", VA = "0x30497E8")]
		set;
	}

	[Token(Token = "0x1700000F")]
	public extern float zFar
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x3049834", Offset = "0x3045834", VA = "0x3049834")]
		set;
	}

	[Token(Token = "0x17000010")]
	public extern bool sRGB
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3049880", Offset = "0x3045880", VA = "0x3049880")]
		set;
	}

	[Token(Token = "0x17000011")]
	public extern TextureLayout textureLayout
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x30498C4", Offset = "0x30458C4", VA = "0x30498C4")]
		set;
	}

	[Token(Token = "0x17000012")]
	public extern bool disableLegacyRenderer
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x304994C", Offset = "0x304594C", VA = "0x304994C")]
		set;
	}

	[Token(Token = "0x17000013")]
	public HDROutputSettings hdrOutputSettings
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3049F68", Offset = "0x3045F68", VA = "0x3049F68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x304977C", Offset = "0x304577C", VA = "0x304977C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private void InvokeDisplayFocusChanged(bool focus)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x3049908", Offset = "0x3045908", VA = "0x3049908")]
	public extern void SetMSAALevel(int level);

	[MethodImpl(4096)]
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x3049990", Offset = "0x3045990", VA = "0x3049990")]
	public extern int GetRenderPassCount();

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x30499CC", Offset = "0x30459CC", VA = "0x30499CC")]
	public void GetRenderPass(int renderPassIndex, out XRRenderPass renderPass)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3049A70", Offset = "0x3045A70", VA = "0x3049A70")]
	[UnityEngine.Bindings.NativeMethod("TryGetRenderPass")]
	private extern bool Internal_TryGetRenderPass(int renderPassIndex, out XRRenderPass renderPass);

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3049AC4", Offset = "0x3045AC4", VA = "0x3049AC4")]
	public void EndRecordingIfLateLatched(Camera camera)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3049BA4", Offset = "0x3045BA4", VA = "0x3049BA4")]
	[UnityEngine.Bindings.NativeMethod("TryEndRecordingIfLateLatched")]
	private extern bool Internal_TryEndRecordingIfLateLatched(Camera camera);

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x3049BE8", Offset = "0x3045BE8", VA = "0x3049BE8")]
	public void BeginRecordingIfLateLatched(Camera camera)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x3049CC8", Offset = "0x3045CC8", VA = "0x3049CC8")]
	[UnityEngine.Bindings.NativeMethod("TryBeginRecordingIfLateLatched")]
	private extern bool Internal_TryBeginRecordingIfLateLatched(Camera camera);

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x3049D0C", Offset = "0x3045D0C", VA = "0x3049D0C")]
	public void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x3049E18", Offset = "0x3045E18", VA = "0x3049E18")]
	[UnityEngine.Bindings.NativeMethod("TryGetCullingParams")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
	private extern bool Internal_TryGetCullingParams(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters);

	[MethodImpl(4096)]
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x3049E74", Offset = "0x3045E74", VA = "0x3049E74")]
	[UnityEngine.Bindings.NativeMethod(Name = "GetPreferredMirrorViewBlitMode", IsThreadSafe = false)]
	[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
	public extern int GetPreferredMirrorBlitMode();

	[MethodImpl(4096)]
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x3049EB0", Offset = "0x3045EB0", VA = "0x3049EB0")]
	[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
	[UnityEngine.Bindings.NativeMethod(Name = "QueryMirrorViewBlitDesc", IsThreadSafe = false)]
	public extern bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode);

	[MethodImpl(4096)]
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x3049F0C", Offset = "0x3045F0C", VA = "0x3049F0C")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
	[UnityEngine.Bindings.NativeMethod(Name = "AddGraphicsThreadMirrorViewBlit", IsThreadSafe = false)]
	public extern bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode);

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x3049FD0", Offset = "0x3045FD0", VA = "0x3049FD0")]
	public XRDisplaySubsystem()
	{
	}
}
[Token(Token = "0x2000015")]
[UnityEngine.Scripting.UsedByNativeCode]
[UnityEngine.Bindings.NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystemDescriptor.h")]
public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem>
{
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x304A1F0", Offset = "0x30461F0", VA = "0x304A1F0")]
	public XRDisplaySubsystemDescriptor()
	{
	}
}
[Token(Token = "0x2000016")]
[UnityEngine.Scripting.UsedByNativeCode]
[UnityEngine.Bindings.NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<XRInputSubsystem> trackingOriginUpdated;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<XRInputSubsystem> boundaryChanged;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x304A238", Offset = "0x3046238", VA = "0x304A238")]
	[UnityEngine.Scripting.RequiredByNativeCode(GenerateProxy = true)]
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x304A2FC", Offset = "0x30462FC", VA = "0x304A2FC")]
	[UnityEngine.Scripting.RequiredByNativeCode(GenerateProxy = true)]
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x304A3C0", Offset = "0x30463C0", VA = "0x304A3C0")]
	public XRInputSubsystem()
	{
	}
}
[Token(Token = "0x2000017")]
[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
[UnityEngine.Scripting.UsedByNativeCode]
[UnityEngine.Bindings.NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
[UnityEngine.Bindings.NativeHeader("Modules/XR/XRPrefix.h")]
public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem>
{
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x304A408", Offset = "0x3046408", VA = "0x304A408")]
	public XRInputSubsystemDescriptor()
	{
	}
}
[Token(Token = "0x2000018")]
[UnityEngine.Scripting.UsedByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public struct MeshId : IEquatable<MeshId>
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MeshId s_InvalidId;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private ulong m_SubId1;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private ulong m_SubId2;

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x304A450", Offset = "0x3046450", VA = "0x304A450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x304A4E4", Offset = "0x30464E4", VA = "0x304A4E4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x304A518", Offset = "0x3046518", VA = "0x304A518", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x304A5D0", Offset = "0x30465D0", VA = "0x304A5D0", Slot = "4")]
	public bool Equals(MeshId other)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000019")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public enum MeshGenerationStatus
{
	[Token(Token = "0x400006C")]
	Success,
	[Token(Token = "0x400006D")]
	InvalidMeshId,
	[Token(Token = "0x400006E")]
	GenerationAlreadyInProgress,
	[Token(Token = "0x400006F")]
	Canceled,
	[Token(Token = "0x4000070")]
	UnknownError
}
[Token(Token = "0x200001A")]
internal static class HashCodeHelper
{
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x304A63C", Offset = "0x304663C", VA = "0x304A63C")]
	public static int Combine(int hash1, int hash2)
	{
		return default(int);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x304A64C", Offset = "0x304664C", VA = "0x304A64C")]
	public static int Combine(int hash1, int hash2, int hash3)
	{
		return default(int);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x304A660", Offset = "0x3046660", VA = "0x304A660")]
	public static int Combine(int hash1, int hash2, int hash3, int hash4)
	{
		return default(int);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x304A678", Offset = "0x3046678", VA = "0x304A678")]
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5)
	{
		return default(int);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x304A694", Offset = "0x3046694", VA = "0x304A694")]
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6)
	{
		return default(int);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x304A6B4", Offset = "0x30466B4", VA = "0x304A6B4")]
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7)
	{
		return default(int);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x304A6D8", Offset = "0x30466D8", VA = "0x304A6D8")]
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8)
	{
		return default(int);
	}
}
[Token(Token = "0x200001B")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public struct MeshGenerationResult : IEquatable<MeshGenerationResult>
{
	[Token(Token = "0x17000014")]
	public readonly MeshId MeshId
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x304A700", Offset = "0x3046700", VA = "0x304A700")]
		[CompilerGenerated]
		get
		{
			return default(MeshId);
		}
	}

	[Token(Token = "0x17000015")]
	public readonly Mesh Mesh
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x304A70C", Offset = "0x304670C", VA = "0x304A70C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	public readonly MeshCollider MeshCollider
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x304A714", Offset = "0x3046714", VA = "0x304A714")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000017")]
	public readonly MeshGenerationStatus Status
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x304A71C", Offset = "0x304671C", VA = "0x304A71C")]
		[CompilerGenerated]
		get
		{
			return default(MeshGenerationStatus);
		}
	}

	[Token(Token = "0x17000018")]
	public readonly MeshVertexAttributes Attributes
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x304A724", Offset = "0x3046724", VA = "0x304A724")]
		[CompilerGenerated]
		get
		{
			return default(MeshVertexAttributes);
		}
	}

	[Token(Token = "0x17000019")]
	public readonly Vector3 Position
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x304A72C", Offset = "0x304672C", VA = "0x304A72C")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700001A")]
	public readonly Quaternion Rotation
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x304A738", Offset = "0x3046738", VA = "0x304A738")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700001B")]
	public readonly Vector3 Scale
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x304A744", Offset = "0x3046744", VA = "0x304A744")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x304A750", Offset = "0x3046750", VA = "0x304A750", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x304A7E0", Offset = "0x30467E0", VA = "0x304A7E0", Slot = "4")]
	public bool Equals(MeshGenerationResult other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x304A948", Offset = "0x3046948", VA = "0x304A948", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200001C")]
[UnityEngine.Scripting.UsedByNativeCode]
[Flags]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public enum MeshVertexAttributes
{
	[Token(Token = "0x400007B")]
	None = 0,
	[Token(Token = "0x400007C")]
	Normals = 1,
	[Token(Token = "0x400007D")]
	Tangents = 2,
	[Token(Token = "0x400007E")]
	UVs = 4,
	[Token(Token = "0x400007F")]
	Colors = 8
}
[Token(Token = "0x200001D")]
[UnityEngine.Bindings.NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
[UnityEngine.Bindings.NativeHeader("Modules/XR/XRPrefix.h")]
[UnityEngine.Scripting.UsedByNativeCode]
public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
{
	[Token(Token = "0x200001E")]
	[UnityEngine.Bindings.NativeConditional("ENABLE_XR")]
	private readonly struct MeshTransformList : IDisposable
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IntPtr m_Self;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x304ABE8", Offset = "0x3046BE8", VA = "0x304ABE8", Slot = "4")]
		public void Dispose()
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x304AC24", Offset = "0x3046C24", VA = "0x304AC24")]
		[UnityEngine.Bindings.FreeFunction("UnityXRMeshTransformList_Dispose")]
		private static extern void Dispose(IntPtr self);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x304AB64", Offset = "0x3046B64", VA = "0x304AB64")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x304ABA0", Offset = "0x3046BA0", VA = "0x304ABA0")]
	public XRMeshSubsystem()
	{
	}
}
[Token(Token = "0x200001F")]
[UnityEngine.Bindings.NativeType(Header = "Modules/XR/Subsystems/Planes/XRMeshSubsystemDescriptor.h")]
[UnityEngine.Scripting.UsedByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/XR/XRPrefix.h")]
public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem>
{
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x304AC60", Offset = "0x3046C60", VA = "0x304AC60")]
	public XRMeshSubsystemDescriptor()
	{
	}
}
