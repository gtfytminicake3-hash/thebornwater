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
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("1.0.0.0")]
[Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
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
	[Address(RVA = "0x2DAD6F4", Offset = "0x2DA96F4", VA = "0x2DAD6F4")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2DAD7B0", Offset = "0x2DA97B0", VA = "0x2DAD7B0")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace UnityEngine.Timeline;

[Token(Token = "0x2000004")]
internal class ActivationMixerPlayable : PlayableBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private ActivationTrack.PostPlaybackState m_PostPlaybackState;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private bool m_BoundGameObjectInitialStateIsActive;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject m_BoundGameObject;

	[Token(Token = "0x17000001")]
	public ActivationTrack.PostPlaybackState postPlaybackState
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2DAD83C", Offset = "0x2DA983C", VA = "0x2DAD83C")]
		get
		{
			return default(ActivationTrack.PostPlaybackState);
		}
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2DAD844", Offset = "0x2DA9844", VA = "0x2DAD844")]
		set
		{
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2DAD7B8", Offset = "0x2DA97B8", VA = "0x2DAD7B8")]
	public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount)
	{
		return default(ScriptPlayable<ActivationMixerPlayable>);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2DAD84C", Offset = "0x2DA984C", VA = "0x2DAD84C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2DAD90C", Offset = "0x2DA990C", VA = "0x2DAD90C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2DADAF4", Offset = "0x2DA9AF4", VA = "0x2DADAF4")]
	public ActivationMixerPlayable()
	{
	}
}
[Token(Token = "0x2000005")]
internal class ActivationPlayableAsset : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x17000002")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2DADAFC", Offset = "0x2DA9AFC", VA = "0x2DADAFC", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2DADB04", Offset = "0x2DA9B04", VA = "0x2DADB04", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2DADB70", Offset = "0x2DA9B70", VA = "0x2DADB70")]
	public ActivationPlayableAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
[TrackClipType(typeof(ActivationPlayableAsset))]
[TrackBindingType(typeof(GameObject))]
[ExcludeFromPreset]
public class ActivationTrack : TrackAsset
{
	[Token(Token = "0x2000007")]
	public enum PostPlaybackState
	{
		[Token(Token = "0x400000C")]
		Active,
		[Token(Token = "0x400000D")]
		Inactive,
		[Token(Token = "0x400000E")]
		Revert,
		[Token(Token = "0x400000F")]
		LeaveAsIs
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private PostPlaybackState m_PostPlaybackState;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private ActivationMixerPlayable m_ActivationMixer;

	[Token(Token = "0x17000003")]
	public PostPlaybackState postPlaybackState
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2DADC84", Offset = "0x2DA9C84", VA = "0x2DADC84")]
		get
		{
			return default(PostPlaybackState);
		}
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2DADC8C", Offset = "0x2DA9C8C", VA = "0x2DADC8C")]
		set
		{
		}
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2DADB78", Offset = "0x2DA9B78", VA = "0x2DADB78", Slot = "33")]
	internal override bool CanCompileClips()
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2DADCB4", Offset = "0x2DA9CB4", VA = "0x2DADCB4", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2DADCA0", Offset = "0x2DA9CA0", VA = "0x2DADCA0")]
	internal void UpdateTrackMode()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2DADD90", Offset = "0x2DA9D90", VA = "0x2DADD90", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2DAE034", Offset = "0x2DAA034", VA = "0x2DAE034", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2DAE088", Offset = "0x2DAA088", VA = "0x2DAE088")]
	public ActivationTrack()
	{
	}
}
[Token(Token = "0x2000008")]
internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback
{
	[Token(Token = "0x2000009")]
	private struct WeightInfo
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Playable mixer;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Playable parentMixer;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int port;
	}

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AnimationPlayableOutput m_Output;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_MotionXPlayable;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly List<WeightInfo> m_Mixers;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2DAE1B0", Offset = "0x2DAA1B0", VA = "0x2DAE1B0")]
	public AnimationOutputWeightProcessor(AnimationPlayableOutput output)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2DAE270", Offset = "0x2DAA270", VA = "0x2DAE270")]
	private void FindMixers()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2DAE358", Offset = "0x2DAA358", VA = "0x2DAE358")]
	private void FindMixers(Playable parent, int port, Playable node)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2DAE640", Offset = "0x2DAA640", VA = "0x2DAE640", Slot = "4")]
	public void Evaluate()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
[NotKeyable]
public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
{
	[Token(Token = "0x200000B")]
	public enum LoopMode
	{
		[Token(Token = "0x4000023")]
		[Tooltip("Use the loop time setting from the source AnimationClip.")]
		UseSourceAsset,
		[Token(Token = "0x4000024")]
		[Tooltip("The source AnimationClip loops during playback.")]
		On,
		[Token(Token = "0x4000025")]
		[Tooltip("The source AnimationClip does not loop during playback.")]
		Off
	}

	[Token(Token = "0x200000C")]
	private enum Versions
	{
		[Token(Token = "0x4000027")]
		Initial,
		[Token(Token = "0x4000028")]
		RotationAsEuler
	}

	[Token(Token = "0x200000D")]
	private static class AnimationPlayableAssetUpgrade
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2DAF42C", Offset = "0x2DAB42C", VA = "0x2DAF42C")]
		public static void ConvertRotationToEuler(AnimationPlayableAsset asset)
		{
		}
	}

	[Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class <get_outputs>d__45 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableBinding <>2__current;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>l__initialThreadId;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationPlayableAsset <>4__this;

		[Token(Token = "0x17000012")]
		private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2DAF64C", Offset = "0x2DAB64C", VA = "0x2DAF64C", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PlayableBinding);
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2DAF694", Offset = "0x2DAB694", VA = "0x2DAF694", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2DAEBCC", Offset = "0x2DAABCC", VA = "0x2DAEBCC")]
		[DebuggerHidden]
		public <get_outputs>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2DAF5C4", Offset = "0x2DAB5C4", VA = "0x2DAF5C4", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2DAF5C8", Offset = "0x2DAB5C8", VA = "0x2DAF5C8", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2DAF65C", Offset = "0x2DAB65C", VA = "0x2DAF65C", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2DAF6F4", Offset = "0x2DAB6F4", VA = "0x2DAF6F4", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2DAF790", Offset = "0x2DAB790", VA = "0x2DAF790", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AnimationClip m_Clip;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 m_Position;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 m_EulerAngles;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_UseTrackMatchFields;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private MatchTargetFields m_MatchTargetFields;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool m_RemoveStartOffset;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool m_ApplyFootIK;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private LoopMode m_Loop;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int k_LatestVersion;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[HideInInspector]
	private int m_Version;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Obsolete("Use m_RotationEuler Instead", false)]
	[HideInInspector]
	private Quaternion m_Rotation;

	[Token(Token = "0x17000004")]
	public Vector3 position
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2DAE7A0", Offset = "0x2DAA7A0", VA = "0x2DAE7A0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2DAE7AC", Offset = "0x2DAA7AC", VA = "0x2DAE7AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public Quaternion rotation
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2DAE7B8", Offset = "0x2DAA7B8", VA = "0x2DAE7B8")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2DAE7E8", Offset = "0x2DAA7E8", VA = "0x2DAE7E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public Vector3 eulerAngles
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2DAE824", Offset = "0x2DAA824", VA = "0x2DAE824")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2DAE830", Offset = "0x2DAA830", VA = "0x2DAE830")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public bool useTrackMatchFields
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2DAE83C", Offset = "0x2DAA83C", VA = "0x2DAE83C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2DAE844", Offset = "0x2DAA844", VA = "0x2DAE844")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public MatchTargetFields matchTargetFields
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2DAE84C", Offset = "0x2DAA84C", VA = "0x2DAE84C")]
		get
		{
			return default(MatchTargetFields);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2DAE854", Offset = "0x2DAA854", VA = "0x2DAE854")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public bool removeStartOffset
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2DAE85C", Offset = "0x2DAA85C", VA = "0x2DAE85C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2DAE864", Offset = "0x2DAA864", VA = "0x2DAE864")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public bool applyFootIK
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2DAE86C", Offset = "0x2DAA86C", VA = "0x2DAE86C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2DAE874", Offset = "0x2DAA874", VA = "0x2DAE874")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public LoopMode loop
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2DAE87C", Offset = "0x2DAA87C", VA = "0x2DAE87C")]
		get
		{
			return default(LoopMode);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2DAE884", Offset = "0x2DAA884", VA = "0x2DAE884")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	internal bool hasRootTransforms
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2DAE88C", Offset = "0x2DAA88C", VA = "0x2DAE88C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000D")]
	internal AppliedOffsetMode appliedOffsetMode
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2DAE9FC", Offset = "0x2DAA9FC", VA = "0x2DAE9FC")]
		[CompilerGenerated]
		get
		{
			return default(AppliedOffsetMode);
		}
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2DAEA04", Offset = "0x2DAAA04", VA = "0x2DAEA04")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public AnimationClip clip
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2DAEA0C", Offset = "0x2DAAA0C", VA = "0x2DAEA0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2DAEA14", Offset = "0x2DAAA14", VA = "0x2DAEA14")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public override double duration
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2DAEAD4", Offset = "0x2DAAAD4", VA = "0x2DAEAD4", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000010")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2DAEB58", Offset = "0x2DAAB58", VA = "0x2DAEB58", Slot = "8")]
		[IteratorStateMachine(typeof(<get_outputs>d__45))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000011")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2DAF140", Offset = "0x2DAB140", VA = "0x2DAF140", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2DAEC00", Offset = "0x2DAAC00", VA = "0x2DAEC00", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2DAECD0", Offset = "0x2DAACD0", VA = "0x2DAECD0")]
	internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2DAF0CC", Offset = "0x2DAB0CC", VA = "0x2DAF0CC")]
	private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip)
	{
		return default(bool);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2DAF0B4", Offset = "0x2DAB0B4", VA = "0x2DAF0B4")]
	private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2DAF224", Offset = "0x2DAB224", VA = "0x2DAF224")]
	public void ResetOffsets()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2DAF28C", Offset = "0x2DAB28C", VA = "0x2DAF28C", Slot = "10")]
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2DAE930", Offset = "0x2DAA930", VA = "0x2DAE930")]
	internal static bool HasRootTransforms(AnimationClip clip)
	{
		return default(bool);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2DAF338", Offset = "0x2DAB338", VA = "0x2DAF338", Slot = "11")]
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2DAF398", Offset = "0x2DAB398", VA = "0x2DAF398", Slot = "12")]
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2DAF41C", Offset = "0x2DAB41C", VA = "0x2DAF41C")]
	private void OnUpgradeFromVersion(int oldVersion)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2DAF478", Offset = "0x2DAB478", VA = "0x2DAF478")]
	public AnimationPlayableAsset()
	{
	}
}
[Token(Token = "0x200000F")]
internal class AnimationPreviewUpdateCallback : ITimelineEvaluateCallback
{
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AnimationPlayableOutput m_Output;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PlayableGraph m_Graph;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<IAnimationWindowPreview> m_PreviewComponents;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2DAF794", Offset = "0x2DAB794", VA = "0x2DAF794")]
	public AnimationPreviewUpdateCallback(AnimationPlayableOutput output)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2DAF85C", Offset = "0x2DAB85C", VA = "0x2DAF85C", Slot = "4")]
	public void Evaluate()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2DAFA2C", Offset = "0x2DABA2C", VA = "0x2DAFA2C")]
	private void FetchPreviewComponents()
	{
	}
}
[Token(Token = "0x2000010")]
[Flags]
public enum MatchTargetFields
{
	[Token(Token = "0x4000031")]
	PositionX = 1,
	[Token(Token = "0x4000032")]
	PositionY = 2,
	[Token(Token = "0x4000033")]
	PositionZ = 4,
	[Token(Token = "0x4000034")]
	RotationX = 8,
	[Token(Token = "0x4000035")]
	RotationY = 0x10,
	[Token(Token = "0x4000036")]
	RotationZ = 0x20
}
[Token(Token = "0x2000011")]
public enum TrackOffset
{
	[Token(Token = "0x4000038")]
	ApplyTransformOffsets,
	[Token(Token = "0x4000039")]
	ApplySceneOffsets,
	[Token(Token = "0x400003A")]
	Auto
}
[Token(Token = "0x2000012")]
internal enum AppliedOffsetMode
{
	[Token(Token = "0x400003C")]
	NoRootTransform,
	[Token(Token = "0x400003D")]
	TransformOffset,
	[Token(Token = "0x400003E")]
	SceneOffset,
	[Token(Token = "0x400003F")]
	TransformOffsetLegacy,
	[Token(Token = "0x4000040")]
	SceneOffsetLegacy,
	[Token(Token = "0x4000041")]
	SceneOffsetEditor,
	[Token(Token = "0x4000042")]
	SceneOffsetLegacyEditor
}
[Token(Token = "0x2000013")]
internal static class MatchTargetFieldConstants
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static MatchTargetFields All;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static MatchTargetFields None;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static MatchTargetFields Position;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static MatchTargetFields Rotation;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2DAFB58", Offset = "0x2DABB58", VA = "0x2DAFB58")]
	public static bool HasAny(this MatchTargetFields me, MatchTargetFields fields)
	{
		return default(bool);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2DAFBCC", Offset = "0x2DABBCC", VA = "0x2DAFBCC")]
	public static MatchTargetFields Toggle(this MatchTargetFields me, MatchTargetFields flag)
	{
		return default(MatchTargetFields);
	}
}
[Serializable]
[Token(Token = "0x2000014")]
[TrackClipType(typeof(AnimationPlayableAsset), false)]
[TrackBindingType(typeof(Animator))]
[ExcludeFromPreset]
public class AnimationTrack : TrackAsset, ILayerable
{
	[Token(Token = "0x2000015")]
	private static class AnimationTrackUpgrade
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2DB3AD0", Offset = "0x2DAFAD0", VA = "0x2DB3AD0")]
		public static void ConvertRotationsToEuler(AnimationTrack track)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2DB3B64", Offset = "0x2DAFB64", VA = "0x2DB3B64")]
		public static void ConvertRootMotion(AnimationTrack track)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2DB3BE4", Offset = "0x2DAFBE4", VA = "0x2DB3BE4")]
		public static void ConvertInfiniteTrack(AnimationTrack track)
		{
		}
	}

	[Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class <get_outputs>d__49 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableBinding <>2__current;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>l__initialThreadId;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationTrack <>4__this;

		[Token(Token = "0x1700002D")]
		private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x2DB3E9C", Offset = "0x2DAFE9C", VA = "0x2DB3E9C", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PlayableBinding);
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2DB3EE4", Offset = "0x2DAFEE4", VA = "0x2DB3EE4", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2DAFEC4", Offset = "0x2DABEC4", VA = "0x2DAFEC4")]
		[DebuggerHidden]
		public <get_outputs>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2DB3E14", Offset = "0x2DAFE14", VA = "0x2DB3E14", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2DB3E18", Offset = "0x2DAFE18", VA = "0x2DB3E18", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2DB3EAC", Offset = "0x2DAFEAC", VA = "0x2DB3EAC", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2DB3F44", Offset = "0x2DAFF44", VA = "0x2DB3F44", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2DB3FE0", Offset = "0x2DAFFE0", VA = "0x2DB3FE0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000047")]
	private const string k_DefaultInfiniteClipName = "Recorded";

	[Token(Token = "0x4000048")]
	private const string k_DefaultRecordableClipName = "Recorded";

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[FormerlySerializedAs("m_OpenClipPreExtrapolation")]
	[SerializeField]
	private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipPostExtrapolation")]
	private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipOffsetPosition")]
	private Vector3 m_InfiniteClipOffsetPosition;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipOffsetEulerAngles")]
	private Vector3 m_InfiniteClipOffsetEulerAngles;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipTimeOffset")]
	private double m_InfiniteClipTimeOffset;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipRemoveOffset")]
	private bool m_InfiniteClipRemoveOffset;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[SerializeField]
	private bool m_InfiniteClipApplyFootIK;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[SerializeField]
	[HideInInspector]
	private AnimationPlayableAsset.LoopMode mInfiniteClipLoop;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private MatchTargetFields m_MatchTargetFields;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private Vector3 m_Position;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Vector3 m_EulerAngles;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private AvatarMask m_AvatarMask;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private bool m_ApplyAvatarMask;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	[SerializeField]
	private TrackOffset m_TrackOffset;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[SerializeField]
	[HideInInspector]
	private AnimationClip m_InfiniteClip;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Queue<Transform> s_CachedQueue;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[Obsolete("Use m_InfiniteClipOffsetEulerAngles Instead", false)]
	[SerializeField]
	[HideInInspector]
	private Quaternion m_OpenClipOffsetRotation;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Obsolete("Use m_RotationEuler Instead", false)]
	[HideInInspector]
	private Quaternion m_Rotation;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[SerializeField]
	[HideInInspector]
	[Obsolete("Use m_RootTransformOffsetMode", false)]
	private bool m_ApplyOffsets;

	[Token(Token = "0x17000014")]
	public Vector3 position
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2DAFC24", Offset = "0x2DABC24", VA = "0x2DAFC24")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2DAFC30", Offset = "0x2DABC30", VA = "0x2DAFC30")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public Quaternion rotation
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2DAFC3C", Offset = "0x2DABC3C", VA = "0x2DAFC3C")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2DAFC6C", Offset = "0x2DABC6C", VA = "0x2DAFC6C")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public Vector3 eulerAngles
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2DAFCA8", Offset = "0x2DABCA8", VA = "0x2DAFCA8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2DAFCB4", Offset = "0x2DABCB4", VA = "0x2DAFCB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	[Obsolete("applyOffset is deprecated. Use trackOffset instead", true)]
	public bool applyOffsets
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2DAFCC0", Offset = "0x2DABCC0", VA = "0x2DAFCC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2DAFCC8", Offset = "0x2DABCC8", VA = "0x2DAFCC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public TrackOffset trackOffset
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2DAFCCC", Offset = "0x2DABCCC", VA = "0x2DAFCCC")]
		get
		{
			return default(TrackOffset);
		}
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2DAFCD4", Offset = "0x2DABCD4", VA = "0x2DAFCD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public MatchTargetFields matchTargetFields
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2DAFCDC", Offset = "0x2DABCDC", VA = "0x2DAFCDC")]
		get
		{
			return default(MatchTargetFields);
		}
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2DAFCE4", Offset = "0x2DABCE4", VA = "0x2DAFCE4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public AnimationClip infiniteClip
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2DAFD54", Offset = "0x2DABD54", VA = "0x2DAFD54")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2DAFD5C", Offset = "0x2DABD5C", VA = "0x2DAFD5C")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	internal bool infiniteClipRemoveOffset
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2DAFD64", Offset = "0x2DABD64", VA = "0x2DAFD64")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2DAFD6C", Offset = "0x2DABD6C", VA = "0x2DAFD6C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public AvatarMask avatarMask
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2DAFD74", Offset = "0x2DABD74", VA = "0x2DAFD74")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2DAFD7C", Offset = "0x2DABD7C", VA = "0x2DAFD7C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public bool applyAvatarMask
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2DAFD84", Offset = "0x2DABD84", VA = "0x2DAFD84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2DAFD8C", Offset = "0x2DABD8C", VA = "0x2DAFD8C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2DAFE50", Offset = "0x2DABE50", VA = "0x2DAFE50", Slot = "8")]
		[IteratorStateMachine(typeof(<get_outputs>d__49))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001F")]
	public bool inClipMode
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2DAFEF8", Offset = "0x2DABEF8", VA = "0x2DAFEF8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public Vector3 infiniteClipOffsetPosition
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2DAFFD8", Offset = "0x2DABFD8", VA = "0x2DAFFD8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2DAFFE4", Offset = "0x2DABFE4", VA = "0x2DAFFE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public Quaternion infiniteClipOffsetRotation
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2DAFFF0", Offset = "0x2DABFF0", VA = "0x2DAFFF0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2DB0020", Offset = "0x2DAC020", VA = "0x2DB0020")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Vector3 infiniteClipOffsetEulerAngles
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2DB005C", Offset = "0x2DAC05C", VA = "0x2DB005C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2DB0068", Offset = "0x2DAC068", VA = "0x2DB0068")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	internal bool infiniteClipApplyFootIK
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2DB0074", Offset = "0x2DAC074", VA = "0x2DB0074")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2DB007C", Offset = "0x2DAC07C", VA = "0x2DB007C")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	internal double infiniteClipTimeOffset
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2DB0084", Offset = "0x2DAC084", VA = "0x2DB0084")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2DB008C", Offset = "0x2DAC08C", VA = "0x2DB008C")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2DB0094", Offset = "0x2DAC094", VA = "0x2DB0094")]
		get
		{
			return default(TimelineClip.ClipExtrapolation);
		}
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2DB009C", Offset = "0x2DAC09C", VA = "0x2DB009C")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2DB00A4", Offset = "0x2DAC0A4", VA = "0x2DB00A4")]
		get
		{
			return default(TimelineClip.ClipExtrapolation);
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2DB00AC", Offset = "0x2DAC0AC", VA = "0x2DB00AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	internal AnimationPlayableAsset.LoopMode infiniteClipLoop
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2DB00B4", Offset = "0x2DAC0B4", VA = "0x2DB00B4")]
		get
		{
			return default(AnimationPlayableAsset.LoopMode);
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2DB00BC", Offset = "0x2DAC0BC", VA = "0x2DB00BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Vector3 openClipOffsetPosition
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2DB39FC", Offset = "0x2DAF9FC", VA = "0x2DB39FC")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2DB3A08", Offset = "0x2DAFA08", VA = "0x2DB3A08")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", true)]
	public Quaternion openClipOffsetRotation
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2DB3A14", Offset = "0x2DAFA14", VA = "0x2DB3A14")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2DB3A44", Offset = "0x2DAFA44", VA = "0x2DB3A44")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Vector3 openClipOffsetEulerAngles
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2DB3A48", Offset = "0x2DAFA48", VA = "0x2DB3A48")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2DB3A54", Offset = "0x2DAFA54", VA = "0x2DB3A54")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public TimelineClip.ClipExtrapolation openClipPreExtrapolation
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2DB3A60", Offset = "0x2DAFA60", VA = "0x2DB3A60")]
		get
		{
			return default(TimelineClip.ClipExtrapolation);
		}
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2DB3A68", Offset = "0x2DAFA68", VA = "0x2DB3A68")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", true)]
	public TimelineClip.ClipExtrapolation openClipPostExtrapolation
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2DB3A70", Offset = "0x2DAFA70", VA = "0x2DB3A70")]
		get
		{
			return default(TimelineClip.ClipExtrapolation);
		}
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2DB3A78", Offset = "0x2DAFA78", VA = "0x2DB3A78")]
		set
		{
		}
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2DAFD94", Offset = "0x2DABD94", VA = "0x2DAFD94", Slot = "33")]
	internal override bool CanCompileClips()
	{
		return default(bool);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2DB00C4", Offset = "0x2DAC0C4", VA = "0x2DB00C4")]
	[ContextMenu("Reset Offsets")]
	private void ResetOffsets()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2DB0130", Offset = "0x2DAC130", VA = "0x2DB0130")]
	public TimelineClip CreateClip(AnimationClip clip)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2DB03F0", Offset = "0x2DAC3F0", VA = "0x2DB03F0")]
	public void CreateInfiniteClip(string infiniteClipName)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2DB04F4", Offset = "0x2DAC4F4", VA = "0x2DB04F4")]
	public TimelineClip CreateRecordableClip(string animClipName)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2DB07E4", Offset = "0x2DAC7E4", VA = "0x2DB07E4", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2DB09AC", Offset = "0x2DAC9AC", VA = "0x2DB09AC", Slot = "31")]
	protected internal override int CalculateItemsHash()
	{
		return default(int);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2DB012C", Offset = "0x2DAC12C", VA = "0x2DB012C")]
	internal void UpdateClipOffsets()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2DB0B90", Offset = "0x2DACB90", VA = "0x2DB0B90")]
	private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
	{
		return default(Playable);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2DB154C", Offset = "0x2DAD54C", VA = "0x2DB154C", Slot = "36")]
	private Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2DB159C", Offset = "0x2DAD59C", VA = "0x2DB159C", Slot = "26")]
	internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
	{
		return default(Playable);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2DB244C", Offset = "0x2DAE44C", VA = "0x2DB244C")]
	private int GetDefaultBlendCount()
	{
		return default(int);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2DB294C", Offset = "0x2DAE94C", VA = "0x2DB294C")]
	private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2DB2960", Offset = "0x2DAE960", VA = "0x2DB2960")]
	private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot)
	{
		return default(Playable);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x2DB283C", Offset = "0x2DAE83C", VA = "0x2DB283C")]
	private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2DB2950", Offset = "0x2DAE950", VA = "0x2DB2950")]
	private static bool UsesAbsoluteMotion(AppliedOffsetMode mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2DB2C9C", Offset = "0x2DAEC9C", VA = "0x2DB2C9C")]
	private bool HasController(GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2DB2AB8", Offset = "0x2DAEAB8", VA = "0x2DB2AB8")]
	internal Animator GetBinding(PlayableDirector director)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2DB2454", Offset = "0x2DAE454", VA = "0x2DB2454")]
	private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(AnimationLayerMixerPlayable);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2DB24C8", Offset = "0x2DAE4C8", VA = "0x2DB24C8")]
	private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2DB138C", Offset = "0x2DAD38C", VA = "0x2DB138C")]
	private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2DB2DE8", Offset = "0x2DAEDE8", VA = "0x2DB2DE8", Slot = "27")]
	internal override void GetEvaluationTime(out double outStart, out double outDuration)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2DB3080", Offset = "0x2DAF080", VA = "0x2DB3080", Slot = "28")]
	internal override void GetSequenceTime(out double outStart, out double outDuration)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2DB01D8", Offset = "0x2DAC1D8", VA = "0x2DB01D8")]
	private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2DB32EC", Offset = "0x2DAF2EC", VA = "0x2DB32EC", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2DB32F0", Offset = "0x2DAF2F0", VA = "0x2DB32F0")]
	private void GetAnimationClips(List<AnimationClip> animClips)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2DB2368", Offset = "0x2DAE368", VA = "0x2DB2368")]
	private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform)
	{
		return default(AppliedOffsetMode);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2DB20F4", Offset = "0x2DAE0F4", VA = "0x2DB20F4")]
	private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode)
	{
		return default(bool);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2DB1F0C", Offset = "0x2DADF0C", VA = "0x2DB1F0C")]
	private Transform GetGenericRootNode(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2DB0FF0", Offset = "0x2DACFF0", VA = "0x2DB0FF0")]
	internal bool AnimatesRootTransform()
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2DB3824", Offset = "0x2DAF824", VA = "0x2DB3824")]
	private static Transform FindInHierarchyBreadthFirst(Transform t, string name)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2DB3A80", Offset = "0x2DAFA80", VA = "0x2DB3A80", Slot = "22")]
	internal override void OnUpgradeFromVersion(int oldVersion)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2DB3C00", Offset = "0x2DAFC00", VA = "0x2DB3C00")]
	public AnimationTrack()
	{
	}
}
[Token(Token = "0x2000017")]
internal interface ICurvesOwner
{
	[Token(Token = "0x1700002F")]
	AnimationClip curves
	{
		[Token(Token = "0x60000A8")]
		get;
	}

	[Token(Token = "0x17000030")]
	bool hasCurves
	{
		[Token(Token = "0x60000A9")]
		get;
	}

	[Token(Token = "0x17000031")]
	double duration
	{
		[Token(Token = "0x60000AA")]
		get;
	}

	[Token(Token = "0x17000032")]
	string defaultCurvesName
	{
		[Token(Token = "0x60000AC")]
		get;
	}

	[Token(Token = "0x17000033")]
	Object asset
	{
		[Token(Token = "0x60000AD")]
		get;
	}

	[Token(Token = "0x17000034")]
	Object assetOwner
	{
		[Token(Token = "0x60000AE")]
		get;
	}

	[Token(Token = "0x17000035")]
	TrackAsset targetTrack
	{
		[Token(Token = "0x60000AF")]
		get;
	}

	[Token(Token = "0x60000AB")]
	void CreateCurves(string curvesClipName);
}
[Serializable]
[Token(Token = "0x2000018")]
public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver
{
	[Token(Token = "0x2000019")]
	private enum Versions
	{
		[Token(Token = "0x4000080")]
		Initial,
		[Token(Token = "0x4000081")]
		ClipInFromGlobalToLocal
	}

	[Token(Token = "0x200001A")]
	private static class TimelineClipUpgrade
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2DB4020", Offset = "0x2DB0020", VA = "0x2DB4020")]
		public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip)
		{
		}
	}

	[Token(Token = "0x200001B")]
	public enum ClipExtrapolation
	{
		[Token(Token = "0x4000083")]
		None,
		[Token(Token = "0x4000084")]
		Hold,
		[Token(Token = "0x4000085")]
		Loop,
		[Token(Token = "0x4000086")]
		PingPong,
		[Token(Token = "0x4000087")]
		Continue
	}

	[Token(Token = "0x200001C")]
	public enum BlendCurveMode
	{
		[Token(Token = "0x4000089")]
		Auto,
		[Token(Token = "0x400008A")]
		Manual
	}

	[Token(Token = "0x4000060")]
	private const int k_LatestVersion = 1;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	private int m_Version;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly ClipCaps kDefaultClipCaps;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static readonly float kDefaultClipDurationInSeconds;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly double kTimeScaleMin;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly double kTimeScaleMax;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal static readonly string kDefaultCurvesName;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal static readonly double kMinDuration;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal static readonly double kMaxTimeValue;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private double m_Start;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private double m_ClipIn;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Object m_Asset;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_HackDuration")]
	[SerializeField]
	private double m_Duration;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private double m_TimeScale;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TrackAsset m_ParentTrack;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private double m_EaseInDuration;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private double m_EaseOutDuration;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private double m_BlendInDuration;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private double m_BlendOutDuration;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AnimationCurve m_MixInCurve;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AnimationCurve m_MixOutCurve;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private BlendCurveMode m_BlendInCurveMode;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private BlendCurveMode m_BlendOutCurveMode;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private List<string> m_ExposedParameterNames;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private AnimationClip m_AnimationCurves;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private bool m_Recordable;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[SerializeField]
	private ClipExtrapolation m_PostExtrapolationMode;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private ClipExtrapolation m_PreExtrapolationMode;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private double m_PostExtrapolationTime;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private double m_PreExtrapolationTime;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private string m_DisplayName;

	[Token(Token = "0x17000036")]
	public bool hasPreExtrapolation
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2DB4188", Offset = "0x2DB0188", VA = "0x2DB4188")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000037")]
	public bool hasPostExtrapolation
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2DB41A8", Offset = "0x2DB01A8", VA = "0x2DB41A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000038")]
	public double timeScale
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2DB41C8", Offset = "0x2DB01C8", VA = "0x2DB41C8")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2DB4390", Offset = "0x2DB0390", VA = "0x2DB4390")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public double start
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2DB4468", Offset = "0x2DB0468", VA = "0x2DB4468")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2DB0634", Offset = "0x2DAC634", VA = "0x2DB0634")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public double duration
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2DB45A8", Offset = "0x2DB05A8", VA = "0x2DB45A8", Slot = "6")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2DB0738", Offset = "0x2DAC738", VA = "0x2DB0738")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public double end
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2DB45B0", Offset = "0x2DB05B0", VA = "0x2DB45B0")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700003C")]
	public double clipIn
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2DB45C0", Offset = "0x2DB05C0", VA = "0x2DB45C0")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2DB45E0", Offset = "0x2DB05E0", VA = "0x2DB45E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public string displayName
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2DB46B8", Offset = "0x2DB06B8", VA = "0x2DB46B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2DB46C0", Offset = "0x2DB06C0", VA = "0x2DB46C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public double clipAssetDuration
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2DB46C8", Offset = "0x2DB06C8", VA = "0x2DB46C8")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700003F")]
	public AnimationClip curves
	{
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2DB4788", Offset = "0x2DB0788", VA = "0x2DB4788", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2DB4790", Offset = "0x2DB0790", VA = "0x2DB4790")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000040")]
	private string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2DB4798", Offset = "0x2DB0798", VA = "0x2DB4798", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public bool hasCurves
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2DB47F0", Offset = "0x2DB07F0", VA = "0x2DB47F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000042")]
	public Object asset
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2DB487C", Offset = "0x2DB087C", VA = "0x2DB487C", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2DB4884", Offset = "0x2DB0884", VA = "0x2DB4884")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2DB488C", Offset = "0x2DB088C", VA = "0x2DB488C", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000044")]
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2DB4894", Offset = "0x2DB0894", VA = "0x2DB4894", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000045")]
	[Obsolete("underlyingAsset property is obsolete. Use asset property instead", true)]
	public Object underlyingAsset
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2DB489C", Offset = "0x2DB089C", VA = "0x2DB489C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2DB48A4", Offset = "0x2DB08A4", VA = "0x2DB48A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	[Obsolete("parentTrack is deprecated and will be removed in a future release. Use GetParentTrack() and TimelineClipExtensions::MoveToTrack() or TimelineClipExtensions::TryMoveToTrack() instead.", false)]
	public TrackAsset parentTrack
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2DB48A8", Offset = "0x2DB08A8", VA = "0x2DB48A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2DB48B0", Offset = "0x2DB08B0", VA = "0x2DB48B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public double easeInDuration
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2DB49EC", Offset = "0x2DB09EC", VA = "0x2DB49EC")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2DB4AD4", Offset = "0x2DB0AD4", VA = "0x2DB4AD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public double easeOutDuration
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2DB4BCC", Offset = "0x2DB0BCC", VA = "0x2DB4BCC")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2DB4CB4", Offset = "0x2DB0CB4", VA = "0x2DB4CB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	[Obsolete("Use easeOutTime instead (UnityUpgradable) -> easeOutTime", true)]
	public double eastOutTime
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2DB4DAC", Offset = "0x2DB0DAC", VA = "0x2DB4DAC")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700004A")]
	public double easeOutTime
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2DB4DD8", Offset = "0x2DB0DD8", VA = "0x2DB4DD8")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700004B")]
	public double blendInDuration
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2DB4E04", Offset = "0x2DB0E04", VA = "0x2DB4E04")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2DB4E24", Offset = "0x2DB0E24", VA = "0x2DB4E24")]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public double blendOutDuration
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2DB4EAC", Offset = "0x2DB0EAC", VA = "0x2DB4EAC")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2DB4ECC", Offset = "0x2DB0ECC", VA = "0x2DB4ECC")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public BlendCurveMode blendInCurveMode
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2DB4F54", Offset = "0x2DB0F54", VA = "0x2DB4F54")]
		get
		{
			return default(BlendCurveMode);
		}
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2DB4F5C", Offset = "0x2DB0F5C", VA = "0x2DB4F5C")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public BlendCurveMode blendOutCurveMode
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2DB4F64", Offset = "0x2DB0F64", VA = "0x2DB4F64")]
		get
		{
			return default(BlendCurveMode);
		}
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2DB4F6C", Offset = "0x2DB0F6C", VA = "0x2DB4F6C")]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public bool hasBlendIn
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2DB4C88", Offset = "0x2DB0C88", VA = "0x2DB4C88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000050")]
	public bool hasBlendOut
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2DB4AA8", Offset = "0x2DB0AA8", VA = "0x2DB4AA8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000051")]
	public AnimationCurve mixInCurve
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2DB4F74", Offset = "0x2DB0F74", VA = "0x2DB4F74")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2DB5018", Offset = "0x2DB1018", VA = "0x2DB5018")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public float mixInPercentage
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2DB5020", Offset = "0x2DB1020", VA = "0x2DB5020")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000053")]
	public double mixInDuration
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2DB5040", Offset = "0x2DB1040", VA = "0x2DB5040")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000054")]
	public AnimationCurve mixOutCurve
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2DB5084", Offset = "0x2DB1084", VA = "0x2DB5084")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2DB5128", Offset = "0x2DB1128", VA = "0x2DB5128")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public double mixOutTime
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2DB5130", Offset = "0x2DB1130", VA = "0x2DB5130")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000056")]
	public double mixOutDuration
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2DB515C", Offset = "0x2DB115C", VA = "0x2DB515C")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000057")]
	public float mixOutPercentage
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2DB51A0", Offset = "0x2DB11A0", VA = "0x2DB51A0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000058")]
	public bool recordable
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2DB51C0", Offset = "0x2DB11C0", VA = "0x2DB51C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2DB51C8", Offset = "0x2DB11C8", VA = "0x2DB51C8")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000059")]
	[Obsolete("exposedParameter is deprecated and will be removed in a future release", true)]
	public List<string> exposedParameters
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2DB51D0", Offset = "0x2DB11D0", VA = "0x2DB51D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005A")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2DB42A0", Offset = "0x2DB02A0", VA = "0x2DB42A0")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x1700005B")]
	public AnimationClip animationClip
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2DB583C", Offset = "0x2DB183C", VA = "0x2DB583C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005C")]
	public ClipExtrapolation postExtrapolationMode
	{
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2DB5934", Offset = "0x2DB1934", VA = "0x2DB5934")]
		get
		{
			return default(ClipExtrapolation);
		}
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2DB0978", Offset = "0x2DAC978", VA = "0x2DB0978")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public ClipExtrapolation preExtrapolationMode
	{
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2DB5958", Offset = "0x2DB1958", VA = "0x2DB5958")]
		get
		{
			return default(ClipExtrapolation);
		}
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2DB0944", Offset = "0x2DAC944", VA = "0x2DB0944")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700005E")]
	public double extrapolatedStart
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2DB59C8", Offset = "0x2DB19C8", VA = "0x2DB59C8")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700005F")]
	public double extrapolatedDuration
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2DB59E0", Offset = "0x2DB19E0", VA = "0x2DB59E0")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2DB3FE4", Offset = "0x2DAFFE4", VA = "0x2DB3FE4")]
	private void UpgradeToLatestVersion()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2DB4058", Offset = "0x2DB0058", VA = "0x2DB4058")]
	internal TimelineClip(TrackAsset parent)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2DB48B4", Offset = "0x2DB08B4", VA = "0x2DB48B4")]
	public TrackAsset GetParentTrack()
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2DB4094", Offset = "0x2DB0094", VA = "0x2DB4094")]
	internal void SetParentTrack_Internal(TrackAsset newParentTrack)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x2DB5248", Offset = "0x2DB1248", VA = "0x2DB5248")]
	internal int Hash()
	{
		return default(int);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x2DB5324", Offset = "0x2DB1324", VA = "0x2DB5324")]
	public float EvaluateMixOut(double time)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x2DB541C", Offset = "0x2DB141C", VA = "0x2DB541C")]
	public float EvaluateMixIn(double time)
	{
		return default(float);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x2DB5000", Offset = "0x2DB1000", VA = "0x2DB5000")]
	private static AnimationCurve GetDefaultMixInCurve()
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x2DB5110", Offset = "0x2DB1110", VA = "0x2DB5110")]
	private static AnimationCurve GetDefaultMixOutCurve()
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x2DB54F4", Offset = "0x2DB14F4", VA = "0x2DB54F4")]
	public double ToLocalTime(double time)
	{
		return default(double);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2DB57A8", Offset = "0x2DB17A8", VA = "0x2DB57A8")]
	public double ToLocalTimeUnbound(double time)
	{
		return default(double);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x2DB57F8", Offset = "0x2DB17F8", VA = "0x2DB57F8")]
	internal double FromLocalTimeUnbound(double time)
	{
		return default(double);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x2DB4470", Offset = "0x2DB0470", VA = "0x2DB4470")]
	private static double SanitizeTimeValue(double value, double defaultValue)
	{
		return default(double);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x2DB597C", Offset = "0x2DB197C", VA = "0x2DB597C")]
	internal void SetPostExtrapolationTime(double time)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x2DB5984", Offset = "0x2DB1984", VA = "0x2DB5984")]
	internal void SetPreExtrapolationTime(double time)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x2DB598C", Offset = "0x2DB198C", VA = "0x2DB598C")]
	public bool IsExtrapolatedTime(double sequenceTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x2DB55E4", Offset = "0x2DB15E4", VA = "0x2DB55E4")]
	public bool IsPreExtrapolatedTime(double sequenceTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x2DB5750", Offset = "0x2DB1750", VA = "0x2DB5750")]
	public bool IsPostExtrapolatedTime(double sequenceTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2DB5634", Offset = "0x2DB1634", VA = "0x2DB5634")]
	private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration)
	{
		return default(double);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x2DB5AAC", Offset = "0x2DB1AAC", VA = "0x2DB5AAC", Slot = "7")]
	public void CreateCurves(string curvesClipName)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2DB5B78", Offset = "0x2DB1B78", VA = "0x2DB5B78", Slot = "12")]
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2DB5B84", Offset = "0x2DB1B84", VA = "0x2DB5B84", Slot = "13")]
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2DB5BC0", Offset = "0x2DB1BC0", VA = "0x2DB5BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2DB5D9C", Offset = "0x2DB1D9C", VA = "0x2DB5D9C")]
	public void ConformEaseValues()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x2DB5E2C", Offset = "0x2DB1E2C", VA = "0x2DB5E2C")]
	private static double CalculateEasingRatio(double easeIn, double easeOut)
	{
		return default(double);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2DB4464", Offset = "0x2DB0464", VA = "0x2DB4464")]
	private void UpdateDirty(double oldValue, double newValue)
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
[ExcludeFromPreset]
public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview
{
	[Token(Token = "0x200001E")]
	private enum Versions
	{
		[Token(Token = "0x4000096")]
		Initial
	}

	[Token(Token = "0x200001F")]
	private static class TimelineAssetUpgrade
	{
	}

	[Token(Token = "0x2000020")]
	[Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
	public enum MediaType
	{
		[Token(Token = "0x4000098")]
		Animation = 0,
		[Token(Token = "0x4000099")]
		Audio = 1,
		[Token(Token = "0x400009A")]
		Texture = 2,
		[Token(Token = "0x400009B")]
		[Obsolete("Use Texture MediaType instead. (UnityUpgradable) -> UnityEngine.Timeline.TimelineAsset/MediaType.Texture", false)]
		Video = 2,
		[Token(Token = "0x400009C")]
		Script = 3,
		[Token(Token = "0x400009D")]
		Hybrid = 4,
		[Token(Token = "0x400009E")]
		Group = 5
	}

	[Token(Token = "0x2000021")]
	public enum DurationMode
	{
		[Token(Token = "0x40000A0")]
		BasedOnClips,
		[Token(Token = "0x40000A1")]
		FixedLength
	}

	[Serializable]
	[Token(Token = "0x2000022")]
	public class EditorSettings
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly double kMinFrameRate;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly double kMaxFrameRate;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly double kDefaultFrameRate;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[FrameRateField]
		[SerializeField]
		[HideInInspector]
		private double m_Framerate;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private bool m_ScenePreview;

		[Token(Token = "0x1700006B")]
		[Obsolete("EditorSettings.fps has been deprecated. Use editorSettings.frameRate instead.", false)]
		public float fps
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2DB938C", Offset = "0x2DB538C", VA = "0x2DB938C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2DB9398", Offset = "0x2DB5398", VA = "0x2DB9398")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public double frameRate
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2DB9420", Offset = "0x2DB5420", VA = "0x2DB9420")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2DB6E14", Offset = "0x2DB2E14", VA = "0x2DB6E14")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public bool scenePreview
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2DB9570", Offset = "0x2DB5570", VA = "0x2DB9570")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2DB9578", Offset = "0x2DB5578", VA = "0x2DB9578")]
			set
			{
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2DB9428", Offset = "0x2DB5428", VA = "0x2DB9428")]
		public void SetStandardFrameRate(StandardFrameRates enumValue)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2DB931C", Offset = "0x2DB531C", VA = "0x2DB931C")]
		public EditorSettings()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class <get_outputs>d__27 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableBinding <>2__current;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>l__initialThreadId;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TimelineAsset <>4__this;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IEnumerator<TrackAsset> <>7__wrap1;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IEnumerator<PlayableBinding> <>7__wrap2;

		[Token(Token = "0x1700006E")]
		private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2DB9C7C", Offset = "0x2DB5C7C", VA = "0x2DB9C7C", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PlayableBinding);
			}
		}

		[Token(Token = "0x1700006F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2DB9CC4", Offset = "0x2DB5CC4", VA = "0x2DB9CC4", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2DB63D0", Offset = "0x2DB23D0", VA = "0x2DB63D0")]
		[DebuggerHidden]
		public <get_outputs>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2DB9604", Offset = "0x2DB5604", VA = "0x2DB9604", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2DB96B0", Offset = "0x2DB56B0", VA = "0x2DB96B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2DB9BCC", Offset = "0x2DB5BCC", VA = "0x2DB9BCC")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2DB9B1C", Offset = "0x2DB5B1C", VA = "0x2DB9B1C")]
		private void <>m__Finally2()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2DB9C8C", Offset = "0x2DB5C8C", VA = "0x2DB9C8C", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2DB9D24", Offset = "0x2DB5D24", VA = "0x2DB9D24", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2DB9DC0", Offset = "0x2DB5DC0", VA = "0x2DB9DC0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400008B")]
	private const int k_LatestVersion = 0;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private int m_Version;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private List<ScriptableObject> m_Tracks;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	private double m_FixedDuration;

	[NonSerialized]
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	private TrackAsset[] m_CacheOutputTracks;

	[NonSerialized]
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	private List<TrackAsset> m_CacheRootTracks;

	[NonSerialized]
	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	private TrackAsset[] m_CacheFlattenedTracks;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	private EditorSettings m_EditorSettings;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private DurationMode m_DurationMode;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	[SerializeField]
	private MarkerTrack m_MarkerTrack;

	[Token(Token = "0x17000060")]
	public EditorSettings editorSettings
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2DB5F78", Offset = "0x2DB1F78", VA = "0x2DB5F78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000061")]
	public override double duration
	{
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2DB5F80", Offset = "0x2DB1F80", VA = "0x2DB5F80", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000062")]
	public double fixedDuration
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2DB6210", Offset = "0x2DB2210", VA = "0x2DB6210")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2DB62DC", Offset = "0x2DB22DC", VA = "0x2DB62DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000063")]
	public DurationMode durationMode
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2DB634C", Offset = "0x2DB234C", VA = "0x2DB634C")]
		get
		{
			return default(DurationMode);
		}
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2DB6354", Offset = "0x2DB2354", VA = "0x2DB6354")]
		set
		{
		}
	}

	[Token(Token = "0x17000064")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2DB635C", Offset = "0x2DB235C", VA = "0x2DB635C", Slot = "8")]
		[IteratorStateMachine(typeof(<get_outputs>d__27))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000065")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2DB6404", Offset = "0x2DB2404", VA = "0x2DB6404", Slot = "11")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17000066")]
	public int outputTrackCount
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2DB6744", Offset = "0x2DB2744", VA = "0x2DB6744")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000067")]
	public int rootTrackCount
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2DB6990", Offset = "0x2DB2990", VA = "0x2DB6990")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000068")]
	internal TrackAsset[] flattenedTracks
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2DB6EE8", Offset = "0x2DB2EE8", VA = "0x2DB6EE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000069")]
	public MarkerTrack markerTrack
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2DB7344", Offset = "0x2DB3344", VA = "0x2DB7344")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006A")]
	internal List<ScriptableObject> trackObjects
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2DB734C", Offset = "0x2DB334C", VA = "0x2DB734C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x2DB5F74", Offset = "0x2DB1F74", VA = "0x2DB5F74")]
	private void UpgradeToLatestVersion()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x2DB6D40", Offset = "0x2DB2D40", VA = "0x2DB6D40")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x2DB6E2C", Offset = "0x2DB2E2C", VA = "0x2DB6E2C")]
	public TrackAsset GetRootTrack(int index)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x2DB672C", Offset = "0x2DB272C", VA = "0x2DB672C")]
	public IEnumerable<TrackAsset> GetRootTracks()
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x2DB6E8C", Offset = "0x2DB2E8C", VA = "0x2DB6E8C")]
	public TrackAsset GetOutputTrack(int index)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x2DB6ED0", Offset = "0x2DB2ED0", VA = "0x2DB6ED0")]
	public IEnumerable<TrackAsset> GetOutputTracks()
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x2DB6D68", Offset = "0x2DB2D68", VA = "0x2DB6D68")]
	private static double GetValidFrameRate(double frameRate)
	{
		return default(double);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x2DB69E0", Offset = "0x2DB29E0", VA = "0x2DB69E0")]
	private void UpdateRootTrackCache()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x2DB6768", Offset = "0x2DB2768", VA = "0x2DB6768")]
	private void UpdateOutputTrackCache()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x2DB7354", Offset = "0x2DB3354", VA = "0x2DB7354")]
	internal void AddTrackInternal(TrackAsset track)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x2DB7410", Offset = "0x2DB3410", VA = "0x2DB7410")]
	internal void RemoveTrack(TrackAsset track)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x2DB7590", Offset = "0x2DB3590", VA = "0x2DB7590", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x2DB7754", Offset = "0x2DB3754", VA = "0x2DB7754", Slot = "9")]
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x2DB775C", Offset = "0x2DB375C", VA = "0x2DB775C", Slot = "10")]
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x2DB7768", Offset = "0x2DB3768", VA = "0x2DB7768")]
	private void __internalAwake()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x2DB78CC", Offset = "0x2DB38CC", VA = "0x2DB78CC", Slot = "12")]
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x2DB7D40", Offset = "0x2DB3D40", VA = "0x2DB7D40")]
	public void CreateMarkerTrack()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x2DB7404", Offset = "0x2DB3404", VA = "0x2DB7404")]
	internal void Invalidate()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x2DB7E0C", Offset = "0x2DB3E0C", VA = "0x2DB7E0C")]
	internal void UpdateFixedDurationWithItemsDuration()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x2DB6030", Offset = "0x2DB2030", VA = "0x2DB6030")]
	private DiscreteTime CalculateItemsDuration()
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x2DB7030", Offset = "0x2DB3030", VA = "0x2DB7030")]
	private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x2DB7FA8", Offset = "0x2DB3FA8", VA = "0x2DB7FA8")]
	public TrackAsset CreateTrack(Type type, TrackAsset parent, string name)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	public T CreateTrack<T>(TrackAsset parent, string trackName) where T : TrackAsset, new()
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	public T CreateTrack<T>(string trackName) where T : TrackAsset, new()
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	public T CreateTrack<T>() where T : TrackAsset, new()
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x2DB867C", Offset = "0x2DB467C", VA = "0x2DB867C")]
	public bool DeleteClip(TimelineClip clip)
	{
		return default(bool);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x2DB89A0", Offset = "0x2DB49A0", VA = "0x2DB89A0")]
	public bool DeleteTrack(TrackAsset track)
	{
		return default(bool);
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x2DB8FD8", Offset = "0x2DB4FD8", VA = "0x2DB8FD8")]
	internal void MoveLastTrackBefore(TrackAsset asset)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x2DB840C", Offset = "0x2DB440C", VA = "0x2DB840C")]
	private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType)
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x2DB8E8C", Offset = "0x2DB4E8C", VA = "0x2DB8E8C")]
	private void DeleteRecordedAnimation(TrackAsset track)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x2DB8848", Offset = "0x2DB4848", VA = "0x2DB8848")]
	private void DeleteRecordedAnimation(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x2DB92C0", Offset = "0x2DB52C0", VA = "0x2DB92C0")]
	public TimelineAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x2000024")]
[IgnoreOnPlayableTrack]
public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner
{
	[Token(Token = "0x2000025")]
	internal enum Versions
	{
		[Token(Token = "0x40000C6")]
		Initial,
		[Token(Token = "0x40000C7")]
		RotationAsEuler,
		[Token(Token = "0x40000C8")]
		RootMotionUpgrade,
		[Token(Token = "0x40000C9")]
		AnimatedTrackProperties
	}

	[Token(Token = "0x2000026")]
	private static class TrackAssetUpgrade
	{
	}

	[Token(Token = "0x2000027")]
	private struct TransientBuildData
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<TrackAsset> trackList;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<TimelineClip> clipList;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<IMarker> markerList;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2DBFC94", Offset = "0x2DBBC94", VA = "0x2DBFC94")]
		public static TransientBuildData Create()
		{
			return default(TransientBuildData);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2DBD874", Offset = "0x2DB9874", VA = "0x2DBD874")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class <get_outputs>d__65 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableBinding <>2__current;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>l__initialThreadId;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TrackAsset <>4__this;

		[Token(Token = "0x17000087")]
		private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2DC0078", Offset = "0x2DBC078", VA = "0x2DC0078", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PlayableBinding);
			}
		}

		[Token(Token = "0x17000088")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2DC00C0", Offset = "0x2DBC0C0", VA = "0x2DC00C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2DBAA88", Offset = "0x2DB6A88", VA = "0x2DBAA88")]
		[DebuggerHidden]
		public <get_outputs>d__65(int <>1__state)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2DBFE34", Offset = "0x2DBBE34", VA = "0x2DBFE34", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2DBFE38", Offset = "0x2DBBE38", VA = "0x2DBFE38", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2DC0088", Offset = "0x2DBC088", VA = "0x2DC0088", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2DC0120", Offset = "0x2DBC120", VA = "0x2DC0120", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2DC01BC", Offset = "0x2DBC1BC", VA = "0x2DC01BC", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x40000AD")]
	private const int k_LatestVersion = 3;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private int m_Version;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Obsolete("Please use m_InfiniteClip (on AnimationTrack) instead.", false)]
	[FormerlySerializedAs("m_animClip")]
	[HideInInspector]
	[SerializeField]
	internal AnimationClip m_AnimClip;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static TransientBuildData s_BuildData;

	[Token(Token = "0x40000B1")]
	internal const string kDefaultCurvesName = "Track Parameters";

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	private bool m_Locked;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[HideInInspector]
	[SerializeField]
	private bool m_Muted;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private string m_CustomPlayableFullTypename;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[SerializeField]
	private AnimationClip m_Curves;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[HideInInspector]
	private PlayableAsset m_Parent;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	private List<ScriptableObject> m_Children;

	[NonSerialized]
	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_ItemsHash;

	[NonSerialized]
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TimelineClip[] m_ClipsCache;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private DiscreteTime m_Start;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private DiscreteTime m_End;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool m_CacheSorted;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool? m_SupportsNotifications;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static TrackAsset[] s_EmptyCache;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private IEnumerable<TrackAsset> m_ChildTrackCache;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	[SerializeField]
	protected internal List<TimelineClip> m_Clips;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[HideInInspector]
	private MarkerList m_Markers;

	[Token(Token = "0x17000070")]
	public double start
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2DBA720", Offset = "0x2DB6720", VA = "0x2DBA720")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000071")]
	public double end
	{
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2DB7EE0", Offset = "0x2DB3EE0", VA = "0x2DB7EE0")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000072")]
	public sealed override double duration
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2DBA88C", Offset = "0x2DB688C", VA = "0x2DBA88C", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000073")]
	public bool muted
	{
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2DBA8F4", Offset = "0x2DB68F4", VA = "0x2DBA8F4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2DBA8FC", Offset = "0x2DB68FC", VA = "0x2DBA8FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public bool mutedInHierarchy
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2DB7BB0", Offset = "0x2DB3BB0", VA = "0x2DB7BB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000075")]
	public TimelineAsset timelineAsset
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2DB82A0", Offset = "0x2DB42A0", VA = "0x2DB82A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000076")]
	public PlayableAsset parent
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2DBA904", Offset = "0x2DB6904", VA = "0x2DBA904")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2DBA90C", Offset = "0x2DB690C", VA = "0x2DBA90C")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000077")]
	internal TimelineClip[] clips
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2DAFF2C", Offset = "0x2DABF2C", VA = "0x2DAFF2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000078")]
	public virtual bool isEmpty
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2DBA914", Offset = "0x2DB6914", VA = "0x2DBA914", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000079")]
	public bool hasClips
	{
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2DADBD4", Offset = "0x2DA9BD4", VA = "0x2DADBD4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700007A")]
	public bool hasCurves
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2DBA980", Offset = "0x2DB6980", VA = "0x2DBA980", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700007B")]
	public bool isSubTrack
	{
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2DB0824", Offset = "0x2DAC824", VA = "0x2DB0824")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700007C")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2DBAA14", Offset = "0x2DB6A14", VA = "0x2DBAA14", Slot = "8")]
		[IteratorStateMachine(typeof(<get_outputs>d__65))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007D")]
	internal string customPlayableTypename
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2DBACC4", Offset = "0x2DB6CC4", VA = "0x2DBACC4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2DBACCC", Offset = "0x2DB6CCC", VA = "0x2DBACCC")]
		set
		{
		}
	}

	[Token(Token = "0x1700007E")]
	public AnimationClip curves
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2DBACD4", Offset = "0x2DB6CD4", VA = "0x2DBACD4", Slot = "12")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2DBACDC", Offset = "0x2DB6CDC", VA = "0x2DBACDC")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700007F")]
	private string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2DBACE4", Offset = "0x2DB6CE4", VA = "0x2DBACE4", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000080")]
	private Object UnityEngine.Timeline.ICurvesOwner.asset
	{
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2DBAD24", Offset = "0x2DB6D24", VA = "0x2DBAD24", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000081")]
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner
	{
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2DBAD28", Offset = "0x2DB6D28", VA = "0x2DBAD28", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000082")]
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack
	{
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2DBAD2C", Offset = "0x2DB6D2C", VA = "0x2DBAD2C", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000083")]
	internal List<ScriptableObject> subTracksObjects
	{
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2DBAD30", Offset = "0x2DB6D30", VA = "0x2DBAD30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000084")]
	public bool locked
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2DBAD38", Offset = "0x2DB6D38", VA = "0x2DBAD38")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2DBAD40", Offset = "0x2DB6D40", VA = "0x2DBAD40")]
		set
		{
		}
	}

	[Token(Token = "0x17000085")]
	public bool lockedInHierarchy
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2DBAD48", Offset = "0x2DB6D48", VA = "0x2DBAD48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000086")]
	public bool supportsNotifications
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2DBAED8", Offset = "0x2DB6ED8", VA = "0x2DBAED8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000001")]
	internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2DBA350", Offset = "0x2DB6350", VA = "0x2DBA350")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2DBA444", Offset = "0x2DB6444", VA = "0x2DBA444")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2DBA538", Offset = "0x2DB6538", VA = "0x2DBA538")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2DBA62C", Offset = "0x2DB662C", VA = "0x2DBA62C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x2DB9DC4", Offset = "0x2DB5DC4", VA = "0x2DB9DC4", Slot = "20")]
	protected virtual void OnBeforeTrackSerialize()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x2DB9DC8", Offset = "0x2DB5DC8", VA = "0x2DB9DC8", Slot = "21")]
	protected virtual void OnAfterTrackDeserialize()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x2DB9DCC", Offset = "0x2DB5DCC", VA = "0x2DB9DCC", Slot = "22")]
	internal virtual void OnUpgradeFromVersion(int oldVersion)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x2DB9DD0", Offset = "0x2DB5DD0", VA = "0x2DB9DD0", Slot = "9")]
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x2DB9F30", Offset = "0x2DB5F30", VA = "0x2DB9F30", Slot = "10")]
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x2DBA330", Offset = "0x2DB6330", VA = "0x2DBA330")]
	private void UpgradeToLatestVersion()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x2DB39F8", Offset = "0x2DAF9F8", VA = "0x2DB39F8")]
	public IEnumerable<TimelineClip> GetClips()
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x2DB2350", Offset = "0x2DAE350", VA = "0x2DB2350")]
	public IEnumerable<TrackAsset> GetChildTracks()
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x2DBAF90", Offset = "0x2DB6F90", VA = "0x2DBAF90")]
	private void __internalAwake()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x2DBB050", Offset = "0x2DB7050", VA = "0x2DBB050", Slot = "15")]
	public void CreateCurves(string curvesClipName)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x2DBB104", Offset = "0x2DB7104", VA = "0x2DBB104", Slot = "24")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x2DBB174", Offset = "0x2DB7174", VA = "0x2DBB174", Slot = "6")]
	public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x2DBB1C4", Offset = "0x2DB71C4", VA = "0x2DBB1C4")]
	public TimelineClip CreateDefaultClip()
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	public TimelineClip CreateClip<T>() where T : ScriptableObject, IPlayableAsset
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x2DBB4C0", Offset = "0x2DB74C0", VA = "0x2DBB4C0")]
	public bool DeleteClip(TimelineClip clip)
	{
		return default(bool);
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x2DBB5D0", Offset = "0x2DB75D0", VA = "0x2DBB5D0")]
	public IMarker CreateMarker(Type type, double time)
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	public T CreateMarker<T>(double time) where T : ScriptableObject, IMarker
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x2DBB8D4", Offset = "0x2DB78D4", VA = "0x2DBB8D4")]
	public bool DeleteMarker(IMarker marker)
	{
		return default(bool);
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x2DBA334", Offset = "0x2DB6334", VA = "0x2DBA334")]
	public IEnumerable<IMarker> GetMarkers()
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x2DBAA0C", Offset = "0x2DB6A0C", VA = "0x2DBAA0C")]
	public int GetMarkerCount()
	{
		return default(int);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x2DBBB24", Offset = "0x2DB7B24", VA = "0x2DBBB24")]
	public IMarker GetMarker(int idx)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x2DBBB8C", Offset = "0x2DB7B8C", VA = "0x2DBBB8C")]
	internal TimelineClip CreateClip(Type requestedType)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x2DBB490", Offset = "0x2DB7490", VA = "0x2DBB490")]
	internal TimelineClip CreateAndAddNewClipOfType(Type requestedType)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x2DBBF0C", Offset = "0x2DB7F0C", VA = "0x2DBBF0C")]
	internal TimelineClip CreateClipOfType(Type requestedType)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x2DBC34C", Offset = "0x2DB834C", VA = "0x2DBC34C")]
	internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x2DBC0D0", Offset = "0x2DB80D0", VA = "0x2DBC0D0")]
	private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x2DBC7B4", Offset = "0x2DB87B4", VA = "0x2DBC7B4")]
	internal IEnumerable<ScriptableObject> GetMarkersRaw()
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x2DBC7BC", Offset = "0x2DB87BC", VA = "0x2DBC7BC")]
	internal void ClearMarkers()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x2DBC834", Offset = "0x2DB8834", VA = "0x2DBC834")]
	internal void AddMarker(ScriptableObject e)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x2DBC924", Offset = "0x2DB8924", VA = "0x2DBC924")]
	internal bool DeleteMarkerRaw(ScriptableObject marker)
	{
		return default(bool);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x2DBCA10", Offset = "0x2DB8A10", VA = "0x2DBCA10")]
	private int GetTimeRangeHash()
	{
		return default(int);
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x2DB491C", Offset = "0x2DB091C", VA = "0x2DB491C")]
	internal void AddClip(TimelineClip newClip)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x2DBCC98", Offset = "0x2DB8C98", VA = "0x2DBCC98")]
	private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable)
	{
		return default(Playable);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x2DBD2D0", Offset = "0x2DB92D0", VA = "0x2DBD2D0")]
	internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable)
	{
		return default(Playable);
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x2DBD954", Offset = "0x2DB9954", VA = "0x2DBD954", Slot = "25")]
	internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
	{
		return default(Playable);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x2DBDED0", Offset = "0x2DB9ED0", VA = "0x2DBDED0")]
	private void GatherCompilableTracks(IList<TrackAsset> tracks)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x2DBCF8C", Offset = "0x2DB8F8C", VA = "0x2DBCF8C")]
	private void GatherNotifications(List<IMarker> markers)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x2DBE294", Offset = "0x2DBA294", VA = "0x2DBE294", Slot = "26")]
	internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x2DBDD78", Offset = "0x2DB9D78", VA = "0x2DBDD78")]
	internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x2DBE85C", Offset = "0x2DBA85C", VA = "0x2DBE85C")]
	internal void SortClips()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x2DBE97C", Offset = "0x2DBA97C", VA = "0x2DBE97C")]
	internal void ClearClipsInternal()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x2DBE9F4", Offset = "0x2DBA9F4", VA = "0x2DBE9F4")]
	internal void ClearSubTracksInternal()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x2DB45A0", Offset = "0x2DB05A0", VA = "0x2DB45A0")]
	internal void OnClipMove()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x2DBC59C", Offset = "0x2DB859C", VA = "0x2DBC59C")]
	internal TimelineClip CreateNewClipContainerInternal()
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x2DB91C4", Offset = "0x2DB51C4", VA = "0x2DB91C4")]
	internal void AddChild(TrackAsset child)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x2DBEA6C", Offset = "0x2DBAA6C", VA = "0x2DBEA6C")]
	internal void MoveLastTrackBefore(TrackAsset asset)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x2DB7518", Offset = "0x2DB3518", VA = "0x2DB7518")]
	internal bool RemoveSubTrack(TrackAsset child)
	{
		return default(bool);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x2DB48BC", Offset = "0x2DB08BC", VA = "0x2DB48BC")]
	internal void RemoveClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x2DB2E84", Offset = "0x2DAEE84", VA = "0x2DB2E84", Slot = "27")]
	internal virtual void GetEvaluationTime(out double outStart, out double outDuration)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x2DB317C", Offset = "0x2DAF17C", VA = "0x2DB317C", Slot = "28")]
	internal virtual void GetSequenceTime(out double outStart, out double outDuration)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x2DBEC88", Offset = "0x2DBAC88", VA = "0x2DBEC88", Slot = "29")]
	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x2DADEBC", Offset = "0x2DA9EBC", VA = "0x2DADEBC")]
	internal GameObject GetGameObjectBinding(PlayableDirector director)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x2DBBC8C", Offset = "0x2DB7C8C", VA = "0x2DBBC8C")]
	internal bool ValidateClipType(Type clipType)
	{
		return default(bool);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x2DAE084", Offset = "0x2DAA084", VA = "0x2DAE084", Slot = "30")]
	protected virtual void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x2DBA780", Offset = "0x2DB6780", VA = "0x2DBA780")]
	private void UpdateDuration()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x2DB0B08", Offset = "0x2DACB08", VA = "0x2DB0B08", Slot = "31")]
	protected internal virtual int CalculateItemsHash()
	{
		return default(int);
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x2DBF468", Offset = "0x2DBB468", VA = "0x2DBF468", Slot = "32")]
	protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
	{
		return default(Playable);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x2DBA2A8", Offset = "0x2DB62A8", VA = "0x2DBA2A8")]
	internal void Invalidate()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x2DB318C", Offset = "0x2DAF18C", VA = "0x2DB318C")]
	internal double GetNotificationDuration()
	{
		return default(double);
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x2DADC28", Offset = "0x2DA9C28", VA = "0x2DADC28", Slot = "33")]
	internal virtual bool CanCompileClips()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x2DBF704", Offset = "0x2DBB704", VA = "0x2DBF704", Slot = "34")]
	public virtual bool CanCreateTrackMixer()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x2DBF714", Offset = "0x2DBB714", VA = "0x2DBF714")]
	internal bool IsCompilable()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x2DBAABC", Offset = "0x2DB6ABC", VA = "0x2DBAABC")]
	private void UpdateChildTrackCache()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x2DBFA90", Offset = "0x2DBBA90", VA = "0x2DBFA90", Slot = "35")]
	internal virtual int Hash()
	{
		return default(int);
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x2DBF31C", Offset = "0x2DBB31C", VA = "0x2DBF31C")]
	private int GetClipsHash()
	{
		return default(int);
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x2DB0A20", Offset = "0x2DACA20", VA = "0x2DB0A20")]
	protected static int GetAnimationClipHash(AnimationClip clip)
	{
		return default(int);
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x2DBEC6C", Offset = "0x2DBAC6C", VA = "0x2DBEC6C")]
	private bool HasNotifications()
	{
		return default(bool);
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x2DBE268", Offset = "0x2DBA268", VA = "0x2DBE268")]
	private bool CanCompileNotifications()
	{
		return default(bool);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x2DBD590", Offset = "0x2DB9590", VA = "0x2DBD590")]
	private bool CanCreateMixerRecursive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x2DAE0E4", Offset = "0x2DAA0E4", VA = "0x2DAE0E4")]
	protected TrackAsset()
	{
	}
}
[Token(Token = "0x200002A")]
[Conditional("UNITY_EDITOR")]
internal class TimelineHelpURLAttribute : Attribute
{
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x2DC01C0", Offset = "0x2DBC1C0", VA = "0x2DC01C0")]
	public TimelineHelpURLAttribute(Type type)
	{
	}
}
[Token(Token = "0x200002B")]
[AttributeUsage(AttributeTargets.Class)]
public class TrackColorAttribute : Attribute
{
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Color m_Color;

	[Token(Token = "0x17000089")]
	public Color color
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2DC01C8", Offset = "0x2DBC1C8", VA = "0x2DC01C8")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2DC01D4", Offset = "0x2DBC1D4", VA = "0x2DC01D4")]
	public TrackColorAttribute(float r, float g, float b)
	{
	}
}
[Serializable]
[Token(Token = "0x200002C")]
[NotKeyable]
internal class AudioClipProperties : PlayableBehaviour
{
	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Range(0f, 1f)]
	public float volume;

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x2DC0218", Offset = "0x2DBC218", VA = "0x2DC0218")]
	public AudioClipProperties()
	{
	}
}
[Serializable]
[Token(Token = "0x200002D")]
internal class AudioMixerProperties : PlayableBehaviour
{
	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Range(0f, 1f)]
	public float volume;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Range(-1f, 1f)]
	public float stereoPan;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 1f)]
	public float spatialBlend;

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x2DC0228", Offset = "0x2DBC228", VA = "0x2DC0228", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x2DC04DC", Offset = "0x2DBC4DC", VA = "0x2DC04DC")]
	public AudioMixerProperties()
	{
	}
}
[Serializable]
[Token(Token = "0x200002E")]
public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class <get_outputs>d__16 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableBinding <>2__current;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>l__initialThreadId;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioPlayableAsset <>4__this;

		[Token(Token = "0x17000090")]
		private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x2DC08D0", Offset = "0x2DBC8D0", VA = "0x2DC08D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PlayableBinding);
			}
		}

		[Token(Token = "0x17000091")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x2DC0918", Offset = "0x2DBC918", VA = "0x2DC0918", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2DC0644", Offset = "0x2DBC644", VA = "0x2DC0644")]
		[DebuggerHidden]
		public <get_outputs>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2DC0848", Offset = "0x2DBC848", VA = "0x2DC0848", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2DC084C", Offset = "0x2DBC84C", VA = "0x2DC084C", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2DC08E0", Offset = "0x2DBC8E0", VA = "0x2DC08E0", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2DC0978", Offset = "0x2DBC978", VA = "0x2DC0978", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2DC0A14", Offset = "0x2DBCA14", VA = "0x2DC0A14", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip m_Clip;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool m_Loop;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	[HideInInspector]
	private float m_bufferingTime;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClipProperties m_ClipProperties;

	[Token(Token = "0x1700008A")]
	internal float bufferingTime
	{
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2DC04EC", Offset = "0x2DBC4EC", VA = "0x2DC04EC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2DC04F4", Offset = "0x2DBC4F4", VA = "0x2DC04F4")]
		set
		{
		}
	}

	[Token(Token = "0x1700008B")]
	public AudioClip clip
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2DC04FC", Offset = "0x2DBC4FC", VA = "0x2DC04FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2DC0504", Offset = "0x2DBC504", VA = "0x2DC0504")]
		set
		{
		}
	}

	[Token(Token = "0x1700008C")]
	public bool loop
	{
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2DC050C", Offset = "0x2DBC50C", VA = "0x2DC050C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2DC0514", Offset = "0x2DBC514", VA = "0x2DC0514")]
		set
		{
		}
	}

	[Token(Token = "0x1700008D")]
	public override double duration
	{
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2DC051C", Offset = "0x2DBC51C", VA = "0x2DC051C", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700008E")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2DC05D0", Offset = "0x2DBC5D0", VA = "0x2DC05D0", Slot = "8")]
		[IteratorStateMachine(typeof(<get_outputs>d__16))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008F")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2DC07C8", Offset = "0x2DBC7C8", VA = "0x2DC07C8", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x2DC0678", Offset = "0x2DBC678", VA = "0x2DC0678", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x2DC07D4", Offset = "0x2DBC7D4", VA = "0x2DC07D4")]
	public AudioPlayableAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x2000030")]
[TrackClipType(typeof(AudioPlayableAsset), false)]
[TrackBindingType(typeof(AudioSource))]
[ExcludeFromPreset]
public class AudioTrack : TrackAsset
{
	[Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class <get_outputs>d__4 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableBinding <>2__current;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>l__initialThreadId;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioTrack <>4__this;

		[Token(Token = "0x17000093")]
		private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x2DC148C", Offset = "0x2DBD48C", VA = "0x2DC148C", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PlayableBinding);
			}
		}

		[Token(Token = "0x17000094")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x2DC14D4", Offset = "0x2DBD4D4", VA = "0x2DC14D4", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2DC12E8", Offset = "0x2DBD2E8", VA = "0x2DC12E8")]
		[DebuggerHidden]
		public <get_outputs>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2DC1404", Offset = "0x2DBD404", VA = "0x2DC1404", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2DC1408", Offset = "0x2DBD408", VA = "0x2DC1408", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2DC149C", Offset = "0x2DBD49C", VA = "0x2DC149C", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2DC1534", Offset = "0x2DBD534", VA = "0x2DC1534", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2DC15D0", Offset = "0x2DBD5D0", VA = "0x2DC15D0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private AudioMixerProperties m_TrackProperties;

	[Token(Token = "0x17000092")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2DC1274", Offset = "0x2DBD274", VA = "0x2DC1274", Slot = "8")]
		[IteratorStateMachine(typeof(<get_outputs>d__4))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2DC0A18", Offset = "0x2DBCA18", VA = "0x2DC0A18")]
	public TimelineClip CreateClip(AudioClip clip)
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x2DC0B4C", Offset = "0x2DBCB4C", VA = "0x2DC0B4C", Slot = "25")]
	internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
	{
		return default(Playable);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x2DC131C", Offset = "0x2DBD31C", VA = "0x2DC131C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x2DC1374", Offset = "0x2DBD374", VA = "0x2DC1374")]
	public AudioTrack()
	{
	}
}
[Token(Token = "0x2000032")]
[Flags]
public enum ClipCaps
{
	[Token(Token = "0x40000E6")]
	None = 0,
	[Token(Token = "0x40000E7")]
	Looping = 1,
	[Token(Token = "0x40000E8")]
	Extrapolation = 2,
	[Token(Token = "0x40000E9")]
	ClipIn = 4,
	[Token(Token = "0x40000EA")]
	SpeedMultiplier = 8,
	[Token(Token = "0x40000EB")]
	Blending = 0x10,
	[Token(Token = "0x40000EC")]
	AutoScale = 0x28,
	[Token(Token = "0x40000ED")]
	All = -1
}
[Token(Token = "0x2000033")]
internal static class TimelineClipCapsExtensions
{
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x2DC15D4", Offset = "0x2DBD5D4", VA = "0x2DC15D4")]
	public static bool SupportsLooping(this TimelineClip clip)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2DC15EC", Offset = "0x2DBD5EC", VA = "0x2DC15EC")]
	public static bool SupportsExtrapolation(this TimelineClip clip)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x2DC1604", Offset = "0x2DBD604", VA = "0x2DC1604")]
	public static bool SupportsClipIn(this TimelineClip clip)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x2DC161C", Offset = "0x2DBD61C", VA = "0x2DC161C")]
	public static bool SupportsSpeedMultiplier(this TimelineClip clip)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x2DC1634", Offset = "0x2DBD634", VA = "0x2DC1634")]
	public static bool SupportsBlending(this TimelineClip clip)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x2DC164C", Offset = "0x2DBD64C", VA = "0x2DC164C")]
	public static bool HasAll(this ClipCaps caps, ClipCaps flags)
	{
		return default(bool);
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x2DB4384", Offset = "0x2DB0384", VA = "0x2DB4384")]
	public static bool HasAny(this ClipCaps caps, ClipCaps flags)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000034")]
[NotKeyable]
public class ControlPlayableAsset : PlayableAsset, IPropertyPreview, ITimelineClipAsset
{
	[Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class <GetControlableScripts>d__39 : IEnumerable<MonoBehaviour>, IEnumerable, IEnumerator<MonoBehaviour>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MonoBehaviour <>2__current;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int <>l__initialThreadId;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject root;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject <>3__root;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MonoBehaviour[] <>7__wrap1;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <>7__wrap2;

		[Token(Token = "0x17000099")]
		private MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.Current
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x2DC53EC", Offset = "0x2DC13EC", VA = "0x2DC53EC", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x2DC542C", Offset = "0x2DC142C", VA = "0x2DC542C", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2DC3B64", Offset = "0x2DBFB64", VA = "0x2DC3B64")]
		[DebuggerHidden]
		public <GetControlableScripts>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2DC52B0", Offset = "0x2DC12B0", VA = "0x2DC52B0", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2DC52B4", Offset = "0x2DC12B4", VA = "0x2DC52B4", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2DC53F4", Offset = "0x2DC13F4", VA = "0x2DC53F4", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2DC5434", Offset = "0x2DC1434", VA = "0x2DC5434", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MonoBehaviour> System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2DC54D0", Offset = "0x2DC14D0", VA = "0x2DC54D0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x40000EE")]
	private const int k_MaxRandInt = 10000;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly List<PlayableDirector> k_EmptyDirectorsList;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly List<ParticleSystem> k_EmptyParticlesList;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly HashSet<ParticleSystem> s_SubEmitterCollector;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ExposedReference<GameObject> sourceGameObject;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public GameObject prefabGameObject;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool updateParticle;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public uint particleRandomSeed;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public bool updateDirector;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	[SerializeField]
	public bool updateITimeControl;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	[SerializeField]
	public bool searchHierarchy;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	[SerializeField]
	public bool active;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public ActivationControlPlayable.PostPlaybackState postPlayback;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PlayableAsset m_ControlDirectorAsset;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private double m_Duration;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_SupportLoop;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static HashSet<PlayableDirector> s_ProcessedDirectors;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static HashSet<GameObject> s_CreatedPrefabs;

	[Token(Token = "0x17000095")]
	internal bool controllingDirectors
	{
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2DC1658", Offset = "0x2DBD658", VA = "0x2DC1658")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2DC1660", Offset = "0x2DBD660", VA = "0x2DC1660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000096")]
	internal bool controllingParticles
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2DC1668", Offset = "0x2DBD668", VA = "0x2DC1668")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2DC1670", Offset = "0x2DBD670", VA = "0x2DC1670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000097")]
	public override double duration
	{
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2DC16A8", Offset = "0x2DBD6A8", VA = "0x2DC16A8", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000098")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2DC16B0", Offset = "0x2DBD6B0", VA = "0x2DC16B0", Slot = "10")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x2DC1678", Offset = "0x2DBD678", VA = "0x2DC1678")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x2DC16BC", Offset = "0x2DBD6BC", VA = "0x2DC16BC", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x2DC36C4", Offset = "0x2DBF6C4", VA = "0x2DC36C4")]
	private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables)
	{
		return default(Playable);
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x2DC28B8", Offset = "0x2DBE8B8", VA = "0x2DC28B8")]
	private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x2DC2E6C", Offset = "0x2DBEE6C", VA = "0x2DC2E6C")]
	private void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, PlayableGraph graph, List<Playable> outplayables)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x2DC2A0C", Offset = "0x2DBEA0C", VA = "0x2DC2A0C")]
	private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x2DC32D8", Offset = "0x2DBF2D8", VA = "0x2DC32D8")]
	private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x2DC382C", Offset = "0x2DBF82C", VA = "0x2DC382C")]
	private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex)
	{
	}

	[Token(Token = "0x60001F9")]
	internal IList<T> GetComponent<T>(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x2DC3264", Offset = "0x2DBF264", VA = "0x2DC3264")]
	[IteratorStateMachine(typeof(<GetControlableScripts>d__39))]
	internal static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root)
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x2DC2048", Offset = "0x2DBE048", VA = "0x2DC2048")]
	internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x2DC1EDC", Offset = "0x2DBDEDC", VA = "0x2DC1EDC")]
	private IList<ParticleSystem> GetControllableParticleSystems(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x2DC3BA4", Offset = "0x2DBFBA4", VA = "0x2DC3BA4")]
	private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x2DC3D8C", Offset = "0x2DBFD8C", VA = "0x2DC3D8C")]
	private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x2DC3EA0", Offset = "0x2DBFEA0", VA = "0x2DC3EA0", Slot = "9")]
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x2DC4188", Offset = "0x2DC0188", VA = "0x2DC4188")]
	internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x2DC45A8", Offset = "0x2DC05A8", VA = "0x2DC45A8")]
	internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x2DC48E8", Offset = "0x2DC08E8", VA = "0x2DC48E8")]
	internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x2DC4CCC", Offset = "0x2DC0CCC", VA = "0x2DC4CCC")]
	internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x2DC5060", Offset = "0x2DC1060", VA = "0x2DC5060")]
	public ControlPlayableAsset()
	{
	}
}
[Token(Token = "0x2000036")]
[ExcludeFromPreset]
[TrackClipType(typeof(ControlPlayableAsset), false)]
public class ControlTrack : TrackAsset
{
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x2DC54D4", Offset = "0x2DC14D4", VA = "0x2DC54D4")]
	public ControlTrack()
	{
	}
}
[Token(Token = "0x2000037")]
internal struct DiscreteTime : IComparable
{
	[Token(Token = "0x4000109")]
	private const double k_Tick = 1E-12;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly DiscreteTime kMaxTime;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly long m_DiscreteTime;

	[Token(Token = "0x1700009B")]
	public static double tickValue
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2DC5528", Offset = "0x2DC1528", VA = "0x2DC5528")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x2DC5534", Offset = "0x2DC1534", VA = "0x2DC5534")]
	public DiscreteTime(DiscreteTime time)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x2DC553C", Offset = "0x2DC153C", VA = "0x2DC553C")]
	private DiscreteTime(long time)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x2DC5544", Offset = "0x2DC1544", VA = "0x2DC5544")]
	public DiscreteTime(double time)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x2DC5628", Offset = "0x2DC1628", VA = "0x2DC5628")]
	public DiscreteTime(float time)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x2DB7E78", Offset = "0x2DB3E78", VA = "0x2DB7E78")]
	public DiscreteTime(int time)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x2DC575C", Offset = "0x2DC175C", VA = "0x2DC575C")]
	public DiscreteTime(int frame, double fps)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x2DB61A4", Offset = "0x2DB21A4", VA = "0x2DB61A4")]
	public DiscreteTime OneTickBefore()
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2DC3B98", Offset = "0x2DBFB98", VA = "0x2DC3B98")]
	public DiscreteTime OneTickAfter()
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x2DC57D4", Offset = "0x2DC17D4", VA = "0x2DC57D4")]
	public long GetTick()
	{
		return default(long);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x2DC57DC", Offset = "0x2DC17DC", VA = "0x2DC57DC")]
	public static DiscreteTime FromTicks(long ticks)
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x2DC57E0", Offset = "0x2DC17E0", VA = "0x2DC57E0", Slot = "4")]
	public int CompareTo(object obj)
	{
		return default(int);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x2DC5868", Offset = "0x2DC1868", VA = "0x2DC5868")]
	public bool Equals(DiscreteTime other)
	{
		return default(bool);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x2DC5878", Offset = "0x2DC1878", VA = "0x2DC5878", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x2DC55AC", Offset = "0x2DC15AC", VA = "0x2DC55AC")]
	private static long DoubleToDiscreteTime(double time)
	{
		return default(long);
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x2DC5690", Offset = "0x2DC1690", VA = "0x2DC5690")]
	private static long FloatToDiscreteTime(float time)
	{
		return default(long);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x2DC5708", Offset = "0x2DC1708", VA = "0x2DC5708")]
	private static long IntToDiscreteTime(int time)
	{
		return default(long);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x2DC5920", Offset = "0x2DC1920", VA = "0x2DC5920")]
	private static double ToDouble(long time)
	{
		return default(double);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x2DC5934", Offset = "0x2DC1934", VA = "0x2DC5934")]
	private static float ToFloat(long time)
	{
		return default(float);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x2DB61B0", Offset = "0x2DB21B0", VA = "0x2DB61B0")]
	public static explicit operator double(DiscreteTime b)
	{
		return default(double);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x2DC5998", Offset = "0x2DC1998", VA = "0x2DC5998")]
	public static explicit operator float(DiscreteTime b)
	{
		return default(float);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x2DC59EC", Offset = "0x2DC19EC", VA = "0x2DC59EC")]
	public static explicit operator long(DiscreteTime b)
	{
		return default(long);
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x2DB62C4", Offset = "0x2DB22C4", VA = "0x2DB62C4")]
	public static explicit operator DiscreteTime(double time)
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x2DC59F0", Offset = "0x2DC19F0", VA = "0x2DC59F0")]
	public static explicit operator DiscreteTime(float time)
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x2DB617C", Offset = "0x2DB217C", VA = "0x2DB617C")]
	public static implicit operator DiscreteTime(int time)
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x2DC5A08", Offset = "0x2DC1A08", VA = "0x2DC5A08")]
	public static explicit operator DiscreteTime(long time)
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x2DC5A0C", Offset = "0x2DC1A0C", VA = "0x2DC5A0C")]
	public static bool operator ==(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x2DC5A18", Offset = "0x2DC1A18", VA = "0x2DC5A18")]
	public static bool operator !=(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x2DC5A7C", Offset = "0x2DC1A7C", VA = "0x2DC5A7C")]
	public static bool operator >(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x2DC5A88", Offset = "0x2DC1A88", VA = "0x2DC5A88")]
	public static bool operator <(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x2DB6198", Offset = "0x2DB2198", VA = "0x2DB6198")]
	public static bool operator <=(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x2DC5A94", Offset = "0x2DC1A94", VA = "0x2DC5A94")]
	public static bool operator >=(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x2DC5AA0", Offset = "0x2DC1AA0", VA = "0x2DC5AA0")]
	public static DiscreteTime operator +(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x2DBA8EC", Offset = "0x2DB68EC", VA = "0x2DBA8EC")]
	public static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x2DC5AA8", Offset = "0x2DC1AA8", VA = "0x2DC5AA8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x2DC5AC4", Offset = "0x2DC1AC4", VA = "0x2DC5AC4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x2DC5AE0", Offset = "0x2DC1AE0", VA = "0x2DC5AE0")]
	public static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x2DB7F40", Offset = "0x2DB3F40", VA = "0x2DB7F40")]
	public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(DiscreteTime);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x2DC5B48", Offset = "0x2DC1B48", VA = "0x2DC5B48")]
	public static double SnapToNearestTick(double time)
	{
		return default(double);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x2DC5BB8", Offset = "0x2DC1BB8", VA = "0x2DC5BB8")]
	public static float SnapToNearestTick(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x2DC5C18", Offset = "0x2DC1C18", VA = "0x2DC5C18")]
	public static long GetNearestTick(double time)
	{
		return default(long);
	}
}
[Token(Token = "0x2000038")]
internal class InfiniteRuntimeClip : RuntimeElement
{
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Playable m_Playable;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly long kIntervalEnd;

	[Token(Token = "0x1700009C")]
	public override long intervalStart
	{
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2DC5CC8", Offset = "0x2DC1CC8", VA = "0x2DC5CC8", Slot = "6")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700009D")]
	public override long intervalEnd
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2DC5CD0", Offset = "0x2DC1CD0", VA = "0x2DC5CD0", Slot = "7")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700009E")]
	public override bool enable
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2DC5D28", Offset = "0x2DC1D28", VA = "0x2DC5D28", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x2DB2DBC", Offset = "0x2DAEDBC", VA = "0x2DB2DBC")]
	public InfiniteRuntimeClip(Playable playable)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x2DC5D9C", Offset = "0x2DC1D9C", VA = "0x2DC5D9C", Slot = "9")]
	public override void EvaluateAt(double localTime, FrameData frameData)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x2DC5DF4", Offset = "0x2DC1DF4", VA = "0x2DC5DF4", Slot = "10")]
	public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
	{
	}
}
[Token(Token = "0x2000039")]
internal interface IInterval
{
	[Token(Token = "0x1700009F")]
	long intervalStart
	{
		[Token(Token = "0x6000240")]
		get;
	}

	[Token(Token = "0x170000A0")]
	long intervalEnd
	{
		[Token(Token = "0x6000241")]
		get;
	}
}
[Token(Token = "0x200003A")]
internal struct IntervalTreeNode
{
	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public long center;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int first;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int last;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int left;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int right;
}
[Token(Token = "0x200003B")]
internal class IntervalTree<T> where T : IInterval
{
	[Token(Token = "0x200003C")]
	internal struct Entry
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long intervalStart;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long intervalEnd;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T item;
	}

	[Token(Token = "0x4000113")]
	private const int kMinNodeSize = 10;

	[Token(Token = "0x4000114")]
	private const int kInvalidNode = -1;

	[Token(Token = "0x4000115")]
	private const long kCenterUnknown = long.MaxValue;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly List<Entry> m_Entries;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly List<IntervalTreeNode> m_Nodes;

	[Token(Token = "0x170000A1")]
	public bool dirty
	{
		[Token(Token = "0x6000242")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000243")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x6000244")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x6000245")]
	public void IntersectsWith(long value, List<T> results)
	{
	}

	[Token(Token = "0x6000246")]
	public void IntersectsWithRange(long start, long end, List<T> results)
	{
	}

	[Token(Token = "0x6000247")]
	public void UpdateIntervals()
	{
	}

	[Token(Token = "0x6000248")]
	private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results)
	{
	}

	[Token(Token = "0x6000249")]
	private void QueryRange(IntervalTreeNode intervalTreeNode, long start, long end, List<T> results)
	{
	}

	[Token(Token = "0x600024A")]
	private void Rebuild()
	{
	}

	[Token(Token = "0x600024B")]
	private int Rebuild(int start, int end)
	{
		return default(int);
	}

	[Token(Token = "0x600024C")]
	public void Clear()
	{
	}

	[Token(Token = "0x600024D")]
	public IntervalTree()
	{
	}
}
[Token(Token = "0x200003D")]
internal class RuntimeClip : RuntimeClipBase
{
	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TimelineClip m_Clip;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Playable m_Playable;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Playable m_ParentMixer;

	[Token(Token = "0x170000A2")]
	public override double start
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2DC5F10", Offset = "0x2DC1F10", VA = "0x2DC5F10", Slot = "11")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x170000A3")]
	public override double duration
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2DC5F38", Offset = "0x2DC1F38", VA = "0x2DC5F38", Slot = "12")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x170000A4")]
	public TimelineClip clip
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2DC5FD8", Offset = "0x2DC1FD8", VA = "0x2DC5FD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A5")]
	public Playable mixer
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2DC5FE0", Offset = "0x2DC1FE0", VA = "0x2DC5FE0")]
		get
		{
			return default(Playable);
		}
	}

	[Token(Token = "0x170000A6")]
	public Playable playable
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2DC5FEC", Offset = "0x2DC1FEC", VA = "0x2DC5FEC")]
		get
		{
			return default(Playable);
		}
	}

	[Token(Token = "0x170000A7")]
	public override bool enable
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2DC5FF8", Offset = "0x2DC1FF8", VA = "0x2DC5FF8", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x2DB0F94", Offset = "0x2DACF94", VA = "0x2DB0F94")]
	public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x2DC5F54", Offset = "0x2DC1F54", VA = "0x2DC5F54")]
	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x2DC612C", Offset = "0x2DC212C", VA = "0x2DC612C")]
	public void SetTime(double time)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x2DC6184", Offset = "0x2DC2184", VA = "0x2DC6184")]
	public void SetDuration(double duration)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x2DC61DC", Offset = "0x2DC21DC", VA = "0x2DC61DC", Slot = "9")]
	public override void EvaluateAt(double localTime, FrameData frameData)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x2DC63CC", Offset = "0x2DC23CC", VA = "0x2DC63CC", Slot = "10")]
	public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
	{
	}
}
[Token(Token = "0x200003E")]
internal abstract class RuntimeClipBase : RuntimeElement
{
	[Token(Token = "0x170000A8")]
	public abstract double start
	{
		[Token(Token = "0x600025A")]
		get;
	}

	[Token(Token = "0x170000A9")]
	public abstract double duration
	{
		[Token(Token = "0x600025B")]
		get;
	}

	[Token(Token = "0x170000AA")]
	public override long intervalStart
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2DC6524", Offset = "0x2DC2524", VA = "0x2DC6524", Slot = "6")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x170000AB")]
	public override long intervalEnd
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2DC6594", Offset = "0x2DC2594", VA = "0x2DC6594", Slot = "7")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x2DC5F4C", Offset = "0x2DC1F4C", VA = "0x2DC5F4C")]
	protected RuntimeClipBase()
	{
	}
}
[Token(Token = "0x200003F")]
internal abstract class RuntimeElement : IInterval
{
	[Token(Token = "0x170000AC")]
	public abstract long intervalStart
	{
		[Token(Token = "0x600025F")]
		get;
	}

	[Token(Token = "0x170000AD")]
	public abstract long intervalEnd
	{
		[Token(Token = "0x6000260")]
		get;
	}

	[Token(Token = "0x170000AE")]
	public int intervalBit
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2DC6618", Offset = "0x2DC2618", VA = "0x2DC6618")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2DC6620", Offset = "0x2DC2620", VA = "0x2DC6620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000AF")]
	public abstract bool enable
	{
		[Token(Token = "0x6000263")]
		set;
	}

	[Token(Token = "0x6000264")]
	public abstract void EvaluateAt(double localTime, FrameData frameData);

	[Token(Token = "0x6000265")]
	public abstract void DisableAt(double localTime, double rootDuration, FrameData frameData);

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x2DC5CC0", Offset = "0x2DC1CC0", VA = "0x2DC5CC0")]
	protected RuntimeElement()
	{
	}
}
[Token(Token = "0x2000040")]
internal class ScheduleRuntimeClip : RuntimeClipBase
{
	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TimelineClip m_Clip;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Playable m_Playable;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Playable m_ParentMixer;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private double m_StartDelay;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private double m_FinishTail;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_Started;

	[Token(Token = "0x170000B0")]
	public override double start
	{
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2DC6628", Offset = "0x2DC2628", VA = "0x2DC6628", Slot = "11")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x170000B1")]
	public override double duration
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2DC66A0", Offset = "0x2DC26A0", VA = "0x2DC66A0", Slot = "12")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x170000B2")]
	public TimelineClip clip
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2DC6744", Offset = "0x2DC2744", VA = "0x2DC6744")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B3")]
	public Playable mixer
	{
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2DC674C", Offset = "0x2DC274C", VA = "0x2DC674C")]
		get
		{
			return default(Playable);
		}
	}

	[Token(Token = "0x170000B4")]
	public Playable playable
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2DC6758", Offset = "0x2DC2758", VA = "0x2DC6758")]
		get
		{
			return default(Playable);
		}
	}

	[Token(Token = "0x170000B5")]
	public override bool enable
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2DC67FC", Offset = "0x2DC27FC", VA = "0x2DC67FC", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x2DC66EC", Offset = "0x2DC26EC", VA = "0x2DC66EC")]
	public void SetTime(double time)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x2DC1200", Offset = "0x2DBD200", VA = "0x2DC1200")]
	public ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2, double finishTail = 0.1)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x2DC6764", Offset = "0x2DC2764", VA = "0x2DC6764")]
	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x2DC6900", Offset = "0x2DC2900", VA = "0x2DC6900", Slot = "9")]
	public override void EvaluateAt(double localTime, FrameData frameData)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x2DC6BA0", Offset = "0x2DC2BA0", VA = "0x2DC6BA0", Slot = "10")]
	public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
	{
	}
}
[Token(Token = "0x2000041")]
public interface IMarker
{
	[Token(Token = "0x170000B6")]
	double time
	{
		[Token(Token = "0x6000272")]
		get;
		[Token(Token = "0x6000273")]
		set;
	}

	[Token(Token = "0x170000B7")]
	TrackAsset parent
	{
		[Token(Token = "0x6000274")]
		get;
	}

	[Token(Token = "0x6000275")]
	void Initialize(TrackAsset parent);
}
[Token(Token = "0x2000042")]
public interface INotificationOptionProvider
{
	[Token(Token = "0x170000B8")]
	NotificationFlags flags
	{
		[Token(Token = "0x6000276")]
		get;
	}
}
[Token(Token = "0x2000043")]
public abstract class Marker : ScriptableObject, IMarker
{
	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TimeField(TimeFieldAttribute.UseEditMode.ApplyEditMode)]
	[SerializeField]
	[Tooltip("Time for the marker")]
	private double m_Time;

	[Token(Token = "0x170000B9")]
	public TrackAsset parent
	{
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2DC6BB0", Offset = "0x2DC2BB0", VA = "0x2DC6BB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2DC6BB8", Offset = "0x2DC2BB8", VA = "0x2DC6BB8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170000BA")]
	public double time
	{
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2DC6BC0", Offset = "0x2DC2BC0", VA = "0x2DC6BC0", Slot = "4")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2DC6BC8", Offset = "0x2DC2BC8", VA = "0x2DC6BC8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x2DC6C38", Offset = "0x2DC2C38", VA = "0x2DC6C38", Slot = "7")]
	private void UnityEngine.Timeline.IMarker.Initialize(TrackAsset parentTrack)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x2DC6D84", Offset = "0x2DC2D84", VA = "0x2DC6D84", Slot = "8")]
	public virtual void OnInitialize(TrackAsset aPent)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x2DC6D88", Offset = "0x2DC2D88", VA = "0x2DC6D88")]
	protected Marker()
	{
	}
}
[Serializable]
[Token(Token = "0x2000044")]
internal struct MarkerList : ISerializationCallbackReceiver
{
	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	[HideInInspector]
	private List<ScriptableObject> m_Objects;

	[NonSerialized]
	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[HideInInspector]
	private List<IMarker> m_Cache;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool m_CacheDirty;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	private bool m_HasNotifications;

	[Token(Token = "0x170000BB")]
	public List<IMarker> markers
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2DC6D90", Offset = "0x2DC2D90", VA = "0x2DC6D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BC")]
	public int Count
	{
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2DBBAD4", Offset = "0x2DB7AD4", VA = "0x2DBBAD4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000BD")]
	public IMarker this[int idx]
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2DBBB2C", Offset = "0x2DB7B2C", VA = "0x2DBBB2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x2DBFAE0", Offset = "0x2DBBAE0", VA = "0x2DBFAE0")]
	public MarkerList(int capacity)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x2DBC83C", Offset = "0x2DB883C", VA = "0x2DBC83C")]
	public void Add(ScriptableObject item)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x2DBB8DC", Offset = "0x2DB78DC", VA = "0x2DBB8DC")]
	public bool Remove(IMarker item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x2DBC954", Offset = "0x2DB8954", VA = "0x2DBC954")]
	public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty)
	{
		return default(bool);
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x2DBC7C4", Offset = "0x2DB87C4", VA = "0x2DBC7C4")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x2DC7060", Offset = "0x2DC3060", VA = "0x2DC7060")]
	public bool Contains(ScriptableObject item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x2DBBABC", Offset = "0x2DB7ABC", VA = "0x2DBBABC")]
	public IEnumerable<IMarker> GetMarkers()
	{
		return null;
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x2DC70B8", Offset = "0x2DC30B8", VA = "0x2DC70B8")]
	public List<ScriptableObject> GetRawMarkerList()
	{
		return null;
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x2DBB5DC", Offset = "0x2DB75DC", VA = "0x2DBB5DC")]
	public IMarker CreateMarker(Type type, double time, TrackAsset owner)
	{
		return null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x2DBFAC8", Offset = "0x2DBBAC8", VA = "0x2DBFAC8")]
	public bool HasNotifications()
	{
		return default(bool);
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x2DC70C0", Offset = "0x2DC30C0", VA = "0x2DC70C0", Slot = "4")]
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x2DC70C4", Offset = "0x2DC30C4", VA = "0x2DC70C4", Slot = "5")]
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x2DC6DA8", Offset = "0x2DC2DA8", VA = "0x2DC6DA8")]
	private void BuildCache()
	{
	}
}
[Serializable]
[Token(Token = "0x2000045")]
[TrackBindingType(typeof(GameObject))]
[HideInMenu]
[ExcludeFromPreset]
public class MarkerTrack : TrackAsset
{
	[Token(Token = "0x170000BE")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2DC70D0", Offset = "0x2DC30D0", VA = "0x2DC70D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x2DC72AC", Offset = "0x2DC32AC", VA = "0x2DC72AC")]
	public MarkerTrack()
	{
	}
}
[Token(Token = "0x2000046")]
internal class CustomSignalEventDrawer : PropertyAttribute
{
	[Token(Token = "0x6000290")]
	[Address(RVA = "0x2DC7300", Offset = "0x2DC3300", VA = "0x2DC7300")]
	public CustomSignalEventDrawer()
	{
	}
}
[Token(Token = "0x2000047")]
[UnityEngine.AssetFileNameExtension("signal", new string[] { })]
public class SignalAsset : ScriptableObject
{
	[Token(Token = "0x14000003")]
	internal static event Action<SignalAsset> OnEnableCallback
	{
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2DC7308", Offset = "0x2DC3308", VA = "0x2DC7308")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2DC73D4", Offset = "0x2DC33D4", VA = "0x2DC73D4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x2DC74A0", Offset = "0x2DC34A0", VA = "0x2DC74A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x2DC750C", Offset = "0x2DC350C", VA = "0x2DC750C")]
	public SignalAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x2000048")]
[CustomStyle("SignalEmitter")]
[ExcludeFromPreset]
public class SignalEmitter : Marker, INotification, INotificationOptionProvider
{
	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_Retroactive;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool m_EmitOnce;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SignalAsset m_Asset;

	[Token(Token = "0x170000BF")]
	public bool retroactive
	{
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2DC7514", Offset = "0x2DC3514", VA = "0x2DC7514")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2DC751C", Offset = "0x2DC351C", VA = "0x2DC751C")]
		set
		{
		}
	}

	[Token(Token = "0x170000C0")]
	public bool emitOnce
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2DC7524", Offset = "0x2DC3524", VA = "0x2DC7524")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2DC752C", Offset = "0x2DC352C", VA = "0x2DC752C")]
		set
		{
		}
	}

	[Token(Token = "0x170000C1")]
	public SignalAsset asset
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2DC7534", Offset = "0x2DC3534", VA = "0x2DC7534")]
		get
		{
			return null;
		}
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2DC753C", Offset = "0x2DC353C", VA = "0x2DC753C")]
		set
		{
		}
	}

	[Token(Token = "0x170000C2")]
	private PropertyName UnityEngine.Playables.INotification.id
	{
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2DC7544", Offset = "0x2DC3544", VA = "0x2DC7544", Slot = "9")]
		get
		{
			return default(PropertyName);
		}
	}

	[Token(Token = "0x170000C3")]
	private NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.flags
	{
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2DC7604", Offset = "0x2DC3604", VA = "0x2DC7604", Slot = "10")]
		get
		{
			return default(NotificationFlags);
		}
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x2DC7620", Offset = "0x2DC3620", VA = "0x2DC7620")]
	public SignalEmitter()
	{
	}
}
[Token(Token = "0x2000049")]
public class SignalReceiver : MonoBehaviour, INotificationReceiver
{
	[Serializable]
	[Token(Token = "0x200004A")]
	private class EventKeyValue
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<SignalAsset> m_Signals;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[CustomSignalEventDrawer]
		private List<UnityEvent> m_Events;

		[Token(Token = "0x170000C4")]
		public List<SignalAsset> signals
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x2DC83A0", Offset = "0x2DC43A0", VA = "0x2DC83A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public List<UnityEvent> events
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x2DC83A8", Offset = "0x2DC43A8", VA = "0x2DC83A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2DC774C", Offset = "0x2DC374C", VA = "0x2DC774C")]
		public bool TryGetValue(SignalAsset key, out UnityEvent value)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2DC7938", Offset = "0x2DC3938", VA = "0x2DC7938")]
		public void Append(SignalAsset key, UnityEvent value)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2DC7FBC", Offset = "0x2DC3FBC", VA = "0x2DC7FBC")]
		public void Remove(int idx)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2DC7B80", Offset = "0x2DC3B80", VA = "0x2DC7B80")]
		public void Remove(SignalAsset key)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2DC82DC", Offset = "0x2DC42DC", VA = "0x2DC82DC")]
		public EventKeyValue()
		{
		}
	}

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private EventKeyValue m_Events;

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x2DC7628", Offset = "0x2DC3628", VA = "0x2DC7628", Slot = "4")]
	public void OnNotify(Playable origin, INotification notification, object context)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x2DC7800", Offset = "0x2DC3800", VA = "0x2DC7800")]
	public void AddReaction(SignalAsset asset, UnityEvent reaction)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x2DC7A58", Offset = "0x2DC3A58", VA = "0x2DC7A58")]
	public int AddEmptyReaction(UnityEvent reaction)
	{
		return default(int);
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x2DC7AC4", Offset = "0x2DC3AC4", VA = "0x2DC7AC4")]
	public void Remove(SignalAsset asset)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x2DC7C40", Offset = "0x2DC3C40", VA = "0x2DC7C40")]
	public IEnumerable<SignalAsset> GetRegisteredSignals()
	{
		return null;
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x2DC7C58", Offset = "0x2DC3C58", VA = "0x2DC7C58")]
	public UnityEvent GetReaction(SignalAsset key)
	{
		return null;
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x2DC7C84", Offset = "0x2DC3C84", VA = "0x2DC7C84")]
	public int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x2DC7CD4", Offset = "0x2DC3CD4", VA = "0x2DC7CD4")]
	public void ChangeSignalAtIndex(int idx, SignalAsset newKey)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x2DC7F20", Offset = "0x2DC3F20", VA = "0x2DC7F20")]
	public void RemoveAtIndex(int idx)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x2DC8050", Offset = "0x2DC4050", VA = "0x2DC8050")]
	public void ChangeReactionAtIndex(int idx, UnityEvent reaction)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x2DC8114", Offset = "0x2DC4114", VA = "0x2DC8114")]
	public UnityEvent GetReactionAtIndex(int idx)
	{
		return null;
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x2DC81C8", Offset = "0x2DC41C8", VA = "0x2DC81C8")]
	public SignalAsset GetSignalAssetAtIndex(int idx)
	{
		return null;
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x2DC827C", Offset = "0x2DC427C", VA = "0x2DC827C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x2DC8280", Offset = "0x2DC4280", VA = "0x2DC8280")]
	public SignalReceiver()
	{
	}
}
[Serializable]
[Token(Token = "0x200004B")]
[ExcludeFromPreset]
[TrackColor(0.25f, 0.25f, 0.25f)]
[TrackBindingType(typeof(SignalReceiver))]
public class SignalTrack : MarkerTrack
{
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x2DC83B0", Offset = "0x2DC43B0", VA = "0x2DC83B0")]
	public SignalTrack()
	{
	}
}
[Token(Token = "0x200004C")]
public static class TrackAssetExtensions
{
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x2DC83B4", Offset = "0x2DC43B4", VA = "0x2DC83B4")]
	public static GroupTrack GetGroup(this TrackAsset asset)
	{
		return null;
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x2DC8478", Offset = "0x2DC4478", VA = "0x2DC8478")]
	public static void SetGroup(this TrackAsset asset, GroupTrack group)
	{
	}
}
[Serializable]
[Token(Token = "0x200004D")]
[SupportsChildTracks(null, int.MaxValue)]
[TrackClipType(typeof(TrackAsset))]
[ExcludeFromPreset]
public class GroupTrack : TrackAsset
{
	[Token(Token = "0x170000C6")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2DC87A0", Offset = "0x2DC47A0", VA = "0x2DC87A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x2DC8798", Offset = "0x2DC4798", VA = "0x2DC8798", Slot = "33")]
	internal override bool CanCompileClips()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x2DC87F8", Offset = "0x2DC47F8", VA = "0x2DC87F8")]
	public GroupTrack()
	{
	}
}
[Token(Token = "0x200004E")]
public interface ILayerable
{
	[Token(Token = "0x60002B9")]
	Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount);
}
[Token(Token = "0x200004F")]
public class ActivationControlPlayable : PlayableBehaviour
{
	[Token(Token = "0x2000050")]
	public enum PostPlaybackState
	{
		[Token(Token = "0x4000137")]
		Active,
		[Token(Token = "0x4000138")]
		Inactive,
		[Token(Token = "0x4000139")]
		Revert
	}

	[Token(Token = "0x2000051")]
	private enum InitialState
	{
		[Token(Token = "0x400013B")]
		Unset,
		[Token(Token = "0x400013C")]
		Active,
		[Token(Token = "0x400013D")]
		Inactive
	}

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject gameObject;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PostPlaybackState postPlayback;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private InitialState m_InitialState;

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x2DC38F4", Offset = "0x2DBF8F4", VA = "0x2DC38F4")]
	public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, PostPlaybackState postPlaybackState)
	{
		return default(ScriptPlayable<ActivationControlPlayable>);
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x2DC884C", Offset = "0x2DC484C", VA = "0x2DC884C", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x2DC88D4", Offset = "0x2DC48D4", VA = "0x2DC88D4", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x2DC897C", Offset = "0x2DC497C", VA = "0x2DC897C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object userData)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x2DC8A04", Offset = "0x2DC4A04", VA = "0x2DC8A04", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x2DC8A98", Offset = "0x2DC4A98", VA = "0x2DC8A98", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x2DC8B64", Offset = "0x2DC4B64", VA = "0x2DC8B64")]
	public ActivationControlPlayable()
	{
	}
}
[Serializable]
[Token(Token = "0x2000052")]
[Obsolete("For best performance use PlayableAsset and PlayableBehaviour.")]
public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour
{
	[Token(Token = "0x170000C7")]
	public virtual double duration
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2DC8B74", Offset = "0x2DC4B74", VA = "0x2DC8B74", Slot = "14")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x170000C8")]
	public virtual IEnumerable<PlayableBinding> outputs
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2DC8BCC", Offset = "0x2DC4BCC", VA = "0x2DC8BCC", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x2DC8C24", Offset = "0x2DC4C24", VA = "0x2DC8C24", Slot = "16")]
	public virtual void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x2DC8C28", Offset = "0x2DC4C28", VA = "0x2DC8C28", Slot = "17")]
	public virtual void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x2DC8C2C", Offset = "0x2DC4C2C", VA = "0x2DC8C2C", Slot = "18")]
	public virtual void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x2DC8C30", Offset = "0x2DC4C30", VA = "0x2DC8C30", Slot = "19")]
	public virtual void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x2DC8C34", Offset = "0x2DC4C34", VA = "0x2DC8C34", Slot = "20")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x2DC8C38", Offset = "0x2DC4C38", VA = "0x2DC8C38", Slot = "21")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x2DC8C3C", Offset = "0x2DC4C3C", VA = "0x2DC8C3C", Slot = "22")]
	public virtual void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x2DC8C40", Offset = "0x2DC4C40", VA = "0x2DC8C40", Slot = "23")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x2DC8C44", Offset = "0x2DC4C44", VA = "0x2DC8C44", Slot = "24")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x2DC8CE8", Offset = "0x2DC4CE8", VA = "0x2DC8CE8")]
	public BasicPlayableBehaviour()
	{
	}
}
[Token(Token = "0x2000053")]
public class DirectorControlPlayable : PlayableBehaviour
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public PlayableDirector director;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_SyncTime;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private double m_AssetDuration;

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x2DC3A34", Offset = "0x2DBFA34", VA = "0x2DC3A34")]
	public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director)
	{
		return default(ScriptPlayable<DirectorControlPlayable>);
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x2DC8CF0", Offset = "0x2DC4CF0", VA = "0x2DC8CF0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x2DC8DB0", Offset = "0x2DC4DB0", VA = "0x2DC8DB0", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x2DC9260", Offset = "0x2DC5260", VA = "0x2DC9260", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x2DC9334", Offset = "0x2DC5334", VA = "0x2DC9334", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x2DC9434", Offset = "0x2DC5434", VA = "0x2DC9434", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x2DC9078", Offset = "0x2DC5078", VA = "0x2DC9078")]
	private void SyncSpeed(double speed)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x2DC91A0", Offset = "0x2DC51A0", VA = "0x2DC91A0")]
	private void SyncStart(PlayableGraph graph, double time)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x2DC9924", Offset = "0x2DC5924", VA = "0x2DC9924")]
	private void SyncStop(PlayableGraph graph, double time)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x2DC8F64", Offset = "0x2DC4F64", VA = "0x2DC8F64")]
	private bool DetectDiscontinuity(Playable playable, FrameData info)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x2DC963C", Offset = "0x2DC563C", VA = "0x2DC963C")]
	private bool DetectOutOfSync(Playable playable)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x2DC978C", Offset = "0x2DC578C", VA = "0x2DC978C")]
	private void UpdateTime(Playable playable)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x2DC99F0", Offset = "0x2DC59F0", VA = "0x2DC99F0")]
	public DirectorControlPlayable()
	{
	}
}
[Token(Token = "0x2000054")]
public interface ITimeControl
{
	[Token(Token = "0x60002DA")]
	void SetTime(double time);

	[Token(Token = "0x60002DB")]
	void OnControlTimeStart();

	[Token(Token = "0x60002DC")]
	void OnControlTimeStop();
}
[Serializable]
[Token(Token = "0x2000055")]
[Flags]
public enum NotificationFlags : short
{
	[Token(Token = "0x4000142")]
	TriggerInEditMode = 1,
	[Token(Token = "0x4000143")]
	Retroactive = 2,
	[Token(Token = "0x4000144")]
	TriggerOnce = 4
}
[Token(Token = "0x2000056")]
public class ParticleControlPlayable : PlayableBehaviour
{
	[Token(Token = "0x4000145")]
	private const float kUnsetTime = float.MaxValue;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float m_LastPlayableTime;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float m_LastParticleTime;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private uint m_RandomSeed;

	[Token(Token = "0x170000C9")]
	public ParticleSystem particleSystem
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2DC9BC0", Offset = "0x2DC5BC0", VA = "0x2DC9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2DC9BC8", Offset = "0x2DC5BC8", VA = "0x2DC9BC8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x2DC9A00", Offset = "0x2DC5A00", VA = "0x2DC9A00")]
	public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed)
	{
		return default(ScriptPlayable<ParticleControlPlayable>);
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x2DC9B40", Offset = "0x2DC5B40", VA = "0x2DC9B40")]
	public void Initialize(ParticleSystem ps, uint randomSeed)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x2DC9BD0", Offset = "0x2DC5BD0", VA = "0x2DC9BD0")]
	private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x2DC9D08", Offset = "0x2DC5D08", VA = "0x2DC9D08", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData data)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x2DC9F80", Offset = "0x2DC5F80", VA = "0x2DC9F80", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x2DC9F8C", Offset = "0x2DC5F8C", VA = "0x2DC9F8C", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x2DC9EBC", Offset = "0x2DC5EBC", VA = "0x2DC9EBC")]
	private void Simulate(float time, bool restart)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x2DC9F98", Offset = "0x2DC5F98", VA = "0x2DC9F98")]
	public ParticleControlPlayable()
	{
	}
}
[Token(Token = "0x2000057")]
public class PrefabControlPlayable : PlayableBehaviour
{
	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GameObject m_Instance;

	[Token(Token = "0x170000CA")]
	public GameObject prefabInstance
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2DCA378", Offset = "0x2DC6378", VA = "0x2DCA378")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x2DC9FB4", Offset = "0x2DC5FB4", VA = "0x2DC9FB4")]
	public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform)
	{
		return default(ScriptPlayable<PrefabControlPlayable>);
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x2DCA0F4", Offset = "0x2DC60F4", VA = "0x2DCA0F4")]
	public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform)
	{
		return null;
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x2DCA6B8", Offset = "0x2DC66B8", VA = "0x2DCA6B8", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x2DCA794", Offset = "0x2DC6794", VA = "0x2DCA794", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x2DCA81C", Offset = "0x2DC681C", VA = "0x2DCA81C", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x2DCA380", Offset = "0x2DC6380", VA = "0x2DCA380")]
	private static void SetHideFlagsRecursive(GameObject gameObject)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x2DCA8C4", Offset = "0x2DC68C4", VA = "0x2DCA8C4")]
	public PrefabControlPlayable()
	{
	}
}
[Token(Token = "0x2000058")]
public class TimeControlPlayable : PlayableBehaviour
{
	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private ITimeControl m_timeControl;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_started;

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x2DCA8CC", Offset = "0x2DC68CC", VA = "0x2DCA8CC")]
	public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl)
	{
		return default(ScriptPlayable<TimeControlPlayable>);
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x2DCA9C4", Offset = "0x2DC69C4", VA = "0x2DCA9C4")]
	public void Initialize(ITimeControl timeControl)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x2DCA9CC", Offset = "0x2DC69CC", VA = "0x2DCA9CC", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x2DCAAC0", Offset = "0x2DC6AC0", VA = "0x2DCAAC0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x2DCAB74", Offset = "0x2DC6B74", VA = "0x2DCAB74", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x2DCAC24", Offset = "0x2DC6C24", VA = "0x2DCAC24")]
	public TimeControlPlayable()
	{
	}
}
[Token(Token = "0x2000059")]
public class TimeNotificationBehaviour : PlayableBehaviour
{
	[Token(Token = "0x200005A")]
	private struct NotificationEntry
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double time;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public INotification payload;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool notificationFired;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public NotificationFlags flags;

		[Token(Token = "0x170000CC")]
		public bool triggerInEditor
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x2DCB9A8", Offset = "0x2DC79A8", VA = "0x2DCB9A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		public bool prewarm
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x2DCB99C", Offset = "0x2DC799C", VA = "0x2DCB99C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		public bool triggerOnce
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x2DCB0EC", Offset = "0x2DC70EC", VA = "0x2DCB0EC")]
			get
			{
				return default(bool);
			}
		}
	}

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly List<NotificationEntry> m_Notifications;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private double m_PreviousTime;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_NeedSortNotifications;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Playable m_TimeSource;

	[Token(Token = "0x170000CB")]
	public Playable timeSource
	{
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2DCAC2C", Offset = "0x2DC6C2C", VA = "0x2DCAC2C")]
		set
		{
		}
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x2DCAC34", Offset = "0x2DC6C34", VA = "0x2DCAC34")]
	public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode)
	{
		return default(ScriptPlayable<TimeNotificationBehaviour>);
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x2DCAD50", Offset = "0x2DC6D50", VA = "0x2DCAD50")]
	public void AddNotification(double time, INotification payload, NotificationFlags flags = NotificationFlags.Retroactive)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x2DCAE40", Offset = "0x2DC6E40", VA = "0x2DCAE40", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x2DCB0F8", Offset = "0x2DC70F8", VA = "0x2DCB0F8", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x2DCB30C", Offset = "0x2DC730C", VA = "0x2DCB30C", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x2DCAFE0", Offset = "0x2DC6FE0", VA = "0x2DCAFE0")]
	private void SortNotifications()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x2DCB930", Offset = "0x2DC7930", VA = "0x2DCB930")]
	private static bool CanRestoreNotification(NotificationEntry e, FrameData info, double currentTime, double previousTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x2DCB76C", Offset = "0x2DC776C", VA = "0x2DCB76C")]
	private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x2DCB668", Offset = "0x2DC7668", VA = "0x2DCB668")]
	private void SyncDurationWithExternalSource(Playable playable)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x2DCB284", Offset = "0x2DC7284", VA = "0x2DCB284")]
	private static void Trigger_internal(Playable playable, PlayableOutput output, ref NotificationEntry e)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x2DCB994", Offset = "0x2DC7994", VA = "0x2DCB994")]
	private static void Restore_internal(ref NotificationEntry e)
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x2DCB9B4", Offset = "0x2DC79B4", VA = "0x2DCB9B4")]
	public TimeNotificationBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200005C")]
public class PlayableTrack : TrackAsset
{
	[Token(Token = "0x6000308")]
	[Address(RVA = "0x2DCBAA4", Offset = "0x2DC7AA4", VA = "0x2DCBAA4", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x2DCBB38", Offset = "0x2DC7B38", VA = "0x2DCBB38")]
	public PlayableTrack()
	{
	}
}
[Token(Token = "0x200005D")]
[Obsolete("TrackMediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
[AttributeUsage(AttributeTargets.Class)]
public class TrackMediaType : Attribute
{
	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly TimelineAsset.MediaType m_MediaType;

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x2DCBB90", Offset = "0x2DC7B90", VA = "0x2DCBB90")]
	public TrackMediaType(TimelineAsset.MediaType mt)
	{
	}
}
[Token(Token = "0x200005E")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class TrackClipTypeAttribute : Attribute
{
	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly Type inspectedType;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly bool allowAutoCreate;

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x2DCBBB8", Offset = "0x2DC7BB8", VA = "0x2DCBBB8")]
	public TrackClipTypeAttribute(Type clipClass)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x2DCBBE8", Offset = "0x2DC7BE8", VA = "0x2DCBBE8")]
	public TrackClipTypeAttribute(Type clipClass, bool allowAutoCreate)
	{
	}
}
[Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
public class NotKeyableAttribute : Attribute
{
	[Token(Token = "0x600030D")]
	[Address(RVA = "0x2DCBC10", Offset = "0x2DC7C10", VA = "0x2DCBC10")]
	public NotKeyableAttribute()
	{
	}
}
[Token(Token = "0x2000060")]
[Flags]
public enum TrackBindingFlags
{
	[Token(Token = "0x400015B")]
	None = 0,
	[Token(Token = "0x400015C")]
	AllowCreateComponent = 1,
	[Token(Token = "0x400015D")]
	All = 1
}
[Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.Class)]
public class TrackBindingTypeAttribute : Attribute
{
	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly Type type;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly TrackBindingFlags flags;

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x2DCBC18", Offset = "0x2DC7C18", VA = "0x2DCBC18")]
	public TrackBindingTypeAttribute(Type type)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x2DCBC48", Offset = "0x2DC7C48", VA = "0x2DCBC48")]
	public TrackBindingTypeAttribute(Type type, TrackBindingFlags flags)
	{
	}
}
[Token(Token = "0x2000062")]
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
internal class SupportsChildTracksAttribute : Attribute
{
	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly Type childType;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly int levels;

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x2DCBC78", Offset = "0x2DC7C78", VA = "0x2DCBC78")]
	public SupportsChildTracksAttribute([Optional] Type childType, int levels = int.MaxValue)
	{
	}
}
[Token(Token = "0x2000063")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
internal class IgnoreOnPlayableTrackAttribute : Attribute
{
	[Token(Token = "0x6000311")]
	[Address(RVA = "0x2DCBCA8", Offset = "0x2DC7CA8", VA = "0x2DCBCA8")]
	public IgnoreOnPlayableTrackAttribute()
	{
	}
}
[Token(Token = "0x2000064")]
internal class TimeFieldAttribute : PropertyAttribute
{
	[Token(Token = "0x2000065")]
	public enum UseEditMode
	{
		[Token(Token = "0x4000164")]
		None,
		[Token(Token = "0x4000165")]
		ApplyEditMode
	}

	[Token(Token = "0x170000CF")]
	public UseEditMode useEditMode
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2DCBCB0", Offset = "0x2DC7CB0", VA = "0x2DCBCB0")]
		[CompilerGenerated]
		get
		{
			return default(UseEditMode);
		}
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x2DCBCB8", Offset = "0x2DC7CB8", VA = "0x2DCBCB8")]
	public TimeFieldAttribute(UseEditMode useEditMode = UseEditMode.ApplyEditMode)
	{
	}
}
[Token(Token = "0x2000066")]
internal class FrameRateFieldAttribute : PropertyAttribute
{
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x2DCBCE0", Offset = "0x2DC7CE0", VA = "0x2DCBCE0")]
	public FrameRateFieldAttribute()
	{
	}
}
[Token(Token = "0x2000067")]
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class HideInMenuAttribute : Attribute
{
	[Token(Token = "0x6000315")]
	[Address(RVA = "0x2DCBCE8", Offset = "0x2DC7CE8", VA = "0x2DCBCE8")]
	public HideInMenuAttribute()
	{
	}
}
[Token(Token = "0x2000068")]
[AttributeUsage(AttributeTargets.Class)]
public class CustomStyleAttribute : Attribute
{
	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string ussStyle;

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x2DCBCF0", Offset = "0x2DC7CF0", VA = "0x2DCBCF0")]
	public CustomStyleAttribute(string ussStyle)
	{
	}
}
[Token(Token = "0x2000069")]
[AttributeUsage(AttributeTargets.Class)]
internal class MenuCategoryAttribute : Attribute
{
	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string category;

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x2DCBD18", Offset = "0x2DC7D18", VA = "0x2DCBD18")]
	public MenuCategoryAttribute(string category)
	{
	}
}
[Token(Token = "0x200006A")]
public interface ITimelineClipAsset
{
	[Token(Token = "0x170000D0")]
	ClipCaps clipCaps
	{
		[Token(Token = "0x6000318")]
		get;
	}
}
[Token(Token = "0x200006B")]
internal interface ITimelineEvaluateCallback
{
	[Token(Token = "0x6000319")]
	void Evaluate();
}
[Token(Token = "0x200006C")]
public class TimelinePlayable : PlayableBehaviour
{
	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private IntervalTree<RuntimeElement> m_IntervalTree;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<RuntimeElement> m_ActiveClips;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<RuntimeElement> m_CurrentListOfActiveClips;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int m_ActiveBit;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<ITimelineEvaluateCallback> m_EvaluateCallbacks;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<TrackAsset, Playable> m_PlayableCache;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static bool muteAudioScrubbing;

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x2DCBD84", Offset = "0x2DC7D84", VA = "0x2DCBD84")]
	public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
	{
		return default(ScriptPlayable<TimelinePlayable>);
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x2DCBF98", Offset = "0x2DC7F98", VA = "0x2DCBF98")]
	public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x2DCC228", Offset = "0x2DC8228", VA = "0x2DCC228")]
	private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x2DCC980", Offset = "0x2DC8980", VA = "0x2DCC980")]
	private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x2DCD004", Offset = "0x2DC9004", VA = "0x2DCD004")]
	private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x2DCD0EC", Offset = "0x2DC90EC", VA = "0x2DCD0EC")]
	private void EvaluateAnimationPreviewUpdateCallback(TrackAsset track, AnimationPlayableOutput animOutput)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x2DCC580", Offset = "0x2DC8580", VA = "0x2DCC580")]
	private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x2DCD244", Offset = "0x2DC9244", VA = "0x2DCD244", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x2DCD270", Offset = "0x2DC9270", VA = "0x2DCD270")]
	private void Evaluate(Playable playable, FrameData frameData)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x2DCD1D4", Offset = "0x2DC91D4", VA = "0x2DCD1D4")]
	private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x2DCD7F0", Offset = "0x2DC97F0", VA = "0x2DCD7F0")]
	private static void ForAOTCompilationOnly()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x2DCD84C", Offset = "0x2DC984C", VA = "0x2DCD84C")]
	public TimelinePlayable()
	{
	}
}
[Token(Token = "0x200006D")]
internal static class Extrapolation
{
	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly double kMinExtrapolationTime;

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x2DCD9EC", Offset = "0x2DC99EC", VA = "0x2DCD9EC")]
	internal static void CalculateExtrapolationTimes(this TrackAsset asset)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x2DCDDE8", Offset = "0x2DC9DE8", VA = "0x2DCDDE8")]
	private static TimelineClip[] SortClipsByStartTime(TimelineClip[] clips)
	{
		return null;
	}
}
[Token(Token = "0x200006F")]
internal static class HashUtility
{
	[Token(Token = "0x600032D")]
	[Address(RVA = "0x2DCE038", Offset = "0x2DCA038", VA = "0x2DCE038")]
	public static int CombineHash(this int h1, int h2)
	{
		return default(int);
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x2DCE054", Offset = "0x2DCA054", VA = "0x2DCE054")]
	public static int CombineHash(int h1, int h2, int h3)
	{
		return default(int);
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x2DCE080", Offset = "0x2DCA080", VA = "0x2DCE080")]
	public static int CombineHash(int h1, int h2, int h3, int h4)
	{
		return default(int);
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x2DCE0BC", Offset = "0x2DCA0BC", VA = "0x2DCE0BC")]
	public static int CombineHash(int h1, int h2, int h3, int h4, int h5)
	{
		return default(int);
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x2DCE108", Offset = "0x2DCA108", VA = "0x2DCE108")]
	public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6)
	{
		return default(int);
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x2DCE164", Offset = "0x2DCA164", VA = "0x2DCE164")]
	public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
	{
		return default(int);
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x2DCE190", Offset = "0x2DCA190", VA = "0x2DCE190")]
	public static int CombineHash(int[] hashes)
	{
		return default(int);
	}
}
[Token(Token = "0x2000070")]
public interface IPropertyCollector
{
	[Token(Token = "0x6000334")]
	void PushActiveGameObject(GameObject gameObject);

	[Token(Token = "0x6000335")]
	void PopActiveGameObject();

	[Token(Token = "0x6000336")]
	void AddFromClip(AnimationClip clip);

	[Token(Token = "0x6000337")]
	void AddFromClips(IEnumerable<AnimationClip> clips);

	[Token(Token = "0x6000338")]
	void AddFromName<T>(string name) where T : Component;

	[Token(Token = "0x6000339")]
	void AddFromName(string name);

	[Token(Token = "0x600033A")]
	void AddFromClip(GameObject obj, AnimationClip clip);

	[Token(Token = "0x600033B")]
	void AddFromClips(GameObject obj, IEnumerable<AnimationClip> clips);

	[Token(Token = "0x600033C")]
	void AddFromName<T>(GameObject obj, string name) where T : Component;

	[Token(Token = "0x600033D")]
	void AddFromName(GameObject obj, string name);

	[Token(Token = "0x600033E")]
	void AddFromName(Component component, string name);

	[Token(Token = "0x600033F")]
	void AddFromComponent(GameObject obj, Component component);

	[Token(Token = "0x6000340")]
	void AddObjectProperties(Object obj, AnimationClip clip);
}
[Token(Token = "0x2000071")]
public interface IPropertyPreview
{
	[Token(Token = "0x6000341")]
	void GatherProperties(PlayableDirector director, IPropertyCollector driver);
}
[Token(Token = "0x2000072")]
internal static class NotificationUtilities
{
	[Token(Token = "0x6000342")]
	[Address(RVA = "0x2DCE1FC", Offset = "0x2DCA1FC", VA = "0x2DCE1FC")]
	public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, PlayableDirector director)
	{
		return default(ScriptPlayable<TimeNotificationBehaviour>);
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x2DCEA30", Offset = "0x2DCAA30", VA = "0x2DCEA30")]
	public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, TimelineAsset timelineAsset)
	{
		return default(ScriptPlayable<TimeNotificationBehaviour>);
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x2DCE208", Offset = "0x2DCA208", VA = "0x2DCE208")]
	private static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, IPlayableAsset asset, PlayableDirector director)
	{
		return default(ScriptPlayable<TimeNotificationBehaviour>);
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x2DCEA38", Offset = "0x2DCAA38", VA = "0x2DCEA38")]
	public static bool TrackTypeSupportsNotifications(Type type)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000073")]
public static class TimelineClipExtensions
{
	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string k_UndoSetParentTrackText;

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x2DCEBC4", Offset = "0x2DCABC4", VA = "0x2DCEBC4")]
	public static void MoveToTrack(this TimelineClip clip, TrackAsset destinationTrack)
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x2DCF008", Offset = "0x2DCB008", VA = "0x2DCF008")]
	public static bool TryMoveToTrack(this TimelineClip clip, TrackAsset destinationTrack)
	{
		return default(bool);
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x2DCEEE8", Offset = "0x2DCAEE8", VA = "0x2DCEEE8")]
	private static void MoveToTrack_Impl(TimelineClip clip, TrackAsset destinationTrack, Object asset, TrackAsset parentTrack)
	{
	}
}
[Token(Token = "0x2000074")]
internal static class TimelineCreateUtilities
{
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x2DCF394", Offset = "0x2DCB394", VA = "0x2DCF394")]
	public static string GenerateUniqueActorName(List<ScriptableObject> tracks, string name)
	{
		return null;
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x2DCF1A4", Offset = "0x2DCB1A4", VA = "0x2DCF1A4")]
	public static void SaveAssetIntoObject(Object childAsset, Object masterAsset)
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x2DCF298", Offset = "0x2DCB298", VA = "0x2DCF298")]
	public static void RemoveAssetFromObject(Object childAsset, Object masterAsset)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x2DCF688", Offset = "0x2DCB688", VA = "0x2DCF688")]
	public static AnimationClip CreateAnimationClipForTrack(string name, TrackAsset track, bool isLegacy)
	{
		return null;
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x2DCF840", Offset = "0x2DCB840", VA = "0x2DCF840")]
	public static bool ValidateParentTrack(TrackAsset parent, Type childType)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000077")]
internal static class TimelineUndo
{
	[Token(Token = "0x170000D1")]
	internal static bool undoEnabled
	{
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x2DCFBC0", Offset = "0x2DCBBC0", VA = "0x2DCFBC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x2DCFBC8", Offset = "0x2DCBBC8", VA = "0x2DCFBC8")]
	public static void PushDestroyUndo(TimelineAsset timeline, Object thingToDirty, Object objectToDestroy)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x2DCFC50", Offset = "0x2DCBC50", VA = "0x2DCFC50")]
	[Conditional("UNITY_EDITOR")]
	public static void PushUndo(Object[] thingsToDirty, string operation)
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x2DCFC54", Offset = "0x2DCBC54", VA = "0x2DCFC54")]
	[Conditional("UNITY_EDITOR")]
	public static void PushUndo(Object thingToDirty, string operation)
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x2DCFC58", Offset = "0x2DCBC58", VA = "0x2DCFC58")]
	[Conditional("UNITY_EDITOR")]
	public static void RegisterCreatedObjectUndo(Object thingCreated, string operation)
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x2DCFC5C", Offset = "0x2DCBC5C", VA = "0x2DCFC5C")]
	internal static string UndoName(string name)
	{
		return null;
	}
}
[Token(Token = "0x2000078")]
public enum StandardFrameRates
{
	[Token(Token = "0x4000176")]
	Fps24,
	[Token(Token = "0x4000177")]
	Fps23_97,
	[Token(Token = "0x4000178")]
	Fps25,
	[Token(Token = "0x4000179")]
	Fps30,
	[Token(Token = "0x400017A")]
	Fps29_97,
	[Token(Token = "0x400017B")]
	Fps50,
	[Token(Token = "0x400017C")]
	Fps60,
	[Token(Token = "0x400017D")]
	Fps59_94
}
[Token(Token = "0x2000079")]
internal static class TimeUtility
{
	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly double kTimeEpsilon;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly double kFrameRateEpsilon;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly double k_MaxTimelineDurationInSeconds;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly double kFrameRateRounding;

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x2DCFCA8", Offset = "0x2DCBCA8", VA = "0x2DCFCA8")]
	private static void ValidateFrameRate(double frameRate)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x2DCFD5C", Offset = "0x2DCBD5C", VA = "0x2DCFD5C")]
	public static int ToFrames(double time, double frameRate)
	{
		return default(int);
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x2DCFF28", Offset = "0x2DCBF28", VA = "0x2DCFF28")]
	public static double ToExactFrames(double time, double frameRate)
	{
		return default(double);
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x2DCFF90", Offset = "0x2DCBF90", VA = "0x2DCFF90")]
	public static double FromFrames(int frames, double frameRate)
	{
		return default(double);
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x2DCFFFC", Offset = "0x2DCBFFC", VA = "0x2DCFFFC")]
	public static double FromFrames(double frames, double frameRate)
	{
		return default(double);
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x2DD0064", Offset = "0x2DCC064", VA = "0x2DD0064")]
	public static bool OnFrameBoundary(double time, double frameRate)
	{
		return default(bool);
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x2DCFE80", Offset = "0x2DCBE80", VA = "0x2DCFE80")]
	public static double GetEpsilon(double time, double frameRate)
	{
		return default(double);
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x2DD01F8", Offset = "0x2DCC1F8", VA = "0x2DD01F8")]
	public static int PreviousFrame(double time, double frameRate)
	{
		return default(int);
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x2DD0298", Offset = "0x2DCC298", VA = "0x2DD0298")]
	public static int NextFrame(double time, double frameRate)
	{
		return default(int);
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x2DD0304", Offset = "0x2DCC304", VA = "0x2DD0304")]
	public static double PreviousFrameTime(double time, double frameRate)
	{
		return default(double);
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x2DD0370", Offset = "0x2DCC370", VA = "0x2DD0370")]
	public static double NextFrameTime(double time, double frameRate)
	{
		return default(double);
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x2DD00D8", Offset = "0x2DCC0D8", VA = "0x2DD00D8")]
	public static bool OnFrameBoundary(double time, double frameRate, double epsilon)
	{
		return default(bool);
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x2DD03DC", Offset = "0x2DCC3DC", VA = "0x2DD03DC")]
	public static double RoundToFrame(double time, double frameRate)
	{
		return default(double);
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x2DD04B8", Offset = "0x2DCC4B8", VA = "0x2DD04B8")]
	public static string TimeAsFrames(double timeValue, double frameRate, string format = "F2")
	{
		return null;
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x2DD058C", Offset = "0x2DCC58C", VA = "0x2DD058C")]
	public static string TimeAsTimeCode(double timeValue, double frameRate, string format = "F2")
	{
		return null;
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x2DD09A0", Offset = "0x2DCC9A0", VA = "0x2DD09A0")]
	public static double ParseTimeCode(string timeCode, double frameRate, double defaultValue)
	{
		return default(double);
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x2DD0F48", Offset = "0x2DCCF48", VA = "0x2DD0F48")]
	public static double ParseTimeSeconds(string timeCode, double frameRate, double defaultValue)
	{
		return default(double);
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x2DD12AC", Offset = "0x2DCD2AC", VA = "0x2DD12AC")]
	public static double GetAnimationClipLength(AnimationClip clip)
	{
		return default(double);
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x2DD0E78", Offset = "0x2DCCE78", VA = "0x2DD0E78")]
	private static string RemoveChar(string str, Func<char, bool> charToRemoveFunc)
	{
		return null;
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x2DD1410", Offset = "0x2DCD410", VA = "0x2DD1410")]
	public static UnityEngine.Playables.FrameRate GetClosestFrameRate(double frameRate)
	{
		return default(UnityEngine.Playables.FrameRate);
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x2DD14FC", Offset = "0x2DCD4FC", VA = "0x2DD14FC")]
	public static UnityEngine.Playables.FrameRate ToFrameRate(StandardFrameRates enumValue)
	{
		return default(UnityEngine.Playables.FrameRate);
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x2DD16C8", Offset = "0x2DCD6C8", VA = "0x2DD16C8")]
	internal static bool ToStandardFrameRate(UnityEngine.Playables.FrameRate rate, out StandardFrameRates standard)
	{
		return default(bool);
	}
}
[Token(Token = "0x200007B")]
internal static class WeightUtility
{
	[Token(Token = "0x6000375")]
	[Address(RVA = "0x2DD1AF0", Offset = "0x2DCDAF0", VA = "0x2DD1AF0")]
	public static float NormalizeMixer(Playable mixer)
	{
		return default(float);
	}
}
