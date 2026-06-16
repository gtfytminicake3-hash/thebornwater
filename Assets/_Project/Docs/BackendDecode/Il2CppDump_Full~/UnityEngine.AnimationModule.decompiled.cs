using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Animations;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine
{
	[Token(Token = "0x2000002")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public sealed class SharedBetweenAnimatorsAttribute : Attribute
	{
	}
	[Token(Token = "0x2000003")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public abstract class StateMachineBehaviour : ScriptableObject
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2DE473C", Offset = "0x2DE073C", VA = "0x2DE473C", Slot = "4")]
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2DE4740", Offset = "0x2DE0740", VA = "0x2DE4740", Slot = "5")]
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2DE4744", Offset = "0x2DE0744", VA = "0x2DE4744", Slot = "6")]
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2DE4748", Offset = "0x2DE0748", VA = "0x2DE4748", Slot = "7")]
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2DE474C", Offset = "0x2DE074C", VA = "0x2DE474C", Slot = "8")]
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2DE4750", Offset = "0x2DE0750", VA = "0x2DE4750", Slot = "9")]
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2DE4754", Offset = "0x2DE0754", VA = "0x2DE4754", Slot = "10")]
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2DE4758", Offset = "0x2DE0758", VA = "0x2DE4758", Slot = "11")]
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2DE475C", Offset = "0x2DE075C", VA = "0x2DE475C", Slot = "12")]
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2DE4760", Offset = "0x2DE0760", VA = "0x2DE4760", Slot = "13")]
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2DE4764", Offset = "0x2DE0764", VA = "0x2DE4764", Slot = "14")]
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2DE4768", Offset = "0x2DE0768", VA = "0x2DE4768", Slot = "15")]
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2DE476C", Offset = "0x2DE076C", VA = "0x2DE476C", Slot = "16")]
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2DE4770", Offset = "0x2DE0770", VA = "0x2DE4770", Slot = "17")]
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2DE4774", Offset = "0x2DE0774", VA = "0x2DE4774")]
		protected StateMachineBehaviour()
		{
		}
	}
	[Token(Token = "0x2000004")]
	internal enum AnimationEventSource
	{
		[Token(Token = "0x4000002")]
		NoSource,
		[Token(Token = "0x4000003")]
		Legacy,
		[Token(Token = "0x4000004")]
		Animator
	}
	[Token(Token = "0x2000005")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/AnimationState.h")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public sealed class AnimationState : TrackedReference
	{
	}
	[Serializable]
	[StructLayout(0)]
	[Token(Token = "0x2000006")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public sealed class AnimationEvent
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float m_Time;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string m_FunctionName;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string m_StringParameter;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Object m_ObjectReferenceParameter;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal float m_FloatParameter;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal int m_IntParameter;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int m_MessageOptions;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal AnimationEventSource m_Source;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal AnimationState m_StateSender;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal AnimatorStateInfo m_AnimatorStateInfo;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal AnimatorClipInfo m_AnimatorClipInfo;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2DE477C", Offset = "0x2DE077C", VA = "0x2DE477C")]
		public AnimationEvent()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
	[UnityEngine.Bindings.NativeType("Modules/Animation/AnimationClip.h")]
	public sealed class AnimationClip : Motion
	{
		[Token(Token = "0x17000001")]
		[UnityEngine.Bindings.NativeProperty("Length", false, UnityEngine.Bindings.TargetType.Function)]
		public extern float length
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2DE48B4", Offset = "0x2DE08B4", VA = "0x2DE48B4")]
			get;
		}

		[Token(Token = "0x17000002")]
		[UnityEngine.Bindings.NativeProperty("SampleRate", false, UnityEngine.Bindings.TargetType.Function)]
		public extern float frameRate
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2DE48F0", Offset = "0x2DE08F0", VA = "0x2DE48F0")]
			get;
			[MethodImpl(4096)]
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2DE492C", Offset = "0x2DE092C", VA = "0x2DE492C")]
			set;
		}

		[Token(Token = "0x17000003")]
		public extern bool legacy
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2DE4978", Offset = "0x2DE0978", VA = "0x2DE4978")]
			[UnityEngine.Bindings.NativeMethod("IsLegacy")]
			get;
			[MethodImpl(4096)]
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2DE49B4", Offset = "0x2DE09B4", VA = "0x2DE49B4")]
			[UnityEngine.Bindings.NativeMethod("SetLegacy")]
			set;
		}

		[Token(Token = "0x17000004")]
		public extern bool empty
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2DE49F8", Offset = "0x2DE09F8", VA = "0x2DE49F8")]
			[UnityEngine.Bindings.NativeMethod("IsEmpty")]
			get;
		}

		[Token(Token = "0x17000005")]
		public extern bool hasGenericRootTransform
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2DE4A34", Offset = "0x2DE0A34", VA = "0x2DE4A34")]
			[UnityEngine.Bindings.NativeMethod("HasGenericRootTransform")]
			get;
		}

		[Token(Token = "0x17000006")]
		public extern bool hasMotionCurves
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2DE4A70", Offset = "0x2DE0A70", VA = "0x2DE4A70")]
			[UnityEngine.Bindings.NativeMethod("HasMotionCurves")]
			get;
		}

		[Token(Token = "0x17000007")]
		public extern bool hasRootCurves
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2DE4AAC", Offset = "0x2DE0AAC", VA = "0x2DE4AAC")]
			[UnityEngine.Bindings.NativeMethod("HasRootCurves")]
			get;
		}

		[Token(Token = "0x17000008")]
		internal extern bool hasRootMotion
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2DE4AE8", Offset = "0x2DE0AE8", VA = "0x2DE4AE8")]
			[UnityEngine.Bindings.FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = true)]
			get;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2DE47E0", Offset = "0x2DE07E0", VA = "0x2DE47E0")]
		public AnimationClip()
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2DE4878", Offset = "0x2DE0878", VA = "0x2DE4878")]
		[UnityEngine.Bindings.FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
		private static extern void Internal_CreateAnimationClip([UnityEngine.Writable] AnimationClip self);
	}
	[Token(Token = "0x2000008")]
	internal enum StateInfoIndex
	{
		[Token(Token = "0x4000011")]
		CurrentState,
		[Token(Token = "0x4000012")]
		NextState,
		[Token(Token = "0x4000013")]
		ExitState,
		[Token(Token = "0x4000014")]
		InterruptedState
	}
	[Token(Token = "0x2000009")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[UnityEngine.Scripting.UsedByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	public struct AnimatorClipInfo
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_ClipInstanceID;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private float m_Weight;
	}
	[Token(Token = "0x200000A")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/AnimatorInfo.h")]
	public struct AnimatorStateInfo
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_Name;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private int m_Path;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int m_FullPath;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private float m_NormalizedTime;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_Length;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_Speed;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_SpeedMultiplier;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_Tag;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Loop;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2DE4B24", Offset = "0x2DE0B24", VA = "0x2DE4B24")]
		public bool IsName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000B")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public struct AnimatorTransitionInfo
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("fullPathHash")]
		private int m_FullPath;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[UnityEngine.Bindings.NativeName("userNameHash")]
		private int m_UserName;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[UnityEngine.Bindings.NativeName("nameHash")]
		private int m_Name;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[UnityEngine.Bindings.NativeName("hasFixedDuration")]
		private bool m_HasFixedDuration;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[UnityEngine.Bindings.NativeName("duration")]
		private float m_Duration;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[UnityEngine.Bindings.NativeName("normalizedTime")]
		private float m_NormalizedTime;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[UnityEngine.Bindings.NativeName("anyState")]
		private bool m_AnyState;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[UnityEngine.Bindings.NativeName("transitionType")]
		private int m_TransitionType;
	}
	[Token(Token = "0x200000C")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[UnityEngine.Scripting.UsedByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Animator.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	public class Animator : Behaviour
	{
		[Token(Token = "0x17000009")]
		public extern bool isHuman
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2DE4BD0", Offset = "0x2DE0BD0", VA = "0x2DE4BD0")]
			[UnityEngine.Bindings.NativeMethod("IsHuman")]
			get;
		}

		[Token(Token = "0x1700000A")]
		public extern bool hasRootMotion
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x2DE4C0C", Offset = "0x2DE0C0C", VA = "0x2DE4C0C")]
			[UnityEngine.Bindings.NativeMethod("HasRootMotion")]
			get;
		}

		[Token(Token = "0x1700000B")]
		public extern float speed
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2DE51E4", Offset = "0x2DE11E4", VA = "0x2DE51E4")]
			get;
			[MethodImpl(4096)]
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2DE5220", Offset = "0x2DE1220", VA = "0x2DE5220")]
			set;
		}

		[Token(Token = "0x1700000C")]
		public extern RuntimeAnimatorController runtimeAnimatorController
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2DE53C0", Offset = "0x2DE13C0", VA = "0x2DE53C0")]
			get;
		}

		[Token(Token = "0x1700000D")]
		public extern bool hasBoundPlayables
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2DE53FC", Offset = "0x2DE13FC", VA = "0x2DE53FC")]
			[UnityEngine.Bindings.NativeMethod("HasBoundPlayables")]
			get;
		}

		[Token(Token = "0x1700000E")]
		public extern Avatar avatar
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2DE5438", Offset = "0x2DE1438", VA = "0x2DE5438")]
			get;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2DE4C48", Offset = "0x2DE0C48", VA = "0x2DE4C48")]
		public void SetFloat(string name, float value)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2DE4CF0", Offset = "0x2DE0CF0", VA = "0x2DE4CF0")]
		public void SetFloat(int id, float value)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2DE4D98", Offset = "0x2DE0D98", VA = "0x2DE4D98")]
		public bool GetBool(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2DE4E20", Offset = "0x2DE0E20", VA = "0x2DE4E20")]
		public void SetBool(string name, bool value)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2DE4EC8", Offset = "0x2DE0EC8", VA = "0x2DE4EC8")]
		public void SetBool(int id, bool value)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2DE4F70", Offset = "0x2DE0F70", VA = "0x2DE4F70")]
		public void SetTrigger(string name)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2DE4FF8", Offset = "0x2DE0FF8", VA = "0x2DE4FF8")]
		public void SetTrigger(int id)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2DE5080", Offset = "0x2DE1080", VA = "0x2DE5080")]
		public void ResetTrigger(string name)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2DE5108", Offset = "0x2DE1108", VA = "0x2DE5108")]
		private extern void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info);

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2DE5164", Offset = "0x2DE1164", VA = "0x2DE5164")]
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			return default(AnimatorStateInfo);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2DE526C", Offset = "0x2DE126C", VA = "0x2DE526C")]
		public void Play(string stateName)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2DE527C", Offset = "0x2DE127C", VA = "0x2DE527C")]
		public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2DE530C", Offset = "0x2DE130C", VA = "0x2DE530C")]
		[UnityEngine.Bindings.FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
		public extern void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2DE5370", Offset = "0x2DE1370", VA = "0x2DE5370")]
		public void Play(int stateNameHash)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2DE4B94", Offset = "0x2DE0B94", VA = "0x2DE4B94")]
		[UnityEngine.Bindings.NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
		public static extern int StringToHash(string name);

		[MethodImpl(4096)]
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2DE4C9C", Offset = "0x2DE0C9C", VA = "0x2DE4C9C")]
		[UnityEngine.Bindings.FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = true)]
		private extern void SetFloatString(string name, float value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2DE4D44", Offset = "0x2DE0D44", VA = "0x2DE4D44")]
		[UnityEngine.Bindings.FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = true)]
		private extern void SetFloatID(int id, float value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2DE4E74", Offset = "0x2DE0E74", VA = "0x2DE4E74")]
		[UnityEngine.Bindings.FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = true)]
		private extern void SetBoolString(string name, bool value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2DE4F1C", Offset = "0x2DE0F1C", VA = "0x2DE4F1C")]
		[UnityEngine.Bindings.FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = true)]
		private extern void SetBoolID(int id, bool value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2DE4DDC", Offset = "0x2DE0DDC", VA = "0x2DE4DDC")]
		[UnityEngine.Bindings.FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = true)]
		private extern bool GetBoolID(int id);

		[MethodImpl(4096)]
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2DE4FB4", Offset = "0x2DE0FB4", VA = "0x2DE4FB4")]
		[UnityEngine.Bindings.FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
		private extern void SetTriggerString(string name);

		[MethodImpl(4096)]
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2DE503C", Offset = "0x2DE103C", VA = "0x2DE503C")]
		[UnityEngine.Bindings.FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = true)]
		private extern void SetTriggerID(int id);

		[MethodImpl(4096)]
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2DE50C4", Offset = "0x2DE10C4", VA = "0x2DE50C4")]
		[UnityEngine.Bindings.FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
		private extern void ResetTriggerString(string name);

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2DE5474", Offset = "0x2DE1474", VA = "0x2DE5474")]
		public Animator()
		{
		}
	}
	[Token(Token = "0x200000D")]
	[UnityEngine.Scripting.UsedByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	[DefaultMember("Item")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
		[Token(Token = "0x200000E")]
		internal delegate void OnOverrideControllerDirtyCallback();

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2DE547C", Offset = "0x2DE147C", VA = "0x2DE547C")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		[UnityEngine.Bindings.NativeConditional("UNITY_EDITOR")]
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller)
		{
		}
	}
	[Token(Token = "0x200000F")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Avatar.h")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public class Avatar : Object
	{
		[Token(Token = "0x1700000F")]
		public HumanDescription humanDescription
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2DE5598", Offset = "0x2DE1598", VA = "0x2DE5598")]
			get
			{
				return default(HumanDescription);
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2DE5540", Offset = "0x2DE1540", VA = "0x2DE5540")]
		private Avatar()
		{
		}

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2DE5604", Offset = "0x2DE1604", VA = "0x2DE5604")]
		private extern void get_humanDescription_Injected(out HumanDescription ret);
	}
	[Token(Token = "0x2000010")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.NativeType(UnityEngine.Bindings.CodegenOptions.Custom, "MonoSkeletonBone")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/HumanDescription.h")]
	public struct SkeletonBone
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("m_Name")]
		public string name;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[UnityEngine.Bindings.NativeName("m_ParentName")]
		internal string parentName;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[UnityEngine.Bindings.NativeName("m_Position")]
		public Vector3 position;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[UnityEngine.Bindings.NativeName("m_Rotation")]
		public Quaternion rotation;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[UnityEngine.Bindings.NativeName("m_Scale")]
		public Vector3 scale;
	}
	[Token(Token = "0x2000011")]
	[UnityEngine.Bindings.NativeType(UnityEngine.Bindings.CodegenOptions.Custom, "MonoHumanLimit")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/HumanDescription.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
	public struct HumanLimit
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 m_Min;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Vector3 m_Max;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 m_Center;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_AxisLength;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_UseDefaultValues;
	}
	[Token(Token = "0x2000012")]
	[UnityEngine.Bindings.NativeType(UnityEngine.Bindings.CodegenOptions.Custom, "MonoHumanBone")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/HumanDescription.h")]
	public struct HumanBone
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string m_BoneName;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string m_HumanName;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[UnityEngine.Bindings.NativeName("m_Limit")]
		public HumanLimit limit;
	}
	[Token(Token = "0x2000013")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/HumanDescription.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
	public struct HumanDescription
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.NativeName("m_Human")]
		public HumanBone[] human;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[UnityEngine.Bindings.NativeName("m_Skeleton")]
		public SkeletonBone[] skeleton;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float m_ArmTwist;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float m_ForeArmTwist;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal float m_UpperLegTwist;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal float m_LegTwist;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float m_ArmStretch;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float m_LegStretch;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal float m_FeetSpacing;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal float m_GlobalScale;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal string m_RootMotionBoneName;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal bool m_HasTranslationDoF;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		internal bool m_HasExtraRoot;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		internal bool m_SkeletonHasParents;
	}
	[Token(Token = "0x2000014")]
	[MovedFrom(true, "UnityEditor.Animations", "UnityEditor", null)]
	public enum AvatarMaskBodyPart
	{
		[Token(Token = "0x4000045")]
		Root,
		[Token(Token = "0x4000046")]
		Body,
		[Token(Token = "0x4000047")]
		Head,
		[Token(Token = "0x4000048")]
		LeftLeg,
		[Token(Token = "0x4000049")]
		RightLeg,
		[Token(Token = "0x400004A")]
		LeftArm,
		[Token(Token = "0x400004B")]
		RightArm,
		[Token(Token = "0x400004C")]
		LeftFingers,
		[Token(Token = "0x400004D")]
		RightFingers,
		[Token(Token = "0x400004E")]
		LeftFootIK,
		[Token(Token = "0x400004F")]
		RightFootIK,
		[Token(Token = "0x4000050")]
		LeftHandIK,
		[Token(Token = "0x4000051")]
		RightHandIK,
		[Token(Token = "0x4000052")]
		LastBodyPart
	}
	[Token(Token = "0x2000015")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/AvatarMask.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UnityEngine.Scripting.UsedByNativeCode]
	[MovedFrom(true, "UnityEditor.Animations", "UnityEditor", null)]
	public sealed class AvatarMask : Object
	{
		[Token(Token = "0x17000010")]
		public extern int transformCount
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x2DE5748", Offset = "0x2DE1748", VA = "0x2DE5748")]
			get;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2DE5648", Offset = "0x2DE1648", VA = "0x2DE5648")]
		public AvatarMask()
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2DE56C8", Offset = "0x2DE16C8", VA = "0x2DE56C8")]
		[UnityEngine.Bindings.FreeFunction("AnimationBindings::CreateAvatarMask")]
		private static extern void Internal_Create([UnityEngine.Writable] AvatarMask self);

		[MethodImpl(4096)]
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2DE5704", Offset = "0x2DE1704", VA = "0x2DE5704")]
		[UnityEngine.Bindings.NativeMethod("GetBodyPart")]
		public extern bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index);

		[MethodImpl(4096)]
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2DE5784", Offset = "0x2DE1784", VA = "0x2DE5784")]
		public extern string GetTransformPath(int index);

		[MethodImpl(4096)]
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2DE57C8", Offset = "0x2DE17C8", VA = "0x2DE57C8")]
		private extern float GetTransformWeight(int index);

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2DE580C", Offset = "0x2DE180C", VA = "0x2DE580C")]
		public bool GetTransformActive(int index)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000016")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Motion.h")]
	public class Motion : Object
	{
		[Token(Token = "0x17000011")]
		public extern bool isLooping
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2DE5860", Offset = "0x2DE1860", VA = "0x2DE5860")]
			[UnityEngine.Bindings.NativeMethod("IsLooping")]
			get;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2DE4820", Offset = "0x2DE0820", VA = "0x2DE4820")]
		protected Motion()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExcludeFromObjectFactory]
	[UnityEngine.Scripting.UsedByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	public class RuntimeAnimatorController : Object
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2DE589C", Offset = "0x2DE189C", VA = "0x2DE589C")]
		protected RuntimeAnimatorController()
		{
		}
	}
}
namespace UnityEngine.Playables
{
	[Token(Token = "0x2000018")]
	public static class AnimationPlayableUtilities
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2DE58F4", Offset = "0x2DE18F4", VA = "0x2DE58F4")]
		public static AnimationClipPlayable PlayClip(Animator animator, AnimationClip clip, out PlayableGraph graph)
		{
			return default(AnimationClipPlayable);
		}
	}
}
namespace UnityEngine.Animations
{
	[Token(Token = "0x2000019")]
	public static class AnimationPlayableBinding
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2DE5B30", Offset = "0x2DE1B30", VA = "0x2DE5B30")]
		public static PlayableBinding Create(string name, Object key)
		{
			return default(PlayableBinding);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2DE5C60", Offset = "0x2DE1C60", VA = "0x2DE5C60")]
		private static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name)
		{
			return default(PlayableOutput);
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeUsage(AttributeTargets.Field)]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public class DiscreteEvaluationAttribute : Attribute
	{
	}
	[Token(Token = "0x200001B")]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	public interface IAnimationWindowPreview
	{
		[Token(Token = "0x6000050")]
		void UpdatePreviewGraph(PlayableGraph graph);
	}
	[Token(Token = "0x200001C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public class NotKeyableAttribute : Attribute
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2DE5CD0", Offset = "0x2DE1CD0", VA = "0x2DE5CD0")]
		public NotKeyableAttribute()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.StaticAccessor("AnimationClipPlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable>
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2DE5AA8", Offset = "0x2DE1AA8", VA = "0x2DE5AA8")]
		public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip)
		{
			return default(AnimationClipPlayable);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2DE5CD8", Offset = "0x2DE1CD8", VA = "0x2DE5CD8")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip)
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2DE5DA4", Offset = "0x2DE1DA4", VA = "0x2DE5DA4")]
		internal AnimationClipPlayable(PlayableHandle handle)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2DE5EF0", Offset = "0x2DE1EF0", VA = "0x2DE5EF0", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2DE5EFC", Offset = "0x2DE1EFC", VA = "0x2DE5EFC")]
		public static implicit operator Playable(AnimationClipPlayable playable)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2DE5F2C", Offset = "0x2DE1F2C", VA = "0x2DE5F2C", Slot = "5")]
		public bool Equals(AnimationClipPlayable other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2DE5FA4", Offset = "0x2DE1FA4", VA = "0x2DE5FA4")]
		public void SetApplyFootIK(bool value)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2DE602C", Offset = "0x2DE202C", VA = "0x2DE602C")]
		internal void SetRemoveStartOffset(bool value)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2DE60B4", Offset = "0x2DE20B4", VA = "0x2DE60B4")]
		internal void SetOverrideLoopTime(bool value)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2DE613C", Offset = "0x2DE213C", VA = "0x2DE613C")]
		internal void SetLoopTime(bool value)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2DE5E94", Offset = "0x2DE1E94", VA = "0x2DE5E94")]
		[UnityEngine.Bindings.NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2DE5FE8", Offset = "0x2DE1FE8", VA = "0x2DE5FE8")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetApplyFootIKInternal(ref PlayableHandle handle, bool value);

		[MethodImpl(4096)]
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2DE6070", Offset = "0x2DE2070", VA = "0x2DE6070")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value);

		[MethodImpl(4096)]
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2DE60F8", Offset = "0x2DE20F8", VA = "0x2DE60F8")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2DE6180", Offset = "0x2DE2180", VA = "0x2DE6180")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetLoopTimeInternal(ref PlayableHandle handle, bool value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2DE61C4", Offset = "0x2DE21C4", VA = "0x2DE61C4")]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle);
	}
	[Token(Token = "0x200001E")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	public struct AnimationHumanStream
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr stream;
	}
	[Token(Token = "0x200001F")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.StaticAccessor("AnimationLayerMixerPlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
	public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable>
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimationLayerMixerPlayable m_NullPlayable;

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2DE6218", Offset = "0x2DE2218", VA = "0x2DE6218")]
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization)
		{
			return default(AnimationLayerMixerPlayable);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2DE62C0", Offset = "0x2DE22C0", VA = "0x2DE62C0")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0)
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2DE63AC", Offset = "0x2DE23AC", VA = "0x2DE63AC")]
		internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2DE65C8", Offset = "0x2DE25C8", VA = "0x2DE65C8", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2DE65D4", Offset = "0x2DE25D4", VA = "0x2DE65D4")]
		public static implicit operator Playable(AnimationLayerMixerPlayable playable)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2DE6654", Offset = "0x2DE2654", VA = "0x2DE6654", Slot = "5")]
		public bool Equals(AnimationLayerMixerPlayable other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2DE66F0", Offset = "0x2DE26F0", VA = "0x2DE66F0")]
		public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2DE64F8", Offset = "0x2DE24F8", VA = "0x2DE64F8")]
		[UnityEngine.Bindings.NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2DE6584", Offset = "0x2DE2584", VA = "0x2DE6584")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value);

		[MethodImpl(4096)]
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2DE6904", Offset = "0x2DE2904", VA = "0x2DE6904")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask);

		[MethodImpl(4096)]
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2DE6958", Offset = "0x2DE2958", VA = "0x2DE6958")]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle);
	}
	[Token(Token = "0x2000020")]
	[UnityEngine.Bindings.StaticAccessor("AnimationMixerPlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable>
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimationMixerPlayable m_NullPlayable;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2DE6A3C", Offset = "0x2DE2A3C", VA = "0x2DE6A3C")]
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0)
		{
			return default(AnimationMixerPlayable);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2DE6AD4", Offset = "0x2DE2AD4", VA = "0x2DE6AD4")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0)
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2DE6BC0", Offset = "0x2DE2BC0", VA = "0x2DE6BC0")]
		internal AnimationMixerPlayable(PlayableHandle handle)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2DE6D3C", Offset = "0x2DE2D3C", VA = "0x2DE6D3C", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2DE6D48", Offset = "0x2DE2D48", VA = "0x2DE6D48")]
		public static implicit operator Playable(AnimationMixerPlayable playable)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2DE6DC8", Offset = "0x2DE2DC8", VA = "0x2DE6DC8", Slot = "5")]
		public bool Equals(AnimationMixerPlayable other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2DE6CB0", Offset = "0x2DE2CB0", VA = "0x2DE6CB0")]
		[UnityEngine.Bindings.NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2DE6E64", Offset = "0x2DE2E64", VA = "0x2DE6E64")]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle);
	}
	[Token(Token = "0x2000021")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
	[UnityEngine.Bindings.StaticAccessor("AnimationMotionXToDeltaPlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable>
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable;

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2DE6F44", Offset = "0x2DE2F44", VA = "0x2DE6F44")]
		public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph)
		{
			return default(AnimationMotionXToDeltaPlayable);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2DE6FD4", Offset = "0x2DE2FD4", VA = "0x2DE6FD4")]
		private static PlayableHandle CreateHandle(PlayableGraph graph)
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2DE70BC", Offset = "0x2DE30BC", VA = "0x2DE70BC")]
		private AnimationMotionXToDeltaPlayable(PlayableHandle handle)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2DE7238", Offset = "0x2DE3238", VA = "0x2DE7238", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2DE7244", Offset = "0x2DE3244", VA = "0x2DE7244")]
		public static implicit operator Playable(AnimationMotionXToDeltaPlayable playable)
		{
			return default(Playable);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2DE72C4", Offset = "0x2DE32C4", VA = "0x2DE72C4", Slot = "5")]
		public bool Equals(AnimationMotionXToDeltaPlayable other)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2DE7360", Offset = "0x2DE3360", VA = "0x2DE7360")]
		public void SetAbsoluteMotion(bool value)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2DE71AC", Offset = "0x2DE31AC", VA = "0x2DE71AC")]
		[UnityEngine.Bindings.NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2DE73E4", Offset = "0x2DE33E4", VA = "0x2DE73E4")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value);

		[MethodImpl(4096)]
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2DE7428", Offset = "0x2DE3428", VA = "0x2DE7428")]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle);
	}
	[Token(Token = "0x2000022")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.StaticAccessor("AnimationOffsetPlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable>
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimationOffsetPlayable m_NullPlayable;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2DE7508", Offset = "0x2DE3508", VA = "0x2DE7508")]
		public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			return default(AnimationOffsetPlayable);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2DE75F8", Offset = "0x2DE35F8", VA = "0x2DE75F8")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2DE773C", Offset = "0x2DE373C", VA = "0x2DE773C")]
		internal AnimationOffsetPlayable(PlayableHandle handle)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2DE78D0", Offset = "0x2DE38D0", VA = "0x2DE78D0", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2DE78DC", Offset = "0x2DE38DC", VA = "0x2DE78DC")]
		public static implicit operator Playable(AnimationOffsetPlayable playable)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2DE795C", Offset = "0x2DE395C", VA = "0x2DE795C", Slot = "5")]
		public bool Equals(AnimationOffsetPlayable other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2DE782C", Offset = "0x2DE382C", VA = "0x2DE782C")]
		[UnityEngine.Bindings.NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2DE7A10", Offset = "0x2DE3A10", VA = "0x2DE7A10")]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle);
	}
	[Token(Token = "0x2000023")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/AnimationClip.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public static class AnimationPlayableExtensions
	{
		[Token(Token = "0x600008B")]
		public static void SetAnimatedProperties<U>(this U playable, AnimationClip clip) where U : struct, IPlayable
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2DE7B08", Offset = "0x2DE3B08", VA = "0x2DE7B08")]
		[UnityEngine.Bindings.NativeThrows]
		internal static extern void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties);
	}
	[Token(Token = "0x2000024")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableGraphExtensions.bindings.h")]
	[UnityEngine.Bindings.StaticAccessor("AnimationPlayableGraphExtensionsBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Animator.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	internal static class AnimationPlayableGraphExtensions
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2DE5AE0", Offset = "0x2DE1AE0", VA = "0x2DE5AE0")]
		internal static void SyncUpdateAndTimeMode(this PlayableGraph graph, Animator animator)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2DE7B90", Offset = "0x2DE3B90", VA = "0x2DE7B90")]
		[UnityEngine.Bindings.NativeThrows]
		internal static extern bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle);

		[MethodImpl(4096)]
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2DE7B4C", Offset = "0x2DE3B4C", VA = "0x2DE7B4C")]
		[UnityEngine.Bindings.NativeThrows]
		internal static extern void InternalSyncUpdateAndTimeMode(ref PlayableGraph graph, [UnityEngine.Bindings.NotNull("ArgumentNullException")] Animator animator);
	}
	[Token(Token = "0x2000025")]
	[UnityEngine.Bindings.StaticAccessor("AnimationPlayableOutputBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Animator.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
	public struct AnimationPlayableOutput : IPlayableOutput
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;

		[Token(Token = "0x17000012")]
		public static AnimationPlayableOutput Null
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x2DE7BE4", Offset = "0x2DE3BE4", VA = "0x2DE7BE4")]
			get
			{
				return default(AnimationPlayableOutput);
			}
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2DE5A00", Offset = "0x2DE1A00", VA = "0x2DE5A00")]
		public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target)
		{
			return default(AnimationPlayableOutput);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2DE7C60", Offset = "0x2DE3C60", VA = "0x2DE7C60")]
		internal AnimationPlayableOutput(PlayableOutputHandle handle)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2DE7D94", Offset = "0x2DE3D94", VA = "0x2DE7D94", Slot = "4")]
		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2DE5CA0", Offset = "0x2DE1CA0", VA = "0x2DE5CA0")]
		public static implicit operator PlayableOutput(AnimationPlayableOutput output)
		{
			return default(PlayableOutput);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2DE7DA0", Offset = "0x2DE3DA0", VA = "0x2DE7DA0")]
		public static explicit operator AnimationPlayableOutput(PlayableOutput output)
		{
			return default(AnimationPlayableOutput);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2DE7E24", Offset = "0x2DE3E24", VA = "0x2DE7E24")]
		public Animator GetTarget()
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2DE7D50", Offset = "0x2DE3D50", VA = "0x2DE7D50")]
		public void SetTarget(Animator value)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2DE7E60", Offset = "0x2DE3E60", VA = "0x2DE7E60")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern Animator InternalGetTarget(ref PlayableOutputHandle handle);

		[MethodImpl(4096)]
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2DE7E9C", Offset = "0x2DE3E9C", VA = "0x2DE7E9C")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void InternalSetTarget(ref PlayableOutputHandle handle, Animator target);
	}
	[Token(Token = "0x2000026")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.StaticAccessor("AnimationPosePlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayable.h")]
	internal struct AnimationPosePlayable : IPlayable, IEquatable<AnimationPosePlayable>
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimationPosePlayable m_NullPlayable;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2DE7EE0", Offset = "0x2DE3EE0", VA = "0x2DE7EE0")]
		internal AnimationPosePlayable(PlayableHandle handle)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2DE7FD0", Offset = "0x2DE3FD0", VA = "0x2DE7FD0", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2DE7FDC", Offset = "0x2DE3FDC", VA = "0x2DE7FDC", Slot = "5")]
		public bool Equals(AnimationPosePlayable other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000027")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[UnityEngine.Bindings.StaticAccessor("AnimationRemoveScalePlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
	internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable>
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimationRemoveScalePlayable m_NullPlayable;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2DE812C", Offset = "0x2DE412C", VA = "0x2DE812C")]
		public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount)
		{
			return default(AnimationRemoveScalePlayable);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2DE81C4", Offset = "0x2DE41C4", VA = "0x2DE81C4")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount)
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2DE82B0", Offset = "0x2DE42B0", VA = "0x2DE82B0")]
		internal AnimationRemoveScalePlayable(PlayableHandle handle)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2DE842C", Offset = "0x2DE442C", VA = "0x2DE842C", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2DE8438", Offset = "0x2DE4438", VA = "0x2DE8438")]
		public static implicit operator Playable(AnimationRemoveScalePlayable playable)
		{
			return default(Playable);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2DE84B8", Offset = "0x2DE44B8", VA = "0x2DE84B8", Slot = "5")]
		public bool Equals(AnimationRemoveScalePlayable other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2DE83A0", Offset = "0x2DE43A0", VA = "0x2DE83A0")]
		[UnityEngine.Bindings.NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2DE856C", Offset = "0x2DE456C", VA = "0x2DE856C")]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle);
	}
	[Token(Token = "0x2000028")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[UnityEngine.Bindings.StaticAccessor("AnimationScriptPlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable>
	{
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimationScriptPlayable m_NullPlayable;

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2DE864C", Offset = "0x2DE464C", VA = "0x2DE864C")]
		internal AnimationScriptPlayable(PlayableHandle handle)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2DE873C", Offset = "0x2DE473C", VA = "0x2DE873C", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2DE8748", Offset = "0x2DE4748", VA = "0x2DE8748", Slot = "5")]
		public bool Equals(AnimationScriptPlayable other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000029")]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public struct AnimationStream
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint m_AnimatorBindingsVersion;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr constant;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr input;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr output;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr workspace;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr inputStreamAccessor;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IntPtr animationHandleBinder;
	}
	[Token(Token = "0x200002A")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[UnityEngine.Bindings.StaticAccessor("AnimatorControllerPlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable>
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimatorControllerPlayable m_NullPlayable;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2DE8880", Offset = "0x2DE4880", VA = "0x2DE8880")]
		internal AnimatorControllerPlayable(PlayableHandle handle)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2DE8A68", Offset = "0x2DE4A68", VA = "0x2DE8A68", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2DE8924", Offset = "0x2DE4924", VA = "0x2DE8924")]
		public void SetHandle(PlayableHandle handle)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2DE8A74", Offset = "0x2DE4A74", VA = "0x2DE8A74", Slot = "5")]
		public bool Equals(AnimatorControllerPlayable other)
		{
			return default(bool);
		}
	}
}
