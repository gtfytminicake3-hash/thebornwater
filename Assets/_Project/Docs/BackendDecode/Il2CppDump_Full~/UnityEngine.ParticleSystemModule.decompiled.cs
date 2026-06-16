using System;
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
[UnityEngine.Bindings.NativeHeader("ParticleSystemScriptingClasses.h")]
[UnityEngine.Bindings.NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[UnityEngine.Bindings.NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[UnityEngine.Bindings.NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[UnityEngine.Bindings.NativeHeader("ParticleSystemScriptingClasses.h")]
[UnityEngine.Bindings.NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[UnityEngine.Bindings.NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[RequireComponent(typeof(Transform))]
[UnityEngine.Bindings.NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[UnityEngine.Scripting.UsedByNativeCode]
public sealed class ParticleSystem : Component
{
	[Token(Token = "0x2000003")]
	public struct MainModule
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ParticleSystem m_ParticleSystem;

		[Token(Token = "0x1700000B")]
		public float duration
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2E7C9FC", Offset = "0x2E789FC", VA = "0x2E7C9FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000C")]
		public bool loop
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2E7CA74", Offset = "0x2E78A74", VA = "0x2E7CA74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2E7C9C8", Offset = "0x2E789C8", VA = "0x2E7C9C8")]
		internal MainModule(ParticleSystem particleSystem)
		{
		}

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2E7CA38", Offset = "0x2E78A38", VA = "0x2E7CA38")]
		private static extern float get_duration_Injected(ref MainModule _unity_self);

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2E7CAB0", Offset = "0x2E78AB0", VA = "0x2E7CAB0")]
		private static extern bool get_loop_Injected(ref MainModule _unity_self);
	}

	[Token(Token = "0x2000004")]
	public struct EmissionModule
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ParticleSystem m_ParticleSystem;

		[Token(Token = "0x1700000D")]
		public MinMaxCurve rateOverTime
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2E7CAEC", Offset = "0x2E78AEC", VA = "0x2E7CAEC")]
			[UnityEngine.Bindings.NativeThrows]
			set
			{
			}
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2E7C9D4", Offset = "0x2E789D4", VA = "0x2E7C9D4")]
		internal EmissionModule(ParticleSystem particleSystem)
		{
		}

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2E7CB30", Offset = "0x2E78B30", VA = "0x2E7CB30")]
		private static extern void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value);
	}

	[Token(Token = "0x2000005")]
	public struct ShapeModule
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ParticleSystem m_ParticleSystem;

		[Token(Token = "0x1700000E")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2E7CB74", Offset = "0x2E78B74", VA = "0x2E7CB74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2E7CBEC", Offset = "0x2E78BEC", VA = "0x2E7CBEC")]
			[UnityEngine.Bindings.NativeThrows]
			set
			{
			}
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2E7C9E0", Offset = "0x2E789E0", VA = "0x2E7C9E0")]
		internal ShapeModule(ParticleSystem particleSystem)
		{
		}

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2E7CBB0", Offset = "0x2E78BB0", VA = "0x2E7CBB0")]
		private static extern MeshRenderer get_meshRenderer_Injected(ref ShapeModule _unity_self);

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2E7CC30", Offset = "0x2E78C30", VA = "0x2E7CC30")]
		private static extern void set_meshRenderer_Injected(ref ShapeModule _unity_self, MeshRenderer value);
	}

	[Token(Token = "0x2000006")]
	public struct SubEmittersModule
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ParticleSystem m_ParticleSystem;

		[Token(Token = "0x1700000F")]
		public int subEmittersCount
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2E7CC74", Offset = "0x2E78C74", VA = "0x2E7CC74")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2E7C9EC", Offset = "0x2E789EC", VA = "0x2E7C9EC")]
		internal SubEmittersModule(ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2E7CCEC", Offset = "0x2E78CEC", VA = "0x2E7CCEC")]
		[UnityEngine.Bindings.NativeThrows]
		public ParticleSystem GetSubEmitterSystem(int index)
		{
			return null;
		}

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2E7CCB0", Offset = "0x2E78CB0", VA = "0x2E7CCB0")]
		private static extern int get_subEmittersCount_Injected(ref SubEmittersModule _unity_self);

		[MethodImpl(4096)]
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2E7CD30", Offset = "0x2E78D30", VA = "0x2E7CD30")]
		private static extern ParticleSystem GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, int index);
	}

	[Token(Token = "0x2000007")]
	[UnityEngine.Scripting.RequiredByNativeCode("particleSystemParticle", Optional = true)]
	public struct Particle
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 m_Position;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Vector3 m_Velocity;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 m_AnimatedVelocity;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_InitialVelocity;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_AxisOfRotation;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Rotation;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 m_AngularVelocity;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_StartSize;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Color32 m_StartColor;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private uint m_RandomSeed;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private uint m_ParentRandomSeed;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_Lifetime;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_StartLifetime;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_MeshIndex;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_EmitAccumulator0;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float m_EmitAccumulator1;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private uint m_Flags;

		[Token(Token = "0x17000010")]
		[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", false)]
		public float lifetime
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2E7C240", Offset = "0x2E78240", VA = "0x2E7C240")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Vector3 position
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2E7C228", Offset = "0x2E78228", VA = "0x2E7C228")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2E7CD7C", Offset = "0x2E78D7C", VA = "0x2E7CD7C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2E7C234", Offset = "0x2E78234", VA = "0x2E7C234")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public float remainingLifetime
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2E7CD74", Offset = "0x2E78D74", VA = "0x2E7CD74")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float startLifetime
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2E7C248", Offset = "0x2E78248", VA = "0x2E7C248")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Color32 startColor
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2E7C2CC", Offset = "0x2E782CC", VA = "0x2E7C2CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public uint randomSeed
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2E7C2D4", Offset = "0x2E782D4", VA = "0x2E7C2D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public float startSize
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2E7C250", Offset = "0x2E78250", VA = "0x2E7C250")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float rotation
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2E7CD88", Offset = "0x2E78D88", VA = "0x2E7CD88")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Vector3 rotation3D
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2E7C25C", Offset = "0x2E7825C", VA = "0x2E7C25C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Vector3 angularVelocity3D
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2E7C294", Offset = "0x2E78294", VA = "0x2E7C294")]
			set
			{
			}
		}
	}

	[Serializable]
	[Token(Token = "0x2000008")]
	[UnityEngine.Bindings.NativeType(UnityEngine.Bindings.CodegenOptions.Custom, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	public struct MinMaxCurve
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ParticleSystemCurveMode m_Mode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private float m_CurveMultiplier;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private AnimationCurve m_CurveMin;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AnimationCurve m_CurveMax;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_ConstantMin;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_ConstantMax;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2E7CDA0", Offset = "0x2E78DA0", VA = "0x2E7CDA0")]
		public MinMaxCurve(float constant)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2E7CDB4", Offset = "0x2E78DB4", VA = "0x2E7CDB4")]
		public static implicit operator MinMaxCurve(float constant)
		{
			return default(MinMaxCurve);
		}
	}

	[Token(Token = "0x2000009")]
	public struct EmitParams
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("particle")]
		private Particle m_Particle;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[UnityEngine.Bindings.NativeName("positionSet")]
		private bool m_PositionSet;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		[UnityEngine.Bindings.NativeName("velocitySet")]
		private bool m_VelocitySet;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		[UnityEngine.Bindings.NativeName("axisOfRotationSet")]
		private bool m_AxisOfRotationSet;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
		[UnityEngine.Bindings.NativeName("rotationSet")]
		private bool m_RotationSet;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[UnityEngine.Bindings.NativeName("rotationalSpeedSet")]
		private bool m_AngularVelocitySet;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[UnityEngine.Bindings.NativeName("startSizeSet")]
		private bool m_StartSizeSet;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		[UnityEngine.Bindings.NativeName("startColorSet")]
		private bool m_StartColorSet;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		[UnityEngine.Bindings.NativeName("randomSeedSet")]
		private bool m_RandomSeedSet;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[UnityEngine.Bindings.NativeName("startLifetimeSet")]
		private bool m_StartLifetimeSet;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[UnityEngine.Bindings.NativeName("meshIndexSet")]
		private bool m_MeshIndexSet;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E")]
		[UnityEngine.Bindings.NativeName("applyShapeToPosition")]
		private bool m_ApplyShapeToPosition;
	}

	[Token(Token = "0x17000001")]
	public extern bool isPlaying
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2E7C364", Offset = "0x2E78364", VA = "0x2E7C364")]
		[UnityEngine.Bindings.NativeName("SyncJobs(false)->IsPlaying")]
		get;
	}

	[Token(Token = "0x17000002")]
	public extern bool isEmitting
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2E7C3A0", Offset = "0x2E783A0", VA = "0x2E7C3A0")]
		[UnityEngine.Bindings.NativeName("SyncJobs(false)->IsEmitting")]
		get;
	}

	[Token(Token = "0x17000003")]
	public extern int particleCount
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2E7C3DC", Offset = "0x2E783DC", VA = "0x2E7C3DC")]
		[UnityEngine.Bindings.NativeName("SyncJobs(false)->GetParticleCount")]
		get;
	}

	[Token(Token = "0x17000004")]
	public extern float time
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2E7C418", Offset = "0x2E78418", VA = "0x2E7C418")]
		[UnityEngine.Bindings.NativeName("SyncJobs(false)->GetSecPosition")]
		get;
	}

	[Token(Token = "0x17000005")]
	public extern uint randomSeed
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2E7C454", Offset = "0x2E78454", VA = "0x2E7C454")]
		[UnityEngine.Bindings.NativeName("SyncJobs(false)->SetRandomSeed")]
		set;
	}

	[Token(Token = "0x17000006")]
	public extern bool useAutoRandomSeed
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2E7C498", Offset = "0x2E78498", VA = "0x2E7C498")]
		[UnityEngine.Bindings.NativeName("GetAutoRandomSeed")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2E7C4D4", Offset = "0x2E784D4", VA = "0x2E7C4D4")]
		[UnityEngine.Bindings.NativeName("SyncJobs(false)->SetAutoRandomSeed")]
		set;
	}

	[Token(Token = "0x17000007")]
	public MainModule main
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2E7C9C4", Offset = "0x2E789C4", VA = "0x2E7C9C4")]
		get
		{
			return default(MainModule);
		}
	}

	[Token(Token = "0x17000008")]
	public EmissionModule emission
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2E7C9D0", Offset = "0x2E789D0", VA = "0x2E7C9D0")]
		get
		{
			return default(EmissionModule);
		}
	}

	[Token(Token = "0x17000009")]
	public ShapeModule shape
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2E7C9DC", Offset = "0x2E789DC", VA = "0x2E7C9DC")]
		get
		{
			return default(ShapeModule);
		}
	}

	[Token(Token = "0x1700000A")]
	public SubEmittersModule subEmitters
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2E7C9E8", Offset = "0x2E789E8", VA = "0x2E7C9E8")]
		get
		{
			return default(SubEmittersModule);
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2E7C12C", Offset = "0x2E7812C", VA = "0x2E7C12C")]
	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2E7C320", Offset = "0x2E78320", VA = "0x2E7C320")]
	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
	public void Emit(Particle particle)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2E7C518", Offset = "0x2E78518", VA = "0x2E7C518")]
	[UnityEngine.Bindings.FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = true, ThrowsException = true)]
	public extern void SetParticles([Out] Particle[] particles, int size, int offset);

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2E7C574", Offset = "0x2E78574", VA = "0x2E7C574")]
	public void SetParticles([Out] Particle[] particles, int size)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2E7C5CC", Offset = "0x2E785CC", VA = "0x2E7C5CC")]
	[UnityEngine.Bindings.FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = true, ThrowsException = true)]
	public extern int GetParticles([Out][UnityEngine.Bindings.NotNull("ArgumentNullException")] Particle[] particles, int size, int offset);

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2E7C628", Offset = "0x2E78628", VA = "0x2E7C628")]
	public int GetParticles([Out] Particle[] particles, int size)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2E7C680", Offset = "0x2E78680", VA = "0x2E7C680")]
	public int GetParticles([Out] Particle[] particles)
	{
		return default(int);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2E7C6CC", Offset = "0x2E786CC", VA = "0x2E7C6CC")]
	[UnityEngine.Bindings.FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = true)]
	public extern void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep);

	[MethodImpl(4096)]
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2E7C738", Offset = "0x2E78738", VA = "0x2E7C738")]
	[UnityEngine.Bindings.FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = true)]
	public extern void Play([DefaultValue("true")] bool withChildren);

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2E7C77C", Offset = "0x2E7877C", VA = "0x2E7C77C")]
	public void Play()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2E7C7BC", Offset = "0x2E787BC", VA = "0x2E7C7BC")]
	[UnityEngine.Bindings.FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = true)]
	public extern void Stop([DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior);

	[MethodImpl(4096)]
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2E7C810", Offset = "0x2E78810", VA = "0x2E7C810")]
	[UnityEngine.Bindings.FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = true)]
	public extern void Clear([DefaultValue("true")] bool withChildren);

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2E7C854", Offset = "0x2E78854", VA = "0x2E7C854")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2E7C894", Offset = "0x2E78894", VA = "0x2E7C894")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public void Emit(int count)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2E7C8D8", Offset = "0x2E788D8", VA = "0x2E7C8D8")]
	[UnityEngine.Bindings.NativeName("SyncJobs()->Emit")]
	private extern void Emit_Internal(int count);

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2E7C91C", Offset = "0x2E7891C", VA = "0x2E7C91C")]
	[UnityEngine.Bindings.NativeName("SyncJobs()->EmitParticlesExternal")]
	public void Emit(EmitParams emitParams, int count)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2E7C2DC", Offset = "0x2E782DC", VA = "0x2E7C2DC")]
	[UnityEngine.Bindings.NativeName("SyncJobs()->EmitParticleExternal")]
	private extern void EmitOld_Internal(ref Particle particle);

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2E7C9F4", Offset = "0x2E789F4", VA = "0x2E7C9F4")]
	public ParticleSystem()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2E7C970", Offset = "0x2E78970", VA = "0x2E7C970")]
	private extern void Emit_Injected(ref EmitParams emitParams, int count);
}
[Token(Token = "0x200000A")]
public enum ParticleSystemCurveMode
{
	[Token(Token = "0x4000029")]
	Constant,
	[Token(Token = "0x400002A")]
	Curve,
	[Token(Token = "0x400002B")]
	TwoCurves,
	[Token(Token = "0x400002C")]
	TwoConstants
}
[Token(Token = "0x200000B")]
public enum ParticleSystemStopBehavior
{
	[Token(Token = "0x400002E")]
	StopEmittingAndClear,
	[Token(Token = "0x400002F")]
	StopEmitting
}
[Token(Token = "0x200000C")]
[UnityEngine.Bindings.NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[UnityEngine.Bindings.NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[RequireComponent(typeof(Transform))]
[UnityEngine.Bindings.NativeHeader("ParticleSystemScriptingClasses.h")]
public sealed class ParticleSystemRenderer : Renderer
{
	[MethodImpl(4096)]
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2E7CDC8", Offset = "0x2E78DC8", VA = "0x2E7CDC8")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = true)]
	public extern int GetMeshes([Out][UnityEngine.Bindings.NotNull("ArgumentNullException")] Mesh[] meshes);
}
