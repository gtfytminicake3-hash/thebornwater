using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
public struct PhysicsScene2D : IEquatable<PhysicsScene2D>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int m_Handle;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2E7CE0C", Offset = "0x2E78E0C", VA = "0x2E7CE0C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2E7CEF0", Offset = "0x2E78EF0", VA = "0x2E7CEF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2E7CEF8", Offset = "0x2E78EF8", VA = "0x2E7CEF8", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2E7CF70", Offset = "0x2E78F70", VA = "0x2E7CF70", Slot = "4")]
	public bool Equals(PhysicsScene2D other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2E7CF80", Offset = "0x2E78F80", VA = "0x2E7CF80")]
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, [DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5)
	{
		return default(RaycastHit2D);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2E7D1A0", Offset = "0x2E791A0", VA = "0x2E7D1A0")]
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		return default(RaycastHit2D);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2E7D10C", Offset = "0x2E7910C", VA = "0x2E7D10C")]
	[UnityEngine.Bindings.NativeMethod("Raycast_Binding")]
	[UnityEngine.Bindings.StaticAccessor("PhysicsQuery2D", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		return default(RaycastHit2D);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2E7D24C", Offset = "0x2E7924C", VA = "0x2E7D24C")]
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2E7D27C", Offset = "0x2E7927C", VA = "0x2E7D27C")]
	[UnityEngine.Bindings.StaticAccessor("PhysicsQuery2D", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeMethod("RaycastArray_Binding")]
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [UnityEngine.Bindings.Unmarshalled][UnityEngine.Bindings.NotNull("ArgumentNullException")] RaycastHit2D[] results)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2E7D370", Offset = "0x2E79370", VA = "0x2E7D370")]
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2E7D3A0", Offset = "0x2E793A0", VA = "0x2E7D3A0")]
	[UnityEngine.Bindings.StaticAccessor("PhysicsQuery2D", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeMethod("RaycastList_Binding")]
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [UnityEngine.Bindings.NotNull("ArgumentNullException")] List<RaycastHit2D> results)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2E7D494", Offset = "0x2E79494", VA = "0x2E7D494")]
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, [DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2E7D4B0", Offset = "0x2E794B0", VA = "0x2E7D4B0")]
	[UnityEngine.Bindings.NativeMethod("GetRayIntersectionArray_Binding")]
	[UnityEngine.Bindings.StaticAccessor("PhysicsQuery2D", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, [UnityEngine.Bindings.NotNull("ArgumentNullException")][UnityEngine.Bindings.Unmarshalled] RaycastHit2D[] results)
	{
		return default(int);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2E7D1D0", Offset = "0x2E791D0", VA = "0x2E7D1D0")]
	private static extern void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret);

	[MethodImpl(4096)]
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2E7D2F4", Offset = "0x2E792F4", VA = "0x2E7D2F4")]
	private static extern int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results);

	[MethodImpl(4096)]
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2E7D418", Offset = "0x2E79418", VA = "0x2E7D418")]
	private static extern int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results);

	[MethodImpl(4096)]
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2E7D530", Offset = "0x2E79530", VA = "0x2E7D530")]
	private static extern int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results);
}
[Token(Token = "0x2000003")]
[UnityEngine.Bindings.StaticAccessor("GetPhysicsManager2D()", UnityEngine.Bindings.StaticAccessorType.Arrow)]
[UnityEngine.Bindings.NativeHeader("Physics2DScriptingClasses.h")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[UnityEngine.Bindings.NativeHeader("Physics2DScriptingClasses.h")]
public class Physics2D
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D;

	[Token(Token = "0x17000001")]
	public static PhysicsScene2D defaultPhysicsScene
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2E7D5AC", Offset = "0x2E795AC", VA = "0x2E7D5AC")]
		get
		{
			return default(PhysicsScene2D);
		}
	}

	[Token(Token = "0x17000002")]
	[UnityEngine.Bindings.StaticAccessor("GetPhysics2DSettings()")]
	public static extern bool queriesHitTriggers
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2E7D5B4", Offset = "0x2E795B4", VA = "0x2E7D5B4")]
		get;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2E7D5DC", Offset = "0x2E795DC", VA = "0x2E7D5DC")]
	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction)
	{
		return default(RaycastHit2D);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2E7D6BC", Offset = "0x2E796BC", VA = "0x2E7D6BC")]
	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance)
	{
		return default(RaycastHit2D);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2E7D79C", Offset = "0x2E7979C", VA = "0x2E7D79C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask)
	{
		return default(RaycastHit2D);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2E7D898", Offset = "0x2E79898", VA = "0x2E7D898")]
	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
	{
		return default(RaycastHit2D);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2E7D994", Offset = "0x2E79994", VA = "0x2E7D994")]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
	{
		return default(RaycastHit2D);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2E7DA98", Offset = "0x2E79A98", VA = "0x2E7DA98")]
	[ExcludeFromDocs]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
	{
		return default(int);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2E7DB54", Offset = "0x2E79B54", VA = "0x2E7DB54")]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance)
	{
		return default(int);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2E7DC18", Offset = "0x2E79C18", VA = "0x2E7DC18")]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity)
	{
		return default(int);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2E7DCDC", Offset = "0x2E79CDC", VA = "0x2E7DCDC")]
	[ExcludeFromDocs]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2E7DDF8", Offset = "0x2E79DF8", VA = "0x2E7DDF8")]
	[ExcludeFromDocs]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2E7DE6C", Offset = "0x2E79E6C", VA = "0x2E7DE6C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2E7DD48", Offset = "0x2E79D48", VA = "0x2E7DD48")]
	[UnityEngine.Bindings.NativeMethod("GetRayIntersectionAll_Binding")]
	[UnityEngine.Bindings.StaticAccessor("PhysicsQuery2D", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2E7DF58", Offset = "0x2E79F58", VA = "0x2E7DF58")]
	[ExcludeFromDocs]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results)
	{
		return default(int);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2E7DFD4", Offset = "0x2E79FD4", VA = "0x2E7DFD4")]
	[ExcludeFromDocs]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance)
	{
		return default(int);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2E7E058", Offset = "0x2E7A058", VA = "0x2E7E058")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
	{
		return default(int);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2E7DEEC", Offset = "0x2E79EEC", VA = "0x2E7DEEC")]
	private static extern RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask);
}
[Serializable]
[Token(Token = "0x2000004")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[UnityEngine.NativeClass("ContactFilter", "struct ContactFilter;")]
[UnityEngine.Scripting.RequiredByNativeCode(Optional = true, GenerateProxy = true)]
public struct ContactFilter2D
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[UnityEngine.Bindings.NativeName("m_UseTriggers")]
	public bool useTriggers;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	[UnityEngine.Bindings.NativeName("m_UseLayerMask")]
	public bool useLayerMask;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	[UnityEngine.Bindings.NativeName("m_UseDepth")]
	public bool useDepth;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
	[UnityEngine.Bindings.NativeName("m_UseOutsideDepth")]
	public bool useOutsideDepth;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[UnityEngine.Bindings.NativeName("m_UseNormalAngle")]
	public bool useNormalAngle;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
	[UnityEngine.Bindings.NativeName("m_UseOutsideNormalAngle")]
	public bool useOutsideNormalAngle;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[UnityEngine.Bindings.NativeName("m_LayerMask")]
	public LayerMask layerMask;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[UnityEngine.Bindings.NativeName("m_MinDepth")]
	public float minDepth;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[UnityEngine.Bindings.NativeName("m_MaxDepth")]
	public float maxDepth;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[UnityEngine.Bindings.NativeName("m_MinNormalAngle")]
	public float minNormalAngle;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[UnityEngine.Bindings.NativeName("m_MaxNormalAngle")]
	public float maxNormalAngle;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2E7E16C", Offset = "0x2E7A16C", VA = "0x2E7E16C")]
	private void CheckConsistency()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2E7E1E4", Offset = "0x2E7A1E4", VA = "0x2E7E1E4")]
	public void SetLayerMask(LayerMask layerMask)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2E7E1F4", Offset = "0x2E7A1F4", VA = "0x2E7E1F4")]
	public void SetDepth(float minDepth, float maxDepth)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2E7D010", Offset = "0x2E79010", VA = "0x2E7D010")]
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth)
	{
		return default(ContactFilter2D);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2E7E1A8", Offset = "0x2E7A1A8", VA = "0x2E7E1A8")]
	private static extern void CheckConsistency_Injected(ref ContactFilter2D _unity_self);
}
[StructLayout(0)]
[Token(Token = "0x2000005")]
[UnityEngine.Scripting.RequiredByNativeCode]
public class Collision2D
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal int m_Collider;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	internal int m_OtherCollider;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal int m_Rigidbody;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	internal int m_OtherRigidbody;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal Vector2 m_RelativeVelocity;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal int m_Enabled;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	internal int m_ContactCount;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal ContactPoint2D[] m_ReusedContacts;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal ContactPoint2D[] m_LegacyContacts;
}
[Token(Token = "0x2000006")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
[UnityEngine.NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
[UnityEngine.Scripting.RequiredByNativeCode(Optional = false, GenerateProxy = true)]
public struct ContactPoint2D
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[UnityEngine.Bindings.NativeName("point")]
	private Vector2 m_Point;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[UnityEngine.Bindings.NativeName("normal")]
	private Vector2 m_Normal;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[UnityEngine.Bindings.NativeName("relativeVelocity")]
	private Vector2 m_RelativeVelocity;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[UnityEngine.Bindings.NativeName("separation")]
	private float m_Separation;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[UnityEngine.Bindings.NativeName("normalImpulse")]
	private float m_NormalImpulse;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[UnityEngine.Bindings.NativeName("tangentImpulse")]
	private float m_TangentImpulse;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[UnityEngine.Bindings.NativeName("collider")]
	private int m_Collider;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[UnityEngine.Bindings.NativeName("otherCollider")]
	private int m_OtherCollider;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[UnityEngine.Bindings.NativeName("rigidbody")]
	private int m_Rigidbody;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[UnityEngine.Bindings.NativeName("otherRigidbody")]
	private int m_OtherRigidbody;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[UnityEngine.Bindings.NativeName("enabled")]
	private int m_Enabled;
}
[Token(Token = "0x2000007")]
[UnityEngine.NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
[UnityEngine.Bindings.NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
[UnityEngine.Scripting.RequiredByNativeCode(Optional = true, GenerateProxy = true)]
public struct RaycastHit2D
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[UnityEngine.Bindings.NativeName("centroid")]
	private Vector2 m_Centroid;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[UnityEngine.Bindings.NativeName("point")]
	private Vector2 m_Point;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[UnityEngine.Bindings.NativeName("normal")]
	private Vector2 m_Normal;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[UnityEngine.Bindings.NativeName("distance")]
	private float m_Distance;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[UnityEngine.Bindings.NativeName("fraction")]
	private float m_Fraction;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[UnityEngine.Bindings.NativeName("collider")]
	private int m_Collider;

	[Token(Token = "0x17000003")]
	public Vector2 point
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2E7E23C", Offset = "0x2E7A23C", VA = "0x2E7E23C")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000004")]
	public Vector2 normal
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2E7E244", Offset = "0x2E7A244", VA = "0x2E7E244")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000005")]
	public float distance
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2E7E24C", Offset = "0x2E7A24C", VA = "0x2E7E24C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000006")]
	public Collider2D collider
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2E7E254", Offset = "0x2E7A254", VA = "0x2E7E254")]
		get
		{
			return null;
		}
	}
}
[Token(Token = "0x2000008")]
[UnityEngine.Bindings.NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
public sealed class Rigidbody2D : Component
{
	[Token(Token = "0x17000007")]
	public Vector2 velocity
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2E7E300", Offset = "0x2E7A300", VA = "0x2E7E300")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2E7E390", Offset = "0x2E7A390", VA = "0x2E7E390")]
	public Rigidbody2D()
	{
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2E7E34C", Offset = "0x2E7A34C", VA = "0x2E7E34C")]
	private extern void get_velocity_Injected(out Vector2 ret);
}
[Token(Token = "0x2000009")]
[RequireComponent(typeof(Transform))]
[UnityEngine.Scripting.RequiredByNativeCode(Optional = true)]
[UnityEngine.Bindings.NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
public class Collider2D : Behaviour
{
	[Token(Token = "0x17000008")]
	public Bounds bounds
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2E7E398", Offset = "0x2E7A398", VA = "0x2E7E398")]
		get
		{
			return default(Bounds);
		}
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2E7E400", Offset = "0x2E7A400", VA = "0x2E7E400")]
	private extern void get_bounds_Injected(out Bounds ret);
}
