using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.AI;

[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
[UnityEngine.Bindings.NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshAgent.html")]
[MovedFrom("UnityEngine")]
public sealed class NavMeshAgent : Behaviour
{
	[Token(Token = "0x17000001")]
	public Vector3 destination
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2DD1D10", Offset = "0x2DCDD10", VA = "0x2DD1D10")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000002")]
	public extern float stoppingDistance
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2DD1DB0", Offset = "0x2DCDDB0", VA = "0x2DD1DB0")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2DD1DEC", Offset = "0x2DCDDEC", VA = "0x2DD1DEC")]
		set;
	}

	[Token(Token = "0x17000003")]
	public extern float remainingDistance
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2DD1E38", Offset = "0x2DCDE38", VA = "0x2DD1E38")]
		get;
	}

	[Token(Token = "0x17000004")]
	public extern float speed
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2DD1E74", Offset = "0x2DCDE74", VA = "0x2DD1E74")]
		set;
	}

	[Token(Token = "0x17000005")]
	public extern float angularSpeed
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2DD1EC0", Offset = "0x2DCDEC0", VA = "0x2DD1EC0")]
		set;
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2DD1C74", Offset = "0x2DCDC74", VA = "0x2DD1C74")]
	public bool SetDestination(Vector3 target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2DD1F0C", Offset = "0x2DCDF0C", VA = "0x2DD1F0C")]
	public NavMeshAgent()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2DD1CCC", Offset = "0x2DCDCCC", VA = "0x2DD1CCC")]
	private extern bool SetDestination_Injected(ref Vector3 target);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2DD1D6C", Offset = "0x2DCDD6C", VA = "0x2DD1D6C")]
	private extern void get_destination_Injected(out Vector3 ret);
}
[Token(Token = "0x2000003")]
[MovedFrom("UnityEngine")]
public struct NavMeshHit
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private Vector3 m_Position;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0xC")]
	private Vector3 m_Normal;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x18")]
	private float m_Distance;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x1C")]
	private int m_Mask;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	private int m_Hit;

	[Token(Token = "0x17000006")]
	public Vector3 position
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2DD1F14", Offset = "0x2DCDF14", VA = "0x2DD1F14")]
		get
		{
			return default(Vector3);
		}
	}
}
[Token(Token = "0x2000004")]
[UnityEngine.Bindings.NativeHeader("Modules/AI/NavMeshManager.h")]
[UnityEngine.Bindings.StaticAccessor("NavMeshBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
[MovedFrom("UnityEngine")]
[UnityEngine.Bindings.NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
public static class NavMesh
{
	[Token(Token = "0x2000005")]
	public delegate void OnNavMeshPreUpdate();

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x0")]
	public static OnNavMeshPreUpdate onPreUpdate;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2DD1F20", Offset = "0x2DCDF20", VA = "0x2DD1F20")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void Internal_CallOnNavMeshPreUpdate()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2DD1F84", Offset = "0x2DCDF84", VA = "0x2DD1F84")]
	public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask)
	{
		return default(bool);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2DD2058", Offset = "0x2DCE058", VA = "0x2DD2058")]
	[UnityEngine.Bindings.StaticAccessor("GetNavMeshProjectSettings()")]
	[UnityEngine.Bindings.NativeName("GetAreaFromName")]
	public static extern int GetAreaFromName(string areaName);

	[MethodImpl(4096)]
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2DD1FF4", Offset = "0x2DCDFF4", VA = "0x2DD1FF4")]
	private static extern bool SamplePosition_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask);
}
