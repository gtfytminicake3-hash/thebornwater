using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.Playables;

[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/Director/PlayableDirector.h")]
public class PlayableDirector : Behaviour, IExposedPropertyTable
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<PlayableDirector> played;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<PlayableDirector> paused;

	[Token(Token = "0x17000001")]
	public PlayState state
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2E50DD0", Offset = "0x2E4CDD0", VA = "0x2E50DD0")]
		get
		{
			return default(PlayState);
		}
	}

	[Token(Token = "0x17000002")]
	public DirectorWrapMode extrapolationMode
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2E50E48", Offset = "0x2E4CE48", VA = "0x2E50E48")]
		get
		{
			return default(DirectorWrapMode);
		}
	}

	[Token(Token = "0x17000003")]
	public PlayableAsset playableAsset
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2E50EC0", Offset = "0x2E4CEC0", VA = "0x2E50EC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public PlayableGraph playableGraph
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2E50F9C", Offset = "0x2E4CF9C", VA = "0x2E50F9C")]
		get
		{
			return default(PlayableGraph);
		}
	}

	[Token(Token = "0x17000005")]
	public extern double time
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2E510D0", Offset = "0x2E4D0D0", VA = "0x2E510D0")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2E51084", Offset = "0x2E4D084", VA = "0x2E51084")]
		set;
	}

	[Token(Token = "0x14000001")]
	public event Action<PlayableDirector> stopped
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2E51374", Offset = "0x2E4D374", VA = "0x2E51374")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2E51424", Offset = "0x2E4D424", VA = "0x2E51424")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2E50FF4", Offset = "0x2E4CFF4", VA = "0x2E50FF4")]
	internal void Play(UnityEngine.Playables.FrameRate frameRate)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2E5110C", Offset = "0x2E4D10C", VA = "0x2E5110C")]
	[UnityEngine.Bindings.NativeThrows]
	public extern void Evaluate();

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2E5103C", Offset = "0x2E4D03C", VA = "0x2E5103C")]
	[UnityEngine.Bindings.NativeThrows]
	private void PlayOnFrame(UnityEngine.Playables.FrameRate frameRate)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2E5118C", Offset = "0x2E4D18C", VA = "0x2E5118C")]
	[UnityEngine.Bindings.NativeThrows]
	public extern void Play();

	[MethodImpl(4096)]
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2E511C8", Offset = "0x2E4D1C8", VA = "0x2E511C8")]
	public extern void Stop();

	[MethodImpl(4096)]
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2E51204", Offset = "0x2E4D204", VA = "0x2E51204")]
	public extern void Pause();

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2E51240", Offset = "0x2E4D240", VA = "0x2E51240", Slot = "4")]
	public Object GetReferenceValue(PropertyName id, out bool idValid)
	{
		return null;
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2E512EC", Offset = "0x2E4D2EC", VA = "0x2E512EC")]
	[UnityEngine.Bindings.NativeMethod("GetBindingFor")]
	public extern Object GetGenericBinding(Object key);

	[MethodImpl(4096)]
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2E50E0C", Offset = "0x2E4CE0C", VA = "0x2E50E0C")]
	private extern PlayState GetPlayState();

	[MethodImpl(4096)]
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2E50E84", Offset = "0x2E4CE84", VA = "0x2E50E84")]
	private extern DirectorWrapMode GetWrapMode();

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2E50FA0", Offset = "0x2E4CFA0", VA = "0x2E50FA0")]
	private PlayableGraph GetGraphHandle()
	{
		return default(PlayableGraph);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2E50F60", Offset = "0x2E4CF60", VA = "0x2E50F60")]
	private extern ScriptableObject Internal_GetPlayableAsset();

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2E514D4", Offset = "0x2E4D4D4", VA = "0x2E514D4")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private void SendOnPlayableDirectorPlay()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2E514F4", Offset = "0x2E4D4F4", VA = "0x2E514F4")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private void SendOnPlayableDirectorPause()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2E51514", Offset = "0x2E4D514", VA = "0x2E51514")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private void SendOnPlayableDirectorStop()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2E51534", Offset = "0x2E4D534", VA = "0x2E51534")]
	public PlayableDirector()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2E51148", Offset = "0x2E4D148", VA = "0x2E51148")]
	private extern void PlayOnFrame_Injected(ref UnityEngine.Playables.FrameRate frameRate);

	[MethodImpl(4096)]
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2E51298", Offset = "0x2E4D298", VA = "0x2E51298", Slot = "5")]
	private extern Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid);

	[MethodImpl(4096)]
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2E51330", Offset = "0x2E4D330", VA = "0x2E51330")]
	private extern void GetGraphHandle_Injected(out PlayableGraph ret);
}
