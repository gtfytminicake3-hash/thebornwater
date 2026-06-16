using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Playables;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine
{
	[Token(Token = "0x2000002")]
	public enum FFTWindow
	{
		[Token(Token = "0x4000002")]
		Rectangular,
		[Token(Token = "0x4000003")]
		Triangle,
		[Token(Token = "0x4000004")]
		Hamming,
		[Token(Token = "0x4000005")]
		Hanning,
		[Token(Token = "0x4000006")]
		Blackman,
		[Token(Token = "0x4000007")]
		BlackmanHarris
	}
	[Token(Token = "0x2000003")]
	[UnityEngine.Bindings.StaticAccessor("GetAudioManager()", UnityEngine.Bindings.StaticAccessorType.Dot)]
	[UnityEngine.Bindings.NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	public sealed class AudioSettings
	{
		[Token(Token = "0x2000004")]
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);

		[Token(Token = "0x2000005")]
		public static class Mobile
		{
			[Token(Token = "0x400000C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			private static bool _stopAudioOutputOnMute;

			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private static Action<bool> OnMuteStateChanged;

			[Token(Token = "0x17000001")]
			public static bool muteState
			{
				[Token(Token = "0x6000008")]
				[Address(RVA = "0x2DE8DD0", Offset = "0x2DE4DD0", VA = "0x2DE8DD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000009")]
				[Address(RVA = "0x2DE8E18", Offset = "0x2DE4E18", VA = "0x2DE8E18")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000002")]
			public static bool stopAudioOutputOnMute
			{
				[Token(Token = "0x600000A")]
				[Address(RVA = "0x2DE8E68", Offset = "0x2DE4E68", VA = "0x2DE8E68")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2DE8EB0", Offset = "0x2DE4EB0", VA = "0x2DE8EB0")]
			[UnityEngine.Scripting.RequiredByNativeCode]
			internal static void InvokeOnMuteStateChanged(bool mute)
			{
			}

			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2DE9070", Offset = "0x2DE5070", VA = "0x2DE9070")]
			[UnityEngine.Scripting.RequiredByNativeCode]
			internal static bool InvokeIsStopAudioOutputOnMuteEnabled()
			{
				return default(bool);
			}

			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2DE9048", Offset = "0x2DE5048", VA = "0x2DE9048")]
			public static void StartAudioOutput()
			{
			}

			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2DE9020", Offset = "0x2DE5020", VA = "0x2DE9020")]
			public static void StopAudioOutput()
			{
			}
		}

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static AudioConfigurationChangeHandler OnAudioConfigurationChanged;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnAudioSystemShuttingDown;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnAudioSystemStartedUp;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2DE8BAC", Offset = "0x2DE4BAC", VA = "0x2DE8BAC")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2DE8C18", Offset = "0x2DE4C18", VA = "0x2DE8C18")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void InvokeOnAudioSystemShuttingDown()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2DE8C7C", Offset = "0x2DE4C7C", VA = "0x2DE8C7C")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static void InvokeOnAudioSystemStartedUp()
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2DE8CE0", Offset = "0x2DE4CE0", VA = "0x2DE8CE0")]
		internal static extern bool StartAudioOutput();

		[MethodImpl(4096)]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2DE8D08", Offset = "0x2DE4D08", VA = "0x2DE8D08")]
		internal static extern bool StopAudioOutput();
	}
	[Token(Token = "0x2000006")]
	[UnityEngine.Bindings.NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[UnityEngine.Bindings.StaticAccessor("AudioClipBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	public sealed class AudioClip : Object
	{
		[Token(Token = "0x2000007")]
		public delegate void PCMReaderCallback(float[] data);

		[Token(Token = "0x2000008")]
		public delegate void PCMSetPositionCallback(int position);

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private PCMReaderCallback m_PCMReaderCallback;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PCMSetPositionCallback m_PCMSetPositionCallback;

		[Token(Token = "0x17000003")]
		[UnityEngine.Bindings.NativeProperty("LengthSec")]
		public extern float length
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2DE9114", Offset = "0x2DE5114", VA = "0x2DE9114")]
			get;
		}

		[Token(Token = "0x17000004")]
		[UnityEngine.Bindings.NativeProperty("SampleCount")]
		public extern int samples
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2DE9150", Offset = "0x2DE5150", VA = "0x2DE9150")]
			get;
		}

		[Token(Token = "0x17000005")]
		public extern int frequency
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2DE918C", Offset = "0x2DE518C", VA = "0x2DE918C")]
			get;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2DE90B8", Offset = "0x2DE50B8", VA = "0x2DE90B8")]
		private AudioClip()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2DE91C8", Offset = "0x2DE51C8", VA = "0x2DE91C8")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		private void InvokePCMReaderCallback_Internal(float[] data)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2DE91E4", Offset = "0x2DE51E4", VA = "0x2DE91E4")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		private void InvokePCMSetPositionCallback_Internal(int position)
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class AudioBehaviour : Behaviour
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2DE9350", Offset = "0x2DE5350", VA = "0x2DE9350")]
		public AudioBehaviour()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[UnityEngine.Bindings.StaticAccessor("AudioListenerBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[RequireComponent(typeof(Transform))]
	public sealed class AudioListener : AudioBehaviour
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2DE9358", Offset = "0x2DE5358", VA = "0x2DE9358")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void GetOutputDataHelper([Out] float[] samples, int channel);

		[MethodImpl(4096)]
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2DE939C", Offset = "0x2DE539C", VA = "0x2DE939C")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void GetSpectrumDataHelper([Out] float[] samples, int channel, FFTWindow window);

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2DE93F0", Offset = "0x2DE53F0", VA = "0x2DE93F0")]
		public static void GetOutputData(float[] samples, int channel)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2DE9434", Offset = "0x2DE5434", VA = "0x2DE9434")]
		public static void GetSpectrumData(float[] samples, int channel, FFTWindow window)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2DE9488", Offset = "0x2DE5488", VA = "0x2DE9488")]
		public AudioListener()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[UnityEngine.Bindings.StaticAccessor("AudioSourceBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[RequireComponent(typeof(Transform))]
	public sealed class AudioSource : AudioBehaviour
	{
		[Token(Token = "0x17000006")]
		public extern float volume
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2DE955C", Offset = "0x2DE555C", VA = "0x2DE955C")]
			get;
			[MethodImpl(4096)]
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2DE9598", Offset = "0x2DE5598", VA = "0x2DE9598")]
			set;
		}

		[Token(Token = "0x17000007")]
		public float pitch
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2DE95E4", Offset = "0x2DE55E4", VA = "0x2DE95E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2DE9620", Offset = "0x2DE5620", VA = "0x2DE9620")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		[UnityEngine.Bindings.NativeProperty("AudioClip")]
		public extern AudioClip clip
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2DE966C", Offset = "0x2DE566C", VA = "0x2DE966C")]
			set;
		}

		[Token(Token = "0x17000009")]
		public extern bool isPlaying
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2DE972C", Offset = "0x2DE572C", VA = "0x2DE972C")]
			[UnityEngine.Bindings.NativeName("IsPlayingScripting")]
			get;
		}

		[Token(Token = "0x1700000A")]
		[UnityEngine.Bindings.NativeProperty("SpatialBlendMix")]
		public extern float spatialBlend
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2DE9768", Offset = "0x2DE5768", VA = "0x2DE9768")]
			set;
		}

		[Token(Token = "0x1700000B")]
		public extern float minDistance
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2DE97B4", Offset = "0x2DE57B4", VA = "0x2DE97B4")]
			set;
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2DE9490", Offset = "0x2DE5490", VA = "0x2DE9490")]
		private static extern float GetPitch([UnityEngine.Bindings.NotNull("ArgumentNullException")] AudioSource source);

		[MethodImpl(4096)]
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2DE94CC", Offset = "0x2DE54CC", VA = "0x2DE94CC")]
		private static extern void SetPitch([UnityEngine.Bindings.NotNull("ArgumentNullException")] AudioSource source, float pitch);

		[MethodImpl(4096)]
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2DE9518", Offset = "0x2DE5518", VA = "0x2DE9518")]
		private static extern void PlayHelper([UnityEngine.Bindings.NotNull("ArgumentNullException")] AudioSource source, ulong delay);

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2DE96B0", Offset = "0x2DE56B0", VA = "0x2DE96B0")]
		[ExcludeFromDocs]
		public void Play()
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2DE96F0", Offset = "0x2DE56F0", VA = "0x2DE96F0")]
		public extern void Pause();

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2DE9800", Offset = "0x2DE5800", VA = "0x2DE9800")]
		public AudioSource()
		{
		}
	}
}
namespace UnityEngine.Experimental.Audio
{
	[Token(Token = "0x200000C")]
	[UnityEngine.Bindings.StaticAccessor("AudioSampleProviderBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
	public class AudioSampleProvider
	{
		[Token(Token = "0x200000D")]
		public delegate void SampleFramesHandler(AudioSampleProvider provider, uint sampleFrameCount);

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SampleFramesHandler sampleFramesAvailable;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SampleFramesHandler sampleFramesOverflow;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2DE9808", Offset = "0x2DE5808", VA = "0x2DE9808")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		private void InvokeSampleFramesAvailable(int sampleFrameCount)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2DE9830", Offset = "0x2DE5830", VA = "0x2DE9830")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		private void InvokeSampleFramesOverflow(int droppedSampleFrameCount)
		{
		}
	}
}
namespace UnityEngine.Audio
{
	[Token(Token = "0x200000E")]
	[UnityEngine.Bindings.NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[UnityEngine.Bindings.StaticAccessor("AudioClipPlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
	public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable>
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2DE9970", Offset = "0x2DE5970", VA = "0x2DE9970")]
		public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping)
		{
			return default(AudioClipPlayable);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2DE9A94", Offset = "0x2DE5A94", VA = "0x2DE9A94")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping)
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2DE9B60", Offset = "0x2DE5B60", VA = "0x2DE9B60")]
		internal AudioClipPlayable(PlayableHandle handle)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2DE9CAC", Offset = "0x2DE5CAC", VA = "0x2DE9CAC", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2DE9CB8", Offset = "0x2DE5CB8", VA = "0x2DE9CB8")]
		public static implicit operator Playable(AudioClipPlayable playable)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2DE9CE8", Offset = "0x2DE5CE8", VA = "0x2DE9CE8")]
		public static explicit operator AudioClipPlayable(Playable playable)
		{
			return default(AudioClipPlayable);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2DE9D6C", Offset = "0x2DE5D6C", VA = "0x2DE9D6C", Slot = "5")]
		public bool Equals(AudioClipPlayable other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2DE9DE4", Offset = "0x2DE5DE4", VA = "0x2DE9DE4")]
		internal void SetVolume(float value)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2DE9F00", Offset = "0x2DE5F00", VA = "0x2DE9F00")]
		internal void SetStereoPan(float value)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2DEA018", Offset = "0x2DE6018", VA = "0x2DEA018")]
		internal void SetSpatialBlend(float value)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2DEA134", Offset = "0x2DE6134", VA = "0x2DEA134")]
		public void Seek(double startTime, double startDelay, [System.ComponentModel.DefaultValue("0")] double duration)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2DE9EB4", Offset = "0x2DE5EB4", VA = "0x2DE9EB4")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetVolumeInternal(ref PlayableHandle hdl, float volume);

		[MethodImpl(4096)]
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2DE9FCC", Offset = "0x2DE5FCC", VA = "0x2DE9FCC")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan);

		[MethodImpl(4096)]
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2DEA0E8", Offset = "0x2DE60E8", VA = "0x2DEA0E8")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend);

		[MethodImpl(4096)]
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2DEA2E0", Offset = "0x2DE62E0", VA = "0x2DEA2E0")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetStartDelayInternal(ref PlayableHandle hdl, double delay);

		[MethodImpl(4096)]
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2DEA32C", Offset = "0x2DE632C", VA = "0x2DEA32C")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void SetPauseDelayInternal(ref PlayableHandle hdl, double delay);

		[MethodImpl(4096)]
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2DE9C50", Offset = "0x2DE5C50", VA = "0x2DE9C50")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle);
	}
	[Token(Token = "0x200000F")]
	[UnityEngine.Bindings.NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	[UnityEngine.Bindings.StaticAccessor("AudioMixerPlayableBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable>
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2DEA378", Offset = "0x2DE6378", VA = "0x2DEA378")]
		public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0, bool normalizeInputVolumes = false)
		{
			return default(AudioMixerPlayable);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2DEA3B0", Offset = "0x2DE63B0", VA = "0x2DEA3B0")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes)
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2DEA494", Offset = "0x2DE6494", VA = "0x2DEA494")]
		internal AudioMixerPlayable(PlayableHandle handle)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2DEA5D8", Offset = "0x2DE65D8", VA = "0x2DEA5D8", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2DEA5E4", Offset = "0x2DE65E4", VA = "0x2DEA5E4")]
		public static implicit operator Playable(AudioMixerPlayable playable)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2DEA614", Offset = "0x2DE6614", VA = "0x2DEA614", Slot = "5")]
		public bool Equals(AudioMixerPlayable other)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2DEA584", Offset = "0x2DE6584", VA = "0x2DEA584")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle);
	}
	[Token(Token = "0x2000010")]
	public static class AudioPlayableBinding
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2DEA68C", Offset = "0x2DE668C", VA = "0x2DEA68C")]
		public static PlayableBinding Create(string name, Object key)
		{
			return default(PlayableBinding);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2DEA7BC", Offset = "0x2DE67BC", VA = "0x2DEA7BC")]
		private static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name)
		{
			return default(PlayableOutput);
		}
	}
	[Token(Token = "0x2000011")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[UnityEngine.Bindings.StaticAccessor("AudioPlayableGraphExtensionsBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableGraphExtensions.bindings.h")]
	internal static class AudioPlayableGraphExtensions
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2DEA8D4", Offset = "0x2DE68D4", VA = "0x2DEA8D4")]
		[UnityEngine.Bindings.NativeThrows]
		internal static extern bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle);
	}
	[Token(Token = "0x2000012")]
	[UnityEngine.Bindings.NativeHeader("Modules/Audio/Public/AudioSource.h")]
	[UnityEngine.Bindings.NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
	[UnityEngine.Bindings.StaticAccessor("AudioPlayableOutputBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	[UnityEngine.Bindings.NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public struct AudioPlayableOutput : IPlayableOutput
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;

		[Token(Token = "0x1700000C")]
		public static AudioPlayableOutput Null
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2DEA928", Offset = "0x2DE6928", VA = "0x2DEA928")]
			get
			{
				return default(AudioPlayableOutput);
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2DEA7FC", Offset = "0x2DE67FC", VA = "0x2DEA7FC")]
		public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target)
		{
			return default(AudioPlayableOutput);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2DEA9A4", Offset = "0x2DE69A4", VA = "0x2DEA9A4")]
		internal AudioPlayableOutput(PlayableOutputHandle handle)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2DEAAD8", Offset = "0x2DE6AD8", VA = "0x2DEAAD8", Slot = "4")]
		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2DEA8A4", Offset = "0x2DE68A4", VA = "0x2DEA8A4")]
		public static implicit operator PlayableOutput(AudioPlayableOutput output)
		{
			return default(PlayableOutput);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2DEAAE4", Offset = "0x2DE6AE4", VA = "0x2DEAAE4")]
		public static explicit operator AudioPlayableOutput(PlayableOutput output)
		{
			return default(AudioPlayableOutput);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2DEAA94", Offset = "0x2DE6A94", VA = "0x2DEAA94")]
		public void SetTarget(AudioSource value)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2DEABAC", Offset = "0x2DE6BAC", VA = "0x2DEABAC")]
		public void SetEvaluateOnSeek(bool value)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2DEAB68", Offset = "0x2DE6B68", VA = "0x2DEAB68")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target);

		[MethodImpl(4096)]
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2DEABF0", Offset = "0x2DE6BF0", VA = "0x2DEABF0")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value);
	}
}
