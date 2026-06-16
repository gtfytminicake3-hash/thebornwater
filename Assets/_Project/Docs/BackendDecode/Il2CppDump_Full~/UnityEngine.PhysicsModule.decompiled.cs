using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[StructLayout(0)]
[Token(Token = "0x2000002")]
[UnityEngine.Scripting.RequiredByNativeCode]
public class ControllerColliderHit
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal CharacterController m_Controller;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal Collider m_Collider;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal Vector3 m_Point;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	internal Vector3 m_Normal;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal Vector3 m_MoveDirection;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	internal float m_MoveLength;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	internal int m_Push;
}
[Token(Token = "0x2000003")]
public class Collision
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private ContactPairHeader m_Header;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ContactPair m_Pair;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool m_Flipped;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ContactPoint[] m_LegacyContacts;

	[Token(Token = "0x17000001")]
	internal bool Flipped
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2E7E444", Offset = "0x2E7A444", VA = "0x2E7E444")]
		set
		{
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2E7E44C", Offset = "0x2E7A44C", VA = "0x2E7E44C")]
	public Collision()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2E7E480", Offset = "0x2E7A480", VA = "0x2E7E480")]
	internal Collision(in ContactPairHeader header, in ContactPair pair, bool flipped)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2E7E5B0", Offset = "0x2E7A5B0", VA = "0x2E7E5B0")]
	internal void Reuse(in ContactPairHeader header, in ContactPair pair)
	{
	}
}
[Token(Token = "0x2000004")]
public enum QueryTriggerInteraction
{
	[Token(Token = "0x400000D")]
	UseGlobal,
	[Token(Token = "0x400000E")]
	Ignore,
	[Token(Token = "0x400000F")]
	Collide
}
[Token(Token = "0x2000005")]
[UnityEngine.Bindings.StaticAccessor("GetPhysicsManager()", UnityEngine.Bindings.StaticAccessorType.Dot)]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/PhysicsManager.h")]
public class Physics
{
	[Token(Token = "0x2000006")]
	public delegate void ContactEventDelegate(PhysicsScene scene, NativeArray<ContactPairHeader>.ReadOnly headerArray);

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static ContactEventDelegate ContactEvent;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Collision s_ReusableCollision;

	[Token(Token = "0x17000002")]
	public static extern bool invokeCollisionCallbacks
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2E7E6D4", Offset = "0x2E7A6D4", VA = "0x2E7E6D4")]
		get;
	}

	[Token(Token = "0x17000003")]
	[UnityEngine.Bindings.NativeProperty("DefaultPhysicsSceneHandle", true, UnityEngine.Bindings.TargetType.Function, true)]
	public static PhysicsScene defaultPhysicsScene
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2E7E6FC", Offset = "0x2E7A6FC", VA = "0x2E7E6FC")]
		get
		{
			return default(PhysicsScene);
		}
	}

	[Token(Token = "0x17000004")]
	public static extern bool reuseCollisionCallbacks
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2E80678", Offset = "0x2E7C678", VA = "0x2E80678")]
		get;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2E7E5E0", Offset = "0x2E7A5E0", VA = "0x2E7E5E0")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2E7E7B4", Offset = "0x2E7A7B4", VA = "0x2E7E7B4")]
	public static bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2E7EA5C", Offset = "0x2E7AA5C", VA = "0x2E7EA5C")]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
	{
		return default(bool);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2E7EB20", Offset = "0x2E7AB20", VA = "0x2E7EB20")]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance)
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2E7EBE8", Offset = "0x2E7ABE8", VA = "0x2E7EBE8")]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction)
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2E7ECA0", Offset = "0x2E7ACA0", VA = "0x2E7ECA0")]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return default(bool);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2E7EF64", Offset = "0x2E7AF64", VA = "0x2E7EF64")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2E7F040", Offset = "0x2E7B040", VA = "0x2E7F040")]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2E7F108", Offset = "0x2E7B108", VA = "0x2E7F108")]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2E7F1D0", Offset = "0x2E7B1D0", VA = "0x2E7F1D0")]
	public static bool Raycast(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2E7F268", Offset = "0x2E7B268", VA = "0x2E7F268")]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2E7F304", Offset = "0x2E7B304", VA = "0x2E7F304")]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance)
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2E7F38C", Offset = "0x2E7B38C", VA = "0x2E7F38C")]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray)
	{
		return default(bool);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2E7F414", Offset = "0x2E7B414", VA = "0x2E7F414")]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2E7F4C4", Offset = "0x2E7B4C4", VA = "0x2E7F4C4")]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2E7F57C", Offset = "0x2E7B57C", VA = "0x2E7F57C")]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2E7F61C", Offset = "0x2E7B61C", VA = "0x2E7F61C")]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2E7F6AC", Offset = "0x2E7B6AC", VA = "0x2E7F6AC")]
	[UnityEngine.Bindings.StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", UnityEngine.Bindings.StaticAccessorType.Dot)]
	[UnityEngine.Bindings.NativeName("RaycastAll")]
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2E7F7C0", Offset = "0x2E7B7C0", VA = "0x2E7F7C0")]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2E7F9D4", Offset = "0x2E7B9D4", VA = "0x2E7F9D4")]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2E7FA84", Offset = "0x2E7BA84", VA = "0x2E7FA84")]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2E7FB30", Offset = "0x2E7BB30", VA = "0x2E7FB30")]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2E7FBD4", Offset = "0x2E7BBD4", VA = "0x2E7FBD4")]
	public static RaycastHit[] RaycastAll(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2E7FC88", Offset = "0x2E7BC88", VA = "0x2E7FC88")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2E7FD38", Offset = "0x2E7BD38", VA = "0x2E7FD38")]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2E7FDDC", Offset = "0x2E7BDDC", VA = "0x2E7FDDC")]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2E7FE78", Offset = "0x2E7BE78", VA = "0x2E7FE78")]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
	{
		return default(int);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2E80184", Offset = "0x2E7C184", VA = "0x2E80184")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask)
	{
		return default(int);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2E8021C", Offset = "0x2E7C21C", VA = "0x2E8021C")]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance)
	{
		return default(int);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2E802B8", Offset = "0x2E7C2B8", VA = "0x2E802B8")]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results)
	{
		return default(int);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2E80344", Offset = "0x2E7C344", VA = "0x2E80344")]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
	{
		return default(int);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2E80418", Offset = "0x2E7C418", VA = "0x2E80418")]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask)
	{
		return default(int);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2E804F0", Offset = "0x2E7C4F0", VA = "0x2E804F0")]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance)
	{
		return default(int);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2E805B4", Offset = "0x2E7C5B4", VA = "0x2E805B4")]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results)
	{
		return default(int);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2E806A0", Offset = "0x2E7C6A0", VA = "0x2E806A0")]
	[UnityEngine.Bindings.StaticAccessor("PhysicsManager", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	internal static extern Collider GetColliderByInstanceID(int instanceID);

	[MethodImpl(4096)]
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2E806DC", Offset = "0x2E7C6DC", VA = "0x2E806DC")]
	[UnityEngine.Bindings.StaticAccessor("PhysicsManager", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	internal static extern Component GetBodyByInstanceID(int instanceID);

	[MethodImpl(4096)]
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2E80718", Offset = "0x2E7C718", VA = "0x2E80718")]
	[UnityEngine.Bindings.StaticAccessor("PhysicsManager", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	private static extern void SendOnCollisionEnter(Component component, Collision collision);

	[MethodImpl(4096)]
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2E8075C", Offset = "0x2E7C75C", VA = "0x2E8075C")]
	[UnityEngine.Bindings.StaticAccessor("PhysicsManager", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	private static extern void SendOnCollisionStay(Component component, Collision collision);

	[MethodImpl(4096)]
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2E807A0", Offset = "0x2E7C7A0", VA = "0x2E807A0")]
	[UnityEngine.Bindings.StaticAccessor("PhysicsManager", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	private static extern void SendOnCollisionExit(Component component, Collision collision);

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2E807E4", Offset = "0x2E7C7E4", VA = "0x2E807E4")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2E80A10", Offset = "0x2E7CA10", VA = "0x2E80A10")]
	private static void ReportContacts(NativeArray<ContactPairHeader>.ReadOnly array)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2E8100C", Offset = "0x2E7D00C", VA = "0x2E8100C")]
	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped)
	{
		return null;
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2E7E778", Offset = "0x2E7A778", VA = "0x2E7E778")]
	private static extern void get_defaultPhysicsScene_Injected(out PhysicsScene ret);

	[MethodImpl(4096)]
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2E7F754", Offset = "0x2E7B754", VA = "0x2E7F754")]
	private static extern RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);
}
[Token(Token = "0x2000007")]
public struct ModifiableContactPair
{
	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private IntPtr actor;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private IntPtr otherActor;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private IntPtr shape;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private IntPtr otherShape;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Quaternion rotation;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 position;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Quaternion otherRotation;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector3 otherPosition;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int numContacts;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private IntPtr contacts;
}
[Token(Token = "0x2000008")]
[UnityEngine.Bindings.NativeHeader("Runtime/Interfaces/IRaycast.h")]
[UnityEngine.Scripting.UsedByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/RaycastHit.h")]
[UnityEngine.Bindings.NativeHeader("PhysicsScriptingClasses.h")]
public struct RaycastHit
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[UnityEngine.Bindings.NativeName("point")]
	internal Vector3 m_Point;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[UnityEngine.Bindings.NativeName("normal")]
	internal Vector3 m_Normal;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[UnityEngine.Bindings.NativeName("faceID")]
	internal uint m_FaceID;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[UnityEngine.Bindings.NativeName("distance")]
	internal float m_Distance;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[UnityEngine.Bindings.NativeName("uv")]
	internal Vector2 m_UV;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[UnityEngine.Bindings.NativeName("collider")]
	internal int m_Collider;

	[Token(Token = "0x17000005")]
	public Collider collider
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2E81274", Offset = "0x2E7D274", VA = "0x2E81274")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public Vector3 point
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2E81320", Offset = "0x2E7D320", VA = "0x2E81320")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000007")]
	public Vector3 normal
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2E8132C", Offset = "0x2E7D32C", VA = "0x2E8132C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000008")]
	public float distance
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2E81338", Offset = "0x2E7D338", VA = "0x2E81338")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000009")]
	public Transform transform
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2E81340", Offset = "0x2E7D340", VA = "0x2E81340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	public Rigidbody rigidbody
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2E81418", Offset = "0x2E7D418", VA = "0x2E81418")]
		get
		{
			return null;
		}
	}
}
[Token(Token = "0x2000009")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component
{
	[Token(Token = "0x1700000B")]
	public Vector3 velocity
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2E81510", Offset = "0x2E7D510", VA = "0x2E81510")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700000C")]
	public Vector3 position
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2E815B0", Offset = "0x2E7D5B0", VA = "0x2E815B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700000D")]
	public Quaternion rotation
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2E81650", Offset = "0x2E7D650", VA = "0x2E81650")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2E816EC", Offset = "0x2E7D6EC", VA = "0x2E816EC")]
		set
		{
		}
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2E81784", Offset = "0x2E7D784", VA = "0x2E81784")]
	public void MovePosition(Vector3 position)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2E8181C", Offset = "0x2E7D81C", VA = "0x2E8181C")]
	public void MoveRotation(Quaternion rot)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2E818B4", Offset = "0x2E7D8B4", VA = "0x2E818B4")]
	public Rigidbody()
	{
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2E8156C", Offset = "0x2E7D56C", VA = "0x2E8156C")]
	private extern void get_velocity_Injected(out Vector3 ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2E8160C", Offset = "0x2E7D60C", VA = "0x2E8160C")]
	private extern void get_position_Injected(out Vector3 ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2E816A8", Offset = "0x2E7D6A8", VA = "0x2E816A8")]
	private extern void get_rotation_Injected(out Quaternion ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2E81740", Offset = "0x2E7D740", VA = "0x2E81740")]
	private extern void set_rotation_Injected(ref Quaternion value);

	[MethodImpl(4096)]
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2E817D8", Offset = "0x2E7D7D8", VA = "0x2E817D8")]
	private extern void MovePosition_Injected(ref Vector3 position);

	[MethodImpl(4096)]
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2E81870", Offset = "0x2E7D870", VA = "0x2E81870")]
	private extern void MoveRotation_Injected(ref Quaternion rot);
}
[Token(Token = "0x200000A")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/Collider.h")]
[UnityEngine.Scripting.RequiredByNativeCode]
[RequireComponent(typeof(Transform))]
public class Collider : Component
{
	[Token(Token = "0x1700000E")]
	public extern bool enabled
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2E818BC", Offset = "0x2E7D8BC", VA = "0x2E818BC")]
		get;
	}

	[Token(Token = "0x1700000F")]
	public extern Rigidbody attachedRigidbody
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2E814D4", Offset = "0x2E7D4D4", VA = "0x2E814D4")]
		[UnityEngine.Bindings.NativeMethod("GetRigidbody")]
		get;
	}

	[Token(Token = "0x17000010")]
	public extern bool isTrigger
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2E818F8", Offset = "0x2E7D8F8", VA = "0x2E818F8")]
		set;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2E8193C", Offset = "0x2E7D93C", VA = "0x2E8193C")]
	public Vector3 ClosestPoint(Vector3 position)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2E819F8", Offset = "0x2E7D9F8", VA = "0x2E819F8")]
	public Collider()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2E819A4", Offset = "0x2E7D9A4", VA = "0x2E819A4")]
	private extern void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret);
}
[Token(Token = "0x200000B")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/CharacterController.h")]
public class CharacterController : Collider
{
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2E81A00", Offset = "0x2E7DA00", VA = "0x2E81A00")]
	public bool SimpleMove(Vector3 speed)
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2E81A9C", Offset = "0x2E7DA9C", VA = "0x2E81A9C")]
	public CharacterController()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2E81A58", Offset = "0x2E7DA58", VA = "0x2E81A58")]
	private extern bool SimpleMove_Injected(ref Vector3 speed);
}
[Token(Token = "0x200000C")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/MeshCollider.h")]
public class MeshCollider : Collider
{
	[Token(Token = "0x17000011")]
	public extern Mesh sharedMesh
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2E81AA4", Offset = "0x2E7DAA4", VA = "0x2E81AA4")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2E81AE0", Offset = "0x2E7DAE0", VA = "0x2E81AE0")]
		set;
	}

	[Token(Token = "0x17000012")]
	public extern bool convex
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2E81B24", Offset = "0x2E7DB24", VA = "0x2E81B24")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2E81B60", Offset = "0x2E7DB60", VA = "0x2E81B60")]
		set;
	}
}
[Token(Token = "0x200000D")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/CapsuleCollider.h")]
public class CapsuleCollider : Collider
{
}
[Token(Token = "0x200000E")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/BoxCollider.h")]
[UnityEngine.Scripting.RequiredByNativeCode]
public class BoxCollider : Collider
{
	[Token(Token = "0x17000013")]
	public Vector3 center
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2E81BA4", Offset = "0x2E7DBA4", VA = "0x2E81BA4")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000014")]
	public Vector3 size
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2E81C44", Offset = "0x2E7DC44", VA = "0x2E81C44")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2E81CE4", Offset = "0x2E7DCE4", VA = "0x2E81CE4")]
	public BoxCollider()
	{
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2E81C00", Offset = "0x2E7DC00", VA = "0x2E81C00")]
	private extern void get_center_Injected(out Vector3 ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2E81CA0", Offset = "0x2E7DCA0", VA = "0x2E81CA0")]
	private extern void get_size_Injected(out Vector3 ret);
}
[Token(Token = "0x200000F")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/SphereCollider.h")]
public class SphereCollider : Collider
{
	[Token(Token = "0x17000015")]
	public Vector3 center
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2E81CEC", Offset = "0x2E7DCEC", VA = "0x2E81CEC")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000016")]
	public extern float radius
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2E81D8C", Offset = "0x2E7DD8C", VA = "0x2E81D8C")]
		get;
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2E81D48", Offset = "0x2E7DD48", VA = "0x2E81D48")]
	private extern void get_center_Injected(out Vector3 ret);
}
[Token(Token = "0x2000010")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/MessageParameters.h")]
[UnityEngine.Scripting.UsedByNativeCode]
public struct ContactPoint
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal Vector3 m_Point;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	internal Vector3 m_Normal;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal Vector3 m_Impulse;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	internal int m_ThisColliderInstanceID;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal int m_OtherColliderInstanceID;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	internal float m_Separation;
}
[Token(Token = "0x2000011")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
public struct PhysicsScene : IEquatable<PhysicsScene>
{
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int m_Handle;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2E81DC8", Offset = "0x2E7DDC8", VA = "0x2E81DC8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2E81EAC", Offset = "0x2E7DEAC", VA = "0x2E81EAC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2E81EB4", Offset = "0x2E7DEB4", VA = "0x2E81EB4", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2E81F2C", Offset = "0x2E7DF2C", VA = "0x2E81F2C", Slot = "4")]
	public bool Equals(PhysicsScene other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2E7E88C", Offset = "0x2E7A88C", VA = "0x2E7E88C")]
	public bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance = float.PositiveInfinity, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(bool);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2E81F3C", Offset = "0x2E7DF3C", VA = "0x2E81F3C")]
	[UnityEngine.Bindings.NativeName("RaycastTest")]
	[UnityEngine.Bindings.StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", UnityEngine.Bindings.StaticAccessorType.Dot)]
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return default(bool);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2E7ED78", Offset = "0x2E7AD78", VA = "0x2E7ED78")]
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance = float.PositiveInfinity, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(bool);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2E82024", Offset = "0x2E7E024", VA = "0x2E82024")]
	[UnityEngine.Bindings.NativeName("Raycast")]
	[UnityEngine.Bindings.StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", UnityEngine.Bindings.StaticAccessorType.Dot)]
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return default(bool);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2E7FF24", Offset = "0x2E7BF24", VA = "0x2E7FF24")]
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, [DefaultValue("Mathf.Infinity")] float maxDistance = float.PositiveInfinity, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(int);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2E8211C", Offset = "0x2E7E11C", VA = "0x2E8211C")]
	[UnityEngine.Bindings.NativeName("RaycastNonAlloc")]
	[UnityEngine.Bindings.StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, [UnityEngine.Bindings.Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return default(int);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2E81FB8", Offset = "0x2E7DFB8", VA = "0x2E81FB8")]
	private static extern bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	[MethodImpl(4096)]
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2E820A0", Offset = "0x2E7E0A0", VA = "0x2E820A0")]
	private static extern bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	[MethodImpl(4096)]
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2E82194", Offset = "0x2E7E194", VA = "0x2E82194")]
	private static extern int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);
}
[Token(Token = "0x2000012")]
public readonly struct ContactPairHeader
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal readonly int m_BodyID;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	internal readonly int m_OtherBodyID;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	internal readonly IntPtr m_StartPtr;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal readonly uint m_NbPairs;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	internal readonly CollisionPairHeaderFlags m_Flags;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal readonly Vector3 m_RelativeVelocity;

	[Token(Token = "0x17000017")]
	public Component Body
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2E80DF8", Offset = "0x2E7CDF8", VA = "0x2E80DF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	public Component OtherBody
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2E80E70", Offset = "0x2E7CE70", VA = "0x2E80E70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000019")]
	internal bool HasRemovedBody
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2E80DD4", Offset = "0x2E7CDD4", VA = "0x2E80DD4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2E80DE4", Offset = "0x2E7CDE4", VA = "0x2E80DE4")]
	public unsafe ref ContactPair GetContactPair(int index)
	{
		return ref *(ContactPair*)null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2E82210", Offset = "0x2E7E210", VA = "0x2E82210")]
	internal unsafe ContactPair* GetContactPair_Internal(int index)
	{
		//IL_0002: Expected I, but got O
		return (ContactPair*)unchecked((nint)null);
	}
}
[Token(Token = "0x2000013")]
[UnityEngine.Scripting.UsedByNativeCode]
public readonly struct ContactPair
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal readonly int m_ColliderID;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	internal readonly int m_OtherColliderID;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	internal readonly IntPtr m_StartPtr;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal readonly uint m_NbPoints;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	internal readonly CollisionPairFlags m_Flags;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	internal readonly CollisionPairEventFlags m_Events;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal readonly Vector3 m_ImpulseSum;

	[Token(Token = "0x1700001A")]
	public Collider Collider
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2E80EE8", Offset = "0x2E7CEE8", VA = "0x2E80EE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001B")]
	public Collider OtherCollider
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2E80F74", Offset = "0x2E7CF74", VA = "0x2E80F74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public bool IsCollisionEnter
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2E81000", Offset = "0x2E7D000", VA = "0x2E81000")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001D")]
	public bool IsCollisionExit
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2E81138", Offset = "0x2E7D138", VA = "0x2E81138")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public bool IsCollisionStay
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2E8112C", Offset = "0x2E7D12C", VA = "0x2E8112C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	internal bool HasRemovedCollider
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2E80DE8", Offset = "0x2E7CDE8", VA = "0x2E80DE8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2E7E55C", Offset = "0x2E7A55C", VA = "0x2E7E55C")]
	internal int ExtractContactsArray([UnityEngine.Bindings.Unmarshalled] ContactPoint[] managedContainer, bool flipped)
	{
		return default(int);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2E82290", Offset = "0x2E7E290", VA = "0x2E82290")]
	private static extern int ExtractContactsArray_Injected(ref ContactPair _unity_self, ContactPoint[] managedContainer, bool flipped);
}
[Token(Token = "0x2000014")]
internal enum CollisionPairHeaderFlags : ushort
{
	[Token(Token = "0x4000039")]
	RemovedActor = 1,
	[Token(Token = "0x400003A")]
	RemovedOtherActor
}
[Token(Token = "0x2000015")]
internal enum CollisionPairFlags : ushort
{
	[Token(Token = "0x400003C")]
	RemovedShape = 1,
	[Token(Token = "0x400003D")]
	RemovedOtherShape = 2,
	[Token(Token = "0x400003E")]
	ActorPairHasFirstTouch = 4,
	[Token(Token = "0x400003F")]
	ActorPairLostTouch = 8,
	[Token(Token = "0x4000040")]
	InternalHasImpulses = 0x10,
	[Token(Token = "0x4000041")]
	InternalContactsAreFlipped = 0x20
}
[Token(Token = "0x2000016")]
internal enum CollisionPairEventFlags : ushort
{
	[Token(Token = "0x4000043")]
	SolveContacts = 1,
	[Token(Token = "0x4000044")]
	ModifyContacts = 2,
	[Token(Token = "0x4000045")]
	NotifyTouchFound = 4,
	[Token(Token = "0x4000046")]
	NotifyTouchPersists = 8,
	[Token(Token = "0x4000047")]
	NotifyTouchLost = 16,
	[Token(Token = "0x4000048")]
	NotifyTouchCCD = 32,
	[Token(Token = "0x4000049")]
	NotifyThresholdForceFound = 64,
	[Token(Token = "0x400004A")]
	NotifyThresholdForcePersists = 128,
	[Token(Token = "0x400004B")]
	NotifyThresholdForceLost = 256,
	[Token(Token = "0x400004C")]
	NotifyContactPoint = 512,
	[Token(Token = "0x400004D")]
	DetectDiscreteContact = 1024,
	[Token(Token = "0x400004E")]
	DetectCCDContact = 2048,
	[Token(Token = "0x400004F")]
	PreSolverVelocity = 4096,
	[Token(Token = "0x4000050")]
	PostSolverVelocity = 8192,
	[Token(Token = "0x4000051")]
	ContactEventPose = 16384,
	[Token(Token = "0x4000052")]
	NextFree = 32768,
	[Token(Token = "0x4000053")]
	ContactDefault = 1025,
	[Token(Token = "0x4000054")]
	TriggerDefault = 1044
}
