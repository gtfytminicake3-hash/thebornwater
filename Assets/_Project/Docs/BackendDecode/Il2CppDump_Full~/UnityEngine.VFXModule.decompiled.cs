using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.VFX;

[StructLayout(0)]
[Token(Token = "0x2000002")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
public sealed class VFXEventAttribute : IDisposable
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private IntPtr m_Ptr;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_Owner;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VisualEffectAsset m_VfxAsset;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x3048124", Offset = "0x3044124", VA = "0x3048124")]
	private VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x3048164", Offset = "0x3044164", VA = "0x3048164")]
	internal static VFXEventAttribute CreateEventAttributeWrapper()
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x30481C4", Offset = "0x30441C4", VA = "0x30481C4")]
	internal void SetWrapValue(IntPtr ptrToEventAttribute)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x3048220", Offset = "0x3044220", VA = "0x3048220")]
	internal static extern IntPtr Internal_Create();

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3048248", Offset = "0x3044248", VA = "0x3048248")]
	internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset)
	{
		return null;
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x304830C", Offset = "0x304430C", VA = "0x304830C")]
	internal extern void Internal_InitFromAsset(VisualEffectAsset vfxAsset);

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3048350", Offset = "0x3044350", VA = "0x3048350")]
	private void Release()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x30483F4", Offset = "0x30443F4", VA = "0x30483F4", Slot = "1")]
	~VFXEventAttribute()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3048478", Offset = "0x3044478", VA = "0x3048478", Slot = "4")]
	public void Dispose()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x30483B8", Offset = "0x30443B8", VA = "0x30483B8")]
	[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
	internal static extern void Internal_Destroy(IntPtr ptr);
}
[StructLayout(0)]
[Token(Token = "0x2000003")]
[UnityEngine.Bindings.NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
[UnityEngine.Scripting.RequiredByNativeCode]
public class VFXExpressionValues
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal IntPtr m_Ptr;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x30484D8", Offset = "0x30444D8", VA = "0x30484D8")]
	private VFXExpressionValues()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x30484E0", Offset = "0x30444E0", VA = "0x30484E0")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
[UnityEngine.Scripting.RequiredByNativeCode]
public struct VFXCameraXRSettings
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint viewTotal;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint viewCount;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint viewOffset;
}
[Token(Token = "0x2000005")]
[UnityEngine.Scripting.RequiredByNativeCode]
public struct VFXBatchedEffectInfo
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public VisualEffectAsset vfxAsset;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint activeBatchCount;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint inactiveBatchCount;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint activeInstanceCount;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public uint unbatchedInstanceCount;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public uint totalInstanceCapacity;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public uint maxInstancePerBatchCapacity;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ulong totalGPUSizeInBytes;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong totalCPUSizeInBytes;
}
[Token(Token = "0x2000006")]
[UnityEngine.Scripting.RequiredByNativeCode]
internal struct VFXBatchInfo
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint capacity;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint activeInstanceCount;
}
[Token(Token = "0x2000007")]
[UnityEngine.Bindings.StaticAccessor("GetVFXManager()", UnityEngine.Bindings.StaticAccessorType.Dot)]
[UnityEngine.Bindings.NativeHeader("Modules/VFX/Public/ScriptBindings/VFXManagerBindings.h")]
[UnityEngine.Bindings.NativeHeader("Modules/VFX/Public/VFXManager.h")]
[UnityEngine.Scripting.RequiredByNativeCode]
public static class VFXManager
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly VFXCameraXRSettings kDefaultCameraXRSettings;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x3048544", Offset = "0x3044544", VA = "0x3048544")]
	public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x30485C8", Offset = "0x30445C8", VA = "0x30485C8")]
	private static void Internal_ProcessCameraCommand([UnityEngine.Bindings.NotNull("NullExceptionObject")] Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, IntPtr cullResults)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x304866C", Offset = "0x304466C", VA = "0x304866C")]
	private static extern void Internal_ProcessCameraCommand_Injected(Camera cam, CommandBuffer cmd, ref VFXCameraXRSettings camXRSettings, IntPtr cullResults);
}
[Serializable]
[Token(Token = "0x2000008")]
[UnityEngine.Scripting.RequiredByNativeCode]
public abstract class VFXSpawnerCallbacks : ScriptableObject
{
	[Token(Token = "0x6000011")]
	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	[Token(Token = "0x6000012")]
	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	[Token(Token = "0x6000013")]
	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x3048718", Offset = "0x3044718", VA = "0x3048718")]
	protected VFXSpawnerCallbacks()
	{
	}
}
[StructLayout(0)]
[Token(Token = "0x2000009")]
[UnityEngine.Bindings.NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
[UnityEngine.Scripting.RequiredByNativeCode]
public sealed class VFXSpawnerState : IDisposable
{
	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private IntPtr m_Ptr;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_Owner;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VFXEventAttribute m_WrapEventAttribute;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x3048720", Offset = "0x3044720", VA = "0x3048720")]
	internal VFXSpawnerState(IntPtr ptr, bool owner)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x3048750", Offset = "0x3044750", VA = "0x3048750")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static VFXSpawnerState CreateSpawnerStateWrapper()
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x30487B4", Offset = "0x30447B4", VA = "0x30487B4")]
	private void PrepareWrapper()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x3048844", Offset = "0x3044844", VA = "0x3048844")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x30488D8", Offset = "0x30448D8", VA = "0x30488D8")]
	private void Release()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x304897C", Offset = "0x304497C", VA = "0x304897C", Slot = "1")]
	~VFXSpawnerState()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3048A00", Offset = "0x3044A00", VA = "0x3048A00", Slot = "4")]
	public void Dispose()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3048940", Offset = "0x3044940", VA = "0x3048940")]
	[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
	private static extern void Internal_Destroy(IntPtr ptr);
}
[Token(Token = "0x200000A")]
[UnityEngine.Bindings.NativeHeader("VFXScriptingClasses.h")]
[UnityEngine.Bindings.NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectAssetBindings.h")]
[UnityEngine.Scripting.UsedByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
public abstract class VisualEffectObject : Object
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x3048A60", Offset = "0x3044A60", VA = "0x3048A60")]
	protected VisualEffectObject()
	{
	}
}
[Token(Token = "0x200000B")]
[UnityEngine.Scripting.UsedByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
[UnityEngine.Bindings.NativeHeader("VFXScriptingClasses.h")]
public class VisualEffectAsset : VisualEffectObject
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly int PlayEventID;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static readonly int StopEventID;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x3048AB8", Offset = "0x3044AB8", VA = "0x3048AB8")]
	public VisualEffectAsset()
	{
	}
}
[Token(Token = "0x200000C")]
public struct VFXOutputEventArgs
{
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x3048B5C", Offset = "0x3044B5C", VA = "0x3048B5C")]
	public VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute)
	{
	}
}
[Token(Token = "0x200000D")]
[UnityEngine.Bindings.NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
[UnityEngine.Bindings.NativeHeader("Modules/VFX/Public/VisualEffect.h")]
[RequireComponent(typeof(Transform))]
public class VisualEffect : Behaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private VFXEventAttribute m_cachedEventAttribute;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action<VFXOutputEventArgs> outputEventReceived;

	[Token(Token = "0x17000001")]
	public extern VisualEffectAsset visualEffectAsset
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3048B68", Offset = "0x3044B68", VA = "0x3048B68")]
		get;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x3048BA4", Offset = "0x3044BA4", VA = "0x3048BA4")]
	public VFXEventAttribute CreateVFXEventAttribute()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x3048C6C", Offset = "0x3044C6C", VA = "0x3048C6C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x3048CA8", Offset = "0x3044CA8", VA = "0x3048CA8")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId)
	{
	}
}
[Token(Token = "0x200000E")]
[UnityEngine.RejectDragAndDropMaterial]
[UnityEngine.Bindings.NativeType(Header = "Modules/VFX/Public/VFXRenderer.h")]
[UnityEngine.Scripting.RequiredByNativeCode]
internal sealed class VFXRenderer : Renderer
{
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x3048CDC", Offset = "0x3044CDC", VA = "0x3048CDC")]
	public VFXRenderer()
	{
	}
}
